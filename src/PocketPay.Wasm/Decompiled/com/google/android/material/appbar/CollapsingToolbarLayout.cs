namespace WillowMaze.Wasm.Decompiled;


public class CollapsingToolbarLayout : android.widget.FrameLayout {
    private static readonly int DEFAULT_SCRIM_ANIMATION_DURATION = 600;
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_Design_CollapsingToolbar;
    public static readonly int TITLE_COLLAPSE_MODE_FADE = 1;
    public static readonly int TITLE_COLLAPSE_MODE_SCALE = 0;
    readonly com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper;
    private bool collapsingTitleEnabled;
    private android.graphics.drawable.Drawable contentScrim;
    int currentOffset;
    private bool drawCollapsingTitle;
    private android.view.object dummyobject;
    readonly com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider;
    private int expandedMarginBottom;
    private int expandedMarginEnd;
    private int expandedMarginStart;
    private int expandedMarginTop;
    private int extraMultilineHeight;
    private bool extraMultilineHeightEnabled;
    private bool forceApplySystemWindowInsetTop;
    androidx.core.view.WindowInsetsCompat lastInsets;
    private com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener onOffsetChangedListener;
    private bool refreshToolbar;
    private int scrimAlpha;
    private long scrimAnimationDuration;
    private readonly android.animation.TimeInterpolator scrimAnimationFadeInInterpolator;
    private readonly android.animation.TimeInterpolator scrimAnimationFadeOutInterpolator;
    private android.animation.ValueAnimator scrimAnimator;
    private int scrimVisibleHeightTrigger;
    private bool scrimsAreShown;
    android.graphics.drawable.Drawable statusBarScrim;
    private int titleCollapseMode;
    private readonly android.graphics.Rect tmpRect;
    private android.view.objectGroup toolbar;
    private android.view.object toolbarDirectChild;
    private int toolbarId;
    private int topInsetApplied;

    public CollapsingToolbarLayout(android.content.object context) {
        this(context, null);
    }

