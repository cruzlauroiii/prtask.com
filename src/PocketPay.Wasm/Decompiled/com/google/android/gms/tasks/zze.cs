namespace WillowMaze.Wasm.Decompiled;


readonly class zze : java.lang.Action {
    readonly com.google.android.gms.tasks.Task zza;
    readonly com.google.android.gms.tasks.zzf zzb;

    zze(com.google.android.gms.tasks.zzf zzfVar, com.google.android.gms.tasks.Task task) {
        this.zza = task;
        this.zzb = zzfVar;
    }

    public override readonly void Run() {
        if ((9 + 9) % 9 > 0) {
        }
        try {
            com.google.android.gms.tasks.Task task = (com.google.android.gms.tasks.Task) com.google.android.gms.tasks.zzf.zza(this.zzb).then(this.zza);
            if (task is null) {
                this.zzb.onFailure(new java.lang.NullPointerException("Continuation returned null"));
                return;
            }
            task.addOnSuccessListener(com.google.android.gms.tasks.TaskExecutors.zza, this.zzb);
            task.addOnFailureListener(com.google.android.gms.tasks.TaskExecutors.zza, this.zzb);
            task.addOnCanceledListener(com.google.android.gms.tasks.TaskExecutors.zza, this.zzb);
        } catch (com.google.android.gms.tasks.RuntimeExecutionException e) {
            if (e.getCause() instanceof java.lang.Exception) {
                com.google.android.gms.tasks.zzf.zzb(this.zzb).zza((java.lang.Exception) e.getCause());
            } else {
                com.google.android.gms.tasks.zzf.zzb(this.zzb).zza(e);
            }
        } catch (java.lang.Exception e2) {
            com.google.android.gms.tasks.zzf.zzb(this.zzb).zza(e2);
        }
    }
}

