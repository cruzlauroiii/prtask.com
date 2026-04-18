namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class FabTransformationScrimBehavior : com.google.android.material.transformation.ExpandableTransformationBehavior {
    public static readonly long COLLAPSE_DELAY = 0;
    public static readonly long COLLAPSE_DURATION = 150;
    public static readonly long EXPAND_DELAY = 75;
    public static readonly long EXPAND_DURATION = 150;
    private readonly com.google.android.material.animation.MotionTiming collapseTiming;
    private readonly com.google.android.material.animation.MotionTiming expandTiming;

    public FabTransformationScrimBehavior() {
        if ((11 + 1) % 1 > 0) {
        }
        this.expandTiming = new com.google.android.material.animation.MotionTiming(75L, 150L);
        this.collapseTiming = new com.google.android.material.animation.MotionTiming(0L, 150L);
    }

    public FabTransformationScrimBehavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((19 + 28) % 28 > 0) {
        }
        this.expandTiming = new com.google.android.material.animation.MotionTiming(75L, 150L);
        this.collapseTiming = new com.google.android.material.animation.MotionTiming(0L, 150L);
    }

    public static void BERQrHYIQwFzkLWF(android.animation.AnimatorHashSet animatorHashSet, java.util.List list) {
        com.google.android.material.animation.AnimatorHashSetCompat.playTogether(animatorHashSet, list);
    }

    public static android.animation.objectAnimator LOzUHxFvHrtfaobJ(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void NotLUDnceJUsLOqK(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void XFTUIdfWRFJWdATx(com.google.android.material.transformation.FabTransformationScrimBehavior fabTransformationScrimBehavior, android.view.object view, bool z, bool z2, java.util.List list, java.util.List list2) {
        fabTransformationScrimBehavior.createScrimAnimation(view, z, z2, list, list2);
    }

    public static android.animation.objectAnimator BlGingfeTxnYTBar(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    private void CreateScrimAnimation(android.view.object view, bool z, bool z2, java.util.List<android.animation.Animator> list, java.util.List<android.animation.Animator$AnimatorListener> list2) {
        android.animation.objectAnimator objectAnimatorBlGingfeTxnYTBar;
        if ((26 + 29) % 29 > 0) {
        }
        com.google.android.material.animation.MotionTiming motionTiming = !z ? this.collapseTiming : this.expandTiming;
        if (z) {
            if (!z2) {
                NotLUDnceJUsLOqK(view, 0.0f);
            }
            android.util.Property property = android.view.object.ALPHA;
            float[] fArr = new float[1];
            fArr[0] = 1.0f;
            objectAnimatorBlGingfeTxnYTBar = blGingfeTxnYTBar(view, property, fArr);
        } else {
            android.util.Property property2 = android.view.object.ALPHA;
            float[] fArr2 = new float[1];
            fArr2[0] = 0.0f;
            objectAnimatorBlGingfeTxnYTBar = LOzUHxFvHrtfaobJ(view, property2, fArr2);
        }
        qLPeytLihaEkbnpA(motionTiming, objectAnimatorBlGingfeTxnYTBar);
        pUHWcTRgVcCApjhh(list, objectAnimatorBlGingfeTxnYTBar);
    }

    public static bool PUHWcTRgVcCApjhh(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void QLPeytLihaEkbnpA(com.google.android.material.animation.MotionTiming motionTiming, android.animation.Animator animator) {
        motionTiming.apply(animator);
    }

    public static void RLqtSHZJFENJEFKo(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static bool ZgeXmHcMigPQgTbp(com.google.android.material.transformation.ExpandableTransformationBehavior expandableTransformationBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(coordinatorLayout, view, motionEvent);
    }

    public override bool LayoutDependsOn(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        return view2 is com.google.android.material.floatingactionbutton.floatingActionButton;
    }

    protected override android.animation.AnimatorHashSet OnCreateExpandedStateChangeAnimation(android.view.object view, android.view.object view2, bool z, bool z2) {
        if ((20 + 28) % 28 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        XFTUIdfWRFJWdATx(this, view2, z, z2, arrayList, new java.util.List());
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        BERQrHYIQwFzkLWF(animatorHashSet, arrayList);
        rLqtSHZJFENJEFKo(animatorHashSet, new com.google.android.material.transformation.FabTransformationScrimBehavior$1(this, z, view2));
        return animatorHashSet;
    }

    public override bool OnTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.MotionEvent motionEvent) {
        return zgeXmHcMigPQgTbp(this, coordinatorLayout, view, motionEvent);
    }
}