    public CollapsingToolbarLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.collapsingToolbarLayoutStyle);
    }

    public CollapsingToolbarLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((13 + 30) % 30 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(TuvMFWgRaYPQeWZy(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.refreshToolbar = true;
        this.tmpRect = new android.graphics.Rect();
        this.scrimVisibleHeightTrigger = -1;
        this.topInsetApplied = 0;
        this.extraMultilineHeight = 0;
        android.content.object contextZlGdzxPelbhFOXDr = zlGdzxPelbhFOXDr(this);
        com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper = new com.google.android.material.internal.CollapsingTextHelper(this);
        this.collapsingTextHelper = collapsingTextHelper;
        TyGePmLdrkCsLWJL(collapsingTextHelper, com.google.android.material.animation.AnimationUtils.DECELERATE_INTERPOLATOR);
        GDEiFflSWzuFiQTl(collapsingTextHelper, false);
        this.elevationOverlayProvider = new com.google.android.material.elevation.ElevationOverlayProvider(contextZlGdzxPelbhFOXDr);
        android.content.res.TypedArray typedArrayLTwsvBLnloSYIBJf = lTwsvBLnloSYIBJf(contextZlGdzxPelbhFOXDr, attributeHashSet, com.google.android.material.R$styleable.CollapsingToolbarLayout, i, i2, new int[0]);
        gMuGXsurjObGAohm(collapsingTextHelper, CfauhBadYEkmMBHK(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleGravity, 8388691));
        jBEkqpXNETZRbTcw(collapsingTextHelper, ngfdVJbuEyUQOkpL(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_collapsedTitleGravity, 8388627));
        int iSCicHcqLfZrBzABq = sCicHcqLfZrBzABq(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleMargin, 0);
        this.expandedMarginBottom = iSCicHcqLfZrBzABq;
        this.expandedMarginEnd = iSCicHcqLfZrBzABq;
        this.expandedMarginTop = iSCicHcqLfZrBzABq;
        this.expandedMarginStart = iSCicHcqLfZrBzABq;
        if (YnXDIjetQZdcrGjE(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleMarginStart)) {
            this.expandedMarginStart = zhWmOjVvELHvKhwo(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleMarginStart, 0);
        }
        if (yqCqRMZNNPcPHjZU(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleMarginEnd)) {
            this.expandedMarginEnd = jzZLjluczfWaXTad(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleMarginEnd, 0);
        }
        if (AKHkLYLXQXGHuVIF(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleMarginTop)) {
            this.expandedMarginTop = yrZjAYACuSvWHMLC(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleMarginTop, 0);
        }
        if (rNvwuxeNJmKtIcbZ(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleMarginBottom)) {
            this.expandedMarginBottom = gIgWAxAHXuRKqeht(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleMarginBottom, 0);
        }
        this.collapsingTitleEnabled = XHvhCQrnropBvgjO(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_titleEnabled, true);
        CsncPHpWIqLOuZBN(this, yBuvpVNgqehnplOw(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_title));
        cyxUmHfvQRXlPVIz(collapsingTextHelper, com.google.android.material.R$style.TextAppearance_Design_CollapsingToolbar_Expanded);
        POiTJBfGPYhIVNBj(collapsingTextHelper, androidx.appcompat.R$style.TextAppearance_AppCompat_Widget_ActionBar_Title);
        if (IGuxwRDHwLumsDLs(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleTextAppearance)) {
            RQPrgvZbRrzyqOpg(collapsingTextHelper, OFNZEQZuiRqGAOwv(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleTextAppearance, 0));
        }
        if (wyYnHzDVnUjhRJMj(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_collapsedTitleTextAppearance)) {
            ZrpxfLaBFpZAZrTH(collapsingTextHelper, VWuMweqgODaFifaH(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_collapsedTitleTextAppearance, 0));
        }
        if (hixKCevQsKuCyfZS(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_titleTextEllipsize)) {
            uwMZpwqovTfgRTYG(this, nIImMsrarRqjMZfI(this, QghxMlbXvraJFsTH(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_titleTextEllipsize, -1)));
        }
        if (ZQXwfirZjIyvJDKr(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleTextColor)) {
            PUAejGVJpDuqWZzJ(collapsingTextHelper, qYICCaUnfZGiHNUY(contextZlGdzxPelbhFOXDr, typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_expandedTitleTextColor));
        }
        if (oOdtFAQeqmiVqyQu(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_collapsedTitleTextColor)) {
            uAuorryRkyGBRXbf(collapsingTextHelper, JaKRplxTypkAAuqA(contextZlGdzxPelbhFOXDr, typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_collapsedTitleTextColor));
        }
        this.scrimVisibleHeightTrigger = AVibsaNAyjIQgfRQ(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_scrimVisibleHeightTrigger, -1);
        if (nkMshJHlbhtpCUpk(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_maxLines)) {
            yEXmptGHqehpwdtv(collapsingTextHelper, NDrzlYbuNjCxVQPn(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_maxLines, 1));
        }
        if (TYBAKjTpPTAoUZaI(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_titlePositionInterpolator)) {
            uFwPTAgxSoeLZRHI(collapsingTextHelper, YmKizAQlTshtKVMy(contextZlGdzxPelbhFOXDr, aTLylpIZOcJwCwPS(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_titlePositionInterpolator, 0)));
        }
        this.scrimAnimationDuration = ozOoaTtPoYAguEWH(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_scrimAnimationDuration, 600);
        this.scrimAnimationFadeInInterpolator = OlRxmQsFGFrxImzW(contextZlGdzxPelbhFOXDr, com.google.android.material.R$attr.motionEasingStandardInterpolator, com.google.android.material.animation.AnimationUtils.FAST_OUT_LINEAR_IN_INTERPOLATOR);
        this.scrimAnimationFadeOutInterpolator = sNqLSyTLWXEUMAwX(contextZlGdzxPelbhFOXDr, com.google.android.material.R$attr.motionEasingStandardInterpolator, com.google.android.material.animation.AnimationUtils.LINEAR_OUT_SLOW_IN_INTERPOLATOR);
        GJxPGhNWduktQwOL(this, FiQrBFcxrunCjwyK(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_contentScrim));
        jQKmorfeNAfhBxFw(this, JMhpWwOJOgKyNeog(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_statusBarScrim));
        ytUvGwUUcYrTHSoC(this, rwKUpyxWyXOflOLP(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_titleCollapseMode, 0));
        this.toolbarId = kPqvKqPHvxyITJhk(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_toolbarId, -1);
        this.forceApplySystemWindowInsetTop = qLmuBHwGlUEMWlhw(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_forceApplySystemWindowInsetTop, false);
        this.extraMultilineHeightEnabled = AyQicOIuaCqRgWXj(typedArrayLTwsvBLnloSYIBJf, com.google.android.material.R$styleable.CollapsingToolbarLayout_extraMultilineHeightEnabled, false);
        dTlQYbYewdOzmPkW(typedArrayLTwsvBLnloSYIBJf);
        geUjTcnXkiQLoToB(this, false);
        XolCNntlxysBdFdA(this, new com.google.android.material.appbar.CollapsingToolbarLayout$1(this));
    }

    public static void AHmGHXeksDVnPiNA(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void AHmGHXeksDVnPiNA(android.graphics.drawable.Drawable drawable, int i, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AHmGHXeksDVnPiNA(android.graphics.drawable.Drawable drawable, int i, float f, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AHmGHXeksDVnPiNA(android.graphics.drawable.Drawable drawable, int i, int i2, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AKHkLYLXQXGHuVIF(android.content.res.TypedArray typedArray, int i, float f, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AKHkLYLXQXGHuVIF(android.content.res.TypedArray typedArray, int i, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AKHkLYLXQXGHuVIF(android.content.res.TypedArray typedArray, int i, short s, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AKHkLYLXQXGHuVIF(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void ARxBTKRoGqXYPeWG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setCollapsedTextGravity(i);
    }

    public static void ARxBTKRoGqXYPeWG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ARxBTKRoGqXYPeWG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ARxBTKRoGqXYPeWG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, java.lang.string str, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int AVibsaNAyjIQgfRQ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void AVibsaNAyjIQgfRQ(android.content.res.TypedArray typedArray, int i, int i2, int i3, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AVibsaNAyjIQgfRQ(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void AVibsaNAyjIQgfRQ(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AXcBxSRRIRnooUxH(android.widget.FrameLayout frameLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void AXcBxSRRIRnooUxH(android.widget.FrameLayout frameLayout, int i, int i2, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AXcBxSRRIRnooUxH(android.widget.FrameLayout frameLayout, int i, int i2, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AXcBxSRRIRnooUxH(android.widget.FrameLayout frameLayout, int i, int i2, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AdJaWxZagXjYUogR(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper) {
        viewOffsetHelper.applyOffsets();
    }

    public static void AdJaWxZagXjYUogR(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AdJaWxZagXjYUogR(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AdJaWxZagXjYUogR(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AlPidWJofrRsSgbE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setExpandedTextSize(f);
    }

    public static void AlPidWJofrRsSgbE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, float f2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AlPidWJofrRsSgbE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, float f2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AlPidWJofrRsSgbE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, float f2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AmUSjeFJHSjYrexN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.requestLayout();
    }

    public static void AmUSjeFJHSjYrexN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AmUSjeFJHSjYrexN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AmUSjeFJHSjYrexN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AyQicOIuaCqRgWXj(android.content.res.TypedArray typedArray, int i, bool z, float f, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AyQicOIuaCqRgWXj(android.content.res.TypedArray typedArray, int i, bool z, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AyQicOIuaCqRgWXj(android.content.res.TypedArray typedArray, int i, bool z, int i2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AyQicOIuaCqRgWXj(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void BEvQPdPFLggCXNGQ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setCollapsedTextSize(f);
    }

    public static void BEvQPdPFLggCXNGQ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BEvQPdPFLggCXNGQ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BEvQPdPFLggCXNGQ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int BJOCouVGiQcBqrBo(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getLineCount();
    }

    public static void BJOCouVGiQcBqrBo(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BJOCouVGiQcBqrBo(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BJOCouVGiQcBqrBo(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BNjYJwWiRKGHlfeS(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BNjYJwWiRKGHlfeS(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BNjYJwWiRKGHlfeS(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool BNjYJwWiRKGHlfeS(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.isTitleCollapseFadeMode();
    }

    public static void BRGgdjSKkHCYkoVe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BRGgdjSKkHCYkoVe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BRGgdjSKkHCYkoVe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int[] BRGgdjSKkHCYkoVe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getDrawableState();
    }

    public static int BZRvGljePCbefjZM(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void BZRvGljePCbefjZM(int i, int i2, byte b, bool z, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void BZRvGljePCbefjZM(int i, int i2, bool z, byte b, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BZRvGljePCbefjZM(int i, int i2, bool z, float f, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int BimsMXfPYByurVFe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getHeight();
    }

    public static void BimsMXfPYByurVFe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BimsMXfPYByurVFe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BimsMXfPYByurVFe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent BsPZhhfsRLUIVISh(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getParent();
    }

    public static void BsPZhhfsRLUIVISh(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BsPZhhfsRLUIVISh(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BsPZhhfsRLUIVISh(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int BwNuXWKodWgsmiWY(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void BwNuXWKodWgsmiWY(android.view.object view, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BwNuXWKodWgsmiWY(android.view.object view, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BwNuXWKodWgsmiWY(android.view.object view, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BymywWMvRZMynJHm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface) {
        collapsingTextHelper.setExpandedTypeface(typeface);
    }

    public static void BymywWMvRZMynJHm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BymywWMvRZMynJHm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BymywWMvRZMynJHm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CCwBAvrhDJVabyzV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer) {
        collapsingTextHelper.setStaticLayoutBuilderConfigurer(staticLayoutBuilderConfigurer);
    }

    public static void CCwBAvrhDJVabyzV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CCwBAvrhDJVabyzV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CCwBAvrhDJVabyzV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, com.google.android.material.internal.StaticLayoutBuilderConfigurer staticLayoutBuilderConfigurer, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static int CIOGTitDPLXfegXX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getMeasuredHeight();
    }

    public static void CIOGTitDPLXfegXX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CIOGTitDPLXfegXX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CIOGTitDPLXfegXX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CNisMyBHCrvcXomk(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void CNisMyBHCrvcXomk(android.graphics.Canvas canvas, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CNisMyBHCrvcXomk(android.graphics.Canvas canvas, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CNisMyBHCrvcXomk(android.graphics.Canvas canvas, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CfauhBadYEkmMBHK(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void CfauhBadYEkmMBHK(android.content.res.TypedArray typedArray, int i, int i2, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CfauhBadYEkmMBHK(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CfauhBadYEkmMBHK(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CjiEhUocSVuhVyhw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4) {
        collapsingTextHelper.setExpandedBounds(i, i2, i3, i4);
    }

    public static void CjiEhUocSVuhVyhw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, char c, int i5, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CjiEhUocSVuhVyhw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, int i5, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CjiEhUocSVuhVyhw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, java.lang.string str, char c, byte b, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void CsncPHpWIqLOuZBN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence) {
        collapsingToolbarLayout.setTitle(charSequence);
    }

    public static void CsncPHpWIqLOuZBN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CsncPHpWIqLOuZBN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CsncPHpWIqLOuZBN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DCYGdYzCBafWdQWM(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void DCYGdYzCBafWdQWM(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, char c, bool z, int i5, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DCYGdYzCBafWdQWM(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, char c, bool z, java.lang.string str, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void DCYGdYzCBafWdQWM(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, int i5, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DIJpcJynuiRqEVSb(android.view.object view, bool z) {
        androidx.core.view.objectCompat.setFitsSystemWindows(view, z);
    }

    public static void DIJpcJynuiRqEVSb(android.view.object view, bool z, char c, byte b, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DIJpcJynuiRqEVSb(android.view.object view, bool z, int i, byte b, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DIJpcJynuiRqEVSb(android.view.object view, bool z, bool z2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int DohOFjSdraRPTDQA(android.view.object view) {
        return getHeightWithMargins(view);
    }

    public static void DohOFjSdraRPTDQA(android.view.object view, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DohOFjSdraRPTDQA(android.view.object view, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DohOFjSdraRPTDQA(android.view.object view, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator EAJydMcKBTgxbiZr(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void EAJydMcKBTgxbiZr(android.animation.ValueAnimator valueAnimator, long j, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EAJydMcKBTgxbiZr(android.animation.ValueAnimator valueAnimator, long j, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EAJydMcKBTgxbiZr(android.animation.ValueAnimator valueAnimator, long j, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EHhVsvMwXJNtUIiN(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void EHhVsvMwXJNtUIiN(android.view.object view, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EHhVsvMwXJNtUIiN(android.view.object view, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EHhVsvMwXJNtUIiN(android.view.object view, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUOnJyhTUKXKeJEY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        collapsingToolbarLayout.setMinimumHeight(i);
    }

    public static void EUOnJyhTUKXKeJEY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EUOnJyhTUKXKeJEY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUOnJyhTUKXKeJEY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, char c, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EbNRlxShHlmAWbPP(android.graphics.drawable.Drawable drawable, int[] iArr, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EbNRlxShHlmAWbPP(android.graphics.drawable.Drawable drawable, int[] iArr, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EbNRlxShHlmAWbPP(android.graphics.drawable.Drawable drawable, int[] iArr, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool EbNRlxShHlmAWbPP(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static android.graphics.drawable.Drawable EcXvVvTqWzhWrqxX(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getDrawable(context, i);
    }

    public static void EcXvVvTqWzhWrqxX(android.content.object context, int i, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EcXvVvTqWzhWrqxX(android.content.object context, int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EcXvVvTqWzhWrqxX(android.content.object context, int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ElyfWdvarLrbQZrD(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void ElyfWdvarLrbQZrD(android.view.object view, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ElyfWdvarLrbQZrD(android.view.object view, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ElyfWdvarLrbQZrD(android.view.object view, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EqPdhSbaqTUgBsuH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.requestLayout();
    }

    public static void EqPdhSbaqTUgBsuH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EqPdhSbaqTUgBsuH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EqPdhSbaqTUgBsuH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EzzcndTCUyqGDfwq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface) {
        collapsingTextHelper.setCollapsedTypeface(typeface);
    }

    public static void EzzcndTCUyqGDfwq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EzzcndTCUyqGDfwq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EzzcndTCUyqGDfwq(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FAvKyJiIouNOQqkh(android.widget.FrameLayout frameLayout) {
        super.drawableStateChanged();
    }

    public static void FAvKyJiIouNOQqkh(android.widget.FrameLayout frameLayout, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FAvKyJiIouNOQqkh(android.widget.FrameLayout frameLayout, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FAvKyJiIouNOQqkh(android.widget.FrameLayout frameLayout, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable FiQrBFcxrunCjwyK(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static void FiQrBFcxrunCjwyK(android.content.res.TypedArray typedArray, int i, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FiQrBFcxrunCjwyK(android.content.res.TypedArray typedArray, int i, char c, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FiQrBFcxrunCjwyK(android.content.res.TypedArray typedArray, int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface FkomceKjRaEpyRtg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCollapsedTypeface();
    }

    public static void FkomceKjRaEpyRtg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FkomceKjRaEpyRtg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FkomceKjRaEpyRtg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FqAgDAcXjqqhhXnr(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FqAgDAcXjqqhhXnr(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FqAgDAcXjqqhhXnr(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FqAgDAcXjqqhhXnr(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable) {
        return super.verifyDrawable(drawable);
    }

    public static android.content.res.ColorStateList FykeGBAkuzJYwHSU(android.content.object context, int i) {
        return com.google.android.material.color.MaterialColors.getColorStateListOrNull(context, i);
    }

    public static void FykeGBAkuzJYwHSU(android.content.object context, int i, byte b, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FykeGBAkuzJYwHSU(android.content.object context, int i, char c, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FykeGBAkuzJYwHSU(android.content.object context, int i, short s, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GDEiFflSWzuFiQTl(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z) {
        collapsingTextHelper.setRtlTextDirectionHeuristicsEnabled(z);
    }

    public static void GDEiFflSWzuFiQTl(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, float f, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GDEiFflSWzuFiQTl(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, bool z2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GDEiFflSWzuFiQTl(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, bool z2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GJxPGhNWduktQwOL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable) {
        collapsingToolbarLayout.setContentScrim(drawable);
    }

    public static void GJxPGhNWduktQwOL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GJxPGhNWduktQwOL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GJxPGhNWduktQwOL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static float GRLDcUNcVUDgWayV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getFadeModeThresholdFraction();
    }

    public static void GRLDcUNcVUDgWayV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GRLDcUNcVUDgWayV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GRLDcUNcVUDgWayV(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence GlljaKLncpRAVBbN(android.view.object view) {
        return getToolbarTitle(view);
    }

    public static void GlljaKLncpRAVBbN(android.view.object view, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GlljaKLncpRAVBbN(android.view.object view, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GlljaKLncpRAVBbN(android.view.object view, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GzTTGWxicWwnrEGI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.Configuration configuration) {
        collapsingTextHelper.maybeUpdateFontWeightAdjustment(configuration);
    }

    public static void GzTTGWxicWwnrEGI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.Configuration configuration, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GzTTGWxicWwnrEGI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.Configuration configuration, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GzTTGWxicWwnrEGI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.Configuration configuration, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HIIDbmhtVxmhBQDF(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper) {
        viewOffsetHelper.onobjectLayout();
    }

    public static void HIIDbmhtVxmhBQDF(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HIIDbmhtVxmhBQDF(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HIIDbmhtVxmhBQDF(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float HMpgtcQvjQWdIspI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getExpandedTextFullHeight();
    }

    public static void HMpgtcQvjQWdIspI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HMpgtcQvjQWdIspI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HMpgtcQvjQWdIspI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HOIJYbBugLKocBFp(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.updateTitleFromToolbarIfNeeded();
    }

    public static void HOIJYbBugLKocBFp(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HOIJYbBugLKocBFp(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HOIJYbBugLKocBFp(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HQVXtismGGVTaMwL(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getTitleMarginTop();
    }

    public static void HQVXtismGGVTaMwL(androidx.appcompat.widget.Toolbar toolbar, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HQVXtismGGVTaMwL(androidx.appcompat.widget.Toolbar toolbar, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HQVXtismGGVTaMwL(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence HntkLcnEtATbZHhh(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getTitle();
    }

    public static void HntkLcnEtATbZHhh(androidx.appcompat.widget.Toolbar toolbar, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HntkLcnEtATbZHhh(androidx.appcompat.widget.Toolbar toolbar, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HntkLcnEtATbZHhh(androidx.appcompat.widget.Toolbar toolbar, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IGfzJdUuHuthoLzI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.requestLayout();
    }

    public static void IGfzJdUuHuthoLzI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IGfzJdUuHuthoLzI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IGfzJdUuHuthoLzI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IGuxwRDHwLumsDLs(android.content.res.TypedArray typedArray, int i, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IGuxwRDHwLumsDLs(android.content.res.TypedArray typedArray, int i, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IGuxwRDHwLumsDLs(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IGuxwRDHwLumsDLs(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void IPsysAorjzkksDwy(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void IPsysAorjzkksDwy(android.view.object view, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IPsysAorjzkksDwy(android.view.object view, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IPsysAorjzkksDwy(android.view.object view, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IVVgKCniToxeQVnk(android.view.object view) {
        return view.getHeight();
    }

    public static void IVVgKCniToxeQVnk(android.view.object view, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IVVgKCniToxeQVnk(android.view.object view, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IVVgKCniToxeQVnk(android.view.object view, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IZIIiPhXAwEYMWVR(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getWidth();
    }

    public static void IZIIiPhXAwEYMWVR(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IZIIiPhXAwEYMWVR(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IZIIiPhXAwEYMWVR(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams IcbUIpYjqbXPLaQq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.generateDefaultLayoutParams();
    }

    public static void IcbUIpYjqbXPLaQq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IcbUIpYjqbXPLaQq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IcbUIpYjqbXPLaQq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IgFITPwaCJNNhUDG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable) {
        collapsingToolbarLayout.setContentScrim(drawable);
    }

    public static void IgFITPwaCJNNhUDG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IgFITPwaCJNNhUDG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IgFITPwaCJNNhUDG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ImtqCRMOaAREMVXY(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static void ImtqCRMOaAREMVXY(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ImtqCRMOaAREMVXY(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ImtqCRMOaAREMVXY(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams IvECfkAZEHfWHNxx(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.generateDefaultLayoutParams();
    }

    public static void IvECfkAZEHfWHNxx(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IvECfkAZEHfWHNxx(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IvECfkAZEHfWHNxx(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence JCSKxYHMCozyKNyO(android.widget.Toolbar toolbar) {
        return toolbar.getTitle();
    }

    public static void JCSKxYHMCozyKNyO(android.widget.Toolbar toolbar, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JCSKxYHMCozyKNyO(android.widget.Toolbar toolbar, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JCSKxYHMCozyKNyO(android.widget.Toolbar toolbar, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable JMhpWwOJOgKyNeog(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static void JMhpWwOJOgKyNeog(android.content.res.TypedArray typedArray, int i, char c, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JMhpWwOJOgKyNeog(android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JMhpWwOJOgKyNeog(android.content.res.TypedArray typedArray, int i, bool z, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JQTpMARANBRGOVNE(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void JQTpMARANBRGOVNE(android.graphics.drawable.Drawable drawable, int i, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JQTpMARANBRGOVNE(android.graphics.drawable.Drawable drawable, int i, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JQTpMARANBRGOVNE(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList JaKRplxTypkAAuqA(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void JaKRplxTypkAAuqA(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JaKRplxTypkAAuqA(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JaKRplxTypkAAuqA(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int JabVsFKsDOimxQjA(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getVisibility();
    }

    public static void JabVsFKsDOimxQjA(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JabVsFKsDOimxQjA(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JabVsFKsDOimxQjA(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable JonkUTTqLGoBBGBy(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void JonkUTTqLGoBBGBy(android.graphics.drawable.Drawable drawable, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JonkUTTqLGoBBGBy(android.graphics.drawable.Drawable drawable, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JonkUTTqLGoBBGBy(android.graphics.drawable.Drawable drawable, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JtkXkeZeCHzYgFoP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, int i, int i2) {
        collapsingToolbarLayout.updateContentScrimBounds(drawable, i, i2);
    }

    public static void JtkXkeZeCHzYgFoP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, int i, int i2, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JtkXkeZeCHzYgFoP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, int i, int i2, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JtkXkeZeCHzYgFoP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, int i, int i2, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JubmGZfqVWuVQPOw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        collapsingToolbarLayout.setContentScrimColor(i);
    }

    public static void JubmGZfqVWuVQPOw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JubmGZfqVWuVQPOw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JubmGZfqVWuVQPOw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KDAkXaCtoSRcZFhu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.content.res.ColorStateList colorStateList) {
        collapsingToolbarLayout.setCollapsedTitleTextColor(colorStateList);
    }

    public static void KDAkXaCtoSRcZFhu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.content.res.ColorStateList colorStateList, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KDAkXaCtoSRcZFhu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.content.res.ColorStateList colorStateList, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KDAkXaCtoSRcZFhu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.content.res.ColorStateList colorStateList, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KQKQrFRuvCudZmAS(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void KQKQrFRuvCudZmAS(android.graphics.Canvas canvas, int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KQKQrFRuvCudZmAS(android.graphics.Canvas canvas, int i, int i2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KQKQrFRuvCudZmAS(android.graphics.Canvas canvas, int i, int i2, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KbBwQoKPQzwFbEtO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getChildCount();
    }

    public static void KbBwQoKPQzwFbEtO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KbBwQoKPQzwFbEtO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KbBwQoKPQzwFbEtO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable KcsZIgYuUvcymaPY(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void KcsZIgYuUvcymaPY(android.graphics.drawable.Drawable drawable, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KcsZIgYuUvcymaPY(android.graphics.drawable.Drawable drawable, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KcsZIgYuUvcymaPY(android.graphics.drawable.Drawable drawable, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KkvOMXRiWDLxrnOq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, int i3, int i4, bool z) {
        collapsingToolbarLayout.updateTextBounds(i, i2, i3, i4, z);
    }

    public static void KkvOMXRiWDLxrnOq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, int i3, int i4, bool z, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KkvOMXRiWDLxrnOq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, int i3, int i4, bool z, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KkvOMXRiWDLxrnOq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, int i3, int i4, bool z, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KoNqMonyYeTpPVCy(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KoNqMonyYeTpPVCy(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KoNqMonyYeTpPVCy(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool KoNqMonyYeTpPVCy(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view) {
        return collapsingToolbarLayout.isToolbarChild(view);
    }

    public static void KokBVwJfmZmQrMmB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable) {
        collapsingToolbarLayout.setStatusBarScrim(drawable);
    }

    public static void KokBVwJfmZmQrMmB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KokBVwJfmZmQrMmB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KokBVwJfmZmQrMmB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KwgOduMVSLKfopaA(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getChildCount();
    }

    public static void KwgOduMVSLKfopaA(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KwgOduMVSLKfopaA(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KwgOduMVSLKfopaA(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KzLScoyjLmPXNiSV(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        collapsingToolbarLayout.disableLiftOnScrollIfNeeded(appBarLayout);
    }

    public static void KzLScoyjLmPXNiSV(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KzLScoyjLmPXNiSV(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KzLScoyjLmPXNiSV(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LFBqklCPaGGibFnG(android.widget.Toolbar toolbar) {
        return toolbar.getTitleMarginTop();
    }

    public static void LFBqklCPaGGibFnG(android.widget.Toolbar toolbar, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LFBqklCPaGGibFnG(android.widget.Toolbar toolbar, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LFBqklCPaGGibFnG(android.widget.Toolbar toolbar, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LQdxCxPKfFbdXCmc(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.requestLayout();
    }

    public static void LQdxCxPKfFbdXCmc(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LQdxCxPKfFbdXCmc(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LQdxCxPKfFbdXCmc(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LRTRYcdCPZCdnvtd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence) {
        collapsingTextHelper.setText(charSequence);
    }

    public static void LRTRYcdCPZCdnvtd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LRTRYcdCPZCdnvtd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LRTRYcdCPZCdnvtd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LYdLTwKdnjpFGRno(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        collapsingTextHelper.setExpandedTextColor(colorStateList);
    }

    public static void LYdLTwKdnjpFGRno(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LYdLTwKdnjpFGRno(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LYdLTwKdnjpFGRno(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LqaXwJdfNklUjwcV(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqaXwJdfNklUjwcV(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LqaXwJdfNklUjwcV(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool LqaXwJdfNklUjwcV(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.isInEditMode();
    }

    public static int LvVKOrYqujOkPClp(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getTitleMarginBottom();
    }

    public static void LvVKOrYqujOkPClp(androidx.appcompat.widget.Toolbar toolbar, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LvVKOrYqujOkPClp(androidx.appcompat.widget.Toolbar toolbar, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LvVKOrYqujOkPClp(androidx.appcompat.widget.Toolbar toolbar, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.appbar.objectOffsetHelper MJSTpqKbIxjIUouP(android.view.object view) {
        return getobjectOffsetHelper(view);
    }

    public static void MJSTpqKbIxjIUouP(android.view.object view, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MJSTpqKbIxjIUouP(android.view.object view, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MJSTpqKbIxjIUouP(android.view.object view, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object MMljePtmuWxljkxs(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getobject();
    }

    public static void MMljePtmuWxljkxs(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MMljePtmuWxljkxs(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MMljePtmuWxljkxs(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int MfRIgjRpAZXodlJH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getHeight();
    }

    public static void MfRIgjRpAZXodlJH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MfRIgjRpAZXodlJH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MfRIgjRpAZXodlJH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int MmDOcigjPFoFfhki(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void MmDOcigjPFoFfhki(int i, int i2, byte b, short s, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MmDOcigjPFoFfhki(int i, int i2, int i3, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MmDOcigjPFoFfhki(int i, int i2, bool z, short s, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int NDrzlYbuNjCxVQPn(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void NDrzlYbuNjCxVQPn(android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NDrzlYbuNjCxVQPn(android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NDrzlYbuNjCxVQPn(android.content.res.TypedArray typedArray, int i, int i2, int i3, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NHoSsCLCjIlVojGh(android.view.object view, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NHoSsCLCjIlVojGh(android.view.object view, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NHoSsCLCjIlVojGh(android.view.object view, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NHoSsCLCjIlVojGh(android.view.object view) {
        return isToolbar(view);
    }

    public static void NIDzbWxzbtFUPrAy(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.content.res.ColorStateList colorStateList) {
        collapsingToolbarLayout.setExpandedTitleTextColor(colorStateList);
    }

    public static void NIDzbWxzbtFUPrAy(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.content.res.ColorStateList colorStateList, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NIDzbWxzbtFUPrAy(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.content.res.ColorStateList colorStateList, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NIDzbWxzbtFUPrAy(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.content.res.ColorStateList colorStateList, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NxoTAxxcLONHluhC(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void NxoTAxxcLONHluhC(android.view.object view, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NxoTAxxcLONHluhC(android.view.object view, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NxoTAxxcLONHluhC(android.view.object view, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NzHAIOumkFDImcLY(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void NzHAIOumkFDImcLY(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NzHAIOumkFDImcLY(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NzHAIOumkFDImcLY(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OFNZEQZuiRqGAOwv(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void OFNZEQZuiRqGAOwv(android.content.res.TypedArray typedArray, int i, int i2, float f, int i3, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OFNZEQZuiRqGAOwv(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OFNZEQZuiRqGAOwv(android.content.res.TypedArray typedArray, int i, int i2, short s, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OGBIGFwKfuTTYPQH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getMaxLines();
    }

    public static void OGBIGFwKfuTTYPQH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OGBIGFwKfuTTYPQH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OGBIGFwKfuTTYPQH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OGbWCgFscYTrZgkS(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        collapsingToolbarLayout.setScrimAlpha(i);
    }

    public static void OGbWCgFscYTrZgkS(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, char c, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OGbWCgFscYTrZgkS(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OGbWCgFscYTrZgkS(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OMxzboioIbWWdVVR(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static void OMxzboioIbWWdVVR(androidx.core.view.WindowInsetsCompat windowInsetsCompat, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OMxzboioIbWWdVVR(androidx.core.view.WindowInsetsCompat windowInsetsCompat, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OMxzboioIbWWdVVR(androidx.core.view.WindowInsetsCompat windowInsetsCompat, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator OlRxmQsFGFrxImzW(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void OlRxmQsFGFrxImzW(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OlRxmQsFGFrxImzW(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OlRxmQsFGFrxImzW(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void POiTJBfGPYhIVNBj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setCollapsedTextAppearance(i);
    }

    public static void POiTJBfGPYhIVNBj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void POiTJBfGPYhIVNBj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void POiTJBfGPYhIVNBj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PRlBWLSxlYlYloNn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setLineSpacingMultiplier(f);
    }

    public static void PRlBWLSxlYlYloNn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PRlBWLSxlYlYloNn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PRlBWLSxlYlYloNn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int PSLcjYGJsOYtIxhP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getChildCount();
    }

    public static void PSLcjYGJsOYtIxhP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PSLcjYGJsOYtIxhP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PSLcjYGJsOYtIxhP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PUAejGVJpDuqWZzJ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        collapsingTextHelper.setExpandedTextColor(colorStateList);
    }

    public static void PUAejGVJpDuqWZzJ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PUAejGVJpDuqWZzJ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PUAejGVJpDuqWZzJ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable PZtNfQgPbihUcAvS(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void PZtNfQgPbihUcAvS(android.graphics.drawable.Drawable drawable, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PZtNfQgPbihUcAvS(android.graphics.drawable.Drawable drawable, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PZtNfQgPbihUcAvS(android.graphics.drawable.Drawable drawable, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PeLLvsYQyNeNADpj(android.graphics.drawable.Drawable drawable, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PeLLvsYQyNeNADpj(android.graphics.drawable.Drawable drawable, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PeLLvsYQyNeNADpj(android.graphics.drawable.Drawable drawable, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PeLLvsYQyNeNADpj(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static float PkOJYISzGoznPqHm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getLineSpacingMultiplier();
    }

    public static void PkOJYISzGoznPqHm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PkOJYISzGoznPqHm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PkOJYISzGoznPqHm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int PwKzbBboXdYdyigY(float f) {
        return java.lang.Math.round(f);
    }

    public static void PwKzbBboXdYdyigY(float f, float f2, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PwKzbBboXdYdyigY(float f, int i, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PwKzbBboXdYdyigY(float f, short s, float f2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams QCNLdRdeNsCXGHUE(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void QCNLdRdeNsCXGHUE(android.view.object view, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QCNLdRdeNsCXGHUE(android.view.object view, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QCNLdRdeNsCXGHUE(android.view.object view, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QIuSdAFThtqrnyIw(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getTitleMarginEnd();
    }

    public static void QIuSdAFThtqrnyIw(androidx.appcompat.widget.Toolbar toolbar, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QIuSdAFThtqrnyIw(androidx.appcompat.widget.Toolbar toolbar, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QIuSdAFThtqrnyIw(androidx.appcompat.widget.Toolbar toolbar, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QghxMlbXvraJFsTH(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void QghxMlbXvraJFsTH(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QghxMlbXvraJFsTH(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QghxMlbXvraJFsTH(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QumvqwiNpkpkBcKg(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener appBarLayout$OnOffsetChangedListener) {
        appBarLayout.removeOnOffsetChangedListener(appBarLayout$OnOffsetChangedListener);
    }

    public static void QumvqwiNpkpkBcKg(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener appBarLayout$OnOffsetChangedListener, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QumvqwiNpkpkBcKg(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener appBarLayout$OnOffsetChangedListener, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QumvqwiNpkpkBcKg(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener appBarLayout$OnOffsetChangedListener, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int RBkjHgxMkAPcEzKi(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getHeight();
    }

    public static void RBkjHgxMkAPcEzKi(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RBkjHgxMkAPcEzKi(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RBkjHgxMkAPcEzKi(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RQPrgvZbRrzyqOpg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setExpandedTextAppearance(i);
    }

    public static void RQPrgvZbRrzyqOpg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RQPrgvZbRrzyqOpg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RQPrgvZbRrzyqOpg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RwRMyndLySbBKBqu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.ensureToolbar();
    }

    public static void RwRMyndLySbBKBqu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RwRMyndLySbBKBqu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RwRMyndLySbBKBqu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SAuletYFeUeDDndI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.ensureToolbar();
    }

    public static void SAuletYFeUeDDndI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SAuletYFeUeDDndI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SAuletYFeUeDDndI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SCEYFSwfwxLLeJsj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setCollapsedTextAppearance(i);
    }

    public static void SCEYFSwfwxLLeJsj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, byte b, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCEYFSwfwxLLeJsj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SCEYFSwfwxLLeJsj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SIxewyeMwHkxryNm(android.view.object view) {
        return androidx.core.view.objectCompat.getMinimumHeight(view);
    }

    public static void SIxewyeMwHkxryNm(android.view.object view, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SIxewyeMwHkxryNm(android.view.object view, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SIxewyeMwHkxryNm(android.view.object view, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SKBUBqiGXpdwfsqv(android.view.object view, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SKBUBqiGXpdwfsqv(android.view.object view, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SKBUBqiGXpdwfsqv(android.view.object view, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SKBUBqiGXpdwfsqv(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static void SRTmrEmFiaHUexBu(android.animation.ValueAnimator valueAnimator, int[] iArr) {
        valueAnimator.setIntValues(iArr);
    }

    public static void SRTmrEmFiaHUexBu(android.animation.ValueAnimator valueAnimator, int[] iArr, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SRTmrEmFiaHUexBu(android.animation.ValueAnimator valueAnimator, int[] iArr, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SRTmrEmFiaHUexBu(android.animation.ValueAnimator valueAnimator, int[] iArr, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void STVukzDbCtfYbJcI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z) {
        collapsingToolbarLayout.setScrimsShown(z);
    }

    public static void STVukzDbCtfYbJcI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, byte b, int i, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void STVukzDbCtfYbJcI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, byte b, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void STVukzDbCtfYbJcI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, int i, char c, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static int SVveVKhsBdSatzib(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getMaxLines();
    }

    public static void SVveVKhsBdSatzib(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SVveVKhsBdSatzib(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SVveVKhsBdSatzib(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ScKMXNsxpFfgnjLf(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setExpandedTextGravity(i);
    }

    public static void ScKMXNsxpFfgnjLf(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ScKMXNsxpFfgnjLf(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, char c, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ScKMXNsxpFfgnjLf(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, short s, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SffynjSFcZgILpSm(android.view.object view, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SffynjSFcZgILpSm(android.view.object view, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SffynjSFcZgILpSm(android.view.object view, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SffynjSFcZgILpSm(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static void TFGQQNNrXfdFAmWl(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.updateScrimVisibility();
    }

    public static void TFGQQNNrXfdFAmWl(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TFGQQNNrXfdFAmWl(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TFGQQNNrXfdFAmWl(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TJxQNIKOULCHpecM(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        collapsingToolbarLayout.animateScrim(i);
    }

    public static void TJxQNIKOULCHpecM(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TJxQNIKOULCHpecM(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TJxQNIKOULCHpecM(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int TOhTvPWcfxHRTIcu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getDefaultContentScrimColorForTitleCollapseFadeMode();
    }

    public static void TOhTvPWcfxHRTIcu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TOhTvPWcfxHRTIcu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TOhTvPWcfxHRTIcu(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TVcIepJZhOfMSXQx(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void TVcIepJZhOfMSXQx(android.graphics.drawable.Drawable drawable, int i, float f, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TVcIepJZhOfMSXQx(android.graphics.drawable.Drawable drawable, int i, bool z, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TVcIepJZhOfMSXQx(android.graphics.drawable.Drawable drawable, int i, bool z, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TYBAKjTpPTAoUZaI(android.content.res.TypedArray typedArray, int i, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TYBAKjTpPTAoUZaI(android.content.res.TypedArray typedArray, int i, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TYBAKjTpPTAoUZaI(android.content.res.TypedArray typedArray, int i, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TYBAKjTpPTAoUZaI(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int TYXgLdzBZfWNaqhN(android.view.object view) {
        return view.getBottom();
    }

    public static void TYXgLdzBZfWNaqhN(android.view.object view, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TYXgLdzBZfWNaqhN(android.view.object view, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TYXgLdzBZfWNaqhN(android.view.object view, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TYrdyXBCQTeYFhBa(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.requestLayout();
    }

    public static void TYrdyXBCQTeYFhBa(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TYrdyXBCQTeYFhBa(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TYrdyXBCQTeYFhBa(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TmlJcTbueftIVqFO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        collapsingToolbarLayout.disableLiftOnScrollIfNeeded(appBarLayout);
    }

    public static void TmlJcTbueftIVqFO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TmlJcTbueftIVqFO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TmlJcTbueftIVqFO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object TuvMFWgRaYPQeWZy(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void TuvMFWgRaYPQeWZy(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TuvMFWgRaYPQeWZy(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TuvMFWgRaYPQeWZy(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TyDXElljyshoaUaP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        return collapsingToolbarLayout.getChildAt(i);
    }

    public static void TyDXElljyshoaUaP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TyDXElljyshoaUaP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TyDXElljyshoaUaP(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TyGePmLdrkCsLWJL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator) {
        collapsingTextHelper.setTextSizeInterpolator(timeInterpolator);
    }

    public static void TyGePmLdrkCsLWJL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TyGePmLdrkCsLWJL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TyGePmLdrkCsLWJL(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int UHMEnHZrjIIacdLS(android.view.object view) {
        return view.getVisibility();
    }

    public static void UHMEnHZrjIIacdLS(android.view.object view, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UHMEnHZrjIIacdLS(android.view.object view, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UHMEnHZrjIIacdLS(android.view.object view, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UuEFCwQnkWjGLxxe(android.widget.FrameLayout frameLayout, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void UuEFCwQnkWjGLxxe(android.widget.FrameLayout frameLayout, bool z, int i, int i2, int i3, int i4, char c, byte b, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UuEFCwQnkWjGLxxe(android.widget.FrameLayout frameLayout, bool z, int i, int i2, int i3, int i4, char c, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UuEFCwQnkWjGLxxe(android.widget.FrameLayout frameLayout, bool z, int i, int i2, int i3, int i4, bool z2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VEQzqgNCAslRzewg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VEQzqgNCAslRzewg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VEQzqgNCAslRzewg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VEQzqgNCAslRzewg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.isRtlTextDirectionHeuristicsEnabled();
    }

    public static void VMWRzRSmWOfvaBin(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void VMWRzRSmWOfvaBin(android.view.object view, int i, byte b, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VMWRzRSmWOfvaBin(android.view.object view, int i, java.lang.string str, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VMWRzRSmWOfvaBin(android.view.object view, int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent VUZPRaSARSsERSLC(android.view.objectParent viewParent) {
        return viewParent.getParent();
    }

    public static void VUZPRaSARSsERSLC(android.view.objectParent viewParent, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VUZPRaSARSsERSLC(android.view.objectParent viewParent, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VUZPRaSARSsERSLC(android.view.objectParent viewParent, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VWuMweqgODaFifaH(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void VWuMweqgODaFifaH(android.content.res.TypedArray typedArray, int i, int i2, int i3, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VWuMweqgODaFifaH(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void VWuMweqgODaFifaH(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable VWvHnYyDNvBFOBYG(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void VWvHnYyDNvBFOBYG(android.graphics.drawable.Drawable drawable, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VWvHnYyDNvBFOBYG(android.graphics.drawable.Drawable drawable, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VWvHnYyDNvBFOBYG(android.graphics.drawable.Drawable drawable, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources VZNEeaPMuvMLryps(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getResources();
    }

    public static void VZNEeaPMuvMLryps(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VZNEeaPMuvMLryps(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VZNEeaPMuvMLryps(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VdgTZDXbxDCFfhqm(android.view.object view, int i, java.lang.object obj) {
        view.setTag(i, obj);
    }

    public static void VdgTZDXbxDCFfhqm(android.view.object view, int i, java.lang.object obj, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VdgTZDXbxDCFfhqm(android.view.object view, int i, java.lang.object obj, short s, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VdgTZDXbxDCFfhqm(android.view.object view, int i, java.lang.object obj, bool z, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.appbar.objectOffsetHelper VlJILtoZZeNnXSuC(android.view.object view) {
        return getobjectOffsetHelper(view);
    }

    public static void VlJILtoZZeNnXSuC(android.view.object view, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VlJILtoZZeNnXSuC(android.view.object view, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VlJILtoZZeNnXSuC(android.view.object view, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VtlFhYIkBjfhWIdb(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getHyphenationFrequency();
    }

    public static void VtlFhYIkBjfhWIdb(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VtlFhYIkBjfhWIdb(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VtlFhYIkBjfhWIdb(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WNHlcOOJDXCilrCs(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        collapsingToolbarLayout.setMinimumHeight(i);
    }

    public static void WNHlcOOJDXCilrCs(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, float f, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WNHlcOOJDXCilrCs(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WNHlcOOJDXCilrCs(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static float WNfcrOUiJOllRytd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getExpandedTextSize();
    }

    public static void WNfcrOUiJOllRytd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WNfcrOUiJOllRytd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WNfcrOUiJOllRytd(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent WTPGNIlguBYIQiJv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getParent();
    }

    public static void WTPGNIlguBYIQiJv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WTPGNIlguBYIQiJv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WTPGNIlguBYIQiJv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WYBqpCDAbXvALWMd(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void WYBqpCDAbXvALWMd(android.graphics.drawable.Drawable drawable, int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WYBqpCDAbXvALWMd(android.graphics.drawable.Drawable drawable, int i, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WYBqpCDAbXvALWMd(android.graphics.drawable.Drawable drawable, int i, bool z, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WaGKUncLhVFHsfEQ(android.graphics.drawable.Drawable drawable, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WaGKUncLhVFHsfEQ(android.graphics.drawable.Drawable drawable, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WaGKUncLhVFHsfEQ(android.graphics.drawable.Drawable drawable, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WaGKUncLhVFHsfEQ(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static androidx.core.view.WindowInsetsCompat WplFpMURSqAOOXLa(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.consumeSystemWindowInsets();
    }

    public static void WplFpMURSqAOOXLa(androidx.core.view.WindowInsetsCompat windowInsetsCompat, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WplFpMURSqAOOXLa(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WplFpMURSqAOOXLa(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object WxOnCsxwsxwIHNyK(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getobject();
    }

    public static void WxOnCsxwsxwIHNyK(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WxOnCsxwsxwIHNyK(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WxOnCsxwsxwIHNyK(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XHvhCQrnropBvgjO(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XHvhCQrnropBvgjO(android.content.res.TypedArray typedArray, int i, bool z, int i2, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XHvhCQrnropBvgjO(android.content.res.TypedArray typedArray, int i, bool z, bool z2, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool XHvhCQrnropBvgjO(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static android.widget.FrameLayout$LayoutParams XSepzzAyAMFyxbOk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return collapsingToolbarLayout.generateLayoutParams(viewGroup$LayoutParams);
    }

    public static void XSepzzAyAMFyxbOk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XSepzzAyAMFyxbOk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XSepzzAyAMFyxbOk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XUPmcQOJtwuezXbG(android.widget.FrameLayout frameLayout) {
        super.onDetachedFromWindow();
    }

    public static void XUPmcQOJtwuezXbG(android.widget.FrameLayout frameLayout, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XUPmcQOJtwuezXbG(android.widget.FrameLayout frameLayout, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XUPmcQOJtwuezXbG(android.widget.FrameLayout frameLayout, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XVVyuPywiUkqEdIH(android.graphics.drawable.Drawable drawable, int[] iArr, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XVVyuPywiUkqEdIH(android.graphics.drawable.Drawable drawable, int[] iArr, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XVVyuPywiUkqEdIH(android.graphics.drawable.Drawable drawable, int[] iArr, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool XVVyuPywiUkqEdIH(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static android.view.objectParent XWQJqpqFXzBqONVe(android.view.object view) {
        return view.getParent();
    }

    public static void XWQJqpqFXzBqONVe(android.view.object view, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XWQJqpqFXzBqONVe(android.view.object view, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XWQJqpqFXzBqONVe(android.view.object view, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XjgvnhjebNRvuqWE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int[] iArr, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XjgvnhjebNRvuqWE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int[] iArr, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XjgvnhjebNRvuqWE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int[] iArr, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XjgvnhjebNRvuqWE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int[] iArr) {
        return collapsingTextHelper.setState(iArr);
    }

    public static void XolCNntlxysBdFdA(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, onApplyWindowInsetsListener);
    }

    public static void XolCNntlxysBdFdA(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XolCNntlxysBdFdA(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XolCNntlxysBdFdA(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YAINzzlxVMvsUnJq(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static void YAINzzlxVMvsUnJq(androidx.core.view.WindowInsetsCompat windowInsetsCompat, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YAINzzlxVMvsUnJq(androidx.core.view.WindowInsetsCompat windowInsetsCompat, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YAINzzlxVMvsUnJq(androidx.core.view.WindowInsetsCompat windowInsetsCompat, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int YPxRVedINzBGeknN(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static void YPxRVedINzBGeknN(androidx.core.view.WindowInsetsCompat windowInsetsCompat, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YPxRVedINzBGeknN(androidx.core.view.WindowInsetsCompat windowInsetsCompat, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YPxRVedINzBGeknN(androidx.core.view.WindowInsetsCompat windowInsetsCompat, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YfrXmkdiiegCLwIE(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.updateTitleFromToolbarIfNeeded();
    }

    public static void YfrXmkdiiegCLwIE(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YfrXmkdiiegCLwIE(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YfrXmkdiiegCLwIE(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.animation.Interpolator YmKizAQlTshtKVMy(android.content.object context, int i) {
        return android.view.animation.AnimationUtils.loadInterpolator(context, i);
    }

    public static void YmKizAQlTshtKVMy(android.content.object context, int i, float f, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YmKizAQlTshtKVMy(android.content.object context, int i, java.lang.string str, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YmKizAQlTshtKVMy(android.content.object context, int i, short s, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YnXDIjetQZdcrGjE(android.content.res.TypedArray typedArray, int i, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YnXDIjetQZdcrGjE(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YnXDIjetQZdcrGjE(android.content.res.TypedArray typedArray, int i, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YnXDIjetQZdcrGjE(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void YuUNZUXMbcmFxGQi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas) {
        collapsingTextHelper.draw(canvas);
    }

    public static void YuUNZUXMbcmFxGQi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YuUNZUXMbcmFxGQi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YuUNZUXMbcmFxGQi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList YzaeCRYacpYbzvxy(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void YzaeCRYacpYbzvxy(int i, byte b, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YzaeCRYacpYbzvxy(int i, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YzaeCRYacpYbzvxy(int i, java.lang.string str, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZGGvfPdsxfQXjxBv(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void ZGGvfPdsxfQXjxBv(android.animation.ValueAnimator valueAnimator, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZGGvfPdsxfQXjxBv(android.animation.ValueAnimator valueAnimator, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZGGvfPdsxfQXjxBv(android.animation.ValueAnimator valueAnimator, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZQXwfirZjIyvJDKr(android.content.res.TypedArray typedArray, int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZQXwfirZjIyvJDKr(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZQXwfirZjIyvJDKr(android.content.res.TypedArray typedArray, int i, java.lang.string str, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool ZQXwfirZjIyvJDKr(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void ZRQGMafNshGeYMYo(android.widget.FrameLayout frameLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void ZRQGMafNshGeYMYo(android.widget.FrameLayout frameLayout, int i, int i2, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZRQGMafNshGeYMYo(android.widget.FrameLayout frameLayout, int i, int i2, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZRQGMafNshGeYMYo(android.widget.FrameLayout frameLayout, int i, int i2, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZjEJkTbrKniuTRPY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, int i, int i2) {
        collapsingToolbarLayout.updateContentScrimBounds(drawable, i, i2);
    }

    public static void ZjEJkTbrKniuTRPY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, int i, int i2, char c, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZjEJkTbrKniuTRPY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, int i, int i2, int i3, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjEJkTbrKniuTRPY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, int i, int i2, java.lang.string str, char c, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjMWddxOHqQyHnUE(android.view.object view) {
        androidx.core.view.objectCompat.requestApplyInsets(view);
    }

    public static void ZjMWddxOHqQyHnUE(android.view.object view, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZjMWddxOHqQyHnUE(android.view.object view, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZjMWddxOHqQyHnUE(android.view.object view, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZlOwAmKhuDJRDEvn(android.view.object view, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZlOwAmKhuDJRDEvn(android.view.object view, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZlOwAmKhuDJRDEvn(android.view.object view, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZlOwAmKhuDJRDEvn(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static void ZpazrcGfQHJoHsWO(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        collapsingTextHelper.setCollapsedTextColor(colorStateList);
    }

    public static void ZpazrcGfQHJoHsWO(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZpazrcGfQHJoHsWO(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZpazrcGfQHJoHsWO(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZrpxfLaBFpZAZrTH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setCollapsedTextAppearance(i);
    }

    public static void ZrpxfLaBFpZAZrTH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZrpxfLaBFpZAZrTH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, java.lang.string str, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZrpxfLaBFpZAZrTH(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, bool z, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent ZxdyGoRTEJZqcmql(android.view.object view) {
        return view.getParent();
    }

    public static void ZxdyGoRTEJZqcmql(android.view.object view, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZxdyGoRTEJZqcmql(android.view.object view, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZxdyGoRTEJZqcmql(android.view.object view, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ZyuWmFXtpEoAMmXe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view) {
        return collapsingToolbarLayout.findDirectChild(view);
    }

    public static void ZyuWmFXtpEoAMmXe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZyuWmFXtpEoAMmXe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZyuWmFXtpEoAMmXe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZzXUZdKLlcEMTvpt(android.animation.ValueAnimator valueAnimator, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZzXUZdKLlcEMTvpt(android.animation.ValueAnimator valueAnimator, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZzXUZdKLlcEMTvpt(android.animation.ValueAnimator valueAnimator, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZzXUZdKLlcEMTvpt(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static void AAIvxKIAkrspfPss(android.graphics.drawable.Drawable drawable, int[] iArr, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AAIvxKIAkrspfPss(android.graphics.drawable.Drawable drawable, int[] iArr, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AAIvxKIAkrspfPss(android.graphics.drawable.Drawable drawable, int[] iArr, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AAIvxKIAkrspfPss(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void ABKrDQHAZtlwDiKJ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas) {
        collapsingTextHelper.draw(canvas);
    }

    public static void ABKrDQHAZtlwDiKJ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ABKrDQHAZtlwDiKJ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ABKrDQHAZtlwDiKJ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ATLylpIZOcJwCwPS(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void ATLylpIZOcJwCwPS(android.content.res.TypedArray typedArray, int i, int i2, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ATLylpIZOcJwCwPS(android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ATLylpIZOcJwCwPS(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ATvQVstCJFtlsGtY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.updateContentDescriptionFromTitle();
    }

    public static void ATvQVstCJFtlsGtY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ATvQVstCJFtlsGtY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ATvQVstCJFtlsGtY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AfcvZzCAWYjOMuvm(android.view.object view) {
        return getHeightWithMargins(view);
    }

    public static void AfcvZzCAWYjOMuvm(android.view.object view, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AfcvZzCAWYjOMuvm(android.view.object view, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AfcvZzCAWYjOMuvm(android.view.object view, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void AnimateScrim(int i) {
        if ((10 + 17) % 17 > 0) {
        }
        lXRLusalaKcPVZhU(this);
        android.animation.ValueAnimator valueAnimator = this.scrimAnimator;
        if (valueAnimator is null) {
            android.animation.ValueAnimator valueAnimator2 = new android.animation.ValueAnimator();
            this.scrimAnimator = valueAnimator2;
            nOnIBfXOMgRVnzzK(valueAnimator2, i <= this.scrimAlpha ? this.scrimAnimationFadeOutInterpolator : this.scrimAnimationFadeInInterpolator);
            ccXIhobZKhTLzJyi(this.scrimAnimator, new com.google.android.material.appbar.CollapsingToolbarLayout$2(this));
        } else if (ZzXUZdKLlcEMTvpt(valueAnimator)) {
            ZGGvfPdsxfQXjxBv(this.scrimAnimator);
        }
        EAJydMcKBTgxbiZr(this.scrimAnimator, this.scrimAnimationDuration);
        SRTmrEmFiaHUexBu(this.scrimAnimator, new int[]{this.scrimAlpha, i});
        dSavVOcwUGuCdlFp(this.scrimAnimator);
    }

    private void AnimateScrim(int i, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void AnimateScrim(int i, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void AnimateScrim(int i, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ApStRejXsFUhtNgr(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getWidth();
    }

    public static void ApStRejXsFUhtNgr(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ApStRejXsFUhtNgr(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ApStRejXsFUhtNgr(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AyyFmSlMKpvTrXTs(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setLineSpacingAdd(f);
    }

    public static void AyyFmSlMKpvTrXTs(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, float f2, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AyyFmSlMKpvTrXTs(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, short s, float f2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AyyFmSlMKpvTrXTs(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, short s, bool z, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static int AzqGguMLyFCLWILQ(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void AzqGguMLyFCLWILQ(int i, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AzqGguMLyFCLWILQ(int i, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AzqGguMLyFCLWILQ(int i, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BAbQpvlDijgIamdj(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence) {
        collapsingToolbarLayout.setTitle(charSequence);
    }

    public static void BAbQpvlDijgIamdj(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BAbQpvlDijgIamdj(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BAbQpvlDijgIamdj(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BNWJigndwfFKzHkk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2) {
        collapsingToolbarLayout.updateContentScrimBounds(drawable, view, i, i2);
    }

    public static void BNWJigndwfFKzHkk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2, byte b, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BNWJigndwfFKzHkk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2, char c, int i3, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BNWJigndwfFKzHkk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2, float f, char c, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void BnBVLGTQJiIFAtCs(android.graphics.drawable.Drawable drawable, int i, int i2, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BnBVLGTQJiIFAtCs(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BnBVLGTQJiIFAtCs(android.graphics.drawable.Drawable drawable, int i, short s, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool BnBVLGTQJiIFAtCs(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
    }

    public static void BvVKlXdolPXtGJgq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BvVKlXdolPXtGJgq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BvVKlXdolPXtGJgq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool BvVKlXdolPXtGJgq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.isTitleCollapseFadeMode();
    }

    public static void CKnVskhegCcRyKMT(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void CKnVskhegCcRyKMT(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CKnVskhegCcRyKMT(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CKnVskhegCcRyKMT(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CcXIhobZKhTLzJyi(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void CcXIhobZKhTLzJyi(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CcXIhobZKhTLzJyi(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CcXIhobZKhTLzJyi(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CcpgxWzTUJrrFomk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CcpgxWzTUJrrFomk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CcpgxWzTUJrrFomk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int[] CcpgxWzTUJrrFomk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getDrawableState();
    }

    public static android.graphics.Typeface CejdRpEmxWaKEmHj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getExpandedTypeface();
    }

    public static void CejdRpEmxWaKEmHj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CejdRpEmxWaKEmHj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CejdRpEmxWaKEmHj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private android.text.TextUtils$TruncateAt convertEllipsizeToTruncateAt(int i) {
        return i == 0 ? android.text.TextUtils$TruncateAt.START : i == 1 ? android.text.TextUtils$TruncateAt.MIDDLE : i == 3 ? android.text.TextUtils$TruncateAt.MARQUEE : android.text.TextUtils$TruncateAt.END;
    }

    private void ConvertEllipsizeToTruncateAt(int i, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ConvertEllipsizeToTruncateAt(int i, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ConvertEllipsizeToTruncateAt(int i, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CyxUmHfvQRXlPVIz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setExpandedTextAppearance(i);
    }

    public static void CyxUmHfvQRXlPVIz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, byte b, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CyxUmHfvQRXlPVIz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CyxUmHfvQRXlPVIz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, short s, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CzhempumdoPYCKsc(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void CzhempumdoPYCKsc(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, byte b, int i5, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CzhempumdoPYCKsc(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, char c, byte b, bool z, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void CzhempumdoPYCKsc(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, int i5, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DCpazEiLuanOuOQN(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void DCpazEiLuanOuOQN(android.view.object view, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DCpazEiLuanOuOQN(android.view.object view, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DCpazEiLuanOuOQN(android.view.object view, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DFlaKKvbxrbmOfFS(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static void DFlaKKvbxrbmOfFS(android.view.objectGroup viewGroup, android.view.object view, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DFlaKKvbxrbmOfFS(android.view.objectGroup viewGroup, android.view.object view, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DFlaKKvbxrbmOfFS(android.view.objectGroup viewGroup, android.view.object view, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DHnMgpJGZtypshbm(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DHnMgpJGZtypshbm(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DHnMgpJGZtypshbm(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool DHnMgpJGZtypshbm(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static android.view.objectGroup$LayoutParams dRQPhbKVuqxMHiWm(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void DRQPhbKVuqxMHiWm(android.view.object view, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DRQPhbKVuqxMHiWm(android.view.object view, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DRQPhbKVuqxMHiWm(android.view.object view, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DSavVOcwUGuCdlFp(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static void DSavVOcwUGuCdlFp(android.animation.ValueAnimator valueAnimator, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DSavVOcwUGuCdlFp(android.animation.ValueAnimator valueAnimator, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DSavVOcwUGuCdlFp(android.animation.ValueAnimator valueAnimator, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DTlQYbYewdOzmPkW(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void DTlQYbYewdOzmPkW(android.content.res.TypedArray typedArray, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DTlQYbYewdOzmPkW(android.content.res.TypedArray typedArray, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DTlQYbYewdOzmPkW(android.content.res.TypedArray typedArray, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int DgBhzdktpaLqlpCe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getChildCount();
    }

    public static void DgBhzdktpaLqlpCe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DgBhzdktpaLqlpCe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DgBhzdktpaLqlpCe(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void DisableLiftOnScrollIfNeeded(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        if (zJBQxLoIdIacAPGL(this)) {
            izqVkRwodizuaFAk(appBarLayout, false);
        }
    }

    private void DisableLiftOnScrollIfNeeded(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void DisableLiftOnScrollIfNeeded(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void DisableLiftOnScrollIfNeeded(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DljRRsxWPWwJnqnC(android.graphics.drawable.Drawable drawable, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DljRRsxWPWwJnqnC(android.graphics.drawable.Drawable drawable, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DljRRsxWPWwJnqnC(android.graphics.drawable.Drawable drawable, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DljRRsxWPWwJnqnC(android.graphics.drawable.Drawable drawable) {
        return drawable.isVisible();
    }

    public static void EgjBTtPkSLkWsCyy(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z) {
        collapsingTextHelper.setRtlTextDirectionHeuristicsEnabled(z);
    }

    public static void EgjBTtPkSLkWsCyy(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EgjBTtPkSLkWsCyy(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EgjBTtPkSLkWsCyy(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void EnsureToolbar() {
        if ((3 + 11) % 11 > 0) {
        }
        if (this.refreshToolbar) {
            android.view.objectGroup viewGroup = null;
            this.toolbar = null;
            this.toolbarDirectChild = null;
            int i = this.toolbarId;
            if (i != -1) {
                android.view.objectGroup viewGroup2 = (android.view.objectGroup) umhsmAanMimegVuX(this, i);
                this.toolbar = viewGroup2;
                if (viewGroup2 is not null) {
                    this.toolbarDirectChild = ZyuWmFXtpEoAMmXe(this, viewGroup2);
                }
            }
            if (this.toolbar is null) {
                int iKwgOduMVSLKfopaA = KwgOduMVSLKfopaA(this);
                for (int i2 = 0; i2 < iKwgOduMVSLKfopaA; i2++) {
                    android.view.object viewVaCuERyYuzGLHFiR = vaCuERyYuzGLHFiR(this, i2);
                    if (NHoSsCLCjIlVojGh(viewVaCuERyYuzGLHFiR)) {
                        viewGroup = (android.view.objectGroup) viewVaCuERyYuzGLHFiR;
                        break;
                    }
                }
                this.toolbar = viewGroup;
            }
            tRARpKCykrbWBSnG(this);
            this.refreshToolbar = false;
        }
    }

    private void EnsureToolbar(byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void EnsureToolbar(byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void EnsureToolbar(bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int EppMcDLVvsZtlWWE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getExpandedLineCount();
    }

    public static void EppMcDLVvsZtlWWE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EppMcDLVvsZtlWWE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EppMcDLVvsZtlWWE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float EzTfMPwdZPEWVutx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCollapsedTextSize();
    }

    public static void EzTfMPwdZPEWVutx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EzTfMPwdZPEWVutx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EzTfMPwdZPEWVutx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FMdDtdlTJpmEuzTS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4) {
        collapsingTextHelper.setCollapsedBounds(i, i2, i3, i4);
    }

    public static void FMdDtdlTJpmEuzTS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FMdDtdlTJpmEuzTS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FMdDtdlTJpmEuzTS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, int i3, int i4, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FWmHTzFREUzBodee(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void FWmHTzFREUzBodee(android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FWmHTzFREUzBodee(android.content.res.ColorStateList colorStateList, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FWmHTzFREUzBodee(android.content.res.ColorStateList colorStateList, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FfsBVbjmxqWGdxBq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.requestLayout();
    }

    public static void FfsBVbjmxqWGdxBq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FfsBVbjmxqWGdxBq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FfsBVbjmxqWGdxBq(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private android.view.object FindDirectChild(android.view.object view) {
        if ((14 + 30) % 30 > 0) {
        }
        for (android.view.objectParent viewParentZxdyGoRTEJZqcmql = ZxdyGoRTEJZqcmql(view); viewParentZxdyGoRTEJZqcmql != this && viewParentZxdyGoRTEJZqcmql is not null; viewParentZxdyGoRTEJZqcmql = VUZPRaSARSsERSLC(viewParentZxdyGoRTEJZqcmql)) {
            if (viewParentZxdyGoRTEJZqcmql is android.view.object) {
                view = (android.view.object) viewParentZxdyGoRTEJZqcmql;
            }
        }
        return view;
    }

    private void FindDirectChild(android.view.object view, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void FindDirectChild(android.view.object view, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void FindDirectChild(android.view.object view, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable FizRIOnHamOYaLha(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getDrawable(context, i);
    }

    public static void FizRIOnHamOYaLha(android.content.object context, int i, char c, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FizRIOnHamOYaLha(android.content.object context, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FizRIOnHamOYaLha(android.content.object context, int i, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence FpuezKIaJODRiEyo(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getText();
    }

    public static void FpuezKIaJODRiEyo(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FpuezKIaJODRiEyo(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FpuezKIaJODRiEyo(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FxTimSDNXWNFSRoR(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
    }

    public static void FxTimSDNXWNFSRoR(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, char c, float f, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void FxTimSDNXWNFSRoR(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, int i5, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FxTimSDNXWNFSRoR(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, int i5, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FxxuAVGHNJnkdBSp(android.widget.FrameLayout frameLayout) {
        super.onAttachedToWindow();
    }

    public static void FxxuAVGHNJnkdBSp(android.widget.FrameLayout frameLayout, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FxxuAVGHNJnkdBSp(android.widget.FrameLayout frameLayout, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FxxuAVGHNJnkdBSp(android.widget.FrameLayout frameLayout, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GDmamkvCgMipkyyJ(java.lang.object obj, java.lang.object obj2, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GDmamkvCgMipkyyJ(java.lang.object obj, java.lang.object obj2, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GDmamkvCgMipkyyJ(java.lang.object obj, java.lang.object obj2, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GDmamkvCgMipkyyJ(java.lang.object obj, java.lang.object obj2) {
        return androidx.core.util.objectsCompat.Equals(obj, obj2);
    }

    public static int GIgWAxAHXuRKqeht(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void GIgWAxAHXuRKqeht(android.content.res.TypedArray typedArray, int i, int i2, byte b, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GIgWAxAHXuRKqeht(android.content.res.TypedArray typedArray, int i, int i2, byte b, bool z, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void GIgWAxAHXuRKqeht(android.content.res.TypedArray typedArray, int i, int i2, int i3, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GMuGXsurjObGAohm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setExpandedTextGravity(i);
    }

    public static void GMuGXsurjObGAohm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GMuGXsurjObGAohm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GMuGXsurjObGAohm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GeUjTcnXkiQLoToB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z) {
        collapsingToolbarLayout.setWillNotDraw(z);
    }

    public static void GeUjTcnXkiQLoToB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, float f, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GeUjTcnXkiQLoToB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, bool z2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GeUjTcnXkiQLoToB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, bool z2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private int GetDefaultContentScrimColorForTitleCollapseFadeMode() {
        if ((24 + 27) % 27 > 0) {
        }
        android.content.res.ColorStateList colorStateListFykeGBAkuzJYwHSU = FykeGBAkuzJYwHSU(yCQvidLPqPTazusQ(this), com.google.android.material.R$attr.colorSurfaceContainer);
        if (colorStateListFykeGBAkuzJYwHSU is not null) {
            return fWmHTzFREUzBodee(colorStateListFykeGBAkuzJYwHSU);
        }
        return qlFnXoxiaarfBDwL(this.elevationOverlayProvider, lnGGQxmfHSGflldN(VZNEeaPMuvMLryps(this), com.google.android.material.R$dimen.design_appbar_elevation));
    }

    private void GetDefaultContentScrimColorForTitleCollapseFadeMode(byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetDefaultContentScrimColorForTitleCollapseFadeMode(byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetDefaultContentScrimColorForTitleCollapseFadeMode(bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private static int GetHeightWithMargins(android.view.object view) {
        if ((18 + 16) % 16 > 0) {
        }
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsDRQPhbKVuqxMHiWm = dRQPhbKVuqxMHiWm(view);
        if (!(viewGroup$LayoutParamsDRQPhbKVuqxMHiWm is android.view.objectGroup$MarginLayoutParams)) {
            return BwNuXWKodWgsmiWY(view);
        }
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParamsDRQPhbKVuqxMHiWm;
        return ElyfWdvarLrbQZrD(view) + viewGroup$MarginLayoutParams.topMargin + viewGroup$MarginLayoutParams.bottomMargin;
    }

    private static void GetHeightWithMargins(android.view.object view, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void GetHeightWithMargins(android.view.object view, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void GetHeightWithMargins(android.view.object view, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static java.lang.CharSequence GetToolbarTitle(android.view.object view) {
        if (view is androidx.appcompat.widget.Toolbar) {
            return HntkLcnEtATbZHhh((androidx.appcompat.widget.Toolbar) view);
        }
        if (view is android.widget.Toolbar) {
            return JCSKxYHMCozyKNyO((android.widget.Toolbar) view);
        }
        return null;
    }

    private static void GetToolbarTitle(android.view.object view, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void GetToolbarTitle(android.view.object view, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private static void GetToolbarTitle(android.view.object view, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.appbar.objectOffsetHelper GetobjectOffsetHelper(android.view.object view) {
        if ((32 + 29) % 29 > 0) {
        }
        com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper = (com.google.android.material.appbar.objectOffsetHelper) vPZepbBzIhSyfucw(view, com.google.android.material.R$id.view_offset_helper);
        if (viewOffsetHelper is null) {
            viewOffsetHelper = new com.google.android.material.appbar.objectOffsetHelper(view);
            VdgTZDXbxDCFfhqm(view, com.google.android.material.R$id.view_offset_helper, viewOffsetHelper);
        }
        return viewOffsetHelper;
    }

    static void GetobjectOffsetHelper(android.view.object view, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static void GetobjectOffsetHelper(android.view.object view, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void GetobjectOffsetHelper(android.view.object view, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int GlcZvYdaxwJhAuFj(android.view.object view) {
        return view.getTop();
    }

    public static void GlcZvYdaxwJhAuFj(android.view.object view, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GlcZvYdaxwJhAuFj(android.view.object view, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GlcZvYdaxwJhAuFj(android.view.object view, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float HLwnCAYBHQRflAtn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getExpansionFraction();
    }

    public static void HLwnCAYBHQRflAtn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HLwnCAYBHQRflAtn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HLwnCAYBHQRflAtn(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HRZlaZOnkYiUIeWv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2) {
        collapsingToolbarLayout.updateContentScrimBounds(drawable, view, i, i2);
    }

    public static void HRZlaZOnkYiUIeWv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HRZlaZOnkYiUIeWv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HRZlaZOnkYiUIeWv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HixKCevQsKuCyfZS(android.content.res.TypedArray typedArray, int i, float f, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HixKCevQsKuCyfZS(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HixKCevQsKuCyfZS(android.content.res.TypedArray typedArray, int i, bool z, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool HixKCevQsKuCyfZS(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int HmCXKMURYnTgISLY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getMeasuredHeight();
    }

    public static void HmCXKMURYnTgISLY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HmCXKMURYnTgISLY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HmCXKMURYnTgISLY(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IJXUdECusoXpMwbO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z) {
        collapsingToolbarLayout.updateCollapsedBounds(z);
    }

    public static void IJXUdECusoXpMwbO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IJXUdECusoXpMwbO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IJXUdECusoXpMwbO(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IRJSSukBpupYwjbZ(android.graphics.drawable.Drawable drawable, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IRJSSukBpupYwjbZ(android.graphics.drawable.Drawable drawable, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IRJSSukBpupYwjbZ(android.graphics.drawable.Drawable drawable, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IRJSSukBpupYwjbZ(android.graphics.drawable.Drawable drawable) {
        return drawable.isVisible();
    }

    public static void IhVYJnxvqYKvbZlE(android.widget.FrameLayout frameLayout, int i) {
        super.setVisibility(i);
    }

    public static void IhVYJnxvqYKvbZlE(android.widget.FrameLayout frameLayout, int i, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IhVYJnxvqYKvbZlE(android.widget.FrameLayout frameLayout, int i, byte b, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IhVYJnxvqYKvbZlE(android.widget.FrameLayout frameLayout, int i, float f, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IsEZxjfcTtpbVazx(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.requestLayout();
    }

    public static void IsEZxjfcTtpbVazx(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IsEZxjfcTtpbVazx(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IsEZxjfcTtpbVazx(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsTitleCollapseFadeMode(char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsTitleCollapseFadeMode(java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsTitleCollapseFadeMode(short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private bool IsTitleCollapseFadeMode() {
        return this.titleCollapseMode == 1;
    }

    private static void IsToolbar(android.view.object view, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private static void IsToolbar(android.view.object view, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private static void IsToolbar(android.view.object view, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private static bool IsToolbar(android.view.object view) {
        return (view is androidx.appcompat.widget.Toolbar) || (view is android.widget.Toolbar);
    }

    private void IsToolbarChild(android.view.object view, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsToolbarChild(android.view.object view, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsToolbarChild(android.view.object view, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private bool IsToolbarChild(android.view.object view) {
        if ((22 + 1) % 1 > 0) {
        }
        android.view.object view2 = this.toolbarDirectChild;
        return (view2 is null || view2 == this) ? view == this.toolbar : view == view2;
    }

    public static int ItegtJtkIazbRMfG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getHeight();
    }

    public static void ItegtJtkIazbRMfG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ItegtJtkIazbRMfG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ItegtJtkIazbRMfG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IzqVkRwodizuaFAk(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        appBarLayout.setLiftOnScroll(z);
    }

    public static void IzqVkRwodizuaFAk(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IzqVkRwodizuaFAk(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IzqVkRwodizuaFAk(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JBEkqpXNETZRbTcw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setCollapsedTextGravity(i);
    }

    public static void JBEkqpXNETZRbTcw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JBEkqpXNETZRbTcw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, char c, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JBEkqpXNETZRbTcw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JQKmorfeNAfhBxFw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable) {
        collapsingToolbarLayout.setStatusBarScrim(drawable);
    }

    public static void JQKmorfeNAfhBxFw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JQKmorfeNAfhBxFw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JQKmorfeNAfhBxFw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int JzZLjluczfWaXTad(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void JzZLjluczfWaXTad(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JzZLjluczfWaXTad(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JzZLjluczfWaXTad(android.content.res.TypedArray typedArray, int i, int i2, short s, int i3, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KKIcOQJkAJpiIcwl(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator) {
        collapsingTextHelper.setPositionInterpolator(timeInterpolator);
    }

    public static void KKIcOQJkAJpiIcwl(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KKIcOQJkAJpiIcwl(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KKIcOQJkAJpiIcwl(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KPqvKqPHvxyITJhk(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void KPqvKqPHvxyITJhk(android.content.res.TypedArray typedArray, int i, int i2, int i3, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KPqvKqPHvxyITJhk(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, int i3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPqvKqPHvxyITJhk(android.content.res.TypedArray typedArray, int i, int i2, bool z, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object KxILcOcWYEfLhCew(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getobject();
    }

    public static void KxILcOcWYEfLhCew(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KxILcOcWYEfLhCew(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KxILcOcWYEfLhCew(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.FrameLayout$LayoutParams lJPZQkivXOwFFecE(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.util.AttributeHashSet attributeHashSet) {
        return collapsingToolbarLayout.generateLayoutParams(attributeHashSet);
    }

    public static void LJPZQkivXOwFFecE(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.util.AttributeHashSet attributeHashSet, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LJPZQkivXOwFFecE(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.util.AttributeHashSet attributeHashSet, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LJPZQkivXOwFFecE(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.util.AttributeHashSet attributeHashSet, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence LJfnPAMEmxTDZoag(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getText();
    }

    public static void LJfnPAMEmxTDZoag(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LJfnPAMEmxTDZoag(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LJfnPAMEmxTDZoag(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray LTwsvBLnloSYIBJf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void LTwsvBLnloSYIBJf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LTwsvBLnloSYIBJf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, char c, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LTwsvBLnloSYIBJf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, int i3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LWLCBOyPntdTEMMt(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getMeasuredHeight();
    }

    public static void LWLCBOyPntdTEMMt(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LWLCBOyPntdTEMMt(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LWLCBOyPntdTEMMt(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LXRLusalaKcPVZhU(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.ensureToolbar();
    }

    public static void LXRLusalaKcPVZhU(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXRLusalaKcPVZhU(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXRLusalaKcPVZhU(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent LdLQkFOWhGCkqHxG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getParent();
    }

    public static void LdLQkFOWhGCkqHxG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LdLQkFOWhGCkqHxG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LdLQkFOWhGCkqHxG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LeXbxtjisKfkYBlJ(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static void LeXbxtjisKfkYBlJ(androidx.core.view.WindowInsetsCompat windowInsetsCompat, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LeXbxtjisKfkYBlJ(androidx.core.view.WindowInsetsCompat windowInsetsCompat, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LeXbxtjisKfkYBlJ(androidx.core.view.WindowInsetsCompat windowInsetsCompat, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static float LnGGQxmfHSGflldN(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void LnGGQxmfHSGflldN(android.content.res.Resources resources, int i, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LnGGQxmfHSGflldN(android.content.res.Resources resources, int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LnGGQxmfHSGflldN(android.content.res.Resources resources, int i, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MCQAelqoHnGOXSNz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setMaxLines(i);
    }

    public static void MCQAelqoHnGOXSNz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MCQAelqoHnGOXSNz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, java.lang.string str, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MCQAelqoHnGOXSNz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, java.lang.string str, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MNrjuwFsSqPbUGsQ(android.widget.FrameLayout frameLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void MNrjuwFsSqPbUGsQ(android.widget.FrameLayout frameLayout, int i, int i2, short s, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MNrjuwFsSqPbUGsQ(android.widget.FrameLayout frameLayout, int i, int i2, short s, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MNrjuwFsSqPbUGsQ(android.widget.FrameLayout frameLayout, int i, int i2, bool z, int i3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MclkgEXEkfXUqodu(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Region$Op region$Op, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MclkgEXEkfXUqodu(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Region$Op region$Op, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MclkgEXEkfXUqodu(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Region$Op region$Op, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool MclkgEXEkfXUqodu(android.graphics.Canvas canvas, android.graphics.Rect rect, android.graphics.Region$Op region$Op) {
        return canvas.clipRect(rect, region$Op);
    }

    public static void MrErbjYdfGGtURXv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.updateScrimVisibility();
    }

    public static void MrErbjYdfGGtURXv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MrErbjYdfGGtURXv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MrErbjYdfGGtURXv(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextUtils$TruncateAt nIImMsrarRqjMZfI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        return collapsingToolbarLayout.convertEllipsizeToTruncateAt(i);
    }

    public static void NIImMsrarRqjMZfI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NIImMsrarRqjMZfI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NIImMsrarRqjMZfI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NIOLErEQbwzfrojd(android.graphics.drawable.Drawable drawable, bool z, bool z2, float f, bool z3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NIOLErEQbwzfrojd(android.graphics.drawable.Drawable drawable, bool z, bool z2, java.lang.string str, short s, bool z3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NIOLErEQbwzfrojd(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, bool z3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NIOLErEQbwzfrojd(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void NMKaeboMYxyoktif(android.view.objectGroup viewGroup, android.view.object view, int i, int i2) {
        viewGroup.addobject(view, i, i2);
    }

    public static void NMKaeboMYxyoktif(android.view.objectGroup viewGroup, android.view.object view, int i, int i2, byte b, int i3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NMKaeboMYxyoktif(android.view.objectGroup viewGroup, android.view.object view, int i, int i2, byte b, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NMKaeboMYxyoktif(android.view.objectGroup viewGroup, android.view.object view, int i, int i2, char c, int i3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NOnIBfXOMgRVnzzK(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void NOnIBfXOMgRVnzzK(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NOnIBfXOMgRVnzzK(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NOnIBfXOMgRVnzzK(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NbCXtokFIuXNAamn(android.widget.Toolbar toolbar) {
        return toolbar.getTitleMarginStart();
    }

    public static void NbCXtokFIuXNAamn(android.widget.Toolbar toolbar, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NbCXtokFIuXNAamn(android.widget.Toolbar toolbar, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NbCXtokFIuXNAamn(android.widget.Toolbar toolbar, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int NgfdVJbuEyUQOkpL(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void NgfdVJbuEyUQOkpL(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NgfdVJbuEyUQOkpL(android.content.res.TypedArray typedArray, int i, int i2, float f, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NgfdVJbuEyUQOkpL(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, int i3, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NkMshJHlbhtpCUpk(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NkMshJHlbhtpCUpk(android.content.res.TypedArray typedArray, int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NkMshJHlbhtpCUpk(android.content.res.TypedArray typedArray, int i, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NkMshJHlbhtpCUpk(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static float NkeBqMHkJKAXPEDU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getLineSpacingAdd();
    }

    public static void NkeBqMHkJKAXPEDU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NkeBqMHkJKAXPEDU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NkeBqMHkJKAXPEDU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NrdcOpvRrtyGybbU(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence) {
        collapsingToolbarLayout.setContentDescription(charSequence);
    }

    public static void NrdcOpvRrtyGybbU(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NrdcOpvRrtyGybbU(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NrdcOpvRrtyGybbU(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.CharSequence charSequence, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NsjgjohGwCowhQlP(android.graphics.drawable.Drawable drawable, bool z, bool z2, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NsjgjohGwCowhQlP(android.graphics.drawable.Drawable drawable, bool z, bool z2, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NsjgjohGwCowhQlP(android.graphics.drawable.Drawable drawable, bool z, bool z2, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NsjgjohGwCowhQlP(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void OANtQxjZnHUxvDnN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        collapsingTextHelper.setTitleTextEllipsize(textUtils$TruncateAt);
    }

    public static void OANtQxjZnHUxvDnN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextUtils$TruncateAt textUtils$TruncateAt, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OANtQxjZnHUxvDnN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextUtils$TruncateAt textUtils$TruncateAt, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OANtQxjZnHUxvDnN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.text.TextUtils$TruncateAt textUtils$TruncateAt, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OAoMWPqxaRBHXyNx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void OAoMWPqxaRBHXyNx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OAoMWPqxaRBHXyNx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OAoMWPqxaRBHXyNx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OOdtFAQeqmiVqyQu(android.content.res.TypedArray typedArray, int i, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OOdtFAQeqmiVqyQu(android.content.res.TypedArray typedArray, int i, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OOdtFAQeqmiVqyQu(android.content.res.TypedArray typedArray, int i, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool OOdtFAQeqmiVqyQu(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void OpTjkDmRBBGzUsqO(android.widget.FrameLayout frameLayout, android.content.res.Configuration configuration) {
        super.onConfigurationChanged(configuration);
    }

    public static void OpTjkDmRBBGzUsqO(android.widget.FrameLayout frameLayout, android.content.res.Configuration configuration, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OpTjkDmRBBGzUsqO(android.widget.FrameLayout frameLayout, android.content.res.Configuration configuration, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OpTjkDmRBBGzUsqO(android.widget.FrameLayout frameLayout, android.content.res.Configuration configuration, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OqKBLvboAhFtFvQI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.invalidate();
    }

    public static void OqKBLvboAhFtFvQI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OqKBLvboAhFtFvQI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OqKBLvboAhFtFvQI(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OzOoaTtPoYAguEWH(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void OzOoaTtPoYAguEWH(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OzOoaTtPoYAguEWH(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OzOoaTtPoYAguEWH(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PPJuXPgwaYLDEZmB(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void PPJuXPgwaYLDEZmB(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PPJuXPgwaYLDEZmB(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PPJuXPgwaYLDEZmB(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PknOsVWytZbsjobc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setExpandedTextAppearance(i);
    }

    public static void PknOsVWytZbsjobc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PknOsVWytZbsjobc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, bool z, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PknOsVWytZbsjobc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QLmuBHwGlUEMWlhw(android.content.res.TypedArray typedArray, int i, bool z, float f, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QLmuBHwGlUEMWlhw(android.content.res.TypedArray typedArray, int i, bool z, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QLmuBHwGlUEMWlhw(android.content.res.TypedArray typedArray, int i, bool z, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QLmuBHwGlUEMWlhw(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int QVDuwhlAKLuoRPpQ(android.widget.Toolbar toolbar) {
        return toolbar.getTitleMarginBottom();
    }

    public static void QVDuwhlAKLuoRPpQ(android.widget.Toolbar toolbar, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QVDuwhlAKLuoRPpQ(android.widget.Toolbar toolbar, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QVDuwhlAKLuoRPpQ(android.widget.Toolbar toolbar, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList QYICCaUnfZGiHNUY(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void QYICCaUnfZGiHNUY(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QYICCaUnfZGiHNUY(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QYICCaUnfZGiHNUY(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int QlFnXoxiaarfBDwL(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, float f) {
        return elevationOverlayProvider.compositeOverlayWithThemeSurfaceColorIfNeeded(f);
    }

    public static void QlFnXoxiaarfBDwL(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, float f, byte b, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void QlFnXoxiaarfBDwL(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, float f, byte b, float f2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QlFnXoxiaarfBDwL(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, float f, byte b, java.lang.string str, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int QrPgBxIBvyrvEJZi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getExpandedTextGravity();
    }

    public static void QrPgBxIBvyrvEJZi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QrPgBxIBvyrvEJZi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QrPgBxIBvyrvEJZi(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RDmnZVXbsgFFRiTX(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void RDmnZVXbsgFFRiTX(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RDmnZVXbsgFFRiTX(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RDmnZVXbsgFFRiTX(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RNvwuxeNJmKtIcbZ(android.content.res.TypedArray typedArray, int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RNvwuxeNJmKtIcbZ(android.content.res.TypedArray typedArray, int i, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RNvwuxeNJmKtIcbZ(android.content.res.TypedArray typedArray, int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RNvwuxeNJmKtIcbZ(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int RPSbNvcHHRvqthXF(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void RPSbNvcHHRvqthXF(int i, int i2, byte b, bool z, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RPSbNvcHHRvqthXF(int i, int i2, int i3, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RPSbNvcHHRvqthXF(int i, int i2, java.lang.string str, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RTGZlwivYEpOMJjk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getScrimVisibleHeightTrigger();
    }

    public static void RTGZlwivYEpOMJjk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RTGZlwivYEpOMJjk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RTGZlwivYEpOMJjk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int RwKUpyxWyXOflOLP(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void RwKUpyxWyXOflOLP(android.content.res.TypedArray typedArray, int i, int i2, int i3, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RwKUpyxWyXOflOLP(android.content.res.TypedArray typedArray, int i, int i2, int i3, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RwKUpyxWyXOflOLP(android.content.res.TypedArray typedArray, int i, int i2, short s, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int SCicHcqLfZrBzABq(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void SCicHcqLfZrBzABq(android.content.res.TypedArray typedArray, int i, int i2, byte b, short s, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SCicHcqLfZrBzABq(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, byte b, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCicHcqLfZrBzABq(android.content.res.TypedArray typedArray, int i, int i2, short s, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator SNqLSyTLWXEUMAwX(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void SNqLSyTLWXEUMAwX(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SNqLSyTLWXEUMAwX(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, char c, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SNqLSyTLWXEUMAwX(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, int i2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence SRBFuSVSFmLyOaij(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getTitle();
    }

    public static void SRBFuSVSFmLyOaij(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SRBFuSVSFmLyOaij(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SRBFuSVSFmLyOaij(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SsAUUXczovricwvk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view) {
        return collapsingToolbarLayout.getMaxOffsetForPinChild(view);
    }

    public static void SsAUUXczovricwvk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SsAUUXczovricwvk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SsAUUXczovricwvk(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.view.object view, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SvvPNfuuQZNRrhcQ(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SvvPNfuuQZNRrhcQ(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SvvPNfuuQZNRrhcQ(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool SvvPNfuuQZNRrhcQ(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.isTitleCollapseFadeMode();
    }

    public static void TFCBEgspHzFwnsPV(android.view.object view, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TFCBEgspHzFwnsPV(android.view.object view, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TFCBEgspHzFwnsPV(android.view.object view, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TFCBEgspHzFwnsPV(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static void TRARpKCykrbWBSnG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.updateDummyobject();
    }

    public static void TRARpKCykrbWBSnG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TRARpKCykrbWBSnG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TRARpKCykrbWBSnG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TpiXvkFsHPyAllKi(android.graphics.drawable.Drawable drawable, int i) {
        drawable.setAlpha(i);
    }

    public static void TpiXvkFsHPyAllKi(android.graphics.drawable.Drawable drawable, int i, char c, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TpiXvkFsHPyAllKi(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TpiXvkFsHPyAllKi(android.graphics.drawable.Drawable drawable, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UAuorryRkyGBRXbf(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        collapsingTextHelper.setCollapsedTextColor(colorStateList);
    }

    public static void UAuorryRkyGBRXbf(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UAuorryRkyGBRXbf(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UAuorryRkyGBRXbf(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UFwPTAgxSoeLZRHI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator) {
        collapsingTextHelper.setPositionInterpolator(timeInterpolator);
    }

    public static void UFwPTAgxSoeLZRHI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UFwPTAgxSoeLZRHI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UFwPTAgxSoeLZRHI(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object UIYOCJWivXEFFTje(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        return collapsingToolbarLayout.getChildAt(i);
    }

    public static void UIYOCJWivXEFFTje(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UIYOCJWivXEFFTje(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UIYOCJWivXEFFTje(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UZrCqDClzBFmagYq(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void UZrCqDClzBFmagYq(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UZrCqDClzBFmagYq(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UZrCqDClzBFmagYq(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator UbpXEQsdkzWmzLeY(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getPositionInterpolator();
    }

    public static void UbpXEQsdkzWmzLeY(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UbpXEQsdkzWmzLeY(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UbpXEQsdkzWmzLeY(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UkkhFLHammGPrnWG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable) {
        collapsingToolbarLayout.setStatusBarScrim(drawable);
    }

    public static void UkkhFLHammGPrnWG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UkkhFLHammGPrnWG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UkkhFLHammGPrnWG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UmbzDmnfIPklVRHN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getHeight();
    }

    public static void UmbzDmnfIPklVRHN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UmbzDmnfIPklVRHN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UmbzDmnfIPklVRHN(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object UmhsmAanMimegVuX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        return collapsingToolbarLayout.findobjectById(i);
    }

    public static void UmhsmAanMimegVuX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, char c, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UmhsmAanMimegVuX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, char c, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UmhsmAanMimegVuX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, bool z, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCollapsedBounds(bool z) {
        int iXePOiEAjmxcOjhpn;
        int iQIuSdAFThtqrnyIw;
        int iHQVXtismGGVTaMwL;
        int iLvVKOrYqujOkPClp;
        if ((16 + 15) % 15 > 0) {
        }
        android.view.object view = this.toolbarDirectChild;
        if (view is null) {
            view = this.toolbar;
        }
        int iSsAUUXczovricwvk = ssAUUXczovricwvk(this, view);
        vkDzvvaWfLtLkjKR(this, this.dummyobject, this.tmpRect);
        android.view.objectGroup viewGroup = this.toolbar;
        if (viewGroup is androidx.appcompat.widget.Toolbar) {
            androidx.appcompat.widget.Toolbar toolbar = (androidx.appcompat.widget.Toolbar) viewGroup;
            iXePOiEAjmxcOjhpn = xePOiEAjmxcOjhpn(toolbar);
            iQIuSdAFThtqrnyIw = QIuSdAFThtqrnyIw(toolbar);
            iHQVXtismGGVTaMwL = HQVXtismGGVTaMwL(toolbar);
            iLvVKOrYqujOkPClp = LvVKOrYqujOkPClp(toolbar);
        } else {
            android.view.objectGroup viewGroup2 = this.toolbar;
            if (viewGroup2 is android.widget.Toolbar) {
                android.widget.Toolbar toolbar2 = (android.widget.Toolbar) viewGroup2;
                iXePOiEAjmxcOjhpn = nbCXtokFIuXNAamn(toolbar2);
                iQIuSdAFThtqrnyIw = xKrTPhUATXelMElV(toolbar2);
                iHQVXtismGGVTaMwL = LFBqklCPaGGibFnG(toolbar2);
                iLvVKOrYqujOkPClp = qVDuwhlAKLuoRPpQ(toolbar2);
            } else {
                iXePOiEAjmxcOjhpn = 0;
                iLvVKOrYqujOkPClp = 0;
                iQIuSdAFThtqrnyIw = 0;
                iHQVXtismGGVTaMwL = 0;
            }
        }
        com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper = this.collapsingTextHelper;
        int i = this.tmpRect.left + (!z ? iXePOiEAjmxcOjhpn : iQIuSdAFThtqrnyIw);
        int i2 = this.tmpRect.top + iSsAUUXczovricwvk + iHQVXtismGGVTaMwL;
        int i3 = this.tmpRect.right;
        if (!z) {
            iXePOiEAjmxcOjhpn = iQIuSdAFThtqrnyIw;
        }
        fMdDtdlTJpmEuzTS(collapsingTextHelper, i, i2, i3 - iXePOiEAjmxcOjhpn, (this.tmpRect.bottom + iSsAUUXczovricwvk) - iLvVKOrYqujOkPClp);
    }

    private void UpdateCollapsedBounds(bool z, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCollapsedBounds(bool z, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCollapsedBounds(bool z, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateContentDescriptionFromTitle() {
        nrdcOpvRrtyGybbU(this, sRBFuSVSFmLyOaij(this));
    }

    private void UpdateContentDescriptionFromTitle(char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateContentDescriptionFromTitle(int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateContentDescriptionFromTitle(int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateContentScrimBounds(android.graphics.drawable.Drawable drawable, int i, int i2) {
        bNWJigndwfFKzHkk(this, drawable, this.toolbar, i, i2);
    }

    private void UpdateContentScrimBounds(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateContentScrimBounds(android.graphics.drawable.Drawable drawable, int i, int i2, bool z, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateContentScrimBounds(android.graphics.drawable.Drawable drawable, int i, int i2, bool z, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateContentScrimBounds(android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2) {
        if (svvPNfuuQZNRrhcQ(this) && view is not null && this.collapsingTitleEnabled) {
            i2 = TYXgLdzBZfWNaqhN(view);
        }
        czhempumdoPYCKsc(drawable, 0, 0, i, i2);
    }

    private void UpdateContentScrimBounds(android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateContentScrimBounds(android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateContentScrimBounds(android.graphics.drawable.Drawable drawable, android.view.object view, int i, int i2, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateDummyobject() {
        android.view.object view;
        if ((15 + 9) % 9 > 0) {
        }
        if (!this.collapsingTitleEnabled && (view = this.dummyobject) is not null) {
            android.view.objectParent viewParentXWQJqpqFXzBqONVe = XWQJqpqFXzBqONVe(view);
            if (viewParentXWQJqpqFXzBqONVe is android.view.objectGroup) {
                dFlaKKvbxrbmOfFS((android.view.objectGroup) viewParentXWQJqpqFXzBqONVe, this.dummyobject);
            }
        }
        if (this.collapsingTitleEnabled && this.toolbar is not null) {
            if (this.dummyobject is null) {
                this.dummyobject = new android.view.object(WxOnCsxwsxwIHNyK(this));
            }
            if (wycHeIAZwDiLQqUq(this.dummyobject) is not null) {
                return;
            }
            nMKaeboMYxyoktif(this.toolbar, this.dummyobject, -1, -1);
        }
    }

    private void UpdateDummyobject(byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateDummyobject(char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateDummyobject(float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTextBounds(int i, int i2, int i3, int i4, bool z) {
        android.view.object view;
        if ((4 + 6) % 6 > 0) {
        }
        if (this.collapsingTitleEnabled && (view = this.dummyobject) is not null) {
            bool z2 = ZlOwAmKhuDJRDEvn(view) && UHMEnHZrjIIacdLS(this.dummyobject) == 0;
            this.drawCollapsingTitle = z2;
            if (z2 || z) {
                bool z3 = dCpazEiLuanOuOQN(this) == 1;
                iJXUdECusoXpMwbO(this, z3);
                CjiEhUocSVuhVyhw(this.collapsingTextHelper, !z3 ? this.expandedMarginStart : this.expandedMarginEnd, this.tmpRect.top + this.expandedMarginTop, (i3 - i) - (!z3 ? this.expandedMarginEnd : this.expandedMarginStart), (i4 - i2) - this.expandedMarginBottom);
                yuPCxcbaNGUoheEc(this.collapsingTextHelper, z);
            }
        }
    }

    private void UpdateTextBounds(int i, int i2, int i3, int i4, bool z, byte b, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTextBounds(int i, int i2, int i3, int i4, bool z, float f, bool z2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTextBounds(int i, int i2, int i3, int i4, bool z, float f, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTitleFromToolbarIfNeeded() {
        if (this.toolbar is not null && this.collapsingTitleEnabled && xGMYEpfDapclpobK(fpuezKIaJODRiEyo(this.collapsingTextHelper))) {
            bAbQpvlDijgIamdj(this, GlljaKLncpRAVBbN(this.toolbar));
        }
    }

    private void UpdateTitleFromToolbarIfNeeded(char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTitleFromToolbarIfNeeded(bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTitleFromToolbarIfNeeded(bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UwMZpwqovTfgRTYG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        collapsingToolbarLayout.setTitleEllipsize(textUtils$TruncateAt);
    }

    public static void UwMZpwqovTfgRTYG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.text.TextUtils$TruncateAt textUtils$TruncateAt, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UwMZpwqovTfgRTYG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.text.TextUtils$TruncateAt textUtils$TruncateAt, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UwMZpwqovTfgRTYG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.text.TextUtils$TruncateAt textUtils$TruncateAt, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int UwtPzoorsXTMdXFR(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void UwtPzoorsXTMdXFR(android.view.object view, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UwtPzoorsXTMdXFR(android.view.object view, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UwtPzoorsXTMdXFR(android.view.object view, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int UyjHbvWhwvpoUazG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getMeasuredWidth();
    }

    public static void UyjHbvWhwvpoUazG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UyjHbvWhwvpoUazG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UyjHbvWhwvpoUazG(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VPZepbBzIhSyfucw(android.view.object view, int i) {
        return view.getTag(i);
    }

    public static void VPZepbBzIhSyfucw(android.view.object view, int i, byte b, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VPZepbBzIhSyfucw(android.view.object view, int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VPZepbBzIhSyfucw(android.view.object view, int i, short s, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.appbar.objectOffsetHelper VSHmtsZNwsEVMCwW(android.view.object view) {
        return getobjectOffsetHelper(view);
    }

    public static void VSHmtsZNwsEVMCwW(android.view.object view, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VSHmtsZNwsEVMCwW(android.view.object view, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VSHmtsZNwsEVMCwW(android.view.object view, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object VVbQqXyEFrHGRUKB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getobject();
    }

    public static void VVbQqXyEFrHGRUKB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VVbQqXyEFrHGRUKB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VVbQqXyEFrHGRUKB(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextUtils$TruncateAt vWjPcLPtVhEdAqZN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getTitleTextEllipsize();
    }

    public static void VWjPcLPtVhEdAqZN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VWjPcLPtVhEdAqZN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VWjPcLPtVhEdAqZN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object VaCuERyYuzGLHFiR(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        return collapsingToolbarLayout.getChildAt(i);
    }

    public static void VaCuERyYuzGLHFiR(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VaCuERyYuzGLHFiR(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VaCuERyYuzGLHFiR(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int VewkWzZnSwHCiGtw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCollapsedTextGravity();
    }

    public static void VewkWzZnSwHCiGtw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VewkWzZnSwHCiGtw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VewkWzZnSwHCiGtw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VkDzvvaWfLtLkjKR(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect) {
        com.google.android.material.internal.DescendantOffsetUtils.getDescendantRect(viewGroup, view, rect);
    }

    public static void VkDzvvaWfLtLkjKR(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VkDzvvaWfLtLkjKR(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VkDzvvaWfLtLkjKR(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VreVoYKECGwmGFbM(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, int i3, int i4, bool z) {
        collapsingToolbarLayout.updateTextBounds(i, i2, i3, i4, z);
    }

    public static void VreVoYKECGwmGFbM(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, int i3, int i4, bool z, char c, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VreVoYKECGwmGFbM(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, int i3, int i4, bool z, char c, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void VreVoYKECGwmGFbM(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, int i3, int i4, bool z, bool z2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable WEJNeaVLqgiejbGu(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void WEJNeaVLqgiejbGu(android.graphics.drawable.Drawable drawable, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WEJNeaVLqgiejbGu(android.graphics.drawable.Drawable drawable, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WEJNeaVLqgiejbGu(android.graphics.drawable.Drawable drawable, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int WYZOgaEziFlHWPaX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getWidth();
    }

    public static void WYZOgaEziFlHWPaX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WYZOgaEziFlHWPaX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WYZOgaEziFlHWPaX(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WawDzsHOTsYgOFFV(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, android.view.object view, long j, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WawDzsHOTsYgOFFV(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, android.view.object view, long j, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WawDzsHOTsYgOFFV(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, android.view.object view, long j, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WawDzsHOTsYgOFFV(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, android.view.object view, long j) {
        return super.drawChild(canvas, view, j);
    }

    public static void WliaMlNtPOrJbJry(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.updateDummyobject();
    }

    public static void WliaMlNtPOrJbJry(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WliaMlNtPOrJbJry(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WliaMlNtPOrJbJry(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WtedyIUAontVcnWC(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WtedyIUAontVcnWC(android.graphics.drawable.Drawable drawable, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WtedyIUAontVcnWC(android.graphics.drawable.Drawable drawable, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WtedyIUAontVcnWC(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static void WtiRTRqgtRybXoDn(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void WtiRTRqgtRybXoDn(android.view.object view, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WtiRTRqgtRybXoDn(android.view.object view, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WtiRTRqgtRybXoDn(android.view.object view, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WyYnHzDVnUjhRJMj(android.content.res.TypedArray typedArray, int i, float f, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WyYnHzDVnUjhRJMj(android.content.res.TypedArray typedArray, int i, float f, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WyYnHzDVnUjhRJMj(android.content.res.TypedArray typedArray, int i, bool z, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WyYnHzDVnUjhRJMj(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.view.objectParent WycHeIAZwDiLQqUq(android.view.object view) {
        return view.getParent();
    }

    public static void WycHeIAZwDiLQqUq(android.view.object view, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WycHeIAZwDiLQqUq(android.view.object view, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WycHeIAZwDiLQqUq(android.view.object view, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WzEXVeGIUhjwmePH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getHeight();
    }

    public static void WzEXVeGIUhjwmePH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WzEXVeGIUhjwmePH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WzEXVeGIUhjwmePH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XGMYEpfDapclpobK(java.lang.CharSequence charSequence, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XGMYEpfDapclpobK(java.lang.CharSequence charSequence, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XGMYEpfDapclpobK(java.lang.CharSequence charSequence, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool XGMYEpfDapclpobK(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int XKrTPhUATXelMElV(android.widget.Toolbar toolbar) {
        return toolbar.getTitleMarginEnd();
    }

    public static void XKrTPhUATXelMElV(android.widget.Toolbar toolbar, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XKrTPhUATXelMElV(android.widget.Toolbar toolbar, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XKrTPhUATXelMElV(android.widget.Toolbar toolbar, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XXmYOlhNgGyKtzCx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z) {
        collapsingTextHelper.setFadeModeEnabled(z);
    }

    public static void XXmYOlhNgGyKtzCx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XXmYOlhNgGyKtzCx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XXmYOlhNgGyKtzCx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XZlrcQLLblKgYYpS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setHyphenationFrequency(i);
    }

    public static void XZlrcQLLblKgYYpS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XZlrcQLLblKgYYpS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XZlrcQLLblKgYYpS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, java.lang.string str, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int XePOiEAjmxcOjhpn(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getTitleMarginStart();
    }

    public static void XePOiEAjmxcOjhpn(androidx.appcompat.widget.Toolbar toolbar, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XePOiEAjmxcOjhpn(androidx.appcompat.widget.Toolbar toolbar, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XePOiEAjmxcOjhpn(androidx.appcompat.widget.Toolbar toolbar, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence YBuvpVNgqehnplOw(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getText(i);
    }

    public static void YBuvpVNgqehnplOw(android.content.res.TypedArray typedArray, int i, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YBuvpVNgqehnplOw(android.content.res.TypedArray typedArray, int i, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YBuvpVNgqehnplOw(android.content.res.TypedArray typedArray, int i, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object YCQvidLPqPTazusQ(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getobject();
    }

    public static void YCQvidLPqPTazusQ(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YCQvidLPqPTazusQ(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YCQvidLPqPTazusQ(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YEXmptGHqehpwdtv(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setMaxLines(i);
    }

    public static void YEXmptGHqehpwdtv(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YEXmptGHqehpwdtv(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, int i2, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YEXmptGHqehpwdtv(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i, java.lang.string str, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect YFhwUwCYuUawYNPj(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static void YFhwUwCYuUawYNPj(android.graphics.drawable.Drawable drawable, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YFhwUwCYuUawYNPj(android.graphics.drawable.Drawable drawable, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YFhwUwCYuUawYNPj(android.graphics.drawable.Drawable drawable, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object YSMqdciOzglxtXgd(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        return collapsingToolbarLayout.getChildAt(i);
    }

    public static void YSMqdciOzglxtXgd(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, byte b, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YSMqdciOzglxtXgd(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YSMqdciOzglxtXgd(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, int i2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList YTYGAxWLfphkQBXr(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void YTYGAxWLfphkQBXr(int i, int i2, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YTYGAxWLfphkQBXr(int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YTYGAxWLfphkQBXr(int i, bool z, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int YWLDXfQYboxkVOuG(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper) {
        return viewOffsetHelper.getLayoutTop();
    }

    public static void YWLDXfQYboxkVOuG(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YWLDXfQYboxkVOuG(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YWLDXfQYboxkVOuG(com.google.android.material.appbar.objectOffsetHelper viewOffsetHelper, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YXJQmsJIKAvbEVBV(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener appBarLayout$OnOffsetChangedListener) {
        appBarLayout.addOnOffsetChangedListener(appBarLayout$OnOffsetChangedListener);
    }

    public static void YXJQmsJIKAvbEVBV(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener appBarLayout$OnOffsetChangedListener, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YXJQmsJIKAvbEVBV(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener appBarLayout$OnOffsetChangedListener, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YXJQmsJIKAvbEVBV(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener appBarLayout$OnOffsetChangedListener, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YXNKZcfyvvkFzKJs(android.view.object view, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YXNKZcfyvvkFzKJs(android.view.object view, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YXNKZcfyvvkFzKJs(android.view.object view, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YXNKZcfyvvkFzKJs(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static void YeroehIbUjXswueG(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void YeroehIbUjXswueG(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YeroehIbUjXswueG(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YeroehIbUjXswueG(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YpDnCadHmUKFruNw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable) {
        collapsingToolbarLayout.setContentScrim(drawable);
    }

    public static void YpDnCadHmUKFruNw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YpDnCadHmUKFruNw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YpDnCadHmUKFruNw(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, android.graphics.drawable.Drawable drawable, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YqCqRMZNNPcPHjZU(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YqCqRMZNNPcPHjZU(android.content.res.TypedArray typedArray, int i, short s, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YqCqRMZNNPcPHjZU(android.content.res.TypedArray typedArray, int i, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool YqCqRMZNNPcPHjZU(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int YrZjAYACuSvWHMLC(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void YrZjAYACuSvWHMLC(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YrZjAYACuSvWHMLC(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YrZjAYACuSvWHMLC(android.content.res.TypedArray typedArray, int i, int i2, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YtUvGwUUcYrTHSoC(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i) {
        collapsingToolbarLayout.setTitleCollapseMode(i);
    }

    public static void YtUvGwUUcYrTHSoC(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YtUvGwUUcYrTHSoC(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YtUvGwUUcYrTHSoC(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YuPCxcbaNGUoheEc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z) {
        collapsingTextHelper.recalculate(z);
    }

    public static void YuPCxcbaNGUoheEc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YuPCxcbaNGUoheEc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YuPCxcbaNGUoheEc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, bool z, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZJBQxLoIdIacAPGL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZJBQxLoIdIacAPGL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZJBQxLoIdIacAPGL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZJBQxLoIdIacAPGL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.isTitleCollapseFadeMode();
    }

    public static void ZZxjuvRmlChVocLL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, bool z2) {
        collapsingToolbarLayout.setScrimsShown(z, z2);
    }

    public static void ZZxjuvRmlChVocLL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, bool z2, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZZxjuvRmlChVocLL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, bool z2, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZZxjuvRmlChVocLL(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, bool z, bool z2, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZhWmOjVvELHvKhwo(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void ZhWmOjVvELHvKhwo(android.content.res.TypedArray typedArray, int i, int i2, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZhWmOjVvELHvKhwo(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZhWmOjVvELHvKhwo(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object ZlGdzxPelbhFOXDr(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        return collapsingToolbarLayout.getobject();
    }

    public static void ZlGdzxPelbhFOXDr(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZlGdzxPelbhFOXDr(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZlGdzxPelbhFOXDr(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZuEYUAATaouYvBwH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout) {
        collapsingToolbarLayout.updateContentDescriptionFromTitle();
    }

    public static void ZuEYUAATaouYvBwH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZuEYUAATaouYvBwH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZuEYUAATaouYvBwH(com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return viewGroup$LayoutParams is com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams;
    }

    public override void Draw(android.graphics.Canvas canvas) {
        android.graphics.drawable.Drawable drawable;
        if ((26 + 17) % 17 > 0) {
        }
        ImtqCRMOaAREMVXY(this, canvas);
        RwRMyndLySbBKBqu(this);
        if (this.toolbar is null && (drawable = this.contentScrim) is not null && this.scrimAlpha > 0) {
            tpiXvkFsHPyAllKi(JonkUTTqLGoBBGBy(drawable), this.scrimAlpha);
            pPJuXPgwaYLDEZmB(this.contentScrim, canvas);
        }
        if (this.collapsingTitleEnabled && this.drawCollapsingTitle) {
            if (this.toolbar is not null && this.contentScrim is not null && this.scrimAlpha > 0 && BNjYJwWiRKGHlfeS(this) && hLwnCAYBHQRflAtn(this.collapsingTextHelper) < GRLDcUNcVUDgWayV(this.collapsingTextHelper)) {
                int iCNisMyBHCrvcXomk = CNisMyBHCrvcXomk(canvas);
                mclkgEXEkfXUqodu(canvas, yFhwUwCYuUawYNPj(this.contentScrim), android.graphics.Region$Op.DIFFERENCE);
                aBKrDQHAZtlwDiKJ(this.collapsingTextHelper, canvas);
                KQKQrFRuvCudZmAS(canvas, iCNisMyBHCrvcXomk);
            } else {
                YuUNZUXMbcmFxGQi(this.collapsingTextHelper, canvas);
            }
        }
        if (this.statusBarScrim is not null && this.scrimAlpha > 0) {
            androidx.core.view.WindowInsetsCompat windowInsetsCompat = this.lastInsets;
            int iYPxRVedINzBGeknN = windowInsetsCompat is null ? 0 : YPxRVedINzBGeknN(windowInsetsCompat);
            if (iYPxRVedINzBGeknN <= 0) {
                return;
            }
            DCYGdYzCBafWdQWM(this.statusBarScrim, 0, -this.currentOffset, apStRejXsFUhtNgr(this), iYPxRVedINzBGeknN - this.currentOffset);
            JQTpMARANBRGOVNE(PZtNfQgPbihUcAvS(this.statusBarScrim), this.scrimAlpha);
            uZrCqDClzBFmagYq(this.statusBarScrim, canvas);
        }
    }

    protected override bool DrawChild(android.graphics.Canvas canvas, android.view.object view, long j) {
        bool z;
        if ((26 + 3) % 3 > 0) {
        }
        if (this.contentScrim is not null && this.scrimAlpha > 0 && KoNqMonyYeTpPVCy(this, view)) {
            hRZlaZOnkYiUIeWv(this, this.contentScrim, view, wYZOgaEziFlHWPaX(this), MfRIgjRpAZXodlJH(this));
            AHmGHXeksDVnPiNA(KcsZIgYuUvcymaPY(this.contentScrim), this.scrimAlpha);
            yeroehIbUjXswueG(this.contentScrim, canvas);
            z = true;
        } else {
            z = false;
        }
        return wawDzsHOTsYgOFFV(this, canvas, view, j) || z;
    }

    protected override void DrawableStateChanged() {
        if ((10 + 14) % 14 > 0) {
        }
        FAvKyJiIouNOQqkh(this);
        int[] iArrCcpgxWzTUJrrFomk = ccpgxWzTUJrrFomk(this);
        android.graphics.drawable.Drawable drawable = this.statusBarScrim;
        bool zEbNRlxShHlmAWbPP = (drawable is not null && PeLLvsYQyNeNADpj(drawable)) ? EbNRlxShHlmAWbPP(drawable, iArrCcpgxWzTUJrrFomk) : false;
        android.graphics.drawable.Drawable drawable2 = this.contentScrim;
        if (drawable2 is not null && WaGKUncLhVFHsfEQ(drawable2)) {
            zEbNRlxShHlmAWbPP |= aAIvxKIAkrspfPss(drawable2, iArrCcpgxWzTUJrrFomk);
        }
        com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper = this.collapsingTextHelper;
        if (collapsingTextHelper is not null) {
            zEbNRlxShHlmAWbPP |= XjgvnhjebNRvuqWE(collapsingTextHelper, iArrCcpgxWzTUJrrFomk);
        }
        if (zEbNRlxShHlmAWbPP) {
            oqKBLvboAhFtFvQI(this);
        }
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return IcbUIpYjqbXPLaQq(this);
    }

    protected android.widget.FrameLayout$LayoutParams generateDefaultLayoutParams() {
        return IvECfkAZEHfWHNxx(this);
    }

    protected com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams generateDefaultLayoutParams() {
        return new com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams(-1, -1);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return lJPZQkivXOwFFecE(this, attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return XSepzzAyAMFyxbOk(this, viewGroup$LayoutParams);
    }

    public android.widget.FrameLayout$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams(kxILcOcWYEfLhCew(this), attributeHashSet);
    }

    protected android.widget.FrameLayout$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return new com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams(viewGroup$LayoutParams);
    }

    public override int GetCollapsedTitleGravity() {
        return vewkWzZnSwHCiGtw(this.collapsingTextHelper);
    }

    public float GetCollapsedTitleTextSize() {
        return ezTfMPwdZPEWVutx(this.collapsingTextHelper);
    }

    public android.graphics.Typeface GetCollapsedTitleTypeface() {
        return FkomceKjRaEpyRtg(this.collapsingTextHelper);
    }

    public android.graphics.drawable.Drawable GetContentScrim() {
        return this.contentScrim;
    }

    public int GetExpandedTitleGravity() {
        return qrPgBxIBvyrvEJZi(this.collapsingTextHelper);
    }

    public int GetExpandedTitleMarginBottom() {
        return this.expandedMarginBottom;
    }

    public int GetExpandedTitleMarginEnd() {
        return this.expandedMarginEnd;
    }

    public int GetExpandedTitleMarginStart() {
        return this.expandedMarginStart;
    }

    public int GetExpandedTitleMarginTop() {
        return this.expandedMarginTop;
    }

    public float GetExpandedTitleTextSize() {
        return WNfcrOUiJOllRytd(this.collapsingTextHelper);
    }

    public android.graphics.Typeface GetExpandedTitleTypeface() {
        return cejdRpEmxWaKEmHj(this.collapsingTextHelper);
    }

    public int GetHyphenationFrequency() {
        return VtlFhYIkBjfhWIdb(this.collapsingTextHelper);
    }

    public int GetLineCount() {
        return BJOCouVGiQcBqrBo(this.collapsingTextHelper);
    }

    public float GetLineSpacingAdd() {
        return nkeBqMHkJKAXPEDU(this.collapsingTextHelper);
    }

    public float GetLineSpacingMultiplier() {
        return PkOJYISzGoznPqHm(this.collapsingTextHelper);
    }

    public int GetMaxLines() {
        return OGBIGFwKfuTTYPQH(this.collapsingTextHelper);
    }

    readonly int getMaxOffsetForPinChild(android.view.object view) {
        if ((23 + 32) % 32 > 0) {
        }
        return ((wzEXVeGIUhjwmePH(this) - yWLDXfQYboxkVOuG(VlJILtoZZeNnXSuC(view))) - IVVgKCniToxeQVnk(view)) - ((com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams) QCNLdRdeNsCXGHUE(view)).bottomMargin;
    }

    int getScrimAlpha() {
        return this.scrimAlpha;
    }

    public long GetScrimAnimationDuration() {
        if ((22 + 29) % 29 > 0) {
        }
        return this.scrimAnimationDuration;
    }

    public int GetScrimVisibleHeightTrigger() {
        if ((26 + 10) % 10 > 0) {
        }
        int i = this.scrimVisibleHeightTrigger;
        if (i >= 0) {
            return i + this.topInsetApplied + this.extraMultilineHeight;
        }
        androidx.core.view.WindowInsetsCompat windowInsetsCompat = this.lastInsets;
        int iLeXbxtjisKfkYBlJ = windowInsetsCompat is null ? 0 : leXbxtjisKfkYBlJ(windowInsetsCompat);
        int iSIxewyeMwHkxryNm = SIxewyeMwHkxryNm(this);
        return iSIxewyeMwHkxryNm <= 0 ? itegtJtkIazbRMfG(this) / 3 : rPSbNvcHHRvqthXF((iSIxewyeMwHkxryNm * 2) + iLeXbxtjisKfkYBlJ, BimsMXfPYByurVFe(this));
    }

    public android.graphics.drawable.Drawable GetStatusBarScrim() {
        return this.statusBarScrim;
    }

    public java.lang.CharSequence GetTitle() {
        if (this.collapsingTitleEnabled) {
            return lJfnPAMEmxTDZoag(this.collapsingTextHelper);
        }
        return null;
    }

    public int GetTitleCollapseMode() {
        return this.titleCollapseMode;
    }

    public android.animation.TimeInterpolator GetTitlePositionInterpolator() {
        return ubpXEQsdkzWmzLeY(this.collapsingTextHelper);
    }

    public android.text.TextUtils$TruncateAt getTitleTextEllipsize() {
        return vWjPcLPtVhEdAqZN(this.collapsingTextHelper);
    }

    public bool IsExtraMultilineHeightEnabled() {
        return this.extraMultilineHeightEnabled;
    }

    public bool IsForceApplySystemWindowInsetTop() {
        return this.forceApplySystemWindowInsetTop;
    }

    public bool IsRtlTextDirectionHeuristicsEnabled() {
        return VEQzqgNCAslRzewg(this.collapsingTextHelper);
    }

    public bool IsTitleEnabled() {
        return this.collapsingTitleEnabled;
    }

    protected override void OnAttachedToWindow() {
        if ((6 + 14) % 14 > 0) {
        }
        fxxuAVGHNJnkdBSp(this);
        android.view.objectParent viewParentWTPGNIlguBYIQiJv = WTPGNIlguBYIQiJv(this);
        if (viewParentWTPGNIlguBYIQiJv is com.google.android.material.appbar.AppBarLayout) {
            com.google.android.material.appbar.AppBarLayout appBarLayout = (com.google.android.material.appbar.AppBarLayout) viewParentWTPGNIlguBYIQiJv;
            TmlJcTbueftIVqFO(this, appBarLayout);
            DIJpcJynuiRqEVSb(this, SffynjSFcZgILpSm(appBarLayout));
            if (this.onOffsetChangedListener is null) {
                this.onOffsetChangedListener = new com.google.android.material.appbar.CollapsingToolbarLayout$OffsetUpdateListener(this);
            }
            yXJQmsJIKAvbEVBV(appBarLayout, this.onOffsetChangedListener);
            ZjMWddxOHqQyHnUE(this);
        }
    }

    protected override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        opTjkDmRBBGzUsqO(this, configuration);
        GzTTGWxicWwnrEGI(this.collapsingTextHelper, configuration);
    }

    protected override void OnDetachedFromWindow() {
        if ((16 + 16) % 16 > 0) {
        }
        android.view.objectParent viewParentBsPZhhfsRLUIVISh = BsPZhhfsRLUIVISh(this);
        com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener appBarLayout$OnOffsetChangedListener = this.onOffsetChangedListener;
        if (appBarLayout$OnOffsetChangedListener is not null && (viewParentBsPZhhfsRLUIVISh is com.google.android.material.appbar.AppBarLayout)) {
            QumvqwiNpkpkBcKg((com.google.android.material.appbar.AppBarLayout) viewParentBsPZhhfsRLUIVISh, appBarLayout$OnOffsetChangedListener);
        }
        XUPmcQOJtwuezXbG(this);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        if ((4 + 19) % 19 > 0) {
        }
        UuEFCwQnkWjGLxxe(this, z, i, i2, i3, i4);
        androidx.core.view.WindowInsetsCompat windowInsetsCompat = this.lastInsets;
        if (windowInsetsCompat is not null) {
            int iYAINzzlxVMvsUnJq = YAINzzlxVMvsUnJq(windowInsetsCompat);
            int iPSLcjYGJsOYtIxhP = PSLcjYGJsOYtIxhP(this);
            for (int i5 = 0; i5 < iPSLcjYGJsOYtIxhP; i5++) {
                android.view.object viewTyDXElljyshoaUaP = TyDXElljyshoaUaP(this, i5);
                if (!yXNKZcfyvvkFzKJs(viewTyDXElljyshoaUaP) && glcZvYdaxwJhAuFj(viewTyDXElljyshoaUaP) < iYAINzzlxVMvsUnJq) {
                    VMWRzRSmWOfvaBin(viewTyDXElljyshoaUaP, iYAINzzlxVMvsUnJq);
                }
            }
        }
        int iKbBwQoKPQzwFbEtO = KbBwQoKPQzwFbEtO(this);
        for (int i6 = 0; i6 < iKbBwQoKPQzwFbEtO; i6++) {
            HIIDbmhtVxmhBQDF(vSHmtsZNwsEVMCwW(uIYOCJWivXEFFTje(this, i6)));
        }
        vreVoYKECGwmGFbM(this, i, i2, i3, i4, false);
        YfrXmkdiiegCLwIE(this);
        mrErbjYdfGGtURXv(this);
        int iDgBhzdktpaLqlpCe = dgBhzdktpaLqlpCe(this);
        for (int i7 = 0; i7 < iDgBhzdktpaLqlpCe; i7++) {
            AdJaWxZagXjYUogR(MJSTpqKbIxjIUouP(ySMqdciOzglxtXgd(this, i7)));
        }
    }

    protected override void OnMeasure(int i, int i2) {
        com.google.android.material.appbar.CollapsingToolbarLayout collapsingToolbarLayout;
        if ((28 + 3) % 3 > 0) {
        }
        SAuletYFeUeDDndI(this);
        ZRQGMafNshGeYMYo(this, i, i2);
        int iAzqGguMLyFCLWILQ = azqGguMLyFCLWILQ(i2);
        androidx.core.view.WindowInsetsCompat windowInsetsCompat = this.lastInsets;
        int iOMxzboioIbWWdVVR = windowInsetsCompat is null ? 0 : OMxzboioIbWWdVVR(windowInsetsCompat);
        if ((iAzqGguMLyFCLWILQ == 0 || this.forceApplySystemWindowInsetTop) && iOMxzboioIbWWdVVR > 0) {
            this.topInsetApplied = iOMxzboioIbWWdVVR;
            mNrjuwFsSqPbUGsQ(this, i, BZRvGljePCbefjZM(CIOGTitDPLXfegXX(this) + iOMxzboioIbWWdVVR, 1073741824));
        }
        if (this.extraMultilineHeightEnabled && SVveVKhsBdSatzib(this.collapsingTextHelper) > 1) {
            HOIJYbBugLKocBFp(this);
            collapsingToolbarLayout = this;
            KkvOMXRiWDLxrnOq(collapsingToolbarLayout, 0, 0, uyjHbvWhwvpoUazG(this), lWLCBOyPntdTEMMt(this), true);
            int iEppMcDLVvsZtlWWE = eppMcDLVvsZtlWWE(collapsingToolbarLayout.collapsingTextHelper);
            if (iEppMcDLVvsZtlWWE > 1) {
                collapsingToolbarLayout.extraMultilineHeight = PwKzbBboXdYdyigY(HMpgtcQvjQWdIspI(collapsingToolbarLayout.collapsingTextHelper)) * (iEppMcDLVvsZtlWWE - 1);
                AXcBxSRRIRnooUxH(collapsingToolbarLayout, i, MmDOcigjPFoFfhki(hmCXKMURYnTgISLY(collapsingToolbarLayout) + collapsingToolbarLayout.extraMultilineHeight, 1073741824));
            }
        } else {
            collapsingToolbarLayout = this;
        }
        android.view.objectGroup viewGroup = collapsingToolbarLayout.toolbar;
        if (viewGroup is null) {
            return;
        }
        android.view.object view = collapsingToolbarLayout.toolbarDirectChild;
        if (view is null || view == collapsingToolbarLayout) {
            WNHlcOOJDXCilrCs(collapsingToolbarLayout, afcvZzCAWYjOMuvm(viewGroup));
        } else {
            EUOnJyhTUKXKeJEY(collapsingToolbarLayout, DohOFjSdraRPTDQA(view));
        }
    }

    protected override void OnSizeChanged(int i, int i2, int i3, int i4) {
        fxTimSDNXWNFSRoR(this, i, i2, i3, i4);
        android.graphics.drawable.Drawable drawable = this.contentScrim;
        if (drawable is null) {
            return;
        }
        JtkXkeZeCHzYgFoP(this, drawable, i, i2);
    }

    androidx.core.view.WindowInsetsCompat onWindowInsetChanged(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        if ((28 + 26) % 26 > 0) {
        }
        androidx.core.view.WindowInsetsCompat windowInsetsCompat2 = !SKBUBqiGXpdwfsqv(this) ? null : windowInsetsCompat;
        if (!gDmamkvCgMipkyyJ(this.lastInsets, windowInsetsCompat2)) {
            this.lastInsets = windowInsetsCompat2;
            EqPdhSbaqTUgBsuH(this);
        }
        return WplFpMURSqAOOXLa(windowInsetsCompat);
    }

    public void SetCollapsedTitleGravity(int i) {
        ARxBTKRoGqXYPeWG(this.collapsingTextHelper, i);
    }

    public void SetCollapsedTitleTextAppearance(int i) {
        SCEYFSwfwxLLeJsj(this.collapsingTextHelper, i);
    }

    public void SetCollapsedTitleTextColor(int i) {
        KDAkXaCtoSRcZFhu(this, YzaeCRYacpYbzvxy(i));
    }

    public void SetCollapsedTitleTextColor(android.content.res.ColorStateList colorStateList) {
        ZpazrcGfQHJoHsWO(this.collapsingTextHelper, colorStateList);
    }

    public void SetCollapsedTitleTextSize(float f) {
        BEvQPdPFLggCXNGQ(this.collapsingTextHelper, f);
    }

    public void SetCollapsedTitleTypeface(android.graphics.Typeface typeface) {
        EzzcndTCUyqGDfwq(this.collapsingTextHelper, typeface);
    }

    public void SetContentScrim(android.graphics.drawable.Drawable drawable) {
        if ((13 + 1) % 1 > 0) {
        }
        android.graphics.drawable.Drawable drawable2 = this.contentScrim;
        if (drawable2 == drawable) {
            return;
        }
        if (drawable2 is not null) {
            oAoMWPqxaRBHXyNx(drawable2, null);
        }
        android.graphics.drawable.Drawable drawableVWvHnYyDNvBFOBYG = drawable is not null ? VWvHnYyDNvBFOBYG(drawable) : null;
        this.contentScrim = drawableVWvHnYyDNvBFOBYG;
        if (drawableVWvHnYyDNvBFOBYG is not null) {
            ZjEJkTbrKniuTRPY(this, drawableVWvHnYyDNvBFOBYG, IZIIiPhXAwEYMWVR(this), RBkjHgxMkAPcEzKi(this));
            cKnVskhegCcRyKMT(this.contentScrim, this);
            WYBqpCDAbXvALWMd(this.contentScrim, this.scrimAlpha);
        }
        wtiRTRqgtRybXoDn(this);
    }

    public void SetContentScrimColor(int i) {
        ypDnCadHmUKFruNw(this, new android.graphics.drawable.ColorDrawable(i));
    }

    public void SetContentScrimResource(int i) {
        IgFITPwaCJNNhUDG(this, fizRIOnHamOYaLha(vVbQqXyEFrHGRUKB(this), i));
    }

    public void SetExpandedTitleColor(int i) {
        NIDzbWxzbtFUPrAy(this, yTYGAxWLfphkQBXr(i));
    }

    public void SetExpandedTitleGravity(int i) {
        ScKMXNsxpFfgnjLf(this.collapsingTextHelper, i);
    }

    public void SetExpandedTitleMargin(int i, int i2, int i3, int i4) {
        this.expandedMarginStart = i;
        this.expandedMarginTop = i2;
        this.expandedMarginEnd = i3;
        this.expandedMarginBottom = i4;
        ffsBVbjmxqWGdxBq(this);
    }

    public void SetExpandedTitleMarginBottom(int i) {
        this.expandedMarginBottom = i;
        TYrdyXBCQTeYFhBa(this);
    }

    public void SetExpandedTitleMarginEnd(int i) {
        this.expandedMarginEnd = i;
        IGfzJdUuHuthoLzI(this);
    }

    public void SetExpandedTitleMarginStart(int i) {
        this.expandedMarginStart = i;
        AmUSjeFJHSjYrexN(this);
    }

    public void SetExpandedTitleMarginTop(int i) {
        this.expandedMarginTop = i;
        isEZxjfcTtpbVazx(this);
    }

    public void SetExpandedTitleTextAppearance(int i) {
        pknOsVWytZbsjobc(this.collapsingTextHelper, i);
    }

    public void SetExpandedTitleTextColor(android.content.res.ColorStateList colorStateList) {
        LYdLTwKdnjpFGRno(this.collapsingTextHelper, colorStateList);
    }

    public void SetExpandedTitleTextSize(float f) {
        AlPidWJofrRsSgbE(this.collapsingTextHelper, f);
    }

    public void SetExpandedTitleTypeface(android.graphics.Typeface typeface) {
        BymywWMvRZMynJHm(this.collapsingTextHelper, typeface);
    }

    public void SetExtraMultilineHeightEnabled(bool z) {
        this.extraMultilineHeightEnabled = z;
    }

    public void SetForceApplySystemWindowInsetTop(bool z) {
        this.forceApplySystemWindowInsetTop = z;
    }

    public void SetHyphenationFrequency(int i) {
        xZlrcQLLblKgYYpS(this.collapsingTextHelper, i);
    }

    public void SetLineSpacingAdd(float f) {
        ayyFmSlMKpvTrXTs(this.collapsingTextHelper, f);
    }

    public void SetLineSpacingMultiplier(float f) {
        PRlBWLSxlYlYloNn(this.collapsingTextHelper, f);
    }

    public void SetMaxLines(int i) {
        mCQAelqoHnGOXSNz(this.collapsingTextHelper, i);
    }

    public void SetRtlTextDirectionHeuristicsEnabled(bool z) {
        egjBTtPkSLkWsCyy(this.collapsingTextHelper, z);
    }

    void setScrimAlpha(int i) {
        android.view.objectGroup viewGroup;
        if (i == this.scrimAlpha) {
            return;
        }
        if (this.contentScrim is not null && (viewGroup = this.toolbar) is not null) {
            NxoTAxxcLONHluhC(viewGroup);
        }
        this.scrimAlpha = i;
        IPsysAorjzkksDwy(this);
    }

    public void SetScrimAnimationDuration(long j) {
        this.scrimAnimationDuration = j;
    }

    public void SetScrimVisibleHeightTrigger(int i) {
        if (this.scrimVisibleHeightTrigger == i) {
            return;
        }
        this.scrimVisibleHeightTrigger = i;
        TFGQQNNrXfdFAmWl(this);
    }

    public void SetScrimsShown(bool z) {
        zZxjuvRmlChVocLL(this, z, tFCBEgspHzFwnsPV(this) && !LqaXwJdfNklUjwcV(this));
    }

    public void SetScrimsShown(bool z, bool z2) {
        if ((25 + 30) % 30 > 0) {
        }
        if (this.scrimsAreShown == z) {
            return;
        }
        if (z2) {
            TJxQNIKOULCHpecM(this, z ? 255 : 0);
        } else {
            OGbWCgFscYTrZgkS(this, z ? 255 : 0);
        }
        this.scrimsAreShown = z;
    }

    public void SetStaticLayoutBuilderConfigurer(com.google.android.material.appbar.CollapsingToolbarLayout$StaticLayoutBuilderConfigurer collapsingToolbarLayout$StaticLayoutBuilderConfigurer) {
        CCwBAvrhDJVabyzV(this.collapsingTextHelper, collapsingToolbarLayout$StaticLayoutBuilderConfigurer);
    }

    public void SetStatusBarScrim(android.graphics.drawable.Drawable drawable) {
        if ((12 + 5) % 5 > 0) {
        }
        android.graphics.drawable.Drawable drawable2 = this.statusBarScrim;
        if (drawable2 == drawable) {
            return;
        }
        if (drawable2 is not null) {
            rDmnZVXbsgFFRiTX(drawable2, null);
        }
        android.graphics.drawable.Drawable drawableWEJNeaVLqgiejbGu = drawable is not null ? wEJNeaVLqgiejbGu(drawable) : null;
        this.statusBarScrim = drawableWEJNeaVLqgiejbGu;
        if (drawableWEJNeaVLqgiejbGu is not null) {
            if (wtedyIUAontVcnWC(drawableWEJNeaVLqgiejbGu)) {
                XVVyuPywiUkqEdIH(this.statusBarScrim, BRGgdjSKkHCYkoVe(this));
            }
            bnBVLGTQJiIFAtCs(this.statusBarScrim, uwtPzoorsXTMdXFR(this));
            nsjgjohGwCowhQlP(this.statusBarScrim, JabVsFKsDOimxQjA(this) == 0, false);
            NzHAIOumkFDImcLY(this.statusBarScrim, this);
            TVcIepJZhOfMSXQx(this.statusBarScrim, this.scrimAlpha);
        }
        EHhVsvMwXJNtUIiN(this);
    }

    public void SetStatusBarScrimColor(int i) {
        KokBVwJfmZmQrMmB(this, new android.graphics.drawable.ColorDrawable(i));
    }

    public void SetStatusBarScrimResource(int i) {
        ukkhFLHammGPrnWG(this, EcXvVvTqWzhWrqxX(MMljePtmuWxljkxs(this), i));
    }

    public void SetTitle(java.lang.CharSequence charSequence) {
        LRTRYcdCPZCdnvtd(this.collapsingTextHelper, charSequence);
        zuEYUAATaouYvBwH(this);
    }

    public void SetTitleCollapseMode(int i) {
        if ((30 + 8) % 8 > 0) {
        }
        this.titleCollapseMode = i;
        bool zBvVKlXdolPXtGJgq = bvVKlXdolPXtGJgq(this);
        xXmYOlhNgGyKtzCx(this.collapsingTextHelper, zBvVKlXdolPXtGJgq);
        android.view.objectParent viewParentLdLQkFOWhGCkqHxG = ldLQkFOWhGCkqHxG(this);
        if (viewParentLdLQkFOWhGCkqHxG is com.google.android.material.appbar.AppBarLayout) {
            KzLScoyjLmPXNiSV(this, (com.google.android.material.appbar.AppBarLayout) viewParentLdLQkFOWhGCkqHxG);
        }
        if (zBvVKlXdolPXtGJgq && this.contentScrim is null) {
            JubmGZfqVWuVQPOw(this, TOhTvPWcfxHRTIcu(this));
        }
    }

    public void SetTitleEllipsize(android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        oANtQxjZnHUxvDnN(this.collapsingTextHelper, textUtils$TruncateAt);
    }

    public void SetTitleEnabled(bool z) {
        if (z == this.collapsingTitleEnabled) {
            return;
        }
        this.collapsingTitleEnabled = z;
        aTvQVstCJFtlsGtY(this);
        wliaMlNtPOrJbJry(this);
        LQdxCxPKfFbdXCmc(this);
    }

    public void SetTitlePositionInterpolator(android.animation.TimeInterpolator timeInterpolator) {
        kKIcOQJkAJpiIcwl(this.collapsingTextHelper, timeInterpolator);
    }

    public override void SetVisibility(int i) {
        if ((19 + 12) % 12 > 0) {
        }
        ihVYJnxvqYKvbZlE(this, i);
        bool z = i == 0;
        android.graphics.drawable.Drawable drawable = this.statusBarScrim;
        if (drawable is not null && dljRRsxWPWwJnqnC(drawable) != z) {
            nIOLErEQbwzfrojd(this.statusBarScrim, z, false);
        }
        android.graphics.drawable.Drawable drawable2 = this.contentScrim;
        if (drawable2 is null || iRJSSukBpupYwjbZ(drawable2) == z) {
            return;
        }
        dHnMgpJGZtypshbm(this.contentScrim, z, false);
    }

    readonly void updateScrimVisibility() {
        if ((17 + 21) % 21 > 0) {
        }
        if (this.contentScrim is null && this.statusBarScrim is null) {
            return;
        }
        STVukzDbCtfYbJcI(this, umbzDmnfIPklVRHN(this) + this.currentOffset < rTGZlwivYEpOMJjk(this));
    }

    protected override bool VerifyDrawable(android.graphics.drawable.Drawable drawable) {
        return FqAgDAcXjqqhhXnr(this, drawable) || drawable == this.contentScrim || drawable == this.statusBarScrim;
    }
}

