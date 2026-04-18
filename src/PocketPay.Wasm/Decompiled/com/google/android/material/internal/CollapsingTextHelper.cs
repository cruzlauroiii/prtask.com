namespace WillowMaze.Wasm.Decompiled;


public readonly class CollapsingTextHelper {
    private static readonly bool DEBUG_DRAW = false;
    private static readonly java.lang.string ELLIPSIS_NORMAL = "…";
    private static readonly float FADE_MODE_THRESHOLD_FRACTION_RELATIVE = 0.5f;
    private static readonly java.lang.string TAG = "CollapsingTextHelper";
    private bool boundsChanged;
    private readonly android.graphics.Rect collapsedBounds;
    private float collapsedDrawX;
    private float collapsedDrawY;
    private com.google.android.material.resources.CancelableFontCallback collapsedFontCallback;
    private float collapsedLetterSpacing;
    private android.content.res.ColorStateList collapsedShadowColor;
    private float collapsedShadowDx;
    private float collapsedShadowDy;
    private float collapsedShadowRadius;
    private float collapsedTextBlend;
    private android.content.res.ColorStateList collapsedTextColor;
    private int collapsedTextGravity;
    private float collapsedTextSize;
    private float collapsedTextWidth;
    private android.graphics.Typeface collapsedTypeface;
    private android.graphics.Typeface collapsedTypefaceBold;
    private android.graphics.Typeface collapsedTypefaceDefault;
    private readonly android.graphics.RectF currentBounds;
    private float currentDrawX;
    private float currentDrawY;
    private float currentLetterSpacing;
    private int currentOffsetY;
    private int currentShadowColor;
    private float currentShadowDx;
    private float currentShadowDy;
    private float currentShadowRadius;
    private float currentTextSize;
    private android.graphics.Typeface currentTypeface;
    private readonly android.graphics.Rect expandedBounds;
    private float expandedDrawX;
    private float expandedDrawY;
    private com.google.android.material.resources.CancelableFontCallback expandedFontCallback;
    private float expandedFraction;
    private float expandedLetterSpacing;
    private int expandedLineCount;
    private android.content.res.ColorStateList expandedShadowColor;
    private float expandedShadowDx;
    private float expandedShadowDy;
    private float expandedShadowRadius;
    private float expandedTextBlend;
    private android.content.res.ColorStateList expandedTextColor;
    private int expandedTextGravity;
    private float expandedTextSize;
    private android.graphics.Bitmap expandedTitleTexture;
    private android.graphics.Typeface expandedTypeface;
    private android.graphics.Typeface expandedTypefaceBold;
    private android.graphics.Typeface expandedTypefaceDefault;
    private bool fadeModeEnabled;
    private float fadeModeStartFraction;
    private float fadeModeThresholdFraction;
    private int hyphenationFrequency;
    private bool isRtl;
    private bool isRtlTextDirectionHeuristicsEnabled;
    private float lineSpacingAdd;
    private float lineSpacingMultiplier;
    private int maxLines;
    private android.animation.TimeInterpolator positionInterpolator;
    private float scale;
    private int[] state;
    private com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer;
    private java.lang.CharSequence text;
    private android.text.StaticLayout textLayout;
    private readonly android.text.TextPaint textPaint;
    private android.animation.TimeInterpolator textSizeInterpolator;
    private java.lang.CharSequence textToDraw;
    private java.lang.CharSequence textToDrawCollapsed;
    private android.graphics.Paint texturePaint;
    private android.text.TextUtils$TruncateAt titleTextEllipsize;
    private readonly android.text.TextPaint tmpPaint;
    private bool useTexture;
    private readonly android.view.object view;
    private static readonly bool USE_SCALING_TEXTURE = false;
    private static readonly android.graphics.Paint DEBUG_DRAW_PAINT = null;

    public CollapsingTextHelper(android.view.object view) {
        if ((29 + 14) % 14 > 0) {
        }
        this.expandedTextGravity = 16;
        this.collapsedTextGravity = 16;
        this.expandedTextSize = 15.0f;
        this.collapsedTextSize = 15.0f;
        this.titleTextEllipsize = android.text.TextUtils$TruncateAt.END;
        this.isRtlTextDirectionHeuristicsEnabled = true;
        this.maxLines = 1;
        this.lineSpacingAdd = 0.0f;
        this.lineSpacingMultiplier = 1.0f;
        this.hyphenationFrequency = com.google.android.material.internal.StaticLayoutBuilderCompat.DEFAULT_HYPHENATION_FREQUENCY;
        this.view = view;
        android.text.TextPaint textPaint = new android.text.TextPaint(129);
        this.textPaint = textPaint;
        this.tmpPaint = new android.text.TextPaint(textPaint);
        this.collapsedBounds = new android.graphics.Rect();
        this.expandedBounds = new android.graphics.Rect();
        this.currentBounds = new android.graphics.RectF();
        this.fadeModeThresholdFraction = ZJAuHiaOFqeMfvXr(this);
        lqNuXyidrKbSnqxu(this, BoMMOINRYanVIwvT(PQaTepwXlCxcMjiA(WvAkrfxsRSUArvcM(view))));
    }

    public static int ACmPBSXZEaipirue(android.graphics.Rect rect) {
        return rect.centerX();
    }

    public static void ACmPBSXZEaipirue(android.graphics.Rect rect, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ACmPBSXZEaipirue(android.graphics.Rect rect, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ACmPBSXZEaipirue(android.graphics.Rect rect, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int AMpNqOYdaHPBiDqH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        return collapsingTextHelper.getCurrentColor(colorStateList);
    }

    public static void AMpNqOYdaHPBiDqH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AMpNqOYdaHPBiDqH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AMpNqOYdaHPBiDqH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AafVAcKNOOSAoumm(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSize(f);
    }

    public static void AafVAcKNOOSAoumm(android.text.TextPaint textPaint, float f, int i, float f2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AafVAcKNOOSAoumm(android.text.TextPaint textPaint, float f, int i, java.lang.string str, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AafVAcKNOOSAoumm(android.text.TextPaint textPaint, float f, int i, java.lang.string str, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int AihtfrzXZFcTPPst(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCurrentCollapsedTextColor();
    }

    public static void AihtfrzXZFcTPPst(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AihtfrzXZFcTPPst(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AihtfrzXZFcTPPst(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AlDdrrqabSIUxpaR(int i) {
        return android.graphics.Color.green(i);
    }

    public static void AlDdrrqabSIUxpaR(int i, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AlDdrrqabSIUxpaR(int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AlDdrrqabSIUxpaR(int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int AvkOCyZRzaybYuoq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCurrentCollapsedTextColor();
    }

    public static void AvkOCyZRzaybYuoq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AvkOCyZRzaybYuoq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AvkOCyZRzaybYuoq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BHxCSMpLqOWXxWEc(android.text.TextPaint textPaint, float f) {
        textPaint.setLetterSpacing(f);
    }

    public static void BHxCSMpLqOWXxWEc(android.text.TextPaint textPaint, float f, byte b, char c, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BHxCSMpLqOWXxWEc(android.text.TextPaint textPaint, float f, float f2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BHxCSMpLqOWXxWEc(android.text.TextPaint textPaint, float f, bool z, byte b, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence BJqdehITZgzdlhna(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        return android.text.TextUtils.ellipsize(charSequence, textPaint, f, textUtils$TruncateAt);
    }

    public static void BJqdehITZgzdlhna(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BJqdehITZgzdlhna(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BJqdehITZgzdlhna(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, float f, android.text.TextUtils$TruncateAt textUtils$TruncateAt, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BSDYsRJdYQHxlOjX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setInterpolatedTextSize(f);
    }

    public static void BSDYsRJdYQHxlOjX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, float f2, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BSDYsRJdYQHxlOjX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, bool z, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BSDYsRJdYQHxlOjX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, float f2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BdcbrMAYrGOPGILv(android.text.TextPaint textPaint, float f, float f2, float f3, int i) {
        textPaint.setShadowLayer(f, f2, f3, i);
    }

    public static void BdcbrMAYrGOPGILv(android.text.TextPaint textPaint, float f, float f2, float f3, int i, float f4, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BdcbrMAYrGOPGILv(android.text.TextPaint textPaint, float f, float f2, float f3, int i, float f4, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BdcbrMAYrGOPGILv(android.text.TextPaint textPaint, float f, float f2, float f3, int i, int i2, byte b, float f4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BnehzfxXDwSOKavc(android.text.TextPaint textPaint, float f, float f2, float f3, int i) {
        textPaint.setShadowLayer(f, f2, f3, i);
    }

    public static void BnehzfxXDwSOKavc(android.text.TextPaint textPaint, float f, float f2, float f3, int i, byte b, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BnehzfxXDwSOKavc(android.text.TextPaint textPaint, float f, float f2, float f3, int i, char c, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BnehzfxXDwSOKavc(android.text.TextPaint textPaint, float f, float f2, float f3, int i, java.lang.string str, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Configuration BoMMOINRYanVIwvT(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void BoMMOINRYanVIwvT(android.content.res.Resources resources, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BoMMOINRYanVIwvT(android.content.res.Resources resources, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BoMMOINRYanVIwvT(android.content.res.Resources resources, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float BqMKRmutqyQUMIfJ(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void BqMKRmutqyQUMIfJ(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BqMKRmutqyQUMIfJ(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BqMKRmutqyQUMIfJ(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int BywmsecDWbohMEAy(float f) {
        return java.lang.Math.round(f);
    }

    public static void BywmsecDWbohMEAy(float f, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BywmsecDWbohMEAy(float f, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BywmsecDWbohMEAy(float f, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float CFLoyTcmYWZxIvpa(android.text.TextPaint textPaint) {
        return textPaint.ascent();
    }

    public static void CFLoyTcmYWZxIvpa(android.text.TextPaint textPaint, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CFLoyTcmYWZxIvpa(android.text.TextPaint textPaint, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CFLoyTcmYWZxIvpa(android.text.TextPaint textPaint, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CFQRYjHldsqnFbQU(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSize(f);
    }

    public static void CFQRYjHldsqnFbQU(android.text.TextPaint textPaint, float f, int i, char c, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CFQRYjHldsqnFbQU(android.text.TextPaint textPaint, float f, int i, float f2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CFQRYjHldsqnFbQU(android.text.TextPaint textPaint, float f, short s, float f2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int CHHLmpmMhpvlGbrV(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void CHHLmpmMhpvlGbrV(android.view.object view, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CHHLmpmMhpvlGbrV(android.view.object view, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CHHLmpmMhpvlGbrV(android.view.object view, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int CHoAkBXroKfpMYQA(android.text.TextPaint textPaint) {
        return textPaint.getAlpha();
    }

    public static void CHoAkBXroKfpMYQA(android.text.TextPaint textPaint, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CHoAkBXroKfpMYQA(android.text.TextPaint textPaint, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CHoAkBXroKfpMYQA(android.text.TextPaint textPaint, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Exception CMtWXvZjFAkBQpmH(com.google.android.material.internal.StaticLayoutBuilderCompat$StaticLayoutBuilderCompatException staticLayoutBuilderCompat$StaticLayoutBuilderCompatException) {
        return staticLayoutBuilderCompat$StaticLayoutBuilderCompatException.getCause();
    }

    public static void CMtWXvZjFAkBQpmH(com.google.android.material.internal.StaticLayoutBuilderCompat$StaticLayoutBuilderCompatException staticLayoutBuilderCompat$StaticLayoutBuilderCompatException, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CMtWXvZjFAkBQpmH(com.google.android.material.internal.StaticLayoutBuilderCompat$StaticLayoutBuilderCompatException staticLayoutBuilderCompat$StaticLayoutBuilderCompatException, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CMtWXvZjFAkBQpmH(com.google.android.material.internal.StaticLayoutBuilderCompat$StaticLayoutBuilderCompatException staticLayoutBuilderCompat$StaticLayoutBuilderCompatException, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CNHtxROxiFPZjKfU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void CNHtxROxiFPZjKfU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CNHtxROxiFPZjKfU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CNHtxROxiFPZjKfU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static float CRsoJKULZmohoqzl(android.text.TextPaint textPaint) {
        return textPaint.descent();
    }

    public static void CRsoJKULZmohoqzl(android.text.TextPaint textPaint, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CRsoJKULZmohoqzl(android.text.TextPaint textPaint, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CRsoJKULZmohoqzl(android.text.TextPaint textPaint, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList CcyfsdMtxgeBlOZX(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextColor();
    }

    public static void CcyfsdMtxgeBlOZX(com.google.android.material.resources.TextAppearance textAppearance, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CcyfsdMtxgeBlOZX(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CcyfsdMtxgeBlOZX(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CsRiOOxYRXKlrObb(int i) {
        return android.graphics.Color.red(i);
    }

    public static void CsRiOOxYRXKlrObb(int i, char c, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CsRiOOxYRXKlrObb(int i, float f, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CsRiOOxYRXKlrObb(int i, java.lang.string str, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float CwHGahbdyFaTkumi(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void CwHGahbdyFaTkumi(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, byte b, bool z, int i, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void CwHGahbdyFaTkumi(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, float f4, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CwHGahbdyFaTkumi(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, bool z, int i, float f4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EAVdwzeEvFZtEAjG(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void EAVdwzeEvFZtEAjG(android.view.object view, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EAVdwzeEvFZtEAjG(android.view.object view, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EAVdwzeEvFZtEAjG(android.view.object view, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static float EIDJTVMFwdLUAZdE(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void EIDJTVMFwdLUAZdE(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EIDJTVMFwdLUAZdE(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EIDJTVMFwdLUAZdE(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.StaticLayoutBuilderCompat EYXhQVlyHmNWKdjd(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer) {
        return staticLayoutBuilderCompat.setStaticLayoutBuilderConfigurer(staticLayoutBuilderConfigurer);
    }

    public static void EYXhQVlyHmNWKdjd(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EYXhQVlyHmNWKdjd(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EYXhQVlyHmNWKdjd(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EdsPYvjVBIbgSctE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.calculateCurrentOffsets();
    }

    public static void EdsPYvjVBIbgSctE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EdsPYvjVBIbgSctE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EdsPYvjVBIbgSctE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EfFwiBeoxnKXRDFD(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void EfFwiBeoxnKXRDFD(android.graphics.Rect rect, int i, int i2, int i3, int i4, float f, int i5, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EfFwiBeoxnKXRDFD(android.graphics.Rect rect, int i, int i2, int i3, int i4, float f, bool z, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void EfFwiBeoxnKXRDFD(android.graphics.Rect rect, int i, int i2, int i3, int i4, short s, float f, int i5, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence EoOdhETTkwzjOiqA(android.text.StaticLayout staticLayout) {
        return staticLayout.getText();
    }

    public static void EoOdhETTkwzjOiqA(android.text.StaticLayout staticLayout, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EoOdhETTkwzjOiqA(android.text.StaticLayout staticLayout, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EoOdhETTkwzjOiqA(android.text.StaticLayout staticLayout, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EsQEUWbzNCfgKHAE(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void EsQEUWbzNCfgKHAE(android.graphics.Canvas canvas, int i, char c, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EsQEUWbzNCfgKHAE(android.graphics.Canvas canvas, int i, int i2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EsQEUWbzNCfgKHAE(android.graphics.Canvas canvas, int i, bool z, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EsYZDXcMfuhvgbpS(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static void EsYZDXcMfuhvgbpS(java.lang.object obj, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EsYZDXcMfuhvgbpS(java.lang.object obj, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EsYZDXcMfuhvgbpS(java.lang.object obj, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EzLEqlDsswgyIYJR(android.text.TextPaint textPaint, float f) {
        textPaint.setLetterSpacing(f);
    }

    public static void EzLEqlDsswgyIYJR(android.text.TextPaint textPaint, float f, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EzLEqlDsswgyIYJR(android.text.TextPaint textPaint, float f, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EzLEqlDsswgyIYJR(android.text.TextPaint textPaint, float f, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FARUyUxfMACksvMa(android.text.TextPaint textPaint, int i) {
        textPaint.setAlpha(i);
    }

    public static void FARUyUxfMACksvMa(android.text.TextPaint textPaint, int i, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FARUyUxfMACksvMa(android.text.TextPaint textPaint, int i, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FARUyUxfMACksvMa(android.text.TextPaint textPaint, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FFaeiXnFIBSDWJYf(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FFaeiXnFIBSDWJYf(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FFaeiXnFIBSDWJYf(java.lang.string str, java.lang.string str2, bool z, int i, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool FFaeiXnFIBSDWJYf(java.lang.string str, java.lang.string str2) {
        return str.EndsWith(str2);
    }

    public static int FGeVdIcwyEJkjdjz(android.text.StaticLayout staticLayout) {
        return staticLayout.getWidth();
    }

    public static void FGeVdIcwyEJkjdjz(android.text.StaticLayout staticLayout, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FGeVdIcwyEJkjdjz(android.text.StaticLayout staticLayout, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FGeVdIcwyEJkjdjz(android.text.StaticLayout staticLayout, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FhcLjWjJSVgQYlNH(android.text.StaticLayout staticLayout) {
        return staticLayout.getLineCount();
    }

    public static void FhcLjWjJSVgQYlNH(android.text.StaticLayout staticLayout, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FhcLjWjJSVgQYlNH(android.text.StaticLayout staticLayout, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FhcLjWjJSVgQYlNH(android.text.StaticLayout staticLayout, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Configuration FjvThexHIgPUOPFQ(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void FjvThexHIgPUOPFQ(android.content.res.Resources resources, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FjvThexHIgPUOPFQ(android.content.res.Resources resources, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FjvThexHIgPUOPFQ(android.content.res.Resources resources, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GBXlWSwXDzjoXifq(android.text.StaticLayout staticLayout) {
        return staticLayout.getHeight();
    }

    public static void GBXlWSwXDzjoXifq(android.text.StaticLayout staticLayout, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GBXlWSwXDzjoXifq(android.text.StaticLayout staticLayout, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GBXlWSwXDzjoXifq(android.text.StaticLayout staticLayout, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GSCgRdPLEXQyCYGv(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z) {
        collapsingTextHelper.calculateUsingTextSize(f, z);
    }

    public static void GSCgRdPLEXQyCYGv(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, byte b, int i, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void GSCgRdPLEXQyCYGv(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, float f2, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GSCgRdPLEXQyCYGv(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, int i, byte b, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static int GTUnuGcFQTohQgWB(android.text.StaticLayout staticLayout) {
        return staticLayout.getWidth();
    }

    public static void GTUnuGcFQTohQgWB(android.text.StaticLayout staticLayout, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GTUnuGcFQTohQgWB(android.text.StaticLayout staticLayout, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GTUnuGcFQTohQgWB(android.text.StaticLayout staticLayout, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GWwXgJBAUDPqMpMz(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void GWwXgJBAUDPqMpMz(android.graphics.Canvas canvas, float f, float f2, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GWwXgJBAUDPqMpMz(android.graphics.Canvas canvas, float f, float f2, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GWwXgJBAUDPqMpMz(android.graphics.Canvas canvas, float f, float f2, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GfNiiRBRGVdxmZiV(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback) {
        cancelableFontCallback.cancel();
    }

    public static void GfNiiRBRGVdxmZiV(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GfNiiRBRGVdxmZiV(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GfNiiRBRGVdxmZiV(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GmdEDSMiaRXAXVjq(android.text.StaticLayout staticLayout, int i) {
        return staticLayout.getLineEnd(i);
    }

    public static void GmdEDSMiaRXAXVjq(android.text.StaticLayout staticLayout, int i, char c, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GmdEDSMiaRXAXVjq(android.text.StaticLayout staticLayout, int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GmdEDSMiaRXAXVjq(android.text.StaticLayout staticLayout, int i, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object HNSbdWGySKGiVHFW(android.view.object view) {
        return view.getobject();
    }

    public static void HNSbdWGySKGiVHFW(android.view.object view, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HNSbdWGySKGiVHFW(android.view.object view, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HNSbdWGySKGiVHFW(android.view.object view, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float HSAryFJRGYnFeVhK(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void HSAryFJRGYnFeVhK(android.graphics.RectF rectF, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HSAryFJRGYnFeVhK(android.graphics.RectF rectF, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HSAryFJRGYnFeVhK(android.graphics.RectF rectF, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.text.StaticLayout HYtHJrBQlMoRQBNf(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat) {
        return staticLayoutBuilderCompat.build();
    }

    public static void HYtHJrBQlMoRQBNf(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HYtHJrBQlMoRQBNf(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HYtHJrBQlMoRQBNf(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float HcylRcWYVhzTJeUB(android.text.TextPaint textPaint) {
        return textPaint.descent();
    }

    public static void HcylRcWYVhzTJeUB(android.text.TextPaint textPaint, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HcylRcWYVhzTJeUB(android.text.TextPaint textPaint, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HcylRcWYVhzTJeUB(android.text.TextPaint textPaint, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HlWIdVCZlDChjorm(android.graphics.Bitmap bitmap) {
        bitmap.recycle();
    }

    public static void HlWIdVCZlDChjorm(android.graphics.Bitmap bitmap, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HlWIdVCZlDChjorm(android.graphics.Bitmap bitmap, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HlWIdVCZlDChjorm(android.graphics.Bitmap bitmap, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HrZaaqhCCBEnVWvR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void HrZaaqhCCBEnVWvR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HrZaaqhCCBEnVWvR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HrZaaqhCCBEnVWvR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IiWvAHMmjLyAJxQj(android.graphics.Canvas canvas, java.lang.string str, int i, int i2, float f, float f2, android.graphics.Paint paint) {
        canvas.drawText(str, i, i2, f, f2, paint);
    }

    public static void IiWvAHMmjLyAJxQj(android.graphics.Canvas canvas, java.lang.string str, int i, int i2, float f, float f2, android.graphics.Paint paint, byte b, int i3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IiWvAHMmjLyAJxQj(android.graphics.Canvas canvas, java.lang.string str, int i, int i2, float f, float f2, android.graphics.Paint paint, short s, byte b, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IiWvAHMmjLyAJxQj(android.graphics.Canvas canvas, java.lang.string str, int i, int i2, float f, float f2, android.graphics.Paint paint, short s, int i3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JGOUSlGOuIQNwVNX(float f) {
        return java.lang.Math.round(f);
    }

    public static void JGOUSlGOuIQNwVNX(float f, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JGOUSlGOuIQNwVNX(float f, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JGOUSlGOuIQNwVNX(float f, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JJKWrKMTjARNcaZR(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback) {
        cancelableFontCallback.cancel();
    }

    public static void JJKWrKMTjARNcaZR(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JJKWrKMTjARNcaZR(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JJKWrKMTjARNcaZR(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface KEPrVFtMoHwPEXGx(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getFallbackFont();
    }

    public static void KEPrVFtMoHwPEXGx(com.google.android.material.resources.TextAppearance textAppearance, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KEPrVFtMoHwPEXGx(com.google.android.material.resources.TextAppearance textAppearance, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KEPrVFtMoHwPEXGx(com.google.android.material.resources.TextAppearance textAppearance, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float KJxjQjhaKJPlJuMK(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2) {
        return collapsingTextHelper.getCollapsedTextLeftBound(i, i2);
    }

    public static void KJxjQjhaKJPlJuMK(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KJxjQjhaKJPlJuMK(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, short s, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void KJxjQjhaKJPlJuMK(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, short s, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KfMpbjdYKwLQJLSG(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void KfMpbjdYKwLQJLSG(java.lang.CharSequence charSequence, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KfMpbjdYKwLQJLSG(java.lang.CharSequence charSequence, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KfMpbjdYKwLQJLSG(java.lang.CharSequence charSequence, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KhMfBcOXYVomHrAa(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static void KhMfBcOXYVomHrAa(int i, int i2, byte b, int i3, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KhMfBcOXYVomHrAa(int i, int i2, float f, short s, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KhMfBcOXYVomHrAa(int i, int i2, short s, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KxlJqQMUniUvldmT(android.graphics.Rect rect, int i, int i2, int i3, int i4, byte b, char c, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KxlJqQMUniUvldmT(android.graphics.Rect rect, int i, int i2, int i3, int i4, byte b, int i5, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KxlJqQMUniUvldmT(android.graphics.Rect rect, int i, int i2, int i3, int i4, short s, int i5, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KxlJqQMUniUvldmT(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        return rectEquals(rect, i, i2, i3, i4);
    }

    public static void LJljemTmINUXkVuB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void LJljemTmINUXkVuB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LJljemTmINUXkVuB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LJljemTmINUXkVuB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LbTJyMQgkSrcYPcG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LbTJyMQgkSrcYPcG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LbTJyMQgkSrcYPcG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool LbTJyMQgkSrcYPcG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface) {
        return collapsingTextHelper.setCollapsedTypefaceInternal(typeface);
    }

    public static float LixVzSmdTklyDnOA(android.text.TextPaint textPaint) {
        return textPaint.ascent();
    }

    public static void LixVzSmdTklyDnOA(android.text.TextPaint textPaint, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LixVzSmdTklyDnOA(android.text.TextPaint textPaint, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LixVzSmdTklyDnOA(android.text.TextPaint textPaint, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LzGxFLOZsxCLQsCp(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.calculateOffsets(f);
    }

    public static void LzGxFLOZsxCLQsCp(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LzGxFLOZsxCLQsCp(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LzGxFLOZsxCLQsCp(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MDyMtJRmPopsekyZ(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void MDyMtJRmPopsekyZ(android.view.object view, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MDyMtJRmPopsekyZ(android.view.object view, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MDyMtJRmPopsekyZ(android.view.object view, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int MGlHaHNBQiHTQUKW(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        return collapsingTextHelper.getCurrentColor(colorStateList);
    }

    public static void MGlHaHNBQiHTQUKW(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MGlHaHNBQiHTQUKW(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MGlHaHNBQiHTQUKW(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static float MHAlAxNSRVhMMFdd(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void MHAlAxNSRVhMMFdd(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MHAlAxNSRVhMMFdd(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MHAlAxNSRVhMMFdd(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MhqXyIEYFCCDOdhY(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSize(f);
    }

    public static void MhqXyIEYFCCDOdhY(android.text.TextPaint textPaint, float f, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MhqXyIEYFCCDOdhY(android.text.TextPaint textPaint, float f, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MhqXyIEYFCCDOdhY(android.text.TextPaint textPaint, float f, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MkurCfcvhlnvlvnZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void MkurCfcvhlnvlvnZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MkurCfcvhlnvlvnZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MkurCfcvhlnvlvnZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MrGUWHnaKZiXVsRR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void MrGUWHnaKZiXVsRR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MrGUWHnaKZiXVsRR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MrGUWHnaKZiXVsRR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MrSFTKXJaOYGMkyw(android.graphics.Canvas canvas, java.lang.CharSequence charSequence, int i, int i2, float f, float f2, android.graphics.Paint paint) {
        canvas.drawText(charSequence, i, i2, f, f2, paint);
    }

    public static void MrSFTKXJaOYGMkyw(android.graphics.Canvas canvas, java.lang.CharSequence charSequence, int i, int i2, float f, float f2, android.graphics.Paint paint, float f3, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MrSFTKXJaOYGMkyw(android.graphics.Canvas canvas, java.lang.CharSequence charSequence, int i, int i2, float f, float f2, android.graphics.Paint paint, float f3, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MrSFTKXJaOYGMkyw(android.graphics.Canvas canvas, java.lang.CharSequence charSequence, int i, int i2, float f, float f2, android.graphics.Paint paint, java.lang.string str, bool z, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MvqyRwaACHrhlYsR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.interpolateBounds(f);
    }

    public static void MvqyRwaACHrhlYsR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MvqyRwaACHrhlYsR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MvqyRwaACHrhlYsR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object MzWTWWGjPBacOsqU(android.view.object view) {
        return view.getobject();
    }

    public static void MzWTWWGjPBacOsqU(android.view.object view, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MzWTWWGjPBacOsqU(android.view.object view, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MzWTWWGjPBacOsqU(android.view.object view, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NQtAuAOONscvEYBz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z) {
        collapsingTextHelper.calculateUsingTextSize(f, z);
    }

    public static void NQtAuAOONscvEYBz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, byte b, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NQtAuAOONscvEYBz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, char c, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NQtAuAOONscvEYBz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, bool z2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.text.StaticLayout NYHMtNXXkRxVHdeq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, float f, bool z) {
        return collapsingTextHelper.createStaticLayout(i, f, z);
    }

    public static void NYHMtNXXkRxVHdeq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, float f, bool z, int i2, byte b, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void NYHMtNXXkRxVHdeq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, float f, bool z, int i2, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NYHMtNXXkRxVHdeq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, float f, bool z, int i2, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void NaoscGZoqxiaEEnT(android.text.TextPaint textPaint, bool z) {
        textPaint.setLinearText(z);
    }

    public static void NaoscGZoqxiaEEnT(android.text.TextPaint textPaint, bool z, java.lang.string str, short s, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NaoscGZoqxiaEEnT(android.text.TextPaint textPaint, bool z, bool z2, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NaoscGZoqxiaEEnT(android.text.TextPaint textPaint, bool z, bool z2, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object NpYsSlDrozjwPyqv(android.view.object view) {
        return view.getobject();
    }

    public static void NpYsSlDrozjwPyqv(android.view.object view, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NpYsSlDrozjwPyqv(android.view.object view, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NpYsSlDrozjwPyqv(android.view.object view, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OEFDDcfmjytVnMXB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCurrentExpandedTextColor();
    }

    public static void OEFDDcfmjytVnMXB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OEFDDcfmjytVnMXB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OEFDDcfmjytVnMXB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface OSsFNyTQqqbWCVPC(android.text.TextPaint textPaint, android.graphics.Typeface typeface) {
        return textPaint.setTypeface(typeface);
    }

    public static void OSsFNyTQqqbWCVPC(android.text.TextPaint textPaint, android.graphics.Typeface typeface, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OSsFNyTQqqbWCVPC(android.text.TextPaint textPaint, android.graphics.Typeface typeface, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OSsFNyTQqqbWCVPC(android.text.TextPaint textPaint, android.graphics.Typeface typeface, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float OgLCBJSgbeBaChdD(float f) {
        return java.lang.Math.abs(f);
    }

    public static void OgLCBJSgbeBaChdD(float f, bool z, byte b, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OgLCBJSgbeBaChdD(float f, bool z, byte b, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void OgLCBJSgbeBaChdD(float f, bool z, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void OtJXfYehsTnOBTmC(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z) {
        collapsingTextHelper.recalculate(z);
    }

    public static void OtJXfYehsTnOBTmC(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, char c, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OtJXfYehsTnOBTmC(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, java.lang.string str, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OtJXfYehsTnOBTmC(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, bool z2, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PLAQazukxAvkUWDn(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSize(f);
    }

    public static void PLAQazukxAvkUWDn(android.text.TextPaint textPaint, float f, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PLAQazukxAvkUWDn(android.text.TextPaint textPaint, float f, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PLAQazukxAvkUWDn(android.text.TextPaint textPaint, float f, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float PPXhixYrVVHfFczd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        return collapsingTextHelper.calculateFadeModeTextAlpha(f);
    }

    public static void PPXhixYrVVHfFczd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, byte b, float f2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PPXhixYrVVHfFczd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, short s, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PPXhixYrVVHfFczd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, short s, java.lang.string str, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources PQaTepwXlCxcMjiA(android.content.object context) {
        return context.getResources();
    }

    public static void PQaTepwXlCxcMjiA(android.content.object context, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PQaTepwXlCxcMjiA(android.content.object context, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PQaTepwXlCxcMjiA(android.content.object context, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PpgtPArIDrNvyWDV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint) {
        collapsingTextHelper.getTextPaintExpanded(textPaint);
    }

    public static void PpgtPArIDrNvyWDV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PpgtPArIDrNvyWDV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PpgtPArIDrNvyWDV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QMlUGqnQGGXayVay(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setInterpolatedTextSize(f);
    }

    public static void QMlUGqnQGGXayVay(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, float f2, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QMlUGqnQGGXayVay(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, char c, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QMlUGqnQGGXayVay(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, float f2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface QVrDdFpaPPLuHChm(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getFallbackFont();
    }

    public static void QVrDdFpaPPLuHChm(com.google.android.material.resources.TextAppearance textAppearance, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QVrDdFpaPPLuHChm(com.google.android.material.resources.TextAppearance textAppearance, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QVrDdFpaPPLuHChm(com.google.android.material.resources.TextAppearance textAppearance, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static float QbSlhOfueeOEbtOZ(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void QbSlhOfueeOEbtOZ(float f, float f2, char c, bool z, java.lang.string str, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void QbSlhOfueeOEbtOZ(float f, float f2, float f3, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QbSlhOfueeOEbtOZ(float f, float f2, float f3, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float QhBeVQOhnVlNMIcb(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void QhBeVQOhnVlNMIcb(float f, float f2, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QhBeVQOhnVlNMIcb(float f, float f2, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QhBeVQOhnVlNMIcb(float f, float f2, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QvbrOhVNRGDRkCdx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z) {
        collapsingTextHelper.calculateUsingTextSize(f, z);
    }

    public static void QvbrOhVNRGDRkCdx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, char c, java.lang.string str, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QvbrOhVNRGDRkCdx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, float f2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QvbrOhVNRGDRkCdx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, short s, java.lang.string str, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RDbpZzCGhMiPhVJR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.ensureExpandedTexture();
    }

    public static void RDbpZzCGhMiPhVJR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RDbpZzCGhMiPhVJR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RDbpZzCGhMiPhVJR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RPwgAVZEajyaDVFs(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas) {
        staticLayout.draw(canvas);
    }

    public static void RPwgAVZEajyaDVFs(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RPwgAVZEajyaDVFs(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RPwgAVZEajyaDVFs(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RSKrvytPwFJzrbSW(int i, int i2) {
        return com.google.android.material.color.MaterialColors.compositeARGBWithAlpha(i, i2);
    }

    public static void RSKrvytPwFJzrbSW(int i, int i2, char c, float f, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RSKrvytPwFJzrbSW(int i, int i2, int i3, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RSKrvytPwFJzrbSW(int i, int i2, short s, float f, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RWjSUyqBMnHAScuZ(androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat, java.lang.CharSequence charSequence, int i, int i2, float f, int i3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RWjSUyqBMnHAScuZ(androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat, java.lang.CharSequence charSequence, int i, int i2, float f, bool z, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RWjSUyqBMnHAScuZ(androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat, java.lang.CharSequence charSequence, int i, int i2, short s, int i3, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RWjSUyqBMnHAScuZ(androidx.core.text.TextDirectionHeuristicCompat textDirectionHeuristicCompat, java.lang.CharSequence charSequence, int i, int i2) {
        return textDirectionHeuristicCompat.isRtl(charSequence, i, i2);
    }

    public static float RlJthSlxHYmETSSu(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextSize();
    }

    public static void RlJthSlxHYmETSSu(com.google.android.material.resources.TextAppearance textAppearance, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RlJthSlxHYmETSSu(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RlJthSlxHYmETSSu(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RmryEcZiQisXQvEB(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void RmryEcZiQisXQvEB(android.graphics.Canvas canvas, int i, char c, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RmryEcZiQisXQvEB(android.graphics.Canvas canvas, int i, float f, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RmryEcZiQisXQvEB(android.graphics.Canvas canvas, int i, java.lang.string str, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int STLIeIiMOXRWBcCF(android.text.StaticLayout staticLayout) {
        return staticLayout.getHeight();
    }

    public static void STLIeIiMOXRWBcCF(android.text.StaticLayout staticLayout, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void STLIeIiMOXRWBcCF(android.text.StaticLayout staticLayout, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void STLIeIiMOXRWBcCF(android.text.StaticLayout staticLayout, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SaIwFPEfliHwdLHO(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void SaIwFPEfliHwdLHO(android.view.object view, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SaIwFPEfliHwdLHO(android.view.object view, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SaIwFPEfliHwdLHO(android.view.object view, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int SbOJGEIbvGPZKPda(android.view.object view) {
        return view.getWidth();
    }

    public static void SbOJGEIbvGPZKPda(android.view.object view, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SbOJGEIbvGPZKPda(android.view.object view, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SbOJGEIbvGPZKPda(android.view.object view, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int SoFzwxuoPRNgDcBv(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void SoFzwxuoPRNgDcBv(int i, int i2, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SoFzwxuoPRNgDcBv(int i, int i2, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SoFzwxuoPRNgDcBv(int i, int i2, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TSQwFpzLMyTqLOFY(int i, int i2) {
        return com.google.android.material.color.MaterialColors.compositeARGBWithAlpha(i, i2);
    }

    public static void TSQwFpzLMyTqLOFY(int i, int i2, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TSQwFpzLMyTqLOFY(int i, int i2, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TSQwFpzLMyTqLOFY(int i, int i2, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TTiMPYBIdBcGndSB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.calculateCurrentOffsets();
    }

    public static void TTiMPYBIdBcGndSB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TTiMPYBIdBcGndSB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TTiMPYBIdBcGndSB(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int TUhuYaGSptgwPIzG(android.graphics.Rect rect) {
        return rect.centerX();
    }

    public static void TUhuYaGSptgwPIzG(android.graphics.Rect rect, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TUhuYaGSptgwPIzG(android.graphics.Rect rect, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TUhuYaGSptgwPIzG(android.graphics.Rect rect, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.StaticLayoutBuilderCompat TmoYyOovfVvrUodw(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        return staticLayoutBuilderCompat.setEllipsize(textUtils$TruncateAt);
    }

    public static void TmoYyOovfVvrUodw(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, android.text.TextUtils$TruncateAt textUtils$TruncateAt, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TmoYyOovfVvrUodw(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, android.text.TextUtils$TruncateAt textUtils$TruncateAt, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TmoYyOovfVvrUodw(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, android.text.TextUtils$TruncateAt textUtils$TruncateAt, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float TtsbnmSvNcEXMjYj(android.text.TextPaint textPaint) {
        return textPaint.ascent();
    }

    public static void TtsbnmSvNcEXMjYj(android.text.TextPaint textPaint, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TtsbnmSvNcEXMjYj(android.text.TextPaint textPaint, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TtsbnmSvNcEXMjYj(android.text.TextPaint textPaint, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UGzHhOwKjYcfrdEi(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static void UGzHhOwKjYcfrdEi(int i, int i2, float f, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UGzHhOwKjYcfrdEi(int i, int i2, bool z, byte b, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UGzHhOwKjYcfrdEi(int i, int i2, bool z, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UMuGOkVTcyWptjum(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void UMuGOkVTcyWptjum(android.graphics.Canvas canvas, float f, float f2, float f3, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UMuGOkVTcyWptjum(android.graphics.Canvas canvas, float f, float f2, float f3, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UMuGOkVTcyWptjum(android.graphics.Canvas canvas, float f, float f2, java.lang.string str, bool z, char c, float f3) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Configuration UQWRCEovZuaxktcj(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static void UQWRCEovZuaxktcj(android.content.res.Resources resources, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UQWRCEovZuaxktcj(android.content.res.Resources resources, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UQWRCEovZuaxktcj(android.content.res.Resources resources, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UbmOAnVuZWGsEjKG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UbmOAnVuZWGsEjKG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UbmOAnVuZWGsEjKG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UbmOAnVuZWGsEjKG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.isDefaultIsRtl();
    }

    public static void UclDUZHKZVYBpWDR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void UclDUZHKZVYBpWDR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UclDUZHKZVYBpWDR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UclDUZHKZVYBpWDR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UejBPOPnZyjdFWoi(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static void UejBPOPnZyjdFWoi(int i, int i2, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UejBPOPnZyjdFWoi(int i, int i2, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UejBPOPnZyjdFWoi(int i, int i2, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UsGHdnwdoZBnhlcK(android.text.TextPaint textPaint, int i) {
        textPaint.setAlpha(i);
    }

    public static void UsGHdnwdoZBnhlcK(android.text.TextPaint textPaint, int i, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UsGHdnwdoZBnhlcK(android.text.TextPaint textPaint, int i, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UsGHdnwdoZBnhlcK(android.text.TextPaint textPaint, int i, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VRpEsYfFsDPjrCdl(android.text.TextPaint textPaint, float f, float f2, float f3, int i) {
        textPaint.setShadowLayer(f, f2, f3, i);
    }

    public static void VRpEsYfFsDPjrCdl(android.text.TextPaint textPaint, float f, float f2, float f3, int i, char c, bool z, int i2, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void VRpEsYfFsDPjrCdl(android.text.TextPaint textPaint, float f, float f2, float f3, int i, bool z, char c, int i2, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void VRpEsYfFsDPjrCdl(android.text.TextPaint textPaint, float f, float f2, float f3, int i, bool z, int i2, float f4, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VVwIjRuXtDEaQJiq(int i, int i2) {
        return com.google.android.material.color.MaterialColors.compositeARGBWithAlpha(i, i2);
    }

    public static void VVwIjRuXtDEaQJiq(int i, int i2, float f, bool z, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VVwIjRuXtDEaQJiq(int i, int i2, int i3, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VVwIjRuXtDEaQJiq(int i, int i2, java.lang.string str, bool z, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static float VibWBlUJldIZosXv(android.text.TextPaint textPaint) {
        return textPaint.ascent();
    }

    public static void VibWBlUJldIZosXv(android.text.TextPaint textPaint, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VibWBlUJldIZosXv(android.text.TextPaint textPaint, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VibWBlUJldIZosXv(android.text.TextPaint textPaint, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float VkDMMwMWhQMayZJX(android.text.TextPaint textPaint) {
        return textPaint.descent();
    }

    public static void VkDMMwMWhQMayZJX(android.text.TextPaint textPaint, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VkDMMwMWhQMayZJX(android.text.TextPaint textPaint, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VkDMMwMWhQMayZJX(android.text.TextPaint textPaint, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WZfSizderpNgjKxy(android.text.TextPaint textPaint, float f) {
        textPaint.setLetterSpacing(f);
    }

    public static void WZfSizderpNgjKxy(android.text.TextPaint textPaint, float f, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WZfSizderpNgjKxy(android.text.TextPaint textPaint, float f, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WZfSizderpNgjKxy(android.text.TextPaint textPaint, float f, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object WvAkrfxsRSUArvcM(android.view.object view) {
        return view.getobject();
    }

    public static void WvAkrfxsRSUArvcM(android.view.object view, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WvAkrfxsRSUArvcM(android.view.object view, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WvAkrfxsRSUArvcM(android.view.object view, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WwjTRcJiDctQiiip(android.text.TextPaint textPaint) {
        return textPaint.getAlpha();
    }

    public static void WwjTRcJiDctQiiip(android.text.TextPaint textPaint, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WwjTRcJiDctQiiip(android.text.TextPaint textPaint, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WwjTRcJiDctQiiip(android.text.TextPaint textPaint, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XerYHWnyULckDOqG(android.text.TextPaint textPaint, float f, float f2, float f3, int i) {
        textPaint.setShadowLayer(f, f2, f3, i);
    }

    public static void XerYHWnyULckDOqG(android.text.TextPaint textPaint, float f, float f2, float f3, int i, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XerYHWnyULckDOqG(android.text.TextPaint textPaint, float f, float f2, float f3, int i, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XerYHWnyULckDOqG(android.text.TextPaint textPaint, float f, float f2, float f3, int i, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XgEAAeIFnFdSFRqI(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void XgEAAeIFnFdSFRqI(android.graphics.Canvas canvas, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XgEAAeIFnFdSFRqI(android.graphics.Canvas canvas, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XgEAAeIFnFdSFRqI(android.graphics.Canvas canvas, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XnNFoVAKwbudQIPE(java.lang.CharSequence charSequence, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XnNFoVAKwbudQIPE(java.lang.CharSequence charSequence, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XnNFoVAKwbudQIPE(java.lang.CharSequence charSequence, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool XnNFoVAKwbudQIPE(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int XpyXDmHnJwNltkgG(android.graphics.Rect rect) {
        return rect.width();
    }

    public static void XpyXDmHnJwNltkgG(android.graphics.Rect rect, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XpyXDmHnJwNltkgG(android.graphics.Rect rect, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XpyXDmHnJwNltkgG(android.graphics.Rect rect, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.StaticLayoutBuilderCompat YNQGFIyhEeivEBFd(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, bool z) {
        return staticLayoutBuilderCompat.setIncludePad(z);
    }

    public static void YNQGFIyhEeivEBFd(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, bool z, int i, bool z2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YNQGFIyhEeivEBFd(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, bool z, java.lang.string str, byte b, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YNQGFIyhEeivEBFd(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, bool z, bool z2, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YQjqHwQlQBtXUYHM(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas, float f, float f2) {
        collapsingTextHelper.drawMultilineTransition(canvas, f, f2);
    }

    public static void YQjqHwQlQBtXUYHM(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas, float f, float f2, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YQjqHwQlQBtXUYHM(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas, float f, float f2, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YQjqHwQlQBtXUYHM(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas, float f, float f2, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YmSdEePbAEUXOQbR(java.lang.object obj) {
        return obj.tostring();
    }

    public static void YmSdEePbAEUXOQbR(java.lang.object obj, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YmSdEePbAEUXOQbR(java.lang.object obj, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YmSdEePbAEUXOQbR(java.lang.object obj, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface YqScwgSrIYZucDVh(android.content.res.Configuration configuration, android.graphics.Typeface typeface) {
        return com.google.android.material.resources.TypefaceUtils.maybeCopyWithFontWeightAdjustment(configuration, typeface);
    }

    public static void YqScwgSrIYZucDVh(android.content.res.Configuration configuration, android.graphics.Typeface typeface, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YqScwgSrIYZucDVh(android.content.res.Configuration configuration, android.graphics.Typeface typeface, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YqScwgSrIYZucDVh(android.content.res.Configuration configuration, android.graphics.Typeface typeface, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZELwnkTIRkpIInyX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void ZELwnkTIRkpIInyX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZELwnkTIRkpIInyX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZELwnkTIRkpIInyX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ZJAuHiaOFqeMfvXr(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.calculateFadeModeThresholdFraction();
    }

    public static void ZJAuHiaOFqeMfvXr(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZJAuHiaOFqeMfvXr(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZJAuHiaOFqeMfvXr(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZJRtkUelswABrBWb(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void ZJRtkUelswABrBWb(android.view.object view, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZJRtkUelswABrBWb(android.view.object view, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZJRtkUelswABrBWb(android.view.object view, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZZYxRJfMsHLcONHP(android.text.TextPaint textPaint, int i) {
        textPaint.setColor(i);
    }

    public static void ZZYxRJfMsHLcONHP(android.text.TextPaint textPaint, int i, byte b, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZZYxRJfMsHLcONHP(android.text.TextPaint textPaint, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZZYxRJfMsHLcONHP(android.text.TextPaint textPaint, int i, char c, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZaCtJSzClJmJpIHZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void ZaCtJSzClJmJpIHZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZaCtJSzClJmJpIHZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZaCtJSzClJmJpIHZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZkDtWhGUoMTaqVqL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z) {
        collapsingTextHelper.recalculate(z);
    }

    public static void ZkDtWhGUoMTaqVqL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, char c, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZkDtWhGUoMTaqVqL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, float f, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ZkDtWhGUoMTaqVqL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, bool z2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZqxFZSEInPGDVEWa(android.text.TextPaint textPaint, int i) {
        textPaint.setColor(i);
    }

    public static void ZqxFZSEInPGDVEWa(android.text.TextPaint textPaint, int i, byte b, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZqxFZSEInPGDVEWa(android.text.TextPaint textPaint, int i, byte b, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZqxFZSEInPGDVEWa(android.text.TextPaint textPaint, int i, short s, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZtImZbhysHASRHWm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint) {
        collapsingTextHelper.getTextPaintCollapsed(textPaint);
    }

    public static void ZtImZbhysHASRHWm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZtImZbhysHASRHWm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZtImZbhysHASRHWm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZvjsVFOufBPIrsMB(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback) {
        cancelableFontCallback.cancel();
    }

    public static void ZvjsVFOufBPIrsMB(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZvjsVFOufBPIrsMB(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZvjsVFOufBPIrsMB(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int AAVlUbCblhIJEVOA(android.text.StaticLayout staticLayout) {
        return staticLayout.getWidth();
    }

    public static void AAVlUbCblhIJEVOA(android.text.StaticLayout staticLayout, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AAVlUbCblhIJEVOA(android.text.StaticLayout staticLayout, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AAVlUbCblhIJEVOA(android.text.StaticLayout staticLayout, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float AFvZiYIwROMKYruN(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void AFvZiYIwROMKYruN(float f, float f2, byte b, float f3, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AFvZiYIwROMKYruN(float f, float f2, float f3, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AFvZiYIwROMKYruN(float f, float f2, int i, java.lang.string str, byte b, float f3) {
        double d = (42 * 210) + 210;
    }

    public static int AIZcEnvftQkvwRap(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void AIZcEnvftQkvwRap(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AIZcEnvftQkvwRap(android.content.res.ColorStateList colorStateList, int[] iArr, int i, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AIZcEnvftQkvwRap(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AUAidxpYVDUZVhDN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.clearTexture();
    }

    public static void AUAidxpYVDUZVhDN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AUAidxpYVDUZVhDN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AUAidxpYVDUZVhDN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AiEdIPzInjLrNLwx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void AiEdIPzInjLrNLwx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AiEdIPzInjLrNLwx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AiEdIPzInjLrNLwx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float ArBSObkRWrrKuxzI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.RectF rectF, int i, int i2) {
        return collapsingTextHelper.getCollapsedTextRightBound(rectF, i, i2);
    }

    public static void ArBSObkRWrrKuxzI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.RectF rectF, int i, int i2, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ArBSObkRWrrKuxzI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.RectF rectF, int i, int i2, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ArBSObkRWrrKuxzI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.RectF rectF, int i, int i2, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BICYhkZCqrlxVtRb(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void BICYhkZCqrlxVtRb(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BICYhkZCqrlxVtRb(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BICYhkZCqrlxVtRb(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BRKbHDxjZkXthWUu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.calculateUsingTextSize(f);
    }

    public static void BRKbHDxjZkXthWUu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BRKbHDxjZkXthWUu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BRKbHDxjZkXthWUu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BTDLIrYOGnFsWNEm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void BTDLIrYOGnFsWNEm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BTDLIrYOGnFsWNEm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BTDLIrYOGnFsWNEm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private static int BlendARGB(int i, int i2, float f) {
        if ((9 + 26) % 26 > 0) {
        }
        float f2 = 1.0f - f;
        return umFaEAuMfRedPvjH(BywmsecDWbohMEAy((erOHeUyCODbGNqND(i) * f2) + (wlRlveUFbwcseozy(i2) * f)), xSqXZlDgHXtGzUrh((CsRiOOxYRXKlrObb(i) * f2) + (lTIccAvlHubodyEl(i2) * f)), JGOUSlGOuIQNwVNX((kpTGGedwIgvvgWBF(i) * f2) + (AlDdrrqabSIUxpaR(i2) * f)), jDGgBEIecnxPbecL((frNWTXEdSfpbbjSE(i) * f2) + (hrTdPhNvaDcgKLEk(i2) * f)));
    }

    private static void BlendARGB(int i, int i2, float f, byte b, bool z, int i3, float f2) {
        double d = (42 * 210) + 210;
    }

    private static void BlendARGB(int i, int i2, float f, int i3, byte b, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void BlendARGB(int i, int i2, float f, bool z, byte b, int i3, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CAIFSjaZzenDAVBD(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.calculateOffsets(f);
    }

    public static void CAIFSjaZzenDAVBD(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CAIFSjaZzenDAVBD(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CAIFSjaZzenDAVBD(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int CHlvHFpwqaEbUviw(android.text.StaticLayout staticLayout) {
        return staticLayout.getLineCount();
    }

    public static void CHlvHFpwqaEbUviw(android.text.StaticLayout staticLayout, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CHlvHFpwqaEbUviw(android.text.StaticLayout staticLayout, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CHlvHFpwqaEbUviw(android.text.StaticLayout staticLayout, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface CZEceYBryiZcsaWG(android.content.res.Configuration configuration, android.graphics.Typeface typeface) {
        return com.google.android.material.resources.TypefaceUtils.maybeCopyWithFontWeightAdjustment(configuration, typeface);
    }

    public static void CZEceYBryiZcsaWG(android.content.res.Configuration configuration, android.graphics.Typeface typeface, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CZEceYBryiZcsaWG(android.content.res.Configuration configuration, android.graphics.Typeface typeface, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CZEceYBryiZcsaWG(android.content.res.Configuration configuration, android.graphics.Typeface typeface, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CalculateBaseOffsets(bool z) {
        android.text.StaticLayout staticLayout;
        if ((19 + 8) % 8 > 0) {
        }
        QvbrOhVNRGDRkCdx(this, 1.0f, z);
        java.lang.CharSequence charSequence = this.textToDraw;
        if (charSequence is not null && (staticLayout = this.textLayout) is not null) {
            this.textToDrawCollapsed = BJqdehITZgzdlhna(charSequence, this.textPaint, GTUnuGcFQTohQgWB(staticLayout), this.titleTextEllipsize);
        }
        java.lang.CharSequence charSequence2 = this.textToDrawCollapsed;
        float fUzPapynukZJXMqds = 0.0f;
        if (charSequence2 is null) {
            this.collapsedTextWidth = 0.0f;
        } else {
            this.collapsedTextWidth = fbYJZvzdZDkbkvcj(this, this.textPaint, charSequence2);
        }
        int iUejBPOPnZyjdFWoi = UejBPOPnZyjdFWoi(this.collapsedTextGravity, this.isRtl ? 1 : 0);
        int i = iUejBPOPnZyjdFWoi & 112;
        if (i == 48) {
            this.collapsedDrawY = this.collapsedBounds.top;
        } else if (i == 80) {
            this.collapsedDrawY = this.collapsedBounds.bottom + VibWBlUJldIZosXv(this.textPaint);
        } else {
            this.collapsedDrawY = siGXquyTfltCRpmE(this.collapsedBounds) - ((VkDMMwMWhQMayZJX(this.textPaint) - CFLoyTcmYWZxIvpa(this.textPaint)) / 2.0f);
        }
        int i2 = iUejBPOPnZyjdFWoi & 8388615;
        if (i2 == 1) {
            this.collapsedDrawX = ACmPBSXZEaipirue(this.collapsedBounds) - (this.collapsedTextWidth / 2.0f);
        } else if (i2 == 5) {
            this.collapsedDrawX = this.collapsedBounds.right - this.collapsedTextWidth;
        } else {
            this.collapsedDrawX = this.collapsedBounds.left;
        }
        GSCgRdPLEXQyCYGv(this, 0.0f, z);
        float fGBXlWSwXDzjoXifq = this.textLayout is null ? 0.0f : GBXlWSwXDzjoXifq(r10);
        android.text.StaticLayout staticLayout2 = this.textLayout;
        if (staticLayout2 is not null && this.maxLines > 1) {
            fUzPapynukZJXMqds = FGeVdIcwyEJkjdjz(staticLayout2);
        } else {
            java.lang.CharSequence charSequence3 = this.textToDraw;
            if (charSequence3 is not null) {
                fUzPapynukZJXMqds = uzPapynukZJXMqds(this, this.textPaint, charSequence3);
            }
        }
        android.text.StaticLayout staticLayout3 = this.textLayout;
        this.expandedLineCount = staticLayout3 is null ? 0 : FhcLjWjJSVgQYlNH(staticLayout3);
        int iUGzHhOwKjYcfrdEi = UGzHhOwKjYcfrdEi(this.expandedTextGravity, this.isRtl ? 1 : 0);
        int i3 = iUGzHhOwKjYcfrdEi & 112;
        if (i3 == 48) {
            this.expandedDrawY = this.expandedBounds.top;
        } else if (i3 == 80) {
            this.expandedDrawY = (this.expandedBounds.bottom - fGBXlWSwXDzjoXifq) + CRsoJKULZmohoqzl(this.textPaint);
        } else {
            this.expandedDrawY = gOEqOwigTDUaeFJW(this.expandedBounds) - (fGBXlWSwXDzjoXifq / 2.0f);
        }
        int i4 = iUGzHhOwKjYcfrdEi & 8388615;
        if (i4 == 1) {
            this.expandedDrawX = TUhuYaGSptgwPIzG(this.expandedBounds) - (fUzPapynukZJXMqds / 2.0f);
        } else if (i4 == 5) {
            this.expandedDrawX = this.expandedBounds.right - fUzPapynukZJXMqds;
        } else {
            this.expandedDrawX = this.expandedBounds.left;
        }
        fgKrOQycEHSZaZHi(this);
        BSDYsRJdYQHxlOjX(this, this.expandedFraction);
    }

    private void CalculateBaseOffsets(bool z, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void CalculateBaseOffsets(bool z, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void CalculateBaseOffsets(bool z, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCurrentOffsets() {
        cAIFSjaZzenDAVBD(this, this.expandedFraction);
    }

    private void CalculateCurrentOffsets(char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCurrentOffsets(bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCurrentOffsets(bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private float CalculateFadeModeTextAlpha(float f) {
        if ((12 + 15) % 15 > 0) {
        }
        float f2 = this.fadeModeThresholdFraction;
        return f > f2 ? wQZkBVfELWXBCwlo(0.0f, 1.0f, f2, 1.0f, f) : zTNScplmuATSoUAf(1.0f, 0.0f, this.fadeModeStartFraction, f2, f);
    }

    private void CalculateFadeModeTextAlpha(float f, float f2, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CalculateFadeModeTextAlpha(float f, float f2, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CalculateFadeModeTextAlpha(float f, java.lang.string str, float f2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private float CalculateFadeModeThresholdFraction() {
        if ((24 + 31) % 31 > 0) {
        }
        float f = this.fadeModeStartFraction;
        return f + ((1.0f - f) * 0.5f);
    }

    private void CalculateFadeModeThresholdFraction(byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void CalculateFadeModeThresholdFraction(char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateFadeModeThresholdFraction(short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateIsRtl(java.lang.CharSequence charSequence, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateIsRtl(java.lang.CharSequence charSequence, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CalculateIsRtl(java.lang.CharSequence charSequence, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool CalculateIsRtl(java.lang.CharSequence charSequence) {
        if ((24 + 22) % 22 > 0) {
        }
        bool zUbmOAnVuZWGsEjKG = UbmOAnVuZWGsEjKG(this);
        return !this.isRtlTextDirectionHeuristicsEnabled ? zUbmOAnVuZWGsEjKG : lIPgTllSFInFovMg(this, charSequence, zUbmOAnVuZWGsEjKG);
    }

    private void CalculateOffsets(float f) {
        float f2;
        if ((1 + 9) % 9 > 0) {
        }
        MvqyRwaACHrhlYsR(this, f);
        if (!this.fadeModeEnabled) {
            this.currentDrawX = CwHGahbdyFaTkumi(this.expandedDrawX, this.collapsedDrawX, f, this.positionInterpolator);
            this.currentDrawY = EIDJTVMFwdLUAZdE(this.expandedDrawY, this.collapsedDrawY, f, this.positionInterpolator);
            lAlNEtiHkmvhODMC(this, f);
            f2 = f;
        } else if (f >= this.fadeModeThresholdFraction) {
            this.currentDrawX = this.collapsedDrawX;
            this.currentDrawY = this.collapsedDrawY - hNynEYmUQqMBhuUH(0, this.currentOffsetY);
            QMlUGqnQGGXayVay(this, 1.0f);
            f2 = 1.0f;
        } else {
            this.currentDrawX = this.expandedDrawX;
            this.currentDrawY = this.expandedDrawY;
            cmoJalnDBqJVpcMW(this, 0.0f);
            f2 = 0.0f;
        }
        iTmDTbcOBMAcAIHG(this, 1.0f - ykKejpFAEPXTFAFu(0.0f, 1.0f, 1.0f - f, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        yPqxXFmeRTAXPPwV(this, BqMKRmutqyQUMIfJ(1.0f, 0.0f, f, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        if (this.collapsedTextColor == this.expandedTextColor) {
            ZqxFZSEInPGDVEWa(this.textPaint, AvkOCyZRzaybYuoq(this));
        } else {
            ZZYxRJfMsHLcONHP(this.textPaint, jreNFgtkoEzYwxug(OEFDDcfmjytVnMXB(this), AihtfrzXZFcTPPst(this), f2));
        }
        float f3 = this.collapsedLetterSpacing;
        float f4 = this.expandedLetterSpacing;
        if (f3 == f4) {
            WZfSizderpNgjKxy(this.textPaint, f3);
        } else {
            BHxCSMpLqOWXxWEc(this.textPaint, zNsrxGUlMcLwgaqj(f4, f3, f, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        }
        this.currentShadowRadius = yPRtiURkzgBEUQYQ(this.expandedShadowRadius, this.collapsedShadowRadius, f, null);
        this.currentShadowDx = vMtokZMkzrLTGZBB(this.expandedShadowDx, this.collapsedShadowDx, f, null);
        this.currentShadowDy = xNUCSRLiCogUKxgE(this.expandedShadowDy, this.collapsedShadowDy, f, null);
        int iYguLOzQAjdyneuBu = yguLOzQAjdyneuBu(zjvBjSyScEbXCGJu(this, this.expandedShadowColor), AMpNqOYdaHPBiDqH(this, this.collapsedShadowColor), f);
        this.currentShadowColor = iYguLOzQAjdyneuBu;
        BnehzfxXDwSOKavc(this.textPaint, this.currentShadowRadius, this.currentShadowDx, this.currentShadowDy, iYguLOzQAjdyneuBu);
        if (this.fadeModeEnabled) {
            fENxJfZMAYJxVufx(this.textPaint, (int) (PPXhixYrVVHfFczd(this, f) * WwjTRcJiDctQiiip(this.textPaint)));
            if (android.os.Build$VERSION.SDK_INT >= 31) {
                android.text.TextPaint textPaint = this.textPaint;
                VRpEsYfFsDPjrCdl(textPaint, this.currentShadowRadius, this.currentShadowDx, this.currentShadowDy, TSQwFpzLMyTqLOFY(this.currentShadowColor, CHoAkBXroKfpMYQA(textPaint)));
            }
        }
        MDyMtJRmPopsekyZ(this.view);
    }

    private void CalculateOffsets(float f, char c, bool z, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CalculateOffsets(float f, float f2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CalculateOffsets(float f, java.lang.string str, float f2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateUsingTextSize(float f) {
        NQtAuAOONscvEYBz(this, f, false);
    }

    private void CalculateUsingTextSize(float f, byte b, float f2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateUsingTextSize(float f, byte b, short s, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    private void CalculateUsingTextSize(float f, int i, byte b, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    private void CalculateUsingTextSize(float f, bool z) {
        float f2;
        float f3;
        android.graphics.Typeface typeface;
        if ((6 + 31) % 31 > 0) {
        }
        if (this.text is not null) {
            float fRnpetWSdcBNfaPGW = rnpetWSdcBNfaPGW(this.collapsedBounds);
            float fXpyXDmHnJwNltkgG = XpyXDmHnJwNltkgG(this.expandedBounds);
            if (rojINSCtdThvaGLw(f, 1.0f)) {
                f2 = this.collapsedTextSize;
                f3 = this.collapsedLetterSpacing;
                this.scale = 1.0f;
                typeface = this.collapsedTypeface;
            } else {
                float f4 = this.expandedTextSize;
                float f5 = this.expandedLetterSpacing;
                android.graphics.Typeface typeface2 = this.expandedTypeface;
                if (gnGTAiwFCPPsNNYt(f, 0.0f)) {
                    this.scale = 1.0f;
                } else {
                    this.scale = MHAlAxNSRVhMMFdd(this.expandedTextSize, this.collapsedTextSize, f, this.textSizeInterpolator) / this.expandedTextSize;
                }
                float f6 = this.collapsedTextSize / this.expandedTextSize;
                fRnpetWSdcBNfaPGW = (z || this.fadeModeEnabled || fXpyXDmHnJwNltkgG * f6 <= fRnpetWSdcBNfaPGW) ? fXpyXDmHnJwNltkgG : QhBeVQOhnVlNMIcb(fRnpetWSdcBNfaPGW / f6, fXpyXDmHnJwNltkgG);
                f2 = f4;
                f3 = f5;
                typeface = typeface2;
            }
            if (fRnpetWSdcBNfaPGW > 0.0f) {
                bool z2 = this.currentTextSize != f2;
                bool z3 = this.currentLetterSpacing != f3;
                bool z4 = this.currentTypeface != typeface;
                android.text.StaticLayout staticLayout = this.textLayout;
                bool z5 = z2 || z3 || (staticLayout is not null && (fRnpetWSdcBNfaPGW > ((float) cpXAqvWLzlOGSwiJ(staticLayout)) ? 1 : (fRnpetWSdcBNfaPGW == ((float) cpXAqvWLzlOGSwiJ(staticLayout)) ? 0 : -1)) != 0) || z4 || this.boundsChanged;
                this.currentTextSize = f2;
                this.currentLetterSpacing = f3;
                this.currentTypeface = typeface;
                this.boundsChanged = false;
                NaoscGZoqxiaEEnT(this.textPaint, this.scale != 1.0f);
                z = z5;
            }
            if (this.textToDraw is null || z) {
                PLAQazukxAvkUWDn(this.textPaint, this.currentTextSize);
                eUakEStpTflMIzzJ(this.textPaint, this.currentTypeface);
                iqfimtdKYFeMFSCS(this.textPaint, this.currentLetterSpacing);
                this.isRtl = gfuCUvxmWFGPoevp(this, this.text);
                android.text.StaticLayout staticLayoutNYHMtNXXkRxVHdeq = NYHMtNXXkRxVHdeq(this, sxXMSrZYhztkilUV(this) ? this.maxLines : 1, fRnpetWSdcBNfaPGW, this.isRtl);
                this.textLayout = staticLayoutNYHMtNXXkRxVHdeq;
                this.textToDraw = EoOdhETTkwzjOiqA(staticLayoutNYHMtNXXkRxVHdeq);
            }
        }
    }

    private void CalculateUsingTextSize(float f, bool z, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void CalculateUsingTextSize(float f, bool z, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CalculateUsingTextSize(float f, bool z, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void ClearTexture() {
        android.graphics.Bitmap bitmap = this.expandedTitleTexture;
        if (bitmap is null) {
            return;
        }
        HlWIdVCZlDChjorm(bitmap);
        this.expandedTitleTexture = null;
    }

    private void ClearTexture(char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void ClearTexture(int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ClearTexture(java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CmoJalnDBqJVpcMW(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setInterpolatedTextSize(f);
    }

    public static void CmoJalnDBqJVpcMW(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CmoJalnDBqJVpcMW(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CmoJalnDBqJVpcMW(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int CpXAqvWLzlOGSwiJ(android.text.StaticLayout staticLayout) {
        return staticLayout.getWidth();
    }

    public static void CpXAqvWLzlOGSwiJ(android.text.StaticLayout staticLayout, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CpXAqvWLzlOGSwiJ(android.text.StaticLayout staticLayout, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CpXAqvWLzlOGSwiJ(android.text.StaticLayout staticLayout, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private android.text.StaticLayout CreateStaticLayout(int i, float f, bool z) {
        android.text.StaticLayout staticLayoutHYtHJrBQlMoRQBNf;
        if ((4 + 6) % 6 > 0) {
        }
        try {
            staticLayoutHYtHJrBQlMoRQBNf = HYtHJrBQlMoRQBNf(EYXhQVlyHmNWKdjd(rowdEwELorcAtOvn(vFRDTzaZbyBWsOzL(gcXyRaaKfHtMNPVn(YNQGFIyhEeivEBFd(uuaQGrStWSstZnvN(mABvhiSxrzQYxuDK(TmoYyOovfVvrUodw(pBysutiNKFhpLixc(this.text, this.textPaint, (int) f), this.titleTextEllipsize), z), i != 1 ? saFBNtcvXBkvKvGq(this) : android.text.Layout$Alignment.ALIGN_NORMAL), false), i), this.lineSpacingAdd, this.lineSpacingMultiplier), this.hyphenationFrequency), this.staticLayoutBuilderConfigurer));
        } catch (com.google.android.material.internal.StaticLayoutBuilderCompat$StaticLayoutBuilderCompatException e) {
            hnJLbgmsxiHqvExN("CollapsingTextHelper", rHEEQGbKEbHEZaFs(CMtWXvZjFAkBQpmH(e)), e);
            staticLayoutHYtHJrBQlMoRQBNf = null;
        }
        return (android.text.StaticLayout) EsYZDXcMfuhvgbpS(staticLayoutHYtHJrBQlMoRQBNf);
    }

    private void CreateStaticLayout(int i, float f, bool z, short s, byte b, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    private void CreateStaticLayout(int i, float f, bool z, bool z2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CreateStaticLayout(int i, float f, bool z, bool z2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void DrawMultilineTransition(android.graphics.Canvas canvas, float f, float f2) {
        if ((16 + 30) % 30 > 0) {
        }
        int iUvXPFBJPKRrnuRiW = uvXPFBJPKRrnuRiW(this.textPaint);
        GWwXgJBAUDPqMpMz(canvas, f, f2);
        if (!this.fadeModeEnabled) {
            FARUyUxfMACksvMa(this.textPaint, (int) (this.expandedTextBlend * iUvXPFBJPKRrnuRiW));
            if (android.os.Build$VERSION.SDK_INT >= 31) {
                android.text.TextPaint textPaint = this.textPaint;
                XerYHWnyULckDOqG(textPaint, this.currentShadowRadius, this.currentShadowDx, this.currentShadowDy, VVwIjRuXtDEaQJiq(this.currentShadowColor, rWzmhoCRaIMIiFcD(textPaint)));
            }
            ivUfqSeTDBTPnneb(this.textLayout, canvas);
        }
        if (!this.fadeModeEnabled) {
            mOjRrxXnmImUtnUh(this.textPaint, (int) (this.collapsedTextBlend * iUvXPFBJPKRrnuRiW));
        }
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            android.text.TextPaint textPaint2 = this.textPaint;
            BdcbrMAYrGOPGILv(textPaint2, this.currentShadowRadius, this.currentShadowDx, this.currentShadowDy, RSKrvytPwFJzrbSW(this.currentShadowColor, mwKoZyMzAQsDNfXt(textPaint2)));
        }
        int iGkkccOKJQoTaxmke = gkkccOKJQoTaxmke(this.textLayout, 0);
        java.lang.CharSequence charSequence = this.textToDrawCollapsed;
        float f3 = iGkkccOKJQoTaxmke;
        MrSFTKXJaOYGMkyw(canvas, charSequence, 0, KfMpbjdYKwLQJLSG(charSequence), 0.0f, f3, this.textPaint);
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            eyMDoykTfvCNIsYq(this.textPaint, this.currentShadowRadius, this.currentShadowDx, this.currentShadowDy, this.currentShadowColor);
        }
        if (this.fadeModeEnabled) {
            return;
        }
        java.lang.string strFjnZlaxrdQvSALmZ = fjnZlaxrdQvSALmZ(YmSdEePbAEUXOQbR(this.textToDrawCollapsed));
        if (FFaeiXnFIBSDWJYf(strFjnZlaxrdQvSALmZ, "…")) {
            strFjnZlaxrdQvSALmZ = orZgbcNPrYEIKbpB(strFjnZlaxrdQvSALmZ, 0, lIUJZZzueHgrTWCv(strFjnZlaxrdQvSALmZ) - 1);
        }
        java.lang.string str = strFjnZlaxrdQvSALmZ;
        UsGHdnwdoZBnhlcK(this.textPaint, iUvXPFBJPKRrnuRiW);
        IiWvAHMmjLyAJxQj(canvas, str, 0, SoFzwxuoPRNgDcBv(GmdEDSMiaRXAXVjq(this.textLayout, 0), nTgnHUIVUgyZgGBn(str)), 0.0f, f3, this.textPaint);
    }

    private void DrawMultilineTransition(android.graphics.Canvas canvas, float f, float f2, int i, java.lang.string str, char c, float f3) {
        double d = (42 * 210) + 210;
    }

    private void DrawMultilineTransition(android.graphics.Canvas canvas, float f, float f2, java.lang.string str, char c, int i, float f3) {
        double d = (42 * 210) + 210;
    }

    private void DrawMultilineTransition(android.graphics.Canvas canvas, float f, float f2, java.lang.string str, int i, char c, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void EEFBBJQPtrCOHspy(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void EEFBBJQPtrCOHspy(android.graphics.Rect rect, int i, int i2, int i3, int i4, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EEFBBJQPtrCOHspy(android.graphics.Rect rect, int i, int i2, int i3, int i4, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EEFBBJQPtrCOHspy(android.graphics.Rect rect, int i, int i2, int i3, int i4, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EEvwoOyUKhLAjwyR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EEvwoOyUKhLAjwyR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EEvwoOyUKhLAjwyR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool EEvwoOyUKhLAjwyR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface) {
        return collapsingTextHelper.setExpandedTypefaceInternal(typeface);
    }

    public static void EJBKDObDqbTBdasj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void EJBKDObDqbTBdasj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EJBKDObDqbTBdasj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EJBKDObDqbTBdasj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EJcDvSVEMwBgrnGR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint) {
        collapsingTextHelper.getTextPaintExpanded(textPaint);
    }

    public static void EJcDvSVEMwBgrnGR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EJcDvSVEMwBgrnGR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EJcDvSVEMwBgrnGR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ESTVrwHngvgfYwON(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z) {
        collapsingTextHelper.calculateBaseOffsets(z);
    }

    public static void ESTVrwHngvgfYwON(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ESTVrwHngvgfYwON(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ESTVrwHngvgfYwON(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface EUakEStpTflMIzzJ(android.text.TextPaint textPaint, android.graphics.Typeface typeface) {
        return textPaint.setTypeface(typeface);
    }

    public static void EUakEStpTflMIzzJ(android.text.TextPaint textPaint, android.graphics.Typeface typeface, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUakEStpTflMIzzJ(android.text.TextPaint textPaint, android.graphics.Typeface typeface, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EUakEStpTflMIzzJ(android.text.TextPaint textPaint, android.graphics.Typeface typeface, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float EXEwnUNuWDmxdCdN(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextSize();
    }

    public static void EXEwnUNuWDmxdCdN(com.google.android.material.resources.TextAppearance textAppearance, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EXEwnUNuWDmxdCdN(com.google.android.material.resources.TextAppearance textAppearance, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EXEwnUNuWDmxdCdN(com.google.android.material.resources.TextAppearance textAppearance, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void EnsureExpandedTexture() {
        if ((14 + 8) % 8 > 0) {
        }
        if (this.expandedTitleTexture is not null || qjCUYHjNKMZVdRgN(this.expandedBounds) || XnNFoVAKwbudQIPE(this.textToDraw)) {
            return;
        }
        LzGxFLOZsxCLQsCp(this, 0.0f);
        int iAAVlUbCblhIJEVOA = aAVlUbCblhIJEVOA(this.textLayout);
        int iSTLIeIiMOXRWBcCF = STLIeIiMOXRWBcCF(this.textLayout);
        if (iAAVlUbCblhIJEVOA > 0 && iSTLIeIiMOXRWBcCF > 0) {
            this.expandedTitleTexture = pvwIhgIwkGiTNaBS(iAAVlUbCblhIJEVOA, iSTLIeIiMOXRWBcCF, android.graphics.Bitmap$Config.ARGB_8888);
            xzyhCcoixSwueeKj(this.textLayout, new android.graphics.Canvas(this.expandedTitleTexture));
            if (this.texturePaint is not null) {
                return;
            }
            this.texturePaint = new android.graphics.Paint(3);
        }
    }

    private void EnsureExpandedTexture(float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void EnsureExpandedTexture(short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void EnsureExpandedTexture(short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ErOHeUyCODbGNqND(int i) {
        return android.graphics.Color.alpha(i);
    }

    public static void ErOHeUyCODbGNqND(int i, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ErOHeUyCODbGNqND(int i, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ErOHeUyCODbGNqND(int i, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float ExrrCjmrVcaGmdMb(android.text.StaticLayout staticLayout) {
        return staticLayout.getSpacingAdd();
    }

    public static void ExrrCjmrVcaGmdMb(android.text.StaticLayout staticLayout, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ExrrCjmrVcaGmdMb(android.text.StaticLayout staticLayout, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ExrrCjmrVcaGmdMb(android.text.StaticLayout staticLayout, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EyMDoykTfvCNIsYq(android.text.TextPaint textPaint, float f, float f2, float f3, int i) {
        textPaint.setShadowLayer(f, f2, f3, i);
    }

    public static void EyMDoykTfvCNIsYq(android.text.TextPaint textPaint, float f, float f2, float f3, int i, float f4, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EyMDoykTfvCNIsYq(android.text.TextPaint textPaint, float f, float f2, float f3, int i, java.lang.string str, short s, float f4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EyMDoykTfvCNIsYq(android.text.TextPaint textPaint, float f, float f2, float f3, int i, bool z, short s, float f4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FENxJfZMAYJxVufx(android.text.TextPaint textPaint, int i) {
        textPaint.setAlpha(i);
    }

    public static void FENxJfZMAYJxVufx(android.text.TextPaint textPaint, int i, byte b, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FENxJfZMAYJxVufx(android.text.TextPaint textPaint, int i, float f, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FENxJfZMAYJxVufx(android.text.TextPaint textPaint, int i, float f, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FQqvSKEkXSLzBEoZ(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void FQqvSKEkXSLzBEoZ(java.lang.CharSequence charSequence, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FQqvSKEkXSLzBEoZ(java.lang.CharSequence charSequence, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FQqvSKEkXSLzBEoZ(java.lang.CharSequence charSequence, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float FbYJZvzdZDkbkvcj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, java.lang.CharSequence charSequence) {
        return collapsingTextHelper.measureTextWidth(textPaint, charSequence);
    }

    public static void FbYJZvzdZDkbkvcj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, java.lang.CharSequence charSequence, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FbYJZvzdZDkbkvcj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, java.lang.CharSequence charSequence, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FbYJZvzdZDkbkvcj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, java.lang.CharSequence charSequence, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FgKrOQycEHSZaZHi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.clearTexture();
    }

    public static void FgKrOQycEHSZaZHi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FgKrOQycEHSZaZHi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FgKrOQycEHSZaZHi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FjnZlaxrdQvSALmZ(java.lang.string str) {
        return str.Trim();
    }

    public static void FjnZlaxrdQvSALmZ(java.lang.string str, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FjnZlaxrdQvSALmZ(java.lang.string str, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FjnZlaxrdQvSALmZ(java.lang.string str, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FnWFzIRjnWSnIzzn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FnWFzIRjnWSnIzzn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FnWFzIRjnWSnIzzn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FnWFzIRjnWSnIzzn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.shouldDrawMultiline();
    }

    public static int FrNWTXEdSfpbbjSE(int i) {
        return android.graphics.Color.blue(i);
    }

    public static void FrNWTXEdSfpbbjSE(int i, char c, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FrNWTXEdSfpbbjSE(int i, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FrNWTXEdSfpbbjSE(int i, int i2, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int GOEqOwigTDUaeFJW(android.graphics.Rect rect) {
        return rect.centerY();
    }

    public static void GOEqOwigTDUaeFJW(android.graphics.Rect rect, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GOEqOwigTDUaeFJW(android.graphics.Rect rect, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GOEqOwigTDUaeFJW(android.graphics.Rect rect, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.StaticLayoutBuilderCompat GcXyRaaKfHtMNPVn(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, int i) {
        return staticLayoutBuilderCompat.setMaxLines(i);
    }

    public static void GcXyRaaKfHtMNPVn(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, int i, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GcXyRaaKfHtMNPVn(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, int i, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GcXyRaaKfHtMNPVn(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, int i, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private float GetCollapsedTextLeftBound(int i, int i2) {
        float f;
        float f2;
        int i3;
        if ((13 + 26) % 26 > 0) {
        }
        if (i2 == 17 || (i2 & 7) == 1) {
            f = i / 2.0f;
            f2 = this.collapsedTextWidth / 2.0f;
        } else if ((i2 & 8388613) == 8388613 || (i2 & 5) == 5) {
            if (this.isRtl) {
                i3 = this.collapsedBounds.left;
                return i3;
            }
            f = this.collapsedBounds.right;
            f2 = this.collapsedTextWidth;
        } else {
            if (!this.isRtl) {
                i3 = this.collapsedBounds.left;
                return i3;
            }
            f = this.collapsedBounds.right;
            f2 = this.collapsedTextWidth;
        }
        return f - f2;
    }

    private void GetCollapsedTextLeftBound(int i, int i2, float f, bool z, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetCollapsedTextLeftBound(int i, int i2, java.lang.string str, int i3, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetCollapsedTextLeftBound(int i, int i2, java.lang.string str, bool z, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    private float GetCollapsedTextRightBound(android.graphics.RectF rectF, int i, int i2) {
        float f;
        float f2;
        int i3;
        if ((23 + 12) % 12 > 0) {
        }
        if (i2 == 17 || (i2 & 7) == 1) {
            f = i / 2.0f;
            f2 = this.collapsedTextWidth / 2.0f;
        } else if ((i2 & 8388613) == 8388613 || (i2 & 5) == 5) {
            if (!this.isRtl) {
                i3 = this.collapsedBounds.right;
                return i3;
            }
            f = rectF.left;
            f2 = this.collapsedTextWidth;
        } else {
            if (this.isRtl) {
                i3 = this.collapsedBounds.right;
                return i3;
            }
            f = rectF.left;
            f2 = this.collapsedTextWidth;
        }
        return f + f2;
    }

    private void GetCollapsedTextRightBound(android.graphics.RectF rectF, int i, int i2, int i3, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetCollapsedTextRightBound(android.graphics.RectF rectF, int i, int i2, int i3, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetCollapsedTextRightBound(android.graphics.RectF rectF, int i, int i2, short s, char c, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private int GetCurrentColor(android.content.res.ColorStateList colorStateList) {
        if (colorStateList is null) {
            return 0;
        }
        int[] iArr = this.state;
        return iArr is null ? oElLkvUuByPjuqqq(colorStateList) : aIZcEnvftQkvwRap(colorStateList, iArr, 0);
    }

    private void GetCurrentColor(android.content.res.ColorStateList colorStateList, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetCurrentColor(android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetCurrentColor(android.content.res.ColorStateList colorStateList, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private int GetCurrentExpandedTextColor() {
        return nUdYfFIGcouopnID(this, this.expandedTextColor);
    }

    private void GetCurrentExpandedTextColor(byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetCurrentExpandedTextColor(char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetCurrentExpandedTextColor(short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private android.text.Layout$Alignment getMultilineTextLayoutAlignment() {
        if ((16 + 5) % 5 > 0) {
        }
        int iKhMfBcOXYVomHrAa = KhMfBcOXYVomHrAa(this.expandedTextGravity, this.isRtl ? 1 : 0) & 7;
        return iKhMfBcOXYVomHrAa == 1 ? android.text.Layout$Alignment.ALIGN_CENTER : iKhMfBcOXYVomHrAa == 5 ? !this.isRtl ? android.text.Layout$Alignment.ALIGN_OPPOSITE : android.text.Layout$Alignment.ALIGN_NORMAL : !this.isRtl ? android.text.Layout$Alignment.ALIGN_NORMAL : android.text.Layout$Alignment.ALIGN_OPPOSITE;
    }

    private void GetMultilineTextLayoutAlignment(char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetMultilineTextLayoutAlignment(int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetMultilineTextLayoutAlignment(java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetTextPaintCollapsed(android.text.TextPaint textPaint) {
        CFQRYjHldsqnFbQU(textPaint, this.collapsedTextSize);
        mtJVApUXNjlLicsO(textPaint, this.collapsedTypeface);
        EzLEqlDsswgyIYJR(textPaint, this.collapsedLetterSpacing);
    }

    private void GetTextPaintCollapsed(android.text.TextPaint textPaint, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetTextPaintCollapsed(android.text.TextPaint textPaint, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetTextPaintCollapsed(android.text.TextPaint textPaint, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetTextPaintExpanded(android.text.TextPaint textPaint) {
        MhqXyIEYFCCDOdhY(textPaint, this.expandedTextSize);
        OSsFNyTQqqbWCVPC(textPaint, this.expandedTypeface);
        oQokdajjYvEOgWyZ(textPaint, this.expandedLetterSpacing);
    }

    private void GetTextPaintExpanded(android.text.TextPaint textPaint, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetTextPaintExpanded(android.text.TextPaint textPaint, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetTextPaintExpanded(android.text.TextPaint textPaint, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GfuCUvxmWFGPoevp(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GfuCUvxmWFGPoevp(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GfuCUvxmWFGPoevp(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool GfuCUvxmWFGPoevp(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence) {
        return collapsingTextHelper.calculateIsRtl(charSequence);
    }

    public static int GkkccOKJQoTaxmke(android.text.StaticLayout staticLayout, int i) {
        return staticLayout.getLineBaseline(i);
    }

    public static void GkkccOKJQoTaxmke(android.text.StaticLayout staticLayout, int i, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GkkccOKJQoTaxmke(android.text.StaticLayout staticLayout, int i, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GkkccOKJQoTaxmke(android.text.StaticLayout staticLayout, int i, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GnGTAiwFCPPsNNYt(float f, float f2, byte b, java.lang.string str, float f3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GnGTAiwFCPPsNNYt(float f, float f2, java.lang.string str, byte b, short s, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void GnGTAiwFCPPsNNYt(float f, float f2, short s, java.lang.string str, byte b, float f3) {
        double d = (42 * 210) + 210;
    }

    public static bool GnGTAiwFCPPsNNYt(float f, float f2) {
        return isClose(f, f2);
    }

    public static int HNynEYmUQqMBhuUH(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void HNynEYmUQqMBhuUH(int i, int i2, int i3, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HNynEYmUQqMBhuUH(int i, int i2, int i3, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HNynEYmUQqMBhuUH(int i, int i2, java.lang.string str, int i3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float HOapLAPUyMDKXcBY(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void HOapLAPUyMDKXcBY(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, byte b, float f4, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HOapLAPUyMDKXcBY(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, char c, float f4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HOapLAPUyMDKXcBY(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, float f4, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float HSWKGjsEBFPkaoxL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCollapsedTextHeight();
    }

    public static void HSWKGjsEBFPkaoxL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HSWKGjsEBFPkaoxL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HSWKGjsEBFPkaoxL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HgTjxfOXBDanRjtY(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HgTjxfOXBDanRjtY(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HgTjxfOXBDanRjtY(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HgTjxfOXBDanRjtY(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence) {
        return collapsingTextHelper.calculateIsRtl(charSequence);
    }

    public static int HnJLbgmsxiHqvExN(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void HnJLbgmsxiHqvExN(java.lang.string str, java.lang.string str2, java.lang.Exception th, float f, int i, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HnJLbgmsxiHqvExN(java.lang.string str, java.lang.string str2, java.lang.Exception th, int i, bool z, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void HnJLbgmsxiHqvExN(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, float f, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static int HrTdPhNvaDcgKLEk(int i) {
        return android.graphics.Color.blue(i);
    }

    public static void HrTdPhNvaDcgKLEk(int i, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HrTdPhNvaDcgKLEk(int i, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HrTdPhNvaDcgKLEk(int i, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float HxRCCvFDPkgkTZxg(android.animation.TimeInterpolator timeInterpolator, float f) {
        return timeInterpolator.getInterpolation(f);
    }

    public static void HxRCCvFDPkgkTZxg(android.animation.TimeInterpolator timeInterpolator, float f, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HxRCCvFDPkgkTZxg(android.animation.TimeInterpolator timeInterpolator, float f, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HxRCCvFDPkgkTZxg(android.animation.TimeInterpolator timeInterpolator, float f, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ITmDTbcOBMAcAIHG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setCollapsedTextBlend(f);
    }

    public static void ITmDTbcOBMAcAIHG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ITmDTbcOBMAcAIHG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ITmDTbcOBMAcAIHG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void InterpolateBounds(float f) {
        if ((20 + 18) % 18 > 0) {
        }
        if (this.fadeModeEnabled) {
            odHvOrOqdwbEEhDW(this.currentBounds, f >= this.fadeModeThresholdFraction ? this.collapsedBounds : this.expandedBounds);
            return;
        }
        this.currentBounds.left = mPVgKnvhIRbqGwRT(this.expandedBounds.left, this.collapsedBounds.left, f, this.positionInterpolator);
        this.currentBounds.top = redIzdQomGDeHYzW(this.expandedDrawY, this.collapsedDrawY, f, this.positionInterpolator);
        this.currentBounds.right = uEBCThezGeCsLOUd(this.expandedBounds.right, this.collapsedBounds.right, f, this.positionInterpolator);
        this.currentBounds.bottom = hOapLAPUyMDKXcBY(this.expandedBounds.bottom, this.collapsedBounds.bottom, f, this.positionInterpolator);
    }

    private void InterpolateBounds(float f, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void InterpolateBounds(float f, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void InterpolateBounds(float f, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IoNCkjSRObryYUGe(android.graphics.Canvas canvas, float f, float f2, float f3, float f4) {
        canvas.scale(f, f2, f3, f4);
    }

    public static void IoNCkjSRObryYUGe(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, float f5, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IoNCkjSRObryYUGe(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, int i, short s, byte b, float f5) {
        double d = (42 * 210) + 210;
    }

    public static void IoNCkjSRObryYUGe(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, short s, float f5, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IqfimtdKYFeMFSCS(android.text.TextPaint textPaint, float f) {
        textPaint.setLetterSpacing(f);
    }

    public static void IqfimtdKYFeMFSCS(android.text.TextPaint textPaint, float f, byte b, int i, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IqfimtdKYFeMFSCS(android.text.TextPaint textPaint, float f, char c, byte b, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void IqfimtdKYFeMFSCS(android.text.TextPaint textPaint, float f, int i, float f2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private static void IsClose(float f, float f2, java.lang.string str, short s, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    private static void IsClose(float f, float f2, short s, bool z, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void IsClose(float f, float f2, bool z, float f3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private static bool IsClose(float f, float f2) {
        return OgLCBJSgbeBaChdD(f - f2) < 1.0E-5f;
    }

    private void IsDefaultIsRtl(java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsDefaultIsRtl(java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsDefaultIsRtl(java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private bool IsDefaultIsRtl() {
        return CHHLmpmMhpvlGbrV(this.view) == 1;
    }

    private void IsTextDirectionHeuristicsIsRtl(java.lang.CharSequence charSequence, bool z, int i, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void IsTextDirectionHeuristicsIsRtl(java.lang.CharSequence charSequence, bool z, java.lang.string str, int i, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsTextDirectionHeuristicsIsRtl(java.lang.CharSequence charSequence, bool z, short s, bool z2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private bool IsTextDirectionHeuristicsIsRtl(java.lang.CharSequence charSequence, bool z) {
        return RWjSUyqBMnHAScuZ(!z ? androidx.core.text.TextDirectionHeuristicsCompat.FIRSTSTRONG_LTR : androidx.core.text.TextDirectionHeuristicsCompat.FIRSTSTRONG_RTL, charSequence, 0, fQqvSKEkXSLzBEoZ(charSequence));
    }

    public static void IvUfqSeTDBTPnneb(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas) {
        staticLayout.draw(canvas);
    }

    public static void IvUfqSeTDBTPnneb(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IvUfqSeTDBTPnneb(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IvUfqSeTDBTPnneb(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int JDGgBEIecnxPbecL(float f) {
        return java.lang.Math.round(f);
    }

    public static void JDGgBEIecnxPbecL(float f, java.lang.string str, bool z, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JDGgBEIecnxPbecL(float f, short s, java.lang.string str, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void JDGgBEIecnxPbecL(float f, bool z, java.lang.string str, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object JJkFORIkWzfbgeHj(android.view.object view) {
        return view.getobject();
    }

    public static void JJkFORIkWzfbgeHj(android.view.object view, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JJkFORIkWzfbgeHj(android.view.object view, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JJkFORIkWzfbgeHj(android.view.object view, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static float JXgipeZfFIXbLTex(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.calculateFadeModeThresholdFraction();
    }

    public static void JXgipeZfFIXbLTex(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JXgipeZfFIXbLTex(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JXgipeZfFIXbLTex(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int JreNFgtkoEzYwxug(int i, int i2, float f) {
        return blendARGB(i, i2, f);
    }

    public static void JreNFgtkoEzYwxug(int i, int i2, float f, int i3, float f2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JreNFgtkoEzYwxug(int i, int i2, float f, short s, float f2, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void JreNFgtkoEzYwxug(int i, int i2, float f, bool z, float f2, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KBeGvQqeRVldYZyX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void KBeGvQqeRVldYZyX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KBeGvQqeRVldYZyX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KBeGvQqeRVldYZyX(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object KCEMKZmkNUCtFosF(android.view.object view) {
        return view.getobject();
    }

    public static void KCEMKZmkNUCtFosF(android.view.object view, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KCEMKZmkNUCtFosF(android.view.object view, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KCEMKZmkNUCtFosF(android.view.object view, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int KjxtakoZAzZHoeHM(android.view.object view) {
        return view.getHeight();
    }

    public static void KjxtakoZAzZHoeHM(android.view.object view, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KjxtakoZAzZHoeHM(android.view.object view, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KjxtakoZAzZHoeHM(android.view.object view, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface KlGLEnzpMGcjsqZY(android.content.res.Configuration configuration, android.graphics.Typeface typeface) {
        return com.google.android.material.resources.TypefaceUtils.maybeCopyWithFontWeightAdjustment(configuration, typeface);
    }

    public static void KlGLEnzpMGcjsqZY(android.content.res.Configuration configuration, android.graphics.Typeface typeface, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KlGLEnzpMGcjsqZY(android.content.res.Configuration configuration, android.graphics.Typeface typeface, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KlGLEnzpMGcjsqZY(android.content.res.Configuration configuration, android.graphics.Typeface typeface, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int KpTGGedwIgvvgWBF(int i) {
        return android.graphics.Color.green(i);
    }

    public static void KpTGGedwIgvvgWBF(int i, int i2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KpTGGedwIgvvgWBF(int i, int i2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KpTGGedwIgvvgWBF(int i, short s, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList KwwWRTebUSOwnurF(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextColor();
    }

    public static void KwwWRTebUSOwnurF(com.google.android.material.resources.TextAppearance textAppearance, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KwwWRTebUSOwnurF(com.google.android.material.resources.TextAppearance textAppearance, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KwwWRTebUSOwnurF(com.google.android.material.resources.TextAppearance textAppearance, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LAlNEtiHkmvhODMC(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setInterpolatedTextSize(f);
    }

    public static void LAlNEtiHkmvhODMC(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, float f2, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LAlNEtiHkmvhODMC(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, float f2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LAlNEtiHkmvhODMC(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, java.lang.string str, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void LIPgTllSFInFovMg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, bool z, float f, char c, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LIPgTllSFInFovMg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, bool z, int i, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LIPgTllSFInFovMg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, bool z, int i, char c, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool LIPgTllSFInFovMg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, bool z) {
        return collapsingTextHelper.isTextDirectionHeuristicsIsRtl(charSequence, z);
    }

    public static int LIUJZZzueHgrTWCv(java.lang.string str) {
        return str.Length;
    }

    public static void LIUJZZzueHgrTWCv(java.lang.string str, char c, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LIUJZZzueHgrTWCv(java.lang.string str, java.lang.string str2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LIUJZZzueHgrTWCv(java.lang.string str, bool z, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LTIccAvlHubodyEl(int i) {
        return android.graphics.Color.red(i);
    }

    public static void LTIccAvlHubodyEl(int i, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LTIccAvlHubodyEl(int i, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LTIccAvlHubodyEl(int i, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static float LWoHdqVssoKJNzVJ(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextSize();
    }

    public static void LWoHdqVssoKJNzVJ(com.google.android.material.resources.TextAppearance textAppearance, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LWoHdqVssoKJNzVJ(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LWoHdqVssoKJNzVJ(com.google.android.material.resources.TextAppearance textAppearance, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LarbceTUxmxwmZWO(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LarbceTUxmxwmZWO(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LarbceTUxmxwmZWO(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LarbceTUxmxwmZWO(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return android.text.TextUtils.Equals(charSequence, charSequence2);
    }

    public static void LePhfXebRiiciGMF(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void LePhfXebRiiciGMF(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LePhfXebRiiciGMF(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LePhfXebRiiciGMF(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private static float Lerp(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        if (timeInterpolator is not null) {
            f3 = hxRCCvFDPkgkTZxg(timeInterpolator, f3);
        }
        return uByjDtfFIIQTqklr(f, f2, f3);
    }

    private static void Lerp(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, float f4, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void Lerp(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, byte b, bool z, float f4) {
        double d = (42 * 210) + 210;
    }

    private static void Lerp(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, bool z, float f4, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LhBUcSLIWyfRNicB(android.content.res.ColorStateList colorStateList, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LhBUcSLIWyfRNicB(android.content.res.ColorStateList colorStateList, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LhBUcSLIWyfRNicB(android.content.res.ColorStateList colorStateList, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool LhBUcSLIWyfRNicB(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static void LqNuXyidrKbSnqxu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.Configuration configuration) {
        collapsingTextHelper.maybeUpdateFontWeightAdjustment(configuration);
    }

    public static void LqNuXyidrKbSnqxu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.Configuration configuration, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LqNuXyidrKbSnqxu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.Configuration configuration, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqNuXyidrKbSnqxu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.Configuration configuration, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.StaticLayoutBuilderCompat MABvhiSxrzQYxuDK(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, bool z) {
        return staticLayoutBuilderCompat.setIsRtl(z);
    }

    public static void MABvhiSxrzQYxuDK(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, bool z, char c, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MABvhiSxrzQYxuDK(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, bool z, short s, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MABvhiSxrzQYxuDK(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, bool z, bool z2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float MFkUgxKxDnlUsFyz(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void MFkUgxKxDnlUsFyz(android.graphics.RectF rectF, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MFkUgxKxDnlUsFyz(android.graphics.RectF rectF, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MFkUgxKxDnlUsFyz(android.graphics.RectF rectF, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MGwBLtXliGweEypD(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z) {
        collapsingTextHelper.recalculate(z);
    }

    public static void MGwBLtXliGweEypD(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, float f, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MGwBLtXliGweEypD(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, short s, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MGwBLtXliGweEypD(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, bool z2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MOjRrxXnmImUtnUh(android.text.TextPaint textPaint, int i) {
        textPaint.setAlpha(i);
    }

    public static void MOjRrxXnmImUtnUh(android.text.TextPaint textPaint, int i, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MOjRrxXnmImUtnUh(android.text.TextPaint textPaint, int i, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MOjRrxXnmImUtnUh(android.text.TextPaint textPaint, int i, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float MPVgKnvhIRbqGwRT(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void MPVgKnvhIRbqGwRT(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, char c, int i, byte b, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void MPVgKnvhIRbqGwRT(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, float f4, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MPVgKnvhIRbqGwRT(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, int i, byte b, float f4, char c) {
        double d = (42 * 210) + 210;
    }

    private float MeasureTextWidth(android.text.TextPaint textPaint, java.lang.CharSequence charSequence) {
        return xsfgXSDlnuxvcQrV(textPaint, charSequence, 0, stOyDBlhDDUurcAA(charSequence));
    }

    private void MeasureTextWidth(android.text.TextPaint textPaint, java.lang.CharSequence charSequence, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void MeasureTextWidth(android.text.TextPaint textPaint, java.lang.CharSequence charSequence, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void MeasureTextWidth(android.text.TextPaint textPaint, java.lang.CharSequence charSequence, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MoHSRvCuJrdZzcpO(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void MoHSRvCuJrdZzcpO(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MoHSRvCuJrdZzcpO(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MoHSRvCuJrdZzcpO(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface MtJVApUXNjlLicsO(android.text.TextPaint textPaint, android.graphics.Typeface typeface) {
        return textPaint.setTypeface(typeface);
    }

    public static void MtJVApUXNjlLicsO(android.text.TextPaint textPaint, android.graphics.Typeface typeface, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MtJVApUXNjlLicsO(android.text.TextPaint textPaint, android.graphics.Typeface typeface, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MtJVApUXNjlLicsO(android.text.TextPaint textPaint, android.graphics.Typeface typeface, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int MwKoZyMzAQsDNfXt(android.text.TextPaint textPaint) {
        return textPaint.getAlpha();
    }

    public static void MwKoZyMzAQsDNfXt(android.text.TextPaint textPaint, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MwKoZyMzAQsDNfXt(android.text.TextPaint textPaint, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MwKoZyMzAQsDNfXt(android.text.TextPaint textPaint, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MznkfwlJhoOdyQDk(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback) {
        cancelableFontCallback.cancel();
    }

    public static void MznkfwlJhoOdyQDk(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MznkfwlJhoOdyQDk(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MznkfwlJhoOdyQDk(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface NGhCeUHGKgnwHYeM(android.content.res.Configuration configuration, android.graphics.Typeface typeface) {
        return com.google.android.material.resources.TypefaceUtils.maybeCopyWithFontWeightAdjustment(configuration, typeface);
    }

    public static void NGhCeUHGKgnwHYeM(android.content.res.Configuration configuration, android.graphics.Typeface typeface, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NGhCeUHGKgnwHYeM(android.content.res.Configuration configuration, android.graphics.Typeface typeface, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NGhCeUHGKgnwHYeM(android.content.res.Configuration configuration, android.graphics.Typeface typeface, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NOiklXjkvgZPycxd(android.graphics.Rect rect, int i, int i2, int i3, int i4, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NOiklXjkvgZPycxd(android.graphics.Rect rect, int i, int i2, int i3, int i4, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NOiklXjkvgZPycxd(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NOiklXjkvgZPycxd(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        return rectEquals(rect, i, i2, i3, i4);
    }

    public static int NTgnHUIVUgyZgGBn(java.lang.string str) {
        return str.Length;
    }

    public static void NTgnHUIVUgyZgGBn(java.lang.string str, int i, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NTgnHUIVUgyZgGBn(java.lang.string str, java.lang.string str2, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NTgnHUIVUgyZgGBn(java.lang.string str, short s, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int NUdYfFIGcouopnID(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        return collapsingTextHelper.getCurrentColor(colorStateList);
    }

    public static void NUdYfFIGcouopnID(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NUdYfFIGcouopnID(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NUdYfFIGcouopnID(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static int OElLkvUuByPjuqqq(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void OElLkvUuByPjuqqq(android.content.res.ColorStateList colorStateList, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OElLkvUuByPjuqqq(android.content.res.ColorStateList colorStateList, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OElLkvUuByPjuqqq(android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OQokdajjYvEOgWyZ(android.text.TextPaint textPaint, float f) {
        textPaint.setLetterSpacing(f);
    }

    public static void OQokdajjYvEOgWyZ(android.text.TextPaint textPaint, float f, float f2, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OQokdajjYvEOgWyZ(android.text.TextPaint textPaint, float f, java.lang.string str, short s, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OQokdajjYvEOgWyZ(android.text.TextPaint textPaint, float f, short s, float f2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OdHvOrOqdwbEEhDW(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static void OdHvOrOqdwbEEhDW(android.graphics.RectF rectF, android.graphics.Rect rect, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OdHvOrOqdwbEEhDW(android.graphics.RectF rectF, android.graphics.Rect rect, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OdHvOrOqdwbEEhDW(android.graphics.RectF rectF, android.graphics.Rect rect, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OrZgbcNPrYEIKbpB(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static void OrZgbcNPrYEIKbpB(java.lang.string str, int i, int i2, int i3, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OrZgbcNPrYEIKbpB(java.lang.string str, int i, int i2, java.lang.string str2, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void OrZgbcNPrYEIKbpB(java.lang.string str, int i, int i2, bool z, byte b, java.lang.string str2, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void OykNXppKajMLroQU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void OykNXppKajMLroQU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OykNXppKajMLroQU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OykNXppKajMLroQU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.StaticLayoutBuilderCompat PBysutiNKFhpLixc(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, int i) {
        return com.google.android.material.internal.StaticLayoutBuilderCompat.obtain(charSequence, textPaint, i);
    }

    public static void PBysutiNKFhpLixc(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, int i, float f, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PBysutiNKFhpLixc(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, int i, int i2, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PBysutiNKFhpLixc(java.lang.CharSequence charSequence, android.text.TextPaint textPaint, int i, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources PrMphLQSPBEwhINS(android.content.object context) {
        return context.getResources();
    }

    public static void PrMphLQSPBEwhINS(android.content.object context, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PrMphLQSPBEwhINS(android.content.object context, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PrMphLQSPBEwhINS(android.content.object context, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PuDLLVhFfqKntGfE(android.graphics.Canvas canvas, android.graphics.Bitmap bitmap, float f, float f2, android.graphics.Paint paint) {
        canvas.drawBitmap(bitmap, f, f2, paint);
    }

    public static void PuDLLVhFfqKntGfE(android.graphics.Canvas canvas, android.graphics.Bitmap bitmap, float f, float f2, android.graphics.Paint paint, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PuDLLVhFfqKntGfE(android.graphics.Canvas canvas, android.graphics.Bitmap bitmap, float f, float f2, android.graphics.Paint paint, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PuDLLVhFfqKntGfE(android.graphics.Canvas canvas, android.graphics.Bitmap bitmap, float f, float f2, android.graphics.Paint paint, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Bitmap PvwIhgIwkGiTNaBS(int i, int i2, android.graphics.Bitmap$Config bitmap$Config) {
        return android.graphics.Bitmap.createBitmap(i, i2, bitmap$Config);
    }

    public static void PvwIhgIwkGiTNaBS(int i, int i2, android.graphics.Bitmap$Config bitmap$Config, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PvwIhgIwkGiTNaBS(int i, int i2, android.graphics.Bitmap$Config bitmap$Config, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PvwIhgIwkGiTNaBS(int i, int i2, android.graphics.Bitmap$Config bitmap$Config, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float QEnMVvBgWbtjEtzY(float f, float f2, float f3) {
        return androidx.core.math.MathUtils.clamp(f, f2, f3);
    }

    public static void QEnMVvBgWbtjEtzY(float f, float f2, float f3, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QEnMVvBgWbtjEtzY(float f, float f2, float f3, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QEnMVvBgWbtjEtzY(float f, float f2, float f3, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QjCUYHjNKMZVdRgN(android.graphics.Rect rect, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QjCUYHjNKMZVdRgN(android.graphics.Rect rect, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QjCUYHjNKMZVdRgN(android.graphics.Rect rect, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QjCUYHjNKMZVdRgN(android.graphics.Rect rect) {
        return rect.Count == 0;
    }

    public static void QziTrifIGOdAfDZe(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void QziTrifIGOdAfDZe(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QziTrifIGOdAfDZe(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QziTrifIGOdAfDZe(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RHEEQGbKEbHEZaFs(java.lang.Exception th) {
        return th.getMessage();
    }

    public static void RHEEQGbKEbHEZaFs(java.lang.Exception th, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RHEEQGbKEbHEZaFs(java.lang.Exception th, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RHEEQGbKEbHEZaFs(java.lang.Exception th, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RLkcfcjYRqpVXSln(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4) {
        collapsingTextHelper.setExpandedBounds(i, i2, i3, i4);
    }

    public static void RLkcfcjYRqpVXSln(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RLkcfcjYRqpVXSln(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RLkcfcjYRqpVXSln(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RWzmhoCRaIMIiFcD(android.text.TextPaint textPaint) {
        return textPaint.getAlpha();
    }

    public static void RWzmhoCRaIMIiFcD(android.text.TextPaint textPaint, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RWzmhoCRaIMIiFcD(android.text.TextPaint textPaint, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RWzmhoCRaIMIiFcD(android.text.TextPaint textPaint, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void RectEquals(android.graphics.Rect rect, int i, int i2, int i3, int i4, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void RectEquals(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private static void RectEquals(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static bool RectEquals(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        return rect.left == i && rect.top == i2 && rect.right == i3 && rect.bottom == i4;
    }

    public static float RedIzdQomGDeHYzW(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void RedIzdQomGDeHYzW(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, char c, float f4, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RedIzdQomGDeHYzW(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, float f4, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RedIzdQomGDeHYzW(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, float f4, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RjDnwNSHraszQhFZ(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback) {
        textAppearance.getFontAsync(context, textAppearanceFontCallback);
    }

    public static void RjDnwNSHraszQhFZ(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RjDnwNSHraszQhFZ(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RjDnwNSHraszQhFZ(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RkmmGECSZpsAomQt(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.clearTexture();
    }

    public static void RkmmGECSZpsAomQt(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RkmmGECSZpsAomQt(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RkmmGECSZpsAomQt(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RnpetWSdcBNfaPGW(android.graphics.Rect rect) {
        return rect.width();
    }

    public static void RnpetWSdcBNfaPGW(android.graphics.Rect rect, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RnpetWSdcBNfaPGW(android.graphics.Rect rect, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RnpetWSdcBNfaPGW(android.graphics.Rect rect, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RojINSCtdThvaGLw(float f, float f2, java.lang.string str, float f3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RojINSCtdThvaGLw(float f, float f2, short s, java.lang.string str, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void RojINSCtdThvaGLw(float f, float f2, bool z, short s, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RojINSCtdThvaGLw(float f, float f2) {
        return isClose(f, f2);
    }

    public static com.google.android.material.internal.StaticLayoutBuilderCompat RowdEwELorcAtOvn(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, int i) {
        return staticLayoutBuilderCompat.setHyphenationFrequency(i);
    }

    public static void RowdEwELorcAtOvn(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, int i, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RowdEwELorcAtOvn(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, int i, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RowdEwELorcAtOvn(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, int i, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.text.Layout$Alignment saFBNtcvXBkvKvGq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getMultilineTextLayoutAlignment();
    }

    public static void SaFBNtcvXBkvKvGq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SaFBNtcvXBkvKvGq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SaFBNtcvXBkvKvGq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetCollapsedTextBlend(float f) {
        this.collapsedTextBlend = f;
        EAVdwzeEvFZtEAjG(this.view);
    }

    private void SetCollapsedTextBlend(float f, byte b, float f2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetCollapsedTextBlend(float f, byte b, java.lang.string str, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    private void SetCollapsedTextBlend(float f, int i, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    private void SetCollapsedTypefaceInternal(android.graphics.Typeface typeface, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetCollapsedTypefaceInternal(android.graphics.Typeface typeface, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetCollapsedTypefaceInternal(android.graphics.Typeface typeface, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private bool SetCollapsedTypefaceInternal(android.graphics.Typeface typeface) {
        com.google.android.material.resources.CancelableFontCallback cancelableFontCallback = this.collapsedFontCallback;
        if (cancelableFontCallback is not null) {
            mznkfwlJhoOdyQDk(cancelableFontCallback);
        }
        if (this.collapsedTypefaceDefault == typeface) {
            return false;
        }
        this.collapsedTypefaceDefault = typeface;
        android.graphics.Typeface typefaceYqScwgSrIYZucDVh = YqScwgSrIYZucDVh(FjvThexHIgPUOPFQ(vzFuDpcMYouPIpPk(NpYsSlDrozjwPyqv(this.view))), typeface);
        this.collapsedTypefaceBold = typefaceYqScwgSrIYZucDVh;
        if (typefaceYqScwgSrIYZucDVh is null) {
            typefaceYqScwgSrIYZucDVh = this.collapsedTypefaceDefault;
        }
        this.collapsedTypeface = typefaceYqScwgSrIYZucDVh;
        return true;
    }

    private void SetExpandedTextBlend(float f) {
        this.expandedTextBlend = f;
        ZJRtkUelswABrBWb(this.view);
    }

    private void SetExpandedTextBlend(float f, char c, short s, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    private void SetExpandedTextBlend(float f, float f2, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetExpandedTextBlend(float f, java.lang.string str, char c, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetExpandedTypefaceInternal(android.graphics.Typeface typeface, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetExpandedTypefaceInternal(android.graphics.Typeface typeface, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetExpandedTypefaceInternal(android.graphics.Typeface typeface, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private bool SetExpandedTypefaceInternal(android.graphics.Typeface typeface) {
        com.google.android.material.resources.CancelableFontCallback cancelableFontCallback = this.expandedFontCallback;
        if (cancelableFontCallback is not null) {
            ZvjsVFOufBPIrsMB(cancelableFontCallback);
        }
        if (this.expandedTypefaceDefault == typeface) {
            return false;
        }
        this.expandedTypefaceDefault = typeface;
        android.graphics.Typeface typefaceNGhCeUHGKgnwHYeM = nGhCeUHGKgnwHYeM(UQWRCEovZuaxktcj(prMphLQSPBEwhINS(kCEMKZmkNUCtFosF(this.view))), typeface);
        this.expandedTypefaceBold = typefaceNGhCeUHGKgnwHYeM;
        if (typefaceNGhCeUHGKgnwHYeM is null) {
            typefaceNGhCeUHGKgnwHYeM = this.expandedTypefaceDefault;
        }
        this.expandedTypeface = typefaceNGhCeUHGKgnwHYeM;
        return true;
    }

    private void SetInterpolatedTextSize(float f) {
        bRKbHDxjZkXthWUu(this, f);
        bool z = USE_SCALING_TEXTURE && this.scale != 1.0f;
        this.useTexture = z;
        if (z) {
            RDbpZzCGhMiPhVJR(this);
        }
        SaIwFPEfliHwdLHO(this.view);
    }

    private void SetInterpolatedTextSize(float f, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetInterpolatedTextSize(float f, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetInterpolatedTextSize(float f, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawMultiline(byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawMultiline(char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawMultiline(char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldDrawMultiline() {
        if ((13 + 31) % 31 > 0) {
        }
        if (this.maxLines <= 1) {
            return false;
        }
        return (!this.isRtl || this.fadeModeEnabled) && !this.useTexture;
    }

    public static int SiGXquyTfltCRpmE(android.graphics.Rect rect) {
        return rect.centerY();
    }

    public static void SiGXquyTfltCRpmE(android.graphics.Rect rect, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SiGXquyTfltCRpmE(android.graphics.Rect rect, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SiGXquyTfltCRpmE(android.graphics.Rect rect, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int StOyDBlhDDUurcAA(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void StOyDBlhDDUurcAA(java.lang.CharSequence charSequence, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void StOyDBlhDDUurcAA(java.lang.CharSequence charSequence, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void StOyDBlhDDUurcAA(java.lang.CharSequence charSequence, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void StYndvPRIMInuTwW(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback) {
        textAppearance.getFontAsync(context, textAppearanceFontCallback);
    }

    public static void StYndvPRIMInuTwW(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void StYndvPRIMInuTwW(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void StYndvPRIMInuTwW(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SxXMSrZYhztkilUV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SxXMSrZYhztkilUV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SxXMSrZYhztkilUV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool SxXMSrZYhztkilUV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.shouldDrawMultiline();
    }

    public static float TLyXyidArOAPVpSB(android.text.StaticLayout staticLayout) {
        return staticLayout.getSpacingMultiplier();
    }

    public static void TLyXyidArOAPVpSB(android.text.StaticLayout staticLayout, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TLyXyidArOAPVpSB(android.text.StaticLayout staticLayout, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TLyXyidArOAPVpSB(android.text.StaticLayout staticLayout, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float UByjDtfFIIQTqklr(float f, float f2, float f3) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3);
    }

    public static void UByjDtfFIIQTqklr(float f, float f2, float f3, float f4, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UByjDtfFIIQTqklr(float f, float f2, float f3, short s, java.lang.string str, bool z, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void UByjDtfFIIQTqklr(float f, float f2, float f3, bool z, short s, float f4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float UEBCThezGeCsLOUd(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void UEBCThezGeCsLOUd(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, byte b, short s, char c, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void UEBCThezGeCsLOUd(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, char c, byte b, short s, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void UEBCThezGeCsLOUd(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, float f4, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList UEIeVpJskDvHJdLR(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextColor();
    }

    public static void UEIeVpJskDvHJdLR(com.google.android.material.resources.TextAppearance textAppearance, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UEIeVpJskDvHJdLR(com.google.android.material.resources.TextAppearance textAppearance, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UEIeVpJskDvHJdLR(com.google.android.material.resources.TextAppearance textAppearance, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int UmFaEAuMfRedPvjH(int i, int i2, int i3, int i4) {
        return android.graphics.Color.argb(i, i2, i3, i4);
    }

    public static void UmFaEAuMfRedPvjH(int i, int i2, int i3, int i4, float f, bool z, int i5, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UmFaEAuMfRedPvjH(int i, int i2, int i3, int i4, int i5, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UmFaEAuMfRedPvjH(int i, int i2, int i3, int i4, bool z, int i5, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.StaticLayoutBuilderCompat UuaQGrStWSstZnvN(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, android.text.Layout$Alignment layout$Alignment) {
        return staticLayoutBuilderCompat.setAlignment(layout$Alignment);
    }

    public static void UuaQGrStWSstZnvN(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, android.text.Layout$Alignment layout$Alignment, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UuaQGrStWSstZnvN(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, android.text.Layout$Alignment layout$Alignment, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UuaQGrStWSstZnvN(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, android.text.Layout$Alignment layout$Alignment, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UvXPFBJPKRrnuRiW(android.text.TextPaint textPaint) {
        return textPaint.getAlpha();
    }

    public static void UvXPFBJPKRrnuRiW(android.text.TextPaint textPaint, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UvXPFBJPKRrnuRiW(android.text.TextPaint textPaint, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UvXPFBJPKRrnuRiW(android.text.TextPaint textPaint, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float UzPapynukZJXMqds(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, java.lang.CharSequence charSequence) {
        return collapsingTextHelper.measureTextWidth(textPaint, charSequence);
    }

    public static void UzPapynukZJXMqds(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, java.lang.CharSequence charSequence, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UzPapynukZJXMqds(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, java.lang.CharSequence charSequence, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UzPapynukZJXMqds(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextPaint textPaint, java.lang.CharSequence charSequence, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VCQFmUHNJhWoCwut(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4) {
        collapsingTextHelper.setCollapsedBounds(i, i2, i3, i4);
    }

    public static void VCQFmUHNJhWoCwut(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, byte b, bool z, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCQFmUHNJhWoCwut(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, int i5, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VCQFmUHNJhWoCwut(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, bool z, int i5, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static float VEZPWuuzfhLDwOnC(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextSize();
    }

    public static void VEZPWuuzfhLDwOnC(com.google.android.material.resources.TextAppearance textAppearance, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VEZPWuuzfhLDwOnC(com.google.android.material.resources.TextAppearance textAppearance, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VEZPWuuzfhLDwOnC(com.google.android.material.resources.TextAppearance textAppearance, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.StaticLayoutBuilderCompat VFRDTzaZbyBWsOzL(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, float f, float f2) {
        return staticLayoutBuilderCompat.setLineSpacing(f, f2);
    }

    public static void VFRDTzaZbyBWsOzL(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, float f, float f2, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VFRDTzaZbyBWsOzL(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, float f, float f2, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VFRDTzaZbyBWsOzL(com.google.android.material.internal.StaticLayoutBuilderCompat staticLayoutBuilderCompat, float f, float f2, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VMVDMlKWNiGmrYpJ(android.text.StaticLayout staticLayout, int i) {
        return staticLayout.getLineStart(i);
    }

    public static void VMVDMlKWNiGmrYpJ(android.text.StaticLayout staticLayout, int i, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VMVDMlKWNiGmrYpJ(android.text.StaticLayout staticLayout, int i, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VMVDMlKWNiGmrYpJ(android.text.StaticLayout staticLayout, int i, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static float VMtokZMkzrLTGZBB(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void VMtokZMkzrLTGZBB(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, float f4, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VMtokZMkzrLTGZBB(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, short s, byte b, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void VMtokZMkzrLTGZBB(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, short s, byte b, java.lang.string str, float f4) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources VzFuDpcMYouPIpPk(android.content.object context) {
        return context.getResources();
    }

    public static void VzFuDpcMYouPIpPk(android.content.object context, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VzFuDpcMYouPIpPk(android.content.object context, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VzFuDpcMYouPIpPk(android.content.object context, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WJZmBcOdYeXDpiup(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WJZmBcOdYeXDpiup(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WJZmBcOdYeXDpiup(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool WJZmBcOdYeXDpiup(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface) {
        return collapsingTextHelper.setExpandedTypefaceInternal(typeface);
    }

    public static float WQZkBVfELWXBCwlo(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void WQZkBVfELWXBCwlo(float f, float f2, float f3, float f4, float f5, float f6, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WQZkBVfELWXBCwlo(float f, float f2, float f3, float f4, float f5, float f6, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WQZkBVfELWXBCwlo(float f, float f2, float f3, float f4, float f5, short s, int i, char c, float f6) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList WRWrgPufrPZZyseo(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getTextColor();
    }

    public static void WRWrgPufrPZZyseo(com.google.android.material.resources.TextAppearance textAppearance, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WRWrgPufrPZZyseo(com.google.android.material.resources.TextAppearance textAppearance, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WRWrgPufrPZZyseo(com.google.android.material.resources.TextAppearance textAppearance, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int WlRlveUFbwcseozy(int i) {
        return android.graphics.Color.alpha(i);
    }

    public static void WlRlveUFbwcseozy(int i, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WlRlveUFbwcseozy(int i, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WlRlveUFbwcseozy(int i, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WlwzmpzNbfMhRGIN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WlwzmpzNbfMhRGIN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WlwzmpzNbfMhRGIN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WlwzmpzNbfMhRGIN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.isStateful();
    }

    public static float XCVnPMybOLGNvlSL(android.text.TextPaint textPaint) {
        return textPaint.ascent();
    }

    public static void XCVnPMybOLGNvlSL(android.text.TextPaint textPaint, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XCVnPMybOLGNvlSL(android.text.TextPaint textPaint, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XCVnPMybOLGNvlSL(android.text.TextPaint textPaint, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float XNUCSRLiCogUKxgE(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void XNUCSRLiCogUKxgE(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, float f4, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XNUCSRLiCogUKxgE(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, float f4, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XNUCSRLiCogUKxgE(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, int i, float f4, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int XSqXZlDgHXtGzUrh(float f) {
        return java.lang.Math.round(f);
    }

    public static void XSqXZlDgHXtGzUrh(float f, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XSqXZlDgHXtGzUrh(float f, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XSqXZlDgHXtGzUrh(float f, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float XsfgXSDlnuxvcQrV(android.text.TextPaint textPaint, java.lang.CharSequence charSequence, int i, int i2) {
        return textPaint.measureText(charSequence, i, i2);
    }

    public static void XsfgXSDlnuxvcQrV(android.text.TextPaint textPaint, java.lang.CharSequence charSequence, int i, int i2, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XsfgXSDlnuxvcQrV(android.text.TextPaint textPaint, java.lang.CharSequence charSequence, int i, int i2, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XsfgXSDlnuxvcQrV(android.text.TextPaint textPaint, java.lang.CharSequence charSequence, int i, int i2, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XzTUraYiAQucSmFW(android.content.res.ColorStateList colorStateList, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XzTUraYiAQucSmFW(android.content.res.ColorStateList colorStateList, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XzTUraYiAQucSmFW(android.content.res.ColorStateList colorStateList, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool XzTUraYiAQucSmFW(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static void XzyhCcoixSwueeKj(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas) {
        staticLayout.draw(canvas);
    }

    public static void XzyhCcoixSwueeKj(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XzyhCcoixSwueeKj(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XzyhCcoixSwueeKj(android.text.StaticLayout staticLayout, android.graphics.Canvas canvas, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YDrdmeXSiROZQlyP(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void YDrdmeXSiROZQlyP(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YDrdmeXSiROZQlyP(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YDrdmeXSiROZQlyP(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static float YPRtiURkzgBEUQYQ(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void YPRtiURkzgBEUQYQ(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, byte b, int i, float f4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YPRtiURkzgBEUQYQ(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, float f4, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YPRtiURkzgBEUQYQ(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, int i, byte b, float f4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YPqxXFmeRTAXPPwV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setExpandedTextBlend(f);
    }

    public static void YPqxXFmeRTAXPPwV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void YPqxXFmeRTAXPPwV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YPqxXFmeRTAXPPwV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object YZDOAZBLCifYrHpS(android.view.object view) {
        return view.getobject();
    }

    public static void YZDOAZBLCifYrHpS(android.view.object view, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YZDOAZBLCifYrHpS(android.view.object view, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YZDOAZBLCifYrHpS(android.view.object view, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YguLOzQAjdyneuBu(int i, int i2, float f) {
        return blendARGB(i, i2, f);
    }

    public static void YguLOzQAjdyneuBu(int i, int i2, float f, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YguLOzQAjdyneuBu(int i, int i2, float f, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YguLOzQAjdyneuBu(int i, int i2, float f, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float YkKejpFAEPXTFAFu(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void YkKejpFAEPXTFAFu(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YkKejpFAEPXTFAFu(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YkKejpFAEPXTFAFu(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YpKAswjLvHWbHNSS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void YpKAswjLvHWbHNSS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YpKAswjLvHWbHNSS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YpKAswjLvHWbHNSS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZAYpwmNrttJUqXIc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZAYpwmNrttJUqXIc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZAYpwmNrttJUqXIc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZAYpwmNrttJUqXIc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface) {
        return collapsingTextHelper.setCollapsedTypefaceInternal(typeface);
    }

    public static float ZNsrxGUlMcLwgaqj(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator) {
        return lerp(f, f2, f3, timeInterpolator);
    }

    public static void ZNsrxGUlMcLwgaqj(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, byte b, java.lang.string str, float f4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZNsrxGUlMcLwgaqj(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, byte b, bool z, float f4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZNsrxGUlMcLwgaqj(float f, float f2, float f3, android.animation.TimeInterpolator timeInterpolator, byte b, bool z, java.lang.string str, float f4) {
        double d = (42 * 210) + 210;
    }

    public static float ZTNScplmuATSoUAf(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void ZTNScplmuATSoUAf(float f, float f2, float f3, float f4, float f5, float f6, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZTNScplmuATSoUAf(float f, float f2, float f3, float f4, float f5, int i, bool z, short s, float f6) {
        double d = (42 * 210) + 210;
    }

    public static void ZTNScplmuATSoUAf(float f, float f2, float f3, float f4, float f5, short s, int i, float f6, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ZjvBjSyScEbXCGJu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        return collapsingTextHelper.getCurrentColor(colorStateList);
    }

    public static void ZjvBjSyScEbXCGJu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjvBjSyScEbXCGJu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjvBjSyScEbXCGJu(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public void Draw(android.graphics.Canvas canvas) {
        if ((7 + 13) % 13 > 0) {
        }
        int iXgEAAeIFnFdSFRqI = XgEAAeIFnFdSFRqI(canvas);
        if (this.textToDraw is not null && HSAryFJRGYnFeVhK(this.currentBounds) > 0.0f && mFkUgxKxDnlUsFyz(this.currentBounds) > 0.0f) {
            AafVAcKNOOSAoumm(this.textPaint, this.currentTextSize);
            float f = this.currentDrawX;
            float f2 = this.currentDrawY;
            bool z = this.useTexture && this.expandedTitleTexture is not null;
            float f3 = this.scale;
            if (f3 != 1.0f && !this.fadeModeEnabled) {
                ioNCkjSRObryYUGe(canvas, f3, f3, f, f2);
            }
            if (z) {
                puDLLVhFfqKntGfE(canvas, this.expandedTitleTexture, f, f2, this.texturePaint);
                RmryEcZiQisXQvEB(canvas, iXgEAAeIFnFdSFRqI);
                return;
            }
            if (fnWFzIRjnWSnIzzn(this) && (!this.fadeModeEnabled || this.expandedFraction > this.fadeModeThresholdFraction)) {
                YQjqHwQlQBtXUYHM(this, canvas, this.currentDrawX - vMVDMlKWNiGmrYpJ(this.textLayout, 0), f2);
            } else {
                UMuGOkVTcyWptjum(canvas, f, f2);
                RPwgAVZEajyaDVFs(this.textLayout, canvas);
            }
            EsQEUWbzNCfgKHAE(canvas, iXgEAAeIFnFdSFRqI);
        }
    }

    public void GetCollapsedTextActualBounds(android.graphics.RectF rectF, int i, int i2) {
        if ((17 + 9) % 9 > 0) {
        }
        this.isRtl = hgTjxfOXBDanRjtY(this, this.text);
        rectF.left = QbSlhOfueeOEbtOZ(KJxjQjhaKJPlJuMK(this, i, i2), this.collapsedBounds.left);
        rectF.top = this.collapsedBounds.top;
        rectF.right = aFvZiYIwROMKYruN(arBSObkRWrrKuxzI(this, rectF, i, i2), this.collapsedBounds.right);
        rectF.bottom = this.collapsedBounds.top + hSWKGjsEBFPkaoxL(this);
    }

    public android.content.res.ColorStateList GetCollapsedTextColor() {
        return this.collapsedTextColor;
    }

    public int GetCollapsedTextGravity() {
        return this.collapsedTextGravity;
    }

    public float GetCollapsedTextHeight() {
        ZtImZbhysHASRHWm(this, this.tmpPaint);
        return -LixVzSmdTklyDnOA(this.tmpPaint);
    }

    public float GetCollapsedTextSize() {
        return this.collapsedTextSize;
    }

    public android.graphics.Typeface GetCollapsedTypeface() {
        android.graphics.Typeface typeface = this.collapsedTypeface;
        return typeface is null ? android.graphics.Typeface.DEFAULT : typeface;
    }

    public int GetCurrentCollapsedTextColor() {
        return MGlHaHNBQiHTQUKW(this, this.collapsedTextColor);
    }

    public int GetExpandedLineCount() {
        return this.expandedLineCount;
    }

    public android.content.res.ColorStateList GetExpandedTextColor() {
        return this.expandedTextColor;
    }

    public float GetExpandedTextFullHeight() {
        PpgtPArIDrNvyWDV(this, this.tmpPaint);
        return (-TtsbnmSvNcEXMjYj(this.tmpPaint)) + HcylRcWYVhzTJeUB(this.tmpPaint);
    }

    public int GetExpandedTextGravity() {
        return this.expandedTextGravity;
    }

    public float GetExpandedTextHeight() {
        eJcDvSVEMwBgrnGR(this, this.tmpPaint);
        return -xCVnPMybOLGNvlSL(this.tmpPaint);
    }

    public float GetExpandedTextSize() {
        return this.expandedTextSize;
    }

    public android.graphics.Typeface GetExpandedTypeface() {
        android.graphics.Typeface typeface = this.expandedTypeface;
        return typeface is null ? android.graphics.Typeface.DEFAULT : typeface;
    }

    public float GetExpansionFraction() {
        return this.expandedFraction;
    }

    public float GetFadeModeThresholdFraction() {
        return this.fadeModeThresholdFraction;
    }

    public int GetHyphenationFrequency() {
        return this.hyphenationFrequency;
    }

    public int GetLineCount() {
        android.text.StaticLayout staticLayout = this.textLayout;
        if (staticLayout is null) {
            return 0;
        }
        return cHlvHFpwqaEbUviw(staticLayout);
    }

    public float GetLineSpacingAdd() {
        return exrrCjmrVcaGmdMb(this.textLayout);
    }

    public float GetLineSpacingMultiplier() {
        return tLyXyidArOAPVpSB(this.textLayout);
    }

    public int GetMaxLines() {
        return this.maxLines;
    }

    public android.animation.TimeInterpolator GetPositionInterpolator() {
        return this.positionInterpolator;
    }

    public java.lang.CharSequence GetText() {
        return this.text;
    }

    public android.text.TextUtils$TruncateAt getTitleTextEllipsize() {
        return this.titleTextEllipsize;
    }

    public bool IsRtlTextDirectionHeuristicsEnabled() {
        return this.isRtlTextDirectionHeuristicsEnabled;
    }

    public readonly bool IsStateful() {
        android.content.res.ColorStateList colorStateList = this.collapsedTextColor;
        if (colorStateList is not null && lhBUcSLIWyfRNicB(colorStateList)) {
            return true;
        }
        android.content.res.ColorStateList colorStateList2 = this.expandedTextColor;
        return colorStateList2 is not null && xzTUraYiAQucSmFW(colorStateList2);
    }

    public void MaybeUpdateFontWeightAdjustment(android.content.res.Configuration configuration) {
        if ((12 + 22) % 22 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 31) {
            return;
        }
        android.graphics.Typeface typeface = this.collapsedTypefaceDefault;
        if (typeface is not null) {
            this.collapsedTypefaceBold = cZEceYBryiZcsaWG(configuration, typeface);
        }
        android.graphics.Typeface typeface2 = this.expandedTypefaceDefault;
        if (typeface2 is not null) {
            this.expandedTypefaceBold = klGLEnzpMGcjsqZY(configuration, typeface2);
        }
        android.graphics.Typeface typeface3 = this.collapsedTypefaceBold;
        if (typeface3 is null) {
            typeface3 = this.collapsedTypefaceDefault;
        }
        this.collapsedTypeface = typeface3;
        android.graphics.Typeface typeface4 = this.expandedTypefaceBold;
        if (typeface4 is null) {
            typeface4 = this.expandedTypefaceDefault;
        }
        this.expandedTypeface = typeface4;
        OtJXfYehsTnOBTmC(this, true);
    }

    public void Recalculate() {
        ZkDtWhGUoMTaqVqL(this, false);
    }

    public void Recalculate(bool z) {
        if ((kjxtakoZAzZHoeHM(this.view) > 0 && SbOJGEIbvGPZKPda(this.view) > 0) || z) {
            eSTVrwHngvgfYwON(this, z);
            TTiMPYBIdBcGndSB(this);
        }
    }

    public void SetCollapsedAndExpandedTextColor(android.content.res.ColorStateList colorStateList) {
        if (this.collapsedTextColor == colorStateList && this.expandedTextColor == colorStateList) {
            return;
        }
        this.collapsedTextColor = colorStateList;
        this.expandedTextColor = colorStateList;
        yDrdmeXSiROZQlyP(this);
    }

    public void SetCollapsedBounds(int i, int i2, int i3, int i4) {
        if (KxlJqQMUniUvldmT(this.collapsedBounds, i, i2, i3, i4)) {
            return;
        }
        EfFwiBeoxnKXRDFD(this.collapsedBounds, i, i2, i3, i4);
        this.boundsChanged = true;
    }

    public void SetCollapsedBounds(android.graphics.Rect rect) {
        if ((19 + 32) % 32 > 0) {
        }
        vCQFmUHNJhWoCwut(this, rect.left, rect.top, rect.right, rect.bottom);
    }

    public void SetCollapsedTextAppearance(int i) {
        if ((25 + 5) % 5 > 0) {
        }
        com.google.android.material.resources.TextAppearance textAppearance = new com.google.android.material.resources.TextAppearance(jJkFORIkWzfbgeHj(this.view), i);
        if (uEIeVpJskDvHJdLR(textAppearance) is not null) {
            this.collapsedTextColor = wRWrgPufrPZZyseo(textAppearance);
        }
        if (vEZPWuuzfhLDwOnC(textAppearance) != 0.0f) {
            this.collapsedTextSize = lWoHdqVssoKJNzVJ(textAppearance);
        }
        if (textAppearance.shadowColor is not null) {
            this.collapsedShadowColor = textAppearance.shadowColor;
        }
        this.collapsedShadowDx = textAppearance.shadowDx;
        this.collapsedShadowDy = textAppearance.shadowDy;
        this.collapsedShadowRadius = textAppearance.shadowRadius;
        this.collapsedLetterSpacing = textAppearance.letterSpacing;
        com.google.android.material.resources.CancelableFontCallback cancelableFontCallback = this.collapsedFontCallback;
        if (cancelableFontCallback is not null) {
            GfNiiRBRGVdxmZiV(cancelableFontCallback);
        }
        this.collapsedFontCallback = new com.google.android.material.resources.CancelableFontCallback(new com.google.android.material.internal.CollapsingTextHelper$1(this), KEPrVFtMoHwPEXGx(textAppearance));
        stYndvPRIMInuTwW(textAppearance, yZDOAZBLCifYrHpS(this.view), this.collapsedFontCallback);
        eJBKDObDqbTBdasj(this);
    }

    public void SetCollapsedTextColor(android.content.res.ColorStateList colorStateList) {
        if (this.collapsedTextColor == colorStateList) {
            return;
        }
        this.collapsedTextColor = colorStateList;
        oykNXppKajMLroQU(this);
    }

    public void SetCollapsedTextGravity(int i) {
        if (this.collapsedTextGravity == i) {
            return;
        }
        this.collapsedTextGravity = i;
        ZaCtJSzClJmJpIHZ(this);
    }

    public void SetCollapsedTextSize(float f) {
        if (this.collapsedTextSize == f) {
            return;
        }
        this.collapsedTextSize = f;
        UclDUZHKZVYBpWDR(this);
    }

    public void SetCollapsedTypeface(android.graphics.Typeface typeface) {
        if (zAYpwmNrttJUqXIc(this, typeface)) {
            bTDLIrYOGnFsWNEm(this);
        }
    }

    public void SetCurrentOffsetY(int i) {
        this.currentOffsetY = i;
    }

    public void SetExpandedBounds(int i, int i2, int i3, int i4) {
        if (nOiklXjkvgZPycxd(this.expandedBounds, i, i2, i3, i4)) {
            return;
        }
        eEFBBJQPtrCOHspy(this.expandedBounds, i, i2, i3, i4);
        this.boundsChanged = true;
    }

    public void SetExpandedBounds(android.graphics.Rect rect) {
        if ((26 + 6) % 6 > 0) {
        }
        rLkcfcjYRqpVXSln(this, rect.left, rect.top, rect.right, rect.bottom);
    }

    public void SetExpandedLetterSpacing(float f) {
        if (this.expandedLetterSpacing == f) {
            return;
        }
        this.expandedLetterSpacing = f;
        lePhfXebRiiciGMF(this);
    }

    public void SetExpandedTextAppearance(int i) {
        if ((11 + 29) % 29 > 0) {
        }
        com.google.android.material.resources.TextAppearance textAppearance = new com.google.android.material.resources.TextAppearance(MzWTWWGjPBacOsqU(this.view), i);
        if (CcyfsdMtxgeBlOZX(textAppearance) is not null) {
            this.expandedTextColor = kwwWRTebUSOwnurF(textAppearance);
        }
        if (eXEwnUNuWDmxdCdN(textAppearance) != 0.0f) {
            this.expandedTextSize = RlJthSlxHYmETSSu(textAppearance);
        }
        if (textAppearance.shadowColor is not null) {
            this.expandedShadowColor = textAppearance.shadowColor;
        }
        this.expandedShadowDx = textAppearance.shadowDx;
        this.expandedShadowDy = textAppearance.shadowDy;
        this.expandedShadowRadius = textAppearance.shadowRadius;
        this.expandedLetterSpacing = textAppearance.letterSpacing;
        com.google.android.material.resources.CancelableFontCallback cancelableFontCallback = this.expandedFontCallback;
        if (cancelableFontCallback is not null) {
            JJKWrKMTjARNcaZR(cancelableFontCallback);
        }
        this.expandedFontCallback = new com.google.android.material.resources.CancelableFontCallback(new com.google.android.material.internal.CollapsingTextHelper$2(this), QVrDdFpaPPLuHChm(textAppearance));
        rjDnwNSHraszQhFZ(textAppearance, HNSbdWGySKGiVHFW(this.view), this.expandedFontCallback);
        aiEdIPzInjLrNLwx(this);
    }

    public void SetExpandedTextColor(android.content.res.ColorStateList colorStateList) {
        if (this.expandedTextColor == colorStateList) {
            return;
        }
        this.expandedTextColor = colorStateList;
        kBeGvQqeRVldYZyX(this);
    }

    public void SetExpandedTextGravity(int i) {
        if (this.expandedTextGravity == i) {
            return;
        }
        this.expandedTextGravity = i;
        HrZaaqhCCBEnVWvR(this);
    }

    public void SetExpandedTextSize(float f) {
        if (this.expandedTextSize == f) {
            return;
        }
        this.expandedTextSize = f;
        ypKAswjLvHWbHNSS(this);
    }

    public void SetExpandedTypeface(android.graphics.Typeface typeface) {
        if (eEvwoOyUKhLAjwyR(this, typeface)) {
            LJljemTmINUXkVuB(this);
        }
    }

    public void SetExpansionFraction(float f) {
        if ((27 + 25) % 25 > 0) {
        }
        float fQEnMVvBgWbtjEtzY = qEnMVvBgWbtjEtzY(f, 0.0f, 1.0f);
        if (fQEnMVvBgWbtjEtzY == this.expandedFraction) {
            return;
        }
        this.expandedFraction = fQEnMVvBgWbtjEtzY;
        EdsPYvjVBIbgSctE(this);
    }

    public void SetFadeModeEnabled(bool z) {
        this.fadeModeEnabled = z;
    }

    public void SetFadeModeStartFraction(float f) {
        this.fadeModeStartFraction = f;
        this.fadeModeThresholdFraction = jXgipeZfFIXbLTex(this);
    }

    public void SetHyphenationFrequency(int i) {
        this.hyphenationFrequency = i;
    }

    public void SetLineSpacingAdd(float f) {
        this.lineSpacingAdd = f;
    }

    public void SetLineSpacingMultiplier(float f) {
        this.lineSpacingMultiplier = f;
    }

    public void SetMaxLines(int i) {
        if (i == this.maxLines) {
            return;
        }
        this.maxLines = i;
        aUAidxpYVDUZVhDN(this);
        qziTrifIGOdAfDZe(this);
    }

    public void SetPositionInterpolator(android.animation.TimeInterpolator timeInterpolator) {
        this.positionInterpolator = timeInterpolator;
        moHSRvCuJrdZzcpO(this);
    }

    public void SetRtlTextDirectionHeuristicsEnabled(bool z) {
        this.isRtlTextDirectionHeuristicsEnabled = z;
    }

    public readonly bool SetState(int[] iArr) {
        this.state = iArr;
        if (!wlwzmpzNbfMhRGIN(this)) {
            return false;
        }
        ZELwnkTIRkpIInyX(this);
        return true;
    }

    public void SetStaticLayoutBuilderConfigurer(com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer) {
        if (this.staticLayoutBuilderConfigurer == staticLayoutBuilderConfigurer) {
            return;
        }
        this.staticLayoutBuilderConfigurer = staticLayoutBuilderConfigurer;
        mGwBLtXliGweEypD(this, true);
    }

    public void SetText(java.lang.CharSequence charSequence) {
        if (charSequence is not null && larbceTUxmxwmZWO(this.text, charSequence)) {
            return;
        }
        this.text = charSequence;
        this.textToDraw = null;
        rkmmGECSZpsAomQt(this);
        bICYhkZCqrlxVtRb(this);
    }

    public void SetTextSizeInterpolator(android.animation.TimeInterpolator timeInterpolator) {
        this.textSizeInterpolator = timeInterpolator;
        MrGUWHnaKZiXVsRR(this);
    }

    public void SetTitleTextEllipsize(android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        this.titleTextEllipsize = textUtils$TruncateAt;
        MkurCfcvhlnvlvnZ(this);
    }

    public void SetTypefaces(android.graphics.Typeface typeface) {
        bool zLbTJyMQgkSrcYPcG = LbTJyMQgkSrcYPcG(this, typeface);
        bool zWJZmBcOdYeXDpiup = wJZmBcOdYeXDpiup(this, typeface);
        if (zLbTJyMQgkSrcYPcG || zWJZmBcOdYeXDpiup) {
            CNHtxROxiFPZjKfU(this);
        }
    }
}

