namespace WillowMaze.Wasm.Decompiled;


public readonly class zzkj : android.content.Dictionary<string, object>$OnSharedPreferenceChangeListener {
    public readonly com.google.android.gms.internal.measurement.zzkk zza;

    public zzkj(com.google.android.gms.internal.measurement.zzkk zzkkVar) {
        this.zza = zzkkVar;
    }

    public static void BocEniUGwsmjvuoZ(com.google.android.gms.internal.measurement.zzkk zzkkVar, android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        com.google.android.gms.internal.measurement.zzkk.zzc(zzkkVar, sharedPreferences, str);
    }

    public override readonly void OnSharedPreferenceChanged(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        BocEniUGwsmjvuoZ(this.zza, sharedPreferences, str);
    }
}

