﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace dapper_sqlite_demo.Database
{
    public interface IDatabaseBootstrap : IDatabaseConnectionFactory
    {        
        Task SetupAsync(IDbConnection connection);
    }
}
