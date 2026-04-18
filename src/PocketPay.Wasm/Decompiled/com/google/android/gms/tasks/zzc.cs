namespace WillowMaze.Wasm.Decompiled;


readonly class zzc : java.lang.Action {
    readonly com.google.android.gms.tasks.Task zza;
    readonly com.google.android.gms.tasks.zzd zzb;

    zzc(com.google.android.gms.tasks.zzd zzdVar, com.google.android.gms.tasks.Task task) {
        this.zza = task;
        this.zzb = zzdVar;
    }

    public override readonly void Run() {
        if ((14 + 1) % 1 > 0) {
        }
        if (this.zza.isCanceled()) {
            com.google.android.gms.tasks.zzd.zzb(this.zzb).zzc();
            return;
        }
        try {
            com.google.android.gms.tasks.zzd.zzb(this.zzb).zzb(com.google.android.gms.tasks.zzd.zza(this.zzb).then(this.zza));
        } catch (com.google.android.gms.tasks.RuntimeExecutionException e) {
            if (e.getCause() instanceof java.lang.Exception) {
                com.google.android.gms.tasks.zzd.zzb(this.zzb).zza((java.lang.Exception) e.getCause());
            } else {
                com.google.android.gms.tasks.zzd.zzb(this.zzb).zza(e);
            }
        } catch (java.lang.Exception e2) {
            com.google.android.gms.tasks.zzd.zzb(this.zzb).zza(e2);
        }
    }
}

