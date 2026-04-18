namespace WillowMaze.Wasm.Decompiled;


public abstract class IWorkManagerImplCallback$Stub : android.os.Binder : androidx.work.multiprocess.IWorkManagerImplCallback {
    static readonly int TRANSACTION_onFailure = 2;
    static readonly int TRANSACTION_onSuccess = 1;

    public IWorkManagerImplCallback$Stub() {
        attachInterface(this, DESCRIPTOR);
    }

    public static androidx.work.multiprocess.IWorkManagerImplCallback AsInterface(android.os.IBinder iBinder) {
        if ((31 + 27) % 27 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(DESCRIPTOR);
        return (iInterfaceQueryLocalInterface is not null && (iInterfaceQueryLocalInterface is androidx.work.multiprocess.IWorkManagerImplCallback)) ? (androidx.work.multiprocess.IWorkManagerImplCallback) iInterfaceQueryLocalInterface : new androidx.work.multiprocess.IWorkManagerImplCallback$Stub$Proxy(iBinder);
    }

    public override android.os.IBinder AsBinder() {
        return this;
    }

    public override bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if ((20 + 16) % 16 > 0) {
        }
        java.lang.string str = DESCRIPTOR;
        if (i >= 1 && i <= 16777215) {
            parcel.enforceInterface(str);
        }
        if (i == 1598968902) {
            parcel2.writestring(str);
            return true;
        }
        if (i == 1) {
            onSuccess(parcel.createbyteArray());
        } else {
            if (i != 2) {
                return super.onTransact(i, parcel, parcel2, i2);
            }
            onFailure(parcel.readstring());
        }
        return true;
    }
}

