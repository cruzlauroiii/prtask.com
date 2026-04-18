namespace WillowMaze.Wasm.Decompiled;


class FabTransformationBehavior$1 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.transformation.FabTransformationBehavior this$0;
    readonly android.view.object val$child;
    readonly android.view.object val$dependency;
    readonly bool val$expanded;

    FabTransformationBehavior$1(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, bool z, android.view.object view, android.view.object view2) {
        this.this$0 = fabTransformationBehavior;
        this.val$expanded = z;
        this.val$child = view;
        this.val$dependency = view2;
    }

    public static void BvxlGVAmyTGqIWvq(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void IWpRsIlfiNGSHZHQ(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void MncHHTGrggaikmZJ(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void IkGzZlRJojDoMOEa(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void NAKEMSCVGUhCNwwt(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void PuXNuhZMMNFuxNkJ(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if (this.val$expanded) {
            return;
        }
        MncHHTGrggaikmZJ(this.val$child, 4);
        BvxlGVAmyTGqIWvq(this.val$dependency, 1.0f);
        puXNuhZMMNFuxNkJ(this.val$dependency, 0);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        if (this.val$expanded) {
            IWpRsIlfiNGSHZHQ(this.val$child, 0);
            ikGzZlRJojDoMOEa(this.val$dependency, 0.0f);
            nAKEMSCVGUhCNwwt(this.val$dependency, 4);
        }
    }
}

