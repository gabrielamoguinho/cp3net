namespace MedicalLib;

public class Consulta
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime DataHora { get; set; }
    public Guid PacienteId { get; set; }
    public Guid MedicoId { get; set; }
    public string Descricao { get; set; } = string.Empty;
}
