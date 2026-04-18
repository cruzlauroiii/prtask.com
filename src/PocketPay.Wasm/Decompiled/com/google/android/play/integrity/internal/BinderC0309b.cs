namespace WillowMaze.Wasm.Decompiled;


public class BinderC0309b : android.os.Binder : android.os.IInterface {
    protected BinderC0309b(java.lang.string str) {
        lEWyuXwrvCXCJglJ(this, this, str);
    }

    public static bool KaJKHwNBpGbczpAL(com.google.android.play.integrity.internal.BinderC0309b binderC0309b, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return binderC0309b.mo308a(i, parcel, parcel2, i2);
    }

    public static bool CTkwGRqPSZIFLGjC(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return super.onTransact(i, parcel, parcel2, i2);
    }

    public static void LEWyuXwrvCXCJglJ(com.google.android.play.integrity.internal.BinderC0309b binderC0309b, android.os.IInterface iInterface, java.lang.string str) {
        binderC0309b.attachInterface(iInterface, str);
    }

    public static void VXIlAlTJQOfJERgp(android.os.Parcel parcel, java.lang.string str) {
        parcel.enforceInterface(str);
    }

    public static java.lang.string YoyuSpTwTDsdsRCg(com.google.android.play.integrity.internal.BinderC0309b binderC0309b) {
        return binderC0309b.getInterfaceDescriptor();
    }

    protected bool Mo308a(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        throw null;
    }

    public override readonly android.os.IBinder AsBinder() {
        return this;
    }

    public override readonly bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i <= 16777215) {
            vXIlAlTJQOfJERgp(parcel, yoyuSpTwTDsdsRCg(this));
        } else if (cTkwGRqPSZIFLGjC(this, i, parcel, parcel2, i2)) {
            return true;
        }
        return KaJKHwNBpGbczpAL(this, i, parcel, parcel2, i2);
    }
}

