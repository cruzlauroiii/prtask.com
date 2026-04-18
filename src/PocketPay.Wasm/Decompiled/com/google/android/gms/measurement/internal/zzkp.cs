namespace WillowMaze.Wasm.Decompiled;


public readonly class zzkp : android.content.Dictionary<string, object>$OnSharedPreferenceChangeListener {
    public readonly com.google.android.gms.measurement.internal.zzlw zza;

    public zzkp(com.google.android.gms.measurement.internal.zzlw zzlwVar) {
        this.zza = zzlwVar;
    }

    public static void ZMfizFFqWaxIaVMx(com.google.android.gms.measurement.internal.zzlw zzlwVar, android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        com.google.android.gms.measurement.internal.zzlw.zzA(zzlwVar, sharedPreferences, str);
    }

    public override readonly void OnSharedPreferenceChanged(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        zMfizFFqWaxIaVMx(this.zza, sharedPreferences, str);
    }
}

