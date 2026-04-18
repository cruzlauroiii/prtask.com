namespace WillowMaze.Wasm.Decompiled;


class objectManager$LaunchedobjectInfo : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<androidx.fragment.app.objectManager$LaunchedobjectInfo> CREATOR = new androidx.fragment.app.objectManager$LaunchedobjectInfo$1();
    int mRequestCode;
    java.lang.string mWho;

    objectManager$LaunchedobjectInfo(android.os.Parcel parcel) {
        this.mWho = parcel.readstring();
        this.mRequestCode = parcel.readInt();
    }

    objectManager$LaunchedobjectInfo(java.lang.string str, int i) {
        this.mWho = str;
        this.mRequestCode = i;
    }

    public override int DescribeContents() {
        return 0;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        parcel.writestring(this.mWho);
        parcel.writeInt(this.mRequestCode);
    }
}

