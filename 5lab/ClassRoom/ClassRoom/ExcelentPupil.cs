using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class ExcelentPupil : Pupil
    {

        public override void Read()
        {
            Console.WriteLine("Я багато читаю");
        }

        public override void Study()
        {
            Console.WriteLine("Я найкращий в группi");
        }

        public override void Relax()
        {
            Console.WriteLine("Я рiдко вiдпочиваю");
        }

        public override void Write()
        {
            Console.WriteLine("Я бездоганно пишу");
        }
    }
}