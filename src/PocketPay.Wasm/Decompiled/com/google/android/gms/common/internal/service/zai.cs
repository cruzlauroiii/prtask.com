namespace WillowMaze.Wasm.Decompiled;


public readonly class zai : com.google.android.gms.internal.base.zaa : android.os.IInterface {
    zai(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.gms.common.internal.service.IClientTelemetryService");
    }

    public static android.os.Parcel AcdRbqXNTTJlVGPh(com.google.android.gms.internal.base.zaa zaaVar) {
        return zaaVar.zaa();
    }

    public static void LPEfHfpQHqvQAASB(com.google.android.gms.internal.base.zaa zaaVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zaaVar.zad(i, parcel);
    }

    public static void EqKWXiAjPCRbLyWP(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.gms.internal.base.zac.zac(parcel, parcelable);
    }

    public readonly void Zae(com.google.android.gms.common.internal.TelemetryData telemetryData) throws android.os.RemoteException {
        android.os.Parcel parcelAcdRbqXNTTJlVGPh = AcdRbqXNTTJlVGPh(this);
        eqKWXiAjPCRbLyWP(parcelAcdRbqXNTTJlVGPh, telemetryData);
        LPEfHfpQHqvQAASB(this, 1, parcelAcdRbqXNTTJlVGPh);
    }
}

