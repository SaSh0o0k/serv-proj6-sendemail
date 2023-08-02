using System;
using System.Net;
using System.Net.Mail;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using ClientManagementApp3.Models;
using MimeKit;

namespace ClientManagementApp3.Services
{
    public class SmtpEmailService
    {
        private readonly EmailConfiguration _configuration;
        public SmtpEmailService()
        {
            _configuration = new EmailConfiguration();
        }

        public void Send(Message message)
        {
            var body = new TextPart("html")
            {
                Text = message.Body
            };
            var multipart = new Multipart("mixed");
            multipart.Add(body);

            if (!string.IsNullOrEmpty(message.AttachmentPath))
            {
                var attachment = new MimePart("application", "octet-stream")
                {
                    Content = new MimeContent(System.IO.File.OpenRead(message.AttachmentPath)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = System.IO.Path.GetFileName(message.AttachmentPath)
                };
                multipart.Add(attachment);
            }

            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_configuration.From));
            emailMessage.To.Add(new MailboxAddress(message.To));
            emailMessage.Subject = message.Subject;
            emailMessage.Body = multipart;

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                try
                {
                    client.Connect(_configuration.SmtpServer, _configuration.Port, true);
                    client.Authenticate(_configuration.UserName, _configuration.Password);
                    client.Send(emailMessage);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }
    }
}
