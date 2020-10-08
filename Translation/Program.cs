using System;

namespace Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taking in inputs and declaring variables
            Console.Write("Enter length of room:");
            int length = Int32.Parse(Console.ReadLine());

            Console.Write("Enter width of room:");
            int width = Int32.Parse(Console.ReadLine());

            Console.Write("Enter length of unused space:");
            int unusedSpaceLength = Int32.Parse(Console.ReadLine());

            Console.Write("Enter width of unused space:");
            int unusedSpaceWidth = Int32.Parse(Console.ReadLine());

            //calculates the area using length and width 

            int area = length * width;

            int unusedSpace = unusedSpaceLength * unusedSpaceWidth;

            area = area - unusedSpace;

            //declare the variable and assign the results of the calculation

            int litresNeeded = area / 11; //meters^2 per litre

            // Ouptut the string and append the value stored in the variable

            Console.WriteLine("Litres needed: " + litresNeeded);
            Console.ReadKey();



         //===========================================================================
        



            /*    'W1 Q1 Paint Litres Needed
        'Declare variables as type integer and then assign the values returned from the input box

        Dim length As Integer = InputBox("Enter length of room")
        Dim width As Integer = InputBox("Enter width of room")
        Dim unusedSpaceLength As Integer = InputBox("Enter lenth of unused space")
        Dim unusedSpaceWidth As Integer = InputBox("Enter width of unused space")
        Dim area As Integer = length * width
        Dim unsuedSpace As Integer = unusedSpaceLength * unusedSpaceWidth
        area = area - unsuedSpace

        'declare the variable and assign the results of the calculation
        Dim litresNeeded = area / 11 'meters squared /Litre

        'Ouptut the string and append the value stored in the variable
        MsgBox("Litres needed: " & litresNeeded)

*/

        }
    }
}
