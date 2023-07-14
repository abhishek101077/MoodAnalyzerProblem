using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzaer
{
    public class UC3
    {
        string message;
        public UC3(string Message)
        {
            this.message = Message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.Exception_Type.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                else if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)  //Exception Handling
            {
                throw new CustomException(CustomException.Exception_Type.NULL_EXCEPTION, "Mood should not be NULL");
            }

        }
    }
}
