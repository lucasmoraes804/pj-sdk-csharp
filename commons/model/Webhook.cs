using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk {
	[DataContract]
	public class Webhook {
		[DataMember(Name="webhookUrl", EmitDefaultValue = false)]
		public string WebhookUrl;
		[DataMember(Name="criacao", EmitDefaultValue = false)]
		public string Criacao;

		public static Webhook Builder() {
			return new Webhook();
		}

		public Webhook Build() {
			return this;
		}

		public Webhook SetWebhookUrl(string webhookUrl) {
			this.WebhookUrl = webhookUrl;
			return this;
		}

		public Webhook SetCriacao(string criacao) {
			this.Criacao = criacao;
			return this;
		}
	}
}
