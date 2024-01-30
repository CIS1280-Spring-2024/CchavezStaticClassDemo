using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CchavezStaticClassDemo
{
    internal class Student
    {
        //  4.2.	Create a static array to store allowable majors.
        public static string[] majors = new string[] { "Programming", "Business", "Art History" };

        //  3.4.	Let’s change major to static as well:
        //  private static string major;
        private string major;
        public string GetMajor()
        {
            return major;
        }
        //  3.2.	Let’s see what happens if we use the static key word with one of
        //  our instance methods.Our accessor and mutator are said to be instance
        //  methods because they are associated with each instanciated instance
        //  of the class (myStudent vs myOtherStudent in this case);
        //  public static void SetMajor(string _major)
        //  {
        //    major = _major;
        //  }
        //  '

        //  GetMajor() also needs to be changed as
        //  all references to variable would need to reference it as static
        //  public static string GetMajor()
        //  {
        //      return major;
        //  }

        public void SetMajor(string major)
        {
            this.major = major;
        }
        private int score1;

        public int GetScore1()
        {
            return score1;
        }

        public void SetScore1(int score1)
        {
            this.score1 = score1;
            Calc();
        }

        private int score2;

        public int GetScore2()
        {
            return score2;
        }

        public void SetScore2(int score2)
        {
            this.score2 = score2;
            Calc();
        }

        private int score3;

        public int GetScore3()
        {
            return score3;
        }

        public void SetScore3(int score3)
        {
            this.score3 = score3;
            Calc();
        }

        private string firstName;

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        private string lastName;

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        private string studentNumber;

        public string GetStudentNumber()
        {
            return studentNumber;
        }

        public void SetStudentNumber(string num)
        {
            studentNumber = num;
        }

        //Read only attributes
        private float average;

        public float GetAverage()
        {
            return average;
        }

        public string GetSummary()
        {
            return firstName + " " + lastName + " " + studentNumber + " Average: " + average;
        }

        //Private methods
        private void Calc()
        {
            average = (score1 + score2 + score3) / 3;
        }
    }
}
