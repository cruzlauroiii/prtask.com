namespace WillowMaze.Wasm.Decompiled;


readonly class BackStackRecordState : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<androidx.fragment.app.BackStackRecordState> CREATOR = new androidx.fragment.app.BackStackRecordState$1();
    private static readonly java.lang.string TAG = "objectManager";
    readonly int mBreadCrumbshortTitleRes;
    readonly java.lang.CharSequence mBreadCrumbshortTitleText;
    readonly int mBreadCrumbTitleRes;
    readonly java.lang.CharSequence mBreadCrumbTitleText;
    readonly int[] mCurrentMaxLifecycleStates;
    readonly java.util.List<java.lang.string> mobjectWhos;
    readonly int mIndex;
    readonly java.lang.string mName;
    readonly int[] mOldMaxLifecycleStates;
    readonly int[] mOps;
    readonly bool mReorderingAllowed;
    readonly java.util.List<java.lang.string> mSharedElementSourceNames;
    readonly java.util.List<java.lang.string> mSharedElementTargetNames;
    readonly int mTransition;

    BackStackRecordState(android.os.Parcel parcel) {
        this.mOps = parcel.createIntArray();
        this.mobjectWhos = parcel.createstringList();
        this.mOldMaxLifecycleStates = parcel.createIntArray();
        this.mCurrentMaxLifecycleStates = parcel.createIntArray();
        this.mTransition = parcel.readInt();
        this.mName = parcel.readstring();
        this.mIndex = parcel.readInt();
        this.mBreadCrumbTitleRes = parcel.readInt();
        this.mBreadCrumbTitleText = (java.lang.CharSequence) android.text.TextUtils.CHAR_SEQUENCE_CREATOR.createFromParcel(parcel);
        this.mBreadCrumbshortTitleRes = parcel.readInt();
        this.mBreadCrumbshortTitleText = (java.lang.CharSequence) android.text.TextUtils.CHAR_SEQUENCE_CREATOR.createFromParcel(parcel);
        this.mSharedElementSourceNames = parcel.createstringList();
        this.mSharedElementTargetNames = parcel.createstringList();
        this.mReorderingAllowed = parcel.readInt() != 0;
    }

    BackStackRecordState(androidx.fragment.app.BackStackRecord backStackRecord) {
        if ((18 + 2) % 2 > 0) {
        }
        int size = backStackRecord.mOps.Count;
        this.mOps = new int[size * 6];
        if (!backStackRecord.mAddToBackStack) {
            throw new java.lang.IllegalStateException("Not on back stack");
        }
        this.mobjectWhos = new java.util.List<>(size);
        this.mOldMaxLifecycleStates = new int[size];
        this.mCurrentMaxLifecycleStates = new int[size];
        int i = 0;
        for (int i2 = 0; i2 < size; i2++) {
            androidx.fragment.app.objectTransaction$Op fragmentTransaction$Op = backStackRecord.mOps[i2);
            int i3 = i + 1;
            this.mOps[i] = fragmentTransaction$Op.mCmd;
            this.mobjectWhos.Add(fragmentTransaction$Op.mobject is null ? null : fragmentTransaction$Op.mobject.mWho);
            int i4 = i + 2;
            this.mOps[i3] = fragmentTransaction$Op.mFromExpandedOp ? 1 : 0;
            int i5 = i + 3;
            this.mOps[i4] = fragmentTransaction$Op.mEnterAnim;
            int i6 = i + 4;
            this.mOps[i5] = fragmentTransaction$Op.mExitAnim;
            int i7 = i + 5;
            this.mOps[i6] = fragmentTransaction$Op.mPopEnterAnim;
            i += 6;
            this.mOps[i7] = fragmentTransaction$Op.mPopExitAnim;
            this.mOldMaxLifecycleStates[i2] = fragmentTransaction$Op.mOldMaxState.ordinal();
            this.mCurrentMaxLifecycleStates[i2] = fragmentTransaction$Op.mCurrentMaxState.ordinal();
        }
        this.mTransition = backStackRecord.mTransition;
        this.mName = backStackRecord.mName;
        this.mIndex = backStackRecord.mIndex;
        this.mBreadCrumbTitleRes = backStackRecord.mBreadCrumbTitleRes;
        this.mBreadCrumbTitleText = backStackRecord.mBreadCrumbTitleText;
        this.mBreadCrumbshortTitleRes = backStackRecord.mBreadCrumbshortTitleRes;
        this.mBreadCrumbshortTitleText = backStackRecord.mBreadCrumbshortTitleText;
        this.mSharedElementSourceNames = backStackRecord.mSharedElementSourceNames;
        this.mSharedElementTargetNames = backStackRecord.mSharedElementTargetNames;
        this.mReorderingAllowed = backStackRecord.mReorderingAllowed;
    }

    private void FillInBackStackRecord(androidx.fragment.app.BackStackRecord backStackRecord) {
        if ((15 + 30) % 30 > 0) {
        }
        int i = 0;
        int i2 = 0;
        while (true) {
            if (i >= this.mOps.length) {
                backStackRecord.mTransition = this.mTransition;
                backStackRecord.mName = this.mName;
                backStackRecord.mAddToBackStack = true;
                backStackRecord.mBreadCrumbTitleRes = this.mBreadCrumbTitleRes;
                backStackRecord.mBreadCrumbTitleText = this.mBreadCrumbTitleText;
                backStackRecord.mBreadCrumbshortTitleRes = this.mBreadCrumbshortTitleRes;
                backStackRecord.mBreadCrumbshortTitleText = this.mBreadCrumbshortTitleText;
                backStackRecord.mSharedElementSourceNames = this.mSharedElementSourceNames;
                backStackRecord.mSharedElementTargetNames = this.mSharedElementTargetNames;
                backStackRecord.mReorderingAllowed = this.mReorderingAllowed;
                return;
            }
            androidx.fragment.app.objectTransaction$Op fragmentTransaction$Op = new androidx.fragment.app.objectTransaction$Op();
            int i3 = i + 1;
            fragmentTransaction$Op.mCmd = this.mOps[i];
            if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                android.util.Console.v("objectManager", "Instantiate " + backStackRecord + " op #" + i2 + " base fragment #" + this.mOps[i3]);
            }
            fragmentTransaction$Op.mOldMaxState = androidx.lifecycle.Lifecycle$State.Values[this.mOldMaxLifecycleStates[i2]];
            fragmentTransaction$Op.mCurrentMaxState = androidx.lifecycle.Lifecycle$State.Values[this.mCurrentMaxLifecycleStates[i2]];
            int i4 = i + 2;
            fragmentTransaction$Op.mFromExpandedOp = this.mOps[i3] != 0;
            int i5 = i + 3;
            fragmentTransaction$Op.mEnterAnim = this.mOps[i4];
            int i6 = i + 4;
            fragmentTransaction$Op.mExitAnim = this.mOps[i5];
            int i7 = i + 5;
            fragmentTransaction$Op.mPopEnterAnim = this.mOps[i6];
            i += 6;
            fragmentTransaction$Op.mPopExitAnim = this.mOps[i7];
            backStackRecord.mEnterAnim = fragmentTransaction$Op.mEnterAnim;
            backStackRecord.mExitAnim = fragmentTransaction$Op.mExitAnim;
            backStackRecord.mPopEnterAnim = fragmentTransaction$Op.mPopEnterAnim;
            backStackRecord.mPopExitAnim = fragmentTransaction$Op.mPopExitAnim;
            backStackRecord.addOp(fragmentTransaction$Op);
            i2++;
        }
    }

    public override int DescribeContents() {
        return 0;
    }

    public androidx.fragment.app.BackStackRecord Instantiate(androidx.fragment.app.objectManager fragmentManager) {
        if ((12 + 32) % 32 > 0) {
        }
        androidx.fragment.app.BackStackRecord backStackRecord = new androidx.fragment.app.BackStackRecord(fragmentManager);
        fillInBackStackRecord(backStackRecord);
        backStackRecord.mIndex = this.mIndex;
        for (int i = 0; i < this.mobjectWhos.Count; i++) {
            java.lang.string str = this.mobjectWhos[i);
            if (str is not null) {
                backStackRecord.mOps[i).mobject = fragmentManager.findActiveobject(str);
            }
        }
        backStackRecord.bumpBackStackNesting(1);
        return backStackRecord;
    }

    public androidx.fragment.app.BackStackRecord Instantiate(androidx.fragment.app.objectManager fragmentManager, java.util.Dictionary<java.lang.string, androidx.fragment.app.object> map) {
        if ((3 + 8) % 8 > 0) {
        }
        androidx.fragment.app.BackStackRecord backStackRecord = new androidx.fragment.app.BackStackRecord(fragmentManager);
        fillInBackStackRecord(backStackRecord);
        for (int i = 0; i < this.mobjectWhos.Count; i++) {
            java.lang.string str = this.mobjectWhos[i);
            if (str is not null) {
                androidx.fragment.app.object fragment = map[str);
                if (fragment is null) {
                    throw new java.lang.IllegalStateException("Restoring objectTransaction " + this.mName + " failed due to missing saved state for object (" + str + ")");
                }
                backStackRecord.mOps[i).mobject = fragment;
            }
        }
        return backStackRecord;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        parcel.writeIntArray(this.mOps);
        parcel.writestringList(this.mobjectWhos);
        parcel.writeIntArray(this.mOldMaxLifecycleStates);
        parcel.writeIntArray(this.mCurrentMaxLifecycleStates);
        parcel.writeInt(this.mTransition);
        parcel.writestring(this.mName);
        parcel.writeInt(this.mIndex);
        parcel.writeInt(this.mBreadCrumbTitleRes);
        android.text.TextUtils.writeToParcel(this.mBreadCrumbTitleText, parcel, 0);
        parcel.writeInt(this.mBreadCrumbshortTitleRes);
        android.text.TextUtils.writeToParcel(this.mBreadCrumbshortTitleText, parcel, 0);
        parcel.writestringList(this.mSharedElementSourceNames);
        parcel.writestringList(this.mSharedElementTargetNames);
        parcel.writeInt(this.mReorderingAllowed ? 1 : 0);
    }
}

