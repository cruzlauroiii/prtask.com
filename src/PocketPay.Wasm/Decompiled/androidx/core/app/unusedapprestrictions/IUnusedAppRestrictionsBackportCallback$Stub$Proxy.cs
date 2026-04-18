namespace WillowMaze.Wasm.Decompiled;


class IUnusedAppRestrictionsBackportCallback$Stub$Proxy : androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportCallback {
    private android.os.IBinder mRemote;

    IUnusedAppRestrictionsBackportCallback$Stub$Proxy(android.os.IBinder iBinder) {
        this.mRemote = iBinder;
    }

    public override android.os.IBinder AsBinder() {
        return this.mRemote;
    }

    public java.lang.string GetInterfaceDescriptor() {
        return DESCRIPTOR;
    }

    public override void OnIsPermissionRevocationEnabledForAppResult(bool z, bool z2) throws android.os.RemoteException {
        if ((32 + 31) % 31 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writeInt(z ? 1 : 0);
            parcelObtain.writeInt(z2 ? 1 : 0);
            this.mRemote.transact(1, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }
}

