namespace WillowMaze.Wasm.Decompiled;


public class CarouselLayoutManager : androidx.recyclerview.widget.Recyclerobject$LayoutManager : com.google.android.material.carousel.Carousel, androidx.recyclerview.widget.Recyclerobject$SmoothScroller$ScrollVectorProvider {
    public static readonly int ALIGNMENT_CENTER = 1;
    public static readonly int ALIGNMENT_START = 0;
    public static readonly int HORIZONTAL = 0;
    private static readonly java.lang.string TAG = "CarouselLayoutManager";
    public static readonly int VERTICAL = 1;
    private int carouselAlignment;
    private com.google.android.material.carousel.CarouselStrategy carouselStrategy;
    private int currentEstimatedPosition;
    private int currentFillStartPosition;
    private com.google.android.material.carousel.KeylineState currentKeylineState;
    private readonly com.google.android.material.carousel.CarouselLayoutManager$DebugItemDecoration debugItemDecoration;
    private bool isDebuggingEnabled;
    private com.google.android.material.carousel.KeylineStateList keylineStateList;
    private java.util.Dictionary<java.lang.int, com.google.android.material.carousel.KeylineState> keylineStatePositionDictionary;
    private int lastItemCount;
    int maxScroll;
    int minScroll;
    private com.google.android.material.carousel.CarouselOrientationHelper orientationHelper;
    private readonly android.view.object$OnLayoutChangeListener recyclerobjectSizeChangeListener;
    int scrollOffset;

