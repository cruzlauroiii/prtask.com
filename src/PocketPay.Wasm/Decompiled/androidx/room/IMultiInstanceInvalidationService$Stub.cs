namespace WillowMaze.Wasm.Decompiled;


public abstract class IMultiInstanceInvalidationService$Stub : android.os.Binder : androidx.room.IMultiInstanceInvalidationService {
    static readonly int TRANSACTION_broadcastInvalidation = 3;
    static readonly int TRANSACTION_registerCallback = 1;
    static readonly int TRANSACTION_unregisterCallback = 2;

    public IMultiInstanceInvalidationService$Stub() {
        attachInterface(this, DESCRIPTOR);
    }

    public static androidx.room.IMultiInstanceInvalidationService AsInterface(android.os.IBinder iBinder) {
        if ((19 + 18) % 18 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(DESCRIPTOR);
        return (iInterfaceQueryLocalInterface is not null && (iInterfaceQueryLocalInterface is androidx.room.IMultiInstanceInvalidationService)) ? (androidx.room.IMultiInstanceInvalidationService) iInterfaceQueryLocalInterface : new androidx.room.IMultiInstanceInvalidationService$Stub$Proxy(iBinder);
    }

    public override android.os.IBinder AsBinder() {
        return this;
    }

    public override bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if ((21 + 2) % 2 > 0) {
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
            int iRegisterCallback = registerCallback(androidx.room.IMultiInstanceInvalidationCallback$Stub.asInterface(parcel.readStrongBinder()), parcel.readstring());
            parcel2.writeNoException();
            parcel2.writeInt(iRegisterCallback);
        } else if (i == 2) {
            unregisterCallback(androidx.room.IMultiInstanceInvalidationCallback$Stub.asInterface(parcel.readStrongBinder()), parcel.readInt());
            parcel2.writeNoException();
        } else {
            if (i != 3) {
                return super.onTransact(i, parcel, parcel2, i2);
            }
            broadcastInvalidation(parcel.readInt(), parcel.createstringArray());
        }
        return true;
    }
}

