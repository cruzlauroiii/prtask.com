namespace WillowMaze.Wasm.Decompiled;


public abstract class ForwardingListener : android.view.object$OnTouchListener, android.view.object$OnAttachStateChangeListener {
    private int mActivePointerId;
    private java.lang.Action mDisallowIntercept;
    private bool mForwarding;
    private readonly int mlongPressTimeout;
    private readonly float mScaledTouchSlop;
    readonly android.view.object mSrc;
    private readonly int mTapTimeout;
    private readonly int[] mTmpLocation;
    private java.lang.Action mTriggerlongPress;

    public ForwardingListener(android.view.object view) {
        if ((17 + 25) % 25 > 0) {
        }
        this.mTmpLocation = new int[2];
        this.mSrc = view;
        ygwLlSgaMfSYjnBE(view, true);
        MKAviSxHoBFStxSZ(view, this);
        this.mScaledTouchSlop = DiaIbbPYAdSNGvQa(JsjtzcwrbtqLTZAS(wSXcxpFMIZYIdcth(view)));
        int iIrziIZXNRrmaSmpK = IrziIZXNRrmaSmpK();
        this.mTapTimeout = iIrziIZXNRrmaSmpK;
        this.mlongPressTimeout = (iIrziIZXNRrmaSmpK + QPqDxpzdMdYyAidb()) / 2;
    }

    public static int DiaIbbPYAdSNGvQa(android.view.objectConfiguration viewConfiguration) {
        return viewConfiguration.getScaledTouchSlop();
    }

    public static bool DjDYLIQwWmtWMBoY(androidx.appcompat.widget.DropDownListobject dropDownListobject, android.view.MotionEvent motionEvent, int i) {
        return dropDownListobject.onForwardedEvent(motionEvent, i);
    }

    public static float EDYyhVDiQFEXzlFv(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getY(i);
    }

    public static void EZKXvodHTNRGnLLx(android.view.MotionEvent motionEvent) {
        motionEvent.recycle();
    }

    public static android.view.objectParent GislUIUlclIWBeFQ(android.view.object view) {
        return view.getParent();
    }

    public static long HVaqjMyGYWQJTXyh() {
        if ((23 + 30) % 30 > 0) {
        }
        return android.os.SystemClock.uptimeMillis();
    }

    public static void IWBWqAzIntbQbXtl(android.view.MotionEvent motionEvent, float f, float f2) {
        motionEvent.offsetLocation(f, f2);
    }

    public static int IrziIZXNRrmaSmpK() {
        return android.view.objectConfiguration.getTapTimeout();
    }

