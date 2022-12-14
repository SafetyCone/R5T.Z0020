using System;

using R5T.T0131;


namespace R5T.Z0020
{
	[ValuesMarker]
	public partial interface IPackageIdentities : IValuesMarker
	{
        public string Microsoft_AspNetCore_Components_Web => "Microsoft.AspNetCore.Components.Web";
        public string Microsoft_AspNetCore_Components_WebAssembly => "Microsoft.AspNetCore.Components.WebAssembly";
        public string Microsoft_AspNetCore_Components_WebAssembly_DevServer => "Microsoft.AspNetCore.Components.WebAssembly.DevServer";
        public string Microsoft_AspNetCore_Components_WebAssembly_Server => "Microsoft.AspNetCore.Components.WebAssembly.Server";
	}
}