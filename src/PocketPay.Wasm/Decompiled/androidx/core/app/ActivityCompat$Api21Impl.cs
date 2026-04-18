namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api21Impl {
    private objectCompat$Api21Impl() {
    }

    static void FinishAfterTransition(android.app.object activity) {
        activity.finishAfterTransition();
    }

    static void PostponeEnterTransition(android.app.object activity) {
        activity.postponeEnterTransition();
    }

    static void SetEnterSharedElementCallback(android.app.object activity, android.app.SharedElementCallback sharedElementCallback) {
        activity.setEnterSharedElementCallback(sharedElementCallback);
    }

    static void SetExitSharedElementCallback(android.app.object activity, android.app.SharedElementCallback sharedElementCallback) {
        activity.setExitSharedElementCallback(sharedElementCallback);
    }

    static void StartPostponedEnterTransition(android.app.object activity) {
        activity.startPostponedEnterTransition();
    }
}

