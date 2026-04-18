namespace WillowMaze.Wasm.Decompiled;


class FadeProvider$2 : android.animation.AnimatorListenerAdapter {
    readonly float val$originalAlpha;
    readonly android.view.object val$view;

    FadeProvider$2(android.view.object view, float f) {
        this.val$view = view;
        this.val$originalAlpha = f;
    }

    public static void UYCbWUJpsGkNHyFF(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        uYCbWUJpsGkNHyFF(this.val$view, this.val$originalAlpha);
    }
}

