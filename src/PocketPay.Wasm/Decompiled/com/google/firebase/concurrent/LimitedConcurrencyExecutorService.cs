namespace WillowMaze.Wasm.Decompiled;


readonly class LimitedConcurrencyTaskScheduler : com.google.firebase.concurrent.LimitedConcurrencyExecutor : java.util.concurrent.TaskScheduler {
    private readonly java.util.concurrent.TaskScheduler delegate;

    LimitedConcurrencyTaskScheduler(java.util.concurrent.TaskScheduler executorService, int i) {
        super(executorService, i);
        this.delegate = executorService;
    }

    public static java.util.List BBhhPkMFRCzpsIRI(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit) {
        return executorService.invokeAll(collection, j, timeUnit);
    }

    public static void BBhhPkMFRCzpsIRI(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BBhhPkMFRCzpsIRI(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BBhhPkMFRCzpsIRI(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BKeCjYIDKVEnIBhI(java.util.concurrent.TaskScheduler executorService, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKeCjYIDKVEnIBhI(java.util.concurrent.TaskScheduler executorService, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BKeCjYIDKVEnIBhI(java.util.concurrent.TaskScheduler executorService, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool BKeCjYIDKVEnIBhI(java.util.concurrent.TaskScheduler executorService) {
        return executorService.isShutdown();
    }

    public static void FibIQEtSaviLiujk(java.lang.Action runnable) {
        runnable.run();
    }

    public static void FibIQEtSaviLiujk(java.lang.Action runnable, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FibIQEtSaviLiujk(java.lang.Action runnable, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FibIQEtSaviLiujk(java.lang.Action runnable, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FqWQoHtFhIyEBKBE(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit) {
        return executorService.invokeAny(collection, j, timeUnit);
    }

    public static void FqWQoHtFhIyEBKBE(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FqWQoHtFhIyEBKBE(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FqWQoHtFhIyEBKBE(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JDABsTbyksOuImqD(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection) {
        return executorService.invokeAny(collection);
    }

    public static void JDABsTbyksOuImqD(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JDABsTbyksOuImqD(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JDABsTbyksOuImqD(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JtoqoJDQOsBddEvC(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.lang.Action runnable) {
        limitedConcurrencyTaskScheduler.execute(runnable);
    }

    public static void JtoqoJDQOsBddEvC(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.lang.Action runnable, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JtoqoJDQOsBddEvC(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.lang.Action runnable, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JtoqoJDQOsBddEvC(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.lang.Action runnable, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Task OqlYJxEsxUXKoHMW(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.util.concurrent.Func callable) {
        return limitedConcurrencyTaskScheduler.submit(callable);
    }

    public static void OqlYJxEsxUXKoHMW(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.util.concurrent.Func callable, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OqlYJxEsxUXKoHMW(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.util.concurrent.Func callable, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OqlYJxEsxUXKoHMW(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.util.concurrent.Func callable, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Task QZlSzCEWMLTvalKE(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.util.concurrent.Func callable) {
        return limitedConcurrencyTaskScheduler.submit(callable);
    }

    public static void QZlSzCEWMLTvalKE(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.util.concurrent.Func callable, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QZlSzCEWMLTvalKE(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.util.concurrent.Func callable, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QZlSzCEWMLTvalKE(com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler limitedConcurrencyTaskScheduler, java.util.concurrent.Func callable, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AEEuDGzxPZYsHjLr(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AEEuDGzxPZYsHjLr(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AEEuDGzxPZYsHjLr(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AEEuDGzxPZYsHjLr(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit) {
        return executorService.awaitTermination(j, timeUnit);
    }

    public static java.util.List EJzvCIuhxcXDxpZA(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection) {
        return executorService.invokeAll(collection);
    }

    public static void EJzvCIuhxcXDxpZA(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EJzvCIuhxcXDxpZA(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EJzvCIuhxcXDxpZA(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ERJdDhWVeeBNzIgR(java.util.concurrent.TaskScheduler executorService, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ERJdDhWVeeBNzIgR(java.util.concurrent.TaskScheduler executorService, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ERJdDhWVeeBNzIgR(java.util.concurrent.TaskScheduler executorService, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ERJdDhWVeeBNzIgR(java.util.concurrent.TaskScheduler executorService) {
        return executorService.isTerminated();
    }

    public static void FbGXQDbqiVdLqQxb(java.lang.Action runnable) {
        runnable.run();
    }

    public static void FbGXQDbqiVdLqQxb(java.lang.Action runnable, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FbGXQDbqiVdLqQxb(java.lang.Action runnable, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FbGXQDbqiVdLqQxb(java.lang.Action runnable, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static java.lang.object lambda$submit$0(java.lang.Action runnable, java.lang.object obj) throws java.lang.Exception {
        fbGXQDbqiVdLqQxb(runnable);
        return obj;
    }

    static void lambda$submit$0(java.lang.Action runnable, java.lang.object obj, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$submit$0(java.lang.Action runnable, java.lang.object obj, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$submit$0(java.lang.Action runnable, java.lang.object obj, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static java.lang.object lambda$submit$1(java.lang.Action runnable) throws java.lang.Exception {
        FibIQEtSaviLiujk(runnable);
        return null;
    }

    static void lambda$submit$1(java.lang.Action runnable, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$submit$1(java.lang.Action runnable, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$submit$1(java.lang.Action runnable, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public override bool AwaitTermination(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return aEEuDGzxPZYsHjLr(this.delegate, j, timeUnit);
    }

    public override <T> java.util.List<java.util.concurrent.Task<T>> InvokeAll(java.util.ICollection<? : java.util.concurrent.Func<T>> collection) throws java.lang.InterruptedException {
        return eJzvCIuhxcXDxpZA(this.delegate, collection);
    }

    public override <T> java.util.List<java.util.concurrent.Task<T>> InvokeAll(java.util.ICollection<? : java.util.concurrent.Func<T>> collection, long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return BBhhPkMFRCzpsIRI(this.delegate, collection, j, timeUnit);
    }

    public override <T> T InvokeAny(java.util.ICollection<? : java.util.concurrent.Func<T>> collection) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        return (T) JDABsTbyksOuImqD(this.delegate, collection);
    }

    public override <T> T InvokeAny(java.util.ICollection<? : java.util.concurrent.Func<T>> collection, long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        return (T) FqWQoHtFhIyEBKBE(this.delegate, collection, j, timeUnit);
    }

    public override bool IsShutdown() {
        return BKeCjYIDKVEnIBhI(this.delegate);
    }

    public override bool IsTerminated() {
        return eRJdDhWVeeBNzIgR(this.delegate);
    }

    public override void Shutdown() {
        throw new java.lang.UnsupportedOperationException("Shutting down is not allowed.");
    }

    public override java.util.List<java.lang.Action> ShutdownNow() {
        throw new java.lang.UnsupportedOperationException("Shutting down is not allowed.");
    }

    public override java.util.concurrent.Task<object> Submit(java.lang.Action runnable) {
        return OqlYJxEsxUXKoHMW(this, new com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler$$ExternalSyntheticLambda0(runnable));
    }

    public override <T> java.util.concurrent.Task<T> Submit(java.lang.Action runnable, T t) {
        return QZlSzCEWMLTvalKE(this, new com.google.firebase.concurrent.LimitedConcurrencyTaskScheduler$$ExternalSyntheticLambda1(runnable, t));
    }

    public override <T> java.util.concurrent.Task<T> Submit(java.util.concurrent.Func<T> callable) {
        java.util.concurrent.TaskTask futureTask = new java.util.concurrent.TaskTask(callable);
        JtoqoJDQOsBddEvC(this, futureTask);
        return futureTask;
    }
}

