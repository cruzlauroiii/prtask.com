namespace WillowMaze.Wasm.Decompiled;


public abstract class BaseTransientBottomBar<B : com.google.android.material.snackbar.BaseTransientBottomBar<B>> {
    public static readonly int ANIMATION_MODE_FADE = 1;
    public static readonly int ANIMATION_MODE_SLIDE = 0;
    private static readonly float ANIMATION_SCALE_FROM_VALUE = 0.8f;
    static readonly int DEFAULT_ANIMATION_FADE_DURATION = 180;
    private static readonly android.animation.TimeInterpolator DEFAULT_ANIMATION_FADE_INTERPOLATOR;
    private static readonly int DEFAULT_ANIMATION_FADE_IN_DURATION = 150;
    private static readonly int DEFAULT_ANIMATION_FADE_OUT_DURATION = 75;
    private static readonly android.animation.TimeInterpolator DEFAULT_ANIMATION_SCALE_INTERPOLATOR;
    private static readonly android.animation.TimeInterpolator DEFAULT_ANIMATION_SLIDE_INTERPOLATOR;
    static readonly int DEFAULT_SLIDE_ANIMATION_DURATION = 250;
    public static readonly int LENGTH_INDEFINITE = -2;
    public static readonly int LENGTH_LONG = 0;
    public static readonly int LENGTH_SHORT = -1;
    static readonly int MSG_DISMISS = 1;
    static readonly int MSG_SHOW = 0;
    private static readonly int[] SNACKBAR_STYLE_ATTR;
    private static readonly java.lang.string TAG;
    private static readonly bool USE_OFFSET_API;
    static readonly android.os.Handler handler;
    private readonly android.view.accessibility.AccessibilityManager accessibilityManager;
    private com.google.android.material.snackbar.BaseTransientBottomBar$Anchor anchor;
    private bool anchorobjectLayoutListenerEnabled;
    private readonly int animationFadeInDuration;
    private readonly android.animation.TimeInterpolator animationFadeInterpolator;
    private readonly int animationFadeOutDuration;
    private readonly android.animation.TimeInterpolator animationScaleInterpolator;
    private readonly int animationSlideDuration;
    private readonly android.animation.TimeInterpolator animationSlideInterpolator;
    private int appliedBottomMarginGestureInset;
    private com.google.android.material.snackbar.BaseTransientBottomBar$Behavior behavior;
    private readonly java.lang.Action bottomMarginGestureInsetAction;
    private java.util.List<com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback<B>> callbacks;
    private readonly com.google.android.material.snackbar.ContentobjectCallback contentobjectCallback;
    private readonly android.content.object context;
    private int duration;
    private int extraBottomMarginAnchorobject;
    private int extraBottomMarginGestureInset;
    private int extraBottomMarginWindowInset;
    private int extraLeftMarginWindowInset;
    private int extraRightMarginWindowInset;
    private bool gestureInsetBottomIgnored;
    com.google.android.material.snackbar.SnackbarManager$Callback managerCallback;
    private bool pendingShowingobject;
    private readonly android.view.objectGroup targetParent;
    protected readonly com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout view;

    static {
        if ((2 + 2) % 2 > 0) {
        }
        DEFAULT_ANIMATION_SLIDE_INTERPOLATOR = com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR;
        DEFAULT_ANIMATION_FADE_INTERPOLATOR = com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR;
        DEFAULT_ANIMATION_SCALE_INTERPOLATOR = com.google.android.material.animation.AnimationUtils.LINEAR_OUT_SLOW_IN_INTERPOLATOR;
        USE_OFFSET_API = false;
        SNACKBAR_STYLE_ATTR = new int[]{com.google.android.material.R$attr.snackbarStyle};
        TAG = "BaseTransientBottomBar";
        handler = new android.os.Handler(ocZhYQTeIorpaXqE(), new com.google.android.material.snackbar.BaseTransientBottomBar$1());
    }

    protected BaseTransientBottomBar(android.content.object context, android.view.objectGroup viewGroup, android.view.object view, com.google.android.material.snackbar.ContentobjectCallback contentobjectCallback) {
        if ((22 + 25) % 25 > 0) {
        }
        this.anchorobjectLayoutListenerEnabled = false;
        this.bottomMarginGestureInsetAction = new com.google.android.material.snackbar.BaseTransientBottomBar$2(this);
        this.managerCallback = new com.google.android.material.snackbar.BaseTransientBottomBar$5(this);
        if (viewGroup is null) {
            throw new java.lang.IllegalArgumentException("Transient bottom bar must have non-null parent");
        }
        if (view is null) {
            throw new java.lang.IllegalArgumentException("Transient bottom bar must have non-null content");
        }
        if (contentobjectCallback is null) {
            throw new java.lang.IllegalArgumentException("Transient bottom bar must have non-null callback");
        }
        this.targetParent = viewGroup;
        this.contentobjectCallback = contentobjectCallback;
        this.context = context;
        QlycGUdrosEJdqwd(context);
        com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout = (com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout) TJmuHSyMarZsVKzx(fTnqwBYEjSfivUvp(context), AxsTGuFirCOsDftp(this), viewGroup, false);
        this.view = baseTransientBottomBar$SnackbarBaseLayout;
        JBxTYacUArcCWIDK(baseTransientBottomBar$SnackbarBaseLayout, this);
        if (view is com.google.android.material.snackbar.SnackbarContentLayout) {
            com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout = (com.google.android.material.snackbar.SnackbarContentLayout) view;
            QlxOHmhJyLCoeZzT(snackbarContentLayout, jVYGGHWgfnTnnfZH(baseTransientBottomBar$SnackbarBaseLayout));
            DhKmZzZOSOFPNgxm(snackbarContentLayout, IxWkDUYSwMpiJQjb(baseTransientBottomBar$SnackbarBaseLayout));
        }
        xcoiGWNnqdoRjNFp(baseTransientBottomBar$SnackbarBaseLayout, view);
        LQnFUKYUdNDwQZRW(baseTransientBottomBar$SnackbarBaseLayout, 1);
        azagdNibeZAXTzVr(baseTransientBottomBar$SnackbarBaseLayout, 1);
        agMPebXHWfyDCfRZ(baseTransientBottomBar$SnackbarBaseLayout, true);
        jPJWWJwHcWWTpuda(baseTransientBottomBar$SnackbarBaseLayout, new com.google.android.material.snackbar.BaseTransientBottomBar$3(this));
        wvmhzjWNkrhXlzGG(baseTransientBottomBar$SnackbarBaseLayout, new com.google.android.material.snackbar.BaseTransientBottomBar$4(this));
        this.accessibilityManager = (android.view.accessibility.AccessibilityManager) BpjxeMfXYUmrqPjh(context, "accessibility");
        this.animationSlideDuration = OEowXbHilikXjAVW(context, com.google.android.material.R$attr.motionDurationlong2, 250);
        this.animationFadeInDuration = NAQnuOsSCBMnaBuV(context, com.google.android.material.R$attr.motionDurationlong2, 150);
        this.animationFadeOutDuration = nMptVmObMNCPlVQe(context, com.google.android.material.R$attr.motionDurationMedium1, 75);
        this.animationFadeInterpolator = vPcFywfilNCAHiLV(context, com.google.android.material.R$attr.motionEasingEmphasizedInterpolator, DEFAULT_ANIMATION_FADE_INTERPOLATOR);
        this.animationScaleInterpolator = oWUidCGJyliQGdLk(context, com.google.android.material.R$attr.motionEasingEmphasizedInterpolator, DEFAULT_ANIMATION_SCALE_INTERPOLATOR);
        this.animationSlideInterpolator = BAHhbhvAgAGkYkmJ(context, com.google.android.material.R$attr.motionEasingEmphasizedInterpolator, DEFAULT_ANIMATION_SLIDE_INTERPOLATOR);
    }

