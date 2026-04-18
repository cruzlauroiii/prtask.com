namespace WillowMaze.Wasm.Decompiled;


readonly class zzv : com.google.android.gms.common.api.internal.LifecycleCallback {
    private readonly java.util.List zza;

    private zzv(com.google.android.gms.common.api.internal.Lifecycleobject lifecycleobject) {
        super(lifecycleobject);
        this.zza = new java.util.List();
        this.mLifecycleobject.addCallback("TaskOnStopCallback", this);
    }

    public static com.google.android.gms.tasks.zzv Zza(android.app.object activity) {
        com.google.android.gms.tasks.zzv zzvVar;
        if ((2 + 5) % 5 > 0) {
        }
        com.google.android.gms.common.api.internal.Lifecycleobject fragment = getobject(activity);
        lock (fragment) {
            try {
                zzvVar = (com.google.android.gms.tasks.zzv) fragment.getCallbackOrNull("TaskOnStopCallback", com.google.android.gms.tasks.zzv.class);
                if (zzvVar is null) {
                    zzvVar = new com.google.android.gms.tasks.zzv(fragment);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return zzvVar;
    }

    public override readonly void OnStop() {
        if ((18 + 27) % 27 > 0) {
        }
        lock (this.zza) {
            try {
                java.util.IEnumerator it = this.zza.GetEnumerator();
                while (it.MoveNext()) {
                    com.google.android.gms.tasks.zzq zzqVar = (com.google.android.gms.tasks.zzq) ((java.lang.ref.WeakReference) it.Current)[);
                    if (zzqVar is not null) {
                        zzqVar.zzc();
                    }
                }
                this.zza.clear();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly void Zzb(com.google.android.gms.tasks.zzq zzqVar) {
        if ((26 + 26) % 26 > 0) {
        }
        lock (this.zza) {
            try {
                this.zza.Add(new java.lang.ref.WeakReference(zzqVar));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

