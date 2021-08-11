using System;
namespace TechJobsOO
{
    public class Location
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public Location()
        {
            Id = nextId; //initialize id proptery
            nextId++;
        }

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field.

        public Location(string value) : this()//constructor chaining: calling first constructor to initalize id field
        {
            Value = value; //sets the value of value field
        }




        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
