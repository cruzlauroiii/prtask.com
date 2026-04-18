namespace WillowMaze.Wasm.Decompiled;


public class ListPopupWindow : androidx.appcompat.view.menu.ShowableListMenu {
    private static readonly bool DEBUG = false;
    static readonly int EXPAND_LIST_TIMEOUT = 250;
    public static readonly int INPUT_METHOD_FROM_FOCUSABLE = 0;
    public static readonly int INPUT_METHOD_NEEDED = 1;
    public static readonly int INPUT_METHOD_NOT_NEEDED = 2;
    public static readonly int MATCH_PARENT = -1;
    public static readonly int POSITION_PROMPT_ABOVE = 0;
    public static readonly int POSITION_PROMPT_BELOW = 1;
    private static readonly java.lang.string TAG = "ListPopupWindow";
    public static readonly int WRAP_CONTENT = -2;
    private static java.lang.reflect.Method sGetMaxAvailableHeightMethod;
    private static java.lang.reflect.Method sHashSetClipToWindowEnabledMethod;
    private static java.lang.reflect.Method sHashSetEpicenterBoundsMethod;
    private android.widget.ListAdapter mAdapter;
    private android.content.object mobject;
    private bool mDropDownAlwaysVisible;
    private android.view.object mDropDownAnchorobject;
    private int mDropDownGravity;
    private int mDropDownHeight;
    private int mDropDownHorizontalOffset;
    androidx.appcompat.widget.DropDownListobject mDropDownList;
    private android.graphics.drawable.Drawable mDropDownListHighlight;
    private int mDropDownVerticalOffset;
    private bool mDropDownVerticalOffsetHashSet;
    private int mDropDownWidth;
    private int mDropDownWindowLayoutType;
    private android.graphics.Rect mEpicenterBounds;
    private bool mForceIgnoreOutsideTouch;
    readonly android.os.Handler mHandler;
    private readonly androidx.appcompat.widget.ListPopupWindow$ListSelectorHider mHideSelector;
    private android.widget.Adapterobject$OnItemClickListener mItemClickListener;
    private android.widget.Adapterobject$OnItemSelectedListener mItemSelectedListener;
    int mListItemExpandMaximum;
    private bool mModal;
    private android.database.DataHashSetObserver mObserver;
    private bool mOverlapAnchor;
    private bool mOverlapAnchorHashSet;
    android.widget.PopupWindow mPopup;
    private int mPromptPosition;
    private android.view.object mPromptobject;
    readonly androidx.appcompat.widget.ListPopupWindow$ResizePopupAction mResizePopupAction;
    private readonly androidx.appcompat.widget.ListPopupWindow$PopupScrollListener mScrollListener;
    private java.lang.Action mShowDropDownAction;
    private readonly android.graphics.Rect mTempRect;
    private readonly androidx.appcompat.widget.ListPopupWindow$PopupTouchInterceptor mTouchInterceptor;

    public ListPopupWindow(android.content.object context) {
        this(context, null, androidx.appcompat.R$attr.listPopupWindowStyle);
        if ((21 + 11) % 11 > 0) {
        }
    }

