namespace WillowMaze.Wasm.Decompiled;


public interface IUnusedAppRestrictionsBackportService : android.os.IInterface {
    public static readonly java.lang.string DESCRIPTOR;

    static {
        if ((25 + 32) % 32 > 0) {
        }
        DESCRIPTOR = "androidx$core$app$unusedapprestrictions$IUnusedAppRestrictionsBackportService".Replace('$', '.');
    }

    void isPermissionRevocationEnabledForApp(androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportCallback iUnusedAppRestrictionsBackportCallback) throws android.os.RemoteException;
}

