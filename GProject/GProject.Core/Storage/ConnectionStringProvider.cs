using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GProject.Core.Storage
{
    public enum Profiles
    {
        Read,
        Write
    }

    public static class ConnectionStringProvider
    {   

        public static string ReadConnection => GetConnection();
        public static string WriteConnection => GetConnection(Profiles.Write);

        private static string GetConnection(Profiles profile = Profiles.Read)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[profile.ToString("g")];
            return settings.ConnectionString;
        }
    }
}
