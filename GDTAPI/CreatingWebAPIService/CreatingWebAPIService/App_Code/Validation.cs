using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


namespace DevetchAPI
{
    public class Validation
    {
        #region Validations
        public static string ValidFirstName = "{\"ResponseCode\" : 2 , \"Message\" : \"First name field can not be blank.\" }";
        public static string ValidUserId = "{\"ResponseCode\" : 2 , \"Message\" : \"User Id field can not be blank.\" }";
        public static string ValidRoleId = "{\"ResponseCode\" : 2 , \"Message\" : \"Role field can not be blank.\" }";
        public static string ValidPassword = "{\"ResponseCode\" : 2 , \"Message\" : \"Password field can not be blank.\" }";
        public static string ValidEmail = "{\"ResponseCode\" : 2 , \"Message\" : \"Email field can not be blank.\" }";

        public static string ValidDuplicateUserId = "{\"ResponseCode\" : 3 , \"Message\" : \"This user id is already exists, please try again with another user id.\" }";
        public static string ValidDuplicateEmailId = "{\"ResponseCode\" : 3 , \"Message\" : \"This email id is already exists, please try again with another email id.\" }";
        public static string ValidDuplicatePhone = "{\"ResponseCode\" : 3 , \"Message\" : \"This phone is already exists, please try again with another phone.\" }";
        public static string ValidDuplicateAuthToken = "{\"ResponseCode\" : 3 , \"Message\" : \"This auth token is already exists, please try again with another auth token.\" }";
        public static string ValidDuplicateDeviceId = "{\"ResponseCode\" : 3 , \"Message\" : \"This device id is already exists, please try again with another device id.\" }";
        public static string ValidDuplicateRoleId = "{\"ResponseCode\" : 3 , \"Message\" : \"This role is already existing, please try again with another role.\" }";
        // public static string ValidLogin = "[{\"\"ResponseCode\"\" : 3 , \"\"Message\"\" : \"This user is not exists, please try again with valid username or password.\" }]";
        public static string ValidLogin = "[{\"ResponseCode\": 3,\"Message\": \"This user is not exists, please try again with valid username or password.\"}]";

        #endregion

        #region Success \"Message\"
        public static string SuccessAddUser = "{\"ResponseCode\" : 1 , \"Message\" : \"User has been added successfully.\" }";
        public static string SuccessDeleteUser = "{\"ResponseCode\" : 1 , \"Message\" : \"User has been deleted successfully.\" }";
        public static string SuccessUpdateUser = "{\"ResponseCode\" : 1 , \"Message\" : \"User has been updated successfully.\" }";
        public static string SuccessAddToken = "{\"ResponseCode\" : 1 , \"Message\" : \"Token has been updated successfully.\" }";
        public static string SuccessDeleteToken = "{\"ResponseCode\" : 1 , \"Message\" : \"Token has been deleted successfully.\" }";
        public static string SuccessUpdateToken = "{\"ResponseCode\" : 1 , \"Message\" : \"Token has been updated successfully.\" }";
        public static string SuccessRoleUser = "{\"ResponseCode\" : 1 , \"Message\" : \"Role has been added successfully.\" }";
        public static string SuccessDeleteRole = "{\"ResponseCode\" : 1 , \"Message\" : \"Role has been deleted successfully.\" }";
        public static string SuccessUpdateRole = "{\"ResponseCode\" : 1 , \"Message\" : \"Role has been updated successfully.\" }";
        public static string SuccessActivity = "{\"ResponseCode\" : 1 , \"Message\" : \"Activity has been added successfully.\" }";
        public static string SuccessUpdateUserToken = "{\"ResponseCode\" : 1 , \"Message\" : \"Token has been updated successfully.\" }";
        public static string SuccessEnergyParameter = "{\"ResponseCode\" : 1 , \"Message\" : \"Energy meter parameter has been updated successfully.\" }";
        public static string SuccessLogin = "{\"ResponseCode\" : 1 , \"Message\" : \"User is valid.\" }";
        public static string SuccessDeviceProfile = "{\"ResponseCode\" : 1 , \"Message\" : \"Device profile is set.\" }";
        #endregion

        #region Unsuccess \"Message\"
        public static string UnsuccessAddUser = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, user not added.\" }";
        public static string UnsuccessDeleteUser = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, user not deleted.\" }";
        public static string UnsuccessUpdateUser = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, user not updated.\" }";
        public static string UnsuccessAddToken = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, token not added.\" }";
        public static string UnsuccessDeleteToken = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, token not deleted.\" }";
        public static string UnsuccessUpdateToken = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, token not updated.\" }";
        public static string UnsuccessRoleUser = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, role not added.\" }";
        public static string UnsuccessDeleteRole = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, role not deleted.\" }";
        public static string UnsuccessUpdateRole = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, role not updated.\" }";
        public static string UnsuccessActivity = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, activity not updated.\" }";
        public static string UnsuccessUpdateUserToken = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, token not updated.\" }";
        public static string UnsuccessEnergyParameter = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, energy meter parameter not updated.\" }";
        public static string UnsuccessDeviceProfile = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request, device profile not created.\" }";
        #endregion

