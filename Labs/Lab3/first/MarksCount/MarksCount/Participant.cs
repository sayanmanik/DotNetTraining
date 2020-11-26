using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksCount
{
    class Participant
    {
        private int empId;
        private string name;
        private static string compnayName;
        private int foundationMarks;
        private int webBasicMarks;
        private int dotNetMarks;
        private static int totalMarks;
        private int obtainedMarks;
        double percentage;

        public Participant()
        {
            totalMarks = 300;
        }

        public Participant(int id,string name,int foundationMarks, int webBasicMarks,int dotNetMarks)
        {
            this.empId = id;
            this.name = name;
            this.foundationMarks = foundationMarks;
            this.webBasicMarks = webBasicMarks;
            this.dotNetMarks = dotNetMarks;
        }

        static Participant()
        {
            compnayName = "Corporate University";
            totalMarks = 300;

        }

        public int total()
        {
            obtainedMarks = foundationMarks + webBasicMarks + dotNetMarks;
            return obtainedMarks;
        }


        public double percentageMarks()
        {
            percentage =  (foundationMarks + webBasicMarks + dotNetMarks) * 100 / totalMarks;
            return percentage;
        }


    }
}
