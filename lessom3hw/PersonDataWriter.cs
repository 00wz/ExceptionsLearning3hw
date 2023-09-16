using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessom3hw
{
    class PersonDataWriter
    {
        /// <summary>
        /// Wrute data to file "surname.txt"
        /// </summary>
        /// <param name="data">string in the format of "Surname FirstName Patronymic DD/MM/YYYY PPPPPP G"</param>
        public static void WritePerson(string data)
        {
            var _data=data.Split(' ');
            if (_data.Length != 6)
                throw new IncorrectPersonDataExeption("incorrect data length");
            if(!DateTime.TryParse(_data[3],out _))
                throw new IncorrectPersonDataExeption("incorrect birthday format");
            if (!uint.TryParse(_data[4], out _))
                throw new IncorrectPersonDataExeption("incorrect phone number format");
            if (!_data[5].Equals("f") && !_data[5].Equals("m"))
                throw new IncorrectPersonDataExeption("gender field can be \"f\" or \"m\" only");

            using (var fw = new StreamWriter(_data[0] + ".txt", true))
            {
                fw.WriteLine(data);
            }
        }
    }
}
