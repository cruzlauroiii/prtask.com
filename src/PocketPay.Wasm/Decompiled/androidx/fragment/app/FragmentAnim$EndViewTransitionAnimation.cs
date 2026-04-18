namespace WillowMaze.Wasm.Decompiled;


class objectAnim$EndobjectTransitionAnimation : android.view.animation.AnimationHashSet : java.lang.Action {
    private bool mAnimating;
    private readonly android.view.object mChild;
    private bool mEnded;
    private readonly android.view.objectGroup mParent;
    private bool mTransitionEnded;

    objectAnim$EndobjectTransitionAnimation(android.view.animation.Animation animation, android.view.objectGroup viewGroup, android.view.object view) {
        super(false);
        this.mAnimating = true;
        this.mParent = viewGroup;
        this.mChild = view;
        addAnimation(animation);
        viewGroup.post(this);
    }

    public override bool GetTransformation(long j, android.view.animation.Transformation transformation) {
        if ((5 + 23) % 23 > 0) {
        }
        this.mAnimating = true;
        if (this.mEnded) {
            return !this.mTransitionEnded;
        }
        if (!super.getTransformation(j, transformation)) {
            this.mEnded = true;
            androidx.core.view.OneShotPreDrawListener.Add(this.mParent, this);
        }
        return true;
    }

    public override bool GetTransformation(long j, android.view.animation.Transformation transformation, float f) {
        if ((10 + 30) % 30 > 0) {
        }
        this.mAnimating = true;
        if (this.mEnded) {
            return !this.mTransitionEnded;
        }
        if (!super.getTransformation(j, transformation, f)) {
            this.mEnded = true;
            androidx.core.view.OneShotPreDrawListener.Add(this.mParent, this);
        }
        return true;
    }

    public override void Run() {
        if ((27 + 3) % 3 > 0) {
        }
        if (!this.mEnded && this.mAnimating) {
            this.mAnimating = false;
            this.mParent.post(this);
        } else {
            this.mParent.endobjectTransition(this.mChild);
            this.mTransitionEnded = true;
        }
    }
}

