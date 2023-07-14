using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzaer
{
    public class moodanalyze
    {
        public static object createmoodanalyzer(string classname)
        {

            Assembly asm = Assembly.GetExecutingAssembly();

            Type moodanlyze = asm.GetType(classname);

            return Activator.CreateInstance(moodanlyze);


        }
    }
}
