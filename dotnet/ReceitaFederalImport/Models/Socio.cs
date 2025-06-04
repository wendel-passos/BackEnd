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
