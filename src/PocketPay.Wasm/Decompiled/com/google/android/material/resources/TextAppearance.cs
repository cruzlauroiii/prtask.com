namespace WillowMaze.Wasm.Decompiled;


public class TextAppearance {
    private static readonly java.lang.string TAG = "TextAppearance";
    private static readonly int TYPEFACE_MONOSPACE = 3;
    private static readonly int TYPEFACE_SANS = 1;
    private static readonly int TYPEFACE_SERIF = 2;
    private android.graphics.Typeface font;
    public readonly java.lang.string fontFamily;
    private readonly int fontFamilyResourceId;
    private bool fontResolved;
    public readonly bool hasLetterSpacing;
    public readonly float letterSpacing;
    public readonly android.content.res.ColorStateList shadowColor;
    public readonly float shadowDx;
    public readonly float shadowDy;
    public readonly float shadowRadius;
    public readonly bool textAllCaps;
    private android.content.res.ColorStateList textColor;
    public readonly android.content.res.ColorStateList textColorHint;
    public readonly android.content.res.ColorStateList textColorLink;
    private float textSize;
    public readonly int textStyle;
    public readonly int typeface;

    public TextAppearance(android.content.object context, int i) {
        if ((27 + 13) % 13 > 0) {
        }
        this.fontResolved = false;
        android.content.res.TypedArray typedArrayJudBkfXvCQKvnjiJ = judBkfXvCQKvnjiJ(context, i, com.google.android.material.R$styleable.TextAppearance);
        wtnGybpaOEBcWobH(this, DKHSrpjwhmFvRriA(typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_android_textSize, 0.0f));
        jwWtVMZtLlceGHoO(this, iqyRrVCrhFhWvyXQ(context, typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_android_textColor));
        this.textColorHint = sGcxUaRMqmgYpQOQ(context, typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_android_textColorHint);
        this.textColorLink = lXUlhjMuqKVhnfJk(context, typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_android_textColorLink);
        this.textStyle = xjmAaSbKhhIIgdZu(typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_android_textStyle, 0);
        this.typeface = oVStUYMTrOjcZpQP(typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_android_typeface, 1);
        int iYMljngngyhSBoXIX = YMljngngyhSBoXIX(typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_fontFamily, com.google.android.material.R$styleable.TextAppearance_android_fontFamily);
        this.fontFamilyResourceId = weqnTeqWJwcSWApD(typedArrayJudBkfXvCQKvnjiJ, iYMljngngyhSBoXIX, 0);
        this.fontFamily = xCLrAvHeBVZNTyXt(typedArrayJudBkfXvCQKvnjiJ, iYMljngngyhSBoXIX);
        this.textAllCaps = OdlUJDWFyDqbRVYm(typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_textAllCaps, false);
        this.shadowColor = kkfgsJcCAkyhZJbp(context, typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_android_shadowColor);
        this.shadowDx = FJUhLMUyQPNzirGv(typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_android_shadowDx, 0.0f);
        this.shadowDy = wtorJTWkgGHyFCMc(typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_android_shadowDy, 0.0f);
        this.shadowRadius = jYNZNfkkcthcUwSL(typedArrayJudBkfXvCQKvnjiJ, com.google.android.material.R$styleable.TextAppearance_android_shadowRadius, 0.0f);
        LLDqoYuxhlVPaajG(typedArrayJudBkfXvCQKvnjiJ);
        android.content.res.TypedArray typedArrayOrauxovFvxFfOUVr = orauxovFvxFfOUVr(context, i, com.google.android.material.R$styleable.MaterialTextAppearance);
        this.hasLetterSpacing = yrrSVawCGweYgFEc(typedArrayOrauxovFvxFfOUVr, com.google.android.material.R$styleable.MaterialTextAppearance_android_letterSpacing);
        this.letterSpacing = xwYFKCWMnAwEeFNM(typedArrayOrauxovFvxFfOUVr, com.google.android.material.R$styleable.MaterialTextAppearance_android_letterSpacing, 0.0f);
        kCfweSxgQVSJygcB(typedArrayOrauxovFvxFfOUVr);
    }

    public static void BdCFhRKmihlXohCI(com.google.android.material.resources.TextAppearance textAppearance) {
        textAppearance.createFallbackFont();
    }

