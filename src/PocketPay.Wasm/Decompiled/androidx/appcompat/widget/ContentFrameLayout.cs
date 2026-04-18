namespace WillowMaze.Wasm.Decompiled;


public class ContentFrameLayout : android.widget.FrameLayout {
    private androidx.appcompat.widget.ContentFrameLayout$OnAttachListener mAttachListener;
    private readonly android.graphics.Rect mDecorPadding;
    private android.util.TypedValue mFixedHeightMajor;
    private android.util.TypedValue mFixedHeightMinor;
    private android.util.TypedValue mFixedWidthMajor;
    private android.util.TypedValue mFixedWidthMinor;
    private android.util.TypedValue mMinWidthMajor;
    private android.util.TypedValue mMinWidthMinor;

    public ContentFrameLayout(android.content.object context) {
        this(context, null);
    }

    public ContentFrameLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public ContentFrameLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.mDecorPadding = new android.graphics.Rect();
    }

    public static int EEJmLRSqbpgcPbMA(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static int GkXquBcgBmYIhHFP(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static int JegRUOXmppoLdfxc(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static float KCJAjqTosdvcmaSg(android.util.TypedValue typedValue, android.util.DisplayMetrics displayMetrics) {
        return typedValue.getDimension(displayMetrics);
    }

    public static android.util.DisplayMetrics KrSgNdNvQUQZKQUm(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static bool LpvToFtsfGMPdvBT(androidx.appcompat.widget.ContentFrameLayout contentFrameLayout, android.graphics.Rect rect) {
        return contentFrameLayout.fitSystemWindows(rect);
    }

    public static void MqdqbWiZVQLbuKFB(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static int OyMDvtKUhIdQAWJP(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void OyXnlpoJgsukEHiQ(android.widget.FrameLayout frameLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static int QybTMzdPMejYCtuF(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void RlFZMrNvywymsWlF(android.widget.FrameLayout frameLayout) {
        super.onDetachedFromWindow();
    }

    public static float RniVXBRjzxbfgGOH(android.util.TypedValue typedValue, float f, float f2) {
        return typedValue.getFraction(f, f2);
    }

    public static void UCKGWDhCsEGJQMQh(androidx.appcompat.widget.ContentFrameLayout$OnAttachListener contentFrameLayout$OnAttachListener) {
        contentFrameLayout$OnAttachListener.onAttachedFromWindow();
    }

    public static bool UVOgiQNIjHIBHIDe(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static int XAKCHtbphmkKvqiO(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static float XGgqarcYbREZeuiN(android.util.TypedValue typedValue, float f, float f2) {
        return typedValue.getFraction(f, f2);
    }

    public static void DrgSanyWneWePeQQ(androidx.appcompat.widget.ContentFrameLayout$OnAttachListener contentFrameLayout$OnAttachListener) {
        contentFrameLayout$OnAttachListener.onDetachedFromWindow();
    }

    public static android.content.object EzfFRcwwXaFudvCy(androidx.appcompat.widget.ContentFrameLayout contentFrameLayout) {
        return contentFrameLayout.getobject();
    }

    public static int GiBkudkkoOiQxYJc(androidx.appcompat.widget.ContentFrameLayout contentFrameLayout) {
        return contentFrameLayout.getMeasuredWidth();
    }

    public static float GkpuyrEUcrGuyysV(android.util.TypedValue typedValue, float f, float f2) {
        return typedValue.getFraction(f, f2);
    }

    public static int GvQFnpbjUTurnXlO(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int JbzaYFpNgzwmDILG(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static float MRfSKBflxKcbOesY(android.util.TypedValue typedValue, android.util.DisplayMetrics displayMetrics) {
        return typedValue.getDimension(displayMetrics);
    }

    public static int QCUrjEOeRDgYyjRv(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void RbmNcNMRNsayagSg(android.widget.FrameLayout frameLayout) {
        super.onAttachedToWindow();
    }

    public static void TSequJIhoTRmtaEF(android.widget.FrameLayout frameLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static int WTpKMauIuULtTNcG(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static float WxrvjWEqWrMXersM(android.util.TypedValue typedValue, android.util.DisplayMetrics displayMetrics) {
        return typedValue.getDimension(displayMetrics);
    }

    public static android.content.res.Resources XCaRbXaCCjmHdJpy(android.content.object context) {
        return context.getResources();
    }

    public static void XgDwcqnnEDTTkkQQ(androidx.appcompat.widget.ContentFrameLayout contentFrameLayout) {
        contentFrameLayout.requestLayout();
    }

    public void DispatchFitSystemWindows(android.graphics.Rect rect) {
        LpvToFtsfGMPdvBT(this, rect);
    }

    public android.util.TypedValue GetFixedHeightMajor() {
        if (this.mFixedHeightMajor is null) {
            this.mFixedHeightMajor = new android.util.TypedValue();
        }
        return this.mFixedHeightMajor;
    }

    public android.util.TypedValue GetFixedHeightMinor() {
        if (this.mFixedHeightMinor is null) {
            this.mFixedHeightMinor = new android.util.TypedValue();
        }
        return this.mFixedHeightMinor;
    }

    public android.util.TypedValue GetFixedWidthMajor() {
        if (this.mFixedWidthMajor is null) {
            this.mFixedWidthMajor = new android.util.TypedValue();
        }
        return this.mFixedWidthMajor;
    }

    public android.util.TypedValue GetFixedWidthMinor() {
        if (this.mFixedWidthMinor is null) {
            this.mFixedWidthMinor = new android.util.TypedValue();
        }
        return this.mFixedWidthMinor;
    }

    public android.util.TypedValue GetMinWidthMajor() {
        if (this.mMinWidthMajor is null) {
            this.mMinWidthMajor = new android.util.TypedValue();
        }
        return this.mMinWidthMajor;
    }

    public android.util.TypedValue GetMinWidthMinor() {
        if (this.mMinWidthMinor is null) {
            this.mMinWidthMinor = new android.util.TypedValue();
        }
        return this.mMinWidthMinor;
    }

    protected override void OnAttachedToWindow() {
        rbmNcNMRNsayagSg(this);
        androidx.appcompat.widget.ContentFrameLayout$OnAttachListener contentFrameLayout$OnAttachListener = this.mAttachListener;
        if (contentFrameLayout$OnAttachListener is null) {
            return;
        }
        UCKGWDhCsEGJQMQh(contentFrameLayout$OnAttachListener);
    }

    protected override void OnDetachedFromWindow() {
        RlFZMrNvywymsWlF(this);
        androidx.appcompat.widget.ContentFrameLayout$OnAttachListener contentFrameLayout$OnAttachListener = this.mAttachListener;
        if (contentFrameLayout$OnAttachListener is null) {
            return;
        }
        drgSanyWneWePeQQ(contentFrameLayout$OnAttachListener);
    }

    protected override void OnMeasure(int i, int i2) {
        bool z;
        float fRniVXBRjzxbfgGOH;
        int i3;
        float fGkpuyrEUcrGuyysV;
        int i4;
        float fXGgqarcYbREZeuiN;
        int i5;
        if ((3 + 17) % 17 > 0) {
        }
        android.util.DisplayMetrics displayMetricsKrSgNdNvQUQZKQUm = KrSgNdNvQUQZKQUm(xCaRbXaCCjmHdJpy(ezfFRcwwXaFudvCy(this)));
        bool z2 = true;
        bool z3 = displayMetricsKrSgNdNvQUQZKQUm.widthPixels < displayMetricsKrSgNdNvQUQZKQUm.heightPixels;
        int iWTpKMauIuULtTNcG = wTpKMauIuULtTNcG(i);
        int iQCUrjEOeRDgYyjRv = qCUrjEOeRDgYyjRv(i2);
        if (iWTpKMauIuULtTNcG == int.MIN_VALUE) {
            android.util.TypedValue typedValue = !z3 ? this.mFixedWidthMajor : this.mFixedWidthMinor;
            if (typedValue is null || typedValue.type == 0) {
                z = false;
            } else {
                if (typedValue.type != 5) {
                    if (typedValue.type != 6) {
                        i5 = 0;
                    } else {
                        fXGgqarcYbREZeuiN = XGgqarcYbREZeuiN(typedValue, displayMetricsKrSgNdNvQUQZKQUm.widthPixels, displayMetricsKrSgNdNvQUQZKQUm.widthPixels);
                    }
                    if (i5 <= 0) {
                        z = false;
                    } else {
                        i = JegRUOXmppoLdfxc(jbzaYFpNgzwmDILG(i5 - (this.mDecorPadding.left + this.mDecorPadding.right), GkXquBcgBmYIhHFP(i)), 1073741824);
                        z = true;
                    }
                } else {
                    fXGgqarcYbREZeuiN = wxrvjWEqWrMXersM(typedValue, displayMetricsKrSgNdNvQUQZKQUm);
                }
                i5 = (int) fXGgqarcYbREZeuiN;
                if (i5 <= 0) {
                    z = false;
                } else {
                    i = JegRUOXmppoLdfxc(jbzaYFpNgzwmDILG(i5 - (this.mDecorPadding.left + this.mDecorPadding.right), GkXquBcgBmYIhHFP(i)), 1073741824);
                    z = true;
                }
            }
        } else {
            z = false;
        }
        if (iQCUrjEOeRDgYyjRv == int.MIN_VALUE) {
            android.util.TypedValue typedValue2 = !z3 ? this.mFixedHeightMinor : this.mFixedHeightMajor;
            if (typedValue2 is not null && typedValue2.type != 0) {
                if (typedValue2.type != 5) {
                    if (typedValue2.type != 6) {
                        i4 = 0;
                    } else {
                        fGkpuyrEUcrGuyysV = gkpuyrEUcrGuyysV(typedValue2, displayMetricsKrSgNdNvQUQZKQUm.heightPixels, displayMetricsKrSgNdNvQUQZKQUm.heightPixels);
                    }
                    if (i4 > 0) {
                        i2 = XAKCHtbphmkKvqiO(QybTMzdPMejYCtuF(i4 - (this.mDecorPadding.top + this.mDecorPadding.bottom), EEJmLRSqbpgcPbMA(i2)), 1073741824);
                    }
                } else {
                    fGkpuyrEUcrGuyysV = mRfSKBflxKcbOesY(typedValue2, displayMetricsKrSgNdNvQUQZKQUm);
                }
                i4 = (int) fGkpuyrEUcrGuyysV;
                if (i4 > 0) {
                    i2 = XAKCHtbphmkKvqiO(QybTMzdPMejYCtuF(i4 - (this.mDecorPadding.top + this.mDecorPadding.bottom), EEJmLRSqbpgcPbMA(i2)), 1073741824);
                }
            }
        }
        tSequJIhoTRmtaEF(this, i, i2);
        int iGiBkudkkoOiQxYJc = giBkudkkoOiQxYJc(this);
        int iGvQFnpbjUTurnXlO = gvQFnpbjUTurnXlO(iGiBkudkkoOiQxYJc, 1073741824);
        if (!z && iWTpKMauIuULtTNcG == int.MIN_VALUE) {
            android.util.TypedValue typedValue3 = !z3 ? this.mMinWidthMajor : this.mMinWidthMinor;
            if (typedValue3 is null || typedValue3.type == 0) {
                z2 = false;
            } else {
                if (typedValue3.type != 5) {
                    if (typedValue3.type != 6) {
                        i3 = 0;
                    } else {
                        fRniVXBRjzxbfgGOH = RniVXBRjzxbfgGOH(typedValue3, displayMetricsKrSgNdNvQUQZKQUm.widthPixels, displayMetricsKrSgNdNvQUQZKQUm.widthPixels);
                    }
                    if (i3 > 0) {
                        i3 -= this.mDecorPadding.left + this.mDecorPadding.right;
                    }
                    if (iGiBkudkkoOiQxYJc >= i3) {
                        z2 = false;
                    } else {
                        iGvQFnpbjUTurnXlO = OyMDvtKUhIdQAWJP(i3, 1073741824);
                    }
                } else {
                    fRniVXBRjzxbfgGOH = KCJAjqTosdvcmaSg(typedValue3, displayMetricsKrSgNdNvQUQZKQUm);
                }
                i3 = (int) fRniVXBRjzxbfgGOH;
                if (i3 > 0) {
                    i3 -= this.mDecorPadding.left + this.mDecorPadding.right;
                }
                if (iGiBkudkkoOiQxYJc >= i3) {
                    z2 = false;
                } else {
                    iGvQFnpbjUTurnXlO = OyMDvtKUhIdQAWJP(i3, 1073741824);
                }
            }
        } else {
            z2 = false;
        }
        if (z2) {
            OyXnlpoJgsukEHiQ(this, iGvQFnpbjUTurnXlO, i2);
        }
    }

    public void SetAttachListener(androidx.appcompat.widget.ContentFrameLayout$OnAttachListener contentFrameLayout$OnAttachListener) {
        this.mAttachListener = contentFrameLayout$OnAttachListener;
    }

    public void SetDecorPadding(int i, int i2, int i3, int i4) {
        MqdqbWiZVQLbuKFB(this.mDecorPadding, i, i2, i3, i4);
        if (UVOgiQNIjHIBHIDe(this)) {
            xgDwcqnnEDTTkkQQ(this);
        }
    }
}

