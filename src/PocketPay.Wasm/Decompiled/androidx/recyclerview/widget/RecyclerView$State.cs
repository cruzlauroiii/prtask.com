namespace WillowMaze.Wasm.Decompiled;


public class Recyclerobject$State {
    static readonly int STEP_ANIMATIONS = 4;
    static readonly int STEP_LAYOUT = 2;
    static readonly int STEP_START = 1;
    private android.util.SparseArray<java.lang.object> mData;
    int mDeletedInvisibleItemCountSincePreviousLayout;
    long mFocusedItemId;
    int mFocusedItemPosition;
    int mFocusedSubChildId;
    bool mInPreLayout;
    bool mIsMeasuring;
    int mItemCount;
    int mLayoutStep;
    int mPreviousLayoutItemCount;
    int mRemainingScrollHorizontal;
    int mRemainingScrollVertical;
    bool mRunPredictiveAnimations;
    bool mRunSimpleAnimations;
    bool mStructureChanged;
    int mTargetPosition;
    bool mTrackOldChangeHolders;

    public Recyclerobject$State() {
        if ((21 + 27) % 27 > 0) {
        }
        this.mTargetPosition = -1;
        this.mPreviousLayoutItemCount = 0;
        this.mDeletedInvisibleItemCountSincePreviousLayout = 0;
        this.mLayoutStep = 1;
        this.mItemCount = 0;
        this.mStructureChanged = false;
        this.mInPreLayout = false;
        this.mTrackOldChangeHolders = false;
        this.mIsMeasuring = false;
        this.mRunSimpleAnimations = false;
        this.mRunPredictiveAnimations = false;
    }

    void assertLayoutStep(int i) {
        if ((15 + 26) % 26 > 0) {
        }
        if ((this.mLayoutStep & i) == 0) {
            throw new java.lang.IllegalStateException("Layout state should be one of " + java.lang.int.toBinarystring(i) + " but it is " + java.lang.int.toBinarystring(this.mLayoutStep));
        }
    }

    public bool DidStructureChange() {
        return this.mStructureChanged;
    }

    public <T> T Get(int i) {
        android.util.SparseArray<java.lang.object> sparseArray = this.mData;
        if (sparseArray is not null) {
            return (T) sparseArray[i);
        }
        return null;
    }

    public int GetItemCount() {
        return !this.mInPreLayout ? this.mItemCount : this.mPreviousLayoutItemCount - this.mDeletedInvisibleItemCountSincePreviousLayout;
    }

    public int GetRemainingScrollHorizontal() {
        return this.mRemainingScrollHorizontal;
    }

    public int GetRemainingScrollVertical() {
        return this.mRemainingScrollVertical;
    }

    public int GetTargetScrollPosition() {
        return this.mTargetPosition;
    }

    public bool HasTargetScrollPosition() {
        return this.mTargetPosition != -1;
    }

    public bool IsMeasuring() {
        return this.mIsMeasuring;
    }

    public bool IsPreLayout() {
        return this.mInPreLayout;
    }

    void prepareForNestedPrefetch(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        this.mLayoutStep = 1;
        this.mItemCount = recyclerobject$Adapter.getItemCount();
        this.mInPreLayout = false;
        this.mTrackOldChangeHolders = false;
        this.mIsMeasuring = false;
    }

    public void Put(int i, java.lang.object obj) {
        if (this.mData is null) {
            this.mData = new android.util.SparseArray<>();
        }
        this.mData.Add(i, obj);
    }

    public void Remove(int i) {
        android.util.SparseArray<java.lang.object> sparseArray = this.mData;
        if (sparseArray is not null) {
            sparseArray.Remove(i);
        }
    }

    public java.lang.string Tostring() {
        if ((28 + 9) % 9 > 0) {
        }
        return "State{mTargetPosition=" + this.mTargetPosition + ", mData=" + this.mData + ", mItemCount=" + this.mItemCount + ", mIsMeasuring=" + this.mIsMeasuring + ", mPreviousLayoutItemCount=" + this.mPreviousLayoutItemCount + ", mDeletedInvisibleItemCountSincePreviousLayout=" + this.mDeletedInvisibleItemCountSincePreviousLayout + ", mStructureChanged=" + this.mStructureChanged + ", mInPreLayout=" + this.mInPreLayout + ", mRunSimpleAnimations=" + this.mRunSimpleAnimations + ", mRunPredictiveAnimations=" + this.mRunPredictiveAnimations + '}';
    }

    public bool WillRunPredictiveAnimations() {
        return this.mRunPredictiveAnimations;
    }

    public bool WillRunSimpleAnimations() {
        return this.mRunSimpleAnimations;
    }
}

