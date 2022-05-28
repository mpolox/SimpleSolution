using SimpleAPI.Data.interfaces;
using SimpleAPI.Models;

namespace SimpleAPI.Data;

public class MockOperationRepo : IOperationRepo
{

    Operation myOp = new Operation {
        Id = 1,
        Name = "Marcopolo",
        Description = "This is the description",
        Details = "Details"
    };
    Operation myOp2 = new Operation {
        Id = 2,
        Name = "Marcopolo",
        Description = "This is the description",
        Details = "Details"
    };

    List<Calificaciones> myCals = new List<Calificaciones>
    {
        new Calificaciones { Id = 1, Materia = "Mate I", Calificacion= 23},
        new Calificaciones { Id = 2, Materia = "TLR I", Calificacion= 23},
        new Calificaciones { Id = 3, Materia = "Física I", Calificacion= 23},
        new Calificaciones { Id = 4, Materia = "Artes", Calificacion= 23},
        new Calificaciones { Id = 5, Materia = "Dibujo", Calificacion= 23},
        new Calificaciones { Id = 6, Materia = "Geografía", Calificacion= 23},
        new Calificaciones { Id = 7, Materia = "Naturales", Calificacion= 23},
    };
    


  public Operation CreateOperation(Operation op)
  {
    return op;    
  }

  public Operation DeleteById(int id)
  {
    return myOp;
  }

  public IEnumerable<Operation> getAll()
  {
    var response = new List<Operation> {myOp,myOp2};
    return response;
  }

  public Operation getById(int id)
  {
    return myOp;
  }

    public IEnumerable<Calificaciones> getMines()
    {
        return myCals;
    }

    public Operation RunbyId(int id)
  {
    return myOp;
  }
}