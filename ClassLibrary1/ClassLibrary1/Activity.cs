using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Activity
    {
        private String title;
        private Boolean IsCompulsory;

        public String Title 
        { 
            get; 
            set; 
        }


        public Boolean isCompulsory 
        { 
            get; 
            set; 
        }
        public Activity(String title,Boolean isCompulsory)
        {
            if (String.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("title");
            }
            Title = title;
            IsCompulsory = isCompulsory;
        }

        public override string ToString()
        {
            return (isCompulsory) ? Title+" (obligatoire)" : Title;
        }
    }



}
