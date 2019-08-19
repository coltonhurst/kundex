using System;

namespace kundex
{
    class Program
    {
        static void Main(string[] args)
        {
            SiteBuilder sb;

            /*
                determine the source & destination path based on the number of 
                command line arguments passed

                Arg1 -> source folder path
                Arg2 -> destination path
            */
            if (args.Length < 1) {
                Console.WriteLine("kundex: the source path is required");
            }
            sb = new SiteBuilder(args[0], args.Length >= 2 ? args[1] : "");

            // testing command line args
            Console.WriteLine(sb.GetSourcePath() + "\n" + sb.GetDestinationPath());

            // build the site
            if (sb.Build()) {
                Console.WriteLine("kundex: build successful!");
            } else {
                Console.WriteLine("kundex: ERROR! build failed.");
                Console.WriteLine(sb.GetError());
            }
        }
    }
}