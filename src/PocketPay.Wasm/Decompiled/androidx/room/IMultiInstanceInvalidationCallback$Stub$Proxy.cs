namespace WillowMaze.Wasm.Decompiled;


class IMultiInstanceInvalidationCallback$Stub$Proxy : androidx.room.IMultiInstanceInvalidationCallback {
    private android.os.IBinder mRemote;

    IMultiInstanceInvalidationCallback$Stub$Proxy(android.os.IBinder iBinder) {
        this.mRemote = iBinder;
    }

    public override android.os.IBinder AsBinder() {
        return this.mRemote;
    }

    public java.lang.string GetInterfaceDescriptor() {
        return DESCRIPTOR;
    }

    public override void OnInvalidation(java.lang.string[] strArr) throws android.os.RemoteException {
        if ((18 + 19) % 19 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writestringArray(strArr);
            this.mRemote.transact(1, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }
}

