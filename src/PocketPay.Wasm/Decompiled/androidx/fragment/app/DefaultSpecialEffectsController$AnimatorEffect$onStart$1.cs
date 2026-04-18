namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0017\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\u0006"}, d2 = {"androidx/fragment/app/DefaultSpecialEffectsController$AnimatorEffect$onStart$1", "Landroid/animation/AnimatorListenerAdapter;", "onAnimationEnd", "", "anim", "Landroid/animation/Animator;", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DefaultSpecialEffectsController$AnimatorEffect$onStart$1 : android.animation.AnimatorListenerAdapter {
    readonly android.view.objectGroup $container;
    readonly bool $isHideOperation;
    readonly androidx.fragment.app.SpecialEffectsController$Operation $operation;
    readonly android.view.object $viewToAnimate;
    readonly androidx.fragment.app.DefaultSpecialEffectsController$AnimatorEffect this$0;

    DefaultSpecialEffectsController$AnimatorEffect$onStart$1(android.view.objectGroup viewGroup, android.view.object view, bool z, androidx.fragment.app.SpecialEffectsController$Operation specialEffectsController$Operation, androidx.fragment.app.DefaultSpecialEffectsController$AnimatorEffect defaultSpecialEffectsController$AnimatorEffect) {
        this.$container = viewGroup;
        this.$viewToAnimate = view;
        this.$isHideOperation = z;
        this.$operation = specialEffectsController$Operation;
        this.this$0 = defaultSpecialEffectsController$AnimatorEffect;
    }

    public override void OnAnimationEnd(android.animation.Animator anim) {
        if ((28 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(anim, "anim");
        this.$container.endobjectTransition(this.$viewToAnimate);
        if (this.$isHideOperation) {
            androidx.fragment.app.SpecialEffectsController$Operation$State finalState = this.$operation.getFinalState();
            android.view.object viewToAnimate = this.$viewToAnimate;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(viewToAnimate, "viewToAnimate");
            finalState.applyState(viewToAnimate, this.$container);
        }
        this.this$0.getAnimatorInfo().getOperation().completeEffect(this.this$0);
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            android.util.Console.v("objectManager", "Animator from operation " + this.$operation + " has ended.");
        }
    }
}

