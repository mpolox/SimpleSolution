using SimpleAPI.Models;

namespace SimpleAPI.Data.interfaces;

public interface IOperationRepo
{
    IEnumerable<Operation> getAll();
    Operation getById(int id);
    Operation RunbyId(int id);
    Operation DeleteById(int id);
    Operation CreateOperation(Operation op);
    IEnumerable<Calificaciones> getMines();
    ResumenAlumno GetResumenAlumno();
}
