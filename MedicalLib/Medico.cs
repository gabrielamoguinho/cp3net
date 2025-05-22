namespace MedicalLib;

public class Medico : Pessoa
{
    public string CRM { get; set; } = string.Empty;
    protected string Especialidade { get; set; } = string.Empty;

    public override string ObterIdentificacao()
    {
        return $"Médico: {Nome}, CRM: {CRM}";
    }
}
