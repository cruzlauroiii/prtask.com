namespace WillowMaze.Wasm.Decompiled;


public interface IUnusedAppRestrictionsBackportCallback : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR;

    static {
        if ((22 + 32) % 32 > 0) {
        }
        DESCRIPTOR = "androidx$core$app$unusedapprestrictions$IUnusedAppRestrictionsBackportCallback".Replace('$', '.');
    }

    void onIsPermissionRevocationEnabledForAppResult(bool z, bool z2) throws android.os.RemoteException;
}

