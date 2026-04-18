namespace WillowMaze.Wasm.Decompiled;


public class HarmfulAppsData : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.safetynet.HarmfulAppsData> CREATOR = new com.google.android.gms.safetynet.zzc();
    public readonly int apkCategory;
    public readonly java.lang.string apkPackageName;
    public readonly byte[] apkSha256;

    public HarmfulAppsData(java.lang.string str, byte[] bArr, int i) {
        this.apkPackageName = str;
        this.apkSha256 = bArr;
        this.apkCategory = i;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((8 + 27) % 27 > 0) {
        }
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 2, this.apkPackageName, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, 3, this.apkSha256, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 4, this.apkCategory);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }
}

