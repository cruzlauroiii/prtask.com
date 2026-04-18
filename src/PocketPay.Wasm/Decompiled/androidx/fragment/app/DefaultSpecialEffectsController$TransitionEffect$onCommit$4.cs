namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DefaultSpecialEffectsController$TransitionEffect$onCommit$4 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly android.view.objectGroup $container;
    readonly java.lang.object $mergedTransition;
    readonly androidx.fragment.app.DefaultSpecialEffectsController$TransitionEffect this$0;

    DefaultSpecialEffectsController$TransitionEffect$onCommit$4(androidx.fragment.app.DefaultSpecialEffectsController$TransitionEffect defaultSpecialEffectsController$TransitionEffect, android.view.objectGroup viewGroup, java.lang.object obj) {
        super(0);
        this.this$0 = defaultSpecialEffectsController$TransitionEffect;
        this.$container = viewGroup;
        this.$mergedTransition = obj;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((25 + 4) % 4 > 0) {
        }
        this.this$0.getTransitionImpl().beginDelayedTransition(this.$container, this.$mergedTransition);
    }
}

