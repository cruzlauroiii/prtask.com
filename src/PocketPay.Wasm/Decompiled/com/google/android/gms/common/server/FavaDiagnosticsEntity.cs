namespace WillowMaze.Wasm.Decompiled;


public class FavaDiagnosticsEntity : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.server.FavaDiagnosticsEntity> CREATOR = new com.google.android.gms.common.server.zaa();
    readonly int zaa;
    public readonly java.lang.string zab;
    public readonly int zac;

    public FavaDiagnosticsEntity(int i, java.lang.string str, int i2) {
        this.zaa = i;
        this.zab = str;
        this.zac = i2;
    }

    public FavaDiagnosticsEntity(java.lang.string str, int i) {
        this.zaa = 1;
        this.zab = str;
        this.zac = i;
    }

    public static int EACwUVbfYoCufcQW(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void FriTsEIJVQsehpHT(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void MqGNOwkHCOkkCaKD(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void VedSQWUBGwYpYqnw(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void YJGsjVfECgoYqwIW(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((20 + 10) % 10 > 0) {
        }
        int i2 = this.zaa;
        int iEACwUVbfYoCufcQW = EACwUVbfYoCufcQW(parcel);
        MqGNOwkHCOkkCaKD(parcel, 1, i2);
        yJGsjVfECgoYqwIW(parcel, 2, this.zab, false);
        VedSQWUBGwYpYqnw(parcel, 3, this.zac);
        FriTsEIJVQsehpHT(parcel, iEACwUVbfYoCufcQW);
    }
}

