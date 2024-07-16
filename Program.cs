using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf('.'); //returns dot index
            var extension = path.Substring(dotIndex); //returns extension

            Console.WriteLine("Extension: " + Path.GetExtension(path)); 
            //returns .sln
            Console.WriteLine("File Name: " + Path.GetFileName(path)); 
            //returns HelloWorld.sln
            Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(path)); 
            //returns HelloWorld
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path)); 
            //returns C:\Projects\CSharpFundamentals\HelloWorld

        }
    }
}