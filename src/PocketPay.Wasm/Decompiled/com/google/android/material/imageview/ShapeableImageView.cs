namespace WillowMaze.Wasm.Decompiled;


public class ShapeableImageobject : androidx.appcompat.widget.AppCompatImageobject : com.google.android.material.shape.Shapeable {
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_ShapeableImageobject;
    private static readonly int UNDEFINED_PADDING = int.MIN_VALUE;
    private readonly android.graphics.Paint borderPaint;
    private int bottomContentPadding;
    private readonly android.graphics.Paint clearPaint;
    private readonly android.graphics.RectF destination;
    private int endContentPadding;
    private bool hasAdjustedPaddingAfterLayoutDirectionResolved;
    private int leftContentPadding;
    private android.graphics.Path maskPath;
    private readonly android.graphics.RectF maskRect;
    private readonly android.graphics.Path path;
    private readonly com.google.android.material.shape.ShapeAppearancePathProvider pathProvider;
    private int rightContentPadding;
    private com.google.android.material.shape.MaterialShapeDrawable shadowDrawable;
    private com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel;
    private int startContentPadding;
    private android.content.res.ColorStateList strokeColor;
    private float strokeWidth;
    private int topContentPadding;

    public ShapeableImageobject(android.content.object context) {
        this(context, null, 0);
        if ((1 + 18) % 18 > 0) {
        }
    }

