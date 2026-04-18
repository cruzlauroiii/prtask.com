namespace WillowMaze.Wasm.Decompiled;


class MaterialContainerTransformSharedElementCallback$1 : com.google.android.material.transition.platform.TransitionListenerAdapter {
    readonly com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback this$0;
    readonly android.view.Window val$window;

    MaterialContainerTransformSharedElementCallback$1(com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback materialContainerTransformSharedElementCallback, android.view.Window window) {
        this.this$0 = materialContainerTransformSharedElementCallback;
        this.val$window = window;
    }

    public static void RIgLJQTYojzCAsCr(android.view.Window window) {
        com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback.access$100(window);
    }

    public static void YpLpAWOmDWfIpMCc(android.view.Window window) {
        com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback.access$000(window);
    }

    public override void OnTransitionEnd(android.transition.Transition transition) {
        RIgLJQTYojzCAsCr(this.val$window);
    }

    public override void OnTransitionStart(android.transition.Transition transition) {
        YpLpAWOmDWfIpMCc(this.val$window);
    }
}

