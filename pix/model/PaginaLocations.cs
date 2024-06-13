using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk.PixApi {
	[DataContract]
	public class PaginaLocations {
		[DataMember(Name="parametros", EmitDefaultValue = false)]
		public Parametros Parametros;
		[DataMember(Name="loc", EmitDefaultValue = false)]
		public List<Location> Locs;

		public static PaginaLocations Builder() {
			return new PaginaLocations();
		}

		public PaginaLocations Build() {
			return this;
		}

		public PaginaLocations SetParametros(Parametros parametros) {
			this.Parametros = parametros;
			return this;
		}

		public PaginaLocations SetLocs(List<Location> locs) {
			this.Locs = locs;
			return this;
		}
	}
}