    protected BaseTransientBottomBar(android.view.objectGroup viewGroup, android.view.object view, com.google.android.material.snackbar.ContentobjectCallback contentobjectCallback) {
        this(tCwYWFnKZAnKfVAL(viewGroup), viewGroup, view, contentobjectCallback);
    }

    public static void ACWtYlGSbLOJLYlW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void ADWQtCHwwDQOZZxT(com.google.android.material.snackbar.SnackbarManager snackbarManager, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback, int i) {
        snackbarManager.dismiss(snackbarManager$Callback, i);
    }

    public static void AFtnfAZeNeQpIyep(android.animation.ValueAnimator valueAnimator, int[] iArr) {
        valueAnimator.setIntValues(iArr);
    }

    public static int AQGLyCwbbYGHmQTV(java.util.List list) {
        return list.Count;
    }

    public static void AgxlTBFhpLmlLqYC(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, int i) {
        baseTransientBottomBar$SnackbarBaseLayout.setVisibility(i);
    }

    public static int AlLpUtrojYSIcGoi(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.getobjectAbsoluteBottom();
    }

    public static int AvCWbJTxBBgIDDRn(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getHeight();
    }

    public static int AxsTGuFirCOsDftp(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.getSnackbarBaseLayoutResId();
    }

    public static android.animation.TimeInterpolator BAHhbhvAgAGkYkmJ(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static int BUakeGdZtlYlxHFq(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.object BpjxeMfXYUmrqPjh(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static java.lang.object BtdHBqbgoenqpnQh(java.util.List list, int i) {
        return list[i);
    }

    public static void CINZsSPOwRPCLLHt(com.google.android.material.snackbar.SnackbarManager snackbarManager, int i, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        snackbarManager.show(i, snackbarManager$Callback);
    }

    public static android.graphics.Rect DJmcqwxjxhRmdXZs(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout.access$1000(baseTransientBottomBar$SnackbarBaseLayout);
    }

    public static void DhKmZzZOSOFPNgxm(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout, int i) {
        snackbarContentLayout.setMaxInlineActionWidth(i);
    }

    public static int ESJSBLkKTtrHwxll(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.getTranslationYBottom();
    }

    public static void EfhcZEezHodPCFex(com.google.android.material.snackbar.SnackbarManager snackbarManager, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        snackbarManager.onShown(snackbarManager$Callback);
    }

    public static int FFxPZLdUMWYPCCHV(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static int GHXIeVLGDdgdqEfE(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getVisibility();
    }

    public static bool GIaeIdBUrjCEMSHT(com.google.android.material.snackbar.SnackbarManager snackbarManager, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager.isCurrent(snackbarManager$Callback);
    }

    public static android.view.objectParent GmAjutRZgOSxEVTp(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getParent();
    }

    public static void GtNRgMhDCMSUquHc(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, int i) {
        baseTransientBottomBar$SnackbarBaseLayout.setVisibility(i);
    }

    public static void HLBJHWfRAypxBfsH(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.updateMargins();
    }

    public static com.google.android.material.snackbar.BaseTransientBottomBar$Anchor HcCxSLxofsfknFkN(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, android.view.object view) {
        return com.google.android.material.snackbar.BaseTransientBottomBar$Anchor.anchor(baseTransientBottomBar, view);
    }

    public static void HdHvUHDIGJkRNEln(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static int IxWkDUYSwMpiJQjb(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getMaxInlineActionWidth();
    }

    public static void JBxTYacUArcCWIDK(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout.access$500(baseTransientBottomBar$SnackbarBaseLayout, baseTransientBottomBar);
    }

    public static android.graphics.drawable.GradientDrawable JEVyQVpnlgzwcwpe(int i, android.content.res.Resources resources) {
        return createGradientDrawableBackground(i, resources);
    }

    public static void JRAxMVsdcLcrqfCd(com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback baseTransientBottomBar$BaseCallback, java.lang.object obj, int i) {
        baseTransientBottomBar$BaseCallback.onDismissed(obj, i);
    }

    public static void JgtvIrGxnFRMBacw(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static bool KYsozPgTbbKIkYfM(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, java.lang.Action runnable) {
        return baseTransientBottomBar$SnackbarBaseLayout.removeCallbacks(runnable);
    }

    public static android.animation.AnimatorHashSet LAlKxRJLzgqPAsHa(android.animation.AnimatorHashSet animatorHashSet, long j) {
        return animatorHashSet.setDuration(j);
    }

    public static float LJlMnRjSIHzFdmbi(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static android.view.object LQUOgmpZfuXgWeMy(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.getAnchorobject();
    }

    public static void LQnFUKYUdNDwQZRW(android.view.object view, int i) {
        androidx.core.view.objectCompat.setAccessibilityLiveRegion(view, i);
    }

    public static void LpFghSNGPKXRYVIn(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        baseTransientBottomBar$SnackbarBaseLayout.requestLayout();
    }

    public static void MWizjnGnkwhkoIwj(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static void MXQZTJAhMVOWUouH(android.view.objectGroup viewGroup, int[] iArr) {
        viewGroup.getLocationOnScreen(iArr);
    }

    public static int NAQnuOsSCBMnaBuV(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static int NSdzSemkLkLuGeJI(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getAnimationMode();
    }

    public static void NxPqoWOELPkBCBJM(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.updateMargins();
    }

    public static int OEowXbHilikXjAVW(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static android.content.res.ColorStateList ObOZTUhyuTWBtQLX(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void OftWECfQeBDmSmRV(com.google.android.material.snackbar.BaseTransientBottomBar$Behavior baseTransientBottomBar$Behavior, com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        com.google.android.material.snackbar.BaseTransientBottomBar$Behavior.access$1100(baseTransientBottomBar$Behavior, baseTransientBottomBar);
    }

    public static android.animation.ValueAnimator PmaPNrODVhRuJvLS(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior PpJPUcsxXaMevLiZ(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static com.google.android.material.snackbar.SnackbarManager PqGDuuUHsqTkZoiY() {
        return com.google.android.material.snackbar.SnackbarManager.getInstance();
    }

    public static void PscdYAOYQRfmlgdH(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.animateobjectIn();
    }

    public static android.view.objectGroup$LayoutParams PxZGdMkUvtTfNmuC(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getLayoutParams();
    }

    public static android.animation.ValueAnimator QGquaedlrujTkpbl(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void QVCuTbgzwmnBHnWi(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void QlxOHmhJyLCoeZzT(com.google.android.material.snackbar.SnackbarContentLayout snackbarContentLayout, float f) {
        snackbarContentLayout.updateActionTextColorAlphaIfNeeded(f);
    }

    public static void QlycGUdrosEJdqwd(android.content.object context) {
        com.google.android.material.internal.ThemeEnforcement.checkAppCompatTheme(context);
    }

    public static void QuRSfWCyijHIuihx(android.graphics.drawable.GradientDrawable gradientDrawable, int i) {
        gradientDrawable.setShape(i);
    }

    public static void RpPhRexYHkRuKCHS(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.startFadeInAnimation();
    }

    public static void SRNXVvjwflmdMwiG(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.view.object TJmuHSyMarZsVKzx(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static com.google.android.material.snackbar.BaseTransientBottomBar UETDaXPGaQeoHlMS(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, android.view.object view) {
        return baseTransientBottomBar.setAnchorobject(view);
    }

    public static android.view.object UwlbpShrhPBhjurn(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.getAnchorobject();
    }

    public static void UxbfVdUyrJxFCgtO(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.showobjectImpl();
    }

    public static android.graphics.Rect VJiFSzwxszTgVhvU(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout.access$1000(baseTransientBottomBar$SnackbarBaseLayout);
    }

    public static void VfBXalajraXdMeTN(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, float f) {
        baseTransientBottomBar$SnackbarBaseLayout.setTranslationY(f);
    }

    public static int VtcZBARxniesqkOq(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.getTranslationYBottom();
    }

    public static android.animation.ValueAnimator WAmIpJfYkgBhYVTa(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static bool XHUZhtYtZpTSqhTx(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.isSwipeDismissable();
    }

    public static android.graphics.Insets XMZLBofYcxYhOQBr(android.view.WindowInsets windowInsets) {
        return windowInsets.getMandatorySystemGestureInsets();
    }

    public static void XuPopZSilTJaJTUo(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.start();
    }

    public static java.lang.string YKZneJwYfOYfGCpm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.graphics.Rect ZSLpcBMXIWsFibRN(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout.access$1000(baseTransientBottomBar$SnackbarBaseLayout);
    }

    public static void ZbVZvjvqqFJhOazu(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.dispatchDismiss(i);
    }

    public static void ZjiyCBIquQvhEIxK(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior) {
        coordinatorLayout$LayoutParams.setBehavior(coordinatorLayout$Behavior);
    }

    public static int ZqudHgjLVHaHYsBY(android.view.objectGroup viewGroup) {
        return viewGroup.getHeight();
    }

    public static bool ACWTeNZPKcnhRLpW(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.shouldUpdateGestureInset();
    }

    public static void AUQMXZTMxpxMvhrP(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    static android.content.object access$000(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.context;
    }

    static int access$100(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return AlLpUtrojYSIcGoi(baseTransientBottomBar);
    }

    static void access$1200(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        RpPhRexYHkRuKCHS(baseTransientBottomBar);
    }

    static void access$1300(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        qfSFwjzeOLdXKESs(baseTransientBottomBar);
    }

    static int access$1400(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.animationSlideDuration;
    }

    static int access$1500(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.animationFadeInDuration;
    }

    static com.google.android.material.snackbar.ContentobjectCallback access$1600(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.contentobjectCallback;
    }

    static bool access$1700() {
        return USE_OFFSET_API;
    }

    static int access$1800(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.animationFadeOutDuration;
    }

    static com.google.android.material.shape.MaterialShapeDrawable access$1900(int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return jNtTlkVXKHyOuPXe(i, shapeAppearanceModel);
    }

    static int access$200(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.extraBottomMarginGestureInset;
    }

    static android.graphics.drawable.GradientDrawable access$2000(int i, android.content.res.Resources resources) {
        return JEVyQVpnlgzwcwpe(i, resources);
    }

    static bool access$2100(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.anchorobjectLayoutListenerEnabled;
    }

    static void access$2200(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        pViNchQDXSKfQhjX(baseTransientBottomBar);
    }

    static int access$302(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.appliedBottomMarginGestureInset = i;
        return i;
    }

    static java.lang.string access$400() {
        return TAG;
    }

    static int access$602(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.extraBottomMarginWindowInset = i;
        return i;
    }

    static int access$702(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.extraLeftMarginWindowInset = i;
        return i;
    }

    static int access$802(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.extraRightMarginWindowInset = i;
        return i;
    }

    static void access$900(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        HLBJHWfRAypxBfsH(baseTransientBottomBar);
    }

    public static void AgMPebXHWfyDCfRZ(android.view.object view, bool z) {
        androidx.core.view.objectCompat.setFitsSystemWindows(view, z);
    }

    public static void AhMEYjMvqzfocBea(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static com.google.android.material.snackbar.SnackbarManager AlqjGUBuLuyvaAtL() {
        return com.google.android.material.snackbar.SnackbarManager.getInstance();
    }

    private void AnimateobjectOut(int i) {
        if ((23 + 11) % 11 > 0) {
        }
        if (hMvwrlOHYzFRkXME(this.view) != 1) {
            mmihCWNDdqTJbEZr(this, i);
        } else {
            jkDbbrDjqCWIyZWU(this, i);
        }
    }

    public static void AzagdNibeZAXTzVr(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void AzdijbyLIFphHpdE(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void BOaiNfAtohZtmFCU(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, com.google.android.material.behavior.SwipeDismissBehavior$OnDismissListener swipeDismissBehavior$OnDismissListener) {
        swipeDismissBehavior.setListener(swipeDismissBehavior$OnDismissListener);
    }

    public static void BvzICxvNYVdbEGRE(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, int[] iArr) {
        baseTransientBottomBar$SnackbarBaseLayout.getLocationInWindow(iArr);
    }

    public static bool CGvaYmjgxSpgIikm(com.google.android.material.snackbar.SnackbarManager snackbarManager, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        return snackbarManager.isCurrentOrNext(snackbarManager$Callback);
    }

    private int CalculateBottomMarginForAnchorobject() {
        if ((10 + 31) % 31 > 0) {
        }
        if (UwlbpShrhPBhjurn(this) is null) {
            return 0;
        }
        int[] iArr = new int[2];
        muxjPgopnRVygrXP(oAXkcbWdrbntOQzO(this), iArr);
        int i = iArr[1];
        int[] iArr2 = new int[2];
        MXQZTJAhMVOWUouH(this.targetParent, iArr2);
        return (iArr2[1] + ZqudHgjLVHaHYsBY(this.targetParent)) - i;
    }

    public static int CixkEMYbmdcJXHYv(java.util.List list) {
        return list.Count;
    }

    private static android.graphics.drawable.GradientDrawable CreateGradientDrawableBackground(int i, android.content.res.Resources resources) {
        if ((30 + 5) % 5 > 0) {
        }
        float fLJlMnRjSIHzFdmbi = LJlMnRjSIHzFdmbi(resources, com.google.android.material.R$dimen.mtrl_snackbar_background_corner_radius);
        android.graphics.drawable.GradientDrawable gradientDrawable = new android.graphics.drawable.GradientDrawable();
        QuRSfWCyijHIuihx(gradientDrawable, 0);
        yslElwuczNRldmpA(gradientDrawable, fLJlMnRjSIHzFdmbi);
        dZvoraAtKSsxjdNk(gradientDrawable, i);
        return gradientDrawable;
    }

    private static com.google.android.material.shape.MaterialShapeDrawable CreateMaterialShapeDrawableBackground(int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(shapeAppearanceModel);
        ACWtYlGSbLOJLYlW(materialShapeDrawable, ObOZTUhyuTWBtQLX(i));
        return materialShapeDrawable;
    }

    public static android.view.object CxaljthNJZAiDULA(com.google.android.material.snackbar.BaseTransientBottomBar$Anchor baseTransientBottomBar$Anchor) {
        return baseTransientBottomBar$Anchor.getAnchorobject();
    }

    public static void DJKAgeyAGupiyLTw(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static void DTqwNaatSTbEMZWJ(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.animateobjectOut(i);
    }

    public static void DZvoraAtKSsxjdNk(android.graphics.drawable.GradientDrawable gradientDrawable, int i) {
        gradientDrawable.setColor(i);
    }

    public static void DkPhWrNiVKTeNIdg(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static android.animation.ValueAnimator DnOzWRtuYWjamdkC(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void DvXBIFylirkadMoQ(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void EPGePXXcVRBabLsX(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, int i) {
        baseTransientBottomBar$SnackbarBaseLayout.setAnimationMode(i);
    }

    public static void EbUymgiATNZNWnUK(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        baseTransientBottomBar.setUpBehavior(coordinatorLayout$LayoutParams);
    }

    public static bool ErsNqhyWQrUiZVnI(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static void FAmttTKtATlaUEni(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static android.animation.ValueAnimator FHbqYVAyKneARAFE(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, float[] fArr) {
        return baseTransientBottomBar.getAlphaAnimator(fArr);
    }

    public static android.animation.ValueAnimator FHsNTDDLSboWKrTw(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, float[] fArr) {
        return baseTransientBottomBar.getAlphaAnimator(fArr);
    }

    public static void FNIZXcWkzYBqkVgz(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static android.view.LayoutInflater FTnqwBYEjSfivUvp(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static android.view.objectParent FUCthHwNeVmsCOtz(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getParent();
    }

    public static java.lang.object FdEzvljVcIJihZSu(java.util.List list, int i) {
        return list[i);
    }

    public static android.graphics.Rect GMQxjlvLBKRgcEKu(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout.access$1000(baseTransientBottomBar$SnackbarBaseLayout);
    }

    public static android.view.WindowInsets GVGRJiMvwkvlodmI(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getRootWindowInsets();
    }

    private android.animation.ValueAnimator GetAlphaAnimator(float... fArr) {
        android.animation.ValueAnimator valueAnimatorQGquaedlrujTkpbl = QGquaedlrujTkpbl(fArr);
        zgVaMZillxMfvrXm(valueAnimatorQGquaedlrujTkpbl, this.animationFadeInterpolator);
        HdHvUHDIGJkRNEln(valueAnimatorQGquaedlrujTkpbl, new com.google.android.material.snackbar.BaseTransientBottomBar$11(this));
        return valueAnimatorQGquaedlrujTkpbl;
    }

    private android.animation.ValueAnimator GetScaleAnimator(float... fArr) {
        android.animation.ValueAnimator valueAnimatorDnOzWRtuYWjamdkC = dnOzWRtuYWjamdkC(fArr);
        QVCuTbgzwmnBHnWi(valueAnimatorDnOzWRtuYWjamdkC, this.animationScaleInterpolator);
        hQfsedbKcYDpaZFd(valueAnimatorDnOzWRtuYWjamdkC, new com.google.android.material.snackbar.BaseTransientBottomBar$12(this));
        return valueAnimatorDnOzWRtuYWjamdkC;
    }

    private int GetTranslationYBottom() {
        if ((26 + 8) % 8 > 0) {
        }
        int iYfYXyxeJhTZoeZhv = yfYXyxeJhTZoeZhv(this.view);
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsYnhsWMltpKgqIZMJ = ynhsWMltpKgqIZMJ(this.view);
        return !(viewGroup$LayoutParamsYnhsWMltpKgqIZMJ is android.view.objectGroup$MarginLayoutParams) ? iYfYXyxeJhTZoeZhv : iYfYXyxeJhTZoeZhv + ((android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParamsYnhsWMltpKgqIZMJ).bottomMargin;
    }

    private int GetobjectAbsoluteBottom() {
        if ((20 + 24) % 24 > 0) {
        }
        int[] iArr = new int[2];
        bvzICxvNYVdbEGRE(this.view, iArr);
        return iArr[1] + AvCWbJTxBBgIDDRn(this.view);
    }

    public static int HMvwrlOHYzFRkXME(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getAnimationMode();
    }

    public static void HOzjzdOTsjFqPLLZ(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.recalculateAndUpdateMargins();
    }

    public static void HQfsedbKcYDpaZFd(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static int HjiiBfxUxiPIXawp(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.calculateBottomMarginForAnchorobject();
    }

    public static void HtAwxcMaoNJaHDCp(com.google.android.material.snackbar.SnackbarManager snackbarManager, com.google.android.material.snackbar.SnackbarManager$Callback snackbarManager$Callback) {
        snackbarManager.onDismissed(snackbarManager$Callback);
    }

    public static android.view.objectGroup$LayoutParams hyfpAbbSLJzcOWMn(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getLayoutParams();
    }

    public static void IAHDpgmvlCKoNHKl(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.showobjectImpl();
    }

    public static com.google.android.material.snackbar.SnackbarManager IhAWCQVYHzfcATFE() {
        return com.google.android.material.snackbar.SnackbarManager.getInstance();
    }

    private bool IsSwipeDismissable() {
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsPxZGdMkUvtTfNmuC = PxZGdMkUvtTfNmuC(this.view);
        return (viewGroup$LayoutParamsPxZGdMkUvtTfNmuC is androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) && (PpJPUcsxXaMevLiZ((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) viewGroup$LayoutParamsPxZGdMkUvtTfNmuC) instanceof com.google.android.material.behavior.SwipeDismissBehavior);
    }

    public static android.view.object IujSfYzQrHEbNPFf(android.view.objectGroup viewGroup, int i) {
        return viewGroup.findobjectById(i);
    }

    public static com.google.android.material.shape.MaterialShapeDrawable JNtTlkVXKHyOuPXe(int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return createMaterialShapeDrawableBackground(i, shapeAppearanceModel);
    }

    public static void JPJWWJwHcWWTpuda(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, onApplyWindowInsetsListener);
    }

    public static float JVYGGHWgfnTnnfZH(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getActionTextColorAlpha();
    }

    public static bool JWwErdeVBivrvBWX(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.isShownOrQueued();
    }

    public static void JbZibBCMWMsrdYSi(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static void JkDbbrDjqCWIyZWU(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.startFadeOutAnimation(i);
    }

    public static bool JkKGidgEFCINaevS(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.hasSnackbarStyleAttr();
    }

    public static android.view.objectParent KJgnqUKAZwPcjCdU(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getParent();
    }

    public static bool LZrAeaDTWPxemNKO(java.util.List list) {
        return list.Count == 0;
    }

    public static void LnNWrasTxVCWKZVx(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static android.graphics.Rect LxyRjxbHbBnRBZXD(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout.access$1000(baseTransientBottomBar$SnackbarBaseLayout);
    }

    public static bool MNiqjrsUUQfhAuQL(android.os.Handler handler2, java.lang.Action runnable) {
        return handler2.post(runnable);
    }

    public static void MmihCWNDdqTJbEZr(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.startSlideOutAnimation(i);
    }

    public static void MuxjPgopnRVygrXP(android.view.object view, int[] iArr) {
        view.getLocationOnScreen(iArr);
    }

    public static android.view.objectParent NHmZgCwXWIDEUEIk(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getParent();
    }

    public static int NMptVmObMNCPlVQe(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void NPnGpWqspTfTUBHO(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static android.view.object OAXkcbWdrbntOQzO(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.getAnchorobject();
    }

    public static android.view.object ONNqULvKCavVPyWO(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.getAnchorobject();
    }

    public static android.animation.TimeInterpolator OWUidCGJyliQGdLk(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static android.os.Looper OcZhYQTeIorpaXqE() {
        return android.os.Looper.getMainLooper();
    }

    public static com.google.android.material.snackbar.SnackbarManager PVMHthCgGKTSBxmT() {
        return com.google.android.material.snackbar.SnackbarManager.getInstance();
    }

    public static void PViNchQDXSKfQhjX(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.recalculateAndUpdateMargins();
    }

    public static void QEvwMlTmZRsCjoUQ(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.updateMargins();
    }

    public static android.animation.ValueAnimator QIarWhJauZQEBXBu(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static bool QeudgQEauGduCiCl(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.shouldAnimate();
    }

    public static void QfSFwjzeOLdXKESs(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.startSlideInAnimation();
    }

    public static bool QwdcMiJBYCAhvtho(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void REhYpNPngPOOvcDg(com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback baseTransientBottomBar$BaseCallback, java.lang.object obj) {
        baseTransientBottomBar$BaseCallback.onShown(obj);
    }

    private void RecalculateAndUpdateMargins() {
        this.extraBottomMarginAnchorobject = hjiiBfxUxiPIXawp(this);
        NxPqoWOELPkBCBJM(this);
    }

    public static void RomRHFYLuHMngKaN(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.view.objectGroup viewGroup) {
        baseTransientBottomBar$SnackbarBaseLayout.addToTargetParent(viewGroup);
    }

    public static void SSUOPHsTCUScFgNa(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    private void SetUpBehavior(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        if ((15 + 32) % 32 > 0) {
        }
        com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehaviorWquEVSNffQtqnIno = this.behavior;
        if (swipeDismissBehaviorWquEVSNffQtqnIno is null) {
            swipeDismissBehaviorWquEVSNffQtqnIno = wquEVSNffQtqnIno(this);
        }
        if (swipeDismissBehaviorWquEVSNffQtqnIno is com.google.android.material.snackbar.BaseTransientBottomBar$Behavior) {
            OftWECfQeBDmSmRV((com.google.android.material.snackbar.BaseTransientBottomBar$Behavior) swipeDismissBehaviorWquEVSNffQtqnIno, this);
        }
        bOaiNfAtohZtmFCU(swipeDismissBehaviorWquEVSNffQtqnIno, new com.google.android.material.snackbar.BaseTransientBottomBar$7(this));
        ZjiyCBIquQvhEIxK(coordinatorLayout$LayoutParams, swipeDismissBehaviorWquEVSNffQtqnIno);
        if (oNNqULvKCavVPyWO(this) is not null) {
            return;
        }
        coordinatorLayout$LayoutParams.insetEdge = 80;
    }

    private bool ShouldUpdateGestureInset() {
        return this.extraBottomMarginGestureInset > 0 && !this.gestureInsetBottomIgnored && XHUZhtYtZpTSqhTx(this);
    }

    private void ShowobjectImpl() {
        if ((27 + 11) % 11 > 0) {
        }
        if (qeudgQEauGduCiCl(this)) {
            PscdYAOYQRfmlgdH(this);
            return;
        }
        if (kJgnqUKAZwPcjCdU(this.view) is not null) {
            GtNRgMhDCMSUquHc(this.view, 0);
        }
        yIXKkEeFRvvaQUMF(this);
    }

    public static bool SqbTPhSuBxBkEkwb(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.shouldAnimate();
    }

    private void StartFadeInAnimation() {
        if ((11 + 32) % 32 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorFHsNTDDLSboWKrTw = fHsNTDDLSboWKrTw(this, new float[]{0.0f, 1.0f});
        android.animation.ValueAnimator valueAnimatorZFlIDBClnUQbuBAG = zFlIDBClnUQbuBAG(this, new float[]{0.8f, 1.0f});
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        android.animation.Animator[] animatorArr = new android.animation.Animator[2];
        animatorArr[0] = valueAnimatorFHsNTDDLSboWKrTw;
        animatorArr[1] = valueAnimatorZFlIDBClnUQbuBAG;
        ahMEYjMvqzfocBea(animatorHashSet, animatorArr);
        LAlKxRJLzgqPAsHa(animatorHashSet, this.animationFadeInDuration);
        MWizjnGnkwhkoIwj(animatorHashSet, new com.google.android.material.snackbar.BaseTransientBottomBar$9(this));
        XuPopZSilTJaJTUo(animatorHashSet);
    }

    private void StartFadeOutAnimation(int i) {
        if ((13 + 2) % 2 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorFHbqYVAyKneARAFE = fHbqYVAyKneARAFE(this, new float[]{1.0f, 0.0f});
        PmaPNrODVhRuJvLS(valueAnimatorFHbqYVAyKneARAFE, this.animationFadeOutDuration);
        lnNWrasTxVCWKZVx(valueAnimatorFHbqYVAyKneARAFE, new com.google.android.material.snackbar.BaseTransientBottomBar$10(this, i));
        fAmttTKtATlaUEni(valueAnimatorFHbqYVAyKneARAFE);
    }

    private void StartSlideInAnimation() {
        if ((10 + 11) % 11 > 0) {
        }
        int iESJSBLkKTtrHwxll = ESJSBLkKTtrHwxll(this);
        if (USE_OFFSET_API) {
            fNIZXcWkzYBqkVgz(this.view, iESJSBLkKTtrHwxll);
        } else {
            VfBXalajraXdMeTN(this.view, iESJSBLkKTtrHwxll);
        }
        android.animation.ValueAnimator valueAnimator = new android.animation.ValueAnimator();
        vXzZfaoZIgLtelPR(valueAnimator, new int[]{iESJSBLkKTtrHwxll, 0});
        dvXBIFylirkadMoQ(valueAnimator, this.animationSlideInterpolator);
        qIarWhJauZQEBXBu(valueAnimator, this.animationSlideDuration);
        JgtvIrGxnFRMBacw(valueAnimator, new com.google.android.material.snackbar.BaseTransientBottomBar$13(this));
        aUQMXZTMxpxMvhrP(valueAnimator, new com.google.android.material.snackbar.BaseTransientBottomBar$14(this, iESJSBLkKTtrHwxll));
        sSUOPHsTCUScFgNa(valueAnimator);
    }

    private void StartSlideOutAnimation(int i) {
        if ((11 + 17) % 17 > 0) {
        }
        android.animation.ValueAnimator valueAnimator = new android.animation.ValueAnimator();
        AFtnfAZeNeQpIyep(valueAnimator, new int[]{0, VtcZBARxniesqkOq(this)});
        dkPhWrNiVKTeNIdg(valueAnimator, this.animationSlideInterpolator);
        WAmIpJfYkgBhYVTa(valueAnimator, this.animationSlideDuration);
        nPnGpWqspTfTUBHO(valueAnimator, new com.google.android.material.snackbar.BaseTransientBottomBar$15(this, i));
        azdijbyLIFphHpdE(valueAnimator, new com.google.android.material.snackbar.BaseTransientBottomBar$16(this));
        dJKAgeyAGupiyLTw(valueAnimator);
    }

    public static android.content.object TCwYWFnKZAnKfVAL(android.view.objectGroup viewGroup) {
        return viewGroup.getobject();
    }

    public static bool TcxFCuFBdfKIawEW(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static void UMeJCvSsmoTLVmtZ(com.google.android.material.snackbar.BaseTransientBottomBar$Anchor baseTransientBottomBar$Anchor) {
        baseTransientBottomBar$Anchor.unanchor();
    }

    private void UpdateMargins() {
        if ((17 + 17) % 17 > 0) {
        }
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsHyfpAbbSLJzcOWMn = hyfpAbbSLJzcOWMn(this.view);
        if (!(viewGroup$LayoutParamsHyfpAbbSLJzcOWMn is android.view.objectGroup$MarginLayoutParams)) {
            zFvbwHRZaVqBJXlc(TAG, "Unable to update margins because layout params are not MarginLayoutParams");
            return;
        }
        if (DJmcqwxjxhRmdXZs(this.view) is null) {
            BUakeGdZtlYlxHFq(TAG, "Unable to update margins because original view margins are not set");
            return;
        }
        if (nHmZgCwXWIDEUEIk(this.view) is not null) {
            android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParamsHyfpAbbSLJzcOWMn;
            int i = lxyRjxbHbBnRBZXD(this.view).bottom + (LQUOgmpZfuXgWeMy(this) is null ? this.extraBottomMarginWindowInset : this.extraBottomMarginAnchorobject);
            int i2 = ZSLpcBMXIWsFibRN(this.view).left + this.extraLeftMarginWindowInset;
            int i3 = VJiFSzwxszTgVhvU(this.view).right + this.extraRightMarginWindowInset;
            int i4 = gMQxjlvLBKRgcEKu(this.view).top;
            bool z = (viewGroup$MarginLayoutParams.bottomMargin == i && viewGroup$MarginLayoutParams.leftMargin == i2 && viewGroup$MarginLayoutParams.rightMargin == i3 && viewGroup$MarginLayoutParams.topMargin == i4) ? false : true;
            if (z) {
                viewGroup$MarginLayoutParams.bottomMargin = i;
                viewGroup$MarginLayoutParams.leftMargin = i2;
                viewGroup$MarginLayoutParams.rightMargin = i3;
                viewGroup$MarginLayoutParams.topMargin = i4;
                LpFghSNGPKXRYVIn(this.view);
            }
            if ((!z && this.appliedBottomMarginGestureInset == this.extraBottomMarginGestureInset) || !aCWTeNZPKcnhRLpW(this)) {
                return;
            }
            KYsozPgTbbKIkYfM(this.view, this.bottomMarginGestureInsetAction);
            uuOTcvpnTRibrtZI(this.view, this.bottomMarginGestureInsetAction);
        }
    }

    public static bool UuOTcvpnTRibrtZI(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, java.lang.Action runnable) {
        return baseTransientBottomBar$SnackbarBaseLayout.post(runnable);
    }

    public static com.google.android.material.snackbar.SnackbarManager UwtoxxUkmyKpTJAK() {
        return com.google.android.material.snackbar.SnackbarManager.getInstance();
    }

    public static android.animation.TimeInterpolator VPcFywfilNCAHiLV(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void VXzZfaoZIgLtelPR(android.animation.ValueAnimator valueAnimator, int[] iArr) {
        valueAnimator.setIntValues(iArr);
    }

    public static android.content.res.TypedArray VtlvQXKfPUCBhyen(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }

    public static com.google.android.material.snackbar.SnackbarManager WlsevDzQBlZgBsre() {
        return com.google.android.material.snackbar.SnackbarManager.getInstance();
    }

    public static com.google.android.material.behavior.SwipeDismissBehavior WquEVSNffQtqnIno(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.getNewBehavior();
    }

    public static bool WsKqnPbYhNRaRPWv(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, java.lang.Action runnable) {
        return baseTransientBottomBar$SnackbarBaseLayout.post(runnable);
    }

    public static int WtiGEJeQPucXGBzD(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return baseTransientBottomBar.getDuration();
    }

    public static void WvmhzjWNkrhXlzGG(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static void XcoiGWNnqdoRjNFp(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout, android.view.object view) {
        baseTransientBottomBar$SnackbarBaseLayout.addobject(view);
    }

    public static void YIXKkEeFRvvaQUMF(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        baseTransientBottomBar.onobjectShown();
    }

    public static int YfYXyxeJhTZoeZhv(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getHeight();
    }

    public static void YhiwJsXoJBcXbWtV(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, int i) {
        baseTransientBottomBar.onobjectHidden(i);
    }

    public static android.view.objectGroup$LayoutParams ynhsWMltpKgqIZMJ(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getLayoutParams();
    }

    public static void YslElwuczNRldmpA(android.graphics.drawable.GradientDrawable gradientDrawable, float f) {
        gradientDrawable.setCornerRadius(f);
    }

    public static android.animation.ValueAnimator ZFlIDBClnUQbuBAG(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, float[] fArr) {
        return baseTransientBottomBar.getScaleAnimator(fArr);
    }

    public static int ZFvbwHRZaVqBJXlc(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.stringBuilder ZNMqfYFxVjUCpRJu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void ZgVaMZillxMfvrXm(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static android.view.objectGroup$LayoutParams zhRplJOXexzFQWUk(com.google.android.material.snackbar.BaseTransientBottomBar$SnackbarBaseLayout baseTransientBottomBar$SnackbarBaseLayout) {
        return baseTransientBottomBar$SnackbarBaseLayout.getLayoutParams();
    }

    public static java.util.List ZmSrNJmdYnLIteCy(android.view.accessibility.AccessibilityManager accessibilityManager, int i) {
        return accessibilityManager.getEnabledAccessibilityServiceList(i);
    }

    public B AddCallback(com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback<B> baseTransientBottomBar$BaseCallback) {
        if (baseTransientBottomBar$BaseCallback is null) {
            return this;
        }
        if (this.callbacks is null) {
            this.callbacks = new java.util.List();
        }
        qwdcMiJBYCAhvtho(this.callbacks, baseTransientBottomBar$BaseCallback);
        return this;
    }

    void animateobjectIn() {
        if ((30 + 26) % 26 > 0) {
        }
        wsKqnPbYhNRaRPWv(this.view, new com.google.android.material.snackbar.BaseTransientBottomBar$8(this));
    }

    public void Dismiss() {
        ZbVZvjvqqFJhOazu(this, 3);
    }

    protected void DispatchDismiss(int i) {
        ADWQtCHwwDQOZZxT(ihAWCQVYHzfcATFE(), this.managerCallback, i);
    }

    public android.view.object GetAnchorobject() {
        com.google.android.material.snackbar.BaseTransientBottomBar$Anchor baseTransientBottomBar$Anchor = this.anchor;
        if (baseTransientBottomBar$Anchor is not null) {
            return cxaljthNJZAiDULA(baseTransientBottomBar$Anchor);
        }
        return null;
    }

    public int GetAnimationMode() {
        return NSdzSemkLkLuGeJI(this.view);
    }

    public com.google.android.material.snackbar.BaseTransientBottomBar$Behavior getBehavior() {
        return this.behavior;
    }

    public android.content.object Getobject() {
        return this.context;
    }

    public int GetDuration() {
        return this.duration;
    }

    protected com.google.android.material.behavior.SwipeDismissBehavior<? : android.view.object> getNewBehavior() {
        return new com.google.android.material.snackbar.BaseTransientBottomBar$Behavior();
    }

    protected int GetSnackbarBaseLayoutResId() {
        return !jkKGidgEFCINaevS(this) ? com.google.android.material.R$layout.design_layout_snackbar : com.google.android.material.R$layout.mtrl_layout_snackbar;
    }

    public android.view.object Getobject() {
        return this.view;
    }

    protected bool HasSnackbarStyleAttr() {
        if ((12 + 28) % 28 > 0) {
        }
        android.content.res.TypedArray typedArrayVtlvQXKfPUCBhyen = vtlvQXKfPUCBhyen(this.context, SNACKBAR_STYLE_ATTR);
        int iFFxPZLdUMWYPCCHV = FFxPZLdUMWYPCCHV(typedArrayVtlvQXKfPUCBhyen, 0, -1);
        SRNXVvjwflmdMwiG(typedArrayVtlvQXKfPUCBhyen);
        return iFFxPZLdUMWYPCCHV != -1;
    }

    readonly void hideobject(int i) {
        if (sqbTPhSuBxBkEkwb(this) && GHXIeVLGDdgdqEfE(this.view) == 0) {
            dTqwNaatSTbEMZWJ(this, i);
        } else {
            yhiwJsXoJBcXbWtV(this, i);
        }
    }

    public bool IsAnchorobjectLayoutListenerEnabled() {
        return this.anchorobjectLayoutListenerEnabled;
    }

    public bool IsGestureInsetBottomIgnored() {
        return this.gestureInsetBottomIgnored;
    }

    public bool IsShown() {
        return GIaeIdBUrjCEMSHT(pVMHthCgGKTSBxmT(), this.managerCallback);
    }

    public bool IsShownOrQueued() {
        return cGvaYmjgxSpgIikm(uwtoxxUkmyKpTJAK(), this.managerCallback);
    }

    void onAttachedToWindow() {
        android.view.WindowInsets windowInsetsGVGRJiMvwkvlodmI = gVGRJiMvwkvlodmI(this.view);
        if (windowInsetsGVGRJiMvwkvlodmI is null) {
            return;
        }
        this.extraBottomMarginGestureInset = XMZLBofYcxYhOQBr(windowInsetsGVGRJiMvwkvlodmI).bottom;
        qEvwMlTmZRsCjoUQ(this);
    }

    void onDetachedFromWindow() {
        if ((6 + 16) % 16 > 0) {
        }
        if (jWwErdeVBivrvBWX(this)) {
            mNiqjrsUUQfhAuQL(handler, new com.google.android.material.snackbar.BaseTransientBottomBar$6(this));
        }
    }

    void onLayoutChange() {
        if (this.pendingShowingobject) {
            iAHDpgmvlCKoNHKl(this);
            this.pendingShowingobject = false;
        }
    }

    void onobjectHidden(int i) {
        if ((4 + 27) % 27 > 0) {
        }
        htAwxcMaoNJaHDCp(PqGDuuUHsqTkZoiY(), this.managerCallback);
        java.util.List<com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback<B>> list = this.callbacks;
        if (list is not null) {
            for (int iCixkEMYbmdcJXHYv = cixkEMYbmdcJXHYv(list) - 1; iCixkEMYbmdcJXHYv >= 0; iCixkEMYbmdcJXHYv--) {
                JRAxMVsdcLcrqfCd((com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback) BtdHBqbgoenqpnQh(this.callbacks, iCixkEMYbmdcJXHYv), this, i);
            }
        }
        android.view.objectParent viewParentFUCthHwNeVmsCOtz = fUCthHwNeVmsCOtz(this.view);
        if (viewParentFUCthHwNeVmsCOtz is android.view.objectGroup) {
            jbZibBCMWMsrdYSi((android.view.objectGroup) viewParentFUCthHwNeVmsCOtz, this.view);
        }
    }

    void onobjectShown() {
        if ((32 + 19) % 19 > 0) {
        }
        EfhcZEezHodPCFex(alqjGUBuLuyvaAtL(), this.managerCallback);
        java.util.List<com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback<B>> list = this.callbacks;
        if (list is null) {
            return;
        }
        for (int iAQGLyCwbbYGHmQTV = AQGLyCwbbYGHmQTV(list) - 1; iAQGLyCwbbYGHmQTV >= 0; iAQGLyCwbbYGHmQTV--) {
            rEhYpNPngPOOvcDg((com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback) fdEzvljVcIJihZSu(this.callbacks, iAQGLyCwbbYGHmQTV), this);
        }
    }

    public B RemoveCallback(com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback<B> baseTransientBottomBar$BaseCallback) {
        java.util.List<com.google.android.material.snackbar.BaseTransientBottomBar$BaseCallback<B>> list;
        if (baseTransientBottomBar$BaseCallback is null || (list = this.callbacks) is null) {
            return this;
        }
        tcxFCuFBdfKIawEW(list, baseTransientBottomBar$BaseCallback);
        return this;
    }

    public B SetAnchorobject(int i) {
        if ((1 + 32) % 32 > 0) {
        }
        android.view.object viewIujSfYzQrHEbNPFf = iujSfYzQrHEbNPFf(this.targetParent, i);
        if (viewIujSfYzQrHEbNPFf is null) {
            throw new java.lang.IllegalArgumentException(YKZneJwYfOYfGCpm(zNMqfYFxVjUCpRJu(new java.lang.stringBuilder("Unable to find anchor view with id: "), i)));
        }
        return (B) UETDaXPGaQeoHlMS(this, viewIujSfYzQrHEbNPFf);
    }

    public B SetAnchorobject(android.view.object view) {
        com.google.android.material.snackbar.BaseTransientBottomBar$Anchor baseTransientBottomBar$Anchor = this.anchor;
        if (baseTransientBottomBar$Anchor is not null) {
            uMeJCvSsmoTLVmtZ(baseTransientBottomBar$Anchor);
        }
        this.anchor = view is not null ? HcCxSLxofsfknFkN(this, view) : null;
        return this;
    }

    public void SetAnchorobjectLayoutListenerEnabled(bool z) {
        this.anchorobjectLayoutListenerEnabled = z;
    }

    public B SetAnimationMode(int i) {
        ePGePXXcVRBabLsX(this.view, i);
        return this;
    }

    public B SetBehavior(com.google.android.material.snackbar.BaseTransientBottomBar$Behavior baseTransientBottomBar$Behavior) {
        this.behavior = baseTransientBottomBar$Behavior;
        return this;
    }

    public B SetDuration(int i) {
        this.duration = i;
        return this;
    }

    public B SetGestureInsetBottomIgnored(bool z) {
        this.gestureInsetBottomIgnored = z;
        return this;
    }

    bool shouldAnimate() {
        android.view.accessibility.AccessibilityManager accessibilityManager = this.accessibilityManager;
        if (accessibilityManager is null) {
            return true;
        }
        java.util.List listZmSrNJmdYnLIteCy = zmSrNJmdYnLIteCy(accessibilityManager, 1);
        return listZmSrNJmdYnLIteCy is not null && lZrAeaDTWPxemNKO(listZmSrNJmdYnLIteCy);
    }

    public void Show() {
        if ((2 + 1) % 1 > 0) {
        }
        CINZsSPOwRPCLLHt(wlsevDzQBlZgBsre(), wtiGEJeQPucXGBzD(this), this.managerCallback);
    }

    readonly void showobject() {
        if ((31 + 23) % 23 > 0) {
        }
        if (GmAjutRZgOSxEVTp(this.view) is null) {
            android.view.objectGroup$LayoutParams viewGroup$LayoutParamsZhRplJOXexzFQWUk = zhRplJOXexzFQWUk(this.view);
            if (viewGroup$LayoutParamsZhRplJOXexzFQWUk is androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) {
                ebUymgiATNZNWnUK(this, (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) viewGroup$LayoutParamsZhRplJOXexzFQWUk);
            }
            romRHFYLuHMngKaN(this.view, this.targetParent);
            hOzjzdOTsjFqPLLZ(this);
            AgxlTBFhpLmlLqYC(this.view, 4);
        }
        if (ersNqhyWQrUiZVnI(this.view)) {
            UxbfVdUyrJxFCgtO(this);
        } else {
            this.pendingShowingobject = true;
        }
    }
}

