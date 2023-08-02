using System;
using System.Windows.Forms;
using ClientManagementApp3.Services;
using ClientManagementApp3.Data;
using ClientManagementApp3.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientManagementApp3
{
    public partial class Form1 : Form
    {
        private BindingSource clientsBindingSource;
        private ClientDbContext dbContext;

        public Form1()
        {
            InitializeComponent();
            dbContext = new ClientDbContext();
        }

        private void btnAttachFile_Click(object sender, EventArgs e)
        {
            // Вибір файлу для додавання вкладення
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblSelectedAttachment.Text = openFileDialog.FileName;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Відправка листа з вкладенням
            SmtpEmailService emailService = new SmtpEmailService();
            Message message = new Message()
            {
                Subject = txtSubject.Text,
                Body = txtBody.Text,
                To = txtRecipientEmail.Text,
                AttachmentPath = lblSelectedAttachment.Text
            };
            emailService.Send(message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Підключення до бази даних SQLite
            var optionsBuilder = new DbContextOptionsBuilder<ClientDbContext>();
            optionsBuilder.UseSqlite("Data Source=clients.db");

            // Створення екземпляра контексту бази даних
            using (var dbContext = new ClientDbContext(optionsBuilder.Options))
            {
                // Створюємо базу даних за необхідності
                dbContext.Database.EnsureCreated();

                // Завантажуємо клієнтів із бази даних
                var clients = dbContext.Clients.ToList();
                clientsBindingSource = new BindingSource(clients, null);
                lstClients.DataSource = clientsBindingSource;

                // Встановлюємо подію SelectedIndexChanged
                lstClients.SelectedIndexChanged += new System.EventHandler(this.lstClients_SelectedIndexChanged);

                // Встановлюємо формат відображення рядків у ListBox
                lstClients.Format += (s, ev) =>
                {
                    var client = ((Client)ev.ListItem);
                    ev.Value = string.Format("{0,-60} {1,-60} {2}", client.FullName, client.PhoneNumber, client.Email);
                };
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            // Додавання клієнта до списку та бази даних
            Client client = new Client()
            {
                FullName = txtFullName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Email = txtEmail.Text
            };
            dbContext.Clients.Add(client);
            dbContext.SaveChanges();

            clientsBindingSource.Add(client);
            clientsBindingSource.ResetBindings(false);

            txtFullName.Text = "";
            txtPhoneNumber.Text = "";
            txtEmail.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Збереження клієнтів у базу даних перед закриттям форми
            dbContext.SaveChanges();
        }

        private void lstClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClients.SelectedIndex >= 0)
            {
                Client selectedClient = (Client)lstClients.SelectedItem;
                txtRecipientEmail.Text = selectedClient.Email;
            }
        }
    }
}