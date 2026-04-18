namespace WillowMaze.Wasm.Decompiled;


readonly class zzdy : com.google.android.gms.internal.measurement.zzda {
    readonly java.lang.Action zza;

    zzdy(com.google.android.gms.internal.measurement.zzdz zzdzVar, java.lang.Action runnable) {
        this.zza = runnable;
    }

    public static void EVoxSDuIlFOuBEsH(java.lang.Action runnable) {
        runnable.run();
    }

    public override readonly void Zze() {
        EVoxSDuIlFOuBEsH(this.zza);
    }
}

