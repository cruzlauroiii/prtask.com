namespace WillowMaze.Wasm.Decompiled;


class FadeThroughProvider$2 : android.animation.AnimatorListenerAdapter {
    readonly float val$originalAlpha;
    readonly android.view.object val$view;

    FadeThroughProvider$2(android.view.object view, float f) {
        this.val$view = view;
        this.val$originalAlpha = f;
    }

    public static void TkJKYCksVOzxLdXf(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        tkJKYCksVOzxLdXf(this.val$view, this.val$originalAlpha);
    }
}

