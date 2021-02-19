using System;
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
            
            eFirma.sign Sign = new eFirma.sign();
            return Sign.data(cert, key, pwd,os);
        }

        internal static evidence Sign(String cert, String key, String pwd, string os)
        {
            eFirma.sign Sign = new eFirma.sign();
            return Sign.data(cert, key, pwd, os);
        }


        internal static evidence Sign(byte[] cert, byte[] key, String pwd, originalStringToSignModel os)
        {

            eFirma.sign Sign = new eFirma.sign();
            return Sign.data(cert, key, pwd, os);
        }

        internal static evidence Sign(byte[] cert, byte[] key, String pwd, string os)
        {
            eFirma.sign Sign = new eFirma.sign();
            return Sign.data(cert, key, pwd, os);
        }
    }
}
