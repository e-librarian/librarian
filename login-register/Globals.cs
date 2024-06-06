using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_register
{
    public static partial class GLOBALS
    {
        public static readonly string pepper = "sVgS12";
        public static readonly string usernameGuidelines = "A valid username should:\n- Start with a letter.\n - Use only uppercase or lowercase letters, numbers and underscores(_).\n- Be between 8-30 characters long.";
        public static readonly string passGuidelines = "A valid password should:\n- Contain at least one digit from 1 to 9.\n- Contain at least one lowercase letter.\n- Contain at least one uppercase letter.\n- Contain at least one special character.\n- Be between 8-16 characters long.";
        public static readonly string usernameREGEX = "^[A-Za-z][A-Za-z0-9_]{7,29}$";
        public static readonly string passREGEX = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*\\W)(?!.* ).{8,16}$";
        public static readonly string[] profImages = ["https://i.imgur.com/pRRG40D.png", "https://i.imgur.com/n98Ys57.png", "https://i.imgur.com/9kXOzjz.png", "https://i.imgur.com/TsohuOm.png", "https://i.imgur.com/xeo0AnV.png", "https://i.imgur.com/orj9eIX.png", "https://i.imgur.com/LUaF612.png", "https://i.imgur.com/S1Ormx7.png", "https://i.imgur.com/KKh8ISt.png", "https://i.imgur.com/1GDp8hc.png"];
        
    }
}
