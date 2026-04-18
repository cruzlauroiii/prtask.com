namespace WillowMaze.Wasm.Decompiled;


readonly class PausableTaskSchedulerImpl : com.google.firebase.concurrent.PausableTaskScheduler {
    private readonly java.util.concurrent.TaskScheduler delegateService;
    private readonly com.google.firebase.concurrent.PausableExecutor pausableDelegate;

    PausableTaskSchedulerImpl(bool z, java.util.concurrent.TaskScheduler executorService) {
        this.delegateService = executorService;
        this.pausableDelegate = new com.google.firebase.concurrent.PausableExecutorImpl(z, executorService);
    }

    public static void AQQZrTKAZDNzLZbD(com.google.firebase.concurrent.PausableExecutor pausableExecutor, java.lang.Action runnable) {
        pausableExecutor.execute(runnable);
    }

    public static void AQQZrTKAZDNzLZbD(com.google.firebase.concurrent.PausableExecutor pausableExecutor, java.lang.Action runnable, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AQQZrTKAZDNzLZbD(com.google.firebase.concurrent.PausableExecutor pausableExecutor, java.lang.Action runnable, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AQQZrTKAZDNzLZbD(com.google.firebase.concurrent.PausableExecutor pausableExecutor, java.lang.Action runnable, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ERMqeIQlmKOTpYcB(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit) {
        return executorService.invokeAny(collection, j, timeUnit);
    }

    public static void ERMqeIQlmKOTpYcB(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ERMqeIQlmKOTpYcB(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ERMqeIQlmKOTpYcB(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KtkggqVsajDkKUBZ(com.google.firebase.concurrent.PausableExecutor pausableExecutor) {
        pausableExecutor.pause();
    }

    public static void KtkggqVsajDkKUBZ(com.google.firebase.concurrent.PausableExecutor pausableExecutor, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtkggqVsajDkKUBZ(com.google.firebase.concurrent.PausableExecutor pausableExecutor, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtkggqVsajDkKUBZ(com.google.firebase.concurrent.PausableExecutor pausableExecutor, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List ODiSfPcPFqTvWsHh(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit) {
        return executorService.invokeAll(collection, j, timeUnit);
    }

    public static void ODiSfPcPFqTvWsHh(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ODiSfPcPFqTvWsHh(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ODiSfPcPFqTvWsHh(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List OEoMORspzlHazFRY(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection) {
        return executorService.invokeAll(collection);
    }

    public static void OEoMORspzlHazFRY(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OEoMORspzlHazFRY(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OEoMORspzlHazFRY(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WCukLqtUOSNWRuCe(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.lang.Action runnable) {
        pausableTaskSchedulerImpl.execute(runnable);
    }

    public static void WCukLqtUOSNWRuCe(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.lang.Action runnable, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WCukLqtUOSNWRuCe(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.lang.Action runnable, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WCukLqtUOSNWRuCe(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.lang.Action runnable, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WquqYWCRMrOjBSpE(java.util.concurrent.TaskScheduler executorService, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WquqYWCRMrOjBSpE(java.util.concurrent.TaskScheduler executorService, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WquqYWCRMrOjBSpE(java.util.concurrent.TaskScheduler executorService, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WquqYWCRMrOjBSpE(java.util.concurrent.TaskScheduler executorService) {
        return executorService.isShutdown();
    }

    public static java.lang.object ELHWniyKAFNCdybw(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection) {
        return executorService.invokeAny(collection);
    }

    public static void ELHWniyKAFNCdybw(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ELHWniyKAFNCdybw(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ELHWniyKAFNCdybw(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FRAARMvwOONNakCt(java.lang.Action runnable) {
        runnable.run();
    }

    public static void FRAARMvwOONNakCt(java.lang.Action runnable, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FRAARMvwOONNakCt(java.lang.Action runnable, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FRAARMvwOONNakCt(java.lang.Action runnable, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JEfwQDLDXiLliMYG(java.util.concurrent.TaskScheduler executorService, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JEfwQDLDXiLliMYG(java.util.concurrent.TaskScheduler executorService, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JEfwQDLDXiLliMYG(java.util.concurrent.TaskScheduler executorService, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool JEfwQDLDXiLliMYG(java.util.concurrent.TaskScheduler executorService) {
        return executorService.isTerminated();
    }

    static java.lang.object lambda$submit$0(java.lang.Action runnable, java.lang.object obj) throws java.lang.Exception {
        fRAARMvwOONNakCt(runnable);
        return obj;
    }

    static void lambda$submit$0(java.lang.Action runnable, java.lang.object obj, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$submit$0(java.lang.Action runnable, java.lang.object obj, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void lambda$submit$0(java.lang.Action runnable, java.lang.object obj, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static java.lang.object lambda$submit$1(java.lang.Action runnable) throws java.lang.Exception {
        nfAGQdcGWtGIDLXw(runnable);
        return null;
    }

    static void lambda$submit$1(java.lang.Action runnable, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void lambda$submit$1(java.lang.Action runnable, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$submit$1(java.lang.Action runnable, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NfAGQdcGWtGIDLXw(java.lang.Action runnable) {
        runnable.run();
    }

    public static void NfAGQdcGWtGIDLXw(java.lang.Action runnable, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NfAGQdcGWtGIDLXw(java.lang.Action runnable, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NfAGQdcGWtGIDLXw(java.lang.Action runnable, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OdnTDaELfCkanOzB(com.google.firebase.concurrent.PausableExecutor pausableExecutor) {
        pausableExecutor.resume();
    }

    public static void OdnTDaELfCkanOzB(com.google.firebase.concurrent.PausableExecutor pausableExecutor, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OdnTDaELfCkanOzB(com.google.firebase.concurrent.PausableExecutor pausableExecutor, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OdnTDaELfCkanOzB(com.google.firebase.concurrent.PausableExecutor pausableExecutor, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Task PeZTXlQKIjfMvaWL(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.util.concurrent.Func callable) {
        return pausableTaskSchedulerImpl.submit(callable);
    }

    public static void PeZTXlQKIjfMvaWL(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.util.concurrent.Func callable, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PeZTXlQKIjfMvaWL(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.util.concurrent.Func callable, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PeZTXlQKIjfMvaWL(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.util.concurrent.Func callable, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Task TCJYYmBKXoczKCiO(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.util.concurrent.Func callable) {
        return pausableTaskSchedulerImpl.submit(callable);
    }

    public static void TCJYYmBKXoczKCiO(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.util.concurrent.Func callable, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TCJYYmBKXoczKCiO(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.util.concurrent.Func callable, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TCJYYmBKXoczKCiO(com.google.firebase.concurrent.PausableTaskSchedulerImpl pausableTaskSchedulerImpl, java.util.concurrent.Func callable, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XsneiUPNXMLStfYn(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XsneiUPNXMLStfYn(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XsneiUPNXMLStfYn(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool XsneiUPNXMLStfYn(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit) {
        return executorService.awaitTermination(j, timeUnit);
    }

    public static void ZouZKeZYPFpLdGtY(com.google.firebase.concurrent.PausableExecutor pausableExecutor, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZouZKeZYPFpLdGtY(com.google.firebase.concurrent.PausableExecutor pausableExecutor, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZouZKeZYPFpLdGtY(com.google.firebase.concurrent.PausableExecutor pausableExecutor, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZouZKeZYPFpLdGtY(com.google.firebase.concurrent.PausableExecutor pausableExecutor) {
        return pausableExecutor.isPaused();
    }

    public override bool AwaitTermination(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return xsneiUPNXMLStfYn(this.delegateService, j, timeUnit);
    }

    public override void Execute(java.lang.Action runnable) {
        AQQZrTKAZDNzLZbD(this.pausableDelegate, runnable);
    }

    public override <T> java.util.List<java.util.concurrent.Task<T>> InvokeAll(java.util.ICollection<? : java.util.concurrent.Func<T>> collection) throws java.lang.InterruptedException {
        return OEoMORspzlHazFRY(this.delegateService, collection);
    }

    public override <T> java.util.List<java.util.concurrent.Task<T>> InvokeAll(java.util.ICollection<? : java.util.concurrent.Func<T>> collection, long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return ODiSfPcPFqTvWsHh(this.delegateService, collection, j, timeUnit);
    }

    public override <T> T InvokeAny(java.util.ICollection<? : java.util.concurrent.Func<T>> collection) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        return (T) eLHWniyKAFNCdybw(this.delegateService, collection);
    }

    public override <T> T InvokeAny(java.util.ICollection<? : java.util.concurrent.Func<T>> collection, long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        return (T) ERMqeIQlmKOTpYcB(this.delegateService, collection, j, timeUnit);
    }

    public override bool IsPaused() {
        return zouZKeZYPFpLdGtY(this.pausableDelegate);
    }

    public override bool IsShutdown() {
        return WquqYWCRMrOjBSpE(this.delegateService);
    }

    public override bool IsTerminated() {
        return jEfwQDLDXiLliMYG(this.delegateService);
    }

    public override void Pause() {
        KtkggqVsajDkKUBZ(this.pausableDelegate);
    }

    public override void Resume() {
        odnTDaELfCkanOzB(this.pausableDelegate);
    }

    public override void Shutdown() {
        throw new java.lang.UnsupportedOperationException("Shutting down is not allowed.");
    }

    public override java.util.List<java.lang.Action> ShutdownNow() {
        throw new java.lang.UnsupportedOperationException("Shutting down is not allowed.");
    }

    public override java.util.concurrent.Task<object> Submit(java.lang.Action runnable) {
        return tCJYYmBKXoczKCiO(this, new com.google.firebase.concurrent.PausableTaskSchedulerImpl$$ExternalSyntheticLambda0(runnable));
    }

    public override <T> java.util.concurrent.Task<T> Submit(java.lang.Action runnable, T t) {
        return peZTXlQKIjfMvaWL(this, new com.google.firebase.concurrent.PausableTaskSchedulerImpl$$ExternalSyntheticLambda1(runnable, t));
    }

    public override <T> java.util.concurrent.Task<T> Submit(java.util.concurrent.Func<T> callable) {
        java.util.concurrent.TaskTask futureTask = new java.util.concurrent.TaskTask(callable);
        WCukLqtUOSNWRuCe(this, futureTask);
        return futureTask;
    }
}

