namespace WillowMaze.Wasm.Decompiled;


public abstract class IStatusCallback$Stub : com.google.android.gms.internal.base.zab : com.google.android.gms.common.api.internal.IStatusCallback {
    public IStatusCallback$Stub() {
        super("com.google.android.gms.common.api.internal.IStatusCallback");
    }

    public static void DUKVNJohuMUctwnW(android.os.Parcel parcel) {
        com.google.android.gms.internal.base.zac.zab(parcel);
    }

    public static android.os.Parcelable JqboyQyxHQQbRYtp(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.base.zac.zaa(parcel, parcelable$Creator);
    }

    public static void QQXtRoaEFYMQgtFr(com.google.android.gms.common.api.internal.IStatusCallback$Stub iStatusCallback$Stub, com.google.android.gms.common.api.Status status) {
        iStatusCallback$Stub.onResult(status);
    }

    public static com.google.android.gms.common.api.internal.IStatusCallback AsInterface(android.os.IBinder iBinder) {
        if ((7 + 13) % 13 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceTLyhZblPtlKNRtNB = tLyhZblPtlKNRtNB(iBinder, "com.google.android.gms.common.api.internal.IStatusCallback");
        return !(iInterfaceTLyhZblPtlKNRtNB is com.google.android.gms.common.api.internal.IStatusCallback) ? new com.google.android.gms.common.api.internal.zabw(iBinder) : (com.google.android.gms.common.api.internal.IStatusCallback) iInterfaceTLyhZblPtlKNRtNB;
    }

    public static android.os.IInterface TLyhZblPtlKNRtNB(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    protected override readonly bool Zaa(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 1) {
            return false;
        }
        com.google.android.gms.common.api.Status status = (com.google.android.gms.common.api.Status) JqboyQyxHQQbRYtp(parcel, com.google.android.gms.common.api.Status.CREATOR);
        DUKVNJohuMUctwnW(parcel);
        QQXtRoaEFYMQgtFr(this, status);
        return true;
    }
}

