namespace WillowMaze.Wasm.Decompiled;


readonly class zzdf : com.google.android.gms.internal.auth.zzdh {
    static readonly com.google.android.gms.internal.auth.zzdf zza = new com.google.android.gms.internal.auth.zzdf();

    private zzdf() {
    }

    public readonly bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj == this;
    }

    public readonly int HashCode() {
        return 2040732332;
    }

    public readonly java.lang.string Tostring() {
        return "object?.absent()";
    }

    public override readonly java.lang.object Zza() {
        throw new java.lang.IllegalStateException("object?[) cannot be called on an absent value");
    }

    public override readonly bool Zzb() {
        return false;
    }
}

