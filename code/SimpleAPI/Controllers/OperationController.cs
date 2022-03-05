using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Dtos;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("api/operation")]
public class OperationController : ControllerBase{

  ResponseDto myResponse = new ResponseDto();

  [HttpGet("{id}")]
  public ResponseDto GetById(int id) {
    myResponse.Data = "Marcopolo" + id;
    return myResponse;
  }  
}