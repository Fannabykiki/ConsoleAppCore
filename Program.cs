namespace ConsoleAppCore
{
    class Program
    {


        static public void Main(String[] args)
        {
            int n;
            List<Member> mb = new List<Member>();

            mb.Add(new Member
            {
                FirstName = "Phan",
                LastName = "Nam",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 10, 18),
                PhoneNumber = "0396373132",
                BirthPlace = "Ha Noi",
                Age = 21,
                IsGraduated = true
            });

            mb.Add(new Member
            {
                FirstName = "Tran",
                LastName = "Linh",
                Gender = "FeMale",
                DateOfBirth = new DateTime(2003, 10, 15),
                PhoneNumber = "0396373132",
                BirthPlace = "Bac Ninh",
                Age = 29,
                IsGraduated = false
            });

            mb.Add(new Member
            {
                FirstName = "Dao",
                LastName = "Trang",
                Gender = "FeMale",
                DateOfBirth = new DateTime(2003, 07, 13),
                PhoneNumber = "0396373132",
                BirthPlace = "SG",
                Age = 29,
                IsGraduated = true
            });

            mb.Add(new Member
            {
                FirstName = "Vu",
                LastName = "Kim",
                Gender = "Male",
                DateOfBirth = new DateTime(2003, 11, 30),
                PhoneNumber = "0396373132",
                BirthPlace = "Ha Noi",
                Age = 29,
                IsGraduated = true
            });

            mb.Add(new Member
            {
                FirstName = "Duy",
                LastName = "Anh",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 11, 30),
                PhoneNumber = "0396373132",
                BirthPlace = "Ha Noi",
                Age = 21,
                IsGraduated = true
            });

            do
            {

                try
                {

                    System.Console.WriteLine("Case 0 :Show all");
                    System.Console.WriteLine("Case 1 :A list of members who is Male");
                    System.Console.WriteLine("Case 2 :The oldest one based on “Age”");
                    System.Console.WriteLine("Case 3 :A new list that contains Full Name only");
                    System.Console.WriteLine("Case 4 :List of members who has birth year is 2000");
                    System.Console.WriteLine("Case 5 :List of members who has birth year greater than 2000");
                    System.Console.WriteLine("Case 6 :List of members who has birth year less than 2000");
                    System.Console.WriteLine("Case 7 :Return the first person who was born in Ha Noi.");
                    System.Console.WriteLine("Enter option: ");

                    n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {

                        case 0:                         
                            Function.GetAllMember(mb);

                            break;
                        case 1:
                            Function.GetMaleMember(mb);

                            break;
                        case 2:
                            Function.GetOldestAge(mb);

                            break;
                        case 3:
                            Function.GetFullName(mb);

                            break;
                        case 4:
                            Function.GetBirthYearIs2000(mb);

                            break;
                        case 5:
                            Function.GetBirthYearGreater2000(mb);

                            break;

                        case 6:
                            Function.GetBirthYearLess2000(mb);

                            break;
                        case 7:
                            Function.GetMemberBornInHaNoi(mb);

                            break;
                        default:
                            System.Console.WriteLine("Enter integer number from 0 - 7 ");

                            return;
                    }
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Enter integer number please");

                    return;
                }
            } while (n >= 0 && n <= 7);
            Console.ReadKey();
        }
    }
}