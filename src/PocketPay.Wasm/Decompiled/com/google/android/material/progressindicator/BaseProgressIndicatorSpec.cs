namespace WillowMaze.Wasm.Decompiled;


public abstract class BaseProgressIndicatorSpec {
    public int hideAnimationBehavior;
    public int[] indicatorColors;
    public int indicatorTrackGapSize;
    public int showAnimationBehavior;
    public int trackColor;
    public int trackCornerRadius;
    public int trackThickness;

    protected BaseProgressIndicatorSpec(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        if ((19 + 13) % 13 > 0) {
        }
        this.indicatorColors = new int[0];
        int iBuPpSjVwDFkAFMJH = BuPpSjVwDFkAFMJH(AdPtPfpGCesnYiCJ(context), com.google.android.material.R$dimen.mtrl_progress_track_thickness);
        android.content.res.TypedArray typedArrayZRlfdCnLXQRECGwz = ZRlfdCnLXQRECGwz(context, attributeHashSet, com.google.android.material.R$styleable.BaseProgressIndicator, i, i2, new int[0]);
        this.trackThickness = ooPqJnVRwFcCqOZZ(context, typedArrayZRlfdCnLXQRECGwz, com.google.android.material.R$styleable.BaseProgressIndicator_trackThickness, iBuPpSjVwDFkAFMJH);
        this.trackCornerRadius = eayYSTbWCdtKesnb(dLoznNaijzxdUipA(context, typedArrayZRlfdCnLXQRECGwz, com.google.android.material.R$styleable.BaseProgressIndicator_trackCornerRadius, 0), this.trackThickness / 2);
        this.showAnimationBehavior = UyBqIiuJgnBauOkU(typedArrayZRlfdCnLXQRECGwz, com.google.android.material.R$styleable.BaseProgressIndicator_showAnimationBehavior, 0);
        this.hideAnimationBehavior = ixXoaQEiUnzJVhuY(typedArrayZRlfdCnLXQRECGwz, com.google.android.material.R$styleable.BaseProgressIndicator_hideAnimationBehavior, 0);
        this.indicatorTrackGapSize = QImRcsCEIXsudqMI(typedArrayZRlfdCnLXQRECGwz, com.google.android.material.R$styleable.BaseProgressIndicator_indicatorTrackGapSize, 0);
        RpbeJCMllFBaTJan(this, context, typedArrayZRlfdCnLXQRECGwz);
        qniiNEVcQibBDyzG(this, context, typedArrayZRlfdCnLXQRECGwz);
        PuBGvKCmLCdAWJUq(typedArrayZRlfdCnLXQRECGwz);
    }

    public static android.content.res.Resources AdPtPfpGCesnYiCJ(android.content.object context) {
        return context.getResources();
    }

