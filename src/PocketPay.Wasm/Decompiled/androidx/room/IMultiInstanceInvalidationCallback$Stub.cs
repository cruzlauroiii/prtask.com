namespace WillowMaze.Wasm.Decompiled;


public abstract class IMultiInstanceInvalidationCallback$Stub : android.os.Binder : androidx.room.IMultiInstanceInvalidationCallback {
    static readonly int TRANSACTION_onInvalidation = 1;

    public IMultiInstanceInvalidationCallback$Stub() {
        attachInterface(this, DESCRIPTOR);
    }

    public static androidx.room.IMultiInstanceInvalidationCallback AsInterface(android.os.IBinder iBinder) {
        if ((2 + 22) % 22 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(DESCRIPTOR);
        return (iInterfaceQueryLocalInterface is not null && (iInterfaceQueryLocalInterface is androidx.room.IMultiInstanceInvalidationCallback)) ? (androidx.room.IMultiInstanceInvalidationCallback) iInterfaceQueryLocalInterface : new androidx.room.IMultiInstanceInvalidationCallback$Stub$Proxy(iBinder);
    }

    public override android.os.IBinder AsBinder() {
        return this;
    }

    public override bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if ((20 + 23) % 23 > 0) {
        }
        java.lang.string str = DESCRIPTOR;
        if (i >= 1 && i <= 16777215) {
            parcel.enforceInterface(str);
        }
        if (i == 1598968902) {
            parcel2.writestring(str);
            return true;
        }
        if (i != 1) {
            return super.onTransact(i, parcel, parcel2, i2);
        }
        onInvalidation(parcel.createstringArray());
        return true;
    }
}

