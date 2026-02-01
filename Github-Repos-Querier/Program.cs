using Rox.Runtimes;
using System;
using System.Windows.Forms;
using static Rox.Runtimes.Reporter;

namespace GithubReposQuerier
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form form1() => new Form1();
            InitializeReportInterface reporter = new InitializeReportInterface(form1);
            reporter.Run();
        }
    }
}
