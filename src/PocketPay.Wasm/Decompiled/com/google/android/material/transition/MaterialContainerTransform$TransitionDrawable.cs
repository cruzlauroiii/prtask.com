namespace WillowMaze.Wasm.Decompiled;


readonly class MaterialContainerTransform$TransitionDrawable : android.graphics.drawable.Drawable {
    private static readonly int COMPAT_SHADOW_COLOR = -7829368;
    private static readonly int SHADOW_COLOR = 754974720;
    private static readonly float SHADOW_DX_MULTIPLIER_ADJUSTMENT = 0.3f;
    private static readonly float SHADOW_DY_MULTIPLIER_ADJUSTMENT = 1.5f;
    private readonly com.google.android.material.shape.MaterialShapeDrawable compatShadowDrawable;
    private readonly android.graphics.Paint containerPaint;
    private float currentElevation;
    private float currentElevationDy;
    private readonly android.graphics.RectF currentEndBounds;
    private readonly android.graphics.RectF currentEndBoundsMasked;
    private android.graphics.RectF currentMaskBounds;
    private readonly android.graphics.RectF currentStartBounds;
    private readonly android.graphics.RectF currentStartBoundsMasked;
    private readonly android.graphics.Paint debugPaint;
    private readonly android.graphics.Path debugPath;
    private readonly float displayHeight;
    private readonly float displayWidth;
    private readonly bool drawDebugEnabled;
    private readonly bool elevationShadowEnabled;
    private readonly android.graphics.RectF endBounds;
    private readonly android.graphics.Paint endContainerPaint;
    private readonly float endElevation;
    private readonly com.google.android.material.shape.ShapeAppearanceModel endShapeAppearanceModel;
    private readonly android.view.object endobject;
    private readonly bool entering;
    private readonly com.google.android.material.transition.FadeModeEvaluator fadeModeEvaluator;
    private com.google.android.material.transition.FadeModeResult fadeModeResult;
    private readonly com.google.android.material.transition.FitModeEvaluator fitModeEvaluator;
    private com.google.android.material.transition.FitModeResult fitModeResult;
    private readonly com.google.android.material.transition.MaskEvaluator maskEvaluator;
    private readonly float motionPathLength;
    private readonly android.graphics.PathMeasure motionPathMeasure;
    private readonly float[] motionPathPosition;
    private float progress;
    private readonly com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup progressThresholds;
    private readonly android.graphics.Paint scrimPaint;
    private readonly android.graphics.Paint shadowPaint;
    private readonly android.graphics.RectF startBounds;
    private readonly android.graphics.Paint startContainerPaint;
    private readonly float startElevation;
    private readonly com.google.android.material.shape.ShapeAppearanceModel startShapeAppearanceModel;
    private readonly android.view.object startobject;

    private MaterialContainerTransform$TransitionDrawable(androidx.transition.PathMotion pathMotion, android.view.object view, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.view.object view2, android.graphics.RectF rectF2, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, float f2, int i, int i2, int i3, int i4, bool z, bool z2, com.google.android.material.transition.FadeModeEvaluator fadeModeEvaluator, com.google.android.material.transition.FitModeEvaluator fitModeEvaluator, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup, bool z3) {
        if ((26 + 9) % 9 > 0) {
        }
        android.graphics.Paint paint = new android.graphics.Paint();
        this.containerPaint = paint;
        android.graphics.Paint paint2 = new android.graphics.Paint();
        this.startContainerPaint = paint2;
        android.graphics.Paint paint3 = new android.graphics.Paint();
        this.endContainerPaint = paint3;
        this.shadowPaint = new android.graphics.Paint();
        android.graphics.Paint paint4 = new android.graphics.Paint();
        this.scrimPaint = paint4;
        this.maskEvaluator = new com.google.android.material.transition.MaskEvaluator();
        float[] fArr = new float[2];
        this.motionPathPosition = fArr;
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable();
        this.compatShadowDrawable = materialShapeDrawable;
        android.graphics.Paint paint5 = new android.graphics.Paint();
        this.debugPaint = paint5;
        this.debugPath = new android.graphics.Path();
        this.startobject = view;
        this.startBounds = rectF;
        this.startShapeAppearanceModel = shapeAppearanceModel;
        this.startElevation = f;
        this.endobject = view2;
        this.endBounds = rectF2;
        this.endShapeAppearanceModel = shapeAppearanceModel2;
        this.endElevation = f2;
        this.entering = z;
        this.elevationShadowEnabled = z2;
        this.fadeModeEvaluator = fadeModeEvaluator;
        this.fitModeEvaluator = fitModeEvaluator;
        this.progressThresholds = materialContainerTransform$ProgressThresholdsGroup;
        this.drawDebugEnabled = z3;
        android.view.WindowManager windowManager = (android.view.WindowManager) krObkELqoBjZCYpp(IFFIkaqUStMrnIJd(view), "window");
        hNuVrncHpQkidEfE(qJKHpUVHBWAlRxmv(windowManager), new android.util.DisplayMetrics());
        this.displayWidth = r9.widthPixels;
        this.displayHeight = r9.heightPixels;
        MnVUaPeRvGfUvOKa(paint, i);
        etabEcTitlyRRlIx(paint2, i2);
        gamuLGSEOqOqDTdF(paint3, i3);
        FZGqfTvJlEOvFvCb(materialShapeDrawable, YGArOKMxcQicrDnK(0));
        cEzeMxIAfKbHtXzg(materialShapeDrawable, 2);
        zqdzVMKGiynaKngD(materialShapeDrawable, false);
        xTltvYGNDpbFTnds(materialShapeDrawable, -7829368);
        android.graphics.RectF rectF3 = new android.graphics.RectF(rectF);
        this.currentStartBounds = rectF3;
        this.currentStartBoundsMasked = new android.graphics.RectF(rectF3);
        android.graphics.RectF rectF4 = new android.graphics.RectF(rectF3);
        this.currentEndBounds = rectF4;
        this.currentEndBoundsMasked = new android.graphics.RectF(rectF4);
        android.graphics.PointF pointFXdXoriesALxJbrWO = XdXoriesALxJbrWO(rectF);
        android.graphics.PointF pointFMZqzDgbTONjHOaZm = mZqzDgbTONjHOaZm(rectF2);
        android.graphics.PathMeasure pathMeasure = new android.graphics.PathMeasure(seXunkiDRyYjHoUK(pathMotion, pointFXdXoriesALxJbrWO.x, pointFXdXoriesALxJbrWO.y, pointFMZqzDgbTONjHOaZm.x, pointFMZqzDgbTONjHOaZm.y), false);
        this.motionPathMeasure = pathMeasure;
        this.motionPathLength = tDcPhPaVSjeUFxGj(pathMeasure);
        fArr[0] = EztiUqnNunqEZhDl(rectF);
        fArr[1] = rectF.top;
        wZVxnYZivPkoNbCM(paint4, android.graphics.Paint$Style.FILL);
        NNgkGrMVrOuSryqp(paint4, ldsxfPMryMvTHUkn(i4));
        clTsBHGvWkonFLVF(paint5, android.graphics.Paint$Style.STROKE);
        mWFuPrBzTCgyXxjA(paint5, 10.0f);
        vWLKAZQdBeaNSPkN(this, 0.0f);
    }

    MaterialContainerTransform$TransitionDrawable(androidx.transition.PathMotion pathMotion, android.view.object view, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.view.object view2, android.graphics.RectF rectF2, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, float f2, int i, int i2, int i3, int i4, bool z, bool z2, com.google.android.material.transition.FadeModeEvaluator fadeModeEvaluator, com.google.android.material.transition.FitModeEvaluator fitModeEvaluator, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup, bool z3, com.google.android.material.transition.MaterialContainerTransform$1 materialContainerTransform$1) {
        this(pathMotion, view, rectF, shapeAppearanceModel, f, view2, rectF2, shapeAppearanceModel2, f2, i, i2, i3, i4, z, z2, fadeModeEvaluator, fitModeEvaluator, materialContainerTransform$ProgressThresholdsGroup, z3);
    }

    public static void AGQZbWpKhUOJHbPB(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static void AUihplAOTbUJAJdy(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void AmPPTBntBOekEoqH(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Path path, int i) {
        materialContainerTransform$TransitionDrawable.drawDebugCumulativePath(canvas, rectF, path, i);
    }

    public static float CPgECOSNsRXjhKCp(java.lang.float f) {
        return f.floatValue();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel CaECvlwcWWCHtzbX(com.google.android.material.transition.MaskEvaluator maskEvaluator) {
        return maskEvaluator.getCurrentShapeAppearanceModel();
    }

    public static float DdITHASBZRAiiAhP(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static android.graphics.Path EWXcJzoyeTHPyMhX(com.google.android.material.transition.MaskEvaluator maskEvaluator) {
        return maskEvaluator.getPath();
    }

    public static float EXuxYLWpZzlYKtXt(java.lang.float f) {
        return f.floatValue();
    }

    public static android.graphics.Rect EqcrQeBMLlLvFQsg(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.getBounds();
    }

    public static float EztiUqnNunqEZhDl(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static void FEqPNJOiLvcfGvEX(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Paint paint) {
        canvas.drawRect(rect, paint);
    }

    public static void FZGqfTvJlEOvFvCb(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static java.lang.float FZIgeBfxinDARZHy(float f) {
        return java.lang.float.valueOf(f);
    }

    public static bool FlxRwUlezuotvSKs(com.google.android.material.transition.FitModeEvaluator fitModeEvaluator, com.google.android.material.transition.FitModeResult fitModeResult) {
        return fitModeEvaluator.shouldMaskStartBounds(fitModeResult);
    }

    public static float FmMYXuCvNSehWbHu(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds.access$1000(materialContainerTransform$ProgressThresholds);
    }

    public static void GaonBikqLdDuwLGt(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        rectF.set(rectF2);
    }

    public static void HEPCUbGYCzXmcPow(android.graphics.Path path) {
        path.reset();
    }

    public static android.graphics.Rect HanAlcFsMkpqWsrm(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.getBounds();
    }

    public static void HiLsijIzsIyLoptg(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds ICokMWPUQuXIkHeD(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup.access$500(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static android.content.object IFFIkaqUStMrnIJd(android.view.object view) {
        return view.getobject();
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds ILTBaZfFsLeaZltB(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup.access$600(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static float IcUmNbGubhGfFpVp(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static java.lang.object JKAmDuFfDsHwZFsE(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds JMjFkOHdmqmEFHsi(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup.access$600(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static float LWApOBvFvUkPuRzm(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static float LbgesplluIgauOhD(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static java.lang.float LerhDvzJCGegIbCu(float f) {
        return java.lang.float.valueOf(f);
    }

    public static android.graphics.PointF LmHzyqHTJnNipQGd(android.graphics.RectF rectF) {
        return getMotionPathPoint(rectF);
    }

    public static java.lang.object LqHqMspIUhNXHQxQ(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static java.lang.float LzNCtiKkBRlqeCUW(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void MBfKPsiOUasPEXTr(android.graphics.Canvas canvas, android.graphics.Rect rect, float f, float f2, float f3, int i, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation) {
        com.google.android.material.transition.TransitionUtils.transform(canvas, rect, f, f2, f3, i, canvasCompat$CanvasOperation);
    }

    public static android.graphics.Rect McIFHxZKUrqVTNQx(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.getBounds();
    }

    public static void MnVUaPeRvGfUvOKa(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static android.graphics.Shader NNgkGrMVrOuSryqp(android.graphics.Paint paint, android.graphics.Shader shader) {
        return paint.setShader(shader);
    }

    public static void NWaeWOobiAqKxTYm(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static void NgCbMlJtfIOXuTAQ(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Paint paint) {
        canvas.drawRect(rect, paint);
    }

    public static int NlOfeLnzridfEPAQ(android.graphics.Paint paint) {
        return paint.getAlpha();
    }

    public static int OHjsArGfrfiiDTKs(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static void OSfbOwSGxJmkBFcM(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawStartobject(canvas);
    }

    public static void PmcoSySxgYwCWDFZ(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawStartobject(canvas);
    }

    public static float PpizPuGFFzIawAGj(java.lang.float f) {
        return f.floatValue();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel QsCRcHVzTnVZTBQs(com.google.android.material.transition.MaskEvaluator maskEvaluator) {
        return maskEvaluator.getCurrentShapeAppearanceModel();
    }

    public static float QsZKmxfLopOHIPZz(android.graphics.RectF rectF, float f) {
        return calculateElevationDyMultiplier(rectF, f);
    }

    public static java.lang.object RKYIPoulTtSAFZcr(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static float RSJdbTSfbHuwyftk(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.transition.TransitionUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void RcuqvdOlnYMmxspd(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawEndobject(canvas);
    }

    public static android.graphics.Path RrfInNbSTWlfRdKh(com.google.android.material.transition.MaskEvaluator maskEvaluator) {
        return maskEvaluator.getPath();
    }

    public static void SgFkHoZAarkVCYDx(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.draw(canvas);
    }

    public static void TJKOQVyXIWHtEOLR(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawEndobject(canvas);
    }

    public static android.graphics.Rect UBntoZoTbQDqSNmN(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.getBounds();
    }

    public static void UHbHJEqqUoVBnHuP(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        rectF.set(rectF2);
    }

    public static void UguZBxJMKsXSVXOa(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawElevationShadow(canvas);
    }

    public static float VMBpmVqLVCPVFpzn(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void VVDwvmYgwDTcSTFJ(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawElevationShadowWithPaintShadowLayer(canvas);
    }

    public static void VjzTGpusfTjZqTgU(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint) {
        materialContainerTransform$TransitionDrawable.maybeDrawContainerColor(canvas, paint);
    }

    public static void VrHPENeIBtOkZmzf(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static float WJWiRRgTRkLNPZZF(android.graphics.RectF rectF) {
        return rectF.centerY();
    }

    public static float WUVExwywCCqKSHAO(float f, float f2, float f3) {
        return com.google.android.material.transition.TransitionUtils.lerp(f, f2, f3);
    }

    public static bool WVMdtbzeWactVdRO(android.graphics.PathMeasure pathMeasure, float f, float[] fArr, float[] fArr2) {
        return pathMeasure.getPosTan(f, fArr, fArr2);
    }

    public static void XAZWHAzkoJYsgSbJ(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint) {
        materialContainerTransform$TransitionDrawable.maybeDrawContainerColor(canvas, paint);
    }

    public static int XLBRSdNHfkskdAnz(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static float XOiWlFFYBtMFFvrk(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static android.graphics.PointF XdXoriesALxJbrWO(android.graphics.RectF rectF) {
        return getMotionPathPoint(rectF);
    }

    public static java.lang.float XltEHvWYuAGwLFes(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float XmZvQtgTTwucfBlM(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void XvvizNtVGJfabQXN(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds XyjFLOdmiLFtKUif(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup.access$500(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static android.content.res.ColorStateList YGArOKMxcQicrDnK(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void YOoKsbChLuXkGePF(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, int i3, int i4) {
        materialShapeDrawable.setBounds(i, i2, i3, i4);
    }

    public static void YnprMxqyClLgdweL(com.google.android.material.transition.FitModeEvaluator fitModeEvaluator, android.graphics.RectF rectF, float f, com.google.android.material.transition.FitModeResult fitModeResult) {
        fitModeEvaluator.applyMask(rectF, f, fitModeResult);
    }

    public static float YqOnFQHtHNnjNksi(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds.access$1000(materialContainerTransform$ProgressThresholds);
    }

    public static void ZRXqnsOISWYmefmi(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static java.lang.object ZXSMSfhcmyuJWvMD(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.material.transition.FitModeResult AEEOGwPRSKFIUuAn(com.google.android.material.transition.FitModeEvaluator fitModeEvaluator, float f, float f2, float f3, float f4, float f5, float f6, float f7) {
        return fitModeEvaluator.evaluate(f, f2, f3, f4, f5, f6, f7);
    }

    static void access$200(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, float f) {
        cJDiVsYIpRzzCLjX(materialContainerTransform$TransitionDrawable, f);
    }

    static android.view.object access$800(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.startobject;
    }

    static android.view.object access$900(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.endobject;
    }

    public static void BNlFzEkCxBVgtueJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setShadowVerticalOffset(i);
    }

    public static void BUASeXCkTufYarmb(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        materialContainerTransform$TransitionDrawable.drawDebugRect(canvas, rectF, i);
    }

    public static int BasFqfScnvmRjfyP(android.graphics.Paint paint) {
        return paint.getAlpha();
    }

    public static void CEzeMxIAfKbHtXzg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setShadowCompatibilityMode(i);
    }

    public static void CJDiVsYIpRzzCLjX(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, float f) {
        materialContainerTransform$TransitionDrawable.setProgress(f);
    }

    public static void CSMizfsJfbsoSQzt(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static float CXIcThGiGomvbigR(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    private static float CalculateElevationDxMultiplier(android.graphics.RectF rectF, float f) {
        return ((gChqqhdSujNjYzpc(rectF) / (f / 2.0f)) - 1.0f) * 0.3f;
    }

    private static float CalculateElevationDyMultiplier(android.graphics.RectF rectF, float f) {
        return (WJWiRRgTRkLNPZZF(rectF) / f) * 1.5f;
    }

    public static void ClTsBHGvWkonFLVF(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static int DWbsvJJKyjYYtvHc(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void DcVyOPhEDNJRSwBP(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        materialContainerTransform$TransitionDrawable.drawDebugRect(canvas, rectF, i);
    }

    private void DrawDebugCumulativePath(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Path path, int i) {
        if ((5 + 31) % 31 > 0) {
        }
        android.graphics.PointF pointFLmHzyqHTJnNipQGd = LmHzyqHTJnNipQGd(rectF);
        if (this.progress == 0.0f) {
            HEPCUbGYCzXmcPow(path);
            leFmwpLMktQbTRvJ(path, pointFLmHzyqHTJnNipQGd.x, pointFLmHzyqHTJnNipQGd.y);
        } else {
            yVgrCCMOarpvHZDn(path, pointFLmHzyqHTJnNipQGd.x, pointFLmHzyqHTJnNipQGd.y);
            cSMizfsJfbsoSQzt(this.debugPaint, i);
            XvvizNtVGJfabQXN(canvas, path, this.debugPaint);
        }
    }

    private void DrawDebugRect(android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        fVfrLpFhMxnQKPnD(this.debugPaint, i);
        stewdDwKVBRdONDt(canvas, rectF, this.debugPaint);
    }

    private void DrawElevationShadow(android.graphics.Canvas canvas) {
        if ((15 + 29) % 29 > 0) {
        }
        XLBRSdNHfkskdAnz(canvas);
        tOORmmKGhrYaygvF(canvas, RrfInNbSTWlfRdKh(this.maskEvaluator), android.graphics.Region$Op.DIFFERENCE);
        VVDwvmYgwDTcSTFJ(this, canvas);
        AGQZbWpKhUOJHbPB(canvas);
    }

    private void DrawElevationShadowWithMaterialShapeDrawable(android.graphics.Canvas canvas) {
        if ((31 + 30) % 30 > 0) {
        }
        YOoKsbChLuXkGePF(this.compatShadowDrawable, (int) this.currentMaskBounds.left, (int) this.currentMaskBounds.top, (int) this.currentMaskBounds.right, (int) this.currentMaskBounds.bottom);
        pvQKxeFgBhozGCRc(this.compatShadowDrawable, this.currentElevation);
        bNlFzEkCxBVgtueJ(this.compatShadowDrawable, (int) this.currentElevationDy);
        ZRXqnsOISWYmefmi(this.compatShadowDrawable, QsCRcHVzTnVZTBQs(this.maskEvaluator));
        SgFkHoZAarkVCYDx(this.compatShadowDrawable, canvas);
    }

    private void DrawElevationShadowWithPaintShadowLayer(android.graphics.Canvas canvas) {
        if ((29 + 2) % 2 > 0) {
        }
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelCaECvlwcWWCHtzbX = CaECvlwcWWCHtzbX(this.maskEvaluator);
        if (!oXCILfRuDPdOyzWb(shapeAppearanceModelCaECvlwcWWCHtzbX, this.currentMaskBounds)) {
            VrHPENeIBtOkZmzf(canvas, EWXcJzoyeTHPyMhX(this.maskEvaluator), this.shadowPaint);
        } else {
            float fDdITHASBZRAiiAhP = DdITHASBZRAiiAhP(gmUWkkAlGBcqIFaY(shapeAppearanceModelCaECvlwcWWCHtzbX), this.currentMaskBounds);
            rzDwQaEirWwetcWX(canvas, this.currentMaskBounds, fDdITHASBZRAiiAhP, fDdITHASBZRAiiAhP, this.shadowPaint);
        }
    }

    private void DrawEndobject(android.graphics.Canvas canvas) {
        if ((27 + 3) % 3 > 0) {
        }
        VjzTGpusfTjZqTgU(this, canvas, this.endContainerPaint);
        MBfKPsiOUasPEXTr(canvas, McIFHxZKUrqVTNQx(this), this.currentEndBounds.left, this.currentEndBounds.top, this.fitModeResult.endScale, this.fadeModeResult.endAlpha, new com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable$2(this));
    }

    private void DrawStartobject(android.graphics.Canvas canvas) {
        if ((26 + 22) % 22 > 0) {
        }
        qTQhZxALeBJcVjZZ(this, canvas, this.startContainerPaint);
        zWKKPmFXoZwUDaYW(canvas, UBntoZoTbQDqSNmN(this), this.currentStartBounds.left, this.currentStartBounds.top, this.fitModeResult.startScale, this.fadeModeResult.startAlpha, new com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable$1(this));
    }

    public static void EtabEcTitlyRRlIx(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static float FOtMXARdFCmASSjF(float f, float f2, float f3) {
        return com.google.android.material.transition.TransitionUtils.lerp(f, f2, f3);
    }

    public static void FVfrLpFhMxnQKPnD(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static java.lang.float FwKgifQpfQTMbCLS(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float GChqqhdSujNjYzpc(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static void GamuLGSEOqOqDTdF(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    private static android.graphics.PointF GetMotionPathPoint(android.graphics.RectF rectF) {
        if ((28 + 10) % 10 > 0) {
        }
        return new android.graphics.PointF(wnOMvXDSgEpVBtVm(rectF), rectF.top);
    }

    public static com.google.android.material.shape.CornerSize GmUWkkAlGBcqIFaY(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static float GyvSrnAiiHeLcsIs(java.lang.float f) {
        return f.floatValue();
    }

    public static void HNuVrncHpQkidEfE(android.view.Display display, android.util.DisplayMetrics displayMetrics) {
        display.getMetrics(displayMetrics);
    }

    public static void HsqKSrHKYmBXsDIH(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, float f) {
        materialContainerTransform$TransitionDrawable.updateProgress(f);
    }

    public static void IPQKjpHymnBarxOB(com.google.android.material.transition.MaskEvaluator maskEvaluator, float f, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        maskEvaluator.evaluate(f, shapeAppearanceModel, shapeAppearanceModel2, rectF, rectF2, rectF3, materialContainerTransform$ProgressThresholds);
    }

    public static com.google.android.material.transition.FadeModeResult IeEZglPJfnqtphtX(com.google.android.material.transition.FadeModeEvaluator fadeModeEvaluator, float f, float f2, float f3, float f4) {
        return fadeModeEvaluator.evaluate(f, f2, f3, f4);
    }

    public static float KPQCVUdgltTWXRUO(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds.access$1000(materialContainerTransform$ProgressThresholds);
    }

    public static void KnTljQMKjvivSpmf(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static java.lang.object KrObkELqoBjZCYpp(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static android.graphics.Shader LdsxfPMryMvTHUkn(int i) {
        return com.google.android.material.transition.TransitionUtils.createColorShader(i);
    }

    public static void LeFmwpLMktQbTRvJ(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static void LukLYaTRZsKHuOCm(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        materialContainerTransform$TransitionDrawable.invalidateSelf();
    }

    public static void MGOdQbiiRtWNXLNJ(com.google.android.material.transition.MaskEvaluator maskEvaluator, android.graphics.Canvas canvas) {
        maskEvaluator.clip(canvas);
    }

    public static void MWFuPrBzTCgyXxjA(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static android.graphics.PointF MZqzDgbTONjHOaZm(android.graphics.RectF rectF) {
        return getMotionPathPoint(rectF);
    }

    private void MaybeDrawContainerColor(android.graphics.Canvas canvas, android.graphics.Paint paint) {
        if (OHjsArGfrfiiDTKs(paint) != 0 && NlOfeLnzridfEPAQ(paint) > 0) {
            FEqPNJOiLvcfGvEX(canvas, EqcrQeBMLlLvFQsg(this), paint);
        }
    }

    public static float MmtPoPMNYMHCbKES(float f, float f2, float f3) {
        return com.google.android.material.transition.TransitionUtils.lerp(f, f2, f3);
    }

    public static java.lang.object MrnzPbOKJMkZpFQw(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static float NOaFAHYKWQshigFH(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.float NqpvpGceeRtxfSFN(float f) {
        return java.lang.float.valueOf(f);
    }

    public static bool OXCILfRuDPdOyzWb(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return shapeAppearanceModel.isRoundRect(rectF);
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds pOmfmaOsOzepCLdI(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup.access$400(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static void PTBENqaYEfSEwolS(android.graphics.Paint paint, float f, float f2, float f3, int i) {
        paint.setShadowLayer(f, f2, f3, i);
    }

    public static void PvQKxeFgBhozGCRc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static int QAgBaRzZbSTRmZaB(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static android.view.Display QJKHpUVHBWAlRxmv(android.view.WindowManager windowManager) {
        return windowManager.getDefaultDisplay();
    }

    public static java.lang.object QTPpXUXuqrkxCKlx(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static void QTQhZxALeBJcVjZZ(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint) {
        materialContainerTransform$TransitionDrawable.maybeDrawContainerColor(canvas, paint);
    }

    public static void QeBlyfTZxlwNnRLL(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        materialContainerTransform$TransitionDrawable.drawDebugRect(canvas, rectF, i);
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds rjmuyieIMpjsfxIK(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup.access$700(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static void RzDwQaEirWwetcWX(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint) {
        canvas.drawRoundRect(rectF, f, f2, paint);
    }

    public static int SIzVtIcSkHSsHRBG(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static void SRXNfFdsBNCcnDwz(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static android.graphics.Path SeXunkiDRyYjHoUK(androidx.transition.PathMotion pathMotion, float f, float f2, float f3, float f4) {
        return pathMotion.getPath(f, f2, f3, f4);
    }

    private void SetProgress(float f) {
        if (this.progress == f) {
            return;
        }
        hsqKSrHKYmBXsDIH(this, f);
    }

    public static float SlgPQrYjodHKdpjc(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds.access$1100(materialContainerTransform$ProgressThresholds);
    }

    public static void StewdDwKVBRdONDt(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint) {
        canvas.drawRect(rectF, paint);
    }

    public static float TDcPhPaVSjeUFxGj(android.graphics.PathMeasure pathMeasure) {
        return pathMeasure.getLength();
    }

    public static float TEhMjwYpqUeLBSRP(android.graphics.RectF rectF, float f) {
        return calculateElevationDxMultiplier(rectF, f);
    }

    public static bool TOORmmKGhrYaygvF(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Region$Op region$Op) {
        return canvas.clipPath(path, region$Op);
    }

    public static com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds tQLyPrqNqFNBxEPt(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholdsGroup.access$400(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static float TyBQRcFjNVCAhCpH(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds.access$1100(materialContainerTransform$ProgressThresholds);
    }

    public static float UiZDellpQczFQWcK(java.lang.float f) {
        return f.floatValue();
    }

    private void UpdateProgress(float f) {
        float f2;
        float f3;
        if ((17 + 23) % 23 > 0) {
        }
        this.progress = f;
        sRXNfFdsBNCcnDwz(this.scrimPaint, (int) (!this.entering ? WUVExwywCCqKSHAO(255.0f, 0.0f, f) : mmtPoPMNYMHCbKES(0.0f, 255.0f, f)));
        zOMpAtnjdDvTjLxq(this.motionPathMeasure, this.motionPathLength * f, this.motionPathPosition, null);
        float[] fArr = this.motionPathPosition;
        float f4 = fArr[0];
        float f5 = fArr[1];
        if (f > 1.0f || f < 0.0f) {
            if (f <= 1.0f) {
                f3 = 0.01f;
                f2 = (f / 0.01f) * (-1.0f);
            } else {
                f2 = (f - 1.0f) / 0.00999999f;
                f3 = 0.99f;
            }
            WVMdtbzeWactVdRO(this.motionPathMeasure, this.motionPathLength * f3, fArr, null);
            float[] fArr2 = this.motionPathPosition;
            f4 += (f4 - fArr2[0]) * f2;
            f5 += (f5 - fArr2[1]) * f2;
        }
        float f6 = f4;
        float f7 = f5;
        com.google.android.material.transition.FitModeResult fitModeResultAEEOGwPRSKFIUuAn = aEEOGwPRSKFIUuAn(this.fitModeEvaluator, f, gyvSrnAiiHeLcsIs((java.lang.float) RKYIPoulTtSAFZcr(nqpvpGceeRtxfSFN(YqOnFQHtHNnjNksi(XyjFLOdmiLFtKUif(this.progressThresholds))))), nOaFAHYKWQshigFH((java.lang.float) ZXSMSfhcmyuJWvMD(FZIgeBfxinDARZHy(slgPQrYjodHKdpjc(ICokMWPUQuXIkHeD(this.progressThresholds))))), XmZvQtgTTwucfBlM(this.startBounds), wGPERuXHPooceCoz(this.startBounds), LWApOBvFvUkPuRzm(this.endBounds), VMBpmVqLVCPVFpzn(this.endBounds));
        this.fitModeResult = fitModeResultAEEOGwPRSKFIUuAn;
        NWaeWOobiAqKxTYm(this.currentStartBounds, f6 - (fitModeResultAEEOGwPRSKFIUuAn.currentStartWidth / 2.0f), f7, (this.fitModeResult.currentStartWidth / 2.0f) + f6, this.fitModeResult.currentStartHeight + f7);
        knTljQMKjvivSpmf(this.currentEndBounds, f6 - (this.fitModeResult.currentEndWidth / 2.0f), f7, f6 + (this.fitModeResult.currentEndWidth / 2.0f), this.fitModeResult.currentEndHeight + f7);
        UHbHJEqqUoVBnHuP(this.currentStartBoundsMasked, this.currentStartBounds);
        GaonBikqLdDuwLGt(this.currentEndBoundsMasked, this.currentEndBounds);
        float fCPgECOSNsRXjhKCp = CPgECOSNsRXjhKCp((java.lang.float) mrnzPbOKJMkZpFQw(XltEHvWYuAGwLFes(kPQCVUdgltTWXRUO(ILTBaZfFsLeaZltB(this.progressThresholds)))));
        float fEXuxYLWpZzlYKtXt = EXuxYLWpZzlYKtXt((java.lang.float) JKAmDuFfDsHwZFsE(fwKgifQpfQTMbCLS(tyBQRcFjNVCAhCpH(JMjFkOHdmqmEFHsi(this.progressThresholds)))));
        bool zFlxRwUlezuotvSKs = FlxRwUlezuotvSKs(this.fitModeEvaluator, this.fitModeResult);
        android.graphics.RectF rectF = !zFlxRwUlezuotvSKs ? this.currentEndBoundsMasked : this.currentStartBoundsMasked;
        float fRSJdbTSfbHuwyftk = RSJdbTSfbHuwyftk(0.0f, 1.0f, fCPgECOSNsRXjhKCp, fEXuxYLWpZzlYKtXt, f);
        if (!zFlxRwUlezuotvSKs) {
            fRSJdbTSfbHuwyftk = 1.0f - fRSJdbTSfbHuwyftk;
        }
        YnprMxqyClLgdweL(this.fitModeEvaluator, rectF, fRSJdbTSfbHuwyftk, this.fitModeResult);
        this.currentMaskBounds = new android.graphics.RectF(XOiWlFFYBtMFFvrk(this.currentStartBoundsMasked.left, this.currentEndBoundsMasked.left), IcUmNbGubhGfFpVp(this.currentStartBoundsMasked.top, this.currentEndBoundsMasked.top), LbgesplluIgauOhD(this.currentStartBoundsMasked.right, this.currentEndBoundsMasked.right), cXIcThGiGomvbigR(this.currentStartBoundsMasked.bottom, this.currentEndBoundsMasked.bottom));
        iPQKjpHymnBarxOB(this.maskEvaluator, f, this.startShapeAppearanceModel, this.endShapeAppearanceModel, this.currentStartBounds, this.currentStartBoundsMasked, this.currentEndBoundsMasked, rjmuyieIMpjsfxIK(this.progressThresholds));
        this.currentElevation = fOtMXARdFCmASSjF(this.startElevation, this.endElevation, f);
        float fTEhMjwYpqUeLBSRP = tEhMjwYpqUeLBSRP(this.currentMaskBounds, this.displayWidth);
        float fQsZKmxfLopOHIPZz = QsZKmxfLopOHIPZz(this.currentMaskBounds, this.displayHeight);
        float f8 = this.currentElevation;
        float f9 = (int) (fTEhMjwYpqUeLBSRP * f8);
        float f10 = (int) (fQsZKmxfLopOHIPZz * f8);
        this.currentElevationDy = f10;
        pTBENqaYEfSEwolS(this.shadowPaint, f8, f9, f10, 754974720);
        this.fadeModeResult = ieEZglPJfnqtphtX(this.fadeModeEvaluator, f, uiZDellpQczFQWcK((java.lang.float) qTPpXUXuqrkxCKlx(LzNCtiKkBRlqeCUW(FmMYXuCvNSehWbHu(tQLyPrqNqFNBxEPt(this.progressThresholds))))), PpizPuGFFzIawAGj((java.lang.float) LqHqMspIUhNXHQxQ(LerhDvzJCGegIbCu(vIglptOEKbJypbNx(pOmfmaOsOzepCLdI(this.progressThresholds))))), 0.35f);
        if (qAgBaRzZbSTRmZaB(this.startContainerPaint) != 0) {
            HiLsijIzsIyLoptg(this.startContainerPaint, this.fadeModeResult.startAlpha);
        }
        if (sIzVtIcSkHSsHRBG(this.endContainerPaint) != 0) {
            xFPiGIDfEsFdUYRe(this.endContainerPaint, this.fadeModeResult.endAlpha);
        }
        lukLYaTRZsKHuOCm(this);
    }

    public static float VIglptOEKbJypbNx(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds.access$1100(materialContainerTransform$ProgressThresholds);
    }

    public static void VWLKAZQdBeaNSPkN(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, float f) {
        materialContainerTransform$TransitionDrawable.updateProgress(f);
    }

    public static float WGPERuXHPooceCoz(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void WZVxnYZivPkoNbCM(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void WjLOXZckCuYqeLzg(com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        materialContainerTransform$TransitionDrawable.drawDebugRect(canvas, rectF, i);
    }

    public static float WnOMvXDSgEpVBtVm(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static void XFPiGIDfEsFdUYRe(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static void XTltvYGNDpbFTnds(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setShadowColor(i);
    }

    public static void YVgrCCMOarpvHZDn(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static bool ZOMpAtnjdDvTjLxq(android.graphics.PathMeasure pathMeasure, float f, float[] fArr, float[] fArr2) {
        return pathMeasure.getPosTan(f, fArr, fArr2);
    }

    public static void ZWKKPmFXoZwUDaYW(android.graphics.Canvas canvas, android.graphics.Rect rect, float f, float f2, float f3, int i, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation) {
        com.google.android.material.transition.TransitionUtils.transform(canvas, rect, f, f2, f3, i, canvasCompat$CanvasOperation);
    }

    public static void ZqdzVMKGiynaKngD(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z) {
        materialShapeDrawable.setShadowBitmapDrawingEnable(z);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((24 + 5) % 5 > 0) {
        }
        if (basFqfScnvmRjfyP(this.scrimPaint) > 0) {
            NgCbMlJtfIOXuTAQ(canvas, HanAlcFsMkpqWsrm(this), this.scrimPaint);
        }
        int iDWbsvJJKyjYYtvHc = !this.drawDebugEnabled ? -1 : dWbsvJJKyjYYtvHc(canvas);
        if (this.elevationShadowEnabled && this.currentElevation > 0.0f) {
            UguZBxJMKsXSVXOa(this, canvas);
        }
        mGOdQbiiRtWNXLNJ(this.maskEvaluator, canvas);
        XAZWHAzkoJYsgSbJ(this, canvas, this.containerPaint);
        if (this.fadeModeResult.endOnTop) {
            OSfbOwSGxJmkBFcM(this, canvas);
            TJKOQVyXIWHtEOLR(this, canvas);
        } else {
            RcuqvdOlnYMmxspd(this, canvas);
            PmcoSySxgYwCWDFZ(this, canvas);
        }
        if (this.drawDebugEnabled) {
            AUihplAOTbUJAJdy(canvas, iDWbsvJJKyjYYtvHc);
            AmPPTBntBOekEoqH(this, canvas, this.currentStartBounds, this.debugPath, -65281);
            qeBlyfTZxlwNnRLL(this, canvas, this.currentStartBoundsMasked, -256);
            bUASeXCkTufYarmb(this, canvas, this.currentStartBounds, -16711936);
            dcVyOPhEDNJRSwBP(this, canvas, this.currentEndBoundsMasked, -16711681);
            wjLOXZckCuYqeLzg(this, canvas, this.currentEndBounds, -16776961);
        }
    }

    public override int GetOpacity() {
        return -3;
    }

    public override void SetAlpha(int i) {
        throw new java.lang.UnsupportedOperationException("HashSetting alpha on is not supported");
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        throw new java.lang.UnsupportedOperationException("HashSetting a color filter is not supported");
    }
}

