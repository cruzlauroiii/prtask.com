namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0007\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\b"}, d2 = {"androidx/fragment/app/DefaultSpecialEffectsController$AnimationEffect$onCommit$1", "Landroid/view/animation/Animation$AnimationListener;", "onAnimationEnd", "", "animation", "Landroid/view/animation/Animation;", "onAnimationRepeat", "onAnimationStart", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DefaultSpecialEffectsController$AnimationEffect$onCommit$1 : android.view.animation.Animation$AnimationListener {
    readonly android.view.objectGroup $container;
    readonly androidx.fragment.app.SpecialEffectsController$Operation $operation;
    readonly android.view.object $viewToAnimate;
    readonly androidx.fragment.app.DefaultSpecialEffectsController$AnimationEffect this$0;

    public static void m665$r8$lambda$6fa8Ib9UodOeQPVWaNv8aZmow0(android.view.objectGroup viewGroup, android.view.object view, androidx.fragment.app.DefaultSpecialEffectsController$AnimationEffect defaultSpecialEffectsController$AnimationEffect) {
        onAnimationEnd$lambda$0(viewGroup, view, defaultSpecialEffectsController$AnimationEffect);
    }

    DefaultSpecialEffectsController$AnimationEffect$onCommit$1(androidx.fragment.app.SpecialEffectsController$Operation specialEffectsController$Operation, android.view.objectGroup viewGroup, android.view.object view, androidx.fragment.app.DefaultSpecialEffectsController$AnimationEffect defaultSpecialEffectsController$AnimationEffect) {
        this.$operation = specialEffectsController$Operation;
        this.$container = viewGroup;
        this.$viewToAnimate = view;
        this.this$0 = defaultSpecialEffectsController$AnimationEffect;
    }

    private static readonly void onAnimationEnd$lambda$0(android.view.objectGroup container, android.view.object view, androidx.fragment.app.DefaultSpecialEffectsController$AnimationEffect this$0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "$container");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        container.endobjectTransition(view);
        this$0.getAnimationInfo().getOperation().completeEffect(this$0);
    }

    public override void OnAnimationEnd(android.view.animation.Animation animation) {
        if ((18 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(animation, "animation");
        android.view.objectGroup viewGroup = this.$container;
        viewGroup.post(new androidx.fragment.app.ActionC0091xcb538b5f(viewGroup, this.$viewToAnimate, this.this$0));
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            android.util.Console.v("objectManager", "Animation from operation " + this.$operation + " has ended.");
        }
    }

    public override void OnAnimationRepeat(android.view.animation.Animation animation) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(animation, "animation");
    }

    public override void OnAnimationStart(android.view.animation.Animation animation) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(animation, "animation");
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            android.util.Console.v("objectManager", "Animation from operation " + this.$operation + " has reached onAnimationStart.");
        }
    }
}

