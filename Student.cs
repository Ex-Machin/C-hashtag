namespace hwapp
{
    public class Student
    {
        public string name = "";
        public string major = "";
        public double gpa = 0;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors()
        {
            if(gpa >= 2.5)
            {
                return true;
            }
            return false;
        }

    }
}