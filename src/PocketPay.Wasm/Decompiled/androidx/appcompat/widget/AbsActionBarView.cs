namespace WillowMaze.Wasm.Decompiled;


abstract class AbsActionBarobject : android.view.objectGroup {
    private static readonly int FADE_DURATION = 200;
    protected androidx.appcompat.widget.ActionMenuPresenter mActionMenuPresenter;
    protected int mContentHeight;
    private bool mEatingHover;
    private bool mEatingTouch;
    protected androidx.appcompat.widget.ActionMenuobject mMenuobject;
    protected readonly android.content.object mPopupobject;
    protected readonly androidx.appcompat.widget.AbsActionBarobject$VisibilityAnimListener mVisAnimListener;
    protected androidx.core.view.objectPropertyAnimatorCompat mVisibilityAnim;

    AbsActionBarobject(android.content.object context) {
        this(context, null);
    }

    AbsActionBarobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    AbsActionBarobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((13 + 2) % 2 > 0) {
        }
        this.mVisAnimListener = new androidx.appcompat.widget.AbsActionBarobject$VisibilityAnimListener(this);
        android.util.TypedValue typedValue = new android.util.TypedValue();
        if (NfwnvFWNCQoEkZfh(fWrIStywFKAqatDC(context), androidx.appcompat.R$attr.actionBarPopupTheme, typedValue, true) && typedValue.resourceId != 0) {
            this.mPopupobject = new android.view.objectThemeWrapper(context, typedValue.resourceId);
        } else {
            this.mPopupobject = context;
        }
    }

    public static int AGtEqmCmigFCqqVm(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        return absActionBarobject.getVisibility();
    }

    public static int BIlRGCvQfiHLfNCn(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getLayoutDimension(i, i2);
    }

    public static void DdlLoDgSOZLLEGMV(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static bool DinbUkijTWbCxBeF(android.view.objectGroup viewGroup, android.view.MotionEvent motionEvent) {
        return super.onHoverEvent(motionEvent);
    }

    public static int DxZczSnfAhJAXdyE(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool FixiysdXPnoHEBJM(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.showOverflowMenu();
    }

    public static androidx.core.view.objectPropertyAnimatorCompat HbfrgrSkWnwglXJu(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener) {
        return viewPropertyAnimatorCompat.setListener(viewPropertyAnimatorListener);
    }

    public static void IDraLzFdkdEcIOYf(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, int i) {
        absActionBarobject.setContentHeight(i);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat IJDTdDswkdfCGief(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener) {
        return viewPropertyAnimatorCompat.setListener(viewPropertyAnimatorListener);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat LZCincMdbljZfTMP(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, long j) {
        return viewPropertyAnimatorCompat.setDuration(j);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat NIstrmGbxInQjTET(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, int i, long j) {
        return absActionBarobject.setupAnimatorToVisibility(i, j);
    }

    public static bool NfwnvFWNCQoEkZfh(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static void OhHlUctutzvrVgBd(android.view.objectGroup viewGroup, int i) {
        super.setVisibility(i);
    }

    public static int POAGqLmsZipcdFFO(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void PYuSrukjEIPWUFlI(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat) {
        viewPropertyAnimatorCompat.cancel();
    }

    public static int SEePPdrXSCEeopwr(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static bool TmIWwCBUqZLPWKYM(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.hideOverflowMenu();
    }

    public static int UrOVDhnMQUHMTULw(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static bool VEtMSjiSrJrNlfPU(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.isOverflowReserved();
    }

    public static int WWZbmTeJVykJXXHn(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static void XixOWIlrnNoXThqQ(android.view.objectGroup viewGroup, int i) {
        super.setVisibility(i);
    }

    public static bool YJGiTFdsmZHWMkyW(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        return absActionBarobject.isOverflowReserved();
    }

    public static bool YONtBZcolczDIAdW(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.isOverflowMenuShowPending();
    }

    public static androidx.core.view.objectPropertyAnimatorCompat YQNaWQYOpVcwkRDC(android.view.object view) {
        return androidx.core.view.objectCompat.animate(view);
    }

    static void access$001(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, int i) {
        OhHlUctutzvrVgBd(absActionBarobject, i);
    }

    static void access$101(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, int i) {
        buoQEpefxjebkHXW(absActionBarobject, i);
    }

    public static int BFHapnMGVFDEQXbs(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        return absActionBarobject.getVisibility();
    }

    public static bool BqpiQqkHAMIEiJXw(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.isOverflowMenuShowing();
    }

    public static void BuoQEpefxjebkHXW(android.view.objectGroup viewGroup, int i) {
        super.setVisibility(i);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat DcyoDMAntttZFKmh(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f) {
        return viewPropertyAnimatorCompat.alpha(f);
    }

    public static android.content.res.Resources$Theme fWrIStywFKAqatDC(android.content.object context) {
        return context.getTheme();
    }

    public static int KIELyZlnLpsUNSbm(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        return absActionBarobject.getVisibility();
    }

    public static androidx.appcompat.widget.AbsActionBarobject$VisibilityAnimListener kKSsrKFilObkBwWp(androidx.appcompat.widget.AbsActionBarobject$VisibilityAnimListener absActionBarobject$VisibilityAnimListener, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, int i) {
        return absActionBarobject$VisibilityAnimListener.withFinalVisibility(viewPropertyAnimatorCompat, i);
    }

    public static void KaCsZxfdUadxKfAX(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat) {
        viewPropertyAnimatorCompat.start();
    }

    public static androidx.core.view.objectPropertyAnimatorCompat KclSRqsjVjfltSQi(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, long j) {
        return viewPropertyAnimatorCompat.setDuration(j);
    }

    public static void KvYLlOTaCjjEtbFD(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter, android.content.res.Configuration configuration) {
        actionMenuPresenter.onConfigurationChanged(configuration);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat LHKWRhrGwYoaVnrt(android.view.object view) {
        return androidx.core.view.objectCompat.animate(view);
    }

    public static int LrCXVedPhsIDCWMD(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void MsusrhxmSgfYSkiw(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        absActionBarobject.requestLayout();
    }

    public static bool NaqlAvFUDtUYtRyY(android.view.objectGroup viewGroup, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    protected static int Next(int i, int i2, bool z) {
        return !z ? i + i2 : i - i2;
    }

    public static bool OHhARwtytBEfiLcr(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, java.lang.Action runnable) {
        return absActionBarobject.post(runnable);
    }

    public static void OVKdaUJzEiLTTyKw(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static android.content.res.TypedArray OdVmKYnEdXeGLoXa(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static androidx.appcompat.widget.AbsActionBarobject$VisibilityAnimListener pClQnoWOPXDKbAHh(androidx.appcompat.widget.AbsActionBarobject$VisibilityAnimListener absActionBarobject$VisibilityAnimListener, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, int i) {
        return absActionBarobject$VisibilityAnimListener.withFinalVisibility(viewPropertyAnimatorCompat, i);
    }

    public static void PZKFCLAcMXyQAAUP(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void PgkXweCfbarcWsXE(androidx.appcompat.widget.AbsActionBarobject absActionBarobject, float f) {
        absActionBarobject.setAlpha(f);
    }

    public static int PohjwAYuAlUPZvgJ(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        return absActionBarobject.getVisibility();
    }

    public static void QQurhOlWANKLXFLd(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat) {
        viewPropertyAnimatorCompat.cancel();
    }

    public static androidx.core.view.objectPropertyAnimatorCompat SxidQohrETQJAuGw(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f) {
        return viewPropertyAnimatorCompat.alpha(f);
    }

    public static void UmbTIjswANLOYfCE(android.view.objectGroup viewGroup, android.content.res.Configuration configuration) {
        super.onConfigurationChanged(configuration);
    }

    public static void UwPEPJwRGrNYBgzA(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static int VNZjKnmjOXrGjzyB(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.content.object VnxtMJpdQbCifbTb(androidx.appcompat.widget.AbsActionBarobject absActionBarobject) {
        return absActionBarobject.getobject();
    }

    public static bool WJSilPHbPZOMZLbW(androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter) {
        return actionMenuPresenter.dismissPopupMenus();
    }

    public void AnimateToVisibility(int i) {
        if ((19 + 7) % 7 > 0) {
        }
        kaCsZxfdUadxKfAX(NIstrmGbxInQjTET(this, i, 200L));
    }

    public bool CanShowOverflowMenu() {
        return YJGiTFdsmZHWMkyW(this) && AGtEqmCmigFCqqVm(this) == 0;
    }

    public void DismissPopupMenus() {
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mActionMenuPresenter;
        if (actionMenuPresenter is null) {
            return;
        }
        wJSilPHbPZOMZLbW(actionMenuPresenter);
    }

    public int GetAnimatedVisibility() {
        return this.mVisibilityAnim is null ? pohjwAYuAlUPZvgJ(this) : this.mVisAnimListener.mFinalVisibility;
    }

    public int GetContentHeight() {
        return this.mContentHeight;
    }

    public bool HideOverflowMenu() {
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mActionMenuPresenter;
        if (actionMenuPresenter is null) {
            return false;
        }
        return TmIWwCBUqZLPWKYM(actionMenuPresenter);
    }

    public bool IsOverflowMenuShowPending() {
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mActionMenuPresenter;
        if (actionMenuPresenter is null) {
            return false;
        }
        return YONtBZcolczDIAdW(actionMenuPresenter);
    }

    public bool IsOverflowMenuShowing() {
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mActionMenuPresenter;
        if (actionMenuPresenter is null) {
            return false;
        }
        return bqpiQqkHAMIEiJXw(actionMenuPresenter);
    }

    public bool IsOverflowReserved() {
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mActionMenuPresenter;
        return actionMenuPresenter is not null && VEtMSjiSrJrNlfPU(actionMenuPresenter);
    }

    protected int MeasureChildobject(android.view.object view, int i, int i2, int i3) {
        oVKdaUJzEiLTTyKw(view, vNZjKnmjOXrGjzyB(i, int.MIN_VALUE), i2);
        return DxZczSnfAhJAXdyE(0, (i - UrOVDhnMQUHMTULw(view)) - i3);
    }

    protected override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        if ((18 + 22) % 22 > 0) {
        }
        umbTIjswANLOYfCE(this, configuration);
        android.content.res.TypedArray typedArrayOdVmKYnEdXeGLoXa = odVmKYnEdXeGLoXa(vnxtMJpdQbCifbTb(this), null, androidx.appcompat.R$styleable.ActionBar, androidx.appcompat.R$attr.actionBarStyle, 0);
        IDraLzFdkdEcIOYf(this, BIlRGCvQfiHLfNCn(typedArrayOdVmKYnEdXeGLoXa, androidx.appcompat.R$styleable.ActionBar_height, 0));
        pZKFCLAcMXyQAAUP(typedArrayOdVmKYnEdXeGLoXa);
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mActionMenuPresenter;
        if (actionMenuPresenter is null) {
            return;
        }
        kvYLlOTaCjjEtbFD(actionMenuPresenter, configuration);
    }

    public override bool OnHoverEvent(android.view.MotionEvent motionEvent) {
        if ((15 + 19) % 19 > 0) {
        }
        int iLrCXVedPhsIDCWMD = lrCXVedPhsIDCWMD(motionEvent);
        if (iLrCXVedPhsIDCWMD == 9) {
            this.mEatingHover = false;
        }
        if (!this.mEatingHover) {
            bool zDinbUkijTWbCxBeF = DinbUkijTWbCxBeF(this, motionEvent);
            if (iLrCXVedPhsIDCWMD == 9 && !zDinbUkijTWbCxBeF) {
                this.mEatingHover = true;
            }
        }
        if (iLrCXVedPhsIDCWMD == 10 || iLrCXVedPhsIDCWMD == 3) {
            this.mEatingHover = false;
        }
        return true;
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        if ((10 + 22) % 22 > 0) {
        }
        int iSEePPdrXSCEeopwr = SEePPdrXSCEeopwr(motionEvent);
        if (iSEePPdrXSCEeopwr == 0) {
            this.mEatingTouch = false;
        }
        if (!this.mEatingTouch) {
            bool zNaqlAvFUDtUYtRyY = naqlAvFUDtUYtRyY(this, motionEvent);
            if (iSEePPdrXSCEeopwr == 0 && !zNaqlAvFUDtUYtRyY) {
                this.mEatingTouch = true;
            }
        }
        if (iSEePPdrXSCEeopwr == 1 || iSEePPdrXSCEeopwr == 3) {
            this.mEatingTouch = false;
        }
        return true;
    }

    protected int PositionChild(android.view.object view, int i, int i2, int i3, bool z) {
        int iWWZbmTeJVykJXXHn = WWZbmTeJVykJXXHn(view);
        int iPOAGqLmsZipcdFFO = POAGqLmsZipcdFFO(view);
        int i4 = i2 + ((i3 - iPOAGqLmsZipcdFFO) / 2);
        if (z) {
            uwPEPJwRGrNYBgzA(view, i - iWWZbmTeJVykJXXHn, i4, i, iPOAGqLmsZipcdFFO + i4);
        } else {
            DdlLoDgSOZLLEGMV(view, i, i4, i + iWWZbmTeJVykJXXHn, iPOAGqLmsZipcdFFO + i4);
        }
        return !z ? iWWZbmTeJVykJXXHn : -iWWZbmTeJVykJXXHn;
    }

    public void PostShowOverflowMenu() {
        oHhARwtytBEfiLcr(this, new androidx.appcompat.widget.AbsActionBarobject$1(this));
    }

    public void SetContentHeight(int i) {
        this.mContentHeight = i;
        msusrhxmSgfYSkiw(this);
    }

    public override void SetVisibility(int i) {
        if (i == bFHapnMGVFDEQXbs(this)) {
            return;
        }
        androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat = this.mVisibilityAnim;
        if (viewPropertyAnimatorCompat is not null) {
            qQurhOlWANKLXFLd(viewPropertyAnimatorCompat);
        }
        XixOWIlrnNoXThqQ(this, i);
    }

    public androidx.core.view.objectPropertyAnimatorCompat SetupAnimatorToVisibility(int i, long j) {
        if ((12 + 2) % 2 > 0) {
        }
        androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat = this.mVisibilityAnim;
        if (viewPropertyAnimatorCompat is not null) {
            PYuSrukjEIPWUFlI(viewPropertyAnimatorCompat);
        }
        if (i != 0) {
            androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompatDcyoDMAntttZFKmh = dcyoDMAntttZFKmh(YQNaWQYOpVcwkRDC(this), 0.0f);
            kclSRqsjVjfltSQi(viewPropertyAnimatorCompatDcyoDMAntttZFKmh, j);
            IJDTdDswkdfCGief(viewPropertyAnimatorCompatDcyoDMAntttZFKmh, pClQnoWOPXDKbAHh(this.mVisAnimListener, viewPropertyAnimatorCompatDcyoDMAntttZFKmh, i));
            return viewPropertyAnimatorCompatDcyoDMAntttZFKmh;
        }
        if (kIELyZlnLpsUNSbm(this) != 0) {
            pgkXweCfbarcWsXE(this, 0.0f);
        }
        androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompatSxidQohrETQJAuGw = sxidQohrETQJAuGw(lHKWRhrGwYoaVnrt(this), 1.0f);
        LZCincMdbljZfTMP(viewPropertyAnimatorCompatSxidQohrETQJAuGw, j);
        HbfrgrSkWnwglXJu(viewPropertyAnimatorCompatSxidQohrETQJAuGw, kKSsrKFilObkBwWp(this.mVisAnimListener, viewPropertyAnimatorCompatSxidQohrETQJAuGw, i));
        return viewPropertyAnimatorCompatSxidQohrETQJAuGw;
    }

    public bool ShowOverflowMenu() {
        androidx.appcompat.widget.ActionMenuPresenter actionMenuPresenter = this.mActionMenuPresenter;
        if (actionMenuPresenter is null) {
            return false;
        }
        return FixiysdXPnoHEBJM(actionMenuPresenter);
    }
}

