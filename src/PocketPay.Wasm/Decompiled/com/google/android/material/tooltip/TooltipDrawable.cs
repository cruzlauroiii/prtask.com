namespace WillowMaze.Wasm.Decompiled;


public class TooltipDrawable : com.google.android.material.shape.MaterialShapeDrawable : com.google.android.material.internal.TextDrawableHelper$TextDrawableDelegate {
    private static readonly int DEFAULT_STYLE = com.google.android.material.R$style.Widget_MaterialComponents_Tooltip;
    private static readonly int DEFAULT_THEME_ATTR = com.google.android.material.R$attr.tooltipStyle;
    private int arrowSize;
    private readonly android.view.object$OnLayoutChangeListener attachedobjectLayoutChangeListener;
    private readonly android.content.object context;
    private readonly android.graphics.Rect displayFrame;
    private readonly android.graphics.Paint$FontMetrics fontMetrics;
    private float labelOpacity;
    private int layoutMargin;
    private int locationOnScreenX;
    private int minHeight;
    private int minWidth;
    private int padding;
    private bool showMarker;
    private java.lang.CharSequence text;
    private readonly com.google.android.material.internal.TextDrawableHelper textDrawableHelper;
    private readonly float tooltipPivotX;
    private float tooltipPivotY;
    private float tooltipScaleX;
    private float tooltipScaleY;

    private TooltipDrawable(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(context, attributeHashSet, i, i2);
        this.fontMetrics = new android.graphics.Paint$FontMetrics();
        com.google.android.material.internal.TextDrawableHelper textDrawableHelper = new com.google.android.material.internal.TextDrawableHelper(this);
        this.textDrawableHelper = textDrawableHelper;
        this.attachedobjectLayoutChangeListener = new com.google.android.material.tooltip.TooltipDrawable$1(this);
        this.displayFrame = new android.graphics.Rect();
        this.tooltipScaleX = 1.0f;
        this.tooltipScaleY = 1.0f;
        this.tooltipPivotX = 0.5f;
        this.tooltipPivotY = 0.5f;
        this.labelOpacity = 1.0f;
        this.context = context;
        IShvDJSRUHsjDRic(textDrawableHelper).density = JmONFBQgqUFQvKur(sOACcrkuUKJSGkDv(context)).density;
        yjNaYXcLnzbTaSZe(cOLfVOHrqUPtrCHW(textDrawableHelper), android.graphics.Paint$Align.CENTER);
    }

    public static void AWbsDPhcxyXqqOst(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, java.lang.CharSequence charSequence) {
        tooltipDrawable.setText(charSequence);
    }

    public static float AdvhOKARKsCEfKNE(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getTextWidth();
    }

