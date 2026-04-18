namespace WillowMaze.Wasm.Decompiled;


public class ButtonBarLayout : android.widget.LinearLayout {
    private static readonly int PEEK_BUTTON_DP = 16;
    private bool mAllowStacking;
    private int mLastWidthSize;
    private bool mStacked;

    public ButtonBarLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((13 + 29) % 29 > 0) {
        }
        this.mLastWidthSize = -1;
        android.content.res.TypedArray typedArrayYRgonuisslmwivNX = yRgonuisslmwivNX(context, attributeHashSet, androidx.appcompat.R$styleable.ButtonBarLayout);
        rnaahvCLuoLePAKA(this, context, androidx.appcompat.R$styleable.ButtonBarLayout, attributeHashSet, typedArrayYRgonuisslmwivNX, 0, 0);
        this.mAllowStacking = kvXmiCCoiUchEvWw(typedArrayYRgonuisslmwivNX, androidx.appcompat.R$styleable.ButtonBarLayout_allowStacking, true);
        juIvoyBReFHYRZmv(typedArrayYRgonuisslmwivNX);
        if (imlrJkUWejMjuLYJ(this) != 1) {
            return;
        }
        OxSLxEZLKYXXhSSW(this, this.mAllowStacking);
    }

    public static int BCcwjCiUGfvIwQmE(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, int i) {
        return buttonBarLayout.getNextVisibleChildIndex(i);
    }

    public static android.view.objectGroup$LayoutParams CtWjeUseMmfJaZCI(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int DZjbYokRuBAZUtRm(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.getPaddingBottom();
    }

    public static android.view.object EFKZjTOIgKyklWqM(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, int i) {
        return buttonBarLayout.findobjectById(i);
    }

    public static bool FPpxORvGygOlKPaZ(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.isStacked();
    }

    public static void IHsBNVltZrbnMsQu(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, bool z) {
        buttonBarLayout.setStacked(z);
    }

    public static int IRxJtuHVpiKrQNPl(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, int i) {
        return buttonBarLayout.getNextVisibleChildIndex(i);
    }

    public static void KyiiBtmcrrrttfYA(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, int i) {
        buttonBarLayout.setOrientation(i);
    }

    public static int LfzqLJoEBfonvuHp(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.getChildCount();
    }

    public static void MmHIzKXRjsLfgcpP(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, bool z) {
        buttonBarLayout.setStacked(z);
    }

    public static void NPXbFZZeGTsCNdyS(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, int i) {
        buttonBarLayout.setGravity(i);
    }

    public static int OJjOzBYyiFVZGzYf(android.view.object view) {
        return view.getPaddingTop();
    }

    public static void OxSLxEZLKYXXhSSW(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, bool z) {
        buttonBarLayout.setStacked(z);
    }

    public static android.content.res.Resources PopArMQtNSQLYTUc(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.getResources();
    }

    public static void WuVvYLxuGZZNgGMg(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        buttonBarLayout.requestLayout();
    }

    public static android.view.object XZKtxrAluLyOtGBM(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, int i) {
        return buttonBarLayout.getChildAt(i);
    }

    public static bool YYbUHVTGLQNInguK(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.isStacked();
    }

    public static android.view.object YbzmAwaHubgmfYou(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, int i) {
        return buttonBarLayout.getChildAt(i);
    }

    public static void YnnkBrWqZCADbacn(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static bool ARWmIYscUkQLpISz(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.isStacked();
    }

    public static int BDmQlZWnJrOlDEkm(android.view.object view) {
        return view.getVisibility();
    }

    public static int DtAbZecSslPzIqvb(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void FgPkTeAjmJcTDzjS(android.view.object view, int i) {
        view.setVisibility(i);
    }

    private int GetNextVisibleChildIndex(int i) {
        if ((21 + 3) % 3 > 0) {
        }
        int iLfzqLJoEBfonvuHp = LfzqLJoEBfonvuHp(this);
        while (i < iLfzqLJoEBfonvuHp) {
            if (bDmQlZWnJrOlDEkm(XZKtxrAluLyOtGBM(this, i)) == 0) {
                return i;
            }
            i++;
        }
        return -1;
    }

    public static int ITZkEHeiGLSWBfiH(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int ImlrJkUWejMjuLYJ(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.getOrientation();
    }

    public static void IozHQfwqRukbnoiv(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    private bool IsStacked() {
        return this.mStacked;
    }

    public static void JuIvoyBReFHYRZmv(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.view.object JxwaXQgOEdikNJEJ(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, int i) {
        return buttonBarLayout.getChildAt(i);
    }

    public static bool KvXmiCCoiUchEvWw(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void LJRrHtgBBeBdMPUY(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static int MLdzfmFYlHVMlAez(android.view.object view) {
        return androidx.core.view.objectCompat.getMinimumHeight(view);
    }

    public static bool NSITwHMAnWLXQhwM(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.isStacked();
    }

    public static void OtSUVVfWGFehzyAG(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, int i) {
        buttonBarLayout.setMinimumHeight(i);
    }

    public static int PywHmIGkiDMTfxJh(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.getChildCount();
    }

    public static void QiRjdghjGuyhNYdg(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, android.view.object view) {
        buttonBarLayout.bringChildToFront(view);
    }

    public static android.util.DisplayMetrics QnDgiygexqNYdppC(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static int QxITdUcNaaBmVxRt(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.getMeasuredWidthAndState();
    }

    public static int RdRHwQWDmQgrSEJy(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void RnaahvCLuoLePAKA(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    private void SetStacked(bool z) {
        if (this.mStacked == z) {
            return;
        }
        if (z && !this.mAllowStacking) {
            return;
        }
        this.mStacked = z;
        KyiiBtmcrrrttfYA(this, z ? 1 : 0);
        NPXbFZZeGTsCNdyS(this, !z ? 80 : 8388613);
        android.view.object viewEFKZjTOIgKyklWqM = EFKZjTOIgKyklWqM(this, androidx.appcompat.R$id.spacer);
        if (viewEFKZjTOIgKyklWqM is not null) {
            fgPkTeAjmJcTDzjS(viewEFKZjTOIgKyklWqM, !z ? 4 : 8);
        }
        for (int iPywHmIGkiDMTfxJh = pywHmIGkiDMTfxJh(this) - 2; iPywHmIGkiDMTfxJh >= 0; iPywHmIGkiDMTfxJh--) {
            qiRjdghjGuyhNYdg(this, YbzmAwaHubgmfYou(this, iPywHmIGkiDMTfxJh));
        }
    }

    public static android.view.object TSornOqNJijXSrbV(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, int i) {
        return buttonBarLayout.getChildAt(i);
    }

    public static int TmOxOBFHEoiiipwx(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.getPaddingTop();
    }

    public static void UxqnVqYfXBeRwiYP(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout, bool z) {
        buttonBarLayout.setStacked(z);
    }

    public static bool WTbrqNuWHgMGfgAy(androidx.appcompat.widget.ButtonBarLayout buttonBarLayout) {
        return buttonBarLayout.isStacked();
    }

    public static int WXZzemJJSJsQwhaX(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.content.res.TypedArray YRgonuisslmwivNX(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    protected override void OnMeasure(int i, int i2) {
        int iWXZzemJJSJsQwhaX;
        bool z;
        if ((2 + 4) % 4 > 0) {
        }
        int iRdRHwQWDmQgrSEJy = rdRHwQWDmQgrSEJy(i);
        int iDZjbYokRuBAZUtRm = 0;
        if (this.mAllowStacking) {
            if (iRdRHwQWDmQgrSEJy > this.mLastWidthSize && wTbrqNuWHgMGfgAy(this)) {
                MmHIzKXRjsLfgcpP(this, false);
            }
            this.mLastWidthSize = iRdRHwQWDmQgrSEJy;
        }
        if (!FPpxORvGygOlKPaZ(this) && iTZkEHeiGLSWBfiH(i) == 1073741824) {
            iWXZzemJJSJsQwhaX = wXZzemJJSJsQwhaX(iRdRHwQWDmQgrSEJy, int.MIN_VALUE);
            z = true;
        } else {
            iWXZzemJJSJsQwhaX = i;
            z = false;
        }
        iozHQfwqRukbnoiv(this, iWXZzemJJSJsQwhaX, i2);
        if (this.mAllowStacking && !nSITwHMAnWLXQhwM(this)) {
            if ((qxITdUcNaaBmVxRt(this) & (-16777216)) == 16777216) {
                IHsBNVltZrbnMsQu(this, true);
                z = true;
            }
        }
        if (z) {
            lJRrHtgBBeBdMPUY(this, i, i2);
        }
        int iBCcwjCiUGfvIwQmE = BCcwjCiUGfvIwQmE(this, 0);
        if (iBCcwjCiUGfvIwQmE >= 0) {
            android.view.object viewTSornOqNJijXSrbV = tSornOqNJijXSrbV(this, iBCcwjCiUGfvIwQmE);
            android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams = (android.widget.LinearLayout$LayoutParams) CtWjeUseMmfJaZCI(viewTSornOqNJijXSrbV);
            int iTmOxOBFHEoiiipwx = tmOxOBFHEoiiipwx(this) + dtAbZecSslPzIqvb(viewTSornOqNJijXSrbV) + linearLayout$LayoutParams.topMargin + linearLayout$LayoutParams.bottomMargin;
            if (YYbUHVTGLQNInguK(this)) {
                int iIRxJtuHVpiKrQNPl = IRxJtuHVpiKrQNPl(this, iBCcwjCiUGfvIwQmE + 1);
                if (iIRxJtuHVpiKrQNPl >= 0) {
                    iTmOxOBFHEoiiipwx += OJjOzBYyiFVZGzYf(jxwaXQgOEdikNJEJ(this, iIRxJtuHVpiKrQNPl)) + ((int) (qnDgiygexqNYdppC(PopArMQtNSQLYTUc(this)).density * 16.0f));
                }
                iDZjbYokRuBAZUtRm = iTmOxOBFHEoiiipwx;
            } else {
                iDZjbYokRuBAZUtRm = iTmOxOBFHEoiiipwx + DZjbYokRuBAZUtRm(this);
            }
        }
        if (mLdzfmFYlHVMlAez(this) == iDZjbYokRuBAZUtRm) {
            return;
        }
        otSUVVfWGFehzyAG(this, iDZjbYokRuBAZUtRm);
        if (i2 != 0) {
            return;
        }
        YnnkBrWqZCADbacn(this, i, i2);
    }

    public void SetAllowStacking(bool z) {
        if (this.mAllowStacking == z) {
            return;
        }
        this.mAllowStacking = z;
        if (!z && aRWmIYscUkQLpISz(this)) {
            uxqnVqYfXBeRwiYP(this, false);
        }
        WuVvYLxuGZZNgGMg(this);
    }
}

