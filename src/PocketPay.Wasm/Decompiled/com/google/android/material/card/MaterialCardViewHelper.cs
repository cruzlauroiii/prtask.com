namespace WillowMaze.Wasm.Decompiled;


class MaterialCardobjectHelper {
    private static readonly float CARD_VIEW_SHADOW_MULTIPLIER = 1.5f;
    private static readonly int CHECKED_ICON_LAYER_INDEX = 2;
    private static readonly android.graphics.drawable.Drawable CHECKED_ICON_NONE;
    private static readonly double COS_45;
    public static readonly int DEFAULT_FADE_ANIM_DURATION = 300;
    private static readonly int DEFAULT_STROKE_VALUE = -1;
    private readonly com.google.android.material.shape.MaterialShapeDrawable bgDrawable;
    private bool checkable;
    private float checkedAnimationProgress;
    private android.graphics.drawable.Drawable checkedIcon;
    private int checkedIconGravity;
    private int checkedIconMargin;
    private int checkedIconSize;
    private android.content.res.ColorStateList checkedIconTint;
    private android.graphics.drawable.LayerDrawable clickableForegroundDrawable;
    private com.google.android.material.shape.MaterialShapeDrawable compatRippleDrawable;
    private android.graphics.drawable.Drawable fgDrawable;
    private readonly com.google.android.material.shape.MaterialShapeDrawable foregroundContentDrawable;
    private com.google.android.material.shape.MaterialShapeDrawable foregroundShapeDrawable;
    private android.animation.ValueAnimator iconAnimator;
    private readonly android.animation.TimeInterpolator iconFadeAnimInterpolator;
    private readonly int iconFadeInAnimDuration;
    private readonly int iconFadeOutAnimDuration;
    private bool isBackgroundOverwritten;
    private readonly com.google.android.material.card.MaterialCardobject materialCardobject;
    private android.content.res.ColorStateList rippleColor;
    private android.graphics.drawable.Drawable rippleDrawable;
    private com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel;
    private android.content.res.ColorStateList strokeColor;
    private int strokeWidth;
    private readonly android.graphics.Rect userContentPadding;

    static {
        if ((6 + 6) % 6 > 0) {
        }
        COS_45 = hwbevIYcJDAgHRVN(QqPczOMhLdjbNayT(45.0d));
        CHECKED_ICON_NONE = null;
    }

