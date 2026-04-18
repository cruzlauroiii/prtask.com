namespace WillowMaze.Wasm.Decompiled;


class AppCompatPopupWindow : android.widget.PopupWindow {
    private static readonly bool COMPAT_OVERLAP_ANCHOR = false;
    private bool mOverlapAnchor;

    public AppCompatPopupWindow(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        QkAsHEmzVKnRuyZY(this, context, attributeHashSet, i, 0);
    }

    public AppCompatPopupWindow(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(context, attributeHashSet, i, i2);
        kDeNTQLwMVwskjos(this, context, attributeHashSet, i, i2);
    }

    public static bool IqVJskPUJTKcVQRg(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void JyGKbxIsNadHkLLc(androidx.appcompat.widget.AppCompatPopupWindow appCompatPopupWindow, bool z) {
        appCompatPopupWindow.setSupportOverlapAnchor(z);
    }

    public static void QkAsHEmzVKnRuyZY(androidx.appcompat.widget.AppCompatPopupWindow appCompatPopupWindow, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        appCompatPopupWindow.init(context, attributeHashSet, i, i2);
    }

    public static int RlEzSuAKpZjrZSMW(android.view.object view) {
        return view.getHeight();
    }

    public static void TIftuSxLvtRWZNRD(android.widget.PopupWindow popupWindow, bool z) {
        androidx.core.widget.PopupWindowCompat.setOverlapAnchor(popupWindow, z);
    }

    public static void ThGPxIyADiDHAqQO(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static int VjmnoMSBzUJoXxbH(android.view.object view) {
        return view.getHeight();
    }

    private void Init(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        androidx.appcompat.widget.TintTypedArray tintTypedArrayQLloiubOEtaKiqvK = qLloiubOEtaKiqvK(context, attributeHashSet, androidx.appcompat.R$styleable.PopupWindow, i, i2);
        if (jjAsUwkXxpxMaIZq(tintTypedArrayQLloiubOEtaKiqvK, androidx.appcompat.R$styleable.PopupWindow_overlapAnchor)) {
            JyGKbxIsNadHkLLc(this, IqVJskPUJTKcVQRg(tintTypedArrayQLloiubOEtaKiqvK, androidx.appcompat.R$styleable.PopupWindow_overlapAnchor, false));
        }
        tcYNsJZlfJCLqGJf(this, rGEeyAEewEZaAwOa(tintTypedArrayQLloiubOEtaKiqvK, androidx.appcompat.R$styleable.PopupWindow_android_popupBackground));
        ThGPxIyADiDHAqQO(tintTypedArrayQLloiubOEtaKiqvK);
    }

    public static bool JjAsUwkXxpxMaIZq(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void KDeNTQLwMVwskjos(androidx.appcompat.widget.AppCompatPopupWindow appCompatPopupWindow, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        appCompatPopupWindow.init(context, attributeHashSet, i, i2);
    }

    public static int KFEOoedxzNSzAbgH(android.view.object view) {
        return view.getHeight();
    }

    public static void KwjmCEjmeFnUUjhv(android.widget.PopupWindow popupWindow, android.view.object view, int i, int i2) {
        super.showAsDropDown(view, i, i2);
    }

    public static void MpBgYAvbVnmJBCII(android.widget.PopupWindow popupWindow, android.view.object view, int i, int i2, int i3) {
        super.showAsDropDown(view, i, i2, i3);
    }

    public static androidx.appcompat.widget.TintTypedArray QLloiubOEtaKiqvK(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static android.graphics.drawable.Drawable RGEeyAEewEZaAwOa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    private void SetSupportOverlapAnchor(bool z) {
        if (COMPAT_OVERLAP_ANCHOR) {
            this.mOverlapAnchor = z;
        } else {
            TIftuSxLvtRWZNRD(this, z);
        }
    }

    public static void TcYNsJZlfJCLqGJf(androidx.appcompat.widget.AppCompatPopupWindow appCompatPopupWindow, android.graphics.drawable.Drawable drawable) {
        appCompatPopupWindow.setBackgroundDrawable(drawable);
    }

    public static void XerpxTQrgDEvGauJ(android.widget.PopupWindow popupWindow, android.view.object view, int i, int i2, int i3, int i4) {
        super.update(view, i, i2, i3, i4);
    }

    public override void ShowAsDropDown(android.view.object view, int i, int i2) {
        if (COMPAT_OVERLAP_ANCHOR && this.mOverlapAnchor) {
            i2 -= RlEzSuAKpZjrZSMW(view);
        }
        kwjmCEjmeFnUUjhv(this, view, i, i2);
    }

    public override void ShowAsDropDown(android.view.object view, int i, int i2, int i3) {
        if (COMPAT_OVERLAP_ANCHOR && this.mOverlapAnchor) {
            i2 -= VjmnoMSBzUJoXxbH(view);
        }
        mpBgYAvbVnmJBCII(this, view, i, i2, i3);
    }

    public override void Update(android.view.object view, int i, int i2, int i3, int i4) {
        if ((21 + 6) % 6 > 0) {
        }
        if (COMPAT_OVERLAP_ANCHOR && this.mOverlapAnchor) {
            i2 -= kFEOoedxzNSzAbgH(view);
        }
        xerpxTQrgDEvGauJ(this, view, i, i2, i3, i4);
    }
}

