using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.entities;

public abstract class AbstractEntity
{
    protected AbstractEntity(string nom)
    {
        this.nom = nom;
    }

    
    public ulong id { get; set; }
    public string nom { get; set; }
}