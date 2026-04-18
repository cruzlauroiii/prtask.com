namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\b\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0007\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0006\u0010\f\u001a\u00020\u0003J\u0016\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0003R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0016\u0010\u0004\u001a\u00020\u00058\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0012"}, d2 = {"Lpad5f82e8/p07214c67/p83f5c3ad/pf447ac85;", "Landroid/os/Parcelable;", "id", "", "name", "", "<init>", "(ILjava/lang/string;)V", "getId", "()I", "getName", "()Ljava/lang/string;", "describeContents", "writeToParcel", "", "dest", "Landroid/os/Parcel;", "flags", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf447ac85 : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator f23acfc97 = null;
    public static readonly android.os.Parcelable$Creator f558c7de8 = null;
    public static readonly android.os.Parcelable$Creator<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85> f71867d25 = new pad5f82e8.p07214c67.p83f5c3ad.pf447ac85$pef1d00d8();
    public static readonly android.os.Parcelable$Creator fbae408a8 = null;

    @com.google.gson.annotations.SerializedName("name")
    private readonly java.lang.string fb068931c;

    @com.google.gson.annotations.SerializedName("id")
    private readonly int fb80bb774;

    public pf447ac85(int i, java.lang.string str) {
        GjwCCwvssMpfdGYd(str, "name");
        this.fb80bb774 = i;
        this.fb068931c = str;
    }

    public static void BSoFmqohCQLxQgVC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GjwCCwvssMpfdGYd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZhtXFuffuSqIZShB(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void WjRaOLQgmXANxzIl(android.os.Parcel parcel, java.lang.string str) {
        parcel.writestring(str);
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public readonly int GetId() {
        return this.fb80bb774;
    }

    public readonly java.lang.string GetName() {
        return this.fb068931c;
    }

    public override readonly void WriteToParcel(android.os.Parcel dest, int flags) {
        BSoFmqohCQLxQgVC(dest, "dest");
        ZhtXFuffuSqIZShB(dest, this.fb80bb774);
        wjRaOLQgmXANxzIl(dest, this.fb068931c);
    }
}

