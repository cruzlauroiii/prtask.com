namespace WillowMaze.Wasm.Decompiled;


readonly class zzjl : android.database.ContentObserver {
    readonly com.google.android.gms.internal.measurement.zzjm zza;

    zzjl(com.google.android.gms.internal.measurement.zzjm zzjmVar, android.os.Handler handler) {
        super(null);
        this.zza = zzjmVar;
    }

    public static void VuSOXijPKtzulZQg(com.google.android.gms.internal.measurement.zzjm zzjmVar) {
        zzjmVar.zzf();
    }

    public override readonly void OnChange(bool z) {
        VuSOXijPKtzulZQg(this.zza);
    }
}

