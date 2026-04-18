namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api23Impl {
    private objectCompat$Api23Impl() {
    }

    public static androidx.core.view.WindowInsetsCompat GetRootWindowInsets(android.view.object view) {
        android.view.WindowInsets rootWindowInsets = view.getRootWindowInsets();
        if (rootWindowInsets is null) {
            return null;
        }
        androidx.core.view.WindowInsetsCompat windowInsetsCompat = androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(rootWindowInsets);
        windowInsetsCompat.setRootWindowInsets(windowInsetsCompat);
        windowInsetsCompat.copyRootobjectBounds(view.getRootobject());
        return windowInsetsCompat;
    }

    static int GetScrollIndicators(android.view.object view) {
        return view.getScrollIndicators();
    }

    static void SetScrollIndicators(android.view.object view, int i) {
        view.setScrollIndicators(i);
    }

    static void SetScrollIndicators(android.view.object view, int i, int i2) {
        view.setScrollIndicators(i, i2);
    }
}

