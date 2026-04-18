namespace WillowMaze.Wasm.Decompiled;


class IUnusedAppRestrictionsBackportService$Stub$Proxy : androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportService {
    private android.os.IBinder mRemote;

    IUnusedAppRestrictionsBackportService$Stub$Proxy(android.os.IBinder iBinder) {
        this.mRemote = iBinder;
    }

    public override android.os.IBinder AsBinder() {
        return this.mRemote;
    }

    public java.lang.string GetInterfaceDescriptor() {
        return DESCRIPTOR;
    }

    public override void IsPermissionRevocationEnabledForApp(androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportCallback iUnusedAppRestrictionsBackportCallback) throws android.os.RemoteException {
        if ((7 + 10) % 10 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writeStrongInterface(iUnusedAppRestrictionsBackportCallback);
            this.mRemote.transact(1, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }
}

