using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Data;
using SimpleAPI.Data.interfaces;
using SimpleAPI.Dtos;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("api/operation")]
public class OperationController : ControllerBase{

  private ResponseDto _response = new ResponseDto();
  private readonly IOperationRepo _repo;

  public OperationController(IOperationRepo repo)
  {
    _repo = repo;    
  }

  [HttpGet("{id}")]
  public ResponseDto GetById(int id) {
    _response.Data = _repo.getById(id);
    return _response;
  }

  [HttpGet]
  public ResponseDto GetAll() {
    _response.Data = _repo.getAll();
    return _response;
  }

}