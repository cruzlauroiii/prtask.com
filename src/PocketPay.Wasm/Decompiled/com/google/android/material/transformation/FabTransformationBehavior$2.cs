namespace WillowMaze.Wasm.Decompiled;


class FabTransformationBehavior$2 : android.animation.ValueAnimator$AnimatorUpdateListener {
    readonly com.google.android.material.transformation.FabTransformationBehavior this$0;
    readonly android.view.object val$child;

    FabTransformationBehavior$2(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, android.view.object view) {
        this.this$0 = fabTransformationBehavior;
        this.val$child = view;
    }

    public static void PElmVMjunspkLRHX(android.view.object view) {
        view.invalidate();
    }

    public override void OnAnimationUpdate(android.animation.ValueAnimator valueAnimator) {
        pElmVMjunspkLRHX(this.val$child);
    }
}

