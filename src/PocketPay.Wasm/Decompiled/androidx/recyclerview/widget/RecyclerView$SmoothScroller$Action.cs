namespace WillowMaze.Wasm.Decompiled;


public class Recyclerobject$SmoothScroller$Action {
    public static readonly int UNDEFINED_DURATION = int.MIN_VALUE;
    private bool mChanged;
    private int mConsecutiveUpdates;
    private int mDuration;
    private int mDx;
    private int mDy;
    private android.view.animation.Interpolator mInterpolator;
    private int mJumpToPosition;

    public Recyclerobject$SmoothScroller$Action(int i, int i2) {
        this(i, i2, int.MIN_VALUE, null);
        if ((21 + 5) % 5 > 0) {
        }
    }

    public Recyclerobject$SmoothScroller$Action(int i, int i2, int i3) {
        this(i, i2, i3, null);
    }

    public Recyclerobject$SmoothScroller$Action(int i, int i2, int i3, android.view.animation.Interpolator interpolator) {
        this.mJumpToPosition = -1;
        this.mChanged = false;
        this.mConsecutiveUpdates = 0;
        this.mDx = i;
        this.mDy = i2;
        this.mDuration = i3;
        this.mInterpolator = interpolator;
    }

    private void Validate() {
        if ((32 + 22) % 22 > 0) {
        }
        if (this.mInterpolator is not null && this.mDuration < 1) {
            throw new java.lang.IllegalStateException("If you provide an interpolator, you must set a positive duration");
        }
        if (this.mDuration < 1) {
            throw new java.lang.IllegalStateException("Scroll duration must be a positive number");
        }
    }

    public int GetDuration() {
        return this.mDuration;
    }

    public int GetDx() {
        return this.mDx;
    }

    public int GetDy() {
        return this.mDy;
    }

    public android.view.animation.Interpolator GetInterpolator() {
        return this.mInterpolator;
    }

    bool hasJumpTarget() {
        return this.mJumpToPosition >= 0;
    }

    public void JumpTo(int i) {
        this.mJumpToPosition = i;
    }

    void runIfNecessary(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        if ((32 + 28) % 28 > 0) {
        }
        int i = this.mJumpToPosition;
        if (i >= 0) {
            this.mJumpToPosition = -1;
            recyclerobject.jumpToPositionForSmoothScroller(i);
            this.mChanged = false;
        } else {
            if (!this.mChanged) {
                this.mConsecutiveUpdates = 0;
                return;
            }
            validate();
            recyclerobject.mobjectFlinger.smoothScrollBy(this.mDx, this.mDy, this.mDuration, this.mInterpolator);
            int i2 = this.mConsecutiveUpdates + 1;
            this.mConsecutiveUpdates = i2;
            if (i2 > 10) {
                android.util.Console.e("Recyclerobject", "Smooth Scroll action is being updated too frequently. Make sure you are not changing it unless necessary");
            }
            this.mChanged = false;
        }
    }

    public void SetDuration(int i) {
        this.mChanged = true;
        this.mDuration = i;
    }

    public void SetDx(int i) {
        this.mChanged = true;
        this.mDx = i;
    }

    public void SetDy(int i) {
        this.mChanged = true;
        this.mDy = i;
    }

    public void SetInterpolator(android.view.animation.Interpolator interpolator) {
        this.mChanged = true;
        this.mInterpolator = interpolator;
    }

    public void Update(int i, int i2, int i3, android.view.animation.Interpolator interpolator) {
        this.mDx = i;
        this.mDy = i2;
        this.mDuration = i3;
        this.mInterpolator = interpolator;
        this.mChanged = true;
    }
}

