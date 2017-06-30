using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApplication2.Classes
{
    class Function
    {
        internal static string slugify(String name)
        {
            return Regex.Replace(name, "[^a-z0-9\\._\\s]", "", RegexOptions.IgnoreCase);
        }

        internal static decimal PlusGrandeValeur(List<decimal> L)
        {
            decimal max = 0;
            foreach (decimal line in L)
            {
                if (line > max)
                {
                    max = line;
                }
            }
            return max;
        }

        internal static decimal PlusPetiteValeur(List<decimal> L)
        {
            decimal min = L[0];
            foreach (decimal line in L)
            {
                if (line < min)
                {
                    min = line;
                }
            }
            return min;
        }

        internal static decimal valeurMoyenne(List<decimal> L)
        {
            decimal moy = 0;
            foreach (decimal line in L)
            {
                moy += line;
            }
            moy = moy / L.Count;
            return moy;
        }

        internal static void send_report(string subject, string content, String file)
        {
            SmtpClient client = new SmtpClient("127.0.0.1", 1025);
            //client.EnableSsl = true;
            
            //client.Credentials = new NetworkCredential("philippe.lavielle@free.fr", "Velentino");

            try
            {
                // Create instance of message
                MailMessage message = new MailMessage();

                // Add receiver
                message.To.Add(ReadSetting("mailExport"));

                // Set sender
                // In this case the same as the username
                message.From = new MailAddress("no-reply@gmail.com");

                // Set subject
                message.Subject = subject;

                // Set body of message
                message.Body = content;

                // Set attachtment of message
                Attachment attachment = new Attachment(file);
                message.Attachments.Add(attachment);
                

                // Send the message
                client.Send(message);

                // Clean up
                message = null;
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not send e-mail. Exception caught: " + e);
            }
        }

        internal static void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("Le fichier de configuration est vide");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Erreur lecture fichier configuration de l'application");
            }
        }

        internal static String ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Non Renseignée";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Erreur lecture config : " + key);
                return null;
            }

        }

        internal static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Erreur d'ecriture du fichier de configuration");
            }
        }
    }
}
