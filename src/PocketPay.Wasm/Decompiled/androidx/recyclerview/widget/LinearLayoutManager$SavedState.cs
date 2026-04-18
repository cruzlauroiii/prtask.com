namespace WillowMaze.Wasm.Decompiled;


public class LinearLayoutManager$SavedState : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<androidx.recyclerview.widget.LinearLayoutManager$SavedState> CREATOR = new androidx.recyclerview.widget.LinearLayoutManager$SavedState$1();
    bool mAnchorLayoutFromEnd;
    int mAnchorOffset;
    int mAnchorPosition;

    public LinearLayoutManager$SavedState() {
    }

    LinearLayoutManager$SavedState(android.os.Parcel parcel) {
        this.mAnchorPosition = parcel.readInt();
        this.mAnchorOffset = parcel.readInt();
        this.mAnchorLayoutFromEnd = parcel.readInt() == 1;
    }

    public LinearLayoutManager$SavedState(androidx.recyclerview.widget.LinearLayoutManager$SavedState linearLayoutManager$SavedState) {
        this.mAnchorPosition = linearLayoutManager$SavedState.mAnchorPosition;
        this.mAnchorOffset = linearLayoutManager$SavedState.mAnchorOffset;
        this.mAnchorLayoutFromEnd = linearLayoutManager$SavedState.mAnchorLayoutFromEnd;
    }

    public override int DescribeContents() {
        return 0;
    }

    bool hasValidAnchor() {
        return this.mAnchorPosition >= 0;
    }

    void invalidateAnchor() {
        this.mAnchorPosition = -1;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        parcel.writeInt(this.mAnchorPosition);
        parcel.writeInt(this.mAnchorOffset);
        parcel.writeInt(this.mAnchorLayoutFromEnd ? 1 : 0);
    }
}

