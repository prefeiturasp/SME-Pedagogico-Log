using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME.Pedagogico.Log
{
    public class LogManager
    {
        #region ==================== ATTRIBUTES ====================
        private Contexts.SmeLogContext db;
        #endregion ==================== ATTRIBUTES ====================



        #region ==================== CONSTRUCTORS ====================
        public LogManager()
        {
            db = new Contexts.SmeLogContext();
        }

        public LogManager(string connectionString)
        {
            db = new Contexts.SmeLogContext(connectionString);
        }
        #endregion ==================== CONSTRUCTORS ====================



        #region ==================== METHODS ====================
        // Criar método genérico para buscar objetos pelo código

        public bool AddEntry(string description, string actionCode, string applicationCode, string ip, string machineName, string permissionCode, string userId, string username)
        {
            try
            {
                Models.Entry entry = new Models.Entry();
                entry.NewId();
                entry.Description = description;

                entry.Action =
                    (from action in db.Actions
                     where action.Code == actionCode
                     select action).FirstOrDefault();

                if (entry.Action == null)
                {
                    entry.Action = new Models.Action();
                    entry.Action.NewId();
                    entry.Action.Code = actionCode;
                }

                entry.Application =
                    (from application in db.Applications
                     where application.Code == applicationCode
                     select application).FirstOrDefault();

                if (entry.Application == null)
                {
                    entry.Application = new Models.Application();
                    entry.Application.NewId();
                    entry.Application.Code = applicationCode;
                }

                entry.Connection =
                    (from connection in db.Connections
                     where connection.IP == ip
                     && connection.MachineName == machineName
                     select connection).FirstOrDefault();

                if (entry.Connection == null)
                {
                    entry.Connection = new Models.Connection();
                    entry.Connection.NewId();
                    entry.Connection.IP = ip;
                    entry.Connection.MachineName = machineName;
                }

                entry.Permission =
                    (from permission in db.Permissions
                     where permission.Code == permissionCode
                     select permission).FirstOrDefault();

                if (entry.Permission == null)
                {
                    entry.Permission = new Models.Permission();
                    entry.Permission.NewId();
                    entry.Permission.Code = actionCode;
                }

                entry.User =
                    (from user in db.Users
                     where user.Id == userId
                     select user).FirstOrDefault();

                if (entry.User == null)
                {
                    entry.User = new Models.User();
                    entry.User.NewId();
                    entry.User.UserId = userId;
                    entry.User.Username = username;
                }

                db.SaveChanges();

                return (true);
            }
            catch (Exception error)
            {
                return (false);
            }
        }
        #endregion ==================== METHODS ====================
    }
}
