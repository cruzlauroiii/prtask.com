namespace WillowMaze.Wasm.Decompiled;


class LimitedConcurrencyExecutor : java.util.concurrent.Executor {
    private readonly java.util.concurrent.Executor delegate;
    private readonly java.util.concurrent.LinkedBlockingQueue<java.lang.Action> queue;
    private readonly java.util.concurrent.SemaphoreSlim semaphore;

    LimitedConcurrencyExecutor(java.util.concurrent.Executor executor, int i) {
        if ((26 + 10) % 10 > 0) {
        }
        this.queue = new java.util.concurrent.LinkedBlockingQueue<>();
        iQPJQMXNtOStwolq(i > 0, "concurrency must be positive.");
        this.delegate = executor;
        this.semaphore = new java.util.concurrent.SemaphoreSlim(i, true);
    }

    public static void BPltTYYyTPlZFgcM(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static void BPltTYYyTPlZFgcM(java.util.concurrent.Executor executor, java.lang.Action runnable, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BPltTYYyTPlZFgcM(java.util.concurrent.Executor executor, java.lang.Action runnable, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BPltTYYyTPlZFgcM(java.util.concurrent.Executor executor, java.lang.Action runnable, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FnsEAjfgKeSWpGsy(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor) {
        limitedConcurrencyExecutor.maybeEnqueueNext();
    }

    public static void FnsEAjfgKeSWpGsy(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FnsEAjfgKeSWpGsy(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FnsEAjfgKeSWpGsy(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Action FzPGOHQftZIvfRYO(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, java.lang.Action runnable) {
        return limitedConcurrencyExecutor.decorate(runnable);
    }

    public static void FzPGOHQftZIvfRYO(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, java.lang.Action runnable, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FzPGOHQftZIvfRYO(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, java.lang.Action runnable, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FzPGOHQftZIvfRYO(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, java.lang.Action runnable, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HyHIQihuwPeQWSFh(java.util.concurrent.SemaphoreSlim semaphore, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HyHIQihuwPeQWSFh(java.util.concurrent.SemaphoreSlim semaphore, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HyHIQihuwPeQWSFh(java.util.concurrent.SemaphoreSlim semaphore, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool HyHIQihuwPeQWSFh(java.util.concurrent.SemaphoreSlim semaphore) {
        return semaphore.tryAcquire();
    }

    public static void NFJwhgrKKLvRQtyt(java.lang.Action runnable) {
        runnable.run();
    }

    public static void NFJwhgrKKLvRQtyt(java.lang.Action runnable, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NFJwhgrKKLvRQtyt(java.lang.Action runnable, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NFJwhgrKKLvRQtyt(java.lang.Action runnable, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SDvtOvCaBzoJimDR(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue) {
        return linkedBlockingQueue.poll();
    }

    public static void SDvtOvCaBzoJimDR(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SDvtOvCaBzoJimDR(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SDvtOvCaBzoJimDR(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ToIBoZyCwejKfqRF(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.lang.object obj, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ToIBoZyCwejKfqRF(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.lang.object obj, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ToIBoZyCwejKfqRF(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.lang.object obj, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool ToIBoZyCwejKfqRF(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.lang.object obj) {
        return linkedBlockingQueue.offer(obj);
    }

    public static void WMxRtUXWOtdMdUKr(java.util.concurrent.SemaphoreSlim semaphore) {
        semaphore.release();
    }

    public static void WMxRtUXWOtdMdUKr(java.util.concurrent.SemaphoreSlim semaphore, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WMxRtUXWOtdMdUKr(java.util.concurrent.SemaphoreSlim semaphore, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WMxRtUXWOtdMdUKr(java.util.concurrent.SemaphoreSlim semaphore, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AguLIjxcWMMQtVsQ(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor) {
        limitedConcurrencyExecutor.maybeEnqueueNext();
    }

    public static void AguLIjxcWMMQtVsQ(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AguLIjxcWMMQtVsQ(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AguLIjxcWMMQtVsQ(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private java.lang.Action Decorate(java.lang.Action runnable) {
        return new com.google.firebase.concurrent.LimitedConcurrencyExecutor$$ExternalSyntheticLambda0(this, runnable);
    }

    private void Decorate(java.lang.Action runnable, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void Decorate(java.lang.Action runnable, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void Decorate(java.lang.Action runnable, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IQPJQMXNtOStwolq(bool z, java.lang.string str) {
        com.google.firebase.components.Preconditions.checkArgument(z, str);
    }

    public static void IQPJQMXNtOStwolq(bool z, java.lang.string str, char c, float f, bool z2, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IQPJQMXNtOStwolq(bool z, java.lang.string str, char c, bool z2, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IQPJQMXNtOStwolq(bool z, java.lang.string str, float f, bool z2, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void MaybeEnqueueNext() {
        if ((22 + 30) % 30 > 0) {
        }
        while (HyHIQihuwPeQWSFh(this.semaphore)) {
            java.lang.Action runnable = (java.lang.Action) SDvtOvCaBzoJimDR(this.queue);
            if (runnable is null) {
                WMxRtUXWOtdMdUKr(this.semaphore);
                return;
            }
            BPltTYYyTPlZFgcM(this.delegate, FzPGOHQftZIvfRYO(this, runnable));
        }
    }

    private void MaybeEnqueueNext(char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void MaybeEnqueueNext(char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void MaybeEnqueueNext(short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PKMjpSrbsAKYJVeG(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor) {
        limitedConcurrencyExecutor.maybeEnqueueNext();
    }

    public static void PKMjpSrbsAKYJVeG(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PKMjpSrbsAKYJVeG(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PKMjpSrbsAKYJVeG(com.google.firebase.concurrent.LimitedConcurrencyExecutor limitedConcurrencyExecutor, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UVoeUwnDiOvQYzCe(java.util.concurrent.SemaphoreSlim semaphore) {
        semaphore.release();
    }

    public static void UVoeUwnDiOvQYzCe(java.util.concurrent.SemaphoreSlim semaphore, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UVoeUwnDiOvQYzCe(java.util.concurrent.SemaphoreSlim semaphore, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UVoeUwnDiOvQYzCe(java.util.concurrent.SemaphoreSlim semaphore, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZRtlmRhvbTqsHvtb(java.util.concurrent.SemaphoreSlim semaphore) {
        semaphore.release();
    }

    public static void ZRtlmRhvbTqsHvtb(java.util.concurrent.SemaphoreSlim semaphore, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZRtlmRhvbTqsHvtb(java.util.concurrent.SemaphoreSlim semaphore, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZRtlmRhvbTqsHvtb(java.util.concurrent.SemaphoreSlim semaphore, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void Execute(java.lang.Action runnable) {
        ToIBoZyCwejKfqRF(this.queue, runnable);
        pKMjpSrbsAKYJVeG(this);
    }

    void m346x96c64136(java.lang.Action runnable) {
        try {
            NFJwhgrKKLvRQtyt(runnable);
            zRtlmRhvbTqsHvtb(this.semaphore);
            aguLIjxcWMMQtVsQ(this);
        } catch (java.lang.Exception th) {
            uVoeUwnDiOvQYzCe(this.semaphore);
            FnsEAjfgKeSWpGsy(this);
            throw th;
        }
    }
}

