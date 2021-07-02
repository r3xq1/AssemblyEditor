namespace AssemblyInfoEditor
{
    using System.Reflection;
    using System.Runtime.InteropServices;

    public static class MutEx
    {
        public static string GetGuidApp
        {
            get
            {
                string result = string.Empty;
                try
                {
                    Assembly assembly = typeof(Program).Assembly;
                    var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
                    result = attribute.Value;
                }
                catch { }
                return result?.ToUpper();
            }
        }
    }
}