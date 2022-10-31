using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class ClassRoom
    {
        List<Pupil> pupils1 = new List<Pupil>();
        public ClassRoom(List<Pupil> pupils)
        {
            pupils1 = pupils;
        }
        public void AddPupil(Pupil pupil)
        {
            pupils1.Add(pupil);
        }
        public void infr()
        {
            foreach (Pupil a in pupils1)
            {
                if (a != null)
                {
                    a.Study();
                    a.Write();
                    a.Read();
                    a.Relax();
                }
            }
        }
    }
}