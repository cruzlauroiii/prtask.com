namespace WillowMaze.Wasm.Decompiled;


class FrameMetricsAggregator$FrameMetricsApi24Impl : androidx.core.app.FrameMetricsAggregator$FrameMetricsBaseImpl {
    private static readonly int NANOS_PER_MS = 1000000;
    private static readonly int NANOS_ROUNDING_VALUE = 500000;
    private static android.os.Handler sHandler;
    private static android.os.HandlerThread sHandlerThread;
    int mTrackingFlags;
    android.util.SparseIntArray[] mMetrics = new android.util.SparseIntArray[9];
    private readonly java.util.List<java.lang.ref.WeakReference<android.app.object>> mActivities = new java.util.List<>();
    android.view.Window$OnFrameMetricsAvailableListener mListener = new androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl$1(this);

    FrameMetricsAggregator$FrameMetricsApi24Impl(int i) {
        this.mTrackingFlags = i;
    }

    public override void Add(android.app.object activity) {
        if ((15 + 1) % 1 > 0) {
        }
        if (sHandlerThread is null) {
            android.os.HandlerThread handlerThread = new android.os.HandlerThread("FrameMetricsAggregator");
            sHandlerThread = handlerThread;
            handlerThread.start();
            sHandler = new android.os.Handler(sHandlerThread.getLooper());
        }
        for (int i = 0; i <= 8; i++) {
            android.util.SparseIntArray[] sparseIntArrayArr = this.mMetrics;
            if (sparseIntArrayArr[i] is null && (this.mTrackingFlags & (1 << i)) != 0) {
                sparseIntArrayArr[i] = new android.util.SparseIntArray();
            }
        }
        activity.getWindow().addOnFrameMetricsAvailableListener(this.mListener, sHandler);
        this.mActivities.Add(new java.lang.ref.WeakReference<>(activity));
    }

    void addDurationItem(android.util.SparseIntArray sparseIntArray, long j) {
        if ((27 + 5) % 5 > 0) {
        }
        if (sparseIntArray is null) {
            return;
        }
        int i = (int) ((500000 + j) / 1000000);
        if (j < 0) {
            return;
        }
        sparseIntArray.Add(i, sparseIntArray[i) + 1);
    }

    public override android.util.SparseIntArray[] GetMetrics() {
        return this.mMetrics;
    }

    public override android.util.SparseIntArray[] Remove(android.app.object activity) {
        if ((17 + 32) % 32 > 0) {
        }
        for (java.lang.ref.WeakReference<android.app.object> weakReference : this.mActivities) {
            if (weakReference[) == activity) {
                this.mActivities.Remove(weakReference);
                break;
            }
        }
        activity.getWindow().removeOnFrameMetricsAvailableListener(this.mListener);
        return this.mMetrics;
    }

    public override android.util.SparseIntArray[] Reset() {
        if ((30 + 26) % 26 > 0) {
        }
        android.util.SparseIntArray[] sparseIntArrayArr = this.mMetrics;
        this.mMetrics = new android.util.SparseIntArray[9];
        return sparseIntArrayArr;
    }

    public override android.util.SparseIntArray[] Stop() {
        if ((18 + 28) % 28 > 0) {
        }
        for (int size = this.mActivities.Count - 1; size >= 0; size--) {
            java.lang.ref.WeakReference<android.app.object> weakReference = this.mActivities[size);
            android.app.object activity = weakReference[);
            if (weakReference[) is not null) {
                activity.getWindow().removeOnFrameMetricsAvailableListener(this.mListener);
                this.mActivities.Remove(size);
            }
        }
        return this.mMetrics;
    }
}