    public ShapeableImageobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public ShapeableImageobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((30 + 12) % 12 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(BvvSchrEYudYhivk(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.pathProvider = cNAERZvZfMIpYEoj();
        this.path = new android.graphics.Path();
        this.hasAdjustedPaddingAfterLayoutDirectionResolved = false;
        android.content.object contextAfVhBNRLlZNZGAdB = AfVhBNRLlZNZGAdB(this);
        android.graphics.Paint paint = new android.graphics.Paint();
        this.clearPaint = paint;
        SUTTBxrieZoxlniA(paint, true);
        ATiheFxcVVocloIt(paint, -1);
        yCpOIfiCyNLzlhuB(paint, new android.graphics.PorterDuffXfermode(android.graphics.PorterDuff$Mode.DST_OUT));
        this.destination = new android.graphics.RectF();
        this.maskRect = new android.graphics.RectF();
        this.maskPath = new android.graphics.Path();
        android.content.res.TypedArray typedArrayBHQLeVojWuWtqVbo = BHQLeVojWuWtqVbo(contextAfVhBNRLlZNZGAdB, attributeHashSet, com.google.android.material.R$styleable.ShapeableImageobject, i, i2);
        LryYygsExExJnzpX(this, 2, null);
        this.strokeColor = IGnbzjOdojkAQDzG(contextAfVhBNRLlZNZGAdB, typedArrayBHQLeVojWuWtqVbo, com.google.android.material.R$styleable.ShapeableImageobject_strokeColor);
        this.strokeWidth = ijAwZIwukoReDsma(typedArrayBHQLeVojWuWtqVbo, com.google.android.material.R$styleable.ShapeableImageobject_strokeWidth, 0);
        int iCpxaZimANvBBiMiV = CpxaZimANvBBiMiV(typedArrayBHQLeVojWuWtqVbo, com.google.android.material.R$styleable.ShapeableImageobject_contentPadding, 0);
        this.leftContentPadding = iCpxaZimANvBBiMiV;
        this.topContentPadding = iCpxaZimANvBBiMiV;
        this.rightContentPadding = iCpxaZimANvBBiMiV;
        this.bottomContentPadding = iCpxaZimANvBBiMiV;
        this.leftContentPadding = cxfMqfIBmhNAMeJt(typedArrayBHQLeVojWuWtqVbo, com.google.android.material.R$styleable.ShapeableImageobject_contentPaddingLeft, iCpxaZimANvBBiMiV);
        this.topContentPadding = ubjPNFhbTfVOXUZt(typedArrayBHQLeVojWuWtqVbo, com.google.android.material.R$styleable.ShapeableImageobject_contentPaddingTop, iCpxaZimANvBBiMiV);
        this.rightContentPadding = CTRCwgmRhXrKHPJn(typedArrayBHQLeVojWuWtqVbo, com.google.android.material.R$styleable.ShapeableImageobject_contentPaddingRight, iCpxaZimANvBBiMiV);
        this.bottomContentPadding = eiRxeTZYanLEtbbo(typedArrayBHQLeVojWuWtqVbo, com.google.android.material.R$styleable.ShapeableImageobject_contentPaddingBottom, iCpxaZimANvBBiMiV);
        this.startContentPadding = fSwueCvykFFwTlrp(typedArrayBHQLeVojWuWtqVbo, com.google.android.material.R$styleable.ShapeableImageobject_contentPaddingStart, int.MIN_VALUE);
        this.endContentPadding = hrurZqURezPIGMyU(typedArrayBHQLeVojWuWtqVbo, com.google.android.material.R$styleable.ShapeableImageobject_contentPaddingEnd, int.MIN_VALUE);
        NcVDCRgMlLegRvwy(typedArrayBHQLeVojWuWtqVbo);
        android.graphics.Paint paint2 = new android.graphics.Paint();
        this.borderPaint = paint2;
        iNIqTDlGpZZcCgND(paint2, android.graphics.Paint$Style.STROKE);
        xkGokyhdRUyTGbYS(paint2, true);
        this.shapeAppearanceModel = lgAVuJEwNlGcazXJ(AoWzCDUCeJNvfjVu(contextAfVhBNRLlZNZGAdB, attributeHashSet, i, i2));
        jMQedfMsPfAKuOPt(this, new com.google.android.material.imageview.ShapeableImageobject$OutlineProvider(this));
    }

    public static void ATiheFxcVVocloIt(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void ATiheFxcVVocloIt(android.graphics.Paint paint, int i, byte b, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ATiheFxcVVocloIt(android.graphics.Paint paint, int i, int i2, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ATiheFxcVVocloIt(android.graphics.Paint paint, int i, bool z, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object AfVhBNRLlZNZGAdB(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getobject();
    }

    public static void AfVhBNRLlZNZGAdB(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AfVhBNRLlZNZGAdB(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AfVhBNRLlZNZGAdB(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder AoWzCDUCeJNvfjVu(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2);
    }

    public static void AoWzCDUCeJNvfjVu(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AoWzCDUCeJNvfjVu(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AoWzCDUCeJNvfjVu(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray BHQLeVojWuWtqVbo(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void BHQLeVojWuWtqVbo(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, float f, java.lang.string str, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BHQLeVojWuWtqVbo(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, java.lang.string str, int i3, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BHQLeVojWuWtqVbo(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, bool z, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int BcOSaubBQokhcEau(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingStart();
    }

    public static void BcOSaubBQokhcEau(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BcOSaubBQokhcEau(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BcOSaubBQokhcEau(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object BvvSchrEYudYhivk(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void BvvSchrEYudYhivk(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BvvSchrEYudYhivk(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BvvSchrEYudYhivk(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CTRCwgmRhXrKHPJn(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void CTRCwgmRhXrKHPJn(android.content.res.TypedArray typedArray, int i, int i2, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CTRCwgmRhXrKHPJn(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CTRCwgmRhXrKHPJn(android.content.res.TypedArray typedArray, int i, int i2, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CpxaZimANvBBiMiV(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void CpxaZimANvBBiMiV(android.content.res.TypedArray typedArray, int i, int i2, int i3, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CpxaZimANvBBiMiV(android.content.res.TypedArray typedArray, int i, int i2, bool z, float f, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CpxaZimANvBBiMiV(android.content.res.TypedArray typedArray, int i, int i2, bool z, int i3, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int CtmcNQMkNMeINZxs(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingBottom();
    }

    public static void CtmcNQMkNMeINZxs(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CtmcNQMkNMeINZxs(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CtmcNQMkNMeINZxs(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CxPNrCdAxEIJbFwy(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingStart();
    }

    public static void CxPNrCdAxEIJbFwy(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CxPNrCdAxEIJbFwy(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CxPNrCdAxEIJbFwy(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int GuLgeqLJnhfikNlA(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getHeight();
    }

    public static void GuLgeqLJnhfikNlA(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GuLgeqLJnhfikNlA(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GuLgeqLJnhfikNlA(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HDqkSAYZxbPmiBaO(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f) {
        shapeableImageobject.setStrokeWidth(f);
    }

    public static void HDqkSAYZxbPmiBaO(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, byte b, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void HDqkSAYZxbPmiBaO(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, byte b, java.lang.string str, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HDqkSAYZxbPmiBaO(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, java.lang.string str, char c, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList IGnbzjOdojkAQDzG(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void IGnbzjOdojkAQDzG(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IGnbzjOdojkAQDzG(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IGnbzjOdojkAQDzG(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int IWLeGwCkhvzpGDaW(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingLeft();
    }

    public static void IWLeGwCkhvzpGDaW(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IWLeGwCkhvzpGDaW(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IWLeGwCkhvzpGDaW(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JuwYexhIffssSPru(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingLeft();
    }

    public static void JuwYexhIffssSPru(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JuwYexhIffssSPru(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JuwYexhIffssSPru(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int JySJNAcDdoEtAVcq(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingRight();
    }

    public static void JySJNAcDdoEtAVcq(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JySJNAcDdoEtAVcq(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JySJNAcDdoEtAVcq(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int LVRKjKMWrxSLMJPN(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingTop();
    }

    public static void LVRKjKMWrxSLMJPN(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LVRKjKMWrxSLMJPN(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LVRKjKMWrxSLMJPN(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LryYygsExExJnzpX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, android.graphics.Paint paint) {
        shapeableImageobject.setLayerType(i, paint);
    }

    public static void LryYygsExExJnzpX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, android.graphics.Paint paint, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LryYygsExExJnzpX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, android.graphics.Paint paint, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LryYygsExExJnzpX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, android.graphics.Paint paint, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MnCYPkssCnISYDbp(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingTop();
    }

    public static void MnCYPkssCnISYDbp(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MnCYPkssCnISYDbp(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MnCYPkssCnISYDbp(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int NQqFSWmwVCUCyUHV(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingLeft();
    }

    public static void NQqFSWmwVCUCyUHV(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NQqFSWmwVCUCyUHV(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NQqFSWmwVCUCyUHV(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NcVDCRgMlLegRvwy(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void NcVDCRgMlLegRvwy(android.content.res.TypedArray typedArray, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NcVDCRgMlLegRvwy(android.content.res.TypedArray typedArray, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NcVDCRgMlLegRvwy(android.content.res.TypedArray typedArray, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OBbzsQhyQhxRixau(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.content.res.ColorStateList colorStateList) {
        shapeableImageobject.setStrokeColor(colorStateList);
    }

    public static void OBbzsQhyQhxRixau(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.content.res.ColorStateList colorStateList, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OBbzsQhyQhxRixau(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.content.res.ColorStateList colorStateList, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OBbzsQhyQhxRixau(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PPxTlENzqExRFjBJ(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PPxTlENzqExRFjBJ(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PPxTlENzqExRFjBJ(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PPxTlENzqExRFjBJ(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isContentPaddingRelative();
    }

    public static int PSywsHkmanljEayL(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getPaddingTop();
    }

    public static void PSywsHkmanljEayL(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PSywsHkmanljEayL(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PSywsHkmanljEayL(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PdFSpDzUtSnwxmco(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PdFSpDzUtSnwxmco(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PdFSpDzUtSnwxmco(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool PdFSpDzUtSnwxmco(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isContentPaddingRelative();
    }

    public static void PdYSoEKXkifooZWa(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        shapeableImageobject.invalidate();
    }

    public static void PdYSoEKXkifooZWa(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PdYSoEKXkifooZWa(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PdYSoEKXkifooZWa(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PfhujxujurjxSGJz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2) {
        shapeableImageobject.updateShapeMask(i, i2);
    }

    public static void PfhujxujurjxSGJz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PfhujxujurjxSGJz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PfhujxujurjxSGJz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QGDArgYRDyTmQWON(android.graphics.Path path, android.graphics.RectF rectF, android.graphics.Path$Direction path$Direction) {
        path.addRect(rectF, path$Direction);
    }

    public static void QGDArgYRDyTmQWON(android.graphics.Path path, android.graphics.RectF rectF, android.graphics.Path$Direction path$Direction, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QGDArgYRDyTmQWON(android.graphics.Path path, android.graphics.RectF rectF, android.graphics.Path$Direction path$Direction, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QGDArgYRDyTmQWON(android.graphics.Path path, android.graphics.RectF rectF, android.graphics.Path$Direction path$Direction, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int QlpMJfswVCpZwtla(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingRight();
    }

    public static void QlpMJfswVCpZwtla(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QlpMJfswVCpZwtla(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QlpMJfswVCpZwtla(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RZTWcwGRYnzoEicY(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RZTWcwGRYnzoEicY(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RZTWcwGRYnzoEicY(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RZTWcwGRYnzoEicY(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isLayoutDirectionResolved();
    }

    public static int RpIreaxQJeTyBHpR(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingTop();
    }

    public static void RpIreaxQJeTyBHpR(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RpIreaxQJeTyBHpR(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RpIreaxQJeTyBHpR(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RtvZjBHPSZkDSdaz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingEnd();
    }

    public static void RtvZjBHPSZkDSdaz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RtvZjBHPSZkDSdaz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RtvZjBHPSZkDSdaz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RxIKKFrGtKPuifHP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingStart();
    }

    public static void RxIKKFrGtKPuifHP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RxIKKFrGtKPuifHP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RxIKKFrGtKPuifHP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SUTTBxrieZoxlniA(android.graphics.Paint paint, bool z) {
        paint.setAntiAlias(z);
    }

    public static void SUTTBxrieZoxlniA(android.graphics.Paint paint, bool z, float f, bool z2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SUTTBxrieZoxlniA(android.graphics.Paint paint, bool z, int i, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SUTTBxrieZoxlniA(android.graphics.Paint paint, bool z, bool z2, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SXAfjQnfIjHTrmNl(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingTop();
    }

    public static void SXAfjQnfIjHTrmNl(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SXAfjQnfIjHTrmNl(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SXAfjQnfIjHTrmNl(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SwWzkgpTolwkeQjq(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SwWzkgpTolwkeQjq(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SwWzkgpTolwkeQjq(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SwWzkgpTolwkeQjq(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isRtl();
    }

    public static int TbXAyevAbszcQKJQ(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getLayoutDirection();
    }

    public static void TbXAyevAbszcQKJQ(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TbXAyevAbszcQKJQ(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TbXAyevAbszcQKJQ(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TvatCGkLysGHpYwn(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingBottom();
    }

    public static void TvatCGkLysGHpYwn(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TvatCGkLysGHpYwn(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TvatCGkLysGHpYwn(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UHtTqDxAQHrUKcRf(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UHtTqDxAQHrUKcRf(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UHtTqDxAQHrUKcRf(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UHtTqDxAQHrUKcRf(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isContentPaddingRelative();
    }

    public static void ULozpinrAbrrayZr(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void ULozpinrAbrrayZr(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, bool z, float f, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ULozpinrAbrrayZr(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, bool z, short s, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ULozpinrAbrrayZr(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, bool z, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UMymQojmDLIhshXk(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path) {
        shapeAppearancePathProvider.calculatePath(shapeAppearanceModel, f, rectF, path);
    }

    public static void UMymQojmDLIhshXk(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path, char c, short s, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UMymQojmDLIhshXk(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path, int i, short s, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UMymQojmDLIhshXk(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path, short s, float f2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UqPGPYcJJNBuUlht(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4) {
        super.setPadding(i, i2, i3, i4);
    }

    public static void UqPGPYcJJNBuUlht(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UqPGPYcJJNBuUlht(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UqPGPYcJJNBuUlht(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UuAGyUkgmuSRvWoz(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4) {
        super.setPadding(i, i2, i3, i4);
    }

    public static void UuAGyUkgmuSRvWoz(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, int i5, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UuAGyUkgmuSRvWoz(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, short s, byte b, float f, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void UuAGyUkgmuSRvWoz(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, short s, int i5, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VIEAaTHtercaYCCL(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void VIEAaTHtercaYCCL(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VIEAaTHtercaYCCL(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VIEAaTHtercaYCCL(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WFWDhyIcjaDKQdMN(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void WFWDhyIcjaDKQdMN(android.graphics.Paint paint, float f, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WFWDhyIcjaDKQdMN(android.graphics.Paint paint, float f, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WFWDhyIcjaDKQdMN(android.graphics.Paint paint, float f, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int WQOmyNMLjvbcVriO(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingEnd();
    }

    public static void WQOmyNMLjvbcVriO(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WQOmyNMLjvbcVriO(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WQOmyNMLjvbcVriO(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WlDGzfZegRmZSADL(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WlDGzfZegRmZSADL(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WlDGzfZegRmZSADL(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WlDGzfZegRmZSADL(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isRtl();
    }

    public static void WryzXLZgzrTtlHqX(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static void WryzXLZgzrTtlHqX(android.graphics.RectF rectF, float f, float f2, float f3, float f4, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WryzXLZgzrTtlHqX(android.graphics.RectF rectF, float f, float f2, float f3, float f4, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WryzXLZgzrTtlHqX(android.graphics.RectF rectF, float f, float f2, float f3, float f4, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int YwiqIxDQFFqNhhwm(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void YwiqIxDQFFqNhhwm(android.content.res.ColorStateList colorStateList, int[] iArr, int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YwiqIxDQFFqNhhwm(android.content.res.ColorStateList colorStateList, int[] iArr, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YwiqIxDQFFqNhhwm(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ABhJzHrSFQBWqfWy(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABhJzHrSFQBWqfWy(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABhJzHrSFQBWqfWy(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ABhJzHrSFQBWqfWy(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isRtl();
    }

    public static int AHgVkQoCfjmVDXml(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingBottom();
    }

    public static void AHgVkQoCfjmVDXml(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AHgVkQoCfjmVDXml(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AHgVkQoCfjmVDXml(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void APxoPCvoAMNmxvDF(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        shapeableImageobject.invalidate();
    }

    public static void APxoPCvoAMNmxvDF(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void APxoPCvoAMNmxvDF(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void APxoPCvoAMNmxvDF(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.shape.ShapeAppearanceModel access$000(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.shapeAppearanceModel;
    }

    static void access$000(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.shape.MaterialShapeDrawable access$100(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.shadowDrawable;
    }

    static void access$100(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.shape.MaterialShapeDrawable access$102(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        shapeableImageobject.shadowDrawable = materialShapeDrawable;
        return materialShapeDrawable;
    }

    static void access$102(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$102(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$102(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static android.graphics.RectF access$200(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.destination;
    }

    static void access$200(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AwjjwabjVqZhJHBt(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static void AwjjwabjVqZhJHBt(android.graphics.RectF rectF, float f, float f2, float f3, float f4, char c, int i, float f5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AwjjwabjVqZhJHBt(android.graphics.RectF rectF, float f, float f2, float f3, float f4, int i, float f5, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AwjjwabjVqZhJHBt(android.graphics.RectF rectF, float f, float f2, float f3, float f4, short s, char c, int i, float f5) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearancePathProvider CNAERZvZfMIpYEoj() {
        return com.google.android.material.shape.ShapeAppearancePathProvider.getInstance();
    }

    public static void CNAERZvZfMIpYEoj(float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CNAERZvZfMIpYEoj(float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CNAERZvZfMIpYEoj(int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CQqytNnCCWCGorom(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2) {
        shapeableImageobject.updateShapeMask(i, i2);
    }

    public static void CQqytNnCCWCGorom(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CQqytNnCCWCGorom(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CQqytNnCCWCGorom(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CYIYGZIFrAjLeqfb(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CYIYGZIFrAjLeqfb(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CYIYGZIFrAjLeqfb(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool CYIYGZIFrAjLeqfb(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isRtl();
    }

    public static android.content.res.Resources CeMjwrubrNsqOfAX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getResources();
    }

    public static void CeMjwrubrNsqOfAX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CeMjwrubrNsqOfAX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CeMjwrubrNsqOfAX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CxfMqfIBmhNAMeJt(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void CxfMqfIBmhNAMeJt(android.content.res.TypedArray typedArray, int i, int i2, byte b, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void CxfMqfIBmhNAMeJt(android.content.res.TypedArray typedArray, int i, int i2, char c, int i3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CxfMqfIBmhNAMeJt(android.content.res.TypedArray typedArray, int i, int i2, bool z, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int DClYtfwOuYoXoRsp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingBottom();
    }

    public static void DClYtfwOuYoXoRsp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DClYtfwOuYoXoRsp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DClYtfwOuYoXoRsp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int DDomXoPMiQPmBQib(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingStart();
    }

    public static void DDomXoPMiQPmBQib(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DDomXoPMiQPmBQib(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DDomXoPMiQPmBQib(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int DPpucgHzrUJnYhQC(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingBottom();
    }

    public static void DPpucgHzrUJnYhQC(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DPpucgHzrUJnYhQC(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DPpucgHzrUJnYhQC(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DpDVRasFyWsrKSoT(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DpDVRasFyWsrKSoT(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DpDVRasFyWsrKSoT(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int[] DpDVRasFyWsrKSoT(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getDrawableState();
    }

    private void DrawStroke(android.graphics.Canvas canvas) {
        if ((7 + 1) % 1 > 0) {
        }
        if (this.strokeColor is not null) {
            WFWDhyIcjaDKQdMN(this.borderPaint, this.strokeWidth);
            int iYwiqIxDQFFqNhhwm = YwiqIxDQFFqNhhwm(this.strokeColor, dpDVRasFyWsrKSoT(this), ujggRaUnVZxegzXO(this.strokeColor));
            if (this.strokeWidth > 0.0f && iYwiqIxDQFFqNhhwm != 0) {
                sjTmFyuOiPPRdMpv(this.borderPaint, iYwiqIxDQFFqNhhwm);
                VIEAaTHtercaYCCL(canvas, this.path, this.borderPaint);
            }
        }
    }

    private void DrawStroke(android.graphics.Canvas canvas, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void DrawStroke(android.graphics.Canvas canvas, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void DrawStroke(android.graphics.Canvas canvas, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EKDNbmDROmegiIMV(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        shapeableImageobject.invalidate();
    }

    public static void EKDNbmDROmegiIMV(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EKDNbmDROmegiIMV(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EKDNbmDROmegiIMV(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EiRxeTZYanLEtbbo(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void EiRxeTZYanLEtbbo(android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EiRxeTZYanLEtbbo(android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EiRxeTZYanLEtbbo(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int EpGUJfMCpaUfoEwS(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingTop();
    }

    public static void EpGUJfMCpaUfoEwS(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EpGUJfMCpaUfoEwS(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EpGUJfMCpaUfoEwS(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FJjFiZACrMkHdFnb(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, android.graphics.Canvas canvas) {
        super.onDraw(canvas);
    }

    public static void FJjFiZACrMkHdFnb(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, android.graphics.Canvas canvas, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FJjFiZACrMkHdFnb(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, android.graphics.Canvas canvas, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FJjFiZACrMkHdFnb(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, android.graphics.Canvas canvas, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FSwueCvykFFwTlrp(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void FSwueCvykFFwTlrp(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FSwueCvykFFwTlrp(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void FSwueCvykFFwTlrp(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FUtTXyjYgCYOnDpJ(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingRight();
    }

    public static void FUtTXyjYgCYOnDpJ(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FUtTXyjYgCYOnDpJ(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FUtTXyjYgCYOnDpJ(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FkqAkCiZwCLFkmdB(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingEnd();
    }

    public static void FkqAkCiZwCLFkmdB(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FkqAkCiZwCLFkmdB(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FkqAkCiZwCLFkmdB(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FrPcpdEWBHOtKxPq(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingBottom();
    }

    public static void FrPcpdEWBHOtKxPq(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FrPcpdEWBHOtKxPq(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FrPcpdEWBHOtKxPq(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GWGrHyXMknKlidYY(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, int i3, int i4) {
        shapeableImageobject.setPaddingRelative(i, i2, i3, i4);
    }

    public static void GWGrHyXMknKlidYY(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, int i3, int i4, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GWGrHyXMknKlidYY(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, int i3, int i4, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GWGrHyXMknKlidYY(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, int i3, int i4, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HrurZqURezPIGMyU(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void HrurZqURezPIGMyU(android.content.res.TypedArray typedArray, int i, int i2, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HrurZqURezPIGMyU(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HrurZqURezPIGMyU(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ICzVUmnlAjreSrxe(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingRight();
    }

    public static void ICzVUmnlAjreSrxe(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ICzVUmnlAjreSrxe(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ICzVUmnlAjreSrxe(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IDsEedPutZEojXVq(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
    }

    public static void IDsEedPutZEojXVq(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, char c, int i5, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IDsEedPutZEojXVq(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, int i5, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IDsEedPutZEojXVq(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, int i5, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList IFCElYiOsKaAnASc(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void IFCElYiOsKaAnASc(android.content.object context, int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IFCElYiOsKaAnASc(android.content.object context, int i, int i2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IFCElYiOsKaAnASc(android.content.object context, int i, short s, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void INIqTDlGpZZcCgND(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void INIqTDlGpZZcCgND(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void INIqTDlGpZZcCgND(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void INIqTDlGpZZcCgND(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IjAwZIwukoReDsma(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void IjAwZIwukoReDsma(android.content.res.TypedArray typedArray, int i, int i2, float f, int i3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IjAwZIwukoReDsma(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, short s, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IjAwZIwukoReDsma(android.content.res.TypedArray typedArray, int i, int i2, short s, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    private void IsContentPaddingRelative(byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsContentPaddingRelative(java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsContentPaddingRelative(short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private bool IsContentPaddingRelative() {
        if ((15 + 15) % 15 > 0) {
        }
        return (this.startContentPadding == int.MIN_VALUE && this.endContentPadding == int.MIN_VALUE) ? false : true;
    }

    private void IsRtl(byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void IsRtl(byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void IsRtl(java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool IsRtl() {
        return TbXAyevAbszcQKJQ(this) == 1;
    }

    public static int JAaubfEticywCnhk(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingBottom();
    }

    public static void JAaubfEticywCnhk(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JAaubfEticywCnhk(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JAaubfEticywCnhk(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JMQedfMsPfAKuOPt(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.view.objectOutlineProvider viewOutlineProvider) {
        shapeableImageobject.setOutlineProvider(viewOutlineProvider);
    }

    public static void JMQedfMsPfAKuOPt(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.view.objectOutlineProvider viewOutlineProvider, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JMQedfMsPfAKuOPt(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.view.objectOutlineProvider viewOutlineProvider, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JMQedfMsPfAKuOPt(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.view.objectOutlineProvider viewOutlineProvider, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JUQVhdCUAqzaXrVL(android.graphics.Path path) {
        path.rewind();
    }

    public static void JUQVhdCUAqzaXrVL(android.graphics.Path path, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JUQVhdCUAqzaXrVL(android.graphics.Path path, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JUQVhdCUAqzaXrVL(android.graphics.Path path, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JgqHgGWZufWecFDP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, int i3, int i4) {
        shapeableImageobject.setPadding(i, i2, i3, i4);
    }

    public static void JgqHgGWZufWecFDP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, int i3, int i4, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JgqHgGWZufWecFDP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, int i3, int i4, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JgqHgGWZufWecFDP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, int i2, int i3, int i4, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KifSsanqLGsIwlRI(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KifSsanqLGsIwlRI(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KifSsanqLGsIwlRI(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool KifSsanqLGsIwlRI(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isPaddingRelative();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel LgAVuJEwNlGcazXJ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void LgAVuJEwNlGcazXJ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LgAVuJEwNlGcazXJ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LgAVuJEwNlGcazXJ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LgJaXSuukcgtemzZ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void LgJaXSuukcgtemzZ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LgJaXSuukcgtemzZ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LgJaXSuukcgtemzZ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MXluoTHmLgNklojE(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingTop();
    }

    public static void MXluoTHmLgNklojE(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MXluoTHmLgNklojE(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MXluoTHmLgNklojE(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NoHuKWeAHfWzuoyz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NoHuKWeAHfWzuoyz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NoHuKWeAHfWzuoyz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NoHuKWeAHfWzuoyz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isRtl();
    }

    public static int NxFwpBnpcjpazqZp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingEnd();
    }

    public static void NxFwpBnpcjpazqZp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NxFwpBnpcjpazqZp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NxFwpBnpcjpazqZp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OJRKbqsAlkUiqvHd(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getPaddingRight();
    }

    public static void OJRKbqsAlkUiqvHd(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OJRKbqsAlkUiqvHd(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OJRKbqsAlkUiqvHd(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int OoNHsZaBAtsOMtjG(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void OoNHsZaBAtsOMtjG(android.content.res.Resources resources, int i, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OoNHsZaBAtsOMtjG(android.content.res.Resources resources, int i, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OoNHsZaBAtsOMtjG(android.content.res.Resources resources, int i, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int PJheLYfmypLGbicu(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getPaddingLeft();
    }

    public static void PJheLYfmypLGbicu(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PJheLYfmypLGbicu(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PJheLYfmypLGbicu(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PRHjXDyAVtdwnbEg(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getobject();
    }

    public static void PRHjXDyAVtdwnbEg(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PRHjXDyAVtdwnbEg(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PRHjXDyAVtdwnbEg(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QgXUtXasxkehjclF(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.graphics.Canvas canvas) {
        shapeableImageobject.drawStroke(canvas);
    }

    public static void QgXUtXasxkehjclF(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.graphics.Canvas canvas, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QgXUtXasxkehjclF(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.graphics.Canvas canvas, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QgXUtXasxkehjclF(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, android.graphics.Canvas canvas, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QlMsDSxuLmVqvviG(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingRight();
    }

    public static void QlMsDSxuLmVqvviG(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QlMsDSxuLmVqvviG(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QlMsDSxuLmVqvviG(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RhSnjsGboombybTp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4) {
        super.setPaddingRelative(i, i2, i3, i4);
    }

    public static void RhSnjsGboombybTp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, float f, int i5, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RhSnjsGboombybTp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, int i5, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RhSnjsGboombybTp(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, bool z, int i5, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SLypFHrspWgmyzNW(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingStart();
    }

    public static void SLypFHrspWgmyzNW(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SLypFHrspWgmyzNW(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SLypFHrspWgmyzNW(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SjTmFyuOiPPRdMpv(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void SjTmFyuOiPPRdMpv(android.graphics.Paint paint, int i, float f, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SjTmFyuOiPPRdMpv(android.graphics.Paint paint, int i, float f, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SjTmFyuOiPPRdMpv(android.graphics.Paint paint, int i, int i2, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SpVUYHeqigktJsqG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingLeft();
    }

    public static void SpVUYHeqigktJsqG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SpVUYHeqigktJsqG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SpVUYHeqigktJsqG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SxfnpskcqecXnOZS(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4) {
        super.setPaddingRelative(i, i2, i3, i4);
    }

    public static void SxfnpskcqecXnOZS(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, byte b, java.lang.string str, int i5, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SxfnpskcqecXnOZS(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, java.lang.string str, bool z, byte b, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void SxfnpskcqecXnOZS(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, int i, int i2, int i3, int i4, bool z, byte b, java.lang.string str, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void TAPjmnGEjdbIOlVo(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TAPjmnGEjdbIOlVo(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TAPjmnGEjdbIOlVo(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TAPjmnGEjdbIOlVo(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isRtl();
    }

    public static int TETiXaErVJFfLqOu(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingBottom();
    }

    public static void TETiXaErVJFfLqOu(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TETiXaErVJFfLqOu(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TETiXaErVJFfLqOu(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int TFXLnVWOBZPNAFTk(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingTop();
    }

    public static void TFXLnVWOBZPNAFTk(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TFXLnVWOBZPNAFTk(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TFXLnVWOBZPNAFTk(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int TRCNFUnxxfILYuGH(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingLeft();
    }

    public static void TRCNFUnxxfILYuGH(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TRCNFUnxxfILYuGH(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TRCNFUnxxfILYuGH(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TZevRqelrhfxfHVz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        shapeableImageobject.invalidateOutline();
    }

    public static void TZevRqelrhfxfHVz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZevRqelrhfxfHVz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TZevRqelrhfxfHVz(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TaWBxKBzLBrudrJw(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingTop();
    }

    public static void TaWBxKBzLBrudrJw(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TaWBxKBzLBrudrJw(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TaWBxKBzLBrudrJw(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int UbjPNFhbTfVOXUZt(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void UbjPNFhbTfVOXUZt(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UbjPNFhbTfVOXUZt(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UbjPNFhbTfVOXUZt(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int UjggRaUnVZxegzXO(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void UjggRaUnVZxegzXO(android.content.res.ColorStateList colorStateList, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UjggRaUnVZxegzXO(android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UjggRaUnVZxegzXO(android.content.res.ColorStateList colorStateList, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateShapeMask(int i, int i2) {
        if ((7 + 15) % 15 > 0) {
        }
        WryzXLZgzrTtlHqX(this.destination, pJheLYfmypLGbicu(this), PSywsHkmanljEayL(this), i - oJRKbqsAlkUiqvHd(this), i2 - uqyDxEgKbYEJJFbX(this));
        UMymQojmDLIhshXk(this.pathProvider, this.shapeAppearanceModel, 1.0f, this.destination, this.path);
        jUQVhdCUAqzaXrVL(this.maskPath);
        xtehAWOBoVchfBoq(this.maskPath, this.path);
        awjjwabjVqZhJHBt(this.maskRect, 0.0f, 0.0f, i, i2);
        QGDArgYRDyTmQWON(this.maskPath, this.maskRect, android.graphics.Path$Direction.CCW);
    }

    private void UpdateShapeMask(int i, int i2, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateShapeMask(int i, int i2, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateShapeMask(int i, int i2, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UqyDxEgKbYEJJFbX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getPaddingBottom();
    }

    public static void UqyDxEgKbYEJJFbX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UqyDxEgKbYEJJFbX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UqyDxEgKbYEJJFbX(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VgnUGNkmihCGxAlD(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VgnUGNkmihCGxAlD(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VgnUGNkmihCGxAlD(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VgnUGNkmihCGxAlD(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isRtl();
    }

    public static int WajKNgtXOtBuGUyn(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return super.getPaddingEnd();
    }

    public static void WajKNgtXOtBuGUyn(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WajKNgtXOtBuGUyn(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WajKNgtXOtBuGUyn(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WpuelEZhnYrLxPZG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WpuelEZhnYrLxPZG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WpuelEZhnYrLxPZG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WpuelEZhnYrLxPZG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.isRtl();
    }

    public static int XLIflnlQFtHRdnHG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingStart();
    }

    public static void XLIflnlQFtHRdnHG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XLIflnlQFtHRdnHG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XLIflnlQFtHRdnHG(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XkGokyhdRUyTGbYS(android.graphics.Paint paint, bool z) {
        paint.setAntiAlias(z);
    }

    public static void XkGokyhdRUyTGbYS(android.graphics.Paint paint, bool z, byte b, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XkGokyhdRUyTGbYS(android.graphics.Paint paint, bool z, byte b, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XkGokyhdRUyTGbYS(android.graphics.Paint paint, bool z, float f, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XsdBZBCkNZVXPEeP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getWidth();
    }

    public static void XsdBZBCkNZVXPEeP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XsdBZBCkNZVXPEeP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XsdBZBCkNZVXPEeP(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XtehAWOBoVchfBoq(android.graphics.Path path, android.graphics.Path path2) {
        path.addPath(path2);
    }

    public static void XtehAWOBoVchfBoq(android.graphics.Path path, android.graphics.Path path2, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XtehAWOBoVchfBoq(android.graphics.Path path, android.graphics.Path path2, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XtehAWOBoVchfBoq(android.graphics.Path path, android.graphics.Path path2, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Xfermode YCpOIfiCyNLzlhuB(android.graphics.Paint paint, android.graphics.Xfermode xfermode) {
        return paint.setXfermode(xfermode);
    }

    public static void YCpOIfiCyNLzlhuB(android.graphics.Paint paint, android.graphics.Xfermode xfermode, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YCpOIfiCyNLzlhuB(android.graphics.Paint paint, android.graphics.Xfermode xfermode, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YCpOIfiCyNLzlhuB(android.graphics.Paint paint, android.graphics.Xfermode xfermode, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int YjBCVsEPQnOLrfFu(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject) {
        return shapeableImageobject.getContentPaddingEnd();
    }

    public static void YjBCVsEPQnOLrfFu(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YjBCVsEPQnOLrfFu(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YjBCVsEPQnOLrfFu(com.google.android.material.imageview.ShapeableImageobject shapeableImageobject, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YpnjsrMowspshbVj(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void YpnjsrMowspshbVj(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YpnjsrMowspshbVj(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YpnjsrMowspshbVj(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public int GetContentPaddingBottom() {
        return this.bottomContentPadding;
    }

    public readonly int GetContentPaddingEnd() {
        if ((11 + 4) % 4 > 0) {
        }
        int i = this.endContentPadding;
        return i == int.MIN_VALUE ? !aBhJzHrSFQBWqfWy(this) ? this.rightContentPadding : this.leftContentPadding : i;
    }

    public int GetContentPaddingLeft() {
        int i;
        int i2;
        if ((2 + 11) % 11 > 0) {
        }
        if (UHtTqDxAQHrUKcRf(this)) {
            if (WlDGzfZegRmZSADL(this) && (i2 = this.endContentPadding) != int.MIN_VALUE) {
                return i2;
            }
            if (!SwWzkgpTolwkeQjq(this) && (i = this.startContentPadding) != int.MIN_VALUE) {
                return i;
            }
        }
        return this.leftContentPadding;
    }

    public int GetContentPaddingRight() {
        int i;
        int i2;
        if ((20 + 28) % 28 > 0) {
        }
        if (PdFSpDzUtSnwxmco(this)) {
            if (vgnUGNkmihCGxAlD(this) && (i = this.startContentPadding) != int.MIN_VALUE) {
                return i;
            }
            if (!wpuelEZhnYrLxPZG(this) && (i2 = this.endContentPadding) != int.MIN_VALUE) {
                return i2;
            }
        }
        return this.rightContentPadding;
    }

    public readonly int GetContentPaddingStart() {
        if ((8 + 14) % 14 > 0) {
        }
        int i = this.startContentPadding;
        return i == int.MIN_VALUE ? !tAPjmnGEjdbIOlVo(this) ? this.leftContentPadding : this.rightContentPadding : i;
    }

    public int GetContentPaddingTop() {
        return this.topContentPadding;
    }

    public override int GetPaddingBottom() {
        return aHgVkQoCfjmVDXml(this) - dPpucgHzrUJnYhQC(this);
    }

    public override int GetPaddingEnd() {
        return fkqAkCiZwCLFkmdB(this) - RtvZjBHPSZkDSdaz(this);
    }

    public override int GetPaddingLeft() {
        return NQqFSWmwVCUCyUHV(this) - spVUYHeqigktJsqG(this);
    }

    public override int GetPaddingRight() {
        return QlpMJfswVCpZwtla(this) - JySJNAcDdoEtAVcq(this);
    }

    public override int GetPaddingStart() {
        return BcOSaubBQokhcEau(this) - RxIKKFrGtKPuifHP(this);
    }

    public override int GetPaddingTop() {
        return taWBxKBzLBrudrJw(this) - tFXLnVWOBZPNAFTk(this);
    }

    public override com.google.android.material.shape.ShapeAppearanceModel GetShapeAppearanceModel() {
        return this.shapeAppearanceModel;
    }

    public android.content.res.ColorStateList GetStrokeColor() {
        return this.strokeColor;
    }

    public float GetStrokeWidth() {
        return this.strokeWidth;
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        if ((25 + 3) % 3 > 0) {
        }
        fJjFiZACrMkHdFnb(this, canvas);
        ypnjsrMowspshbVj(canvas, this.maskPath, this.clearPaint);
        qgXUtXasxkehjclF(this, canvas);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((17 + 3) % 3 > 0) {
        }
        ULozpinrAbrrayZr(this, i, i2);
        if (this.hasAdjustedPaddingAfterLayoutDirectionResolved || !RZTWcwGRYnzoEicY(this)) {
            return;
        }
        this.hasAdjustedPaddingAfterLayoutDirectionResolved = true;
        if (kifSsanqLGsIwlRI(this) || PPxTlENzqExRFjBJ(this)) {
            gWGrHyXMknKlidYY(this, dDomXoPMiQPmBQib(this), SXAfjQnfIjHTrmNl(this), nxFwpBnpcjpazqZp(this), jAaubfEticywCnhk(this));
        } else {
            jgqHgGWZufWecFDP(this, JuwYexhIffssSPru(this), epGUJfMCpaUfoEwS(this), qlMsDSxuLmVqvviG(this), frPcpdEWBHOtKxPq(this));
        }
    }

    protected override void OnSizeChanged(int i, int i2, int i3, int i4) {
        iDsEedPutZEojXVq(this, i, i2, i3, i4);
        cQqytNnCCWCGorom(this, i, i2);
    }

    public void SetContentPadding(int i, int i2, int i3, int i4) {
        if ((2 + 11) % 11 > 0) {
        }
        this.startContentPadding = int.MIN_VALUE;
        this.endContentPadding = int.MIN_VALUE;
        UuAGyUkgmuSRvWoz(this, (tRCNFUnxxfILYuGH(this) - this.leftContentPadding) + i, (RpIreaxQJeTyBHpR(this) - this.topContentPadding) + i2, (fUtTXyjYgCYOnDpJ(this) - this.rightContentPadding) + i3, (dClYtfwOuYoXoRsp(this) - this.bottomContentPadding) + i4);
        this.leftContentPadding = i;
        this.topContentPadding = i2;
        this.rightContentPadding = i3;
        this.bottomContentPadding = i4;
    }

    public void SetContentPaddingRelative(int i, int i2, int i3, int i4) {
        if ((28 + 2) % 2 > 0) {
        }
        sxfnpskcqecXnOZS(this, (CxPNrCdAxEIJbFwy(this) - xLIflnlQFtHRdnHG(this)) + i, (LVRKjKMWrxSLMJPN(this) - this.topContentPadding) + i2, (wajKNgtXOtBuGUyn(this) - WQOmyNMLjvbcVriO(this)) + i3, (tETiXaErVJFfLqOu(this) - this.bottomContentPadding) + i4);
        this.leftContentPadding = !noHuKWeAHfWzuoyz(this) ? i : i3;
        this.topContentPadding = i2;
        if (!cYIYGZIFrAjLeqfb(this)) {
            i = i3;
        }
        this.rightContentPadding = i;
        this.bottomContentPadding = i4;
    }

    public override void SetPadding(int i, int i2, int i3, int i4) {
        UqPGPYcJJNBuUlht(this, i + IWLeGwCkhvzpGDaW(this), i2 + MnCYPkssCnISYDbp(this), i3 + iCzVUmnlAjreSrxe(this), i4 + TvatCGkLysGHpYwn(this));
    }

    public override void SetPaddingRelative(int i, int i2, int i3, int i4) {
        rhSnjsGboombybTp(this, i + sLypFHrspWgmyzNW(this), i2 + mXluoTHmLgNklojE(this), i3 + yjBCVsEPQnOLrfFu(this), i4 + CtmcNQMkNMeINZxs(this));
    }

    public override void SetShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        this.shapeAppearanceModel = shapeAppearanceModel;
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.shadowDrawable;
        if (materialShapeDrawable is not null) {
            lgJaXSuukcgtemzZ(materialShapeDrawable, shapeAppearanceModel);
        }
        PfhujxujurjxSGJz(this, xsdBZBCkNZVXPEeP(this), GuLgeqLJnhfikNlA(this));
        aPxoPCvoAMNmxvDF(this);
        tZevRqelrhfxfHVz(this);
    }

    public void SetStrokeColor(android.content.res.ColorStateList colorStateList) {
        this.strokeColor = colorStateList;
        eKDNbmDROmegiIMV(this);
    }

    public void SetStrokeColorResource(int i) {
        OBbzsQhyQhxRixau(this, iFCElYiOsKaAnASc(pRHjXDyAVtdwnbEg(this), i));
    }

    public void SetStrokeWidth(float f) {
        if (this.strokeWidth == f) {
            return;
        }
        this.strokeWidth = f;
        PdYSoEKXkifooZWa(this);
    }

    public void SetStrokeWidthResource(int i) {
        HDqkSAYZxbPmiBaO(this, ooNHsZaBAtsOMtjG(ceMjwrubrNsqOfAX(this), i));
    }
}

