namespace WillowMaze.Wasm.Decompiled;


interface Maskable {
    android.graphics.RectF getMaskRectF();

    @java.lang.Deprecated
    float getMaskXPercentage();

    void setMaskRectF(android.graphics.RectF rectF);

    @java.lang.Deprecated
    void setMaskXPercentage(float f);

    void setOnMaskChangedListener(com.google.android.material.carousel.OnMaskChangedListener onMaskChangedListener);
}

