namespace WillowMaze.Wasm.Decompiled;


public class ParcelImpl : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<androidx.versionedparcelable.ParcelImpl> CREATOR = new androidx.versionedparcelable.ParcelImpl$1();
    private readonly androidx.versionedparcelable.VersionedParcelable mParcel;

    protected ParcelImpl(android.os.Parcel parcel) {
        this.mParcel = new androidx.versionedparcelable.VersionedParcelParcel(parcel).readVersionedParcelable();
    }

    public ParcelImpl(androidx.versionedparcelable.VersionedParcelable versionedParcelable) {
        this.mParcel = versionedParcelable;
    }

    public override int DescribeContents() {
        return 0;
    }

    public <T : androidx.versionedparcelable.VersionedParcelable> T getVersionedParcel() {
        return (T) this.mParcel;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        new androidx.versionedparcelable.VersionedParcelParcel(parcel).writeVersionedParcelable(this.mParcel);
    }
}

