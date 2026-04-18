namespace WillowMaze.Wasm.Decompiled;


public readonly class zzib : java.util.concurrent.Func {
    public readonly com.google.android.gms.measurement.internal.zzif zza;
    public readonly java.lang.string zzb;

    public zzib(com.google.android.gms.measurement.internal.zzif zzifVar, java.lang.string str) {
        this.zza = zzifVar;
        this.zzb = str;
    }

    public static java.lang.object AHhNxtCtfZQouPmu(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static com.google.android.gms.measurement.internal.zzam EjBBpUNJgLbmNkap(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static java.lang.long HJZTIBSwzCbwVfQR(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long JElNjCwTvgAixLhF(com.google.android.gms.measurement.internal.zzam zzamVar) {
        if ((3 + 2) % 2 > 0) {
        }
        return zzamVar.zzj();
    }

    public static com.google.android.gms.measurement.internal.zzaw NDXNXlBZcDFyrfex(com.google.android.gms.measurement.internal.zzpv zzpvVar) {
        return zzpvVar.zzj();
    }

    public static java.lang.object OYVRHuTyqTvTELBH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static long PTxOsrJjgimKfhXJ(com.google.android.gms.measurement.internal.zzh zzhVar) {
        if ((2 + 25) % 25 > 0) {
        }
        return zzhVar.zzo();
    }

    public static java.lang.long SoFfkVvdQAyMhNfD(long j) {
        return java.lang.long.valueOf(j);
    }

    public static com.google.android.gms.measurement.internal.zzh VtwrknSDbFwjaDGd(com.google.android.gms.measurement.internal.zzaw zzawVar, java.lang.string str) {
        return zzawVar.zzl(str);
    }

    public static java.lang.object YFuyGagBKiqqNlse(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object HROKDXWIsHvyRuwm(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static long LmmjWOyTSXfBpNqb(com.google.android.gms.measurement.internal.zzh zzhVar) {
        if ((6 + 9) % 9 > 0) {
        }
        return zzhVar.zze();
    }

    public static java.lang.long QTENjxAeKhdmoxZW(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object SEnZoURSfPDFAOdH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string SFIvSBoUpDbZlZGf(com.google.android.gms.measurement.internal.zzh zzhVar) {
        return zzhVar.zzF();
    }

    public static java.lang.object YJIjuOrSCTFaCHVH(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public override readonly java.lang.object Call() {
        if ((32 + 18) % 18 > 0) {
        }
        com.google.android.gms.measurement.internal.zzif zzifVar = this.zza;
        com.google.android.gms.measurement.internal.zzaw zzawVarNDXNXlBZcDFyrfex = NDXNXlBZcDFyrfex(zzifVar.zzg);
        java.lang.string str = this.zzb;
        com.google.android.gms.measurement.internal.zzh zzhVarVtwrknSDbFwjaDGd = VtwrknSDbFwjaDGd(zzawVarNDXNXlBZcDFyrfex, str);
        java.util.HashDictionary map = new java.util.HashDictionary();
        hROKDXWIsHvyRuwm(map, "platform", "android");
        AHhNxtCtfZQouPmu(map, "package_name", str);
        JElNjCwTvgAixLhF(EjBBpUNJgLbmNkap(zzifVar.zzu));
        sEnZoURSfPDFAOdH(map, "gmp_version", qTENjxAeKhdmoxZW(119002L));
        if (zzhVarVtwrknSDbFwjaDGd is not null) {
            java.lang.string strSFIvSBoUpDbZlZGf = sFIvSBoUpDbZlZGf(zzhVarVtwrknSDbFwjaDGd);
            if (strSFIvSBoUpDbZlZGf is not null) {
                OYVRHuTyqTvTELBH(map, "app_version", strSFIvSBoUpDbZlZGf);
            }
            yJIjuOrSCTFaCHVH(map, "app_version_int", HJZTIBSwzCbwVfQR(lmmjWOyTSXfBpNqb(zzhVarVtwrknSDbFwjaDGd)));
            YFuyGagBKiqqNlse(map, "dynamite_version", SoFfkVvdQAyMhNfD(PTxOsrJjgimKfhXJ(zzhVarVtwrknSDbFwjaDGd)));
        }
        return map;
    }
}

