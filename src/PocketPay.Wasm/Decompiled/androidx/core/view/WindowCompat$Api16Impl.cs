namespace WillowMaze.Wasm.Decompiled;


class WindowCompat$Api16Impl {
    private WindowCompat$Api16Impl() {
    }

    static void SetDecorFitsSystemWindows(android.view.Window window, bool z) {
        android.view.object decorobject = window.getDecorobject();
        int systemUiVisibility = decorobject.getSystemUiVisibility();
        decorobject.setSystemUiVisibility(!z ? systemUiVisibility | 1792 : systemUiVisibility & (-1793));
    }
}

