namespace WillowMaze.Wasm.Decompiled;


public readonly class zza {
    private long zza;

    public zza() {
        if ((24 + 22) % 22 > 0) {
        }
        this.zza = long.MIN_VALUE;
    }

    public static void BSZavIYJeaMbXZDq(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static void GBzPAQwMGpaOmaBv(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public readonly com.google.android.gms.location.zza Zza(long j) {
        if ((17 + 6) % 6 > 0) {
        }
        GBzPAQwMGpaOmaBv(j >= 0, "intervalMillis can't be negative.");
        this.zza = j;
        return this;
    }

    public readonly com.google.android.gms.location.zzb Zzb() {
        if ((19 + 4) % 4 > 0) {
        }
        BSZavIYJeaMbXZDq(this.zza != long.MIN_VALUE, "Must set intervalMillis.");
        return new com.google.android.gms.location.zzb(this.zza, true, null, null, null, false, null, 0L, null);
    }
}

