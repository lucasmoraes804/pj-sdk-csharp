using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.CobrancaApi {
	[DataContract]
	public class RespostaBuscarCallbacks {
		[DataMember(Name="webhookUrl", EmitDefaultValue = false)]
		public string WebhookUrl;
		[DataMember(Name="numeroTentativa", EmitDefaultValue = false)]
		public int NumeroTentativa;
		[DataMember(Name="dataHoraDisparo", EmitDefaultValue = false)]
		public string DataHoraDisparo;
		[DataMember(Name="sucesso", EmitDefaultValue = false)]
		public bool Sucesso;
		[DataMember(Name="httpStatus", EmitDefaultValue = false)]
		public int HttpStatus;
		[DataMember(Name="payload", EmitDefaultValue = false)]
		public List<Payload> Payload;

		public static RespostaBuscarCallbacks Builder() {
			return new RespostaBuscarCallbacks();
		}

		public RespostaBuscarCallbacks Build() {
			return this;
		}

		public RespostaBuscarCallbacks SetWebhookUrl(string webhookUrl) {
			this.WebhookUrl = webhookUrl;
			return this;
		}

		public RespostaBuscarCallbacks SetNumeroTentativa(int numeroTentativa) {
			this.NumeroTentativa = numeroTentativa;
			return this;
		}

		public RespostaBuscarCallbacks SetDataHoraDisparo(string dataHoraDisparo) {
			this.DataHoraDisparo = dataHoraDisparo;
			return this;
		}

		public RespostaBuscarCallbacks SetSucesso(bool sucesso) {
			this.Sucesso = sucesso;
			return this;
		}

		public RespostaBuscarCallbacks SetHttpStatus(int httpStatus) {
			this.HttpStatus = httpStatus;
			return this;
		}

		public RespostaBuscarCallbacks SetPayload(List<Payload> payload) {
			this.Payload = payload;
			return this;
		}
	}
}
