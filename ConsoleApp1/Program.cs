using System;
using ClassLibrary1;
using System.Reflection;

public class MagicClass
{
    private int magicBaseValue;

    public MagicClass()
    {
        magicBaseValue = 9;
    }

    public int ItsMagic(int preMagic)
    {
        return preMagic * magicBaseValue;
    }
}
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type magicType = Type.GetType("MagicClass");
            ConstructorInfo magicConstructor = magicType.GetConstructor(Type.EmptyTypes);
            object magicClassObject = magicConstructor.Invoke(new object[]{});

            // Get the ItsMagic method and invoke with a parameter value of 100

            MethodInfo magicMethod = magicType.GetMethod("ItsMagic");
            object magicValue = magicMethod.Invoke(magicClassObject, new object[]{100});

            Console.WriteLine("MethodInfo.Invoke() Example\n");
            Console.WriteLine("MagicClass.ItsMagic() returned: {0}", magicValue);
        }
    }
}