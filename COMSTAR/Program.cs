using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMSTAR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(HugeHeader());

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static string HugeHeader()
        {
            return (
                "                                                            ,----,                                 \n" +
                "               ,----..             ____                   ,/   .`|                                 \n" +
                "  ,----..     /   /   \\          ,'  , `.  .--.--.      ,`   .'  : ,---,       ,-.----.           \n" +
                " /   /   \\   /   .     :      ,-+-,.' _ | /  /    '.  ;    ;     /'  .' \\      \\    /  \\       \n" +
                "|   :     : .   /   ;.  \\  ,-+-. ;   , |||  :  /`. /.'___,/    ,'/  ;    '.    ;   :    \\        \n" +
                ".   |  ;. /.   ;   /  ` ; ,--.'|'   |  ;|;  |  |--` |    :     |:  :       \\   |   | .\\ :        \n" +
                ".   ; /--` ;   |  ; \\ ; ||   |  ,', |  ':|  :  ;_   ;    |.';  ;:  |   /\\   \\  .   : |: |       \n" +
                ";   | ;    |   :  | ; | '|   | /  | |  || \\  \\    `.`----'  |  ||  :  ' ;.   : |   |  \\ :       \n" +
                "|   : |    .   |  ' ' ' :'   | :  | :  |,  `----.   \\   '   :  ;|  |  ;/  \\   \\|   : .  /       \n" +
                ".   | '___ '   ;  \\; /  |;   . |  ; |--'   __ \\  \\  |   |   |  ''  :  | \\  \\ ,';   | |  \\    \n" +
                "'   ; : .'| \\   \\  ',  / |   : |  | ,     /  /`--'  /   '   :  ||  |  '  '--'  |   | ;\\  \\     \n" +
                "'   | '/  :  ;   :    /  |   : '  |/     '--'.     /    ;   |.' |  :  :        :   ' | \\.'        \n" +
                "|   :    /    \\   \\ .'   ;   | |`-'        `--'---'     '---'   |  | ,'        :   : :-'         \n" +
                " \\   \\ .'      `---`     |   ;/                                 `--''          |   |.'           \n" +
                "  `---`                  '---'                                                 `---'               \n");
        }
    }
}
