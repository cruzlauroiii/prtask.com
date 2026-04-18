namespace WillowMaze.Wasm.Decompiled;


class FabTransformationScrimBehavior$1 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.transformation.FabTransformationScrimBehavior this$0;
    readonly android.view.object val$child;
    readonly bool val$expanded;

    FabTransformationScrimBehavior$1(com.google.android.material.transformation.FabTransformationScrimBehavior fabTransformationScrimBehavior, bool z, android.view.object view) {
        this.this$0 = fabTransformationScrimBehavior;
        this.val$expanded = z;
        this.val$child = view;
    }

    public static void JBhRdGZbKACiXCJr(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void ZLhTuVtGHMNvxWvG(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if (this.val$expanded) {
            return;
        }
        ZLhTuVtGHMNvxWvG(this.val$child, 4);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        if (this.val$expanded) {
            JBhRdGZbKACiXCJr(this.val$child, 0);
        }
    }
}

