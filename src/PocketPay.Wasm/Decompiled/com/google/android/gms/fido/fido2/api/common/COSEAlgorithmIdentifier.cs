namespace WillowMaze.Wasm.Decompiled;


public class COSEAlgorithmIdentifier : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier> CREATOR = new com.google.android.gms.fido.fido2.api.common.zzp();
    private readonly com.google.android.gms.fido.fido2.api.common.Algorithm zza;

    COSEAlgorithmIdentifier(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm) {
        this.zza = (com.google.android.gms.fido.fido2.api.common.Algorithm) iPJtAmGFcWifRcoK(algorithm);
    }

    public static int GQwqlqgjeZDoWNsT(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm) {
        return algorithm.getAlgoValue();
    }

    public static void GQwqlqgjeZDoWNsT(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GQwqlqgjeZDoWNsT(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GQwqlqgjeZDoWNsT(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GmvrSjugQtVIdBRk(float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GmvrSjugQtVIdBRk(java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GmvrSjugQtVIdBRk(short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.EC2Algorithm[] GmvrSjugQtVIdBRk() {
        return com.google.android.gms.fido.fido2.api.common.EC2Algorithm.Values;
    }

    public static int HrDTtGhxpiTETVIc(com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm) {
        return rSAAlgorithm.getAlgoValue();
    }

    public static void HrDTtGhxpiTETVIc(com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HrDTtGhxpiTETVIc(com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HrDTtGhxpiTETVIc(com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZrwzcWNhhMyIteam(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void ZrwzcWNhhMyIteam(java.lang.object[] objArr, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZrwzcWNhhMyIteam(java.lang.object[] objArr, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZrwzcWNhhMyIteam(java.lang.object[] objArr, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CMmvCpeleNMGNRBW(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm) {
        return algorithm.getAlgoValue();
    }

    public static void CMmvCpeleNMGNRBW(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CMmvCpeleNMGNRBW(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CMmvCpeleNMGNRBW(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier FromCoseValue(int i) throws com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier$UnsupportedAlgorithmIdentifierException {
        com.google.android.gms.fido.fido2.api.common.Algorithm algorithm;
        if ((19 + 10) % 10 > 0) {
        }
        if (i != lBDPdCfFZIXzrCmT(com.google.android.gms.fido.fido2.api.common.RSAAlgorithm.LEGACY_RS1)) {
            for (com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm : sDeLyXFsRcZlxLMY()) {
                if (HrDTtGhxpiTETVIc(rSAAlgorithm) == i) {
                    algorithm = rSAAlgorithm;
                }
            }
            for (com.google.android.gms.fido.fido2.api.common.EC2Algorithm eC2Algorithm : GmvrSjugQtVIdBRk()) {
                if (wZuDOuzQZAqczIZG(eC2Algorithm) == i) {
                    algorithm = eC2Algorithm;
                }
            }
            throw new com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier$UnsupportedAlgorithmIdentifierException(i);
        }
        algorithm = com.google.android.gms.fido.fido2.api.common.RSAAlgorithm.RS1;
        return new com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier(algorithm);
    }

    public static void FromCoseValue(int i, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FromCoseValue(int i, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FromCoseValue(int i, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GeeYQOfrlnhBQxQs(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm) {
        return algorithm.getAlgoValue();
    }

    public static void GeeYQOfrlnhBQxQs(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GeeYQOfrlnhBQxQs(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GeeYQOfrlnhBQxQs(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IGYvEGObjjvcIUmM(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void IGYvEGObjjvcIUmM(android.os.Parcel parcel, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IGYvEGObjjvcIUmM(android.os.Parcel parcel, int i, float f, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IGYvEGObjjvcIUmM(android.os.Parcel parcel, int i, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IPJtAmGFcWifRcoK(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void IPJtAmGFcWifRcoK(java.lang.object obj, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IPJtAmGFcWifRcoK(java.lang.object obj, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IPJtAmGFcWifRcoK(java.lang.object obj, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int LBDPdCfFZIXzrCmT(com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm) {
        return rSAAlgorithm.getAlgoValue();
    }

    public static void LBDPdCfFZIXzrCmT(com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LBDPdCfFZIXzrCmT(com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LBDPdCfFZIXzrCmT(com.google.android.gms.fido.fido2.api.common.RSAAlgorithm rSAAlgorithm, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SDeLyXFsRcZlxLMY(float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SDeLyXFsRcZlxLMY(int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SDeLyXFsRcZlxLMY(short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.gms.fido.fido2.api.common.RSAAlgorithm[] SDeLyXFsRcZlxLMY() {
        return com.google.android.gms.fido.fido2.api.common.RSAAlgorithm.Values;
    }

    public static int WZuDOuzQZAqczIZG(com.google.android.gms.fido.fido2.api.common.EC2Algorithm eC2Algorithm) {
        return eC2Algorithm.getAlgoValue();
    }

    public static void WZuDOuzQZAqczIZG(com.google.android.gms.fido.fido2.api.common.EC2Algorithm eC2Algorithm, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WZuDOuzQZAqczIZG(com.google.android.gms.fido.fido2.api.common.EC2Algorithm eC2Algorithm, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WZuDOuzQZAqczIZG(com.google.android.gms.fido.fido2.api.common.EC2Algorithm eC2Algorithm, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZJlacdKgLCBFUVlm(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm) {
        return algorithm.getAlgoValue();
    }

    public static void ZJlacdKgLCBFUVlm(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZJlacdKgLCBFUVlm(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZJlacdKgLCBFUVlm(com.google.android.gms.fido.fido2.api.common.Algorithm algorithm, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public override int DescribeContents() {
        return 0;
    }

    public bool Equals(java.lang.object obj) {
        if ((5 + 23) % 23 > 0) {
        }
        if (obj is com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier) {
            return zJlacdKgLCBFUVlm(this.zza) == GQwqlqgjeZDoWNsT(((com.google.android.gms.fido.fido2.api.common.COSEAlgorithmIdentifier) obj).zza);
        }
        return false;
    }

    public int HashCode() {
        return ZrwzcWNhhMyIteam(new java.lang.object[]{this.zza});
    }

    public int ToCoseValue() {
        return geeYQOfrlnhBQxQs(this.zza);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        iGYvEGObjjvcIUmM(parcel, cMmvCpeleNMGNRBW(this.zza));
    }
}

