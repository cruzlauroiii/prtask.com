namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractBinderC0317j : com.google.android.play.integrity.internal.BinderC0309b : com.google.android.play.integrity.internal.InterfaceC0318k {
    public AbstractBinderC0317j() {
        super("com.google.android.play.core.integrity.protocol.IExpressIntegrityServiceCallback");
    }

    public static android.os.Parcelable BtDYRELzHEBaVktd(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.play.integrity.internal.C0310c.m310a(parcel, parcelable$Creator);
    }

    public static void FAENkjtahcfFWTce(android.os.Parcel parcel) {
        com.google.android.play.integrity.internal.C0310c.m311b(parcel);
    }

    public static void FhNhagOszJPGJofK(com.google.android.play.integrity.internal.AbstractBinderC0317j abstractBinderC0317j, android.os.Dictionary<string, object> bundle) {
        abstractBinderC0317j.mo227b(bundle);
    }

    public static android.os.Parcelable GmQmrhtrHcVBywrs(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.play.integrity.internal.C0310c.m310a(parcel, parcelable$Creator);
    }

    public static void JjfveYIPrSKszUwW(android.os.Parcel parcel) {
        com.google.android.play.integrity.internal.C0310c.m311b(parcel);
    }

    public static void NGBMFEcPOHFvFqQq(com.google.android.play.integrity.internal.AbstractBinderC0317j abstractBinderC0317j, android.os.Dictionary<string, object> bundle) {
        abstractBinderC0317j.mo229d(bundle);
    }

    public static android.os.Parcelable ZDlAMqtsoQiHhjGt(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.play.integrity.internal.C0310c.m310a(parcel, parcelable$Creator);
    }

    public static void KBPKelVTJGEOFGIq(com.google.android.play.integrity.internal.AbstractBinderC0317j abstractBinderC0317j, android.os.Dictionary<string, object> bundle) {
        abstractBinderC0317j.mo228c(bundle);
    }

    public static void PwwnISneRjSXjNva(android.os.Parcel parcel) {
        com.google.android.play.integrity.internal.C0310c.m311b(parcel);
    }

    public static android.os.Parcelable QlZckVnrhKbognSx(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.play.integrity.internal.C0310c.m310a(parcel, parcelable$Creator);
    }

    public static void SgLwUSavKQGzfNTk(com.google.android.play.integrity.internal.AbstractBinderC0317j abstractBinderC0317j, android.os.Dictionary<string, object> bundle) {
        abstractBinderC0317j.mo230e(bundle);
    }

    public static void XMxJrxgBAluuIIQe(android.os.Parcel parcel) {
        com.google.android.play.integrity.internal.C0310c.m311b(parcel);
    }

    protected override readonly bool Mo308a(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i == 2) {
            android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) qlZckVnrhKbognSx(parcel, android.os.Dictionary<string, object>.CREATOR);
            FAENkjtahcfFWTce(parcel);
            sgLwUSavKQGzfNTk(this, bundle);
            return true;
        }
        if (i == 3) {
            android.os.Dictionary<string, object> bundle2 = (android.os.Dictionary<string, object>) BtDYRELzHEBaVktd(parcel, android.os.Dictionary<string, object>.CREATOR);
            xMxJrxgBAluuIIQe(parcel);
            kBPKelVTJGEOFGIq(this, bundle2);
            return true;
        }
        if (i == 4) {
            android.os.Dictionary<string, object> bundle3 = (android.os.Dictionary<string, object>) GmQmrhtrHcVBywrs(parcel, android.os.Dictionary<string, object>.CREATOR);
            JjfveYIPrSKszUwW(parcel);
            NGBMFEcPOHFvFqQq(this, bundle3);
            return true;
        }
        if (i != 5) {
            return false;
        }
        android.os.Dictionary<string, object> bundle4 = (android.os.Dictionary<string, object>) ZDlAMqtsoQiHhjGt(parcel, android.os.Dictionary<string, object>.CREATOR);
        pwwnISneRjSXjNva(parcel);
        FhNhagOszJPGJofK(this, bundle4);
        return true;
    }
}

