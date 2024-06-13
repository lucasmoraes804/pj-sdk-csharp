using System;

namespace Sdk {
    public class SdkException : Exception {
        public Erro Erro;

        public SdkException(string message, string json) : base(message) {
            Erro = (Erro) SdkUtils.Deserialize(typeof(Erro), json);
        }
    }
}

