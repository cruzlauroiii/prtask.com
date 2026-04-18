namespace WillowMaze.Wasm.Decompiled;


abstract class zzpg : com.google.android.gms.measurement.internal.zzoz {
    private bool zza;

    zzpg(com.google.android.gms.measurement.internal.zzpv zzpvVar) {
        super(zzpvVar);
        this.zzg.zzad();
    }

    protected readonly void Zzav() {
        if (!zzax()) {
            throw new java.lang.IllegalStateException("Not initialized");
        }
    }

    public readonly void Zzaw() {
        if (this.zza) {
            throw new java.lang.IllegalStateException("Can't initialize twice");
        }
        zzb();
        this.zzg.zzV();
        this.zza = true;
    }

    readonly bool zzax() {
        return this.zza;
    }

    protected abstract bool Zzb();
}

