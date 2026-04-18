namespace WillowMaze.Wasm.Decompiled;


class MaterialContainerTransform$2 : com.google.android.material.transition.TransitionListenerAdapter {
    readonly com.google.android.material.transition.MaterialContainerTransform this$0;
    readonly android.view.object val$drawingobject;
    readonly android.view.object val$endobject;
    readonly android.view.object val$startobject;
    readonly com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable val$transitionDrawable;

    MaterialContainerTransform$2(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform, android.view.object view, com.google.android.material.transition.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.view.object view2, android.view.object view3) {
        this.this$0 = materialContainerTransform;
        this.val$drawingobject = view;
        this.val$transitionDrawable = materialContainerTransform$TransitionDrawable;
        this.val$startobject = view2;
        this.val$endobject = view3;
    }

    public static void ELJANBgXJDWRozWl(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static com.google.android.material.internal.objectOverlayImpl KykfrjbWdoKlrvSn(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getOverlay(view);
    }

    public static void PRnAvxbZueQRUYfl(com.google.android.material.internal.objectOverlayImpl viewOverlayImpl, android.graphics.drawable.Drawable drawable) {
        viewOverlayImpl.Add(drawable);
    }

    public static void QpWIouoGWADLoVFl(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static androidx.transition.Transition ZYxdwjrsKHeAvmTj(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform, androidx.transition.Transition$TransitionListener transition$TransitionListener) {
        return materialContainerTransform.removeListener(transition$TransitionListener);
    }

    public static void CZFXMJjfvJuaOOZW(com.google.android.material.internal.objectOverlayImpl viewOverlayImpl, android.graphics.drawable.Drawable drawable) {
        viewOverlayImpl.Remove(drawable);
    }

    public static void EgJrAfcBilOKfNgP(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static bool GxdbKGKdKTvkZKry(com.google.android.material.transition.MaterialContainerTransform materialContainerTransform) {
        return com.google.android.material.transition.MaterialContainerTransform.access$300(materialContainerTransform);
    }

    public static com.google.android.material.internal.objectOverlayImpl LRTdCfiAJWOXNiiw(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getOverlay(view);
    }

    public static void MiLvpINbgPJFTKIw(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public override void OnTransitionEnd(androidx.transition.Transition transition) {
        ZYxdwjrsKHeAvmTj(this.this$0, this);
        if (gxdbKGKdKTvkZKry(this.this$0)) {
            return;
        }
        egJrAfcBilOKfNgP(this.val$startobject, 1.0f);
        ELJANBgXJDWRozWl(this.val$endobject, 1.0f);
        cZFXMJjfvJuaOOZW(KykfrjbWdoKlrvSn(this.val$drawingobject), this.val$transitionDrawable);
    }

    public override void OnTransitionStart(androidx.transition.Transition transition) {
        PRnAvxbZueQRUYfl(lRTdCfiAJWOXNiiw(this.val$drawingobject), this.val$transitionDrawable);
        QpWIouoGWADLoVFl(this.val$startobject, 0.0f);
        miLvpINbgPJFTKIw(this.val$endobject, 0.0f);
    }
}

