namespace WebApplication1.entities;
using Microsoft.EntityFrameworkCore;

public class Personnage:AbstractEntity
{

    
    public Personnage(string nom): base(nom)
    {
        
    }

    public virtual List<Item> Items { get; set; } = new();

    public void AddItem(Item item)
    {
        Items.Add(item);
    }
    
}