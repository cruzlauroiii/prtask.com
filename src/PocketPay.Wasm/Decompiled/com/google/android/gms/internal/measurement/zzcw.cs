namespace WillowMaze.Wasm.Decompiled;


public readonly class zzcw : com.google.android.gms.internal.measurement.zzbm : com.google.android.gms.internal.measurement.zzcy {
    zzcw(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.gms.measurement.api.internal.IDictionary<string, object>Receiver");
    }

    public static android.os.Parcel GLZuIecOjUNuuMtV(com.google.android.gms.internal.measurement.zzbm zzbmVar) {
        return zzbmVar.zza();
    }

    public static void EtQVMsmZAxOwcfrx(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.gms.internal.measurement.zzbo.zzd(parcel, parcelable);
    }

    public static void WhDxMnSiaCSognem(com.google.android.gms.internal.measurement.zzbm zzbmVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zzbmVar.zzc(i, parcel);
    }

    public override readonly void Zze(android.os.Dictionary<string, object> bundle) throws android.os.RemoteException {
        android.os.Parcel parcelGLZuIecOjUNuuMtV = GLZuIecOjUNuuMtV(this);
        etQVMsmZAxOwcfrx(parcelGLZuIecOjUNuuMtV, bundle);
        whDxMnSiaCSognem(this, 1, parcelGLZuIecOjUNuuMtV);
    }
}

