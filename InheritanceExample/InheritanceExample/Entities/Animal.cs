namespace InheritanceExample.Entities
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public int KilledByHunterId { get; set; }
        public string Name { get; set; }
        public Hunter KilledByHunter { get; set; }
    }
}
