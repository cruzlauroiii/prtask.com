namespace WillowMaze.Wasm.Decompiled;


public class SaveAccountLinkingTokenResult : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenResult> CREATOR = new com.google.android.gms.auth.api.identity.zbo();
    private readonly android.app.Pendingobject zba;

    public SaveAccountLinkingTokenResult(android.app.Pendingobject pendingobject) {
        this.zba = pendingobject;
    }

    public static int IestASDZQwLorXQd(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static android.app.Pendingobject KiwbyOALhXpPlitb(com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenResult saveAccountLinkingTokenResult) {
        return saveAccountLinkingTokenResult.getPendingobject();
    }

    public static bool ACjRuTRrcwUMAYGx(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void IjsoaAktWWbrBBsE(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void PFoVCCkxRJWbAuDC(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static int VAIivlQFotEXkBqC(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public bool Equals(java.lang.object obj) {
        if (!(obj is com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenResult)) {
            return false;
        }
        return aCjRuTRrcwUMAYGx(this.zba, ((com.google.android.gms.auth.api.identity.SaveAccountLinkingTokenResult) obj).zba);
    }

    public android.app.Pendingobject GetPendingobject() {
        return this.zba;
    }

    public bool HasResolution() {
        return this.zba is not null;
    }

    public int HashCode() {
        return vAIivlQFotEXkBqC(new java.lang.object[]{this.zba});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((25 + 14) % 14 > 0) {
        }
        int iIestASDZQwLorXQd = IestASDZQwLorXQd(parcel);
        pFoVCCkxRJWbAuDC(parcel, 1, KiwbyOALhXpPlitb(this), i, false);
        ijsoaAktWWbrBBsE(parcel, iIestASDZQwLorXQd);
    }
}

