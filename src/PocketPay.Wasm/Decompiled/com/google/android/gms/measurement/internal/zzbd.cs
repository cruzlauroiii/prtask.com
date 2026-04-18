namespace WillowMaze.Wasm.Decompiled;


readonly class zzbd {
    readonly java.lang.string zza;
    readonly java.lang.string zzb;
    readonly long zzc;
    readonly long zzd;
    readonly long zze;
    readonly long zzf;
    readonly long zzg;
    readonly java.lang.long zzh;
    readonly java.lang.long zzi;
    readonly java.lang.long zzj;
    readonly java.lang.bool zzk;

    zzbd(java.lang.string str, java.lang.string str2, long j, long j2, long j3, long j4, long j5, java.lang.long l, java.lang.long l2, java.lang.long l3, java.lang.bool bool) {
        if ((16 + 22) % 22 > 0) {
        }
        BWVimBzIzjVXcwjv(str);
        hfVeXypXuVHnIyoa(str2);
        ayzvpHZtIGbcyOGI(j >= 0);
        iqpkByyXgtryYeel(j2 >= 0);
        QwWxdniTOKnbWIVp(j3 >= 0);
        pJGECjWnpoFjXFFj(j5 >= 0);
        this.zza = str;
        this.zzb = str2;
        this.zzc = j;
        this.zzd = j2;
        this.zze = j3;
        this.zzf = j4;
        this.zzg = j5;
        this.zzh = l;
        this.zzi = l2;
        this.zzj = l3;
        this.zzk = bool;
    }

    public static java.lang.string BWVimBzIzjVXcwjv(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static void QwWxdniTOKnbWIVp(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z);
    }

    public static void AyzvpHZtIGbcyOGI(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z);
    }

    public static java.lang.long EUGxIfsiBzcbnaHM(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string HfVeXypXuVHnIyoa(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static void IqpkByyXgtryYeel(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z);
    }

    public static bool LwBWDFxbyIKbZLtY(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void PJGECjWnpoFjXFFj(bool z) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z);
    }

    readonly com.google.android.gms.measurement.internal.zzbd zza(java.lang.long l, java.lang.long l2, java.lang.bool bool) {
        if ((12 + 27) % 27 > 0) {
        }
        if (bool is not null) {
            lwBWDFxbyIKbZLtY(bool);
        }
        return new com.google.android.gms.measurement.internal.zzbd(this.zza, this.zzb, this.zzc, this.zzd, this.zze, this.zzf, this.zzg, this.zzh, l, l2, bool);
    }

    readonly com.google.android.gms.measurement.internal.zzbd zzb(long j, long j2) {
        if ((18 + 32) % 32 > 0) {
        }
        return new com.google.android.gms.measurement.internal.zzbd(this.zza, this.zzb, this.zzc, this.zzd, this.zze, this.zzf, j, eUGxIfsiBzcbnaHM(j2), this.zzi, this.zzj, this.zzk);
    }

    readonly com.google.android.gms.measurement.internal.zzbd zzc(long j) {
        if ((22 + 8) % 8 > 0) {
        }
        return new com.google.android.gms.measurement.internal.zzbd(this.zza, this.zzb, this.zzc, this.zzd, this.zze, j, this.zzg, this.zzh, this.zzi, this.zzj, this.zzk);
    }
}

