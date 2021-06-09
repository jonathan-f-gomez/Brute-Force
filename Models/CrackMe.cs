using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brute_Force.Models
{
    public class CrackMe
    {
        static char[] CharArray ={'0','1','2','3','4','5','6','7','8','9',
                              'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                              'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                              '~','!', '@', '#','$','%','^','&','*','(',')','_','+','{','}',';','"','|','<','>','?','`','-','=','[',']',';','\\',',','.','/'};
        
        
        public static DateTime StartTime;
        public static DateTime EndTime;
        public static int Combinations;

        static bool passwordsMatch;
        public string? EnteredPassword { get; set; } = null; 
        

        
        public CrackMe StartMe(CrackMe cM)
        {
            string enteredPassword = cM.EnteredPassword;
            StartTime = DateTime.Now;
            
            Combinations = 0;
            passwordsMatch = false;
            for (int passwordLength = 0; passwordLength <= 15; passwordLength++)
            {
                Recurse(passwordLength, 0, "", enteredPassword);                
                if (passwordsMatch == true) break;
            }
            return cM;  
        }

        static void Recurse(int passwordLength, int currPosition, string guessPassword, string enteredPassword)
        {
            for (int i = 0; i < CharArray.Length; i++)
            {
                Combinations++;
                if (currPosition < passwordLength)
                {
                    Recurse(passwordLength, currPosition + 1, guessPassword + CharArray[i], enteredPassword);
                }
                if (guessPassword + CharArray[i] == enteredPassword)
                {                       
                    EndTime = DateTime.Now;
                    passwordsMatch = true;
                    break;
                }
                if (passwordsMatch == true) break;
            }
        }
    }
}
