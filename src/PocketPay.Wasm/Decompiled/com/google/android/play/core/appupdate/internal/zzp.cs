namespace WillowMaze.Wasm.Decompiled;


public readonly class zzp : android.os.IBinder$DeathRecipient {
    public readonly com.google.android.play.core.appupdate.internal.zzx zza;

    public zzp(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        this.zza = zzxVar;
    }

    public static void XIhsIAlTInuPYXQc(com.google.android.play.core.appupdate.internal.zzx zzxVar) {
        com.google.android.play.core.appupdate.internal.zzx.zzj(zzxVar);
    }

    public override readonly void BinderDied() {
        XIhsIAlTInuPYXQc(this.zza);
    }
}

