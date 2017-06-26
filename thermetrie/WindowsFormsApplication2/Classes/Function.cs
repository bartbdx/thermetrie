using System;
using System.Collections.Generic;
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

        internal static void send_report(string subject, string content, string recipients, String file)
        {
            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.EnableSsl = false;
            //client.UseDefaultCredentials = false;
            //client.Credentials = new NetworkCredential("philippe.lavielle@viacesi.fr", "Bykyp628");

            try
            {
                // Create instance of message
                MailMessage message = new MailMessage();

                // Add receiver
                message.To.Add(recipients);

                // Set sender
                // In this case the same as the username
                message.From = new MailAddress("thermetrie@gmail.com");

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
    }
}
