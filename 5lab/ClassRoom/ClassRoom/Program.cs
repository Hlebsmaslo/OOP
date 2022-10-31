using System;
using System.Collections.Generic;
using System.Text;


namespace ClassRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil excelentPupil = new ExcelentPupil();
            BadPupil badPupil = new BadPupil();
            BadPupil goodPupil2 = new BadPupil();
            GoodPupil goodPupil = new GoodPupil();
            List<Pupil> pupils = new List<Pupil>();

            pupils.Add(excelentPupil);
            pupils.Add(goodPupil);
            pupils.Add(goodPupil2);
            pupils.Add(badPupil);

            ClassRoom classRoom = new ClassRoom(pupils);
            classRoom.infr();
        }
    }
}