namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\u0007"}, d2 = {"androidx/core/animation/AnimatorKt$addPauseListener$listener$1", "Landroid/animation/Animator$AnimatorPauseListener;", "onAnimationPause", "", "animator", "Landroid/animation/Animator;", "onAnimationResume", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AnimatorKt$addPauseListener$listener$1 : android.animation.Animator$AnimatorPauseListener {
    readonly kotlin.jvm.functions.Function1<android.animation.Animator, kotlin.Unit> $onPause;
    readonly kotlin.jvm.functions.Function1<android.animation.Animator, kotlin.Unit> $onResume;

    AnimatorKt$addPauseListener$listener$1(kotlin.jvm.functions.Function1<? super android.animation.Animator, kotlin.Unit> function1, kotlin.jvm.functions.Function1<? super android.animation.Animator, kotlin.Unit> function12) {
        this.$onPause = function1;
        this.$onResume = function12;
    }

    public override void OnAnimationPause(android.animation.Animator animator) {
        this.$onPause.invoke(animator);
    }

    public override void OnAnimationResume(android.animation.Animator animator) {
        this.$onResume.invoke(animator);
    }
}

