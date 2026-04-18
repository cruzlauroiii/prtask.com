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
    private readonly com.google.android.material.transition.platform.FadeModeEvaluator fadeModeEvaluator;
    private com.google.android.material.transition.platform.FadeModeResult fadeModeResult;
    private readonly com.google.android.material.transition.platform.FitModeEvaluator fitModeEvaluator;
    private com.google.android.material.transition.platform.FitModeResult fitModeResult;
    private readonly com.google.android.material.transition.platform.MaskEvaluator maskEvaluator;
    private readonly float motionPathLength;
    private readonly android.graphics.PathMeasure motionPathMeasure;
    private readonly float[] motionPathPosition;
    private float progress;
    private readonly com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup progressThresholds;
    private readonly android.graphics.Paint scrimPaint;
    private readonly android.graphics.Paint shadowPaint;
    private readonly android.graphics.RectF startBounds;
    private readonly android.graphics.Paint startContainerPaint;
    private readonly float startElevation;
    private readonly com.google.android.material.shape.ShapeAppearanceModel startShapeAppearanceModel;
    private readonly android.view.object startobject;

    private MaterialContainerTransform$TransitionDrawable(android.transition.PathMotion pathMotion, android.view.object view, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.view.object view2, android.graphics.RectF rectF2, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, float f2, int i, int i2, int i3, int i4, bool z, bool z2, com.google.android.material.transition.platform.FadeModeEvaluator fadeModeEvaluator, com.google.android.material.transition.platform.FitModeEvaluator fitModeEvaluator, com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup, bool z3) {
        if ((14 + 15) % 15 > 0) {
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
        this.maskEvaluator = new com.google.android.material.transition.platform.MaskEvaluator();
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
        android.view.WindowManager windowManager = (android.view.WindowManager) ZDrpBTqLBnVPRwmq(VRXTtEMGsLWBQZNz(view), "window");
        qDtxAygRMZLmPAzP(ZUUHzIyfhsFxdvIa(windowManager), new android.util.DisplayMetrics());
        this.displayWidth = r9.widthPixels;
        this.displayHeight = r9.heightPixels;
        mDOpsVTxhaImlWfG(paint, i);
        uegDZhuWRENfPWWi(paint2, i2);
        ftjpKSVhjouondFQ(paint3, i3);
        kIIYfYQMSZfciUmL(materialShapeDrawable, IVfunahGzyswPewm(0));
        DDMpgPfIMOfUjMmU(materialShapeDrawable, 2);
        NmIQCzIsXgwDnIci(materialShapeDrawable, false);
        UFJyODiUKRwyBgcK(materialShapeDrawable, -7829368);
        android.graphics.RectF rectF3 = new android.graphics.RectF(rectF);
        this.currentStartBounds = rectF3;
        this.currentStartBoundsMasked = new android.graphics.RectF(rectF3);
        android.graphics.RectF rectF4 = new android.graphics.RectF(rectF3);
        this.currentEndBounds = rectF4;
        this.currentEndBoundsMasked = new android.graphics.RectF(rectF4);
        android.graphics.PointF pointFDtIKhXOtApbydWfA = dtIKhXOtApbydWfA(rectF);
        android.graphics.PointF pointFJSEwUcLaYacOpVRV = JSEwUcLaYacOpVRV(rectF2);
        android.graphics.PathMeasure pathMeasure = new android.graphics.PathMeasure(ljaRQKYGZEhCAcnZ(pathMotion, pointFDtIKhXOtApbydWfA.x, pointFDtIKhXOtApbydWfA.y, pointFJSEwUcLaYacOpVRV.x, pointFJSEwUcLaYacOpVRV.y), false);
        this.motionPathMeasure = pathMeasure;
        this.motionPathLength = OIrQNYLePLmTZgnm(pathMeasure);
        fArr[0] = AOftTzfEtgpVKUAd(rectF);
        fArr[1] = rectF.top;
        YgYXTGmRbRESBKKx(paint4, android.graphics.Paint$Style.FILL);
        qSqrDHVsyaYbtuIT(paint4, piBjlzyFqbbizypv(i4));
        LRBdoKRZRbsCnFZq(paint5, android.graphics.Paint$Style.STROKE);
        FJctyNKCtbkWoIrc(paint5, 10.0f);
        deWtxaBUwqTGwJCy(this, 0.0f);
    }

    MaterialContainerTransform$TransitionDrawable(android.transition.PathMotion pathMotion, android.view.object view, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.view.object view2, android.graphics.RectF rectF2, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, float f2, int i, int i2, int i3, int i4, bool z, bool z2, com.google.android.material.transition.platform.FadeModeEvaluator fadeModeEvaluator, com.google.android.material.transition.platform.FitModeEvaluator fitModeEvaluator, com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup, bool z3, com.google.android.material.transition.platform.MaterialContainerTransform$1 materialContainerTransform$1) {
        this(pathMotion, view, rectF, shapeAppearanceModel, f, view2, rectF2, shapeAppearanceModel2, f2, i, i2, i3, i4, z, z2, fadeModeEvaluator, fitModeEvaluator, materialContainerTransform$ProgressThresholdsGroup, z3);
    }

    public static void AHKzgmcUARYrdUvC(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Paint paint) {
        canvas.drawRect(rect, paint);
    }

    public static android.graphics.PointF ALNGqCoWApnkCCuN(android.graphics.RectF rectF) {
        return getMotionPathPoint(rectF);
    }

    public static float AOftTzfEtgpVKUAd(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static void AoKmyMnhmwpJlaiO(android.graphics.Path path, float f, float f2) {
        path.lineTo(f, f2);
    }

    public static void AxLGspbVHrUAATFt(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static bool BaVgrjFNJFCBWFKJ(com.google.android.material.transition.platform.FitModeEvaluator fitModeEvaluator, com.google.android.material.transition.platform.FitModeResult fitModeResult) {
        return fitModeEvaluator.shouldMaskStartBounds(fitModeResult);
    }

    public static float BwNHjADeMBoPoPKa(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds.access$1100(materialContainerTransform$ProgressThresholds);
    }

    public static void DDMpgPfIMOfUjMmU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setShadowCompatibilityMode(i);
    }

    public static void DaQnCDgQSRBoXnrq(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint) {
        materialContainerTransform$TransitionDrawable.maybeDrawContainerColor(canvas, paint);
    }

    public static void DdBGDymSjEUwwroE(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        materialContainerTransform$TransitionDrawable.drawDebugRect(canvas, rectF, i);
    }

    public static float DhZUaYUwnukhQZok(float f, float f2, float f3) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(f, f2, f3);
    }

    public static com.google.android.material.shape.CornerSize DombyLjYLnrdrDdr(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static void EXoSPtptETJXLkfb(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setShadowVerticalOffset(i);
    }

    public static int EYTiTTuSlsASIbWq(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void FJctyNKCtbkWoIrc(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void GLmeDfhcJMSiYJFl(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static int GtMncUmaFQlbpEfQ(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static float HJWCEOysbhAbkXdd(java.lang.float f) {
        return f.floatValue();
    }

    public static android.graphics.Rect HVVoaPXUHmPyRlmG(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.getBounds();
    }

    public static java.lang.float HlqkpiaWWKmLrGgj(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float HsErpXlHpHMGjDCx(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static android.content.res.ColorStateList IVfunahGzyswPewm(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void IbksUmhsKlKkTluS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static android.graphics.Path IcMPKhXjEeZXSySi(com.google.android.material.transition.platform.MaskEvaluator maskEvaluator) {
        return maskEvaluator.getPath();
    }

    public static void IciaBstgzgTEjcmg(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawStartobject(canvas);
    }

    public static void IlkikjtQHVdyIEJp(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static void JQmbtQdZCyWkQBce(android.graphics.Paint paint, float f, float f2, float f3, int i) {
        paint.setShadowLayer(f, f2, f3, i);
    }

    public static android.graphics.PointF JSEwUcLaYacOpVRV(android.graphics.RectF rectF) {
        return getMotionPathPoint(rectF);
    }

    public static void JdJJNKAnnOzUvUWY(android.graphics.Canvas canvas, android.graphics.Rect rect, float f, float f2, float f3, int i, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation) {
        com.google.android.material.transition.platform.TransitionUtils.transform(canvas, rect, f, f2, f3, i, canvasCompat$CanvasOperation);
    }

    public static void JntXEkAEmxobLEwB(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static float KDeSCSDvyVfTVyyn(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static int KoPRSCMbnhuZDbBR(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static float LAtyMlCkxBCreNsZ(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void LDfdxQwpSKwoYJnR(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void LRBdoKRZRbsCnFZq(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static float LYfXMOLVPwWwfoYu(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds.access$1000(materialContainerTransform$ProgressThresholds);
    }

    public static void LiiYCLFUTUHZImyn(com.google.android.material.transition.platform.MaskEvaluator maskEvaluator, android.graphics.Canvas canvas) {
        maskEvaluator.clip(canvas);
    }

    public static float LxmpAPNEHkyHONxd(java.lang.float f) {
        return f.floatValue();
    }

    public static float McGjdhOEKWDqHeAp(java.lang.float f) {
        return f.floatValue();
    }

    public static void MoyDKSorwlPvlkct(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        materialContainerTransform$TransitionDrawable.invalidateSelf();
    }

    public static void NBILIUEqxPPonxyV(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        materialContainerTransform$TransitionDrawable.drawDebugRect(canvas, rectF, i);
    }

    public static void NNLLeEsBHahgsBXE(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static void NmIQCzIsXgwDnIci(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z) {
        materialShapeDrawable.setShadowBitmapDrawingEnable(z);
    }

    public static float OIrQNYLePLmTZgnm(android.graphics.PathMeasure pathMeasure) {
        return pathMeasure.getLength();
    }

    public static float OpgBWXTvNtYfRyvz(android.graphics.RectF rectF, float f) {
        return calculateElevationDyMultiplier(rectF, f);
    }

    public static java.lang.float PFJVLHatUppPPTEQ(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.object PXHOpKqvUdECbWRH(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static void PaNnUydKzRYjmlxb(com.google.android.material.transition.platform.MaskEvaluator maskEvaluator, float f, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3, com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        maskEvaluator.evaluate(f, shapeAppearanceModel, shapeAppearanceModel2, rectF, rectF2, rectF3, materialContainerTransform$ProgressThresholds);
    }

    public static android.graphics.Path PqVTdOqlkVGDcwrG(com.google.android.material.transition.platform.MaskEvaluator maskEvaluator) {
        return maskEvaluator.getPath();
    }

    public static void QmbxJehMaHvmWXGq(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        materialContainerTransform$TransitionDrawable.drawDebugRect(canvas, rectF, i);
    }

    public static void QnyEMGePXhrkPdBS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.draw(canvas);
    }

    public static void RirbYrOAmezeubfh(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawEndobject(canvas);
    }

    public static float RqmjLMhoAwgdMXgV(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(f, f2, f3, f4, f5);
    }

    public static float SSqjMeVxuFphkyel(java.lang.float f) {
        return f.floatValue();
    }

    public static void SfaKnKDgvJovGXAc(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Paint paint) {
        canvas.drawRect(rectF, paint);
    }

    public static void SswMLGkjzDYaOBFf(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, float f) {
        materialContainerTransform$TransitionDrawable.setProgress(f);
    }

    public static void StZIPSUqcaUDUWlE(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static int TADsFvuAWnkdLTmB(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static void UFJyODiUKRwyBgcK(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setShadowColor(i);
    }

    public static float UnYcYubuGmgoimih(float f, float f2, float f3) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(f, f2, f3);
    }

    public static float UuZARRiXzAheztmb(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static void VNeUaoUPLpYIAICh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, int i3, int i4) {
        materialShapeDrawable.setBounds(i, i2, i3, i4);
    }

    public static android.content.object VRXTtEMGsLWBQZNz(android.view.object view) {
        return view.getobject();
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds VWyRgsfMDvEakume(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup.access$500(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static float VgZpJdJBxFrkFRTD(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds.access$1000(materialContainerTransform$ProgressThresholds);
    }

    public static bool WGlzPQAGKFasimbm(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Region$Op region$Op) {
        return canvas.clipPath(path, region$Op);
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds WisIsWiGGYposlFd(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup.access$700(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static int WyGqQJMXxJlDFbsM(android.graphics.Paint paint) {
        return paint.getAlpha();
    }

    public static float XPdtEkvEkINeLaoU(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static java.lang.object XpowikakabsNVdyB(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static void YgYXTGmRbRESBKKx(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void YpCqHmiFUxUMNlOu(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawElevationShadow(canvas);
    }

    public static java.lang.object ZDrpBTqLBnVPRwmq(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static java.lang.float ZOEXNOkQlBjoDXzj(float f) {
        return java.lang.float.valueOf(f);
    }

    public static android.view.Display ZUUHzIyfhsFxdvIa(android.view.WindowManager windowManager) {
        return windowManager.getDefaultDisplay();
    }

    public static void ZoxxkFvQFYvqYIbW(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    static void access$200(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, float f) {
        SswMLGkjzDYaOBFf(materialContainerTransform$TransitionDrawable, f);
    }

    static android.view.object access$800(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.startobject;
    }

    static android.view.object access$900(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.endobject;
    }

    public static float AmlAxDictionaryBAKBGset(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static java.lang.object BSbNAYYuVxJQeuon(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static java.lang.float BgQPFKtnKEzhRzxa(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void BhKfmypvaRXGXJmA(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint) {
        materialContainerTransform$TransitionDrawable.maybeDrawContainerColor(canvas, paint);
    }

    public static android.graphics.Rect BoJfIOYNCdJtruMt(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.getBounds();
    }

    public static void COnAwcYrCtazmqvt(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    private static float CalculateElevationDxMultiplier(android.graphics.RectF rectF, float f) {
        return ((XPdtEkvEkINeLaoU(rectF) / (f / 2.0f)) - 1.0f) * 0.3f;
    }

    private static float CalculateElevationDyMultiplier(android.graphics.RectF rectF, float f) {
        return (lYXqUByyByFWVqXT(rectF) / f) * 1.5f;
    }

    public static bool CbIVTsjhTkjIOVif(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return shapeAppearanceModel.isRoundRect(rectF);
    }

    public static java.lang.object DMGExYnTJLMtMiVh(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static float DMnfjkCvUxpPrwoc(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void DeWtxaBUwqTGwJCy(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, float f) {
        materialContainerTransform$TransitionDrawable.updateProgress(f);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel DfjCeNxjsnqOfkdd(com.google.android.material.transition.platform.MaskEvaluator maskEvaluator) {
        return maskEvaluator.getCurrentShapeAppearanceModel();
    }

    private void DrawDebugCumulativePath(android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Path path, int i) {
        if ((20 + 18) % 18 > 0) {
        }
        android.graphics.PointF pointFALNGqCoWApnkCCuN = ALNGqCoWApnkCCuN(rectF);
        if (this.progress == 0.0f) {
            wfPCmGEaCHjlthMs(path);
            eyqwgqMEFLfjinje(path, pointFALNGqCoWApnkCCuN.x, pointFALNGqCoWApnkCCuN.y);
        } else {
            AoKmyMnhmwpJlaiO(path, pointFALNGqCoWApnkCCuN.x, pointFALNGqCoWApnkCCuN.y);
            fVZpFZFKlRdkQhii(this.debugPaint, i);
            LDfdxQwpSKwoYJnR(canvas, path, this.debugPaint);
        }
    }

    private void DrawDebugRect(android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        StZIPSUqcaUDUWlE(this.debugPaint, i);
        SfaKnKDgvJovGXAc(canvas, rectF, this.debugPaint);
    }

    private void DrawElevationShadow(android.graphics.Canvas canvas) {
        if ((28 + 32) % 32 > 0) {
        }
        uHALCdMbpKhlVSQy(canvas);
        WGlzPQAGKFasimbm(canvas, PqVTdOqlkVGDcwrG(this.maskEvaluator), android.graphics.Region$Op.DIFFERENCE);
        pxlifxMzbDwBLBYN(this, canvas);
        ZoxxkFvQFYvqYIbW(canvas);
    }

    private void DrawElevationShadowWithMaterialShapeDrawable(android.graphics.Canvas canvas) {
        if ((13 + 28) % 28 > 0) {
        }
        VNeUaoUPLpYIAICh(this.compatShadowDrawable, (int) this.currentMaskBounds.left, (int) this.currentMaskBounds.top, (int) this.currentMaskBounds.right, (int) this.currentMaskBounds.bottom);
        nZTTQGZKTKQdoyWH(this.compatShadowDrawable, this.currentElevation);
        EXoSPtptETJXLkfb(this.compatShadowDrawable, (int) this.currentElevationDy);
        IbksUmhsKlKkTluS(this.compatShadowDrawable, lbqKupnylyNlCqTI(this.maskEvaluator));
        QnyEMGePXhrkPdBS(this.compatShadowDrawable, canvas);
    }

    private void DrawElevationShadowWithPaintShadowLayer(android.graphics.Canvas canvas) {
        if ((25 + 18) % 18 > 0) {
        }
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelDfjCeNxjsnqOfkdd = dfjCeNxjsnqOfkdd(this.maskEvaluator);
        if (!cbIVTsjhTkjIOVif(shapeAppearanceModelDfjCeNxjsnqOfkdd, this.currentMaskBounds)) {
            cOnAwcYrCtazmqvt(canvas, IcMPKhXjEeZXSySi(this.maskEvaluator), this.shadowPaint);
        } else {
            float fUuZARRiXzAheztmb = UuZARRiXzAheztmb(DombyLjYLnrdrDdr(shapeAppearanceModelDfjCeNxjsnqOfkdd), this.currentMaskBounds);
            qmRwCwvQQukXJigR(canvas, this.currentMaskBounds, fUuZARRiXzAheztmb, fUuZARRiXzAheztmb, this.shadowPaint);
        }
    }

    private void DrawEndobject(android.graphics.Canvas canvas) {
        if ((1 + 10) % 10 > 0) {
        }
        bhKfmypvaRXGXJmA(this, canvas, this.endContainerPaint);
        unpgPvPbmHweGDjf(canvas, jvGKmLIfUUAWTrYR(this), this.currentEndBounds.left, this.currentEndBounds.top, this.fitModeResult.endScale, this.fadeModeResult.endAlpha, new com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable$2(this));
    }

    private void DrawStartobject(android.graphics.Canvas canvas) {
        if ((14 + 14) % 14 > 0) {
        }
        pmWMsJkOTodJoLjL(this, canvas, this.startContainerPaint);
        JdJJNKAnnOzUvUWY(canvas, hXwVAczYjjtuSnFq(this), this.currentStartBounds.left, this.currentStartBounds.top, this.fitModeResult.startScale, this.fadeModeResult.startAlpha, new com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable$1(this));
    }

    public static android.graphics.PointF DtIKhXOtApbydWfA(android.graphics.RectF rectF) {
        return getMotionPathPoint(rectF);
    }

    public static void EyqwgqMEFLfjinje(android.graphics.Path path, float f, float f2) {
        path.moveTo(f, f2);
    }

    public static float FAJLFDRbnOCxslSa(java.lang.float f) {
        return f.floatValue();
    }

    public static void FVZpFZFKlRdkQhii(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void FYdZzeRwmvQByMpY(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawEndobject(canvas);
    }

    public static float FlsRHgCmGkYjsweV(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static void FtjpKSVhjouondFQ(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static float GKlNttOSjsYjBEUq(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.object GVUKXsEOwdHhxCVO(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    private static android.graphics.PointF GetMotionPathPoint(android.graphics.RectF rectF) {
        if ((17 + 13) % 13 > 0) {
        }
        return new android.graphics.PointF(flsRHgCmGkYjsweV(rectF), rectF.top);
    }

    public static float GmfgvsodcQQsSEjq(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void GqCYWVabRBYinOBR(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.RectF rectF, int i) {
        materialContainerTransform$TransitionDrawable.drawDebugRect(canvas, rectF, i);
    }

    public static android.graphics.Rect HXwVAczYjjtuSnFq(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.getBounds();
    }

    public static android.graphics.Rect JvGKmLIfUUAWTrYR(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable) {
        return materialContainerTransform$TransitionDrawable.getBounds();
    }

    public static void KIIYfYQMSZfciUmL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void KcQYzfSqQHxJPOeF(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, float f) {
        materialContainerTransform$TransitionDrawable.updateProgress(f);
    }

    public static float KdIPrwVtJKTPsjEV(android.graphics.RectF rectF, float f) {
        return calculateElevationDxMultiplier(rectF, f);
    }

    public static float KdJJjHJoXcwAUJKv(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void KzISPCnoXogmwCMO(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawStartobject(canvas);
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds lGuAahGtkcMtvNiB(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup.access$500(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static float LYXqUByyByFWVqXT(android.graphics.RectF rectF) {
        return rectF.centerY();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel LbqKupnylyNlCqTI(com.google.android.material.transition.platform.MaskEvaluator maskEvaluator) {
        return maskEvaluator.getCurrentShapeAppearanceModel();
    }

    public static android.graphics.Path LjaRQKYGZEhCAcnZ(android.transition.PathMotion pathMotion, float f, float f2, float f3, float f4) {
        return pathMotion.getPath(f, f2, f3, f4);
    }

    public static bool LpQzpfOrUCUuiDto(android.graphics.PathMeasure pathMeasure, float f, float[] fArr, float[] fArr2) {
        return pathMeasure.getPosTan(f, fArr, fArr2);
    }

    public static void MDOpsVTxhaImlWfG(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    private void MaybeDrawContainerColor(android.graphics.Canvas canvas, android.graphics.Paint paint) {
        if (TADsFvuAWnkdLTmB(paint) != 0 && WyGqQJMXxJlDFbsM(paint) > 0) {
            AHKzgmcUARYrdUvC(canvas, HVVoaPXUHmPyRlmG(this), paint);
        }
    }

    public static com.google.android.material.transition.platform.FitModeResult MegBHjkqevmsZNDi(com.google.android.material.transition.platform.FitModeEvaluator fitModeEvaluator, float f, float f2, float f3, float f4, float f5, float f6, float f7) {
        return fitModeEvaluator.evaluate(f, f2, f3, f4, f5, f6, f7);
    }

    public static void NZTTQGZKTKQdoyWH(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static float NlKtAIZJEBSzYvyZ(float f, float f2, float f3) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(f, f2, f3);
    }

    public static float NqACXvmpUyhikMUy(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds.access$1000(materialContainerTransform$ProgressThresholds);
    }

    public static void OzjstZQsgNmfEYnW(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        rectF.set(rectF2);
    }

    public static bool PcApzmkOkXriCRmf(android.graphics.PathMeasure pathMeasure, float f, float[] fArr, float[] fArr2) {
        return pathMeasure.getPosTan(f, fArr, fArr2);
    }

    public static android.graphics.Shader PiBjlzyFqbbizypv(int i) {
        return com.google.android.material.transition.platform.TransitionUtils.createColorShader(i);
    }

    public static void PmWMsJkOTodJoLjL(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint) {
        materialContainerTransform$TransitionDrawable.maybeDrawContainerColor(canvas, paint);
    }

    public static void PxlifxMzbDwBLBYN(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas) {
        materialContainerTransform$TransitionDrawable.drawElevationShadowWithPaintShadowLayer(canvas);
    }

    public static void QDtxAygRMZLmPAzP(android.view.Display display, android.util.DisplayMetrics displayMetrics) {
        display.getMetrics(displayMetrics);
    }

    public static void QGFEGxcFIzoYFtjH(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        rectF.set(rectF2);
    }

    public static android.graphics.Shader QSqrDHVsyaYbtuIT(android.graphics.Paint paint, android.graphics.Shader shader) {
        return paint.setShader(shader);
    }

    public static com.google.android.material.transition.platform.FadeModeResult QeaebIduWGVjYVtz(com.google.android.material.transition.platform.FadeModeEvaluator fadeModeEvaluator, float f, float f2, float f3, float f4) {
        return fadeModeEvaluator.evaluate(f, f2, f3, f4);
    }

    public static void QmRwCwvQQukXJigR(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint) {
        canvas.drawRoundRect(rectF, f, f2, paint);
    }

    public static void RfoPWvdrMUnfTFNW(com.google.android.material.transition.platform.FitModeEvaluator fitModeEvaluator, android.graphics.RectF rectF, float f, com.google.android.material.transition.platform.FitModeResult fitModeResult) {
        fitModeEvaluator.applyMask(rectF, f, fitModeResult);
    }

    public static void RnpFBpenYraQVwNH(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    private void SetProgress(float f) {
        if (this.progress == f) {
            return;
        }
        kcQYzfSqQHxJPOeF(this, f);
    }

    public static java.lang.float TQriJfXRnlyzLnWd(float f) {
        return java.lang.float.valueOf(f);
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds tXdgWpwLlVmGbNut(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup.access$600(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static int UHALCdMbpKhlVSQy(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void UegDZhuWRENfPWWi(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void UnpgPvPbmHweGDjf(android.graphics.Canvas canvas, android.graphics.Rect rect, float f, float f2, float f3, int i, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation) {
        com.google.android.material.transition.platform.TransitionUtils.transform(canvas, rect, f, f2, f3, i, canvasCompat$CanvasOperation);
    }

    private void UpdateProgress(float f) {
        float f2;
        float f3;
        if ((4 + 6) % 6 > 0) {
        }
        this.progress = f;
        NNLLeEsBHahgsBXE(this.scrimPaint, (int) (!this.entering ? nlKtAIZJEBSzYvyZ(255.0f, 0.0f, f) : DhZUaYUwnukhQZok(0.0f, 255.0f, f)));
        lpQzpfOrUCUuiDto(this.motionPathMeasure, this.motionPathLength * f, this.motionPathPosition, null);
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
            pcApzmkOkXriCRmf(this.motionPathMeasure, this.motionPathLength * f3, fArr, null);
            float[] fArr2 = this.motionPathPosition;
            f4 += (f4 - fArr2[0]) * f2;
            f5 += (f5 - fArr2[1]) * f2;
        }
        float f6 = f4;
        float f7 = f5;
        com.google.android.material.transition.platform.FitModeResult fitModeResultMegBHjkqevmsZNDi = megBHjkqevmsZNDi(this.fitModeEvaluator, f, gKlNttOSjsYjBEUq((java.lang.float) gVUKXsEOwdHhxCVO(bgQPFKtnKEzhRzxa(LYfXMOLVPwWwfoYu(lGuAahGtkcMtvNiB(this.progressThresholds))))), LxmpAPNEHkyHONxd((java.lang.float) wCkSuGEVxLgvqvGY(ymcQCsnfSRPkBfnx(zXJrscEpuGsBumbG(VWyRgsfMDvEakume(this.progressThresholds))))), LAtyMlCkxBCreNsZ(this.startBounds), amlAxDictionaryBAKBGset(this.startBounds), dMnfjkCvUxpPrwoc(this.endBounds), gmfgvsodcQQsSEjq(this.endBounds));
        this.fitModeResult = fitModeResultMegBHjkqevmsZNDi;
        GLmeDfhcJMSiYJFl(this.currentStartBounds, f6 - (fitModeResultMegBHjkqevmsZNDi.currentStartWidth / 2.0f), f7, (this.fitModeResult.currentStartWidth / 2.0f) + f6, this.fitModeResult.currentStartHeight + f7);
        AxLGspbVHrUAATFt(this.currentEndBounds, f6 - (this.fitModeResult.currentEndWidth / 2.0f), f7, f6 + (this.fitModeResult.currentEndWidth / 2.0f), this.fitModeResult.currentEndHeight + f7);
        qGFEGxcFIzoYFtjH(this.currentStartBoundsMasked, this.currentStartBounds);
        ozjstZQsgNmfEYnW(this.currentEndBoundsMasked, this.currentEndBounds);
        float fFAJLFDRbnOCxslSa = fAJLFDRbnOCxslSa((java.lang.float) PXHOpKqvUdECbWRH(tQriJfXRnlyzLnWd(VgZpJdJBxFrkFRTD(vbuizdjVNFXPGPRG(this.progressThresholds)))));
        float fHJWCEOysbhAbkXdd = HJWCEOysbhAbkXdd((java.lang.float) XpowikakabsNVdyB(HlqkpiaWWKmLrGgj(BwNHjADeMBoPoPKa(tXdgWpwLlVmGbNut(this.progressThresholds)))));
        bool zBaVgrjFNJFCBWFKJ = BaVgrjFNJFCBWFKJ(this.fitModeEvaluator, this.fitModeResult);
        android.graphics.RectF rectF = !zBaVgrjFNJFCBWFKJ ? this.currentEndBoundsMasked : this.currentStartBoundsMasked;
        float fRqmjLMhoAwgdMXgV = RqmjLMhoAwgdMXgV(0.0f, 1.0f, fFAJLFDRbnOCxslSa, fHJWCEOysbhAbkXdd, f);
        if (!zBaVgrjFNJFCBWFKJ) {
            fRqmjLMhoAwgdMXgV = 1.0f - fRqmjLMhoAwgdMXgV;
        }
        rfoPWvdrMUnfTFNW(this.fitModeEvaluator, rectF, fRqmjLMhoAwgdMXgV, this.fitModeResult);
        this.currentMaskBounds = new android.graphics.RectF(KDeSCSDvyVfTVyyn(this.currentStartBoundsMasked.left, this.currentEndBoundsMasked.left), kdJJjHJoXcwAUJKv(this.currentStartBoundsMasked.top, this.currentEndBoundsMasked.top), xBeTblQjIeCnxyAY(this.currentStartBoundsMasked.right, this.currentEndBoundsMasked.right), HsErpXlHpHMGjDCx(this.currentStartBoundsMasked.bottom, this.currentEndBoundsMasked.bottom));
        PaNnUydKzRYjmlxb(this.maskEvaluator, f, this.startShapeAppearanceModel, this.endShapeAppearanceModel, this.currentStartBounds, this.currentStartBoundsMasked, this.currentEndBoundsMasked, WisIsWiGGYposlFd(this.progressThresholds));
        this.currentElevation = UnYcYubuGmgoimih(this.startElevation, this.endElevation, f);
        float fKdIPrwVtJKTPsjEV = kdIPrwVtJKTPsjEV(this.currentMaskBounds, this.displayWidth);
        float fOpgBWXTvNtYfRyvz = OpgBWXTvNtYfRyvz(this.currentMaskBounds, this.displayHeight);
        float f8 = this.currentElevation;
        float f9 = (int) (fKdIPrwVtJKTPsjEV * f8);
        float f10 = (int) (fOpgBWXTvNtYfRyvz * f8);
        this.currentElevationDy = f10;
        JQmbtQdZCyWkQBce(this.shadowPaint, f8, f9, f10, 754974720);
        this.fadeModeResult = qeaebIduWGVjYVtz(this.fadeModeEvaluator, f, McGjdhOEKWDqHeAp((java.lang.float) bSbNAYYuVxJQeuon(ZOEXNOkQlBjoDXzj(nqACXvmpUyhikMUy(xhDsfbWkucatHYYB(this.progressThresholds))))), SSqjMeVxuFphkyel((java.lang.float) dMGExYnTJLMtMiVh(PFJVLHatUppPPTEQ(vhlnluNvieZovWTL(yRzTPiFiwRkArQgj(this.progressThresholds))))), 0.35f);
        if (GtMncUmaFQlbpEfQ(this.startContainerPaint) != 0) {
            rnpFBpenYraQVwNH(this.startContainerPaint, this.fadeModeResult.startAlpha);
        }
        if (KoPRSCMbnhuZDbBR(this.endContainerPaint) != 0) {
            IlkikjtQHVdyIEJp(this.endContainerPaint, this.fadeModeResult.endAlpha);
        }
        MoyDKSorwlPvlkct(this);
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds vbuizdjVNFXPGPRG(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup.access$600(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static float VhlnluNvieZovWTL(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds.access$1100(materialContainerTransform$ProgressThresholds);
    }

    public static java.lang.object WCkSuGEVxLgvqvGY(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static int WSkBfnwQGTmmzbkm(android.graphics.Paint paint) {
        return paint.getAlpha();
    }

    public static void WXyVMtcdBmalyNNp(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Paint paint) {
        canvas.drawRect(rect, paint);
    }

    public static void WfPCmGEaCHjlthMs(android.graphics.Path path) {
        path.reset();
    }

    public static float XBeTblQjIeCnxyAY(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void XeejLnICiLhsUhmE(com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.graphics.Canvas canvas, android.graphics.RectF rectF, android.graphics.Path path, int i) {
        materialContainerTransform$TransitionDrawable.drawDebugCumulativePath(canvas, rectF, path, i);
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds xhDsfbWkucatHYYB(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup.access$400(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds yRzTPiFiwRkArQgj(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup materialContainerTransform$ProgressThresholdsGroup) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholdsGroup.access$400(materialContainerTransform$ProgressThresholdsGroup);
    }

    public static java.lang.float YmcQCsnfSRPkBfnx(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float ZXJrscEpuGsBumbG(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds.access$1100(materialContainerTransform$ProgressThresholds);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((11 + 12) % 12 > 0) {
        }
        if (wSkBfnwQGTmmzbkm(this.scrimPaint) > 0) {
            wXyVMtcdBmalyNNp(canvas, boJfIOYNCdJtruMt(this), this.scrimPaint);
        }
        int iEYTiTTuSlsASIbWq = !this.drawDebugEnabled ? -1 : EYTiTTuSlsASIbWq(canvas);
        if (this.elevationShadowEnabled && this.currentElevation > 0.0f) {
            YpCqHmiFUxUMNlOu(this, canvas);
        }
        LiiYCLFUTUHZImyn(this.maskEvaluator, canvas);
        DaQnCDgQSRBoXnrq(this, canvas, this.containerPaint);
        if (this.fadeModeResult.endOnTop) {
            kzISPCnoXogmwCMO(this, canvas);
            RirbYrOAmezeubfh(this, canvas);
        } else {
            fYdZzeRwmvQByMpY(this, canvas);
            IciaBstgzgTEjcmg(this, canvas);
        }
        if (this.drawDebugEnabled) {
            JntXEkAEmxobLEwB(canvas, iEYTiTTuSlsASIbWq);
            xeejLnICiLhsUhmE(this, canvas, this.currentStartBounds, this.debugPath, -65281);
            DdBGDymSjEUwwroE(this, canvas, this.currentStartBoundsMasked, -256);
            gqCYWVabRBYinOBR(this, canvas, this.currentStartBounds, -16711936);
            NBILIUEqxPPonxyV(this, canvas, this.currentEndBoundsMasked, -16711681);
            QmbxJehMaHvmWXGq(this, canvas, this.currentEndBounds, -16776961);
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

