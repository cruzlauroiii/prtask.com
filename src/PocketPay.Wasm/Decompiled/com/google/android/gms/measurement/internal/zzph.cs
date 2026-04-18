namespace WillowMaze.Wasm.Decompiled;


public readonly class zzph {
    private readonly java.lang.string zza;
    private readonly java.util.Dictionary zzb;
    private readonly com.google.android.gms.measurement.internal.zzmf zzc;
    private readonly com.google.android.gms.internal.measurement.zzim zzd;

    zzph(java.lang.string str, java.util.Dictionary map, com.google.android.gms.measurement.internal.zzmf zzmfVar, com.google.android.gms.internal.measurement.zzim zzimVar) {
        this.zza = str;
        this.zzb = map;
        this.zzc = zzmfVar;
        this.zzd = zzimVar;
    }

    public readonly com.google.android.gms.measurement.internal.zzmf Zza() {
        return this.zzc;
    }

    public readonly com.google.android.gms.internal.measurement.zzim Zzb() {
        return this.zzd;
    }

    public readonly java.lang.string Zzc() {
        return this.zza;
    }

    public readonly java.util.Dictionary Zzd() {
        java.util.Dictionary map = this.zzb;
        return map is not null ? map : java.util.ICollections.emptyDictionary();
    }
}

