using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk {
	[DataContract]
	public class CriarWebhookRequest {
		[DataMember(Name="webhookUrl", EmitDefaultValue = false)]
		public string WebhookUrl;

		public static CriarWebhookRequest Builder() {
			return new CriarWebhookRequest();
		}

		public CriarWebhookRequest Build() {
			return this;
		}

		public CriarWebhookRequest SetWebhookUrl(string webhookUrl) {
			this.WebhookUrl = webhookUrl;
			return this;
		}
	}
}
