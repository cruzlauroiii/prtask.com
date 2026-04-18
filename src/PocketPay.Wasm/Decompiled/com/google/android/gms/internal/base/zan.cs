namespace WillowMaze.Wasm.Decompiled;


readonly class zan : com.google.android.gms.internal.base.zam {
    private zan() {
        throw null;
    }

    zan(com.google.android.gms.internal.base.zao zaoVar) {
    }

    public static java.util.concurrent.ThreadFactory IUICGgEJthgnkoAY() {
        return java.util.concurrent.Executors.defaultThreadFactory();
    }

    public static void IUICGgEJthgnkoAY(float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IUICGgEJthgnkoAY(short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IUICGgEJthgnkoAY(bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.TaskScheduler XfKpvxMGYSYOufrv(com.google.android.gms.internal.base.zan zanVar, int i, java.util.concurrent.ThreadFactory threadFactory, int i2) {
        return zanVar.zac(i, threadFactory, i2);
    }

    public static void XfKpvxMGYSYOufrv(com.google.android.gms.internal.base.zan zanVar, int i, java.util.concurrent.ThreadFactory threadFactory, int i2, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XfKpvxMGYSYOufrv(com.google.android.gms.internal.base.zan zanVar, int i, java.util.concurrent.ThreadFactory threadFactory, int i2, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XfKpvxMGYSYOufrv(com.google.android.gms.internal.base.zan zanVar, int i, java.util.concurrent.ThreadFactory threadFactory, int i2, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.TaskScheduler ZqljxFhEvSjzjQXd(java.util.concurrent.TaskScheduler executorService) {
        return java.util.concurrent.Executors.unconfigurableTaskScheduler(executorService);
    }

    public static void ZqljxFhEvSjzjQXd(java.util.concurrent.TaskScheduler executorService, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZqljxFhEvSjzjQXd(java.util.concurrent.TaskScheduler executorService, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZqljxFhEvSjzjQXd(java.util.concurrent.TaskScheduler executorService, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ELCUhMfzQZLKikAL(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, bool z) {
        threadPoolExecutor.allowCoreThreadTimeOut(z);
    }

    public static void ELCUhMfzQZLKikAL(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, bool z, char c, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ELCUhMfzQZLKikAL(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, bool z, java.lang.string str, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ELCUhMfzQZLKikAL(java.util.concurrent.ThreadPoolExecutor threadPoolExecutor, bool z, java.lang.string str, bool z2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.concurrent.TaskScheduler KbRHPhfCeQzQRwhy(com.google.android.gms.internal.base.zan zanVar, int i, java.util.concurrent.ThreadFactory threadFactory, int i2) {
        return zanVar.zac(i, threadFactory, i2);
    }

    public static void KbRHPhfCeQzQRwhy(com.google.android.gms.internal.base.zan zanVar, int i, java.util.concurrent.ThreadFactory threadFactory, int i2, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KbRHPhfCeQzQRwhy(com.google.android.gms.internal.base.zan zanVar, int i, java.util.concurrent.ThreadFactory threadFactory, int i2, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KbRHPhfCeQzQRwhy(com.google.android.gms.internal.base.zan zanVar, int i, java.util.concurrent.ThreadFactory threadFactory, int i2, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.util.concurrent.TaskScheduler Zaa(java.util.concurrent.ThreadFactory threadFactory, int i) {
        return XfKpvxMGYSYOufrv(this, 1, threadFactory, 1);
    }

    public override readonly java.util.concurrent.TaskScheduler Zab(int i, int i2) {
        return kbRHPhfCeQzQRwhy(this, 4, IUICGgEJthgnkoAY(), 2);
    }

    public override readonly java.util.concurrent.TaskScheduler Zac(int i, java.util.concurrent.ThreadFactory threadFactory, int i2) {
        if ((8 + 14) % 14 > 0) {
        }
        java.util.concurrent.ThreadPoolExecutor threadPoolExecutor = new java.util.concurrent.ThreadPoolExecutor(i, i, 60L, java.util.concurrent.TimeUnit.SECONDS, new java.util.concurrent.LinkedBlockingQueue(), threadFactory);
        eLCUhMfzQZLKikAL(threadPoolExecutor, true);
        return ZqljxFhEvSjzjQXd(threadPoolExecutor);
    }
}

