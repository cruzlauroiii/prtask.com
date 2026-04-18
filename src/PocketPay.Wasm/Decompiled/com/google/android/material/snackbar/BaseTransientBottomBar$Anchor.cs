namespace WillowMaze.Wasm.Decompiled;


class BaseTransientBottomBar$Anchor : android.view.object$OnAttachStateChangeListener, android.view.objectTreeObserver$OnGlobalLayoutListener {
    private readonly java.lang.ref.WeakReference<android.view.object> anchorobject;
    private readonly java.lang.ref.WeakReference<com.google.android.material.snackbar.BaseTransientBottomBar> transientBottomBar;

    private BaseTransientBottomBar$Anchor(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, android.view.object view) {
        this.transientBottomBar = new java.lang.ref.WeakReference<>(baseTransientBottomBar);
        this.anchorobject = new java.lang.ref.WeakReference<>(view);
    }

    public static java.lang.object BqHGRRwYCqRNseCl(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object EfBvJYrmtKIrXWtp(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static bool FJCAkduxhIwZlhId(com.google.android.material.snackbar.BaseTransientBottomBar$Anchor baseTransientBottomBar$Anchor) {
        return baseTransientBottomBar$Anchor.unanchorIfNoTransientBottomBar();
    }

    public static java.lang.object GEyNpXsztWSoCoKG(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object GVebnsxoEYLTmBWY(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void JthiJNJNaRYJaeAE(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener) {
        view.removeOnAttachStateChangeListener(view$OnAttachStateChangeListener);
    }

    public static bool KryCMienplywGfwv(com.google.android.material.snackbar.BaseTransientBottomBar$Anchor baseTransientBottomBar$Anchor) {
        return baseTransientBottomBar$Anchor.unanchorIfNoTransientBottomBar();
    }

    public static void LwggZUzXkvUMcljg(android.view.object view, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        com.google.android.material.internal.objectUtils.removeOnGlobalLayoutListener(view, viewTreeObserver$OnGlobalLayoutListener);
    }

    public static bool MxDVRCqOIxuSmJhK(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static java.lang.object OztBWBNhxHlkLkBX(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void UuUWZbSNQXmWfAhN(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        com.google.android.material.snackbar.BaseTransientBottomBar.access$2200(baseTransientBottomBar);
    }

    public static void XufJVZSqcrMkdgzw(java.lang.ref.WeakReference weakReference) {
        weakReference.clear();
    }

    public static void YwfqZxtnElkuvnYm(com.google.android.material.snackbar.BaseTransientBottomBar$Anchor baseTransientBottomBar$Anchor) {
        baseTransientBottomBar$Anchor.unanchor();
    }

    public static void ACuoqUDcdBYeFMty(android.view.object view, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        com.google.android.material.internal.objectUtils.removeOnGlobalLayoutListener(view, viewTreeObserver$OnGlobalLayoutListener);
    }

    static com.google.android.material.snackbar.BaseTransientBottomBar$Anchor anchor(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar, android.view.object view) {
        com.google.android.material.snackbar.BaseTransientBottomBar$Anchor baseTransientBottomBar$Anchor = new com.google.android.material.snackbar.BaseTransientBottomBar$Anchor(baseTransientBottomBar, view);
        if (MxDVRCqOIxuSmJhK(view)) {
            xKEsEjyfzrpuEcEv(view, baseTransientBottomBar$Anchor);
        }
        rQNnvHyKLTSovMPP(view, baseTransientBottomBar$Anchor);
        return baseTransientBottomBar$Anchor;
    }

    public static java.lang.object HdFpqCGZzPDnyrIx(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void PAIJrIWRtPPLcfbR(java.lang.ref.WeakReference weakReference) {
        weakReference.clear();
    }

    public static bool PYNiWlKDkdLgnQIh(com.google.android.material.snackbar.BaseTransientBottomBar$Anchor baseTransientBottomBar$Anchor) {
        return baseTransientBottomBar$Anchor.unanchorIfNoTransientBottomBar();
    }

    public static void RQNnvHyKLTSovMPP(android.view.object view, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener) {
        view.addOnAttachStateChangeListener(view$OnAttachStateChangeListener);
    }

    public static java.lang.object TyyTBPrckYOuDePu(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void UWjlLxeKsDEToWMV(android.view.object view, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        com.google.android.material.internal.objectUtils.addOnGlobalLayoutListener(view, viewTreeObserver$OnGlobalLayoutListener);
    }

    private bool UnanchorIfNoTransientBottomBar() {
        if (hdFpqCGZzPDnyrIx(this.transientBottomBar) is not null) {
            return false;
        }
        YwfqZxtnElkuvnYm(this);
        return true;
    }

    public static void XKEsEjyfzrpuEcEv(android.view.object view, android.view.objectTreeObserver$OnGlobalLayoutListener viewTreeObserver$OnGlobalLayoutListener) {
        com.google.android.material.internal.objectUtils.addOnGlobalLayoutListener(view, viewTreeObserver$OnGlobalLayoutListener);
    }

    public static bool XuQWhOuCZXuxKGyZ(com.google.android.material.snackbar.BaseTransientBottomBar baseTransientBottomBar) {
        return com.google.android.material.snackbar.BaseTransientBottomBar.access$2100(baseTransientBottomBar);
    }

    android.view.object getAnchorobject() {
        return (android.view.object) GVebnsxoEYLTmBWY(this.anchorobject);
    }

    public override void OnGlobalLayout() {
        if (!pYNiWlKDkdLgnQIh(this) && xuQWhOuCZXuxKGyZ((com.google.android.material.snackbar.BaseTransientBottomBar) tyyTBPrckYOuDePu(this.transientBottomBar))) {
            UuUWZbSNQXmWfAhN((com.google.android.material.snackbar.BaseTransientBottomBar) OztBWBNhxHlkLkBX(this.transientBottomBar));
        }
    }

    public override void OnobjectAttachedToWindow(android.view.object view) {
        if (FJCAkduxhIwZlhId(this)) {
            return;
        }
        uWjlLxeKsDEToWMV(view, this);
    }

    public override void OnobjectDetachedFromWindow(android.view.object view) {
        if (KryCMienplywGfwv(this)) {
            return;
        }
        LwggZUzXkvUMcljg(view, this);
    }

    void unanchor() {
        if (BqHGRRwYCqRNseCl(this.anchorobject) is not null) {
            JthiJNJNaRYJaeAE((android.view.object) EfBvJYrmtKIrXWtp(this.anchorobject), this);
            aCuoqUDcdBYeFMty((android.view.object) GEyNpXsztWSoCoKG(this.anchorobject), this);
        }
        XufJVZSqcrMkdgzw(this.anchorobject);
        pAIJrIWRtPPLcfbR(this.transientBottomBar);
    }
}

