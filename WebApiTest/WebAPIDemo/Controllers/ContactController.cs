using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WebAPIDemo.Hubs;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [System.Web.Http.RoutePrefix("api/Contact")]

    public class ContactController : ApiControllerWithHub<MyHub>
    {

        // Get api/Account/GetAllContacts
        [System.Web.Http.Route("GetAllContacts")]
        public IEnumerable<Contact> GetAllContacts()
        {
            return new Contact []
            {
               new Contact { Id=1,Name="Contaxt" }    };
        }

        // POST api/Account/SaveContacts
        [System.Web.Http.Route("SaveContacts")]
        public HttpResponseMessage SaveContacts(Contact Contact)
        {
            Hub.Clients.All.announce(Contact);
            var response = Request.CreateResponse(HttpStatusCode.Created, Contact);
           
           
            return response;
        }
    }
}