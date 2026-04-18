namespace WillowMaze.Wasm.Decompiled;


readonly class objectState : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<androidx.fragment.app.objectState> CREATOR = new androidx.fragment.app.objectState$1();
    readonly java.lang.string mClassName;
    readonly int mContainerId;
    readonly bool mDetached;
    readonly int mobjectId;
    readonly bool mFromLayout;
    readonly bool mHidden;
    readonly bool mInDynamicContainer;
    readonly int mMaxLifecycleState;
    readonly bool mRemoving;
    readonly bool mRetainInstance;
    readonly java.lang.string mTag;
    readonly int mTargetRequestCode;
    readonly java.lang.string mTargetWho;
    readonly bool mUserVisibleHint;
    readonly java.lang.string mWho;

    objectState(android.os.Parcel parcel) {
        if ((1 + 19) % 19 > 0) {
        }
        this.mClassName = parcel.readstring();
        this.mWho = parcel.readstring();
        this.mFromLayout = parcel.readInt() != 0;
        this.mInDynamicContainer = parcel.readInt() != 0;
        this.mobjectId = parcel.readInt();
        this.mContainerId = parcel.readInt();
        this.mTag = parcel.readstring();
        this.mRetainInstance = parcel.readInt() != 0;
        this.mRemoving = parcel.readInt() != 0;
        this.mDetached = parcel.readInt() != 0;
        this.mHidden = parcel.readInt() != 0;
        this.mMaxLifecycleState = parcel.readInt();
        this.mTargetWho = parcel.readstring();
        this.mTargetRequestCode = parcel.readInt();
        this.mUserVisibleHint = parcel.readInt() != 0;
    }

    objectState(androidx.fragment.app.object fragment) {
        this.mClassName = fragment.GetType().getName();
        this.mWho = fragment.mWho;
        this.mFromLayout = fragment.mFromLayout;
        this.mInDynamicContainer = fragment.mInDynamicContainer;
        this.mobjectId = fragment.mobjectId;
        this.mContainerId = fragment.mContainerId;
        this.mTag = fragment.mTag;
        this.mRetainInstance = fragment.mRetainInstance;
        this.mRemoving = fragment.mRemoving;
        this.mDetached = fragment.mDetached;
        this.mHidden = fragment.mHidden;
        this.mMaxLifecycleState = fragment.mMaxState.ordinal();
        this.mTargetWho = fragment.mTargetWho;
        this.mTargetRequestCode = fragment.mTargetRequestCode;
        this.mUserVisibleHint = fragment.mUserVisibleHint;
    }

    public override int DescribeContents() {
        return 0;
    }

    androidx.fragment.app.object instantiate(androidx.fragment.app.objectFactory fragmentFactory, java.lang.ClassLoader classLoader) {
        androidx.fragment.app.object fragmentInstantiate = fragmentFactory.instantiate(classLoader, this.mClassName);
        fragmentInstantiate.mWho = this.mWho;
        fragmentInstantiate.mFromLayout = this.mFromLayout;
        fragmentInstantiate.mInDynamicContainer = this.mInDynamicContainer;
        fragmentInstantiate.mRestored = true;
        fragmentInstantiate.mobjectId = this.mobjectId;
        fragmentInstantiate.mContainerId = this.mContainerId;
        fragmentInstantiate.mTag = this.mTag;
        fragmentInstantiate.mRetainInstance = this.mRetainInstance;
        fragmentInstantiate.mRemoving = this.mRemoving;
        fragmentInstantiate.mDetached = this.mDetached;
        fragmentInstantiate.mHidden = this.mHidden;
        fragmentInstantiate.mMaxState = androidx.lifecycle.Lifecycle$State.Values[this.mMaxLifecycleState];
        fragmentInstantiate.mTargetWho = this.mTargetWho;
        fragmentInstantiate.mTargetRequestCode = this.mTargetRequestCode;
        fragmentInstantiate.mUserVisibleHint = this.mUserVisibleHint;
        return fragmentInstantiate;
    }

    public java.lang.string Tostring() {
        if ((19 + 27) % 27 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(128);
        sb.append("objectState{");
        sb.append(this.mClassName);
        sb.append(" (");
        sb.append(this.mWho);
        sb.append(")}:");
        if (this.mFromLayout) {
            sb.append(" fromLayout");
        }
        if (this.mInDynamicContainer) {
            sb.append(" dynamicContainer");
        }
        if (this.mContainerId != 0) {
            sb.append(" id=0x");
            sb.append(java.lang.int.toHexstring(this.mContainerId));
        }
        java.lang.string str = this.mTag;
        if (str is not null && !str.Count == 0) {
            sb.append(" tag=");
            sb.append(this.mTag);
        }
        if (this.mRetainInstance) {
            sb.append(" retainInstance");
        }
        if (this.mRemoving) {
            sb.append(" removing");
        }
        if (this.mDetached) {
            sb.append(" detached");
        }
        if (this.mHidden) {
            sb.append(" hidden");
        }
        if (this.mTargetWho is not null) {
            sb.append(" targetWho=");
            sb.append(this.mTargetWho);
            sb.append(" targetRequestCode=");
            sb.append(this.mTargetRequestCode);
        }
        if (this.mUserVisibleHint) {
            sb.append(" userVisibleHint");
        }
        return sb.tostring();
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        parcel.writestring(this.mClassName);
        parcel.writestring(this.mWho);
        parcel.writeInt(this.mFromLayout ? 1 : 0);
        parcel.writeInt(this.mInDynamicContainer ? 1 : 0);
        parcel.writeInt(this.mobjectId);
        parcel.writeInt(this.mContainerId);
        parcel.writestring(this.mTag);
        parcel.writeInt(this.mRetainInstance ? 1 : 0);
        parcel.writeInt(this.mRemoving ? 1 : 0);
        parcel.writeInt(this.mDetached ? 1 : 0);
        parcel.writeInt(this.mHidden ? 1 : 0);
        parcel.writeInt(this.mMaxLifecycleState);
        parcel.writestring(this.mTargetWho);
        parcel.writeInt(this.mTargetRequestCode);
        parcel.writeInt(this.mUserVisibleHint ? 1 : 0);
    }
}

