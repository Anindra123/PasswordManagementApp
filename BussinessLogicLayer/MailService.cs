using DataAcessLayer;
using FluentEmail.Core;
using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public static class MailService
    {
        public static async Task<bool> SendMail(MasterAccModel masterAcc,int vcode)
        {
            string pass = "blkbacbbhogdpioe";
            string senderEmail = "projmanagapp@gmail.com";
            var sender = new SmtpSender(() => new SmtpClient()
            {
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Port = 587,
                Credentials = new NetworkCredential(senderEmail, pass)
            });

            string messageBody = $"Verification code for {masterAcc.email}: \n\n\n" +
                $"Dear {masterAcc.firstname} {masterAcc.lastname}, \n" +
                $"Your Verification code is : {vcode}. \n" +
                $"Thank you for using our software. \n\n\n" +
                $"------------------------------------------------------\n"+
                $"Auto Generated Message. Do not reply to this message.";

            Email.DefaultSender = sender;
            var mail = await Email
                .From(senderEmail)
                .To(masterAcc.email)
                .Subject("Forget Password")
                .Body(messageBody)
                .SendAsync();

            return mail.Successful;
        }
    }
}
