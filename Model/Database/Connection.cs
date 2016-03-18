using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using SQLite.Net.Platform.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using JetBrains.Annotations;
using SQLite.Net.Attributes;
using SQLite.Net.Interop;

namespace Model.Database
{
    public class Connection : SQLiteConnection
    {
        public const string DatabasePath = "Database.db";

        public Connection(ISQLitePlatform sqlitePlatform, bool storeDateTimeAsTicks = true, IBlobSerializer serializer = null, IDictionary<string, TableMapping> tableMappings = null, IDictionary<Type, string> extraTypeMappings = null, IContractResolver resolver = null) : base(sqlitePlatform, DatabasePath, storeDateTimeAsTicks, serializer, tableMappings, extraTypeMappings, resolver)
        {

        }
    }
}
