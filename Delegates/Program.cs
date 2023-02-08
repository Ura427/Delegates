using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Creating delaegate
    public delegate void MyDelegate(bool a, bool b);


    //Class with methods that represent logical operations
    public class LogicalOperations
    {
        public static void InitialParameters(bool P, bool Q) => Console.WriteLine($"P: {P}\tQ: {Q}");
        public static void AND(bool P, bool Q) => Console.WriteLine("AND: " + (P && Q));

        public static void OR(bool P, bool Q) => Console.WriteLine("OR: " + (P || Q));

        public static void XOR(bool P, bool Q) => Console.WriteLine("XOR: " + ((P || Q) && !(P && Q)));

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("////////// Working with delegate ///////////");
            Console.WriteLine();
            //initial parameters
            bool P = true;
            bool Q = false;

            //Creating object type delegate and assigning static method from LogicalOperations class
            MyDelegate myDelegate = new MyDelegate(LogicalOperations.InitialParameters);
            //Assigning additional methods to delegate
            myDelegate += LogicalOperations.AND;
            myDelegate += LogicalOperations.OR;
            myDelegate += LogicalOperations.XOR;

            //invoke delegate
            myDelegate(P, Q);

            Console.WriteLine("/////////// Working with Action delegate //////////");
            Console.WriteLine();
            P = true;
            Q = true;

            //Creating object type Action delegate and assigning static method from LogicalOperations class
            Action<bool, bool> myAction = new Action<bool, bool>
                (LogicalOperations.InitialParameters);
            //Assigning additional methods to Action delegate
            myAction += LogicalOperations.AND;
            myAction += LogicalOperations.OR;
            myAction += LogicalOperations.XOR;

            //Invoke Action delegate
            myAction(P, Q);

            Console.ReadLine();
        }
    }
}
