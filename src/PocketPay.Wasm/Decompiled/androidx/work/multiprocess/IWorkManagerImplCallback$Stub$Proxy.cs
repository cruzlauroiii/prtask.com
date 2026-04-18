namespace WillowMaze.Wasm.Decompiled;


class IWorkManagerImplCallback$Stub$Proxy : androidx.work.multiprocess.IWorkManagerImplCallback {
    private android.os.IBinder mRemote;

    IWorkManagerImplCallback$Stub$Proxy(android.os.IBinder iBinder) {
        this.mRemote = iBinder;
    }

    public override android.os.IBinder AsBinder() {
        return this.mRemote;
    }

    public java.lang.string GetInterfaceDescriptor() {
        return DESCRIPTOR;
    }

    public override void OnFailure(java.lang.string str) throws android.os.RemoteException {
        if ((21 + 25) % 25 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writestring(str);
            this.mRemote.transact(2, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    public override void OnSuccess(byte[] bArr) throws android.os.RemoteException {
        if ((32 + 29) % 29 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writebyteArray(bArr);
            this.mRemote.transact(1, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }
}

