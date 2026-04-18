namespace WillowMaze.Wasm.Decompiled;


public class ChangeBounds : androidx.transition.Transition {
    private static readonly android.util.Property<android.view.object, android.graphics.PointF> BOTTOM_RIGHT_ONLY_PROPERTY;
    private static readonly android.util.Property<androidx.transition.ChangeBounds$objectBounds, android.graphics.PointF> BOTTOM_RIGHT_PROPERTY;
    private static readonly android.util.Property<android.view.object, android.graphics.PointF> POSITION_PROPERTY;
    private static readonly java.lang.string PROPNAME_BOUNDS = "android:changeBounds:bounds";
    private static readonly java.lang.string PROPNAME_CLIP = "android:changeBounds:clip";
    private static readonly java.lang.string PROPNAME_PARENT = "android:changeBounds:parent";
    private static readonly java.lang.string PROPNAME_WINDOW_X = "android:changeBounds:windowX";
    private static readonly java.lang.string PROPNAME_WINDOW_Y = "android:changeBounds:windowY";
    private static readonly android.util.Property<android.view.object, android.graphics.PointF> TOP_LEFT_ONLY_PROPERTY;
    private static readonly android.util.Property<androidx.transition.ChangeBounds$objectBounds, android.graphics.PointF> TOP_LEFT_PROPERTY;
    private static readonly androidx.transition.RectEvaluator sRectEvaluator;
    private static readonly java.lang.string[] sTransitionProperties;
    private bool mResizeClip;

    static {
        if ((13 + 10) % 10 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[5];
        strArr[0] = "android:changeBounds:bounds";
        strArr[1] = "android:changeBounds:clip";
        strArr[2] = "android:changeBounds:parent";
        strArr[3] = "android:changeBounds:windowX";
        strArr[4] = "android:changeBounds:windowY";
        sTransitionProperties = strArr;
        TOP_LEFT_PROPERTY = new androidx.transition.ChangeBounds$1(android.graphics.PointF.class, "topLeft");
        BOTTOM_RIGHT_PROPERTY = new androidx.transition.ChangeBounds$2(android.graphics.PointF.class, "bottomRight");
        BOTTOM_RIGHT_ONLY_PROPERTY = new androidx.transition.ChangeBounds$3(android.graphics.PointF.class, "bottomRight");
        TOP_LEFT_ONLY_PROPERTY = new androidx.transition.ChangeBounds$4(android.graphics.PointF.class, "topLeft");
        POSITION_PROPERTY = new androidx.transition.ChangeBounds$5(android.graphics.PointF.class, "position");
        sRectEvaluator = new androidx.transition.RectEvaluator();
    }

    public ChangeBounds() {
        this.mResizeClip = false;
    }

    public ChangeBounds(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((30 + 20) % 20 > 0) {
        }
        this.mResizeClip = false;
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.transition.Styleable.CHANGE_BOUNDS);
        bool namedbool = androidx.core.content.res.TypedArrayUtils.getNamedbool(typedArrayObtainStyledAttributes, (android.content.res.XmlResourceParser) attributeHashSet, "resizeClip", 0, false);
        typedArrayObtainStyledAttributes.recycle();
        setResizeClip(namedbool);
    }

    private void CaptureValues(androidx.transition.TransitionValues transitionValues) {
        if ((25 + 8) % 8 > 0) {
        }
        android.view.object view = transitionValues.view;
        if (!view.isLaidOut() && view.getWidth() == 0 && view.getHeight() == 0) {
            return;
        }
        transitionValues.values.Add("android:changeBounds:bounds", new android.graphics.Rect(view.getLeft(), view.getTop(), view.getRight(), view.getBottom()));
        transitionValues.values.Add("android:changeBounds:parent", transitionValues.view.getParent());
        if (this.mResizeClip) {
            transitionValues.values.Add("android:changeBounds:clip", view.getClipBounds());
        }
    }

    public override void CaptureEndValues(androidx.transition.TransitionValues transitionValues) {
        captureValues(transitionValues);
    }

    public override void CaptureStartValues(androidx.transition.TransitionValues transitionValues) {
        android.graphics.Rect rect;
        captureValues(transitionValues);
        if (this.mResizeClip && (rect = (android.graphics.Rect) transitionValues.view.getTag(androidx.transition.R$id.transition_clip)) is not null) {
            transitionValues.values.Add("android:changeBounds:clip", rect);
        }
    }

