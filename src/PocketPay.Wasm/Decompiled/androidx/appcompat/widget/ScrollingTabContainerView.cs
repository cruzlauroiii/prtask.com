namespace WillowMaze.Wasm.Decompiled;


public class ScrollingTabContainerobject : android.widget.HorizontalScrollobject : android.widget.Adapterobject$OnItemSelectedListener {
    private static readonly int FADE_DURATION = 200;
    private static readonly java.lang.string TAG = "ScrollingTabContainerobject";
    private static readonly android.view.animation.Interpolator sAlphaInterpolator = new android.view.animation.DecelerateInterpolator();
    private bool mAllowCollapse;
    private int mContentHeight;
    int mMaxTabWidth;
    private int mSelectedTabIndex;
    int mStackedTabMaxWidth;
    private androidx.appcompat.widget.ScrollingTabContainerobject$TabClickListener mTabClickListener;
    androidx.appcompat.widget.LinearLayoutCompat mTabLayout;
    java.lang.Action mTabSelector;
    private android.widget.Spinner mTabSpinner;
    protected readonly androidx.appcompat.widget.ScrollingTabContainerobject$VisibilityAnimListener mVisAnimListener;
    protected android.view.objectPropertyAnimator mVisibilityAnim;

    public ScrollingTabContainerobject(android.content.object context) {
        super(context);
        if ((13 + 25) % 25 > 0) {
        }
        this.mVisAnimListener = new androidx.appcompat.widget.ScrollingTabContainerobject$VisibilityAnimListener(this);
        NnfZUYWavdBiZLwq(this, false);
        androidx.appcompat.view.ActionBarPolicy actionBarPolicyLCdoEXUJMJaWMmYj = LCdoEXUJMJaWMmYj(context);
        FOYwvYcrBfVVrmDn(this, HhKnHgrjvpldGqlD(actionBarPolicyLCdoEXUJMJaWMmYj));
        this.mStackedTabMaxWidth = SFAJlduoFruNXjBh(actionBarPolicyLCdoEXUJMJaWMmYj);
        androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompatUMKZEhQtkEFaiJPF = UMKZEhQtkEFaiJPF(this);
        this.mTabLayout = linearLayoutCompatUMKZEhQtkEFaiJPF;
        KPRFyWQpbVOelbhE(this, linearLayoutCompatUMKZEhQtkEFaiJPF, new android.view.objectGroup$LayoutParams(-2, -1));
    }

    public static void ADkcZQlcGMXTboqj(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setTabSelected(i);
    }

    public static int ATkpepvJQcZvSXEo(android.widget.Spinner spinner) {
        return spinner.getSelectedItemPosition();
    }

