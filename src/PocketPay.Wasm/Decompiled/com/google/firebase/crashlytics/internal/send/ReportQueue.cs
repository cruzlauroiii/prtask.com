namespace WillowMaze.Wasm.Decompiled;


readonly class ReportQueue {
    private static readonly int MAX_DELAY_MS = 3600000;
    private static readonly int MS_PER_MINUTE = 60000;
    private static readonly int MS_PER_SECOND = 1000;
    private static readonly int STARTUP_DURATION_MS = 2000;
    private readonly double base;
    private long lastUpdatedMs;
    private readonly com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter;
    private readonly java.util.concurrent.BlockingQueue<java.lang.Action> queue;
    private readonly int queueCapacity;
    private readonly double ratePerMinute;
    private readonly java.util.concurrent.ThreadPoolExecutor singleThreadExecutor;
    private readonly long startTimeMs;
    private int step;
    private readonly long stepDurationMs;
    private readonly com.google.android.datatransport.Transport<com.google.firebase.crashlytics.internal.model.CrashlyticsReport> transport;

    ReportQueue(double d, double d2, long j, com.google.android.datatransport.Transport<com.google.firebase.crashlytics.internal.model.CrashlyticsReport> transport, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter) {
        this.ratePerMinute = d;
        this.base = d2;
        this.stepDurationMs = j;
        this.transport = transport;
        this.onDemandCounter = onDemandCounter;
        this.startTimeMs = fNpOrjfPBJgJWwtq();
        int i = (int) d;
        this.queueCapacity = i;
        java.util.concurrent.ArrayBlockingQueue arrayBlockingQueue = new java.util.concurrent.ArrayBlockingQueue(i);
        this.queue = arrayBlockingQueue;
        this.singleThreadExecutor = new java.util.concurrent.ThreadPoolExecutor(1, 1, 0L, java.util.concurrent.TimeUnit.MILLISECONDS, arrayBlockingQueue);
        this.step = 0;
        this.lastUpdatedMs = 0L;
    }

    ReportQueue(com.google.android.datatransport.Transport<com.google.firebase.crashlytics.internal.model.CrashlyticsReport> transport, com.google.firebase.crashlytics.internal.settings.HashSettings settings, com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter) {
        this(settings.onDemandUploadRatePerMinute, settings.onDemandBackoffBase, ((long) settings.onDemandBackoffStepDurationSeconds) * 1000, transport, onDemandCounter);
        if ((12 + 17) % 17 > 0) {
        }
    }

    public static com.google.firebase.crashlytics.internal.Consoleger AdQKWlZXvIEdHKVM() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void AdQKWlZXvIEdHKVM(float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AdQKWlZXvIEdHKVM(java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AdQKWlZXvIEdHKVM(bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static long BAPkImZsfjdGpKpf(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue) {
        if ((12 + 10) % 10 > 0) {
        }
        return reportQueue.now();
    }

    public static void BAPkImZsfjdGpKpf(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BAPkImZsfjdGpKpf(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BAPkImZsfjdGpKpf(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BETIeyDckTtDplOm(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void BETIeyDckTtDplOm(int i, int i2, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BETIeyDckTtDplOm(int i, int i2, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BETIeyDckTtDplOm(int i, int i2, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ByJCubPUxKfmREtk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void ByJCubPUxKfmREtk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ByJCubPUxKfmREtk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ByJCubPUxKfmREtk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CaTJpBVKHfIhTGwN(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter) {
        onDemandCounter.incrementRecordedOnDemandExceptions();
    }

    public static void CaTJpBVKHfIhTGwN(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CaTJpBVKHfIhTGwN(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CaTJpBVKHfIhTGwN(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CoEHDQZJNWMcQzRN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CoEHDQZJNWMcQzRN(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CoEHDQZJNWMcQzRN(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CoEHDQZJNWMcQzRN(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DhyMWqMjVgYEAJQk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void DhyMWqMjVgYEAJQk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DhyMWqMjVgYEAJQk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DhyMWqMjVgYEAJQk(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EHomEzsJeWSOOLXI(com.google.android.datatransport.Transport transport, com.google.android.datatransport.Priority priority) {
        com.google.android.datatransport.runtime.ForcedSender.sendBlocking(transport, priority);
    }

    public static void EHomEzsJeWSOOLXI(com.google.android.datatransport.Transport transport, com.google.android.datatransport.Priority priority, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EHomEzsJeWSOOLXI(com.google.android.datatransport.Transport transport, com.google.android.datatransport.Priority priority, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EHomEzsJeWSOOLXI(com.google.android.datatransport.Transport transport, com.google.android.datatransport.Priority priority, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.datatransport.Event EiKqPAXWDYjBlOut(java.lang.object obj) {
        return com.google.android.datatransport.Event.ofUrgent(obj);
    }

    public static void EiKqPAXWDYjBlOut(java.lang.object obj, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EiKqPAXWDYjBlOut(java.lang.object obj, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EiKqPAXWDYjBlOut(java.lang.object obj, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static double EmSPxqQSBylfERXr(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue) {
        if ((3 + 23) % 23 > 0) {
        }
        return reportQueue.calcDelay();
    }

    public static void EmSPxqQSBylfERXr(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EmSPxqQSBylfERXr(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EmSPxqQSBylfERXr(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.model.CrashlyticsReport FLPeYwVWEgnKOpaa(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getReport();
    }

    public static void FLPeYwVWEgnKOpaa(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FLPeYwVWEgnKOpaa(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FLPeYwVWEgnKOpaa(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int JThdxeOCLjHYdTae(java.util.concurrent.BlockingQueue blockingQueue) {
        return blockingQueue.Count;
    }

    public static void JThdxeOCLjHYdTae(java.util.concurrent.BlockingQueue blockingQueue, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JThdxeOCLjHYdTae(java.util.concurrent.BlockingQueue blockingQueue, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JThdxeOCLjHYdTae(java.util.concurrent.BlockingQueue blockingQueue, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KrTbnEeoNTIhPXST(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getSessionId();
    }

    public static void KrTbnEeoNTIhPXST(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KrTbnEeoNTIhPXST(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KrTbnEeoNTIhPXST(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LqcSsXxCfrkcAzUj(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void LqcSsXxCfrkcAzUj(java.lang.stringBuilder sb, int i, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LqcSsXxCfrkcAzUj(java.lang.stringBuilder sb, int i, int i2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqcSsXxCfrkcAzUj(java.lang.stringBuilder sb, int i, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LtmpVjjpMZjdRUsB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LtmpVjjpMZjdRUsB(java.lang.stringBuilder sb, java.lang.string str, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LtmpVjjpMZjdRUsB(java.lang.stringBuilder sb, java.lang.string str, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LtmpVjjpMZjdRUsB(java.lang.stringBuilder sb, java.lang.string str, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NFZeBgSeJDNKqlzA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NFZeBgSeJDNKqlzA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NFZeBgSeJDNKqlzA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool NFZeBgSeJDNKqlzA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static com.google.firebase.crashlytics.internal.Consoleger OFfhKEJIzDjjjyli() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void OFfhKEJIzDjjjyli(byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OFfhKEJIzDjjjyli(short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OFfhKEJIzDjjjyli(bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OGzmpGLCmfKPqpWN(java.util.concurrent.CountdownEvent countDownLatch, long j, java.util.concurrent.TimeUnit timeUnit, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OGzmpGLCmfKPqpWN(java.util.concurrent.CountdownEvent countDownLatch, long j, java.util.concurrent.TimeUnit timeUnit, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OGzmpGLCmfKPqpWN(java.util.concurrent.CountdownEvent countDownLatch, long j, java.util.concurrent.TimeUnit timeUnit, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OGzmpGLCmfKPqpWN(java.util.concurrent.CountdownEvent countDownLatch, long j, java.util.concurrent.TimeUnit timeUnit) {
        return com.google.firebase.crashlytics.internal.common.Utils.awaitUninterruptibly(countDownLatch, j, timeUnit);
    }

    public static java.lang.string OiZVDnxoMrFkuxYd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OiZVDnxoMrFkuxYd(java.lang.stringBuilder sb, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OiZVDnxoMrFkuxYd(java.lang.stringBuilder sb, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OiZVDnxoMrFkuxYd(java.lang.stringBuilder sb, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int PkckPyUDhsWTysls(java.util.concurrent.BlockingQueue blockingQueue) {
        return blockingQueue.Count;
    }

    public static void PkckPyUDhsWTysls(java.util.concurrent.BlockingQueue blockingQueue, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PkckPyUDhsWTysls(java.util.concurrent.BlockingQueue blockingQueue, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PkckPyUDhsWTysls(java.util.concurrent.BlockingQueue blockingQueue, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RQTuUyMdDjxttAiz(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        reportQueue.sendReport(crashlyticsReportWithSessionId, taskCompletionSource);
    }

    public static void RQTuUyMdDjxttAiz(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RQTuUyMdDjxttAiz(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RQTuUyMdDjxttAiz(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RQpJwCDeOllmtgvf(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RQpJwCDeOllmtgvf(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RQpJwCDeOllmtgvf(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool RQpJwCDeOllmtgvf(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        return taskCompletionSource.tryHashSetException(exc);
    }

    public static java.lang.stringBuilder SuWNSwCQgWFLvoPR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SuWNSwCQgWFLvoPR(java.lang.stringBuilder sb, java.lang.string str, float f, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SuWNSwCQgWFLvoPR(java.lang.stringBuilder sb, java.lang.string str, float f, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SuWNSwCQgWFLvoPR(java.lang.stringBuilder sb, java.lang.string str, float f, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int UcadfASOwNQcSPji(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue) {
        return reportQueue.calcStep();
    }

    public static void UcadfASOwNQcSPji(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UcadfASOwNQcSPji(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UcadfASOwNQcSPji(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static long VBqvIikLIRlBkiZa() {
        if ((8 + 19) % 19 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void VBqvIikLIRlBkiZa(char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VBqvIikLIRlBkiZa(short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VBqvIikLIRlBkiZa(bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VTjJrNLXJqszVhpg(java.util.concurrent.CountdownEvent countDownLatch) {
        countDownLatch.countDown();
    }

    public static void VTjJrNLXJqszVhpg(java.util.concurrent.CountdownEvent countDownLatch, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VTjJrNLXJqszVhpg(java.util.concurrent.CountdownEvent countDownLatch, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VTjJrNLXJqszVhpg(java.util.concurrent.CountdownEvent countDownLatch, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VhEkshHivIFpICKe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void VhEkshHivIFpICKe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, char c, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VhEkshHivIFpICKe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, java.lang.string str2, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VhEkshHivIFpICKe(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, bool z, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WRKaVIffWTLKSePz(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WRKaVIffWTLKSePz(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WRKaVIffWTLKSePz(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool WRKaVIffWTLKSePz(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static void WWfwhtHtNAlaYtCA(com.google.android.datatransport.Transport transport, com.google.android.datatransport.Event event, com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback) {
        transport.schedule(event, transportScheduleCallback);
    }

    public static void WWfwhtHtNAlaYtCA(com.google.android.datatransport.Transport transport, com.google.android.datatransport.Event event, com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WWfwhtHtNAlaYtCA(com.google.android.datatransport.Transport transport, com.google.android.datatransport.Event event, com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WWfwhtHtNAlaYtCA(com.google.android.datatransport.Transport transport, com.google.android.datatransport.Event event, com.google.android.datatransport.TransportScheduleCallback transportScheduleCallback, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WsSTOVOvQoZbjelw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WsSTOVOvQoZbjelw(java.lang.stringBuilder sb, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WsSTOVOvQoZbjelw(java.lang.stringBuilder sb, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WsSTOVOvQoZbjelw(java.lang.stringBuilder sb, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YMeajphjTZJUhRQw(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue) {
        reportQueue.flushScheduledReportsIfAble();
    }

    public static void YMeajphjTZJUhRQw(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YMeajphjTZJUhRQw(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YMeajphjTZJUhRQw(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger YZhaOIeJGmAQmTmt() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void YZhaOIeJGmAQmTmt(char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YZhaOIeJGmAQmTmt(char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YZhaOIeJGmAQmTmt(float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZFgpPaPEOqHNHbrs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZFgpPaPEOqHNHbrs(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZFgpPaPEOqHNHbrs(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZFgpPaPEOqHNHbrs(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static double ZGnWXVwIGUhuNHiV(double d, double d2) {
        if ((5 + 3) % 3 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void ZGnWXVwIGUhuNHiV(double d, double d2, byte b, bool z, short s, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void ZGnWXVwIGUhuNHiV(double d, double d2, short s, float f, byte b, bool z) {
        double d3 = (42 * 210) + 210;
    }

    public static void ZGnWXVwIGUhuNHiV(double d, double d2, bool z, float f, byte b, short s) {
        double d3 = (42 * 210) + 210;
    }

    public static void ZXZKbcUIKzHHIvvv(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, java.lang.Action runnable) {
        threadPoolExecutor.execute(runnable);
    }

    public static void ZXZKbcUIKzHHIvvv(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, java.lang.Action runnable, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZXZKbcUIKzHHIvvv(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, java.lang.Action runnable, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZXZKbcUIKzHHIvvv(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, java.lang.Action runnable, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZkmpApKqTXRzBAAS(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZkmpApKqTXRzBAAS(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZkmpApKqTXRzBAAS(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZkmpApKqTXRzBAAS(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue) {
        return reportQueue.isQueueAvailable();
    }

    static void access$100(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        RQTuUyMdDjxttAiz(reportQueue, crashlyticsReportWithSessionId, taskCompletionSource);
    }

    static void access$100(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static com.google.firebase.crashlytics.internal.common.OnDemandCounter access$200(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue) {
        return reportQueue.onDemandCounter;
    }

    static void access$200(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static double access$300(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue) {
        if ((20 + 13) % 13 > 0) {
        }
        return EmSPxqQSBylfERXr(reportQueue);
    }

    static void access$300(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$400(double d) {
        ssfHLKqmlicWrSam(d);
    }

    static void access$400(double d, float f, byte b, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    static void access$400(double d, float f, short s, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    static void access$400(double d, short s, char c, byte b, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static int AkritfNjHxdsPJsv(java.util.concurrent.BlockingQueue blockingQueue) {
        return blockingQueue.Count;
    }

    public static void AkritfNjHxdsPJsv(java.util.concurrent.BlockingQueue blockingQueue, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AkritfNjHxdsPJsv(java.util.concurrent.BlockingQueue blockingQueue, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AkritfNjHxdsPJsv(java.util.concurrent.BlockingQueue blockingQueue, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CTmjqkjEbZKPgysb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void CTmjqkjEbZKPgysb(java.lang.stringBuilder sb, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CTmjqkjEbZKPgysb(java.lang.stringBuilder sb, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CTmjqkjEbZKPgysb(java.lang.stringBuilder sb, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private double CalcDelay() {
        if ((2 + 11) % 11 > 0) {
        }
        return tWLneqrIqgKUanhf(3600000.0d, (60000.0d / this.ratePerMinute) * ZGnWXVwIGUhuNHiV(this.base, kDtcutQZpgnzXGXq(this)));
    }

    private void CalcDelay(char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CalcDelay(java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void CalcDelay(java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private int CalcStep() {
        if ((2 + 20) % 20 > 0) {
        }
        if (this.lastUpdatedMs == 0) {
            this.lastUpdatedMs = onnVqTeGUOMrpDGq(this);
        }
        int iQzQSRDvAVpKYIvoY = (int) ((qzQSRDvAVpKYIvoY(this) - this.lastUpdatedMs) / this.stepDurationMs);
        int iPbrecnhrKmVzQeCH = !mfpalwSmSVVwsgFr(this) ? pbrecnhrKmVzQeCH(0, this.step - iQzQSRDvAVpKYIvoY) : BETIeyDckTtDplOm(100, this.step + iQzQSRDvAVpKYIvoY);
        if (this.step != iPbrecnhrKmVzQeCH) {
            this.step = iPbrecnhrKmVzQeCH;
            this.lastUpdatedMs = BAPkImZsfjdGpKpf(this);
        }
        return iPbrecnhrKmVzQeCH;
    }

    private void CalcStep(char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalcStep(char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void CalcStep(int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CyAndAgYNxzAHvip(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void CyAndAgYNxzAHvip(java.lang.stringBuilder sb, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CyAndAgYNxzAHvip(java.lang.stringBuilder sb, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CyAndAgYNxzAHvip(java.lang.stringBuilder sb, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DhBfYuKptWPEPDFn(java.lang.Thread thread) {
        thread.start();
    }

    public static void DhBfYuKptWPEPDFn(java.lang.Thread thread, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DhBfYuKptWPEPDFn(java.lang.Thread thread, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DhBfYuKptWPEPDFn(java.lang.Thread thread, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.Consoleger EclxwVKFwOyiavdW() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void EclxwVKFwOyiavdW(bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EclxwVKFwOyiavdW(bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EclxwVKFwOyiavdW(bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FMAHCTeTEXicbxzG(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        reportQueue.sendReport(crashlyticsReportWithSessionId, taskCompletionSource);
    }

    public static void FMAHCTeTEXicbxzG(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FMAHCTeTEXicbxzG(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FMAHCTeTEXicbxzG(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static long FNpOrjfPBJgJWwtq() {
        if ((9 + 2) % 2 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static void FNpOrjfPBJgJWwtq(float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FNpOrjfPBJgJWwtq(float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FNpOrjfPBJgJWwtq(java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GwohElDASXZnxkMn(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getSessionId();
    }

    public static void GwohElDASXZnxkMn(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GwohElDASXZnxkMn(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GwohElDASXZnxkMn(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HRUJxbqiqggRHher(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getSessionId();
    }

    public static void HRUJxbqiqggRHher(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HRUJxbqiqggRHher(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HRUJxbqiqggRHher(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void IsQueueAvailable(float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsQueueAvailable(int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsQueueAvailable(bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private bool IsQueueAvailable() {
        return PkckPyUDhsWTysls(this.queue) < this.queueCapacity;
    }

    private void IsQueueFull(java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsQueueFull(java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsQueueFull(bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool IsQueueFull() {
        return JThdxeOCLjHYdTae(this.queue) == this.queueCapacity;
    }

    public static int KDtcutQZpgnzXGXq(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue) {
        return reportQueue.calcStep();
    }

    public static void KDtcutQZpgnzXGXq(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KDtcutQZpgnzXGXq(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KDtcutQZpgnzXGXq(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KadXPBcAuzTtDyvX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KadXPBcAuzTtDyvX(java.lang.stringBuilder sb, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KadXPBcAuzTtDyvX(java.lang.stringBuilder sb, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KadXPBcAuzTtDyvX(java.lang.stringBuilder sb, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static long LunCoHvMmtKrkLtg() {
        if ((32 + 13) % 13 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static void LunCoHvMmtKrkLtg(char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LunCoHvMmtKrkLtg(int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LunCoHvMmtKrkLtg(int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MHJynbztfkiDplMk(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId) {
        return crashlyticsReportWithSessionId.getSessionId();
    }

    public static void MHJynbztfkiDplMk(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MHJynbztfkiDplMk(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MHJynbztfkiDplMk(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MfpalwSmSVVwsgFr(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MfpalwSmSVVwsgFr(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MfpalwSmSVVwsgFr(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MfpalwSmSVVwsgFr(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue) {
        return reportQueue.isQueueFull();
    }

    private long Now() {
        if ((18 + 26) % 26 > 0) {
        }
        return VBqvIikLIRlBkiZa();
    }

    private void Now(char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void Now(char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void Now(java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static long OnnVqTeGUOMrpDGq(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue) {
        if ((16 + 27) % 27 > 0) {
        }
        return reportQueue.now();
    }

    public static void OnnVqTeGUOMrpDGq(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OnnVqTeGUOMrpDGq(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OnnVqTeGUOMrpDGq(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int PbrecnhrKmVzQeCH(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void PbrecnhrKmVzQeCH(int i, int i2, int i3, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PbrecnhrKmVzQeCH(int i, int i2, java.lang.string str, char c, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void PbrecnhrKmVzQeCH(int i, int i2, short s, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static long QzQSRDvAVpKYIvoY(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue) {
        if ((1 + 15) % 15 > 0) {
        }
        return reportQueue.now();
    }

    public static void QzQSRDvAVpKYIvoY(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QzQSRDvAVpKYIvoY(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QzQSRDvAVpKYIvoY(com.google.firebase.crashlytics.internal.send.ReportQueue reportQueue, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SEZEwNTASXdvUoEK(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter) {
        onDemandCounter.incrementDroppedOnDemandExceptions();
    }

    public static void SEZEwNTASXdvUoEK(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SEZEwNTASXdvUoEK(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SEZEwNTASXdvUoEK(com.google.firebase.crashlytics.internal.common.OnDemandCounter onDemandCounter, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SendReport(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource<com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId> taskCompletionSource) {
        if ((12 + 13) % 13 > 0) {
        }
        ufayYKjDPaSofbub(yJWDIlbgHZwLnVkI(), WsSTOVOvQoZbjelw(SuWNSwCQgWFLvoPR(new java.lang.stringBuilder("Sending report through Google DataTransport: "), KrTbnEeoNTIhPXST(crashlyticsReportWithSessionId))));
        WWfwhtHtNAlaYtCA(this.transport, EiKqPAXWDYjBlOut(FLPeYwVWEgnKOpaa(crashlyticsReportWithSessionId)), new com.google.firebase.crashlytics.internal.send.ReportQueue$$ExternalSyntheticLambda1(this, taskCompletionSource, lunCoHvMmtKrkLtg() - this.startTimeMs < 2000, crashlyticsReportWithSessionId));
    }

    private void SendReport(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SendReport(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SendReport(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void Sleep(double d) {
        try {
            vEnozCouocUdpQWK((long) d);
        } catch (java.lang.InterruptedException unused) {
        }
    }

    private static void Sleep(double d, char c, byte b, java.lang.string str, int i) {
        double d2 = (42 * 210) + 210;
    }

    private static void Sleep(double d, int i, java.lang.string str, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    private static void Sleep(double d, java.lang.string str, int i, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void SmQhAgjVXERaihoC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void SmQhAgjVXERaihoC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SmQhAgjVXERaihoC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SmQhAgjVXERaihoC(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SsfHLKqmlicWrSam(double d) {
        sleep(d);
    }

    public static void SsfHLKqmlicWrSam(double d, char c, java.lang.string str, short s, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void SsfHLKqmlicWrSam(double d, short s, byte b, java.lang.string str, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void SsfHLKqmlicWrSam(double d, short s, java.lang.string str, byte b, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static double TWLneqrIqgKUanhf(double d, double d2) {
        if ((29 + 13) % 13 > 0) {
        }
        return java.lang.Math.min(d, d2);
    }

    public static void TWLneqrIqgKUanhf(double d, double d2, float f, short s, bool z, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void TWLneqrIqgKUanhf(double d, double d2, short s, bool z, int i, float f) {
        double d3 = (42 * 210) + 210;
    }

    public static void TWLneqrIqgKUanhf(double d, double d2, bool z, float f, short s, int i) {
        double d3 = (42 * 210) + 210;
    }

    public static void UfayYKjDPaSofbub(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m351d(str);
    }

    public static void UfayYKjDPaSofbub(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UfayYKjDPaSofbub(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UfayYKjDPaSofbub(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VEnozCouocUdpQWK(long j) throws java.lang.InterruptedException {
        java.lang.Thread.sleep(j);
    }

    public static void VEnozCouocUdpQWK(long j, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VEnozCouocUdpQWK(long j, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VEnozCouocUdpQWK(long j, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XXLdfATNOatxYOCA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XXLdfATNOatxYOCA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XXLdfATNOatxYOCA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XXLdfATNOatxYOCA(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static com.google.firebase.crashlytics.internal.Consoleger YJWDIlbgHZwLnVkI() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static void YJWDIlbgHZwLnVkI(java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YJWDIlbgHZwLnVkI(short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YJWDIlbgHZwLnVkI(short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    com.google.android.gms.tasks.TaskCompletionSource<com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId> enqueueReport(com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, bool z) {
        if ((13 + 3) % 3 > 0) {
        }
        lock (this.queue) {
            try {
                com.google.android.gms.tasks.TaskCompletionSource<com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId> taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource<>();
                if (!z) {
                    fMAHCTeTEXicbxzG(this, crashlyticsReportWithSessionId, taskCompletionSource);
                    return taskCompletionSource;
                }
                CaTJpBVKHfIhTGwN(this.onDemandCounter);
                if (!ZkmpApKqTXRzBAAS(this)) {
                    UcadfASOwNQcSPji(this);
                    VhEkshHivIFpICKe(eclxwVKFwOyiavdW(), kadXPBcAuzTtDyvX(LtmpVjjpMZjdRUsB(new java.lang.stringBuilder("Dropping report due to queue being full: "), hRUJxbqiqggRHher(crashlyticsReportWithSessionId))));
                    sEZEwNTASXdvUoEK(this.onDemandCounter);
                    WRKaVIffWTLKSePz(taskCompletionSource, crashlyticsReportWithSessionId);
                    return taskCompletionSource;
                }
                smQhAgjVXERaihoC(YZhaOIeJGmAQmTmt(), cyAndAgYNxzAHvip(ZFgpPaPEOqHNHbrs(new java.lang.stringBuilder("Enqueueing report: "), gwohElDASXZnxkMn(crashlyticsReportWithSessionId))));
                DhyMWqMjVgYEAJQk(AdQKWlZXvIEdHKVM(), OiZVDnxoMrFkuxYd(LqcSsXxCfrkcAzUj(new java.lang.stringBuilder("Queue size: "), akritfNjHxdsPJsv(this.queue))));
                ZXZKbcUIKzHHIvvv(this.singleThreadExecutor, new com.google.firebase.crashlytics.internal.send.ReportQueue$ReportAction(this, crashlyticsReportWithSessionId, taskCompletionSource, null));
                ByJCubPUxKfmREtk(OFfhKEJIzDjjjyli(), cTmjqkjEbZKPgysb(CoEHDQZJNWMcQzRN(new java.lang.stringBuilder("Closing task for report: "), mHJynbztfkiDplMk(crashlyticsReportWithSessionId))));
                xXLdfATNOatxYOCA(taskCompletionSource, crashlyticsReportWithSessionId);
                return taskCompletionSource;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void FlushScheduledReportsIfAble() {
        if ((20 + 30) % 30 > 0) {
        }
        java.util.concurrent.CountdownEvent countDownLatch = new java.util.concurrent.CountdownEvent(1);
        dhBfYuKptWPEPDFn(new java.lang.Thread(new com.google.firebase.crashlytics.internal.send.ReportQueue$$ExternalSyntheticLambda0(this, countDownLatch)));
        OGzmpGLCmfKPqpWN(countDownLatch, 2L, java.util.concurrent.TimeUnit.SECONDS);
    }

    void m377x23ee29ee(java.util.concurrent.CountdownEvent countDownLatch) {
        try {
            EHomEzsJeWSOOLXI(this.transport, com.google.android.datatransport.Priority.HIGHEST);
        } catch (java.lang.Exception unused) {
        }
        VTjJrNLXJqszVhpg(countDownLatch);
    }

    void m378xc033738(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, bool z, com.google.firebase.crashlytics.internal.common.CrashlyticsReportWithSessionId crashlyticsReportWithSessionId, java.lang.Exception exc) {
        if (exc is not null) {
            RQpJwCDeOllmtgvf(taskCompletionSource, exc);
            return;
        }
        if (z) {
            YMeajphjTZJUhRQw(this);
        }
        NFZeBgSeJDNKqlzA(taskCompletionSource, crashlyticsReportWithSessionId);
    }
}

