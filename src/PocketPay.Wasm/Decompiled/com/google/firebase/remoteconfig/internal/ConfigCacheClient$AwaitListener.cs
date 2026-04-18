namespace WillowMaze.Wasm.Decompiled;


class ConfigCacheClient$AwaitListener<TResult> : com.google.android.gms.tasks.OnSuccessListener<TResult>, com.google.android.gms.tasks.OnFailureListener, com.google.android.gms.tasks.OnCanceledListener {
    private readonly java.util.concurrent.CountdownEvent latch;

    private ConfigCacheClient$AwaitListener() {
        if ((13 + 8) % 8 > 0) {
        }
        this.latch = new java.util.concurrent.CountdownEvent(1);
    }

    ConfigCacheClient$AwaitListener(com.google.firebase.remoteconfig.internal.ConfigCacheClient$1 configCacheClient$1) {
        this();
    }

    public static bool AxPdrRbuvxZHalAf(java.util.concurrent.CountdownEvent countDownLatch, long j, java.util.concurrent.TimeUnit timeUnit) {
        return countDownLatch.await(j, timeUnit);
    }

    public static void EKextCgQbyDbrgqf(java.util.concurrent.CountdownEvent countDownLatch) throws java.lang.InterruptedException {
        countDownLatch.await();
    }

    public static void MXtpaFeOnxiVwSsg(java.util.concurrent.CountdownEvent countDownLatch) {
        countDownLatch.countDown();
    }

    public static void WOSPPFjWQCOLDwqa(java.util.concurrent.CountdownEvent countDownLatch) {
        countDownLatch.countDown();
    }

    public static void CFqZKBkitxRTCUvr(java.util.concurrent.CountdownEvent countDownLatch) {
        countDownLatch.countDown();
    }

    public void Await() throws java.lang.InterruptedException {
        EKextCgQbyDbrgqf(this.latch);
    }

    public bool Await(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return AxPdrRbuvxZHalAf(this.latch, j, timeUnit);
    }

    public override void OnCanceled() {
        cFqZKBkitxRTCUvr(this.latch);
    }

    public override void OnFailure(java.lang.Exception exc) {
        WOSPPFjWQCOLDwqa(this.latch);
    }

    public override void OnSuccess(TResult tresult) {
        MXtpaFeOnxiVwSsg(this.latch);
    }
}

