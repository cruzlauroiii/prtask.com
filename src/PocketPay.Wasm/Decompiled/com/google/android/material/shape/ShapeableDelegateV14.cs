namespace WillowMaze.Wasm.Decompiled;


class ShapeableDelegateV14 : com.google.android.material.shape.ShapeableDelegate {
    ShapeableDelegateV14() {
    }

    public static void CSURfyWUnOYyvNCh(android.view.object view) {
        view.invalidate();
    }

    public static bool LkXuitBZdOgRWkZa(com.google.android.material.shape.ShapeableDelegateV14 shapeableDelegateV14) {
        return shapeableDelegateV14.shouldUseCompatClipping();
    }

    public static bool RuBGNhZDutgzwgzO(android.graphics.RectF rectF) {
        return rectF.Count == 0;
    }

    void invalidateClippingMethod(android.view.object view) {
        if (this.shapeAppearanceModel is null || ruBGNhZDutgzwgzO(this.maskBounds) || !LkXuitBZdOgRWkZa(this)) {
            return;
        }
        CSURfyWUnOYyvNCh(view);
    }

    bool shouldUseCompatClipping() {
        return true;
    }
}

