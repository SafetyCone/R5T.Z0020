using System;


namespace R5T.Z0020
{
	[Obsolete("See R5T.Z0050.")]
	public class Packages : IPackages
	{
		#region Infrastructure

	    public static IPackages Instance { get; } = new Packages();


	    private Packages()
	    {
        }

	    #endregion
	}
}