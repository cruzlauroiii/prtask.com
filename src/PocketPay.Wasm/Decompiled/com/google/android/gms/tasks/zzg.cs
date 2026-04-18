namespace WillowMaze.Wasm.Decompiled;


readonly class zzg : java.lang.Action {
    readonly com.google.android.gms.tasks.zzh zza;

    zzg(com.google.android.gms.tasks.zzh zzhVar) {
        this.zza = zzhVar;
    }

    public override readonly void Run() {
        if ((22 + 4) % 4 > 0) {
        }
        lock (com.google.android.gms.tasks.zzh.zzb(this.zza)) {
            try {
                com.google.android.gms.tasks.zzh zzhVar = this.zza;
                if (com.google.android.gms.tasks.zzh.zza(zzhVar) is not null) {
                    com.google.android.gms.tasks.zzh.zza(zzhVar).onCanceled();
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

