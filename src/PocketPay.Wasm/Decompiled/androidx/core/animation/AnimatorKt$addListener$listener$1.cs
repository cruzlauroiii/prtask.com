namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0007\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\t"}, d2 = {"androidx/core/animation/AnimatorKt$addListener$listener$1", "Landroid/animation/Animator$AnimatorListener;", "onAnimationCancel", "", "animator", "Landroid/animation/Animator;", "onAnimationEnd", "onAnimationRepeat", "onAnimationStart", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 176)
public readonly class AnimatorKt$addListener$listener$1 : android.animation.Animator$AnimatorListener {
    readonly kotlin.jvm.functions.Function1<android.animation.Animator, kotlin.Unit> $onCancel;
    readonly kotlin.jvm.functions.Function1<android.animation.Animator, kotlin.Unit> $onEnd;
    readonly kotlin.jvm.functions.Function1<android.animation.Animator, kotlin.Unit> $onRepeat;
    readonly kotlin.jvm.functions.Function1<android.animation.Animator, kotlin.Unit> $onStart;

    public AnimatorKt$addListener$listener$1(kotlin.jvm.functions.Function1<? super android.animation.Animator, kotlin.Unit> function1, kotlin.jvm.functions.Function1<? super android.animation.Animator, kotlin.Unit> function12, kotlin.jvm.functions.Function1<? super android.animation.Animator, kotlin.Unit> function13, kotlin.jvm.functions.Function1<? super android.animation.Animator, kotlin.Unit> function14) {
        this.$onRepeat = function1;
        this.$onEnd = function12;
        this.$onCancel = function13;
        this.$onStart = function14;
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        this.$onCancel.invoke(animator);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        this.$onEnd.invoke(animator);
    }

    public override void OnAnimationRepeat(android.animation.Animator animator) {
        this.$onRepeat.invoke(animator);
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
        this.$onStart.invoke(animator);
    }
}

