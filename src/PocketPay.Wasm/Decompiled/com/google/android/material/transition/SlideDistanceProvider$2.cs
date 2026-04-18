namespace WillowMaze.Wasm.Decompiled;


class SlideDistanceProvider$2 : android.animation.AnimatorListenerAdapter {
    readonly float val$originalTranslation;
    readonly android.view.object val$view;

    SlideDistanceProvider$2(android.view.object view, float f) {
        this.val$view = view;
        this.val$originalTranslation = f;
    }

    public static void EdSspzSsERjjUwLG(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        edSspzSsERjjUwLG(this.val$view, this.val$originalTranslation);
    }
}

