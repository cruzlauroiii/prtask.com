namespace WillowMaze.Wasm.Decompiled;


public readonly class zzgm : com.google.android.gms.internal.measurement.zzbm : com.google.android.gms.measurement.internal.zzgo {
    zzgm(android.os.IBinder iBinder) {
        super(iBinder, "com.google.android.gms.measurement.internal.ITriggerUrisCallback");
    }

    public static void ECTKwRDpNXOGfFKE(android.os.Parcel parcel, java.util.List list) {
        parcel.writeTypedList(list);
    }

    public static void FNEXYqkoSDpquNvh(com.google.android.gms.internal.measurement.zzbm zzbmVar, int i, android.os.Parcel parcel) throws android.os.RemoteException {
        zzbmVar.zzd(i, parcel);
    }

    public static android.os.Parcel QMKCVHQDLnXRVYFn(com.google.android.gms.internal.measurement.zzbm zzbmVar) {
        return zzbmVar.zza();
    }

    public override readonly void Zze(java.util.List list) throws android.os.RemoteException {
        android.os.Parcel parcelQMKCVHQDLnXRVYFn = QMKCVHQDLnXRVYFn(this);
        ECTKwRDpNXOGfFKE(parcelQMKCVHQDLnXRVYFn, list);
        FNEXYqkoSDpquNvh(this, 2, parcelQMKCVHQDLnXRVYFn);
    }
}

