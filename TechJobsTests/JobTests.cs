using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //declare global variables that will allow all tests to have access
        Job one;
        Job two;
        Job three;
        Employer ACME;
        Location desert;
        PositionType qualityControl;
        CoreCompetency persistence;


        [TestInitialize] //TestInitalize attribute will run CreateObjects() method before each test method is run
        public void CreateObjects()
        {
            //instantiate class Job, Employer, Location, PositionType, and CoreCompetency
            two = new Job();
            three = new Job("Product tester", ACME, desert, qualityControl, persistence);
            one = new Job();

            ACME = new Employer("ACME");
            desert = new Location("Desert");
            qualityControl = new PositionType("Quality control");
            persistence = new CoreCompetency("Persistence");

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
            //assert statements to test that the constructor correctly assigns the value of each field
            Assert.AreEqual("Product tester", three.Name);
            Assert.AreEqual(ACME, three.EmployerName);
            Assert.AreEqual(desert, three.EmployerLocation);
            Assert.AreEqual(qualityControl, three.JobType);
            Assert.AreEqual(persistence, three.JobCoreCompetency);
        }

        //TODO TEST 3
        //Two Job objects are considered equal if they have the same id value, even if one or more of the other fields differ
        //Two objects are NOT equal if their id values differ, even if all the other fields are identica
        [TestMethod]
        public void TestJobsForEquality()
        {
            //two Job object with identical fields except for their id
            one = new Job("Product tester", ACME, desert, qualityControl, persistence);
            two = new Job("Product tester", ACME, desert, qualityControl, persistence);

            //assert statement that test Equal() returns false
            Assert.IsFalse(one.Equals(two));
        }

        //TODO TEST 4
        //When passed a Job object, it should return a string that contains a blank line before and after the job information
        [TestMethod]
        public void ShouldReturnTwoBlankLineBeforeInfo()
        {
            String toString = one.ToString();
            Assert.IsTrue(toString.StartsWith("\n"));
           
        }

        //TODO TEST 5
        //string should contain a label for each field, followed by the data stored in that field. Each field should be on its own line.
        [TestMethod]
        public void ShouldBeLabelThenDataAndBeOnOwnLine()
        {
            Assert.AreEqual("\n" + "ID:  " + one.Id + "\n" + "Name:  " + one.Name + "\n" + "Employer:  " + one.EmployerName + "\n" + "Location:  " + one.EmployerLocation + "\n" + "Position Type:  " + one.JobType + "\n" + "Core Competency:  " + one.JobCoreCompetency, one.ToString());
        }

        //TODO TEST 6
        //if field is empty, return “Data not available” after the label.
        [TestMethod]
        public void ShouldDisplayNotAvailableIfAFieldIsEmpty ()
        {
            //create empty objects
            Employer EmployerEmpty = new Employer("");
            Location LocationEmpty = new Location("");
            PositionType PositionEmpty = new PositionType("");
            CoreCompetency CompetencyEmpty = new CoreCompetency("");

            //declare message that would be displayed if field is empty
            string unavailable =  "Data not available";

            //create object with empty-string fields
            Job four_test = new Job("Some Job", EmployerEmpty, LocationEmpty, PositionEmpty, CompetencyEmpty);

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
