

namespace ConsoleAppCore
{
    public class Member
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BirthPlace { get; set; }

        public uint? Age { get; set; }
        public bool? IsGraduated { get; set; }

        public Member(string firstname, string lastname, string gender, DateTime dob,
         string phonenumber, string birthplace, uint age, bool isgraduated)
        {
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            DateOfBirth = dob;
            PhoneNumber = phonenumber;
            BirthPlace = birthplace;
            Age = age;
            IsGraduated = isgraduated;
        }

        public Member()
        {

        }

        public override string ToString()
        {

            return $"Member's Information: FirstName: {FirstName} – LastName: {LastName} – Gender:{Gender} -Age: {Age} - Phone : {PhoneNumber} - Date of birth: {DateOfBirth} - Birth Place: {BirthPlace} - IsGraduated:{IsGraduated} ";
        }

        public static void GetFullName(List<Member> list)
        {
            foreach (Member item in list)
            {
                string FullName = item.LastName + " " + item.FirstName;
                System.Console.WriteLine(FullName);
            }
        }

        public static void GetMaleMember(List<Member> list)
        {
            foreach (Member item in list)
            {
                if (item.Gender == "Male")
                {
                    System.Console.WriteLine(item);
                }
            }
        }

        public static void GetOldestAge(List<Member> list)
        {
            foreach (Member item in list)
            {
                
                   
                System.Console.WriteLine(item);

                break;
            }
        }
        
        public static void GetBirthYearIs2000(List<Member> list)
        {
            foreach (Member item in list)
            {
                if (item.DateOfBirth.Year == 2000)
                {
                    System.Console.WriteLine(item);
                }
            }
        }

         public static void GetBirthYearGreater2000(List<Member> list)
        {
            foreach (Member item in list)
            {
                if (item.DateOfBirth.Year >= 2000)
                {
                    System.Console.WriteLine(item);
                }
            }
        }

        public static void GetBirthYearLess2000(List<Member> list)
        {
            foreach (Member item in list)
            {
                if (item.DateOfBirth.Year <= 2000)
                {
                    System.Console.WriteLine(item);
                }
            }
        }

        public static void GetMemberBornInHaNoi(List<Member> list){
            foreach (Member item in list)
            {
                if (item.BirthPlace.ToLower() == "ha noi" )
                {
                    System.Console.WriteLine(item);
                    break;
                }
            }
        }
    }
}