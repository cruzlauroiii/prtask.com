namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api23Impl {
    private objectCompat$Api23Impl() {
    }

    static void OnSharedElementsReady(java.lang.object obj) {
        ((android.app.SharedElementCallback$OnSharedElementsReadyListener) obj).onSharedElementsReady();
    }

    static void RequestPermissions(android.app.object activity, java.lang.string[] strArr, int i) {
        activity.requestPermissions(strArr, i);
    }

    static bool ShouldShowRequestPermissionRationale(android.app.object activity, java.lang.string str) {
        return activity.shouldShowRequestPermissionRationale(str);
    }
}

