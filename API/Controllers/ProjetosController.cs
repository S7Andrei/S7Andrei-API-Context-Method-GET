using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore. Mvc;
using System;
namespace Exo.WebApi. Controllers
{
[Route("api/[controller]"]]
[ApiController]
0 references
public class Projetos Controller ControllerBase
{ I
2 references
private readonly ProjetoRepository projetoRepository;
O references
public Projetos Controller (ProjetoRepository projetoRepository)
{
_projetoRepository = projetoRepository;
}

[HttpGet]
0 references
public IActionResult Listar()
{   
return ok (_projetoRepository. Listar());
}
}
}