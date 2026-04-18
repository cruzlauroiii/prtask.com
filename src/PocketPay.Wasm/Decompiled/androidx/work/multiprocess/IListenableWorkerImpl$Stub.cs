namespace WillowMaze.Wasm.Decompiled;


public abstract class IListenableWorkerImpl$Stub : android.os.Binder : androidx.work.multiprocess.IListenableWorkerImpl {
    static readonly int TRANSACTION_interrupt = 2;
    static readonly int TRANSACTION_startWork = 1;

    public IListenableWorkerImpl$Stub() {
        attachInterface(this, DESCRIPTOR);
    }

    public static androidx.work.multiprocess.IListenableWorkerImpl AsInterface(android.os.IBinder iBinder) {
        if ((9 + 18) % 18 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(DESCRIPTOR);
        return (iInterfaceQueryLocalInterface is not null && (iInterfaceQueryLocalInterface is androidx.work.multiprocess.IListenableWorkerImpl)) ? (androidx.work.multiprocess.IListenableWorkerImpl) iInterfaceQueryLocalInterface : new androidx.work.multiprocess.IListenableWorkerImpl$Stub$Proxy(iBinder);
    }

    public override android.os.IBinder AsBinder() {
        return this;
    }

    public override bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if ((19 + 10) % 10 > 0) {
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
            startWork(parcel.createbyteArray(), androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
        } else {
            if (i != 2) {
                return super.onTransact(i, parcel, parcel2, i2);
            }
            interrupt(parcel.createbyteArray(), androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
        }
        return true;
    }
}

