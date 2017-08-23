using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System;

namespace DevetchAPI
{
    public class DeviceProfileController : ApiController
    {
        [HttpPost]
        public string SetDevice(string DeviceName, string DeviceNo, string UserId)
        {
            string IsSet = Validation.UnsuccessDeviceProfile;
            try
            {
                AppLog.WriteErrorLog("Function (POST) : DeviceProfile/SetDevice");
                DataTable dt = QueryBuilder.GetDataTable("DeviceMastreId", "gdt_device", "Where DeviceNo = '" + DeviceNo + "'");


                if (dt.Rows.Count > 0)
                {
                    bool IsSet1 = false;
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                    IsSet1 = QueryBuilder.UpdateDB("DeviceName = '" + DeviceName + "', HDate = '" + Date + "'", "gdt_device", " Where DeviceNo = '" + DeviceNo + "'");

                    if (IsSet1 == true)
                    {
                        IsSet = Validation.SuccessDeviceProfile;

                        DataTable dt1 = QueryBuilder.GetDataTable("Id", "gdt_deviceprofile",
                        " Where (select DeviceNo from gdt_device where DeviceId = DeviceMastreId LIMIT 1) = '" + DeviceNo + "' AND UserId = '" + UserId + "'");

                        if (dt1.Rows.Count > 0)
                        {
                        }
                        else
                        {
                            bool IsSet2 = false;
                            string Date1 = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                            Int32 DeviceMasterId = QueryBuilder.GetInt("DeviceMastreId", "gdt_device", " Where DeviceNo = '" + DeviceNo + "' LIMIT 1");
                            IsSet2 = QueryBuilder.InsertInDB("gdt_deviceprofile", "DeviceId,UserId,DeviceDateTime,HDate",
                                                             "'" + DeviceMasterId.ToString() + "','" + UserId + "','" + Date1 + "','" + Date1 + "'");
                            if (IsSet2 == true)
                            {
                                IsSet = Validation.SuccessDeviceProfile;
                                SetActivityLog(DeviceMasterId.ToString(), "Profile Created", UserId, Date);
                            }
                        }
                    }
                }
                else
                {
                    bool IsSet1 = false;
                    string Date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;

                    IsSet1 = QueryBuilder.InsertInDB("gdt_device", "DeviceName,DeviceNo,Date,HDate",
                                                     "'" + DeviceName + "','" + DeviceNo + "','" + Date + "','" + Date + "'");
                    if (IsSet1 == true)
                    {
                        IsSet = Validation.SuccessDeviceProfile;
                        Int32 DeviceMasterId = QueryBuilder.GetInt("DeviceMastreId", "gdt_device", " Where DeviceNo = '" + DeviceNo + "' LIMIT 1");
                        SetActivityLog(DeviceMasterId.ToString(), "Device Created", UserId, Date);

                        DataTable dt1 = QueryBuilder.GetDataTable("Id", "gdt_deviceprofile",
                       " Where (select DeviceNo from gdt_device where DeviceId = DeviceMastreId LIMIT 1) = '" + DeviceNo + "' AND UserId = '" + UserId + "'");

                        if (dt1.Rows.Count > 0)
                        {
                        }
                        else
                        {
                            bool IsSet2 = false;
                            string Date1 = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
                            Int32 DeviceMasterId1 = QueryBuilder.GetInt("DeviceMastreId", "gdt_device", " Where DeviceNo = '" + DeviceNo + "' LIMIT 1");
                            IsSet2 = QueryBuilder.InsertInDB("gdt_deviceprofile", "DeviceId,UserId,DeviceDateTime,HDate",
                                                             "'" + DeviceMasterId1.ToString() + "','" + UserId + "','" + Date1 + "','" + Date1 + "'");
                            if (IsSet2 == true)
                            {
                                IsSet = Validation.SuccessDeviceProfile;

                                SetActivityLog(DeviceMasterId1.ToString(), "Profile Created", UserId, Date);
                            }
                        }
                    }
                }
                return IsSet;
            }
            catch (Exception ex)
            {
                return Validation.ErrorComman;
            }
            finally
            {// return IsSet; }
            }

        }

        [HttpGet]
        public string[] GetDeviceProfileList(string UserId)
        {
            string[] UseList = null;
            try
            {
                AppLog.WriteErrorLog("Function (GET) : DeviceProfile/GetDeviceProfileList");
                if (UserId != "-2")
                {
                    UseList = QueryBuilder.GetArrayList("CONCAT(DeviceMastreId,'-',DeviceName, '-', DeviceNo,'-',DeviceDateTime,'-',UserId) AS FullName",
                        "gdt_deviceprofile AS gdtdp Inner Join  gdt_device AS gdtd ON gdtd.DeviceMastreId = gdtdp .DeviceId",
                        " Where UserId = '" + UserId + "'");
                }
                else
                {
                    UseList = QueryBuilder.GetArrayList("CONCAT(DeviceMastreId,'-',DeviceName, '-', DeviceNo,'-',DeviceDateTime,'-',UserId) AS FullName",
                                            "gdt_deviceprofile AS gdtdp Inner Join  gdt_device AS gdtd ON gdtd.DeviceMastreId = gdtdp .DeviceId",
                                            " group by DeviceMastreId ");
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {

            }
            return UseList;
        }

        [HttpGet]
        public string GetDeviceProfileDetails(string DeviceId)
        {
            string UseList = null;
            try
            {
                AppLog.WriteErrorLog("Function (GET) : DeviceProfile/GetDeviceProfileDetails");
                UseList = QueryBuilder.GetStr("CONCAT(DeviceMastreId,'-',DeviceName,'-',DeviceNo,'-',IFNULL(RTC,0),'-',IFNULL(Latitude,0),'-',IFNULL(Longitude,0),'-',IFNULL(RPH,0),'-',IFNULL(YPH,0),'-',IFNULL(BPH,0)) AS DeviceDetails",
                    "devicedetails", " Where DeviceMastreId = '" + DeviceId + "'");
            }
            catch (Exception ex)
            {
                return Validation.ErrorComman;
            }
            finally
            {

            }
            return UseList;
        }

        public string[] GetDeviceScheduleList(string DeviceId)
        {
            string[] UseList = null;
            try
            {
                AppLog.WriteErrorLog("Function : DeviceProfile/GetDeviceScheduleList");
                UseList = QueryBuilder.GetArrayList("CONCAT(Intervall,'-',RPhase,'-', YPhase,'-',BPhase,'-',SunriseSunset,'-',ScheduleType) AS FullName",
                    "gdt_deviceschedule",
                    " Where (DeviceId = '" + DeviceId + "') AND (IsActive = 1)");

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {

            }
            return UseList;
        }

        private void SetActivityLog(string DeviceId, string HType, string UserId, string HDate)
        {
            try
            {
                AppLog.WriteErrorLog("Function : DeviceProfile/SetActivityLog");
                bool IsSet1 = false;
                IsSet1 = QueryBuilder.InsertInDB("gdt_activitylog", "DeviceId,MHDate,HType,UserId",
                                                 "'" + DeviceId + "','" + HDate + "','" + HType + "','" + UserId + "'");
            }
            catch (Exception ex) { }
            finally { }
        }
    }
}