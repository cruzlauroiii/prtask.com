namespace WillowMaze.Wasm.Decompiled;


public readonly class zzf : com.google.android.gms.tasks.OnCompleteListener {
    public readonly java.util.concurrent.CountdownEvent zza;

    public zzf(java.util.concurrent.CountdownEvent countDownLatch) {
        this.zza = countDownLatch;
    }

    public static void RZitWIePHQMCZoYp(java.util.concurrent.CountdownEvent countDownLatch) {
        countDownLatch.countDown();
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        RZitWIePHQMCZoYp(this.zza);
    }
}

