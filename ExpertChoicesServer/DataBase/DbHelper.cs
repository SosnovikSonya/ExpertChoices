using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExpertChoicesServer.DataBase
{
    public static class DbHelper
    {        
        private static void ExecuteQuery<T>(string query, T obj)
        {
            using (IDbConnection connection = new SqlConnection("Server=localhost\\sqlexpress;Database=ExpertChoices;Integrated Security=SSPI"))
            {
                connection.Query<T>(query, obj, commandTimeout: 180);
            }
        }

        private static List<T> ExecuteQueryWithResult<T>(string query)
        {
            var queryResult = new List<T>();
            using (IDbConnection connection = new SqlConnection("Server=localhost\\sqlexpress;Database=ExpertChoices;Integrated Security=SSPI"))
            {
                queryResult = connection.Query<T>(query, commandTimeout: 180).ToList();
            }

            return queryResult;
        }

        public static List<User> GetPendingUsers()
        {
            var query = "select * from [dbo].[User] where IsApproved = 0";
            return ExecuteQueryWithResult<User>(query);
        }

        public static void RegisterUser(User user)
        {
            user.IsApproved = false;
            var query = "insert into [dbo].[User] values(@Email, @Password, @FirstName, @LastName, @Role, @IsApproved) ";
            ExecuteQuery(query, user);
        }      

        public static User GetUser(string email, string password)
        {
            var query = $"select * from [dbo].[user] where email = '{email}' and password = '{password}'";
            return ExecuteQueryWithResult<User>(query).SingleOrDefault();
        }

        public static List<EstimationOnExpert> CheckForEstimationsOnExperts(int userId)
        {
            var query = $@"select * from EstimationOnExpert es
                        join Expert ex on es.IdEstimator = ex.IdExpert
                        join [dbo].[user] u on u.IdUser = ex.IdUser
                        where u.IdUser = {userId}
                        and value is null";
            return ExecuteQueryWithResult<EstimationOnExpert>(query);
        }

        public static List<EstimationOnAlternative> CheckForEstimationsOnAlternative(int userId)
        {
            var query = $@"select * from EstimationOnAlternative es                       
                        join Expert ex on es.IdEstimator = ex.IdExpert
                        join [dbo].[user] u on u.IdUser = ex.IdUser
                        where u.IdUser = {userId}
                        and value is null";
            return ExecuteQueryWithResult<EstimationOnAlternative>(query);
        }

        public static Problem GetProblem(int problemId)
        {
            var query = $@"select * from Problem
                        where idproblem = {problemId}";
            return ExecuteQueryWithResult<Problem>(query).SingleOrDefault();
        }

        public static Expert GetExpertByUserId(int userId)
        {
            var query = $@"select * from expert
                        where iduser = {userId}";
            return ExecuteQueryWithResult<Expert>(query).SingleOrDefault();
        }

        public static Expert GetExpertById(int expertId)
        {
            var query = $@"select * from expert
                        where idexpert = {expertId}";
            return ExecuteQueryWithResult<Expert>(query).SingleOrDefault();
        }

        public static Expert GetExpertByName(string name)
        {
            var query = $@"select * from expert
                        where name = '{name}'";
            return ExecuteQueryWithResult<Expert>(query).SingleOrDefault();
        }

        public static Alternative GetAlternativeById(int alternativeId)
        {
            var query = $@"select * from Alternative
                        where idAlternative = {alternativeId}";
            return ExecuteQueryWithResult<Alternative>(query).SingleOrDefault();
        }

        public static int CreateProblem(Problem problem)
        {
            var query = $"insert into [Problem] output inserted.IdProblem values('{problem.Name}', '{problem.Description}') ";
            return ExecuteQueryWithResult<int>(query).Single();
        }

        public static void CreateEtimationOnExpert(EstimationOnExpert est)
        {
            var query = "insert into EstimationOnExpert values(@IdEstimator, @IdProblem, @IdEstimatedExpert, @Value) ";
            ExecuteQuery(query, est);
        }

        public static void CreateEtimationOnAlternative(EstimationOnAlternative est)
        {
            var query = "insert into EstimationOnAlternative values(@IdEstimator, @IdEstimatedAlternative, @IdProblem, @Value) ";
            ExecuteQuery(query, est);
        }

        public static int CreateAlternative(Alternative alternative)
        {
            var query = $"insert into Alternative output inserted.IdAlternative values('{alternative.Name}','{alternative.Description}') ";
            return ExecuteQueryWithResult<int>(query).Single();
        }

        public static Alternative GetAlternativeByName(string name)
        {
            var query = $@"select * from Alternative
                        where name = '{name}'";
            return ExecuteQueryWithResult<Alternative>(query).SingleOrDefault();
        }

        public static void UpdateEstimationOnExpert(EstimationOnExpert estimation)
        {
            var query = @"update EstimationOnExpert
                        set Value = @Value
                        where IdProblem = @IdProblem
                        and IdEstimator = @IdEstimator
                        and IdEstimatedExpert = @IdEstimatedExpert";
            ExecuteQuery(query, estimation);
        }

        public static void UpdateEstimationOnAlternative(EstimationOnAlternative estimation, string altName)
        {
            var query = $@"update EstimationOnAlternative
                        set value = @Value
                        where IdEstimationOnAlternative in (
                        select top 1 IdEstimationOnAlternative from EstimationOnAlternative ea
                        join alternative a on ea.IdEstimatedAlternative = a.IdAlternative
                        where ea.IdProblem = @IdProblem
                        and IdEstimator = @IdEstimator
                        and a.Name = '{altName}')";
            ExecuteQuery(query, estimation);
        }

        public static List<dynamic> GetAlternativeDispersions(int problemId)
        {
            var query = $@"select a.Name, ad.Value from AlternativeDispersion ad 
                join Alternative a on a.IdAlternative = ad.IdAlternative
                where IdProblem = {problemId}";
            return ExecuteQueryWithResult<dynamic>(query);
        }

        public static List<dynamic> GetAlternativesPreferencies(int problemId)
        {
            var query = $@"select a.Name, ad.Value from AlternativePreferency ap 
                join Alternative a on a.IdAlternative = ap.IdAlternative
                where IdProblem = {problemId}";
            return ExecuteQueryWithResult<dynamic>(query);
        }

        public static List<dynamic> GetExpertDispersions(int problemId)
        {
            var query = $@"select a.Name, ad.Value from ExpertDispersion ed 
                join Expert a on a.IdExpert = ed.IdExpert
                where IdProblem = {problemId}";
            return ExecuteQueryWithResult<dynamic>(query);
        }

        public static List<dynamic> GetExpertCompitencies(int problemId)
        {
            var query = $@"select a.Name, ad.Value from ExpertCompitency ec 
                join Expert a on a.IdExpert = ec.IdExpert
                where IdProblem = {problemId}";
            return ExecuteQueryWithResult<dynamic>(query);
        }

        public static List<EstimationOnAlternative> GetEstimationsOnAlternatives(int problemId)
        {
            var query = $@"select * from EstimationOnAlternative
                where IdProblem = {problemId}";
            return ExecuteQueryWithResult<EstimationOnAlternative>(query);
        }

        public static List<EstimationOnExpert> GetEstimationsOnExpert(int problemId)
        {
            var query = $@"select * from EstimationOnExpert
                where IdProblem = {problemId}";
            return ExecuteQueryWithResult<EstimationOnExpert>(query);
        }
    }
}