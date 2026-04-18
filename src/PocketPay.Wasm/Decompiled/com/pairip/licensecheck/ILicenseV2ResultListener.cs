namespace WillowMaze.Wasm.Decompiled;


public interface ILicenseV2ResultListener : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR = "com.android.vending.licensing.ILicenseV2ResultListener";

    void verifyLicense(int i, android.os.Dictionary<string, object> bundle) throws android.os.RemoteException;
}

