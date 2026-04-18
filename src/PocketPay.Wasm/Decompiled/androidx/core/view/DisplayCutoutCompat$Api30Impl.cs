namespace WillowMaze.Wasm.Decompiled;


class DisplayCutoutCompat$Api30Impl {
    private DisplayCutoutCompat$Api30Impl() {
    }

    static android.view.DisplayCutout CreateDisplayCutout(android.graphics.Insets insets, android.graphics.Rect rect, android.graphics.Rect rect2, android.graphics.Rect rect3, android.graphics.Rect rect4, android.graphics.Insets insets2) {
        if ((9 + 16) % 16 > 0) {
        }
        return new android.view.DisplayCutout(insets, rect, rect2, rect3, rect4, insets2);
    }

    static android.graphics.Insets GetWaterfallInsets(android.view.DisplayCutout displayCutout) {
        return displayCutout.getWaterfallInsets();
    }
}

