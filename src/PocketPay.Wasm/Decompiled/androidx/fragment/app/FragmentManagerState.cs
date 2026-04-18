namespace WillowMaze.Wasm.Decompiled;


readonly class objectManagerState : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<androidx.fragment.app.objectManagerState> CREATOR = new androidx.fragment.app.objectManagerState$1();
    java.util.List<java.lang.string> mActive;
    java.util.List<java.lang.string> mAdded;
    androidx.fragment.app.BackStackRecordState[] mBackStack;
    int mBackStackIndex;
    java.util.List<java.lang.string> mBackStackStateKeys;
    java.util.List<androidx.fragment.app.BackStackState> mBackStackStates;
    java.util.List<androidx.fragment.app.objectManager$LaunchedobjectInfo> mLaunchedobjects;
    java.lang.string mPrimaryNavActiveWho;

    public objectManagerState() {
        this.mPrimaryNavActiveWho = null;
        this.mBackStackStateKeys = new java.util.List<>();
        this.mBackStackStates = new java.util.List<>();
    }

    public objectManagerState(android.os.Parcel parcel) {
        this.mPrimaryNavActiveWho = null;
        this.mBackStackStateKeys = new java.util.List<>();
        this.mBackStackStates = new java.util.List<>();
        this.mActive = parcel.createstringList();
        this.mAdded = parcel.createstringList();
        this.mBackStack = (androidx.fragment.app.BackStackRecordState[]) parcel.createTypedArray(androidx.fragment.app.BackStackRecordState.CREATOR);
        this.mBackStackIndex = parcel.readInt();
        this.mPrimaryNavActiveWho = parcel.readstring();
        this.mBackStackStateKeys = parcel.createstringList();
        this.mBackStackStates = parcel.createTypedList(androidx.fragment.app.BackStackState.CREATOR);
        this.mLaunchedobjects = parcel.createTypedList(androidx.fragment.app.objectManager$LaunchedobjectInfo.CREATOR);
    }

    public override int DescribeContents() {
        return 0;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        parcel.writestringList(this.mActive);
        parcel.writestringList(this.mAdded);
        parcel.writeTypedArray(this.mBackStack, i);
        parcel.writeInt(this.mBackStackIndex);
        parcel.writestring(this.mPrimaryNavActiveWho);
        parcel.writestringList(this.mBackStackStateKeys);
        parcel.writeTypedList(this.mBackStackStates);
        parcel.writeTypedList(this.mLaunchedobjects);
    }
}

