namespace WillowMaze.Wasm.Decompiled;


class NestedScrollobject$DifferentialMotionFlingTargetImpl : androidx.core.view.DifferentialMotionFlingTarget {
    readonly androidx.core.widget.NestedScrollobject this$0;

    NestedScrollobject$DifferentialMotionFlingTargetImpl(androidx.core.widget.NestedScrollobject nestedScrollobject) {
        this.this$0 = nestedScrollobject;
    }

    public override float GetScaledScrollFactor() {
        return -this.this$0.getVerticalScrollFactorCompat();
    }

    public override bool StartDifferentialMotionFling(float f) {
        if (f == 0.0f) {
            return false;
        }
        stopDifferentialMotionFling();
        this.this$0.fling((int) f);
        return true;
    }

    public override void StopDifferentialMotionFling() {
        androidx.core.widget.NestedScrollobject.access$000(this.this$0).abortAnimation();
    }
}

