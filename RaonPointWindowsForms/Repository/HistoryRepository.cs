using Dapper;
using RaonPointWindowsForms.Auth;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaonPointWindowsForms.Repository
{
    public static class HistoryRepository
    {

        public static async Task CreateHistory(IDbConnection connection, IDbTransaction transaction, string action, string details)
        {
            await connection.ExecuteAsync("INSERT INTO history (user_id, action, details) VALUES (@UserID, @Action, @Details)", new { 
                UserID = Session.CurrentUser.id,
                Action = action,
                Details = details
            }, transaction);
        }

    }
}
