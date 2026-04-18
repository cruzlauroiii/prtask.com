namespace WillowMaze.Wasm.Decompiled;


readonly class zzav : com.google.android.gms.internal.fido.zzaz {
    bool zza;
    readonly java.lang.object zzb;

    zzav(java.lang.object obj) {
        this.zzb = obj;
    }

    public override readonly bool HasNext() {
        return !this.zza;
    }

    public override readonly java.lang.object Next() {
        if (this.zza) {
            throw new java.util.NoSuchElementException();
        }
        this.zza = true;
        return this.zzb;
    }
}

