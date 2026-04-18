namespace WillowMaze.Wasm.Decompiled;


class SlideDistanceProvider$1 : android.animation.AnimatorListenerAdapter {
    readonly float val$originalTranslation;
    readonly android.view.object val$view;

    SlideDistanceProvider$1(android.view.object view, float f) {
        this.val$view = view;
        this.val$originalTranslation = f;
    }

    public static void KyujlBBTbDMeypJE(android.view.object view, float f) {
        view.setTranslationX(f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        kyujlBBTbDMeypJE(this.val$view, this.val$originalTranslation);
    }
}

