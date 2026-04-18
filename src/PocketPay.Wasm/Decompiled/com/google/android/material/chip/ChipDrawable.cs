namespace WillowMaze.Wasm.Decompiled;


public class ChipDrawable : com.google.android.material.shape.MaterialShapeDrawable : androidx.core.graphics.drawable.TintAwareDrawable, android.graphics.drawable.Drawable$Callback, com.google.android.material.internal.TextDrawableHelper$TextDrawableDelegate {
    private static readonly bool DEBUG = false;
    private static readonly int[] DEFAULT_STATE;
    private static readonly int MAX_CHIP_ICON_HEIGHT = 24;
    private static readonly java.lang.string NAMESPACE_APP = "http://schemas.android.com/apk/res-auto";
    private static readonly android.graphics.drawable.ShapeDrawable closeIconRippleMask;
    private int alpha;
    private bool checkable;
    private android.graphics.drawable.Drawable checkedIcon;
    private android.content.res.ColorStateList checkedIconTint;
    private bool checkedIconVisible;
    private android.content.res.ColorStateList chipBackgroundColor;
    private float chipCornerRadius;
    private float chipEndPadding;
    private android.graphics.drawable.Drawable chipIcon;
    private float chipIconSize;
    private android.content.res.ColorStateList chipIconTint;
    private bool chipIconVisible;
    private float chipMinHeight;
    private readonly android.graphics.Paint chipPaint;
    private float chipStartPadding;
    private android.content.res.ColorStateList chipStrokeColor;
    private float chipStrokeWidth;
    private android.content.res.ColorStateList chipSurfaceColor;
    private android.graphics.drawable.Drawable closeIcon;
    private java.lang.CharSequence closeIconContentDescription;
    private float closeIconEndPadding;
    private android.graphics.drawable.Drawable closeIconRipple;
    private float closeIconSize;
    private float closeIconStartPadding;
    private int[] closeIconStateHashSet;
    private android.content.res.ColorStateList closeIconTint;
    private bool closeIconVisible;
    private android.graphics.ColorFilter colorFilter;
    private android.content.res.ColorStateList compatRippleColor;
    private readonly android.content.object context;
    private bool currentChecked;
    private int currentChipBackgroundColor;
    private int currentChipStrokeColor;
    private int currentChipSurfaceColor;
    private int currentCompatRippleColor;
    private int currentCompositeSurfaceBackgroundColor;
    private int currentTextColor;
    private int currentTint;
    private readonly android.graphics.Paint debugPaint;
    private java.lang.ref.WeakReference<com.google.android.material.chip.ChipDrawable$Delegate> delegate;
    private readonly android.graphics.Paint$FontMetrics fontMetrics;
    private bool hasChipIconTint;
    private com.google.android.material.animation.MotionSpec hideMotionSpec;
    private float iconEndPadding;
    private float iconStartPadding;
    private bool isShapeThemingEnabled;
    private int maxWidth;
    private readonly android.graphics.PointF pointF;
    private readonly android.graphics.RectF rectF;
    private android.content.res.ColorStateList rippleColor;
    private readonly android.graphics.Path shapePath;
    private bool shouldDrawText;
    private com.google.android.material.animation.MotionSpec showMotionSpec;
    private java.lang.CharSequence text;
    private readonly com.google.android.material.internal.TextDrawableHelper textDrawableHelper;
    private float textEndPadding;
    private float textStartPadding;
    private android.content.res.ColorStateList tint;
    private android.graphics.PorterDuffColorFilter tintFilter;
    private android.graphics.PorterDuff$Mode tintMode;
    private android.text.TextUtils$TruncateAt truncateAt;
    private bool useCompatRipple;

    static {
        if ((30 + 32) % 32 > 0) {
        }
        DEFAULT_STATE = new int[]{16842910};
        closeIconRippleMask = new android.graphics.drawable.ShapeDrawable(new android.graphics.drawable.shapes.OvalShape());
    }

    private ChipDrawable(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(context, attributeHashSet, i, i2);
        this.chipCornerRadius = -1.0f;
        this.chipPaint = new android.graphics.Paint(1);
        this.fontMetrics = new android.graphics.Paint$FontMetrics();
        this.rectF = new android.graphics.RectF();
        this.pointF = new android.graphics.PointF();
        this.shapePath = new android.graphics.Path();
        this.alpha = 255;
        this.tintMode = android.graphics.PorterDuff$Mode.SRC_IN;
        this.delegate = new java.lang.ref.WeakReference<>(null);
        hQGqRzLOoUGvMivQ(this, context);
        this.context = context;
        com.google.android.material.internal.TextDrawableHelper textDrawableHelper = new com.google.android.material.internal.TextDrawableHelper(this);
        this.textDrawableHelper = textDrawableHelper;
        this.text = "";
        jRqQmcEIUMFxAiKc(textDrawableHelper).density = yvESiVHRuQTkVTmt(LsYojdZZznnbCBzp(context)).density;
        this.debugPaint = null;
        int[] iArr = DEFAULT_STATE;
        YoYVjoZSKMTmZMqm(this, iArr);
        RDyRfAoNoUbZDSre(this, iArr);
        this.shouldDrawText = true;
        if (com.google.android.material.ripple.RippleUtils.USE_FRAMEWORK_RIPPLE) {
            XJynDToKmycGRRrz(closeIconRippleMask, -1);
        }
    }

    public static android.content.res.Resources ANfbmPXYIkHdWKKX(android.content.object context) {
        return context.getResources();
    }

