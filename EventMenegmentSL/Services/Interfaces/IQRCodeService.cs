﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMenegmentSL.Services.Interfaces
{
    public interface IQrCodeService
    {
        byte[] GenerateQrCode(string text);
    }

}
