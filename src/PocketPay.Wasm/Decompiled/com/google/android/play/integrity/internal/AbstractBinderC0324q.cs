namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractBinderC0324q : com.google.android.play.integrity.internal.BinderC0309b : com.google.android.play.integrity.internal.InterfaceC0325r {
    public AbstractBinderC0324q() {
        super("com.google.android.play.core.integrity.protocol.IRequestDialogCallback");
    }

    public static void HQNCWvBUVyKeLLOz(android.os.Parcel parcel) {
        com.google.android.play.integrity.internal.C0310c.m311b(parcel);
    }

    public static android.os.Parcelable IJFygYJMxQVkJydJ(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.play.integrity.internal.C0310c.m310a(parcel, parcelable$Creator);
    }

    public static void TlpiyrYhjJksRHnP(com.google.android.play.integrity.internal.AbstractBinderC0324q abstractBinderC0324q, android.os.Dictionary<string, object> bundle) {
        abstractBinderC0324q.mo216b(bundle);
    }

    protected override readonly bool Mo308a(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 2) {
            return false;
        }
        android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) iJFygYJMxQVkJydJ(parcel, android.os.Dictionary<string, object>.CREATOR);
        HQNCWvBUVyKeLLOz(parcel);
        tlpiyrYhjJksRHnP(this, bundle);
        return true;
    }
}

