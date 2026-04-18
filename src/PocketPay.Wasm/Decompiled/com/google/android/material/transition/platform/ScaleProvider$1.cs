namespace WillowMaze.Wasm.Decompiled;


class ScaleProvider$1 : android.animation.AnimatorListenerAdapter {
    readonly float val$originalScaleX;
    readonly float val$originalScaleY;
    readonly android.view.object val$view;

    ScaleProvider$1(android.view.object view, float f, float f2) {
        this.val$view = view;
        this.val$originalScaleX = f;
        this.val$originalScaleY = f2;
    }

    public static void FIQWEfmZOmAiNOTO(android.view.object view, float f) {
        view.setScaleY(f);
    }

    public static void LOEAYdruBPEaMZxW(android.view.object view, float f) {
        view.setScaleX(f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        lOEAYdruBPEaMZxW(this.val$view, this.val$originalScaleX);
        FIQWEfmZOmAiNOTO(this.val$view, this.val$originalScaleY);
    }
}

