using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.BankingApi {
	[DataContract]
	public class Pix {
		[DataMember(Name="valor", EmitDefaultValue = false)]
		public double Valor;
		// 
		//  <p>Se não for informada, será a data atual.</p>
		//  <p>Format aceito: YYYY-MM-DD</p>
		//      
		[DataMember(Name="dataPagamento", EmitDefaultValue = false)]
		public string DataPagamento;
		[DataMember(Name="descricao", EmitDefaultValue = false)]
		public string Descricao;
		[DataMember(Name="destinatario", EmitDefaultValue = false)]
		public Destinatario Destinatario;

		public static Pix Builder() {
			return new Pix();
		}

		public Pix Build() {
			return this;
		}

		public Pix SetValor(double valor) {
			this.Valor = valor;
			return this;
		}

		public Pix SetDataPagamento(string dataPagamento) {
			this.DataPagamento = dataPagamento;
			return this;
		}

		public Pix SetDescricao(string descricao) {
			this.Descricao = descricao;
			return this;
		}

		public Pix SetDestinatario(Destinatario destinatario) {
			this.Destinatario = destinatario;
			return this;
		}
	}
}
