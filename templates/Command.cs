using System;
using McMaster.Extensions.CommandLineUtils;

namespace CommandLineUtilsTemplate
{
    class Command
    {
        [Argument(0)]
        string Argument { get; set; }

        [Option]
        string Option { get; set; }

        void OnExecute()
        {
            Console.WriteLine($"subcommand arg:{this.Argument} op:{this.Option}");
        }
    }
}