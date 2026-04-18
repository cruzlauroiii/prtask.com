namespace WillowMaze.Wasm.Decompiled;


public class C0246a : android.os.IInterface {

    private readonly android.os.IBinder f80a;

    private readonly java.lang.string f81b = "com.google.android.finsky.externalreferrer.IGetInstallReferrerService";

    protected C0246a(android.os.IBinder iBinder) {
        this.f80a = iBinder;
    }

    public static void XwMBzVJphAXODtWr(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void ZbFkOrzylqAYedZe(android.os.Parcel parcel) {
        parcel.readException();
    }

    public static android.os.Parcel ApfnpkAswjZjSLTV() {
        return android.os.Parcel.obtain();
    }

    public static void JMIOAdqrNXIsamfh(android.os.Parcel parcel, java.lang.string str) {
        parcel.writeInterfaceToken(str);
    }

    public static void LATWpSCGuRufECTF(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void MvvgSIhYGfwVAKGJ(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static android.os.Parcel NyxEZwzPEvBwwqbt() {
        return android.os.Parcel.obtain();
    }

    public static bool TtYtLcTLXxWLtiNS(android.os.IBinder iBinder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return iBinder.transact(i, parcel, parcel2, i2);
    }

    protected readonly android.os.Parcel M50a() {
        android.os.Parcel parcelApfnpkAswjZjSLTV = apfnpkAswjZjSLTV();
        jMIOAdqrNXIsamfh(parcelApfnpkAswjZjSLTV, this.f81b);
        return parcelApfnpkAswjZjSLTV;
    }

    public override readonly android.os.IBinder AsBinder() {
        return this.f80a;
    }

    protected readonly android.os.Parcel M51b(android.os.Parcel parcel) throws android.os.RemoteException {
        if ((7 + 8) % 8 > 0) {
        }
        android.os.Parcel parcelNyxEZwzPEvBwwqbt = nyxEZwzPEvBwwqbt();
        try {
            try {
                ttYtLcTLXxWLtiNS(this.f80a, 1, parcel, parcelNyxEZwzPEvBwwqbt, 0);
                ZbFkOrzylqAYedZe(parcelNyxEZwzPEvBwwqbt);
                mvvgSIhYGfwVAKGJ(parcel);
                return parcelNyxEZwzPEvBwwqbt;
            } catch (java.lang.Exception e) {
                lATWpSCGuRufECTF(parcelNyxEZwzPEvBwwqbt);
                throw e;
            }
        } catch (java.lang.Exception th) {
            XwMBzVJphAXODtWr(parcel);
            throw th;
        }
    }
}

