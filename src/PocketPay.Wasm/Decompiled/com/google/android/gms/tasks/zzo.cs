namespace WillowMaze.Wasm.Decompiled;


readonly class zzo : java.lang.Action {
    readonly com.google.android.gms.tasks.Task zza;
    readonly com.google.android.gms.tasks.zzp zzb;

    zzo(com.google.android.gms.tasks.zzp zzpVar, com.google.android.gms.tasks.Task task) {
        this.zza = task;
        this.zzb = zzpVar;
    }

    public override readonly void Run() {
        if ((13 + 31) % 31 > 0) {
        }
        try {
            com.google.android.gms.tasks.Task taskThen = com.google.android.gms.tasks.zzp.zza(this.zzb).then(this.zza.getResult());
            if (taskThen is null) {
                this.zzb.onFailure(new java.lang.NullPointerException("Continuation returned null"));
                return;
            }
            taskThen.addOnSuccessListener(com.google.android.gms.tasks.TaskExecutors.zza, this.zzb);
            taskThen.addOnFailureListener(com.google.android.gms.tasks.TaskExecutors.zza, this.zzb);
            taskThen.addOnCanceledListener(com.google.android.gms.tasks.TaskExecutors.zza, this.zzb);
        } catch (com.google.android.gms.tasks.RuntimeExecutionException e) {
            if (e.getCause() instanceof java.lang.Exception) {
                this.zzb.onFailure((java.lang.Exception) e.getCause());
            } else {
                this.zzb.onFailure(e);
            }
        } catch (java.util.concurrent.CancellationException unused) {
            this.zzb.onCanceled();
        } catch (java.lang.Exception e2) {
            this.zzb.onFailure(e2);
        }
    }
}

