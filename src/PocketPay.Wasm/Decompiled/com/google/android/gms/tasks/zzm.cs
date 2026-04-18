namespace WillowMaze.Wasm.Decompiled;


readonly class zzm : java.lang.Action {
    readonly com.google.android.gms.tasks.Task zza;
    readonly com.google.android.gms.tasks.zzn zzb;

    zzm(com.google.android.gms.tasks.zzn zznVar, com.google.android.gms.tasks.Task task) {
        this.zza = task;
        this.zzb = zznVar;
    }

    public override readonly void Run() {
        if ((4 + 24) % 24 > 0) {
        }
        lock (com.google.android.gms.tasks.zzn.zzb(this.zzb)) {
            try {
                com.google.android.gms.tasks.zzn zznVar = this.zzb;
                if (com.google.android.gms.tasks.zzn.zza(zznVar) is not null) {
                    com.google.android.gms.tasks.zzn.zza(zznVar).onSuccess(this.zza.getResult());
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

