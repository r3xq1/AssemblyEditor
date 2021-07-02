namespace AssemblyInfoEditor
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            using (new Mutex(true, $@"Local\{MutEx.GetGuidApp}", out bool flag))
            {
                if (flag)
                {
                    Application.Run(new AssEditor());
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}