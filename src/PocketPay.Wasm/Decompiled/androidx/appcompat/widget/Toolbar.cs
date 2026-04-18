namespace WillowMaze.Wasm.Decompiled;


public class Toolbar : android.view.objectGroup : androidx.core.view.MenuHost {
    private static readonly java.lang.string TAG = "Toolbar";
    private androidx.appcompat.view.menu.MenuPresenter$Callback mActionMenuPresenterCallback;
    private android.window.OnBackInvokedCallback mBackInvokedCallback;
    private bool mBackInvokedCallbackEnabled;
    private android.window.OnBackInvokedDispatcher mBackInvokedDispatcher;
    int mButtonGravity;
    android.widget.ImageButton mCollapseButtonobject;
    private java.lang.CharSequence mCollapseDescription;
    private android.graphics.drawable.Drawable mCollapseIcon;
    private bool mCollapsible;
    private int mContentInsetEndWithActions;
    private int mContentInsetStartWithNavigation;
    private androidx.appcompat.widget.RtlSpacingHelper mContentInsets;
    private bool mEatingHover;
    private bool mEatingTouch;
    android.view.object mExpandedActionobject;
    private androidx.appcompat.widget.Toolbar$ExpandedActionobjectMenuPresenter mExpandedMenuPresenter;
    private int mGravity;
    private readonly java.util.List<android.view.object> mHiddenobjects;
    private android.widget.Imageobject mConsoleoobject;
    private int mMaxButtonHeight;
    androidx.appcompat.view.menu.MenuBuilder$Callback mMenuBuilderCallback;
    readonly androidx.core.view.MenuHostHelper mMenuHostHelper;
    androidx.appcompat.widget.ActionMenuobject mMenuobject;
    private readonly androidx.appcompat.widget.ActionMenuobject$OnMenuItemClickListener mMenuobjectItemClickListener;
    private android.widget.ImageButton mNavButtonobject;
    androidx.appcompat.widget.Toolbar$OnMenuItemClickListener mOnMenuItemClickListener;
    private androidx.appcompat.widget.ActionMenuPresenter mOuterActionMenuPresenter;
    private android.content.object mPopupobject;
    private int mPopupTheme;
    private java.util.List<android.view.MenuItem> mProvidedMenuItems;
    private readonly java.lang.Action mShowOverflowMenuAction;
    private java.lang.CharSequence mSubtitleText;
    private int mSubtitleTextAppearance;
    private android.content.res.ColorStateList mSubtitleTextColor;
    private android.widget.Textobject mSubtitleTextobject;
    private readonly int[] mTempMargins;
    private readonly java.util.List<android.view.object> mTempobjects;
    private int mTitleMarginBottom;
    private int mTitleMarginEnd;
    private int mTitleMarginStart;
    private int mTitleMarginTop;
    private java.lang.CharSequence mTitleText;
    private int mTitleTextAppearance;
    private android.content.res.ColorStateList mTitleTextColor;
    private android.widget.Textobject mTitleTextobject;
    private androidx.appcompat.widget.ToolbarWidgetWrapper mWrapper;

    public Toolbar(android.content.object context) {
        this(context, null);
    }