    public static void $r8$lambda$EVyYoVT11DpL60suE9bxns8qbCM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        sFbJRqrbVscRsieh(carouselLayoutManager);
    }

    public static void $r8$lambda$EVyYoVT11DpL60suE9bxns8qbCM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void $r8$lambda$EVyYoVT11DpL60suE9bxns8qbCM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void $r8$lambda$EVyYoVT11DpL60suE9bxns8qbCM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public CarouselLayoutManager() {
        this(new com.google.android.material.carousel.MultiBrowseCarouselStrategy());
    }

    public CarouselLayoutManager(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        this.isDebuggingEnabled = false;
        this.debugItemDecoration = new com.google.android.material.carousel.CarouselLayoutManager$DebugItemDecoration();
        this.currentFillStartPosition = 0;
        this.recyclerobjectSizeChangeListener = new com.google.android.material.carousel.CarouselLayoutManager$$ExternalSyntheticLambda1(this);
        this.currentEstimatedPosition = -1;
        this.carouselAlignment = 0;
        QGVQaeXkcqMWZGxk(this, new com.google.android.material.carousel.MultiBrowseCarouselStrategy());
        WXfpmEjKSChPqUKj(this, context, attributeHashSet);
    }

    public CarouselLayoutManager(com.google.android.material.carousel.CarouselStrategy carouselStrategy) {
        this(carouselStrategy, 0);
    }

    public CarouselLayoutManager(com.google.android.material.carousel.CarouselStrategy carouselStrategy, int i) {
        if ((5 + 18) % 18 > 0) {
        }
        this.isDebuggingEnabled = false;
        this.debugItemDecoration = new com.google.android.material.carousel.CarouselLayoutManager$DebugItemDecoration();
        this.currentFillStartPosition = 0;
        this.recyclerobjectSizeChangeListener = new com.google.android.material.carousel.CarouselLayoutManager$$ExternalSyntheticLambda1(this);
        this.currentEstimatedPosition = -1;
        this.carouselAlignment = 0;
        ttKmwznADdlCdeIE(this, carouselStrategy);
        BKiybsPxdssDRuCK(this, i);
    }

    public static float ACFnOEYSrJIHAzHu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2) {
        return carouselLayoutManager.addStart(f, f2);
    }

    public static void ACFnOEYSrJIHAzHu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, char c, int i, float f3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ACFnOEYSrJIHAzHu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, int i, char c, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void ACFnOEYSrJIHAzHu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, bool z, int i, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AODKvCAztkGYefOW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getHeight();
    }

    public static void AODKvCAztkGYefOW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AODKvCAztkGYefOW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AODKvCAztkGYefOW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ATLOsERMfYGXBHAe(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ATLOsERMfYGXBHAe(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ATLOsERMfYGXBHAe(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ATLOsERMfYGXBHAe(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static int AVVwGeecoEbWohLE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getPaddingTop();
    }

    public static void AVVwGeecoEbWohLE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AVVwGeecoEbWohLE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AVVwGeecoEbWohLE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int AXkrpeSDmTRNyicI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState) {
        return carouselLayoutManager.getScrollOffsetForPosition(i, keylineState);
    }

    public static void AXkrpeSDmTRNyicI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AXkrpeSDmTRNyicI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, int i2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AXkrpeSDmTRNyicI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AgUbtancjCCyHZcO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentTop();
    }

    public static void AgUbtancjCCyHZcO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AgUbtancjCCyHZcO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AgUbtancjCCyHZcO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AlCTdGDzajVKvfeB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.refreshKeylineState();
    }

    public static void AlCTdGDzajVKvfeB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AlCTdGDzajVKvfeB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AlCTdGDzajVKvfeB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.CarouselLayoutManager$KeylineRange AmbhOdAPIioTQGRz(java.util.List list, float f, bool z) {
        return getSurroundingKeylineRange(list, f, z);
    }

    public static void AmbhOdAPIioTQGRz(java.util.List list, float f, bool z, byte b, char c, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AmbhOdAPIioTQGRz(java.util.List list, float f, bool z, float f2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AmbhOdAPIioTQGRz(java.util.List list, float f, bool z, float f2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int AnoAXNGRJBiKlaoS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getPaddingBottom();
    }

    public static void AnoAXNGRJBiKlaoS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AnoAXNGRJBiKlaoS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AnoAXNGRJBiKlaoS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BEJuoegUKgBHJBdY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BEJuoegUKgBHJBdY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BEJuoegUKgBHJBdY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool BEJuoegUKgBHJBdY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.isLocOffsetOutOfFillBoundsEnd(f, carouselLayoutManager$KeylineRange);
    }

    public static int BIOVjOxkOvThLmxP(int i) {
        return java.lang.Math.abs(i);
    }

    public static void BIOVjOxkOvThLmxP(int i, int i2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BIOVjOxkOvThLmxP(int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BIOVjOxkOvThLmxP(int i, short s, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BIQIxpKcWFLTGdgP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BIQIxpKcWFLTGdgP(java.lang.stringBuilder sb, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BIQIxpKcWFLTGdgP(java.lang.stringBuilder sb, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BIQIxpKcWFLTGdgP(java.lang.stringBuilder sb, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BJUPikpKyMLwosjG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BJUPikpKyMLwosjG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BJUPikpKyMLwosjG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool BJUPikpKyMLwosjG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static void BKiybsPxdssDRuCK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        carouselLayoutManager.setOrientation(i);
    }

    public static void BKiybsPxdssDRuCK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BKiybsPxdssDRuCK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BKiybsPxdssDRuCK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float BKjFixnYoADNHgCo(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams) {
        return carouselOrientationHelper.getMaskMargins(recyclerobject$LayoutParams);
    }

    public static void BKjFixnYoADNHgCo(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKjFixnYoADNHgCo(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BKjFixnYoADNHgCo(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object BLOSjWsxwbTyZZzp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void BLOSjWsxwbTyZZzp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BLOSjWsxwbTyZZzp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BLOSjWsxwbTyZZzp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BTLqaQJCXgDsfrSH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.refreshKeylineState();
    }

    public static void BTLqaQJCXgDsfrSH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTLqaQJCXgDsfrSH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BTLqaQJCXgDsfrSH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations BahyFmCVOcBbIFtg(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i) {
        return carouselLayoutManager.makeChildCalculations(recyclerobject$Recycler, f, i);
    }

    public static void BahyFmCVOcBbIFtg(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, byte b, float f2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BahyFmCVOcBbIFtg(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, float f2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BahyFmCVOcBbIFtg(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, short s, float f2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BbVaYhklVSFMkHzo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BbVaYhklVSFMkHzo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BbVaYhklVSFMkHzo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BbVaYhklVSFMkHzo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static android.view.object BtIukEmQucheCGDO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void BtIukEmQucheCGDO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BtIukEmQucheCGDO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BtIukEmQucheCGDO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object BtsxFXmEhxkfbgpX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void BtsxFXmEhxkfbgpX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BtsxFXmEhxkfbgpX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BtsxFXmEhxkfbgpX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object CAbRpZQldcsSQjtq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void CAbRpZQldcsSQjtq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CAbRpZQldcsSQjtq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CAbRpZQldcsSQjtq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams CRTNCYBLeIqcOCgq(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void CRTNCYBLeIqcOCgq(android.view.object view, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CRTNCYBLeIqcOCgq(android.view.object view, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CRTNCYBLeIqcOCgq(android.view.object view, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState CRVguyyEjNFCVoyA(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getDefaultState();
    }

    public static void CRVguyyEjNFCVoyA(com.google.android.material.carousel.KeylineStateList keylineStateList, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CRVguyyEjNFCVoyA(com.google.android.material.carousel.KeylineStateList keylineStateList, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CRVguyyEjNFCVoyA(com.google.android.material.carousel.KeylineStateList keylineStateList, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CnscQVjAYmspmnrz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CnscQVjAYmspmnrz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CnscQVjAYmspmnrz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CnscQVjAYmspmnrz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isHorizontal();
    }

    public static float DElIeRVHJpbmeodl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, float f2, android.graphics.Rect rect) {
        return carouselLayoutManager.offsetChild(view, f, f2, rect);
    }

    public static void DElIeRVHJpbmeodl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, float f2, android.graphics.Rect rect, float f3, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DElIeRVHJpbmeodl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, float f2, android.graphics.Rect rect, java.lang.string str, float f3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DElIeRVHJpbmeodl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, float f2, android.graphics.Rect rect, short s, java.lang.string str, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState DFklPKGOsVPqgQBZ(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getEndState();
    }

    public static void DFklPKGOsVPqgQBZ(com.google.android.material.carousel.KeylineStateList keylineStateList, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DFklPKGOsVPqgQBZ(com.google.android.material.carousel.KeylineStateList keylineStateList, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DFklPKGOsVPqgQBZ(com.google.android.material.carousel.KeylineStateList keylineStateList, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DOJcvbPqDKDkbAsU(java.util.List list, int i) {
        return list[i);
    }

    public static void DOJcvbPqDKDkbAsU(java.util.List list, int i, char c, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DOJcvbPqDKDkbAsU(java.util.List list, int i, float f, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DOJcvbPqDKDkbAsU(java.util.List list, int i, bool z, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DPvuIEVsYnTHFiXt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getHeight();
    }

    public static void DPvuIEVsYnTHFiXt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DPvuIEVsYnTHFiXt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DPvuIEVsYnTHFiXt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static float DTQAdZprQatynTVu(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void DTQAdZprQatynTVu(com.google.android.material.carousel.KeylineState keylineState, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DTQAdZprQatynTVu(com.google.android.material.carousel.KeylineState keylineState, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DTQAdZprQatynTVu(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static float DfvyfoqPWKzinJsP(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void DfvyfoqPWKzinJsP(com.google.android.material.carousel.KeylineState keylineState, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DfvyfoqPWKzinJsP(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DfvyfoqPWKzinJsP(com.google.android.material.carousel.KeylineState keylineState, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int EGqlVEGAfpPWKjyo(int i, int i2, int i3, int i4, bool z) {
        return getChildMeasureSpec(i, i2, i3, i4, z);
    }

    public static void EGqlVEGAfpPWKjyo(int i, int i2, int i3, int i4, bool z, java.lang.string str, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EGqlVEGAfpPWKjyo(int i, int i2, int i3, int i4, bool z, short s, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void EGqlVEGAfpPWKjyo(int i, int i2, int i3, int i4, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float EHjGwTZWVQKBVnWO(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void EHjGwTZWVQKBVnWO(android.graphics.RectF rectF, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EHjGwTZWVQKBVnWO(android.graphics.RectF rectF, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EHjGwTZWVQKBVnWO(android.graphics.RectF rectF, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ENrgMOCPKOOqPDMO(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void ENrgMOCPKOOqPDMO(com.google.android.material.carousel.KeylineState keylineState, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ENrgMOCPKOOqPDMO(com.google.android.material.carousel.KeylineState keylineState, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ENrgMOCPKOOqPDMO(com.google.android.material.carousel.KeylineState keylineState, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EUJyBjXFtUilnvxL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EUJyBjXFtUilnvxL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EUJyBjXFtUilnvxL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool EUJyBjXFtUilnvxL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.canScrollHorizontally();
    }

    public static void EgVVTOKTSryUolXV(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.requestLayout();
    }

    public static void EgVVTOKTSryUolXV(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EgVVTOKTSryUolXV(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EgVVTOKTSryUolXV(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object EoHYDezcTIAXmNjW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void EoHYDezcTIAXmNjW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EoHYDezcTIAXmNjW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EoHYDezcTIAXmNjW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int EoQEWhHiKJXedoJC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState) {
        return carouselLayoutManager.getScrollOffsetForPosition(i, keylineState);
    }

    public static void EoQEWhHiKJXedoJC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, char c, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EoQEWhHiKJXedoJC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, char c, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EoQEWhHiKJXedoJC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EtciMkbpezAVbYbr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EtciMkbpezAVbYbr(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EtciMkbpezAVbYbr(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EtciMkbpezAVbYbr(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EznWWKrOSLLOrKRX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EznWWKrOSLLOrKRX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EznWWKrOSLLOrKRX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool EznWWKrOSLLOrKRX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static float FAwHZWFoAVHUyeEJ(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void FAwHZWFoAVHUyeEJ(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FAwHZWFoAVHUyeEJ(com.google.android.material.carousel.KeylineState keylineState, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FAwHZWFoAVHUyeEJ(com.google.android.material.carousel.KeylineState keylineState, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FDjvUDUXTWhjGnZX(java.lang.string str, int i, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FDjvUDUXTWhjGnZX(java.lang.string str, int i, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FDjvUDUXTWhjGnZX(java.lang.string str, int i, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FDjvUDUXTWhjGnZX(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int FLYZXjGnmDqZVyaD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void FLYZXjGnmDqZVyaD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FLYZXjGnmDqZVyaD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FLYZXjGnmDqZVyaD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float FMaaCOisNlhCzWku(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.getMaskedItemSizeForLocOffset(f, carouselLayoutManager$KeylineRange);
    }

    public static void FMaaCOisNlhCzWku(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, short s, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FMaaCOisNlhCzWku(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, float f2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FMaaCOisNlhCzWku(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, java.lang.string str, float f2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FWFSacyIvExRKAfj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void FWFSacyIvExRKAfj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FWFSacyIvExRKAfj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FWFSacyIvExRKAfj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int FbbzKnKZBWQgNoxr(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void FbbzKnKZBWQgNoxr(java.lang.string str, java.lang.string str2, float f, int i, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void FbbzKnKZBWQgNoxr(java.lang.string str, java.lang.string str2, float f, short s, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FbbzKnKZBWQgNoxr(java.lang.string str, java.lang.string str2, short s, int i, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void FjuvyPMLngZlccXR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        carouselLayoutManager.removeAndRecycleobject(view, recyclerobject$Recycler);
    }

    public static void FjuvyPMLngZlccXR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FjuvyPMLngZlccXR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FjuvyPMLngZlccXR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float FlVIUewOBWrptGPR(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void FlVIUewOBWrptGPR(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FlVIUewOBWrptGPR(com.google.android.material.carousel.KeylineState keylineState, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FlVIUewOBWrptGPR(com.google.android.material.carousel.KeylineState keylineState, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FmXXQWOLNjDttMSm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void FmXXQWOLNjDttMSm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FmXXQWOLNjDttMSm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FmXXQWOLNjDttMSm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object GJHqLGrFgcjyxUDI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void GJHqLGrFgcjyxUDI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GJHqLGrFgcjyxUDI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GJHqLGrFgcjyxUDI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GXdmdcQCauubJyuX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GXdmdcQCauubJyuX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GXdmdcQCauubJyuX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GXdmdcQCauubJyuX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isHorizontal();
    }

    public static void GdLxsYuQZvTrTKXR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList) {
        carouselLayoutManager.updateCurrentKeylineStateForScrollOffset(keylineStateList);
    }

    public static void GdLxsYuQZvTrTKXR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GdLxsYuQZvTrTKXR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GdLxsYuQZvTrTKXR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GlbXDURkiFsnthif(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GlbXDURkiFsnthif(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GlbXDURkiFsnthif(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GlbXDURkiFsnthif(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isHorizontal();
    }

    public static java.lang.stringBuilder HDIRROYEzxTsXkka(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HDIRROYEzxTsXkka(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HDIRROYEzxTsXkka(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HDIRROYEzxTsXkka(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static float HJWMntluirlhGCjN(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void HJWMntluirlhGCjN(android.graphics.RectF rectF, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HJWMntluirlhGCjN(android.graphics.RectF rectF, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HJWMntluirlhGCjN(android.graphics.RectF rectF, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HLkJkLJWtnabtWDC(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void HLkJkLJWtnabtWDC(java.util.IEnumerator it, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HLkJkLJWtnabtWDC(java.util.IEnumerator it, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HLkJkLJWtnabtWDC(java.util.IEnumerator it, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HPlHZzWYdhGijAaY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void HPlHZzWYdhGijAaY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HPlHZzWYdhGijAaY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HPlHZzWYdhGijAaY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState HWXRovgNGFKEwmsQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getKeylineStateForPosition(i);
    }

    public static void HWXRovgNGFKEwmsQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HWXRovgNGFKEwmsQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HWXRovgNGFKEwmsQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator HXWuwYgNHDbXURRr(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void HXWuwYgNHDbXURRr(java.util.List list, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HXWuwYgNHDbXURRr(java.util.List list, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HXWuwYgNHDbXURRr(java.util.List list, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float HowRlLVmgHhBDWrJ(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void HowRlLVmgHhBDWrJ(com.google.android.material.carousel.KeylineState keylineState, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HowRlLVmgHhBDWrJ(com.google.android.material.carousel.KeylineState keylineState, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HowRlLVmgHhBDWrJ(com.google.android.material.carousel.KeylineState keylineState, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int HulOlzcjmbvTBzBk(int i, int i2, int i3, int i4) {
        return calculateShouldScrollBy(i, i2, i3, i4);
    }

    public static void HulOlzcjmbvTBzBk(int i, int i2, int i3, int i4, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HulOlzcjmbvTBzBk(int i, int i2, int i3, int i4, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HulOlzcjmbvTBzBk(int i, int i2, int i3, int i4, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float HuyfBzcSbSvDfWAS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getDecoratedCenterWithMargins(view);
    }

    public static void HuyfBzcSbSvDfWAS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HuyfBzcSbSvDfWAS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HuyfBzcSbSvDfWAS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static float HvRlqRmurtyVSNWb(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void HvRlqRmurtyVSNWb(float f, float f2, float f3, float f4, float f5, char c, bool z, short s, float f6) {
        double d = (42 * 210) + 210;
    }

    public static void HvRlqRmurtyVSNWb(float f, float f2, float f3, float f4, float f5, float f6, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HvRlqRmurtyVSNWb(float f, float f2, float f3, float f4, float f5, short s, bool z, float f6, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HySEmiuuKHVCPDjF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, int i2) {
        carouselLayoutManager.measureChildWithMargins(view, i, i2);
    }

    public static void HySEmiuuKHVCPDjF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, int i2, int i3, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HySEmiuuKHVCPDjF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, int i2, short s, bool z, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HySEmiuuKHVCPDjF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, int i2, short s, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IAEdacGaxgxLTISW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IAEdacGaxgxLTISW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IAEdacGaxgxLTISW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IAEdacGaxgxLTISW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static com.google.android.material.carousel.KeylineState IBeDhwoCRuFdEYln(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getEndState();
    }

    public static void IBeDhwoCRuFdEYln(com.google.android.material.carousel.KeylineStateList keylineStateList, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IBeDhwoCRuFdEYln(com.google.android.material.carousel.KeylineStateList keylineStateList, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IBeDhwoCRuFdEYln(com.google.android.material.carousel.KeylineStateList keylineStateList, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IFcjpzkGrdQVcUbc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.validateChildOrderIfDebugging();
    }

    public static void IFcjpzkGrdQVcUbc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IFcjpzkGrdQVcUbc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IFcjpzkGrdQVcUbc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float IHeXaxTvjpaceOqT(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void IHeXaxTvjpaceOqT(com.google.android.material.carousel.KeylineState keylineState, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IHeXaxTvjpaceOqT(com.google.android.material.carousel.KeylineState keylineState, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IHeXaxTvjpaceOqT(com.google.android.material.carousel.KeylineState keylineState, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string INthXnrFHaNEtXEo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void INthXnrFHaNEtXEo(java.lang.stringBuilder sb, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void INthXnrFHaNEtXEo(java.lang.stringBuilder sb, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void INthXnrFHaNEtXEo(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IRqAaqayuIlLDKMD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void IRqAaqayuIlLDKMD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IRqAaqayuIlLDKMD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IRqAaqayuIlLDKMD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IWxPPzdvkaYyrcHU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller) {
        carouselLayoutManager.startSmoothScroll(recyclerobject$SmoothScroller);
    }

    public static void IWxPPzdvkaYyrcHU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IWxPPzdvkaYyrcHU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IWxPPzdvkaYyrcHU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$SmoothScroller recyclerobject$SmoothScroller, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int IfXgNYOZxVDjrPNV(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState) {
        return carouselLayoutManager.getSmallestScrollOffsetToFocalKeyline(i, keylineState);
    }

    public static void IfXgNYOZxVDjrPNV(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IfXgNYOZxVDjrPNV(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IfXgNYOZxVDjrPNV(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ImDRpuXzDsgTPvbC(int i) {
        return java.lang.Math.abs(i);
    }

    public static void ImDRpuXzDsgTPvbC(int i, float f, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ImDRpuXzDsgTPvbC(int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ImDRpuXzDsgTPvbC(int i, bool z, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JDsEENnBvcxzDVwH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getContainerWidth();
    }

    public static void JDsEENnBvcxzDVwH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JDsEENnBvcxzDVwH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JDsEENnBvcxzDVwH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int JEZicFMeOBXodxdi(java.util.List list) {
        return list.Count;
    }

    public static void JEZicFMeOBXodxdi(java.util.List list, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JEZicFMeOBXodxdi(java.util.List list, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JEZicFMeOBXodxdi(java.util.List list, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.CarouselLayoutManager$KeylineRange JaqqHpLSvSELOVgy(java.util.List list, float f, bool z) {
        return getSurroundingKeylineRange(list, f, z);
    }

    public static void JaqqHpLSvSELOVgy(java.util.List list, float f, bool z, char c, java.lang.string str, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JaqqHpLSvSELOVgy(java.util.List list, float f, bool z, char c, java.lang.string str, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void JaqqHpLSvSELOVgy(java.util.List list, float f, bool z, java.lang.string str, char c, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JbKtPiMNNwmVbaPG(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void JbKtPiMNNwmVbaPG(android.graphics.Rect rect, int i, int i2, int i3, int i4, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JbKtPiMNNwmVbaPG(android.graphics.Rect rect, int i, int i2, int i3, int i4, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JbKtPiMNNwmVbaPG(android.graphics.Rect rect, int i, int i2, int i3, int i4, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float JraTTchZuoyILtZl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.calculateChildStartForFill(i);
    }

    public static void JraTTchZuoyILtZl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JraTTchZuoyILtZl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JraTTchZuoyILtZl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JupOshJrBtmYlFVF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getContainerSize();
    }

    public static void JupOshJrBtmYlFVF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JupOshJrBtmYlFVF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JupOshJrBtmYlFVF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JwHryTOUneGSpARZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        carouselLayoutManager.setCarouselAlignment(i);
    }

    public static void JwHryTOUneGSpARZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JwHryTOUneGSpARZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JwHryTOUneGSpARZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KAAHTHGfJTBezisS(android.view.object view, java.lang.Action runnable, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KAAHTHGfJTBezisS(android.view.object view, java.lang.Action runnable, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KAAHTHGfJTBezisS(android.view.object view, java.lang.Action runnable, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KAAHTHGfJTBezisS(android.view.object view, java.lang.Action runnable) {
        return view.post(runnable);
    }

    public static com.google.android.material.carousel.KeylineState KHppEcftfDxotZyE(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3) {
        return keylineStateList.getShiftedState(f, f2, f3);
    }

    public static void KHppEcftfDxotZyE(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KHppEcftfDxotZyE(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KHppEcftfDxotZyE(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int KLcgjpYbQdVeRppo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void KLcgjpYbQdVeRppo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KLcgjpYbQdVeRppo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KLcgjpYbQdVeRppo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static float KMrvFQPBtRqSlTfU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2) {
        return carouselLayoutManager.addEnd(f, f2);
    }

    public static void KMrvFQPBtRqSlTfU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, char c, byte b, short s, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void KMrvFQPBtRqSlTfU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, float f3, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KMrvFQPBtRqSlTfU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, short s, char c, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KVafOgYXaooBhBlf(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper) {
        return carouselOrientationHelper.getParentStart();
    }

    public static void KVafOgYXaooBhBlf(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KVafOgYXaooBhBlf(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KVafOgYXaooBhBlf(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState KWjdSMpuqsuKtlhm(com.google.android.material.carousel.CarouselStrategy carouselStrategy, com.google.android.material.carousel.Carousel carousel, android.view.object view) {
        return carouselStrategy.onFirstChildMeasuredWithMargins(carousel, view);
    }

    public static void KWjdSMpuqsuKtlhm(com.google.android.material.carousel.CarouselStrategy carouselStrategy, com.google.android.material.carousel.Carousel carousel, android.view.object view, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KWjdSMpuqsuKtlhm(com.google.android.material.carousel.CarouselStrategy carouselStrategy, com.google.android.material.carousel.Carousel carousel, android.view.object view, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KWjdSMpuqsuKtlhm(com.google.android.material.carousel.CarouselStrategy carouselStrategy, com.google.android.material.carousel.Carousel carousel, android.view.object view, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KafayzcOsHaqQgaj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2) {
        carouselLayoutManager.addobjectAtPosition(recyclerobject$Recycler, i, i2);
    }

    public static void KafayzcOsHaqQgaj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, char c, short s, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void KafayzcOsHaqQgaj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, int i3, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KafayzcOsHaqQgaj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, short s, char c, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KnjgKSCgquuWtIwS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str) {
        carouselLayoutManager.assertNotInLayoutOrScroll(str);
    }

    public static void KnjgKSCgquuWtIwS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KnjgKSCgquuWtIwS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KnjgKSCgquuWtIwS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KoXhKvvmAjkddDgM(com.google.android.material.carousel.CarouselStrategy carouselStrategy, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KoXhKvvmAjkddDgM(com.google.android.material.carousel.CarouselStrategy carouselStrategy, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KoXhKvvmAjkddDgM(com.google.android.material.carousel.CarouselStrategy carouselStrategy, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool KoXhKvvmAjkddDgM(com.google.android.material.carousel.CarouselStrategy carouselStrategy) {
        return carouselStrategy.isContained();
    }

    public static int KvKCjVJeqyKrBWDx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void KvKCjVJeqyKrBWDx(java.lang.string str, java.lang.string str2, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KvKCjVJeqyKrBWDx(java.lang.string str, java.lang.string str2, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KvKCjVJeqyKrBWDx(java.lang.string str, java.lang.string str2, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object LBgfawXDqMPoheVw(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getobject();
    }

    public static void LBgfawXDqMPoheVw(androidx.recyclerview.widget.Recyclerobject recyclerobject, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LBgfawXDqMPoheVw(androidx.recyclerview.widget.Recyclerobject recyclerobject, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LBgfawXDqMPoheVw(androidx.recyclerview.widget.Recyclerobject recyclerobject, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LElbwPXYfykdTgfs(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LElbwPXYfykdTgfs(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LElbwPXYfykdTgfs(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LElbwPXYfykdTgfs(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static int LHxODOsjtIHPPHVG(android.view.object view) {
        return view.getHeight();
    }

    public static void LHxODOsjtIHPPHVG(android.view.object view, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LHxODOsjtIHPPHVG(android.view.object view, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LHxODOsjtIHPPHVG(android.view.object view, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LXhxltkqEFYvvgan(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void LXhxltkqEFYvvgan(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LXhxltkqEFYvvgan(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LXhxltkqEFYvvgan(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LXrkQHdLGUcQOuQM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LXrkQHdLGUcQOuQM(java.lang.stringBuilder sb, java.lang.string str, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LXrkQHdLGUcQOuQM(java.lang.stringBuilder sb, java.lang.string str, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LXrkQHdLGUcQOuQM(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline LZVdDpcoBAeAuYQd(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeyline();
    }

    public static void LZVdDpcoBAeAuYQd(com.google.android.material.carousel.KeylineState keylineState, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LZVdDpcoBAeAuYQd(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LZVdDpcoBAeAuYQd(com.google.android.material.carousel.KeylineState keylineState, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState LagHpaxIbXJvPJba(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getDefaultState();
    }

    public static void LagHpaxIbXJvPJba(com.google.android.material.carousel.KeylineStateList keylineStateList, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LagHpaxIbXJvPJba(com.google.android.material.carousel.KeylineStateList keylineStateList, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LagHpaxIbXJvPJba(com.google.android.material.carousel.KeylineStateList keylineStateList, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int LdmsNZIwLJKwOnum(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void LdmsNZIwLJKwOnum(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LdmsNZIwLJKwOnum(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LdmsNZIwLJKwOnum(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int LiglyqkysolgkfaL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void LiglyqkysolgkfaL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LiglyqkysolgkfaL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LiglyqkysolgkfaL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float LlKxrFPfWYXjKKON(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void LlKxrFPfWYXjKKON(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LlKxrFPfWYXjKKON(com.google.android.material.carousel.KeylineState keylineState, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LlKxrFPfWYXjKKON(com.google.android.material.carousel.KeylineState keylineState, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object LmmzxFVmdrYUjjET(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void LmmzxFVmdrYUjjET(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LmmzxFVmdrYUjjET(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LmmzxFVmdrYUjjET(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LvKZNGgkAeShojqq(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(accessibilityEvent);
    }

    public static void LvKZNGgkAeShojqq(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.accessibility.AccessibilityEvent accessibilityEvent, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LvKZNGgkAeShojqq(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.accessibility.AccessibilityEvent accessibilityEvent, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LvKZNGgkAeShojqq(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int LzWLNloXdYWoIGOr(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getContainerSize();
    }

    public static void LzWLNloXdYWoIGOr(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LzWLNloXdYWoIGOr(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LzWLNloXdYWoIGOr(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int MAtqhpMjvxkjzEEK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentStart();
    }

    public static void MAtqhpMjvxkjzEEK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MAtqhpMjvxkjzEEK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MAtqhpMjvxkjzEEK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.RectF MCOqQDLhocFwlRGQ(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, float f, float f2, float f3, float f4) {
        return carouselOrientationHelper.getMaskRect(f, f2, f3, f4);
    }

    public static void MCOqQDLhocFwlRGQ(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, float f, float f2, float f3, float f4, byte b, bool z, float f5, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MCOqQDLhocFwlRGQ(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, float f, float f2, float f3, float f4, float f5, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MCOqQDLhocFwlRGQ(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, float f, float f2, float f3, float f4, bool z, byte b, char c, float f5) {
        double d = (42 * 210) + 210;
    }

    public static int MEAhxOMUkasMYcKj(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void MEAhxOMUkasMYcKj(int i, int i2, int i3, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MEAhxOMUkasMYcKj(int i, int i2, short s, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MEAhxOMUkasMYcKj(int i, int i2, bool z, int i3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MHPNnZLcyXMMEcmP(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3) {
        carouselOrientationHelper.containMaskWithinBounds(rectF, rectF2, rectF3);
    }

    public static void MHPNnZLcyXMMEcmP(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MHPNnZLcyXMMEcmP(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MHPNnZLcyXMMEcmP(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float MIJQzKldSjUrfkUa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.calculateChildStartForFill(i);
    }

    public static void MIJQzKldSjUrfkUa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MIJQzKldSjUrfkUa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MIJQzKldSjUrfkUa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int MMbwPmqoDFmHNVje(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return carouselLayoutManager.scrollBy(i, recyclerobject$Recycler, recyclerobject$State);
    }

    public static void MMbwPmqoDFmHNVje(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MMbwPmqoDFmHNVje(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, float f, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MMbwPmqoDFmHNVje(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int MMdmRtlWXajpQVCD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void MMdmRtlWXajpQVCD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MMdmRtlWXajpQVCD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MMdmRtlWXajpQVCD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object MaQRwmaKioZBzNoI(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i) {
        return recyclerobject$Recycler.getobjectForPosition(i);
    }

    public static void MaQRwmaKioZBzNoI(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, byte b, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MaQRwmaKioZBzNoI(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MaQRwmaKioZBzNoI(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float MdRIaRwSaHlTmCtI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.calculateChildOffsetCenterForLocation(view, f, carouselLayoutManager$KeylineRange);
    }

    public static void MdRIaRwSaHlTmCtI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, short s, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MdRIaRwSaHlTmCtI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, short s, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void MdRIaRwSaHlTmCtI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, bool z, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int MdvtEmGqKbEvAYFM(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void MdvtEmGqKbEvAYFM(int i, int i2, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MdvtEmGqKbEvAYFM(int i, int i2, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MdvtEmGqKbEvAYFM(int i, int i2, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MilSvfCulbItvyTT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MilSvfCulbItvyTT(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MilSvfCulbItvyTT(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MilSvfCulbItvyTT(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NElAeXdHPxhBDTPT(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        recyclerobject.scrollBy(i, i2);
    }

    public static void NElAeXdHPxhBDTPT(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, float f, int i3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NElAeXdHPxhBDTPT(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, short s, int i3, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NElAeXdHPxhBDTPT(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, short s, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NEmqRpnHGidARzcm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getItemMargins();
    }

    public static void NEmqRpnHGidARzcm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NEmqRpnHGidARzcm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NEmqRpnHGidARzcm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float NHMksyADoqqXpeZn(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void NHMksyADoqqXpeZn(com.google.android.material.carousel.KeylineState keylineState, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NHMksyADoqqXpeZn(com.google.android.material.carousel.KeylineState keylineState, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NHMksyADoqqXpeZn(com.google.android.material.carousel.KeylineState keylineState, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int NNRYhQapKAKOMIPj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState) {
        return carouselLayoutManager.getOffsetToScrollToPosition(i, keylineState);
    }

    public static void NNRYhQapKAKOMIPj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NNRYhQapKAKOMIPj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, int i2, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NNRYhQapKAKOMIPj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float NUdYcAFPJcpUvPpi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getDecoratedCenterWithMargins(view);
    }

    public static void NUdYcAFPJcpUvPpi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NUdYcAFPJcpUvPpi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NUdYcAFPJcpUvPpi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float NZEOLODdwMWDNkks(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void NZEOLODdwMWDNkks(android.graphics.RectF rectF, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NZEOLODdwMWDNkks(android.graphics.RectF rectF, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NZEOLODdwMWDNkks(android.graphics.RectF rectF, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NgYxBconYYoWIKUa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getPaddingBottom();
    }

    public static void NgYxBconYYoWIKUa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NgYxBconYYoWIKUa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NgYxBconYYoWIKUa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NggnthnfDXwMjQSJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getHeight();
    }

    public static void NggnthnfDXwMjQSJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NggnthnfDXwMjQSJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NggnthnfDXwMjQSJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int NiZDPDDXvzptljXb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState) {
        return carouselLayoutManager.getScrollOffsetForPosition(i, keylineState);
    }

    public static void NiZDPDDXvzptljXb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NiZDPDDXvzptljXb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NiZDPDDXvzptljXb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NnkZhQaCuxnQmKbx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getPaddingRight();
    }

    public static void NnkZhQaCuxnQmKbx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NnkZhQaCuxnQmKbx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NnkZhQaCuxnQmKbx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.CarouselLayoutManager$KeylineRange NrWDyKrVPQwvawbj(java.util.List list, float f, bool z) {
        return getSurroundingKeylineRange(list, f, z);
    }

    public static void NrWDyKrVPQwvawbj(java.util.List list, float f, bool z, byte b, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NrWDyKrVPQwvawbj(java.util.List list, float f, bool z, bool z2, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NrWDyKrVPQwvawbj(java.util.List list, float f, bool z, bool z2, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NuQkcftTiZvtMaML(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getPaddingTop();
    }

    public static void NuQkcftTiZvtMaML(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NuQkcftTiZvtMaML(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NuQkcftTiZvtMaML(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NwtfFOUukLsKkEIC(com.google.android.material.carousel.CarouselStrategy carouselStrategy, android.content.object context) {
        carouselStrategy.initialize(context);
    }

    public static void NwtfFOUukLsKkEIC(com.google.android.material.carousel.CarouselStrategy carouselStrategy, android.content.object context, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NwtfFOUukLsKkEIC(com.google.android.material.carousel.CarouselStrategy carouselStrategy, android.content.object context, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NwtfFOUukLsKkEIC(com.google.android.material.carousel.CarouselStrategy carouselStrategy, android.content.object context, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OKhEasVnNcyQujMj(androidx.recyclerview.widget.LinearSmoothScroller linearSmoothScroller, int i) {
        linearSmoothScroller.setTargetPosition(i);
    }

    public static void OKhEasVnNcyQujMj(androidx.recyclerview.widget.LinearSmoothScroller linearSmoothScroller, int i, byte b, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OKhEasVnNcyQujMj(androidx.recyclerview.widget.LinearSmoothScroller linearSmoothScroller, int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OKhEasVnNcyQujMj(androidx.recyclerview.widget.LinearSmoothScroller linearSmoothScroller, int i, java.lang.string str, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OLCYWmkCfuTbEknW(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void OLCYWmkCfuTbEknW(java.util.Dictionary map, java.lang.object obj, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OLCYWmkCfuTbEknW(java.util.Dictionary map, java.lang.object obj, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OLCYWmkCfuTbEknW(java.util.Dictionary map, java.lang.object obj, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OMRqFoLalTHDxqCF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void OMRqFoLalTHDxqCF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OMRqFoLalTHDxqCF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OMRqFoLalTHDxqCF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int OSNKPpknLVrbVPEE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getContainerSize();
    }

    public static void OSNKPpknLVrbVPEE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OSNKPpknLVrbVPEE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OSNKPpknLVrbVPEE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OcOASmOAJSuZDDyJ(int i) {
        return java.lang.Math.abs(i);
    }

    public static void OcOASmOAJSuZDDyJ(int i, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OcOASmOAJSuZDDyJ(int i, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OcOASmOAJSuZDDyJ(int i, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OqlDnkUFSiCniwan(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentRight();
    }

    public static void OqlDnkUFSiCniwan(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OqlDnkUFSiCniwan(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OqlDnkUFSiCniwan(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int OtdPvlVXZMHhrgUt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void OtdPvlVXZMHhrgUt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OtdPvlVXZMHhrgUt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OtdPvlVXZMHhrgUt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PBdUQfZztjrhlNap(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i) {
        carouselLayoutManager.addobjectsEnd(recyclerobject$Recycler, recyclerobject$State, i);
    }

    public static void PBdUQfZztjrhlNap(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PBdUQfZztjrhlNap(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PBdUQfZztjrhlNap(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline PGNulseEZZjfiZMj(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeyline();
    }

    public static void PGNulseEZZjfiZMj(com.google.android.material.carousel.KeylineState keylineState, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PGNulseEZZjfiZMj(com.google.android.material.carousel.KeylineState keylineState, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PGNulseEZZjfiZMj(com.google.android.material.carousel.KeylineState keylineState, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object PaxBHpSpxEfWcEJQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void PaxBHpSpxEfWcEJQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PaxBHpSpxEfWcEJQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PaxBHpSpxEfWcEJQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float PeSrZxTIApSXlBIw(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void PeSrZxTIApSXlBIw(com.google.android.material.carousel.KeylineState keylineState, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PeSrZxTIApSXlBIw(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PeSrZxTIApSXlBIw(com.google.android.material.carousel.KeylineState keylineState, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PhCQEkoYwqdDwsak(com.google.android.material.carousel.CarouselLayoutManager$DebugItemDecoration carouselLayoutManager$DebugItemDecoration, java.util.List list) {
        carouselLayoutManager$DebugItemDecoration.setKeylines(list);
    }

    public static void PhCQEkoYwqdDwsak(com.google.android.material.carousel.CarouselLayoutManager$DebugItemDecoration carouselLayoutManager$DebugItemDecoration, java.util.List list, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PhCQEkoYwqdDwsak(com.google.android.material.carousel.CarouselLayoutManager$DebugItemDecoration carouselLayoutManager$DebugItemDecoration, java.util.List list, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PhCQEkoYwqdDwsak(com.google.android.material.carousel.CarouselLayoutManager$DebugItemDecoration carouselLayoutManager$DebugItemDecoration, java.util.List list, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int PmuSRvYmbiOEKpkG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void PmuSRvYmbiOEKpkG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PmuSRvYmbiOEKpkG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PmuSRvYmbiOEKpkG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int PqyQNbxxLLqqRMoL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void PqyQNbxxLLqqRMoL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PqyQNbxxLLqqRMoL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PqyQNbxxLLqqRMoL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PrlZlFOjwmZhEVXW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, android.graphics.Rect rect) {
        carouselLayoutManager.calculateItemDecorationsForChild(view, rect);
    }

    public static void PrlZlFOjwmZhEVXW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, android.graphics.Rect rect, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PrlZlFOjwmZhEVXW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, android.graphics.Rect rect, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PrlZlFOjwmZhEVXW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, android.graphics.Rect rect, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PufByDAXTJXQKQHi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        carouselLayoutManager.setOrientation(i);
    }

    public static void PufByDAXTJXQKQHi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PufByDAXTJXQKQHi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PufByDAXTJXQKQHi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int PzqppJWSsnThRFtU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void PzqppJWSsnThRFtU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PzqppJWSsnThRFtU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PzqppJWSsnThRFtU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.CarouselLayoutManager$KeylineRange QAYjkmJaMIHEIPqM(java.util.List list, float f, bool z) {
        return getSurroundingKeylineRange(list, f, z);
    }

    public static void QAYjkmJaMIHEIPqM(java.util.List list, float f, bool z, byte b, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QAYjkmJaMIHEIPqM(java.util.List list, float f, bool z, int i, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QAYjkmJaMIHEIPqM(java.util.List list, float f, bool z, bool z2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float QEGaTUEIFeoJWfzB(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void QEGaTUEIFeoJWfzB(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QEGaTUEIFeoJWfzB(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QEGaTUEIFeoJWfzB(com.google.android.material.carousel.KeylineState keylineState, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QGVQaeXkcqMWZGxk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.CarouselStrategy carouselStrategy) {
        carouselLayoutManager.setCarouselStrategy(carouselStrategy);
    }

    public static void QGVQaeXkcqMWZGxk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.CarouselStrategy carouselStrategy, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QGVQaeXkcqMWZGxk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.CarouselStrategy carouselStrategy, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QGVQaeXkcqMWZGxk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.CarouselStrategy carouselStrategy, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float QPUqTcPWOHlrGagu(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void QPUqTcPWOHlrGagu(com.google.android.material.carousel.KeylineState keylineState, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QPUqTcPWOHlrGagu(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QPUqTcPWOHlrGagu(com.google.android.material.carousel.KeylineState keylineState, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int QPgUwrKMjNwyfBmG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return carouselLayoutManager.computeVerticalScrollRange(recyclerobject$State);
    }

    public static void QPgUwrKMjNwyfBmG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QPgUwrKMjNwyfBmG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QPgUwrKMjNwyfBmG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState QakxPFucQGPCNJuD(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getStartState();
    }

    public static void QakxPFucQGPCNJuD(com.google.android.material.carousel.KeylineStateList keylineStateList, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QakxPFucQGPCNJuD(com.google.android.material.carousel.KeylineStateList keylineStateList, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QakxPFucQGPCNJuD(com.google.android.material.carousel.KeylineStateList keylineStateList, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float QcgPxVbjxjnazavT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.getMaskedItemSizeForLocOffset(f, carouselLayoutManager$KeylineRange);
    }

    public static void QcgPxVbjxjnazavT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, java.lang.string str, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void QcgPxVbjxjnazavT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, bool z, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void QcgPxVbjxjnazavT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, bool z, float f2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QfdsEjKEXfgWFhQj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.updateItemCount();
    }

    public static void QfdsEjKEXfgWFhQj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QfdsEjKEXfgWFhQj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QfdsEjKEXfgWFhQj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QheyQkARbjsBIRAN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QheyQkARbjsBIRAN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QheyQkARbjsBIRAN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool QheyQkARbjsBIRAN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isHorizontal();
    }

    public static int QodWPMKCvYxCUVYV(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void QodWPMKCvYxCUVYV(int i, int i2, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QodWPMKCvYxCUVYV(int i, int i2, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QodWPMKCvYxCUVYV(int i, int i2, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QzYeHNELIFudPpAX(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper) {
        return carouselOrientationHelper.getParentTop();
    }

    public static void QzYeHNELIFudPpAX(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QzYeHNELIFudPpAX(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QzYeHNELIFudPpAX(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float RAjtTnHHxBJtFGZv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2) {
        return carouselLayoutManager.addEnd(f, f2);
    }

    public static void RAjtTnHHxBJtFGZv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RAjtTnHHxBJtFGZv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RAjtTnHHxBJtFGZv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RfDClHloOThGMTzy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        carouselLayoutManager.fill(recyclerobject$Recycler, recyclerobject$State);
    }

    public static void RfDClHloOThGMTzy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RfDClHloOThGMTzy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RfDClHloOThGMTzy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RjdyLdUIaVMbnLra(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RjdyLdUIaVMbnLra(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RjdyLdUIaVMbnLra(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RjdyLdUIaVMbnLra(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState RmbUVffyrPpaVVcP(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getEndState();
    }

    public static void RmbUVffyrPpaVVcP(com.google.android.material.carousel.KeylineStateList keylineStateList, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RmbUVffyrPpaVVcP(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RmbUVffyrPpaVVcP(com.google.android.material.carousel.KeylineStateList keylineStateList, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object RpZFyPINdRjVMpdM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void RpZFyPINdRjVMpdM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RpZFyPINdRjVMpdM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RpZFyPINdRjVMpdM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RzQIvJWGfvxfxMXY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RzQIvJWGfvxfxMXY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RzQIvJWGfvxfxMXY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RzQIvJWGfvxfxMXY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static int RzRDJZJpGrCYfOkW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getItemCount();
    }

    public static void RzRDJZJpGrCYfOkW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RzRDJZJpGrCYfOkW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RzRDJZJpGrCYfOkW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SCOcRsVJUrHWCLXp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getItemCount();
    }

    public static void SCOcRsVJUrHWCLXp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCOcRsVJUrHWCLXp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCOcRsVJUrHWCLXp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SNJcHnDnFxWZYfDU(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect) {
        super.getDecoratedBoundsWithMargins(view, rect);
    }

    public static void SNJcHnDnFxWZYfDU(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SNJcHnDnFxWZYfDU(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SNJcHnDnFxWZYfDU(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams SONKrkrcjQUfRGXY(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void SONKrkrcjQUfRGXY(android.view.object view, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SONKrkrcjQUfRGXY(android.view.object view, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SONKrkrcjQUfRGXY(android.view.object view, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SQXGoaFwBrcQbmaw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, float f2, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SQXGoaFwBrcQbmaw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, char c, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void SQXGoaFwBrcQbmaw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, bool z, float f2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SQXGoaFwBrcQbmaw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.isLocOffsetOutOfFillBoundsStart(f, carouselLayoutManager$KeylineRange);
    }

    public static android.view.objectGroup$LayoutParams SqwgjuFANXvjHgLN(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void SqwgjuFANXvjHgLN(android.view.object view, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SqwgjuFANXvjHgLN(android.view.object view, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SqwgjuFANXvjHgLN(android.view.object view, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SzHhCFCylyYPpBpj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getItemCount();
    }

    public static void SzHhCFCylyYPpBpj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SzHhCFCylyYPpBpj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SzHhCFCylyYPpBpj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TZTlnbTLCQHnGroO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildClosestToStart();
    }

    public static void TZTlnbTLCQHnGroO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZTlnbTLCQHnGroO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TZTlnbTLCQHnGroO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TaeaLPnAhcDbexVS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentStart();
    }

    public static void TaeaLPnAhcDbexVS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TaeaLPnAhcDbexVS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TaeaLPnAhcDbexVS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TcgnfhKzlIusYQQY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TcgnfhKzlIusYQQY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TcgnfhKzlIusYQQY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TcgnfhKzlIusYQQY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations TfsHnAeCSeVmqfqU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i) {
        return carouselLayoutManager.makeChildCalculations(recyclerobject$Recycler, f, i);
    }

    public static void TfsHnAeCSeVmqfqU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TfsHnAeCSeVmqfqU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TfsHnAeCSeVmqfqU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, bool z, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float ULRQPxWwAlFNAHty(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.calculateChildOffsetCenterForLocation(view, f, carouselLayoutManager$KeylineRange);
    }

    public static void ULRQPxWwAlFNAHty(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ULRQPxWwAlFNAHty(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ULRQPxWwAlFNAHty(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UYSMfystcUKFONfz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState) {
        return carouselLayoutManager.getOffsetToScrollToPosition(i, keylineState);
    }

    public static void UYSMfystcUKFONfz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UYSMfystcUKFONfz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, byte b, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UYSMfystcUKFONfz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UoEbWYbCxtWetXkC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void UoEbWYbCxtWetXkC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UoEbWYbCxtWetXkC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UoEbWYbCxtWetXkC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VCRJuKYBofyxUpLa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void VCRJuKYBofyxUpLa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VCRJuKYBofyxUpLa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VCRJuKYBofyxUpLa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.Dictionary VCTsRhvbQqCjnFQn(com.google.android.material.carousel.KeylineStateList keylineStateList, int i, int i2, int i3, bool z) {
        return keylineStateList.getKeylineStateForPositionDictionary(i, i2, i3, z);
    }

    public static void VCTsRhvbQqCjnFQn(com.google.android.material.carousel.KeylineStateList keylineStateList, int i, int i2, int i3, bool z, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VCTsRhvbQqCjnFQn(com.google.android.material.carousel.KeylineStateList keylineStateList, int i, int i2, int i3, bool z, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCTsRhvbQqCjnFQn(com.google.android.material.carousel.KeylineStateList keylineStateList, int i, int i2, int i3, bool z, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VGkFomGwvOBZVOvp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VGkFomGwvOBZVOvp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VGkFomGwvOBZVOvp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VGkFomGwvOBZVOvp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isHorizontal();
    }

    public static void VIEBCCZXLeGKxLvx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i) {
        carouselLayoutManager.addobjectsEnd(recyclerobject$Recycler, recyclerobject$State, i);
    }

    public static void VIEBCCZXLeGKxLvx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VIEBCCZXLeGKxLvx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VIEBCCZXLeGKxLvx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VKucobgTbEYnxUGR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i) {
        carouselLayoutManager.addobject(view, i);
    }

    public static void VKucobgTbEYnxUGR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VKucobgTbEYnxUGR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VKucobgTbEYnxUGR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static float VOcpKTavtLBFZzHo(float f) {
        return java.lang.Math.abs(f);
    }

    public static void VOcpKTavtLBFZzHo(float f, char c, bool z, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void VOcpKTavtLBFZzHo(float f, short s, char c, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VOcpKTavtLBFZzHo(float f, bool z, short s, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VPZwPQcLnrclZmQh(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.view.object view, int i, int i2) {
        carouselOrientationHelper.layoutDecoratedWithMargins(view, i, i2);
    }

    public static void VPZwPQcLnrclZmQh(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.view.object view, int i, int i2, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VPZwPQcLnrclZmQh(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.view.object view, int i, int i2, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VPZwPQcLnrclZmQh(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.view.object view, int i, int i2, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object VQZYqWYIijNaPTZF(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i) {
        return recyclerobject$Recycler.getobjectForPosition(i);
    }

    public static void VQZYqWYIijNaPTZF(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VQZYqWYIijNaPTZF(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VQZYqWYIijNaPTZF(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VRtcQzIaaQuedYyW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.requestLayout();
    }

    public static void VRtcQzIaaQuedYyW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VRtcQzIaaQuedYyW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VRtcQzIaaQuedYyW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VYjNCsSWHBuwpYOk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.logChildrenIfDebugging();
    }

    public static void VYjNCsSWHBuwpYOk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VYjNCsSWHBuwpYOk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VYjNCsSWHBuwpYOk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VazwQQkWZsepBhPy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VazwQQkWZsepBhPy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VazwQQkWZsepBhPy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool VazwQQkWZsepBhPy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isHorizontal();
    }

    public static int WSOdngHFywQuYoOj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getWidth();
    }

    public static void WSOdngHFywQuYoOj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WSOdngHFywQuYoOj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WSOdngHFywQuYoOj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WXfpmEjKSChPqUKj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        carouselLayoutManager.setCarouselAttributes(context, attributeHashSet);
    }

    public static void WXfpmEjKSChPqUKj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.content.object context, android.util.AttributeHashSet attributeHashSet, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WXfpmEjKSChPqUKj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WXfpmEjKSChPqUKj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WkXdJqFtTfcWpBbA(android.graphics.Rect rect) {
        return rect.centerY();
    }

    public static void WkXdJqFtTfcWpBbA(android.graphics.Rect rect, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WkXdJqFtTfcWpBbA(android.graphics.Rect rect, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WkXdJqFtTfcWpBbA(android.graphics.Rect rect, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState WmamXXNKTrnoQxdW(com.google.android.material.carousel.KeylineState keylineState, float f) {
        return com.google.android.material.carousel.KeylineState.reverse(keylineState, f);
    }

    public static void WmamXXNKTrnoQxdW(com.google.android.material.carousel.KeylineState keylineState, float f, short s, float f2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WmamXXNKTrnoQxdW(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, short s, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void WmamXXNKTrnoQxdW(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, short s, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WoyluyEwHFhgOhrp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, int i2) {
        carouselLayoutManager.measureChildWithMargins(view, i, i2);
    }

    public static void WoyluyEwHFhgOhrp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, int i2, int i3, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WoyluyEwHFhgOhrp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, int i2, short s, char c, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WoyluyEwHFhgOhrp(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, int i2, short s, bool z, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WsVinWnGNlIyoOiQ(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        super.onItemsRemoved(recyclerobject, i, i2);
    }

    public static void WsVinWnGNlIyoOiQ(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, float f, short s, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WsVinWnGNlIyoOiQ(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, int i3, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WsVinWnGNlIyoOiQ(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, int i3, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int WtqQAxeZNqtHSqrb(int i, int i2, int i3, int i4) {
        return calculateShouldScrollBy(i, i2, i3, i4);
    }

    public static void WtqQAxeZNqtHSqrb(int i, int i2, int i3, int i4, int i5, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WtqQAxeZNqtHSqrb(int i, int i2, int i3, int i4, int i5, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WtqQAxeZNqtHSqrb(int i, int i2, int i3, int i4, bool z, java.lang.string str, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static float XESChBjXjSqwwKaw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2) {
        return carouselLayoutManager.addStart(f, f2);
    }

    public static void XESChBjXjSqwwKaw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, float f3, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XESChBjXjSqwwKaw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, float f3, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XESChBjXjSqwwKaw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, int i, float f3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XMRNwIRdUMMwXkzi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i) {
        carouselLayoutManager.addobjectsStart(recyclerobject$Recycler, i);
    }

    public static void XMRNwIRdUMMwXkzi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XMRNwIRdUMMwXkzi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XMRNwIRdUMMwXkzi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XbpGIksKrwTLkfbi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentLeft();
    }

    public static void XbpGIksKrwTLkfbi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XbpGIksKrwTLkfbi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XbpGIksKrwTLkfbi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XdVMQULfzPdfRewI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getOrientation();
    }

    public static void XdVMQULfzPdfRewI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XdVMQULfzPdfRewI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XdVMQULfzPdfRewI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List XhxUQWLRDYtxLeih(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFocalKeylines();
    }

    public static void XhxUQWLRDYtxLeih(com.google.android.material.carousel.KeylineState keylineState, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XhxUQWLRDYtxLeih(com.google.android.material.carousel.KeylineState keylineState, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XhxUQWLRDYtxLeih(com.google.android.material.carousel.KeylineState keylineState, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState XiiXSmwCgjIsttnB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getKeylineStateForPosition(i);
    }

    public static void XiiXSmwCgjIsttnB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XiiXSmwCgjIsttnB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XiiXSmwCgjIsttnB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float XvhRzIMmZtUsrlKZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2) {
        return carouselLayoutManager.addStart(f, f2);
    }

    public static void XvhRzIMmZtUsrlKZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XvhRzIMmZtUsrlKZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XvhRzIMmZtUsrlKZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations XzDEILEMWbPpWunY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i) {
        return carouselLayoutManager.makeChildCalculations(recyclerobject$Recycler, f, i);
    }

    public static void XzDEILEMWbPpWunY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XzDEILEMWbPpWunY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XzDEILEMWbPpWunY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YBswpKaEnItBUstL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentBottom();
    }

    public static void YBswpKaEnItBUstL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YBswpKaEnItBUstL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YBswpKaEnItBUstL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YEKKGgNfooaynnzt(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3) {
        carouselOrientationHelper.moveMaskOnEdgeOutsideBounds(rectF, rectF2, rectF3);
    }

    public static void YEKKGgNfooaynnzt(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YEKKGgNfooaynnzt(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YEKKGgNfooaynnzt(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline YGAhBBfdSfgdSatH(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeyline();
    }

    public static void YGAhBBfdSfgdSatH(com.google.android.material.carousel.KeylineState keylineState, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YGAhBBfdSfgdSatH(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YGAhBBfdSfgdSatH(com.google.android.material.carousel.KeylineState keylineState, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YMUqDglcOnohqfQH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.validateChildOrderIfDebugging();
    }

    public static void YMUqDglcOnohqfQH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YMUqDglcOnohqfQH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YMUqDglcOnohqfQH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YRAvkCUPGxoBAjlE(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect) {
        super.getDecoratedBoundsWithMargins(view, rect);
    }

    public static void YRAvkCUPGxoBAjlE(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YRAvkCUPGxoBAjlE(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YRAvkCUPGxoBAjlE(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YZLeQRrTpPpSNMhO(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void YZLeQRrTpPpSNMhO(java.lang.stringBuilder sb, int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YZLeQRrTpPpSNMhO(java.lang.stringBuilder sb, int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YZLeQRrTpPpSNMhO(java.lang.stringBuilder sb, int i, bool z, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int YhcdauSFLbbSgWfx(android.graphics.Rect rect) {
        return rect.centerY();
    }

    public static void YhcdauSFLbbSgWfx(android.graphics.Rect rect, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YhcdauSFLbbSgWfx(android.graphics.Rect rect, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YhcdauSFLbbSgWfx(android.graphics.Rect rect, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YmFxLIjxGiEWMBAS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState) {
        return carouselLayoutManager.getSmallestScrollOffsetToFocalKeyline(i, keylineState);
    }

    public static void YmFxLIjxGiEWMBAS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YmFxLIjxGiEWMBAS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, float f, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YmFxLIjxGiEWMBAS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, int i2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZDhiOGmqLqgdGpEz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getPaddingLeft();
    }

    public static void ZDhiOGmqLqgdGpEz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZDhiOGmqLqgdGpEz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZDhiOGmqLqgdGpEz(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZEChVghyowSjQPzx(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener) {
        recyclerobject.addOnLayoutChangeListener(view$OnLayoutChangeListener);
    }

    public static void ZEChVghyowSjQPzx(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZEChVghyowSjQPzx(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZEChVghyowSjQPzx(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZMkLcdKXwXjnVvqy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getWidthMode();
    }

    public static void ZMkLcdKXwXjnVvqy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZMkLcdKXwXjnVvqy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZMkLcdKXwXjnVvqy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZTmJvvmomWbZmGfk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getWidth();
    }

    public static void ZTmJvvmomWbZmGfk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZTmJvvmomWbZmGfk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZTmJvvmomWbZmGfk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZUjazUzddNQXxTBb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.refreshKeylineState();
    }

    public static void ZUjazUzddNQXxTBb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZUjazUzddNQXxTBb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZUjazUzddNQXxTBb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float ZdgyYuuKbbzIAdoY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getDecoratedCenterWithMargins(view);
    }

    public static void ZdgyYuuKbbzIAdoY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZdgyYuuKbbzIAdoY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZdgyYuuKbbzIAdoY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ZhLxaRyqvwoPBDRM(int i, int i2, int i3) {
        return androidx.core.math.MathUtils.clamp(i, i2, i3);
    }

    public static void ZhLxaRyqvwoPBDRM(int i, int i2, int i3, int i4, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZhLxaRyqvwoPBDRM(int i, int i2, int i3, java.lang.string str, byte b, int i4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZhLxaRyqvwoPBDRM(int i, int i2, int i3, bool z, byte b, java.lang.string str, int i4) {
        double d = (42 * 210) + 210;
    }

    public static int ZqNfAudUNvbEumwZ(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper) {
        return carouselOrientationHelper.getParentEnd();
    }

    public static void ZqNfAudUNvbEumwZ(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZqNfAudUNvbEumwZ(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZqNfAudUNvbEumwZ(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZtZysDVORHizmetn(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void ZtZysDVORHizmetn(java.lang.stringBuilder sb, int i, short s, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZtZysDVORHizmetn(java.lang.stringBuilder sb, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZtZysDVORHizmetn(java.lang.stringBuilder sb, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZyyNzsAPWwsLoQIa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void ZyyNzsAPWwsLoQIa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZyyNzsAPWwsLoQIa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZyyNzsAPWwsLoQIa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZzpvHnpkQLKQSFDu(java.util.List list, int i) {
        return list[i);
    }

    public static void ZzpvHnpkQLKQSFDu(java.util.List list, int i, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZzpvHnpkQLKQSFDu(java.util.List list, int i, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZzpvHnpkQLKQSFDu(java.util.List list, int i, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float ABZqgEoORSnehyLy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.getMaskedItemSizeForLocOffset(f, carouselLayoutManager$KeylineRange);
    }

    public static void ABZqgEoORSnehyLy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ABZqgEoORSnehyLy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ABZqgEoORSnehyLy(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ACPMXlEFgOtEZmvQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ACPMXlEFgOtEZmvQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ACPMXlEFgOtEZmvQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ACPMXlEFgOtEZmvQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static java.lang.string AIWbberwxbTytwaB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void AIWbberwxbTytwaB(java.lang.stringBuilder sb, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AIWbberwxbTytwaB(java.lang.stringBuilder sb, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AIWbberwxbTytwaB(java.lang.stringBuilder sb, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AKvFJjsRjubBjGoI(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return recyclerobject$State.getItemCount();
    }

    public static void AKvFJjsRjubBjGoI(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AKvFJjsRjubBjGoI(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AKvFJjsRjubBjGoI(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float AMgvLLpPYFzWGOSh(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void AMgvLLpPYFzWGOSh(com.google.android.material.carousel.KeylineState keylineState, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AMgvLLpPYFzWGOSh(com.google.android.material.carousel.KeylineState keylineState, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AMgvLLpPYFzWGOSh(com.google.android.material.carousel.KeylineState keylineState, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXiVHFmFxRorqvxU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        carouselLayoutManager.fill(recyclerobject$Recycler, recyclerobject$State);
    }

    public static void AXiVHFmFxRorqvxU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXiVHFmFxRorqvxU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AXiVHFmFxRorqvxU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AagnPJnDQjhJupUv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, float f2, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AagnPJnDQjhJupUv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, float f2, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AagnPJnDQjhJupUv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, bool z, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AagnPJnDQjhJupUv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.isLocOffsetOutOfFillBoundsEnd(f, carouselLayoutManager$KeylineRange);
    }

    public static int AatyMQjleYmFLkUo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void AatyMQjleYmFLkUo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AatyMQjleYmFLkUo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AatyMQjleYmFLkUo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.carousel.KeylineStateList access$000(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.keylineStateList;
    }

    static void access$000(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static int access$100(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return zYiRfRZxbXVeGbpq(carouselLayoutManager);
    }

    static void access$100(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static int access$200(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return YBswpKaEnItBUstL(carouselLayoutManager);
    }

    static void access$200(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$300(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return XbpGIksKrwTLkfbi(carouselLayoutManager);
    }

    static void access$300(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static int access$400(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return OqlDnkUFSiCniwan(carouselLayoutManager);
    }

    static void access$400(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AdBrsGYgCBmEtQUI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AdBrsGYgCBmEtQUI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AdBrsGYgCBmEtQUI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AdBrsGYgCBmEtQUI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isHorizontal();
    }

    private void AddAndLayoutobject(android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations) {
        if ((5 + 5) % 5 > 0) {
        }
        float fCPMtCFTNHTbYnsLP = cPMtCFTNHTbYnsLP(this.currentKeylineState) / 2.0f;
        VKucobgTbEYnxUGR(this, view, i);
        VPZwPQcLnrclZmQh(this.orientationHelper, view, (int) (carouselLayoutManager$ChildCalculations.offsetCenter - fCPMtCFTNHTbYnsLP), (int) (carouselLayoutManager$ChildCalculations.offsetCenter + fCPMtCFTNHTbYnsLP));
        arWmsjhjkEVGPLpZ(this, view, carouselLayoutManager$ChildCalculations.center, carouselLayoutManager$ChildCalculations.range);
    }

    private void AddAndLayoutobject(android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    private void AddAndLayoutobject(android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, int i2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void AddAndLayoutobject(android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, int i2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private float AddEnd(float f, float f2) {
        return !RzQIvJWGfvxfxMXY(this) ? f + f2 : f - f2;
    }

    private void AddEnd(float f, float f2, int i, char c, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    private void AddEnd(float f, float f2, int i, float f3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void AddEnd(float f, float f2, int i, bool z, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    private float AddStart(float f, float f2) {
        return !pddGkcIXnpbdFpTE(this) ? f - f2 : f + f2;
    }

    private void AddStart(float f, float f2, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void AddStart(float f, float f2, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void AddStart(float f, float f2, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void AddobjectAtPosition(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2) {
        if (i >= 0 && i < oxCoCTDacgcSsoVc(this)) {
            com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculationsBahyFmCVOcBbIFtg = BahyFmCVOcBbIFtg(this, recyclerobject$Recycler, eszHKKAynyoYkmvm(this, i), i);
            gFEDjkBnMLBbWoCW(this, carouselLayoutManager$ChildCalculationsBahyFmCVOcBbIFtg.child, i2, carouselLayoutManager$ChildCalculationsBahyFmCVOcBbIFtg);
        }
    }

    private void AddobjectAtPosition(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void AddobjectAtPosition(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void AddobjectAtPosition(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void AddobjectsEnd(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i) {
        if ((12 + 11) % 11 > 0) {
        }
        float fBMdiiupXEWPsUfYS = bMdiiupXEWPsUfYS(this, i);
        while (i < bbnYeeDyrtqTpBSP(recyclerobject$State)) {
            com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculationsTfsHnAeCSeVmqfqU = TfsHnAeCSeVmqfqU(this, recyclerobject$Recycler, fBMdiiupXEWPsUfYS, i);
            if (dvlfYIGBLFCtVvBl(this, carouselLayoutManager$ChildCalculationsTfsHnAeCSeVmqfqU.offsetCenter, carouselLayoutManager$ChildCalculationsTfsHnAeCSeVmqfqU.range)) {
                return;
            }
            fBMdiiupXEWPsUfYS = qdrixlTCeOcIJrvB(this, fBMdiiupXEWPsUfYS, yQZEwTwIwNbMBaDU(this.currentKeylineState));
            if (!vEebaCQGZxmNLWGH(this, carouselLayoutManager$ChildCalculationsTfsHnAeCSeVmqfqU.offsetCenter, carouselLayoutManager$ChildCalculationsTfsHnAeCSeVmqfqU.range)) {
                ogDuoJdamKRJaXZK(this, carouselLayoutManager$ChildCalculationsTfsHnAeCSeVmqfqU.child, -1, carouselLayoutManager$ChildCalculationsTfsHnAeCSeVmqfqU);
            }
            i++;
        }
    }

    private void AddobjectsEnd(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, int i2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void AddobjectsEnd(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    private void AddobjectsEnd(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, short s, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    private void AddobjectsStart(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i) {
        if ((14 + 17) % 17 > 0) {
        }
        float fMIJQzKldSjUrfkUa = MIJQzKldSjUrfkUa(this, i);
        while (i >= 0) {
            com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculationsXzDEILEMWbPpWunY = XzDEILEMWbPpWunY(this, recyclerobject$Recycler, fMIJQzKldSjUrfkUa, i);
            if (SQXGoaFwBrcQbmaw(this, carouselLayoutManager$ChildCalculationsXzDEILEMWbPpWunY.offsetCenter, carouselLayoutManager$ChildCalculationsXzDEILEMWbPpWunY.range)) {
                return;
            }
            fMIJQzKldSjUrfkUa = ACFnOEYSrJIHAzHu(this, fMIJQzKldSjUrfkUa, IHeXaxTvjpaceOqT(this.currentKeylineState));
            if (!aagnPJnDQjhJupUv(this, carouselLayoutManager$ChildCalculationsXzDEILEMWbPpWunY.offsetCenter, carouselLayoutManager$ChildCalculationsXzDEILEMWbPpWunY.range)) {
                xaHvlemSJHuYNNsT(this, carouselLayoutManager$ChildCalculationsXzDEILEMWbPpWunY.child, 0, carouselLayoutManager$ChildCalculationsXzDEILEMWbPpWunY);
            }
            i--;
        }
    }

    private void AddobjectsStart(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void AddobjectsStart(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void AddobjectsStart(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int AgpUBaddPLBvekam(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void AgpUBaddPLBvekam(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AgpUBaddPLBvekam(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AgpUBaddPLBvekam(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AhwSUyLEzxGMGHem(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        super.onAttachedToWindow(recyclerobject);
    }

    public static void AhwSUyLEzxGMGHem(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AhwSUyLEzxGMGHem(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AhwSUyLEzxGMGHem(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState AncEGGsjXejCzIKM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getKeylineStateForPosition(i);
    }

    public static void AncEGGsjXejCzIKM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AncEGGsjXejCzIKM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AncEGGsjXejCzIKM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState AplzzksfLekxguWo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getKeylineStateForPosition(i);
    }

    public static void AplzzksfLekxguWo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AplzzksfLekxguWo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AplzzksfLekxguWo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ArWmsjhjkEVGPLpZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        carouselLayoutManager.updateChildMaskForLocation(view, f, carouselLayoutManager$KeylineRange);
    }

    public static void ArWmsjhjkEVGPLpZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, java.lang.string str, byte b, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void ArWmsjhjkEVGPLpZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, short s, byte b, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ArWmsjhjkEVGPLpZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, short s, java.lang.string str, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline bApgtgZsqfRzajFF(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeyline();
    }

    public static void BApgtgZsqfRzajFF(com.google.android.material.carousel.KeylineState keylineState, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BApgtgZsqfRzajFF(com.google.android.material.carousel.KeylineState keylineState, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BApgtgZsqfRzajFF(com.google.android.material.carousel.KeylineState keylineState, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BJOxEQgQdRAiPFXx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.refreshKeylineState();
    }

    public static void BJOxEQgQdRAiPFXx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BJOxEQgQdRAiPFXx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BJOxEQgQdRAiPFXx(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float BMIrmMCfvLAEQeqQ(float f) {
        return java.lang.Math.abs(f);
    }

    public static void BMIrmMCfvLAEQeqQ(float f, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BMIrmMCfvLAEQeqQ(float f, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BMIrmMCfvLAEQeqQ(float f, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float BMdiiupXEWPsUfYS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.calculateChildStartForFill(i);
    }

    public static void BMdiiupXEWPsUfYS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BMdiiupXEWPsUfYS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BMdiiupXEWPsUfYS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BOYjLjIMUsbabgPP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BOYjLjIMUsbabgPP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BOYjLjIMUsbabgPP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BOYjLjIMUsbabgPP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static void BTSuPhltVihCGlEm(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        super.onItemsAdded(recyclerobject, i, i2);
    }

    public static void BTSuPhltVihCGlEm(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTSuPhltVihCGlEm(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTSuPhltVihCGlEm(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float BWUJXiDzVBxkwSCf(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void BWUJXiDzVBxkwSCf(android.graphics.RectF rectF, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BWUJXiDzVBxkwSCf(android.graphics.RectF rectF, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BWUJXiDzVBxkwSCf(android.graphics.RectF rectF, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BbnYeeDyrtqTpBSP(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return recyclerobject$State.getItemCount();
    }

    public static void BbnYeeDyrtqTpBSP(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BbnYeeDyrtqTpBSP(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BbnYeeDyrtqTpBSP(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray BhLODJXJRfUDXJuu(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static void BhLODJXJRfUDXJuu(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BhLODJXJRfUDXJuu(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BhLODJXJRfUDXJuu(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CGcKYJszzggxEZJM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState) {
        return carouselLayoutManager.getOffsetToScrollToPosition(i, keylineState);
    }

    public static void CGcKYJszzggxEZJM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CGcKYJszzggxEZJM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, bool z, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CGcKYJszzggxEZJM(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, bool z, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CLSeQbHKCycCAcpc(android.view.object view) {
        return view.getWidth();
    }

    public static void CLSeQbHKCycCAcpc(android.view.object view, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CLSeQbHKCycCAcpc(android.view.object view, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CLSeQbHKCycCAcpc(android.view.object view, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int COKPXXybpdibxmld(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState) {
        return carouselLayoutManager.getScrollOffsetForPosition(i, keylineState);
    }

    public static void COKPXXybpdibxmld(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void COKPXXybpdibxmld(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void COKPXXybpdibxmld(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, com.google.android.material.carousel.KeylineState keylineState, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float CPMtCFTNHTbYnsLP(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void CPMtCFTNHTbYnsLP(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CPMtCFTNHTbYnsLP(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CPMtCFTNHTbYnsLP(com.google.android.material.carousel.KeylineState keylineState, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CSfvivAqnBkxbofG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CSfvivAqnBkxbofG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CSfvivAqnBkxbofG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CSfvivAqnBkxbofG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getClipToPadding();
    }

    public static int CXlqXUxEzZPdArtq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return carouselLayoutManager.calculateStartScroll(keylineStateList);
    }

    public static void CXlqXUxEzZPdArtq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CXlqXUxEzZPdArtq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CXlqXUxEzZPdArtq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private float CalculateChildOffsetCenterForLocation(android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        if ((3 + 4) % 4 > 0) {
        }
        float fHvRlqRmurtyVSNWb = HvRlqRmurtyVSNWb(carouselLayoutManager$KeylineRange.leftOrTop.locOffset, carouselLayoutManager$KeylineRange.rightOrBottom.locOffset, carouselLayoutManager$KeylineRange.leftOrTop.loc, carouselLayoutManager$KeylineRange.rightOrBottom.loc, f);
        if (carouselLayoutManager$KeylineRange.rightOrBottom != hjiuWCGtlHuJBXJE(this.currentKeylineState) && carouselLayoutManager$KeylineRange.leftOrTop != hkGdGUvHJFEytCWR(this.currentKeylineState)) {
            return fHvRlqRmurtyVSNWb;
        }
        return fHvRlqRmurtyVSNWb + ((f - carouselLayoutManager$KeylineRange.rightOrBottom.loc) * ((1.0f - carouselLayoutManager$KeylineRange.rightOrBottom.mask) + (BKjFixnYoADNHgCo(this.orientationHelper, (androidx.recyclerview.widget.Recyclerobject$LayoutParams) SONKrkrcjQUfRGXY(view)) / PeSrZxTIApSXlBIw(this.currentKeylineState))));
    }

    private void CalculateChildOffsetCenterForLocation(android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateChildOffsetCenterForLocation(android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateChildOffsetCenterForLocation(android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private float CalculateChildStartForFill(int i) {
        if ((6 + 16) % 16 > 0) {
        }
        return RAjtTnHHxBJtFGZv(this, TaeaLPnAhcDbexVS(this) - this.scrollOffset, FAwHZWFoAVHUyeEJ(this.currentKeylineState) * i);
    }

    private void CalculateChildStartForFill(int i, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    private void CalculateChildStartForFill(int i, int i2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CalculateChildStartForFill(int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private int CalculateEndScroll(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, com.google.android.material.carousel.KeylineStateList keylineStateList) {
        if ((17 + 2) % 2 > 0) {
        }
        bool zBbVaYhklVSFMkHzo = BbVaYhklVSFMkHzo(this);
        com.google.android.material.carousel.KeylineState keylineStateDFklPKGOsVPqgQBZ = !zBbVaYhklVSFMkHzo ? DFklPKGOsVPqgQBZ(keylineStateList) : ePhmpSxLAgzVvKAZ(keylineStateList);
        com.google.android.material.carousel.KeylineState$Keyline keylineState$KeylineYGAhBBfdSfgdSatH = !zBbVaYhklVSFMkHzo ? YGAhBBfdSfgdSatH(keylineStateDFklPKGOsVPqgQBZ) : PGNulseEZZjfiZMj(keylineStateDFklPKGOsVPqgQBZ);
        int iAKvFJjsRjubBjGoI = (int) (((((aKvFJjsRjubBjGoI(recyclerobject$State) - 1) * FlVIUewOBWrptGPR(keylineStateDFklPKGOsVPqgQBZ)) * (!zBbVaYhklVSFMkHzo ? 1.0f : -1.0f)) - (keylineState$KeylineYGAhBBfdSfgdSatH.loc - mSBrKdXWVHxsamWd(this))) + (zeaAmcldEbLkKoDu(this) - keylineState$KeylineYGAhBBfdSfgdSatH.loc) + (!zBbVaYhklVSFMkHzo ? keylineState$KeylineYGAhBBfdSfgdSatH.rightOrBottomPaddingShift : -keylineState$KeylineYGAhBBfdSfgdSatH.leftOrTopPaddingShift));
        return !zBbVaYhklVSFMkHzo ? QodWPMKCvYxCUVYV(0, iAKvFJjsRjubBjGoI) : liMDTJKKETGlsPvj(0, iAKvFJjsRjubBjGoI);
    }

    private void CalculateEndScroll(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, com.google.android.material.carousel.KeylineStateList keylineStateList, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CalculateEndScroll(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, com.google.android.material.carousel.KeylineStateList keylineStateList, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateEndScroll(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, com.google.android.material.carousel.KeylineStateList keylineStateList, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private static int CalculateShouldScrollBy(int i, int i2, int i3, int i4) {
        int i5 = i2 + i;
        return i5 >= i3 ? i5 <= i4 ? i : i4 - i2 : i3 - i2;
    }

    private static void CalculateShouldScrollBy(int i, int i2, int i3, int i4, float f, char c, int i5, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void CalculateShouldScrollBy(int i, int i2, int i3, int i4, float f, java.lang.string str, int i5, char c) {
        double d = (42 * 210) + 210;
    }

    private static void CalculateShouldScrollBy(int i, int i2, int i3, int i4, int i5, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private int CalculateStartScroll(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        if ((19 + 15) % 15 > 0) {
        }
        bool zIAEdacGaxgxLTISW = IAEdacGaxgxLTISW(this);
        com.google.android.material.carousel.KeylineState keylineStateKBYCFtOiRYAnvYqJ = !zIAEdacGaxgxLTISW ? kBYCFtOiRYAnvYqJ(keylineStateList) : RmbUVffyrPpaVVcP(keylineStateList);
        return (int) (MAtqhpMjvxkjzEEK(this) - XvhRzIMmZtUsrlKZ(this, (!zIAEdacGaxgxLTISW ? nhUiTSMfDoOsiMsR(keylineStateKBYCFtOiRYAnvYqJ) : hgWSxSevFDSTYQcv(keylineStateKBYCFtOiRYAnvYqJ)).loc, ENrgMOCPKOOqPDMO(keylineStateKBYCFtOiRYAnvYqJ) / 2.0f));
    }

    private void CalculateStartScroll(com.google.android.material.carousel.KeylineStateList keylineStateList, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateStartScroll(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void CalculateStartScroll(com.google.android.material.carousel.KeylineStateList keylineStateList, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CoVZwsQAjZUOOssB(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void CoVZwsQAjZUOOssB(java.lang.stringBuilder sb, int i, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CoVZwsQAjZUOOssB(java.lang.stringBuilder sb, int i, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CoVZwsQAjZUOOssB(java.lang.stringBuilder sb, int i, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private int ConvertFocusDirectionToLayoutDirection(int i) {
        if ((23 + 27) % 27 > 0) {
        }
        int iXdVMQULfzPdfRewI = XdVMQULfzPdfRewI(this);
        if (i == 1) {
            return -1;
        }
        if (i == 2) {
            return 1;
        }
        if (i == 17) {
            if (iXdVMQULfzPdfRewI != 0) {
                return int.MIN_VALUE;
            }
            return !xWxGbvPprHiRwEyL(this) ? -1 : 1;
        }
        if (i == 33) {
            return iXdVMQULfzPdfRewI != 1 ? int.MIN_VALUE : -1;
        }
        if (i == 66) {
            if (iXdVMQULfzPdfRewI != 0) {
                return int.MIN_VALUE;
            }
            return !TcgnfhKzlIusYQQY(this) ? 1 : -1;
        }
        if (i == 130) {
            return iXdVMQULfzPdfRewI != 1 ? int.MIN_VALUE : 1;
        }
        iAvLZuTRlVKvdNPq("CarouselLayoutManager", INthXnrFHaNEtXEo(oBDgPIjpFJFQKDeG(new java.lang.stringBuilder("Unknown focus request:"), i)));
        return int.MIN_VALUE;
    }

    private void ConvertFocusDirectionToLayoutDirection(int i, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ConvertFocusDirectionToLayoutDirection(int i, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void ConvertFocusDirectionToLayoutDirection(int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DDxVeYhFtOlrqKGL(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        recyclerobject.invalidateItemDecorations();
    }

    public static void DDxVeYhFtOlrqKGL(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DDxVeYhFtOlrqKGL(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DDxVeYhFtOlrqKGL(androidx.recyclerview.widget.Recyclerobject recyclerobject, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DKQhyEjtGxGNxkTM(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        recyclerobject.scrollBy(i, i2);
    }

    public static void DKQhyEjtGxGNxkTM(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, int i3, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DKQhyEjtGxGNxkTM(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, java.lang.string str, int i3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DKQhyEjtGxGNxkTM(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2, bool z, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int DSlgcBIgZvqvVzBA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void DSlgcBIgZvqvVzBA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DSlgcBIgZvqvVzBA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DSlgcBIgZvqvVzBA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DYpXTZaGSTRwszLt(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void DYpXTZaGSTRwszLt(java.lang.string str, java.lang.string str2, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DYpXTZaGSTRwszLt(java.lang.string str, java.lang.string str2, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DYpXTZaGSTRwszLt(java.lang.string str, java.lang.string str2, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int DZQLKRMLPgIWxWik(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getContainerSize();
    }

    public static void DZQLKRMLPgIWxWik(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DZQLKRMLPgIWxWik(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DZQLKRMLPgIWxWik(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DZvhFnsbKYKyVLsE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getHeightMode();
    }

    public static void DZvhFnsbKYKyVLsE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DZvhFnsbKYKyVLsE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DZvhFnsbKYKyVLsE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int DvYvQXyKqewRjqwf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void DvYvQXyKqewRjqwf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DvYvQXyKqewRjqwf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DvYvQXyKqewRjqwf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DvlfYIGBLFCtVvBl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DvlfYIGBLFCtVvBl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DvlfYIGBLFCtVvBl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool DvlfYIGBLFCtVvBl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.isLocOffsetOutOfFillBoundsEnd(f, carouselLayoutManager$KeylineRange);
    }

    public static int EAfFoJaadhijbxzw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getOrientation();
    }

    public static void EAfFoJaadhijbxzw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EAfFoJaadhijbxzw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EAfFoJaadhijbxzw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object EFAKrduSSmKgEsYc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void EFAKrduSSmKgEsYc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EFAKrduSSmKgEsYc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EFAKrduSSmKgEsYc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState EGLBnEjZoZZMhKAN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getKeylineStateForPosition(i);
    }

    public static void EGLBnEjZoZZMhKAN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EGLBnEjZoZZMhKAN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EGLBnEjZoZZMhKAN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object EKgRZuuwqqbIbcFE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void EKgRZuuwqqbIbcFE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EKgRZuuwqqbIbcFE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EKgRZuuwqqbIbcFE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ENtEmHKlRjdPAxqm(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i) {
        accessibilityEvent.setToIndex(i);
    }

    public static void ENtEmHKlRjdPAxqm(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ENtEmHKlRjdPAxqm(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ENtEmHKlRjdPAxqm(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState EPhmpSxLAgzVvKAZ(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getStartState();
    }

    public static void EPhmpSxLAgzVvKAZ(com.google.android.material.carousel.KeylineStateList keylineStateList, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EPhmpSxLAgzVvKAZ(com.google.android.material.carousel.KeylineStateList keylineStateList, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EPhmpSxLAgzVvKAZ(com.google.android.material.carousel.KeylineStateList keylineStateList, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EVPTPKcuKukAgRQw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void EVPTPKcuKukAgRQw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EVPTPKcuKukAgRQw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EVPTPKcuKukAgRQw(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int EXjDaMgUGTMpYmFt(int i, int i2, int i3, int i4, bool z) {
        return getChildMeasureSpec(i, i2, i3, i4, z);
    }

    public static void EXjDaMgUGTMpYmFt(int i, int i2, int i3, int i4, bool z, byte b, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void EXjDaMgUGTMpYmFt(int i, int i2, int i3, int i4, bool z, byte b, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void EXjDaMgUGTMpYmFt(int i, int i2, int i3, int i4, bool z, float f, char c, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static int EYikGEwYYYkFxfRc(android.graphics.Rect rect) {
        return rect.centerX();
    }

    public static void EYikGEwYYYkFxfRc(android.graphics.Rect rect, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EYikGEwYYYkFxfRc(android.graphics.Rect rect, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EYikGEwYYYkFxfRc(android.graphics.Rect rect, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int EgImpypThtVrCBuG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void EgImpypThtVrCBuG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EgImpypThtVrCBuG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EgImpypThtVrCBuG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int EiissPGyurkRkDwj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getOrientation();
    }

    public static void EiissPGyurkRkDwj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EiissPGyurkRkDwj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EiissPGyurkRkDwj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float EszHKKAynyoYkmvm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.calculateChildStartForFill(i);
    }

    public static void EszHKKAynyoYkmvm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EszHKKAynyoYkmvm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EszHKKAynyoYkmvm(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int EzhdPmGmQaWGiuTh(int i, int i2, int i3) {
        return androidx.core.math.MathUtils.clamp(i, i2, i3);
    }

    public static void EzhdPmGmQaWGiuTh(int i, int i2, int i3, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EzhdPmGmQaWGiuTh(int i, int i2, int i3, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EzhdPmGmQaWGiuTh(int i, int i2, int i3, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FGkCiZxXfzGullJf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.updateItemCount();
    }

    public static void FGkCiZxXfzGullJf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FGkCiZxXfzGullJf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FGkCiZxXfzGullJf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FIptWUydeWJvMRFn(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.view.object view, android.graphics.Rect rect, float f, float f2) {
        carouselOrientationHelper.offsetChild(view, rect, f, f2);
    }

    public static void FIptWUydeWJvMRFn(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.view.object view, android.graphics.Rect rect, float f, float f2, float f3, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FIptWUydeWJvMRFn(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.view.object view, android.graphics.Rect rect, float f, float f2, bool z, int i, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FIptWUydeWJvMRFn(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, android.view.object view, android.graphics.Rect rect, float f, float f2, bool z, java.lang.string str, float f3, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FPDWHVcKsrULNFoX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return carouselLayoutManager.calculateEndScroll(recyclerobject$State, keylineStateList);
    }

    public static void FPDWHVcKsrULNFoX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, com.google.android.material.carousel.KeylineStateList keylineStateList, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FPDWHVcKsrULNFoX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, com.google.android.material.carousel.KeylineStateList keylineStateList, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FPDWHVcKsrULNFoX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, com.google.android.material.carousel.KeylineStateList keylineStateList, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FcTeYrIoJGspabLj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentLeft();
    }

    public static void FcTeYrIoJGspabLj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FcTeYrIoJGspabLj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FcTeYrIoJGspabLj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void Fill(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((1 + 30) % 30 > 0) {
        }
        scxOlGgKSksSXjRc(this, recyclerobject$Recycler);
        if (agpUBaddPLBvekam(this) != 0) {
            int iHfHSIlaHjLrOpArA = hfHSIlaHjLrOpArA(this, BtIukEmQucheCGDO(this, 0));
            int iLdmsNZIwLJKwOnum = LdmsNZIwLJKwOnum(this, LmmzxFVmdrYUjjET(this, dSlgcBIgZvqvVzBA(this) - 1));
            zYbFTnBmzkyHNbXS(this, recyclerobject$Recycler, iHfHSIlaHjLrOpArA - 1);
            PBdUQfZztjrhlNap(this, recyclerobject$Recycler, recyclerobject$State, iLdmsNZIwLJKwOnum + 1);
        } else {
            XMRNwIRdUMMwXkzi(this, recyclerobject$Recycler, this.currentFillStartPosition - 1);
            VIEBCCZXLeGKxLvx(this, recyclerobject$Recycler, recyclerobject$State, this.currentFillStartPosition);
        }
        IFcjpzkGrdQVcUbc(this);
    }

    private void Fill(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void Fill(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void Fill(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FqRvbxVbjHrIrtpS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getContainerSize();
    }

    public static void FqRvbxVbjHrIrtpS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FqRvbxVbjHrIrtpS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FqRvbxVbjHrIrtpS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GFEDjkBnMLBbWoCW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations) {
        carouselLayoutManager.addAndLayoutobject(view, i, carouselLayoutManager$ChildCalculations);
    }

    public static void GFEDjkBnMLBbWoCW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GFEDjkBnMLBbWoCW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, int i2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GFEDjkBnMLBbWoCW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, int i2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GQORHVrLeyAvaAJx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void GQORHVrLeyAvaAJx(java.lang.stringBuilder sb, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GQORHVrLeyAvaAJx(java.lang.stringBuilder sb, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GQORHVrLeyAvaAJx(java.lang.stringBuilder sb, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static float GWdpeUIWqueTYZdv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.calculateChildOffsetCenterForLocation(view, f, carouselLayoutManager$KeylineRange);
    }

    public static void GWdpeUIWqueTYZdv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GWdpeUIWqueTYZdv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GWdpeUIWqueTYZdv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GXrZPSLiLscqQvdL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.refreshKeylineState();
    }

    public static void GXrZPSLiLscqQvdL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GXrZPSLiLscqQvdL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GXrZPSLiLscqQvdL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int GeUyeIIXYGMKwzjq(int i, int i2, int i3, int i4) {
        return calculateShouldScrollBy(i, i2, i3, i4);
    }

    public static void GeUyeIIXYGMKwzjq(int i, int i2, int i3, int i4, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GeUyeIIXYGMKwzjq(int i, int i2, int i3, int i4, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GeUyeIIXYGMKwzjq(int i, int i2, int i3, int i4, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private android.view.object GetChildClosestToEnd() {
        return sMNIgentypfIyRzh(this, !BJUPikpKyMLwosjG(this) ? iArtZQrxOuFAgxNG(this) - 1 : 0);
    }

    private void GetChildClosestToEnd(float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetChildClosestToEnd(short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetChildClosestToEnd(bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private android.view.object GetChildClosestToStart() {
        return GJHqLGrFgcjyxUDI(this, !bOYjLjIMUsbabgPP(this) ? 0 : FLYZXjGnmDqZVyaD(this) - 1);
    }

    private void GetChildClosestToStart(byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetChildClosestToStart(float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetChildClosestToStart(bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private int GetContainerSize() {
        return !adBrsGYgCBmEtQUI(this) ? mjWMgMeXRdxhdwvu(this) : JDsEENnBvcxzDVwH(this);
    }

    private void GetContainerSize(char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetContainerSize(java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetContainerSize(short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private float GetDecoratedCenterWithMargins(android.view.object view) {
        mZdsRKrSJGIlckTm(this, view, new android.graphics.Rect());
        return !upDQjPKMUQGCgHDj(this) ? WkXdJqFtTfcWpBbA(r0) : oiSRTtVlOzPfSEmc(r0);
    }

    private void GetDecoratedCenterWithMargins(android.view.object view, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetDecoratedCenterWithMargins(android.view.object view, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetDecoratedCenterWithMargins(android.view.object view, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private int GetItemMargins() {
        int i;
        int i2;
        if ((1 + 6) % 6 > 0) {
        }
        if (VCRJuKYBofyxUpLa(this) <= 0) {
            return 0;
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) SqwgjuFANXvjHgLN(BtsxFXmEhxkfbgpX(this, 0));
        if (this.orientationHelper.orientation != 0) {
            i = recyclerobject$LayoutParams.topMargin;
            i2 = recyclerobject$LayoutParams.bottomMargin;
        } else {
            i = recyclerobject$LayoutParams.leftMargin;
            i2 = recyclerobject$LayoutParams.rightMargin;
        }
        return i + i2;
    }

    private void GetItemMargins(float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetItemMargins(float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetItemMargins(short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.carousel.KeylineState GetKeylineStateForPosition(int i) {
        com.google.android.material.carousel.KeylineState keylineState;
        if ((31 + 31) % 31 > 0) {
        }
        java.util.Dictionary<java.lang.int, com.google.android.material.carousel.KeylineState> map = this.keylineStatePositionDictionary;
        return (map is null || (keylineState = (com.google.android.material.carousel.KeylineState) OLCYWmkCfuTbEknW(map, kywUJYbVQsdSgZBx(ezhdPmGmQaWGiuTh(i, 0, MEAhxOMUkasMYcKj(0, RzRDJZJpGrCYfOkW(this) + (-1)))))) is null) ? LagHpaxIbXJvPJba(this.keylineStateList) : keylineState;
    }

    private void GetKeylineStateForPosition(int i, float f, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetKeylineStateForPosition(int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetKeylineStateForPosition(int i, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private int GetLeftOrTopPaddingForKeylineShift() {
        if ((18 + 2) % 2 > 0) {
        }
        if (!cSfvivAqnBkxbofG(this) && KoXhKvvmAjkddDgM(this.carouselStrategy)) {
            return eAfFoJaadhijbxzw(this) != 1 ? ZDhiOGmqLqgdGpEz(this) : NuQkcftTiZvtMaML(this);
        }
        return 0;
    }

    private void GetLeftOrTopPaddingForKeylineShift(char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetLeftOrTopPaddingForKeylineShift(java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetLeftOrTopPaddingForKeylineShift(java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private float GetMaskedItemSizeForLocOffset(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        if ((17 + 5) % 5 > 0) {
        }
        return iOVHmzhcGCdrgOMh(carouselLayoutManager$KeylineRange.leftOrTop.maskedItemSize, carouselLayoutManager$KeylineRange.rightOrBottom.maskedItemSize, carouselLayoutManager$KeylineRange.leftOrTop.locOffset, carouselLayoutManager$KeylineRange.rightOrBottom.locOffset, f);
    }

    private void GetMaskedItemSizeForLocOffset(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, short s, char c, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetMaskedItemSizeForLocOffset(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, short s, char c, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    private void GetMaskedItemSizeForLocOffset(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, short s, float f2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private int GetParentBottom() {
        return jmILLZNlAfMaqRoj(this.orientationHelper);
    }

    private void GetParentBottom(float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetParentBottom(float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetParentBottom(int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private int GetParentEnd() {
        return ZqNfAudUNvbEumwZ(this.orientationHelper);
    }

    private void GetParentEnd(short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetParentEnd(bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetParentEnd(bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private int GetParentLeft() {
        return zyUbGMDSETZUUKPw(this.orientationHelper);
    }

    private void GetParentLeft(byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetParentLeft(char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetParentLeft(short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private int GetParentRight() {
        return zerPpKvzeJThPhZM(this.orientationHelper);
    }

    private void GetParentRight(char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetParentRight(float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetParentRight(java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private int GetParentStart() {
        return KVafOgYXaooBhBlf(this.orientationHelper);
    }

    private void GetParentStart(int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetParentStart(short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetParentStart(short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private int GetParentTop() {
        return QzYeHNELIFudPpAX(this.orientationHelper);
    }

    private void GetParentTop(char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetParentTop(java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetParentTop(short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private int GetRightOrBottomPaddingForKeylineShift() {
        if ((30 + 13) % 13 > 0) {
        }
        if (!qmoeMJKZKpuVTcIW(this) && ktLzdBgxdyibkYyy(this.carouselStrategy)) {
            return eiissPGyurkRkDwj(this) != 1 ? jXCPoEgMojIoIRON(this) : AnoAXNGRJBiKlaoS(this);
        }
        return 0;
    }

    private void GetRightOrBottomPaddingForKeylineShift(byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetRightOrBottomPaddingForKeylineShift(byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetRightOrBottomPaddingForKeylineShift(short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private int GetScrollOffsetForPosition(int i, com.google.android.material.carousel.KeylineState keylineState) {
        if ((9 + 15) % 15 > 0) {
        }
        return (int) (!tNRfYNmfbPfMIpBo(this) ? ((i * DTQAdZprQatynTVu(keylineState)) - yOdIkiMjxOVcrBqV(keylineState).loc) + (QPUqTcPWOHlrGagu(keylineState) / 2.0f) : ((rUNcIjlRVBozNZCi(this) - LZVdDpcoBAeAuYQd(keylineState).loc) - (i * aMgvLLpPYFzWGOSh(keylineState))) - (LlKxrFPfWYXjKKON(keylineState) / 2.0f));
    }

    private void GetScrollOffsetForPosition(int i, com.google.android.material.carousel.KeylineState keylineState, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetScrollOffsetForPosition(int i, com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetScrollOffsetForPosition(int i, com.google.android.material.carousel.KeylineState keylineState, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private int GetSmallestScrollOffsetToFocalKeyline(int i, com.google.android.material.carousel.KeylineState keylineState) {
        if ((12 + 21) % 21 > 0) {
        }
        java.util.IEnumerator itHXWuwYgNHDbXURRr = HXWuwYgNHDbXURRr(XhxUQWLRDYtxLeih(keylineState));
        int i2 = int.MAX_VALUE;
        while (veysWkipoxspQERz(itHXWuwYgNHDbXURRr)) {
            com.google.android.material.carousel.KeylineState$Keyline keylineState$Keyline = (com.google.android.material.carousel.KeylineState$Keyline) HLkJkLJWtnabtWDC(itHXWuwYgNHDbXURRr);
            float fLwthwWTUIeFZeCiO = (i * lwthwWTUIeFZeCiO(keylineState)) + (DfvyfoqPWKzinJsP(keylineState) / 2.0f);
            int iDZQLKRMLPgIWxWik = (!wICtIMLWnnuBvrcc(this) ? (int) (fLwthwWTUIeFZeCiO - keylineState$Keyline.loc) : (int) ((dZQLKRMLPgIWxWik(this) - keylineState$Keyline.loc) - fLwthwWTUIeFZeCiO)) - this.scrollOffset;
            if (OcOASmOAJSuZDDyJ(i2) > ImDRpuXzDsgTPvbC(iDZQLKRMLPgIWxWik)) {
                i2 = iDZQLKRMLPgIWxWik;
            }
        }
        return i2;
    }

    private void GetSmallestScrollOffsetToFocalKeyline(int i, com.google.android.material.carousel.KeylineState keylineState, byte b, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetSmallestScrollOffsetToFocalKeyline(int i, com.google.android.material.carousel.KeylineState keylineState, int i2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetSmallestScrollOffsetToFocalKeyline(int i, com.google.android.material.carousel.KeylineState keylineState, bool z, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    private static com.google.android.material.carousel.CarouselLayoutManager$KeylineRange getSurroundingKeylineRange(java.util.List<com.google.android.material.carousel.KeylineState$Keyline> list, float f, bool z) {
        if ((5 + 29) % 29 > 0) {
        }
        float f2 = float.MAX_VALUE;
        int i = -1;
        int i2 = -1;
        int i3 = -1;
        int i4 = -1;
        float f3 = -3.4028235E38f;
        float f4 = float.MAX_VALUE;
        float f5 = float.MAX_VALUE;
        for (int i5 = 0; i5 < JEZicFMeOBXodxdi(list); i5++) {
            com.google.android.material.carousel.KeylineState$Keyline keylineState$Keyline = (com.google.android.material.carousel.KeylineState$Keyline) DOJcvbPqDKDkbAsU(list, i5);
            float f6 = !z ? keylineState$Keyline.loc : keylineState$Keyline.locOffset;
            float fVOcpKTavtLBFZzHo = VOcpKTavtLBFZzHo(f6 - f);
            if (f6 <= f && fVOcpKTavtLBFZzHo <= f2) {
                i = i5;
                f2 = fVOcpKTavtLBFZzHo;
            }
            if (f6 > f && fVOcpKTavtLBFZzHo <= f4) {
                i3 = i5;
                f4 = fVOcpKTavtLBFZzHo;
            }
            if (f6 <= f5) {
                i2 = i5;
                f5 = f6;
            }
            if (f6 > f3) {
                i4 = i5;
                f3 = f6;
            }
        }
        if (i == -1) {
            i = i2;
        }
        if (i3 == -1) {
            i3 = i4;
        }
        return new com.google.android.material.carousel.CarouselLayoutManager$KeylineRange((com.google.android.material.carousel.KeylineState$Keyline) ZzpvHnpkQLKQSFDu(list, i), (com.google.android.material.carousel.KeylineState$Keyline) okDZgTeklFvzWRiz(list, i3));
    }

    private static void GetSurroundingKeylineRange(java.util.List list, float f, bool z, byte b, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    private static void GetSurroundingKeylineRange(java.util.List list, float f, bool z, byte b, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private static void GetSurroundingKeylineRange(java.util.List list, float f, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float GlpeCwjwQMEFUjFS(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void GlpeCwjwQMEFUjFS(com.google.android.material.carousel.KeylineState keylineState, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GlpeCwjwQMEFUjFS(com.google.android.material.carousel.KeylineState keylineState, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GlpeCwjwQMEFUjFS(com.google.android.material.carousel.KeylineState keylineState, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List GppayxtHSYXLeGpL(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void GppayxtHSYXLeGpL(com.google.android.material.carousel.KeylineState keylineState, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GppayxtHSYXLeGpL(com.google.android.material.carousel.KeylineState keylineState, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GppayxtHSYXLeGpL(com.google.android.material.carousel.KeylineState keylineState, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HTDNoMJSGnxHxBdR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        carouselLayoutManager.removeAndRecycleobject(view, recyclerobject$Recycler);
    }

    public static void HTDNoMJSGnxHxBdR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HTDNoMJSGnxHxBdR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HTDNoMJSGnxHxBdR(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HfHSIlaHjLrOpArA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void HfHSIlaHjLrOpArA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HfHSIlaHjLrOpArA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HfHSIlaHjLrOpArA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline hgWSxSevFDSTYQcv(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastFocalKeyline();
    }

    public static void HgWSxSevFDSTYQcv(com.google.android.material.carousel.KeylineState keylineState, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HgWSxSevFDSTYQcv(com.google.android.material.carousel.KeylineState keylineState, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HgWSxSevFDSTYQcv(com.google.android.material.carousel.KeylineState keylineState, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline hjiuWCGtlHuJBXJE(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstKeyline();
    }

    public static void HjiuWCGtlHuJBXJE(com.google.android.material.carousel.KeylineState keylineState, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HjiuWCGtlHuJBXJE(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HjiuWCGtlHuJBXJE(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline hkGdGUvHJFEytCWR(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getLastKeyline();
    }

    public static void HkGdGUvHJFEytCWR(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HkGdGUvHJFEytCWR(com.google.android.material.carousel.KeylineState keylineState, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HkGdGUvHJFEytCWR(com.google.android.material.carousel.KeylineState keylineState, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int HmLVObcoCBlJLyzr(android.graphics.Rect rect) {
        return rect.width();
    }

    public static void HmLVObcoCBlJLyzr(android.graphics.Rect rect, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HmLVObcoCBlJLyzr(android.graphics.Rect rect, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HmLVObcoCBlJLyzr(android.graphics.Rect rect, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HnOkBMQlCWvziBPc(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener) {
        recyclerobject.removeOnLayoutChangeListener(view$OnLayoutChangeListener);
    }

    public static void HnOkBMQlCWvziBPc(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HnOkBMQlCWvziBPc(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HnOkBMQlCWvziBPc(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int HsMmKeIhvpujwzoT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getLeftOrTopPaddingForKeylineShift();
    }

    public static void HsMmKeIhvpujwzoT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HsMmKeIhvpujwzoT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HsMmKeIhvpujwzoT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int IArtZQrxOuFAgxNG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void IArtZQrxOuFAgxNG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IArtZQrxOuFAgxNG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IArtZQrxOuFAgxNG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int IAvLZuTRlVKvdNPq(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void IAvLZuTRlVKvdNPq(java.lang.string str, java.lang.string str2, char c, int i, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void IAvLZuTRlVKvdNPq(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IAvLZuTRlVKvdNPq(java.lang.string str, java.lang.string str2, bool z, int i, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ILWvKWgCBgLSuKUf(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void ILWvKWgCBgLSuKUf(float f, float f2, float f3, float f4, float f5, char c, int i, float f6, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ILWvKWgCBgLSuKUf(float f, float f2, float f3, float f4, float f5, char c, java.lang.string str, float f6, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ILWvKWgCBgLSuKUf(float f, float f2, float f3, float f4, float f5, float f6, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float IOVHmzhcGCdrgOMh(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void IOVHmzhcGCdrgOMh(float f, float f2, float f3, float f4, float f5, byte b, short s, bool z, float f6) {
        double d = (42 * 210) + 210;
    }

    public static void IOVHmzhcGCdrgOMh(float f, float f2, float f3, float f4, float f5, byte b, bool z, short s, float f6) {
        double d = (42 * 210) + 210;
    }

    public static void IOVHmzhcGCdrgOMh(float f, float f2, float f3, float f4, float f5, float f6, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IOipPoRzUEVqzSow(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        super.onLayoutCompleted(recyclerobject$State);
    }

    public static void IOipPoRzUEVqzSow(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IOipPoRzUEVqzSow(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IOipPoRzUEVqzSow(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IViSjQyiIfKVQqwQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return carouselLayoutManager.scrollBy(i, recyclerobject$Recycler, recyclerobject$State);
    }

    public static void IViSjQyiIfKVQqwQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, char c, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IViSjQyiIfKVQqwQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, float f, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IViSjQyiIfKVQqwQ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i2, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IbvxKidzzPZtbVqd(android.graphics.Rect rect) {
        return rect.height();
    }

    public static void IbvxKidzzPZtbVqd(android.graphics.Rect rect, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IbvxKidzzPZtbVqd(android.graphics.Rect rect, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IbvxKidzzPZtbVqd(android.graphics.Rect rect, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IcmCakTpwWhEBKTU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void IcmCakTpwWhEBKTU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IcmCakTpwWhEBKTU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IcmCakTpwWhEBKTU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void IsLocOffsetOutOfFillBoundsEnd(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsLocOffsetOutOfFillBoundsEnd(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void IsLocOffsetOutOfFillBoundsEnd(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private bool IsLocOffsetOutOfFillBoundsEnd(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        if ((13 + 2) % 2 > 0) {
        }
        float fXESChBjXjSqwwKaw = XESChBjXjSqwwKaw(this, f, aBZqgEoORSnehyLy(this, f, carouselLayoutManager$KeylineRange) / 2.0f);
        return !uuzEvABhrPjpgSME(this) ? fXESChBjXjSqwwKaw > ((float) OSNKPpknLVrbVPEE(this)) : fXESChBjXjSqwwKaw < 0.0f;
    }

    private void IsLocOffsetOutOfFillBoundsStart(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, float f2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsLocOffsetOutOfFillBoundsStart(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, bool z, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    private void IsLocOffsetOutOfFillBoundsStart(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, float f2, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private bool IsLocOffsetOutOfFillBoundsStart(float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        if ((32 + 20) % 20 > 0) {
        }
        float fKMrvFQPBtRqSlTfU = KMrvFQPBtRqSlTfU(this, f, FMaaCOisNlhCzWku(this, f, carouselLayoutManager$KeylineRange) / 2.0f);
        return !aCPMXlEFgOtEZmvQ(this) ? fKMrvFQPBtRqSlTfU < 0.0f : fKMrvFQPBtRqSlTfU > ((float) fqRvbxVbjHrIrtpS(this));
    }

    public static int JBDoBSxmRvQlqrpb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getWidth();
    }

    public static void JBDoBSxmRvQlqrpb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JBDoBSxmRvQlqrpb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JBDoBSxmRvQlqrpb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JBttBYFUjmVIsDFO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getItemCount();
    }

    public static void JBttBYFUjmVIsDFO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JBttBYFUjmVIsDFO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JBttBYFUjmVIsDFO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JOkXiGeocWTIwNlo(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration) {
        recyclerobject.removeItemDecoration(recyclerobject$ItemDecoration);
    }

    public static void JOkXiGeocWTIwNlo(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JOkXiGeocWTIwNlo(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JOkXiGeocWTIwNlo(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState JRpwGElZziKgBUuP(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getDefaultState();
    }

    public static void JRpwGElZziKgBUuP(com.google.android.material.carousel.KeylineStateList keylineStateList, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JRpwGElZziKgBUuP(com.google.android.material.carousel.KeylineStateList keylineStateList, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JRpwGElZziKgBUuP(com.google.android.material.carousel.KeylineStateList keylineStateList, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JVSmWoueDZaEkSGj(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void JVSmWoueDZaEkSGj(java.lang.stringBuilder sb, int i, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JVSmWoueDZaEkSGj(java.lang.stringBuilder sb, int i, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JVSmWoueDZaEkSGj(java.lang.stringBuilder sb, int i, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JXCPoEgMojIoIRON(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getPaddingRight();
    }

    public static void JXCPoEgMojIoIRON(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JXCPoEgMojIoIRON(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JXCPoEgMojIoIRON(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JdKGMVjARRpyGhCA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        carouselLayoutManager.recalculateKeylineStateList(recyclerobject$Recycler);
    }

    public static void JdKGMVjARRpyGhCA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JdKGMVjARRpyGhCA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JdKGMVjARRpyGhCA(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JmILLZNlAfMaqRoj(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper) {
        return carouselOrientationHelper.getParentBottom();
    }

    public static void JmILLZNlAfMaqRoj(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JmILLZNlAfMaqRoj(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JmILLZNlAfMaqRoj(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JscGZYDkYSLzBCpP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        carouselLayoutManager.removeAndRecycleAllobjects(recyclerobject$Recycler);
    }

    public static void JscGZYDkYSLzBCpP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JscGZYDkYSLzBCpP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JscGZYDkYSLzBCpP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float JyODcfyTNmmvcapQ(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void JyODcfyTNmmvcapQ(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JyODcfyTNmmvcapQ(com.google.android.material.carousel.KeylineState keylineState, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JyODcfyTNmmvcapQ(com.google.android.material.carousel.KeylineState keylineState, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState KBYCFtOiRYAnvYqJ(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getStartState();
    }

    public static void KBYCFtOiRYAnvYqJ(com.google.android.material.carousel.KeylineStateList keylineStateList, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KBYCFtOiRYAnvYqJ(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KBYCFtOiRYAnvYqJ(com.google.android.material.carousel.KeylineStateList keylineStateList, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KtLzdBgxdyibkYyy(com.google.android.material.carousel.CarouselStrategy carouselStrategy, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KtLzdBgxdyibkYyy(com.google.android.material.carousel.CarouselStrategy carouselStrategy, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtLzdBgxdyibkYyy(com.google.android.material.carousel.CarouselStrategy carouselStrategy, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KtLzdBgxdyibkYyy(com.google.android.material.carousel.CarouselStrategy carouselStrategy) {
        return carouselStrategy.isContained();
    }

    public static java.lang.int KywUJYbVQsdSgZBx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void KywUJYbVQsdSgZBx(int i, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KywUJYbVQsdSgZBx(int i, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KywUJYbVQsdSgZBx(int i, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LJfCdHjJTkzISPdm(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void LJfCdHjJTkzISPdm(android.content.res.TypedArray typedArray, int i, int i2, char c, java.lang.string str, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LJfCdHjJTkzISPdm(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LJfCdHjJTkzISPdm(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void LXbvwgQqQtrJsTCU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXbvwgQqQtrJsTCU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LXbvwgQqQtrJsTCU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool LXbvwgQqQtrJsTCU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static int LhnmhmiLJYCPZjoZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void LhnmhmiLJYCPZjoZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LhnmhmiLJYCPZjoZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LhnmhmiLJYCPZjoZ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LiMDTJKKETGlsPvj(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void LiMDTJKKETGlsPvj(int i, int i2, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LiMDTJKKETGlsPvj(int i, int i2, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LiMDTJKKETGlsPvj(int i, int i2, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void LogChildrenIfDebugging() {
        if ((27 + 2) % 2 > 0) {
        }
        if (this.isDebuggingEnabled && FDjvUDUXTWhjGnZX("CarouselLayoutManager", 3)) {
            FbbzKnKZBWQgNoxr("CarouselLayoutManager", "internal representation of views on the screen");
            for (int i = 0; i < pTkjjxXGZGgPHPnv(this); i++) {
                android.view.object viewCAbRpZQldcsSQjtq = CAbRpZQldcsSQjtq(this, i);
                KvKCjVJeqyKrBWDx("CarouselLayoutManager", BIQIxpKcWFLTGdgP(YZLeQRrTpPpSNMhO(RjdyLdUIaVMbnLra(tFiiWIErxdufZeBE(luDphjLpolIPlliC(jVSmWoueDZaEkSGj(new java.lang.stringBuilder("item position "), LXhxltkqEFYvvgan(this, viewCAbRpZQldcsSQjtq)), ", center:"), ZdgyYuuKbbzIAdoY(this, viewCAbRpZQldcsSQjtq)), ", child index:"), i)));
            }
            dYpXTZaGSTRwszLt("CarouselLayoutManager", "==============");
        }
    }

    private void LogChildrenIfDebugging(float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void LogChildrenIfDebugging(float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void LogChildrenIfDebugging(float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LuDphjLpolIPlliC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LuDphjLpolIPlliC(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LuDphjLpolIPlliC(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LuDphjLpolIPlliC(java.lang.stringBuilder sb, java.lang.string str, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.CarouselOrientationHelper LuRIdIDkBXKkhhpE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return com.google.android.material.carousel.CarouselOrientationHelper.createOrientationHelper(carouselLayoutManager, i);
    }

    public static void LuRIdIDkBXKkhhpE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LuRIdIDkBXKkhhpE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LuRIdIDkBXKkhhpE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float LwthwWTUIeFZeCiO(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void LwthwWTUIeFZeCiO(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LwthwWTUIeFZeCiO(com.google.android.material.carousel.KeylineState keylineState, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LwthwWTUIeFZeCiO(com.google.android.material.carousel.KeylineState keylineState, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int MHHjCYiIOHvJXSBt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getItemCount();
    }

    public static void MHHjCYiIOHvJXSBt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MHHjCYiIOHvJXSBt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MHHjCYiIOHvJXSBt(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MLeJqdVaPayLZBQP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MLeJqdVaPayLZBQP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MLeJqdVaPayLZBQP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MLeJqdVaPayLZBQP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isHorizontal();
    }

    public static int MSBrKdXWVHxsamWd(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentStart();
    }

    public static void MSBrKdXWVHxsamWd(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MSBrKdXWVHxsamWd(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MSBrKdXWVHxsamWd(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float MXWOCqNiQMjySMen(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void MXWOCqNiQMjySMen(float f, float f2, float f3, float f4, float f5, char c, java.lang.string str, float f6, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MXWOCqNiQMjySMen(float f, float f2, float f3, float f4, float f5, float f6, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MXWOCqNiQMjySMen(float f, float f2, float f3, float f4, float f5, java.lang.string str, byte b, float f6, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MZdsRKrSJGIlckTm(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect) {
        super.getDecoratedBoundsWithMargins(view, rect);
    }

    public static void MZdsRKrSJGIlckTm(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MZdsRKrSJGIlckTm(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MZdsRKrSJGIlckTm(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, android.view.object view, android.graphics.Rect rect, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations makeChildCalculations(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i) {
        if ((24 + 7) % 7 > 0) {
        }
        android.view.object viewVQZYqWYIijNaPTZF = VQZYqWYIijNaPTZF(recyclerobject$Recycler, i);
        HySEmiuuKHVCPDjF(this, viewVQZYqWYIijNaPTZF, 0, 0);
        float fNbGtzAORanPzSUoN = nbGtzAORanPzSUoN(this, f, HowRlLVmgHhBDWrJ(this.currentKeylineState) / 2.0f);
        com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRangeWXbdfzvfzdWueyph = wXbdfzvfzdWueyph(ncRYMlnEcNvWVtxI(this.currentKeylineState), fNbGtzAORanPzSUoN, false);
        return new com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations(viewVQZYqWYIijNaPTZF, fNbGtzAORanPzSUoN, gWdpeUIWqueTYZdv(this, viewVQZYqWYIijNaPTZF, fNbGtzAORanPzSUoN, carouselLayoutManager$KeylineRangeWXbdfzvfzdWueyph), carouselLayoutManager$KeylineRangeWXbdfzvfzdWueyph);
    }

    private void MakeChildCalculations(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, int i2, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void MakeChildCalculations(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, int i2, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void MakeChildCalculations(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, int i, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float MgwwnRgwFacBaIbW(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void MgwwnRgwFacBaIbW(com.google.android.material.carousel.KeylineState keylineState, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MgwwnRgwFacBaIbW(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MgwwnRgwFacBaIbW(com.google.android.material.carousel.KeylineState keylineState, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int MjWMgMeXRdxhdwvu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getContainerHeight();
    }

    public static void MjWMgMeXRdxhdwvu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MjWMgMeXRdxhdwvu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MjWMgMeXRdxhdwvu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MoLkwIaZrLExwkip(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getItemCount();
    }

    public static void MoLkwIaZrLExwkip(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MoLkwIaZrLExwkip(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MoLkwIaZrLExwkip(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NVRiRXrwCXROhpkW(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void NVRiRXrwCXROhpkW(android.content.res.TypedArray typedArray, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NVRiRXrwCXROhpkW(android.content.res.TypedArray typedArray, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NVRiRXrwCXROhpkW(android.content.res.TypedArray typedArray, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float NbGtzAORanPzSUoN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2) {
        return carouselLayoutManager.addEnd(f, f2);
    }

    public static void NbGtzAORanPzSUoN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, char c, float f3, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NbGtzAORanPzSUoN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, float f3, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NbGtzAORanPzSUoN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, int i, short s, char c, float f3) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List NcRYMlnEcNvWVtxI(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void NcRYMlnEcNvWVtxI(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NcRYMlnEcNvWVtxI(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NcRYMlnEcNvWVtxI(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NeRyXknqUNaVGSFa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2) {
        carouselLayoutManager.addobjectAtPosition(recyclerobject$Recycler, i, i2);
    }

    public static void NeRyXknqUNaVGSFa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NeRyXknqUNaVGSFa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NeRyXknqUNaVGSFa(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline nhUiTSMfDoOsiMsR(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeyline();
    }

    public static void NhUiTSMfDoOsiMsR(com.google.android.material.carousel.KeylineState keylineState, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NhUiTSMfDoOsiMsR(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NhUiTSMfDoOsiMsR(com.google.android.material.carousel.KeylineState keylineState, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NyLTRYTxIVjJJibO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NyLTRYTxIVjJJibO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NyLTRYTxIVjJJibO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NyLTRYTxIVjJJibO(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.canScrollHorizontally();
    }

    public static java.lang.stringBuilder OBDgPIjpFJFQKDeG(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void OBDgPIjpFJFQKDeG(java.lang.stringBuilder sb, int i, float f, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OBDgPIjpFJFQKDeG(java.lang.stringBuilder sb, int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OBDgPIjpFJFQKDeG(java.lang.stringBuilder sb, int i, float f, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OFTptoJoDLlmjiYI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList) {
        carouselLayoutManager.updateCurrentKeylineStateForScrollOffset(keylineStateList);
    }

    public static void OFTptoJoDLlmjiYI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OFTptoJoDLlmjiYI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OFTptoJoDLlmjiYI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OGIoHhXImkjnjTeF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OGIoHhXImkjnjTeF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OGIoHhXImkjnjTeF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool OGIoHhXImkjnjTeF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.canScrollVertically();
    }

    public static int OcRqkfHwndexjtUf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getLayoutDirection();
    }

    public static void OcRqkfHwndexjtUf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OcRqkfHwndexjtUf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OcRqkfHwndexjtUf(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OeooklyiAhsEHrcC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getItemCount();
    }

    public static void OeooklyiAhsEHrcC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OeooklyiAhsEHrcC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OeooklyiAhsEHrcC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private float OffsetChild(android.view.object view, float f, float f2, android.graphics.Rect rect) {
        if ((31 + 24) % 24 > 0) {
        }
        float fTxWCGnSXQjRRCNGv = txWCGnSXQjRRCNGv(this, f, f2);
        com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRangeNrWDyKrVPQwvawbj = NrWDyKrVPQwvawbj(ueNAETAbbnHjWxxX(this.currentKeylineState), fTxWCGnSXQjRRCNGv, false);
        float fMdRIaRwSaHlTmCtI = MdRIaRwSaHlTmCtI(this, view, fTxWCGnSXQjRRCNGv, carouselLayoutManager$KeylineRangeNrWDyKrVPQwvawbj);
        SNJcHnDnFxWZYfDU(this, view, rect);
        vzBqNsbBLhAPRMkP(this, view, fTxWCGnSXQjRRCNGv, carouselLayoutManager$KeylineRangeNrWDyKrVPQwvawbj);
        fIptWUydeWJvMRFn(this.orientationHelper, view, rect, f2, fMdRIaRwSaHlTmCtI);
        return fMdRIaRwSaHlTmCtI;
    }

    private void OffsetChild(android.view.object view, float f, float f2, android.graphics.Rect rect, int i, float f3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void OffsetChild(android.view.object view, float f, float f2, android.graphics.Rect rect, bool z, byte b, int i, float f3) {
        double d = (42 * 210) + 210;
    }

    private void OffsetChild(android.view.object view, float f, float f2, android.graphics.Rect rect, bool z, int i, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OgDuoJdamKRJaXZK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations) {
        carouselLayoutManager.addAndLayoutobject(view, i, carouselLayoutManager$ChildCalculations);
    }

    public static void OgDuoJdamKRJaXZK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OgDuoJdamKRJaXZK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, bool z, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OgDuoJdamKRJaXZK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OiSRTtVlOzPfSEmc(android.graphics.Rect rect) {
        return rect.centerX();
    }

    public static void OiSRTtVlOzPfSEmc(android.graphics.Rect rect, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OiSRTtVlOzPfSEmc(android.graphics.Rect rect, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OiSRTtVlOzPfSEmc(android.graphics.Rect rect, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OkDZgTeklFvzWRiz(java.util.List list, int i) {
        return list[i);
    }

    public static void OkDZgTeklFvzWRiz(java.util.List list, int i, float f, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OkDZgTeklFvzWRiz(java.util.List list, int i, float f, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OkDZgTeklFvzWRiz(java.util.List list, int i, java.lang.string str, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OmllHYlqFxtBCyky(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList) {
        carouselLayoutManager.updateCurrentKeylineStateForScrollOffset(keylineStateList);
    }

    public static void OmllHYlqFxtBCyky(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OmllHYlqFxtBCyky(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OmllHYlqFxtBCyky(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.KeylineStateList keylineStateList, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OtnKBSsfXBhYbWFB(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration) {
        recyclerobject.addItemDecoration(recyclerobject$ItemDecoration);
    }

    public static void OtnKBSsfXBhYbWFB(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OtnKBSsfXBhYbWFB(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OtnKBSsfXBhYbWFB(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OwEXOOeoaksOkwTC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        carouselLayoutManager.scrollBy(recyclerobject, i);
    }

    public static void OwEXOOeoaksOkwTC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, byte b, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OwEXOOeoaksOkwTC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, char c, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OwEXOOeoaksOkwTC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int OxCoCTDacgcSsoVc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getItemCount();
    }

    public static void OxCoCTDacgcSsoVc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OxCoCTDacgcSsoVc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OxCoCTDacgcSsoVc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PEJcqXbntMEXsPgC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        carouselLayoutManager.detachAndScrapAttachedobjects(recyclerobject$Recycler);
    }

    public static void PEJcqXbntMEXsPgC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PEJcqXbntMEXsPgC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PEJcqXbntMEXsPgC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState PLrWOeLqjqwKczVG(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getDefaultState();
    }

    public static void PLrWOeLqjqwKczVG(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PLrWOeLqjqwKczVG(com.google.android.material.carousel.KeylineStateList keylineStateList, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PLrWOeLqjqwKczVG(com.google.android.material.carousel.KeylineStateList keylineStateList, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PTkjjxXGZGgPHPnv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void PTkjjxXGZGgPHPnv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PTkjjxXGZGgPHPnv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PTkjjxXGZGgPHPnv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float PUFmsOdIgdrObWms(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2) {
        return carouselLayoutManager.addEnd(f, f2);
    }

    public static void PUFmsOdIgdrObWms(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PUFmsOdIgdrObWms(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PUFmsOdIgdrObWms(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState PWPgvTmKCVWBqEfV(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, bool z) {
        return keylineStateList.getShiftedState(f, f2, f3, z);
    }

    public static void PWPgvTmKCVWBqEfV(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, bool z, byte b, java.lang.string str, float f4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PWPgvTmKCVWBqEfV(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, bool z, java.lang.string str, float f4, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PWPgvTmKCVWBqEfV(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, bool z, java.lang.string str, short s, float f4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float PapsdBdLIauetntJ(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void PapsdBdLIauetntJ(com.google.android.material.carousel.KeylineState keylineState, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PapsdBdLIauetntJ(com.google.android.material.carousel.KeylineState keylineState, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PapsdBdLIauetntJ(com.google.android.material.carousel.KeylineState keylineState, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PddGkcIXnpbdFpTE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PddGkcIXnpbdFpTE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PddGkcIXnpbdFpTE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PddGkcIXnpbdFpTE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static void PvIabhJsMPzLmMCp(com.google.android.material.carousel.CarouselStrategy carouselStrategy, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PvIabhJsMPzLmMCp(com.google.android.material.carousel.CarouselStrategy carouselStrategy, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PvIabhJsMPzLmMCp(com.google.android.material.carousel.CarouselStrategy carouselStrategy, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool PvIabhJsMPzLmMCp(com.google.android.material.carousel.CarouselStrategy carouselStrategy) {
        return carouselStrategy.isContained();
    }

    public static android.view.object QCbRzSpDeHzfXflG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void QCbRzSpDeHzfXflG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QCbRzSpDeHzfXflG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QCbRzSpDeHzfXflG(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QDslEFjeWqmEzAlI(com.google.android.material.carousel.Maskable maskable, android.graphics.RectF rectF) {
        maskable.setMaskRectF(rectF);
    }

    public static void QDslEFjeWqmEzAlI(com.google.android.material.carousel.Maskable maskable, android.graphics.RectF rectF, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QDslEFjeWqmEzAlI(com.google.android.material.carousel.Maskable maskable, android.graphics.RectF rectF, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QDslEFjeWqmEzAlI(com.google.android.material.carousel.Maskable maskable, android.graphics.RectF rectF, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QSzvoJsQvyyIrETc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QSzvoJsQvyyIrETc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QSzvoJsQvyyIrETc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QSzvoJsQvyyIrETc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.isLocOffsetOutOfFillBoundsStart(f, carouselLayoutManager$KeylineRange);
    }

    public static com.google.android.material.carousel.KeylineState QYplbSGyTZvKUaNe(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3) {
        return keylineStateList.getShiftedState(f, f2, f3);
    }

    public static void QYplbSGyTZvKUaNe(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, char c, float f4, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QYplbSGyTZvKUaNe(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, float f4, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QYplbSGyTZvKUaNe(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, float f2, float f3, int i, float f4, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float QdrixlTCeOcIJrvB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2) {
        return carouselLayoutManager.addEnd(f, f2);
    }

    public static void QdrixlTCeOcIJrvB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, float f3, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QdrixlTCeOcIJrvB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, java.lang.string str, short s, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QdrixlTCeOcIJrvB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, short s, byte b, java.lang.string str, float f3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QfTUdLMxDuxVvWgh(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void QfTUdLMxDuxVvWgh(java.lang.stringBuilder sb, int i, byte b, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QfTUdLMxDuxVvWgh(java.lang.stringBuilder sb, int i, short s, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QfTUdLMxDuxVvWgh(java.lang.stringBuilder sb, int i, short s, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QmoeMJKZKpuVTcIW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QmoeMJKZKpuVTcIW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QmoeMJKZKpuVTcIW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool QmoeMJKZKpuVTcIW(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getClipToPadding();
    }

    public static android.content.object QnEKXeJQwXoljdib(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.getobject();
    }

    public static void QnEKXeJQwXoljdib(androidx.recyclerview.widget.Recyclerobject recyclerobject, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QnEKXeJQwXoljdib(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QnEKXeJQwXoljdib(androidx.recyclerview.widget.Recyclerobject recyclerobject, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RBNhYyhukNoulSvx(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void RBNhYyhukNoulSvx(java.lang.stringBuilder sb, int i, float f, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RBNhYyhukNoulSvx(java.lang.stringBuilder sb, int i, bool z, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RBNhYyhukNoulSvx(java.lang.stringBuilder sb, int i, bool z, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ROGbmcgMTfHcqNta(int i, int i2, int i3) {
        return androidx.core.math.MathUtils.clamp(i, i2, i3);
    }

    public static void ROGbmcgMTfHcqNta(int i, int i2, int i3, char c, int i4, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ROGbmcgMTfHcqNta(int i, int i2, int i3, short s, bool z, char c, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void ROGbmcgMTfHcqNta(int i, int i2, int i3, short s, bool z, int i4, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RUNcIjlRVBozNZCi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getContainerSize();
    }

    public static void RUNcIjlRVBozNZCi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RUNcIjlRVBozNZCi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RUNcIjlRVBozNZCi(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RXFchiGICtMVHJeJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RXFchiGICtMVHJeJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RXFchiGICtMVHJeJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RXFchiGICtMVHJeJ(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    private void RecalculateKeylineStateList(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        if ((22 + 22) % 22 > 0) {
        }
        android.view.object viewMaQRwmaKioZBzNoI = MaQRwmaKioZBzNoI(recyclerobject$Recycler, 0);
        WoyluyEwHFhgOhrp(this, viewMaQRwmaKioZBzNoI, 0, 0);
        com.google.android.material.carousel.KeylineState keylineStateKWjdSMpuqsuKtlhm = KWjdSMpuqsuKtlhm(this.carouselStrategy, this, viewMaQRwmaKioZBzNoI);
        if (ATLOsERMfYGXBHAe(this)) {
            keylineStateKWjdSMpuqsuKtlhm = WmamXXNKTrnoQxdW(keylineStateKWjdSMpuqsuKtlhm, JupOshJrBtmYlFVF(this));
        }
        this.keylineStateList = vtruULmjOsUrfJxQ(this, keylineStateKWjdSMpuqsuKtlhm, NEmqRpnHGidARzcm(this), hsMmKeIhvpujwzoT(this), xhMgZZEuuomCYKjr(this));
    }

    private void RecalculateKeylineStateList(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RecalculateKeylineStateList(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void RecalculateKeylineStateList(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void RefreshKeylineState() {
        this.keylineStateList = null;
        VRtcQzIaaQuedYyW(this);
    }

    private void RefreshKeylineState(byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void RefreshKeylineState(char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void RefreshKeylineState(char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void RemoveAndRecycleOutOfBoundsobjects(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        if ((27 + 27) % 27 > 0) {
        }
        while (xCRdUDoptRqmEkJh(this) > 0) {
            android.view.object viewSWtRFxDeGnByLgyl = sWtRFxDeGnByLgyl(this, 0);
            float fNUdYcAFPJcpUvPpi = NUdYcAFPJcpUvPpi(this, viewSWtRFxDeGnByLgyl);
            if (!qSzvoJsQvyyIrETc(this, fNUdYcAFPJcpUvPpi, AmbhOdAPIioTQGRz(vljRLAssiAtHAfct(this.currentKeylineState), fNUdYcAFPJcpUvPpi, true))) {
                break;
            } else {
                hTDNoMJSGnxHxBdR(this, viewSWtRFxDeGnByLgyl, recyclerobject$Recycler);
            }
        }
        while (egImpypThtVrCBuG(this) - 1 >= 0) {
            android.view.object viewQCbRzSpDeHzfXflG = qCbRzSpDeHzfXflG(this, FmXXQWOLNjDttMSm(this) - 1);
            float fHuyfBzcSbSvDfWAS = HuyfBzcSbSvDfWAS(this, viewQCbRzSpDeHzfXflG);
            if (!BEJuoegUKgBHJBdY(this, fHuyfBzcSbSvDfWAS, QAYjkmJaMIHEIPqM(uGljjpkgNYeEjegH(this.currentKeylineState), fHuyfBzcSbSvDfWAS, true))) {
                return;
            } else {
                FjuvyPMLngZlccXR(this, viewQCbRzSpDeHzfXflG, recyclerobject$Recycler);
            }
        }
    }

    private void RemoveAndRecycleOutOfBoundsobjects(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void RemoveAndRecycleOutOfBoundsobjects(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RemoveAndRecycleOutOfBoundsobjects(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState RhzoyZCLvWGXjIOK(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        return keylineStateList.getDefaultState();
    }

    public static void RhzoyZCLvWGXjIOK(com.google.android.material.carousel.KeylineStateList keylineStateList, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RhzoyZCLvWGXjIOK(com.google.android.material.carousel.KeylineStateList keylineStateList, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RhzoyZCLvWGXjIOK(com.google.android.material.carousel.KeylineStateList keylineStateList, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RkHjNrNcpYjDPbBX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        carouselLayoutManager.recalculateKeylineStateList(recyclerobject$Recycler);
    }

    public static void RkHjNrNcpYjDPbBX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RkHjNrNcpYjDPbBX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RkHjNrNcpYjDPbBX(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RqTZdrQDURDxeApq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RqTZdrQDURDxeApq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RqTZdrQDURDxeApq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RqTZdrQDURDxeApq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isHorizontal();
    }

    public static void RwsRglFBLBTDJLVa(com.google.android.material.carousel.CarouselStrategy carouselStrategy, com.google.android.material.carousel.Carousel carousel, int i, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RwsRglFBLBTDJLVa(com.google.android.material.carousel.CarouselStrategy carouselStrategy, com.google.android.material.carousel.Carousel carousel, int i, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RwsRglFBLBTDJLVa(com.google.android.material.carousel.CarouselStrategy carouselStrategy, com.google.android.material.carousel.Carousel carousel, int i, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool RwsRglFBLBTDJLVa(com.google.android.material.carousel.CarouselStrategy carouselStrategy, com.google.android.material.carousel.Carousel carousel, int i) {
        return carouselStrategy.shouldRefreshKeylineState(carousel, i);
    }

    public static void SFbJRqrbVscRsieh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        carouselLayoutManager.refreshKeylineState();
    }

    public static void SFbJRqrbVscRsieh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SFbJRqrbVscRsieh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SFbJRqrbVscRsieh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object SMNIgentypfIyRzh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void SMNIgentypfIyRzh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SMNIgentypfIyRzh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SMNIgentypfIyRzh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object SWtRFxDeGnByLgyl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void SWtRFxDeGnByLgyl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SWtRFxDeGnByLgyl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SWtRFxDeGnByLgyl(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private int ScrollBy(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((2 + 15) % 15 > 0) {
        }
        if (PzqppJWSsnThRFtU(this) == 0 || i == 0) {
            return 0;
        }
        if (this.keylineStateList is null) {
            jdKGMVjARRpyGhCA(this, recyclerobject$Recycler);
        }
        int iGeUyeIIXYGMKwzjq = geUyeIIXYGMKwzjq(i, this.scrollOffset, this.minScroll, this.maxScroll);
        this.scrollOffset += iGeUyeIIXYGMKwzjq;
        oFTptoJoDLlmjiYI(this, this.keylineStateList);
        float fQEGaTUEIFeoJWfzB = QEGaTUEIFeoJWfzB(this.currentKeylineState) / 2.0f;
        float fJraTTchZuoyILtZl = JraTTchZuoyILtZl(this, PmuSRvYmbiOEKpkG(this, PaxBHpSpxEfWcEJQ(this, 0)));
        android.graphics.Rect rect = new android.graphics.Rect();
        float f = !rXFchiGICtMVHJeJ(this) ? vCEYFARekAMEoaft(this.currentKeylineState).locOffset : bApgtgZsqfRzajFF(this.currentKeylineState).locOffset;
        float f2 = float.MAX_VALUE;
        for (int i2 = 0; i2 < PqyQNbxxLLqqRMoL(this); i2++) {
            android.view.object viewTBJbcEceoHMEXoQg = tBJbcEceoHMEXoQg(this, i2);
            float fBMIrmMCfvLAEQeqQ = bMIrmMCfvLAEQeqQ(f - DElIeRVHJpbmeodl(this, viewTBJbcEceoHMEXoQg, fJraTTchZuoyILtZl, fQEGaTUEIFeoJWfzB, rect));
            if (viewTBJbcEceoHMEXoQg is not null && fBMIrmMCfvLAEQeqQ < f2) {
                this.currentEstimatedPosition = zQslMMwRZJQAYHAY(this, viewTBJbcEceoHMEXoQg);
                f2 = fBMIrmMCfvLAEQeqQ;
            }
            fJraTTchZuoyILtZl = pUFmsOdIgdrObWms(this, fJraTTchZuoyILtZl, papsdBdLIauetntJ(this.currentKeylineState));
        }
        aXiVHFmFxRorqvxU(this, recyclerobject$Recycler, recyclerobject$State);
        return iGeUyeIIXYGMKwzjq;
    }

    private void ScrollBy(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void ScrollBy(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ScrollBy(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void ScrollBy(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        if (VazwQQkWZsepBhPy(this)) {
            dKQhyEjtGxGNxkTM(recyclerobject, i, 0);
        } else {
            NElAeXdHPxhBDTPT(recyclerobject, 0, i);
        }
    }

    private void ScrollBy(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    private void ScrollBy(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, short s, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    private void ScrollBy(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ScxOlGgKSksSXjRc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        carouselLayoutManager.removeAndRecycleOutOfBoundsobjects(recyclerobject$Recycler);
    }

    public static void ScxOlGgKSksSXjRc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ScxOlGgKSksSXjRc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ScxOlGgKSksSXjRc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetCarouselAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if (attributeHashSet is null) {
            return;
        }
        android.content.res.TypedArray typedArrayBhLODJXJRfUDXJuu = bhLODJXJRfUDXJuu(context, attributeHashSet, com.google.android.material.R$styleable.Carousel);
        JwHryTOUneGSpARZ(this, lJfCdHjJTkzISPdm(typedArrayBhLODJXJRfUDXJuu, com.google.android.material.R$styleable.Carousel_carousel_alignment, 0));
        PufByDAXTJXQKQHi(this, tIUlumjelgznDNpN(typedArrayBhLODJXJRfUDXJuu, com.google.android.material.R$styleable.Recyclerobject_android_orientation, 0));
        nVRiRXrwCXROhpkW(typedArrayBhLODJXJRfUDXJuu);
    }

    private void SetCarouselAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetCarouselAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetCarouselAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object SpQzbWDfmFGTtjhc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildClosestToEnd();
    }

    public static void SpQzbWDfmFGTtjhc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SpQzbWDfmFGTtjhc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SpQzbWDfmFGTtjhc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SyDXQYpiWQSBsILC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void SyDXQYpiWQSBsILC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SyDXQYpiWQSBsILC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SyDXQYpiWQSBsILC(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TBJbcEceoHMEXoQg(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void TBJbcEceoHMEXoQg(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TBJbcEceoHMEXoQg(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TBJbcEceoHMEXoQg(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TFiiWIErxdufZeBE(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void TFiiWIErxdufZeBE(java.lang.stringBuilder sb, float f, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TFiiWIErxdufZeBE(java.lang.stringBuilder sb, float f, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TFiiWIErxdufZeBE(java.lang.stringBuilder sb, float f, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int THGmkgrCIRsIZeAN(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return recyclerobject$State.getItemCount();
    }

    public static void THGmkgrCIRsIZeAN(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void THGmkgrCIRsIZeAN(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void THGmkgrCIRsIZeAN(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int THKCBKBIKrHorhlb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return carouselLayoutManager.computeHorizontalScrollRange(recyclerobject$State);
    }

    public static void THKCBKBIKrHorhlb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void THKCBKBIKrHorhlb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void THKCBKBIKrHorhlb(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int TIUlumjelgznDNpN(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void TIUlumjelgznDNpN(android.content.res.TypedArray typedArray, int i, int i2, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TIUlumjelgznDNpN(android.content.res.TypedArray typedArray, int i, int i2, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TIUlumjelgznDNpN(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TMiYNeIjAcQUkLNx(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i) {
        accessibilityEvent.setFromIndex(i);
    }

    public static void TMiYNeIjAcQUkLNx(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i, char c, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TMiYNeIjAcQUkLNx(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i, int i2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TMiYNeIjAcQUkLNx(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TNRfYNmfbPfMIpBo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TNRfYNmfbPfMIpBo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TNRfYNmfbPfMIpBo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TNRfYNmfbPfMIpBo(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static int TgGAgnQGcHVtcMQB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.convertFocusDirectionToLayoutDirection(i);
    }

    public static void TgGAgnQGcHVtcMQB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TgGAgnQGcHVtcMQB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TgGAgnQGcHVtcMQB(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static float TjFREpyHTvtLKuyl(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void TjFREpyHTvtLKuyl(float f, float f2, float f3, float f4, float f5, char c, float f6, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TjFREpyHTvtLKuyl(float f, float f2, float f3, float f4, float f5, float f6, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TjFREpyHTvtLKuyl(float f, float f2, float f3, float f4, float f5, float f6, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TtKmwznADdlCdeIE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.CarouselStrategy carouselStrategy) {
        carouselLayoutManager.setCarouselStrategy(carouselStrategy);
    }

    public static void TtKmwznADdlCdeIE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.CarouselStrategy carouselStrategy, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TtKmwznADdlCdeIE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.CarouselStrategy carouselStrategy, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TtKmwznADdlCdeIE(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, com.google.android.material.carousel.CarouselStrategy carouselStrategy, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float TxWCGnSXQjRRCNGv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2) {
        return carouselLayoutManager.addEnd(f, f2);
    }

    public static void TxWCGnSXQjRRCNGv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TxWCGnSXQjRRCNGv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TxWCGnSXQjRRCNGv(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, float f2, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List UGljjpkgNYeEjegH(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void UGljjpkgNYeEjegH(com.google.android.material.carousel.KeylineState keylineState, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UGljjpkgNYeEjegH(com.google.android.material.carousel.KeylineState keylineState, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UGljjpkgNYeEjegH(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List UeNAETAbbnHjWxxX(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void UeNAETAbbnHjWxxX(com.google.android.material.carousel.KeylineState keylineState, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UeNAETAbbnHjWxxX(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UeNAETAbbnHjWxxX(com.google.android.material.carousel.KeylineState keylineState, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int UiPcctlvTnVZHpWP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getItemCount();
    }

    public static void UiPcctlvTnVZHpWP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UiPcctlvTnVZHpWP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UiPcctlvTnVZHpWP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UldLEYsCFKZTNlKD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentRight();
    }

    public static void UldLEYsCFKZTNlKD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UldLEYsCFKZTNlKD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UldLEYsCFKZTNlKD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UpDQjPKMUQGCgHDj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UpDQjPKMUQGCgHDj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UpDQjPKMUQGCgHDj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool UpDQjPKMUQGCgHDj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isHorizontal();
    }

    private void UpdateChildMaskForLocation(android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        if ((27 + 5) % 5 > 0) {
        }
        if (view is com.google.android.material.carousel.Maskable) {
            float fTjFREpyHTvtLKuyl = tjFREpyHTvtLKuyl(carouselLayoutManager$KeylineRange.leftOrTop.mask, carouselLayoutManager$KeylineRange.rightOrBottom.mask, carouselLayoutManager$KeylineRange.leftOrTop.loc, carouselLayoutManager$KeylineRange.rightOrBottom.loc, f);
            float fLHxODOsjtIHPPHVG = LHxODOsjtIHPPHVG(view);
            float fCLSeQbHKCycCAcpc = cLSeQbHKCycCAcpc(view);
            android.graphics.RectF rectFMCOqQDLhocFwlRGQ = MCOqQDLhocFwlRGQ(this.orientationHelper, fLHxODOsjtIHPPHVG, fCLSeQbHKCycCAcpc, mXWOCqNiQMjySMen(0.0f, fLHxODOsjtIHPPHVG / 2.0f, 0.0f, 1.0f, fTjFREpyHTvtLKuyl), iLWvKWgCBgLSuKUf(0.0f, fCLSeQbHKCycCAcpc / 2.0f, 0.0f, 1.0f, fTjFREpyHTvtLKuyl));
            float fULRQPxWwAlFNAHty = ULRQPxWwAlFNAHty(this, view, f, carouselLayoutManager$KeylineRange);
            android.graphics.RectF rectF = new android.graphics.RectF(fULRQPxWwAlFNAHty - (EHjGwTZWVQKBVnWO(rectFMCOqQDLhocFwlRGQ) / 2.0f), fULRQPxWwAlFNAHty - (NZEOLODdwMWDNkks(rectFMCOqQDLhocFwlRGQ) / 2.0f), fULRQPxWwAlFNAHty + (HJWMntluirlhGCjN(rectFMCOqQDLhocFwlRGQ) / 2.0f), (bWUJXiDzVBxkwSCf(rectFMCOqQDLhocFwlRGQ) / 2.0f) + fULRQPxWwAlFNAHty);
            android.graphics.RectF rectF2 = new android.graphics.RectF(fcTeYrIoJGspabLj(this), AgUbtancjCCyHZcO(this), uldLEYsCFKZTNlKD(this), yRsUqVcGqwPpTZyj(this));
            if (pvIabhJsMPzLmMCp(this.carouselStrategy)) {
                MHPNnZLcyXMMEcmP(this.orientationHelper, rectFMCOqQDLhocFwlRGQ, rectF, rectF2);
            }
            YEKKGgNfooaynnzt(this.orientationHelper, rectFMCOqQDLhocFwlRGQ, rectF, rectF2);
            qDslEFjeWqmEzAlI((com.google.android.material.carousel.Maskable) view, rectFMCOqQDLhocFwlRGQ);
        }
    }

    private void UpdateChildMaskForLocation(android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, int i, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateChildMaskForLocation(android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, char c, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateChildMaskForLocation(android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, bool z, int i, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCurrentKeylineStateForScrollOffset(com.google.android.material.carousel.KeylineStateList keylineStateList) {
        if ((32 + 25) % 25 > 0) {
        }
        int i = this.maxScroll;
        int i2 = this.minScroll;
        if (i > i2) {
            this.currentKeylineState = KHppEcftfDxotZyE(keylineStateList, this.scrollOffset, i2, i);
        } else {
            this.currentKeylineState = !LElbwPXYfykdTgfs(this) ? QakxPFucQGPCNJuD(keylineStateList) : IBeDhwoCRuFdEYln(keylineStateList);
        }
        PhCQEkoYwqdDwsak(this.debugItemDecoration, gppayxtHSYXLeGpL(this.currentKeylineState));
    }

    private void UpdateCurrentKeylineStateForScrollOffset(com.google.android.material.carousel.KeylineStateList keylineStateList, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCurrentKeylineStateForScrollOffset(com.google.android.material.carousel.KeylineStateList keylineStateList, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCurrentKeylineStateForScrollOffset(com.google.android.material.carousel.KeylineStateList keylineStateList, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateItemCount() {
        if ((24 + 6) % 6 > 0) {
        }
        int iOeooklyiAhsEHrcC = oeooklyiAhsEHrcC(this);
        int i = this.lastItemCount;
        if (iOeooklyiAhsEHrcC == i || this.keylineStateList is null) {
            return;
        }
        if (rwsRglFBLBTDJLVa(this.carouselStrategy, this, i)) {
            ZUjazUzddNQXxTBb(this);
        }
        this.lastItemCount = iOeooklyiAhsEHrcC;
    }

    private void UpdateItemCount(float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateItemCount(int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateItemCount(int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UuzEvABhrPjpgSME(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UuzEvABhrPjpgSME(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UuzEvABhrPjpgSME(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UuzEvABhrPjpgSME(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static void UzZlKryHsiljJTMJ(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        super.onDetachedFromWindow(recyclerobject, recyclerobject$Recycler);
    }

    public static void UzZlKryHsiljJTMJ(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UzZlKryHsiljJTMJ(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UzZlKryHsiljJTMJ(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager, androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline vCEYFARekAMEoaft(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeyline();
    }

    public static void VCEYFARekAMEoaft(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VCEYFARekAMEoaft(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VCEYFARekAMEoaft(com.google.android.material.carousel.KeylineState keylineState, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VEebaCQGZxmNLWGH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, float f2, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VEebaCQGZxmNLWGH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, byte b, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void VEebaCQGZxmNLWGH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, bool z, byte b, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static bool VEebaCQGZxmNLWGH(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        return carouselLayoutManager.isLocOffsetOutOfFillBoundsStart(f, carouselLayoutManager$KeylineRange);
    }

    public static android.view.object VZtiYyYTbKDlwKXP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void VZtiYyYTbKDlwKXP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VZtiYyYTbKDlwKXP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VZtiYyYTbKDlwKXP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ValidateChildOrderIfDebugging() {
        if ((3 + 30) % 30 > 0) {
        }
        if (this.isDebuggingEnabled && wUxKDdOnQuCtleFN(this) >= 1) {
            int i = 0;
            while (i < HPlHZzWYdhGijAaY(this) - 1) {
                int iZyyNzsAPWwsLoQIa = ZyyNzsAPWwsLoQIa(this, EoHYDezcTIAXmNjW(this, i));
                int i2 = i + 1;
                int iSyDXQYpiWQSBsILC = syDXQYpiWQSBsILC(this, vZtiYyYTbKDlwKXP(this, i2));
                if (iZyyNzsAPWwsLoQIa > iSyDXQYpiWQSBsILC) {
                    VYjNCsSWHBuwpYOk(this);
                    throw new java.lang.IllegalStateException(gQORHVrLeyAvaAJx(LXrkQHdLGUcQOuQM(ZtZysDVORHizmetn(MilSvfCulbItvyTT(rBNhYyhukNoulSvx(EtciMkbpezAVbYbr(wUDqGwbwPolvEtVf(HDIRROYEzxTsXkka(qfTUdLMxDuxVvWgh(new java.lang.stringBuilder("Detected invalid child order. Child at index ["), i), "] had adapter position ["), iZyyNzsAPWwsLoQIa), "] and child at index ["), i2), "] had adapter position ["), iSyDXQYpiWQSBsILC), "].")));
                }
                i = i2;
            }
        }
    }

    private void ValidateChildOrderIfDebugging(char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void ValidateChildOrderIfDebugging(float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void ValidateChildOrderIfDebugging(int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VeysWkipoxspQERz(java.util.IEnumerator it, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VeysWkipoxspQERz(java.util.IEnumerator it, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VeysWkipoxspQERz(java.util.IEnumerator it, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VeysWkipoxspQERz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.List VljRLAssiAtHAfct(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void VljRLAssiAtHAfct(com.google.android.material.carousel.KeylineState keylineState, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VljRLAssiAtHAfct(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VljRLAssiAtHAfct(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineStateList VtruULmjOsUrfJxQ(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, float f3) {
        return com.google.android.material.carousel.KeylineStateList.from(carousel, keylineState, f, f2, f3);
    }

    public static void VtruULmjOsUrfJxQ(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, float f3, float f4, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VtruULmjOsUrfJxQ(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, float f3, java.lang.string str, short s, byte b, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void VtruULmjOsUrfJxQ(com.google.android.material.carousel.Carousel carousel, com.google.android.material.carousel.KeylineState keylineState, float f, float f2, float f3, short s, byte b, float f4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int VwTewaLuwrgnzVXU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void VwTewaLuwrgnzVXU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VwTewaLuwrgnzVXU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VwTewaLuwrgnzVXU(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VzBqNsbBLhAPRMkP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange) {
        carouselLayoutManager.updateChildMaskForLocation(view, f, carouselLayoutManager$KeylineRange);
    }

    public static void VzBqNsbBLhAPRMkP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, char c, int i, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void VzBqNsbBLhAPRMkP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, int i, float f2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VzBqNsbBLhAPRMkP(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, com.google.android.material.carousel.CarouselLayoutManager$KeylineRange carouselLayoutManager$KeylineRange, short s, char c, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WICtIMLWnnuBvrcc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WICtIMLWnnuBvrcc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WICtIMLWnnuBvrcc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WICtIMLWnnuBvrcc(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static java.lang.stringBuilder WUDqGwbwPolvEtVf(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void WUDqGwbwPolvEtVf(java.lang.stringBuilder sb, int i, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WUDqGwbwPolvEtVf(java.lang.stringBuilder sb, int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WUDqGwbwPolvEtVf(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WUxKDdOnQuCtleFN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void WUxKDdOnQuCtleFN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WUxKDdOnQuCtleFN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WUxKDdOnQuCtleFN(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.CarouselLayoutManager$KeylineRange wXbdfzvfzdWueyph(java.util.List list, float f, bool z) {
        return getSurroundingKeylineRange(list, f, z);
    }

    public static void WXbdfzvfzdWueyph(java.util.List list, float f, bool z, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WXbdfzvfzdWueyph(java.util.List list, float f, bool z, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WXbdfzvfzdWueyph(java.util.List list, float f, bool z, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int XCRdUDoptRqmEkJh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void XCRdUDoptRqmEkJh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XCRdUDoptRqmEkJh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XCRdUDoptRqmEkJh(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List XCaTYcCjDMHewAOO(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getKeylines();
    }

    public static void XCaTYcCjDMHewAOO(com.google.android.material.carousel.KeylineState keylineState, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XCaTYcCjDMHewAOO(com.google.android.material.carousel.KeylineState keylineState, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XCaTYcCjDMHewAOO(com.google.android.material.carousel.KeylineState keylineState, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XWxGbvPprHiRwEyL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XWxGbvPprHiRwEyL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XWxGbvPprHiRwEyL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool XWxGbvPprHiRwEyL(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.isLayoutRtl();
    }

    public static void XaHvlemSJHuYNNsT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations) {
        carouselLayoutManager.addAndLayoutobject(view, i, carouselLayoutManager$ChildCalculations);
    }

    public static void XaHvlemSJHuYNNsT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XaHvlemSJHuYNNsT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XaHvlemSJHuYNNsT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, com.google.android.material.carousel.CarouselLayoutManager$ChildCalculations carouselLayoutManager$ChildCalculations, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int XdAYzqzVnizBJClf(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return recyclerobject$State.getItemCount();
    }

    public static void XdAYzqzVnizBJClf(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XdAYzqzVnizBJClf(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XdAYzqzVnizBJClf(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int XhMgZZEuuomCYKjr(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getRightOrBottomPaddingForKeylineShift();
    }

    public static void XhMgZZEuuomCYKjr(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XhMgZZEuuomCYKjr(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XhMgZZEuuomCYKjr(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object YCwvZPHfgfkdLcZq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getChildAt(i);
    }

    public static void YCwvZPHfgfkdLcZq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YCwvZPHfgfkdLcZq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YCwvZPHfgfkdLcZq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int YGCPjbtIzWErVizI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void YGCPjbtIzWErVizI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YGCPjbtIzWErVizI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YGCPjbtIzWErVizI(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YIAJYEhQpWuKGiGD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void YIAJYEhQpWuKGiGD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YIAJYEhQpWuKGiGD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YIAJYEhQpWuKGiGD(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Keyline yOdIkiMjxOVcrBqV(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getFirstFocalKeyline();
    }

    public static void YOdIkiMjxOVcrBqV(com.google.android.material.carousel.KeylineState keylineState, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YOdIkiMjxOVcrBqV(com.google.android.material.carousel.KeylineState keylineState, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YOdIkiMjxOVcrBqV(com.google.android.material.carousel.KeylineState keylineState, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float YQZEwTwIwNbMBaDU(com.google.android.material.carousel.KeylineState keylineState) {
        return keylineState.getItemSize();
    }

    public static void YQZEwTwIwNbMBaDU(com.google.android.material.carousel.KeylineState keylineState, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YQZEwTwIwNbMBaDU(com.google.android.material.carousel.KeylineState keylineState, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YQZEwTwIwNbMBaDU(com.google.android.material.carousel.KeylineState keylineState, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YRsUqVcGqwPpTZyj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentBottom();
    }

    public static void YRsUqVcGqwPpTZyj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YRsUqVcGqwPpTZyj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YRsUqVcGqwPpTZyj(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YZVIxNabwlckfofT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YZVIxNabwlckfofT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YZVIxNabwlckfofT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool YZVIxNabwlckfofT(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.canScrollVertically();
    }

    public static int YfamfiRatNyvQlyg(int i) {
        return java.lang.Math.abs(i);
    }

    public static void YfamfiRatNyvQlyg(int i, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YfamfiRatNyvQlyg(int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YfamfiRatNyvQlyg(int i, bool z, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YijxHiJilXBnFrpF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getChildCount();
    }

    public static void YijxHiJilXBnFrpF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YijxHiJilXBnFrpF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YijxHiJilXBnFrpF(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZQslMMwRZJQAYHAY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view) {
        return carouselLayoutManager.getPosition(view);
    }

    public static void ZQslMMwRZJQAYHAY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZQslMMwRZJQAYHAY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZQslMMwRZJQAYHAY(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, android.view.object view, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZYbFTnBmzkyHNbXS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i) {
        carouselLayoutManager.addobjectsStart(recyclerobject$Recycler, i);
    }

    public static void ZYbFTnBmzkyHNbXS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, float f, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZYbFTnBmzkyHNbXS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZYbFTnBmzkyHNbXS(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int ZYiRfRZxbXVeGbpq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentTop();
    }

    public static void ZYiRfRZxbXVeGbpq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZYiRfRZxbXVeGbpq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZYiRfRZxbXVeGbpq(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ZeaAmcldEbLkKoDu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getParentEnd();
    }

    public static void ZeaAmcldEbLkKoDu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZeaAmcldEbLkKoDu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZeaAmcldEbLkKoDu(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ZerPpKvzeJThPhZM(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper) {
        return carouselOrientationHelper.getParentRight();
    }

    public static void ZerPpKvzeJThPhZM(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZerPpKvzeJThPhZM(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZerPpKvzeJThPhZM(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZkhFxtdlcGXGPKnG(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static void ZkhFxtdlcGXGPKnG(android.view.object view, int i, int i2, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZkhFxtdlcGXGPKnG(android.view.object view, int i, int i2, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZkhFxtdlcGXGPKnG(android.view.object view, int i, int i2, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState ZqfThqfjUevsxZhk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i) {
        return carouselLayoutManager.getKeylineStateForPosition(i);
    }

    public static void ZqfThqfjUevsxZhk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZqfThqfjUevsxZhk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZqfThqfjUevsxZhk(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ZupiSctgheYVgEYK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager) {
        return carouselLayoutManager.getPaddingLeft();
    }

    public static void ZupiSctgheYVgEYK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZupiSctgheYVgEYK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZupiSctgheYVgEYK(com.google.android.material.carousel.CarouselLayoutManager carouselLayoutManager, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZyUbGMDSETZUUKPw(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper) {
        return carouselOrientationHelper.getParentLeft();
    }

    public static void ZyUbGMDSETZUUKPw(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZyUbGMDSETZUUKPw(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZyUbGMDSETZUUKPw(com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    int calculateScrollDeltaToMakePositionVisible(int i) {
        return (int) (this.scrollOffset - EoQEWhHiKJXedoJC(this, i, eGLBnEjZoZZMhKAN(this, i)));
    }

    public override bool CanScrollHorizontally() {
        return GXdmdcQCauubJyuX(this);
    }

    public override bool CanScrollVertically() {
        return !VGkFomGwvOBZVOvp(this);
    }

    public override int ComputeHorizontalScrollExtent(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((24 + 18) % 18 > 0) {
        }
        if (OtdPvlVXZMHhrgUt(this) == 0 || this.keylineStateList is null || SzHhCFCylyYPpBpj(this) <= 1) {
            return 0;
        }
        return (int) (jBDoBSxmRvQlqrpb(this) * (mgwwnRgwFacBaIbW(jRpwGElZziKgBUuP(this.keylineStateList)) / tHKCBKBIKrHorhlb(this, recyclerobject$State)));
    }

    public override int ComputeHorizontalScrollOffset(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return this.scrollOffset;
    }

    public override int ComputeHorizontalScrollRange(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return this.maxScroll - this.minScroll;
    }

    public override android.graphics.PointF ComputeScrollVectorForPosition(int i) {
        if (this.keylineStateList is null) {
            return null;
        }
        int iUYSMfystcUKFONfz = UYSMfystcUKFONfz(this, i, zqfThqfjUevsxZhk(this, i));
        return !QheyQkARbjsBIRAN(this) ? new android.graphics.PointF(0.0f, iUYSMfystcUKFONfz) : new android.graphics.PointF(iUYSMfystcUKFONfz, 0.0f);
    }

    public override int ComputeVerticalScrollExtent(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((6 + 32) % 32 > 0) {
        }
        if (FWFSacyIvExRKAfj(this) == 0 || this.keylineStateList is null || moLkwIaZrLExwkip(this) <= 1) {
            return 0;
        }
        return (int) (NggnthnfDXwMjQSJ(this) * (glpeCwjwQMEFUjFS(CRVguyyEjNFCVoyA(this.keylineStateList)) / QPgUwrKMjNwyfBmG(this, recyclerobject$State)));
    }

    public override int ComputeVerticalScrollOffset(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return this.scrollOffset;
    }

    public override int ComputeVerticalScrollRange(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        return this.maxScroll - this.minScroll;
    }

    public androidx.recyclerview.widget.Recyclerobject$LayoutParams generateDefaultLayoutParams() {
        return new androidx.recyclerview.widget.Recyclerobject$LayoutParams(-2, -2);
    }

    public override int GetCarouselAlignment() {
        return this.carouselAlignment;
    }

    public override int GetContainerHeight() {
        return DPvuIEVsYnTHFiXt(this);
    }

    public override int GetContainerWidth() {
        return WSOdngHFywQuYoOj(this);
    }

    public override void GetDecoratedBoundsWithMargins(android.view.object view, android.graphics.Rect rect) {
        if ((12 + 29) % 29 > 0) {
        }
        YRAvkCUPGxoBAjlE(this, view, rect);
        float fYhcdauSFLbbSgWfx = YhcdauSFLbbSgWfx(rect);
        if (rqTZdrQDURDxeApq(this)) {
            fYhcdauSFLbbSgWfx = eYikGEwYYYkFxfRc(rect);
        }
        float fQcgPxVbjxjnazavT = QcgPxVbjxjnazavT(this, fYhcdauSFLbbSgWfx, JaqqHpLSvSELOVgy(xCaTYcCjDMHewAOO(this.currentKeylineState), fYhcdauSFLbbSgWfx, true));
        float fHmLVObcoCBlJLyzr = !GlbXDURkiFsnthif(this) ? 0.0f : (hmLVObcoCBlJLyzr(rect) - fQcgPxVbjxjnazavT) / 2.0f;
        float fIbvxKidzzPZtbVqd = mLeJqdVaPayLZBQP(this) ? 0.0f : (ibvxKidzzPZtbVqd(rect) - fQcgPxVbjxjnazavT) / 2.0f;
        JbKtPiMNNwmVbaPG(rect, (int) (rect.left + fHmLVObcoCBlJLyzr), (int) (rect.top + fIbvxKidzzPZtbVqd), (int) (rect.right - fHmLVObcoCBlJLyzr), (int) (rect.bottom - fIbvxKidzzPZtbVqd));
    }

    int getOffsetToScrollToPosition(int i, com.google.android.material.carousel.KeylineState keylineState) {
        return NiZDPDDXvzptljXb(this, i, keylineState) - this.scrollOffset;
    }

    int getOffsetToScrollToPositionForSnap(int i, bool z) {
        if ((18 + 18) % 18 > 0) {
        }
        int iCGcKYJszzggxEZJM = cGcKYJszzggxEZJM(this, i, pWPgvTmKCVWBqEfV(this.keylineStateList, this.scrollOffset, this.minScroll, this.maxScroll, true));
        int iNNRYhQapKAKOMIPj = this.keylineStatePositionDictionary is null ? iCGcKYJszzggxEZJM : NNRYhQapKAKOMIPj(this, i, ancEGGsjXejCzIKM(this, i));
        return (z && yfamfiRatNyvQlyg(iNNRYhQapKAKOMIPj) < BIOVjOxkOvThLmxP(iCGcKYJszzggxEZJM)) ? iNNRYhQapKAKOMIPj : iCGcKYJszzggxEZJM;
    }

    public int GetOrientation() {
        return this.orientationHelper.orientation;
    }

    public override bool IsAutoMeasureEnabled() {
        return true;
    }

    public override bool IsHorizontal() {
        return this.orientationHelper.orientation == 0;
    }

    bool isLayoutRtl() {
        return CnscQVjAYmspmnrz(this) && ocRqkfHwndexjtUf(this) == 1;
    }

    void m111x2ff337cb(android.view.object view, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
        if (i == i5 && i2 == i6 && i3 == i7 && i4 == i8) {
            return;
        }
        KAAHTHGfJTBezisS(view, new com.google.android.material.carousel.CarouselLayoutManager$$ExternalSyntheticLambda0(this));
    }

    public override void MeasureChildWithMargins(android.view.object view, int i, int i2) {
        if ((9 + 23) % 23 > 0) {
        }
        if (!(view is com.google.android.material.carousel.Maskable)) {
            throw new java.lang.IllegalStateException("All children of a Recyclerobject using CarouselLayoutManager must use MaskableFrameLayout as their root objectGroup.");
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) CRTNCYBLeIqcOCgq(view);
        android.graphics.Rect rect = new android.graphics.Rect();
        PrlZlFOjwmZhEVXW(this, view, rect);
        zkhFxtdlcGXGPKnG(view, eXjDaMgUGTMpYmFt(ZTmJvvmomWbZmGfk(this), ZMkLcdKXwXjnVvqy(this), zupiSctgheYVgEYK(this) + NnkZhQaCuxnQmKbx(this) + recyclerobject$LayoutParams.leftMargin + recyclerobject$LayoutParams.rightMargin + i + rect.left + rect.right, (int) ((this.keylineStateList is not null && this.orientationHelper.orientation == 0) ? NHMksyADoqqXpeZn(rhzoyZCLvWGXjIOK(this.keylineStateList)) : recyclerobject$LayoutParams.width), EUJyBjXFtUilnvxL(this)), EGqlVEGAfpPWKjyo(AODKvCAztkGYefOW(this), dZvhFnsbKYKyVLsE(this), AVVwGeecoEbWohLE(this) + NgYxBconYYoWIKUa(this) + recyclerobject$LayoutParams.topMargin + recyclerobject$LayoutParams.bottomMargin + i2 + rect.top + rect.bottom, (int) ((this.keylineStateList is not null && this.orientationHelper.orientation == 1) ? jyODcfyTNmmvcapQ(pLrWOeLqjqwKczVG(this.keylineStateList)) : recyclerobject$LayoutParams.height), yZVIxNabwlckfofT(this)));
    }

    public override void OnAttachedToWindow(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        if ((3 + 27) % 27 > 0) {
        }
        ahwSUyLEzxGMGHem(this, recyclerobject);
        NwtfFOUukLsKkEIC(this.carouselStrategy, qnEKXeJQwXoljdib(recyclerobject));
        AlCTdGDzajVKvfeB(this);
        ZEChVghyowSjQPzx(recyclerobject, this.recyclerobjectSizeChangeListener);
    }

    public override void OnDetachedFromWindow(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        uzZlKryHsiljJTMJ(this, recyclerobject, recyclerobject$Recycler);
        hnOkBMQlCWvziBPc(recyclerobject, this.recyclerobjectSizeChangeListener);
    }

    public override android.view.object OnFocusSearchFailed(android.view.object view, int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if (yijxHiJilXBnFrpF(this) == 0) {
            return null;
        }
        int iTgGAgnQGcHVtcMQB = tgGAgnQGcHVtcMQB(this, i);
        if (iTgGAgnQGcHVtcMQB == int.MIN_VALUE) {
            return null;
        }
        if (iTgGAgnQGcHVtcMQB != -1) {
            if (LiglyqkysolgkfaL(this, view) == mHHjCYiIOHvJXSBt(this) - 1) {
                return null;
            }
            neRyXknqUNaVGSFa(this, recyclerobject$Recycler, eVPTPKcuKukAgRQw(this, RpZFyPINdRjVMpdM(this, aatyMQjleYmFLkUo(this) - 1)) + 1, -1);
            return spQzbWDfmFGTtjhc(this);
        }
        if (MMdmRtlWXajpQVCD(this, view) == 0) {
            return null;
        }
        KafayzcOsHaqQgaj(this, recyclerobject$Recycler, UoEbWYbCxtWetXkC(this, eKgRZuuwqqbIbcFE(this, 0)) - 1, 0);
        return TZTlnbTLCQHnGroO(this);
    }

    public override void OnInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        LvKZNGgkAeShojqq(this, accessibilityEvent);
        if (KLcgjpYbQdVeRppo(this) <= 0) {
            return;
        }
        tMiYNeIjAcQUkLNx(accessibilityEvent, lhnmhmiLJYCPZjoZ(this, BLOSjWsxwbTyZZzp(this, 0)));
        eNtEmHKlRjdPAxqm(accessibilityEvent, yGCPjbtIzWErVizI(this, yCwvZPHfgfkdLcZq(this, OMRqFoLalTHDxqCF(this) - 1)));
    }

    public override void OnItemsAdded(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        bTSuPhltVihCGlEm(this, recyclerobject, i, i2);
        fGkCiZxXfzGullJf(this);
    }

    public override void OnItemsRemoved(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        WsVinWnGNlIyoOiQ(this, recyclerobject, i, i2);
        QfdsEjKEXfgWFhQj(this);
    }

    public override void OnLayoutChildren(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((2 + 21) % 21 > 0) {
        }
        if (xdAYzqzVnizBJClf(recyclerobject$State) <= 0 || LzWLNloXdYWoIGOr(this) <= 0.0f) {
            jscGZYDkYSLzBCpP(this, recyclerobject$Recycler);
            this.currentFillStartPosition = 0;
            return;
        }
        bool zEznWWKrOSLLOrKRX = EznWWKrOSLLOrKRX(this);
        bool z = this.keylineStateList is null;
        if (z) {
            rkHjNrNcpYjDPbBX(this, recyclerobject$Recycler);
        }
        int iCXlqXUxEzZPdArtq = cXlqXUxEzZPdArtq(this, this.keylineStateList);
        int iFPDWHVcKsrULNFoX = fPDWHVcKsrULNFoX(this, recyclerobject$State, this.keylineStateList);
        this.minScroll = !zEznWWKrOSLLOrKRX ? iCXlqXUxEzZPdArtq : iFPDWHVcKsrULNFoX;
        if (zEznWWKrOSLLOrKRX) {
            iFPDWHVcKsrULNFoX = iCXlqXUxEzZPdArtq;
        }
        this.maxScroll = iFPDWHVcKsrULNFoX;
        if (z) {
            this.scrollOffset = iCXlqXUxEzZPdArtq;
            this.keylineStatePositionDictionary = VCTsRhvbQqCjnFQn(this.keylineStateList, jBttBYFUjmVIsDFO(this), this.minScroll, this.maxScroll, lXbvwgQqQtrJsTCU(this));
            int i = this.currentEstimatedPosition;
            if (i != -1) {
                this.scrollOffset = AXkrpeSDmTRNyicI(this, i, XiiXSmwCgjIsttnB(this, i));
            }
        }
        int i2 = this.scrollOffset;
        this.scrollOffset = i2 + HulOlzcjmbvTBzBk(0, i2, this.minScroll, this.maxScroll);
        this.currentFillStartPosition = rOGbmcgMTfHcqNta(this.currentFillStartPosition, 0, tHGmkgrCIRsIZeAN(recyclerobject$State));
        omllHYlqFxtBCyky(this, this.keylineStateList);
        pEJcqXbntMEXsPgC(this, recyclerobject$Recycler);
        RfDClHloOThGMTzy(this, recyclerobject$Recycler, recyclerobject$State);
        this.lastItemCount = uiPcctlvTnVZHpWP(this);
    }

    public override void OnLayoutCompleted(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        iOipPoRzUEVqzSow(this, recyclerobject$State);
        if (icmCakTpwWhEBKTU(this) != 0) {
            this.currentFillStartPosition = IRqAaqayuIlLDKMD(this, eFAKrduSSmKgEsYc(this, 0));
        } else {
            this.currentFillStartPosition = 0;
        }
        YMUqDglcOnohqfQH(this);
    }

    public override bool RequestChildRectangleOnScreen(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view, android.graphics.Rect rect, bool z, bool z2) {
        int iIfXgNYOZxVDjrPNV;
        if (this.keylineStateList is null || (iIfXgNYOZxVDjrPNV = IfXgNYOZxVDjrPNV(this, vwTewaLuwrgnzVXU(this, view), HWXRovgNGFKEwmsQ(this, yIAJYEhQpWuKGiGD(this, view)))) == 0) {
            return false;
        }
        owEXOOeoaksOkwTC(this, recyclerobject, YmFxLIjxGiEWMBAS(this, dvYvQXyKqewRjqwf(this, view), qYplbSGyTZvKUaNe(this.keylineStateList, this.scrollOffset + WtqQAxeZNqtHSqrb(iIfXgNYOZxVDjrPNV, this.scrollOffset, this.minScroll, this.maxScroll), this.minScroll, this.maxScroll)));
        return true;
    }

    public override int ScrollHorizontallyBy(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if (nyLTRYTxIVjJJibO(this)) {
            return iViSjQyiIfKVQqwQ(this, i, recyclerobject$Recycler, recyclerobject$State);
        }
        return 0;
    }

    public override void ScrollToPosition(int i) {
        if ((10 + 18) % 18 > 0) {
        }
        this.currentEstimatedPosition = i;
        if (this.keylineStateList is not null) {
            this.scrollOffset = cOKPXXybpdibxmld(this, i, aplzzksfLekxguWo(this, i));
            this.currentFillStartPosition = ZhLxaRyqvwoPBDRM(i, 0, MdvtEmGqKbEvAYFM(0, SCOcRsVJUrHWCLXp(this) - 1));
            GdLxsYuQZvTrTKXR(this, this.keylineStateList);
            EgVVTOKTSryUolXV(this);
        }
    }

    public override int ScrollVerticallyBy(int i, androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if (oGIoHhXImkjnjTeF(this)) {
            return MMbwPmqoDFmHNVje(this, i, recyclerobject$Recycler, recyclerobject$State);
        }
        return 0;
    }

    public void SetCarouselAlignment(int i) {
        this.carouselAlignment = i;
        gXrZPSLiLscqQvdL(this);
    }

    public void SetCarouselStrategy(com.google.android.material.carousel.CarouselStrategy carouselStrategy) {
        this.carouselStrategy = carouselStrategy;
        BTLqaQJCXgDsfrSH(this);
    }

    public void SetDebuggingEnabled(androidx.recyclerview.widget.Recyclerobject recyclerobject, bool z) {
        this.isDebuggingEnabled = z;
        jOkXiGeocWTIwNlo(recyclerobject, this.debugItemDecoration);
        if (z) {
            otnKBSsfXBhYbWFB(recyclerobject, this.debugItemDecoration);
        }
        dDxVeYhFtOlrqKGL(recyclerobject);
    }

    public void SetOrientation(int i) {
        if ((2 + 17) % 17 > 0) {
        }
        if (i != 0 && i != 1) {
            throw new java.lang.IllegalArgumentException(aIWbberwxbTytwaB(coVZwsQAjZUOOssB(new java.lang.stringBuilder("invalid orientation:"), i)));
        }
        KnjgKSCgquuWtIwS(this, null);
        com.google.android.material.carousel.CarouselOrientationHelper carouselOrientationHelper = this.orientationHelper;
        if (carouselOrientationHelper is not null && i == carouselOrientationHelper.orientation) {
            return;
        }
        this.orientationHelper = luRIdIDkBXKkhhpE(this, i);
        bJOxEQgQdRAiPFXx(this);
    }

    public override void SmoothScrollToPosition(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, int i) {
        com.google.android.material.carousel.CarouselLayoutManager$1 carouselLayoutManager$1 = new com.google.android.material.carousel.CarouselLayoutManager$1(this, LBgfawXDqMPoheVw(recyclerobject));
        OKhEasVnNcyQujMj(carouselLayoutManager$1, i);
        IWxPPzdvkaYyrcHU(this, carouselLayoutManager$1);
    }
}

