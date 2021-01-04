using System;
using System.Security.Principal;

namespace ExplicitInterfaces_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] token = input.Split();

                Citizen citizen = new Citizen(token[0], token[1], int.Parse(token[2]));
                Console.WriteLine(citizen.GetName());
                Console.WriteLine((citizen as IResident).GetName());

                input = Console.ReadLine();
            }
        }
    }
}
/*Explicit Interfaces
Create 2 interfaces IResident and IPerson. IResident should have a name, country and a method 
GetName(). IPerson should have a name, an age and a method GetName(). Create a class Citizen 
which implements both IResident and IPerson, explicitly declare that IResident’s GetName() 
method should return "Mr/Ms/Mrs " before the name while IPerson’s GetName() method should 
return just the name. You will receive lines of Citizen information from the console until 
the command "End" is received. Each will be in the format "<name> <country> <age>" for each
line create the corresponding Citizen and print his IPerson’s GetName() and his IResitent’s
GetName().
Examples
Input	Output
PeshoPeshev Bulgaria 20
End	

    Output
PeshoPeshev
Mr/Ms/Mrs PeshoPeshev

    Input
JoroJorev Bulgaria 33
EricAnderson GreatBritain 28
PeterArmstrong USA 19
End	

    Output
JoroJorev
Mr/Ms/Mrs JoroJorev
EricAnderson
Mr/Ms/Mrs EricAnderson
PeterArmstrong
Mr/Ms/Mrs PeterArmstrong

Hint
Check online about Explicit Interface Implementation.
*/
