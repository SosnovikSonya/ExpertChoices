using ExpertChoices.ServerInteraction;
using ExpertChoicesModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolverTests
{
    [TestClass]
    public class ClientTests
    {
        #region testdata
        ExpertChoicesModels.Expert expert1;
        ExpertChoicesModels.Expert expert2;
        ExpertChoicesModels.Expert expert3;

        ExpertChoicesModels.Problem problem;

        ExpertChoicesModels.Alternative alt1;
        ExpertChoicesModels.Alternative alt2;
        ExpertChoicesModels.Alternative alt3;

        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert> expEstimations1;
        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert> expEstimations2;
        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert> expEstimations3;

        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative> altEstimations1;
        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative> altEstimations2;
        Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative> altEstimations3;

        User user3 = new User
        {
            Email = "asd3@asd.asd",
            Password = "asd123",
            Role = UserRole.Analytic | UserRole.Expert
        };

        User user2 = new User
        {
            Email = "asd2@asd.asd",
            Password = "asd123",
            Role = UserRole.Expert
        };

        User user1 = new User
        {
            Email = "asd1@asd.asd",
            Password = "asd123",
            Role = UserRole.Expert
        };

        User admin = new User
        {
            Email = "asdsadada",
            Password = "123123",
            Role = UserRole.Admin | UserRole.Expert
        };



        #endregion

        [TestInitialize]
        public void Setup()
        {
            #region Test data
            //Admin
            expert1 = new ExpertChoicesModels.Expert
            {
                Id = 1,
                Name = "Sonya"
            };

            expert2 = new ExpertChoicesModels.Expert
            {
                Id = 2,
                Name = "Misha"
            };

            expert3 = new ExpertChoicesModels.Expert
            {
                Id = 3,
                Name = "Eva"
            };

            //Analytic
            problem = new ExpertChoicesModels.Problem
            {
                Name = "When to go to cinema"
            };

            alt1 = new ExpertChoicesModels.Alternative
            {
                Id = 7,
                Name = "А1",
                Description = "Описание 1"
            };

            alt2 = new ExpertChoicesModels.Alternative
            {
                Id = 8,
                Name = "А2",
                Description = "Описание 2"
            };

            alt3 = new ExpertChoicesModels.Alternative
            {
                Id = 9,
                Name = "А3",
                Description = "Описание 3"
            };

            //Experts
            expEstimations1 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>
            {
                Estimator = expert1,
                Estimated = new Dictionary<ExpertChoicesModels.Expert, int?>
                {
                    { expert2, 4},
                    { expert3, 8},
                }
            };

            expEstimations2 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>
            {
                Estimator = expert2,
                Estimated = new Dictionary<ExpertChoicesModels.Expert, int?>
                {
                    { expert1, 4},
                    { expert3, 6},
                }
            };

            expEstimations3 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>
            {
                Estimator = expert3,
                Estimated = new Dictionary<ExpertChoicesModels.Expert, int?>
                {
                    { expert1, 5},
                    { expert2, 7},
                }
            };


            altEstimations1 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>
            {
                Estimator = expert1,
                Estimated = new Dictionary<ExpertChoicesModels.Alternative, int?>
                {
                    { alt1, 4},
                    { alt2, 5},
                    { alt3, 8}
                }
            };

            altEstimations2 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>
            {
                Estimator = expert2,
                Estimated = new Dictionary<ExpertChoicesModels.Alternative, int?>
                {
                    { alt1, 5},
                    { alt2, 6},
                    { alt3, 7}
                }
            };

            altEstimations3 = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>
            {
                Estimator = expert3,
                Estimated = new Dictionary<ExpertChoicesModels.Alternative, int?>
                {
                    { alt1, 8},
                    { alt2, 5},
                    { alt3, 4}
                }
            };


            //Server
            problem.AlternativesEstimations = new List<Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>>
                {
                    altEstimations1,
                    altEstimations2,
                    altEstimations3
                };

            problem.ExpertsEstimations = new List<Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>>
                {
                    expEstimations1,
                    expEstimations2,
                    expEstimations3
                };
            #endregion

        }

        ExpertChoicesClient client = new ExpertChoicesClient();

        [TestMethod]
        public void RegisterUser()
        {
            var user = new User
            {
                Email = "asdsadada",
                FirstName = "asd",
                LastName = "12asd",
                Password = "123123",
                Role = UserRole.Admin | UserRole.Expert
            };
            client.Register(user);
        }

        [TestMethod]
        public void AuthorizeUser()
        {           
            var user = client.Authorize("asdsadada", "123123");
            Assert.IsNotNull(user);
            Assert.AreEqual(false, user.IsAuthorized);
            Assert.AreEqual(6, (int)user.Role);
        }

        [TestMethod]
        public void CreateProblem()
        {
            var userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);

            var problem = new Problem
            {
                Name = "В каком городе открыть новый филиал",
                Description = "города по Беларуси"
            };

            var problemId = client.CreateProblem(problem);
            Assert.AreNotEqual(-1, problemId);
        }

        [TestMethod]
        public void AssignAlternatives()
        {
            var userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);

            var alternativesList = new List<Alternative>
            {
                alt1, alt2, alt3
            };

            var altIds = client.AssignAlternative(2, alternativesList);
            Assert.AreEqual(3, altIds.Count);
        }

        [TestMethod]
        public void AssignExperts()
        {
            var userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);

            var ExpertsList = new List<int>
            {
                1, 2, 3
            };
            client.AssignExperts(2, ExpertsList);
        }
        
        [TestMethod]
        public void CheckForProblems()
        {
            var userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);

            var problems = client.CheckForAssignedProblems();
            Assert.AreEqual(1, problems.Count);
        }

        [TestMethod]
        public void CheckForEstExperts()
        {
            var userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);

            var problems = client.CheckForAssignedEstimationsOnExperts(2);
            Assert.AreEqual(2, problems.Count);
        }

        [TestMethod]
        public void CheckForEstAlts()
        {
            var userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);

            var problems = client.CheckForAssignedEstimationsOnAlternatives(2);
            Assert.AreEqual(3, problems.Count);
        }

        [TestMethod]
        public void SendEstimationOnExpert()
        {
            var userModel = client.Authorize(user1.Email, user1.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(4, (int)userModel.Role);
                        
            client.SendEstimationsOnExperts(2, expEstimations1);

            userModel = client.Authorize(user2.Email, user2.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(4, (int)userModel.Role);
            client.SendEstimationsOnExperts(2, expEstimations2);


            userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);
            client.SendEstimationsOnExperts(2, expEstimations3);
        }

        [TestMethod]
        public void SendEstimationOnAlternatives()
        {
            var userModel = client.Authorize(user1.Email, user1.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(4, (int)userModel.Role);

            client.SendEstimationsOnAlternatives(2, altEstimations1);

            userModel = client.Authorize(user2.Email, user2.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(4, (int)userModel.Role);
            client.SendEstimationsOnAlternatives(2, altEstimations2);


            userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);
            client.SendEstimationsOnAlternatives(2, altEstimations3);
        }

        [TestMethod]
        public void SolveTheProblem()
        {
            var userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);

            client.SolveTheProblem(2);
        }

        [TestMethod]
        public void GetAllExperts()
        {
            var userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);

            var experts = client.GetAllExperts();
            Assert.AreEqual(4, experts.Count);
        }

        [TestMethod]
        public void GetExpertMetrics()
        {
            var userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);

            var metrics = client.GetExpertMetrics(2, 1);
            Assert.IsNotNull(metrics.Competency);
            Assert.IsNotNull(metrics.Dispersion);
        }

        [TestMethod]
        public void GetAltMetrics()
        {
            var userModel = client.Authorize(user3.Email, user3.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(12, (int)userModel.Role);

            var metrics = client.GetAlternativeMetrics(2, 7);
            Assert.IsNotNull(metrics.Preferency);
            Assert.IsNotNull(metrics.Dispersion);
        }

        [TestMethod]
        public void GetPendingUsers()
        {
            //var newUser = new User
            //{
            //    Email = "asdkjdshfj",
            //    Password = "12313213",
            //    Role = UserRole.Expert,
            //    FirstName = "ddd",
            //    LastName = "xvxcv"
            //};
            //client.Register(newUser);
            //var userModel1 = client.Authorize(newUser.Email, newUser.Password);
            //Assert.IsNotNull(userModel1);
            //Assert.AreEqual(false, userModel1.IsAuthorized);
            //Assert.AreEqual(4, (int)userModel1.Role);

            var userModel = client.Authorize(admin.Email, admin.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(6, (int)userModel.Role);
                       
            var users = client.GetPendingUsers();
            Assert.AreEqual(1, users.Count);
        }

        [TestMethod]
        public void ApproveUser()
        {
            var userModel = client.Authorize(admin.Email, admin.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(6, (int)userModel.Role);

            client.ApproveUsers(5);
        }

        [TestMethod]
        public void DeleteUser()
        {
            var userModel = client.Authorize(admin.Email, admin.Password);
            Assert.IsNotNull(userModel);
            Assert.AreEqual(true, userModel.IsAuthorized);
            Assert.AreEqual(6, (int)userModel.Role);

            client.DeleteUsers(5);
        }
    }
}
