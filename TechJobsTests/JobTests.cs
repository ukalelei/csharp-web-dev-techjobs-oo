using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //TODO TEST 1: Each Job object should contain a unique ID number, and these should also be sequential integers
        [TestMethod]
        public void TestSettingJobId()
        {
            Job one = new Job();
            Job two = new Job();

            Assert.IsFalse(one.Id == two.Id);
            Assert.IsTrue(two.Id == one.Id + 1);
        }

        //TODO TEST 2: Each Job object should contain six properties—Id, Name, EmployerName, EmployerLocation, JobType, and JobCoreCompetency
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //arrange variable  
            Employer ACME = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality control");
            CoreCompetency persistence = new CoreCompetency("Persistence");

            //act on Job constructor method
            Job test_job = new Job("Product tester", ACME, desert, qualityControl, persistence);

            //assert statements to test that the constructor correctly assigns the value of each field
            Assert.AreEqual("Product tester", test_job.Name);
            Assert.AreEqual(ACME, test_job.EmployerName);
            Assert.AreEqual(desert, test_job.EmployerLocation);
            Assert.AreEqual(qualityControl, test_job.JobType);
            Assert.AreEqual(persistence, test_job.JobCoreCompetency);
        }

        //TODO TEST 3
        //Two Job objects are considered equal if they have the same id value, even if one or more of the other fields differ
        //Two objects are NOT equal if their id values differ, even if all the other fields are identica
        [TestMethod]
        public void TestJobsForEquality()
        {
            //Passing arguement to Job constructor 
            Employer ACME = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality control");
            CoreCompetency persistence = new CoreCompetency("Persistence");

            //two Job object with identical fields except for their id
            Job one = new Job("Product tester", ACME, desert, qualityControl, persistence);
            Job two = new Job("Product tester", ACME, desert, qualityControl, persistence);

            //assert statement that test Equal() returns false
            Assert.IsFalse(one.Equals(two));
        }

        //TODO TEST 4

    }
}
