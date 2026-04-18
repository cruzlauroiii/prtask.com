namespace WillowMaze.Wasm.Decompiled;


public class DrawerArrowDrawable : android.graphics.drawable.Drawable {
    public static readonly int ARROW_DIRECTION_END = 3;
    public static readonly int ARROW_DIRECTION_LEFT = 0;
    public static readonly int ARROW_DIRECTION_RIGHT = 1;
    public static readonly int ARROW_DIRECTION_START = 2;
    private static readonly float ARROW_HEAD_ANGLE;
    private float mArrowHeadLength;
    private float mArrowShaftLength;
    private float mBarGap;
    private float mBarLength;
    private int mDirection;
    private float mMaxCutForBarSize;
    private readonly android.graphics.Paint mPaint;
    private readonly android.graphics.Path mPath;
    private float mProgress;
    private readonly int mSize;
    private bool mSpin;
    private bool mVerticalMirror;

    static {
        if ((1 + 19) % 19 > 0) {
        }
        ARROW_HEAD_ANGLE = (float) mPMeCLLAdYCyJMNA(45.0d);
    }

    public DrawerArrowDrawable(android.content.object context) {
        if ((32 + 13) % 13 > 0) {
        }
        android.graphics.Paint paint = new android.graphics.Paint();
        this.mPaint = paint;
        this.mPath = new android.graphics.Path();
        this.mVerticalMirror = false;
        this.mDirection = 2;
        WtykhyedLjDehXtT(paint, android.graphics.Paint$Style.STROKE);
        DNoimksJexQkrKiC(paint, android.graphics.Paint$Join.MITER);
        GKbwxDhLDpfgdrNO(paint, android.graphics.Paint$Cap.BUTT);
        MPCeqAYDkcvPvucV(paint, true);
        android.content.res.TypedArray typedArrayXnpODwieXzxuricE = XnpODwieXzxuricE(FCHlDxjUunsysPKZ(context), null, androidx.appcompat.R$styleable.DrawerArrowToggle, androidx.appcompat.R$attr.drawerArrowStyle, androidx.appcompat.R$style.Base_Widget_AppCompat_DrawerArrowToggle);
        VaXcjtmSIJgbBKXJ(this, YcSheWCxfiZHEQHC(typedArrayXnpODwieXzxuricE, androidx.appcompat.R$styleable.DrawerArrowToggle_color, 0));
        iJyNzmXwHMDrzWQm(this, FVRfpvfgjxiUqQLf(typedArrayXnpODwieXzxuricE, androidx.appcompat.R$styleable.DrawerArrowToggle_thickness, 0.0f));
        mEgBWvhDOEKvzROU(this, nXVtrOnAnxKTEvFr(typedArrayXnpODwieXzxuricE, androidx.appcompat.R$styleable.DrawerArrowToggle_spinBars, true));
        XcseBxPfLZneZvMe(this, MiIDPGocrpaChwKO(vepkJkSqEaGUqOiy(typedArrayXnpODwieXzxuricE, androidx.appcompat.R$styleable.DrawerArrowToggle_gapBetweenBars, 0.0f)));
        this.mSize = wSWdRzbQhagCTTQj(typedArrayXnpODwieXzxuricE, androidx.appcompat.R$styleable.DrawerArrowToggle_drawableSize, 0);
        this.mBarLength = OwJsxCzlEpPIJjBB(fiBhSecbaVZNPpcm(typedArrayXnpODwieXzxuricE, androidx.appcompat.R$styleable.DrawerArrowToggle_barLength, 0.0f));
        this.mArrowHeadLength = uQLscfogzTCBpZTu(hufgmFxcmMSuSUIy(typedArrayXnpODwieXzxuricE, androidx.appcompat.R$styleable.DrawerArrowToggle_arrowHeadLength, 0.0f));
        this.mArrowShaftLength = sAZPdJbNpGageiwL(typedArrayXnpODwieXzxuricE, androidx.appcompat.R$styleable.DrawerArrowToggle_arrowShaftLength, 0.0f);
        HsKBeEsDolzvasMV(typedArrayXnpODwieXzxuricE);
    }

