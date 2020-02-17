using System;
public class ModuleB
{
    public static void FunctionB()
    {
        int res = ModuleA.FuntionA(1, 2);
        Console.WriteLine(res);

        // modified
    }
}