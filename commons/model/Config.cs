using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk {
	[DataContract]
	public class Config {
		[DataMember(Name="ambiente", EmitDefaultValue = false)]
		public string Ambiente;
		[DataMember(Name="clientId", EmitDefaultValue = false)]
		public string ClientId;
		[DataMember(Name="clientSecret", EmitDefaultValue = false)]
		public string ClientSecret;
		[DataMember(Name="certificado", EmitDefaultValue = false)]
		public string Certificado;
		[DataMember(Name="senha", EmitDefaultValue = false)]
		public string Senha;
		[DataMember(Name="debug", EmitDefaultValue = false)]
		public bool Debug;
		[DataMember(Name="contaCorrente", EmitDefaultValue = false)]
		public string ContaCorrente;
		[DataMember(Name="controleRateLimit", EmitDefaultValue = false)]
		public bool ControleRateLimit;

		public static Config Builder() {
			return new Config();
		}

		public Config Build() {
			return this;
		}

		public Config SetAmbiente(string ambiente) {
			this.Ambiente = ambiente;
			return this;
		}

		public Config SetClientId(string clientId) {
			this.ClientId = clientId;
			return this;
		}

		public Config SetClientSecret(string clientSecret) {
			this.ClientSecret = clientSecret;
			return this;
		}

		public Config SetCertificado(string certificado) {
			this.Certificado = certificado;
			return this;
		}

		public Config SetSenha(string senha) {
			this.Senha = senha;
			return this;
		}

		public Config SetDebug(bool debug) {
			this.Debug = debug;
			return this;
		}

		public Config SetContaCorrente(string contaCorrente) {
			this.ContaCorrente = contaCorrente;
			return this;
		}

		public Config SetControleRateLimit(bool controleRateLimit) {
			this.ControleRateLimit = controleRateLimit;
			return this;
		}
	}
}
