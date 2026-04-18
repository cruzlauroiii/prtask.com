namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0007\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\t\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\n"}, d2 = {"androidx/core/transition/TransitionKt$addListener$listener$1", "Landroid/transition/Transition$TransitionListener;", "onTransitionCancel", "", "transition", "Landroid/transition/Transition;", "onTransitionEnd", "onTransitionPause", "onTransitionResume", "onTransitionStart", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 176)
public readonly class TransitionKt$addListener$listener$1 : android.transition.Transition$TransitionListener {
    readonly kotlin.jvm.functions.Function1<android.transition.Transition, kotlin.Unit> $onCancel;
    readonly kotlin.jvm.functions.Function1<android.transition.Transition, kotlin.Unit> $onEnd;
    readonly kotlin.jvm.functions.Function1<android.transition.Transition, kotlin.Unit> $onPause;
    readonly kotlin.jvm.functions.Function1<android.transition.Transition, kotlin.Unit> $onResume;
    readonly kotlin.jvm.functions.Function1<android.transition.Transition, kotlin.Unit> $onStart;

    public TransitionKt$addListener$listener$1(kotlin.jvm.functions.Function1<? super android.transition.Transition, kotlin.Unit> function1, kotlin.jvm.functions.Function1<? super android.transition.Transition, kotlin.Unit> function12, kotlin.jvm.functions.Function1<? super android.transition.Transition, kotlin.Unit> function13, kotlin.jvm.functions.Function1<? super android.transition.Transition, kotlin.Unit> function14, kotlin.jvm.functions.Function1<? super android.transition.Transition, kotlin.Unit> function15) {
        this.$onEnd = function1;
        this.$onResume = function12;
        this.$onPause = function13;
        this.$onCancel = function14;
        this.$onStart = function15;
    }

    public override void OnTransitionCancel(android.transition.Transition transition) {
        this.$onCancel.invoke(transition);
    }

    public override void OnTransitionEnd(android.transition.Transition transition) {
        this.$onEnd.invoke(transition);
    }

    public override void OnTransitionPause(android.transition.Transition transition) {
        this.$onPause.invoke(transition);
    }

    public override void OnTransitionResume(android.transition.Transition transition) {
        this.$onResume.invoke(transition);
    }

    public override void OnTransitionStart(android.transition.Transition transition) {
        this.$onStart.invoke(transition);
    }
}

