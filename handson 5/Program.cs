using System.Text.RegularExpressions;
using System;
public class Demo
{
   public static void Main()
    {
        string myStr; 
        string rev;
        string res2;
        Console.WriteLine("enter the string");
        myStr = Console.ReadLine();
        rev = "";
        
        string myStr2 = String.Copy(myStr);// copy the string to another variable
        res2 = myStr2.Substring(2);
        string res = myStr.Substring(1);//prints the char of string after the second position
        //now the replacing of the string starts from here
        string op = string.Empty;
        Regex rgx = new Regex("[^A-Za-z0-9]");
        for (int i = 0; i < myStr.Length; i++)
        {
            op += (rgx.IsMatch(myStr[i].ToString())) ? "$" : myStr[i].ToString();
        }
        // replacing of the string ends here
        // find string length
        int len;
        len = myStr.Length - 1;
        while (len >= 0)
        {
            rev = rev + myStr[len];
            len--;
        }

        Console.WriteLine("Reversed String is {0}", rev);
        Console.WriteLine("From the 2nd position is {0} ",res);
        Console.WriteLine("after the replacement of string by $ is {0} ",op);
        Console.WriteLine("After the modification in the position string is {0}", res2);
        Console.ReadLine();
    }
}
