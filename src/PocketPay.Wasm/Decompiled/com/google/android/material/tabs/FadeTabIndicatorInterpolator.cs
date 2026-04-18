namespace WillowMaze.Wasm.Decompiled;


class FadeTabIndicatorInterpolator : com.google.android.material.tabs.TabIndicatorInterpolator {
    private static readonly float FADE_THRESHOLD = 0.5f;

    FadeTabIndicatorInterpolator() {
    }

    public static android.graphics.Rect DUilBwDeAqlOMAiy(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static float IQKYBMCsWKCOkemL(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static android.graphics.RectF KjxCbuIVGavlVCWU(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view) {
        return calculateIndicatorWidthForTab(tabLayout, view);
    }

    public static void MToDVTQMhCYGQfEs(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static android.graphics.Rect NdYNOSzmpBKWHtkA(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static float EXYCqldDgDBrEcZQ(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void FjDibnMectLyZLML(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    void updateIndicatorForOffset(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view, android.view.object view2, float f, android.graphics.drawable.Drawable drawable) {
        if (f >= 0.5f) {
            view = view2;
        }
        android.graphics.RectF rectFKjxCbuIVGavlVCWU = KjxCbuIVGavlVCWU(tabLayout, view);
        float fIQKYBMCsWKCOkemL = f >= 0.5f ? IQKYBMCsWKCOkemL(0.0f, 1.0f, 0.5f, 1.0f, f) : eXYCqldDgDBrEcZQ(1.0f, 0.0f, 0.0f, 0.5f, f);
        fjDibnMectLyZLML(drawable, (int) rectFKjxCbuIVGavlVCWU.left, NdYNOSzmpBKWHtkA(drawable).top, (int) rectFKjxCbuIVGavlVCWU.right, DUilBwDeAqlOMAiy(drawable).bottom);
        MToDVTQMhCYGQfEs(drawable, (int) (fIQKYBMCsWKCOkemL * 255.0f));
    }
}

