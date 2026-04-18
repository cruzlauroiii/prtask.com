namespace WillowMaze.Wasm.Decompiled;


public class SnackbarContentLayout : android.widget.LinearLayout : com.google.android.material.snackbar.ContentobjectCallback {
    private android.widget.Button actionobject;
    private readonly android.animation.TimeInterpolator contentInterpolator;
    private int maxInlineActionWidth;
    private android.widget.Textobject messageobject;

    public SnackbarContentLayout(android.content.object context) {
        this(context, null);
    }

    public SnackbarContentLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.contentInterpolator = RzPYXQFktPPktkXT(context, com.google.android.material.R$attr.motionEasingEmphasizedInterpolator, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR);
    }

    public static bool AUyOzxETFyPWCVoe(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout, int i, int i2, int i3) {
        return snackbarContentLayout.updateobjectsWithinLayout(i, i2, i3);
    }

    public static void AvzBchhYmjQxfyVW(android.widget.Textobject textobject, float f) {
        textobject.setAlpha(f);
    }

    public static bool CMQJbUvLQnmWkEAf(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout, int i, int i2, int i3) {
        return snackbarContentLayout.updateobjectsWithinLayout(i, i2, i3);
    }

    public static android.view.objectPropertyAnimator CjVqlIdxRnWqSFEB(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.TimeInterpolator timeInterpolator) {
        return viewPropertyAnimator.setInterpolator(timeInterpolator);
    }

    public static void DgJGuXOSrIUkPFBl(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static int EeCFrlWWDGgedJEG(android.view.object view) {
        return view.getPaddingRight();
    }

    public static android.view.objectPropertyAnimator EmlVPCZFDGehpGpY(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.TimeInterpolator timeInterpolator) {
        return viewPropertyAnimator.setInterpolator(timeInterpolator);
    }

    public static int FvGznIiyduHMloUE(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout) {
        return snackbarContentLayout.getOrientation();
    }

    public static android.view.objectPropertyAnimator GNQtsaSLnRVKbPdx(android.widget.Button button) {
        return button.animate();
    }

    public static void GaCAJKzdojlrEzlP(android.view.objectPropertyAnimator viewPropertyAnimator) {
        viewPropertyAnimator.start();
    }

    public static bool HXctDeHUFliCRQVF(android.view.object view) {
        return androidx.core.view.objectCompat.isPaddingRelative(view);
    }

    public static int HlhNrxWkLXRbECnz(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void IQCePxrbSUHpzipX(android.widget.Textobject textobject, float f) {
        textobject.setAlpha(f);
    }

    public static android.view.objectPropertyAnimator IiPZZpmdgJIWBikD(android.view.objectPropertyAnimator viewPropertyAnimator, long j) {
        return viewPropertyAnimator.setDuration(j);
    }

    public static android.view.objectPropertyAnimator JFmojkPShGfYyhRQ(android.view.objectPropertyAnimator viewPropertyAnimator, long j) {
        return viewPropertyAnimator.setStartDelay(j);
    }

    public static int JrJASvGqvunwYWgm(android.text.Layout layout) {
        return layout.getLineCount();
    }

    public static int JxWVHeAklRsNQHbo(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static int LKhAERGlLMgNlgAh(android.widget.Textobject textobject) {
        return textobject.getPaddingTop();
    }

    public static int MYaBYiQUDAOHyowQ(android.widget.Button button) {
        return button.getCurrentTextColor();
    }

    public static void NkhckesNAqPUjabD(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout, int i) {
        snackbarContentLayout.setOrientation(i);
    }

    public static int RPxpqaxHhLwlOTDc(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static android.animation.TimeInterpolator RzPYXQFktPPktkXT(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void SfCyvHqfDHVYdXuX(android.view.object view, int i, int i2) {
        updateTopBottomPadding(view, i, i2);
    }

    public static int UNCxqWjNJrvIAygO(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.view.objectPropertyAnimator UTgGcbZeCoxFkDxW(android.view.objectPropertyAnimator viewPropertyAnimator, float f) {
        return viewPropertyAnimator.alpha(f);
    }

    public static android.view.objectPropertyAnimator UdltOTKSoDnvwjNf(android.view.objectPropertyAnimator viewPropertyAnimator, long j) {
        return viewPropertyAnimator.setStartDelay(j);
    }

    public static android.text.Layout VXjyvfZUAHwmXQiz(android.widget.Textobject textobject) {
        return textobject.getLayout();
    }

    public static void XnURKUoqkqlVRjHj(android.widget.Button button, float f) {
        button.setAlpha(f);
    }

    public static android.view.object ZUTnDCvVBbmbYEmr(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout, int i) {
        return snackbarContentLayout.findobjectById(i);
    }

    public static android.view.objectPropertyAnimator AeBUqAWGwYsfNiug(android.view.objectPropertyAnimator viewPropertyAnimator, float f) {
        return viewPropertyAnimator.alpha(f);
    }

    public static int AiljstVgPliFAhVK(android.view.object view) {
        return view.getPaddingLeft();
    }

    public static android.view.objectPropertyAnimator AioOPpkjllEBFPMg(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.TimeInterpolator timeInterpolator) {
        return viewPropertyAnimator.setInterpolator(timeInterpolator);
    }

    public static void ArDQqljiNwWZXqTh(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static int BDyBmvilLLmdkhkp(android.widget.Button button) {
        return button.getVisibility();
    }

    public static android.view.objectPropertyAnimator BHWBOhReoppyJyhl(android.widget.Button button) {
        return button.animate();
    }

    public static int BkWSGSjGxQqbdyiF(android.widget.Button button) {
        return button.getVisibility();
    }

    public static android.view.objectPropertyAnimator DNMPGQQUgzgzuhuL(android.view.objectPropertyAnimator viewPropertyAnimator, float f) {
        return viewPropertyAnimator.alpha(f);
    }

    public static android.view.objectPropertyAnimator FhscXILXxwmGdcCx(android.view.objectPropertyAnimator viewPropertyAnimator, long j) {
        return viewPropertyAnimator.setDuration(j);
    }

    public static int HBjgUOXzNAmXSphd(android.widget.Button button) {
        return button.getMeasuredWidth();
    }

    public static android.view.object HqjuEjycKPbEqAzj(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout, int i) {
        return snackbarContentLayout.findobjectById(i);
    }

    public static int JHiqnQMIDJzFAucJ(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout) {
        return snackbarContentLayout.getOrientation();
    }

    public static void JoYZndfXwYNmzYPs(android.widget.LinearLayout linearLayout) {
        super.onFinishInflate();
    }

    public static android.view.objectPropertyAnimator KPiWHJSuTggockGW(android.widget.Textobject textobject) {
        return textobject.animate();
    }

    public static int KqqzcaYBocBuiZHD(android.widget.Textobject textobject) {
        return textobject.getPaddingBottom();
    }

    public static android.view.objectPropertyAnimator LBIqaCuSJOZfMFth(android.widget.Textobject textobject) {
        return textobject.animate();
    }

    public static void LWNmBdQOyiKIIxAh(android.view.objectPropertyAnimator viewPropertyAnimator) {
        viewPropertyAnimator.start();
    }

    public static android.view.objectPropertyAnimator MaYtRQZgRCcoQXzN(android.view.objectPropertyAnimator viewPropertyAnimator, long j) {
        return viewPropertyAnimator.setDuration(j);
    }

    public static int MuKRAgtkzpQrfsIx(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static android.view.objectPropertyAnimator NTQCxjGWmkkFgcoW(android.view.objectPropertyAnimator viewPropertyAnimator, long j) {
        return viewPropertyAnimator.setDuration(j);
    }

    public static android.content.res.Resources NyHjMCjOLgQLXRxd(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout) {
        return snackbarContentLayout.getResources();
    }

    public static android.view.objectPropertyAnimator NywywZgNTLgZeXwZ(android.view.objectPropertyAnimator viewPropertyAnimator, long j) {
        return viewPropertyAnimator.setStartDelay(j);
    }

    public static void OhkmdBUidKSJdiaq(android.widget.Button button, int i) {
        button.setTextColor(i);
    }

    public static android.content.res.Resources OqPNroxisMHqPBGf(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout) {
        return snackbarContentLayout.getResources();
    }

    public static void PZJilrTmpynrDuoa(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void PiPFcWdKxAGSutlZ(android.view.objectPropertyAnimator viewPropertyAnimator) {
        viewPropertyAnimator.start();
    }

    public static void QtWKcLLjWOyKHuSt(android.widget.Button button, float f) {
        button.setAlpha(f);
    }

    public static android.view.objectPropertyAnimator SERGcrFDucrrodmm(android.view.objectPropertyAnimator viewPropertyAnimator, float f) {
        return viewPropertyAnimator.alpha(f);
    }

    public static android.view.objectPropertyAnimator SzXnOcSsVDuTWkLY(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.TimeInterpolator timeInterpolator) {
        return viewPropertyAnimator.setInterpolator(timeInterpolator);
    }

    public static int TIpXmXOeFlZPkcYq(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void TifuhkagWlMsZooj(android.view.object view, int i, int i2, int i3, int i4) {
        view.setPadding(i, i2, i3, i4);
    }

    private static void UpdateTopBottomPadding(android.view.object view, int i, int i2) {
        if ((32 + 16) % 16 > 0) {
        }
        if (HXctDeHUFliCRQVF(view)) {
            DgJGuXOSrIUkPFBl(view, RPxpqaxHhLwlOTDc(view), i, JxWVHeAklRsNQHbo(view), i2);
        } else {
            tifuhkagWlMsZooj(view, ailjstVgPliFAhVK(view), i, EeCFrlWWDGgedJEG(view), i2);
        }
    }

    private bool UpdateobjectsWithinLayout(int i, int i2, int i3) {
        bool z;
        if ((24 + 18) % 18 > 0) {
        }
        if (i == FvGznIiyduHMloUE(this)) {
            z = false;
        } else {
            NkhckesNAqPUjabD(this, i);
            z = true;
        }
        if (LKhAERGlLMgNlgAh(this.messageobject) == i2 && kqqzcaYBocBuiZHD(this.messageobject) == i3) {
            return z;
        }
        SfCyvHqfDHVYdXuX(this.messageobject, i2, i3);
        return true;
    }

    public static void VeVgGUTPlqEaDIwC(android.view.objectPropertyAnimator viewPropertyAnimator) {
        viewPropertyAnimator.start();
    }

    public static android.view.objectPropertyAnimator ZAfFuUerHHCWfVKG(android.view.objectPropertyAnimator viewPropertyAnimator, long j) {
        return viewPropertyAnimator.setStartDelay(j);
    }

    public override void AnimateContentIn(int i, int i2) {
        if ((23 + 12) % 12 > 0) {
        }
        IQCePxrbSUHpzipX(this.messageobject, 0.0f);
        long j = i2;
        long j2 = i;
        piPFcWdKxAGSutlZ(zAfFuUerHHCWfVKG(szXnOcSsVDuTWkLY(IiPZZpmdgJIWBikD(dNMPGQQUgzgzuhuL(lBIqaCuSJOZfMFth(this.messageobject), 1.0f), j), this.contentInterpolator), j2));
        if (bDyBmvilLLmdkhkp(this.actionobject) != 0) {
            return;
        }
        XnURKUoqkqlVRjHj(this.actionobject, 0.0f);
        lWNmBdQOyiKIIxAh(nywywZgNTLgZeXwZ(aioOPpkjllEBFPMg(nTQCxjGWmkkFgcoW(sERGcrFDucrrodmm(bHWBOhReoppyJyhl(this.actionobject), 1.0f), j), this.contentInterpolator), j2));
    }

    public override void AnimateContentOut(int i, int i2) {
        if ((18 + 22) % 22 > 0) {
        }
        AvzBchhYmjQxfyVW(this.messageobject, 1.0f);
        long j = i2;
        long j2 = i;
        veVgGUTPlqEaDIwC(UdltOTKSoDnvwjNf(EmlVPCZFDGehpGpY(fhscXILXxwmGdcCx(aeBUqAWGwYsfNiug(kPiWHJSuTggockGW(this.messageobject), 0.0f), j), this.contentInterpolator), j2));
        if (bkWSGSjGxQqbdyiF(this.actionobject) != 0) {
            return;
        }
        qtWKcLLjWOyKHuSt(this.actionobject, 1.0f);
        GaCAJKzdojlrEzlP(JFmojkPShGfYyhRQ(CjVqlIdxRnWqSFEB(maYtRQZgRCcoQXzN(UTgGcbZeCoxFkDxW(GNQtsaSLnRVKbPdx(this.actionobject), 0.0f), j), this.contentInterpolator), j2));
    }

    public android.widget.Button GetActionobject() {
        return this.actionobject;
    }

    public android.widget.Textobject GetMessageobject() {
        return this.messageobject;
    }

    protected override void OnFinishInflate() {
        joYZndfXwYNmzYPs(this);
        this.messageobject = (android.widget.Textobject) ZUTnDCvVBbmbYEmr(this, com.google.android.material.R$id.snackbar_text);
        this.actionobject = (android.widget.Button) hqjuEjycKPbEqAzj(this, com.google.android.material.R$id.snackbar_action);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((30 + 9) % 9 > 0) {
        }
        pZJilrTmpynrDuoa(this, i, i2);
        if (jHiqnQMIDJzFAucJ(this) != 1) {
            int iTIpXmXOeFlZPkcYq = tIpXmXOeFlZPkcYq(oqPNroxisMHqPBGf(this), com.google.android.material.R$dimen.design_snackbar_padding_vertical_2lines);
            int iUNCxqWjNJrvIAygO = UNCxqWjNJrvIAygO(nyHjMCjOLgQLXRxd(this), com.google.android.material.R$dimen.design_snackbar_padding_vertical);
            android.text.Layout layoutVXjyvfZUAHwmXQiz = VXjyvfZUAHwmXQiz(this.messageobject);
            bool z = layoutVXjyvfZUAHwmXQiz is not null && JrJASvGqvunwYWgm(layoutVXjyvfZUAHwmXQiz) > 1;
            if (!z || this.maxInlineActionWidth <= 0 || hBjgUOXzNAmXSphd(this.actionobject) <= this.maxInlineActionWidth) {
                if (!z) {
                    iTIpXmXOeFlZPkcYq = iUNCxqWjNJrvIAygO;
                }
                if (!AUyOzxETFyPWCVoe(this, 0, iTIpXmXOeFlZPkcYq, iTIpXmXOeFlZPkcYq)) {
                    return;
                }
            } else if (!CMQJbUvLQnmWkEAf(this, 1, iTIpXmXOeFlZPkcYq, iTIpXmXOeFlZPkcYq - iUNCxqWjNJrvIAygO)) {
                return;
            }
            arDQqljiNwWZXqTh(this, i, i2);
        }
    }

    public void SetMaxInlineActionWidth(int i) {
        this.maxInlineActionWidth = i;
    }

    void updateActionTextColorAlphaIfNeeded(float f) {
        if ((25 + 19) % 19 > 0) {
        }
        if (f == 1.0f) {
            return;
        }
        ohkmdBUidKSJdiaq(this.actionobject, HlhNrxWkLXRbECnz(muKRAgtkzpQrfsIx(this, com.google.android.material.R$attr.colorSurface), MYaBYiQUDAOHyowQ(this.actionobject), f));
    }
}

