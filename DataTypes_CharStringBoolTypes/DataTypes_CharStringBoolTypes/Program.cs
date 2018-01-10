using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = Char.MinValue;
            int charMax = Char.MaxValue;
            char myVar = 'G';
            int myVarValue1 = 'G';
            int myvarValue2 = 'I';
            char myVarValue3 = Convert.ToChar(myVar);
            char myVarValue4 = Convert.ToChar(71);
            Console.WriteLine("Min Char = {0}\nMax Char = {1}\nMy Charcter = {2} \nMy Variable Number = {3} \nMy Variable Number = {4}"
                                , charMin, charMax , myVar , myVarValue1 , myvarValue2);
            Console.WriteLine("My conversion value = {0} ",myVarValue3);
            Console.WriteLine("My conversion value = {0} ", myVarValue4);

  
            string myString = "this is my variable";
            Console.WriteLine("My string is {0}",myString);

            bool myBool = true;
            Console.WriteLine("My boolean is {0}", myBool);

            //------------ TP ------------------

            // Q1 - Define a variable that can accept  the 'A' Character value and print that number value on the console screen
            char myCharVar = 'A';
            int myCharVarValue = Convert.ToChar(myCharVar);
            Console.WriteLine("My Number Value = {0}", myCharVarValue);

            //Q2 - Define a variable that can accept  the 'A' Character value and print that number value on the console screen
            char myCharVar2 = 'a';
            int myCharVarValue2 = Convert.ToChar(myCharVar2);
            Console.WriteLine("My Number Value = {0}", myCharVarValue2);

            //Q3 - Define a string variable and assign the statement  "this is my my Character A value , and print the variables in this form :
            //     this is my my Character A value  # and this is my my Character a value
            string myString2 = "this is my my Character A value";
            string myString3 = "this is my my Character a value";
            Console.WriteLine("this is my my Character A value :{0},this is my my Character a value :{1}", myString2, myString3);




            Console.WriteLine(myString3);




            Console.ReadKey();

        }
    }
}
