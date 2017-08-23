using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System;


namespace DevetchAPI
{
    public class ActivityLogController : ApiController
    {
        [HttpPost]
        public string SetActivityLog(string DeviceNo, string HType, string UserId, string Value1, string Value2, string Value3)
        {
           
            string IsSet = Validation.UnsuccessActivity;
            try
            {
                if (string.IsNullOrEmpty(Value1)) { Value1 = "NULL"; }
                if (string.IsNullOrEmpty(Value2)) { Value2 = "NULL"; }
                if (string.IsNullOrEmpty(Value3)) { Value3 = "NULL"; }

                AppLog.WriteErrorLog("Function : ActivityLog/SetActivityLog  | DeviceNo : " + DeviceNo + " | HType : " + HType + " | UserId : " + UserId + " | Value1 : " + Value1 + " | Value2 : " + Value2 + " | Value3 : " + Value3);
                string DeviceMasterId = DeviceNo;

                if (HType == "Set RTC")
                {
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                    SetActivityLogg(DeviceMasterId.ToString(), "Set RTC", UserId, Date, Value1, Value2, Value3);
                    IsSet = Validation.SuccessActivity;
                }
                if (HType == "Set Lat Long")
                {
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                    SetActivityLogg(DeviceMasterId.ToString(), "Set Lat Long", UserId, Date, Value1, Value2, Value3);
                    IsSet = Validation.SuccessActivity;
                }
                if (HType == "Phase switch")
                {
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                    SetActivityLogg(DeviceMasterId.ToString(), "Phase switch", UserId, Date, Value1, Value2, Value3);
                    IsSet = Validation.SuccessActivity;
                }
                if (HType == "Lamp control")
                {
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                    SetActivityLogg(DeviceMasterId.ToString(), "Lamp control", UserId, Date, Value1, Value2, Value3);
                    IsSet = Validation.SuccessActivity;
                }
                if (HType == "4 CH Lamp control")
                {
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                    SetActivityLogg(DeviceMasterId.ToString(), "4 CH Lamp control", UserId, Date, Value1, Value2, Value3);
                    IsSet = Validation.SuccessActivity;
                }
                if (HType == "Get Time")
                {
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                    SetActivityLogg(DeviceMasterId.ToString(), "Get Time", UserId, Date, Value1, Value2, Value3);
                    IsSet = Validation.SuccessActivity;
                }
                if (HType == "Smart Scheduling")
                {
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                    SetActivityLogg(DeviceMasterId.ToString(), "Smart Scheduling", UserId, Date, Value1, Value2, Value3);
                    IsSet = Validation.SuccessActivity;
                }
                if (HType == "Set Astro Schedule")
                {
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                    SetActivityLogg(DeviceMasterId.ToString(), "Set Astro Schedule", UserId, Date, Value1, Value2, Value3);
                    IsSet = Validation.SuccessActivity;
                }
                if (HType == "Device Connected")
                {
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                    SetActivityLogg(DeviceMasterId.ToString(), "Device Connected", UserId, Date, Value1, Value2, Value3);
                    IsSet = Validation.SuccessActivity;
                }
                if (HType == "Device Disconneced")
                {
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                    SetActivityLogg(DeviceMasterId.ToString(), "Device Disconneced", UserId, Date, Value1, Value2, Value3);
                    IsSet = Validation.SuccessActivity;
                }

                return IsSet;
            }
            catch (Exception ex) { return IsSet; }
            finally { }
        }

        private void SetActivityLogg(string DeviceId, string HType, string UserId, string HDate, string Value1, string Value2, string Value3)
        {
            try
            {
                AppLog.WriteErrorLog("Function : ActivityLog/SetActivityLogg");
                bool IsSet1 = false;
                IsSet1 = QueryBuilder.InsertInDB("gdt_activitylog", "DeviceId,MHDate,HType,UserId,Value1,Value2,Value3",
                                                 "'" + DeviceId + "','" + HDate + "','" + HType + "','" + UserId + "','" + Value1 + "','" + Value2  + "','" + Value3 + "'");
            }
            catch (Exception ex) { }
            finally { }
        }

        [HttpGet]
        public DataTable GetActivityList()
        {
            try
            {
                AppLog.WriteErrorLog("Function : ActivityLog/GetActivityList");
                DataTable dt = QueryBuilder.GetDataTable("*", "gdt_activitylog", string.Empty);
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
        public DataTable GetActivity(string UserId)
        {
            try
            {
                AppLog.WriteErrorLog("Function : ActivityLog/GetActivity");
                DataTable dt = QueryBuilder.GetDataTable("*", "gdt_activitylog", "Where UserId = '" + UserId + "'");
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
    }
}