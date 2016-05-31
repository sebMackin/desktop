using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_160531_CSharpTest
{

    class Global
    {

        public static ArrayList list = new ArrayList();
    }

    class Program : Global
    {
        static void Main(string[] args)
        {
            
            addList();
        }


        static void addList()
        {

            string finished = "n";

            do
            {

                Console.WriteLine("Enter a number:");
                string answer = Console.ReadLine();

                int number = Convert.ToInt32(answer);

                list.Add(number);

                Console.WriteLine("Finished adding? y/n");
                finished = Console.ReadLine();

            } while (!finished.Equals("y"));

            displayAsk(list);
        }

        static void displayAsk(ArrayList List)
        {

            Console.WriteLine("Display list? y/n");
            string answer = Console.ReadLine();

            if (answer.Equals("n"))
            {

                addList();
            }
            else
            {
                Console.WriteLine("Finished List:");

                for (int i = 0; i <= List.Count - 1; i++)
                {

                    object o = List[i];

                    Console.WriteLine(o);
                }

                Console.Read();
            }
        }
    }
}
