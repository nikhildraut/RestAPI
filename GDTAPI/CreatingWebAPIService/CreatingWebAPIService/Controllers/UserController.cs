using System;
using System.Web.Http;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;




namespace DevetchAPI
{
    public class UserController : ApiController
    {
        [HttpPost]
        public string AddUser(string FirstName, string MiddleName, string LastName, string UserId, string Password, string RoleId, string EmailId, string Phone, string IsActive, string CreatedDate, string CreatedBy)
        {
            try
            {
                AppLog.WriteErrorLog("Function (POST) : User/AddUser");

                if (!Validation.DuplicateUserId(UserId).Equals("1")) { return Validation.ValidDuplicateUserId; }
                if (!Validation.DuplicateEmailId(EmailId).Equals("1")) { return Validation.ValidDuplicateEmailId; }
                if (!Validation.DuplicatePhone(Phone).Equals("1")) { return Validation.ValidDuplicatePhone; }

                bool IsAdd = false; string ReturnVal = Validation.UnsuccessAddUser; string Columns = string.Empty; string Values = string.Empty;
                if (!string.IsNullOrEmpty(FirstName)) { Columns = "FirstName"; Values = "'" + FirstName + "'"; } else { return Validation.ValidFirstName; }
                if (!string.IsNullOrEmpty(MiddleName)) { Columns = Columns + ",MiddleName"; Values = Values + ",'" + MiddleName + "'"; }
                if (!string.IsNullOrEmpty(LastName)) { Columns = Columns + ",LastName"; Values = Values + ",'" + LastName + "'"; }
                if (!string.IsNullOrEmpty(UserId)) { Columns = Columns + ",UserId"; Values = Values + ",'" + UserId + "'"; } else { return Validation.ValidUserId; }
                if (string.IsNullOrEmpty(RoleId)) { return Validation.ValidRoleId; }
                if (!string.IsNullOrEmpty(Password)) { Columns = Columns + ",Password"; Values = Values + ",'" + Password + "'"; } else { return Validation.ValidPassword; }
                if (!string.IsNullOrEmpty(EmailId)) { Columns = Columns + ",EmailId"; Values = Values + ",'" + EmailId + "'"; } else { return Validation.ValidEmail; }
                if (!string.IsNullOrEmpty(Phone)) { Columns = Columns + ",Phone"; Values = Values + ",'" + Phone + "'"; }
                if (!string.IsNullOrEmpty(IsActive)) { Columns = Columns + ",IsActive"; Values = Values + ",'" + IsActive + "'"; }
                if (!string.IsNullOrEmpty(CreatedDate)) { Columns = Columns + ",CreatedDate"; Values = Values + ",'" + CreatedDate + "'"; }
                if (!string.IsNullOrEmpty(CreatedBy)) { Columns = Columns + ",CreatedBy"; Values = Values + ",'" + CreatedBy + "'"; }

                if (!string.IsNullOrEmpty(Columns) && !string.IsNullOrEmpty(Values))
                {
                    IsAdd = QueryBuilder.InsertInDB("tblusers", Columns, Values);
                    if (IsAdd)
                    {
                        string Columns1 = string.Empty; string Values1 = string.Empty; string AuthToken = Guid.NewGuid().ToString().Substring(0, 8);
                        if (!string.IsNullOrEmpty(UserId)) { Columns1 = "UserId"; Values1 = "'" + UserId + "'"; } else { return Validation.ValidUserId; }
                        if (!string.IsNullOrEmpty(AuthToken)) { Columns1 = Columns1 + ",AuthToken"; Values1 = Values1 + ",'" + AuthToken + "'"; }
                        if (!string.IsNullOrEmpty(IsActive)) { Columns1 = Columns1 + ",IsActive"; Values1 = Values1 + ",'" + IsActive + "'"; }
                        if (!string.IsNullOrEmpty(CreatedDate)) { Columns1 = Columns1 + ",CreatedDate"; Values1 = Values1 + ",'" + CreatedDate + "'"; }
                        if (!string.IsNullOrEmpty(CreatedBy)) { Columns1 = Columns1 + ",CreatedBy"; Values1 = Values1 + ",'" + CreatedBy + "'"; }
                        if (!string.IsNullOrEmpty(Columns1) && !string.IsNullOrEmpty(Values1))
                        {
                            QueryBuilder.InsertInDB("tbluserauthtokens", Columns1, Values1);
                        }
                    }
                    if (IsAdd)
                    {
                        string Columns2 = string.Empty; string Values2 = string.Empty;
                        if (!string.IsNullOrEmpty(UserId)) { Columns2 = "UserId"; Values2 = "'" + UserId + "'"; } else { return Validation.ValidUserId; }
                        if (!string.IsNullOrEmpty(RoleId)) { Columns2 = Columns2 + ",RoleId"; Values2 = Values2 + ",'" + RoleId + "'"; }
                        if (!string.IsNullOrEmpty(IsActive)) { Columns2 = Columns2 + ",IsActive"; Values2 = Values2 + ",'" + IsActive + "'"; }
                        if (!string.IsNullOrEmpty(CreatedDate)) { Columns2 = Columns2 + ",CreatedDate"; Values2 = Values2 + ",'" + CreatedDate + "'"; }
                        if (!string.IsNullOrEmpty(CreatedBy)) { Columns2 = Columns2 + ",CreatedBy"; Values2 = Values2 + ",'" + CreatedBy + "'"; }
                        if (!string.IsNullOrEmpty(Columns2) && !string.IsNullOrEmpty(Values2))
                        {
                            QueryBuilder.InsertInDB("tbluserroles", Columns2, Values2);
                        }
                    }

                }
                if (IsAdd) { ReturnVal = Validation.SuccessAddUser; }
                return ReturnVal;
            }
            catch
            {
                return Validation.ErrorComman;
            }
            finally
            {

            }
        }

