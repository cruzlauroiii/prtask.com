namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api20Impl {
    private objectCompat$Api20Impl() {
    }

    static android.view.WindowInsets DispatchApplyWindowInsets(android.view.object view, android.view.WindowInsets windowInsets) {
        return view.dispatchApplyWindowInsets(windowInsets);
    }

    static android.view.WindowInsets OnApplyWindowInsets(android.view.object view, android.view.WindowInsets windowInsets) {
        return view.onApplyWindowInsets(windowInsets);
    }

    static void RequestApplyInsets(android.view.object view) {
        view.requestApplyInsets();
    }
}

