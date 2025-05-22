namespace MedicalLib;

public class Paciente : Pessoa
{
    public string CPF { get; set; } = string.Empty;

    public override string ObterIdentificacao()
    {
        return $"Paciente: {Nome}, CPF: {CPF}";
    }
}
