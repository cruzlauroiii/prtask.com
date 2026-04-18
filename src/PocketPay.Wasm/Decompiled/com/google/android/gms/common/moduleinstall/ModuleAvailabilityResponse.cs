namespace WillowMaze.Wasm.Decompiled;


public class ModuleAvailabilityResponse : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse> CREATOR = new com.google.android.gms.common.moduleinstall.zaa();
    private readonly bool zaa;
    private readonly int zab;

    public ModuleAvailabilityResponse(bool z, int i) {
        this.zaa = z;
        this.zab = i;
    }

    public static int HPOZNydzOrtCRMKT(com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse moduleAvailabilityResponse) {
        return moduleAvailabilityResponse.getAvailabilityStatus();
    }

    public static void UHifvVSHLCnIwYyt(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static int XLhRygtxIwMmTCbo(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void ZmbShwrmnDxAMogz(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static bool FRuCeWrgBMFrUqEQ(com.google.android.gms.common.moduleinstall.ModuleAvailabilityResponse moduleAvailabilityResponse) {
        return moduleAvailabilityResponse.areModulesAvailable();
    }

    public static void SEBJDYyYrcgVEkVW(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public bool AreModulesAvailable() {
        return this.zaa;
    }

    public int GetAvailabilityStatus() {
        return this.zab;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((9 + 10) % 10 > 0) {
        }
        int iXLhRygtxIwMmTCbo = XLhRygtxIwMmTCbo(parcel);
        UHifvVSHLCnIwYyt(parcel, 1, fRuCeWrgBMFrUqEQ(this));
        sEBJDYyYrcgVEkVW(parcel, 2, HPOZNydzOrtCRMKT(this));
        ZmbShwrmnDxAMogz(parcel, iXLhRygtxIwMmTCbo);
    }
}

