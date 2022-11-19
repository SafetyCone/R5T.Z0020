using System;

using R5T.T0131;
using R5T.T0152;


namespace R5T.Z0020
{
	[ValuesMarker]
	public partial interface IPackages : IValuesMarker
	{
		public PackageReference Microsoft_AspNetCore_Components_WebAssembly_Server => this.Microsoft_AspNetCore_Components_WebAssembly_Server_6_0_11;
		public PackageReference Microsoft_AspNetCore_Components_WebAssembly_Server_6_0_11 => new PackageReference
		{
			Identity = PackageIdentities.Instance.Microsoft_AspNetCore_Components_WebAssembly_Server,
			Version = F0000.VersionOperator.Instance.From("6.0.11"),
		};
	}
}