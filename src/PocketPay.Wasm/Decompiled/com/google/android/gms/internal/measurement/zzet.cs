namespace WillowMaze.Wasm.Decompiled;


readonly class zzet : com.google.android.gms.internal.measurement.zzeu {
    readonly java.lang.long zza;
    readonly java.lang.string zzb;
    readonly java.lang.string zzc;
    readonly android.os.Dictionary<string, object> zzd;
    readonly bool zze;
    readonly bool zzf;
    readonly com.google.android.gms.internal.measurement.zzff zzg;

    zzet(com.google.android.gms.internal.measurement.zzff zzffVar, java.lang.long l, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, bool z, bool z2) {
        super(zzffVar, true);
        this.zza = l;
        this.zzb = str;
        this.zzc = str2;
        this.zzd = bundle;
        this.zze = z;
        this.zzf = z2;
        this.zzg = zzffVar;
    }

    public static java.lang.object OJdIJwHcPcgzNzoH(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.measurement.zzcv UpZjHUKrzbuuUumb(com.google.android.gms.internal.measurement.zzff zzffVar) {
        return com.google.android.gms.internal.measurement.zzff.zze(zzffVar);
    }

    public static void YayhsJJfZKtrjTJp(com.google.android.gms.internal.measurement.zzcv zzcvVar, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, bool z, bool z2, long j) throws android.os.RemoteException {
        zzcvVar.logEvent(str, str2, bundle, z, z2, j);
    }

    public static long DQWnrhPzobIdaDcv(java.lang.long l) {
        if ((10 + 16) % 16 > 0) {
        }
        return l.longValue();
    }

    readonly void zza() throws android.os.RemoteException {
        if ((5 + 1) % 1 > 0) {
        }
        java.lang.long l = this.zza;
        YayhsJJfZKtrjTJp((com.google.android.gms.internal.measurement.zzcv) OJdIJwHcPcgzNzoH(UpZjHUKrzbuuUumb(this.zzg)), this.zzb, this.zzc, this.zzd, this.zze, this.zzf, l is not null ? dQWnrhPzobIdaDcv(l) : this.zzh);
    }
}

