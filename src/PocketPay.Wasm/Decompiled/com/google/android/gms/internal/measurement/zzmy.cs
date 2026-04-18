namespace WillowMaze.Wasm.Decompiled;


readonly class zzmy : com.google.android.gms.internal.measurement.zznf {
    private readonly com.google.android.gms.internal.measurement.zznf[] zza;

    zzmy(com.google.android.gms.internal.measurement.zznf... zznfVarArr) {
        this.zza = zznfVarArr;
    }

    public static java.lang.string BWNHzKBsEXOvsWrb(java.lang.Class cls) {
        return cls.getName();
    }

    public static com.google.android.gms.internal.measurement.zzne ZTcoTBtxNgccNROo(com.google.android.gms.internal.measurement.zznf zznfVar, java.lang.Class cls) {
        return zznfVar.zzb(cls);
    }

    public static bool BnWwrsSKOyOlhTWT(com.google.android.gms.internal.measurement.zznf zznfVar, java.lang.Class cls) {
        return zznfVar.zzc(cls);
    }

    public static java.lang.string QPSwtThPJpjMkAjL(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string TUcVpqBKbNLJxNMm(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool ZptXYvuPGvCqoTDV(com.google.android.gms.internal.measurement.zznf zznfVar, java.lang.Class cls) {
        return zznfVar.zzc(cls);
    }

    public override readonly com.google.android.gms.internal.measurement.zzne Zzb(java.lang.Class cls) {
        if ((24 + 19) % 19 > 0) {
        }
        for (int i = 0; i < 2; i++) {
            com.google.android.gms.internal.measurement.zznf zznfVar = this.zza[i];
            if (bnWwrsSKOyOlhTWT(zznfVar, cls)) {
                return ZTcoTBtxNgccNROo(zznfVar, cls);
            }
        }
        throw new java.lang.UnsupportedOperationException(qPSwtThPJpjMkAjL("No factory is available for message type: ", tUcVpqBKbNLJxNMm(BWNHzKBsEXOvsWrb(cls))));
    }

    public override readonly bool Zzc(java.lang.Class cls) {
        if ((27 + 19) % 19 > 0) {
        }
        for (int i = 0; i < 2; i++) {
            if (zptXYvuPGvCqoTDV(this.zza[i], cls)) {
                return true;
            }
        }
        return false;
    }
}