        #region Error \"Message\"
        public static string ErrorComman = "{\"ResponseCode\" : 0 , \"Message\" : \"Oops! Something went wrong while processing your request.\" }";
        #endregion

        #region Duplicate Check
        public static string DuplicateUserId(string UserId)
        {
            try
            {
                string ReturnMsg = "1";
                Int32 CountUser = QueryBuilder.GetInt("Count(*)", "tblusers", "Where UserId = '" + UserId + "'");
                if(CountUser > 0) { ReturnMsg = ValidDuplicateUserId.ToString(); }
                return ReturnMsg;
            }
            catch(Exception ex)
            {
                return ErrorComman;
            }
            finally
            {

            }
        }

        public static string DuplicateEmailId(string EmailId)
        {
            try
            {
                string ReturnMsg = "1";
                Int32 CountUser = QueryBuilder.GetInt("Count(*)", "tblusers", "Where EmailId = '" + EmailId + "'");
                if (CountUser > 0) { ReturnMsg = ValidDuplicateEmailId.ToString(); }
                return ReturnMsg;
            }
            catch (Exception ex)
            {
                return ErrorComman;
            }
            finally
            {

            }
        }

        public static string DuplicatePhone(string Phone)
        {
            try
            {
                string ReturnMsg = "1";
                Int32 CountUser = QueryBuilder.GetInt("Count(*)", "tblusers", "Where Phone = '" + Phone + "'");
                if (CountUser > 0) { ReturnMsg = ValidDuplicatePhone.ToString(); }
                return ReturnMsg;
            }
            catch (Exception ex)
            {
                return ErrorComman;
            }
            finally
            {

            }
        }

        public static string DuplicateAuthToken(string UserId, string AuthToken, string DeviceId)
        {
            try
            {
                string ReturnMsg = "1";
                Int32 CountUser = QueryBuilder.GetInt("Count(*)", "tbluserauthtokens", "Where UserId = '" + UserId + "' And AuthToken = '" + AuthToken + "' And DeviceId = '" + DeviceId + "'");
                if (CountUser > 0) { ReturnMsg = ValidDuplicateAuthToken.ToString(); }
                return ReturnMsg;
            }
            catch (Exception ex)
            {
                return ErrorComman;
            }
            finally
            {

            }
        }

        public static string DuplicateUpdateUserId(string UserId, string PriUserId)
        {
            try
            {
                string ReturnMsg = "1";
                Int32 CountUser = QueryBuilder.GetInt("Count(*)", "tblusers", "Where UserId = '" + UserId + "' And id != '" + PriUserId + "'");
                if (CountUser > 0) { ReturnMsg = ValidDuplicateUserId.ToString(); }
                return ReturnMsg;
            }
            catch (Exception ex)
            {
                return ErrorComman;
            }
            finally
            {

            }
        }

        public static string DuplicateUpdateEmailId(string EmailId, string PriUserId)
        {
            try
            {
                string ReturnMsg = "1";
                Int32 CountUser = QueryBuilder.GetInt("Count(*)", "tblusers", "Where EmailId = '" + EmailId + "' And id != '" + PriUserId + "'");
                if (CountUser > 0) { ReturnMsg = ValidDuplicateEmailId.ToString(); }
                return ReturnMsg;
            }
            catch (Exception ex)
            {
                return ErrorComman;
            }
            finally
            {

            }
        }

        public static string DuplicateUpdatePhone(string Phone, string PriUserId)
        {
            try
            {
                string ReturnMsg = "1";
                Int32 CountUser = QueryBuilder.GetInt("Count(*)", "tblusers", "Where Phone = '" + Phone + "' And id != '" + PriUserId + "'");
                if (CountUser > 0) { ReturnMsg = ValidDuplicatePhone.ToString(); }
                return ReturnMsg;
            }
            catch (Exception ex)
            {
                return ErrorComman;
            }
            finally
            {

            }
        }

        public static string DuplicateRole(string Role)
        {
            try
            {
                string ReturnMsg = "1";
                Int32 CountUser = QueryBuilder.GetInt("Count(*)", "mtblroles", "Where IsActive = 1 AND Role = '" + Role + "'");
                if (CountUser > 0) { ReturnMsg = ValidDuplicateRoleId.ToString(); }
                return ReturnMsg;
            }
            catch (Exception ex)
            {
                return ErrorComman;
            }
            finally
            {

            }
        }

        public static string DuplicateUpdateRole(string Role, string RoleId)
        {
            try
            {
                string ReturnMsg = "1";
                Int32 CountUser = QueryBuilder.GetInt("Count(*)", "mtblroles", "Where Role = '" + Role + "' And id != '" + RoleId + "'");
                if (CountUser > 0) { ReturnMsg = ValidDuplicateRoleId.ToString(); }
                return ReturnMsg;
            }
            catch (Exception ex)
            {
                return ErrorComman;
            }
            finally
            {

            }
        }
        #endregion

    }
}