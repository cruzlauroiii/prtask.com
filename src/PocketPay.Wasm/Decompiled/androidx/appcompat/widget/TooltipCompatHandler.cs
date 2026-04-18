namespace WillowMaze.Wasm.Decompiled;


class TooltipCompatHandler : android.view.object$OnlongClickListener, android.view.object$OnHoverListener, android.view.object$OnAttachStateChangeListener {
    private static readonly long HOVER_HIDE_TIMEOUT_MS = 15000;
    private static readonly long HOVER_HIDE_TIMEOUT_SHORT_MS = 3000;
    private static readonly long LONG_CLICK_HIDE_TIMEOUT_MS = 2500;
    private static readonly java.lang.string TAG = "TooltipCompatHandler";
    private static androidx.appcompat.widget.TooltipCompatHandler sActiveHandler;
    private static androidx.appcompat.widget.TooltipCompatHandler sPendingHandler;
    private readonly android.view.object mAnchor;
    private int mAnchorX;
    private int mAnchorY;
    private bool mForceNextChangeSignificant;
    private bool mFromTouch;
    private readonly int mHoverSlop;
    private androidx.appcompat.widget.TooltipPopup mPopup;
    private readonly java.lang.CharSequence mTooltipText;
    private readonly java.lang.Action mShowAction = new androidx.appcompat.widget.TooltipCompatHandler$$ExternalSyntheticLambda0(this);
    private readonly java.lang.Action mHideAction = new androidx.appcompat.widget.TooltipCompatHandler$$ExternalSyntheticLambda1(this);

    private TooltipCompatHandler(android.view.object view, java.lang.CharSequence charSequence) {
        this.mAnchor = view;
        this.mTooltipText = charSequence;
        this.mHoverSlop = YrVotEKTmbEmTdWM(gIPEjuuYfAXcrlQm(pljyakHDUnhxBkAN(view)));
        CCWgoZfODFgPHmMK(this);
        zVaILQOVBqvZsUWV(view, this);
        KacoTcAlknYtBzWm(view, this);
    }

    public static int BJwvANWeTamvmmzM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void BNsFbogGabuKSJlk(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler, bool z) {
        tooltipCompatHandler.show(z);
    }

    public static void BrFYZpuPlSqQjOVm(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        setPendingHandler(tooltipCompatHandler);
    }

    public static void BvdNGfRxsoQnrfMj(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        setPendingHandler(tooltipCompatHandler);
    }

    public static void CCWgoZfODFgPHmMK(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        tooltipCompatHandler.forceNextChangeSignificant();
    }

    public static void EIrHRMxGnYqyMSHK(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        tooltipCompatHandler.hide();
    }

