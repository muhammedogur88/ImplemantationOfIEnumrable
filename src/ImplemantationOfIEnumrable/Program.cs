using System;

namespace ImplemantationOfIEnumrable
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseMemberList courseMemberList = new CourseMemberList();
            courseMemberList.Add(new CourseMember("Oğuz", "Karan"));
            courseMemberList.Add(new CourseMember("Kaan", "Arslan"));
            courseMemberList.Add(new CourseMember("Muhammed", "Oğur"));
            courseMemberList.Add(new CourseMember("Hede", "Hüde"));

            //for (int i = 0; i < courseMemberList.Count; i++)
            //{
            //    Console.WriteLine(courseMemberList[i]);
            //}

            Console.WriteLine(courseMemberList.Count);
            Console.WriteLine(courseMemberList[0]);

            foreach (var member in courseMemberList)
            {
                Console.WriteLine(member);
            }
        }
    }
}
