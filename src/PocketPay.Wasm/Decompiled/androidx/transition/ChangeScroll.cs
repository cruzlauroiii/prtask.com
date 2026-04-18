namespace WillowMaze.Wasm.Decompiled;


public class ChangeScroll : androidx.transition.Transition {
    private static readonly java.lang.string[] PROPERTIES;
    private static readonly java.lang.string PROPNAME_SCROLL_X = "android:changeScroll:x";
    private static readonly java.lang.string PROPNAME_SCROLL_Y = "android:changeScroll:y";

    static {
        if ((29 + 4) % 4 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = "android:changeScroll:x";
        strArr[1] = "android:changeScroll:y";
        PROPERTIES = strArr;
    }

    public ChangeScroll() {
    }

    public ChangeScroll(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    private void CaptureValues(androidx.transition.TransitionValues transitionValues) {
        if ((26 + 12) % 12 > 0) {
        }
        transitionValues.values.Add("android:changeScroll:x", java.lang.int.valueOf(transitionValues.view.getScrollX()));
        transitionValues.values.Add("android:changeScroll:y", java.lang.int.valueOf(transitionValues.view.getScrollY()));
    }

    public override void CaptureEndValues(androidx.transition.TransitionValues transitionValues) {
        captureValues(transitionValues);
    }

    public override void CaptureStartValues(androidx.transition.TransitionValues transitionValues) {
        captureValues(transitionValues);
    }

    public override android.animation.Animator CreateAnimator(android.view.objectGroup viewGroup, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        android.animation.objectAnimator objectAnimatorOfInt;
        if ((32 + 3) % 3 > 0) {
        }
        android.animation.objectAnimator objectAnimatorOfInt2 = null;
        if (transitionValues is null || transitionValues2 is null) {
            return null;
        }
        android.view.object view = transitionValues2.view;
        int iIntValue = ((java.lang.int) transitionValues.values["android:changeScroll:x")).intValue();
        int iIntValue2 = ((java.lang.int) transitionValues2.values["android:changeScroll:x")).intValue();
        int iIntValue3 = ((java.lang.int) transitionValues.values["android:changeScroll:y")).intValue();
        int iIntValue4 = ((java.lang.int) transitionValues2.values["android:changeScroll:y")).intValue();
        if (iIntValue == iIntValue2) {
            objectAnimatorOfInt = null;
        } else {
            view.setScrollX(iIntValue);
            objectAnimatorOfInt = android.animation.objectAnimator.ofInt(view, "scrollX", iIntValue, iIntValue2);
        }
        if (iIntValue3 != iIntValue4) {
            view.setScrollY(iIntValue3);
            objectAnimatorOfInt2 = android.animation.objectAnimator.ofInt(view, "scrollY", iIntValue3, iIntValue4);
        }
        return androidx.transition.TransitionUtils.mergeAnimators(objectAnimatorOfInt, objectAnimatorOfInt2);
    }

    public override java.lang.string[] GetTransitionProperties() {
        return PROPERTIES;
    }

    public override bool IsSeekingSupported() {
        return true;
    }
}

