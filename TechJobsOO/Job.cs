using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }


        // TODO: Add the two necessary constructors.

        //constructor 1 of Job class: initialize id field with a unqiue value. Takes no parameter.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        //constructor 2: Takes 5 parameter and assign values to them //Use constructor chaining to call first constructor so that id field will initalize
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            string unavailableMessage = "Data not available";

            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;

            if (name == "")
            {
                Name = unavailableMessage;

            }

        }



        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            //Two Job objects are equal when their id fields match
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

  
        //TODO: Generate ToString() method that overrides the Tostring method to return type name along with its value
        public override string ToString()
        {
            string unavailableMessage = "Data not available";

            if (Name == unavailableMessage && EmployerName.Value == unavailableMessage && EmployerLocation.Value == unavailableMessage && JobType.Value == unavailableMessage && JobCoreCompetency.Value == unavailableMessage)
            {
                return "OOPS! This job does not seem to exist.";

            } else
            {

                return "\n" + "ID:  " + Id + "\n" + "Name:  " + Name + "\n" + "Employer:  " + EmployerName + "\n" + "Location:  " + EmployerLocation + "\n" + "Position Type:  " + JobType + "\n" + "Core Competency:  " + JobCoreCompetency;
       
            }
        }

    }
}
