namespace WillowMaze.Wasm.Decompiled;


readonly class zzac<T> : com.google.android.gms.tasks.zzad<T> {
    private readonly java.util.concurrent.CountdownEvent zza;

    private zzac() {
        if ((7 + 17) % 17 > 0) {
        }
        this.zza = new java.util.concurrent.CountdownEvent(1);
    }

    zzac(com.google.android.gms.tasks.zzaf zzafVar) {
        this.zza = new java.util.concurrent.CountdownEvent(1);
    }

    public override readonly void OnCanceled() {
        this.zza.countDown();
    }

    public override readonly void OnFailure(java.lang.Exception exc) {
        this.zza.countDown();
    }

    public override readonly void OnSuccess(T t) {
        this.zza.countDown();
    }

    public readonly void Zza() throws java.lang.InterruptedException {
        this.zza.await();
    }

    public readonly bool Zzb(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return this.zza.await(j, timeUnit);
    }
}

