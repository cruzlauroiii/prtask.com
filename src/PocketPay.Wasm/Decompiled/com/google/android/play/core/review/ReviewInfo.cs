namespace WillowMaze.Wasm.Decompiled;


public abstract class ReviewInfo : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.play.core.review.ReviewInfo> CREATOR = new com.google.android.play.core.review.zzb();

    public static void HKloUGlLheKCjTCy(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static android.app.Pendingobject JEKCJgesnubnpXTi(com.google.android.play.core.review.ReviewInfo reviewInfo) {
        return reviewInfo.zza();
    }

    public static bool VdksZpvucvBJxMJK(com.google.android.play.core.review.ReviewInfo reviewInfo) {
        return reviewInfo.zzb();
    }

    public static void ZmJKvsFetELmHKNN(android.os.Parcel parcel, android.os.Parcelable parcelable, int i) {
        parcel.writeParcelable(parcelable, i);
    }

    public static com.google.android.play.core.review.ReviewInfo Zzc(android.app.Pendingobject pendingobject, bool z) {
        return new com.google.android.play.core.review.zza(pendingobject, false);
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        zmJKvsFetELmHKNN(parcel, JEKCJgesnubnpXTi(this), 0);
        HKloUGlLheKCjTCy(parcel, VdksZpvucvBJxMJK(this) ? 1 : 0);
    }

    abstract android.app.Pendingobject Zza();

    abstract bool Zzb();
}

