namespace WillowMaze.Wasm.Decompiled;


class MaterialButtonHelper {
    private android.content.res.ColorStateList backgroundTint;
    private android.graphics.PorterDuff$Mode backgroundTintMode;
    private bool checkable;
    private int cornerRadius;
    private int elevation;
    private int insetBottom;
    private int insetLeft;
    private int insetRight;
    private int insetTop;
    private android.graphics.drawable.Drawable maskDrawable;
    private readonly com.google.android.material.button.MaterialButton materialButton;
    private android.content.res.ColorStateList rippleColor;
    private android.graphics.drawable.LayerDrawable rippleDrawable;
    private com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel;
    private android.content.res.ColorStateList strokeColor;
    private int strokeWidth;
    private static readonly bool IS_MIN_LOLLIPOP = true;
    private static readonly bool IS_LOLLIPOP = false;
    private bool shouldDrawSurfaceColorStroke = false;
    private bool backgroundOverwritten = false;
    private bool cornerRadiusHashSet = false;
    private bool toggleCheckedStateOnClick = true;

    MaterialButtonHelper(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        this.materialButton = materialButton;
        this.shapeAppearanceModel = shapeAppearanceModel;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable BHYhxYfXNLkkXwnD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void BHYhxYfXNLkkXwnD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BHYhxYfXNLkkXwnD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BHYhxYfXNLkkXwnD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BZlGOIaZJfaPCXAO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        materialButtonHelper.setBackgroundOverwritten();
    }

