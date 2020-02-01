using simple_text_mining_library;
using simple_text_mining_library.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace TextAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"E:\RPA Calculator\TextAnalysis\TextAnalysis\SampleBooks\");
            string sampleInputText = "Hello Jimmy";//File.ReadAllText(filePath);

            MineText mineText = new MineText();
            mineText.textMiningLanguage = TextMiningLanguage.English;

            string a = mineText.RemoveSpecialCharacters(sampleInputText, true);
            string b = mineText.RemoveSpecialCharacters(sampleInputText, false);
            string c = sampleInputText;

            string d = mineText.RemoveStopWordsFromText(a);

            List<string> e = mineText.N1GramAnalysis(d);
            List<string> f = mineText.N2GramAnalysis(d);
            List<string> g = mineText.N3GramAnalysis(d);
            List<string> h = mineText.N4GramAnalysis(d);
            List<string> i = mineText.N5GramAnalysis(d);

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
        }
    }
}
