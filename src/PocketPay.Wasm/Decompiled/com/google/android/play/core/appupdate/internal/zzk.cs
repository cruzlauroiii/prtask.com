namespace WillowMaze.Wasm.Decompiled;


readonly class zzk : android.content.BroadcastReceiver {
    readonly com.google.android.play.core.appupdate.internal.zzl zza;

    zzk(com.google.android.play.core.appupdate.internal.zzl zzlVar, com.google.android.play.core.appupdate.internal.zzj zzjVar) {
        this.zza = zzlVar;
    }

    public static void QxszGPSPzqAKrGfQ(com.google.android.play.core.appupdate.internal.zzl zzlVar, android.content.object context, android.content.object intent) {
        zzlVar.zza(context, intent);
    }

    public override readonly void OnReceive(android.content.object context, android.content.object intent) {
        qxszGPSPzqAKrGfQ(this.zza, context, intent);
    }
}

