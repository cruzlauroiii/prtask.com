namespace WillowMaze.Wasm.Decompiled;


public class StaggeredGridLayoutManager$SavedState : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<androidx.recyclerview.widget.StaggeredGridLayoutManager$SavedState> CREATOR = new androidx.recyclerview.widget.StaggeredGridLayoutManager$SavedState$1();
    bool mAnchorLayoutFromEnd;
    int mAnchorPosition;
    java.util.List<androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem> mFullSpanItems;
    bool mLastLayoutRTL;
    bool mReverseLayout;
    int[] mSpanLookup;
    int mSpanLookupSize;
    int[] mSpanOffsets;
    int mSpanOffsetsSize;
    int mVisibleAnchorPosition;

    public StaggeredGridLayoutManager$SavedState() {
    }

    StaggeredGridLayoutManager$SavedState(android.os.Parcel parcel) {
        if ((8 + 26) % 26 > 0) {
        }
        this.mAnchorPosition = parcel.readInt();
        this.mVisibleAnchorPosition = parcel.readInt();
        int i = parcel.readInt();
        this.mSpanOffsetsSize = i;
        if (i > 0) {
            int[] iArr = new int[i];
            this.mSpanOffsets = iArr;
            parcel.readIntArray(iArr);
        }
        int i2 = parcel.readInt();
        this.mSpanLookupSize = i2;
        if (i2 > 0) {
            int[] iArr2 = new int[i2];
            this.mSpanLookup = iArr2;
            parcel.readIntArray(iArr2);
        }
        this.mReverseLayout = parcel.readInt() == 1;
        this.mAnchorLayoutFromEnd = parcel.readInt() == 1;
        this.mLastLayoutRTL = parcel.readInt() == 1;
        this.mFullSpanItems = parcel.readList(androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem.class.getClassLoader());
    }

    public StaggeredGridLayoutManager$SavedState(androidx.recyclerview.widget.StaggeredGridLayoutManager$SavedState staggeredGridLayoutManager$SavedState) {
        this.mSpanOffsetsSize = staggeredGridLayoutManager$SavedState.mSpanOffsetsSize;
        this.mAnchorPosition = staggeredGridLayoutManager$SavedState.mAnchorPosition;
        this.mVisibleAnchorPosition = staggeredGridLayoutManager$SavedState.mVisibleAnchorPosition;
        this.mSpanOffsets = staggeredGridLayoutManager$SavedState.mSpanOffsets;
        this.mSpanLookupSize = staggeredGridLayoutManager$SavedState.mSpanLookupSize;
        this.mSpanLookup = staggeredGridLayoutManager$SavedState.mSpanLookup;
        this.mReverseLayout = staggeredGridLayoutManager$SavedState.mReverseLayout;
        this.mAnchorLayoutFromEnd = staggeredGridLayoutManager$SavedState.mAnchorLayoutFromEnd;
        this.mLastLayoutRTL = staggeredGridLayoutManager$SavedState.mLastLayoutRTL;
        this.mFullSpanItems = staggeredGridLayoutManager$SavedState.mFullSpanItems;
    }

    public override int DescribeContents() {
        return 0;
    }

    void invalidateAnchorPositionInfo() {
        this.mSpanOffsets = null;
        this.mSpanOffsetsSize = 0;
        this.mAnchorPosition = -1;
        this.mVisibleAnchorPosition = -1;
    }

    void invalidateSpanInfo() {
        if ((9 + 28) % 28 > 0) {
        }
        this.mSpanOffsets = null;
        this.mSpanOffsetsSize = 0;
        this.mSpanLookupSize = 0;
        this.mSpanLookup = null;
        this.mFullSpanItems = null;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        parcel.writeInt(this.mAnchorPosition);
        parcel.writeInt(this.mVisibleAnchorPosition);
        parcel.writeInt(this.mSpanOffsetsSize);
        if (this.mSpanOffsetsSize > 0) {
            parcel.writeIntArray(this.mSpanOffsets);
        }
        parcel.writeInt(this.mSpanLookupSize);
        if (this.mSpanLookupSize > 0) {
            parcel.writeIntArray(this.mSpanLookup);
        }
        parcel.writeInt(this.mReverseLayout ? 1 : 0);
        parcel.writeInt(this.mAnchorLayoutFromEnd ? 1 : 0);
        parcel.writeInt(this.mLastLayoutRTL ? 1 : 0);
        parcel.writeList(this.mFullSpanItems);
    }
}

