using System;
using System.Configuration;
using System.ServiceProcess;


namespace DevetchAPI
{
    public class Comman
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public static int Port = Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);
        public static string IPAddress = ConfigurationManager.AppSettings["IPAddress"];
        public static string IISPort = ConfigurationManager.AppSettings["IISPort"];
        public static int Interval = Convert.ToInt32(ConfigurationManager.AppSettings["Interval"]);

        //public static void RestartWindowsService(string serviceName)
        //{
        //    ServiceController serviceController = new ServiceController(serviceName);
        //    try
        //    {
        //        if ((serviceController.Status.Equals(ServiceControllerStatus.Running)) || (serviceController.Status.Equals(ServiceControllerStatus.StartPending)))
        //        {
        //            serviceController.Stop();
        //        }
        //        serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
        //        serviceController.Start();
        //        serviceController.WaitForStatus(ServiceControllerStatus.Running);
        //    }
        //    catch
        //    {
        //       // ShowMsg(AppTexts.Information, AppTexts.SystematicError, MessageBox.Icon.WARNING);
        //    }
        //}
    }
}