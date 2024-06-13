using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk {
	[DataContract]
	public class RetornoPdf {
		[DataMember(Name="pdf", EmitDefaultValue = false)]
		public string Pdf;

		public static RetornoPdf Builder() {
			return new RetornoPdf();
		}

		public RetornoPdf Build() {
			return this;
		}

		public RetornoPdf SetPdf(string pdf) {
			this.Pdf = pdf;
			return this;
		}
	}
}
