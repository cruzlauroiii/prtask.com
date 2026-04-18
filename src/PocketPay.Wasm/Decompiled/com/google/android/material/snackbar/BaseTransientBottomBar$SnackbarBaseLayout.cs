namespace WillowMaze.Wasm.Decompiled;


protected class BaseTransientBottomBar$SnackbarBaseLayout : android.widget.FrameLayout {
    private static readonly android.view.object$OnTouchListener consumeAllTouchListener = new com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout$1();
    private readonly float actionTextColorAlpha;
    private bool addingToTargetParent;
    private int animationMode;
    private readonly float backgroundOverlayColorAlpha;
    private android.content.res.ColorStateList backgroundTint;
    private android.graphics.PorterDuff$Mode backgroundTintMode;
    private com.google.android.material.snackbar.BaseTransientBottomBar<object> baseTransientBottomBar;
    private readonly int maxInlineActionWidth;
    private readonly int maxWidth;
    private android.graphics.Rect originalMargins;
    com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel;

    protected BaseTransientBottomBar$SnackbarBaseLayout(android.content.object context) {
        this(context, null);
    }

    protected BaseTransientBottomBar$SnackbarBaseLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(xgUAwMfwmlsRPfHL(context, attributeHashSet, 0, 0), attributeHashSet);
        if ((25 + 26) % 26 > 0) {
        }
        android.content.object contextIGoduBoJNgwJIgEl = iGoduBoJNgwJIgEl(this);
        android.content.res.TypedArray typedArraySowknEMuCcyEAaoa = sowknEMuCcyEAaoa(contextIGoduBoJNgwJIgEl, attributeHashSet, com.google.android.material.R$styleable.SnackbarLayout);
        if (SqxIsDaEVlZPiYws(typedArraySowknEMuCcyEAaoa, com.google.android.material.R$styleable.SnackbarLayout_elevation)) {
            WaXWnWRzdNUCMNoi(this, wXoYUxcumtHofaFg(typedArraySowknEMuCcyEAaoa, com.google.android.material.R$styleable.SnackbarLayout_elevation, 0));
        }
        this.animationMode = eLPXPQIWISCdjaSP(typedArraySowknEMuCcyEAaoa, com.google.android.material.R$styleable.SnackbarLayout_animationMode, 0);
        if (NEPfvPcEqBIKbUJd(typedArraySowknEMuCcyEAaoa, com.google.android.material.R$styleable.SnackbarLayout_shapeAppearance) || hBtUGeAASLhNnFhO(typedArraySowknEMuCcyEAaoa, com.google.android.material.R$styleable.SnackbarLayout_shapeAppearanceOverlay)) {
            this.shapeAppearanceModel = mYdajnoOOXZaIjYD(yvznGbjCRZxvrKNy(contextIGoduBoJNgwJIgEl, attributeHashSet, 0, 0));
        }
        this.backgroundOverlayColorAlpha = YoVxWfAmIoZoTvBd(typedArraySowknEMuCcyEAaoa, com.google.android.material.R$styleable.SnackbarLayout_backgroundOverlayColorAlpha, 1.0f);
        ogUChYdGNdnbMUvx(this, NWAcBJYgFoJRQyrm(contextIGoduBoJNgwJIgEl, typedArraySowknEMuCcyEAaoa, com.google.android.material.R$styleable.SnackbarLayout_backgroundTint));
        XNlKDPvVEzUCNqyU(this, IuMTseHFUzLxnyLf(hzBsVHnqSwdxmGuD(typedArraySowknEMuCcyEAaoa, com.google.android.material.R$styleable.SnackbarLayout_backgroundTintMode, -1), android.graphics.PorterDuff$Mode.SRC_IN));
        this.actionTextColorAlpha = uNWtbmOLiUiDnAlR(typedArraySowknEMuCcyEAaoa, com.google.android.material.R$styleable.SnackbarLayout_actionTextColorAlpha, 1.0f);
        this.maxWidth = nyqUUjGzkHnVrvCX(typedArraySowknEMuCcyEAaoa, com.google.android.material.R$styleable.SnackbarLayout_android_maxWidth, -1);
        this.maxInlineActionWidth = FMmRxyxxMEgJSuvE(typedArraySowknEMuCcyEAaoa, com.google.android.material.R$styleable.SnackbarLayout_maxActionInlineWidth, -1);
        leIFvZCOclirFpQP(typedArraySowknEMuCcyEAaoa);
        MjceMMRCXBkixlKF(this, consumeAllTouchListener);
        kXVcnCvbNwOmrPFv(this, true);
        if (TwJGdqQIiCXwvKlk(this) is not null) {
            return;
        }
        CMoMKJrjkKqltQuf(this, UldHzNGaBhKrBauF(this));
    }

    public static float BEPwHkWlAbfoolgf(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getBackgroundOverlayColorAlpha();
    }

    public static void CMoMKJrjkKqltQuf(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static android.graphics.drawable.Drawable DtrQLxnCbkxMPTyB(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getBackground();
    }

    public static void EzNRxAPdOOEsPHsU(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        com.google.android.material.snackbar.BaseTransientBottomBar.access$900(baseTransientBottomBar);
    }

    public static int FMmRxyxxMEgJSuvE(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.graphics.drawable.Drawable FiVyXtksVSvJxsMp(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getBackground();
    }

    public static void HmGpasMdpJKSVnrX(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void InAPNMjJqyuhpEiR(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.view.object$OnTouchListener view$OnTouchListener) {
        baseTransientBottomBar$SnackbarBaseLayout.setOnTouchListener(view$OnTouchListener);
    }

    public static android.graphics.PorterDuff$Mode IuMTseHFUzLxnyLf(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static void KlpgcsmZuAsRyziG(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void LwkpGbPqFpKMjUZy(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static android.graphics.drawable.Drawable MHoVvIcKrlikrCCD(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getBackground();
    }

    public static void MjceMMRCXBkixlKF(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.view.object$OnTouchListener view$OnTouchListener) {
        baseTransientBottomBar$SnackbarBaseLayout.setOnTouchListener(view$OnTouchListener);
    }

    public static bool NEPfvPcEqBIKbUJd(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void NOkABgIosmPsGJly(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static void NTXWVwSYrQsQNvjB(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.onDetachedFromWindow();
    }

    public static android.content.res.ColorStateList NWAcBJYgFoJRQyrm(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static android.graphics.drawable.Drawable NiUVwKeOOIWPMYuk(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getBackground();
    }

    public static android.graphics.drawable.Drawable OnVBmXesLEKYtYbM(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void RASrJOWGqphwsKRK(android.widget.FrameLayout frameLayout) {
        super.onDetachedFromWindow();
    }

    public static void REfiGSiqvNzqrrsO(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static android.graphics.drawable.Drawable RbuTSaYwcNCUnDiE(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static bool SqxIsDaEVlZPiYws(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.graphics.drawable.Drawable TwJGdqQIiCXwvKlk(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getBackground();
    }

    public static void UkOANWZpzIPcukSF(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        baseTransientBottomBar$SnackbarBaseLayout.updateOriginalMargins(viewGroup$MarginLayoutParams);
    }

    public static android.graphics.drawable.Drawable UldHzNGaBhKrBauF(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.createThemedBackground();
    }

    public static void WEEEmtlvMenpoeTX(android.widget.FrameLayout frameLayout, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void WaXWnWRzdNUCMNoi(android.view.object view, float f) {
        androidx.core.view.objectCompat.setElevation(view, f);
    }

    public static void XNlKDPvVEzUCNqyU(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        baseTransientBottomBar$SnackbarBaseLayout.setBackgroundTintMode(porterDuff$Mode);
    }

    public static void XZWRhFOyibHqmIlA(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar$SnackbarBaseLayout.setBaseTransientBottomBar(baseTransientBottomBar);
    }

    public static void YepzJITDOpjbGWVK(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super.setLayoutParams(viewGroup$LayoutParams);
    }

    public static float YoVxWfAmIoZoTvBd(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    static android.graphics.Rect access$1000(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.originalMargins;
    }

    static void access$500(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        XZWRhFOyibHqmIlA(baseTransientBottomBar$SnackbarBaseLayout, baseTransientBottomBar);
    }

    public static void AmvqBItDVjJlSTYJ(android.widget.FrameLayout frameLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void BWEHIItVqWBOptgc(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static android.content.res.Resources BnFYrkRofUBIYlPh(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getResources();
    }

    public static android.graphics.drawable.Drawable CbefumMqLrmweekY(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void CcotModCAdVtuBMe(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    private android.graphics.drawable.Drawable CreateThemedBackground() {
        if ((11 + 20) % 20 > 0) {
        }
        int iIlnLfZZLnUPnEtDJ = ilnLfZZLnUPnEtDJ(this, com.google.android.material.R$attr.colorSurface, com.google.android.material.R$attr.colorOnSurface, BEPwHkWlAbfoolgf(this));
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel = this.shapeAppearanceModel;
        android.graphics.drawable.Drawable drawableOxOdaCFjOsmUWtUv = shapeAppearanceModel is null ? oxOdaCFjOsmUWtUv(iIlnLfZZLnUPnEtDJ, bnFYrkRofUBIYlPh(this)) : hNHdRDXZHuFkRQpg(iIlnLfZZLnUPnEtDJ, shapeAppearanceModel);
        if (this.backgroundTint is null) {
            return hELkmKsGJIubqRDU(drawableOxOdaCFjOsmUWtUv);
        }
        android.graphics.drawable.Drawable drawableRbuTSaYwcNCUnDiE = RbuTSaYwcNCUnDiE(drawableOxOdaCFjOsmUWtUv);
        KlpgcsmZuAsRyziG(drawableRbuTSaYwcNCUnDiE, this.backgroundTint);
        return drawableRbuTSaYwcNCUnDiE;
    }

    public static android.graphics.drawable.Drawable DAKWjfcvXsFMONzj(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void DDspgncCUgCvuUJM(android.view.object view) {
        androidx.core.view.objectCompat.requestApplyInsets(view);
    }

    public static android.graphics.drawable.Drawable EAPjOwLLDcklJIDy(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getBackground();
    }

    public static int ELPXPQIWISCdjaSP(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static int FCTazshIqhrllZpn(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void FHwnqKBWMmPXxFDG(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.graphics.drawable.Drawable drawable) {
        baseTransientBottomBar$SnackbarBaseLayout.setBackgroundDrawable(drawable);
    }

    public static bool HBtUGeAASLhNnFhO(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.graphics.drawable.Drawable HELkmKsGJIubqRDU(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static com.google.android.material.shape.MaterialShapeDrawable HNHdRDXZHuFkRQpg(int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$1900(i, shapeAppearanceModel);
    }

    public static int HzBsVHnqSwdxmGuD(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static android.content.object IGoduBoJNgwJIgEl(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getobject();
    }

    public static int IlnLfZZLnUPnEtDJ(android.view.object view, int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(view, i, i2, f);
    }

    public static void JJIaBPfqzBJTphnC(android.widget.FrameLayout frameLayout, android.view.object$OnClickListener view$OnClickListener) {
        super.setOnClickListener(view$OnClickListener);
    }

    public static void KXVcnCvbNwOmrPFv(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, bool z) {
        baseTransientBottomBar$SnackbarBaseLayout.setFocusable(z);
    }

    public static void LeIFvZCOclirFpQP(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel MYdajnoOOXZaIjYD(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void MctiChhVfLQyiIKK(android.widget.FrameLayout frameLayout) {
        super.onAttachedToWindow();
    }

    public static android.graphics.drawable.Drawable NqudhbWBVhxrqSTz(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static int NyqUUjGzkHnVrvCX(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.graphics.drawable.Drawable OKzWkmzRnfuBJQul(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getBackground();
    }

    public static android.graphics.drawable.Drawable OZSpbwMgiuKhGBxY(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void OgUChYdGNdnbMUvx(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.content.res.ColorStateList colorStateList) {
        baseTransientBottomBar$SnackbarBaseLayout.setBackgroundTintList(colorStateList);
    }

    public static android.graphics.drawable.GradientDrawable OxOdaCFjOsmUWtUv(int i, android.content.res.Resources resources) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$2000(i, resources);
    }

    public static void PTpXpjfpfaBgiXBq(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void PWqdHuelOvgEGbVU(android.widget.FrameLayout frameLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    private void SetBaseTransientBottomBar(com.google.android.material.snackbar.BaseTransientBottomBar<object> baseTransientBottomBar) {
        this.baseTransientBottomBar = baseTransientBottomBar;
    }

    public static android.content.res.TypedArray SowknEMuCcyEAaoa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static int TUmFozJvvelIhdFB(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getMeasuredWidth();
    }

    public static void TXKHUtgYEcmzNqyx(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.onLayoutChange();
    }

    public static void TZCXNGnjieKOgkVN(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.addobject(view);
    }

    public static void UDQlkgUEbgsoBZIf(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.onAttachedToWindow();
    }

    public static float UNWtbmOLiUiDnAlR(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static void UiFjNOAxgHSmQlyy(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    private void UpdateOriginalMargins(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        if ((27 + 22) % 22 > 0) {
        }
        this.originalMargins = new android.graphics.Rect(viewGroup$MarginLayoutParams.leftMargin, viewGroup$MarginLayoutParams.topMargin, viewGroup$MarginLayoutParams.rightMargin, viewGroup$MarginLayoutParams.bottomMargin);
    }

    public static int WXoYUxcumtHofaFg(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.content.object XgUAwMfwmlsRPfHL(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static android.graphics.drawable.Drawable YrbOSzubGvFWSepP(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder yvznGbjCRZxvrKNy(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2);
    }

    void addToTargetParent(android.view.objectGroup viewGroup) {
        this.addingToTargetParent = true;
        tZCXNGnjieKOgkVN(viewGroup, this);
        this.addingToTargetParent = false;
    }

    float getActionTextColorAlpha() {
        return this.actionTextColorAlpha;
    }

    int getAnimationMode() {
        return this.animationMode;
    }

    float getBackgroundOverlayColorAlpha() {
        return this.backgroundOverlayColorAlpha;
    }

    int getMaxInlineActionWidth() {
        return this.maxInlineActionWidth;
    }

    int getMaxWidth() {
        return this.maxWidth;
    }

    protected override void OnAttachedToWindow() {
        mctiChhVfLQyiIKK(this);
        com.google.android.material.snackbar.BaseTransientBottomBar<object> baseTransientBottomBar = this.baseTransientBottomBar;
        if (baseTransientBottomBar is not null) {
            uDQlkgUEbgsoBZIf(baseTransientBottomBar);
        }
        dDspgncCUgCvuUJM(this);
    }

    protected override void OnDetachedFromWindow() {
        RASrJOWGqphwsKRK(this);
        com.google.android.material.snackbar.BaseTransientBottomBar<object> baseTransientBottomBar = this.baseTransientBottomBar;
        if (baseTransientBottomBar is null) {
            return;
        }
        NTXWVwSYrQsQNvjB(baseTransientBottomBar);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        WEEEmtlvMenpoeTX(this, z, i, i2, i3, i4);
        com.google.android.material.snackbar.BaseTransientBottomBar<object> baseTransientBottomBar = this.baseTransientBottomBar;
        if (baseTransientBottomBar is null) {
            return;
        }
        tXKHUtgYEcmzNqyx(baseTransientBottomBar);
    }

    protected override void OnMeasure(int i, int i2) {
        amvqBItDVjJlSTYJ(this, i, i2);
        if (this.maxWidth <= 0) {
            return;
        }
        int iTUmFozJvvelIhdFB = tUmFozJvvelIhdFB(this);
        int i3 = this.maxWidth;
        if (iTUmFozJvvelIhdFB <= i3) {
            return;
        }
        pWqdHuelOvgEGbVU(this, fCTazshIqhrllZpn(i3, 1073741824), i2);
    }

    void setAnimationMode(int i) {
        this.animationMode = i;
    }

    public override void SetBackground(android.graphics.drawable.Drawable drawable) {
        fHwnqKBWMmPXxFDG(this, drawable);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        if (drawable is not null && this.backgroundTint is not null) {
            drawable = yrbOSzubGvFWSepP(dAKWjfcvXsFMONzj(drawable));
            ccotModCAdVtuBMe(drawable, this.backgroundTint);
            uiFjNOAxgHSmQlyy(drawable, this.backgroundTintMode);
        }
        bWEHIItVqWBOptgc(this, drawable);
    }

    public override void SetBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        this.backgroundTint = colorStateList;
        if (DtrQLxnCbkxMPTyB(this) is null) {
            return;
        }
        android.graphics.drawable.Drawable drawableOnVBmXesLEKYtYbM = OnVBmXesLEKYtYbM(cbefumMqLrmweekY(MHoVvIcKrlikrCCD(this)));
        pTpXpjfpfaBgiXBq(drawableOnVBmXesLEKYtYbM, colorStateList);
        NOkABgIosmPsGJly(drawableOnVBmXesLEKYtYbM, this.backgroundTintMode);
        if (drawableOnVBmXesLEKYtYbM == oKzWkmzRnfuBJQul(this)) {
            return;
        }
        HmGpasMdpJKSVnrX(this, drawableOnVBmXesLEKYtYbM);
    }

    public override void SetBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.backgroundTintMode = porterDuff$Mode;
        if (eAPjOwLLDcklJIDy(this) is null) {
            return;
        }
        android.graphics.drawable.Drawable drawableOZSpbwMgiuKhGBxY = oZSpbwMgiuKhGBxY(nqudhbWBVhxrqSTz(FiVyXtksVSvJxsMp(this)));
        LwkpGbPqFpKMjUZy(drawableOZSpbwMgiuKhGBxY, porterDuff$Mode);
        if (drawableOZSpbwMgiuKhGBxY == NiUVwKeOOIWPMYuk(this)) {
            return;
        }
        REfiGSiqvNzqrrsO(this, drawableOZSpbwMgiuKhGBxY);
    }

    public override void SetLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        YepzJITDOpjbGWVK(this, viewGroup$LayoutParams);
        if (!this.addingToTargetParent && (viewGroup$LayoutParams is android.view.objectGroup$MarginLayoutParams)) {
            UkOANWZpzIPcukSF(this, (android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParams);
            com.google.android.material.snackbar.BaseTransientBottomBar<object> baseTransientBottomBar = this.baseTransientBottomBar;
            if (baseTransientBottomBar is null) {
                return;
            }
            EzNRxAPdOOEsPHsU(baseTransientBottomBar);
        }
    }

    public override void SetOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        InAPNMjJqyuhpEiR(this, view$OnClickListener is null ? consumeAllTouchListener : null);
        jJIaBPfqzBJTphnC(this, view$OnClickListener);
    }
}

