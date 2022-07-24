using System.Diagnostics.CodeAnalysis;
using WebApplication1.entities;
using WebApplication1.Model;

namespace WebApplication1.Repositories;


public class PersonnageRepository:AbstractRepository<Personnage>
{

    private readonly ItemRepository _itemRepository;

    public PersonnageRepository(ItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    public override Personnage getById(ulong id)
    {
        return db.Personnages
            .First(perso => perso.id.Equals(id));
    
    }

    public override List<Personnage> getAll()
    {
        return db.Personnages
            .ToList();
    }

    public override ulong create(Personnage personnageCreationRequest)
    {

        
        Personnage pers = db.Personnages
            .Add(personnageCreationRequest)
            .Entity;

        
        
        
        Item epee = new Item("Epee");
        pers.AddItem(epee);
        
        //_itemRepository.CreateEntity(new Item("Epee"));
        
        db.SaveChanges();


        return pers.id;
    }

    public override void deleteById(ulong id)
    {

        db.Personnages
            .Remove(entity: getById(id) );

        db.SaveChanges();
    }

    public override void delete(Personnage entity)
    {
        db.Personnages
            .Remove(entity);
    }
}