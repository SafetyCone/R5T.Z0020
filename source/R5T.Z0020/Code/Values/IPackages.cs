using System;

using R5T.T0131;
using R5T.T0152;


namespace R5T.Z0020
{
	[ValuesMarker]
	public partial interface IPackages : IValuesMarker
	{
        public PackageReference Microsoft_AspNetCore_Components_Web => this.Microsoft_AspNetCore_Components_Web_6_0_11;
        public PackageReference Microsoft_AspNetCore_Components_Web_6_0_11 => new PackageReference
        {
            Identity = PackageIdentities.Instance.Microsoft_AspNetCore_Components_Web,
            Version = F0000.VersionOperator.Instance.From("6.0.11"),
        };

        public PackageReference Microsoft_AspNetCore_Components_WebAssembly => this.Microsoft_AspNetCore_Components_WebAssembly_6_0_11;
        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_6_0_11 => new PackageReference
        {
            Identity = PackageIdentities.Instance.Microsoft_AspNetCore_Components_WebAssembly,
            Version = F0000.VersionOperator.Instance.From("6.0.11"),
        };

        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_DevServer => this.Microsoft_AspNetCore_Components_WebAssembly_DevServer_6_0_11;
		public PackageReference Microsoft_AspNetCore_Components_WebAssembly_DevServer_6_0_11 => new PackageReference
		{
			Identity = PackageIdentities.Instance.Microsoft_AspNetCore_Components_WebAssembly_DevServer,
			Version = F0000.VersionOperator.Instance.From("6.0.11"),
            // Prevent the development package from flowing through to any dependencies.
            PrivateAssets = AssetsTagValues.Instance.All,
		};

        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_Server => this.Microsoft_AspNetCore_Components_WebAssembly_Server_6_0_11;
        public PackageReference Microsoft_AspNetCore_Components_WebAssembly_Server_6_0_11 => new PackageReference
        {
            Identity = PackageIdentities.Instance.Microsoft_AspNetCore_Components_WebAssembly_Server,
            Version = F0000.VersionOperator.Instance.From("6.0.11"),
        };


        public PackageReference[] ForRazorClassLibrary => new[]
        {
            this.Microsoft_AspNetCore_Components_Web,
        };

        public PackageReference[] ForWebBlazorServer => new[]
		{
			this.Microsoft_AspNetCore_Components_WebAssembly_Server,
		};

        public PackageReference[] ForWebBlazorClient => new[]
        {
            this.Microsoft_AspNetCore_Components_WebAssembly,
            this.Microsoft_AspNetCore_Components_WebAssembly_DevServer
        };
    }
}