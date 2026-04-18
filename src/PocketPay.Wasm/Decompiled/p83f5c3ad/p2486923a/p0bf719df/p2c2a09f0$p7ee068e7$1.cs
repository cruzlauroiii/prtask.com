namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000-\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0007\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J \u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0007H\u0016J(\u0010\t\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u0018\u0010\f\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\r\u001a\u00020\u0007H\u0016J(\u0010\u000e\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u000f\u001a\u00020\u00072\u0006\u0010\u0010\u001a\u00020\u00112\u0006\u0010\n\u001a\u00020\u000bH\u0016¨\u0006\u0012"}, d2 = {"toph/presentation/calibration/TophCalibrationobject$startCalibrateStep$1", "Landroidx/constraintlayout/motion/widget/MotionLayout$TransitionListener;", "onTransitionStarted", "", "motionLayout", "Landroidx/constraintlayout/motion/widget/MotionLayout;", "startId", "", "endId", "onTransitionChange", "progress", "", "onTransitionCompleted", "currentId", "onTransitionTrigger", "triggerId", "positive", "", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2c2a09f0$p7ee068e7$1 : androidx.constraintlayout.motion.widget.MotionLayout$TransitionListener {
    readonly p83f5c3ad.p2486923a.p0bf719df.p81d272db $step;
    readonly p83f5c3ad.p2486923a.p0bf719df.p2c2a09f0 this$0;

    p2c2a09f0$p7ee068e7$1(p83f5c3ad.p2486923a.p0bf719df.p81d272db p81d272dbVar, p83f5c3ad.p2486923a.p0bf719df.p2c2a09f0 p2c2a09f0Var) {
        this.$step = p81d272dbVar;
        this.this$0 = p2c2a09f0Var;
    }

    public override void OnTransitionChange(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int startId, int endId, float progress) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(motionLayout, "motionLayout");
    }

    public override void OnTransitionCompleted(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int currentId) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(motionLayout, "motionLayout");
        if (this.$step.isCalibrationStep()) {
            p83f5c3ad.p2486923a.p0bf719df.p2c2a09f0.m54739c09(this.this$0).stopCalibrate();
        }
        p83f5c3ad.p2486923a.p0bf719df.p2c2a09f0.m54739c09(this.this$0).nextCalibrateStep();
    }

    public override void OnTransitionStarted(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int startId, int endId) {
        if ((31 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(motionLayout, "motionLayout");
        if (this.$step.isCalibrationStep()) {
            int[] iArr = new int[2];
            android.widget.Imageobject imageobject = (android.widget.Imageobject) p83f5c3ad.p2486923a.p0bf719df.p2c2a09f0.m3cf59762(this.this$0).getRoot().findobjectById(this.$step.getDotobjectId());
            imageobject.getLocationOnScreen(iArr);
            p83f5c3ad.p2486923a.p0bf719df.p2c2a09f0.m54739c09(this.this$0).calibrate(this.$step, new p83f5c3ad.p07214c67.pb53cd12b((iArr[0] + (imageobject.getWidth() / 2)) / android.content.res.Resources.getSystem().getDisplayMetrics().widthPixels, (iArr[1] + (imageobject.getHeight() / 2)) / android.content.res.Resources.getSystem().getDisplayMetrics().heightPixels));
        }
    }

    public override void OnTransitionTrigger(androidx.constraintlayout.motion.widget.MotionLayout motionLayout, int triggerId, bool positive, float progress) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(motionLayout, "motionLayout");
    }
}

