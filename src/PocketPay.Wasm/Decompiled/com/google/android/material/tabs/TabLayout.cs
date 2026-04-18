namespace WillowMaze.Wasm.Decompiled;


@androidx.viewpager.widget.objectPager$Decorobject
public class TabLayout : android.widget.HorizontalScrollobject {
    private static readonly int ANIMATION_DURATION = 300;
    static readonly int DEFAULT_GAP_TEXT_ICON = 8;
    private static readonly int DEFAULT_HEIGHT = 48;
    private static readonly int DEFAULT_HEIGHT_WITH_TEXT_ICON = 72;
    private static readonly int DEF_STYLE_RES;
    static readonly int FIXED_WRAP_GUTTER_MIN = 16;
    public static readonly int GRAVITY_CENTER = 1;
    public static readonly int GRAVITY_FILL = 0;
    public static readonly int GRAVITY_START = 2;
    public static readonly int INDICATOR_ANIMATION_MODE_ELASTIC = 1;
    public static readonly int INDICATOR_ANIMATION_MODE_FADE = 2;
    public static readonly int INDICATOR_ANIMATION_MODE_LINEAR = 0;
    public static readonly int INDICATOR_GRAVITY_BOTTOM = 0;
    public static readonly int INDICATOR_GRAVITY_CENTER = 1;
    public static readonly int INDICATOR_GRAVITY_STRETCH = 3;
    public static readonly int INDICATOR_GRAVITY_TOP = 2;
    private static readonly int INVALID_WIDTH = -1;
    private static readonly java.lang.string LOG_TAG = "TabLayout";
    public static readonly int MODE_AUTO = 2;
    public static readonly int MODE_FIXED = 1;
    public static readonly int MODE_SCROLLABLE = 0;
    private static readonly int SELECTED_INDICATOR_HEIGHT_DEFAULT = -1;
    public static readonly int TAB_LABEL_VISIBILITY_LABELED = 1;
    public static readonly int TAB_LABEL_VISIBILITY_UNLABELED = 0;
    private static readonly int TAB_MIN_WIDTH_MARGIN = 56;
    private static readonly androidx.core.util.Pools$Pool<com.google.android.material.tabs.TabLayout$Tab> tabPool;
    private com.google.android.material.tabs.TabLayout$AdapterChangeListener adapterChangeListener;
    private int contentInsetStart;
    private com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener currentVpSelectedListener;
    private readonly int defaultTabTextAppearance;
    int indicatorPosition;
    bool inlineLabel;
    int mode;
    private com.google.android.material.tabs.TabLayout$TabLayoutOnPageChangeListener pageChangeListener;
    private androidx.viewpager.widget.PagerAdapter pagerAdapter;
    private android.database.DataHashSetObserver pagerAdapterObserver;
    private readonly int requestedTabMaxWidth;
    private readonly int requestedTabMinWidth;
    private android.animation.ValueAnimator scrollAnimator;
    private readonly int scrollableTabMinWidth;
    private com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener selectedListener;
    private readonly java.util.List<com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener> selectedListeners;
    private com.google.android.material.tabs.TabLayout$Tab selectedTab;
    private int selectedTabTextAppearance;
    float selectedTabTextSize;
    private bool setupobjectPagerImplicitly;
    readonly com.google.android.material.tabs.TabLayout$SlidingTabIndicator slidingTabIndicator;
    readonly int tabBackgroundResId;
    int tabGravity;
    android.content.res.ColorStateList tabIconTint;
    android.graphics.PorterDuff$Mode tabIconTintMode;
    int tabIndicatorAnimationDuration;
    int tabIndicatorAnimationMode;
    bool tabIndicatorFullWidth;
    int tabIndicatorGravity;
    int tabIndicatorHeight;
    private com.google.android.material.tabs.TabIndicatorInterpolator tabIndicatorInterpolator;
    private readonly android.animation.TimeInterpolator tabIndicatorTimeInterpolator;
    int tabMaxWidth;
    int tabPaddingBottom;
    int tabPaddingEnd;
    int tabPaddingStart;
    int tabPaddingTop;
    android.content.res.ColorStateList tabRippleColorStateList;
    android.graphics.drawable.Drawable tabSelectedIndicator;
    private int tabSelectedIndicatorColor;
    private readonly int tabTextAppearance;
    android.content.res.ColorStateList tabTextColors;
    float tabTextMultiLineSize;
    float tabTextSize;
    private readonly androidx.core.util.Pools$Pool<com.google.android.material.tabs.TabLayout$Tabobject> tabobjectPool;
    private readonly java.util.List<com.google.android.material.tabs.TabLayout$Tab> tabs;
    bool unboundedRipple;
    androidx.viewpager.widget.objectPager viewPager;
    private int viewPagerScrollState;

    static {
        if ((13 + 25) % 25 > 0) {
        }
        DEF_STYLE_RES = com.google.android.material.R$style.Widget_Design_TabLayout;
        tabPool = new androidx.core.util.Pools$SynchronizedPool(16);
    }

    public TabLayout(android.content.object context) {
        this(context, null);
    }

