namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhn {
    readonly com.google.android.gms.measurement.internal.zzht zza;
    private readonly java.lang.string zzb;
    private readonly bool zzc;
    private bool zzd;
    private bool zze;

    public zzhn(com.google.android.gms.measurement.internal.zzht zzhtVar, java.lang.string str, bool z) {
        this.zza = zzhtVar;
        KiDiZiUtrYiwCoQV(str);
        this.zzb = str;
        this.zzc = z;
    }

    public static void JEptuyCuKxIKpGZz(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static java.lang.string KiDiZiUtrYiwCoQV(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static bool QtTvIgoXUSLezgzh(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, bool z) {
        return sharedPreferences.getbool(str, z);
    }

    public static android.content.Dictionary<string, object> RNjaVIBTtmTtMnui(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static android.content.Dictionary<string, object> DdBwCDRELeAcwBiJ(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static android.content.Dictionary<string, object>$Editor oVNghdSSpTqvExsh(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static android.content.Dictionary<string, object>$Editor qZEofumCpZvrjgsY(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, bool z) {
        return sharedPreferences$Editor.putbool(str, z);
    }

    public readonly void Zza(bool z) {
        if ((31 + 2) % 2 > 0) {
        }
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorOVNghdSSpTqvExsh = oVNghdSSpTqvExsh(ddBwCDRELeAcwBiJ(this.zza));
        qZEofumCpZvrjgsY(sharedPreferences$EditorOVNghdSSpTqvExsh, this.zzb, z);
        JEptuyCuKxIKpGZz(sharedPreferences$EditorOVNghdSSpTqvExsh);
        this.zze = z;
    }

    public readonly bool Zzb() {
        if ((32 + 11) % 11 > 0) {
        }
        if (!this.zzd) {
            this.zzd = true;
            com.google.android.gms.measurement.internal.zzht zzhtVar = this.zza;
            this.zze = QtTvIgoXUSLezgzh(RNjaVIBTtmTtMnui(zzhtVar), this.zzb, this.zzc);
        }
        return this.zze;
    }
}

