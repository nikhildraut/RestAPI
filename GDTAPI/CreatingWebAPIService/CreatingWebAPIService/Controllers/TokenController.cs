using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;

namespace DevetchAPI
{
    public class TokenController : ApiController
    {
        [HttpPost]
        public string AddToken(string UserId, string DeviceId, string IsActive, string CreatedDate, string CreatedBy)
        {
            try
            {
                AppLog.WriteErrorLog("Function (POST) : Token/AddToken");
                string AuthToken = Guid.NewGuid().ToString().Substring(0, 8);
                if (!Validation.DuplicateAuthToken(UserId, AuthToken, DeviceId).Equals("1")) { return Validation.ValidDuplicateAuthToken; }
                bool IsAdd = false; string ReturnVal = Validation.UnsuccessAddToken; string Columns = string.Empty; string Values = string.Empty;
                if (!string.IsNullOrEmpty(UserId)) { Columns = "UserId"; Values = "'" + UserId + "'"; } else { return Validation.ValidDuplicateUserId; }
                if (!string.IsNullOrEmpty(AuthToken)) { Columns = Columns + ",AuthToken"; Values = Values + ",'" + AuthToken + "'"; } else { return Validation.ValidDuplicateAuthToken; }
                if (!string.IsNullOrEmpty(DeviceId)) { Columns = Columns + ",DeviceId"; Values = Values + ",'" + DeviceId + "'"; } else { return Validation.ValidDuplicateDeviceId; }
                if (!string.IsNullOrEmpty(UserId)) { Columns = Columns + ",UserId"; Values = Values + ",'" + UserId + "'"; }
                if (!string.IsNullOrEmpty(IsActive)) { Columns = Columns + ",IsActive"; Values = Values + ",'" + IsActive + "'"; }
                if (!string.IsNullOrEmpty(CreatedDate)) { Columns = Columns + ",CreatedDate"; Values = Values + ",'" + CreatedDate + "'"; }
                if (!string.IsNullOrEmpty(CreatedBy)) { Columns = Columns + ",CreatedBy"; Values = Values + ",'" + CreatedBy + "'"; }

                if (!string.IsNullOrEmpty(Columns) && !string.IsNullOrEmpty(Values)) { IsAdd = QueryBuilder.InsertInDB("tbluserauthtokens", Columns, Values); }
                if (IsAdd) { ReturnVal = Validation.SuccessAddToken; }
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
        public DataTable GetToken(string UserId)
        {
            try
            {
                AppLog.WriteErrorLog("Function (GET) : Token/GetToken");
                DataTable dt = QueryBuilder.GetDataTable("*", "tbluserauthtokens", "Where UserId = '" + UserId + "'");
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
        public string DeleteUser(string TokenId)
        {
            try
            {
                AppLog.WriteErrorLog("Function (POST) : Token/DeleteUser");
                bool IsAdd = false; string ReturnVal = Validation.UnsuccessDeleteToken;
                if (!string.IsNullOrEmpty(TokenId)) { IsAdd = QueryBuilder.UpdateDB("IsActive = 0", "tbluserauthtokens", "Where id = '" + TokenId + "'"); }
                if (IsAdd) { ReturnVal = Validation.SuccessDeleteToken; }
                return ReturnVal;
            }
            catch
            {
                return Validation.ErrorComman; ;
            }
            finally
            {

            }

        }

        [HttpPost]
        public string UpdateToken(string TokenId, string UserId, string AuthToken, string DeviceId, string IsActive, string ModifiedDate, string ModifiedBy)
        {
            try
            {
                AppLog.WriteErrorLog("Function (POST) : Token/UpdateToken");
                bool IsAdd = false; string ReturnVal = Validation.UnsuccessUpdateToken; string ColumnsValues = string.Empty;
                if (!string.IsNullOrEmpty(UserId)) { ColumnsValues = "UserId = '" + UserId + "'"; }
                if (!string.IsNullOrEmpty(AuthToken)) { ColumnsValues = ColumnsValues + ",AuthToken = '" + AuthToken + "'"; }
                if (!string.IsNullOrEmpty(DeviceId)) { ColumnsValues = ColumnsValues + ",DeviceId = '" + DeviceId + "'"; }
                if (!string.IsNullOrEmpty(UserId)) { ColumnsValues = ColumnsValues + ",UserId = '" + UserId + "'"; }
                if (!string.IsNullOrEmpty(IsActive)) { ColumnsValues = ColumnsValues + ",IsActive = '" + IsActive + "'"; }
                if (!string.IsNullOrEmpty(ModifiedDate)) { ColumnsValues = ColumnsValues + ",ModifiedDate = '" + ModifiedDate + "'"; }
                if (!string.IsNullOrEmpty(ModifiedBy)) { ColumnsValues = ColumnsValues + ",ModifiedBy = '" + ModifiedBy + "'"; }

                if (!string.IsNullOrEmpty(ColumnsValues)) { IsAdd = QueryBuilder.UpdateDB(ColumnsValues, "tbluserauthtokens", "Where id = '" + TokenId + "'"); }
                if (IsAdd) { ReturnVal = Validation.SuccessUpdateToken; }
                return ReturnVal;
            }
            catch
            {
                return Validation.ErrorComman; ;
            }
            finally
            {

            }

        }

        [HttpPost]
        public string UpdateUserToken(string UserId)
        {
            try
            {
                AppLog.WriteErrorLog("Function (POST) : Token/UpdateUserToken");
                bool IsAdd = false; string ReturnVal = Validation.UnsuccessUpdateUserToken; string ColumnsValues = string.Empty; string AuthToken = Guid.NewGuid().ToString().Substring(0, 8);
                if (!string.IsNullOrEmpty(AuthToken)) { ColumnsValues = "AuthToken = '" + AuthToken + "'"; }
                if (!string.IsNullOrEmpty(ColumnsValues)) { IsAdd = QueryBuilder.UpdateDB(ColumnsValues, "tbluserauthtokens", "Where UserId = '" + UserId + "'"); }
                if (IsAdd) { ReturnVal = Validation.SuccessUpdateUserToken; }
                return ReturnVal;
            }
            catch (Exception ex)
            {
                return Validation.ErrorComman;
            }
            finally
            {

            }
        }
    }
}