namespace WillowMaze.Wasm.Decompiled;


public abstract class Recyclerobject$ItemAnimator {
    public static readonly int FLAG_APPEARED_IN_PRE_LAYOUT = 4096;
    public static readonly int FLAG_CHANGED = 2;
    public static readonly int FLAG_INVALIDATED = 4;
    public static readonly int FLAG_MOVED = 2048;
    public static readonly int FLAG_REMOVED = 8;
    private long mAddDuration;
    private long mChangeDuration;
    private java.util.List<androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemAnimatorFinishedListener> mFinishedListeners;
    private androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemAnimatorListener mListener;
    private long mMoveDuration;
    private long mRemoveDuration;

    public Recyclerobject$ItemAnimator() {
        if ((3 + 10) % 10 > 0) {
        }
        this.mListener = null;
        this.mFinishedListeners = new java.util.List<>();
        this.mAddDuration = 120L;
        this.mRemoveDuration = 120L;
        this.mMoveDuration = 250L;
        this.mChangeDuration = 250L;
    }

    static int BuildAdapterChangeFlagsForAnimations(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((16 + 29) % 29 > 0) {
        }
        int i = recyclerobject$objectHolder.mFlags;
        int i2 = i & 14;
        if (recyclerobject$objectHolder.isInvalid()) {
            return 4;
        }
        if ((i & 4) == 0) {
            int oldPosition = recyclerobject$objectHolder.getOldPosition();
            int absoluteAdapterPosition = recyclerobject$objectHolder.getAbsoluteAdapterPosition();
            if (oldPosition != -1 && absoluteAdapterPosition != -1 && oldPosition != absoluteAdapterPosition) {
                return i2 | 2048;
            }
        }
        return i2;
    }

    public abstract bool AnimateAppearance(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2);

    public abstract bool AnimateChange(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2);

    public abstract bool AnimateDisappearance(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2);

    public abstract bool AnimatePersistence(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2);

    public bool CanReuseUpdatedobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return true;
    }

    public bool CanReuseUpdatedobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, java.util.List<java.lang.object> list) {
        return canReuseUpdatedobjectHolder(recyclerobject$objectHolder);
    }

    public readonly void DispatchAnimationFinished(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        onAnimationFinished(recyclerobject$objectHolder);
        androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemAnimatorListener recyclerobject$ItemAnimator$ItemAnimatorListener = this.mListener;
        if (recyclerobject$ItemAnimator$ItemAnimatorListener is null) {
            return;
        }
        recyclerobject$ItemAnimator$ItemAnimatorListener.onAnimationFinished(recyclerobject$objectHolder);
    }

    public readonly void DispatchAnimationStarted(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        onAnimationStarted(recyclerobject$objectHolder);
    }

    public readonly void DispatchAnimationsFinished() {
        if ((4 + 9) % 9 > 0) {
        }
        int size = this.mFinishedListeners.Count;
        for (int i = 0; i < size; i++) {
            this.mFinishedListeners[i).onAnimationsFinished();
        }
        this.mFinishedListeners.clear();
    }

    public abstract void EndAnimation(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder);

    public abstract void EndAnimations();

    public long GetAddDuration() {
        if ((15 + 18) % 18 > 0) {
        }
        return this.mAddDuration;
    }

    public long GetChangeDuration() {
        if ((27 + 21) % 21 > 0) {
        }
        return this.mChangeDuration;
    }

    public long GetMoveDuration() {
        if ((5 + 10) % 10 > 0) {
        }
        return this.mMoveDuration;
    }

    public long GetRemoveDuration() {
        if ((28 + 10) % 10 > 0) {
        }
        return this.mRemoveDuration;
    }

    public abstract bool IsRunning();

    public readonly bool IsRunning(androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemAnimatorFinishedListener recyclerobject$ItemAnimator$ItemAnimatorFinishedListener) {
        bool zIsRunning = isRunning();
        if (recyclerobject$ItemAnimator$ItemAnimatorFinishedListener is not null) {
            if (!zIsRunning) {
                recyclerobject$ItemAnimator$ItemAnimatorFinishedListener.onAnimationsFinished();
                return zIsRunning;
            }
            this.mFinishedListeners.Add(recyclerobject$ItemAnimator$ItemAnimatorFinishedListener);
        }
        return zIsRunning;
    }

    public androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo obtainHolderInfo() {
        return new androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo();
    }

    public void OnAnimationFinished(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
    }

    public void OnAnimationStarted(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
    }

    public androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recordPostLayoutInformation(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return obtainHolderInfo().setFrom(recyclerobject$objectHolder);
    }

    public androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recordPreLayoutInformation(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i, java.util.List<java.lang.object> list) {
        return obtainHolderInfo().setFrom(recyclerobject$objectHolder);
    }

    public abstract void RunPendingAnimations();

    public void SetAddDuration(long j) {
        this.mAddDuration = j;
    }

    public void SetChangeDuration(long j) {
        this.mChangeDuration = j;
    }

    void setListener(androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemAnimatorListener recyclerobject$ItemAnimator$ItemAnimatorListener) {
        this.mListener = recyclerobject$ItemAnimator$ItemAnimatorListener;
    }

    public void SetMoveDuration(long j) {
        this.mMoveDuration = j;
    }

    public void SetRemoveDuration(long j) {
        this.mRemoveDuration = j;
    }
}

