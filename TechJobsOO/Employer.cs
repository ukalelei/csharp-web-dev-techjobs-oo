using System;
namespace TechJobsOO
{
    public class Employer
    {

        //get can only read information from that private field and return it
        //set can only write information in that private field.

        public int Id { get; } 
        private static int nextId = 1; // cause its static, its changing value is NOT stored within any Employer object.
        public string Value { get; set; }


        //-------------constructors-------------//

        //every new Employer object will get a different ID number
        public Employer()
        {
            Id = nextId; //assigns value of nextId to id field
            nextId++; //increments nextId
        }

        //initializes id for the object by calling first constructor statement with ": this()"
        //including ": this()" in any Employer constructor makes initializing id a default behavior
        public Employer(string value) : this()//constructor chaining
        {
            Value = value; //assigns value field 
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
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
