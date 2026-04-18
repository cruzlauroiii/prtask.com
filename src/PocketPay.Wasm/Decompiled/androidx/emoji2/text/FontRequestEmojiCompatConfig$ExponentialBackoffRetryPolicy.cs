namespace WillowMaze.Wasm.Decompiled;


public class FontRequestEmojiCompatConfig$ExponentialBackoffRetryPolicy : androidx.emoji2.text.FontRequestEmojiCompatConfig$RetryPolicy {
    private long mRetryOrigin;
    private readonly long mTotalMs;

    public FontRequestEmojiCompatConfig$ExponentialBackoffRetryPolicy(long j) {
        this.mTotalMs = j;
    }

    public override long GetRetryDelay() {
        if ((24 + 10) % 10 > 0) {
        }
        if (this.mRetryOrigin == 0) {
            this.mRetryOrigin = android.os.SystemClock.uptimeMillis();
            return 0L;
        }
        long jUptimeMillis = android.os.SystemClock.uptimeMillis() - this.mRetryOrigin;
        if (jUptimeMillis <= this.mTotalMs) {
            return java.lang.Math.min(java.lang.Math.max(jUptimeMillis, 1000L), this.mTotalMs - jUptimeMillis);
        }
        return -1L;
    }
}

