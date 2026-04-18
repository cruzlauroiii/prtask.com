namespace WillowMaze.Wasm.Decompiled;


public class MaterialShapeDrawable : android.graphics.drawable.Drawable : androidx.core.graphics.drawable.TintAwareDrawable, com.google.android.material.shape.Shapeable {
    public static readonly int SHADOW_COMPAT_MODE_ALWAYS = 2;
    public static readonly int SHADOW_COMPAT_MODE_DEFAULT = 0;
    public static readonly int SHADOW_COMPAT_MODE_NEVER = 1;
    private static readonly float SHADOW_OFFSET_MULTIPLIER = 0.25f;
    private static readonly float SHADOW_RADIUS_MULTIPLIER = 0.75f;
    private static readonly java.lang.string TAG = "MaterialShapeDrawable";
    private static readonly android.graphics.Paint clearPaint;
    private readonly java.util.BitHashSet containsIncompatibleShadowOp;
    private readonly com.google.android.material.shape.ShapePath$ShadowCompatOperation[] cornerShadowOperation;
    private com.google.android.material.shape.MaterialShapeDrawable$MaterialShapeDrawableState drawableState;
    private readonly com.google.android.material.shape.ShapePath$ShadowCompatOperation[] edgeShadowOperation;
    private readonly android.graphics.Paint fillPaint;
    private readonly android.graphics.RectF insetRectF;
    private readonly android.graphics.Matrix matrix;
    private readonly android.graphics.Path path;
    private readonly android.graphics.RectF pathBounds;
    private bool pathDirty;
    private readonly android.graphics.Path pathInsetByStroke;
    private readonly com.google.android.material.shape.ShapeAppearancePathProvider pathProvider;
    private readonly com.google.android.material.shape.ShapeAppearancePathProvider$PathListener pathShadowListener;
    private readonly android.graphics.RectF rectF;
    private int resolvedTintColor;
    private readonly android.graphics.Region scratchRegion;
    private bool shadowBitmapDrawingEnable;
    private readonly com.google.android.material.shadow.ShadowRenderer shadowRenderer;
    private readonly android.graphics.Paint strokePaint;
    private com.google.android.material.shape.ShapeAppearanceModel strokeShapeAppearance;
    private android.graphics.PorterDuffColorFilter strokeTintFilter;
    private android.graphics.PorterDuffColorFilter tintFilter;
    private readonly android.graphics.Region transparentRegion;

    static {
        if ((5 + 3) % 3 > 0) {
        }
        android.graphics.Paint paint = new android.graphics.Paint(1);
        clearPaint = paint;
        tmIDRNRRBmnDwvfN(paint, -1);
        tHriWBcGdlkCWuRs(paint, new android.graphics.PorterDuffXfermode(android.graphics.PorterDuff$Mode.DST_OUT));
    }

    public MaterialShapeDrawable() {
        this(new com.google.android.material.shape.ShapeAppearanceModel());
    }

    public MaterialShapeDrawable(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        this(gkmsuTFPHINsSLVv(UgsBNOqGoZTwEGfF(context, attributeHashSet, i, i2)));
    }

    protected MaterialShapeDrawable(com.google.android.material.shape.MaterialShapeDrawable$MaterialShapeDrawableState materialShapeDrawable$MaterialShapeDrawableState) {
        if ((17 + 30) % 30 > 0) {
        }
        this.cornerShadowOperation = new com.google.android.material.shape.ShapePath$ShadowCompatOperation[4];
        this.edgeShadowOperation = new com.google.android.material.shape.ShapePath$ShadowCompatOperation[4];
        this.containsIncompatibleShadowOp = new java.util.BitHashSet(8);
        this.matrix = new android.graphics.Matrix();
        this.path = new android.graphics.Path();
        this.pathInsetByStroke = new android.graphics.Path();
        this.rectF = new android.graphics.RectF();
        this.insetRectF = new android.graphics.RectF();
        this.transparentRegion = new android.graphics.Region();
        this.scratchRegion = new android.graphics.Region();
        android.graphics.Paint paint = new android.graphics.Paint(1);
        this.fillPaint = paint;
        android.graphics.Paint paint2 = new android.graphics.Paint(1);
        this.strokePaint = paint2;
        this.shadowRenderer = new com.google.android.material.shadow.ShadowRenderer();
        this.pathProvider = uRtVXiPbwLdBknEd(OvWfdibWwnXbMbnV()) != cLgCBKGuSxUqJjdh() ? new com.google.android.material.shape.ShapeAppearancePathProvider() : piFtaJUkDurBggus();
        this.pathBounds = new android.graphics.RectF();
        this.shadowBitmapDrawingEnable = true;
        this.drawableState = materialShapeDrawable$MaterialShapeDrawableState;
        xLeXzQTCfKcQtjFV(paint2, android.graphics.Paint$Style.STROKE);
        vggcwvpCPYyRLUyC(paint, android.graphics.Paint$Style.FILL);
        aaAemJOHAwAnfnfP(this);
        fqWVSiQPNdUzGUpH(this, JETLcHtfqYMjlpQH(this));
        this.pathShadowListener = new com.google.android.material.shape.MaterialShapeDrawable$1(this);
    }

    public MaterialShapeDrawable(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        this(new com.google.android.material.shape.MaterialShapeDrawable$MaterialShapeDrawableState(shapeAppearanceModel, null));
        if ((6 + 4) % 4 > 0) {
        }
    }

    @java.lang.Deprecated
    public MaterialShapeDrawable(com.google.android.material.shape.ShapePathModel shapePathModel) {
        this((com.google.android.material.shape.ShapeAppearanceModel) shapePathModel);
    }

