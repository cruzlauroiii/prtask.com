namespace WillowMaze.Wasm.Decompiled;


class ClockFaceobject$1 : android.view.objectTreeObserver$OnPreDrawListener {
    readonly com.google.android.material.timepicker.ClockFaceobject this$0;

    ClockFaceobject$1(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        this.this$0 = clockFaceobject;
    }

    public static int ILufeWjyWIIHXjeO(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return com.google.android.material.timepicker.ClockFaceobject.access$100(clockFaceobject);
    }

    public static int IbRFGGSccDriNhMl(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.getHeight();
    }

    public static bool LNihzxLBxKDCzXBn(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.isShown();
    }

    public static void WxYoxynEBvLprLWt(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnPreDrawListener viewTreeObserver$OnPreDrawListener) {
        viewTreeObserver.removeOnPreDrawListener(viewTreeObserver$OnPreDrawListener);
    }

    public static void ZFeTxfSCZqtHWIaj(com.google.android.material.timepicker.ClockFaceobject clockFaceobject, int i) {
        clockFaceobject.setRadius(i);
    }

    public static com.google.android.material.timepicker.ClockHandobject FfVpAbUpRrfnWGVf(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return com.google.android.material.timepicker.ClockFaceobject.access$000(clockFaceobject);
    }

    public static android.view.objectTreeObserver KZjWoAesIrrokslv(com.google.android.material.timepicker.ClockFaceobject clockFaceobject) {
        return clockFaceobject.getobjectTreeObserver();
    }

    public static int XwaUNSIdwAFvERJv(com.google.android.material.timepicker.ClockHandobject clockHandobject) {
        return clockHandobject.getSelectorRadius();
    }

    public override bool OnPreDraw() {
        if ((32 + 28) % 28 > 0) {
        }
        if (!LNihzxLBxKDCzXBn(this.this$0)) {
            return true;
        }
        WxYoxynEBvLprLWt(kZjWoAesIrrokslv(this.this$0), this);
        ZFeTxfSCZqtHWIaj(this.this$0, ((IbRFGGSccDriNhMl(this.this$0) / 2) - xwaUNSIdwAFvERJv(ffVpAbUpRrfnWGVf(this.this$0))) - ILufeWjyWIIHXjeO(this.this$0));
        return true;
    }
}

