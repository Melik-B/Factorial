using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    public class Logo
    {
        public static void WriteLogo()
        {
            string logo = @"  _____      _       ____   _____    ___    ____    _[]      _      _     
 |  ___|    / \     / ___| |_   _|  / _ \  |  _ \  |_ _|    / \    | |    
 | |_      / _ \   | |       | |   | | | | | |_) |  | |    / _ \   | |    
 |  _|    / ___ \  | |___    | |   | |_| | |  _ <   | |   / ___ \  | |___ 
 |_|     /_/   \_\  \____|   |_|    \___/  |_| \_\ |___| /_/   \_\ |_____|
                                                                          ";
            Console.WriteLine(logo);
        }
    }
}
