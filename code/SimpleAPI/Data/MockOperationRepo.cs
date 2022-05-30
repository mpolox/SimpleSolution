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
            Ausencias = rand.Next(3),
            Calificacion = 30 + rand.Next(71),
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

    private Materia CreateMateria(int id, string name, string shortName, string teacher)
    {
        
        Materia materia = new Materia();
        materia.Id = rand.Next(101);
        materia.Nombre = name;
        materia.NombreMaestro = teacher;
        materia.NombreCorto = shortName;
        materia.Parciales = CreateParciales();
        materia.Creditos = 5 * rand.Next(1,3);
        return materia;

    }

    private List<Materia> CreateMaterias()
    {
        List<Materia> materias = new List<Materia>();
        materias.Add(CreateMateria(1,"Matematicas I", "Mate I", "Pancho Lopez"));
        materias.Add(CreateMateria(2,"Taller de Lectura y Redaccion I", "TLR I", "Ramiro Ramirez"));
        materias.Add(CreateMateria(3,"Fisica I", "Fis I", "Luisa Lozano"));
        materias.Add(CreateMateria(4,"Apreciacion del Arte", "Artes", "Flor Flores"));
        materias.Add(CreateMateria(5,"Historia", "His", "Jesus Jimenez"));
        materias.Add(CreateMateria(6,"Deportes", "Dep", "Hugo Hernandez"));
        materias.Add(CreateMateria(7,"Geografia", "Geo", "Gerardo Gomez"));
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