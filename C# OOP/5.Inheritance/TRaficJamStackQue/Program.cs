using System;
using System.Collections.Generic;

namespace TRaficJamStackQue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            int counter = 0;

            uint n = uint.Parse(Console.ReadLine());
            List<string> cars = new List<string>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if(command != "green")
                {

                    queue.Enqueue(command);
                }
                else
                {

                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            string carDeque = queue.Dequeue();
                            cars.Add(carDeque);
                            counter++;
                        }
                        
                    }
                }
                command = Console.ReadLine();
            }
            foreach(var car in cars)
            {
                Console.WriteLine(car + " passed!");
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
/*
 * 8. Traffic Jam
Create a program that simulates the queue that forms during a traffic jam. During a traffic jam only N cars can pass
the crossroads when the light goes green. Then the program reads the vehicles that arrive one by one and adds
them to the queue. When the light goes green N number of cars pass the crossroads and for each a message &quot;{car}

© SoftUni – about.softuni.bg. Copyrighted document. Unauthorized copy, reproduction or use is not permitted.
Follow us: Page 1 of 1
passed!&quot; is displayed. When the &quot;end&quot; command is given, terminate the program and display a message with the
total number of cars that passed the crossroads.
Input
On the first line you will receive N – the number of cars that can pass during a green light
 On the next lines, until the &quot;end&quot; command is given, you will receive commands – a single string, either a
car or &quot;green&quot;
Output
 Every time the &quot;green&quot; command is given, print out a message for every car that passes the crossroads in
the format &quot;{car} passed!&quot;
 When the &quot;end&quot; command is given, print out a message in the format &quot;{number of cars} cars passed the
crossroads.&quot;
Examples
Input Output
4
Hummer H2
Audi
Lada
Tesla
Renault
Trabant
Mercedes
MAN Truck
green
green
Tesla
Renault
Trabant
end

    Output
Hummer H2 passed!
Audi passed!
Lada passed!
Tesla passed!
Renault passed!
Trabant passed!
Mercedes passed!
MAN Truck passed!
8 cars passed the crossroads.

    Input
3
Enzo&#39;s car
Jade&#39;s car
Mercedes CLS
Audi
green
BMW X5
green
end

    Output
Enzo&#39;s car passed!
Jade&#39;s car passed!
Mercedes CLS passed!
Audi passed!
BMW X5 passed!
5 cars passed the crossroads.

    */

