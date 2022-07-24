using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers;

[ApiController]
public abstract class AbstractController<T>:Controller
{
    [HttpGet("all")]
    public abstract List<T> GetAll();
    
    [HttpDelete("{id:long}")]
    public abstract void DeleteById(ulong id);
    
    [HttpGet("{id:long}")]
    public abstract T FindById(ulong id);

    [HttpPost("")]
    public abstract ulong Create(PersonnageCreationRequest creationRequest);

}