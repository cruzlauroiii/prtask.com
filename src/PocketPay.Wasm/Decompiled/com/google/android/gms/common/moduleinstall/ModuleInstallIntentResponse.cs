namespace WillowMaze.Wasm.Decompiled;


public class ModuleInstallobjectResponse : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse> CREATOR = new com.google.android.gms.common.moduleinstall.zab();
    private readonly android.app.Pendingobject zaa;

    public ModuleInstallobjectResponse(android.app.Pendingobject pendingobject) {
        this.zaa = pendingobject;
    }

    public static void ImdkccezaaHKMjfk(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void FEFEBJvsaiqaaCjl(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static android.app.Pendingobject HhmiibJsRjrOBjMK(com.google.android.gms.common.moduleinstall.ModuleInstallobjectResponse moduleInstallobjectResponse) {
        return moduleInstallobjectResponse.getPendingobject();
    }

    public static int LJIUZWZNybEiwfbN(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public android.app.Pendingobject GetPendingobject() {
        return this.zaa;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((5 + 3) % 3 > 0) {
        }
        int iLJIUZWZNybEiwfbN = lJIUZWZNybEiwfbN(parcel);
        ImdkccezaaHKMjfk(parcel, 1, hhmiibJsRjrOBjMK(this), i, false);
        fEFEBJvsaiqaaCjl(parcel, iLJIUZWZNybEiwfbN);
    }
}

