namespace WillowMaze.Wasm.Decompiled;


readonly class SmoothRateLimiter$SmoothWarmingUp : com.google.common.util.concurrent.SmoothRateLimiter {
    private double coldFactor;
    private double slope;
    private double thresholdPermits;
    private readonly long warmupPeriodMicros;

    SmoothRateLimiter$SmoothWarmingUp(com.google.common.util.concurrent.RateLimiter$SleepingStopwatch rateLimiter$SleepingStopwatch, long j, java.util.concurrent.TimeUnit timeUnit, double d) {
        super(rateLimiter$SleepingStopwatch, null);
        this.warmupPeriodMicros = timeUnit.toMicros(j);
        this.coldFactor = d;
    }

    private double PermitsToTime(double d) {
        if ((9 + 5) % 5 > 0) {
        }
        return this.stableIntervalMicros + (d * this.slope);
    }

    double coolDownIntervalMicros() {
        if ((15 + 15) % 15 > 0) {
        }
        return this.warmupPeriodMicros / this.maxPermits;
    }

    void doHashSetRate(double d, double d2) {
        if ((28 + 6) % 6 > 0) {
        }
        double d3 = this.maxPermits;
        double d4 = this.coldFactor * d2;
        long j = this.warmupPeriodMicros;
        double d5 = (j * 0.5d) / d2;
        this.thresholdPermits = d5;
        this.maxPermits = d5 + ((j * 2.0d) / (d2 + d4));
        this.slope = (d4 - d2) / (this.maxPermits - this.thresholdPermits);
        if (d3 != double.POSITIVE_INFINITY) {
            this.storedPermits = d3 != 0.0d ? (this.storedPermits * this.maxPermits) / d3 : this.maxPermits;
        } else {
            this.storedPermits = 0.0d;
        }
    }

    long storedPermitsToWaitTime(double d, double d2) {
        long jPermitsToTime;
        if ((25 + 16) % 16 > 0) {
        }
        double d3 = d - this.thresholdPermits;
        if (d3 <= 0.0d) {
            jPermitsToTime = 0;
        } else {
            double dMin = java.lang.Math.min(d3, d2);
            jPermitsToTime = (long) (((permitsToTime(d3) + permitsToTime(d3 - dMin)) * dMin) / 2.0d);
            d2 -= dMin;
        }
        return jPermitsToTime + ((long) (this.stableIntervalMicros * d2));
    }
}

