using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TypeLibrary;

namespace DynamicInvestigation
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic nonPublicThisAssembly = Activator.CreateInstance(typeof(NonPublicType));
            dynamic publicThisAssembly = Activator.CreateInstance(typeof(PublicType));
            dynamic nonPublicOtherAssembly = Activator.CreateInstance(Type.GetType("TypeLibrary.NonPublicTypeOtherAssembly, TypeLibrary"));
            dynamic publicOtherAssembly = Activator.CreateInstance(typeof(PublicTypeOtherAssembly));

            PrintType(nonPublicThisAssembly);
            PrintType(publicThisAssembly);
            PrintType(nonPublicOtherAssembly);
            PrintType(publicOtherAssembly);
            Console.Read();
        }

        static void PrintType<T>(T instance)
        {
            Console.WriteLine(typeof(T));
        }
    }
}
