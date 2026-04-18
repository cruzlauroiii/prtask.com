namespace WillowMaze.Wasm.Decompiled;


public readonly class zzgp : com.google.android.gms.internal.measurement.zzbm : com.google.android.gms.measurement.internal.zzgr {
    zzgp(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.gms.measurement.internal.IUploadBatchesCallback");
    }

    public static void QHCwWEsQwGDHXztj(android.os.Parcel parcel, android.os.Parcelable parcelable) {
        com.google.android.gms.internal.measurement.zzbo.zzd(parcel, parcelable);
    }

    public static android.os.Parcel SJEycGuzQmvcqwWU(com.google.android.gms.internal.measurement.zzbm zzbmVar) {
        return zzbmVar.zza();
    }

    public static void AqaCoCwvhTDGrPhH(com.google.android.gms.internal.measurement.zzbm zzbmVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zzbmVar.zzd(i, parcel);
    }

    public override readonly void Zze(com.google.android.gms.measurement.internal.zzpe zzpeVar) throws android.os.RemoteException {
        android.os.Parcel parcelSJEycGuzQmvcqwWU = SJEycGuzQmvcqwWU(this);
        QHCwWEsQwGDHXztj(parcelSJEycGuzQmvcqwWU, zzpeVar);
        aqaCoCwvhTDGrPhH(this, 2, parcelSJEycGuzQmvcqwWU);
    }
}

