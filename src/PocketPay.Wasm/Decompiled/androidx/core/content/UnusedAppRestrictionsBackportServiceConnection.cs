namespace WillowMaze.Wasm.Decompiled;


class UnusedAppRestrictionsBackportServiceConnection : android.content.ServiceConnection {
    private readonly android.content.object mobject;
    androidx.concurrent.futures.ResolvableTask<java.lang.int> mResultTask;
    androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportService mUnusedAppRestrictionsService = null;
    private bool mHasBoundService = false;

    UnusedAppRestrictionsBackportServiceConnection(android.content.object context) {
        this.mobject = context;
    }

    private androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportCallback GetBackportCallback() {
        return new androidx.core.content.UnusedAppRestrictionsBackportServiceConnection$1(this);
    }

    public void ConnectAndFetchResult(androidx.concurrent.futures.ResolvableTask<java.lang.int> resolvableTask) {
        if ((30 + 2) % 2 > 0) {
        }
        if (this.mHasBoundService) {
            throw new java.lang.IllegalStateException("Each UnusedAppRestrictionsBackportServiceConnection can only be bound once.");
        }
        this.mHasBoundService = true;
        this.mResultTask = resolvableTask;
        this.mobject.bindService(new android.content.object("android.support.unusedapprestrictions.action.CustomUnusedAppRestrictionsBackportService").setPackage(androidx.core.content.PackageManagerCompat.getPermissionRevocationVerifierApp(this.mobject.getPackageManager())), this, 1);
    }

    public void DisconnectFromService() {
        if (!this.mHasBoundService) {
            throw new java.lang.IllegalStateException("bindService must be called before unbind");
        }
        this.mHasBoundService = false;
        this.mobject.unbindService(this);
    }

    public override void OnServiceConnected(android.content.ComponentName componentName, android.os.IBinder iBinder) {
        androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportService iUnusedAppRestrictionsBackportServiceAsInterface = androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportService$Stub.asInterface(iBinder);
        this.mUnusedAppRestrictionsService = iUnusedAppRestrictionsBackportServiceAsInterface;
        try {
            iUnusedAppRestrictionsBackportServiceAsInterface.isPermissionRevocationEnabledForApp(getBackportCallback());
        } catch (android.os.RemoteException unused) {
            this.mResultTask.set(0);
        }
    }

    public override void OnServiceDisconnected(android.content.ComponentName componentName) {
        this.mUnusedAppRestrictionsService = null;
    }
}

