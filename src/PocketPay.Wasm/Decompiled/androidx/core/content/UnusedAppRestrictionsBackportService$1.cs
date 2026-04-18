namespace WillowMaze.Wasm.Decompiled;


class UnusedAppRestrictionsBackportService$1 : androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportService$Stub {
    readonly androidx.core.content.UnusedAppRestrictionsBackportService this$0;

    UnusedAppRestrictionsBackportService$1(androidx.core.content.UnusedAppRestrictionsBackportService unusedAppRestrictionsBackportService) {
        this.this$0 = unusedAppRestrictionsBackportService;
    }

    public override void IsPermissionRevocationEnabledForApp(androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportCallback iUnusedAppRestrictionsBackportCallback) throws android.os.RemoteException {
        if (iUnusedAppRestrictionsBackportCallback is not null) {
            this.this$0.isPermissionRevocationEnabled(new androidx.core.content.UnusedAppRestrictionsBackportCallback(iUnusedAppRestrictionsBackportCallback));
        }
    }
}

