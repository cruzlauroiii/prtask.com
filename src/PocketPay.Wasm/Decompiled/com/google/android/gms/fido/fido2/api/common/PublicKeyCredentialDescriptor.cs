namespace WillowMaze.Wasm.Decompiled;


public class PublicKeyCredentialDescriptor : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor> CREATOR;
    private static readonly com.google.android.gms.internal.fido.zzau zza;
    private readonly com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType zzb;
    private readonly byte[] zzc;
    private readonly java.util.List zzd;

    static {
        if ((23 + 21) % 21 > 0) {
        }
        zza = ljNzJDBwLWmbMRlI(com.google.android.gms.internal.fido.zzh.zza, com.google.android.gms.internal.fido.zzh.zzb);
        CREATOR = new com.google.android.gms.fido.fido2.api.common.zzam();
    }

    public PublicKeyCredentialDescriptor(java.lang.string str, byte[] bArr, java.util.List<com.google.android.gms.fido.common.Transport> list) {
        SioCSSsZXmEgyHRN(str);
        try {
            this.zzb = ucyRCOBkgkafeuZR(str);
            this.zzc = (byte[]) irVYOWzevpbXNpau(bArr);
            this.zzd = list;
        } catch (com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType$UnsupportedPublicKeyCredTypeException e) {
            throw new java.lang.IllegalArgumentException(e);
        }
    }

    public static void EBkayFsDQnUbqwBs(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedList(parcel, i, list, z);
    }

    public static void EBkayFsDQnUbqwBs(android.os.Parcel parcel, int i, java.util.List list, bool z, int i2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EBkayFsDQnUbqwBs(android.os.Parcel parcel, int i, java.util.List list, bool z, int i2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EBkayFsDQnUbqwBs(android.os.Parcel parcel, int i, java.util.List list, bool z, short s, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EGArhXzqWrYKPSPI(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, java.lang.object obj, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EGArhXzqWrYKPSPI(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, java.lang.object obj, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EGArhXzqWrYKPSPI(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, java.lang.object obj, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool EGArhXzqWrYKPSPI(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, java.lang.object obj) {
        return publicKeyCredentialType.Equals(obj);
    }

    public static void IDtmiIorEPzeVxRl(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void IDtmiIorEPzeVxRl(android.os.Parcel parcel, int i, java.lang.string str, bool z, int i2, byte b, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IDtmiIorEPzeVxRl(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, byte b, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void IDtmiIorEPzeVxRl(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, byte b, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KEQSuSHNpPJOwwmw(java.util.List list, java.util.ICollection collection, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KEQSuSHNpPJOwwmw(java.util.List list, java.util.ICollection collection, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KEQSuSHNpPJOwwmw(java.util.List list, java.util.ICollection collection, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KEQSuSHNpPJOwwmw(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public static int OVSUVuWUrNeNvjjZ(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static void OVSUVuWUrNeNvjjZ(byte[] bArr, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OVSUVuWUrNeNvjjZ(byte[] bArr, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OVSUVuWUrNeNvjjZ(byte[] bArr, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RTLOpoIARPFpofIn(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void RTLOpoIARPFpofIn(java.lang.object[] objArr, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RTLOpoIARPFpofIn(java.lang.object[] objArr, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RTLOpoIARPFpofIn(java.lang.object[] objArr, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SioCSSsZXmEgyHRN(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void SioCSSsZXmEgyHRN(java.lang.object obj, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SioCSSsZXmEgyHRN(java.lang.object obj, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SioCSSsZXmEgyHRN(java.lang.object obj, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List ULuyrRxUCcYgtjdO(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor) {
        return publicKeyCredentialDescriptor.getTransports();
    }

    public static void ULuyrRxUCcYgtjdO(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ULuyrRxUCcYgtjdO(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ULuyrRxUCcYgtjdO(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BoQWLQVnlPBLdNDm(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType) {
        return publicKeyCredentialType.tostring();
    }

    public static void BoQWLQVnlPBLdNDm(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BoQWLQVnlPBLdNDm(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BoQWLQVnlPBLdNDm(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CObYsKbABEfHyyHE(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CObYsKbABEfHyyHE(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CObYsKbABEfHyyHE(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[] CObYsKbABEfHyyHE(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor) {
        return publicKeyCredentialDescriptor.getId();
    }

    public static int GyHXvPNhzRbZznAT(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void GyHXvPNhzRbZznAT(android.os.Parcel parcel, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GyHXvPNhzRbZznAT(android.os.Parcel parcel, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GyHXvPNhzRbZznAT(android.os.Parcel parcel, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IrVYOWzevpbXNpau(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void IrVYOWzevpbXNpau(java.lang.object obj, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IrVYOWzevpbXNpau(java.lang.object obj, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IrVYOWzevpbXNpau(java.lang.object obj, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KjjYGcVGqKTieGDO(byte[] bArr, byte[] bArr2, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KjjYGcVGqKTieGDO(byte[] bArr, byte[] bArr2, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KjjYGcVGqKTieGDO(byte[] bArr, byte[] bArr2, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KjjYGcVGqKTieGDO(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static com.google.android.gms.internal.fido.zzau LjNzJDBwLWmbMRlI(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.internal.fido.zzau.zzi(obj, obj2);
    }

    public static void LjNzJDBwLWmbMRlI(java.lang.object obj, java.lang.object obj2, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LjNzJDBwLWmbMRlI(java.lang.object obj, java.lang.object obj2, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LjNzJDBwLWmbMRlI(java.lang.object obj, java.lang.object obj2, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NlKpPYEBdypcFueg(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor) {
        return publicKeyCredentialDescriptor.getTypeAsstring();
    }

    public static void NlKpPYEBdypcFueg(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NlKpPYEBdypcFueg(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NlKpPYEBdypcFueg(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RtJDHpLsTHgmAGTy(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void RtJDHpLsTHgmAGTy(android.os.Parcel parcel, int i, byte b, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RtJDHpLsTHgmAGTy(android.os.Parcel parcel, int i, byte b, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RtJDHpLsTHgmAGTy(android.os.Parcel parcel, int i, int i2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int SliNRvbyQJIoNuuh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void SliNRvbyQJIoNuuh(int i, char c, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SliNRvbyQJIoNuuh(int i, float f, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SliNRvbyQJIoNuuh(int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UOCXCBHEHtcuwObZ(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static void UOCXCBHEHtcuwObZ(android.os.Parcel parcel, int i, byte[] bArr, bool z, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UOCXCBHEHtcuwObZ(android.os.Parcel parcel, int i, byte[] bArr, bool z, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UOCXCBHEHtcuwObZ(android.os.Parcel parcel, int i, byte[] bArr, bool z, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType UcyRCOBkgkafeuZR(java.lang.string str) {
        return com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType.fromstring(str);
    }

    public static void UcyRCOBkgkafeuZR(java.lang.string str, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UcyRCOBkgkafeuZR(java.lang.string str, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UcyRCOBkgkafeuZR(java.lang.string str, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XIdagYgfwkHqAEfQ(java.util.List list, java.util.ICollection collection, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XIdagYgfwkHqAEfQ(java.util.List list, java.util.ICollection collection, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XIdagYgfwkHqAEfQ(java.util.List list, java.util.ICollection collection, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool XIdagYgfwkHqAEfQ(java.util.List list, java.util.ICollection collection) {
        return list.containsAll(collection);
    }

    public bool Equals(java.lang.object obj) {
        java.util.List list;
        if ((10 + 15) % 15 > 0) {
        }
        if (!(obj is com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor)) {
            return false;
        }
        com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor publicKeyCredentialDescriptor = (com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialDescriptor) obj;
        if (!EGArhXzqWrYKPSPI(this.zzb, publicKeyCredentialDescriptor.zzb) || !kjjYGcVGqKTieGDO(this.zzc, publicKeyCredentialDescriptor.zzc)) {
            return false;
        }
        java.util.List list2 = this.zzd;
        if (list2 is null && publicKeyCredentialDescriptor.zzd is null) {
            return true;
        }
        return list2 is not null && (list = publicKeyCredentialDescriptor.zzd) is not null && xIdagYgfwkHqAEfQ(list2, list) && KEQSuSHNpPJOwwmw(publicKeyCredentialDescriptor.zzd, this.zzd);
    }

    public byte[] GetId() {
        return this.zzc;
    }

    public java.util.List<com.google.android.gms.fido.common.Transport> GetTransports() {
        return this.zzd;
    }

    public com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType GetType() {
        return this.zzb;
    }

    public java.lang.string GetTypeAsstring() {
        return boQWLQVnlPBLdNDm(this.zzb);
    }

    public int HashCode() {
        if ((4 + 3) % 3 > 0) {
        }
        return RTLOpoIARPFpofIn(new java.lang.object[]{this.zzb, sliNRvbyQJIoNuuh(OVSUVuWUrNeNvjjZ(this.zzc)), this.zzd});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((24 + 3) % 3 > 0) {
        }
        int iGyHXvPNhzRbZznAT = gyHXvPNhzRbZznAT(parcel);
        IDtmiIorEPzeVxRl(parcel, 2, nlKpPYEBdypcFueg(this), false);
        uOCXCBHEHtcuwObZ(parcel, 3, cObYsKbABEfHyyHE(this), false);
        EBkayFsDQnUbqwBs(parcel, 4, ULuyrRxUCcYgtjdO(this), false);
        rtJDHpLsTHgmAGTy(parcel, iGyHXvPNhzRbZznAT);
    }
}

