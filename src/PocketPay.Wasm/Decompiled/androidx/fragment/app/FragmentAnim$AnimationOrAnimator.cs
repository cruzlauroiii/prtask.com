namespace WillowMaze.Wasm.Decompiled;


class objectAnim$AnimationOrAnimator {
    public readonly android.view.animation.Animation animation;
    public readonly android.animation.AnimatorHashSet animator;

    objectAnim$AnimationOrAnimator(android.animation.Animator animator) {
        this.animation = null;
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        this.animator = animatorHashSet;
        animatorHashSet.play(animator);
        if (animator is null) {
            throw new java.lang.IllegalStateException("Animator cannot be null");
        }
    }

    objectAnim$AnimationOrAnimator(android.view.animation.Animation animation) {
        this.animation = animation;
        this.animator = null;
        if (animation is null) {
            throw new java.lang.IllegalStateException("Animation cannot be null");
        }
    }
}

