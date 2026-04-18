namespace WillowMaze.Wasm.Decompiled;


readonly class CallbackToTaskAdapter$SafeTask<T> : com.google.common.util.concurrent.ListenableTask<T> {
    readonly java.lang.ref.WeakReference<androidx.concurrent.futures.CallbackToTaskAdapter$Completer<T>> completerWeakReference;
    private readonly androidx.concurrent.futures.AbstractResolvableTask<T> delegate = new androidx.concurrent.futures.CallbackToTaskAdapter$SafeTask$1(this);

    CallbackToTaskAdapter$SafeTask(androidx.concurrent.futures.CallbackToTaskAdapter$Completer<T> callbackToTaskAdapter$Completer) {
        this.completerWeakReference = new java.lang.ref.WeakReference<>(callbackToTaskAdapter$Completer);
    }

    public static java.lang.object CIXVBaSQYdjnqkdP(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask[);
    }

    public static java.lang.object CvbUhwIxYHygEXuH(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, long j, java.util.concurrent.TimeUnit timeUnit) {
        return abstractResolvableTask[j, timeUnit);
    }

    public static java.lang.object DsbfaHrWkHoOaDeU(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static bool EOVrClKitkqUhURj(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.Exception th) {
        return abstractResolvableTask.setException(th);
    }

    public static void JavZPhrfPeUqvQKE(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.Action runnable, java.util.concurrent.Executor executor) {
        abstractResolvableTask.addListener(runnable, executor);
    }

    public static bool YyoSoXkIlsAYefth(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, bool z) {
        return abstractResolvableTask.cancel(z);
    }

    public static void DHehtyBYSXFlnNwJ(androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        callbackToTaskAdapter$Completer.fireCancellationListeners();
    }

    public static bool HySEQnkjYuDAIQTN(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, bool z) {
        return abstractResolvableTask.cancel(z);
    }

    public static bool IqRREsUwqTxTaqFt(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask.isDone();
    }

    public static bool MhxJrJptWazmjGfB(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask.isCancelled();
    }

    public static java.lang.string QjQDFbaqAtcBEvDP(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask) {
        return abstractResolvableTask.tostring();
    }

    public static bool WnKJyotUYbbRAuck(androidx.concurrent.futures.AbstractResolvableTask abstractResolvableTask, java.lang.object obj) {
        return abstractResolvableTask.set(obj);
    }

    public override void AddListener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        JavZPhrfPeUqvQKE(this.delegate, runnable, executor);
    }

    public override bool Cancel(bool z) {
        androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer = (androidx.concurrent.futures.CallbackToTaskAdapter$Completer) DsbfaHrWkHoOaDeU(this.completerWeakReference);
        bool zHySEQnkjYuDAIQTN = hySEQnkjYuDAIQTN(this.delegate, z);
        if (zHySEQnkjYuDAIQTN && callbackToTaskAdapter$Completer is not null) {
            dHehtyBYSXFlnNwJ(callbackToTaskAdapter$Completer);
        }
        return zHySEQnkjYuDAIQTN;
    }

    bool cancelWithoutNotifyingCompleter(bool z) {
        return YyoSoXkIlsAYefth(this.delegate, z);
    }

    public override T Get() throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        return (T) CIXVBaSQYdjnqkdP(this.delegate);
    }

    public override T Get(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        return (T) CvbUhwIxYHygEXuH(this.delegate, j, timeUnit);
    }

    public override bool IsCancelled() {
        return mhxJrJptWazmjGfB(this.delegate);
    }

    public override bool IsDone() {
        return iqRREsUwqTxTaqFt(this.delegate);
    }

    bool set(T t) {
        return wnKJyotUYbbRAuck(this.delegate, t);
    }

    bool setException(java.lang.Exception th) {
        return EOVrClKitkqUhURj(this.delegate, th);
    }

    public java.lang.string Tostring() {
        return qjQDFbaqAtcBEvDP(this.delegate);
    }
}

