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

    // ---------------- Para el resumen de calificaciones ----------------
    Random rand = new Random();

    Alumno a = new Alumno
    {
        Id = 1,
        Nombre = "Marcopolo",
        Apellidos = "Ramos Galvan",
        FechaDeNacimiento = DateTime.Now,
        Matricula = "2022321654987",
        Nota = "Alumno de 1er semestre."
    };

    private Parcial CreateParcial(int numero)
    {
        Parcial parcial = new Parcial
        {
            Ausencias = rand.Next(5),
            Calificacion = rand.Next(101),
            Descripcion = "Descripcion del parcial",
            Id = rand.Next(1000),
            Nombre = "Nombre del parcial #" + rand.Next(1000),
            Numero = numero            
        };

        return parcial;
    }
    private List<Parcial> CreateParciales()
    {
        List<Parcial> parciales = new List<Parcial>();
        parciales.Add(CreateParcial(1));
        parciales.Add(CreateParcial(2));
        parciales.Add(CreateParcial(3));
        parciales.Add(CreateParcial(4));
        return parciales;    
    }

    private Materia CreateMateria(string name, string teacher)
    {
        
        Materia materia = new Materia();
        materia.Id = rand.Next(101);
        materia.Nombre = name;
        materia.NombreMaestro = teacher;
        materia.NombreCorto = name.Substring(0, 3);
        materia.Parciales = CreateParciales();
        materia.Creditos = 5 * rand.Next(1,3);
        return materia;

    }

    private List<Materia> CreateMaterias()
    {
        List<Materia> materias = new List<Materia>();
        materias.Add(CreateMateria("Matematicas I", "Pancho Lopez"));
        materias.Add(CreateMateria("Español", "Ramiro Ramirez"));
        materias.Add(CreateMateria("Fisica I", "Luisa Lozano"));
        materias.Add(CreateMateria("Artes", "Flor Flores"));
        materias.Add(CreateMateria("Historia", "Jesus Jimenez"));
        materias.Add(CreateMateria("Deportes", "Hugo Hernandez"));
        materias.Add(CreateMateria("Geografia", "Gerardo Gomez"));
        return materias;
    }

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

    public ResumenAlumno GetResumenAlumno()
    {

        ResumenAlumno ra = new ResumenAlumno
        {
            Alumno = a,
            Descripcion = "Resumen para el Alumno " + a.Nombre,
            Id = 1,
            Materias = CreateMaterias()
        };
        return ra;
    }

    public Operation RunbyId(int id)
  {
    return myOp;
  }
}