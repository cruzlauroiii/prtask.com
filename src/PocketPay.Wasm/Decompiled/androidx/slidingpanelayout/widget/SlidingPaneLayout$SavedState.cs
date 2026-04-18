namespace WillowMaze.Wasm.Decompiled;


class SlidingPaneLayout$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<androidx.slidingpanelayout.widget.SlidingPaneLayout$SavedState> CREATOR = new androidx.slidingpanelayout.widget.SlidingPaneLayout$SavedState$1();
    bool isOpen;

    SlidingPaneLayout$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        this.isOpen = parcel.readInt() != 0;
    }

    SlidingPaneLayout$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
        parcel.writeInt(this.isOpen ? 1 : 0);
    }
}

