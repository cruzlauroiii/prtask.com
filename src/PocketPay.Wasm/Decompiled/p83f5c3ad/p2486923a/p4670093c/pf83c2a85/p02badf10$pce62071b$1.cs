namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000-\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0007\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J \u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0007H\u0016J(\u0010\t\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u0018\u0010\f\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\r\u001a\u00020\u0007H\u0016J(\u0010\u000e\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u000f\u001a\u00020\u00072\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\n\u001a\u00020\u000bH\u0016¨\u0006\u0012"}, d2 = {"toph/presentation/payback/payment/TophPaybackobject$performDotSuccessCalibrationAnimationLoop$1", "Landroidx/constraintlayout/motion/widget/MotionLayout$TransitionListener;", "onTransitionStarted", "", "motionLayout", "Landroidx/constraintlayout/motion/widget/MotionLayout;", "startId", "", "endId", "onTransitionChange", "progress", "", "onTransitionCompleted", "currentId", "onTransitionTrigger", "triggerId", "positive", "", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p02badf10$pce62071b$1 : androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener {
    p02badf10$pce62071b$1() {
    }

    public override void OnTransitionChange(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int startId, int endId, float progress) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(motionLayout, "motionLayout");
    }

    public override void OnTransitionCompleted(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int currentId) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(motionLayout, "motionLayout");
        motionLayout.setProgress(0.0f);
        motionLayout.transitionToEnd();
    }

    public override void OnTransitionStarted(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int startId, int endId) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(motionLayout, "motionLayout");
    }

    public override void OnTransitionTrigger(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int triggerId, bool positive, float progress) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(motionLayout, "motionLayout");
    }
}

