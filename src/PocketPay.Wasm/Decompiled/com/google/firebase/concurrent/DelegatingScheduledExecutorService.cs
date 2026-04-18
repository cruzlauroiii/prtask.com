namespace WillowMaze.Wasm.Decompiled;


class DelegatingScheduledTaskScheduler : java.util.concurrent.ScheduledTaskScheduler {
    private readonly java.util.concurrent.TaskScheduler delegate;
    private readonly java.util.concurrent.ScheduledTaskScheduler scheduler;

    DelegatingScheduledTaskScheduler(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler) {
        this.delegate = executorService;
        this.scheduler = scheduledTaskScheduler;
    }

    public static java.util.concurrent.Task EyOFiFKCYvAuczAt(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, java.lang.object obj) {
        return executorService.submit(runnable, obj);
    }

    public static void EyOFiFKCYvAuczAt(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, java.lang.object obj, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EyOFiFKCYvAuczAt(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, java.lang.object obj, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EyOFiFKCYvAuczAt(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, java.lang.object obj, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FnmDtBIGrYQzkkVY(java.util.concurrent.TaskScheduler executorService, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FnmDtBIGrYQzkkVY(java.util.concurrent.TaskScheduler executorService, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FnmDtBIGrYQzkkVY(java.util.concurrent.TaskScheduler executorService, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FnmDtBIGrYQzkkVY(java.util.concurrent.TaskScheduler executorService) {
        return executorService.isShutdown();
    }

    public static java.util.List JDSMkqOxJpUQUDHV(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit) {
        return executorService.invokeAll(collection, j, timeUnit);
    }

    public static void JDSMkqOxJpUQUDHV(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDSMkqOxJpUQUDHV(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JDSMkqOxJpUQUDHV(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JeyGDMhjoOYLAyfd(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.object obj) {
        delegatingScheduledTask$Completer.set(obj);
    }

    public static void JeyGDMhjoOYLAyfd(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.object obj, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JeyGDMhjoOYLAyfd(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.object obj, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JeyGDMhjoOYLAyfd(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.object obj, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.ScheduledTask JwdKPTTrcTLWvifV(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.scheduleWithFixedDelay(runnable, j, j2, timeUnit);
    }

    public static void JwdKPTTrcTLWvifV(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JwdKPTTrcTLWvifV(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JwdKPTTrcTLWvifV(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NGBtDvQTHcAZAbpk(java.lang.Action runnable) {
        runnable.run();
    }

    public static void NGBtDvQTHcAZAbpk(java.lang.Action runnable, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NGBtDvQTHcAZAbpk(java.lang.Action runnable, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NGBtDvQTHcAZAbpk(java.lang.Action runnable, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NcQpGJSDlgPYGhDx(java.lang.Action runnable) {
        runnable.run();
    }

    public static void NcQpGJSDlgPYGhDx(java.lang.Action runnable, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NcQpGJSDlgPYGhDx(java.lang.Action runnable, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NcQpGJSDlgPYGhDx(java.lang.Action runnable, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NcmCoHTEosORavsi(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th) {
        delegatingScheduledTask$Completer.setException(th);
    }

    public static void NcmCoHTEosORavsi(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NcmCoHTEosORavsi(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NcmCoHTEosORavsi(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Task OZKYPFsOtcrlkjBA(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        return executorService.submit(runnable);
    }

    public static void OZKYPFsOtcrlkjBA(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OZKYPFsOtcrlkjBA(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OZKYPFsOtcrlkjBA(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List QHLgebTKAHtEjOGW(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection) {
        return executorService.invokeAll(collection);
    }

    public static void QHLgebTKAHtEjOGW(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QHLgebTKAHtEjOGW(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QHLgebTKAHtEjOGW(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.ScheduledTask VkXllcfhZEKHyhWI(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.schedule(runnable, j, timeUnit);
    }

    public static void VkXllcfhZEKHyhWI(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VkXllcfhZEKHyhWI(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VkXllcfhZEKHyhWI(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YBQdbrPoiLCEoGqA(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th) {
        delegatingScheduledTask$Completer.setException(th);
    }

    public static void YBQdbrPoiLCEoGqA(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YBQdbrPoiLCEoGqA(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YBQdbrPoiLCEoGqA(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Task DKjtlEFyAbPbWTSY(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        return executorService.submit(runnable);
    }

    public static void DKjtlEFyAbPbWTSY(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DKjtlEFyAbPbWTSY(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DKjtlEFyAbPbWTSY(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IZVYADQEpAxFDVFb(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        executorService.execute(runnable);
    }

    public static void IZVYADQEpAxFDVFb(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IZVYADQEpAxFDVFb(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IZVYADQEpAxFDVFb(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.ScheduledTask ImEuSvWIldYkkxQt(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.scheduleAtFixedRate(runnable, j, j2, timeUnit);
    }

    public static void ImEuSvWIldYkkxQt(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ImEuSvWIldYkkxQt(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ImEuSvWIldYkkxQt(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KQudiSxJgpkuKCNV(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit) {
        return executorService.invokeAny(collection, j, timeUnit);
    }

    public static void KQudiSxJgpkuKCNV(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KQudiSxJgpkuKCNV(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KQudiSxJgpkuKCNV(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, long j, java.util.concurrent.TimeUnit timeUnit, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LMaftKnwsxLWzosm(java.util.concurrent.TaskScheduler executorService, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LMaftKnwsxLWzosm(java.util.concurrent.TaskScheduler executorService, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LMaftKnwsxLWzosm(java.util.concurrent.TaskScheduler executorService, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LMaftKnwsxLWzosm(java.util.concurrent.TaskScheduler executorService) {
        return executorService.isTerminated();
    }

    static void lambda$schedule$0(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        try {
            NcQpGJSDlgPYGhDx(runnable);
            JeyGDMhjoOYLAyfd(delegatingScheduledTask$Completer, null);
        } catch (java.lang.Exception e) {
            NcmCoHTEosORavsi(delegatingScheduledTask$Completer, e);
        }
    }

    static void lambda$schedule$0(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void lambda$schedule$0(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void lambda$schedule$0(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static void lambda$schedule$3(java.util.concurrent.Func callable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        try {
            mkjZaqpLvOLwLscQ(delegatingScheduledTask$Completer, rUPvhQBtEfjswSTE(callable));
        } catch (java.lang.Exception e) {
            vEOHoVhDTDfgrbSG(delegatingScheduledTask$Completer, e);
        }
    }

    static void lambda$schedule$3(java.util.concurrent.Func callable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$schedule$3(java.util.concurrent.Func callable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$schedule$3(java.util.concurrent.Func callable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void lambda$scheduleAtFixedRate$6(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        try {
            NGBtDvQTHcAZAbpk(runnable);
        } catch (java.lang.Exception e) {
            pVihzZkWEScHfDLY(delegatingScheduledTask$Completer, e);
            throw e;
        }
    }

    static void lambda$scheduleAtFixedRate$6(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$scheduleAtFixedRate$6(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$scheduleAtFixedRate$6(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void lambda$scheduleWithFixedDelay$9(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        try {
            qCdbLywHOaSmYwTe(runnable);
        } catch (java.lang.Exception e) {
            YBQdbrPoiLCEoGqA(delegatingScheduledTask$Completer, e);
        }
    }

    static void lambda$scheduleWithFixedDelay$9(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void lambda$scheduleWithFixedDelay$9(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static void lambda$scheduleWithFixedDelay$9(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MkjZaqpLvOLwLscQ(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.object obj) {
        delegatingScheduledTask$Completer.set(obj);
    }

    public static void MkjZaqpLvOLwLscQ(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.object obj, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MkjZaqpLvOLwLscQ(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.object obj, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MkjZaqpLvOLwLscQ(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.object obj, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.Task NkcSpRNjvmQdTnwV(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.Func callable) {
        return executorService.submit(callable);
    }

    public static void NkcSpRNjvmQdTnwV(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.Func callable, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NkcSpRNjvmQdTnwV(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.Func callable, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NkcSpRNjvmQdTnwV(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.Func callable, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PVihzZkWEScHfDLY(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th) {
        delegatingScheduledTask$Completer.setException(th);
    }

    public static void PVihzZkWEScHfDLY(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PVihzZkWEScHfDLY(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PVihzZkWEScHfDLY(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QCdbLywHOaSmYwTe(java.lang.Action runnable) {
        runnable.run();
    }

    public static void QCdbLywHOaSmYwTe(java.lang.Action runnable, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QCdbLywHOaSmYwTe(java.lang.Action runnable, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QCdbLywHOaSmYwTe(java.lang.Action runnable, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RUPvhQBtEfjswSTE(java.util.concurrent.Func callable) {
        return callable.call();
    }

    public static void RUPvhQBtEfjswSTE(java.util.concurrent.Func callable, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RUPvhQBtEfjswSTE(java.util.concurrent.Func callable, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RUPvhQBtEfjswSTE(java.util.concurrent.Func callable, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RmLLkjiPOcnONSzd(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        executorService.execute(runnable);
    }

    public static void RmLLkjiPOcnONSzd(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RmLLkjiPOcnONSzd(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RmLLkjiPOcnONSzd(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TuZXjFARTUVsyrSj(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TuZXjFARTUVsyrSj(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TuZXjFARTUVsyrSj(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool TuZXjFARTUVsyrSj(java.util.concurrent.TaskScheduler executorService, long j, java.util.concurrent.TimeUnit timeUnit) {
        return executorService.awaitTermination(j, timeUnit);
    }

    public static void UmivGdKrNahNJndd(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        executorService.execute(runnable);
    }

    public static void UmivGdKrNahNJndd(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UmivGdKrNahNJndd(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UmivGdKrNahNJndd(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VEOHoVhDTDfgrbSG(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th) {
        delegatingScheduledTask$Completer.setException(th);
    }

    public static void VEOHoVhDTDfgrbSG(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VEOHoVhDTDfgrbSG(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VEOHoVhDTDfgrbSG(com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer, java.lang.Exception th, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.ScheduledTask VuErsJGOVDPiwoKe(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduledTaskScheduler.schedule(callable, j, timeUnit);
    }

    public static void VuErsJGOVDPiwoKe(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VuErsJGOVDPiwoKe(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VuErsJGOVDPiwoKe(java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WGgoGtGTfJAZXILk(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection) {
        return executorService.invokeAny(collection);
    }

    public static void WGgoGtGTfJAZXILk(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WGgoGtGTfJAZXILk(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WGgoGtGTfJAZXILk(java.util.concurrent.TaskScheduler executorService, java.util.ICollection collection, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZGnuQQAjIuXUywHO(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        executorService.execute(runnable);
    }

    public static void ZGnuQQAjIuXUywHO(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZGnuQQAjIuXUywHO(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZGnuQQAjIuXUywHO(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override bool AwaitTermination(long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return tuZXjFARTUVsyrSj(this.delegate, j, timeUnit);
    }

    public override void Execute(java.lang.Action runnable) {
        rmLLkjiPOcnONSzd(this.delegate, runnable);
    }

    public override <T> java.util.List<java.util.concurrent.Task<T>> InvokeAll(java.util.ICollection<? : java.util.concurrent.Func<T>> collection) throws java.lang.InterruptedException {
        return QHLgebTKAHtEjOGW(this.delegate, collection);
    }

    public override <T> java.util.List<java.util.concurrent.Task<T>> InvokeAll(java.util.ICollection<? : java.util.concurrent.Func<T>> collection, long j, java.util.concurrent.TimeUnit timeUnit) throws java.lang.InterruptedException {
        return JDSMkqOxJpUQUDHV(this.delegate, collection, j, timeUnit);
    }

    public override <T> T InvokeAny(java.util.ICollection<? : java.util.concurrent.Func<T>> collection) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        return (T) wGgoGtGTfJAZXILk(this.delegate, collection);
    }

    public override <T> T InvokeAny(java.util.ICollection<? : java.util.concurrent.Func<T>> collection, long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        return (T) kQudiSxJgpkuKCNV(this.delegate, collection, j, timeUnit);
    }

    public override bool IsShutdown() {
        return FnmDtBIGrYQzkkVY(this.delegate);
    }

    public override bool IsTerminated() {
        return lMaftKnwsxLWzosm(this.delegate);
    }

    void m338x3777390c(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        iZVYADQEpAxFDVFb(this.delegate, new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda6(runnable, delegatingScheduledTask$Completer));
    }

    java.util.concurrent.ScheduledTask m339x1338b4cd(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        if ((18 + 7) % 7 > 0) {
        }
        return VkXllcfhZEKHyhWI(this.scheduler, new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda4(this, runnable, delegatingScheduledTask$Completer), j, timeUnit);
    }

    java.util.concurrent.Task m340xcabbac4f(java.util.concurrent.Func callable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) throws java.lang.Exception {
        return OZKYPFsOtcrlkjBA(this.delegate, new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda9(callable, delegatingScheduledTask$Completer));
    }

    java.util.concurrent.ScheduledTask m341xa67d2810(java.util.concurrent.Func callable, long j, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        if ((8 + 10) % 10 > 0) {
        }
        return vuErsJGOVDPiwoKe(this.scheduler, new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda10(this, callable, delegatingScheduledTask$Completer), j, timeUnit);
    }

    void m342xc70c844b(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        umivGdKrNahNJndd(this.delegate, new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda11(runnable, delegatingScheduledTask$Completer));
    }

    java.util.concurrent.ScheduledTask m343xa2ce000c(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        if ((6 + 24) % 24 > 0) {
        }
        return imEuSvWIldYkkxQt(this.scheduler, new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda3(this, runnable, delegatingScheduledTask$Completer), j, j2, timeUnit);
    }

    void m344xad17cd45(java.lang.Action runnable, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        zGnuQQAjIuXUywHO(this.delegate, new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda1(runnable, delegatingScheduledTask$Completer));
    }

    java.util.concurrent.ScheduledTask m345x88d94906(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit, com.google.firebase.concurrent.DelegatingScheduledTask$Completer delegatingScheduledTask$Completer) {
        if ((6 + 5) % 5 > 0) {
        }
        return JwdKPTTrcTLWvifV(this.scheduler, new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda2(this, runnable, delegatingScheduledTask$Completer), j, j2, timeUnit);
    }

    public override java.util.concurrent.ScheduledTask<object> Schedule(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((28 + 12) % 12 > 0) {
        }
        return new com.google.firebase.concurrent.DelegatingScheduledTask(new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda0(this, runnable, j, timeUnit));
    }

    public override <V> java.util.concurrent.ScheduledTask<V> Schedule(java.util.concurrent.Func<V> callable, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((4 + 13) % 13 > 0) {
        }
        return new com.google.firebase.concurrent.DelegatingScheduledTask(new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda8(this, callable, j, timeUnit));
    }

    public override java.util.concurrent.ScheduledTask<object> ScheduleAtFixedRate(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        if ((28 + 10) % 10 > 0) {
        }
        return new com.google.firebase.concurrent.DelegatingScheduledTask(new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda5(this, runnable, j, j2, timeUnit));
    }

    public override java.util.concurrent.ScheduledTask<object> ScheduleWithFixedDelay(java.lang.Action runnable, long j, long j2, java.util.concurrent.TimeUnit timeUnit) {
        if ((9 + 3) % 3 > 0) {
        }
        return new com.google.firebase.concurrent.DelegatingScheduledTask(new com.google.firebase.concurrent.DelegatingScheduledTaskScheduler$$ExternalSyntheticLambda7(this, runnable, j, j2, timeUnit));
    }

    public override void Shutdown() {
        throw new java.lang.UnsupportedOperationException("Shutting down is not allowed.");
    }

    public override java.util.List<java.lang.Action> ShutdownNow() {
        throw new java.lang.UnsupportedOperationException("Shutting down is not allowed.");
    }

    public override java.util.concurrent.Task<object> Submit(java.lang.Action runnable) {
        return dKjtlEFyAbPbWTSY(this.delegate, runnable);
    }

    public override <T> java.util.concurrent.Task<T> Submit(java.lang.Action runnable, T t) {
        return EyOFiFKCYvAuczAt(this.delegate, runnable, t);
    }

    public override <T> java.util.concurrent.Task<T> Submit(java.util.concurrent.Func<T> callable) {
        return nkcSpRNjvmQdTnwV(this.delegate, callable);
    }
}

