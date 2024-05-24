using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_bai_3
{
    class UserData
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public List<float> Scores { get; set; }

        public UserData(int id, string userName, List<float> scores)
        {
            ID = id;
            UserName = userName;
            Scores = scores;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        
            List<float> ldata = new List<float>() { 10, 9, 8, 7.5f, 2, 1.4f };

           
            int id = 12345;
            string userName = "Mike";

        
            UserData userData = new UserData(id, userName, ldata);

          
            Console.WriteLine("ID: " + userData.ID);
            Console.WriteLine("UserName: " + userData.UserName);
            Console.WriteLine("Scores:");
            foreach (var score in userData.Scores)
            {
                Console.WriteLine(score);
            }
        }
    }
}
