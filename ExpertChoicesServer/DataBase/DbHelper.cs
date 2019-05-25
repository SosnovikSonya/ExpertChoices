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
            var query = "select * from [User] where IsApproved = 0";
            return ExecuteQueryWithResult<User>(query);
        }

        public static void CreateUser(User user, bool isExpert)
        {
            user.IsApproved = false;
            var query = "insert into [User] values(@Email, @Password, @FirstName, @LastName, @IsApproved, @Role) ";
            ExecuteQuery(query, user);

            if (isExpert)
            {
                query = $"select iduser from [user] where  email = '{user.Email}' and password = '{user.Password}'";
                var iduser =  ExecuteQueryWithResult<int>(query).Single();
                CreateExpert(new Expert
                {
                    IdUser = iduser,
                    Name = $"{user.FirstName} {user.LastName}"
                });
            }
        }

        public static void ApproveUser(int id)
        {
            var query = $"update [User] set isapproved = 1 where iduser = {id} select iduser from [user] where iduser = {id}";
            ExecuteQueryWithResult<int>(query);
        }

        public static User GetUser(string email, string password)
        {
            var query = $"select * from [user] where email = '{email}' and password = '{password}'";
            return ExecuteQueryWithResult<User>(query).SingleOrDefault();
        }

        public static User DeleteUser(int id)
        {
            var query = $"delete from [user] where iduser = {id}";
            return ExecuteQueryWithResult<User>(query).SingleOrDefault();
        }

        public static List<Problem> CheckForAssignedProblems(int userId)
        {
            var query = $@"select distinct IdProblem from EstimationOnExpert es
                        join Expert ex on es.IdEstimator = ex.IdExpert
                        join [user] u on u.IdUser = ex.IdUser
                        where u.IdUser = {userId}
                        and value is null";
            var problems1 = ExecuteQueryWithResult<int>(query);

            query = $@"select distinct IdProblem from EstimationOnAlternative ea
                    join Expert ex on ea.IdEstimator = ex.IdExpert
                    join [user] u on u.IdUser = ex.IdUser
                    where u.IdUser = {userId}
                    and value is null";
            var problems2 = ExecuteQueryWithResult<int>(query);

            problems1.AddRange(problems2);
            problems1.Distinct();

            if (problems1.Count == 0)
            {
                return new List<Problem>();
            }            

            query = $@"select * from problem where idproblem in ({string.Join(", ", problems1)})";

            return ExecuteQueryWithResult<Problem>(query);
        }

        public static List<EstimationOnExpert> CheckForEstimationsOnExperts(int userId, int problemId)
        {
            var query = $@"select * from EstimationOnExpert es
                        join Expert ex on es.IdEstimator = ex.IdExpert
                        join [user] u on u.IdUser = ex.IdUser
                        where u.IdUser = {userId}
                        and idproblem = {problemId}
                        and value is null";
            return ExecuteQueryWithResult<EstimationOnExpert>(query);
        }

        public static List<EstimationOnAlternative> CheckForEstimationsOnAlternative(int userId, int problemId)
        {
            var query = $@"select * from EstimationOnAlternative es                       
                        join Expert ex on es.IdEstimator = ex.IdExpert
                        join [user] u on u.IdUser = ex.IdUser
                        where u.IdUser = {userId}
                        and idproblem = {problemId}
                        and value is null";
            return ExecuteQueryWithResult<EstimationOnAlternative>(query);
        }

        public static Problem GetProblem(int problemId)
        {
            var query = $@"select * from Problem
                        where idproblem = {problemId}";
            return ExecuteQueryWithResult<Problem>(query).SingleOrDefault();
        }

        public static void CreateExpert(Expert expert)
        {
            var query = "insert into Expert values(@IdUser, @Name) ";
            ExecuteQuery(query, expert);
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

        public static List<Expert> GetAllExperts()
        {
            var query = $@"select * from expert";
            return ExecuteQueryWithResult<Expert>(query);
        }

        public static Expert GetExpertByName(string name)
        {
            var query = $@"select * from expert
                        where name = N'{name}'";
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
            var query = "insert into EstimationOnExpert values(@IdEstimator, @IdEstimatedExpert, @IdProblem, @Value) ";
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
                        where name = N'{name}'";
            return ExecuteQueryWithResult<Alternative>(query).SingleOrDefault();
        }

        public static void UpdateEstimationOnExpert(EstimationOnExpert estimation)
        {
            var query = $@"update EstimationOnExpert
                        set Value = {estimation.Value}
                        where IdProblem = {estimation.IdProblem}
                        and IdEstimator = {estimation.IdEstimator}
                        and IdEstimatedExpert = {estimation.IdEstimatedExpert}";
            ExecuteQueryWithResult<object>(query);
        }

        public static void UpdateEstimationOnAlternative(EstimationOnAlternative estimation)
        {
            var query = $@"update EstimationOnAlternative
                        set value = {estimation.Value}
                        where IdProblem = {estimation.IdProblem}
                        and IdEstimator = {estimation.IdEstimator}
                        and IdEstimatedAlternative = {estimation.IdEstimatedAlternative}";
            ExecuteQueryWithResult<object>(query);
        }

        public static float? GetAlternativeDispersion(int problemId, int altId)
        {
            var query = $@"select top 1 Value from AlternativeDispersion
                where IdProblem = {problemId}
                and IdAlternative = {altId}
                order by idAlternativeDispersion desc";
            return ExecuteQueryWithResult<float?>(query).SingleOrDefault();
        }

        public static float? GetAlternativesPreferency(int problemId, int altId)
        {
            var query = $@"select top 1 Value from AlternativePreferency
                where IdProblem = {problemId}
                and IdAlternative = {altId}
                order by idAlternativePreferency desc";
            return ExecuteQueryWithResult<float?>(query).SingleOrDefault();
        }

        public static float? GetExpertDispersion(int problemId, int expertId)
        {
            var query = $@"select top 1 Value from ExpertDispersion
                where IdProblem = {problemId}
                and Idexpert = {expertId}
                order by idExpertDispersion desc";
            return ExecuteQueryWithResult<float?>(query).SingleOrDefault();
        }

        public static float? GetExpertCompetency(int problemId, int expertId)
        {
            var query = $@"select top 1 Value from ExpertCompetency
                where IdProblem = {problemId}
                and Idexpert = {expertId}
                order by idExpertCompetency desc";
            return ExecuteQueryWithResult<float?>(query).SingleOrDefault();
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

        public static void CreateExpertCompetency(ExpertCompetency obj)
        {
            var query = "insert into ExpertCompetency values(@IdProblem, @IdExpert, @Value) ";
            ExecuteQuery(query, obj);
        }

        public static void CreateExpertDispersion(ExpertDispersion obj)
        {
            var query = "insert into ExpertDispersion values(@IdProblem, @IdExpert, @Value) ";
            ExecuteQuery(query, obj);
        }

        public static void CreateAlternativeDispersion(AlternativeDispersion obj)
        {
            var query = "insert into AlternativeDispersion values(@IdProblem, @IdAlternative, @Value) ";
            ExecuteQuery(query, obj);
        }

        public static void CreateAlternativePreferency(AlternativePreferency obj)
        {
            var query = "insert into AlternativePreferency values(@IdProblem, @IdAlternative, @Value) ";
            ExecuteQuery(query, obj);
        }

        public static List<int> GetEstimatorsOfProblem(int problemId)
        {
            var query = $@"select distinct IdEstimator from EstimationOnExpert where IdProblem =  {problemId}";
            return ExecuteQueryWithResult<int>(query);
        }
    }
}