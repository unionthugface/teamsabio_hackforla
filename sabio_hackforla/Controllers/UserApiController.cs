using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using sabio_hackforla.Models;
using System.Web;
using System.Diagnostics;
using System.IO;

namespace sabio_hackforla.Controllers
{
    [RoutePrefix("api/UserLocation")]
    public class UserApiController : ApiController
    {
        [Route(""), HttpGet]
        public HttpResponseMessage GetLocation(User model)
        {
            HttpResponseMessage resp = new HttpResponseMessage();
            try
            {
                //User user = UserService.GetLocation(userid);
                //resp = Request.CreateResponse<User>(HttpStatusCode.OK, user);
            }
            catch (Exception ex)
            {
                resp = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }
            return resp;
        }
    }
}