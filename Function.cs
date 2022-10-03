using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppCore
{
    public class Function
    {
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

        public static void GetAllMember(List<Member> list){
            foreach (Member item in list)
            {
               System.Console.WriteLine(item);
            }
        }
    }
}