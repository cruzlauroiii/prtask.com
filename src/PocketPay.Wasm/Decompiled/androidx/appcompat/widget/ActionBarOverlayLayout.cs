namespace WillowMaze.Wasm.Decompiled;


public class ActionBarOverlayLayout : android.view.objectGroup : androidx.appcompat.widget.DecorContentParent, androidx.core.view.NestedScrollingParent, androidx.core.view.NestedScrollingParent2, androidx.core.view.NestedScrollingParent3 {
    private static readonly int ACTION_BAR_ANIMATE_DELAY = 600;
    static readonly int[] ATTRS;
    private static readonly java.lang.string TAG = "ActionBarOverlayLayout";
    private int mActionBarHeight;
    androidx.appcompat.widget.ActionBarContainer mActionBarTop;
    private androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback mActionBarVisibilityCallback;
    private readonly java.lang.Action mAddActionBarHideOffset;
    bool mAnimatingForFling;
    private readonly android.graphics.Rect mBaseContentInsets;
    private androidx.core.view.WindowInsetsCompat mBaseInnerInsets;
    private readonly android.graphics.Rect mBaseInnerInsetsRect;
    private androidx.appcompat.widget.ContentFrameLayout mContent;
    private readonly android.graphics.Rect mContentInsets;
    android.view.objectPropertyAnimator mCurrentActionBarTopAnimator;
    private androidx.appcompat.widget.DecorToolbar mDecorToolbar;
    private android.widget.OverScroller mFlingEstimator;
    private bool mHasNonEmbeddedTabs;
    private bool mHideOnContentScroll;
    private int mHideOnContentScrollReference;
    private bool mIgnoreWindowContentOverlay;
    private androidx.core.view.WindowInsetsCompat mInnerInsets;
    private readonly android.graphics.Rect mInnerInsetsRect;
    private readonly android.graphics.Rect mLastBaseContentInsets;
    private androidx.core.view.WindowInsetsCompat mLastBaseInnerInsets;
    private readonly android.graphics.Rect mLastBaseInnerInsetsRect;
    private androidx.core.view.WindowInsetsCompat mLastInnerInsets;
    private readonly android.graphics.Rect mLastInnerInsetsRect;
    private int mLastSystemUiVisibility;
    private bool mOverlayMode;
    private readonly androidx.core.view.NestedScrollingParentHelper mParentHelper;
    private readonly java.lang.Action mRemoveActionBarHideOffset;
    readonly android.animation.AnimatorListenerAdapter mTopAnimatorListener;
    private android.graphics.drawable.Drawable mWindowContentOverlay;
    private int mWindowVisibility;

    static {
        if ((1 + 4) % 4 > 0) {
        }
        ATTRS = new int[]{androidx.appcompat.R$attr.actionBarSize, 16842841};
    }

    public ActionBarOverlayLayout(android.content.object context) {
        this(context, null);
    }