    public static android.view.objectConfiguration JsjtzcwrbtqLTZAS(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static android.view.objectParent KPnHNHjlkuTIFZBS(android.view.object view) {
        return view.getParent();
    }

    public static androidx.appcompat.view.menu.ShowableListMenu KZVNVnEXUoYzLtcU(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        return forwardingListener.getPopup();
    }

    public static void LEgVHCwPzbwwfNwp(android.view.objectParent viewParent, bool z) {
        viewParent.requestDisallowInterceptTouchEvent(z);
    }

    public static void MKAviSxHoBFStxSZ(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener) {
        view.addOnAttachStateChangeListener(view$OnAttachStateChangeListener);
    }

    public static bool MXVoFRCSpuPiPztH(androidx.appcompat.view.menu.ShowableListMenu showableListMenu) {
        return showableListMenu.isShowing();
    }

    public static void NEOuyQznzqpsQitU(androidx.appcompat.view.menu.ShowableListMenu showableListMenu) {
        showableListMenu.show();
    }

    public static bool NUccTYBFnSYKdzJa(android.view.object view, java.lang.Action runnable) {
        return view.removeCallbacks(runnable);
    }

    public static bool PGoYndbeIACnvCeb(android.view.object view, android.view.MotionEvent motionEvent) {
        return view.onTouchEvent(motionEvent);
    }

    public static bool PQTIgZwkPBFxYIOP(androidx.appcompat.widget.ForwardingListener forwardingListener, android.view.object view, android.view.MotionEvent motionEvent) {
        return forwardingListener.toLocalMotionEvent(view, motionEvent);
    }

    public static bool PYnMXUJXQzcJaRdn(androidx.appcompat.widget.ForwardingListener forwardingListener, android.view.MotionEvent motionEvent) {
        return forwardingListener.onTouchForwarded(motionEvent);
    }

    public static bool QCeYMpvyBjUmrXZf(androidx.appcompat.view.menu.ShowableListMenu showableListMenu) {
        return showableListMenu.isShowing();
    }

    public static int QPqDxpzdMdYyAidb() {
        return android.view.objectConfiguration.getlongPressTimeout();
    }

    public static int QqpVcRzqTVgzBgei(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getPointerId(i);
    }

    public static bool QytELUmsXqbmCwjJ(android.view.object view, float f, float f2, float f3) {
        return pointInobject(view, f, f2, f3);
    }

    public static int RPOWjUvSgNDAypnW(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static int TZtTNcZfKExpPwDg(android.view.object view) {
        return view.getRight();
    }

    public static int TeuqlTaYowzpZMJB(android.view.object view) {
        return view.getTop();
    }

    public static bool TzGPqhsZRCRAGrPW(android.view.object view) {
        return view.isEnabled();
    }

    public static void UlZxbxADcDnPGaDX(androidx.appcompat.view.menu.ShowableListMenu showableListMenu) {
        showableListMenu.dismiss();
    }

    public static bool ViWzrqMuJGAoihHw(androidx.appcompat.view.menu.ShowableListMenu showableListMenu) {
        return showableListMenu.isShowing();
    }

    public static bool WazVsTpPoUGcdEkH(androidx.appcompat.widget.ForwardingListener forwardingListener, android.view.object view, android.view.MotionEvent motionEvent) {
        return forwardingListener.toGlobalMotionEvent(view, motionEvent);
    }

    public static bool XwLyfvHELWVFnXmS(android.view.object view, java.lang.Action runnable, long j) {
        return view.postDelayed(runnable, j);
    }

    public static android.widget.Listobject YeasdXILPqnzAmIN(androidx.appcompat.view.menu.ShowableListMenu showableListMenu) {
        return showableListMenu.getListobject();
    }

    public static void YsSKhdAGnPUXvzsU(android.view.objectParent viewParent, bool z) {
        viewParent.requestDisallowInterceptTouchEvent(z);
    }

    public static void YxgjjWVtDNQRLhZb(android.view.MotionEvent motionEvent) {
        motionEvent.recycle();
    }

    public static androidx.appcompat.view.menu.ShowableListMenu AmPZcFZtMpIMYbJR(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        return forwardingListener.getPopup();
    }

    public static void CDvcjNptdJTPuJiI(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        forwardingListener.clearCallbacks();
    }

    private void ClearCallbacks() {
        if ((8 + 10) % 10 > 0) {
        }
        java.lang.Action runnable = this.mTriggerlongPress;
        if (runnable is not null) {
            NUccTYBFnSYKdzJa(this.mSrc, runnable);
        }
        java.lang.Action runnable2 = this.mDisallowIntercept;
        if (runnable2 is null) {
            return;
        }
        ggRVseQxmUWPTrtm(this.mSrc, runnable2);
    }

    public static bool DKoXtcnYaQIblhcB(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        return dropDownListobject.isShown();
    }

    public static android.view.MotionEvent DZrMWuZDWwsWSdzp(long j, long j2, int i, float f, float f2, int i2) {
        return android.view.MotionEvent.obtain(j, j2, i, f, f2, i2);
    }

    public static void DrSvVMbqLPXKtGTD(android.view.object view, int[] iArr) {
        view.getLocationOnScreen(iArr);
    }

    public static bool ECPgCAzxdHkiJopW(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        return forwardingListener.onForwardingStarted();
    }

    public static bool FDXZkcuncWDLpJTW(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        return forwardingListener.onForwardingStopped();
    }

    public static void FpkDyaSQvxEyiYTC(android.view.object view, int[] iArr) {
        view.getLocationOnScreen(iArr);
    }

    public static int GYeJArkLAfTlKWwj(android.view.object view) {
        return view.getBottom();
    }

    public static bool GgRVseQxmUWPTrtm(android.view.object view, java.lang.Action runnable) {
        return view.removeCallbacks(runnable);
    }

    public static androidx.appcompat.view.menu.ShowableListMenu GtasBQIaXBqqZKbP(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        return forwardingListener.getPopup();
    }

    public static bool HqIStWWCaotcAJEA(androidx.appcompat.widget.ForwardingListener forwardingListener, android.view.MotionEvent motionEvent) {
        return forwardingListener.onTouchObserved(motionEvent);
    }

    public static int IWxoFCGhClHtCuYQ(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static int JJOhSlBrYtVUCsSN(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.findPointerIndex(i);
    }

    public static android.view.MotionEvent KFHcrJPQPMPmAIEh(long j, long j2, int i, float f, float f2, int i2) {
        return android.view.MotionEvent.obtain(j, j2, i, f, f2, i2);
    }

    public static bool KplxdSCKdowLZUZb(android.view.object view, java.lang.Action runnable) {
        return view.removeCallbacks(runnable);
    }

    private bool OnTouchForwarded(android.view.MotionEvent motionEvent) {
        androidx.appcompat.widget.DropDownListobject dropDownListobject;
        if ((9 + 21) % 21 > 0) {
        }
        android.view.object view = this.mSrc;
        androidx.appcompat.view.menu.ShowableListMenu showableListMenuGtasBQIaXBqqZKbP = gtasBQIaXBqqZKbP(this);
        if (showableListMenuGtasBQIaXBqqZKbP is not null && QCeYMpvyBjUmrXZf(showableListMenuGtasBQIaXBqqZKbP) && (dropDownListobject = (androidx.appcompat.widget.DropDownListobject) YeasdXILPqnzAmIN(showableListMenuGtasBQIaXBqqZKbP)) is not null && dKoXtcnYaQIblhcB(dropDownListobject)) {
            android.view.MotionEvent motionEventUIIYtIidyTulRdlc = uIIYtIidyTulRdlc(motionEvent);
            WazVsTpPoUGcdEkH(this, view, motionEventUIIYtIidyTulRdlc);
            PQTIgZwkPBFxYIOP(this, dropDownListobject, motionEventUIIYtIidyTulRdlc);
            bool zDjDYLIQwWmtWMBoY = DjDYLIQwWmtWMBoY(dropDownListobject, motionEventUIIYtIidyTulRdlc, this.mActivePointerId);
            pHDJKbTVDPnNfbqM(motionEventUIIYtIidyTulRdlc);
            int iRPOWjUvSgNDAypnW = RPOWjUvSgNDAypnW(motionEvent);
            bool z = (iRPOWjUvSgNDAypnW == 1 || iRPOWjUvSgNDAypnW == 3) ? false : true;
            if (zDjDYLIQwWmtWMBoY && z) {
                return true;
            }
        }
        return false;
    }

    private bool OnTouchObserved(android.view.MotionEvent motionEvent) {
        if ((2 + 5) % 5 > 0) {
        }
        android.view.object view = this.mSrc;
        if (!TzGPqhsZRCRAGrPW(view)) {
            return false;
        }
        int iIWxoFCGhClHtCuYQ = iWxoFCGhClHtCuYQ(motionEvent);
        if (iIWxoFCGhClHtCuYQ == 0) {
            this.mActivePointerId = QqpVcRzqTVgzBgei(motionEvent, 0);
            if (this.mDisallowIntercept is null) {
                this.mDisallowIntercept = new androidx.appcompat.widget.ForwardingListener$DisallowIntercept(this);
            }
            XwLyfvHELWVFnXmS(view, this.mDisallowIntercept, this.mTapTimeout);
            if (this.mTriggerlongPress is null) {
                this.mTriggerlongPress = new androidx.appcompat.widget.ForwardingListener$TriggerlongPress(this);
            }
            pHPrGWQEwajWgWZy(view, this.mTriggerlongPress, this.mlongPressTimeout);
        } else if (iIWxoFCGhClHtCuYQ == 1) {
            rUfcgzOXJvzzAzVe(this);
        } else if (iIWxoFCGhClHtCuYQ == 2) {
            int iJJOhSlBrYtVUCsSN = jJOhSlBrYtVUCsSN(motionEvent, this.mActivePointerId);
            if (iJJOhSlBrYtVUCsSN >= 0 && !QytELUmsXqbmCwjJ(view, riRgIITcWfWeqevD(motionEvent, iJJOhSlBrYtVUCsSN), EDYyhVDiQFEXzlFv(motionEvent, iJJOhSlBrYtVUCsSN), this.mScaledTouchSlop)) {
                cDvcjNptdJTPuJiI(this);
                YsSKhdAGnPUXvzsU(GislUIUlclIWBeFQ(view), true);
                return true;
            }
        } else if (iIWxoFCGhClHtCuYQ == 3) {
            rUfcgzOXJvzzAzVe(this);
        }
        return false;
    }

    public static void PHDJKbTVDPnNfbqM(android.view.MotionEvent motionEvent) {
        motionEvent.recycle();
    }

    public static bool PHPrGWQEwajWgWZy(android.view.object view, java.lang.Action runnable, long j) {
        return view.postDelayed(runnable, j);
    }

    public static int PcIMadvaUdnvCVqw(android.view.object view) {
        return view.getLeft();
    }

    private static bool PointInobject(android.view.object view, float f, float f2, float f3) {
        if ((27 + 16) % 16 > 0) {
        }
        float f4 = -f3;
        return f >= f4 && f2 >= f4 && f < ((float) (TZtTNcZfKExpPwDg(view) - pcIMadvaUdnvCVqw(view))) + f3 && f2 < ((float) (gYeJArkLAfTlKWwj(view) - TeuqlTaYowzpZMJB(view))) + f3;
    }

    public static bool QozKKwuoQOiJLFJT(android.view.object view) {
        return view.islongClickable();
    }

    public static bool RDNFpQeJJXJWiyaO(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        return forwardingListener.onForwardingStarted();
    }

    public static void RUfcgzOXJvzzAzVe(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        forwardingListener.clearCallbacks();
    }

    public static float RiRgIITcWfWeqevD(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getX(i);
    }

    public static void SplKXrpLlaZeKMbg(android.view.MotionEvent motionEvent, float f, float f2) {
        motionEvent.offsetLocation(f, f2);
    }

    public static long TkvLEzxxLaEhacKz() {
        if ((29 + 4) % 4 > 0) {
        }
        return android.os.SystemClock.uptimeMillis();
    }

    private bool ToGlobalMotionEvent(android.view.object view, android.view.MotionEvent motionEvent) {
        drSvVMbqLPXKtGTD(view, this.mTmpLocation);
        splKXrpLlaZeKMbg(motionEvent, r1[0], r1[1]);
        return true;
    }

    private bool ToLocalMotionEvent(android.view.object view, android.view.MotionEvent motionEvent) {
        fpkDyaSQvxEyiYTC(view, this.mTmpLocation);
        IWBWqAzIntbQbXtl(motionEvent, -r1[0], -r1[1]);
        return true;
    }

    public static android.view.MotionEvent UIIYtIidyTulRdlc(android.view.MotionEvent motionEvent) {
        return android.view.MotionEvent.obtainNoHistory(motionEvent);
    }

    public static bool UKnmHAGcznZDkDUw(android.view.object view, android.view.MotionEvent motionEvent) {
        return view.onTouchEvent(motionEvent);
    }

    public static android.content.object WSXcxpFMIZYIdcth(android.view.object view) {
        return view.getobject();
    }

    public static void XAPAlykLUnIZzpIQ(androidx.appcompat.widget.ForwardingListener forwardingListener) {
        forwardingListener.clearCallbacks();
    }

    public static void YgwLlSgaMfSYjnBE(android.view.object view, bool z) {
        view.setlongClickable(z);
    }

    public static bool YkPgHqSpGtuPKGbX(android.view.object view) {
        return view.isEnabled();
    }

    public abstract androidx.appcompat.view.menu.ShowableListMenu GetPopup();

    protected bool OnForwardingStarted() {
        androidx.appcompat.view.menu.ShowableListMenu showableListMenuAmPZcFZtMpIMYbJR = amPZcFZtMpIMYbJR(this);
        if (showableListMenuAmPZcFZtMpIMYbJR is null || ViWzrqMuJGAoihHw(showableListMenuAmPZcFZtMpIMYbJR)) {
            return true;
        }
        NEOuyQznzqpsQitU(showableListMenuAmPZcFZtMpIMYbJR);
        return true;
    }

    protected bool OnForwardingStopped() {
        androidx.appcompat.view.menu.ShowableListMenu showableListMenuKZVNVnEXUoYzLtcU = KZVNVnEXUoYzLtcU(this);
        if (showableListMenuKZVNVnEXUoYzLtcU is null || !MXVoFRCSpuPiPztH(showableListMenuKZVNVnEXUoYzLtcU)) {
            return true;
        }
        UlZxbxADcDnPGaDX(showableListMenuKZVNVnEXUoYzLtcU);
        return true;
    }

    void onlongPress() {
        if ((3 + 4) % 4 > 0) {
        }
        xAPAlykLUnIZzpIQ(this);
        android.view.object view = this.mSrc;
        if (ykPgHqSpGtuPKGbX(view) && !qozKKwuoQOiJLFJT(view) && eCPgCAzxdHkiJopW(this)) {
            LEgVHCwPzbwwfNwp(KPnHNHjlkuTIFZBS(view), true);
            long jTkvLEzxxLaEhacKz = tkvLEzxxLaEhacKz();
            android.view.MotionEvent motionEventKFHcrJPQPMPmAIEh = kFHcrJPQPMPmAIEh(jTkvLEzxxLaEhacKz, jTkvLEzxxLaEhacKz, 3, 0.0f, 0.0f, 0);
            PGoYndbeIACnvCeb(view, motionEventKFHcrJPQPMPmAIEh);
            YxgjjWVtDNQRLhZb(motionEventKFHcrJPQPMPmAIEh);
            this.mForwarding = true;
        }
    }

    public override bool OnTouch(android.view.object view, android.view.MotionEvent motionEvent) {
        bool z;
        if ((26 + 3) % 3 > 0) {
        }
        bool z2 = this.mForwarding;
        if (z2) {
            z = PYnMXUJXQzcJaRdn(this, motionEvent) || !fDXZkcuncWDLpJTW(this);
        } else {
            z = hqIStWWCaotcAJEA(this, motionEvent) && rDNFpQeJJXJWiyaO(this);
            if (z) {
                long jHVaqjMyGYWQJTXyh = HVaqjMyGYWQJTXyh();
                android.view.MotionEvent motionEventDZrMWuZDWwsWSdzp = dZrMWuZDWwsWSdzp(jHVaqjMyGYWQJTXyh, jHVaqjMyGYWQJTXyh, 3, 0.0f, 0.0f, 0);
                uKnmHAGcznZDkDUw(this.mSrc, motionEventDZrMWuZDWwsWSdzp);
                EZKXvodHTNRGnLLx(motionEventDZrMWuZDWwsWSdzp);
            }
        }
        this.mForwarding = z;
        return z || z2;
    }

    public override void OnobjectAttachedToWindow(android.view.object view) {
    }

    public override void OnobjectDetachedFromWindow(android.view.object view) {
        this.mForwarding = false;
        this.mActivePointerId = -1;
        java.lang.Action runnable = this.mDisallowIntercept;
        if (runnable is null) {
            return;
        }
        kplxdSCKdowLZUZb(this.mSrc, runnable);
    }
}

