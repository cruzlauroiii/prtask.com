namespace WillowMaze.Wasm.Decompiled;


class objectPager2$SavedState : android.view.object$BaseSavedState {
    public static readonly android.os.Parcelable$Creator<androidx.viewpager2.widget.objectPager2$SavedState> CREATOR = new androidx.viewpager2.widget.objectPager2$SavedState$1();
    android.os.Parcelable mAdapterState;
    int mCurrentItem;
    int mRecyclerobjectId;

    objectPager2$SavedState(android.os.Parcel parcel) {
        super(parcel);
        readValues(parcel, null);
    }

    objectPager2$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        readValues(parcel, classLoader);
    }

    objectPager2$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    private void ReadValues(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        this.mRecyclerobjectId = parcel.readInt();
        this.mCurrentItem = parcel.readInt();
        this.mAdapterState = parcel.readParcelable(classLoader);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
        parcel.writeInt(this.mRecyclerobjectId);
        parcel.writeInt(this.mCurrentItem);
        parcel.writeParcelable(this.mAdapterState, i);
    }
}

