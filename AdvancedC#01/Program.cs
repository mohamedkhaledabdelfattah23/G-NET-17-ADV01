using System.Data;
using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdvancedC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Question01
            //A generic class is a class that can work with different data types using a type parameter(T). It allows writing reusable and type-safe code without duplication.

            //Why use generics:

            //            Code reusability
            //            Type safety (no casting needed)
            //            Better performance 
            #endregion


            // Question02 
            // Done


            #region Question03
            //Multiple type parameters allow a class to work with more than one data type.

            //// Pair<TKey , TValue>  Done 
            #endregion


            #region Question06
            //A generic interface defines operations that work with any data type.

            //Done. 
            #endregion


            #region Question07
            //The struct constraint restricts the type to value types only.

            //Done. 
            #endregion


            #region Question08
            //The class constraint restricts the type to reference types.

            //class MyClass<T> where T : class
            //{


            //} 
            #endregion

            #region Question09
            //The new() constraint requires a parameterless constructor.

            //class MyNewClass<T> where T : new()
            //{

            //    public T Create()
            //    {

            //        return new T();
            //    }

            //} 
            #endregion


            #region Question10
            //It restricts the type to implement a specific interface.

            //class MyInterfaceClass<T> where T : IDisposable
            //{


            //} 
            #endregion



            #region Question11
            //    It restricts the type to inherit from a specific base class.

            //class Animal 
            //{


            //}

            //class Dog : Animal 
            //{


            //}

            //class Test<T> where T : Animal
            //{


            //} 
            #endregion


            #region Question12
            //class Multi<T> where T : class, IDisposable, new()
            //{


            //} 
            #endregion

            #region Question13
            //The default keyword returns the default value of a type:

            //0 for numeric types
            //false for bool
            //null for reference types 
            #endregion


            #region Question14
            //Question14:
            //    Done. 
            #endregion

            #region Question15
            //Covariance allows using a more derived type than originally specified.
            //The out keyword is used when the type is only returned (output).

            //interface IProducer<out T>
            //{
            //   T Get();

            //} 
            #endregion


            #region Question16
            //Contravariance allows using a less derived type.
            //The in keyword is used when the type is only used as input.

            //interface IConsumer<in T>
            //{
            //     void Set(T item);


            //} 
            #endregion

            #region Question18
            //Static members are separate for each closed generic type.

            //class Test<T>
            //{
            //    public static int Count;


            //} 
            #endregion


            #region Question19
            //class Base<T>
            //{


            //}

            //class Derived<T> : Base<T>
            //{


            //} 
            #endregion





        }

        #region Question04
        //A generic method is a method that uses a type parameter to work with different data types.

        //static void Swap<T>(ref T a, ref T b)
        //{
        //    T temp = a;
        //    a = b;
        //    b = temp;
        //} 
        #endregion


        #region Question05
        //public static T FindMax<T>(T a, T b) where T : IComparable<T>
        //{


        //    return a.CompareTo(b) > 0 ?  a  :  b;

        //} 
        #endregion







    }


}
