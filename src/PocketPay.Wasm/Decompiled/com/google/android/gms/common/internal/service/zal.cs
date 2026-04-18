namespace WillowMaze.Wasm.Decompiled;


public readonly class zal : com.google.android.gms.internal.base.zaa : android.os.IInterface {
    zal(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.gms.common.internal.service.ICommonService");
    }

    public static android.os.Parcel BzCAsorxPGQdtZaP(com.google.android.gms.internal.base.zaa zaaVar) {
        return zaaVar.zaa();
    }

    public static void BENVZLnPVUimZRXS(android.os.Parcel parcel, android.os.IInterface iInterface) {
        com.google.android.gms.internal.base.zac.zad(parcel, iInterface);
    }

    public static void IliiVuMQshgsZMXL(com.google.android.gms.internal.base.zaa zaaVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zaaVar.zad(i, parcel);
    }

    public readonly void Zae(com.google.android.gms.common.internal.service.zak zakVar) throws android.os.RemoteException {
        android.os.Parcel parcelBzCAsorxPGQdtZaP = BzCAsorxPGQdtZaP(this);
        bENVZLnPVUimZRXS(parcelBzCAsorxPGQdtZaP, zakVar);
        iliiVuMQshgsZMXL(this, 1, parcelBzCAsorxPGQdtZaP);
    }
}

