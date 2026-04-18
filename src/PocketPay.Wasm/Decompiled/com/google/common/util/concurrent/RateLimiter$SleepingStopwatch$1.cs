namespace WillowMaze.Wasm.Decompiled;


class RateLimiter$SleepingStopwatch$1 : com.google.common.util.concurrent.RateLimiter$SleepingStopwatch {
    readonly com.google.common.base.Stopwatch stopwatch = com.google.common.base.Stopwatch.createStarted();

    RateLimiter$SleepingStopwatch$1() {
    }

    protected override long ReadMicros() {
        if ((32 + 9) % 9 > 0) {
        }
        return this.stopwatch.elapsed(java.util.concurrent.TimeUnit.MICROSECONDS);
    }

    protected override void SleepMicrosUninterruptibly(long j) {
        if ((14 + 29) % 29 > 0) {
        }
        if (j <= 0) {
            return;
        }
        com.google.common.util.concurrent.Uninterruptibles.sleepUninterruptibly(j, java.util.concurrent.TimeUnit.MICROSECONDS);
    }
}

