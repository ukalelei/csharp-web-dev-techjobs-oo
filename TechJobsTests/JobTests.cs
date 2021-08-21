using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job one;
        Job two;
        Job test_three;
        Employer ACME;
        PositionType qualityControl;
        CoreCompetency persistence;


        [TestInitialize]
        public void CreateObjects()
        {
            ACME = new Employer("ACME");
            desert = new Location("Desert");
            qualityControl = new PositionType("Quality control");
            persistence = new CoreCompetency("Persistence");

            one = new Job();
            two = new Job();
            test_three = new Job("Product tester", ACME, desert, qualityControl, persistence);
        }


        //TODO TEST 1: Each Job object should contain a unique ID number, and these should also be sequential integers
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(one.Id == two.Id);
            Assert.IsTrue(two.Id == one.Id + 1);
        }

        //TODO TEST 2: Each Job object should contain six properties—Id, Name, EmployerName, EmployerLocation, JobType, and JobCoreCompetency
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            /*arrange variable  
            Employer ACME = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality control");
            CoreCompetency persistence = new CoreCompetency("Persistence");*/

            //act on Job constructor method
            //test_three = new Job("Product tester", ACME, desert, qualityControl, persistence);

            //assert statements to test that the constructor correctly assigns the value of each field
            Assert.AreEqual("Product tester", test_three.Name);
            Assert.AreEqual(ACME, test_three.EmployerName);
            Assert.AreEqual(desert, test_three.EmployerLocation);
            Assert.AreEqual(qualityControl, test_three.JobType);
            Assert.AreEqual(persistence, test_three.JobCoreCompetency);
        }

        //TODO TEST 3
        //Two Job objects are considered equal if they have the same id value, even if one or more of the other fields differ
        //Two objects are NOT equal if their id values differ, even if all the other fields are identica
        [TestMethod]
        public void TestJobsForEquality()
        {
            //Passing arguement to Job constructor 
            /*Employer ACME = new Employer("ACME");
            Location desert = new Location("Desert");
            PositionType qualityControl = new PositionType("Quality control");
            CoreCompetency persistence = new CoreCompetency("Persistence");*/

            //two Job object with identical fields except for their id
            one = new Job("Product tester", ACME, desert, qualityControl, persistence);
            two = new Job("Product tester", ACME, desert, qualityControl, persistence);

            //assert statement that test Equal() returns false
            Assert.IsFalse(one.Equals(two));
        }

        //TODO TEST 4

            //assert test
            Assert.AreEqual("\n" + "ID:  " + four_test.Id + "\n" + "Name:  " + four_test.Name +"\n" + "Employer:  " + unavailable + "\n" + "Location:  " + unavailable + "\n" + "Position Type:  " + unavailable + "\n" + "Core Competency:  " + unavailable , four_test.ToString());
        }

        //TODO TEST 7 BONUS
        //if only ID data exist, method returns "OOPS! This job does not seem to exist.”
        [TestMethod]
        public void ShouldDisplaySpecilMessageIfOnlyIdDataExist()
        {
            //create empty objects
            Employer EmployerEmpty = new Employer("");
            Location LocationEmpty = new Location("");
            PositionType PositionEmpty = new PositionType("");
            CoreCompetency CompetencyEmpty = new CoreCompetency("");

            //create object with empty-string fields
            Job five_test = new Job("", EmployerEmpty, LocationEmpty, PositionEmpty, CompetencyEmpty);

            Assert.AreEqual("OOPS! This job does not seem to exist.", five_test.ToString());
        }
    }
}
