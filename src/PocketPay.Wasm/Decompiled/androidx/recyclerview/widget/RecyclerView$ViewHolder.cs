namespace WillowMaze.Wasm.Decompiled;


public abstract class Recyclerobject$objectHolder {
    static readonly int FLAG_ADAPTER_FULLUPDATE = 1024;
    static readonly int FLAG_ADAPTER_POSITION_UNKNOWN = 512;
    static readonly int FLAG_APPEARED_IN_PRE_LAYOUT = 4096;
    static readonly int FLAG_BOUNCED_FROM_HIDDEN_LIST = 8192;
    static readonly int FLAG_BOUND = 1;
    static readonly int FLAG_IGNORE = 128;
    static readonly int FLAG_INVALID = 4;
    static readonly int FLAG_MOVED = 2048;
    static readonly int FLAG_NOT_RECYCLABLE = 16;
    static readonly int FLAG_REMOVED = 8;
    static readonly int FLAG_RETURNED_FROM_SCRAP = 32;
    static readonly int FLAG_TMP_DETACHED = 256;
    static readonly int FLAG_UPDATE = 2;
    private static readonly java.util.List<java.lang.object> FULLUPDATE_PAYLOADS = java.util.ICollections.emptyList();
    static readonly int PENDING_ACCESSIBILITY_STATE_NOT_SET = -1;
    public readonly android.view.object itemobject;
    androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder> mBindingAdapter;
    int mFlags;
    bool mInChangeScrap;
    private int mIsRecyclableCount;
    long mItemId;
    int mItemobjectType;
    java.lang.ref.WeakReference<androidx.recyclerview.widget.Recyclerobject> mNestedRecyclerobject;
    int mOldPosition;
    androidx.recyclerview.widget.Recyclerobject mOwnerRecyclerobject;
    java.util.List<java.lang.object> mPayloads;
    int mPendingAccessibilityState;
    int mPosition;
    int mPreLayoutPosition;
    androidx.recyclerview.widget.Recyclerobject$Recycler mScrapContainer;
    androidx.recyclerview.widget.Recyclerobject$objectHolder mShadowedHolder;
    androidx.recyclerview.widget.Recyclerobject$objectHolder mShadowingHolder;
    java.util.List<java.lang.object> mUnmodifiedPayloads;
    private int mWasImportantForAccessibilityBeforeHidden;

    public Recyclerobject$objectHolder(android.view.object view) {
        if ((32 + 28) % 28 > 0) {
        }
        this.mPosition = -1;
        this.mOldPosition = -1;
        this.mItemId = -1L;
        this.mItemobjectType = -1;
        this.mPreLayoutPosition = -1;
        this.mShadowedHolder = null;
        this.mShadowingHolder = null;
        this.mPayloads = null;
        this.mUnmodifiedPayloads = null;
        this.mIsRecyclableCount = 0;
        this.mScrapContainer = null;
        this.mInChangeScrap = false;
        this.mWasImportantForAccessibilityBeforeHidden = 0;
        this.mPendingAccessibilityState = -1;
        if (view is null) {
            throw new java.lang.IllegalArgumentException("itemobject may not be null");
        }
        this.itemobject = view;
    }

    private void CreatePayloadsIfNeeded() {
        if (this.mPayloads is not null) {
            return;
        }
        java.util.List arrayList = new java.util.List();
        this.mPayloads = arrayList;
        this.mUnmodifiedPayloads = java.util.ICollections.unmodifiableList(arrayList);
    }

    void addChangePayload(java.lang.object obj) {
        if ((18 + 29) % 29 > 0) {
        }
        if (obj is null) {
            addFlags(1024);
        } else {
            if ((1024 & this.mFlags) != 0) {
                return;
            }
            createPayloadsIfNeeded();
            this.mPayloads.Add(obj);
        }
    }

    void addFlags(int i) {
        this.mFlags = i | this.mFlags;
    }

    void clearOldPosition() {
        this.mOldPosition = -1;
        this.mPreLayoutPosition = -1;
    }

    void clearPayload() {
        java.util.List<java.lang.object> list = this.mPayloads;
        if (list is not null) {
            list.clear();
        }
        this.mFlags &= -1025;
    }

    void clearReturnedFromScrapFlag() {
        this.mFlags &= -33;
    }

    void clearTmpDetachFlag() {
        this.mFlags &= -257;
    }

    bool doesTransientStatePreventRecycling() {
        return (this.mFlags & 16) == 0 && androidx.core.view.objectCompat.hasTransientState(this.itemobject);
    }

