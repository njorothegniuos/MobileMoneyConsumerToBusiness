using System.Reflection;

namespace Infrastructure
{
    public static class ApplicationAssembly
    {
        public static readonly Assembly Instance = typeof(ApplicationAssembly).Assembly;
    }
}