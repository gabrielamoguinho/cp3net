using Microsoft.AspNetCore.Mvc;
using MedicalLib;

namespace MedicalApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConsultaController : ControllerBase
{
    // Lista em memória para simular o banco por enquanto
    private static readonly List<Consulta> _consultas = new();

    // GET: /api/consulta
    [HttpGet]
    public ActionResult<IEnumerable<Consulta>> Get()
    {
        return Ok(_consultas);
    }

    // POST: /api/consulta
    [HttpPost]
    public ActionResult Post([FromBody] Consulta consulta)
    {
        consulta.Id = Guid.NewGuid();
        _consultas.Add(consulta);
        return CreatedAtAction(nameof(Get), new { id = consulta.Id }, consulta);
    }

    // PUT: /api/consulta/{id}
    [HttpPut("{id}")]
    public ActionResult Put(Guid id, [FromBody] Consulta novaConsulta)
    {
        var consulta = _consultas.FirstOrDefault(c => c.Id == id);
        if (consulta == null) return NotFound();

        consulta.DataHora = novaConsulta.DataHora;
        consulta.Descricao = novaConsulta.Descricao;
        consulta.PacienteId = novaConsulta.PacienteId;
        consulta.MedicoId = novaConsulta.MedicoId;

        return NoContent();
    }

    // DELETE: /api/consulta/{id}
    [HttpDelete("{id}")]
    public ActionResult Delete(Guid id)
    {
        var consulta = _consultas.FirstOrDefault(c => c.Id == id);
        if (consulta == null) return NotFound();

        _consultas.Remove(consulta);
        return NoContent();
    }
}
