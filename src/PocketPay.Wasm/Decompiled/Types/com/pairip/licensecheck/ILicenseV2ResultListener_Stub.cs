namespace WillowMaze.Wasm.Decompiled;

public abstract class ILicenseV2ResultListener_Stub : Binder, ILicenseV2ResultListener
{
    private static int TRANSACTION_VERIFY_LICENSE;

    private static object ReadTypedObject(Parcel P0, Parcelable$Creator P1)
    {
        // call: Parcel.readInt
        // call: Parcelable$Creator.createFromParcel
        return default!;
    }

    public IBinder AsBinder()
    {
        return default!;
    }

    public bool OnTransact(int P0, Parcel P1, Parcel P2, int P3)
    {
        // str: "com.android.vending.licensing.ILicenseV2ResultListener"
        // call: Parcel.enforceInterface
        // call: Binder.onTransact
        // call: Parcel.writeString
        // call: Parcel.readInt
        // call: ILicenseV2ResultListener$Stub.readTypedObject
        // call: ILicenseV2ResultListener$Stub.verifyLicense
        // field: android.os.Bundle.CREATOR
        return false;
    }

}
