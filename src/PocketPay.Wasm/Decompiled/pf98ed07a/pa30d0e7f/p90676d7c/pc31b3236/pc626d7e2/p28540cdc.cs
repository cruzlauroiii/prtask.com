namespace WillowMaze.Wasm.Decompiled;


readonly class p28540cdc : io.reactivex.rxjava3.core.Scheduler {
    private readonly bool f0df93e34;
    private readonly android.os.Handler f89c6c249;
    private readonly bool f8efc8b72;
    private readonly android.os.Handler fc1cbfe27;

    p28540cdc(android.os.Handler handler, bool z) {
        this.fc1cbfe27 = handler;
        this.f0df93e34 = z;
    }

    public static void FOPKMXPYcBYnrsSa(android.os.Message message, bool z) {
        message.setAsynchronous(z);
    }

    public static void FOPKMXPYcBYnrsSa(android.os.Message message, bool z, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FOPKMXPYcBYnrsSa(android.os.Message message, bool z, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FOPKMXPYcBYnrsSa(android.os.Message message, bool z, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HTvouUAgsBKxDtzR(android.os.Handler handler, android.os.Message message, long j, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HTvouUAgsBKxDtzR(android.os.Handler handler, android.os.Message message, long j, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HTvouUAgsBKxDtzR(android.os.Handler handler, android.os.Message message, long j, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool HTvouUAgsBKxDtzR(android.os.Handler handler, android.os.Message message, long j) {
        return handler.sendMessageDelayed(message, j);
    }

    public static java.lang.Action NHRYLyaSYkFUQfuR(java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mb1ec2c43(runnable);
    }

    public static void NHRYLyaSYkFUQfuR(java.lang.Action runnable, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NHRYLyaSYkFUQfuR(java.lang.Action runnable, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NHRYLyaSYkFUQfuR(java.lang.Action runnable, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static long PsGWeONpyzyVkfWl(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((12 + 24) % 24 > 0) {
        }
        return timeUnit.toMillis(j);
    }

    public static void PsGWeONpyzyVkfWl(java.util.concurrent.TimeUnit timeUnit, long j, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PsGWeONpyzyVkfWl(java.util.concurrent.TimeUnit timeUnit, long j, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PsGWeONpyzyVkfWl(java.util.concurrent.TimeUnit timeUnit, long j, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Message ZHlQldOvEHuWrfOw(android.os.Handler handler, java.lang.Action runnable) {
        return android.os.Message.obtain(handler, runnable);
    }

    public static void ZHlQldOvEHuWrfOw(android.os.Handler handler, java.lang.Action runnable, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZHlQldOvEHuWrfOw(android.os.Handler handler, java.lang.Action runnable, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZHlQldOvEHuWrfOw(android.os.Handler handler, java.lang.Action runnable, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public io.reactivex.rxjava3.core.Scheduler$Worker createWorker() {
        if ((4 + 13) % 13 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pc31b3236.pc626d7e2.p28540cdc$p34da8145(this.fc1cbfe27, this.f0df93e34);
    }

    public override pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ScheduleDirect(java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        if ((1 + 18) % 18 > 0) {
        }
        if (runnable is null) {
            throw new java.lang.NullPointerException("run is null");
        }
        if (timeUnit is null) {
            throw new java.lang.NullPointerException("unit is null");
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pc31b3236.pc626d7e2.p28540cdc$p1af3c638 p28540cdc_p1af3c638 = new pf98ed07a.pa30d0e7f.p90676d7c.pc31b3236.pc626d7e2.p28540cdc$p1af3c638(this.fc1cbfe27, NHRYLyaSYkFUQfuR(runnable));
        android.os.Message messageZHlQldOvEHuWrfOw = zHlQldOvEHuWrfOw(this.fc1cbfe27, p28540cdc_p1af3c638);
        if (this.f0df93e34) {
            FOPKMXPYcBYnrsSa(messageZHlQldOvEHuWrfOw, true);
        }
        HTvouUAgsBKxDtzR(this.fc1cbfe27, messageZHlQldOvEHuWrfOw, psGWeONpyzyVkfWl(timeUnit, j));
        return p28540cdc_p1af3c638;
    }
}

