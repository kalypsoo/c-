using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pupil : Person
    {
        private int grade;
        internal List<Activity> LstActivities;
        
        private char[] TabEval;

        public Pupil (String name, int age, int grade) : base(name,age)
         {
             Grade = grade;
             LstActivities = new List<Activity>();
             TabEval = new char [Parameter.DIX];
         }

        public Pupil(String name, int age)  : this(name, age, 1)
        { 
        }
        public int Grade  
        {
            get { return grade; }
            set { grade = (value > 0) ? value : 1; }
        }

        public void AddActivity(Activity act)
        {
            if (LstActivities.Count < Parameter.DIX)
                LstActivities.Add(act);
        }

        public override string ToString()
        {
            string ch = base.ToString() + ((LstActivities.Count()!=0)? "a choisi ..." : "n’a pas encore choisi d’activité");

            for (int i = 0; i < LstActivities.Count(); i++)
                ch += " "+LstActivities.ElementAt(i);
            return ch;             
        }
        public void AddEvaluation ( String title = null, char evaluation = (char)Parameter.Cote.Satisfaisant) 
        {
             int i=0;
             if (title != null)
             {
                 foreach(Activity activity in LstActivities) // autre manière de parcourir la liste
                 { 
                    if(activity.Title.Equals(title)) break ;
                    i++;
                         }
                TabEval[i]=evaluation ;
            }
        }

        /*public char GetEvaluationFor(String intitule)
        {
            int i = 0;
            foreach(Activity activity in LstActivities)
            { 
                    if(activity.Title.Equals(intitule)) break ;
                    i++;
            }
            return TabEval[i];
            
        }*/
        public char GetEvaluationFor(String intitule)
        {
            int i = 0;
            foreach (Activity activity in LstActivities)
            {
                if (activity.Title.Equals(intitule)) break;
                i++;
            }
            if (i == LstActivities.Count)
                throw new KeyNotFoundException();
            else
                return TabEval[i];

        }



    }
}
