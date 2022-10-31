using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Я непогано читаю");
        }
        public override void Relax()
        {
            Console.WriteLine("Менi подобається проводити час за моїм хоббi");
            Console.WriteLine("Я часто роблю щось нове");
        }

        public override void Study()
        {
            Console.WriteLine("Я непогано вчуся");
            Console.WriteLine("За навчанням я вище середнього в группi ");
        }

        public override void Write()
        {
            Console.WriteLine("В мене хорошi навички в граматицi");
        }
    }
}