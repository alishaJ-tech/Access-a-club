using System;

namespace clubInvite
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize vars
            int susanAge, christianaAge, jaelAge;

            //susan
            Console.WriteLine("How old are you Susan?: ");
            susanAge = int.Parse(Console.ReadLine());
            
            // now applying conditional statement
            if(susanAge>=18){
                Console.WriteLine("You are allowed into the club. Have FUN!!!!");
            }
           
            else{
                Console.WriteLine("Sorry you can't enter the club unit you are 18.\r\nUntil then, BYE!");
            }

            //christiana
            Console.WriteLine("How old are you Christian?: ");
            christianaAge = int.Parse(Console.ReadLine());

            // now applying conditional statement
            if(christianaAge>=18){
                Console.WriteLine("You are allowed into the club. Have FUN!!!!");
            }
           
            else{
                Console.WriteLine("Sorry you can't enter the club unit you are 18.\r\nUntil then, BYE!");
            }

            //joel
            Console.WriteLine("How old are you Jael?: ");
            jaelAge = int.Parse(Console.ReadLine());
            
            // now applying conditional statement
            if(jaelAge>=18){
                Console.WriteLine("You are allowed into the club. Have FUN!!!!");
            }
           
            else{
                Console.WriteLine("Sorry you can't enter the club unit you are 18.\r\nUntil then, BYE!");
            }

        }
    }
}
