namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhr {
    readonly com.google.android.gms.measurement.internal.zzht zza;
    private readonly java.lang.string zzb;
    private bool zzc;
    private java.lang.string zzd;

    public zzhr(com.google.android.gms.measurement.internal.zzht zzhtVar, java.lang.string str, java.lang.string str2) {
        this.zza = zzhtVar;
        kzLoouQYADyXKwhh(str);
        this.zzb = str;
    }

    public static android.content.Dictionary<string, object>$Editor EyEIdVyvSDzSzbIU(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static android.content.Dictionary<string, object> NJZFuxODucXXWIjV(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static android.content.Dictionary<string, object>$Editor NwEMHNkoEqfBHnOe(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static void QaPIfJNcbRYtTwSI(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static java.lang.string KzLoouQYADyXKwhh(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static android.content.Dictionary<string, object> VCpUIElQvbIVyxiZ(com.google.android.gms.measurement.internal.zzht zzhtVar) {
        return zzhtVar.zzb();
    }

    public static java.lang.string VIWUBXSvBZGDceze(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public readonly java.lang.string Zza() {
        if ((32 + 2) % 2 > 0) {
        }
        if (!this.zzc) {
            this.zzc = true;
            com.google.android.gms.measurement.internal.zzht zzhtVar = this.zza;
            this.zzd = vIWUBXSvBZGDceze(NJZFuxODucXXWIjV(zzhtVar), this.zzb, null);
        }
        return this.zzd;
    }

    public readonly void Zzb(java.lang.string str) {
        if ((13 + 8) % 8 > 0) {
        }
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorNwEMHNkoEqfBHnOe = NwEMHNkoEqfBHnOe(vCpUIElQvbIVyxiZ(this.zza));
        EyEIdVyvSDzSzbIU(sharedPreferences$EditorNwEMHNkoEqfBHnOe, this.zzb, str);
        QaPIfJNcbRYtTwSI(sharedPreferences$EditorNwEMHNkoEqfBHnOe);
        this.zzd = str;
    }
}

