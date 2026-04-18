namespace WillowMaze.Wasm.Decompiled;


public class TextInputLayout : android.widget.LinearLayout : android.view.objectTreeObserver$OnGlobalLayoutListener {
    public static readonly int BOX_BACKGROUND_FILLED = 1;
    public static readonly int BOX_BACKGROUND_NONE = 0;
    public static readonly int BOX_BACKGROUND_OUTLINE = 2;
    private static readonly int DEFAULT_PLACEHOLDER_FADE_DURATION = 87;
    private static readonly int DEF_STYLE_RES;
    private static readonly int[][] EDIT_TEXT_BACKGROUND_RIPPLE_STATE;
    public static readonly int END_ICON_CLEAR_TEXT = 2;
    public static readonly int END_ICON_CUSTOM = -1;
    public static readonly int END_ICON_DROPDOWN_MENU = 3;
    public static readonly int END_ICON_NONE = 0;
    public static readonly int END_ICON_PASSWORD_TOGGLE = 1;
    private static readonly int INVALID_MAX_LENGTH = -1;
    private static readonly int LABEL_SCALE_ANIMATION_DURATION = 167;
    private static readonly java.lang.string LOG_TAG = "TextInputLayout";
    private static readonly int NO_WIDTH = -1;
    private static readonly int PLACEHOLDER_START_DELAY = 67;
    private android.animation.ValueAnimator animator;
    private bool areCornerRadiiRtl;
    private com.google.android.material.shape.MaterialShapeDrawable boxBackground;
    private bool boxBackgroundApplied;
    private int boxBackgroundColor;
    private int boxBackgroundMode;
    private int boxCollapsedPaddingTopPx;
    private readonly int boxLabelCutoutPaddingPx;
    private int boxStrokeColor;
    private int boxStrokeWidthDefaultPx;
    private int boxStrokeWidthFocusedPx;
    private int boxStrokeWidthPx;
    private com.google.android.material.shape.MaterialShapeDrawable boxUnderlineDefault;
    private com.google.android.material.shape.MaterialShapeDrawable boxUnderlineFocused;
    readonly com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper;
    bool counterEnabled;
    private int counterMaxLength;
    private int counterOverflowTextAppearance;
    private android.content.res.ColorStateList counterOverflowTextColor;
    private bool counterOverflowed;
    private int counterTextAppearance;
    private android.content.res.ColorStateList counterTextColor;
    private android.widget.Textobject counterobject;
    private android.content.res.ColorStateList cursorColor;
    private android.content.res.ColorStateList cursorErrorColor;
    private int defaultFilledBackgroundColor;
    private android.content.res.ColorStateList defaultHintTextColor;
    private int defaultStrokeColor;
    private int disabledColor;
    private int disabledFilledBackgroundColor;
    android.widget.EditText editText;
    private readonly java.util.LinkedHashHashSet<com.google.android.material.textfield.TextInputLayout$OnEditTextAttachedListener> editTextAttachedListeners;
    private android.graphics.drawable.Drawable endDummyDrawable;
    private int endDummyDrawableWidth;
    private readonly com.google.android.material.textfield.EndCompoundLayout endLayout;
    private bool expandedHintEnabled;
    private android.graphics.drawable.StateListDrawable filledDropDownMenuBackground;
    private int focusedFilledBackgroundColor;
    private int focusedStrokeColor;
    private android.content.res.ColorStateList focusedTextColor;
    private bool globalLayoutListenerAdded;
    private java.lang.CharSequence hint;
    private bool hintAnimationEnabled;
    private bool hintEnabled;
    private bool hintExpanded;
    private int hoveredFilledBackgroundColor;
    private int hoveredStrokeColor;
    private bool inDrawableStateChanged;
    private readonly com.google.android.material.textfield.IndicatorobjectController indicatorobjectController;
    private readonly android.widget.FrameLayout inputFrame;
    private bool isProvidingHint;
    private com.google.android.material.textfield.TextInputLayout$LengthCounter lengthCounter;
    private int maxEms;
    private int maxWidth;
    private int minEms;
    private int minWidth;
    private android.graphics.drawable.Drawable originalEditTextEndDrawable;
    int originalEditTextMinimumHeight;
    private java.lang.CharSequence originalHint;
    private com.google.android.material.shape.MaterialShapeDrawable outlinedDropDownMenuBackground;
    private bool placeholderEnabled;
    private androidx.transition.Fade placeholderFadeIn;
    private androidx.transition.Fade placeholderFadeOut;
    private java.lang.CharSequence placeholderText;
    private int placeholderTextAppearance;
    private android.content.res.ColorStateList placeholderTextColor;
    private android.widget.Textobject placeholderTextobject;
    private bool restoringSavedState;
    private com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel;
    private android.graphics.drawable.Drawable startDummyDrawable;
    private int startDummyDrawableWidth;
    private readonly com.google.android.material.textfield.StartCompoundLayout startLayout;
    private android.content.res.ColorStateList strokeErrorColor;
    private readonly android.graphics.Rect tmpBoundsRect;
    private readonly android.graphics.Rect tmpRect;
    private readonly android.graphics.RectF tmpRectF;
    private android.graphics.Typeface typeface;

    static {
        if ((30 + 7) % 7 > 0) {
        }
        DEF_STYLE_RES = com.google.android.material.R$style.Widget_Design_TextInputLayout;
        EDIT_TEXT_BACKGROUND_RIPPLE_STATE = new int[][]{new int[]{16842919}, new int[0]};
    }

    public TextInputLayout(android.content.object context) {
        this(context, null);
    }