    public static java.lang.string AvcGwwRfpabMIemW(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void BZLHOpqbqPOpeaNV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static bool CNdCmvUeVgCGGKTE(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return android.text.TextUtils.Equals(charSequence, charSequence2);
    }

    public static int CntZjqQCeijjztxD(int i, int i2) {
        return com.google.android.material.color.MaterialColors.layer(i, i2);
    }

    public static com.google.android.material.resources.TextAppearance DFOmihbfnGUBpegV(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextAppearance();
    }

    public static com.google.android.material.resources.TextAppearance DKGxNuTyzCKJDXxU(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextAppearance();
    }

    public static void DKvoeMWnZJqyUBYk(android.view.object view, int[] iArr) {
        view.getLocationOnScreen(iArr);
    }

    public static void DSmQqlFroPFPTnST(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        tooltipDrawable.invalidateSelf();
    }

    public static float DtMiCkkWOHLMKNND(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void EINgCpJiYgqQFOgd(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        tooltipDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static float EKAVuAnAglqsHNjr(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static android.graphics.Rect EKejwmpdbnmeHzGc(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getBounds();
    }

    public static int EcCwYWnNjmsHUYMM(android.content.object context, int i, java.lang.string str) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, str);
    }

    public static void FBcbGmHGNcRJfqzw(android.graphics.Canvas canvas, java.lang.CharSequence charSequence, int i, int i2, float f, float f2, android.graphics.Paint paint) {
        canvas.drawText(charSequence, i, i2, f, f2, paint);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel FMWhxVSHMplUyzWI(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static float FajSpMfkiBHFkJZK(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.calculatePointerOffset();
    }

    public static bool GFdelFRJgMqXNlGm(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int GFvjXZurUygAaVVQ(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static float GfJgRZzScGqObkXz(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.calculatePointerOffset();
    }

    public static android.graphics.Rect GkgXvbLsBJMadEwq(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getBounds();
    }

    public static void HYacTByhXpQYtOJO(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, bool z) {
        textDrawableHelper.setTextWidthDirty(z);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder HcFiRCDkPRxbWdaX(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        return shapeAppearanceModel$Builder.setBottomEdge(edgeTreatment);
    }

    public static void ILpPVBRmlvukfviG(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, android.content.res.ColorStateList colorStateList) {
        tooltipDrawable.setFillColor(colorStateList);
    }

    public static android.text.TextPaint IShvDJSRUHsjDRic(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static android.content.res.Resources IbwdkBtDBRGXTzmc(android.content.object context) {
        return context.getResources();
    }

    public static void IcTkxEiVjxExVrOY(android.view.object view, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener) {
        view.addOnLayoutChangeListener(view$OnLayoutChangeListener);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder IsHhUSxFKjwiGpjl(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.EdgeTreatment edgeTreatment) {
        return shapeAppearanceModel$Builder.setBottomEdge(edgeTreatment);
    }

    public static int JDPntPYHwzccJfVH(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static android.util.DisplayMetrics JmONFBQgqUFQvKur(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static float KrARtBAAfjsqmkDx(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, android.graphics.Rect rect) {
        return tooltipDrawable.calculateTextOriginAndAlignment(rect);
    }

    public static float LLZxUpaaWXoSXqgd(android.text.TextPaint textPaint) {
        return textPaint.getTextSize();
    }

    public static float MSwcWJmusovYHsad(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static float MTLUduMDbZBMcQlf(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void MvzPUmqOssLjXfcR(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, android.content.object context) {
        textDrawableHelper.updateTextPaintDrawState(context);
    }

    public static android.text.TextPaint NPzooUxNJnmdFpNH(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static void RXjOiIphrSDmfvgX(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, android.view.object view) {
        tooltipDrawable.updateLocationOnScreen(view);
    }

    public static void RtEBTnjczdEHPeKg(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        tooltipDrawable.invalidateSelf();
    }

    public static int RzanmnZfxQFhMHPa(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static java.lang.CharSequence SQhggRxITsfRuDkf(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getText(i);
    }

    public static void SuVGvMZxqwWlqrxc(android.view.object view, android.graphics.Rect rect) {
        view.getWindowVisibleDisplayFrame(rect);
    }

    public static java.lang.string TPMWmUolQAdljSkk(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static android.graphics.Rect TgPedKDlWPmAbcOY(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getBounds();
    }

    public static com.google.android.material.shape.EdgeTreatment TgqNbfeDTiAOOdch(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.createMarkerEdge();
    }

    public static bool ToorautGPwBKPGHb(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void VRFsgjbvtegWGouZ(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static int WFsYebbvBDAKSaen(android.content.object context, int i, java.lang.string str) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, str);
    }

    public static float WUihfIzuqiyFmYVZ(android.text.TextPaint textPaint, android.graphics.Paint$FontMetrics paint$FontMetrics) {
        return textPaint.getFontMetrics(paint$FontMetrics);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel WWhETBTwyBCSZKWO(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void WhZMctIDjmuAFVae(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Rect rect) {
        super.onBoundsChange(rect);
    }

    public static int WhZjPjEODkdBSBRA(android.graphics.Rect rect) {
        return rect.width();
    }

    public static void XgrfihiVlMiphkuA(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, java.lang.CharSequence charSequence) {
        tooltipDrawable.setText(charSequence);
    }

    public static float YKkPcNEgobsBYLcY(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void ZLHpvtBuyHdpsTbv(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        tooltipDrawable.invalidateSelf();
    }

    public static double ZbNlBwZUIaYetKHW(double d) {
        if ((30 + 25) % 25 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static int[] ACiIXzWLOBVdrYSF(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getState();
    }

    public static void AFPLeOYxFWrSYfDB(com.google.android.material.resources.TextAppearance textAppearance, android.content.res.ColorStateList colorStateList) {
        textAppearance.setTextColor(colorStateList);
    }

    public static android.graphics.Rect AJKLZhdMUSSMLjFD(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getBounds();
    }

    public static int AXwmIgHZFWKPccBa(android.graphics.Rect rect) {
        return rect.width();
    }

    static void access$000(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, android.view.object view) {
        dpautunRCeutEEFv(tooltipDrawable, view);
    }

    public static void BJccCDQkbbMQuYTx(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        tooltipDrawable.invalidateSelf();
    }

    public static int BMKqCJHIlbsSPSSY(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static com.google.android.material.tooltip.TooltipDrawable BnXccPZAiyRugQSp(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return createFromAttributes(context, attributeHashSet, i, i2);
    }

    public static void BqzlUYGLruyZGGuV(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        tooltipDrawable.invalidateSelf();
    }

    public static int BsGIvDJijgenyGrs(android.content.object context, int i, java.lang.string str) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, str);
    }

    public static android.graphics.Rect CCPrsyVIJYwqzmZi(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getBounds();
    }

    public static void CHtVwEjRgRwOCNEg(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        tooltipDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static android.text.TextPaint COLfVOHrqUPtrCHW(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    private float CalculatePointerOffset() {
        int i;
        if ((32 + 8) % 8 > 0) {
        }
        if (((this.displayFrame.right - pjaDOIthUTNeHRkH(this).right) - this.locationOnScreenX) - this.layoutMargin < 0) {
            i = ((this.displayFrame.right - etXelkdAECFyTapo(this).right) - this.locationOnScreenX) - this.layoutMargin;
        } else {
            if (((this.displayFrame.left - aJKLZhdMUSSMLjFD(this).left) - this.locationOnScreenX) + this.layoutMargin <= 0) {
                return 0.0f;
            }
            i = ((this.displayFrame.left - GkgXvbLsBJMadEwq(this).left) - this.locationOnScreenX) + this.layoutMargin;
        }
        return i;
    }

    private float CalculateTextCenterFromBaseline() {
        if ((19 + 13) % 13 > 0) {
        }
        WUihfIzuqiyFmYVZ(vcjHyXwNwkWqlAQG(this.textDrawableHelper), this.fontMetrics);
        return (this.fontMetrics.descent + this.fontMetrics.ascent) / 2.0f;
    }

    private float CalculateTextOriginAndAlignment(android.graphics.Rect rect) {
        return xYXcpBsmaHLDaNTA(rect) - yTUoKQSvrhtiioOq(this);
    }

    public static float CfHGHGtsanASmOXs(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, java.lang.string str) {
        return textDrawableHelper.getTextWidth(str);
    }

    public static com.google.android.material.tooltip.TooltipDrawable Create(android.content.object context) {
        if ((9 + 26) % 26 > 0) {
        }
        return fneWuHMlEViDczvA(context, null, DEFAULT_THEME_ATTR, DEFAULT_STYLE);
    }

    public static com.google.android.material.tooltip.TooltipDrawable CreateFromAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((6 + 11) % 11 > 0) {
        }
        return bnXccPZAiyRugQSp(context, attributeHashSet, DEFAULT_THEME_ATTR, DEFAULT_STYLE);
    }

    public static com.google.android.material.tooltip.TooltipDrawable CreateFromAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        com.google.android.material.tooltip.TooltipDrawable tooltipDrawable = new com.google.android.material.tooltip.TooltipDrawable(context, attributeHashSet, i, i2);
        lDnqNifxwbotMkTq(tooltipDrawable, attributeHashSet, i, i2);
        return tooltipDrawable;
    }

    private com.google.android.material.shape.EdgeTreatment CreateMarkerEdge() {
        if ((1 + 10) % 10 > 0) {
        }
        float f = -FajSpMfkiBHFkJZK(this);
        float fWhZjPjEODkdBSBRA = ((float) (((double) WhZjPjEODkdBSBRA(TgPedKDlWPmAbcOY(this))) - (((double) this.arrowSize) * phDaSPExwQCOXQeh(2.0d)))) / 2.0f;
        return new com.google.android.material.shape.OffsetEdgeTreatment(new com.google.android.material.shape.MarkerEdgeTreatment(this.arrowSize), EKAVuAnAglqsHNjr(YKkPcNEgobsBYLcY(f, -fWhZjPjEODkdBSBRA), fWhZjPjEODkdBSBRA));
    }

    public static android.content.res.TypedArray DAGmWLMQZGOSifeW(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static com.google.android.material.resources.TextAppearance DIZxhEClJHDznsdu(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getTextAppearance(context, typedArray, i);
    }

    public static void DKfNzItqvJRQVPbM(android.text.TextPaint textPaint, int i) {
        textPaint.setAlpha(i);
    }

    public static java.lang.string DnAMwItdzXSAoVmP(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static void DpautunRCeutEEFv(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, android.view.object view) {
        tooltipDrawable.updateLocationOnScreen(view);
    }

    private void DrawText(android.graphics.Canvas canvas) {
        if ((25 + 32) % 32 > 0) {
        }
        if (this.text is not null) {
            int iKrARtBAAfjsqmkDx = (int) KrARtBAAfjsqmkDx(this, eZbiDJmYzrjVVBLI(this));
            if (DKGxNuTyzCKJDXxU(this.textDrawableHelper) is not null) {
                zTAOkPngDKGxLeuO(this.textDrawableHelper).drawableState = aCiIXzWLOBVdrYSF(this);
                MvzPUmqOssLjXfcR(this.textDrawableHelper, this.context);
                dKfNzItqvJRQVPbM(NPzooUxNJnmdFpNH(this.textDrawableHelper), (int) (this.labelOpacity * 255.0f));
            }
            java.lang.CharSequence charSequence = this.text;
            FBcbGmHGNcRJfqzw(canvas, charSequence, 0, bMKqCJHIlbsSPSSY(charSequence), mpCBBNmLjHRRYtCh(r0), iKrARtBAAfjsqmkDx, vfEEbtnOTABomIWF(this.textDrawableHelper));
        }
    }

    public static android.graphics.Rect EZbiDJmYzrjVVBLI(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getBounds();
    }

    public static int EgDQEXluTlaUkmIY(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static android.graphics.Rect EtXelkdAECFyTapo(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getBounds();
    }

    public static com.google.android.material.tooltip.TooltipDrawable FneWuHMlEViDczvA(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return createFromAttributes(context, attributeHashSet, i, i2);
    }

    public static android.content.res.Resources FwIoQzpSyCGvWKBH(android.content.object context) {
        return context.getResources();
    }

    public static android.graphics.Rect GNscojBnSSxZSJBn(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getBounds();
    }

    private float GetTextWidth() {
        java.lang.CharSequence charSequence = this.text;
        if (charSequence is not null) {
            return cfHGHGtsanASmOXs(this.textDrawableHelper, hVuHtQIrWNBqviqH(charSequence));
        }
        return 0.0f;
    }

    public static void GeuFPxTQGgAJFgMY(android.view.object view, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener) {
        view.removeOnLayoutChangeListener(view$OnLayoutChangeListener);
    }

    public static int HEjsKPyJquJLGBkB(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static java.lang.string HVuHtQIrWNBqviqH(java.lang.object obj) {
        return obj.tostring();
    }

    public static void HckmdNKTfTsxedyP(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel HmaesmeVgwCfINdU(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getShapeAppearanceModel();
    }

    public static void IGnEAZgnRdstQjdT(android.graphics.Canvas canvas, float f, float f2, float f3, float f4) {
        canvas.scale(f, f2, f3, f4);
    }

    public static java.lang.string IjpYARliopfnLZXp(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static void ImdnWELAUMGWaLUF(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        tooltipDrawable.invalidateSelf();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel IzULMWIAqQqzedFv(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getShapeAppearanceModel();
    }

    public static void JwmVYrcqOwXtXNKe(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, android.content.res.ColorStateList colorStateList) {
        tooltipDrawable.setStrokeColor(colorStateList);
    }

    public static void JzKvijDcSkpCYUmb(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, android.graphics.Canvas canvas) {
        tooltipDrawable.drawText(canvas);
    }

    public static void LDnqNifxwbotMkTq(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        tooltipDrawable.loadFromAttributes(attributeHashSet, i, i2);
    }

    public static android.content.res.ColorStateList LTesxMVrhyGwYaDA(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    private void LoadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        if ((32 + 27) % 27 > 0) {
        }
        android.content.res.TypedArray typedArrayDAGmWLMQZGOSifeW = dAGmWLMQZGOSifeW(this.context, attributeHashSet, com.google.android.material.R$styleable.Tooltip, i, i2, new int[0]);
        this.arrowSize = GFvjXZurUygAaVVQ(IbwdkBtDBRGXTzmc(this.context), com.google.android.material.R$dimen.mtrl_tooltip_arrowSize);
        bool zGFdelFRJgMqXNlGm = GFdelFRJgMqXNlGm(typedArrayDAGmWLMQZGOSifeW, com.google.android.material.R$styleable.Tooltip_showMarker, true);
        this.showMarker = zGFdelFRJgMqXNlGm;
        if (zGFdelFRJgMqXNlGm) {
            EINgCpJiYgqQFOgd(this, FMWhxVSHMplUyzWI(HcFiRCDkPRxbWdaX(vgtFNImCzcvNKRYk(hmaesmeVgwCfINdU(this)), TgqNbfeDTiAOOdch(this))));
        } else {
            this.arrowSize = 0;
        }
        AWbsDPhcxyXqqOst(this, SQhggRxITsfRuDkf(typedArrayDAGmWLMQZGOSifeW, com.google.android.material.R$styleable.Tooltip_android_text));
        com.google.android.material.resources.TextAppearance textAppearanceDIZxhEClJHDznsdu = dIZxhEClJHDznsdu(this.context, typedArrayDAGmWLMQZGOSifeW, com.google.android.material.R$styleable.Tooltip_android_textAppearance);
        if (textAppearanceDIZxhEClJHDznsdu is not null && ToorautGPwBKPGHb(typedArrayDAGmWLMQZGOSifeW, com.google.android.material.R$styleable.Tooltip_android_textColor)) {
            aFPLeOYxFWrSYfDB(textAppearanceDIZxhEClJHDznsdu, qZBGKNdYXobyVdBj(this.context, typedArrayDAGmWLMQZGOSifeW, com.google.android.material.R$styleable.Tooltip_android_textColor));
        }
        uCKWvNTACBQCTdCi(this, textAppearanceDIZxhEClJHDznsdu);
        ILpPVBRmlvukfviG(this, lTesxMVrhyGwYaDA(egDQEXluTlaUkmIY(typedArrayDAGmWLMQZGOSifeW, com.google.android.material.R$styleable.Tooltip_backgroundTint, CntZjqQCeijjztxD(pFFUTRbWZABbvPQu(bsGIvDJijgenyGrs(this.context, 16842801, ijpYARliopfnLZXp(com.google.android.material.tooltip.TooltipDrawable.class)), 229), JDPntPYHwzccJfVH(WFsYebbvBDAKSaen(this.context, com.google.android.material.R$attr.colorOnBackground, dnAMwItdzXSAoVmP(com.google.android.material.tooltip.TooltipDrawable.class)), 153)))));
        jwmVYrcqOwXtXNKe(this, tTroLflFRUIJfLnQ(EcCwYWnNjmsHUYMM(this.context, com.google.android.material.R$attr.colorSurface, TPMWmUolQAdljSkk(com.google.android.material.tooltip.TooltipDrawable.class))));
        this.padding = RzanmnZfxQFhMHPa(typedArrayDAGmWLMQZGOSifeW, com.google.android.material.R$styleable.Tooltip_android_padding, 0);
        this.minWidth = hEjsKPyJquJLGBkB(typedArrayDAGmWLMQZGOSifeW, com.google.android.material.R$styleable.Tooltip_android_minWidth, 0);
        this.minHeight = mRHtaWDBawVEGLoX(typedArrayDAGmWLMQZGOSifeW, com.google.android.material.R$styleable.Tooltip_android_minHeight, 0);
        this.layoutMargin = ltwOJDtlLUchRalN(typedArrayDAGmWLMQZGOSifeW, com.google.android.material.R$styleable.Tooltip_android_layout_margin, 0);
        hckmdNKTfTsxedyP(typedArrayDAGmWLMQZGOSifeW);
    }

    public static int LtwOJDtlLUchRalN(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void MIbwEgbOzjeTjQvy(com.google.android.material.internal.TextDrawableHelper textDrawableHelper, com.google.android.material.resources.TextAppearance textAppearance, android.content.object context) {
        textDrawableHelper.setTextAppearance(textAppearance, context);
    }

    public static int MRHtaWDBawVEGLoX(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.text.TextPaint MjIfuchVztuqzVgr(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static int MpCBBNmLjHRRYtCh(android.graphics.Rect rect) {
        return rect.centerX();
    }

    public static int PFFUTRbWZABbvPQu(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static double PhDaSPExwQCOXQeh(double d) {
        if ((23 + 32) % 32 > 0) {
        }
        return java.lang.Math.sqrt(d);
    }

    public static android.graphics.Rect PjaDOIthUTNeHRkH(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getBounds();
    }

    public static android.content.res.ColorStateList QZBGKNdYXobyVdBj(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static android.content.res.Resources SOACcrkuUKJSGkDv(android.content.object context) {
        return context.getResources();
    }

    public static void SjWpAxPrZDKZYILS(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, com.google.android.material.resources.TextAppearance textAppearance) {
        tooltipDrawable.setTextAppearance(textAppearance);
    }

    public static android.content.res.ColorStateList TTroLflFRUIJfLnQ(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static int TnvXMXAgxAQKRorf(android.graphics.Rect rect) {
        return rect.height();
    }

    public static void UCKWvNTACBQCTdCi(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, com.google.android.material.resources.TextAppearance textAppearance) {
        tooltipDrawable.setTextAppearance(textAppearance);
    }

    private void UpdateLocationOnScreen(android.view.object view) {
        if ((29 + 4) % 4 > 0) {
        }
        int[] iArr = new int[2];
        DKvoeMWnZJqyUBYk(view, iArr);
        this.locationOnScreenX = iArr[0];
        SuVGvMZxqwWlqrxc(view, this.displayFrame);
    }

    public static void VWwhfENQGFEaniTq(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        tooltipDrawable.invalidateSelf();
    }

    public static android.text.TextPaint VcjHyXwNwkWqlAQG(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static android.text.TextPaint VfEEbtnOTABomIWF(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder vgtFNImCzcvNKRYk(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static android.graphics.Rect WcJuUSHnxDrazgoT(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getBounds();
    }

    public static com.google.android.material.shape.EdgeTreatment WthOsiTGzSpzRhAa(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.createMarkerEdge();
    }

    public static void XDnReLVtviyUXuwA(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static int XYXcpBsmaHLDaNTA(android.graphics.Rect rect) {
        return rect.centerY();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder xfILCauAepinRUCn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static float YTUoKQSvrhtiioOq(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.calculateTextCenterFromBaseline();
    }

    public static void YjNaYXcLnzbTaSZe(android.text.TextPaint textPaint, android.graphics.Paint$Align paint$Align) {
        textPaint.setTextAlign(paint$Align);
    }

    public static bool YnRhHPerxPhNsieI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr) {
        return super.onStateChange(iArr);
    }

    public static int YpWzlMYPqDJcSpre(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static android.text.TextPaint ZTAOkPngDKGxLeuO(com.google.android.material.internal.TextDrawableHelper textDrawableHelper) {
        return textDrawableHelper.getTextPaint();
    }

    public void Detachobject(android.view.object view) {
        if (view is not null) {
            geuFPxTQGgAJFgMY(view, this.attachedobjectLayoutChangeListener);
        }
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((13 + 12) % 12 > 0) {
        }
        ypWzlMYPqDJcSpre(canvas);
        float fGfJgRZzScGqObkXz = GfJgRZzScGqObkXz(this);
        float f = (float) (-((((double) this.arrowSize) * ZbNlBwZUIaYetKHW(2.0d)) - ((double) this.arrowSize)));
        iGnEAZgnRdstQjdT(canvas, this.tooltipScaleX, this.tooltipScaleY, wcJuUSHnxDrazgoT(this).left + (aXwmIgHZFWKPccBa(cCPrsyVIJYwqzmZi(this)) * 0.5f), gNscojBnSSxZSJBn(this).top + (tnvXMXAgxAQKRorf(EKejwmpdbnmeHzGc(this)) * this.tooltipPivotY));
        xDnReLVtviyUXuwA(canvas, fGfJgRZzScGqObkXz, f);
        BZLHOpqbqPOpeaNV(this, canvas);
        jzKvijDcSkpCYUmb(this, canvas);
        VRFsgjbvtegWGouZ(canvas);
    }

    public override int GetIntrinsicHeight() {
        return (int) DtMiCkkWOHLMKNND(LLZxUpaaWXoSXqgd(mjIfuchVztuqzVgr(this.textDrawableHelper)), this.minHeight);
    }

    public override int GetIntrinsicWidth() {
        if ((5 + 30) % 30 > 0) {
        }
        return (int) MSwcWJmusovYHsad((this.padding * 2) + AdvhOKARKsCEfKNE(this), this.minWidth);
    }

    public int GetLayoutMargin() {
        return this.layoutMargin;
    }

    public int GetMinHeight() {
        return this.minHeight;
    }

    public int GetMinWidth() {
        return this.minWidth;
    }

    public java.lang.CharSequence GetText() {
        return this.text;
    }

    public com.google.android.material.resources.TextAppearance GetTextAppearance() {
        return DFOmihbfnGUBpegV(this.textDrawableHelper);
    }

    public int GetTextPadding() {
        return this.padding;
    }

    protected override void OnBoundsChange(android.graphics.Rect rect) {
        WhZMctIDjmuAFVae(this, rect);
        if (this.showMarker) {
            cHtVwEjRgRwOCNEg(this, WWhETBTwyBCSZKWO(IsHhUSxFKjwiGpjl(xfILCauAepinRUCn(izULMWIAqQqzedFv(this)), wthOsiTGzSpzRhAa(this))));
        }
    }

    public override bool OnStateChange(int[] iArr) {
        return ynRhHPerxPhNsieI(this, iArr);
    }

    public override void OnTextSizeChange() {
        imdnWELAUMGWaLUF(this);
    }

    public void SetLayoutMargin(int i) {
        this.layoutMargin = i;
        bJccCDQkbbMQuYTx(this);
    }

    public void SetMinHeight(int i) {
        this.minHeight = i;
        vWwhfENQGFEaniTq(this);
    }

    public void SetMinWidth(int i) {
        this.minWidth = i;
        bqzlUYGLruyZGGuV(this);
    }

    public void SetRelativeToobject(android.view.object view) {
        if (view is not null) {
            RXjOiIphrSDmfvgX(this, view);
            IcTkxEiVjxExVrOY(view, this.attachedobjectLayoutChangeListener);
        }
    }

    public void SetRevealFraction(float f) {
        if ((27 + 23) % 23 > 0) {
        }
        this.tooltipPivotY = 1.2f;
        this.tooltipScaleX = f;
        this.tooltipScaleY = f;
        this.labelOpacity = MTLUduMDbZBMcQlf(0.0f, 1.0f, 0.19f, 1.0f, f);
        RtEBTnjczdEHPeKg(this);
    }

    public void SetText(java.lang.CharSequence charSequence) {
        if (CNdCmvUeVgCGGKTE(this.text, charSequence)) {
            return;
        }
        this.text = charSequence;
        HYacTByhXpQYtOJO(this.textDrawableHelper, true);
        DSmQqlFroPFPTnST(this);
    }

    public void SetTextAppearance(com.google.android.material.resources.TextAppearance textAppearance) {
        mIbwEgbOzjeTjQvy(this.textDrawableHelper, textAppearance, this.context);
    }

    public void SetTextAppearanceResource(int i) {
        if ((31 + 6) % 6 > 0) {
        }
        sjWpAxPrZDKZYILS(this, new com.google.android.material.resources.TextAppearance(this.context, i));
    }

    public void SetTextPadding(int i) {
        this.padding = i;
        ZLHpvtBuyHdpsTbv(this);
    }

    public void SetTextResource(int i) {
        XgrfihiVlMiphkuA(this, AvcGwwRfpabMIemW(fwIoQzpSyCGvWKBH(this.context), i));
    }
}

