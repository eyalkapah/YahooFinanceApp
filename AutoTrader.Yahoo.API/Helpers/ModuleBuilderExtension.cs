using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTrader.Yahoo.API.Helpers
{
    public static class ModuleBuilderExtension
    {
        public static void AddModule(this List<string> builder, string moduleName, bool isModuleEnabled)
        {
            if (isModuleEnabled)
                builder.Add(moduleName);
        }
    }
}
