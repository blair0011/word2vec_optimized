using System;
using CommandLine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word2vecLib
{
    public class Options
    {
        // -train <file> Use text data from <file> to train the model
        string train = "Corpus.txt";

        // -output <file> Use <file> to save the resulting word vectors / word clusters
        string output = "Vectors.bin";

        // -save-vocab <file> The vocabulary will be saved to <file>
        string savevocab = "";

        // -read-vocab <file> The vocabulary will be read from <file>, not constructed from the training data
        string readvocab = "";

        // -size <int> Set size of word vectors; default is 100
        int size = 100;

        // -debug <int> Set the debug mode (default = 2 = more info during training)
        int debug = 2;

        // -binary <int> Save the resulting vectors in binary moded; default is 0 (off)
        int binary = 1;

        // -cbow <int> Use the continuous bag of words model; default is 1 (use 0 for skip-gram model)
        int cbow = 1;

        // -alpha <float> Set the starting learning rate; default is 0.025 for skip-gram and 0.05 for CBOW
        float alpha = 0.05f;

        // -sample <float> Set threshold for occurrence of words. Those that appear with higher frequency in the training data
        float sample = 1e-4f;

        // -hs <int> Use Hierarchical Softmax; default is 0 (not used)
        int hs = 0;

        // -negative <int> Number of negative examples; default is 5, common values are 3 - 10 (0 = not used)
        int negative = 25;

        // -threads <int> Use <int> threads (default 12)
        int threads = 12;

        // -iter <int> Run more training iterations (default 5)
        long iter = 15;

        // -min-count <int> This will discard words that appear less than <int> times; default is 5
        int mincount = 5;

        // -classes <int> Output word classes rather than word vectors; default number of classes is 0 (vectors are written)
        long classes = 0;

        // -window <int> Set max skip length between words; default is 5
        int window = 12;

        [Option("doc2vec", DefaultValue = false, HelpText = "-doc2vec selects the doc2vec version of word2vec")]
        public bool doc2vec { get; set; }

        [Option('t', "train", HelpText = "-train <file> Use text data from <file> to train the model")]
        public string Train { get => train; set => train = value; }

        [Option('o', "output", HelpText = "-output <file> Use <file> to save the resulting word vectors / word clusters")]
        public string Output { get => output; set => output = value; }

        [Option('s', "save", HelpText = "-save-vocab <file> The vocabulary will be saved to <file>")]
        public string Savevocab { get => savevocab; set => savevocab = value; }

        [Option('r', "read-vocab", HelpText = "-read-vocab <file> The vocabulary will be read from <file>, not constructed from the training data")]
        public string Readvocab { get => readvocab; set => readvocab = value; }

        [Option("size", HelpText = "-size <int> Set size of word vectors; default is 100")]
        public int Size { get => size; set => size = value; }

        [Option('d', "debug", HelpText = "-debug <int> Set the debug mode (default = 2 = more info during training)")]
        public int Debug { get => debug; set => debug = value; }

        [Option('b', "binary", HelpText = "-binary <int> Save the resulting vectors in binary moded; default is 0 (off)")]
        public int Binary { get => binary; set => binary = value; }

        [Option('c', "cbow", HelpText = "-cbow <int> Use the continuous bag of words model; default is 1 (use 0 for skip-gram model)")]
        public int Cbow { get => cbow; set => cbow = value; }

        [Option('a', "alpha", HelpText = "-alpha <float> Set the starting learning rate; default is 0.025 for skip-gram and 0.05 for CBOW")]
        public float Alpha { get => alpha; set => alpha = value; }

        [Option("sample", HelpText = "-sample <float> Set threshold for occurrence of words. Those that appear with higher frequency in the training data")]
        public float Sample { get => sample; set => sample = value; }

        [Option("hs", HelpText = "-hs <int> Use Hierarchical Softmax; default is 0 (not used)")]
        public int Hs { get => hs; set => hs = value; }

        [Option('n', "negative", HelpText = "-negative <int> Number of negative examples; default is 5, common values are 3 - 10 (0 = not used)")]
        public int Negative { get => negative; set => negative = value; }

        [Option('t', "thread", HelpText = "-threads <int> Use <int> threads (default 12)")]
        public int Threads { get => threads; set => threads = value; }

        [Option('i', "iter", HelpText = "-iter <int> Run more training iterations (default 5)")]
        public long Iter { get => iter; set => iter = value; }

        [Option('m', "min-count", HelpText = "-min-count <int> This will discard words that appear less than <int> times; default is 5")]
        public int Mincount { get => mincount; set => mincount = value; }

        [Option("classes", HelpText = "-classes <int> Output word classes rather than word vectors; default number of classes is 0 (vectors are written)")]
        public long Classes { get => classes; set => classes = value; }

        [Option('w', "window", HelpText = "-window <int> Set max skip length between words; default is 5")]
        public int Window { get => window; set => window = value; }
    }
}
