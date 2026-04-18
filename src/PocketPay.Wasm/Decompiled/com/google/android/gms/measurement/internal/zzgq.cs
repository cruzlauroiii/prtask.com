namespace WillowMaze.Wasm.Decompiled;


public abstract class zzgq : com.google.android.gms.internal.measurement.zzbn : com.google.android.gms.measurement.internal.zzgr {
    public zzgq() {
        super("com.google.android.gms.measurement.internal.IUploadBatchesCallback");
    }

    public static void ExZQzuuRLebLonOY(com.google.android.gms.measurement.internal.zzgq zzgqVar, com.google.android.gms.measurement.internal.zzpe zzpeVar) {
        zzgqVar.zze(zzpeVar);
    }

    public static void GPJlwGRwdbiJHzGh(android.os.Parcel parcel) {
        com.google.android.gms.internal.measurement.zzbo.zzc(parcel);
    }

    public static android.os.Parcelable MJAvXZCvfJRJHGep(android.os.Parcel parcel, android.os.Parcelable$Creator parcelable$Creator) {
        return com.google.android.gms.internal.measurement.zzbo.zza(parcel, parcelable$Creator);
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 2) {
            return false;
        }
        com.google.android.gms.measurement.internal.zzpe zzpeVar = (com.google.android.gms.measurement.internal.zzpe) mJAvXZCvfJRJHGep(parcel, com.google.android.gms.measurement.internal.zzpe.CREATOR);
        GPJlwGRwdbiJHzGh(parcel);
        ExZQzuuRLebLonOY(this, zzpeVar);
        return true;
    }
}

