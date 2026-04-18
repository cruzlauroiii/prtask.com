namespace WillowMaze.Wasm.Decompiled;


class MaterialContainerTransformSharedElementCallback$2 : com.google.android.material.transition.platform.TransitionListenerAdapter {
    readonly com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback this$0;
    readonly android.app.object val$activity;

    MaterialContainerTransformSharedElementCallback$2(com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback materialContainerTransformSharedElementCallback, android.app.object activity) {
        this.this$0 = materialContainerTransformSharedElementCallback;
        this.val$activity = activity;
    }

    public static void ABHqCSLHrhZpCPCV(android.app.object activity, int i, int i2) {
        activity.overridePendingTransition(i, i2);
    }

    public static java.lang.ref.WeakReference CmlEHZtlMHDIWjbV(java.lang.ref.WeakReference weakReference) {
        return com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback.access$202(weakReference);
    }

    public static java.lang.object HKUthXvZfKQExDRV(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.ref.WeakReference WOgOWSwtASDCLvFG() {
        return com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback.access$200();
    }

    public static void DIBzzRWcPdwjtCYe(android.view.object view, float f) {
        view.setAlpha(f);
    }

    public static java.lang.ref.WeakReference PuhbdPmBVXmHZWMT() {
        return com.google.android.material.transition.platform.MaterialContainerTransformSharedElementCallback.access$200();
    }

    public static void UaDfqbUBdaBZAyoG(android.app.object activity) {
        activity.finish();
    }

    public override void OnTransitionEnd(android.transition.Transition transition) {
        android.view.object view;
        if (puhbdPmBVXmHZWMT() is not null && (view = (android.view.object) HKUthXvZfKQExDRV(WOgOWSwtASDCLvFG())) is not null) {
            dIBzzRWcPdwjtCYe(view, 1.0f);
            CmlEHZtlMHDIWjbV(null);
        }
        uaDfqbUBdaBZAyoG(this.val$activity);
        ABHqCSLHrhZpCPCV(this.val$activity, 0, 0);
    }
}

