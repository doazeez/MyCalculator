using System;

namespace ClassLibrary1
{
    public class Validation
    {
       
        public string NumberChecker(string number)
        {
            return double.TryParse(number, out _) == true ? number.Trim() : "Invalid input";  
        }
        
    }
}
