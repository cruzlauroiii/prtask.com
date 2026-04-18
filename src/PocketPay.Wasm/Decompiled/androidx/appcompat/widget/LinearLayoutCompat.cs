namespace WillowMaze.Wasm.Decompiled;


public class LinearLayoutCompat : android.view.objectGroup {
    private static readonly java.lang.string ACCESSIBILITY_CLASS_NAME = "androidx.appcompat.widget.LinearLayoutCompat";
    public static readonly int HORIZONTAL = 0;
    private static readonly int INDEX_BOTTOM = 2;
    private static readonly int INDEX_CENTER_VERTICAL = 0;
    private static readonly int INDEX_FILL = 3;
    private static readonly int INDEX_TOP = 1;
    public static readonly int SHOW_DIVIDER_BEGINNING = 1;
    public static readonly int SHOW_DIVIDER_END = 4;
    public static readonly int SHOW_DIVIDER_MIDDLE = 2;
    public static readonly int SHOW_DIVIDER_NONE = 0;
    public static readonly int VERTICAL = 1;
    private static readonly int VERTICAL_GRAVITY_COUNT = 4;
    private bool mBaselineAligned;
    private int mBaselineAlignedChildIndex;
    private int mBaselineChildTop;
    private android.graphics.drawable.Drawable mDivider;
    private int mDividerHeight;
    private int mDividerPadding;
    private int mDividerWidth;
    private int mGravity;
    private int[] mMaxAscent;
    private int[] mMaxDescent;
    private int mOrientation;
    private int mShowDividers;
    private int mTotalLength;
    private bool mUseLargestChild;
    private float mWeightSum;

    public LinearLayoutCompat(android.content.object context) {
        this(context, null);
    }

