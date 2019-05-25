using ExpertChoicesServer.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ExpertChoicesServer.Extensions
{
    public static class AuthHelper
    {
        public static DataBase.User GetUserFromAuthHeader(HttpRequestMessage request)
        {
            try
            {
                var token = request.Headers.Authorization.Parameter;
                byte[] data = System.Convert.FromBase64String(token);
                var credentials = System.Text.ASCIIEncoding.ASCII.GetString(data).Split(':');
                return DbHelper.GetUser(credentials[0], credentials[1]);
            }
            catch (Exception)
            {
                return null; 
            }
        }

        public static DataBase.User GetUserFromAuthToken(string token)
        {
            try
            {
                byte[] data = System.Convert.FromBase64String(token);
                var credentials = System.Text.ASCIIEncoding.ASCII.GetString(data).Split(':');

                return new DataBase.User
                {
                    Email = credentials[0],
                    Password = credentials[1]
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool VerifyUserAuthorizedAdmin(DataBase.User user)
        {
            if (user is null)
            {
                return false;
            }
            if (user.Role == 0)
            {
                user = DbHelper.GetUser(user.Email, user.Password);
            }

            return ((ExpertChoicesModels.UserRole)user.Role).HasFlag(ExpertChoicesModels.UserRole.Admin) && user.IsApproved;
        }

        public static bool VerifyUserAuthorizedAnalytic(DataBase.User user)
        {
            if (user is null)
            {
                return false;
            }
            if (user.Role == 0)
            {
                user = DbHelper.GetUser(user.Email, user.Password);
            }

            return ((ExpertChoicesModels.UserRole)user.Role).HasFlag(ExpertChoicesModels.UserRole.Analytic) && user.IsApproved;
        }

        public static bool VerifyUserAuthorizedExpert(DataBase.User user)
        {
            if (user is null)
            {
                return false;
            }
            if (user.Role == 0)
            {
                user = DbHelper.GetUser(user.Email, user.Password);
            }

            return ((ExpertChoicesModels.UserRole)user.Role).HasFlag(ExpertChoicesModels.UserRole.Expert) && user.IsApproved;
        }
    }
}