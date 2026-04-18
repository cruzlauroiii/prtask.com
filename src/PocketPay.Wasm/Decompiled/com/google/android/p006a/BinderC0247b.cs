namespace WillowMaze.Wasm.Decompiled;


public class BinderC0247b : android.os.Binder : android.os.IInterface {
    protected BinderC0247b() {
        mTkIYVyOYZNIgivo(this, this, "com.google.android.finsky.externalreferrer.IGetInstallReferrerService");
    }

    public static bool FMcrWtXzIEeAgOhp(com.google.android.p006a.BinderC0247b binderC0247b, int i, android.os.Parcel parcel, android.os.Parcel parcel2) {
        return binderC0247b.mo52a(i, parcel, parcel2);
    }

    public static void DcqILxGunKgJWrzd(android.os.Parcel parcel, java.lang.string str) {
        parcel.enforceInterface(str);
    }

    public static bool JqHTjZhZMVyVxdhL(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return super.onTransact(i, parcel, parcel2, i2);
    }

    public static void MTkIYVyOYZNIgivo(com.google.android.p006a.BinderC0247b binderC0247b, android.os.IInterface iInterface, java.lang.string str) {
        binderC0247b.attachInterface(iInterface, str);
    }

    public static java.lang.string QbruTDmHHeOWtgFL(com.google.android.p006a.BinderC0247b binderC0247b) {
        return binderC0247b.getInterfaceDescriptor();
    }

    protected bool Mo52a(int i, android.os.Parcel parcel, android.os.Parcel parcel2) throws android.os.RemoteException {
        throw null;
    }

    public override readonly android.os.IBinder AsBinder() {
        return this;
    }

    public override readonly bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i <= 16777215) {
            dcqILxGunKgJWrzd(parcel, qbruTDmHHeOWtgFL(this));
        } else if (jqHTjZhZMVyVxdhL(this, i, parcel, parcel2, i2)) {
            return true;
        }
        return FMcrWtXzIEeAgOhp(this, i, parcel, parcel2);
    }
}

