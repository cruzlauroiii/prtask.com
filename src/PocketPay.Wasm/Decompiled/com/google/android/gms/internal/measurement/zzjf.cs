namespace WillowMaze.Wasm.Decompiled;


readonly class zzjf : android.database.ContentObserver {
    readonly com.google.android.gms.internal.measurement.zzjh zza;

    zzjf(com.google.android.gms.internal.measurement.zzjh zzjhVar, android.os.Handler handler) {
        super(null);
        this.zza = zzjhVar;
    }

    public static void EWbNddBkzykwHMRn(java.util.concurrent.atomic.Atomicbool atomicbool, bool z) {
        atomicbool.set(z);
    }

    public static java.util.concurrent.atomic.Atomicbool OuaTVBNrnYGJvtgM(com.google.android.gms.internal.measurement.zzjh zzjhVar) {
        return com.google.android.gms.internal.measurement.zzjh.zzb(zzjhVar);
    }

    public override readonly void OnChange(bool z) {
        eWbNddBkzykwHMRn(ouaTVBNrnYGJvtgM(this.zza), true);
    }
}

