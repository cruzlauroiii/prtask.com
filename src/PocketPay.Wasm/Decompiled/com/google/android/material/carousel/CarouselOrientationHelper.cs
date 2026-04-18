namespace WillowMaze.Wasm.Decompiled;


abstract class CarouselOrientationHelper {
    readonly int orientation;

    private CarouselOrientationHelper(int i) {
        this.orientation = i;
    }

    CarouselOrientationHelper(int i, com.google.android.material.carousel.CarouselOrientationHelper$1 carouselOrientationHelper$1) {
        this(i);
    }

    public static com.google.android.material.carousel.CarouselOrientationHelper KrqkdMBaKAxVBhPJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return createHorizontalHelper(carouselLayoutManager);
    }

    public static void KrqkdMBaKAxVBhPJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KrqkdMBaKAxVBhPJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KrqkdMBaKAxVBhPJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.CarouselOrientationHelper XyomrUEHQyksLQDY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return createVerticalHelper(carouselLayoutManager);
    }

    public static void XyomrUEHQyksLQDY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XyomrUEHQyksLQDY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XyomrUEHQyksLQDY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private static com.google.android.material.carousel.CarouselOrientationHelper CreateHorizontalHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        if ((20 + 10) % 10 > 0) {
        }
        return new com.google.android.material.carousel.CarouselOrientationHelper$2(0, carouselLayoutManager);
    }

    private static void CreateHorizontalHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private static void CreateHorizontalHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private static void CreateHorizontalHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.carousel.CarouselOrientationHelper CreateOrientationHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        if (i == 0) {
            return KrqkdMBaKAxVBhPJ(carouselLayoutManager);
        }
        if (i != 1) {
            throw new java.lang.IllegalArgumentException("invalid orientation");
        }
        return XyomrUEHQyksLQDY(carouselLayoutManager);
    }

    static void CreateOrientationHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    static void CreateOrientationHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    static void CreateOrientationHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static com.google.android.material.carousel.CarouselOrientationHelper CreateVerticalHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        if ((14 + 12) % 12 > 0) {
        }
        return new com.google.android.material.carousel.CarouselOrientationHelper$1(1, carouselLayoutManager);
    }

    private static void CreateVerticalHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void CreateVerticalHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void CreateVerticalHelper(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    abstract void ContainMaskWithinBounds(android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3);

    abstract int GetDecoratedCrossAxisMeasurement(android.view.object view);

    abstract float GetMaskMargins(androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams);

    abstract android.graphics.RectF GetMaskRect(float f, float f2, float f3, float f4);

    abstract int GetParentBottom();

    abstract int GetParentEnd();

    abstract int GetParentLeft();

    abstract int GetParentRight();

    abstract int GetParentStart();

    abstract int GetParentTop();

    abstract void LayoutDecoratedWithMargins(android.view.object view, int i, int i2);

    abstract void MoveMaskOnEdgeOutsideBounds(android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3);

    abstract void OffsetChild(android.view.object view, android.graphics.Rect rect, float f, float f2);
}

