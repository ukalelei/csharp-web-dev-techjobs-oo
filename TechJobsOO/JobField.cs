using System;
namespace TechJobsOO
{
    public abstract class JobField //abstract to prevent creation of a JobField object
    {
        //all four classes have these fields and proerties in common;
        public int Id { get; }
        private static int nextId = 1; //cause its static, its changing value is NOT stored within any Employer object
        public string Value { get; set; }
        private static string unavailableMessage = "Data not available";

        //all four classes hav these constructors
        public JobField()
        {
            Id = nextId; //assigns value of nextId to id field
            nextId++; //increments nextId
        }

        //change and value of empty string to "unavailableMessage"
        public JobField(string value): this()
        {
            Value = value;
            if (value == "")
            {
                Value = unavailableMessage;
            }
        }

        public override string ToString()
        {
            return Value;
        }

    

    }
}
