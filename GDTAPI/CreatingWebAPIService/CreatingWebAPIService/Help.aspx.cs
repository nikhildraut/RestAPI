using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.NetworkInformation;

namespace DevetchAPI
{
    public partial class Help : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblAllNodesOnOffDim.InnerText = Request.ServerVariables["REMOTE_ADDR"].ToString();


                HostedInfo();
            }
            catch (Exception ex)
            {
                string Error = ex.Message;
            }
            finally
            {

            }
        }

        private void HostedInfo()
        {
            try
            {
                lblAllNodesOnOffDim.InnerText = "http://" + Comman.IPAddress + ":" + Comman.IISPort + "/DevtechAPI/AllNodesOnOffDim";
                lblSingleNodeOnOffDim.InnerText = "http://" + Comman.IPAddress + ":" + Comman.IISPort + "/DevtechAPI/SingleNodeOnOffDim";
                lblSingleNodeGetEnergyData.InnerText = "http://" + Comman.IPAddress + ":" + Comman.IISPort + "/DevtechAPI/SingleNodeGetEnergyData";
                lblBPhaseOnOff.InnerText = "http://" + Comman.IPAddress + ":" + Comman.IISPort + "/DevtechAPI/BPhaseOnOff";
                lblGetCurrentStatus.InnerText = "http://" + Comman.IPAddress + ":" + Comman.IISPort + "/DevtechAPI/GetCurrentStatus";
                lblSetRTC.InnerText = "http://" + Comman.IPAddress + ":" + Comman.IISPort + "/DevtechAPI/SetRTC";
            }
            catch (Exception ex)
            {
                string Error = ex.Message;
            }
            finally
            {

            }
        }
    }
}