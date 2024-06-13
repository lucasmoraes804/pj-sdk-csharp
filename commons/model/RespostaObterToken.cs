using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Sdk {
	[DataContract]
	public class RespostaObterToken {
		[DataMember(Name="access_token", EmitDefaultValue = false)]
		public string AccessToken;
		[DataMember(Name="token_type", EmitDefaultValue = false)]
		public string TokenType;
		[DataMember(Name="expires_in", EmitDefaultValue = false)]
		public int ExpiresIn;
		[DataMember(Name="scope", EmitDefaultValue = false)]
		public string Scope;
		[DataMember(Name="createdAt", EmitDefaultValue = false)]
		public long CreatedAt;

		public static RespostaObterToken Builder() {
			return new RespostaObterToken();
		}

		public RespostaObterToken Build() {
			return this;
		}

		public RespostaObterToken SetAccessToken(string accessToken) {
			this.AccessToken = accessToken;
			return this;
		}

		public RespostaObterToken SetTokenType(string tokenType) {
			this.TokenType = tokenType;
			return this;
		}

		public RespostaObterToken SetExpiresIn(int expiresIn) {
			this.ExpiresIn = expiresIn;
			return this;
		}

		public RespostaObterToken SetScope(string scope) {
			this.Scope = scope;
			return this;
		}

		public RespostaObterToken SetCreatedAt(long createdAt) {
			this.CreatedAt = createdAt;
			return this;
		}
	}
}
