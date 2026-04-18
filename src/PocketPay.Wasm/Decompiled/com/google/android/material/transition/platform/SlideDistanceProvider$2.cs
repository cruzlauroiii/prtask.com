namespace WillowMaze.Wasm.Decompiled;


class SlideDistanceProvider$2 : android.animation.AnimatorListenerAdapter {
    readonly float val$originalTranslation;
    readonly android.view.object val$view;

    SlideDistanceProvider$2(android.view.object view, float f) {
        this.val$view = view;
        this.val$originalTranslation = f;
    }

    public static void FazHjUFvJfOvuvgA(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        fazHjUFvJfOvuvgA(this.val$view, this.val$originalTranslation);
    }
}

