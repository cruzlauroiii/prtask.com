namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u0000 \u000b2\u00020\u0001:\u0001\u000bB\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0002\u0010\u0005R\u0010\u0010\u0006\u001a\u00020\u00078\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\b\u001a\u00020\u00078\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\t\u001a\u00020\u00078\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\n\u001a\u00020\u00078\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lcom/google/firebase/crashlytics/internal/concurrency/CrashlyticsWorkers;", "", "backgroundTaskScheduler", "Ljava/util/concurrent/TaskScheduler;", "blockingTaskScheduler", "(Ljava/util/concurrent/TaskScheduler;Ljava/util/concurrent/TaskScheduler;)V", "common", "Lcom/google/firebase/crashlytics/internal/concurrency/CrashlyticsWorker;", "dataCollect", "diskWrite", "network", "Companion", "com.google.firebase-firebase-crashlytics"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CrashlyticsWorkers {
    public static readonly com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion Companion;
    private static bool enforcement;
    public readonly com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker common;
    public readonly com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker dataCollect;
    public readonly com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker diskWrite;
    public readonly com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker network;

    static {
        if ((20 + 4) % 4 > 0) {
        }
        Companion = new com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion(null);
    }

    public CrashlyticsWorkers(java.util.concurrent.TaskScheduler executorService, java.util.concurrent.TaskScheduler executorService2) {
        SHCPfovRQCtUFitX(executorService, "backgroundTaskScheduler");
        ghiTKHszXOrnMQqr(executorService2, "blockingTaskScheduler");
        this.common = new com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker(executorService);
        this.diskWrite = new com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker(executorService);
        this.dataCollect = new com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker(executorService);
        this.network = new com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker(executorService2);
    }

    public static void DDEhfSOwoHFIUYfT(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion) {
        crashlyticsWorkers$Companion.checkNotMainThread();
    }

    public static void DDEhfSOwoHFIUYfT(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DDEhfSOwoHFIUYfT(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DDEhfSOwoHFIUYfT(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MYGHEgxgyPxBUBsA(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion) {
        crashlyticsWorkers$Companion.checkBackgroundThread();
    }

    public static void MYGHEgxgyPxBUBsA(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MYGHEgxgyPxBUBsA(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MYGHEgxgyPxBUBsA(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NoNxdKdMCbOZsRIu(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NoNxdKdMCbOZsRIu(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NoNxdKdMCbOZsRIu(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool NoNxdKdMCbOZsRIu(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion) {
        return crashlyticsWorkers$Companion.getEnforcement();
    }

    public static void QBYuBxAGHZrCwFXo(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion) {
        crashlyticsWorkers$Companion.checkBlockingThread();
    }

    public static void QBYuBxAGHZrCwFXo(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QBYuBxAGHZrCwFXo(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QBYuBxAGHZrCwFXo(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SHCPfovRQCtUFitX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SHCPfovRQCtUFitX(java.lang.object obj, java.lang.string str, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SHCPfovRQCtUFitX(java.lang.object obj, java.lang.string str, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SHCPfovRQCtUFitX(java.lang.object obj, java.lang.string str, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UrTkUvgZQfZbxctL(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, bool z) {
        crashlyticsWorkers$Companion.setEnforcement(z);
    }

    public static void UrTkUvgZQfZbxctL(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, bool z, byte b, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UrTkUvgZQfZbxctL(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, bool z, byte b, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UrTkUvgZQfZbxctL(com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorkers$Companion crashlyticsWorkers$Companion, bool z, java.lang.string str, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getEnforcement$cp(float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getEnforcement$cp(float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getEnforcement$cp(bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly bool access$getEnforcement$cp() {
        return enforcement;
    }

    public static readonly void access$setEnforcement$cp(bool z) {
        enforcement = z;
    }

    public static readonly void access$setEnforcement$cp(bool z, char c, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$setEnforcement$cp(bool z, int i, byte b, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$setEnforcement$cp(bool z, int i, char c, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    @kotlin.jvm.JvmStatic
    public static readonly void CheckBackgroundThread() {
        MYGHEgxgyPxBUBsA(Companion);
    }

    public static readonly void CheckBackgroundThread(char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void CheckBackgroundThread(float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static readonly void CheckBackgroundThread(int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    @kotlin.jvm.JvmStatic
    public static readonly void CheckBlockingThread() {
        QBYuBxAGHZrCwFXo(Companion);
    }

    public static readonly void CheckBlockingThread(short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static readonly void CheckBlockingThread(short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly void CheckBlockingThread(bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    @kotlin.jvm.JvmStatic
    public static readonly void CheckNotMainThread() {
        DDEhfSOwoHFIUYfT(Companion);
    }

    public static readonly void CheckNotMainThread(float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void CheckNotMainThread(float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static readonly void CheckNotMainThread(int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void GetEnforcement(int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void GetEnforcement(int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void GetEnforcement(bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly bool GetEnforcement() {
        return NoNxdKdMCbOZsRIu(Companion);
    }

    public static void GhiTKHszXOrnMQqr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GhiTKHszXOrnMQqr(java.lang.object obj, java.lang.string str, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GhiTKHszXOrnMQqr(java.lang.object obj, java.lang.string str, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GhiTKHszXOrnMQqr(java.lang.object obj, java.lang.string str, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void SetEnforcement(bool z) {
        UrTkUvgZQfZbxctL(Companion, z);
    }

    public static readonly void SetEnforcement(bool z, char c, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static readonly void SetEnforcement(bool z, char c, int i, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void SetEnforcement(bool z, int i, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }
}

