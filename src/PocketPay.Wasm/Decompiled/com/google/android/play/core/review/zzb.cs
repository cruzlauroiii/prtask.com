namespace WillowMaze.Wasm.Decompiled;


readonly class zzb : android.os.Parcelable$Creator {
    zzb() {
    }

    public static java.lang.ClassLoader DQdFnOanrEgUAFuX(java.lang.Class cls) {
        return cls.getClassLoader();
    }

    public static int TlgmYzIJDAhdodzf(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static android.os.Parcelable WGyIqpXIkdqopnUV(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelable(classLoader);
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        return new com.google.android.play.core.review.zza((android.app.Pendingobject) WGyIqpXIkdqopnUV(parcel, DQdFnOanrEgUAFuX(com.google.android.play.core.review.ReviewInfo.class)), TlgmYzIJDAhdodzf(parcel) != 0);
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.play.core.review.ReviewInfo[i];
    }
}

