using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saratyc._3._Servicios
{
    internal class RecomendarAuxiliar
    {

        private void Run_cmd(string cmd, string args, Process process)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("D:\\ProgramData\\Miniconda3\\envs\\Taller 2\\python.exe preferencias_auxiliares.py");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;

            Process.Start(startInfo);

            startInfo.Arguments = "";

            Process.Start(startInfo);


        }


    }


}
