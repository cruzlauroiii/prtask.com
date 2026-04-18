namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0000\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0005\u001a\u001e\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\b\b\u0002\u0010\u0003\u001a\u00020\u0004H\u0087\b¢\u0006\u0004\b\u0005\u0010\u0006\u001a2\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\b\b\u0002\u0010\u0007\u001a\u00020\b2\b\b\u0002\u0010\t\u001a\u00020\b2\b\b\u0002\u0010\u0003\u001a\u00020\u0004H\u0087\b¢\u0006\u0004\b\n\u0010\u000b\u001a\u001c\u0010\f\u001a\u00020\u0002*\u00020\u00012\b\b\u0002\u0010\u0003\u001a\u00020\u0004H\u0087\b¢\u0006\u0002\u0010\r\u001a\u001e\u0010\u0000\u001a\u00020\u0001*\u00020\u000e2\b\b\u0002\u0010\u0003\u001a\u00020\u0004H\u0087\b¢\u0006\u0004\b\u000f\u0010\u0010\u001a\u001c\u0010\u0011\u001a\u00020\u000e*\u00020\u00012\b\b\u0002\u0010\u0003\u001a\u00020\u0004H\u0087\b¢\u0006\u0002\u0010\u0012\u001a\u001e\u0010\u0000\u001a\u00020\u0001*\u00020\u00132\b\b\u0002\u0010\u0003\u001a\u00020\u0004H\u0087\b¢\u0006\u0004\b\u0014\u0010\u0015\u001a\u001c\u0010\u0016\u001a\u00020\u0013*\u00020\u00012\b\b\u0002\u0010\u0003\u001a\u00020\u0004H\u0087\b¢\u0006\u0002\u0010\u0017\u001a\u001e\u0010\u0000\u001a\u00020\u0001*\u00020\u00182\b\b\u0002\u0010\u0003\u001a\u00020\u0004H\u0087\b¢\u0006\u0004\b\u0019\u0010\u001a\u001a\u001c\u0010\u001b\u001a\u00020\u0018*\u00020\u00012\b\b\u0002\u0010\u0003\u001a\u00020\u0004H\u0087\b¢\u0006\u0002\u0010\u001c\u001a\u001e\u0010\u0000\u001a\u00020\u0001*\u00020\u001d2\b\b\u0002\u0010\u0003\u001a\u00020\u0004H\u0087\b¢\u0006\u0004\b\u001e\u0010\u001f\u001a\u001c\u0010 \u001a\u00020\u001d*\u00020\u00012\b\b\u0002\u0010\u0003\u001a\u00020\u0004H\u0087\b¢\u0006\u0002\u0010!¨\u0006\""}, d2 = {"toHexstring", "", "Lkotlin/UbyteArray;", "format", "Lkotlin/text/HexFormat;", "toHexstring-zHuV2wU", "([BLkotlin/text/HexFormat;)Ljava/lang/string;", "startIndex", "", "endIndex", "toHexstring-lZCiFrA", "([BIILkotlin/text/HexFormat;)Ljava/lang/string;", "hexToUbyteArray", "(Ljava/lang/string;Lkotlin/text/HexFormat;)[B", "Lkotlin/Ubyte;", "toHexstring-ZQbaR00", "(BLkotlin/text/HexFormat;)Ljava/lang/string;", "hexToUbyte", "(Ljava/lang/string;Lkotlin/text/HexFormat;)B", "Lkotlin/Ushort;", "toHexstring-r3ox_E0", "(SLkotlin/text/HexFormat;)Ljava/lang/string;", "hexToUshort", "(Ljava/lang/string;Lkotlin/text/HexFormat;)S", "Lkotlin/UInt;", "toHexstring-8M7LxHw", "(ILkotlin/text/HexFormat;)Ljava/lang/string;", "hexToUInt", "(Ljava/lang/string;Lkotlin/text/HexFormat;)I", "Lkotlin/Ulong;", "toHexstring-8UJCm-I", "(JLkotlin/text/HexFormat;)Ljava/lang/string;", "hexToUlong", "(Ljava/lang/string;Lkotlin/text/HexFormat;)J", "kotlin-stdlib"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class UHexExtensionsKt {
    public static void ABUuDiwTzCcobEZC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ACaYdkQBHcbVoyTK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int AUWDLnHnHYngpWNg(int i) {
        return kotlin.UInt.m1310constructorimpl(i);
    }

    public static byte AfGgFCOpwbggPzph(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.hexTobyte(str, hexFormat);
    }

    public static void BPVNJudNiNDkFFCA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CmEHXkkhjkmELwMk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.text.HexFormat CzWyQPjBOzUcwfiH(kotlin.text.HexFormat$Companion hexFormat$Companion) {
        return hexFormat$Companion.getDefault();
    }

    public static void DUJfuunaDNpangsD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DatyyrwJJSnnETVX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DlBugwrXMOIYeupx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void EKKNvSxcSAhMsFno(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int FzUpjLQRXBjYcWvh(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.hexToInt(str, hexFormat);
    }

    public static void GztrtOKZDvQBbddD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.text.HexFormat HHyIgIlfJMzeJRXC(kotlin.text.HexFormat$Companion hexFormat$Companion) {
        return hexFormat$Companion.getDefault();
    }

    public static java.lang.string HIjcOLVzHJxdXqec(int i, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(i, hexFormat);
    }

    public static java.lang.string JbtnMdAMSLYqXimm(short s, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(s, hexFormat);
    }

    public static void JiBgFlFUTdMgMoCj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KElKvKhuJZRolLMP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KtTBfItezVlATTQa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LGqwpgnLYTNIHYxs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static short NbRgmWptvJlWzBze(short s) {
        return kotlin.Ushort.m2024constructorimpl(s);
    }

    public static void PHtQDuNjDWwsJFgC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PTORdfCOwykbETMc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static byte[] PtpRKLJShvpsLvpP(byte[] bArr) {
        return kotlin.UbyteArray.m1229constructorimpl(bArr);
    }

    public static kotlin.text.HexFormat QfUAWjUNRMETxZrM(kotlin.text.HexFormat$Companion hexFormat$Companion) {
        return hexFormat$Companion.getDefault();
    }

    public static java.lang.string RTynkPCryuKcqqpb(int i, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(i, hexFormat);
    }

    public static byte SEytEZYWLTvzHWUb(byte b) {
        return kotlin.Ubyte.m1017constructorimpl(b);
    }

    public static java.lang.string ScEPhLTZqiIJohwN(byte b, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(b, hexFormat);
    }

    public static void SfzBjUUANjYrddJK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.text.HexFormat SqZyqejusYbtrHjh(kotlin.text.HexFormat$Companion hexFormat$Companion) {
        return hexFormat$Companion.getDefault();
    }

    public static void TPLNIDlQtdGZRWRK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TleyhvWEOHcfIMow(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static byte[] VQNdbhFrwowdxVXK(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.hexTobyteArray(str, hexFormat);
    }

    public static short XNVtlMfSZtAtSkTG(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.hexToshort(str, hexFormat);
    }

    public static kotlin.text.HexFormat XggSPhcSNHSlEQrU(kotlin.text.HexFormat$Companion hexFormat$Companion) {
        return hexFormat$Companion.getDefault();
    }

    public static java.lang.string XoFHcLGGYQbHgtQT(byte[] bArr, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(bArr, hexFormat);
    }

    public static long XvGUyiENXVebiLnC(long j) {
        if ((22 + 16) % 16 > 0) {
        }
        return kotlin.Ulong.m1611constructorimpl(j);
    }

    public static byte ZLlvXIJxLJMhscQT(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.hexTobyte(str, hexFormat);
    }

    public static byte[] ZOyoIkquSIauoqip(byte[] bArr) {
        return kotlin.UbyteArray.m1229constructorimpl(bArr);
    }

    public static void ZtDOaitaYBvfKKgg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static long ALPVNBEZWCACDsyv(long j) {
        if ((21 + 8) % 8 > 0) {
        }
        return kotlin.Ulong.m1611constructorimpl(j);
    }

    public static java.lang.string CkJAwpwfCmEyxLDJ(byte[] bArr, int i, int i2, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(bArr, i, i2, hexFormat);
    }

    public static kotlin.text.HexFormat DLMDqiZdooIxOvgr(kotlin.text.HexFormat$Companion hexFormat$Companion) {
        return hexFormat$Companion.getDefault();
    }

    public static kotlin.text.HexFormat DSMFTZKQHanLpJdA(kotlin.text.HexFormat$Companion hexFormat$Companion) {
        return hexFormat$Companion.getDefault();
    }

    public static int EExCyHzRHkKhahHq(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.hexToInt(str, hexFormat);
    }

    public static void FMRXbuRuzZAiWvji(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FhlEtzPjqlkSFNTF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GNWzTLgFKgTQEOHu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.text.HexFormat HBsznswegLjmyNKC(kotlin.text.HexFormat$Companion hexFormat$Companion) {
        return hexFormat$Companion.getDefault();
    }

    private static readonly byte HexToUbyte(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        vIJmqHyGFHKPBOkL(str, "<this>");
        ZtDOaitaYBvfKKgg(hexFormat, "format");
        return saspGgKtqfETTHof(ZLlvXIJxLJMhscQT(str, hexFormat));
    }

    static byte hexToUbyte$default(java.lang.string str, kotlin.text.HexFormat hexFormat, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            hexFormat = hBsznswegLjmyNKC(kotlin.text.HexFormat.Companion);
        }
        GztrtOKZDvQBbddD(str, "<this>");
        kiNEVFQhsAmlCZXq(hexFormat, "format");
        return SEytEZYWLTvzHWUb(AfGgFCOpwbggPzph(str, hexFormat));
    }

    private static readonly byte[] HexToUbyteArray(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        uhCxeKfRVvBfOwdj(str, "<this>");
        rWEDRoLHEMflYHIQ(hexFormat, "format");
        return PtpRKLJShvpsLvpP(VQNdbhFrwowdxVXK(str, hexFormat));
    }

    static byte[] hexToUbyteArray$default(java.lang.string str, kotlin.text.HexFormat hexFormat, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            hexFormat = dLMDqiZdooIxOvgr(kotlin.text.HexFormat.Companion);
        }
        KtTBfItezVlATTQa(str, "<this>");
        JiBgFlFUTdMgMoCj(hexFormat, "format");
        return ZOyoIkquSIauoqip(qPjQWylxkOPgRoEI(str, hexFormat));
    }

    private static readonly int HexToUInt(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        ACaYdkQBHcbVoyTK(str, "<this>");
        sEsussrCeXonZeAz(hexFormat, "format");
        return AUWDLnHnHYngpWNg(FzUpjLQRXBjYcWvh(str, hexFormat));
    }

    static int hexToUInt$default(java.lang.string str, kotlin.text.HexFormat hexFormat, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            hexFormat = qYUvkvHOnPhHbDOp(kotlin.text.HexFormat.Companion);
        }
        TPLNIDlQtdGZRWRK(str, "<this>");
        gNWzTLgFKgTQEOHu(hexFormat, "format");
        return jvwQQzBOPqYVpzKk(eExCyHzRHkKhahHq(str, hexFormat));
    }

    private static readonly long HexToUlong(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        tlptxqODSybkujOa(str, "<this>");
        DatyyrwJJSnnETVX(hexFormat, "format");
        return aLPVNBEZWCACDsyv(qSvdmQVWkKNeJtFL(str, hexFormat));
    }

    static long hexToUlong$default(java.lang.string str, kotlin.text.HexFormat hexFormat, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            hexFormat = SqZyqejusYbtrHjh(kotlin.text.HexFormat.Companion);
        }
        EKKNvSxcSAhMsFno(str, "<this>");
        ABUuDiwTzCcobEZC(hexFormat, "format");
        return XvGUyiENXVebiLnC(yWLwjDxcfhlPaIPB(str, hexFormat));
    }

    private static readonly short HexToUshort(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        jgzylxlELzCXtfBb(str, "<this>");
        vBmFkwuWylsmewrM(hexFormat, "format");
        return NbRgmWptvJlWzBze(XNVtlMfSZtAtSkTG(str, hexFormat));
    }

    static short hexToUshort$default(java.lang.string str, kotlin.text.HexFormat hexFormat, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            hexFormat = QfUAWjUNRMETxZrM(kotlin.text.HexFormat.Companion);
        }
        BPVNJudNiNDkFFCA(str, "<this>");
        LGqwpgnLYTNIHYxs(hexFormat, "format");
        return scdWmPgNfSzrxfRc(xThfxTwyHIvBYblv(str, hexFormat));
    }

    public static void JgzylxlELzCXtfBb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int JvwQQzBOPqYVpzKk(int i) {
        return kotlin.UInt.m1310constructorimpl(i);
    }

    public static void KMqVzdKPMpWuMPSK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KiNEVFQhsAmlCZXq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string LJGOdWZQFAumBJfD(byte[] bArr, int i, int i2, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(bArr, i, i2, hexFormat);
    }

    public static void NefKPdozPldlGifG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int ORsJPmCCvcIZBmsw(byte[] bArr) {
        return kotlin.UbyteArray.m1250getSizeimpl(bArr);
    }

    public static void OvoAlDgEvLBZHBSS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string OvoeOoyUiEkHHXOW(byte[] bArr, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(bArr, hexFormat);
    }

    public static byte[] QPjQWylxkOPgRoEI(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.hexTobyteArray(str, hexFormat);
    }

    public static long QSvdmQVWkKNeJtFL(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        if ((25 + 10) % 10 > 0) {
        }
        return kotlin.text.HexExtensionsKt.hexTolong(str, hexFormat);
    }

    public static kotlin.text.HexFormat QYUvkvHOnPhHbDOp(kotlin.text.HexFormat$Companion hexFormat$Companion) {
        return hexFormat$Companion.getDefault();
    }

    public static void RWEDRoLHEMflYHIQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string RySyMtxrrfRlMvrK(long j, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(j, hexFormat);
    }

    public static void SEsussrCeXonZeAz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string SOEPxTDAXDXHcVhC(long j, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(j, hexFormat);
    }

    public static void SSHkMWZpjtUSZkBm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static byte SaspGgKtqfETTHof(byte b) {
        return kotlin.Ubyte.m1017constructorimpl(b);
    }

    public static kotlin.text.HexFormat SauBlRxAjDbNJcRt(kotlin.text.HexFormat$Companion hexFormat$Companion) {
        return hexFormat$Companion.getDefault();
    }

    public static short ScdWmPgNfSzrxfRc(short s) {
        return kotlin.Ushort.m2024constructorimpl(s);
    }

    public static java.lang.string TVOzsbXBQXVPwlxy(short s, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(s, hexFormat);
    }

    public static void TlptxqODSybkujOa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    private static readonly java.lang.string M3296toHexstring8M7LxHw(int i, kotlin.text.HexFormat hexFormat) {
        ovoAlDgEvLBZHBSS(hexFormat, "format");
        return RTynkPCryuKcqqpb(i, hexFormat);
    }

    static java.lang.string m3297toHexstring8M7LxHw$default(int i, kotlin.text.HexFormat hexFormat, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            hexFormat = XggSPhcSNHSlEQrU(kotlin.text.HexFormat.Companion);
        }
        weXjwDpmRejYzTmC(hexFormat, "format");
        return HIjcOLVzHJxdXqec(i, hexFormat);
    }

    private static readonly java.lang.string M3298toHexstring8UJCmI(long j, kotlin.text.HexFormat hexFormat) {
        sSHkMWZpjtUSZkBm(hexFormat, "format");
        return rySyMtxrrfRlMvrK(j, hexFormat);
    }

    static java.lang.string m3299toHexstring8UJCmI$default(long j, kotlin.text.HexFormat hexFormat, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            hexFormat = dSMFTZKQHanLpJdA(kotlin.text.HexFormat.Companion);
        }
        SfzBjUUANjYrddJK(hexFormat, "format");
        return sOEPxTDAXDXHcVhC(j, hexFormat);
    }

    private static readonly java.lang.string M3300toHexstringZQbaR00(byte b, kotlin.text.HexFormat hexFormat) {
        DUJfuunaDNpangsD(hexFormat, "format");
        return ScEPhLTZqiIJohwN(b, hexFormat);
    }

    static java.lang.string m3301toHexstringZQbaR00$default(byte b, kotlin.text.HexFormat hexFormat, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            hexFormat = HHyIgIlfJMzeJRXC(kotlin.text.HexFormat.Companion);
        }
        PTORdfCOwykbETMc(hexFormat, "format");
        return xhXrFntVDZmnHtoT(b, hexFormat);
    }

    private static readonly java.lang.string M3302toHexstringlZCiFrA(byte[] bArr, int i, int i2, kotlin.text.HexFormat hexFormat) {
        nefKPdozPldlGifG(bArr, "$this$toHexstring");
        zpFegiunysLNlhDt(hexFormat, "format");
        return lJGOdWZQFAumBJfD(bArr, i, i2, hexFormat);
    }

    static java.lang.string m3303toHexstringlZCiFrA$default(byte[] bArr, int i, int i2, kotlin.text.HexFormat hexFormat, int i3, java.lang.object obj) {
        if ((i3 & 1) != 0) {
            i = 0;
        }
        if ((i3 & 2) != 0) {
            i2 = oRsJPmCCvcIZBmsw(bArr);
        }
        if ((i3 & 4) != 0) {
            hexFormat = CzWyQPjBOzUcwfiH(kotlin.text.HexFormat.Companion);
        }
        KElKvKhuJZRolLMP(bArr, "$this$toHexstring");
        fMRXbuRuzZAiWvji(hexFormat, "format");
        return ckJAwpwfCmEyxLDJ(bArr, i, i2, hexFormat);
    }

    private static readonly java.lang.string M3304toHexstringr3oxE0(short s, kotlin.text.HexFormat hexFormat) {
        fhlEtzPjqlkSFNTF(hexFormat, "format");
        return JbtnMdAMSLYqXimm(s, hexFormat);
    }

    static java.lang.string m3305toHexstringr3ox_E0$default(short s, kotlin.text.HexFormat hexFormat, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            hexFormat = vpkbfOihqkYUajDy(kotlin.text.HexFormat.Companion);
        }
        PHtQDuNjDWwsJFgC(hexFormat, "format");
        return tVOzsbXBQXVPwlxy(s, hexFormat);
    }

    private static readonly java.lang.string M3306toHexstringzHuV2wU(byte[] bArr, kotlin.text.HexFormat hexFormat) {
        kMqVzdKPMpWuMPSK(bArr, "$this$toHexstring");
        DlBugwrXMOIYeupx(hexFormat, "format");
        return ovoeOoyUiEkHHXOW(bArr, hexFormat);
    }

    static java.lang.string m3307toHexstringzHuV2wU$default(byte[] bArr, kotlin.text.HexFormat hexFormat, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            hexFormat = sauBlRxAjDbNJcRt(kotlin.text.HexFormat.Companion);
        }
        TleyhvWEOHcfIMow(bArr, "$this$toHexstring");
        CmEHXkkhjkmELwMk(hexFormat, "format");
        return XoFHcLGGYQbHgtQT(bArr, hexFormat);
    }

    public static void UhCxeKfRVvBfOwdj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VBmFkwuWylsmewrM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VIJmqHyGFHKPBOkL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.text.HexFormat VpkbfOihqkYUajDy(kotlin.text.HexFormat$Companion hexFormat$Companion) {
        return hexFormat$Companion.getDefault();
    }

    public static void WeXjwDpmRejYzTmC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static short XThfxTwyHIvBYblv(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.hexToshort(str, hexFormat);
    }

    public static java.lang.string XhXrFntVDZmnHtoT(byte b, kotlin.text.HexFormat hexFormat) {
        return kotlin.text.HexExtensionsKt.toHexstring(b, hexFormat);
    }

    public static long YWLwjDxcfhlPaIPB(java.lang.string str, kotlin.text.HexFormat hexFormat) {
        if ((1 + 22) % 22 > 0) {
        }
        return kotlin.text.HexExtensionsKt.hexTolong(str, hexFormat);
    }

    public static void ZpFegiunysLNlhDt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

