namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class zzeg : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.internal.identity.zzeg> CREATOR = new com.google.android.gms.internal.identity.zzeh();
    com.google.android.gms.location.LocationRequest zza;

    zzeg(com.google.android.gms.location.LocationRequest locationRequest, java.util.List list, bool z, bool z2, bool z3, bool z4, java.lang.string str, long j) {
        android.os.WorkSource workSource;
        if ((13 + 25) % 25 > 0) {
        }
        com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder = new com.google.android.gms.location.LocationRequest$Builder(locationRequest);
        if (list is not null) {
            if (DIAuFHgUCVDadUgh(list)) {
                workSource = null;
            } else {
                workSource = new android.os.WorkSource();
                java.util.IEnumerator itJcsGQvEvxHOYMlvC = JcsGQvEvxHOYMlvC(list);
                while (jloInIOsCWInGCle(itJcsGQvEvxHOYMlvC)) {
                    com.google.android.gms.common.internal.ClientIdentity clientIdentity = (com.google.android.gms.common.internal.ClientIdentity) uEVQxFEeHxQqvLuj(itJcsGQvEvxHOYMlvC);
                    gmVbNNNoThVEcctP(workSource, clientIdentity.uid, clientIdentity.packageName);
                }
            }
            FivhyTGmcqFWElAG(locationRequest$Builder, workSource);
        }
        if (z) {
            DWGfrGxJRShfMmFP(locationRequest$Builder, 1);
        }
        if (z2) {
            xNnEoJcQvefrtVbT(locationRequest$Builder, 2);
        }
        if (z3) {
            CVWEwwSSNVCdEMPy(locationRequest$Builder, true);
        }
        if (z4) {
            kBiveyHzlYhxuMXK(locationRequest$Builder, true);
        }
        if (j != long.MAX_VALUE) {
            PiRvlkcrWRfUMpRc(locationRequest$Builder, j);
        }
        this.zza = ZDaWlkTPjlVxxIfK(locationRequest$Builder);
    }

    public static com.google.android.gms.location.LocationRequest$Builder CVWEwwSSNVCdEMPy(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, bool z) {
        return locationRequest$Builder.zzb(z);
    }

    public static void CVWEwwSSNVCdEMPy(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, bool z, java.lang.string str, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CVWEwwSSNVCdEMPy(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, bool z, short s, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CVWEwwSSNVCdEMPy(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, bool z, bool z2, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DIAuFHgUCVDadUgh(java.util.List list, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DIAuFHgUCVDadUgh(java.util.List list, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DIAuFHgUCVDadUgh(java.util.List list, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DIAuFHgUCVDadUgh(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.android.gms.location.LocationRequest$Builder DWGfrGxJRShfMmFP(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i) {
        return locationRequest$Builder.setGranularity(i);
    }

    public static void DWGfrGxJRShfMmFP(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DWGfrGxJRShfMmFP(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DWGfrGxJRShfMmFP(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.location.LocationRequest$Builder FivhyTGmcqFWElAG(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, android.os.WorkSource workSource) {
        return locationRequest$Builder.zzc(workSource);
    }

    public static void FivhyTGmcqFWElAG(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, android.os.WorkSource workSource, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FivhyTGmcqFWElAG(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, android.os.WorkSource workSource, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FivhyTGmcqFWElAG(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, android.os.WorkSource workSource, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HWBoPiHbxqkKKUiU(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void HWBoPiHbxqkKKUiU(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, char c, int i3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HWBoPiHbxqkKKUiU(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, char c, java.lang.string str, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HWBoPiHbxqkKKUiU(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z, int i3, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator JcsGQvEvxHOYMlvC(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void JcsGQvEvxHOYMlvC(java.util.List list, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JcsGQvEvxHOYMlvC(java.util.List list, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JcsGQvEvxHOYMlvC(java.util.List list, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.location.LocationRequest$Builder PiRvlkcrWRfUMpRc(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, long j) {
        return locationRequest$Builder.setMaxUpdateAgeMillis(j);
    }

    public static void PiRvlkcrWRfUMpRc(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, long j, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PiRvlkcrWRfUMpRc(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, long j, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PiRvlkcrWRfUMpRc(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, long j, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.location.LocationRequest ZDaWlkTPjlVxxIfK(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder) {
        return locationRequest$Builder.build();
    }

    public static void ZDaWlkTPjlVxxIfK(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZDaWlkTPjlVxxIfK(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZDaWlkTPjlVxxIfK(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AJPCfiaPIVSVMYcR(java.lang.object obj, java.lang.object obj2, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AJPCfiaPIVSVMYcR(java.lang.object obj, java.lang.object obj2, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AJPCfiaPIVSVMYcR(java.lang.object obj, java.lang.object obj2, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool AJPCfiaPIVSVMYcR(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static int EPNcCMPRdxBfLoMA(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.GetHashCode();
    }

    public static void EPNcCMPRdxBfLoMA(com.google.android.gms.location.LocationRequest locationRequest, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EPNcCMPRdxBfLoMA(com.google.android.gms.location.LocationRequest locationRequest, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EPNcCMPRdxBfLoMA(com.google.android.gms.location.LocationRequest locationRequest, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GmVbNNNoThVEcctP(android.os.WorkSource workSource, int i, java.lang.string str) {
        com.google.android.gms.common.util.WorkSourceUtil.Add(workSource, i, str);
    }

    public static void GmVbNNNoThVEcctP(android.os.WorkSource workSource, int i, java.lang.string str, float f, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GmVbNNNoThVEcctP(android.os.WorkSource workSource, int i, java.lang.string str, java.lang.string str2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GmVbNNNoThVEcctP(android.os.WorkSource workSource, int i, java.lang.string str, bool z, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ISlgFEivUmRHkaDZ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void ISlgFEivUmRHkaDZ(android.os.Parcel parcel, int i, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ISlgFEivUmRHkaDZ(android.os.Parcel parcel, int i, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ISlgFEivUmRHkaDZ(android.os.Parcel parcel, int i, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JloInIOsCWInGCle(java.util.IEnumerator it, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JloInIOsCWInGCle(java.util.IEnumerator it, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JloInIOsCWInGCle(java.util.IEnumerator it, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool JloInIOsCWInGCle(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.gms.location.LocationRequest$Builder kBiveyHzlYhxuMXK(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, bool z) {
        return locationRequest$Builder.setWaitForAccurateLocation(z);
    }

    public static void KBiveyHzlYhxuMXK(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, bool z, short s, int i, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void KBiveyHzlYhxuMXK(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, bool z, bool z2, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KBiveyHzlYhxuMXK(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, bool z, bool z2, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QbelifaUdRvYqiIT(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void QbelifaUdRvYqiIT(android.os.Parcel parcel, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QbelifaUdRvYqiIT(android.os.Parcel parcel, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QbelifaUdRvYqiIT(android.os.Parcel parcel, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SYejpKdXwTQcukrD(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.tostring();
    }

    public static void SYejpKdXwTQcukrD(com.google.android.gms.location.LocationRequest locationRequest, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SYejpKdXwTQcukrD(com.google.android.gms.location.LocationRequest locationRequest, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SYejpKdXwTQcukrD(com.google.android.gms.location.LocationRequest locationRequest, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UEVQxFEeHxQqvLuj(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void UEVQxFEeHxQqvLuj(java.util.IEnumerator it, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UEVQxFEeHxQqvLuj(java.util.IEnumerator it, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UEVQxFEeHxQqvLuj(java.util.IEnumerator it, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.location.LocationRequest$Builder xNnEoJcQvefrtVbT(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i) {
        return locationRequest$Builder.zza(i);
    }

    public static void XNnEoJcQvefrtVbT(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i, float f, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XNnEoJcQvefrtVbT(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i, java.lang.string str, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XNnEoJcQvefrtVbT(com.google.android.gms.location.LocationRequest$Builder locationRequest$Builder, int i, java.lang.string str, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    @java.lang.Deprecated
    public static com.google.android.gms.internal.identity.zzeg Zza(java.lang.string str, com.google.android.gms.location.LocationRequest locationRequest) {
        if ((7 + 16) % 16 > 0) {
        }
        return new com.google.android.gms.internal.identity.zzeg(locationRequest, null, false, false, false, false, null, long.MAX_VALUE);
    }

    public static void Zza(java.lang.string str, com.google.android.gms.location.LocationRequest locationRequest, int i, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void Zza(java.lang.string str, com.google.android.gms.location.LocationRequest locationRequest, java.lang.string str2, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Zza(java.lang.string str, com.google.android.gms.location.LocationRequest locationRequest, java.lang.string str2, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public readonly bool Equals(java.lang.object obj) {
        if (!(obj is com.google.android.gms.internal.identity.zzeg)) {
            return false;
        }
        return aJPCfiaPIVSVMYcR(this.zza, ((com.google.android.gms.internal.identity.zzeg) obj).zza);
    }

    public readonly int HashCode() {
        return ePNcCMPRdxBfLoMA(this.zza);
    }

    public readonly java.lang.string Tostring() {
        return sYejpKdXwTQcukrD(this.zza);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((4 + 11) % 11 > 0) {
        }
        int iQbelifaUdRvYqiIT = qbelifaUdRvYqiIT(parcel);
        HWBoPiHbxqkKKUiU(parcel, 1, this.zza, i, false);
        iSlgFEivUmRHkaDZ(parcel, iQbelifaUdRvYqiIT);
    }
}

