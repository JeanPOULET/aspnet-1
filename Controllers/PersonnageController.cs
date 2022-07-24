using Microsoft.AspNetCore.Mvc;
using WebApplication1.entities;
using WebApplication1.Model;
using WebApplication1.Repositories;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
public class PersonnageController : AbstractController<Personnage>
{

    private readonly ILogger<PersonnageController> _logger;
    private readonly PersonnageRepository repo;
    private readonly ItemRepository item;


    public PersonnageController(ILogger<PersonnageController> logger)
    {
        _logger = logger;
        repo = new PersonnageRepository(new ItemRepository());
    }
    
    public override List<Personnage> GetAll()
    {
        return repo.getAll();
    }

    public override void DeleteById(ulong id)
    {
        repo.deleteById(id);
    }

    public override Personnage FindById(ulong id)
    {
        return repo.getById(id);
    }

    public override ulong Create(PersonnageCreationRequest creationRequest)
    {
        return repo.create(new Personnage(creationRequest.nom));
    }
}