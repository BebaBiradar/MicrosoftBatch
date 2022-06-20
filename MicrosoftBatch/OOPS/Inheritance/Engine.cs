using System;
using System.Collections.Generic;
using System.Text;

namespace MicrosoftBatch.OOPS.Inheritance
{
    class SubEngine
    {
        string cleanupDept;
        public SubEngine(string cleanupDept)
        {
            this.cleanupDept = cleanupDept;
        }
        public void DisplaySubEngine()
        {
            Console.WriteLine(cleanupDept);
        }
    }

    class Engine
    {
        string type;
        SubEngine sub;
        public Engine(string type,SubEngine sub)
        {
            this.type = type;
            this.sub = sub;
        }
        public void DisplayEngine()
        {
            Console.WriteLine(type + " ");
            sub.DisplaySubEngine();

        }
    }
}
