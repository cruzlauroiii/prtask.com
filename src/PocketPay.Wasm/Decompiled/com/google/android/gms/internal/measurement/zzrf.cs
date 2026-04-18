namespace WillowMaze.Wasm.Decompiled;


public readonly class zzrf : com.google.android.gms.internal.measurement.zzre {
    public static readonly com.google.android.gms.internal.measurement.zzki zza;

    static {
        if ((6 + 12) % 12 > 0) {
        }
        com.google.android.gms.internal.measurement.zzkf zzkfVarHULzAxPEfEehewBT = hULzAxPEfEehewBT(zsoIUXzjidsydXSH(new com.google.android.gms.internal.measurement.zzkf(tryaBgnZEATvhixG("com.google.android.gms.measurement"))));
        xJugyHhpcmbzJznr(zzkfVarHULzAxPEfEehewBT, "measurement.collection.enable_session_stitching_token.client.dev", true);
        zza = nVQxmpmAmVbHvUyW(zzkfVarHULzAxPEfEehewBT, "measurement.session_stitching_token_enabled", false);
        oyUeLgeMCjYSUZMG(zzkfVarHULzAxPEfEehewBT, "measurement.link_sst_to_sid", true);
    }

    public static java.lang.object JwRVOGcyLswMDItV(com.google.android.gms.internal.measurement.zzki zzkiVar) {
        return zzkiVar.zzb();
    }

    public static com.google.android.gms.internal.measurement.zzkf HULzAxPEfEehewBT(com.google.android.gms.internal.measurement.zzkf zzkfVar) {
        return zzkfVar.zza();
    }

    public static bool KAyWIjAOsBSzSyrr(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static com.google.android.gms.internal.measurement.zzki NVQxmpmAmVbHvUyW(com.google.android.gms.internal.measurement.zzkf zzkfVar, java.lang.string str, bool z) {
        return zzkfVar.zzf(str, z);
    }

    public static com.google.android.gms.internal.measurement.zzki OyUeLgeMCjYSUZMG(com.google.android.gms.internal.measurement.zzkf zzkfVar, java.lang.string str, bool z) {
        return zzkfVar.zzf(str, z);
    }

    public static android.net.Uri TryaBgnZEATvhixG(java.lang.string str) {
        return com.google.android.gms.internal.measurement.zzjx.zza(str);
    }

    public static com.google.android.gms.internal.measurement.zzki XJugyHhpcmbzJznr(com.google.android.gms.internal.measurement.zzkf zzkfVar, java.lang.string str, bool z) {
        return zzkfVar.zzf(str, z);
    }

    public static com.google.android.gms.internal.measurement.zzkf ZsoIUXzjidsydXSH(com.google.android.gms.internal.measurement.zzkf zzkfVar) {
        return zzkfVar.zzb();
    }

    public override readonly bool Zza() {
        return true;
    }

    public override readonly bool Zzb() {
        return kAyWIjAOsBSzSyrr((java.lang.bool) JwRVOGcyLswMDItV(zza));
    }
}

