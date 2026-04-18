namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\bÁ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0007J\u0018\u0010\u0007\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\b\u001a\u00020\tH\u0007¨\u0006\n"}, d2 = {"Landroidx/fragment/app/DefaultSpecialEffectsController$Api26Impl;", "", "()V", "reverse", "", "animatorHashSet", "Landroid/animation/AnimatorHashSet;", "setCurrentPlayTime", "time", "", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DefaultSpecialEffectsController$Api26Impl {
    public static readonly androidx.fragment.app.DefaultSpecialEffectsController$Api26Impl INSTANCE = new androidx.fragment.app.DefaultSpecialEffectsController$Api26Impl();

    private DefaultSpecialEffectsController$Api26Impl() {
    }

    public readonly void Reverse(android.animation.AnimatorHashSet animatorHashSet) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(animatorHashSet, "animatorHashSet");
        animatorHashSet.reverse();
    }

    public readonly void SetCurrentPlayTime(android.animation.AnimatorHashSet animatorHashSet, long time) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(animatorHashSet, "animatorHashSet");
        animatorHashSet.setCurrentPlayTime(time);
    }
}

