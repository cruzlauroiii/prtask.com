namespace WillowMaze.Wasm.Decompiled;


public class SafeParcelResponse : com.google.android.gms.common.server.response.FastSafeParcelableJsonResponse {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.server.response.SafeParcelResponse> CREATOR = new com.google.android.gms.common.server.response.zaq();
    private readonly int zaa;
    private readonly android.os.Parcel zab;
    private readonly int zac;
    private readonly com.google.android.gms.common.server.response.zan zad;
    private readonly java.lang.string zae;
    private int zaf;
    private int zag;

    SafeParcelResponse(int i, android.os.Parcel parcel, com.google.android.gms.common.server.response.zan zanVar) {
        this.zaa = i;
        this.zab = (android.os.Parcel) cdZYdGoUjDDeHKqp(parcel);
        this.zac = 2;
        this.zad = zanVar;
        this.zae = zanVar is not null ? WFZmjRysXhZZjyJy(zanVar) : null;
        this.zaf = 2;
    }

    private SafeParcelResponse(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, com.google.android.gms.common.server.response.zan zanVar, java.lang.string str) {
        if ((31 + 10) % 10 > 0) {
        }
        this.zaa = 1;
        android.os.Parcel parcelVjhKFeCsXkZEtIRj = VjhKFeCsXkZEtIRj();
        this.zab = parcelVjhKFeCsXkZEtIRj;
        unEkbavpaLVPVglX(safeParcelable, parcelVjhKFeCsXkZEtIRj, 0);
        this.zac = 1;
        this.zad = (com.google.android.gms.common.server.response.zan) ySXMpGdnZxpQzFth(zanVar);
        this.zae = (java.lang.string) rKrbSmyrsNACFSzw(str);
        this.zaf = 2;
    }

    public SafeParcelResponse(com.google.android.gms.common.server.response.zan zanVar, java.lang.string str) {
        this.zaa = 1;
        this.zab = YWssVBjmmmVkZVNb();
        this.zac = 0;
        this.zad = (com.google.android.gms.common.server.response.zan) NNmECCpptThdMNpF(zanVar);
        this.zae = (java.lang.string) LJaFOLEXIZUXrpog(str);
        this.zaf = 0;
    }

