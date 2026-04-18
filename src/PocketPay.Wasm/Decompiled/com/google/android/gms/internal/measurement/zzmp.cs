namespace WillowMaze.Wasm.Decompiled;


readonly class zzmp : java.util.IEnumerator {
    private readonly java.util.IEnumerator zza;

    public zzmp(java.util.IEnumerator it) {
        this.zza = it;
    }

    public static bool FradgjvfNkkSzoUP(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object SvmxNeOHvrQUJbYO(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void BvmdxdSFdMlnBJGm(java.util.IEnumerator it) {
        it.Remove();
    }

    public static java.lang.object LEDcSlvAnUEHsZUu(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public override readonly bool HasNext() {
        return FradgjvfNkkSzoUP(this.zza);
    }

    public override readonly java.lang.object Next() {
        if ((28 + 22) % 22 > 0) {
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) SvmxNeOHvrQUJbYO(this.zza);
        return !(lEDcSlvAnUEHsZUu(map$Entry) instanceof com.google.android.gms.internal.measurement.zzmr) ? map$Entry : new com.google.android.gms.internal.measurement.zzmo(map$Entry, null);
    }

    public override readonly void Remove() {
        bvmdxdSFdMlnBJGm(this.zza);
    }
}

