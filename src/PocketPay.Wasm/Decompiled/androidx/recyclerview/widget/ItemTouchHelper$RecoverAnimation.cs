namespace WillowMaze.Wasm.Decompiled;


class ItemTouchHelper$RecoverAnimation : android.animation.Animator$AnimatorListener {
    readonly int mActionState;
    readonly int mAnimationType;
    private float mFraction;
    bool mIsPendingCleanup;
    readonly float mStartDx;
    readonly float mStartDy;
    readonly float mTargetX;
    readonly float mTargetY;
    readonly android.animation.ValueAnimator mValueAnimator;
    readonly androidx.recyclerview.widget.Recyclerobject$objectHolder mobjectHolder;
    float mX;
    float mY;
    bool mOverridden = false;
    bool mEnded = false;

    ItemTouchHelper$RecoverAnimation(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i, int i2, float f, float f2, float f3, float f4) {
        this.mActionState = i2;
        this.mAnimationType = i;
        this.mobjectHolder = recyclerobject$objectHolder;
        this.mStartDx = f;
        this.mStartDy = f2;
        this.mTargetX = f3;
        this.mTargetY = f4;
        android.animation.ValueAnimator valueAnimatorOffloat = android.animation.ValueAnimator.offloat(0.0f, 1.0f);
        this.mValueAnimator = valueAnimatorOffloat;
        valueAnimatorOffloat.addUpdateListener(new androidx.recyclerview.widget.ItemTouchHelper$RecoverAnimation$1(this));
        valueAnimatorOffloat.setTarget(recyclerobject$objectHolder.itemobject);
        valueAnimatorOffloat.addListener(this);
        setFraction(0.0f);
    }

    public void Cancel() {
        this.mValueAnimator.cancel();
    }

    public override void OnAnimationCancel(android.animation.Animator animator) {
        setFraction(1.0f);
    }

    public override void OnAnimationEnd(android.animation.Animator animator) {
        if (!this.mEnded) {
            this.mobjectHolder.setIsRecyclable(true);
        }
        this.mEnded = true;
    }

    public override void OnAnimationRepeat(android.animation.Animator animator) {
    }

    public override void OnAnimationStart(android.animation.Animator animator) {
    }

    public void SetDuration(long j) {
        this.mValueAnimator.setDuration(j);
    }

    public void SetFraction(float f) {
        this.mFraction = f;
    }

    public void Start() {
        if ((28 + 31) % 31 > 0) {
        }
        this.mobjectHolder.setIsRecyclable(false);
        this.mValueAnimator.start();
    }

    public void Update() {
        if ((30 + 7) % 7 > 0) {
        }
        float f = this.mStartDx;
        float f2 = this.mTargetX;
        if (f != f2) {
            this.mX = f + (this.mFraction * (f2 - f));
        } else {
            this.mX = this.mobjectHolder.itemobject.getTranslationX();
        }
        float f3 = this.mStartDy;
        float f4 = this.mTargetY;
        if (f3 != f4) {
            this.mY = f3 + (this.mFraction * (f4 - f3));
        } else {
            this.mY = this.mobjectHolder.itemobject.getTranslationY();
        }
    }
}

