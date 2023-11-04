using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using WebApplication21.Models;
using WebApplication21.Domain;
using Vonage;
using Vonage.Request;

namespace WebApplication21.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {          
            return View();
        }

        [HttpPost]
        public ActionResult Index(Lead lead)
        {
            string name = lead.Name;
            string phone = lead.Phone;
            string message = lead.Message;

            var credentials = Vonage.Request.Credentials.FromApiKeyAndSecret(
            Domain.Credentials.APIKey,
            Domain.Credentials.APISecret
            );

            var VonageClient = new VonageClient(credentials);

            var response = VonageClient.SmsClient.SendAnSms(new Vonage.Messaging.SendSmsRequest()
            {
                To = lead.Phone,
                From = credentials.ApiKey,
                Text = lead.Message
            }) ;

            return this.View(lead);


        }
    }
}



