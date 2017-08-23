using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System;

namespace DevetchAPI
{
    public class EnergyParameterController : ApiController
    {
        [HttpPost]
        public string SetEnergyMeterParameter(string MacId, string EPRowNo, string EPDate, string EPMonth, string EPYear, string EPHour, string EPMinute,
            string EPCumulativeActiveEnergy, string EPAveragePowerFactor, string EPPowerONHours, string EPMonthlyLoadONCount, string EPMonthlyLoadOFFCount)
        {
            AppLog.WriteErrorLog("Function (POST) : EnergyParameter/SetEnergyMeterParameter");
            bool IsRecordStore = false;
            string ReturnVal = Validation.UnsuccessEnergyParameter;
            try
            {
                IsRecordStore = QueryBuilder.InsertInDB("gdt_energymeterparameter",
                    "MacId,EPRowNo,EPDate,EPMonth,EPYear,EPHour,EPMinute,EPCumulativeActiveEnergy,EPAveragePowerFactor,EPPowerONHours,EPMonthlyLoadONCount,EPMonthlyLoadOFFCount,EPRecordDate",
                    "'" + MacId + "','" + EPRowNo + "','" + EPDate + "','" + EPMonth + "','" + EPYear + "','" + EPHour + "','" + EPMinute + "','" + EPCumulativeActiveEnergy + "','" +
                    EPAveragePowerFactor + "','" + EPPowerONHours + "','" + EPMonthlyLoadONCount + "','" + EPMonthlyLoadOFFCount + "','" + DateTime.Now + "'");

                if (IsRecordStore) { ReturnVal = Validation.SuccessEnergyParameter; }
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