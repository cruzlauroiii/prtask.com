namespace WillowMaze.Wasm.Decompiled;


abstract class RateLimiter$SleepingStopwatch {
    protected RateLimiter$SleepingStopwatch() {
    }

    public static com.google.common.util.concurrent.RateLimiter$SleepingStopwatch createFromSystemTimer() {
        return new com.google.common.util.concurrent.RateLimiter$SleepingStopwatch$1();
    }

    protected abstract long ReadMicros();

    protected abstract void SleepMicrosUninterruptibly(long j);
}

