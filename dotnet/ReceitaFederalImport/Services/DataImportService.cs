using ReceitaFederalImport.Data;
using ReceitaFederalImport.Models;
using System.IO.Compression;

namespace ReceitaFederalImport.Services
{
    public class DataImportService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<DataImportService> _logger;
        private readonly string url = "https://arquivos.receitafederal.gov.br/dados/cnpj/dados_abertos_cnpj/2023-05/soocios0.zip";

        public DataImportService(ApplicationDbContext context, ILogger<DataImportService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task ImportDataAsync()
        {
            var tempDir = Path.Combine(Path.GetTempPath(), "rfb_import");
            Directory.CreateDirectory(tempDir);

            string zipPath = Path.Combine(tempDir, "soocios0.zip");

            using (var client = new HttpClient())
            {
                var data = await client.GetByteArrayAsync(url);
                await File.WriteAllBytesAsync(zipPath, data);
            }

            ZipFile.ExtractToDirectory(zipPath, tempDir, true);
            var txtFile = Directory.GetFiles(tempDir, "*.txt").FirstOrDefault();
            if (txtFile == null) throw new FileNotFoundException("Arquivo TXT não encontrado após extração.");

            using var reader = new StreamReader(txtFile);
            int count = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var fields = line.Split(';').Select(f => f.Trim('"')).ToArray();

                if (fields.Length < 11) continue;

                var socio = new Socio
                {
                    CnpjBasico = fields[0],
                    IdentificadorSocio = fields[1],
                    NomeSocio = fields[2],
                    CnpjCpfSocio = fields[3],
                    QualificacaoSocio = fields[4],
                    DataEntradaSociedade = DateTime.TryParseExact(fields[5], "yyyyMMdd", null, System.Globalization.DateTimeStyles.None, out var dataEntrada)
                        ? dataEntrada
                        : null,

                    Pais = fields[6],
                    CpfRepresentanteLegal = fields[7],
                    NomeRepresentante = fields[8],
                    QualificacaoRepresentante = fields[9],
                    FaixaEtaria = fields[10]
                };

                _context.Socios.Add(socio);

                count++;
                if (count % 1000 == 0)
                {
                    await _context.SaveChangesAsync();
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