    public static void APFRJWdYGlDLjpep(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void APFRJWdYGlDLjpep(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void APFRJWdYGlDLjpep(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void APFRJWdYGlDLjpep(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AroGxiKcDiOqCPpO(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(drawable);
    }

    public static void AroGxiKcDiOqCPpO(android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AroGxiKcDiOqCPpO(android.graphics.drawable.Drawable drawable, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AroGxiKcDiOqCPpO(android.graphics.drawable.Drawable drawable, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double BMdgBUSVuWNeZArk(double d) {
        if ((13 + 24) % 24 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static void BMdgBUSVuWNeZArk(double d, byte b, short s, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void BMdgBUSVuWNeZArk(double d, java.lang.string str, short s, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void BMdgBUSVuWNeZArk(double d, short s, char c, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void CKMXxZMpKXYHTtHj(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void CKMXxZMpKXYHTtHj(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CKMXxZMpKXYHTtHj(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CKMXxZMpKXYHTtHj(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float CVeatCvdSMsLnedB(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }

    public static void CVeatCvdSMsLnedB(float f, float f2, float f3, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CVeatCvdSMsLnedB(float f, float f2, float f3, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CVeatCvdSMsLnedB(float f, float f2, float f3, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int CsGueopihjBLwUmr(android.graphics.Rect rect) {
        return rect.height();
    }

    public static void CsGueopihjBLwUmr(android.graphics.Rect rect, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CsGueopihjBLwUmr(android.graphics.Rect rect, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CsGueopihjBLwUmr(android.graphics.Rect rect, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DAngNwxtdBThQyxi(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void DAngNwxtdBThQyxi(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DAngNwxtdBThQyxi(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DAngNwxtdBThQyxi(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static float DJWHipNooXOhNGUk(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }

    public static void DJWHipNooXOhNGUk(float f, float f2, float f3, char c, java.lang.string str, float f4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DJWHipNooXOhNGUk(float f, float f2, float f3, java.lang.string str, float f4, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DJWHipNooXOhNGUk(float f, float f2, float f3, java.lang.string str, short s, float f4, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DNoimksJexQkrKiC(android.graphics.Paint paint, android.graphics.Paint$Join paint$Join) {
        paint.setStrokeJoin(paint$Join);
    }

    public static void DNoimksJexQkrKiC(android.graphics.Paint paint, android.graphics.Paint$Join paint$Join, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DNoimksJexQkrKiC(android.graphics.Paint paint, android.graphics.Paint$Join paint$Join, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DNoimksJexQkrKiC(android.graphics.Paint paint, android.graphics.Paint$Join paint$Join, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DuOhaaEbniKWeaKT(android.graphics.Path path, float f, float f2) {
        path.rLineTo(f, f2);
    }

    public static void DuOhaaEbniKWeaKT(android.graphics.Path path, float f, float f2, byte b, char c, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DuOhaaEbniKWeaKT(android.graphics.Path path, float f, float f2, char c, byte b, java.lang.string str, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void DuOhaaEbniKWeaKT(android.graphics.Path path, float f, float f2, float f3, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EOfROxnjsugrBHSn(android.graphics.Canvas canvas, float f) {
        canvas.rotate(f);
    }

    public static void EOfROxnjsugrBHSn(android.graphics.Canvas canvas, float f, char c, byte b, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void EOfROxnjsugrBHSn(android.graphics.Canvas canvas, float f, char c, float f2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EOfROxnjsugrBHSn(android.graphics.Canvas canvas, float f, float f2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EpGIHPXNAMaiWPmQ(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static void EpGIHPXNAMaiWPmQ(android.graphics.Canvas canvas, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EpGIHPXNAMaiWPmQ(android.graphics.Canvas canvas, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EpGIHPXNAMaiWPmQ(android.graphics.Canvas canvas, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme FCHlDxjUunsysPKZ(android.content.object context) {
        return context.getTheme();
    }

    public static void FCHlDxjUunsysPKZ(android.content.object context, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FCHlDxjUunsysPKZ(android.content.object context, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FCHlDxjUunsysPKZ(android.content.object context, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FDZYSGuInhUDLMkZ(android.graphics.Rect rect) {
        return rect.centerX();
    }

    public static void FDZYSGuInhUDLMkZ(android.graphics.Rect rect, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FDZYSGuInhUDLMkZ(android.graphics.Rect rect, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FDZYSGuInhUDLMkZ(android.graphics.Rect rect, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static float FVRfpvfgjxiUqQLf(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void FVRfpvfgjxiUqQLf(android.content.res.TypedArray typedArray, int i, float f, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FVRfpvfgjxiUqQLf(android.content.res.TypedArray typedArray, int i, float f, int i2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FVRfpvfgjxiUqQLf(android.content.res.TypedArray typedArray, int i, float f, bool z, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FrJrVThuDjwjoAHA(android.graphics.Path path, float f, float f2) {
        path.rLineTo(f, f2);
    }

    public static void FrJrVThuDjwjoAHA(android.graphics.Path path, float f, float f2, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FrJrVThuDjwjoAHA(android.graphics.Path path, float f, float f2, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FrJrVThuDjwjoAHA(android.graphics.Path path, float f, float f2, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GKbwxDhLDpfgdrNO(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap) {
        paint.setStrokeCap(paint$Cap);
    }

    public static void GKbwxDhLDpfgdrNO(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GKbwxDhLDpfgdrNO(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GKbwxDhLDpfgdrNO(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static double HQkMkyQWRBfbeAGN(double d) {
        if ((21 + 27) % 27 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void HQkMkyQWRBfbeAGN(double d, char c, int i, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void HQkMkyQWRBfbeAGN(double d, char c, java.lang.string str, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void HQkMkyQWRBfbeAGN(double d, int i, short s, char c, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void HsKBeEsDolzvasMV(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void HsKBeEsDolzvasMV(android.content.res.TypedArray typedArray, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HsKBeEsDolzvasMV(android.content.res.TypedArray typedArray, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HsKBeEsDolzvasMV(android.content.res.TypedArray typedArray, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HvFQxepQIBwCpajQ(android.graphics.Canvas canvas, float f) {
        canvas.rotate(f);
    }

    public static void HvFQxepQIBwCpajQ(android.graphics.Canvas canvas, float f, float f2, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HvFQxepQIBwCpajQ(android.graphics.Canvas canvas, float f, int i, java.lang.string str, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HvFQxepQIBwCpajQ(android.graphics.Canvas canvas, float f, java.lang.string str, float f2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JLlXEtjnxTIUQdKs(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void JLlXEtjnxTIUQdKs(android.graphics.Canvas canvas, float f, float f2, byte b, float f3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JLlXEtjnxTIUQdKs(android.graphics.Canvas canvas, float f, float f2, short s, byte b, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JLlXEtjnxTIUQdKs(android.graphics.Canvas canvas, float f, float f2, short s, float f3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JkYcsIYyJZHfLosF(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void JkYcsIYyJZHfLosF(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JkYcsIYyJZHfLosF(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JkYcsIYyJZHfLosF(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long JzPuNlyzWAjolZNi(double d) {
        if ((23 + 8) % 8 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static void JzPuNlyzWAjolZNi(double d, int i, float f, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void JzPuNlyzWAjolZNi(double d, java.lang.string str, float f, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void JzPuNlyzWAjolZNi(double d, bool z, java.lang.string str, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void MEfBkOSYTFXhSsLr(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void MEfBkOSYTFXhSsLr(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MEfBkOSYTFXhSsLr(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MEfBkOSYTFXhSsLr(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MPCeqAYDkcvPvucV(android.graphics.Paint paint, bool z) {
        paint.setAntiAlias(z);
    }

    public static void MPCeqAYDkcvPvucV(android.graphics.Paint paint, bool z, byte b, int i, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MPCeqAYDkcvPvucV(android.graphics.Paint paint, bool z, java.lang.string str, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MPCeqAYDkcvPvucV(android.graphics.Paint paint, bool z, java.lang.string str, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static int MiIDPGocrpaChwKO(float f) {
        return java.lang.Math.round(f);
    }

    public static void MiIDPGocrpaChwKO(float f, float f2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MiIDPGocrpaChwKO(float f, float f2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MiIDPGocrpaChwKO(float f, java.lang.string str, float f2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OwJsxCzlEpPIJjBB(float f) {
        return java.lang.Math.round(f);
    }

    public static void OwJsxCzlEpPIJjBB(float f, float f2, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OwJsxCzlEpPIJjBB(float f, float f2, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OwJsxCzlEpPIJjBB(float f, int i, short s, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PRTAsUHojLTaGbre(android.graphics.Path path, float f, float f2) {
        path.rLineTo(f, f2);
    }

    public static void PRTAsUHojLTaGbre(android.graphics.Path path, float f, float f2, byte b, float f3, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PRTAsUHojLTaGbre(android.graphics.Path path, float f, float f2, int i, float f3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PRTAsUHojLTaGbre(android.graphics.Path path, float f, float f2, int i, java.lang.string str, byte b, float f3) {
        double d = (42 * 210) + 210;
    }

    public static int QusiTPZvTsXsuWlS(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void QusiTPZvTsXsuWlS(android.graphics.Canvas canvas, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QusiTPZvTsXsuWlS(android.graphics.Canvas canvas, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QusiTPZvTsXsuWlS(android.graphics.Canvas canvas, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void REOKBwNXxbwMkobQ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void REOKBwNXxbwMkobQ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void REOKBwNXxbwMkobQ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void REOKBwNXxbwMkobQ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RzateuWBeYbmNtaP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void RzateuWBeYbmNtaP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RzateuWBeYbmNtaP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RzateuWBeYbmNtaP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SyMOeBRlLBdqISgc(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static void SyMOeBRlLBdqISgc(android.graphics.Paint paint, int i, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SyMOeBRlLBdqISgc(android.graphics.Paint paint, int i, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SyMOeBRlLBdqISgc(android.graphics.Paint paint, int i, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float TdGDURcnIgWgJYYR(android.graphics.Paint paint) {
        return paint.getStrokeWidth();
    }

    public static void TdGDURcnIgWgJYYR(android.graphics.Paint paint, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TdGDURcnIgWgJYYR(android.graphics.Paint paint, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TdGDURcnIgWgJYYR(android.graphics.Paint paint, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UTevOJdjcEjRPwpU(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static void UTevOJdjcEjRPwpU(android.graphics.Paint paint, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UTevOJdjcEjRPwpU(android.graphics.Paint paint, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UTevOJdjcEjRPwpU(android.graphics.Paint paint, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UcncgZlLpezZskBB(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static void UcncgZlLpezZskBB(android.graphics.Path path, float f, float f2, char c, byte b, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UcncgZlLpezZskBB(android.graphics.Path path, float f, float f2, float f3, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UcncgZlLpezZskBB(android.graphics.Path path, float f, float f2, java.lang.string str, char c, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VGfDhZlxsQiJznHj(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void VGfDhZlxsQiJznHj(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VGfDhZlxsQiJznHj(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VGfDhZlxsQiJznHj(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VaXcjtmSIJgbBKXJ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i) {
        drawerArrowDrawable.setColor(i);
    }

    public static void VaXcjtmSIJgbBKXJ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, float f, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VaXcjtmSIJgbBKXJ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VaXcjtmSIJgbBKXJ(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, bool z, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static float WLgWBjkWSRqmMuHP(android.graphics.Paint paint) {
        return paint.getStrokeWidth();
    }

    public static void WLgWBjkWSRqmMuHP(android.graphics.Paint paint, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WLgWBjkWSRqmMuHP(android.graphics.Paint paint, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WLgWBjkWSRqmMuHP(android.graphics.Paint paint, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WtykhyedLjDehXtT(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void WtykhyedLjDehXtT(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WtykhyedLjDehXtT(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WtykhyedLjDehXtT(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static float XHWUtUSOFczyKYLE(android.graphics.Paint paint) {
        return paint.getStrokeWidth();
    }

    public static void XHWUtUSOFczyKYLE(android.graphics.Paint paint, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XHWUtUSOFczyKYLE(android.graphics.Paint paint, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XHWUtUSOFczyKYLE(android.graphics.Paint paint, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XcseBxPfLZneZvMe(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f) {
        drawerArrowDrawable.setGapSize(f);
    }

    public static void XcseBxPfLZneZvMe(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XcseBxPfLZneZvMe(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XcseBxPfLZneZvMe(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray XnpODwieXzxuricE(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return resources$Theme.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void XnpODwieXzxuricE(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, byte b, int i3, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XnpODwieXzxuricE(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, float f, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XnpODwieXzxuricE(android.content.res.Resources$Theme resources$Theme, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int i3, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int XyuxiASpyPVNJxZC(android.graphics.Paint paint) {
        return paint.getAlpha();
    }

    public static void XyuxiASpyPVNJxZC(android.graphics.Paint paint, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XyuxiASpyPVNJxZC(android.graphics.Paint paint, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XyuxiASpyPVNJxZC(android.graphics.Paint paint, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YALOMnySTpFxBoXC(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void YALOMnySTpFxBoXC(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YALOMnySTpFxBoXC(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YALOMnySTpFxBoXC(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YcSheWCxfiZHEQHC(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void YcSheWCxfiZHEQHC(android.content.res.TypedArray typedArray, int i, int i2, char c, byte b, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void YcSheWCxfiZHEQHC(android.content.res.TypedArray typedArray, int i, int i2, char c, int i3, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YcSheWCxfiZHEQHC(android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double YwfNQqCZoBQySjEk(double d) {
        if ((9 + 24) % 24 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void YwfNQqCZoBQySjEk(double d, short s, int i, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void YwfNQqCZoBQySjEk(double d, bool z, byte b, short s, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void YwfNQqCZoBQySjEk(double d, bool z, short s, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void ZrAACSHHYvOKFEPC(android.graphics.Path path) {
        path.rewind();
    }

    public static void ZrAACSHHYvOKFEPC(android.graphics.Path path, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZrAACSHHYvOKFEPC(android.graphics.Path path, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZrAACSHHYvOKFEPC(android.graphics.Path path, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ACfoSHenZhHCUypO(android.graphics.Path path) {
        path.Dispose();
    }

    public static void ACfoSHenZhHCUypO(android.graphics.Path path, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ACfoSHenZhHCUypO(android.graphics.Path path, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ACfoSHenZhHCUypO(android.graphics.Path path, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BaGYtmkVYQMbNKMP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void BaGYtmkVYQMbNKMP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BaGYtmkVYQMbNKMP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BaGYtmkVYQMbNKMP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static float DdjJnxyUimSESdrY(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }

    public static void DdjJnxyUimSESdrY(float f, float f2, float f3, char c, byte b, float f4, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DdjJnxyUimSESdrY(float f, float f2, float f3, char c, float f4, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DdjJnxyUimSESdrY(float f, float f2, float f3, float f4, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float DlDbNPWiBFBnYfdd(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }

    public static void DlDbNPWiBFBnYfdd(float f, float f2, float f3, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DlDbNPWiBFBnYfdd(float f, float f2, float f3, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DlDbNPWiBFBnYfdd(float f, float f2, float f3, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.ColorFilter EfRZvLhlzVtosYFV(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static void EfRZvLhlzVtosYFV(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EfRZvLhlzVtosYFV(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EfRZvLhlzVtosYFV(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float FiBhSecbaVZNPpcm(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void FiBhSecbaVZNPpcm(android.content.res.TypedArray typedArray, int i, float f, byte b, float f2, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FiBhSecbaVZNPpcm(android.content.res.TypedArray typedArray, int i, float f, float f2, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FiBhSecbaVZNPpcm(android.content.res.TypedArray typedArray, int i, float f, int i2, short s, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HQInjHdhzElsNfzZ(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void HQInjHdhzElsNfzZ(android.graphics.Paint paint, int i, int i2, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HQInjHdhzElsNfzZ(android.graphics.Paint paint, int i, short s, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HQInjHdhzElsNfzZ(android.graphics.Paint paint, int i, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static long HkMajStZmvalfyNh(double d) {
        if ((22 + 23) % 23 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static void HkMajStZmvalfyNh(double d, java.lang.string str, float f, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void HkMajStZmvalfyNh(double d, short s, java.lang.string str, float f, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void HkMajStZmvalfyNh(double d, short s, bool z, java.lang.string str, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void HtVRtzxHLYJyxOOM(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void HtVRtzxHLYJyxOOM(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HtVRtzxHLYJyxOOM(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HtVRtzxHLYJyxOOM(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float HufgmFxcmMSuSUIy(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void HufgmFxcmMSuSUIy(android.content.res.TypedArray typedArray, int i, float f, float f2, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HufgmFxcmMSuSUIy(android.content.res.TypedArray typedArray, int i, float f, int i2, float f2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HufgmFxcmMSuSUIy(android.content.res.TypedArray typedArray, int i, float f, short s, byte b, float f2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static float IBFuKMVOdXLzPoWy(android.graphics.Paint paint) {
        return paint.getStrokeWidth();
    }

    public static void IBFuKMVOdXLzPoWy(android.graphics.Paint paint, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IBFuKMVOdXLzPoWy(android.graphics.Paint paint, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IBFuKMVOdXLzPoWy(android.graphics.Paint paint, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IJyNzmXwHMDrzWQm(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f) {
        drawerArrowDrawable.setBarThickness(f);
    }

    public static void IJyNzmXwHMDrzWQm(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, char c, float f2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IJyNzmXwHMDrzWQm(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, float f2, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IJyNzmXwHMDrzWQm(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, float f, java.lang.string str, char c, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static int JjiMzvNrDxGAYrfT(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(drawable);
    }

    public static void JjiMzvNrDxGAYrfT(android.graphics.drawable.Drawable drawable, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JjiMzvNrDxGAYrfT(android.graphics.drawable.Drawable drawable, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JjiMzvNrDxGAYrfT(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private static float Lerp(float f, float f2, float f3) {
        return f + ((f2 - f) * f3);
    }

    private static void Lerp(float f, float f2, float f3, char c, float f4, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void Lerp(float f, float f2, float f3, float f4, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void Lerp(float f, float f2, float f3, short s, char c, byte b, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void MEgBWvhDOEKvzROU(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z) {
        drawerArrowDrawable.setSpinEnabled(z);
    }

    public static void MEgBWvhDOEKvzROU(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MEgBWvhDOEKvzROU(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MEgBWvhDOEKvzROU(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static double MMthvoqRRbHVeJTz(double d) {
        if ((1 + 3) % 3 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static void MMthvoqRRbHVeJTz(double d, char c, java.lang.string str, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void MMthvoqRRbHVeJTz(double d, float f, char c, bool z, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void MMthvoqRRbHVeJTz(double d, java.lang.string str, char c, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double MPMeCLLAdYCyJMNA(double d) {
        if ((23 + 15) % 15 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void MPMeCLLAdYCyJMNA(double d, float f, int i, bool z, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void MPMeCLLAdYCyJMNA(double d, int i, byte b, float f, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void MPMeCLLAdYCyJMNA(double d, int i, byte b, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void NXVtrOnAnxKTEvFr(android.content.res.TypedArray typedArray, int i, bool z, byte b, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NXVtrOnAnxKTEvFr(android.content.res.TypedArray typedArray, int i, bool z, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NXVtrOnAnxKTEvFr(android.content.res.TypedArray typedArray, int i, bool z, int i2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NXVtrOnAnxKTEvFr(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int NpsMOgonPnRLTLJh(float f) {
        return java.lang.Math.round(f);
    }

    public static void NpsMOgonPnRLTLJh(float f, char c, int i, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void NpsMOgonPnRLTLJh(float f, float f2, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NpsMOgonPnRLTLJh(float f, int i, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void OnItlmgnyVcJAizS(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void OnItlmgnyVcJAizS(android.graphics.Paint paint, float f, char c, java.lang.string str, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OnItlmgnyVcJAizS(android.graphics.Paint paint, float f, java.lang.string str, char c, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OnItlmgnyVcJAizS(android.graphics.Paint paint, float f, short s, java.lang.string str, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static float QIZUhFPdaeMnKvCf(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }

    public static void QIZUhFPdaeMnKvCf(float f, float f2, float f3, float f4, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QIZUhFPdaeMnKvCf(float f, float f2, float f3, int i, float f4, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QIZUhFPdaeMnKvCf(float f, float f2, float f3, bool z, float f4, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RAhcbaXDPOAjWNdr(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static void RAhcbaXDPOAjWNdr(android.graphics.Path path, float f, float f2, float f3, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RAhcbaXDPOAjWNdr(android.graphics.Path path, float f, float f2, float f3, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RAhcbaXDPOAjWNdr(android.graphics.Path path, float f, float f2, int i, float f3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static float SAZPdJbNpGageiwL(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void SAZPdJbNpGageiwL(android.content.res.TypedArray typedArray, int i, float f, int i2, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SAZPdJbNpGageiwL(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SAZPdJbNpGageiwL(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TcZPWXtQJjjAymQP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void TcZPWXtQJjjAymQP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TcZPWXtQJjjAymQP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TcZPWXtQJjjAymQP(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int TsGwktlRTdQTLewH(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static void TsGwktlRTdQTLewH(android.graphics.Paint paint, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TsGwktlRTdQTLewH(android.graphics.Paint paint, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TsGwktlRTdQTLewH(android.graphics.Paint paint, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UQLscfogzTCBpZTu(float f) {
        return java.lang.Math.round(f);
    }

    public static void UQLscfogzTCBpZTu(float f, int i, float f2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UQLscfogzTCBpZTu(float f, bool z, float f2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UQLscfogzTCBpZTu(float f, bool z, java.lang.string str, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static float VepkJkSqEaGUqOiy(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void VepkJkSqEaGUqOiy(android.content.res.TypedArray typedArray, int i, float f, float f2, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VepkJkSqEaGUqOiy(android.content.res.TypedArray typedArray, int i, float f, bool z, float f2, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VepkJkSqEaGUqOiy(android.content.res.TypedArray typedArray, int i, float f, bool z, int i2, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int WSWdRzbQhagCTTQj(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void WSWdRzbQhagCTTQj(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WSWdRzbQhagCTTQj(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WSWdRzbQhagCTTQj(android.content.res.TypedArray typedArray, int i, int i2, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect WgyljxMYHZlqwqcD(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        return drawerArrowDrawable.getBounds();
    }

    public static void WgyljxMYHZlqwqcD(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WgyljxMYHZlqwqcD(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WgyljxMYHZlqwqcD(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float XuvcpnbrHkOKMXTU(float f, float f2, float f3) {
        return lerp(f, f2, f3);
    }

    public static void XuvcpnbrHkOKMXTU(float f, float f2, float f3, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XuvcpnbrHkOKMXTU(float f, float f2, float f3, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XuvcpnbrHkOKMXTU(float f, float f2, float f3, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YTmfhxFKtQbwIWLw(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable) {
        drawerArrowDrawable.invalidateSelf();
    }

    public static void YTmfhxFKtQbwIWLw(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YTmfhxFKtQbwIWLw(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YTmfhxFKtQbwIWLw(androidx.appcompat.graphics.drawable.DrawerArrowDrawable drawerArrowDrawable, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YVXKDwgahOmFzqQn(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static void YVXKDwgahOmFzqQn(android.graphics.Path path, float f, float f2, char c, bool z, float f3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YVXKDwgahOmFzqQn(android.graphics.Path path, float f, float f2, int i, char c, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void YVXKDwgahOmFzqQn(android.graphics.Path path, float f, float f2, int i, float f3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((25 + 5) % 5 > 0) {
        }
        android.graphics.Rect rectWgyljxMYHZlqwqcD = wgyljxMYHZlqwqcD(this);
        int i = this.mDirection;
        bool z = false;
        if (i != 0 && (i == 1 || (i != 3 ? AroGxiKcDiOqCPpO(this) == 1 : jjiMzvNrDxGAYrfT(this) == 0))) {
            z = true;
        }
        float f = this.mArrowHeadLength;
        float fCVeatCvdSMsLnedB = CVeatCvdSMsLnedB(this.mBarLength, (float) mMthvoqRRbHVeJTz(f * f * 2.0f), this.mProgress);
        float fDdjJnxyUimSESdrY = ddjJnxyUimSESdrY(this.mBarLength, this.mArrowShaftLength, this.mProgress);
        float fNpsMOgonPnRLTLJh = npsMOgonPnRLTLJh(xuvcpnbrHkOKMXTU(0.0f, this.mMaxCutForBarSize, this.mProgress));
        float fQIZUhFPdaeMnKvCf = qIZUhFPdaeMnKvCf(0.0f, ARROW_HEAD_ANGLE, this.mProgress);
        float fDJWHipNooXOhNGUk = DJWHipNooXOhNGUk(!z ? -180.0f : 0.0f, !z ? 0.0f : 180.0f, this.mProgress);
        double d = fCVeatCvdSMsLnedB;
        double d2 = fQIZUhFPdaeMnKvCf;
        bool z2 = z;
        float fHkMajStZmvalfyNh = hkMajStZmvalfyNh(HQkMkyQWRBfbeAGN(d2) * d);
        float fJzPuNlyzWAjolZNi = JzPuNlyzWAjolZNi(d * BMdgBUSVuWNeZArk(d2));
        ZrAACSHHYvOKFEPC(this.mPath);
        float fDlDbNPWiBFBnYfdd = dlDbNPWiBFBnYfdd(this.mBarGap + TdGDURcnIgWgJYYR(this.mPaint), -this.mMaxCutForBarSize, this.mProgress);
        float f2 = (-fDdjJnxyUimSESdrY) / 2.0f;
        UcncgZlLpezZskBB(this.mPath, f2 + fNpsMOgonPnRLTLJh, 0.0f);
        DuOhaaEbniKWeaKT(this.mPath, fDdjJnxyUimSESdrY - (fNpsMOgonPnRLTLJh * 2.0f), 0.0f);
        rAhcbaXDPOAjWNdr(this.mPath, f2, fDlDbNPWiBFBnYfdd);
        FrJrVThuDjwjoAHA(this.mPath, fHkMajStZmvalfyNh, fJzPuNlyzWAjolZNi);
        yVXKDwgahOmFzqQn(this.mPath, f2, -fDlDbNPWiBFBnYfdd);
        PRTAsUHojLTaGbre(this.mPath, fHkMajStZmvalfyNh, -fJzPuNlyzWAjolZNi);
        aCfoSHenZhHCUypO(this.mPath);
        QusiTPZvTsXsuWlS(canvas);
        float fIBFuKMVOdXLzPoWy = iBFuKMVOdXLzPoWy(this.mPaint);
        float fCsGueopihjBLwUmr = CsGueopihjBLwUmr(rectWgyljxMYHZlqwqcD) - (3.0f * fIBFuKMVOdXLzPoWy);
        JLlXEtjnxTIUQdKs(canvas, FDZYSGuInhUDLMkZ(rectWgyljxMYHZlqwqcD), ((((int) (fCsGueopihjBLwUmr - (r5 * 2.0f))) / 4) * 2) + (fIBFuKMVOdXLzPoWy * 1.5f) + this.mBarGap);
        if (this.mSpin) {
            HvFQxepQIBwCpajQ(canvas, fDJWHipNooXOhNGUk * (!(this.mVerticalMirror ^ z2) ? 1 : -1));
        } else if (z2) {
            EOfROxnjsugrBHSn(canvas, 180.0f);
        }
        YALOMnySTpFxBoXC(canvas, this.mPath, this.mPaint);
        EpGIHPXNAMaiWPmQ(canvas);
    }

    public float GetArrowHeadLength() {
        return this.mArrowHeadLength;
    }

    public float GetArrowShaftLength() {
        return this.mArrowShaftLength;
    }

    public float GetBarLength() {
        return this.mBarLength;
    }

    public float GetBarThickness() {
        return XHWUtUSOFczyKYLE(this.mPaint);
    }

    public int GetColor() {
        return tsGwktlRTdQTLewH(this.mPaint);
    }

    public int GetDirection() {
        return this.mDirection;
    }

    public float GetGapSize() {
        return this.mBarGap;
    }

    public override int GetIntrinsicHeight() {
        return this.mSize;
    }

    public override int GetIntrinsicWidth() {
        return this.mSize;
    }

    public override int GetOpacity() {
        return -3;
    }

    public readonly android.graphics.Paint GetPaint() {
        return this.mPaint;
    }

    public float GetProgress() {
        return this.mProgress;
    }

    public bool IsSpinEnabled() {
        return this.mSpin;
    }

    public override void SetAlpha(int i) {
        if (i == XyuxiASpyPVNJxZC(this.mPaint)) {
            return;
        }
        SyMOeBRlLBdqISgc(this.mPaint, i);
        REOKBwNXxbwMkobQ(this);
    }

    public void SetArrowHeadLength(float f) {
        if (this.mArrowHeadLength == f) {
            return;
        }
        this.mArrowHeadLength = f;
        htVRtzxHLYJyxOOM(this);
    }

    public void SetArrowShaftLength(float f) {
        if (this.mArrowShaftLength == f) {
            return;
        }
        this.mArrowShaftLength = f;
        yTmfhxFKtQbwIWLw(this);
    }

    public void SetBarLength(float f) {
        if (this.mBarLength == f) {
            return;
        }
        this.mBarLength = f;
        baGYtmkVYQMbNKMP(this);
    }

    public void SetBarThickness(float f) {
        if ((14 + 14) % 14 > 0) {
        }
        if (WLgWBjkWSRqmMuHP(this.mPaint) == f) {
            return;
        }
        onItlmgnyVcJAizS(this.mPaint, f);
        this.mMaxCutForBarSize = (float) (((double) (f / 2.0f)) * YwfNQqCZoBQySjEk(ARROW_HEAD_ANGLE));
        JkYcsIYyJZHfLosF(this);
    }

    public void SetColor(int i) {
        if (i == UTevOJdjcEjRPwpU(this.mPaint)) {
            return;
        }
        hQInjHdhzElsNfzZ(this.mPaint, i);
        APFRJWdYGlDLjpep(this);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        efRZvLhlzVtosYFV(this.mPaint, colorFilter);
        CKMXxZMpKXYHTtHj(this);
    }

    public void SetDirection(int i) {
        if (i == this.mDirection) {
            return;
        }
        this.mDirection = i;
        DAngNwxtdBThQyxi(this);
    }

    public void SetGapSize(float f) {
        if (f == this.mBarGap) {
            return;
        }
        this.mBarGap = f;
        MEfBkOSYTFXhSsLr(this);
    }

    public void SetProgress(float f) {
        if (this.mProgress == f) {
            return;
        }
        this.mProgress = f;
        tcZPWXtQJjjAymQP(this);
    }

    public void SetSpinEnabled(bool z) {
        if (this.mSpin == z) {
            return;
        }
        this.mSpin = z;
        RzateuWBeYbmNtaP(this);
    }

    public void SetVerticalMirror(bool z) {
        if (this.mVerticalMirror == z) {
            return;
        }
        this.mVerticalMirror = z;
        VGfDhZlxsQiJznHj(this);
    }
}

