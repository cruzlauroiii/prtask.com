namespace WillowMaze.Wasm.Decompiled;


readonly class PausableExecutorImpl : com.google.firebase.concurrent.PausableExecutor {
    private readonly java.util.concurrent.Executor delegate;
    private bool paused;
    readonly java.util.concurrent.LinkedBlockingQueue<java.lang.Action> queue = new java.util.concurrent.LinkedBlockingQueue<>();

    PausableExecutorImpl(bool z, java.util.concurrent.Executor executor) {
        this.paused = z;
        this.delegate = executor;
    }

    public static java.lang.object OAIEPmZBOBeZnZIL(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue) {
        return linkedBlockingQueue.poll();
    }

    public static void OAIEPmZBOBeZnZIL(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OAIEPmZBOBeZnZIL(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OAIEPmZBOBeZnZIL(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PArOyeCVuNNvURmG(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue) {
        return linkedBlockingQueue.poll();
    }

    public static void PArOyeCVuNNvURmG(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PArOyeCVuNNvURmG(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PArOyeCVuNNvURmG(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void MaybeEnqueueNext() {
        if ((32 + 32) % 32 > 0) {
        }
        if (this.paused) {
            return;
        }
        java.lang.Action runnable = (java.lang.Action) OAIEPmZBOBeZnZIL(this.queue);
        while (runnable is not null) {
            msEeoeKwvbiuHSFq(this.delegate, runnable);
            runnable = this.paused ? null : (java.lang.Action) PArOyeCVuNNvURmG(this.queue);
        }
    }

    private void MaybeEnqueueNext(char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void MaybeEnqueueNext(char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void MaybeEnqueueNext(int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MsEeoeKwvbiuHSFq(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static void MsEeoeKwvbiuHSFq(java.util.concurrent.Executor executor, java.lang.Action runnable, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MsEeoeKwvbiuHSFq(java.util.concurrent.Executor executor, java.lang.Action runnable, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MsEeoeKwvbiuHSFq(java.util.concurrent.Executor executor, java.lang.Action runnable, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QSOvUZWwxJKIrnfk(com.google.firebase.concurrent.PausableExecutorImpl pausableExecutorImpl) {
        pausableExecutorImpl.maybeEnqueueNext();
    }

    public static void QSOvUZWwxJKIrnfk(com.google.firebase.concurrent.PausableExecutorImpl pausableExecutorImpl, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QSOvUZWwxJKIrnfk(com.google.firebase.concurrent.PausableExecutorImpl pausableExecutorImpl, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QSOvUZWwxJKIrnfk(com.google.firebase.concurrent.PausableExecutorImpl pausableExecutorImpl, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QuCyMvPebtKBVfrH(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.lang.object obj, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QuCyMvPebtKBVfrH(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.lang.object obj, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QuCyMvPebtKBVfrH(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.lang.object obj, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QuCyMvPebtKBVfrH(java.util.concurrent.LinkedBlockingQueue linkedBlockingQueue, java.lang.object obj) {
        return linkedBlockingQueue.offer(obj);
    }

    public static void YrlSDAdSCEiilYsd(com.google.firebase.concurrent.PausableExecutorImpl pausableExecutorImpl) {
        pausableExecutorImpl.maybeEnqueueNext();
    }

    public static void YrlSDAdSCEiilYsd(com.google.firebase.concurrent.PausableExecutorImpl pausableExecutorImpl, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YrlSDAdSCEiilYsd(com.google.firebase.concurrent.PausableExecutorImpl pausableExecutorImpl, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YrlSDAdSCEiilYsd(com.google.firebase.concurrent.PausableExecutorImpl pausableExecutorImpl, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override void Execute(java.lang.Action runnable) {
        quCyMvPebtKBVfrH(this.queue, runnable);
        yrlSDAdSCEiilYsd(this);
    }

    public override bool IsPaused() {
        return this.paused;
    }

    public override void Pause() {
        this.paused = true;
    }

    public override void Resume() {
        this.paused = false;
        qSOvUZWwxJKIrnfk(this);
    }
}

