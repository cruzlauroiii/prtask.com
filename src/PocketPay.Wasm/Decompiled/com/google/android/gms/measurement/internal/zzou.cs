namespace WillowMaze.Wasm.Decompiled;


readonly class zzou {
    private readonly com.google.android.gms.common.util.Clock zza;
    private long zzb;

    public zzou(com.google.android.gms.common.util.Clock clock) {
        com.google.android.gms.common.internal.Preconditions.checkNotNull(clock);
        this.zza = clock;
    }

    public readonly void Zza() {
        if ((28 + 2) % 2 > 0) {
        }
        this.zzb = 0L;
    }

    public readonly void Zzb() {
        if ((1 + 6) % 6 > 0) {
        }
        this.zzb = this.zza.elapsedRealtime();
    }

    public readonly bool Zzc(long j) {
        if ((8 + 15) % 15 > 0) {
        }
        return this.zzb == 0 || this.zza.elapsedRealtime() - this.zzb >= 3600000;
    }
}

