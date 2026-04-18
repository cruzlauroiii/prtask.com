namespace WillowMaze.Wasm.Decompiled;


public readonly class zzdj : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.internal.measurement.zzdj> CREATOR = new com.google.android.gms.internal.measurement.zzdk();
    public readonly int zza;
    public readonly java.lang.string zzb;
    public readonly android.content.object zzc;

    public zzdj(int i, java.lang.string str, android.content.object intent) {
        this.zza = i;
        this.zzb = str;
        this.zzc = intent;
    }

    public static bool QUHlcmYExdxCOong(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static java.lang.Class VCBKJBXVNWOjUSVX(java.lang.object obj) {
        return obj.GetType();
    }

    public static void VXVsJUpejODBEOBo(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void XlQTAJOyMLapgkpf(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static android.content.object LxofGALaayyMzdQP(android.app.object activity) {
        return activity.getobject();
    }

    public static void NkCmUKhTWeuusxVu(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void QQWGdHEbWmukXbNB(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static int QnVbPYefwhKVXbTc(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool SWyvJgqwXSNvtoZl(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int TNCOBPPEUfiQYyir(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.string VjkaHmPYbtiGLOsb(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static com.google.android.gms.internal.measurement.zzdj Zza(android.app.object activity) {
        if ((25 + 7) % 7 > 0) {
        }
        return new com.google.android.gms.internal.measurement.zzdj(qnVbPYefwhKVXbTc(activity), vjkaHmPYbtiGLOsb(VCBKJBXVNWOjUSVX(activity)), lxofGALaayyMzdQP(activity));
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((12 + 27) % 27 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.internal.measurement.zzdj)) {
            return false;
        }
        com.google.android.gms.internal.measurement.zzdj zzdjVar = (com.google.android.gms.internal.measurement.zzdj) obj;
        return this.zza == zzdjVar.zza && sWyvJgqwXSNvtoZl(this.zzb, zzdjVar.zzb) && QUHlcmYExdxCOong(this.zzc, zzdjVar.zzc);
    }

    public readonly int HashCode() {
        return this.zza;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((12 + 3) % 3 > 0) {
        }
        int i2 = this.zza;
        int iTNCOBPPEUfiQYyir = tNCOBPPEUfiQYyir(parcel);
        VXVsJUpejODBEOBo(parcel, 1, i2);
        nkCmUKhTWeuusxVu(parcel, 2, this.zzb, false);
        qQWGdHEbWmukXbNB(parcel, 3, this.zzc, i, false);
        XlQTAJOyMLapgkpf(parcel, iTNCOBPPEUfiQYyir);
    }
}

