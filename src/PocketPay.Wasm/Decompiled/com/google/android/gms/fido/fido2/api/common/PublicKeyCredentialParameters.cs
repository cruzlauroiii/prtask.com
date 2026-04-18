namespace WillowMaze.Wasm.Decompiled;


public class PublicKeyCredentialParameters : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters> CREATOR = new com.google.android.gms.fido.fido2.api.common.zzan();
    private readonly com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType zza;
    private readonly com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier zzb;

    public PublicKeyCredentialParameters(java.lang.string str, int i) {
        oggmCTcLfcEuUvTo(str);
        try {
            this.zza = UzcgsGxWkKyibkEx(str);
            pDCiuetKNYkJjCoO(PGQlwskjsLcXYUOJ(i));
            try {
                this.zzb = bfraiTaEEIyMcqhM(i);
            } catch (com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier$UnsupportedAlgorithmIdentifierException e) {
                throw new java.lang.IllegalArgumentException(e);
            }
        } catch (com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType$UnsupportedPublicKeyCredTypeException e2) {
            throw new java.lang.IllegalArgumentException(e2);
        }
    }

    public static java.lang.string FzkGHvdBcPKefCcH(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType) {
        return publicKeyCredentialType.tostring();
    }

    public static void FzkGHvdBcPKefCcH(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FzkGHvdBcPKefCcH(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FzkGHvdBcPKefCcH(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int HlGGKmoaeMJMdeyG(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters publicKeyCredentialParameters) {
        return publicKeyCredentialParameters.getAlgorithmIdAsint();
    }

    public static void HlGGKmoaeMJMdeyG(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters publicKeyCredentialParameters, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HlGGKmoaeMJMdeyG(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters publicKeyCredentialParameters, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HlGGKmoaeMJMdeyG(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters publicKeyCredentialParameters, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int HvmTBrBSihOMtlID(com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier cOSEAlgorithmIdentifier) {
        return cOSEAlgorithmIdentifier.toCoseValue();
    }

    public static void HvmTBrBSihOMtlID(com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier cOSEAlgorithmIdentifier, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HvmTBrBSihOMtlID(com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier cOSEAlgorithmIdentifier, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HvmTBrBSihOMtlID(com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier cOSEAlgorithmIdentifier, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int IhCcVzmOvqhmVsFO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void IhCcVzmOvqhmVsFO(int i, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IhCcVzmOvqhmVsFO(int i, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IhCcVzmOvqhmVsFO(int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JMHUYEZiQwqTPZWF(com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier cOSEAlgorithmIdentifier, java.lang.object obj, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JMHUYEZiQwqTPZWF(com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier cOSEAlgorithmIdentifier, java.lang.object obj, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JMHUYEZiQwqTPZWF(com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier cOSEAlgorithmIdentifier, java.lang.object obj, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JMHUYEZiQwqTPZWF(com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier cOSEAlgorithmIdentifier, java.lang.object obj) {
        return cOSEAlgorithmIdentifier.Equals(obj);
    }

    public static int LKgposvMjQtQLLJH(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void LKgposvMjQtQLLJH(java.lang.object[] objArr, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LKgposvMjQtQLLJH(java.lang.object[] objArr, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LKgposvMjQtQLLJH(java.lang.object[] objArr, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LYYXGdnONMxzIgxn(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void LYYXGdnONMxzIgxn(android.os.Parcel parcel, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LYYXGdnONMxzIgxn(android.os.Parcel parcel, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LYYXGdnONMxzIgxn(android.os.Parcel parcel, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int PGQlwskjsLcXYUOJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PGQlwskjsLcXYUOJ(int i, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PGQlwskjsLcXYUOJ(int i, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PGQlwskjsLcXYUOJ(int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UkHeIwNgQbJmEyZJ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void UkHeIwNgQbJmEyZJ(android.os.Parcel parcel, int i, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UkHeIwNgQbJmEyZJ(android.os.Parcel parcel, int i, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UkHeIwNgQbJmEyZJ(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType UzcgsGxWkKyibkEx(java.lang.string str) {
        return com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType.fromstring(str);
    }

    public static void UzcgsGxWkKyibkEx(java.lang.string str, float f, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UzcgsGxWkKyibkEx(java.lang.string str, int i, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UzcgsGxWkKyibkEx(java.lang.string str, short s, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YGIlfvHPuFCitBWf(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void YGIlfvHPuFCitBWf(android.os.Parcel parcel, int i, java.lang.string str, bool z, byte b, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YGIlfvHPuFCitBWf(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YGIlfvHPuFCitBWf(android.os.Parcel parcel, int i, java.lang.string str, bool z, short s, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YOLGyQETFhAiqzwn(android.os.Parcel parcel, int i, java.lang.int num, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeintobject(parcel, i, num, z);
    }

    public static void YOLGyQETFhAiqzwn(android.os.Parcel parcel, int i, java.lang.int num, bool z, int i2, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YOLGyQETFhAiqzwn(android.os.Parcel parcel, int i, java.lang.int num, bool z, short s, int i2, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YOLGyQETFhAiqzwn(android.os.Parcel parcel, int i, java.lang.int num, bool z, bool z2, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier BfraiTaEEIyMcqhM(int i) {
        return com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier.fromCoseValue(i);
    }

    public static void BfraiTaEEIyMcqhM(int i, byte b, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BfraiTaEEIyMcqhM(int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BfraiTaEEIyMcqhM(int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EOVUqSDaROuwCThX(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters publicKeyCredentialParameters) {
        return publicKeyCredentialParameters.getTypeAsstring();
    }

    public static void EOVUqSDaROuwCThX(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters publicKeyCredentialParameters, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EOVUqSDaROuwCThX(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters publicKeyCredentialParameters, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EOVUqSDaROuwCThX(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters publicKeyCredentialParameters, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IhxOevRwGxyFwbmI(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, java.lang.object obj, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IhxOevRwGxyFwbmI(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, java.lang.object obj, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IhxOevRwGxyFwbmI(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, java.lang.object obj, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool IhxOevRwGxyFwbmI(com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType publicKeyCredentialType, java.lang.object obj) {
        return publicKeyCredentialType.Equals(obj);
    }

    public static java.lang.object OggmCTcLfcEuUvTo(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void OggmCTcLfcEuUvTo(java.lang.object obj, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OggmCTcLfcEuUvTo(java.lang.object obj, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OggmCTcLfcEuUvTo(java.lang.object obj, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PDCiuetKNYkJjCoO(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void PDCiuetKNYkJjCoO(java.lang.object obj, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PDCiuetKNYkJjCoO(java.lang.object obj, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PDCiuetKNYkJjCoO(java.lang.object obj, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 18) % 18 > 0) {
        }
        if (!(obj is com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters)) {
            return false;
        }
        com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters publicKeyCredentialParameters = (com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialParameters) obj;
        return ihxOevRwGxyFwbmI(this.zza, publicKeyCredentialParameters.zza) && JMHUYEZiQwqTPZWF(this.zzb, publicKeyCredentialParameters.zzb);
    }

    public com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier GetAlgorithm() {
        return this.zzb;
    }

    public int GetAlgorithmIdAsint() {
        return HvmTBrBSihOMtlID(this.zzb);
    }

    public com.google.android.gms.fido.fido2.api.common.PublicKeyCredentialType GetType() {
        return this.zza;
    }

    public java.lang.string GetTypeAsstring() {
        return FzkGHvdBcPKefCcH(this.zza);
    }

    public int HashCode() {
        return LKgposvMjQtQLLJH(new java.lang.object[]{this.zza, this.zzb});
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((32 + 1) % 1 > 0) {
        }
        int iLYYXGdnONMxzIgxn = LYYXGdnONMxzIgxn(parcel);
        YGIlfvHPuFCitBWf(parcel, 2, eOVUqSDaROuwCThX(this), false);
        YOLGyQETFhAiqzwn(parcel, 3, IhCcVzmOvqhmVsFO(HlGGKmoaeMJMdeyG(this)), false);
        UkHeIwNgQbJmEyZJ(parcel, iLYYXGdnONMxzIgxn);
    }
}

