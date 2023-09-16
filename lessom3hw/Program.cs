using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessom3hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите данные в формате:\n" +
                "Surname FirstName Patronymic DD/MM/YYYY PPPPPP G\n"+
                "где G может быть 'f' или 'm'");
            var data = Console.ReadLine();
            try
            {
                PersonDataWriter.WritePerson(data);
                Console.WriteLine("OK");
            }
            catch(IncorrectPersonDataExeption e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
