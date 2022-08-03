using System;
using System.Collections.Generic;
using System.Text;

namespace Gs1Br
{
    public class Gs1brConfig
    {
        public Gs1brConfig(string gs1brGs1brClientId, string gs1brSecretId, string gs1brUsername, string gs1brPassword)
        {
            ClientId = gs1brGs1brClientId;
            SecretId = gs1brSecretId;
            Username = gs1brUsername;
            Password = gs1brPassword;
        }

        public static void DefinirGs1brConfig(string gs1brGs1brClientId, string gs1brSecretId, string gs1brUsername, string gs1brPassword)
        {
            InstanciaConfig = new Gs1brConfig(gs1brGs1brClientId, gs1brSecretId, gs1brUsername, gs1brPassword);
        }
        public static Gs1brConfig InstanciaConfig { get; private set; }

        public string ClientId { get; private set; }
        public string SecretId { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
    }
}