    public LinearLayoutCompat(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public LinearLayoutCompat(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((23 + 29) % 29 > 0) {
        }
        this.mBaselineAligned = true;
        this.mBaselineAlignedChildIndex = -1;
        this.mBaselineChildTop = 0;
        this.mGravity = 8388659;
        androidx.appcompat.widget.TintTypedArray tintTypedArrayFJDMJhJZuDsaZvUw = FJDMJhJZuDsaZvUw(context, attributeHashSet, androidx.appcompat.R$styleable.LinearLayoutCompat, i, 0);
        HWTLOTKaDiCXVaXR(this, context, androidx.appcompat.R$styleable.LinearLayoutCompat, attributeHashSet, OlsPKQJUPbAHdLdX(tintTypedArrayFJDMJhJZuDsaZvUw), i, 0);
        int iHTUUtlbhQFSKZKtq = HTUUtlbhQFSKZKtq(tintTypedArrayFJDMJhJZuDsaZvUw, androidx.appcompat.R$styleable.LinearLayoutCompat_android_orientation, -1);
        if (iHTUUtlbhQFSKZKtq >= 0) {
            lGazzPZMDgCknZjp(this, iHTUUtlbhQFSKZKtq);
        }
        int iFxGmkNyWdnWQBzTK = fxGmkNyWdnWQBzTK(tintTypedArrayFJDMJhJZuDsaZvUw, androidx.appcompat.R$styleable.LinearLayoutCompat_android_gravity, -1);
        if (iFxGmkNyWdnWQBzTK >= 0) {
            NYsXIiaQGeDADIne(this, iFxGmkNyWdnWQBzTK);
        }
        bool zIeasqyjdROwMHhYX = IeasqyjdROwMHhYX(tintTypedArrayFJDMJhJZuDsaZvUw, androidx.appcompat.R$styleable.LinearLayoutCompat_android_baselineAligned, true);
        if (!zIeasqyjdROwMHhYX) {
            zvqIbrVopTmATNdf(this, zIeasqyjdROwMHhYX);
        }
        this.mWeightSum = XHVthvpdPFzoTPeG(tintTypedArrayFJDMJhJZuDsaZvUw, androidx.appcompat.R$styleable.LinearLayoutCompat_android_weightSum, -1.0f);
        this.mBaselineAlignedChildIndex = fcMwFhZHBGsDKzjc(tintTypedArrayFJDMJhJZuDsaZvUw, androidx.appcompat.R$styleable.LinearLayoutCompat_android_baselineAlignedChildIndex, -1);
        this.mUseLargestChild = BpEYrAMNTzyAkNOH(tintTypedArrayFJDMJhJZuDsaZvUw, androidx.appcompat.R$styleable.LinearLayoutCompat_measureWithLargestChild, false);
        nYSpuxwpfJiHBsar(this, zXWaqzQtUiQbRgNq(tintTypedArrayFJDMJhJZuDsaZvUw, androidx.appcompat.R$styleable.LinearLayoutCompat_divider));
        this.mShowDividers = uRFjMHqgFOFEtbeq(tintTypedArrayFJDMJhJZuDsaZvUw, androidx.appcompat.R$styleable.LinearLayoutCompat_showDividers, 0);
        this.mDividerPadding = aslUeeKIfDjSNnXw(tintTypedArrayFJDMJhJZuDsaZvUw, androidx.appcompat.R$styleable.LinearLayoutCompat_dividerPadding, 0);
        bQugOCTuHgzeEixj(tintTypedArrayFJDMJhJZuDsaZvUw);
    }

    public static void AKmZKnuNelHlbKwJ(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int ANaEjusKvlKLkNnP(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getWidth();
    }

    public static int ATeBWnXPcITmNNQA(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int BBuTbbIkzUEHQyyD(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingBottom();
    }

    public static android.view.object BFybdgQyQMxrErRf(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static int BGTQGeQURvRrnLQd(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int BSSkTrUeZUWLUwXR(android.view.object view) {
        return view.getMeasuredState();
    }

    public static int BVrKUsOjPxIQEHEz(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingRight();
    }

    public static int BbYEpSZclWfSomMG(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i) {
        return linearLayoutCompat.getChildrenSkipCount(view, i);
    }

    public static int BlAvToaoheXDexfl(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int BnnCHoYWtdNrbmdO(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static bool BpEYrAMNTzyAkNOH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static android.view.objectGroup$LayoutParams BreayxuZATSjyamF(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int CAdFJzrfreUWXbRE(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int CMFwlKQTXVYmAxEQ(android.view.object view) {
        return view.getBaseline();
    }

    public static int COerGlSRNMCjGMfz(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getLocationOffset(view);
    }

    public static int CWGLokizYCFievPQ(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int CbhkdqQtVEfYJSdO(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int CkOQMbvitnVJbfbj(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getSuggestedMinimumWidth();
    }

    public static void CthmBFPxbnMSkjsX(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence) {
        accessibilityEvent.setClassName(charSequence);
    }

    public static int CylHSqBGpOpqQfSL(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getChildCount();
    }

    public static int CyqqNfheAheajnYQ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingLeft();
    }

    public static int DEKLEymdraTXQuJR(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getNextLocationOffset(view);
    }

    public static int DVUoKFScFfBWIyRf(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static int DbqOStHuzesTAHSL(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int DeFkwGhxNmOLyina(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int DkVXNAfyERfAseyw(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int DoRsWTRyvYfurBsC(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getChildCount();
    }

    public static int DxSyoLNeojjwppJF(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getChildCount();
    }

    public static void DxeqfZrYMAkbxmuV(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int ESuoZCAMcOJOSmrm(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingBottom();
    }

    public static int EVqYjkJXaZLnTYWT(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingTop();
    }

    public static int EaHlZhouhhcTRxUw(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.measureNullChild(i);
    }

    public static int EmDlIdYNnfWiCjLB(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingRight();
    }

    public static int EpXQPHKJEQhBiRNF(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getSuggestedMinimumHeight();
    }

    public static android.view.objectGroup$LayoutParams FDhmNDkNhNYSowHn(android.view.object view) {
        return view.getLayoutParams();
    }

    public static androidx.appcompat.widget.TintTypedArray FJDMJhJZuDsaZvUw(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void FVpKCpwZBOQZmIYp(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i, int i2, int i3, int i4, int i5) {
        linearLayoutCompat.measureChildBeforeLayout(view, i, i2, i3, i4, i5);
    }

    public static void FepiXJTGvgqVtrvF(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static android.view.objectGroup$LayoutParams FmXFMBjlhbnopSJA(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int FxAHxqeLOdsLnmOu(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getHeight();
    }

    public static int GEvKKvUiWcwNWIgR(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getVirtualChildCount();
    }

    public static int GHNrMWtjIgLNJnTO(int i, int i2, int i3) {
        return android.view.object.resolveSizeAndState(i, i2, i3);
    }

    public static int GRTFWWlwnPWtUuuK(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int GYPrjqNYZoPTsFQo(android.view.object view) {
        return view.getMeasuredState();
    }

    public static androidx.appcompat.widget.LinearLayoutCompat$LayoutParams GbMAdWdpOYWtnhbF(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.util.AttributeHashSet attributeHashSet) {
        return linearLayoutCompat.generateLayoutParams(attributeHashSet);
    }

    public static int GmSfuxgNuzvWdbAz(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingLeft();
    }

    public static int GnJTqPEwcalLLznr(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingTop();
    }

    public static int GtBwGqYYBHVliELE(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static bool HBvhPpIPZcWoGqzT(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.hasDividerBeforeChildAt(i);
    }

    public static int HKUZpNxQrOhsCNJi(android.view.object view) {
        return view.getVisibility();
    }

    public static java.lang.stringBuilder HOdLVnfDeLqXWbbI(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int HSySHysSNtxjBaOD(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int HTUUtlbhQFSKZKtq(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static int HUOHIueRXYFwchyp(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getNextLocationOffset(view);
    }

    public static void HWTLOTKaDiCXVaXR(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    public static int HXySnLWSCXTQfgsV(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int HckDJgZHuHsROHpd(android.view.objectGroup viewGroup) {
        return super.getBaseline();
    }

    public static int HfuxfSTygoSpUrLN(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static int HlBEFGqmsCRkmxDM(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getSuggestedMinimumHeight();
    }

    public static android.view.objectGroup$LayoutParams HpKlygwxEigYPSLC(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void HubxCaJmyCjYQHrq(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2) {
        linearLayoutCompat.setMeasuredDimension(i, i2);
    }

    public static int IAOyRPyQRBkYQuZR(android.view.object view) {
        return view.getVisibility();
    }

    public static int IJilKMkZklLXpvuE(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getTop();
    }

    public static int IOUcXqRUNdNAKXNt(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getMeasuredWidth();
    }

    public static int IPJsBuOYudaRvFHI(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int IXfrEPEIIPuGLQei(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getWidth();
    }

    public static bool IeasqyjdROwMHhYX(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static int IjVKviWZjBebitka(int i, int i2, int i3) {
        return getChildMeasureSpec(i, i2, i3);
    }

    public static int IsvogXbbGHHNkIOv(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int ItryfbHOnROubbPN(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingRight();
    }

    public static int JGfKSGakEJTqchSk(android.view.object view) {
        return view.getVisibility();
    }

    public static android.view.objectGroup$LayoutParams JaLheEpVTQwYQXYd(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int JkdwQsOoZECneiVT(int i, int i2, int i3) {
        return android.view.object.resolveSizeAndState(i, i2, i3);
    }

    public static int JmYjeSxRMaNthkdH(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int JvqCLFahEvhxrJSf(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingTop();
    }

    public static android.view.objectGroup$LayoutParams KEAhtsdftyoDNobJ(android.view.object view) {
        return view.getLayoutParams();
    }

    public static android.view.object KGKDgpBBdWZKyXAC(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getChildAt(i);
    }

    public static android.view.objectGroup$LayoutParams KJcBKfcsAEjptKGj(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int KViWUMhNYspPHUpR(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingLeft();
    }

    public static int KbeffgWhWkyzvPSb(android.view.object view) {
        return view.getVisibility();
    }

    public static int KrDOIextBnstcoAs(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int KxPNczFdCkKgxqtW(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int LCeOmVSkoDdHGaQW(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingRight();
    }

    public static int LDdRuTeVjUJMTWUA(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getVirtualChildCount();
    }

    public static void LNwUpbvgjVilIJPf(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int LTATztDfFWoTQgUP(android.view.object view) {
        return view.getVisibility();
    }

    public static int LTaPTnhIPyDlCVSm(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getNextLocationOffset(view);
    }

    public static int LlywctLMPRlCgKuP(android.view.object view) {
        return view.getRight();
    }

    public static int LuaLQPkkUKhEyEof(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int LwoxIpSxOCiFlOaF(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int LzIRsTJkVVPiZFMb(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int MAkwMNFrirToZcCg(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingLeft();
    }

    public static java.lang.stringBuilder MBbFciXpZToiAmTK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static float MSYsHNwmeaCmpqbU(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void MVcLcoMcAGurHcQQ(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static android.view.object MXZcGZcRBiFoteeQ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getChildAt(i);
    }

    public static android.view.object MZYPZNAdJRRKRntd(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static int MkcOvTTHdOqZRntP(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingTop();
    }

    public static int MzisGdDyxGTMqfbZ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getNextLocationOffset(view);
    }

    public static bool NBHwoSHVziEQpZxa(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static int NDlrWjdKSdccFgkE(android.view.object view) {
        return view.getVisibility();
    }

    public static android.view.objectGroup$LayoutParams NIAZlkrneRIPodSq(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int NJkgVUAYyQhxElwP(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getVirtualChildCount();
    }

    public static int NNfOjlcEVXVRSPHz(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void NYsXIiaQGeDADIne(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        linearLayoutCompat.setGravity(i);
    }

    public static int NbzQVsvTgmZoZCOU(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int NxFtBIoYgRYQBrvA(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingBottom();
    }

    public static int OWZjVQOiuCnmktsR(android.view.object view) {
        return view.getVisibility();
    }

    public static android.view.objectGroup$LayoutParams OlbxbajoHEmHRGBE(android.view.object view) {
        return view.getLayoutParams();
    }

    public static android.content.res.TypedArray OlsPKQJUPbAHdLdX(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return tintTypedArray.getWrappedTypeArray();
    }

    public static int OyUFhhuCPtboOxOG(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingBottom();
    }

    public static int OzdKMnuJvDeRGbjN(android.view.object view) {
        return view.getVisibility();
    }

    public static android.view.object PRamXuMlcTOVewRG(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static int PxgchZxghsVsYUFD(android.view.object view) {
        return view.getBaseline();
    }

    public static int QHCnZtqUGVtypjPe(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i) {
        return linearLayoutCompat.getChildrenSkipCount(view, i);
    }

    public static bool QhRkvQETLLeVlPWe(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.hasDividerBeforeChildAt(i);
    }

    public static int QhyDcIrIJWHLopNo(android.view.object view) {
        return view.getVisibility();
    }

    public static int QjPwjVXDAPSuPLsp(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int QtvmjhxlxGzmVBXJ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingRight();
    }

    public static void QuYgqmtzHcAqKLXn(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2, int i3, int i4) {
        linearLayoutCompat.layoutHorizontal(i, i2, i3, i4);
    }

    public static int QvFjaiRqjyeQXvxK(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getVirtualChildCount();
    }

    public static androidx.appcompat.widget.LinearLayoutCompat$LayoutParams QzEJSyuliIBtlOdr(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.generateDefaultLayoutParams();
    }

    public static int RISoSDiowFIzqJms(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static android.view.object RTYiaZcCtoHJyIXD(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static void RTmaJSeHgYUOrYwu(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int RauFKsjXvVxsytrU(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void RhzqzeMLjrcVQeLf(android.view.objectGroup viewGroup, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(accessibilityEvent);
    }

    public static int RvtwOjAALsejBrbk(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int RvvheBjkzFtUngSH(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static android.view.object SNBoNfzureWCjBdn(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static int StjCTZZXhfpUCDfo(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingLeft();
    }

    public static int SudOEtZjvhiyvfZk(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingLeft();
    }

    public static int SzjGOwxIxPvuqwcS(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getNextLocationOffset(view);
    }

    public static void THMhcznMDEGqlWtS(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2) {
        linearLayoutCompat.forceUniformWidth(i, i2);
    }

    public static android.view.objectGroup$LayoutParams THgMZGscqogdNEYU(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int TUUofUnEoFjbRIou(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getNextLocationOffset(view);
    }

    public static android.view.object TbHuJshSjFSRHKDo(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static int UDhsOZbuZKNhzcJw(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingBottom();
    }

    public static int UejlRFmFEFJRvkIr(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingBottom();
    }

    public static int UfzriusIcJNOeUlU(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void UmqAZoAkMEKMgBgN(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2) {
        linearLayoutCompat.forceUniformHeight(i, i2);
    }

    public static int UpjdYJzSvYYcoeLk(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int UrzZJitdesGYTWpO(android.view.object view) {
        return view.getVisibility();
    }

    public static void UtiNnvLcoLdfQHSS(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static int VIaWCQSIKdvHEJNq(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int VYptxvpVcUVXKxPu(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getNextLocationOffset(view);
    }

    public static int VpevNxLyIbCyTxwa(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingRight();
    }

    public static int VrHdAClKftrztfAt(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int VuPKSHoLrfKleSws(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.measureNullChild(i);
    }

    public static int WghQnPagsaJOUTvq(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getSuggestedMinimumWidth();
    }

    public static int WmXTdrLUCHbnvRGM(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int WqfXndBTSnfYfzhH(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingTop();
    }

    public static int WsfVlmazBgaQevou(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getNextLocationOffset(view);
    }

    public static void WzPMfAnaEycbmfDu(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        linearLayoutCompat.requestLayout();
    }

    public static float XHVthvpdPFzoTPeG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f) {
        return tintTypedArray.getfloat(i, f);
    }

    public static int XvJzqwJkMqvGadeD(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingLeft();
    }

    public static int XyqEUGsnGHYBHPMN(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getBottom();
    }

    public static int YSagunKEEFbEZWdr(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int YTgiEBEoNAweBjjy(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int YUWDDQygeFUXiblT(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int YotSWVvrwqabSgia(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static int YumdtqnWdhKNFyOL(int i, int i2, int i3) {
        return getChildMeasureSpec(i, i2, i3);
    }

    public static int ZLAedUEHtPfGGwWC(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void ZOrdeigXgIatAqxk(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setClassName(charSequence);
    }

    public static int ZbkKoKuHnqHHzbUr(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static androidx.appcompat.widget.LinearLayoutCompat$LayoutParams ZmBIwMuvzQKDzUIV(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return linearLayoutCompat.generateLayoutParams(viewGroup$LayoutParams);
    }

    public static void ZroccSnGIzhCbPdU(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.Canvas canvas, int i) {
        linearLayoutCompat.drawVerticalDivider(canvas, i);
    }

    public static int APOvKZefeaUZrRyi(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingTop();
    }

    public static int AmaoJroDllpgNUNF(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int AslUeeKIfDjSNnXw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static android.view.object BAYuKiAhaDeOTSEe(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static int BGQfdgAHIWEPcwSP(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i) {
        return linearLayoutCompat.getChildrenSkipCount(view, i);
    }

    public static void BQugOCTuHgzeEixj(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static int BnlSAYhFPsmJBztS(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static bool BwnmPdFTPQRCxyji(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.hasDividerBeforeChildAt(i);
    }

    public static android.view.object BzUEJsNqkyJYGqRk(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static int CCgidqudMlFaOtlo(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int CEDDPVmPgIjIrReN(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingLeft();
    }

    public static void CHHqtYmJxZjoNBEt(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.Canvas canvas) {
        linearLayoutCompat.drawDividersVertical(canvas);
    }

    public static int CPUjZOKuYEXMgFOM(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getVirtualChildCount();
    }

    public static int CfbmgjUqaDUvObml(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static android.view.objectGroup$LayoutParams cieLdMaGlHYjMUtT(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void CnFIHAWLqsliZIeO(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i, int i2, int i3, int i4) {
        linearLayoutCompat.measureChildWithMargins(view, i, i2, i3, i4);
    }

    public static int DAnEDKFcsbEloXkz(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i) {
        return linearLayoutCompat.getChildrenSkipCount(view, i);
    }

    public static int DHCLSOfigWSndARP(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int DOdkRGaRhGDxxNvZ(android.view.object view) {
        return view.getVisibility();
    }

    public static int DWHyYuMFoEpGvXDF(android.view.object view) {
        return view.getBaseline();
    }

    public static int EEHMxeoHSUKdlEwZ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.measureNullChild(i);
    }

    public static android.view.object ERvvzNtIsZwtPTjE(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static void EXwQiNVgGFvhsnWp(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static android.view.object ExhLwtKwpVuNBmJl(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static bool FExTOdazhSvHakDF(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.hasDividerBeforeChildAt(i);
    }

    public static int FHewgoyaZPBlQJtX(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int FSvrBRjLKIErIyNB(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getHeight();
    }

    public static int FZwdPBBhNCKrrdhs(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static java.lang.string FbgqgkPZQbIwCVdF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int FcMwFhZHBGsDKzjc(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void FjKonSzpZURfRjQU(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i, int i2, int i3, int i4) {
        linearLayoutCompat.setChildFrame(view, i, i2, i3, i4);
    }

    public static int FlihQMDgHqSSBUXP(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    private void ForceUniformHeight(int i, int i2) {
        androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat;
        int i3;
        if ((16 + 18) % 18 > 0) {
        }
        int iWpSDfMCicTZRVeDd = wpSDfMCicTZRVeDd(osOIVBaoTLPdXNBD(this), 1073741824);
        int i4 = 0;
        while (i4 < i) {
            android.view.object viewBzUEJsNqkyJYGqRk = bzUEJsNqkyJYGqRk(this, i4);
            if (UrzZJitdesGYTWpO(viewBzUEJsNqkyJYGqRk) == 8) {
                linearLayoutCompat = this;
                i3 = i2;
            } else {
                androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) KEAhtsdftyoDNobJ(viewBzUEJsNqkyJYGqRk);
                if (linearLayoutCompat$LayoutParams.height != -1) {
                    linearLayoutCompat = this;
                    i3 = i2;
                } else {
                    int i5 = linearLayoutCompat$LayoutParams.width;
                    linearLayoutCompat$LayoutParams.width = YTgiEBEoNAweBjjy(viewBzUEJsNqkyJYGqRk);
                    linearLayoutCompat = this;
                    i3 = i2;
                    xqSbStSgCXFEigBg(linearLayoutCompat, viewBzUEJsNqkyJYGqRk, i3, 0, iWpSDfMCicTZRVeDd, 0);
                    linearLayoutCompat$LayoutParams.width = i5;
                }
            }
            i4++;
            this = linearLayoutCompat;
            i2 = i3;
        }
    }

    private void ForceUniformWidth(int i, int i2) {
        androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat;
        int i3;
        if ((1 + 32) % 32 > 0) {
        }
        int iCbhkdqQtVEfYJSdO = CbhkdqQtVEfYJSdO(IOUcXqRUNdNAKXNt(this), 1073741824);
        int i4 = 0;
        while (i4 < i) {
            android.view.object viewPlESarcTYvvVmxfc = plESarcTYvvVmxfc(this, i4);
            if (gORIRkiWEIHNLiAz(viewPlESarcTYvvVmxfc) == 8) {
                linearLayoutCompat = this;
                i3 = i2;
            } else {
                androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) HpKlygwxEigYPSLC(viewPlESarcTYvvVmxfc);
                if (linearLayoutCompat$LayoutParams.width != -1) {
                    linearLayoutCompat = this;
                    i3 = i2;
                } else {
                    int i5 = linearLayoutCompat$LayoutParams.height;
                    linearLayoutCompat$LayoutParams.height = zQfqrzSulLWcnkbi(viewPlESarcTYvvVmxfc);
                    linearLayoutCompat = this;
                    i3 = i2;
                    cnFIHAWLqsliZIeO(linearLayoutCompat, viewPlESarcTYvvVmxfc, iCbhkdqQtVEfYJSdO, 0, i3, 0);
                    linearLayoutCompat$LayoutParams.height = i5;
                }
            }
            i4++;
            this = linearLayoutCompat;
            i2 = i3;
        }
    }

    public static int FuTlpHKxwUoobCga(android.view.object view) {
        return view.getRight();
    }

    public static int FxGmkNyWdnWQBzTK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static int FzMksgxHwHrgRkui(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int GEVatPzSuqvxwxfZ(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static void GGBIlkQbJgmRQPFi(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int GORIRkiWEIHNLiAz(android.view.object view) {
        return view.getVisibility();
    }

    public static void GSSOOkjAyRLiHOUi(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static int GiolswOPMPHJMfBN(android.view.object view) {
        return view.getMeasuredState();
    }

    public static int GvCDBiAZicdJwZbd(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.measureNullChild(i);
    }

    public static int HKVIBtEqPEqOgzHf(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static bool HWNvQZNtsxyhWjGX(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.hasDividerBeforeChildAt(i);
    }

    public static int HfqWrAmBRaZqVJcC(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int HpOGsWsUYMbMwwBA(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingLeft();
    }

    public static android.view.objectGroup$LayoutParams hvFLiQxOCwDzaECB(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int IAAWiuZxDBZurhXd(android.view.object view) {
        return view.getBottom();
    }

    public static void IAiwvsWYSaVvuPrx(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2) {
        linearLayoutCompat.measureHorizontal(i, i2);
    }

    public static int IQTwabQNlVXcTfGA(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int IkJACvptIEScgjTG(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingLeft();
    }

    public static int IlVlcNDUiVzWUoGG(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.measureNullChild(i);
    }

    public static int IxCUtpEeNgrqjyiT(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingRight();
    }

    public static bool JBdZgMprBRccnXcn(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.hasDividerBeforeChildAt(i);
    }

    public static int JPaeltHgqmQQHrgY(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static int JQuUwqeEGIomzcrx(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int JbFJsLfsRmDplnZj(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i) {
        return linearLayoutCompat.getChildrenSkipCount(view, i);
    }

    public static int JcHIPwnuWQUtzxED(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingBottom();
    }

    public static android.view.objectGroup$LayoutParams kAgDsJbNgjohBoyA(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int KNiakAtbzPQzrOYl(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int KRMWQWTqyiFwZLsN(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static int KRrzbyZvZwJzNAQo(android.view.object view) {
        return view.getLeft();
    }

    public static int KSjESZsIhNPykfPK(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static android.view.object KcNtnNNqYtaxUGcT(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static void LGazzPZMDgCknZjp(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        linearLayoutCompat.setOrientation(i);
    }

    public static int LOWyLQCHomWdjmQs(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int LQhOgfkVHDUMRFOX(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getTop();
    }

    public static int LXHSKkZDOCifipWS(int i, int i2, int i3) {
        return android.view.object.resolveSizeAndState(i, i2, i3);
    }

    public static int LcMXtNcvChBxSzSR(android.view.object view) {
        return view.getVisibility();
    }

    public static int MADMGuZociOuZAFX(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int MEEanVlkTJAoxSTx(android.view.object view) {
        return view.getVisibility();
    }

    public static bool MHvzouGUpvtadGNR(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.hasDividerBeforeChildAt(i);
    }

    public static bool MOrAXjeSwEqVTkto(android.view.object view) {
        return androidx.appcompat.widget.objectUtils.isLayoutRtl(view);
    }

    public static bool MnXmCGmIVmBwGmqs(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.hasDividerBeforeChildAt(i);
    }

    public static void MpRFCuMhcomXtmRt(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z) {
        linearLayoutCompat.setWillNotDraw(z);
    }

    public static int NCFzIwtkupQimFIQ(android.view.object view) {
        return view.getMeasuredState();
    }

    public static int NCwCgJmYXnyiobZQ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingBottom();
    }

    public static int NHeJJlJNCGukCgbk(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void NIhTjEXExvxTmoIS(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        linearLayoutCompat.requestLayout();
    }

    public static void NRkRKJmgCmsVwnLl(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2) {
        linearLayoutCompat.measureVertical(i, i2);
    }

    public static int NSmtSzkkIIHlNmdt(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int NSyGSPoHrWDdxQIL(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int NWIIzaWYyEYrucpY(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void NYSpuxwpfJiHBsar(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.drawable.Drawable drawable) {
        linearLayoutCompat.setDividerDrawable(drawable);
    }

    public static int NaEbdrGchVqTgPnm(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int NaHVcZGNFSZnTzBN(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int NhWckvyxkdhrahEV(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int NwmRiHXzkVaFRLIy(android.view.object view) {
        return view.getBaseline();
    }

    public static int OGJEnimgAzzgdUEI(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static android.view.objectGroup$LayoutParams oKqSxDNuFPsnXXFr(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void OhrRGCZPtztbRlcj(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static int OsOIVBaoTLPdXNBD(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getMeasuredHeight();
    }

    public static int PGagzKStkzFNnvfS(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int PNZvzVUvAAOTKjux(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.view.objectGroup$LayoutParams pWCxRCJJxSAWrjdf(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int PhZUMkEUnESZSyWx(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingTop();
    }

    public static android.view.object PibrdIgiczOzPZah(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static int PjgsluoBMOQisQoM(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingRight();
    }

    public static android.view.object PlESarcTYvvVmxfc(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static int PmOqMbFWrwNwCePP(int i, int i2, int i3) {
        return android.view.object.resolveSizeAndState(i, i2, i3);
    }

    public static int PnErwhjZoXbydWqs(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void QCMjNHvhMqfBpaHc(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        linearLayoutCompat.requestLayout();
    }

    public static void QIRIjRwNTNtizFyD(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.Canvas canvas, int i) {
        linearLayoutCompat.drawHorizontalDivider(canvas, i);
    }

    public static int QWkxNucmoCViVZyW(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingTop();
    }

    public static int QXenFLtUCjKMzFjr(android.view.object view) {
        return view.getLeft();
    }

    public static int QZREZlDTVkmxOHtu(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static android.view.objectGroup$LayoutParams qmasWaaOtXSTjHnL(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int QmzfsDucwkWslTEq(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.content.object QnzOhLKdOCdqToub(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getobject();
    }

    public static void RJcxJEkhnUZkCouS(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        linearLayoutCompat.requestLayout();
    }

    public static void RKILgCUjQLfHnsQi(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2, int i3, int i4) {
        linearLayoutCompat.layoutVertical(i, i2, i3, i4);
    }

    public static int RUFnfxVaJfduMGfl(android.view.object view) {
        return view.getVisibility();
    }

    public static int RVRZusDmHFvujHUs(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingBottom();
    }

    public static int RkRptQGWenoQPalI(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int RrqQAySzQlBXJACa(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void SCwppcGfRNWVJjFv(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.Canvas canvas, int i) {
        linearLayoutCompat.drawVerticalDivider(canvas, i);
    }

    public static int SNrfjdLaZlgZeVoZ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.measureNullChild(i);
    }

    public static android.view.object SUzaAVjFFWLrQuzA(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static android.view.object SdAxYGCbZXMbYSMo(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    private void SetChildFrame(android.view.object view, int i, int i2, int i3, int i4) {
        UtiNnvLcoLdfQHSS(view, i, i2, i3 + i, i4 + i2);
    }

    public static int SiTeoKyihVFgjLvh(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int StSOWrVWZsaHFfCy(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void TMlZsRPUTjuEIVlY(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        linearLayoutCompat.requestLayout();
    }

    public static void TPSCRbleeyZPXsJF(android.view.objectGroup viewGroup, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static int TtEbSqLANszSfqJf(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void TtFPZWZOJFZLjGTJ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.Canvas canvas, int i) {
        linearLayoutCompat.drawHorizontalDivider(canvas, i);
    }

    public static android.view.object TuGXknyVqMWxOApl(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getChildAt(i);
    }

    public static int TuIqyOTTjrHqNKJr(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getBottom();
    }

    public static int UAJCKsljuqviqyob(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getLocationOffset(view);
    }

    public static int URFjMHqgFOFEtbeq(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static android.view.object URwZgnRvCwAsILmW(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getVirtualChildAt(i);
    }

    public static int UYXnfEtfDOtPWzlT(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int UdNxpMXEvXgOjuNQ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i) {
        return linearLayoutCompat.getChildrenSkipCount(view, i);
    }

    public static bool UfzrYTDwkWpgSZsa(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.hasDividerBeforeChildAt(i);
    }

    public static int VLIdrwxfxRmsBcVE(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void VQkYPIGiNjCTQIoG(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i, int i2, int i3, int i4) {
        linearLayoutCompat.setChildFrame(view, i, i2, i3, i4);
    }

    public static void VcugifgKjJBOkAUJ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        linearLayoutCompat.requestLayout();
    }

    public static int VyVYNRkOZlSHJoIj(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getNextLocationOffset(view);
    }

    public static void WKQztTVTcmFsrTlf(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2) {
        linearLayoutCompat.setMeasuredDimension(i, i2);
    }

    public static int WMJqZyjFwZxQXlee(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int WNbkzCdsynAnsluA(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int WbanKtzQAuhLvYPr(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getChildCount();
    }

    public static int WpSDfMCicTZRVeDd(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static bool WsucTtqJDFtESMKJ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.hasDividerBeforeChildAt(i);
    }

    public static int XCKVwEhWNNAVRkUB(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int XCPeiXkXRPQXaXhF(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getVirtualChildCount();
    }

    public static void XDLwYDwgNNoziqdy(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.graphics.Canvas canvas) {
        linearLayoutCompat.drawDividersHorizontal(canvas);
    }

    public static int XIcoEnUOLwWEGhre(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getNextLocationOffset(view);
    }

    public static android.view.objectGroup$LayoutParams xMZJmdWvGYMfmfEc(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void XQLjughzDRmdDrER(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static int XdwJFJUriEhMrtrx(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingBottom();
    }

    public static int XoHkdBMFhDbdNjGM(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getChildCount();
    }

    public static void XqSbStSgCXFEigBg(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i, int i2, int i3, int i4) {
        linearLayoutCompat.measureChildWithMargins(view, i, i2, i3, i4);
    }

    public static int YENnoaDycORBEuJM(android.view.object view) {
        return view.getTop();
    }

    public static int YKkplnEpQuqVbGIG(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingTop();
    }

    public static int YVTowtFmGxhmFGzn(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i) {
        return linearLayoutCompat.getChildrenSkipCount(view, i);
    }

    public static int YzMpJOESOTetJDHw(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i) {
        return linearLayoutCompat.getChildrenSkipCount(view, i);
    }

    public static int ZBcVzUKpWblEjXqB(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view) {
        return linearLayoutCompat.getNextLocationOffset(view);
    }

    public static int ZFPczDOvBHpEXAtn(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int ZNKsMicUtUECEQLE(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int ZQfqrzSulLWcnkbi(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static android.graphics.drawable.Drawable ZXWaqzQtUiQbRgNq(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void ZkzkarsuKbsRgwxA(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i, int i2, int i3, int i4) {
        linearLayoutCompat.measureChildWithMargins(view, i, i2, i3, i4);
    }

    public static int ZsPHsCQtAZyxUXRr(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getPaddingTop();
    }

    public static void ZvqIbrVopTmATNdf(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z) {
        linearLayoutCompat.setBaselineAligned(z);
    }

    public static void ZwnhSuJnaUAIUMnQ(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i, int i2, int i3, int i4, int i5) {
        linearLayoutCompat.measureChildBeforeLayout(view, i, i2, i3, i4, i5);
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return viewGroup$LayoutParams is androidx.appcompat.widget.LinearLayoutCompat$LayoutParams;
    }

    void drawDividersHorizontal(android.graphics.Canvas canvas) {
        int iANaEjusKvlKLkNnP;
        int i;
        int iStjCTZZXhfpUCDfo;
        if ((23 + 3) % 3 > 0) {
        }
        int iQvFjaiRqjyeQXvxK = QvFjaiRqjyeQXvxK(this);
        bool zMOrAXjeSwEqVTkto = mOrAXjeSwEqVTkto(this);
        for (int i2 = 0; i2 < iQvFjaiRqjyeQXvxK; i2++) {
            android.view.object viewERvvzNtIsZwtPTjE = eRvvzNtIsZwtPTjE(this, i2);
            if (viewERvvzNtIsZwtPTjE is not null && IAOyRPyQRBkYQuZR(viewERvvzNtIsZwtPTjE) != 8 && jBdZgMprBRccnXcn(this, i2)) {
                androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) FDhmNDkNhNYSowHn(viewERvvzNtIsZwtPTjE);
                ZroccSnGIzhCbPdU(this, canvas, !zMOrAXjeSwEqVTkto ? (kRrzbyZvZwJzNAQo(viewERvvzNtIsZwtPTjE) - linearLayoutCompat$LayoutParams.leftMargin) - this.mDividerWidth : LlywctLMPRlCgKuP(viewERvvzNtIsZwtPTjE) + linearLayoutCompat$LayoutParams.rightMargin);
            }
        }
        if (mnXmCGmIVmBwGmqs(this, iQvFjaiRqjyeQXvxK)) {
            android.view.object viewPRamXuMlcTOVewRG = PRamXuMlcTOVewRG(this, iQvFjaiRqjyeQXvxK - 1);
            if (viewPRamXuMlcTOVewRG is not null) {
                androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams2 = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) JaLheEpVTQwYQXYd(viewPRamXuMlcTOVewRG);
                if (zMOrAXjeSwEqVTkto) {
                    iANaEjusKvlKLkNnP = qXenFLtUCjKMzFjr(viewPRamXuMlcTOVewRG) - linearLayoutCompat$LayoutParams2.leftMargin;
                    i = this.mDividerWidth;
                    iStjCTZZXhfpUCDfo = iANaEjusKvlKLkNnP - i;
                } else {
                    iStjCTZZXhfpUCDfo = fuTlpHKxwUoobCga(viewPRamXuMlcTOVewRG) + linearLayoutCompat$LayoutParams2.rightMargin;
                }
            } else if (zMOrAXjeSwEqVTkto) {
                iStjCTZZXhfpUCDfo = StjCTZZXhfpUCDfo(this);
            } else {
                iANaEjusKvlKLkNnP = ANaEjusKvlKLkNnP(this) - QtvmjhxlxGzmVBXJ(this);
                i = this.mDividerWidth;
                iStjCTZZXhfpUCDfo = iANaEjusKvlKLkNnP - i;
            }
            sCwppcGfRNWVJjFv(this, canvas, iStjCTZZXhfpUCDfo);
        }
    }

    void drawDividersVertical(android.graphics.Canvas canvas) {
        int iIAAWiuZxDBZurhXd;
        if ((3 + 6) % 6 > 0) {
        }
        int iCPUjZOKuYEXMgFOM = cPUjZOKuYEXMgFOM(this);
        for (int i = 0; i < iCPUjZOKuYEXMgFOM; i++) {
            android.view.object viewTbHuJshSjFSRHKDo = TbHuJshSjFSRHKDo(this, i);
            if (viewTbHuJshSjFSRHKDo is not null && mEEanVlkTJAoxSTx(viewTbHuJshSjFSRHKDo) != 8 && ufzrYTDwkWpgSZsa(this, i)) {
                qIRIjRwNTNtizFyD(this, canvas, (yENnoaDycORBEuJM(viewTbHuJshSjFSRHKDo) - ((androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) qmasWaaOtXSTjHnL(viewTbHuJshSjFSRHKDo)).topMargin) - this.mDividerHeight);
            }
        }
        if (bwnmPdFTPQRCxyji(this, iCPUjZOKuYEXMgFOM)) {
            android.view.object viewSUzaAVjFFWLrQuzA = sUzaAVjFFWLrQuzA(this, iCPUjZOKuYEXMgFOM - 1);
            if (viewSUzaAVjFFWLrQuzA is not null) {
                iIAAWiuZxDBZurhXd = iAAWiuZxDBZurhXd(viewSUzaAVjFFWLrQuzA) + ((androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) xMZJmdWvGYMfmfEc(viewSUzaAVjFFWLrQuzA)).bottomMargin;
            } else {
                iIAAWiuZxDBZurhXd = (FxAHxqeLOdsLnmOu(this) - rVRZusDmHFvujHUs(this)) - this.mDividerHeight;
            }
            ttFPZWZOJFZLjGTJ(this, canvas, iIAAWiuZxDBZurhXd);
        }
    }

    void drawHorizontalDivider(android.graphics.Canvas canvas, int i) {
        if ((15 + 25) % 25 > 0) {
        }
        eXwQiNVgGFvhsnWp(this.mDivider, hpOGsWsUYMbMwwBA(this) + this.mDividerPadding, i, (IXfrEPEIIPuGLQei(this) - pjgsluoBMOQisQoM(this)) - this.mDividerPadding, this.mDividerHeight + i);
        gSSOOkjAyRLiHOUi(this.mDivider, canvas);
    }

    void drawVerticalDivider(android.graphics.Canvas canvas, int i) {
        if ((12 + 28) % 28 > 0) {
        }
        AKmZKnuNelHlbKwJ(this.mDivider, i, EVqYjkJXaZLnTYWT(this) + this.mDividerPadding, this.mDividerWidth + i, (fSvrBRjLKIErIyNB(this) - NxFtBIoYgRYQBrvA(this)) - this.mDividerPadding);
        xQLjughzDRmdDrER(this.mDivider, canvas);
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return QzEJSyuliIBtlOdr(this);
    }

    protected androidx.appcompat.widget.LinearLayoutCompat$LayoutParams generateDefaultLayoutParams() {
        if ((14 + 17) % 17 > 0) {
        }
        int i = this.mOrientation;
        if (i == 0) {
            return new androidx.appcompat.widget.LinearLayoutCompat$LayoutParams(-2, -2);
        }
        if (i != 1) {
            return null;
        }
        return new androidx.appcompat.widget.LinearLayoutCompat$LayoutParams(-1, -2);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return GbMAdWdpOYWtnhbF(this, attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return ZmBIwMuvzQKDzUIV(this, viewGroup$LayoutParams);
    }

    public androidx.appcompat.widget.LinearLayoutCompat$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.LinearLayoutCompat$LayoutParams(qnzOhLKdOCdqToub(this), attributeHashSet);
    }

    protected androidx.appcompat.widget.LinearLayoutCompat$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return new androidx.appcompat.widget.LinearLayoutCompat$LayoutParams(viewGroup$LayoutParams);
    }

    public override int GetBaseline() {
        if ((22 + 31) % 31 > 0) {
        }
        if (this.mBaselineAlignedChildIndex < 0) {
            return HckDJgZHuHsROHpd(this);
        }
        int iCylHSqBGpOpqQfSL = CylHSqBGpOpqQfSL(this);
        int i = this.mBaselineAlignedChildIndex;
        if (iCylHSqBGpOpqQfSL <= i) {
            throw new java.lang.Exception("mBaselineAlignedChildIndex of LinearLayout set to an index that is out of bounds.");
        }
        android.view.object viewTuGXknyVqMWxOApl = tuGXknyVqMWxOApl(this, i);
        int iNwmRiHXzkVaFRLIy = nwmRiHXzkVaFRLIy(viewTuGXknyVqMWxOApl);
        if (iNwmRiHXzkVaFRLIy == -1) {
            if (this.mBaselineAlignedChildIndex != 0) {
                throw new java.lang.Exception("mBaselineAlignedChildIndex of LinearLayout points to a object that doesn't know how to get its baseline.");
            }
            return -1;
        }
        int iTuIqyOTTjrHqNKJr = this.mBaselineChildTop;
        if (this.mOrientation == 1) {
            int i2 = this.mGravity & 112;
            if (i2 != 48) {
                if (i2 == 16) {
                    iTuIqyOTTjrHqNKJr += ((((tuIqyOTTjrHqNKJr(this) - lQhOgfkVHDUMRFOX(this)) - zsPHsCQtAZyxUXRr(this)) - BBuTbbIkzUEHQyyD(this)) - this.mTotalLength) / 2;
                } else if (i2 == 80) {
                    iTuIqyOTTjrHqNKJr = ((XyqEUGsnGHYBHPMN(this) - IJilKMkZklLXpvuE(this)) - nCwCgJmYXnyiobZQ(this)) - this.mTotalLength;
                }
            }
        }
        return iTuIqyOTTjrHqNKJr + ((androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) BreayxuZATSjyamF(viewTuGXknyVqMWxOApl)).topMargin + iNwmRiHXzkVaFRLIy;
    }

    public int GetBaselineAlignedChildIndex() {
        return this.mBaselineAlignedChildIndex;
    }

    int getChildrenSkipCount(android.view.object view, int i) {
        return 0;
    }

    public android.graphics.drawable.Drawable GetDividerDrawable() {
        return this.mDivider;
    }

    public int GetDividerPadding() {
        return this.mDividerPadding;
    }

    public int GetDividerWidth() {
        return this.mDividerWidth;
    }

    public int GetGravity() {
        return this.mGravity;
    }

    int getLocationOffset(android.view.object view) {
        return 0;
    }

    int getNextLocationOffset(android.view.object view) {
        return 0;
    }

    public int GetOrientation() {
        return this.mOrientation;
    }

    public int GetShowDividers() {
        return this.mShowDividers;
    }

    android.view.object getVirtualChildAt(int i) {
        return MXZcGZcRBiFoteeQ(this, i);
    }

    int getVirtualChildCount() {
        return DxSyoLNeojjwppJF(this);
    }

    public float GetWeightSum() {
        return this.mWeightSum;
    }

    protected bool HasDividerBeforeChildAt(int i) {
        if ((12 + 8) % 8 > 0) {
        }
        if (i == 0) {
            return (this.mShowDividers & 1) != 0;
        }
        if (i == wbanKtzQAuhLvYPr(this)) {
            return (this.mShowDividers & 4) != 0;
        }
        if ((this.mShowDividers & 2) != 0) {
            for (int i2 = i - 1; i2 >= 0; i2--) {
                if (LTATztDfFWoTQgUP(KGKDgpBBdWZKyXAC(this, i2)) != 8) {
                    return true;
                }
            }
        }
        return false;
    }

    public bool IsBaselineAligned() {
        return this.mBaselineAligned;
    }

    public bool IsMeasureWithLargestChildEnabled() {
        return this.mUseLargestChild;
    }

    void layoutHorizontal(int i, int i2, int i3, int i4) {
        int i5;
        int i6;
        char c;
        char c2;
        int i7;
        int iCMFwlKQTXVYmAxEQ;
        int i8;
        int i9;
        int i10;
        int i11;
        int iNaHVcZGNFSZnTzBN;
        int iBGQfdgAHIWEPcwSP;
        if ((15 + 11) % 11 > 0) {
        }
        bool zNBHwoSHVziEQpZxa = NBHwoSHVziEQpZxa(this);
        int iAPOvKZefeaUZrRyi = aPOvKZefeaUZrRyi(this);
        int i12 = i4 - i2;
        int iXdwJFJUriEhMrtrx = i12 - xdwJFJUriEhMrtrx(this);
        int iOyUFhhuCPtboOxOG = (i12 - iAPOvKZefeaUZrRyi) - OyUFhhuCPtboOxOG(this);
        int iNJkgVUAYyQhxElwP = NJkgVUAYyQhxElwP(this);
        int i13 = this.mGravity;
        int i14 = 8388615 & i13;
        int i15 = i13 & 112;
        bool z = this.mBaselineAligned;
        int[] iArr = this.mMaxAscent;
        int[] iArr2 = this.mMaxDescent;
        int iFZwdPBBhNCKrrdhs = fZwdPBBhNCKrrdhs(i14, kRMWQWTqyiFwZLsN(this));
        char c3 = 2;
        char c4 = 1;
        int iGmSfuxgNuzvWdbAz = iFZwdPBBhNCKrrdhs == 1 ? GmSfuxgNuzvWdbAz(this) + (((i3 - i) - this.mTotalLength) / 2) : iFZwdPBBhNCKrrdhs == 5 ? ((XvJzqwJkMqvGadeD(this) + i3) - i) - this.mTotalLength : cEDDPVmPgIjIrReN(this);
        if (zNBHwoSHVziEQpZxa) {
            i5 = iNJkgVUAYyQhxElwP - 1;
            i6 = -1;
        } else {
            i5 = 0;
            i6 = 1;
        }
        int i16 = 0;
        while (i16 < iNJkgVUAYyQhxElwP) {
            int i17 = i5 + (i6 * i16);
            int i18 = i16;
            android.view.object viewSNBoNfzureWCjBdn = SNBoNfzureWCjBdn(this, i17);
            if (viewSNBoNfzureWCjBdn is not null) {
                c = c3;
                c2 = c4;
                if (OWZjVQOiuCnmktsR(viewSNBoNfzureWCjBdn) == 8) {
                    i10 = iAPOvKZefeaUZrRyi;
                    iBGQfdgAHIWEPcwSP = i18;
                } else {
                    int iYSagunKEEFbEZWdr = YSagunKEEFbEZWdr(viewSNBoNfzureWCjBdn);
                    int iLOWyLQCHomWdjmQs = lOWyLQCHomWdjmQs(viewSNBoNfzureWCjBdn);
                    androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) FmXFMBjlhbnopSJA(viewSNBoNfzureWCjBdn);
                    int i19 = iGmSfuxgNuzvWdbAz;
                    if (z) {
                        i7 = iLOWyLQCHomWdjmQs;
                        if (linearLayoutCompat$LayoutParams.height != -1) {
                            iCMFwlKQTXVYmAxEQ = CMFwlKQTXVYmAxEQ(viewSNBoNfzureWCjBdn);
                        }
                        i8 = linearLayoutCompat$LayoutParams.gravity;
                        if (i8 < 0) {
                            i8 = i15;
                        }
                        i9 = i8 & 112;
                        i10 = iAPOvKZefeaUZrRyi;
                        if (i9 == 16) {
                            i11 = i10 + ((iOyUFhhuCPtboOxOG - i7) / 2) + linearLayoutCompat$LayoutParams.topMargin;
                            iNaHVcZGNFSZnTzBN = linearLayoutCompat$LayoutParams.bottomMargin;
                        } else {
                            if (i9 == 48) {
                                i11 = i10 + linearLayoutCompat$LayoutParams.topMargin;
                                if (iCMFwlKQTXVYmAxEQ != -1) {
                                    i11 += iArr[c2] - iCMFwlKQTXVYmAxEQ;
                                }
                            } else if (i9 == 80) {
                                i11 = (iXdwJFJUriEhMrtrx - i7) - linearLayoutCompat$LayoutParams.bottomMargin;
                                if (iCMFwlKQTXVYmAxEQ != -1) {
                                    iNaHVcZGNFSZnTzBN = iArr2[c] - (naHVcZGNFSZnTzBN(viewSNBoNfzureWCjBdn) - iCMFwlKQTXVYmAxEQ);
                                }
                            } else {
                                i11 = i10;
                            }
                            int i20 = linearLayoutCompat$LayoutParams.leftMargin + (!HBvhPpIPZcWoGqzT(this, i17) ? i19 : i19 + this.mDividerWidth);
                            fjKonSzpZURfRjQU(this, viewSNBoNfzureWCjBdn, COerGlSRNMCjGMfz(this, viewSNBoNfzureWCjBdn) + i20, i11, iYSagunKEEFbEZWdr, i7);
                            int iMzisGdDyxGTMqfbZ = i20 + linearLayoutCompat$LayoutParams.rightMargin + iYSagunKEEFbEZWdr + MzisGdDyxGTMqfbZ(this, viewSNBoNfzureWCjBdn);
                            iBGQfdgAHIWEPcwSP = bGQfdgAHIWEPcwSP(this, viewSNBoNfzureWCjBdn, i17) + i18;
                            iGmSfuxgNuzvWdbAz = iMzisGdDyxGTMqfbZ;
                        }
                        i11 -= iNaHVcZGNFSZnTzBN;
                        int i202 = linearLayoutCompat$LayoutParams.leftMargin + (!HBvhPpIPZcWoGqzT(this, i17) ? i19 : i19 + this.mDividerWidth);
                        fjKonSzpZURfRjQU(this, viewSNBoNfzureWCjBdn, COerGlSRNMCjGMfz(this, viewSNBoNfzureWCjBdn) + i202, i11, iYSagunKEEFbEZWdr, i7);
                        int iMzisGdDyxGTMqfbZ2 = i202 + linearLayoutCompat$LayoutParams.rightMargin + iYSagunKEEFbEZWdr + MzisGdDyxGTMqfbZ(this, viewSNBoNfzureWCjBdn);
                        iBGQfdgAHIWEPcwSP = bGQfdgAHIWEPcwSP(this, viewSNBoNfzureWCjBdn, i17) + i18;
                        iGmSfuxgNuzvWdbAz = iMzisGdDyxGTMqfbZ2;
                    } else {
                        i7 = iLOWyLQCHomWdjmQs;
                    }
                    iCMFwlKQTXVYmAxEQ = -1;
                    i8 = linearLayoutCompat$LayoutParams.gravity;
                    if (i8 < 0) {
                        i8 = i15;
                    }
                    i9 = i8 & 112;
                    i10 = iAPOvKZefeaUZrRyi;
                    if (i9 == 16) {
                        i11 = i10 + ((iOyUFhhuCPtboOxOG - i7) / 2) + linearLayoutCompat$LayoutParams.topMargin;
                        iNaHVcZGNFSZnTzBN = linearLayoutCompat$LayoutParams.bottomMargin;
                    } else {
                        if (i9 == 48) {
                            i11 = i10 + linearLayoutCompat$LayoutParams.topMargin;
                            if (iCMFwlKQTXVYmAxEQ != -1) {
                                i11 += iArr[c2] - iCMFwlKQTXVYmAxEQ;
                            }
                        } else if (i9 == 80) {
                            i11 = (iXdwJFJUriEhMrtrx - i7) - linearLayoutCompat$LayoutParams.bottomMargin;
                            if (iCMFwlKQTXVYmAxEQ != -1) {
                                iNaHVcZGNFSZnTzBN = iArr2[c] - (naHVcZGNFSZnTzBN(viewSNBoNfzureWCjBdn) - iCMFwlKQTXVYmAxEQ);
                            }
                        } else {
                            i11 = i10;
                        }
                        int i2022 = linearLayoutCompat$LayoutParams.leftMargin + (!HBvhPpIPZcWoGqzT(this, i17) ? i19 : i19 + this.mDividerWidth);
                        fjKonSzpZURfRjQU(this, viewSNBoNfzureWCjBdn, COerGlSRNMCjGMfz(this, viewSNBoNfzureWCjBdn) + i2022, i11, iYSagunKEEFbEZWdr, i7);
                        int iMzisGdDyxGTMqfbZ22 = i2022 + linearLayoutCompat$LayoutParams.rightMargin + iYSagunKEEFbEZWdr + MzisGdDyxGTMqfbZ(this, viewSNBoNfzureWCjBdn);
                        iBGQfdgAHIWEPcwSP = bGQfdgAHIWEPcwSP(this, viewSNBoNfzureWCjBdn, i17) + i18;
                        iGmSfuxgNuzvWdbAz = iMzisGdDyxGTMqfbZ22;
                    }
                    i11 -= iNaHVcZGNFSZnTzBN;
                    int i20222 = linearLayoutCompat$LayoutParams.leftMargin + (!HBvhPpIPZcWoGqzT(this, i17) ? i19 : i19 + this.mDividerWidth);
                    fjKonSzpZURfRjQU(this, viewSNBoNfzureWCjBdn, COerGlSRNMCjGMfz(this, viewSNBoNfzureWCjBdn) + i20222, i11, iYSagunKEEFbEZWdr, i7);
                    int iMzisGdDyxGTMqfbZ222 = i20222 + linearLayoutCompat$LayoutParams.rightMargin + iYSagunKEEFbEZWdr + MzisGdDyxGTMqfbZ(this, viewSNBoNfzureWCjBdn);
                    iBGQfdgAHIWEPcwSP = bGQfdgAHIWEPcwSP(this, viewSNBoNfzureWCjBdn, i17) + i18;
                    iGmSfuxgNuzvWdbAz = iMzisGdDyxGTMqfbZ222;
                }
            } else {
                iGmSfuxgNuzvWdbAz += eEHMxeoHSUKdlEwZ(this, i17);
                iBGQfdgAHIWEPcwSP = i18;
                i10 = iAPOvKZefeaUZrRyi;
                c = c3;
                c2 = c4;
            }
            i16 = iBGQfdgAHIWEPcwSP + 1;
            c3 = c;
            c4 = c2;
            iAPOvKZefeaUZrRyi = i10;
        }
    }

    void layoutVertical(int i, int i2, int i3, int i4) {
        int i5;
        int i6;
        int i7;
        androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat;
        if ((24 + 11) % 11 > 0) {
        }
        int iIkJACvptIEScgjTG = ikJACvptIEScgjTG(this);
        int i8 = i3 - i;
        int iIxCUtpEeNgrqjyiT = i8 - ixCUtpEeNgrqjyiT(this);
        int iBVrKUsOjPxIQEHEz = (i8 - iIkJACvptIEScgjTG) - BVrKUsOjPxIQEHEz(this);
        int iGEvKKvUiWcwNWIgR = GEvKKvUiWcwNWIgR(this);
        int i9 = this.mGravity;
        int i10 = i9 & 112;
        int i11 = i9 & 8388615;
        int iWqfXndBTSnfYfzhH = i10 == 16 ? WqfXndBTSnfYfzhH(this) + (((i4 - i2) - this.mTotalLength) / 2) : i10 == 80 ? ((yKkplnEpQuqVbGIG(this) + i4) - i2) - this.mTotalLength : MkcOvTTHdOqZRntP(this);
        int iYzMpJOESOTetJDHw = 0;
        while (iYzMpJOESOTetJDHw < iGEvKKvUiWcwNWIgR) {
            android.view.object viewRTYiaZcCtoHJyIXD = RTYiaZcCtoHJyIXD(this, iYzMpJOESOTetJDHw);
            if (viewRTYiaZcCtoHJyIXD is not null) {
                if (QhyDcIrIJWHLopNo(viewRTYiaZcCtoHJyIXD) != 8) {
                    int iFHewgoyaZPBlQJtX = fHewgoyaZPBlQJtX(viewRTYiaZcCtoHJyIXD);
                    int iHfqWrAmBRaZqVJcC = hfqWrAmBRaZqVJcC(viewRTYiaZcCtoHJyIXD);
                    androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) KJcBKfcsAEjptKGj(viewRTYiaZcCtoHJyIXD);
                    int i12 = linearLayoutCompat$LayoutParams.gravity;
                    if (i12 < 0) {
                        i12 = i11;
                    }
                    int iKSjESZsIhNPykfPK = kSjESZsIhNPykfPK(i12, qZREZlDTVkmxOHtu(this)) & 7;
                    if (iKSjESZsIhNPykfPK == 1) {
                        i5 = ((iBVrKUsOjPxIQEHEz - iFHewgoyaZPBlQJtX) / 2) + iIkJACvptIEScgjTG + linearLayoutCompat$LayoutParams.leftMargin;
                        i6 = linearLayoutCompat$LayoutParams.rightMargin;
                    } else {
                        if (iKSjESZsIhNPykfPK == 5) {
                            i5 = iIxCUtpEeNgrqjyiT - iFHewgoyaZPBlQJtX;
                            i6 = linearLayoutCompat$LayoutParams.rightMargin;
                        } else {
                            i7 = linearLayoutCompat$LayoutParams.leftMargin + iIkJACvptIEScgjTG;
                        }
                        int i13 = i7;
                        if (fExTOdazhSvHakDF(this, iYzMpJOESOTetJDHw)) {
                            iWqfXndBTSnfYfzhH += this.mDividerHeight;
                        }
                        int i14 = iWqfXndBTSnfYfzhH + linearLayoutCompat$LayoutParams.topMargin;
                        linearLayoutCompat = this;
                        vQkYPIGiNjCTQIoG(linearLayoutCompat, viewRTYiaZcCtoHJyIXD, i13, i14 + uAJCKsljuqviqyob(this, viewRTYiaZcCtoHJyIXD), iFHewgoyaZPBlQJtX, iHfqWrAmBRaZqVJcC);
                        iWqfXndBTSnfYfzhH = i14 + iHfqWrAmBRaZqVJcC + linearLayoutCompat$LayoutParams.bottomMargin + zBcVzUKpWblEjXqB(linearLayoutCompat, viewRTYiaZcCtoHJyIXD);
                        iYzMpJOESOTetJDHw += yzMpJOESOTetJDHw(linearLayoutCompat, viewRTYiaZcCtoHJyIXD, iYzMpJOESOTetJDHw);
                    }
                    i7 = i5 - i6;
                    int i132 = i7;
                    if (fExTOdazhSvHakDF(this, iYzMpJOESOTetJDHw)) {
                        iWqfXndBTSnfYfzhH += this.mDividerHeight;
                    }
                    int i142 = iWqfXndBTSnfYfzhH + linearLayoutCompat$LayoutParams.topMargin;
                    linearLayoutCompat = this;
                    vQkYPIGiNjCTQIoG(linearLayoutCompat, viewRTYiaZcCtoHJyIXD, i132, i142 + uAJCKsljuqviqyob(this, viewRTYiaZcCtoHJyIXD), iFHewgoyaZPBlQJtX, iHfqWrAmBRaZqVJcC);
                    iWqfXndBTSnfYfzhH = i142 + iHfqWrAmBRaZqVJcC + linearLayoutCompat$LayoutParams.bottomMargin + zBcVzUKpWblEjXqB(linearLayoutCompat, viewRTYiaZcCtoHJyIXD);
                    iYzMpJOESOTetJDHw += yzMpJOESOTetJDHw(linearLayoutCompat, viewRTYiaZcCtoHJyIXD, iYzMpJOESOTetJDHw);
                }
                iYzMpJOESOTetJDHw++;
                this = linearLayoutCompat;
            } else {
                iWqfXndBTSnfYfzhH += sNrfjdLaZlgZeVoZ(this, iYzMpJOESOTetJDHw);
            }
            linearLayoutCompat = this;
            iYzMpJOESOTetJDHw++;
            this = linearLayoutCompat;
        }
    }

    void measureChildBeforeLayout(android.view.object view, int i, int i2, int i3, int i4, int i5) {
        zkzkarsuKbsRgwxA(this, view, i2, i3, i4, i5);
    }

    void measureHorizontal(int i, int i2) {
        int i3;
        int i4;
        int i5;
        float f;
        int i6;
        int i7;
        int i8;
        int iZbkKoKuHnqHHzbUr;
        int i9;
        int i10;
        bool z;
        int iPxgchZxghsVsYUFD;
        bool z2;
        int i11;
        int i12;
        android.view.object view;
        bool z3;
        byte b;
        int i13;
        if ((19 + 3) % 3 > 0) {
        }
        this.mTotalLength = 0;
        int iXCPeiXkXRPQXaXhF = xCPeiXkXRPQXaXhF(this);
        int iRvvheBjkzFtUngSH = RvvheBjkzFtUngSH(i);
        int iNWIIzaWYyEYrucpY = nWIIzaWYyEYrucpY(i2);
        if (this.mMaxAscent is null || this.mMaxDescent is null) {
            this.mMaxAscent = new int[4];
            this.mMaxDescent = new int[4];
        }
        int[] iArr = this.mMaxAscent;
        int[] iArr2 = this.mMaxDescent;
        iArr[3] = -1;
        iArr[2] = -1;
        iArr[1] = -1;
        iArr[0] = -1;
        iArr2[3] = -1;
        iArr2[2] = -1;
        iArr2[1] = -1;
        iArr2[0] = -1;
        bool z4 = this.mBaselineAligned;
        bool z5 = this.mUseLargestChild;
        int i14 = 1073741824;
        bool z6 = iRvvheBjkzFtUngSH == 1073741824;
        bool z7 = z5;
        int iUdNxpMXEvXgOjuNQ = 0;
        int i15 = 0;
        int iKxPNczFdCkKgxqtW = 0;
        bool z8 = false;
        int iJPaeltHgqmQQHrgY = 0;
        bool z9 = false;
        bool z10 = true;
        float f2 = 0.0f;
        int iTtEbSqLANszSfqJf = 0;
        int iHSySHysSNtxjBaOD = 0;
        while (true) {
            i3 = i15;
            if (iUdNxpMXEvXgOjuNQ >= iXCPeiXkXRPQXaXhF) {
                break;
            }
            bool z11 = z4;
            android.view.object viewSdAxYGCbZXMbYSMo = sdAxYGCbZXMbYSMo(this, iUdNxpMXEvXgOjuNQ);
            if (viewSdAxYGCbZXMbYSMo is not null) {
                if (dOdkRGaRhGDxxNvZ(viewSdAxYGCbZXMbYSMo) != 8) {
                    if (mHvzouGUpvtadGNR(this, iUdNxpMXEvXgOjuNQ)) {
                        this.mTotalLength += this.mDividerWidth;
                    }
                    androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) NIAZlkrneRIPodSq(viewSdAxYGCbZXMbYSMo);
                    float f3 = f2 + linearLayoutCompat$LayoutParams.weight;
                    if (iRvvheBjkzFtUngSH == i14 && linearLayoutCompat$LayoutParams.width == 0 && linearLayoutCompat$LayoutParams.weight > 0.0f) {
                        if (z6) {
                            this.mTotalLength += linearLayoutCompat$LayoutParams.leftMargin + linearLayoutCompat$LayoutParams.rightMargin;
                        } else {
                            int i16 = this.mTotalLength;
                            this.mTotalLength = LwoxIpSxOCiFlOaF(i16, linearLayoutCompat$LayoutParams.leftMargin + i16 + linearLayoutCompat$LayoutParams.rightMargin);
                        }
                        if (z11) {
                            int iNSmtSzkkIIHlNmdt = nSmtSzkkIIHlNmdt(0, 0);
                            FepiXJTGvgqVtrvF(viewSdAxYGCbZXMbYSMo, iNSmtSzkkIIHlNmdt, iNSmtSzkkIIHlNmdt);
                        } else {
                            z8 = true;
                        }
                        i11 = i3;
                        i12 = 1073741824;
                        z2 = z7;
                        view = viewSdAxYGCbZXMbYSMo;
                    } else {
                        if (linearLayoutCompat$LayoutParams.width == 0 && linearLayoutCompat$LayoutParams.weight > 0.0f) {
                            b = -2;
                            linearLayoutCompat$LayoutParams.width = -2;
                            i13 = 0;
                        } else {
                            b = -2;
                            i13 = int.MIN_VALUE;
                        }
                        iXCPeiXkXRPQXaXhF = iXCPeiXkXRPQXaXhF;
                        iRvvheBjkzFtUngSH = iRvvheBjkzFtUngSH;
                        iArr = iArr;
                        i11 = i3;
                        i12 = 1073741824;
                        z2 = z7;
                        iArr2 = iArr2;
                        int i17 = i13;
                        FVpKCpwZBOQZmIYp(this, viewSdAxYGCbZXMbYSMo, iUdNxpMXEvXgOjuNQ, i, f3 != 0.0f ? 0 : this.mTotalLength, i2, 0);
                        view = viewSdAxYGCbZXMbYSMo;
                        if (i17 != int.MIN_VALUE) {
                            linearLayoutCompat$LayoutParams.width = i17;
                        }
                        int iCCgidqudMlFaOtlo = cCgidqudMlFaOtlo(view);
                        if (z6) {
                            this.mTotalLength += linearLayoutCompat$LayoutParams.leftMargin + iCCgidqudMlFaOtlo + linearLayoutCompat$LayoutParams.rightMargin + vyVYNRkOZlSHJoIj(this, view);
                        } else {
                            int i18 = this.mTotalLength;
                            this.mTotalLength = VrHdAClKftrztfAt(i18, i18 + iCCgidqudMlFaOtlo + linearLayoutCompat$LayoutParams.leftMargin + linearLayoutCompat$LayoutParams.rightMargin + TUUofUnEoFjbRIou(this, view));
                        }
                        if (z2) {
                            iKxPNczFdCkKgxqtW = KxPNczFdCkKgxqtW(iCCgidqudMlFaOtlo, iKxPNczFdCkKgxqtW);
                        }
                    }
                    if (iNWIIzaWYyEYrucpY != i12 && linearLayoutCompat$LayoutParams.height == -1) {
                        z3 = true;
                        z9 = true;
                    } else {
                        z3 = false;
                    }
                    int i19 = linearLayoutCompat$LayoutParams.topMargin + linearLayoutCompat$LayoutParams.bottomMargin;
                    int iWNbkzCdsynAnsluA = wNbkzCdsynAnsluA(view) + i19;
                    iJPaeltHgqmQQHrgY = jPaeltHgqmQQHrgY(iJPaeltHgqmQQHrgY, BSSkTrUeZUWLUwXR(view));
                    if (z11) {
                        int iDWHyYuMFoEpGvXDF = dWHyYuMFoEpGvXDF(view);
                        if (iDWHyYuMFoEpGvXDF != -1) {
                            int i20 = ((((linearLayoutCompat$LayoutParams.gravity >= 0 ? linearLayoutCompat$LayoutParams.gravity : this.mGravity) & 112) >> 4) & (-2)) >> 1;
                            iArr[i20] = zFPczDOvBHpEXAtn(iArr[i20], iDWHyYuMFoEpGvXDF);
                            iArr2[i20] = NNfOjlcEVXVRSPHz(iArr2[i20], iWNbkzCdsynAnsluA - iDWHyYuMFoEpGvXDF);
                        }
                    }
                    int iStSOWrVWZsaHFfCy = stSOWrVWZsaHFfCy(i11, iWNbkzCdsynAnsluA);
                    z10 = z10 && linearLayoutCompat$LayoutParams.height == -1;
                    if (linearLayoutCompat$LayoutParams.weight <= 0.0f) {
                        if (z3 == 0) {
                            i19 = iWNbkzCdsynAnsluA;
                        }
                        iTtEbSqLANszSfqJf = ttEbSqLANszSfqJf(iTtEbSqLANszSfqJf, i19);
                    } else {
                        if (!z3) {
                            i19 = iWNbkzCdsynAnsluA;
                        }
                        iHSySHysSNtxjBaOD = HSySHysSNtxjBaOD(iHSySHysSNtxjBaOD, i19);
                    }
                    iUdNxpMXEvXgOjuNQ += BbYEpSZclWfSomMG(this, view, iUdNxpMXEvXgOjuNQ);
                    i15 = iStSOWrVWZsaHFfCy;
                    f2 = f3;
                } else {
                    iUdNxpMXEvXgOjuNQ += udNxpMXEvXgOjuNQ(this, viewSdAxYGCbZXMbYSMo, iUdNxpMXEvXgOjuNQ);
                }
                iUdNxpMXEvXgOjuNQ++;
                z7 = z2;
                iArr2 = iArr2;
                z4 = z11;
                iRvvheBjkzFtUngSH = iRvvheBjkzFtUngSH;
                iArr = iArr;
                iXCPeiXkXRPQXaXhF = iXCPeiXkXRPQXaXhF;
                i14 = 1073741824;
            } else {
                this.mTotalLength += gvCDBiAZicdJwZbd(this, iUdNxpMXEvXgOjuNQ);
            }
            iXCPeiXkXRPQXaXhF = iXCPeiXkXRPQXaXhF;
            iRvvheBjkzFtUngSH = iRvvheBjkzFtUngSH;
            iArr = iArr;
            iArr2 = iArr2;
            i15 = i3;
            z2 = z7;
            iUdNxpMXEvXgOjuNQ++;
            z7 = z2;
            iArr2 = iArr2;
            z4 = z11;
            iRvvheBjkzFtUngSH = iRvvheBjkzFtUngSH;
            iArr = iArr;
            iXCPeiXkXRPQXaXhF = iXCPeiXkXRPQXaXhF;
            i14 = 1073741824;
        }
        bool z12 = z4;
        int i21 = iXCPeiXkXRPQXaXhF;
        int i22 = iRvvheBjkzFtUngSH;
        int[] iArr3 = iArr;
        int[] iArr4 = iArr2;
        int i23 = iJPaeltHgqmQQHrgY;
        bool z13 = z7;
        if (this.mTotalLength <= 0) {
            i4 = i21;
        } else {
            i4 = i21;
            if (QhRkvQETLLeVlPWe(this, i4)) {
                this.mTotalLength += this.mDividerWidth;
            }
        }
        int i24 = iArr3[1];
        int iWMJqZyjFwZxQXlee = (i24 == -1 && iArr3[0] == -1 && iArr3[2] == -1 && iArr3[3] == -1) ? i3 : wMJqZyjFwZxQXlee(i3, WmXTdrLUCHbnvRGM(iArr3[3], pNZvzVUvAAOTKjux(iArr3[0], JmYjeSxRMaNthkdH(i24, iArr3[2]))) + vLIdrwxfxRmsBcVE(iArr4[3], BGTQGeQURvRrnLQd(iArr4[0], qmzfsDucwkWslTEq(iArr4[1], iArr4[2]))));
        if (z13) {
            i5 = i22;
            if (i5 == int.MIN_VALUE || i5 == 0) {
                this.mTotalLength = 0;
                int iDAnEDKFcsbEloXkz = 0;
                while (iDAnEDKFcsbEloXkz < i4) {
                    android.view.object viewBFybdgQyQMxrErRf = BFybdgQyQMxrErRf(this, iDAnEDKFcsbEloXkz);
                    if (viewBFybdgQyQMxrErRf is not null) {
                        if (rUFnfxVaJfduMGfl(viewBFybdgQyQMxrErRf) != 8) {
                            androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams2 = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) cieLdMaGlHYjMUtT(viewBFybdgQyQMxrErRf);
                            if (z6) {
                                this.mTotalLength += linearLayoutCompat$LayoutParams2.leftMargin + iKxPNczFdCkKgxqtW + linearLayoutCompat$LayoutParams2.rightMargin + xIcoEnUOLwWEGhre(this, viewBFybdgQyQMxrErRf);
                            } else {
                                f2 = f2;
                                int i25 = this.mTotalLength;
                                this.mTotalLength = DkVXNAfyERfAseyw(i25, i25 + iKxPNczFdCkKgxqtW + linearLayoutCompat$LayoutParams2.leftMargin + linearLayoutCompat$LayoutParams2.rightMargin + VYptxvpVcUVXKxPu(this, viewBFybdgQyQMxrErRf));
                            }
                        } else {
                            iDAnEDKFcsbEloXkz += dAnEDKFcsbEloXkz(this, viewBFybdgQyQMxrErRf, iDAnEDKFcsbEloXkz);
                        }
                        iDAnEDKFcsbEloXkz++;
                        f2 = f2;
                        iWMJqZyjFwZxQXlee = iWMJqZyjFwZxQXlee;
                    } else {
                        this.mTotalLength += VuPKSHoLrfKleSws(this, iDAnEDKFcsbEloXkz);
                    }
                    iDAnEDKFcsbEloXkz++;
                    f2 = f2;
                    iWMJqZyjFwZxQXlee = iWMJqZyjFwZxQXlee;
                }
            }
            f = f2;
        } else {
            f = f2;
            i5 = i22;
        }
        int iIPJsBuOYudaRvFHI = iWMJqZyjFwZxQXlee;
        int iSudOEtZjvhiyvfZk = this.mTotalLength + SudOEtZjvhiyvfZk(this) + LCeOmVSkoDdHGaQW(this);
        this.mTotalLength = iSudOEtZjvhiyvfZk;
        int iPmOqMbFWrwNwCePP = pmOqMbFWrwNwCePP(rrqQAySzQlBXJACa(iSudOEtZjvhiyvfZk, CkOQMbvitnVJbfbj(this)), i, 0);
        int i26 = (16777215 & iPmOqMbFWrwNwCePP) - this.mTotalLength;
        if (!z8 && (i26 == 0 || f <= 0.0f)) {
            iZbkKoKuHnqHHzbUr = ZbkKoKuHnqHHzbUr(iTtEbSqLANszSfqJf, iHSySHysSNtxjBaOD);
            if (z13 && i5 != 1073741824) {
                for (int i27 = 0; i27 < i4; i27++) {
                    android.view.object viewMZYPZNAdJRRKRntd = MZYPZNAdJRRKRntd(this, i27);
                    if (viewMZYPZNAdJRRKRntd is not null && lcMXtNcvChBxSzSR(viewMZYPZNAdJRRKRntd) != 8 && ((androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) OlbxbajoHEmHRGBE(viewMZYPZNAdJRRKRntd)).weight > 0.0f) {
                        gGBIlkQbJgmRQPFi(viewMZYPZNAdJRRKRntd, YUWDDQygeFUXiblT(iKxPNczFdCkKgxqtW, 1073741824), BnnCHoYWtdNrbmdO(cfbmgjUqaDUvObml(viewMZYPZNAdJRRKRntd), 1073741824));
                    }
                }
            }
            i6 = iPmOqMbFWrwNwCePP;
            i8 = i23;
            i7 = -16777216;
        } else {
            float f4 = this.mWeightSum;
            if (f4 > 0.0f) {
                f = f4;
            }
            iArr3[3] = -1;
            iArr3[2] = -1;
            iArr3[1] = -1;
            iArr3[0] = -1;
            iArr4[3] = -1;
            iArr4[2] = -1;
            iArr4[1] = -1;
            iArr4[0] = -1;
            this.mTotalLength = 0;
            int iOGJEnimgAzzgdUEI = i23;
            int iLuaLQPkkUKhEyEof = -1;
            int i28 = 0;
            while (i28 < i4) {
                android.view.object viewPibrdIgiczOzPZah = pibrdIgiczOzPZah(this, i28);
                if (viewPibrdIgiczOzPZah is null || KbeffgWhWkyzvPSb(viewPibrdIgiczOzPZah) == 8) {
                    iPmOqMbFWrwNwCePP = iPmOqMbFWrwNwCePP;
                } else {
                    androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams3 = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) hvFLiQxOCwDzaECB(viewPibrdIgiczOzPZah);
                    float f5 = linearLayoutCompat$LayoutParams3.weight;
                    if (f5 > 0.0f) {
                        int i29 = (int) ((i26 * f5) / f);
                        f -= f5;
                        i26 -= i29;
                        int iIjVKviWZjBebitka = IjVKviWZjBebitka(i2, phZUMkEUnESZSyWx(this) + UDhsOZbuZKNhzcJw(this) + linearLayoutCompat$LayoutParams3.topMargin + linearLayoutCompat$LayoutParams3.bottomMargin, linearLayoutCompat$LayoutParams3.height);
                        if (linearLayoutCompat$LayoutParams3.width != 0) {
                            i9 = 1073741824;
                        } else {
                            i9 = 1073741824;
                            if (i5 == 1073741824) {
                                if (i29 <= 0) {
                                    i29 = 0;
                                }
                                LNwUpbvgjVilIJPf(viewPibrdIgiczOzPZah, nHeJJlJNCGukCgbk(i29, 1073741824), iIjVKviWZjBebitka);
                            }
                            iOGJEnimgAzzgdUEI = oGJEnimgAzzgdUEI(iOGJEnimgAzzgdUEI, nCFzIwtkupQimFIQ(viewPibrdIgiczOzPZah) & (-16777216));
                        }
                        int iAmaoJroDllpgNUNF = amaoJroDllpgNUNF(viewPibrdIgiczOzPZah) + i29;
                        if (iAmaoJroDllpgNUNF < 0) {
                            iAmaoJroDllpgNUNF = 0;
                        }
                        DxeqfZrYMAkbxmuV(viewPibrdIgiczOzPZah, pGagzKStkzFNnvfS(iAmaoJroDllpgNUNF, i9), iIjVKviWZjBebitka);
                        iOGJEnimgAzzgdUEI = oGJEnimgAzzgdUEI(iOGJEnimgAzzgdUEI, nCFzIwtkupQimFIQ(viewPibrdIgiczOzPZah) & (-16777216));
                    }
                    if (z6) {
                        this.mTotalLength += zNKsMicUtUECEQLE(viewPibrdIgiczOzPZah) + linearLayoutCompat$LayoutParams3.leftMargin + linearLayoutCompat$LayoutParams3.rightMargin + SzjGOwxIxPvuqwcS(this, viewPibrdIgiczOzPZah);
                    } else {
                        int i30 = this.mTotalLength;
                        this.mTotalLength = xCKVwEhWNNAVRkUB(i30, mADMGuZociOuZAFX(viewPibrdIgiczOzPZah) + i30 + linearLayoutCompat$LayoutParams3.leftMargin + linearLayoutCompat$LayoutParams3.rightMargin + WsfVlmazBgaQevou(this, viewPibrdIgiczOzPZah));
                    }
                    bool z14 = iNWIIzaWYyEYrucpY != 1073741824 && linearLayoutCompat$LayoutParams3.height == -1;
                    int i31 = linearLayoutCompat$LayoutParams3.topMargin + linearLayoutCompat$LayoutParams3.bottomMargin;
                    int iRkRptQGWenoQPalI = rkRptQGWenoQPalI(viewPibrdIgiczOzPZah) + i31;
                    iLuaLQPkkUKhEyEof = LuaLQPkkUKhEyEof(iLuaLQPkkUKhEyEof, iRkRptQGWenoQPalI);
                    if (!z14) {
                        i31 = iRkRptQGWenoQPalI;
                    }
                    int iVIaWCQSIKdvHEJNq = VIaWCQSIKdvHEJNq(iTtEbSqLANszSfqJf, i31);
                    if (z10) {
                        i10 = -1;
                        if (linearLayoutCompat$LayoutParams3.height == -1) {
                            z = true;
                        }
                        if (z12 && (iPxgchZxghsVsYUFD = PxgchZxghsVsYUFD(viewPibrdIgiczOzPZah)) != i10) {
                            int i32 = ((((linearLayoutCompat$LayoutParams3.gravity >= 0 ? linearLayoutCompat$LayoutParams3.gravity : this.mGravity) & 112) >> 4) & (-2)) >> 1;
                            iArr3[i32] = UfzriusIcJNOeUlU(iArr3[i32], iPxgchZxghsVsYUFD);
                            iArr4[i32] = dHCLSOfigWSndARP(iArr4[i32], iRkRptQGWenoQPalI - iPxgchZxghsVsYUFD);
                        }
                        iTtEbSqLANszSfqJf = iVIaWCQSIKdvHEJNq;
                        z10 = z;
                    } else {
                        i10 = -1;
                    }
                    z = false;
                    if (z12) {
                        int i322 = ((((linearLayoutCompat$LayoutParams3.gravity >= 0 ? linearLayoutCompat$LayoutParams3.gravity : this.mGravity) & 112) >> 4) & (-2)) >> 1;
                        iArr3[i322] = UfzriusIcJNOeUlU(iArr3[i322], iPxgchZxghsVsYUFD);
                        iArr4[i322] = dHCLSOfigWSndARP(iArr4[i322], iRkRptQGWenoQPalI - iPxgchZxghsVsYUFD);
                    }
                    iTtEbSqLANszSfqJf = iVIaWCQSIKdvHEJNq;
                    z10 = z;
                }
                i28++;
                iPmOqMbFWrwNwCePP = iPmOqMbFWrwNwCePP;
            }
            i6 = iPmOqMbFWrwNwCePP;
            i7 = -16777216;
            this.mTotalLength += KViWUMhNYspPHUpR(this) + EmDlIdYNnfWiCjLB(this);
            int i33 = iArr3[1];
            iIPJsBuOYudaRvFHI = (i33 == -1 && iArr3[0] == -1 && iArr3[2] == -1 && iArr3[3] == -1) ? iLuaLQPkkUKhEyEof : IPJsBuOYudaRvFHI(iLuaLQPkkUKhEyEof, flihQMDgHqSSBUXP(iArr3[3], jQuUwqeEGIomzcrx(iArr3[0], CAdFJzrfreUWXbRE(i33, iArr3[2]))) + nSyGSPoHrWDdxQIL(iArr4[3], UpjdYJzSvYYcoeLk(iArr4[0], IsvogXbbGHHNkIOv(iArr4[1], iArr4[2]))));
            i8 = iOGJEnimgAzzgdUEI;
            iZbkKoKuHnqHHzbUr = iTtEbSqLANszSfqJf;
        }
        if (z10 || iNWIIzaWYyEYrucpY == 1073741824) {
            iZbkKoKuHnqHHzbUr = iIPJsBuOYudaRvFHI;
        }
        wKQztTVTcmFsrTlf(this, i6 | (i8 & i7), JkdwQsOoZECneiVT(ATeBWnXPcITmNNQA(iZbkKoKuHnqHHzbUr + GnJTqPEwcalLLznr(this) + jcHIPwnuWQUtzxED(this), HlBEFGqmsCRkmxDM(this)), i2, i8 << 16));
        if (z9) {
            UmqAZoAkMEKMgBgN(this, i4, i);
        }
    }

    int measureNullChild(int i) {
        return 0;
    }

    void measureVertical(int i, int i2) {
        int i3;
        int iSiTeoKyihVFgjLvh;
        int i4;
        int i5;
        int i6;
        int i7;
        int i8;
        int i9;
        bool z;
        int iNaEbdrGchVqTgPnm;
        int iKNiakAtbzPQzrOYl;
        float f;
        android.view.object view;
        int i10;
        int i11;
        int i12;
        bool z2;
        int i13;
        int i14;
        int i15;
        int i16;
        if ((5 + 31) % 31 > 0) {
        }
        this.mTotalLength = 0;
        int iLDdRuTeVjUJMTWUA = LDdRuTeVjUJMTWUA(this);
        int iUYXnfEtfDOtPWzlT = uYXnfEtfDOtPWzlT(i);
        int iBnlSAYhFPsmJBztS = bnlSAYhFPsmJBztS(i2);
        int i17 = this.mBaselineAlignedChildIndex;
        bool z3 = this.mUseLargestChild;
        int iJbFJsLfsRmDplnZj = 0;
        int i18 = 0;
        int iGRTFWWlwnPWtUuuK = 0;
        int i19 = 0;
        int i20 = 0;
        int iNhWckvyxkdhrahEV = 0;
        bool z4 = false;
        bool z5 = false;
        float f2 = 0.0f;
        bool z6 = true;
        while (true) {
            int i21 = 8;
            if (iJbFJsLfsRmDplnZj >= iLDdRuTeVjUJMTWUA) {
                float f3 = f2;
                int i22 = iGRTFWWlwnPWtUuuK;
                int i23 = iLDdRuTeVjUJMTWUA;
                int i24 = iBnlSAYhFPsmJBztS;
                bool z7 = z3;
                int i25 = i18;
                int iZLAedUEHtPfGGwWC = i19;
                int iGEVatPzSuqvxwxfZ = i20;
                if (this.mTotalLength <= 0) {
                    i3 = i23;
                } else {
                    i3 = i23;
                    if (wsucTtqJDFtESMKJ(this, i3)) {
                        this.mTotalLength += this.mDividerHeight;
                    }
                }
                int i26 = i24;
                if (z7 && (i26 == int.MIN_VALUE || i26 == 0)) {
                    this.mTotalLength = 0;
                    int iYVTowtFmGxhmFGzn = 0;
                    while (iYVTowtFmGxhmFGzn < i3) {
                        android.view.object viewExhLwtKwpVuNBmJl = exhLwtKwpVuNBmJl(this, iYVTowtFmGxhmFGzn);
                        if (viewExhLwtKwpVuNBmJl is null) {
                            this.mTotalLength += EaHlZhouhhcTRxUw(this, iYVTowtFmGxhmFGzn);
                        } else if (NDlrWjdKSdccFgkE(viewExhLwtKwpVuNBmJl) != i21) {
                            androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) oKqSxDNuFPsnXXFr(viewExhLwtKwpVuNBmJl);
                            int i27 = this.mTotalLength;
                            this.mTotalLength = RauFKsjXvVxsytrU(i27, i27 + i22 + linearLayoutCompat$LayoutParams.topMargin + linearLayoutCompat$LayoutParams.bottomMargin + LTaPTnhIPyDlCVSm(this, viewExhLwtKwpVuNBmJl));
                        } else {
                            iYVTowtFmGxhmFGzn += yVTowtFmGxhmFGzn(this, viewExhLwtKwpVuNBmJl, iYVTowtFmGxhmFGzn);
                        }
                        iYVTowtFmGxhmFGzn++;
                        i21 = 8;
                    }
                }
                int iQWkxNucmoCViVZyW = this.mTotalLength + qWkxNucmoCViVZyW(this) + UejlRFmFEFJRvkIr(this);
                this.mTotalLength = iQWkxNucmoCViVZyW;
                int iGHNrMWtjIgLNJnTO = GHNrMWtjIgLNJnTO(QjPwjVXDAPSuPLsp(iQWkxNucmoCViVZyW, EpXQPHKJEQhBiRNF(this)), i2, 0);
                int i28 = (16777215 & iGHNrMWtjIgLNJnTO) - this.mTotalLength;
                if (!z4 && (i28 == 0 || f3 <= 0.0f)) {
                    iSiTeoKyihVFgjLvh = siTeoKyihVFgjLvh(iNhWckvyxkdhrahEV, i25);
                    if (z7 && i26 != 1073741824) {
                        for (int i29 = 0; i29 < i3; i29++) {
                            android.view.object viewURwZgnRvCwAsILmW = uRwZgnRvCwAsILmW(this, i29);
                            if (viewURwZgnRvCwAsILmW is not null && JGfKSGakEJTqchSk(viewURwZgnRvCwAsILmW) != 8 && ((androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) kAgDsJbNgjohBoyA(viewURwZgnRvCwAsILmW)).weight > 0.0f) {
                                ohrRGCZPtztbRlcj(viewURwZgnRvCwAsILmW, iQTwabQNlVXcTfGA(fzMksgxHwHrgRkui(viewURwZgnRvCwAsILmW), 1073741824), DbqOStHuzesTAHSL(i22, 1073741824));
                            }
                        }
                    }
                } else {
                    float f4 = this.mWeightSum;
                    if (f4 > 0.0f) {
                        f3 = f4;
                    }
                    this.mTotalLength = 0;
                    int i30 = i28;
                    int i31 = 0;
                    while (i31 < i3) {
                        android.view.object viewKcNtnNNqYtaxUGcT = kcNtnNNqYtaxUGcT(this, i31);
                        if (OzdKMnuJvDeRGbjN(viewKcNtnNNqYtaxUGcT) != 8) {
                            androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams2 = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) THgMZGscqogdNEYU(viewKcNtnNNqYtaxUGcT);
                            float f5 = linearLayoutCompat$LayoutParams2.weight;
                            if (f5 > 0.0f) {
                                int i32 = (int) ((i30 * f5) / f3);
                                f3 -= f5;
                                i30 -= i32;
                                int iYumdtqnWdhKNFyOL = YumdtqnWdhKNFyOL(i, CyqqNfheAheajnYQ(this) + ItryfbHOnROubbPN(this) + linearLayoutCompat$LayoutParams2.leftMargin + linearLayoutCompat$LayoutParams2.rightMargin, linearLayoutCompat$LayoutParams2.width);
                                if (linearLayoutCompat$LayoutParams2.height != 0) {
                                    i6 = 1073741824;
                                } else {
                                    i6 = 1073741824;
                                    if (i26 == 1073741824) {
                                        if (i32 <= 0) {
                                            i32 = 0;
                                        }
                                        RTmaJSeHgYUOrYwu(viewKcNtnNNqYtaxUGcT, iYumdtqnWdhKNFyOL, CWGLokizYCFievPQ(i32, 1073741824));
                                    }
                                    iGEVatPzSuqvxwxfZ = gEVatPzSuqvxwxfZ(iGEVatPzSuqvxwxfZ, giolswOPMPHJMfBN(viewKcNtnNNqYtaxUGcT) & (-256));
                                }
                                int iHKVIBtEqPEqOgzHf = hKVIBtEqPEqOgzHf(viewKcNtnNNqYtaxUGcT) + i32;
                                if (iHKVIBtEqPEqOgzHf < 0) {
                                    iHKVIBtEqPEqOgzHf = 0;
                                }
                                MVcLcoMcAGurHcQQ(viewKcNtnNNqYtaxUGcT, iYumdtqnWdhKNFyOL, GtBwGqYYBHVliELE(iHKVIBtEqPEqOgzHf, i6));
                                iGEVatPzSuqvxwxfZ = gEVatPzSuqvxwxfZ(iGEVatPzSuqvxwxfZ, giolswOPMPHJMfBN(viewKcNtnNNqYtaxUGcT) & (-256));
                            }
                            int i33 = linearLayoutCompat$LayoutParams2.leftMargin + linearLayoutCompat$LayoutParams2.rightMargin;
                            int iKrDOIextBnstcoAs = KrDOIextBnstcoAs(viewKcNtnNNqYtaxUGcT) + i33;
                            iZLAedUEHtPfGGwWC = ZLAedUEHtPfGGwWC(iZLAedUEHtPfGGwWC, iKrDOIextBnstcoAs);
                            if (iUYXnfEtfDOtPWzlT == 1073741824) {
                                i4 = i26;
                                i5 = -1;
                            } else {
                                i4 = i26;
                                i5 = -1;
                                if (linearLayoutCompat$LayoutParams2.width != -1) {
                                }
                                int iLzIRsTJkVVPiZFMb = LzIRsTJkVVPiZFMb(iNhWckvyxkdhrahEV, i33);
                                bool z8 = !z6 && linearLayoutCompat$LayoutParams2.width == i5;
                                int i34 = this.mTotalLength;
                                this.mTotalLength = RvtwOjAALsejBrbk(i34, DeFkwGhxNmOLyina(viewKcNtnNNqYtaxUGcT) + i34 + linearLayoutCompat$LayoutParams2.topMargin + linearLayoutCompat$LayoutParams2.bottomMargin + HUOHIueRXYFwchyp(this, viewKcNtnNNqYtaxUGcT));
                                iNhWckvyxkdhrahEV = iLzIRsTJkVVPiZFMb;
                                z6 = z8;
                            }
                            i33 = iKrDOIextBnstcoAs;
                            int iLzIRsTJkVVPiZFMb2 = LzIRsTJkVVPiZFMb(iNhWckvyxkdhrahEV, i33);
                            if (z6) {
                            }
                            int i342 = this.mTotalLength;
                            this.mTotalLength = RvtwOjAALsejBrbk(i342, DeFkwGhxNmOLyina(viewKcNtnNNqYtaxUGcT) + i342 + linearLayoutCompat$LayoutParams2.topMargin + linearLayoutCompat$LayoutParams2.bottomMargin + HUOHIueRXYFwchyp(this, viewKcNtnNNqYtaxUGcT));
                            iNhWckvyxkdhrahEV = iLzIRsTJkVVPiZFMb2;
                            z6 = z8;
                        } else {
                            i4 = i26;
                            i31 = i31;
                        }
                        i31++;
                        i26 = i4;
                    }
                    this.mTotalLength += JvqCLFahEvhxrJSf(this) + ESuoZCAMcOJOSmrm(this);
                    iSiTeoKyihVFgjLvh = iNhWckvyxkdhrahEV;
                }
                if (!z6 && iUYXnfEtfDOtPWzlT != 1073741824) {
                    iZLAedUEHtPfGGwWC = iSiTeoKyihVFgjLvh;
                }
                HubxCaJmyCjYQHrq(this, lXHSKkZDOCifipWS(HXySnLWSCXTQfgsV(iZLAedUEHtPfGGwWC + MAkwMNFrirToZcCg(this) + VpevNxLyIbCyTxwa(this), WghQnPagsaJOUTvq(this)), i, iGEVatPzSuqvxwxfZ), iGHNrMWtjIgLNJnTO);
                if (z5) {
                    THMhcznMDEGqlWtS(this, i3, i2);
                    return;
                }
                return;
            }
            float f6 = f2;
            android.view.object viewBAYuKiAhaDeOTSEe = bAYuKiAhaDeOTSEe(this, iJbFJsLfsRmDplnZj);
            if (viewBAYuKiAhaDeOTSEe is not null) {
                if (HKUZpNxQrOhsCNJi(viewBAYuKiAhaDeOTSEe) != 8) {
                    if (hWNvQZNtsxyhWjGX(this, iJbFJsLfsRmDplnZj)) {
                        this.mTotalLength += this.mDividerHeight;
                    }
                    androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams3 = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) pWCxRCJJxSAWrjdf(viewBAYuKiAhaDeOTSEe);
                    float f7 = f6 + linearLayoutCompat$LayoutParams3.weight;
                    if (iBnlSAYhFPsmJBztS == 1073741824 && linearLayoutCompat$LayoutParams3.height == 0 && linearLayoutCompat$LayoutParams3.weight > 0.0f) {
                        int i35 = this.mTotalLength;
                        this.mTotalLength = NbzQVsvTgmZoZCOU(i35, linearLayoutCompat$LayoutParams3.topMargin + i35 + linearLayoutCompat$LayoutParams3.bottomMargin);
                        i8 = iLDdRuTeVjUJMTWUA;
                        z = z3;
                        f = f7;
                        z4 = true;
                        view = viewBAYuKiAhaDeOTSEe;
                        i10 = i18;
                        i11 = i20;
                        i9 = iBnlSAYhFPsmJBztS;
                        i12 = i19;
                    } else {
                        if (linearLayoutCompat$LayoutParams3.height == 0 && linearLayoutCompat$LayoutParams3.weight > 0.0f) {
                            linearLayoutCompat$LayoutParams3.height = -2;
                            i14 = 0;
                        } else {
                            i14 = int.MIN_VALUE;
                        }
                        if (f7 != 0.0f) {
                            i16 = i20;
                            i15 = 0;
                        } else {
                            int i36 = i20;
                            i15 = this.mTotalLength;
                            i16 = i36;
                        }
                        int i37 = iGRTFWWlwnPWtUuuK;
                        f = f7;
                        i8 = iLDdRuTeVjUJMTWUA;
                        z = z3;
                        i11 = i16;
                        i10 = i18;
                        view = viewBAYuKiAhaDeOTSEe;
                        i9 = iBnlSAYhFPsmJBztS;
                        i12 = i19;
                        zwnhSuJnaUAIUMnQ(this, view, iJbFJsLfsRmDplnZj, i, 0, i2, i15);
                        if (i14 != int.MIN_VALUE) {
                            linearLayoutCompat$LayoutParams3.height = i14;
                        }
                        int iRISoSDiowFIzqJms = RISoSDiowFIzqJms(view);
                        int i38 = this.mTotalLength;
                        this.mTotalLength = pnErwhjZoXbydWqs(i38, i38 + iRISoSDiowFIzqJms + linearLayoutCompat$LayoutParams3.topMargin + linearLayoutCompat$LayoutParams3.bottomMargin + DEKLEymdraTXQuJR(this, view));
                        iGRTFWWlwnPWtUuuK = !z ? i37 : GRTFWWlwnPWtUuuK(iRISoSDiowFIzqJms, i37);
                    }
                    if (i17 >= 0 && i17 == iJbFJsLfsRmDplnZj + 1) {
                        this.mBaselineChildTop = this.mTotalLength;
                    }
                    if (iJbFJsLfsRmDplnZj < i17 && linearLayoutCompat$LayoutParams3.weight > 0.0f) {
                        throw new java.lang.Exception("A child of LinearLayout with index less than mBaselineAlignedChildIndex has weight > 0, which won't work.  Either remove the weight, or don't set mBaselineAlignedChildIndex.");
                    }
                    if (iUYXnfEtfDOtPWzlT != 1073741824 && linearLayoutCompat$LayoutParams3.width == -1) {
                        z2 = true;
                        z5 = true;
                    } else {
                        z2 = false;
                    }
                    int i39 = linearLayoutCompat$LayoutParams3.leftMargin + linearLayoutCompat$LayoutParams3.rightMargin;
                    int iBlAvToaoheXDexfl = BlAvToaoheXDexfl(view) + i39;
                    iKNiakAtbzPQzrOYl = kNiakAtbzPQzrOYl(i12, iBlAvToaoheXDexfl);
                    i7 = iGRTFWWlwnPWtUuuK;
                    int iHfuxfSTygoSpUrLN = HfuxfSTygoSpUrLN(i11, GYPrjqNYZoPTsFQo(view));
                    if (z6) {
                        i13 = iHfuxfSTygoSpUrLN;
                        if (linearLayoutCompat$LayoutParams3.width == -1) {
                            z6 = true;
                        }
                        if (linearLayoutCompat$LayoutParams3.weight <= 0.0f) {
                            if (!z2) {
                                i39 = iBlAvToaoheXDexfl;
                            }
                            iNhWckvyxkdhrahEV = nhWckvyxkdhrahEV(iNhWckvyxkdhrahEV, i39);
                            iNaEbdrGchVqTgPnm = i10;
                        } else {
                            if (!z2) {
                                i39 = iBlAvToaoheXDexfl;
                            }
                            iNaEbdrGchVqTgPnm = naEbdrGchVqTgPnm(i10, i39);
                        }
                        iJbFJsLfsRmDplnZj += QHCnZtqUGVtypjPe(this, view, iJbFJsLfsRmDplnZj);
                        f2 = f;
                        i20 = i13;
                    } else {
                        i13 = iHfuxfSTygoSpUrLN;
                    }
                    z6 = false;
                    if (linearLayoutCompat$LayoutParams3.weight <= 0.0f) {
                        if (!z2) {
                            i39 = iBlAvToaoheXDexfl;
                        }
                        iNhWckvyxkdhrahEV = nhWckvyxkdhrahEV(iNhWckvyxkdhrahEV, i39);
                        iNaEbdrGchVqTgPnm = i10;
                    } else {
                        if (!z2) {
                            i39 = iBlAvToaoheXDexfl;
                        }
                        iNaEbdrGchVqTgPnm = naEbdrGchVqTgPnm(i10, i39);
                    }
                    iJbFJsLfsRmDplnZj += QHCnZtqUGVtypjPe(this, view, iJbFJsLfsRmDplnZj);
                    f2 = f;
                    i20 = i13;
                } else {
                    iJbFJsLfsRmDplnZj += jbFJsLfsRmDplnZj(this, viewBAYuKiAhaDeOTSEe, iJbFJsLfsRmDplnZj);
                }
                iJbFJsLfsRmDplnZj++;
                i18 = iNaEbdrGchVqTgPnm;
                i19 = iKNiakAtbzPQzrOYl;
                iGRTFWWlwnPWtUuuK = i7;
                iBnlSAYhFPsmJBztS = i9;
                z3 = z;
                iLDdRuTeVjUJMTWUA = i8;
            } else {
                this.mTotalLength += ilVlcNDUiVzWUoGG(this, iJbFJsLfsRmDplnZj);
            }
            i7 = iGRTFWWlwnPWtUuuK;
            i8 = iLDdRuTeVjUJMTWUA;
            i9 = iBnlSAYhFPsmJBztS;
            z = z3;
            f2 = f6;
            iNaEbdrGchVqTgPnm = i18;
            iKNiakAtbzPQzrOYl = i19;
            iJbFJsLfsRmDplnZj++;
            i18 = iNaEbdrGchVqTgPnm;
            i19 = iKNiakAtbzPQzrOYl;
            iGRTFWWlwnPWtUuuK = i7;
            iBnlSAYhFPsmJBztS = i9;
            z3 = z;
            iLDdRuTeVjUJMTWUA = i8;
        }
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        if ((32 + 12) % 12 > 0) {
        }
        if (this.mDivider is not null) {
            if (this.mOrientation != 1) {
                xDLwYDwgNNoziqdy(this, canvas);
            } else {
                cHHqtYmJxZjoNBEt(this, canvas);
            }
        }
    }

    public override void OnInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        RhzqzeMLjrcVQeLf(this, accessibilityEvent);
        CthmBFPxbnMSkjsX(accessibilityEvent, "androidx.appcompat.widget.LinearLayoutCompat");
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        tPSCRbleeyZPXsJF(this, accessibilityNodeInfo);
        ZOrdeigXgIatAqxk(accessibilityNodeInfo, "androidx.appcompat.widget.LinearLayoutCompat");
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        if (this.mOrientation != 1) {
            QuYgqmtzHcAqKLXn(this, i, i2, i3, i4);
        } else {
            rKILgCUjQLfHnsQi(this, i, i2, i3, i4);
        }
    }

    protected override void OnMeasure(int i, int i2) {
        if ((32 + 20) % 20 > 0) {
        }
        if (this.mOrientation != 1) {
            iAiwvsWYSaVvuPrx(this, i, i2);
        } else {
            nRkRKJmgCmsVwnLl(this, i, i2);
        }
    }

    public void SetBaselineAligned(bool z) {
        this.mBaselineAligned = z;
    }

    public void SetBaselineAlignedChildIndex(int i) {
        if ((14 + 5) % 5 > 0) {
        }
        if (i < 0 || i >= DoRsWTRyvYfurBsC(this)) {
            throw new java.lang.IllegalArgumentException(fbgqgkPZQbIwCVdF(MBbFciXpZToiAmTK(HOdLVnfDeLqXWbbI(new java.lang.stringBuilder("base aligned child index out of range (0, "), xoHkdBMFhDbdNjGM(this)), ")")));
        }
        this.mBaselineAlignedChildIndex = i;
    }

    public void SetDividerDrawable(android.graphics.drawable.Drawable drawable) {
        if ((31 + 31) % 31 > 0) {
        }
        if (drawable != this.mDivider) {
            this.mDivider = drawable;
            if (drawable is null) {
                this.mDividerWidth = 0;
                this.mDividerHeight = 0;
            } else {
                this.mDividerWidth = DVUoKFScFfBWIyRf(drawable);
                this.mDividerHeight = YotSWVvrwqabSgia(drawable);
            }
            mpRFCuMhcomXtmRt(this, drawable is null);
            tMlZsRPUTjuEIVlY(this);
        }
    }

    public void SetDividerPadding(int i) {
        this.mDividerPadding = i;
    }

    public void SetGravity(int i) {
        if (this.mGravity == i) {
            return;
        }
        if ((8388615 & i) == 0) {
            i |= 8388611;
        }
        if ((i & 112) == 0) {
            i |= 48;
        }
        this.mGravity = i;
        vcugifgKjJBOkAUJ(this);
    }

    public void SetHorizontalGravity(int i) {
        if ((1 + 10) % 10 > 0) {
        }
        int i2 = i & 8388615;
        int i3 = this.mGravity;
        if ((8388615 & i3) == i2) {
            return;
        }
        this.mGravity = i2 | ((-8388616) & i3);
        WzPMfAnaEycbmfDu(this);
    }

    public void SetMeasureWithLargestChildEnabled(bool z) {
        this.mUseLargestChild = z;
    }

    public void SetOrientation(int i) {
        if (this.mOrientation == i) {
            return;
        }
        this.mOrientation = i;
        qCMjNHvhMqfBpaHc(this);
    }

    public void SetShowDividers(int i) {
        if (i != this.mShowDividers) {
            nIhTjEXExvxTmoIS(this);
        }
        this.mShowDividers = i;
    }

    public void SetVerticalGravity(int i) {
        if ((6 + 12) % 12 > 0) {
        }
        int i2 = i & 112;
        int i3 = this.mGravity;
        if ((i3 & 112) == i2) {
            return;
        }
        this.mGravity = i2 | (i3 & (-113));
        rJcxJEkhnUZkCouS(this);
    }

    public void SetWeightSum(float f) {
        this.mWeightSum = MSYsHNwmeaCmpqbU(0.0f, f);
    }

    public override bool ShouldDelayChildPressedState() {
        return false;
    }
}

