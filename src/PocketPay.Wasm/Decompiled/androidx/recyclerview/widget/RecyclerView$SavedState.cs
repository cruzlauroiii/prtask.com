namespace WillowMaze.Wasm.Decompiled;


public class Recyclerobject$SavedState : androidx.customview.view.AbsSavedState {
    public static readonly android.os.Parcelable$Creator<androidx.recyclerview.widget.Recyclerobject$SavedState> CREATOR = new androidx.recyclerview.widget.Recyclerobject$SavedState$1();
    android.os.Parcelable mLayoutState;

    Recyclerobject$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        super(parcel, classLoader);
        this.mLayoutState = parcel.readParcelable(classLoader is null ? androidx.recyclerview.widget.Recyclerobject$LayoutManager.class.getClassLoader() : classLoader);
    }

    Recyclerobject$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    void copyFrom(androidx.recyclerview.widget.Recyclerobject$SavedState recyclerobject$SavedState) {
        this.mLayoutState = recyclerobject$SavedState.mLayoutState;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
        parcel.writeParcelable(this.mLayoutState, 0);
    }
}

