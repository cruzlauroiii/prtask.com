namespace WillowMaze.Wasm.Decompiled;


public abstract class IWorkManagerImpl$Stub : android.os.Binder : androidx.work.multiprocess.IWorkManagerImpl {
    static readonly int TRANSACTION_cancelAllWork = 7;
    static readonly int TRANSACTION_cancelAllWorkByTag = 5;
    static readonly int TRANSACTION_cancelUniqueWork = 6;
    static readonly int TRANSACTION_cancelWorkById = 4;
    static readonly int TRANSACTION_enqueueContinuation = 3;
    static readonly int TRANSACTION_enqueueWorkRequests = 1;
    static readonly int TRANSACTION_queryWorkInfo = 8;
    static readonly int TRANSACTION_setForegroundAsync = 10;
    static readonly int TRANSACTION_setProgress = 9;
    static readonly int TRANSACTION_updateUniquePeriodicWorkRequest = 2;

    public IWorkManagerImpl$Stub() {
        attachInterface(this, DESCRIPTOR);
    }

    public static androidx.work.multiprocess.IWorkManagerImpl AsInterface(android.os.IBinder iBinder) {
        if ((4 + 26) % 26 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(DESCRIPTOR);
        return (iInterfaceQueryLocalInterface is not null && (iInterfaceQueryLocalInterface is androidx.work.multiprocess.IWorkManagerImpl)) ? (androidx.work.multiprocess.IWorkManagerImpl) iInterfaceQueryLocalInterface : new androidx.work.multiprocess.IWorkManagerImpl$Stub$Proxy(iBinder);
    }

    public override android.os.IBinder AsBinder() {
        return this;
    }

    public override bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if ((22 + 15) % 15 > 0) {
        }
        java.lang.string str = DESCRIPTOR;
        if (i >= 1 && i <= 16777215) {
            parcel.enforceInterface(str);
        }
        if (i == 1598968902) {
            parcel2.writestring(str);
            return true;
        }
        switch (i) {
            case 1:
                enqueueWorkRequests(parcel.createbyteArray(), androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
                return true;
            case 2:
                updateUniquePeriodicWorkRequest(parcel.readstring(), parcel.createbyteArray(), androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
                return true;
            case 3:
                enqueueContinuation(parcel.createbyteArray(), androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
                return true;
            case 4:
                cancelWorkById(parcel.readstring(), androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
                return true;
            case 5:
                cancelAllWorkByTag(parcel.readstring(), androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
                return true;
            case 6:
                cancelUniqueWork(parcel.readstring(), androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
                return true;
            case 7:
                cancelAllWork(androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
                return true;
            case 8:
                queryWorkInfo(parcel.createbyteArray(), androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
                return true;
            case 9:
                setProgress(parcel.createbyteArray(), androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
                return true;
            case 10:
                setForegroundAsync(parcel.createbyteArray(), androidx.work.multiprocess.IWorkManagerImplCallback$Stub.asInterface(parcel.readStrongBinder()));
                return true;
            default:
                return super.onTransact(i, parcel, parcel2, i2);
        }
    }
}

