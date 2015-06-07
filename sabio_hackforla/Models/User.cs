using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sabio_hackforla.Models
{
    public class User 
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName {get; set;}

        public string Email { get; set; }

        public decimal Lat { get; set; }

        public decimal Lng { get; set; }

    }
}