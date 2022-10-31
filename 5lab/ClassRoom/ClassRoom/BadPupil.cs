using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class BadPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Я не люблю читати.");
        }
        public override void Relax()
        {
            Console.WriteLine("Я люблю розваги");
        }
        public override void Study()
        {
            Console.WriteLine("Я не люблю навчатися");
        }
        public override void Write()
        {
            Console.WriteLine("Я погано знаю граматику");
        }
    }
}
