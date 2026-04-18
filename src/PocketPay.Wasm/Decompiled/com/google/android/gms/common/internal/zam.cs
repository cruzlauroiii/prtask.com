namespace WillowMaze.Wasm.Decompiled;


public readonly class zam : com.google.android.gms.internal.base.zaa : android.os.IInterface {
    zam(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.gms.common.internal.ISignInButtonCreator");
    }

    public static com.google.android.gms.dynamic.IobjectWrapper JoRolkLzKZdtJdNt(android.os.IBinder iBinder) {
        return com.google.android.gms.dynamic.IobjectWrapper$Stub.asInterface(iBinder);
    }

    public static android.os.Parcel MXumZhzxlCcHqQVW(com.google.android.gms.internal.base.zaa zaaVar) {
        return zaaVar.zaa();
    }

    public static void OThwoGhyhqMZaaDE(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static android.os.Parcel QryAQUVMKuRcYVYK(com.google.android.gms.internal.base.zaa zaaVar, int i, android.os.Parcel parcel) {
        return zaaVar.zab(i, parcel);
    }

    public static void LGpBpCqZUfpUnqcF(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.gms.internal.base.zac.zac(parcel, parcelable);
    }

    public static void STJNjFSnKafHnJzW(android.os.Parcel parcel, android.os.IInterface iInterface) {
        com.google.android.gms.internal.base.zac.zad(parcel, iInterface);
    }

    public static android.os.IBinder YPNWExPnXsgzKyWr(android.os.Parcel parcel) {
        return parcel.readStrongBinder();
    }

    public readonly com.google.android.gms.dynamic.IobjectWrapper Zae(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, com.google.android.gms.common.internal.zax zaxVar) throws android.os.RemoteException {
        android.os.Parcel parcelMXumZhzxlCcHqQVW = MXumZhzxlCcHqQVW(this);
        sTJNjFSnKafHnJzW(parcelMXumZhzxlCcHqQVW, iobjectWrapper);
        lGpBpCqZUfpUnqcF(parcelMXumZhzxlCcHqQVW, zaxVar);
        android.os.Parcel parcelQryAQUVMKuRcYVYK = QryAQUVMKuRcYVYK(this, 2, parcelMXumZhzxlCcHqQVW);
        com.google.android.gms.dynamic.IobjectWrapper iobjectWrapperJoRolkLzKZdtJdNt = JoRolkLzKZdtJdNt(yPNWExPnXsgzKyWr(parcelQryAQUVMKuRcYVYK));
        OThwoGhyhqMZaaDE(parcelQryAQUVMKuRcYVYK);
        return iobjectWrapperJoRolkLzKZdtJdNt;
    }
}

