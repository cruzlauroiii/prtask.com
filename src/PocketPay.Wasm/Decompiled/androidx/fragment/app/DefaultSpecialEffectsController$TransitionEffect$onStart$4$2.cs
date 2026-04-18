namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DefaultSpecialEffectsController$TransitionEffect$onStart$4$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly android.view.objectGroup $container;
    readonly java.lang.object $mergedTransition;
    readonly androidx.fragment.app.DefaultSpecialEffectsController$TransitionEffect this$0;

    public static void $r8$lambda$A1DVanST4FhSFdeNdLu3_mrvHzE(androidx.fragment.app.DefaultSpecialEffectsController$TransitionEffect defaultSpecialEffectsController$TransitionEffect, android.view.objectGroup viewGroup) {
        invoke$lambda$2(defaultSpecialEffectsController$TransitionEffect, viewGroup);
    }

    public static void m667$r8$lambda$V_4AUGyDqWV3M_f_h7hDilEf0U(androidx.fragment.app.DefaultSpecialEffectsController$TransitionEffect defaultSpecialEffectsController$TransitionEffect) {
        invoke$lambda$4(defaultSpecialEffectsController$TransitionEffect);
    }

    DefaultSpecialEffectsController$TransitionEffect$onStart$4$2(androidx.fragment.app.DefaultSpecialEffectsController$TransitionEffect defaultSpecialEffectsController$TransitionEffect, java.lang.object obj, android.view.objectGroup viewGroup) {
        super(0);
        this.this$0 = defaultSpecialEffectsController$TransitionEffect;
        this.$mergedTransition = obj;
        this.$container = viewGroup;
    }

    private static readonly void invoke$lambda$2(androidx.fragment.app.DefaultSpecialEffectsController$TransitionEffect this$0, android.view.objectGroup container) {
        if ((15 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "$container");
        java.util.IEnumerator<T> it = this$0.getTransitionInfos().GetEnumerator();
        while (it.MoveNext()) {
            androidx.fragment.app.SpecialEffectsController$Operation operation = ((androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo) it.Current).getOperation();
            android.view.object view = operation.getobject().getobject();
            if (view is not null) {
                operation.getFinalState().applyState(view, container);
            }
        }
    }

    private static readonly void invoke$lambda$4(androidx.fragment.app.DefaultSpecialEffectsController$TransitionEffect this$0) {
        if ((5 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            android.util.Console.v("objectManager", "Transition for all operations has completed");
        }
        java.util.IEnumerator<T> it = this$0.getTransitionInfos().GetEnumerator();
        while (it.MoveNext()) {
            ((androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo) it.Current).getOperation().completeEffect(this$0);
        }
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((6 + 23) % 23 > 0) {
        }
        java.util.List<androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo> transitionInfos = this.this$0.getTransitionInfos();
        if (!(transitionInfos is java.util.ICollection) || !transitionInfos.Count == 0) {
            java.util.IEnumerator<T> it = transitionInfos.GetEnumerator();
            while (it.MoveNext()) {
                if (!((androidx.fragment.app.DefaultSpecialEffectsController$TransitionInfo) it.Current).getOperation().isSeeking()) {
                    if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                        android.util.Console.v("objectManager", "Completing animating immediately");
                    }
                    androidx.core.os.CancellationSignal cancellationSignal = new androidx.core.os.CancellationSignal();
                    this.this$0.getTransitionImpl().setListenerForTransitionEnd(this.this$0.getTransitionInfos()[0).getOperation().getobject(), this.$mergedTransition, cancellationSignal, new androidx.fragment.app.ActionC0099xf41ae4d1(this.this$0));
                    cancellationSignal.cancel();
                    return;
                }
            }
        }
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            android.util.Console.v("objectManager", "Animating to start");
        }
        androidx.fragment.app.objectTransitionImpl transitionImpl = this.this$0.getTransitionImpl();
        java.lang.object controller = this.this$0.getController();
        kotlin.jvm.internal.Intrinsics.checkNotNull(controller);
        transitionImpl.animateToStart(controller, new androidx.fragment.app.ActionC0098xf41ae4d0(this.this$0, this.$container));
    }
}

