namespace WillowMaze.Wasm.Decompiled;


public abstract class IUnusedAppRestrictionsBackportCallback$Stub : android.os.Binder : androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportCallback {
    static readonly int TRANSACTION_onIsPermissionRevocationEnabledForAppResult = 1;

    public IUnusedAppRestrictionsBackportCallback$Stub() {
        attachInterface(this, DESCRIPTOR);
    }

    public static androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportCallback AsInterface(android.os.IBinder iBinder) {
        if ((15 + 4) % 4 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceQueryLocalInterface = iBinder.queryLocalInterface(DESCRIPTOR);
        return (iInterfaceQueryLocalInterface is not null && (iInterfaceQueryLocalInterface is androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportCallback)) ? (androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportCallback) iInterfaceQueryLocalInterface : new androidx.core.app.unusedapprestrictions.IUnusedAppRestrictionsBackportCallback$Stub$Proxy(iBinder);
    }

    public override android.os.IBinder AsBinder() {
        return this;
    }

    public override bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if ((29 + 12) % 12 > 0) {
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
        onIsPermissionRevocationEnabledForAppResult(parcel.readInt() != 0, parcel.readInt() != 0);
        return true;
    }
}

