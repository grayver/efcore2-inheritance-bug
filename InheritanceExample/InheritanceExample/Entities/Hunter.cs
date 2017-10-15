using System.Collections.Generic;

namespace InheritanceExample.Entities
{
    public class Hunter
    {
        public int Id { get; set; }
        public ICollection<Animal> KilledAnimals { get; set; }
    }
}
