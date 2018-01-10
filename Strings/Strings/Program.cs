using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //string mySentence = "Please go to a new  \n  line?";

            //string mySentence = "My  \"pretty wife\";

            //string mySentence = string.Format("{0}!", "i live in Morocco");  
              
            //string mySentence = string.Format("{0:C}", 240.25);  
                   
            //string mySentence = string.Format("{0:N}", 1234567);

            //string mySentence = string.Format("{0:P}", .575);            


            //------------------------------------
           
              
               string mySentence = "";
               for (int i = 0; i < 50 ; i++)                                                                                        
                 {                                                                                      
                    // mySentence = mySentence+ "--" +i.ToString();
                        mySentence += "- " + i.ToString(); 
                  } 
                                                                                                        
       


            //------------------------------------

                           
          
                       


            Console.WriteLine(mySentence);
            Console.ReadKey();
        }
    }
}