    public static void ANfbmPXYIkHdWKKX(android.content.object context, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ANfbmPXYIkHdWKKX(android.content.object context, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ANfbmPXYIkHdWKKX(android.content.object context, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList APbHBbbhsYeKbKOB(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void APbHBbbhsYeKbKOB(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void APbHBbbhsYeKbKOB(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void APbHBbbhsYeKbKOB(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ARtZIRQXTPDfxNfn(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(drawable);
    }

    public static void ARtZIRQXTPDfxNfn(android.graphics.drawable.Drawable drawable, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ARtZIRQXTPDfxNfn(android.graphics.drawable.Drawable drawable, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ARtZIRQXTPDfxNfn(android.graphics.drawable.Drawable drawable, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float AWitbhISOfdMEpbK(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void AWitbhISOfdMEpbK(android.content.res.Resources resources, int i, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AWitbhISOfdMEpbK(android.content.res.Resources resources, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AWitbhISOfdMEpbK(android.content.res.Resources resources, int i, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AaezHvRjiXmbelPK(android.content.res.TypedArray typedArray, int i, bool z, float f, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AaezHvRjiXmbelPK(android.content.res.TypedArray typedArray, int i, bool z, float f, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AaezHvRjiXmbelPK(android.content.res.TypedArray typedArray, int i, bool z, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool AaezHvRjiXmbelPK(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void AhpygcqODZYZGtTY(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF) {
        chipDrawable.calculateCloseIconTouchBounds(rect, rectF);
    }

    public static void AhpygcqODZYZGtTY(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AhpygcqODZYZGtTY(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AhpygcqODZYZGtTY(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ArDFvkdxUQSldgLz(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void ArDFvkdxUQSldgLz(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ArDFvkdxUQSldgLz(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ArDFvkdxUQSldgLz(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AyxhfRBcPaFvpubr(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AyxhfRBcPaFvpubr(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AyxhfRBcPaFvpubr(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AyxhfRBcPaFvpubr(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static float BAqFwZxpzBRdtfXg(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void BAqFwZxpzBRdtfXg(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BAqFwZxpzBRdtfXg(android.content.res.TypedArray typedArray, int i, float f, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BAqFwZxpzBRdtfXg(android.content.res.TypedArray typedArray, int i, float f, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BDquZWCkwthSTGjw(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void BDquZWCkwthSTGjw(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BDquZWCkwthSTGjw(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BDquZWCkwthSTGjw(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BHvCtoJRPqxaknhS(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BHvCtoJRPqxaknhS(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BHvCtoJRPqxaknhS(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool BHvCtoJRPqxaknhS(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static void BMrWdwheovjXNbLf(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BMrWdwheovjXNbLf(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BMrWdwheovjXNbLf(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BMrWdwheovjXNbLf(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsChipIcon();
    }

    public static void BRCehrUOxFFRSFri(android.graphics.Outline outline, int i, int i2, int i3, int i4, float f) {
        outline.setRoundRect(i, i2, i3, i4, f);
    }

    public static void BRCehrUOxFFRSFri(android.graphics.Outline outline, int i, int i2, int i3, int i4, float f, char c, java.lang.string str, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void BRCehrUOxFFRSFri(android.graphics.Outline outline, int i, int i2, int i3, int i4, float f, int i5, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BRCehrUOxFFRSFri(android.graphics.Outline outline, int i, int i2, int i3, int i4, float f, short s, java.lang.string str, int i5, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BUuBhMqsPuIOdHVE(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect) {
        chipDrawable.drawChipStroke(canvas, rect);
    }

    public static void BUuBhMqsPuIOdHVE(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BUuBhMqsPuIOdHVE(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BUuBhMqsPuIOdHVE(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BjjzvbqPJJsLHOyP(android.graphics.drawable.Drawable drawable, int[] iArr, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BjjzvbqPJJsLHOyP(android.graphics.drawable.Drawable drawable, int[] iArr, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BjjzvbqPJJsLHOyP(android.graphics.drawable.Drawable drawable, int[] iArr, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool BjjzvbqPJJsLHOyP(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static android.graphics.Rect ByRedKBKMbHQVaez(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getBounds();
    }

    public static void ByRedKBKMbHQVaez(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ByRedKBKMbHQVaez(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ByRedKBKMbHQVaez(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static float CAiWLUXekfqSKUir(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void CAiWLUXekfqSKUir(android.content.res.TypedArray typedArray, int i, float f, float f2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CAiWLUXekfqSKUir(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, float f2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CAiWLUXekfqSKUir(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, bool z, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CCJxPwRFcHwMEmRz(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CCJxPwRFcHwMEmRz(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CCJxPwRFcHwMEmRz(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] CCJxPwRFcHwMEmRz(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static void CIQOfFiUfEmnaYYn(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void CIQOfFiUfEmnaYYn(android.graphics.Paint paint, int i, int i2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CIQOfFiUfEmnaYYn(android.graphics.Paint paint, int i, int i2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CIQOfFiUfEmnaYYn(android.graphics.Paint paint, int i, short s, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static float CLiOWuXBhFGdMdur(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void CLiOWuXBhFGdMdur(android.graphics.RectF rectF, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CLiOWuXBhFGdMdur(android.graphics.RectF rectF, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CLiOWuXBhFGdMdur(android.graphics.RectF rectF, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void COOicoymeqUiRXPJ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec) {
        chipDrawable.setHideMotionSpec(motionSpec);
    }

    public static void COOicoymeqUiRXPJ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void COOicoymeqUiRXPJ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void COOicoymeqUiRXPJ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CRicMZaKiJfmjBEL(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect) {
        chipDrawable.drawCompatRipple(canvas, rect);
    }

    public static void CRicMZaKiJfmjBEL(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CRicMZaKiJfmjBEL(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CRicMZaKiJfmjBEL(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CaYFQGdvfLwYFlXs(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getAlpha();
    }

    public static void CaYFQGdvfLwYFlXs(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CaYFQGdvfLwYFlXs(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CaYFQGdvfLwYFlXs(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CbvaXKpilCixZVgE(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipStartPadding(f);
    }

    public static void CbvaXKpilCixZVgE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, java.lang.string str, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CbvaXKpilCixZVgE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CbvaXKpilCixZVgE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, byte b, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable CbzRMptKhGkMsejQ(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void CbzRMptKhGkMsejQ(android.content.object context, int i, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CbzRMptKhGkMsejQ(android.content.object context, int i, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CbzRMptKhGkMsejQ(android.content.object context, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CgdwVHQvkUjRseDh(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CgdwVHQvkUjRseDh(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CgdwVHQvkUjRseDh(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int[] CgdwVHQvkUjRseDh(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static int ChOyGYgjIacfWOMP(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static void ChOyGYgjIacfWOMP(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ChOyGYgjIacfWOMP(android.graphics.drawable.Drawable drawable, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ChOyGYgjIacfWOMP(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ChUnJGWjlRTFFehS(android.graphics.drawable.Drawable drawable, int[] iArr, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ChUnJGWjlRTFFehS(android.graphics.drawable.Drawable drawable, int[] iArr, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ChUnJGWjlRTFFehS(android.graphics.drawable.Drawable drawable, int[] iArr, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ChUnJGWjlRTFFehS(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static int CkbOwkWeKLgqpMzF(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(drawable);
    }

    public static void CkbOwkWeKLgqpMzF(android.graphics.drawable.Drawable drawable, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CkbOwkWeKLgqpMzF(android.graphics.drawable.Drawable drawable, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CkbOwkWeKLgqpMzF(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable CpMPPHQrFVqYQhAY(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void CpMPPHQrFVqYQhAY(android.graphics.drawable.Drawable drawable, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CpMPPHQrFVqYQhAY(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CpMPPHQrFVqYQhAY(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList CuehoqhyAmjKdyqy(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextColor();
    }

    public static void CuehoqhyAmjKdyqy(com.google.android.material.resources.TextAppearance textAppearance, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CuehoqhyAmjKdyqy(com.google.android.material.resources.TextAppearance textAppearance, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CuehoqhyAmjKdyqy(com.google.android.material.resources.TextAppearance textAppearance, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CzPuKRWQHIWlItwC(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect) {
        chipDrawable.drawChipSurface(canvas, rect);
    }

    public static void CzPuKRWQHIWlItwC(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CzPuKRWQHIWlItwC(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CzPuKRWQHIWlItwC(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DAhdDZsZpYvLqwaq(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void DAhdDZsZpYvLqwaq(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DAhdDZsZpYvLqwaq(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DAhdDZsZpYvLqwaq(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable DCrquyhRguYsEJAK(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void DCrquyhRguYsEJAK(android.content.object context, int i, char c, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DCrquyhRguYsEJAK(android.content.object context, int i, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DCrquyhRguYsEJAK(android.content.object context, int i, bool z, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DGcRpiAjVUyGLRug(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DGcRpiAjVUyGLRug(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DGcRpiAjVUyGLRug(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool DGcRpiAjVUyGLRug(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCheckedIcon();
    }

    public static android.graphics.ColorFilter DMpVySMTAwbVLhTh(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static void DMpVySMTAwbVLhTh(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DMpVySMTAwbVLhTh(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DMpVySMTAwbVLhTh(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DSJDDZBhaRxBJVCf(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getIntrinsicHeight();
    }

    public static void DSJDDZBhaRxBJVCf(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DSJDDZBhaRxBJVCf(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DSJDDZBhaRxBJVCf(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DjyVFZUDWZXiNfaL(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setTextColor(colorStateList);
    }

    public static void DjyVFZUDWZXiNfaL(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DjyVFZUDWZXiNfaL(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DjyVFZUDWZXiNfaL(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DoUsrGoYKBBjXLhw(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DoUsrGoYKBBjXLhw(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DoUsrGoYKBBjXLhw(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool DoUsrGoYKBBjXLhw(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static void DstlEedByryrcyHp(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void DstlEedByryrcyHp(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DstlEedByryrcyHp(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DstlEedByryrcyHp(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources DwAXnyLAMIxdvOoC(android.content.object context) {
        return context.getResources();
    }

    public static void DwAXnyLAMIxdvOoC(android.content.object context, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DwAXnyLAMIxdvOoC(android.content.object context, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DwAXnyLAMIxdvOoC(android.content.object context, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ECwrTpiHeJxmBJvP(int[] iArr, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ECwrTpiHeJxmBJvP(int[] iArr, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ECwrTpiHeJxmBJvP(int[] iArr, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ECwrTpiHeJxmBJvP(int[] iArr) {
        return com.google.android.material.ripple.RippleUtils.shouldDrawRippleCompat(iArr);
    }

    public static void EYTfyvHjlvaFnpdo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setCheckedIconTint(colorStateList);
    }

    public static void EYTfyvHjlvaFnpdo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EYTfyvHjlvaFnpdo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EYTfyvHjlvaFnpdo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EZVSgXmAKclUjhgn(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void EZVSgXmAKclUjhgn(android.graphics.Canvas canvas, int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EZVSgXmAKclUjhgn(android.graphics.Canvas canvas, int i, int i2, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EZVSgXmAKclUjhgn(android.graphics.Canvas canvas, int i, int i2, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList EaRtYpjKBkAreOLd(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextColor();
    }

    public static void EaRtYpjKBkAreOLd(com.google.android.material.resources.TextAppearance textAppearance, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EaRtYpjKBkAreOLd(com.google.android.material.resources.TextAppearance textAppearance, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EaRtYpjKBkAreOLd(com.google.android.material.resources.TextAppearance textAppearance, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ElpmAgcGQDcRxuiB(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void ElpmAgcGQDcRxuiB(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ElpmAgcGQDcRxuiB(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ElpmAgcGQDcRxuiB(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EoxuuNvxgOlkkKez(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void EoxuuNvxgOlkkKez(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EoxuuNvxgOlkkKez(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EoxuuNvxgOlkkKez(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float EsSykkKDNbjvxxpl(android.text.TextPaint textPaint, android.graphics.Paint$FontMetrics paint$FontMetrics) {
        return textPaint.getFontMetrics(paint$FontMetrics);
    }

    public static void EsSykkKDNbjvxxpl(android.text.TextPaint textPaint, android.graphics.Paint$FontMetrics paint$FontMetrics, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EsSykkKDNbjvxxpl(android.text.TextPaint textPaint, android.graphics.Paint$FontMetrics paint$FontMetrics, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EsSykkKDNbjvxxpl(android.text.TextPaint textPaint, android.graphics.Paint$FontMetrics paint$FontMetrics, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.RectF FBbRtAHaRfBzISGY(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getBoundsAsRectF();
    }

    public static void FBbRtAHaRfBzISGY(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FBbRtAHaRfBzISGY(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FBbRtAHaRfBzISGY(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FCPnxTGeOEhflTEv(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getLevel();
    }

    public static void FCPnxTGeOEhflTEv(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FCPnxTGeOEhflTEv(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FCPnxTGeOEhflTEv(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FGEWnoUTFLIKFFby(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.setCloseIcon(drawable);
    }

    public static void FGEWnoUTFLIKFFby(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FGEWnoUTFLIKFFby(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FGEWnoUTFLIKFFby(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FGxLoTwnKVJSOUuZ(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.unapplyChildDrawable(drawable);
    }

    public static void FGxLoTwnKVJSOUuZ(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FGxLoTwnKVJSOUuZ(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FGxLoTwnKVJSOUuZ(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FHWxDFEEyOzykESU(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void FHWxDFEEyOzykESU(android.graphics.Canvas canvas, float f, float f2, float f3, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FHWxDFEEyOzykESU(android.graphics.Canvas canvas, float f, float f2, float f3, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FHWxDFEEyOzykESU(android.graphics.Canvas canvas, float f, float f2, java.lang.string str, short s, float f3, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FUXuJFgdzqjCpyIG(int i, int i2) {
        return com.google.android.material.color.MaterialColors.layer(i, i2);
    }

    public static void FUXuJFgdzqjCpyIG(int i, int i2, char c, float f, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FUXuJFgdzqjCpyIG(int i, int i2, int i3, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FUXuJFgdzqjCpyIG(int i, int i2, int i3, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FYBuroLBQwPCnlXw(android.content.res.TypedArray typedArray, int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FYBuroLBQwPCnlXw(android.content.res.TypedArray typedArray, int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FYBuroLBQwPCnlXw(android.content.res.TypedArray typedArray, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool FYBuroLBQwPCnlXw(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.graphics.Rect GHtYEXsrChhgCCkp(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getBounds();
    }

    public static void GHtYEXsrChhgCCkp(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GHtYEXsrChhgCCkp(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GHtYEXsrChhgCCkp(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence GLXlbaNdNfJbELnf(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getText(i);
    }

    public static void GLXlbaNdNfJbELnf(android.content.res.TypedArray typedArray, int i, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GLXlbaNdNfJbELnf(android.content.res.TypedArray typedArray, int i, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GLXlbaNdNfJbELnf(android.content.res.TypedArray typedArray, int i, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.resources.TextAppearance GLvFvOGlaAGxwHou(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getTextAppearance();
    }

    public static void GLvFvOGlaAGxwHou(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GLvFvOGlaAGxwHou(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GLvFvOGlaAGxwHou(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect GNLkXxyCBWAckXdn(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static void GNLkXxyCBWAckXdn(android.graphics.drawable.Drawable drawable, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GNLkXxyCBWAckXdn(android.graphics.drawable.Drawable drawable, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GNLkXxyCBWAckXdn(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float GTAAGwyXNeiVxrHk(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void GTAAGwyXNeiVxrHk(android.content.res.TypedArray typedArray, int i, float f, int i2, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GTAAGwyXNeiVxrHk(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GTAAGwyXNeiVxrHk(android.content.res.TypedArray typedArray, int i, float f, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList GUtpBIpUrpKExOUQ(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getRippleColor();
    }

    public static void GUtpBIpUrpKExOUQ(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GUtpBIpUrpKExOUQ(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GUtpBIpUrpKExOUQ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GWbGcTBArOJkxNzu(android.graphics.drawable.Drawable drawable, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GWbGcTBArOJkxNzu(android.graphics.drawable.Drawable drawable, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GWbGcTBArOJkxNzu(android.graphics.drawable.Drawable drawable, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool GWbGcTBArOJkxNzu(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static void GkDvKuulTKUSptaQ(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint) {
        canvas.drawRect(rectF, paint);
    }

    public static void GkDvKuulTKUSptaQ(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GkDvKuulTKUSptaQ(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GkDvKuulTKUSptaQ(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList GrYjNrSHhXWXawxD(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void GrYjNrSHhXWXawxD(android.content.object context, int i, char c, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GrYjNrSHhXWXawxD(android.content.object context, int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GrYjNrSHhXWXawxD(android.content.object context, int i, int i2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GujBsaZMgViXFVtP(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void GujBsaZMgViXFVtP(android.graphics.Canvas canvas, int i, byte b, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GujBsaZMgViXFVtP(android.graphics.Canvas canvas, int i, char c, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GujBsaZMgViXFVtP(android.graphics.Canvas canvas, int i, int i2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float GvDoVSrmxcyHNBUU(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void GvDoVSrmxcyHNBUU(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GvDoVSrmxcyHNBUU(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GvDoVSrmxcyHNBUU(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources GzSpOTQKtENjgGLY(android.content.object context) {
        return context.getResources();
    }

    public static void GzSpOTQKtENjgGLY(android.content.object context, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GzSpOTQKtENjgGLY(android.content.object context, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GzSpOTQKtENjgGLY(android.content.object context, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float GzaxjhtHsWyIENlv(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void GzaxjhtHsWyIENlv(android.content.res.Resources resources, int i, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GzaxjhtHsWyIENlv(android.content.res.Resources resources, int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GzaxjhtHsWyIENlv(android.content.res.Resources resources, int i, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HBlupdVGOOpOpvpm(java.lang.object obj) {
        return obj.tostring();
    }

    public static void HBlupdVGOOpOpvpm(java.lang.object obj, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HBlupdVGOOpOpvpm(java.lang.object obj, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HBlupdVGOOpOpvpm(java.lang.object obj, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HFKvmhuMVNMJPWeI(android.graphics.drawable.Drawable drawable, int[] iArr, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HFKvmhuMVNMJPWeI(android.graphics.drawable.Drawable drawable, int[] iArr, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HFKvmhuMVNMJPWeI(android.graphics.drawable.Drawable drawable, int[] iArr, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HFKvmhuMVNMJPWeI(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void HGoJnzSKcXtvfHzo(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.setCloseIcon(drawable);
    }

    public static void HGoJnzSKcXtvfHzo(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HGoJnzSKcXtvfHzo(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HGoJnzSKcXtvfHzo(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HUOzxfBkpOuEarlO(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint) {
        canvas.drawRoundRect(rectF, f, f2, paint);
    }

    public static void HUOzxfBkpOuEarlO(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, char c, int i, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void HUOzxfBkpOuEarlO(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, int i, char c, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void HUOzxfBkpOuEarlO(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, int i, float f3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HWUSmBEFqqviJqJs(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.updateCompatRippleColor();
    }

    public static void HWUSmBEFqqviJqJs(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HWUSmBEFqqviJqJs(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HWUSmBEFqqviJqJs(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HXGySxVpzHIYWLYU(android.graphics.drawable.Drawable drawable, int i, int i2, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HXGySxVpzHIYWLYU(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HXGySxVpzHIYWLYU(android.graphics.drawable.Drawable drawable, int i, bool z, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool HXGySxVpzHIYWLYU(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
    }

    public static void HYJldkEGMinAOweP(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void HYJldkEGMinAOweP(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HYJldkEGMinAOweP(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HYJldkEGMinAOweP(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float HanPFaWqAEfAbnGo(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void HanPFaWqAEfAbnGo(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HanPFaWqAEfAbnGo(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HanPFaWqAEfAbnGo(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HcDhEVcIExQLoFsT(android.content.res.TypedArray typedArray, int i, bool z, float f, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HcDhEVcIExQLoFsT(android.content.res.TypedArray typedArray, int i, bool z, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HcDhEVcIExQLoFsT(android.content.res.TypedArray typedArray, int i, bool z, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool HcDhEVcIExQLoFsT(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void HmEzAqCKdVwbWTUK(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipEndPadding(f);
    }

    public static void HmEzAqCKdVwbWTUK(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, float f2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HmEzAqCKdVwbWTUK(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, short s, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HmEzAqCKdVwbWTUK(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static float HmKaykTrEgNJuKDV(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void HmKaykTrEgNJuKDV(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HmKaykTrEgNJuKDV(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HmKaykTrEgNJuKDV(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HnyAUXJzztCOSdKx(java.lang.object obj) {
        return obj.tostring();
    }

    public static void HnyAUXJzztCOSdKx(java.lang.object obj, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HnyAUXJzztCOSdKx(java.lang.object obj, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HnyAUXJzztCOSdKx(java.lang.object obj, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float HqfexYiBvrqWllae(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void HqfexYiBvrqWllae(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HqfexYiBvrqWllae(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HqfexYiBvrqWllae(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable HrEuoegalTOCVecA(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.unwrap(drawable);
    }

    public static void HrEuoegalTOCVecA(android.graphics.drawable.Drawable drawable, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HrEuoegalTOCVecA(android.graphics.drawable.Drawable drawable, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HrEuoegalTOCVecA(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.ColorFilter HutpqEJHjlrMTuDk(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getTintColorFilter();
    }

    public static void HutpqEJHjlrMTuDk(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HutpqEJHjlrMTuDk(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HutpqEJHjlrMTuDk(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float HvDSEcDcLYCzaAMr(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void HvDSEcDcLYCzaAMr(android.content.res.TypedArray typedArray, int i, float f, float f2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HvDSEcDcLYCzaAMr(android.content.res.TypedArray typedArray, int i, float f, float f2, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HvDSEcDcLYCzaAMr(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, bool z, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IAWUtYKsjWkbOuqd(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF) {
        chipDrawable.calculateChipIconBounds(rect, rectF);
    }

    public static void IAWUtYKsjWkbOuqd(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IAWUtYKsjWkbOuqd(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IAWUtYKsjWkbOuqd(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IJQomWbbJyuYJlVc(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IJQomWbbJyuYJlVc(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IJQomWbbJyuYJlVc(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IJQomWbbJyuYJlVc(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCheckedIcon();
    }

    public static android.content.res.Resources IKBhYjNVnkSoftLg(android.content.object context) {
        return context.getResources();
    }

    public static void IKBhYjNVnkSoftLg(android.content.object context, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IKBhYjNVnkSoftLg(android.content.object context, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IKBhYjNVnkSoftLg(android.content.object context, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ILMRqxjLEaiZvVRR(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void ILMRqxjLEaiZvVRR(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ILMRqxjLEaiZvVRR(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ILMRqxjLEaiZvVRR(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IMoCfbqMWzRdNazR(android.content.res.ColorStateList colorStateList, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IMoCfbqMWzRdNazR(android.content.res.ColorStateList colorStateList, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IMoCfbqMWzRdNazR(android.content.res.ColorStateList colorStateList, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool IMoCfbqMWzRdNazR(android.content.res.ColorStateList colorStateList) {
        return isStateful(colorStateList);
    }

    public static float INoXhHXYTPajxSIv(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void INoXhHXYTPajxSIv(android.content.res.Resources resources, int i, byte b, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void INoXhHXYTPajxSIv(android.content.res.Resources resources, int i, byte b, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void INoXhHXYTPajxSIv(android.content.res.Resources resources, int i, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IfxUEVCSOyCtqoNv(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setChipIconTint(colorStateList);
    }

    public static void IfxUEVCSOyCtqoNv(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IfxUEVCSOyCtqoNv(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IfxUEVCSOyCtqoNv(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IiBbDUWCYBbiFfKn(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.RectF rectF, android.graphics.Path path) {
        chipDrawable.calculatePathForSize(rectF, path);
    }

    public static void IiBbDUWCYBbiFfKn(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.RectF rectF, android.graphics.Path path, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IiBbDUWCYBbiFfKn(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.RectF rectF, android.graphics.Path path, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IiBbDUWCYBbiFfKn(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.RectF rectF, android.graphics.Path path, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.resources.TextAppearance IlwjdLJhHbPgADEU(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getTextAppearance(context, typedArray, i);
    }

    public static void IlwjdLJhHbPgADEU(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IlwjdLJhHbPgADEU(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IlwjdLJhHbPgADEU(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void InzJNiFfAsAMmhPb(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipIconSize(f);
    }

    public static void InzJNiFfAsAMmhPb(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void InzJNiFfAsAMmhPb(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void InzJNiFfAsAMmhPb(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ItLKTKowzHtilmju(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect) {
        chipDrawable.drawText(canvas, rect);
    }

    public static void ItLKTKowzHtilmju(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ItLKTKowzHtilmju(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ItLKTKowzHtilmju(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static float IvUeqAHMmjYtviAi(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void IvUeqAHMmjYtviAi(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IvUeqAHMmjYtviAi(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IvUeqAHMmjYtviAi(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JGLtgRcPMocsFfez(android.content.res.ColorStateList colorStateList, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JGLtgRcPMocsFfez(android.content.res.ColorStateList colorStateList, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JGLtgRcPMocsFfez(android.content.res.ColorStateList colorStateList, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JGLtgRcPMocsFfez(android.content.res.ColorStateList colorStateList) {
        return isStateful(colorStateList);
    }

    public static void JQoYGaRbFtnzJOrr(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance) {
        chipDrawable.setTextAppearance(textAppearance);
    }

    public static void JQoYGaRbFtnzJOrr(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JQoYGaRbFtnzJOrr(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JQoYGaRbFtnzJOrr(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float JRbUywGpWzrxRVDc(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void JRbUywGpWzrxRVDc(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JRbUywGpWzrxRVDc(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JRbUywGpWzrxRVDc(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JRbXQSJeHLMqvBJB(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, int i, float f, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void JRbXQSJeHLMqvBJB(android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JRbXQSJeHLMqvBJB(android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool JRbXQSJeHLMqvBJB(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void JTmBSOFqtHqhtVKc(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void JTmBSOFqtHqhtVKc(android.graphics.Paint paint, int i, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JTmBSOFqtHqhtVKc(android.graphics.Paint paint, int i, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JTmBSOFqtHqhtVKc(android.graphics.Paint paint, int i, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JVOibUvbNMVpvGEB(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCheckedIconVisible(z);
    }

    public static void JVOibUvbNMVpvGEB(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JVOibUvbNMVpvGEB(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JVOibUvbNMVpvGEB(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JeQSSigsIgjZfpFI(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void JeQSSigsIgjZfpFI(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JeQSSigsIgjZfpFI(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JeQSSigsIgjZfpFI(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources JkkJtWeafpEXIGgB(android.content.object context) {
        return context.getResources();
    }

    public static void JkkJtWeafpEXIGgB(android.content.object context, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JkkJtWeafpEXIGgB(android.content.object context, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JkkJtWeafpEXIGgB(android.content.object context, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JnfgomlVoLodDInC(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void JnfgomlVoLodDInC(android.graphics.Paint paint, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JnfgomlVoLodDInC(android.graphics.Paint paint, int i, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JnfgomlVoLodDInC(android.graphics.Paint paint, int i, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float JnwVyMzobQmnDdwJ(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void JnwVyMzobQmnDdwJ(android.content.res.TypedArray typedArray, int i, float f, bool z, float f2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JnwVyMzobQmnDdwJ(android.content.res.TypedArray typedArray, int i, float f, bool z, float f2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JnwVyMzobQmnDdwJ(android.content.res.TypedArray typedArray, int i, float f, bool z, short s, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JshdiFMvBMbyNZLs(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void JshdiFMvBMbyNZLs(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JshdiFMvBMbyNZLs(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JshdiFMvBMbyNZLs(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JyGHhEbnlvaWhBLt(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void JyGHhEbnlvaWhBLt(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JyGHhEbnlvaWhBLt(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JyGHhEbnlvaWhBLt(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float KCDGbXDmyAwTJSAr(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void KCDGbXDmyAwTJSAr(android.content.res.TypedArray typedArray, int i, float f, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KCDGbXDmyAwTJSAr(android.content.res.TypedArray typedArray, int i, float f, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KCDGbXDmyAwTJSAr(android.content.res.TypedArray typedArray, int i, float f, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KDJCygwvXUYnPBhw(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCheckable(z);
    }

    public static void KDJCygwvXUYnPBhw(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KDJCygwvXUYnPBhw(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KDJCygwvXUYnPBhw(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float KEIivRbLPQLpAdMM(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateTextCenterFromBaseline();
    }

    public static void KEIivRbLPQLpAdMM(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KEIivRbLPQLpAdMM(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KEIivRbLPQLpAdMM(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KHoCfUWivalGyysJ(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void KHoCfUWivalGyysJ(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, byte b, float f, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KHoCfUWivalGyysJ(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, byte b, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KHoCfUWivalGyysJ(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList KJUaypgDxhOnHCsr(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void KJUaypgDxhOnHCsr(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KJUaypgDxhOnHCsr(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KJUaypgDxhOnHCsr(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KLMnkXrQjWRucGce(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF) {
        chipDrawable.calculateCloseIconBounds(rect, rectF);
    }

    public static void KLMnkXrQjWRucGce(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KLMnkXrQjWRucGce(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KLMnkXrQjWRucGce(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KMfOiqRcBDPicCFF(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void KMfOiqRcBDPicCFF(android.content.res.ColorStateList colorStateList, int[] iArr, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KMfOiqRcBDPicCFF(android.content.res.ColorStateList colorStateList, int[] iArr, int i, short s, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KMfOiqRcBDPicCFF(android.content.res.ColorStateList colorStateList, int[] iArr, int i, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.resources.TextAppearance KNphdPWXwwHWJvwq(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextAppearance();
    }

    public static void KNphdPWXwwHWJvwq(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KNphdPWXwwHWJvwq(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KNphdPWXwwHWJvwq(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KXFPxohRljsUDiWF(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KXFPxohRljsUDiWF(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KXFPxohRljsUDiWF(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int[] KXFPxohRljsUDiWF(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static void KatuMGmgofOKXudV(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KatuMGmgofOKXudV(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KatuMGmgofOKXudV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KatuMGmgofOKXudV(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static void KcwKZqBQiRBCCiXB(android.graphics.drawable.Drawable drawable, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KcwKZqBQiRBCCiXB(android.graphics.drawable.Drawable drawable, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KcwKZqBQiRBCCiXB(android.graphics.drawable.Drawable drawable, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KcwKZqBQiRBCCiXB(android.graphics.drawable.Drawable drawable) {
        return isStateful(drawable);
    }

    public static com.google.android.material.resources.TextAppearance KhcXdDUAZnkrLMqn(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextAppearance();
    }

    public static void KhcXdDUAZnkrLMqn(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KhcXdDUAZnkrLMqn(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KhcXdDUAZnkrLMqn(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KlKPKEXyYAEEGJAX(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    public static void KlKPKEXyYAEEGJAX(android.graphics.drawable.Drawable drawable, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KlKPKEXyYAEEGJAX(android.graphics.drawable.Drawable drawable, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KlKPKEXyYAEEGJAX(android.graphics.drawable.Drawable drawable, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float KoUnqLqgBhvXlgWJ(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void KoUnqLqgBhvXlgWJ(android.content.res.Resources resources, int i, char c, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KoUnqLqgBhvXlgWJ(android.content.res.Resources resources, int i, int i2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KoUnqLqgBhvXlgWJ(android.content.res.Resources resources, int i, java.lang.string str, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KqSjTsTaTHTpRufl(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF) {
        chipDrawable.calculateChipIconBounds(rect, rectF);
    }

    public static void KqSjTsTaTHTpRufl(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KqSjTsTaTHTpRufl(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KqSjTsTaTHTpRufl(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static float KtktOtigjbSMYTaL(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void KtktOtigjbSMYTaL(android.content.res.TypedArray typedArray, int i, float f, char c, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KtktOtigjbSMYTaL(android.content.res.TypedArray typedArray, int i, float f, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KtktOtigjbSMYTaL(android.content.res.TypedArray typedArray, int i, float f, short s, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LHTOLaBNAjeWTaVf(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LHTOLaBNAjeWTaVf(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LHTOLaBNAjeWTaVf(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool LHTOLaBNAjeWTaVf(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.onStateChange(iArr);
    }

    public static void LHgHruFaZZnejBmg(android.graphics.drawable.Drawable drawable, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LHgHruFaZZnejBmg(android.graphics.drawable.Drawable drawable, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LHgHruFaZZnejBmg(android.graphics.drawable.Drawable drawable, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool LHgHruFaZZnejBmg(android.graphics.drawable.Drawable drawable) {
        return isStateful(drawable);
    }

    public static float LLIDDzlcNUiCZzua(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void LLIDDzlcNUiCZzua(android.content.res.TypedArray typedArray, int i, float f, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LLIDDzlcNUiCZzua(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LLIDDzlcNUiCZzua(android.content.res.TypedArray typedArray, int i, float f, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint LOlRdrjIdfxpOcof(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void LOlRdrjIdfxpOcof(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LOlRdrjIdfxpOcof(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LOlRdrjIdfxpOcof(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LYrkCqxnJGAzyaKc(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setIconStartPadding(f);
    }

    public static void LYrkCqxnJGAzyaKc(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, java.lang.string str, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LYrkCqxnJGAzyaKc(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LYrkCqxnJGAzyaKc(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, bool z, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LZQEkCabEEDOmHQS(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LZQEkCabEEDOmHQS(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LZQEkCabEEDOmHQS(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LZQEkCabEEDOmHQS(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCheckedIcon();
    }

    public static void LpaOYurKICIawXNn(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LpaOYurKICIawXNn(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LpaOYurKICIawXNn(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] LpaOYurKICIawXNn(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static void LqSuaQqzWLdDPOmQ(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void LqSuaQqzWLdDPOmQ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LqSuaQqzWLdDPOmQ(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqSuaQqzWLdDPOmQ(com.google.android.material.chip.ChipDrawable chipDrawable, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LqsipEbryRrXrJqT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.setCheckedIcon(drawable);
    }

    public static void LqsipEbryRrXrJqT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqsipEbryRrXrJqT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqsipEbryRrXrJqT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList LqzWtlrnLxGpvipr(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void LqzWtlrnLxGpvipr(android.content.object context, int i, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqzWtlrnLxGpvipr(android.content.object context, int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqzWtlrnLxGpvipr(android.content.object context, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources LsYojdZZznnbCBzp(android.content.object context) {
        return context.getResources();
    }

    public static void LsYojdZZznnbCBzp(android.content.object context, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LsYojdZZznnbCBzp(android.content.object context, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LsYojdZZznnbCBzp(android.content.object context, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LujSxHqZuHyyGxgY(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void LujSxHqZuHyyGxgY(android.content.res.Resources resources, int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LujSxHqZuHyyGxgY(android.content.res.Resources resources, int i, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LujSxHqZuHyyGxgY(android.content.res.Resources resources, int i, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MMsZqSYcjFGvDYYd(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCheckedIconVisible(z);
    }

    public static void MMsZqSYcjFGvDYYd(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MMsZqSYcjFGvDYYd(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MMsZqSYcjFGvDYYd(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence MWEUaPmmqGoWtKee(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getText();
    }

    public static void MWEUaPmmqGoWtKee(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MWEUaPmmqGoWtKee(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MWEUaPmmqGoWtKee(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.chip.ChipDrawable MXhADcwrDvOtUzvB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return createFromAttributes(context, attributeHashSet, i, i2);
    }

    public static void MXhADcwrDvOtUzvB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MXhADcwrDvOtUzvB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MXhADcwrDvOtUzvB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MYLWcQaubxAQGLbo(android.content.res.TypedArray typedArray, int i, bool z, byte b, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MYLWcQaubxAQGLbo(android.content.res.TypedArray typedArray, int i, bool z, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MYLWcQaubxAQGLbo(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MYLWcQaubxAQGLbo(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static float MajZwWXYVuiOsFXR(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipCornerRadius();
    }

    public static void MajZwWXYVuiOsFXR(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MajZwWXYVuiOsFXR(com.google.android.material.chip.ChipDrawable chipDrawable, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MajZwWXYVuiOsFXR(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MfsZJwpkEttQcBoa(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void MfsZJwpkEttQcBoa(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MfsZJwpkEttQcBoa(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MfsZJwpkEttQcBoa(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MsxLpPMsapBRqLfF(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void MsxLpPMsapBRqLfF(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MsxLpPMsapBRqLfF(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MsxLpPMsapBRqLfF(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MutibapkuEDfUWOm(android.content.res.ColorStateList colorStateList, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MutibapkuEDfUWOm(android.content.res.ColorStateList colorStateList, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MutibapkuEDfUWOm(android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MutibapkuEDfUWOm(android.content.res.ColorStateList colorStateList) {
        return isStateful(colorStateList);
    }

    public static float MxCzMatNAGQCzhxD(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void MxCzMatNAGQCzhxD(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MxCzMatNAGQCzhxD(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MxCzMatNAGQCzhxD(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MxcnmelutFqDTWpF(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MxcnmelutFqDTWpF(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MxcnmelutFqDTWpF(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool MxcnmelutFqDTWpF(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.canShowCheckedIcon();
    }

    public static void NCLGyoVdQzxQKvvC(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.unapplyChildDrawable(drawable);
    }

    public static void NCLGyoVdQzxQKvvC(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NCLGyoVdQzxQKvvC(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NCLGyoVdQzxQKvvC(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NGdjNWDBzWSAWnPV(android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NGdjNWDBzWSAWnPV(android.content.res.ColorStateList colorStateList, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NGdjNWDBzWSAWnPV(android.content.res.ColorStateList colorStateList, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NGdjNWDBzWSAWnPV(android.content.res.ColorStateList colorStateList) {
        return isStateful(colorStateList);
    }

    public static void NVFCxyLeozkbTqDj(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NVFCxyLeozkbTqDj(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NVFCxyLeozkbTqDj(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NVFCxyLeozkbTqDj(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsChipIcon();
    }

    public static void NXCiWBXuJnYGHXzS(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setCloseIconTint(colorStateList);
    }

    public static void NXCiWBXuJnYGHXzS(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NXCiWBXuJnYGHXzS(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NXCiWBXuJnYGHXzS(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NhGKSwYlXHIELLcH(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NhGKSwYlXHIELLcH(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NhGKSwYlXHIELLcH(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NhGKSwYlXHIELLcH(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsChipIcon();
    }

    public static void NtRnKzqqwGdTUYyu(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void NtRnKzqqwGdTUYyu(android.graphics.Paint paint, int i, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NtRnKzqqwGdTUYyu(android.graphics.Paint paint, int i, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NtRnKzqqwGdTUYyu(android.graphics.Paint paint, int i, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NyxEnRIbYQqHKqVe(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        chipDrawable.setEllipsize(textUtils$TruncateAt);
    }

    public static void NyxEnRIbYQqHKqVe(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NyxEnRIbYQqHKqVe(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NyxEnRIbYQqHKqVe(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NzaeFPbjeVAYpXnv(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.setChipIcon(drawable);
    }

    public static void NzaeFPbjeVAYpXnv(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NzaeFPbjeVAYpXnv(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NzaeFPbjeVAYpXnv(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList NzjsiaiYYwhUiefl(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void NzjsiaiYYwhUiefl(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NzjsiaiYYwhUiefl(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NzjsiaiYYwhUiefl(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable OGeksAuyVasyKCgf(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCloseIcon();
    }

    public static void OGeksAuyVasyKCgf(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OGeksAuyVasyKCgf(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OGeksAuyVasyKCgf(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OHswlVswvYldliOb(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static void OHswlVswvYldliOb(android.graphics.RectF rectF, android.graphics.Rect rect, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OHswlVswvYldliOb(android.graphics.RectF rectF, android.graphics.Rect rect, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OHswlVswvYldliOb(android.graphics.RectF rectF, android.graphics.Rect rect, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float OJzSqsAyVVDSPhfR(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void OJzSqsAyVVDSPhfR(android.graphics.RectF rectF, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OJzSqsAyVVDSPhfR(android.graphics.RectF rectF, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OJzSqsAyVVDSPhfR(android.graphics.RectF rectF, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OPUwzGkIsefxjrjn(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setCloseIconVisible(i);
    }

    public static void OPUwzGkIsefxjrjn(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OPUwzGkIsefxjrjn(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OPUwzGkIsefxjrjn(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable OUrpVSdAGVYPjOKv(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void OUrpVSdAGVYPjOKv(android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OUrpVSdAGVYPjOKv(android.graphics.drawable.Drawable drawable, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OUrpVSdAGVYPjOKv(android.graphics.drawable.Drawable drawable, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float OUwdtfQlShxblPXe(android.graphics.Rect rect) {
        return rect.exactCenterY();
    }

    public static void OUwdtfQlShxblPXe(android.graphics.Rect rect, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OUwdtfQlShxblPXe(android.graphics.Rect rect, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OUwdtfQlShxblPXe(android.graphics.Rect rect, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OcijcPvxSzJPhaTF(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void OcijcPvxSzJPhaTF(int i, int i2, int i3, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OcijcPvxSzJPhaTF(int i, int i2, int i3, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OcijcPvxSzJPhaTF(int i, int i2, bool z, java.lang.string str, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void OdiQDVvvQCfCzXaC(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void OdiQDVvvQCfCzXaC(android.graphics.Paint paint, int i, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OdiQDVvvQCfCzXaC(android.graphics.Paint paint, int i, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OdiQDVvvQCfCzXaC(android.graphics.Paint paint, int i, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OePCgRNIJYjNsKUB(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void OePCgRNIJYjNsKUB(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OePCgRNIJYjNsKUB(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OePCgRNIJYjNsKUB(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OhJAkGNaIYYsHLsy(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable) {
        drawable$Callback.invalidateDrawable(drawable);
    }

    public static void OhJAkGNaIYYsHLsy(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OhJAkGNaIYYsHLsy(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OhJAkGNaIYYsHLsy(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OhhjtAsoPeTsZmov(android.graphics.drawable.Drawable drawable, int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OhhjtAsoPeTsZmov(android.graphics.drawable.Drawable drawable, int i, byte b, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OhhjtAsoPeTsZmov(android.graphics.drawable.Drawable drawable, int i, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OhhjtAsoPeTsZmov(android.graphics.drawable.Drawable drawable, int i) {
        return drawable.setLevel(i);
    }

    public static void OvJrgsLREIHaRhXa(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static void OvJrgsLREIHaRhXa(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OvJrgsLREIHaRhXa(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OvJrgsLREIHaRhXa(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OwZKPhgYABZMsmdX(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void OwZKPhgYABZMsmdX(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OwZKPhgYABZMsmdX(android.content.res.ColorStateList colorStateList, int[] iArr, int i, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OwZKPhgYABZMsmdX(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable PGoGBElPGygRPvOs(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void PGoGBElPGygRPvOs(android.graphics.drawable.Drawable drawable, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PGoGBElPGygRPvOs(android.graphics.drawable.Drawable drawable, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PGoGBElPGygRPvOs(android.graphics.drawable.Drawable drawable, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PJWZiAhrcfyvRBKw(int[] iArr, int i, byte b, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PJWZiAhrcfyvRBKw(int[] iArr, int i, float f, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PJWZiAhrcfyvRBKw(int[] iArr, int i, float f, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PJWZiAhrcfyvRBKw(int[] iArr, int i) {
        return hasState(iArr, i);
    }

    public static void PKYHaCQEekMOWrVK(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF) {
        chipDrawable.calculateChipTouchBounds(rect, rectF);
    }

    public static void PKYHaCQEekMOWrVK(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PKYHaCQEekMOWrVK(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PKYHaCQEekMOWrVK(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PLxMKimDIxHKloVX(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void PLxMKimDIxHKloVX(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PLxMKimDIxHKloVX(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PLxMKimDIxHKloVX(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void POzRAHInJCPKBRdA(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void POzRAHInJCPKBRdA(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void POzRAHInJCPKBRdA(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void POzRAHInJCPKBRdA(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PPBmCPIgHtvVmjKz(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void PPBmCPIgHtvVmjKz(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PPBmCPIgHtvVmjKz(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PPBmCPIgHtvVmjKz(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PRyYiwQaBqzGfQTL(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void PRyYiwQaBqzGfQTL(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PRyYiwQaBqzGfQTL(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PRyYiwQaBqzGfQTL(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PUDsItoaooDQUPwZ(android.graphics.drawable.Drawable drawable, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PUDsItoaooDQUPwZ(android.graphics.drawable.Drawable drawable, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PUDsItoaooDQUPwZ(android.graphics.drawable.Drawable drawable, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PUDsItoaooDQUPwZ(android.graphics.drawable.Drawable drawable) {
        return isStateful(drawable);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel PUZgkytQzngaQxog(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getShapeAppearanceModel();
    }

    public static void PUZgkytQzngaQxog(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PUZgkytQzngaQxog(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PUZgkytQzngaQxog(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PWDSWHpWSCyjliUB(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setRippleColor(colorStateList);
    }

    public static void PWDSWHpWSCyjliUB(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PWDSWHpWSCyjliUB(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PWDSWHpWSCyjliUB(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PXyLCdlKPQUXBKpB(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setCloseIconSize(f);
    }

    public static void PXyLCdlKPQUXBKpB(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, float f2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PXyLCdlKPQUXBKpB(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, byte b, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PXyLCdlKPQUXBKpB(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, float f2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float PagpfagNKHLVNqel(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void PagpfagNKHLVNqel(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PagpfagNKHLVNqel(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PagpfagNKHLVNqel(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel PbwQFBxhMtYucEAn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f) {
        return shapeAppearanceModel.withCornerSize(f);
    }

    public static void PbwQFBxhMtYucEAn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PbwQFBxhMtYucEAn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PbwQFBxhMtYucEAn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PhycEkOADQRfRQSf(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PhycEkOADQRfRQSf(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PhycEkOADQRfRQSf(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PhycEkOADQRfRQSf(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static void PlSdsynxMorVllhw(android.graphics.Outline outline, android.graphics.Rect rect, float f) {
        outline.setRoundRect(rect, f);
    }

    public static void PlSdsynxMorVllhw(android.graphics.Outline outline, android.graphics.Rect rect, float f, byte b, float f2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PlSdsynxMorVllhw(android.graphics.Outline outline, android.graphics.Rect rect, float f, char c, float f2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PlSdsynxMorVllhw(android.graphics.Outline outline, android.graphics.Rect rect, float f, float f2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PozOUzNPLLvLDjyb(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void PozOUzNPLLvLDjyb(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PozOUzNPLLvLDjyb(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PozOUzNPLLvLDjyb(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint PtvSspmYrRctkPmL(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void PtvSspmYrRctkPmL(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PtvSspmYrRctkPmL(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PtvSspmYrRctkPmL(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float QAIlBAJpVBKognch(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void QAIlBAJpVBKognch(android.content.res.Resources resources, int i, byte b, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QAIlBAJpVBKognch(android.content.res.Resources resources, int i, float f, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QAIlBAJpVBKognch(android.content.res.Resources resources, int i, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QDTaTZMfRaPlnJKI(android.graphics.drawable.Drawable drawable, int[] iArr, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QDTaTZMfRaPlnJKI(android.graphics.drawable.Drawable drawable, int[] iArr, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QDTaTZMfRaPlnJKI(android.graphics.drawable.Drawable drawable, int[] iArr, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool QDTaTZMfRaPlnJKI(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void QGHKpROGYomHeAFA(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.applyChildDrawable(drawable);
    }

    public static void QGHKpROGYomHeAFA(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QGHKpROGYomHeAFA(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QGHKpROGYomHeAFA(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QKtZrWZnmjRpnmlC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, float f, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QKtZrWZnmjRpnmlC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QKtZrWZnmjRpnmlC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, short s, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool QKtZrWZnmjRpnmlC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        return super.onLevelChange(i);
    }

    public static android.text.TextPaint QMRfuYobrMgnDODM(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void QMRfuYobrMgnDODM(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QMRfuYobrMgnDODM(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QMRfuYobrMgnDODM(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QWyGazPKuwWTPUUq(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void QWyGazPKuwWTPUUq(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QWyGazPKuwWTPUUq(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QWyGazPKuwWTPUUq(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QclnYkSfWnOlDylM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QclnYkSfWnOlDylM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, java.lang.string str, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QclnYkSfWnOlDylM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QclnYkSfWnOlDylM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        return super.onLayoutDirectionChanged(i);
    }

    public static void QhkDiDUqozzWGuBe(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void QhkDiDUqozzWGuBe(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QhkDiDUqozzWGuBe(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QhkDiDUqozzWGuBe(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QiautWYKniKqZTFf(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.unapplyChildDrawable(drawable);
    }

    public static void QiautWYKniKqZTFf(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QiautWYKniKqZTFf(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QiautWYKniKqZTFf(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QjSLJOjYUwJZfQZY(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.unapplyChildDrawable(drawable);
    }

    public static void QjSLJOjYUwJZfQZY(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QjSLJOjYUwJZfQZY(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QjSLJOjYUwJZfQZY(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float QkEPFyFQJsJvesBy(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void QkEPFyFQJsJvesBy(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QkEPFyFQJsJvesBy(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QkEPFyFQJsJvesBy(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QoQjtqZASdCtOfCH(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void QoQjtqZASdCtOfCH(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, float f, bool z, char c, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void QoQjtqZASdCtOfCH(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, int i4, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QoQjtqZASdCtOfCH(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, bool z, int i4, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QqPxRYoPOtJbLlEa(android.graphics.Outline outline, float f) {
        outline.setAlpha(f);
    }

    public static void QqPxRYoPOtJbLlEa(android.graphics.Outline outline, float f, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QqPxRYoPOtJbLlEa(android.graphics.Outline outline, float f, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QqPxRYoPOtJbLlEa(android.graphics.Outline outline, float f, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QtPazuLnwzqJimZy(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QtPazuLnwzqJimZy(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QtPazuLnwzqJimZy(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool QtPazuLnwzqJimZy(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsChipIcon();
    }

    public static float QtYmWdGWVMBTpnrD(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str) {
        return textDrawableHelper.getTextWidth(str);
    }

    public static void QtYmWdGWVMBTpnrD(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, java.lang.string str2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QtYmWdGWVMBTpnrD(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, bool z, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QtYmWdGWVMBTpnrD(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, bool z, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RAgcgbOlKfDBPxLl(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCloseIconVisible(z);
    }

    public static void RAgcgbOlKfDBPxLl(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void RAgcgbOlKfDBPxLl(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RAgcgbOlKfDBPxLl(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, bool z2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RDyRfAoNoUbZDSre(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RDyRfAoNoUbZDSre(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RDyRfAoNoUbZDSre(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RDyRfAoNoUbZDSre(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.setCloseIconState(iArr);
    }

    public static int RTqOYvQdrQrzEqvv(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        return chipDrawable.compositeElevationOverlayIfNeeded(i);
    }

    public static void RTqOYvQdrQrzEqvv(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RTqOYvQdrQrzEqvv(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RTqOYvQdrQrzEqvv(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RkYYofNHCgJZwreE(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCloseIconVisible(z);
    }

    public static void RkYYofNHCgJZwreE(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RkYYofNHCgJZwreE(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RkYYofNHCgJZwreE(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RvtKBSMjUxteTNzE(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setCloseIconEndPadding(f);
    }

    public static void RvtKBSMjUxteTNzE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, char c, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RvtKBSMjUxteTNzE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, char c, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RvtKBSMjUxteTNzE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, float f2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RytaNOQvwPPuZldd(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(drawable);
    }

    public static void RytaNOQvwPPuZldd(android.graphics.drawable.Drawable drawable, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RytaNOQvwPPuZldd(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RytaNOQvwPPuZldd(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SDwiwixvXvcpNYYU(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint) {
        canvas.drawRoundRect(rectF, f, f2, paint);
    }

    public static void SDwiwixvXvcpNYYU(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SDwiwixvXvcpNYYU(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SDwiwixvXvcpNYYU(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList SGJDMWbQTNFmlULK(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void SGJDMWbQTNFmlULK(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SGJDMWbQTNFmlULK(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SGJDMWbQTNFmlULK(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec SINprxsIwsTiNjgl(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.animation.MotionSpec.createFromAttribute(context, typedArray, i);
    }

    public static void SINprxsIwsTiNjgl(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SINprxsIwsTiNjgl(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SINprxsIwsTiNjgl(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int SNlqWWRzBnYlKhKc(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(drawable);
    }

    public static void SNlqWWRzBnYlKhKc(android.graphics.drawable.Drawable drawable, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SNlqWWRzBnYlKhKc(android.graphics.drawable.Drawable drawable, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SNlqWWRzBnYlKhKc(android.graphics.drawable.Drawable drawable, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable SWELxRhqtsKCMbIs(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipIcon();
    }

    public static void SWELxRhqtsKCMbIs(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SWELxRhqtsKCMbIs(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SWELxRhqtsKCMbIs(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static float SXzQZaDXJBDyFWGS(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void SXzQZaDXJBDyFWGS(android.content.res.TypedArray typedArray, int i, float f, float f2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SXzQZaDXJBDyFWGS(android.content.res.TypedArray typedArray, int i, float f, short s, float f2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SXzQZaDXJBDyFWGS(android.content.res.TypedArray typedArray, int i, float f, bool z, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static float ScsbFJlgoswaCvgW(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void ScsbFJlgoswaCvgW(android.graphics.RectF rectF, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ScsbFJlgoswaCvgW(android.graphics.RectF rectF, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ScsbFJlgoswaCvgW(android.graphics.RectF rectF, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources SfOaOfoESbCSENCR(android.content.object context) {
        return context.getResources();
    }

    public static void SfOaOfoESbCSENCR(android.content.object context, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SfOaOfoESbCSENCR(android.content.object context, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SfOaOfoESbCSENCR(android.content.object context, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$Callback SgqdOkmgKyWHugAB(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCallback();
    }

    public static void SgqdOkmgKyWHugAB(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SgqdOkmgKyWHugAB(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SgqdOkmgKyWHugAB(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SguuPefRUaFQwQhr(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void SguuPefRUaFQwQhr(android.content.res.TypedArray typedArray, int i, int i2, int i3, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SguuPefRUaFQwQhr(android.content.res.TypedArray typedArray, int i, int i2, int i3, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SguuPefRUaFQwQhr(android.content.res.TypedArray typedArray, int i, int i2, short s, int i3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable SkxXUVOMxswowPbA(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void SkxXUVOMxswowPbA(android.content.object context, int i, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkxXUVOMxswowPbA(android.content.object context, int i, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SkxXUVOMxswowPbA(android.content.object context, int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SoDNhkQFmZlKOiaL(android.content.res.Resources resources, int i, java.lang.string str, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SoDNhkQFmZlKOiaL(android.content.res.Resources resources, int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SoDNhkQFmZlKOiaL(android.content.res.Resources resources, int i, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SoDNhkQFmZlKOiaL(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    public static void SsORIMVvDuouNoLM(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void SsORIMVvDuouNoLM(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SsORIMVvDuouNoLM(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SsORIMVvDuouNoLM(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SsZjWXNaQUTsnrPy(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static void SsZjWXNaQUTsnrPy(android.graphics.RectF rectF, android.graphics.Rect rect, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SsZjWXNaQUTsnrPy(android.graphics.RectF rectF, android.graphics.Rect rect, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SsZjWXNaQUTsnrPy(android.graphics.RectF rectF, android.graphics.Rect rect, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TFRpunvMYIRzygdB(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipCornerRadius(f);
    }

    public static void TFRpunvMYIRzygdB(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TFRpunvMYIRzygdB(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void TFRpunvMYIRzygdB(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable TJnYADOWNyBABXiL(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getDrawable(context, typedArray, i);
    }

    public static void TJnYADOWNyBABXiL(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TJnYADOWNyBABXiL(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TJnYADOWNyBABXiL(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TKxKTWztbjTKtdAv(android.content.res.Resources resources, int i, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TKxKTWztbjTKtdAv(android.content.res.Resources resources, int i, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TKxKTWztbjTKtdAv(android.content.res.Resources resources, int i, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TKxKTWztbjTKtdAv(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    public static float TQnwfNGRhQbjfpZx(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void TQnwfNGRhQbjfpZx(android.content.res.Resources resources, int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TQnwfNGRhQbjfpZx(android.content.res.Resources resources, int i, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TQnwfNGRhQbjfpZx(android.content.res.Resources resources, int i, bool z, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList TjHSbVQNiRLOyIyG(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void TjHSbVQNiRLOyIyG(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TjHSbVQNiRLOyIyG(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TjHSbVQNiRLOyIyG(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TppvrwZHUAPDmFRq(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipIconVisible(i);
    }

    public static void TppvrwZHUAPDmFRq(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TppvrwZHUAPDmFRq(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TppvrwZHUAPDmFRq(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TslhUirHnVbUgHMz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, bool z2, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TslhUirHnVbUgHMz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, bool z2, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TslhUirHnVbUgHMz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, bool z2, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TslhUirHnVbUgHMz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, bool z2) {
        return super.setVisible(z, z2);
    }

    public static android.content.res.Resources TtPrOtnAgajsMBME(android.content.object context) {
        return context.getResources();
    }

    public static void TtPrOtnAgajsMBME(android.content.object context, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TtPrOtnAgajsMBME(android.content.object context, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TtPrOtnAgajsMBME(android.content.object context, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources TyzRqVhaNYvVXNjc(android.content.object context) {
        return context.getResources();
    }

    public static void TyzRqVhaNYvVXNjc(android.content.object context, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TyzRqVhaNYvVXNjc(android.content.object context, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TyzRqVhaNYvVXNjc(android.content.object context, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UIPxDWVyMHoYoDdj(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipEndPadding(f);
    }

    public static void UIPxDWVyMHoYoDdj(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UIPxDWVyMHoYoDdj(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UIPxDWVyMHoYoDdj(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static float UNZXHydQTcJnRoFA(android.graphics.Rect rect) {
        return rect.exactCenterY();
    }

    public static void UNZXHydQTcJnRoFA(android.graphics.Rect rect, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UNZXHydQTcJnRoFA(android.graphics.Rect rect, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UNZXHydQTcJnRoFA(android.graphics.Rect rect, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UdZQiERCfpivAZzj(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.applyChildDrawable(drawable);
    }

    public static void UdZQiERCfpivAZzj(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UdZQiERCfpivAZzj(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UdZQiERCfpivAZzj(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UrdqCSLzlICiQJAh(float f) {
        return java.lang.Math.round(f);
    }

    public static void UrdqCSLzlICiQJAh(float f, float f2, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UrdqCSLzlICiQJAh(float f, int i, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void UrdqCSLzlICiQJAh(float f, java.lang.string str, float f2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UtYoUmtzucFqEbgG(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UtYoUmtzucFqEbgG(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UtYoUmtzucFqEbgG(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UtYoUmtzucFqEbgG(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.onStateChange(iArr);
    }

    public static void UwDdzFldPfRMxdDj(android.graphics.drawable.Drawable drawable, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UwDdzFldPfRMxdDj(android.graphics.drawable.Drawable drawable, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UwDdzFldPfRMxdDj(android.graphics.drawable.Drawable drawable, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool UwDdzFldPfRMxdDj(android.graphics.drawable.Drawable drawable) {
        return isStateful(drawable);
    }

    public static void VCSCPTdHcdYWbiOa(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSize(f);
    }

    public static void VCSCPTdHcdYWbiOa(android.text.TextPaint textPaint, float f, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VCSCPTdHcdYWbiOa(android.text.TextPaint textPaint, float f, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VCSCPTdHcdYWbiOa(android.text.TextPaint textPaint, float f, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VISbtJJSVzvivkaf(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, int i) {
        return com.google.android.material.canvas.CanvasCompat.saveLayerAlpha(canvas, f, f2, f3, f4, i);
    }

    public static void VISbtJJSVzvivkaf(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, int i, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VISbtJJSVzvivkaf(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, int i, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VISbtJJSVzvivkaf(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VTdPOoOEWnluSdHk(android.graphics.RectF rectF) {
        rectF.setEmpty();
    }

    public static void VTdPOoOEWnluSdHk(android.graphics.RectF rectF, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VTdPOoOEWnluSdHk(android.graphics.RectF rectF, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VTdPOoOEWnluSdHk(android.graphics.RectF rectF, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string VVwxPKVRJCjOGlVq(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void VVwxPKVRJCjOGlVq(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, byte b, char c, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void VVwxPKVRJCjOGlVq(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, java.lang.string str3, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VVwxPKVRJCjOGlVq(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, short s, byte b, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VYKmGWlXMmbOEvdw(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        chipDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void VYKmGWlXMmbOEvdw(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VYKmGWlXMmbOEvdw(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VYKmGWlXMmbOEvdw(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VhxUBhZMurdlKIMx(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onTextSizeChange();
    }

    public static void VhxUBhZMurdlKIMx(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VhxUBhZMurdlKIMx(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VhxUBhZMurdlKIMx(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VnZLCjWcVnYuiiNO(android.graphics.drawable.Drawable drawable, int i, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VnZLCjWcVnYuiiNO(android.graphics.drawable.Drawable drawable, int i, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VnZLCjWcVnYuiiNO(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VnZLCjWcVnYuiiNO(android.graphics.drawable.Drawable drawable, int i) {
        return drawable.setLevel(i);
    }

    public static void VqOVsZSeOCEiOeoa(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VqOVsZSeOCEiOeoa(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VqOVsZSeOCEiOeoa(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VqOVsZSeOCEiOeoa(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return android.text.TextUtils.Equals(charSequence, charSequence2);
    }

    public static void VxgMWesIAoxALzDa(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void VxgMWesIAoxALzDa(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VxgMWesIAoxALzDa(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VxgMWesIAoxALzDa(com.google.android.material.chip.ChipDrawable chipDrawable, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VycNHBDEnjegXzUK(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void VycNHBDEnjegXzUK(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VycNHBDEnjegXzUK(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VycNHBDEnjegXzUK(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WHUDyKoTwWxsYQxF(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void WHUDyKoTwWxsYQxF(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WHUDyKoTwWxsYQxF(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WHUDyKoTwWxsYQxF(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WMvconkFYOAlvkYv(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCheckedIconVisible(z);
    }

    public static void WMvconkFYOAlvkYv(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WMvconkFYOAlvkYv(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WMvconkFYOAlvkYv(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WOJcJwUWoQalgNnO(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void WOJcJwUWoQalgNnO(android.graphics.Canvas canvas, float f, float f2, float f3, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WOJcJwUWoQalgNnO(android.graphics.Canvas canvas, float f, float f2, int i, byte b, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WOJcJwUWoQalgNnO(android.graphics.Canvas canvas, float f, float f2, int i, float f3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float WSYywEixJufngFEK(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getTopLeftCornerResolvedSize();
    }

    public static void WSYywEixJufngFEK(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WSYywEixJufngFEK(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WSYywEixJufngFEK(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WXEmwslZnMsTjDfg(android.graphics.drawable.Drawable drawable, int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WXEmwslZnMsTjDfg(android.graphics.drawable.Drawable drawable, int i, int i2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WXEmwslZnMsTjDfg(android.graphics.drawable.Drawable drawable, int i, short s, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WXEmwslZnMsTjDfg(android.graphics.drawable.Drawable drawable, int i) {
        return drawable.setLevel(i);
    }

    public static android.text.TextPaint WdKDZKoXyUKOZLTR(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void WdKDZKoXyUKOZLTR(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WdKDZKoXyUKOZLTR(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WdKDZKoXyUKOZLTR(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WhOyAjWGtmAwDjcg(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WhOyAjWGtmAwDjcg(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WhOyAjWGtmAwDjcg(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool WhOyAjWGtmAwDjcg(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static android.graphics.drawable.Drawable WkKKhYbsYDsYMTrU(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getDrawable(context, typedArray, i);
    }

    public static void WkKKhYbsYDsYMTrU(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WkKKhYbsYDsYMTrU(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WkKKhYbsYDsYMTrU(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WsWVleXRIRyVduLx(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WsWVleXRIRyVduLx(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WsWVleXRIRyVduLx(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool WsWVleXRIRyVduLx(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.isChipIconVisible();
    }

    public static int WxDADBOOcUPLqGKJ(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void WxDADBOOcUPLqGKJ(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WxDADBOOcUPLqGKJ(android.content.res.ColorStateList colorStateList, int[] iArr, int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WxDADBOOcUPLqGKJ(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XDCwujHYFQVEjVkG(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setStrokeColor(colorStateList);
    }

    public static void XDCwujHYFQVEjVkG(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XDCwujHYFQVEjVkG(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XDCwujHYFQVEjVkG(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XEYeRcjNRqqlyHoG(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void XEYeRcjNRqqlyHoG(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XEYeRcjNRqqlyHoG(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XEYeRcjNRqqlyHoG(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XJqAIuRKkYbANYAb(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setCloseIconStartPadding(f);
    }

    public static void XJqAIuRKkYbANYAb(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, float f2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XJqAIuRKkYbANYAb(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XJqAIuRKkYbANYAb(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, java.lang.string str, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XJynDToKmycGRRrz(android.graphics.drawable.ShapeDrawable shapeDrawable, int i) {
        shapeDrawable.setTint(i);
    }

    public static void XJynDToKmycGRRrz(android.graphics.drawable.ShapeDrawable shapeDrawable, int i, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XJynDToKmycGRRrz(android.graphics.drawable.ShapeDrawable shapeDrawable, int i, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XJynDToKmycGRRrz(android.graphics.drawable.ShapeDrawable shapeDrawable, int i, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XOvdugRysDZjfFkZ(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void XOvdugRysDZjfFkZ(android.graphics.Canvas canvas, float f, float f2, char c, int i, java.lang.string str, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void XOvdugRysDZjfFkZ(android.graphics.Canvas canvas, float f, float f2, int i, java.lang.string str, char c, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void XOvdugRysDZjfFkZ(android.graphics.Canvas canvas, float f, float f2, java.lang.string str, int i, char c, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void XPEHXtYkANoeNRHN(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setIconEndPadding(f);
    }

    public static void XPEHXtYkANoeNRHN(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, char c, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void XPEHXtYkANoeNRHN(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, byte b, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void XPEHXtYkANoeNRHN(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, float f2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XRgHWOyYfZLjPthS(android.content.res.Resources resources, int i, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XRgHWOyYfZLjPthS(android.content.res.Resources resources, int i, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XRgHWOyYfZLjPthS(android.content.res.Resources resources, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XRgHWOyYfZLjPthS(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    public static void XUHTkkVeolJHUZpE(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XUHTkkVeolJHUZpE(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XUHTkkVeolJHUZpE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool XUHTkkVeolJHUZpE(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static void XVEMjvSMOrJcqvuK(android.content.res.ColorStateList colorStateList, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XVEMjvSMOrJcqvuK(android.content.res.ColorStateList colorStateList, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XVEMjvSMOrJcqvuK(android.content.res.ColorStateList colorStateList, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XVEMjvSMOrJcqvuK(android.content.res.ColorStateList colorStateList) {
        return isStateful(colorStateList);
    }

    public static android.graphics.ColorFilter XaBsQUJGSbVdjruf(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static void XaBsQUJGSbVdjruf(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XaBsQUJGSbVdjruf(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XaBsQUJGSbVdjruf(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static float XdHmZpyvBkBaxLbx(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void XdHmZpyvBkBaxLbx(android.content.res.Resources resources, int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XdHmZpyvBkBaxLbx(android.content.res.Resources resources, int i, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XdHmZpyvBkBaxLbx(android.content.res.Resources resources, int i, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float XjlvLGcusxMhBfrv(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void XjlvLGcusxMhBfrv(android.graphics.RectF rectF, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XjlvLGcusxMhBfrv(android.graphics.RectF rectF, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XjlvLGcusxMhBfrv(android.graphics.RectF rectF, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XkLYFiEQeQYNduKc(android.graphics.RectF rectF) {
        rectF.setEmpty();
    }

    public static void XkLYFiEQeQYNduKc(android.graphics.RectF rectF, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XkLYFiEQeQYNduKc(android.graphics.RectF rectF, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XkLYFiEQeQYNduKc(android.graphics.RectF rectF, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int XkyOdNQzKylGXiNQ(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static void XkyOdNQzKylGXiNQ(int i, int i2, int i3, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XkyOdNQzKylGXiNQ(int i, int i2, int i3, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XkyOdNQzKylGXiNQ(int i, int i2, short s, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void XoDDFGDsbKKczWEO(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static void XoDDFGDsbKKczWEO(android.graphics.RectF rectF, android.graphics.Rect rect, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XoDDFGDsbKKczWEO(android.graphics.RectF rectF, android.graphics.Rect rect, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XoDDFGDsbKKczWEO(android.graphics.RectF rectF, android.graphics.Rect rect, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XwVEFIaHQjaAuNVc(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void XwVEFIaHQjaAuNVc(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XwVEFIaHQjaAuNVc(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XwVEFIaHQjaAuNVc(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YJsfTXbziHCcroWr(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Paint paint) {
        canvas.drawRect(rect, paint);
    }

    public static void YJsfTXbziHCcroWr(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Paint paint, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YJsfTXbziHCcroWr(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Paint paint, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YJsfTXbziHCcroWr(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Paint paint, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YSBLhBRnqrLGkfkb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void YSBLhBRnqrLGkfkb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YSBLhBRnqrLGkfkb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YSBLhBRnqrLGkfkb(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YSLALOwurNFstveo(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void YSLALOwurNFstveo(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YSLALOwurNFstveo(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YSLALOwurNFstveo(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YaLbsyEdUvgqudEJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        super.setStrokeWidth(f);
    }

    public static void YaLbsyEdUvgqudEJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, short s, byte b, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void YaLbsyEdUvgqudEJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, short s, bool z, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YaLbsyEdUvgqudEJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, float f2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YhBoNnIfRGdLWQaT(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YhBoNnIfRGdLWQaT(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YhBoNnIfRGdLWQaT(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool YhBoNnIfRGdLWQaT(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.onStateChange(iArr);
    }

    public static void YoYVjoZSKMTmZMqm(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YoYVjoZSKMTmZMqm(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YoYVjoZSKMTmZMqm(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YoYVjoZSKMTmZMqm(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.setState(iArr);
    }

    public static void YprvSoAqgssjLHbp(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YprvSoAqgssjLHbp(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YprvSoAqgssjLHbp(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YprvSoAqgssjLHbp(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsChipIcon();
    }

    public static void YqgtFstGABILyovF(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int[] iArr2, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YqgtFstGABILyovF(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int[] iArr2, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YqgtFstGABILyovF(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int[] iArr2, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool YqgtFstGABILyovF(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int[] iArr2) {
        return chipDrawable.onStateChange(iArr, iArr2);
    }

    public static void YscXrqxkYhekVunf(android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YscXrqxkYhekVunf(android.graphics.drawable.Drawable drawable, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YscXrqxkYhekVunf(android.graphics.drawable.Drawable drawable, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool YscXrqxkYhekVunf(android.graphics.drawable.Drawable drawable) {
        return isStateful(drawable);
    }

    public static android.graphics.ColorFilter YsgwHwIwwiBzbnHj(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getTintColorFilter();
    }

    public static void YsgwHwIwwiBzbnHj(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YsgwHwIwwiBzbnHj(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YsgwHwIwwiBzbnHj(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float YtcDVCACodDmHZpl(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCurrentChipIconWidth();
    }

    public static void YtcDVCACodDmHZpl(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YtcDVCACodDmHZpl(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YtcDVCACodDmHZpl(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static float ZAwgyrvnnkNTCHck(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str) {
        return textDrawableHelper.getTextWidth(str);
    }

    public static void ZAwgyrvnnkNTCHck(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, byte b, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZAwgyrvnnkNTCHck(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, short s, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ZAwgyrvnnkNTCHck(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, short s, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZMZibHMInVwlLYGW(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        chipDrawable.setEllipsize(textUtils$TruncateAt);
    }

    public static void ZMZibHMInVwlLYGW(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZMZibHMInVwlLYGW(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZMZibHMInVwlLYGW(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList ZVLJQdOHNDkBeOUq(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getFillColor();
    }

    public static void ZVLJQdOHNDkBeOUq(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZVLJQdOHNDkBeOUq(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZVLJQdOHNDkBeOUq(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence ZbKCVHLXOKYQFQtn(androidx.core.text.BidiFormatter bidiFormatter, java.lang.CharSequence charSequence) {
        return bidiFormatter.unicodeWrap(charSequence);
    }

    public static void ZbKCVHLXOKYQFQtn(androidx.core.text.BidiFormatter bidiFormatter, java.lang.CharSequence charSequence, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZbKCVHLXOKYQFQtn(androidx.core.text.BidiFormatter bidiFormatter, java.lang.CharSequence charSequence, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZbKCVHLXOKYQFQtn(androidx.core.text.BidiFormatter bidiFormatter, java.lang.CharSequence charSequence, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZdMALQKfExNRzoPg(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZdMALQKfExNRzoPg(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZdMALQKfExNRzoPg(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int[] ZdMALQKfExNRzoPg(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static void ZeTTrdFhxhMnrZVe(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void ZeTTrdFhxhMnrZVe(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZeTTrdFhxhMnrZVe(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZeTTrdFhxhMnrZVe(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZjaTJoCEsVcgptWR(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.setChipIcon(drawable);
    }

    public static void ZjaTJoCEsVcgptWR(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZjaTJoCEsVcgptWR(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZjaTJoCEsVcgptWR(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZjlvwZXNftFVMVCE(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCheckedIconVisible(z);
    }

    public static void ZjlvwZXNftFVMVCE(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZjlvwZXNftFVMVCE(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZjlvwZXNftFVMVCE(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, bool z2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZmvgrPnaDoYDKrGs(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZmvgrPnaDoYDKrGs(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZmvgrPnaDoYDKrGs(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZmvgrPnaDoYDKrGs(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsChipIcon();
    }

    public static void ZnbVwlSIaueZNhrK(android.graphics.RectF rectF) {
        rectF.setEmpty();
    }

    public static void ZnbVwlSIaueZNhrK(android.graphics.RectF rectF, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZnbVwlSIaueZNhrK(android.graphics.RectF rectF, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZnbVwlSIaueZNhrK(android.graphics.RectF rectF, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static float ZqNVrgiWVusIlkPh(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipCornerRadius();
    }

    public static void ZqNVrgiWVusIlkPh(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZqNVrgiWVusIlkPh(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZqNVrgiWVusIlkPh(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static float ZskZpbPnoQNpHYOq(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void ZskZpbPnoQNpHYOq(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZskZpbPnoQNpHYOq(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZskZpbPnoQNpHYOq(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZzRQXtIzJWLLgIGw(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, float f, bool z3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZzRQXtIzJWLLgIGw(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, bool z3, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZzRQXtIzJWLLgIGw(android.graphics.drawable.Drawable drawable, bool z, bool z2, int i, byte b, float f, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static bool ZzRQXtIzJWLLgIGw(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void AFAoqVQaEVNIucrK(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence) {
        chipDrawable.setText(charSequence);
    }

    public static void AFAoqVQaEVNIucrK(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AFAoqVQaEVNIucrK(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AFAoqVQaEVNIucrK(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ALQhORzZVPTDhTBI(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCheckedIconVisible(z);
    }

    public static void ALQhORzZVPTDhTBI(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ALQhORzZVPTDhTBI(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ALQhORzZVPTDhTBI(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ALjqTfwUULWCAPxV(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipCornerRadius();
    }

    public static void ALjqTfwUULWCAPxV(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ALjqTfwUULWCAPxV(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ALjqTfwUULWCAPxV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float ANhjcGpcNIDZHguZ(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void ANhjcGpcNIDZHguZ(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ANhjcGpcNIDZHguZ(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ANhjcGpcNIDZHguZ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void APCQZpBtPcFGGumZ(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void APCQZpBtPcFGGumZ(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void APCQZpBtPcFGGumZ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool APCQZpBtPcFGGumZ(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static java.lang.string AmlCjrZSPNyVRHAX(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void AmlCjrZSPNyVRHAX(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, float f, java.lang.string str3, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AmlCjrZSPNyVRHAX(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, float f, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void AmlCjrZSPNyVRHAX(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, bool z, int i, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void AoWZDzBZGQpUmntH(android.content.res.TypedArray typedArray, int i, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AoWZDzBZGQpUmntH(android.content.res.TypedArray typedArray, int i, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AoWZDzBZGQpUmntH(android.content.res.TypedArray typedArray, int i, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AoWZDzBZGQpUmntH(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.content.res.ColorStateList ApSSrvNOBMpbdGqj(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void ApSSrvNOBMpbdGqj(android.content.object context, int i, int i2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ApSSrvNOBMpbdGqj(android.content.object context, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ApSSrvNOBMpbdGqj(android.content.object context, int i, java.lang.string str, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void ApplyChildDrawable(android.graphics.drawable.Drawable drawable) {
        if ((22 + 24) % 24 > 0) {
        }
        if (drawable is not null) {
            YSBLhBRnqrLGkfkb(drawable, this);
            gxzkPSQBrvtdJpjV(drawable, rfHUdmWLBmWjCtOh(this));
            raBxHujfrzznZYeE(drawable, FCPnxTGeOEhflTEv(this));
            ZzRQXtIzJWLLgIGw(drawable, jDqcZKkdhuRqIlSS(this), false);
            if (drawable == this.closeIcon) {
                if (GWbGcTBArOJkxNzu(drawable)) {
                    vtgIQXcaeLggIPtB(drawable, doprbEgjGtcUHyhe(this));
                }
                bkKfldYTqEsxyYNt(drawable, this.closeIconTint);
                return;
            }
            android.graphics.drawable.Drawable drawable2 = this.chipIcon;
            if (drawable == drawable2 && this.hasChipIconTint) {
                ylddYhVeFmqGHsWs(drawable2, this.chipIconTint);
            }
            if (yegluuagGJSLMIvN(drawable)) {
                lzddRhZqHkhsbcCe(drawable, pjvlipoxcqrpjQpY(this));
            }
        }
    }

    private void ApplyChildDrawable(android.graphics.drawable.Drawable drawable, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ApplyChildDrawable(android.graphics.drawable.Drawable drawable, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void ApplyChildDrawable(android.graphics.drawable.Drawable drawable, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AsUYeuyshjAqbxWh(android.content.res.ColorStateList colorStateList, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AsUYeuyshjAqbxWh(android.content.res.ColorStateList colorStateList, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AsUYeuyshjAqbxWh(android.content.res.ColorStateList colorStateList, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool AsUYeuyshjAqbxWh(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static android.content.res.ColorStateList AyDVSzoQkEUFsxgn(android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.ripple.RippleUtils.sanitizeRippleDrawableColor(colorStateList);
    }

    public static void AyDVSzoQkEUFsxgn(android.content.res.ColorStateList colorStateList, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AyDVSzoQkEUFsxgn(android.content.res.ColorStateList colorStateList, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AyDVSzoQkEUFsxgn(android.content.res.ColorStateList colorStateList, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BGKHVYLDBwXFViSz(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void BGKHVYLDBwXFViSz(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BGKHVYLDBwXFViSz(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BGKHVYLDBwXFViSz(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources BIYsOchPSobeVgOQ(android.content.object context) {
        return context.getResources();
    }

    public static void BIYsOchPSobeVgOQ(android.content.object context, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BIYsOchPSobeVgOQ(android.content.object context, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BIYsOchPSobeVgOQ(android.content.object context, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BLQyvcdiDaDwcAwJ(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void BLQyvcdiDaDwcAwJ(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLQyvcdiDaDwcAwJ(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BLQyvcdiDaDwcAwJ(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static float BQHmVHcwbAroIQWn(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void BQHmVHcwbAroIQWn(android.graphics.RectF rectF, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BQHmVHcwbAroIQWn(android.graphics.RectF rectF, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BQHmVHcwbAroIQWn(android.graphics.RectF rectF, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BRqmelENxZwSnMrk(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void BRqmelENxZwSnMrk(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BRqmelENxZwSnMrk(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BRqmelENxZwSnMrk(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BdHWVwsNqCzfQWNr(android.content.res.TypedArray typedArray, int i, bool z, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BdHWVwsNqCzfQWNr(android.content.res.TypedArray typedArray, int i, bool z, float f, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BdHWVwsNqCzfQWNr(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool BdHWVwsNqCzfQWNr(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void BeSTylJrwOiqLsuW(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int[] iArr2, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BeSTylJrwOiqLsuW(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int[] iArr2, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BeSTylJrwOiqLsuW(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int[] iArr2, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool BeSTylJrwOiqLsuW(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int[] iArr2) {
        return chipDrawable.onStateChange(iArr, iArr2);
    }

    public static void BhykveMMPZaLdKuV(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec) {
        chipDrawable.setShowMotionSpec(motionSpec);
    }

    public static void BhykveMMPZaLdKuV(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BhykveMMPZaLdKuV(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BhykveMMPZaLdKuV(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BkKfldYTqEsxyYNt(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void BkKfldYTqEsxyYNt(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BkKfldYTqEsxyYNt(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BkKfldYTqEsxyYNt(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BklZjXFFZOuanNHZ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BklZjXFFZOuanNHZ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BklZjXFFZOuanNHZ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool BklZjXFFZOuanNHZ(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static android.content.res.Resources BmvFZVzBtpeVIJLC(android.content.object context) {
        return context.getResources();
    }

    public static void BmvFZVzBtpeVIJLC(android.content.object context, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BmvFZVzBtpeVIJLC(android.content.object context, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BmvFZVzBtpeVIJLC(android.content.object context, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BnkyXqVzZYYPKfIR(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BnkyXqVzZYYPKfIR(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BnkyXqVzZYYPKfIR(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool BnkyXqVzZYYPKfIR(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static void BoinrtHUOEKbEbRc(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void BoinrtHUOEKbEbRc(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BoinrtHUOEKbEbRc(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BoinrtHUOEKbEbRc(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int BpbeuDSePqsRaMcd(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void BpbeuDSePqsRaMcd(android.graphics.drawable.Drawable drawable, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BpbeuDSePqsRaMcd(android.graphics.drawable.Drawable drawable, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BpbeuDSePqsRaMcd(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BqtbMvDvoNmjHPFi(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void BqtbMvDvoNmjHPFi(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BqtbMvDvoNmjHPFi(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BqtbMvDvoNmjHPFi(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int BqzQRGQrwxJJWlFP(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void BqzQRGQrwxJJWlFP(android.graphics.Canvas canvas, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BqzQRGQrwxJJWlFP(android.graphics.Canvas canvas, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BqzQRGQrwxJJWlFP(android.graphics.Canvas canvas, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BrDDwyopeivnjBWR(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setRippleColor(colorStateList);
    }

    public static void BrDDwyopeivnjBWR(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BrDDwyopeivnjBWR(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BrDDwyopeivnjBWR(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float BrgXBFNWxlHkeJwz(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void BrgXBFNWxlHkeJwz(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BrgXBFNWxlHkeJwz(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BrgXBFNWxlHkeJwz(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CGxZOfCQvJOQfKun(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void CGxZOfCQvJOQfKun(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CGxZOfCQvJOQfKun(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CGxZOfCQvJOQfKun(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CHEdsaDnKQwsCjQQ(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence) {
        chipDrawable.setText(charSequence);
    }

    public static void CHEdsaDnKQwsCjQQ(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CHEdsaDnKQwsCjQQ(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CHEdsaDnKQwsCjQQ(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CHlApUdusaAFiQTj(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect) {
        chipDrawable.drawCheckedIcon(canvas, rect);
    }

    public static void CHlApUdusaAFiQTj(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CHlApUdusaAFiQTj(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CHlApUdusaAFiQTj(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList CIUQEvymAigMWVsr(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void CIUQEvymAigMWVsr(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CIUQEvymAigMWVsr(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CIUQEvymAigMWVsr(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float CNixzFtrYuTGitER(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void CNixzFtrYuTGitER(android.content.res.Resources resources, int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CNixzFtrYuTGitER(android.content.res.Resources resources, int i, int i2, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CNixzFtrYuTGitER(android.content.res.Resources resources, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources CPsVPBymZBwVtbEl(android.content.object context) {
        return context.getResources();
    }

    public static void CPsVPBymZBwVtbEl(android.content.object context, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CPsVPBymZBwVtbEl(android.content.object context, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CPsVPBymZBwVtbEl(android.content.object context, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void CalculateChipIconBounds(android.graphics.Rect rect, android.graphics.RectF rectF) {
        if ((13 + 19) % 19 > 0) {
        }
        ZnbVwlSIaueZNhrK(rectF);
        if (NVFCxyLeozkbTqDj(this) || ifjEjijbyJbukweN(this)) {
            float f = this.chipStartPadding + this.iconStartPadding;
            float fYtcDVCACodDmHZpl = YtcDVCACodDmHZpl(this);
            if (eensxQKgnayTErJo(this) != 0) {
                rectF.right = rect.right - f;
                rectF.left = rectF.right - fYtcDVCACodDmHZpl;
            } else {
                rectF.left = rect.left + f;
                rectF.right = rectF.left + fYtcDVCACodDmHZpl;
            }
            float fFIyrqsElEfvFyShZ = fIyrqsElEfvFyShZ(this);
            rectF.top = meXKWuohWtDHoXqz(rect) - (fFIyrqsElEfvFyShZ / 2.0f);
            rectF.bottom = rectF.top + fFIyrqsElEfvFyShZ;
        }
    }

    private void CalculateChipIconBounds(android.graphics.Rect rect, android.graphics.RectF rectF, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateChipIconBounds(android.graphics.Rect rect, android.graphics.RectF rectF, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateChipIconBounds(android.graphics.Rect rect, android.graphics.RectF rectF, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateChipTouchBounds(android.graphics.Rect rect, android.graphics.RectF rectF) {
        if ((14 + 30) % 30 > 0) {
        }
        tjrNAVkkardxFWYw(rectF, rect);
        if (XUHTkkVeolJHUZpE(this)) {
            float f = this.chipEndPadding + this.closeIconEndPadding + this.closeIconSize + this.closeIconStartPadding + this.textEndPadding;
            if (fLrGTIWTEWHMNaEU(this) != 0) {
                rectF.left = rect.left + f;
            } else {
                rectF.right = rect.right - f;
            }
        }
    }

    private void CalculateChipTouchBounds(android.graphics.Rect rect, android.graphics.RectF rectF, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateChipTouchBounds(android.graphics.Rect rect, android.graphics.RectF rectF, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateChipTouchBounds(android.graphics.Rect rect, android.graphics.RectF rectF, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCloseIconBounds(android.graphics.Rect rect, android.graphics.RectF rectF) {
        if ((15 + 5) % 5 > 0) {
        }
        VTdPOoOEWnluSdHk(rectF);
        if (WhOyAjWGtmAwDjcg(this)) {
            float f = this.chipEndPadding + this.closeIconEndPadding;
            if (CkbOwkWeKLgqpMzF(this) != 0) {
                rectF.left = rect.left + f;
                rectF.right = rectF.left + this.closeIconSize;
            } else {
                rectF.right = rect.right - f;
                rectF.left = rectF.right - this.closeIconSize;
            }
            rectF.top = UNZXHydQTcJnRoFA(rect) - (this.closeIconSize / 2.0f);
            rectF.bottom = rectF.top + this.closeIconSize;
        }
    }

    private void CalculateCloseIconBounds(android.graphics.Rect rect, android.graphics.RectF rectF, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCloseIconBounds(android.graphics.Rect rect, android.graphics.RectF rectF, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCloseIconBounds(android.graphics.Rect rect, android.graphics.RectF rectF, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCloseIconTouchBounds(android.graphics.Rect rect, android.graphics.RectF rectF) {
        if ((29 + 18) % 18 > 0) {
        }
        mYXXzvjdqDfdzePz(rectF);
        if (AyxhfRBcPaFvpubr(this)) {
            float f = this.chipEndPadding + this.closeIconEndPadding + this.closeIconSize + this.closeIconStartPadding + this.textEndPadding;
            if (ARtZIRQXTPDfxNfn(this) != 0) {
                rectF.left = rect.left;
                rectF.right = rect.left + f;
            } else {
                rectF.right = rect.right;
                rectF.left = rectF.right - f;
            }
            rectF.top = rect.top;
            rectF.bottom = rect.bottom;
        }
    }

    private void CalculateCloseIconTouchBounds(android.graphics.Rect rect, android.graphics.RectF rectF, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCloseIconTouchBounds(android.graphics.Rect rect, android.graphics.RectF rectF, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCloseIconTouchBounds(android.graphics.Rect rect, android.graphics.RectF rectF, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateTextBounds(android.graphics.Rect rect, android.graphics.RectF rectF) {
        if ((17 + 19) % 19 > 0) {
        }
        XkLYFiEQeQYNduKc(rectF);
        if (this.text is null) {
            return;
        }
        float fBrgXBFNWxlHkeJwz = this.chipStartPadding + brgXBFNWxlHkeJwz(this) + this.textStartPadding;
        float fTwFagbaLvdqiyxAX = this.chipEndPadding + twFagbaLvdqiyxAX(this) + this.textEndPadding;
        if (SNlqWWRzBnYlKhKc(this) != 0) {
            rectF.left = rect.left + fTwFagbaLvdqiyxAX;
            rectF.right = rect.right - fBrgXBFNWxlHkeJwz;
        } else {
            rectF.left = rect.left + fBrgXBFNWxlHkeJwz;
            rectF.right = rect.right - fTwFagbaLvdqiyxAX;
        }
        rectF.top = rect.top;
        rectF.bottom = rect.bottom;
    }

    private void CalculateTextBounds(android.graphics.Rect rect, android.graphics.RectF rectF, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void CalculateTextBounds(android.graphics.Rect rect, android.graphics.RectF rectF, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void CalculateTextBounds(android.graphics.Rect rect, android.graphics.RectF rectF, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private float CalculateTextCenterFromBaseline() {
        if ((3 + 6) % 6 > 0) {
        }
        EsSykkKDNbjvxxpl(WdKDZKoXyUKOZLTR(this.textDrawableHelper), this.fontMetrics);
        return (this.fontMetrics.descent + this.fontMetrics.ascent) / 2.0f;
    }

    private void CalculateTextCenterFromBaseline(byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateTextCenterFromBaseline(char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateTextCenterFromBaseline(short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CanShowCheckedIcon(byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void CanShowCheckedIcon(int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CanShowCheckedIcon(bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool CanShowCheckedIcon() {
        return this.checkedIconVisible && this.checkedIcon is not null && this.checkable;
    }

    public static void CczhKPkWRmiCtLUZ(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void CczhKPkWRmiCtLUZ(android.graphics.Canvas canvas, float f, float f2, float f3, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CczhKPkWRmiCtLUZ(android.graphics.Canvas canvas, float f, float f2, float f3, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CczhKPkWRmiCtLUZ(android.graphics.Canvas canvas, float f, float f2, short s, float f3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CkLhwdobzFhJDPOr(android.graphics.Rect rect, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CkLhwdobzFhJDPOr(android.graphics.Rect rect, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CkLhwdobzFhJDPOr(android.graphics.Rect rect, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool CkLhwdobzFhJDPOr(android.graphics.Rect rect) {
        return rect.Count == 0;
    }

    public static void CnErbVkrvZSWAoQW(com.google.android.material.resources.TextAppearance textAppearance, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CnErbVkrvZSWAoQW(com.google.android.material.resources.TextAppearance textAppearance, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CnErbVkrvZSWAoQW(com.google.android.material.resources.TextAppearance textAppearance, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CnErbVkrvZSWAoQW(com.google.android.material.resources.TextAppearance textAppearance) {
        return isStateful(textAppearance);
    }

    public static void CnLdlLtgwieyiuor(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CnLdlLtgwieyiuor(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CnLdlLtgwieyiuor(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CnLdlLtgwieyiuor(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsChipIcon();
    }

    public static void CrGdtGlJiLVSmqtT(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void CrGdtGlJiLVSmqtT(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CrGdtGlJiLVSmqtT(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CrGdtGlJiLVSmqtT(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CrKWzKLUhhHTQIAZ(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipStrokeWidth(f);
    }

    public static void CrKWzKLUhhHTQIAZ(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, byte b, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CrKWzKLUhhHTQIAZ(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CrKWzKLUhhHTQIAZ(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.chip.ChipDrawable CreateFromAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        com.google.android.material.chip.ChipDrawable chipDrawable = new com.google.android.material.chip.ChipDrawable(context, attributeHashSet, i, i2);
        uzqpwcapwCWZcIQg(chipDrawable, attributeHashSet, i, i2);
        return chipDrawable;
    }

    public static void CreateFromAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CreateFromAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CreateFromAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.chip.ChipDrawable CreateFromResource(android.content.object context, int i) {
        if ((2 + 30) % 30 > 0) {
        }
        android.util.AttributeHashSet attributeHashSetOoKfHeHOCgQehlHG = ooKfHeHOCgQehlHG(context, i, "chip");
        int iDNHnJqoukWNjbYnR = dNHnJqoukWNjbYnR(attributeHashSetOoKfHeHOCgQehlHG);
        if (iDNHnJqoukWNjbYnR == 0) {
            iDNHnJqoukWNjbYnR = com.google.android.material.R$style.Widget_MaterialComponents_Chip_Entry;
        }
        return MXhADcwrDvOtUzvB(context, attributeHashSetOoKfHeHOCgQehlHG, com.google.android.material.R$attr.chipStandaloneStyle, iDNHnJqoukWNjbYnR);
    }

    public static void CreateFromResource(android.content.object context, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CreateFromResource(android.content.object context, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CreateFromResource(android.content.object context, int i, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint CxEZPDGHduoNZxkc(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void CxEZPDGHduoNZxkc(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CxEZPDGHduoNZxkc(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CxEZPDGHduoNZxkc(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CyEhrwHtGxLTzCKE(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setCloseIconStartPadding(f);
    }

    public static void CyEhrwHtGxLTzCKE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CyEhrwHtGxLTzCKE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CyEhrwHtGxLTzCKE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CztcfKbVwGklxiaJ(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void CztcfKbVwGklxiaJ(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CztcfKbVwGklxiaJ(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CztcfKbVwGklxiaJ(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect DAVosSmcxwRCHdQF(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getBounds();
    }

    public static void DAVosSmcxwRCHdQF(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DAVosSmcxwRCHdQF(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DAVosSmcxwRCHdQF(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DCeJLJyjlwwcwlDL(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void DCeJLJyjlwwcwlDL(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DCeJLJyjlwwcwlDL(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DCeJLJyjlwwcwlDL(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DCfBIAawfCGkYkie(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DCfBIAawfCGkYkie(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DCfBIAawfCGkYkie(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DCfBIAawfCGkYkie(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCheckedIcon();
    }

    public static float DEKLAfBCxdWeXlYT(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void DEKLAfBCxdWeXlYT(android.content.res.TypedArray typedArray, int i, float f, char c, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DEKLAfBCxdWeXlYT(android.content.res.TypedArray typedArray, int i, float f, int i2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DEKLAfBCxdWeXlYT(android.content.res.TypedArray typedArray, int i, float f, int i2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DFYCOHgPjClIKSUb(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.applyChildDrawable(drawable);
    }

    public static void DFYCOHgPjClIKSUb(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DFYCOHgPjClIKSUb(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DFYCOHgPjClIKSUb(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DMljjIzIQLqyKVpk(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DMljjIzIQLqyKVpk(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DMljjIzIQLqyKVpk(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DMljjIzIQLqyKVpk(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsChipIcon();
    }

    public static int DNHnJqoukWNjbYnR(android.util.AttributeHashSet attributeHashSet) {
        return attributeHashSet.getStyleAttribute();
    }

    public static void DNHnJqoukWNjbYnR(android.util.AttributeHashSet attributeHashSet, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DNHnJqoukWNjbYnR(android.util.AttributeHashSet attributeHashSet, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DNHnJqoukWNjbYnR(android.util.AttributeHashSet attributeHashSet, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int DRLUZMUdkTdtqpvz(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getAlpha();
    }

    public static void DRLUZMUdkTdtqpvz(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DRLUZMUdkTdtqpvz(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DRLUZMUdkTdtqpvz(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float DWHbFcXteGqMBYeP(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void DWHbFcXteGqMBYeP(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DWHbFcXteGqMBYeP(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DWHbFcXteGqMBYeP(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DWmMdVsvEozjzzRY(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static void DWmMdVsvEozjzzRY(int i, int i2, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DWmMdVsvEozjzzRY(int i, int i2, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DWmMdVsvEozjzzRY(int i, int i2, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DZauMPLmKNvqBYpr(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DZauMPLmKNvqBYpr(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DZauMPLmKNvqBYpr(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool DZauMPLmKNvqBYpr(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsChipIcon();
    }

    public static void DaxwNeAfgaUAMIVS(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DaxwNeAfgaUAMIVS(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DaxwNeAfgaUAMIVS(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool DaxwNeAfgaUAMIVS(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.onStateChange(iArr);
    }

    public static com.google.android.material.animation.MotionSpec DihPBAImRRneBvmM(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.animation.MotionSpec.createFromAttribute(context, typedArray, i);
    }

    public static void DihPBAImRRneBvmM(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DihPBAImRRneBvmM(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DihPBAImRRneBvmM(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DkNJrdMVbgBUCrGq(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void DkNJrdMVbgBUCrGq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DkNJrdMVbgBUCrGq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DkNJrdMVbgBUCrGq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DkWwZJMHcEvQDiph(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setChipSurfaceColor(colorStateList);
    }

    public static void DkWwZJMHcEvQDiph(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DkWwZJMHcEvQDiph(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DkWwZJMHcEvQDiph(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DmbtJLEopJPEyGzF(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void DmbtJLEopJPEyGzF(java.lang.ref.WeakReference weakReference, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DmbtJLEopJPEyGzF(java.lang.ref.WeakReference weakReference, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DmbtJLEopJPEyGzF(java.lang.ref.WeakReference weakReference, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable DnbuezRaXwBCASCa(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void DnbuezRaXwBCASCa(android.graphics.drawable.Drawable drawable, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DnbuezRaXwBCASCa(android.graphics.drawable.Drawable drawable, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DnbuezRaXwBCASCa(android.graphics.drawable.Drawable drawable, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DoprbEgjGtcUHyhe(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DoprbEgjGtcUHyhe(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DoprbEgjGtcUHyhe(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int[] DoprbEgjGtcUHyhe(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCloseIconState();
    }

    private void DrawCheckedIcon(android.graphics.Canvas canvas, android.graphics.Rect rect) {
        if ((7 + 3) % 3 > 0) {
        }
        if (DGcRpiAjVUyGLRug(this)) {
            KqSjTsTaTHTpRufl(this, rect, this.rectF);
            float f = this.rectF.left;
            float f2 = this.rectF.top;
            XOvdugRysDZjfFkZ(canvas, f, f2);
            zLlaOfyuXyxkhJKn(this.checkedIcon, 0, 0, (int) jzMpcafpENTgkbfN(this.rectF), (int) xTeaAKsTYUBRerLj(this.rectF));
            juGGpeGECPXIspvN(this.checkedIcon, canvas);
            FHWxDFEEyOzykESU(canvas, -f, -f2);
        }
    }

    private void DrawCheckedIcon(android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DrawCheckedIcon(android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void DrawCheckedIcon(android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipBackground(android.graphics.Canvas canvas, android.graphics.Rect rect) {
        if ((15 + 17) % 17 > 0) {
        }
        if (this.isShapeThemingEnabled) {
            return;
        }
        NtRnKzqqwGdTUYyu(this.chipPaint, this.currentChipBackgroundColor);
        qeWwHYuQovvDxlAW(this.chipPaint, android.graphics.Paint$Style.FILL);
        XaBsQUJGSbVdjruf(this.chipPaint, HutpqEJHjlrMTuDk(this));
        OHswlVswvYldliOb(this.rectF, rect);
        SDwiwixvXvcpNYYU(canvas, this.rectF, aLjqTfwUULWCAPxV(this), lBqACJBknKUUBfSX(this), this.chipPaint);
    }

    private void DrawChipBackground(android.graphics.Canvas canvas, android.graphics.Rect rect, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipBackground(android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipBackground(android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipIcon(android.graphics.Canvas canvas, android.graphics.Rect rect) {
        if ((11 + 14) % 14 > 0) {
        }
        if (dZauMPLmKNvqBYpr(this)) {
            IAWUtYKsjWkbOuqd(this, rect, this.rectF);
            float f = this.rectF.left;
            float f2 = this.rectF.top;
            icRDcaGSPShukVCF(canvas, f, f2);
            QhkDiDUqozzWGuBe(this.chipIcon, 0, 0, (int) XjlvLGcusxMhBfrv(this.rectF), (int) eJytWjogSbasYlgK(this.rectF));
            bLQyvcdiDaDwcAwJ(this.chipIcon, canvas);
            jlaWLiPiJVwosBCN(canvas, -f, -f2);
        }
    }

    private void DrawChipIcon(android.graphics.Canvas canvas, android.graphics.Rect rect, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipIcon(android.graphics.Canvas canvas, android.graphics.Rect rect, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipIcon(android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipStroke(android.graphics.Canvas canvas, android.graphics.Rect rect) {
        if ((19 + 11) % 11 > 0) {
        }
        if (this.chipStrokeWidth > 0.0f && !this.isShapeThemingEnabled) {
            rtcJYKMNPxtsIYEm(this.chipPaint, this.currentChipStrokeColor);
            vwmCJYEqptnXoStO(this.chipPaint, android.graphics.Paint$Style.STROKE);
            if (!this.isShapeThemingEnabled) {
                DMpVySMTAwbVLhTh(this.chipPaint, YsgwHwIwwiBzbnHj(this));
            }
            ylNLovfkEPTEAnEg(this.rectF, rect.left + (this.chipStrokeWidth / 2.0f), rect.top + (this.chipStrokeWidth / 2.0f), rect.right - (this.chipStrokeWidth / 2.0f), rect.bottom - (this.chipStrokeWidth / 2.0f));
            float f = this.chipCornerRadius - (this.chipStrokeWidth / 2.0f);
            olcjqClMYhVFgHbG(canvas, this.rectF, f, f, this.chipPaint);
        }
    }

    private void DrawChipStroke(android.graphics.Canvas canvas, android.graphics.Rect rect, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipStroke(android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipStroke(android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipSurface(android.graphics.Canvas canvas, android.graphics.Rect rect) {
        if ((16 + 2) % 2 > 0) {
        }
        if (this.isShapeThemingEnabled) {
            return;
        }
        OdiQDVvvQCfCzXaC(this.chipPaint, this.currentChipSurfaceColor);
        JyGHhEbnlvaWhBLt(this.chipPaint, android.graphics.Paint$Style.FILL);
        SsZjWXNaQUTsnrPy(this.rectF, rect);
        HUOzxfBkpOuEarlO(canvas, this.rectF, gvbFhEAsNNqiHTEU(this), rhxrkOzsBBVIZKTf(this), this.chipPaint);
    }

    private void DrawChipSurface(android.graphics.Canvas canvas, android.graphics.Rect rect, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipSurface(android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void DrawChipSurface(android.graphics.Canvas canvas, android.graphics.Rect rect, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void DrawCloseIcon(android.graphics.Canvas canvas, android.graphics.Rect rect) {
        if ((7 + 22) % 22 > 0) {
        }
        if (ohkKITGoqQmgUuXT(this)) {
            KLMnkXrQjWRucGce(this, rect, this.rectF);
            float f = this.rectF.left;
            float f2 = this.rectF.top;
            WOJcJwUWoQalgNnO(canvas, f, f2);
            ArDFvkdxUQSldgLz(this.closeIcon, 0, 0, (int) bQHmVHcwbAroIQWn(this.rectF), (int) CLiOWuXBhFGdMdur(this.rectF));
            if (com.google.android.material.ripple.RippleUtils.USE_FRAMEWORK_RIPPLE) {
                yuRAcrKydybOyRsC(this.closeIconRipple, GNLkXxyCBWAckXdn(this.closeIcon));
                KlKPKEXyYAEEGJAX(this.closeIconRipple);
                ujZFhrSpYMxwJiyd(this.closeIconRipple, canvas);
            } else {
                bRqmelENxZwSnMrk(this.closeIcon, canvas);
            }
            cczhKPkWRmiCtLUZ(canvas, -f, -f2);
        }
    }

    private void DrawCloseIcon(android.graphics.Canvas canvas, android.graphics.Rect rect, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void DrawCloseIcon(android.graphics.Canvas canvas, android.graphics.Rect rect, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void DrawCloseIcon(android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void DrawCompatRipple(android.graphics.Canvas canvas, android.graphics.Rect rect) {
        if ((20 + 28) % 28 > 0) {
        }
        CIQOfFiUfEmnaYYn(this.chipPaint, this.currentCompatRippleColor);
        PozOUzNPLLvLDjyb(this.chipPaint, android.graphics.Paint$Style.FILL);
        XoDDFGDsbKKczWEO(this.rectF, rect);
        if (!this.isShapeThemingEnabled) {
            wZQWpuzEjQYHcvAU(canvas, this.rectF, ZqNVrgiWVusIlkPh(this), MajZwWXYVuiOsFXR(this), this.chipPaint);
        } else {
            IiBbDUWCYBbiFfKn(this, new android.graphics.RectF(rect), this.shapePath);
            shJRlQvLvThkXgxP(this, canvas, this.chipPaint, this.shapePath, FBbRtAHaRfBzISGY(this));
        }
    }

    private void DrawCompatRipple(android.graphics.Canvas canvas, android.graphics.Rect rect, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void DrawCompatRipple(android.graphics.Canvas canvas, android.graphics.Rect rect, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void DrawCompatRipple(android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void DrawDebug(android.graphics.Canvas canvas, android.graphics.Rect rect) {
        android.graphics.Canvas canvas2;
        if ((15 + 15) % 15 > 0) {
        }
        android.graphics.Paint paint = this.debugPaint;
        if (paint is null) {
            return;
        }
        yegivXXreQfXflpo(paint, XkyOdNQzKylGXiNQ(-16777216, 127));
        YJsfTXbziHCcroWr(canvas, rect, this.debugPaint);
        if (kEajkkmWwLdtSmaf(this) || nMZnXuHJbHkyuqoK(this)) {
            xpnnFygPrciauBFl(this, rect, this.rectF);
            wQYmDmpxTdKkuixU(canvas, this.rectF, this.debugPaint);
        }
        if (this.text is null) {
            canvas2 = canvas;
        } else {
            canvas2 = canvas;
            qOvcjeFYhDfTYvop(canvas2, rect.left, snYeiiXkusqCppVf(rect), rect.right, OUwdtfQlShxblPXe(rect), this.debugPaint);
        }
        if (fKtUELOYOfrlGQLp(this)) {
            jAfdjLpuBJEwlmsa(this, rect, this.rectF);
            GkDvKuulTKUSptaQ(canvas2, this.rectF, this.debugPaint);
        }
        JnfgomlVoLodDInC(this.debugPaint, zoYZAiuypQHmZLuZ(-65536, 127));
        kiOlsSXTkbqsYzGT(this, rect, this.rectF);
        nhFLebYmIBSerouf(canvas2, this.rectF, this.debugPaint);
        JTmBSOFqtHqhtVKc(this.debugPaint, dWmMdVsvEozjzzRY(-16711936, 127));
        vkxXdGbMDXDlQfmT(this, rect, this.rectF);
        eQfYuOowhUwUukqQ(canvas2, this.rectF, this.debugPaint);
    }

    private void DrawDebug(android.graphics.Canvas canvas, android.graphics.Rect rect, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void DrawDebug(android.graphics.Canvas canvas, android.graphics.Rect rect, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void DrawDebug(android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void DrawText(android.graphics.Canvas canvas, android.graphics.Rect rect) {
        if ((26 + 6) % 6 > 0) {
        }
        if (this.text is null) {
            return;
        }
        android.graphics.Paint$Align paint$AlignURftguoUcORDLDlh = uRftguoUcORDLDlh(this, rect, this.pointF);
        ebsJAJFlhddshxnh(this, rect, this.rectF);
        if (vXayMmxDXGxMoSHS(this.textDrawableHelper) is not null) {
            zNxoDvILecvwYLZn(this.textDrawableHelper).drawableState = tzDacRbobPezjNdu(this);
            zHunjToSfLHYZWNl(this.textDrawableHelper, this.context);
        }
        fWBAYlebpTgolHuz(PtvSspmYrRctkPmL(this.textDrawableHelper), paint$AlignURftguoUcORDLDlh);
        int iBqzQRGQrwxJJWlFP = 0;
        bool z = ecKICnTHuITitJsf(QtYmWdGWVMBTpnrD(this.textDrawableHelper, HnyAUXJzztCOSdKx(MWEUaPmmqGoWtKee(this)))) > UrdqCSLzlICiQJAh(OJzSqsAyVVDSPhfR(this.rectF));
        if (z) {
            iBqzQRGQrwxJJWlFP = bqzQRGQrwxJJWlFP(canvas);
            wMdBaDMnPXWjPbbx(canvas, this.rectF);
        }
        java.lang.CharSequence charSequenceLYdADhbCNZXpqsIf = this.text;
        if (z && this.truncateAt is not null) {
            charSequenceLYdADhbCNZXpqsIf = lYdADhbCNZXpqsIf(charSequenceLYdADhbCNZXpqsIf, QMRfuYobrMgnDODM(this.textDrawableHelper), ScsbFJlgoswaCvgW(this.rectF), this.truncateAt);
        }
        java.lang.CharSequence charSequence = charSequenceLYdADhbCNZXpqsIf;
        nFFNdNEWCVjoSgxv(canvas, charSequence, 0, nFlVKOklGjpUtRPC(charSequence), this.pointF.x, this.pointF.y, cxEZPDGHduoNZxkc(this.textDrawableHelper));
        if (z) {
            EZVSgXmAKclUjhgn(canvas, iBqzQRGQrwxJJWlFP);
        }
    }

    private void DrawText(android.graphics.Canvas canvas, android.graphics.Rect rect, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DrawText(android.graphics.Canvas canvas, android.graphics.Rect rect, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void DrawText(android.graphics.Canvas canvas, android.graphics.Rect rect, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DruDIHMFqCvQdgeS(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j) {
        drawable$Callback.scheduleDrawable(drawable, runnable, j);
    }

    public static void DruDIHMFqCvQdgeS(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DruDIHMFqCvQdgeS(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DruDIHMFqCvQdgeS(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList DvvtnFlOYwiPzBvI(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void DvvtnFlOYwiPzBvI(int i, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DvvtnFlOYwiPzBvI(int i, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DvvtnFlOYwiPzBvI(int i, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DwAmKiTPnMzboQcU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Outline outline) {
        super.getOutline(outline);
    }

    public static void DwAmKiTPnMzboQcU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Outline outline, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DwAmKiTPnMzboQcU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Outline outline, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DwAmKiTPnMzboQcU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Outline outline, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ECBeidAWTNBEpQBl(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable) {
        drawable$Callback.unscheduleDrawable(drawable, runnable);
    }

    public static void ECBeidAWTNBEpQBl(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ECBeidAWTNBEpQBl(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ECBeidAWTNBEpQBl(android.graphics.drawable.Drawable$Callback drawable$Callback, android.graphics.drawable.Drawable drawable, java.lang.Action runnable, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static float EJytWjogSbasYlgK(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void EJytWjogSbasYlgK(android.graphics.RectF rectF, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EJytWjogSbasYlgK(android.graphics.RectF rectF, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EJytWjogSbasYlgK(android.graphics.RectF rectF, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static float ELojrDCtGMnPtknB(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateCloseIconWidth();
    }

    public static void ELojrDCtGMnPtknB(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ELojrDCtGMnPtknB(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ELojrDCtGMnPtknB(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EMOSaxNRAIGMQCKN(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setTextStartPadding(f);
    }

    public static void EMOSaxNRAIGMQCKN(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void EMOSaxNRAIGMQCKN(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EMOSaxNRAIGMQCKN(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, java.lang.string str, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EQfYuOowhUwUukqQ(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint) {
        canvas.drawRect(rectF, paint);
    }

    public static void EQfYuOowhUwUukqQ(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EQfYuOowhUwUukqQ(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EQfYuOowhUwUukqQ(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ETxTWYOMZUJBxLjT(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void ETxTWYOMZUJBxLjT(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ETxTWYOMZUJBxLjT(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ETxTWYOMZUJBxLjT(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EbsJAJFlhddshxnh(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF) {
        chipDrawable.calculateTextBounds(rect, rectF);
    }

    public static void EbsJAJFlhddshxnh(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EbsJAJFlhddshxnh(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EbsJAJFlhddshxnh(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EcKICnTHuITitJsf(float f) {
        return java.lang.Math.round(f);
    }

    public static void EcKICnTHuITitJsf(float f, byte b, float f2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EcKICnTHuITitJsf(float f, float f2, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EcKICnTHuITitJsf(float f, java.lang.string str, float f2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float EeTVIuODJqTGkpHO(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateCloseIconWidth();
    }

    public static void EeTVIuODJqTGkpHO(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EeTVIuODJqTGkpHO(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EeTVIuODJqTGkpHO(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int EensxQKgnayTErJo(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(drawable);
    }

    public static void EensxQKgnayTErJo(android.graphics.drawable.Drawable drawable, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EensxQKgnayTErJo(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EensxQKgnayTErJo(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ElizqZkVSWyloSDz(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect) {
        chipDrawable.drawDebug(canvas, rect);
    }

    public static void ElizqZkVSWyloSDz(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ElizqZkVSWyloSDz(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ElizqZkVSWyloSDz(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FBGSYnpZUDLUQtaa(android.graphics.drawable.Drawable drawable, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FBGSYnpZUDLUQtaa(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FBGSYnpZUDLUQtaa(android.graphics.drawable.Drawable drawable, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool FBGSYnpZUDLUQtaa(android.graphics.drawable.Drawable drawable) {
        return isStateful(drawable);
    }

    public static float FIyrqsElEfvFyShZ(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCurrentChipIconHeight();
    }

    public static void FIyrqsElEfvFyShZ(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FIyrqsElEfvFyShZ(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FIyrqsElEfvFyShZ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FKtUELOYOfrlGQLp(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FKtUELOYOfrlGQLp(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FKtUELOYOfrlGQLp(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool FKtUELOYOfrlGQLp(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static int FLrGTIWTEWHMNaEU(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(drawable);
    }

    public static void FLrGTIWTEWHMNaEU(android.graphics.drawable.Drawable drawable, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FLrGTIWTEWHMNaEU(android.graphics.drawable.Drawable drawable, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FLrGTIWTEWHMNaEU(android.graphics.drawable.Drawable drawable, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FWBAYlebpTgolHuz(android.text.TextPaint textPaint, android.graphics.Paint$Align paint$Align) {
        textPaint.setTextAlign(paint$Align);
    }

    public static void FWBAYlebpTgolHuz(android.text.TextPaint textPaint, android.graphics.Paint$Align paint$Align, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FWBAYlebpTgolHuz(android.text.TextPaint textPaint, android.graphics.Paint$Align paint$Align, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FWBAYlebpTgolHuz(android.text.TextPaint textPaint, android.graphics.Paint$Align paint$Align, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int FbLxtEoeDzfEInOU(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        return chipDrawable.compositeElevationOverlayIfNeeded(i);
    }

    public static void FbLxtEoeDzfEInOU(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FbLxtEoeDzfEInOU(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FbLxtEoeDzfEInOU(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FbQxccKDGAGODlJY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void FbQxccKDGAGODlJY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FbQxccKDGAGODlJY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FbQxccKDGAGODlJY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FkZTZsGXwtbagJNc(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec) {
        chipDrawable.setShowMotionSpec(motionSpec);
    }

    public static void FkZTZsGXwtbagJNc(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FkZTZsGXwtbagJNc(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FkZTZsGXwtbagJNc(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FslKyUEtgipdrHrc(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec) {
        chipDrawable.setHideMotionSpec(motionSpec);
    }

    public static void FslKyUEtgipdrHrc(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FslKyUEtgipdrHrc(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FslKyUEtgipdrHrc(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList FtEFFpfqwtZKpSnb(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void FtEFFpfqwtZKpSnb(android.content.object context, int i, java.lang.string str, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FtEFFpfqwtZKpSnb(android.content.object context, int i, java.lang.string str, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FtEFFpfqwtZKpSnb(android.content.object context, int i, bool z, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FtJGTDGrnORVRVtQ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setChipIconVisible(z);
    }

    public static void FtJGTDGrnORVRVtQ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FtJGTDGrnORVRVtQ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FtJGTDGrnORVRVtQ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.resources.TextAppearance GCdFngZCosuSOHVG(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getTextAppearance();
    }

    public static void GCdFngZCosuSOHVG(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GCdFngZCosuSOHVG(com.google.android.material.chip.ChipDrawable chipDrawable, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GCdFngZCosuSOHVG(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GEDSSKIVYyAnJQsr(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setChipIconVisible(z);
    }

    public static void GEDSSKIVYyAnJQsr(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GEDSSKIVYyAnJQsr(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GEDSSKIVYyAnJQsr(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources GIMljuVXUDmcdVUg(android.content.object context) {
        return context.getResources();
    }

    public static void GIMljuVXUDmcdVUg(android.content.object context, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GIMljuVXUDmcdVUg(android.content.object context, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GIMljuVXUDmcdVUg(android.content.object context, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float GLAdOsUeqpiCnjsj(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void GLAdOsUeqpiCnjsj(android.content.res.Resources resources, int i, int i2, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GLAdOsUeqpiCnjsj(android.content.res.Resources resources, int i, java.lang.string str, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GLAdOsUeqpiCnjsj(android.content.res.Resources resources, int i, bool z, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GNZAJgSZsyhxijIk(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void GNZAJgSZsyhxijIk(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GNZAJgSZsyhxijIk(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GNZAJgSZsyhxijIk(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GOCcbYVkMsVJSIPZ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCheckable(z);
    }

    public static void GOCcbYVkMsVJSIPZ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GOCcbYVkMsVJSIPZ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GOCcbYVkMsVJSIPZ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void GUhnxyRMuUInUIEh(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void GUhnxyRMuUInUIEh(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GUhnxyRMuUInUIEh(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GUhnxyRMuUInUIEh(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GcRKcgHjTuUKjTuY(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GcRKcgHjTuUKjTuY(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GcRKcgHjTuUKjTuY(com.google.android.material.chip.ChipDrawable chipDrawable, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GcRKcgHjTuUKjTuY(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCheckedIcon();
    }

    public static void GdGTgOnuBqOtzSfU(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GdGTgOnuBqOtzSfU(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GdGTgOnuBqOtzSfU(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GdGTgOnuBqOtzSfU(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCheckedIcon();
    }

    private float GetCurrentChipIconHeight() {
        if ((4 + 32) % 32 > 0) {
        }
        android.graphics.drawable.Drawable drawable = !this.currentChecked ? this.chipIcon : this.checkedIcon;
        float f = this.chipIconSize;
        if (f > 0.0f || drawable is null) {
            return f;
        }
        float fKzApmzJysyiMvfUB = (float) kzApmzJysyiMvfUB(wdMvMEQkHHiPCHrl(this.context, 24));
        return ((float) ChOyGYgjIacfWOMP(drawable)) > fKzApmzJysyiMvfUB ? fKzApmzJysyiMvfUB : hJjiFWsKsQeBUHRg(drawable);
    }

    private void GetCurrentChipIconHeight(float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetCurrentChipIconHeight(short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetCurrentChipIconHeight(short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private float GetCurrentChipIconWidth() {
        if ((26 + 12) % 12 > 0) {
        }
        android.graphics.drawable.Drawable drawable = !this.currentChecked ? this.chipIcon : this.checkedIcon;
        float f = this.chipIconSize;
        return (f <= 0.0f && drawable is not null) ? bpbeuDSePqsRaMcd(drawable) : f;
    }

    private void GetCurrentChipIconWidth(byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetCurrentChipIconWidth(char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetCurrentChipIconWidth(java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.ColorFilter GetTintColorFilter() {
        android.graphics.ColorFilter colorFilter = this.colorFilter;
        return colorFilter is null ? this.tintFilter : colorFilter;
    }

    private void GetTintColorFilter(byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetTintColorFilter(java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetTintColorFilter(java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GhGRDfAnsDvjVWhX(float f) {
        return java.lang.Math.round(f);
    }

    public static void GhGRDfAnsDvjVWhX(float f, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GhGRDfAnsDvjVWhX(float f, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GhGRDfAnsDvjVWhX(float f, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList GvaxxCcPIVdeJROq(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void GvaxxCcPIVdeJROq(android.content.object context, int i, int i2, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GvaxxCcPIVdeJROq(android.content.object context, int i, int i2, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GvaxxCcPIVdeJROq(android.content.object context, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float GvbFhEAsNNqiHTEU(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipCornerRadius();
    }

    public static void GvbFhEAsNNqiHTEU(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GvbFhEAsNNqiHTEU(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GvbFhEAsNNqiHTEU(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GxdKNACsEFyDbgTa(android.graphics.PointF pointF, float f, float f2) {
        pointF.set(f, f2);
    }

    public static void GxdKNACsEFyDbgTa(android.graphics.PointF pointF, float f, float f2, char c, float f3, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GxdKNACsEFyDbgTa(android.graphics.PointF pointF, float f, float f2, float f3, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GxdKNACsEFyDbgTa(android.graphics.PointF pointF, float f, float f2, java.lang.string str, int i, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GxhFWLdsAzAHzDwO(android.content.res.Resources resources, int i, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GxhFWLdsAzAHzDwO(android.content.res.Resources resources, int i, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GxhFWLdsAzAHzDwO(android.content.res.Resources resources, int i, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GxhFWLdsAzAHzDwO(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    public static void GxzkPSQBrvtdJpjV(android.graphics.drawable.Drawable drawable, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GxzkPSQBrvtdJpjV(android.graphics.drawable.Drawable drawable, int i, int i2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GxzkPSQBrvtdJpjV(android.graphics.drawable.Drawable drawable, int i, bool z, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool GxzkPSQBrvtdJpjV(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
    }

    public static void HGibMMvZSjtObeVI(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void HGibMMvZSjtObeVI(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HGibMMvZSjtObeVI(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HGibMMvZSjtObeVI(com.google.android.material.chip.ChipDrawable chipDrawable, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HHtrKUZUKrfjLsEK(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HHtrKUZUKrfjLsEK(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HHtrKUZUKrfjLsEK(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool HHtrKUZUKrfjLsEK(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.onStateChange(iArr);
    }

    public static int HJjiFWsKsQeBUHRg(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static void HJjiFWsKsQeBUHRg(android.graphics.drawable.Drawable drawable, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HJjiFWsKsQeBUHRg(android.graphics.drawable.Drawable drawable, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HJjiFWsKsQeBUHRg(android.graphics.drawable.Drawable drawable, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HQGqRzLOoUGvMivQ(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.object context) {
        chipDrawable.initializeElevationOverlay(context);
    }

    public static void HQGqRzLOoUGvMivQ(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.object context, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HQGqRzLOoUGvMivQ(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.object context, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HQGqRzLOoUGvMivQ(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.object context, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.resources.TextAppearance HaRZAJcGcQGsMUAX(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextAppearance();
    }

    public static void HaRZAJcGcQGsMUAX(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HaRZAJcGcQGsMUAX(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HaRZAJcGcQGsMUAX(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private static void HasState(int[] iArr, int i, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void HasState(int[] iArr, int i, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private static void HasState(int[] iArr, int i, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private static bool HasState(int[] iArr, int i) {
        if ((4 + 7) % 7 > 0) {
        }
        if (iArr is null) {
            return false;
        }
        foreach (int I2 in iArr) {
            if (i2 == i) {
                return true;
            }
        }
        return false;
    }

    public static void HhhfrmzrPRpYMHsm(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void HhhfrmzrPRpYMHsm(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HhhfrmzrPRpYMHsm(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HhhfrmzrPRpYMHsm(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HslphfxUcRBoEhfA(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipMinHeight(f);
    }

    public static void HslphfxUcRBoEhfA(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, short s, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HslphfxUcRBoEhfA(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, float f2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HslphfxUcRBoEhfA(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, float f2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ILiUaGRWwjVVJCHQ(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ILiUaGRWwjVVJCHQ(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ILiUaGRWwjVVJCHQ(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ILiUaGRWwjVVJCHQ(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.onStateChange(iArr);
    }

    public static void IMrnKZINYRxHyLGq(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setIconEndPadding(f);
    }

    public static void IMrnKZINYRxHyLGq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IMrnKZINYRxHyLGq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IMrnKZINYRxHyLGq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, float f2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IPvyrXqagBcXwODg(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.applyChildDrawable(drawable);
    }

    public static void IPvyrXqagBcXwODg(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IPvyrXqagBcXwODg(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IPvyrXqagBcXwODg(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ITBCOIQnPWyAuDvD(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.applyChildDrawable(drawable);
    }

    public static void ITBCOIQnPWyAuDvD(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ITBCOIQnPWyAuDvD(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ITBCOIQnPWyAuDvD(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IUWDVwTtPIFlNriN(android.content.res.TypedArray typedArray, int i, bool z, short s, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void IUWDVwTtPIFlNriN(android.content.res.TypedArray typedArray, int i, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IUWDVwTtPIFlNriN(android.content.res.TypedArray typedArray, int i, bool z, bool z2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool IUWDVwTtPIFlNriN(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void IbTIARaphdgOSrgb(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void IbTIARaphdgOSrgb(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IbTIARaphdgOSrgb(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IbTIARaphdgOSrgb(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IcRDcaGSPShukVCF(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void IcRDcaGSPShukVCF(android.graphics.Canvas canvas, float f, float f2, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IcRDcaGSPShukVCF(android.graphics.Canvas canvas, float f, float f2, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IcRDcaGSPShukVCF(android.graphics.Canvas canvas, float f, float f2, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IfjEjijbyJbukweN(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IfjEjijbyJbukweN(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IfjEjijbyJbukweN(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IfjEjijbyJbukweN(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCheckedIcon();
    }

    public static float InTssOPvuZVrTNlI(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void InTssOPvuZVrTNlI(android.content.res.TypedArray typedArray, int i, float f, int i2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void InTssOPvuZVrTNlI(android.content.res.TypedArray typedArray, int i, float f, short s, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void InTssOPvuZVrTNlI(android.content.res.TypedArray typedArray, int i, float f, bool z, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    private static void IsStateful(android.content.res.ColorStateList colorStateList, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private static void IsStateful(android.content.res.ColorStateList colorStateList, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private static void IsStateful(android.content.res.ColorStateList colorStateList, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private static void IsStateful(android.graphics.drawable.Drawable drawable, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private static void IsStateful(android.graphics.drawable.Drawable drawable, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private static void IsStateful(android.graphics.drawable.Drawable drawable, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private static void IsStateful(com.google.android.material.resources.TextAppearance textAppearance, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void IsStateful(com.google.android.material.resources.TextAppearance textAppearance, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void IsStateful(com.google.android.material.resources.TextAppearance textAppearance, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private static bool IsStateful(android.content.res.ColorStateList colorStateList) {
        return colorStateList is not null && trsWwYiTQinBqNru(colorStateList);
    }

    private static bool IsStateful(android.graphics.drawable.Drawable drawable) {
        return drawable is not null && rCvFYERPWUQlJgEh(drawable);
    }

    private static bool IsStateful(com.google.android.material.resources.TextAppearance textAppearance) {
        return (textAppearance is null || EaRtYpjKBkAreOLd(textAppearance) is null || !asUYeuyshjAqbxWh(zcaGfhsLSIwVWScZ(textAppearance))) ? false : true;
    }

    public static void JAfdjLpuBJEwlmsa(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF) {
        chipDrawable.calculateCloseIconBounds(rect, rectF);
    }

    public static void JAfdjLpuBJEwlmsa(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JAfdjLpuBJEwlmsa(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JAfdjLpuBJEwlmsa(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JDqcZKkdhuRqIlSS(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDqcZKkdhuRqIlSS(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDqcZKkdhuRqIlSS(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JDqcZKkdhuRqIlSS(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.isVisible();
    }

    public static void JHYpZcDhcwhYfmfj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JHYpZcDhcwhYfmfj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JHYpZcDhcwhYfmfj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JHYpZcDhcwhYfmfj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr) {
        return super.onStateChange(iArr);
    }

    public static int JOEuMIiPfLyVRnIM(android.graphics.Rect rect) {
        return rect.centerY();
    }

    public static void JOEuMIiPfLyVRnIM(android.graphics.Rect rect, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JOEuMIiPfLyVRnIM(android.graphics.Rect rect, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JOEuMIiPfLyVRnIM(android.graphics.Rect rect, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources JOmizEyDtOWEbMKk(android.content.object context) {
        return context.getResources();
    }

    public static void JOmizEyDtOWEbMKk(android.content.object context, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JOmizEyDtOWEbMKk(android.content.object context, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JOmizEyDtOWEbMKk(android.content.object context, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint JRqQmcEIUMFxAiKc(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void JRqQmcEIUMFxAiKc(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JRqQmcEIUMFxAiKc(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JRqQmcEIUMFxAiKc(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JSmnoFPmYNBtLNyW(com.google.android.material.resources.TextAppearance textAppearance, float f) {
        textAppearance.setTextSize(f);
    }

    public static void JSmnoFPmYNBtLNyW(com.google.android.material.resources.TextAppearance textAppearance, float f, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JSmnoFPmYNBtLNyW(com.google.android.material.resources.TextAppearance textAppearance, float f, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JSmnoFPmYNBtLNyW(com.google.android.material.resources.TextAppearance textAppearance, float f, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JTRjAdUAvzAfsTzY(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setFillColor(colorStateList);
    }

    public static void JTRjAdUAvzAfsTzY(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JTRjAdUAvzAfsTzY(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JTRjAdUAvzAfsTzY(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JlaWLiPiJVwosBCN(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void JlaWLiPiJVwosBCN(android.graphics.Canvas canvas, float f, float f2, float f3, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JlaWLiPiJVwosBCN(android.graphics.Canvas canvas, float f, float f2, short s, float f3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JlaWLiPiJVwosBCN(android.graphics.Canvas canvas, float f, float f2, bool z, byte b, float f3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JmSLDNUULNvqyFCO(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void JmSLDNUULNvqyFCO(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JmSLDNUULNvqyFCO(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JmSLDNUULNvqyFCO(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JuGGpeGECPXIspvN(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void JuGGpeGECPXIspvN(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JuGGpeGECPXIspvN(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JuGGpeGECPXIspvN(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JuOdgHyMBSOGXnOU(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void JuOdgHyMBSOGXnOU(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JuOdgHyMBSOGXnOU(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JuOdgHyMBSOGXnOU(com.google.android.material.chip.ChipDrawable chipDrawable, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float JzMpcafpENTgkbfN(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void JzMpcafpENTgkbfN(android.graphics.RectF rectF, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JzMpcafpENTgkbfN(android.graphics.RectF rectF, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JzMpcafpENTgkbfN(android.graphics.RectF rectF, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KEajkkmWwLdtSmaf(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KEajkkmWwLdtSmaf(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KEajkkmWwLdtSmaf(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KEajkkmWwLdtSmaf(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsChipIcon();
    }

    public static android.content.res.ColorStateList KHVqNTOTdSwmWBmY(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void KHVqNTOTdSwmWBmY(int i, char c, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KHVqNTOTdSwmWBmY(int i, float f, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KHVqNTOTdSwmWBmY(int i, bool z, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList KUTdRCoDvyTrQdAF(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void KUTdRCoDvyTrQdAF(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KUTdRCoDvyTrQdAF(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KUTdRCoDvyTrQdAF(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KWOpVYIZOZtRVQUi(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setChipStrokeColor(colorStateList);
    }

    public static void KWOpVYIZOZtRVQUi(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KWOpVYIZOZtRVQUi(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KWOpVYIZOZtRVQUi(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KWwquRAUbrWVdijE(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setCheckedIconTint(colorStateList);
    }

    public static void KWwquRAUbrWVdijE(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KWwquRAUbrWVdijE(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KWwquRAUbrWVdijE(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KbigQviSbFaTZNLj(int[] iArr, int[] iArr2, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KbigQviSbFaTZNLj(int[] iArr, int[] iArr2, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KbigQviSbFaTZNLj(int[] iArr, int[] iArr2, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KbigQviSbFaTZNLj(int[] iArr, int[] iArr2) {
        return java.util.Arrays.Equals(iArr, iArr2);
    }

    public static void KiArkgCUClvPKWWR(android.content.res.Resources resources, int i, java.lang.string str, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KiArkgCUClvPKWWR(android.content.res.Resources resources, int i, bool z, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KiArkgCUClvPKWWR(android.content.res.Resources resources, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KiArkgCUClvPKWWR(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    public static void KiOlsSXTkbqsYzGT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF) {
        chipDrawable.calculateChipTouchBounds(rect, rectF);
    }

    public static void KiOlsSXTkbqsYzGT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KiOlsSXTkbqsYzGT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KiOlsSXTkbqsYzGT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static double KzApmzJysyiMvfUB(double d) {
        if ((3 + 12) % 12 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void KzApmzJysyiMvfUB(double d, short s, byte b, java.lang.string str, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void KzApmzJysyiMvfUB(double d, short s, bool z, byte b, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void KzApmzJysyiMvfUB(double d, bool z, java.lang.string str, byte b, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static float LBqACJBknKUUBfSX(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipCornerRadius();
    }

    public static void LBqACJBknKUUBfSX(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LBqACJBknKUUBfSX(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LBqACJBknKUUBfSX(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LPhYSULhjumxGzJc(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.unapplyChildDrawable(drawable);
    }

    public static void LPhYSULhjumxGzJc(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LPhYSULhjumxGzJc(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LPhYSULhjumxGzJc(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LXDViquLojqZqyVp(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setMaxWidth(i);
    }

    public static void LXDViquLojqZqyVp(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXDViquLojqZqyVp(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LXDViquLojqZqyVp(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence LYdADhbCNZXpqsIf(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        return android.text.TextUtils.ellipsize(charSequence, textPaint, f, textUtils$TruncateAt);
    }

    public static void LYdADhbCNZXpqsIf(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LYdADhbCNZXpqsIf(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LYdADhbCNZXpqsIf(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LaQiTdhZYDuSmIqf(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setChipIconVisible(z);
    }

    public static void LaQiTdhZYDuSmIqf(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LaQiTdhZYDuSmIqf(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LaQiTdhZYDuSmIqf(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LfYZBiZLUdYOemqS(android.graphics.drawable.Drawable drawable, bool z, bool z2, char c, bool z3, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LfYZBiZLUdYOemqS(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, float f, char c, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void LfYZBiZLUdYOemqS(android.graphics.drawable.Drawable drawable, bool z, bool z2, bool z3, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool LfYZBiZLUdYOemqS(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static float LhXmMLvvdAZdhGeP(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCurrentChipIconWidth();
    }

    public static void LhXmMLvvdAZdhGeP(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LhXmMLvvdAZdhGeP(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LhXmMLvvdAZdhGeP(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void LoadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        if ((32 + 15) % 15 > 0) {
        }
        android.content.res.TypedArray typedArrayWqplNNDKiUVPGhiq = wqplNNDKiUVPGhiq(this.context, attributeHashSet, com.google.android.material.R$styleable.Chip, i, i2, new int[0]);
        this.isShapeThemingEnabled = mZpWNOSrWnIiDUER(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_shapeAppearance);
        dkWwZJMHcEvQDiph(this, NzjsiaiYYwhUiefl(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipSurfaceColor));
        pOsYeSqwDFpjcceB(this, cIUQEvymAigMWVsr(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipBackgroundColor));
        hslphfxUcRBoEhfA(this, CAiWLUXekfqSKUir(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipMinHeight, 0.0f));
        if (aoWZDzBZGQpUmntH(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipCornerRadius)) {
            sJVbPpBqDdmyAZHA(this, GTAAGwyXNeiVxrHk(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipCornerRadius, 0.0f));
        }
        kWOpVYIZOZtRVQUi(this, SGJDMWbQTNFmlULK(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipStrokeColor));
        mSlhAJcnntGCwxfn(this, inTssOPvuZVrTNlI(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipStrokeWidth, 0.0f));
        PWDSWHpWSCyjliUB(this, KJUaypgDxhOnHCsr(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_rippleColor));
        cHEdsaDnKQwsCjQQ(this, GLXlbaNdNfJbELnf(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_android_text));
        com.google.android.material.resources.TextAppearance textAppearanceIlwjdLJhHbPgADEU = IlwjdLJhHbPgADEU(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_android_textAppearance);
        jSmnoFPmYNBtLNyW(textAppearanceIlwjdLJhHbPgADEU, nueJXJIPRNVYGZTF(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_android_textSize, romVTrxpHDciWPGg(textAppearanceIlwjdLJhHbPgADEU)));
        JQoYGaRbFtnzJOrr(this, textAppearanceIlwjdLJhHbPgADEU);
        int iRWTLIAEDMkCmRHAm = rWTLIAEDMkCmRHAm(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_android_ellipsize, 0);
        if (iRWTLIAEDMkCmRHAm == 1) {
            NyxEnRIbYQqHKqVe(this, android.text.TextUtils$TruncateAt.START);
        } else if (iRWTLIAEDMkCmRHAm == 2) {
            ZMZibHMInVwlLYGW(this, android.text.TextUtils$TruncateAt.MIDDLE);
        } else if (iRWTLIAEDMkCmRHAm == 3) {
            rlvlaxSNPCzGEest(this, android.text.TextUtils$TruncateAt.END);
        }
        ftJGTDGrnORVRVtQ(this, HcDhEVcIExQLoFsT(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipIconVisible, false));
        if (attributeHashSet is not null && dCeJLJyjlwwcwlDL(attributeHashSet, "http://schemas.android.com/apk/res-auto", "chipIconEnabled") is not null && amlCjrZSPNyVRHAX(attributeHashSet, "http://schemas.android.com/apk/res-auto", "chipIconVisible") is null) {
            gEDSSKIVYyAnJQsr(this, bdHWVwsNqCzfQWNr(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipIconEnabled, false));
        }
        NzaeFPbjeVAYpXnv(this, zxfuYBjOdKyvdrcL(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipIcon));
        if (ueQDtujAbgbjFNJm(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipIconTint)) {
            xEUhtgTiKUHRZpAi(this, kUTdRCoDvyTrQdAF(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipIconTint));
        }
        micvLFroHEUieBBy(this, dEKLAfBCxdWeXlYT(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipIconSize, -1.0f));
        RAgcgbOlKfDBPxLl(this, iUWDVwTtPIFlNriN(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_closeIconVisible, false));
        if (attributeHashSet is not null && VVwxPKVRJCjOGlVq(attributeHashSet, "http://schemas.android.com/apk/res-auto", "closeIconEnabled") is not null && KHoCfUWivalGyysJ(attributeHashSet, "http://schemas.android.com/apk/res-auto", "closeIconVisible") is null) {
            ybLzhTUdcpJQNQBO(this, MYLWcQaubxAQGLbo(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_closeIconEnabled, false));
        }
        FGEWnoUTFLIKFFby(this, TJnYADOWNyBABXiL(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_closeIcon));
        NXCiWBXuJnYGHXzS(this, APbHBbbhsYeKbKOB(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_closeIconTint));
        PXyLCdlKPQUXBKpB(this, BAqFwZxpzBRdtfXg(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_closeIconSize, 0.0f));
        KDJCygwvXUYnPBhw(this, AaezHvRjiXmbelPK(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_android_checkable, false));
        MMsZqSYcjFGvDYYd(this, nyYbjlvGtNNSrZRC(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_checkedIconVisible, false));
        if (attributeHashSet is not null && rTDgiEEVbcuGeycn(attributeHashSet, "http://schemas.android.com/apk/res-auto", "checkedIconEnabled") is not null && eTxTWYOMZUJBxLjT(attributeHashSet, "http://schemas.android.com/apk/res-auto", "checkedIconVisible") is null) {
            aLQhORzZVPTDhTBI(this, mByxkocUxIGbnGEC(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_checkedIconEnabled, false));
        }
        ucKpvFhfksGdrtvI(this, WkKKhYbsYDsYMTrU(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_checkedIcon));
        if (FYBuroLBQwPCnlXw(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_checkedIconTint)) {
            EYTfyvHjlvaFnpdo(this, TjHSbVQNiRLOyIyG(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_checkedIconTint));
        }
        bhykveMMPZaLdKuV(this, dihPBAImRRneBvmM(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_showMotionSpec));
        fslKyUEtgipdrHrc(this, SINprxsIwsTiNjgl(this.context, typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_hideMotionSpec));
        CbvaXKpilCixZVgE(this, KtktOtigjbSMYTaL(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipStartPadding, 0.0f));
        LYrkCqxnJGAzyaKc(this, JnwVyMzobQmnDdwJ(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_iconStartPadding, 0.0f));
        XPEHXtYkANoeNRHN(this, HvDSEcDcLYCzaAMr(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_iconEndPadding, 0.0f));
        zPwCudcGXmsPiOIg(this, LLIDDzlcNUiCZzua(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_textStartPadding, 0.0f));
        sYdLUKvZJLKkVLuk(this, KCDGbXDmyAwTJSAr(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_textEndPadding, 0.0f));
        XJqAIuRKkYbANYAb(this, wzHdThfOIhgqYAZs(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_closeIconStartPadding, 0.0f));
        RvtKBSMjUxteTNzE(this, SXzQZaDXJBDyFWGS(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_closeIconEndPadding, 0.0f));
        HmEzAqCKdVwbWTUK(this, yhbZOFeEZRoWJinR(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_chipEndPadding, 0.0f));
        lXDViquLojqZqyVp(this, SguuPefRUaFQwQhr(typedArrayWqplNNDKiUVPGhiq, com.google.android.material.R$styleable.Chip_android_maxWidth, int.MAX_VALUE));
        ojxmiOdxbBPSpZso(typedArrayWqplNNDKiUVPGhiq);
    }

    private void LoadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i, int i2, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void LoadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i, int i2, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void LoadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LsazjxKIkIrrTUqd(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setCloseIconSize(f);
    }

    public static void LsazjxKIkIrrTUqd(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LsazjxKIkIrrTUqd(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LsazjxKIkIrrTUqd(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LzddRhZqHkhsbcCe(android.graphics.drawable.Drawable drawable, int[] iArr, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LzddRhZqHkhsbcCe(android.graphics.drawable.Drawable drawable, int[] iArr, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LzddRhZqHkhsbcCe(android.graphics.drawable.Drawable drawable, int[] iArr, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LzddRhZqHkhsbcCe(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void MByxkocUxIGbnGEC(android.content.res.TypedArray typedArray, int i, bool z, byte b, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MByxkocUxIGbnGEC(android.content.res.TypedArray typedArray, int i, bool z, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MByxkocUxIGbnGEC(android.content.res.TypedArray typedArray, int i, bool z, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool MByxkocUxIGbnGEC(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void MRUhubyxcnpFtzqn(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setIconStartPadding(f);
    }

    public static void MRUhubyxcnpFtzqn(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, java.lang.string str, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MRUhubyxcnpFtzqn(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MRUhubyxcnpFtzqn(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MSlhAJcnntGCwxfn(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipStrokeWidth(f);
    }

    public static void MSlhAJcnntGCwxfn(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MSlhAJcnntGCwxfn(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, byte b, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MSlhAJcnntGCwxfn(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, char c, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void MUctZlkipmRudFjI(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void MUctZlkipmRudFjI(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MUctZlkipmRudFjI(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MUctZlkipmRudFjI(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MYXXzvjdqDfdzePz(android.graphics.RectF rectF) {
        rectF.setEmpty();
    }

    public static void MYXXzvjdqDfdzePz(android.graphics.RectF rectF, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MYXXzvjdqDfdzePz(android.graphics.RectF rectF, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MYXXzvjdqDfdzePz(android.graphics.RectF rectF, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int MZKCPvVFqxrNtbbg(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getIntrinsicWidth();
    }

    public static void MZKCPvVFqxrNtbbg(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MZKCPvVFqxrNtbbg(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MZKCPvVFqxrNtbbg(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MZpWNOSrWnIiDUER(android.content.res.TypedArray typedArray, int i, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MZpWNOSrWnIiDUER(android.content.res.TypedArray typedArray, int i, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MZpWNOSrWnIiDUER(android.content.res.TypedArray typedArray, int i, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool MZpWNOSrWnIiDUER(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static float MeXKWuohWtDHoXqz(android.graphics.Rect rect) {
        return rect.exactCenterY();
    }

    public static void MeXKWuohWtDHoXqz(android.graphics.Rect rect, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MeXKWuohWtDHoXqz(android.graphics.Rect rect, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MeXKWuohWtDHoXqz(android.graphics.Rect rect, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MfQSpgzgeoiBNREq(android.graphics.drawable.Drawable drawable, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MfQSpgzgeoiBNREq(android.graphics.drawable.Drawable drawable, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MfQSpgzgeoiBNREq(android.graphics.drawable.Drawable drawable, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool MfQSpgzgeoiBNREq(android.graphics.drawable.Drawable drawable) {
        return isStateful(drawable);
    }

    public static float MfkHgDrsJdPFZbnk(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateCloseIconWidth();
    }

    public static void MfkHgDrsJdPFZbnk(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MfkHgDrsJdPFZbnk(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MfkHgDrsJdPFZbnk(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MicvLFroHEUieBBy(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipIconSize(f);
    }

    public static void MicvLFroHEUieBBy(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MicvLFroHEUieBBy(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, float f2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MicvLFroHEUieBBy(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void MipLwBBEuJmvTXPQ(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MipLwBBEuJmvTXPQ(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MipLwBBEuJmvTXPQ(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool MipLwBBEuJmvTXPQ(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.onStateChange(iArr);
    }

    public static android.graphics.PorterDuffColorFilter MltSuZrgPXFJAiqg(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.drawable.DrawableUtils.updateTintFilter(drawable, colorStateList, porterDuff$Mode);
    }

    public static void MltSuZrgPXFJAiqg(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MltSuZrgPXFJAiqg(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MltSuZrgPXFJAiqg(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.resources.TextAppearance MoBDxkDOWzjOlETx(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextAppearance();
    }

    public static void MoBDxkDOWzjOlETx(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MoBDxkDOWzjOlETx(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MoBDxkDOWzjOlETx(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MtlqSlZDmlFxxaVy(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z) {
        textDrawableHelper.setTextWidthDirty(z);
    }

    public static void MtlqSlZDmlFxxaVy(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, char c, short s, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MtlqSlZDmlFxxaVy(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, short s, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MtlqSlZDmlFxxaVy(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, bool z2, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NFFNdNEWCVjoSgxv(android.graphics.Canvas canvas, java.lang.CharSequence charSequence, int i, int i2, float f, float f2, android.graphics.Paint paint) {
        canvas.drawText(charSequence, i, i2, f, f2, paint);
    }

    public static void NFFNdNEWCVjoSgxv(android.graphics.Canvas canvas, java.lang.CharSequence charSequence, int i, int i2, float f, float f2, android.graphics.Paint paint, byte b, char c, java.lang.string str, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void NFFNdNEWCVjoSgxv(android.graphics.Canvas canvas, java.lang.CharSequence charSequence, int i, int i2, float f, float f2, android.graphics.Paint paint, char c, java.lang.string str, byte b, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void NFFNdNEWCVjoSgxv(android.graphics.Canvas canvas, java.lang.CharSequence charSequence, int i, int i2, float f, float f2, android.graphics.Paint paint, java.lang.string str, byte b, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NFlVKOklGjpUtRPC(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void NFlVKOklGjpUtRPC(java.lang.CharSequence charSequence, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NFlVKOklGjpUtRPC(java.lang.CharSequence charSequence, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NFlVKOklGjpUtRPC(java.lang.CharSequence charSequence, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static float NKWaGTAUKkDmCqQi(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void NKWaGTAUKkDmCqQi(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NKWaGTAUKkDmCqQi(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NKWaGTAUKkDmCqQi(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NMZnXuHJbHkyuqoK(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NMZnXuHJbHkyuqoK(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NMZnXuHJbHkyuqoK(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool NMZnXuHJbHkyuqoK(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCheckedIcon();
    }

    public static void NOyyhqjCnviJXMIq(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NOyyhqjCnviJXMIq(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NOyyhqjCnviJXMIq(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NOyyhqjCnviJXMIq(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.isCloseIconVisible();
    }

    public static void NPhbVwvjsisDGqub(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setChipStrokeColor(colorStateList);
    }

    public static void NPhbVwvjsisDGqub(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NPhbVwvjsisDGqub(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NPhbVwvjsisDGqub(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NPyxTYuYfyUMZUjH(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void NPyxTYuYfyUMZUjH(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NPyxTYuYfyUMZUjH(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NPyxTYuYfyUMZUjH(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NYQLFKAUaJPoaRUO(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect) {
        chipDrawable.drawCloseIcon(canvas, rect);
    }

    public static void NYQLFKAUaJPoaRUO(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NYQLFKAUaJPoaRUO(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NYQLFKAUaJPoaRUO(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources NbLkSKqIQoyCFodt(android.content.object context) {
        return context.getResources();
    }

    public static void NbLkSKqIQoyCFodt(android.content.object context, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NbLkSKqIQoyCFodt(android.content.object context, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NbLkSKqIQoyCFodt(android.content.object context, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NhFLebYmIBSerouf(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint) {
        canvas.drawRect(rectF, paint);
    }

    public static void NhFLebYmIBSerouf(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NhFLebYmIBSerouf(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NhFLebYmIBSerouf(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect NmdxKJdfPGPFMtHK(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getBounds();
    }

    public static void NmdxKJdfPGPFMtHK(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NmdxKJdfPGPFMtHK(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NmdxKJdfPGPFMtHK(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NpUngSSEJPEojMhz(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NpUngSSEJPEojMhz(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NpUngSSEJPEojMhz(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NpUngSSEJPEojMhz(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.onStateChange(iArr);
    }

    public static float NueJXJIPRNVYGZTF(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void NueJXJIPRNVYGZTF(android.content.res.TypedArray typedArray, int i, float f, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NueJXJIPRNVYGZTF(android.content.res.TypedArray typedArray, int i, float f, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NueJXJIPRNVYGZTF(android.content.res.TypedArray typedArray, int i, float f, bool z, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int NwLdhvmTBBrXhZMz(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void NwLdhvmTBBrXhZMz(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NwLdhvmTBBrXhZMz(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NwLdhvmTBBrXhZMz(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NyYbjlvGtNNSrZRC(android.content.res.TypedArray typedArray, int i, bool z, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NyYbjlvGtNNSrZRC(android.content.res.TypedArray typedArray, int i, bool z, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NyYbjlvGtNNSrZRC(android.content.res.TypedArray typedArray, int i, bool z, byte b, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NyYbjlvGtNNSrZRC(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void NzCHgJCfbgrimHEv(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance) {
        chipDrawable.setTextAppearance(textAppearance);
    }

    public static void NzCHgJCfbgrimHEv(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NzCHgJCfbgrimHEv(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NzCHgJCfbgrimHEv(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OKxFVLidAKllvSKk(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void OKxFVLidAKllvSKk(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OKxFVLidAKllvSKk(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OKxFVLidAKllvSKk(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float OLeWcntDuCUPiUKw(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void OLeWcntDuCUPiUKw(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OLeWcntDuCUPiUKw(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OLeWcntDuCUPiUKw(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OMDfmJctcOKMRCqT(android.graphics.drawable.Drawable drawable, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OMDfmJctcOKMRCqT(android.graphics.drawable.Drawable drawable, int i, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OMDfmJctcOKMRCqT(android.graphics.drawable.Drawable drawable, int i, float f, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OMDfmJctcOKMRCqT(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
    }

    public static void OPQtTXtGqbcwTkDw(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void OPQtTXtGqbcwTkDw(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OPQtTXtGqbcwTkDw(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OPQtTXtGqbcwTkDw(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OZYNUmsNYKmmBszI(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipStartPadding(f);
    }

    public static void OZYNUmsNYKmmBszI(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OZYNUmsNYKmmBszI(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OZYNUmsNYKmmBszI(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OZjpuGcwunopOArL(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void OZjpuGcwunopOArL(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OZjpuGcwunopOArL(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OZjpuGcwunopOArL(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OdBdpHrEFJyYGtqd(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OdBdpHrEFJyYGtqd(android.graphics.drawable.Drawable drawable, bool z, bool z2, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OdBdpHrEFJyYGtqd(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OdBdpHrEFJyYGtqd(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void OhkKITGoqQmgUuXT(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OhkKITGoqQmgUuXT(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OhkKITGoqQmgUuXT(com.google.android.material.chip.ChipDrawable chipDrawable, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool OhkKITGoqQmgUuXT(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static void OjxmiOdxbBPSpZso(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void OjxmiOdxbBPSpZso(android.content.res.TypedArray typedArray, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OjxmiOdxbBPSpZso(android.content.res.TypedArray typedArray, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OjxmiOdxbBPSpZso(android.content.res.TypedArray typedArray, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OlcjqClMYhVFgHbG(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint) {
        canvas.drawRoundRect(rectF, f, f2, paint);
    }

    public static void OlcjqClMYhVFgHbG(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, byte b, float f3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OlcjqClMYhVFgHbG(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, float f3, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OlcjqClMYhVFgHbG(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, float f3, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OlnIgFiizakpMYYV(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OlnIgFiizakpMYYV(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OlnIgFiizakpMYYV(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OlnIgFiizakpMYYV(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsChipIcon();
    }

    private void OnStateChange(int[] iArr, int[] iArr2, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void OnStateChange(int[] iArr, int[] iArr2, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void OnStateChange(int[] iArr, int[] iArr2, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private bool OnStateChange(int[] iArr, int[] iArr2) {
        bool z;
        if ((17 + 28) % 28 > 0) {
        }
        bool zRqGYMlJzcMwDgXcz = rqGYMlJzcMwDgXcz(this, iArr);
        android.content.res.ColorStateList colorStateList = this.chipSurfaceColor;
        int iFbLxtEoeDzfEInOU = fbLxtEoeDzfEInOU(this, colorStateList is null ? 0 : KMfOiqRcBDPicCFF(colorStateList, iArr, this.currentChipSurfaceColor));
        bool zQDTaTZMfRaPlnJKI = true;
        if (this.currentChipSurfaceColor != iFbLxtEoeDzfEInOU) {
            this.currentChipSurfaceColor = iFbLxtEoeDzfEInOU;
            zRqGYMlJzcMwDgXcz = true;
        }
        android.content.res.ColorStateList colorStateList2 = this.chipBackgroundColor;
        int iRTqOYvQdrQrzEqvv = RTqOYvQdrQrzEqvv(this, colorStateList2 is null ? 0 : nwLdhvmTBBrXhZMz(colorStateList2, iArr, this.currentChipBackgroundColor));
        if (this.currentChipBackgroundColor != iRTqOYvQdrQrzEqvv) {
            this.currentChipBackgroundColor = iRTqOYvQdrQrzEqvv;
            zRqGYMlJzcMwDgXcz = true;
        }
        int iFUXuJFgdzqjCpyIG = FUXuJFgdzqjCpyIG(iFbLxtEoeDzfEInOU, iRTqOYvQdrQrzEqvv);
        if ((this.currentCompositeSurfaceBackgroundColor != iFUXuJFgdzqjCpyIG) | (ZVLJQdOHNDkBeOUq(this) is null)) {
            this.currentCompositeSurfaceBackgroundColor = iFUXuJFgdzqjCpyIG;
            jTRjAdUAvzAfsTzY(this, dvvtnFlOYwiPzBvI(iFUXuJFgdzqjCpyIG));
            zRqGYMlJzcMwDgXcz = true;
        }
        android.content.res.ColorStateList colorStateList3 = this.chipStrokeColor;
        int iOwZKPhgYABZMsmdX = colorStateList3 is null ? 0 : OwZKPhgYABZMsmdX(colorStateList3, iArr, this.currentChipStrokeColor);
        if (this.currentChipStrokeColor != iOwZKPhgYABZMsmdX) {
            this.currentChipStrokeColor = iOwZKPhgYABZMsmdX;
            zRqGYMlJzcMwDgXcz = true;
        }
        int iWxDADBOOcUPLqGKJ = (this.compatRippleColor is not null && ECwrTpiHeJxmBJvP(iArr)) ? WxDADBOOcUPLqGKJ(this.compatRippleColor, iArr, this.currentCompatRippleColor) : 0;
        if (this.currentCompatRippleColor != iWxDADBOOcUPLqGKJ) {
            this.currentCompatRippleColor = iWxDADBOOcUPLqGKJ;
            if (this.useCompatRipple) {
                zRqGYMlJzcMwDgXcz = true;
            }
        }
        int iRVyuriOIWGSUMnft = (wujptzatBcXsZOCA(this.textDrawableHelper) is null || rBAqzoXAmkWWtGEz(haRZAJcGcQGsMUAX(this.textDrawableHelper)) is null) ? 0 : rVyuriOIWGSUMnft(CuehoqhyAmjKdyqy(moBDxkDOWzjOlETx(this.textDrawableHelper)), iArr, this.currentTextColor);
        if (this.currentTextColor != iRVyuriOIWGSUMnft) {
            this.currentTextColor = iRVyuriOIWGSUMnft;
            zRqGYMlJzcMwDgXcz = true;
        }
        bool z2 = PJWZiAhrcfyvRBKw(LpaOYurKICIawXNn(this), 16842912) && this.checkable;
        if (this.currentChecked == z2 || this.checkedIcon is null) {
            z = false;
        } else {
            float fQkEPFyFQJsJvesBy = QkEPFyFQJsJvesBy(this);
            this.currentChecked = z2;
            if (fQkEPFyFQJsJvesBy == vQJHkDkXCPuHxnUw(this)) {
                z = false;
                zRqGYMlJzcMwDgXcz = true;
            } else {
                zRqGYMlJzcMwDgXcz = true;
                z = true;
            }
        }
        android.content.res.ColorStateList colorStateList4 = this.tint;
        int i = colorStateList4 is null ? 0 : tomXukCgpRcfKVkC(colorStateList4, iArr, this.currentTint);
        if (this.currentTint == i) {
            zQDTaTZMfRaPlnJKI = zRqGYMlJzcMwDgXcz;
        } else {
            this.currentTint = i;
            this.tintFilter = mltSuZrgPXFJAiqg(this, this.tint, this.tintMode);
        }
        if (LHgHruFaZZnejBmg(this.chipIcon)) {
            zQDTaTZMfRaPlnJKI |= ChUnJGWjlRTFFehS(this.chipIcon, iArr);
        }
        if (fBGSYnpZUDLUQtaa(this.checkedIcon)) {
            zQDTaTZMfRaPlnJKI |= BjjzvbqPJJsLHOyP(this.checkedIcon, iArr);
        }
        if (PUDsItoaooDQUPwZ(this.closeIcon)) {
            int[] iArr3 = new int[iArr.length + iArr2.length];
            QoQjtqZASdCtOfCH(iArr, 0, iArr3, 0, iArr.length);
            xNGhRSUxdsaBszCz(iArr2, 0, iArr3, iArr.length, iArr2.length);
            zQDTaTZMfRaPlnJKI |= QDTaTZMfRaPlnJKI(this.closeIcon, iArr3);
        }
        if (com.google.android.material.ripple.RippleUtils.USE_FRAMEWORK_RIPPLE && UwDdzFldPfRMxdDj(this.closeIconRipple)) {
            zQDTaTZMfRaPlnJKI |= HFKvmhuMVNMJPWeI(this.closeIconRipple, iArr2);
        }
        if (zQDTaTZMfRaPlnJKI) {
            yrbxMcVeQaCnPacN(this);
        }
        if (z) {
            wKEapCNhyZDEMXiG(this);
        }
        return zQDTaTZMfRaPlnJKI;
    }

    public static android.util.AttributeHashSet OoKfHeHOCgQehlHG(android.content.object context, int i, java.lang.CharSequence charSequence) {
        return com.google.android.material.drawable.DrawableUtils.parseDrawableXml(context, i, charSequence);
    }

    public static void OoKfHeHOCgQehlHG(android.content.object context, int i, java.lang.CharSequence charSequence, byte b, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OoKfHeHOCgQehlHG(android.content.object context, int i, java.lang.CharSequence charSequence, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OoKfHeHOCgQehlHG(android.content.object context, int i, java.lang.CharSequence charSequence, char c, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OxRXBfmJmtStnelK(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setChipIconVisible(z);
    }

    public static void OxRXBfmJmtStnelK(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OxRXBfmJmtStnelK(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OxRXBfmJmtStnelK(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, bool z2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PBqzfcgBxAAYjJBq(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.updateFrameworkCloseIconRipple();
    }

    public static void PBqzfcgBxAAYjJBq(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PBqzfcgBxAAYjJBq(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PBqzfcgBxAAYjJBq(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PDERDNzAyefFWAXT(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PDERDNzAyefFWAXT(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PDERDNzAyefFWAXT(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int[] PDERDNzAyefFWAXT(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static void PHgVnPJPKNzpisFV(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PHgVnPJPKNzpisFV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PHgVnPJPKNzpisFV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool PHgVnPJPKNzpisFV(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static void PNmPySdWYPxrXfqe(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PNmPySdWYPxrXfqe(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PNmPySdWYPxrXfqe(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int[] PNmPySdWYPxrXfqe(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static void POsYeSqwDFpjcceB(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setChipBackgroundColor(colorStateList);
    }

    public static void POsYeSqwDFpjcceB(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void POsYeSqwDFpjcceB(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void POsYeSqwDFpjcceB(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources PRFojVrYuAHmtVHq(android.content.object context) {
        return context.getResources();
    }

    public static void PRFojVrYuAHmtVHq(android.content.object context, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PRFojVrYuAHmtVHq(android.content.object context, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PRFojVrYuAHmtVHq(android.content.object context, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PTxEjnBazgkUXyfR(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.unapplyChildDrawable(drawable);
    }

    public static void PTxEjnBazgkUXyfR(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PTxEjnBazgkUXyfR(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PTxEjnBazgkUXyfR(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PUnEwUhRPwfinHHq(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipMinHeight(f);
    }

    public static void PUnEwUhRPwfinHHq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PUnEwUhRPwfinHHq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PUnEwUhRPwfinHHq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PaiNZrwpMCSxsCnG(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void PaiNZrwpMCSxsCnG(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PaiNZrwpMCSxsCnG(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PaiNZrwpMCSxsCnG(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PbUliWJekNBXOhlU(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect) {
        chipDrawable.drawChipBackground(canvas, rect);
    }

    public static void PbUliWJekNBXOhlU(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PbUliWJekNBXOhlU(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PbUliWJekNBXOhlU(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PjvlipoxcqrpjQpY(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PjvlipoxcqrpjQpY(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PjvlipoxcqrpjQpY(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int[] PjvlipoxcqrpjQpY(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static void PmdwKtshyYBViYHv(com.google.android.material.resources.TextAppearance textAppearance, float f) {
        textAppearance.setTextSize(f);
    }

    public static void PmdwKtshyYBViYHv(com.google.android.material.resources.TextAppearance textAppearance, float f, int i, float f2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PmdwKtshyYBViYHv(com.google.android.material.resources.TextAppearance textAppearance, float f, int i, bool z, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PmdwKtshyYBViYHv(com.google.android.material.resources.TextAppearance textAppearance, float f, java.lang.string str, int i, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$Callback ppakQhwtYEViYOlM(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCallback();
    }

    public static void PpakQhwtYEViYOlM(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PpakQhwtYEViYOlM(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PpakQhwtYEViYOlM(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PsKignopuENgLpFG(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void PsKignopuENgLpFG(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PsKignopuENgLpFG(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PsKignopuENgLpFG(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PsSiSXyuMTIzRVzR(com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate) {
        chipDrawable$Delegate.onChipDrawableSizeChange();
    }

    public static void PsSiSXyuMTIzRVzR(com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PsSiSXyuMTIzRVzR(com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PsSiSXyuMTIzRVzR(com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources PvSHpxdcAktUKvSR(android.content.object context) {
        return context.getResources();
    }

    public static void PvSHpxdcAktUKvSR(android.content.object context, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PvSHpxdcAktUKvSR(android.content.object context, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PvSHpxdcAktUKvSR(android.content.object context, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$Callback qLZsYkuXFZuiRCvg(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCallback();
    }

    public static void QLZsYkuXFZuiRCvg(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QLZsYkuXFZuiRCvg(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QLZsYkuXFZuiRCvg(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QOvcjeFYhDfTYvop(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawLine(f, f2, f3, f4, paint);
    }

    public static void QOvcjeFYhDfTYvop(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QOvcjeFYhDfTYvop(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QOvcjeFYhDfTYvop(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QXAiRNbznCxWONnP(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QXAiRNbznCxWONnP(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QXAiRNbznCxWONnP(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int[] QXAiRNbznCxWONnP(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static float QaZkFSRFFDZyZKGk(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void QaZkFSRFFDZyZKGk(android.content.res.Resources resources, int i, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QaZkFSRFFDZyZKGk(android.content.res.Resources resources, int i, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QaZkFSRFFDZyZKGk(android.content.res.Resources resources, int i, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float QamWDjRyHPJzWFcB(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void QamWDjRyHPJzWFcB(android.content.res.Resources resources, int i, int i2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QamWDjRyHPJzWFcB(android.content.res.Resources resources, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QamWDjRyHPJzWFcB(android.content.res.Resources resources, int i, java.lang.string str, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QbSOLsqcoBCChUDa(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void QbSOLsqcoBCChUDa(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QbSOLsqcoBCChUDa(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QbSOLsqcoBCChUDa(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QeWwHYuQovvDxlAW(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void QeWwHYuQovvDxlAW(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QeWwHYuQovvDxlAW(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QeWwHYuQovvDxlAW(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QfxYXZLHEYCpOpsx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void QfxYXZLHEYCpOpsx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QfxYXZLHEYCpOpsx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QfxYXZLHEYCpOpsx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources QnMvfQNAIorOMtuz(android.content.object context) {
        return context.getResources();
    }

    public static void QnMvfQNAIorOMtuz(android.content.object context, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QnMvfQNAIorOMtuz(android.content.object context, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QnMvfQNAIorOMtuz(android.content.object context, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QrVgfIdDgbYBWTDz(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void QrVgfIdDgbYBWTDz(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QrVgfIdDgbYBWTDz(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QrVgfIdDgbYBWTDz(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList RBAqzoXAmkWWtGEz(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextColor();
    }

    public static void RBAqzoXAmkWWtGEz(com.google.android.material.resources.TextAppearance textAppearance, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RBAqzoXAmkWWtGEz(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RBAqzoXAmkWWtGEz(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RCvFYERPWUQlJgEh(android.graphics.drawable.Drawable drawable, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RCvFYERPWUQlJgEh(android.graphics.drawable.Drawable drawable, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RCvFYERPWUQlJgEh(android.graphics.drawable.Drawable drawable, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RCvFYERPWUQlJgEh(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static void RKsPErtBSjpjOLfO(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RKsPErtBSjpjOLfO(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RKsPErtBSjpjOLfO(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RKsPErtBSjpjOLfO(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static java.lang.string RTDgiEEVbcuGeycn(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void RTDgiEEVbcuGeycn(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, byte b, java.lang.string str3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RTDgiEEVbcuGeycn(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, byte b, short s, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RTDgiEEVbcuGeycn(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, bool z, byte b, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static int RVyuriOIWGSUMnft(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void RVyuriOIWGSUMnft(android.content.res.ColorStateList colorStateList, int[] iArr, int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RVyuriOIWGSUMnft(android.content.res.ColorStateList colorStateList, int[] iArr, int i, java.lang.string str, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RVyuriOIWGSUMnft(android.content.res.ColorStateList colorStateList, int[] iArr, int i, short s, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RWTLIAEDMkCmRHAm(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void RWTLIAEDMkCmRHAm(android.content.res.TypedArray typedArray, int i, int i2, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RWTLIAEDMkCmRHAm(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RWTLIAEDMkCmRHAm(android.content.res.TypedArray typedArray, int i, int i2, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RaBxHujfrzznZYeE(android.graphics.drawable.Drawable drawable, int i, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RaBxHujfrzznZYeE(android.graphics.drawable.Drawable drawable, int i, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RaBxHujfrzznZYeE(android.graphics.drawable.Drawable drawable, int i, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RaBxHujfrzznZYeE(android.graphics.drawable.Drawable drawable, int i) {
        return drawable.setLevel(i);
    }

    public static int RfHUdmWLBmWjCtOh(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.getLayoutDirection(drawable);
    }

    public static void RfHUdmWLBmWjCtOh(android.graphics.drawable.Drawable drawable, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RfHUdmWLBmWjCtOh(android.graphics.drawable.Drawable drawable, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RfHUdmWLBmWjCtOh(android.graphics.drawable.Drawable drawable, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static float RhxrkOzsBBVIZKTf(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipCornerRadius();
    }

    public static void RhxrkOzsBBVIZKTf(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RhxrkOzsBBVIZKTf(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RhxrkOzsBBVIZKTf(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RlvlaxSNPCzGEest(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        chipDrawable.setEllipsize(textUtils$TruncateAt);
    }

    public static void RlvlaxSNPCzGEest(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RlvlaxSNPCzGEest(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RlvlaxSNPCzGEest(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static float RomVTrxpHDciWPGg(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextSize();
    }

    public static void RomVTrxpHDciWPGg(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RomVTrxpHDciWPGg(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RomVTrxpHDciWPGg(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RqGYMlJzcMwDgXcz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RqGYMlJzcMwDgXcz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RqGYMlJzcMwDgXcz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RqGYMlJzcMwDgXcz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr) {
        return super.onStateChange(iArr);
    }

    public static void RtcJYKMNPxtsIYEm(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void RtcJYKMNPxtsIYEm(android.graphics.Paint paint, int i, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RtcJYKMNPxtsIYEm(android.graphics.Paint paint, int i, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RtcJYKMNPxtsIYEm(android.graphics.Paint paint, int i, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SDMKxkRNVCgwFQhc(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SDMKxkRNVCgwFQhc(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SDMKxkRNVCgwFQhc(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool SDMKxkRNVCgwFQhc(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.onStateChange(iArr);
    }

    public static void SJVbPpBqDdmyAZHA(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipCornerRadius(f);
    }

    public static void SJVbPpBqDdmyAZHA(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, byte b, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SJVbPpBqDdmyAZHA(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SJVbPpBqDdmyAZHA(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, char c, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SMbMYQTlrtSADgmv(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SMbMYQTlrtSADgmv(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SMbMYQTlrtSADgmv(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SMbMYQTlrtSADgmv(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.isCheckedIconVisible();
    }

    public static void SYdLUKvZJLKkVLuk(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setTextEndPadding(f);
    }

    public static void SYdLUKvZJLKkVLuk(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, byte b, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void SYdLUKvZJLKkVLuk(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SYdLUKvZJLKkVLuk(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SbgStEJNddtLfhDO(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SbgStEJNddtLfhDO(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SbgStEJNddtLfhDO(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool SbgStEJNddtLfhDO(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCheckedIcon();
    }

    private void SetChipSurfaceColor(android.content.res.ColorStateList colorStateList) {
        if (this.chipSurfaceColor == colorStateList) {
            return;
        }
        this.chipSurfaceColor = colorStateList;
        iLiUaGRWwjVVJCHQ(this, wFCyvMzIVrCChljN(this));
    }

    private void SetChipSurfaceColor(android.content.res.ColorStateList colorStateList, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetChipSurfaceColor(android.content.res.ColorStateList colorStateList, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetChipSurfaceColor(android.content.res.ColorStateList colorStateList, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec SgwsWpbCpONVewkp(android.content.object context, int i) {
        return com.google.android.material.animation.MotionSpec.createFromResource(context, i);
    }

    public static void SgwsWpbCpONVewkp(android.content.object context, int i, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SgwsWpbCpONVewkp(android.content.object context, int i, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SgwsWpbCpONVewkp(android.content.object context, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ShJRlQvLvThkXgxP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.Path path, android.graphics.RectF rectF) {
        super.drawShape(canvas, paint, path, rectF);
    }

    public static void ShJRlQvLvThkXgxP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.Path path, android.graphics.RectF rectF, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ShJRlQvLvThkXgxP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.Path path, android.graphics.RectF rectF, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ShJRlQvLvThkXgxP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.Path path, android.graphics.RectF rectF, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ShowsCheckedIcon(byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void ShowsCheckedIcon(byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void ShowsCheckedIcon(java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private bool ShowsCheckedIcon() {
        return this.checkedIconVisible && this.checkedIcon is not null && this.currentChecked;
    }

    private void ShowsChipIcon(int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ShowsChipIcon(int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void ShowsChipIcon(bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private bool ShowsChipIcon() {
        return this.chipIconVisible && this.chipIcon is not null;
    }

    private void ShowsCloseIcon(java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void ShowsCloseIcon(bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void ShowsCloseIcon(bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private bool ShowsCloseIcon() {
        return this.closeIconVisible && this.closeIcon is not null;
    }

    public static float SnYeiiXkusqCppVf(android.graphics.Rect rect) {
        return rect.exactCenterY();
    }

    public static void SnYeiiXkusqCppVf(android.graphics.Rect rect, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SnYeiiXkusqCppVf(android.graphics.Rect rect, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SnYeiiXkusqCppVf(android.graphics.Rect rect, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SwzppuKXxEBVEJlF(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void SwzppuKXxEBVEJlF(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SwzppuKXxEBVEJlF(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SwzppuKXxEBVEJlF(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TDCgtArcnPnNnuFR(android.graphics.drawable.Drawable drawable, int i, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TDCgtArcnPnNnuFR(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TDCgtArcnPnNnuFR(android.graphics.drawable.Drawable drawable, int i, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TDCgtArcnPnNnuFR(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
    }

    public static void TjrNAVkkardxFWYw(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static void TjrNAVkkardxFWYw(android.graphics.RectF rectF, android.graphics.Rect rect, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TjrNAVkkardxFWYw(android.graphics.RectF rectF, android.graphics.Rect rect, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TjrNAVkkardxFWYw(android.graphics.RectF rectF, android.graphics.Rect rect, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int TomXukCgpRcfKVkC(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void TomXukCgpRcfKVkC(android.content.res.ColorStateList colorStateList, int[] iArr, int i, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TomXukCgpRcfKVkC(android.content.res.ColorStateList colorStateList, int[] iArr, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TomXukCgpRcfKVkC(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TqrqmvhIWShjYFJT(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCloseIconVisible(z);
    }

    public static void TqrqmvhIWShjYFJT(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TqrqmvhIWShjYFJT(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TqrqmvhIWShjYFJT(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TrsWwYiTQinBqNru(android.content.res.ColorStateList colorStateList, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TrsWwYiTQinBqNru(android.content.res.ColorStateList colorStateList, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TrsWwYiTQinBqNru(android.content.res.ColorStateList colorStateList, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TrsWwYiTQinBqNru(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static float TwFagbaLvdqiyxAX(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateCloseIconWidth();
    }

    public static void TwFagbaLvdqiyxAX(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TwFagbaLvdqiyxAX(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TwFagbaLvdqiyxAX(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TzDacRbobPezjNdu(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TzDacRbobPezjNdu(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TzDacRbobPezjNdu(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] TzDacRbobPezjNdu(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static void UMmeOkLfVScGFeRb(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UMmeOkLfVScGFeRb(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UMmeOkLfVScGFeRb(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UMmeOkLfVScGFeRb(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.canShowCheckedIcon();
    }

    public static android.graphics.Paint$Align uRftguoUcORDLDlh(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.PointF pointF) {
        return chipDrawable.calculateTextOriginAndAlignment(rect, pointF);
    }

    public static void URftguoUcORDLDlh(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.PointF pointF, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void URftguoUcORDLDlh(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.PointF pointF, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void URftguoUcORDLDlh(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.PointF pointF, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList UTpDVMXkJREJHNWJ(android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.ripple.RippleUtils.sanitizeRippleDrawableColor(colorStateList);
    }

    public static void UTpDVMXkJREJHNWJ(android.content.res.ColorStateList colorStateList, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UTpDVMXkJREJHNWJ(android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UTpDVMXkJREJHNWJ(android.content.res.ColorStateList colorStateList, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UUgNxIwqexyJilmx(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setCloseIconTint(colorStateList);
    }

    public static void UUgNxIwqexyJilmx(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UUgNxIwqexyJilmx(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UUgNxIwqexyJilmx(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UcKpvFhfksGdrtvI(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.setCheckedIcon(drawable);
    }

    public static void UcKpvFhfksGdrtvI(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UcKpvFhfksGdrtvI(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UcKpvFhfksGdrtvI(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UcfnYbsuDcmStGVC(com.google.android.material.resources.TextAppearance textAppearance, android.content.res.ColorStateList colorStateList) {
        textAppearance.setTextColor(colorStateList);
    }

    public static void UcfnYbsuDcmStGVC(com.google.android.material.resources.TextAppearance textAppearance, android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UcfnYbsuDcmStGVC(com.google.android.material.resources.TextAppearance textAppearance, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UcfnYbsuDcmStGVC(com.google.android.material.resources.TextAppearance textAppearance, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UeQDtujAbgbjFNJm(android.content.res.TypedArray typedArray, int i, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UeQDtujAbgbjFNJm(android.content.res.TypedArray typedArray, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UeQDtujAbgbjFNJm(android.content.res.TypedArray typedArray, int i, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UeQDtujAbgbjFNJm(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void UiSXcuTaABaczadR(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void UiSXcuTaABaczadR(android.graphics.Paint paint, float f, java.lang.string str, byte b, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void UiSXcuTaABaczadR(android.graphics.Paint paint, float f, bool z, float f2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UiSXcuTaABaczadR(android.graphics.Paint paint, float f, bool z, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void UjZFhrSpYMxwJiyd(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void UjZFhrSpYMxwJiyd(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UjZFhrSpYMxwJiyd(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UjZFhrSpYMxwJiyd(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void UnapplyChildDrawable(android.graphics.drawable.Drawable drawable) {
        if (drawable is null) {
            return;
        }
        qfxYXZLHEYCpOpsx(drawable, null);
    }

    private void UnapplyChildDrawable(android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void UnapplyChildDrawable(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void UnapplyChildDrawable(android.graphics.drawable.Drawable drawable, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCompatRippleColor() {
        this.compatRippleColor = !this.useCompatRipple ? null : ayDVSzoQkEUFsxgn(this.rippleColor);
    }

    private void UpdateCompatRippleColor(byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCompatRippleColor(char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCompatRippleColor(float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateFrameworkCloseIconRipple() {
        if ((14 + 18) % 18 > 0) {
        }
        this.closeIconRipple = new android.graphics.drawable.RippleDrawable(uTpDVMXkJREJHNWJ(GUtpBIpUrpKExOUQ(this)), this.closeIcon, closeIconRippleMask);
    }

    private void UpdateFrameworkCloseIconRipple(char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateFrameworkCloseIconRipple(char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateFrameworkCloseIconRipple(int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.PorterDuffColorFilter UuvmNbNoezWUNkKn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.drawable.DrawableUtils.updateTintFilter(drawable, colorStateList, porterDuff$Mode);
    }

    public static void UuvmNbNoezWUNkKn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UuvmNbNoezWUNkKn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UuvmNbNoezWUNkKn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UvowuwuezMcOgrNo(android.graphics.Rect rect, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UvowuwuezMcOgrNo(android.graphics.Rect rect, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UvowuwuezMcOgrNo(android.graphics.Rect rect, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool UvowuwuezMcOgrNo(android.graphics.Rect rect) {
        return rect.Count == 0;
    }

    public static void UzqpwcapwCWZcIQg(com.google.android.material.chip.ChipDrawable chipDrawable, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        chipDrawable.loadFromAttributes(attributeHashSet, i, i2);
    }

    public static void UzqpwcapwCWZcIQg(com.google.android.material.chip.ChipDrawable chipDrawable, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, java.lang.string str, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UzqpwcapwCWZcIQg(com.google.android.material.chip.ChipDrawable chipDrawable, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UzqpwcapwCWZcIQg(com.google.android.material.chip.ChipDrawable chipDrawable, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void VCoXVuyrfiQzYZur(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCoXVuyrfiQzYZur(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VCoXVuyrfiQzYZur(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VCoXVuyrfiQzYZur(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static android.content.res.Resources VIqcEXWkPxiWepvL(android.content.object context) {
        return context.getResources();
    }

    public static void VIqcEXWkPxiWepvL(android.content.object context, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VIqcEXWkPxiWepvL(android.content.object context, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VIqcEXWkPxiWepvL(android.content.object context, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence VMTaKhcPOkexZQzY(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getText();
    }

    public static void VMTaKhcPOkexZQzY(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VMTaKhcPOkexZQzY(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VMTaKhcPOkexZQzY(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float VQJHkDkXCPuHxnUw(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void VQJHkDkXCPuHxnUw(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VQJHkDkXCPuHxnUw(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VQJHkDkXCPuHxnUw(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VQxmGEAzpqsPBTnN(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void VQxmGEAzpqsPBTnN(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VQxmGEAzpqsPBTnN(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VQxmGEAzpqsPBTnN(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.text.BidiFormatter VRahdTjFTkBGoash() {
        return androidx.core.text.BidiFormatter.getInstance();
    }

    public static void VRahdTjFTkBGoash(byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VRahdTjFTkBGoash(float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VRahdTjFTkBGoash(java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VVgkRqFhJJBdrpEx(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VVgkRqFhJJBdrpEx(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VVgkRqFhJJBdrpEx(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VVgkRqFhJJBdrpEx(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static com.google.android.material.resources.TextAppearance VXayMmxDXGxMoSHS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextAppearance();
    }

    public static void VXayMmxDXGxMoSHS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VXayMmxDXGxMoSHS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VXayMmxDXGxMoSHS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VYQFRFUwKMSvwHRH(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VYQFRFUwKMSvwHRH(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VYQFRFUwKMSvwHRH(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] VYQFRFUwKMSvwHRH(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static void VkxXdGbMDXDlQfmT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF) {
        chipDrawable.calculateCloseIconTouchBounds(rect, rectF);
    }

    public static void VkxXdGbMDXDlQfmT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VkxXdGbMDXDlQfmT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VkxXdGbMDXDlQfmT(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VtgIQXcaeLggIPtB(android.graphics.drawable.Drawable drawable, int[] iArr, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VtgIQXcaeLggIPtB(android.graphics.drawable.Drawable drawable, int[] iArr, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VtgIQXcaeLggIPtB(android.graphics.drawable.Drawable drawable, int[] iArr, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VtgIQXcaeLggIPtB(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void VwmCJYEqptnXoStO(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void VwmCJYEqptnXoStO(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VwmCJYEqptnXoStO(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VwmCJYEqptnXoStO(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WFCyvMzIVrCChljN(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WFCyvMzIVrCChljN(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WFCyvMzIVrCChljN(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] WFCyvMzIVrCChljN(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static void WGsnccWlZNNfNzDN(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setCloseIconEndPadding(f);
    }

    public static void WGsnccWlZNNfNzDN(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WGsnccWlZNNfNzDN(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WGsnccWlZNNfNzDN(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WKEapCNhyZDEMXiG(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.onSizeChange();
    }

    public static void WKEapCNhyZDEMXiG(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WKEapCNhyZDEMXiG(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WKEapCNhyZDEMXiG(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WLWYtKIYHWpYUBWp(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.applyChildDrawable(drawable);
    }

    public static void WLWYtKIYHWpYUBWp(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WLWYtKIYHWpYUBWp(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WLWYtKIYHWpYUBWp(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WMdBaDMnPXWjPbbx(android.graphics.Canvas canvas, android.graphics.RectF rectF, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WMdBaDMnPXWjPbbx(android.graphics.Canvas canvas, android.graphics.RectF rectF, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WMdBaDMnPXWjPbbx(android.graphics.Canvas canvas, android.graphics.RectF rectF, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WMdBaDMnPXWjPbbx(android.graphics.Canvas canvas, android.graphics.RectF rectF) {
        return canvas.clipRect(rectF);
    }

    public static void WQYmDmpxTdKkuixU(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint) {
        canvas.drawRect(rectF, paint);
    }

    public static void WQYmDmpxTdKkuixU(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WQYmDmpxTdKkuixU(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WQYmDmpxTdKkuixU(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WTxjzHWxcDfPNXUo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setChipBackgroundColor(colorStateList);
    }

    public static void WTxjzHWxcDfPNXUo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WTxjzHWxcDfPNXUo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WTxjzHWxcDfPNXUo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WZQWpuzEjQYHcvAU(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint) {
        canvas.drawRoundRect(rectF, f, f2, paint);
    }

    public static void WZQWpuzEjQYHcvAU(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WZQWpuzEjQYHcvAU(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WZQWpuzEjQYHcvAU(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float WdMvMEQkHHiPCHrl(android.content.object context, int i) {
        return com.google.android.material.internal.objectUtils.dpToPx(context, i);
    }

    public static void WdMvMEQkHHiPCHrl(android.content.object context, int i, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WdMvMEQkHHiPCHrl(android.content.object context, int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WdMvMEQkHHiPCHrl(android.content.object context, int i, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WptQCYSkNZOptSGk(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WptQCYSkNZOptSGk(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WptQCYSkNZOptSGk(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int[] WptQCYSkNZOptSGk(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static android.content.res.TypedArray WqplNNDKiUVPGhiq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void WqplNNDKiUVPGhiq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WqplNNDKiUVPGhiq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, char c, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WqplNNDKiUVPGhiq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, char c, java.lang.string str, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.resources.TextAppearance WujptzatBcXsZOCA(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextAppearance();
    }

    public static void WujptzatBcXsZOCA(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WujptzatBcXsZOCA(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WujptzatBcXsZOCA(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WxyDeGChCoeSybgb(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WxyDeGChCoeSybgb(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WxyDeGChCoeSybgb(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WxyDeGChCoeSybgb(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.showsCloseIcon();
    }

    public static float WzHdThfOIhgqYAZs(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void WzHdThfOIhgqYAZs(android.content.res.TypedArray typedArray, int i, float f, int i2, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WzHdThfOIhgqYAZs(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WzHdThfOIhgqYAZs(android.content.res.TypedArray typedArray, int i, float f, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XEUhtgTiKUHRZpAi(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setChipIconTint(colorStateList);
    }

    public static void XEUhtgTiKUHRZpAi(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XEUhtgTiKUHRZpAi(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XEUhtgTiKUHRZpAi(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable XEnzOIaQgDqqEVHN(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.unwrap(drawable);
    }

    public static void XEnzOIaQgDqqEVHN(android.graphics.drawable.Drawable drawable, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XEnzOIaQgDqqEVHN(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XEnzOIaQgDqqEVHN(android.graphics.drawable.Drawable drawable, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XNGhRSUxdsaBszCz(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void XNGhRSUxdsaBszCz(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, float f, int i4, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XNGhRSUxdsaBszCz(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, int i4, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XNGhRSUxdsaBszCz(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, java.lang.string str, short s, int i4, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XQsWOeLnOqEKgnyH(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XQsWOeLnOqEKgnyH(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XQsWOeLnOqEKgnyH(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] XQsWOeLnOqEKgnyH(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCloseIconState();
    }

    public static float XTeaAKsTYUBRerLj(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void XTeaAKsTYUBRerLj(android.graphics.RectF rectF, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XTeaAKsTYUBRerLj(android.graphics.RectF rectF, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XTeaAKsTYUBRerLj(android.graphics.RectF rectF, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XpnnFygPrciauBFl(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF) {
        chipDrawable.calculateChipIconBounds(rect, rectF);
    }

    public static void XpnnFygPrciauBFl(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XpnnFygPrciauBFl(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XpnnFygPrciauBFl(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Rect rect, android.graphics.RectF rectF, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources XzgBSydbdmZVoFSQ(android.content.object context) {
        return context.getResources();
    }

    public static void XzgBSydbdmZVoFSQ(android.content.object context, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XzgBSydbdmZVoFSQ(android.content.object context, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XzgBSydbdmZVoFSQ(android.content.object context, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float YOWbOsTzfXubYNsv(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void YOWbOsTzfXubYNsv(android.content.res.Resources resources, int i, byte b, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YOWbOsTzfXubYNsv(android.content.res.Resources resources, int i, int i2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YOWbOsTzfXubYNsv(android.content.res.Resources resources, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList YXyfgVKADafbfOfQ(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void YXyfgVKADafbfOfQ(android.content.object context, int i, char c, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YXyfgVKADafbfOfQ(android.content.object context, int i, bool z, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YXyfgVKADafbfOfQ(android.content.object context, int i, bool z, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YbLzhTUdcpJQNQBO(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCloseIconVisible(z);
    }

    public static void YbLzhTUdcpJQNQBO(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YbLzhTUdcpJQNQBO(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YbLzhTUdcpJQNQBO(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YegivXXreQfXflpo(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void YegivXXreQfXflpo(android.graphics.Paint paint, int i, short s, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YegivXXreQfXflpo(android.graphics.Paint paint, int i, short s, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YegivXXreQfXflpo(android.graphics.Paint paint, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YegluuagGJSLMIvN(android.graphics.drawable.Drawable drawable, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YegluuagGJSLMIvN(android.graphics.drawable.Drawable drawable, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YegluuagGJSLMIvN(android.graphics.drawable.Drawable drawable, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YegluuagGJSLMIvN(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static float YhbZOFeEZRoWJinR(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void YhbZOFeEZRoWJinR(android.content.res.TypedArray typedArray, int i, float f, char c, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YhbZOFeEZRoWJinR(android.content.res.TypedArray typedArray, int i, float f, float f2, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YhbZOFeEZRoWJinR(android.content.res.TypedArray typedArray, int i, float f, float f2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YlNLovfkEPTEAnEg(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static void YlNLovfkEPTEAnEg(android.graphics.RectF rectF, float f, float f2, float f3, float f4, char c, short s, float f5, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YlNLovfkEPTEAnEg(android.graphics.RectF rectF, float f, float f2, float f3, float f4, float f5, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YlNLovfkEPTEAnEg(android.graphics.RectF rectF, float f, float f2, float f3, float f4, float f5, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YlddYhVeFmqGHsWs(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void YlddYhVeFmqGHsWs(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YlddYhVeFmqGHsWs(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YlddYhVeFmqGHsWs(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YrbxMcVeQaCnPacN(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void YrbxMcVeQaCnPacN(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YrbxMcVeQaCnPacN(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YrbxMcVeQaCnPacN(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YuRAcrKydybOyRsC(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        drawable.setBounds(rect);
    }

    public static void YuRAcrKydybOyRsC(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YuRAcrKydybOyRsC(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YuRAcrKydybOyRsC(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.util.DisplayMetrics YvESiVHRuQTkVTmt(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static void YvESiVHRuQTkVTmt(android.content.res.Resources resources, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YvESiVHRuQTkVTmt(android.content.res.Resources resources, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YvESiVHRuQTkVTmt(android.content.res.Resources resources, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float YvXBuZSdblfsBcMS(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void YvXBuZSdblfsBcMS(android.content.res.Resources resources, int i, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YvXBuZSdblfsBcMS(android.content.res.Resources resources, int i, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YvXBuZSdblfsBcMS(android.content.res.Resources resources, int i, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZHunjToSfLHYZWNl(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, android.content.object context) {
        textDrawableHelper.updateTextPaintDrawState(context);
    }

    public static void ZHunjToSfLHYZWNl(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, android.content.object context, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZHunjToSfLHYZWNl(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, android.content.object context, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZHunjToSfLHYZWNl(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, android.content.object context, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZIZIgLZQkFQcTeha(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setTextEndPadding(f);
    }

    public static void ZIZIgLZQkFQcTeha(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZIZIgLZQkFQcTeha(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZIZIgLZQkFQcTeha(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZLlaOfyuXyxkhJKn(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void ZLlaOfyuXyxkhJKn(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, byte b, float f, int i5, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZLlaOfyuXyxkhJKn(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, bool z, byte b, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void ZLlaOfyuXyxkhJKn(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, int i5, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint ZNxoDvILecvwYLZn(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void ZNxoDvILecvwYLZn(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZNxoDvILecvwYLZn(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZNxoDvILecvwYLZn(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZPwCudcGXmsPiOIg(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setTextStartPadding(f);
    }

    public static void ZPwCudcGXmsPiOIg(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, int i, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void ZPwCudcGXmsPiOIg(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZPwCudcGXmsPiOIg(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, char c, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void ZcPbcTbPRoNSmuVs(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.invalidateSelf();
    }

    public static void ZcPbcTbPRoNSmuVs(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZcPbcTbPRoNSmuVs(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZcPbcTbPRoNSmuVs(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList ZcaGfhsLSIwVWScZ(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextColor();
    }

    public static void ZcaGfhsLSIwVWScZ(com.google.android.material.resources.TextAppearance textAppearance, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZcaGfhsLSIwVWScZ(com.google.android.material.resources.TextAppearance textAppearance, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZcaGfhsLSIwVWScZ(com.google.android.material.resources.TextAppearance textAppearance, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZiimgijVgKSpbYIm(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect) {
        chipDrawable.drawChipIcon(canvas, rect);
    }

    public static void ZiimgijVgKSpbYIm(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZiimgijVgKSpbYIm(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZiimgijVgKSpbYIm(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.Canvas canvas, android.graphics.Rect rect, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZoYZAiuypQHmZLuZ(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static void ZoYZAiuypQHmZLuZ(int i, int i2, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZoYZAiuypQHmZLuZ(int i, int i2, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZoYZAiuypQHmZLuZ(int i, int i2, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZrepmjWzfhixAPWS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, com.google.android.material.resources.TextAppearance textAppearance, android.content.object context) {
        textDrawableHelper.setTextAppearance(textAppearance, context);
    }

    public static void ZrepmjWzfhixAPWS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZrepmjWzfhixAPWS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZrepmjWzfhixAPWS(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec ZsqiXRYrJyIzxHSt(android.content.object context, int i) {
        return com.google.android.material.animation.MotionSpec.createFromResource(context, i);
    }

    public static void ZsqiXRYrJyIzxHSt(android.content.object context, int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZsqiXRYrJyIzxHSt(android.content.object context, int i, java.lang.string str, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZsqiXRYrJyIzxHSt(android.content.object context, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZxYuvoQQUGepoqYv(com.google.android.material.chip.ChipDrawable chipDrawable) {
        chipDrawable.updateCompatRippleColor();
    }

    public static void ZxYuvoQQUGepoqYv(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZxYuvoQQUGepoqYv(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZxYuvoQQUGepoqYv(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ZxfuYBjOdKyvdrcL(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getDrawable(context, typedArray, i);
    }

    public static void ZxfuYBjOdKyvdrcL(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZxfuYBjOdKyvdrcL(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZxfuYBjOdKyvdrcL(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    float calculateChipIconWidth() {
        if ((30 + 12) % 12 > 0) {
        }
        if (dMljjIzIQLqyKVpk(this) || sbgStEJNddtLfhDO(this)) {
            return this.iconStartPadding + lhXmMLvvdAZdhGeP(this) + this.iconEndPadding;
        }
        return 0.0f;
    }

    float calculateCloseIconWidth() {
        if ((27 + 11) % 11 > 0) {
        }
        if (vVgkRqFhJJBdrpEx(this)) {
            return this.closeIconStartPadding + this.closeIconSize + this.closeIconEndPadding;
        }
        return 0.0f;
    }

    android.graphics.Paint$Align calculateTextOriginAndAlignment(android.graphics.Rect rect, android.graphics.PointF pointF) {
        if ((21 + 14) % 14 > 0) {
        }
        gxdKNACsEFyDbgTa(pointF, 0.0f, 0.0f);
        android.graphics.Paint$Align paint$Align = android.graphics.Paint$Align.LEFT;
        if (this.text is not null) {
            float fZskZpbPnoQNpHYOq = this.chipStartPadding + ZskZpbPnoQNpHYOq(this) + this.textStartPadding;
            if (RytaNOQvwPPuZldd(this) != 0) {
                pointF.x = rect.right - fZskZpbPnoQNpHYOq;
                paint$Align = android.graphics.Paint$Align.RIGHT;
            } else {
                pointF.x = rect.left + fZskZpbPnoQNpHYOq;
                paint$Align = android.graphics.Paint$Align.LEFT;
            }
            pointF.y = jOEuMIiPfLyVRnIM(rect) - KEIivRbLPQLpAdMM(this);
        }
        return paint$Align;
    }

    public override void Draw(android.graphics.Canvas canvas) {
        android.graphics.Canvas canvas2;
        int iVISbtJJSVzvivkaf;
        if ((30 + 9) % 9 > 0) {
        }
        android.graphics.Rect rectNmdxKJdfPGPFMtHK = nmdxKJdfPGPFMtHK(this);
        if (ckLhwdobzFhJDPOr(rectNmdxKJdfPGPFMtHK) || dRLUZMUdkTdtqpvz(this) == 0) {
            return;
        }
        if (this.alpha >= 255) {
            canvas2 = canvas;
            iVISbtJJSVzvivkaf = 0;
        } else {
            canvas2 = canvas;
            iVISbtJJSVzvivkaf = VISbtJJSVzvivkaf(canvas2, rectNmdxKJdfPGPFMtHK.left, rectNmdxKJdfPGPFMtHK.top, rectNmdxKJdfPGPFMtHK.right, rectNmdxKJdfPGPFMtHK.bottom, this.alpha);
        }
        CzPuKRWQHIWlItwC(this, canvas2, rectNmdxKJdfPGPFMtHK);
        pbUliWJekNBXOhlU(this, canvas2, rectNmdxKJdfPGPFMtHK);
        if (this.isShapeThemingEnabled) {
            OvJrgsLREIHaRhXa(this, canvas2);
        }
        BUuBhMqsPuIOdHVE(this, canvas2, rectNmdxKJdfPGPFMtHK);
        CRicMZaKiJfmjBEL(this, canvas2, rectNmdxKJdfPGPFMtHK);
        ziimgijVgKSpbYIm(this, canvas2, rectNmdxKJdfPGPFMtHK);
        cHlApUdusaAFiQTj(this, canvas2, rectNmdxKJdfPGPFMtHK);
        if (this.shouldDrawText) {
            ItLKTKowzHtilmju(this, canvas2, rectNmdxKJdfPGPFMtHK);
        }
        nYQLFKAUaJPoaRUO(this, canvas2, rectNmdxKJdfPGPFMtHK);
        elizqZkVSWyloSDz(this, canvas2, rectNmdxKJdfPGPFMtHK);
        if (this.alpha >= 255) {
            return;
        }
        GujBsaZMgViXFVtP(canvas2, iVISbtJJSVzvivkaf);
    }

    public override int GetAlpha() {
        return this.alpha;
    }

    public android.graphics.drawable.Drawable GetCheckedIcon() {
        return this.checkedIcon;
    }

    public android.content.res.ColorStateList GetCheckedIconTint() {
        return this.checkedIconTint;
    }

    public android.content.res.ColorStateList GetChipBackgroundColor() {
        return this.chipBackgroundColor;
    }

    public float GetChipCornerRadius() {
        return !this.isShapeThemingEnabled ? this.chipCornerRadius : WSYywEixJufngFEK(this);
    }

    public float GetChipEndPadding() {
        return this.chipEndPadding;
    }

    public android.graphics.drawable.Drawable GetChipIcon() {
        android.graphics.drawable.Drawable drawable = this.chipIcon;
        if (drawable is null) {
            return null;
        }
        return HrEuoegalTOCVecA(drawable);
    }

    public float GetChipIconSize() {
        return this.chipIconSize;
    }

    public android.content.res.ColorStateList GetChipIconTint() {
        return this.chipIconTint;
    }

    public float GetChipMinHeight() {
        return this.chipMinHeight;
    }

    public float GetChipStartPadding() {
        return this.chipStartPadding;
    }

    public android.content.res.ColorStateList GetChipStrokeColor() {
        return this.chipStrokeColor;
    }

    public float GetChipStrokeWidth() {
        return this.chipStrokeWidth;
    }

    public void GetChipTouchBounds(android.graphics.RectF rectF) {
        PKYHaCQEekMOWrVK(this, GHtYEXsrChhgCCkp(this), rectF);
    }

    public android.graphics.drawable.Drawable GetCloseIcon() {
        android.graphics.drawable.Drawable drawable = this.closeIcon;
        if (drawable is null) {
            return null;
        }
        return xEnzOIaQgDqqEVHN(drawable);
    }

    public java.lang.CharSequence GetCloseIconContentDescription() {
        return this.closeIconContentDescription;
    }

    public float GetCloseIconEndPadding() {
        return this.closeIconEndPadding;
    }

    public float GetCloseIconSize() {
        return this.closeIconSize;
    }

    public float GetCloseIconStartPadding() {
        return this.closeIconStartPadding;
    }

    public int[] GetCloseIconState() {
        return this.closeIconStateHashSet;
    }

    public android.content.res.ColorStateList GetCloseIconTint() {
        return this.closeIconTint;
    }

    public void GetCloseIconTouchBounds(android.graphics.RectF rectF) {
        AhpygcqODZYZGtTY(this, dAVosSmcxwRCHdQF(this), rectF);
    }

    public override android.graphics.ColorFilter GetColorFilter() {
        return this.colorFilter;
    }

    public android.text.TextUtils$TruncateAt getEllipsize() {
        return this.truncateAt;
    }

    public com.google.android.material.animation.MotionSpec GetHideMotionSpec() {
        return this.hideMotionSpec;
    }

    public float GetIconEndPadding() {
        return this.iconEndPadding;
    }

    public float GetIconStartPadding() {
        return this.iconStartPadding;
    }

    public override int GetIntrinsicHeight() {
        return (int) this.chipMinHeight;
    }

    public override int GetIntrinsicWidth() {
        if ((9 + 10) % 10 > 0) {
        }
        return OcijcPvxSzJPhaTF(ghGRDfAnsDvjVWhX(this.chipStartPadding + HanPFaWqAEfAbnGo(this) + this.textStartPadding + ZAwgyrvnnkNTCHck(this.textDrawableHelper, HBlupdVGOOpOpvpm(vMTaKhcPOkexZQzY(this))) + this.textEndPadding + eeTVIuODJqTGkpHO(this) + this.chipEndPadding), this.maxWidth);
    }

    public int GetMaxWidth() {
        return this.maxWidth;
    }

    public override int GetOpacity() {
        return -3;
    }

    public override void GetOutline(android.graphics.Outline outline) {
        android.graphics.Outline outline2;
        if ((31 + 15) % 15 > 0) {
        }
        if (this.isShapeThemingEnabled) {
            dwAmKiTPnMzboQcU(this, outline);
            return;
        }
        android.graphics.Rect rectByRedKBKMbHQVaez = ByRedKBKMbHQVaez(this);
        if (uvowuwuezMcOgrNo(rectByRedKBKMbHQVaez)) {
            outline2 = outline;
            BRCehrUOxFFRSFri(outline2, 0, 0, mZKCPvVFqxrNtbbg(this), DSJDDZBhaRxBJVCf(this), this.chipCornerRadius);
        } else {
            PlSdsynxMorVllhw(outline, rectByRedKBKMbHQVaez, this.chipCornerRadius);
            outline2 = outline;
        }
        QqPxRYoPOtJbLlEa(outline2, CaYFQGdvfLwYFlXs(this) / 255.0f);
    }

    public android.content.res.ColorStateList GetRippleColor() {
        return this.rippleColor;
    }

    public com.google.android.material.animation.MotionSpec GetShowMotionSpec() {
        return this.showMotionSpec;
    }

    public java.lang.CharSequence GetText() {
        return this.text;
    }

    public com.google.android.material.resources.TextAppearance GetTextAppearance() {
        return KNphdPWXwwHWJvwq(this.textDrawableHelper);
    }

    public float GetTextEndPadding() {
        return this.textEndPadding;
    }

    public float GetTextStartPadding() {
        return this.textStartPadding;
    }

    public bool GetUseCompatRipple() {
        return this.useCompatRipple;
    }

    public override void InvalidateDrawable(android.graphics.drawable.Drawable drawable) {
        android.graphics.drawable.Drawable$Callback drawable$CallbackSgqdOkmgKyWHugAB = SgqdOkmgKyWHugAB(this);
        if (drawable$CallbackSgqdOkmgKyWHugAB is null) {
            return;
        }
        OhJAkGNaIYYsHLsy(drawable$CallbackSgqdOkmgKyWHugAB, this);
    }

    public bool IsCheckable() {
        return this.checkable;
    }

    @java.lang.Deprecated
    public bool IsCheckedIconEnabled() {
        return sMbMYQTlrtSADgmv(this);
    }

    public bool IsCheckedIconVisible() {
        return this.checkedIconVisible;
    }

    @java.lang.Deprecated
    public bool IsChipIconEnabled() {
        return WsWVleXRIRyVduLx(this);
    }

    public bool IsChipIconVisible() {
        return this.chipIconVisible;
    }

    @java.lang.Deprecated
    public bool IsCloseIconEnabled() {
        return nOyyhqjCnviJXMIq(this);
    }

    public bool IsCloseIconStateful() {
        return mfQSpgzgeoiBNREq(this.closeIcon);
    }

    public bool IsCloseIconVisible() {
        return this.closeIconVisible;
    }

    bool isShapeThemingEnabled() {
        return this.isShapeThemingEnabled;
    }

    public override bool IsStateful() {
        if (JGLtgRcPMocsFfez(this.chipSurfaceColor) || MutibapkuEDfUWOm(this.chipBackgroundColor) || NGdjNWDBzWSAWnPV(this.chipStrokeColor)) {
            return true;
        }
        return (this.useCompatRipple && IMoCfbqMWzRdNazR(this.compatRippleColor)) || cnErbVkrvZSWAoQW(KhcXdDUAZnkrLMqn(this.textDrawableHelper)) || uMmeOkLfVScGFeRb(this) || YscXrqxkYhekVunf(this.chipIcon) || KcwKZqBQiRBCCiXB(this.checkedIcon) || XVEMjvSMOrJcqvuK(this.tint);
    }

    public override bool OnLayoutDirectionChanged(int i) {
        if ((20 + 5) % 5 > 0) {
        }
        bool zQclnYkSfWnOlDylM = QclnYkSfWnOlDylM(this, i);
        if (QtPazuLnwzqJimZy(this)) {
            zQclnYkSfWnOlDylM |= tDCgtArcnPnNnuFR(this.chipIcon, i);
        }
        if (gcRKcgHjTuUKjTuY(this)) {
            zQclnYkSfWnOlDylM |= HXGySxVpzHIYWLYU(this.checkedIcon, i);
        }
        if (vCoXVuyrfiQzYZur(this)) {
            zQclnYkSfWnOlDylM |= oMDfmJctcOKMRCqT(this.closeIcon, i);
        }
        if (!zQclnYkSfWnOlDylM) {
            return true;
        }
        PRyYiwQaBqzGfQTL(this);
        return true;
    }

    protected override bool OnLevelChange(int i) {
        if ((9 + 1) % 1 > 0) {
        }
        bool zQKtZrWZnmjRpnmlC = QKtZrWZnmjRpnmlC(this, i);
        if (olnIgFiizakpMYYV(this)) {
            zQKtZrWZnmjRpnmlC |= VnZLCjWcVnYuiiNO(this.chipIcon, i);
        }
        if (LZQEkCabEEDOmHQS(this)) {
            zQKtZrWZnmjRpnmlC |= OhhjtAsoPeTsZmov(this.checkedIcon, i);
        }
        if (bnkyXqVzZYYPKfIR(this)) {
            zQKtZrWZnmjRpnmlC |= WXEmwslZnMsTjDfg(this.closeIcon, i);
        }
        if (zQKtZrWZnmjRpnmlC) {
            HYJldkEGMinAOweP(this);
        }
        return zQKtZrWZnmjRpnmlC;
    }

    protected void OnSizeChange() {
        com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate = (com.google.android.material.chip.ChipDrawable$Delegate) dmbtJLEopJPEyGzF(this.delegate);
        if (chipDrawable$Delegate is null) {
            return;
        }
        psSiSXyuMTIzRVzR(chipDrawable$Delegate);
    }

    public override bool OnStateChange(int[] iArr) {
        if (this.isShapeThemingEnabled) {
            jHYpZcDhcwhYfmfj(this, iArr);
        }
        return beSTylJrwOiqLsuW(this, iArr, xQsWOeLnOqEKgnyH(this));
    }

    public override void OnTextSizeChange() {
        boinrtHUOEKbEbRc(this);
        QWyGazPKuwWTPUUq(this);
    }

    public override void ScheduleDrawable(android.graphics.drawable.Drawable drawable, java.lang.Action runnable, long j) {
        android.graphics.drawable.Drawable$Callback drawable$CallbackQLZsYkuXFZuiRCvg = qLZsYkuXFZuiRCvg(this);
        if (drawable$CallbackQLZsYkuXFZuiRCvg is null) {
            return;
        }
        druDIHMFqCvQdgeS(drawable$CallbackQLZsYkuXFZuiRCvg, this, runnable, j);
    }

    public override void SetAlpha(int i) {
        if (this.alpha == i) {
            return;
        }
        this.alpha = i;
        JshdiFMvBMbyNZLs(this);
    }

    public void SetCheckable(bool z) {
        if (this.checkable == z) {
            return;
        }
        this.checkable = z;
        float fANhjcGpcNIDZHguZ = aNhjcGpcNIDZHguZ(this);
        if (!z && this.currentChecked) {
            this.currentChecked = false;
        }
        float fHmKaykTrEgNJuKDV = HmKaykTrEgNJuKDV(this);
        bqtbMvDvoNmjHPFi(this);
        if (fANhjcGpcNIDZHguZ == fHmKaykTrEgNJuKDV) {
            return;
        }
        oPQtTXtGqbcwTkDw(this);
    }

    public void SetCheckableResource(int i) {
        gOCcbYVkMsVJSIPZ(this, SoDNhkQFmZlKOiaL(bmvFZVzBtpeVIJLC(this.context), i));
    }

    public void SetCheckedIcon(android.graphics.drawable.Drawable drawable) {
        if ((27 + 3) % 3 > 0) {
        }
        if (this.checkedIcon == drawable) {
            return;
        }
        float fMxCzMatNAGQCzhxD = MxCzMatNAGQCzhxD(this);
        this.checkedIcon = drawable;
        float fJRbUywGpWzrxRVDc = JRbUywGpWzrxRVDc(this);
        pTxEjnBazgkUXyfR(this, this.checkedIcon);
        UdZQiERCfpivAZzj(this, this.checkedIcon);
        swzppuKXxEBVEJlF(this);
        if (fMxCzMatNAGQCzhxD == fJRbUywGpWzrxRVDc) {
            return;
        }
        nPyxTYuYfyUMZUjH(this);
    }

    @java.lang.Deprecated
    public void SetCheckedIconEnabled(bool z) {
        JVOibUvbNMVpvGEB(this, z);
    }

    @java.lang.Deprecated
    public void SetCheckedIconEnabledResource(int i) {
        WMvconkFYOAlvkYv(this, XRgHWOyYfZLjPthS(nbLkSKqIQoyCFodt(this.context), i));
    }

    public void SetCheckedIconResource(int i) {
        LqsipEbryRrXrJqT(this, DCrquyhRguYsEJAK(this.context, i));
    }

    public void SetCheckedIconTint(android.content.res.ColorStateList colorStateList) {
        if (this.checkedIconTint == colorStateList) {
            return;
        }
        this.checkedIconTint = colorStateList;
        if (MxcnmelutFqDTWpF(this)) {
            fbQxccKDGAGODlJY(this.checkedIcon, colorStateList);
        }
        sDMKxkRNVCgwFQhc(this, pDERDNzAyefFWAXT(this));
    }

    public void SetCheckedIconTintResource(int i) {
        kWwquRAUbrWVdijE(this, LqzWtlrnLxGpvipr(this.context, i));
    }

    public void SetCheckedIconVisible(int i) {
        ZjlvwZXNftFVMVCE(this, gxhFWLdsAzAHzDwO(JkkJtWeafpEXIGgB(this.context), i));
    }

    public void SetCheckedIconVisible(bool z) {
        if (this.checkedIconVisible == z) {
            return;
        }
        bool zDCfBIAawfCGkYkie = dCfBIAawfCGkYkie(this);
        this.checkedIconVisible = z;
        bool zIJQomWbbJyuYJlVc = IJQomWbbJyuYJlVc(this);
        if (zDCfBIAawfCGkYkie == zIJQomWbbJyuYJlVc) {
            return;
        }
        if (zIJQomWbbJyuYJlVc) {
            dFYCOHgPjClIKSUb(this, this.checkedIcon);
        } else {
            QiautWYKniKqZTFf(this, this.checkedIcon);
        }
        VxgMWesIAoxALzDa(this);
        oKxFVLidAKllvSKk(this);
    }

    public void SetChipBackgroundColor(android.content.res.ColorStateList colorStateList) {
        if (this.chipBackgroundColor == colorStateList) {
            return;
        }
        this.chipBackgroundColor = colorStateList;
        hHtrKUZUKrfjLsEK(this, wptQCYSkNZOptSGk(this));
    }

    public void SetChipBackgroundColorResource(int i) {
        wTxjzHWxcDfPNXUo(this, apSSrvNOBMpbdGqj(this.context, i));
    }

    @java.lang.Deprecated
    public void SetChipCornerRadius(float f) {
        if (this.chipCornerRadius == f) {
            return;
        }
        this.chipCornerRadius = f;
        VYKmGWlXMmbOEvdw(this, PbwQFBxhMtYucEAn(PUZgkytQzngaQxog(this), f));
    }

    @java.lang.Deprecated
    public void SetChipCornerRadiusResource(int i) {
        TFRpunvMYIRzygdB(this, yvXBuZSdblfsBcMS(vIqcEXWkPxiWepvL(this.context), i));
    }

    public void SetChipEndPadding(float f) {
        if (this.chipEndPadding == f) {
            return;
        }
        this.chipEndPadding = f;
        hhhfrmzrPRpYMHsm(this);
        LqSuaQqzWLdDPOmQ(this);
    }

    public void SetChipEndPaddingResource(int i) {
        UIPxDWVyMHoYoDdj(this, qaZkFSRFFDZyZKGk(pRFojVrYuAHmtVHq(this.context), i));
    }

    public void SetChipIcon(android.graphics.drawable.Drawable drawable) {
        if ((29 + 1) % 1 > 0) {
        }
        android.graphics.drawable.Drawable drawableSWELxRhqtsKCMbIs = SWELxRhqtsKCMbIs(this);
        if (drawableSWELxRhqtsKCMbIs == drawable) {
            return;
        }
        float fGvDoVSrmxcyHNBUU = GvDoVSrmxcyHNBUU(this);
        this.chipIcon = drawable is null ? null : OUrpVSdAGVYPjOKv(PGoGBElPGygRPvOs(drawable));
        float fILMRqxjLEaiZvVRR = ILMRqxjLEaiZvVRR(this);
        FGxLoTwnKVJSOUuZ(this, drawableSWELxRhqtsKCMbIs);
        if (ZmvgrPnaDoYDKrGs(this)) {
            wLWYtKIYHWpYUBWp(this, this.chipIcon);
        }
        zcPbcTbPRoNSmuVs(this);
        if (fGvDoVSrmxcyHNBUU == fILMRqxjLEaiZvVRR) {
            return;
        }
        ElpmAgcGQDcRxuiB(this);
    }

    @java.lang.Deprecated
    public void SetChipIconEnabled(bool z) {
        oxRXBfmJmtStnelK(this, z);
    }

    @java.lang.Deprecated
    public void SetChipIconEnabledResource(int i) {
        TppvrwZHUAPDmFRq(this, i);
    }

    public void SetChipIconResource(int i) {
        ZjaTJoCEsVcgptWR(this, SkxXUVOMxswowPbA(this.context, i));
    }

    public void SetChipIconSize(float f) {
        if (this.chipIconSize == f) {
            return;
        }
        float fNKWaGTAUKkDmCqQi = nKWaGTAUKkDmCqQi(this);
        this.chipIconSize = f;
        float fOLeWcntDuCUPiUKw = oLeWcntDuCUPiUKw(this);
        POzRAHInJCPKBRdA(this);
        if (fNKWaGTAUKkDmCqQi == fOLeWcntDuCUPiUKw) {
            return;
        }
        YSLALOwurNFstveo(this);
    }

    public void SetChipIconSizeResource(int i) {
        InzJNiFfAsAMmhPb(this, QAIlBAJpVBKognch(TtPrOtnAgajsMBME(this.context), i));
    }

    public void SetChipIconTint(android.content.res.ColorStateList colorStateList) {
        this.hasChipIconTint = true;
        if (this.chipIconTint == colorStateList) {
            return;
        }
        this.chipIconTint = colorStateList;
        if (NhGKSwYlXHIELLcH(this)) {
            XEYeRcjNRqqlyHoG(this.chipIcon, colorStateList);
        }
        npUngSSEJPEojMhz(this, KXFPxohRljsUDiWF(this));
    }

    public void SetChipIconTintResource(int i) {
        IfxUEVCSOyCtqoNv(this, gvaxxCcPIVdeJROq(this.context, i));
    }

    public void SetChipIconVisible(int i) {
        laQiTdhZYDuSmIqf(this, kiArkgCUClvPKWWR(IKBhYjNVnkSoftLg(this.context), i));
    }

    public void SetChipIconVisible(bool z) {
        if (this.chipIconVisible == z) {
            return;
        }
        bool zBMrWdwheovjXNbLf = BMrWdwheovjXNbLf(this);
        this.chipIconVisible = z;
        bool zCnLdlLtgwieyiuor = cnLdlLtgwieyiuor(this);
        if (zBMrWdwheovjXNbLf == zCnLdlLtgwieyiuor) {
            return;
        }
        if (zCnLdlLtgwieyiuor) {
            iTBCOIQnPWyAuDvD(this, this.chipIcon);
        } else {
            lPhYSULhjumxGzJc(this, this.chipIcon);
        }
        PLxMKimDIxHKloVX(this);
        DAhdDZsZpYvLqwaq(this);
    }

    public void SetChipMinHeight(float f) {
        if (this.chipMinHeight == f) {
            return;
        }
        this.chipMinHeight = f;
        MfsZJwpkEttQcBoa(this);
        crGdtGlJiLVSmqtT(this);
    }

    public void SetChipMinHeightResource(int i) {
        pUnEwUhRPwfinHHq(this, XdHmZpyvBkBaxLbx(qnMvfQNAIorOMtuz(this.context), i));
    }

    public void SetChipStartPadding(float f) {
        if (this.chipStartPadding == f) {
            return;
        }
        this.chipStartPadding = f;
        oZjpuGcwunopOArL(this);
        jmSLDNUULNvqyFCO(this);
    }

    public void SetChipStartPaddingResource(int i) {
        oZYNUmsNYKmmBszI(this, yOWbOsTzfXubYNsv(ANfbmPXYIkHdWKKX(this.context), i));
    }

    public void SetChipStrokeColor(android.content.res.ColorStateList colorStateList) {
        if (this.chipStrokeColor == colorStateList) {
            return;
        }
        this.chipStrokeColor = colorStateList;
        if (this.isShapeThemingEnabled) {
            XDCwujHYFQVEjVkG(this, colorStateList);
        }
        LHTOLaBNAjeWTaVf(this, qXAiRNbznCxWONnP(this));
    }

    public void SetChipStrokeColorResource(int i) {
        nPhbVwvjsisDGqub(this, yXyfgVKADafbfOfQ(this.context, i));
    }

    public void SetChipStrokeWidth(float f) {
        if (this.chipStrokeWidth == f) {
            return;
        }
        this.chipStrokeWidth = f;
        uiSXcuTaABaczadR(this.chipPaint, f);
        if (this.isShapeThemingEnabled) {
            YaLbsyEdUvgqudEJ(this, f);
        }
        XwVEFIaHQjaAuNVc(this);
    }

    public void SetChipStrokeWidthResource(int i) {
        crKWzKLUhhHTQIAZ(this, KoUnqLqgBhvXlgWJ(SfOaOfoESbCSENCR(this.context), i));
    }

    public void SetCloseIcon(android.graphics.drawable.Drawable drawable) {
        if ((26 + 8) % 8 > 0) {
        }
        android.graphics.drawable.Drawable drawableOGeksAuyVasyKCgf = OGeksAuyVasyKCgf(this);
        if (drawableOGeksAuyVasyKCgf == drawable) {
            return;
        }
        float fMfkHgDrsJdPFZbnk = mfkHgDrsJdPFZbnk(this);
        this.closeIcon = drawable is null ? null : CpMPPHQrFVqYQhAY(dnbuezRaXwBCASCa(drawable));
        if (com.google.android.material.ripple.RippleUtils.USE_FRAMEWORK_RIPPLE) {
            pBqzfcgBxAAYjJBq(this);
        }
        float fELojrDCtGMnPtknB = eLojrDCtGMnPtknB(this);
        QjSLJOjYUwJZfQZY(this, drawableOGeksAuyVasyKCgf);
        if (PhycEkOADQRfRQSf(this)) {
            QGHKpROGYomHeAFA(this, this.closeIcon);
        }
        psKignopuENgLpFG(this);
        if (fMfkHgDrsJdPFZbnk == fELojrDCtGMnPtknB) {
            return;
        }
        gUhnxyRMuUInUIEh(this);
    }

    public void SetCloseIconContentDescription(java.lang.CharSequence charSequence) {
        if (this.closeIconContentDescription == charSequence) {
            return;
        }
        this.closeIconContentDescription = ZbKCVHLXOKYQFQtn(vRahdTjFTkBGoash(), charSequence);
        VycNHBDEnjegXzUK(this);
    }

    @java.lang.Deprecated
    public void SetCloseIconEnabled(bool z) {
        tqrqmvhIWShjYFJT(this, z);
    }

    @java.lang.Deprecated
    public void SetCloseIconEnabledResource(int i) {
        OPUwzGkIsefxjrjn(this, i);
    }

    public void SetCloseIconEndPadding(float f) {
        if (this.closeIconEndPadding == f) {
            return;
        }
        this.closeIconEndPadding = f;
        BDquZWCkwthSTGjw(this);
        if (pHgVnPJPKNzpisFV(this)) {
            cztcfKbVwGklxiaJ(this);
        }
    }

    public void SetCloseIconEndPaddingResource(int i) {
        wGsnccWlZNNfNzDN(this, GzaxjhtHsWyIENlv(TyzRqVhaNYvVXNjc(this.context), i));
    }

    public void SetCloseIconResource(int i) {
        HGoJnzSKcXtvfHzo(this, CbzRMptKhGkMsejQ(this.context, i));
    }

    public void SetCloseIconSize(float f) {
        if (this.closeIconSize == f) {
            return;
        }
        this.closeIconSize = f;
        cGxZOfCQvJOQfKun(this);
        if (KatuMGmgofOKXudV(this)) {
            dkNJrdMVbgBUCrGq(this);
        }
    }

    public void SetCloseIconSizeResource(int i) {
        lsazjxKIkIrrTUqd(this, cNixzFtrYuTGitER(pvSHpxdcAktUKvSR(this.context), i));
    }

    public void SetCloseIconStartPadding(float f) {
        if (this.closeIconStartPadding == f) {
            return;
        }
        this.closeIconStartPadding = f;
        bGKHVYLDBwXFViSz(this);
        if (rKsPErtBSjpjOLfO(this)) {
            SsORIMVvDuouNoLM(this);
        }
    }

    public void SetCloseIconStartPaddingResource(int i) {
        cyEhrwHtGxLTzCKE(this, INoXhHXYTPajxSIv(jOmizEyDtOWEbMKk(this.context), i));
    }

    public bool SetCloseIconState(int[] iArr) {
        if (kbigQviSbFaTZNLj(this.closeIconStateHashSet, iArr)) {
            return false;
        }
        this.closeIconStateHashSet = iArr;
        if (DoUsrGoYKBBjXLhw(this)) {
            return YqgtFstGABILyovF(this, vYQFRFUwKMSvwHRH(this), iArr);
        }
        return false;
    }

    public void SetCloseIconTint(android.content.res.ColorStateList colorStateList) {
        if (this.closeIconTint == colorStateList) {
            return;
        }
        this.closeIconTint = colorStateList;
        if (bklZjXFFZOuanNHZ(this)) {
            MsxLpPMsapBRqLfF(this.closeIcon, colorStateList);
        }
        YhBoNnIfRGdLWQaT(this, CCJxPwRFcHwMEmRz(this));
    }

    public void SetCloseIconTintResource(int i) {
        uUgNxIwqexyJilmx(this, ftEFFpfqwtZKpSnb(this.context, i));
    }

    public void SetCloseIconVisible(int i) {
        RkYYofNHCgJZwreE(this, TKxKTWztbjTKtdAv(bIYsOchPSobeVgOQ(this.context), i));
    }

    public void SetCloseIconVisible(bool z) {
        if (this.closeIconVisible == z) {
            return;
        }
        bool zAPCQZpBtPcFGGumZ = aPCQZpBtPcFGGumZ(this);
        this.closeIconVisible = z;
        bool zWxyDeGChCoeSybgb = wxyDeGChCoeSybgb(this);
        if (zAPCQZpBtPcFGGumZ == zWxyDeGChCoeSybgb) {
            return;
        }
        if (zWxyDeGChCoeSybgb) {
            iPvyrXqagBcXwODg(this, this.closeIcon);
        } else {
            NCLGyoVdQzxQKvvC(this, this.closeIcon);
        }
        vQxmGEAzpqsPBTnN(this);
        paiNZrwpMCSxsCnG(this);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        if (this.colorFilter == colorFilter) {
            return;
        }
        this.colorFilter = colorFilter;
        EoxuuNvxgOlkkKez(this);
    }

    public void SetDelegate(com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate) {
        this.delegate = new java.lang.ref.WeakReference<>(chipDrawable$Delegate);
    }

    public void SetEllipsize(android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        this.truncateAt = textUtils$TruncateAt;
    }

    public void SetHideMotionSpec(com.google.android.material.animation.MotionSpec motionSpec) {
        this.hideMotionSpec = motionSpec;
    }

    public void SetHideMotionSpecResource(int i) {
        COOicoymeqUiRXPJ(this, sgwsWpbCpONVewkp(this.context, i));
    }

    public void SetIconEndPadding(float f) {
        if (this.iconEndPadding == f) {
            return;
        }
        float fHqfexYiBvrqWllae = HqfexYiBvrqWllae(this);
        this.iconEndPadding = f;
        float fPagpfagNKHLVNqel = PagpfagNKHLVNqel(this);
        hGibMMvZSjtObeVI(this);
        if (fHqfexYiBvrqWllae == fPagpfagNKHLVNqel) {
            return;
        }
        DstlEedByryrcyHp(this);
    }

    public void SetIconEndPaddingResource(int i) {
        iMrnKZINYRxHyLGq(this, AWitbhISOfdMEpbK(gIMljuVXUDmcdVUg(this.context), i));
    }

    public void SetIconStartPadding(float f) {
        if (this.iconStartPadding == f) {
            return;
        }
        float fDWHbFcXteGqMBYeP = dWHbFcXteGqMBYeP(this);
        this.iconStartPadding = f;
        float fIvUeqAHMmjYtviAi = IvUeqAHMmjYtviAi(this);
        ibTIARaphdgOSrgb(this);
        if (fDWHbFcXteGqMBYeP == fIvUeqAHMmjYtviAi) {
            return;
        }
        qrVgfIdDgbYBWTDz(this);
    }

    public void SetIconStartPaddingResource(int i) {
        mRUhubyxcnpFtzqn(this, gLAdOsUeqpiCnjsj(xzgBSydbdmZVoFSQ(this.context), i));
    }

    public void SetMaxWidth(int i) {
        this.maxWidth = i;
    }

    public void SetRippleColor(android.content.res.ColorStateList colorStateList) {
        if (this.rippleColor == colorStateList) {
            return;
        }
        this.rippleColor = colorStateList;
        zxYuvoQQUGepoqYv(this);
        UtYoUmtzucFqEbgG(this, ZdMALQKfExNRzoPg(this));
    }

    public void SetRippleColorResource(int i) {
        brDDwyopeivnjBWR(this, GrYjNrSHhXWXawxD(this.context, i));
    }

    void setShouldDrawText(bool z) {
        this.shouldDrawText = z;
    }

    public void SetShowMotionSpec(com.google.android.material.animation.MotionSpec motionSpec) {
        this.showMotionSpec = motionSpec;
    }

    public void SetShowMotionSpecResource(int i) {
        fkZTZsGXwtbagJNc(this, zsqiXRYrJyIzxHSt(this.context, i));
    }

    public void SetText(java.lang.CharSequence charSequence) {
        if (charSequence is null) {
            charSequence = "";
        }
        if (VqOVsZSeOCEiOeoa(this.text, charSequence)) {
            return;
        }
        this.text = charSequence;
        mtlqSlZDmlFxxaVy(this.textDrawableHelper, true);
        JeQSSigsIgjZfpFI(this);
        gNZAJgSZsyhxijIk(this);
    }

    public void SetTextAppearance(com.google.android.material.resources.TextAppearance textAppearance) {
        zrepmjWzfhixAPWS(this.textDrawableHelper, textAppearance, this.context);
    }

    public void SetTextAppearanceResource(int i) {
        if ((13 + 24) % 24 > 0) {
        }
        nzCHgJCfbgrimHEv(this, new com.google.android.material.resources.TextAppearance(this.context, i));
    }

    public void SetTextColor(int i) {
        DjyVFZUDWZXiNfaL(this, kHVqNTOTdSwmWBmY(i));
    }

    public void SetTextColor(android.content.res.ColorStateList colorStateList) {
        com.google.android.material.resources.TextAppearance textAppearanceGCdFngZCosuSOHVG = gCdFngZCosuSOHVG(this);
        if (textAppearanceGCdFngZCosuSOHVG is null) {
            return;
        }
        ucfnYbsuDcmStGVC(textAppearanceGCdFngZCosuSOHVG, colorStateList);
        ZeTTrdFhxhMnrZVe(this);
    }

    public void SetTextEndPadding(float f) {
        if (this.textEndPadding == f) {
            return;
        }
        this.textEndPadding = f;
        mUctZlkipmRudFjI(this);
        WHUDyKoTwWxsYQxF(this);
    }

    public void SetTextEndPaddingResource(int i) {
        zIZIgLZQkFQcTeha(this, TQnwfNGRhQbjfpZx(DwAXnyLAMIxdvOoC(this.context), i));
    }

    public void SetTextResource(int i) {
        aFAoqVQaEVNIucrK(this, LujSxHqZuHyyGxgY(cPsVPBymZBwVtbEl(this.context), i));
    }

    public void SetTextSize(float f) {
        com.google.android.material.resources.TextAppearance textAppearanceGLvFvOGlaAGxwHou = GLvFvOGlaAGxwHou(this);
        if (textAppearanceGLvFvOGlaAGxwHou is null) {
            return;
        }
        pmdwKtshyYBViYHv(textAppearanceGLvFvOGlaAGxwHou, f);
        VCSCPTdHcdYWbiOa(LOlRdrjIdfxpOcof(this.textDrawableHelper), f);
        VhxUBhZMurdlKIMx(this);
    }

    public void SetTextStartPadding(float f) {
        if (this.textStartPadding == f) {
            return;
        }
        this.textStartPadding = f;
        qbSOLsqcoBCChUDa(this);
        PPBmCPIgHtvVmjKz(this);
    }

    public void SetTextStartPaddingResource(int i) {
        eMOSaxNRAIGMQCKN(this, qamWDjRyHPJzWFcB(GzSpOTQKtENjgGLY(this.context), i));
    }

    public override void SetTintList(android.content.res.ColorStateList colorStateList) {
        if (this.tint == colorStateList) {
            return;
        }
        this.tint = colorStateList;
        mipLwBBEuJmvTXPQ(this, pNmPySdWYPxrXfqe(this));
    }

    public override void SetTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (this.tintMode == porterDuff$Mode) {
            return;
        }
        this.tintMode = porterDuff$Mode;
        this.tintFilter = uuvmNbNoezWUNkKn(this, this.tint, porterDuff$Mode);
        OePCgRNIJYjNsKUB(this);
    }

    public void SetUseCompatRipple(bool z) {
        if (this.useCompatRipple == z) {
            return;
        }
        this.useCompatRipple = z;
        HWUSmBEFqqviJqJs(this);
        daxwNeAfgaUAMIVS(this, CgdwVHQvkUjRseDh(this));
    }

    public override bool SetVisible(bool z, bool z2) {
        if ((19 + 18) % 18 > 0) {
        }
        bool zTslhUirHnVbUgHMz = TslhUirHnVbUgHMz(this, z, z2);
        if (YprvSoAqgssjLHbp(this)) {
            zTslhUirHnVbUgHMz |= odBdpHrEFJyYGtqd(this.chipIcon, z, z2);
        }
        if (gdGTgOnuBqOtzSfU(this)) {
            zTslhUirHnVbUgHMz |= JRbXQSJeHLMqvBJB(this.checkedIcon, z, z2);
        }
        if (BHvCtoJRPqxaknhS(this)) {
            zTslhUirHnVbUgHMz |= lfYZBiZLUdYOemqS(this.closeIcon, z, z2);
        }
        if (zTslhUirHnVbUgHMz) {
            juOdgHyMBSOGXnOU(this);
        }
        return zTslhUirHnVbUgHMz;
    }

    bool shouldDrawText() {
        return this.shouldDrawText;
    }

    public override void UnscheduleDrawable(android.graphics.drawable.Drawable drawable, java.lang.Action runnable) {
        android.graphics.drawable.Drawable$Callback drawable$CallbackPpakQhwtYEViYOlM = ppakQhwtYEViYOlM(this);
        if (drawable$CallbackPpakQhwtYEViYOlM is null) {
            return;
        }
        eCBeidAWTNBEpQBl(drawable$CallbackPpakQhwtYEViYOlM, this, runnable);
    }
}

