using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.entities;

public class Item:AbstractEntity
{
    public Item(string nom) : base(nom)
    {
    }

    [ForeignKey("fk_personnage")]
    public virtual Personnage Personnage { get; set; }
    
    public decimal vie { get; set; } = new decimal(100.00);
    
    private readonly decimal multiplier = new (0.7);
    
    public decimal degats {get; set;} = new (10.00);

    public decimal slash()
    {
        return degats * multiplier;
    }
    
}