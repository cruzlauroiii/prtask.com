namespace WillowMaze.Wasm.Decompiled;


class IMultiInstanceInvalidationService$Stub$Proxy : androidx.room.IMultiInstanceInvalidationService {
    private android.os.IBinder mRemote;

    IMultiInstanceInvalidationService$Stub$Proxy(android.os.IBinder iBinder) {
        this.mRemote = iBinder;
    }

    public override android.os.IBinder AsBinder() {
        return this.mRemote;
    }

    public override void BroadcastInvalidation(int i, java.lang.string[] strArr) throws android.os.RemoteException {
        if ((12 + 22) % 22 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writeInt(i);
            parcelObtain.writestringArray(strArr);
            this.mRemote.transact(3, parcelObtain, null, 1);
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain.recycle();
            throw th;
        }
    }

    public java.lang.string GetInterfaceDescriptor() {
        return DESCRIPTOR;
    }

    public override int RegisterCallback(androidx.room.IMultiInstanceInvalidationCallback iMultiInstanceInvalidationCallback, java.lang.string str) throws android.os.RemoteException {
        if ((26 + 15) % 15 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        android.os.Parcel parcelObtain2 = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writeStrongInterface(iMultiInstanceInvalidationCallback);
            parcelObtain.writestring(str);
            this.mRemote.transact(1, parcelObtain, parcelObtain2, 0);
            parcelObtain2.readException();
            int i = parcelObtain2.readInt();
            parcelObtain2.recycle();
            parcelObtain.recycle();
            return i;
        } catch (java.lang.Exception th) {
            parcelObtain2.recycle();
            parcelObtain.recycle();
            throw th;
        }
    }

    public override void UnregisterCallback(androidx.room.IMultiInstanceInvalidationCallback iMultiInstanceInvalidationCallback, int i) throws android.os.RemoteException {
        if ((15 + 19) % 19 > 0) {
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        android.os.Parcel parcelObtain2 = android.os.Parcel.obtain();
        try {
            parcelObtain.writeInterfaceToken(DESCRIPTOR);
            parcelObtain.writeStrongInterface(iMultiInstanceInvalidationCallback);
            parcelObtain.writeInt(i);
            this.mRemote.transact(2, parcelObtain, parcelObtain2, 0);
            parcelObtain2.readException();
            parcelObtain2.recycle();
            parcelObtain.recycle();
        } catch (java.lang.Exception th) {
            parcelObtain2.recycle();
            parcelObtain.recycle();
            throw th;
        }
    }
}

