using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk {
	[DataContract]
	public class Erro {
		[DataMember(Name="title", EmitDefaultValue = false)]
		public string Title;
		[DataMember(Name="detail", EmitDefaultValue = false)]
		public string Detail;
		[DataMember(Name="timestamp", EmitDefaultValue = false)]
		public string Timestamp;
		[DataMember(Name="violacoes", EmitDefaultValue = false)]
		public List<Violacao> Violacoes;

		public static Erro Builder() {
			return new Erro();
		}

		public Erro Build() {
			return this;
		}

		public Erro SetTitle(string title) {
			this.Title = title;
			return this;
		}

		public Erro SetDetail(string detail) {
			this.Detail = detail;
			return this;
		}

		public Erro SetTimestamp(string timestamp) {
			this.Timestamp = timestamp;
			return this;
		}

		public Erro SetViolacoes(List<Violacao> violacoes) {
			this.Violacoes = violacoes;
			return this;
		}
	}
}
