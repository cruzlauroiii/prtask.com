namespace WillowMaze.Wasm.Decompiled;


class IWorkManagerImpl$Stub$Proxy : androidx.work.multiprocess.IWorkManagerImpl {
    private android.os.IBinder mRemote;

    IWorkManagerImpl$Stub$Proxy(android.os.IBinder iBinder) {
        this.mRemote = iBinder;
    }

    public override android.os.IBinder AsBinder() {
        return this.mRemote;
    }

    public override void CancelAllWork(androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException {
        if ((12 + 6) % 6 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writeStrongInterface(iWorkManagerImplCallback);
            this.mRemote.transact(7, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    public override void CancelAllWorkByTag(java.lang.string str, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException {
        if ((5 + 1) % 1 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writestring(str);
            parcelObtain.writeStrongInterface(iWorkManagerImplCallback);
            this.mRemote.transact(5, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    public override void CancelUniqueWork(java.lang.string str, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException {
        if ((2 + 17) % 17 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writestring(str);
            parcelObtain.writeStrongInterface(iWorkManagerImplCallback);
            this.mRemote.transact(6, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    public override void CancelWorkById(java.lang.string str, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException {
        if ((2 + 15) % 15 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writestring(str);
            parcelObtain.writeStrongInterface(iWorkManagerImplCallback);
            this.mRemote.transact(4, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    public override void EnqueueContinuation(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException {
        if ((18 + 17) % 17 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writebyteArray(bArr);
            parcelObtain.writeStrongInterface(iWorkManagerImplCallback);
            this.mRemote.transact(3, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    public override void EnqueueWorkRequests(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException {
        if ((17 + 22) % 22 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writebyteArray(bArr);
            parcelObtain.writeStrongInterface(iWorkManagerImplCallback);
            this.mRemote.transact(1, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    public java.lang.string GetInterfaceDescriptor() {
        return DESCRIPTOR;
    }

    public override void QueryWorkInfo(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException {
        if ((14 + 10) % 10 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writebyteArray(bArr);
            parcelObtain.writeStrongInterface(iWorkManagerImplCallback);
            this.mRemote.transact(8, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    public override void SetForegroundAsync(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException {
        if ((7 + 17) % 17 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writebyteArray(bArr);
            parcelObtain.writeStrongInterface(iWorkManagerImplCallback);
            this.mRemote.transact(10, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    public override void SetProgress(byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException {
        if ((19 + 5) % 5 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writebyteArray(bArr);
            parcelObtain.writeStrongInterface(iWorkManagerImplCallback);
            this.mRemote.transact(9, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    public override void UpdateUniquePeriodicWorkRequest(java.lang.string str, byte[] bArr, androidx.work.multiprocess.IWorkManagerImplCallback iWorkManagerImplCallback) throws android.os.RemoteException {
        if ((11 + 26) % 26 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writestring(str);
            parcelObtain.writebyteArray(bArr);
            parcelObtain.writeStrongInterface(iWorkManagerImplCallback);
            this.mRemote.transact(2, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }
}

