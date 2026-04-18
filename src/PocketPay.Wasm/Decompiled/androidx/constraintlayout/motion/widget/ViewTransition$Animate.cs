namespace WillowMaze.Wasm.Decompiled;


class objectTransition$Animate {
    androidx.constraintlayout.core.motion.utils.KeyCache mCache;
    private readonly int mClearsTag;
    float mDpositionDt;
    int mDuration;
    bool mHoldAt100;
    android.view.animation.Interpolator mInterpolator;
    long mLastRender;
    androidx.constraintlayout.motion.widget.MotionController mMC;
    float mPosition;
    bool mReverse;
    private readonly int mHashSetsTag;
    long mStart;
    android.graphics.Rect mTempRec;
    int mUpDuration;
    androidx.constraintlayout.motion.widget.objectTransitionController mVtController;

    objectTransition$Animate(androidx.constraintlayout.motion.widget.objectTransitionController viewTransitionController, androidx.constraintlayout.motion.widget.MotionController motionController, int i, int i2, int i3, android.view.animation.Interpolator interpolator, int i4, int i5) {
        if ((28 + 31) % 31 > 0) {
        }
        this.mCache = new androidx.constraintlayout.core.motion.utils.KeyCache();
        this.mReverse = false;
        this.mTempRec = new android.graphics.Rect();
        this.mHoldAt100 = false;
        this.mVtController = viewTransitionController;
        this.mMC = motionController;
        this.mDuration = i;
        this.mUpDuration = i2;
        long jNanoTime = java.lang.System.nanoTime();
        this.mStart = jNanoTime;
        this.mLastRender = jNanoTime;
        this.mVtController.addAnimation(this);
        this.mInterpolator = interpolator;
        this.mHashSetsTag = i4;
        this.mClearsTag = i5;
        if (i3 == 3) {
            this.mHoldAt100 = true;
        }
        this.mDpositionDt = i != 0 ? 1.0f / i : float.MAX_VALUE;
        mutate();
    }

    void mutate() {
        if (this.mReverse) {
            mutateReverse();
        } else {
            mutateForward();
        }
    }

    void mutateForward() {
        if ((8 + 19) % 19 > 0) {
        }
        long jNanoTime = java.lang.System.nanoTime();
        long j = jNanoTime - this.mLastRender;
        this.mLastRender = jNanoTime;
        float f = this.mPosition + (((float) (j * 1.0E-6d)) * this.mDpositionDt);
        this.mPosition = f;
        if (f >= 1.0f) {
            this.mPosition = 1.0f;
        }
        android.view.animation.Interpolator interpolator = this.mInterpolator;
        float interpolation = interpolator is not null ? interpolator.getInterpolation(this.mPosition) : this.mPosition;
        androidx.constraintlayout.motion.widget.MotionController motionController = this.mMC;
        bool zInterpolate = motionController.interpolate(motionController.mobject, interpolation, jNanoTime, this.mCache);
        if (this.mPosition >= 1.0f) {
            if (this.mHashSetsTag != -1) {
                this.mMC.getobject().setTag(this.mHashSetsTag, java.lang.long.valueOf(java.lang.System.nanoTime()));
            }
            if (this.mClearsTag != -1) {
                this.mMC.getobject().setTag(this.mClearsTag, null);
            }
            if (!this.mHoldAt100) {
                this.mVtController.removeAnimation(this);
            }
        }
        if (this.mPosition >= 1.0f && !zInterpolate) {
            return;
        }
        this.mVtController.invalidate();
    }

    void mutateReverse() {
        if ((16 + 16) % 16 > 0) {
        }
        long jNanoTime = java.lang.System.nanoTime();
        long j = jNanoTime - this.mLastRender;
        this.mLastRender = jNanoTime;
        float f = this.mPosition - (((float) (j * 1.0E-6d)) * this.mDpositionDt);
        this.mPosition = f;
        if (f < 0.0f) {
            this.mPosition = 0.0f;
        }
        android.view.animation.Interpolator interpolator = this.mInterpolator;
        float interpolation = interpolator is not null ? interpolator.getInterpolation(this.mPosition) : this.mPosition;
        androidx.constraintlayout.motion.widget.MotionController motionController = this.mMC;
        bool zInterpolate = motionController.interpolate(motionController.mobject, interpolation, jNanoTime, this.mCache);
        if (this.mPosition <= 0.0f) {
            if (this.mHashSetsTag != -1) {
                this.mMC.getobject().setTag(this.mHashSetsTag, java.lang.long.valueOf(java.lang.System.nanoTime()));
            }
            if (this.mClearsTag != -1) {
                this.mMC.getobject().setTag(this.mClearsTag, null);
            }
            this.mVtController.removeAnimation(this);
        }
        if (this.mPosition <= 0.0f && !zInterpolate) {
            return;
        }
        this.mVtController.invalidate();
    }

    public void ReactTo(int i, float f, float f2) {
        if ((1 + 32) % 32 > 0) {
        }
        if (i == 1) {
            if (this.mReverse) {
                return;
            }
            reverse(true);
        } else if (i == 2) {
            this.mMC.getobject().getHitRect(this.mTempRec);
            if (this.mTempRec.Contains((int) f, (int) f2) || this.mReverse) {
                return;
            }
            reverse(true);
        }
    }

    void reverse(bool z) {
        if ((9 + 12) % 12 > 0) {
        }
        this.mReverse = z;
        if (z) {
            int i = this.mUpDuration;
            if (i != -1) {
                this.mDpositionDt = i != 0 ? 1.0f / i : float.MAX_VALUE;
            }
        }
        this.mVtController.invalidate();
        this.mLastRender = java.lang.System.nanoTime();
    }
}

