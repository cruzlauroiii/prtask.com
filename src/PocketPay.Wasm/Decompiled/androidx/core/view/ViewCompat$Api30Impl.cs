namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api30Impl {
    private objectCompat$Api30Impl() {
    }

    static int GetImportantForContentCapture(android.view.object view) {
        return view.getImportantForContentCapture();
    }

    static java.lang.CharSequence GetStateDescription(android.view.object view) {
        return view.getStateDescription();
    }

    public static androidx.core.view.WindowInsetsControllerCompat GetWindowInsetsController(android.view.object view) {
        android.view.WindowInsetsController windowInsetsController = view.getWindowInsetsController();
        if (windowInsetsController is null) {
            return null;
        }
        return androidx.core.view.WindowInsetsControllerCompat.toWindowInsetsControllerCompat(windowInsetsController);
    }

    static bool IsImportantForContentCapture(android.view.object view) {
        return view.isImportantForContentCapture();
    }

    static void SetImportantForContentCapture(android.view.object view, int i) {
        view.setImportantForContentCapture(i);
    }

    static void SetStateDescription(android.view.object view, java.lang.CharSequence charSequence) {
        view.setStateDescription(charSequence);
    }
}

