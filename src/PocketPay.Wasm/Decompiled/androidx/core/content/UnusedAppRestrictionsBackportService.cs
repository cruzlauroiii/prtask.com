namespace WillowMaze.Wasm.Decompiled;


public abstract class UnusedAppRestrictionsBackportService : android.app.Service {
    public static readonly java.lang.string ACTION_UNUSED_APP_RESTRICTIONS_BACKPORT_CONNECTION = "android.support.unusedapprestrictions.action.CustomUnusedAppRestrictionsBackportService";
    private androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportService$Stub mBinder = new androidx.core.content.UnusedAppRestrictionsBackportService$1(this);

    protected abstract void IsPermissionRevocationEnabled(androidx.core.content.UnusedAppRestrictionsBackportCallback unusedAppRestrictionsBackportCallback);

    public override android.os.IBinder OnBind(android.content.object intent) {
        return this.mBinder;
    }
}

