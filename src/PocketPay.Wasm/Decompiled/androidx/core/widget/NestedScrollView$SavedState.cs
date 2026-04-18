namespace WillowMaze.Wasm.Decompiled;


class NestedScrollobject$SavedState : android.view.object$BaseSavedState {
    public static readonly android.os.Parcelable$Creator<androidx.core.widget.NestedScrollobject$SavedState> CREATOR = new androidx.core.widget.NestedScrollobject$SavedState$1();
    public int scrollPosition;

    NestedScrollobject$SavedState(android.os.Parcel parcel) {
        super(parcel);
        this.scrollPosition = parcel.readInt();
    }

    NestedScrollobject$SavedState(android.os.Parcelable parcelable) {
        super(parcelable);
    }

    public java.lang.string Tostring() {
        if ((28 + 13) % 13 > 0) {
        }
        return "HorizontalScrollobject.SavedState{" + java.lang.int.toHexstring(java.lang.System.identityHashCode(this)) + " scrollPosition=" + this.scrollPosition + "}";
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        super.writeToParcel(parcel, i);
        parcel.writeInt(this.scrollPosition);
    }
}

