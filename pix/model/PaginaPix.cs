using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class PaginaPix {
		[DataMember(Name="parametros", EmitDefaultValue = false)]
		public Parametros Parametros;
		[DataMember(Name="pix", EmitDefaultValue = false)]
		public List<Pix> ListaPix;

		public static PaginaPix Builder() {
			return new PaginaPix();
		}

		public PaginaPix Build() {
			return this;
		}

		public PaginaPix SetParametros(Parametros parametros) {
			this.Parametros = parametros;
			return this;
		}

		public PaginaPix SetListaPix(List<Pix> listaPix) {
			this.ListaPix = listaPix;
			return this;
		}
	}
}
