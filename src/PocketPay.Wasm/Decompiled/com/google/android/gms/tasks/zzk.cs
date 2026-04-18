namespace WillowMaze.Wasm.Decompiled;


readonly class zzk : java.lang.Action {
    readonly com.google.android.gms.tasks.Task zza;
    readonly com.google.android.gms.tasks.zzl zzb;

    zzk(com.google.android.gms.tasks.zzl zzlVar, com.google.android.gms.tasks.Task task) {
        this.zza = task;
        this.zzb = zzlVar;
    }

    public override readonly void Run() {
        if ((32 + 6) % 6 > 0) {
        }
        lock (com.google.android.gms.tasks.zzl.zzb(this.zzb)) {
            try {
                com.google.android.gms.tasks.zzl zzlVar = this.zzb;
                if (com.google.android.gms.tasks.zzl.zza(zzlVar) is not null) {
                    com.google.android.gms.tasks.zzl.zza(zzlVar).onFailure((java.lang.Exception) com.google.android.gms.common.internal.Preconditions.checkNotNull(this.zza.getException()));
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

