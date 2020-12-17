using MyLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq.Data
{
    class Data
    {
        public List<Emplyee> Emplyees
        {
            get;
            set;
        }
        public Data()
        {
            Emplyees = new List<Emplyee>();
            InitializeSampleData();
        }

        private void InitializeSampleData()
        {
            string[] possibleNames = new string[] { "Dawid", "Mariola", "Maciej", "Zbigniew", "Katarzyna" };
            string[] possibleLastNames = new string[] { "Kowalski", "Nowak", "Pszczyński", "Wolski", "Murek" };

            string[] noteTitles = new string[] { "Meeting", "Cleaning", "Phone call" };
            string[] noteContents = new string[] { "Lorem ipsum dolor sit amet, consectuar..." };

            string[] jobTitles = new string[] { "Create project", "Create database", "Design database" };
            string[] jobDescriptions = new string[] { "Lorem ipsum dolor sit amet, consectuar..." };
       

          //  Emplyees = possibleNames.SelectMany(last)
        }
    }
}
