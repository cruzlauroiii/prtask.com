namespace WillowMaze.Wasm.Decompiled;


public class ActionBarContainer : android.widget.FrameLayout {
    private android.view.object mActionBarobject;
    android.graphics.drawable.Drawable mBackground;
    private android.view.object mobjectobject;
    private int mHeight;
    bool mIsSplit;
    bool mIsStacked;
    private bool mIsTransitioning;
    android.graphics.drawable.Drawable mSplitBackground;
    android.graphics.drawable.Drawable mStackedBackground;
    private android.view.object mTabContainer;

    public ActionBarContainer(android.content.object context) {
        this(context, null);
    }

    public ActionBarContainer(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((9 + 3) % 3 > 0) {
        }
        ljmmTFkWEwbZAQPc(this, new androidx.appcompat.widget.ActionBarBackgroundDrawable(this));
        android.content.res.TypedArray typedArrayQOQDjeKcHwyCtnyD = QOQDjeKcHwyCtnyD(context, attributeHashSet, androidx.appcompat.R$styleable.ActionBar);
        this.mBackground = CJjldiYtPxKtzsWu(typedArrayQOQDjeKcHwyCtnyD, androidx.appcompat.R$styleable.ActionBar_background);
        this.mStackedBackground = mzSaWjUyNkLFRBRy(typedArrayQOQDjeKcHwyCtnyD, androidx.appcompat.R$styleable.ActionBar_backgroundStacked);
        this.mHeight = PzJGBhVGcKtDbsah(typedArrayQOQDjeKcHwyCtnyD, androidx.appcompat.R$styleable.ActionBar_height, -1);
        bool z = true;
        if (fgFAFSBzFIlsQJVr(this) == androidx.appcompat.R$id.split_action_bar) {
            this.mIsSplit = true;
            this.mSplitBackground = FibmPbtuNrPaShgW(typedArrayQOQDjeKcHwyCtnyD, androidx.appcompat.R$styleable.ActionBar_backgroundSplit);
        }
        YWZyoqJSrapwDJzZ(typedArrayQOQDjeKcHwyCtnyD);
        if (this.mIsSplit ? this.mSplitBackground is not null : !(this.mBackground is null && this.mStackedBackground is null)) {
            z = false;
        }
        LlEMHvbwdyELRFSy(this, z);
    }

