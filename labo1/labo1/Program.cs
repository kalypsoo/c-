using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace labo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil etu1 = new Pupil("Oli", 20, 1);
            etu1.AddActivity(new Activity("fr", true));
            etu1.AddActivity(new Activity("math", false));
            etu1.AddActivity(new Activity("eco", true));
            etu1.AddActivity(new Activity("pp", true));
            etu1.AddActivity(new Activity("oed", false));
            etu1.AddEvaluation("fr",'S');

            List<Pupil> lstPupil = new List<Pupil>()
            {
                new Pupil("Ghislain",20,1),
                new Pupil("Francois",26,1),
                new Pupil("boul",5,1),
            };


            //var pupilGrade1Plus6 = from pupil in lstPupil
            //                       where pupil.Age > 6 && pupil.Grade >= 1
            //                       select pupil;
            var pupilGrade1Plus6 = lstPupil.Where(pupil => pupil.Age > 6 && pupil.Grade == 1);

            if (pupilGrade1Plus6 != null)
            {               
                foreach (var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(pupil);
                    System.Console.Write('\n');
                }
            }

            System.Console.Write(etu1);
            System.Console.Read(); 
            
        }
           
    }
}
