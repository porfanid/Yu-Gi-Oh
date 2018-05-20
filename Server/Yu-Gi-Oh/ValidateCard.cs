using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PartialKeyVerification.Checksum;
using PartialKeyVerification.Hash;
namespace Yu_Gi_Oh
{
    class ValidateCard
    {
        string[] Blacklist = {"QDKZUO-JLLWPY-XWOULC-ONCQIN-5R5X35-ZS3KEQ" };




        public bool testCard(string key)
        {
            var isValid = PartialKeyValidator.ValidateKey(new Adler16(), new Jenkins96(), key, 0, 1);
            bool existance=false;
            foreach(string s in Blacklist)
            {
                if (key==s)
                {
                    existance = true;
                }
            }
            if (isValid && !existance)
            {
                return true;
            }
            return false;
        }
    }
}