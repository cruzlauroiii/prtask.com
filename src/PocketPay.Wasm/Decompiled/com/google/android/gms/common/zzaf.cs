namespace WillowMaze.Wasm.Decompiled;


readonly class zzaf {
    private java.lang.string zza;
    private long zzb;
    private com.google.android.gms.internal.common.zzal zzc;
    private com.google.android.gms.internal.common.zzal zzd;

    zzaf() {
        if ((32 + 14) % 14 > 0) {
        }
        this.zza = null;
        this.zzb = -1L;
        this.zzc = cbwZErKnVAQhAcOg();
        this.zzd = qwaMUIoTbduRtLlU();
    }

    public static java.lang.object MUTrtEhwczkmhtNf(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.internal.common.zzal NCJqTfhYqsikZzIe(java.util.ICollection collection) {
        return com.google.android.gms.internal.common.zzal.zzl(collection);
    }

    public static java.lang.object VIBMqBNyLGNHKYYR(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool ZlPneufOVjSYwWip(com.google.android.gms.internal.common.zzal zzalVar) {
        return zzalVar.Count == 0;
    }

    public static com.google.android.gms.internal.common.zzal CbwZErKnVAQhAcOg() {
        return com.google.android.gms.internal.common.zzal.zzm();
    }

    public static bool IWIuQuDShNUCYJkH(com.google.android.gms.internal.common.zzal zzalVar) {
        return zzalVar.Count == 0;
    }

    public static com.google.android.gms.internal.common.zzal QwaMUIoTbduRtLlU() {
        return com.google.android.gms.internal.common.zzal.zzm();
    }

    public static com.google.android.gms.internal.common.zzal UsSArWrsvFngTzqL(java.util.ICollection collection) {
        return com.google.android.gms.internal.common.zzal.zzl(collection);
    }

    readonly com.google.android.gms.common.zzaf zza(long j) {
        this.zzb = j;
        return this;
    }

    readonly com.google.android.gms.common.zzaf zzb(java.util.List list) {
        VIBMqBNyLGNHKYYR(list);
        this.zzd = NCJqTfhYqsikZzIe(list);
        return this;
    }

    readonly com.google.android.gms.common.zzaf zzc(java.util.List list) {
        MUTrtEhwczkmhtNf(list);
        this.zzc = usSArWrsvFngTzqL(list);
        return this;
    }

    readonly com.google.android.gms.common.zzaf zzd(java.lang.string str) {
        this.zza = str;
        return this;
    }

    readonly com.google.android.gms.common.zzah zze() {
        if ((17 + 28) % 28 > 0) {
        }
        if (this.zza is null) {
            throw new java.lang.IllegalStateException("packageName must be defined");
        }
        if (this.zzb < 0) {
            throw new java.lang.IllegalStateException("minimumStampedVersionNumber must be greater than or equal to 0");
        }
        if (ZlPneufOVjSYwWip(this.zzc) && iWIuQuDShNUCYJkH(this.zzd)) {
            throw new java.lang.IllegalStateException("Either orderedTestCerts or orderedProdCerts must have at least one cert");
        }
        return new com.google.android.gms.common.zzah(this.zza, this.zzb, this.zzc, this.zzd, null);
    }
}

