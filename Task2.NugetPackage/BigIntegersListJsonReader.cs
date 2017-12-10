using System.Collections.Generic;
using System.Numerics;
using Newtonsoft.Json;

namespace Task2.NugetPackage
{
    public static class BigIntegersListJsonReader
    {
        public static List<BigInteger> ReadFromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<List<BigInteger>>(jsonString);
        }
    }
}