        [HttpGet]
        public DataTable GetUserList()
        {
            try
            {
                AppLog.WriteErrorLog("Function (GET) : User/GetUserList");
                DataTable dt = QueryBuilder.GetDataTable("*", "tblusers inner join tbluserroles on tbluserroles.UserId = tblusers.UserId Inner Join mtblroles on tbluserroles.RoleId = mtblroles.id", string.Empty);
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {

            }
        }

        [HttpGet]
        public DataTable GetUser(string UserId)
        {
            try
            {
                AppLog.WriteErrorLog("Function (GET) : User/GetUser");
                DataTable dt = QueryBuilder.GetDataTable("*", "tblusers inner join tbluserroles on tbluserroles.UserId = tblusers.UserId Inner Join mtblroles on tbluserroles.RoleId = mtblroles.id", "Where tblusers.UserId = '" + UserId + "'");
                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {

            }
        }

        [HttpPost]
        public string DeleteUser(string PriUserId)
        {
            try
            {
                AppLog.WriteErrorLog("Function (POST) : User/DeleteUser");
                bool IsAdd = false; string ReturnVal = Validation.UnsuccessDeleteUser;
                if (!string.IsNullOrEmpty(PriUserId)) { IsAdd = QueryBuilder.UpdateDB("IsActive = 0", "tblusers", "Where id = '" + PriUserId + "'"); }
                if (IsAdd) { ReturnVal = Validation.SuccessDeleteUser; }
                return ReturnVal;
            }
            catch
            {
                return Validation.ErrorComman;
            }
            finally
            {

            }

        }

        [HttpPost]
        public string UpdateUser(string PriUserId, string FirstName, string MiddleName, string LastName, string UserId, string Password, string RoleId, string EmailId, string Phone, string IsActive, string ModifiedDate, string ModifiedBy, string PasswordModifiedDate)
        {
            try
            {
                AppLog.WriteErrorLog("Function (POST) : User/UpdateUser");
                if (!Validation.DuplicateUpdateUserId(UserId, PriUserId).Equals("1")) { return Validation.ValidDuplicateUserId; }
                if (!Validation.DuplicateUpdateEmailId(EmailId, PriUserId).Equals("1")) { return Validation.ValidDuplicateEmailId; }
                if (!Validation.DuplicateUpdatePhone(Phone, PriUserId).Equals("1")) { return Validation.ValidDuplicatePhone; }
                string UserName = QueryBuilder.GetStr("UserId", "tblusers", "Where id = '" + PriUserId + "'");
                bool IsAdd = false; string ReturnVal = Validation.UnsuccessUpdateUser; string ColumnsValues = string.Empty;
                if (!string.IsNullOrEmpty(FirstName)) { ColumnsValues = "FirstName = '" + FirstName + "'"; }
                if (!string.IsNullOrEmpty(MiddleName)) { ColumnsValues = ColumnsValues + ",MiddleName = '" + MiddleName + "'"; }
                if (!string.IsNullOrEmpty(LastName)) { ColumnsValues = ColumnsValues + ",LastName = '" + LastName + "'"; }
                if (!string.IsNullOrEmpty(UserId)) { ColumnsValues = ColumnsValues + ",UserId = '" + UserId + "'"; }
                if (!string.IsNullOrEmpty(Password)) { ColumnsValues = ColumnsValues + ",Password = '" + Password + "'"; }
                if (!string.IsNullOrEmpty(EmailId)) { ColumnsValues = ColumnsValues + ",EmailId = '" + EmailId + "'"; }
                if (!string.IsNullOrEmpty(Phone)) { ColumnsValues = ColumnsValues + ",Phone = '" + Phone + "'"; }
                if (!string.IsNullOrEmpty(IsActive)) { ColumnsValues = ColumnsValues + ",IsActive = '" + IsActive + "'"; }
                if (!string.IsNullOrEmpty(ModifiedDate)) { ColumnsValues = ColumnsValues + ",ModifiedDate = '" + ModifiedDate + "'"; }
                if (!string.IsNullOrEmpty(ModifiedBy)) { ColumnsValues = ColumnsValues + ",ModifiedBy = '" + ModifiedBy + "'"; }
                if (!string.IsNullOrEmpty(PasswordModifiedDate)) { ColumnsValues = ColumnsValues + ",PasswordModifiedDate = '" + PasswordModifiedDate + "'"; }
                if (!string.IsNullOrEmpty(ColumnsValues)) { IsAdd = QueryBuilder.UpdateDB(ColumnsValues, "tblusers", "Where id = '" + PriUserId + "'"); }
                if (IsAdd)
                {
                    string ColumnsValues1 = string.Empty;
                    if (!string.IsNullOrEmpty(RoleId)) { ColumnsValues1 = "RoleId = '" + RoleId + "'"; }
                    if (!string.IsNullOrEmpty(UserId)) { ColumnsValues1 = ColumnsValues1 + ",UserId = '" + UserId + "'"; }
                    if (!string.IsNullOrEmpty(ColumnsValues1)) { QueryBuilder.UpdateDB(ColumnsValues1, "tbluserroles", "Where UserId = '" + UserName + "'"); }
                    ReturnVal = Validation.SuccessUpdateUser;
                }
                return ReturnVal;
            }
            catch
            {
                return Validation.ErrorComman;
            }
            finally
            {

            }

        }

        [HttpGet]
        public string GetValidUser(string Username, string Password)
        {
            try
            {
                AppLog.WriteErrorLog("Function (GET) : User/GetValidUser");
                string ReturnValue = Validation.ValidLogin;
                string AuthToken = Guid.NewGuid().ToString().Substring(0, 8);
                bool IsUpdate = QueryBuilder.UpdateDB("AuthToken = '" + AuthToken + "'", "tbluserauthtokens", "Where UserId = '" + Username + "'");
                if (IsUpdate)
                {
                    DataTable dt = QueryBuilder.GetDataTable("tbluserauthtokens.AuthToken", "tblusers inner join tbluserauthtokens on tbluserauthtokens.userid = tblusers.userid ", "Where tblusers.UserId = '" + Username + "' AND tblusers.Password = '" + Password + "'");


                    if (dt.Rows.Count > 0)
                    {
                        string AuthToken1 = dt.Rows[0]["AuthToken"].ToString();

                        if (!string.IsNullOrEmpty(AuthToken1))
                        {
                            ReturnValue = AuthToken1;
                        }
                    }
                }
                return ReturnValue;
            }
            catch
            {
                return null;
            }
            finally
            {

            }
        }

        [HttpGet]
        public string GetValidLogin(string Username, string Password)
        {
            try
            {
                AppLog.WriteErrorLog("Function (GET) : User/GetValidLogin");
                string ReturnValue = Validation.ValidLogin;
                // dynamic json = JsonConvert.DeserializeObject(ReturnValue);
                string AuthToken = Guid.NewGuid().ToString().Substring(0, 8);
                bool IsUpdate = QueryBuilder.UpdateDB("AuthToken = '" + AuthToken + "'", "tbluserauthtokens", "Where UserId = '" + Username + "'");
                if (IsUpdate)
                {
                    DataTable dt = QueryBuilder.GetDataTable("tbluserauthtokens.AuthToken", "tblusers inner join tbluserauthtokens on tbluserauthtokens.userid = tblusers.userid ", "Where tblusers.UserId = '" + Username + "' AND tblusers.Password = '" + Password + "'");


                    if (dt.Rows.Count > 0)
                    {
                        string AuthToken1 = dt.Rows[0]["AuthToken"].ToString();

                        if (!string.IsNullOrEmpty(AuthToken1))
                        {
                            ReturnValue = AuthToken1;
                        }
                    }
                }

                return ReturnValue;
            }
            catch
            {
                return null;
            }
            finally
            {

            }
        }
    }
}