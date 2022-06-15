using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace MovieLand
{
    public static class ConfigurationExtensions
    {
        // Dictionnaire des préfixes de nom d'ordinateur avec leur nom de connectionstring correspondant
        public static Dictionary<string, string> GetMachineNamePrefixes(this IConfiguration config)
        {
            return new Dictionary<string, string>() {
                { "LLBINF", "LaboCegep" }
            };
        }

        public static string GetConnectionString(this IConfiguration config)
        {
            string machineName = System.Environment.MachineName;
            Dictionary<string, string> machineNamePrefixes = config.GetMachineNamePrefixes();
            string machineNamePrefixKey = machineNamePrefixes.Keys.Where(k => machineName.StartsWith(k)).FirstOrDefault();
            string connectionStringName;

            if (machineNamePrefixKey != null && config.GetMachineNamePrefixes().TryGetValue(machineNamePrefixKey, out connectionStringName))
            {
                return config.GetConnectionString(connectionStringName).Replace("%MachineName%", machineName);
            }

            return config.GetConnectionString(machineName);
        }
    }
}