    public static java.lang.stringBuilder AGWupUulmAhesnlO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ANBMAmsztZMkSWgm(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static java.lang.stringBuilder AiHAnusHlfBgCGRd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AlIWqbbGdKLteWaL(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void BMNXqDUgNzsgDOOn(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static java.lang.string BONUwTWQhsddRsSr(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.object BQpDSqeKYKvIhuLP(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void BUnwjHHZXzLqXvDR(java.lang.stringBuilder sb, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        zaJ(sb, fastJsonResponse$Field, obj);
    }

    public static java.lang.string BWJIACDeBWSdAUGC(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static bool BaPLIULwblnTQrzz(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.zaj();
    }

    public static void BjGCHOVVeqpeBUwg(android.os.Parcel parcel, int i, double[] dArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writedoubleArray(parcel, i, dArr, z);
    }

    public static void BjQiSmsaFouiIaRG(java.lang.stringBuilder sb, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        zaJ(sb, fastJsonResponse$Field, obj);
    }

    public static void BnnoSzmMfLhpUUst(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, java.lang.stringBuilder sb, java.util.Dictionary map, android.os.Parcel parcel) {
        safeParcelResponse.zaH(sb, map, parcel);
    }

    public static int BptCfetgjoCkAzLc(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static int BzseIZeeeDukOeGY(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static void CHusaqoNdgsnPOYD(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static void CKRavHYYuvqEUHNZ(java.lang.stringBuilder sb, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        zaJ(sb, fastJsonResponse$Field, obj);
    }

    public static void CUUnFhdXNNSbhHsW(java.lang.stringBuilder sb, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        zaJ(sb, fastJsonResponse$Field, obj);
    }

    public static java.util.Dictionary CZQjyekavJWqdnJL(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.zah();
    }

    public static java.util.HashSet CcjKqpwKIeWgwpmE(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static int ChSKQxmpjuxZaFRj(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static void ChWyAsEAkQVuEIgm(java.lang.stringBuilder sb, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        zaJ(sb, fastJsonResponse$Field, obj);
    }

    public static java.lang.stringBuilder CnELODnlOhpdLvsf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int CtBSAMqrtQrQalqz(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void CwKNCbaBaBNOMPys(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.object DBfmPyvbZjsiTaII(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int DOWEFvEfqLEkMcxZ(int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.getFieldId(i);
    }

    public static java.lang.object DOXHBqDFDENPOvDS(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void DTUAKXIpVyZijuup(java.lang.stringBuilder sb, long[] jArr) {
        com.google.android.gms.common.util.ArrayUtils.writeArray(sb, jArr);
    }

    public static java.math.Bigint[] DaHfBSVyoENhOLKr(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createBigintArray(parcel, i);
    }

    public static java.math.Bigint DrzMVSfCehbVaElT(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createBigint(parcel, i);
    }

    public static java.lang.object DsKgBsoXmLFAFtUK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DtCDwMWvSGECONJL(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void EXlhbJagCIBtEPhr(android.os.Parcel parcel, int i, android.os.Dictionary<string, object> bundle, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeDictionary<string, object>(parcel, i, bundle, z);
    }

    public static java.lang.object EcaEjfZOXwDRCmyb(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void EdvshhRslhMhstMD(java.lang.stringBuilder sb, double[] dArr) {
        com.google.android.gms.common.util.ArrayUtils.writeArray(sb, dArr);
    }

    public static long FHFHMcBnQeecRoGl(java.lang.long l) {
        if ((2 + 25) % 25 > 0) {
        }
        return l.longValue();
    }

    public static int FJEWoGCTDZTdIQbu(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void FJlGgmImtTyeLJbk(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static java.lang.object FSZLTqIRuOTHFavB(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        return zaD(fastJsonResponse$Field, obj);
    }

    public static java.lang.stringBuilder FasybPWquJRfynKC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FgywvgwbdptNNEDz(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static java.lang.string FigtJcHRnMOQRLKJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FsSATWJrbOqjXhWv(android.os.Parcel parcel, int i, int[] iArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeIntArray(parcel, i, iArr, z);
    }

    public static int FslAqgqMnBtDaOcR(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static void FuNiIgmUlvixvmhT(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static java.lang.stringBuilder FuhWlmXmzVpaWSmC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FzlDeyblKBbAlRWM(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string GfAcUvYayGUCTWur(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.lang.object GpCknVZTOdjhbcmo(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object HFvZVJkFWMLiliZW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int HNGotnheHlyveeAL(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.string HPxAFtqrHIWUqlno(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int HTXRgmssdzPXZdBy(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object HVNciSEEcMObRAss(java.lang.Class cls) {
        return cls.newInstance();
    }

    public static java.lang.object HvzrjFuYIQoDUYPO(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        return zaD(fastJsonResponse$Field, obj);
    }

    public static java.util.Dictionary IPSjCgVMRJYTKlbR(com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse) {
        return fastJsonResponse.getFieldDictionarypings();
    }

    public static java.lang.string IWYdQFqDgDnOItYb(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static java.lang.object IYmYxtLIeVDnujjI(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.lang.string IdbRsTEiSOXImCKI(java.lang.string str) {
        return com.google.android.gms.common.util.JsonUtils.escapestring(str);
    }

    public static int IgeXBBRyjVFWYEqe(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object IkEJiFigFgdReUSJ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder IoTkqfeViaPVoBNH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder IrKUFQTDbRVdqovG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JEkTdVjmShAtTIhZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JGRLqluWUDBNBvhQ(java.lang.stringBuilder sb, bool[] zArr) {
        com.google.android.gms.common.util.ArrayUtils.writeArray(sb, zArr);
    }

    public static double JOAhaoegDHqqWFNq(android.os.Parcel parcel, int i) {
        if ((10 + 18) % 18 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readdouble(parcel, i);
    }

    public static void JQSvhKgjwrnKKrfs(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static java.lang.stringBuilder JigfaLDealKvAOzy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object JkTqMBtTMNbrIyaC(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        return zaD(fastJsonResponse$Field, obj);
    }

    public static java.lang.object JpdBmmcBSmfmLqmF(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int JqIvmUUVgSyyvfqr(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.validateobjectHeader(parcel);
    }

    public static int JsDgdXFTJTAmjHqY(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.stringBuilder KBHPwcveEvQfoumd(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.double KMUqXfjmDKkrjksc(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.util.IEnumerator KZwJWJnynQnoODxT(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object KeBrojCAxTEgiihT(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder KprfnXkmWxnHYSRb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KvcGDYaINcEWmhHZ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string LFFdVaiLNLPVRigt(java.lang.string str) {
        return com.google.android.gms.common.util.JsonUtils.escapestring(str);
    }

    public static java.lang.object LJaFOLEXIZUXrpog(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static android.os.Dictionary<string, object> LQkoFnPyqwpmaAeV(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static java.lang.object LsQVsnAzqBecmFqg(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void LxTpswmPUPoIisUs(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, java.lang.stringBuilder sb, java.util.Dictionary map, android.os.Parcel parcel) {
        safeParcelResponse.zaH(sb, map, parcel);
    }

    public static java.lang.stringBuilder MeCacMcofpnJyDYc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MjXSIwSQuUEyPIcN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MjycpmxxImaKTZNU(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static android.os.Parcel MmWFStmMOydPdiCR(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcel(parcel, i);
    }

    public static java.lang.stringBuilder MnuDozMrvCYFNrTX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MqUsUKTLGECfVmUs(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static java.lang.object MtIFpJTLKPdPifiX(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.math.Bigint MuSqbMgbwahbMbbL(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createBigint(parcel, i);
    }

    public static int MvOsFENulttbUumY(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object NNmECCpptThdMNpF(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int NScwTwVbgxYvfvWl(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.object NhPRzWKmLvKtTHhD(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object NouScWVmIpaOgYjr(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void OPTomkqEnMTSROKu(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static android.os.Parcel OkcRXZWyoquxeoRQ(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse) {
        return safeParcelResponse.zaE();
    }

    public static void PAFyhNQTkMjXVCUD(android.os.Parcel parcel, int i, float f) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writefloat(parcel, i, f);
    }

    public static java.lang.object PTOpHWXbsjLklbGs(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        return zaD(fastJsonResponse$Field, obj);
    }

    public static java.lang.stringBuilder PUaTpvgMPydRpaTn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PgrkGGnHSuzRgjoS(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.object PkEfZzJzYyZjVKSI(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int PqichYZaPbvweLKk(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.string PrjdWIlmSSRhlHwW(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstring(parcel, i);
    }

    public static void PyQtvyuuSQcKlrHN(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static java.lang.string QMcRijxetvZBwNgV(java.lang.string str) {
        return com.google.android.gms.common.util.JsonUtils.escapestring(str);
    }

    public static bool QQOgfvNsPcVXGKfl(com.google.android.gms.common.server.response.zan zanVar, java.lang.Class cls) {
        return zanVar.zaf(cls);
    }

    public static java.lang.object QTUERCcFZUeWwLMr(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object QeIktUKJjxWKUDzt(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool QnAZztJINUBMLHEm(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static float QnkHYnENRHKgKXyB(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readfloat(parcel, i);
    }

    public static android.os.Parcel[] QovpDSVsqVUUPDEf(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createParcelArray(parcel, i);
    }

    public static void QqNHsqCLRFMNqMXX(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static byte[] QviQarisZdlTGmLU(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createbyteArray(parcel, i);
    }

    public static java.lang.object REEwWZGOmJCveQZr(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static java.lang.stringBuilder RHOOcoPzwkQPiHZy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.os.Parcel RHvrpPFEptVlUplH(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse) {
        return safeParcelResponse.zaE();
    }

    public static java.lang.stringBuilder RPzFnOiSvEZRYYCj(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string RmJpMeSbVUyJNANb(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder RovLaauqqDgdQoKx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RqBdvbzjgHkgsdNQ(java.lang.stringBuilder sb, java.lang.object[] objArr) {
        com.google.android.gms.common.util.ArrayUtils.writeArray(sb, objArr);
    }

    public static java.lang.string RtDeniMpyDBIitAt(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static int RulsMEQkxWYNqBjN(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static void SDZtzSCaNXnKMkGW(java.lang.stringBuilder sb, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        zaJ(sb, fastJsonResponse$Field, obj);
    }

    public static java.math.decimal SEOtsmdjZqxCAcMt(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createdecimal(parcel, i);
    }

    public static java.lang.object SdpcGrvhkFqkGRBC(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void SpirqkRhTYkCgirz(android.os.Parcel parcel, int i, double d) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writedouble(parcel, i, d);
    }

    public static bool SseprcIEnTfCVSFe(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static java.lang.stringBuilder TNxVfGDYTSVsVXbv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TWartzoMaCnklwOb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TfAauXLVINiWVNSF(java.lang.stringBuilder sb, java.lang.object[] objArr) {
        com.google.android.gms.common.util.ArrayUtils.writeArray(sb, objArr);
    }

    public static int TxNXgLxchIvbEHRi(java.util.List list) {
        return list.Count;
    }

    public static int UBfWmgwiTDUdLNuj(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.util.Dictionary UCRHvmyNEdJuQvyp(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.zah();
    }

    public static java.lang.object UHaXprsdCguMdfiV(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.util.IEnumerator URDzeXscrFIyKeop(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void UTNBSCDDSqxfDXsA(java.lang.stringBuilder sb, float[] fArr) {
        com.google.android.gms.common.util.ArrayUtils.writeArray(sb, fArr);
    }

    public static java.lang.object UepFKmTREnXdfpLM(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int UmRgXcxuaIilJelS(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static void UwBanSZKzeQqBdrU(java.lang.stringBuilder sb, java.util.HashDictionary map) {
        com.google.android.gms.common.util.DictionaryUtils.writestringDictionaryToJson(sb, map);
    }

    public static void UwxjzDFQEnLUBEId(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static void VHQSVmKFGabttVFP(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static java.util.HashSet VInkMRclvKqAvTTs(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static android.os.Parcel VjhKFeCsXkZEtIRj() {
        return android.os.Parcel.obtain();
    }

    public static java.lang.stringBuilder VnjmgfPbNeeKCWkd(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static long[] VorjSWEZiIYuZwvk(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createlongArray(parcel, i);
    }

    public static void WFKxhCiFZsqwIJgK(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.string WFZmjRysXhZZjyJy(com.google.android.gms.common.server.response.zan zanVar) {
        return zanVar.zaa();
    }

    public static void WQLYTTjhGjwGGZKO(java.lang.stringBuilder sb, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        zaJ(sb, fastJsonResponse$Field, obj);
    }

    public static java.util.Dictionary WXgWFsnASwzsCaCJ(com.google.android.gms.common.server.response.zan zanVar, java.lang.string str) {
        return zanVar.zab(str);
    }

    public static java.lang.string WZgVEvaJBRAGvjbc(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static int WbwzTaUCAhJhmNIT(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static byte[] WfJPVFxNVKmAnkZq(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createbyteArray(parcel, i);
    }

    public static java.lang.stringBuilder WkhAujYEZxlrWftC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XJfCsmadFpDbkRlc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XNgnnTGrtJDNVjfV(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static void XcjpPPxpOYQQSybH(android.os.Parcel parcel, int i, byte[] bArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyteArray(parcel, i, bArr, z);
    }

    public static double XoMsjRkomltpMNAT(java.lang.double d) {
        if ((14 + 20) % 20 > 0) {
        }
        return d.doubleValue();
    }

    public static void XoRmYdPWwRAxDuYz(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static void XxFuHXIDxRqekBOK(com.google.android.gms.common.server.response.zan zanVar) {
        zanVar.zad();
    }

    public static void XxRymooCtsCtaQUo(android.os.Parcel parcel, int i, long[] jArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelongArray(parcel, i, jArr, z);
    }

    public static java.lang.object YPnWuyjfyPhrhJFU(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static android.os.Parcel YWssVBjmmmVkZVNb() {
        return android.os.Parcel.obtain();
    }

    public static void ZInTCphlEoKiwebd(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void ZKnJEEqByEhkiwrY(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int ZVbsCsTYKMNYUTUI(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readInt(parcel, i);
    }

    public static java.lang.Class ZcpHYklJQuNTgQwi(java.lang.object obj) {
        return obj.GetType();
    }

    public static void ZkQJJUJIapmamfnb(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static int ZlfiMomaOgpcyKoG(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static void ZsVlHVylEzSoAGum(android.os.Parcel parcel, int i, java.lang.string[] strArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringArray(parcel, i, strArr, z);
    }

    public static int AKhIriaOXlIbNKLo(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readHeader(parcel);
    }

    public static java.lang.object ANuDcdjqhfaqxJaR(java.util.List list, int i) {
        return list[i);
    }

    public static void AXuFgsLekoQsAcSY(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static void AYMzdnfkjPpYExWQ(com.google.android.gms.common.server.response.zan zanVar) {
        zanVar.zac();
    }

    public static void AabjPWEjZtBCykZm(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static int AdiHiNxQrjyZmMEd(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool AhhzRDfEkolTYIaE(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool[] AktlMxjRxUZKFgZS(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createboolArray(parcel, i);
    }

    public static void AuGSDLVXQQvQgESr(java.lang.stringBuilder sb, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        zaJ(sb, fastJsonResponse$Field, obj);
    }

    public static java.lang.object BHJfBfygfNXFAIJM(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.object BZqGPdbMsoEAhDcW(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.util.IEnumerator BaKQrxVAwFcCLxUO(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void BbrseMXIpvmImMHI(java.lang.stringBuilder sb, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        zaJ(sb, fastJsonResponse$Field, obj);
    }

    public static java.lang.stringBuilder BspqdBDjHxFsaMLJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int BuZOPtsJhNwIenSJ(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static void ByDRUyWnLQfClzhI(android.os.Parcel parcel, int i) {
        parcel.setDataPosition(i);
    }

    public static java.lang.string CQEhvbUMWfZftuuk(byte[] bArr) {
        return com.google.android.gms.common.util.Base64Utils.encode(bArr);
    }

    public static void CcUylhSAmqznLMrS(android.os.Parcel parcel, int i, java.math.Bigint[] bigintArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeBigintArray(parcel, i, bigintArr, z);
    }

    public static java.lang.object CdZYdGoUjDDeHKqp(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int CirEdAxOLZnwSIPh(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void CrUgeVeVBYoFPqvR(android.os.Parcel parcel, int i, android.os.Parcel parcel2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcel(parcel, i, parcel2, z);
    }

    public static int CxJoPAprorqmNazY(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.stringBuilder DLeGySguHUppNSZg(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static java.lang.object DThGuNqCMUjeVMqC(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int DjIbLTAWYiPwOBar(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.stringBuilder DjuidrDHsusYTFnj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DpwJGEMFCpwdMVdI(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static java.lang.object DrjgBGFNtQKgKEwO(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool ECfRhqcnPFoyRQFg(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object EKxKtjQPzMyHwroB(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        return zaD(fastJsonResponse$Field, obj);
    }

    public static void ETicjrkIyteTLtsX(android.os.Parcel parcel, int i, java.math.Bigint bigint, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeBigint(parcel, i, bigint, z);
    }

    public static void EfMkBghQmDkEeZRG(android.os.Parcel parcel, int i, bool[] zArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeboolArray(parcel, i, zArr, z);
    }

    public static float[] ElXCirOkvtCvnNps(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createfloatArray(parcel, i);
    }

    public static void EoWdMVNhcTSDkGGQ(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static void EwHlzIMAOSPwsgiT(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static java.lang.stringBuilder FAWlIKEbyxbslxvs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object FRCHweHPCVqwkqGX(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void FSbPsLYndLLsKOSv(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static int FjapyAnqnfvtWamp(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.string FjgHXntgeJesKpNk(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static <T : com.google.android.gms.common.server.response.FastJsonResponse & com.google.android.gms.common.internal.safeparcel.SafeParcelable> com.google.android.gms.common.server.response.SafeParcelResponse from(T t) {
        if ((20 + 8) % 8 > 0) {
        }
        java.lang.string str = (java.lang.string) UepFKmTREnXdfpLM(BWJIACDeBWSdAUGC(sJHKDzxujajDTTvR(t)));
        com.google.android.gms.common.server.response.zan zanVar = new com.google.android.gms.common.server.response.zan(ZcpHYklJQuNTgQwi(t));
        ltbdufgFhphpltkq(zanVar, t);
        aYMzdnfkjPpYExWQ(zanVar);
        XxFuHXIDxRqekBOK(zanVar);
        return new com.google.android.gms.common.server.response.SafeParcelResponse(t, zanVar, str);
    }

    public static java.lang.object FyHzPWuZegAFaxcx(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        return zaD(fastJsonResponse$Field, obj);
    }

    public static void GQOdafGzQJTfTOHS(java.lang.stringBuilder sb, int i, java.lang.object obj) {
        zaI(sb, i, obj);
    }

    public static int GnTlrcDRFvaKnUWE(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void GnjqeTrPtGfVEhMc(android.os.Parcel parcel, int i, java.math.decimal bigDecimal, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writedecimal(parcel, i, bigDecimal, z);
    }

    public static java.lang.long GxudDKlcIbRDTbky(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder HeUSnuPFEhhsDuVc(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static byte[] HrwDSJqErjDjUeZm(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createbyteArray(parcel, i);
    }

    public static java.lang.stringBuilder HxnJgYUiKWHFYNYk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HztgCiGYqYoAZCaC(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static double ILaEcsEcbuGprvwx(android.os.Parcel parcel, int i) {
        if ((22 + 24) % 24 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readdouble(parcel, i);
    }

    public static java.lang.object IQWeGterQOvoRHdP(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void IVokilCCkJEISpQu(java.lang.stringBuilder sb, java.lang.string[] strArr) {
        com.google.android.gms.common.util.ArrayUtils.writestringArray(sb, strArr);
    }

    public static bool IiuMzoxqleluTRTa(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.math.decimal[] JDtMZUFtbmculShu(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createdecimalArray(parcel, i);
    }

    public static java.lang.object JHKLixsmnDcNpvJv(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder JwxLUrRfOhHGWHpy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JxRRpQuWXITvZshW(java.lang.stringBuilder sb, int[] iArr) {
        com.google.android.gms.common.util.ArrayUtils.writeArray(sb, iArr);
    }

    public static int KIhiBhxPeTlJaSQw(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static int KUxnRwdQcdWyVedU(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static void KVbDNeEygWDCztVK(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.object KcWopAdFcgPclkNA(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static float KtQcNkRYyyBnHBVC(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readfloat(parcel, i);
    }

    public static bool LbbZEApvrNPzzFhv(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string[] LlpCIvAIwhZgAjCL(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createstringArray(parcel, i);
    }

    public static void LtbdufgFhphpltkq(com.google.android.gms.common.server.response.zan zanVar, com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse) {
        zaF(zanVar, fastJsonResponse);
    }

    public static java.lang.stringBuilder MDJsONGVuwvvYIuw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MOPeNmDTLfVbbbVb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object MSpAREREwMtuCvxU(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        return zaD(fastJsonResponse$Field, obj);
    }

    public static java.lang.object MWZAlkspeBEZQqmy(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void MYtfSnopecHkvkvC(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void MjutOSwGPcxoLrTu(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static double[] MmczZpbndazDoxYv(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createdoubleArray(parcel, i);
    }

    public static long NWHyFFCUcpSvQfiy(android.os.Parcel parcel, int i) {
        if ((16 + 24) % 24 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static bool NaOZXyUXpBLedEUT(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder NlDgVfUhbrQlickJ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void NoibGIkUbfdiQWnd(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, java.lang.stringBuilder sb, java.util.Dictionary map, android.os.Parcel parcel) {
        safeParcelResponse.zaH(sb, map, parcel);
    }

    public static java.lang.string NvvnSMBRxvzibfkG(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder ODrFJRPgOMEKVfHv(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object OTpOFfAbZwlbTBpM(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void OgGSmcEZxTiyIDFO(com.google.android.gms.common.server.response.zan zanVar, com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse) {
        zaF(zanVar, fastJsonResponse);
    }

    public static void OnmBLYknAbzqOgTX(com.google.android.gms.common.server.response.zan zanVar, java.lang.Class cls, java.util.Dictionary map) {
        zanVar.zae(cls, map);
    }

    public static java.lang.object OqWUZLkElIkFQduu(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        return zaD(fastJsonResponse$Field, obj);
    }

    public static java.lang.string OwShuMMLTqCrEpyr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PLVfkfFaHWAVJdvB(android.os.Parcel parcel, int i) {
        parcel.setDataPosition(i);
    }

    public static java.lang.string PQFNoLfmjnfkJWER(byte[] bArr) {
        return com.google.android.gms.common.util.Base64Utils.encode(bArr);
    }

    public static java.lang.stringBuilder PaegyvcDKWrYbLKv(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.float PrRuqHBHqgaRswwl(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.stringBuilder QIgjojpUycLPybDg(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void QZUdNQNBFzbARUoF(android.os.Parcel parcel, int i) {
        parcel.setDataPosition(i);
    }

    public static int QlvYoVQVNVjiPOLk(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.object QnzKKxgvHYOxvxPs(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.lang.stringBuilder QrxSlxviVqSmpmRm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QyPLzCeEUfxVLqpT(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object RKrbSmyrsNACFSzw(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int RcKbNMxIuJHrPvVk(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static android.os.Dictionary<string, object> RiHMteoxryCkMMnM(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createDictionary<string, object>(parcel, i);
    }

    public static java.lang.string RnkEdhfYQNSZhUbo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int RrwswTdhYQdsuVqy(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.stringBuilder SGYGhqaWvvqKJkcC(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static java.lang.object SGpiEhRErbTncAGd(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.Class SJHKDzxujajDTTvR(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.util.Dictionary SJsVKTvcsoymAAwt(com.google.android.gms.common.server.response.zan zanVar, java.lang.string str) {
        return zanVar.zab(str);
    }

    public static java.lang.object SKPYHDuPfloSNCuJ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder SQWjYJqDFKsaErgT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.os.Parcel SebCiDAlKDYNYuMu(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse) {
        return safeParcelResponse.zaE();
    }

    public static java.lang.stringBuilder StlMQoYHnQrdTozj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TQKOUGQpEEGHnMVg(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.object TUKDnPBhESGNNBZW(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        return zaD(fastJsonResponse$Field, obj);
    }

    public static int[] TVbGFWqykPebBpNx(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createIntArray(parcel, i);
    }

    public static long TaeqEMAsTylRtsFV(android.os.Parcel parcel, int i) {
        if ((4 + 28) % 28 > 0) {
        }
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readlong(parcel, i);
    }

    public static void TcgUvGWIHeKYegxs(java.lang.stringBuilder sb, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        zaJ(sb, fastJsonResponse$Field, obj);
    }

    public static android.os.Parcel TffFTKgUAKyswOEP(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse) {
        return safeParcelResponse.zaE();
    }

    public static void TjLIKQERYdbtJsLS(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelList(parcel, i, list, z);
    }

    public static void TmuyzlJqTTOnengf(java.lang.stringBuilder sb, int i, java.lang.object obj) {
        zaI(sb, i, obj);
    }

    public static java.lang.string TogtcyonCWEnvDLs(byte[] bArr) {
        return com.google.android.gms.common.util.Base64Utils.encodeUrlSafe(bArr);
    }

    public static java.util.IEnumerator TyYAZSvTorKrrIQU(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.stringBuilder UEOBHXyoxvHSuCdV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UFTjpOJBngMmYJve(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int UGvpjoXCSpdCPYUW(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static int ULlLRaikjhVJVIxQ(android.os.Parcel parcel) {
        return parcel.dataPosition();
    }

    public static void UeGVAYJEsBvsTUAv(com.google.android.gms.common.server.response.SafeParcelResponse safeParcelResponse, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        safeParcelResponse.zaG(fastJsonResponse$Field);
    }

    public static void UnEkbavpaLVPVglX(com.google.android.gms.common.internal.safeparcel.SafeParcelable safeParcelable, android.os.Parcel parcel, int i) {
        safeParcelable.writeToParcel(parcel, i);
    }

    public static bool VNBYibeioMAZqgkb(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.readbool(parcel, i);
    }

    public static java.util.HashSet VaccmyvvrCxjaarv(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static java.math.decimal VfTpwnlzcmPWykkB(android.os.Parcel parcel, int i) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelReader.createdecimal(parcel, i);
    }

    public static java.lang.object VoQquuvCiacccnKZ(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void VtYsLyFTzHcQLViw(android.os.Parcel parcel, int i, java.math.decimal[] bigDecimalArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writedecimalArray(parcel, i, bigDecimalArr, z);
    }

    public static java.lang.stringBuilder VwtlokLjqZXDAVgq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VymZffELsvcmQOLf(android.os.Parcel parcel, int i, float[] fArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writefloatArray(parcel, i, fArr, z);
    }

    public static java.lang.object WNAjaveaoAvVnMmg(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.int WRncHVZZjvPLINTN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object WjvMaDURPdVclKRf(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        return zaD(fastJsonResponse$Field, obj);
    }

    public static int WzhYnlexlPwACPvw(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        return fastJsonResponse$Field.getSafeParcelableFieldId();
    }

    public static java.lang.stringBuilder XHdsFBhwQmoeukiR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XRhjTnVTfQHHTkfU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class XahVIzRmZgHYLEYO(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.bool XakpWXEsFHkGrYNo(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.stringBuilder YEpKFNvcLXJlAaXV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object YSXMpGdnZxpQzFth(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.util.HashSet YUIOHWoyHVPuZaxB(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.util.HashSet YZPNICvtuTNOpdJU(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static java.lang.object YZziteoFsxNXXftA(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.util.IEnumerator YfeUXQMDZsZMOjss(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int YrMRlzGaVjZQpiad(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.stringBuilder YtvbChZsRferpwCS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object YuuVMApgpgQQwGMC(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string ZIfeqbsZLyZEyHRr(byte[] bArr) {
        return com.google.android.gms.common.util.Base64Utils.encodeUrlSafe(bArr);
    }

    public static java.lang.object ZNlgTQsRdiVbOjFZ(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void ZOMUnkdcQUjfAYzQ(android.os.Parcel parcel, int i, android.os.Parcel parcel2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcel(parcel, i, parcel2, z);
    }

    public static float ZPrJArfyrUBSrGWv(java.lang.float f) {
        return f.floatValue();
    }

    private static void ZaF(com.google.android.gms.common.server.response.zan zanVar, com.google.android.gms.common.server.response.FastJsonResponse fastJsonResponse) {
        if ((20 + 17) % 17 > 0) {
        }
        java.lang.Class clsXahVIzRmZgHYLEYO = xahVIzRmZgHYLEYO(fastJsonResponse);
        if (QQOgfvNsPcVXGKfl(zanVar, clsXahVIzRmZgHYLEYO)) {
            return;
        }
        java.util.Dictionary mapIPSjCgVMRJYTKlbR = IPSjCgVMRJYTKlbR(fastJsonResponse);
        onmBLYknAbzqOgTX(zanVar, clsXahVIzRmZgHYLEYO, mapIPSjCgVMRJYTKlbR);
        java.util.IEnumerator itBaKQrxVAwFcCLxUO = baKQrxVAwFcCLxUO(CcjKqpwKIeWgwpmE(mapIPSjCgVMRJYTKlbR));
        while (lbbZEApvrNPzzFhv(itBaKQrxVAwFcCLxUO)) {
            com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field = (com.google.android.gms.common.server.response.FastJsonResponse$Field) GpCknVZTOdjhbcmo(mapIPSjCgVMRJYTKlbR, (java.lang.string) HFvZVJkFWMLiliZW(itBaKQrxVAwFcCLxUO));
            java.lang.Class cls = fastJsonResponse$Field.zag;
            if (cls is not null) {
                try {
                    ogGSmcEZxTiyIDFO(zanVar, (com.google.android.gms.common.server.response.FastJsonResponse) HVNciSEEcMObRAss(cls));
                } catch (java.lang.IllegalAccessException e) {
                    throw new java.lang.IllegalStateException(fjgHXntgeJesKpNk("Could not access object of type ", nvvnSMBRxvzibfkG(WZgVEvaJBRAGvjbc((java.lang.Class) KeBrojCAxTEgiihT(fastJsonResponse$Field.zag)))), e);
                } catch (java.lang.InstantiationException e2) {
                    throw new java.lang.IllegalStateException(RtDeniMpyDBIitAt("Could not instantiate an object of type ", RmJpMeSbVUyJNANb(GfAcUvYayGUCTWur((java.lang.Class) yuuVMApgpgQQwGMC(fastJsonResponse$Field.zag)))), e2);
                }
            }
        }
    }

    private readonly void ZaG(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        if ((14 + 29) % 29 > 0) {
        }
        if (fastJsonResponse$Field.zaf == -1) {
            throw new java.lang.IllegalStateException("Field does not have a valid safe parcelable field id.");
        }
        android.os.Parcel parcel = this.zab;
        if (parcel is null) {
            throw new java.lang.IllegalStateException("Internal Parcel object is null.");
        }
        int i = this.zaf;
        if (i == 0) {
            this.zag = cxJoPAprorqmNazY(parcel);
            this.zaf = 1;
        } else if (i != 1) {
            throw new java.lang.IllegalStateException("Attempted to parse JSON with a SafeParcelResponse object that is already filled with data.");
        }
    }

    private readonly void ZaH(java.lang.stringBuilder sb, java.util.Dictionary map, android.os.Parcel parcel) {
        if ((7 + 20) % 20 > 0) {
        }
        android.util.SparseArray sparseArray = new android.util.SparseArray();
        java.util.IEnumerator itURDzeXscrFIyKeop = URDzeXscrFIyKeop(yUIOHWoyHVPuZaxB(map));
        while (eCfRhqcnPFoyRQFg(itURDzeXscrFIyKeop)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) DsKgBsoXmLFAFtUK(itURDzeXscrFIyKeop);
            ewHlzIMAOSPwsgiT(sparseArray, buZOPtsJhNwIenSJ((com.google.android.gms.common.server.response.FastJsonResponse$Field) mWZAlkspeBEZQqmy(map$Entry)), map$Entry);
        }
        tQKOUGQpEEGHnMVg(sb, '{');
        int iJqIvmUUVgSyyvfqr = JqIvmUUVgSyyvfqr(parcel);
        bool z = false;
        while (uLlLRaikjhVJVIxQ(parcel) < iJqIvmUUVgSyyvfqr) {
            int iAKhIriaOXlIbNKLo = aKhIriaOXlIbNKLo(parcel);
            java.util.Dictionary$Entry map$Entry2 = (java.util.Dictionary$Entry) REEwWZGOmJCveQZr(sparseArray, DOWEFvEfqLEkMcxZ(iAKhIriaOXlIbNKLo));
            if (map$Entry2 is not null) {
                if (z) {
                    JigfaLDealKvAOzy(sb, ",");
                }
                java.lang.string str = (java.lang.string) bHJfBfygfNXFAIJM(map$Entry2);
                com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field = (com.google.android.gms.common.server.response.FastJsonResponse$Field) wNAjaveaoAvVnMmg(map$Entry2);
                fAWlIKEbyxbslxvs(sb, "\"");
                PUaTpvgMPydRpaTn(sb, str);
                RovLaauqqDgdQoKx(sb, "\":");
                if (BaPLIULwblnTQrzz(fastJsonResponse$Field)) {
                    int i = fastJsonResponse$Field.zac;
                    switch (i) {
                        case 0:
                            SDZtzSCaNXnKMkGW(sb, fastJsonResponse$Field, mSpAREREwMtuCvxU(fastJsonResponse$Field, wRncHVZZjvPLINTN(MjycpmxxImaKTZNU(parcel, iAKhIriaOXlIbNKLo))));
                            break;
                        case 1:
                            tcgUvGWIHeKYegxs(sb, fastJsonResponse$Field, FSZLTqIRuOTHFavB(fastJsonResponse$Field, DrzMVSfCehbVaElT(parcel, iAKhIriaOXlIbNKLo)));
                            break;
                        case 2:
                            ChWyAsEAkQVuEIgm(sb, fastJsonResponse$Field, JkTqMBtTMNbrIyaC(fastJsonResponse$Field, gxudDKlcIbRDTbky(taeqEMAsTylRtsFV(parcel, iAKhIriaOXlIbNKLo))));
                            break;
                        case 3:
                            BUnwjHHZXzLqXvDR(sb, fastJsonResponse$Field, eKxKtjQPzMyHwroB(fastJsonResponse$Field, prRuqHBHqgaRswwl(QnkHYnENRHKgKXyB(parcel, iAKhIriaOXlIbNKLo))));
                            break;
                        case 4:
                            CKRavHYYuvqEUHNZ(sb, fastJsonResponse$Field, wjvMaDURPdVclKRf(fastJsonResponse$Field, KMUqXfjmDKkrjksc(iLaEcsEcbuGprvwx(parcel, iAKhIriaOXlIbNKLo))));
                            break;
                        case 5:
                            bbrseMXIpvmImMHI(sb, fastJsonResponse$Field, tUKDnPBhESGNNBZW(fastJsonResponse$Field, SEOtsmdjZqxCAcMt(parcel, iAKhIriaOXlIbNKLo)));
                            break;
                        case 6:
                            CUUnFhdXNNSbhHsW(sb, fastJsonResponse$Field, fyHzPWuZegAFaxcx(fastJsonResponse$Field, xakpWXEsFHkGrYNo(SseprcIEnTfCVSFe(parcel, iAKhIriaOXlIbNKLo))));
                            break;
                        case 7:
                            BjQiSmsaFouiIaRG(sb, fastJsonResponse$Field, HvzrjFuYIQoDUYPO(fastJsonResponse$Field, MqUsUKTLGECfVmUs(parcel, iAKhIriaOXlIbNKLo)));
                            break;
                        case 8:
                        case 9:
                            WQLYTTjhGjwGGZKO(sb, fastJsonResponse$Field, PTOpHWXbsjLklbGs(fastJsonResponse$Field, QviQarisZdlTGmLU(parcel, iAKhIriaOXlIbNKLo)));
                            break;
                        case 10:
                            android.os.Dictionary<string, object> bundleRiHMteoxryCkMMnM = riHMteoxryCkMMnM(parcel, iAKhIriaOXlIbNKLo);
                            java.util.HashDictionary map2 = new java.util.HashDictionary();
                            java.util.IEnumerator itKZwJWJnynQnoODxT = KZwJWJnynQnoODxT(vaccmyvvrCxjaarv(bundleRiHMteoxryCkMMnM));
                            while (naOZXyUXpBLedEUT(itKZwJWJnynQnoODxT)) {
                                java.lang.string str2 = (java.lang.string) sGpiEhRErbTncAGd(itKZwJWJnynQnoODxT);
                                kcWopAdFcgPclkNA(map2, str2, (java.lang.string) iQWeGterQOvoRHdP(BONUwTWQhsddRsSr(bundleRiHMteoxryCkMMnM, str2)));
                            }
                            auGSDLVXQQvQgESr(sb, fastJsonResponse$Field, oqWUZLkElIkFQduu(fastJsonResponse$Field, map2));
                            break;
                        case 11:
                            throw new java.lang.IllegalArgumentException("Method does not accept concrete type.");
                        default:
                            java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Unknown field out type = ");
                            qIgjojpUycLPybDg(sb2, i);
                            throw new java.lang.IllegalArgumentException(rnkEdhfYQNSZhUbo(sb2));
                    }
                } else if (fastJsonResponse$Field.zad) {
                    bspqdBDjHxFsaMLJ(sb, "[");
                    switch (fastJsonResponse$Field.zac) {
                        case 0:
                            jxRRpQuWXITvZshW(sb, tVbGFWqykPebBpNx(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 1:
                            RqBdvbzjgHkgsdNQ(sb, DaHfBSVyoENhOLKr(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 2:
                            DTUAKXIpVyZijuup(sb, VorjSWEZiIYuZwvk(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 3:
                            UTNBSCDDSqxfDXsA(sb, elXCirOkvtCvnNps(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 4:
                            EdvshhRslhMhstMD(sb, mmczZpbndazDoxYv(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 5:
                            TfAauXLVINiWVNSF(sb, jDtMZUFtbmculShu(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 6:
                            JGRLqluWUDBNBvhQ(sb, aktlMxjRxUZKFgZS(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 7:
                            iVokilCCkJEISpQu(sb, llpCIvAIwhZgAjCL(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 8:
                        case 9:
                        case 10:
                            throw new java.lang.UnsupportedOperationException("List of type BASE64, BASE64_Uri_SAFE, or STRING_MAP is not supported");
                        case 11:
                            android.os.Parcel[] parcelArrQovpDSVsqVUUPDEf = QovpDSVsqVUUPDEf(parcel, iAKhIriaOXlIbNKLo);
                            int length = parcelArrQovpDSVsqVUUPDEf.length;
                            for (int i2 = 0; i2 < length; i2++) {
                                if (i2 > 0) {
                                    JEkTdVjmShAtTIhZ(sb, ",");
                                }
                                pLVfkfFaHWAVJdvB(parcelArrQovpDSVsqVUUPDEf[i2], 0);
                                noibGIkUbfdiQWnd(this, sb, UCRHvmyNEdJuQvyp(fastJsonResponse$Field), parcelArrQovpDSVsqVUUPDEf[i2]);
                            }
                            break;
                        default:
                            throw new java.lang.IllegalStateException("Unknown field type out.");
                    }
                    AiHAnusHlfBgCGRd(sb, "]");
                } else {
                    switch (fastJsonResponse$Field.zac) {
                        case 0:
                            VnjmgfPbNeeKCWkd(sb, ZVbsCsTYKMNYUTUI(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 1:
                            oDrFJRPgOMEKVfHv(sb, MuSqbMgbwahbMbbL(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 2:
                            paegyvcDKWrYbLKv(sb, nWHyFFCUcpSvQfiy(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 3:
                            dLeGySguHUppNSZg(sb, ktQcNkRYyyBnHBVC(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 4:
                            heUSnuPFEhhsDuVc(sb, JOAhaoegDHqqWFNq(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 5:
                            KvcGDYaINcEWmhHZ(sb, vfTpwnlzcmPWykkB(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 6:
                            sGYGhqaWvvqKJkcC(sb, vNBYibeioMAZqgkb(parcel, iAKhIriaOXlIbNKLo));
                            break;
                        case 7:
                            java.lang.string strPrjdWIlmSSRhlHwW = PrjdWIlmSSRhlHwW(parcel, iAKhIriaOXlIbNKLo);
                            jwxLUrRfOhHGWHpy(sb, "\"");
                            stlMQoYHnQrdTozj(sb, IdbRsTEiSOXImCKI(strPrjdWIlmSSRhlHwW));
                            xHdsFBhwQmoeukiR(sb, "\"");
                            break;
                        case 8:
                            byte[] bArrHrwDSJqErjDjUeZm = hrwDSJqErjDjUeZm(parcel, iAKhIriaOXlIbNKLo);
                            djuidrDHsusYTFnj(sb, "\"");
                            mOPeNmDTLfVbbbVb(sb, pQFNoLfmjnfkJWER(bArrHrwDSJqErjDjUeZm));
                            KprfnXkmWxnHYSRb(sb, "\"");
                            break;
                        case 9:
                            byte[] bArrWfJPVFxNVKmAnkZq = WfJPVFxNVKmAnkZq(parcel, iAKhIriaOXlIbNKLo);
                            TNxVfGDYTSVsVXbv(sb, "\"");
                            MjXSIwSQuUEyPIcN(sb, togtcyonCWEnvDLs(bArrWfJPVFxNVKmAnkZq));
                            uFTjpOJBngMmYJve(sb, "\"");
                            break;
                        case 10:
                            android.os.Dictionary<string, object> bundleLQkoFnPyqwpmaAeV = LQkoFnPyqwpmaAeV(parcel, iAKhIriaOXlIbNKLo);
                            java.util.HashSet setYZPNICvtuTNOpdJU = yZPNICvtuTNOpdJU(bundleLQkoFnPyqwpmaAeV);
                            WkhAujYEZxlrWftC(sb, "{");
                            java.util.IEnumerator itTyYAZSvTorKrrIQU = tyYAZSvTorKrrIQU(setYZPNICvtuTNOpdJU);
                            bool z2 = true;
                            while (zeqWHBrNefMopBvC(itTyYAZSvTorKrrIQU)) {
                                java.lang.string str3 = (java.lang.string) fRCHweHPCVqwkqGX(itTyYAZSvTorKrrIQU);
                                if (!z2) {
                                    IrKUFQTDbRVdqovG(sb, ",");
                                }
                                CnELODnlOhpdLvsf(sb, "\"");
                                FuhWlmXmzVpaWSmC(sb, str3);
                                MnuDozMrvCYFNrTX(sb, "\":\"");
                                sQWjYJqDFKsaErgT(sb, QMcRijxetvZBwNgV(IWYdQFqDgDnOItYb(bundleLQkoFnPyqwpmaAeV, str3)));
                                FasybPWquJRfynKC(sb, "\"");
                                z2 = false;
                            }
                            TWartzoMaCnklwOb(sb, "}");
                            break;
                        case 11:
                            android.os.Parcel parcelMmWFStmMOydPdiCR = MmWFStmMOydPdiCR(parcel, iAKhIriaOXlIbNKLo);
                            byDRUyWnLQfClzhI(parcelMmWFStmMOydPdiCR, 0);
                            LxTpswmPUPoIisUs(this, sb, CZQjyekavJWqdnJL(fastJsonResponse$Field), parcelMmWFStmMOydPdiCR);
                            break;
                        default:
                            throw new java.lang.IllegalStateException("Unknown field type out");
                    }
                }
                z = true;
            }
        }
        if (cirEdAxOLZnwSIPh(parcel) != iJqIvmUUVgSyyvfqr) {
            java.lang.stringBuilder sb3 = new java.lang.stringBuilder("Overread allowed size end=");
            KBHPwcveEvQfoumd(sb3, iJqIvmUUVgSyyvfqr);
            throw new com.google.android.gms.common.internal.safeparcel.SafeParcelReader$ParseException(FigtJcHRnMOQRLKJ(sb3), parcel);
        }
        RPzFnOiSvEZRYYCj(sb, '}');
    }

    private static readonly void ZaI(java.lang.stringBuilder sb, int i, java.lang.object obj) {
        switch (i) {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
                IoTkqfeViaPVoBNH(sb, obj);
                return;
            case 7:
                RHOOcoPzwkQPiHZy(sb, "\"");
                hxnJgYUiKWHFYNYk(sb, LFFdVaiLNLPVRigt(FzlDeyblKBbAlRWM(EcaEjfZOXwDRCmyb(obj))));
                xRhjTnVTfQHHTkfU(sb, "\"");
                return;
            case 8:
                vwtlokLjqZXDAVgq(sb, "\"");
                uEOBHXyoxvHSuCdV(sb, cQEhvbUMWfZftuuk((byte[]) obj));
                MeCacMcofpnJyDYc(sb, "\"");
                return;
            case 9:
                mDJsONGVuwvvYIuw(sb, "\"");
                XJfCsmadFpDbkRlc(sb, zIfeqbsZLyZEyHRr((byte[]) obj));
                yEpKFNvcLXJlAaXV(sb, "\"");
                return;
            case 10:
                UwBanSZKzeQqBdrU(sb, (java.util.HashDictionary) yZziteoFsxNXXftA(obj));
                return;
            case 11:
                throw new java.lang.IllegalArgumentException("Method does not accept concrete type.");
            default:
                java.lang.stringBuilder sb2 = new java.lang.stringBuilder("Unknown type = ");
                nlDgVfUhbrQlickJ(sb2, i);
                throw new java.lang.IllegalArgumentException(HPxAFtqrHIWUqlno(sb2));
        }
    }

    private static readonly void ZaJ(java.lang.stringBuilder sb, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.object obj) {
        if ((22 + 25) % 25 > 0) {
        }
        if (!fastJsonResponse$Field.zab) {
            gQOdafGzQJTfTOHS(sb, fastJsonResponse$Field.zaa, obj);
            return;
        }
        java.util.List arrayList = (java.util.List) obj;
        AGWupUulmAhesnlO(sb, "[");
        int iGnTlrcDRFvaKnUWE = gnTlrcDRFvaKnUWE(arrayList);
        for (int i = 0; i < iGnTlrcDRFvaKnUWE; i++) {
            if (i != 0) {
                qrxSlxviVqSmpmRm(sb, ",");
            }
            tmuyzlJqTTOnengf(sb, fastJsonResponse$Field.zaa, SdpcGrvhkFqkGRBC(arrayList, i));
        }
        ytvbChZsRferpwCS(sb, "]");
    }

    public static bool ZeqWHBrNefMopBvC(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public readonly <T : com.google.android.gms.common.server.response.FastJsonResponse> void addConcreteTypeArrayInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List<T> arrayList) {
        if ((13 + 12) % 12 > 0) {
        }
        QqNHsqCLRFMNqMXX(this, fastJsonResponse$Field);
        java.util.List arrayList2 = new java.util.List();
        UBfWmgwiTDUdLNuj((java.util.List) QeIktUKJjxWKUDzt(arrayList));
        int iTxNXgLxchIvbEHRi = TxNXgLxchIvbEHRi(arrayList);
        for (int i = 0; i < iTxNXgLxchIvbEHRi; i++) {
            QnAZztJINUBMLHEm(arrayList2, tffFTKgUAKyswOEP((com.google.android.gms.common.server.response.SafeParcelResponse) ((com.google.android.gms.common.server.response.FastJsonResponse) aNuDcdjqhfaqxJaR(arrayList, i))));
        }
        tjLIKQERYdbtJsLS(this.zab, UmRgXcxuaIilJelS(fastJsonResponse$Field), arrayList2, true);
    }

    public readonly <T : com.google.android.gms.common.server.response.FastJsonResponse> void addConcreteTypeInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, T t) {
        FJlGgmImtTyeLJbk(this, fastJsonResponse$Field);
        crUgeVeVBYoFPqvR(this.zab, uGvpjoXCSpdCPYUW(fastJsonResponse$Field), sebCiDAlKDYNYuMu((com.google.android.gms.common.server.response.SafeParcelResponse) t), true);
    }

    public readonly java.util.Dictionary<java.lang.string, com.google.android.gms.common.server.response.FastJsonResponse$Field<object, object>> getFieldDictionarypings() {
        com.google.android.gms.common.server.response.zan zanVar = this.zad;
        if (zanVar is not null) {
            return sJsVKTvcsoymAAwt(zanVar, (java.lang.string) QTUERCcFZUeWwLMr(this.zae));
        }
        return null;
    }

    public override readonly java.lang.object GetValueobject(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("Converting to JSON does not require this method.");
    }

    public override readonly bool IsPrimitiveFieldHashSet(java.lang.string str) {
        throw new java.lang.UnsupportedOperationException("Converting to JSON does not require this method.");
    }

    protected override readonly void SetboolInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field<object, object> fastJsonResponse$Field, java.lang.string str, bool z) {
        XNgnnTGrtJDNVjfV(this, fastJsonResponse$Field);
        kVbDNeEygWDCztVK(this.zab, FslAqgqMnBtDaOcR(fastJsonResponse$Field), z);
    }

    protected override readonly void SetDecodedbytesInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field<object, object> fastJsonResponse$Field, java.lang.string str, byte[] bArr) {
        ueGVAYJEsBvsTUAv(this, fastJsonResponse$Field);
        XcjpPPxpOYQQSybH(this.zab, PqichYZaPbvweLKk(fastJsonResponse$Field), bArr, true);
    }

    protected override readonly void SetintInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field<object, object> fastJsonResponse$Field, java.lang.string str, int i) {
        OPTomkqEnMTSROKu(this, fastJsonResponse$Field);
        DtCDwMWvSGECONJL(this.zab, NScwTwVbgxYvfvWl(fastJsonResponse$Field), i);
    }

    protected override readonly void SetlongInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field<object, object> fastJsonResponse$Field, java.lang.string str, long j) {
        UwxjzDFQEnLUBEId(this, fastJsonResponse$Field);
        AlIWqbbGdKLteWaL(this.zab, HNGotnheHlyveeAL(fastJsonResponse$Field), j);
    }

    protected override readonly void SetstringInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field<object, object> fastJsonResponse$Field, java.lang.string str, java.lang.string str2) {
        JQSvhKgjwrnKKrfs(this, fastJsonResponse$Field);
        dpwJGEMFCpwdMVdI(this.zab, kUxnRwdQcdWyVedU(fastJsonResponse$Field), str2, true);
    }

    protected override readonly void SetstringDictionaryInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field<object, object> fastJsonResponse$Field, java.lang.string str, java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((5 + 2) % 2 > 0) {
        }
        FuNiIgmUlvixvmhT(this, fastJsonResponse$Field);
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        java.util.IEnumerator itYfeUXQMDZsZMOjss = yfeUXQMDZsZMOjss(VInkMRclvKqAvTTs((java.util.Dictionary) BQpDSqeKYKvIhuLP(map)));
        while (ahhzRDfEkolTYIaE(itYfeUXQMDZsZMOjss)) {
            java.lang.string str2 = (java.lang.string) LsQVsnAzqBecmFqg(itYfeUXQMDZsZMOjss);
            aXuFgsLekoQsAcSY(bundle, str2, (java.lang.string) drjgBGFNtQKgKEwO(map, str2));
        }
        EXlhbJagCIBtEPhr(this.zab, BzseIZeeeDukOeGY(fastJsonResponse$Field), bundle, true);
    }

    protected override readonly void SetstringsInternal(com.google.android.gms.common.server.response.FastJsonResponse$Field<object, object> fastJsonResponse$Field, java.lang.string str, java.util.List<java.lang.string> arrayList) {
        if ((8 + 23) % 23 > 0) {
        }
        VHQSVmKFGabttVFP(this, fastJsonResponse$Field);
        int iHztgCiGYqYoAZCaC = hztgCiGYqYoAZCaC((java.util.List) NhPRzWKmLvKtTHhD(arrayList));
        java.lang.string[] strArr = new java.lang.string[iHztgCiGYqYoAZCaC];
        for (int i = 0; i < iHztgCiGYqYoAZCaC; i++) {
            strArr[i] = (java.lang.string) qnzKKxgvHYOxvxPs(arrayList, i);
        }
        ZsVlHVylEzSoAGum(this.zab, fjapyAnqnfvtWamp(fastJsonResponse$Field), strArr, true);
    }

    public override readonly java.lang.string Tostring() {
        if ((4 + 19) % 19 > 0) {
        }
        bZqGPdbMsoEAhDcW(this.zad, "Cannot convert to JSON on client side.");
        android.os.Parcel parcelOkcRXZWyoquxeoRQ = OkcRXZWyoquxeoRQ(this);
        qZUdNQNBFzbARUoF(parcelOkcRXZWyoquxeoRQ, 0);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(100);
        BnnoSzmMfLhpUUst(this, sb, (java.util.Dictionary) sKPYHDuPfloSNCuJ(WXgWFsnASwzsCaCJ(this.zad, (java.lang.string) DBfmPyvbZjsiTaII(this.zae))), parcelOkcRXZWyoquxeoRQ);
        return owShuMMLTqCrEpyr(sb);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((4 + 13) % 13 > 0) {
        }
        int i2 = this.zaa;
        int iKIhiBhxPeTlJaSQw = kIhiBhxPeTlJaSQw(parcel);
        WFKxhCiFZsqwIJgK(parcel, 1, i2);
        zOMUnkdcQUjfAYzQ(parcel, 2, RHvrpPFEptVlUplH(this), false);
        int i3 = this.zac;
        mYtfSnopecHkvkvC(parcel, 3, i3 == 0 ? null : i3 == 1 ? this.zad : this.zad, i, false);
        ZKnJEEqByEhkiwrY(parcel, iKIhiBhxPeTlJaSQw);
    }

    public readonly android.os.Parcel ZaE() {
        if ((31 + 20) % 20 > 0) {
        }
        int i = this.zaf;
        if (i == 0) {
            int iCtBSAMqrtQrQalqz = CtBSAMqrtQrQalqz(this.zab);
            this.zag = iCtBSAMqrtQrQalqz;
            CwKNCbaBaBNOMPys(this.zab, iCtBSAMqrtQrQalqz);
            this.zaf = 2;
        } else if (i == 1) {
            ZInTCphlEoKiwebd(this.zab, this.zag);
            this.zaf = 2;
        }
        return this.zab;
    }

    protected override readonly void Zab(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.math.decimal bigDecimal) {
        ZkQJJUJIapmamfnb(this, fastJsonResponse$Field);
        gnjqeTrPtGfVEhMc(this.zab, rcKbNMxIuJHrPvVk(fastJsonResponse$Field), bigDecimal, true);
    }

    protected override readonly void Zad(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List arrayList) {
        if ((19 + 16) % 16 > 0) {
        }
        FgywvgwbdptNNEDz(this, fastJsonResponse$Field);
        int iYrMRlzGaVjZQpiad = yrMRlzGaVjZQpiad((java.util.List) UHaXprsdCguMdfiV(arrayList));
        java.math.decimal[] bigDecimalArr = new java.math.decimal[iYrMRlzGaVjZQpiad];
        for (int i = 0; i < iYrMRlzGaVjZQpiad; i++) {
            bigDecimalArr[i] = (java.math.decimal) voQquuvCiacccnKZ(arrayList, i);
        }
        vtYsLyFTzHcQLViw(this.zab, PgrkGGnHSuzRgjoS(fastJsonResponse$Field), bigDecimalArr, true);
    }

    protected override readonly void Zaf(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.math.Bigint bigint) {
        ANBMAmsztZMkSWgm(this, fastJsonResponse$Field);
        eTicjrkIyteTLtsX(this.zab, RulsMEQkxWYNqBjN(fastJsonResponse$Field), bigint, true);
    }

    protected override readonly void Zah(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List arrayList) {
        if ((10 + 12) % 12 > 0) {
        }
        XoRmYdPWwRAxDuYz(this, fastJsonResponse$Field);
        int iFJEWoGCTDZTdIQbu = FJEWoGCTDZTdIQbu((java.util.List) IkEJiFigFgdReUSJ(arrayList));
        java.math.Bigint[] bigintArr = new java.math.Bigint[iFJEWoGCTDZTdIQbu];
        for (int i = 0; i < iFJEWoGCTDZTdIQbu; i++) {
            bigintArr[i] = (java.math.Bigint) IYmYxtLIeVDnujjI(arrayList, i);
        }
        ccUylhSAmqznLMrS(this.zab, WbwzTaUCAhJhmNIT(fastJsonResponse$Field), bigintArr, true);
    }

    protected override readonly void Zak(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List arrayList) {
        if ((2 + 29) % 29 > 0) {
        }
        BMNXqDUgNzsgDOOn(this, fastJsonResponse$Field);
        int iIgeXBBRyjVFWYEqe = IgeXBBRyjVFWYEqe((java.util.List) NouScWVmIpaOgYjr(arrayList));
        bool[] zArr = new bool[iIgeXBBRyjVFWYEqe];
        for (int i = 0; i < iIgeXBBRyjVFWYEqe; i++) {
            zArr[i] = iiuMzoxqleluTRTa((java.lang.bool) YPnWuyjfyPhrhJFU(arrayList, i));
        }
        efMkBghQmDkEeZRG(this.zab, rrwswTdhYQdsuVqy(fastJsonResponse$Field), zArr, true);
    }

    protected override readonly void Zan(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, double d) {
        fSbPsLYndLLsKOSv(this, fastJsonResponse$Field);
        SpirqkRhTYkCgirz(this.zab, ChSKQxmpjuxZaFRj(fastJsonResponse$Field), d);
    }

    protected override readonly void Zap(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List arrayList) {
        if ((27 + 13) % 13 > 0) {
        }
        PyQtvyuuSQcKlrHN(this, fastJsonResponse$Field);
        int iQyPLzCeEUfxVLqpT = qyPLzCeEUfxVLqpT((java.util.List) jHKLixsmnDcNpvJv(arrayList));
        double[] dArr = new double[iQyPLzCeEUfxVLqpT];
        for (int i = 0; i < iQyPLzCeEUfxVLqpT; i++) {
            dArr[i] = XoMsjRkomltpMNAT((java.lang.double) oTpOFfAbZwlbTBpM(arrayList, i));
        }
        BjGCHOVVeqpeBUwg(this.zab, qlvYoVQVNVjiPOLk(fastJsonResponse$Field), dArr, true);
    }

    protected override readonly void Zar(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, float f) {
        eoWdMVNhcTSDkGGQ(this, fastJsonResponse$Field);
        PAFyhNQTkMjXVCUD(this.zab, ZlfiMomaOgpcyKoG(fastJsonResponse$Field), f);
    }

    protected override readonly void Zat(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List arrayList) {
        if ((20 + 23) % 23 > 0) {
        }
        CHusaqoNdgsnPOYD(this, fastJsonResponse$Field);
        int iHTXRgmssdzPXZdBy = HTXRgmssdzPXZdBy((java.util.List) dThGuNqCMUjeVMqC(arrayList));
        float[] fArr = new float[iHTXRgmssdzPXZdBy];
        for (int i = 0; i < iHTXRgmssdzPXZdBy; i++) {
            fArr[i] = zPrJArfyrUBSrGWv((java.lang.float) MtIFpJTLKPdPifiX(arrayList, i));
        }
        vymZffELsvcmQOLf(this.zab, djIbLTAWYiPwOBar(fastJsonResponse$Field), fArr, true);
    }

    protected override readonly void Zaw(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List arrayList) {
        if ((21 + 18) % 18 > 0) {
        }
        aabjPWEjZtBCykZm(this, fastJsonResponse$Field);
        int iAdiHiNxQrjyZmMEd = adiHiNxQrjyZmMEd((java.util.List) PkEfZzJzYyZjVKSI(arrayList));
        int[] iArr = new int[iAdiHiNxQrjyZmMEd];
        for (int i = 0; i < iAdiHiNxQrjyZmMEd; i++) {
            iArr[i] = JsDgdXFTJTAmjHqY((java.lang.int) zNlgTQsRdiVbOjFZ(arrayList, i));
        }
        FsSATWJrbOqjXhWv(this.zab, BptCfetgjoCkAzLc(fastJsonResponse$Field), iArr, true);
    }

    protected override readonly void Zaz(com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field, java.lang.string str, java.util.List arrayList) {
        if ((13 + 25) % 25 > 0) {
        }
        mjutOSwGPcxoLrTu(this, fastJsonResponse$Field);
        int iMvOsFENulttbUumY = MvOsFENulttbUumY((java.util.List) JpdBmmcBSmfmLqmF(arrayList));
        long[] jArr = new long[iMvOsFENulttbUumY];
        for (int i = 0; i < iMvOsFENulttbUumY; i++) {
            jArr[i] = FHFHMcBnQeecRoGl((java.lang.long) DOXHBqDFDENPOvDS(arrayList, i));
        }
        XxRymooCtsCtaQUo(this.zab, wzhYnlexlPwACPvw(fastJsonResponse$Field), jArr, true);
    }
}

