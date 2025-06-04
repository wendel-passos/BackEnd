namespace ReceitaFederalImport.Models
{
    public class Socio
    {
        public int Id { get; set; }
        public string? CnpjBasico { get; set; }
        public string? IdentificadorSocio { get; set; }
        public string? NomeSocio { get; set; }
        public string? CnpjCpfSocio { get; set; }
        public string? QualificacaoSocio { get; set; }
        public DateTime? DataEntradaSociedade { get; set; }
        public string? Pais { get; set; }
        public string? CpfRepresentanteLegal { get; set; }
        public string? NomeRepresentante { get; set; }
        public string? QualificacaoRepresentante { get; set; }
        public string? FaixaEtaria { get; set; }
    }
}
