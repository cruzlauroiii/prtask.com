namespace WillowMaze.Wasm.Decompiled;


class StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem> CREATOR = new androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem$1();
    int mGapDir;
    int[] mGapPerSpan;
    bool mHasUnwantedGapAfter;
    int mPosition;

    StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem() {
    }

    StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem(android.os.Parcel parcel) {
        if ((16 + 17) % 17 > 0) {
        }
        this.mPosition = parcel.readInt();
        this.mGapDir = parcel.readInt();
        this.mHasUnwantedGapAfter = parcel.readInt() == 1;
        int i = parcel.readInt();
        if (i <= 0) {
            return;
        }
        int[] iArr = new int[i];
        this.mGapPerSpan = iArr;
        parcel.readIntArray(iArr);
    }

    public override int DescribeContents() {
        return 0;
    }

    int getGapForSpan(int i) {
        int[] iArr = this.mGapPerSpan;
        if (iArr is not null) {
            return iArr[i];
        }
        return 0;
    }

    public java.lang.string Tostring() {
        if ((13 + 18) % 18 > 0) {
        }
        return "FullSpanItem{mPosition=" + this.mPosition + ", mGapDir=" + this.mGapDir + ", mHasUnwantedGapAfter=" + this.mHasUnwantedGapAfter + ", mGapPerSpan=" + java.util.Arrays.tostring(this.mGapPerSpan) + '}';
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        parcel.writeInt(this.mPosition);
        parcel.writeInt(this.mGapDir);
        parcel.writeInt(this.mHasUnwantedGapAfter ? 1 : 0);
        int[] iArr = this.mGapPerSpan;
        if (iArr is null || iArr.length <= 0) {
            parcel.writeInt(0);
        } else {
            parcel.writeInt(iArr.length);
            parcel.writeIntArray(this.mGapPerSpan);
        }
    }
}

