using System;

namespace Wine.Bottles
{
    public class Bottle : Container
    {
        public Bottle(int id, string name, int size)
        {
            Id = id;
            Name = name;
            Size = size;
        }

        public Bottle() : this(10, "Empty", 75)
        {
        }

        public override void Pour()
        {
            base.Pour();
            Console.WriteLine("Bottle::Pour");
        }

        int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
               
    }
}
