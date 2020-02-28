using System;
using McMaster.Extensions.CommandLineUtils;

namespace CommandLineUtilsTemplate
{
    [Subcommand(typeof(Command))]
    class Program
    {
        static int Main(string[] args)
            => CommandLineApplication.Execute<Program>(args);

        void OnExecute()
        {
            Console.WriteLine("rootcommand");
        }
    }
}
