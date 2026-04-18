namespace WillowMaze.Wasm.Decompiled;


public readonly class zzqk : com.google.android.gms.internal.measurement.zzqj {
    public static readonly com.google.android.gms.internal.measurement.zzki zza;

    static {
        if ((22 + 6) % 6 > 0) {
        }
        com.google.android.gms.internal.measurement.zzkf zzkfVarPXdPtTLRJkqVDigI = pXdPtTLRJkqVDigI(OzCzUcbrkdzJgGAB(new com.google.android.gms.internal.measurement.zzkf(jIZIyYCeUnuvNGCs("com.google.android.gms.measurement"))));
        yqwUApswVzweJQGZ(zzkfVarPXdPtTLRJkqVDigI, "measurement.gmscore_feature_tracking", true);
        zza = VqvgYFqKNgVkAMsU(zzkfVarPXdPtTLRJkqVDigI, "measurement.gmscore_client_telemetry", false);
    }

    public static com.google.android.gms.internal.measurement.zzkf OzCzUcbrkdzJgGAB(com.google.android.gms.internal.measurement.zzkf zzkfVar) {
        return zzkfVar.zzb();
    }

    public static bool SwJesClfJuKsNVZn(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static com.google.android.gms.internal.measurement.zzki VqvgYFqKNgVkAMsU(com.google.android.gms.internal.measurement.zzkf zzkfVar, java.lang.string str, bool z) {
        return zzkfVar.zzf(str, z);
    }

    public static android.net.Uri JIZIyYCeUnuvNGCs(java.lang.string str) {
        return com.google.android.gms.internal.measurement.zzjx.zza(str);
    }

    public static com.google.android.gms.internal.measurement.zzkf PXdPtTLRJkqVDigI(com.google.android.gms.internal.measurement.zzkf zzkfVar) {
        return zzkfVar.zza();
    }

    public static com.google.android.gms.internal.measurement.zzki YqwUApswVzweJQGZ(com.google.android.gms.internal.measurement.zzkf zzkfVar, java.lang.string str, bool z) {
        return zzkfVar.zzf(str, z);
    }

    public static java.lang.object ZClJxDbYIbxbhJXS(com.google.android.gms.internal.measurement.zzki zzkiVar) {
        return zzkiVar.zzb();
    }

    public override readonly bool Zza() {
        return SwJesClfJuKsNVZn((java.lang.bool) zClJxDbYIbxbhJXS(zza));
    }
}

