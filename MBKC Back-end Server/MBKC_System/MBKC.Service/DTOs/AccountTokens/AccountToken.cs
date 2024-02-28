﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBKC.Service.DTOs.AccountTokens
{
    public class AccountToken
    {
        public int AccountId { get; set; }
        public string JWTId { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}
