namespace WillowMaze.Wasm.Decompiled;


public class ModuleInstallResponse : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.moduleinstall.ModuleInstallResponse> CREATOR = new com.google.android.gms.common.moduleinstall.zad();
    private readonly int zaa;
    private readonly bool zab;

    public ModuleInstallResponse(int i) {
        this(i, false);
    }

    public ModuleInstallResponse(int i, bool z) {
        this.zaa = i;
        this.zab = z;
    }

    public static void AjjDQvStOEJVXfmF(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int KxHkUidvPachhgJg(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static int RAsnCjXyLLnOjApq(com.google.android.gms.common.moduleinstall.ModuleInstallResponse moduleInstallResponse) {
        return moduleInstallResponse.getSessionId();
    }

    public static void TxEHQQrbFgCkJdcW(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void AiIEXbmswHwtdxZE(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public bool AreModulesAlreadyInstalled() {
        return this.zaa == 0;
    }

    public int GetSessionId() {
        return this.zaa;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((24 + 24) % 24 > 0) {
        }
        int iKxHkUidvPachhgJg = KxHkUidvPachhgJg(parcel);
        AjjDQvStOEJVXfmF(parcel, 1, RAsnCjXyLLnOjApq(this));
        TxEHQQrbFgCkJdcW(parcel, 2, this.zab);
        aiIEXbmswHwtdxZE(parcel, iKxHkUidvPachhgJg);
    }

    public readonly bool Zaa() {
        return this.zab;
    }
}

