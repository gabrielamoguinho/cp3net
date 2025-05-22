namespace MedicalLib;

public abstract class Pessoa
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public abstract string ObterIdentificacao();
}
