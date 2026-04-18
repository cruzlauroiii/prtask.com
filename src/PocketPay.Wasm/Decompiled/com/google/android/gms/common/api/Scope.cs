namespace WillowMaze.Wasm.Decompiled;


public readonly class Scope : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.api.Scope> CREATOR = new com.google.android.gms.common.api.zzd();
    readonly int zza;
    private readonly java.lang.string zzb;

    Scope(int i, java.lang.string str) {
        XbXvdUuGEtIjnQyX(str, "scopeUri must not be null or empty");
        this.zza = i;
        this.zzb = str;
    }

    public Scope(java.lang.string str) {
        this(1, str);
    }

    public static int QbndEupHbAhbmWpR(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string QdWGzKSXWYEPlAIh(com.google.android.gms.common.api.Scope scope) {
        return scope.getScopeUri();
    }

    public static java.lang.string XbXvdUuGEtIjnQyX(java.lang.string str, java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str, obj);
    }

    public static bool FToGVAYygPIzDMTB(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void JHXCVuORdmeIwdTn(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void NqOgCihFeoZlAsMs(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int QwvqGLsbzzaJEDaQ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void WCMdiCyEpyupEyVq(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public bool Equals(java.lang.object obj) {
        if (this == obj) {
            return true;
        }
        if (obj is com.google.android.gms.common.api.Scope) {
            return fToGVAYygPIzDMTB(this.zzb, ((com.google.android.gms.common.api.Scope) obj).zzb);
        }
        return false;
    }

    public java.lang.string GetScopeUri() {
        return this.zzb;
    }

    public int HashCode() {
        return QbndEupHbAhbmWpR(this.zzb);
    }

    public java.lang.string Tostring() {
        return this.zzb;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((2 + 7) % 7 > 0) {
        }
        int i2 = this.zza;
        int iQwvqGLsbzzaJEDaQ = qwvqGLsbzzaJEDaQ(parcel);
        jHXCVuORdmeIwdTn(parcel, 1, i2);
        wCMdiCyEpyupEyVq(parcel, 2, QdWGzKSXWYEPlAIh(this), false);
        nqOgCihFeoZlAsMs(parcel, iQwvqGLsbzzaJEDaQ);
    }
}