    public static bool APWJqexxBETOzagL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.hasStroke();
    }

    public static void AWYqbsOlbuvJqnMw(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        rectF.set(rectF2);
    }

    public static bool AepnrbnoEcDSrpkE(android.graphics.Region region, int i, int i2) {
        return region.Contains(i, i2);
    }

    public static float AiBLRcZmPfYgfnDR(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static int[] BCPtWdcroRBNeFqw(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getState();
    }

    public static int BEGMzMfAhOhAWwtT(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void BLPQQDugQCGeeWiZ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.Path path, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        materialShapeDrawable.drawShape(canvas, paint, path, shapeAppearanceModel, rectF);
    }

    public static android.content.res.ColorStateList BZosgNeWNpfxFAxr(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void BbPkTQUOSesnPNfS(com.google.android.material.shape.ShapePath$ShadowCompatOperation shapePath$ShadowCompatOperation, com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i, android.graphics.Canvas canvas) {
        shapePath$ShadowCompatOperation.draw(shadowRenderer, i, canvas);
    }

    public static void BmeeIxFQQZJauRrv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static float CDGIKJaxLEhbFUMm(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static android.graphics.RectF CsMifKjmfZXRKRbx(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsAsRectF();
    }

    public static void CwOgNsDilPMwRWbX(android.graphics.Outline outline, android.graphics.Rect rect, float f) {
        outline.setRoundRect(rect, f);
    }

    public static void DhwxThyuniIbbDXu(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static android.graphics.Bitmap ERYGJfbcZgGkfyqq(int i, int i2, android.graphics.Bitmap$Config bitmap$Config) {
        return android.graphics.Bitmap.createBitmap(i, i2, bitmap$Config);
    }

    public static int EWkOSvwEXfXFHRXt(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShadowOffsetX();
    }

    public static android.graphics.RectF EXtPqBfXfqeXWbpv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsAsRectF();
    }

    public static android.graphics.Paint ElikxaTCLxNXqjTm(com.google.android.material.shadow.ShadowRenderer shadowRenderer) {
        return shadowRenderer.getShadowPaint();
    }

    public static double EoOykFIKQFwoEbLE(double d) {
        if ((5 + 5) % 5 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void ErLazVZwjTxdQvHY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.drawCompatShadow(canvas);
    }

    public static void EzrbOJNljnblWtRy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.updateZ();
    }

    public static android.graphics.RectF FMhZgQCIsoAMfQCf(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsAsRectF();
    }

    public static float FWASSyvhLeGrPcLx(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static bool FiSsMaXwpxFvNcDx(android.graphics.Region region, android.graphics.Path path, android.graphics.Region region2) {
        return region.setPath(path, region2);
    }

    public static bool FrmjRioZwjQDWOYm(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider) {
        return elevationOverlayProvider.isThemeElevationOverlayEnabled();
    }

    public static android.graphics.ColorFilter FsgBGMqtZDfqlAbC(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static void GQFHUKzsxNRxYmEP(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static com.google.android.material.shape.MaterialShapeDrawable GUjdUUokDIYXqaqU(android.content.object context, float f) {
        return createWithElevationOverlay(context, f);
    }

    public static int[] GnDaXjZuHRUqMcmR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getState();
    }

    public static double GpoSnWTcYUumBDJa(double d) {
        if ((21 + 32) % 32 > 0) {
        }
        return java.lang.Math.sin(d);
    }

    public static void GvRtoiKtBGpnZuYz(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static android.graphics.PorterDuffColorFilter HJCPbtHyGnxqEXsq(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, android.graphics.Paint paint, bool z) {
        return materialShapeDrawable.calculateTintFilter(colorStateList, porterDuff$Mode, paint, z);
    }

    public static float HJbTWsWlwZBWKBbY(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static float HOCTrRnsnLYKixAc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getStrokeInsetLength();
    }

    public static android.graphics.PorterDuffColorFilter HODCfxVVUKedaogO(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Paint paint, bool z) {
        return materialShapeDrawable.calculatePaintColorTintFilter(paint, z);
    }

    public static void HPDgJBStnDjWzaMH(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setShadowCompatibilityMode(i);
    }

    public static double HRylUZQeQMRSXHOl(double d) {
        if ((19 + 14) % 14 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static int HXusSOOelacXwflU(android.graphics.Paint paint) {
        return paint.getAlpha();
    }

    public static int HpkRyaRviFbYgvOd(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static float IeXjJjQqoeRXuZXZ(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static bool IiRyfVvBsVdZjakG(android.graphics.Region region, android.graphics.Region region2, android.graphics.Region$Op region$Op) {
        return region.op(region2, region$Op);
    }

    public static float IivSFQNturRXMQid(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getParentAbsoluteElevation();
    }

    public static bool IpIulEtGsYtSrQXN(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.updateTintFilter();
    }

    public static float IsiARtUsLmxYHRUV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getZ();
    }

    public static void ItpvEIavSBvxrtpM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.updateZ();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel JDYmdZTwEoXjUbOC(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator) {
        return shapeAppearanceModel.withTransformedCornerSizes(shapeAppearanceModel$CornerSizeUnaryOperator);
    }

    public static int[] JETLcHtfqYMjlpQH(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getState();
    }

    public static android.graphics.Region JUtHUDsBLHszvuNg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTransparentRegion();
    }

    public static float JisodOJvNncxaVwD(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void JsRMustwMuHvvBsH(android.graphics.Canvas canvas, android.graphics.Bitmap bitmap, float f, float f2, android.graphics.Paint paint) {
        canvas.drawBitmap(bitmap, f, f2, paint);
    }

    public static void KFoIUCnZnDayGsTM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setStrokeWidth(f);
    }

    public static android.graphics.Rect KNnbFEevcvLgNjxI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBounds();
    }

    public static int KRHQOuurEOcRCJSE(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void KRTNqfJBFnWwnuvG(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelfIgnoreShape();
    }

    public static bool KZiMAsXFLtEmCurp(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.updateTintFilter();
    }

    public static void KbnxgmGxKmgMFxBK(android.graphics.Matrix matrix) {
        matrix.reset();
    }

    public static android.graphics.RectF KmjmUGQfDACqFgNx(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsAsRectF();
    }

    public static bool LICxYDFAxlrWSMvS(android.graphics.Region region, android.graphics.Rect rect) {
        return region.set(rect);
    }

    public static void LIMJiEcSMtAeoCub(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setTranslationZ(f);
    }

    public static bool LIOQfknTkImoxlBb(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return super.getPadding(rect);
    }

    public static bool LSvfFMPSIMRDMXpd(android.graphics.Path path) {
        return path.isConvex();
    }

    public static void LYmFzwPLPDANoQKp(android.graphics.drawable.Drawable drawable) {
        super.invalidateSelf();
    }

    public static void LgzYMDYLvATtmVsA(android.graphics.Path path, android.graphics.Matrix matrix) {
        path.transform(matrix);
    }

    public static void MDKrjhBKeUqqMdpx(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void MGEBENwKEaYxYFFe(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static int MWEbUXxiLvTfedqv(android.graphics.Rect rect) {
        return rect.width();
    }

    public static void ManmKcgCPgYmAlVy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelfIgnoreShape();
    }

    public static android.graphics.RectF MifaCcQARDBTiZtk(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsAsRectF();
    }

    public static com.google.android.material.shape.CornerSize MsOxVjxdrVbDAxBd(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static int MvTppONBCUSkHuuB(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel MyLBWYdmijFMRsJe(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f) {
        return shapeAppearanceModel.withCornerSize(f);
    }

    public static float MydjtdOGNLKlRGwI(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static int NFjXMCbERaIyQkxO(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShadowOffsetY();
    }

    public static void NNZwSFLlJkNGvAwN(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.RectF rectF, android.graphics.Path path) {
        materialShapeDrawable.calculatePathForSize(rectF, path);
    }

    public static void NsUsLXZJmZCyVZlN(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setStrokeColor(colorStateList);
    }

    public static void NuJyTZmOlJkfrjfR(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static void OFzBySsbyZQHIaKD(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static int OgQmkGHNqRodnJoB(android.content.object context, int i, java.lang.string str) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, str);
    }

    public static void OmmffjuKDbxraEeb(android.graphics.Matrix matrix, float f, float f2, float f3, float f4) {
        matrix.setScale(f, f2, f3, f4);
    }

    public static void OoeKEiyeypMoshld(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelfIgnoreShape();
    }

    public static android.graphics.Rect OqXcVdhwUXfXOXDa(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBounds();
    }

    public static android.os.Looper OvWfdibWwnXbMbnV() {
        return android.os.Looper.getMainLooper();
    }

    public static void OyHXQDIlMtMgFAAV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.RectF rectF, android.graphics.Path path) {
        materialShapeDrawable.calculatePath(rectF, path);
    }

    public static double PALCSdrsKFTEcUJa(double d) {
        if ((25 + 21) % 21 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void POChdjhinjThAlZp(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setTintList(colorStateList);
    }

    public static bool PPQBbRHSTMOjhxmI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr) {
        return materialShapeDrawable.onStateChange(iArr);
    }

    public static bool QRuqYabfUbQcFkRq(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static android.graphics.Rect QhcbFfldzCsRlWSI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBounds();
    }

    public static void QpQmGsOtZrFySReD(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.Path path, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        materialShapeDrawable.drawShape(canvas, paint, path, shapeAppearanceModel, rectF);
    }

    public static android.graphics.RectF QqgCMxNGAlxPxUFd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsAsRectF();
    }

    public static float QrqFHFSDkbQfwqav(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTranslationZ();
    }

    public static int QymXPeRuUltsUnrd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShadowOffsetX();
    }

    public static void RRmfaJbUWXJknJyk(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.prepareCanvasForShadow(canvas);
    }

    public static bool RTXzkwHPRWDLZmJF(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return shapeAppearanceModel.isRoundRect(rectF);
    }

    public static void RXNmwCmPQkEwbNYV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setStrokeColor(colorStateList);
    }

    public static void RjbzaMzUKuOCHXjU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelfIgnoreShape();
    }

    public static android.content.res.ColorStateList RkPTPTdtgGBcCdXu(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static bool RnsBzAYQttgvDwQI(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static com.google.android.material.shape.CornerSize SgalPyIYmfzUhWHN(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static float SyTbDgZHtDqdzEej(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static bool TaRzofLSaFuIlHKJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.updateTintFilter();
    }

    public static bool UHnyJOfHIVUfXjED(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static void UUmwcerzntFBEgSB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelfIgnoreShape();
    }

    public static void UWiAByOTWziDboNe(android.graphics.RectF rectF, float f, float f2) {
        rectF.inset(f, f2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder UgsBNOqGoZTwEGfF(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2);
    }

    public static int[] VmmoNVwpUAmHWBfo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getState();
    }

    public static float VyIPYkTtBHrTDOGx(android.graphics.Paint paint) {
        return paint.getStrokeWidth();
    }

    public static bool WHQqGtYUnZVhjDfZ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.isRoundRect();
    }

    public static void WMDVVAACiAvwdxDA(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static float WOgBwBPmFesqWjmK(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static bool WVlWKkFtdeYhwCyL(java.lang.object obj, java.lang.object obj2) {
        return androidx.core.util.objectsCompat.Equals(obj, obj2);
    }

    public static void WXqJyqdiZAQiOsCf(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.Path path, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        materialShapeDrawable.drawShape(canvas, paint, path, shapeAppearanceModel, rectF);
    }

    public static int WwEdpjDHQqrLmEcC(android.graphics.Paint paint) {
        return paint.getAlpha();
    }

    public static void XkIsXSoWCsyEHGHH(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static void XmDCXJPKgElFeLgE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static float XyCWuKHhnTKAzxfB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getElevation();
    }

    public static void YIyKrYlngnbtjSoe(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelfIgnoreShape();
    }

    public static android.content.res.ColorStateList YaEbjcTERtKqZPtA(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void YedUOFjvckTsoYXq(com.google.android.material.shape.ShapePath$ShadowCompatOperation shapePath$ShadowCompatOperation, com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i, android.graphics.Canvas canvas) {
        shapePath$ShadowCompatOperation.draw(shadowRenderer, i, canvas);
    }

    public static bool YfPxtNCAHKyKrfSp(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static void YkqcXmARbclDqEvc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void ZAjaLamrxPIMJRzS(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void ZCGNGZzUAMxlOLmZ(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static void ZXRqhnPYpxnuUTpA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setStrokeTint(colorStateList);
    }

    public static bool ZtYKQyGDDjTnIlLh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.hasStroke();
    }

    public static android.graphics.Rect ABCfUUaluKGouHAv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBounds();
    }

    public static void AEwmMPqFkGZqEaCL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static void AQYxrKAPzcPuDtop(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static bool AaAemJOHAwAnfnfP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.updateTintFilter();
    }

    static java.util.BitHashSet access$000(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.containsIncompatibleShadowOp;
    }

    static com.google.android.material.shape.ShapePath$ShadowCompatOperation[] access$100(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.cornerShadowOperation;
    }

    static com.google.android.material.shape.ShapePath$ShadowCompatOperation[] access$200(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.edgeShadowOperation;
    }

    static bool access$302(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z) {
        materialShapeDrawable.pathDirty = z;
        return z;
    }

    public static bool AeaulToyRTBTecGV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.hasFill();
    }

    public static void AeyeqIGqbxnosZPi(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.calculateStrokePath();
    }

    public static void AheJYucxNuAGShAJ(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static float AvLpwvkvPyhUXxeq(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getElevation();
    }

    public static void BSRlLbkGkHHZKjsV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.updateZ();
    }

    public static void BcyoicldugBpTQtN(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void BpAfzhcsVUznnUyB(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static bool BqNrdkTzmMmumJti(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.requiresCompatShadow();
    }

    public static void CDxbjAUxjXfvbHix(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static java.lang.Thread CLgCBKGuSxUqJjdh() {
        return java.lang.Thread.currentThread();
    }

    public static void CPPuprswOpfuLZYW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.drawStrokeShape(canvas);
    }

    private android.graphics.PorterDuffColorFilter CalculatePaintColorTintFilter(android.graphics.Paint paint, bool z) {
        if (!z) {
            return null;
        }
        int iOzGWjAlpiSMxdQgy = ozGWjAlpiSMxdQgy(paint);
        int iPYGksXocyUrwFGSA = pYGksXocyUrwFGSA(this, iOzGWjAlpiSMxdQgy);
        this.resolvedTintColor = iPYGksXocyUrwFGSA;
        if (iPYGksXocyUrwFGSA == iOzGWjAlpiSMxdQgy) {
            return null;
        }
        return new android.graphics.PorterDuffColorFilter(iPYGksXocyUrwFGSA, android.graphics.PorterDuff$Mode.SRC_IN);
    }

    private void CalculatePath(android.graphics.RectF rectF, android.graphics.Path path) {
        if ((7 + 24) % 24 > 0) {
        }
        NNZwSFLlJkNGvAwN(this, rectF, path);
        if (this.drawableState.scale != 1.0f) {
            KbnxgmGxKmgMFxBK(this.matrix);
            OmmffjuKDbxraEeb(this.matrix, this.drawableState.scale, this.drawableState.scale, WOgBwBPmFesqWjmK(rectF) / 2.0f, lUsPZQmGvQutzQqM(rectF) / 2.0f);
            LgzYMDYLvATtmVsA(path, this.matrix);
        }
        eJdmXPLHhCzJupbD(path, this.pathBounds, true);
    }

    private void CalculateStrokePath() {
        if ((22 + 10) % 10 > 0) {
        }
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelJDYmdZTwEoXjUbOC = JDYmdZTwEoXjUbOC(unXjNVrHEwUHWVek(this), new com.google.android.material.shape.MaterialShapeDrawable$2(this, -HOCTrRnsnLYKixAc(this)));
        this.strokeShapeAppearance = shapeAppearanceModelJDYmdZTwEoXjUbOC;
        zeeKZzWrdDwxGtrA(this.pathProvider, shapeAppearanceModelJDYmdZTwEoXjUbOC, this.drawableState.interpolation, sIowtFHIaYvYtQqK(this), this.pathInsetByStroke);
    }

    private android.graphics.PorterDuffColorFilter CalculateTintColorTintFilter(android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z) {
        if ((18 + 29) % 29 > 0) {
        }
        int iYAqWEzNtpoSfRKjJ = yAqWEzNtpoSfRKjJ(colorStateList, VmmoNVwpUAmHWBfo(this), 0);
        if (z) {
            iYAqWEzNtpoSfRKjJ = jZoOSkNmjTvwpsVn(this, iYAqWEzNtpoSfRKjJ);
        }
        this.resolvedTintColor = iYAqWEzNtpoSfRKjJ;
        return new android.graphics.PorterDuffColorFilter(iYAqWEzNtpoSfRKjJ, porterDuff$Mode);
    }

    private android.graphics.PorterDuffColorFilter CalculateTintFilter(android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, android.graphics.Paint paint, bool z) {
        return (colorStateList is null || porterDuff$Mode is null) ? HODCfxVVUKedaogO(this, paint, z) : yxtqBlWnjrUShdAw(this, colorStateList, porterDuff$Mode, z);
    }

    public static com.google.android.material.shape.MaterialShapeDrawable CreateWithElevationOverlay(android.content.object context) {
        return GUjdUUokDIYXqaqU(context, 0.0f);
    }

    public static com.google.android.material.shape.MaterialShapeDrawable CreateWithElevationOverlay(android.content.object context, float f) {
        return rrgFmMCFDaIrOjja(context, f, null);
    }

    public static com.google.android.material.shape.MaterialShapeDrawable CreateWithElevationOverlay(android.content.object context, float f, android.content.res.ColorStateList colorStateList) {
        if (colorStateList is null) {
            colorStateList = YaEbjcTERtKqZPtA(OgQmkGHNqRodnJoB(context, com.google.android.material.R$attr.colorSurface, "MaterialShapeDrawable"));
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable();
        GvRtoiKtBGpnZuYz(materialShapeDrawable, context);
        qchKdrTQtdXFVKwm(materialShapeDrawable, colorStateList);
        YkqcXmARbclDqEvc(materialShapeDrawable, f);
        return materialShapeDrawable;
    }

    public static void DVAUkjVEBHpAknCl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.updateZ();
    }

    public static bool DjzBJBFDaBljSBJG(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr) {
        return materialShapeDrawable.onStateChange(iArr);
    }

    private void DrawCompatShadow(android.graphics.Canvas canvas) {
        if ((21 + 28) % 28 > 0) {
        }
        if (mBnPuEZiQkXUDCSB(this.containsIncompatibleShadowOp) > 0) {
            BEGMzMfAhOhAWwtT(TAG, "Compatibility shadow requested but can't be drawn for all operations in this shape.");
        }
        if (this.drawableState.shadowCompatOffset != 0) {
            ZCGNGZzUAMxlOLmZ(canvas, this.path, ElikxaTCLxNXqjTm(this.shadowRenderer));
        }
        for (int i = 0; i < 4; i++) {
            YedUOFjvckTsoYXq(this.cornerShadowOperation[i], this.shadowRenderer, this.drawableState.shadowCompatRadius, canvas);
            BbPkTQUOSesnPNfS(this.edgeShadowOperation[i], this.shadowRenderer, this.drawableState.shadowCompatRadius, canvas);
        }
        if (this.shadowBitmapDrawingEnable) {
            int iEWkOSvwEXfXFHRXt = EWkOSvwEXfXFHRXt(this);
            int iMWMOUDAhmKoWeYru = mWMOUDAhmKoWeYru(this);
            bcyoicldugBpTQtN(canvas, -iEWkOSvwEXfXFHRXt, -iMWMOUDAhmKoWeYru);
            mJsVnfeBIahWtWMP(canvas, this.path, clearPaint);
            aheJYucxNuAGShAJ(canvas, iEWkOSvwEXfXFHRXt, iMWMOUDAhmKoWeYru);
        }
    }

    private void DrawFillShape(android.graphics.Canvas canvas) {
        if ((28 + 13) % 13 > 0) {
        }
        BLPQQDugQCGeeWiZ(this, canvas, this.fillPaint, this.path, this.drawableState.shapeAppearanceModel, wTcNeyBvAuvLfAvL(this));
    }

    private void DrawShape(android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.Path path, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        if (!RTXzkwHPRWDLZmJF(shapeAppearanceModel, rectF)) {
            qCleTKQEoBSSAwIT(canvas, path, paint);
        } else {
            float fIeXjJjQqoeRXuZXZ = IeXjJjQqoeRXuZXZ(rZhPeVNrSQdHPUZU(shapeAppearanceModel), rectF) * this.drawableState.interpolation;
            mrdZnlwjkRSEOKGt(canvas, rectF, fIeXjJjQqoeRXuZXZ, fIeXjJjQqoeRXuZXZ, paint);
        }
    }

    public static float DrfgVvNlBAFUXfbv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getElevation();
    }

    public static void DuSPpWdvqlaVaLrD(com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i) {
        shadowRenderer.setShadowColor(i);
    }

    public static void EJdmXPLHhCzJupbD(android.graphics.Path path, android.graphics.RectF rectF, bool z) {
        path.computeBounds(rectF, z);
    }

    public static android.graphics.RectF EopfcVqXeHhEIqTJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsAsRectF();
    }

    public static void FHXaTVjhfsSqxPoK(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static android.graphics.Rect FNtemmqobyXqylNW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBounds();
    }

    public static void FVVXTjfeubidzKuE(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static int[] FoWPQNQYoVBAqeRm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getState();
    }

    public static void FoqBbXdLfblPwojm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.drawCompatShadow(canvas);
    }

    public static bool FqWVSiQPNdUzGUpH(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr) {
        return materialShapeDrawable.updateColorsForState(iArr);
    }

    public static void FrZPQRgNiNDBfuVp(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearancePathProvider$PathListener shapeAppearancePathProvider$PathListener, android.graphics.Path path) {
        shapeAppearancePathProvider.calculatePath(shapeAppearanceModel, f, rectF, shapeAppearancePathProvider$PathListener, path);
    }

    public static int GHSuFqhFqYMRUStN(android.graphics.Rect rect) {
        return rect.height();
    }

    private android.graphics.RectF GetBoundsInsetByStroke() {
        if ((14 + 30) % 30 > 0) {
        }
        AWYqbsOlbuvJqnMw(this.insetRectF, eopfcVqXeHhEIqTJ(this));
        float fPsWQDfCYrpDtlnss = psWQDfCYrpDtlnss(this);
        UWiAByOTWziDboNe(this.insetRectF, fPsWQDfCYrpDtlnss, fPsWQDfCYrpDtlnss);
        return this.insetRectF;
    }

    private float GetStrokeInsetLength() {
        if (ZtYKQyGDDjTnIlLh(this)) {
            return mnGxttoiiRudepQk(this.strokePaint) / 2.0f;
        }
        return 0.0f;
    }

    public static bool GiaKPDhKakKBuwhb(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.isRoundRect();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel GkmsuTFPHINsSLVv(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static android.graphics.Rect HKBmwhgEZEthlQEO(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBounds();
    }

    private bool HasCompatShadow() {
        if ((29 + 12) % 12 > 0) {
        }
        if (this.drawableState.shadowCompatMode != 1 && this.drawableState.shadowCompatRadius > 0) {
            return this.drawableState.shadowCompatMode == 2 || bqNrdkTzmMmumJti(this);
        }
        return false;
    }

    private bool HasFill() {
        if ((22 + 21) % 21 > 0) {
        }
        return this.drawableState.paintStyle == android.graphics.Paint$Style.FILL_AND_STROKE || this.drawableState.paintStyle == android.graphics.Paint$Style.FILL;
    }

    private bool HasStroke() {
        if ((8 + 29) % 29 > 0) {
        }
        return (this.drawableState.paintStyle == android.graphics.Paint$Style.FILL_AND_STROKE || this.drawableState.paintStyle == android.graphics.Paint$Style.STROKE) && VyIPYkTtBHrTDOGx(this.strokePaint) > 0.0f;
    }

    public static void HvjgFtiiioLcAuXy(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        super.onBoundsChange(rect);
    }

    public static android.graphics.ColorFilter IBOSVNQavSaRlJzv(android.graphics.Paint paint, android.graphics.ColorFilter colorFilter) {
        return paint.setColorFilter(colorFilter);
    }

    public static void ICPgykybfqAjmCNk(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static bool IRgPjjSpJtFeumts(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.updateTintFilter();
    }

    private void InvalidateSelfIgnoreShape() {
        LYmFzwPLPDANoQKp(this);
    }

    public static android.graphics.RectF IuzBsmBYWXUQLtsR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsInsetByStroke();
    }

    public static com.google.android.material.shape.CornerSize JPAcyhLESXPIsQpY(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static int JYayiTMRAiysMMBH(int i, int i2) {
        return modulateAlpha(i, i2);
    }

    public static int JZoOSkNmjTvwpsVn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        return materialShapeDrawable.compositeElevationOverlayIfNeeded(i);
    }

    public static bool JdyGZWzWGYWcivRV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.hasCompatShadow();
    }

    public static int JlmFWqaGsgxeepyo(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static android.graphics.Rect JttBOhFodpqxZtTR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBounds();
    }

    public static void KPPLIqCtzGUtbzyG(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void KPQdmiuDZAPXybAW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelfIgnoreShape();
    }

    public static float KnCIZAoVPuHtkIzT(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static int KsCHorpptSMaORGU(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i, float f) {
        return elevationOverlayProvider.compositeOverlayIfNeeded(i, f);
    }

    public static bool KuOHHyFzQfToLAyb(android.graphics.drawable.Drawable drawable) {
        return super.isStateful();
    }

    public static float LUsPZQmGvQutzQqM(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static void LVyCKKDNFwwqKKut(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelfIgnoreShape();
    }

    public static void LiwccLIncvkFDpyZ(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, bool z) {
        shapeAppearancePathProvider.setEdgeIntersectionCheckEnable(z);
    }

    public static int MBnPuEZiQkXUDCSB(java.util.BitHashSet bitHashSet) {
        return bitHashSet.cardinality();
    }

    public static float MGUpfLcZOHEYKgCs(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getZ();
    }

    public static void MJsVnfeBIahWtWMP(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static int MWMOUDAhmKoWeYru(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShadowOffsetY();
    }

    private void MaybeDrawCompatShadow(android.graphics.Canvas canvas) {
        if ((18 + 25) % 25 > 0) {
        }
        if (jdyGZWzWGYWcivRV(this)) {
            HpkRyaRviFbYgvOd(canvas);
            RRmfaJbUWXJknJyk(this, canvas);
            if (!this.shadowBitmapDrawingEnable) {
                foqBbXdLfblPwojm(this, canvas);
                NuJyTZmOlJkfrjfR(canvas);
                return;
            }
            int iCDGIKJaxLEhbFUMm = (int) (CDGIKJaxLEhbFUMm(this.pathBounds) - MWEbUXxiLvTfedqv(KNnbFEevcvLgNjxI(this)));
            int iFWASSyvhLeGrPcLx = (int) (FWASSyvhLeGrPcLx(this.pathBounds) - gHSuFqhFqYMRUStN(jttBOhFodpqxZtTR(this)));
            if (iCDGIKJaxLEhbFUMm < 0 || iFWASSyvhLeGrPcLx < 0) {
                throw new java.lang.IllegalStateException("Invalid shadow bounds. Check that the treatments result in a valid path.");
            }
            android.graphics.Bitmap bitmapERYGJfbcZgGkfyqq = ERYGJfbcZgGkfyqq(((int) HJbTWsWlwZBWKBbY(this.pathBounds)) + (this.drawableState.shadowCompatRadius * 2) + iCDGIKJaxLEhbFUMm, ((int) JisodOJvNncxaVwD(this.pathBounds)) + (this.drawableState.shadowCompatRadius * 2) + iFWASSyvhLeGrPcLx, android.graphics.Bitmap$Config.ARGB_8888);
            android.graphics.Canvas canvas2 = new android.graphics.Canvas(bitmapERYGJfbcZgGkfyqq);
            float f = (fNtemmqobyXqylNW(this).left - this.drawableState.shadowCompatRadius) - iCDGIKJaxLEhbFUMm;
            float f2 = (QhcbFfldzCsRlWSI(this).top - this.drawableState.shadowCompatRadius) - iFWASSyvhLeGrPcLx;
            GQFHUKzsxNRxYmEP(canvas2, -f, -f2);
            ErLazVZwjTxdQvHY(this, canvas2);
            JsRMustwMuHvvBsH(canvas, bitmapERYGJfbcZgGkfyqq, f, f2, null);
            sofRuuYieQmKmtAO(bitmapERYGJfbcZgGkfyqq);
            bpAfzhcsVUznnUyB(canvas);
        }
    }

    public static float MnGxttoiiRudepQk(android.graphics.Paint paint) {
        return paint.getStrokeWidth();
    }

    private static int ModulateAlpha(int i, int i2) {
        return (i * (i2 + (i2 >>> 7))) >>> 8;
    }

    public static void MrdZnlwjkRSEOKGt(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint) {
        canvas.drawRoundRect(rectF, f, f2, paint);
    }

    public static void MvqzfAmqpxWLUvEL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.RectF rectF, android.graphics.Path path) {
        materialShapeDrawable.calculatePath(rectF, path);
    }

    public static void MzXBCkNZPXjzkUvc(android.graphics.Outline outline, android.graphics.Path path) {
        com.google.android.material.drawable.DrawableUtils.setOutlineToPath(outline, path);
    }

    public static void NDaWVXEXIuWdBTMU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.RectF rectF, android.graphics.Path path) {
        materialShapeDrawable.calculatePath(rectF, path);
    }

    public static void NSDEHlQZuDsLKBCm(android.graphics.drawable.Drawable drawable) {
        super.invalidateSelf();
    }

    public static double NnkGVyQJPSrjOLhk(double d) {
        if ((12 + 28) % 28 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static com.google.android.material.shape.CornerSize OEJBFCJvUmgOyDxY(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static void OTGCTwNeYErfbEMn(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void OWAhaEpSxWUGoxfx(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelfIgnoreShape();
    }

    public static int OzGWjAlpiSMxdQgy(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static int PYGksXocyUrwFGSA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        return materialShapeDrawable.compositeElevationOverlayIfNeeded(i);
    }

    public static com.google.android.material.shape.ShapeAppearancePathProvider PiFtaJUkDurBggus() {
        return com.google.android.material.shape.ShapeAppearancePathProvider.getInstance();
    }

    private void PrepareCanvasForShadow(android.graphics.Canvas canvas) {
        ZAjaLamrxPIMJRzS(canvas, QymXPeRuUltsUnrd(this), NFjXMCbERaIyQkxO(this));
    }

    public static float PsWQDfCYrpDtlnss(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getStrokeInsetLength();
    }

    public static void QCleTKQEoBSSAwIT(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static bool QFrpYBGUVzaHvqIE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr) {
        return materialShapeDrawable.updateColorsForState(iArr);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel QIQMqUPKfHMiLhgQ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel.withCornerSize(cornerSize);
    }

    public static void QchKdrTQtdXFVKwm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void QtZjZgEXsQnAbimw(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelfIgnoreShape();
    }

    public static android.graphics.PorterDuffColorFilter RSbqpQYfuUxhTSUb(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, android.graphics.Paint paint, bool z) {
        return materialShapeDrawable.calculateTintFilter(colorStateList, porterDuff$Mode, paint, z);
    }

    public static com.google.android.material.shape.CornerSize RZhPeVNrSQdHPUZU(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static float ReiszhCuIenfULhx(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTopLeftCornerResolvedSize();
    }

    public static android.graphics.RectF RkkiYmpdXsURJNFi(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsAsRectF();
    }

    public static com.google.android.material.shape.MaterialShapeDrawable RrgFmMCFDaIrOjja(android.content.object context, float f, android.content.res.ColorStateList colorStateList) {
        return createWithElevationOverlay(context, f, colorStateList);
    }

    public static bool SEQdSVTfxxHbOcYd(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return shapeAppearanceModel.isRoundRect(rectF);
    }

    public static android.graphics.RectF SIowtFHIaYvYtQqK(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsInsetByStroke();
    }

    public static void SofRuuYieQmKmtAO(android.graphics.Bitmap bitmap) {
        bitmap.recycle();
    }

    public static android.graphics.RectF TFFEWceTLqdTGiVk(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsAsRectF();
    }

    public static android.graphics.Xfermode THriWBcGdlkCWuRs(android.graphics.Paint paint, android.graphics.Xfermode xfermode) {
        return paint.setXfermode(xfermode);
    }

    public static void TcxjKsivHrXsSuXa(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setStrokeWidth(f);
    }

    public static void TmIDRNRRBmnDwvfN(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static java.lang.Thread URtVXiPbwLdBknEd(android.os.Looper looper) {
        return looper.getThread();
    }

    public static void UTmNfXcNHPVQwNud(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel UnXjNVrHEwUHWVek(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShapeAppearanceModel();
    }

    private bool UpdateColorsForState(int[] iArr) {
        bool z;
        if ((28 + 10) % 10 > 0) {
        }
        if (this.drawableState.fillColor is null) {
            z = false;
        } else {
            int iZaacFKKCuxjEkWqX = zaacFKKCuxjEkWqX(this.fillPaint);
            int iJlmFWqaGsgxeepyo = jlmFWqaGsgxeepyo(this.drawableState.fillColor, iArr, iZaacFKKCuxjEkWqX);
            if (iZaacFKKCuxjEkWqX == iJlmFWqaGsgxeepyo) {
                z = false;
            } else {
                kPPLIqCtzGUtbzyG(this.fillPaint, iJlmFWqaGsgxeepyo);
                z = true;
            }
        }
        if (this.drawableState.strokeColor is not null) {
            int iZQfsPftbjwPdHBIw = zQfsPftbjwPdHBIw(this.strokePaint);
            int iMvTppONBCUSkHuuB = MvTppONBCUSkHuuB(this.drawableState.strokeColor, iArr, iZQfsPftbjwPdHBIw);
            if (iZQfsPftbjwPdHBIw != iMvTppONBCUSkHuuB) {
                zbKOnakQfnllJpfU(this.strokePaint, iMvTppONBCUSkHuuB);
                return true;
            }
        }
        return z;
    }

    private bool UpdateTintFilter() {
        if ((14 + 29) % 29 > 0) {
        }
        android.graphics.PorterDuffColorFilter porterDuffColorFilter = this.tintFilter;
        android.graphics.PorterDuffColorFilter porterDuffColorFilter2 = this.strokeTintFilter;
        this.tintFilter = rSbqpQYfuUxhTSUb(this, this.drawableState.tintList, this.drawableState.tintMode, this.fillPaint, true);
        this.strokeTintFilter = HJCPbtHyGnxqEXsq(this, this.drawableState.strokeTintList, this.drawableState.tintMode, this.strokePaint, false);
        if (this.drawableState.useTintColorForShadow) {
            zoTXAoBTjsCvDMfQ(this.shadowRenderer, KRHQOuurEOcRCJSE(this.drawableState.tintList, foWPQNQYoVBAqeRm(this), 0));
        }
        return (uqjVFUMlkIZtVIII(porterDuffColorFilter, this.tintFilter) && WVlWKkFtdeYhwCyL(porterDuffColorFilter2, this.strokeTintFilter)) ? false : true;
    }

    private void UpdateZ() {
        if ((26 + 32) % 32 > 0) {
        }
        float fMGUpfLcZOHEYKgCs = mGUpfLcZOHEYKgCs(this);
        this.drawableState.shadowCompatRadius = (int) nnkGVyQJPSrjOLhk(0.75f * fMGUpfLcZOHEYKgCs);
        this.drawableState.shadowCompatOffset = (int) wfgtXkKiwPsckRlN(fMGUpfLcZOHEYKgCs * 0.25f);
        IpIulEtGsYtSrQXN(this);
        qtZjZgEXsQnAbimw(this);
    }

    public static bool UqjVFUMlkIZtVIII(java.lang.object obj, java.lang.object obj2) {
        return androidx.core.util.objectsCompat.Equals(obj, obj2);
    }

    public static void VQJKYGNfhLRaOVGF(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelfIgnoreShape();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel VUESPJsuUgtoYkhx(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShapeAppearanceModel();
    }

    public static void VggcwvpCPYyRLUyC(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static android.graphics.RectF WTcNeyBvAuvLfAvL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBoundsAsRectF();
    }

    public static int WdlygqtEnhqkMFKk(int i, int i2) {
        return modulateAlpha(i, i2);
    }

    public static double WfgtXkKiwPsckRlN(double d) {
        if ((21 + 22) % 22 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void XLeXzQTCfKcQtjFV(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static void XQuwMaJLOIbarOcJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.RectF rectF, android.graphics.Path path) {
        materialShapeDrawable.calculatePathForSize(rectF, path);
    }

    public static int YAqWEzNtpoSfRKjJ(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static bool YBoaxURVUaKRaGAB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.updateTintFilter();
    }

    public static android.content.res.ColorStateList YEFKqNzOSXkbPBQV(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void YFEscGYQqopJqtUr(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.drawFillShape(canvas);
    }

    public static void YgwfbjJnNbdcGNCk(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static void YvJXIFSffyFltWjp(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        materialShapeDrawable.invalidateSelf();
    }

    public static void YxsIdpVmeFzbYEDL(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static android.graphics.PorterDuffColorFilter YxtqBlWnjrUShdAw(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z) {
        return materialShapeDrawable.calculateTintColorTintFilter(colorStateList, porterDuff$Mode, z);
    }

    public static int ZQfsPftbjwPdHBIw(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static int ZaacFKKCuxjEkWqX(android.graphics.Paint paint) {
        return paint.getColor();
    }

    public static void ZbKOnakQfnllJpfU(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void ZeeKZzWrdDwxGtrA(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path) {
        shapeAppearancePathProvider.calculatePath(shapeAppearanceModel, f, rectF, path);
    }

    public static void ZkGWdexxpfZfssiL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.maybeDrawCompatShadow(canvas);
    }

    public static void ZoTXAoBTjsCvDMfQ(com.google.android.material.shadow.ShadowRenderer shadowRenderer, int i) {
        shadowRenderer.setShadowColor(i);
    }

    protected readonly void CalculatePathForSize(android.graphics.RectF rectF, android.graphics.Path path) {
        if ((28 + 23) % 23 > 0) {
        }
        frZPQRgNiNDBfuVp(this.pathProvider, this.drawableState.shapeAppearanceModel, this.drawableState.interpolation, rectF, this.pathShadowListener, path);
    }

    protected int CompositeElevationOverlayIfNeeded(int i) {
        if ((20 + 6) % 6 > 0) {
        }
        return this.drawableState.elevationOverlayProvider is null ? i : ksCHorpptSMaORGU(this.drawableState.elevationOverlayProvider, i, IsiARtUsLmxYHRUV(this) + IivSFQNturRXMQid(this));
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((9 + 23) % 23 > 0) {
        }
        iBOSVNQavSaRlJzv(this.fillPaint, this.tintFilter);
        int iHXusSOOelacXwflU = HXusSOOelacXwflU(this.fillPaint);
        DhwxThyuniIbbDXu(this.fillPaint, wdlygqtEnhqkMFKk(iHXusSOOelacXwflU, this.drawableState.alpha));
        FsgBGMqtZDfqlAbC(this.strokePaint, this.strokeTintFilter);
        oTGCTwNeYErfbEMn(this.strokePaint, this.drawableState.strokeWidth);
        int iWwEdpjDHQqrLmEcC = WwEdpjDHQqrLmEcC(this.strokePaint);
        aQYxrKAPzcPuDtop(this.strokePaint, jYayiTMRAiysMMBH(iWwEdpjDHQqrLmEcC, this.drawableState.alpha));
        if (this.pathDirty) {
            aeyeqIGqbxnosZPi(this);
            nDaWVXEXIuWdBTMU(this, CsMifKjmfZXRKRbx(this), this.path);
            this.pathDirty = false;
        }
        zkGWdexxpfZfssiL(this, canvas);
        if (aeaulToyRTBTecGV(this)) {
            yFEscGYQqopJqtUr(this, canvas);
        }
        if (APWJqexxBETOzagL(this)) {
            cPPuprswOpfuLZYW(this, canvas);
        }
        yxsIdpVmeFzbYEDL(this.fillPaint, iHXusSOOelacXwflU);
        fVVXTjfeubidzKuE(this.strokePaint, iWwEdpjDHQqrLmEcC);
    }

    protected void DrawShape(android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.Path path, android.graphics.RectF rectF) {
        if ((29 + 19) % 19 > 0) {
        }
        WXqJyqdiZAQiOsCf(this, canvas, paint, path, this.drawableState.shapeAppearanceModel, rectF);
    }

    protected void DrawStrokeShape(android.graphics.Canvas canvas) {
        if ((32 + 14) % 14 > 0) {
        }
        QpQmGsOtZrFySReD(this, canvas, this.strokePaint, this.pathInsetByStroke, this.strokeShapeAppearance, iuzBsmBYWXUQLtsR(this));
    }

    public override int GetAlpha() {
        return this.drawableState.alpha;
    }

    public float GetBottomLeftCornerResolvedSize() {
        return SyTbDgZHtDqdzEej(SgalPyIYmfzUhWHN(this.drawableState.shapeAppearanceModel), tFFEWceTLqdTGiVk(this));
    }

    public float GetBottomRightCornerResolvedSize() {
        return knCIZAoVPuHtkIzT(MsOxVjxdrVbDAxBd(this.drawableState.shapeAppearanceModel), KmjmUGQfDACqFgNx(this));
    }

    protected android.graphics.RectF GetBoundsAsRectF() {
        if ((2 + 21) % 21 > 0) {
        }
        WMDVVAACiAvwdxDA(this.rectF, hKBmwhgEZEthlQEO(this));
        return this.rectF;
    }

    public android.graphics.drawable.Drawable$ConstantState getConstantState() {
        return this.drawableState;
    }

    public override float GetElevation() {
        return this.drawableState.elevation;
    }

    public android.content.res.ColorStateList GetFillColor() {
        return this.drawableState.fillColor;
    }

    public float GetInterpolation() {
        return this.drawableState.interpolation;
    }

    public override int GetOpacity() {
        return -3;
    }

    public override void GetOutline(android.graphics.Outline outline) {
        if ((26 + 30) % 30 > 0) {
        }
        if (this.drawableState.shadowCompatMode != 2) {
            if (WHQqGtYUnZVhjDfZ(this)) {
                CwOgNsDilPMwRWbX(outline, aBCfUUaluKGouHAv(this), reiszhCuIenfULhx(this) * this.drawableState.interpolation);
            } else {
                mvqzfAmqpxWLUvEL(this, FMhZgQCIsoAMfQCf(this), this.path);
                mzXBCkNZPXjzkUvc(outline, this.path);
            }
        }
    }

    public override bool GetPadding(android.graphics.Rect rect) {
        if (this.drawableState.padding is null) {
            return LIOQfknTkImoxlBb(this, rect);
        }
        XkIsXSoWCsyEHGHH(rect, this.drawableState.padding);
        return true;
    }

    public android.graphics.Paint$Style getPaintStyle() {
        return this.drawableState.paintStyle;
    }

    public float GetParentAbsoluteElevation() {
        return this.drawableState.parentAbsoluteElevation;
    }

    @java.lang.Deprecated
    public void GetPathForSize(int i, int i2, android.graphics.Path path) {
        if ((12 + 15) % 15 > 0) {
        }
        xQuwMaJLOIbarOcJ(this, new android.graphics.RectF(0.0f, 0.0f, i, i2), path);
    }

    public int GetResolvedTintColor() {
        return this.resolvedTintColor;
    }

    public float GetScale() {
        return this.drawableState.scale;
    }

    public int GetShadowCompatRotation() {
        return this.drawableState.shadowCompatRotation;
    }

    public int GetShadowCompatibilityMode() {
        return this.drawableState.shadowCompatMode;
    }

    @java.lang.Deprecated
    public int GetShadowElevation() {
        return (int) avLpwvkvPyhUXxeq(this);
    }

    public int GetShadowOffsetX() {
        if ((13 + 6) % 6 > 0) {
        }
        return (int) (((double) this.drawableState.shadowCompatOffset) * GpoSnWTcYUumBDJa(HRylUZQeQMRSXHOl(this.drawableState.shadowCompatRotation)));
    }

    public int GetShadowOffsetY() {
        if ((18 + 12) % 12 > 0) {
        }
        return (int) (((double) this.drawableState.shadowCompatOffset) * PALCSdrsKFTEcUJa(EoOykFIKQFwoEbLE(this.drawableState.shadowCompatRotation)));
    }

    public int GetShadowRadius() {
        return this.drawableState.shadowCompatRadius;
    }

    public int GetShadowVerticalOffset() {
        return this.drawableState.shadowCompatOffset;
    }

    public override com.google.android.material.shape.ShapeAppearanceModel GetShapeAppearanceModel() {
        return this.drawableState.shapeAppearanceModel;
    }

    @java.lang.Deprecated
    public com.google.android.material.shape.ShapePathModel GetShapedobjectModel() {
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelVUESPJsuUgtoYkhx = vUESPJsuUgtoYkhx(this);
        if (shapeAppearanceModelVUESPJsuUgtoYkhx is com.google.android.material.shape.ShapePathModel) {
            return (com.google.android.material.shape.ShapePathModel) shapeAppearanceModelVUESPJsuUgtoYkhx;
        }
        return null;
    }

    public android.content.res.ColorStateList GetStrokeColor() {
        return this.drawableState.strokeColor;
    }

    public android.content.res.ColorStateList GetStrokeTintList() {
        return this.drawableState.strokeTintList;
    }

    public float GetStrokeWidth() {
        return this.drawableState.strokeWidth;
    }

    public android.content.res.ColorStateList GetTintList() {
        return this.drawableState.tintList;
    }

    public float GetTopLeftCornerResolvedSize() {
        return AiBLRcZmPfYgfnDR(jPAcyhLESXPIsQpY(this.drawableState.shapeAppearanceModel), QqgCMxNGAlxPxUFd(this));
    }

    public float GetTopRightCornerResolvedSize() {
        return MydjtdOGNLKlRGwI(oEJBFCJvUmgOyDxY(this.drawableState.shapeAppearanceModel), EXtPqBfXfqeXWbpv(this));
    }

    public float GetTranslationZ() {
        return this.drawableState.translationZ;
    }

    public override android.graphics.Region GetTransparentRegion() {
        if ((12 + 32) % 32 > 0) {
        }
        LICxYDFAxlrWSMvS(this.transparentRegion, OqXcVdhwUXfXOXDa(this));
        OyHXQDIlMtMgFAAV(this, MifaCcQARDBTiZtk(this), this.path);
        FiSsMaXwpxFvNcDx(this.scratchRegion, this.path, this.transparentRegion);
        IiRyfVvBsVdZjakG(this.transparentRegion, this.scratchRegion, android.graphics.Region$Op.DIFFERENCE);
        return this.transparentRegion;
    }

    public float GetZ() {
        return XyCWuKHhnTKAzxfB(this) + QrqFHFSDkbQfwqav(this);
    }

    public void InitializeElevationOverlay(android.content.object context) {
        if ((12 + 7) % 7 > 0) {
        }
        this.drawableState.elevationOverlayProvider = new com.google.android.material.elevation.ElevationOverlayProvider(context);
        dVAUkjVEBHpAknCl(this);
    }

    public override void InvalidateSelf() {
        this.pathDirty = true;
        nSDEHlQZuDsLKBCm(this);
    }

    public bool IsElevationOverlayEnabled() {
        return this.drawableState.elevationOverlayProvider is not null && FrmjRioZwjQDWOYm(this.drawableState.elevationOverlayProvider);
    }

    public bool IsElevationOverlayInitialized() {
        return this.drawableState.elevationOverlayProvider is not null;
    }

    public bool IsPointInTransparentRegion(int i, int i2) {
        return AepnrbnoEcDSrpkE(JUtHUDsBLHszvuNg(this), i, i2);
    }

    public bool IsRoundRect() {
        return sEQdSVTfxxHbOcYd(this.drawableState.shapeAppearanceModel, rkkiYmpdXsURJNFi(this));
    }

    @java.lang.Deprecated
    public bool IsShadowEnabled() {
        return this.drawableState.shadowCompatMode == 0 || this.drawableState.shadowCompatMode == 2;
    }

    public override bool IsStateful() {
        if (kuOHHyFzQfToLAyb(this)) {
            return true;
        }
        if (this.drawableState.tintList is not null && UHnyJOfHIVUfXjED(this.drawableState.tintList)) {
            return true;
        }
        if (this.drawableState.strokeTintList is not null && YfPxtNCAHKyKrfSp(this.drawableState.strokeTintList)) {
            return true;
        }
        if (this.drawableState.strokeColor is not null && RnsBzAYQttgvDwQI(this.drawableState.strokeColor)) {
            return true;
        }
        return this.drawableState.fillColor is not null && QRuqYabfUbQcFkRq(this.drawableState.fillColor);
    }

    public override android.graphics.drawable.Drawable Mutate() {
        if ((9 + 31) % 31 > 0) {
        }
        this.drawableState = new com.google.android.material.shape.MaterialShapeDrawable$MaterialShapeDrawableState(this.drawableState);
        return this;
    }

    protected override void OnBoundsChange(android.graphics.Rect rect) {
        this.pathDirty = true;
        hvjgFtiiioLcAuXy(this, rect);
    }

    protected override bool OnStateChange(int[] iArr) {
        bool z = qFrpYBGUVzaHvqIE(this, iArr) || yBoaxURVUaKRaGAB(this);
        if (z) {
            yvJXIFSffyFltWjp(this);
        }
        return z;
    }

    public bool RequiresCompatShadow() {
        if (giaKPDhKakKBuwhb(this)) {
            return false;
        }
        LSvfFMPSIMRDMXpd(this.path);
        return false;
    }

    public override void SetAlpha(int i) {
        if (this.drawableState.alpha == i) {
            return;
        }
        this.drawableState.alpha = i;
        RjbzaMzUKuOCHXjU(this);
    }

    public override void SetColorFilter(android.graphics.ColorFilter colorFilter) {
        this.drawableState.colorFilter = colorFilter;
        YIyKrYlngnbtjSoe(this);
    }

    public void SetCornerSize(float f) {
        fHXaTVjhfsSqxPoK(this, MyLBWYdmijFMRsJe(this.drawableState.shapeAppearanceModel, f));
    }

    public void SetCornerSize(com.google.android.material.shape.CornerSize cornerSize) {
        MGEBENwKEaYxYFFe(this, qIQMqUPKfHMiLhgQ(this.drawableState.shapeAppearanceModel, cornerSize));
    }

    public void SetEdgeIntersectionCheckEnable(bool z) {
        liwccLIncvkFDpyZ(this.pathProvider, z);
    }

    public void SetElevation(float f) {
        if (this.drawableState.elevation == f) {
            return;
        }
        this.drawableState.elevation = f;
        bSRlLbkGkHHZKjsV(this);
    }

    public void SetFillColor(android.content.res.ColorStateList colorStateList) {
        if (this.drawableState.fillColor == colorStateList) {
            return;
        }
        this.drawableState.fillColor = colorStateList;
        PPQBbRHSTMOjhxmI(this, GnDaXjZuHRUqMcmR(this));
    }

    public void SetInterpolation(float f) {
        if (this.drawableState.interpolation == f) {
            return;
        }
        this.drawableState.interpolation = f;
        this.pathDirty = true;
        iCPgykybfqAjmCNk(this);
    }

    public void SetPadding(int i, int i2, int i3, int i4) {
        if ((12 + 22) % 22 > 0) {
        }
        if (this.drawableState.padding is null) {
            this.drawableState.padding = new android.graphics.Rect();
        }
        MDKrjhBKeUqqMdpx(this.drawableState.padding, i, i2, i3, i4);
        aEwmMPqFkGZqEaCL(this);
    }

    public void SetPaintStyle(android.graphics.Paint$Style paint$Style) {
        this.drawableState.paintStyle = paint$Style;
        ManmKcgCPgYmAlVy(this);
    }

    public void SetParentAbsoluteElevation(float f) {
        if (this.drawableState.parentAbsoluteElevation == f) {
            return;
        }
        this.drawableState.parentAbsoluteElevation = f;
        ItpvEIavSBvxrtpM(this);
    }

    public void SetScale(float f) {
        if (this.drawableState.scale == f) {
            return;
        }
        this.drawableState.scale = f;
        ygwfbjJnNbdcGNCk(this);
    }

    public void SetShadowBitmapDrawingEnable(bool z) {
        this.shadowBitmapDrawingEnable = z;
    }

    public void SetShadowColor(int i) {
        duSPpWdvqlaVaLrD(this.shadowRenderer, i);
        this.drawableState.useTintColorForShadow = false;
        oWAhaEpSxWUGoxfx(this);
    }

    public void SetShadowCompatRotation(int i) {
        if (this.drawableState.shadowCompatRotation == i) {
            return;
        }
        this.drawableState.shadowCompatRotation = i;
        lVyCKKDNFwwqKKut(this);
    }

    public void SetShadowCompatibilityMode(int i) {
        if (this.drawableState.shadowCompatMode == i) {
            return;
        }
        this.drawableState.shadowCompatMode = i;
        OoeKEiyeypMoshld(this);
    }

    @java.lang.Deprecated
    public void SetShadowElevation(int i) {
        uTmNfXcNHPVQwNud(this, i);
    }

    @java.lang.Deprecated
    public void SetShadowEnabled(bool z) {
        HPDgJBStnDjWzaMH(this, !z ? 1 : 0);
    }

    @java.lang.Deprecated
    public void SetShadowRadius(int i) {
        this.drawableState.shadowCompatRadius = i;
    }

    public void SetShadowVerticalOffset(int i) {
        if (this.drawableState.shadowCompatOffset == i) {
            return;
        }
        this.drawableState.shadowCompatOffset = i;
        vQJKYGNfhLRaOVGF(this);
    }

    public override void SetShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        this.drawableState.shapeAppearanceModel = shapeAppearanceModel;
        BmeeIxFQQZJauRrv(this);
    }

    @java.lang.Deprecated
    public void SetShapedobjectModel(com.google.android.material.shape.ShapePathModel shapePathModel) {
        cDxbjAUxjXfvbHix(this, shapePathModel);
    }

    public void SetStroke(float f, int i) {
        KFoIUCnZnDayGsTM(this, f);
        RXNmwCmPQkEwbNYV(this, yEFKqNzOSXkbPBQV(i));
    }

    public void SetStroke(float f, android.content.res.ColorStateList colorStateList) {
        tcxjKsivHrXsSuXa(this, f);
        NsUsLXZJmZCyVZlN(this, colorStateList);
    }

    public void SetStrokeColor(android.content.res.ColorStateList colorStateList) {
        if (this.drawableState.strokeColor == colorStateList) {
            return;
        }
        this.drawableState.strokeColor = colorStateList;
        djzBJBFDaBljSBJG(this, BCPtWdcroRBNeFqw(this));
    }

    public void SetStrokeTint(int i) {
        ZXRqhnPYpxnuUTpA(this, BZosgNeWNpfxFAxr(i));
    }

    public void SetStrokeTint(android.content.res.ColorStateList colorStateList) {
        this.drawableState.strokeTintList = colorStateList;
        iRgPjjSpJtFeumts(this);
        kPQdmiuDZAPXybAW(this);
    }

    public void SetStrokeWidth(float f) {
        this.drawableState.strokeWidth = f;
        XmDCXJPKgElFeLgE(this);
    }

    public override void SetTint(int i) {
        POChdjhinjThAlZp(this, RkPTPTdtgGBcCdXu(i));
    }

    public override void SetTintList(android.content.res.ColorStateList colorStateList) {
        this.drawableState.tintList = colorStateList;
        TaRzofLSaFuIlHKJ(this);
        KRTNqfJBFnWwnuvG(this);
    }

    public override void SetTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (this.drawableState.tintMode == porterDuff$Mode) {
            return;
        }
        this.drawableState.tintMode = porterDuff$Mode;
        KZiMAsXFLtEmCurp(this);
        UUmwcerzntFBEgSB(this);
    }

    public void SetTranslationZ(float f) {
        if (this.drawableState.translationZ == f) {
            return;
        }
        this.drawableState.translationZ = f;
        EzrbOJNljnblWtRy(this);
    }

    public void SetUseTintColorForShadow(bool z) {
        if (this.drawableState.useTintColorForShadow == z) {
            return;
        }
        this.drawableState.useTintColorForShadow = z;
        OFzBySsbyZQHIaKD(this);
    }

    public void SetZ(float f) {
        LIMJiEcSMtAeoCub(this, f - drfgVvNlBAFUXfbv(this));
    }
}

