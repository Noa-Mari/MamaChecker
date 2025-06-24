using System;
using System.IO;
using MamaChecker;

TestCase[] cases = new TestCase[]
        {
            new TestCase
            {
                Textname = "Test_1",

                IsPassed = false
            }
        };

MamaSerializer mamaSerializer = new MamaSerializer();
MamaTestRunner mamaTestRunner = new MamaTestRunner();

Stream stream = mamaSerializer.Serialize(cases);
TestCase[] DeserializeCases = mamaTestRunner.Deserialize<TestCase>(stream);

 Console.WriteLine("\n--- Restored from XML ---");
foreach (TestCase test in DeserializeCases)
{
           Console.WriteLine($"{test.Textname},{test.IsPassed}");
}


