namespace WillowMaze.Wasm.Decompiled;


public class FrameMetricsAggregator {
    public static readonly int ANIMATION_DURATION = 256;
    public static readonly int ANIMATION_INDEX = 8;
    public static readonly int COMMAND_DURATION = 32;
    public static readonly int COMMAND_INDEX = 5;
    public static readonly int DELAY_DURATION = 128;
    public static readonly int DELAY_INDEX = 7;
    public static readonly int DRAW_DURATION = 8;
    public static readonly int DRAW_INDEX = 3;
    public static readonly int EVERY_DURATION = 511;
    public static readonly int INPUT_DURATION = 2;
    public static readonly int INPUT_INDEX = 1;
    private static readonly int LAST_INDEX = 8;
    public static readonly int LAYOUT_MEASURE_DURATION = 4;
    public static readonly int LAYOUT_MEASURE_INDEX = 2;
    public static readonly int SWAP_DURATION = 64;
    public static readonly int SWAP_INDEX = 6;
    public static readonly int SYNC_DURATION = 16;
    public static readonly int SYNC_INDEX = 4;
    public static readonly int TOTAL_DURATION = 1;
    public static readonly int TOTAL_INDEX = 0;
    private readonly androidx.core.app.FrameMetricsAggregator$FrameMetricsBaseImpl mInstance;

    public FrameMetricsAggregator() {
        this(1);
    }

    public FrameMetricsAggregator(int i) {
        this.mInstance = new androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl(i);
    }

    public void Add(android.app.object activity) {
        this.mInstance.Add(activity);
    }

    public android.util.SparseIntArray[] GetMetrics() {
        return this.mInstance.getMetrics();
    }

    public android.util.SparseIntArray[] Remove(android.app.object activity) {
        return this.mInstance.Remove(activity);
    }

    public android.util.SparseIntArray[] Reset() {
        return this.mInstance.reset();
    }

    public android.util.SparseIntArray[] Stop() {
        return this.mInstance.stop();
    }
}

