namespace WillowMaze.Wasm.Decompiled;

public class P2c2a09f0_p7ee068e7_1 : MotionLayout$TransitionListener
{
    private readonly p81d272db $step;
    private readonly p2c2a09f0 This$0;

    public void OnTransitionChange(MotionLayout P0, int P1, int P2, float P3)
    {
        // str: "motionLayout"
        // call: Intrinsics.checkNotNullParameter
    }

    public void OnTransitionCompleted(MotionLayout P0, int P1)
    {
        // str: "motionLayout"
        // call: p2c2a09f0.m54739c09
        // call: pecfe5a38.nextCalibrateStep
        // call: p81d272db.isCalibrationStep
        // call: Intrinsics.checkNotNullParameter
        // call: pecfe5a38.stopCalibrate
        // field: p83f5c3ad.p2486923a.p0bf719df.p2c2a09f0$p7ee068e7$1.this$0
        // field: p83f5c3ad.p2486923a.p0bf719df.p2c2a09f0$p7ee068e7$1.$step
    }

    public void OnTransitionStarted(MotionLayout P0, int P1, int P2)
    {
        // str: "motionLayout"
        // call: ConstraintLayout.findViewById
        // call: Resources.getDisplayMetrics
        // call: ImageView.getHeight
        // call: Intrinsics.checkNotNullParameter
        // call: p81d272db.isCalibrationStep
        // call: p2c2a09f0.m54739c09
        // call: p81d272db.getDotViewId
        // call: pecfe5a38.calibrate
        // call: Resources.getSystem
        // call: pb53cd12b.<init>
        // call: ImageView.getLocationOnScreen
        // call: ImageView.getWidth
        // call: p2c2a09f0.m3cf59762
        // call: p4187163c.getRoot
        // field: p83f5c3ad.p2486923a.p0bf719df.p2c2a09f0$p7ee068e7$1.$step
        // field: android.util.DisplayMetrics.widthPixels
        // field: p83f5c3ad.p2486923a.p0bf719df.p2c2a09f0$p7ee068e7$1.this$0
        // field: android.util.DisplayMetrics.heightPixels
        // type: pb53cd12b
    }

    public void OnTransitionTrigger(MotionLayout P0, int P1, bool P2, float P3)
    {
        // str: "motionLayout"
        // call: Intrinsics.checkNotNullParameter
    }

}
