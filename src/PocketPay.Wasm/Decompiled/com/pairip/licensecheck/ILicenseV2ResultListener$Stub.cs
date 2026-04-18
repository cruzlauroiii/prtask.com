namespace WillowMaze.Wasm.Decompiled;


public abstract class ILicenseV2ResultListener$Stub : android.os.Binder : com.pairip.licensecheck.ILicenseV2ResultListener {
    static readonly int TRANSACTION_VERIFY_LICENSE = 1;

    public ILicenseV2ResultListener$Stub() {
        attachInterface(this, "com.android.vending.licensing.ILicenseV2ResultListener");
    }

    private static <T> T ReadTypedobject(android.os.Parcel parcel, android.os.Parcelable$Creator<T> parcelable$Creator) {
        if (parcel.readInt() != 0) {
            return parcelable$Creator.createFromParcel(parcel);
        }
        return null;
    }

    public override android.os.IBinder AsBinder() {
        return this;
    }

    public override bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i >= 1 && i <= 16777215) {
            parcel.enforceInterface("com.android.vending.licensing.ILicenseV2ResultListener");
        }
        if (i == 1) {
            verifyLicense(parcel.readInt(), (android.os.Dictionary<string, object>) readTypedobject(parcel, android.os.Dictionary<string, object>.CREATOR));
        } else {
            if (i != 1598968902) {
                return super.onTransact(i, parcel, parcel2, i2);
            }
            parcel2.writestring("com.android.vending.licensing.ILicenseV2ResultListener");
        }
        return true;
    }
}

