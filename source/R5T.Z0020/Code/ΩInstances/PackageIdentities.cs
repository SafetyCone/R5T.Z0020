using System;


namespace R5T.Z0020
{
	public class PackageIdentities : IPackageIdentities
	{
		#region Infrastructure

	    public static IPackageIdentities Instance { get; } = new PackageIdentities();

	    private PackageIdentities()
	    {
        }

	    #endregion
	}
}