using CommandLine;
using CommandLine.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using word2vecLib;

namespace _2VecRunner
{
    class Program
    {
        static string path = @"Word2VectorOutputFile.bin";
        static Distance distance = null;
        static WordAnalogy wordAnalogy = null;

        static void Main(string[] args)
        {
            Options opt = new Options();
            if (args.Length > 0) {
                Parser.Default.ParseArguments(args, opt);
                Word2Vec w2v = new Word2Vec(opt);
                Console.WriteLine("Train Model: Y/N");
                string usr = Console.ReadLine().ToLower();
                if (usr == "y")
                    w2v.TrainModel();

                path = @"Vectors.bin";
                distance = new Distance(path);
                wordAnalogy = new WordAnalogy(path);

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("{0}\nPlease enter Word: ", new string('-', 50));
                    string input = Console.ReadLine();
                    Console.Clear();

                    distance.Search(input, 10);
                    wordAnalogy.Search(input, 10);
                    Console.ReadLine();
                }
        }
            else
            {
                Console.Out.WriteLine(GetUsage(opt));
            }
        }

        [HelpOption]
        public static string GetUsage(Options opt)
        {
            return HelpText.AutoBuild(opt,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(opt, current));
        }
    }
}
