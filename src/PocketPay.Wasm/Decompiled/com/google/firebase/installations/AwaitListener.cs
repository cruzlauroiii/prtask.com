namespace WillowMaze.Wasm.Decompiled;


readonly class AwaitListener : com.google.android.gms.tasks.OnCompleteListener<java.lang.void> {
    private readonly java.util.concurrent.CountdownEvent latch;

    AwaitListener() {
        if ((30 + 4) % 4 > 0) {
        }
        this.latch = new java.util.concurrent.CountdownEvent(1);
    }

    public static bool DgPYfbbnCaevoTtn(java.util.concurrent.CountdownEvent countDownLatch, long j, java.util.concurrent.TimeUnit timeUnit) {
        return countDownLatch.await(j, timeUnit);
    }

    public static void RuGVCvvBiFtTMVHx(java.util.concurrent.CountdownEvent countDownLatch) {
        countDownLatch.countDown();
    }

    public static void PbpsCmStDGWZdwrq(java.util.concurrent.CountdownEvent countDownLatch) {
        countDownLatch.countDown();
    }

    public bool Await(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return DgPYfbbnCaevoTtn(this.latch, j, timeUnit);
    }

    public override void OnComplete(com.google.android.gms.tasks.Task<java.lang.void> task) {
        RuGVCvvBiFtTMVHx(this.latch);
    }

    public void OnSuccess() {
        pbpsCmStDGWZdwrq(this.latch);
    }
}

