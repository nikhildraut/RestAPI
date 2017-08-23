using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Web;
using System.Xml;

namespace DevetchAPI
{
    public class ErrorLog
    {
        public static bool WriteErrorLog(string Action)
        {
            bool Status = false; string User = string.Empty;
            string LogDirectory = ConfigurationManager.AppSettings["LogDirectory"].ToString();

            try
            {
              
            }
            catch
            {
                User = "Anonymous";
            }
            finally { }

            DateTime CurrentDateTime = DateTime.Now;
            string CurrentDateTimeString = CurrentDateTime.ToString();
            CheckCreateLogDirectory(LogDirectory);

            LogDirectory = (LogDirectory + "Log_" + LogFileName(DateTime.Now) + ".txt");

          //  lock (typeof(ApplicationLog))
            {
                StreamWriter oStreamWriter = null;
                try
                {
                    oStreamWriter = new StreamWriter(LogDirectory, true);

                    string hostName = Dns.GetHostName();
                    string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    var macAddr = (from nic in NetworkInterface.GetAllNetworkInterfaces()
                                   where nic.OperationalStatus == OperationalStatus.Up
                                   select nic.GetPhysicalAddress().ToString()).FirstOrDefault();

                    #region Storing Values in Notepad
                    oStreamWriter.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                    oStreamWriter.WriteLine("| HostName - " + hostName + " | IP -" + myIP + " | Mac Address - " + macAddr + " | User - " + User + " | Action - " + Action + " |");
                    oStreamWriter.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                    #endregion

                    #region Storing in DB
                    try
                    {
                        QueryBuilder.InsertInDB("errorlog", "HostName,MacAdd,IP,User,DateTime,ErrorDetails", "'" + hostName + "','" + macAddr + "','" + myIP + "','" + User + "','" + DateTime.Now + "','" + Action + "'");
                    }
                    catch
                    {

                    }
                    finally { }
                    #endregion

                    #region Storing Values in XML
                    XmlDocument oXmlDocument = new XmlDocument();
                    oXmlDocument.Load(@"D:\LogFiles\Log.xml");
                    //XmlNode oXmlRootNodeC = oXmlDocument.CreateNode("Records");
                    XmlNode oXmlRootNode = oXmlDocument.SelectSingleNode("Records");
                    XmlNode oXmlRecordNode = oXmlRootNode.AppendChild(
                    oXmlDocument.CreateNode(XmlNodeType.Element, "Log", ""));
                    oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element, "HostName", "")).InnerText = hostName;
                    oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element, "IP", "")).InnerText = myIP;
                    oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element, "Datetime", "")).InnerText = DateTime.Now.ToString();
                    oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element, "MacId", "")).InnerText = macAddr;
                    oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element, "User", "")).InnerText = "User";
                    oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element, "Action", "")).InnerText = "Test";
                    oXmlDocument.Save((@"D:\LogFiles\Log.xml"));
                    #endregion

                }
                catch (Exception ex)
                {
                    string Error = ex.Message;
                }
                finally
                {
                    if (oStreamWriter != null)
                    {
                        oStreamWriter.Close();
                    }
                }
            }
            return Status;
        }

        public static bool CheckCreateLogDirectory(string LogPath)
        {
            bool loggingDirectoryExists = false;
            DirectoryInfo oDirectoryInfo = new DirectoryInfo(LogPath);
            if (oDirectoryInfo.Exists)
            {
                loggingDirectoryExists = true;
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(LogPath);
                    loggingDirectoryExists = true;
                }
                catch
                {
                    // Logging failure
                }
                finally
                { }
            }
            return loggingDirectoryExists;
        }

        private static string BuildLogLine(DateTime CurrentDateTime, string LogMessage)
        {
            try
            {
                StringBuilder loglineStringBuilder = new StringBuilder();

                loglineStringBuilder.Append(LogFileEntryDateTime(CurrentDateTime));
                // loglineStringBuilder.Append(" \t");
                loglineStringBuilder.Append(LogMessage);

                return loglineStringBuilder.ToString();
            }
            finally { }
        }

        public static string LogFileEntryDateTime(DateTime CurrentDateTime)
        {
            try
            {
                return CurrentDateTime.ToString("dd-MM-yyyy HH:mm:ss");
            }
            finally { }
        }

        private static string LogFileName(DateTime CurrentDateTime)
        {
            try
            {
                return CurrentDateTime.ToString("dd_MM_yyyy");
            }
            finally { }
        }


    }
}