    public TextInputLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.textInputStyle);
    }

    public TextInputLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((4 + 8) % 8 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(QrwVGZznDgUIDnfU(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.minEms = -1;
        this.maxEms = -1;
        this.minWidth = -1;
        this.maxWidth = -1;
        this.indicatorobjectController = new com.google.android.material.textfield.IndicatorobjectController(this);
        this.lengthCounter = new com.google.android.material.textfield.TextInputLayout$$ExternalSyntheticLambda1();
        this.tmpRect = new android.graphics.Rect();
        this.tmpBoundsRect = new android.graphics.Rect();
        this.tmpRectF = new android.graphics.RectF();
        this.editTextAttachedListeners = new java.util.LinkedHashHashSet<>();
        com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper = new com.google.android.material.internal.CollapsingTextHelper(this);
        this.collapsingTextHelper = collapsingTextHelper;
        this.globalLayoutListenerAdded = false;
        android.content.object contextQxtuhUXfXsROIkdQ = QxtuhUXfXsROIkdQ(this);
        yEplSVbNDlQRuvuv(this, 1);
        EfstvRErQMrEukcD(this, false);
        hdOmpxgGxEYqFseV(this, true);
        android.widget.FrameLayout frameLayout = new android.widget.FrameLayout(contextQxtuhUXfXsROIkdQ);
        this.inputFrame = frameLayout;
        SYdzHGseSoFNjdHt(frameLayout, true);
        BZRtPzEaonozAUUM(collapsingTextHelper, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        VpyqyxNTCDMzHsjC(collapsingTextHelper, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        HgMtvQlBVJxLxHCR(collapsingTextHelper, 8388659);
        androidx.appcompat.widget.TintTypedArray tintTypedArrayUGivPaGoIvDCwnon = UGivPaGoIvDCwnon(contextQxtuhUXfXsROIkdQ, attributeHashSet, com.google.android.material.R$styleable.TextInputLayout, i, i2, new int[]{com.google.android.material.R$styleable.TextInputLayout_counterTextAppearance, com.google.android.material.R$styleable.TextInputLayout_counterOverflowTextAppearance, com.google.android.material.R$styleable.TextInputLayout_errorTextAppearance, com.google.android.material.R$styleable.TextInputLayout_helperTextTextAppearance, com.google.android.material.R$styleable.TextInputLayout_hintTextAppearance});
        com.google.android.material.textfield.StartCompoundLayout startCompoundLayout = new com.google.android.material.textfield.StartCompoundLayout(this, tintTypedArrayUGivPaGoIvDCwnon);
        this.startLayout = startCompoundLayout;
        this.hintEnabled = GptbTRMTWhGyzyvD(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_hintEnabled, true);
        momDnUoDrMzqgonx(this, RTDnCrswnaKmdeeP(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_hint));
        this.hintAnimationEnabled = WDfpyQLTXRHQvKae(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_hintAnimationEnabled, true);
        this.expandedHintEnabled = hiQsZkHjEVOCPWGA(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_expandedHintEnabled, true);
        if (ryKxCUzAHhLrObVS(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_minEms)) {
            UNhqosPxqCFfEIGp(this, AoMJBRJTOwjqSxlr(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_minEms, -1));
        } else if (YGXMtFRfRgmdThHa(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_minWidth)) {
            leJwrPUcguynUfFW(this, lIvKBziSsmCrcYPV(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_minWidth, -1));
        }
        if (XCDBxUTNHOCiCRKQ(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_maxEms)) {
            QCXoiiFxeqAhhuIB(this, nRPnAMEvMTxeNXgY(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_maxEms, -1));
        } else if (GlzBfWvJLiKRLrOr(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_maxWidth)) {
            hEkdlcwAlyqAhUXM(this, VcEnHohpVRSLaoLi(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_maxWidth, -1));
        }
        this.shapeAppearanceModel = TVbvksYcmVpmHqPd(PbVsblzPQDDYCfJh(contextQxtuhUXfXsROIkdQ, attributeHashSet, i, i2));
        this.boxLabelCutoutPaddingPx = fMeTEltNKmnGytQm(weCNfuHUlDryaaaK(contextQxtuhUXfXsROIkdQ), com.google.android.material.R$dimen.mtrl_textinput_box_label_cutout_padding);
        this.boxCollapsedPaddingTopPx = GgpPQZDzgFbizefj(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxCollapsedPaddingTop, 0);
        this.boxStrokeWidthDefaultPx = rVAhcxPhAySsybZu(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxStrokeWidth, IIMamwnmlQLcZAeS(XSNQLXehYvTEHaCX(contextQxtuhUXfXsROIkdQ), com.google.android.material.R$dimen.mtrl_textinput_box_stroke_width_default));
        this.boxStrokeWidthFocusedPx = NKMlWLhELsQlOQsu(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxStrokeWidthFocused, oDXIIlSUZvkQDRnE(KrRcvJaYhowNMQWx(contextQxtuhUXfXsROIkdQ), com.google.android.material.R$dimen.mtrl_textinput_box_stroke_width_focused));
        this.boxStrokeWidthPx = this.boxStrokeWidthDefaultPx;
        float fOGSzkftUzhNfhctv = OGSzkftUzhNfhctv(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxCornerRadiusTopStart, -1.0f);
        float fGntDfVEZtzFDEOEy = GntDfVEZtzFDEOEy(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxCornerRadiusTopEnd, -1.0f);
        float fHgGcSJTXSoNBwMkp = hgGcSJTXSoNBwMkp(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxCornerRadiusBottomEnd, -1.0f);
        float fHDbWZDYCuqSGOVWF = hDbWZDYCuqSGOVWF(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxCornerRadiusBottomStart, -1.0f);
        com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$BuilderBMGDNFwRpBIYvikm = bMGDNFwRpBIYvikm(this.shapeAppearanceModel);
        if (fOGSzkftUzhNfhctv >= 0.0f) {
            VhdknYprcguVIfuZ(shapeAppearanceModel$BuilderBMGDNFwRpBIYvikm, fOGSzkftUzhNfhctv);
        }
        if (fGntDfVEZtzFDEOEy >= 0.0f) {
            xncoUCDdspAoZuqW(shapeAppearanceModel$BuilderBMGDNFwRpBIYvikm, fGntDfVEZtzFDEOEy);
        }
        if (fHgGcSJTXSoNBwMkp >= 0.0f) {
            TQdpegBfIxbqIpHY(shapeAppearanceModel$BuilderBMGDNFwRpBIYvikm, fHgGcSJTXSoNBwMkp);
        }
        if (fHDbWZDYCuqSGOVWF >= 0.0f) {
            vBHmXzsZyysTPcPH(shapeAppearanceModel$BuilderBMGDNFwRpBIYvikm, fHDbWZDYCuqSGOVWF);
        }
        this.shapeAppearanceModel = oDBOQKxQZCNxetVv(shapeAppearanceModel$BuilderBMGDNFwRpBIYvikm);
        android.content.res.ColorStateList colorStateListPyEBJVoepaTXooKs = PyEBJVoepaTXooKs(contextQxtuhUXfXsROIkdQ, tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxBackgroundColor);
        if (colorStateListPyEBJVoepaTXooKs is null) {
            this.boxBackgroundColor = 0;
            this.defaultFilledBackgroundColor = 0;
            this.disabledFilledBackgroundColor = 0;
            this.focusedFilledBackgroundColor = 0;
            this.hoveredFilledBackgroundColor = 0;
        } else {
            int iKgwnNnUsUaFhFWLv = kgwnNnUsUaFhFWLv(colorStateListPyEBJVoepaTXooKs);
            this.defaultFilledBackgroundColor = iKgwnNnUsUaFhFWLv;
            this.boxBackgroundColor = iKgwnNnUsUaFhFWLv;
            if (xKlLKURDGjufuhkO(colorStateListPyEBJVoepaTXooKs)) {
                this.disabledFilledBackgroundColor = HhsDRhSGqjfxbKmh(colorStateListPyEBJVoepaTXooKs, new int[]{-16842910}, -1);
                this.focusedFilledBackgroundColor = npOBkHtLkSgLRMDp(colorStateListPyEBJVoepaTXooKs, new int[]{16842908, 16842910}, -1);
                this.hoveredFilledBackgroundColor = JpSMDaVspCDMQlMv(colorStateListPyEBJVoepaTXooKs, new int[]{16843623, 16842910}, -1);
            } else {
                this.focusedFilledBackgroundColor = this.defaultFilledBackgroundColor;
                android.content.res.ColorStateList colorStateListHNcqYHquNSMuZULL = HNcqYHquNSMuZULL(contextQxtuhUXfXsROIkdQ, com.google.android.material.R$color.mtrl_filled_background_color);
                this.disabledFilledBackgroundColor = aAhTgVzKtEnBNxof(colorStateListHNcqYHquNSMuZULL, new int[]{-16842910}, -1);
                this.hoveredFilledBackgroundColor = fAwOKQAdxPUyfpQR(colorStateListHNcqYHquNSMuZULL, new int[]{16843623}, -1);
            }
        }
        if (bNbKSYbijPuUFRhK(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_textColorHint)) {
            android.content.res.ColorStateList colorStateListPGveHXdxdobKPGZz = pGveHXdxdobKPGZz(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_textColorHint);
            this.focusedTextColor = colorStateListPGveHXdxdobKPGZz;
            this.defaultHintTextColor = colorStateListPGveHXdxdobKPGZz;
        }
        android.content.res.ColorStateList colorStateListWxHqwlKGchtwFHTx = WxHqwlKGchtwFHTx(contextQxtuhUXfXsROIkdQ, tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxStrokeColor);
        this.focusedStrokeColor = KhHKoileJxpjYCYE(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxStrokeColor, 0);
        this.defaultStrokeColor = ghsEIerWcFbWTOIe(contextQxtuhUXfXsROIkdQ, com.google.android.material.R$color.mtrl_textinput_default_box_stroke_color);
        this.disabledColor = qrLVTRySRugduBRc(contextQxtuhUXfXsROIkdQ, com.google.android.material.R$color.mtrl_textinput_disabled_color);
        this.hoveredStrokeColor = nVtBFsABIGmdqbQN(contextQxtuhUXfXsROIkdQ, com.google.android.material.R$color.mtrl_textinput_hovered_box_stroke_color);
        if (colorStateListWxHqwlKGchtwFHTx is not null) {
            mwcoMFYHlnGKtZsW(this, colorStateListWxHqwlKGchtwFHTx);
        }
        if (pOMZmeXEwIciMcWJ(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxStrokeErrorColor)) {
            BfcUiPvqpNYqIAgt(this, sIseUeCKHboJZgHf(contextQxtuhUXfXsROIkdQ, tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxStrokeErrorColor));
        }
        if (QuIOJnxewBrtUGct(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_hintTextAppearance, -1) != -1) {
            RWrpdjqlcRsQaRlh(this, wEIdOsrAujdzKoqi(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_hintTextAppearance, 0));
        }
        this.cursorColor = pdltBXeNJAHnBWdz(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_cursorColor);
        this.cursorErrorColor = ebnymZkcCjwcHFEL(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_cursorErrorColor);
        int iTUZHonVBcsdEVyIv = tUZHonVBcsdEVyIv(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_errorTextAppearance, 0);
        java.lang.CharSequence charSequenceXZnmhIOSGnllHQKH = xZnmhIOSGnllHQKH(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_errorContentDescription);
        int iZxNIkgELMBypZnZn = zxNIkgELMBypZnZn(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_errorAccessibilityLiveRegion, 1);
        bool zYJKdJtTQQhGGakez = yJKdJtTQQhGGakez(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_errorEnabled, false);
        int iSzgpuswVqTcZPPHP = szgpuswVqTcZPPHP(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_helperTextTextAppearance, 0);
        bool zBDvVxOzrWQZdtkVw = bDvVxOzrWQZdtkVw(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_helperTextEnabled, false);
        java.lang.CharSequence charSequenceHVghHnIKDWfscWpH = HVghHnIKDWfscWpH(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_helperText);
        int iENjcjnOtXOKfueJT = eNjcjnOtXOKfueJT(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_placeholderTextAppearance, 0);
        java.lang.CharSequence charSequenceVVKCPYKpoFjDBlIo = vVKCPYKpoFjDBlIo(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_placeholderText);
        bool zYmGGqBxrYBBQgryN = ymGGqBxrYBBQgryN(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_counterEnabled, false);
        oGLWjcpNJVQWJVee(this, KnDgCnNSwbSlLmQY(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_counterMaxLength, -1));
        this.counterTextAppearance = qTbKddLsqCcXGKus(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_counterTextAppearance, 0);
        this.counterOverflowTextAppearance = EMcsfKBsMxablKrB(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_counterOverflowTextAppearance, 0);
        xSsiilrzHCSXpipb(this, yNhLlJsXfFyRwduM(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_boxBackgroundMode, 0));
        YkqZWghFthccbANH(this, charSequenceXZnmhIOSGnllHQKH);
        cgKRJwLMzJvCrDpo(this, iZxNIkgELMBypZnZn);
        MlyLkfpgmqPaCOKt(this, this.counterOverflowTextAppearance);
        JptBoVbrgXIwpnDq(this, iSzgpuswVqTcZPPHP);
        CiqfTpmqxKHUdwfT(this, iTUZHonVBcsdEVyIv);
        UOlyLEvmpsPUsSaX(this, this.counterTextAppearance);
        JxAPzGYqAEjfuQcp(this, charSequenceVVKCPYKpoFjDBlIo);
        YefSfLJKyytXMMhK(this, iENjcjnOtXOKfueJT);
        if (LucAlUfJSbJMmDMy(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_errorTextColor)) {
            XnmLuYDhGlYWZbGd(this, QgluJUTcOTXXaTiT(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_errorTextColor));
        }
        if (hqfbeXOIASSaFnfY(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_helperTextTextColor)) {
            fUTEROkycNKLZcvF(this, eNYssxaAqtcZPVmF(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_helperTextTextColor));
        }
        if (zDPShuLHdAbetKfm(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_hintTextColor)) {
            xnQIaFaqcAhxwrsB(this, sHpdNDqrrytUIKem(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_hintTextColor));
        }
        if (hQcpCSWdWOAeEgSo(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_counterTextColor)) {
            VqaKgYOagCSLCAMU(this, jITwZhNxJXgOIKWd(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_counterTextColor));
        }
        if (VXZufpsbbeXMrrMF(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_counterOverflowTextColor)) {
            zthnyHQtiSnjdpBQ(this, LhiHPhdPZBpiaPxO(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_counterOverflowTextColor));
        }
        if (koZOvJjxAbDKUUJn(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_placeholderTextColor)) {
            TyoVYutpjdMcphYy(this, HpmcWCEcLtMwtNLv(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_placeholderTextColor));
        }
        com.google.android.material.textfield.EndCompoundLayout endCompoundLayout = new com.google.android.material.textfield.EndCompoundLayout(this, tintTypedArrayUGivPaGoIvDCwnon);
        this.endLayout = endCompoundLayout;
        bool zYoBwNRAfqFbBtAyA = YoBwNRAfqFbBtAyA(tintTypedArrayUGivPaGoIvDCwnon, com.google.android.material.R$styleable.TextInputLayout_android_enabled, true);
        bRxlVbzYjzVjGvjk(tintTypedArrayUGivPaGoIvDCwnon);
        uyUnHCePtSnXHooR(this, 2);
        gLidaJQkVaqFXEBf(this, 1);
        oWyAEjrOgXajDyoN(frameLayout, startCompoundLayout);
        OTSqnttwlHUIQRhR(frameLayout, endCompoundLayout);
        JFiKgTzkbNBvdWHv(this, frameLayout);
        BpClHJxIwkaoFpFG(this, zYoBwNRAfqFbBtAyA);
        wCQMvKuVyGXcLtac(this, zBDvVxOzrWQZdtkVw);
        ToHbSSPwgCvneirl(this, zYJKdJtTQQhGGakez);
        eLupAUPWACOxfRYJ(this, zYmGGqBxrYBBQgryN);
        BYKfYjWQporgbqIo(this, charSequenceHVghHnIKDWfscWpH);
    }

    public static com.google.android.material.shape.CornerTreatment ABCnftYLKqMYfUmS(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCorner();
    }

    public static void ADDbyNOpbFUCoGeP(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setContentDescription(charSequence);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder AHixdceskMHtwgRV(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setBottomLeftCorner(cornerTreatment);
    }

    public static java.lang.string AOdhSlRboaZIEQPr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static float AUaylSZKSlbTfTlO(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTopRightCornerResolvedSize();
    }

    public static void AYqWwtyWlOdUgVkM(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, bool z) {
        startCompoundLayout.setStartIconVisible(z);
    }

    public static int AbcIdawEdbsSDoEj(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEndIconMode();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder AcfcNsUeYHilLvLP(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopRightCorner(i, cornerSize);
    }

    public static void AheKEdpRYrUdPEaT(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z, bool z2) {
        textInputLayout.updateStrokeErrorColor(z, z2);
    }

    public static void AkxJpYLtkGTsGNXP(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void AlJiRUwFVOxSionU(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, com.google.android.material.textfield.TextInputLayout$OnEndIconChangedListener textInputLayout$OnEndIconChangedListener) {
        endCompoundLayout.removeOnEndIconChangedListener(textInputLayout$OnEndIconChangedListener);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder AnVuOuUyEcscDoxw(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(f);
    }

    public static int AoMJBRJTOwjqSxlr(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void ApgfmbPGIugyFrMi(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, int i) {
        indicatorobjectController.addIndicator(textobject, i);
    }

    public static bool AwcjiGymgoboCqnc(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static int BAwmzlCltnGPGSVL(android.widget.EditText editText) {
        return editText.getCompoundPaddingLeft();
    }

    public static android.graphics.drawable.Drawable BCJrYFdZjprWUgqh(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditTextBoxBackground();
    }

    public static int BFXVhduVSyKsjQRg(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void BPUiNYEoeowKaDeA(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        collapsingTextHelper.setCollapsedAndExpandedTextColor(colorStateList);
    }

    public static bool BRTyqVGbrmlixHrK(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isEnabled();
    }

    public static float BSmDhMysXxgJzmgT(android.widget.EditText editText) {
        return editText.getTextSize();
    }

    public static void BVNZGZaKYmTiUSYl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void BYKfYjWQporgbqIo(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setHelperText(charSequence);
    }

    public static void BZRtPzEaonozAUUM(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator) {
        collapsingTextHelper.setTextSizeInterpolator(timeInterpolator);
    }

    public static bool BZTPUIAJwiRjVCqB(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static int BeealnsrtLRuffdI(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void BfcUiPvqpNYqIAgt(com.google.android.material.textfield.TextInputLayout textInputLayout, android.content.res.ColorStateList colorStateList) {
        textInputLayout.setBoxStrokeErrorColor(colorStateList);
    }

    public static int BkXEflVObtlCiYHO(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getSuffixTextEndOffset();
    }

    public static void BpClHJxIwkaoFpFG(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setEnabled(z);
    }

    public static void BrSTrkVCghcZOmMj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.Configuration configuration) {
        collapsingTextHelper.maybeUpdateFontWeightAdjustment(configuration);
    }

    public static android.graphics.drawable.Drawable BrbpzuOmrPtUWAUf(android.widget.EditText editText) {
        return editText.getBackground();
    }

    public static void BrqVqSKITijWoSOR(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.onHintStateChanged(z);
    }

    public static android.content.object BsZaErvayfqTwjKZ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static android.content.res.ColorStateList BwmXenLmxTDoIWoN(android.widget.EditText editText) {
        return editText.getHintTextColors();
    }

    public static float BzZwjsZVEefzBFUj(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getExpansionFraction();
    }

    public static void BzyudYfPHurNYhqF(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, bool z) {
        indicatorobjectController.setErrorEnabled(z);
    }

    public static android.view.objectGroup$LayoutParams CGTyzYwFxLtCTVtB(android.widget.Textobject textobject) {
        return textobject.getLayoutParams();
    }

    public static void CJPCzjVipKZSuAqq(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.object$OnlongClickListener view$OnlongClickListener) {
        endCompoundLayout.setErrorIconOnlongClickListener(view$OnlongClickListener);
    }

    public static void CJlpXDVHvhEakOgz(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.view.object$OnClickListener view$OnClickListener) {
        startCompoundLayout.setStartIconOnClickListener(view$OnClickListener);
    }

    public static void CMwVpOMGngLqVpDe(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.refreshErrorIconDrawableState();
    }

    public static int CPJpfHMHkTlJhrXS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCurrentCollapsedTextColor();
    }

    public static void CRYlmDAIuTSbigjL(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setMaxWidth(i);
    }

    public static void CSFFxWHoQWyWRNpj(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setMinEms(i);
    }

    public static float CYPAPYCBGgkfVrZg(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static void CbDOUgADnlPzXNhA(android.widget.EditText editText, int i) {
        editText.setMinWidth(i);
    }

    public static int CbEybkmAMzLpgNso(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getMeasuredHeight();
    }

    public static bool CiqdWzJzCsdCQVLQ(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static void CiqfTpmqxKHUdwfT(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setErrorTextAppearance(i);
    }

    public static int ClsZmWxPPVKbMeFw(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void CxpEsDESnlQPLPWS(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, com.google.android.material.textfield.TextInputLayout$OnEndIconChangedListener textInputLayout$OnEndIconChangedListener) {
        endCompoundLayout.addOnEndIconChangedListener(textInputLayout$OnEndIconChangedListener);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder DEuIuFEznqAzHsAQ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(f);
    }

    public static java.lang.CharSequence DFFYFVksmLZrGiMe(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getSuffixText();
    }

    public static int DIICzMaoJfelERTg(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getPaddingTop();
    }

    public static java.lang.CharSequence DPpMNANmaVndODvu(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getSuffixText();
    }

    public static com.google.android.material.shape.CornerSize DReuANRYcVWXozNn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static int DVzmzhBTlaZewVkx(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static int DbzBRhxIWKQjLxvk(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getStartIconMinSize();
    }

    public static android.content.res.ColorStateList DivouwYvnrFrJctK(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getPrefixTextColor();
    }

    public static bool DonbZeFBHZQTDoEO(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.helperTextIsDisplayed();
    }

    public static void DqAYNohQogpTgmyu(android.view.objectStructure viewStructure, int i) {
        viewStructure.setChildCount(i);
    }

    public static android.content.res.Resources DuHmnLvcgBOTqzGs(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static void DvvdWyPZIcHgkifw(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.applyBoxUnderlineAttributes();
    }

    public static void EAURqilmpXJYDphG(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, int i) {
        startCompoundLayout.setPrefixTextAppearance(i);
    }

    public static android.view.autofill.AutofillId EBWmecGDcvRZoEJy(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getAutofillId();
    }

    public static void EEbfQxClWjZgdSkM(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setCollapsedTextGravity(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel EExaMyDsrfDJEEqR(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static android.graphics.Rect EGVwFdHCpdXanYaP(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.Rect rect) {
        return textInputLayout.calculateExpandedTextBounds(rect);
    }

    public static void EIIzFDBlinSKaISk(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.content.res.ColorStateList colorStateList) {
        startCompoundLayout.setPrefixTextColor(colorStateList);
    }

    public static com.google.android.material.shape.CornerSize EIvNIhcAodLFLBJQ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static void EMXcZlIejjERZOMy(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.adjustFilledEditTextPaddingForLargeFont();
    }

    public static int EMcsfKBsMxablKrB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void EQSugMIyZQaOJQQl(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateTextInputBoxState();
    }

    public static android.graphics.drawable.Drawable EVMclwjGLzXJcFZX(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static float EWbmoSJBmYdfPhHh(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static int EZtMfCVGEiRElhUM(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getPaddingTop();
    }

    public static void EbGAAiIXPoVcvysx(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCursorColor();
    }

    public static void EclxTOGiUnNYNuDO(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.openCutout();
    }

    public static void EcoxuWlZHqNufZLk(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setBoxStrokeWidth(i);
    }

    public static float EeADtyfpDgWALHSE(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static void EfstvRErQMrEukcD(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setWillNotDraw(z);
    }

    public static int EgwgutlyHSBBXgiJ(com.google.android.material.textfield.TextInputLayout$LengthCounter textInputLayout$LengthCounter, android.text.Editable editable) {
        return textInputLayout$LengthCounter.countLength(editable);
    }

    public static void EiSLLggbTLDtEiQH(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.sendAccessibilityEvent(i);
    }

    public static android.view.objectTreeObserver EjIfIGTGXsQpClwT(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobjectTreeObserver();
    }

    public static void EkiphmZJBTpKeOnm(com.google.android.material.textfield.TextInputLayout textInputLayout, android.view.objectStructure viewStructure, int i) {
        textInputLayout.onProvideAutofillStructure(viewStructure, i);
    }

    public static android.graphics.drawable.Drawable ElhDgsGgLkmyDKYG(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getStartIconDrawable();
    }

    public static void FIaosOkxuOxfLuCS(android.widget.Textobject textobject) {
        textobject.bringToFront();
    }

    public static void FJBUHFTymivDcxLI(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.invalidate();
    }

    public static float FMKrEbiMrFtlsxTN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCollapsedTextHeight();
    }

    public static void FSfVeWdrVshGylKM(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCursorColor();
    }

    public static bool FUMADafNVnnqZgWf(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isEndIconChecked();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel FWdCnMDqhaHFvApR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShapeAppearanceModel();
    }

    public static void FZwGpWKcxrhVytqY(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        endCompoundLayout.setPasswordVisibilityToggleTintMode(porterDuff$Mode);
    }

    public static void FgGeHPsQjTRfzUQp(com.google.android.material.textfield.TextInputLayout textInputLayout, float f) {
        textInputLayout.animateToExpansionFraction(f);
    }

    public static int FhgzbWsXiXcFKqjg(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static android.graphics.drawable.Drawable FimZuPsvUXZvBwaj(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getErrorIconDrawable();
    }

    public static void FkVauzdktSqwVmLB(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static java.lang.CharSequence FwDpAtkWGNBHwezU(android.widget.EditText editText) {
        return editText.getHint();
    }

    public static void GBSJDUGmtMrpMvPM(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateInputLayoutMargins();
    }

    public static void GBzOUCuPwdLYkDCu(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static int GDxPJooStAebcYVZ(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static bool GHzAKsOWHWqwdKdv(android.content.object context) {
        return com.google.android.material.resources.MaterialResources.isFontScaleAtLeast2_0(context);
    }

    public static void GPUsTNKbyMeBcziQ(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setHelperTextEnabled(z);
    }

    public static void GRNYcBCRdUrgnaFW(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.setDropDownMenuBackgroundIfNeeded();
    }

    public static float GSbcevhhyKPSpVCN(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getExpansionFraction();
    }

    public static android.content.object GSdSTsorwxNuSwfc(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static int GfTFHlhGMVqKPgCv(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.Rect rect, android.graphics.Rect rect2, float f) {
        return textInputLayout.calculateExpandedLabelBottom(rect, rect2, f);
    }

    public static int GgpPQZDzgFbizefj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static int GgsrWtQwtYnBhPLp(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void GlvHnyulfzVlGWoK(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.graphics.drawable.Drawable drawable) {
        endCompoundLayout.setErrorIconDrawable(drawable);
    }

    public static bool GlzBfWvJLiKRLrOr(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static float GntDfVEZtzFDEOEy(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f) {
        return tintTypedArray.getDimension(i, f);
    }

    public static void GoTzTQyZGmdiGwBc(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateTextInputBoxState();
    }

    public static bool GptbTRMTWhGyzyvD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static java.lang.CharSequence HAWGUtBfLNZIdJRJ(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getStartIconContentDescription();
    }

    public static void HCYalkjIcmKORhpX(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.closeCutout();
    }

    public static java.lang.CharSequence HFefhQxRexOjPMtn(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.getErrorText();
    }

    public static void HGwjGMtJgzJnUjel(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.recalculateCutout();
    }

    public static void HJihZtSNnMaflZna(android.widget.LinearLayout linearLayout, android.view.objectStructure viewStructure, int i) {
        super.dispatchProvideAutofillStructure(viewStructure, i);
    }

    public static android.content.res.ColorStateList HNcqYHquNSMuZULL(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static android.content.object HQCnbyglurniJnsS(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static androidx.core.text.BidiFormatter HRfzxMqYwHTOUCNh() {
        return androidx.core.text.BidiFormatter.getInstance();
    }

    public static java.lang.CharSequence HVghHnIKDWfscWpH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel HXuivnYmwQROOPPk(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShapeAppearanceModel();
    }

    public static void HbLJIEBuYUgfJvJc(android.widget.LinearLayout linearLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super.addobject(view, i, viewGroup$LayoutParams);
    }

    public static java.lang.CharSequence HddPMdZttohdOvhv(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getPrefixText();
    }

    public static void HeqnmlfZnTQnKrQL(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.collapseHint(z);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder HfnylYpUMFotNcer() {
        return com.google.android.material.shape.ShapeAppearanceModel.builder();
    }

    public static void HgMtvQlBVJxLxHCR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setCollapsedTextGravity(i);
    }

    public static android.widget.Imageobject$ScaleType HgTdmYhfARXgpfzm(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconScaleType();
    }

    public static int HhsDRhSGqjfxbKmh(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static android.content.res.ColorStateList HpmcWCEcLtMwtNLv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void HwbXLXgFMPhBJiZa(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setEndIconContentDescription(i);
    }

    public static java.lang.CharSequence IAoyGBUHYIWwLTHr(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getPrefixText();
    }

    public static void ICvcMLKnEzKbPXDf(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.applyBoxAttributes();
    }

    public static void IDtcnCJhZNNbkvek(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setCollapsedTextGravity(i);
    }

    public static int IIMamwnmlQLcZAeS(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void IOZsVOmUhIFXJrKX(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCounterTextAppearanceAndColor();
    }

    public static void IOtyTMjnwSbnxPBq(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static int ISiYVOyGfuwVOrGD(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.calculateLabelMarginTop();
    }

    public static void ISkujbxggHmmfxak(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setHintInternal(charSequence);
    }

    public static int ITCHRKjTJEOAPAEt(android.widget.Textobject textobject) {
        return textobject.getCurrentTextColor();
    }

    public static android.graphics.drawable.Drawable IVroHMzJGqpLcBSb(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getOrCreateOutlinedDropDownMenuBackground();
    }

    public static android.animation.TimeInterpolator IYsCtdIsjzSrzdrJ(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static bool IdoYesNUMcnfgRhf(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return android.text.TextUtils.Equals(charSequence, charSequence2);
    }

    public static void IfFtNkEyWgcOTNLw(android.widget.LinearLayout linearLayout, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static void IfNPMWOIvBGeEDjd(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect) {
        com.google.android.material.internal.DescendantOffsetUtils.getDescendantRect(viewGroup, view, rect);
    }

    public static com.google.android.material.shape.CornerSize IfmDxcxGapEyBVyh(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static int IgWklsOHFouFrvLV(int i, int i2) {
        return com.google.android.material.color.MaterialColors.layer(i, i2);
    }

    public static android.graphics.drawable.Drawable IirJaQBlTJwrOEBr(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static float ImrddQZErzBUZveG(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static com.google.android.material.shape.MaterialShapeDrawable IpgVBDyftKWQesVL(android.content.object context, float f, android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.shape.MaterialShapeDrawable.createWithElevationOverlay(context, f, colorStateList);
    }

    public static void IqVVWnNGWDtsLiVL(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.hidePlaceholderText();
    }

    public static void IrREZtVGvSGicXCA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.draw(canvas);
    }

    public static com.google.android.material.shape.CornerTreatment IxidanAoZgZbAIzl(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCorner();
    }

    public static void JFiKgTzkbNBvdWHv(com.google.android.material.textfield.TextInputLayout textInputLayout, android.view.object view) {
        textInputLayout.addobject(view);
    }

    public static bool JFjMHZEuIgOiHBQV(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.cutoutEnabled();
    }

    public static java.lang.string JHlqfaSXNEVuTTgE(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void JQEnolnDcposrlTL(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setHint(charSequence);
    }

    public static float JQLNbiMYChzBVSOI(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static bool JdQnShYVZqGoRcsf(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static int JfIyudQIjHDiinbb(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.getHelperTextobjectCurrentTextColor();
    }

    public static bool JlLpntfbaDTssagh(android.widget.EditText editText) {
        return editText.isFocused();
    }

    public static android.content.object JnOaoxuBRErgpeXj(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static int JpSMDaVspCDMQlMv(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void JptBoVbrgXIwpnDq(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setHelperTextTextAppearance(i);
    }

    public static void JrjFqOoegYbHuHhO(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setBoxBackgroundColor(i);
    }

    public static android.content.object JwPPmcpmkcmZXrTc(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static void JxAPzGYqAEjfuQcp(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setPlaceholderText(charSequence);
    }

    public static void JxMbrtaxZFLXmQwL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, int i3, int i4) {
        materialShapeDrawable.setBounds(i, i2, i3, i4);
    }

    public static bool JxOEGskDyylgfWtQ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.shouldShowError();
    }

    public static void JydAXEqCyQHKCtdn(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter) {
        drawable.setColorFilter(colorFilter);
    }

    public static bool JzopSNwKqPXOBONq(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void KAqjdMLdUXrbzTPr(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void KHpHrKRyBCvgRglA(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setHint(charSequence);
    }

    public static java.lang.CharSequence KLHiWXVBJZjRNaxQ(android.widget.EditText editText) {
        return editText.getHint();
    }

    public static int KOEjCvZHaNURWmqA(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconMode();
    }

    public static int KTkNrBAJdMlNGtyn(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void KVeODGJkhDTtdLKl(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static void KfzYKvgtECLDpjQe(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCounterTextAppearanceAndColor();
    }

    public static int KhHKoileJxpjYCYE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getColor(i, i2);
    }

    public static android.content.res.ColorStateList KlILXKAXlovdKvKj(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static int KnDgCnNSwbSlLmQY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void KneoRxxdtzNJmGVZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setExpansionFraction(f);
    }

    public static java.lang.CharSequence KqkxqtLLehOTVKKd(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getPrefixText();
    }

    public static android.content.res.Resources KrRcvJaYhowNMQWx(android.content.object context) {
        return context.getResources();
    }

    public static android.graphics.drawable.Drawable[] KvBintwpKSGsAtnM(android.widget.Textobject textobject) {
        return androidx.core.widget.TextobjectCompat.getCompoundDrawablesRelative(textobject);
    }

    public static void KyjBQPAVzZtyFhcC(android.graphics.RectF rectF, float f, float f2) {
        rectF.offset(f, f2);
    }

    public static android.view.objectStructure LAcjavcJXwhedwCo(android.view.objectStructure viewStructure, int i) {
        return viewStructure.newChild(i);
    }

    public static void LKUxfThaVSDMmMWF(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setExpansionFraction(f);
    }

    public static void LPMbvHNWXRZDmTzM(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static void LVGjrYexOsZyZYio(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateEditTextBackground();
    }

    public static int LWZCbhYWajxhWlkH(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.calculateLabelMarginTop();
    }

    public static android.content.object LbmdlUPryHcCrVCu(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static void LcTaTPHnqoHqtAtr(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.requestLayout();
    }

    public static android.content.res.ColorStateList LdOrmvqEraGjNwmh(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel LdTGrnDsHKdaZjLm(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void LeTUoxolciyjedMK(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.content.res.ColorStateList colorStateList) {
        endCompoundLayout.setPasswordVisibilityToggleTintList(colorStateList);
    }

    public static void LfMHykfoJpwKgsaL(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCounterTextAppearanceAndColor();
    }

    public static android.content.res.ColorStateList LhiHPhdPZBpiaPxO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void LiOWCjEWyweczHME(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static android.graphics.drawable.Drawable LqBkHNcsIoAcovpX(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconDrawable();
    }

    public static void LsdOOQxJvatHINqg(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        androidx.core.view.MarginLayoutParamsCompat.setMarginStart(viewGroup$MarginLayoutParams, i);
    }

    public static void LsuRcMwiTGaJylVs(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setPlaceholderTextEnabled(z);
    }

    public static void LtHvfQIWhGjvLgiD(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        androidx.core.widget.TextobjectCompat.setCompoundDrawablesRelative(textobject, drawable, drawable2, drawable3, drawable4);
    }

    public static bool LucAlUfJSbJMmDMy(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int LwVUsKRXinhsNgOL(android.widget.EditText editText) {
        return editText.getPaddingRight();
    }

    public static bool LxJUrWCQgqAJxAuO(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder LzxGMKwnBpFoIqRi(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setTopLeftCorner(cornerTreatment);
    }

    public static android.content.object MHYtUIYVKJIAxjxd(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder MIOiairyoQYYmwFX(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(f);
    }

    public static bool MIbBnLifsYtsihLS(com.google.android.material.textfield.CutoutDrawable cutoutDrawable) {
        return cutoutDrawable.hasCutout();
    }

    public static void MJmZMKJJSIgsDiNR(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.updateLabelState(z);
    }

    public static float MJqZOGrWfCtUWyEL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBottomLeftCornerResolvedSize();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder MRoODfbSzYpvQwMA(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomRightCorner(i, cornerSize);
    }

    public static void MUwShHDktFetbdsE(android.view.object view, android.view.objectStructure viewStructure, int i) {
        view.dispatchProvideAutofillStructure(viewStructure, i);
    }

    public static com.google.android.material.shape.CornerSize MXxpyfLmNVEDtmXZ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static android.content.res.Resources MZYIbbvfppdciyIC(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static void MaPomzsuEifPpqJB(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setHint(charSequence);
    }

    public static void McGmRizctiXmUjof(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setHint(charSequence);
    }

    public static float MdpWRnZUPpdsTosQ(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static android.view.object MgNZBppzoBLxaFNS(android.widget.FrameLayout frameLayout, int i) {
        return frameLayout.getChildAt(i);
    }

    public static void MkRZazTNuwGizuto(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updatePlaceholderMeasurementsBasedOnEditText();
    }

    public static void MlyLkfpgmqPaCOKt(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setCounterOverflowTextAppearance(i);
    }

    public static void MpngTiSIhoYdkFUa(android.widget.Textobject textobject, int i) {
        textobject.setTextColor(i);
    }

    public static android.graphics.PorterDuffColorFilter MwAqpXiKYYrVNHDa(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.AppCompatDrawableManager.getPorterDuffColorFilter(i, porterDuff$Mode);
    }

    public static void MwvOvlEtXdSSaNZn(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCounterTextAppearanceAndColor();
    }

    public static void MxHsrLnIbOmkxoOr(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.view.object$OnlongClickListener view$OnlongClickListener) {
        startCompoundLayout.setStartIconOnlongClickListener(view$OnlongClickListener);
    }

    public static float MybUGHGmJNjFjsXw(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void NHtpyooHzWOtMYGP(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.togglePasswordVisibilityToggle(z);
    }

    public static android.content.res.ColorStateList NKKOyVBYTqDEFDqe(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static int NKMlWLhELsQlOQsu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static int NNlkpzhVcxsMRBwy(android.text.Editable editable) {
        return editable.Length;
    }

    public static float NNymSATnDGwZLsDh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBottomRightCornerResolvedSize();
    }

    public static android.graphics.Typeface NOejaLsUeihqsaKF(android.widget.EditText editText) {
        return editText.getTypeface();
    }

    public static void NSPsCcUUXvlGBbIQ(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, java.lang.CharSequence charSequence) {
        startCompoundLayout.setStartIconContentDescription(charSequence);
    }

    public static void NUWVRXqgqgxpHhQf(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void NdFZfqxjTQUxVzxL(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, bool z) {
        startCompoundLayout.onHintStateChanged(z);
    }

    public static bool NgCMmBzxfshQFoKm(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isErrorIconVisible();
    }

    public static void NhrXhRJaxAAiHeVq(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setPasswordVisibilityToggleDrawable(i);
    }

    public static void NiChtdZkwJTUWtop(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setErrorEnabled(z);
    }

    public static int NjHdGKZObUteoBDK(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconMinSize();
    }

    public static int NkeCkSSsHhdVYWPY(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.getErrorobjectCurrentTextColor();
    }

    public static android.content.res.Resources NoMQxezdFDurgXmN(android.content.object context) {
        return context.getResources();
    }

    public static int NseiDpkYQTjbKaMX(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static int NvbMTsmIDZueDaiP(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getMeasuredHeight();
    }

    public static bool NwArjLfabddDvIwu(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.content.object NwPdpEwGUXfWqvye(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static void NwpWJNrnpbBVdYRn(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static float OGSzkftUzhNfhctv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f) {
        return tintTypedArray.getDimension(i, f);
    }

    public static bool ORnhRghbTZfSrdfA(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isEnabled();
    }

    public static void OTSqnttwlHUIQRhR(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static void OTpsjoryRZsxNnOT(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.object$OnClickListener view$OnClickListener) {
        endCompoundLayout.setEndIconOnClickListener(view$OnClickListener);
    }

    public static void OUOqOHvSIWHlrxAN(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        indicatorobjectController.adjustIndicatorPadding();
    }

    public static void OXGrHsvLWcAwzYQT(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        collapsingTextHelper.setCollapsedTextColor(colorStateList);
    }

    public static bool OaJXBUNUHOQbXgIy(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.shouldShowError();
    }

    public static bool OaoUXALdzcIDyamc(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.Action runnable) {
        return textInputLayout.post(runnable);
    }

    public static void OfEsqtPwtsDAUhYQ(android.view.object view, bool z) {
        view.setEnabled(z);
    }

    public static bool OjUtHBzwysNykDmt(android.widget.EditText editText) {
        return editText.isFocused();
    }

    public static void OmlpAYmENfLrVfYe(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, bool z) {
        indicatorobjectController.setHelperTextEnabled(z);
    }

    public static void OskSVeSpgqWxGyri(android.view.objectStructure viewStructure, java.lang.CharSequence charSequence) {
        viewStructure.setHint(charSequence);
    }

    public static void OtIyheghMfGpuxyK(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static bool OwMXcVmggbxZROca(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isHelperTextEnabled();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder OyBACXcpZvQorXDT(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(f);
    }

    public static void PBVrBgZfdMorCsZM(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCursorColor();
    }

    public static int PCZoTALoturGAvOn(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getPrefixTextStartOffset();
    }

    public static android.content.res.ColorStateList PFnlzNwVPNzmGKcU(android.content.object context, int i) {
        return com.google.android.material.color.MaterialColors.getColorStateListOrNull(context, i);
    }

    public static android.content.res.Resources PHwLFjvFTPblNGuJ(android.content.object context) {
        return context.getResources();
    }

    public static android.content.res.ColorStateList PKwIrGznEFguDlWW(android.widget.Textobject textobject) {
        return textobject.getTextColors();
    }

    public static void PLfEhExMPNyokyws(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.applyBoxAttributes();
    }

    public static android.graphics.Rect PQMVNTSbxivUhumL(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBounds();
    }

    public static void PWkJFVnsNnJhKxcB(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setEndIconMinSize(i);
    }

    public static java.lang.CharSequence PXFBmQZYOOSXxwOu(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getPasswordVisibilityToggleContentDescription();
    }

    public static void PZqhmesbNumUjRJV(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.Rect rect) {
        textInputLayout.updateBoxUnderlineBounds(rect);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder PbVsblzPQDDYCfJh(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2);
    }

    public static void PbpeXfezrvNfujCU(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.RectF rectF) {
        textInputLayout.applyCutoutPadding(rectF);
    }

    public static void PcHdGMfOvWVOAUON(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static com.google.android.material.shape.CornerSize PedevpSbeJEcIltm(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static android.content.object PguGISFLfupAcxaE(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static android.content.res.Resources PmupRKejDAPJWyIX(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static android.content.res.ColorStateList PyEBJVoepaTXooKs(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static void QCXoiiFxeqAhhuIB(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setMaxEms(i);
    }

    public static void QEqddTULYIjTnlef(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setExpandedTextGravity(i);
    }

    public static java.lang.CharSequence QLqNRZFIhFQnWJLR(android.widget.EditText editText) {
        return editText.getHint();
    }

    public static bool QOfsfFgpbNdlJmfH(android.widget.EditText editText) {
        return editText.isHovered();
    }

    public static void QTPtjkqGipfrGXlQ(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static android.os.Parcelable QgLhMsBJVwdstDkP(com.google.android.material.textfield.TextInputLayout$SavedState textInputLayout$SavedState) {
        return textInputLayout$SavedState.getSuperState();
    }

    public static android.content.res.ColorStateList QgluJUTcOTXXaTiT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void QiOojjGvZbWfdoZh(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, java.lang.CharSequence charSequence) {
        endCompoundLayout.setPasswordVisibilityToggleContentDescription(charSequence);
    }

    public static void QieVQZYEXlUGaNfu(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.onTextInputBoxStateUpdated();
    }

    public static int QocAZiyRFUfHvbWL(android.widget.EditText editText) {
        return editText.getGravity();
    }

    public static android.content.object QrwVGZznDgUIDnfU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static int QuIOJnxewBrtUGct(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static android.content.object QxtuhUXfXsROIkdQ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static android.graphics.drawable.Drawable RBFxobfpZKWmpIJU(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void RROpYDDhxLHEQvOT(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void RRgrLwbfhIxUjsOt(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.graphics.drawable.Drawable drawable) {
        startCompoundLayout.setStartIconDrawable(drawable);
    }

    public static void RSFDMpZFqkPwzIuc(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        collapsingTextHelper.setCollapsedAndExpandedTextColor(colorStateList);
    }

    public static java.lang.CharSequence RTDnCrswnaKmdeeP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static void RWrpdjqlcRsQaRlh(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setHintTextAppearance(i);
    }

    public static int RYjOfsSUaibyVJLf(android.widget.Textobject textobject) {
        return textobject.getVisibility();
    }

    public static android.graphics.drawable.Drawable RbPPTBTGyiflqkll(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getPasswordVisibilityToggleDrawable();
    }

    public static com.google.android.material.textfield.CutoutDrawable RcNpjYxgOJKXHobH(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return com.google.android.material.textfield.CutoutDrawable.create(shapeAppearanceModel);
    }

    public static void RebBaXoaTrXxwyDS(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        androidx.core.widget.TextobjectCompat.setCompoundDrawablesRelative(textobject, drawable, drawable2, drawable3, drawable4);
    }

    public static void RpDyuAXavmeYPfUa(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.updateSuffixTextobjectPadding();
    }

    public static int RqXzOMufYMvmpagG(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static com.google.android.material.shape.CornerSize RtqmEWfwupXeFBFG(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static void RtzDjloIFBzIqnmW(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateTextInputBoxState();
    }

    public static android.widget.Textobject RvMnkRkHHtZuWtZU(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getSuffixTextobject();
    }

    public static void RyOpKWZlhJDoBkoG(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.onHintStateChanged(z);
    }

    public static int SBRiadarsPJzICjw(int i, int i2, float f) {
        return com.google.android.material.animation.AnimationUtils.lerp(i, i2, f);
    }

    public static int SBpoOWrXVmtsjBMm(android.view.object view) {
        return androidx.core.view.objectCompat.getMinimumHeight(view);
    }

    public static void SCePqsfGjKFdJiKf(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void SOFJhommWpkRhAhZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Rect rect) {
        collapsingTextHelper.setCollapsedBounds(rect);
    }

    public static android.content.res.Resources SQotYXBtdVapGAef(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static int SUxuAVkssxmnDxFc(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static android.content.object SWtSaDqNvxAnImtk(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static com.google.android.material.shape.CornerSize SWxEDmRxjkiLhZdH(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static bool SYFANFdOXobownSV(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.isHelperTextEnabled();
    }

    public static void SYdzHGseSoFNjdHt(android.widget.FrameLayout frameLayout, bool z) {
        frameLayout.setAddStatesFromChildren(z);
    }

    public static java.lang.CharSequence SZTvSNSKIHeyAvzC(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getSuffixText();
    }

    public static void SbfFnfACclBFSlEe(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.setEndIconActivated(z);
    }

    public static void ScKtEqPxLDpixxFE(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setCollapsedTextAppearance(i);
    }

    public static bool ScaWvKyZUCpTqJJT(android.widget.EditText editText) {
        return editText.hasFocus();
    }

    public static com.google.android.material.shape.CornerSize SdalTkEnPSWJRzjQ(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static void SeHTwPEhyaISBOAd(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.showPlaceholderText();
    }

    public static int SjSFwOLmeScumZhx(android.view.objectGroup viewGroup) {
        return viewGroup.getChildCount();
    }

    public static android.content.res.ColorStateList SkEJtxoSISuvXFEq(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static com.google.android.material.shape.CornerSize TAeGOJStpTlyEIcN(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static void TAfbMecoJkIrdqcZ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.dispatchOnEditTextAttached();
    }

    public static void TBriKBwerDCWXruG(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        startCompoundLayout.setStartIconTintMode(porterDuff$Mode);
    }

    public static void TEldkWObUqFkexnj(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        endCompoundLayout.setErrorIconTintMode(porterDuff$Mode);
    }

    public static bool TGDmrCNdgVwHdTyN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void TGTJdPAeDlyQhdGU(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, bool z) {
        startCompoundLayout.setStartIconCheckable(z);
    }

    public static void TMTnDokYEfAKllLv(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static android.content.res.Resources TOgnfSyLiiPoJLNI(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder TQdpegBfIxbqIpHY(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(f);
    }

    public static int TSmwiBZnzqHbxQci(android.widget.EditText editText) {
        return editText.getCompoundPaddingBottom();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel TVbvksYcmVpmHqPd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static android.graphics.drawable.Drawable TVlrJBUhWTQDXrUZ(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static float TXwroFbZCGmNVskM(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static float TZEEXjksIyvqZRJC(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCollapsedTextHeight();
    }

    public static void TbJymRYcmEMlCYrS(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updatePlaceholderText();
    }

    public static int TbZDAdRxVUtOdEOD(android.graphics.Rect rect) {
        return rect.centerX();
    }

    public static int TeOAiedgnGhaYBtJ(android.graphics.Rect rect) {
        return rect.centerY();
    }

    public static bool TnoCjuGMrtibwNlY(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.hasEndIcon();
    }

    public static void ToHbSSPwgCvneirl(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setErrorEnabled(z);
    }

    public static android.content.object TrXjitWGBIxmBoPZ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static androidx.transition.Transition TvfbflHkJklOyUdg(androidx.transition.Fade fade, long j) {
        return fade.setStartDelay(j);
    }

    public static void TyoVYutpjdMcphYy(com.google.android.material.textfield.TextInputLayout textInputLayout, android.content.res.ColorStateList colorStateList) {
        textInputLayout.setPlaceholderTextColor(colorStateList);
    }

    public static int UBmYQFziwRFRkVmS(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static androidx.appcompat.widget.TintTypedArray UGivPaGoIvDCwnon(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainTintedStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static float UJIiZvkTiXSxXsVm(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getExpansionFraction();
    }

    public static int ULRmgstkFnRojxdq(com.google.android.material.textfield.TextInputLayout textInputLayout, int i, bool z) {
        return textInputLayout.getLabelRightBoundAlignedWithPrefixAndSuffix(i, z);
    }

    public static void ULdcYbSCwswYTAzI(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setEndIconMode(i);
    }

    public static int UMBqQIWFbdXogfOh(android.widget.EditText editText) {
        return editText.getCompoundPaddingLeft();
    }

    public static void UNhqosPxqCFfEIGp(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setMinEms(i);
    }

    public static void UOlyLEvmpsPUsSaX(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setCounterTextAppearance(i);
    }

    public static android.content.object URfvAQMvRElXwsow(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static int UXNedjRvoVfifCmQ(android.widget.EditText editText) {
        return editText.getCompoundPaddingLeft();
    }

    public static java.lang.string UYIROaGgJkPkaoSb(android.content.object context, int i, java.lang.object[] objArr) {
        return context.getstring(i, objArr);
    }

    public static int UZwgjyMYlxHInsjH(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getPrefixTextStartOffset();
    }

    public static void UdHRlVfkcvhhmlLw(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface) {
        collapsingTextHelper.setTypefaces(typeface);
    }

    public static float UdlByqUoHIeqTVtv(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static void UglVneIbqGGOsiGd(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.refreshStartIconDrawableState();
    }

    public static int UgoAADirjIzlorwa(android.widget.EditText editText) {
        return editText.getGravity();
    }

    public static android.os.Parcelable UqvRnifqRBGlFzSu(android.widget.LinearLayout linearLayout) {
        return super.onSaveInstanceState();
    }

    public static void UrDEFtUxCXIlnVaW(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.setEndIconCheckable(z);
    }

    public static java.lang.int UxjrUDEGeorgLTtE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int UyDwrzyGitWVFmxq(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getPaddingLeft();
    }

    public static void VGujESwYOCIGmUxD(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateInputLayoutMargins();
    }

    public static void VIZsHSrIYJqpNMFO(com.google.android.material.textfield.TextInputLayout textInputLayout, android.content.res.ColorStateList colorStateList) {
        textInputLayout.setPlaceholderTextColor(colorStateList);
    }

    public static void VIsdWkZvrcuxAveT(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static bool VXZufpsbbeXMrrMF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static android.graphics.drawable.Drawable VYNycdoxCySZESXP(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        return autoCompleteTextobject.getDropDownBackground();
    }

    public static android.content.res.ColorStateList VYPrXhJpAaKcaAjK(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getDropDownBackgroundTintList();
    }

    public static void VZNgbrjWpqaBarMU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Canvas canvas) {
        collapsingTextHelper.draw(canvas);
    }

    public static void VaqtIygGNpkLIDuP(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCounter();
    }

    public static int VcEnHohpVRSLaoLi(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void VcsHdBlUITCMUvMW(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        indicatorobjectController.hideError();
    }

    public static bool VdCWMjnxxlNEvurG(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.canDrawStroke();
    }

    public static void VhBrexXeGlmPYalG(android.widget.LinearLayout linearLayout, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder VhdknYprcguVIfuZ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(f);
    }

    public static void VpWhMJTiUoipveFs(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setContentDescription(charSequence);
    }

    public static void VpyqyxNTCDMzHsjC(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.animation.TimeInterpolator timeInterpolator) {
        collapsingTextHelper.setPositionInterpolator(timeInterpolator);
    }

    public static void VqaKgYOagCSLCAMU(com.google.android.material.textfield.TextInputLayout textInputLayout, android.content.res.ColorStateList colorStateList) {
        textInputLayout.setCounterTextColor(colorStateList);
    }

    public static int VuGUifTjzbVVwTEq(android.widget.EditText editText) {
        return editText.getCompoundPaddingRight();
    }

    public static int VwDFekEEnDkLomSD(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getColor(context, i);
    }

    public static bool WDfpyQLTXRHQvKae(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static android.graphics.drawable.Drawable WIwwyRJGzpFWgKfp(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, int[][] iArr) {
        return getFilledBoxBackgroundWithRipple(materialShapeDrawable, i, i2, iArr);
    }

    public static android.content.res.Resources WJzyPMLVVTDPUlUh(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static void WPqoZifWhONECzsZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setExpandedTextSize(f);
    }

    public static void WayWzFaARQSAUuNA(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.graphics.Typeface typeface) {
        indicatorobjectController.setTypefaces(typeface);
    }

    public static bool WcKugwgeHlnRTbAG(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int WdcFPeUJmWOOWatJ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getErrorCurrentTextColors();
    }

    public static bool WeXNwtqkOmguyaQO(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isEnabled();
    }

    public static java.lang.int WiasakTobxtkQudN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void WktUooJnRfpgjzUo(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.updateSuffixTextobjectPadding();
    }

    public static int WrhKnqnSjWLNCREf(android.widget.EditText editText) {
        return editText.getCompoundPaddingTop();
    }

    public static int WvqeNIjmUGwmFnbO(android.widget.EditText editText) {
        return editText.getGravity();
    }

    public static android.content.res.ColorStateList WxHqwlKGchtwFHTx(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static bool XCDBxUTNHOCiCRKQ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void XFPMUZDFTQWoviYO(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        endCompoundLayout.setEndIconTintMode(porterDuff$Mode);
    }

    public static void XGsQAPgZsBetjwXQ(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        startCompoundLayout.refreshStartIconDrawableState();
    }

    public static android.widget.Textobject XHXMQAQKjjnItbpn(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getSuffixTextobject();
    }

    public static void XPgYMYOPSBKJGyHR(com.google.android.material.textfield.TextInputLayout textInputLayout, float f, float f2, float f3, float f4) {
        textInputLayout.setBoxCornerRadii(f, f2, f3, f4);
    }

    public static android.content.res.Resources XSNQLXehYvTEHaCX(android.content.object context) {
        return context.getResources();
    }

    public static float XSUbddaZTTAyBlin(android.widget.EditText editText) {
        return editText.getLetterSpacing();
    }

    public static void XVnInNHIOQZFdSId(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updatePlaceholderText();
    }

    public static void XYMKwrlAQLwqLIsQ(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.content.res.ColorStateList colorStateList) {
        indicatorobjectController.setErrorobjectTextColor(colorStateList);
    }

    public static void XZdwkcfFTGPDQBbR(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        collapsingTextHelper.setCollapsedAndExpandedTextColor(colorStateList);
    }

    public static android.graphics.Rect XbnvkqMCXmLiZkWo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBounds();
    }

    public static android.text.Editable XeDKGFxyBqQWghZM(android.widget.EditText editText) {
        return editText.getText();
    }

    public static float XhiTkPHtnVjzTKEL(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static int XmNhcnGudYuGPonf(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.content.res.Resources XnBDCttuedkkFCSl(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static void XnmLuYDhGlYWZbGd(com.google.android.material.textfield.TextInputLayout textInputLayout, android.content.res.ColorStateList colorStateList) {
        textInputLayout.setErrorTextColor(colorStateList);
    }

    public static android.graphics.drawable.Drawable XoLPWgayqwlOQmRx(android.widget.EditText editText) {
        return editText.getBackground();
    }

    public static bool XxcqXUkOGJJeMvYP(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.isErrorEnabled();
    }

    public static void YDqRDKnTWPbcMQYS(com.google.android.material.textfield.CutoutDrawable cutoutDrawable) {
        cutoutDrawable.removeCutout();
    }

    public static void YEaINQkqTCsbFYko(android.widget.Textobject textobject, android.graphics.Typeface typeface) {
        textobject.setTypeface(typeface);
    }

    public static bool YGXMtFRfRgmdThHa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void YJnVAblsTRwfsZwl(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.graphics.drawable.Drawable drawable) {
        autoCompleteTextobject.setDropDownBackgroundDrawable(drawable);
    }

    public static void YLFFZyVSdUYRzumK(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.applyBoxAttributes();
    }

    public static int YUshsfJgwHIMuFzi(android.widget.LinearLayout linearLayout) {
        return super.getBaseline();
    }

    public static void YVXHkNFtjtwniuwg(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.updateLabelState(z);
    }

    public static android.content.res.Resources YVjBsECVVBWvBLnz(android.content.object context) {
        return context.getResources();
    }

    public static void YWPiyhvBIWKKzXvS(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.setPasswordVisibilityToggleEnabled(z);
    }

    public static void YWpZbgZxgLxlYGBx(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.refreshEndIconDrawableState();
    }

    public static int YckeczxzYaKTKOIo(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getSuffixTextEndOffset();
    }

    public static bool YeQiFhQUZKXcyrnU(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void YefSfLJKyytXMMhK(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setPlaceholderTextAppearance(i);
    }

    public static void YehlwbFpOAUQjyos(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void YfZzAJsFKcatqUdU(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.Canvas canvas) {
        textInputLayout.drawHint(canvas);
    }

    public static com.google.android.material.shape.CornerSize YkGMTnPopJyRxpMH(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static void YkqZWghFthccbANH(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setErrorContentDescription(charSequence);
    }

    public static bool YoBwNRAfqFbBtAyA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static java.lang.CharSequence YoxhBwDOHRnYfUrt(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getPrefixText();
    }

    public static void YsSJdwKiEnhTGkcI(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setHint(charSequence);
    }

    public static bool YtjOUdOgKdrRIzCX(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.cutoutEnabled();
    }

    public static void ZCzQYaOcVGKiUsLT(android.widget.Textobject textobject, int i) {
        textobject.setId(i);
    }

    public static bool ZEYvCYESYsbATZXd(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isOnError();
    }

    public static android.widget.Textobject ZGIehuTcQkWSMkxU(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getPrefixTextobject();
    }

    public static int ZGeCBQZyOkWTdcWG(android.widget.EditText editText) {
        return editText.getPaddingLeft();
    }

    public static bool ZJGsDqoPbduSQDZS(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isOnError();
    }

    public static android.content.res.Resources ZMdDRKRXjlGXHZIP(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static android.graphics.drawable.Drawable ZRPVtmCotJsEnhQv(android.widget.EditText editText) {
        return editText.getTextCursorDrawable();
    }

    public static int ZUstqmuuOpSMYiar(com.google.android.material.textfield.TextInputLayout textInputLayout, int i, bool z) {
        return textInputLayout.getLabelLeftBoundAlignedWithPrefixAndSuffix(i, z);
    }

    public static void ZcqyyavjZcUeMTwN(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.applyBoxAttributes();
    }

    public static bool ZdslwOvkfyUnWeuH(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static int ZgCEdHVaTubQeomK(com.google.android.material.textfield.TextInputLayout textInputLayout, int i, bool z) {
        return textInputLayout.getLabelLeftBoundAlignedWithPrefixAndSuffix(i, z);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel ZgHALNFsxKVvqdGw(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShapeAppearanceModel();
    }

    public static int ZhqJHwBOWEXOZVAA(android.widget.EditText editText) {
        return editText.getMeasuredHeight();
    }

    public static int ZrOnOAEsLUUCAbXH(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static java.lang.CharSequence ZxChdpIwtpTWPlQW(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.getErrorContentDescription();
    }

    public static int AAhTgVzKtEnBNxof(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void ABVppIhKuYzkpEeM(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.updateLabelState(z);
    }

    public static int ADCoHNGyznVOVrlx(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void ADYinzZdISrRwOyS(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        androidx.core.widget.TextobjectCompat.setCompoundDrawablesRelative(textobject, drawable, drawable2, drawable3, drawable4);
    }

    public static void ADemApxZUPQmxVBK(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, java.lang.CharSequence charSequence) {
        indicatorobjectController.setErrorContentDescription(charSequence);
    }

    public static void AFlUMkfKaEHwIQQY(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateBoxCollapsedPaddingTop();
    }

    public static int AGECOmdXdpSTMErA(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static bool AIbMOYJVZkBslPmB(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.cutoutEnabled();
    }

    public static int AIrQwDVmkFmENRfK(com.google.android.material.textfield.TextInputLayout textInputLayout, int i, bool z) {
        return textInputLayout.getLabelRightBoundAlignedWithPrefixAndSuffix(i, z);
    }

    public static void APeMMtAQBclhZEBx(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.openCutout();
    }

    public static java.util.IEnumerator ARDzZXFBlVneuukg(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static int[] ASTQNEDTuwctFsko(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getDrawableState();
    }

    public static void AUzwMlwpeiXGViJE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder abvFHQwoNEFAWcmd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setTopRightCorner(cornerTreatment);
    }

    public static int AcNChpEfPXDswNIu(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    static bool access$000(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.restoringSavedState;
    }

    static bool access$100(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.placeholderEnabled;
    }

    static void access$200(com.google.android.material.textfield.TextInputLayout textInputLayout, android.text.Editable editable) {
        rqEdJOJZDuQRRIQN(textInputLayout, editable);
    }

    static com.google.android.material.textfield.EndCompoundLayout access$300(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.endLayout;
    }

    static com.google.android.material.textfield.StartCompoundLayout access$400(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.startLayout;
    }

    static com.google.android.material.textfield.IndicatorobjectController access$500(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.indicatorobjectController;
    }

    public static android.content.res.Resources AcpEPiRbVwohZYor(android.content.object context) {
        return context.getResources();
    }

    private void AddPlaceholderTextobject() {
        if ((15 + 10) % 10 > 0) {
        }
        android.widget.Textobject textobject = this.placeholderTextobject;
        if (textobject is null) {
            return;
        }
        agdSbRofpnillnAt(this.inputFrame, textobject);
        FkVauzdktSqwVmLB(this.placeholderTextobject, 0);
    }

    private void AdjustFilledEditTextPaddingForLargeFont() {
        if ((14 + 25) % 25 > 0) {
        }
        if (this.editText is not null && this.boxBackgroundMode == 1) {
            if (lLibHQpTjvDzIOfj(LbmdlUPryHcCrVCu(this))) {
                android.widget.EditText editText = this.editText;
                GBzOUCuPwdLYkDCu(editText, jnQrEQhaRCApCbjA(editText), nUtzpzGtTXZHBtfy(PmupRKejDAPJWyIX(this), com.google.android.material.R$dimen.material_filled_edittext_font_2_0_padding_top), FhgzbWsXiXcFKqjg(this.editText), fAVeWNKpUSsFzuoG(ZMdDRKRXjlGXHZIP(this), com.google.android.material.R$dimen.material_filled_edittext_font_2_0_padding_bottom));
            } else if (ezMhrhgYEqiusUum(lpkjjvRwmOuGnbMf(this))) {
                android.widget.EditText editText2 = this.editText;
                VIsdWkZvrcuxAveT(editText2, lKFXxdQIoHkoPRtY(editText2), DVzmzhBTlaZewVkx(WJzyPMLVVTDPUlUh(this), com.google.android.material.R$dimen.material_filled_edittext_font_1_3_padding_top), ucJSPgayEfGEbRLB(this.editText), ClsZmWxPPVKbMeFw(rWIHxvCHPUTSAKJQ(this), com.google.android.material.R$dimen.material_filled_edittext_font_1_3_padding_bottom));
            }
        }
    }

    public static void AgYUeXPVpFIxGuyv(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setHelperTextEnabled(z);
    }

    public static void AgdSbRofpnillnAt(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static void AiHiGGcIKbrSbnat(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setMinWidth(i);
    }

    public static int AihsxnpeikiaVomw(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static android.view.objectGroup$LayoutParams amCBxVjAqdjailgH(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void AnbXLoAkpGjGMwQz(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    private void ApplyBoxAttributes() {
        if ((16 + 11) % 11 > 0) {
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.boxBackground;
        if (materialShapeDrawable is not null) {
            com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelFWdCnMDqhaHFvApR = FWdCnMDqhaHFvApR(materialShapeDrawable);
            com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel = this.shapeAppearanceModel;
            if (shapeAppearanceModelFWdCnMDqhaHFvApR != shapeAppearanceModel) {
                LiOWCjEWyweczHME(this.boxBackground, shapeAppearanceModel);
            }
            if (zhXDzlndPvdNHGby(this)) {
                zARvtoXjoltYimqK(this.boxBackground, this.boxStrokeWidthPx, this.boxStrokeColor);
            }
            int iBKgnHOqznEkmFYEj = bKgnHOqznEkmFYEj(this);
            this.boxBackgroundColor = iBKgnHOqznEkmFYEj;
            fexwXQGdMvoqQbbm(this.boxBackground, kRrCzVxsbpyrROLq(iBKgnHOqznEkmFYEj));
            DvvdWyPZIcHgkifw(this);
            hyDHhPTwxjQqNXuW(this);
        }
    }

    private void ApplyBoxUnderlineAttributes() {
        if ((23 + 5) % 5 > 0) {
        }
        if (this.boxUnderlineDefault is null || this.boxUnderlineFocused is null) {
            return;
        }
        if (VdCWMjnxxlNEvurG(this)) {
            BVNZGZaKYmTiUSYl(this.boxUnderlineDefault, !JlLpntfbaDTssagh(this.editText) ? KlILXKAXlovdKvKj(this.boxStrokeColor) : SkEJtxoSISuvXFEq(this.defaultStrokeColor));
            jUudzCPPGeNqgwTJ(this.boxUnderlineFocused, NKKOyVBYTqDEFDqe(this.boxStrokeColor));
        }
        FJBUHFTymivDcxLI(this);
    }

    private void ApplyCutoutPadding(android.graphics.RectF rectF) {
        if ((20 + 17) % 17 > 0) {
        }
        rectF.left -= this.boxLabelCutoutPaddingPx;
        rectF.right += this.boxLabelCutoutPaddingPx;
    }

    public static void ArRJdvhTNJazOyZh(android.view.objectGroup viewGroup, androidx.transition.Transition transition) {
        androidx.transition.TransitionManager.beginDelayedTransition(viewGroup, transition);
    }

    private void AssignBoxBackgroundByMode() {
        if ((12 + 29) % 29 > 0) {
        }
        int i = this.boxBackgroundMode;
        if (i == 0) {
            this.boxBackground = null;
            this.boxUnderlineDefault = null;
            this.boxUnderlineFocused = null;
        } else if (i == 1) {
            this.boxBackground = new com.google.android.material.shape.MaterialShapeDrawable(this.shapeAppearanceModel);
            this.boxUnderlineDefault = new com.google.android.material.shape.MaterialShapeDrawable();
            this.boxUnderlineFocused = new com.google.android.material.shape.MaterialShapeDrawable();
        } else {
            if (i != 2) {
                throw new java.lang.IllegalArgumentException(AOdhSlRboaZIEQPr(xAghBpvTtuahZUSh(ohvbIofwOYcRruWd(new java.lang.stringBuilder(), this.boxBackgroundMode), " is illegal; only @BoxBackgroundMode constants are supported.")));
            }
            if (this.hintEnabled && !(this.boxBackground is com.google.android.material.textfield.CutoutDrawable)) {
                this.boxBackground = RcNpjYxgOJKXHobH(this.shapeAppearanceModel);
            } else {
                this.boxBackground = new com.google.android.material.shape.MaterialShapeDrawable(this.shapeAppearanceModel);
            }
            this.boxUnderlineDefault = null;
            this.boxUnderlineFocused = null;
        }
    }

    public static void AwOIaQalJrmvHEce(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.content.res.ColorStateList colorStateList) {
        endCompoundLayout.setSuffixTextColor(colorStateList);
    }

    public static void AwlgDhmzxrqQHzpK(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        indicatorobjectController.setErrorAccessibilityLiveRegion(i);
    }

    public static void AyXTlZIQLiXovRkp(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setPlaceholderTextEnabled(z);
    }

    public static int AywRdgcrtXAFaFSM(android.widget.EditText editText) {
        return editText.getBaseline();
    }

    public static void BABeKxdfEOEhjRGQ(android.widget.Textobject textobject, int i) {
        textobject.setGravity(i);
    }

    public static bool BDvVxOzrWQZdtkVw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static int BKgnHOqznEkmFYEj(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.calculateBoxBackgroundColor();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder bMGDNFwRpBIYvikm(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static bool BNbKSYbijPuUFRhK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void BPHZLnAEwAqAzYWE(com.google.android.material.textfield.TextInputLayout textInputLayout, android.text.Editable editable) {
        textInputLayout.updateCounter(editable);
    }

    public static bool BPyGUqPaiNHSBNgK(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.shouldShowError();
    }

    public static void BQoJsUrnaOEJvmiY(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setHint(charSequence);
    }

    public static void BRxlVbzYjzVjGvjk(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void BTzZetuwHYBnAcLV(android.view.objectGroup viewGroup, bool z) {
        recursiveHashSetEnabled(viewGroup, z);
    }

    public static int BWwIpErxOmiNkRcy(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getColor(context, i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder bYHDrnaKxAErlkxJ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(f);
    }

    public static int BYeJYPtMlKXEQTMk(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.object BbstkBTbdkmPXFCF(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void BdtgocXuJoDNvXwr(android.view.objectGroup viewGroup, androidx.transition.Transition transition) {
        androidx.transition.TransitionManager.beginDelayedTransition(viewGroup, transition);
    }

    public static void BmJSUDSKyrFbJdCn(com.google.android.material.textfield.TextInputLayout$OnEditTextAttachedListener textInputLayout$OnEditTextAttachedListener, com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout$OnEditTextAttachedListener.onEditTextAttached(textInputLayout);
    }

    public static androidx.transition.Fade BnATFaVtgdkGIZkR(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.createPlaceholderFadeTransition();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder bqKGABCiOpyuehIB(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(f);
    }

    public static java.lang.CharSequence CGUdNInkPfDRxwta(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static void CXryzsRJebzdgHZy(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.object$OnlongClickListener view$OnlongClickListener) {
        endCompoundLayout.setEndIconOnlongClickListener(view$OnlongClickListener);
    }

    private int CalculateBoxBackgroundColor() {
        if ((24 + 22) % 22 > 0) {
        }
        return this.boxBackgroundMode != 1 ? this.boxBackgroundColor : IgWklsOHFouFrvLV(jEdoIXwudCiZCAZI(this, com.google.android.material.R$attr.colorSurface, 0), this.boxBackgroundColor);
    }

    private android.graphics.Rect CalculateCollapsedTextBounds(android.graphics.Rect rect) {
        if ((13 + 27) % 27 > 0) {
        }
        if (this.editText is null) {
            throw new java.lang.IllegalStateException();
        }
        android.graphics.Rect rect2 = this.tmpBoundsRect;
        bool zBZTPUIAJwiRjVCqB = BZTPUIAJwiRjVCqB(this);
        rect2.bottom = rect.bottom;
        int i = this.boxBackgroundMode;
        if (i == 1) {
            rect2.left = ZgCEdHVaTubQeomK(this, rect.left, zBZTPUIAJwiRjVCqB);
            rect2.top = rect.top + this.boxCollapsedPaddingTopPx;
            rect2.right = aIrQwDVmkFmENRfK(this, rect.right, zBZTPUIAJwiRjVCqB);
            return rect2;
        }
        if (i == 2) {
            rect2.left = rect.left + ZGeCBQZyOkWTdcWG(this.editText);
            rect2.top = rect.top - ISiYVOyGfuwVOrGD(this);
            rect2.right = rect.right - cneOuglwrSutoqDS(this.editText);
            return rect2;
        }
        rect2.left = ZUstqmuuOpSMYiar(this, rect.left, zBZTPUIAJwiRjVCqB);
        rect2.top = EZtMfCVGEiRElhUM(this);
        rect2.right = ULRmgstkFnRojxdq(this, rect.right, zBZTPUIAJwiRjVCqB);
        return rect2;
    }

    private int CalculateExpandedLabelBottom(android.graphics.Rect rect, android.graphics.Rect rect2, float f) {
        return !wJkuPpRyUYntbxFj(this) ? rect.bottom - TSmwiBZnzqHbxQci(this.editText) : (int) (rect2.top + f);
    }

    private int CalculateExpandedLabelTop(android.graphics.Rect rect, float f) {
        return !onFQnLnTFIisAOgU(this) ? rect.top + oBxHgqGijZCJbgxq(this.editText) : (int) (TeOAiedgnGhaYBtJ(rect) - (f / 2.0f));
    }

    private android.graphics.Rect CalculateExpandedTextBounds(android.graphics.Rect rect) {
        if ((24 + 14) % 14 > 0) {
        }
        if (this.editText is null) {
            throw new java.lang.IllegalStateException();
        }
        android.graphics.Rect rect2 = this.tmpBoundsRect;
        float fMcXXAGrePyyenAAh = mcXXAGrePyyenAAh(this.collapsingTextHelper);
        rect2.left = rect.left + UXNedjRvoVfifCmQ(this.editText);
        rect2.top = yfnezavLHAsoccoW(this, rect, fMcXXAGrePyyenAAh);
        rect2.right = rect.right - VuGUifTjzbVVwTEq(this.editText);
        rect2.bottom = GfTFHlhGMVqKPgCv(this, rect, rect2, fMcXXAGrePyyenAAh);
        return rect2;
    }

    private int CalculateLabelMarginTop() {
        float fVBgdADZWWbuXfjPa;
        if ((28 + 22) % 22 > 0) {
        }
        if (!this.hintEnabled) {
            return 0;
        }
        int i = this.boxBackgroundMode;
        if (i == 0) {
            fVBgdADZWWbuXfjPa = vBgdADZWWbuXfjPa(this.collapsingTextHelper);
        } else {
            if (i != 2) {
                return 0;
            }
            fVBgdADZWWbuXfjPa = FMKrEbiMrFtlsxTN(this.collapsingTextHelper) / 2.0f;
        }
        return (int) fVBgdADZWWbuXfjPa;
    }

    private bool CanDrawOutlineStroke() {
        if ((1 + 9) % 9 > 0) {
        }
        return this.boxBackgroundMode == 2 && hCJFhhyWnZHTfgxO(this);
    }

    private bool CanDrawStroke() {
        if ((12 + 21) % 21 > 0) {
        }
        return this.boxStrokeWidthPx > -1 && this.boxStrokeColor != 0;
    }

    public static void CgKRJwLMzJvCrDpo(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setErrorAccessibilityLiveRegion(i);
    }

    public static void ChQLDXzZgYKhgayE(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.announceForAccessibility(charSequence);
    }

    public static int CiVWUxgSFIudOGIH(android.widget.EditText editText) {
        return editText.getWidth();
    }

    public static void CkrifaJCOvBybgxH(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z, bool z2) {
        textInputLayout.updateLabelState(z, z2);
    }

    private void CloseCutout() {
        if (pHAFHSNzmnDhVjAt(this)) {
            YDqRDKnTWPbcMQYS((com.google.android.material.textfield.CutoutDrawable) this.boxBackground);
        }
    }

    public static int CneOuglwrSutoqDS(android.widget.EditText editText) {
        return editText.getPaddingRight();
    }

    private void CollapseHint(bool z) {
        android.animation.ValueAnimator valueAnimator = this.animator;
        if (valueAnimator is not null && yazyjGXtsxGNcKCp(valueAnimator)) {
            SCePqsfGjKFdJiKf(this.animator);
        }
        if (z && this.hintAnimationEnabled) {
            FgGeHPsQjTRfzUQp(this, 1.0f);
        } else {
            LKUxfThaVSDMmMWF(this.collapsingTextHelper, 1.0f);
        }
        this.hintExpanded = false;
        if (JFjMHZEuIgOiHBQV(this)) {
            aPeMMtAQBclhZEBx(this);
        }
        TbJymRYcmEMlCYrS(this);
        NdFZfqxjTQUxVzxL(this.startLayout, false);
        BrqVqSKITijWoSOR(this.endLayout, false);
    }

    public static int CpyMVtEzqVavsWIG(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getMeasuredWidth();
    }

    private androidx.transition.Fade CreatePlaceholderFadeTransition() {
        if ((32 + 8) % 8 > 0) {
        }
        androidx.transition.Fade fade = new androidx.transition.Fade();
        pqJSrozjiimTftHv(fade, ugIlgurJghVbfXOW(eoFFErtDRouketKm(this), com.google.android.material.R$attr.motionDurationshort2, 87));
        szCgMvOjGSMWoMpo(fade, IYsCtdIsjzSrzdrJ(yrnObKsiPwPqoKwj(this), com.google.android.material.R$attr.motionEasingLinearInterpolator, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR));
        return fade;
    }

    private bool CutoutEnabled() {
        return this.hintEnabled && !JzopSNwKqPXOBONq(this.hint) && (this.boxBackground is com.google.android.material.textfield.CutoutDrawable);
    }

    public static bool DAhOsdIFjCyeBeRk(android.widget.EditText editText, java.lang.Action runnable) {
        return editText.post(runnable);
    }

    public static void DECwfMVzKfZsaSIM(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setHint(charSequence);
    }

    public static void DHFISCHvESFCONwo(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void DVnFPPhseQHcsFWL(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.applyBoxAttributes();
    }

    public static void DWlUcjItgsdGvydt(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static bool DXpihocvMesDhcXF(android.content.object context) {
        return com.google.android.material.resources.MaterialResources.isFontScaleAtLeast1_3(context);
    }

    public static void DYUBbSNCUuWySDih(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    private void DispatchOnEditTextAttached() {
        if ((13 + 31) % 31 > 0) {
        }
        java.util.IEnumerator itARDzZXFBlVneuukg = aRDzZXFBlVneuukg(this.editTextAttachedListeners);
        while (TGDmrCNdgVwHdTyN(itARDzZXFBlVneuukg)) {
            bmJSUDSKyrFbJdCn((com.google.android.material.textfield.TextInputLayout$OnEditTextAttachedListener) bbstkBTbdkmPXFCF(itARDzZXFBlVneuukg), this);
        }
    }

    public static com.google.android.material.shape.CornerSize DosmRRxzAqiiLLQr(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    private void DrawBoxUnderline(android.graphics.Canvas canvas) {
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable;
        if ((32 + 27) % 27 > 0) {
        }
        if (this.boxUnderlineFocused is null || (materialShapeDrawable = this.boxUnderlineDefault) is null) {
            return;
        }
        IrREZtVGvSGicXCA(materialShapeDrawable, canvas);
        if (OjUtHBzwysNykDmt(this.editText)) {
            android.graphics.Rect rectPQMVNTSbxivUhumL = PQMVNTSbxivUhumL(this.boxUnderlineFocused);
            android.graphics.Rect rectXbnvkqMCXmLiZkWo = XbnvkqMCXmLiZkWo(this.boxUnderlineDefault);
            float fBzZwjsZVEefzBFUj = BzZwjsZVEefzBFUj(this.collapsingTextHelper);
            int iTbZDAdRxVUtOdEOD = TbZDAdRxVUtOdEOD(rectXbnvkqMCXmLiZkWo);
            rectPQMVNTSbxivUhumL.left = SBRiadarsPJzICjw(iTbZDAdRxVUtOdEOD, rectXbnvkqMCXmLiZkWo.left, fBzZwjsZVEefzBFUj);
            rectPQMVNTSbxivUhumL.right = nfBrVrfZWtAxhTNY(iTbZDAdRxVUtOdEOD, rectXbnvkqMCXmLiZkWo.right, fBzZwjsZVEefzBFUj);
            mheOtCeZGGaitEmQ(this.boxUnderlineFocused, canvas);
        }
    }

    private void DrawHint(android.graphics.Canvas canvas) {
        if (this.hintEnabled) {
            VZNgbrjWpqaBarMU(this.collapsingTextHelper, canvas);
        }
    }

    public static void DrjXyRFEIDPIDjBB(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        androidx.core.widget.TextobjectCompat.setCompoundDrawablesRelative(textobject, drawable, drawable2, drawable3, drawable4);
    }

    public static void DypMcCLJghCjacov(android.widget.EditText editText, int i) {
        editText.setMaxWidth(i);
    }

    public static void EDaKfxrHCJrpNLlI(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static void EGRbVCUKSimzUSmj(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        startCompoundLayout.setStartIconScaleType(imageobject$ScaleType);
    }

    public static void EHOBjgFKoUsWNsmD(com.google.android.material.textfield.TextInputLayout textInputLayout, android.text.Editable editable) {
        textInputLayout.updateCounter(editable);
    }

    public static java.lang.CharSequence EIHgTKmQYfSKolZN(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.getHelperText();
    }

    public static void ELupAUPWACOxfRYJ(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setCounterEnabled(z);
    }

    public static android.content.res.ColorStateList ENYssxaAqtcZPVmF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static int ENjcjnOtXOKfueJT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder eQFXroMpXuaFPDrF(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopLeftCorner(i, cornerSize);
    }

    public static bool ETnduNRFMluGJhlh(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static float EUykAonhGpmqlNNf(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static bool EYXowIgyxICieLWM(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isEnabled();
    }

    public static android.content.res.ColorStateList EbnymZkcCjwcHFEL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void EfdfoOrBQUPRCtrV(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.expandHint(z);
    }

    public static java.lang.CharSequence ElbeNwhVBzhCUdVV(android.widget.Textobject textobject) {
        return textobject.getContentDescription();
    }

    public static void EllrvYXknwIMVvzv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, int i3, int i4) {
        materialShapeDrawable.setBounds(i, i2, i3, i4);
    }

    public static int EloOKTFriPyFPpMY(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return androidx.core.view.MarginLayoutParamsCompat.getMarginStart(viewGroup$MarginLayoutParams);
    }

    public static void EnmVsAZvkQMDBGpS(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        collapsingTextHelper.setCollapsedTextColor(colorStateList);
    }

    public static android.content.object EoFFErtDRouketKm(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static void EppgrpIGTGLPstiZ(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.setEndIconVisible(z);
    }

    public static bool EsnmSqsUBONPhgyK(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.isHelperTextEnabled();
    }

    public static float EuqpneFiqfvMQGYK(android.widget.EditText editText) {
        return editText.getTextSize();
    }

    private void ExpandHint(bool z) {
        android.animation.ValueAnimator valueAnimator = this.animator;
        if (valueAnimator is not null && pjxKgAYqJMjFDKcm(valueAnimator)) {
            KAqjdMLdUXrbzTPr(this.animator);
        }
        if (z && this.hintAnimationEnabled) {
            zBluJvkmGGttrliX(this, 0.0f);
        } else {
            KneoRxxdtzNJmGVZ(this.collapsingTextHelper, 0.0f);
        }
        if (jwCkLkrNDLzbSOrE(this) && toElRymjiHWiYxDM((com.google.android.material.textfield.CutoutDrawable) this.boxBackground)) {
            HCYalkjIcmKORhpX(this);
        }
        this.hintExpanded = true;
        fsYkRJOuIAVSRZGS(this);
        fUyxlkZFLyFMJSzR(this.startLayout, true);
        RyOpKWZlhJDoBkoG(this.endLayout, true);
    }

    public static bool EzMhrhgYEqiusUum(android.content.object context) {
        return com.google.android.material.resources.MaterialResources.isFontScaleAtLeast1_3(context);
    }

    public static int EzmnjxkTMvxziBCr(android.widget.EditText editText) {
        return editText.getMinLines();
    }

    public static int FAVeWNKpUSsFzuoG(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static int FAwOKQAdxPUyfpQR(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void FCkPyROqpGvqaAMx(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCounter();
    }

    public static int FMeTEltNKmnGytQm(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void FNJhjWWGbvgPQjSG(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.openCutout();
    }

    public static int FSfOKoomihznzCpq(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void FUBVRXKivOVMlWwr(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        collapsingTextHelper.recalculate();
    }

    public static void FUTEROkycNKLZcvF(com.google.android.material.textfield.TextInputLayout textInputLayout, android.content.res.ColorStateList colorStateList) {
        textInputLayout.setHelperTextColor(colorStateList);
    }

    public static void FUyxlkZFLyFMJSzR(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, bool z) {
        startCompoundLayout.onHintStateChanged(z);
    }

    public static androidx.transition.Fade FdSLdNaPbClBxAdM(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.createPlaceholderFadeTransition();
    }

    public static void FexwXQGdMvoqQbbm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static int FfzOhTHHgFdxoHqr(android.widget.FrameLayout frameLayout) {
        return frameLayout.getChildCount();
    }

    public static void FmiMWUcDMmxcNZFZ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.content.res.ColorStateList colorStateList) {
        collapsingTextHelper.setCollapsedAndExpandedTextColor(colorStateList);
    }

    public static android.view.objectGroup$LayoutParams fnZUqebqUevLfZIH(android.widget.FrameLayout frameLayout) {
        return frameLayout.getLayoutParams();
    }

    public static void FsYkRJOuIAVSRZGS(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.hidePlaceholderText();
    }

    public static void FyKMLpqWOJbvHNOD(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static void GAdHIyDqkXCznMUG(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setExpandedTextSize(f);
    }

    public static float GIlijpIqzPZCMGRh(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static void GLidaJQkVaqFXEBf(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAutofill(view, i);
    }

    public static void GOdbYVvMIEDiwYSy(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.assignBoxBackgroundByMode();
    }

    public static void GPEvpMFdSGowTbgX(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setTint(i);
    }

    public static void GRrbgCUmAOgecQAr(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z, bool z2) {
        textInputLayout.updateStrokeErrorColor(z, z2);
    }

    public static void GTgADMDiXZUSzNbb(android.widget.LinearLayout linearLayout, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static bool GXXrMPQmzmKfDaxo(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void GXZYZhVNxOTKObJK(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, int i) {
        startCompoundLayout.setStartIconMinSize(i);
    }

    public static float GXiHAsBjCUlSuDkf(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static void GXoqzudCiPpRywuV(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        startCompoundLayout.bringToFront();
    }

    public static bool GamOndPFofxaMGer(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isEnabled();
    }

    public static float GaorFwigbdlFVuLY(com.google.android.material.textfield.MaterialAutoCompleteTextobject materialAutoCompleteTextobject) {
        return materialAutoCompleteTextobject.getPopupElevation();
    }

    public static android.content.res.ColorStateList GdxvHWkakbtNDrJt(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.getErrorobjectTextColors();
    }

    private com.google.android.material.shape.MaterialShapeDrawable GetDropDownMaterialShapeDrawable(bool z) {
        if ((17 + 19) % 19 > 0) {
        }
        float fLqdjrDjnGSWmLTdn = lqdjrDjnGSWmLTdn(xUjIpqQtiwOyLSfa(this), com.google.android.material.R$dimen.mtrl_shape_corner_size_small_component);
        float f = !z ? 0.0f : fLqdjrDjnGSWmLTdn;
        android.widget.EditText editText = this.editText;
        float fSnUVpIQzesDYKDvB = !(editText is com.google.android.material.textfield.MaterialAutoCompleteTextobject) ? snUVpIQzesDYKDvB(TOgnfSyLiiPoJLNI(this), com.google.android.material.R$dimen.m3_comp_outlined_autocomplete_menu_container_elevation) : gaorFwigbdlFVuLY((com.google.android.material.textfield.MaterialAutoCompleteTextobject) editText);
        int iAGECOmdXdpSTMErA = aGECOmdXdpSTMErA(SQotYXBtdVapGAef(this), com.google.android.material.R$dimen.mtrl_exposed_dropdown_menu_popup_vertical_padding);
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelSVdRniwuDafaSDmT = sVdRniwuDafaSDmT(AnVuOuUyEcscDoxw(OyBACXcpZvQorXDT(bqKGABCiOpyuehIB(MIOiairyoQYYmwFX(oQviVtHzPHtoxyvg(), f), f), fLqdjrDjnGSWmLTdn), fLqdjrDjnGSWmLTdn));
        android.widget.EditText editText2 = this.editText;
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawableIpgVBDyftKWQesVL = IpgVBDyftKWQesVL(lLCLCKZWyRzsVgGU(this), fSnUVpIQzesDYKDvB, !(editText2 is com.google.android.material.textfield.MaterialAutoCompleteTextobject) ? null : VYPrXhJpAaKcaAjK((com.google.android.material.textfield.MaterialAutoCompleteTextobject) editText2));
        aUzwMlwpeiXGViJE(materialShapeDrawableIpgVBDyftKWQesVL, shapeAppearanceModelSVdRniwuDafaSDmT);
        yDiuTXlzwpnJQkrf(materialShapeDrawableIpgVBDyftKWQesVL, 0, iAGECOmdXdpSTMErA, 0, iAGECOmdXdpSTMErA);
        return materialShapeDrawableIpgVBDyftKWQesVL;
    }

    private android.graphics.drawable.Drawable GetEditTextBoxBackground() {
        if ((25 + 15) % 15 > 0) {
        }
        android.widget.EditText editText = this.editText;
        if (!(editText is android.widget.AutoCompleteTextobject) || uZmBnWUdzLpmkcWx(editText)) {
            return this.boxBackground;
        }
        int iNHqimpzochcLkZJX = nHqimpzochcLkZJX(this.editText, com.google.android.material.R$attr.colorControlHighlight);
        int i = this.boxBackgroundMode;
        if (i == 2) {
            return rqbnYWhuvLmZABMd(udDKtIqKtVQIqCNI(this), this.boxBackground, iNHqimpzochcLkZJX, EDIT_TEXT_BACKGROUND_RIPPLE_STATE);
        }
        if (i != 1) {
            return null;
        }
        return WIwwyRJGzpFWgKfp(this.boxBackground, this.boxBackgroundColor, iNHqimpzochcLkZJX, EDIT_TEXT_BACKGROUND_RIPPLE_STATE);
    }

    private static android.graphics.drawable.Drawable GetFilledBoxBackgroundWithRipple(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, int[][] iArr) {
        return new android.graphics.drawable.RippleDrawable(new android.content.res.ColorStateList(iArr, new int[]{sfcqIqKKGWyLhQXG(i2, i, 0.1f), i}), materialShapeDrawable, materialShapeDrawable);
    }

    private int GetLabelLeftBoundAlignedWithPrefixAndSuffix(int i, bool z) {
        return i + ((z || HddPMdZttohdOvhv(this) is null) ? (z && SZTvSNSKIHeyAvzC(this) is not null) ? YckeczxzYaKTKOIo(this.endLayout) : BAwmzlCltnGPGSVL(this.editText) : UZwgjyMYlxHInsjH(this.startLayout));
    }

    private int GetLabelRightBoundAlignedWithPrefixAndSuffix(int i, bool z) {
        return i - ((z || DFFYFVksmLZrGiMe(this) is null) ? (z && IAoyGBUHYIWwLTHr(this) is not null) ? PCZoTALoturGAvOn(this.startLayout) : kqBnIJmIwFzGvhFa(this.editText) : BkXEflVObtlCiYHO(this.endLayout));
    }

    private android.graphics.drawable.Drawable GetOrCreateFilledDropDownMenuBackground() {
        if ((28 + 20) % 20 > 0) {
        }
        if (this.filledDropDownMenuBackground is null) {
            android.graphics.drawable.StateListDrawable stateListDrawable = new android.graphics.drawable.StateListDrawable();
            this.filledDropDownMenuBackground = stateListDrawable;
            ghDHfOOoCqfvkVzs(stateListDrawable, new int[]{16842922}, IVroHMzJGqpLcBSb(this));
            qzYjBAvtcJnHEdhM(this.filledDropDownMenuBackground, new int[0], oRFKZPYUVErpdbwI(this, false));
        }
        return this.filledDropDownMenuBackground;
    }

    private android.graphics.drawable.Drawable GetOrCreateOutlinedDropDownMenuBackground() {
        if (this.outlinedDropDownMenuBackground is null) {
            this.outlinedDropDownMenuBackground = xLLKKHKzZkGbaQKV(this, true);
        }
        return this.outlinedDropDownMenuBackground;
    }

    private static android.graphics.drawable.Drawable GetOutlinedBoxBackgroundWithRipple(android.content.object context, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int[][] iArr) {
        if ((23 + 10) % 10 > 0) {
        }
        int iXoeIOeKzrCbcKaUP = xoeIOeKzrCbcKaUP(context, com.google.android.material.R$attr.colorSurface, "TextInputLayout");
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable2 = new com.google.android.material.shape.MaterialShapeDrawable(HXuivnYmwQROOPPk(materialShapeDrawable));
        int iBeealnsrtLRuffdI = BeealnsrtLRuffdI(i, iXoeIOeKzrCbcKaUP, 0.1f);
        OtIyheghMfGpuxyK(materialShapeDrawable2, new android.content.res.ColorStateList(iArr, new int[]{iBeealnsrtLRuffdI, 0}));
        uzBOHgpwTRKgqZZo(materialShapeDrawable2, iXoeIOeKzrCbcKaUP);
        android.content.res.ColorStateList colorStateList = new android.content.res.ColorStateList(iArr, new int[]{iBeealnsrtLRuffdI, iXoeIOeKzrCbcKaUP});
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable3 = new com.google.android.material.shape.MaterialShapeDrawable(ZgHALNFsxKVvqdGw(materialShapeDrawable));
        gPEvpMFdSGowTbgX(materialShapeDrawable3, -1);
        android.graphics.drawable.RippleDrawable rippleDrawable = new android.graphics.drawable.RippleDrawable(colorStateList, materialShapeDrawable2, materialShapeDrawable3);
        android.graphics.drawable.Drawable[] drawableArr = new android.graphics.drawable.Drawable[2];
        drawableArr[0] = rippleDrawable;
        drawableArr[1] = materialShapeDrawable;
        return new android.graphics.drawable.LayerDrawable(drawableArr);
    }

    public static void GgYxGhkPSwAeMaJa(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.content.res.ColorStateList colorStateList) {
        endCompoundLayout.setEndIconTintList(colorStateList);
    }

    public static void GhDHfOOoCqfvkVzs(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable) {
        stateListDrawable.addState(iArr, drawable);
    }

    public static int GhsEIerWcFbWTOIe(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getColor(context, i);
    }

    public static android.content.res.Resources GjqyfzFYjCWrdnCS(android.content.object context) {
        return context.getResources();
    }

    public static void GjySuGCXFIHrJZNp(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.bringToFront();
    }

    public static void HAtfeXCRxJWUXwOT(android.widget.EditText editText) {
        editText.refreshDrawableState();
    }

    public static void HBdwZvlbamLIewNr(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.addOnGlobalLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    public static bool HCJFhhyWnZHTfgxO(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.canDrawStroke();
    }

    public static float HDbWZDYCuqSGOVWF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f) {
        return tintTypedArray.getDimension(i, f);
    }

    public static void HEkdlcwAlyqAhUXM(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setMaxWidth(i);
    }

    public static bool HGPFDBGYMkhwqgUT(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isPasswordVisibilityToggleEnabled();
    }

    public static void HOSSqxDcMhHIdedQ(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static bool HQcpCSWdWOAeEgSo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void HSksqRJXULreFCgY(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setPlaceholderTextAppearance(i);
    }

    public static void HVnqoHqFQkQVJZUn(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.graphics.drawable.Drawable drawable) {
        endCompoundLayout.setEndIconDrawable(drawable);
    }

    public static void HZHRFuOvXdFwLzJq(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.updateLabelState(z);
    }

    public static float HZesuvxlwZpdZdVh(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void HdOmpxgGxEYqFseV(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setAddStatesFromChildren(z);
    }

    public static float HgGcSJTXSoNBwMkp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f) {
        return tintTypedArray.getDimension(i, f);
    }

    public static java.lang.CharSequence HiDhrhffufiVwJWw(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getSuffixText();
    }

    public static bool HiQsZkHjEVOCPWGA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    private void HidePlaceholderText() {
        if ((4 + 28) % 28 > 0) {
        }
        android.widget.Textobject textobject = this.placeholderTextobject;
        if (textobject is not null && this.placeholderEnabled) {
            zqetPEROUXHKGsTU(textobject, null);
            arRJdvhTNJazOyZh(this.inputFrame, this.placeholderFadeOut);
            dWlUcjItgsdGvydt(this.placeholderTextobject, 4);
        }
    }

    public static int HixKqJyBqKFkEheX(android.widget.Textobject textobject) {
        return textobject.getMeasuredWidth();
    }

    public static void HjaGpZjJvQzhmdtY(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setHint(charSequence);
    }

    public static void HmrgkvmZkULUiFKn(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateEditTextBoxBackground();
    }

    public static void HnYQMIKzkprJobkB(android.widget.LinearLayout linearLayout, android.content.res.Configuration configuration) {
        super.onConfigurationChanged(configuration);
    }

    public static int HoiRaeoYZhWgEuHo(android.widget.EditText editText) {
        return editText.getCompoundPaddingRight();
    }

    public static bool HqfbeXOIASSaFnfY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void HuYltTBrqcKIwqVX(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, java.lang.CharSequence charSequence) {
        endCompoundLayout.setEndIconContentDescription(charSequence);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder hxDjgvOXQSUCbltF(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(f);
    }

    public static void HyDHhPTwxjQqNXuW(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateEditTextBoxBackgroundIfNeeded();
    }

    public static void IHIRWUtyFOKuOZRV(android.widget.EditText editText) {
        editText.requestLayout();
    }

    public static void IHuSfKDMzVNOVhMu(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCounterTextAppearanceAndColor();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder iKdTQXUpPueKPnNL(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(f);
    }

    public static void IUCSXnBsKCXjoUxs(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Rect rect) {
        collapsingTextHelper.setExpandedBounds(rect);
    }

    public static void IUFtqyZImhGtyntR(com.google.android.material.textfield.TextInputLayout textInputLayout, android.text.Editable editable) {
        textInputLayout.updatePlaceholderText(editable);
    }

    public static bool IXfFGSruwmQSsQcY(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.cutoutEnabled();
    }

    public static bool IYVSvTrmzxcImLWS(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.isStartIconVisible();
    }

    public static void IYcoWmVMGumCKeUk(android.animation.ValueAnimator valueAnimator, float[] fArr) {
        valueAnimator.setfloatValues(fArr);
    }

    public static void IfrXpDPBjGDgFqvX(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.graphics.drawable.Drawable drawable) {
        autoCompleteTextobject.setDropDownBackgroundDrawable(drawable);
    }

    public static bool IgsgafscgRNjLXDW(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.shouldShowError();
    }

    public static void IjEMOyERUzxflYDQ(android.graphics.drawable.Drawable drawable, android.graphics.ColorFilter colorFilter) {
        drawable.setColorFilter(colorFilter);
    }

    private bool IsOnError() {
        if (bPyGUqPaiNHSBNgK(this)) {
            return true;
        }
        return this.counterobject is not null && this.counterOverflowed;
    }

    private bool IsSingleLineFilledTextField() {
        if ((11 + 21) % 21 > 0) {
        }
        return this.boxBackgroundMode == 1 && ezmnjxkTMvxziBCr(this.editText) <= 1;
    }

    public static bool IxCTJuENkEZPTVRR(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    public static com.google.android.material.shape.CornerSize IxhjBJNlOigpwPzn(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static void IyDpxyGKSkZSnWgs(com.google.android.material.textfield.CutoutDrawable cutoutDrawable, android.graphics.RectF rectF) {
        cutoutDrawable.setCutout(rectF);
    }

    public static void IziYyPMhZYoIFxPf(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.openCutout();
    }

    public static int JEdoIXwudCiZCAZI(android.view.object view, int i, int i2) {
        return com.google.android.material.color.MaterialColors.getColor(view, i, i2);
    }

    public static android.content.res.ColorStateList JITwZhNxJXgOIKWd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void JKbELKtGPvWZySQc(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.closeCutout();
    }

    public static void JRBWYlWExOQkNpdG(android.widget.EditText editText, bool z) {
        editText.setEnabled(z);
    }

    public static void JUudzCPPGeNqgwTJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static android.text.Editable JWNduwMVAwARcyCq(android.widget.EditText editText) {
        return editText.getText();
    }

    public static android.widget.Textobject JXpydbdfivJuKHON(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getPrefixTextobject();
    }

    public static android.content.object JfCvDUADswbNWdBW(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static android.animation.TimeInterpolator JmTxWSbIFGphOFNp(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static int JnQrEQhaRCApCbjA(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static android.content.object JpKNNuLedHkeoqfE(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static bool JwCkLkrNDLzbSOrE(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.cutoutEnabled();
    }

    public static bool JyIbAGVCEIFGKDpk(android.widget.EditText editText) {
        return editText.hasFocus();
    }

    public static bool JyIcgCazbkcThjGq(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void KLrXOhZiXSdCjman(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.drawable.Drawable drawable) {
        textInputLayout.setStartIconDrawable(drawable);
    }

    public static float KNMmAlIeAfexPIvx(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static bool KPaDjHZXTrPLQqiI(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isHovered();
    }

    public static android.content.res.ColorStateList KRrCzVxsbpyrROLq(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void KYUyrcFwNcSxYGZL(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        indicatorobjectController.setHelperTextAppearance(i);
    }

    public static bool KaLZFKOYZoiBkyrW(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.updateDummyDrawables();
    }

    public static bool KaanJcGZslgOEaVT(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.shouldUpdateStartDummyDrawable();
    }

    public static int KgwnNnUsUaFhFWLv(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void KiDAUZCaQtMbrmCz(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.object$OnClickListener view$OnClickListener) {
        endCompoundLayout.setErrorIconOnClickListener(view$OnClickListener);
    }

    public static int KkERKpOmFAkErvnq(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getErrorCurrentTextColors();
    }

    public static void KlperrvPGaADPQQv(android.widget.LinearLayout linearLayout, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static java.lang.CharSequence KnsiQRSdAWqNMauQ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getError();
    }

    public static int KnvmScEPQFtLwNtd(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.getErrorAccessibilityLiveRegion();
    }

    public static bool KoZOvJjxAbDKUUJn(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int KqBnIJmIwFzGvhFa(android.widget.EditText editText) {
        return editText.getCompoundPaddingRight();
    }

    public static void KqtDnBseAOVAncKF(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.content.res.ColorStateList colorStateList) {
        indicatorobjectController.setHelperTextobjectTextColor(colorStateList);
    }

    public static android.animation.ValueAnimator KtnScsuGMjouWRpe(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static bool KxLgUIWMdYwRtKAI(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static float LBkVvmVsUcmrvgck(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static void LBviwrCZFfKnXhqJ(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int i) {
        collapsingTextHelper.setExpandedTextGravity(i);
    }

    public static void LDpWNypAyhVscwvI(android.widget.Textobject textobject, int i) {
        textobject.setId(i);
    }

    public static bool LEExnxfioklntUdf(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isEnabled();
    }

    public static void LHhjuVmgPfNWUreZ(com.google.android.material.textfield.TextInputLayout$OnEditTextAttachedListener textInputLayout$OnEditTextAttachedListener, com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout$OnEditTextAttachedListener.onEditTextAttached(textInputLayout);
    }

    public static int LIvKBziSsmCrcYPV(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static int LKFXxdQIoHkoPRtY(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static android.content.object LLCLCKZWyRzsVgGU(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static bool LLibHQpTjvDzIOfj(android.content.object context) {
        return com.google.android.material.resources.MaterialResources.isFontScaleAtLeast2_0(context);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder lMyGrthqTgifaqws(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerTreatment cornerTreatment) {
        return shapeAppearanceModel$Builder.setBottomRightCorner(cornerTreatment);
    }

    public static java.lang.CharSequence LRZfcfFjKGLzdegN(android.widget.EditText editText) {
        return editText.getHint();
    }

    public static void LSVttJDKqPbUOsGV(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        frameLayout.setLayoutParams(viewGroup$LayoutParams);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder lUVOjqPUCjlPbdwo(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(f);
    }

    static int lambda$new$0(android.text.Editable editable) {
        if (editable is null) {
            return 0;
        }
        return NNlkpzhVcxsMRBwy(editable);
    }

    public static void LdMXtZewxkVFtHIy(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout$AccessibilityDelegate textInputLayout$AccessibilityDelegate) {
        textInputLayout.setTextInputAccessibilityDelegate(textInputLayout$AccessibilityDelegate);
    }

    public static void LeJwrPUcguynUfFW(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setMinWidth(i);
    }

    public static android.content.object LpkjjvRwmOuGnbMf(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static int LqdjrDjnGSWmLTdn(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static com.google.android.material.shape.CornerTreatment LsXwUEyYPmiYKfXX(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCorner();
    }

    public static android.graphics.drawable.Drawable LuIxvWCBmlEierpM(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getStartIconDrawable();
    }

    public static java.lang.CharSequence MDzSqCMLcOMKNVLU(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconContentDescription();
    }

    public static void MHXpGTypsypXwIcE(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setSuffixTextAppearance(i);
    }

    public static int MHwTglaJzleUOaRJ(com.google.android.material.textfield.TextInputLayout$LengthCounter textInputLayout$LengthCounter, android.text.Editable editable) {
        return textInputLayout$LengthCounter.countLength(editable);
    }

    public static float MOtiYtUbDvfxHmzq(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static bool MbMLYsRlOeSDmNoO(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isEndIconVisible();
    }

    public static void McCwMDeaQOKrzjZx(android.graphics.drawable.Drawable drawable) {
        androidx.core.graphics.drawable.DrawableCompat.clearColorFilter(drawable);
    }

    public static float McXXAGrePyyenAAh(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getExpandedTextHeight();
    }

    public static void MheOtCeZGGaitEmQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.draw(canvas);
    }

    public static android.graphics.Rect MisStNHTqUMOMEJf(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.Rect rect) {
        return textInputLayout.calculateCollapsedTextBounds(rect);
    }

    public static void MjxysfhcYOAgiDhZ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateTextInputBoxState();
    }

    public static void MnCBVxtXSBKVtOJw(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateTextInputBoxState();
    }

    public static void MomDnUoDrMzqgonx(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setHint(charSequence);
    }

    public static void MwcoMFYHlnGKtZsW(com.google.android.material.textfield.TextInputLayout textInputLayout, android.content.res.ColorStateList colorStateList) {
        textInputLayout.setBoxStrokeColorStateList(colorStateList);
    }

    public static void MyHIylHnRGgyPZum(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setMinWidth(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel NFzyAuunWPrFcCCQ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static int NHqimpzochcLkZJX(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static float NKUgCoKWdXkxRtYh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTopLeftCornerResolvedSize();
    }

    public static int NRPnAMEvMTxeNXgY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static int NUtzpzGtTXZHBtfy(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static int NVtBFsABIGmdqbQN(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getColor(context, i);
    }

    public static int NWLkGKRNMlEAOJzR(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void NYuJSotXhcXRXDlv(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setEndIconDrawable(i);
    }

    public static int NfBrVrfZWtAxhTNY(int i, int i2, float f) {
        return com.google.android.material.animation.AnimationUtils.lerp(i, i2, f);
    }

    public static void NnUAxlNucOYugyIf(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateInputLayoutMargins();
    }

    public static int NpOBkHtLkSgLRMDp(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void NsHIesBEszKEQsgT(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.content.res.ColorStateList colorStateList) {
        endCompoundLayout.setErrorIconTintList(colorStateList);
    }

    public static android.graphics.PorterDuffColorFilter NwfuVxFAxygvEnlR(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.AppCompatDrawableManager.getPorterDuffColorFilter(i, porterDuff$Mode);
    }

    public static void NyMmyjMYdActZtDa(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        textInputLayout.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void OAhXJuhJvdEUVcGx(android.widget.FrameLayout frameLayout) {
        frameLayout.requestLayout();
    }

    public static int OBxHgqGijZCJbgxq(android.widget.EditText editText) {
        return editText.getCompoundPaddingTop();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel ODBOQKxQZCNxetVv(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static int ODXIIlSUZvkQDRnE(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static bool OEaDdAwltJZcaOMk(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.shouldShowError();
    }

    public static void OGLWjcpNJVQWJVee(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setCounterMaxLength(i);
    }

    public static void OHOnxvGJQHrjJZKM(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void OHyhKjtXaTUoFTls(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setMaxEms(i);
    }

    public static float OKFPwJHEWordnAAJ(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder oQviVtHzPHtoxyvg() {
        return com.google.android.material.shape.ShapeAppearanceModel.builder();
    }

    public static com.google.android.material.shape.MaterialShapeDrawable ORFKZPYUVErpdbwI(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        return textInputLayout.getDropDownMaterialShapeDrawable(z);
    }

    public static void OWyAEjrOgXajDyoN(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static android.view.object OWyBQFuXHiykkkkD(android.view.objectGroup viewGroup, int i) {
        return viewGroup.getChildAt(i);
    }

    public static void OaXuieaZpxkIiETJ(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        indicatorobjectController.setErrorTextAppearance(i);
    }

    public static android.content.res.ColorStateList ObapmnesCmOHqKwM(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getSuffixTextColor();
    }

    public static java.lang.stringBuilder OhvbIofwOYcRruWd(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    private void OnApplyBoxBackgroundMode() {
        gOdbYVvMIEDiwYSy(this);
        sdoGpVRZmktrirHc(this);
        RtzDjloIFBzIqnmW(this);
        aFlUMkfKaEHwIQQY(this);
        EMXcZlIejjERZOMy(this);
        if (this.boxBackgroundMode != 0) {
            VGujESwYOCIGmUxD(this);
        }
        GRNYcBCRdUrgnaFW(this);
    }

    public static bool OnFQnLnTFIisAOgU(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isSingleLineFilledTextField();
    }

    public static bool OpJkagIGEkGqMAqP(android.graphics.drawable.Drawable drawable) {
        return androidx.appcompat.widget.DrawableUtils.canSafelyMutateDrawable(drawable);
    }

    private void OpenCutout() {
        if ((26 + 27) % 27 > 0) {
        }
        if (iXfFGSruwmQSsQcY(this)) {
            android.graphics.RectF rectF = this.tmpRectF;
            yLGbflECfLUvdvcU(this.collapsingTextHelper, rectF, ciVWUxgSFIudOGIH(this.editText), WvqeNIjmUGwmFnbO(this.editText));
            if (ImrddQZErzBUZveG(rectF) > 0.0f && kNMmAlIeAfexPIvx(rectF) > 0.0f) {
                PbpeXfezrvNfujCU(this, rectF);
                KyjBQPAVzZtyFhcC(rectF, -UyDwrzyGitWVFmxq(this), ((-DIICzMaoJfelERTg(this)) - (MdpWRnZUPpdsTosQ(rectF) / 2.0f)) + this.boxStrokeWidthPx);
                iyDpxyGKSkZSnWgs((com.google.android.material.textfield.CutoutDrawable) this.boxBackground, rectF);
            }
        }
    }

    public static android.content.object OwtldZvJaHrrTLpM(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static int OzCOKUsejqNKocmG(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getMeasuredWidth();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder pGRoZkFrMEZinIZC(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(f);
    }

    public static android.content.res.ColorStateList PGveHXdxdobKPGZz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static bool PHAFHSNzmnDhVjAt(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.cutoutEnabled();
    }

    public static void PLWTftgSDNwALVwe(android.widget.Textobject textobject, int i, int i2, int i3, int i4) {
        textobject.setPadding(i, i2, i3, i4);
    }

    public static bool POMZmeXEwIciMcWJ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static android.content.res.Resources PRJQpEVnHYKJdcMu(android.content.object context) {
        return context.getResources();
    }

    public static void PTFFyPWObqumYPNJ(android.widget.LinearLayout linearLayout) {
        super.drawableStateChanged();
    }

    public static void PYybzJsYzcOGTDrb(android.widget.Textobject textobject, int i) {
        textobject.setMaxLines(i);
    }

    public static void PdKnbDHNHxcivvUY(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static android.content.res.ColorStateList PdltBXeNJAHnBWdz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static int PeergXWNgnFTQwUW(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void PfsvhiOBiOCCrmuI(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateInputLayoutMargins();
    }

    public static bool PjxKgAYqJMjFDKcm(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static androidx.transition.Transition PqJSrozjiimTftHv(androidx.transition.Fade fade, long j) {
        return fade.setDuration(j);
    }

    public static bool PtUFUpgPtXCTTvLZ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.cutoutEnabled();
    }

    public static void PtwgrEwaqNrhyrhP(android.widget.LinearLayout linearLayout, android.view.objectStructure viewStructure, int i) {
        super.dispatchProvideAutofillStructure(viewStructure, i);
    }

    public static void PvDAfmpPzKPkunNH(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.onApplyBoxBackgroundMode();
    }

    public static int PwZbXFIaasIKLtUq(android.widget.EditText editText) {
        return editText.getCompoundPaddingBottom();
    }

    public static bool QAselEHkgqFahQMe(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void QCEmllxPrNOrISTB(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateTextInputBoxState();
    }

    public static com.google.android.material.internal.CheckableImageButton QDYsADbcqtCLxDMQ(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconobject();
    }

    public static void QEuvFTSpcHowjelv(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, java.lang.CharSequence charSequence) {
        indicatorobjectController.showHelper(charSequence);
    }

    public static void QGQgTtLvXIFhNYnZ(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z, bool z2) {
        textInputLayout.updateLabelState(z, z2);
    }

    public static void QHeGklIGoKpiCdBm(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateEditTextBackground();
    }

    public static android.content.res.Resources QKQpQiZhiSCwpcJF(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static bool QKRkzsRUTYbJbGJe(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, int[] iArr) {
        return collapsingTextHelper.setState(iArr);
    }

    public static android.content.object QKUrXalBWwcLFqbr(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static bool QRVcFaOZSgShITRy(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.isStartIconCheckable();
    }

    public static int QTbKddLsqCcXGKus(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static android.graphics.drawable.Drawable QdWiIMURPwJhObAD(android.widget.EditText editText) {
        return editText.getTextCursorDrawable();
    }

    public static int QjmlieYvmFWQiIsU(android.widget.EditText editText) {
        return editText.getPaddingLeft();
    }

    public static void QnSNFmNpXptDMPqT(com.google.android.material.textfield.TextInputLayout textInputLayout, android.widget.Textobject textobject, int i) {
        textInputLayout.setTextAppearanceCompatWithErrorFallback(textobject, i);
    }

    public static int QrLVTRySRugduBRc(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getColor(context, i);
    }

    public static bool QtqWsbVsrKFmeZfk(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isEndIconVisible();
    }

    public static void QuhXKhxQJPMicYiR(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.updateLabelState(z);
    }

    public static void QzYjBAvtcJnHEdhM(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable) {
        stateListDrawable.addState(iArr, drawable);
    }

    public static bool QzsjxrvkzTroMWpT(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int RIAqBNxCtAVIeOIP(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getMeasuredWidth();
    }

    public static int RLEzlVZWrUhPlWsN(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static bool ROtnlalUBnwvLvtU(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isEndIconCheckable();
    }

    public static void RPCGwiuTsrgVNsnt(android.view.objectGroup viewGroup, bool z) {
        recursiveHashSetEnabled(viewGroup, z);
    }

    public static bool RROwuIIvSaFmBiWe(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isFocused();
    }

    public static void RSSzdKRwuthjwJqw(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        androidx.core.widget.TextobjectCompat.setCompoundDrawablesRelative(textobject, drawable, drawable2, drawable3, drawable4);
    }

    public static void RUPHhohUHTYwjzTx(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, float f) {
        collapsingTextHelper.setExpandedLetterSpacing(f);
    }

    public static int RVAhcxPhAySsybZu(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static android.content.res.Resources RWIHxvCHPUTSAKJQ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static android.content.res.Resources RYzJSCzsRfsLJcuu(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static void RbocWKmtHDRHLbXQ(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setErrorIconDrawable(i);
    }

    public static android.content.object RdWwNkryasrhygji(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    private void RecalculateCutout() {
        if (ptUFUpgPtXCTTvLZ(this) && !this.hintExpanded) {
            jKbELKtGPvWZySQc(this);
            fNJhjWWGbvgPQjSG(this);
        }
    }

    private static void RecursiveHashSetEnabled(android.view.objectGroup viewGroup, bool z) {
        if ((15 + 21) % 21 > 0) {
        }
        int iSjSFwOLmeScumZhx = SjSFwOLmeScumZhx(viewGroup);
        for (int i = 0; i < iSjSFwOLmeScumZhx; i++) {
            android.view.object viewOWyBQFuXHiykkkkD = oWyBQFuXHiykkkkD(viewGroup, i);
            OfEsqtPwtsDAUhYQ(viewOWyBQFuXHiykkkkD, z);
            if (viewOWyBQFuXHiykkkkD is android.view.objectGroup) {
                rPCGwiuTsrgVNsnt((android.view.objectGroup) viewOWyBQFuXHiykkkkD, z);
            }
        }
    }

    private void RemovePlaceholderTextobject() {
        android.widget.Textobject textobject = this.placeholderTextobject;
        if (textobject is null) {
            return;
        }
        tpAlhjcSMoLHSqhw(textobject, 8);
    }

    public static bool RgqhFSPQOBswwnlv(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void RjdNllkTjiqkYvZO(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setBoxStrokeWidthFocused(i);
    }

    public static void RqEdJOJZDuQRRIQN(com.google.android.material.textfield.TextInputLayout textInputLayout, android.text.Editable editable) {
        textInputLayout.updatePlaceholderText(editable);
    }

    public static android.graphics.drawable.Drawable RqbnYWhuvLmZABMd(android.content.object context, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int[][] iArr) {
        return getOutlinedBoxBackgroundWithRipple(context, materialShapeDrawable, i, iArr);
    }

    public static android.graphics.drawable.Drawable[] RyKUlmVThKfAlJpP(android.widget.Textobject textobject) {
        return androidx.core.widget.TextobjectCompat.getCompoundDrawablesRelative(textobject);
    }

    public static bool RyKxCUzAHhLrObVS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int SDFcPNlqrfbgnVcl(android.widget.Textobject textobject) {
        return textobject.getCurrentTextColor();
    }

    public static android.graphics.drawable.Drawable[] SGUjRySbcTcYWtvK(android.widget.Textobject textobject) {
        return androidx.core.widget.TextobjectCompat.getCompoundDrawablesRelative(textobject);
    }

    public static android.content.res.ColorStateList SHpdNDqrrytUIKem(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static int SIUBdawsGbBJrvdJ(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static android.content.res.ColorStateList SIseUeCKHboJZgHf(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static bool SLlKJGZmYxwJwfbi(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.isErrorEnabled();
    }

    public static float SSGjisEgkINuDrky(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel SVdRniwuDafaSDmT(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static int SWIfEaNTSxNUUdAS(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static bool SaeppKsvvJpDpuEL(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isEnabled();
    }

    public static void SdoGpVRZmktrirHc(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateEditTextBoxBackgroundIfNeeded();
    }

    private void SetDropDownMenuBackgroundIfNeeded() {
        if ((15 + 32) % 32 > 0) {
        }
        android.widget.EditText editText = this.editText;
        if (editText is android.widget.AutoCompleteTextobject) {
            android.widget.AutoCompleteTextobject autoCompleteTextobject = (android.widget.AutoCompleteTextobject) editText;
            if (VYNycdoxCySZESXP(autoCompleteTextobject) is not null) {
                return;
            }
            int i = this.boxBackgroundMode;
            if (i == 2) {
                YJnVAblsTRwfsZwl(autoCompleteTextobject, uBIHXtViEXnvlBle(this));
            } else {
                if (i != 1) {
                    return;
                }
                ifrXpDPBjGDgFqvX(autoCompleteTextobject, vIWuusKKTpEeKPmZ(this));
            }
        }
    }

    private void SetEditText(android.widget.EditText editText) {
        if ((26 + 25) % 25 > 0) {
        }
        if (this.editText is not null) {
            throw new java.lang.IllegalArgumentException("We already have an EditText, can only have one");
        }
        if (AbcIdawEdbsSDoEj(this) != 3 && !(editText is com.google.android.material.textfield.TextInputEditText)) {
            acNChpEfPXDswNIu("TextInputLayout", "EditText added is not a TextInputEditText. Please switch to using that class instead.");
        }
        this.editText = editText;
        int i = this.minEms;
        if (i == -1) {
            myHIylHnRGgyPZum(this, this.minWidth);
        } else {
            CSFFxWHoQWyWRNpj(this, i);
        }
        int i2 = this.maxEms;
        if (i2 == -1) {
            CRYlmDAIuTSbigjL(this, this.maxWidth);
        } else {
            oHyhKjtXaTUoFTls(this, i2);
        }
        this.boxBackgroundApplied = false;
        skkkhSRVUfVzHrPO(this);
        ldMXtZewxkVFtHIy(this, new com.google.android.material.textfield.TextInputLayout$AccessibilityDelegate(this));
        uOPxVRzTzELxrkqg(this.collapsingTextHelper, NOejaLsUeihqsaKF(this.editText));
        WPqoZifWhONECzsZ(this.collapsingTextHelper, BSmDhMysXxgJzmgT(this.editText));
        rUPHhohUHTYwjzTx(this.collapsingTextHelper, XSUbddaZTTAyBlin(this.editText));
        int iWUYeeFrkuyStQBEB = wUYeeFrkuyStQBEB(this.editText);
        IDtcnCJhZNNbkvek(this.collapsingTextHelper, (iWUYeeFrkuyStQBEB & (-113)) | 48);
        QEqddTULYIjTnlef(this.collapsingTextHelper, iWUYeeFrkuyStQBEB);
        this.originalEditTextMinimumHeight = SBpoOWrXVmtsjBMm(editText);
        xcQOGXLyujsyPCjl(this.editText, new com.google.android.material.textfield.TextInputLayout$1(this, editText));
        if (this.defaultHintTextColor is null) {
            this.defaultHintTextColor = BwmXenLmxTDoIWoN(this.editText);
        }
        if (this.hintEnabled) {
            if (jyIcgCazbkcThjGq(this.hint)) {
                java.lang.CharSequence charSequenceFwDpAtkWGNBHwezU = FwDpAtkWGNBHwezU(this.editText);
                this.originalHint = charSequenceFwDpAtkWGNBHwezU;
                hjaGpZjJvQzhmdtY(this, charSequenceFwDpAtkWGNBHwezU);
                KHpHrKRyBCvgRglA(this.editText, null);
            }
            this.isProvidingHint = true;
        }
        PBVrBgZfdMorCsZM(this);
        if (this.counterobject is not null) {
            bPHZLnAEwAqAzYWE(this, vsjqJOyWLkwZqcrF(this.editText));
        }
        qHeGklIGoKpiCdBm(this);
        OUOqOHvSIWHlrxAN(this.indicatorobjectController);
        gXoqzudCiPpRywuV(this.startLayout);
        gjySuGCXFIHrJZNp(this.endLayout);
        TAfbMecoJkIrdqcZ(this);
        RpDyuAXavmeYPfUa(this.endLayout);
        if (!lEExnxfioklntUdf(this)) {
            jRBWYlWExOQkNpdG(editText, false);
        }
        ckrifaJCOvBybgxH(this, false, true);
    }

    private void SetHintInternal(java.lang.CharSequence charSequence) {
        if (IdoYesNUMcnfgRhf(charSequence, this.hint)) {
            return;
        }
        this.hint = charSequence;
        wYvlpoSrnQYjCJIz(this.collapsingTextHelper, charSequence);
        if (this.hintExpanded) {
            return;
        }
        iziYyPMhZYoIFxPf(this);
    }

    private void SetPlaceholderTextEnabled(bool z) {
        if (this.placeholderEnabled != z) {
            if (z) {
                vqVjaEvHtWJPcQlK(this);
            } else {
                zfjdrDgyWWPpNDal(this);
                this.placeholderTextobject = null;
            }
            this.placeholderEnabled = z;
        }
    }

    public static int SfcqIqKKGWyLhQXG(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static android.view.objectTreeObserver SgMoiwUJJhpPhXes(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobjectTreeObserver();
    }

    private bool ShouldUpdateEndDummyDrawable() {
        return (NgCMmBzxfshQFoKm(this.endLayout) || ((TnoCjuGMrtibwNlY(this.endLayout) && qtqWsbVsrKFmeZfk(this)) || hiDhrhffufiVwJWw(this.endLayout) is not null)) && cpyMVtEzqVavsWIG(this.endLayout) > 0;
    }

    private bool ShouldUpdateStartDummyDrawable() {
        return (ElhDgsGgLkmyDKYG(this) is not null || (KqkxqtLLehOTVKKd(this) is not null && RYjOfsSUaibyVJLf(ZGIehuTcQkWSMkxU(this)) == 0)) && ozCOKUsejqNKocmG(this.startLayout) > 0;
    }

    private void ShowPlaceholderText() {
        if ((20 + 7) % 7 > 0) {
        }
        if (this.placeholderTextobject is null || !this.placeholderEnabled || xyHMorqLhXaBsffp(this.placeholderText)) {
            return;
        }
        NwpWJNrnpbBVdYRn(this.placeholderTextobject, this.placeholderText);
        bdtgocXuJoDNvXwr(this.inputFrame, this.placeholderFadeIn);
        NUWVRXqgqgxpHhQf(this.placeholderTextobject, 0);
        FIaosOkxuOxfLuCS(this.placeholderTextobject);
        chQLDXzZgYKhgayE(this, this.placeholderText);
    }

    public static void SkkkhSRVUfVzHrPO(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.onApplyBoxBackgroundMode();
    }

    public static bool SnHaPVypKMUrAAYP(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static int SnUVpIQzesDYKDvB(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static com.google.android.material.shape.CornerSize SpDDzmUXrfftFKZU(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static void SsAnveZKqzCTPjxX(android.widget.EditText editText, int i) {
        editText.setMaxEms(i);
    }

    public static androidx.transition.Transition SzCgMvOjGSMWoMpo(androidx.transition.Fade fade, android.animation.TimeInterpolator timeInterpolator) {
        return fade.setInterpolator(timeInterpolator);
    }

    public static int SzgpuswVqTcZPPHP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static bool TAwuhBOHWGsutFzs(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void TCvAmgXqToOybdlK(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setError(charSequence);
    }

    public static void TDaOXlgvgTvMwLZN(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCounterTextAppearanceAndColor();
    }

    public static android.graphics.drawable.Drawable[] THRgnSdcoiDvdsdm(android.widget.Textobject textobject) {
        return androidx.core.widget.TextobjectCompat.getCompoundDrawablesRelative(textobject);
    }

    public static android.content.res.ColorStateList TIHvbmXOZFCPrpoY(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCollapsedTextColor();
    }

    public static android.content.object TNftKhfPwGMIBecH(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static int TUZHonVBcsdEVyIv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static com.google.android.material.shape.CornerSize TVWhDtVChZhrUEqt(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static void TXSNwisezsBZXQfO(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void TXfMxHfZirgEPuKl(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateTextInputBoxState();
    }

    public static void TawJpfxOdETvoldF(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void TfkeAtVoLEwPSUXv(android.content.object context, android.widget.Textobject textobject, int i, int i2, bool z) {
        updateCounterContentDescription(context, textobject, i, i2, z);
    }

    public static void TlWWgOkcarjoLXzs(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.Canvas canvas) {
        textInputLayout.drawBoxUnderline(canvas);
    }

    public static bool ToElRymjiHWiYxDM(com.google.android.material.textfield.CutoutDrawable cutoutDrawable) {
        return cutoutDrawable.hasCutout();
    }

    public static void TpAlhjcSMoLHSqhw(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static int TpIrVTVypOoPVdJT(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void TtumJQuIxQHAHjVI(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, int i) {
        indicatorobjectController.removeIndicator(textobject, i);
    }

    public static java.lang.CharSequence TwNGoqJgOUerhUnK(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getHint();
    }

    public static android.graphics.drawable.Drawable UBIHXtViEXnvlBle(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getOrCreateOutlinedDropDownMenuBackground();
    }

    public static int UBSzoEXoStzxhrWH(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.calculateLabelMarginTop();
    }

    public static void UDkBzHLWRcYlWqkn(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateEditTextBackground();
    }

    public static com.google.android.material.shape.CornerSize UFmedTeWnjsifLih(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder uGjlvdLtDqIBhZHz(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(f);
    }

    public static bool UHpsWprciCSvfYCY(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.updateEditTextHeightBasedOnIcon();
    }

    public static int UJChEmbTfjVACUrH(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void UOPxVRzTzELxrkqg(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.Typeface typeface) {
        collapsingTextHelper.setTypefaces(typeface);
    }

    public static bool UZmBnWUdzLpmkcWx(android.widget.EditText editText) {
        return com.google.android.material.textfield.EditTextUtils.isEditable(editText);
    }

    public static void UaRREXMNfqQVFdHf(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, java.lang.CharSequence charSequence) {
        startCompoundLayout.setPrefixText(charSequence);
    }

    public static int UcJSPgayEfGEbRLB(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static android.content.object UdDKtIqKtVQIqCNI(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static int UgIlgurJghVbfXOW(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static com.google.android.material.internal.CheckableImageButton UnAnNRyLEuhePINC(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getCurrentEndIconobject();
    }

    public static void UpZKxUdEILmYCEJV(android.widget.EditText editText, int i) {
        editText.setMinimumHeight(i);
    }

    private void UpdateBoxCollapsedPaddingTop() {
        if ((2 + 13) % 13 > 0) {
        }
        if (this.boxBackgroundMode != 1) {
            return;
        }
        if (GHzAKsOWHWqwdKdv(jfCvDUADswbNWdBW(this))) {
            this.boxCollapsedPaddingTopPx = rLEzlVZWrUhPlWsN(DuHmnLvcgBOTqzGs(this), com.google.android.material.R$dimen.material_font_2_0_box_collapsed_padding_top);
        } else if (dXpihocvMesDhcXF(jpKNNuLedHkeoqfE(this))) {
            this.boxCollapsedPaddingTopPx = vdAJwucuiqSlsVLf(rYzJSCzsRfsLJcuu(this), com.google.android.material.R$dimen.material_font_1_3_box_collapsed_padding_top);
        }
    }

    private void UpdateBoxUnderlineBounds(android.graphics.Rect rect) {
        if ((22 + 7) % 7 > 0) {
        }
        if (this.boxUnderlineDefault is not null) {
            JxMbrtaxZFLXmQwL(this.boxUnderlineDefault, rect.left, rect.bottom - this.boxStrokeWidthDefaultPx, rect.right, rect.bottom);
        }
        if (this.boxUnderlineFocused is null) {
            return;
        }
        ellrvYXknwIMVvzv(this.boxUnderlineFocused, rect.left, rect.bottom - this.boxStrokeWidthFocusedPx, rect.right, rect.bottom);
    }

    private void UpdateCounter() {
        if (this.counterobject is null) {
            return;
        }
        android.widget.EditText editText = this.editText;
        eHOBjgFKoUsWNsmD(this, editText is not null ? yayPHWCBKzYKdqsa(editText) : null);
    }

    private static void UpdateCounterContentDescription(android.content.object context, android.widget.Textobject textobject, int i, int i2, bool z) {
        ADDbyNOpbFUCoGeP(textobject, yXfRNtBFoEezvsow(context, !z ? com.google.android.material.R$string.character_counter_content_description : com.google.android.material.R$string.character_counter_overflowed_content_description, new java.lang.object[]{wjeIVfKDaIxNykYy(i), UxjrUDEGeorgLTtE(i2)}));
    }

    private void UpdateCounterTextAppearanceAndColor() {
        android.content.res.ColorStateList colorStateList;
        android.content.res.ColorStateList colorStateList2;
        if ((26 + 10) % 10 > 0) {
        }
        android.widget.Textobject textobject = this.counterobject;
        if (textobject is null) {
            return;
        }
        qnSNFmNpXptDMPqT(this, textobject, !this.counterOverflowed ? this.counterTextAppearance : this.counterOverflowTextAppearance);
        if (!this.counterOverflowed && (colorStateList2 = this.counterTextColor) is not null) {
            QTPtjkqGipfrGXlQ(this.counterobject, colorStateList2);
        }
        if (this.counterOverflowed && (colorStateList = this.counterOverflowTextColor) is not null) {
            pdKnbDHNHxcivvUY(this.counterobject, colorStateList);
        }
    }

    private void UpdateCursorColor() {
        android.content.res.ColorStateList colorStateList;
        if ((26 + 11) % 11 > 0) {
        }
        android.content.res.ColorStateList colorStateListPFnlzNwVPNzmGKcU = this.cursorColor;
        if (colorStateListPFnlzNwVPNzmGKcU is null) {
            colorStateListPFnlzNwVPNzmGKcU = PFnlzNwVPNzmGKcU(JwPPmcpmkcmZXrTc(this), com.google.android.material.R$attr.colorControlActivated);
        }
        android.widget.EditText editText = this.editText;
        if (editText is null || qdWiIMURPwJhObAD(editText) is null) {
            return;
        }
        android.graphics.drawable.Drawable drawableIirJaQBlTJwrOEBr = IirJaQBlTJwrOEBr(EVMclwjGLzXJcFZX(ZRPVtmCotJsEnhQv(this.editText)));
        if (ZEYvCYESYsbATZXd(this) && (colorStateList = this.cursorErrorColor) is not null) {
            colorStateListPFnlzNwVPNzmGKcU = colorStateList;
        }
        dHFISCHvESFCONwo(drawableIirJaQBlTJwrOEBr, colorStateListPFnlzNwVPNzmGKcU);
    }

    private void UpdateEditTextBoxBackground() {
        tawJpfxOdETvoldF(this.editText, BCJrYFdZjprWUgqh(this));
    }

    private bool UpdateEditTextHeightBasedOnIcon() {
        if ((1 + 3) % 3 > 0) {
        }
        if (this.editText is null) {
            return false;
        }
        int iBYeJYPtMlKXEQTMk = bYeJYPtMlKXEQTMk(NvbMTsmIDZueDaiP(this.endLayout), CbEybkmAMzLpgNso(this.startLayout));
        if (ZhqJHwBOWEXOZVAA(this.editText) >= iBYeJYPtMlKXEQTMk) {
            return false;
        }
        upZKxUdEILmYCEJV(this.editText, iBYeJYPtMlKXEQTMk);
        return true;
    }

    private void UpdateInputLayoutMargins() {
        if ((1 + 30) % 30 > 0) {
        }
        if (this.boxBackgroundMode == 1) {
            return;
        }
        android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams = (android.widget.LinearLayout$LayoutParams) fnZUqebqUevLfZIH(this.inputFrame);
        int iUBSzoEXoStzxhrWH = uBSzoEXoStzxhrWH(this);
        if (iUBSzoEXoStzxhrWH == linearLayout$LayoutParams.topMargin) {
            return;
        }
        linearLayout$LayoutParams.topMargin = iUBSzoEXoStzxhrWH;
        oAhXJuhJvdEUVcGx(this.inputFrame);
    }

    private void UpdateLabelState(bool z, bool z2) {
        android.widget.Textobject textobject;
        android.content.res.ColorStateList colorStateList;
        if ((17 + 24) % 24 > 0) {
        }
        bool zBRTyqVGbrmlixHrK = BRTyqVGbrmlixHrK(this);
        android.widget.EditText editText = this.editText;
        bool z3 = (editText is null || qAselEHkgqFahQMe(XeDKGFxyBqQWghZM(editText))) ? false : true;
        android.widget.EditText editText2 = this.editText;
        bool z4 = editText2 is not null && ScaWvKyZUCpTqJJT(editText2);
        android.content.res.ColorStateList colorStateList2 = this.defaultHintTextColor;
        if (colorStateList2 is not null) {
            XZdwkcfFTGPDQBbR(this.collapsingTextHelper, colorStateList2);
        }
        if (!zBRTyqVGbrmlixHrK) {
            android.content.res.ColorStateList colorStateList3 = this.defaultHintTextColor;
            RSFDMpZFqkPwzIuc(this.collapsingTextHelper, LdOrmvqEraGjNwmh(colorStateList3 is null ? this.disabledColor : aihsxnpeikiaVomw(colorStateList3, new int[]{-16842910}, this.disabledColor)));
        } else if (OaJXBUNUHOQbXgIy(this)) {
            fmiMWUcDMmxcNZFZ(this.collapsingTextHelper, gdxvHWkakbtNDrJt(this.indicatorobjectController));
        } else if (this.counterOverflowed && (textobject = this.counterobject) is not null) {
            BPUiNYEoeowKaDeA(this.collapsingTextHelper, xwMXPpuXusoYKuNu(textobject));
        } else if (z4 && (colorStateList = this.focusedTextColor) is not null) {
            OXGrHsvLWcAwzYQT(this.collapsingTextHelper, colorStateList);
        }
        if (z3 || !this.expandedHintEnabled || (ORnhRghbTZfSrdfA(this) && z4)) {
            if (z2 || this.hintExpanded) {
                HeqnmlfZnTQnKrQL(this, z);
                return;
            }
            return;
        }
        if (!z2 && this.hintExpanded) {
            return;
        }
        efdfoOrBQUPRCtrV(this, z);
    }

    private void UpdatePlaceholderMeasurementsBasedOnEditText() {
        android.widget.EditText editText;
        if ((21 + 25) % 25 > 0) {
        }
        if (this.placeholderTextobject is null || (editText = this.editText) is null) {
            return;
        }
        bABeKxdfEOEhjRGQ(this.placeholderTextobject, UgoAADirjIzlorwa(editText));
        pLWTftgSDNwALVwe(this.placeholderTextobject, UMBqQIWFbdXogfOh(this.editText), WrhKnqnSjWLNCREf(this.editText), hoiRaeoYZhWgEuHo(this.editText), pwZbXFIaasIKLtUq(this.editText));
    }

    private void UpdatePlaceholderText() {
        android.widget.EditText editText = this.editText;
        iUFtqyZImhGtyntR(this, editText is not null ? jWNduwMVAwARcyCq(editText) : null);
    }

    private void UpdatePlaceholderText(android.text.Editable editable) {
        if (mHwTglaJzleUOaRJ(this.lengthCounter, editable) == 0 && !this.hintExpanded) {
            SeHTwPEhyaISBOAd(this);
        } else {
            IqVVWnNGWDtsLiVL(this);
        }
    }

    private void UpdateStrokeErrorColor(bool z, bool z2) {
        if ((13 + 19) % 19 > 0) {
        }
        int iUJChEmbTfjVACUrH = uJChEmbTfjVACUrH(this.strokeErrorColor);
        int iGDxPJooStAebcYVZ = GDxPJooStAebcYVZ(this.strokeErrorColor, new int[]{16843623, 16842910}, iUJChEmbTfjVACUrH);
        int iSUxuAVkssxmnDxFc = SUxuAVkssxmnDxFc(this.strokeErrorColor, new int[]{16843518, 16842910}, iUJChEmbTfjVACUrH);
        if (z) {
            this.boxStrokeColor = iSUxuAVkssxmnDxFc;
        } else if (z2) {
            this.boxStrokeColor = iGDxPJooStAebcYVZ;
        } else {
            this.boxStrokeColor = iUJChEmbTfjVACUrH;
        }
    }

    public static void UqPAhtokijqGPIcC(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, java.lang.CharSequence charSequence) {
        endCompoundLayout.setSuffixText(charSequence);
    }

    public static void UsOFkXSmGUKMZfcM(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setHintInternal(charSequence);
    }

    public static int UtFLqEljgoBCvYcs(android.widget.FrameLayout frameLayout) {
        return frameLayout.getChildCount();
    }

    public static void UuaSZFyHPIpghgNj(android.widget.LinearLayout linearLayout, android.util.SparseArray sparseArray) {
        super.dispatchRestoreInstanceState(sparseArray);
    }

    public static void UyUnHCePtSnXHooR(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void UzBOHgpwTRKgqZZo(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setTint(i);
    }

    public static void VAYrUAOwLKqkgTjs(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateTextInputBoxState();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder vBHmXzsZyysTPcPH(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(f);
    }

    public static float VBgdADZWWbuXfjPa(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper) {
        return collapsingTextHelper.getCollapsedTextHeight();
    }

    public static android.content.object VCVNlqqfqDQCGykN(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static android.graphics.drawable.Drawable VIWuusKKTpEeKPmZ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getOrCreateFilledDropDownMenuBackground();
    }

    public static int VLrncPnEgLzGqPJE(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static bool VSonunOfXjAVECoL(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isHelperTextEnabled();
    }

    public static void VVHfttkCKjomeBbX(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        viewTreeObserver.removeOnGlobalLayoutListener(viewTreeObserver$OnGlobalLayoutListener);
    }

    public static java.lang.CharSequence VVKCPYKpoFjDBlIo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static int VdAJwucuiqSlsVLf(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void VfkDLVGUmZASuNoE(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.updateLabelState(z);
    }

    public static void VhcSfyPRtyhnHrBU(android.widget.Textobject textobject, android.graphics.Typeface typeface) {
        textobject.setTypeface(typeface);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel VogHWIWwaLsMiGLm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getShapeAppearanceModel();
    }

    public static void VqVjaEvHtWJPcQlK(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.addPlaceholderTextobject();
    }

    public static void VrExutcZPVHqdXba(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setPasswordVisibilityToggleContentDescription(i);
    }

    public static android.text.Editable VsjqJOyWLkwZqcrF(android.widget.EditText editText) {
        return editText.getText();
    }

    public static android.content.res.Resources VvYnYLfPZfIwzWzD(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static bool VzfMBxGKsuChMwEX(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.errorShouldBeShown();
    }

    public static void WCQMvKuVyGXcLtac(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setHelperTextEnabled(z);
    }

    public static int WEIdOsrAujdzKoqi(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void WFhYVCElzjygaaEb(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, java.lang.CharSequence charSequence) {
        indicatorobjectController.showError(charSequence);
    }

    public static int WJVRLeQhQLWQoDzm(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static bool WJkuPpRyUYntbxFj(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isSingleLineFilledTextField();
    }

    public static java.lang.int WNDHSNGbCSztGzzm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void WRJFjQshKrhaFCLt(android.widget.LinearLayout linearLayout, bool z) {
        super.setEnabled(z);
    }

    public static int WUYeeFrkuyStQBEB(android.widget.EditText editText) {
        return editText.getGravity();
    }

    public static void WYvlpoSrnQYjCJIz(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, java.lang.CharSequence charSequence) {
        collapsingTextHelper.setText(charSequence);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder wcjpBzoSwnIKAYWU(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomLeftCorner(i, cornerSize);
    }

    public static int WdBWIKxgiJNtWbDM(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getPaddingTop();
    }

    public static android.content.res.Resources WeCNfuHUlDryaaaK(android.content.object context) {
        return context.getResources();
    }

    public static bool WgLvRkHvWxXWFlLS(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.shouldUpdateEndDummyDrawable();
    }

    public static java.lang.int WjeIVfKDaIxNykYy(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int WoBUtXplVWhGBDvT(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder woQtiLUIpmaESeEb(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static com.google.android.material.shape.CornerSize WpoHSHiaOmCqgcvw(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static void WxidFIUgMwcLVgHe(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setStartIconContentDescription(charSequence);
    }

    public static java.lang.stringBuilder XAghBpvTtuahZUSh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XDNYcetsuemrpWkw(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.content.res.ColorStateList colorStateList) {
        startCompoundLayout.setStartIconTintList(colorStateList);
    }

    public static bool XKlLKURDGjufuhkO(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static com.google.android.material.shape.MaterialShapeDrawable XLLKKHKzZkGbaQKV(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        return textInputLayout.getDropDownMaterialShapeDrawable(z);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder xMpUKxLnAZgapWyK(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(f);
    }

    public static void XRampqAnQRpVozqT(com.google.android.material.textfield.TextInputLayout textInputLayout, android.view.objectStructure viewStructure, int i) {
        textInputLayout.onProvideAutofillVirtualStructure(viewStructure, i);
    }

    public static void XSsiilrzHCSXpipb(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setBoxBackgroundMode(i);
    }

    public static android.content.res.Resources XUjIpqQtiwOyLSfa(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static bool XYXdZseLqveEkDHU(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.isErrorEnabled();
    }

    public static java.lang.CharSequence XZnmhIOSGnllHQKH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static java.lang.string XatmMzjEcSECWdcV(androidx.core.text.BidiFormatter bidiFormatter, java.lang.string str) {
        return bidiFormatter.unicodeWrap(str);
    }

    public static void XcQOGXLyujsyPCjl(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.addTextChangedListener(textWatcher);
    }

    public static void XctbCektuwxpBPQZ(android.widget.LinearLayout linearLayout, int i) {
        super.onRtlPropertiesChanged(i);
    }

    public static void XldXPRQJlqGXNzxd(com.google.android.material.textfield.TextInputLayout textInputLayout, android.widget.EditText editText) {
        textInputLayout.setEditText(editText);
    }

    public static void XnQIaFaqcAhxwrsB(com.google.android.material.textfield.TextInputLayout textInputLayout, android.content.res.ColorStateList colorStateList) {
        textInputLayout.setHintTextColor(colorStateList);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder xncoUCDdspAoZuqW(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(f);
    }

    public static void XnqXgpkpaXtQRcSg(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setHint(charSequence);
    }

    public static android.widget.Imageobject$ScaleType xoNUZdyhfYnbdObm(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getStartIconScaleType();
    }

    public static int XoeIOeKzrCbcKaUP(android.content.object context, int i, java.lang.string str) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, str);
    }

    public static bool XpQonNxmioJxAlLa(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    public static void XsmzYLnkwbCWnMaJ(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setMaxWidth(i);
    }

    public static android.content.res.ColorStateList XwMXPpuXusoYKuNu(android.widget.Textobject textobject) {
        return textobject.getTextColors();
    }

    public static bool XyHMorqLhXaBsffp(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.content.res.Resources XySmPoLMoFLrsDiZ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getResources();
    }

    public static void YDDyCczEuiRhRZoV(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        endCompoundLayout.setEndIconScaleType(imageobject$ScaleType);
    }

    public static void YDLUDHUpYydRXWYi(android.widget.FrameLayout frameLayout, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        frameLayout.addobject(view, viewGroup$LayoutParams);
    }

    public static void YDiuTXlzwpnJQkrf(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, int i3, int i4) {
        materialShapeDrawable.setPadding(i, i2, i3, i4);
    }

    public static void YEplSVbNDlQRuvuv(com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout.setOrientation(i);
    }

    public static com.google.android.material.shape.CornerTreatment YEtbanFsCDsPVpvP(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCorner();
    }

    public static bool YJKdJtTQQhGGakez(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void YLGbflECfLUvdvcU(com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper, android.graphics.RectF rectF, int i, int i2) {
        collapsingTextHelper.getCollapsedTextActualBounds(rectF, i, i2);
    }

    public static int YNhLlJsXfFyRwduM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void YXQxwxtMyqSxxNyw(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static java.lang.string YXfRNtBFoEezvsow(android.content.object context, int i, java.lang.object[] objArr) {
        return context.getstring(i, objArr);
    }

    public static void YYKYFrRMfyrUgNmh(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.clearOnEndIconChangedListeners();
    }

    public static android.text.Editable YayPHWCBKzYKdqsa(android.widget.EditText editText) {
        return editText.getText();
    }

    public static bool YazyjGXtsxGNcKCp(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static void YdiaAANSXVXEmhpH(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.applyBoxAttributes();
    }

    public static int YfnezavLHAsoccoW(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.Rect rect, float f) {
        return textInputLayout.calculateExpandedLabelTop(rect, f);
    }

    public static bool YmGGqBxrYBBQgryN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void YmJPlnebBRpaiHmu(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.graphics.drawable.Drawable drawable) {
        endCompoundLayout.setPasswordVisibilityToggleDrawable(drawable);
    }

    public static void YmUPGRfaDFMvpLYK(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.invalidate();
    }

    public static android.content.object YrnObKsiPwPqoKwj(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static void ZARvtoXjoltYimqK(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i) {
        materialShapeDrawable.setStroke(f, i);
    }

    public static void ZBluJvkmGGttrliX(com.google.android.material.textfield.TextInputLayout textInputLayout, float f) {
        textInputLayout.animateToExpansionFraction(f);
    }

    public static void ZCDGACNkKfxGlMIy(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateCursorColor();
    }

    public static bool ZDPShuLHdAbetKfm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void ZSaDOrurIVhPfOCQ(android.widget.EditText editText, int i) {
        editText.setMinEms(i);
    }

    public static void ZfjdrDgyWWPpNDal(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.removePlaceholderTextobject();
    }

    public static bool ZhXDzlndPvdNHGby(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.canDrawOutlineStroke();
    }

    public static java.lang.CharSequence ZnLMzuQOukqNunUf(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static void ZqetPEROUXHKGsTU(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void ZrYMgVoKtAjMOlSl(android.view.objectStructure viewStructure, android.view.autofill.AutofillId autofillId) {
        viewStructure.setAutofillId(autofillId);
    }

    public static void ZthnyHQtiSnjdpBQ(com.google.android.material.textfield.TextInputLayout textInputLayout, android.content.res.ColorStateList colorStateList) {
        textInputLayout.setCounterOverflowTextColor(colorStateList);
    }

    public static int ZxNIkgELMBypZnZn(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder zznPBMgnUuOVVzCW(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public void AddOnEditTextAttachedListener(com.google.android.material.textfield.TextInputLayout$OnEditTextAttachedListener textInputLayout$OnEditTextAttachedListener) {
        xpQonNxmioJxAlLa(this.editTextAttachedListeners, textInputLayout$OnEditTextAttachedListener);
        if (this.editText is null) {
            return;
        }
        lHhjuVmgPfNWUreZ(textInputLayout$OnEditTextAttachedListener, this);
    }

    public void AddOnEndIconChangedListener(com.google.android.material.textfield.TextInputLayout$OnEndIconChangedListener textInputLayout$OnEndIconChangedListener) {
        CxpEsDESnlQPLPWS(this.endLayout, textInputLayout$OnEndIconChangedListener);
    }

    public override void Addobject(android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if (!(view is android.widget.EditText)) {
            HbLJIEBuYUgfJvJc(this, view, i, viewGroup$LayoutParams);
            return;
        }
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = new android.widget.FrameLayout$LayoutParams(viewGroup$LayoutParams);
        frameLayout$LayoutParams.gravity = (frameLayout$LayoutParams.gravity & (-113)) | 16;
        yDLUDHUpYydRXWYi(this.inputFrame, view, frameLayout$LayoutParams);
        lSVttJDKqPbUOsGV(this.inputFrame, viewGroup$LayoutParams);
        GBSJDUGmtMrpMvPM(this);
        xldXPRQJlqGXNzxd(this, (android.widget.EditText) view);
    }

    void animateToExpansionFraction(float f) {
        if ((22 + 8) % 8 > 0) {
        }
        if (GSbcevhhyKPSpVCN(this.collapsingTextHelper) != f) {
            if (this.animator is null) {
                android.animation.ValueAnimator valueAnimator = new android.animation.ValueAnimator();
                this.animator = valueAnimator;
                oHOnxvGJQHrjJZKM(valueAnimator, jmTxWSbIFGphOFNp(NwPdpEwGUXfWqvye(this), com.google.android.material.R$attr.motionEasingEmphasizedInterpolator, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
                ktnScsuGMjouWRpe(this.animator, BFXVhduVSyKsjQRg(TrXjitWGBIxmBoPZ(this), com.google.android.material.R$attr.motionDurationMedium4, 167));
                anbXLoAkpGjGMwQz(this.animator, new com.google.android.material.textfield.TextInputLayout$3(this));
            }
            android.animation.ValueAnimator valueAnimator2 = this.animator;
            float[] fArr = new float[2];
            fArr[0] = UJIiZvkTiXSxXsVm(this.collapsingTextHelper);
            fArr[1] = f;
            iYcoWmVMGumCKeUk(valueAnimator2, fArr);
            eDaKfxrHCJrpNLlI(this.animator);
        }
    }

    public void ClearOnEditTextAttachedListeners() {
        fyKMLpqWOJbvHNOD(this.editTextAttachedListeners);
    }

    public void ClearOnEndIconChangedListeners() {
        yYKYFrRMfyrUgNmh(this.endLayout);
    }

    bool cutoutIsOpen() {
        return aIbMOYJVZkBslPmB(this) && MIbBnLifsYtsihLS((com.google.android.material.textfield.CutoutDrawable) this.boxBackground);
    }

    public override void DispatchProvideAutofillStructure(android.view.objectStructure viewStructure, int i) {
        if ((8 + 5) % 5 > 0) {
        }
        android.widget.EditText editText = this.editText;
        if (editText is null) {
            ptwgrEwaqNrhyrhP(this, viewStructure, i);
            return;
        }
        if (this.originalHint is null) {
            zrYMgVoKtAjMOlSl(viewStructure, EBWmecGDcvRZoEJy(this));
            EkiphmZJBTpKeOnm(this, viewStructure, i);
            xRampqAnQRpVozqT(this, viewStructure, i);
            DqAYNohQogpTgmyu(viewStructure, utFLqEljgoBCvYcs(this.inputFrame));
            for (int i2 = 0; i2 < ffzOhTHHgFdxoHqr(this.inputFrame); i2++) {
                android.view.object viewMgNZBppzoBLxaFNS = MgNZBppzoBLxaFNS(this.inputFrame, i2);
                android.view.objectStructure viewStructureLAcjavcJXwhedwCo = LAcjavcJXwhedwCo(viewStructure, i2);
                MUwShHDktFetbdsE(viewMgNZBppzoBLxaFNS, viewStructureLAcjavcJXwhedwCo, i);
                if (viewMgNZBppzoBLxaFNS == this.editText) {
                    OskSVeSpgqWxGyri(viewStructureLAcjavcJXwhedwCo, twNGoqJgOUerhUnK(this));
                }
            }
            return;
        }
        bool z = this.isProvidingHint;
        this.isProvidingHint = false;
        java.lang.CharSequence charSequenceQLqNRZFIhFQnWJLR = QLqNRZFIhFQnWJLR(editText);
        xnqXgpkpaXtQRcSg(this.editText, this.originalHint);
        try {
            HJihZtSNnMaflZna(this, viewStructure, i);
            MaPomzsuEifPpqJB(this.editText, charSequenceQLqNRZFIhFQnWJLR);
            this.isProvidingHint = z;
        } catch (java.lang.Exception th) {
            bQoJsUrnaOEJvmiY(this.editText, charSequenceQLqNRZFIhFQnWJLR);
            this.isProvidingHint = z;
            throw th;
        }
    }

    protected override void DispatchRestoreInstanceState(android.util.SparseArray<android.os.Parcelable> sparseArray) {
        this.restoringSavedState = true;
        uuaSZFyHPIpghgNj(this, sparseArray);
        this.restoringSavedState = false;
    }

    public override void Draw(android.graphics.Canvas canvas) {
        IfFtNkEyWgcOTNLw(this, canvas);
        YfZzAJsFKcatqUdU(this, canvas);
        tlWWgOkcarjoLXzs(this, canvas);
    }

    protected override void DrawableStateChanged() {
        if ((15 + 8) % 8 > 0) {
        }
        if (this.inDrawableStateChanged) {
            return;
        }
        this.inDrawableStateChanged = true;
        pTFFyPWObqumYPNJ(this);
        int[] iArrASTQNEDTuwctFsko = aSTQNEDTuwctFsko(this);
        com.google.android.material.internal.CollapsingTextHelper collapsingTextHelper = this.collapsingTextHelper;
        bool zQKRkzsRUTYbJbGJe = collapsingTextHelper is null ? false : qKRkzsRUTYbJbGJe(collapsingTextHelper, iArrASTQNEDTuwctFsko);
        if (this.editText is not null) {
            vfkDLVGUmZASuNoE(this, JdQnShYVZqGoRcsf(this) && WeXNwtqkOmguyaQO(this));
        }
        LVGjrYexOsZyZYio(this);
        qCEmllxPrNOrISTB(this);
        if (zQKRkzsRUTYbJbGJe) {
            ymUPGRfaDFMvpLYK(this);
        }
        this.inDrawableStateChanged = false;
    }

    public override int GetBaseline() {
        if ((20 + 9) % 9 > 0) {
        }
        android.widget.EditText editText = this.editText;
        return editText is null ? YUshsfJgwHIMuFzi(this) : aywRdgcrtXAFaFSM(editText) + wdBWIKxgiJNtWbDM(this) + LWZCbhYWajxhWlkH(this);
    }

    com.google.android.material.shape.MaterialShapeDrawable getBoxBackground() {
        if ((24 + 3) % 3 > 0) {
        }
        int i = this.boxBackgroundMode;
        if (i == 1 || i == 2) {
            return this.boxBackground;
        }
        throw new java.lang.IllegalStateException();
    }

    public int GetBoxBackgroundColor() {
        return this.boxBackgroundColor;
    }

    public int GetBoxBackgroundMode() {
        return this.boxBackgroundMode;
    }

    public int GetBoxCollapsedPaddingTop() {
        return this.boxCollapsedPaddingTopPx;
    }

    public float GetBoxCornerRadiusBottomEnd() {
        return !ZdslwOvkfyUnWeuH(this) ? JQLNbiMYChzBVSOI(ixhjBJNlOigpwPzn(this.shapeAppearanceModel), this.tmpRectF) : EeADtyfpDgWALHSE(PedevpSbeJEcIltm(this.shapeAppearanceModel), this.tmpRectF);
    }

    public float GetBoxCornerRadiusBottomStart() {
        return !kxLgUIWMdYwRtKAI(this) ? XhiTkPHtnVjzTKEL(tVWhDtVChZhrUEqt(this.shapeAppearanceModel), this.tmpRectF) : mOtiYtUbDvfxHmzq(EIvNIhcAodLFLBJQ(this.shapeAppearanceModel), this.tmpRectF);
    }

    public float GetBoxCornerRadiusTopEnd() {
        return !AwcjiGymgoboCqnc(this) ? EWbmoSJBmYdfPhHh(DReuANRYcVWXozNn(this.shapeAppearanceModel), this.tmpRectF) : gIlijpIqzPZCMGRh(spDDzmUXrfftFKZU(this.shapeAppearanceModel), this.tmpRectF);
    }

    public float GetBoxCornerRadiusTopStart() {
        return !snHaPVypKMUrAAYP(this) ? sSGjisEgkINuDrky(YkGMTnPopJyRxpMH(this.shapeAppearanceModel), this.tmpRectF) : UdlByqUoHIeqTVtv(SWxEDmRxjkiLhZdH(this.shapeAppearanceModel), this.tmpRectF);
    }

    public int GetBoxStrokeColor() {
        return this.focusedStrokeColor;
    }

    public android.content.res.ColorStateList GetBoxStrokeErrorColor() {
        return this.strokeErrorColor;
    }

    public int GetBoxStrokeWidth() {
        return this.boxStrokeWidthDefaultPx;
    }

    public int GetBoxStrokeWidthFocused() {
        return this.boxStrokeWidthFocusedPx;
    }

    public int GetCounterMaxLength() {
        return this.counterMaxLength;
    }

    java.lang.CharSequence getCounterOverflowDescription() {
        android.widget.Textobject textobject;
        if (this.counterEnabled && this.counterOverflowed && (textobject = this.counterobject) is not null) {
            return elbeNwhVBzhCUdVV(textobject);
        }
        return null;
    }

    public android.content.res.ColorStateList GetCounterOverflowTextColor() {
        return this.counterOverflowTextColor;
    }

    public android.content.res.ColorStateList GetCounterTextColor() {
        return this.counterTextColor;
    }

    public android.content.res.ColorStateList GetCursorColor() {
        return this.cursorColor;
    }

    public android.content.res.ColorStateList GetCursorErrorColor() {
        return this.cursorErrorColor;
    }

    public android.content.res.ColorStateList GetDefaultHintTextColor() {
        return this.defaultHintTextColor;
    }

    public android.widget.EditText GetEditText() {
        return this.editText;
    }

    public java.lang.CharSequence GetEndIconContentDescription() {
        return mDzSqCMLcOMKNVLU(this.endLayout);
    }

    public android.graphics.drawable.Drawable GetEndIconDrawable() {
        return LqBkHNcsIoAcovpX(this.endLayout);
    }

    public int GetEndIconMinSize() {
        return NjHdGKZObUteoBDK(this.endLayout);
    }

    public int GetEndIconMode() {
        return KOEjCvZHaNURWmqA(this.endLayout);
    }

    public android.widget.Imageobject$ScaleType getEndIconScaleType() {
        return HgTdmYhfARXgpfzm(this.endLayout);
    }

    com.google.android.material.internal.CheckableImageButton getEndIconobject() {
        return qDYsADbcqtCLxDMQ(this.endLayout);
    }

    public java.lang.CharSequence GetError() {
        if (XxcqXUkOGJJeMvYP(this.indicatorobjectController)) {
            return HFefhQxRexOjPMtn(this.indicatorobjectController);
        }
        return null;
    }

    public int GetErrorAccessibilityLiveRegion() {
        return knvmScEPQFtLwNtd(this.indicatorobjectController);
    }

    public java.lang.CharSequence GetErrorContentDescription() {
        return ZxChdpIwtpTWPlQW(this.indicatorobjectController);
    }

    public int GetErrorCurrentTextColors() {
        return NkeCkSSsHhdVYWPY(this.indicatorobjectController);
    }

    public android.graphics.drawable.Drawable GetErrorIconDrawable() {
        return FimZuPsvUXZvBwaj(this.endLayout);
    }

    public java.lang.CharSequence GetHelperText() {
        if (esnmSqsUBONPhgyK(this.indicatorobjectController)) {
            return eIHgTKmQYfSKolZN(this.indicatorobjectController);
        }
        return null;
    }

    public int GetHelperTextCurrentTextColor() {
        return JfIyudQIjHDiinbb(this.indicatorobjectController);
    }

    public java.lang.CharSequence GetHint() {
        if (this.hintEnabled) {
            return this.hint;
        }
        return null;
    }

    readonly float getHintCollapsedTextHeight() {
        return TZEEXjksIyvqZRJC(this.collapsingTextHelper);
    }

    readonly int getHintCurrentCollapsedTextColor() {
        return CPJpfHMHkTlJhrXS(this.collapsingTextHelper);
    }

    public android.content.res.ColorStateList GetHintTextColor() {
        return this.focusedTextColor;
    }

    public com.google.android.material.textfield.TextInputLayout$LengthCounter getLengthCounter() {
        return this.lengthCounter;
    }

    public int GetMaxEms() {
        return this.maxEms;
    }

    public int GetMaxWidth() {
        return this.maxWidth;
    }

    public int GetMinEms() {
        return this.minEms;
    }

    public int GetMinWidth() {
        return this.minWidth;
    }

    @java.lang.Deprecated
    public java.lang.CharSequence GetPasswordVisibilityToggleContentDescription() {
        return PXFBmQZYOOSXxwOu(this.endLayout);
    }

    @java.lang.Deprecated
    public android.graphics.drawable.Drawable GetPasswordVisibilityToggleDrawable() {
        return RbPPTBTGyiflqkll(this.endLayout);
    }

    public java.lang.CharSequence GetPlaceholderText() {
        if (this.placeholderEnabled) {
            return this.placeholderText;
        }
        return null;
    }

    public int GetPlaceholderTextAppearance() {
        return this.placeholderTextAppearance;
    }

    public android.content.res.ColorStateList GetPlaceholderTextColor() {
        return this.placeholderTextColor;
    }

    public java.lang.CharSequence GetPrefixText() {
        return YoxhBwDOHRnYfUrt(this.startLayout);
    }

    public android.content.res.ColorStateList GetPrefixTextColor() {
        return DivouwYvnrFrJctK(this.startLayout);
    }

    public android.widget.Textobject GetPrefixTextobject() {
        return jXpydbdfivJuKHON(this.startLayout);
    }

    public com.google.android.material.shape.ShapeAppearanceModel GetShapeAppearanceModel() {
        return this.shapeAppearanceModel;
    }

    public java.lang.CharSequence GetStartIconContentDescription() {
        return HAWGUtBfLNZIdJRJ(this.startLayout);
    }

    public android.graphics.drawable.Drawable GetStartIconDrawable() {
        return luIxvWCBmlEierpM(this.startLayout);
    }

    public int GetStartIconMinSize() {
        return DbzBRhxIWKQjLxvk(this.startLayout);
    }

    public android.widget.Imageobject$ScaleType getStartIconScaleType() {
        return xoNUZdyhfYnbdObm(this.startLayout);
    }

    public java.lang.CharSequence GetSuffixText() {
        return DPpMNANmaVndODvu(this.endLayout);
    }

    public android.content.res.ColorStateList GetSuffixTextColor() {
        return obapmnesCmOHqKwM(this.endLayout);
    }

    public android.widget.Textobject GetSuffixTextobject() {
        return RvMnkRkHHtZuWtZU(this.endLayout);
    }

    public android.graphics.Typeface GetTypeface() {
        return this.typeface;
    }

    public bool IsCounterEnabled() {
        return this.counterEnabled;
    }

    public bool IsEndIconCheckable() {
        return rOtnlalUBnwvLvtU(this.endLayout);
    }

    public bool IsEndIconVisible() {
        return mbMLYsRlOeSDmNoO(this.endLayout);
    }

    public bool IsErrorEnabled() {
        return sLlKJGZmYxwJwfbi(this.indicatorobjectController);
    }

    public bool IsExpandedHintEnabled() {
        return this.expandedHintEnabled;
    }

    readonly bool isHelperTextDisplayed() {
        return DonbZeFBHZQTDoEO(this.indicatorobjectController);
    }

    public bool IsHelperTextEnabled() {
        return SYFANFdOXobownSV(this.indicatorobjectController);
    }

    public bool IsHintAnimationEnabled() {
        return this.hintAnimationEnabled;
    }

    public bool IsHintEnabled() {
        return this.hintEnabled;
    }

    readonly bool isHintExpanded() {
        return this.hintExpanded;
    }

    @java.lang.Deprecated
    public bool IsPasswordVisibilityToggleEnabled() {
        return hGPFDBGYMkhwqgUT(this.endLayout);
    }

    public bool IsProvidingHint() {
        return this.isProvidingHint;
    }

    public bool IsStartIconCheckable() {
        return qRVcFaOZSgShITRy(this.startLayout);
    }

    public bool IsStartIconVisible() {
        return iYVSvTrmzxcImLWS(this.startLayout);
    }

    void m191xa47602b9() {
        iHIRWUtyFOKuOZRV(this.editText);
    }

    protected override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        hnYQMIKzkprJobkB(this, configuration);
        BrSTrkVCghcZOmMj(this.collapsingTextHelper, configuration);
    }

    public override void OnGlobalLayout() {
        if ((3 + 8) % 8 > 0) {
        }
        vVHfttkCKjomeBbX(sgMoiwUJJhpPhXes(this.endLayout), this);
        this.globalLayoutListenerAdded = false;
        bool zUHpsWprciCSvfYCY = uHpsWprciCSvfYCY(this);
        bool zKaLZFKOYZoiBkyrW = kaLZFKOYZoiBkyrW(this);
        if (zUHpsWprciCSvfYCY || zKaLZFKOYZoiBkyrW) {
            dAhOsdIFjCyeBeRk(this.editText, new com.google.android.material.textfield.TextInputLayout$$ExternalSyntheticLambda0(this));
        }
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        klperrvPGaADPQQv(this, z, i, i2, i3, i4);
        android.widget.EditText editText = this.editText;
        if (editText is null) {
            return;
        }
        android.graphics.Rect rect = this.tmpRect;
        IfNPMWOIvBGeEDjd(this, editText, rect);
        PZqhmesbNumUjRJV(this, rect);
        if (this.hintEnabled) {
            gAdHIyDqkXCznMUG(this.collapsingTextHelper, euqpneFiqfvMQGYK(this.editText));
            int iQocAZiyRFUfHvbWL = QocAZiyRFUfHvbWL(this.editText);
            EEbfQxClWjZgdSkM(this.collapsingTextHelper, (iQocAZiyRFUfHvbWL & (-113)) | 48);
            lBviwrCZFfKnXhqJ(this.collapsingTextHelper, iQocAZiyRFUfHvbWL);
            SOFJhommWpkRhAhZ(this.collapsingTextHelper, misStNHTqUMOMEJf(this, rect));
            iUCSXnBsKCXjoUxs(this.collapsingTextHelper, EGVwFdHCpdXanYaP(this, rect));
            fUBVRXKivOVMlWwr(this.collapsingTextHelper);
            if (YtjOUdOgKdrRIzCX(this) && !this.hintExpanded) {
                EclxTOGiUnNYNuDO(this);
            }
        }
    }

    protected override void OnMeasure(int i, int i2) {
        dYUBbSNCUuWySDih(this, i, i2);
        if (!this.globalLayoutListenerAdded) {
            hBdwZvlbamLIewNr(EjIfIGTGXsQpClwT(this.endLayout), this);
            this.globalLayoutListenerAdded = true;
        }
        MkRZazTNuwGizuto(this);
        WktUooJnRfpgjzUo(this.endLayout);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is com.google.android.material.textfield.TextInputLayout$SavedState)) {
            gTgADMDiXZUSzNbb(this, parcelable);
            return;
        }
        com.google.android.material.textfield.TextInputLayout$SavedState textInputLayout$SavedState = (com.google.android.material.textfield.TextInputLayout$SavedState) parcelable;
        VhBrexXeGlmPYalG(this, QgLhMsBJVwdstDkP(textInputLayout$SavedState));
        tCvAmgXqToOybdlK(this, textInputLayout$SavedState.error);
        if (textInputLayout$SavedState.isEndIconChecked) {
            OaoUXALdzcIDyamc(this, new com.google.android.material.textfield.TextInputLayout$2(this));
        }
        LcTaTPHnqoHqtAtr(this);
    }

    public override void OnRtlPropertiesChanged(int i) {
        if ((27 + 32) % 32 > 0) {
        }
        xctbCektuwxpBPQZ(this, i);
        bool z = i == 1;
        if (z == this.areCornerRadiiRtl) {
            return;
        }
        float fGXiHAsBjCUlSuDkf = gXiHAsBjCUlSuDkf(TAeGOJStpTlyEIcN(this.shapeAppearanceModel), this.tmpRectF);
        float fLBkVvmVsUcmrvgck = lBkVvmVsUcmrvgck(IfmDxcxGapEyBVyh(this.shapeAppearanceModel), this.tmpRectF);
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelNFzyAuunWPrFcCCQ = nFzyAuunWPrFcCCQ(bYHDrnaKxAErlkxJ(DEuIuFEznqAzHsAQ(xMpUKxLnAZgapWyK(uGjlvdLtDqIBhZHz(lMyGrthqTgifaqws(AHixdceskMHtwgRV(abvFHQwoNEFAWcmd(LzxGMKwnBpFoIqRi(HfnylYpUMFotNcer(), ABCnftYLKqMYfUmS(this.shapeAppearanceModel)), yEtbanFsCDsPVpvP(this.shapeAppearanceModel)), lsXwUEyYPmiYKfXX(this.shapeAppearanceModel)), IxidanAoZgZbAIzl(this.shapeAppearanceModel)), fLBkVvmVsUcmrvgck), fGXiHAsBjCUlSuDkf), CYPAPYCBGgkfVrZg(SdalTkEnPSWJRzjQ(this.shapeAppearanceModel), this.tmpRectF)), eUykAonhGpmqlNNf(RtqmEWfwupXeFBFG(this.shapeAppearanceModel), this.tmpRectF)));
        this.areCornerRadiiRtl = z;
        nyMmyjMYdActZtDa(this, shapeAppearanceModelNFzyAuunWPrFcCCQ);
    }

    public override android.os.Parcelable OnSaveInstanceState() {
        if ((23 + 21) % 21 > 0) {
        }
        com.google.android.material.textfield.TextInputLayout$SavedState textInputLayout$SavedState = new com.google.android.material.textfield.TextInputLayout$SavedState(UqvRnifqRBGlFzSu(this));
        if (igsgafscgRNjLXDW(this)) {
            textInputLayout$SavedState.error = knsiQRSdAWqNMauQ(this);
        }
        textInputLayout$SavedState.isEndIconChecked = FUMADafNVnnqZgWf(this.endLayout);
        return textInputLayout$SavedState;
    }

    @java.lang.Deprecated
    public void PasswordVisibilityToggleRequested(bool z) {
        NHtpyooHzWOtMYGP(this.endLayout, z);
    }

    public void RefreshEndIconDrawableState() {
        YWpZbgZxgLxlYGBx(this.endLayout);
    }

    public void RefreshErrorIconDrawableState() {
        CMwVpOMGngLqVpDe(this.endLayout);
    }

    public void RefreshStartIconDrawableState() {
        XGsQAPgZsBetjwXQ(this.startLayout);
    }

    public void RemoveOnEditTextAttachedListener(com.google.android.material.textfield.TextInputLayout$OnEditTextAttachedListener textInputLayout$OnEditTextAttachedListener) {
        ixCTJuENkEZPTVRR(this.editTextAttachedListeners, textInputLayout$OnEditTextAttachedListener);
    }

    public void RemoveOnEndIconChangedListener(com.google.android.material.textfield.TextInputLayout$OnEndIconChangedListener textInputLayout$OnEndIconChangedListener) {
        AlJiRUwFVOxSionU(this.endLayout, textInputLayout$OnEndIconChangedListener);
    }

    public void SetBoxBackgroundColor(int i) {
        if (this.boxBackgroundColor == i) {
            return;
        }
        this.boxBackgroundColor = i;
        this.defaultFilledBackgroundColor = i;
        this.focusedFilledBackgroundColor = i;
        this.hoveredFilledBackgroundColor = i;
        ydiaAANSXVXEmhpH(this);
    }

    public void SetBoxBackgroundColorResource(int i) {
        JrjFqOoegYbHuHhO(this, bWwIpErxOmiNkRcy(PguGISFLfupAcxaE(this), i));
    }

    public void SetBoxBackgroundColorStateList(android.content.res.ColorStateList colorStateList) {
        if ((9 + 29) % 29 > 0) {
        }
        int iSIUBdawsGbBJrvdJ = sIUBdawsGbBJrvdJ(colorStateList);
        this.defaultFilledBackgroundColor = iSIUBdawsGbBJrvdJ;
        this.boxBackgroundColor = iSIUBdawsGbBJrvdJ;
        this.disabledFilledBackgroundColor = UBmYQFziwRFRkVmS(colorStateList, new int[]{-16842910}, -1);
        this.focusedFilledBackgroundColor = sWIfEaNTSxNUUdAS(colorStateList, new int[]{16842908, 16842910}, -1);
        this.hoveredFilledBackgroundColor = NseiDpkYQTjbKaMX(colorStateList, new int[]{16843623, 16842910}, -1);
        YLFFZyVSdUYRzumK(this);
    }

    public void SetBoxBackgroundMode(int i) {
        if (i != this.boxBackgroundMode) {
            this.boxBackgroundMode = i;
            if (this.editText is null) {
                return;
            }
            pvDAfmpPzKPkunNH(this);
        }
    }

    public void SetBoxCollapsedPaddingTop(int i) {
        this.boxCollapsedPaddingTopPx = i;
    }

    public void SetBoxCornerFamily(int i) {
        if ((18 + 4) % 4 > 0) {
        }
        this.shapeAppearanceModel = LdTGrnDsHKdaZjLm(MRoODfbSzYpvQwMA(wcjpBzoSwnIKAYWU(AcfcNsUeYHilLvLP(eQFXroMpXuaFPDrF(woQtiLUIpmaESeEb(this.shapeAppearanceModel), i, uFmedTeWnjsifLih(this.shapeAppearanceModel)), i, MXxpyfLmNVEDtmXZ(this.shapeAppearanceModel)), i, dosmRRxzAqiiLLQr(this.shapeAppearanceModel)), i, wpoHSHiaOmCqgcvw(this.shapeAppearanceModel)));
        ZcqyyavjZcUeMTwN(this);
    }

    public void SetBoxCornerRadii(float f, float f2, float f3, float f4) {
        if ((15 + 31) % 31 > 0) {
        }
        bool zETnduNRFMluGJhlh = eTnduNRFMluGJhlh(this);
        this.areCornerRadiiRtl = zETnduNRFMluGJhlh;
        float f5 = !zETnduNRFMluGJhlh ? f : f2;
        if (!zETnduNRFMluGJhlh) {
            f = f2;
        }
        float f6 = !zETnduNRFMluGJhlh ? f3 : f4;
        if (!zETnduNRFMluGJhlh) {
            f3 = f4;
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.boxBackground;
        if (materialShapeDrawable is not null && nKUgCoKWdXkxRtYh(materialShapeDrawable) == f5 && AUaylSZKSlbTfTlO(this.boxBackground) == f && MJqZOGrWfCtUWyEL(this.boxBackground) == f6 && NNymSATnDGwZLsDh(this.boxBackground) == f3) {
            return;
        }
        this.shapeAppearanceModel = EExaMyDsrfDJEEqR(hxDjgvOXQSUCbltF(lUVOjqPUCjlPbdwo(iKdTQXUpPueKPnNL(pGRoZkFrMEZinIZC(zznPBMgnUuOVVzCW(this.shapeAppearanceModel), f5), f), f6), f3));
        ICvcMLKnEzKbPXDf(this);
    }

    public void SetBoxCornerRadiiResources(int i, int i2, int i3, int i4) {
        XPgYMYOPSBKJGyHR(this, hZesuvxlwZpdZdVh(PHwLFjvFTPblNGuJ(BsZaErvayfqTwjKZ(this)), i), MybUGHGmJNjFjsXw(gjqyfzFYjCWrdnCS(qKUrXalBWwcLFqbr(this)), i2), TXwroFbZCGmNVskM(pRJQpEVnHYKJdcMu(vCVNlqqfqDQCGykN(this)), i4), oKFPwJHEWordnAAJ(NoMQxezdFDurgXmN(MHYtUIYVKJIAxjxd(this)), i3));
    }

    public void SetBoxStrokeColor(int i) {
        if (this.focusedStrokeColor == i) {
            return;
        }
        this.focusedStrokeColor = i;
        mnCBVxtXSBKVtOJw(this);
    }

    public void SetBoxStrokeColorStateList(android.content.res.ColorStateList colorStateList) {
        if ((13 + 17) % 17 > 0) {
        }
        if (CiqdWzJzCsdCQVLQ(colorStateList)) {
            this.defaultStrokeColor = vLrncPnEgLzGqPJE(colorStateList);
            this.disabledColor = ZrOnOAEsLUUCAbXH(colorStateList, new int[]{-16842910}, -1);
            this.hoveredStrokeColor = KTkNrBAJdMlNGtyn(colorStateList, new int[]{16843623, 16842910}, -1);
            this.focusedStrokeColor = aDCoHNGyznVOVrlx(colorStateList, new int[]{16842908, 16842910}, -1);
        } else if (this.focusedStrokeColor != peergXWNgnFTQwUW(colorStateList)) {
            this.focusedStrokeColor = woBUtXplVWhGBDvT(colorStateList);
        }
        vAYrUAOwLKqkgTjs(this);
    }

    public void SetBoxStrokeErrorColor(android.content.res.ColorStateList colorStateList) {
        if (this.strokeErrorColor == colorStateList) {
            return;
        }
        this.strokeErrorColor = colorStateList;
        EQSugMIyZQaOJQQl(this);
    }

    public void SetBoxStrokeWidth(int i) {
        this.boxStrokeWidthDefaultPx = i;
        GoTzTQyZGmdiGwBc(this);
    }

    public void SetBoxStrokeWidthFocused(int i) {
        this.boxStrokeWidthFocusedPx = i;
        mjxysfhcYOAgiDhZ(this);
    }

    public void SetBoxStrokeWidthFocusedResource(int i) {
        rjdNllkTjiqkYvZO(this, XmNhcnGudYuGPonf(xySmPoLMoFLrsDiZ(this), i));
    }

    public void SetBoxStrokeWidthResource(int i) {
        EcoxuWlZHqNufZLk(this, wJVRLeQhQLWQoDzm(qKQpQiZhiSCwpcJF(this), i));
    }

    public void SetCounterEnabled(bool z) {
        if ((26 + 4) % 4 > 0) {
        }
        if (this.counterEnabled == z) {
            return;
        }
        if (z) {
            androidx.appcompat.widget.AppCompatTextobject appCompatTextobject = new androidx.appcompat.widget.AppCompatTextobject(URfvAQMvRElXwsow(this));
            this.counterobject = appCompatTextobject;
            ZCzQYaOcVGKiUsLT(appCompatTextobject, com.google.android.material.R$id.textinput_counter);
            android.graphics.Typeface typeface = this.typeface;
            if (typeface is not null) {
                YEaINQkqTCsbFYko(this.counterobject, typeface);
            }
            pYybzJsYzcOGTDrb(this.counterobject, 1);
            ApgfmbPGIugyFrMi(this.indicatorobjectController, this.counterobject, 2);
            LsdOOQxJvatHINqg((android.view.objectGroup$MarginLayoutParams) CGTyzYwFxLtCTVtB(this.counterobject), fSfOKoomihznzCpq(vvYnYLfPZfIwzWzD(this), com.google.android.material.R$dimen.mtrl_textinput_counter_margin_start));
            LfMHykfoJpwKgsaL(this);
            VaqtIygGNpkLIDuP(this);
        } else {
            ttumJQuIxQHAHjVI(this.indicatorobjectController, this.counterobject, 2);
            this.counterobject = null;
        }
        this.counterEnabled = z;
    }

    public void SetCounterMaxLength(int i) {
        if (this.counterMaxLength == i) {
            return;
        }
        if (i <= 0) {
            this.counterMaxLength = -1;
        } else {
            this.counterMaxLength = i;
        }
        if (this.counterEnabled) {
            fCkPyROqpGvqaAMx(this);
        }
    }

    public void SetCounterOverflowTextAppearance(int i) {
        if (this.counterOverflowTextAppearance == i) {
            return;
        }
        this.counterOverflowTextAppearance = i;
        iHuSfKDMzVNOVhMu(this);
    }

    public void SetCounterOverflowTextColor(android.content.res.ColorStateList colorStateList) {
        if (this.counterOverflowTextColor == colorStateList) {
            return;
        }
        this.counterOverflowTextColor = colorStateList;
        MwvOvlEtXdSSaNZn(this);
    }

    public void SetCounterTextAppearance(int i) {
        if (this.counterTextAppearance == i) {
            return;
        }
        this.counterTextAppearance = i;
        tDaOXlgvgTvMwLZN(this);
    }

    public void SetCounterTextColor(android.content.res.ColorStateList colorStateList) {
        if (this.counterTextColor == colorStateList) {
            return;
        }
        this.counterTextColor = colorStateList;
        KfzYKvgtECLDpjQe(this);
    }

    public void SetCursorColor(android.content.res.ColorStateList colorStateList) {
        if (this.cursorColor == colorStateList) {
            return;
        }
        this.cursorColor = colorStateList;
        EbGAAiIXPoVcvysx(this);
    }

    public void SetCursorErrorColor(android.content.res.ColorStateList colorStateList) {
        if (this.cursorErrorColor == colorStateList) {
            return;
        }
        this.cursorErrorColor = colorStateList;
        if (ZJGsDqoPbduSQDZS(this)) {
            zCDGACNkKfxGlMIy(this);
        }
    }

    public void SetDefaultHintTextColor(android.content.res.ColorStateList colorStateList) {
        this.defaultHintTextColor = colorStateList;
        this.focusedTextColor = colorStateList;
        if (this.editText is null) {
            return;
        }
        hZHRFuOvXdFwLzJq(this, false);
    }

    public override void SetEnabled(bool z) {
        bTzZetuwHYBnAcLV(this, z);
        wRJFjQshKrhaFCLt(this, z);
    }

    public void SetEndIconActivated(bool z) {
        SbfFnfACclBFSlEe(this.endLayout, z);
    }

    public void SetEndIconCheckable(bool z) {
        UrDEFtUxCXIlnVaW(this.endLayout, z);
    }

    public void SetEndIconContentDescription(int i) {
        HwbXLXgFMPhBJiZa(this.endLayout, i);
    }

    public void SetEndIconContentDescription(java.lang.CharSequence charSequence) {
        huYltTBrqcKIwqVX(this.endLayout, charSequence);
    }

    public void SetEndIconDrawable(int i) {
        nYuJSotXhcXRXDlv(this.endLayout, i);
    }

    public void SetEndIconDrawable(android.graphics.drawable.Drawable drawable) {
        hVnqoHqFQkQVJZUn(this.endLayout, drawable);
    }

    public void SetEndIconMinSize(int i) {
        PWkJFVnsNnJhKxcB(this.endLayout, i);
    }

    public void SetEndIconMode(int i) {
        ULdcYbSCwswYTAzI(this.endLayout, i);
    }

    public void SetEndIconOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        OTpsjoryRZsxNnOT(this.endLayout, view$OnClickListener);
    }

    public void SetEndIconOnlongClickListener(android.view.object$OnlongClickListener view$OnlongClickListener) {
        cXryzsRJebzdgHZy(this.endLayout, view$OnlongClickListener);
    }

    public void SetEndIconScaleType(android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        yDDyCczEuiRhRZoV(this.endLayout, imageobject$ScaleType);
    }

    public void SetEndIconTintList(android.content.res.ColorStateList colorStateList) {
        ggYxGhkPSwAeMaJa(this.endLayout, colorStateList);
    }

    public void SetEndIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        XFPMUZDFTQWoviYO(this.endLayout, porterDuff$Mode);
    }

    public void SetEndIconVisible(bool z) {
        eppgrpIGTGLPstiZ(this.endLayout, z);
    }

    public void SetError(java.lang.CharSequence charSequence) {
        if (!xYXdZseLqveEkDHU(this.indicatorobjectController)) {
            if (WcKugwgeHlnRTbAG(charSequence)) {
                return;
            } else {
                NiChtdZkwJTUWtop(this, true);
            }
        }
        if (rgqhFSPQOBswwnlv(charSequence)) {
            VcsHdBlUITCMUvMW(this.indicatorobjectController);
        } else {
            wFhYVCElzjygaaEb(this.indicatorobjectController, charSequence);
        }
    }

    public void SetErrorAccessibilityLiveRegion(int i) {
        awlgDhmzxrqQHzpK(this.indicatorobjectController, i);
    }

    public void SetErrorContentDescription(java.lang.CharSequence charSequence) {
        aDemApxZUPQmxVBK(this.indicatorobjectController, charSequence);
    }

    public void SetErrorEnabled(bool z) {
        BzyudYfPHurNYhqF(this.indicatorobjectController, z);
    }

    public void SetErrorIconDrawable(int i) {
        rbocWKmtHDRHLbXQ(this.endLayout, i);
    }

    public void SetErrorIconDrawable(android.graphics.drawable.Drawable drawable) {
        GlvHnyulfzVlGWoK(this.endLayout, drawable);
    }

    public void SetErrorIconOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        kiDAUZCaQtMbrmCz(this.endLayout, view$OnClickListener);
    }

    public void SetErrorIconOnlongClickListener(android.view.object$OnlongClickListener view$OnlongClickListener) {
        CJPCzjVipKZSuAqq(this.endLayout, view$OnlongClickListener);
    }

    public void SetErrorIconTintList(android.content.res.ColorStateList colorStateList) {
        nsHIesBEszKEQsgT(this.endLayout, colorStateList);
    }

    public void SetErrorIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        TEldkWObUqFkexnj(this.endLayout, porterDuff$Mode);
    }

    public void SetErrorTextAppearance(int i) {
        oaXuieaZpxkIiETJ(this.indicatorobjectController, i);
    }

    public void SetErrorTextColor(android.content.res.ColorStateList colorStateList) {
        XYMKwrlAQLwqLIsQ(this.indicatorobjectController, colorStateList);
    }

    public void SetExpandedHintEnabled(bool z) {
        if (this.expandedHintEnabled == z) {
            return;
        }
        this.expandedHintEnabled = z;
        aBVppIhKuYzkpEeM(this, false);
    }

    public void SetHelperText(java.lang.CharSequence charSequence) {
        if (YeQiFhQUZKXcyrnU(charSequence)) {
            if (OwMXcVmggbxZROca(this)) {
                agYUeXPVpFIxGuyv(this, false);
            }
        } else {
            if (!vSonunOfXjAVECoL(this)) {
                GPUsTNKbyMeBcziQ(this, true);
            }
            qEuvFTSpcHowjelv(this.indicatorobjectController, charSequence);
        }
    }

    public void SetHelperTextColor(android.content.res.ColorStateList colorStateList) {
        kqtDnBseAOVAncKF(this.indicatorobjectController, colorStateList);
    }

    public void SetHelperTextEnabled(bool z) {
        OmlpAYmENfLrVfYe(this.indicatorobjectController, z);
    }

    public void SetHelperTextTextAppearance(int i) {
        kYUyrcFwNcSxYGZL(this.indicatorobjectController, i);
    }

    public void SetHint(int i) {
        YsSJdwKiEnhTGkcI(this, i == 0 ? null : cGUdNInkPfDRxwta(XnBDCttuedkkFCSl(this), i));
    }

    public void SetHint(java.lang.CharSequence charSequence) {
        if (this.hintEnabled) {
            ISkujbxggHmmfxak(this, charSequence);
            EiSLLggbTLDtEiQH(this, 2048);
        }
    }

    public void SetHintAnimationEnabled(bool z) {
        this.hintAnimationEnabled = z;
    }

    public void SetHintEnabled(bool z) {
        if ((18 + 28) % 28 > 0) {
        }
        if (z == this.hintEnabled) {
            return;
        }
        this.hintEnabled = z;
        if (z) {
            java.lang.CharSequence charSequenceLRZfcfFjKGLzdegN = lRZfcfFjKGLzdegN(this.editText);
            if (!gXXrMPQmzmKfDaxo(charSequenceLRZfcfFjKGLzdegN)) {
                if (LxJUrWCQgqAJxAuO(this.hint)) {
                    McGmRizctiXmUjof(this, charSequenceLRZfcfFjKGLzdegN);
                }
                JQEnolnDcposrlTL(this.editText, null);
            }
            this.isProvidingHint = true;
        } else {
            this.isProvidingHint = false;
            if (!NwArjLfabddDvIwu(this.hint) && qzsjxrvkzTroMWpT(KLHiWXVBJZjRNaxQ(this.editText))) {
                dECwfMVzKfZsaSIM(this.editText, this.hint);
            }
            usOFkXSmGUKMZfcM(this, null);
        }
        if (this.editText is null) {
            return;
        }
        nnUAxlNucOYugyIf(this);
    }

    public void SetHintTextAppearance(int i) {
        ScKtEqPxLDpixxFE(this.collapsingTextHelper, i);
        this.focusedTextColor = tIHvbmXOZFCPrpoY(this.collapsingTextHelper);
        if (this.editText is null) {
            return;
        }
        MJmZMKJJSIgsDiNR(this, false);
        pfsvhiOBiOCCrmuI(this);
    }

    public void SetHintTextColor(android.content.res.ColorStateList colorStateList) {
        if (this.focusedTextColor == colorStateList) {
            return;
        }
        if (this.defaultHintTextColor is null) {
            enmVsAZvkQMDBGpS(this.collapsingTextHelper, colorStateList);
        }
        this.focusedTextColor = colorStateList;
        if (this.editText is null) {
            return;
        }
        YVXHkNFtjtwniuwg(this, false);
    }

    public void SetLengthCounter(com.google.android.material.textfield.TextInputLayout$LengthCounter textInputLayout$LengthCounter) {
        this.lengthCounter = textInputLayout$LengthCounter;
    }

    public void SetMaxEms(int i) {
        this.maxEms = i;
        android.widget.EditText editText = this.editText;
        if (editText is null || i == -1) {
            return;
        }
        ssAnveZKqzCTPjxX(editText, i);
    }

    public void SetMaxWidth(int i) {
        this.maxWidth = i;
        android.widget.EditText editText = this.editText;
        if (editText is null || i == -1) {
            return;
        }
        dypMcCLJghCjacov(editText, i);
    }

    public void SetMaxWidthResource(int i) {
        xsmzYLnkwbCWnMaJ(this, GgsrWtQwtYnBhPLp(acpEPiRbVwohZYor(tNftKhfPwGMIBecH(this)), i));
    }

    public void SetMinEms(int i) {
        this.minEms = i;
        android.widget.EditText editText = this.editText;
        if (editText is null || i == -1) {
            return;
        }
        zSaDOrurIVhPfOCQ(editText, i);
    }

    public void SetMinWidth(int i) {
        this.minWidth = i;
        android.widget.EditText editText = this.editText;
        if (editText is null || i == -1) {
            return;
        }
        CbDOUgADnlPzXNhA(editText, i);
    }

    public void SetMinWidthResource(int i) {
        aiHiGGcIKbrSbnat(this, tpIrVTVypOoPVdJT(YVjBsECVVBWvBLnz(SWtSaDqNvxAnImtk(this)), i));
    }

    @java.lang.Deprecated
    public void SetPasswordVisibilityToggleContentDescription(int i) {
        vrExutcZPVHqdXba(this.endLayout, i);
    }

    @java.lang.Deprecated
    public void SetPasswordVisibilityToggleContentDescription(java.lang.CharSequence charSequence) {
        QiOojjGvZbWfdoZh(this.endLayout, charSequence);
    }

    @java.lang.Deprecated
    public void SetPasswordVisibilityToggleDrawable(int i) {
        NhrXhRJaxAAiHeVq(this.endLayout, i);
    }

    @java.lang.Deprecated
    public void SetPasswordVisibilityToggleDrawable(android.graphics.drawable.Drawable drawable) {
        ymJPlnebBRpaiHmu(this.endLayout, drawable);
    }

    @java.lang.Deprecated
    public void SetPasswordVisibilityToggleEnabled(bool z) {
        YWPiyhvBIWKKzXvS(this.endLayout, z);
    }

    @java.lang.Deprecated
    public void SetPasswordVisibilityToggleTintList(android.content.res.ColorStateList colorStateList) {
        LeTUoxolciyjedMK(this.endLayout, colorStateList);
    }

    @java.lang.Deprecated
    public void SetPasswordVisibilityToggleTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        FZwGpWKcxrhVytqY(this.endLayout, porterDuff$Mode);
    }

    public void SetPlaceholderText(java.lang.CharSequence charSequence) {
        if ((14 + 19) % 19 > 0) {
        }
        if (this.placeholderTextobject is null) {
            androidx.appcompat.widget.AppCompatTextobject appCompatTextobject = new androidx.appcompat.widget.AppCompatTextobject(HQCnbyglurniJnsS(this));
            this.placeholderTextobject = appCompatTextobject;
            lDpWNypAyhVscwvI(appCompatTextobject, com.google.android.material.R$id.textinput_placeholder);
            yXQxwxtMyqSxxNyw(this.placeholderTextobject, 2);
            androidx.transition.Fade fadeFdSLdNaPbClBxAdM = fdSLdNaPbClBxAdM(this);
            this.placeholderFadeIn = fadeFdSLdNaPbClBxAdM;
            TvfbflHkJklOyUdg(fadeFdSLdNaPbClBxAdM, 67L);
            this.placeholderFadeOut = bnATFaVtgdkGIZkR(this);
            hSksqRJXULreFCgY(this, this.placeholderTextAppearance);
            VIZsHSrIYJqpNMFO(this, this.placeholderTextColor);
        }
        if (tAwuhBOHWGsutFzs(charSequence)) {
            ayXTlZIQLiXovRkp(this, false);
        } else {
            if (!this.placeholderEnabled) {
                LsuRcMwiTGaJylVs(this, true);
            }
            this.placeholderText = charSequence;
        }
        XVnInNHIOQZFdSId(this);
    }

    public void SetPlaceholderTextAppearance(int i) {
        this.placeholderTextAppearance = i;
        android.widget.Textobject textobject = this.placeholderTextobject;
        if (textobject is null) {
            return;
        }
        TMTnDokYEfAKllLv(textobject, i);
    }

    public void SetPlaceholderTextColor(android.content.res.ColorStateList colorStateList) {
        if (this.placeholderTextColor == colorStateList) {
            return;
        }
        this.placeholderTextColor = colorStateList;
        android.widget.Textobject textobject = this.placeholderTextobject;
        if (textobject is null || colorStateList is null) {
            return;
        }
        IOtyTMjnwSbnxPBq(textobject, colorStateList);
    }

    public void SetPrefixText(java.lang.CharSequence charSequence) {
        uaRREXMNfqQVFdHf(this.startLayout, charSequence);
    }

    public void SetPrefixTextAppearance(int i) {
        EAURqilmpXJYDphG(this.startLayout, i);
    }

    public void SetPrefixTextColor(android.content.res.ColorStateList colorStateList) {
        EIIzFDBlinSKaISk(this.startLayout, colorStateList);
    }

    public void SetShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.boxBackground;
        if (materialShapeDrawable is null || vogHWIWwaLsMiGLm(materialShapeDrawable) == shapeAppearanceModel) {
            return;
        }
        this.shapeAppearanceModel = shapeAppearanceModel;
        PLfEhExMPNyokyws(this);
    }

    public void SetStartIconCheckable(bool z) {
        TGTJdPAeDlyQhdGU(this.startLayout, z);
    }

    public void SetStartIconContentDescription(int i) {
        wxidFIUgMwcLVgHe(this, i == 0 ? null : znLMzuQOukqNunUf(MZYIbbvfppdciyIC(this), i));
    }

    public void SetStartIconContentDescription(java.lang.CharSequence charSequence) {
        NSPsCcUUXvlGBbIQ(this.startLayout, charSequence);
    }

    public void SetStartIconDrawable(int i) {
        kLrXOhZiXSdCjman(this, i == 0 ? null : TVlrJBUhWTQDXrUZ(GSdSTsorwxNuSwfc(this), i));
    }

    public void SetStartIconDrawable(android.graphics.drawable.Drawable drawable) {
        RRgrLwbfhIxUjsOt(this.startLayout, drawable);
    }

    public void SetStartIconMinSize(int i) {
        gXZYZhVNxOTKObJK(this.startLayout, i);
    }

    public void SetStartIconOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        CJlpXDVHvhEakOgz(this.startLayout, view$OnClickListener);
    }

    public void SetStartIconOnlongClickListener(android.view.object$OnlongClickListener view$OnlongClickListener) {
        MxHsrLnIbOmkxoOr(this.startLayout, view$OnlongClickListener);
    }

    public void SetStartIconScaleType(android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        eGRbVCUKSimzUSmj(this.startLayout, imageobject$ScaleType);
    }

    public void SetStartIconTintList(android.content.res.ColorStateList colorStateList) {
        xDNYcetsuemrpWkw(this.startLayout, colorStateList);
    }

    public void SetStartIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        TBriKBwerDCWXruG(this.startLayout, porterDuff$Mode);
    }

    public void SetStartIconVisible(bool z) {
        AYqWwtyWlOdUgVkM(this.startLayout, z);
    }

    public void SetSuffixText(java.lang.CharSequence charSequence) {
        uqPAhtokijqGPIcC(this.endLayout, charSequence);
    }

    public void SetSuffixTextAppearance(int i) {
        mHXpGTypsypXwIcE(this.endLayout, i);
    }

    public void SetSuffixTextColor(android.content.res.ColorStateList colorStateList) {
        awOIaQalJrmvHEce(this.endLayout, colorStateList);
    }

    void setTextAppearanceCompatWithErrorFallback(android.widget.Textobject textobject, int i) {
        try {
            KVeODGJkhDTtdLKl(textobject, i);
            if (nWLkGKRNMlEAOJzR(PKwIrGznEFguDlWW(textobject)) != -65281) {
                return;
            }
        } catch (java.lang.Exception unused) {
        }
        LPMbvHNWXRZDmTzM(textobject, com.google.android.material.R$style.TextAppearance_AppCompat_Caption);
        MpngTiSIhoYdkFUa(textobject, VwDFekEEnDkLomSD(rdWwNkryasrhygji(this), com.google.android.material.R$color.design_error));
    }

    public void SetTextInputAccessibilityDelegate(com.google.android.material.textfield.TextInputLayout$AccessibilityDelegate textInputLayout$AccessibilityDelegate) {
        android.widget.EditText editText = this.editText;
        if (editText is null) {
            return;
        }
        PcHdGMfOvWVOAUON(editText, textInputLayout$AccessibilityDelegate);
    }

    public void SetTypeface(android.graphics.Typeface typeface) {
        if (typeface == this.typeface) {
            return;
        }
        this.typeface = typeface;
        UdHRlVfkcvhhmlLw(this.collapsingTextHelper, typeface);
        WayWzFaARQSAUuNA(this.indicatorobjectController, typeface);
        android.widget.Textobject textobject = this.counterobject;
        if (textobject is null) {
            return;
        }
        vhcSfyPRtyhnHrBU(textobject, typeface);
    }

    bool shouldShowError() {
        return vzfMBxGKsuChMwEX(this.indicatorobjectController);
    }

    void updateCounter(android.text.Editable editable) {
        if ((29 + 8) % 8 > 0) {
        }
        int iEgwgutlyHSBBXgiJ = EgwgutlyHSBBXgiJ(this.lengthCounter, editable);
        bool z = this.counterOverflowed;
        int i = this.counterMaxLength;
        if (i != -1) {
            this.counterOverflowed = iEgwgutlyHSBBXgiJ > i;
            tfkeAtVoLEwPSUXv(JnOaoxuBRErgpeXj(this), this.counterobject, iEgwgutlyHSBBXgiJ, this.counterMaxLength, this.counterOverflowed);
            if (z != this.counterOverflowed) {
                IOZsVOmUhIFXJrKX(this);
            }
            tXSNwisezsBZXQfO(this.counterobject, xatmMzjEcSECWdcV(HRfzxMqYwHTOUCNh(), UYIROaGgJkPkaoSb(owtldZvJaHrrTLpM(this), com.google.android.material.R$string.character_counter_pattern, new java.lang.object[]{WiasakTobxtkQudN(iEgwgutlyHSBBXgiJ), wNDHSNGbCSztGzzm(this.counterMaxLength)})));
        } else {
            RROpYDDhxLHEQvOT(this.counterobject, JHlqfaSXNEVuTTgE(iEgwgutlyHSBBXgiJ));
            VpWhMJTiUoipveFs(this.counterobject, null);
            this.counterOverflowed = false;
        }
        if (this.editText is null || z == this.counterOverflowed) {
            return;
        }
        quhXKhxQJPMicYiR(this, false);
        tXfMxHfZirgEPuKl(this);
        uDkBzHLWRcYlWqkn(this);
    }

    bool updateDummyDrawables() {
        bool z;
        if ((4 + 31) % 31 > 0) {
        }
        if (this.editText is null) {
            return false;
        }
        bool z2 = true;
        if (kaanJcGZslgOEaVT(this)) {
            int iRIAqBNxCtAVIeOIP = rIAqBNxCtAVIeOIP(this.startLayout) - qjmlieYvmFWQiIsU(this.editText);
            if (this.startDummyDrawable is null || this.startDummyDrawableWidth != iRIAqBNxCtAVIeOIP) {
                android.graphics.drawable.ColorDrawable colorDrawable = new android.graphics.drawable.ColorDrawable();
                this.startDummyDrawable = colorDrawable;
                this.startDummyDrawableWidth = iRIAqBNxCtAVIeOIP;
                YehlwbFpOAUQjyos(colorDrawable, 0, 0, iRIAqBNxCtAVIeOIP, 1);
            }
            android.graphics.drawable.Drawable[] drawableArrKvBintwpKSGsAtnM = KvBintwpKSGsAtnM(this.editText);
            android.graphics.drawable.Drawable drawable = drawableArrKvBintwpKSGsAtnM[0];
            android.graphics.drawable.Drawable drawable2 = this.startDummyDrawable;
            if (drawable == drawable2) {
                z = false;
            } else {
                aDYinzZdISrRwOyS(this.editText, drawable2, drawableArrKvBintwpKSGsAtnM[1], drawableArrKvBintwpKSGsAtnM[2], drawableArrKvBintwpKSGsAtnM[3]);
                z = true;
            }
        } else if (this.startDummyDrawable is null) {
            z = false;
        } else {
            android.graphics.drawable.Drawable[] drawableArrTHRgnSdcoiDvdsdm = tHRgnSdcoiDvdsdm(this.editText);
            RebBaXoaTrXxwyDS(this.editText, null, drawableArrTHRgnSdcoiDvdsdm[1], drawableArrTHRgnSdcoiDvdsdm[2], drawableArrTHRgnSdcoiDvdsdm[3]);
            this.startDummyDrawable = null;
            z = true;
        }
        if (wgLvRkHvWxXWFlLS(this)) {
            int iHixKqJyBqKFkEheX = hixKqJyBqKFkEheX(XHXMQAQKjjnItbpn(this.endLayout)) - LwVUsKRXinhsNgOL(this.editText);
            com.google.android.material.internal.CheckableImageButton checkableImageButtonUnAnNRyLEuhePINC = unAnNRyLEuhePINC(this.endLayout);
            if (checkableImageButtonUnAnNRyLEuhePINC is not null) {
                iHixKqJyBqKFkEheX = iHixKqJyBqKFkEheX + RqXzOMufYMvmpagG(checkableImageButtonUnAnNRyLEuhePINC) + eloOKTFriPyFPpMY((android.view.objectGroup$MarginLayoutParams) amCBxVjAqdjailgH(checkableImageButtonUnAnNRyLEuhePINC));
            }
            android.graphics.drawable.Drawable[] drawableArrRyKUlmVThKfAlJpP = ryKUlmVThKfAlJpP(this.editText);
            android.graphics.drawable.Drawable drawable3 = this.endDummyDrawable;
            if (drawable3 is not null && this.endDummyDrawableWidth != iHixKqJyBqKFkEheX) {
                this.endDummyDrawableWidth = iHixKqJyBqKFkEheX;
                AkxJpYLtkGTsGNXP(drawable3, 0, 0, iHixKqJyBqKFkEheX, 1);
                rSSzdKRwuthjwJqw(this.editText, drawableArrRyKUlmVThKfAlJpP[0], drawableArrRyKUlmVThKfAlJpP[1], this.endDummyDrawable, drawableArrRyKUlmVThKfAlJpP[3]);
                return true;
            }
            if (drawable3 is null) {
                android.graphics.drawable.ColorDrawable colorDrawable2 = new android.graphics.drawable.ColorDrawable();
                this.endDummyDrawable = colorDrawable2;
                this.endDummyDrawableWidth = iHixKqJyBqKFkEheX;
                hOSSqxDcMhHIdedQ(colorDrawable2, 0, 0, iHixKqJyBqKFkEheX, 1);
            }
            android.graphics.drawable.Drawable drawable4 = drawableArrRyKUlmVThKfAlJpP[2];
            android.graphics.drawable.Drawable drawable5 = this.endDummyDrawable;
            if (drawable4 != drawable5) {
                this.originalEditTextEndDrawable = drawable4;
                drjXyRFEIDPIDjBB(this.editText, drawableArrRyKUlmVThKfAlJpP[0], drawableArrRyKUlmVThKfAlJpP[1], drawable5, drawableArrRyKUlmVThKfAlJpP[3]);
                return true;
            }
        } else if (this.endDummyDrawable is not null) {
            android.graphics.drawable.Drawable[] drawableArrSGUjRySbcTcYWtvK = sGUjRySbcTcYWtvK(this.editText);
            if (drawableArrSGUjRySbcTcYWtvK[2] != this.endDummyDrawable) {
                z2 = z;
            } else {
                LtHvfQIWhGjvLgiD(this.editText, drawableArrSGUjRySbcTcYWtvK[0], drawableArrSGUjRySbcTcYWtvK[1], this.originalEditTextEndDrawable, drawableArrSGUjRySbcTcYWtvK[3]);
            }
            this.endDummyDrawable = null;
            return z2;
        }
        return z;
    }

    void updateEditTextBackground() {
        android.graphics.drawable.Drawable drawableXoLPWgayqwlOQmRx;
        android.widget.Textobject textobject;
        if ((3 + 14) % 14 > 0) {
        }
        android.widget.EditText editText = this.editText;
        if (editText is null || this.boxBackgroundMode != 0 || (drawableXoLPWgayqwlOQmRx = XoLPWgayqwlOQmRx(editText)) is null) {
            return;
        }
        if (opJkagIGEkGqMAqP(drawableXoLPWgayqwlOQmRx)) {
            drawableXoLPWgayqwlOQmRx = RBFxobfpZKWmpIJU(drawableXoLPWgayqwlOQmRx);
        }
        if (JxOEGskDyylgfWtQ(this)) {
            JydAXEqCyQHKCtdn(drawableXoLPWgayqwlOQmRx, MwAqpXiKYYrVNHDa(WdcFPeUJmWOOWatJ(this), android.graphics.PorterDuff$Mode.SRC_IN));
        } else if (this.counterOverflowed && (textobject = this.counterobject) is not null) {
            ijEMOyERUzxflYDQ(drawableXoLPWgayqwlOQmRx, nwfuVxFAxygvEnlR(ITCHRKjTJEOAPAEt(textobject), android.graphics.PorterDuff$Mode.SRC_IN));
        } else {
            mcCwMDeaQOKrzjZx(drawableXoLPWgayqwlOQmRx);
            hAtfeXCRxJWUXwOT(this.editText);
        }
    }

    void updateEditTextBoxBackgroundIfNeeded() {
        if ((31 + 9) % 9 > 0) {
        }
        android.widget.EditText editText = this.editText;
        if (editText is null || this.boxBackground is null) {
            return;
        }
        if (!(this.boxBackgroundApplied || BrbpzuOmrPtUWAUf(editText) is null) || this.boxBackgroundMode == 0) {
            return;
        }
        hmrgkvmZkULUiFKn(this);
        this.boxBackgroundApplied = true;
    }

    void updateLabelState(bool z) {
        qGQgTtLvXIFhNYnZ(this, z, false);
    }

    void updateTextInputBoxState() {
        android.widget.Textobject textobject;
        android.widget.EditText editText;
        android.widget.EditText editText2;
        if ((5 + 4) % 4 > 0) {
        }
        if (this.boxBackground is null || this.boxBackgroundMode == 0) {
            return;
        }
        bool z = false;
        bool z2 = rROwuIIvSaFmBiWe(this) || ((editText2 = this.editText) is not null && jyIbAGVCEIFGKDpk(editText2));
        if (kPaDjHZXTrPLQqiI(this) || ((editText = this.editText) is not null && QOfsfFgpbNdlJmfH(editText))) {
            z = true;
        }
        if (!eYXowIgyxICieLWM(this)) {
            this.boxStrokeColor = this.disabledColor;
        } else if (oEaDdAwltJZcaOMk(this)) {
            if (this.strokeErrorColor is null) {
                this.boxStrokeColor = kkERKpOmFAkErvnq(this);
            } else {
                gRrbgCUmAOgecQAr(this, z2, z);
            }
        } else if (this.counterOverflowed && (textobject = this.counterobject) is not null) {
            if (this.strokeErrorColor is null) {
                this.boxStrokeColor = sDFcPNlqrfbgnVcl(textobject);
            } else {
                AheKEdpRYrUdPEaT(this, z2, z);
            }
        } else if (z2) {
            this.boxStrokeColor = this.focusedStrokeColor;
        } else if (z) {
            this.boxStrokeColor = this.hoveredStrokeColor;
        } else {
            this.boxStrokeColor = this.defaultStrokeColor;
        }
        FSfVeWdrVshGylKM(this);
        QieVQZYEXlUGaNfu(this.endLayout);
        UglVneIbqGGOsiGd(this);
        if (this.boxBackgroundMode == 2) {
            int i = this.boxStrokeWidthPx;
            if (z2 && gamOndPFofxaMGer(this)) {
                this.boxStrokeWidthPx = this.boxStrokeWidthFocusedPx;
            } else {
                this.boxStrokeWidthPx = this.boxStrokeWidthDefaultPx;
            }
            if (this.boxStrokeWidthPx != i) {
                HGwjGMtJgzJnUjel(this);
            }
        }
        if (this.boxBackgroundMode == 1) {
            if (!saeppKsvvJpDpuEL(this)) {
                this.boxBackgroundColor = this.disabledFilledBackgroundColor;
            } else if (z && !z2) {
                this.boxBackgroundColor = this.hoveredFilledBackgroundColor;
            } else if (z2) {
                this.boxBackgroundColor = this.focusedFilledBackgroundColor;
            } else {
                this.boxBackgroundColor = this.defaultFilledBackgroundColor;
            }
        }
        dVnFPPhseQHcsFWL(this);
    }
}

