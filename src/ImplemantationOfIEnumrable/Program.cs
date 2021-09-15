using System;

namespace ImplemantationOfIEnumrable
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseMemberList courseMemberList = new CourseMemberList
            {
                new CourseMember("Oğuz", "Karan"),
                new CourseMember("Kaan", "Arslan"),
                new CourseMember("Muhammed", "Oğur"),
                new CourseMember("Hede", "Hüde")
             };

            //courseMemberList.Add(new CourseMember("Oğuz", "Karan"));
            //courseMemberList.Add(new CourseMember("Kaan", "Arslan"));
            //courseMemberList.Add(new CourseMember("Muhammed", "Oğur"));
            //courseMemberList.Add(new CourseMember("Hede", "Hüde"));

            for (int i = 0; i < courseMemberList.Count; i++)
            {
                Console.WriteLine(courseMemberList[i]);
            }

            foreach (var member in courseMemberList)
            {
                Console.WriteLine(member);
            }
        }
    }
}