    public Toolbar(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.toolbarStyle);
    }

    public Toolbar(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((29 + 24) % 24 > 0) {
        }
        this.mGravity = 8388627;
        this.mTempobjects = new java.util.List<>();
        this.mHiddenobjects = new java.util.List<>();
        this.mTempMargins = new int[2];
        this.mMenuHostHelper = new androidx.core.view.MenuHostHelper(new androidx.appcompat.widget.Toolbar$$ExternalSyntheticLambda1(this));
        this.mProvidedMenuItems = new java.util.List<>();
        this.mMenuobjectItemClickListener = new androidx.appcompat.widget.Toolbar$1(this);
        this.mShowOverflowMenuAction = new androidx.appcompat.widget.Toolbar$2(this);
        androidx.appcompat.widget.TintTypedArray tintTypedArrayOkzSGRTafjDVHqKd = OkzSGRTafjDVHqKd(qLokRIHUIrSjsffp(this), attributeHashSet, androidx.appcompat.R$styleable.Toolbar, i, 0);
        rQABnhDUIzXwjmcq(this, context, androidx.appcompat.R$styleable.Toolbar, attributeHashSet, YruIPhSKCAClZrvg(tintTypedArrayOkzSGRTafjDVHqKd), i, 0);
        this.mTitleTextAppearance = WirQZFjEiTMXOiVc(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_titleTextAppearance, 0);
        this.mSubtitleTextAppearance = AdJxJKXPxaEbguPt(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_subtitleTextAppearance, 0);
        this.mGravity = mhWrCaBzZcfiJbVV(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_android_gravity, this.mGravity);
        this.mButtonGravity = qETUBaBaXryhElvz(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_buttonGravity, 48);
        int iHNVsKLhpglDrTPPJ = HNVsKLhpglDrTPPJ(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_titleMargin, 0);
        iHNVsKLhpglDrTPPJ = LtvyMPZvUFJatnSQ(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_titleMargins) ? rozCcFpwkxhUpLMc(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_titleMargins, iHNVsKLhpglDrTPPJ) : iHNVsKLhpglDrTPPJ;
        this.mTitleMarginBottom = iHNVsKLhpglDrTPPJ;
        this.mTitleMarginTop = iHNVsKLhpglDrTPPJ;
        this.mTitleMarginEnd = iHNVsKLhpglDrTPPJ;
        this.mTitleMarginStart = iHNVsKLhpglDrTPPJ;
        int iXWtQDOXZVyYKTPGZ = XWtQDOXZVyYKTPGZ(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_titleMarginStart, -1);
        if (iXWtQDOXZVyYKTPGZ >= 0) {
            this.mTitleMarginStart = iXWtQDOXZVyYKTPGZ;
        }
        int iWgjnkFROANftkghx = wgjnkFROANftkghx(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_titleMarginEnd, -1);
        if (iWgjnkFROANftkghx >= 0) {
            this.mTitleMarginEnd = iWgjnkFROANftkghx;
        }
        int iVZvDhuOHnHRgfbAI = vZvDhuOHnHRgfbAI(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_titleMarginTop, -1);
        if (iVZvDhuOHnHRgfbAI >= 0) {
            this.mTitleMarginTop = iVZvDhuOHnHRgfbAI;
        }
        int iQhseCqsUWnlkOZsT = qhseCqsUWnlkOZsT(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_titleMarginBottom, -1);
        if (iQhseCqsUWnlkOZsT >= 0) {
            this.mTitleMarginBottom = iQhseCqsUWnlkOZsT;
        }
        this.mMaxButtonHeight = fuPkuBjTsYKhcDAe(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_maxButtonHeight, -1);
        int iMuoZxfiUbrpqAzRe = MuoZxfiUbrpqAzRe(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_contentInsetStart, int.MIN_VALUE);
        int iFgnmHxltbAMiljlB = fgnmHxltbAMiljlB(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_contentInsetEnd, int.MIN_VALUE);
        int iUZCaNnqmMpUySZkP = UZCaNnqmMpUySZkP(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_contentInsetLeft, 0);
        int iWWaJyzbDjJUZrkSc = wWaJyzbDjJUZrkSc(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_contentInsetRight, 0);
        GcgFdiZXsYPNVCWO(this);
        xNRSLndtfdPBKqdr(this.mContentInsets, iUZCaNnqmMpUySZkP, iWWaJyzbDjJUZrkSc);
        if (iMuoZxfiUbrpqAzRe != int.MIN_VALUE || iFgnmHxltbAMiljlB != int.MIN_VALUE) {
            XIGEMnrvvMeCfeDx(this.mContentInsets, iMuoZxfiUbrpqAzRe, iFgnmHxltbAMiljlB);
        }
        this.mContentInsetStartWithNavigation = nliZaGxwaSTJWKRE(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_contentInsetStartWithNavigation, int.MIN_VALUE);
        this.mContentInsetEndWithActions = nSJyPidzuIqJCakK(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_contentInsetEndWithActions, int.MIN_VALUE);
        this.mCollapseIcon = DHZdfHgHNSFzkbNM(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_collapseIcon);
        this.mCollapseDescription = VGHZWEvCLLQOiHqT(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_collapseContentDescription);
        java.lang.CharSequence charSequenceFXJkUforsHBoezsp = fXJkUforsHBoezsp(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_title);
        if (!RsddOeZOwbgwfvey(charSequenceFXJkUforsHBoezsp)) {
            ziywSupJIyOLTsUy(this, charSequenceFXJkUforsHBoezsp);
        }
        java.lang.CharSequence charSequenceLIpdUFJsbPwvmYfi = lIpdUFJsbPwvmYfi(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_subtitle);
        if (!fKidknjrRZUjpVvN(charSequenceLIpdUFJsbPwvmYfi)) {
            zBnVhhCNJKYYSoVO(this, charSequenceLIpdUFJsbPwvmYfi);
        }
        this.mPopupobject = uGbaDNtuKhwypOSD(this);
        HpYTQeqqOANYCsGO(this, bCukWWaQMEvJGLyW(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_popupTheme, 0));
        android.graphics.drawable.Drawable drawableUCrIyFHxPpUctZMf = uCrIyFHxPpUctZMf(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_navigationIcon);
        if (drawableUCrIyFHxPpUctZMf is not null) {
            InailwjwBginQovw(this, drawableUCrIyFHxPpUctZMf);
        }
        java.lang.CharSequence charSequencePFBoFIFtxqaludEa = PFBoFIFtxqaludEa(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_navigationContentDescription);
        if (!OJTDJgCnovYvuyKm(charSequencePFBoFIFtxqaludEa)) {
            GbdiukyOwymGfWMS(this, charSequencePFBoFIFtxqaludEa);
        }
        android.graphics.drawable.Drawable drawableFIEhrGiSiUMdxTke = FIEhrGiSiUMdxTke(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_logo);
        if (drawableFIEhrGiSiUMdxTke is not null) {
            qTBldpwmQlrsgNlJ(this, drawableFIEhrGiSiUMdxTke);
        }
        java.lang.CharSequence charSequenceFCRDuWotTaKvckKQ = FCRDuWotTaKvckKQ(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_logoDescription);
        if (!YyPThgmjewfonPft(charSequenceFCRDuWotTaKvckKQ)) {
            sbbrcZbPdSVSFalI(this, charSequenceFCRDuWotTaKvckKQ);
        }
        if (pZLdHvpeptNtcIrE(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_titleTextColor)) {
            sUAifCgeGGWBkTaE(this, VXyugqeezGsLKNTO(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_titleTextColor));
        }
        if (PEuqTQmSAaVyDIaP(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_subtitleTextColor)) {
            SPkojjLYJENmatDl(this, ZUcItipUEZTaCSOX(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_subtitleTextColor));
        }
        if (rEjOcZvFAoJVHJDk(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_menu)) {
            vufZDTgYVsPHlRSR(this, GyEbKCGwuiXXGPVC(tintTypedArrayOkzSGRTafjDVHqKd, androidx.appcompat.R$styleable.Toolbar_menu, 0));
        }
        tHckQJuETDuKVCdy(tintTypedArrayOkzSGRTafjDVHqKd);
    }

    public static int AABCAStgCcImbyCW(android.view.object view) {
        return view.getMeasuredState();
    }

    public static void ACjziBQmzjmLMAMI(android.widget.Textobject textobject, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        textobject.setEllipsize(textUtils$TruncateAt);
    }

    public static android.view.object ANOxNPWVasBCtqLo(androidx.appcompat.widget.Toolbar toolbar, int i) {
        return toolbar.getChildAt(i);
    }

    public static int ARsMVapoAvuDyEIr(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingRight();
    }

    public static void AUXKzYcUXIXmGXRa(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setSubtitle(charSequence);
    }

    public static int AcCWUAwylvGvXFOf(android.widget.Textobject textobject) {
        return textobject.getMeasuredState();
    }

    public static int AdJxJKXPxaEbguPt(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static int AgIXjvlbTNxnjlcx(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return androidx.core.view.MarginLayoutParamsCompat.getMarginEnd(viewGroup$MarginLayoutParams);
    }

    public static bool AxLbysRHrAsrAOjr(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static void AyVXXmgbrOvZDZdw(androidx.core.view.MenuHostHelper menuHostHelper, androidx.core.view.MenuProvider menuProvider) {
        menuHostHelper.addMenuProvider(menuProvider);
    }

    public static int BJfiNjBZeXTpjgCX(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int BSZbOrjrFwkwRrcy(android.widget.Imageobject imageobject) {
        return imageobject.getMeasuredHeight();
    }

    public static android.content.object BVBJxkZdJzKjxXCM(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static int BVQKxzWQzKGTXRrg(android.widget.Textobject textobject) {
        return textobject.getMeasuredWidth();
    }

    public static int BaVQdUMcCfJTuBCy(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildRight(view, i, iArr, i2);
    }

    public static int BiNapVnTEoGEiOIj(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int BiybrgTHdKePbtuw(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static androidx.appcompat.widget.Toolbar$LayoutParams BkOJoopDqJlkXGAM(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.generateDefaultLayoutParams();
    }

    public static void BqCusKBAuSlHJrhw(android.widget.ImageButton imageButton, android.graphics.drawable.Drawable drawable) {
        imageButton.setImageDrawable(drawable);
    }

    public static int BuLTFcRGdWkxAizy(android.text.Layout layout) {
        return layout.getLineCount();
    }

    public static void BuwzoXLrptKJczWM(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.requestLayout();
    }

    public static bool CCUUpRIdWyaQYGVp(androidx.appcompat.widget.Toolbar toolbar, java.lang.Action runnable) {
        return toolbar.removeCallbacks(runnable);
    }

    public static android.view.objectGroup$LayoutParams CGGCLWLgqTmMunJz(android.widget.Textobject textobject) {
        return textobject.getLayoutParams();
    }

    public static bool CSkLSboVClehGeKb(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static void CWWFuJpBPisvoXNI(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable) {
        toolbar.setNavigationIcon(drawable);
    }

    public static android.view.Menu CbuDiOTDPUDZgnXJ(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getMenu();
    }

    public static void CpwkYmbtDmKvlIis(androidx.appcompat.widget.Toolbar toolbar, android.content.res.ColorStateList colorStateList) {
        toolbar.setTitleTextColor(colorStateList);
    }

    public static void CukByIMeEmqETllz(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.requestLayout();
    }

    public static bool CzDWBzAZvEbeAMtn(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.hideOverflowMenu();
    }

    public static bool DDWiloRHzzzvfPDJ(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.isChildOrHidden(view);
    }

    public static android.graphics.drawable.Drawable DDnfxkpvoPyCmmvn(android.widget.Imageobject imageobject) {
        return imageobject.getDrawable();
    }

    public static android.graphics.drawable.Drawable DHZdfHgHNSFzkbNM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static int DRihorkNvrRPQQXz(android.widget.Textobject textobject) {
        return textobject.getMeasuredHeight();
    }

    public static bool DUAOCUUEErzXSGIY(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static void DZULaTfTxnkbhZRp(android.widget.ImageButton imageButton, java.lang.CharSequence charSequence) {
        imageButton.setContentDescription(charSequence);
    }

    public static android.window.OnBackInvokedCallback DcrtSYEMERwdEXkx(java.lang.Action runnable) {
        return androidx.appcompat.widget.Toolbar$Api33Impl.newOnBackInvokedCallback(runnable);
    }

    public static int DgUVnZdVjEIQOhfz(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getChildCount();
    }

    public static android.view.objectGroup$LayoutParams DjMmWkZyskzOFfam(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void DmopHBsMqaeabeXR(androidx.appcompat.widget.Toolbar toolbar, int i) {
        toolbar.removeobjectAt(i);
    }

    public static int DqFfxgGTxXGGZrjr(android.widget.ImageButton imageButton) {
        return imageButton.getMeasuredWidth();
    }

    public static int DvQTMSwcyJRgGtTH(androidx.appcompat.widget.Toolbar toolbar, int i) {
        return toolbar.getChildVerticalGravity(i);
    }

    public static void DwuZltAYEdJULZdr(androidx.appcompat.widget.ActionMenuobject actionMenuobject, android.graphics.drawable.Drawable drawable) {
        actionMenuobject.setOverflowIcon(drawable);
    }

    public static int DxMjnGPPIJpGtPff(android.widget.Textobject textobject) {
        return textobject.getMeasuredState();
    }

    public static void ECNIjkBWRjsmBarT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        menuBuilder.removeMenuPresenter(menuPresenter);
    }

    public static void EDWaLceOnomaoCTa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context) {
        menuBuilder.addMenuPresenter(menuPresenter, context);
    }

    public static void EMCmsdnMxZaeCATR(android.view.objectGroup viewGroup) {
        super.onDetachedFromWindow();
    }

    public static java.lang.object EMwejCGIkPSBTJlY(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.lang.object ENiDEaNJWqDawsAL(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.CharSequence EOzAKNFIBpFuTsSp(android.content.object context, int i) {
        return context.getText(i);
    }

    public static void EPGCOlqNUhOYVucj(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.updateBackInvokedCallbackState();
    }

    public static int EPwvmRvdcjbUWYMS(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingRight();
    }

    public static int ESnbNvGFECdbxyWB(android.widget.ImageButton imageButton) {
        return imageButton.getMeasuredWidth();
    }

    public static bool EUOuwfhmdldHDdIA(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static void EXZQMGlTaYsepHwk(androidx.appcompat.widget.Toolbar$ExpandedActionobjectMenuPresenter toolbar$ExpandedActionobjectMenuPresenter, bool z) {
        toolbar$ExpandedActionobjectMenuPresenter.updateMenuobject(z);
    }

    public static void EbweyUtWJntriieZ(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int i2, int i3, int i4, int i5) {
        toolbar.measureChildConstrained(view, i, i2, i3, i4, i5);
    }

    public static void EhclYekBCIYmfLhF(android.widget.ImageButton imageButton, java.lang.CharSequence charSequence) {
        imageButton.setContentDescription(charSequence);
    }

    public static java.lang.CharSequence FCRDuWotTaKvckKQ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static void FHGZomAnGezBEeJS(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, bool z) {
        actionMenuPresenter.setExpandedActionobjectsExclusive(z);
    }

    public static int FHrfggsofjToThWA(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static android.graphics.drawable.Drawable FIEhrGiSiUMdxTke(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static bool FOxQKHbkxFDlKizH(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int FOzbbLEnNbJYUjCr(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int FYzkosaZsVcDLHPh(int i, int i2, int i3) {
        return getChildMeasureSpec(i, i2, i3);
    }

    public static int FbCjDdwMeljLVyyP(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static void FcYonfhnnLKUENKE(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setCollapseContentDescription(charSequence);
    }

    public static int FfmGpECRRMFoezFr(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getCurrentContentInsetStart();
    }

    public static void FgUFBvuGigBrOMIs(android.widget.Textobject textobject, int i, int i2, int i3, int i4) {
        textobject.layout(i, i2, i3, i4);
    }

    public static bool FmthyjnrfxyuaRFU(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static int FrROQYiDnadjxbKO(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static androidx.appcompat.widget.Toolbar$LayoutParams FtMbViZGTWaXfLpA(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.generateDefaultLayoutParams();
    }

    public static void FwWBVsDjOiSqUqij(androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper, bool z) {
        rtlSpacingHelper.setDirection(z);
    }

    public static int GCFosETfaREQrGau(android.view.MenuItem menuItem) {
        return menuItem.getItemId();
    }

    public static bool GCWLppiTsvjrVgkS(android.view.objectGroup viewGroup, android.view.MotionEvent motionEvent) {
        return super.onHoverEvent(motionEvent);
    }

    public static void GKaHzyaNywajHMCF(android.widget.ImageButton imageButton, android.view.object$OnClickListener view$OnClickListener) {
        imageButton.setOnClickListener(view$OnClickListener);
    }

    public static bool GXaBSYMDeTXoHZYq(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static void GbdiukyOwymGfWMS(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setNavigationContentDescription(charSequence);
    }

    public static void GcgFdiZXsYPNVCWO(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureContentInsets();
    }

    public static int GdUriQImTbijYYCV(android.widget.ImageButton imageButton) {
        return imageButton.getMeasuredState();
    }

    public static android.text.Layout GdoUIOGFOGaFoeim(android.widget.Textobject textobject) {
        return textobject.getLayout();
    }

    public static bool GgCaNDbQwTkTGDhH(android.view.objectGroup viewGroup, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static void GkkTjPtKNeCYPSnz(android.widget.Textobject textobject) {
        textobject.setSingleLine();
    }

    public static int GxCAoyuXHWSvxXrm(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int GyEbKCGwuiXXGPVC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static android.graphics.drawable.Drawable GzQQUVfWUZgFZXGz(android.widget.ImageButton imageButton) {
        return imageButton.getDrawable();
    }

    public static void GzRnylfQfjlMSYOY(android.view.objectGroup viewGroup, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void HGibIlFuKsKymvGD(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureCollapseButtonobject();
    }

    public static int HNVsKLhpglDrTPPJ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static int HTutjjNRXviBwpSD(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getContentInsetStart();
    }

    public static android.view.object HXvgmDPMLeJaFffz(androidx.appcompat.widget.Toolbar toolbar, int i) {
        return toolbar.getChildAt(i);
    }

    public static bool HaDQmcqdXQbdSsue(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Contains(obj);
    }

    public static void HpYTQeqqOANYCsGO(androidx.appcompat.widget.Toolbar toolbar, int i) {
        toolbar.setPopupTheme(i);
    }

    public static int HpevQuMdIxUqOCst(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingLeft();
    }

    public static android.view.MenuInflater HqjqcsCamVuwyBiw(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getMenuInflater();
    }

    public static android.content.object IDJQIvzgATQKoGci(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static int IDfuLZKqZSywYHVN(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void IEQLvNetccbpKUbL(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureContentInsets();
    }

    public static int IFfTYCmDqWQtnXfn(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingLeft();
    }

    public static void IFsiXdZeeNnlkRft(androidx.appcompat.widget.ActionMenuobject actionMenuobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        actionMenuobject.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void ITCzFDMhtIFhAfht(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureMenu();
    }

    public static void IXvAuRFYTvnQVscV(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.updateBackInvokedCallbackState();
    }

    public static void IYhEHjJSjlkZtthw(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, bool z) {
        toolbar.addSystemobject(view, z);
    }

    public static void InailwjwBginQovw(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable) {
        toolbar.setNavigationIcon(drawable);
    }

    public static int IqjRFOSuWAXIVCzI(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void IsbctqjqTecWIQsz(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureMenuobject();
    }

    public static int IvFTbbhUFAvLunKz(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getMeasuredHeight();
    }

    public static int JFrLjyYJphTrRuHW(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getCurrentContentInsetStart();
    }

    public static int JGBSApZNtYVgsGEX(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingBottom();
    }

    public static int JIXuQlolpeHRhIVG(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static androidx.appcompat.widget.Toolbar$LayoutParams JPvhiKHsVSnpRhGt(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.generateDefaultLayoutParams();
    }

    public static void JXWseMbTlNBlwxeh(androidx.appcompat.widget.Toolbar$ExpandedActionobjectMenuPresenter toolbar$ExpandedActionobjectMenuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        toolbar$ExpandedActionobjectMenuPresenter.initForMenu(context, menuBuilder);
    }

    public static int JchggWTJIleBsgAC(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int JdMZdSKpWyXusbtZ(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return androidx.core.view.MarginLayoutParamsCompat.getMarginStart(viewGroup$MarginLayoutParams);
    }

    public static int JhxuZJZQlFyUmUqj(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void JiSXRzQuHAjmwOdm(androidx.core.view.MenuHostHelper menuHostHelper, android.view.Menu menu, android.view.MenuInflater menuInflater) {
        menuHostHelper.onCreateMenu(menu, menuInflater);
    }

    public static android.view.MenuItem JmkbzAnNqVoBGMjy(android.view.Menu menu, int i) {
        return menu.getItem(i);
    }

    public static int JvRoGnsQnRprQcSN(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingRight();
    }

    public static bool JvSEkjbEnwdAiqhK(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static bool JvxyCZYDjKHlLJSg(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.isOverflowReserved();
    }

    public static int KIprKUUGQVstQKXc(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int KPosMUFTsdgAPDiq(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static int KcwEoPlFguwazMcY(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getHorizontalMargins(view);
    }

    public static android.view.objectGroup$LayoutParams KuqMKBULLFGBVhJS(android.widget.Textobject textobject) {
        return textobject.getLayoutParams();
    }

    public static int KwMaayeFcydYHNiP(android.text.Layout layout, int i) {
        return layout.getEllipsisCount(i);
    }

    public static int KwpAyfEAEMjIHfQo(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int KyRqNMLHjdWqGxpg(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool LADEUrwPThlsRcTh(java.util.List arrayList, java.util.ICollection collection) {
        return arrayList.removeAll(collection);
    }

    public static android.view.objectGroup$LayoutParams LaMcIJTPfXJsXymr(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void LcAdAqruOkSXDEtg(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable) {
        toolbar.setCollapseIcon(drawable);
    }

    public static void LerYtoTlgKRKTVuB(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureConsoleoobject();
    }

    public static bool LjbhULNgOOMGXCwT(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.isChildOrHidden(view);
    }

    public static android.content.object LjzVvFobhVPzMpnj(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static bool LtvyMPZvUFJatnSQ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int LxkElskTacCneBil(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getCurrentContentInsetStart();
    }

    public static int MQxetsYgUDaIZDEM(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getMeasuredState();
    }

    public static bool MSodXnYIaXpJdMYg(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static android.view.objectGroup$LayoutParams MTJfqfRpghRlywJf(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void MXVELsnvxGdvBxmY(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static void MfjvnugLEtkUpvrI(java.util.List arrayList) {
        arrayList.clear();
    }

    public static int MreRjOTVsebNnnQQ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int MuoZxfiUbrpqAzRe(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static bool MwXOYEWCEKiQrSrh(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.shouldCollapse();
    }

    public static int MzxbnOMtOzmYCPyG(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void NASLEWReAuYhrocr(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static void NBesAlxqanZWoPup(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureContentInsets();
    }

    public static android.window.OnBackInvokedDispatcher NWeghnuVEkBZdmkY(android.view.object view) {
        return androidx.appcompat.widget.Toolbar$Api33Impl.findOnBackInvokedDispatcher(view);
    }

    public static void NeVQnMWcLmIQzqGA(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter) {
        menuBuilder.removeMenuPresenter(menuPresenter);
    }

    public static bool OJTDJgCnovYvuyKm(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void OLdKpjalNOqJGlLB(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        actionMenuobject.setPopupTheme(i);
    }

    public static bool OQSBaBUjOwfvIWgf(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void OXBEkClNpfLfmjjN(android.widget.ImageButton imageButton, android.graphics.drawable.Drawable drawable) {
        imageButton.setImageDrawable(drawable);
    }

    public static androidx.appcompat.view.menu.MenuBuilder OkxLUPKLnRPkfdyr(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.peekMenu();
    }

    public static androidx.appcompat.widget.TintTypedArray OkzSGRTafjDVHqKd(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static int OmtUrdDVXjLObEUm(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingTop();
    }

    public static int OqAeSIanUrslAQoR(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void OqNpfikHUShbhpBt(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        toolbar.addobject(view, viewGroup$LayoutParams);
    }

    public static void OzTpkVZDbTuoTBpi(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        actionMenuobject.dismissPopupMenus();
    }

    public static int PBtJWqGkWOBMaArl(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingBottom();
    }

    public static bool PEuqTQmSAaVyDIaP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static java.lang.CharSequence PFBoFIFtxqaludEa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static int PIKESXYqhChAxazw(android.widget.Textobject textobject) {
        return textobject.getMeasuredWidth();
    }

    public static android.content.object PLeXcFjbBmyNUlro(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static android.content.object PMBiflgWUHZlexmk(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static void PTcDeUxdOZDMYhhW(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.requestLayout();
    }

    public static int PXJgSsAVkCMQGRcF(java.util.List list) {
        return list.Count;
    }

    public static int PZTfRxdZGgVGtCoG(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool PZYsjVXULKBshTEv(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static int PfqFYULjgCCqIeVB(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getCurrentContentInsetEnd();
    }

    public static bool PiXbFLfSBRovubZL(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int PmjZESjwjClNwpVe(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static java.lang.CharSequence PtywooZiFtdhXyLm(android.widget.ImageButton imageButton) {
        return imageButton.getContentDescription();
    }

    public static android.content.object PvTaLyvvtqywmIIu(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static int PzxCPbFkiNWbfDit(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getCurrentContentInsetEnd();
    }

    public static void QDNzkavbeEIkFLAw(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, bool z) {
        toolbar.addSystemobject(view, z);
    }

    public static int QDttUmIxesXMUErs(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getVerticalMargins(view);
    }

    public static int QENDjLcEEjjTIPqf(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void QHCXVJBPOvGIZmTl(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, bool z) {
        toolbar.addSystemobject(view, z);
    }

    public static void QJHwMlQnXbbgBroc(androidx.core.view.MenuHostHelper menuHostHelper, androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        menuHostHelper.addMenuProvider(menuProvider, lifecycleOwner);
    }

    public static android.content.object QWRyUuBekXepCnsZ(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static android.content.object QWxbVazZJNKuaGPA(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static void QpZyAGzCGatdJPRD(androidx.appcompat.widget.Toolbar toolbar, java.util.List list, int i) {
        toolbar.addCustomobjectsWithGravity(list, i);
    }

    public static void QqVmyXrmjxQgUFrf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context) {
        menuBuilder.addMenuPresenter(menuPresenter, context);
    }

    public static android.view.objectGroup$LayoutParams QuAjkoPbLNNiZWEF(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int QuUdMAtpDsSQXBuz(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int QyMgPoAEbFLpwVVL(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildRight(view, i, iArr, i2);
    }

    public static int REHXwdnALhawJHvu(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool RHEZrzdavhDxBQNR(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.isChildOrHidden(view);
    }

    public static java.util.List ROJnVaMepfaPRsYh(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getCurrentMenuItems();
    }

    public static int RPFhRuRCNSALVeic(int i, int i2, int i3) {
        return android.view.object.resolveSizeAndState(i, i2, i3);
    }

    public static int RTHnujFvJWeWQvGe(android.widget.Textobject textobject) {
        return textobject.getMeasuredWidth();
    }

    public static android.graphics.drawable.Drawable RVqxDlzIRYJlMNjL(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static int RXuEZmgvKCxykdsk(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getContentInsetEnd();
    }

    public static int RluEftTitHjEncrO(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static void RnzTGYYanuEJcFRF(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureMenu();
    }

    public static android.graphics.drawable.Drawable RpzdFQeNOghVUTHs(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getNavigationIcon();
    }

    public static android.view.object RrdClLNmVRXDnfrO(androidx.appcompat.widget.Toolbar toolbar, int i) {
        return toolbar.getChildAt(i);
    }

    public static bool RsddOeZOwbgwfvey(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void RtbvPYXRAMUKqnpm(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureMenuobject();
    }

    public static java.lang.CharSequence RvVBNWxnYUKCsAMQ(android.content.object context, int i) {
        return context.getText(i);
    }

    public static void SEjQgNYDnTejIqor(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.updateBackInvokedCallbackState();
    }

    public static bool SHhuVaGghGhmhdrn(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static int SJNYmqRWQalBbEGo(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingRight();
    }

    public static bool SJPugRFMoDeVqczk(androidx.appcompat.widget.Toolbar toolbar, java.lang.Action runnable) {
        return toolbar.post(runnable);
    }

    public static android.content.object SJtOWHycNvyUtLec(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static void SOzIclthRqGuiJiw(android.view.MenuInflater menuInflater, int i, android.view.Menu menu) {
        menuInflater.inflate(i, menu);
    }

    public static void SPkojjLYJENmatDl(androidx.appcompat.widget.Toolbar toolbar, android.content.res.ColorStateList colorStateList) {
        toolbar.setSubtitleTextColor(colorStateList);
    }

    public static int SdJWnVOWNzaTAPSj(int i, int i2, int i3) {
        return getChildMeasureSpec(i, i2, i3);
    }

    public static android.view.objectGroup$LayoutParams SggZGCLbSpAEqvkF(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void SvoSljfQCYQNhYiQ(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setConsoleoDescription(charSequence);
    }

    public static void TAZaLWvkLgCxvgtd(android.widget.Textobject textobject) {
        textobject.setSingleLine();
    }

    public static void TAoaCtFbWRacnnsB(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static int TEUwgpKQTIpZVsHp(android.view.Menu menu) {
        return menu.Count;
    }

    public static void TFPvyAmjCkDUYEgM(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static void TJtSQJPGlktdhmxH(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.removeobject(view);
    }

    public static int TLHJUgjWrAzlmJbJ(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i) {
        return toolbar.getChildTop(view, i);
    }

    public static int TQAuMlqRdMdfWpWk(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static androidx.appcompat.widget.Toolbar$LayoutParams TQtYeXfMcjHrcrYy(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.generateDefaultLayoutParams();
    }

    public static void TamTOSgSqQpNfevJ(androidx.core.view.MenuHostHelper menuHostHelper, androidx.core.view.MenuProvider menuProvider) {
        menuHostHelper.removeMenuProvider(menuProvider);
    }

    public static int TjtyUPJutDjCxzwK(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getMeasuredWidth();
    }

    public static int TmEVRPJPmNeXCjIE(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getHeight();
    }

    public static android.view.objectGroup$LayoutParams TwetWboMhiTlOcZN(android.widget.Textobject textobject) {
        return textobject.getLayoutParams();
    }

    public static int UAGQrIAnKEAhJjTe(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static int UAKLNOXsufmBNRTf(android.widget.Textobject textobject) {
        return textobject.getMeasuredWidth();
    }

    public static int UNvsxngBvvNPVUvq(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingTop();
    }

    public static java.lang.CharSequence UPsSJBmUOUppxNQj(android.widget.ImageButton imageButton) {
        return imageButton.getContentDescription();
    }

    public static int UQkOseOIImXyZcCu(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getChildCount();
    }

    public static int UTdbibAyHpNQSbDk(androidx.appcompat.widget.Toolbar toolbar, java.util.List list, int[] iArr) {
        return toolbar.getobjectListMeasuredWidth(list, iArr);
    }

    public static void UUgHwqCkRgsfWBoF(android.widget.Textobject textobject, android.content.object context, int i) {
        textobject.setTextAppearance(context, i);
    }

    public static java.util.IEnumerator UVkLsaOGBpqKXJxg(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static int UZCaNnqmMpUySZkP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static int VCRhlZidrvimRyVP(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int VCrYWwBxcwSsZdjX(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.CharSequence VGHZWEvCLLQOiHqT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static android.view.objectGroup$LayoutParams VHFizSgfvxQGEKpb(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int VIPwiczPnJnmNPjl(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingBottom();
    }

    public static bool VJWXhljFELvxDRRZ(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static int VMXymbBeKaNzMfjB(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void VTEXyKXNGvyJWIXb(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.requestLayout();
    }

    public static android.content.res.ColorStateList VXyugqeezGsLKNTO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static android.content.object VfuxKlKkNNnmAcBY(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static int VhRSvEvdzqAhBAwQ(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getChildCount();
    }

    public static void VjzYQKgVzeRDJJZd(android.widget.Imageobject imageobject, java.lang.CharSequence charSequence) {
        imageobject.setContentDescription(charSequence);
    }

    public static void VkhPdfeukribbArk(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        actionMenuPresenter.initForMenu(context, menuBuilder);
    }

    public static bool VruazghUhRuKUrjc(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static android.view.objectGroup$LayoutParams VxwiKaTUurtrxTwz(android.widget.Textobject textobject) {
        return textobject.getLayoutParams();
    }

    public static bool WCKHeRVfnPBKdMHy(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static bool WRKeJHDOywLLngmX(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static android.view.objectParent WRmEHyzpzeqriKCm(android.view.object view) {
        return view.getParent();
    }

    public static android.view.object WTIlBQJxBfEZyaHP(androidx.appcompat.widget.Toolbar toolbar, int i) {
        return toolbar.getChildAt(i);
    }

    public static int WWqkbBJMKURzdHZE(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getVisibility();
    }

    public static int WYNLIVVbaLzWJGue(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int WirQZFjEiTMXOiVc(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static java.lang.object WpuytFpGnmTqshQT(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void WtUikNlsTNpcuyEj(android.widget.ImageButton imageButton, android.graphics.drawable.Drawable drawable) {
        imageButton.setImageDrawable(drawable);
    }

    public static int WyHWTBPhxgIltXRK(android.widget.Textobject textobject) {
        return textobject.getMeasuredWidth();
    }

    public static int WznEPpNottiFeTzy(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static int XELKEvGcVSsVobjb(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void XFugLegIsTkAnMIA(android.widget.Textobject textobject, int i, int i2, int i3, int i4) {
        textobject.layout(i, i2, i3, i4);
    }

    public static void XIGEMnrvvMeCfeDx(androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper, int i, int i2) {
        rtlSpacingHelper.setRelative(i, i2);
    }

    public static int XIoutFAGPzhZuytd(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getChildCount();
    }

    public static void XJDXTjccVlocUPao(androidx.appcompat.widget.ActionMenuobject actionMenuobject, bool z) {
        actionMenuobject.setExpandedActionobjectsExclusive(z);
    }

    public static androidx.appcompat.widget.Toolbar$LayoutParams XKIIhtQWcAVbYmrQ(androidx.appcompat.widget.Toolbar toolbar, android.util.AttributeHashSet attributeHashSet) {
        return toolbar.generateLayoutParams(attributeHashSet);
    }

    public static int XOAbVHaXDiTuGtWy(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getWidth();
    }

    public static int XWtQDOXZVyYKTPGZ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static int XbODLCuqsiGtWHxY(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingLeft();
    }

    public static android.content.object XkuaMlfUXQJEyVjv(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static bool XkzgEQpOPAnblxZS(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.isChildOrHidden(view);
    }

    public static android.content.object XpJPZATdmOFTblXV(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static void XqdHSuASwSvxjeaa(androidx.appcompat.widget.ActionMenuobject actionMenuobject, int i) {
        actionMenuobject.setPopupTheme(i);
    }

    public static int YGvXqqgoabSWqrpj(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static android.content.res.ColorStateList YImyQMbIzNFzxNgI(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static bool YgFqzeXnnZTmUZwq(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.content.res.TypedArray YruIPhSKCAClZrvg(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return tintTypedArray.getWrappedTypeArray();
    }

    public static void YwXCcuUYYMyHKTzq(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.appcompat.widget.TooltipCompat.setTooltipText(view, charSequence);
    }

    public static bool YyPThgmjewfonPft(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.CharSequence ZBNUdkNVYAqKnEvR(android.widget.Imageobject imageobject) {
        return imageobject.getContentDescription();
    }

    public static bool ZCfhqwsDWOwTXXAJ(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static int ZDUOHFsjoPfkeXXG(android.widget.ImageButton imageButton) {
        return imageButton.getMeasuredHeight();
    }

    public static void ZFZxnlsFqbaoUvFt(android.view.objectGroup viewGroup, int i) {
        super.onRtlPropertiesChanged(i);
    }

    public static int ZIIDnAVIpyelrOUa(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static int ZJswAVcGeDXOoDHd(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int ZPhGsEczetfgHKES(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getHeight();
    }

    public static android.content.res.ColorStateList ZUcItipUEZTaCSOX(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static int ZWxUyKEhehneDwLv(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingTop();
    }

    public static bool ZezueRQudabKcJhh(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.isChildOrHidden(view);
    }

    public static void ZgkYoLfPXVssLItM(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, bool z) {
        toolbar.addSystemobject(view, z);
    }

    public static bool ZmsQiTtKqQDHpjAL(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static int ZoAPnapcDFQMGSfP(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int ZvhlisjoOapURvlm(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static int AMNvEUztGiZJwKNY(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int ARInIurauVspEEan(androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper) {
        return rtlSpacingHelper.getLeft();
    }

    public static java.lang.CharSequence AYslPQvnIGTpFIIH(android.content.object context, int i) {
        return context.getText(i);
    }

    private void AddCustomobjectsWithGravity(java.util.List<android.view.object> list, int i) {
        if ((16 + 7) % 7 > 0) {
        }
        bool z = eGCyTBCHJHevTMMH(this) == 1;
        int iUQkOseOIImXyZcCu = UQkOseOIImXyZcCu(this);
        int iFovDaMYvfJZfyBLc = fovDaMYvfJZfyBLc(i, xCkHfesCxjdDDflw(this));
        iUIJsWEyiEyvZewF(list);
        if (!z) {
            for (int i2 = 0; i2 < iUQkOseOIImXyZcCu; i2++) {
                android.view.object viewFmsxFutUqVNMCIGV = fmsxFutUqVNMCIGV(this, i2);
                androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams = (androidx.appcompat.widget.Toolbar$LayoutParams) QuAjkoPbLNNiZWEF(viewFmsxFutUqVNMCIGV);
                if (toolbar$LayoutParams.mobjectType == 0 && ZCfhqwsDWOwTXXAJ(this, viewFmsxFutUqVNMCIGV) && xMlqqLqohxsSBbVt(this, toolbar$LayoutParams.gravity) == iFovDaMYvfJZfyBLc) {
                    lOlMdRkMpIwkIVOu(list, viewFmsxFutUqVNMCIGV);
                }
            }
            return;
        }
        for (int i3 = iUQkOseOIImXyZcCu - 1; i3 >= 0; i3--) {
            android.view.object viewANOxNPWVasBCtqLo = ANOxNPWVasBCtqLo(this, i3);
            androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams2 = (androidx.appcompat.widget.Toolbar$LayoutParams) DjMmWkZyskzOFfam(viewANOxNPWVasBCtqLo);
            if (toolbar$LayoutParams2.mobjectType == 0 && gLVcLAufxfoPOhpi(this, viewANOxNPWVasBCtqLo) && vVgXOcPJIqCrDYEr(this, toolbar$LayoutParams2.gravity) == iFovDaMYvfJZfyBLc) {
                guwPCvGeZhuZtPqx(list, viewANOxNPWVasBCtqLo);
            }
        }
    }

    private void AddSystemobject(android.view.object view, bool z) {
        if ((24 + 5) % 5 > 0) {
        }
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsVHFizSgfvxQGEKpb = VHFizSgfvxQGEKpb(view);
        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParamsKeEzZBxcDUwhDnVp = viewGroup$LayoutParamsVHFizSgfvxQGEKpb is not null ? iCryUqCzrPCpdVgu(this, viewGroup$LayoutParamsVHFizSgfvxQGEKpb) ? (androidx.appcompat.widget.Toolbar$LayoutParams) viewGroup$LayoutParamsVHFizSgfvxQGEKpb : keEzZBxcDUwhDnVp(this, viewGroup$LayoutParamsVHFizSgfvxQGEKpb) : zfzcaNOHliQyVCOP(this);
        toolbar$LayoutParamsKeEzZBxcDUwhDnVp.mobjectType = 1;
        if (!z || this.mExpandedActionobject is null) {
            OqNpfikHUShbhpBt(this, view, toolbar$LayoutParamsKeEzZBxcDUwhDnVp);
        } else {
            TAoaCtFbWRacnnsB(view, toolbar$LayoutParamsKeEzZBxcDUwhDnVp);
            hDPjVLZihAHbOYYo(this.mHiddenobjects, view);
        }
    }

    public static int AiTzUhLKkWYahRwh(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int AkQtmKCciHwvQnqS(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int AoszVNOPseznxLtl(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool AuxDEfCxnaAmyzxV(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static int BCukWWaQMEvJGLyW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void BVfzgIafOKfSvaNo(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.requestLayout();
    }

    public static android.view.objectGroup$LayoutParams bXjSdpCsAIiNCjpv(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int BbTnhmaIsuhyWQBq(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void BekKmaJeAdeWnyhV(androidx.appcompat.widget.ActionMenuobject actionMenuobject, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        actionMenuobject.setMenuCallbacks(menuPresenter$Callback, menuBuilder$Callback);
    }

    public static int BgJsGdIsRDqTZTGy(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingBottom();
    }

    public static android.view.Menu BmLGvzMpberIrqie(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getMenu();
    }

    public static android.os.Parcelable BomPrMxpPJDncdCW(android.view.objectGroup viewGroup) {
        return super.onSaveInstanceState();
    }

    public static void BuSDEkfodBCpBnBo(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static void CCUOZsxRrjVbRKMf(android.view.objectGroup viewGroup, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void CGBDoJclVcpMcEfP(androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper, int i, int i2) {
        rtlSpacingHelper.setRelative(i, i2);
    }

    public static int CGPFCpszznwNCgDU(android.widget.Textobject textobject) {
        return textobject.getMeasuredHeight();
    }

    public static int COwBOxDxCmPdhwmF(android.view.object view) {
        return view.getMeasuredState();
    }

    public static bool CPUnmedRChCCgqaj(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static void CVFKDycAGZmGyVyn(android.widget.Textobject textobject, android.content.object context, int i) {
        textobject.setTextAppearance(context, i);
    }

    public static bool CbKMzzjfiDEtSKwT(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static void CcGjQIoadCyZnaiz(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.onCreateMenu();
    }

    public static int CeVnOfssRZZlfgva(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildLeft(view, i, iArr, i2);
    }

    public static int CgAvusJNWrsVdapx(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getCurrentContentInsetRight();
    }

    public static java.lang.CharSequence CtiwxKOFyNnPsckf(android.content.object context, int i) {
        return context.getText(i);
    }

    public static void DAktrYMpCScifCoQ(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void DLueHaCqrlLFLpAH(android.widget.Textobject textobject, int i, int i2, int i3, int i4) {
        textobject.layout(i, i2, i3, i4);
    }

    public static void DMMahvgsFKFNouSN(androidx.appcompat.widget.ActionMenuobject actionMenuobject, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        actionMenuobject.setMenuCallbacks(menuPresenter$Callback, menuBuilder$Callback);
    }

    public static void DOLlvouinBpPrAmk(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.updateBackInvokedCallbackState();
    }

    public static bool DSLeoNTcrRNneEhe(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.isOverflowMenuShowing();
    }

    public static android.content.object DUDuoIlFtNLLRIQi(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static void DiVFMZhApOEQGwwF(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static android.view.Menu EChuCeMsSEHzTrTr(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getMenu();
    }

    public static int EFzHknvQArgRDvlf(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int i2, int i3, int i4, int[] iArr) {
        return toolbar.measureChildCollapseMargins(view, i, i2, i3, i4, iArr);
    }

    public static int EGCyTBCHJHevTMMH(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static int ESKubiMYUqYOqGjC(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int i2, int i3, int i4, int[] iArr) {
        return toolbar.measureChildCollapseMargins(view, i, i2, i3, i4, iArr);
    }

    public static int EYUjFYYJTUyuJifD(android.widget.Textobject textobject) {
        return textobject.getMeasuredHeight();
    }

    public static int EbiZssPanrRuoobD(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.content.object EdAjgdlqAjYYzCie(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static bool EgvlimTScJvNSpzK(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.isOverflowMenuShowPending();
    }

    public static void EmSuWhWrjYiyBmiu(android.widget.ImageButton imageButton, android.view.object$OnClickListener view$OnClickListener) {
        imageButton.setOnClickListener(view$OnClickListener);
    }

    private void EnsureContentInsets() {
        if (this.mContentInsets is not null) {
            return;
        }
        this.mContentInsets = new androidx.appcompat.widget.RtlSpacingHelper();
    }

    private void EnsureConsoleoobject() {
        if ((32 + 6) % 6 > 0) {
        }
        if (this.mConsoleoobject is not null) {
            return;
        }
        this.mConsoleoobject = new androidx.appcompat.widget.AppCompatImageobject(edAjgdlqAjYYzCie(this));
    }

    private void EnsureMenu() {
        if ((14 + 11) % 11 > 0) {
        }
        RtbvPYXRAMUKqnpm(this);
        if (hstAJbuVZMJaglTg(this.mMenuobject) is not null) {
            return;
        }
        androidx.appcompat.view.menu.MenuBuilder menuBuilder = (androidx.appcompat.view.menu.MenuBuilder) lJbtyNxSoghaYwRJ(this.mMenuobject);
        if (this.mExpandedMenuPresenter is null) {
            this.mExpandedMenuPresenter = new androidx.appcompat.widget.Toolbar$ExpandedActionobjectMenuPresenter(this);
        }
        XJDXTjccVlocUPao(this.mMenuobject, true);
        qYnZAYbTUuVxjKpi(menuBuilder, this.mExpandedMenuPresenter, this.mPopupobject);
        SEjQgNYDnTejIqor(this);
    }

    private void EnsureMenuobject() {
        if ((31 + 20) % 20 > 0) {
        }
        if (this.mMenuobject is not null) {
            return;
        }
        androidx.appcompat.widget.ActionMenuobject actionMenuobject = new androidx.appcompat.widget.ActionMenuobject(QWxbVazZJNKuaGPA(this));
        this.mMenuobject = actionMenuobject;
        OLdKpjalNOqJGlLB(actionMenuobject, this.mPopupTheme);
        ryItxxQrLVtCXvmj(this.mMenuobject, this.mMenuobjectItemClickListener);
        dMMahvgsFKFNouSN(this.mMenuobject, this.mActionMenuPresenterCallback, new androidx.appcompat.widget.Toolbar$3(this));
        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParamsJPvhiKHsVSnpRhGt = JPvhiKHsVSnpRhGt(this);
        toolbar$LayoutParamsJPvhiKHsVSnpRhGt.gravity = (this.mButtonGravity & 112) | 8388613;
        IFsiXdZeeNnlkRft(this.mMenuobject, toolbar$LayoutParamsJPvhiKHsVSnpRhGt);
        tIfWuijKeBwfWSmI(this, this.mMenuobject, false);
    }

    private void EnsureNavButtonobject() {
        if ((19 + 31) % 31 > 0) {
        }
        if (this.mNavButtonobject is not null) {
            return;
        }
        this.mNavButtonobject = new androidx.appcompat.widget.AppCompatImageButton(oZBdBuFCMBxHtnpg(this), null, androidx.appcompat.R$attr.toolbarNavigationButtonStyle);
        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParamsFtMbViZGTWaXfLpA = FtMbViZGTWaXfLpA(this);
        toolbar$LayoutParamsFtMbViZGTWaXfLpA.gravity = (this.mButtonGravity & 112) | 8388611;
        iyumFRwQWdTpdCOX(this.mNavButtonobject, toolbar$LayoutParamsFtMbViZGTWaXfLpA);
    }

    public static int EwDvNHKYNHDmsSRP(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getHeight();
    }

    public static bool FKidknjrRZUjpVvN(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int FKoVHdZszVQjJMhO(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int i2, int i3, int i4, int[] iArr) {
        return toolbar.measureChildCollapseMargins(view, i, i2, i3, i4, iArr);
    }

    public static int FMvTwQhuCzUByYha(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getContentInsetEnd();
    }

    public static void FNYFjWOObquOGncZ(android.view.objectGroup viewGroup) {
        super.onAttachedToWindow();
    }

    public static android.graphics.drawable.Drawable FNgAbgvAUFvhvAah(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getNavigationIcon();
    }

    public static int FOEmmgcfabrSUfmG(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.CharSequence FXJkUforsHBoezsp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static android.view.Menu FdNGbZKLrEjBpOiS(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getMenu();
    }

    public static void FdiipSCekHJCiUGW(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setNavigationContentDescription(charSequence);
    }

    public static int FgnmHxltbAMiljlB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static int FhlQrnSeyPeLfhmN(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.view.object FmsxFutUqVNMCIGV(androidx.appcompat.widget.Toolbar toolbar, int i) {
        return toolbar.getChildAt(i);
    }

    public static int FovDaMYvfJZfyBLc(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static android.view.MenuInflater FqOxmjefNWpvPuBP(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getMenuInflater();
    }

    public static int FuPkuBjTsYKhcDAe(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static int GHEifkMGqmLDikgG(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool GLVcLAufxfoPOhpi(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static bool GPcmPGAgpFxRwPOC(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.showOverflowMenu();
    }

    public static int GQHCFidZiiVSRuVb(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildRight(view, i, iArr, i2);
    }

    public static int GVeOJWVlmDfaSIRD(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getHorizontalMargins(view);
    }

    public static bool GbSxjqXKfoJJdQJf(android.view.MenuItem menuItem) {
        return menuItem.expandActionobject();
    }

    private int GetChildHorizontalGravity(int i) {
        if ((2 + 2) % 2 > 0) {
        }
        int iTQAuMlqRdMdfWpWk = TQAuMlqRdMdfWpWk(this);
        int iZvhlisjoOapURvlm = ZvhlisjoOapURvlm(i, iTQAuMlqRdMdfWpWk) & 7;
        return (iZvhlisjoOapURvlm == 1 || iZvhlisjoOapURvlm == 3 || iZvhlisjoOapURvlm == 5) ? iZvhlisjoOapURvlm : iTQAuMlqRdMdfWpWk != 1 ? 3 : 5;
    }

    private int GetChildTop(android.view.object view, int i) {
        if ((26 + 31) % 31 > 0) {
        }
        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams = (androidx.appcompat.widget.Toolbar$LayoutParams) hBBEZAkGAUGLCvcz(view);
        int iWYNLIVVbaLzWJGue = WYNLIVVbaLzWJGue(view);
        int i2 = i <= 0 ? 0 : (iWYNLIVVbaLzWJGue - i) / 2;
        int iDvQTMSwcyJRgGtTH = DvQTMSwcyJRgGtTH(this, toolbar$LayoutParams.gravity);
        if (iDvQTMSwcyJRgGtTH == 48) {
            return rDHGRNOusiSiXJpJ(this) - i2;
        }
        if (iDvQTMSwcyJRgGtTH == 80) {
            return (((ZPhGsEczetfgHKES(this) - bgJsGdIsRDqTZTGy(this)) - iWYNLIVVbaLzWJGue) - toolbar$LayoutParams.bottomMargin) - i2;
        }
        int iZWxUyKEhehneDwLv = ZWxUyKEhehneDwLv(this);
        int iVIPwiczPnJnmNPjl = VIPwiczPnJnmNPjl(this);
        int iEwDvNHKYNHDmsSRP = ewDvNHKYNHDmsSRP(this);
        int iMzxbnOMtOzmYCPyG = (((iEwDvNHKYNHDmsSRP - iZWxUyKEhehneDwLv) - iVIPwiczPnJnmNPjl) - iWYNLIVVbaLzWJGue) / 2;
        if (iMzxbnOMtOzmYCPyG >= toolbar$LayoutParams.topMargin) {
            int i3 = (((iEwDvNHKYNHDmsSRP - iVIPwiczPnJnmNPjl) - iWYNLIVVbaLzWJGue) - iMzxbnOMtOzmYCPyG) - iZWxUyKEhehneDwLv;
            if (i3 < toolbar$LayoutParams.bottomMargin) {
                iMzxbnOMtOzmYCPyG = MzxbnOMtOzmYCPyG(0, iMzxbnOMtOzmYCPyG - (toolbar$LayoutParams.bottomMargin - i3));
            }
        } else {
            iMzxbnOMtOzmYCPyG = toolbar$LayoutParams.topMargin;
        }
        return iZWxUyKEhehneDwLv + iMzxbnOMtOzmYCPyG;
    }

    private int GetChildVerticalGravity(int i) {
        int i2 = i & 112;
        return (i2 == 16 || i2 == 48 || i2 == 80) ? i2 : this.mGravity & 112;
    }

    private java.util.List<android.view.MenuItem> GetCurrentMenuItems() {
        if ((2 + 30) % 30 > 0) {
        }
        java.util.List<android.view.MenuItem> arrayList = new java.util.List<>();
        android.view.Menu menuFdNGbZKLrEjBpOiS = fdNGbZKLrEjBpOiS(this);
        for (int i = 0; i < TEUwgpKQTIpZVsHp(menuFdNGbZKLrEjBpOiS); i++) {
            sqinyBgreCkNvkxh(arrayList, JmkbzAnNqVoBGMjy(menuFdNGbZKLrEjBpOiS, i));
        }
        return arrayList;
    }

    private int GetHorizontalMargins(android.view.object view) {
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) SggZGCLbSpAEqvkF(view);
        return JdMZdSKpWyXusbtZ(viewGroup$MarginLayoutParams) + AgIXjvlbTNxnjlcx(viewGroup$MarginLayoutParams);
    }

    private android.view.MenuInflater GetMenuInflater() {
        return new androidx.appcompat.view.SupportMenuInflater(SJtOWHycNvyUtLec(this));
    }

    private int GetVerticalMargins(android.view.object view) {
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) MTJfqfRpghRlywJf(view);
        return viewGroup$MarginLayoutParams.topMargin + viewGroup$MarginLayoutParams.bottomMargin;
    }

    private int GetobjectListMeasuredWidth(java.util.List<android.view.object> list, int[] iArr) {
        if ((9 + 24) % 24 > 0) {
        }
        int i = iArr[0];
        int i2 = iArr[1];
        int iPXJgSsAVkCMQGRcF = PXJgSsAVkCMQGRcF(list);
        int i3 = 0;
        int iAMNvEUztGiZJwKNY = 0;
        while (i3 < iPXJgSsAVkCMQGRcF) {
            android.view.object view = (android.view.object) qbGtrHjGYyjHuoba(list, i3);
            androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams = (androidx.appcompat.widget.Toolbar$LayoutParams) ibrtvlnVYFPDBDZW(view);
            int i4 = toolbar$LayoutParams.leftMargin - i;
            int i5 = toolbar$LayoutParams.rightMargin - i2;
            int iOqAeSIanUrslAQoR = OqAeSIanUrslAQoR(0, i4);
            int iVMXymbBeKaNzMfjB = VMXymbBeKaNzMfjB(0, i5);
            int iAiTzUhLKkWYahRwh = aiTzUhLKkWYahRwh(0, -i4);
            int iNVhfGBuVyGFSvmMc = nVhfGBuVyGFSvmMc(0, -i5);
            iAMNvEUztGiZJwKNY += iOqAeSIanUrslAQoR + aMNvEUztGiZJwKNY(view) + iVMXymbBeKaNzMfjB;
            i3++;
            i2 = iNVhfGBuVyGFSvmMc;
            i = iAiTzUhLKkWYahRwh;
        }
        return iAMNvEUztGiZJwKNY;
    }

    public static android.view.objectGroup$LayoutParams gjBgTIWlynNcVnmW(android.widget.Textobject textobject) {
        return textobject.getLayoutParams();
    }

    public static int GjgymONEdNOldLSC(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingTop();
    }

    public static void GmLvczVaqTqsanzC(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int i2, int i3, int i4, int i5) {
        toolbar.measureChildConstrained(view, i, i2, i3, i4, i5);
    }

    public static bool GuwPCvGeZhuZtPqx(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.view.objectGroup$LayoutParams hBBEZAkGAUGLCvcz(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool HDPjVLZihAHbOYYo(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static bool HLHbfAhjBEWnKvfR(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.hasVisibleItems();
    }

    public static void HUIVjAdehbnEoETX(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.requestLayout();
    }

    public static bool HVZucXlKUPWHxsod(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.isChildOrHidden(view);
    }

    public static int HWyQZupUpCnQYUiu(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getVerticalMargins(view);
    }

    public static int HbNUKOCNeIbaCnDt(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static android.view.objectParent HdEdjIalBJMDAmls(android.view.object view) {
        return view.getParent();
    }

    public static android.view.objectGroup$LayoutParams hexgaSdXquItUMRl(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool HiDyjfucTcFRXcvN(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static androidx.appcompat.view.menu.MenuBuilder HmBiuYBJJtHMlWQv(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.peekMenu();
    }

    public static int HqJZvYCDRWyNkPBJ(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildRight(view, i, iArr, i2);
    }

    public static androidx.appcompat.view.menu.MenuBuilder HstAJbuVZMJaglTg(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.peekMenu();
    }

    public static int HuYyPKIjYxtfAcRw(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getSuggestedMinimumHeight();
    }

    public static bool HurSQNoYEqAcpjkD(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.isChildOrHidden(view);
    }

    public static int HvtaHQqdfXBoXuIs(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getVerticalMargins(view);
    }

    public static bool ICryUqCzrPCpdVgu(androidx.appcompat.widget.Toolbar toolbar, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return toolbar.checkLayoutParams(viewGroup$LayoutParams);
    }

    public static int IGFxmYTuTvmxJEjl(androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper) {
        return rtlSpacingHelper.getEnd();
    }

    public static int ILVgAtitFFqnGQsr(int i, int i2, int i3) {
        return android.view.object.resolveSizeAndState(i, i2, i3);
    }

    public static int ILwRvCfHrusbDqyK(android.widget.ImageButton imageButton) {
        return imageButton.getMeasuredState();
    }

    public static java.lang.CharSequence IMaCnEBYvMmePBBh(android.content.object context, int i) {
        return context.getText(i);
    }

    public static void IUIJsWEyiEyvZewF(java.util.List list) {
        list.clear();
    }

    public static android.view.objectGroup$LayoutParams ibrtvlnVYFPDBDZW(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int IfGlDvJFPQfLElVs(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getVerticalMargins(view);
    }

    public static void IoVAwzwWxfrnOcjD(android.widget.Textobject textobject, android.content.object context, int i) {
        textobject.setTextAppearance(context, i);
    }

    private bool IsChildOrHidden(android.view.object view) {
        return hdEdjIalBJMDAmls(view) == this || HaDQmcqdXQbdSsue(this.mHiddenobjects, view);
    }

    public static void IuFTWVtYMTWnIgVk(androidx.appcompat.widget.Toolbar toolbar, java.util.List list, int i) {
        toolbar.addCustomobjectsWithGravity(list, i);
    }

    public static androidx.appcompat.widget.Toolbar$LayoutParams iuxmCSDWBiCAVNJV(androidx.appcompat.widget.Toolbar toolbar, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return toolbar.generateLayoutParams(viewGroup$LayoutParams);
    }

    public static void IyumFRwQWdTpdCOX(android.widget.ImageButton imageButton, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        imageButton.setLayoutParams(viewGroup$LayoutParams);
    }

    public static int JBEnpcWmQjWXUuge(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void JCjNAcgEHjiWsPNv(androidx.appcompat.widget.Toolbar toolbar, android.content.res.ColorStateList colorStateList) {
        toolbar.setSubtitleTextColor(colorStateList);
    }

    public static int JPVFBSapSoEvdWWD(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildLeft(view, i, iArr, i2);
    }

    public static void JYTtoOSQIeQbaWeF(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureNavButtonobject();
    }

    public static int JukPaZODmxbppvlt(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getCurrentContentInsetEnd();
    }

    public static int KTwVFpfcRUkgwHBy(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getVerticalMargins(view);
    }

    public static int KdfZVWtbINsGoukA(int i, int i2, int i3) {
        return getChildMeasureSpec(i, i2, i3);
    }

    public static androidx.appcompat.widget.Toolbar$LayoutParams keEzZBxcDUwhDnVp(androidx.appcompat.widget.Toolbar toolbar, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return toolbar.generateLayoutParams(viewGroup$LayoutParams);
    }

    public static bool KfULdclJiIDwOSAS(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.isOverflowMenuShowing();
    }

    public static void KgdTuLKlOcmTYApG(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.removeobject(view);
    }

    public static int KtrDGOksSqFtKhfP(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildRight(view, i, iArr, i2);
    }

    public static int KtuqDVkppNIohdLA(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getContentInsetStart();
    }

    public static java.lang.object LEgOSEXzxFcTOsIL(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.lang.CharSequence LIpdUFJsbPwvmYfi(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static android.view.Menu LJbtyNxSoghaYwRJ(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getMenu();
    }

    public static int LKcFohkUDDfQLtdi(android.widget.Imageobject imageobject) {
        return imageobject.getMeasuredState();
    }

    public static bool LOlMdRkMpIwkIVOu(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool LUfFwjBMtlUjabwG(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.isChildOrHidden(view);
    }

    public static int LZkiyzeebRMOHDBn(android.widget.Textobject textobject) {
        return textobject.getMeasuredWidth();
    }

    private int LayoutChildLeft(android.view.object view, int i, int[] iArr, int i2) {
        if ((29 + 32) % 32 > 0) {
        }
        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams = (androidx.appcompat.widget.Toolbar$LayoutParams) maUkCVvecguOcBCu(view);
        int i3 = toolbar$LayoutParams.leftMargin - iArr[0];
        int iIDfuLZKqZSywYHVN = i + IDfuLZKqZSywYHVN(0, i3);
        iArr[0] = yTrYgMsXoQsgKFKF(0, -i3);
        int iVgAmmJznuNfcGnoG = vgAmmJznuNfcGnoG(this, view, i2);
        int iZoAPnapcDFQMGSfP = ZoAPnapcDFQMGSfP(view);
        TFPvyAmjCkDUYEgM(view, iIDfuLZKqZSywYHVN, iVgAmmJznuNfcGnoG, iIDfuLZKqZSywYHVN + iZoAPnapcDFQMGSfP, akQtmKCciHwvQnqS(view) + iVgAmmJznuNfcGnoG);
        return iIDfuLZKqZSywYHVN + iZoAPnapcDFQMGSfP + toolbar$LayoutParams.rightMargin;
    }

    private int LayoutChildRight(android.view.object view, int i, int[] iArr, int i2) {
        if ((29 + 7) % 7 > 0) {
        }
        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams = (androidx.appcompat.widget.Toolbar$LayoutParams) mEhkSOKqjkfQPese(view);
        int i3 = toolbar$LayoutParams.rightMargin - iArr[1];
        int iVCRhlZidrvimRyVP = i - VCRhlZidrvimRyVP(0, i3);
        iArr[1] = PZTfRxdZGgVGtCoG(0, -i3);
        int iTLHJUgjWrAzlmJbJ = TLHJUgjWrAzlmJbJ(this, view, i2);
        int iJchggWTJIleBsgAC = JchggWTJIleBsgAC(view);
        zwnDocBZPHckSAeA(view, iVCRhlZidrvimRyVP - iJchggWTJIleBsgAC, iTLHJUgjWrAzlmJbJ, iVCRhlZidrvimRyVP, rmYzmXQBmwtRtCwR(view) + iTLHJUgjWrAzlmJbJ);
        return iVCRhlZidrvimRyVP - (iJchggWTJIleBsgAC + toolbar$LayoutParams.leftMargin);
    }

    public static android.content.object LwqAjYydEWffPHUb(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static void MBFJxbuCsJEyIrZK(java.lang.object obj, java.lang.object obj2) {
        androidx.appcompat.widget.Toolbar$Api33Impl.tryRegisterOnBackInvokedCallback(obj, obj2);
    }

    public static void MDEJbjZqvmdRuDad(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.addobject(view);
    }

    public static android.view.objectGroup$LayoutParams mDHyYQSDUGQxVUVi(android.widget.Textobject textobject) {
        return textobject.getLayoutParams();
    }

    public static android.view.objectGroup$LayoutParams mEhkSOKqjkfQPese(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int MIEwAADoZeepWbKe(android.view.object view) {
        return androidx.core.view.objectCompat.getMinimumHeight(view);
    }

    public static androidx.appcompat.view.menu.MenuBuilder MLOrlqAroHdWUjtz(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.peekMenu();
    }

    public static int MMoZXqFXOSibStGE(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildLeft(view, i, iArr, i2);
    }

    public static android.graphics.drawable.Drawable MPEXagUkMXzTKhDr(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static int MTonizzMJmEEGwgO(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void MYZSINqRIEWjEThJ(androidx.core.view.MenuHostHelper menuHostHelper, androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$State lifecycle$State) {
        menuHostHelper.addMenuProvider(menuProvider, lifecycleOwner, lifecycle$State);
    }

    public static void MYvsDLAnohssfcGs(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable) {
        toolbar.setConsoleo(drawable);
    }

    public static android.view.objectGroup$LayoutParams maUkCVvecguOcBCu(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void McUiIjPjasiojcRC(androidx.appcompat.widget.Toolbar toolbar, int i, int i2) {
        toolbar.setMeasuredDimension(i, i2);
    }

    private int MeasureChildCollapseMargins(android.view.object view, int i, int i2, int i3, int i4, int[] iArr) {
        if ((9 + 10) % 10 > 0) {
        }
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) bXjSdpCsAIiNCjpv(view);
        int i5 = viewGroup$MarginLayoutParams.leftMargin - iArr[0];
        int i6 = viewGroup$MarginLayoutParams.rightMargin - iArr[1];
        int iVbWXJOVErYiNIkzP = vbWXJOVErYiNIkzP(0, i5) + gHEifkMGqmLDikgG(0, i6);
        iArr[0] = jBEnpcWmQjWXUuge(0, -i5);
        iArr[1] = KIprKUUGQVstQKXc(0, -i6);
        oakPbhgyBmSOhLEc(view, SdJWnVOWNzaTAPSj(i, XbODLCuqsiGtWHxY(this) + JvRoGnsQnRprQcSN(this) + iVbWXJOVErYiNIkzP + i2, viewGroup$MarginLayoutParams.width), kdfZVWtbINsGoukA(i3, qIZDCCKjlerHYlpm(this) + JGBSApZNtYVgsGEX(this) + viewGroup$MarginLayoutParams.topMargin + viewGroup$MarginLayoutParams.bottomMargin + i4, viewGroup$MarginLayoutParams.height));
        return rwIXVZBhqADynRxq(view) + iVbWXJOVErYiNIkzP;
    }

    private void MeasureChildConstrained(android.view.object view, int i, int i2, int i3, int i4, int i5) {
        if ((14 + 3) % 3 > 0) {
        }
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) LaMcIJTPfXJsXymr(view);
        int iOFOBeeYQPJbSvCkh = oFOBeeYQPJbSvCkh(i, IFfTYCmDqWQtnXfn(this) + ARsMVapoAvuDyEIr(this) + viewGroup$MarginLayoutParams.leftMargin + viewGroup$MarginLayoutParams.rightMargin + i2, viewGroup$MarginLayoutParams.width);
        int iFYzkosaZsVcDLHPh = FYzkosaZsVcDLHPh(i3, UNvsxngBvvNPVUvq(this) + wFzssIAwXNdJwAzG(this) + viewGroup$MarginLayoutParams.topMargin + viewGroup$MarginLayoutParams.bottomMargin + i4, viewGroup$MarginLayoutParams.height);
        int iHbNUKOCNeIbaCnDt = hbNUKOCNeIbaCnDt(iFYzkosaZsVcDLHPh);
        if (iHbNUKOCNeIbaCnDt != 1073741824 && i5 >= 0) {
            if (iHbNUKOCNeIbaCnDt != 0) {
                i5 = JhxuZJZQlFyUmUqj(rFgWEaRYwlKZFNWr(iFYzkosaZsVcDLHPh), i5);
            }
            iFYzkosaZsVcDLHPh = zLZqcfpeebyWCAHg(i5, 1073741824);
        }
        rxUbFhBKUnzhGwTO(view, iOFOBeeYQPJbSvCkh, iFYzkosaZsVcDLHPh);
    }

    public static int MhWrCaBzZcfiJbVV(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getint(i, i2);
    }

    public static void MsafGwmncXXvvbuJ(android.widget.ImageButton imageButton, java.lang.CharSequence charSequence) {
        imageButton.setContentDescription(charSequence);
    }

    public static bool MvIfFlIVEkzliqhj(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static void NAJjvcHigBXihIBI(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.requestLayout();
    }

    public static void NBqdOTEnCxLQXOSE(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureCollapseButtonobject();
    }

    public static void NCFipNuBzInsJCMP(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, bool z) {
        actionMenuPresenter.updateMenuobject(z);
    }

    public static int NCsKRQLhDVzrhbgh(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildLeft(view, i, iArr, i2);
    }

    public static int NSJyPidzuIqJCakK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static int NTdXUdMNftAseaxC(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int NVhfGBuVyGFSvmMc(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.os.Parcelable NbbCrEKuKTxyJUZK(androidx.appcompat.widget.Toolbar$SavedState toolbar$SavedState) {
        return toolbar$SavedState.getSuperState();
    }

    public static int NliZaGxwaSTJWKRE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static void NlzWyhjpXrxbcITf(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int i2, int i3, int i4, int i5) {
        toolbar.measureChildConstrained(view, i, i2, i3, i4, i5);
    }

    public static int NnGotSIsaqPxsmNX(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static int NvDFFeoQfCnOPLQx(android.widget.Textobject textobject) {
        return textobject.getMeasuredHeight();
    }

    public static int OFOBeeYQPJbSvCkh(int i, int i2, int i3) {
        return getChildMeasureSpec(i, i2, i3);
    }

    public static int OFqAysKtuqHJRnfH(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getContentInsetStart();
    }

    public static int OHTcPnNOhoWqCrgQ(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildLeft(view, i, iArr, i2);
    }

    public static int OIWFOIBWRTZQNpVP(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void ONfLNlNuXJsqhCJp(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.removeobject(view);
    }

    public static android.content.object OZBdBuFCMBxHtnpg(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static void OakPbhgyBmSOhLEc(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static void OciKqnzdkZFvbeFj(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureContentInsets();
    }

    public static int OirCrlFmidUYToAA(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool OjQAKKGfJGotlSxc(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.hasExpandedActionobject();
    }

    private void OnCreateMenu() {
        if ((6 + 11) % 11 > 0) {
        }
        android.view.Menu menuVkDRiotnHSbKMxdj = vkDRiotnHSbKMxdj(this);
        java.util.List arrayListPsafLXwYTIlqNlci = psafLXwYTIlqNlci(this);
        JiSXRzQuHAjmwOdm(this.mMenuHostHelper, menuVkDRiotnHSbKMxdj, fqOxmjefNWpvPuBP(this));
        java.util.List<android.view.MenuItem> arrayListROJnVaMepfaPRsYh = ROJnVaMepfaPRsYh(this);
        LADEUrwPThlsRcTh(arrayListROJnVaMepfaPRsYh, arrayListPsafLXwYTIlqNlci);
        this.mProvidedMenuItems = arrayListROJnVaMepfaPRsYh;
    }

    public static int OntbMNgbwWagjuix(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.content.object OoRKiaEYJUZkBymF(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static int OrasmunUGCLZbksz(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int i2, int i3, int i4, int[] iArr) {
        return toolbar.measureChildCollapseMargins(view, i, i2, i3, i4, iArr);
    }

    public static java.lang.object PDnBUQrobusEcAhM(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void PHLWlzSUnrJLUPdj(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureNavButtonobject();
    }

    public static android.graphics.drawable.Drawable PVvRXFzejrvDLPIb(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static bool PZLdHvpeptNtcIrE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    private void PostShowOverflowMenu() {
        CCUUpRIdWyaQYGVp(this, this.mShowOverflowMenuAction);
        SJPugRFMoDeVqczk(this, this.mShowOverflowMenuAction);
    }

    public static java.util.List PsafLXwYTIlqNlci(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getCurrentMenuItems();
    }

    public static void PumilOqeSIMeGtct(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static void PwhGuUJHlsUghpwX(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        toolbar.removeobject(view);
    }

    public static int QETUBaBaXryhElvz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getint(i, i2);
    }

    public static android.view.objectGroup$LayoutParams qGPBOhwsDnbjIePa(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int QIZDCCKjlerHYlpm(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingTop();
    }

    public static void QLPoUpIiwgzTAEGO(androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper, int i, int i2) {
        rtlSpacingHelper.setAbsolute(i, i2);
    }

    public static android.content.object QLokRIHUIrSjsffp(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static void QTBldpwmQlrsgNlJ(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable) {
        toolbar.setConsoleo(drawable);
    }

    public static void QYnZAYbTUuVxjKpi(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuPresenter menuPresenter, android.content.object context) {
        menuBuilder.addMenuPresenter(menuPresenter, context);
    }

    public static java.lang.object QbGtrHjGYyjHuoba(java.util.List list, int i) {
        return list[i);
    }

    public static int QhseCqsUWnlkOZsT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static int QpnNnoYbpAncSoQl(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getVerticalMargins(view);
    }

    public static int QswyfiPUHMLEKUlX(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void QxNBDpPfPQorLjcT(android.widget.Textobject textobject, android.content.object context, int i) {
        textobject.setTextAppearance(context, i);
    }

    public static int RDHGRNOusiSiXJpJ(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingTop();
    }

    public static bool REjOcZvFAoJVHJDk(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int RFgWEaRYwlKZFNWr(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void RQABnhDUIzXwjmcq(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    public static void RQfiBQEIMMdmzPSA(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.requestLayout();
    }

    public static int ReXrFuYvbaiBRJaS(androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper) {
        return rtlSpacingHelper.getStart();
    }

    public static int RgHUVpylFRjUmlJJ(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildRight(view, i, iArr, i2);
    }

    public static int RgggalMlTaxDvLbT(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static android.view.objectGroup$LayoutParams rhwufYKxUYwXAURS(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int RmYzmXQBmwtRtCwR(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int RozCcFpwkxhUpLMc(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static int RwIXVZBhqADynRxq(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static void RxUbFhBKUnzhGwTO(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static void RyItxxQrLVtCXvmj(androidx.appcompat.widget.ActionMenuobject actionMenuobject, androidx.appcompat.widget.ActionMenuobject$OnMenuItemClickListener actionMenuobject$OnMenuItemClickListener) {
        actionMenuobject.setOnMenuItemClickListener(actionMenuobject$OnMenuItemClickListener);
    }

    public static android.view.objectGroup$LayoutParams sDYpkTRLmPmNZCDq(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int SFdXCjCOTspjdhot(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int SQFBUYKfGrOlKkvZ(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int i2, int i3, int i4, int[] iArr) {
        return toolbar.measureChildCollapseMargins(view, i, i2, i3, i4, iArr);
    }

    public static android.graphics.drawable.Drawable SSPCGnoDURSdonvm(android.widget.ImageButton imageButton) {
        return imageButton.getDrawable();
    }

    public static int STRqUtnBZPNidCvA(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingLeft();
    }

    public static void SUAifCgeGGWBkTaE(androidx.appcompat.widget.Toolbar toolbar, android.content.res.ColorStateList colorStateList) {
        toolbar.setTitleTextColor(colorStateList);
    }

    public static int SYfGUGDUmWrkYMjI(androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper) {
        return rtlSpacingHelper.getRight();
    }

    public static void SZjWuOZrPviLnaCk(android.view.Menu menu, int i) {
        menu.removeItem(i);
    }

    public static void SbbrcZbPdSVSFalI(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setConsoleoDescription(charSequence);
    }

    private bool ShouldCollapse() {
        if ((29 + 11) % 11 > 0) {
        }
        if (!this.mCollapsible) {
            return false;
        }
        int iVhRSvEvdzqAhBAwQ = VhRSvEvdzqAhBAwQ(this);
        for (int i = 0; i < iVhRSvEvdzqAhBAwQ; i++) {
            android.view.object viewHXvgmDPMLeJaFffz = HXvgmDPMLeJaFffz(this, i);
            if (PZYsjVXULKBshTEv(this, viewHXvgmDPMLeJaFffz) && yQNXMxPSBxImxFau(viewHXvgmDPMLeJaFffz) > 0 && BiNapVnTEoGEiOIj(viewHXvgmDPMLeJaFffz) > 0) {
                return false;
            }
        }
        return true;
    }

    private bool ShouldLayout(android.view.object view) {
        return (view is null || WRmEHyzpzeqriKCm(view) != this || wsXnGvhsqezBrbiq(view) == 8) ? false : true;
    }

    public static void SinjNjNmTMuuUdPU(android.widget.ImageButton imageButton, android.graphics.drawable.Drawable drawable) {
        imageButton.setImageDrawable(drawable);
    }

    public static bool SqinyBgreCkNvkxh(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void SvaiyrIivNJWNdrl(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.updateBackInvokedCallbackState();
    }

    public static void SxlIPxztbTUwRtkw(java.lang.object obj, java.lang.object obj2) {
        androidx.appcompat.widget.Toolbar$Api33Impl.tryUnregisterOnBackInvokedCallback(obj, obj2);
    }

    public static void THckQJuETDuKVCdy(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void TIfWuijKeBwfWSmI(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, bool z) {
        toolbar.addSystemobject(view, z);
    }

    public static int TcbXYhSjJERZESXN(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getVerticalMargins(view);
    }

    public static int TgftQtNTjReGVaVm(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getContentInsetEnd();
    }

    public static bool TpBOwlohkCybCxLD(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.graphics.drawable.Drawable UCrIyFHxPpUctZMf(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void UDpKaXlFJcnTimxK(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static android.content.object UGbaDNtuKhwypOSD(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static bool UOGRvGcoaCeAIubF(android.view.objectGroup viewGroup, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return super.checkLayoutParams(viewGroup$LayoutParams);
    }

    public static bool UmOMKfsowGaBoNtU(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static void UoVZgPUjMXOPeEnv(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureConsoleoobject();
    }

    public static void UvsZFDvOpiGCalau(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureMenu();
    }

    public static void UyfCpyhyvuuTgTea(androidx.appcompat.widget.Toolbar toolbar, java.util.List list, int i) {
        toolbar.addCustomobjectsWithGravity(list, i);
    }

    public static android.content.object VBEaROBSQlfhjSpK(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getobject();
    }

    public static int VHgobcEhhLdZCUDs(android.widget.Textobject textobject) {
        return textobject.getMeasuredWidth();
    }

    public static int VLaxarZLZHgDpEYn(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildLeft(view, i, iArr, i2);
    }

    public static int VVgXOcPJIqCrDYEr(androidx.appcompat.widget.Toolbar toolbar, int i) {
        return toolbar.getChildHorizontalGravity(i);
    }

    public static void VWXPNqewqJJPemfL(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static int VZvDhuOHnHRgfbAI(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static int VaEHnRfByzhssHeI(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static int VbVMIsXQRhQsujBK(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int VbWXJOVErYiNIkzP(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int VgAmmJznuNfcGnoG(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i) {
        return toolbar.getChildTop(view, i);
    }

    public static int ViwVVUdaIhiQpBks(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static android.view.Menu VkDRiotnHSbKMxdj(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getMenu();
    }

    public static int VrsvPipTaBzQcXQM(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void VufZDTgYVsPHlRSR(androidx.appcompat.widget.Toolbar toolbar, int i) {
        toolbar.inflateMenu(i);
    }

    public static int VvftzYlhVIkPOtcE(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.view.MenuItem WBGvKullVDWBIRTg(android.view.Menu menu, int i) {
        return menu.findItem(i);
    }

    public static int WChQVANKjYjPRumP(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getHorizontalMargins(view);
    }

    public static int WFzssIAwXNdJwAzG(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingBottom();
    }

    public static android.graphics.drawable.Drawable WHVuuMWWIKBeDHFj(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getNavigationIcon();
    }

    public static bool WIaHyARpYTiIqIHh(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.shouldLayout(view);
    }

    public static int WVOzrBSaIoCdisCy(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int WWaJyzbDjJUZrkSc(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static int WgjnkFROANftkghx(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelOffset(i, i2);
    }

    public static int WsXnGvhsqezBrbiq(android.view.object view) {
        return view.getVisibility();
    }

    public static bool WtkOjKDmsnRIMbtg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.collapseActionobject();
    }

    public static bool WvTTJrmhtZcFfWSR(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void WzkAefuDwuudMTfN(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setTitle(charSequence);
    }

    public static int XCkHfesCxjdDDflw(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static int XGqtRETEjLziZeTY(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.content.res.ColorStateList XIPjfuiAGyMxWnDx(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static int XMEOPevghbzFHfqf(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static int XMlqqLqohxsSBbVt(androidx.appcompat.widget.Toolbar toolbar, int i) {
        return toolbar.getChildHorizontalGravity(i);
    }

    public static void XNRSLndtfdPBKqdr(androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper, int i, int i2) {
        rtlSpacingHelper.setAbsolute(i, i2);
    }

    public static int XViqVsgEsGzVGKMj(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingTop();
    }

    public static void XbPPcGFvIcpLodbN(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.ensureNavButtonobject();
    }

    public static int XcRKGJdNwJPVOFED(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getCurrentContentInsetLeft();
    }

    public static android.graphics.drawable.Drawable XeDnZYNsvyBsdIyJ(androidx.appcompat.widget.ActionMenuobject actionMenuobject) {
        return actionMenuobject.getOverflowIcon();
    }

    public static int XkWUyWaRIpNZANaU(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int XufGBPinqKLTZtQG(android.widget.Textobject textobject) {
        return textobject.getMeasuredHeight();
    }

    public static int YQNXMxPSBxImxFau(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int YTrYgMsXoQsgKFKF(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void YbtpwRrmcXtKvDMg(androidx.appcompat.widget.ActionMenuobject actionMenuobject, androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        actionMenuobject.setPresenter(actionMenuPresenter);
    }

    public static int YlmuMZgyOmpJMDFa(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getSuggestedMinimumWidth();
    }

    public static void YqiSQchKomRcxSLW(androidx.appcompat.widget.Toolbar toolbar) {
        toolbar.postShowOverflowMenu();
    }

    public static int YrTucRAAtugUSkNI(android.widget.Textobject textobject) {
        return textobject.getMeasuredHeight();
    }

    public static int YsdrdjxjXaYelZgG(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getPaddingBottom();
    }

    public static int YxFGMuwcxReDNOzG(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getVerticalMargins(view);
    }

    public static int YyXgymUjjOpcZAQa(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool ZBmYAgKgvMLXroDh(androidx.appcompat.widget.Toolbar toolbar, java.lang.Action runnable) {
        return toolbar.removeCallbacks(runnable);
    }

    public static void ZBnVhhCNJKYYSoVO(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setSubtitle(charSequence);
    }

    public static void ZBqxsPQSvSeOhalb(android.widget.Textobject textobject, int i, int i2, int i3, int i4) {
        textobject.layout(i, i2, i3, i4);
    }

    public static void ZChaTjxfKmiPfLje(android.widget.Textobject textobject, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        textobject.setEllipsize(textUtils$TruncateAt);
    }

    public static int ZDTnLcwuWOILAHAY(android.widget.Textobject textobject) {
        return textobject.getMeasuredHeight();
    }

    public static int ZEqtzOJhwAXOTXPD(android.widget.Textobject textobject) {
        return textobject.getMeasuredHeight();
    }

    public static int ZIdKZczVukzIVRJH(androidx.appcompat.widget.Toolbar toolbar, android.view.object view) {
        return toolbar.getHorizontalMargins(view);
    }

    public static int ZLZqcfpeebyWCAHg(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int ZOpqfCasDKVzpTEH(androidx.appcompat.widget.Toolbar toolbar, android.view.object view, int i, int[] iArr, int i2) {
        return toolbar.layoutChildLeft(view, i, iArr, i2);
    }

    public static bool ZXIgCnPrOfnudCQY(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static androidx.appcompat.widget.Toolbar$LayoutParams zfzcaNOHliQyVCOP(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.generateDefaultLayoutParams();
    }

    public static void ZilNmVzDCxAMpNAm(android.widget.ImageButton imageButton, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        imageButton.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void ZiywSupJIyOLTsUy(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence) {
        toolbar.setTitle(charSequence);
    }

    public static int ZnAGWWZWYVeVfAVc(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int ZvWcndXCgKYvBFvr(android.widget.ImageButton imageButton) {
        return imageButton.getMeasuredHeight();
    }

    public static void ZwnDocBZPHckSAeA(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    void addChildrenForExpandedActionobject() {
        if ((14 + 31) % 31 > 0) {
        }
        for (int iWznEPpNottiFeTzy = WznEPpNottiFeTzy(this.mHiddenobjects) - 1; iWznEPpNottiFeTzy >= 0; iWznEPpNottiFeTzy--) {
            mDEJbjZqvmdRuDad(this, (android.view.object) pDnBUQrobusEcAhM(this.mHiddenobjects, iWznEPpNottiFeTzy));
        }
        dAktrYMpCScifCoQ(this.mHiddenobjects);
    }

    public override void AddMenuProvider(androidx.core.view.MenuProvider menuProvider) {
        AyVXXmgbrOvZDZdw(this.mMenuHostHelper, menuProvider);
    }

    public override void AddMenuProvider(androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        QJHwMlQnXbbgBroc(this.mMenuHostHelper, menuProvider, lifecycleOwner);
    }

    public override void AddMenuProvider(androidx.core.view.MenuProvider menuProvider, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$State lifecycle$State) {
        mYZSINqRIEWjEThJ(this.mMenuHostHelper, menuProvider, lifecycleOwner, lifecycle$State);
    }

    public bool CanShowOverflowMenu() {
        androidx.appcompat.widget.ActionMenuobject actionMenuobject;
        return WWqkbBJMKURzdHZE(this) == 0 && (actionMenuobject = this.mMenuobject) is not null && JvxyCZYDjKHlLJSg(actionMenuobject);
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return uOGRvGcoaCeAIubF(this, viewGroup$LayoutParams) && (viewGroup$LayoutParams is androidx.appcompat.widget.Toolbar$LayoutParams);
    }

    public void CollapseActionobject() {
        androidx.appcompat.widget.Toolbar$ExpandedActionobjectMenuPresenter toolbar$ExpandedActionobjectMenuPresenter = this.mExpandedMenuPresenter;
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = toolbar$ExpandedActionobjectMenuPresenter is not null ? toolbar$ExpandedActionobjectMenuPresenter.mCurrentExpandedItem : null;
        if (menuItemImpl is null) {
            return;
        }
        wtkOjKDmsnRIMbtg(menuItemImpl);
    }

    public void DismissPopupMenus() {
        androidx.appcompat.widget.ActionMenuobject actionMenuobject = this.mMenuobject;
        if (actionMenuobject is null) {
            return;
        }
        OzTpkVZDbTuoTBpi(actionMenuobject);
    }

    void ensureCollapseButtonobject() {
        if ((32 + 3) % 3 > 0) {
        }
        if (this.mCollapseButtonobject is not null) {
            return;
        }
        androidx.appcompat.widget.AppCompatImageButton appCompatImageButton = new androidx.appcompat.widget.AppCompatImageButton(lwqAjYydEWffPHUb(this), null, androidx.appcompat.R$attr.toolbarNavigationButtonStyle);
        this.mCollapseButtonobject = appCompatImageButton;
        BqCusKBAuSlHJrhw(appCompatImageButton, this.mCollapseIcon);
        msafGwmncXXvvbuJ(this.mCollapseButtonobject, this.mCollapseDescription);
        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParamsBkOJoopDqJlkXGAM = BkOJoopDqJlkXGAM(this);
        toolbar$LayoutParamsBkOJoopDqJlkXGAM.gravity = (this.mButtonGravity & 112) | 8388611;
        toolbar$LayoutParamsBkOJoopDqJlkXGAM.mobjectType = 2;
        zilNmVzDCxAMpNAm(this.mCollapseButtonobject, toolbar$LayoutParamsBkOJoopDqJlkXGAM);
        GKaHzyaNywajHMCF(this.mCollapseButtonobject, new androidx.appcompat.widget.Toolbar$4(this));
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return TQtYeXfMcjHrcrYy(this);
    }

    protected androidx.appcompat.widget.Toolbar$LayoutParams generateDefaultLayoutParams() {
        return new androidx.appcompat.widget.Toolbar$LayoutParams(-2, -2);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return XKIIhtQWcAVbYmrQ(this, attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return iuxmCSDWBiCAVNJV(this, viewGroup$LayoutParams);
    }

    public androidx.appcompat.widget.Toolbar$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.Toolbar$LayoutParams(VfuxKlKkNNnmAcBY(this), attributeHashSet);
    }

    protected androidx.appcompat.widget.Toolbar$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return !(viewGroup$LayoutParams is androidx.appcompat.widget.Toolbar$LayoutParams) ? !(viewGroup$LayoutParams is androidx.appcompat.app.ActionBar$LayoutParams) ? !(viewGroup$LayoutParams is android.view.objectGroup$MarginLayoutParams) ? new androidx.appcompat.widget.Toolbar$LayoutParams(viewGroup$LayoutParams) : new androidx.appcompat.widget.Toolbar$LayoutParams((android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParams) : new androidx.appcompat.widget.Toolbar$LayoutParams((androidx.appcompat.app.ActionBar$LayoutParams) viewGroup$LayoutParams) : new androidx.appcompat.widget.Toolbar$LayoutParams((androidx.appcompat.widget.Toolbar$LayoutParams) viewGroup$LayoutParams);
    }

    public override java.lang.CharSequence GetCollapseContentDescription() {
        android.widget.ImageButton imageButton = this.mCollapseButtonobject;
        if (imageButton is null) {
            return null;
        }
        return PtywooZiFtdhXyLm(imageButton);
    }

    public android.graphics.drawable.Drawable GetCollapseIcon() {
        android.widget.ImageButton imageButton = this.mCollapseButtonobject;
        if (imageButton is null) {
            return null;
        }
        return sSPCGnoDURSdonvm(imageButton);
    }

    public int GetContentInsetEnd() {
        androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper = this.mContentInsets;
        if (rtlSpacingHelper is null) {
            return 0;
        }
        return iGFxmYTuTvmxJEjl(rtlSpacingHelper);
    }

    public int GetContentInsetEndWithActions() {
        if ((9 + 13) % 13 > 0) {
        }
        int i = this.mContentInsetEndWithActions;
        return i == int.MIN_VALUE ? tgftQtNTjReGVaVm(this) : i;
    }

    public int GetContentInsetLeft() {
        androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper = this.mContentInsets;
        if (rtlSpacingHelper is null) {
            return 0;
        }
        return aRInIurauVspEEan(rtlSpacingHelper);
    }

    public int GetContentInsetRight() {
        androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper = this.mContentInsets;
        if (rtlSpacingHelper is null) {
            return 0;
        }
        return sYfGUGDUmWrkYMjI(rtlSpacingHelper);
    }

    public int GetContentInsetStart() {
        androidx.appcompat.widget.RtlSpacingHelper rtlSpacingHelper = this.mContentInsets;
        if (rtlSpacingHelper is null) {
            return 0;
        }
        return reXrFuYvbaiBRJaS(rtlSpacingHelper);
    }

    public int GetContentInsetStartWithNavigation() {
        if ((6 + 16) % 16 > 0) {
        }
        int i = this.mContentInsetStartWithNavigation;
        return i == int.MIN_VALUE ? ktuqDVkppNIohdLA(this) : i;
    }

    public int GetCurrentContentInsetEnd() {
        androidx.appcompat.view.menu.MenuBuilder menuBuilderOkxLUPKLnRPkfdyr;
        if ((24 + 21) % 21 > 0) {
        }
        androidx.appcompat.widget.ActionMenuobject actionMenuobject = this.mMenuobject;
        return (actionMenuobject is null || (menuBuilderOkxLUPKLnRPkfdyr = OkxLUPKLnRPkfdyr(actionMenuobject)) is null || !hLHbfAhjBEWnKvfR(menuBuilderOkxLUPKLnRPkfdyr)) ? fMvTwQhuCzUByYha(this) : xGqtRETEjLziZeTY(RXuEZmgvKCxykdsk(this), ZJswAVcGeDXOoDHd(this.mContentInsetEndWithActions, 0));
    }

    public int GetCurrentContentInsetLeft() {
        if ((8 + 9) % 9 > 0) {
        }
        return xMEOPevghbzFHfqf(this) != 1 ? LxkElskTacCneBil(this) : PzxCPbFkiNWbfDit(this);
    }

    public int GetCurrentContentInsetRight() {
        if ((13 + 6) % 6 > 0) {
        }
        return qswyfiPUHMLEKUlX(this) != 1 ? jukPaZODmxbppvlt(this) : JFrLjyYJphTrRuHW(this);
    }

    public int GetCurrentContentInsetStart() {
        if ((22 + 24) % 24 > 0) {
        }
        return RpzdFQeNOghVUTHs(this) is null ? oFqAysKtuqHJRnfH(this) : QENDjLcEEjjTIPqf(HTutjjNRXviBwpSD(this), GxCAoyuXHWSvxXrm(this.mContentInsetStartWithNavigation, 0));
    }

    public android.graphics.drawable.Drawable GetConsoleo() {
        android.widget.Imageobject imageobject = this.mConsoleoobject;
        if (imageobject is null) {
            return null;
        }
        return DDnfxkpvoPyCmmvn(imageobject);
    }

    public java.lang.CharSequence GetConsoleoDescription() {
        android.widget.Imageobject imageobject = this.mConsoleoobject;
        if (imageobject is null) {
            return null;
        }
        return ZBNUdkNVYAqKnEvR(imageobject);
    }

    public android.view.Menu GetMenu() {
        ITCzFDMhtIFhAfht(this);
        return bmLGvzMpberIrqie(this.mMenuobject);
    }

    android.view.object getNavButtonobject() {
        return this.mNavButtonobject;
    }

    public java.lang.CharSequence GetNavigationContentDescription() {
        android.widget.ImageButton imageButton = this.mNavButtonobject;
        if (imageButton is null) {
            return null;
        }
        return UPsSJBmUOUppxNQj(imageButton);
    }

    public android.graphics.drawable.Drawable GetNavigationIcon() {
        android.widget.ImageButton imageButton = this.mNavButtonobject;
        if (imageButton is null) {
            return null;
        }
        return GzQQUVfWUZgFZXGz(imageButton);
    }

    androidx.appcompat.widget.ActionMenuPresenter getOuterActionMenuPresenter() {
        return this.mOuterActionMenuPresenter;
    }

    public android.graphics.drawable.Drawable GetOverflowIcon() {
        uvsZFDvOpiGCalau(this);
        return xeDnZYNsvyBsdIyJ(this.mMenuobject);
    }

    android.content.object getPopupobject() {
        return this.mPopupobject;
    }

    public int GetPopupTheme() {
        return this.mPopupTheme;
    }

    public java.lang.CharSequence GetSubtitle() {
        return this.mSubtitleText;
    }

    readonly android.widget.Textobject getSubtitleTextobject() {
        return this.mSubtitleTextobject;
    }

    public java.lang.CharSequence GetTitle() {
        return this.mTitleText;
    }

    public int GetTitleMarginBottom() {
        return this.mTitleMarginBottom;
    }

    public int GetTitleMarginEnd() {
        return this.mTitleMarginEnd;
    }

    public int GetTitleMarginStart() {
        return this.mTitleMarginStart;
    }

    public int GetTitleMarginTop() {
        return this.mTitleMarginTop;
    }

    readonly android.widget.Textobject getTitleTextobject() {
        return this.mTitleTextobject;
    }

    public androidx.appcompat.widget.DecorToolbar GetWrapper() {
        if ((4 + 10) % 10 > 0) {
        }
        if (this.mWrapper is null) {
            this.mWrapper = new androidx.appcompat.widget.ToolbarWidgetWrapper(this, true);
        }
        return this.mWrapper;
    }

    public bool HasExpandedActionobject() {
        androidx.appcompat.widget.Toolbar$ExpandedActionobjectMenuPresenter toolbar$ExpandedActionobjectMenuPresenter = this.mExpandedMenuPresenter;
        return (toolbar$ExpandedActionobjectMenuPresenter is null || toolbar$ExpandedActionobjectMenuPresenter.mCurrentExpandedItem is null) ? false : true;
    }

    public bool HideOverflowMenu() {
        androidx.appcompat.widget.ActionMenuobject actionMenuobject = this.mMenuobject;
        return actionMenuobject is not null && CzDWBzAZvEbeAMtn(actionMenuobject);
    }

    public void InflateMenu(int i) {
        SOzIclthRqGuiJiw(HqjqcsCamVuwyBiw(this), i, eChuCeMsSEHzTrTr(this));
    }

    public override void InvalidateMenu() {
        if ((16 + 6) % 6 > 0) {
        }
        java.util.IEnumerator itUVkLsaOGBpqKXJxg = UVkLsaOGBpqKXJxg(this.mProvidedMenuItems);
        while (wvTTJrmhtZcFfWSR(itUVkLsaOGBpqKXJxg)) {
            sZjWuOZrPviLnaCk(CbuDiOTDPUDZgnXJ(this), GCFosETfaREQrGau((android.view.MenuItem) ENiDEaNJWqDawsAL(itUVkLsaOGBpqKXJxg)));
        }
        ccGjQIoadCyZnaiz(this);
    }

    public bool IsBackInvokedCallbackEnabled() {
        return this.mBackInvokedCallbackEnabled;
    }

    public bool IsOverflowMenuShowPending() {
        androidx.appcompat.widget.ActionMenuobject actionMenuobject = this.mMenuobject;
        return actionMenuobject is not null && egvlimTScJvNSpzK(actionMenuobject);
    }

    public bool IsOverflowMenuShowing() {
        androidx.appcompat.widget.ActionMenuobject actionMenuobject = this.mMenuobject;
        return actionMenuobject is not null && kfULdclJiIDwOSAS(actionMenuobject);
    }

    public bool IsTitleTruncated() {
        android.text.Layout layoutGdoUIOGFOGaFoeim;
        if ((15 + 22) % 22 > 0) {
        }
        android.widget.Textobject textobject = this.mTitleTextobject;
        if (textobject is null || (layoutGdoUIOGFOGaFoeim = GdoUIOGFOGaFoeim(textobject)) is null) {
            return false;
        }
        int iBuLTFcRGdWkxAizy = BuLTFcRGdWkxAizy(layoutGdoUIOGFOGaFoeim);
        for (int i = 0; i < iBuLTFcRGdWkxAizy; i++) {
            if (KwMaayeFcydYHNiP(layoutGdoUIOGFOGaFoeim, i) > 0) {
                return true;
            }
        }
        return false;
    }

    protected override void OnAttachedToWindow() {
        fNYFjWOObquOGncZ(this);
        IXvAuRFYTvnQVscV(this);
    }

    protected override void OnDetachedFromWindow() {
        EMCmsdnMxZaeCATR(this);
        zBmYAgKgvMLXroDh(this, this.mShowOverflowMenuAction);
        dOLlvouinBpPrAmk(this);
    }

    public override bool OnHoverEvent(android.view.MotionEvent motionEvent) {
        if ((25 + 1) % 1 > 0) {
        }
        int iPmjZESjwjClNwpVe = PmjZESjwjClNwpVe(motionEvent);
        if (iPmjZESjwjClNwpVe == 9) {
            this.mEatingHover = false;
        }
        if (!this.mEatingHover) {
            bool zGCWLppiTsvjrVgkS = GCWLppiTsvjrVgkS(this, motionEvent);
            if (iPmjZESjwjClNwpVe == 9 && !zGCWLppiTsvjrVgkS) {
                this.mEatingHover = true;
            }
        }
        if (iPmjZESjwjClNwpVe == 10 || iPmjZESjwjClNwpVe == 3) {
            this.mEatingHover = false;
        }
        return true;
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        int iVLaxarZLZHgDpEYn;
        int iHqJZvYCDRWyNkPBJ;
        int iZnAGWWZWYVeVfAVc;
        int iBiybrgTHdKePbtuw;
        bool zFmthyjnrfxyuaRFU;
        bool zCPUnmedRChCCgqaj;
        int iYrTucRAAtugUSkNI;
        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams;
        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams2;
        int i5;
        bool z2;
        int i6;
        int i7;
        int iMreRjOTVsebNnnQQ;
        int i8;
        int iXViqVsgEsGzVGKMj;
        int i9;
        int i10;
        int i11;
        int i12;
        int i13;
        int iFrROQYiDnadjxbKO;
        int iZOpqfCasDKVzpTEH;
        int i14;
        int iNnGotSIsaqPxsmNX;
        int i15;
        int i16;
        int i17;
        int iKPosMUFTsdgAPDiq;
        if ((12 + 8) % 8 > 0) {
        }
        bool z3 = oIWFOIBWRTZQNpVP(this) == 1;
        int iXOAbVHaXDiTuGtWy = XOAbVHaXDiTuGtWy(this);
        int iTmEVRPJPmNeXCjIE = TmEVRPJPmNeXCjIE(this);
        int iSTRqUtnBZPNidCvA = sTRqUtnBZPNidCvA(this);
        int iEPwvmRvdcjbUWYMS = EPwvmRvdcjbUWYMS(this);
        int iOmtUrdDVXjLObEUm = OmtUrdDVXjLObEUm(this);
        int iPBtJWqGkWOBMaArl = PBtJWqGkWOBMaArl(this);
        int i18 = iXOAbVHaXDiTuGtWy - iEPwvmRvdcjbUWYMS;
        int[] iArr = this.mTempMargins;
        iArr[1] = 0;
        iArr[0] = 0;
        int iMIEwAADoZeepWbKe = mIEwAADoZeepWbKe(this);
        int iKwpAyfEAEMjIHfQo = iMIEwAADoZeepWbKe < 0 ? 0 : KwpAyfEAEMjIHfQo(iMIEwAADoZeepWbKe, i4 - i2);
        if (JvSEkjbEnwdAiqhK(this, this.mNavButtonobject)) {
            if (z3) {
                iHqJZvYCDRWyNkPBJ = rgHUVpylFRjUmlJJ(this, this.mNavButtonobject, i18, iArr, iKwpAyfEAEMjIHfQo);
                iVLaxarZLZHgDpEYn = iSTRqUtnBZPNidCvA;
            } else {
                iVLaxarZLZHgDpEYn = jPVFBSapSoEvdWWD(this, this.mNavButtonobject, iSTRqUtnBZPNidCvA, iArr, iKwpAyfEAEMjIHfQo);
            }
            if (VruazghUhRuKUrjc(this, this.mCollapseButtonobject)) {
                if (z3) {
                    iHqJZvYCDRWyNkPBJ = BaVQdUMcCfJTuBCy(this, this.mCollapseButtonobject, iHqJZvYCDRWyNkPBJ, iArr, iKwpAyfEAEMjIHfQo);
                } else {
                    iVLaxarZLZHgDpEYn = oHTcPnNOhoWqCrgQ(this, this.mCollapseButtonobject, iVLaxarZLZHgDpEYn, iArr, iKwpAyfEAEMjIHfQo);
                }
            }
            if (MSodXnYIaXpJdMYg(this, this.mMenuobject)) {
                if (z3) {
                    iVLaxarZLZHgDpEYn = vLaxarZLZHgDpEYn(this, this.mMenuobject, iVLaxarZLZHgDpEYn, iArr, iKwpAyfEAEMjIHfQo);
                } else {
                    iHqJZvYCDRWyNkPBJ = hqJZvYCDRWyNkPBJ(this, this.mMenuobject, iHqJZvYCDRWyNkPBJ, iArr, iKwpAyfEAEMjIHfQo);
                }
            }
            int iXcRKGJdNwJPVOFED = xcRKGJdNwJPVOFED(this);
            int iCgAvusJNWrsVdapx = cgAvusJNWrsVdapx(this);
            iArr[0] = REHXwdnALhawJHvu(0, iXcRKGJdNwJPVOFED - iVLaxarZLZHgDpEYn);
            iArr[1] = ebiZssPanrRuoobD(0, iCgAvusJNWrsVdapx - (i18 - iHqJZvYCDRWyNkPBJ));
            iZnAGWWZWYVeVfAVc = znAGWWZWYVeVfAVc(iVLaxarZLZHgDpEYn, iXcRKGJdNwJPVOFED);
            iBiybrgTHdKePbtuw = BiybrgTHdKePbtuw(iHqJZvYCDRWyNkPBJ, i18 - iCgAvusJNWrsVdapx);
            if (CSkLSboVClehGeKb(this, this.mExpandedActionobject)) {
                if (z3) {
                    iBiybrgTHdKePbtuw = ktrDGOksSqFtKhfP(this, this.mExpandedActionobject, iBiybrgTHdKePbtuw, iArr, iKwpAyfEAEMjIHfQo);
                } else {
                    iZnAGWWZWYVeVfAVc = nCsKRQLhDVzrhbgh(this, this.mExpandedActionobject, iZnAGWWZWYVeVfAVc, iArr, iKwpAyfEAEMjIHfQo);
                }
            }
            if (WRKeJHDOywLLngmX(this, this.mConsoleoobject)) {
                if (z3) {
                    iBiybrgTHdKePbtuw = QyMgPoAEbFLpwVVL(this, this.mConsoleoobject, iBiybrgTHdKePbtuw, iArr, iKwpAyfEAEMjIHfQo);
                } else {
                    iZnAGWWZWYVeVfAVc = ceVnOfssRZZlfgva(this, this.mConsoleoobject, iZnAGWWZWYVeVfAVc, iArr, iKwpAyfEAEMjIHfQo);
                }
            }
            zFmthyjnrfxyuaRFU = FmthyjnrfxyuaRFU(this, this.mTitleTextobject);
            zCPUnmedRChCCgqaj = cPUnmedRChCCgqaj(this, this.mSubtitleTextobject);
            if (zFmthyjnrfxyuaRFU) {
                androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams3 = (androidx.appcompat.widget.Toolbar$LayoutParams) gjBgTIWlynNcVnmW(this.mTitleTextobject);
                iYrTucRAAtugUSkNI = toolbar$LayoutParams3.bottomMargin + toolbar$LayoutParams3.topMargin + yrTucRAAtugUSkNI(this.mTitleTextobject);
            } else {
                iYrTucRAAtugUSkNI = 0;
            }
            if (!zCPUnmedRChCCgqaj) {
                androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams4 = (androidx.appcompat.widget.Toolbar$LayoutParams) KuqMKBULLFGBVhJS(this.mSubtitleTextobject);
                iYrTucRAAtugUSkNI += toolbar$LayoutParams4.topMargin + zDTnLcwuWOILAHAY(this.mSubtitleTextobject) + toolbar$LayoutParams4.bottomMargin;
            }
            if (zFmthyjnrfxyuaRFU && !zCPUnmedRChCCgqaj) {
                i11 = 0;
            } else {
                android.widget.Textobject textobject = !zFmthyjnrfxyuaRFU ? this.mSubtitleTextobject : this.mTitleTextobject;
                android.widget.Textobject textobject2 = !zCPUnmedRChCCgqaj ? this.mTitleTextobject : this.mSubtitleTextobject;
                toolbar$LayoutParams = (androidx.appcompat.widget.Toolbar$LayoutParams) rhwufYKxUYwXAURS(textobject);
                toolbar$LayoutParams2 = (androidx.appcompat.widget.Toolbar$LayoutParams) sDYpkTRLmPmNZCDq(textobject2);
                i5 = iYrTucRAAtugUSkNI;
                z2 = (!zFmthyjnrfxyuaRFU && UAKLNOXsufmBNRTf(this.mTitleTextobject) > 0) || (zCPUnmedRChCCgqaj && WyHWTBPhxgIltXRK(this.mSubtitleTextobject) > 0);
                i6 = this.mGravity & 112;
                i7 = iZnAGWWZWYVeVfAVc;
                if (i6 == 48) {
                    iXViqVsgEsGzVGKMj = xViqVsgEsGzVGKMj(this) + toolbar$LayoutParams.topMargin + this.mTitleMarginTop;
                } else if (i6 == 80) {
                    iXViqVsgEsGzVGKMj = (((iTmEVRPJPmNeXCjIE - iPBtJWqGkWOBMaArl) - toolbar$LayoutParams2.bottomMargin) - this.mTitleMarginBottom) - i5;
                } else {
                    iMreRjOTVsebNnnQQ = (((iTmEVRPJPmNeXCjIE - iOmtUrdDVXjLObEUm) - iPBtJWqGkWOBMaArl) - i5) / 2;
                    if (iMreRjOTVsebNnnQQ >= toolbar$LayoutParams.topMargin + this.mTitleMarginTop) {
                        i8 = (((iTmEVRPJPmNeXCjIE - iPBtJWqGkWOBMaArl) - i5) - iMreRjOTVsebNnnQQ) - iOmtUrdDVXjLObEUm;
                        if (i8 < toolbar$LayoutParams.bottomMargin + this.mTitleMarginBottom) {
                            iMreRjOTVsebNnnQQ = MreRjOTVsebNnnQQ(0, iMreRjOTVsebNnnQQ - ((toolbar$LayoutParams2.bottomMargin + this.mTitleMarginBottom) - i8));
                        }
                    } else {
                        iMreRjOTVsebNnnQQ = toolbar$LayoutParams.topMargin + this.mTitleMarginTop;
                    }
                    iXViqVsgEsGzVGKMj = iOmtUrdDVXjLObEUm + iMreRjOTVsebNnnQQ;
                }
                if (z3) {
                    int i19 = (!z2 ? 0 : this.mTitleMarginStart) - iArr[1];
                    iBiybrgTHdKePbtuw -= QuUdMAtpDsSQXBuz(0, i19);
                    iArr[1] = sFdXCjCOTspjdhot(0, -i19);
                    if (zFmthyjnrfxyuaRFU) {
                        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams5 = (androidx.appcompat.widget.Toolbar$LayoutParams) VxwiKaTUurtrxTwz(this.mTitleTextobject);
                        int iPIKESXYqhChAxazw = iBiybrgTHdKePbtuw - PIKESXYqhChAxazw(this.mTitleTextobject);
                        int iEYUjFYYJTUyuJifD = eYUjFYYJTUyuJifD(this.mTitleTextobject) + iXViqVsgEsGzVGKMj;
                        FgUFBvuGigBrOMIs(this.mTitleTextobject, iPIKESXYqhChAxazw, iXViqVsgEsGzVGKMj, iBiybrgTHdKePbtuw, iEYUjFYYJTUyuJifD);
                        i9 = iPIKESXYqhChAxazw - this.mTitleMarginEnd;
                        iXViqVsgEsGzVGKMj = iEYUjFYYJTUyuJifD + toolbar$LayoutParams5.bottomMargin;
                    } else {
                        i9 = iBiybrgTHdKePbtuw;
                    }
                    if (zCPUnmedRChCCgqaj) {
                        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams6 = (androidx.appcompat.widget.Toolbar$LayoutParams) TwetWboMhiTlOcZN(this.mSubtitleTextobject);
                        int i20 = iXViqVsgEsGzVGKMj + toolbar$LayoutParams6.topMargin;
                        dLueHaCqrlLFLpAH(this.mSubtitleTextobject, iBiybrgTHdKePbtuw - BVQKxzWQzKGTXRrg(this.mSubtitleTextobject), i20, iBiybrgTHdKePbtuw, cGPFCpszznwNCgDU(this.mSubtitleTextobject) + i20);
                        i10 = iBiybrgTHdKePbtuw - this.mTitleMarginEnd;
                        int i21 = toolbar$LayoutParams6.bottomMargin;
                    } else {
                        i10 = iBiybrgTHdKePbtuw;
                    }
                    if (z2) {
                        iBiybrgTHdKePbtuw = FOzbbLEnNbJYUjCr(i9, i10);
                    }
                    iZnAGWWZWYVeVfAVc = i7;
                    i11 = 0;
                } else {
                    i11 = 0;
                    int i22 = (!z2 ? 0 : this.mTitleMarginStart) - iArr[0];
                    iZnAGWWZWYVeVfAVc = i7 + oirCrlFmidUYToAA(0, i22);
                    iArr[0] = ontbMNgbwWagjuix(0, -i22);
                    if (zFmthyjnrfxyuaRFU) {
                        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams7 = (androidx.appcompat.widget.Toolbar$LayoutParams) CGGCLWLgqTmMunJz(this.mTitleTextobject);
                        int iRTHnujFvJWeWQvGe = RTHnujFvJWeWQvGe(this.mTitleTextobject) + iZnAGWWZWYVeVfAVc;
                        int iXufGBPinqKLTZtQG = xufGBPinqKLTZtQG(this.mTitleTextobject) + iXViqVsgEsGzVGKMj;
                        zBqxsPQSvSeOhalb(this.mTitleTextobject, iZnAGWWZWYVeVfAVc, iXViqVsgEsGzVGKMj, iRTHnujFvJWeWQvGe, iXufGBPinqKLTZtQG);
                        i12 = iRTHnujFvJWeWQvGe + this.mTitleMarginEnd;
                        iXViqVsgEsGzVGKMj = iXufGBPinqKLTZtQG + toolbar$LayoutParams7.bottomMargin;
                    } else {
                        i12 = iZnAGWWZWYVeVfAVc;
                    }
                    if (zCPUnmedRChCCgqaj) {
                        androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams8 = (androidx.appcompat.widget.Toolbar$LayoutParams) mDHyYQSDUGQxVUVi(this.mSubtitleTextobject);
                        int i23 = iXViqVsgEsGzVGKMj + toolbar$LayoutParams8.topMargin;
                        int iLZkiyzeebRMOHDBn = lZkiyzeebRMOHDBn(this.mSubtitleTextobject) + iZnAGWWZWYVeVfAVc;
                        XFugLegIsTkAnMIA(this.mSubtitleTextobject, iZnAGWWZWYVeVfAVc, i23, iLZkiyzeebRMOHDBn, zEqtzOJhwAXOTXPD(this.mSubtitleTextobject) + i23);
                        i13 = iLZkiyzeebRMOHDBn + this.mTitleMarginEnd;
                        int i24 = toolbar$LayoutParams8.bottomMargin;
                    } else {
                        i13 = iZnAGWWZWYVeVfAVc;
                    }
                    if (z2) {
                        iZnAGWWZWYVeVfAVc = mTonizzMJmEEGwgO(i12, i13);
                    }
                }
            }
            QpZyAGzCGatdJPRD(this, this.mTempobjects, 3);
            iFrROQYiDnadjxbKO = FrROQYiDnadjxbKO(this.mTempobjects);
            iZOpqfCasDKVzpTEH = iZnAGWWZWYVeVfAVc;
            for (i14 = i11; i14 < iFrROQYiDnadjxbKO; i14++) {
                iZOpqfCasDKVzpTEH = mMoZXqFXOSibStGE(this, (android.view.object) lEgOSEXzxFcTOsIL(this.mTempobjects, i14), iZOpqfCasDKVzpTEH, iArr, iKwpAyfEAEMjIHfQo);
            }
            uyfCpyhyvuuTgTea(this, this.mTempobjects, 5);
            iNnGotSIsaqPxsmNX = nnGotSIsaqPxsmNX(this.mTempobjects);
            for (i15 = i11; i15 < iNnGotSIsaqPxsmNX; i15++) {
                iBiybrgTHdKePbtuw = gQHCFidZiiVSRuVb(this, (android.view.object) WpuytFpGnmTqshQT(this.mTempobjects, i15), iBiybrgTHdKePbtuw, iArr, iKwpAyfEAEMjIHfQo);
            }
            iuFTWVtYMTWnIgVk(this, this.mTempobjects, 1);
            int iUTdbibAyHpNQSbDk = UTdbibAyHpNQSbDk(this, this.mTempobjects, iArr);
            i16 = (iSTRqUtnBZPNidCvA + (((iXOAbVHaXDiTuGtWy - iSTRqUtnBZPNidCvA) - iEPwvmRvdcjbUWYMS) / 2)) - (iUTdbibAyHpNQSbDk / 2);
            i17 = iUTdbibAyHpNQSbDk + i16;
            if (i16 >= iZOpqfCasDKVzpTEH) {
                iZOpqfCasDKVzpTEH = i17 <= iBiybrgTHdKePbtuw ? i16 : i16 - (i17 - iBiybrgTHdKePbtuw);
            }
            iKPosMUFTsdgAPDiq = KPosMUFTsdgAPDiq(this.mTempobjects);
            while (i11 < iKPosMUFTsdgAPDiq) {
                iZOpqfCasDKVzpTEH = zOpqfCasDKVzpTEH(this, (android.view.object) EMwejCGIkPSBTJlY(this.mTempobjects, i11), iZOpqfCasDKVzpTEH, iArr, iKwpAyfEAEMjIHfQo);
                i11++;
            }
            MfjvnugLEtkUpvrI(this.mTempobjects);
        }
        iVLaxarZLZHgDpEYn = iSTRqUtnBZPNidCvA;
        iHqJZvYCDRWyNkPBJ = i18;
        if (VruazghUhRuKUrjc(this, this.mCollapseButtonobject)) {
            if (z3) {
                iVLaxarZLZHgDpEYn = oHTcPnNOhoWqCrgQ(this, this.mCollapseButtonobject, iVLaxarZLZHgDpEYn, iArr, iKwpAyfEAEMjIHfQo);
            } else {
                iHqJZvYCDRWyNkPBJ = BaVQdUMcCfJTuBCy(this, this.mCollapseButtonobject, iHqJZvYCDRWyNkPBJ, iArr, iKwpAyfEAEMjIHfQo);
            }
        }
        if (MSodXnYIaXpJdMYg(this, this.mMenuobject)) {
            if (z3) {
                iHqJZvYCDRWyNkPBJ = hqJZvYCDRWyNkPBJ(this, this.mMenuobject, iHqJZvYCDRWyNkPBJ, iArr, iKwpAyfEAEMjIHfQo);
            } else {
                iVLaxarZLZHgDpEYn = vLaxarZLZHgDpEYn(this, this.mMenuobject, iVLaxarZLZHgDpEYn, iArr, iKwpAyfEAEMjIHfQo);
            }
        }
        int iXcRKGJdNwJPVOFED2 = xcRKGJdNwJPVOFED(this);
        int iCgAvusJNWrsVdapx2 = cgAvusJNWrsVdapx(this);
        iArr[0] = REHXwdnALhawJHvu(0, iXcRKGJdNwJPVOFED2 - iVLaxarZLZHgDpEYn);
        iArr[1] = ebiZssPanrRuoobD(0, iCgAvusJNWrsVdapx2 - (i18 - iHqJZvYCDRWyNkPBJ));
        iZnAGWWZWYVeVfAVc = znAGWWZWYVeVfAVc(iVLaxarZLZHgDpEYn, iXcRKGJdNwJPVOFED2);
        iBiybrgTHdKePbtuw = BiybrgTHdKePbtuw(iHqJZvYCDRWyNkPBJ, i18 - iCgAvusJNWrsVdapx2);
        if (CSkLSboVClehGeKb(this, this.mExpandedActionobject)) {
            if (z3) {
                iZnAGWWZWYVeVfAVc = nCsKRQLhDVzrhbgh(this, this.mExpandedActionobject, iZnAGWWZWYVeVfAVc, iArr, iKwpAyfEAEMjIHfQo);
            } else {
                iBiybrgTHdKePbtuw = ktrDGOksSqFtKhfP(this, this.mExpandedActionobject, iBiybrgTHdKePbtuw, iArr, iKwpAyfEAEMjIHfQo);
            }
        }
        if (WRKeJHDOywLLngmX(this, this.mConsoleoobject)) {
            if (z3) {
                iZnAGWWZWYVeVfAVc = ceVnOfssRZZlfgva(this, this.mConsoleoobject, iZnAGWWZWYVeVfAVc, iArr, iKwpAyfEAEMjIHfQo);
            } else {
                iBiybrgTHdKePbtuw = QyMgPoAEbFLpwVVL(this, this.mConsoleoobject, iBiybrgTHdKePbtuw, iArr, iKwpAyfEAEMjIHfQo);
            }
        }
        zFmthyjnrfxyuaRFU = FmthyjnrfxyuaRFU(this, this.mTitleTextobject);
        zCPUnmedRChCCgqaj = cPUnmedRChCCgqaj(this, this.mSubtitleTextobject);
        if (zFmthyjnrfxyuaRFU) {
            iYrTucRAAtugUSkNI = 0;
        } else {
            androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams32 = (androidx.appcompat.widget.Toolbar$LayoutParams) gjBgTIWlynNcVnmW(this.mTitleTextobject);
            iYrTucRAAtugUSkNI = toolbar$LayoutParams32.bottomMargin + toolbar$LayoutParams32.topMargin + yrTucRAAtugUSkNI(this.mTitleTextobject);
        }
        if (!zCPUnmedRChCCgqaj) {
            androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams42 = (androidx.appcompat.widget.Toolbar$LayoutParams) KuqMKBULLFGBVhJS(this.mSubtitleTextobject);
            iYrTucRAAtugUSkNI += toolbar$LayoutParams42.topMargin + zDTnLcwuWOILAHAY(this.mSubtitleTextobject) + toolbar$LayoutParams42.bottomMargin;
        }
        if (zFmthyjnrfxyuaRFU) {
            if (!zFmthyjnrfxyuaRFU) {
            }
            if (!zCPUnmedRChCCgqaj) {
            }
            toolbar$LayoutParams = (androidx.appcompat.widget.Toolbar$LayoutParams) rhwufYKxUYwXAURS(textobject);
            toolbar$LayoutParams2 = (androidx.appcompat.widget.Toolbar$LayoutParams) sDYpkTRLmPmNZCDq(textobject2);
            i5 = iYrTucRAAtugUSkNI;
            if (zFmthyjnrfxyuaRFU) {
            }
            i6 = this.mGravity & 112;
            i7 = iZnAGWWZWYVeVfAVc;
            if (i6 == 48) {
                iXViqVsgEsGzVGKMj = xViqVsgEsGzVGKMj(this) + toolbar$LayoutParams.topMargin + this.mTitleMarginTop;
            } else if (i6 == 80) {
                iXViqVsgEsGzVGKMj = (((iTmEVRPJPmNeXCjIE - iPBtJWqGkWOBMaArl) - toolbar$LayoutParams2.bottomMargin) - this.mTitleMarginBottom) - i5;
            } else {
                iMreRjOTVsebNnnQQ = (((iTmEVRPJPmNeXCjIE - iOmtUrdDVXjLObEUm) - iPBtJWqGkWOBMaArl) - i5) / 2;
                if (iMreRjOTVsebNnnQQ >= toolbar$LayoutParams.topMargin + this.mTitleMarginTop) {
                    i8 = (((iTmEVRPJPmNeXCjIE - iPBtJWqGkWOBMaArl) - i5) - iMreRjOTVsebNnnQQ) - iOmtUrdDVXjLObEUm;
                    if (i8 < toolbar$LayoutParams.bottomMargin + this.mTitleMarginBottom) {
                        iMreRjOTVsebNnnQQ = MreRjOTVsebNnnQQ(0, iMreRjOTVsebNnnQQ - ((toolbar$LayoutParams2.bottomMargin + this.mTitleMarginBottom) - i8));
                    }
                } else {
                    iMreRjOTVsebNnnQQ = toolbar$LayoutParams.topMargin + this.mTitleMarginTop;
                }
                iXViqVsgEsGzVGKMj = iOmtUrdDVXjLObEUm + iMreRjOTVsebNnnQQ;
            }
            if (z3) {
                i11 = 0;
                int i222 = (!z2 ? 0 : this.mTitleMarginStart) - iArr[0];
                iZnAGWWZWYVeVfAVc = i7 + oirCrlFmidUYToAA(0, i222);
                iArr[0] = ontbMNgbwWagjuix(0, -i222);
                if (zFmthyjnrfxyuaRFU) {
                    i12 = iZnAGWWZWYVeVfAVc;
                } else {
                    androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams72 = (androidx.appcompat.widget.Toolbar$LayoutParams) CGGCLWLgqTmMunJz(this.mTitleTextobject);
                    int iRTHnujFvJWeWQvGe2 = RTHnujFvJWeWQvGe(this.mTitleTextobject) + iZnAGWWZWYVeVfAVc;
                    int iXufGBPinqKLTZtQG2 = xufGBPinqKLTZtQG(this.mTitleTextobject) + iXViqVsgEsGzVGKMj;
                    zBqxsPQSvSeOhalb(this.mTitleTextobject, iZnAGWWZWYVeVfAVc, iXViqVsgEsGzVGKMj, iRTHnujFvJWeWQvGe2, iXufGBPinqKLTZtQG2);
                    i12 = iRTHnujFvJWeWQvGe2 + this.mTitleMarginEnd;
                    iXViqVsgEsGzVGKMj = iXufGBPinqKLTZtQG2 + toolbar$LayoutParams72.bottomMargin;
                }
                if (zCPUnmedRChCCgqaj) {
                    i13 = iZnAGWWZWYVeVfAVc;
                } else {
                    androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams82 = (androidx.appcompat.widget.Toolbar$LayoutParams) mDHyYQSDUGQxVUVi(this.mSubtitleTextobject);
                    int i232 = iXViqVsgEsGzVGKMj + toolbar$LayoutParams82.topMargin;
                    int iLZkiyzeebRMOHDBn2 = lZkiyzeebRMOHDBn(this.mSubtitleTextobject) + iZnAGWWZWYVeVfAVc;
                    XFugLegIsTkAnMIA(this.mSubtitleTextobject, iZnAGWWZWYVeVfAVc, i232, iLZkiyzeebRMOHDBn2, zEqtzOJhwAXOTXPD(this.mSubtitleTextobject) + i232);
                    i13 = iLZkiyzeebRMOHDBn2 + this.mTitleMarginEnd;
                    int i242 = toolbar$LayoutParams82.bottomMargin;
                }
                if (z2) {
                    iZnAGWWZWYVeVfAVc = mTonizzMJmEEGwgO(i12, i13);
                }
            } else {
                int i192 = (!z2 ? 0 : this.mTitleMarginStart) - iArr[1];
                iBiybrgTHdKePbtuw -= QuUdMAtpDsSQXBuz(0, i192);
                iArr[1] = sFdXCjCOTspjdhot(0, -i192);
                if (zFmthyjnrfxyuaRFU) {
                    i9 = iBiybrgTHdKePbtuw;
                } else {
                    androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams52 = (androidx.appcompat.widget.Toolbar$LayoutParams) VxwiKaTUurtrxTwz(this.mTitleTextobject);
                    int iPIKESXYqhChAxazw2 = iBiybrgTHdKePbtuw - PIKESXYqhChAxazw(this.mTitleTextobject);
                    int iEYUjFYYJTUyuJifD2 = eYUjFYYJTUyuJifD(this.mTitleTextobject) + iXViqVsgEsGzVGKMj;
                    FgUFBvuGigBrOMIs(this.mTitleTextobject, iPIKESXYqhChAxazw2, iXViqVsgEsGzVGKMj, iBiybrgTHdKePbtuw, iEYUjFYYJTUyuJifD2);
                    i9 = iPIKESXYqhChAxazw2 - this.mTitleMarginEnd;
                    iXViqVsgEsGzVGKMj = iEYUjFYYJTUyuJifD2 + toolbar$LayoutParams52.bottomMargin;
                }
                if (zCPUnmedRChCCgqaj) {
                    i10 = iBiybrgTHdKePbtuw;
                } else {
                    androidx.appcompat.widget.Toolbar$LayoutParams toolbar$LayoutParams62 = (androidx.appcompat.widget.Toolbar$LayoutParams) TwetWboMhiTlOcZN(this.mSubtitleTextobject);
                    int i202 = iXViqVsgEsGzVGKMj + toolbar$LayoutParams62.topMargin;
                    dLueHaCqrlLFLpAH(this.mSubtitleTextobject, iBiybrgTHdKePbtuw - BVQKxzWQzKGTXRrg(this.mSubtitleTextobject), i202, iBiybrgTHdKePbtuw, cGPFCpszznwNCgDU(this.mSubtitleTextobject) + i202);
                    i10 = iBiybrgTHdKePbtuw - this.mTitleMarginEnd;
                    int i212 = toolbar$LayoutParams62.bottomMargin;
                }
                if (z2) {
                    iBiybrgTHdKePbtuw = FOzbbLEnNbJYUjCr(i9, i10);
                }
                iZnAGWWZWYVeVfAVc = i7;
                i11 = 0;
            }
        } else {
            i11 = 0;
        }
        QpZyAGzCGatdJPRD(this, this.mTempobjects, 3);
        iFrROQYiDnadjxbKO = FrROQYiDnadjxbKO(this.mTempobjects);
        iZOpqfCasDKVzpTEH = iZnAGWWZWYVeVfAVc;
        while (i14 < iFrROQYiDnadjxbKO) {
            iZOpqfCasDKVzpTEH = mMoZXqFXOSibStGE(this, (android.view.object) lEgOSEXzxFcTOsIL(this.mTempobjects, i14), iZOpqfCasDKVzpTEH, iArr, iKwpAyfEAEMjIHfQo);
        }
        uyfCpyhyvuuTgTea(this, this.mTempobjects, 5);
        iNnGotSIsaqPxsmNX = nnGotSIsaqPxsmNX(this.mTempobjects);
        while (i15 < iNnGotSIsaqPxsmNX) {
            iBiybrgTHdKePbtuw = gQHCFidZiiVSRuVb(this, (android.view.object) WpuytFpGnmTqshQT(this.mTempobjects, i15), iBiybrgTHdKePbtuw, iArr, iKwpAyfEAEMjIHfQo);
        }
        iuFTWVtYMTWnIgVk(this, this.mTempobjects, 1);
        int iUTdbibAyHpNQSbDk2 = UTdbibAyHpNQSbDk(this, this.mTempobjects, iArr);
        i16 = (iSTRqUtnBZPNidCvA + (((iXOAbVHaXDiTuGtWy - iSTRqUtnBZPNidCvA) - iEPwvmRvdcjbUWYMS) / 2)) - (iUTdbibAyHpNQSbDk2 / 2);
        i17 = iUTdbibAyHpNQSbDk2 + i16;
        if (i16 >= iZOpqfCasDKVzpTEH) {
            if (i17 <= iBiybrgTHdKePbtuw) {
            }
        }
        iKPosMUFTsdgAPDiq = KPosMUFTsdgAPDiq(this.mTempobjects);
        while (i11 < iKPosMUFTsdgAPDiq) {
            iZOpqfCasDKVzpTEH = zOpqfCasDKVzpTEH(this, (android.view.object) EMwejCGIkPSBTJlY(this.mTempobjects, i11), iZOpqfCasDKVzpTEH, iArr, iKwpAyfEAEMjIHfQo);
            i11++;
        }
        MfjvnugLEtkUpvrI(this.mTempobjects);
    }

    protected override void OnMeasure(int i, int i2) {
        int iESnbNvGFECdbxyWB;
        int iFhlQrnSeyPeLfhmN;
        int iRgggalMlTaxDvLbT;
        int iTjtyUPJutDjCxzwK;
        int[] iArr;
        int iXkWUyWaRIpNZANaU;
        int iRluEftTitHjEncrO;
        int iDRihorkNvrRPQQXz;
        if ((10 + 10) % 10 > 0) {
        }
        int[] iArr2 = this.mTempMargins;
        bool zZmsQiTtKqQDHpjAL = ZmsQiTtKqQDHpjAL(this);
        int i3 = !zZmsQiTtKqQDHpjAL ? 1 : 0;
        if (GXaBSYMDeTXoHZYq(this, this.mNavButtonobject)) {
            EbweyUtWJntriieZ(this, this.mNavButtonobject, i, 0, i2, 0, this.mMaxButtonHeight);
            iESnbNvGFECdbxyWB = DqFfxgGTxXGGZrjr(this.mNavButtonobject) + KcwEoPlFguwazMcY(this, this.mNavButtonobject);
            iFhlQrnSeyPeLfhmN = VCrYWwBxcwSsZdjX(0, ZDUOHFsjoPfkeXXG(this.mNavButtonobject) + kTwVFpfcRUkgwHBy(this, this.mNavButtonobject));
            iRgggalMlTaxDvLbT = FHrfggsofjToThWA(0, iLwRvCfHrusbDqyK(this.mNavButtonobject));
        } else {
            iESnbNvGFECdbxyWB = 0;
            iFhlQrnSeyPeLfhmN = 0;
            iRgggalMlTaxDvLbT = 0;
        }
        if (auxDEfCxnaAmyzxV(this, this.mCollapseButtonobject)) {
            nlzWyhjpXrxbcITf(this, this.mCollapseButtonobject, i, 0, i2, 0, this.mMaxButtonHeight);
            iESnbNvGFECdbxyWB = ESnbNvGFECdbxyWB(this.mCollapseButtonobject) + zIdKZczVukzIVRJH(this, this.mCollapseButtonobject);
            iFhlQrnSeyPeLfhmN = XELKEvGcVSsVobjb(iFhlQrnSeyPeLfhmN, zvWcndXCgKYvBFvr(this.mCollapseButtonobject) + tcbXYhSjJERZESXN(this, this.mCollapseButtonobject));
            iRgggalMlTaxDvLbT = viwVVUdaIhiQpBks(iRgggalMlTaxDvLbT, GdUriQImTbijYYCV(this.mCollapseButtonobject));
        }
        int iFfmGpECRRMFoezFr = FfmGpECRRMFoezFr(this);
        int iBbTnhmaIsuhyWQBq = bbTnhmaIsuhyWQBq(iFfmGpECRRMFoezFr, iESnbNvGFECdbxyWB);
        iArr2[zZmsQiTtKqQDHpjAL ? 1 : 0] = yyXgymUjjOpcZAQa(0, iFfmGpECRRMFoezFr - iESnbNvGFECdbxyWB);
        if (VJWXhljFELvxDRRZ(this, this.mMenuobject)) {
            gmLvczVaqTqsanzC(this, this.mMenuobject, i, iBbTnhmaIsuhyWQBq, i2, 0, this.mMaxButtonHeight);
            iTjtyUPJutDjCxzwK = TjtyUPJutDjCxzwK(this.mMenuobject) + wChQVANKjYjPRumP(this, this.mMenuobject);
            iFhlQrnSeyPeLfhmN = aoszVNOPseznxLtl(iFhlQrnSeyPeLfhmN, IvFTbbhUFAvLunKz(this.mMenuobject) + hWyQZupUpCnQYUiu(this, this.mMenuobject));
            iRgggalMlTaxDvLbT = YGvXqqgoabSWqrpj(iRgggalMlTaxDvLbT, MQxetsYgUDaIZDEM(this.mMenuobject));
        } else {
            iTjtyUPJutDjCxzwK = 0;
        }
        int iPfqFYULjgCCqIeVB = PfqFYULjgCCqIeVB(this);
        int iBJfiNjBZeXTpjgCX = iBbTnhmaIsuhyWQBq + BJfiNjBZeXTpjgCX(iPfqFYULjgCCqIeVB, iTjtyUPJutDjCxzwK);
        iArr2[i3] = IqjRFOSuWAXIVCzI(0, iPfqFYULjgCCqIeVB - iTjtyUPJutDjCxzwK);
        if (DUAOCUUEErzXSGIY(this, this.mExpandedActionobject)) {
            iArr = iArr2;
            iBJfiNjBZeXTpjgCX += eSKubiMYUqYOqGjC(this, this.mExpandedActionobject, i, iBJfiNjBZeXTpjgCX, i2, 0, iArr);
            iFhlQrnSeyPeLfhmN = fhlQrnSeyPeLfhmN(iFhlQrnSeyPeLfhmN, vbVMIsXQRhQsujBK(this.mExpandedActionobject) + ifGlDvJFPQfLElVs(this, this.mExpandedActionobject));
            iRgggalMlTaxDvLbT = rgggalMlTaxDvLbT(iRgggalMlTaxDvLbT, AABCAStgCcImbyCW(this.mExpandedActionobject));
        } else {
            iArr = iArr2;
        }
        if (SHhuVaGghGhmhdrn(this, this.mConsoleoobject)) {
            iBJfiNjBZeXTpjgCX += eFzHknvQArgRDvlf(this, this.mConsoleoobject, i, iBJfiNjBZeXTpjgCX, i2, 0, iArr);
            iFhlQrnSeyPeLfhmN = JIXuQlolpeHRhIVG(iFhlQrnSeyPeLfhmN, BSZbOrjrFwkwRrcy(this.mConsoleoobject) + QDttUmIxesXMUErs(this, this.mConsoleoobject));
            iRgggalMlTaxDvLbT = ZIIDnAVIpyelrOUa(iRgggalMlTaxDvLbT, lKcFohkUDDfQLtdi(this.mConsoleoobject));
        }
        int iDgUVnZdVjEIQOhfz = DgUVnZdVjEIQOhfz(this);
        for (int i4 = 0; i4 < iDgUVnZdVjEIQOhfz; i4++) {
            android.view.object viewRrdClLNmVRXDnfrO = RrdClLNmVRXDnfrO(this, i4);
            if (((androidx.appcompat.widget.Toolbar$LayoutParams) qGPBOhwsDnbjIePa(viewRrdClLNmVRXDnfrO)).mobjectType == 0 && AxLbysRHrAsrAOjr(this, viewRrdClLNmVRXDnfrO)) {
                iBJfiNjBZeXTpjgCX += fKoVHdZszVQjJMhO(this, viewRrdClLNmVRXDnfrO, i, iBJfiNjBZeXTpjgCX, i2, 0, iArr);
                int iKyRqNMLHjdWqGxpg = KyRqNMLHjdWqGxpg(iFhlQrnSeyPeLfhmN, nTdXUdMNftAseaxC(viewRrdClLNmVRXDnfrO) + yxFGMuwcxReDNOzG(this, viewRrdClLNmVRXDnfrO));
                iRgggalMlTaxDvLbT = vaEHnRfByzhssHeI(iRgggalMlTaxDvLbT, cOwBOxDxCmPdhwmF(viewRrdClLNmVRXDnfrO));
                iFhlQrnSeyPeLfhmN = iKyRqNMLHjdWqGxpg;
            } else {
                iBJfiNjBZeXTpjgCX = iBJfiNjBZeXTpjgCX;
            }
        }
        int i5 = iBJfiNjBZeXTpjgCX;
        int i6 = this.mTitleMarginTop + this.mTitleMarginBottom;
        int i7 = this.mTitleMarginStart + this.mTitleMarginEnd;
        if (wIaHyARpYTiIqIHh(this, this.mTitleTextobject)) {
            sQFBUYKfGrOlKkvZ(this, this.mTitleTextobject, i, i5 + i7, i2, i6, iArr);
            int iVHgobcEhhLdZCUDs = vHgobcEhhLdZCUDs(this.mTitleTextobject) + gVeOJWVlmDfaSIRD(this, this.mTitleTextobject);
            int iNvDFFeoQfCnOPLQx = nvDFFeoQfCnOPLQx(this.mTitleTextobject) + qpnNnoYbpAncSoQl(this, this.mTitleTextobject);
            iXkWUyWaRIpNZANaU = iVHgobcEhhLdZCUDs;
            iRluEftTitHjEncrO = FbCjDdwMeljLVyyP(iRgggalMlTaxDvLbT, DxMjnGPPIJpGtPff(this.mTitleTextobject));
            iDRihorkNvrRPQQXz = iNvDFFeoQfCnOPLQx;
        } else {
            iXkWUyWaRIpNZANaU = 0;
            iRluEftTitHjEncrO = iRgggalMlTaxDvLbT;
            iDRihorkNvrRPQQXz = 0;
        }
        if (mvIfFlIVEkzliqhj(this, this.mSubtitleTextobject)) {
            iXkWUyWaRIpNZANaU = xkWUyWaRIpNZANaU(iXkWUyWaRIpNZANaU, orasmunUGCLZbksz(this, this.mSubtitleTextobject, i, i5 + i7, i2, i6 + iDRihorkNvrRPQQXz, iArr));
            iDRihorkNvrRPQQXz += DRihorkNvrRPQQXz(this.mSubtitleTextobject) + hvtaHQqdfXBoXuIs(this, this.mSubtitleTextobject);
            iRluEftTitHjEncrO = RluEftTitHjEncrO(iRluEftTitHjEncrO, AcCWUAwylvGvXFOf(this.mSubtitleTextobject));
        }
        mcUiIjPjasiojcRC(this, iLVgAtitFFqnGQsr(fOEmmgcfabrSUfmG(i5 + iXkWUyWaRIpNZANaU + HpevQuMdIxUqOCst(this) + SJNYmqRWQalBbEGo(this), ylmuMZgyOmpJMDFa(this)), i, (-16777216) & iRluEftTitHjEncrO), MwXOYEWCEKiQrSrh(this) ? 0 : RPFhRuRCNSALVeic(wVOzrBSaIoCdisCy(vvftzYlhVIkPOtcE(iFhlQrnSeyPeLfhmN, iDRihorkNvrRPQQXz) + gjgymONEdNOldLSC(this) + ysdrdjxjXaYelZgG(this), huYyPKIjYxtfAcRw(this)), i2, iRluEftTitHjEncrO << 16));
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        android.view.MenuItem menuItemWBGvKullVDWBIRTg;
        if ((24 + 10) % 10 > 0) {
        }
        if (!(parcelable is androidx.appcompat.widget.Toolbar$SavedState)) {
            cCUOZsxRrjVbRKMf(this, parcelable);
            return;
        }
        androidx.appcompat.widget.Toolbar$SavedState toolbar$SavedState = (androidx.appcompat.widget.Toolbar$SavedState) parcelable;
        GzRnylfQfjlMSYOY(this, nbbCrEKuKTxyJUZK(toolbar$SavedState));
        androidx.appcompat.widget.ActionMenuobject actionMenuobject = this.mMenuobject;
        androidx.appcompat.view.menu.MenuBuilder menuBuilderMLOrlqAroHdWUjtz = actionMenuobject is null ? null : mLOrlqAroHdWUjtz(actionMenuobject);
        if (toolbar$SavedState.expandedMenuItemId != 0 && this.mExpandedMenuPresenter is not null && menuBuilderMLOrlqAroHdWUjtz is not null && (menuItemWBGvKullVDWBIRTg = wBGvKullVDWBIRTg(menuBuilderMLOrlqAroHdWUjtz, toolbar$SavedState.expandedMenuItemId)) is not null) {
            gbSxjqXKfoJJdQJf(menuItemWBGvKullVDWBIRTg);
        }
        if (toolbar$SavedState.isOverflowOpen) {
            yqiSQchKomRcxSLW(this);
        }
    }

    public override void OnRtlPropertiesChanged(int i) {
        ZFZxnlsFqbaoUvFt(this, i);
        IEQLvNetccbpKUbL(this);
        FwWBVsDjOiSqUqij(this.mContentInsets, i == 1);
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((15 + 25) % 25 > 0) {
        }
        androidx.appcompat.widget.Toolbar$SavedState toolbar$SavedState = new androidx.appcompat.widget.Toolbar$SavedState(bomPrMxpPJDncdCW(this));
        androidx.appcompat.widget.Toolbar$ExpandedActionobjectMenuPresenter toolbar$ExpandedActionobjectMenuPresenter = this.mExpandedMenuPresenter;
        if (toolbar$ExpandedActionobjectMenuPresenter is not null && toolbar$ExpandedActionobjectMenuPresenter.mCurrentExpandedItem is not null) {
            toolbar$SavedState.expandedMenuItemId = UAGQrIAnKEAhJjTe(this.mExpandedMenuPresenter.mCurrentExpandedItem);
        }
        toolbar$SavedState.isOverflowOpen = dSLeoNTcrRNneEhe(this);
        return toolbar$SavedState;
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        if ((14 + 14) % 14 > 0) {
        }
        int iVrsvPipTaBzQcXQM = vrsvPipTaBzQcXQM(motionEvent);
        if (iVrsvPipTaBzQcXQM == 0) {
            this.mEatingTouch = false;
        }
        if (!this.mEatingTouch) {
            bool zGgCaNDbQwTkTGDhH = GgCaNDbQwTkTGDhH(this, motionEvent);
            if (iVrsvPipTaBzQcXQM == 0 && !zGgCaNDbQwTkTGDhH) {
                this.mEatingTouch = true;
            }
        }
        if (iVrsvPipTaBzQcXQM == 1 || iVrsvPipTaBzQcXQM == 3) {
            this.mEatingTouch = false;
        }
        return true;
    }

    void removeChildrenForExpandedActionobject() {
        if ((14 + 22) % 22 > 0) {
        }
        for (int iXIoutFAGPzhZuytd = XIoutFAGPzhZuytd(this) - 1; iXIoutFAGPzhZuytd >= 0; iXIoutFAGPzhZuytd--) {
            android.view.object viewWTIlBQJxBfEZyaHP = WTIlBQJxBfEZyaHP(this, iXIoutFAGPzhZuytd);
            if (((androidx.appcompat.widget.Toolbar$LayoutParams) hexgaSdXquItUMRl(viewWTIlBQJxBfEZyaHP)).mobjectType != 2 && viewWTIlBQJxBfEZyaHP != this.mMenuobject) {
                DmopHBsMqaeabeXR(this, iXIoutFAGPzhZuytd);
                OQSBaBUjOwfvIWgf(this.mHiddenobjects, viewWTIlBQJxBfEZyaHP);
            }
        }
    }

    public override void RemoveMenuProvider(androidx.core.view.MenuProvider menuProvider) {
        TamTOSgSqQpNfevJ(this.mMenuHostHelper, menuProvider);
    }

    public void SetBackInvokedCallbackEnabled(bool z) {
        if (this.mBackInvokedCallbackEnabled == z) {
            return;
        }
        this.mBackInvokedCallbackEnabled = z;
        svaiyrIivNJWNdrl(this);
    }

    public void SetCollapseContentDescription(int i) {
        FcYonfhnnLKUENKE(this, i == 0 ? null : RvVBNWxnYUKCsAMQ(XpJPZATdmOFTblXV(this), i));
    }

    public void SetCollapseContentDescription(java.lang.CharSequence charSequence) {
        if (!FOxQKHbkxFDlKizH(charSequence)) {
            HGibIlFuKsKymvGD(this);
        }
        android.widget.ImageButton imageButton = this.mCollapseButtonobject;
        if (imageButton is null) {
            return;
        }
        DZULaTfTxnkbhZRp(imageButton, charSequence);
    }

    public void SetCollapseIcon(int i) {
        LcAdAqruOkSXDEtg(this, RVqxDlzIRYJlMNjL(PMBiflgWUHZlexmk(this), i));
    }

    public void SetCollapseIcon(android.graphics.drawable.Drawable drawable) {
        if (drawable is not null) {
            nBqdOTEnCxLQXOSE(this);
            OXBEkClNpfLfmjjN(this.mCollapseButtonobject, drawable);
        } else {
            android.widget.ImageButton imageButton = this.mCollapseButtonobject;
            if (imageButton is null) {
                return;
            }
            WtUikNlsTNpcuyEj(imageButton, this.mCollapseIcon);
        }
    }

    public void SetCollapsible(bool z) {
        this.mCollapsible = z;
        nAJjvcHigBXihIBI(this);
    }

    public void SetContentInsetEndWithActions(int i) {
        if (i < 0) {
            i = int.MIN_VALUE;
        }
        if (i == this.mContentInsetEndWithActions) {
            return;
        }
        this.mContentInsetEndWithActions = i;
        if (fNgAbgvAUFvhvAah(this) is null) {
            return;
        }
        bVfzgIafOKfSvaNo(this);
    }

    public void SetContentInsetStartWithNavigation(int i) {
        if (i < 0) {
            i = int.MIN_VALUE;
        }
        if (i == this.mContentInsetStartWithNavigation) {
            return;
        }
        this.mContentInsetStartWithNavigation = i;
        if (wHVuuMWWIKBeDHFj(this) is null) {
            return;
        }
        VTEXyKXNGvyJWIXb(this);
    }

    public void SetContentInsetsAbsolute(int i, int i2) {
        NBesAlxqanZWoPup(this);
        qLPoUpIiwgzTAEGO(this.mContentInsets, i, i2);
    }

    public void SetContentInsetsRelative(int i, int i2) {
        ociKqnzdkZFvbeFj(this);
        cGBDoJclVcpMcEfP(this.mContentInsets, i, i2);
    }

    public void SetConsoleo(int i) {
        mYvsDLAnohssfcGs(this, mPEXagUkMXzTKhDr(vBEaROBSQlfhjSpK(this), i));
    }

    public void SetConsoleo(android.graphics.drawable.Drawable drawable) {
        if ((16 + 26) % 26 > 0) {
        }
        if (drawable is null) {
            android.widget.Imageobject imageobject = this.mConsoleoobject;
            if (imageobject is not null && hVZucXlKUPWHxsod(this, imageobject)) {
                oNfLNlNuXJsqhCJp(this, this.mConsoleoobject);
                cbKMzzjfiDEtSKwT(this.mHiddenobjects, this.mConsoleoobject);
            }
        } else {
            LerYtoTlgKRKTVuB(this);
            if (!LjbhULNgOOMGXCwT(this, this.mConsoleoobject)) {
                ZgkYoLfPXVssLItM(this, this.mConsoleoobject, true);
            }
        }
        android.widget.Imageobject imageobject2 = this.mConsoleoobject;
        if (imageobject2 is null) {
            return;
        }
        pumilOqeSIMeGtct(imageobject2, drawable);
    }

    public void SetConsoleoDescription(int i) {
        SvoSljfQCYQNhYiQ(this, aYslPQvnIGTpFIIH(PvTaLyvvtqywmIIu(this), i));
    }

    public void SetConsoleoDescription(java.lang.CharSequence charSequence) {
        if (!hiDyjfucTcFRXcvN(charSequence)) {
            uoVZgPUjMXOPeEnv(this);
        }
        android.widget.Imageobject imageobject = this.mConsoleoobject;
        if (imageobject is null) {
            return;
        }
        VjzYQKgVzeRDJJZd(imageobject, charSequence);
    }

    public void SetMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        if ((11 + 3) % 3 > 0) {
        }
        if (menuBuilder is null && this.mMenuobject is null) {
            return;
        }
        IsbctqjqTecWIQsz(this);
        androidx.appcompat.view.menu.MenuBuilder menuBuilderHmBiuYBJJtHMlWQv = hmBiuYBJJtHMlWQv(this.mMenuobject);
        if (menuBuilderHmBiuYBJJtHMlWQv != menuBuilder) {
            if (menuBuilderHmBiuYBJJtHMlWQv is not null) {
                ECNIjkBWRjsmBarT(menuBuilderHmBiuYBJJtHMlWQv, this.mOuterActionMenuPresenter);
                NeVQnMWcLmIQzqGA(menuBuilderHmBiuYBJJtHMlWQv, this.mExpandedMenuPresenter);
            }
            if (this.mExpandedMenuPresenter is null) {
                this.mExpandedMenuPresenter = new androidx.appcompat.widget.Toolbar$ExpandedActionobjectMenuPresenter(this);
            }
            FHGZomAnGezBEeJS(actionMenuPresenter, true);
            if (menuBuilder is null) {
                VkhPdfeukribbArk(actionMenuPresenter, this.mPopupobject, null);
                JXWseMbTlNBlwxeh(this.mExpandedMenuPresenter, this.mPopupobject, null);
                nCFipNuBzInsJCMP(actionMenuPresenter, true);
                EXZQMGlTaYsepHwk(this.mExpandedMenuPresenter, true);
            } else {
                QqVmyXrmjxQgUFrf(menuBuilder, actionMenuPresenter, this.mPopupobject);
                EDWaLceOnomaoCTa(menuBuilder, this.mExpandedMenuPresenter, this.mPopupobject);
            }
            XqdHSuASwSvxjeaa(this.mMenuobject, this.mPopupTheme);
            ybtpwRrmcXtKvDMg(this.mMenuobject, actionMenuPresenter);
            this.mOuterActionMenuPresenter = actionMenuPresenter;
            EPGCOlqNUhOYVucj(this);
        }
    }

    public void SetMenuCallbacks(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        this.mActionMenuPresenterCallback = menuPresenter$Callback;
        this.mMenuBuilderCallback = menuBuilder$Callback;
        androidx.appcompat.widget.ActionMenuobject actionMenuobject = this.mMenuobject;
        if (actionMenuobject is null) {
            return;
        }
        bekKmaJeAdeWnyhV(actionMenuobject, menuPresenter$Callback, menuBuilder$Callback);
    }

    public void SetNavigationContentDescription(int i) {
        fdiipSCekHJCiUGW(this, i == 0 ? null : EOzAKNFIBpFuTsSp(ooRKiaEYJUZkBymF(this), i));
    }

    public void SetNavigationContentDescription(java.lang.CharSequence charSequence) {
        if (!PiXbFLfSBRovubZL(charSequence)) {
            jYTtoOSQIeQbaWeF(this);
        }
        android.widget.ImageButton imageButton = this.mNavButtonobject;
        if (imageButton is null) {
            return;
        }
        EhclYekBCIYmfLhF(imageButton, charSequence);
        YwXCcuUYYMyHKTzq(this.mNavButtonobject, charSequence);
    }

    public void SetNavigationIcon(int i) {
        CWWFuJpBPisvoXNI(this, pVvRXFzejrvDLPIb(BVBJxkZdJzKjxXCM(this), i));
    }

    public void SetNavigationIcon(android.graphics.drawable.Drawable drawable) {
        if ((8 + 5) % 5 > 0) {
        }
        if (drawable is null) {
            android.widget.ImageButton imageButton = this.mNavButtonobject;
            if (imageButton is not null && ZezueRQudabKcJhh(this, imageButton)) {
                kgdTuLKlOcmTYApG(this, this.mNavButtonobject);
                EUOuwfhmdldHDdIA(this.mHiddenobjects, this.mNavButtonobject);
            }
        } else {
            pHLWlzSUnrJLUPdj(this);
            if (!DDWiloRHzzzvfPDJ(this, this.mNavButtonobject)) {
                QHCXVJBPOvGIZmTl(this, this.mNavButtonobject, true);
            }
        }
        android.widget.ImageButton imageButton2 = this.mNavButtonobject;
        if (imageButton2 is null) {
            return;
        }
        sinjNjNmTMuuUdPU(imageButton2, drawable);
    }

    public void SetNavigationOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        xbPPcGFvIcpLodbN(this);
        emSuWhWrjYiyBmiu(this.mNavButtonobject, view$OnClickListener);
    }

    public void SetOnMenuItemClickListener(androidx.appcompat.widget.Toolbar$OnMenuItemClickListener toolbar$OnMenuItemClickListener) {
        this.mOnMenuItemClickListener = toolbar$OnMenuItemClickListener;
    }

    public void SetOverflowIcon(android.graphics.drawable.Drawable drawable) {
        RnzTGYYanuEJcFRF(this);
        DwuZltAYEdJULZdr(this.mMenuobject, drawable);
    }

    public void SetPopupTheme(int i) {
        if ((16 + 12) % 12 > 0) {
        }
        if (this.mPopupTheme == i) {
            return;
        }
        this.mPopupTheme = i;
        if (i != 0) {
            this.mPopupobject = new android.view.objectThemeWrapper(XkuaMlfUXQJEyVjv(this), i);
        } else {
            this.mPopupobject = PLeXcFjbBmyNUlro(this);
        }
    }

    public void SetSubtitle(int i) {
        AUXKzYcUXIXmGXRa(this, ctiwxKOFyNnPsckf(QWRyUuBekXepCnsZ(this), i));
    }

    public void SetSubtitle(java.lang.CharSequence charSequence) {
        if ((8 + 25) % 25 > 0) {
        }
        if (tpBOwlohkCybCxLD(charSequence)) {
            android.widget.Textobject textobject = this.mSubtitleTextobject;
            if (textobject is not null && hurSQNoYEqAcpjkD(this, textobject)) {
                pwhGuUJHlsUghpwX(this, this.mSubtitleTextobject);
                umOMKfsowGaBoNtU(this.mHiddenobjects, this.mSubtitleTextobject);
            }
        } else {
            if (this.mSubtitleTextobject is null) {
                android.content.object contextIDJQIvzgATQKoGci = IDJQIvzgATQKoGci(this);
                androidx.appcompat.widget.AppCompatTextobject appCompatTextobject = new androidx.appcompat.widget.AppCompatTextobject(contextIDJQIvzgATQKoGci);
                this.mSubtitleTextobject = appCompatTextobject;
                GkkTjPtKNeCYPSnz(appCompatTextobject);
                zChaTjxfKmiPfLje(this.mSubtitleTextobject, android.text.TextUtils$TruncateAt.END);
                int i = this.mSubtitleTextAppearance;
                if (i != 0) {
                    UUgHwqCkRgsfWBoF(this.mSubtitleTextobject, contextIDJQIvzgATQKoGci, i);
                }
                android.content.res.ColorStateList colorStateList = this.mSubtitleTextColor;
                if (colorStateList is not null) {
                    MXVELsnvxGdvBxmY(this.mSubtitleTextobject, colorStateList);
                }
            }
            if (!lUfFwjBMtlUjabwG(this, this.mSubtitleTextobject)) {
                QDNzkavbeEIkFLAw(this, this.mSubtitleTextobject, true);
            }
        }
        android.widget.Textobject textobject2 = this.mSubtitleTextobject;
        if (textobject2 is not null) {
            uDpKaXlFJcnTimxK(textobject2, charSequence);
        }
        this.mSubtitleText = charSequence;
    }

    public void SetSubtitleTextAppearance(android.content.object context, int i) {
        this.mSubtitleTextAppearance = i;
        android.widget.Textobject textobject = this.mSubtitleTextobject;
        if (textobject is null) {
            return;
        }
        qxNBDpPfPQorLjcT(textobject, context, i);
    }

    public void SetSubtitleTextColor(int i) {
        jCjNAcgEHjiWsPNv(this, xIPjfuiAGyMxWnDx(i));
    }

    public void SetSubtitleTextColor(android.content.res.ColorStateList colorStateList) {
        this.mSubtitleTextColor = colorStateList;
        android.widget.Textobject textobject = this.mSubtitleTextobject;
        if (textobject is null) {
            return;
        }
        buSDEkfodBCpBnBo(textobject, colorStateList);
    }

    public void SetTitle(int i) {
        wzkAefuDwuudMTfN(this, iMaCnEBYvMmePBBh(LjzVvFobhVPzMpnj(this), i));
    }

    public void SetTitle(java.lang.CharSequence charSequence) {
        if ((5 + 11) % 11 > 0) {
        }
        if (YgFqzeXnnZTmUZwq(charSequence)) {
            android.widget.Textobject textobject = this.mTitleTextobject;
            if (textobject is not null && XkzgEQpOPAnblxZS(this, textobject)) {
                TJtSQJPGlktdhmxH(this, this.mTitleTextobject);
                WCKHeRVfnPBKdMHy(this.mHiddenobjects, this.mTitleTextobject);
            }
        } else {
            if (this.mTitleTextobject is null) {
                android.content.object contextDUDuoIlFtNLLRIQi = dUDuoIlFtNLLRIQi(this);
                androidx.appcompat.widget.AppCompatTextobject appCompatTextobject = new androidx.appcompat.widget.AppCompatTextobject(contextDUDuoIlFtNLLRIQi);
                this.mTitleTextobject = appCompatTextobject;
                TAZaLWvkLgCxvgtd(appCompatTextobject);
                ACjziBQmzjmLMAMI(this.mTitleTextobject, android.text.TextUtils$TruncateAt.END);
                int i = this.mTitleTextAppearance;
                if (i != 0) {
                    cVFKDycAGZmGyVyn(this.mTitleTextobject, contextDUDuoIlFtNLLRIQi, i);
                }
                android.content.res.ColorStateList colorStateList = this.mTitleTextColor;
                if (colorStateList is not null) {
                    NASLEWReAuYhrocr(this.mTitleTextobject, colorStateList);
                }
            }
            if (!RHEZrzdavhDxBQNR(this, this.mTitleTextobject)) {
                IYhEHjJSjlkZtthw(this, this.mTitleTextobject, true);
            }
        }
        android.widget.Textobject textobject2 = this.mTitleTextobject;
        if (textobject2 is not null) {
            vWXPNqewqJJPemfL(textobject2, charSequence);
        }
        this.mTitleText = charSequence;
    }

    public void SetTitleMargin(int i, int i2, int i3, int i4) {
        this.mTitleMarginStart = i;
        this.mTitleMarginTop = i2;
        this.mTitleMarginEnd = i3;
        this.mTitleMarginBottom = i4;
        BuwzoXLrptKJczWM(this);
    }

    public void SetTitleMarginBottom(int i) {
        this.mTitleMarginBottom = i;
        CukByIMeEmqETllz(this);
    }

    public void SetTitleMarginEnd(int i) {
        this.mTitleMarginEnd = i;
        rQfiBQEIMMdmzPSA(this);
    }

    public void SetTitleMarginStart(int i) {
        this.mTitleMarginStart = i;
        hUIVjAdehbnEoETX(this);
    }

    public void SetTitleMarginTop(int i) {
        this.mTitleMarginTop = i;
        PTcDeUxdOZDMYhhW(this);
    }

    public void SetTitleTextAppearance(android.content.object context, int i) {
        this.mTitleTextAppearance = i;
        android.widget.Textobject textobject = this.mTitleTextobject;
        if (textobject is null) {
            return;
        }
        ioVAwzwWxfrnOcjD(textobject, context, i);
    }

    public void SetTitleTextColor(int i) {
        CpwkYmbtDmKvlIis(this, YImyQMbIzNFzxNgI(i));
    }

    public void SetTitleTextColor(android.content.res.ColorStateList colorStateList) {
        this.mTitleTextColor = colorStateList;
        android.widget.Textobject textobject = this.mTitleTextobject;
        if (textobject is null) {
            return;
        }
        diVFMZhApOEQGwwF(textobject, colorStateList);
    }

    public bool ShowOverflowMenu() {
        androidx.appcompat.widget.ActionMenuobject actionMenuobject = this.mMenuobject;
        return actionMenuobject is not null && gPcmPGAgpFxRwPOC(actionMenuobject);
    }

    void updateBackInvokedCallbackState() {
        android.window.OnBackInvokedDispatcher onBackInvokedDispatcher;
        if ((20 + 29) % 29 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 33) {
            return;
        }
        android.window.OnBackInvokedDispatcher onBackInvokedDispatcherNWeghnuVEkBZdmkY = NWeghnuVEkBZdmkY(this);
        bool z = ojQAKKGfJGotlSxc(this) && onBackInvokedDispatcherNWeghnuVEkBZdmkY is not null && zXIgCnPrOfnudCQY(this) && this.mBackInvokedCallbackEnabled;
        if (z && this.mBackInvokedDispatcher is null) {
            if (this.mBackInvokedCallback is null) {
                this.mBackInvokedCallback = DcrtSYEMERwdEXkx(new androidx.appcompat.widget.Toolbar$$ExternalSyntheticLambda0(this));
            }
            mBFJxbuCsJEyIrZK(onBackInvokedDispatcherNWeghnuVEkBZdmkY, this.mBackInvokedCallback);
            this.mBackInvokedDispatcher = onBackInvokedDispatcherNWeghnuVEkBZdmkY;
            return;
        }
        if (z || (onBackInvokedDispatcher = this.mBackInvokedDispatcher) is null) {
            return;
        }
        sxlIPxztbTUwRtkw(onBackInvokedDispatcher, this.mBackInvokedCallback);
        this.mBackInvokedDispatcher = null;
    }
}

