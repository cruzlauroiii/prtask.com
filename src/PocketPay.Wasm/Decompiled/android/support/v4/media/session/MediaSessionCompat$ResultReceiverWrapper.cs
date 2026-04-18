namespace WillowMaze.Wasm.Decompiled;


public readonly class MediaSessionCompat$ResultReceiverWrapper : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<android.support.v4.media.session.MediaSessionCompat$ResultReceiverWrapper> CREATOR = new android.support.v4.media.session.MediaSessionCompat$ResultReceiverWrapper$1();
    android.os.ResultReceiver mResultReceiver;

    MediaSessionCompat$ResultReceiverWrapper(android.os.Parcel parcel) {
        this.mResultReceiver = (android.os.ResultReceiver) jkVxElBvOjosWKIk(android.os.ResultReceiver.CREATOR, parcel);
    }

    public MediaSessionCompat$ResultReceiverWrapper(android.os.ResultReceiver resultReceiver) {
        this.mResultReceiver = resultReceiver;
    }

    public static void ILnSmZuaiqAHdvuu(android.os.ResultReceiver resultReceiver, android.os.Parcel parcel, int i) {
        resultReceiver.writeToParcel(parcel, i);
    }

    public static void ILnSmZuaiqAHdvuu(android.os.ResultReceiver resultReceiver, android.os.Parcel parcel, int i, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ILnSmZuaiqAHdvuu(android.os.ResultReceiver resultReceiver, android.os.Parcel parcel, int i, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ILnSmZuaiqAHdvuu(android.os.ResultReceiver resultReceiver, android.os.Parcel parcel, int i, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JkVxElBvOjosWKIk(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel) {
        return parcelable$Creator.createFromParcel(parcel);
    }

    public static void JkVxElBvOjosWKIk(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JkVxElBvOjosWKIk(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JkVxElBvOjosWKIk(android.os.Parcelable$Creator parcelable$Creator, android.os.Parcel parcel, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public override int DescribeContents() {
        return 0;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        ILnSmZuaiqAHdvuu(this.mResultReceiver, parcel, i);
    }
}

