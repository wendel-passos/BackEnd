using Microsoft.AspNetCore.Mvc;
using ReceitaFederalImport.Services;

namespace ReceitaFederalImport.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImportController : ControllerBase
    {
        private readonly DataImportService _importService;

        public ImportController(DataImportService importService)
        {
            _importService = importService;
        }

        [HttpPost("executar")]
        public async Task<IActionResult> ExecutarImportacao()
        {
            await _importService.ImportDataAsync();
            return Ok("Importação concluída com sucesso.");
        }
    }
}
