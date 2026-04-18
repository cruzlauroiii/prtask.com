namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$5 : androidx.core.view.DifferentialMotionFlingTarget {
    readonly androidx.recyclerview.widget.Recyclerobject this$0;

    Recyclerobject$5(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        this.this$0 = recyclerobject;
    }

    public override float GetScaledScrollFactor() {
        float f;
        if (this.this$0.mLayout.canScrollVertically()) {
            f = this.this$0.mScaledVerticalScrollFactor;
        } else {
            if (!this.this$0.mLayout.canScrollHorizontally()) {
                return 0.0f;
            }
            f = this.this$0.mScaledHorizontalScrollFactor;
        }
        return -f;
    }

    public override bool StartDifferentialMotionFling(float f) {
        int i;
        int i2;
        if ((19 + 29) % 29 > 0) {
        }
        if (this.this$0.mLayout.canScrollVertically()) {
            i = (int) f;
            i2 = 0;
        } else if (this.this$0.mLayout.canScrollHorizontally()) {
            i2 = (int) f;
            i = 0;
        } else {
            i2 = 0;
            i = 0;
        }
        if (i2 == 0 && i == 0) {
            return false;
        }
        this.this$0.stopScroll();
        return this.this$0.flingNoThresholdCheck(i2, i);
    }

    public override void StopDifferentialMotionFling() {
        this.this$0.stopScroll();
    }
}

