using sabio_hackforla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace sabio_hackforla.Service
{
    public class UserService
    {
        public static User GetLocation(int userId)
        {
            User newUser = new User();
            newUser.Lat = 0;
            newUser.Lng = 0;
            return newUser;
        }
    }
}