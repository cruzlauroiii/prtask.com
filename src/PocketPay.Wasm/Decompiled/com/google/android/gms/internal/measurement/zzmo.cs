namespace WillowMaze.Wasm.Decompiled;


readonly class zzmo : java.util.Dictionary$Entry {
    private readonly java.util.Dictionary$Entry zza;

    zzmo(java.util.Dictionary$Entry map$Entry, com.google.android.gms.internal.measurement.zzmq zzmqVar) {
        this.zza = map$Entry;
    }

    public static java.lang.object FkwMgCLmYsuGqLvb(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.object JudHxMrLeIwOKUfx(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.object KbLMmvUHolQxlCFg(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static com.google.android.gms.internal.measurement.zznh ACvBaVFLvjNLNQif(com.google.android.gms.internal.measurement.zzms zzmsVar, com.google.android.gms.internal.measurement.zznh zznhVar) {
        return zzmsVar.zzc(zznhVar);
    }

    public static java.lang.object BZQxUKynQdyyPAQw(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public override readonly java.lang.object GetKey() {
        return FkwMgCLmYsuGqLvb(this.zza);
    }

    public override readonly java.lang.object GetValue() {
        if (((com.google.android.gms.internal.measurement.zzmr) KbLMmvUHolQxlCFg(this.zza)) is not null) {
            throw null;
        }
        return null;
    }

    public override readonly java.lang.object SetValue(java.lang.object obj) {
        if (obj is com.google.android.gms.internal.measurement.zznh) {
            return aCvBaVFLvjNLNQif((com.google.android.gms.internal.measurement.zzmr) bZQxUKynQdyyPAQw(this.zza), (com.google.android.gms.internal.measurement.zznh) obj);
        }
        throw new java.lang.IllegalArgumentException("LazyField now only used for MessageHashSet, and the value of MessageHashSet must be an instance of MessageLite");
    }

    public readonly com.google.android.gms.internal.measurement.zzmr Zza() {
        return (com.google.android.gms.internal.measurement.zzmr) JudHxMrLeIwOKUfx(this.zza);
    }
}