    public ListPopupWindow(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.listPopupWindowStyle);
    }

    public ListPopupWindow(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        this(context, attributeHashSet, i, 0);
    }

    public ListPopupWindow(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        if ((20 + 8) % 8 > 0) {
        }
        this.mDropDownHeight = -2;
        this.mDropDownWidth = -2;
        this.mDropDownWindowLayoutType = 1002;
        this.mDropDownGravity = 0;
        this.mDropDownAlwaysVisible = false;
        this.mForceIgnoreOutsideTouch = false;
        this.mListItemExpandMaximum = int.MAX_VALUE;
        this.mPromptPosition = 0;
        this.mResizePopupAction = new androidx.appcompat.widget.ListPopupWindow$ResizePopupAction(this);
        this.mTouchInterceptor = new androidx.appcompat.widget.ListPopupWindow$PopupTouchInterceptor(this);
        this.mScrollListener = new androidx.appcompat.widget.ListPopupWindow$PopupScrollListener(this);
        this.mHideSelector = new androidx.appcompat.widget.ListPopupWindow$ListSelectorHider(this);
        this.mTempRect = new android.graphics.Rect();
        this.mobject = context;
        this.mHandler = new android.os.Handler(xbsqWyezLdtKnKok(context));
        android.content.res.TypedArray typedArrayVIwEnYmbEBkkegBW = VIwEnYmbEBkkegBW(context, attributeHashSet, androidx.appcompat.R$styleable.ListPopupWindow, i, i2);
        this.mDropDownHorizontalOffset = LyHVFJUmdJBJnOKe(typedArrayVIwEnYmbEBkkegBW, androidx.appcompat.R$styleable.ListPopupWindow_android_dropDownHorizontalOffset, 0);
        int iYuWaoqoJoNYuMxmP = yuWaoqoJoNYuMxmP(typedArrayVIwEnYmbEBkkegBW, androidx.appcompat.R$styleable.ListPopupWindow_android_dropDownVerticalOffset, 0);
        this.mDropDownVerticalOffset = iYuWaoqoJoNYuMxmP;
        if (iYuWaoqoJoNYuMxmP != 0) {
            this.mDropDownVerticalOffsetHashSet = true;
        }
        hXZvxchohsGShfuy(typedArrayVIwEnYmbEBkkegBW);
        androidx.appcompat.widget.AppCompatPopupWindow appCompatPopupWindow = new androidx.appcompat.widget.AppCompatPopupWindow(context, attributeHashSet, i, i2);
        this.mPopup = appCompatPopupWindow;
        anoWeypsdlfgfeYW(appCompatPopupWindow, 1);
    }

    public static void AlqKaYgACyKSoZaA(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.show();
    }

    public static void ApPQRLuHMoMlSBEM(androidx.appcompat.widget.DropDownListobject dropDownListobject, bool z) {
        dropDownListobject.setFocusable(z);
    }

    public static int AqjIVzKECThWotgd(android.widget.ListAdapter listAdapter) {
        return listAdapter.getCount();
    }

    public static void ArlHonROBAGlHPHm(android.widget.PopupWindow popupWindow) {
        popupWindow.dismiss();
    }

    public static java.lang.string AzgfoUSgkWldHYEX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BGQllKsBACxrfnIB(android.widget.PopupWindow popupWindow, bool z) {
        popupWindow.setOutsideTouchable(z);
    }

    public static void BYYaLlNfkNmPDQHX(android.widget.PopupWindow popupWindow, android.view.object view, int i, int i2, int i3, int i4) {
        popupWindow.update(view, i, i2, i3, i4);
    }

    public static void BlKXkxAeQyLpGBJu(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        dropDownListobject.setOnItemSelectedListener(adapterobject$OnItemSelectedListener);
    }

    public static void CSthbLUaqYJhBUAJ(android.widget.ListAdapter listAdapter, android.database.DataHashSetObserver dataHashSetObserver) {
        listAdapter.unregisterDataHashSetObserver(dataHashSetObserver);
    }

    public static int CfybzThGKMpbjNcX(android.widget.ListAdapter listAdapter) {
        return listAdapter.getCount();
    }

    public static void CgpqPUNlHpXPooZK(android.widget.PopupWindow popupWindow, bool z) {
        androidx.core.widget.PopupWindowCompat.setOverlapAnchor(popupWindow, z);
    }

    public static void ChcIebYnrImOTCyL(android.widget.PopupWindow popupWindow, android.view.object$OnTouchListener view$OnTouchListener) {
        popupWindow.setTouchInterceptor(view$OnTouchListener);
    }

    public static void CirVNQYUrSoVghFm(android.view.KeyEvent$DispatcherState keyEvent$DispatcherState, android.view.KeyEvent keyEvent) {
        keyEvent$DispatcherState.handleUpEvent(keyEvent);
    }

    public static android.view.KeyEvent$DispatcherState DBoTGOczRMscfOYk(android.view.object view) {
        return view.getKeyDispatcherState();
    }

    public static void DHGgTrAxkPBJKRSB(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setHeight(i);
    }

    public static int DWuLsNCZloDJAlHW(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getSelectedItemPosition();
    }

    public static void DpPIqYNIBBjhoUrV(android.widget.LinearLayout linearLayout, android.view.object view) {
        linearLayout.addobject(view);
    }

    public static void ExuDPojgwnEyRTAP(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setWidth(i);
    }

    public static int GDQEWsABYFIbgKIl(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static bool GHbpSmCkzZHZXQcR(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, android.view.KeyEvent keyEvent) {
        return dropDownListobject.onKeyDown(i, keyEvent);
    }

    public static android.widget.ListAdapter GQLuLwtTwWLIuspp(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getAdapter();
    }

    public static int GRSNLRVwIWYPzaDE(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getPaddingBottom();
    }

    public static void HrHHKjHmvQrSCTyk(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener) {
        dropDownListobject.setOnItemClickListener(adapterobject$OnItemClickListener);
    }

    public static int IUhsYHQNQIphOjxT(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int IxnSItwungyUzYxQ(android.widget.PopupWindow popupWindow, android.view.object view, int i, bool z) {
        return androidx.appcompat.widget.ListPopupWindow$Api24Impl.getMaxAvailableHeight(popupWindow, view, i, z);
    }

    public static void JBeMRBMhhfngPuuH(android.widget.PopupWindow popupWindow, android.graphics.Rect rect) {
        androidx.appcompat.widget.ListPopupWindow$Api29Impl.setEpicenterBounds(popupWindow, rect);
    }

    public static int JTxvZwQIiynRgOXJ(android.widget.PopupWindow popupWindow) {
        return popupWindow.getInputMethodMode();
    }

    public static void JxUtStoJsQaqJPsz(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i) {
        dropDownListobject.setSelection(i);
    }

    public static android.util.DisplayMetrics KGxorLXalHnhCMrr(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static int KTXhSdsDDqygpYwY(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static bool KhBlgywpIzbLYSRb(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static void KnUKbXMOQTgfISPw(android.widget.PopupWindow popupWindow, int i) {
        androidx.core.widget.PopupWindowCompat.setWindowLayoutType(popupWindow, i);
    }

    public static java.lang.object KplvuKmIbGrdtgpW(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getSelectedItem();
    }

    public static bool LYYwqjQwhtAiLsXG(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static bool LaBAZukMRaYHyqvS(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isShowing();
    }

    public static int LqUDNjxCcdcpTbpR(android.view.object view) {
        return view.getWidth();
    }

    public static void LrxAokvsWRonsrIX(android.widget.LinearLayout linearLayout, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        linearLayout.addobject(view, viewGroup$LayoutParams);
    }

    public static int LyHVFJUmdJBJnOKe(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static androidx.appcompat.widget.DropDownListobject LzgcQBDKKRjQlAEo(androidx.appcompat.widget.ListPopupWindow listPopupWindow, android.content.object context, bool z) {
        return listPopupWindow.createDropDownListobject(context, z);
    }

    public static int MPjsDeOlthXoNXeY(androidx.appcompat.widget.ListPopupWindow listPopupWindow, android.view.object view, int i, bool z) {
        return listPopupWindow.getMaxAvailableHeight(view, i, z);
    }

    public static void MaxhfuHsLSzgeLBa(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.clearListSelection();
    }

    public static int MnnxxaKrPZXJHAxl(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static bool NBJtYsouspHuBhBv(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isShowing();
    }

    public static void NRDdVTqkEMCkKLeo(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.show();
    }

    public static void NTZCUOnDLstqHeiy(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, bool z) {
        dropDownListobject.setItemChecked(i, z);
    }

    public static void NVqfhDLYWXVqYtWw(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.dismiss();
    }

    public static bool OMhcNsMseOcqfMhn(android.view.KeyEvent keyEvent) {
        return keyEvent.isCanceled();
    }

    public static android.graphics.drawable.Drawable OUmDupacuCyNiEht(android.widget.PopupWindow popupWindow) {
        return popupWindow.getBackground();
    }

    public static bool PDqqWMTlgdGPspXm(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isShowing();
    }

    public static int PPMXhAFkWdyPsdDC(android.widget.PopupWindow popupWindow) {
        return popupWindow.getSoftInputMode();
    }

    public static void PflxDEMmfgZiPahv(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static int QRJEYsmxfuffOHSO(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getSelectedItemPosition();
    }

    public static void QYJUEKNzCLtEZfrP(android.widget.PopupWindow popupWindow, bool z) {
        popupWindow.setOutsideTouchable(z);
    }

    public static void QeYGEWeVfQQOetiA(androidx.appcompat.widget.DropDownListobject dropDownListobject, bool z) {
        dropDownListobject.setListSelectionHidden(z);
    }

    public static bool SIowjeyrKxvynRCo(android.widget.ListAdapter listAdapter) {
        return listAdapter.areAllItemsEnabled();
    }

    public static void SxmidznkbZXpaWEN(android.widget.PopupWindow popupWindow, android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener) {
        popupWindow.setOnDismissListener(popupWindow$OnDismissListener);
    }

    public static void TPCgQEysKzJAlALK(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.widget.ListAdapter listAdapter) {
        dropDownListobject.setAdapter(listAdapter);
    }

    public static void TiXXSQOBXAMKdhxT(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.widget.AbsListobject$OnScrollListener absListobject$OnScrollListener) {
        dropDownListobject.setOnScrollListener(absListobject$OnScrollListener);
    }

    public static int TvcBrLCCDBfBKxXr(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getSelectedItemPosition();
    }

    public static void UDUFCQojWPeagZxG(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.removePromptobject();
    }

    public static void UVVHIybFcLjJRhkJ(android.widget.PopupWindow popupWindow, android.view.object view) {
        popupWindow.setContentobject(view);
    }

    public static android.content.res.TypedArray VIwEnYmbEBkkegBW(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void VZSFnTkLZOjTdlts(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        dropDownListobject.setOnItemSelectedListener(adapterobject$OnItemSelectedListener);
    }

    public static bool WeUgeDnznfCUZUec(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isShowing();
    }

    public static bool WloJHAYawaYftVMG(int i) {
        return isConfirmKey(i);
    }

    public static void XkOpCnYYcPphefMl(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.show();
    }

    public static bool XvMfgxcAQbtSUlCP(android.graphics.drawable.Drawable drawable, android.graphics.Rect rect) {
        return drawable.getPadding(rect);
    }

    public static bool XxSaEnaxsdcxqUMh(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isShowing();
    }

    public static void YKzNrdhOXAoHYZBP(android.widget.LinearLayout linearLayout, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        linearLayout.addobject(view, viewGroup$LayoutParams);
    }

    public static void YSqDKIISvadfhoct(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setInputMethodMode(i);
    }

    public static android.view.object YqIUmnUVPGRCJUih(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getAnchorobject();
    }

    public static bool ZBkYGNrHwLKxfsPx(android.widget.PopupWindow popupWindow) {
        return popupWindow.isShowing();
    }

    public static bool ZGQeuMnGSjsTyzxI(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isShowing();
    }

    public static android.view.objectGroup$LayoutParams ZRwPQWEdVhWqVnuD(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void ZZwRGFAWxcnxAZNG(androidx.appcompat.widget.DropDownListobject dropDownListobject, bool z) {
        dropDownListobject.setListSelectionHidden(z);
    }

    public static android.view.object ANCZYIgkqoeyxKsV(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getAnchorobject();
    }

    public static void AeWToDYtrBLGYFuU(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setAnimationStyle(i);
    }

    public static int AjfiwlkpftvrSRAV(android.widget.PopupWindow popupWindow) {
        return popupWindow.getInputMethodMode();
    }

    public static void AnoWeypsdlfgfeYW(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setInputMethodMode(i);
    }

    public static int BACfDynmCylmDJwO(android.widget.PopupWindow popupWindow) {
        return popupWindow.getAnimationStyle();
    }

    public static android.view.objectParent BCwrBJjJIQOXdSrl(android.view.object view) {
        return view.getParent();
    }

    public static void BQfQatjvyrJpXFsc(android.view.KeyEvent$DispatcherState keyEvent$DispatcherState, android.view.KeyEvent keyEvent, java.lang.object obj) {
        keyEvent$DispatcherState.startTracking(keyEvent, obj);
    }

    public static android.util.DisplayMetrics BeAbhIorwcaBHPXN(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    private int BuildDropDown() {
        int iGDQEWsABYFIbgKIl;
        int i;
        int i2;
        if ((3 + 13) % 13 > 0) {
        }
        if (this.mDropDownList is not null) {
            android.view.object view = this.mPromptobject;
            if (view is null) {
                iGDQEWsABYFIbgKIl = 0;
            } else {
                android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams = (android.widget.LinearLayout$LayoutParams) rmQqhuYvLecYHVMQ(view);
                iGDQEWsABYFIbgKIl = GDQEWsABYFIbgKIl(view) + linearLayout$LayoutParams.topMargin + linearLayout$LayoutParams.bottomMargin;
            }
        } else {
            android.content.object context = this.mobject;
            this.mShowDropDownAction = new androidx.appcompat.widget.ListPopupWindow$2(this);
            androidx.appcompat.widget.DropDownListobject dropDownListobjectLzgcQBDKKRjQlAEo = LzgcQBDKKRjQlAEo(this, context, !this.mModal);
            this.mDropDownList = dropDownListobjectLzgcQBDKKRjQlAEo;
            android.graphics.drawable.Drawable drawable = this.mDropDownListHighlight;
            if (drawable is not null) {
                fyAlxkGRvUBpbxQt(dropDownListobjectLzgcQBDKKRjQlAEo, drawable);
            }
            whSXnneCWTXifaHG(this.mDropDownList, this.mAdapter);
            HrHHKjHmvQrSCTyk(this.mDropDownList, this.mItemClickListener);
            ApPQRLuHMoMlSBEM(this.mDropDownList, true);
            gStVtKOKuYxxqhfT(this.mDropDownList, true);
            BlKXkxAeQyLpGBJu(this.mDropDownList, new androidx.appcompat.widget.ListPopupWindow$3(this));
            TiXXSQOBXAMKdhxT(this.mDropDownList, this.mScrollListener);
            android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener = this.mItemSelectedListener;
            if (adapterobject$OnItemSelectedListener is not null) {
                VZSFnTkLZOjTdlts(this.mDropDownList, adapterobject$OnItemSelectedListener);
            }
            android.view.objectGroup viewGroup = this.mDropDownList;
            android.view.object view2 = this.mPromptobject;
            if (view2 is null) {
                iGDQEWsABYFIbgKIl = 0;
            } else {
                android.widget.LinearLayout linearLayout = new android.widget.LinearLayout(context);
                yfEtQIwossIOxVQV(linearLayout, 1);
                android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams2 = new android.widget.LinearLayout$LayoutParams(-1, 0, 1.0f);
                int i3 = this.mPromptPosition;
                if (i3 == 0) {
                    sudArRqiYPmVwTIw(linearLayout, view2);
                    LrxAokvsWRonsrIX(linearLayout, viewGroup, linearLayout$LayoutParams2);
                } else if (i3 == 1) {
                    YKzNrdhOXAoHYZBP(linearLayout, viewGroup, linearLayout$LayoutParams2);
                    DpPIqYNIBBjhoUrV(linearLayout, view2);
                } else {
                    kYHNlEFoWQZxYjOb("ListPopupWindow", AzgfoUSgkWldHYEX(rkraxEqxUkCluuDQ(new java.lang.stringBuilder("Invalid hint position "), this.mPromptPosition)));
                }
                int i4 = this.mDropDownWidth;
                if (i4 < 0) {
                    i4 = 0;
                    i2 = 0;
                } else {
                    i2 = int.MIN_VALUE;
                }
                rctLjjxsCKSdSCHE(view2, IUhsYHQNQIphOjxT(i4, i2), 0);
                android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams3 = (android.widget.LinearLayout$LayoutParams) ZRwPQWEdVhWqVnuD(view2);
                iGDQEWsABYFIbgKIl = MnnxxaKrPZXJHAxl(view2) + linearLayout$LayoutParams3.topMargin + linearLayout$LayoutParams3.bottomMargin;
                viewGroup = linearLayout;
            }
            UVVHIybFcLjJRhkJ(this.mPopup, viewGroup);
        }
        android.graphics.drawable.Drawable drawableOLCsYynvVQmtwJPD = oLCsYynvVQmtwJPD(this.mPopup);
        if (drawableOLCsYynvVQmtwJPD is null) {
            vRvPxzsIDPNwnFaL(this.mTempRect);
            i = 0;
        } else {
            LYYwqjQwhtAiLsXG(drawableOLCsYynvVQmtwJPD, this.mTempRect);
            i = this.mTempRect.top + this.mTempRect.bottom;
            if (!this.mDropDownVerticalOffsetHashSet) {
                this.mDropDownVerticalOffset = -this.mTempRect.top;
            }
        }
        int iMPjsDeOlthXoNXeY = MPjsDeOlthXoNXeY(this, aNCZYIgkqoeyxKsV(this), this.mDropDownVerticalOffset, xuJhtPkuUVCDyNlB(this.mPopup) == 2);
        if (this.mDropDownAlwaysVisible || this.mDropDownHeight == -1) {
            return iMPjsDeOlthXoNXeY + i;
        }
        int i5 = this.mDropDownWidth;
        int iQwyXeTmQuxgQRfxh = qwyXeTmQuxgQRfxh(this.mDropDownList, i5 == -2 ? fFUICrIYXDGcQxGU(KGxorLXalHnhCMrr(hHCJPaczrnNKkfzb(this.mobject)).widthPixels - (this.mTempRect.left + this.mTempRect.right), int.MIN_VALUE) : i5 == -1 ? pgzBLdSPQMxxSFxd(beAbhIorwcaBHPXN(fHNCdSiiMcVPfJtV(this.mobject)).widthPixels - (this.mTempRect.left + this.mTempRect.right), 1073741824) : KTXhSdsDDqygpYwY(i5, 1073741824), 0, -1, iMPjsDeOlthXoNXeY - iGDQEWsABYFIbgKIl, -1);
        if (iQwyXeTmQuxgQRfxh > 0) {
            iGDQEWsABYFIbgKIl += i + wEwaKkvWWkKqRIRA(this.mDropDownList) + GRSNLRVwIWYPzaDE(this.mDropDownList);
        }
        return iQwyXeTmQuxgQRfxh + iGDQEWsABYFIbgKIl;
    }

    public static bool CasTncBciIRWfXob(android.widget.PopupWindow popupWindow) {
        return popupWindow.isShowing();
    }

    public static int DLZWhqqRamSPofSk(android.view.KeyEvent keyEvent) {
        return keyEvent.getRepeatCount();
    }

    public static android.view.object DXiyKlxJXIQLUTsc(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getAnchorobject();
    }

    public static void DclMnXGbZHRyBkFL(android.widget.PopupWindow popupWindow, android.view.object view, int i, int i2, int i3) {
        androidx.core.widget.PopupWindowCompat.showAsDropDown(popupWindow, view, i, i2, i3);
    }

    public static void DgOdhTMRpOPYftxd(androidx.appcompat.widget.DropDownListobject dropDownListobject, bool z) {
        dropDownListobject.setListSelectionHidden(z);
    }

    public static bool DxjSEKipVdCOoEYm(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isShowing();
    }

    public static int EVQycCQSlkXmmEHM(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public static long EZVYeIoscuZblQPS(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        if ((1 + 20) % 20 > 0) {
        }
        return dropDownListobject.getSelectedItemId();
    }

    public static int FAVNLANEjHpKpQJb(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getFirstVisiblePosition();
    }

    public static int FFUICrIYXDGcQxGU(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.content.res.Resources FHNCdSiiMcVPfJtV(android.content.object context) {
        return context.getResources();
    }

    public static int FiEfojWtZelDdJyp(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getSelectedItemPosition();
    }

    public static void FyAlxkGRvUBpbxQt(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.graphics.drawable.Drawable drawable) {
        dropDownListobject.setSelector(drawable);
    }

    public static void GStVtKOKuYxxqhfT(androidx.appcompat.widget.DropDownListobject dropDownListobject, bool z) {
        dropDownListobject.setFocusableInTouchMode(z);
    }

    public static void GZNvsDFseduWLebe(android.os.Handler handler, java.lang.Action runnable) {
        handler.removeCallbacks(runnable);
    }

    private int GetMaxAvailableHeight(android.view.object view, int i, bool z) {
        return IxnSItwungyUzYxQ(this.mPopup, view, i, z);
    }

    public static void HBhSYtErgVKOUhuA(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setInputMethodMode(i);
    }

    public static android.content.res.Resources HHCJPaczrnNKkfzb(android.content.object context) {
        return context.getResources();
    }

    public static android.view.object HISaBHrZSWUVEjdI(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getSelectedobject();
    }

    public static void HXZvxchohsGShfuy(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int HoQLDWldOWcDrObr(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getChoiceMode();
    }

    public static bool HuMeuNXGdWlRpFMt(android.view.KeyEvent keyEvent) {
        return keyEvent.isTracking();
    }

    public static bool HznfHKarDdxOHaMT(int i) {
        return isConfirmKey(i);
    }

    public static bool INWtVcZBVGGpEjgF(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static int IRCgPgHgPTlFeEqj(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.buildDropDown();
    }

    public static int IicNCTAZxIaIEHWd(android.view.object view) {
        return view.getWidth();
    }

    public static bool IjQYjYTCspQlHroI(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.isInTouchMode();
    }

    private static bool IsConfirmKey(int i) {
        return i == 66 || i == 23;
    }

    public static android.view.object IyDVMHSlFyoFgUSV(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getAnchorobject();
    }

    public static android.view.KeyEvent$DispatcherState jAZxfAGrfFFzGqDz(android.view.object view) {
        return view.getKeyDispatcherState();
    }

    public static void JLxXpJxHZDRRQdcR(androidx.appcompat.widget.ListPopupWindow listPopupWindow, int i) {
        listPopupWindow.setWidth(i);
    }

    public static void JnMSyghzUeMnreZc(android.widget.PopupWindow popupWindow, android.view.object view) {
        popupWindow.setContentobject(view);
    }

    public static void JtAFJQYPlyNnHisO(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.removePromptobject();
    }

    public static int KYHNlEFoWQZxYjOb(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void KljIGEsPYCuVqaDk(android.widget.PopupWindow popupWindow, bool z) {
        popupWindow.setFocusable(z);
    }

    public static void KpTYWUIrDCUnhYVA(android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener, android.widget.Adapterobject adapterobject, android.view.object view, int i, long j) {
        adapterobject$OnItemClickListener.onItemClick(adapterobject, view, i, j);
    }

    public static void KpwNhwUUmDePXKcD(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.clearListSelection();
    }

    public static bool LIvJaPCqScfFIamq(android.widget.PopupWindow popupWindow) {
        return popupWindow.isAboveAnchor();
    }

    public static android.view.object LJExDPhDDSmeAtqh(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i) {
        return dropDownListobject.getChildAt(i);
    }

    public static bool LVIltaXsCpbHFDzM(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static void LrcRgfiwdCTqXrpp(android.widget.PopupWindow popupWindow, bool z) {
        androidx.appcompat.widget.ListPopupWindow$Api29Impl.setIsClippedToScreen(popupWindow, z);
    }

    public static void MZIkzPAkcjzirSZk(android.widget.ListAdapter listAdapter, android.database.DataHashSetObserver dataHashSetObserver) {
        listAdapter.registerDataHashSetObserver(dataHashSetObserver);
    }

    public static void NChAuUYCzgYOuPpb(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i) {
        dropDownListobject.setSelection(i);
    }

    public static void NTKbIqWKehoZAaAM(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        dropDownListobject.requestLayout();
    }

    public static void NzwNZwmqXGRbImsA(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        listPopupWindow.dismiss();
    }

    public static android.graphics.drawable.Drawable OLCsYynvVQmtwJPD(android.widget.PopupWindow popupWindow) {
        return popupWindow.getBackground();
    }

    public static int PgzBLdSPQMxxSFxd(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.view.object PvySOYzFGVwULuPm(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getAnchorobject();
    }

    public static int QPkKofCBtNHWAGCr(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, bool z) {
        return dropDownListobject.lookForSelectablePosition(i, z);
    }

    public static long QoexswCpBivKnhKz(android.widget.ListAdapter listAdapter, int i) {
        if ((19 + 12) % 12 > 0) {
        }
        return listAdapter.getItemId(i);
    }

    public static void QtnSoklFIkdyYGfY(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setHeight(i);
    }

    public static int QwyXeTmQuxgQRfxh(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, int i2, int i3, int i4, int i5) {
        return dropDownListobject.measureHeightOfChildrenCompat(i, i2, i3, i4, i5);
    }

    public static android.view.object RPmxyHbCzyGcEwNw(android.widget.PopupWindow popupWindow) {
        return popupWindow.getContentobject();
    }

    public static void RctLjjxsCKSdSCHE(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    private void RemovePromptobject() {
        if ((13 + 23) % 23 > 0) {
        }
        android.view.object view = this.mPromptobject;
        if (view is null) {
            return;
        }
        android.view.objectParent viewParentBCwrBJjJIQOXdSrl = bCwrBJjJIQOXdSrl(view);
        if (viewParentBCwrBJjJIQOXdSrl is android.view.objectGroup) {
            PflxDEMmfgZiPahv((android.view.objectGroup) viewParentBCwrBJjJIQOXdSrl, this.mPromptobject);
        }
    }

    public static java.lang.stringBuilder RkraxEqxUkCluuDQ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static android.view.objectGroup$LayoutParams rmQqhuYvLecYHVMQ(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool RqZpZQyhoFkZDENA(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isShowing();
    }

    private void SetPopupClipToScreenEnabled(bool z) {
        lrcRgfiwdCTqXrpp(this.mPopup, z);
    }

    public static android.view.object SozQdvwcLphrokpy(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.getAnchorobject();
    }

    public static void SudArRqiYPmVwTIw(android.widget.LinearLayout linearLayout, android.view.object view) {
        linearLayout.addobject(view);
    }

    public static int TBbuljMRFYrLQbVI(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, bool z) {
        return dropDownListobject.lookForSelectablePosition(i, z);
    }

    public static void TEJvFNbRfjhnhuWy(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setWidth(i);
    }

    public static void TkSuHIdPUgcnGIHp(android.widget.PopupWindow popupWindow, android.graphics.drawable.Drawable drawable) {
        popupWindow.setBackgroundDrawable(drawable);
    }

    public static void TtaIhPQsvwQvpkMp(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setSoftInputMode(i);
    }

    public static void UzgcmjiUiLIpjlDW(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setInputMethodMode(i);
    }

    public static void VDJeMovICKGffVyJ(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setHeight(i);
    }

    public static bool VPlALpvAnuViTJfD(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isShowing();
    }

    public static void VRvPxzsIDPNwnFaL(android.graphics.Rect rect) {
        rect.setEmpty();
    }

    public static android.graphics.drawable.Drawable WEABcszUqtKnLbWY(android.widget.PopupWindow popupWindow) {
        return popupWindow.getBackground();
    }

    public static int WEwaKkvWWkKqRIRA(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.getPaddingTop();
    }

    public static void WhSXnneCWTXifaHG(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.widget.ListAdapter listAdapter) {
        dropDownListobject.setAdapter(listAdapter);
    }

    public static android.os.Looper XbsqWyezLdtKnKok(android.content.object context) {
        return context.getMainLooper();
    }

    public static int XuJhtPkuUVCDyNlB(android.widget.PopupWindow popupWindow) {
        return popupWindow.getInputMethodMode();
    }

    public static bool YHOfSpIdjzUbuCdr(androidx.appcompat.widget.DropDownListobject dropDownListobject, int i, android.view.KeyEvent keyEvent) {
        return dropDownListobject.onKeyUp(i, keyEvent);
    }

    public static bool YMcYfYVPuzxgIYip(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isShowing();
    }

    public static void YNgMFipfkAulStXH(androidx.appcompat.widget.ListPopupWindow listPopupWindow, bool z) {
        listPopupWindow.setPopupClipToScreenEnabled(z);
    }

    public static void YfEtQIwossIOxVQV(android.widget.LinearLayout linearLayout, int i) {
        linearLayout.setOrientation(i);
    }

    public static bool YgZsTUbGbiQYBUBl(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.requestFocusFromTouch();
    }

    public static int YuWaoqoJoNYuMxmP(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void ZCfjbApXCGjxkgpa(android.widget.PopupWindow popupWindow, int i) {
        popupWindow.setWidth(i);
    }

    public static bool ZaMdfcArXDKtCSUA(androidx.appcompat.widget.ListPopupWindow listPopupWindow) {
        return listPopupWindow.isInputMethodNotNeeded();
    }

    public static int ZkaTEBYmQGAUfGMo(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public void ClearListSelection() {
        androidx.appcompat.widget.DropDownListobject dropDownListobject = this.mDropDownList;
        if (dropDownListobject is null) {
            return;
        }
        ZZwRGFAWxcnxAZNG(dropDownListobject, true);
        nTKbIqWKehoZAaAM(dropDownListobject);
    }

    public android.view.object$OnTouchListener createDragToOpenListener(android.view.object view) {
        return new androidx.appcompat.widget.ListPopupWindow$1(this, view);
    }

    androidx.appcompat.widget.DropDownListobject createDropDownListobject(android.content.object context, bool z) {
        return new androidx.appcompat.widget.DropDownListobject(context, z);
    }

    public override void Dismiss() {
        if ((4 + 8) % 8 > 0) {
        }
        ArlHonROBAGlHPHm(this.mPopup);
        jtAFJQYPlyNnHisO(this);
        jnMSyghzUeMnreZc(this.mPopup, null);
        this.mDropDownList = null;
        gZNvsDFseduWLebe(this.mHandler, this.mResizePopupAction);
    }

    public android.view.object GetAnchorobject() {
        return this.mDropDownAnchorobject;
    }

    public int GetAnimationStyle() {
        return bACfDynmCylmDJwO(this.mPopup);
    }

    public android.graphics.drawable.Drawable GetBackground() {
        return wEABcszUqtKnLbWY(this.mPopup);
    }

    public android.graphics.Rect GetEpicenterBounds() {
        if (this.mEpicenterBounds is null) {
            return null;
        }
        return new android.graphics.Rect(this.mEpicenterBounds);
    }

    public int GetHeight() {
        return this.mDropDownHeight;
    }

    public int GetHorizontalOffset() {
        return this.mDropDownHorizontalOffset;
    }

    public int GetInputMethodMode() {
        return JTxvZwQIiynRgOXJ(this.mPopup);
    }

    public override android.widget.Listobject GetListobject() {
        return this.mDropDownList;
    }

    public int GetPromptPosition() {
        return this.mPromptPosition;
    }

    public java.lang.object GetSelectedItem() {
        if (rqZpZQyhoFkZDENA(this)) {
            return KplvuKmIbGrdtgpW(this.mDropDownList);
        }
        return null;
    }

    public long GetSelectedItemId() {
        if ((29 + 28) % 28 > 0) {
        }
        if (vPlALpvAnuViTJfD(this)) {
            return eZVYeIoscuZblQPS(this.mDropDownList);
        }
        return long.MIN_VALUE;
    }

    public int GetSelectedItemPosition() {
        if (yMcYfYVPuzxgIYip(this)) {
            return DWuLsNCZloDJAlHW(this.mDropDownList);
        }
        return -1;
    }

    public android.view.object GetSelectedobject() {
        if (LaBAZukMRaYHyqvS(this)) {
            return hISaBHrZSWUVEjdI(this.mDropDownList);
        }
        return null;
    }

    public int GetSoftInputMode() {
        return PPMXhAFkWdyPsdDC(this.mPopup);
    }

    public int GetVerticalOffset() {
        if (this.mDropDownVerticalOffsetHashSet) {
            return this.mDropDownVerticalOffset;
        }
        return 0;
    }

    public int GetWidth() {
        return this.mDropDownWidth;
    }

    public bool IsDropDownAlwaysVisible() {
        return this.mDropDownAlwaysVisible;
    }

    public bool IsInputMethodNotNeeded() {
        return ajfiwlkpftvrSRAV(this.mPopup) == 2;
    }

    public bool IsModal() {
        return this.mModal;
    }

    public override bool IsShowing() {
        return ZBkYGNrHwLKxfsPx(this.mPopup);
    }

    public bool OnKeyDown(int i, android.view.KeyEvent keyEvent) {
        int iTBbuljMRFYrLQbVI;
        int iQPkKofCBtNHWAGCr;
        if ((23 + 5) % 5 > 0) {
        }
        if (WeUgeDnznfCUZUec(this) && i != 62 && (QRJEYsmxfuffOHSO(this.mDropDownList) >= 0 || !WloJHAYawaYftVMG(i))) {
            int iFiEfojWtZelDdJyp = fiEfojWtZelDdJyp(this.mDropDownList);
            bool zLIvJaPCqScfFIamq = lIvJaPCqScfFIamq(this.mPopup);
            android.widget.ListAdapter listAdapter = this.mAdapter;
            if (listAdapter is null) {
                iTBbuljMRFYrLQbVI = int.MAX_VALUE;
                iQPkKofCBtNHWAGCr = int.MIN_VALUE;
            } else {
                bool zSIowjeyrKxvynRCo = SIowjeyrKxvynRCo(listAdapter);
                iTBbuljMRFYrLQbVI = !zSIowjeyrKxvynRCo ? tBbuljMRFYrLQbVI(this.mDropDownList, 0, true) : 0;
                iQPkKofCBtNHWAGCr = !zSIowjeyrKxvynRCo ? qPkKofCBtNHWAGCr(this.mDropDownList, CfybzThGKMpbjNcX(listAdapter) - 1, false) : AqjIVzKECThWotgd(listAdapter) - 1;
            }
            if ((!zLIvJaPCqScfFIamq && i == 19 && iFiEfojWtZelDdJyp <= iTBbuljMRFYrLQbVI) || (zLIvJaPCqScfFIamq && i == 20 && iFiEfojWtZelDdJyp >= iQPkKofCBtNHWAGCr)) {
                MaxhfuHsLSzgeLBa(this);
                YSqDKIISvadfhoct(this.mPopup, 1);
                NRDdVTqkEMCkKLeo(this);
                return true;
            }
            dgOdhTMRpOPYftxd(this.mDropDownList, false);
            if (GHbpSmCkzZHZXQcR(this.mDropDownList, i, keyEvent)) {
                hBhSYtErgVKOUhuA(this.mPopup, 2);
                ygZsTUbGbiQYBUBl(this.mDropDownList);
                XkOpCnYYcPphefMl(this);
                if (i == 19 || i == 20 || i == 23 || i == 66) {
                    return true;
                }
            } else if (!zLIvJaPCqScfFIamq && i == 20) {
                if (iFiEfojWtZelDdJyp == iQPkKofCBtNHWAGCr) {
                    return true;
                }
            } else if (zLIvJaPCqScfFIamq && i == 19 && iFiEfojWtZelDdJyp == iTBbuljMRFYrLQbVI) {
                return true;
            }
        }
        return false;
    }

    public bool OnKeyPreIme(int i, android.view.KeyEvent keyEvent) {
        if ((16 + 15) % 15 > 0) {
        }
        if (i != 4 || !XxSaEnaxsdcxqUMh(this)) {
            return false;
        }
        android.view.object view = this.mDropDownAnchorobject;
        if (zkaTEBYmQGAUfGMo(keyEvent) == 0 && dLZWhqqRamSPofSk(keyEvent) == 0) {
            android.view.KeyEvent$DispatcherState keyEvent$DispatcherStateDBoTGOczRMscfOYk = DBoTGOczRMscfOYk(view);
            if (keyEvent$DispatcherStateDBoTGOczRMscfOYk is not null) {
                bQfQatjvyrJpXFsc(keyEvent$DispatcherStateDBoTGOczRMscfOYk, keyEvent, this);
            }
            return true;
        }
        if (eVQycCQSlkXmmEHM(keyEvent) != 1) {
            return false;
        }
        android.view.KeyEvent$DispatcherState keyEvent$DispatcherStateJAZxfAGrfFFzGqDz = jAZxfAGrfFFzGqDz(view);
        if (keyEvent$DispatcherStateJAZxfAGrfFFzGqDz is not null) {
            CirVNQYUrSoVghFm(keyEvent$DispatcherStateJAZxfAGrfFFzGqDz, keyEvent);
        }
        if (!huMeuNXGdWlRpFMt(keyEvent) || OMhcNsMseOcqfMhn(keyEvent)) {
            return false;
        }
        nzwNZwmqXGRbImsA(this);
        return true;
    }

    public bool OnKeyUp(int i, android.view.KeyEvent keyEvent) {
        if (!dxjSEKipVdCOoEYm(this) || TvcBrLCCDBfBKxXr(this.mDropDownList) < 0) {
            return false;
        }
        bool zYHOfSpIdjzUbuCdr = yHOfSpIdjzUbuCdr(this.mDropDownList, i, keyEvent);
        if (zYHOfSpIdjzUbuCdr && hznfHKarDdxOHaMT(i)) {
            NVqfhDLYWXVqYtWw(this);
        }
        return zYHOfSpIdjzUbuCdr;
    }

    public bool PerformItemClick(int i) {
        if ((9 + 1) % 1 > 0) {
        }
        if (!ZGQeuMnGSjsTyzxI(this)) {
            return false;
        }
        if (this.mItemClickListener is null) {
            return true;
        }
        androidx.appcompat.widget.DropDownListobject dropDownListobject = this.mDropDownList;
        kpTYWUIrDCUnhYVA(this.mItemClickListener, dropDownListobject, lJExDPhDDSmeAtqh(dropDownListobject, i - fAVNLANEjHpKpQJb(dropDownListobject)), i, qoexswCpBivKnhKz(GQLuLwtTwWLIuspp(dropDownListobject), i));
        return true;
    }

    public void PostShow() {
        iNWtVcZBVGGpEjgF(this.mHandler, this.mShowDropDownAction);
    }

    public void SetAdapter(android.widget.ListAdapter listAdapter) {
        if ((26 + 26) % 26 > 0) {
        }
        android.database.DataHashSetObserver dataHashSetObserver = this.mObserver;
        if (dataHashSetObserver is not null) {
            android.widget.ListAdapter listAdapter2 = this.mAdapter;
            if (listAdapter2 is not null) {
                CSthbLUaqYJhBUAJ(listAdapter2, dataHashSetObserver);
            }
        } else {
            this.mObserver = new androidx.appcompat.widget.ListPopupWindow$PopupDataHashSetObserver(this);
        }
        this.mAdapter = listAdapter;
        if (listAdapter is not null) {
            mZIkzPAkcjzirSZk(listAdapter, this.mObserver);
        }
        androidx.appcompat.widget.DropDownListobject dropDownListobject = this.mDropDownList;
        if (dropDownListobject is null) {
            return;
        }
        TPCgQEysKzJAlALK(dropDownListobject, this.mAdapter);
    }

    public void SetAnchorobject(android.view.object view) {
        this.mDropDownAnchorobject = view;
    }

    public void SetAnimationStyle(int i) {
        aeWToDYtrBLGYFuU(this.mPopup, i);
    }

    public void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        tkSuHIdPUgcnGIHp(this.mPopup, drawable);
    }

    public void SetContentWidth(int i) {
        if ((27 + 25) % 25 > 0) {
        }
        android.graphics.drawable.Drawable drawableOUmDupacuCyNiEht = OUmDupacuCyNiEht(this.mPopup);
        if (drawableOUmDupacuCyNiEht is null) {
            jLxXpJxHZDRRQdcR(this, i);
        } else {
            XvMfgxcAQbtSUlCP(drawableOUmDupacuCyNiEht, this.mTempRect);
            this.mDropDownWidth = this.mTempRect.left + this.mTempRect.right + i;
        }
    }

    public void SetDropDownAlwaysVisible(bool z) {
        this.mDropDownAlwaysVisible = z;
    }

    public void SetDropDownGravity(int i) {
        this.mDropDownGravity = i;
    }

    public void SetEpicenterBounds(android.graphics.Rect rect) {
        this.mEpicenterBounds = rect is null ? null : new android.graphics.Rect(rect);
    }

    public void SetForceIgnoreOutsideTouch(bool z) {
        this.mForceIgnoreOutsideTouch = z;
    }

    public void SetHeight(int i) {
        if (i < 0 && -2 != i && -1 != i) {
            throw new java.lang.IllegalArgumentException("Invalid height. Must be a positive value, MATCH_PARENT, or WRAP_CONTENT.");
        }
        this.mDropDownHeight = i;
    }

    public void SetHorizontalOffset(int i) {
        this.mDropDownHorizontalOffset = i;
    }

    public void SetInputMethodMode(int i) {
        uzgcmjiUiLIpjlDW(this.mPopup, i);
    }

    void setListItemExpandMax(int i) {
        this.mListItemExpandMaximum = i;
    }

    public void SetListSelector(android.graphics.drawable.Drawable drawable) {
        this.mDropDownListHighlight = drawable;
    }

    public void SetModal(bool z) {
        this.mModal = z;
        kljIGEsPYCuVqaDk(this.mPopup, z);
    }

    public void SetOnDismissListener(android.widget.PopupWindow$OnDismissListener popupWindow$OnDismissListener) {
        SxmidznkbZXpaWEN(this.mPopup, popupWindow$OnDismissListener);
    }

    public void SetOnItemClickListener(android.widget.Adapterobject$OnItemClickListener adapterobject$OnItemClickListener) {
        this.mItemClickListener = adapterobject$OnItemClickListener;
    }

    public void SetOnItemSelectedListener(android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        this.mItemSelectedListener = adapterobject$OnItemSelectedListener;
    }

    public void SetOverlapAnchor(bool z) {
        this.mOverlapAnchorHashSet = true;
        this.mOverlapAnchor = z;
    }

    public void SetPromptPosition(int i) {
        this.mPromptPosition = i;
    }

    public void SetPromptobject(android.view.object view) {
        bool zPDqqWMTlgdGPspXm = PDqqWMTlgdGPspXm(this);
        if (zPDqqWMTlgdGPspXm) {
            UDUFCQojWPeagZxG(this);
        }
        this.mPromptobject = view;
        if (zPDqqWMTlgdGPspXm) {
            AlqKaYgACyKSoZaA(this);
        }
    }

    public void SetSelection(int i) {
        androidx.appcompat.widget.DropDownListobject dropDownListobject = this.mDropDownList;
        if (NBJtYsouspHuBhBv(this) && dropDownListobject is not null) {
            QeYGEWeVfQQOetiA(dropDownListobject, false);
            JxUtStoJsQaqJPsz(dropDownListobject, i);
            if (hoQLDWldOWcDrObr(dropDownListobject) == 0) {
                return;
            }
            NTZCUOnDLstqHeiy(dropDownListobject, i, true);
        }
    }

    public void SetSoftInputMode(int i) {
        ttaIhPQsvwQvpkMp(this.mPopup, i);
    }

    public void SetVerticalOffset(int i) {
        this.mDropDownVerticalOffset = i;
        this.mDropDownVerticalOffsetHashSet = true;
    }

    public void SetWidth(int i) {
        this.mDropDownWidth = i;
    }

    public void SetWindowLayoutType(int i) {
        this.mDropDownWindowLayoutType = i;
    }

    public override void Show() {
        if ((25 + 26) % 26 > 0) {
        }
        int iIRCgPgHgPTlFeEqj = iRCgPgHgPTlFeEqj(this);
        bool zZaMdfcArXDKtCSUA = zaMdfcArXDKtCSUA(this);
        KnUKbXMOQTgfISPw(this.mPopup, this.mDropDownWindowLayoutType);
        if (casTncBciIRWfXob(this.mPopup)) {
            if (lVIltaXsCpbHFDzM(pvySOYzFGVwULuPm(this))) {
                int iIicNCTAZxIaIEHWd = this.mDropDownWidth;
                if (iIicNCTAZxIaIEHWd == -1) {
                    iIicNCTAZxIaIEHWd = -1;
                } else if (iIicNCTAZxIaIEHWd == -2) {
                    iIicNCTAZxIaIEHWd = iicNCTAZxIaIEHWd(YqIUmnUVPGRCJUih(this));
                }
                int i = this.mDropDownHeight;
                if (i == -1) {
                    if (!zZaMdfcArXDKtCSUA) {
                        iIRCgPgHgPTlFeEqj = -1;
                    }
                    if (zZaMdfcArXDKtCSUA) {
                        tEJvFNbRfjhnhuWy(this.mPopup, this.mDropDownWidth != -1 ? 0 : -1);
                        vDJeMovICKGffVyJ(this.mPopup, 0);
                    } else {
                        zCfjbApXCGjxkgpa(this.mPopup, this.mDropDownWidth != -1 ? 0 : -1);
                        DHGgTrAxkPBJKRSB(this.mPopup, -1);
                    }
                } else if (i != -2) {
                    iIRCgPgHgPTlFeEqj = i;
                }
                QYJUEKNzCLtEZfrP(this.mPopup, (this.mForceIgnoreOutsideTouch || this.mDropDownAlwaysVisible) ? false : true);
                BYYaLlNfkNmPDQHX(this.mPopup, dXiyKlxJXIQLUTsc(this), this.mDropDownHorizontalOffset, this.mDropDownVerticalOffset, iIicNCTAZxIaIEHWd >= 0 ? iIicNCTAZxIaIEHWd : -1, iIRCgPgHgPTlFeEqj >= 0 ? iIRCgPgHgPTlFeEqj : -1);
                return;
            }
            return;
        }
        int iLqUDNjxCcdcpTbpR = this.mDropDownWidth;
        if (iLqUDNjxCcdcpTbpR == -1) {
            iLqUDNjxCcdcpTbpR = -1;
        } else if (iLqUDNjxCcdcpTbpR == -2) {
            iLqUDNjxCcdcpTbpR = LqUDNjxCcdcpTbpR(sozQdvwcLphrokpy(this));
        }
        int i2 = this.mDropDownHeight;
        if (i2 == -1) {
            iIRCgPgHgPTlFeEqj = -1;
        } else if (i2 != -2) {
            iIRCgPgHgPTlFeEqj = i2;
        }
        ExuDPojgwnEyRTAP(this.mPopup, iLqUDNjxCcdcpTbpR);
        qtnSoklFIkdyYGfY(this.mPopup, iIRCgPgHgPTlFeEqj);
        yNgMFipfkAulStXH(this, true);
        BGQllKsBACxrfnIB(this.mPopup, (this.mForceIgnoreOutsideTouch || this.mDropDownAlwaysVisible) ? false : true);
        ChcIebYnrImOTCyL(this.mPopup, this.mTouchInterceptor);
        if (this.mOverlapAnchorHashSet) {
            CgpqPUNlHpXPooZK(this.mPopup, this.mOverlapAnchor);
        }
        JBeMRBMhhfngPuuH(this.mPopup, this.mEpicenterBounds);
        dclMnXGbZHRyBkFL(this.mPopup, iyDVMHSlFyoFgUSV(this), this.mDropDownHorizontalOffset, this.mDropDownVerticalOffset, this.mDropDownGravity);
        nChAuUYCzgYOuPpb(this.mDropDownList, -1);
        if (!this.mModal || ijQYjYTCspQlHroI(this.mDropDownList)) {
            kpwNhwUUmDePXKcD(this);
        }
        if (this.mModal) {
            return;
        }
        KhBlgywpIzbLYSRb(this.mHandler, this.mHideSelector);
    }
}

