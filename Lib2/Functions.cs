using System.Management;

namespace TestNet6Deps
{
    public class Functions
    {
        public static string GetComputerName()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT Name FROM Win32_ComputerSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    return queryObj["Name"].ToString();
                }

                return "No Name !?";
            }
            catch (ManagementException e)
            {
                // exception handling
                return "Management Error: " + e.Message;
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }

    }
}