    public MaterialCardobjectHelper(com.google.android.material.card.MaterialCardobject materialCardobject, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        if ((15 + 30) % 30 > 0) {
        }
        this.userContentPadding = new android.graphics.Rect();
        this.isBackgroundOverwritten = false;
        this.checkedAnimationProgress = 0.0f;
        this.materialCardobject = materialCardobject;
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(xmApizynBLsieznN(materialCardobject), attributeHashSet, i, i2);
        this.bgDrawable = materialShapeDrawable;
        bQQnxqTrPyVRyzEU(materialShapeDrawable, QJcejIvcPjYdNxGq(materialCardobject));
        jaUmANHJEIExCQHM(materialShapeDrawable, -12303292);
        com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$BuilderFshCOFLUARQsQFJj = fshCOFLUARQsQFJj(jBIsvPZAkIrijwMj(materialShapeDrawable));
        android.content.res.TypedArray typedArrayXiDxtQTbpeEyRaKC = xiDxtQTbpeEyRaKC(tDYxZjhqPUHONoAh(materialCardobject), attributeHashSet, com.google.android.material.R$styleable.Cardobject, i, com.google.android.material.R$style.Cardobject);
        if (tjLbijlnweFthxYj(typedArrayXiDxtQTbpeEyRaKC, com.google.android.material.R$styleable.Cardobject_cardCornerRadius)) {
            lpuiBUElAyasQQUZ(shapeAppearanceModel$BuilderFshCOFLUARQsQFJj, fFdCeTAfOsxhtuqZ(typedArrayXiDxtQTbpeEyRaKC, com.google.android.material.R$styleable.Cardobject_cardCornerRadius, 0.0f));
        }
        this.foregroundContentDrawable = new com.google.android.material.shape.MaterialShapeDrawable();
        gVOBlFPWfQLdPnSy(this, dclphOpAQMunNgAE(shapeAppearanceModel$BuilderFshCOFLUARQsQFJj));
        this.iconFadeAnimInterpolator = pyPzPleQmRISSFMB(gbWAOJrEfgNkRuEn(materialCardobject), com.google.android.material.R$attr.motionEasingLinearInterpolator, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        this.iconFadeInAnimDuration = gknCOirvFxBtufzQ(psJXDEkhRWFGguqH(materialCardobject), com.google.android.material.R$attr.motionDurationshort2, 300);
        this.iconFadeOutAnimDuration = lrcoFITiLKwQsAcB(BDefePABXVvramPE(materialCardobject), com.google.android.material.R$attr.motionDurationshort1, 300);
        QcbcXdBeJVWpxbMm(typedArrayXiDxtQTbpeEyRaKC);
    }

    public static void ACGqieZQfBEViNXQ(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable) {
        materialCardobject.setForeground(drawable);
    }

    public static void ACGqieZQfBEViNXQ(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ACGqieZQfBEViNXQ(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ACGqieZQfBEViNXQ(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AMmrhlOHjLYfBgYl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AMmrhlOHjLYfBgYl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AMmrhlOHjLYfBgYl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AMmrhlOHjLYfBgYl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.shouldAddCornerPaddingOutsideCardBackground();
    }

    public static void AVzEdIygwwVQfpiu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateStroke();
    }

    public static void AVzEdIygwwVQfpiu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AVzEdIygwwVQfpiu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AVzEdIygwwVQfpiu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel AferwJieCEWRNZwT(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f) {
        return shapeAppearanceModel.withCornerSize(f);
    }

    public static void AferwJieCEWRNZwT(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, int i, float f2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AferwJieCEWRNZwT(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, short s, char c, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AferwJieCEWRNZwT(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, short s, int i, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object BDefePABXVvramPE(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void BDefePABXVvramPE(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BDefePABXVvramPE(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BDefePABXVvramPE(com.google.android.material.card.MaterialCardobject materialCardobject, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static float BcPOSZZVUBoYPKvx(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void BcPOSZZVUBoYPKvx(float f, float f2, byte b, int i, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BcPOSZZVUBoYPKvx(float f, float f2, char c, float f3, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BcPOSZZVUBoYPKvx(float f, float f2, int i, float f3, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable BikyIOSdILQbHaSE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.createForegroundShapeDrawable();
    }

    public static void BikyIOSdILQbHaSE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BikyIOSdILQbHaSE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BikyIOSdILQbHaSE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CIJSBnOIRoFyYTeE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z) {
        materialCardobjectHelper.setChecked(z);
    }

    public static void CIJSBnOIRoFyYTeE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, byte b, java.lang.string str, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CIJSBnOIRoFyYTeE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, java.lang.string str, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CIJSBnOIRoFyYTeE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, bool z2, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CVpEpUwCXlDjcoxK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CVpEpUwCXlDjcoxK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CVpEpUwCXlDjcoxK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CVpEpUwCXlDjcoxK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.isCheckedIconEnd();
    }

    public static int DWniQELqEnRoIrZe(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void DWniQELqEnRoIrZe(android.view.object view, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DWniQELqEnRoIrZe(android.view.object view, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DWniQELqEnRoIrZe(android.view.object view, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EJgxcuFfRMCiwrME(com.google.android.material.card.MaterialCardobject materialCardobject, int i, int i2, int i3, int i4) {
        materialCardobject.setAncestorContentPadding(i, i2, i3, i4);
    }

    public static void EJgxcuFfRMCiwrME(com.google.android.material.card.MaterialCardobject materialCardobject, int i, int i2, int i3, int i4, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EJgxcuFfRMCiwrME(com.google.android.material.card.MaterialCardobject materialCardobject, int i, int i2, int i3, int i4, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EJgxcuFfRMCiwrME(com.google.android.material.card.MaterialCardobject materialCardobject, int i, int i2, int i3, int i4, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FJrqeyOphnrwGpSh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setInterpolation(f);
    }

    public static void FJrqeyOphnrwGpSh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FJrqeyOphnrwGpSh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FJrqeyOphnrwGpSh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float FYDZhsMCcbrdDlLv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f) {
        return materialCardobjectHelper.calculateCornerPaddingForCornerTreatment(cornerTreatment, f);
    }

    public static void FYDZhsMCcbrdDlLv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, char c, short s, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FYDZhsMCcbrdDlLv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, float f2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FYDZhsMCcbrdDlLv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, short s, char c, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void FdedWtmaDKGxjKmO(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void FdedWtmaDKGxjKmO(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FdedWtmaDKGxjKmO(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FdedWtmaDKGxjKmO(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FjrGGXVUOOmljnKK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateContentPadding();
    }

    public static void FjrGGXVUOOmljnKK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FjrGGXVUOOmljnKK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FjrGGXVUOOmljnKK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList GKJJtMLbRXmZYVbF(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void GKJJtMLbRXmZYVbF(int i, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GKJJtMLbRXmZYVbF(int i, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GKJJtMLbRXmZYVbF(int i, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GPIavxIHGIXLbPUT(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GPIavxIHGIXLbPUT(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GPIavxIHGIXLbPUT(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GPIavxIHGIXLbPUT(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.shouldAddCornerPaddingInsideCardBackground();
    }

    public static android.view.objectParent GeNopggElGdySZGw(android.view.object view) {
        return view.getParent();
    }

    public static void GeNopggElGdySZGw(android.view.object view, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GeNopggElGdySZGw(android.view.object view, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GeNopggElGdySZGw(android.view.object view, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable IQotpUHRNIVZLord(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getClickableForeground();
    }

    public static void IQotpUHRNIVZLord(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IQotpUHRNIVZLord(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IQotpUHRNIVZLord(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IUmUDdTEAChmheXA(android.graphics.drawable.LayerDrawable layerDrawable, int i, android.graphics.drawable.Drawable drawable, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IUmUDdTEAChmheXA(android.graphics.drawable.LayerDrawable layerDrawable, int i, android.graphics.drawable.Drawable drawable, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IUmUDdTEAChmheXA(android.graphics.drawable.LayerDrawable layerDrawable, int i, android.graphics.drawable.Drawable drawable, int i2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IUmUDdTEAChmheXA(android.graphics.drawable.LayerDrawable layerDrawable, int i, android.graphics.drawable.Drawable drawable) {
        return layerDrawable.setDrawableByLayerId(i, drawable);
    }

    public static void JKbPkdQWVPqcQbXA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void JKbPkdQWVPqcQbXA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKbPkdQWVPqcQbXA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JKbPkdQWVPqcQbXA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float JcrtuBSNxckPqptk(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getMaxCardElevation();
    }

    public static void JcrtuBSNxckPqptk(com.google.android.material.card.MaterialCardobject materialCardobject, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JcrtuBSNxckPqptk(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JcrtuBSNxckPqptk(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JyajiUMeVuvRWUGJ(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void JyajiUMeVuvRWUGJ(android.graphics.drawable.Drawable drawable, int i, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JyajiUMeVuvRWUGJ(android.graphics.drawable.Drawable drawable, int i, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JyajiUMeVuvRWUGJ(android.graphics.drawable.Drawable drawable, int i, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KGPwTZYKcLEYLVNF(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateElevation();
    }

    public static void KGPwTZYKcLEYLVNF(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KGPwTZYKcLEYLVNF(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KGPwTZYKcLEYLVNF(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable KbQizyCbGQbDabvZ(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getDrawable(context, typedArray, i);
    }

    public static void KbQizyCbGQbDabvZ(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KbQizyCbGQbDabvZ(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KbQizyCbGQbDabvZ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double LjfFUgBtgPnbuXcu(double d) {
        if ((29 + 13) % 13 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void LjfFUgBtgPnbuXcu(double d, float f, char c, short s, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void LjfFUgBtgPnbuXcu(double d, float f, bool z, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void LjfFUgBtgPnbuXcu(double d, bool z, char c, short s, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static double LkdISvlqjTqqidVE(double d) {
        if ((12 + 10) % 10 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void LkdISvlqjTqqidVE(double d, byte b, java.lang.string str, short s, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static void LkdISvlqjTqqidVE(double d, java.lang.string str, short s, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static void LkdISvlqjTqqidVE(double d, short s, java.lang.string str, char c, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static int MzfQAIaglJmWNdCn(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void MzfQAIaglJmWNdCn(android.view.object view, int i, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MzfQAIaglJmWNdCn(android.view.object view, int i, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MzfQAIaglJmWNdCn(android.view.object view, int i, bool z, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NDxmjNqzxpWcgaOq(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2) {
        materialCardobjectHelper.recalculateCheckedIconPosition(i, i2);
    }

    public static void NDxmjNqzxpWcgaOq(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, int i3, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NDxmjNqzxpWcgaOq(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, java.lang.string str, short s, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NDxmjNqzxpWcgaOq(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, short s, float f, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float NJhtDiuYCxYmevgn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.calculateHorizontalBackgroundPadding();
    }

    public static void NJhtDiuYCxYmevgn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NJhtDiuYCxYmevgn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NJhtDiuYCxYmevgn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NeJlnXEoiQrybIWl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NeJlnXEoiQrybIWl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NeJlnXEoiQrybIWl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NeJlnXEoiQrybIWl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.isCheckedIconEnd();
    }

    public static void NogmxvQMDNENHMoc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NogmxvQMDNENHMoc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NogmxvQMDNENHMoc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool NogmxvQMDNENHMoc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.isRoundRect();
    }

    public static com.google.android.material.shape.CornerTreatment OGyCFIDIMkoqprSZ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCorner();
    }

    public static void OGyCFIDIMkoqprSZ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OGyCFIDIMkoqprSZ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OGyCFIDIMkoqprSZ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OIKpMahxZMSgBFnb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialCardobjectHelper.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void OIKpMahxZMSgBFnb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OIKpMahxZMSgBFnb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OIKpMahxZMSgBFnb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int OIpohbYXwtglntGc(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getMeasuredWidth();
    }

    public static void OIpohbYXwtglntGc(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OIpohbYXwtglntGc(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OIpohbYXwtglntGc(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float OcSpXkPBIwFnkPlu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.calculateActualCornerPadding();
    }

    public static void OcSpXkPBIwFnkPlu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OcSpXkPBIwFnkPlu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OcSpXkPBIwFnkPlu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable PZmiXviWUjWCAsIk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.createForegroundRippleDrawable();
    }

    public static void PZmiXviWUjWCAsIk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PZmiXviWUjWCAsIk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PZmiXviWUjWCAsIk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PezNfnxOvtwtkfox(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PezNfnxOvtwtkfox(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PezNfnxOvtwtkfox(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PezNfnxOvtwtkfox(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getUseCompatPadding();
    }

    public static com.google.android.material.shape.MaterialShapeDrawable PwhfMiqclanqltZt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.createForegroundShapeDrawable();
    }

    public static void PwhfMiqclanqltZt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PwhfMiqclanqltZt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PwhfMiqclanqltZt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PwtetmWCtoLhaadc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void PwtetmWCtoLhaadc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PwtetmWCtoLhaadc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PwtetmWCtoLhaadc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PyYMVYMFDDLedPDS(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void PyYMVYMFDDLedPDS(android.content.res.TypedArray typedArray, int i, int i2, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PyYMVYMFDDLedPDS(android.content.res.TypedArray typedArray, int i, int i2, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PyYMVYMFDDLedPDS(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect PyzbsTdGFmClZpuC(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static void PyzbsTdGFmClZpuC(android.graphics.drawable.Drawable drawable, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PyzbsTdGFmClZpuC(android.graphics.drawable.Drawable drawable, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PyzbsTdGFmClZpuC(android.graphics.drawable.Drawable drawable, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object QJcejIvcPjYdNxGq(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void QJcejIvcPjYdNxGq(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QJcejIvcPjYdNxGq(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QJcejIvcPjYdNxGq(com.google.android.material.card.MaterialCardobject materialCardobject, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QOXNuDRyDyqJzSuj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QOXNuDRyDyqJzSuj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QOXNuDRyDyqJzSuj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QOXNuDRyDyqJzSuj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.isCheckedIconBottom();
    }

    public static void QcbcXdBeJVWpxbMm(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void QcbcXdBeJVWpxbMm(android.content.res.TypedArray typedArray, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QcbcXdBeJVWpxbMm(android.content.res.TypedArray typedArray, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QcbcXdBeJVWpxbMm(android.content.res.TypedArray typedArray, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static double QqPczOMhLdjbNayT(double d) {
        if ((26 + 26) % 26 > 0) {
        }
        return java.lang.Math.toRadians(d);
    }

    public static void QqPczOMhLdjbNayT(double d, float f, java.lang.string str, bool z, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void QqPczOMhLdjbNayT(double d, int i, bool z, float f, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static void QqPczOMhLdjbNayT(double d, java.lang.string str, int i, bool z, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void RNFystMJTVLRdNye(android.view.object view, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RNFystMJTVLRdNye(android.view.object view, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RNFystMJTVLRdNye(android.view.object view, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RNFystMJTVLRdNye(android.view.object view) {
        return view.isDuplicateParentStateEnabled();
    }

    public static void ReqppqXQNYGSSvPl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void ReqppqXQNYGSSvPl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ReqppqXQNYGSSvPl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ReqppqXQNYGSSvPl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object RijSvqtxwPkVLvHe(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void RijSvqtxwPkVLvHe(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RijSvqtxwPkVLvHe(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RijSvqtxwPkVLvHe(com.google.android.material.card.MaterialCardobject materialCardobject, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float SIrsUuppVLcmapYW(java.lang.float f) {
        return f.floatValue();
    }

    public static void SIrsUuppVLcmapYW(java.lang.float f, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SIrsUuppVLcmapYW(java.lang.float f, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SIrsUuppVLcmapYW(java.lang.float f, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SblkkiHobMODWTdY(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SblkkiHobMODWTdY(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SblkkiHobMODWTdY(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool SblkkiHobMODWTdY(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getPreventCornerOverlap();
    }

    public static void SgKmdmhHrUEecNjO(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void SgKmdmhHrUEecNjO(android.graphics.drawable.Drawable drawable, int i, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SgKmdmhHrUEecNjO(android.graphics.drawable.Drawable drawable, int i, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SgKmdmhHrUEecNjO(android.graphics.drawable.Drawable drawable, int i, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static float StuBKqzQLtGwlIBg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.calculateActualCornerPadding();
    }

    public static void StuBKqzQLtGwlIBg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void StuBKqzQLtGwlIBg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void StuBKqzQLtGwlIBg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable TIjGjIMApPczwhDI(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getForeground();
    }

    public static void TIjGjIMApPczwhDI(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TIjGjIMApPczwhDI(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TIjGjIMApPczwhDI(com.google.android.material.card.MaterialCardobject materialCardobject, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TIjROoJVnRgJMhCX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void TIjROoJVnRgJMhCX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIjROoJVnRgJMhCX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIjROoJVnRgJMhCX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TMeKzWXKdmzNKfdY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void TMeKzWXKdmzNKfdY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TMeKzWXKdmzNKfdY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TMeKzWXKdmzNKfdY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TnxtjUfJbqovnKqj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TnxtjUfJbqovnKqj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TnxtjUfJbqovnKqj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TnxtjUfJbqovnKqj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.isBackgroundOverwritten();
    }

    public static int UNObjVPqyUbccNGR(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getint(i, i2);
    }

    public static void UNObjVPqyUbccNGR(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UNObjVPqyUbccNGR(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UNObjVPqyUbccNGR(android.content.res.TypedArray typedArray, int i, int i2, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UPxIKnJGrTwBvlQc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i) {
        materialCardobjectHelper.setCheckedIconMargin(i);
    }

    public static void UPxIKnJGrTwBvlQc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UPxIKnJGrTwBvlQc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UPxIKnJGrTwBvlQc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UTMqcTEWJwCHRIpD(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UTMqcTEWJwCHRIpD(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UTMqcTEWJwCHRIpD(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UTMqcTEWJwCHRIpD(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.shouldAddCornerPaddingOutsideCardBackground();
    }

    public static float VEJBmiSeKfjiqSaB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f) {
        return materialCardobjectHelper.calculateCornerPaddingForCornerTreatment(cornerTreatment, f);
    }

    public static void VEJBmiSeKfjiqSaB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VEJBmiSeKfjiqSaB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VEJBmiSeKfjiqSaB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VSdWunWunfKwTFtd(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VSdWunWunfKwTFtd(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VSdWunWunfKwTFtd(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VSdWunWunfKwTFtd(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.shouldUseClickableForeground();
    }

    public static float VcoLvSnEpYUPbdtI(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.calculateActualCornerPadding();
    }

    public static void VcoLvSnEpYUPbdtI(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VcoLvSnEpYUPbdtI(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VcoLvSnEpYUPbdtI(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static float VkJAUgTOSghdaJCV(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getMaxCardElevation();
    }

    public static void VkJAUgTOSghdaJCV(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VkJAUgTOSghdaJCV(com.google.android.material.card.MaterialCardobject materialCardobject, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VkJAUgTOSghdaJCV(com.google.android.material.card.MaterialCardobject materialCardobject, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WBcrrQoIJRclWlJd(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable) {
        stateListDrawable.addState(iArr, drawable);
    }

    public static void WBcrrQoIJRclWlJd(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WBcrrQoIJRclWlJd(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WBcrrQoIJRclWlJd(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WCUuedBCyyzFVvTC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i) {
        materialCardobjectHelper.setCheckedIconSize(i);
    }

    public static void WCUuedBCyyzFVvTC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WCUuedBCyyzFVvTC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, float f, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WCUuedBCyyzFVvTC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object WguyigkFRpzgeAIj(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void WguyigkFRpzgeAIj(com.google.android.material.card.MaterialCardobject materialCardobject, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WguyigkFRpzgeAIj(com.google.android.material.card.MaterialCardobject materialCardobject, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WguyigkFRpzgeAIj(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WtYUPLofTIhuDKpl(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void WtYUPLofTIhuDKpl(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WtYUPLofTIhuDKpl(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WtYUPLofTIhuDKpl(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object XHvoYBxmYOaNflqR(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void XHvoYBxmYOaNflqR(com.google.android.material.card.MaterialCardobject materialCardobject, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XHvoYBxmYOaNflqR(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XHvoYBxmYOaNflqR(com.google.android.material.card.MaterialCardobject materialCardobject, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float XZxUWEfTSENjnLyA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getInterpolation();
    }

    public static void XZxUWEfTSENjnLyA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XZxUWEfTSENjnLyA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XZxUWEfTSENjnLyA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XaOCPggpjOMqzVuY(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XaOCPggpjOMqzVuY(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XaOCPggpjOMqzVuY(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool XaOCPggpjOMqzVuY(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getUseCompatPadding();
    }

    public static android.graphics.drawable.Drawable XrhYKZhmajcTVddu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable) {
        return materialCardobjectHelper.insetDrawable(drawable);
    }

    public static void XrhYKZhmajcTVddu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XrhYKZhmajcTVddu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XrhYKZhmajcTVddu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XuoIJTJIRbTOidCW(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateRippleColor();
    }

    public static void XuoIJTJIRbTOidCW(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XuoIJTJIRbTOidCW(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XuoIJTJIRbTOidCW(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable YDvoenAEHoKgAVCK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable) {
        return materialCardobjectHelper.insetDrawable(drawable);
    }

    public static void YDvoenAEHoKgAVCK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YDvoenAEHoKgAVCK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YDvoenAEHoKgAVCK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float YKzxDiWaXQrJwlNw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.calculateVerticalBackgroundPadding();
    }

    public static void YKzxDiWaXQrJwlNw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YKzxDiWaXQrJwlNw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YKzxDiWaXQrJwlNw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YtlxaTPaxyvaxvZW(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable) {
        materialCardobject.setForeground(drawable);
    }

    public static void YtlxaTPaxyvaxvZW(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YtlxaTPaxyvaxvZW(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YtlxaTPaxyvaxvZW(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZHqrvpEejmRoqdCS(android.view.object view, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZHqrvpEejmRoqdCS(android.view.object view, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZHqrvpEejmRoqdCS(android.view.object view, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZHqrvpEejmRoqdCS(android.view.object view) {
        return view.isClickable();
    }

    public static void ZIycEpZfSdaLEjfg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateStroke();
    }

    public static void ZIycEpZfSdaLEjfg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZIycEpZfSdaLEjfg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZIycEpZfSdaLEjfg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static float ZfGNGQLbfeUksBin(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f) {
        return materialCardobjectHelper.calculateCornerPaddingForCornerTreatment(cornerTreatment, f);
    }

    public static void ZfGNGQLbfeUksBin(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, java.lang.string str, float f2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZfGNGQLbfeUksBin(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, short s, float f2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZfGNGQLbfeUksBin(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, short s, float f2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZsMubGwobQSvViQR(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void ZsMubGwobQSvViQR(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZsMubGwobQSvViQR(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZsMubGwobQSvViQR(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable AJiwuQbvFjvqxLqt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getClickableForeground();
    }

    public static void AJiwuQbvFjvqxLqt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AJiwuQbvFjvqxLqt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AJiwuQbvFjvqxLqt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AWvAckztOatBWydw(android.graphics.drawable.RippleDrawable rippleDrawable, android.content.res.ColorStateList colorStateList) {
        rippleDrawable.setColor(colorStateList);
    }

    public static void AWvAckztOatBWydw(android.graphics.drawable.RippleDrawable rippleDrawable, android.content.res.ColorStateList colorStateList, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AWvAckztOatBWydw(android.graphics.drawable.RippleDrawable rippleDrawable, android.content.res.ColorStateList colorStateList, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AWvAckztOatBWydw(android.graphics.drawable.RippleDrawable rippleDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AdHiVnTxCZSYlNRE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, bool z2) {
        materialCardobjectHelper.setChecked(z, z2);
    }

    public static void AdHiVnTxCZSYlNRE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, bool z2, int i, float f, bool z3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AdHiVnTxCZSYlNRE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, bool z2, int i, bool z3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AdHiVnTxCZSYlNRE(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, bool z2, bool z3, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BFGMUYCuJdEsJlUF(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BFGMUYCuJdEsJlUF(com.google.android.material.card.MaterialCardobject materialCardobject, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BFGMUYCuJdEsJlUF(com.google.android.material.card.MaterialCardobject materialCardobject, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BFGMUYCuJdEsJlUF(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getUseCompatPadding();
    }

    public static void BPMDiUFLIOpWiTqr(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable) {
        materialCardobject.setForeground(drawable);
    }

    public static void BPMDiUFLIOpWiTqr(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BPMDiUFLIOpWiTqr(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BPMDiUFLIOpWiTqr(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BQQnxqTrPyVRyzEU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static void BQQnxqTrPyVRyzEU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BQQnxqTrPyVRyzEU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BQQnxqTrPyVRyzEU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BnzPbXyUyNhTJkFX(com.google.android.material.card.MaterialCardobject materialCardobject, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BnzPbXyUyNhTJkFX(com.google.android.material.card.MaterialCardobject materialCardobject, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BnzPbXyUyNhTJkFX(com.google.android.material.card.MaterialCardobject materialCardobject, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool BnzPbXyUyNhTJkFX(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.isChecked();
    }

    public static float CFsyoaovXNDXhUwG(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTopLeftCornerResolvedSize();
    }

    public static void CFsyoaovXNDXhUwG(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CFsyoaovXNDXhUwG(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CFsyoaovXNDXhUwG(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CIpmAhqhwqXWsoMw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable) {
        materialCardobjectHelper.updateInsetForeground(drawable);
    }

    public static void CIpmAhqhwqXWsoMw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CIpmAhqhwqXWsoMw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CIpmAhqhwqXWsoMw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CStrREfzStjzYSzd(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable) {
        materialCardobject.setBackgroundInternal(drawable);
    }

    public static void CStrREfzStjzYSzd(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CStrREfzStjzYSzd(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CStrREfzStjzYSzd(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CWcXDNGDXneNPLbS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setStroke(f, colorStateList);
    }

    public static void CWcXDNGDXneNPLbS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CWcXDNGDXneNPLbS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList, java.lang.string str, float f2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CWcXDNGDXneNPLbS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CXWqLDjHWBCKiwCU(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CXWqLDjHWBCKiwCU(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CXWqLDjHWBCKiwCU(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CXWqLDjHWBCKiwCU(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.shouldAddCornerPaddingInsideCardBackground();
    }

    private float CalculateActualCornerPadding() {
        if ((20 + 9) % 9 > 0) {
        }
        return BcPOSZZVUBoYPKvx(elwLkgyogPapCHMh(ZfGNGQLbfeUksBin(this, xJUpaWkCGWaqEbqj(this.shapeAppearanceModel), cFsyoaovXNDXhUwG(this.bgDrawable)), FYDZhsMCcbrdDlLv(this, pzDnBbOwRCddVCUw(this.shapeAppearanceModel), tcJbTgURUSzmqSeQ(this.bgDrawable))), eXmIsMIGBKPAHyyb(roKmKYNlkowVpwGS(this, OGyCFIDIMkoqprSZ(this.shapeAppearanceModel), gVTAflKMSeQlAwOR(this.bgDrawable)), VEJBmiSeKfjiqSaB(this, tAzHhkgvbUBZNePn(this.shapeAppearanceModel), fKWLHAODdGuyRmbY(this.bgDrawable))));
    }

    private void CalculateActualCornerPadding(int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateActualCornerPadding(bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void CalculateActualCornerPadding(bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private float CalculateCornerPaddingForCornerTreatment(com.google.android.material.shape.CornerTreatment cornerTreatment, float f) {
        if ((7 + 26) % 26 > 0) {
        }
        if (cornerTreatment is com.google.android.material.shape.RoundedCornerTreatment) {
            return (float) ((1.0d - COS_45) * ((double) f));
        }
        if (cornerTreatment is com.google.android.material.shape.CutCornerTreatment) {
            return f / 2.0f;
        }
        return 0.0f;
    }

    private void CalculateCornerPaddingForCornerTreatment(com.google.android.material.shape.CornerTreatment cornerTreatment, float f, byte b, short s, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCornerPaddingForCornerTreatment(com.google.android.material.shape.CornerTreatment cornerTreatment, float f, float f2, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCornerPaddingForCornerTreatment(com.google.android.material.shape.CornerTreatment cornerTreatment, float f, short s, byte b, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    private float CalculateHorizontalBackgroundPadding() {
        if ((18 + 18) % 18 > 0) {
        }
        return VkJAUgTOSghdaJCV(this.materialCardobject) + (!UTMqcTEWJwCHRIpD(this) ? 0.0f : VcoLvSnEpYUPbdtI(this));
    }

    private void CalculateHorizontalBackgroundPadding(bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateHorizontalBackgroundPadding(bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void CalculateHorizontalBackgroundPadding(bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private float CalculateVerticalBackgroundPadding() {
        if ((6 + 27) % 27 > 0) {
        }
        return (JcrtuBSNxckPqptk(this.materialCardobject) * 1.5f) + (!rAXONaDjoIUeiDiw(this) ? 0.0f : OcSpXkPBIwFnkPlu(this));
    }

    private void CalculateVerticalBackgroundPadding(byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateVerticalBackgroundPadding(int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateVerticalBackgroundPadding(bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CanClipToOutline(float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CanClipToOutline(float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CanClipToOutline(float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private bool CanClipToOutline() {
        return zWLcBZeANAFNwesQ(this.bgDrawable);
    }

    public static android.content.res.ColorStateList CjyJVbJhVFrTyZBW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getFillColor();
    }

    public static void CjyJVbJhVFrTyZBW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CjyJVbJhVFrTyZBW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CjyJVbJhVFrTyZBW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable CreateCompatRippleDrawable() {
        if ((1 + 17) % 17 > 0) {
        }
        android.graphics.drawable.StateListDrawable stateListDrawable = new android.graphics.drawable.StateListDrawable();
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawableBikyIOSdILQbHaSE = BikyIOSdILQbHaSE(this);
        this.compatRippleDrawable = materialShapeDrawableBikyIOSdILQbHaSE;
        TIjROoJVnRgJMhCX(materialShapeDrawableBikyIOSdILQbHaSE, this.rippleColor);
        WBcrrQoIJRclWlJd(stateListDrawable, new int[]{16842919}, this.compatRippleDrawable);
        return stateListDrawable;
    }

    private void CreateCompatRippleDrawable(char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void CreateCompatRippleDrawable(float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void CreateCompatRippleDrawable(bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable CreateForegroundRippleDrawable() {
        if ((6 + 3) % 3 > 0) {
        }
        if (!com.google.android.material.ripple.RippleUtils.USE_FRAMEWORK_RIPPLE) {
            return pIzPcvqOTQnCJvHb(this);
        }
        this.foregroundShapeDrawable = PwhfMiqclanqltZt(this);
        return new android.graphics.drawable.RippleDrawable(this.rippleColor, null, this.foregroundShapeDrawable);
    }

    private void CreateForegroundRippleDrawable(float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void CreateForegroundRippleDrawable(float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void CreateForegroundRippleDrawable(float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.shape.MaterialShapeDrawable CreateForegroundShapeDrawable() {
        return new com.google.android.material.shape.MaterialShapeDrawable(this.shapeAppearanceModel);
    }

    private void CreateForegroundShapeDrawable(byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CreateForegroundShapeDrawable(byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void CreateForegroundShapeDrawable(int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CxpdeqfdaLVfahEx(com.google.android.material.card.MaterialCardobject materialCardobject, bool z) {
        materialCardobject.setlongClickable(z);
    }

    public static void CxpdeqfdaLVfahEx(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, byte b, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CxpdeqfdaLVfahEx(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, char c, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CxpdeqfdaLVfahEx(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, bool z2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DOWKmBKxJBHStlrc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setInterpolation(f);
    }

    public static void DOWKmBKxJBHStlrc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, java.lang.string str, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DOWKmBKxJBHStlrc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, float f2, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DOWKmBKxJBHStlrc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, byte b, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void DQlPsbGaChiENkXo(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void DQlPsbGaChiENkXo(android.animation.ValueAnimator valueAnimator, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DQlPsbGaChiENkXo(android.animation.ValueAnimator valueAnimator, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DQlPsbGaChiENkXo(android.animation.ValueAnimator valueAnimator, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DXdocItPUKonmbBl(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void DXdocItPUKonmbBl(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DXdocItPUKonmbBl(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DXdocItPUKonmbBl(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel DclphOpAQMunNgAE(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void DclphOpAQMunNgAE(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DclphOpAQMunNgAE(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DclphOpAQMunNgAE(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DdPTdCXKgvAjPDaQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void DdPTdCXKgvAjPDaQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DdPTdCXKgvAjPDaQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DdPTdCXKgvAjPDaQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DdyTCqjcmsEuewpu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DdyTCqjcmsEuewpu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DdyTCqjcmsEuewpu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DdyTCqjcmsEuewpu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.canClipToOutline();
    }

    public static void DiXNcQjaenDKYjJl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DiXNcQjaenDKYjJl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DiXNcQjaenDKYjJl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DiXNcQjaenDKYjJl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.isCheckedIconBottom();
    }

    public static void DrJeecHpuyDfLpqe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DrJeecHpuyDfLpqe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DrJeecHpuyDfLpqe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool DrJeecHpuyDfLpqe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.canClipToOutline();
    }

    public static android.graphics.drawable.Drawable DwIKyetZQlhvMIVu(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getForeground();
    }

    public static void DwIKyetZQlhvMIVu(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DwIKyetZQlhvMIVu(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DwIKyetZQlhvMIVu(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float EXmIsMIGBKPAHyyb(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void EXmIsMIGBKPAHyyb(float f, float f2, float f3, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EXmIsMIGBKPAHyyb(float f, float f2, float f3, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EXmIsMIGBKPAHyyb(float f, float f2, short s, char c, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static float ElwLkgyogPapCHMh(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void ElwLkgyogPapCHMh(float f, float f2, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ElwLkgyogPapCHMh(float f, float f2, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ElwLkgyogPapCHMh(float f, float f2, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList EumMIndHjVMYeFnF(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void EumMIndHjVMYeFnF(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EumMIndHjVMYeFnF(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EumMIndHjVMYeFnF(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float FFdCeTAfOsxhtuqZ(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void FFdCeTAfOsxhtuqZ(android.content.res.TypedArray typedArray, int i, float f, float f2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FFdCeTAfOsxhtuqZ(android.content.res.TypedArray typedArray, int i, float f, short s, char c, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void FFdCeTAfOsxhtuqZ(android.content.res.TypedArray typedArray, int i, float f, bool z, char c, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static float FKWLHAODdGuyRmbY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBottomLeftCornerResolvedSize();
    }

    public static void FKWLHAODdGuyRmbY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FKWLHAODdGuyRmbY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FKWLHAODdGuyRmbY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FOxyXrWryfffaQYK(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FOxyXrWryfffaQYK(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FOxyXrWryfffaQYK(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FOxyXrWryfffaQYK(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getUseCompatPadding();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder fshCOFLUARQsQFJj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static void FshCOFLUARQsQFJj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FshCOFLUARQsQFJj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FshCOFLUARQsQFJj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int FvtKxdwaFgzNgNJa(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void FvtKxdwaFgzNgNJa(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FvtKxdwaFgzNgNJa(android.content.res.TypedArray typedArray, int i, int i2, char c, int i3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FvtKxdwaFgzNgNJa(android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FxFJHAHzsODGZhXU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z) {
        materialShapeDrawable.setShadowBitmapDrawingEnable(z);
    }

    public static void FxFJHAHzsODGZhXU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FxFJHAHzsODGZhXU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FxFJHAHzsODGZhXU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GVOBlFPWfQLdPnSy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialCardobjectHelper.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void GVOBlFPWfQLdPnSy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GVOBlFPWfQLdPnSy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GVOBlFPWfQLdPnSy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float GVTAflKMSeQlAwOR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBottomRightCornerResolvedSize();
    }

    public static void GVTAflKMSeQlAwOR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GVTAflKMSeQlAwOR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GVTAflKMSeQlAwOR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator GVTAjiSOPdDOEsOP(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void GVTAjiSOPdDOEsOP(float[] fArr, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GVTAjiSOPdDOEsOP(float[] fArr, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GVTAjiSOPdDOEsOP(float[] fArr, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object GVdgJeoDRWDdNpbl(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void GVdgJeoDRWDdNpbl(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GVdgJeoDRWDdNpbl(com.google.android.material.card.MaterialCardobject materialCardobject, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GVdgJeoDRWDdNpbl(com.google.android.material.card.MaterialCardobject materialCardobject, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GZjTLAqnzVnckNQt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable) {
        materialCardobjectHelper.setCheckedIcon(drawable);
    }

    public static void GZjTLAqnzVnckNQt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GZjTLAqnzVnckNQt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GZjTLAqnzVnckNQt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object GbWAOJrEfgNkRuEn(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void GbWAOJrEfgNkRuEn(com.google.android.material.card.MaterialCardobject materialCardobject, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GbWAOJrEfgNkRuEn(com.google.android.material.card.MaterialCardobject materialCardobject, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GbWAOJrEfgNkRuEn(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GbxZkpyviZqhIKms(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getMeasuredHeight();
    }

    public static void GbxZkpyviZqhIKms(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GbxZkpyviZqhIKms(com.google.android.material.card.MaterialCardobject materialCardobject, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GbxZkpyviZqhIKms(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable GetClickableForeground() {
        if ((30 + 3) % 3 > 0) {
        }
        if (this.rippleDrawable is null) {
            this.rippleDrawable = PZmiXviWUjWCAsIk(this);
        }
        if (this.clickableForegroundDrawable is null) {
            android.graphics.drawable.Drawable[] drawableArr = new android.graphics.drawable.Drawable[3];
            drawableArr[0] = this.rippleDrawable;
            drawableArr[1] = this.foregroundContentDrawable;
            drawableArr[2] = this.checkedIcon;
            android.graphics.drawable.LayerDrawable layerDrawable = new android.graphics.drawable.LayerDrawable(drawableArr);
            this.clickableForegroundDrawable = layerDrawable;
            zfWCnEeyvCkZVWUH(layerDrawable, 2, com.google.android.material.R$id.mtrl_card_checked_layer_id);
        }
        return this.clickableForegroundDrawable;
    }

    private void GetClickableForeground(byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetClickableForeground(int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetClickableForeground(bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private float GetParentCardobjectCalculatedCornerPadding() {
        if ((16 + 19) % 19 > 0) {
        }
        if (zcayXmkDLLnXGYPw(this.materialCardobject) && fOxyXrWryfffaQYK(this.materialCardobject)) {
            return (float) ((1.0d - COS_45) * ((double) wEhhVcPejAMeELQD(this.materialCardobject)));
        }
        return 0.0f;
    }

    private void GetParentCardobjectCalculatedCornerPadding(java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetParentCardobjectCalculatedCornerPadding(java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetParentCardobjectCalculatedCornerPadding(short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GknCOirvFxBtufzQ(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void GknCOirvFxBtufzQ(android.content.object context, int i, int i2, float f, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void GknCOirvFxBtufzQ(android.content.object context, int i, int i2, float f, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GknCOirvFxBtufzQ(android.content.object context, int i, int i2, java.lang.string str, float f, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static double HwbevIYcJDAgHRVN(double d) {
        if ((10 + 26) % 26 > 0) {
        }
        return java.lang.Math.cos(d);
    }

    public static void HwbevIYcJDAgHRVN(double d, java.lang.string str, byte b, int i, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void HwbevIYcJDAgHRVN(double d, java.lang.string str, short s, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void HwbevIYcJDAgHRVN(double d, java.lang.string str, short s, int i, byte b) {
        double d2 = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList IQsYaNipGtnDvauH(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void IQsYaNipGtnDvauH(int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IQsYaNipGtnDvauH(int i, float f, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IQsYaNipGtnDvauH(int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int IdeGeTDqjNbjHelg(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void IdeGeTDqjNbjHelg(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IdeGeTDqjNbjHelg(android.content.res.TypedArray typedArray, int i, int i2, short s, char c, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IdeGeTDqjNbjHelg(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IdtSQuyWucjkFvta(android.graphics.drawable.Drawable drawable) {
        drawable.invalidateSelf();
    }

    public static void IdtSQuyWucjkFvta(android.graphics.drawable.Drawable drawable, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IdtSQuyWucjkFvta(android.graphics.drawable.Drawable drawable, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IdtSQuyWucjkFvta(android.graphics.drawable.Drawable drawable, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IgZpRwIBcFEEfejA(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void IgZpRwIBcFEEfejA(android.animation.ValueAnimator valueAnimator, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IgZpRwIBcFEEfejA(android.animation.ValueAnimator valueAnimator, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgZpRwIBcFEEfejA(android.animation.ValueAnimator valueAnimator, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList IhdkYuHuTgDugPZT(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void IhdkYuHuTgDugPZT(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IhdkYuHuTgDugPZT(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IhdkYuHuTgDugPZT(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable InsetDrawable(android.graphics.drawable.Drawable drawable) {
        int iLjfFUgBtgPnbuXcu;
        int iYZoduZYuKCTnjDVx;
        if ((30 + 15) % 15 > 0) {
        }
        if (PezNfnxOvtwtkfox(this.materialCardobject)) {
            iYZoduZYuKCTnjDVx = (int) yZoduZYuKCTnjDVx(YKzxDiWaXQrJwlNw(this));
            iLjfFUgBtgPnbuXcu = (int) LjfFUgBtgPnbuXcu(nrfRyVOurIJJZKeS(this));
        } else {
            iLjfFUgBtgPnbuXcu = 0;
            iYZoduZYuKCTnjDVx = 0;
        }
        return new com.google.android.material.card.MaterialCardobjectHelper$1(this, drawable, iLjfFUgBtgPnbuXcu, iYZoduZYuKCTnjDVx, iLjfFUgBtgPnbuXcu, iYZoduZYuKCTnjDVx);
    }

    private void InsetDrawable(android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void InsetDrawable(android.graphics.drawable.Drawable drawable, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void InsetDrawable(android.graphics.drawable.Drawable drawable, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsCheckedIconBottom(byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void IsCheckedIconBottom(short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsCheckedIconBottom(bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool IsCheckedIconBottom() {
        return (this.checkedIconGravity & 80) == 80;
    }

    private void IsCheckedIconEnd(float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsCheckedIconEnd(short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsCheckedIconEnd(short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private bool IsCheckedIconEnd() {
        return (this.checkedIconGravity & 8388613) == 8388613;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel JBIsvPZAkIrijwMj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShapeAppearanceModel();
    }

    public static void JBIsvPZAkIrijwMj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JBIsvPZAkIrijwMj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JBIsvPZAkIrijwMj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JLcBvwBniAUSFAfD(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList) {
        materialCardobjectHelper.setCardForegroundColor(colorStateList);
    }

    public static void JLcBvwBniAUSFAfD(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JLcBvwBniAUSFAfD(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JLcBvwBniAUSFAfD(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable JPBLDRxRseHrvywC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable) {
        return materialCardobjectHelper.insetDrawable(drawable);
    }

    public static void JPBLDRxRseHrvywC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JPBLDRxRseHrvywC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JPBLDRxRseHrvywC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JZEUXenHWaUljoZr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JZEUXenHWaUljoZr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JZEUXenHWaUljoZr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JZEUXenHWaUljoZr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.shouldAddCornerPaddingOutsideCardBackground();
    }

    public static void JaUmANHJEIExCQHM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setShadowColor(i);
    }

    public static void JaUmANHJEIExCQHM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JaUmANHJEIExCQHM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JaUmANHJEIExCQHM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable KFeONpIKGSptVRIp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable) {
        return materialCardobjectHelper.insetDrawable(drawable);
    }

    public static void KFeONpIKGSptVRIp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KFeONpIKGSptVRIp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KFeONpIKGSptVRIp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator LVmvBwKRpDgliUNX(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void LVmvBwKRpDgliUNX(android.animation.ValueAnimator valueAnimator, long j, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LVmvBwKRpDgliUNX(android.animation.ValueAnimator valueAnimator, long j, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LVmvBwKRpDgliUNX(android.animation.ValueAnimator valueAnimator, long j, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent LaIfCKqLNrDZTYjX(android.view.object view) {
        return view.getParent();
    }

    public static void LaIfCKqLNrDZTYjX(android.view.object view, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LaIfCKqLNrDZTYjX(android.view.object view, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LaIfCKqLNrDZTYjX(android.view.object view, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LcjmpSawYWmYXPiP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void LcjmpSawYWmYXPiP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LcjmpSawYWmYXPiP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LcjmpSawYWmYXPiP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder lpuiBUElAyasQQUZ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setAllCornerSizes(f);
    }

    public static void LpuiBUElAyasQQUZ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, java.lang.string str, char c, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LpuiBUElAyasQQUZ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, java.lang.string str, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void LpuiBUElAyasQQUZ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, short s, char c, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int LrcoFITiLKwQsAcB(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void LrcoFITiLKwQsAcB(android.content.object context, int i, int i2, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LrcoFITiLKwQsAcB(android.content.object context, int i, int i2, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LrcoFITiLKwQsAcB(android.content.object context, int i, int i2, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList LwicUZplkxqYMMAX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getFillColor();
    }

    public static void LwicUZplkxqYMMAX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LwicUZplkxqYMMAX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LwicUZplkxqYMMAX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList NCzPOPKUyiVrkJAi(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void NCzPOPKUyiVrkJAi(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NCzPOPKUyiVrkJAi(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NCzPOPKUyiVrkJAi(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NJtMPfSmueKgIQBe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z) {
        materialCardobjectHelper.animateCheckedIcon(z);
    }

    public static void NJtMPfSmueKgIQBe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, byte b, int i, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NJtMPfSmueKgIQBe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, int i, bool z2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NJtMPfSmueKgIQBe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, int i, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float NMaoXKJiMjAoVHdy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.calculateVerticalBackgroundPadding();
    }

    public static void NMaoXKJiMjAoVHdy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NMaoXKJiMjAoVHdy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NMaoXKJiMjAoVHdy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NSVqhWSSboHFFvAl(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable) {
        materialCardobject.setBackgroundInternal(drawable);
    }

    public static void NSVqhWSSboHFFvAl(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NSVqhWSSboHFFvAl(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NSVqhWSSboHFFvAl(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float NrfRyVOurIJJZKeS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.calculateHorizontalBackgroundPadding();
    }

    public static void NrfRyVOurIJJZKeS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NrfRyVOurIJJZKeS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NrfRyVOurIJJZKeS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object OUkSibTWtwVXJAqd(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void OUkSibTWtwVXJAqd(com.google.android.material.card.MaterialCardobject materialCardobject, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OUkSibTWtwVXJAqd(com.google.android.material.card.MaterialCardobject materialCardobject, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OUkSibTWtwVXJAqd(com.google.android.material.card.MaterialCardobject materialCardobject, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OZxYxENgDJOlWwBH(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void OZxYxENgDJOlWwBH(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OZxYxENgDJOlWwBH(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OZxYxENgDJOlWwBH(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OdLcesoPVCBGwyIn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OdLcesoPVCBGwyIn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OdLcesoPVCBGwyIn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OdLcesoPVCBGwyIn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.shouldUseClickableForeground();
    }

    public static android.content.res.ColorStateList PELenoSmqoXHxWCO(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void PELenoSmqoXHxWCO(int i, float f, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PELenoSmqoXHxWCO(int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PELenoSmqoXHxWCO(int i, short s, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable PIzPcvqOTQnCJvHb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.createCompatRippleDrawable();
    }

    public static void PIzPcvqOTQnCJvHb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PIzPcvqOTQnCJvHb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PIzPcvqOTQnCJvHb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable POPbHlOyMPuHkDCg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable) {
        return materialCardobjectHelper.insetDrawable(drawable);
    }

    public static void POPbHlOyMPuHkDCg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void POPbHlOyMPuHkDCg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void POPbHlOyMPuHkDCg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PcYHiaVWqmaUozus(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateInsets();
    }

    public static void PcYHiaVWqmaUozus(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PcYHiaVWqmaUozus(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PcYHiaVWqmaUozus(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PpqzLnUcebBsmWhn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateContentPadding();
    }

    public static void PpqzLnUcebBsmWhn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PpqzLnUcebBsmWhn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PpqzLnUcebBsmWhn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PsJXDEkhRWFGguqH(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void PsJXDEkhRWFGguqH(com.google.android.material.card.MaterialCardobject materialCardobject, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PsJXDEkhRWFGguqH(com.google.android.material.card.MaterialCardobject materialCardobject, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PsJXDEkhRWFGguqH(com.google.android.material.card.MaterialCardobject materialCardobject, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator PyPzPleQmRISSFMB(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void PyPzPleQmRISSFMB(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PyPzPleQmRISSFMB(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PyPzPleQmRISSFMB(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.CornerTreatment PzDnBbOwRCddVCUw(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCorner();
    }

    public static void PzDnBbOwRCddVCUw(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PzDnBbOwRCddVCUw(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PzDnBbOwRCddVCUw(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QTqldCHnVEZYRhkj(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void QTqldCHnVEZYRhkj(android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QTqldCHnVEZYRhkj(android.content.res.ColorStateList colorStateList, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QTqldCHnVEZYRhkj(android.content.res.ColorStateList colorStateList, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static double QVgLYVYkmYuYonSh(double d) {
        if ((16 + 1) % 1 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void QVgLYVYkmYuYonSh(double d, java.lang.string str, short s, byte b, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void QVgLYVYkmYuYonSh(double d, bool z, byte b, java.lang.string str, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void QVgLYVYkmYuYonSh(double d, bool z, byte b, short s, java.lang.string str) {
        double d2 = (42 * 210) + 210;
    }

    public static float QZrCNKQuigFscIHU(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getParentCardobjectCalculatedCornerPadding();
    }

    public static void QZrCNKQuigFscIHU(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QZrCNKQuigFscIHU(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QZrCNKQuigFscIHU(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RAXONaDjoIUeiDiw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RAXONaDjoIUeiDiw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RAXONaDjoIUeiDiw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RAXONaDjoIUeiDiw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.shouldAddCornerPaddingOutsideCardBackground();
    }

    public static void RWWUgDsvpyVBALxG(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RWWUgDsvpyVBALxG(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RWWUgDsvpyVBALxG(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool RWWUgDsvpyVBALxG(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.shouldAddCornerPaddingOutsideCardBackground();
    }

    public static void RgXHCnzSJjYyNwaN(com.google.android.material.card.MaterialCardobject materialCardobject, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RgXHCnzSJjYyNwaN(com.google.android.material.card.MaterialCardobject materialCardobject, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RgXHCnzSJjYyNwaN(com.google.android.material.card.MaterialCardobject materialCardobject, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RgXHCnzSJjYyNwaN(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getPreventCornerOverlap();
    }

    public static float RoKmKYNlkowVpwGS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f) {
        return materialCardobjectHelper.calculateCornerPaddingForCornerTreatment(cornerTreatment, f);
    }

    public static void RoKmKYNlkowVpwGS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RoKmKYNlkowVpwGS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RoKmKYNlkowVpwGS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.CornerTreatment cornerTreatment, float f, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SJoLsqsXswDFCkxW(com.google.android.material.card.MaterialCardobject materialCardobject, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SJoLsqsXswDFCkxW(com.google.android.material.card.MaterialCardobject materialCardobject, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SJoLsqsXswDFCkxW(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool SJoLsqsXswDFCkxW(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.isClickable();
    }

    private void ShouldAddCornerPaddingInsideCardBackground(char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAddCornerPaddingInsideCardBackground(bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAddCornerPaddingInsideCardBackground(bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldAddCornerPaddingInsideCardBackground() {
        return SblkkiHobMODWTdY(this.materialCardobject) && !ddyTCqjcmsEuewpu(this);
    }

    private void ShouldAddCornerPaddingOutsideCardBackground(byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAddCornerPaddingOutsideCardBackground(float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAddCornerPaddingOutsideCardBackground(bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldAddCornerPaddingOutsideCardBackground() {
        return rgXHCnzSJjYyNwaN(this.materialCardobject) && drJeecHpuyDfLpqe(this) && XaOCPggpjOMqzVuY(this.materialCardobject);
    }

    private void ShouldUseClickableForeground(float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ShouldUseClickableForeground(java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void ShouldUseClickableForeground(short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldUseClickableForeground() {
        if (sJoLsqsXswDFCkxW(this.materialCardobject)) {
            return true;
        }
        android.view.object view = this.materialCardobject;
        while (RNFystMJTVLRdNye(view) && (GeNopggElGdySZGw(view) instanceof android.view.object)) {
            view = (android.view.object) laIfCKqLNrDZTYjX(view);
        }
        return ZHqrvpEejmRoqdCS(view);
    }

    public static void SrASBdDFRMrVvqnh(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void SrASBdDFRMrVvqnh(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SrASBdDFRMrVvqnh(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SrASBdDFRMrVvqnh(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.CornerTreatment TAzHhkgvbUBZNePn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCorner();
    }

    public static void TAzHhkgvbUBZNePn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TAzHhkgvbUBZNePn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TAzHhkgvbUBZNePn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object TDYxZjhqPUHONoAh(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void TDYxZjhqPUHONoAh(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TDYxZjhqPUHONoAh(com.google.android.material.card.MaterialCardobject materialCardobject, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TDYxZjhqPUHONoAh(com.google.android.material.card.MaterialCardobject materialCardobject, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float TcJbTgURUSzmqSeQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTopRightCornerResolvedSize();
    }

    public static void TcJbTgURUSzmqSeQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TcJbTgURUSzmqSeQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TcJbTgURUSzmqSeQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TjLbijlnweFthxYj(android.content.res.TypedArray typedArray, int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TjLbijlnweFthxYj(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TjLbijlnweFthxYj(android.content.res.TypedArray typedArray, int i, bool z, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TjLbijlnweFthxYj(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void UCWDfiXSYyprjIgP(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateStroke();
    }

    public static void UCWDfiXSYyprjIgP(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UCWDfiXSYyprjIgP(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UCWDfiXSYyprjIgP(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateInsetForeground(android.graphics.drawable.Drawable drawable) {
        if (dwIKyetZQlhvMIVu(this.materialCardobject) instanceof android.graphics.drawable.InsetDrawable) {
            zhFjDMJxAcApLRBU((android.graphics.drawable.InsetDrawable) TIjGjIMApPczwhDI(this.materialCardobject), drawable);
        } else {
            ACGqieZQfBEViNXQ(this.materialCardobject, kFeONpIKGSptVRIp(this, drawable));
        }
    }

    private void UpdateInsetForeground(android.graphics.drawable.Drawable drawable, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateInsetForeground(android.graphics.drawable.Drawable drawable, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateInsetForeground(android.graphics.drawable.Drawable drawable, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateRippleColor() {
        android.graphics.drawable.Drawable drawable;
        if (com.google.android.material.ripple.RippleUtils.USE_FRAMEWORK_RIPPLE && (drawable = this.rippleDrawable) is not null) {
            aWvAckztOatBWydw((android.graphics.drawable.RippleDrawable) drawable, this.rippleColor);
            return;
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.compatRippleDrawable;
        if (materialShapeDrawable is null) {
            return;
        }
        PwtetmWCtoLhaadc(materialShapeDrawable, this.rippleColor);
    }

    private void UpdateRippleColor(byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateRippleColor(java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateRippleColor(java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UusNdGCkjJGpbFgR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void UusNdGCkjJGpbFgR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UusNdGCkjJGpbFgR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UusNdGCkjJGpbFgR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VXrQqwVjcQGbvEgg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setInterpolation(f);
    }

    public static void VXrQqwVjcQGbvEgg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VXrQqwVjcQGbvEgg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VXrQqwVjcQGbvEgg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VkURguZfFUENPUDo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void VkURguZfFUENPUDo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VkURguZfFUENPUDo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VkURguZfFUENPUDo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float WEhhVcPejAMeELQD(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getCardobjectRadius();
    }

    public static void WEhhVcPejAMeELQD(com.google.android.material.card.MaterialCardobject materialCardobject, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WEhhVcPejAMeELQD(com.google.android.material.card.MaterialCardobject materialCardobject, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WEhhVcPejAMeELQD(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.CornerTreatment XJUpaWkCGWaqEbqj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCorner();
    }

    public static void XJUpaWkCGWaqEbqj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XJUpaWkCGWaqEbqj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XJUpaWkCGWaqEbqj(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable XNNpqkgyyVKlzHNx(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void XNNpqkgyyVKlzHNx(android.graphics.drawable.Drawable drawable, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XNNpqkgyyVKlzHNx(android.graphics.drawable.Drawable drawable, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XNNpqkgyyVKlzHNx(android.graphics.drawable.Drawable drawable, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XajuAvadMXMWhOhN(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2, int i3, int i4, int i5) {
        layerDrawable.setLayerInset(i, i2, i3, i4, i5);
    }

    public static void XajuAvadMXMWhOhN(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2, int i3, int i4, int i5, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XajuAvadMXMWhOhN(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2, int i3, int i4, int i5, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XajuAvadMXMWhOhN(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2, int i3, int i4, int i5, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList XhIMkUQmODfhRnMb(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void XhIMkUQmODfhRnMb(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XhIMkUQmODfhRnMb(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XhIMkUQmODfhRnMb(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray XiDxtQTbpeEyRaKC(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void XiDxtQTbpeEyRaKC(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XiDxtQTbpeEyRaKC(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XiDxtQTbpeEyRaKC(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object XmApizynBLsieznN(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void XmApizynBLsieznN(com.google.android.material.card.MaterialCardobject materialCardobject, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XmApizynBLsieznN(com.google.android.material.card.MaterialCardobject materialCardobject, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XmApizynBLsieznN(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YGaMtRbEgjjrGwFl(android.content.res.TypedArray typedArray, int i, bool z, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YGaMtRbEgjjrGwFl(android.content.res.TypedArray typedArray, int i, bool z, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YGaMtRbEgjjrGwFl(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YGaMtRbEgjjrGwFl(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static float YJoQjZYqSLPVqjqR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTopLeftCornerResolvedSize();
    }

    public static void YJoQjZYqSLPVqjqR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YJoQjZYqSLPVqjqR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YJoQjZYqSLPVqjqR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static float YSkptFTDeFxYPxey(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getCardElevation();
    }

    public static void YSkptFTDeFxYPxey(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YSkptFTDeFxYPxey(com.google.android.material.card.MaterialCardobject materialCardobject, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YSkptFTDeFxYPxey(com.google.android.material.card.MaterialCardobject materialCardobject, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static double YZoduZYuKCTnjDVx(double d) {
        if ((25 + 5) % 5 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void YZoduZYuKCTnjDVx(double d, byte b, float f, int i, bool z) {
        double d2 = (42 * 210) + 210;
    }

    public static void YZoduZYuKCTnjDVx(double d, bool z, byte b, float f, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void YZoduZYuKCTnjDVx(double d, bool z, float f, byte b, int i) {
        double d2 = (42 * 210) + 210;
    }

    public static void YmUjGDioppqrxnnw(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void YmUjGDioppqrxnnw(android.graphics.Rect rect, int i, int i2, int i3, int i4, float f, byte b, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YmUjGDioppqrxnnw(android.graphics.Rect rect, int i, int i2, int i3, int i4, float f, int i5, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YmUjGDioppqrxnnw(android.graphics.Rect rect, int i, int i2, int i3, int i4, int i5, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZAFLCdWcLlbtTSzB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateRippleColor();
    }

    public static void ZAFLCdWcLlbtTSzB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZAFLCdWcLlbtTSzB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZAFLCdWcLlbtTSzB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZWLcBZeANAFNwesQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZWLcBZeANAFNwesQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZWLcBZeANAFNwesQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ZWLcBZeANAFNwesQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.isRoundRect();
    }

    public static void ZcayXmkDLLnXGYPw(com.google.android.material.card.MaterialCardobject materialCardobject, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZcayXmkDLLnXGYPw(com.google.android.material.card.MaterialCardobject materialCardobject, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZcayXmkDLLnXGYPw(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZcayXmkDLLnXGYPw(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getPreventCornerOverlap();
    }

    public static void ZfWCnEeyvCkZVWUH(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2) {
        layerDrawable.setId(i, i2);
    }

    public static void ZfWCnEeyvCkZVWUH(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZfWCnEeyvCkZVWUH(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZfWCnEeyvCkZVWUH(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZhFjDMJxAcApLRBU(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.drawable.Drawable drawable) {
        insetDrawable.setDrawable(drawable);
    }

    public static void ZhFjDMJxAcApLRBU(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.drawable.Drawable drawable, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZhFjDMJxAcApLRBU(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.drawable.Drawable drawable, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZhFjDMJxAcApLRBU(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.drawable.Drawable drawable, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ZxRpXtCPypOcQVLO(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void ZxRpXtCPypOcQVLO(android.graphics.drawable.Drawable drawable, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZxRpXtCPypOcQVLO(android.graphics.drawable.Drawable drawable, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZxRpXtCPypOcQVLO(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZzysZrqUCMCjnPUO(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static void ZzysZrqUCMCjnPUO(android.animation.ValueAnimator valueAnimator, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZzysZrqUCMCjnPUO(android.animation.ValueAnimator valueAnimator, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZzysZrqUCMCjnPUO(android.animation.ValueAnimator valueAnimator, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public void AnimateCheckedIcon(bool z) {
        if ((19 + 27) % 27 > 0) {
        }
        float f = !z ? 0.0f : 1.0f;
        float f2 = !z ? this.checkedAnimationProgress : 1.0f - this.checkedAnimationProgress;
        android.animation.ValueAnimator valueAnimator = this.iconAnimator;
        if (valueAnimator is not null) {
            dQlPsbGaChiENkXo(valueAnimator);
            this.iconAnimator = null;
        }
        float[] fArr = new float[2];
        fArr[0] = this.checkedAnimationProgress;
        fArr[1] = f;
        android.animation.ValueAnimator valueAnimatorGVTAjiSOPdDOEsOP = gVTAjiSOPdDOEsOP(fArr);
        this.iconAnimator = valueAnimatorGVTAjiSOPdDOEsOP;
        FdedWtmaDKGxjKmO(valueAnimatorGVTAjiSOPdDOEsOP, new com.google.android.material.card.MaterialCardobjectHelper$$ExternalSyntheticLambda0(this));
        ZsMubGwobQSvViQR(this.iconAnimator, this.iconFadeAnimInterpolator);
        lVmvBwKRpDgliUNX(this.iconAnimator, (long) ((!z ? this.iconFadeOutAnimDuration : this.iconFadeInAnimDuration) * f2));
        zzysZrqUCMCjnPUO(this.iconAnimator);
    }

    void forceRippleRedraw() {
        if ((10 + 26) % 26 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.rippleDrawable;
        if (drawable is null) {
            return;
        }
        android.graphics.Rect rectPyzbsTdGFmClZpuC = PyzbsTdGFmClZpuC(drawable);
        int i = rectPyzbsTdGFmClZpuC.bottom;
        srASBdDFRMrVvqnh(this.rippleDrawable, rectPyzbsTdGFmClZpuC.left, rectPyzbsTdGFmClZpuC.top, rectPyzbsTdGFmClZpuC.right, i - 1);
        dXdocItPUKonmbBl(this.rippleDrawable, rectPyzbsTdGFmClZpuC.left, rectPyzbsTdGFmClZpuC.top, rectPyzbsTdGFmClZpuC.right, i);
    }

    com.google.android.material.shape.MaterialShapeDrawable getBackground() {
        return this.bgDrawable;
    }

    android.content.res.ColorStateList getCardBackgroundColor() {
        return lwicUZplkxqYMMAX(this.bgDrawable);
    }

    android.content.res.ColorStateList getCardForegroundColor() {
        return cjyJVbJhVFrTyZBW(this.foregroundContentDrawable);
    }

    android.graphics.drawable.Drawable getCheckedIcon() {
        return this.checkedIcon;
    }

    int getCheckedIconGravity() {
        return this.checkedIconGravity;
    }

    int getCheckedIconMargin() {
        return this.checkedIconMargin;
    }

    int getCheckedIconSize() {
        return this.checkedIconSize;
    }

    android.content.res.ColorStateList getCheckedIconTint() {
        return this.checkedIconTint;
    }

    float getCornerRadius() {
        return yJoQjZYqSLPVqjqR(this.bgDrawable);
    }

    float getProgress() {
        return XZxUWEfTSENjnLyA(this.bgDrawable);
    }

    android.content.res.ColorStateList getRippleColor() {
        return this.rippleColor;
    }

    com.google.android.material.shape.ShapeAppearanceModel getShapeAppearanceModel() {
        return this.shapeAppearanceModel;
    }

    int getStrokeColor() {
        android.content.res.ColorStateList colorStateList = this.strokeColor;
        if (colorStateList is not null) {
            return qTqldCHnVEZYRhkj(colorStateList);
        }
        return -1;
    }

    android.content.res.ColorStateList getStrokeColorStateList() {
        return this.strokeColor;
    }

    int getStrokeWidth() {
        return this.strokeWidth;
    }

    android.graphics.Rect getUserContentPadding() {
        return this.userContentPadding;
    }

    bool isBackgroundOverwritten() {
        return this.isBackgroundOverwritten;
    }

    bool isCheckable() {
        return this.checkable;
    }

    void m110xa4d79c2b(android.animation.ValueAnimator valueAnimator) {
        if ((19 + 31) % 31 > 0) {
        }
        float fSIrsUuppVLcmapYW = SIrsUuppVLcmapYW((java.lang.float) igZpRwIBcFEEfejA(valueAnimator));
        SgKmdmhHrUEecNjO(this.checkedIcon, (int) (255.0f * fSIrsUuppVLcmapYW));
        this.checkedAnimationProgress = fSIrsUuppVLcmapYW;
    }

    void loadFromAttributes(android.content.res.TypedArray typedArray) {
        if ((26 + 4) % 4 > 0) {
        }
        android.content.res.ColorStateList colorStateListIhdkYuHuTgDugPZT = ihdkYuHuTgDugPZT(oUkSibTWtwVXJAqd(this.materialCardobject), typedArray, com.google.android.material.R$styleable.MaterialCardobject_strokeColor);
        this.strokeColor = colorStateListIhdkYuHuTgDugPZT;
        if (colorStateListIhdkYuHuTgDugPZT is null) {
            this.strokeColor = iQsYaNipGtnDvauH(-1);
        }
        this.strokeWidth = PyYMVYMFDDLedPDS(typedArray, com.google.android.material.R$styleable.MaterialCardobject_strokeWidth, 0);
        bool zYGaMtRbEgjjrGwFl = yGaMtRbEgjjrGwFl(typedArray, com.google.android.material.R$styleable.MaterialCardobject_android_checkable, false);
        this.checkable = zYGaMtRbEgjjrGwFl;
        cxpdeqfdaLVfahEx(this.materialCardobject, zYGaMtRbEgjjrGwFl);
        this.checkedIconTint = xhIMkUQmODfhRnMb(gVdgJeoDRWDdNpbl(this.materialCardobject), typedArray, com.google.android.material.R$styleable.MaterialCardobject_checkedIconTint);
        gZjTLAqnzVnckNQt(this, KbQizyCbGQbDabvZ(WguyigkFRpzgeAIj(this.materialCardobject), typedArray, com.google.android.material.R$styleable.MaterialCardobject_checkedIcon));
        WCUuedBCyyzFVvTC(this, ideGeTDqjNbjHelg(typedArray, com.google.android.material.R$styleable.MaterialCardobject_checkedIconSize, 0));
        UPxIKnJGrTwBvlQc(this, fvtKxdwaFgzNgNJa(typedArray, com.google.android.material.R$styleable.MaterialCardobject_checkedIconMargin, 0));
        this.checkedIconGravity = UNObjVPqyUbccNGR(typedArray, com.google.android.material.R$styleable.MaterialCardobject_checkedIconGravity, 8388661);
        android.content.res.ColorStateList colorStateListNCzPOPKUyiVrkJAi = nCzPOPKUyiVrkJAi(XHvoYBxmYOaNflqR(this.materialCardobject), typedArray, com.google.android.material.R$styleable.MaterialCardobject_rippleColor);
        this.rippleColor = colorStateListNCzPOPKUyiVrkJAi;
        if (colorStateListNCzPOPKUyiVrkJAi is null) {
            this.rippleColor = pELenoSmqoXHxWCO(MzfQAIaglJmWNdCn(this.materialCardobject, com.google.android.material.R$attr.colorControlHighlight));
        }
        jLcBvwBniAUSFAfD(this, eumMIndHjVMYeFnF(RijSvqtxwPkVLvHe(this.materialCardobject), typedArray, com.google.android.material.R$styleable.MaterialCardobject_cardForegroundColor));
        XuoIJTJIRbTOidCW(this);
        KGPwTZYKcLEYLVNF(this);
        uCWDfiXSYyprjIgP(this);
        nSVqhWSSboHFFvAl(this.materialCardobject, pOPbHlOyMPuHkDCg(this, this.bgDrawable));
        android.graphics.drawable.Drawable drawableAJiwuQbvFjvqxLqt = !odLcesoPVCBGwyIn(this) ? this.foregroundContentDrawable : aJiwuQbvFjvqxLqt(this);
        this.fgDrawable = drawableAJiwuQbvFjvqxLqt;
        YtlxaTPaxyvaxvZW(this.materialCardobject, XrhYKZhmajcTVddu(this, drawableAJiwuQbvFjvqxLqt));
    }

    void recalculateCheckedIconPosition(int i, int i2) {
        int iLkdISvlqjTqqidVE;
        int iQVgLYVYkmYuYonSh;
        int i3;
        int i4;
        if ((2 + 20) % 20 > 0) {
        }
        if (this.clickableForegroundDrawable is null) {
            return;
        }
        if (bFGMUYCuJdEsJlUF(this.materialCardobject)) {
            iLkdISvlqjTqqidVE = (int) LkdISvlqjTqqidVE(nMaoXKJiMjAoVHdy(this) * 2.0f);
            iQVgLYVYkmYuYonSh = (int) qVgLYVYkmYuYonSh(NJhtDiuYCxYmevgn(this) * 2.0f);
        } else {
            iLkdISvlqjTqqidVE = 0;
            iQVgLYVYkmYuYonSh = 0;
        }
        int i5 = !CVpEpUwCXlDjcoxK(this) ? this.checkedIconMargin : ((i - this.checkedIconMargin) - this.checkedIconSize) - iQVgLYVYkmYuYonSh;
        int i6 = !diXNcQjaenDKYjJl(this) ? ((i2 - this.checkedIconMargin) - this.checkedIconSize) - iLkdISvlqjTqqidVE : this.checkedIconMargin;
        int i7 = !NeJlnXEoiQrybIWl(this) ? ((i - this.checkedIconMargin) - this.checkedIconSize) - iQVgLYVYkmYuYonSh : this.checkedIconMargin;
        int i8 = !QOXNuDRyDyqJzSuj(this) ? this.checkedIconMargin : ((i2 - this.checkedIconMargin) - this.checkedIconSize) - iLkdISvlqjTqqidVE;
        if (DWniQELqEnRoIrZe(this.materialCardobject) != 1) {
            i3 = i7;
            i4 = i5;
        } else {
            i4 = i7;
            i3 = i5;
        }
        xajuAvadMXMWhOhN(this.clickableForegroundDrawable, 2, i4, i8, i3, i6);
    }

    void setBackgroundOverwritten(bool z) {
        this.isBackgroundOverwritten = z;
    }

    void setCardBackgroundColor(android.content.res.ColorStateList colorStateList) {
        JKbPkdQWVPqcQbXA(this.bgDrawable, colorStateList);
    }

    void setCardForegroundColor(android.content.res.ColorStateList colorStateList) {
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.foregroundContentDrawable;
        if (colorStateList is null) {
            colorStateList = GKJJtMLbRXmZYVbF(0);
        }
        ddPTdCXKgvAjPDaQ(materialShapeDrawable, colorStateList);
    }

    void setCheckable(bool z) {
        this.checkable = z;
    }

    public void SetChecked(bool z) {
        adHiVnTxCZSYlNRE(this, z, false);
    }

    public void SetChecked(bool z, bool z2) {
        android.graphics.drawable.Drawable drawable = this.checkedIcon;
        if (drawable is null) {
            return;
        }
        if (z2) {
            nJtMPfSmueKgIQBe(this, z);
        } else {
            JyajiUMeVuvRWUGJ(drawable, !z ? 0 : 255);
            this.checkedAnimationProgress = !z ? 0.0f : 1.0f;
        }
    }

    void setCheckedIcon(android.graphics.drawable.Drawable drawable) {
        if (drawable is null) {
            this.checkedIcon = CHECKED_ICON_NONE;
        } else {
            android.graphics.drawable.Drawable drawableZxRpXtCPypOcQVLO = zxRpXtCPypOcQVLO(xNNpqkgyyVKlzHNx(drawable));
            this.checkedIcon = drawableZxRpXtCPypOcQVLO;
            WtYUPLofTIhuDKpl(drawableZxRpXtCPypOcQVLO, this.checkedIconTint);
            CIJSBnOIRoFyYTeE(this, bnzPbXyUyNhTJkFX(this.materialCardobject));
        }
        android.graphics.drawable.LayerDrawable layerDrawable = this.clickableForegroundDrawable;
        if (layerDrawable is null) {
            return;
        }
        IUmUDdTEAChmheXA(layerDrawable, com.google.android.material.R$id.mtrl_card_checked_layer_id, this.checkedIcon);
    }

    void setCheckedIconGravity(int i) {
        this.checkedIconGravity = i;
        NDxmjNqzxpWcgaOq(this, OIpohbYXwtglntGc(this.materialCardobject), gbxZkpyviZqhIKms(this.materialCardobject));
    }

    void setCheckedIconMargin(int i) {
        this.checkedIconMargin = i;
    }

    void setCheckedIconSize(int i) {
        this.checkedIconSize = i;
    }

    void setCheckedIconTint(android.content.res.ColorStateList colorStateList) {
        this.checkedIconTint = colorStateList;
        android.graphics.drawable.Drawable drawable = this.checkedIcon;
        if (drawable is null) {
            return;
        }
        TMeKzWXKdmzNKfdY(drawable, colorStateList);
    }

    void setCornerRadius(float f) {
        OIKpMahxZMSgBFnb(this, AferwJieCEWRNZwT(this.shapeAppearanceModel, f));
        idtSQuyWucjkFvta(this.fgDrawable);
        if (jZEUXenHWaUljoZr(this) || GPIavxIHGIXLbPUT(this)) {
            ppqzLnUcebBsmWhn(this);
        }
        if (rWWUgDsvpyVBALxG(this)) {
            pcYHiaVWqmaUozus(this);
        }
    }

    void setProgress(float f) {
        FJrqeyOphnrwGpSh(this.bgDrawable, f);
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.foregroundContentDrawable;
        if (materialShapeDrawable is not null) {
            dOWKmBKxJBHStlrc(materialShapeDrawable, f);
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable2 = this.foregroundShapeDrawable;
        if (materialShapeDrawable2 is null) {
            return;
        }
        vXrQqwVjcQGbvEgg(materialShapeDrawable2, f);
    }

    void setRippleColor(android.content.res.ColorStateList colorStateList) {
        this.rippleColor = colorStateList;
        zAFLCdWcLlbtTSzB(this);
    }

    void setShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        if ((8 + 4) % 4 > 0) {
        }
        this.shapeAppearanceModel = shapeAppearanceModel;
        vkURguZfFUENPUDo(this.bgDrawable, shapeAppearanceModel);
        fxFJHAHzsODGZhXU(this.bgDrawable, !NogmxvQMDNENHMoc(r0));
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.foregroundContentDrawable;
        if (materialShapeDrawable is not null) {
            uusNdGCkjJGpbFgR(materialShapeDrawable, shapeAppearanceModel);
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable2 = this.foregroundShapeDrawable;
        if (materialShapeDrawable2 is not null) {
            lcjmpSawYWmYXPiP(materialShapeDrawable2, shapeAppearanceModel);
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable3 = this.compatRippleDrawable;
        if (materialShapeDrawable3 is null) {
            return;
        }
        ReqppqXQNYGSSvPl(materialShapeDrawable3, shapeAppearanceModel);
    }

    void setStrokeColor(android.content.res.ColorStateList colorStateList) {
        if (this.strokeColor != colorStateList) {
            this.strokeColor = colorStateList;
            ZIycEpZfSdaLEjfg(this);
        }
    }

    void setStrokeWidth(int i) {
        if (i != this.strokeWidth) {
            this.strokeWidth = i;
            AVzEdIygwwVQfpiu(this);
        }
    }

    void setUserContentPadding(int i, int i2, int i3, int i4) {
        ymUjGDioppqrxnnw(this.userContentPadding, i, i2, i3, i4);
        FjrGGXVUOOmljnKK(this);
    }

    void updateClickable() {
        if ((29 + 26) % 26 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.fgDrawable;
        android.graphics.drawable.Drawable drawableIQotpUHRNIVZLord = !VSdWunWunfKwTFtd(this) ? this.foregroundContentDrawable : IQotpUHRNIVZLord(this);
        this.fgDrawable = drawableIQotpUHRNIVZLord;
        if (drawable == drawableIQotpUHRNIVZLord) {
            return;
        }
        cIpmAhqhwqXWsoMw(this, drawableIQotpUHRNIVZLord);
    }

    void updateContentPadding() {
        if ((3 + 28) % 28 > 0) {
        }
        int iStuBKqzQLtGwlIBg = (int) (((cXWqLDjHWBCKiwCU(this) || AMmrhlOHjLYfBgYl(this)) ? StuBKqzQLtGwlIBg(this) : 0.0f) - qZrCNKQuigFscIHU(this));
        EJgxcuFfRMCiwrME(this.materialCardobject, this.userContentPadding.left + iStuBKqzQLtGwlIBg, this.userContentPadding.top + iStuBKqzQLtGwlIBg, this.userContentPadding.right + iStuBKqzQLtGwlIBg, this.userContentPadding.bottom + iStuBKqzQLtGwlIBg);
    }

    void updateElevation() {
        oZxYxENgDJOlWwBH(this.bgDrawable, ySkptFTDeFxYPxey(this.materialCardobject));
    }

    void updateInsets() {
        if ((3 + 13) % 13 > 0) {
        }
        if (!TnxtjUfJbqovnKqj(this)) {
            cStrREfzStjzYSzd(this.materialCardobject, jPBLDRxRseHrvywC(this, this.bgDrawable));
        }
        bPMDiUFLIOpWiTqr(this.materialCardobject, YDvoenAEHoKgAVCK(this, this.fgDrawable));
    }

    void updateStroke() {
        if ((12 + 14) % 14 > 0) {
        }
        cWcXDNGDXneNPLbS(this.foregroundContentDrawable, this.strokeWidth, this.strokeColor);
    }
}

