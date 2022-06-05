using ApiController.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Data.interfaces;
using SimpleAPI.Dtos;
using SimpleAPI.Models;

namespace SimpleAPI.Controllers;

//Controller

[ApiController]
[Route("api/operation")]
public class OperationController : ControllerBase
{

    private OutputResponseDto _response = new OutputResponseDto();
    private readonly IOperationRepo _repo;

    public OperationController(IOperationRepo repo)
    {
        _repo = repo;
    }

    [HttpGet("GetById/{id}")]
    public OutputResponseDto GetById(int id)
    {
        _response.Data = _repo.getById(id);
        return _response;
    }

    [HttpGet("GetAll/")]
    public OutputResponseDto GetAll()
    {
        _response.Data = _repo.getAll();
        return _response;
    }

    [HttpPost("AddOperation")]
    public OutputResponseDto CreateOperation(InputOperationDto op)
    {
        Operation myOp = new Operation();
        myOp.Description = op.Data;
        myOp.Name = op.Name;
        myOp.Id = op.Id;
        _response.Data = _repo.CreateOperation(myOp);

        return _response;
    }

    [HttpGet("GetCalificaciones/")]
    public OutputResponseDto GetCalificaciones()
    {
        _response.Data = _repo.getMines();
        return _response;
    }

    [HttpGet("GetResumen/")]
    public OutputResponseDto GetResumen()
    {
        _response.Data = _repo.GetResumenAlumno();
        return _response;
    }


    [HttpGet("TestAdmin/")]
    [Authorize]

    public IActionResult TestAdmin()
    {
        return Ok("Test Admin");
    }

    [HttpGet("TestPublic/")]
    public IActionResult TestPublic()
    {
        return Ok("Test Public");
    }

    [HttpGet("TestTeacher/")]
    public IActionResult TestTeacher()
    {
        return Ok("Test Teacher");
    }

    [HttpGet("TestStudent/")]
    public IActionResult TestStudent()
    {
        return Ok("Test Student");
    }



}