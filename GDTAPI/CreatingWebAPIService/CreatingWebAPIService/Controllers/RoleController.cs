using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;

namespace DevetchAPI
{
    public class RoleController : ApiController
    {
        [HttpPost]
        public string AddRole(string Role, string RoleDescription, string IsActive, string CreatedDate, string CreatedBy)
        {
            try
            {
                AppLog.WriteErrorLog("Function (POST) : Role/AddRole");
                if (!Validation.DuplicateRole(Role).Equals("1")) { return Validation.ValidDuplicateRoleId; }
                bool IsAdd = false; string ReturnVal = Validation.UnsuccessRoleUser; string Columns = string.Empty; string Values = string.Empty;
                if (!string.IsNullOrEmpty(Role)) { Columns = "Role"; Values = "'" + Role + "'"; } else { return Validation.ValidDuplicateRoleId; }
                if (!string.IsNullOrEmpty(RoleDescription)) { Columns = Columns + ",RoleDescription"; Values = Values + ",'" + RoleDescription + "'"; }
                if (!string.IsNullOrEmpty(IsActive)) { Columns = Columns + ",IsActive"; Values = Values + ",'" + IsActive + "'"; }
                if (!string.IsNullOrEmpty(CreatedDate)) { Columns = Columns + ",CreatedDate"; Values = Values + ",'" + CreatedDate + "'"; }
                if (!string.IsNullOrEmpty(CreatedDate)) { Columns = Columns + ",ModifiedDate"; Values = Values + ",'" + CreatedDate + "'"; }
                if (!string.IsNullOrEmpty(CreatedBy)) { Columns = Columns + ",CreatedBy"; Values = Values + ",'" + CreatedBy + "'"; }

                if (!string.IsNullOrEmpty(Columns) && !string.IsNullOrEmpty(Values)) { IsAdd = QueryBuilder.InsertInDB("mtblroles", Columns, Values); }
                if (IsAdd) { ReturnVal = Validation.SuccessRoleUser; }
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
        public DataTable GetRoleList()
        {
            try
            {
                AppLog.WriteErrorLog("Function (GET) : Role/GetRoleList");
                DataTable dt = QueryBuilder.GetDataTable("*", "mtblroles", string.Empty);
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
        public DataTable GetRole(string RoleId)
        {
            try
            {
                AppLog.WriteErrorLog("Function (GET) : Role/GetRole");
                DataTable dt = QueryBuilder.GetDataTable("*", "mtblroles", "Where id = '" + RoleId + "'");
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
        public string DeleteRole(string RoleId)
        {
            try
            {
                AppLog.WriteErrorLog("Function (POST) : Role/DeleteRole");
                bool IsAdd = false; string ReturnVal = Validation.UnsuccessDeleteRole;
                if (!string.IsNullOrEmpty(RoleId)) { IsAdd = QueryBuilder.UpdateDB("IsActive = 0", "mtblroles", "Where id = '" + RoleId + "'"); }
                if (IsAdd) { ReturnVal = Validation.SuccessDeleteRole; }
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
        public string UpdateRole(string RoleId, string Role, string RoleDescription, string IsActive, string ModifiedDate, string ModifiedBy)
        {
            try
            {
                AppLog.WriteErrorLog("Function (POST) : Role/UpdateRole");
                if (!Validation.DuplicateUpdateUserId(Role, RoleId).Equals("1")) { return Validation.ValidDuplicateRoleId; }
                bool IsAdd = false; string ReturnVal = Validation.UnsuccessUpdateRole; string ColumnsValues = string.Empty;
                if (!string.IsNullOrEmpty(Role)) { ColumnsValues = "Role = '" + Role + "'"; }
                if (!string.IsNullOrEmpty(Role)) { ColumnsValues = ColumnsValues + ",RoleDescription = '" + RoleDescription + "'"; }
                if (!string.IsNullOrEmpty(Role)) { ColumnsValues = ColumnsValues + ",IsActive = '" + IsActive + "'"; }
                if (!string.IsNullOrEmpty(Role)) { ColumnsValues = ColumnsValues + ",ModifiedDate = '" + ModifiedDate + "'"; }
                if (!string.IsNullOrEmpty(Role)) { ColumnsValues = ColumnsValues + ",ModifiedBy = '" + ModifiedBy + "'"; }
                if (!string.IsNullOrEmpty(ColumnsValues)) { IsAdd = QueryBuilder.UpdateDB(ColumnsValues, "mtblroles", "Where id = '" + RoleId + "'"); }
                if (IsAdd) { ReturnVal = Validation.SuccessUpdateRole; }
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
    }
}