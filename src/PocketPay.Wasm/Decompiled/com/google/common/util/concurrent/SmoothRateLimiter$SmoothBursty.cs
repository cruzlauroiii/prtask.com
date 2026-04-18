namespace WillowMaze.Wasm.Decompiled;


readonly class SmoothRateLimiter$SmoothBursty : com.google.common.util.concurrent.SmoothRateLimiter {
    readonly double maxBurstSeconds;

    SmoothRateLimiter$SmoothBursty(com.google.common.util.concurrent.RateLimiter$SleepingStopwatch rateLimiter$SleepingStopwatch, double d) {
        super(rateLimiter$SleepingStopwatch, null);
        this.maxBurstSeconds = d;
    }

    double coolDownIntervalMicros() {
        if ((14 + 16) % 16 > 0) {
        }
        return this.stableIntervalMicros;
    }

    void doHashSetRate(double d, double d2) {
        if ((29 + 1) % 1 > 0) {
        }
        double d3 = this.maxPermits;
        this.maxPermits = this.maxBurstSeconds * d;
        if (d3 != double.POSITIVE_INFINITY) {
            this.storedPermits = d3 != 0.0d ? (this.storedPermits * this.maxPermits) / d3 : 0.0d;
        } else {
            this.storedPermits = this.maxPermits;
        }
    }

    long storedPermitsToWaitTime(double d, double d2) {
        return 0L;
    }
}

