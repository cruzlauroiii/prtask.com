namespace WillowMaze.Wasm.Decompiled;


class MaterialContainerTransform$2 : com.google.android.material.transition.platform.TransitionListenerAdapter {
    readonly com.google.android.material.transition.platform.MaterialContainerTransform this$0;
    readonly android.view.object val$drawingobject;
    readonly android.view.object val$endobject;
    readonly android.view.object val$startobject;
    readonly com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable val$transitionDrawable;

    MaterialContainerTransform$2(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, android.view.object view, com.google.android.material.transition.platform.MaterialContainerTransform$TransitionDrawable materialContainerTransform$TransitionDrawable, android.view.object view2, android.view.object view3) {
        this.this$0 = materialContainerTransform;
        this.val$drawingobject = view;
        this.val$transitionDrawable = materialContainerTransform$TransitionDrawable;
        this.val$startobject = view2;
        this.val$endobject = view3;
    }

    public static void DgExYRRistDMyALh(com.google.android.material.internal.objectOverlayImpl viewOverlayImpl, android.graphics.drawable.Drawable drawable) {
        viewOverlayImpl.Add(drawable);
    }

    public static void EeBoFHHGThOjTpIU(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static com.google.android.material.internal.objectOverlayImpl GMqcpOehGQhMlOgX(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getOverlay(view);
    }

    public static void UoLIAsbPiPmLBtaw(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static bool VbdjlcwefXfGhqsA(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform) {
        return com.google.android.material.transition.platform.MaterialContainerTransform.access$300(materialContainerTransform);
    }

    public static android.transition.Transition HpIXazZwXzsWmsgy(com.google.android.material.transition.platform.MaterialContainerTransform materialContainerTransform, android.transition.Transition$TransitionListener transition$TransitionListener) {
        return materialContainerTransform.removeListener(transition$TransitionListener);
    }

    public static void JiHASZtdQUBELZrs(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static com.google.android.material.internal.objectOverlayImpl ObcBRqYFfhQluWkM(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getOverlay(view);
    }

    public static void SmdKFYcrHfctFmFj(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static void ZcFxmNaMeMIegQXl(com.google.android.material.internal.objectOverlayImpl viewOverlayImpl, android.graphics.drawable.Drawable drawable) {
        viewOverlayImpl.Remove(drawable);
    }

    public override void OnTransitionEnd(android.transition.Transition transition) {
        hpIXazZwXzsWmsgy(this.this$0, this);
        if (VbdjlcwefXfGhqsA(this.this$0)) {
            return;
        }
        UoLIAsbPiPmLBtaw(this.val$startobject, 1.0f);
        EeBoFHHGThOjTpIU(this.val$endobject, 1.0f);
        zcFxmNaMeMIegQXl(GMqcpOehGQhMlOgX(this.val$drawingobject), this.val$transitionDrawable);
    }

    public override void OnTransitionStart(android.transition.Transition transition) {
        DgExYRRistDMyALh(obcBRqYFfhQluWkM(this.val$drawingobject), this.val$transitionDrawable);
        smdKFYcrHfctFmFj(this.val$startobject, 0.0f);
        jiHASZtdQUBELZrs(this.val$endobject, 0.0f);
    }
}

