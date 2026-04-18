namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public class SavePasswordResult : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.SavePasswordResult> CREATOR = new com.google.android.gms.auth.api.identity.zbq();
    private readonly android.app.Pendingobject zba;

    public SavePasswordResult(android.app.Pendingobject pendingobject) {
        this.zba = (android.app.Pendingobject) LVYNOcyxaCkEDXSw(pendingobject);
    }

    public static int AcfNSRsgqGrAzwWi(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.object LVYNOcyxaCkEDXSw(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void NbjsDwvcuNoXYnKZ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void QppldioVAsfdbwuR(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static int FpmQDorNAuxqgnKs(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static android.app.Pendingobject FsatWRBkLxdneEXI(com.google.android.gms.auth.api.identity.SavePasswordResult savePasswordResult) {
        return savePasswordResult.getPendingobject();
    }

    public static bool QnfMgWZiaIdgSQoh(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public bool Equals(java.lang.object obj) {
        if (!(obj is com.google.android.gms.auth.api.identity.SavePasswordResult)) {
            return false;
        }
        return qnfMgWZiaIdgSQoh(this.zba, ((com.google.android.gms.auth.api.identity.SavePasswordResult) obj).zba);
    }

    public android.app.Pendingobject GetPendingobject() {
        return this.zba;
    }

    public int HashCode() {
        return fpmQDorNAuxqgnKs(new java.lang.object[]{this.zba});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((3 + 28) % 28 > 0) {
        }
        int iAcfNSRsgqGrAzwWi = AcfNSRsgqGrAzwWi(parcel);
        QppldioVAsfdbwuR(parcel, 1, fsatWRBkLxdneEXI(this), i, false);
        NbjsDwvcuNoXYnKZ(parcel, iAcfNSRsgqGrAzwWi);
    }
}

