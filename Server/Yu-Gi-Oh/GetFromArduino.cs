using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yu_Gi_Oh
{
    class GetFromArduino
    {
        int location = 0;
        string name = "test123";
        string category = "Monster";
        string mode = "attack";
        



        public string decipher(string ciphertext)
        {
            StringCipher understand = new StringCipher();
            return understand.Decrypt(ciphertext, "metamulehiwigufuPa123!12Ga1966!12");
        }
        





        
    }
}