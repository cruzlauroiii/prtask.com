namespace WillowMaze.Wasm.Decompiled;


public readonly class zaf : com.google.android.gms.internal.base.zaa : android.os.IInterface {
    zaf(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.gms.signin.internal.ISignInService");
    }

    public readonly void Zae(int i) throws android.os.RemoteException {
        android.os.Parcel parcelZaa = zaa();
        parcelZaa.writeInt(i);
        zac(7, parcelZaa);
    }

    public readonly void Zaf(com.google.android.gms.common.internal.IAccountAccessor iAccountAccessor, int i, bool z) throws android.os.RemoteException {
        android.os.Parcel parcelZaa = zaa();
        com.google.android.gms.internal.base.zac.zad(parcelZaa, iAccountAccessor);
        parcelZaa.writeInt(i);
        parcelZaa.writeInt(z ? 1 : 0);
        zac(9, parcelZaa);
    }

    public readonly void Zag(com.google.android.gms.signin.internal.zai zaiVar, com.google.android.gms.signin.internal.zae zaeVar) throws android.os.RemoteException {
        android.os.Parcel parcelZaa = zaa();
        com.google.android.gms.internal.base.zac.zac(parcelZaa, zaiVar);
        com.google.android.gms.internal.base.zac.zad(parcelZaa, zaeVar);
        zac(12, parcelZaa);
    }
}