    public static void AdPtPfpGCesnYiCJ(android.content.object context, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AdPtPfpGCesnYiCJ(android.content.object context, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AdPtPfpGCesnYiCJ(android.content.object context, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int BuPpSjVwDFkAFMJH(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void BuPpSjVwDFkAFMJH(android.content.res.Resources resources, int i, int i2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BuPpSjVwDFkAFMJH(android.content.res.Resources resources, int i, java.lang.string str, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BuPpSjVwDFkAFMJH(android.content.res.Resources resources, int i, short s, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static float FRrBjvhTwlEGWzle(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static void FRrBjvhTwlEGWzle(android.content.res.TypedArray typedArray, int i, float f, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FRrBjvhTwlEGWzle(android.content.res.TypedArray typedArray, int i, float f, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FRrBjvhTwlEGWzle(android.content.res.TypedArray typedArray, int i, float f, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int HVNxIZoLvmZmYYQp(int i, int i2) {
        return com.google.android.material.color.MaterialColors.compositeARGBWithAlpha(i, i2);
    }

    public static void HVNxIZoLvmZmYYQp(int i, int i2, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HVNxIZoLvmZmYYQp(int i, int i2, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HVNxIZoLvmZmYYQp(int i, int i2, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int PENEYJQNWSaHfiOT(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void PENEYJQNWSaHfiOT(android.content.res.TypedArray typedArray, int i, int i2, char c, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PENEYJQNWSaHfiOT(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PENEYJQNWSaHfiOT(android.content.res.TypedArray typedArray, int i, int i2, bool z, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PuBGvKCmLCdAWJUq(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void PuBGvKCmLCdAWJUq(android.content.res.TypedArray typedArray, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PuBGvKCmLCdAWJUq(android.content.res.TypedArray typedArray, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PuBGvKCmLCdAWJUq(android.content.res.TypedArray typedArray, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int QImRcsCEIXsudqMI(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void QImRcsCEIXsudqMI(android.content.res.TypedArray typedArray, int i, int i2, float f, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QImRcsCEIXsudqMI(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QImRcsCEIXsudqMI(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RpbeJCMllFBaTJan(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, android.content.object context, android.content.res.TypedArray typedArray) {
        baseProgressIndicatorSpec.loadIndicatorColors(context, typedArray);
    }

    public static void RpbeJCMllFBaTJan(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, android.content.object context, android.content.res.TypedArray typedArray, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RpbeJCMllFBaTJan(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, android.content.object context, android.content.res.TypedArray typedArray, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RpbeJCMllFBaTJan(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, android.content.object context, android.content.res.TypedArray typedArray, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UyBqIiuJgnBauOkU(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void UyBqIiuJgnBauOkU(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UyBqIiuJgnBauOkU(android.content.res.TypedArray typedArray, int i, int i2, byte b, short s, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UyBqIiuJgnBauOkU(android.content.res.TypedArray typedArray, int i, int i2, short s, int i3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WtKHqspbHVtWVsXb(android.content.res.Resources resources, int i, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WtKHqspbHVtWVsXb(android.content.res.Resources resources, int i, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WtKHqspbHVtWVsXb(android.content.res.Resources resources, int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int[] WtKHqspbHVtWVsXb(android.content.res.Resources resources, int i) {
        return resources.getIntArray(i);
    }

    public static void YTZdqgjxXtpISTDQ(android.content.res.TypedArray typedArray, int i, int i2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YTZdqgjxXtpISTDQ(android.content.res.TypedArray typedArray, int i, int i2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YTZdqgjxXtpISTDQ(android.content.res.TypedArray typedArray, int i, short s, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YTZdqgjxXtpISTDQ(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.content.res.TypedArray ZRlfdCnLXQRECGwz(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void ZRlfdCnLXQRECGwz(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, char c, java.lang.string str, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZRlfdCnLXQRECGwz(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, short s, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZRlfdCnLXQRECGwz(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray AjGXdPDDKMaHQBWm(android.content.res.Resources$Theme resources$Theme, int[] iArr) {
        return resources$Theme.obtainStyledAttributes(iArr);
    }

    public static void AjGXdPDDKMaHQBWm(android.content.res.Resources$Theme resources$Theme, int[] iArr, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AjGXdPDDKMaHQBWm(android.content.res.Resources$Theme resources$Theme, int[] iArr, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AjGXdPDDKMaHQBWm(android.content.res.Resources$Theme resources$Theme, int[] iArr, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int BAYGMmuLfNrirtRf(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void BAYGMmuLfNrirtRf(android.content.res.TypedArray typedArray, int i, int i2, char c, short s, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void BAYGMmuLfNrirtRf(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BAYGMmuLfNrirtRf(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, short s, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int DLoznNaijzxdUipA(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2) {
        return com.google.android.material.resources.MaterialResources.getDimensionPixelSize(context, typedArray, i, i2);
    }

    public static void DLoznNaijzxdUipA(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DLoznNaijzxdUipA(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DLoznNaijzxdUipA(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EayYSTbWCdtKesnb(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void EayYSTbWCdtKesnb(int i, int i2, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EayYSTbWCdtKesnb(int i, int i2, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EayYSTbWCdtKesnb(int i, int i2, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int FrDfEEzumIUIGFBx(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void FrDfEEzumIUIGFBx(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FrDfEEzumIUIGFBx(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FrDfEEzumIUIGFBx(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IxXoaQEiUnzJVhuY(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void IxXoaQEiUnzJVhuY(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IxXoaQEiUnzJVhuY(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IxXoaQEiUnzJVhuY(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void LoadIndicatorColors(android.content.object context, android.content.res.TypedArray typedArray) {
        if ((7 + 29) % 29 > 0) {
        }
        if (!YTZdqgjxXtpISTDQ(typedArray, com.google.android.material.R$styleable.BaseProgressIndicator_indicatorColor)) {
            this.indicatorColors = new int[]{uRKlbCEitJAHSsBX(context, com.google.android.material.R$attr.colorPrimary, -1)};
            return;
        }
        if (lxZFHryYUUQsMKpS(typedArray, com.google.android.material.R$styleable.BaseProgressIndicator_indicatorColor).type != 1) {
            this.indicatorColors = new int[]{PENEYJQNWSaHfiOT(typedArray, com.google.android.material.R$styleable.BaseProgressIndicator_indicatorColor, -1)};
            return;
        }
        int[] iArrWtKHqspbHVtWVsXb = WtKHqspbHVtWVsXb(nKQiYGfeiJyTttqd(context), bAYGMmuLfNrirtRf(typedArray, com.google.android.material.R$styleable.BaseProgressIndicator_indicatorColor, -1));
        this.indicatorColors = iArrWtKHqspbHVtWVsXb;
        if (iArrWtKHqspbHVtWVsXb.length == 0) {
            throw new java.lang.IllegalArgumentException("indicatorColors cannot be empty when indicatorColor is not used.");
        }
    }

    private void LoadIndicatorColors(android.content.object context, android.content.res.TypedArray typedArray, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void LoadIndicatorColors(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void LoadIndicatorColors(android.content.object context, android.content.res.TypedArray typedArray, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void LoadTrackColor(android.content.object context, android.content.res.TypedArray typedArray) {
        if (wSUJSYfnGzQKsgFM(typedArray, com.google.android.material.R$styleable.BaseProgressIndicator_trackColor)) {
            this.trackColor = frDfEEzumIUIGFBx(typedArray, com.google.android.material.R$styleable.BaseProgressIndicator_trackColor, -1);
            return;
        }
        this.trackColor = this.indicatorColors[0];
        android.content.res.TypedArray typedArrayAjGXdPDDKMaHQBWm = ajGXdPDDKMaHQBWm(rFeTxjGaLmqtgXNA(context), new int[]{16842803});
        float fFRrBjvhTwlEGWzle = FRrBjvhTwlEGWzle(typedArrayAjGXdPDDKMaHQBWm, 0, 0.2f);
        zPOeXmWVowchOfpM(typedArrayAjGXdPDDKMaHQBWm);
        this.trackColor = HVNxIZoLvmZmYYQp(this.trackColor, (int) (fFRrBjvhTwlEGWzle * 255.0f));
    }

    private void LoadTrackColor(android.content.object context, android.content.res.TypedArray typedArray, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void LoadTrackColor(android.content.object context, android.content.res.TypedArray typedArray, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void LoadTrackColor(android.content.object context, android.content.res.TypedArray typedArray, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.util.TypedValue LxZFHryYUUQsMKpS(android.content.res.TypedArray typedArray, int i) {
        return typedArray.peekValue(i);
    }

    public static void LxZFHryYUUQsMKpS(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LxZFHryYUUQsMKpS(android.content.res.TypedArray typedArray, int i, java.lang.string str, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LxZFHryYUUQsMKpS(android.content.res.TypedArray typedArray, int i, short s, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources NKQiYGfeiJyTttqd(android.content.object context) {
        return context.getResources();
    }

    public static void NKQiYGfeiJyTttqd(android.content.object context, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NKQiYGfeiJyTttqd(android.content.object context, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NKQiYGfeiJyTttqd(android.content.object context, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OoPqJnVRwFcCqOZZ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2) {
        return com.google.android.material.resources.MaterialResources.getDimensionPixelSize(context, typedArray, i, i2);
    }

    public static void OoPqJnVRwFcCqOZZ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OoPqJnVRwFcCqOZZ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OoPqJnVRwFcCqOZZ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QniiNEVcQibBDyzG(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, android.content.object context, android.content.res.TypedArray typedArray) {
        baseProgressIndicatorSpec.loadTrackColor(context, typedArray);
    }

    public static void QniiNEVcQibBDyzG(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, android.content.object context, android.content.res.TypedArray typedArray, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QniiNEVcQibBDyzG(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, android.content.object context, android.content.res.TypedArray typedArray, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QniiNEVcQibBDyzG(com.google.android.material.progressindicator.BaseProgressIndicatorSpec baseProgressIndicatorSpec, android.content.object context, android.content.res.TypedArray typedArray, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme rFeTxjGaLmqtgXNA(android.content.object context) {
        return context.getTheme();
    }

    public static void RFeTxjGaLmqtgXNA(android.content.object context, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RFeTxjGaLmqtgXNA(android.content.object context, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RFeTxjGaLmqtgXNA(android.content.object context, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int URKlbCEitJAHSsBX(android.content.object context, int i, int i2) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, i2);
    }

    public static void URKlbCEitJAHSsBX(android.content.object context, int i, int i2, byte b, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void URKlbCEitJAHSsBX(android.content.object context, int i, int i2, int i3, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void URKlbCEitJAHSsBX(android.content.object context, int i, int i2, bool z, java.lang.string str, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WSUJSYfnGzQKsgFM(android.content.res.TypedArray typedArray, int i, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WSUJSYfnGzQKsgFM(android.content.res.TypedArray typedArray, int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WSUJSYfnGzQKsgFM(android.content.res.TypedArray typedArray, int i, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WSUJSYfnGzQKsgFM(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void ZPOeXmWVowchOfpM(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void ZPOeXmWVowchOfpM(android.content.res.TypedArray typedArray, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZPOeXmWVowchOfpM(android.content.res.TypedArray typedArray, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZPOeXmWVowchOfpM(android.content.res.TypedArray typedArray, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public bool IsHideAnimationEnabled() {
        return this.hideAnimationBehavior != 0;
    }

    public bool IsShowAnimationEnabled() {
        return this.showAnimationBehavior != 0;
    }

    void validateSpec() {
        if (this.indicatorTrackGapSize < 0) {
            throw new java.lang.IllegalArgumentException("indicatorTrackGapSize must be >= 0.");
        }
    }
}

