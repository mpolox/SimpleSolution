using SimpleAPI.Data.interfaces;
using SimpleAPI.Models;

namespace SimpleAPI.Data;

public class MockOperationRepo : IOperationRepo
{

  Operation myOp = new Operation{
    Id = 1,
    Name = "Marcopolo",
    Description = "This is the description",
    Details = "Details"
  };
  Operation myOp2 = new Operation{
    Id = 2,
    Name = "Marcopolo",
    Description = "This is the description",
    Details = "Details"
  };

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

  public Operation RunbyId(int id)
  {
    return myOp;
  }
}