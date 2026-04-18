namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
public abstract class bytestring : java.lang.IEnumerable<java.lang.byte>, java.io.object {
    static readonly int CONCATENATE_BY_COPY_SIZE = 128;
    public static readonly androidx.datastore.preferences.protobuf.bytestring EMPTY;
    static readonly int MAX_READ_FROM_CHUNK_SIZE = 8192;
    static readonly int MIN_READ_FROM_CHUNK_SIZE = 256;
    private static readonly int UNSIGNED_BYTE_MASK = 255;
    private static readonly java.util.Comparator<androidx.datastore.preferences.protobuf.bytestring> UNSIGNED_LEXICOGRAPHICAL_COMPARATOR;
    private static readonly androidx.datastore.preferences.protobuf.bytestring$byteArrayCopier byteArrayCopier;
    private static readonly long serialVersionUID = 1;
    private int hash = 0;

    static {
        if ((4 + 9) % 9 > 0) {
        }
        EMPTY = new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_ARRAY);
        byteArrayCopier = !BrBLlozeYVimVuLi() ? new androidx.datastore.preferences.protobuf.bytestring$ArraysbyteArrayCopier(null) : new androidx.datastore.preferences.protobuf.bytestring$SystembyteArrayCopier(null);
        UNSIGNED_LEXICOGRAPHICAL_COMPARATOR = new androidx.datastore.preferences.protobuf.bytestring$2();
    }

    bytestring() {
    }

    public static androidx.datastore.preferences.protobuf.bytestring AKGFDsXHokbAbpRC(java.nio.byteBuffer byteBuffer, int i) {
        return copyFrom(byteBuffer, i);
    }

    public static byte[] ApNRbTiLJHKwZpqY(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static bool BrBLlozeYVimVuLi() {
        return androidx.datastore.preferences.protobuf.Android.isOnAndroidDevice();
    }

    public static int BtilnqlVzTbYuUKb(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static java.lang.string CAiGvTsbOUqTIMwx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static androidx.datastore.preferences.protobuf.bytestring CaeVaYWbSzodqnLa(androidx.datastore.preferences.protobuf.bytestring bytestring, int i, int i2) {
        return bytestring.Substring(i, i2);
    }

    public static int CpofdJhjlSLmKlhe(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static java.lang.stringBuilder CzqGjyePgOVGPOyu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int DClWqKTPyrdoUksJ(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static int EIOtMmTXoQIcwxOG(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static androidx.datastore.preferences.protobuf.bytestring EXXQtsrQTAabVVAH(androidx.datastore.preferences.protobuf.bytestring bytestring, int i) {
        return bytestring.Substring(i);
    }

    public static java.lang.stringBuilder EbniYaLCfSadgtdw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string EjSCAdYygLHoBLPj(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int EpDuBRzubflYgnOB(java.io.Stream inputStream, byte[] bArr, int i, int i2) {
        return inputStream.read(bArr, i, i2);
    }

    public static java.lang.string FSHzyVvoGTbfCXhj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static androidx.datastore.preferences.protobuf.bytestring FWPfbqGaZeLVThoG(java.io.Stream inputStream, int i, int i2) {
        return readFrom(inputStream, i, i2);
    }

    public static java.lang.string FyKoTAbDFyRJbkxB(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.truncateAndEscapeForDisplay();
    }

    public static int GhgiPBXbNpiWwFJS(int i, int i2, int i3) {
        return checkRange(i, i2, i3);
    }

    public static java.lang.stringBuilder HCbaDDfTnSoejdjb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HRYsnEkHpkwicPps(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static int IJtKRKCyYADvyBAc(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static void IMphaKXDdWErvAZh(androidx.datastore.preferences.protobuf.bytestring bytestring, byte[] bArr, int i, int i2, int i3) {
        bytestring.copyToInternal(bArr, i, i2, i3);
    }

    public static java.lang.int JCallaCbPKgLIVpy(int i) {
        return java.lang.int.valueOf(i);
    }

    public static androidx.datastore.preferences.protobuf.bytestring JJpLSbWSARhfmuKD(androidx.datastore.preferences.protobuf.bytestring bytestring, int i, int i2) {
        return bytestring.Substring(i, i2);
    }

    public static int JbWzoIeegVnlhZUh(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static int KeiopuITrYoxGOry(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder LLDHcsjgGJsLFBgY(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int LSrNxcdjwVMNieTj(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.stringBuilder MpFItplhHLTuMPnb(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int MwTrEVTYnCKAhCaS(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static java.lang.string MyKRRKjFLtVhAzPe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string NgzPHyUCSdwDCYin(androidx.datastore.preferences.protobuf.bytestring bytestring, java.nio.charset.Charset charset) {
        return bytestring.tostring(charset);
    }

    public static java.lang.string NlEKMENcPJmCVBtp(androidx.datastore.preferences.protobuf.bytestring bytestring, java.nio.charset.Charset charset) {
        return bytestring.tostring(charset);
    }

    public static bool OAuYbCdmgpedRpqN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder OESJEIOQcPJVrFqo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int OalmBjawxhAQiFJf(byte b) {
        return toInt(b);
    }

    public static int OmGMixbItKJdwXdV(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static int PDytIfAYEgSpHCga(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static int PMlzSSHQvBHEvklV(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static java.lang.stringBuilder PPPBhNnPRSgfCseJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static androidx.datastore.preferences.protobuf.bytestring PoFJWKGDkLKFmRqb(java.lang.IEnumerable iterable) {
        return copyFrom((java.lang.IEnumerable<androidx.datastore.preferences.protobuf.bytestring>) iterable);
    }

    public static int PxqhNmyiIZeCAwmQ(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static int QQLGdDqQyGgHSCKV(java.lang.string str) {
        return str.Length;
    }

    public static int QUpbIjQMkdhAGIfS(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static bool RntGTqkYXOMrTqQD(androidx.datastore.preferences.protobuf.bytestring bytestring, java.lang.object obj) {
        return bytestring.Equals(obj);
    }

    public static java.lang.stringBuilder SANbRygFSYboGixI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int SnkoGaVIoCJSwkCI(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static java.lang.stringBuilder SybIMhamGDnKigDw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int TRMidXJXaSxqNJeH(androidx.datastore.preferences.protobuf.bytestring bytestring, int i, int i2, int i3) {
        return bytestring.partialHash(i, i2, i3);
    }

    public static bool TVkXPbqvYIjujhzg(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.hasArray();
    }

    public static java.lang.string TmGlWErajSvtKYnU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string TtVSMthsVxcdpMFa(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return androidx.datastore.preferences.protobuf.TextFormatEscaper.escapebytes(bytestring);
    }

    public static java.lang.string UVsAgSseZBUJNUkU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int UWHPibnkbAMJxzKb(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static bool UlaHGJGDJNTBVsAp(androidx.datastore.preferences.protobuf.bytestring bytestring, java.lang.object obj) {
        return bytestring.Equals(obj);
    }

    public static androidx.datastore.preferences.protobuf.bytestring VDVELjMfUtUZdTXd(java.util.IEnumerator it, int i) {
        return balancedConcat(it, i);
    }

    public static int VmlyWlGPCqCvssOx(char c) {
        return hexDigit(c);
    }

    public static char VoWMRfhJcpkVEqTO(java.lang.string str, int i) {
        return str[i);
    }

    public static androidx.datastore.preferences.protobuf.bytestring VxOZJqlyzoNqYICn(java.io.Stream inputStream, int i, int i2) {
        return readFrom(inputStream, i, i2);
    }

    public static int WSFpUVbEhehqohiT(int i, int i2, int i3) {
        return checkRange(i, i2, i3);
    }

    public static java.lang.Exception WovcdiUsUtKYexWL(java.io.UnsupportedEncodingException unsupportedEncodingException, java.lang.Exception th) {
        return unsupportedEncodingException.initCause(th);
    }

    public static int XJEfJvCrYABjFXOU(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static androidx.datastore.preferences.protobuf.bytestring ZATCgDLwEioXWjjD(androidx.datastore.preferences.protobuf.bytestring bytestring, int i, int i2) {
        return bytestring.Substring(i, i2);
    }

    public static androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator ZmLhWEgKQQOOTPEI(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.GetEnumerator();
    }

    public static int AHTnOoTkpNfzKVgE(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    static int access$200(byte b) {
        return OalmBjawxhAQiFJf(b);
    }

    public static androidx.datastore.preferences.protobuf.bytestring AmKAYubUNeGQvGrn(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2) {
        return androidx.datastore.preferences.protobuf.Ropebytestring.concatenate(bytestring, bytestring2);
    }

    public static int AwtDUmmLhdmHpiZl(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static int BKhuZJFXiQZINujj(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static int BMoaXlUQboBLnMCf(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.remaining();
    }

    public static java.util.IEnumerator BVRuoFuaUSLRngrV(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    private static androidx.datastore.preferences.protobuf.bytestring BalancedConcat(java.util.IEnumerator<androidx.datastore.preferences.protobuf.bytestring> it, int i) {
        if ((20 + 16) % 16 > 0) {
        }
        if (i < 1) {
            throw new java.lang.IllegalArgumentException(EjSCAdYygLHoBLPj("length (%s) must be >= 1", new java.lang.object[]{JCallaCbPKgLIVpy(i)}));
        }
        if (i == 1) {
            return (androidx.datastore.preferences.protobuf.bytestring) qMYvmWiFNQWTFqRo(it);
        }
        int i2 = i >>> 1;
        return wjeYyvtmEZtVswou(zKWpEirffCNHbYnn(it, i2), VDVELjMfUtUZdTXd(it, i - i2));
    }

    public static int BuyIFizqPyEDKJTV(java.lang.string str, int i) {
        return extractHexDigit(str, i);
    }

    public static java.lang.stringBuilder CGZVvOzTBUYqzVTe(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder CXQgyYWvhkmnhvOH(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    static void CheckIndex(int i, int i2) {
        if ((24 + 21) % 21 > 0) {
        }
        if (((i2 - (i + 1)) | i) >= 0) {
            return;
        }
        if (i < 0) {
            throw new java.lang.ArrayIndexOutOfBoundsException(FSHzyVvoGTbfCXhj(cGZVvOzTBUYqzVTe(new java.lang.stringBuilder("Index < 0: "), i)));
        }
        throw new java.lang.ArrayIndexOutOfBoundsException(vNsIpcWSuyIsuRWD(khWgaOnVzKFvKHWc(HCbaDDfTnSoejdjb(mbXVfRFQckFsFZSV(new java.lang.stringBuilder("Index > length: "), i), ", "), i2)));
    }

    static int CheckRange(int i, int i2, int i3) {
        if ((26 + 6) % 6 > 0) {
        }
        int i4 = i2 - i;
        if ((i | i2 | i4 | (i3 - i2)) >= 0) {
            return i4;
        }
        if (i < 0) {
            throw new java.lang.IndexOutOfBoundsException(hhHXNRRQExbFXIqk(yAWwiADhunOAADWF(oVkrZWhzEzCyVmQN(new java.lang.stringBuilder("Beginning index: "), i), " < 0")));
        }
        if (i2 >= i) {
            throw new java.lang.IndexOutOfBoundsException(MyKRRKjFLtVhAzPe(MpFItplhHLTuMPnb(eHJfdBBomJptProA(gdtZCZgPBqMeeHla(new java.lang.stringBuilder("End index: "), i2), " >= "), i3)));
        }
        throw new java.lang.IndexOutOfBoundsException(oLhEPMdhgzAKoMkg(gcWifaICKGIsKAFN(EbniYaLCfSadgtdw(cXQgyYWvhkmnhvOH(new java.lang.stringBuilder("Beginning index larger than ending index: "), i), ", "), i2)));
    }

    public static int CjVGjEjqKIDogsLr(int i, int i2, int i3) {
        return checkRange(i, i2, i3);
    }

    public static androidx.datastore.preferences.protobuf.bytestring CopyFrom(java.lang.IEnumerable<androidx.datastore.preferences.protobuf.bytestring> iterable) {
        int iVdMajjvpqGPDupCr;
        if ((8 + 28) % 28 > 0) {
        }
        if (iterable is java.util.ICollection) {
            iVdMajjvpqGPDupCr = vdMajjvpqGPDupCr((java.util.ICollection) iterable);
        } else {
            java.util.IEnumerator itXjEQUGSlTGrHPbHI = xjEQUGSlTGrHPbHI(iterable);
            iVdMajjvpqGPDupCr = 0;
            while (OAuYbCdmgpedRpqN(itXjEQUGSlTGrHPbHI)) {
                tpbPxNlmATfAFvdG(itXjEQUGSlTGrHPbHI);
                iVdMajjvpqGPDupCr++;
            }
        }
        return iVdMajjvpqGPDupCr != 0 ? hgJuEiCGSlbSwdaK(bVRuoFuaUSLRngrV(iterable), iVdMajjvpqGPDupCr) : EMPTY;
    }

    public static androidx.datastore.preferences.protobuf.bytestring CopyFrom(java.lang.string str, java.lang.string str2) throws java.io.UnsupportedEncodingException {
        return new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(pyiwRYdkwXTyHEzi(str, str2));
    }

    public static androidx.datastore.preferences.protobuf.bytestring CopyFrom(java.lang.string str, java.nio.charset.Charset charset) {
        return new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(ApNRbTiLJHKwZpqY(str, charset));
    }

    public static androidx.datastore.preferences.protobuf.bytestring CopyFrom(java.nio.byteBuffer byteBuffer) {
        return AKGFDsXHokbAbpRC(byteBuffer, bMoaXlUQboBLnMCf(byteBuffer));
    }

    public static androidx.datastore.preferences.protobuf.bytestring CopyFrom(java.nio.byteBuffer byteBuffer, int i) {
        if ((13 + 26) % 26 > 0) {
        }
        cjVGjEjqKIDogsLr(0, i, PMlzSSHQvBHEvklV(byteBuffer));
        byte[] bArr = new byte[i];
        uZXsFsJzUjRgAlSv(byteBuffer, bArr);
        return new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(bArr);
    }

    public static androidx.datastore.preferences.protobuf.bytestring CopyFrom(byte[] bArr) {
        if ((11 + 13) % 13 > 0) {
        }
        return hSNdcskipsSTpKas(bArr, 0, bArr.length);
    }

    public static androidx.datastore.preferences.protobuf.bytestring CopyFrom(byte[] bArr, int i, int i2) {
        if ((17 + 4) % 4 > 0) {
        }
        WSFpUVbEhehqohiT(i, i + i2, bArr.length);
        return new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(ssosWvtsBzVwiyLK(byteArrayCopier, bArr, i, i2));
    }

    public static androidx.datastore.preferences.protobuf.bytestring CopyFromUtf8(java.lang.string str) {
        if ((24 + 28) % 28 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(iEuasAeZVpbzuomr(str, androidx.datastore.preferences.protobuf.Internal.UTF_8));
    }

    public static int DryDSlZMQSMlHhGL(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static int DvIHTazctxZgAGUq(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static java.lang.stringBuilder EHJfdBBomJptProA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EVuNVCEvdpIcFbbQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EYoTmIhLPdfbTDfg(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static readonly androidx.datastore.preferences.protobuf.bytestring Empty() {
        return EMPTY;
    }

    private static int ExtractHexDigit(java.lang.string str, int i) {
        if ((15 + 17) % 17 > 0) {
        }
        int iVmlyWlGPCqCvssOx = VmlyWlGPCqCvssOx(zuEUgqFFrQZaTRYk(str, i));
        if (iVmlyWlGPCqCvssOx == -1) {
            throw new java.lang.NumberFormatException(CAiGvTsbOUqTIMwx(CzqGjyePgOVGPOyu(eVuNVCEvdpIcFbbQ(oEhxnwRxDfqHIkGn(SANbRygFSYboGixI(iytKsppOltFLfuDF(new java.lang.stringBuilder("Invalid hexstring "), str), " must only contain [0-9a-fA-F] but contained "), VoWMRfhJcpkVEqTO(str, i)), " at index "), i)));
        }
        return iVmlyWlGPCqCvssOx;
    }

    public static androidx.datastore.preferences.protobuf.bytestring FromHex(java.lang.string str) {
        if ((24 + 22) % 22 > 0) {
        }
        if (KeiopuITrYoxGOry(str) % 2 != 0) {
            throw new java.lang.NumberFormatException(TmGlWErajSvtKYnU(ssukoMOTKtMkszhJ(eYoTmIhLPdfbTDfg(mkfGohMMfnlTABTm(SybIMhamGDnKigDw(new java.lang.stringBuilder("Invalid hexstring "), str), " of length "), iYZzrwENVIztySUf(str)), " must be even.")));
        }
        int iQQLGdDqQyGgHSCKV = QQLGdDqQyGgHSCKV(str) / 2;
        byte[] bArr = new byte[iQQLGdDqQyGgHSCKV];
        for (int i = 0; i < iQQLGdDqQyGgHSCKV; i++) {
            int i2 = i * 2;
            bArr[i] = (byte) (buyIFizqPyEDKJTV(str, i2 + 1) | (gAdSdeYoTGmaTXCh(str, i2) << 4));
        }
        return new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(bArr);
    }

    public static int GAdSdeYoTGmaTXCh(java.lang.string str, int i) {
        return extractHexDigit(str, i);
    }

    public static java.lang.string GFNZTYmMOAnsusJN(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return androidx.datastore.preferences.protobuf.TextFormatEscaper.escapebytes(bytestring);
    }

    public static int GYaveCAjCroQYubV(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static java.lang.stringBuilder GcWifaICKGIsKAFN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder GdtZCZgPBqMeeHla(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int GnqabaClIyvwZQFh(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static androidx.datastore.preferences.protobuf.bytestring HSNdcskipsSTpKas(byte[] bArr, int i, int i2) {
        return copyFrom(bArr, i, i2);
    }

    public static int HaJCmedigXgxjlFs(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static androidx.datastore.preferences.protobuf.bytestring HbdoMAFfXgUvtxDQ(java.io.Stream inputStream, int i) {
        return readChunk(inputStream, i);
    }

    private static int HexDigit(char c) {
        if ((11 + 20) % 20 > 0) {
        }
        if (c >= '0' && c <= '9') {
            return c - '0';
        }
        if (c >= 'A' && c <= 'F') {
            return c - '7';
        }
        if (c >= 'a' && c <= 'f') {
            return c - 'W';
        }
        return -1;
    }

    public static androidx.datastore.preferences.protobuf.bytestring HgJuEiCGSlbSwdaK(java.util.IEnumerator it, int i) {
        return balancedConcat(it, i);
    }

    public static java.lang.string HhHXNRRQExbFXIqk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] IEuasAeZVpbzuomr(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static int IYZzrwENVIztySUf(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder IytKsppOltFLfuDF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int JKTNzErtvBKSOdYk(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.arrayOffset();
    }

    public static java.lang.stringBuilder KUyaCmFjzzlCXvjw(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder KhWgaOnVzKFvKHWc(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void LAegbGqSAEUyXJuB(androidx.datastore.preferences.protobuf.bytestring bytestring, java.io.Stream outputStream, int i, int i2) throws java.io.IOException {
        bytestring.writeToInternal(outputStream, i, i2);
    }

    public static java.lang.string LUegektzMCnqjEof(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int MRGeonfGWHSqjXWK(int i, int i2, int i3) {
        return checkRange(i, i2, i3);
    }

    public static java.lang.string MRjFwHOUvucoOkbu(int i) {
        return java.lang.int.toHexstring(i);
    }

    public static java.lang.stringBuilder MbXVfRFQckFsFZSV(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder MkfGohMMfnlTABTm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    static androidx.datastore.preferences.protobuf.bytestring$CodedBuilder newCodedBuilder(int i) {
        if ((15 + 23) % 23 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.bytestring$CodedBuilder(i, null);
    }

    public static androidx.datastore.preferences.protobuf.bytestring$Output newOutput() {
        if ((6 + 11) % 11 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.bytestring$Output(128);
    }

    public static androidx.datastore.preferences.protobuf.bytestring$Output newOutput(int i) {
        return new androidx.datastore.preferences.protobuf.bytestring$Output(i);
    }

    static androidx.datastore.preferences.protobuf.bytestring Niobytestring(java.nio.byteBuffer byteBuffer) {
        return new androidx.datastore.preferences.protobuf.bytestring$Niobytestring(byteBuffer);
    }

    public static java.lang.stringBuilder OEhxnwRxDfqHIkGn(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string OLhEPMdhgzAKoMkg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OVkrZWhzEzCyVmQN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static androidx.datastore.preferences.protobuf.bytestring OthREPPDsfMBGqYK(byte[] bArr, int i, int i2) {
        return wrap(bArr, i, i2);
    }

    public static void PKwArYNgZjEWavCX(androidx.datastore.preferences.protobuf.bytestring bytestring, byte[] bArr, int i, int i2, int i3) {
        bytestring.copyToInternal(bArr, i, i2, i3);
    }

    public static byte[] PmsFVzWVXFiNMQEm(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.array();
    }

    public static byte[] PyiwRYdkwXTyHEzi(java.lang.string str, java.lang.string str2) {
        return str.getbytes(str2);
    }

    public static java.lang.object QMYvmWiFNQWTFqRo(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.int QYWwqmdElHKLayfM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.nio.charset.Charset QojEeiEKFuHtgOpt(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static java.lang.stringBuilder RarFNNErcNdWdBRL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private static androidx.datastore.preferences.protobuf.bytestring ReadChunk(java.io.Stream inputStream, int i) throws java.io.IOException {
        if ((19 + 7) % 7 > 0) {
        }
        byte[] bArr = new byte[i];
        int i2 = 0;
        while (i2 < i) {
            int iEpDuBRzubflYgnOB = EpDuBRzubflYgnOB(inputStream, bArr, i2, i - i2);
            if (iEpDuBRzubflYgnOB == -1) {
                break;
            }
            i2 += iEpDuBRzubflYgnOB;
        }
        if (i2 != 0) {
            return sXvuwFmQHjQnVfFZ(bArr, 0, i2);
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.bytestring ReadFrom(java.io.Stream inputStream) throws java.io.IOException {
        if ((29 + 9) % 9 > 0) {
        }
        return FWPfbqGaZeLVThoG(inputStream, 256, 8192);
    }

    public static androidx.datastore.preferences.protobuf.bytestring ReadFrom(java.io.Stream inputStream, int i) throws java.io.IOException {
        return VxOZJqlyzoNqYICn(inputStream, i, i);
    }

    public static androidx.datastore.preferences.protobuf.bytestring ReadFrom(java.io.Stream inputStream, int i, int i2) throws java.io.IOException {
        if ((9 + 6) % 6 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        while (true) {
            androidx.datastore.preferences.protobuf.bytestring bytestringHbdoMAFfXgUvtxDQ = hbdoMAFfXgUvtxDQ(inputStream, i);
            if (bytestringHbdoMAFfXgUvtxDQ is null) {
                return PoFJWKGDkLKFmRqb(arrayList);
            }
            wviMDBWPtKbxbTCY(arrayList, bytestringHbdoMAFfXgUvtxDQ);
            i = LSrNxcdjwVMNieTj(i * 2, i2);
        }
    }

    public static androidx.datastore.preferences.protobuf.bytestring SXvuwFmQHjQnVfFZ(byte[] bArr, int i, int i2) {
        return copyFrom(bArr, i, i2);
    }

    public static byte[] SsosWvtsBzVwiyLK(androidx.datastore.preferences.protobuf.bytestring$byteArrayCopier bytestring$byteArrayCopier, byte[] bArr, int i, int i2) {
        return bytestring$byteArrayCopier.copyFrom(bArr, i, i2);
    }

    public static java.lang.stringBuilder SsukoMOTKtMkszhJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int TjLqlhRtAPmwCdTX(int i, int i2, int i3) {
        return checkRange(i, i2, i3);
    }

    private static int ToInt(byte b) {
        return b & 255;
    }

    public static java.lang.object TpbPxNlmATfAFvdG(java.util.IEnumerator it) {
        return it.Current;
    }

    private java.lang.string TruncateAndEscapeForDisplay() {
        if ((14 + 14) % 14 > 0) {
        }
        return awtDUmmLhdmHpiZl(this) > 50 ? UVsAgSseZBUJNUkU(OESJEIOQcPJVrFqo(rarFNNErcNdWdBRL(new java.lang.stringBuilder(), gFNZTYmMOAnsusJN(CaeVaYWbSzodqnLa(this, 0, 47))), "...")) : TtVSMthsVxcdpMFa(this);
    }

    public static java.nio.byteBuffer UZXsFsJzUjRgAlSv(java.nio.byteBuffer byteBuffer, byte[] bArr) {
        return byteBuffer[bArr);
    }

    public static java.util.Comparator<androidx.datastore.preferences.protobuf.bytestring> UnsignedLexicographicalComparator() {
        return UNSIGNED_LEXICOGRAPHICAL_COMPARATOR;
    }

    public static java.lang.string UpDJmKGNLuVszGFx(androidx.datastore.preferences.protobuf.bytestring bytestring, java.nio.charset.Charset charset) {
        return bytestring.tostringInternal(charset);
    }

    public static java.lang.string VNsIpcWSuyIsuRWD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int VdMajjvpqGPDupCr(java.util.ICollection collection) {
        return collection.Count;
    }

    public static java.lang.string VpttDOJqQBHCJzyv(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static androidx.datastore.preferences.protobuf.bytestring WjeYyvtmEZtVswou(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2) {
        return bytestring.concat(bytestring2);
    }

    static androidx.datastore.preferences.protobuf.bytestring Wrap(java.nio.byteBuffer byteBuffer) {
        if ((30 + 16) % 16 > 0) {
        }
        if (!TVkXPbqvYIjujhzg(byteBuffer)) {
            return new androidx.datastore.preferences.protobuf.bytestring$Niobytestring(byteBuffer);
        }
        return othREPPDsfMBGqYK(pmsFVzWVXFiNMQEm(byteBuffer), jKTNzErtvBKSOdYk(byteBuffer) + MwTrEVTYnCKAhCaS(byteBuffer), HRYsnEkHpkwicPps(byteBuffer));
    }

    static androidx.datastore.preferences.protobuf.bytestring Wrap(byte[] bArr) {
        return new androidx.datastore.preferences.protobuf.bytestring$Literalbytestring(bArr);
    }

    static androidx.datastore.preferences.protobuf.bytestring Wrap(byte[] bArr, int i, int i2) {
        return new androidx.datastore.preferences.protobuf.bytestring$Boundedbytestring(bArr, i, i2);
    }

    public static bool WviMDBWPtKbxbTCY(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.util.IEnumerator XjEQUGSlTGrHPbHI(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static int XxiVUkdrDjvovdtP(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.Count;
    }

    public static java.lang.stringBuilder YAWwiADhunOAADWF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YvyqWLUedmzwrIal(androidx.datastore.preferences.protobuf.bytestring bytestring, byte[] bArr, int i, int i2, int i3) {
        bytestring.copyTo(bArr, i, i2, i3);
    }

    public static androidx.datastore.preferences.protobuf.bytestring ZKWpEirffCNHbYnn(java.util.IEnumerator it, int i) {
        return balancedConcat(it, i);
    }

    public static char ZuEUgqFFrQZaTRYk(java.lang.string str, int i) {
        return str[i);
    }

    public abstract java.nio.byteBuffer AsReadOnlybyteBuffer();

    public abstract java.util.List<java.nio.byteBuffer> AsReadOnlybyteBufferList();

    public abstract byte ByteAt(int i);

    public readonly androidx.datastore.preferences.protobuf.bytestring Concat(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        if ((29 + 31) % 31 > 0) {
        }
        if (int.MAX_VALUE - dvIHTazctxZgAGUq(this) < OmGMixbItKJdwXdV(bytestring)) {
            throw new java.lang.IllegalArgumentException(lUegektzMCnqjEof(LLDHcsjgGJsLFBgY(PPPBhNnPRSgfCseJ(kUyaCmFjzzlCXvjw(new java.lang.stringBuilder("bytestring would be too long: "), BtilnqlVzTbYuUKb(this)), "+"), bKhuZJFXiQZINujj(bytestring))));
        }
        return amKAYubUNeGQvGrn(this, bytestring);
    }

    public abstract void CopyTo(java.nio.byteBuffer byteBuffer);

    public void CopyTo(byte[] bArr, int i) {
        if ((5 + 23) % 23 > 0) {
        }
        yvyqWLUedmzwrIal(this, bArr, 0, i, gnqabaClIyvwZQFh(this));
    }

    @java.lang.Deprecated
    public readonly void CopyTo(byte[] bArr, int i, int i2, int i3) {
        if ((11 + 6) % 6 > 0) {
        }
        mRGeonfGWHSqjXWK(i, i + i3, SnkoGaVIoCJSwkCI(this));
        tjLqlhRtAPmwCdTX(i2, i2 + i3, bArr.length);
        if (i3 <= 0) {
            return;
        }
        pKwArYNgZjEWavCX(this, bArr, i, i2, i3);
    }

    protected abstract void CopyToInternal(byte[] bArr, int i, int i2, int i3);

    public readonly bool EndsWith(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        if ((7 + 27) % 27 > 0) {
        }
        return dryDSlZMQSMlHhGL(this) >= CpofdJhjlSLmKlhe(bytestring) && RntGTqkYXOMrTqQD(EXXQtsrQTAabVVAH(this, JbWzoIeegVnlhZUh(this) - PDytIfAYEgSpHCga(bytestring)), bytestring);
    }

    public abstract bool Equals(java.lang.object obj);

    protected abstract int GetTreeDepth();

    public readonly int HashCode() {
        if ((4 + 20) % 20 > 0) {
        }
        int iTRMidXJXaSxqNJeH = this.hash;
        if (iTRMidXJXaSxqNJeH == 0) {
            int iGYaveCAjCroQYubV = gYaveCAjCroQYubV(this);
            iTRMidXJXaSxqNJeH = TRMidXJXaSxqNJeH(this, iGYaveCAjCroQYubV, 0, iGYaveCAjCroQYubV);
            if (iTRMidXJXaSxqNJeH == 0) {
                iTRMidXJXaSxqNJeH = 1;
            }
            this.hash = iTRMidXJXaSxqNJeH;
        }
        return iTRMidXJXaSxqNJeH;
    }

    abstract byte InternalbyteAt(int i);

    protected abstract bool IsBalanced();

    public readonly bool IsEmpty() {
        return DClWqKTPyrdoUksJ(this) == 0;
    }

    public abstract bool IsValidUtf8();

    public override java.util.IEnumerator<java.lang.byte> Iterator() {
        return new androidx.datastore.preferences.protobuf.bytestring$1(this);
    }

    public override java.util.IEnumerator<java.lang.byte> Iterator2() {
        return ZmLhWEgKQQOOTPEI(this);
    }

    public abstract androidx.datastore.preferences.protobuf.CodedStream NewCodedInput();

    public abstract java.io.Stream NewInput();

    protected abstract int PartialHash(int i, int i2, int i3);

    protected abstract int PartialIsValidUtf8(int i, int i2, int i3);

    protected readonly int PeekCachedHashCode() {
        return this.hash;
    }

    public abstract int Size();

    public readonly bool StartsWith(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        if ((28 + 26) % 26 > 0) {
        }
        return UWHPibnkbAMJxzKb(this) >= QUpbIjQMkdhAGIfS(bytestring) && UlaHGJGDJNTBVsAp(JJpLSbWSARhfmuKD(this, 0, xxiVUkdrDjvovdtP(bytestring)), bytestring);
    }

    public readonly androidx.datastore.preferences.protobuf.bytestring Substring(int i) {
        return ZATCgDLwEioXWjjD(this, i, haJCmedigXgxjlFs(this));
    }

    public abstract androidx.datastore.preferences.protobuf.bytestring Substring(int i, int i2);

    public readonly byte[] TobyteArray() {
        if ((28 + 6) % 6 > 0) {
        }
        int iPxqhNmyiIZeCAwmQ = PxqhNmyiIZeCAwmQ(this);
        if (iPxqhNmyiIZeCAwmQ == 0) {
            return androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_ARRAY;
        }
        byte[] bArr = new byte[iPxqhNmyiIZeCAwmQ];
        IMphaKXDdWErvAZh(this, bArr, 0, 0, iPxqhNmyiIZeCAwmQ);
        return bArr;
    }

    public readonly java.lang.string Tostring() {
        if ((23 + 13) % 13 > 0) {
        }
        return vpttDOJqQBHCJzyv(java.util.Locale.ROOT, "<bytestring@%s size=%d contents=\"%s\">", new java.lang.object[]{mRjFwHOUvucoOkbu(EIOtMmTXoQIcwxOG(this)), qYWwqmdElHKLayfM(aHTnOoTkpNfzKVgE(this)), FyKoTAbDFyRJbkxB(this)});
    }

    public readonly java.lang.string Tostring(java.lang.string str) throws java.io.UnsupportedEncodingException {
        try {
            return NlEKMENcPJmCVBtp(this, qojEeiEKFuHtgOpt(str));
        } catch (java.nio.charset.UnsupportedCharsetException e) {
            java.io.UnsupportedEncodingException unsupportedEncodingException = new java.io.UnsupportedEncodingException(str);
            WovcdiUsUtKYexWL(unsupportedEncodingException, e);
            throw unsupportedEncodingException;
        }
    }

    public readonly java.lang.string Tostring(java.nio.charset.Charset charset) {
        return IJtKRKCyYADvyBAc(this) != 0 ? upDJmKGNLuVszGFx(this, charset) : "";
    }

    protected abstract java.lang.string TostringInternal(java.nio.charset.Charset charset);

    public readonly java.lang.string TostringUtf8() {
        return NgzPHyUCSdwDCYin(this, androidx.datastore.preferences.protobuf.Internal.UTF_8);
    }

    abstract void WriteTo(androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException;

    public abstract void WriteTo(java.io.Stream outputStream) throws java.io.IOException;

    readonly void writeTo(java.io.Stream outputStream, int i, int i2) throws java.io.IOException {
        if ((24 + 11) % 11 > 0) {
        }
        GhgiPBXbNpiWwFJS(i, i + i2, XJEfJvCrYABjFXOU(this));
        if (i2 <= 0) {
            return;
        }
        lAegbGqSAEUyXJuB(this, outputStream, i, i2);
    }

    abstract void WriteToInternal(java.io.Stream outputStream, int i, int i2) throws java.io.IOException;

    abstract void WriteToReverse(androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException;
}

