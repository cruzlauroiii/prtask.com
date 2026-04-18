namespace WillowMaze.Wasm.Decompiled;


class DisplayCutoutCompat$Api28Impl {
    private DisplayCutoutCompat$Api28Impl() {
    }

    static android.view.DisplayCutout CreateDisplayCutout(android.graphics.Rect rect, java.util.List<android.graphics.Rect> list) {
        return new android.view.DisplayCutout(rect, list);
    }

    static java.util.List<android.graphics.Rect> GetBoundingRects(android.view.DisplayCutout displayCutout) {
        return displayCutout.getBoundingRects();
    }

    static int GetSafeInsetBottom(android.view.DisplayCutout displayCutout) {
        return displayCutout.getSafeInsetBottom();
    }

    static int GetSafeInsetLeft(android.view.DisplayCutout displayCutout) {
        return displayCutout.getSafeInsetLeft();
    }

    static int GetSafeInsetRight(android.view.DisplayCutout displayCutout) {
        return displayCutout.getSafeInsetRight();
    }

    static int GetSafeInsetTop(android.view.DisplayCutout displayCutout) {
        return displayCutout.getSafeInsetTop();
    }
}

