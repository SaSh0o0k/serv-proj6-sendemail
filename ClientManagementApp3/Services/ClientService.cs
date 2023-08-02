using System;
using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using ClientManagementApp3.Models;
using ClientManagementApp3.Data;

namespace ClientManagementApp3.Services
{
    public class ClientService
    {
        private readonly ClientDbContext _dbContext;

        public ClientService(ClientDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
        }

        public void AddClient(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
        }

        public List<Client> GetClients()
        {
            return _dbContext.Clients.ToList();
        }

        public void SendEmail(Client client, string subject, string body, string attachmentPath = null)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("Your Name", "your-email@example.com"));
            emailMessage.To.Add(new MailboxAddress(client.FullName, client.Email));
            emailMessage.Subject = subject;

            var builder = new BodyBuilder();
            builder.HtmlBody = body;

            if (!string.IsNullOrEmpty(attachmentPath))
            {
                builder.Attachments.Add(attachmentPath);
            }

            emailMessage.Body = builder.ToMessageBody();

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.ukr.net", 2525, SecureSocketOptions.StartTls);
                smtpClient.Authenticate("sashaputsyk100903@ukr.net", "qhoWGk2oTVkUB2g2");
                smtpClient.Send(emailMessage);
                smtpClient.Disconnect(true);
            }
        }
    }
}