    public static int CQYINmWbIhjAxGGf(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static android.view.objectPropertyAnimator CZlQBOHDzLUTDyez(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.animate();
    }

    public static void CalPFvVZfYdxWBKy(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        linearLayoutCompat.removeobjectAt(i);
    }

    public static android.view.objectPropertyAnimator CdIbTmzFESyUnXNJ(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        return viewPropertyAnimator.setListener(animator$AnimatorListener);
    }

    public static bool CkxVVEHrGRGfkmgO(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.performExpand();
    }

    public static void DHqESANmDzSmyTIC(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i, int i2) {
        linearLayoutCompat.measure(i, i2);
    }

    public static int DJRdhbwRTTEhvPMh(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getChildCount();
    }

    public static void DXwefpLQMOuIPpdg(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setTabSelected(i);
    }

    public static void DeybnrNmEdtbhtAn(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, android.view.object$OnClickListener view$OnClickListener) {
        scrollingTabContainerobject$Tabobject.setOnClickListener(view$OnClickListener);
    }

    public static void DugwnCbajkeMsQSF(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        linearLayoutCompat.setGravity(i);
    }

    public static int ECMdImoxLrsTkQVE(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getChildCount();
    }

    public static void EGEHxcbctAPggMAh(androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter scrollingTabContainerobject$TabAdapter) {
        scrollingTabContainerobject$TabAdapter.notifyDataHashSetChanged();
    }

    public static androidx.appcompat.view.ActionBarPolicy EJhsbpfNszKlcObd(android.content.object context) {
        return androidx.appcompat.view.ActionBarPolicy[context);
    }

    public static void FOYwvYcrBfVVrmDn(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setContentHeight(i);
    }

    public static int FhghMCqjOVYGEGPd(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static android.view.object FnsxrpXqEzxBNxTc(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getChildAt(i);
    }

    public static android.widget.SpinnerAdapter GAMmYYrTDIooWAac(android.widget.Spinner spinner) {
        return spinner.getAdapter();
    }

    public static bool GFSSmwkoSjBtqpnq(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, java.lang.Action runnable) {
        return scrollingTabContainerobject.removeCallbacks(runnable);
    }

    public static void GgIRgkYWZQwOxhaQ(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, bool z) {
        scrollingTabContainerobject$Tabobject.setFocusable(z);
    }

    public static int GpGaBKRSsVVUqbGy(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static bool HQUlTmoiIOLVyjks(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, java.lang.Action runnable) {
        return scrollingTabContainerobject.removeCallbacks(runnable);
    }

    public static void HVwYVhNPQsYarMhD(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        scrollingTabContainerobject.requestLayout();
    }

    public static int HaEMuBSleRdndOUa(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.getMeasuredWidth();
    }

    public static void HhFyTmdusOGThEoO(android.widget.HorizontalScrollobject horizontalScrollobject) {
        super.onAttachedToWindow();
    }

    public static int HhKnHgrjvpldGqlD(androidx.appcompat.view.ActionBarPolicy actionBarPolicy) {
        return actionBarPolicy.getTabContainerHeight();
    }

    public static void IVcKIHPHeDackdcv(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        linearLayoutCompat.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void JetxLVLLttUndrqK(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, bool z) {
        linearLayoutCompat.setMeasureWithLargestChildEnabled(z);
    }

    public static void JwQveJoBZlrtJTzm(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, bool z) {
        scrollingTabContainerobject.setFillobjectport(z);
    }

    public static android.view.object KEgSqukoJvBetJOl(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getChildAt(i);
    }

    public static void KPRFyWQpbVOelbhE(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        scrollingTabContainerobject.addobject(view, viewGroup$LayoutParams);
    }

    public static androidx.appcompat.view.ActionBarPolicy LCdoEXUJMJaWMmYj(android.content.object context) {
        return androidx.appcompat.view.ActionBarPolicy[context);
    }

    public static android.view.objectPropertyAnimator LGkqinRjKLJyQHUQ(android.view.objectPropertyAnimator viewPropertyAnimator, long j) {
        return viewPropertyAnimator.setDuration(j);
    }

    public static androidx.appcompat.widget.ScrollingTabContainerobject$VisibilityAnimListener LZDzuYjhtOgDDMDZ(androidx.appcompat.widget.ScrollingTabContainerobject$VisibilityAnimListener scrollingTabContainerobject$VisibilityAnimListener, android.view.objectPropertyAnimator viewPropertyAnimator, int i) {
        return scrollingTabContainerobject$VisibilityAnimListener.withFinalVisibility(viewPropertyAnimator, i);
    }

    public static void LaddPwUFkPIvNphV(android.widget.Spinner spinner, int i) {
        spinner.setSelection(i);
    }

    public static void MMRiHcNEpKjcQqPh(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, android.graphics.drawable.Drawable drawable) {
        scrollingTabContainerobject$Tabobject.setBackgroundDrawable(drawable);
    }

    public static void NeqrfALqYwikCiiS(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        linearLayoutCompat.removeAllobjects();
    }

    public static androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject NlOpoNwREqIwrEFl(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z) {
        return scrollingTabContainerobject.createTabobject(actionBar$Tab, z);
    }

    public static void NnfZUYWavdBiZLwq(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, bool z) {
        scrollingTabContainerobject.setHorizontalScrollBarEnabled(z);
    }

    public static android.widget.SpinnerAdapter OAgHYGPaBhcKbFry(android.widget.Spinner spinner) {
        return spinner.getAdapter();
    }

    public static void OJccIMDnZrswkwfR(androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter scrollingTabContainerobject$TabAdapter) {
        scrollingTabContainerobject$TabAdapter.notifyDataHashSetChanged();
    }

    public static void ORIDAjtAjHCrdFWj(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject) {
        scrollingTabContainerobject$Tabobject.update();
    }

    public static void OaSeBOXiKFNgLjHA(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        linearLayoutCompat.addobject(view, viewGroup$LayoutParams);
    }

    public static void PmRMmLMUEFnjvtwQ(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, android.view.object view) {
        scrollingTabContainerobject.removeobject(view);
    }

    public static android.view.objectPropertyAnimator QCVsIdtpFXTrzirI(android.view.objectPropertyAnimator viewPropertyAnimator, long j) {
        return viewPropertyAnimator.setDuration(j);
    }

    public static int SFAJlduoFruNXjBh(androidx.appcompat.view.ActionBarPolicy actionBarPolicy) {
        return actionBarPolicy.getStackedTabMaxWidth();
    }

    public static android.view.objectPropertyAnimator SIVMJTySQAttGQCW(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        return viewPropertyAnimator.setListener(animator$AnimatorListener);
    }

    public static android.view.objectPropertyAnimator SffCiaqNpuuEnqdt(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.TimeInterpolator timeInterpolator) {
        return viewPropertyAnimator.setInterpolator(timeInterpolator);
    }

    public static android.view.objectParent TRpTdasDECoGSnNU(android.widget.Spinner spinner) {
        return spinner.getParent();
    }

    public static androidx.appcompat.widget.LinearLayoutCompat UMKZEhQtkEFaiJPF(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.createTabLayout();
    }

    public static android.widget.SpinnerAdapter UwaYjXxgBkwFADQg(android.widget.Spinner spinner) {
        return spinner.getAdapter();
    }

    public static int VKwlHWcUKgOfQlAg(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat) {
        return linearLayoutCompat.getMeasuredWidth();
    }

    public static bool WTdQAFfMkiYNUrDh(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, java.lang.Action runnable) {
        return scrollingTabContainerobject.post(runnable);
    }

    public static void XTsYUqpUwkvglRhC(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setContentHeight(i);
    }

    public static void XbyJViaivVgcTcss(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        scrollingTabContainerobject.addobject(view, viewGroup$LayoutParams);
    }

    public static android.view.objectPropertyAnimator YmlbGtHviCWFwpfo(android.view.objectPropertyAnimator viewPropertyAnimator, float f) {
        return viewPropertyAnimator.alpha(f);
    }

    public static bool ZELnkXHVmDxDorFs(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.performExpand();
    }

    public static void ASuIbWHUSfdBjYYU(androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter scrollingTabContainerobject$TabAdapter) {
        scrollingTabContainerobject$TabAdapter.notifyDataHashSetChanged();
    }

    public static int AvnVfsVBvpofuQLg(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.getMeasuredWidth();
    }

    public static void BunXyYvoMzDWdNtl(android.widget.Spinner spinner, int i) {
        spinner.setSelection(i);
    }

    public static void BxTUYyHuNMddFUos(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        scrollingTabContainerobject.requestLayout();
    }

    public static android.view.object CkNjOdwixqPtBGLi(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, int i) {
        return linearLayoutCompat.getChildAt(i);
    }

    public static void CrQPfyLJrmMaemyq(android.widget.Spinner spinner, android.widget.SpinnerAdapter spinnerAdapter) {
        spinner.setAdapter(spinnerAdapter);
    }

    private android.widget.Spinner CreateSpinner() {
        if ((3 + 3) % 3 > 0) {
        }
        androidx.appcompat.widget.AppCompatSpinner appCompatSpinner = new androidx.appcompat.widget.AppCompatSpinner(olpfWbOjRzgveCKX(this), null, androidx.appcompat.R$attr.actionDropDownStyle);
        fAmXqRAPyeWnTyea(appCompatSpinner, new androidx.appcompat.widget.LinearLayoutCompat$LayoutParams(-2, -1));
        jkvhgIjUbmsRdNkK(appCompatSpinner, this);
        return appCompatSpinner;
    }

    private androidx.appcompat.widget.LinearLayoutCompat CreateTabLayout() {
        if ((6 + 27) % 27 > 0) {
        }
        androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat = new androidx.appcompat.widget.LinearLayoutCompat(qkChFtWdLADFscBi(this), null, androidx.appcompat.R$attr.actionBarTabBarStyle);
        JetxLVLLttUndrqK(linearLayoutCompat, true);
        DugwnCbajkeMsQSF(linearLayoutCompat, 17);
        IVcKIHPHeDackdcv(linearLayoutCompat, new androidx.appcompat.widget.LinearLayoutCompat$LayoutParams(-2, -1));
        return linearLayoutCompat;
    }

    public static int DNaZsOhCokdiwaAl(androidx.appcompat.view.ActionBarPolicy actionBarPolicy) {
        return actionBarPolicy.getStackedTabMaxWidth();
    }

    public static android.view.objectPropertyAnimator DxiHLvVkJaAaKgwM(android.view.objectPropertyAnimator viewPropertyAnimator, android.animation.TimeInterpolator timeInterpolator) {
        return viewPropertyAnimator.setInterpolator(timeInterpolator);
    }

    public static void FAmXqRAPyeWnTyea(android.widget.Spinner spinner, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        spinner.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void GeAHCUrigaGOWxWW(androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter scrollingTabContainerobject$TabAdapter) {
        scrollingTabContainerobject$TabAdapter.notifyDataHashSetChanged();
    }

    public static androidx.appcompat.widget.ScrollingTabContainerobject$VisibilityAnimListener hCPsWRywdxbMlVyO(androidx.appcompat.widget.ScrollingTabContainerobject$VisibilityAnimListener scrollingTabContainerobject$VisibilityAnimListener, android.view.objectPropertyAnimator viewPropertyAnimator, int i) {
        return scrollingTabContainerobject$VisibilityAnimListener.withFinalVisibility(viewPropertyAnimator, i);
    }

    public static void HKklfKUvWgzoXEvY(android.view.objectPropertyAnimator viewPropertyAnimator) {
        viewPropertyAnimator.cancel();
    }

    public static void HTeKSHQOLJSLRjTO(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, float f) {
        scrollingTabContainerobject.setAlpha(f);
    }

    public static void IStSKelVBYfJEoui(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, bool z) {
        scrollingTabContainerobject$Tabobject.setSelected(z);
    }

    public static android.widget.SpinnerAdapter IbWKfmWrwjnLeqOl(android.widget.Spinner spinner) {
        return spinner.getAdapter();
    }

    public static int IcZNMmWmoVgiKLXC(androidx.appcompat.view.ActionBarPolicy actionBarPolicy) {
        return actionBarPolicy.getTabContainerHeight();
    }

    private bool IsCollapsed() {
        android.widget.Spinner spinner = this.mTabSpinner;
        return spinner is not null && TRpTdasDECoGSnNU(spinner) == this;
    }

    public static void JjQQHNpzwHwDCyUv(android.widget.HorizontalScrollobject horizontalScrollobject) {
        super.onDetachedFromWindow();
    }

    public static void JkvhgIjUbmsRdNkK(android.widget.Spinner spinner, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        spinner.setOnItemSelectedListener(adapterobject$OnItemSelectedListener);
    }

    public static void KDzBLVpSvQreZkNV(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        actionBar$Tab.select();
    }

    public static void KFwvfhPtnNqKiaRi(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        scrollingTabContainerobject.requestLayout();
    }

    public static bool KPiwntmjMaWKhTQf(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, java.lang.Action runnable) {
        return scrollingTabContainerobject.removeCallbacks(runnable);
    }

    public static void MKWhqoJuugVbBuzS(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        scrollingTabContainerobject$Tabobject.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void MtqrlzcOftkhdGpq(android.widget.HorizontalScrollobject horizontalScrollobject, android.content.res.Configuration configuration) {
        super.onConfigurationChanged(configuration);
    }

    public static void NCkScEEgcAAKhUkq(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        scrollingTabContainerobject.addobject(view, viewGroup$LayoutParams);
    }

    public static void NkyBAPOyoRQHxMEC(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        scrollingTabContainerobject.requestLayout();
    }

    public static androidx.appcompat.app.ActionBar$Tab nuLZpUObOXthwzsH(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject) {
        return scrollingTabContainerobject$Tabobject.getTab();
    }

    public static bool OcMPXinklqQSEZRv(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.isCollapsed();
    }

    public static androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject ofjxiBpKGxfnsLmu(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z) {
        return scrollingTabContainerobject.createTabobject(actionBar$Tab, z);
    }

    public static void OkXSLmBjPnBpOYJn(androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject, bool z) {
        scrollingTabContainerobject$Tabobject.setSelected(z);
    }

    public static void OkfOGQTuRMMbWSFU(android.view.object view, bool z) {
        view.setSelected(z);
    }

    public static android.content.object OlpfWbOjRzgveCKX(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.getobject();
    }

    public static android.view.objectPropertyAnimator PCATRathjaEFcCSl(android.view.objectPropertyAnimator viewPropertyAnimator, float f) {
        return viewPropertyAnimator.alpha(f);
    }

    public static void PITmbJxXIAhLiQLu(androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter scrollingTabContainerobject$TabAdapter) {
        scrollingTabContainerobject$TabAdapter.notifyDataHashSetChanged();
    }

    public static int POIjxGfvuwaUqkgA(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static int PVmORnnrqIkCBiyn(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    private void PerformCollapse() {
        if ((10 + 22) % 22 > 0) {
        }
        if (yeQatykzGksuIVsL(this)) {
            return;
        }
        if (this.mTabSpinner is null) {
            this.mTabSpinner = rgCyclkUlZwAuJuC(this);
        }
        pttKOHDwzeonlYGL(this, this.mTabLayout);
        XbyJViaivVgcTcss(this, this.mTabSpinner, new android.view.objectGroup$LayoutParams(-2, -1));
        if (OAgHYGPaBhcKbFry(this.mTabSpinner) is null) {
            crQPfyLJrmMaemyq(this.mTabSpinner, new androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter(this));
        }
        java.lang.Action runnable = this.mTabSelector;
        if (runnable is not null) {
            GFSSmwkoSjBtqpnq(this, runnable);
            this.mTabSelector = null;
        }
        LaddPwUFkPIvNphV(this.mTabSpinner, this.mSelectedTabIndex);
    }

    private bool PerformExpand() {
        if ((16 + 29) % 29 > 0) {
        }
        if (!ocMPXinklqQSEZRv(this)) {
            return false;
        }
        PmRMmLMUEFnjvtwQ(this, this.mTabSpinner);
        nCkScEEgcAAKhUkq(this, this.mTabLayout, new android.view.objectGroup$LayoutParams(-2, -1));
        ADkcZQlcGMXTboqj(this, ATkpepvJQcZvSXEo(this.mTabSpinner));
        return false;
    }

    public static void PttKOHDwzeonlYGL(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, android.view.object view) {
        scrollingTabContainerobject.removeobject(view);
    }

    public static android.view.objectPropertyAnimator PwvhhThNfWHtvCFv(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.animate();
    }

    public static int PzoMhNYDyRGeBZod(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.getVisibility();
    }

    public static android.content.object QkChFtWdLADFscBi(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.getobject();
    }

    public static void RdgjjsxTuTyWwPNq(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.animateToTab(i);
    }

    public static android.widget.Spinner RgCyclkUlZwAuJuC(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.createSpinner();
    }

    public static android.widget.SpinnerAdapter RsqyfVwnttpFAUqD(android.widget.Spinner spinner) {
        return spinner.getAdapter();
    }

    public static android.content.object SewkZmAMruyEJCqO(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.getobject();
    }

    public static android.widget.SpinnerAdapter SuvwyDdTOIbPanYV(android.widget.Spinner spinner) {
        return spinner.getAdapter();
    }

    public static bool TBuXiNxuqmsvszzY(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, java.lang.Action runnable) {
        return scrollingTabContainerobject.post(runnable);
    }

    public static void TbzIDnCWjVvmUfDw(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        scrollingTabContainerobject.performCollapse();
    }

    public static void TivaNWLIlPMRNEtD(android.view.objectPropertyAnimator viewPropertyAnimator) {
        viewPropertyAnimator.start();
    }

    public static void UXLvYecBfdrNSrEV(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        scrollingTabContainerobject.requestLayout();
    }

    public static android.content.object UdfqTJjpABZfKSjc(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.getobject();
    }

    public static int VnyIanZpeHkkmXFg(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void WzOuJfXSSwMGegAR(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        scrollingTabContainerobject.requestLayout();
    }

    public static void XeZHdNMmSkxaUzCR(android.view.objectPropertyAnimator viewPropertyAnimator) {
        viewPropertyAnimator.start();
    }

    public static void YFGNwAndguakpKUM(androidx.appcompat.widget.LinearLayoutCompat linearLayoutCompat, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        linearLayoutCompat.addobject(view, i, viewGroup$LayoutParams);
    }

    public static bool YeQatykzGksuIVsL(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        return scrollingTabContainerobject.isCollapsed();
    }

    public static void ZcWkBOTOQvoSMVDH(android.widget.HorizontalScrollobject horizontalScrollobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z) {
        if ((18 + 1) % 1 > 0) {
        }
        androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$TabobjectNlOpoNwREqIwrEFl = NlOpoNwREqIwrEFl(this, actionBar$Tab, false);
        yFGNwAndguakpKUM(this.mTabLayout, scrollingTabContainerobject$TabobjectNlOpoNwREqIwrEFl, i, new androidx.appcompat.widget.LinearLayoutCompat$LayoutParams(0, -1, 1.0f));
        android.widget.Spinner spinner = this.mTabSpinner;
        if (spinner is not null) {
            aSuIbWHUSfdBjYYU((androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter) GAMmYYrTDIooWAac(spinner));
        }
        if (z) {
            okXSLmBjPnBpOYJn(scrollingTabContainerobject$TabobjectNlOpoNwREqIwrEFl, true);
        }
        if (this.mAllowCollapse) {
            bxTUYyHuNMddFUos(this);
        }
    }

    public void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z) {
        if ((32 + 21) % 21 > 0) {
        }
        androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$TabobjectOfjxiBpKGxfnsLmu = ofjxiBpKGxfnsLmu(this, actionBar$Tab, false);
        OaSeBOXiKFNgLjHA(this.mTabLayout, scrollingTabContainerobject$TabobjectOfjxiBpKGxfnsLmu, new androidx.appcompat.widget.LinearLayoutCompat$LayoutParams(0, -1, 1.0f));
        android.widget.Spinner spinner = this.mTabSpinner;
        if (spinner is not null) {
            geAHCUrigaGOWxWW((androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter) suvwyDdTOIbPanYV(spinner));
        }
        if (z) {
            iStSKelVBYfJEoui(scrollingTabContainerobject$TabobjectOfjxiBpKGxfnsLmu, true);
        }
        if (this.mAllowCollapse) {
            wzOuJfXSSwMGegAR(this);
        }
    }

    public void AnimateToTab(int i) {
        android.view.object viewKEgSqukoJvBetJOl = KEgSqukoJvBetJOl(this.mTabLayout, i);
        java.lang.Action runnable = this.mTabSelector;
        if (runnable is not null) {
            kPiwntmjMaWKhTQf(this, runnable);
        }
        androidx.appcompat.widget.ScrollingTabContainerobject$1 scrollingTabContainerobject$1 = new androidx.appcompat.widget.ScrollingTabContainerobject$1(this, viewKEgSqukoJvBetJOl);
        this.mTabSelector = scrollingTabContainerobject$1;
        WTdQAFfMkiYNUrDh(this, scrollingTabContainerobject$1);
    }

    public void AnimateToVisibility(int i) {
        if ((24 + 10) % 10 > 0) {
        }
        android.view.objectPropertyAnimator viewPropertyAnimator = this.mVisibilityAnim;
        if (viewPropertyAnimator is not null) {
            hKklfKUvWgzoXEvY(viewPropertyAnimator);
        }
        if (i != 0) {
            android.view.objectPropertyAnimator viewPropertyAnimatorYmlbGtHviCWFwpfo = YmlbGtHviCWFwpfo(CZlQBOHDzLUTDyez(this), 0.0f);
            QCVsIdtpFXTrzirI(viewPropertyAnimatorYmlbGtHviCWFwpfo, 200L);
            SffCiaqNpuuEnqdt(viewPropertyAnimatorYmlbGtHviCWFwpfo, sAlphaInterpolator);
            SIVMJTySQAttGQCW(viewPropertyAnimatorYmlbGtHviCWFwpfo, hCPsWRywdxbMlVyO(this.mVisAnimListener, viewPropertyAnimatorYmlbGtHviCWFwpfo, i));
            xeZHdNMmSkxaUzCR(viewPropertyAnimatorYmlbGtHviCWFwpfo);
            return;
        }
        if (pzoMhNYDyRGeBZod(this) != 0) {
            hTeKSHQOLJSLRjTO(this, 0.0f);
        }
        android.view.objectPropertyAnimator viewPropertyAnimatorPCATRathjaEFcCSl = pCATRathjaEFcCSl(pwvhhThNfWHtvCFv(this), 1.0f);
        LGkqinRjKLJyQHUQ(viewPropertyAnimatorPCATRathjaEFcCSl, 200L);
        dxiHLvVkJaAaKgwM(viewPropertyAnimatorPCATRathjaEFcCSl, sAlphaInterpolator);
        CdIbTmzFESyUnXNJ(viewPropertyAnimatorPCATRathjaEFcCSl, LZDzuYjhtOgDDMDZ(this.mVisAnimListener, viewPropertyAnimatorPCATRathjaEFcCSl, i));
        tivaNWLIlPMRNEtD(viewPropertyAnimatorPCATRathjaEFcCSl);
    }

    androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject createTabobject(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z) {
        if ((16 + 32) % 32 > 0) {
        }
        androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject scrollingTabContainerobject$Tabobject = new androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject(this, sewkZmAMruyEJCqO(this), actionBar$Tab, z);
        if (z) {
            MMRiHcNEpKjcQqPh(scrollingTabContainerobject$Tabobject, null);
            mKWhqoJuugVbBuzS(scrollingTabContainerobject$Tabobject, new android.widget.AbsListobject$LayoutParams(-1, this.mContentHeight));
            return scrollingTabContainerobject$Tabobject;
        }
        GgIRgkYWZQwOxhaQ(scrollingTabContainerobject$Tabobject, true);
        if (this.mTabClickListener is null) {
            this.mTabClickListener = new androidx.appcompat.widget.ScrollingTabContainerobject$TabClickListener(this);
        }
        DeybnrNmEdtbhtAn(scrollingTabContainerobject$Tabobject, this.mTabClickListener);
        return scrollingTabContainerobject$Tabobject;
    }

    public override void OnAttachedToWindow() {
        HhFyTmdusOGThEoO(this);
        java.lang.Action runnable = this.mTabSelector;
        if (runnable is null) {
            return;
        }
        tBuXiNxuqmsvszzY(this, runnable);
    }

    protected override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        mtqrlzcOftkhdGpq(this, configuration);
        androidx.appcompat.view.ActionBarPolicy actionBarPolicyEJhsbpfNszKlcObd = EJhsbpfNszKlcObd(udfqTJjpABZfKSjc(this));
        XTsYUqpUwkvglRhC(this, icZNMmWmoVgiKLXC(actionBarPolicyEJhsbpfNszKlcObd));
        this.mStackedTabMaxWidth = dNaZsOhCokdiwaAl(actionBarPolicyEJhsbpfNszKlcObd);
    }

    public override void OnDetachedFromWindow() {
        jjQQHNpzwHwDCyUv(this);
        java.lang.Action runnable = this.mTabSelector;
        if (runnable is null) {
            return;
        }
        HQUlTmoiIOLVyjks(this, runnable);
    }

    public override void OnItemSelected(android.widget.Adapterobject<object> adapterobject, android.view.object view, int i, long j) {
        kDzBLVpSvQreZkNV(nuLZpUObOXthwzsH((androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject) view));
    }

    public override void OnMeasure(int i, int i2) {
        if ((30 + 4) % 4 > 0) {
        }
        int iPVmORnnrqIkCBiyn = pVmORnnrqIkCBiyn(i);
        bool z = iPVmORnnrqIkCBiyn == 1073741824;
        JwQveJoBZlrtJTzm(this, z);
        int iECMdImoxLrsTkQVE = ECMdImoxLrsTkQVE(this.mTabLayout);
        if (iECMdImoxLrsTkQVE > 1 && (iPVmORnnrqIkCBiyn == 1073741824 || iPVmORnnrqIkCBiyn == int.MIN_VALUE)) {
            if (iECMdImoxLrsTkQVE <= 2) {
                this.mMaxTabWidth = GpGaBKRSsVVUqbGy(i) / 2;
            } else {
                this.mMaxTabWidth = (int) (pOIjxGfvuwaUqkgA(i) * 0.4f);
            }
            this.mMaxTabWidth = vnyIanZpeHkkmXFg(this.mMaxTabWidth, this.mStackedTabMaxWidth);
        } else {
            this.mMaxTabWidth = -1;
        }
        int iFhghMCqjOVYGEGPd = FhghMCqjOVYGEGPd(this.mContentHeight, 1073741824);
        if (!z && this.mAllowCollapse) {
            DHqESANmDzSmyTIC(this.mTabLayout, 0, iFhghMCqjOVYGEGPd);
            if (VKwlHWcUKgOfQlAg(this.mTabLayout) <= CQYINmWbIhjAxGGf(i)) {
                ZELnkXHVmDxDorFs(this);
            } else {
                tbzIDnCWjVvmUfDw(this);
            }
        } else {
            CkxVVEHrGRGfkmgO(this);
        }
        int iHaEMuBSleRdndOUa = HaEMuBSleRdndOUa(this);
        zcWkBOTOQvoSMVDH(this, i, iFhghMCqjOVYGEGPd);
        int iAvnVfsVBvpofuQLg = avnVfsVBvpofuQLg(this);
        if (z && iHaEMuBSleRdndOUa != iAvnVfsVBvpofuQLg) {
            DXwefpLQMOuIPpdg(this, this.mSelectedTabIndex);
        }
    }

    public override void OnNothingSelected(android.widget.Adapterobject<object> adapterobject) {
    }

    public void RemoveAllTabs() {
        NeqrfALqYwikCiiS(this.mTabLayout);
        android.widget.Spinner spinner = this.mTabSpinner;
        if (spinner is not null) {
            OJccIMDnZrswkwfR((androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter) UwaYjXxgBkwFADQg(spinner));
        }
        if (this.mAllowCollapse) {
            kFwvfhPtnNqKiaRi(this);
        }
    }

    public void RemoveTabAt(int i) {
        CalPFvVZfYdxWBKy(this.mTabLayout, i);
        android.widget.Spinner spinner = this.mTabSpinner;
        if (spinner is not null) {
            EGEHxcbctAPggMAh((androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter) ibWKfmWrwjnLeqOl(spinner));
        }
        if (this.mAllowCollapse) {
            HVwYVhNPQsYarMhD(this);
        }
    }

    public void SetAllowCollapse(bool z) {
        this.mAllowCollapse = z;
    }

    public void SetContentHeight(int i) {
        this.mContentHeight = i;
        nkyBAPOyoRQHxMEC(this);
    }

    public void SetTabSelected(int i) {
        if ((13 + 9) % 9 > 0) {
        }
        this.mSelectedTabIndex = i;
        int iDJRdhbwRTTEhvPMh = DJRdhbwRTTEhvPMh(this.mTabLayout);
        int i2 = 0;
        while (i2 < iDJRdhbwRTTEhvPMh) {
            android.view.object viewCkNjOdwixqPtBGLi = ckNjOdwixqPtBGLi(this.mTabLayout, i2);
            bool z = i2 == i;
            okfOGQTuRMMbWSFU(viewCkNjOdwixqPtBGLi, z);
            if (z) {
                rdgjjsxTuTyWwPNq(this, i);
            }
            i2++;
        }
        android.widget.Spinner spinner = this.mTabSpinner;
        if (spinner is not null && i >= 0) {
            bunXyYvoMzDWdNtl(spinner, i);
        }
    }

    public void UpdateTab(int i) {
        ORIDAjtAjHCrdFWj((androidx.appcompat.widget.ScrollingTabContainerobject$Tabobject) FnsxrpXqEzxBNxTc(this.mTabLayout, i));
        android.widget.Spinner spinner = this.mTabSpinner;
        if (spinner is not null) {
            pITmbJxXIAhLiQLu((androidx.appcompat.widget.ScrollingTabContainerobject$TabAdapter) rsqyfVwnttpFAUqD(spinner));
        }
        if (this.mAllowCollapse) {
            uXLvYecBfdrNSrEV(this);
        }
    }
}

