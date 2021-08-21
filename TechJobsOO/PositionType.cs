using System;
namespace TechJobsOO
{
    public class PositionType
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            string unavailableMessage = "Data not available";
            Value = value;

            if (value == "")
            {
                Value = unavailableMessage;
            }
        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.

        //ToString method
        public override string ToString()
        {
            return Value; //returns value of a PositionType object
        }

        // Equals method returns true if all equality check within the method is true
        public override bool Equals(object obj)
        {
            return obj is PositionType position && // Sets value of position to obj if compiler confirms is possible to cast obj to a variable name "position" of type PositionType. 
                   Id == position.Id; //Value of Id and value of position.Id is compared for equality 
        }

        //GetHashCode 
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
