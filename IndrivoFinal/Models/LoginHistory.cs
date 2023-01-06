using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndrivoFinal.Models
{
    public class LoginHistory
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public DateTime LoginTime { get; set; }
    }
}