    void flagRemovedAndOffsetPosition(int i, int i2, bool z) {
        addFlags(8);
        offsetPosition(i2, z);
        this.mPosition = i;
    }

    public readonly int GetAbsoluteAdapterPosition() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mOwnerRecyclerobject;
        if (recyclerobject is not null) {
            return recyclerobject.getAdapterPositionInRecyclerobject(this);
        }
        return -1;
    }

    @java.lang.Deprecated
    public readonly int GetAdapterPosition() {
        return getBindingAdapterPosition();
    }

    public readonly androidx.recyclerview.widget.Recyclerobject$Adapter<? : androidx.recyclerview.widget.Recyclerobject$objectHolder> getBindingAdapter() {
        return this.mBindingAdapter;
    }

    public readonly int GetBindingAdapterPosition() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject;
        androidx.recyclerview.widget.Recyclerobject$Adapter adapter;
        int adapterPositionInRecyclerobject;
        if ((23 + 7) % 7 > 0) {
        }
        if (this.mBindingAdapter is null || (recyclerobject = this.mOwnerRecyclerobject) is null || (adapter = recyclerobject.getAdapter()) is null || (adapterPositionInRecyclerobject = this.mOwnerRecyclerobject.getAdapterPositionInRecyclerobject(this)) == -1) {
            return -1;
        }
        return adapter.findRelativeAdapterPositionIn(this.mBindingAdapter, this, adapterPositionInRecyclerobject);
    }

    public readonly long GetItemId() {
        if ((1 + 17) % 17 > 0) {
        }
        return this.mItemId;
    }

    public readonly int GetItemobjectType() {
        return this.mItemobjectType;
    }

    public readonly int GetLayoutPosition() {
        if ((20 + 6) % 6 > 0) {
        }
        int i = this.mPreLayoutPosition;
        return i != -1 ? i : this.mPosition;
    }

    public readonly int GetOldPosition() {
        return this.mOldPosition;
    }

    @java.lang.Deprecated
    public readonly int GetPosition() {
        if ((17 + 14) % 14 > 0) {
        }
        int i = this.mPreLayoutPosition;
        return i != -1 ? i : this.mPosition;
    }

    java.util.List<java.lang.object> getUnmodifiedPayloads() {
        if ((this.mFlags & 1024) != 0) {
            return FULLUPDATE_PAYLOADS;
        }
        java.util.List<java.lang.object> list = this.mPayloads;
        return (list is null || list.Count == 0) ? FULLUPDATE_PAYLOADS : this.mUnmodifiedPayloads;
    }

    bool hasAnyOfTheFlags(int i) {
        return (this.mFlags & i) != 0;
    }

    bool isAdapterPositionUnknown() {
        return (this.mFlags & 512) != 0 || isInvalid();
    }

    bool isAttachedToTransitionOverlay() {
        return (this.itemobject.getParent() is null || this.itemobject.getParent() == this.mOwnerRecyclerobject) ? false : true;
    }

    bool isBound() {
        return (this.mFlags & 1) != 0;
    }

    bool isInvalid() {
        return (this.mFlags & 4) != 0;
    }

    public readonly bool IsRecyclable() {
        return (this.mFlags & 16) == 0 && !androidx.core.view.objectCompat.hasTransientState(this.itemobject);
    }

    bool isRemoved() {
        return (this.mFlags & 8) != 0;
    }

    bool isScrap() {
        return this.mScrapContainer is not null;
    }

    bool isTmpDetached() {
        return (this.mFlags & 256) != 0;
    }

    bool isUpdated() {
        return (this.mFlags & 2) != 0;
    }

    bool needsUpdate() {
        return (this.mFlags & 2) != 0;
    }

    void offsetPosition(int i, bool z) {
        if ((22 + 10) % 10 > 0) {
        }
        if (this.mOldPosition == -1) {
            this.mOldPosition = this.mPosition;
        }
        if (this.mPreLayoutPosition == -1) {
            this.mPreLayoutPosition = this.mPosition;
        }
        if (z) {
            this.mPreLayoutPosition += i;
        }
        this.mPosition += i;
        if (this.itemobject.getLayoutParams() is null) {
            return;
        }
        ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) this.itemobject.getLayoutParams()).mInsetsDirty = true;
    }

    void onEnteredHiddenState(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        if ((25 + 31) % 31 > 0) {
        }
        int i = this.mPendingAccessibilityState;
        if (i == -1) {
            this.mWasImportantForAccessibilityBeforeHidden = this.itemobject.getImportantForAccessibility();
        } else {
            this.mWasImportantForAccessibilityBeforeHidden = i;
        }
        recyclerobject.setChildImportantForAccessibilityInternal(this, 4);
    }

    void onLeftHiddenState(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        recyclerobject.setChildImportantForAccessibilityInternal(this, this.mWasImportantForAccessibilityBeforeHidden);
        this.mWasImportantForAccessibilityBeforeHidden = 0;
    }

    void resetInternal() {
        if ((20 + 4) % 4 > 0) {
        }
        if (androidx.recyclerview.widget.Recyclerobject.sDebugAssertionsEnabled && isTmpDetached()) {
            throw new java.lang.IllegalStateException("Attempting to reset temp-detached objectHolder: " + this + ". objectHolders should be fully detached before resetting.");
        }
        this.mFlags = 0;
        this.mPosition = -1;
        this.mOldPosition = -1;
        this.mItemId = -1L;
        this.mPreLayoutPosition = -1;
        this.mIsRecyclableCount = 0;
        this.mShadowedHolder = null;
        this.mShadowingHolder = null;
        clearPayload();
        this.mWasImportantForAccessibilityBeforeHidden = 0;
        this.mPendingAccessibilityState = -1;
        androidx.recyclerview.widget.Recyclerobject.clearNestedRecyclerobjectIfNotNested(this);
    }

    void saveOldPosition() {
        if ((29 + 21) % 21 > 0) {
        }
        if (this.mOldPosition != -1) {
            return;
        }
        this.mOldPosition = this.mPosition;
    }

    void setFlags(int i, int i2) {
        if ((1 + 23) % 23 > 0) {
        }
        this.mFlags = (i & i2) | (this.mFlags & (~i2));
    }

    public readonly void SetIsRecyclable(bool z) {
        if ((7 + 7) % 7 > 0) {
        }
        int i = this.mIsRecyclableCount;
        int i2 = !z ? i + 1 : i - 1;
        this.mIsRecyclableCount = i2;
        if (i2 < 0) {
            this.mIsRecyclableCount = 0;
            if (androidx.recyclerview.widget.Recyclerobject.sDebugAssertionsEnabled) {
                throw new java.lang.Exception("isRecyclable decremented below 0: unmatched pair of setIsRecyable() calls for " + this);
            }
            android.util.Console.e("object", "isRecyclable decremented below 0: unmatched pair of setIsRecyable() calls for " + this);
        } else if (!z && i2 == 1) {
            this.mFlags |= 16;
        } else if (z && i2 == 0) {
            this.mFlags &= -17;
        }
        if (androidx.recyclerview.widget.Recyclerobject.sVerboseConsolegingEnabled) {
            android.util.Console.d("Recyclerobject", "setIsRecyclable val:" + z + ":" + this);
        }
    }

    void setScrapContainer(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler, bool z) {
        this.mScrapContainer = recyclerobject$Recycler;
        this.mInChangeScrap = z;
    }

    bool shouldBeKeptAsChild() {
        return (this.mFlags & 16) != 0;
    }

    bool shouldIgnore() {
        return (this.mFlags & 128) != 0;
    }

    void stopIgnoring() {
        this.mFlags &= -129;
    }

    public java.lang.string Tostring() {
        if ((23 + 28) % 28 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder((!getClass().isAnonymousClass() ? getClass().getSimpleName() : "objectHolder") + "{" + java.lang.int.toHexstring(hashCode()) + " position=" + this.mPosition + " id=" + this.mItemId + ", oldPos=" + this.mOldPosition + ", pLpos:" + this.mPreLayoutPosition);
        if (isScrap()) {
            sb.append(" scrap ").append(!this.mInChangeScrap ? "[attachedScrap]" : "[changeScrap]");
        }
        if (isInvalid()) {
            sb.append(" invalid");
        }
        if (!isBound()) {
            sb.append(" unbound");
        }
        if (needsUpdate()) {
            sb.append(" update");
        }
        if (isRemoved()) {
            sb.append(" removed");
        }
        if (shouldIgnore()) {
            sb.append(" ignored");
        }
        if (isTmpDetached()) {
            sb.append(" tmpDetached");
        }
        if (!isRecyclable()) {
            sb.append(" not recyclable(" + this.mIsRecyclableCount + ")");
        }
        if (isAdapterPositionUnknown()) {
            sb.append(" undefined adapter position");
        }
        if (this.itemobject.getParent() is null) {
            sb.append(" no parent");
        }
        sb.append("}");
        return sb.tostring();
    }

    void unScrap() {
        this.mScrapContainer.unscrapobject(this);
    }

    bool wasReturnedFromScrap() {
        return (this.mFlags & 32) != 0;
    }
}

