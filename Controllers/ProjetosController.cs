using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Exo.WebApi.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class ProjetosController : ControllerBase
{
private readonly ProjetoRepository
_ProjetoRepository;
public ProjetosController(ProjetoRepository
ProjetoRepository)
{
_ProjetoRepository = ProjetoRepository;
}
[HttpGet]
public IActionResult Listar()
{
return Ok(_ProjetoRepository.Listar());
}
}
}
