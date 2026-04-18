namespace WillowMaze.Wasm.Decompiled;


readonly class zzps {
    readonly java.lang.string zza;
    long zzb;

    zzps(com.google.android.gms.measurement.internal.zzpv zzpvVar, com.google.android.gms.measurement.internal.zzpu zzpuVar) {
        this(zzpvVar, zzpvVar.zzB().zzF());
    }

    private zzps(com.google.android.gms.measurement.internal.zzpv zzpvVar, java.lang.string str) {
        this.zza = str;
        this.zzb = zzpvVar.zzaU().elapsedRealtime();
    }

    zzps(com.google.android.gms.measurement.internal.zzpv zzpvVar, java.lang.string str, com.google.android.gms.measurement.internal.zzpu zzpuVar) {
        this(zzpvVar, str);
    }
}

