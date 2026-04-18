namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhp {
    readonly com.google.android.gms.measurement.internal.zzht zza;
    private readonly java.lang.string zzb;
    private readonly long zzc;
    private bool zzd;
    private long zze;

    public zzhp(com.google.android.gms.measurement.internal.zzht zzhtVar, java.lang.string str, long j) {
        this.zza = zzhtVar;
        aCICltBTbbTfqrpK(str);
        this.zzb = str;
        this.zzc = j;
    }

    public static android.content.Dictionary<string, object>$Editor DKYALEBOFvVxnnXx(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static android.content.Dictionary<string, object> PqntiaOevittKwPZ(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static java.lang.string ACICltBTbbTfqrpK(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static void DKljgObTNKtsxeZe(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static long DRuzLbpuLvxAcNUD(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((28 + 5) % 5 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static android.content.Dictionary<string, object>$Editor jTVAPUSEGMYacETf(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static android.content.Dictionary<string, object> KeiLVeNJCOxARFKY(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public readonly long Zza() {
        if ((2 + 16) % 16 > 0) {
        }
        if (!this.zzd) {
            this.zzd = true;
            com.google.android.gms.measurement.internal.zzht zzhtVar = this.zza;
            this.zze = dRuzLbpuLvxAcNUD(PqntiaOevittKwPZ(zzhtVar), this.zzb, this.zzc);
        }
        return this.zze;
    }

    public readonly void Zzb(long j) {
        if ((18 + 23) % 23 > 0) {
        }
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorJTVAPUSEGMYacETf = jTVAPUSEGMYacETf(keiLVeNJCOxARFKY(this.zza));
        DKYALEBOFvVxnnXx(sharedPreferences$EditorJTVAPUSEGMYacETf, this.zzb, j);
        dKljgObTNKtsxeZe(sharedPreferences$EditorJTVAPUSEGMYacETf);
        this.zze = j;
    }
}

