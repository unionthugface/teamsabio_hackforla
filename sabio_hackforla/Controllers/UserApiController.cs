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
    [Route(""),HttpGet]
        public HttpResponseMessage GetLocation(User model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            HttpResponseMessage resp = null;

            return resp;
        }
    }
}