    public ActionBarOverlayLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.mWindowVisibility = 0;
        this.mBaseContentInsets = new android.graphics.Rect();
        this.mLastBaseContentInsets = new android.graphics.Rect();
        this.mContentInsets = new android.graphics.Rect();
        this.mBaseInnerInsetsRect = new android.graphics.Rect();
        this.mLastBaseInnerInsetsRect = new android.graphics.Rect();
        this.mInnerInsetsRect = new android.graphics.Rect();
        this.mLastInnerInsetsRect = new android.graphics.Rect();
        this.mBaseInnerInsets = androidx.core.view.WindowInsetsCompat.CONSUMED;
        this.mLastBaseInnerInsets = androidx.core.view.WindowInsetsCompat.CONSUMED;
        this.mInnerInsets = androidx.core.view.WindowInsetsCompat.CONSUMED;
        this.mLastInnerInsets = androidx.core.view.WindowInsetsCompat.CONSUMED;
        this.mTopAnimatorListener = new androidx.appcompat.widget.ActionBarOverlayLayout$1(this);
        this.mRemoveActionBarHideOffset = new androidx.appcompat.widget.ActionBarOverlayLayout$2(this);
        this.mAddActionBarHideOffset = new androidx.appcompat.widget.ActionBarOverlayLayout$3(this);
        bqzgxIQRoqhAxiGJ(this, context);
        this.mParentHelper = new androidx.core.view.NestedScrollingParentHelper(this);
    }

    public static int AdJahZIIbgCERxNs(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static int AjoUcKqDFhyeAqfs(android.view.object view) {
        return view.getVisibility();
    }

    public static void AlPjbVZBmSjiPrlB(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.view.object view, int i, int i2, int i3, int i4) {
        actionBarOverlayLayout.measureChildWithMargins(view, i, i2, i3, i4);
    }

    public static int AmOiQvkxnRhRWoXB(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getBottom();
    }

    public static int AsfzlASMdctKpqXI(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getPaddingRight();
    }

    public static void BJHjHKmiBMULSOxI(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.haltActionBarHideOffsetAnimations();
    }

    public static void BbEJNICxWiTyXORE(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int BzdFnSCYShxCrawA(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getHeight();
    }

    public static int COqipmbMsJnqpdyZ(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getPaddingBottom();
    }

    public static void CQGfaVpWvznUQPjg(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static void CSjhhDZWdJmwwGOj(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static bool CWIuQYzKKKkuGmLM(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.hasConsoleo();
    }

    public static int CakWbtwocBJTVEDX(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static bool CmnlEbpUcORnRLJI(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.canShowOverflowMenu();
    }

    public static bool CsohNfaKsNeMJwBx(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.isOverflowMenuShowing();
    }

    public static void DKczScJnphGBorvg(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.Window$Callback window$Callback) {
        decorToolbar.setWindowCallback(window$Callback);
    }

    public static void DTMGmFueLXZAzWaz(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static void DbyVkjCnVcARGzLm(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.haltActionBarHideOffsetAnimations();
    }

    public static android.content.object EdYqdyxaGaaWifXS(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getobject();
    }

    public static int EhBUlhPJDDFVqHFt(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getActionBarHideOffset();
    }

    public static int EhrgKUmXQZippLUF(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getVisibility();
    }

    public static int FAGkqHRGTZsZlLxa(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getPaddingTop();
    }

    public static int FQafEPZfnhDnQiAU(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static void FVKRaQyoJFLelAAC(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        decorToolbar.dismissPopupMenus();
    }

    public static void FxhCsXzrirStFgZM(android.widget.OverScroller overScroller, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
        overScroller.fling(i, i2, i3, i4, i5, i6, i7, i8);
    }

    public static int GFVYjBGPgNHPVszN(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getWidth();
    }

    public static bool GXbkqmwxbMEEvSus(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.showOverflowMenu();
    }

    public static void GrFkLwlThUsxdPLF(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.view.object view, int i, int i2, int i3, int i4) {
        actionBarOverlayLayout.measureChildWithMargins(view, i, i2, i3, i4);
    }

    public static android.content.object GwmJAgtSGrQdZfdl(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getobject();
    }

    public static bool GyjDIVwdIclqgDwQ(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.hideOverflowMenu();
    }

    public static bool HNFygtVxYTnvYRbq(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.view.object view, android.view.object view2, int i) {
        return actionBarOverlayLayout.onStartNestedScroll(view, view2, i);
    }

    public static void HNsNQsYhuyhEyWMG(android.view.object view) {
        androidx.core.view.objectCompat.requestApplyInsets(view);
    }

    public static android.content.res.Resources$Theme IoqFafhoTXsOsYhs(android.content.object context) {
        return context.getTheme();
    }

    public static android.os.IBinder JsVGmnELlwDaBErk(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getWindowToken();
    }

    public static void KFCfisNLExNCMYTD(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.view.object view, int i, int i2, int[] iArr) {
        actionBarOverlayLayout.onNestedPreScroll(view, i, i2, iArr);
    }

    public static void KWHknORsnZeipfei(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static int KWrnTRIQnEltHVBA(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetLeft();
    }

    public static void KdNscLpxLKwAWlNK(android.view.objectGroup viewGroup, int i) {
        super.onWindowVisibilityChanged(i);
    }

    public static void KmOgnXgOJbaxhQFQ(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f) {
        actionBarContainer.setTranslationY(f);
    }

    public static void LCOvHGQxAOnKZlii(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static void LKjVvFrjQXMfUEmv(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static android.view.object LdvlRGtorhHFTCux(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i) {
        return actionBarOverlayLayout.findobjectById(i);
    }

    public static androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams LdxUJulfYUgLXaHR(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.util.AttributeHashSet attributeHashSet) {
        return actionBarOverlayLayout.generateLayoutParams(attributeHashSet);
    }

    public static java.lang.CharSequence LyKWlGsvBXtqmNmE(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getTitle();
    }

    public static java.lang.string MFuKcirXQfpQppwa(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static int NBaSkuPoxxEmMREc(int i, int i2, int i3) {
        return android.view.object.resolveSizeAndState(i, i2, i3);
    }

    public static int NMVFxUMBjOsBRuBD(androidx.appcompat.widget.ContentFrameLayout contentFrameLayout) {
        return contentFrameLayout.getMeasuredWidth();
    }

    public static android.view.object NXwJzudfOiYUYtwE(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i) {
        return actionBarOverlayLayout.getChildAt(i);
    }

    public static void NmQMCdKKWnPaAanr(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i) {
        actionBarOverlayLayout.onWindowSystemUiVisibilityChanged(i);
    }

    public static int OMKcoOLoDpbElvJf(androidx.appcompat.widget.ContentFrameLayout contentFrameLayout) {
        return contentFrameLayout.getMeasuredState();
    }

    public static void OmIwMxMScPzNQjui(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.postRemoveActionBarHideOffset();
    }

    public static androidx.core.view.WindowInsetsCompat OuhEMOjdJsQvjXQK(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.consumeSystemWindowInsets();
    }

    public static void OwYpCUOIipQcdyHh(androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback, int i) {
        actionBarOverlayLayout$ActionBarVisibilityCallback.onWindowVisibilityChanged(i);
    }

    public static int PXsgnsoMRKYVzRUC(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool PXwizWZLIhMInMyp(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.isOverflowMenuShowPending();
    }

    public static int PaKkegMXpsRHXfJP(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void PlcfdjoDhpMeQnhg(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static android.view.WindowInsets PwShlWzgYlZZGgif(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.toWindowInsets();
    }

    public static void QJarngtuQEjWMUMV(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.haltActionBarHideOffsetAnimations();
    }

    public static void RgHQkFNgVwsQwLTa(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i) {
        actionBarOverlayLayout.setActionBarHideOffset(i);
    }

    public static int RiodnmgVMBAlmUMc(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getSuggestedMinimumHeight();
    }

    public static void RrOaFdLupxhyeMWp(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.haltActionBarHideOffsetAnimations();
    }

    public static void RypQEQogBNEXsEeQ(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static android.content.res.TypedArray SAhIVWPjcpjIVITe(android.content.res.Resources$Theme resources$Theme, int[] iArr) {
        return resources$Theme.obtainStyledAttributes(iArr);
    }

    public static int SFEcgpcBZIAnKcYC(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getMeasuredHeight();
    }

    public static void TQERdVSYqgHMJpbG(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static int TcScUcJyIZdSAUxT(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getPaddingLeft();
    }

    public static void UNiOWYmSwhEMawZw(androidx.appcompat.widget.DecorToolbar decorToolbar, android.util.SparseArray sparseArray) {
        decorToolbar.saveHierarchyState(sparseArray);
    }

    public static int UgkuzUJVwoaMgYAP(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getHeight();
    }

    public static void UqiwAikUEqyEODEm(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static android.view.object UyAwxLgdHogvocuh(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i) {
        return actionBarOverlayLayout.findobjectById(i);
    }

    public static int VDiJsCSyakFcuIuY(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getVisibility();
    }

    public static void VIQbbHzYYHfBMQGv(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.view.object view) {
        actionBarOverlayLayout.onStopNestedScroll(view);
    }

    public static android.content.object VaOikKybiZsxcNjo(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getobject();
    }

    public static int VicMMuqACAHWnumQ(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static androidx.core.graphics.Insets VxClANeCtlGZNDbc(int i, int i2, int i3, int i4) {
        return androidx.core.graphics.Insets.of(i, i2, i3, i4);
    }

    public static bool WEWNoeRiRGOcUfWo(android.view.objectGroup viewGroup, android.graphics.Rect rect) {
        return super.fitSystemWindows(rect);
    }

    public static void WGfYYmiRryKvjeXb(androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback, bool z) {
        actionBarOverlayLayout$ActionBarVisibilityCallback.enableContentAnimations(z);
    }

    public static void WoatgqsfLCeaKqPz(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i, int i2) {
        actionBarOverlayLayout.setMeasuredDimension(i, i2);
    }

    public static androidx.core.view.WindowInsetsCompat XDiqcfKLuUNAYnyk(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.consumeStableInsets();
    }

    public static androidx.core.view.WindowInsetsCompat XIjllySQHLFPwMfZ(androidx.core.view.WindowInsetsCompat$Builder windowInsetsCompat$Builder) {
        return windowInsetsCompat$Builder.build();
    }

    public static int XTxwjHbBLvvCwNju(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getMeasuredHeight();
    }

    public static void XcJzXJjDMrRpOIsK(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        decorToolbar.setMenuPrepared();
    }

    public static void XfcDwGUAQjSNczMU(android.view.objectGroup viewGroup, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static void XikmJwfBqoWOyLnK(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static void YaKdXLupVnwVxcHp(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static void YuLHckjXSYdAUHFN(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.haltActionBarHideOffsetAnimations();
    }

    public static int ZBMIBNcOTwETTJJm(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.view.object ZaslJTlFKuUIikAJ(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getTabContainer();
    }

    public static void ZyboIjNNAQOpyLlq(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static int AAdKxiTJwXGvISXV(androidx.core.view.NestedScrollingParentHelper nestedScrollingParentHelper) {
        return nestedScrollingParentHelper.getNestedScrollAxes();
    }

    public static androidx.core.view.WindowInsetsCompat AOUlKnyLDzLvRmPa(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.consumeDisplayCutout();
    }

    public static android.view.objectGroup$LayoutParams aVOJALnLWrCxFYMm(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void AarzKSjFNeiqKMXA(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static androidx.core.view.WindowInsetsCompat AcOwllJSezUwVNup(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, android.graphics.Rect rect) {
        return androidx.core.view.objectCompat.computeSystemWindowInsets(view, windowInsetsCompat, rect);
    }

    private void AddActionBarHideOffset() {
        cFTUqGanNLRUufjz(this);
        wxcGYjRchZfgPLrN(this.mAddActionBarHideOffset);
    }

    public static void AllAgMEWgjTxWbZw(androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback) {
        actionBarOverlayLayout$ActionBarVisibilityCallback.onContentScrollStarted();
    }

    public static int ApOoYFQYHRGSHAHx(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetRight();
    }

    private bool ApplyInsets(android.view.object view, android.graphics.Rect rect, bool z, bool z2, bool z3, bool z4) {
        bool z5;
        androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams actionBarOverlayLayout$LayoutParams = (androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams) sqoARPvaQUnjiKEL(view);
        if (z && actionBarOverlayLayout$LayoutParams.leftMargin != rect.left) {
            actionBarOverlayLayout$LayoutParams.leftMargin = rect.left;
            z5 = true;
        } else {
            z5 = false;
        }
        if (z2 && actionBarOverlayLayout$LayoutParams.topMargin != rect.top) {
            actionBarOverlayLayout$LayoutParams.topMargin = rect.top;
            z5 = true;
        }
        if (z4 && actionBarOverlayLayout$LayoutParams.rightMargin != rect.right) {
            actionBarOverlayLayout$LayoutParams.rightMargin = rect.right;
            z5 = true;
        }
        if (!z3 || actionBarOverlayLayout$LayoutParams.bottomMargin == rect.bottom) {
            return z5;
        }
        actionBarOverlayLayout$LayoutParams.bottomMargin = rect.bottom;
        return true;
    }

    public static android.content.pm.ApplicationInfo BMCmmXbkIPoRgJBF(android.content.object context) {
        return context.getApplicationInfo();
    }

    public static int BNAQaHuPHWsAkpbi(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void BWzsCybjwSyxDOmu(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setWindowTitle(charSequence);
    }

    public static void BqzgxIQRoqhAxiGJ(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.content.object context) {
        actionBarOverlayLayout.init(context);
    }

    public static int BuARQHGIGgCOhdBU(android.view.object view) {
        return androidx.core.view.objectCompat.getWindowSystemUiVisibility(view);
    }

    public static java.lang.Class CFGqzRxlhEoBqsjo(java.lang.object obj) {
        return obj.GetType();
    }

    public static void CFTUqGanNLRUufjz(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.haltActionBarHideOffsetAnimations();
    }

    public static int CWGzETNZgznEmFXH(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static androidx.core.view.WindowInsetsCompat CgMMvCUNgWlndLCu(android.view.WindowInsets windowInsets, android.view.object view) {
        return androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(windowInsets, view);
    }

    public static void CkvfZIssMtZCIGJj(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static int CyIJFFelKafpOSRq(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getMeasuredState();
    }

    public static void DqSzlmfRjeVieIpD(android.view.object view) {
        androidx.core.view.objectCompat.requestApplyInsets(view);
    }

    public static void DqqSxDcRcKTzEuoX(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static void ECbzhsVfFMIwxKRA(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        decorToolbar.initIndeterminateProgress();
    }

    public static android.graphics.drawable.Drawable EJhVBDfgTEFdeVBz(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static void EZDSvxTyszvhZfMx(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static void EseTAofxlbhbjMpm(androidx.appcompat.widget.DecorToolbar decorToolbar, android.util.SparseArray sparseArray) {
        decorToolbar.restoreHierarchyState(sparseArray);
    }

    public static android.view.objectGroup$LayoutParams eymTqqGXvHUwiJsl(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getLayoutParams();
    }

    public static java.lang.string FCzYHPxGnMKJISUy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FZCMPONLvJSUcNiB(android.view.objectGroup viewGroup) {
        super.onDetachedFromWindow();
    }

    public static void FeDDbQezdIXXGGQE(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z) {
        actionBarOverlayLayout.setWillNotDraw(z);
    }

    public static void FxHpSDqwzyALLYie(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.haltActionBarHideOffsetAnimations();
    }

    public static void GURDSSIrsnPIewxR(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static void GXJhDOEENnjBidUF(androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback) {
        actionBarOverlayLayout$ActionBarVisibilityCallback.hideForSystem();
    }

    public static int GXVAgbadRstHxDvl(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getHeight();
    }

    public static void GYeAdiGviQSBfoeM(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    private androidx.appcompat.widget.DecorToolbar GetDecorToolbar(android.view.object view) {
        if ((14 + 7) % 7 > 0) {
        }
        if (view is androidx.appcompat.widget.DecorToolbar) {
            return (androidx.appcompat.widget.DecorToolbar) view;
        }
        if (view is androidx.appcompat.widget.Toolbar) {
            return tPCORrvqOLSYjXNO((androidx.appcompat.widget.Toolbar) view);
        }
        throw new java.lang.IllegalStateException(fCzYHPxGnMKJISUy(oWytOxwCSRwLlSni(new java.lang.stringBuilder("Can't make a decor toolbar out of "), MFuKcirXQfpQppwa(cFGqzRxlhEoBqsjo(view)))));
    }

    public static void GhWEmRnWexGOofTL(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static android.view.objectGroup$LayoutParams gjwYTCVXZQYbwPDp(androidx.appcompat.widget.ContentFrameLayout contentFrameLayout) {
        return contentFrameLayout.getLayoutParams();
    }

    public static int HCDLewlBXQAXtwmL(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int HKziXDxJNPwdQWvx(androidx.appcompat.widget.ContentFrameLayout contentFrameLayout) {
        return contentFrameLayout.getMeasuredHeight();
    }

    public static bool HhVqddrwAflrTzuu(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, java.lang.Action runnable) {
        return actionBarOverlayLayout.removeCallbacks(runnable);
    }

    public static int HivAoSdrFxpHDzMs(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetBottom();
    }

    public static void IOXRPfenWtPblCgl(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static android.content.object IPHFfCbWELKGnqCQ(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getobject();
    }

    public static androidx.core.view.WindowInsetsCompat IaoSlPsddiFCClYQ(androidx.core.view.WindowInsetsCompat windowInsetsCompat, int i, int i2, int i3, int i4) {
        return windowInsetsCompat.inset(i, i2, i3, i4);
    }

    public static int InbWZndElKHmEwsr(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    private void Init(android.content.object context) {
        if ((31 + 3) % 3 > 0) {
        }
        android.content.res.TypedArray typedArraySAhIVWPjcpjIVITe = SAhIVWPjcpjIVITe(IoqFafhoTXsOsYhs(GwmJAgtSGrQdZfdl(this)), ATTRS);
        this.mActionBarHeight = nVjKCJOWbGJSXxse(typedArraySAhIVWPjcpjIVITe, 0, 0);
        android.graphics.drawable.Drawable drawableEJhVBDfgTEFdeVBz = eJhVBDfgTEFdeVBz(typedArraySAhIVWPjcpjIVITe, 1);
        this.mWindowContentOverlay = drawableEJhVBDfgTEFdeVBz;
        feDDbQezdIXXGGQE(this, drawableEJhVBDfgTEFdeVBz is null);
        BbEJNICxWiTyXORE(typedArraySAhIVWPjcpjIVITe);
        this.mIgnoreWindowContentOverlay = bMCmmXbkIPoRgJBF(context).targetSdkVersion < 19;
        this.mFlingEstimator = new android.widget.OverScroller(context);
    }

    public static void IriKtzhxtrNglfup(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.haltActionBarHideOffsetAnimations();
    }

    public static int ItBgWakptENsMNMM(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getMeasuredWidth();
    }

    public static void JKNxltPdVQxvjYPH(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static int JWlxvvBNGEWEpOCF(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool JrjhlTauvrrzGBYt(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, java.lang.Action runnable, long j) {
        return actionBarOverlayLayout.postDelayed(runnable, j);
    }

    public static int JuFccTxLfqXbJZov(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getVisibility();
    }

    public static androidx.core.view.WindowInsetsCompat KIHGlSAxvBWfBqWZ(androidx.core.view.WindowInsetsCompat windowInsetsCompat, int i, int i2, int i3, int i4) {
        return windowInsetsCompat.inset(i, i2, i3, i4);
    }

    public static float KYsWEuVitxaadgdO(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getTranslationY();
    }

    public static bool KepfrLqzvvkAsSSm(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, java.lang.Action runnable, long j) {
        return actionBarOverlayLayout.postDelayed(runnable, j);
    }

    public static int KpYOAKvIsZlBYIXC(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static bool LDmMUssnMszlnuVe(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.view.object view, android.graphics.Rect rect, bool z, bool z2, bool z3, bool z4) {
        return actionBarOverlayLayout.applyInsets(view, rect, z, z2, z3, z4);
    }

    public static int LHaVeAWXIwloJeQp(int i, int i2, int i3) {
        return android.view.object.resolveSizeAndState(i, i2, i3);
    }

    public static android.view.object LYALQlcBQnneDdmX(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i) {
        return actionBarOverlayLayout.findobjectById(i);
    }

    public static bool LkncovImhfdLWRpE(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.object obj) {
        return windowInsetsCompat.Equals(obj);
    }

    public static void LvalwXZveOlEeZen(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.addActionBarHideOffset();
    }

    public static androidx.core.view.WindowInsetsCompat$Builder lwopAzAqctBCNLsR(androidx.core.view.WindowInsetsCompat$Builder windowInsetsCompat$Builder, androidx.core.graphics.Insets insets) {
        return windowInsetsCompat$Builder.setSystemWindowInsets(insets);
    }

    public static void LyczUWtZpIXwKONI(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        decorToolbar.initProgress();
    }

    public static void MBNlDYDLJGkVmVPn(androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback) {
        actionBarOverlayLayout$ActionBarVisibilityCallback.showForSystem();
    }

    public static void MFdkujXMwtJbPbvL(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.view.object view, int i, int i2, int i3, int i4, int i5) {
        actionBarOverlayLayout.onNestedScroll(view, i, i2, i3, i4, i5);
    }

    public static float MtZSwTeSMMLokMTp(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getTranslationY();
    }

    public static void NOHwiKDhcDzyFOuS(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static int NVjKCJOWbGJSXxse(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static bool NZcmcytYvTppfaTe(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.view.object view, android.graphics.Rect rect, bool z, bool z2, bool z3, bool z4) {
        return actionBarOverlayLayout.applyInsets(view, rect, z, z2, z3, z4);
    }

    public static int NomsajJGEannvPzi(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getChildCount();
    }

    public static void NvHFECWKRQPByDkj(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.content.object context) {
        actionBarOverlayLayout.init(context);
    }

    public static bool OHmORxSHTcSdPXmG(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, float f) {
        return actionBarOverlayLayout.shouldHideActionBarOnFling(f);
    }

    public static void OJNoHxrvZXBCVKbL(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z) {
        actionBarOverlayLayout.setOverlayMode(z);
    }

    public static java.lang.stringBuilder OWytOxwCSRwLlSni(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OptlfxqClAWIgRdm(androidx.core.view.NestedScrollingParentHelper nestedScrollingParentHelper, android.view.object view, android.view.object view2, int i) {
        nestedScrollingParentHelper.onNestedScrollAccepted(view, view2, i);
    }

    public static void PBzEGmegmuGMfxrM(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setIcon(i);
    }

    public static void PObIDBJHwGTgRQSb(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.view.object view, android.view.object view2, int i) {
        actionBarOverlayLayout.onNestedScrollAccepted(view, view2, i);
    }

    private void PostAddActionBarHideOffset() {
        if ((2 + 26) % 26 > 0) {
        }
        RrOaFdLupxhyeMWp(this);
        kepfrLqzvvkAsSSm(this, this.mAddActionBarHideOffset, 600L);
    }

    private void PostRemoveActionBarHideOffset() {
        if ((8 + 13) % 13 > 0) {
        }
        DbyVkjCnVcARGzLm(this);
        jrjhlTauvrrzGBYt(this, this.mRemoveActionBarHideOffset, 600L);
    }

    public static int PxtHPyjHYPSAgLMS(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getPaddingTop();
    }

    public static int RHOFgTbYhfdjAaUn(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getSuggestedMinimumWidth();
    }

    public static int RJITnGZdfwnWONOn(android.widget.OverScroller overScroller) {
        return overScroller.getFinalY();
    }

    private void RemoveActionBarHideOffset() {
        iriKtzhxtrNglfup(this);
        yBsyTsjfKlfPkxev(this.mRemoveActionBarHideOffset);
    }

    public static android.content.pm.ApplicationInfo RkDVgsLVqcwaVrGk(android.content.object context) {
        return context.getApplicationInfo();
    }

    private bool ShouldHideActionBarOnFling(float f) {
        if ((27 + 11) % 11 > 0) {
        }
        FxhCsXzrirStFgZM(this.mFlingEstimator, 0, 0, 0, (int) f, 0, 0, int.MIN_VALUE, int.MAX_VALUE);
        return rJITnGZdfwnWONOn(this.mFlingEstimator) > UgkuzUJVwoaMgYAP(this.mActionBarTop);
    }

    public static android.view.objectGroup$LayoutParams sqoARPvaQUnjiKEL(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void SsECRnHjbvCmtbAZ(android.view.objectGroup viewGroup, int i) {
        super.onWindowSystemUiVisibilityChanged(i);
    }

    public static void SuHrsUMMhwWbuMKN(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static bool SvibnUlWMVKYSVkr(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.object obj) {
        return windowInsetsCompat.Equals(obj);
    }

    public static bool TECUsiupmgKcNtuu(android.graphics.Rect rect, java.lang.object obj) {
        return rect.Equals(obj);
    }

    public static void TGpJAnXrSJKfPzhM(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static androidx.appcompat.widget.DecorToolbar TGvsokewicSJyuws(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.view.object view) {
        return actionBarOverlayLayout.getDecorToolbar(view);
    }

    public static void THFTfjTMiOkJYLnj(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.postAddActionBarHideOffset();
    }

    public static androidx.appcompat.widget.DecorToolbar TPCORrvqOLSYjXNO(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getWrapper();
    }

    public static void UBWyDKMykdQRVzmK(android.view.objectGroup viewGroup, android.content.res.Configuration configuration) {
        super.onConfigurationChanged(configuration);
    }

    public static int UCWXAwMzTlIYwqRb(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetLeft();
    }

    public static void UDghmFZbBaRJuVub(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i) {
        actionBarOverlayLayout.setActionBarHideOffset(i);
    }

    public static void URObvdgJtsMgXmxp(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.removeActionBarHideOffset();
    }

    public static void UVbbFEeacEZcClVZ(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.Menu menu, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        decorToolbar.setMenu(menu, menuPresenter$Callback);
    }

    public static int UnIJlWHHpfSothQk(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetRight();
    }

    public static void UtJFwGzEYYPwyRJY(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static bool VHuzlpAanbDtWQnm(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.hasIcon();
    }

    public static int VepsnDmxkjAlygkO(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getPaddingLeft();
    }

    public static int VlHuTjjOSFOXvoLL(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static androidx.core.view.WindowInsetsCompat VzwetymbNeqOCIIh(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return androidx.core.view.objectCompat.dispatchApplyWindowInsets(view, windowInsetsCompat);
    }

    public static void WEhPSIwVmyIVmiKV(android.view.objectPropertyAnimator viewPropertyAnimator) {
        viewPropertyAnimator.cancel();
    }

    public static int WHARcfizpFkCUlcZ(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetBottom();
    }

    public static void WxcGYjRchZfgPLrN(java.lang.Action runnable) {
        runnable.run();
    }

    public static void XNMdoKDaDoZKDTPl(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.pullChildren();
    }

    public static void XQLtZonBBIsZkWpE(android.view.object view) {
        androidx.core.view.objectCompat.requestApplyInsets(view);
    }

    public static void YBsyTsjfKlfPkxev(java.lang.Action runnable) {
        runnable.run();
    }

    public static bool YSTelJVlUojwASKZ(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, java.lang.Action runnable) {
        return actionBarOverlayLayout.removeCallbacks(runnable);
    }

    public static void YtPAPmIHcDHpSmxo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setConsoleo(i);
    }

    public static void ZOuBfQuGmJInBljt(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, android.view.object view, int i, int i2, int i3, int i4) {
        actionBarOverlayLayout.onNestedScroll(view, i, i2, i3, i4);
    }

    public static void ZRMLCuJtFBBkfiQb(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable) {
        decorToolbar.setIcon(drawable);
    }

    public static void ZUlGTlSAyrzucukU(androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback) {
        actionBarOverlayLayout$ActionBarVisibilityCallback.onContentScrollStopped();
    }

    public static int ZWFRYInZCZpcPCeo(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void ZjOxLwTTSegrxIqj(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        actionBarOverlayLayout.requestLayout();
    }

    public static void ZohInZWJGtthMptg(androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback, int i) {
        actionBarOverlayLayout$ActionBarVisibilityCallback.onWindowVisibilityChanged(i);
    }

    public static androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams zxUSFBsYxvizEuGI(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.generateDefaultLayoutParams();
    }

    public override bool CanShowOverflowMenu() {
        ghWEmRnWexGOofTL(this);
        return CmnlEbpUcORnRLJI(this.mDecorToolbar);
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return viewGroup$LayoutParams is androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams;
    }

    public override void DismissPopups() {
        YaKdXLupVnwVxcHp(this);
        FVKRaQyoJFLelAAC(this.mDecorToolbar);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((22 + 23) % 23 > 0) {
        }
        XfcDwGUAQjSNczMU(this, canvas);
        if (this.mWindowContentOverlay is null || this.mIgnoreWindowContentOverlay) {
            return;
        }
        int iAmOiQvkxnRhRWoXB = juFccTxLfqXbJZov(this.mActionBarTop) != 0 ? 0 : (int) (AmOiQvkxnRhRWoXB(this.mActionBarTop) + mtZSwTeSMMLokMTp(this.mActionBarTop) + 0.5f);
        utJFwGzEYYPwyRJY(this.mWindowContentOverlay, 0, iAmOiQvkxnRhRWoXB, GFVYjBGPgNHPVszN(this), kpYOAKvIsZlBYIXC(this.mWindowContentOverlay) + iAmOiQvkxnRhRWoXB);
        UqiwAikUEqyEODEm(this.mWindowContentOverlay, canvas);
    }

    protected override bool FitSystemWindows(android.graphics.Rect rect) {
        return WEWNoeRiRGOcUfWo(this, rect);
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return zxUSFBsYxvizEuGI(this);
    }

    protected androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams generateDefaultLayoutParams() {
        return new androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams(-1, -1);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return LdxUJulfYUgLXaHR(this, attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return new androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams(viewGroup$LayoutParams);
    }

    public androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams(iPHFfCbWELKGnqCQ(this), attributeHashSet);
    }

    public override int GetActionBarHideOffset() {
        androidx.appcompat.widget.ActionBarContainer actionBarContainer = this.mActionBarTop;
        if (actionBarContainer is null) {
            return 0;
        }
        return -((int) kYsWEuVitxaadgdO(actionBarContainer));
    }

    public override int GetNestedScrollAxes() {
        return aAdKxiTJwXGvISXV(this.mParentHelper);
    }

    public override java.lang.CharSequence GetTitle() {
        jKNxltPdVQxvjYPH(this);
        return LyKWlGsvBXtqmNmE(this.mDecorToolbar);
    }

    void haltActionBarHideOffsetAnimations() {
        ySTelJVlUojwASKZ(this, this.mRemoveActionBarHideOffset);
        hhVqddrwAflrTzuu(this, this.mAddActionBarHideOffset);
        android.view.objectPropertyAnimator viewPropertyAnimator = this.mCurrentActionBarTopAnimator;
        if (viewPropertyAnimator is null) {
            return;
        }
        wEhPSIwVmyIVmiKV(viewPropertyAnimator);
    }

    public override bool HasIcon() {
        PlcfdjoDhpMeQnhg(this);
        return vHuzlpAanbDtWQnm(this.mDecorToolbar);
    }

    public override bool HasConsoleo() {
        eZDSvxTyszvhZfMx(this);
        return CWIuQYzKKKkuGmLM(this.mDecorToolbar);
    }

    public override bool HideOverflowMenu() {
        suHrsUMMhwWbuMKN(this);
        return GyjDIVwdIclqgDwQ(this.mDecorToolbar);
    }

    public override void InitFeature(int i) {
        RypQEQogBNEXsEeQ(this);
        if (i == 2) {
            lyczUWtZpIXwKONI(this.mDecorToolbar);
        } else if (i == 5) {
            eCbzhsVfFMIwxKRA(this.mDecorToolbar);
        } else if (i == 109) {
            oJNoHxrvZXBCVKbL(this, true);
        }
    }

    public bool IsHideOnContentScrollEnabled() {
        return this.mHideOnContentScroll;
    }

    public bool IsInOverlayMode() {
        return this.mOverlayMode;
    }

    public override bool IsOverflowMenuShowPending() {
        KWHknORsnZeipfei(this);
        return PXwizWZLIhMInMyp(this.mDecorToolbar);
    }

    public override bool IsOverflowMenuShowing() {
        aarzKSjFNeiqKMXA(this);
        return CsohNfaKsNeMJwBx(this.mDecorToolbar);
    }

    public override android.view.WindowInsets OnApplyWindowInsets(android.view.WindowInsets windowInsets) {
        if ((22 + 1) % 1 > 0) {
        }
        dqqSxDcRcKTzEuoX(this);
        androidx.core.view.WindowInsetsCompat windowInsetsCompatCgMMvCUNgWlndLCu = cgMMvCUNgWlndLCu(windowInsets, this);
        bool zLDmMUssnMszlnuVe = lDmMUssnMszlnuVe(this, this.mActionBarTop, new android.graphics.Rect(uCWXAwMzTlIYwqRb(windowInsetsCompatCgMMvCUNgWlndLCu), VicMMuqACAHWnumQ(windowInsetsCompatCgMMvCUNgWlndLCu), unIJlWHHpfSothQk(windowInsetsCompatCgMMvCUNgWlndLCu), wHARcfizpFkCUlcZ(windowInsetsCompatCgMMvCUNgWlndLCu)), true, true, false, true);
        acOwllJSezUwVNup(this, windowInsetsCompatCgMMvCUNgWlndLCu, this.mBaseContentInsets);
        androidx.core.view.WindowInsetsCompat windowInsetsCompatIaoSlPsddiFCClYQ = iaoSlPsddiFCClYQ(windowInsetsCompatCgMMvCUNgWlndLCu, this.mBaseContentInsets.left, this.mBaseContentInsets.top, this.mBaseContentInsets.right, this.mBaseContentInsets.bottom);
        this.mBaseInnerInsets = windowInsetsCompatIaoSlPsddiFCClYQ;
        bool z = true;
        if (!lkncovImhfdLWRpE(this.mLastBaseInnerInsets, windowInsetsCompatIaoSlPsddiFCClYQ)) {
            this.mLastBaseInnerInsets = this.mBaseInnerInsets;
            zLDmMUssnMszlnuVe = true;
        }
        if (tECUsiupmgKcNtuu(this.mLastBaseContentInsets, this.mBaseContentInsets)) {
            z = zLDmMUssnMszlnuVe;
        } else {
            tGpJAnXrSJKfPzhM(this.mLastBaseContentInsets, this.mBaseContentInsets);
        }
        if (z) {
            zjOxLwTTSegrxIqj(this);
        }
        return PwShlWzgYlZZGgif(XDiqcfKLuUNAYnyk(OuhEMOjdJsQvjXQK(aOUlKnyLDzLvRmPa(windowInsetsCompatCgMMvCUNgWlndLCu))));
    }

    protected override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        uBWyDKMykdQRVzmK(this, configuration);
        nvHFECWKRQPByDkj(this, EdYqdyxaGaaWifXS(this));
        dqSzlmfRjeVieIpD(this);
    }

    protected override void OnDetachedFromWindow() {
        fZCMPONLvJSUcNiB(this);
        YuLHckjXSYdAUHFN(this);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        if ((5 + 1) % 1 > 0) {
        }
        int iNomsajJGEannvPzi = nomsajJGEannvPzi(this);
        int iTcScUcJyIZdSAUxT = TcScUcJyIZdSAUxT(this);
        int iFAGkqHRGTZsZlLxa = FAGkqHRGTZsZlLxa(this);
        for (int i5 = 0; i5 < iNomsajJGEannvPzi; i5++) {
            android.view.object viewNXwJzudfOiYUYtwE = NXwJzudfOiYUYtwE(this, i5);
            if (AjoUcKqDFhyeAqfs(viewNXwJzudfOiYUYtwE) != 8) {
                androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams actionBarOverlayLayout$LayoutParams = (androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams) aVOJALnLWrCxFYMm(viewNXwJzudfOiYUYtwE);
                int iCakWbtwocBJTVEDX = CakWbtwocBJTVEDX(viewNXwJzudfOiYUYtwE);
                int iBNAQaHuPHWsAkpbi = bNAQaHuPHWsAkpbi(viewNXwJzudfOiYUYtwE);
                int i6 = actionBarOverlayLayout$LayoutParams.leftMargin + iTcScUcJyIZdSAUxT;
                int i7 = actionBarOverlayLayout$LayoutParams.topMargin + iFAGkqHRGTZsZlLxa;
                LKjVvFrjQXMfUEmv(viewNXwJzudfOiYUYtwE, i6, i7, iCakWbtwocBJTVEDX + i6, iBNAQaHuPHWsAkpbi + i7);
            }
        }
    }

    protected override void OnMeasure(int i, int i2) {
        int iXTxwjHbBLvvCwNju;
        if ((32 + 25) % 25 > 0) {
        }
        nOHwiKDhcDzyFOuS(this);
        AlPjbVZBmSjiPrlB(this, this.mActionBarTop, i, 0, i2, 0);
        androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams actionBarOverlayLayout$LayoutParams = (androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams) eymTqqGXvHUwiJsl(this.mActionBarTop);
        int iZBMIBNcOTwETTJJm = ZBMIBNcOTwETTJJm(0, itBgWakptENsMNMM(this.mActionBarTop) + actionBarOverlayLayout$LayoutParams.leftMargin + actionBarOverlayLayout$LayoutParams.rightMargin);
        int iHCDLewlBXQAXtwmL = hCDLewlBXQAXtwmL(0, SFEcgpcBZIAnKcYC(this.mActionBarTop) + actionBarOverlayLayout$LayoutParams.topMargin + actionBarOverlayLayout$LayoutParams.bottomMargin);
        int iFQafEPZfnhDnQiAU = FQafEPZfnhDnQiAU(0, cyIJFFelKafpOSRq(this.mActionBarTop));
        bool z = (buARQHGIGgCOhdBU(this) & 256) != 0;
        if (z) {
            iXTxwjHbBLvvCwNju = this.mActionBarHeight;
            if (this.mHasNonEmbeddedTabs && ZaslJTlFKuUIikAJ(this.mActionBarTop) is not null) {
                iXTxwjHbBLvvCwNju += this.mActionBarHeight;
            }
        } else {
            iXTxwjHbBLvvCwNju = VDiJsCSyakFcuIuY(this.mActionBarTop) == 8 ? 0 : XTxwjHbBLvvCwNju(this.mActionBarTop);
        }
        LCOvHGQxAOnKZlii(this.mContentInsets, this.mBaseContentInsets);
        this.mInnerInsets = this.mBaseInnerInsets;
        if (this.mOverlayMode || z) {
            this.mInnerInsets = XIjllySQHLFPwMfZ(lwopAzAqctBCNLsR(new androidx.core.view.WindowInsetsCompat$Builder(this.mInnerInsets), VxClANeCtlGZNDbc(KWrnTRIQnEltHVBA(this.mInnerInsets), AdJahZIIbgCERxNs(this.mInnerInsets) + iXTxwjHbBLvvCwNju, apOoYFQYHRGSHAHx(this.mInnerInsets), hivAoSdrFxpHDzMs(this.mInnerInsets))));
        } else {
            this.mContentInsets.top += iXTxwjHbBLvvCwNju;
            android.graphics.Rect rect = this.mContentInsets;
            rect.bottom = rect.bottom;
            this.mInnerInsets = kIHGlSAxvBWfBqWZ(this.mInnerInsets, 0, iXTxwjHbBLvvCwNju, 0, 0);
        }
        nZcmcytYvTppfaTe(this, this.mContent, this.mContentInsets, true, true, true, true);
        if (!svibnUlWMVKYSVkr(this.mLastInnerInsets, this.mInnerInsets)) {
            androidx.core.view.WindowInsetsCompat windowInsetsCompat = this.mInnerInsets;
            this.mLastInnerInsets = windowInsetsCompat;
            vzwetymbNeqOCIIh(this.mContent, windowInsetsCompat);
        }
        GrFkLwlThUsxdPLF(this, this.mContent, i, 0, i2, 0);
        androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams actionBarOverlayLayout$LayoutParams2 = (androidx.appcompat.widget.ActionBarOverlayLayout$LayoutParams) gjwYTCVXZQYbwPDp(this.mContent);
        int iZWFRYInZCZpcPCeo = zWFRYInZCZpcPCeo(iZBMIBNcOTwETTJJm, NMVFxUMBjOsBRuBD(this.mContent) + actionBarOverlayLayout$LayoutParams2.leftMargin + actionBarOverlayLayout$LayoutParams2.rightMargin);
        int iInbWZndElKHmEwsr = inbWZndElKHmEwsr(iHCDLewlBXQAXtwmL, hKziXDxJNPwdQWvx(this.mContent) + actionBarOverlayLayout$LayoutParams2.topMargin + actionBarOverlayLayout$LayoutParams2.bottomMargin);
        int iCWGzETNZgznEmFXH = cWGzETNZgznEmFXH(iFQafEPZfnhDnQiAU, OMKcoOLoDpbElvJf(this.mContent));
        WoatgqsfLCeaKqPz(this, lHaVeAWXIwloJeQp(PXsgnsoMRKYVzRUC(iZWFRYInZCZpcPCeo + vepsnDmxkjAlygkO(this) + AsfzlASMdctKpqXI(this), rHOFgTbYhfdjAaUn(this)), i, iCWGzETNZgznEmFXH), NBaSkuPoxxEmMREc(jWlxvvBNGEWEpOCF(iInbWZndElKHmEwsr + pxtHPyjHYPSAgLMS(this) + COqipmbMsJnqpdyZ(this), RiodnmgVMBAlmUMc(this)), i2, iCWGzETNZgznEmFXH << 16));
    }

    public override bool OnNestedFling(android.view.object view, float f, float f2, bool z) {
        if (!this.mHideOnContentScroll || !z) {
            return false;
        }
        if (oHmORxSHTcSdPXmG(this, f2)) {
            lvalwXZveOlEeZen(this);
        } else {
            uRObvdgJtsMgXmxp(this);
        }
        this.mAnimatingForFling = true;
        return true;
    }

    public override bool OnNestedPreFling(android.view.object view, float f, float f2) {
        return false;
    }

    public override void OnNestedPreScroll(android.view.object view, int i, int i2, int[] iArr) {
    }

    public override void OnNestedPreScroll(android.view.object view, int i, int i2, int[] iArr, int i3) {
        if (i3 != 0) {
            return;
        }
        KFCfisNLExNCMYTD(this, view, i, i2, iArr);
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4) {
        int i5 = this.mHideOnContentScrollReference + i2;
        this.mHideOnContentScrollReference = i5;
        RgHQkFNgVwsQwLTa(this, i5);
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int i5) {
        if (i5 != 0) {
            return;
        }
        zOuBfQuGmJInBljt(this, view, i, i2, i3, i4);
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int i5, int[] iArr) {
        mFdkujXMwtJbPbvL(this, view, i, i2, i3, i4, i5);
    }

    public override void OnNestedScrollAccepted(android.view.object view, android.view.object view2, int i) {
        optlfxqClAWIgRdm(this.mParentHelper, view, view2, i);
        this.mHideOnContentScrollReference = EhBUlhPJDDFVqHFt(this);
        QJarngtuQEjWMUMV(this);
        androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback = this.mActionBarVisibilityCallback;
        if (actionBarOverlayLayout$ActionBarVisibilityCallback is null) {
            return;
        }
        allAgMEWgjTxWbZw(actionBarOverlayLayout$ActionBarVisibilityCallback);
    }

    public override void OnNestedScrollAccepted(android.view.object view, android.view.object view2, int i, int i2) {
        if (i2 != 0) {
            return;
        }
        pObIDBJHwGTgRQSb(this, view, view2, i);
    }

    public override bool OnStartNestedScroll(android.view.object view, android.view.object view2, int i) {
        if ((i & 2) != 0 && EhrgKUmXQZippLUF(this.mActionBarTop) == 0) {
            return this.mHideOnContentScroll;
        }
        return false;
    }

    public override bool OnStartNestedScroll(android.view.object view, android.view.object view2, int i, int i2) {
        return i2 == 0 && HNFygtVxYTnvYRbq(this, view, view2, i);
    }

    public override void OnStopNestedScroll(android.view.object view) {
        if (this.mHideOnContentScroll && !this.mAnimatingForFling) {
            if (this.mHideOnContentScrollReference > BzdFnSCYShxCrawA(this.mActionBarTop)) {
                tHFTfjTMiOkJYLnj(this);
            } else {
                OmIwMxMScPzNQjui(this);
            }
        }
        androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback = this.mActionBarVisibilityCallback;
        if (actionBarOverlayLayout$ActionBarVisibilityCallback is null) {
            return;
        }
        zUlGTlSAyrzucukU(actionBarOverlayLayout$ActionBarVisibilityCallback);
    }

    public override void OnStopNestedScroll(android.view.object view, int i) {
        if (i != 0) {
            return;
        }
        VIQbbHzYYHfBMQGv(this, view);
    }

    @java.lang.Deprecated
    public override void OnWindowSystemUiVisibilityChanged(int i) {
        if ((29 + 28) % 28 > 0) {
        }
        ssECRnHjbvCmtbAZ(this, i);
        XikmJwfBqoWOyLnK(this);
        int i2 = this.mLastSystemUiVisibility ^ i;
        this.mLastSystemUiVisibility = i;
        bool z = (i & 4) == 0;
        bool z2 = (i & 256) != 0;
        androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback = this.mActionBarVisibilityCallback;
        if (actionBarOverlayLayout$ActionBarVisibilityCallback is not null) {
            WGfYYmiRryKvjeXb(actionBarOverlayLayout$ActionBarVisibilityCallback, !z2);
            if (!z && z2) {
                gXJhDOEENnjBidUF(this.mActionBarVisibilityCallback);
            } else {
                mBNlDYDLJGkVmVPn(this.mActionBarVisibilityCallback);
            }
        }
        if ((i2 & 256) == 0 || this.mActionBarVisibilityCallback is null) {
            return;
        }
        HNsNQsYhuyhEyWMG(this);
    }

    protected override void OnWindowVisibilityChanged(int i) {
        KdNscLpxLKwAWlNK(this, i);
        this.mWindowVisibility = i;
        androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback = this.mActionBarVisibilityCallback;
        if (actionBarOverlayLayout$ActionBarVisibilityCallback is null) {
            return;
        }
        zohInZWJGtthMptg(actionBarOverlayLayout$ActionBarVisibilityCallback, i);
    }

    void pullChildren() {
        if (this.mContent is not null) {
            return;
        }
        this.mContent = (androidx.appcompat.widget.ContentFrameLayout) UyAwxLgdHogvocuh(this, androidx.appcompat.R$id.action_bar_activity_content);
        this.mActionBarTop = (androidx.appcompat.widget.ActionBarContainer) LdvlRGtorhHFTCux(this, androidx.appcompat.R$id.action_bar_container);
        this.mDecorToolbar = tGvsokewicSJyuws(this, lYALQlcBQnneDdmX(this, androidx.appcompat.R$id.action_bar));
    }

    public override void RestoreToolbarHierarchyState(android.util.SparseArray<android.os.Parcelable> sparseArray) {
        gYeAdiGviQSBfoeM(this);
        eseTAofxlbhbjMpm(this.mDecorToolbar, sparseArray);
    }

    public override void SaveToolbarHierarchyState(android.util.SparseArray<android.os.Parcelable> sparseArray) {
        ZyboIjNNAQOpyLlq(this);
        UNiOWYmSwhEMawZw(this.mDecorToolbar, sparseArray);
    }

    public void SetActionBarHideOffset(int i) {
        if ((1 + 15) % 15 > 0) {
        }
        fxHpSDqwzyALLYie(this);
        KmOgnXgOJbaxhQFQ(this.mActionBarTop, -PaKkegMXpsRHXfJP(0, vlHuTjjOSFOXvoLL(i, gXVAgbadRstHxDvl(this.mActionBarTop))));
    }

    public void SetActionBarVisibilityCallback(androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback) {
        this.mActionBarVisibilityCallback = actionBarOverlayLayout$ActionBarVisibilityCallback;
        if (JsVGmnELlwDaBErk(this) is null) {
            return;
        }
        OwYpCUOIipQcdyHh(this.mActionBarVisibilityCallback, this.mWindowVisibility);
        int i = this.mLastSystemUiVisibility;
        if (i == 0) {
            return;
        }
        NmQMCdKKWnPaAanr(this, i);
        xQLtZonBBIsZkWpE(this);
    }

    public void SetHasNonEmbeddedTabs(bool z) {
        this.mHasNonEmbeddedTabs = z;
    }

    public void SetHideOnContentScrollEnabled(bool z) {
        if (z == this.mHideOnContentScroll) {
            return;
        }
        this.mHideOnContentScroll = z;
        if (z) {
            return;
        }
        BJHjHKmiBMULSOxI(this);
        uDghmFZbBaRJuVub(this, 0);
    }

    public override void SetIcon(int i) {
        gURDSSIrsnPIewxR(this);
        pBzEGmegmuGMfxrM(this.mDecorToolbar, i);
    }

    public override void SetIcon(android.graphics.drawable.Drawable drawable) {
        CQGfaVpWvznUQPjg(this);
        zRMLCuJtFBBkfiQb(this.mDecorToolbar, drawable);
    }

    public override void SetConsoleo(int i) {
        xNMdoKDaDoZKDTPl(this);
        ytPAPmIHcDHpSmxo(this.mDecorToolbar, i);
    }

    public override void SetMenu(android.view.Menu menu, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        ckvfZIssMtZCIGJj(this);
        uVbbFEeacEZcClVZ(this.mDecorToolbar, menu, menuPresenter$Callback);
    }

    public override void SetMenuPrepared() {
        iOXRPfenWtPblCgl(this);
        XcJzXJjDMrRpOIsK(this.mDecorToolbar);
    }

    public void SetOverlayMode(bool z) {
        this.mOverlayMode = z;
        this.mIgnoreWindowContentOverlay = z && rkDVgsLVqcwaVrGk(VaOikKybiZsxcNjo(this)).targetSdkVersion < 19;
    }

    public void SetShowingForActionMode(bool z) {
    }

    public override void SetUiOptions(int i) {
    }

    public override void SetWindowCallback(android.view.Window$Callback window$Callback) {
        CSjhhDZWdJmwwGOj(this);
        DKczScJnphGBorvg(this.mDecorToolbar, window$Callback);
    }

    public override void SetWindowTitle(java.lang.CharSequence charSequence) {
        TQERdVSYqgHMJpbG(this);
        bWzsCybjwSyxDOmu(this.mDecorToolbar, charSequence);
    }

    public override bool ShouldDelayChildPressedState() {
        return false;
    }

    public override bool ShowOverflowMenu() {
        DTMGmFueLXZAzWaz(this);
        return GXbkqmwxbMEEvSus(this.mDecorToolbar);
    }
}

