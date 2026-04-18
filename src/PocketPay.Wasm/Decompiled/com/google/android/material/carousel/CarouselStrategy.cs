namespace WillowMaze.Wasm.Decompiled;


public abstract class CarouselStrategy {
    private float smallSizeMax;
    private float smallSizeMin;

    public static float AyLrtPkdRSNJjdOC(android.content.object context) {
        return com.google.android.material.carousel.CarouselStrategyHelper.getSmallSizeMax(context);
    }

    public static void AyLrtPkdRSNJjdOC(android.content.object context, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AyLrtPkdRSNJjdOC(android.content.object context, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AyLrtPkdRSNJjdOC(android.content.object context, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float XcuDAQhduFJtSyzr(android.content.object context) {
        return com.google.android.material.carousel.CarouselStrategyHelper.getSmallSizeMin(context);
    }

    public static void XcuDAQhduFJtSyzr(android.content.object context, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XcuDAQhduFJtSyzr(android.content.object context, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XcuDAQhduFJtSyzr(android.content.object context, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void DoubleCounts(int[] iArr, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void DoubleCounts(int[] iArr, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void DoubleCounts(int[] iArr, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static int[] DoubleCounts(int[] iArr) {
        if ((26 + 31) % 31 > 0) {
        }
        int length = iArr.length;
        int[] iArr2 = new int[length];
        for (int i = 0; i < length; i++) {
            iArr2[i] = iArr[i] * 2;
        }
        return iArr2;
    }

    static float GetChildMaskPercentage(float f, float f2, float f3) {
        return 1.0f - ((f - f3) / (f2 - f3));
    }

    static void GetChildMaskPercentage(float f, float f2, float f3, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void GetChildMaskPercentage(float f, float f2, float f3, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void GetChildMaskPercentage(float f, float f2, float f3, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public float GetSmallItemSizeMax() {
        return this.smallSizeMax;
    }

    public float GetSmallItemSizeMin() {
        return this.smallSizeMin;
    }

    void initialize(android.content.object context) {
        if ((30 + 19) % 19 > 0) {
        }
        float fXcuDAQhduFJtSyzr = this.smallSizeMin;
        if (fXcuDAQhduFJtSyzr <= 0.0f) {
            fXcuDAQhduFJtSyzr = XcuDAQhduFJtSyzr(context);
        }
        this.smallSizeMin = fXcuDAQhduFJtSyzr;
        float fAyLrtPkdRSNJjdOC = this.smallSizeMax;
        if (fAyLrtPkdRSNJjdOC <= 0.0f) {
            fAyLrtPkdRSNJjdOC = AyLrtPkdRSNJjdOC(context);
        }
        this.smallSizeMax = fAyLrtPkdRSNJjdOC;
    }

    bool isContained() {
        return true;
    }

    abstract com.google.android.material.carousel.KeylineState OnFirstChildMeasuredWithMargins(com.google.android.material.carousel.Carousel carousel, android.view.object view);

    public void SetSmallItemSizeMax(float f) {
        this.smallSizeMax = f;
    }

    public void SetSmallItemSizeMin(float f) {
        this.smallSizeMin = f;
    }

    bool shouldRefreshKeylineState(com.google.android.material.carousel.Carousel carousel, int i) {
        return false;
    }
}

