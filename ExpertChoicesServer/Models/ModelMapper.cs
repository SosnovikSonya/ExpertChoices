﻿using ExpertChoicesServer.Extensions;
using ProblemSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpertChoicesServer.Models
{
    /// <summary>
    /// Convert DB entities to response models and vice versa
    /// </summary>
    public static class ModelMapper
    {
        public static ExpertChoicesModels.User ConvertToResponseUser(DataBase.User userDB)
        {
            return new ExpertChoicesModels.User
            {
                Email = userDB.Email,
                FirstName = userDB.FirstName,
                LastName = userDB.LastName,
                Id = userDB.IdUser,
                Password = null,
                Role = (ExpertChoicesModels.UserRole)userDB.Role
            };
        }

        public static DataBase.User ConvertToDBUser(ExpertChoicesModels.RegisterUserPostRequestModel userModel)
        {
            var user = AuthHelper.GetUserFromAuthToken(userModel.AuthToken);
            user.FirstName = userModel.Name.Split(' ')[0];
            user.LastName = userModel.Name.Split(' ')[1];
            user.IsApproved = false;
            user.Role = (int)userModel.Role;
            return user;
        }

        public static ExpertChoicesModels.Alternative ConvertToResponseAlternative(DataBase.Alternative alternativeDB)
        {
            return new ExpertChoicesModels.Alternative
            {
                Id = alternativeDB.IdAlternative,
                Name = alternativeDB.Name,
                Description = alternativeDB.Description
            };
        }

        public static ExpertChoicesModels.Problem ConvertToResponseProblem(DataBase.Problem problemDB)
        {
            return new ExpertChoicesModels.Problem
            {
                Name = problemDB.Name,
                Description = problemDB.Description,
                Id = problemDB.IdProblem
            };
        }

        public static ExpertChoicesModels.Expert ConvertToResponseExpert(DataBase.Expert ExpertDB)
        {
            return new ExpertChoicesModels.Expert
            {
                Id = ExpertDB.IdExpert,
                Name = ExpertDB.Name                
            };
        }

        public static DataBase.Problem ConvertToDBProblem(ExpertChoicesModels.Problem problemModel)
        {
            return new DataBase.Problem
            {
                Name = problemModel.Name,
                Description = problemModel.Description,
                IdProblem = problemModel.Id
            };
        }

        public static DataBase.Alternative ConvertToDBAlternative(IAlternative alternativeModel)
        {
            return new DataBase.Alternative
            {
                Name = alternativeModel.Name,
                Description = alternativeModel.Description
            };
        }

        public static List<DataBase.EstimationOnExpert> ConvertToDBEstimationExpert(List<ExpertChoicesModels.EstimationModel> estimations)
        {
            var expertEstimationList = new List<DataBase.EstimationOnExpert>();
            foreach (var estimation in estimations)
            {
                expertEstimationList.Add(
                    new DataBase.EstimationOnExpert
                    {
                        IdEstimatedExpert = estimation.Id,
                        Value = estimation.Value
                    });

            }
            return expertEstimationList;
        }

        public static List<DataBase.EstimationOnAlternative> ConvertToDBEstimationAlternative(List<ExpertChoicesModels.EstimationModel> estimations)
        {
            var expertEstimationList = new List<DataBase.EstimationOnAlternative>();
            foreach (var estimation in estimations)
            {
                expertEstimationList.Add(
                    new DataBase.EstimationOnAlternative
                    {
                        IdEstimatedAlternative = estimation.Id,
                        Value = estimation.Value
                    });

            }
            return expertEstimationList;            
        }

        public static Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative> ConvertToEstimationModel(List<DataBase.EstimationOnAlternative> estimations)
        {
            var model = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Alternative>
            {
                Estimated = new Dictionary<ExpertChoicesModels.Alternative, int?>()
            };

            foreach (var estimation in estimations)
            {
                model.Estimated.Add(
                    new ExpertChoicesModels.Alternative
                    {
                        Id = estimation.IdEstimatedAlternative
                    },
                    estimation.Value
                    );                    
            }
            return model;            
        }

        public static Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert> ConvertToEstimationModel(List<DataBase.EstimationOnExpert> estimations)
        {
            var model = new Estimation<ExpertChoicesModels.Expert, ExpertChoicesModels.Expert>
            {
                Estimated = new Dictionary<ExpertChoicesModels.Expert, int?>()
            };

            foreach (var estimation in estimations)
            {
                model.Estimated.Add(
                    new ExpertChoicesModels.Expert
                    {
                        Id = estimation.IdEstimatedExpert
                    },
                    estimation.Value
                    );
            }
            return model;
        }               
    }
}