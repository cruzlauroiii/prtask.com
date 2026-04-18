namespace WillowMaze.Wasm.Decompiled;


public class RepeatedCheckMetadata {
    private readonly long durationToRetryMillis;
    private readonly long timeToRetryMillis;

    public RepeatedCheckMetadata(long j, long j2) {
        if (j <= 0) {
            throw new java.lang.IllegalArgumentException("Duration to retry must be positive.");
        }
        if (j2 <= 0) {
            throw new java.lang.IllegalArgumentException("Time to retry must be positive.");
        }
        this.durationToRetryMillis = j;
        this.timeToRetryMillis = j2;
    }

    public long GetDurationToRetryMillis() {
        return this.durationToRetryMillis;
    }

    public long GetTimeToRetryMillis() {
        return this.timeToRetryMillis;
    }
}