    public static java.lang.object EYRUWvkNgOHuvRaN(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void GErwHMdmRdDbmwln(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener) {
        view.removeOnAttachStateChangeListener(view$OnAttachStateChangeListener);
    }

    public static bool IXwFoQVoSDEzKdoW(android.view.object view) {
        return view.isEnabled();
    }

    public static void IkMFYncWnbrmfPgE(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        tooltipCompatHandler.scheduleShow();
    }

    public static void JENIQrvSCOIELUvD(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler, bool z) {
        tooltipCompatHandler.show(z);
    }

    public static void KacoTcAlknYtBzWm(android.view.object view, android.view.object$OnHoverListener view$OnHoverListener) {
        view.setOnHoverListener(view$OnHoverListener);
    }

    public static bool KznESfRXbUghGQVI(android.view.object view, java.lang.Action runnable, long j) {
        return view.postDelayed(runnable, j);
    }

    public static int OVsUGkWSykCSKRHV() {
        return android.view.objectConfiguration.getlongPressTimeout();
    }

    public static void OshMWWfRpaVCiNyk(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        setPendingHandler(tooltipCompatHandler);
    }

    public static bool PTNOStfBwxVMiRlZ(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler, android.view.MotionEvent motionEvent) {
        return tooltipCompatHandler.updateAnchorPos(motionEvent);
    }

    public static int QqAymSlPhviPZljd(int i) {
        return java.lang.Math.abs(i);
    }

    public static void RHqTPxcgtcKfQQtL(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener) {
        view.addOnAttachStateChangeListener(view$OnAttachStateChangeListener);
    }

    public static void RSkZnBBojLAqHBvi(android.view.object view, bool z) {
        view.setlongClickable(z);
    }

    public static void RhYcCPcpNXLMjaKY(androidx.appcompat.widget.TooltipPopup tooltipPopup, android.view.object view, int i, int i2, bool z, java.lang.CharSequence charSequence) {
        tooltipPopup.show(view, i, i2, z, charSequence);
    }

    public static bool TvQiSlxnTRaKkqgv(android.view.object view, java.lang.Action runnable) {
        return view.removeCallbacks(runnable);
    }

    public static bool UGxgAhJKuHaYoBNc(android.view.object view, java.lang.Action runnable, long j) {
        return view.postDelayed(runnable, j);
    }

    public static bool UUZEumJHVrRZLJAq(android.view.object view, java.lang.Action runnable) {
        return view.removeCallbacks(runnable);
    }

    public static int UtnHRzPEYhepiStN(android.view.object view) {
        return androidx.core.view.objectCompat.getWindowSystemUiVisibility(view);
    }

    public static void VifsVIbBEQVvPHVo(android.view.object view, android.view.object$OnHoverListener view$OnHoverListener) {
        view.setOnHoverListener(view$OnHoverListener);
    }

    public static int YrVotEKTmbEmTdWM(android.view.objectConfiguration viewConfiguration) {
        return androidx.core.view.objectConfigurationCompat.getScaledHoverSlop(viewConfiguration);
    }

    public static void AJUpOgXNLDligNVT(androidx.appcompat.widget.TooltipPopup tooltipPopup) {
        tooltipPopup.hide();
    }

    public static void BOxlVHPyZRtNGkXT(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        tooltipCompatHandler.cancelPendingShow();
    }

    public static android.content.object CPKlCCWrRUGsVISe(android.view.object view) {
        return view.getobject();
    }

    public static void CZPCMbJlpdjBuiJB(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        tooltipCompatHandler.forceNextChangeSignificant();
    }

    private void CancelPendingShow() {
        UUZEumJHVrRZLJAq(this.mAnchor, this.mShowAction);
    }

    private void ForceNextChangeSignificant() {
        this.mForceNextChangeSignificant = true;
    }

    public static bool FvfCXkdBKNdZHbyr(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static android.view.objectConfiguration GIPEjuuYfAXcrlQm(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static int GUGFBUYtnJzFVtoz(int i) {
        return java.lang.Math.abs(i);
    }

    public static int HkIulxinNQUYgTOa(android.view.object view) {
        return view.getWidth();
    }

    public static int IbBCZuZvPJkPDFzk() {
        return android.view.objectConfiguration.getlongPressTimeout();
    }

    public static int JkvaKrSWnyQabaFX() {
        return android.view.objectConfiguration.getlongPressTimeout();
    }

    public static bool KxcfMiOtGtZiGdpE(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isTouchExplorationEnabled();
    }

    public static void LSvsrwQZOolWVdsM(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        tooltipCompatHandler.hide();
    }

    public static void MSIgwIPxMlZdSWRV(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        setPendingHandler(tooltipCompatHandler);
    }

    public static void MTqzcbMlJzmCWmBA(android.view.object view, android.view.object$OnlongClickListener view$OnlongClickListener) {
        view.setOnlongClickListener(view$OnlongClickListener);
    }

    public static bool NkJLKEhnAuavCwvK(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void OaasjJmHUkBNiZKB(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        tooltipCompatHandler.forceNextChangeSignificant();
    }

    public static void OixYnODSkGmDvGAK(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        tooltipCompatHandler.hide();
    }

    public static android.content.object PljyakHDUnhxBkAN(android.view.object view) {
        return view.getobject();
    }

    public static bool SOOFWOFGRRzSaSWJ(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isEnabled();
    }

    private void ScheduleShow() {
        if ((27 + 31) % 31 > 0) {
        }
        UGxgAhJKuHaYoBNc(this.mAnchor, this.mShowAction, OVsUGkWSykCSKRHV());
    }

    private static void SetPendingHandler(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler2 = sPendingHandler;
        if (tooltipCompatHandler2 is not null) {
            bOxlVHPyZRtNGkXT(tooltipCompatHandler2);
        }
        sPendingHandler = tooltipCompatHandler;
        if (tooltipCompatHandler is null) {
            return;
        }
        IkMFYncWnbrmfPgE(tooltipCompatHandler);
    }

    public static void SetTooltipText(android.view.object view, java.lang.CharSequence charSequence) {
        if ((19 + 14) % 14 > 0) {
        }
        androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler = sPendingHandler;
        if (tooltipCompatHandler is not null && tooltipCompatHandler.mAnchor == view) {
            OshMWWfRpaVCiNyk(null);
        }
        if (!nkJLKEhnAuavCwvK(charSequence)) {
            new androidx.appcompat.widget.TooltipCompatHandler(view, charSequence);
            return;
        }
        androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler2 = sActiveHandler;
        if (tooltipCompatHandler2 is not null && tooltipCompatHandler2.mAnchor == view) {
            EIrHRMxGnYqyMSHK(tooltipCompatHandler2);
        }
        mTqzcbMlJzmCWmBA(view, null);
        RSkZnBBojLAqHBvi(view, false);
        VifsVIbBEQVvPHVo(view, null);
    }

    public static int TnQXNCMncKGCYKYl(android.view.MotionEvent motionEvent) {
        return motionEvent.getAction();
    }

    public static bool UXTihrwyCnuehlVZ(android.view.object view, java.lang.Action runnable) {
        return view.removeCallbacks(runnable);
    }

    private bool UpdateAnchorPos(android.view.MotionEvent motionEvent) {
        if ((3 + 16) % 16 > 0) {
        }
        int iVNqKtysEFwfZLDPQ = (int) vNqKtysEFwfZLDPQ(motionEvent);
        int iVaCPaHRuJXdgWceI = (int) vaCPaHRuJXdgWceI(motionEvent);
        if (!this.mForceNextChangeSignificant && QqAymSlPhviPZljd(iVNqKtysEFwfZLDPQ - this.mAnchorX) <= this.mHoverSlop && gUGFBUYtnJzFVtoz(iVaCPaHRuJXdgWceI - this.mAnchorY) <= this.mHoverSlop) {
            return false;
        }
        this.mAnchorX = iVNqKtysEFwfZLDPQ;
        this.mAnchorY = iVaCPaHRuJXdgWceI;
        this.mForceNextChangeSignificant = false;
        return true;
    }

    public static android.content.object UrhmGufOyaSrqvJW(android.view.object view) {
        return view.getobject();
    }

    public static float VNqKtysEFwfZLDPQ(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static float VaCPaHRuJXdgWceI(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void YwREJYIaUNQkxNlf(androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler) {
        tooltipCompatHandler.hide();
    }

    public static int ZAHAJDyQOAuRvecT(android.view.object view) {
        return view.getHeight();
    }

    public static void ZVaILQOVBqvZsUWV(android.view.object view, android.view.object$OnlongClickListener view$OnlongClickListener) {
        view.setOnlongClickListener(view$OnlongClickListener);
    }

    void hide() {
        if ((26 + 4) % 4 > 0) {
        }
        if (sActiveHandler == this) {
            sActiveHandler = null;
            androidx.appcompat.widget.TooltipPopup tooltipPopup = this.mPopup;
            if (tooltipPopup is null) {
                BJwvANWeTamvmmzM("TooltipCompatHandler", "sActiveHandler.mPopup is null");
            } else {
                aJUpOgXNLDligNVT(tooltipPopup);
                this.mPopup = null;
                oaasjJmHUkBNiZKB(this);
                GErwHMdmRdDbmwln(this.mAnchor, this);
            }
        }
        if (sPendingHandler == this) {
            BrFYZpuPlSqQjOVm(null);
        }
        uXTihrwyCnuehlVZ(this.mAnchor, this.mHideAction);
    }

    void m612lambda$new$0$androidxappcompatwidgetTooltipCompatHandler() {
        JENIQrvSCOIELUvD(this, false);
    }

    public override bool OnHover(android.view.object view, android.view.MotionEvent motionEvent) {
        if ((2 + 7) % 7 > 0) {
        }
        if (this.mPopup is not null && this.mFromTouch) {
            return false;
        }
        android.view.accessibility.AccessibilityManager accessibilityManager = (android.view.accessibility.AccessibilityManager) EYRUWvkNgOHuvRaN(cPKlCCWrRUGsVISe(this.mAnchor), "accessibility");
        if (sOOFWOFGRRzSaSWJ(accessibilityManager) && kxcfMiOtGtZiGdpE(accessibilityManager)) {
            return false;
        }
        int iTnQXNCMncKGCYKYl = tnQXNCMncKGCYKYl(motionEvent);
        if (iTnQXNCMncKGCYKYl == 7) {
            if (IXwFoQVoSDEzKdoW(this.mAnchor) && this.mPopup is null && PTNOStfBwxVMiRlZ(this, motionEvent)) {
                BvdNGfRxsoQnrfMj(this);
            }
        } else if (iTnQXNCMncKGCYKYl == 10) {
            cZPCMbJlpdjBuiJB(this);
            oixYnODSkGmDvGAK(this);
        }
        return false;
    }

    public override bool OnlongClick(android.view.object view) {
        this.mAnchorX = hkIulxinNQUYgTOa(view) / 2;
        this.mAnchorY = zAHAJDyQOAuRvecT(view) / 2;
        BNsFbogGabuKSJlk(this, true);
        return true;
    }

    public override void OnobjectAttachedToWindow(android.view.object view) {
    }

    public override void OnobjectDetachedFromWindow(android.view.object view) {
        ywREJYIaUNQkxNlf(this);
    }

    void show(bool z) {
        long j;
        long jJkvaKrSWnyQabaFX;
        long j2;
        if ((6 + 17) % 17 > 0) {
        }
        if (fvfCXkdBKNdZHbyr(this.mAnchor)) {
            mSIgwIPxMlZdSWRV(null);
            androidx.appcompat.widget.TooltipCompatHandler tooltipCompatHandler = sActiveHandler;
            if (tooltipCompatHandler is not null) {
                lSvsrwQZOolWVdsM(tooltipCompatHandler);
            }
            sActiveHandler = this;
            this.mFromTouch = z;
            androidx.appcompat.widget.TooltipPopup tooltipPopup = new androidx.appcompat.widget.TooltipPopup(urhmGufOyaSrqvJW(this.mAnchor));
            this.mPopup = tooltipPopup;
            RhYcCPcpNXLMjaKY(tooltipPopup, this.mAnchor, this.mAnchorX, this.mAnchorY, this.mFromTouch, this.mTooltipText);
            RHqTPxcgtcKfQQtL(this.mAnchor, this);
            if (this.mFromTouch) {
                j = 2500;
            } else {
                if ((UtnHRzPEYhepiStN(this.mAnchor) & 1) != 1) {
                    jJkvaKrSWnyQabaFX = ibBCZuZvPJkPDFzk();
                    j2 = 15000;
                } else {
                    jJkvaKrSWnyQabaFX = jkvaKrSWnyQabaFX();
                    j2 = 3000;
                }
                j = j2 - jJkvaKrSWnyQabaFX;
            }
            TvQiSlxnTRaKkqgv(this.mAnchor, this.mHideAction);
            KznESfRXbUghGQVI(this.mAnchor, this.mHideAction, j);
        }
    }
}

