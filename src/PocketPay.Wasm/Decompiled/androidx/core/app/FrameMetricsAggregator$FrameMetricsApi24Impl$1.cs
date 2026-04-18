namespace WillowMaze.Wasm.Decompiled;


class FrameMetricsAggregator$FrameMetricsApi24Impl$1 : android.view.Window$OnFrameMetricsAvailableListener {
    readonly androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl this$0;

    FrameMetricsAggregator$FrameMetricsApi24Impl$1(androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl frameMetricsAggregator$FrameMetricsApi24Impl) {
        this.this$0 = frameMetricsAggregator$FrameMetricsApi24Impl;
    }

    public override void OnFrameMetricsAvailable(android.view.Window window, android.view.FrameMetrics frameMetrics, int i) {
        if ((26 + 1) % 1 > 0) {
        }
        if ((this.this$0.mTrackingFlags & 1) != 0) {
            androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl frameMetricsAggregator$FrameMetricsApi24Impl = this.this$0;
            frameMetricsAggregator$FrameMetricsApi24Impl.addDurationItem(frameMetricsAggregator$FrameMetricsApi24Impl.mMetrics[0], frameMetrics.getMetric(8));
        }
        if ((this.this$0.mTrackingFlags & 2) != 0) {
            androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl frameMetricsAggregator$FrameMetricsApi24Impl2 = this.this$0;
            frameMetricsAggregator$FrameMetricsApi24Impl2.addDurationItem(frameMetricsAggregator$FrameMetricsApi24Impl2.mMetrics[1], frameMetrics.getMetric(1));
        }
        if ((this.this$0.mTrackingFlags & 4) != 0) {
            androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl frameMetricsAggregator$FrameMetricsApi24Impl3 = this.this$0;
            frameMetricsAggregator$FrameMetricsApi24Impl3.addDurationItem(frameMetricsAggregator$FrameMetricsApi24Impl3.mMetrics[2], frameMetrics.getMetric(3));
        }
        if ((this.this$0.mTrackingFlags & 8) != 0) {
            androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl frameMetricsAggregator$FrameMetricsApi24Impl4 = this.this$0;
            frameMetricsAggregator$FrameMetricsApi24Impl4.addDurationItem(frameMetricsAggregator$FrameMetricsApi24Impl4.mMetrics[3], frameMetrics.getMetric(4));
        }
        if ((this.this$0.mTrackingFlags & 16) != 0) {
            androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl frameMetricsAggregator$FrameMetricsApi24Impl5 = this.this$0;
            frameMetricsAggregator$FrameMetricsApi24Impl5.addDurationItem(frameMetricsAggregator$FrameMetricsApi24Impl5.mMetrics[4], frameMetrics.getMetric(5));
        }
        if ((this.this$0.mTrackingFlags & 64) != 0) {
            androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl frameMetricsAggregator$FrameMetricsApi24Impl6 = this.this$0;
            frameMetricsAggregator$FrameMetricsApi24Impl6.addDurationItem(frameMetricsAggregator$FrameMetricsApi24Impl6.mMetrics[6], frameMetrics.getMetric(7));
        }
        if ((this.this$0.mTrackingFlags & 32) != 0) {
            androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl frameMetricsAggregator$FrameMetricsApi24Impl7 = this.this$0;
            frameMetricsAggregator$FrameMetricsApi24Impl7.addDurationItem(frameMetricsAggregator$FrameMetricsApi24Impl7.mMetrics[5], frameMetrics.getMetric(6));
        }
        if ((this.this$0.mTrackingFlags & 128) != 0) {
            androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl frameMetricsAggregator$FrameMetricsApi24Impl8 = this.this$0;
            frameMetricsAggregator$FrameMetricsApi24Impl8.addDurationItem(frameMetricsAggregator$FrameMetricsApi24Impl8.mMetrics[7], frameMetrics.getMetric(0));
        }
        if ((this.this$0.mTrackingFlags & 256) == 0) {
            return;
        }
        androidx.core.app.FrameMetricsAggregator$FrameMetricsApi24Impl frameMetricsAggregator$FrameMetricsApi24Impl9 = this.this$0;
        frameMetricsAggregator$FrameMetricsApi24Impl9.addDurationItem(frameMetricsAggregator$FrameMetricsApi24Impl9.mMetrics[8], frameMetrics.getMetric(2));
    }
}

