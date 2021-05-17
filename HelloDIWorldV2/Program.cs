using System;

namespace HelloDIWorldV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string command1;
            Console.WriteLine("v^v online");
            Console.WriteLine("1");

            for (int i = 2; i < 100; i++)
            {
                
                command1 = Console.ReadLine();
                switch (command1)
                {
                    //language
                    case "hello":       Console.WriteLine("world!");break;
                    case "let":         Console.WriteLine("it be");break;
                    case "relax":       Console.WriteLine("and float downstream"); break;
                    case "amazon":      Console.WriteLine("Built book selling website. Perfected the art of keeping the heavy traffic of the website. Sold this knowledge to other companies. AWS. Through the 90's the web team was devoted to making the website run fast and not go down. They became so good they sold the system. Target wanted to get into e-commerce. So they built them a store."); break;
                    case "encourage":   Console.WriteLine("don't be afraid to show off, more than enough to pull this off");  break;
                    //language
                






























                   
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        
                        /*key, value
                    case "key":       Console.WriteLine("value"); break;
                    how many pairs are there? 
                    add one 
                    the variable is concatonated "key" + "{n+1}"
                    or the variable is named from the string, with the spaced removed
                    user enters "voice gem encouragement" and the variable is string minus spaced "voicegemencouragement" with the vale being the folling text
                    have the app take this string from readline Command1 and make a string out of it. So 
                    */








                    //DEFAULT 
                    default:
                        Console.WriteLine("err: type 'hello', 'let', or 'relax' ");
                        break;
                }
                Console.WriteLine("{0}", i);
            }
        }
    }
}
