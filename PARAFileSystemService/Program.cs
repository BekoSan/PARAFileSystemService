using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace PARAFileSystemService
{
    class Program
    {
        static void Main()
        {
        
        }

        static void InitializeParaService()
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<ParaService>(s =>
                {
                    s.ConstructUsing(paraSerice => new ParaService());
                    s.WhenStarted(paraService => paraService.Start());
                    s.WhenStopped(paraService => paraService.Stop());
                });

                x.RunAsLocalSystem();
                x.SetServiceName("PARAService");
                x.SetDisplayName("PARA Service");
                x.SetDescription("This service used PARA method to organize folders and files.");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }

    }
}
