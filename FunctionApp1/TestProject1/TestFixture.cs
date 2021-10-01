using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    public class TestFixture : IDisposable
    {
        private Process process;
        public int port = 7071;
        public HttpClient = new HttpClient();

        public testc TestFixure()
        {
            var dotnet = Environment.ExpandEnvironmentVariables(ConfigHelper.Settings.DotnetExecutablePath);
            var FunctionHost = Environment.ExpandEnvironmentVariables(ConfigHelper.Settings.FunctionHostPath);
            var FunctionApp = Path.GetRelativePath(Directory.GetCurrentDirectory(), ConfigHelper.Settings.FunctionApp1);

            process = new Process
            {
                StartInfo =
                {
                    Filename= dotnet,
                    Arguments = $"\"{functionHost}"start -process {port}",
                    WorkingDirectory= FunctionApp
                }
            };
            var success = process.Start();
            Client.BaseAddress = new Uri($"http://localhost:{port}");

        }
        public void Dispose ()
        {
            if(!process.HasExited)
            {
                process.kill();

            }
            process.Dispose();

            
        }
    }
}