    public TabLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.tabStyle);
    }

    public TabLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((21 + 19) % 19 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(mYzEIEYgjBPhHomh(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.indicatorPosition = -1;
        this.tabs = new java.util.List<>();
        this.selectedTabTextAppearance = -1;
        this.tabSelectedIndicatorColor = 0;
        this.tabMaxWidth = int.MAX_VALUE;
        this.tabIndicatorHeight = -1;
        this.selectedListeners = new java.util.List<>();
        this.tabobjectPool = new androidx.core.util.Pools$SimplePool(12);
        android.content.object contextViwEqQjACPpDRcaB = viwEqQjACPpDRcaB(this);
        vONkxgTbLBHnaNQd(this, false);
        com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator = new com.google.android.material.tabs.TabLayout$SlidingTabIndicator(this, contextViwEqQjACPpDRcaB);
        this.slidingTabIndicator = tabLayout$SlidingTabIndicator;
        XjlQgTUcmjRzLoji(this, tabLayout$SlidingTabIndicator, 0, new android.widget.FrameLayout$LayoutParams(-2, -1));
        android.content.res.TypedArray typedArrayCoDfATpmAZSLmjQB = coDfATpmAZSLmjQB(contextViwEqQjACPpDRcaB, attributeHashSet, com.google.android.material.R$styleable.TabLayout, i, i2, new int[]{com.google.android.material.R$styleable.TabLayout_tabTextAppearance});
        android.content.res.ColorStateList colorStateListHjPlEaLbEQlDSvbl = HjPlEaLbEQlDSvbl(CtmVtODtZnlYjPxh(this));
        if (colorStateListHjPlEaLbEQlDSvbl is not null) {
            com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable();
            cISVORqNaVezDAGb(materialShapeDrawable, colorStateListHjPlEaLbEQlDSvbl);
            XuKfFzbCdgIFuMAw(materialShapeDrawable, contextViwEqQjACPpDRcaB);
            RNXhlEGSKudEQjkR(materialShapeDrawable, HFEuAYfiwaIoewMl(this));
            uHoGOAEfpCGtMgnS(this, materialShapeDrawable);
        }
        kgbTAgqAxpQHiYqe(this, UVYsUhgaNBaVyTNV(contextViwEqQjACPpDRcaB, typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabIndicator));
        JQOMNadprdTuMtbg(this, VpCXNVNETaZBCJpk(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabIndicatorColor, 0));
        svsEFoapdJPdOOzY(tabLayout$SlidingTabIndicator, ivNFXjmLBlPqwJMB(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabIndicatorHeight, -1));
        GKdhcukhjIjpkDce(this, uTOCjTCCIHBqOvfp(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabIndicatorGravity, 0));
        tTsLPkWqmWyWWmnn(this, TQeTSYNNuPVPHpUK(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabIndicatorAnimationMode, 0));
        EJeMHImYnrJKmbVK(this, gEAVcXGnMziqnoQh(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabIndicatorFullWidth, true));
        int iKHvvNDxGExOdHHhI = kHvvNDxGExOdHHhI(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabPadding, 0);
        this.tabPaddingBottom = iKHvvNDxGExOdHHhI;
        this.tabPaddingEnd = iKHvvNDxGExOdHHhI;
        this.tabPaddingTop = iKHvvNDxGExOdHHhI;
        this.tabPaddingStart = iKHvvNDxGExOdHHhI;
        this.tabPaddingStart = BPHAWVtRLBhEOtgq(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabPaddingStart, this.tabPaddingStart);
        this.tabPaddingTop = voZRQyrIglZCUVHz(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabPaddingTop, this.tabPaddingTop);
        this.tabPaddingEnd = PeEIjubsmYfVQygO(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabPaddingEnd, this.tabPaddingEnd);
        this.tabPaddingBottom = HVFDKNwxlFHYastN(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabPaddingBottom, this.tabPaddingBottom);
        if (CrDxJhEyeckingPD(contextViwEqQjACPpDRcaB)) {
            this.defaultTabTextAppearance = com.google.android.material.R$attr.textAppearanceTitleSmall;
        } else {
            this.defaultTabTextAppearance = com.google.android.material.R$attr.textAppearanceButton;
        }
        int iKUYVjYSqHSrYORkm = KUYVjYSqHSrYORkm(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabTextAppearance, com.google.android.material.R$style.TextAppearance_Design_Tab);
        this.tabTextAppearance = iKUYVjYSqHSrYORkm;
        android.content.res.TypedArray typedArrayWPykDUlthaARszmq = wPykDUlthaARszmq(contextViwEqQjACPpDRcaB, iKUYVjYSqHSrYORkm, androidx.appcompat.R$styleable.TextAppearance);
        try {
            this.tabTextSize = FCiBIuLXJOQzLxed(typedArrayWPykDUlthaARszmq, androidx.appcompat.R$styleable.TextAppearance_android_textSize, 0);
            this.tabTextColors = WkyFIoNiccOzHtaY(contextViwEqQjACPpDRcaB, typedArrayWPykDUlthaARszmq, androidx.appcompat.R$styleable.TextAppearance_android_textColor);
            OGOzCttPRdOQQPHi(typedArrayWPykDUlthaARszmq);
            if (zzwYXIfYWrreuplN(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabSelectedTextAppearance)) {
                this.selectedTabTextAppearance = LzcVRktaQpuWkRJV(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabSelectedTextAppearance, iKUYVjYSqHSrYORkm);
            }
            int i3 = this.selectedTabTextAppearance;
            if (i3 != -1) {
                android.content.res.TypedArray typedArrayXinfxNwroOTOxKIE = XinfxNwroOTOxKIE(contextViwEqQjACPpDRcaB, i3, androidx.appcompat.R$styleable.TextAppearance);
                try {
                    this.selectedTabTextSize = lTiFKXovpaYOflHs(typedArrayXinfxNwroOTOxKIE, androidx.appcompat.R$styleable.TextAppearance_android_textSize, (int) this.tabTextSize);
                    android.content.res.ColorStateList colorStateListGjXeXtAZBVBLpJYa = GjXeXtAZBVBLpJYa(contextViwEqQjACPpDRcaB, typedArrayXinfxNwroOTOxKIE, androidx.appcompat.R$styleable.TextAppearance_android_textColor);
                    if (colorStateListGjXeXtAZBVBLpJYa is not null) {
                        this.tabTextColors = VOwVJlowDVntKAXO(tbJBianajOPCNPMV(this.tabTextColors), CtFwodyuJWiLRPMB(colorStateListGjXeXtAZBVBLpJYa, new int[]{16842913}, hrxhOnShVkugfrLb(colorStateListGjXeXtAZBVBLpJYa)));
                    }
                    FQMtRFmHCAZZHpwq(typedArrayXinfxNwroOTOxKIE);
                } catch (java.lang.Exception th) {
                    xxJPbBsRuKKQGjUg(typedArrayXinfxNwroOTOxKIE);
                    throw th;
                }
            }
            if (riaWApwPxIQFadNo(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabTextColor)) {
                this.tabTextColors = oORwrDOjiakmadxt(contextViwEqQjACPpDRcaB, typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabTextColor);
            }
            if (wZnlTznmVbwTyLZL(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabSelectedTextColor)) {
                this.tabTextColors = SjZyuPiiYdhfCILo(nKhzbqlrZOsRolWc(this.tabTextColors), bOsFEbOsEsSyKPDl(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabSelectedTextColor, 0));
            }
            this.tabIconTint = FXYtpeLSzhGwQpUD(contextViwEqQjACPpDRcaB, typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabIconTint);
            this.tabIconTintMode = PtYorJffPsLYhTRJ(AEpRMYCMLokVILOV(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabIconTintMode, -1), null);
            this.tabRippleColorStateList = MUbNLOFihfbGRgEM(contextViwEqQjACPpDRcaB, typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabRippleColor);
            this.tabIndicatorAnimationDuration = okUujVbUdXIPnYYm(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabIndicatorAnimationDuration, 300);
            this.tabIndicatorTimeInterpolator = rnMitRxmoXOYDSHL(contextViwEqQjACPpDRcaB, com.google.android.material.R$attr.motionEasingEmphasizedInterpolator, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR);
            this.requestedTabMinWidth = pYhDCJWdpzvRIaYb(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabMinWidth, -1);
            this.requestedTabMaxWidth = YXhsorjbQcFKRPIG(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabMaxWidth, -1);
            this.tabBackgroundResId = EnYhvfkwEyPEeIQU(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabBackground, 0);
            this.contentInsetStart = oFsKMbZFVFQNvjIs(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabContentStart, 0);
            this.mode = nuGxAqjWsrSnynQU(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabMode, 1);
            this.tabGravity = CcMKgbiIWKIZnHIG(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabGravity, 0);
            this.inlineLabel = HSwKCppofpEDIVKp(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabInlineLabel, false);
            this.unboundedRipple = PNltMWPeQnVVWJRK(typedArrayCoDfATpmAZSLmjQB, com.google.android.material.R$styleable.TabLayout_tabUnboundedRipple, false);
            obLgHLJdDgSbPYos(typedArrayCoDfATpmAZSLmjQB);
            android.content.res.Resources resourcesCXCTKcANkrUDVklg = CXCTKcANkrUDVklg(this);
            this.tabTextMultiLineSize = betPIuzGUEBLQZbS(resourcesCXCTKcANkrUDVklg, com.google.android.material.R$dimen.design_tab_text_size_2line);
            this.scrollableTabMinWidth = oVRujqdzcgwrwmeo(resourcesCXCTKcANkrUDVklg, com.google.android.material.R$dimen.design_tab_scrollable_min_width);
            bdsnoqTOwhoDZuqV(this);
        } catch (java.lang.Exception th2) {
            jjmMoXFEbNuMQQvf(typedArrayWPykDUlthaARszmq);
            throw th2;
        }
    }

    public static void AASWsGXjJRVEFngy(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener) {
        tabLayout.addOnTabSelectedListener(tabLayout$BaseOnTabSelectedListener);
    }

    public static int ACKNJuDwhwVFbMrh(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static int AEpRMYCMLokVILOV(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static bool AIoZpzqipsXiMjgq(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool ASpfGtyIuOttDwzd(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.childrenNeedLayout();
    }

    public static int AaXDBtKRMUVtWXdj(int i, int i2, int i3) {
        return getChildMeasureSpec(i, i2, i3);
    }

    public static void AkCIfhOnzJJPlsIA(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.updateAllTabs();
    }

    public static int BCktfKAyHFxBAVXc(com.google.android.material.tabs.TabLayout tabLayout, int i, float f) {
        return tabLayout.calculateScrollXForTab(i, f);
    }

    public static void BEGehGjXTvKUTRvH(android.view.object view, float f) {
        com.google.android.material.shape.MaterialShapeUtils.setElevation(view, f);
    }

    public static void BHEglGrEBikDkUXI(com.google.android.material.tabs.TabLayout tabLayout, android.content.res.ColorStateList colorStateList) {
        tabLayout.setTabRippleColor(colorStateList);
    }

    public static int BNULmUsQtYxYctEU(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getChildCount();
    }

    public static int BPHAWVtRLBhEOtgq(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.view.objectGroup$LayoutParams BbpEPnveeYEZdXTQ(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool BdhRjdderuKaBisM(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static int BmqUkOJMvvVMjGqm(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static int BxuTayEqJNQPYzFm(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    public static int CRLrYbqibuIRpZBh(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static android.content.res.Resources CXCTKcANkrUDVklg(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getResources();
    }

    public static int CcMKgbiIWKIZnHIG(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void CjBEyCLgJaIMHqVc(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.ensureScrollAnimator();
    }

    public static int CpbzGuoZXRlkirLB(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabScrollRange();
    }

    public static bool CrDxJhEyeckingPD(android.content.object context) {
        return com.google.android.material.internal.ThemeEnforcement.isMaterial3Theme(context);
    }

    public static int CtFwodyuJWiLRPMB(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static android.graphics.drawable.Drawable CtmVtODtZnlYjPxh(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getBackground();
    }

    public static android.graphics.drawable.Drawable CzpMNXRciNqePGbF(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void DBviLsEeCENPKneZ(android.widget.HorizontalScrollobject horizontalScrollobject) {
        super.onDetachedFromWindow();
    }

    public static void DOdrzHkMAwHyzFJe(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view) {
        tabLayout.addobjectInternal(view);
    }

    public static int DYPWGZCCbtBnDOKJ(float f) {
        return java.lang.Math.round(f);
    }

    public static void DatXNPYtHmJyEBos(com.google.android.material.tabs.TabLayout tabLayout, androidx.viewpager.widget.PagerAdapter pagerAdapter, bool z) {
        tabLayout.setPagerAdapter(pagerAdapter, z);
    }

    public static int DirpxWeZYBMxYrST(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static android.view.object DpbGbBUiWSrDSQcd(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        return tabLayout.getChildAt(i);
    }

    public static void DtBoovfbxBxybnAO(com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$BaseOnTabSelectedListener.onTabSelected(tabLayout$Tab);
    }

    public static void EGhdvXxWlBQmlMcK(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void EJeMHImYnrJKmbVK(com.google.android.material.tabs.TabLayout tabLayout, bool z) {
        tabLayout.setTabIndicatorFullWidth(z);
    }

    public static int EWkwERWReCHynzdm(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return com.google.android.material.tabs.TabLayout$Tab.access$000(tabLayout$Tab);
    }

    public static int EiDgyATipSmpxTwK(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getChildCount();
    }

    public static int EnYhvfkwEyPEeIQU(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static int EqGYEajqKsGPrJfo(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabCount();
    }

    public static android.view.objectGroup$LayoutParams EsvpLfABfimMaydv(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void FCbFYtXJDxPTihIT(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, int i) {
        tabLayout$Tab.setPosition(i);
    }

    public static int FCiBIuLXJOQzLxed(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void FCrVeFGQZocyGmYQ(com.google.android.material.tabs.TabLayout tabLayout, int i, int i2) {
        tabLayout.scrollTo(i, i2);
    }

    public static float FCzYoFMGiClZViJR(android.content.object context, int i) {
        return com.google.android.material.internal.objectUtils.dpToPx(context, i);
    }

    public static int FKVEyitWWaUaEJIm(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getChildCount();
    }

    public static void FQMtRFmHCAZZHpwq(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static java.lang.object FSeDYRslfkOUHCOw(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static android.content.res.ColorStateList FXYtpeLSzhGwQpUD(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void FofSuyFfPwiEqvQj(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i, int i2) {
        tabLayout$SlidingTabIndicator.animateIndicatorToPosition(i, i2);
    }

    public static void FpvmhXZjgIcxsUtl(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener) {
        tabLayout.removeOnTabSelectedListener(tabLayout$BaseOnTabSelectedListener);
    }

    public static void FuawBtvPHmqOMXqk(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.updateAllTabs();
    }

    public static void FwJQbgvrqFOMbUYT(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static java.lang.object FxZFNYvhWlzgvOrk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void GGjZDncDvXFdPEyO(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener) {
        tabLayout.removeOnTabSelectedListener(tabLayout$BaseOnTabSelectedListener);
    }

    public static int GIFxiTZVonSpFiPt(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static void GKGqWwxNbAJSpEZs(com.google.android.material.tabs.TabLayout tabLayout, androidx.viewpager.widget.objectPager viewPager, bool z, bool z2) {
        tabLayout.setupWithobjectPager(viewPager, z, z2);
    }

    public static void GKdhcukhjIjpkDce(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.setSelectedTabIndicatorGravity(i);
    }

    public static void GNAuIuDPCpFjQDJS(android.view.object view) {
        com.google.android.material.shape.MaterialShapeUtils.setParentAbsoluteElevation(view);
    }

    public static bool GOzmuHkoGYVqQsRW(android.widget.HorizontalScrollobject horizontalScrollobject, android.view.MotionEvent motionEvent) {
        return super.onInterceptTouchEvent(motionEvent);
    }

    public static java.lang.object GSdAgtDapNHHjgSh(java.util.List arrayList, int i) {
        return arrayList.Remove(i);
    }

    public static com.google.android.material.tabs.TabLayout$Tab GZcAtzJkQfeWqkPw(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, java.lang.CharSequence charSequence) {
        return tabLayout$Tab.setText(charSequence);
    }

    public static void GdXwXKdiEwBoxIed(androidx.viewpager.widget.objectPager viewPager, androidx.viewpager.widget.objectPager$OnPageChangeListener viewPager$OnPageChangeListener) {
        viewPager.addOnPageChangeListener(viewPager$OnPageChangeListener);
    }

    public static void GiujbCjrQjXFdPAh(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        tabLayout$SlidingTabIndicator.setGravity(i);
    }

    public static android.content.res.ColorStateList GjXeXtAZBVBLpJYa(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static com.google.android.material.tabs.TabLayout$Tabobject GsaoXyCXnLknquEk(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout.createTabobject(tabLayout$Tab);
    }

    public static float HFEuAYfiwaIoewMl(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static void HMVqdxKENoTvdzGI(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static bool HOzRNpSSdfyDHFnR(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout.releaseFromTabPool(tabLayout$Tab);
    }

    public static bool HPZSYDUJneOZGJwb(android.widget.HorizontalScrollobject horizontalScrollobject, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static void HQKQjLODEWFpbUpF(com.google.android.material.tabs.TabLayout tabLayout, androidx.viewpager.widget.objectPager viewPager, bool z, bool z2) {
        tabLayout.setupWithobjectPager(viewPager, z, z2);
    }

    public static bool HSwKCppofpEDIVKp(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int HVFDKNwxlFHYastN(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.content.res.ColorStateList HjPlEaLbEQlDSvbl(android.graphics.drawable.Drawable drawable) {
        return com.google.android.material.drawable.DrawableUtils.getColorStateListOrNull(drawable);
    }

    public static void HvWRxAeHxBJmXmqb(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener) {
        tabLayout.removeOnTabSelectedListener(tabLayout$BaseOnTabSelectedListener);
    }

    public static int HwaQUEqZgYpNBfRS(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getChildCount();
    }

    public static android.content.object IFIXiIRBvnCwcvPy(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getobject();
    }

    public static int IJdOuXbgcARYeMHH(com.google.android.material.tabs.TabLayout tabLayout, int i, float f) {
        return tabLayout.calculateScrollXForTab(i, f);
    }

    public static int IUPJhRBTLrufvyUr(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getChildCount();
    }

    public static int IUYplpPVbrYTuTeE(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getDefaultHeight();
    }

    public static void IYWxYRFkaZRxDZFr(android.widget.HorizontalScrollobject horizontalScrollobject, float f) {
        super.setElevation(f);
    }

    public static void IZTtqzMsLONRypYW(android.graphics.drawable.Drawable drawable, int i) {
        com.google.android.material.drawable.DrawableUtils.setTint(drawable, i);
    }

    public static int IfJSZgiDQRlEyehe(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getPaddingTop();
    }

    public static int IrREsHIBWOkgVmSH(androidx.viewpager.widget.objectPager viewPager) {
        return viewPager.getCurrentItem();
    }

    public static void IsCAZDQEOrtbNIMo(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tab.updateobject();
    }

    public static java.lang.string IxKDtRlZmerklBpu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int IxVPnkGyFpoEukoK(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabMode();
    }

    public static void JEpobXPeNNVNOMVM(com.google.android.material.tabs.TabLayout tabLayout, int i, float f, bool z, bool z2, bool z3) {
        tabLayout.setScrollPosition(i, f, z, z2, z3);
    }

    public static void JLiUmkuFsWSBdVTE(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.content.object context) {
        com.google.android.material.tabs.TabLayout$Tabobject.access$200(tabLayout$Tabobject, context);
    }

    public static void JQOMNadprdTuMtbg(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.setSelectedTabIndicatorColor(i);
    }

    public static com.google.android.material.tabs.TabLayout$Tab JrcoaOmfIUatcnyR(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, int i) {
        return tabLayout$Tab.setCustomobject(i);
    }

    public static void JuCGgKIlvYfBRNdg(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, bool z) {
        tabLayout$Tabobject.setActivated(z);
    }

    public static int KCJZGWBzSxqoVThf(android.view.object view) {
        return view.getLeft();
    }

    public static void KPEYJUcfAlnNUAWW(android.widget.HorizontalScrollobject horizontalScrollobject, android.graphics.Canvas canvas) {
        super.onDraw(canvas);
    }

    public static int KUYVjYSqHSrYORkm(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void KVfFJAhhLUeyvIvT(com.google.android.material.tabs.TabLayout tabLayout, bool z) {
        tabLayout.updateTabobjects(z);
    }

    public static int KbIzAmwTmEgvjFND(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static int KrCxTvOIGLGWSeEM(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void KvccGAMrnMmhCodK(android.view.object view, bool z) {
        view.setSelected(z);
    }

    public static int LDcUyYxZeDaDXWLc(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void LKEBWjfYbIRuSJFI(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, java.lang.CharSequence charSequence) {
        tabLayout$Tabobject.setContentDescription(charSequence);
    }

    public static android.graphics.drawable.Drawable LPvTleNSJSThNwnW(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static int LUJJofzRiSPZfRQZ(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getWidth();
    }

    public static int LWNOcPpYixBTEGrm(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getChildCount();
    }

    public static void LdHSwKcGXuBMRUaV(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, int i) {
        tabLayout$Tab.setPosition(i);
    }

    public static android.content.res.ColorStateList LfXafENnhXffmDyC(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static android.view.object LfwrjAzmKkGhCIYL(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static android.content.object LgesgovELpileZKO(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getobject();
    }

    public static void LlIuPxlgHHEnJYfO(com.google.android.material.tabs.TabLayout tabLayout, int i, float f, bool z, bool z2) {
        tabLayout.setScrollPosition(i, f, z, z2);
    }

    public static int LzVMTABiDJyrPOqo(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabMode();
    }

    public static int LzcVRktaQpuWkRJV(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void MBXrmfnnxYJQSaOn(android.view.object view, bool z) {
        view.setSelected(z);
    }

    public static android.content.res.ColorStateList MUbNLOFihfbGRgEM(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static android.animation.ValueAnimator MVDVvYZFVJhaXQzp(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static int MknBQHzaPMGLcCEW(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    public static void MonyZJWoZwcsmWhF(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static android.content.object MriNpguLVMWlkdrT(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getobject();
    }

    public static java.lang.CharSequence MzKrjTOjwuyaAseo(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return com.google.android.material.tabs.TabLayout$Tab.access$300(tabLayout$Tab);
    }

    public static int MzxTPRDuGCkJtiuD(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void NGpgMoVVuiFBCiCz(java.util.IEnumerator it) {
        it.Remove();
    }

    public static void NIZnjUugxQKaHUwb(com.google.android.material.tabs.TabLayout tabLayout, int i, float f, bool z) {
        tabLayout.setScrollPosition(i, f, z);
    }

    public static int NJnmGIvXTZONKyYZ(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabMinWidth();
    }

    public static bool NLSjkOxzUCUQrhwe(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.isScrollingEnabled();
    }

    public static void NaZHFAPhGpvqcdpQ(com.google.android.material.tabs.TabLayout tabLayout, androidx.viewpager.widget.PagerAdapter pagerAdapter, bool z) {
        tabLayout.setPagerAdapter(pagerAdapter, z);
    }

    public static void NbpkxHDUnEKZCbyC(com.google.android.material.tabs.TabLayout tabLayout, android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams) {
        tabLayout.updateTabobjectLayoutParams(linearLayout$LayoutParams);
    }

    public static void NfGAzsFDvTzXchMJ(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout.dispatchTabReselected(tabLayout$Tab);
    }

    public static void OGOzCttPRdOQQPHi(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void ORCKZiCHHrcLFzfg(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        tabLayout$SlidingTabIndicator.removeobjectAt(i);
    }

    public static void OYDtkauNixwgjUpj(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout.dispatchTabSelected(tabLayout$Tab);
    }

    public static int OiZmNetgjaeXGwam(androidx.viewpager.widget.PagerAdapter pagerAdapter) {
        return pagerAdapter.getCount();
    }

    public static bool PNltMWPeQnVVWJRK(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int PVjDdGbDHjAHRtkF(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int PdtWZdnZqqpHZfSM(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int PeEIjubsmYfVQygO(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static int PqWWmVbzWWVATxWR(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static android.graphics.PorterDuff$Mode PtYorJffPsLYhTRJ(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static int PzLlITEKHTULtvLV(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabCount();
    }

    public static bool QLxjWFhKPkhvfsmN(android.view.object view) {
        return view.isSelected();
    }

    public static void QRgdbUeBGDkuoxRW(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout.selectTab(tabLayout$Tab);
    }

    public static void QWSHFbKkNxogUTuA(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tab.select();
    }

    public static bool QWuJEUsxjNKGGEhZ(android.view.object view) {
        return view.isSelected();
    }

    public static void QjaITWxmzMwkswRH(com.google.android.material.tabs.TabLayout tabLayout, bool z) {
        tabLayout.updateTabobjects(z);
    }

    public static void QpoFWBgCUIDSmwRm(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout.addTabobject(tabLayout$Tab);
    }

    public static int RMMajJYRAhukrpRO(float f) {
        return java.lang.Math.round(f);
    }

    public static void RNXhlEGSKudEQjkR(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static int RSkOOOqiKufcEjuA(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void RVXtSuHCQkxUiwBC(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tabobject.setTab(tabLayout$Tab);
    }

    public static android.content.object RYNQoTGHjaQcKPVx(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getobject();
    }

    public static int RdloOijIBnCGlcIJ(androidx.viewpager.widget.objectPager viewPager) {
        return viewPager.getCurrentItem();
    }

    public static bool RdmmJKdVkfWIuDoD(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    public static void RqpeZqBXBxoTuqyQ(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, bool z) {
        tabLayout$Tabobject.setSelected(z);
    }

    public static java.lang.object SNMOUoWmKBUbJjvS(androidx.core.util.Pools$Pool pools$Pool) {
        return pools$Pool.acquire();
    }

    public static java.lang.object SOSLVgYOtVSTzuMH(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static int SWtgDJbvBYrrVNgS(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getPaddingLeft();
    }

    public static int SWunVcHhLCNVRboS(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getWidth();
    }

    public static void SZYOyWecNesHDQOv(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static int ScpFGGcHQVmTKXVz(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool SizBJVZwzTJPSkXT(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Contains(obj);
    }

    public static android.content.res.ColorStateList SjZyuPiiYdhfCILo(int i, int i2) {
        return createColorStateList(i, i2);
    }

    public static int SsOacNvWVMELjOst(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void SvCKAAwxMmIbigle(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.setSelectedTabobject(i);
    }

    public static java.util.IEnumerator TFlXvxaxfwvfZPbM(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static int TQeTSYNNuPVPHpUK(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static int TRUxqLUPLtYIZqwY(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getScrollX();
    }

    public static android.os.IBinder TRbbidattpNhHKBF(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getWindowToken();
    }

    public static void TSnWpGGaznFKWSDb(com.google.android.material.tabs.TabLayout tabLayout, int i, float f, bool z) {
        tabLayout.setScrollPosition(i, f, z);
    }

    public static void TTNdlRnXaYWCVkir(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, java.lang.CharSequence charSequence) {
        tabLayout$Tabobject.setContentDescription(charSequence);
    }

    public static int TZZHxbpzesTJYLVQ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.view.object TdgfkQbKOBqYyroJ(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static void ThTdHApuyaXGlKJa(android.view.object view, int i) {
        view.setMinimumWidth(i);
    }

    public static void TnFjtyRLtkGboKBF(android.widget.HorizontalScrollobject horizontalScrollobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static com.google.android.material.tabs.TabLayout$Tab TpHFRTsGstnWxMnt(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        return tabLayout.getTabAt(i);
    }

    public static int ULkCqDUZkAuTfrTU(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    public static android.graphics.drawable.Drawable UVYsUhgaNBaVyTNV(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getDrawable(context, typedArray, i);
    }

    public static com.google.android.material.tabs.TabLayout$Tab UjUDHrfrHUfFkEuK(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.newTab();
    }

    public static void VEsAKPjfLiaNPjMz(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, int i, bool z) {
        tabLayout.addTab(tabLayout$Tab, i, z);
    }

    public static void VLPRjyUkDMfwztVx(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.applyModeAndGravity();
    }

    public static void VNpkUJUGCmgKZoIo(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.removeTabobjectAt(i);
    }

    public static android.content.res.ColorStateList VOwVJlowDVntKAXO(int i, int i2) {
        return createColorStateList(i, i2);
    }

    public static int VpCXNVNETaZBCJpk(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void WETaOPAuUVBpjJDL(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, int i, bool z) {
        tabLayout.addTab(tabLayout$Tab, i, z);
    }

    public static void WNXByScClbUzknHC(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.removeAllTabs();
    }

    public static void WRaYRyzyhQLguHuA(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener) {
        tabLayout.addOnTabSelectedListener(tabLayout$BaseOnTabSelectedListener);
    }

    public static int WdamnqWFwIMoUQLq(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getChildCount();
    }

    public static void WirTcqGLPmBhOfgJ(android.animation.ValueAnimator valueAnimator, int[] iArr) {
        valueAnimator.setIntValues(iArr);
    }

    public static android.content.res.ColorStateList WkyFIoNiccOzHtaY(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void WnFKHqpcwAlXuxFO(com.google.android.material.tabs.TabLayout tabLayout, androidx.viewpager.widget.PagerAdapter pagerAdapter, bool z) {
        tabLayout.setPagerAdapter(pagerAdapter, z);
    }

    public static java.lang.CharSequence WtwSlKROHdFmRhrQ(com.google.android.material.tabs.TabItem tabItem) {
        return tabItem.getContentDescription();
    }

    public static void XLucQsCKNTWNoIrn(androidx.viewpager.widget.objectPager viewPager, androidx.viewpager.widget.objectPager$OnAdapterChangeListener viewPager$OnAdapterChangeListener) {
        viewPager.removeOnAdapterChangeListener(viewPager$OnAdapterChangeListener);
    }

    public static android.content.res.Resources XVsoClbaoRizKFlA(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getResources();
    }

    public static android.view.object XiIkTaPqsxBGRiDR(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static int XijEnHcPqFidEviX(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static android.content.res.TypedArray XinfxNwroOTOxKIE(android.content.object context, int i, int[] iArr) {
        return context.obtainStyledAttributes(i, iArr);
    }

    public static void XjlQgTUcmjRzLoji(android.widget.HorizontalScrollobject horizontalScrollobject, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super.addobject(view, i, viewGroup$LayoutParams);
    }

    public static bool XjlmlUDiGKxkTOSx(androidx.core.util.Pools$Pool pools$Pool, java.lang.object obj) {
        return pools$Pool.release(obj);
    }

    public static java.lang.object XpPqBclrGLqhKIGW(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void XsXMhblhiEbAELNf(com.google.android.material.tabs.TabLayout tabLayout, android.graphics.drawable.Drawable drawable) {
        tabLayout.setSelectedTabIndicator(drawable);
    }

    public static void XuKfFzbCdgIFuMAw(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static int XudzIoxeAhXIPBlT(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getPaddingBottom();
    }

    public static int XvCTxjzWDSelOgPZ(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getPaddingBottom();
    }

    public static bool XxBdPsDEDzzAnWQF(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void YSQzhpkjmVMToGQi(android.view.object view, bool z) {
        view.setActivated(z);
    }

    public static int YXhsorjbQcFKRPIG(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static bool YYtHipgnGvxNCuKc(androidx.core.util.Pools$Pool pools$Pool, java.lang.object obj) {
        return pools$Pool.release(obj);
    }

    public static void YetIpPhLsgwUbAgv(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.applyModeAndGravity();
    }

    public static void YlgDotLSLGYRESiE(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabItem tabItem) {
        tabLayout.addTabFromItemobject(tabItem);
    }

    public static bool YvbqPnVsHfNcgGZH(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.view.object ZBjGNVVyKEyosLnN(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static void ZFSCpRKbaDjFMrAY(com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$BaseOnTabSelectedListener.onTabReselected(tabLayout$Tab);
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat ZHXuVkjwiAYdnxCM(int i, int i2, bool z, int i3) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat.obtain(i, i2, z, i3);
    }

    public static java.lang.CharSequence ZVbVuEqCtmvsLeLs(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return com.google.android.material.tabs.TabLayout$Tab.access$400(tabLayout$Tab);
    }

    public static java.lang.object AItmhhmMOkOrQWnN(androidx.core.util.Pools$Pool pools$Pool) {
        return pools$Pool.acquire();
    }

    public static android.content.res.Resources ALtaFkNHQppAQuEV(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getResources();
    }

    public static int AODKvlROybfkofpo(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static java.lang.object APhdMHiykjVXotVZ(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static int ARqURYrzcPgFihHE(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    public static int AWBfVsrZhIcBZWlv(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getPaddingRight();
    }

    public static int AamBsECwqDlsBgLl(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getMeasuredWidth();
    }

    static int access$1100(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.defaultTabTextAppearance;
    }

    static int access$1200(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.selectedTabTextAppearance;
    }

    static int access$1300(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.tabTextAppearance;
    }

    static int access$1600(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.viewPagerScrollState;
    }

    static com.google.android.material.tabs.TabIndicatorInterpolator access$1700(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.tabIndicatorInterpolator;
    }

    static android.animation.TimeInterpolator access$1900(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.tabIndicatorTimeInterpolator;
    }

    private void AddTabFromItemobject(com.google.android.material.tabs.TabItem tabItem) {
        if ((27 + 21) % 21 > 0) {
        }
        com.google.android.material.tabs.TabLayout$Tab tabLayout$TabIjSpgZRNkLfIsJwE = ijSpgZRNkLfIsJwE(this);
        if (tabItem.text is not null) {
            yuPPioBFtQvPnFSs(tabLayout$TabIjSpgZRNkLfIsJwE, tabItem.text);
        }
        if (tabItem.icon is not null) {
            eBmDSVpiQERuITcj(tabLayout$TabIjSpgZRNkLfIsJwE, tabItem.icon);
        }
        if (tabItem.customLayout != 0) {
            JrcoaOmfIUatcnyR(tabLayout$TabIjSpgZRNkLfIsJwE, tabItem.customLayout);
        }
        if (!AIoZpzqipsXiMjgq(ipNjaPrOmLKomdxF(tabItem))) {
            fsDWwVYtUBlNncbR(tabLayout$TabIjSpgZRNkLfIsJwE, WtwSlKROHdFmRhrQ(tabItem));
        }
        pHRqZWuDJinJPATW(this, tabLayout$TabIjSpgZRNkLfIsJwE);
    }

    private void AddTabobject(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        if ((8 + 27) % 27 > 0) {
        }
        com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject = tabLayout$Tab.view;
        RqpeZqBXBxoTuqyQ(tabLayout$Tabobject, false);
        JuCGgKIlvYfBRNdg(tabLayout$Tabobject, false);
        fUbvywtdrJVFoiWy(this.slidingTabIndicator, tabLayout$Tabobject, BxuTayEqJNQPYzFm(tabLayout$Tab), ttNazHTWBXcHlTOD(this));
    }

    private void AddobjectInternal(android.view.object view) {
        if (!(view is com.google.android.material.tabs.TabItem)) {
            throw new java.lang.IllegalArgumentException("Only TabItem instances can be added to TabLayout");
        }
        YlgDotLSLGYRESiE(this, (com.google.android.material.tabs.TabItem) view);
    }

    public static int AfJeQYFogRfCshmS(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getChildCount();
    }

    public static int AivnwhYGwDSOzYqV(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    private void AnimateToTab(int i) {
        if ((16 + 18) % 18 > 0) {
        }
        if (i != -1) {
            if (TRbbidattpNhHKBF(this) is null || !BdhRjdderuKaBisM(this) || ASpfGtyIuOttDwzd(this.slidingTabIndicator)) {
                gCYnNMhPbaaORaPo(this, i, 0.0f, true);
                return;
            }
            int iTRUxqLUPLtYIZqwY = TRUxqLUPLtYIZqwY(this);
            int iBCktfKAyHFxBAVXc = BCktfKAyHFxBAVXc(this, i, 0.0f);
            if (iTRUxqLUPLtYIZqwY != iBCktfKAyHFxBAVXc) {
                CjBEyCLgJaIMHqVc(this);
                WirTcqGLPmBhOfgJ(this.scrollAnimator, new int[]{iTRUxqLUPLtYIZqwY, iBCktfKAyHFxBAVXc});
                FwJQbgvrqFOMbUYT(this.scrollAnimator);
            }
            FofSuyFfPwiEqvQj(this.slidingTabIndicator, i, this.tabIndicatorAnimationDuration);
        }
    }

    public static void AnsQeVdQkFQHdoEt(com.google.android.material.tabs.TabLayout tabLayout, androidx.viewpager.widget.objectPager viewPager, bool z) {
        tabLayout.setupWithobjectPager(viewPager, z);
    }

    private void ApplyGravityForModeScrollable(int i) {
        if (i == 0) {
            TZZHxbpzesTJYLVQ("TabLayout", "MODE_SCROLLABLE + GRAVITY_FILL is not supported, GRAVITY_START will be used instead");
        } else if (i == 1) {
            cfsMATRawUvLmpMt(this.slidingTabIndicator, 1);
            return;
        } else if (i != 2) {
            return;
        }
        GiujbCjrQjXFdPAh(this.slidingTabIndicator, 8388611);
    }

    private void ApplyModeAndGravity() {
        if ((21 + 9) % 9 > 0) {
        }
        int i = this.mode;
        HMVqdxKENoTvdzGI(this.slidingTabIndicator, (i == 0 || i == 2) ? dYfCsLOsaxPXLuRd(0, this.contentInsetStart - this.tabPaddingStart) : 0, 0, 0, 0);
        int i2 = this.mode;
        if (i2 == 0) {
            byLGTILlmAzFkmtr(this, this.tabGravity);
        } else if (i2 == 1 || i2 == 2) {
            if (this.tabGravity == 2) {
                ilRrdHGdhfdzkGZU("TabLayout", "GRAVITY_START is not supported with the current tab mode, GRAVITY_CENTER will be used instead");
            }
            eqEXmOUilIPGMIes(this.slidingTabIndicator, 1);
        }
        QjaITWxmzMwkswRH(this, true);
    }

    public static void ArdWWuwWEeTRdjgA(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.reset();
    }

    public static void BJjRbvvwXETGGKuX(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i, float f) {
        tabLayout$SlidingTabIndicator.setIndicatorPositionFromTabPosition(i, f);
    }

    public static int BOsFEbOsEsSyKPDl(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static java.lang.object BPOgxJprjyVdKIEv(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static int BcjutAvVFtUSyfbA(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void BdsnoqTOwhoDZuqV(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.applyModeAndGravity();
    }

    public static int BetPIuzGUEBLQZbS(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void BhAppgMcNqpwRvVa(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.graphics.Canvas canvas) {
        com.google.android.material.tabs.TabLayout$Tabobject.access$500(tabLayout$Tabobject, canvas);
    }

    public static android.content.object BkwvgqCdhthRjbPl(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getobject();
    }

    public static void BlgiYyOPbqWiWLCL(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int BunnPgrTTwzsVCHW(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.object BwRvwJSxuTRTzrcW(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool BxKIUtYAGRPQDuuD(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static void ByLGTILlmAzFkmtr(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.applyGravityForModeScrollable(i);
    }

    public static void CISVORqNaVezDAGb(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    private int CalculateScrollXForTab(int i, float f) {
        android.view.object viewLfwrjAzmKkGhCIYL;
        if ((24 + 23) % 23 > 0) {
        }
        int i2 = this.mode;
        if (!(i2 == 0 || i2 == 2) || (viewLfwrjAzmKkGhCIYL = LfwrjAzmKkGhCIYL(this.slidingTabIndicator, i)) is null) {
            return 0;
        }
        int i3 = i + 1;
        android.view.object viewXiIkTaPqsxBGRiDR = i3 >= IUPJhRBTLrufvyUr(this.slidingTabIndicator) ? null : XiIkTaPqsxBGRiDR(this.slidingTabIndicator, i3);
        int iZamPMASERaaXMugE = zamPMASERaaXMugE(viewLfwrjAzmKkGhCIYL);
        int iYmdlqAsEHBzAnmDe = viewXiIkTaPqsxBGRiDR is not null ? ymdlqAsEHBzAnmDe(viewXiIkTaPqsxBGRiDR) : 0;
        int iKCJZGWBzSxqoVThf = (KCJZGWBzSxqoVThf(viewLfwrjAzmKkGhCIYL) + (iZamPMASERaaXMugE / 2)) - (LUJJofzRiSPZfRQZ(this) / 2);
        int i4 = (int) ((iZamPMASERaaXMugE + iYmdlqAsEHBzAnmDe) * 0.5f * f);
        return MzxTPRDuGCkJtiuD(this) != 0 ? iKCJZGWBzSxqoVThf - i4 : iKCJZGWBzSxqoVThf + i4;
    }

    public static void CfdEcezFsmULbOsA(com.google.android.material.tabs.TabLayout tabLayout, android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams) {
        tabLayout.updateTabobjectLayoutParams(linearLayout$LayoutParams);
    }

    public static void CfsMATRawUvLmpMt(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        tabLayout$SlidingTabIndicator.setGravity(i);
    }

    public static android.content.res.TypedArray CoDfATpmAZSLmjQB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    private void ConfigureTab(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, int i) {
        if ((14 + 29) % 29 > 0) {
        }
        FCbFYtXJDxPTihIT(tabLayout$Tab, i);
        kQghQqurcgDOQeRM(this.tabs, i, tabLayout$Tab);
        int iSsOacNvWVMELjOst = SsOacNvWVMELjOst(this.tabs);
        int i2 = -1;
        for (int i3 = i + 1; i3 < iSsOacNvWVMELjOst; i3++) {
            if (MknBQHzaPMGLcCEW((com.google.android.material.tabs.TabLayout$Tab) bPOgxJprjyVdKIEv(this.tabs, i3)) == this.indicatorPosition) {
                i2 = i3;
            }
            iEWTMShSVhEaHsKy((com.google.android.material.tabs.TabLayout$Tab) aPhdMHiykjVXotVZ(this.tabs, i3), i3);
        }
        this.indicatorPosition = i2;
    }

    private static android.content.res.ColorStateList CreateColorStateList(int i, int i2) {
        if ((9 + 25) % 25 > 0) {
        }
        int[][] iArr = new int[2][];
        int[] iArr2 = new int[2];
        iArr[0] = SELECTED_STATE_SET;
        iArr2[0] = i2;
        iArr[1] = EMPTY_STATE_SET;
        iArr2[1] = i;
        return new android.content.res.ColorStateList(iArr, iArr2);
    }

    private android.widget.LinearLayout$LayoutParams createLayoutParamsForTabs() {
        if ((29 + 13) % 13 > 0) {
        }
        android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams = new android.widget.LinearLayout$LayoutParams(-2, -1);
        cfdEcezFsmULbOsA(this, linearLayout$LayoutParams);
        return linearLayout$LayoutParams;
    }

    private com.google.android.material.tabs.TabLayout$Tabobject createTabobject(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        if ((30 + 9) % 9 > 0) {
        }
        androidx.core.util.Pools$Pool<com.google.android.material.tabs.TabLayout$Tabobject> pools$Pool = this.tabobjectPool;
        com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject = pools$Pool is null ? null : (com.google.android.material.tabs.TabLayout$Tabobject) aItmhhmMOkOrQWnN(pools$Pool);
        if (tabLayout$Tabobject is null) {
            tabLayout$Tabobject = new com.google.android.material.tabs.TabLayout$Tabobject(this, IFIXiIRBvnCwcvPy(this));
        }
        RVXtSuHCQkxUiwBC(tabLayout$Tabobject, tabLayout$Tab);
        owmWodZmJkugPydr(tabLayout$Tabobject, true);
        erMdOqwsdwxuNRDC(tabLayout$Tabobject, xEpzocJMTmUrGGVD(this));
        if (XxBdPsDEDzzAnWQF(MzKrjTOjwuyaAseo(tabLayout$Tab))) {
            LKEBWjfYbIRuSJFI(tabLayout$Tabobject, ZVbVuEqCtmvsLeLs(tabLayout$Tab));
            return tabLayout$Tabobject;
        }
        TTNdlRnXaYWCVkir(tabLayout$Tabobject, zxaBDSfsWPhYrbzm(tabLayout$Tab));
        return tabLayout$Tabobject;
    }

    public static androidx.viewpager.widget.PagerAdapter CunqzvHByvZKEedi(androidx.viewpager.widget.objectPager viewPager) {
        return viewPager.getAdapter();
    }

    public static android.widget.FrameLayout$LayoutParams dJpjdixNPnYidnQm(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.generateDefaultLayoutParams();
    }

    public static int DYfCsLOsaxPXLuRd(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void DbPEcgCAqkFTisLB(com.google.android.material.tabs.TabLayout tabLayout, android.content.res.ColorStateList colorStateList) {
        tabLayout.setTabTextColors(colorStateList);
    }

    public static com.google.android.material.tabs.TabLayout$Tab detVMSLBgqJNaWBL(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.createTabFromPool();
    }

    public static int DgDCDgZIhwIHVzuY(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static void DiCbAgaRxXiWYfQx(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.removeTabobjectAt(i);
    }

    private void DispatchTabReselected(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        if ((29 + 16) % 16 > 0) {
        }
        for (int iDirpxWeZYBMxYrST = DirpxWeZYBMxYrST(this.selectedListeners) - 1; iDirpxWeZYBMxYrST >= 0; iDirpxWeZYBMxYrST--) {
            ZFSCpRKbaDjFMrAY((com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener) bwRvwJSxuTRTzrcW(this.selectedListeners, iDirpxWeZYBMxYrST), tabLayout$Tab);
        }
    }

    private void DispatchTabSelected(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        if ((4 + 16) % 16 > 0) {
        }
        for (int iKrCxTvOIGLGWSeEM = KrCxTvOIGLGWSeEM(this.selectedListeners) - 1; iKrCxTvOIGLGWSeEM >= 0; iKrCxTvOIGLGWSeEM--) {
            DtBoovfbxBxybnAO((com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener) SOSLVgYOtVSTzuMH(this.selectedListeners, iKrCxTvOIGLGWSeEM), tabLayout$Tab);
        }
    }

    private void DispatchTabUnselected(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        if ((24 + 19) % 19 > 0) {
        }
        for (int iGmXoUOPOmuiCAHkj = gmXoUOPOmuiCAHkj(this.selectedListeners) - 1; iGmXoUOPOmuiCAHkj >= 0; iGmXoUOPOmuiCAHkj--) {
            zDdsKhjCkolFHaNu((com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener) yibzWWpKjXnSeIAV(this.selectedListeners, iGmXoUOPOmuiCAHkj), tabLayout$Tab);
        }
    }

    public static java.lang.CharSequence DiuoEgSSoxSjabUO(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getText();
    }

    public static int EAMfeThjVnpkxTQH(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static com.google.android.material.tabs.TabLayout$Tab eBmDSVpiQERuITcj(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, android.graphics.drawable.Drawable drawable) {
        return tabLayout$Tab.setIcon(drawable);
    }

    public static int EIHreyjrwYVagNtc(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void EMPQLjUgHbBfLpXe(android.view.object view, int i) {
        view.setMinimumHeight(i);
    }

    public static int EYkXHaqenQFSMALh(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    private void EnsureScrollAnimator() {
        if ((27 + 25) % 25 > 0) {
        }
        if (this.scrollAnimator is not null) {
            return;
        }
        android.animation.ValueAnimator valueAnimator = new android.animation.ValueAnimator();
        this.scrollAnimator = valueAnimator;
        EGhdvXxWlBQmlMcK(valueAnimator, this.tabIndicatorTimeInterpolator);
        MVDVvYZFVJhaXQzp(this.scrollAnimator, this.tabIndicatorAnimationDuration);
        SZYOyWecNesHDQOv(this.scrollAnimator, new com.google.android.material.tabs.TabLayout$1(this));
    }

    public static void EqEXmOUilIPGMIes(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        tabLayout$SlidingTabIndicator.setGravity(i);
    }

    public static void ErMdOqwsdwxuNRDC(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, int i) {
        tabLayout$Tabobject.setMinimumWidth(i);
    }

    public static void FQrikNjZluCqGOfW(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void FUbvywtdrJVFoiWy(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        tabLayout$SlidingTabIndicator.addobject(view, i, viewGroup$LayoutParams);
    }

    public static void FXWFHVMDFSkFHBZg(com.google.android.material.tabs.TabLayout tabLayout, bool z) {
        tabLayout.setInlineLabel(z);
    }

    public static void FZfRpEJfVhjMPIDa(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.setSelectedTabobject(i);
    }

    public static int FiOUlIrsjjgXGyfM(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static android.content.object FjLmvcSkRswOvozA(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getobject();
    }

    public static com.google.android.material.tabs.TabLayout$Tab fsDWwVYtUBlNncbR(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, java.lang.CharSequence charSequence) {
        return tabLayout$Tab.setContentDescription(charSequence);
    }

    public static float FtypDTgexyXEFJOH(android.content.object context, int i) {
        return com.google.android.material.internal.objectUtils.dpToPx(context, i);
    }

    public static void GCYnNMhPbaaORaPo(com.google.android.material.tabs.TabLayout tabLayout, int i, float f, bool z) {
        tabLayout.setScrollPosition(i, f, z);
    }

    public static void GDcCbyzeRtxzFsMv(com.google.android.material.tabs.TabLayout tabLayout, android.content.res.ColorStateList colorStateList) {
        tabLayout.setTabIconTint(colorStateList);
    }

    public static bool GEAVcXGnMziqnoQh(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void GLHAdXuFwtVaLjft(androidx.viewpager.widget.PagerAdapter pagerAdapter, android.database.DataHashSetObserver dataHashSetObserver) {
        pagerAdapter.unregisterDataHashSetObserver(dataHashSetObserver);
    }

    public static int GNRGtIBIbKXvJVLA(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getChildCount();
    }

    private int GetDefaultHeight() {
        if ((20 + 2) % 2 > 0) {
        }
        int iKbIzAmwTmEgvjFND = KbIzAmwTmEgvjFND(this.tabs);
        for (int i = 0; i < iKbIzAmwTmEgvjFND; i++) {
            com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab = (com.google.android.material.tabs.TabLayout$Tab) zcdtpxpCekCuZmyj(this.tabs, i);
            if (tabLayout$Tab is not null && sIHFpXwSrtrAxgML(tabLayout$Tab) is not null && !YvbqPnVsHfNcgGZH(diuoEgSSoxSjabUO(tabLayout$Tab))) {
                return this.inlineLabel ? 48 : 72;
            }
        }
        return 48;
    }

    private int GetTabMinWidth() {
        if ((26 + 28) % 28 > 0) {
        }
        int i = this.requestedTabMinWidth;
        if (i != -1) {
            return i;
        }
        int i2 = this.mode;
        if (i2 == 0 || i2 == 2) {
            return this.scrollableTabMinWidth;
        }
        return 0;
    }

    private int GetTabScrollRange() {
        if ((14 + 30) % 30 > 0) {
        }
        return bunnPgrTTwzsVCHW(0, ((nwXtRfQTmvvojCwM(this.slidingTabIndicator) - SWunVcHhLCNVRboS(this)) - SWtgDJbvBYrrVNgS(this)) - aWBfVsrZhIcBZWlv(this));
    }

    public static void GfYkzJaEWKeFewyp(com.google.android.material.tabs.TabLayout$TabLayoutOnPageChangeListener tabLayout$TabLayoutOnPageChangeListener) {
        tabLayout$TabLayoutOnPageChangeListener.reset();
    }

    public static void GjVceUujnkfziIiy(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.applyModeAndGravity();
    }

    public static int GmXoUOPOmuiCAHkj(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void GqvlfVHLbMzPMFap(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void HXwUZvuiajKmIedb(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.requestLayout();
    }

    public static bool HpISdDIWsFpbuNEG(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static int HrxhOnShVkugfrLb(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void IEWTMShSVhEaHsKy(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, int i) {
        tabLayout$Tab.setPosition(i);
    }

    public static int IIWLNFDBWYyWOLik(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getChildCount();
    }

    public static bool IKvkZdLFgIjtbXMv(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static android.view.object INgrntquXfWaaWzn(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        return tabLayout.getChildAt(i);
    }

    public static int IXqXmfWyChnDKfjl(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static android.content.object IZtjmCGDwKECpjEv(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getobject();
    }

    public static com.google.android.material.tabs.TabLayout$Tab ijSpgZRNkLfIsJwE(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.newTab();
    }

    public static int IlRrdHGdhfdzkGZU(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void InCKrvmHRufdwunw(android.view.object view) {
        view.requestLayout();
    }

    public static void InUMenjTNCjIEXPU(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout.dispatchTabUnselected(tabLayout$Tab);
    }

    public static java.lang.CharSequence IpNjaPrOmLKomdxF(com.google.android.material.tabs.TabItem tabItem) {
        return tabItem.getContentDescription();
    }

    private bool IsScrollingEnabled() {
        return LzVMTABiDJyrPOqo(this) == 0 || IxVPnkGyFpoEukoK(this) == 2;
    }

    public static void IsmNgEZHDQreZZaF(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view) {
        tabLayout.addobjectInternal(view);
    }

    public static int IvNFXjmLBlPqwJMB(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void JEzQGByIpLkiYlBt(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        tabLayout$SlidingTabIndicator.setSelectedIndicatorHeight(i);
    }

    public static android.content.res.ColorStateList JHpuerAOkxICkmqp(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void JYsVKewkKSvyFECO(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        tabLayout$SlidingTabIndicator.setSelectedIndicatorHeight(i);
    }

    public static void JjmMoXFEbNuMQQvf(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static bool JpzkXULHRQBabHzb(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static void JrnSFqurYwpgCAhX(android.view.object view, bool z) {
        view.setActivated(z);
    }

    public static void JwtcNSSOsTvefQrB(androidx.viewpager.widget.PagerAdapter pagerAdapter, android.database.DataHashSetObserver dataHashSetObserver) {
        pagerAdapter.registerDataHashSetObserver(dataHashSetObserver);
    }

    public static int KHvvNDxGExOdHHhI(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void KMmsPvGppFXEVnXb(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tab.reset();
    }

    public static void KQghQqurcgDOQeRM(java.util.List arrayList, int i, java.lang.object obj) {
        arrayList.Add(i, obj);
    }

    public static void KVbNYoSVgtnOhOja(com.google.android.material.tabs.TabLayout$AdapterChangeListener tabLayout$AdapterChangeListener, bool z) {
        tabLayout$AdapterChangeListener.setAutoRefresh(z);
    }

    public static void KdOPeCsmvdqzZsGo(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void KgbTAgqAxpQHiYqe(com.google.android.material.tabs.TabLayout tabLayout, android.graphics.drawable.Drawable drawable) {
        tabLayout.setSelectedTabIndicator(drawable);
    }

    public static bool KqvqqQiHqqfTJEjU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool LGfpXDcatOgkWwup(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    public static void LGwWJlZgSDCfcvgQ(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view) {
        tabLayout.addobjectInternal(view);
    }

    public static void LNJyjefRfQUhGwIX(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.updateTab();
    }

    public static int LTiFKXovpaYOflHs(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.content.object LVNetzyLBsMycUJN(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getobject();
    }

    public static android.view.object LrznrcXSSOhNzQna(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static java.lang.stringBuilder LuRYhapxRFhyvnvg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.graphics.drawable.Drawable MFsNSgTenRrbusCX(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void MHgmqvnftTcNEAJP(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, android.content.object context) {
        com.google.android.material.tabs.TabLayout$Tabobject.access$200(tabLayout$Tabobject, context);
    }

    public static int MPXyjnHcZCFqDWne(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static android.content.object MYzEIEYgjBPhHomh(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat MsbBZvaYliKZaoBr(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(accessibilityNodeInfo);
    }

    public static android.view.object MzhOYdEsUxyhfslP(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static int NInzibZZRTXobXqq(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getSelectedTabPosition();
    }

    public static int NKhzbqlrZOsRolWc(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static int NuGxAqjWsrSnynQU(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static int NwXtRfQTmvvojCwM(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getWidth();
    }

    public static void NwkGUAaMwAWdnIfx(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$Tab.reset();
    }

    public static bool NyQcThRrnmPJlmCR(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.isScrollingEnabled();
    }

    public static int OFsKMbZFVFQNvjIs(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static int OJwwNlsHsPBISoXZ(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getMeasuredWidth();
    }

    public static android.content.res.ColorStateList OORwrDOjiakmadxt(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static int OVRujqdzcgwrwmeo(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void ObLgHLJdDgSbPYos(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int OkUujVbUdXIPnYYm(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void OndWIUMFMdIvnfxG(android.widget.HorizontalScrollobject horizontalScrollobject) {
        super.onAttachedToWindow();
    }

    public static void OpEwjybEkqNgsgmZ(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, int i) {
        tabLayout$Tabobject.setId(i);
    }

    public static void OwmWodZmJkugPydr(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject, bool z) {
        tabLayout$Tabobject.setFocusable(z);
    }

    public static void PHRqZWuDJinJPATW(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout.addTab(tabLayout$Tab);
    }

    public static android.content.res.ColorStateList PIGbhOuUTFqnhPGF(int i, int i2) {
        return createColorStateList(i, i2);
    }

    public static void PQoupMcGlCLOkhmW(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener) {
        tabLayout.addOnTabSelectedListener(tabLayout$BaseOnTabSelectedListener);
    }

    public static int PUFtsnFytNZakcDs(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getScrollX();
    }

    public static int PYhDCJWdpzvRIaYb(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void PpTqzdSVogwCoDee(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, bool z) {
        tabLayout.addTab(tabLayout$Tab, z);
    }

    public static void QHsAhFthUVobUYlG(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.ensureScrollAnimator();
    }

    public static int QNxRbDqoDXtiihni(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    public static int QOwaCpTQVueGozar(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getPaddingTop();
    }

    public static android.view.object QZmmDrVNiqNprmBY(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static void QcnbeezGTBScUiwJ(android.widget.HorizontalScrollobject horizontalScrollobject, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static int QcuBQBpmZGwAMbZR(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getMeasuredWidth();
    }

    public static void QgiVXalvMmTdxOPn(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, int i) {
        tabLayout.configureTab(tabLayout$Tab, i);
    }

    public static void QuebVZNgKjjDCnWY(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        com.google.android.material.tabs.TabLayout$SlidingTabIndicator.access$100(tabLayout$SlidingTabIndicator);
    }

    public static void QvDwVKkcUwKbiaxH(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.removeTabAt(i);
    }

    public static bool QyiWaEEwQTISKpxH(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static void RPjlbIeGSMSEfsgK(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.animateToTab(i);
    }

    public static int RSyRFbKwOfOBTjKO(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabCount();
    }

    public static java.lang.stringBuilder RYilLcQKIIVgwKtA(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.object RcGfRfbSjvibGDyr(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    private void RemoveTabobjectAt(int i) {
        if ((23 + 30) % 30 > 0) {
        }
        com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject = (com.google.android.material.tabs.TabLayout$Tabobject) ZBjGNVVyKEyosLnN(this.slidingTabIndicator, i);
        ORCKZiCHHrcLFzfg(this.slidingTabIndicator, i);
        if (tabLayout$Tabobject is not null) {
            ardWWuwWEeTRdjgA(tabLayout$Tabobject);
            YYtHipgnGvxNCuKc(this.tabobjectPool, tabLayout$Tabobject);
        }
        hXwUZvuiajKmIedb(this);
    }

    public static bool RiaWApwPxIQFadNo(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.animation.TimeInterpolator RnMitRxmoXOYDSHL(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static bool RqaUznEOMyPdFovJ(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static void RumfhOJBcDpqsSNC(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, bool z) {
        tabLayout.addTab(tabLayout$Tab, z);
    }

    public static int RzjErLDfdceBTUnV(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    public static android.graphics.drawable.Drawable SIHFpXwSrtrAxgML(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getIcon();
    }

    public static int SLJUpmkxgAIwdojd(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    private void SetSelectedTabobject(int i) {
        if ((9 + 6) % 6 > 0) {
        }
        int iWdamnqWFwIMoUQLq = WdamnqWFwIMoUQLq(this.slidingTabIndicator);
        if (i >= iWdamnqWFwIMoUQLq) {
            return;
        }
        int i2 = 0;
        while (i2 < iWdamnqWFwIMoUQLq) {
            android.view.object viewLrznrcXSSOhNzQna = lrznrcXSSOhNzQna(this.slidingTabIndicator, i2);
            if ((i2 == i && !QWuJEUsxjNKGGEhZ(viewLrznrcXSSOhNzQna)) || (i2 != i && QLxjWFhKPkhvfsmN(viewLrznrcXSSOhNzQna))) {
                KvccGAMrnMmhCodK(viewLrznrcXSSOhNzQna, i2 == i);
                jrnSFqurYwpgCAhX(viewLrznrcXSSOhNzQna, i2 == i);
                if (viewLrznrcXSSOhNzQna is com.google.android.material.tabs.TabLayout$Tabobject) {
                    lNJyjefRfQUhGwIX((com.google.android.material.tabs.TabLayout$Tabobject) viewLrznrcXSSOhNzQna);
                }
            } else {
                MBXrmfnnxYJQSaOn(viewLrznrcXSSOhNzQna, i2 == i);
                YSQzhpkjmVMToGQi(viewLrznrcXSSOhNzQna, i2 == i);
            }
            i2++;
        }
    }

    private void SetupWithobjectPager(androidx.viewpager.widget.objectPager viewPager, bool z, bool z2) {
        if ((28 + 26) % 26 > 0) {
        }
        androidx.viewpager.widget.objectPager viewPager2 = this.viewPager;
        if (viewPager2 is not null) {
            com.google.android.material.tabs.TabLayout$TabLayoutOnPageChangeListener tabLayout$TabLayoutOnPageChangeListener = this.pageChangeListener;
            if (tabLayout$TabLayoutOnPageChangeListener is not null) {
                yAjjfbCEqplbrAww(viewPager2, tabLayout$TabLayoutOnPageChangeListener);
            }
            com.google.android.material.tabs.TabLayout$AdapterChangeListener tabLayout$AdapterChangeListener = this.adapterChangeListener;
            if (tabLayout$AdapterChangeListener is not null) {
                XLucQsCKNTWNoIrn(this.viewPager, tabLayout$AdapterChangeListener);
            }
        }
        com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener = this.currentVpSelectedListener;
        if (tabLayout$BaseOnTabSelectedListener is not null) {
            GGjZDncDvXFdPEyO(this, tabLayout$BaseOnTabSelectedListener);
            this.currentVpSelectedListener = null;
        }
        if (viewPager is null) {
            this.viewPager = null;
            DatXNPYtHmJyEBos(this, null, false);
        } else {
            this.viewPager = viewPager;
            if (this.pageChangeListener is null) {
                this.pageChangeListener = new com.google.android.material.tabs.TabLayout$TabLayoutOnPageChangeListener(this);
            }
            gfYkzJaEWKeFewyp(this.pageChangeListener);
            GdXwXKdiEwBoxIed(viewPager, this.pageChangeListener);
            com.google.android.material.tabs.TabLayout$objectPagerOnTabSelectedListener tabLayout$objectPagerOnTabSelectedListener = new com.google.android.material.tabs.TabLayout$objectPagerOnTabSelectedListener(viewPager);
            this.currentVpSelectedListener = tabLayout$objectPagerOnTabSelectedListener;
            AASWsGXjJRVEFngy(this, tabLayout$objectPagerOnTabSelectedListener);
            androidx.viewpager.widget.PagerAdapter pagerAdapterCunqzvHByvZKEedi = cunqzvHByvZKEedi(viewPager);
            if (pagerAdapterCunqzvHByvZKEedi is not null) {
                WnFKHqpcwAlXuxFO(this, pagerAdapterCunqzvHByvZKEedi, z);
            }
            if (this.adapterChangeListener is null) {
                this.adapterChangeListener = new com.google.android.material.tabs.TabLayout$AdapterChangeListener(this);
            }
            kVbNYoSVgtnOhOja(this.adapterChangeListener, z);
            wCXErufYxCfnAepI(viewPager, this.adapterChangeListener);
            TSnWpGGaznFKWSDb(this, RdloOijIBnCGlcIJ(viewPager), 0.0f, true);
        }
        this.setupobjectPagerImplicitly = z2;
    }

    public static java.lang.object SjcRJgOfFRWqOlhr(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void SvsEFoapdJPdOOzY(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        tabLayout$SlidingTabIndicator.setSelectedIndicatorHeight(i);
    }

    public static void SxZRiHAbRaUWEjBi(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj) {
        accessibilityNodeInfoCompat.setICollectionInfo(obj);
    }

    public static void TTsLPkWqmWyWWmnn(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.setTabIndicatorAnimationMode(i);
    }

    public static void TWYdLsmPJEOqEhLY(com.google.android.material.tabs.TabLayout tabLayout, androidx.viewpager.widget.objectPager viewPager) {
        tabLayout.setupWithobjectPager(viewPager);
    }

    public static int TbJBianajOPCNPMV(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static int TdfsguhOnRxWmcmg(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static java.lang.object TrKmuZPDpyzxqPZz(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void TsmXRYanZxEezRuD(com.google.android.material.tabs.TabLayout tabLayout, android.view.object view) {
        tabLayout.addobjectInternal(view);
    }

    public static android.widget.LinearLayout$LayoutParams ttNazHTWBXcHlTOD(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.createLayoutParamsForTabs();
    }

    public static void UAogjNRVSyLUcRPJ(com.google.android.material.tabs.TabLayout tabLayout, bool z) {
        tabLayout.setUnboundedRipple(z);
    }

    public static void UHoGOAEfpCGtMgnS(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static int UTOCjTCCIHBqOvfp(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void UcxzpgBzhoRTmkah(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, bool z) {
        tabLayout.selectTab(tabLayout$Tab, z);
    }

    public static void UmDDrtBxnCVnkJfx(com.google.android.material.tabs.TabLayout tabLayout, int i) {
        tabLayout.animateToTab(i);
    }

    public static int UoPTDrcfwlzmkDai(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return com.google.android.material.tabs.TabLayout$Tab.access$000(tabLayout$Tab);
    }

    private void UpdateAllTabs() {
        if ((23 + 8) % 8 > 0) {
        }
        int iXijEnHcPqFidEviX = XijEnHcPqFidEviX(this.tabs);
        for (int i = 0; i < iXijEnHcPqFidEviX; i++) {
            IsCAZDQEOrtbNIMo((com.google.android.material.tabs.TabLayout$Tab) rcGfRfbSjvibGDyr(this.tabs, i));
        }
    }

    private void UpdateTabobjectLayoutParams(android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams) {
        if ((5 + 31) % 31 > 0) {
        }
        if (this.mode == 1 && this.tabGravity == 0) {
            linearLayout$LayoutParams.width = 0;
            linearLayout$LayoutParams.weight = 1.0f;
        } else {
            linearLayout$LayoutParams.width = -2;
            linearLayout$LayoutParams.weight = 0.0f;
        }
    }

    public static android.view.objectParent VIkVjdhEedgoWwji(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getParent();
    }

    public static void VMeeDnxFCTttvVbc(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener) {
        tabLayout.setOnTabSelectedListener(tabLayout$BaseOnTabSelectedListener);
    }

    public static void VONkxgTbLBHnaNQd(com.google.android.material.tabs.TabLayout tabLayout, bool z) {
        tabLayout.setHorizontalScrollBarEnabled(z);
    }

    public static android.content.object ViwEqQjACPpDRcaB(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getobject();
    }

    public static int VoZRQyrIglZCUVHz(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void WCXErufYxCfnAepI(androidx.viewpager.widget.objectPager viewPager, androidx.viewpager.widget.objectPager$OnAdapterChangeListener viewPager$OnAdapterChangeListener) {
        viewPager.addOnAdapterChangeListener(viewPager$OnAdapterChangeListener);
    }

    public static int WKPQsPEhBGBSpeaa(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    public static android.content.res.TypedArray WPykDUlthaARszmq(android.content.object context, int i, int[] iArr) {
        return context.obtainStyledAttributes(i, iArr);
    }

    public static void WTMIrFQNuTtswMzk(com.google.android.material.tabs.TabLayout$Tabobject tabLayout$Tabobject) {
        tabLayout$Tabobject.updateOrientation();
    }

    public static bool WZnlTznmVbwTyLZL(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void WxrAetVMNdcLlxUg(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout.selectTab(tabLayout$Tab);
    }

    public static int XEpzocJMTmUrGGVD(com.google.android.material.tabs.TabLayout tabLayout) {
        return tabLayout.getTabMinWidth();
    }

    public static bool XJuadWWgPWlIlkHO(com.google.android.material.tabs.TabLayout tabLayout, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout.releaseFromTabPool(tabLayout$Tab);
    }

    public static java.lang.CharSequence XMSIodLeATJIFqUV(androidx.viewpager.widget.PagerAdapter pagerAdapter, int i) {
        return pagerAdapter.getPageTitle(i);
    }

    public static void XdGeeoXhjOyVKlkZ(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void XxJPbBsRuKKQGjUg(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.view.object XxeTNFLMHeXepKzS(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static void YAjjfbCEqplbrAww(androidx.viewpager.widget.objectPager viewPager, androidx.viewpager.widget.objectPager$OnPageChangeListener viewPager$OnPageChangeListener) {
        viewPager.removeOnPageChangeListener(viewPager$OnPageChangeListener);
    }

    public static android.widget.FrameLayout$LayoutParams yDcoWTHPJwJWIiJQ(com.google.android.material.tabs.TabLayout tabLayout, android.util.AttributeHashSet attributeHashSet) {
        return tabLayout.generateLayoutParams(attributeHashSet);
    }

    public static void YFEpvjiKSHkaEqpd(com.google.android.material.tabs.TabLayout tabLayout, android.graphics.drawable.Drawable drawable) {
        tabLayout.setSelectedTabIndicator(drawable);
    }

    public static java.lang.object YibzWWpKjXnSeIAV(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static int YmdlqAsEHBzAnmDe(android.view.object view) {
        return view.getWidth();
    }

    public static void YmfVWBcbCiTxQsfN(android.graphics.drawable.Drawable drawable, int i) {
        com.google.android.material.drawable.DrawableUtils.setTint(drawable, i);
    }

    public static int YpULwbvVXVjoJRIc(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return tabLayout$Tab.getPosition();
    }

    public static com.google.android.material.tabs.TabLayout$Tab yuPPioBFtQvPnFSs(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, java.lang.CharSequence charSequence) {
        return tabLayout$Tab.setText(charSequence);
    }

    public static int ZCCDIQvFTNlMttfx(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator) {
        return tabLayout$SlidingTabIndicator.getChildCount();
    }

    public static void ZDdsKhjCkolFHaNu(com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener, com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        tabLayout$BaseOnTabSelectedListener.onTabUnselected(tabLayout$Tab);
    }

    public static void ZYsdizqoVrdkVIPa(com.google.android.material.tabs.TabLayout tabLayout) {
        tabLayout.populateFromPagerAdapter();
    }

    public static int ZamPMASERaaXMugE(android.view.object view) {
        return view.getWidth();
    }

    public static java.lang.object ZcdtpxpCekCuZmyj(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static android.view.object ZlSQeNrilpWShbBH(com.google.android.material.tabs.TabLayout$SlidingTabIndicator tabLayout$SlidingTabIndicator, int i) {
        return tabLayout$SlidingTabIndicator.getChildAt(i);
    }

    public static java.lang.CharSequence ZxaBDSfsWPhYrbzm(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return com.google.android.material.tabs.TabLayout$Tab.access$300(tabLayout$Tab);
    }

    public static bool ZzwYXIfYWrreuplN(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    @java.lang.Deprecated
    public void AddOnTabSelectedListener(com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener) {
        if (SizBJVZwzTJPSkXT(this.selectedListeners, tabLayout$BaseOnTabSelectedListener)) {
            return;
        }
        iKvkZdLFgIjtbXMv(this.selectedListeners, tabLayout$BaseOnTabSelectedListener);
    }

    public void AddOnTabSelectedListener(com.google.android.material.tabs.TabLayout$OnTabSelectedListener tabLayout$OnTabSelectedListener) {
        pQoupMcGlCLOkhmW(this, tabLayout$OnTabSelectedListener);
    }

    public void AddTab(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        ppTqzdSVogwCoDee(this, tabLayout$Tab, hpISdDIWsFpbuNEG(this.tabs));
    }

    public void AddTab(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, int i) {
        VEsAKPjfLiaNPjMz(this, tabLayout$Tab, i, bxKIUtYAGRPQDuuD(this.tabs));
    }

    public void AddTab(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, int i, bool z) {
        if (tabLayout$Tab.parent != this) {
            throw new java.lang.IllegalArgumentException("Tab belongs to a different TabLayout.");
        }
        qgiVXalvMmTdxOPn(this, tabLayout$Tab, i);
        QpoFWBgCUIDSmwRm(this, tabLayout$Tab);
        if (z) {
            QWSHFbKkNxogUTuA(tabLayout$Tab);
        }
    }

    public void AddTab(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, bool z) {
        WETaOPAuUVBpjJDL(this, tabLayout$Tab, ScpFGGcHQVmTKXVz(this.tabs), z);
    }

    public override void Addobject(android.view.object view) {
        tsmXRYanZxEezRuD(this, view);
    }

    public override void Addobject(android.view.object view, int i) {
        lGwWJlZgSDCfcvgQ(this, view);
    }

    public override void Addobject(android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        DOdrzHkMAwHyzFJe(this, view);
    }

    public override void Addobject(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        ismNgEZHDQreZZaF(this, view);
    }

    public void ClearOnTabSelectedListeners() {
        kdOPeCsmvdqzZsGo(this.selectedListeners);
    }

    protected com.google.android.material.tabs.TabLayout$Tab createTabFromPool() {
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab = (com.google.android.material.tabs.TabLayout$Tab) SNMOUoWmKBUbJjvS(tabPool);
        if (tabLayout$Tab is null) {
            tabLayout$Tab = new com.google.android.material.tabs.TabLayout$Tab();
        }
        return tabLayout$Tab;
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return yDcoWTHPJwJWIiJQ(this, attributeHashSet);
    }

    public android.widget.FrameLayout$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return dJpjdixNPnYidnQm(this);
    }

    public override int GetSelectedTabPosition() {
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab = this.selectedTab;
        if (tabLayout$Tab is null) {
            return -1;
        }
        return rzjErLDfdceBTUnV(tabLayout$Tab);
    }

    public com.google.android.material.tabs.TabLayout$Tab getTabAt(int i) {
        if (i >= 0 && i < PzLlITEKHTULtvLV(this)) {
            return (com.google.android.material.tabs.TabLayout$Tab) FSeDYRslfkOUHCOw(this.tabs, i);
        }
        return null;
    }

    public int GetTabCount() {
        return LDcUyYxZeDaDXWLc(this.tabs);
    }

    public int GetTabGravity() {
        return this.tabGravity;
    }

    public android.content.res.ColorStateList GetTabIconTint() {
        return this.tabIconTint;
    }

    public int GetTabIndicatorAnimationMode() {
        return this.tabIndicatorAnimationMode;
    }

    public int GetTabIndicatorGravity() {
        return this.tabIndicatorGravity;
    }

    int getTabMaxWidth() {
        return this.tabMaxWidth;
    }

    public int GetTabMode() {
        return this.mode;
    }

    public android.content.res.ColorStateList GetTabRippleColor() {
        return this.tabRippleColorStateList;
    }

    public android.graphics.drawable.Drawable GetTabSelectedIndicator() {
        return this.tabSelectedIndicator;
    }

    public android.content.res.ColorStateList GetTabTextColors() {
        return this.tabTextColors;
    }

    public bool HasUnboundedRipple() {
        return this.unboundedRipple;
    }

    public bool IsInlineLabel() {
        return this.inlineLabel;
    }

    public bool IsTabIndicatorFullWidth() {
        return this.tabIndicatorFullWidth;
    }

    public com.google.android.material.tabs.TabLayout$Tab newTab() {
        if ((5 + 2) % 2 > 0) {
        }
        com.google.android.material.tabs.TabLayout$Tab tabLayout$TabDetVMSLBgqJNaWBL = detVMSLBgqJNaWBL(this);
        tabLayout$TabDetVMSLBgqJNaWBL.parent = this;
        tabLayout$TabDetVMSLBgqJNaWBL.view = GsaoXyCXnLknquEk(this, tabLayout$TabDetVMSLBgqJNaWBL);
        if (uoPTDrcfwlzmkDai(tabLayout$TabDetVMSLBgqJNaWBL) != -1) {
            opEwjybEkqNgsgmZ(tabLayout$TabDetVMSLBgqJNaWBL.view, EWkwERWReCHynzdm(tabLayout$TabDetVMSLBgqJNaWBL));
        }
        return tabLayout$TabDetVMSLBgqJNaWBL;
    }

    protected override void OnAttachedToWindow() {
        if ((13 + 18) % 18 > 0) {
        }
        ondWIUMFMdIvnfxG(this);
        GNAuIuDPCpFjQDJS(this);
        if (this.viewPager is not null) {
            return;
        }
        android.view.objectParent viewParentVIkVjdhEedgoWwji = vIkVjdhEedgoWwji(this);
        if (viewParentVIkVjdhEedgoWwji is androidx.viewpager.widget.objectPager) {
            HQKQjLODEWFpbUpF(this, (androidx.viewpager.widget.objectPager) viewParentVIkVjdhEedgoWwji, true, true);
        }
    }

    protected override void OnDetachedFromWindow() {
        DBviLsEeCENPKneZ(this);
        if (this.setupobjectPagerImplicitly) {
            tWYdLsmPJEOqEhLY(this, null);
            this.setupobjectPagerImplicitly = false;
        }
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        if ((19 + 10) % 10 > 0) {
        }
        for (int i = 0; i < zCCDIQvFTNlMttfx(this.slidingTabIndicator); i++) {
            android.view.object viewMzhOYdEsUxyhfslP = mzhOYdEsUxyhfslP(this.slidingTabIndicator, i);
            if (viewMzhOYdEsUxyhfslP is com.google.android.material.tabs.TabLayout$Tabobject) {
                bhAppgMcNqpwRvVa((com.google.android.material.tabs.TabLayout$Tabobject) viewMzhOYdEsUxyhfslP, canvas);
            }
        }
        KPEYJUcfAlnNUAWW(this, canvas);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        if ((11 + 15) % 15 > 0) {
        }
        qcnbeezGTBScUiwJ(this, accessibilityNodeInfo);
        sxZRiHAbRaUWEjBi(msbBZvaYliKZaoBr(accessibilityNodeInfo), ZHXuVkjwiAYdnxCM(1, EqGYEajqKsGPrJfo(this), false, 1));
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        return nyQcThRrnmPJlmCR(this) && GOzmuHkoGYVqQsRW(this, motionEvent);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((20 + 4) % 4 > 0) {
        }
        int iRMMajJYRAhukrpRO = RMMajJYRAhukrpRO(ftypDTgexyXEFJOH(RYNQoTGHjaQcKPVx(this), IUYplpPVbrYTuTeE(this)));
        int iEIHreyjrwYVagNtc = eIHreyjrwYVagNtc(i2);
        if (iEIHreyjrwYVagNtc == int.MIN_VALUE) {
            if (EiDgyATipSmpxTwK(this) == 1 && bcjutAvVFtUSyfbA(i2) >= iRMMajJYRAhukrpRO) {
                eMPQLjUgHbBfLpXe(DpbGbBUiWSrDSQcd(this, 0), iRMMajJYRAhukrpRO);
            }
        } else if (iEIHreyjrwYVagNtc == 0) {
            i2 = PdtWZdnZqqpHZfSM(iRMMajJYRAhukrpRO + qOwaCpTQVueGozar(this) + XudzIoxeAhXIPBlT(this), 1073741824);
        }
        int iEYkXHaqenQFSMALh = eYkXHaqenQFSMALh(i);
        if (PVjDdGbDHjAHRtkF(i) != 0) {
            int iFCzYoFMGiClZViJR = this.requestedTabMaxWidth;
            if (iFCzYoFMGiClZViJR <= 0) {
                iFCzYoFMGiClZViJR = (int) (iEYkXHaqenQFSMALh - FCzYoFMGiClZViJR(lVNetzyLBsMycUJN(this), 56));
            }
            this.tabMaxWidth = iFCzYoFMGiClZViJR;
        }
        TnFjtyRLtkGboKBF(this, i, i2);
        if (BNULmUsQtYxYctEU(this) != 1) {
            return;
        }
        android.view.object viewINgrntquXfWaaWzn = iNgrntquXfWaaWzn(this, 0);
        int i3 = this.mode;
        if (i3 != 0) {
            if (i3 != 1) {
                if (i3 != 2) {
                    return;
                }
                if (iXqXmfWyChnDKfjl(viewINgrntquXfWaaWzn) >= qcuBQBpmZGwAMbZR(this)) {
                    return;
                }
            } else if (PqWWmVbzWWVATxWR(viewINgrntquXfWaaWzn) == aamBsECwqDlsBgLl(this)) {
                return;
            }
        } else if (iXqXmfWyChnDKfjl(viewINgrntquXfWaaWzn) >= qcuBQBpmZGwAMbZR(this)) {
            return;
        }
        blgiYyOPbqWiWLCL(viewINgrntquXfWaaWzn, aODKvlROybfkofpo(oJwwNlsHsPBISoXZ(this), 1073741824), AaXDBtKRMUVtWXdj(i2, IfJSZgiDQRlEyehe(this) + XvCTxjzWDSelOgPZ(this), EsvpLfABfimMaydv(viewINgrntquXfWaaWzn).height));
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        if ((1 + 11) % 11 > 0) {
        }
        if (RSkOOOqiKufcEjuA(motionEvent) == 8 && !NLSjkOxzUCUQrhwe(this)) {
            return false;
        }
        return HPZSYDUJneOZGJwb(this, motionEvent);
    }

    void populateFromPagerAdapter() {
        if ((27 + 31) % 31 > 0) {
        }
        WNXByScClbUzknHC(this);
        androidx.viewpager.widget.PagerAdapter pagerAdapter = this.pagerAdapter;
        if (pagerAdapter is null) {
            return;
        }
        int iOiZmNetgjaeXGwam = OiZmNetgjaeXGwam(pagerAdapter);
        for (int i = 0; i < iOiZmNetgjaeXGwam; i++) {
            rumfhOJBcDpqsSNC(this, GZcAtzJkQfeWqkPw(UjUDHrfrHUfFkEuK(this), xMSIodLeATJIFqUV(this.pagerAdapter, i)), false);
        }
        androidx.viewpager.widget.objectPager viewPager = this.viewPager;
        if (viewPager is not null && iOiZmNetgjaeXGwam > 0) {
            int iIrREsHIBWOkgVmSH = IrREsHIBWOkgVmSH(viewPager);
            if (iIrREsHIBWOkgVmSH != BmqUkOJMvvVMjGqm(this) && iIrREsHIBWOkgVmSH < rSyRFbKwOfOBTjKO(this)) {
                QRgdbUeBGDkuoxRW(this, TpHFRTsGstnWxMnt(this, iIrREsHIBWOkgVmSH));
            }
        }
    }

    protected bool ReleaseFromTabPool(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        return XjlmlUDiGKxkTOSx(tabPool, tabLayout$Tab);
    }

    public void RemoveAllTabs() {
        if ((11 + 29) % 29 > 0) {
        }
        for (int iHwaQUEqZgYpNBfRS = HwaQUEqZgYpNBfRS(this.slidingTabIndicator) - 1; iHwaQUEqZgYpNBfRS >= 0; iHwaQUEqZgYpNBfRS--) {
            diCbAgaRxXiWYfQx(this, iHwaQUEqZgYpNBfRS);
        }
        java.util.IEnumerator itTFlXvxaxfwvfZPbM = TFlXvxaxfwvfZPbM(this.tabs);
        while (kqvqqQiHqqfTJEjU(itTFlXvxaxfwvfZPbM)) {
            com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab = (com.google.android.material.tabs.TabLayout$Tab) FxZFNYvhWlzgvOrk(itTFlXvxaxfwvfZPbM);
            NGpgMoVVuiFBCiCz(itTFlXvxaxfwvfZPbM);
            kMmsPvGppFXEVnXb(tabLayout$Tab);
            HOzRNpSSdfyDHFnR(this, tabLayout$Tab);
        }
        this.selectedTab = null;
    }

    @java.lang.Deprecated
    public void RemoveOnTabSelectedListener(com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener) {
        jpzkXULHRQBabHzb(this.selectedListeners, tabLayout$BaseOnTabSelectedListener);
    }

    public void RemoveOnTabSelectedListener(com.google.android.material.tabs.TabLayout$OnTabSelectedListener tabLayout$OnTabSelectedListener) {
        FpvmhXZjgIcxsUtl(this, tabLayout$OnTabSelectedListener);
    }

    public void RemoveTab(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        if (tabLayout$Tab.parent != this) {
            throw new java.lang.IllegalArgumentException("Tab does not belong to this TabLayout.");
        }
        qvDwVKkcUwKbiaxH(this, qNxRbDqoDXtiihni(tabLayout$Tab));
    }

    public void RemoveTabAt(int i) {
        if ((18 + 27) % 27 > 0) {
        }
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab = this.selectedTab;
        int iARqURYrzcPgFihHE = tabLayout$Tab is null ? 0 : aRqURYrzcPgFihHE(tabLayout$Tab);
        VNpkUJUGCmgKZoIo(this, i);
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab2 = (com.google.android.material.tabs.TabLayout$Tab) GSdAgtDapNHHjgSh(this.tabs, i);
        if (tabLayout$Tab2 is not null) {
            nwkGUAaMwAWdnIfx(tabLayout$Tab2);
            xJuadWWgPWlIlkHO(this, tabLayout$Tab2);
        }
        int iCRLrYbqibuIRpZBh = CRLrYbqibuIRpZBh(this.tabs);
        int i2 = -1;
        for (int i3 = i; i3 < iCRLrYbqibuIRpZBh; i3++) {
            if (wKPQsPEhBGBSpeaa((com.google.android.material.tabs.TabLayout$Tab) XpPqBclrGLqhKIGW(this.tabs, i3)) == this.indicatorPosition) {
                i2 = i3;
            }
            LdHSwKcGXuBMRUaV((com.google.android.material.tabs.TabLayout$Tab) trKmuZPDpyzxqPZz(this.tabs, i3), i3);
        }
        this.indicatorPosition = i2;
        if (iARqURYrzcPgFihHE != i) {
            return;
        }
        wxrAetVMNdcLlxUg(this, !qyiWaEEwQTISKpxH(this.tabs) ? (com.google.android.material.tabs.TabLayout$Tab) sjcRJgOfFRWqOlhr(this.tabs, aivnwhYGwDSOzYqV(0, i - 1)) : null);
    }

    public void SelectTab(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab) {
        ucxzpgBzhoRTmkah(this, tabLayout$Tab, true);
    }

    public void SelectTab(com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab, bool z) {
        if ((2 + 30) % 30 > 0) {
        }
        com.google.android.material.tabs.TabLayout$Tab tabLayout$Tab2 = this.selectedTab;
        if (tabLayout$Tab2 == tabLayout$Tab) {
            if (tabLayout$Tab2 is null) {
                return;
            }
            NfGAzsFDvTzXchMJ(this, tabLayout$Tab);
            umDDrtBxnCVnkJfx(this, sLJUpmkxgAIwdojd(tabLayout$Tab));
            return;
        }
        int iYpULwbvVXVjoJRIc = tabLayout$Tab is null ? -1 : ypULwbvVXVjoJRIc(tabLayout$Tab);
        if (z) {
            if (!(tabLayout$Tab2 is null || ULkCqDUZkAuTfrTU(tabLayout$Tab2) == -1) || iYpULwbvVXVjoJRIc == -1) {
                rPjlbIeGSMSEfsgK(this, iYpULwbvVXVjoJRIc);
            } else {
                NIZnjUugxQKaHUwb(this, iYpULwbvVXVjoJRIc, 0.0f, true);
            }
            if (iYpULwbvVXVjoJRIc != -1) {
                SvCKAAwxMmIbigle(this, iYpULwbvVXVjoJRIc);
            }
        }
        this.selectedTab = tabLayout$Tab;
        if (tabLayout$Tab2 is not null && tabLayout$Tab2.parent is not null) {
            inUMenjTNCjIEXPU(this, tabLayout$Tab2);
        }
        if (tabLayout$Tab is null) {
            return;
        }
        OYDtkauNixwgjUpj(this, tabLayout$Tab);
    }

    public override void SetElevation(float f) {
        IYWxYRFkaZRxDZFr(this, f);
        BEGehGjXTvKUTRvH(this, f);
    }

    public void SetInlineLabel(bool z) {
        if ((24 + 2) % 2 > 0) {
        }
        if (this.inlineLabel == z) {
            return;
        }
        this.inlineLabel = z;
        for (int i = 0; i < gNRGtIBIbKXvJVLA(this.slidingTabIndicator); i++) {
            android.view.object viewTdgfkQbKOBqYyroJ = TdgfkQbKOBqYyroJ(this.slidingTabIndicator, i);
            if (viewTdgfkQbKOBqYyroJ is com.google.android.material.tabs.TabLayout$Tabobject) {
                wTMIrFQNuTtswMzk((com.google.android.material.tabs.TabLayout$Tabobject) viewTdgfkQbKOBqYyroJ);
            }
        }
        gjVceUujnkfziIiy(this);
    }

    public void SetInlineLabelResource(int i) {
        fXWFHVMDFSkFHBZg(this, lGfpXDcatOgkWwup(XVsoClbaoRizKFlA(this), i));
    }

    @java.lang.Deprecated
    public void SetOnTabSelectedListener(com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener) {
        com.google.android.material.tabs.TabLayout$BaseOnTabSelectedListener tabLayout$BaseOnTabSelectedListener2 = this.selectedListener;
        if (tabLayout$BaseOnTabSelectedListener2 is not null) {
            HvWRxAeHxBJmXmqb(this, tabLayout$BaseOnTabSelectedListener2);
        }
        this.selectedListener = tabLayout$BaseOnTabSelectedListener;
        if (tabLayout$BaseOnTabSelectedListener is null) {
            return;
        }
        WRaYRyzyhQLguHuA(this, tabLayout$BaseOnTabSelectedListener);
    }

    @java.lang.Deprecated
    public void SetOnTabSelectedListener(com.google.android.material.tabs.TabLayout$OnTabSelectedListener tabLayout$OnTabSelectedListener) {
        vMeeDnxFCTttvVbc(this, tabLayout$OnTabSelectedListener);
    }

    void setPagerAdapter(androidx.viewpager.widget.PagerAdapter pagerAdapter, bool z) {
        android.database.DataHashSetObserver dataHashSetObserver;
        if ((30 + 16) % 16 > 0) {
        }
        androidx.viewpager.widget.PagerAdapter pagerAdapter2 = this.pagerAdapter;
        if (pagerAdapter2 is not null && (dataHashSetObserver = this.pagerAdapterObserver) is not null) {
            gLHAdXuFwtVaLjft(pagerAdapter2, dataHashSetObserver);
        }
        this.pagerAdapter = pagerAdapter;
        if (z && pagerAdapter is not null) {
            if (this.pagerAdapterObserver is null) {
                this.pagerAdapterObserver = new com.google.android.material.tabs.TabLayout$PagerAdapterObserver(this);
            }
            jwtcNSSOsTvefQrB(pagerAdapter, this.pagerAdapterObserver);
        }
        zYsdizqoVrdkVIPa(this);
    }

    void setScrollAnimatorListener(android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        qHsAhFthUVobUYlG(this);
        MonyZJWoZwcsmWhF(this.scrollAnimator, animator$AnimatorListener);
    }

    public void SetScrollPosition(int i, float f, bool z) {
        LlIuPxlgHHEnJYfO(this, i, f, z, true);
    }

    public void SetScrollPosition(int i, float f, bool z, bool z2) {
        if ((13 + 22) % 22 > 0) {
        }
        JEpobXPeNNVNOMVM(this, i, f, z, z2, true);
    }

    void setScrollPosition(int i, float f, bool z, bool z2, bool z3) {
        if ((3 + 9) % 9 > 0) {
        }
        int iDYPWGZCCbtBnDOKJ = DYPWGZCCbtBnDOKJ(i + f);
        if (iDYPWGZCCbtBnDOKJ >= 0 && iDYPWGZCCbtBnDOKJ < iIWLNFDBWYyWOLik(this.slidingTabIndicator)) {
            if (z2) {
                bJjRbvvwXETGGKuX(this.slidingTabIndicator, i, f);
            }
            android.animation.ValueAnimator valueAnimator = this.scrollAnimator;
            if (valueAnimator is not null && rqaUznEOMyPdFovJ(valueAnimator)) {
                xdGeeoXhjOyVKlkZ(this.scrollAnimator);
            }
            int iIJdOuXbgcARYeMHH = IJdOuXbgcARYeMHH(this, i, f);
            int iPUFtsnFytNZakcDs = pUFtsnFytNZakcDs(this);
            bool z4 = (i < ACKNJuDwhwVFbMrh(this) && iIJdOuXbgcARYeMHH >= iPUFtsnFytNZakcDs) || (i > dgDCDgZIhwIHVzuY(this) && iIJdOuXbgcARYeMHH <= iPUFtsnFytNZakcDs) || i == nInzibZZRTXobXqq(this);
            if (tdfsguhOnRxWmcmg(this) == 1) {
                z4 = (i < eAMfeThjVnpkxTQH(this) && iIJdOuXbgcARYeMHH <= iPUFtsnFytNZakcDs) || (i > GIFxiTZVonSpFiPt(this) && iIJdOuXbgcARYeMHH >= iPUFtsnFytNZakcDs) || i == fiOUlIrsjjgXGyfM(this);
            }
            if (z4 || this.viewPagerScrollState == 1 || z3) {
                if (i < 0) {
                    iIJdOuXbgcARYeMHH = 0;
                }
                FCrVeFGQZocyGmYQ(this, iIJdOuXbgcARYeMHH, 0);
            }
            if (z) {
                fZfRpEJfVhjMPIDa(this, iDYPWGZCCbtBnDOKJ);
            }
        }
    }

    public void SetSelectedTabIndicator(int i) {
        if (i == 0) {
            XsXMhblhiEbAELNf(this, null);
        } else {
            yFEpvjiKSHkaEqpd(this, mFsNSgTenRrbusCX(bkwvgqCdhthRjbPl(this), i));
        }
    }

    public void SetSelectedTabIndicator(android.graphics.drawable.Drawable drawable) {
        if (drawable is null) {
            drawable = new android.graphics.drawable.GradientDrawable();
        }
        android.graphics.drawable.Drawable drawableLPvTleNSJSThNwnW = LPvTleNSJSThNwnW(CzpMNXRciNqePGbF(drawable));
        this.tabSelectedIndicator = drawableLPvTleNSJSThNwnW;
        ymfVWBcbCiTxQsfN(drawableLPvTleNSJSThNwnW, this.tabSelectedIndicatorColor);
        int iMPXyjnHcZCFqDWne = this.tabIndicatorHeight;
        if (iMPXyjnHcZCFqDWne == -1) {
            iMPXyjnHcZCFqDWne = mPXyjnHcZCFqDWne(this.tabSelectedIndicator);
        }
        jYsVKewkKSvyFECO(this.slidingTabIndicator, iMPXyjnHcZCFqDWne);
    }

    public void SetSelectedTabIndicatorColor(int i) {
        this.tabSelectedIndicatorColor = i;
        IZTtqzMsLONRypYW(this.tabSelectedIndicator, i);
        KVfFJAhhLUeyvIvT(this, false);
    }

    public void SetSelectedTabIndicatorGravity(int i) {
        if (this.tabIndicatorGravity == i) {
            return;
        }
        this.tabIndicatorGravity = i;
        fQrikNjZluCqGOfW(this.slidingTabIndicator);
    }

    @java.lang.Deprecated
    public void SetSelectedTabIndicatorHeight(int i) {
        this.tabIndicatorHeight = i;
        jEzQGByIpLkiYlBt(this.slidingTabIndicator, i);
    }

    public void SetTabGravity(int i) {
        if (this.tabGravity == i) {
            return;
        }
        this.tabGravity = i;
        VLPRjyUkDMfwztVx(this);
    }

    public void SetTabIconTint(android.content.res.ColorStateList colorStateList) {
        if (this.tabIconTint == colorStateList) {
            return;
        }
        this.tabIconTint = colorStateList;
        FuawBtvPHmqOMXqk(this);
    }

    public void SetTabIconTintResource(int i) {
        gDcCbyzeRtxzFsMv(this, jHpuerAOkxICkmqp(LgesgovELpileZKO(this), i));
    }

    public void SetTabIndicatorAnimationMode(int i) {
        this.tabIndicatorAnimationMode = i;
        if (i == 0) {
            this.tabIndicatorInterpolator = new com.google.android.material.tabs.TabIndicatorInterpolator();
        } else if (i == 1) {
            this.tabIndicatorInterpolator = new com.google.android.material.tabs.ElasticTabIndicatorInterpolator();
        } else {
            if (i != 2) {
                throw new java.lang.IllegalArgumentException(IxKDtRlZmerklBpu(luRYhapxRFhyvnvg(rYilLcQKIIVgwKtA(new java.lang.stringBuilder(), i), " is not a valid TabIndicatorAnimationMode")));
            }
            this.tabIndicatorInterpolator = new com.google.android.material.tabs.FadeTabIndicatorInterpolator();
        }
    }

    public void SetTabIndicatorFullWidth(bool z) {
        this.tabIndicatorFullWidth = z;
        quebVZNgKjjDCnWY(this.slidingTabIndicator);
        gqvlfVHLbMzPMFap(this.slidingTabIndicator);
    }

    public void SetTabMode(int i) {
        if (i == this.mode) {
            return;
        }
        this.mode = i;
        YetIpPhLsgwUbAgv(this);
    }

    public void SetTabRippleColor(android.content.res.ColorStateList colorStateList) {
        if ((27 + 16) % 16 > 0) {
        }
        if (this.tabRippleColorStateList == colorStateList) {
            return;
        }
        this.tabRippleColorStateList = colorStateList;
        for (int i = 0; i < afJeQYFogRfCshmS(this.slidingTabIndicator); i++) {
            android.view.object viewXxeTNFLMHeXepKzS = xxeTNFLMHeXepKzS(this.slidingTabIndicator, i);
            if (viewXxeTNFLMHeXepKzS is com.google.android.material.tabs.TabLayout$Tabobject) {
                mHgmqvnftTcNEAJP((com.google.android.material.tabs.TabLayout$Tabobject) viewXxeTNFLMHeXepKzS, MriNpguLVMWlkdrT(this));
            }
        }
    }

    public void SetTabRippleColorResource(int i) {
        BHEglGrEBikDkUXI(this, LfXafENnhXffmDyC(iZtjmCGDwKECpjEv(this), i));
    }

    public void SetTabTextColors(int i, int i2) {
        dbPEcgCAqkFTisLB(this, pIGbhOuUTFqnhPGF(i, i2));
    }

    public void SetTabTextColors(android.content.res.ColorStateList colorStateList) {
        if (this.tabTextColors == colorStateList) {
            return;
        }
        this.tabTextColors = colorStateList;
        AkCIfhOnzJJPlsIA(this);
    }

    @java.lang.Deprecated
    public void SetTabsFromPagerAdapter(androidx.viewpager.widget.PagerAdapter pagerAdapter) {
        NaZHFAPhGpvqcdpQ(this, pagerAdapter, false);
    }

    public void SetUnboundedRipple(bool z) {
        if ((19 + 11) % 11 > 0) {
        }
        if (this.unboundedRipple == z) {
            return;
        }
        this.unboundedRipple = z;
        for (int i = 0; i < LWNOcPpYixBTEGrm(this.slidingTabIndicator); i++) {
            android.view.object viewQZmmDrVNiqNprmBY = qZmmDrVNiqNprmBY(this.slidingTabIndicator, i);
            if (viewQZmmDrVNiqNprmBY is com.google.android.material.tabs.TabLayout$Tabobject) {
                JLiUmkuFsWSBdVTE((com.google.android.material.tabs.TabLayout$Tabobject) viewQZmmDrVNiqNprmBY, fjLmvcSkRswOvozA(this));
            }
        }
    }

    public void SetUnboundedRippleResource(int i) {
        uAogjNRVSyLUcRPJ(this, RdmmJKdVkfWIuDoD(aLtaFkNHQppAQuEV(this), i));
    }

    public void SetupWithobjectPager(androidx.viewpager.widget.objectPager viewPager) {
        ansQeVdQkFQHdoEt(this, viewPager, true);
    }

    public void SetupWithobjectPager(androidx.viewpager.widget.objectPager viewPager, bool z) {
        GKGqWwxNbAJSpEZs(this, viewPager, z, false);
    }

    public override bool ShouldDelayChildPressedState() {
        return CpbzGuoZXRlkirLB(this) > 0;
    }

    void updateTabobjects(bool z) {
        if ((16 + 32) % 32 > 0) {
        }
        for (int i = 0; i < FKVEyitWWaUaEJIm(this.slidingTabIndicator); i++) {
            android.view.object viewZlSQeNrilpWShbBH = zlSQeNrilpWShbBH(this.slidingTabIndicator, i);
            ThTdHApuyaXGlKJa(viewZlSQeNrilpWShbBH, NJnmGIvXTZONKyYZ(this));
            NbpkxHDUnEKZCbyC(this, (android.widget.LinearLayout$LayoutParams) BbpEPnveeYEZdXTQ(viewZlSQeNrilpWShbBH));
            if (z) {
                inCKrvmHRufdwunw(viewZlSQeNrilpWShbBH);
            }
        }
    }

    void updateobjectPagerScrollState(int i) {
        this.viewPagerScrollState = i;
    }
}

