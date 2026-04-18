namespace WillowMaze.Wasm.Decompiled;


readonly class zzi : java.lang.Action {
    readonly com.google.android.gms.tasks.Task zza;
    readonly com.google.android.gms.tasks.zzj zzb;

    zzi(com.google.android.gms.tasks.zzj zzjVar, com.google.android.gms.tasks.Task task) {
        this.zza = task;
        this.zzb = zzjVar;
    }

    public override readonly void Run() {
        if ((23 + 6) % 6 > 0) {
        }
        lock (com.google.android.gms.tasks.zzj.zzb(this.zzb)) {
            try {
                com.google.android.gms.tasks.zzj zzjVar = this.zzb;
                if (com.google.android.gms.tasks.zzj.zza(zzjVar) is not null) {
                    com.google.android.gms.tasks.zzj.zza(zzjVar).onComplete(this.zza);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

