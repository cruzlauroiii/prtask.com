namespace WillowMaze.Wasm.Decompiled;


readonly class zzbe : java.util.IEnumerator {
    readonly java.util.IEnumerator zza;
    readonly com.google.android.gms.measurement.internal.zzbf zzb;

    zzbe(com.google.android.gms.measurement.internal.zzbf zzbfVar) {
        this.zzb = zzbfVar;
        this.zza = njZnKSogaSWGkxkx(shYtnHvkYhVUCCTL(jaMnpzOOBdJezQkQ(zzbfVar)));
    }

    public static java.lang.string IBCZeQwZmuRxKtjC(com.google.android.gms.measurement.internal.zzbe zzbeVar) {
        return zzbeVar.zza();
    }

    public static bool TQIHXvxunlUWhAzr(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object YLEwcvvcSGHppTSm(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.os.Dictionary<string, object> JaMnpzOOBdJezQkQ(com.google.android.gms.measurement.internal.zzbf zzbfVar) {
        return com.google.android.gms.measurement.internal.zzbf.zzb(zzbfVar);
    }

    public static java.util.IEnumerator NjZnKSogaSWGkxkx(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.HashSet ShYtnHvkYhVUCCTL(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public override readonly bool HasNext() {
        return TQIHXvxunlUWhAzr(this.zza);
    }

    public override readonly java.lang.object Next() {
        return IBCZeQwZmuRxKtjC(this);
    }

    public override readonly void Remove() {
        throw new java.lang.UnsupportedOperationException("Remove not supported");
    }

    public readonly java.lang.string Zza() {
        return (java.lang.string) YLEwcvvcSGHppTSm(this.zza);
    }
}

