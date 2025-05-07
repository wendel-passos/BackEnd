using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading.Tasks;

namespace _06ExemploProjetoAPI.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class ArquivosController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ArquivosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadArquivo(IFormFile arquivo)
        {
            if (arquivo == null || arquivo.Length == 0)
                return BadRequest("Nenhum arquivo foi enviado.");

            // Lê o caminho parametrizado do appsettings
            var caminhoPasta = _configuration["UploadSettings:CaminhoPasta"];

            // Se quiser transformar em caminho absoluto
            if (string.IsNullOrEmpty(caminhoPasta))
                return BadRequest("O caminho da pasta não está configurado.");

            caminhoPasta = Path.Combine(Directory.GetCurrentDirectory(), caminhoPasta);

            // Garante que a pasta existe
            if (!Directory.Exists(caminhoPasta))
            {
                Directory.CreateDirectory(caminhoPasta);
            }

            // Monta o caminho completo do arquivo
            var caminhoArquivo = Path.Combine(caminhoPasta, arquivo.FileName);

            // Salva o arquivo no disco
            using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                await arquivo.CopyToAsync(stream);
            }

            return Ok(new { mensagem = "Arquivo enviado com sucesso!", nomeArquivo = arquivo.FileName });
        }
        [HttpGet("download/{nomeArquivo}")]
        public IActionResult DownloadArquivo(string nomeArquivo)
        {
            // Lê o caminho configurado no appsettings.json
            var caminhoPasta = _configuration["UploadSettings:CaminhoPasta"];
            caminhoPasta = Path.Combine(Directory.GetCurrentDirectory(), caminhoPasta);

            var caminhoArquivo = Path.Combine(caminhoPasta, nomeArquivo);

            if (!System.IO.File.Exists(caminhoArquivo))
                return NotFound("Arquivo não encontrado.");

            var contentType = "application/octet-stream"; // Tipo genérico (pode melhorar detectando MIME)

            var bytes = System.IO.File.ReadAllBytes(caminhoArquivo);
            return File(bytes, contentType, nomeArquivo);
        }
        [HttpDelete("delete/{nomeArquivo}")]
        public IActionResult ExcluirArquivo(string nomeArquivo)
        {
            // Lê o caminho configurado no appsettings.json
            var caminhoPasta = _configuration["UploadSettings:CaminhoPasta"];
            caminhoPasta = Path.Combine(Directory.GetCurrentDirectory(), caminhoPasta);

            var caminhoArquivo = Path.Combine(caminhoPasta, nomeArquivo);

            if (!System.IO.File.Exists(caminhoArquivo))
                return NotFound("Arquivo não encontrado.");

            System.IO.File.Delete(caminhoArquivo);

            return Ok(new { mensagem = "Arquivo excluído com sucesso!", nomeArquivo = nomeArquivo });
        }
        [HttpGet("listar")]
        public IActionResult ListarArquivos()
        {
            // Lê o caminho configurado no appsettings.json
            var caminhoPasta = _configuration["UploadSettings:CaminhoPasta"];
            caminhoPasta = Path.Combine(Directory.GetCurrentDirectory(), caminhoPasta);

            if (!Directory.Exists(caminhoPasta))
                return NotFound("Pasta não encontrada.");

            var arquivos = Directory.GetFiles(caminhoPasta);
            return Ok(arquivos);
        }
    }
}