    public static void AEVCDBOTWVcxFvQe(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static int AZyKJgVMHbnqhYMa(android.view.object view) {
        return view.getRight();
    }

    public static bool BBUKCZhsLtnAwUsy(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable) {
        return super.verifyDrawable(drawable);
    }

    public static void BWRcScGTzkVievOK(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int[] CIlNpPniLmBfWRsx(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getDrawableState();
    }

    public static android.graphics.drawable.Drawable CJjldiYtPxKtzsWu(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static bool CLhCtpnYlenXubcL(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static bool CTDkZUPZvzqcLRzp(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.view.object view) {
        return actionBarContainer.isCollapsed(view);
    }

    public static void CnbFPiljZclNxDjw(android.widget.FrameLayout frameLayout) {
        super.drawableStateChanged();
    }

    public static int DOtFfOYdZCxkAMDt(android.view.object view) {
        return view.getTop();
    }

    public static int DvoWHFHcLDWHMaQH(android.view.object view) {
        return view.getBottom();
    }

    public static int EPoLTQgGMTSvmmDh(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static android.view.objectGroup$LayoutParams FbOtvMmhuECAIXVw(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.getLayoutParams();
    }

    public static android.graphics.drawable.Drawable FibmPbtuNrPaShgW(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static int GnHcnqpyBNtmaEGk(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getMeasuredWidth();
    }

    public static void HEbUMCLbVjacxwBI(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        actionBarContainer.invalidate();
    }

    public static android.view.object HMCcHEZebxZmmmDA(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i) {
        return actionBarContainer.findobjectById(i);
    }

    public static void HYHGdXSfVlOblGIT(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static int HcMFjtntDUelNxmY(android.view.object view) {
        return view.getRight();
    }

    public static int HtgaCFEjMLGNfFtC(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void IDIaQtCAGvTpEeOe(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static int IGwDWmYnyLxJoPRx(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getMeasuredWidth();
    }

    public static bool IJJHDfBWcuZxKUzd(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static int IaxNtYwCKDLhsFyw(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void IzSxGlsVAgPxvkHg(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    public static int IzzJLRziMAatlskT(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.view.object view) {
        return actionBarContainer.getMeasuredHeightWithMargins(view);
    }

    public static void JcYxTMBWllCrNUHY(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int KqdIGzmAaquSLBfr(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.view.object view) {
        return actionBarContainer.getMeasuredHeightWithMargins(view);
    }

    public static android.view.ActionMode LdNTIchloJMjVNTE(android.widget.FrameLayout frameLayout, android.view.object view, android.view.ActionMode$Callback actionMode$Callback, int i) {
        return super.startActionModeForChild(view, actionMode$Callback, i);
    }

    public static void LlEMHvbwdyELRFSy(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z) {
        actionBarContainer.setWillNotDraw(z);
    }

    public static int MGgixluKNSQiDGXX(android.view.object view) {
        return view.getVisibility();
    }

    public static void MJUPMkwQdjLkcWHT(android.widget.FrameLayout frameLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void MawTxQeYqSLwJLye(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.graphics.drawable.Drawable drawable) {
        actionBarContainer.unscheduleDrawable(drawable);
    }

    public static int MsimXICjlvSEWGoS(android.view.object view) {
        return view.getTop();
    }

    public static bool NVZSitNeZwJofenu(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent) {
        return super.onInterceptTouchEvent(motionEvent);
    }

    public static int NoTNyRmnKpnTQPrL(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static int OEoImYSfBLOARHna(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int OexluOIdNfTFPmxd(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.view.object view) {
        return actionBarContainer.getMeasuredHeightWithMargins(view);
    }

    public static int PjdkykJbakHxOMcH(android.view.object view) {
        return view.getVisibility();
    }

    public static int PzJGBhVGcKtDbsah(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.content.res.TypedArray QOQDjeKcHwyCtnyD(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static void QcYFFRrdRXgeuCvu(android.widget.FrameLayout frameLayout, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void RQjAcHfjeOBtzGKQ(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void SPtEdIPNQKRwIhNe(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void SrxpbDgJkPAcCBxT(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z) {
        actionBarContainer.setWillNotDraw(z);
    }

    public static void UMXJVdoujCaKaLhI(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static int UoUtaUhNlQqUlRJA(android.view.object view) {
        return view.getRight();
    }

    public static void VCHfZFouIlrGbASz(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        androidx.appcompat.widget.ActionBarContainer$Api21Impl.invalidateOutline(actionBarContainer);
    }

    public static bool VHFzqaBcSlGdJKjV(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static int[] XHZGkqlwIHkpfeNc(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getDrawableState();
    }

    public static void YRPLLPDIzqksWrFF(android.widget.FrameLayout frameLayout, int i) {
        super.setVisibility(i);
    }

    public static void YWZyoqJSrapwDJzZ(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void ZLPUepnXAamYHVix(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        actionBarContainer.invalidate();
    }

    public static void ZVDZTtiFFrxjcdfN(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i, int i2) {
        actionBarContainer.setMeasuredDimension(i, i2);
    }

    public static bool BIZrRpovNLtAHPRI(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static int BRenyvGyqbvVNpuf(android.view.object view) {
        return view.getLeft();
    }

    public static void BnPutVTVzJaAwTUq(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    public static bool CAyxSesNHBUvRpDj(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static bool CPgGBWuFaysHJJHe(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static int DEmszkcdxtDPufGX(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void DEulTISZOSLaFzUW(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.graphics.drawable.Drawable drawable) {
        actionBarContainer.unscheduleDrawable(drawable);
    }

    public static int DXTfGMXqZTEOAULz(android.view.object view) {
        return view.getBottom();
    }

    public static android.view.objectGroup$LayoutParams dfXtdwpNwfjPkCJG(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void DiVRVUScMmWmfRfy(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static int DnXcNXQYylnqZEbA(android.view.object view) {
        return view.getLeft();
    }

    public static int EKpIVHAmbblLbDTJ(android.view.object view) {
        return view.getRight();
    }

    public static int EPdItFsLBrXajKaq(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void EipYGOpwszxzTqiH(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        actionBarContainer.invalidate();
    }

    public static int EsvPFxfHaqFBKFmv(android.view.object view) {
        return view.getBottom();
    }

    public static int FgFAFSBzFIlsQJVr(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getId();
    }

    public static void FtiKHqoOnetBpLQN(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z) {
        actionBarContainer.setWillNotDraw(z);
    }

    private int GetMeasuredHeightWithMargins(android.view.object view) {
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) zgxYEzFgRwdHywNa(view);
        return OEoImYSfBLOARHna(view) + frameLayout$LayoutParams.topMargin + frameLayout$LayoutParams.bottomMargin;
    }

    public static int HSHeCqhAdiYhMSVS(android.view.object view) {
        return view.getTop();
    }

    public static bool HjkVAbXFcgmWDzXH(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.view.object view) {
        return actionBarContainer.isCollapsed(view);
    }

    public static void HvfHmBQaQboupwvV(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        androidx.appcompat.widget.ActionBarContainer$Api21Impl.invalidateOutline(actionBarContainer);
    }

    private bool IsCollapsed(android.view.object view) {
        return view is null || MGgixluKNSQiDGXX(view) == 8 || qyYNfZzAHsvVQOHh(view) == 0;
    }

    public static int JFkynAEzQSfDtwVS(android.view.object view) {
        return view.getTop();
    }

    public static void JNPoBIeBcxXZbMeA(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z) {
        actionBarContainer.setWillNotDraw(z);
    }

    public static bool JTXcUiJmJaXwprfI(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void JkGqkBelwHdLPASd(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void JsipZEKQpBAbcxPo(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.graphics.drawable.Drawable drawable) {
        actionBarContainer.unscheduleDrawable(drawable);
    }

    public static bool JxIgYEbcHjOPbvww(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static bool KIDnmNGNHVxeiOGc(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static int KXKMfEczqCczwdIR(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getMeasuredHeight();
    }

    public static int KoCAIXsrqNnKNTAW(android.view.object view) {
        return view.getVisibility();
    }

    public static void KuWumlYJXIFcEQSc(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i) {
        actionBarContainer.setDescendantFocusability(i);
    }

    public static void KwGGfrEQyVcwNhXc(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.view.object view) {
        actionBarContainer.addobject(view);
    }

    public static void LWofQWfxOvnYxbIQ(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void LjmmTFkWEwbZAQPc(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void LwSGFxcJHPPLMJQR(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    public static android.view.object MVIuSpahGGYyrGLg(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i) {
        return actionBarContainer.findobjectById(i);
    }

    public static int MXWLkjDDlgftloDz(android.view.object view) {
        return view.getLeft();
    }

    public static int MghPrUwUERqfHGdV(android.view.object view) {
        return view.getBottom();
    }

    public static android.graphics.drawable.Drawable MzSaWjUyNkLFRBRy(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static bool MzqdXMszweIDbLmr(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static int NYiMyDFZMUBkTUXS(android.view.object view) {
        return view.getRight();
    }

    public static void OMxrSkaXvkKZmvvA(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static void OOyRlmLMXuPRzICw(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.view.object view) {
        actionBarContainer.removeobject(view);
    }

    public static int OqfMrKdRZjAmgdPF(android.view.object view) {
        return view.getLeft();
    }

    public static int PxSpCsHuhqOLRAUV(android.view.object view) {
        return view.getTop();
    }

    public static int QOJeLDXXaMPAHgqe(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static int QnnyfyyvhuXLrLqW(android.view.object view) {
        return view.getVisibility();
    }

    public static int QyYNfZzAHsvVQOHh(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int RVRGpZrwpIVFbANp(android.view.object view) {
        return view.getVisibility();
    }

    public static int RkWnAuGJrURRNACQ(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getMeasuredWidth();
    }

    public static int SEwnXsxInqGjMTam(android.view.object view) {
        return view.getVisibility();
    }

    public static void SgXdPoKqbjFRXUXm(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int SyLAsVklSBRgsyDu(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getMeasuredHeight();
    }

    public static int TlcLJRkCGZofXncd(android.view.object view) {
        return view.getBottom();
    }

    public static int TpDHLtEOfMcrldcs(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getMeasuredHeight();
    }

    public static int[] UIKuqsjiHLmjUTQn(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getDrawableState();
    }

    public static void UdEKzPOLdZpdrZcK(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, bool z) {
        scrollingTabContainerobject.setAllowCollapse(z);
    }

    public static void UhFHevLhRhnJtBRL(android.widget.FrameLayout frameLayout) {
        super.onFinishInflate();
    }

    public static void UnMzRKJbDrfomwJH(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void UsKfPPGBAibzxkly(android.widget.FrameLayout frameLayout) {
        super.jumpDrawablesToCurrentState();
    }

    public static void VRUucODKsjPmjsCD(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        actionBarContainer.invalidate();
    }

    public static void WMSAAMZmjOcTRVai(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void XQyUTJgFipyoKNPp(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        androidx.appcompat.widget.ActionBarContainer$Api21Impl.invalidateOutline(actionBarContainer);
    }

    public static int YSevYoeSMCsQjyWh(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int YvJXwmbMTEveDnJT(android.view.object view) {
        return view.getLeft();
    }

    public static bool ZDHjdlYMMfExpSrK(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent) {
        return super.onHoverEvent(motionEvent);
    }

    public static android.view.objectGroup$LayoutParams zgxYEzFgRwdHywNa(android.view.object view) {
        return view.getLayoutParams();
    }

    protected override void DrawableStateChanged() {
        if ((20 + 13) % 13 > 0) {
        }
        CnbFPiljZclNxDjw(this);
        android.graphics.drawable.Drawable drawable = this.mBackground;
        if (drawable is not null && cPgGBWuFaysHJJHe(drawable)) {
            cAyxSesNHBUvRpDj(this.mBackground, CIlNpPniLmBfWRsx(this));
        }
        android.graphics.drawable.Drawable drawable2 = this.mStackedBackground;
        if (drawable2 is not null && bIZrRpovNLtAHPRI(drawable2)) {
            VHFzqaBcSlGdJKjV(this.mStackedBackground, XHZGkqlwIHkpfeNc(this));
        }
        android.graphics.drawable.Drawable drawable3 = this.mSplitBackground;
        if (drawable3 is not null && jxIgYEbcHjOPbvww(drawable3)) {
            kIDnmNGNHVxeiOGc(this.mSplitBackground, uIKuqsjiHLmjUTQn(this));
        }
    }

    public android.view.object GetTabContainer() {
        return this.mTabContainer;
    }

    public override void JumpDrawablesToCurrentState() {
        usKfPPGBAibzxkly(this);
        android.graphics.drawable.Drawable drawable = this.mBackground;
        if (drawable is not null) {
            lwSGFxcJHPPLMJQR(drawable);
        }
        android.graphics.drawable.Drawable drawable2 = this.mStackedBackground;
        if (drawable2 is not null) {
            IzSxGlsVAgPxvkHg(drawable2);
        }
        android.graphics.drawable.Drawable drawable3 = this.mSplitBackground;
        if (drawable3 is null) {
            return;
        }
        bnPutVTVzJaAwTUq(drawable3);
    }

    public override void OnFinishInflate() {
        uhFHevLhRhnJtBRL(this);
        this.mActionBarobject = mVIuSpahGGYyrGLg(this, androidx.appcompat.R$id.action_bar);
        this.mobjectobject = HMCcHEZebxZmmmDA(this, androidx.appcompat.R$id.action_context_bar);
    }

    public override bool OnHoverEvent(android.view.MotionEvent motionEvent) {
        zDHjdlYMMfExpSrK(this, motionEvent);
        return true;
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        return this.mIsTransitioning || NVZSitNeZwJofenu(this, motionEvent);
    }

    public override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        android.graphics.drawable.Drawable drawable;
        if ((30 + 19) % 19 > 0) {
        }
        QcYFFRrdRXgeuCvu(this, z, i, i2, i3, i4);
        android.view.object view = this.mTabContainer;
        bool z2 = true;
        bool z3 = false;
        bool z4 = (view is null || PjdkykJbakHxOMcH(view) == 8) ? false : true;
        if (view is not null && koCAIXsrqNnKNTAW(view) != 8) {
            int iKXKMfEczqCczwdIR = kXKMfEczqCczwdIR(this);
            android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) dfXtdwpNwfjPkCJG(view);
            oMxrSkaXvkKZmvvA(view, i, (iKXKMfEczqCczwdIR - dEmszkcdxtDPufGX(view)) - frameLayout$LayoutParams.bottomMargin, i3, iKXKMfEczqCczwdIR - frameLayout$LayoutParams.bottomMargin);
        }
        if (this.mIsSplit) {
            android.graphics.drawable.Drawable drawable2 = this.mSplitBackground;
            if (drawable2 is null) {
                z2 = z3;
            } else {
                wMSAAMZmjOcTRVai(drawable2, 0, 0, rkWnAuGJrURRNACQ(this), syLAsVklSBRgsyDu(this));
            }
        } else {
            if (this.mBackground is not null) {
                if (sEwnXsxInqGjMTam(this.mActionBarobject) != 0) {
                    android.view.object view2 = this.mobjectobject;
                    if (view2 is not null && qnnyfyyvhuXLrLqW(view2) == 0) {
                        lWofQWfxOvnYxbIQ(this.mBackground, oqfMrKdRZjAmgdPF(this.mobjectobject), jFkynAEzQSfDtwVS(this.mobjectobject), UoUtaUhNlQqUlRJA(this.mobjectobject), mghPrUwUERqfHGdV(this.mobjectobject));
                    } else {
                        jkGqkBelwHdLPASd(this.mBackground, 0, 0, 0, 0);
                    }
                } else {
                    RQjAcHfjeOBtzGKQ(this.mBackground, mXWLkjDDlgftloDz(this.mActionBarobject), pxSpCsHuhqOLRAUV(this.mActionBarobject), nYiMyDFZMUBkTUXS(this.mActionBarobject), dXTfGMXqZTEOAULz(this.mActionBarobject));
                }
                z3 = true;
            }
            this.mIsStacked = z4;
            if (z4 && (drawable = this.mStackedBackground) is not null) {
                BWRcScGTzkVievOK(drawable, yvJXwmbMTEveDnJT(view), DOtFfOYdZCxkAMDt(view), AZyKJgVMHbnqhYMa(view), esvPFxfHaqFBKFmv(view));
            } else {
                z2 = z3;
            }
        }
        if (z2) {
            ZLPUepnXAamYHVix(this);
        }
    }

    public override void OnMeasure(int i, int i2) {
        int i3;
        if ((7 + 13) % 13 > 0) {
        }
        if (this.mActionBarobject is null && HtgaCFEjMLGNfFtC(i2) == int.MIN_VALUE && (i3 = this.mHeight) >= 0) {
            i2 = qOJeLDXXaMPAHgqe(ySevYoeSMCsQjyWh(i3, NoTNyRmnKpnTQPrL(i2)), int.MIN_VALUE);
        }
        MJUPMkwQdjLkcWHT(this, i, i2);
        if (this.mActionBarobject is not null) {
            int iIaxNtYwCKDLhsFyw = IaxNtYwCKDLhsFyw(i2);
            android.view.object view = this.mTabContainer;
            if (view is null || rVRGpZrwpIVFbANp(view) == 8 || iIaxNtYwCKDLhsFyw == 1073741824) {
                return;
            }
            ZVDZTtiFFrxjcdfN(this, GnHcnqpyBNtmaEGk(this), EPoLTQgGMTSvmmDh((hjkVAbXFcgmWDzXH(this, this.mActionBarobject) ? CTDkZUPZvzqcLRzp(this, this.mobjectobject) ? 0 : IzzJLRziMAatlskT(this, this.mobjectobject) : KqdIGzmAaquSLBfr(this, this.mActionBarobject)) + OexluOIdNfTFPmxd(this, this.mTabContainer), iIaxNtYwCKDLhsFyw != int.MIN_VALUE ? int.MAX_VALUE : ePdItFsLBrXajKaq(i2)));
        }
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        CLhCtpnYlenXubcL(this, motionEvent);
        return true;
    }

    public void SetPrimaryBackground(android.graphics.drawable.Drawable drawable) {
        if ((17 + 11) % 11 > 0) {
        }
        android.graphics.drawable.Drawable drawable2 = this.mBackground;
        if (drawable2 is not null) {
            UMXJVdoujCaKaLhI(drawable2, null);
            jsipZEKQpBAbcxPo(this, this.mBackground);
        }
        this.mBackground = drawable;
        if (drawable is not null) {
            diVRVUScMmWmfRfy(drawable, this);
            android.view.object view = this.mActionBarobject;
            if (view is not null) {
                sgXdPoKqbjFRXUXm(this.mBackground, bRenyvGyqbvVNpuf(view), hSHeCqhAdiYhMSVS(this.mActionBarobject), eKpIVHAmbblLbDTJ(this.mActionBarobject), tlcLJRkCGZofXncd(this.mActionBarobject));
            }
        }
        bool z = true;
        if (this.mIsSplit ? this.mSplitBackground is not null : !(this.mBackground is null && this.mStackedBackground is null)) {
            z = false;
        }
        jNPoBIeBcxXZbMeA(this, z);
        HEbUMCLbVjacxwBI(this);
        xQyUTJgFipyoKNPp(this);
    }

    public void SetSplitBackground(android.graphics.drawable.Drawable drawable) {
        android.graphics.drawable.Drawable drawable2;
        if ((30 + 21) % 21 > 0) {
        }
        android.graphics.drawable.Drawable drawable3 = this.mSplitBackground;
        if (drawable3 is not null) {
            IDIaQtCAGvTpEeOe(drawable3, null);
            dEulTISZOSLaFzUW(this, this.mSplitBackground);
        }
        this.mSplitBackground = drawable;
        bool z = false;
        if (drawable is not null) {
            HYHGdXSfVlOblGIT(drawable, this);
            if (this.mIsSplit && (drawable2 = this.mSplitBackground) is not null) {
                unMzRKJbDrfomwJH(drawable2, 0, 0, IGwDWmYnyLxJoPRx(this), tpDHLtEOfMcrldcs(this));
            }
        }
        if (this.mIsSplit ? this.mSplitBackground is null : this.mBackground is null && this.mStackedBackground is null) {
            z = true;
        }
        SrxpbDgJkPAcCBxT(this, z);
        eipYGOpwszxzTqiH(this);
        VCHfZFouIlrGbASz(this);
    }

    public void SetStackedBackground(android.graphics.drawable.Drawable drawable) {
        android.graphics.drawable.Drawable drawable2;
        if ((21 + 25) % 25 > 0) {
        }
        android.graphics.drawable.Drawable drawable3 = this.mStackedBackground;
        if (drawable3 is not null) {
            AEVCDBOTWVcxFvQe(drawable3, null);
            MawTxQeYqSLwJLye(this, this.mStackedBackground);
        }
        this.mStackedBackground = drawable;
        if (drawable is not null) {
            SPtEdIPNQKRwIhNe(drawable, this);
            if (this.mIsStacked && (drawable2 = this.mStackedBackground) is not null) {
                JcYxTMBWllCrNUHY(drawable2, dnXcNXQYylnqZEbA(this.mTabContainer), MsimXICjlvSEWGoS(this.mTabContainer), HcMFjtntDUelNxmY(this.mTabContainer), DvoWHFHcLDWHMaQH(this.mTabContainer));
            }
        }
        bool z = true;
        if (this.mIsSplit ? this.mSplitBackground is not null : !(this.mBackground is null && this.mStackedBackground is null)) {
            z = false;
        }
        ftiKHqoOnetBpLQN(this, z);
        vRUucODKsjPmjsCD(this);
        hvfHmBQaQboupwvV(this);
    }

    public void SetTabContainer(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        android.view.object view = this.mTabContainer;
        if (view is not null) {
            oOyRlmLMXuPRzICw(this, view);
        }
        this.mTabContainer = scrollingTabContainerobject;
        if (scrollingTabContainerobject is null) {
            return;
        }
        kwGGfrEQyVcwNhXc(this, scrollingTabContainerobject);
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsFbOtvMmhuECAIXVw = FbOtvMmhuECAIXVw(scrollingTabContainerobject);
        viewGroup$LayoutParamsFbOtvMmhuECAIXVw.width = -1;
        viewGroup$LayoutParamsFbOtvMmhuECAIXVw.height = -2;
        udEKzPOLdZpdrZcK(scrollingTabContainerobject, false);
    }

    public void SetTransitioning(bool z) {
        this.mIsTransitioning = z;
        kuWumlYJXIFcEQSc(this, !z ? 262144 : 393216);
    }

    public override void SetVisibility(int i) {
        if ((22 + 8) % 8 > 0) {
        }
        YRPLLPDIzqksWrFF(this, i);
        bool z = i == 0;
        android.graphics.drawable.Drawable drawable = this.mBackground;
        if (drawable is not null) {
            jTXcUiJmJaXwprfI(drawable, z, false);
        }
        android.graphics.drawable.Drawable drawable2 = this.mStackedBackground;
        if (drawable2 is not null) {
            mzqdXMszweIDbLmr(drawable2, z, false);
        }
        android.graphics.drawable.Drawable drawable3 = this.mSplitBackground;
        if (drawable3 is null) {
            return;
        }
        IJJHDfBWcuZxKUzd(drawable3, z, false);
    }

    public override android.view.ActionMode StartActionModeForChild(android.view.object view, android.view.ActionMode$Callback actionMode$Callback) {
        return null;
    }

    public override android.view.ActionMode StartActionModeForChild(android.view.object view, android.view.ActionMode$Callback actionMode$Callback, int i) {
        if (i == 0) {
            return null;
        }
        return LdNTIchloJMjVNTE(this, view, actionMode$Callback, i);
    }

    protected override bool VerifyDrawable(android.graphics.drawable.Drawable drawable) {
        if (drawable == this.mBackground && !this.mIsSplit) {
            return true;
        }
        if (drawable == this.mStackedBackground && this.mIsStacked) {
            return true;
        }
        return (drawable == this.mSplitBackground && this.mIsSplit) || BBUKCZhsLtnAwUsy(this, drawable);
    }
}

