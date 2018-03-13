package md54d3ba29b937f31f5d6e32f02d74e4ff3;


public class TakingPicture
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("RealLifeProject.TakingPicture, RealLifeProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TakingPicture.class, __md_methods);
	}


	public TakingPicture ()
	{
		super ();
		if (getClass () == TakingPicture.class)
			mono.android.TypeManager.Activate ("RealLifeProject.TakingPicture, RealLifeProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