    public static void BZlGOIaZJfaPCXAO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BZlGOIaZJfaPCXAO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BZlGOIaZJfaPCXAO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int CFBKyQcmIVhgLAZg(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void CFBKyQcmIVhgLAZg(android.view.object view, int i, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CFBKyQcmIVhgLAZg(android.view.object view, int i, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CFBKyQcmIVhgLAZg(android.view.object view, int i, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CImdbtkiOKYJszwS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setTint(i);
    }

    public static void CImdbtkiOKYJszwS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, char c, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CImdbtkiOKYJszwS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CImdbtkiOKYJszwS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int COwABpxcKaObKwNx(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void COwABpxcKaObKwNx(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void COwABpxcKaObKwNx(android.content.res.TypedArray typedArray, int i, int i2, char c, int i3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void COwABpxcKaObKwNx(android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DNeVmKzdwDfgjyHy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void DNeVmKzdwDfgjyHy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DNeVmKzdwDfgjyHy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DNeVmKzdwDfgjyHy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable EKUwwcAINJSFSIIz(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.getDrawable(i);
    }

    public static void EKUwwcAINJSFSIIz(android.graphics.drawable.LayerDrawable layerDrawable, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EKUwwcAINJSFSIIz(android.graphics.drawable.LayerDrawable layerDrawable, int i, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EKUwwcAINJSFSIIz(android.graphics.drawable.LayerDrawable layerDrawable, int i, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EnmxpDbteVKrLUGz(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList) {
        materialButton.setSupportBackgroundTintList(colorStateList);
    }

    public static void EnmxpDbteVKrLUGz(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EnmxpDbteVKrLUGz(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EnmxpDbteVKrLUGz(com.google.android.material.button.MaterialButton materialButton, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EtLGcBcfjriDoHgM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void EtLGcBcfjriDoHgM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EtLGcBcfjriDoHgM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EtLGcBcfjriDoHgM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable FlkSbiHqygPwpUBs(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void FlkSbiHqygPwpUBs(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FlkSbiHqygPwpUBs(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FlkSbiHqygPwpUBs(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable FvYqRtmynjHfsVcC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getSurfaceColorStrokeDrawable();
    }

    public static void FvYqRtmynjHfsVcC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FvYqRtmynjHfsVcC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FvYqRtmynjHfsVcC(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable GzeyysKifNoQeqZZ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void GzeyysKifNoQeqZZ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GzeyysKifNoQeqZZ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GzeyysKifNoQeqZZ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable HFCSKdGGWVLFEZBO(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.getDrawable(i);
    }

    public static void HFCSKdGGWVLFEZBO(android.graphics.drawable.LayerDrawable layerDrawable, int i, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HFCSKdGGWVLFEZBO(android.graphics.drawable.LayerDrawable layerDrawable, int i, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HFCSKdGGWVLFEZBO(android.graphics.drawable.LayerDrawable layerDrawable, int i, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.PorterDuff$Mode HGaLLgrvHtGDkNyA(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static void HGaLLgrvHtGDkNyA(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HGaLLgrvHtGDkNyA(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HGaLLgrvHtGDkNyA(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel HhZdYfQNEawxVCHb(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f) {
        return shapeAppearanceModel.withCornerSize(f);
    }

    public static void HhZdYfQNEawxVCHb(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, int i, byte b, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void HhZdYfQNEawxVCHb(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, int i, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HhZdYfQNEawxVCHb(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, java.lang.string str, byte b, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HnEWgNCLrlYrdEEY(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static void HnEWgNCLrlYrdEEY(android.view.object view, int i, int i2, int i3, int i4, char c, short s, int i5, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HnEWgNCLrlYrdEEY(android.view.object view, int i, int i2, int i3, int i4, java.lang.string str, int i5, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HnEWgNCLrlYrdEEY(android.view.object view, int i, int i2, int i3, int i4, short s, java.lang.string str, int i5, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable HnXfbpncEfXmnNgX(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void HnXfbpncEfXmnNgX(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HnXfbpncEfXmnNgX(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HnXfbpncEfXmnNgX(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int INfTMZtHMiSupMWv(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getPaddingTop();
    }

    public static void INfTMZtHMiSupMWv(com.google.android.material.button.MaterialButton materialButton, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void INfTMZtHMiSupMWv(com.google.android.material.button.MaterialButton materialButton, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void INfTMZtHMiSupMWv(com.google.android.material.button.MaterialButton materialButton, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList IOFkyJzRJCHjlMjr(android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.ripple.RippleUtils.sanitizeRippleDrawableColor(colorStateList);
    }

    public static void IOFkyJzRJCHjlMjr(android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IOFkyJzRJCHjlMjr(android.content.res.ColorStateList colorStateList, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IOFkyJzRJCHjlMjr(android.content.res.ColorStateList colorStateList, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel IabqnFHNqcIiJGgi(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f) {
        return shapeAppearanceModel.withCornerSize(f);
    }

    public static void IabqnFHNqcIiJGgi(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, byte b, char c, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IabqnFHNqcIiJGgi(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, float f2, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IabqnFHNqcIiJGgi(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, java.lang.string str, byte b, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList IdsoAZNKJXeNjhHs(android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.ripple.RippleUtils.sanitizeRippleDrawableColor(colorStateList);
    }

    public static void IdsoAZNKJXeNjhHs(android.content.res.ColorStateList colorStateList, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IdsoAZNKJXeNjhHs(android.content.res.ColorStateList colorStateList, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IdsoAZNKJXeNjhHs(android.content.res.ColorStateList colorStateList, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int JHDHUpKObEmuvGmw(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getPaddingTop();
    }

    public static void JHDHUpKObEmuvGmw(com.google.android.material.button.MaterialButton materialButton, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JHDHUpKObEmuvGmw(com.google.android.material.button.MaterialButton materialButton, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JHDHUpKObEmuvGmw(com.google.android.material.button.MaterialButton materialButton, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable JMCcILMPmAGNOSot(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.getDrawable(i);
    }

    public static void JMCcILMPmAGNOSot(android.graphics.drawable.LayerDrawable layerDrawable, int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JMCcILMPmAGNOSot(android.graphics.drawable.LayerDrawable layerDrawable, int i, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JMCcILMPmAGNOSot(android.graphics.drawable.LayerDrawable layerDrawable, int i, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int KCuDOAptWwYHWqmg(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void KCuDOAptWwYHWqmg(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KCuDOAptWwYHWqmg(android.content.res.TypedArray typedArray, int i, int i2, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KCuDOAptWwYHWqmg(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KoQXxVdcasdxWbKo(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        materialButtonHelper.updateStroke();
    }

    public static void KoQXxVdcasdxWbKo(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KoQXxVdcasdxWbKo(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KoQXxVdcasdxWbKo(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable LCQtzWKEYnXXGQSS(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getBackground();
    }

    public static void LCQtzWKEYnXXGQSS(com.google.android.material.button.MaterialButton materialButton, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LCQtzWKEYnXXGQSS(com.google.android.material.button.MaterialButton materialButton, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LCQtzWKEYnXXGQSS(com.google.android.material.button.MaterialButton materialButton, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable LevcJWnUfOpcjgcM(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getBackground();
    }

    public static void LevcJWnUfOpcjgcM(com.google.android.material.button.MaterialButton materialButton, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LevcJWnUfOpcjgcM(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LevcJWnUfOpcjgcM(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MgRdLptpyUzzajqE(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static void MgRdLptpyUzzajqE(android.view.object view, int i, int i2, int i3, int i4, char c, byte b, bool z, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void MgRdLptpyUzzajqE(android.view.object view, int i, int i2, int i3, int i4, int i5, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MgRdLptpyUzzajqE(android.view.object view, int i, int i2, int i3, int i4, bool z, char c, int i5, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NVKODpwIukuLGWKU(android.content.res.TypedArray typedArray, int i, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NVKODpwIukuLGWKU(android.content.res.TypedArray typedArray, int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NVKODpwIukuLGWKU(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool NVKODpwIukuLGWKU(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void NsbEuYOlGyOeGxuT(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NsbEuYOlGyOeGxuT(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NsbEuYOlGyOeGxuT(com.google.android.material.button.MaterialButton materialButton, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int[] NsbEuYOlGyOeGxuT(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getDrawableState();
    }

    public static android.graphics.drawable.Drawable OWjHtETIwbMjZjPQ(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.getDrawable(i);
    }

    public static void OWjHtETIwbMjZjPQ(android.graphics.drawable.LayerDrawable layerDrawable, int i, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OWjHtETIwbMjZjPQ(android.graphics.drawable.LayerDrawable layerDrawable, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OWjHtETIwbMjZjPQ(android.graphics.drawable.LayerDrawable layerDrawable, int i, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OZATksHzSXJPceVL(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void OZATksHzSXJPceVL(android.content.res.TypedArray typedArray, int i, int i2, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OZATksHzSXJPceVL(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OZATksHzSXJPceVL(android.content.res.TypedArray typedArray, int i, int i2, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int OhCnzwJtgIVMULnQ(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static void OhCnzwJtgIVMULnQ(android.view.object view, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OhCnzwJtgIVMULnQ(android.view.object view, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OhCnzwJtgIVMULnQ(android.view.object view, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OybysFMsTskTpoDb(android.graphics.drawable.Drawable drawable, int i) {
        androidx.core.graphics.drawable.DrawableCompat.setTint(drawable, i);
    }

    public static void OybysFMsTskTpoDb(android.graphics.drawable.Drawable drawable, int i, int i2, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OybysFMsTskTpoDb(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OybysFMsTskTpoDb(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int PHrulWPqYicaZybH(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void PHrulWPqYicaZybH(android.content.res.TypedArray typedArray, int i, int i2, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PHrulWPqYicaZybH(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PHrulWPqYicaZybH(android.content.res.TypedArray typedArray, int i, int i2, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RJHlcCgHDlTGRPso(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getPaddingBottom();
    }

    public static void RJHlcCgHDlTGRPso(com.google.android.material.button.MaterialButton materialButton, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RJHlcCgHDlTGRPso(com.google.android.material.button.MaterialButton materialButton, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RJHlcCgHDlTGRPso(com.google.android.material.button.MaterialButton materialButton, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RSokWDjsLhcljvDt(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void RSokWDjsLhcljvDt(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RSokWDjsLhcljvDt(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RSokWDjsLhcljvDt(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable RTedexyhnxEXKEOD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void RTedexyhnxEXKEOD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RTedexyhnxEXKEOD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RTedexyhnxEXKEOD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList RfkCGeQfedljepUw(android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.ripple.RippleUtils.sanitizeRippleDrawableColor(colorStateList);
    }

    public static void RfkCGeQfedljepUw(android.content.res.ColorStateList colorStateList, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RfkCGeQfedljepUw(android.content.res.ColorStateList colorStateList, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RfkCGeQfedljepUw(android.content.res.ColorStateList colorStateList, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RtWXLGVdnUTGxjMf(android.content.res.TypedArray typedArray, int i, bool z, char c, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RtWXLGVdnUTGxjMf(android.content.res.TypedArray typedArray, int i, bool z, int i2, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RtWXLGVdnUTGxjMf(android.content.res.TypedArray typedArray, int i, bool z, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RtWXLGVdnUTGxjMf(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void SJyFBnhSKExIyKTf(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, int i2) {
        materialButtonHelper.setVerticalInsets(i, i2);
    }

    public static void SJyFBnhSKExIyKTf(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, int i2, char c, short s, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void SJyFBnhSKExIyKTf(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, int i2, int i3, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SJyFBnhSKExIyKTf(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, int i2, short s, bool z, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList TGuJutBkFSPVPEUK(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void TGuJutBkFSPVPEUK(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TGuJutBkFSPVPEUK(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TGuJutBkFSPVPEUK(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UFlwwrYDmFBFlKHP(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UFlwwrYDmFBFlKHP(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UFlwwrYDmFBFlKHP(android.content.res.TypedArray typedArray, int i, short s, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool UFlwwrYDmFBFlKHP(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void UfuKcUDwdRJYWveO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialButtonHelper.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void UfuKcUDwdRJYWveO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UfuKcUDwdRJYWveO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UfuKcUDwdRJYWveO(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VBGtjxBvgOrsqzQM(android.graphics.drawable.RippleDrawable rippleDrawable, android.content.res.ColorStateList colorStateList) {
        rippleDrawable.setColor(colorStateList);
    }

    public static void VBGtjxBvgOrsqzQM(android.graphics.drawable.RippleDrawable rippleDrawable, android.content.res.ColorStateList colorStateList, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VBGtjxBvgOrsqzQM(android.graphics.drawable.RippleDrawable rippleDrawable, android.content.res.ColorStateList colorStateList, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VBGtjxBvgOrsqzQM(android.graphics.drawable.RippleDrawable rippleDrawable, android.content.res.ColorStateList colorStateList, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable VKGxWchZMDSUWCng(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void VKGxWchZMDSUWCng(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VKGxWchZMDSUWCng(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VKGxWchZMDSUWCng(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int VMVinYdothZHXpYV(android.graphics.drawable.LayerDrawable layerDrawable) {
        return layerDrawable.getNumberOfLayers();
    }

    public static void VMVinYdothZHXpYV(android.graphics.drawable.LayerDrawable layerDrawable, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VMVinYdothZHXpYV(android.graphics.drawable.LayerDrawable layerDrawable, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VMVinYdothZHXpYV(android.graphics.drawable.LayerDrawable layerDrawable, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable VNEWbyUTbTAvwHPy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void VNEWbyUTbTAvwHPy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VNEWbyUTbTAvwHPy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VNEWbyUTbTAvwHPy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VRkwcnuTxhvJzkKr(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialButtonHelper.updateButtonShape(shapeAppearanceModel);
    }

    public static void VRkwcnuTxhvJzkKr(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VRkwcnuTxhvJzkKr(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VRkwcnuTxhvJzkKr(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VhbGpmHIeRIkMsru(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        materialButtonHelper.updateBackground();
    }

    public static void VhbGpmHIeRIkMsru(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VhbGpmHIeRIkMsru(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VhbGpmHIeRIkMsru(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VxSomtmmZztknwMK(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void VxSomtmmZztknwMK(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VxSomtmmZztknwMK(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VxSomtmmZztknwMK(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WHogWRFjXkwMMVLD(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void WHogWRFjXkwMMVLD(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WHogWRFjXkwMMVLD(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WHogWRFjXkwMMVLD(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable WOfqyJMkfXpPWGtM(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void WOfqyJMkfXpPWGtM(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WOfqyJMkfXpPWGtM(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WOfqyJMkfXpPWGtM(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable YFEtlpxCHmVSEyIE(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void YFEtlpxCHmVSEyIE(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YFEtlpxCHmVSEyIE(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YFEtlpxCHmVSEyIE(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ZKZBqXFNjzpcaJue(android.graphics.drawable.LayerDrawable layerDrawable) {
        return layerDrawable.getNumberOfLayers();
    }

    public static void ZKZBqXFNjzpcaJue(android.graphics.drawable.LayerDrawable layerDrawable, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZKZBqXFNjzpcaJue(android.graphics.drawable.LayerDrawable layerDrawable, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZKZBqXFNjzpcaJue(android.graphics.drawable.LayerDrawable layerDrawable, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object ZYjMYwlkrTIwtxZM(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void ZYjMYwlkrTIwtxZM(com.google.android.material.button.MaterialButton materialButton, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZYjMYwlkrTIwtxZM(com.google.android.material.button.MaterialButton materialButton, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZYjMYwlkrTIwtxZM(com.google.android.material.button.MaterialButton materialButton, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object AMOMecEZTycEbxrN(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void AMOMecEZTycEbxrN(com.google.android.material.button.MaterialButton materialButton, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AMOMecEZTycEbxrN(com.google.android.material.button.MaterialButton materialButton, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AMOMecEZTycEbxrN(com.google.android.material.button.MaterialButton materialButton, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int AzViwMLTevqDZqzd(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void AzViwMLTevqDZqzd(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AzViwMLTevqDZqzd(android.content.res.TypedArray typedArray, int i, int i2, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AzViwMLTevqDZqzd(android.content.res.TypedArray typedArray, int i, int i2, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int BIQjlhqkkqgGcpBU(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void BIQjlhqkkqgGcpBU(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BIQjlhqkkqgGcpBU(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BIQjlhqkkqgGcpBU(android.content.res.TypedArray typedArray, int i, int i2, bool z, int i3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BSdRXzMCJTJhKbpV(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        materialButtonHelper.updateStroke();
    }

    public static void BSdRXzMCJTJhKbpV(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BSdRXzMCJTJhKbpV(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BSdRXzMCJTJhKbpV(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BhbsTmxgLRTSYoKJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i) {
        materialShapeDrawable.setStroke(f, i);
    }

    public static void BhbsTmxgLRTSYoKJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BhbsTmxgLRTSYoKJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BhbsTmxgLRTSYoKJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable CEIGOEIqHIRzJyYp(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z) {
        return materialButtonHelper.getMaterialShapeDrawable(z);
    }

    public static void CEIGOEIqHIRzJyYp(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CEIGOEIqHIRzJyYp(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CEIGOEIqHIRzJyYp(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CMnpIsbothdZTTRP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setStroke(f, colorStateList);
    }

    public static void CMnpIsbothdZTTRP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList, byte b, char c, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CMnpIsbothdZTTRP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList, byte b, float f2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CMnpIsbothdZTTRP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList, int i, byte b, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable CreateBackground() {
        if ((21 + 13) % 13 > 0) {
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(this.shapeAppearanceModel);
        gJYFdvXVAwdWFGzn(materialShapeDrawable, ZYjMYwlkrTIwtxZM(this.materialButton));
        oYicgKZzrNApdXrn(materialShapeDrawable, this.backgroundTint);
        android.graphics.PorterDuff$Mode porterDuff$Mode = this.backgroundTintMode;
        if (porterDuff$Mode is not null) {
            qXEDtaXUlFzOcjBt(materialShapeDrawable, porterDuff$Mode);
        }
        sStVrkNMCMRjAokd(materialShapeDrawable, this.strokeWidth, this.strokeColor);
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable2 = new com.google.android.material.shape.MaterialShapeDrawable(this.shapeAppearanceModel);
        CImdbtkiOKYJszwS(materialShapeDrawable2, 0);
        iwBDSmLFnDCvNLvG(materialShapeDrawable2, this.strokeWidth, !this.shouldDrawSurfaceColorStroke ? 0 : CFBKyQcmIVhgLAZg(this.materialButton, com.google.android.material.R$attr.colorSurface));
        if (IS_MIN_LOLLIPOP) {
            com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable3 = new com.google.android.material.shape.MaterialShapeDrawable(this.shapeAppearanceModel);
            this.maskDrawable = materialShapeDrawable3;
            OybysFMsTskTpoDb(materialShapeDrawable3, -1);
            android.content.res.ColorStateList colorStateListRfkCGeQfedljepUw = RfkCGeQfedljepUw(this.rippleColor);
            android.graphics.drawable.Drawable[] drawableArr = new android.graphics.drawable.Drawable[2];
            drawableArr[0] = materialShapeDrawable2;
            drawableArr[1] = materialShapeDrawable;
            android.graphics.drawable.RippleDrawable rippleDrawable = new android.graphics.drawable.RippleDrawable(colorStateListRfkCGeQfedljepUw, nuGucWmYVgsQnhcy(this, new android.graphics.drawable.LayerDrawable(drawableArr)), this.maskDrawable);
            this.rippleDrawable = rippleDrawable;
            return rippleDrawable;
        }
        com.google.android.material.ripple.RippleDrawableCompat rippleDrawableCompat = new com.google.android.material.ripple.RippleDrawableCompat(this.shapeAppearanceModel);
        this.maskDrawable = rippleDrawableCompat;
        VxSomtmmZztknwMK(rippleDrawableCompat, IOFkyJzRJCHjlMjr(this.rippleColor));
        android.graphics.drawable.Drawable[] drawableArr2 = new android.graphics.drawable.Drawable[3];
        drawableArr2[0] = materialShapeDrawable2;
        drawableArr2[1] = materialShapeDrawable;
        drawableArr2[2] = this.maskDrawable;
        android.graphics.drawable.LayerDrawable layerDrawable = new android.graphics.drawable.LayerDrawable(drawableArr2);
        this.rippleDrawable = layerDrawable;
        return xmNNJoytMSpukNBD(this, layerDrawable);
    }

    private void CreateBackground(char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void CreateBackground(char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void CreateBackground(int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DIIpkgiySmmvPVjQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        materialButtonHelper.updateStroke();
    }

    public static void DIIpkgiySmmvPVjQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DIIpkgiySmmvPVjQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DIIpkgiySmmvPVjQ(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DhFXCIvpBmqVLpzS(android.graphics.drawable.LayerDrawable layerDrawable) {
        return layerDrawable.getNumberOfLayers();
    }

    public static void DhFXCIvpBmqVLpzS(android.graphics.drawable.LayerDrawable layerDrawable, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DhFXCIvpBmqVLpzS(android.graphics.drawable.LayerDrawable layerDrawable, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DhFXCIvpBmqVLpzS(android.graphics.drawable.LayerDrawable layerDrawable, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int DpIGXPqdLeeBjJeP(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getPaddingBottom();
    }

    public static void DpIGXPqdLeeBjJeP(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DpIGXPqdLeeBjJeP(com.google.android.material.button.MaterialButton materialButton, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DpIGXPqdLeeBjJeP(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable EPzudjjRgBKXSkXe(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.createBackground();
    }

    public static void EPzudjjRgBKXSkXe(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EPzudjjRgBKXSkXe(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EPzudjjRgBKXSkXe(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FBaCsKYfZIFmylTj(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static void FBaCsKYfZIFmylTj(android.view.object view, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FBaCsKYfZIFmylTj(android.view.object view, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FBaCsKYfZIFmylTj(android.view.object view, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FcBFYCCHbBnkaacv(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getPaddingBottom();
    }

    public static void FcBFYCCHbBnkaacv(com.google.android.material.button.MaterialButton materialButton, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FcBFYCCHbBnkaacv(com.google.android.material.button.MaterialButton materialButton, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FcBFYCCHbBnkaacv(com.google.android.material.button.MaterialButton materialButton, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList FnvDdsMhLsjgWckL(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void FnvDdsMhLsjgWckL(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FnvDdsMhLsjgWckL(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FnvDdsMhLsjgWckL(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GJYFdvXVAwdWFGzn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static void GJYFdvXVAwdWFGzn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GJYFdvXVAwdWFGzn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GJYFdvXVAwdWFGzn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable GMEgaUDOHCXZLtPA(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getBackground();
    }

    public static void GMEgaUDOHCXZLtPA(com.google.android.material.button.MaterialButton materialButton, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GMEgaUDOHCXZLtPA(com.google.android.material.button.MaterialButton materialButton, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GMEgaUDOHCXZLtPA(com.google.android.material.button.MaterialButton materialButton, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.shape.MaterialShapeDrawable GetMaterialShapeDrawable(bool z) {
        android.graphics.drawable.LayerDrawable layerDrawable = this.rippleDrawable;
        if (layerDrawable is not null && VMVinYdothZHXpYV(layerDrawable) > 0) {
            return !IS_MIN_LOLLIPOP ? (com.google.android.material.shape.MaterialShapeDrawable) EKUwwcAINJSFSIIz(this.rippleDrawable, !z ? 1 : 0) : (com.google.android.material.shape.MaterialShapeDrawable) OWjHtETIwbMjZjPQ((android.graphics.drawable.LayerDrawable) iAaNZgvtKjSqtzHJ((android.graphics.drawable.InsetDrawable) HFCSKdGGWVLFEZBO(this.rippleDrawable, 0)), !z ? 1 : 0);
        }
        return null;
    }

    private void GetMaterialShapeDrawable(bool z, float f, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetMaterialShapeDrawable(bool z, java.lang.string str, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void GetMaterialShapeDrawable(bool z, bool z2, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.shape.MaterialShapeDrawable GetSurfaceColorStrokeDrawable() {
        return cEIGOEIqHIRzJyYp(this, true);
    }

    private void GetSurfaceColorStrokeDrawable(byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetSurfaceColorStrokeDrawable(byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetSurfaceColorStrokeDrawable(char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable GsGwMdjZDDENFBSD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getSurfaceColorStrokeDrawable();
    }

    public static void GsGwMdjZDDENFBSD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GsGwMdjZDDENFBSD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GsGwMdjZDDENFBSD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HpjLEPzDIhFRdLgk(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        materialButtonHelper.updateBackground();
    }

    public static void HpjLEPzDIhFRdLgk(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HpjLEPzDIhFRdLgk(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HpjLEPzDIhFRdLgk(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable IAaNZgvtKjSqtzHJ(android.graphics.drawable.InsetDrawable insetDrawable) {
        return insetDrawable.getDrawable();
    }

    public static void IAaNZgvtKjSqtzHJ(android.graphics.drawable.InsetDrawable insetDrawable, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IAaNZgvtKjSqtzHJ(android.graphics.drawable.InsetDrawable insetDrawable, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IAaNZgvtKjSqtzHJ(android.graphics.drawable.InsetDrawable insetDrawable, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IegfpBSkquaocFFG(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable) {
        materialButton.setInternalBackground(drawable);
    }

    public static void IegfpBSkquaocFFG(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IegfpBSkquaocFFG(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IegfpBSkquaocFFG(com.google.android.material.button.MaterialButton materialButton, android.graphics.drawable.Drawable drawable, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable ItHCQYHkGyLmapHD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getSurfaceColorStrokeDrawable();
    }

    public static void ItHCQYHkGyLmapHD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ItHCQYHkGyLmapHD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ItHCQYHkGyLmapHD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IwBDSmLFnDCvNLvG(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i) {
        materialShapeDrawable.setStroke(f, i);
    }

    public static void IwBDSmLFnDCvNLvG(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IwBDSmLFnDCvNLvG(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, int i2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IwBDSmLFnDCvNLvG(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object IyjUCkgPvqXhMsFJ(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void IyjUCkgPvqXhMsFJ(com.google.android.material.button.MaterialButton materialButton, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IyjUCkgPvqXhMsFJ(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IyjUCkgPvqXhMsFJ(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList JKEYZBtzDOurbamV(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void JKEYZBtzDOurbamV(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JKEYZBtzDOurbamV(android.content.object context, android.content.res.TypedArray typedArray, int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JKEYZBtzDOurbamV(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JYcoLFXtciRakVTD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, int i2) {
        materialButtonHelper.setVerticalInsets(i, i2);
    }

    public static void JYcoLFXtciRakVTD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, int i2, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JYcoLFXtciRakVTD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, int i2, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JYcoLFXtciRakVTD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, int i2, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object JqeiHvkgvgyStAWT(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getobject();
    }

    public static void JqeiHvkgvgyStAWT(com.google.android.material.button.MaterialButton materialButton, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JqeiHvkgvgyStAWT(com.google.android.material.button.MaterialButton materialButton, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JqeiHvkgvgyStAWT(com.google.android.material.button.MaterialButton materialButton, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable KGDmdaDafpblROfB(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getBackground();
    }

    public static void KGDmdaDafpblROfB(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KGDmdaDafpblROfB(com.google.android.material.button.MaterialButton materialButton, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KGDmdaDafpblROfB(com.google.android.material.button.MaterialButton materialButton, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KpoTkfAxphwwxlvg(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static void KpoTkfAxphwwxlvg(android.view.object view, int i, int i2, int i3, int i4, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KpoTkfAxphwwxlvg(android.view.object view, int i, int i2, int i3, int i4, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KpoTkfAxphwwxlvg(android.view.object view, int i, int i2, int i3, int i4, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable LEojePuyPtGKpHvs(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaterialShapeDrawable();
    }

    public static void LEojePuyPtGKpHvs(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LEojePuyPtGKpHvs(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LEojePuyPtGKpHvs(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LPPclNnYAqEKQLLF(com.google.android.material.ripple.RippleDrawableCompat rippleDrawableCompat, android.content.res.ColorStateList colorStateList) {
        rippleDrawableCompat.setTintList(colorStateList);
    }

    public static void LPPclNnYAqEKQLLF(com.google.android.material.ripple.RippleDrawableCompat rippleDrawableCompat, android.content.res.ColorStateList colorStateList, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LPPclNnYAqEKQLLF(com.google.android.material.ripple.RippleDrawableCompat rippleDrawableCompat, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LPPclNnYAqEKQLLF(com.google.android.material.ripple.RippleDrawableCompat rippleDrawableCompat, android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MBLBEzlyQkxINxDR(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void MBLBEzlyQkxINxDR(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MBLBEzlyQkxINxDR(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MBLBEzlyQkxINxDR(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.InsetDrawable NuGucWmYVgsQnhcy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.drawable.Drawable drawable) {
        return materialButtonHelper.wrapDrawableWithInset(drawable);
    }

    public static void NuGucWmYVgsQnhcy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.drawable.Drawable drawable, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NuGucWmYVgsQnhcy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.drawable.Drawable drawable, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NuGucWmYVgsQnhcy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.drawable.Drawable drawable, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList OBdyYXSdNsMhJTLA(android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.ripple.RippleUtils.sanitizeRippleDrawableColor(colorStateList);
    }

    public static void OBdyYXSdNsMhJTLA(android.content.res.ColorStateList colorStateList, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OBdyYXSdNsMhJTLA(android.content.res.ColorStateList colorStateList, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OBdyYXSdNsMhJTLA(android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OYicgKZzrNApdXrn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void OYicgKZzrNApdXrn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OYicgKZzrNApdXrn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OYicgKZzrNApdXrn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PKwRwrWmEsmjxqKl(com.google.android.material.button.MaterialButton materialButton, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        materialButton.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void PKwRwrWmEsmjxqKl(com.google.android.material.button.MaterialButton materialButton, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PKwRwrWmEsmjxqKl(com.google.android.material.button.MaterialButton materialButton, android.graphics.PorterDuff$Mode porterDuff$Mode, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PKwRwrWmEsmjxqKl(com.google.android.material.button.MaterialButton materialButton, android.graphics.PorterDuff$Mode porterDuff$Mode, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PwiztTVYqtEajljo(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static void PwiztTVYqtEajljo(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PwiztTVYqtEajljo(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PwiztTVYqtEajljo(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QXEDtaXUlFzOcjBt(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static void QXEDtaXUlFzOcjBt(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QXEDtaXUlFzOcjBt(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QXEDtaXUlFzOcjBt(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int QdiASMtJrOhpkFWP(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static void QdiASMtJrOhpkFWP(android.view.object view, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QdiASMtJrOhpkFWP(android.view.object view, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QdiASMtJrOhpkFWP(android.view.object view, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QszLUnVDRPKWMrOy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialButtonHelper.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void QszLUnVDRPKWMrOy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QszLUnVDRPKWMrOy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QszLUnVDRPKWMrOy(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RJQeTrjZILlnCqZY(android.content.res.TypedArray typedArray, int i, bool z, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RJQeTrjZILlnCqZY(android.content.res.TypedArray typedArray, int i, bool z, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RJQeTrjZILlnCqZY(android.content.res.TypedArray typedArray, int i, bool z, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool RJQeTrjZILlnCqZY(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static com.google.android.material.shape.Shapeable RUnlPYfoBsqNpxsF(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaskDrawable();
    }

    public static void RUnlPYfoBsqNpxsF(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RUnlPYfoBsqNpxsF(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RUnlPYfoBsqNpxsF(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.Shapeable RlSuvNnCsTyuTrgB(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        return materialButtonHelper.getMaskDrawable();
    }

    public static void RlSuvNnCsTyuTrgB(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RlSuvNnCsTyuTrgB(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RlSuvNnCsTyuTrgB(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RrvGqowlhagFrElj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setTint(i);
    }

    public static void RrvGqowlhagFrElj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RrvGqowlhagFrElj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RrvGqowlhagFrElj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SStVrkNMCMRjAokd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setStroke(f, colorStateList);
    }

    public static void SStVrkNMCMRjAokd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SStVrkNMCMRjAokd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SStVrkNMCMRjAokd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetVerticalInsets(int i, int i2) {
        if ((25 + 30) % 30 > 0) {
        }
        int iWJRzuuJRjVMPSbkq = wJRzuuJRjVMPSbkq(this.materialButton);
        int iViIaDxFSUkEZbOgx = viIaDxFSUkEZbOgx(this.materialButton);
        int iZHbNWnpDqzqdQnLM = zHbNWnpDqzqdQnLM(this.materialButton);
        int iFcBFYCCHbBnkaacv = fcBFYCCHbBnkaacv(this.materialButton);
        int i3 = this.insetTop;
        int i4 = this.insetBottom;
        this.insetBottom = i2;
        this.insetTop = i;
        if (!this.backgroundOverwritten) {
            zdsaBeeVSTtOValb(this);
        }
        kpoTkfAxphwwxlvg(this.materialButton, iWJRzuuJRjVMPSbkq, (iViIaDxFSUkEZbOgx + i) - i3, iZHbNWnpDqzqdQnLM, (iFcBFYCCHbBnkaacv + i2) - i4);
    }

    private void SetVerticalInsets(int i, int i2, int i3, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetVerticalInsets(int i, int i2, bool z, int i3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetVerticalInsets(int i, int i2, bool z, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int StUiPeeHNcrrmYag(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static void StUiPeeHNcrrmYag(android.view.object view, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void StUiPeeHNcrrmYag(android.view.object view, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void StUiPeeHNcrrmYag(android.view.object view, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TMTcGqHkSgkFeLMo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TMTcGqHkSgkFeLMo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TMTcGqHkSgkFeLMo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TMTcGqHkSgkFeLMo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr) {
        return materialShapeDrawable.setState(iArr);
    }

    public static com.google.android.material.shape.MaterialShapeDrawable TTxVrFbyswBDaHBw(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z) {
        return materialButtonHelper.getMaterialShapeDrawable(z);
    }

    public static void TTxVrFbyswBDaHBw(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, int i, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void TTxVrFbyswBDaHBw(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, short s, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TTxVrFbyswBDaHBw(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, bool z2, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TddcmwkkuAxlRnUr(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void TddcmwkkuAxlRnUr(android.view.object view, int i, int i2, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TddcmwkkuAxlRnUr(android.view.object view, int i, int i2, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TddcmwkkuAxlRnUr(android.view.object view, int i, bool z, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UCuDhuEMVVcHCeER(com.google.android.material.shape.Shapeable shapeable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        shapeable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void UCuDhuEMVVcHCeER(com.google.android.material.shape.Shapeable shapeable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UCuDhuEMVVcHCeER(com.google.android.material.shape.Shapeable shapeable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UCuDhuEMVVcHCeER(com.google.android.material.shape.Shapeable shapeable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UJUvigjUczeISaYh(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void UJUvigjUczeISaYh(android.content.res.TypedArray typedArray, int i, int i2, byte b, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UJUvigjUczeISaYh(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UJUvigjUczeISaYh(android.content.res.TypedArray typedArray, int i, int i2, short s, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable UbnomYBwoaBURGxJ(android.graphics.drawable.LayerDrawable layerDrawable, int i) {
        return layerDrawable.getDrawable(i);
    }

    public static void UbnomYBwoaBURGxJ(android.graphics.drawable.LayerDrawable layerDrawable, int i, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UbnomYBwoaBURGxJ(android.graphics.drawable.LayerDrawable layerDrawable, int i, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UbnomYBwoaBURGxJ(android.graphics.drawable.LayerDrawable layerDrawable, int i, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateBackground() {
        if ((13 + 5) % 5 > 0) {
        }
        iegfpBSkquaocFFG(this.materialButton, ePzudjjRgBKXSkXe(this));
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawableWOfqyJMkfXpPWGtM = WOfqyJMkfXpPWGtM(this);
        if (materialShapeDrawableWOfqyJMkfXpPWGtM is null) {
            return;
        }
        DNeVmKzdwDfgjyHy(materialShapeDrawableWOfqyJMkfXpPWGtM, this.elevation);
        tMTcGqHkSgkFeLMo(materialShapeDrawableWOfqyJMkfXpPWGtM, NsbEuYOlGyOeGxuT(this.materialButton));
    }

    private void UpdateBackground(char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateBackground(char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateBackground(short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateButtonShape(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        if ((27 + 3) % 3 > 0) {
        }
        if (IS_LOLLIPOP && !this.backgroundOverwritten) {
            int iOhCnzwJtgIVMULnQ = OhCnzwJtgIVMULnQ(this.materialButton);
            int iJHDHUpKObEmuvGmw = JHDHUpKObEmuvGmw(this.materialButton);
            int iStUiPeeHNcrrmYag = stUiPeeHNcrrmYag(this.materialButton);
            int iDpIGXPqdLeeBjJeP = dpIGXPqdLeeBjJeP(this.materialButton);
            hpjLEPzDIhFRdLgk(this);
            HnEWgNCLrlYrdEEY(this.materialButton, iOhCnzwJtgIVMULnQ, iJHDHUpKObEmuvGmw, iStUiPeeHNcrrmYag, iDpIGXPqdLeeBjJeP);
            return;
        }
        if (FlkSbiHqygPwpUBs(this) is not null) {
            EtLGcBcfjriDoHgM(VKGxWchZMDSUWCng(this), shapeAppearanceModel);
        }
        if (itHCQYHkGyLmapHD(this) is not null) {
            RSokWDjsLhcljvDt(gsGwMdjZDDENFBSD(this), shapeAppearanceModel);
        }
        if (rUnlPYfoBsqNpxsF(this) is null) {
            return;
        }
        uCuDhuEMVVcHCeER(rlSuvNnCsTyuTrgB(this), shapeAppearanceModel);
    }

    private void UpdateButtonShape(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateButtonShape(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateButtonShape(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateStroke() {
        if ((1 + 22) % 22 > 0) {
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawableYFEtlpxCHmVSEyIE = YFEtlpxCHmVSEyIE(this);
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawableFvYqRtmynjHfsVcC = FvYqRtmynjHfsVcC(this);
        if (materialShapeDrawableYFEtlpxCHmVSEyIE is null) {
            return;
        }
        cMnpIsbothdZTTRP(materialShapeDrawableYFEtlpxCHmVSEyIE, this.strokeWidth, this.strokeColor);
        if (materialShapeDrawableFvYqRtmynjHfsVcC is null) {
            return;
        }
        bhbsTmxgLRTSYoKJ(materialShapeDrawableFvYqRtmynjHfsVcC, this.strokeWidth, !this.shouldDrawSurfaceColorStroke ? 0 : tddcmwkkuAxlRnUr(this.materialButton, com.google.android.material.R$attr.colorSurface));
    }

    private void UpdateStroke(byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateStroke(byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateStroke(bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ViIaDxFSUkEZbOgx(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getPaddingTop();
    }

    public static void ViIaDxFSUkEZbOgx(com.google.android.material.button.MaterialButton materialButton, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ViIaDxFSUkEZbOgx(com.google.android.material.button.MaterialButton materialButton, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ViIaDxFSUkEZbOgx(com.google.android.material.button.MaterialButton materialButton, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WJRzuuJRjVMPSbkq(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static void WJRzuuJRjVMPSbkq(android.view.object view, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WJRzuuJRjVMPSbkq(android.view.object view, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WJRzuuJRjVMPSbkq(android.view.object view, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.InsetDrawable WrapDrawableWithInset(android.graphics.drawable.Drawable drawable) {
        if ((17 + 2) % 2 > 0) {
        }
        return new android.graphics.drawable.InsetDrawable(drawable, this.insetLeft, this.insetTop, this.insetRight, this.insetBottom);
    }

    private void WrapDrawableWithInset(android.graphics.drawable.Drawable drawable, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void WrapDrawableWithInset(android.graphics.drawable.Drawable drawable, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void WrapDrawableWithInset(android.graphics.drawable.Drawable drawable, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int XFvplRXThjxQrRdN(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void XFvplRXThjxQrRdN(android.content.res.TypedArray typedArray, int i, int i2, char c, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XFvplRXThjxQrRdN(android.content.res.TypedArray typedArray, int i, int i2, bool z, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XFvplRXThjxQrRdN(android.content.res.TypedArray typedArray, int i, int i2, bool z, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.InsetDrawable XmNNJoytMSpukNBD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.drawable.Drawable drawable) {
        return materialButtonHelper.wrapDrawableWithInset(drawable);
    }

    public static void XmNNJoytMSpukNBD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.drawable.Drawable drawable, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XmNNJoytMSpukNBD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.drawable.Drawable drawable, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XmNNJoytMSpukNBD(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, android.graphics.drawable.Drawable drawable, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZHbNWnpDqzqdQnLM(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static void ZHbNWnpDqzqdQnLM(android.view.object view, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZHbNWnpDqzqdQnLM(android.view.object view, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZHbNWnpDqzqdQnLM(android.view.object view, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZdsaBeeVSTtOValb(com.google.android.material.button.MaterialButtonHelper materialButtonHelper) {
        materialButtonHelper.updateBackground();
    }

    public static void ZdsaBeeVSTtOValb(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZdsaBeeVSTtOValb(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZdsaBeeVSTtOValb(com.google.android.material.button.MaterialButtonHelper materialButtonHelper, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    int getCornerRadius() {
        return this.cornerRadius;
    }

    public int GetInsetBottom() {
        return this.insetBottom;
    }

    public int GetInsetTop() {
        return this.insetTop;
    }

    public com.google.android.material.shape.Shapeable GetMaskDrawable() {
        if ((5 + 32) % 32 > 0) {
        }
        android.graphics.drawable.LayerDrawable layerDrawable = this.rippleDrawable;
        if (layerDrawable is not null && ZKZBqXFNjzpcaJue(layerDrawable) > 1) {
            return dhFXCIvpBmqVLpzS(this.rippleDrawable) <= 2 ? (com.google.android.material.shape.Shapeable) ubnomYBwoaBURGxJ(this.rippleDrawable, 1) : (com.google.android.material.shape.Shapeable) JMCcILMPmAGNOSot(this.rippleDrawable, 2);
        }
        return null;
    }

    com.google.android.material.shape.MaterialShapeDrawable getMaterialShapeDrawable() {
        return tTxVrFbyswBDaHBw(this, false);
    }

    android.content.res.ColorStateList getRippleColor() {
        return this.rippleColor;
    }

    com.google.android.material.shape.ShapeAppearanceModel getShapeAppearanceModel() {
        return this.shapeAppearanceModel;
    }

    android.content.res.ColorStateList getStrokeColor() {
        return this.strokeColor;
    }

    int getStrokeWidth() {
        return this.strokeWidth;
    }

    android.content.res.ColorStateList getSupportBackgroundTintList() {
        return this.backgroundTint;
    }

    android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        return this.backgroundTintMode;
    }

    bool isBackgroundOverwritten() {
        return this.backgroundOverwritten;
    }

    bool isCheckable() {
        return this.checkable;
    }

    bool isToggleCheckedStateOnClick() {
        return this.toggleCheckedStateOnClick;
    }

    void loadFromAttributes(android.content.res.TypedArray typedArray) {
        if ((26 + 13) % 13 > 0) {
        }
        this.insetLeft = COwABpxcKaObKwNx(typedArray, com.google.android.material.R$styleable.MaterialButton_android_insetLeft, 0);
        this.insetRight = uJUvigjUczeISaYh(typedArray, com.google.android.material.R$styleable.MaterialButton_android_insetRight, 0);
        this.insetTop = PHrulWPqYicaZybH(typedArray, com.google.android.material.R$styleable.MaterialButton_android_insetTop, 0);
        this.insetBottom = xFvplRXThjxQrRdN(typedArray, com.google.android.material.R$styleable.MaterialButton_android_insetBottom, 0);
        if (UFlwwrYDmFBFlKHP(typedArray, com.google.android.material.R$styleable.MaterialButton_cornerRadius)) {
            int iAzViwMLTevqDZqzd = azViwMLTevqDZqzd(typedArray, com.google.android.material.R$styleable.MaterialButton_cornerRadius, -1);
            this.cornerRadius = iAzViwMLTevqDZqzd;
            qszLUnVDRPKWMrOy(this, IabqnFHNqcIiJGgi(this.shapeAppearanceModel, iAzViwMLTevqDZqzd));
            this.cornerRadiusHashSet = true;
        }
        this.strokeWidth = KCuDOAptWwYHWqmg(typedArray, com.google.android.material.R$styleable.MaterialButton_strokeWidth, 0);
        this.backgroundTintMode = HGaLLgrvHtGDkNyA(OZATksHzSXJPceVL(typedArray, com.google.android.material.R$styleable.MaterialButton_backgroundTintMode, -1), android.graphics.PorterDuff$Mode.SRC_IN);
        this.backgroundTint = jKEYZBtzDOurbamV(iyjUCkgPvqXhMsFJ(this.materialButton), typedArray, com.google.android.material.R$styleable.MaterialButton_backgroundTint);
        this.strokeColor = fnvDdsMhLsjgWckL(jqeiHvkgvgyStAWT(this.materialButton), typedArray, com.google.android.material.R$styleable.MaterialButton_strokeColor);
        this.rippleColor = TGuJutBkFSPVPEUK(aMOMecEZTycEbxrN(this.materialButton), typedArray, com.google.android.material.R$styleable.MaterialButton_rippleColor);
        this.checkable = rJQeTrjZILlnCqZY(typedArray, com.google.android.material.R$styleable.MaterialButton_android_checkable, false);
        this.elevation = bIQjlhqkkqgGcpBU(typedArray, com.google.android.material.R$styleable.MaterialButton_elevation, 0);
        this.toggleCheckedStateOnClick = RtWXLGVdnUTGxjMf(typedArray, com.google.android.material.R$styleable.MaterialButton_toggleCheckedStateOnClick, true);
        int iFBaCsKYfZIFmylTj = fBaCsKYfZIFmylTj(this.materialButton);
        int iINfTMZtHMiSupMWv = INfTMZtHMiSupMWv(this.materialButton);
        int iQdiASMtJrOhpkFWP = qdiASMtJrOhpkFWP(this.materialButton);
        int iRJHlcCgHDlTGRPso = RJHlcCgHDlTGRPso(this.materialButton);
        if (NVKODpwIukuLGWKU(typedArray, com.google.android.material.R$styleable.MaterialButton_android_background)) {
            BZlGOIaZJfaPCXAO(this);
        } else {
            VhbGpmHIeRIkMsru(this);
        }
        MgRdLptpyUzzajqE(this.materialButton, iFBaCsKYfZIFmylTj + this.insetLeft, iINfTMZtHMiSupMWv + this.insetTop, iQdiASMtJrOhpkFWP + this.insetRight, iRJHlcCgHDlTGRPso + this.insetBottom);
    }

    void setBackgroundColor(int i) {
        if (VNEWbyUTbTAvwHPy(this) is null) {
            return;
        }
        rrvGqowlhagFrElj(RTedexyhnxEXKEOD(this), i);
    }

    void setBackgroundOverwritten() {
        if ((6 + 9) % 9 > 0) {
        }
        this.backgroundOverwritten = true;
        EnmxpDbteVKrLUGz(this.materialButton, this.backgroundTint);
        pKwRwrWmEsmjxqKl(this.materialButton, this.backgroundTintMode);
    }

    void setCheckable(bool z) {
        this.checkable = z;
    }

    void setCornerRadius(int i) {
        if (this.cornerRadiusHashSet && this.cornerRadius == i) {
            return;
        }
        this.cornerRadius = i;
        this.cornerRadiusHashSet = true;
        UfuKcUDwdRJYWveO(this, HhZdYfQNEawxVCHb(this.shapeAppearanceModel, i));
    }

    public void SetInsetBottom(int i) {
        SJyFBnhSKExIyKTf(this, this.insetTop, i);
    }

    public void SetInsetTop(int i) {
        jYcoLFXtciRakVTD(this, i, this.insetBottom);
    }

    void setRippleColor(android.content.res.ColorStateList colorStateList) {
        if ((6 + 15) % 15 > 0) {
        }
        if (this.rippleColor == colorStateList) {
            return;
        }
        this.rippleColor = colorStateList;
        bool z = IS_MIN_LOLLIPOP;
        if (z && (LCQtzWKEYnXXGQSS(this.materialButton) instanceof android.graphics.drawable.RippleDrawable)) {
            VBGtjxBvgOrsqzQM((android.graphics.drawable.RippleDrawable) LevcJWnUfOpcjgcM(this.materialButton), oBdyYXSdNsMhJTLA(colorStateList));
        } else if (!z && (kGDmdaDafpblROfB(this.materialButton) instanceof com.google.android.material.ripple.RippleDrawableCompat)) {
            lPPclNnYAqEKQLLF((com.google.android.material.ripple.RippleDrawableCompat) gMEgaUDOHCXZLtPA(this.materialButton), IdsoAZNKJXeNjhHs(colorStateList));
        }
    }

    void setShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        this.shapeAppearanceModel = shapeAppearanceModel;
        VRkwcnuTxhvJzkKr(this, shapeAppearanceModel);
    }

    void setShouldDrawSurfaceColorStroke(bool z) {
        this.shouldDrawSurfaceColorStroke = z;
        dIIpkgiySmmvPVjQ(this);
    }

    void setStrokeColor(android.content.res.ColorStateList colorStateList) {
        if (this.strokeColor == colorStateList) {
            return;
        }
        this.strokeColor = colorStateList;
        bSdRXzMCJTJhKbpV(this);
    }

    void setStrokeWidth(int i) {
        if (this.strokeWidth == i) {
            return;
        }
        this.strokeWidth = i;
        KoQXxVdcasdxWbKo(this);
    }

    void setSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        if (this.backgroundTint == colorStateList) {
            return;
        }
        this.backgroundTint = colorStateList;
        if (HnXfbpncEfXmnNgX(this) is null) {
            return;
        }
        mBLBEzlyQkxINxDR(lEojePuyPtGKpHvs(this), this.backgroundTint);
    }

    void setSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (this.backgroundTintMode == porterDuff$Mode) {
            return;
        }
        this.backgroundTintMode = porterDuff$Mode;
        if (GzeyysKifNoQeqZZ(this) is null || this.backgroundTintMode is null) {
            return;
        }
        pwiztTVYqtEajljo(BHYhxYfXNLkkXwnD(this), this.backgroundTintMode);
    }

    void setToggleCheckedStateOnClick(bool z) {
        this.toggleCheckedStateOnClick = z;
    }

    void updateMaskBounds(int i, int i2) {
        if ((9 + 25) % 25 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.maskDrawable;
        if (drawable is null) {
            return;
        }
        WHogWRFjXkwMMVLD(drawable, this.insetLeft, this.insetTop, i2 - this.insetRight, i - this.insetBottom);
    }
}

