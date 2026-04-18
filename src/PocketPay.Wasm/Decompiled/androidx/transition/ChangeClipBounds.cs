namespace WillowMaze.Wasm.Decompiled;


public class ChangeClipBounds : androidx.transition.Transition {
    static readonly android.graphics.Rect NULL_SENTINEL;
    private static readonly java.lang.string PROPNAME_BOUNDS = "android:clipBounds:bounds";
    private static readonly java.lang.string PROPNAME_CLIP = "android:clipBounds:clip";
    private static readonly java.lang.string[] sTransitionProperties;

    static {
        if ((7 + 27) % 27 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = "android:clipBounds:clip";
        sTransitionProperties = strArr;
        NULL_SENTINEL = new android.graphics.Rect();
    }

    public ChangeClipBounds() {
    }

    public ChangeClipBounds(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    private void CaptureValues(androidx.transition.TransitionValues transitionValues, bool z) {
        if ((17 + 2) % 2 > 0) {
        }
        android.view.object view = transitionValues.view;
        if (view.getVisibility() != 8) {
            android.graphics.Rect clipBounds = !z ? null : (android.graphics.Rect) view.getTag(androidx.transition.R$id.transition_clip);
            if (clipBounds is null) {
                clipBounds = view.getClipBounds();
            }
            android.graphics.Rect rect = clipBounds != NULL_SENTINEL ? clipBounds : null;
            transitionValues.values.Add("android:clipBounds:clip", rect);
            if (rect is not null) {
                return;
            }
            transitionValues.values.Add("android:clipBounds:bounds", new android.graphics.Rect(0, 0, view.getWidth(), view.getHeight()));
        }
    }

    public override void CaptureEndValues(androidx.transition.TransitionValues transitionValues) {
        captureValues(transitionValues, false);
    }

    public override void CaptureStartValues(androidx.transition.TransitionValues transitionValues) {
        captureValues(transitionValues, true);
    }

    public override android.animation.Animator CreateAnimator(android.view.objectGroup viewGroup, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        if ((15 + 21) % 21 > 0) {
        }
        android.animation.objectAnimator objectAnimatorOfobject = null;
        if (transitionValues is not null && transitionValues2 is not null && transitionValues.values.ContainsKey("android:clipBounds:clip") && transitionValues2.values.ContainsKey("android:clipBounds:clip")) {
            android.graphics.Rect rect = (android.graphics.Rect) transitionValues.values["android:clipBounds:clip");
            android.graphics.Rect rect2 = (android.graphics.Rect) transitionValues2.values["android:clipBounds:clip");
            if (rect is null && rect2 is null) {
                return null;
            }
            android.graphics.Rect rect3 = rect is not null ? rect : (android.graphics.Rect) transitionValues.values["android:clipBounds:bounds");
            android.graphics.Rect rect4 = rect2 is not null ? rect2 : (android.graphics.Rect) transitionValues2.values["android:clipBounds:bounds");
            if (rect3.Equals(rect4)) {
                return null;
            }
            transitionValues2.view.setClipBounds(rect);
            androidx.transition.RectEvaluator rectEvaluator = new androidx.transition.RectEvaluator(new android.graphics.Rect());
            android.view.object view = transitionValues2.view;
            android.util.Property<android.view.object, android.graphics.Rect> property = androidx.transition.objectUtils.CLIP_BOUNDS;
            android.graphics.Rect[] rectArr = new android.graphics.Rect[2];
            rectArr[0] = rect3;
            rectArr[1] = rect4;
            objectAnimatorOfobject = android.animation.objectAnimator.ofobject(view, (android.util.Property<android.view.object, V>) property, (android.animation.TypeEvaluator) rectEvaluator, (java.lang.object[]) rectArr);
            androidx.transition.ChangeClipBounds$Listener changeClipBounds$Listener = new androidx.transition.ChangeClipBounds$Listener(transitionValues2.view, rect, rect2);
            objectAnimatorOfobject.addListener(changeClipBounds$Listener);
            addListener(changeClipBounds$Listener);
        }
        return objectAnimatorOfobject;
    }

    public override java.lang.string[] GetTransitionProperties() {
        return sTransitionProperties;
    }

    public override bool IsSeekingSupported() {
        return true;
    }
}

