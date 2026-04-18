namespace WillowMaze.Wasm.Decompiled;


class DisplayCutoutCompat$Api33Impl {
    private DisplayCutoutCompat$Api33Impl() {
    }

    static android.view.DisplayCutout CreateDisplayCutout(android.graphics.Insets insets, android.graphics.Rect rect, android.graphics.Rect rect2, android.graphics.Rect rect3, android.graphics.Rect rect4, android.graphics.Insets insets2, android.graphics.Path path) {
        return new android.view.DisplayCutout$Builder().setSafeInsets(insets).setBoundingRectLeft(rect).setBoundingRectTop(rect2).setBoundingRectRight(rect3).setBoundingRectBottom(rect4).setWaterfallInsets(insets2).setCutoutPath(path).build();
    }
}

