using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh
{
    class Activation
    {

        private static void SetRegistryInfo()
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Yu_Gi_Oh_Evaluation");
            key.SetValue("Evaluation", "False");
            key.Close();
        }

        private static bool GetRegistryInfo()
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Yu_Gi_Oh_Evaluation");
            if (key.GetValue("Evaluation")==null)
            {
                SetRegistryInfo();
            }
            string value = key.GetValue("Evaluation").ToString();
            bool report;
            try
            {
                report = Convert.ToBoolean(value);
            }
            catch (Exception)
            {
                report = false;
            }
            return report;
        }



        private static void validate()
        {
            Console.WriteLine("Do you want to activate the program?(yes/no)");
            string answer = Console.ReadLine();
            while (answer != "yes" && answer != "no")
            {
                Console.WriteLine("wrong input please try again");
                answer = Console.ReadLine();
            }
            if (answer == "no")
            {
                return;
            }
            Console.WriteLine("Do you want to have a license or do you want to upgrade online?(license/online)");
            answer = Console.ReadLine();
            while (answer != "license" && answer != "online")
            {
                Console.WriteLine("wrong input please try again");
                answer = Console.ReadLine();
            }
            if (answer == "license")
            {
                ValidateLicense validator = new ValidateLicense();
                validator.testLicense();
            }
            if (answer == "online")
            {
                ValidateLicense validator = new ValidateLicense();
                validator.testLicense();
            }
        }







        public void checkIfUserWantsPro()
        {
            if (!GetRegistryInfo())
            {
                validate();
            }
        }







        public void exitIfNotPro()
        {
            if (GetRegistryInfo() == false)
            {
                Console.WriteLine("Sorry, but since you have not activated the programm you cannot play the game.");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
