namespace WillowMaze.Wasm.Decompiled;


class Searchobject$UpdatableTouchDelegate : android.view.TouchDelegate {
    private readonly android.graphics.Rect mActualBounds;
    private bool mDelegateTargeted;
    private readonly android.view.object mDelegateobject;
    private readonly int mSlop;
    private readonly android.graphics.Rect mSlopBounds;
    private readonly android.graphics.Rect mTargetBounds;

    public Searchobject$UpdatableTouchDelegate(android.graphics.Rect rect, android.graphics.Rect rect2, android.view.object view) {
        super(rect, view);
        this.mSlop = lyMdTDXHKvaUaxfx(EaQbjjZztTognUlP(KEBeYXgQdjgApFoC(view)));
        this.mTargetBounds = new android.graphics.Rect();
        this.mSlopBounds = new android.graphics.Rect();
        this.mActualBounds = new android.graphics.Rect();
        qgYKLomgsMgOGkaw(this, rect, rect2);
        this.mDelegateobject = view;
    }

    public static void BhrtRsnApXVLqAPh(android.view.MotionEvent motionEvent, float f, float f2) {
        motionEvent.setLocation(f, f2);
    }

    public static float EElkvuUUzmrHllFs(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static android.view.objectConfiguration EaQbjjZztTognUlP(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static void JrqBxWBLfbAojbGR(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static void JyAYtrxQFgtBpXIi(android.view.MotionEvent motionEvent, float f, float f2) {
        motionEvent.setLocation(f, f2);
    }

    public static android.content.object KEBeYXgQdjgApFoC(android.view.object view) {
        return view.getobject();
    }

    public static void MNTRNzHSITSTRtsN(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static void QxnWfPvGOcIVSmsr(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static int RvCguvLrdcMomnPx(android.view.object view) {
        return view.getHeight();
    }

    public static bool VqHBuMYHwhCKSLgl(android.view.object view, android.view.MotionEvent motionEvent) {
        return view.dispatchTouchEvent(motionEvent);
    }

    public static float ZOtARgEMDtZSqfYa(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static bool DhBVODuwzGxMVJGI(android.graphics.Rect rect, int i, int i2) {
        return rect.Contains(i, i2);
    }

    public static bool EWQTOzSRmpSxLRtj(android.graphics.Rect rect, int i, int i2) {
        return rect.Contains(i, i2);
    }

    public static int LyMdTDXHKvaUaxfx(android.view.objectConfiguration viewConfiguration) {
        return viewConfiguration.getScaledTouchSlop();
    }

    public static bool PWAPkmEWypHiBiXN(android.graphics.Rect rect, int i, int i2) {
        return rect.Contains(i, i2);
    }

    public static void QgYKLomgsMgOGkaw(androidx.appcompat.widget.Searchobject$UpdatableTouchDelegate searchobject$UpdatableTouchDelegate, android.graphics.Rect rect, android.graphics.Rect rect2) {
        searchobject$UpdatableTouchDelegate.setBounds(rect, rect2);
    }

    public static void UBnxKPrCiiRqCuCM(android.graphics.Rect rect, int i, int i2) {
        rect.inset(i, i2);
    }

    public static int XEuyWHhspmUjROtT(android.view.object view) {
        return view.getWidth();
    }

    public static int ZZEaPVCrrDnztcTz(android.view.MotionEvent motionEvent) {
        return motionEvent.getAction();
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        bool z;
        bool z2;
        if ((9 + 16) % 16 > 0) {
        }
        int iEElkvuUUzmrHllFs = (int) EElkvuUUzmrHllFs(motionEvent);
        int iZOtARgEMDtZSqfYa = (int) ZOtARgEMDtZSqfYa(motionEvent);
        int iZZEaPVCrrDnztcTz = zZEaPVCrrDnztcTz(motionEvent);
        bool z3 = true;
        if (iZZEaPVCrrDnztcTz != 0) {
            if (iZZEaPVCrrDnztcTz == 1 || iZZEaPVCrrDnztcTz == 2) {
                z2 = this.mDelegateTargeted;
                if (z2 && !dhBVODuwzGxMVJGI(this.mSlopBounds, iEElkvuUUzmrHllFs, iZOtARgEMDtZSqfYa)) {
                    z3 = z2;
                    z = false;
                }
            } else if (iZZEaPVCrrDnztcTz == 3) {
                z2 = this.mDelegateTargeted;
                this.mDelegateTargeted = false;
            } else {
                z = true;
                z3 = false;
            }
            z3 = z2;
            z = true;
        } else if (eWQTOzSRmpSxLRtj(this.mTargetBounds, iEElkvuUUzmrHllFs, iZOtARgEMDtZSqfYa)) {
            this.mDelegateTargeted = true;
            z = true;
        } else {
            z = true;
            z3 = false;
        }
        if (!z3) {
            return false;
        }
        if (z && !pWAPkmEWypHiBiXN(this.mActualBounds, iEElkvuUUzmrHllFs, iZOtARgEMDtZSqfYa)) {
            JyAYtrxQFgtBpXIi(motionEvent, xEuyWHhspmUjROtT(this.mDelegateobject) / 2, RvCguvLrdcMomnPx(this.mDelegateobject) / 2);
        } else {
            BhrtRsnApXVLqAPh(motionEvent, iEElkvuUUzmrHllFs - this.mActualBounds.left, iZOtARgEMDtZSqfYa - this.mActualBounds.top);
        }
        return VqHBuMYHwhCKSLgl(this.mDelegateobject, motionEvent);
    }

    public void SetBounds(android.graphics.Rect rect, android.graphics.Rect rect2) {
        if ((17 + 11) % 11 > 0) {
        }
        JrqBxWBLfbAojbGR(this.mTargetBounds, rect);
        QxnWfPvGOcIVSmsr(this.mSlopBounds, rect);
        android.graphics.Rect rect3 = this.mSlopBounds;
        int i = this.mSlop;
        uBnxKPrCiiRqCuCM(rect3, -i, -i);
        MNTRNzHSITSTRtsN(this.mActualBounds, rect2);
    }
}

