#nullable disable
using System.Diagnostics;
using System.Reflection;

namespace ScriptTest
{
    public static class ObjectHelper
    {
        public static Stream GetAssemblyManifestResource(Assembly assembly, string resourceName)
        {
            try
            {
                return assembly.GetManifestResourceStream(String.Format("{0}.{1}", assembly.GetName().Name, resourceName));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }
        public static StreamReader GetAssemblyManifestResourceReader(Assembly assembly, string resourceName)
        {
            try
            {
                Stream res = GetAssemblyManifestResource(assembly, resourceName);
                if (res != null) return new StreamReader(res);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }
        public static string GetAssemblyManifestResourceText(Assembly assembly, string resourceName)
        {
            using var reader = GetAssemblyManifestResourceReader(assembly, resourceName);
            return reader?.ReadToEnd();
        }
    }
}
