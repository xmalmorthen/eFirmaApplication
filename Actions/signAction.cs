﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eFirma.Models;

namespace eFirmaApplication.Actions
{
    internal static class signAction
    {
        internal static pubCert ValidateCert(String cert)
        {
            eFirma.validate Validate = new eFirma.validate();
            pubCert pubCertInfo = Validate.pubCert(cert.Trim());
            return pubCertInfo; 
        }

        internal static evidence Sign(String cert, String key, String pwd, originalStringToSignModel os)
        {
            
            eFirma.sign Sign = new eFirma.sign(cert, key, pwd);            
            return Sign.data(os);
        }

        internal static evidence Sign(String cert, String key, String pwd, string os)
        {
            eFirma.sign Sign = new eFirma.sign(cert, key, pwd);
            return Sign.data(os);
        }
    }
}
