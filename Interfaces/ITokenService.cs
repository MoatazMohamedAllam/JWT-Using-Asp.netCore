﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_Demo.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(string username);
    }
}