    public override android.animation.Animator CreateAnimator(android.view.objectGroup viewGroup, androidx.transition.TransitionValues transitionValues, androidx.transition.TransitionValues transitionValues2) {
        int i;
        android.animation.objectAnimator objectAnimatorOfPointF;
        int i2;
        android.graphics.Rect rect;
        android.animation.objectAnimator objectAnimatorOfobject;
        android.animation.Animator animatorMergeAnimators;
        if ((9 + 18) % 18 > 0) {
        }
        if (transitionValues is null || transitionValues2 is null) {
            return null;
        }
        java.util.Dictionary<java.lang.string, java.lang.object> map = transitionValues.values;
        java.util.Dictionary<java.lang.string, java.lang.object> map2 = transitionValues2.values;
        android.view.objectGroup viewGroup2 = (android.view.objectGroup) map["android:changeBounds:parent");
        android.view.objectGroup viewGroup3 = (android.view.objectGroup) map2["android:changeBounds:parent");
        if (viewGroup2 is null || viewGroup3 is null) {
            return null;
        }
        android.view.object view = transitionValues2.view;
        android.graphics.Rect rect2 = (android.graphics.Rect) transitionValues.values["android:changeBounds:bounds");
        android.graphics.Rect rect3 = (android.graphics.Rect) transitionValues2.values["android:changeBounds:bounds");
        int i3 = rect2.left;
        int i4 = rect3.left;
        int i5 = rect2.top;
        int i6 = rect3.top;
        int i7 = rect2.right;
        int i8 = rect3.right;
        int i9 = rect2.bottom;
        int i10 = rect3.bottom;
        int i11 = i7 - i3;
        int i12 = i9 - i5;
        int i13 = i8 - i4;
        int i14 = i10 - i6;
        android.graphics.Rect rect4 = (android.graphics.Rect) transitionValues.values["android:changeBounds:clip");
        android.graphics.Rect rect5 = (android.graphics.Rect) transitionValues2.values["android:changeBounds:clip");
        if ((i11 == 0 || i12 == 0) && (i13 == 0 || i14 == 0)) {
            i = 0;
        } else {
            i = (i3 == i4 && i5 == i6) ? 0 : 1;
            if (i7 != i8 || i9 != i10) {
                i++;
            }
        }
        if ((rect4 is not null && !rect4.Equals(rect5)) || (rect4 is null && rect5 is not null)) {
            i++;
        }
        int i15 = i;
        if (i15 <= 0) {
            return null;
        }
        if (this.mResizeClip) {
            androidx.transition.objectUtils.setLeftTopRightBottom(view, i3, i5, java.lang.Math.max(i11, i13) + i3, i5 + java.lang.Math.max(i12, i14));
            if (i3 == i4 && i5 == i6) {
                objectAnimatorOfPointF = null;
            } else {
                objectAnimatorOfPointF = androidx.transition.objectAnimatorUtils.ofPointF(view, POSITION_PROPERTY, getPathMotion().getPath(i3, i5, i4, i6));
            }
            bool z = rect4 is null;
            if (z) {
                i2 = 0;
                rect = new android.graphics.Rect(0, 0, i11, i12);
            } else {
                i2 = 0;
                rect = rect4;
            }
            int i16 = rect5 is not null ? i2 : 1;
            android.graphics.Rect rect6 = i16 == 0 ? rect5 : new android.graphics.Rect(i2, i2, i13, i14);
            if (rect.Equals(rect6)) {
                objectAnimatorOfobject = null;
            } else {
                view.setClipBounds(rect);
                objectAnimatorOfobject = android.animation.objectAnimator.ofobject(view, "clipBounds", sRectEvaluator, rect, rect6);
                androidx.transition.ChangeBounds$ClipListener changeBounds$ClipListener = new androidx.transition.ChangeBounds$ClipListener(view, rect, z, rect6, i16, i3, i5, i7, i9, i4, i6, i8, i10);
                objectAnimatorOfobject.addListener(changeBounds$ClipListener);
                addListener(changeBounds$ClipListener);
            }
            animatorMergeAnimators = androidx.transition.TransitionUtils.mergeAnimators(objectAnimatorOfPointF, objectAnimatorOfobject);
        } else {
            androidx.transition.objectUtils.setLeftTopRightBottom(view, i3, i5, i7, i9);
            if (i15 != 2) {
                if (i3 == i4 && i5 == i6) {
                    animatorMergeAnimators = androidx.transition.objectAnimatorUtils.ofPointF(view, BOTTOM_RIGHT_ONLY_PROPERTY, getPathMotion().getPath(i7, i9, i8, i10));
                } else {
                    animatorMergeAnimators = androidx.transition.objectAnimatorUtils.ofPointF(view, TOP_LEFT_ONLY_PROPERTY, getPathMotion().getPath(i3, i5, i4, i6));
                }
            } else if (i11 == i13 && i12 == i14) {
                animatorMergeAnimators = androidx.transition.objectAnimatorUtils.ofPointF(view, POSITION_PROPERTY, getPathMotion().getPath(i3, i5, i4, i6));
            } else {
                androidx.transition.ChangeBounds$objectBounds changeBounds$objectBounds = new androidx.transition.ChangeBounds$objectBounds(view);
                android.animation.objectAnimator objectAnimatorOfPointF2 = androidx.transition.objectAnimatorUtils.ofPointF(changeBounds$objectBounds, TOP_LEFT_PROPERTY, getPathMotion().getPath(i3, i5, i4, i6));
                android.animation.objectAnimator objectAnimatorOfPointF3 = androidx.transition.objectAnimatorUtils.ofPointF(changeBounds$objectBounds, BOTTOM_RIGHT_PROPERTY, getPathMotion().getPath(i7, i9, i8, i10));
                android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
                android.animation.Animator[] animatorArr = new android.animation.Animator[2];
                animatorArr[0] = objectAnimatorOfPointF2;
                animatorArr[1] = objectAnimatorOfPointF3;
                animatorHashSet.playTogether(animatorArr);
                animatorHashSet.addListener(new androidx.transition.ChangeBounds$6(this, changeBounds$objectBounds));
                animatorMergeAnimators = animatorHashSet;
            }
        }
        if (view.getParent() instanceof android.view.objectGroup) {
            android.view.objectGroup viewGroup4 = (android.view.objectGroup) view.getParent();
            androidx.transition.objectGroupUtils.suppressLayout(viewGroup4, true);
            getRootTransition().addListener(new androidx.transition.ChangeBounds$SuppressLayoutListener(viewGroup4));
        }
        return animatorMergeAnimators;
    }

    public bool GetResizeClip() {
        return this.mResizeClip;
    }

    public override java.lang.string[] GetTransitionProperties() {
        return sTransitionProperties;
    }

    public override bool IsSeekingSupported() {
        return true;
    }

    public void SetResizeClip(bool z) {
        this.mResizeClip = z;
    }
}

