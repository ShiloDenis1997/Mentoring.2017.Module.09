using System;
using Task2.NugetPackage;

namespace NugetPackageTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = BigIntegersListJsonReader.ReadFromJson("[12341234213421341234123412341234, 49823759348759324759325792345345]");
            foreach (var bigInteger in integers)
            {
                Console.WriteLine(bigInteger);
            }
        }
    }
}