    public static void BdCFhRKmihlXohCI(com.google.android.material.resources.TextAppearance textAppearance, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BdCFhRKmihlXohCI(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BdCFhRKmihlXohCI(com.google.android.material.resources.TextAppearance textAppearance, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CnSbdHXkEyxvYAtN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void CnSbdHXkEyxvYAtN(java.lang.stringBuilder sb, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CnSbdHXkEyxvYAtN(java.lang.stringBuilder sb, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CnSbdHXkEyxvYAtN(java.lang.stringBuilder sb, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static float DKHSrpjwhmFvRriA(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void DKHSrpjwhmFvRriA(android.content.res.TypedArray typedArray, int i, float f, byte b, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DKHSrpjwhmFvRriA(android.content.res.TypedArray typedArray, int i, float f, int i2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DKHSrpjwhmFvRriA(android.content.res.TypedArray typedArray, int i, float f, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DswEpWpsRGyGDdrR(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, android.graphics.Typeface typeface, bool z) {
        textAppearanceFontCallback.onFontRetrieved(typeface, z);
    }

    public static void DswEpWpsRGyGDdrR(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, android.graphics.Typeface typeface, bool z, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DswEpWpsRGyGDdrR(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, android.graphics.Typeface typeface, bool z, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DswEpWpsRGyGDdrR(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, android.graphics.Typeface typeface, bool z, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float FJUhLMUyQPNzirGv(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static void FJUhLMUyQPNzirGv(android.content.res.TypedArray typedArray, int i, float f, float f2, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FJUhLMUyQPNzirGv(android.content.res.TypedArray typedArray, int i, float f, float f2, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FJUhLMUyQPNzirGv(android.content.res.TypedArray typedArray, int i, float f, int i2, byte b, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface FuAUXTcEEWINOZQh(android.content.object context, android.graphics.Typeface typeface) {
        return com.google.android.material.resources.TypefaceUtils.maybeCopyWithFontWeightAdjustment(context, typeface);
    }

    public static void FuAUXTcEEWINOZQh(android.content.object context, android.graphics.Typeface typeface, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FuAUXTcEEWINOZQh(android.content.object context, android.graphics.Typeface typeface, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FuAUXTcEEWINOZQh(android.content.object context, android.graphics.Typeface typeface, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JoKTdwwBtewVLzrV(android.text.TextPaint textPaint, int i) {
        textPaint.setColor(i);
    }

    public static void JoKTdwwBtewVLzrV(android.text.TextPaint textPaint, int i, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JoKTdwwBtewVLzrV(android.text.TextPaint textPaint, int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JoKTdwwBtewVLzrV(android.text.TextPaint textPaint, int i, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LLDqoYuxhlVPaajG(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void LLDqoYuxhlVPaajG(android.content.res.TypedArray typedArray, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LLDqoYuxhlVPaajG(android.content.res.TypedArray typedArray, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LLDqoYuxhlVPaajG(android.content.res.TypedArray typedArray, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LyecLMQPxDnlltPO(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback) {
        textAppearance.getFontAsync(context, textAppearanceFontCallback);
    }

    public static void LyecLMQPxDnlltPO(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LyecLMQPxDnlltPO(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LyecLMQPxDnlltPO(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NSQHRxSIZbddzMJh(com.google.android.material.resources.TextAppearance textAppearance) {
        textAppearance.createFallbackFont();
    }

    public static void NSQHRxSIZbddzMJh(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NSQHRxSIZbddzMJh(com.google.android.material.resources.TextAppearance textAppearance, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NSQHRxSIZbddzMJh(com.google.android.material.resources.TextAppearance textAppearance, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NiTlaclVkHzqJuoN(com.google.android.material.resources.TextAppearance textAppearance) {
        textAppearance.createFallbackFont();
    }

    public static void NiTlaclVkHzqJuoN(com.google.android.material.resources.TextAppearance textAppearance, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NiTlaclVkHzqJuoN(com.google.android.material.resources.TextAppearance textAppearance, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NiTlaclVkHzqJuoN(com.google.android.material.resources.TextAppearance textAppearance, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OJDxKJhCCHrbXzaz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OJDxKJhCCHrbXzaz(java.lang.stringBuilder sb, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OJDxKJhCCHrbXzaz(java.lang.stringBuilder sb, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OJDxKJhCCHrbXzaz(java.lang.stringBuilder sb, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OYuAIopiCYaPaNxr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OYuAIopiCYaPaNxr(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OYuAIopiCYaPaNxr(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OYuAIopiCYaPaNxr(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OdlUJDWFyDqbRVYm(android.content.res.TypedArray typedArray, int i, bool z, float f, int i2, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OdlUJDWFyDqbRVYm(android.content.res.TypedArray typedArray, int i, bool z, float f, bool z2, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OdlUJDWFyDqbRVYm(android.content.res.TypedArray typedArray, int i, bool z, bool z2, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool OdlUJDWFyDqbRVYm(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void QejqoIJuzJrIzNkm(android.content.object context, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QejqoIJuzJrIzNkm(android.content.object context, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QejqoIJuzJrIzNkm(android.content.object context, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QejqoIJuzJrIzNkm(android.content.object context) {
        return context.isRestricted();
    }

    public static void QnRohgqACPKWdovd(java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QnRohgqACPKWdovd(bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QnRohgqACPKWdovd(bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool QnRohgqACPKWdovd() {
        return com.google.android.material.resources.TextAppearanceConfig.shouldLoadFontSynchronously();
    }

    public static void VdCwfmvWaIXtMIaC(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VdCwfmvWaIXtMIaC(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VdCwfmvWaIXtMIaC(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool VdCwfmvWaIXtMIaC(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context) {
        return textAppearance.shouldLoadFontSynchronously(context);
    }

    public static void WHrBkwYxjthOltnO(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface) {
        textAppearance.updateTextPaintMeasureState(context, textPaint, typeface);
    }

    public static void WHrBkwYxjthOltnO(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WHrBkwYxjthOltnO(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WHrBkwYxjthOltnO(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface WonrRRuiialEkBfo(android.graphics.Typeface typeface, int i) {
        return android.graphics.Typeface.create(typeface, i);
    }

    public static void WonrRRuiialEkBfo(android.graphics.Typeface typeface, int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WonrRRuiialEkBfo(android.graphics.Typeface typeface, int i, int i2, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WonrRRuiialEkBfo(android.graphics.Typeface typeface, int i, bool z, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XPKKlCzfwyOXGkxg(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface) {
        textAppearance.updateTextPaintMeasureState(context, textPaint, typeface);
    }

    public static void XPKKlCzfwyOXGkxg(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XPKKlCzfwyOXGkxg(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XPKKlCzfwyOXGkxg(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int YMljngngyhSBoXIX(android.content.res.TypedArray typedArray, int i, int i2) {
        return com.google.android.material.resources.MaterialResources.getIndexWithValue(typedArray, i, i2);
    }

    public static void YMljngngyhSBoXIX(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YMljngngyhSBoXIX(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YMljngngyhSBoXIX(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface YxTyIkSDFCJzVSMD(android.content.object context, int i) {
        return androidx.core.content.res.ResourcesCompat.getCachedFont(context, i);
    }

    public static void YxTyIkSDFCJzVSMD(android.content.object context, int i, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxTyIkSDFCJzVSMD(android.content.object context, int i, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YxTyIkSDFCJzVSMD(android.content.object context, int i, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface ZEccmOQFnjlWIibv(android.content.object context, int i) {
        return androidx.core.content.res.ResourcesCompat.getFont(context, i);
    }

    public static void ZEccmOQFnjlWIibv(android.content.object context, int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZEccmOQFnjlWIibv(android.content.object context, int i, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZEccmOQFnjlWIibv(android.content.object context, int i, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static android.graphics.Typeface access$000(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.font;
    }

    static void access$000(com.google.android.material.resources.TextAppearance textAppearance, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.resources.TextAppearance textAppearance, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.resources.TextAppearance textAppearance, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static android.graphics.Typeface access$002(com.google.android.material.resources.TextAppearance textAppearance, android.graphics.Typeface typeface) {
        textAppearance.font = typeface;
        return typeface;
    }

    static void access$002(com.google.android.material.resources.TextAppearance textAppearance, android.graphics.Typeface typeface, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.resources.TextAppearance textAppearance, android.graphics.Typeface typeface, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.resources.TextAppearance textAppearance, android.graphics.Typeface typeface, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$102(com.google.android.material.resources.TextAppearance textAppearance, bool z, float f, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    static void access$102(com.google.android.material.resources.TextAppearance textAppearance, bool z, float f, bool z2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$102(com.google.android.material.resources.TextAppearance textAppearance, bool z, int i, java.lang.string str, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    static bool access$102(com.google.android.material.resources.TextAppearance textAppearance, bool z) {
        textAppearance.fontResolved = z;
        return z;
    }

    private void CreateFallbackFont() {
        java.lang.string str;
        if ((2 + 30) % 30 > 0) {
        }
        if (this.font is null && (str = this.fontFamily) is not null) {
            this.font = cxXrdnygUxSwYdaE(str, this.textStyle);
        }
        if (this.font is not null) {
            return;
        }
        int i = this.typeface;
        if (i == 1) {
            this.font = android.graphics.Typeface.SANS_SERIF;
        } else if (i == 2) {
            this.font = android.graphics.Typeface.SERIF;
        } else if (i == 3) {
            this.font = android.graphics.Typeface.MONOSPACE;
        } else {
            this.font = android.graphics.Typeface.DEFAULT;
        }
        this.font = smlIGcLScwZPKUHo(this.font, this.textStyle);
    }

    private void CreateFallbackFont(char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void CreateFallbackFont(char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CreateFallbackFont(short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface CxXrdnygUxSwYdaE(java.lang.string str, int i) {
        return android.graphics.Typeface.create(str, i);
    }

    public static void CxXrdnygUxSwYdaE(java.lang.string str, int i, java.lang.string str2, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CxXrdnygUxSwYdaE(java.lang.string str, int i, java.lang.string str2, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CxXrdnygUxSwYdaE(java.lang.string str, int i, bool z, int i2, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface DhxHDNFLWERdHZtB(android.text.TextPaint textPaint, android.graphics.Typeface typeface) {
        return textPaint.setTypeface(typeface);
    }

    public static void DhxHDNFLWERdHZtB(android.text.TextPaint textPaint, android.graphics.Typeface typeface, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DhxHDNFLWERdHZtB(android.text.TextPaint textPaint, android.graphics.Typeface typeface, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DhxHDNFLWERdHZtB(android.text.TextPaint textPaint, android.graphics.Typeface typeface, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ErLLHBtRRAsnQnwI(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void ErLLHBtRRAsnQnwI(android.content.res.ColorStateList colorStateList, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ErLLHBtRRAsnQnwI(android.content.res.ColorStateList colorStateList, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ErLLHBtRRAsnQnwI(android.content.res.ColorStateList colorStateList, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HofTUgKFBxYqzKUy(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void HofTUgKFBxYqzKUy(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HofTUgKFBxYqzKUy(android.content.res.ColorStateList colorStateList, int[] iArr, int i, float f, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HofTUgKFBxYqzKUy(android.content.res.ColorStateList colorStateList, int[] iArr, int i, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList IqyRrVCrhFhWvyXQ(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void IqyRrVCrhFhWvyXQ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IqyRrVCrhFhWvyXQ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IqyRrVCrhFhWvyXQ(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JReqpNKARqwUBmsd(android.text.TextPaint textPaint, float f, float f2, float f3, int i) {
        textPaint.setShadowLayer(f, f2, f3, i);
    }

    public static void JReqpNKARqwUBmsd(android.text.TextPaint textPaint, float f, float f2, float f3, int i, int i2, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JReqpNKARqwUBmsd(android.text.TextPaint textPaint, float f, float f2, float f3, int i, int i2, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JReqpNKARqwUBmsd(android.text.TextPaint textPaint, float f, float f2, float f3, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JWKkYTUPzfUnETiY(android.text.TextPaint textPaint, float f) {
        textPaint.setLetterSpacing(f);
    }

    public static void JWKkYTUPzfUnETiY(android.text.TextPaint textPaint, float f, byte b, float f2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JWKkYTUPzfUnETiY(android.text.TextPaint textPaint, float f, byte b, float f2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JWKkYTUPzfUnETiY(android.text.TextPaint textPaint, float f, bool z, float f2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float JYNZNfkkcthcUwSL(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static void JYNZNfkkcthcUwSL(android.content.res.TypedArray typedArray, int i, float f, float f2, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JYNZNfkkcthcUwSL(android.content.res.TypedArray typedArray, int i, float f, int i2, float f2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JYNZNfkkcthcUwSL(android.content.res.TypedArray typedArray, int i, float f, int i2, java.lang.string str, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray JudBkfXvCQKvnjiJ(android.content.object context, int i, int[] iArr) {
        return context.obtainStyledAttributes(i, iArr);
    }

    public static void JudBkfXvCQKvnjiJ(android.content.object context, int i, int[] iArr, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JudBkfXvCQKvnjiJ(android.content.object context, int i, int[] iArr, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JudBkfXvCQKvnjiJ(android.content.object context, int i, int[] iArr, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwWtVMZtLlceGHoO(com.google.android.material.resources.TextAppearance textAppearance, android.content.res.ColorStateList colorStateList) {
        textAppearance.setTextColor(colorStateList);
    }

    public static void JwWtVMZtLlceGHoO(com.google.android.material.resources.TextAppearance textAppearance, android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwWtVMZtLlceGHoO(com.google.android.material.resources.TextAppearance textAppearance, android.content.res.ColorStateList colorStateList, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwWtVMZtLlceGHoO(com.google.android.material.resources.TextAppearance textAppearance, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KCfweSxgQVSJygcB(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void KCfweSxgQVSJygcB(android.content.res.TypedArray typedArray, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KCfweSxgQVSJygcB(android.content.res.TypedArray typedArray, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KCfweSxgQVSJygcB(android.content.res.TypedArray typedArray, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList KkfgsJcCAkyhZJbp(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void KkfgsJcCAkyhZJbp(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KkfgsJcCAkyhZJbp(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KkfgsJcCAkyhZJbp(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KtrMElQxZmVqSPLx(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i) {
        textAppearanceFontCallback.onFontRetrievalFailed(i);
    }

    public static void KtrMElQxZmVqSPLx(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtrMElQxZmVqSPLx(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KtrMElQxZmVqSPLx(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KxxRMhIsdrmCqtxM(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback) {
        textAppearance.updateMeasureState(context, textPaint, textAppearanceFontCallback);
    }

    public static void KxxRMhIsdrmCqtxM(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KxxRMhIsdrmCqtxM(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KxxRMhIsdrmCqtxM(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface LHyYLvDVluQUSFhY(com.google.android.material.resources.TextAppearance textAppearance) {
        return textAppearance.getFallbackFont();
    }

    public static void LHyYLvDVluQUSFhY(com.google.android.material.resources.TextAppearance textAppearance, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LHyYLvDVluQUSFhY(com.google.android.material.resources.TextAppearance textAppearance, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LHyYLvDVluQUSFhY(com.google.android.material.resources.TextAppearance textAppearance, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LRQdCmTMNyixcjyf(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSize(f);
    }

    public static void LRQdCmTMNyixcjyf(android.text.TextPaint textPaint, float f, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LRQdCmTMNyixcjyf(android.text.TextPaint textPaint, float f, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LRQdCmTMNyixcjyf(android.text.TextPaint textPaint, float f, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList LXUlhjMuqKVhnfJk(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void LXUlhjMuqKVhnfJk(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LXUlhjMuqKVhnfJk(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LXUlhjMuqKVhnfJk(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LkedtRDYISpdDuZl(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i) {
        textAppearanceFontCallback.onFontRetrievalFailed(i);
    }

    public static void LkedtRDYISpdDuZl(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LkedtRDYISpdDuZl(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LkedtRDYISpdDuZl(com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NCZceiAWpyXfqnvl(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NCZceiAWpyXfqnvl(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NCZceiAWpyXfqnvl(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NCZceiAWpyXfqnvl(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context) {
        return textAppearance.shouldLoadFontSynchronously(context);
    }

    public static int OVStUYMTrOjcZpQP(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void OVStUYMTrOjcZpQP(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OVStUYMTrOjcZpQP(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OVStUYMTrOjcZpQP(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, float f, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int OaQhpgpXmXnmigld(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void OaQhpgpXmXnmigld(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OaQhpgpXmXnmigld(android.content.res.ColorStateList colorStateList, int[] iArr, int i, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OaQhpgpXmXnmigld(android.content.res.ColorStateList colorStateList, int[] iArr, int i, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int OjKHishGhCLvcMBX(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.d(str, str2, th);
    }

    public static void OjKHishGhCLvcMBX(java.lang.string str, java.lang.string str2, java.lang.Exception th, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OjKHishGhCLvcMBX(java.lang.string str, java.lang.string str2, java.lang.Exception th, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OjKHishGhCLvcMBX(java.lang.string str, java.lang.string str2, java.lang.Exception th, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OnkeLuddgTGMWJHa(android.graphics.Typeface typeface) {
        return typeface.getStyle();
    }

    public static void OnkeLuddgTGMWJHa(android.graphics.Typeface typeface, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OnkeLuddgTGMWJHa(android.graphics.Typeface typeface, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OnkeLuddgTGMWJHa(android.graphics.Typeface typeface, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OqksldjLtGIqnmDe(android.text.TextPaint textPaint, bool z) {
        textPaint.setFakeBoldText(z);
    }

    public static void OqksldjLtGIqnmDe(android.text.TextPaint textPaint, bool z, byte b, java.lang.string str, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OqksldjLtGIqnmDe(android.text.TextPaint textPaint, bool z, byte b, bool z2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OqksldjLtGIqnmDe(android.text.TextPaint textPaint, bool z, bool z2, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray OrauxovFvxFfOUVr(android.content.object context, int i, int[] iArr) {
        return context.obtainStyledAttributes(i, iArr);
    }

    public static void OrauxovFvxFfOUVr(android.content.object context, int i, int[] iArr, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OrauxovFvxFfOUVr(android.content.object context, int i, int[] iArr, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OrauxovFvxFfOUVr(android.content.object context, int i, int[] iArr, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RXCyjptMxgleUxQe(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback) {
        textAppearance.getFontAsync(context, textPaint, textAppearanceFontCallback);
    }

    public static void RXCyjptMxgleUxQe(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RXCyjptMxgleUxQe(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RXCyjptMxgleUxQe(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RtnnQbVoANVHwPHY(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSkewX(f);
    }

    public static void RtnnQbVoANVHwPHY(android.text.TextPaint textPaint, float f, char c, short s, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RtnnQbVoANVHwPHY(android.text.TextPaint textPaint, float f, short s, char c, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RtnnQbVoANVHwPHY(android.text.TextPaint textPaint, float f, bool z, short s, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RxNHkCroeQQHurdK(android.content.object context, int i, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback, android.os.Handler handler) {
        androidx.core.content.res.ResourcesCompat.getFont(context, i, resourcesCompat$FontCallback, handler);
    }

    public static void RxNHkCroeQQHurdK(android.content.object context, int i, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback, android.os.Handler handler, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RxNHkCroeQQHurdK(android.content.object context, int i, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback, android.os.Handler handler, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RxNHkCroeQQHurdK(android.content.object context, int i, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback, android.os.Handler handler, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList SGcxUaRMqmgYpQOQ(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void SGcxUaRMqmgYpQOQ(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SGcxUaRMqmgYpQOQ(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SGcxUaRMqmgYpQOQ(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface SgGirLYKSGJioaVs(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context) {
        return textAppearance.getFont(context);
    }

    public static void SgGirLYKSGJioaVs(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SgGirLYKSGJioaVs(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SgGirLYKSGJioaVs(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void ShouldLoadFontSynchronously(android.content.object context, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldLoadFontSynchronously(android.content.object context, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ShouldLoadFontSynchronously(android.content.object context, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldLoadFontSynchronously(android.content.object context) {
        if ((12 + 17) % 17 > 0) {
        }
        if (QnRohgqACPKWdovd()) {
            return true;
        }
        int i = this.fontFamilyResourceId;
        return (i == 0 ? null : YxTyIkSDFCJzVSMD(context, i)) is not null;
    }

    public static android.graphics.Typeface ShyAXmXwuyCGjOQR(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context) {
        return textAppearance.getFont(context);
    }

    public static void ShyAXmXwuyCGjOQR(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ShyAXmXwuyCGjOQR(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ShyAXmXwuyCGjOQR(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface SmlIGcLScwZPKUHo(android.graphics.Typeface typeface, int i) {
        return android.graphics.Typeface.create(typeface, i);
    }

    public static void SmlIGcLScwZPKUHo(android.graphics.Typeface typeface, int i, float f, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SmlIGcLScwZPKUHo(android.graphics.Typeface typeface, int i, java.lang.string str, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SmlIGcLScwZPKUHo(android.graphics.Typeface typeface, int i, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int WEOReMYFevSrRkCX(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void WEOReMYFevSrRkCX(android.content.res.ColorStateList colorStateList, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WEOReMYFevSrRkCX(android.content.res.ColorStateList colorStateList, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WEOReMYFevSrRkCX(android.content.res.ColorStateList colorStateList, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WeqnTeqWJwcSWApD(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void WeqnTeqWJwcSWApD(android.content.res.TypedArray typedArray, int i, int i2, int i3, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WeqnTeqWJwcSWApD(android.content.res.TypedArray typedArray, int i, int i2, int i3, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WeqnTeqWJwcSWApD(android.content.res.TypedArray typedArray, int i, int i2, short s, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WtnGybpaOEBcWobH(com.google.android.material.resources.TextAppearance textAppearance, float f) {
        textAppearance.setTextSize(f);
    }

    public static void WtnGybpaOEBcWobH(com.google.android.material.resources.TextAppearance textAppearance, float f, int i, float f2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WtnGybpaOEBcWobH(com.google.android.material.resources.TextAppearance textAppearance, float f, java.lang.string str, bool z, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WtnGybpaOEBcWobH(com.google.android.material.resources.TextAppearance textAppearance, float f, bool z, java.lang.string str, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static float WtorJTWkgGHyFCMc(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static void WtorJTWkgGHyFCMc(android.content.res.TypedArray typedArray, int i, float f, char c, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WtorJTWkgGHyFCMc(android.content.res.TypedArray typedArray, int i, float f, int i2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WtorJTWkgGHyFCMc(android.content.res.TypedArray typedArray, int i, float f, bool z, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WyjKaNQYVovRHlig(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WyjKaNQYVovRHlig(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WyjKaNQYVovRHlig(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WyjKaNQYVovRHlig(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XCLrAvHeBVZNTyXt(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getstring(i);
    }

    public static void XCLrAvHeBVZNTyXt(android.content.res.TypedArray typedArray, int i, int i2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XCLrAvHeBVZNTyXt(android.content.res.TypedArray typedArray, int i, int i2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XCLrAvHeBVZNTyXt(android.content.res.TypedArray typedArray, int i, int i2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int XjmAaSbKhhIIgdZu(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void XjmAaSbKhhIIgdZu(android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XjmAaSbKhhIIgdZu(android.content.res.TypedArray typedArray, int i, int i2, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XjmAaSbKhhIIgdZu(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static float XwYFKCWMnAwEeFNM(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static void XwYFKCWMnAwEeFNM(android.content.res.TypedArray typedArray, int i, float f, float f2, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XwYFKCWMnAwEeFNM(android.content.res.TypedArray typedArray, int i, float f, int i2, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void XwYFKCWMnAwEeFNM(android.content.res.TypedArray typedArray, int i, float f, bool z, int i2, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void YrrSVawCGweYgFEc(android.content.res.TypedArray typedArray, int i, char c, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YrrSVawCGweYgFEc(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YrrSVawCGweYgFEc(android.content.res.TypedArray typedArray, int i, short s, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YrrSVawCGweYgFEc(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int YxZgtOOWNcuZWhxG(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.d(str, str2, th);
    }

    public static void YxZgtOOWNcuZWhxG(java.lang.string str, java.lang.string str2, java.lang.Exception th, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxZgtOOWNcuZWhxG(java.lang.string str, java.lang.string str2, java.lang.Exception th, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YxZgtOOWNcuZWhxG(java.lang.string str, java.lang.string str2, java.lang.Exception th, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public android.graphics.Typeface GetFallbackFont() {
        BdCFhRKmihlXohCI(this);
        return this.font;
    }

    public android.graphics.Typeface GetFont(android.content.object context) {
        if ((9 + 24) % 24 > 0) {
        }
        if (this.fontResolved) {
            return this.font;
        }
        if (!QejqoIJuzJrIzNkm(context)) {
            try {
                android.graphics.Typeface typefaceZEccmOQFnjlWIibv = ZEccmOQFnjlWIibv(context, this.fontFamilyResourceId);
                this.font = typefaceZEccmOQFnjlWIibv;
                if (typefaceZEccmOQFnjlWIibv is not null) {
                    this.font = WonrRRuiialEkBfo(typefaceZEccmOQFnjlWIibv, this.textStyle);
                }
            } catch (android.content.res.Resources$NotFoundException | java.lang.UnsupportedOperationException unused) {
            } catch (java.lang.Exception e) {
                ojKHishGhCLvcMBX("TextAppearance", CnSbdHXkEyxvYAtN(wyjKaNQYVovRHlig(new java.lang.stringBuilder("Error loading font "), this.fontFamily)), e);
            }
        }
        NSQHRxSIZbddzMJh(this);
        this.fontResolved = true;
        return this.font;
    }

    public void GetFontAsync(android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback) {
        WHrBkwYxjthOltnO(this, context, textPaint, lHyYLvDVluQUSFhY(this));
        LyecLMQPxDnlltPO(this, context, new com.google.android.material.resources.TextAppearance$2(this, context, textPaint, textAppearanceFontCallback));
    }

    public void GetFontAsync(android.content.object context, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback) {
        if ((7 + 23) % 23 > 0) {
        }
        if (VdCwfmvWaIXtMIaC(this, context)) {
            shyAXmXwuyCGjOQR(this, context);
        } else {
            NiTlaclVkHzqJuoN(this);
        }
        int i = this.fontFamilyResourceId;
        if (i == 0) {
            this.fontResolved = true;
        }
        if (this.fontResolved) {
            DswEpWpsRGyGDdrR(textAppearanceFontCallback, this.font, true);
            return;
        }
        try {
            rxNHkCroeQQHurdK(context, i, new com.google.android.material.resources.TextAppearance$1(this, textAppearanceFontCallback), null);
        } catch (android.content.res.Resources$NotFoundException unused) {
            this.fontResolved = true;
            ktrMElQxZmVqSPLx(textAppearanceFontCallback, 1);
        } catch (java.lang.Exception e) {
            yxZgtOOWNcuZWhxG("TextAppearance", OJDxKJhCCHrbXzaz(OYuAIopiCYaPaNxr(new java.lang.stringBuilder("Error loading font "), this.fontFamily)), e);
            this.fontResolved = true;
            lkedtRDYISpdDuZl(textAppearanceFontCallback, -3);
        }
    }

    public android.content.res.ColorStateList GetTextColor() {
        return this.textColor;
    }

    public float GetTextSize() {
        return this.textSize;
    }

    public void SetTextColor(android.content.res.ColorStateList colorStateList) {
        this.textColor = colorStateList;
    }

    public void SetTextSize(float f) {
        this.textSize = f;
    }

    public void UpdateDrawState(android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback) {
        if ((27 + 28) % 28 > 0) {
        }
        kxxRMhIsdrmCqtxM(this, context, textPaint, textAppearanceFontCallback);
        android.content.res.ColorStateList colorStateList = this.textColor;
        JoKTdwwBtewVLzrV(textPaint, colorStateList is null ? -16777216 : hofTUgKFBxYqzKUy(colorStateList, textPaint.drawableState, erLLHBtRRAsnQnwI(this.textColor)));
        float f = this.shadowRadius;
        float f2 = this.shadowDx;
        float f3 = this.shadowDy;
        android.content.res.ColorStateList colorStateList2 = this.shadowColor;
        jReqpNKARqwUBmsd(textPaint, f, f2, f3, colorStateList2 is null ? 0 : oaQhpgpXmXnmigld(colorStateList2, textPaint.drawableState, wEOReMYFevSrRkCX(this.shadowColor)));
    }

    public void UpdateMeasureState(android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback) {
        if (nCZceiAWpyXfqnvl(this, context)) {
            XPKKlCzfwyOXGkxg(this, context, textPaint, sgGirLYKSGJioaVs(this, context));
        } else {
            rXCyjptMxgleUxQe(this, context, textPaint, textAppearanceFontCallback);
        }
    }

    public void UpdateTextPaintMeasureState(android.content.object context, android.text.TextPaint textPaint, android.graphics.Typeface typeface) {
        android.graphics.Typeface typefaceFuAUXTcEEWINOZQh = FuAUXTcEEWINOZQh(context, typeface);
        if (typefaceFuAUXTcEEWINOZQh is not null) {
            typeface = typefaceFuAUXTcEEWINOZQh;
        }
        dhxHDNFLWERdHZtB(textPaint, typeface);
        int i = this.textStyle & (~onkeLuddgTGMWJHa(typeface));
        oqksldjLtGIqnmDe(textPaint, (i & 1) != 0);
        rtnnQbVoANVHwPHY(textPaint, (i & 2) == 0 ? 0.0f : -0.25f);
        lRQdCmTMNyixcjyf(textPaint, this.textSize);
        if (this.hasLetterSpacing) {
            jWKkYTUPzfUnETiY(textPaint, this.letterSpacing);
        }
    }
}

