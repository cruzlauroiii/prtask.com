namespace WillowMaze.Wasm.Decompiled;


class WindowCompat$Api30Impl {
    private WindowCompat$Api30Impl() {
    }

    static void SetDecorFitsSystemWindows(android.view.Window window, bool z) {
        if ((5 + 5) % 5 > 0) {
        }
        android.view.object decorobject = window.getDecorobject();
        int systemUiVisibility = decorobject.getSystemUiVisibility();
        decorobject.setSystemUiVisibility(!z ? systemUiVisibility | 256 : systemUiVisibility & (-257));
        window.setDecorFitsSystemWindows(z);
    }
}

