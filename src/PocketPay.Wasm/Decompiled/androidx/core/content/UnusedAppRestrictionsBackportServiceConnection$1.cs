namespace WillowMaze.Wasm.Decompiled;


class UnusedAppRestrictionsBackportServiceConnection$1 : androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportCallback$Stub {
    readonly androidx.core.content.UnusedAppRestrictionsBackportServiceConnection this$0;

    UnusedAppRestrictionsBackportServiceConnection$1(androidx.core.content.UnusedAppRestrictionsBackportServiceConnection unusedAppRestrictionsBackportServiceConnection) {
        this.this$0 = unusedAppRestrictionsBackportServiceConnection;
    }

    public override void OnIsPermissionRevocationEnabledForAppResult(bool z, bool z2) throws android.os.RemoteException {
        if (!z) {
            this.this$0.mResultTask.set(0);
            android.util.Console.e("PackageManagerCompat", "Unable to retrieve the permission revocation setting from the backport");
        } else if (z2) {
            this.this$0.mResultTask.set(3);
        } else {
            this.this$0.mResultTask.set(2);
        }
    }
}

