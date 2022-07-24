using System.Diagnostics.CodeAnalysis;
using WebApplication1.entities;

namespace WebApplication1.Repositories;

public class ItemRepository:AbstractRepository<Item>
{
    
    public override Item getById(ulong id)
    {
        return db
            .Items
            .First((item) => id == item.id);
    }

    public override List<Item> getAll()
    {
        throw new NotImplementedException();
    }

    public override ulong create(Item personnageCreationRequest)
    {

        return CreateEntity(personnageCreationRequest)
            .id;
    }
    
    public Item CreateEntity(Item personnageCreationRequest)
    {

        Item entity =  db
            .Items
            .Add(personnageCreationRequest)
            .Entity;

        db.SaveChanges();

        return entity;
    }

    public override void deleteById(ulong id)
    {
        throw new NotImplementedException();
    }

    public override void delete(Item personnage)
    {
        throw new NotImplementedException();
    }
}