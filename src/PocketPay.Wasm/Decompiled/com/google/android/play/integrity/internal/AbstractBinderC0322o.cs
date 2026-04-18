namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractBinderC0322o : com.google.android.play.integrity.internal.BinderC0309b : com.google.android.play.integrity.internal.InterfaceC0323p {
    public AbstractBinderC0322o() {
        super("com.google.android.play.core.integrity.protocol.IIntegrityServiceCallback");
    }

    public static void COCbJUFuYkMWKhVS(android.os.Parcel parcel) {
        com.google.android.play.integrity.internal.C0310c.m311b(parcel);
    }

    public static android.os.Parcelable KckZjoqBYHJYCoIT(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.play.integrity.internal.C0310c.m310a(parcel, parcelable$Creator);
    }

    public static void TalFdBruTDGNXCnh(com.google.android.play.integrity.internal.AbstractBinderC0322o abstractBinderC0322o, android.os.Dictionary<string, object> bundle) {
        abstractBinderC0322o.mo207b(bundle);
    }

    protected override readonly bool Mo308a(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 2) {
            return false;
        }
        android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) KckZjoqBYHJYCoIT(parcel, android.os.Dictionary<string, object>.CREATOR);
        COCbJUFuYkMWKhVS(parcel);
        TalFdBruTDGNXCnh(this, bundle);
        return true;
    }
}

