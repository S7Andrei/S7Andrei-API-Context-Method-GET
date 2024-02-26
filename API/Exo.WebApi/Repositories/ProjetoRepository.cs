using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System. Threading. Tasks;
namespace Exo.WebApi. Repositories
{
2 references
public class ProjetoRepository
{
2 references
private readonly ExoContext _context;
O references
public ProjetoRepository (ExoContext context)
{
_context= context;
}
public List<Projeto> Listar()
{
return _context. Projetos. ToList();
}
}