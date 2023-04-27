using System.ComponentModel.DataAnnotations;

namespace Core.Persistence.Repositories;

public class Entity
{
    [Key]
    public int Id { get; set; }

    public Entity()
    {
    }

    public Entity(int id) : this()
    {
        Id = id;
    }
}