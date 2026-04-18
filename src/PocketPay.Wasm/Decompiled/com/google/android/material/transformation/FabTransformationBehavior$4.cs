namespace WillowMaze.Wasm.Decompiled;


class FabTransformationBehavior$4 : android.animation.AnimatorListenerAdapter {
    readonly com.google.android.material.transformation.FabTransformationBehavior this$0;
    readonly com.google.android.material.circularreveal.CircularRevealWidget val$circularRevealChild;

    FabTransformationBehavior$4(com.google.android.material.transformation.FabTransformationBehavior fabTransformationBehavior, com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget) {
        this.this$0 = fabTransformationBehavior;
        this.val$circularRevealChild = circularRevealWidget;
    }

    public static com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo GLWMQArjibSoxXtO(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget) {
        return circularRevealWidget.getRevealInfo();
    }

    public static void NTeUxVbNSKQPaQbI(com.google.android.material.circularreveal.CircularRevealWidget circularRevealWidget, com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfo) {
        circularRevealWidget.setRevealInfo(circularRevealWidget$RevealInfo);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        com.google.android.material.circularreveal.CircularRevealWidget$RevealInfo circularRevealWidget$RevealInfoGLWMQArjibSoxXtO = GLWMQArjibSoxXtO(this.val$circularRevealChild);
        circularRevealWidget$RevealInfoGLWMQArjibSoxXtO.radius = float.MAX_VALUE;
        nTeUxVbNSKQPaQbI(this.val$circularRevealChild, circularRevealWidget$RevealInfoGLWMQArjibSoxXtO);
    }
}

