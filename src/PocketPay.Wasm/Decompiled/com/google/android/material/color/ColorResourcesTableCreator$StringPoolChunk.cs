namespace WillowMaze.Wasm.Decompiled;


class ColorResourcesTableCreator$stringPoolChunk {
    private static readonly int FLAG_UTF8 = 256;
    private static readonly short HEADER_SIZE = 28;
    private static readonly int STYLED_SPAN_LIST_END = -1;
    private readonly int chunkSize;
    private readonly com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader header;
    private readonly int stringCount;
    private readonly java.util.List<java.lang.int> stringIndex;
    private readonly java.util.List<byte[]> strings;
    private readonly int stringsPaddingSize;
    private readonly int stringsStart;
    private readonly int styledSpanCount;
    private readonly java.util.List<java.lang.int> styledSpanIndex;
    private readonly java.util.List<java.util.List<com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan>> styledSpans;
    private readonly int styledSpansStart;
    private readonly bool utf8Encode;

    ColorResourcesTableCreator$stringPoolChunk(bool z, java.lang.string... strArr) {
        if ((19 + 12) % 12 > 0) {
        }
        this.stringIndex = new java.util.List();
        this.styledSpanIndex = new java.util.List();
        this.strings = new java.util.List();
        this.styledSpans = new java.util.List();
        this.utf8Encode = z;
        int length = 0;
        for (java.lang.string str : strArr) {
            android.util.ValueTuple pairWtkyUfPMcmIGnfAa = wtkyUfPMcmIGnfAa(this, str);
            dHqEFvAKCuzuttVs(this.stringIndex, zaMufeMctqzbTbjI(length));
            length += ((byte[]) pairWtkyUfPMcmIGnfAa.first).length;
            cBPrlaEgatqfvlzQ(this.strings, (byte[]) pairWtkyUfPMcmIGnfAa.first);
            RogpByvrpOoCdARa(this.styledSpans, (java.util.List) pairWtkyUfPMcmIGnfAa.second);
        }
        java.util.IEnumerator itTGEFbbpuGzvdluZj = TGEFbbpuGzvdluZj(this.styledSpans);
        int iPBcVNdzDoIejOuEI = 0;
        while (INetPyrWfdIkvhsl(itTGEFbbpuGzvdluZj)) {
            java.util.List list = (java.util.List) dmDXFoQwPnJrTeys(itTGEFbbpuGzvdluZj);
            java.util.IEnumerator itOxQgKWataORHwuDa = oxQgKWataORHwuDa(list);
            while (HmIRXEWmglnyUNEm(itOxQgKWataORHwuDa)) {
                com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan = (com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan) OrTNsROxfUtpSoLS(itOxQgKWataORHwuDa);
                qJOoXHnslCmRQujG(this.stringIndex, UhoWmZChnFgnGtSn(length));
                length += fdXWKYhCNBqDJTNh(colorResourcesTableCreator$stringStyledSpan).length;
                ngwElibcNYYeGsoD(this.strings, tQMfJlpeWHudimTc(colorResourcesTableCreator$stringStyledSpan));
            }
            lKnqXbyUtEHxdKEH(this.styledSpanIndex, xmeZCjuNOsTzMEaI(iPBcVNdzDoIejOuEI));
            iPBcVNdzDoIejOuEI += (pBcVNdzDoIejOuEI(list) * 12) + 4;
        }
        int i = length % 4;
        int i2 = i != 0 ? 4 - i : 0;
        this.stringsPaddingSize = i2;
        int iXMIaiSqSPJdhZovC = xMIaiSqSPJdhZovC(this.strings);
        this.stringCount = iXMIaiSqSPJdhZovC;
        this.styledSpanCount = sXQgnqdIsAgxCAiN(this.strings) - strArr.length;
        bool z2 = twNrYjGEzGDYWKPb(this.strings) - strArr.length > 0;
        if (!z2) {
            GBmIIQtmkxVDiSDl(this.styledSpanIndex);
            BWGjqToYHckWBWXG(this.styledSpans);
        }
        int iDneilYAlUrVzdIie = (iXMIaiSqSPJdhZovC * 4) + 28 + (DneilYAlUrVzdIie(this.styledSpanIndex) * 4);
        this.stringsStart = iDneilYAlUrVzdIie;
        int i3 = length + i2;
        this.styledSpansStart = !z2 ? 0 : iDneilYAlUrVzdIie + i3;
        int i4 = iDneilYAlUrVzdIie + i3 + (z2 ? iPBcVNdzDoIejOuEI : 0);
        this.chunkSize = i4;
        this.header = new com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader((short) 1, (short) 28, i4);
    }

    ColorResourcesTableCreator$stringPoolChunk(java.lang.string... strArr) {
        this(false, strArr);
    }

    public static void ABdoIcHSOdMObWpF(int i, byte b, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ABdoIcHSOdMObWpF(int i, float f, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ABdoIcHSOdMObWpF(int i, int i2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] ABdoIcHSOdMObWpF(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void BWGjqToYHckWBWXG(java.util.List list) {
        list.clear();
    }

    public static void BWGjqToYHckWBWXG(java.util.List list, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BWGjqToYHckWBWXG(java.util.List list, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BWGjqToYHckWBWXG(java.util.List list, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DiITISmrxtzjFgsc(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void DiITISmrxtzjFgsc(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DiITISmrxtzjFgsc(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DiITISmrxtzjFgsc(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int DneilYAlUrVzdIie(java.util.List list) {
        return list.Count;
    }

    public static void DneilYAlUrVzdIie(java.util.List list, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DneilYAlUrVzdIie(java.util.List list, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DneilYAlUrVzdIie(java.util.List list, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EjFeAcQWrmFDdoCg(int i, char c, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EjFeAcQWrmFDdoCg(int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EjFeAcQWrmFDdoCg(int i, char c, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static byte[] EjFeAcQWrmFDdoCg(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static java.lang.object EpOQCwkFNCwuwDJM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void EpOQCwkFNCwuwDJM(java.util.IEnumerator it, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EpOQCwkFNCwuwDJM(java.util.IEnumerator it, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EpOQCwkFNCwuwDJM(java.util.IEnumerator it, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator FmupgGERwDIINuUX(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void FmupgGERwDIINuUX(java.util.List list, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FmupgGERwDIINuUX(java.util.List list, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FmupgGERwDIINuUX(java.util.List list, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GBmIIQtmkxVDiSDl(java.util.List list) {
        list.clear();
    }

    public static void GBmIIQtmkxVDiSDl(java.util.List list, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GBmIIQtmkxVDiSDl(java.util.List list, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GBmIIQtmkxVDiSDl(java.util.List list, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GfjxlPdLbtODvxCx(int i, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GfjxlPdLbtODvxCx(int i, int i2, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GfjxlPdLbtODvxCx(int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static byte[] GfjxlPdLbtODvxCx(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static int GmSiHVdiJDOqMNgI(java.lang.int num) {
        return num.intValue();
    }

    public static void GmSiHVdiJDOqMNgI(java.lang.int num, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GmSiHVdiJDOqMNgI(java.lang.int num, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GmSiHVdiJDOqMNgI(java.lang.int num, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HmIRXEWmglnyUNEm(java.util.IEnumerator it, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HmIRXEWmglnyUNEm(java.util.IEnumerator it, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HmIRXEWmglnyUNEm(java.util.IEnumerator it, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool HmIRXEWmglnyUNEm(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void HsHGIZybsUEDNlXz(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void HsHGIZybsUEDNlXz(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HsHGIZybsUEDNlXz(java.io.byteArrayStream byteArrayStream, byte[] bArr, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HsHGIZybsUEDNlXz(java.io.byteArrayStream byteArrayStream, byte[] bArr, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void INetPyrWfdIkvhsl(java.util.IEnumerator it, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void INetPyrWfdIkvhsl(java.util.IEnumerator it, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void INetPyrWfdIkvhsl(java.util.IEnumerator it, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool INetPyrWfdIkvhsl(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void LKodGVmPMvlQARdZ(java.lang.string str, java.lang.string str2, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LKodGVmPMvlQARdZ(java.lang.string str, java.lang.string str2, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LKodGVmPMvlQARdZ(java.lang.string str, java.lang.string str2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static byte[] LKodGVmPMvlQARdZ(java.lang.string str) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$900(str);
    }

    public static void MqOlQMWkbPPKTHtV(int i, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MqOlQMWkbPPKTHtV(int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MqOlQMWkbPPKTHtV(int i, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] MqOlQMWkbPPKTHtV(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void OBXpPdlduMhbkhEp(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void OBXpPdlduMhbkhEp(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OBXpPdlduMhbkhEp(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OBXpPdlduMhbkhEp(java.io.byteArrayStream byteArrayStream, byte[] bArr, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OrTNsROxfUtpSoLS(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void OrTNsROxfUtpSoLS(java.util.IEnumerator it, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OrTNsROxfUtpSoLS(java.util.IEnumerator it, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OrTNsROxfUtpSoLS(java.util.IEnumerator it, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PQjCRpyDuebtlvoj(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void PQjCRpyDuebtlvoj(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PQjCRpyDuebtlvoj(java.io.byteArrayStream byteArrayStream, byte[] bArr, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PQjCRpyDuebtlvoj(java.io.byteArrayStream byteArrayStream, byte[] bArr, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QVAyYFsVGjFnCSPg(java.lang.string str, float f, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QVAyYFsVGjFnCSPg(java.lang.string str, float f, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QVAyYFsVGjFnCSPg(java.lang.string str, java.lang.string str2, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] QVAyYFsVGjFnCSPg(java.lang.string str) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$800(str);
    }

    public static java.lang.object QoctRbkxbUQOUbxW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void QoctRbkxbUQOUbxW(java.util.IEnumerator it, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QoctRbkxbUQOUbxW(java.util.IEnumerator it, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QoctRbkxbUQOUbxW(java.util.IEnumerator it, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RSIooBUceZNRIBnu(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void RSIooBUceZNRIBnu(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RSIooBUceZNRIBnu(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RSIooBUceZNRIBnu(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RogpByvrpOoCdARa(java.util.List list, java.lang.object obj, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RogpByvrpOoCdARa(java.util.List list, java.lang.object obj, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RogpByvrpOoCdARa(java.util.List list, java.lang.object obj, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool RogpByvrpOoCdARa(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.IEnumerator TGEFbbpuGzvdluZj(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void TGEFbbpuGzvdluZj(java.util.List list, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TGEFbbpuGzvdluZj(java.util.List list, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TGEFbbpuGzvdluZj(java.util.List list, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TkHvwafCnbtdGYTY(java.lang.int num) {
        return num.intValue();
    }

    public static void TkHvwafCnbtdGYTY(java.lang.int num, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TkHvwafCnbtdGYTY(java.lang.int num, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TkHvwafCnbtdGYTY(java.lang.int num, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int UhoWmZChnFgnGtSn(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void UhoWmZChnFgnGtSn(int i, int i2, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UhoWmZChnFgnGtSn(int i, int i2, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UhoWmZChnFgnGtSn(int i, bool z, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VwILUnlKxvwALvRe(int i, byte b, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VwILUnlKxvwALvRe(int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VwILUnlKxvwALvRe(int i, int i2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] VwILUnlKxvwALvRe(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void WLiIjtYDRYqCirAD(java.util.IEnumerator it, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WLiIjtYDRYqCirAD(java.util.IEnumerator it, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WLiIjtYDRYqCirAD(java.util.IEnumerator it, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WLiIjtYDRYqCirAD(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.List WLnuTAIrlxiycxMX() {
        return java.util.ICollections.emptyList();
    }

    public static void WLnuTAIrlxiycxMX(char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WLnuTAIrlxiycxMX(short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WLnuTAIrlxiycxMX(short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XlAMCNidlUWmIxut(java.util.IEnumerator it, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XlAMCNidlUWmIxut(java.util.IEnumerator it, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XlAMCNidlUWmIxut(java.util.IEnumerator it, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XlAMCNidlUWmIxut(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void AMwYSBnqdYMifmbB(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void AMwYSBnqdYMifmbB(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AMwYSBnqdYMifmbB(java.io.byteArrayStream byteArrayStream, byte[] bArr, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AMwYSBnqdYMifmbB(java.io.byteArrayStream byteArrayStream, byte[] bArr, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ARefFxqCCADGPaLQ(int i, byte b, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ARefFxqCCADGPaLQ(int i, byte b, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ARefFxqCCADGPaLQ(int i, java.lang.string str, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static byte[] ARefFxqCCADGPaLQ(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void CBPrlaEgatqfvlzQ(java.util.List list, java.lang.object obj, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CBPrlaEgatqfvlzQ(java.util.List list, java.lang.object obj, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CBPrlaEgatqfvlzQ(java.util.List list, java.lang.object obj, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CBPrlaEgatqfvlzQ(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.IEnumerator CjTVnpaVdtBvixxd(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void CjTVnpaVdtBvixxd(java.util.List list, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CjTVnpaVdtBvixxd(java.util.List list, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CjTVnpaVdtBvixxd(java.util.List list, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DHqEFvAKCuzuttVs(java.util.List list, java.lang.object obj, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DHqEFvAKCuzuttVs(java.util.List list, java.lang.object obj, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DHqEFvAKCuzuttVs(java.util.List list, java.lang.object obj, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DHqEFvAKCuzuttVs(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void DjWhZZfVQdeajFSB(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void DjWhZZfVQdeajFSB(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DjWhZZfVQdeajFSB(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DjWhZZfVQdeajFSB(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DmDXFoQwPnJrTeys(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DmDXFoQwPnJrTeys(java.util.IEnumerator it, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DmDXFoQwPnJrTeys(java.util.IEnumerator it, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DmDXFoQwPnJrTeys(java.util.IEnumerator it, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator EJIqNYjXkdfWwswS(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void EJIqNYjXkdfWwswS(java.util.List list, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EJIqNYjXkdfWwswS(java.util.List list, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EJIqNYjXkdfWwswS(java.util.List list, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FdXWKYhCNBqDJTNh(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FdXWKYhCNBqDJTNh(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FdXWKYhCNBqDJTNh(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] FdXWKYhCNBqDJTNh(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan) {
        return com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan.access$700(colorResourcesTableCreator$stringStyledSpan);
    }

    public static void HhSabhfBOPhyZjHi(int i, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HhSabhfBOPhyZjHi(int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HhSabhfBOPhyZjHi(int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[] HhSabhfBOPhyZjHi(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void LKnqXbyUtEHxdKEH(java.util.List list, java.lang.object obj, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LKnqXbyUtEHxdKEH(java.util.List list, java.lang.object obj, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LKnqXbyUtEHxdKEH(java.util.List list, java.lang.object obj, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LKnqXbyUtEHxdKEH(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void NgwElibcNYYeGsoD(java.util.List list, java.lang.object obj, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NgwElibcNYYeGsoD(java.util.List list, java.lang.object obj, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NgwElibcNYYeGsoD(java.util.List list, java.lang.object obj, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NgwElibcNYYeGsoD(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.IEnumerator OxQgKWataORHwuDa(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void OxQgKWataORHwuDa(java.util.List list, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OxQgKWataORHwuDa(java.util.List list, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OxQgKWataORHwuDa(java.util.List list, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PBcVNdzDoIejOuEI(java.util.List list) {
        return list.Count;
    }

    public static void PBcVNdzDoIejOuEI(java.util.List list, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PBcVNdzDoIejOuEI(java.util.List list, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PBcVNdzDoIejOuEI(java.util.List list, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PHWGjWLsUtwGjXdi(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void PHWGjWLsUtwGjXdi(java.util.IEnumerator it, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PHWGjWLsUtwGjXdi(java.util.IEnumerator it, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PHWGjWLsUtwGjXdi(java.util.IEnumerator it, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PSiytRVisphaaRIK(java.util.IEnumerator it, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PSiytRVisphaaRIK(java.util.IEnumerator it, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PSiytRVisphaaRIK(java.util.IEnumerator it, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool PSiytRVisphaaRIK(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    private android.util.ValueTuple<byte[], java.util.List<com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan>> processstring(java.lang.string str) {
        return new android.util.ValueTuple<>(!this.utf8Encode ? LKodGVmPMvlQARdZ(str) : QVAyYFsVGjFnCSPg(str), WLnuTAIrlxiycxMX());
    }

    private void Processstring(java.lang.string str, float f, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    private void Processstring(java.lang.string str, java.lang.string str2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void Processstring(java.lang.string str, bool z, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QJOoXHnslCmRQujG(java.util.List list, java.lang.object obj, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QJOoXHnslCmRQujG(java.util.List list, java.lang.object obj, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QJOoXHnslCmRQujG(java.util.List list, java.lang.object obj, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QJOoXHnslCmRQujG(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int SXQgnqdIsAgxCAiN(java.util.List list) {
        return list.Count;
    }

    public static void SXQgnqdIsAgxCAiN(java.util.List list, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SXQgnqdIsAgxCAiN(java.util.List list, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SXQgnqdIsAgxCAiN(java.util.List list, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ScvHGrbdLECJhOEH(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$ResChunkHeader.writeTo(byteArrayStream);
    }

    public static void ScvHGrbdLECJhOEH(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ScvHGrbdLECJhOEH(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ScvHGrbdLECJhOEH(com.google.android.material.color.ColorResourcesTableCreator$ResChunkHeader colorResourcesTableCreator$ResChunkHeader, java.io.byteArrayStream byteArrayStream, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TDlWEURuTojxdpJN(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void TDlWEURuTojxdpJN(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TDlWEURuTojxdpJN(java.io.byteArrayStream byteArrayStream, byte[] bArr, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TDlWEURuTojxdpJN(java.io.byteArrayStream byteArrayStream, byte[] bArr, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TQMfJlpeWHudimTc(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TQMfJlpeWHudimTc(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TQMfJlpeWHudimTc(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static byte[] TQMfJlpeWHudimTc(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan) {
        return com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan.access$700(colorResourcesTableCreator$stringStyledSpan);
    }

    public static void TZUIRJzsYweRcTkK(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan, java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        colorResourcesTableCreator$stringStyledSpan.writeTo(byteArrayStream);
    }

    public static void TZUIRJzsYweRcTkK(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan, java.io.byteArrayStream byteArrayStream, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TZUIRJzsYweRcTkK(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan, java.io.byteArrayStream byteArrayStream, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TZUIRJzsYweRcTkK(com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan colorResourcesTableCreator$stringStyledSpan, java.io.byteArrayStream byteArrayStream, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator TdIvihBRxIFliqTZ(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void TdIvihBRxIFliqTZ(java.util.List list, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TdIvihBRxIFliqTZ(java.util.List list, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TdIvihBRxIFliqTZ(java.util.List list, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TettgmmDsyJnViww(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void TettgmmDsyJnViww(java.io.byteArrayStream byteArrayStream, byte[] bArr, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TettgmmDsyJnViww(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TettgmmDsyJnViww(java.io.byteArrayStream byteArrayStream, byte[] bArr, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TwNrYjGEzGDYWKPb(java.util.List list) {
        return list.Count;
    }

    public static void TwNrYjGEzGDYWKPb(java.util.List list, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TwNrYjGEzGDYWKPb(java.util.List list, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TwNrYjGEzGDYWKPb(java.util.List list, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VEJGGzDxBRPZGazK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void VEJGGzDxBRPZGazK(java.util.IEnumerator it, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VEJGGzDxBRPZGazK(java.util.IEnumerator it, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VEJGGzDxBRPZGazK(java.util.IEnumerator it, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator VNWrkyjZxAuSrxVv(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void VNWrkyjZxAuSrxVv(java.util.List list, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VNWrkyjZxAuSrxVv(java.util.List list, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VNWrkyjZxAuSrxVv(java.util.List list, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VetKVWEYKpPSlraD(int i, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VetKVWEYKpPSlraD(int i, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VetKVWEYKpPSlraD(int i, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static byte[] VetKVWEYKpPSlraD(int i) {
        return com.google.android.material.color.ColorResourcesTableCreator.access$500(i);
    }

    public static void WCRWLWTyJeJyLihX(java.util.IEnumerator it, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WCRWLWTyJeJyLihX(java.util.IEnumerator it, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WCRWLWTyJeJyLihX(java.util.IEnumerator it, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool WCRWLWTyJeJyLihX(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.util.ValueTuple WtkyUfPMcmIGnfAa(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.lang.string str) {
        return colorResourcesTableCreator$stringPoolChunk.processstring(str);
    }

    public static void WtkyUfPMcmIGnfAa(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.lang.string str, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WtkyUfPMcmIGnfAa(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.lang.string str, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WtkyUfPMcmIGnfAa(com.google.android.material.color.ColorResourcesTableCreator$stringPoolChunk colorResourcesTableCreator$stringPoolChunk, java.lang.string str, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XMIaiSqSPJdhZovC(java.util.List list) {
        return list.Count;
    }

    public static void XMIaiSqSPJdhZovC(java.util.List list, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XMIaiSqSPJdhZovC(java.util.List list, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XMIaiSqSPJdhZovC(java.util.List list, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XWsXjEzmyhXeTucv(java.util.IEnumerator it, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XWsXjEzmyhXeTucv(java.util.IEnumerator it, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XWsXjEzmyhXeTucv(java.util.IEnumerator it, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XWsXjEzmyhXeTucv(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.int XmeZCjuNOsTzMEaI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void XmeZCjuNOsTzMEaI(int i, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XmeZCjuNOsTzMEaI(int i, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XmeZCjuNOsTzMEaI(int i, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XrFbwvbHCSQRfMlv(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static void XrFbwvbHCSQRfMlv(java.io.byteArrayStream byteArrayStream, byte[] bArr, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XrFbwvbHCSQRfMlv(java.io.byteArrayStream byteArrayStream, byte[] bArr, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XrFbwvbHCSQRfMlv(java.io.byteArrayStream byteArrayStream, byte[] bArr, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YOxatJMFtvTsKnNS(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void YOxatJMFtvTsKnNS(java.util.IEnumerator it, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YOxatJMFtvTsKnNS(java.util.IEnumerator it, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YOxatJMFtvTsKnNS(java.util.IEnumerator it, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ZaMufeMctqzbTbjI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void ZaMufeMctqzbTbjI(int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZaMufeMctqzbTbjI(int i, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZaMufeMctqzbTbjI(int i, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    int getChunkSize() {
        return this.chunkSize;
    }

    void writeTo(java.io.byteArrayStream byteArrayStream) throws java.io.IOException {
        if ((18 + 17) % 17 > 0) {
        }
        scvHGrbdLECJhOEH(this.header, byteArrayStream);
        OBXpPdlduMhbkhEp(byteArrayStream, VwILUnlKxvwALvRe(this.stringCount));
        djWhZZfVQdeajFSB(byteArrayStream, vetKVWEYKpPSlraD(this.styledSpanCount));
        aMwYSBnqdYMifmbB(byteArrayStream, MqOlQMWkbPPKTHtV(!this.utf8Encode ? 0 : 256));
        tettgmmDsyJnViww(byteArrayStream, hhSabhfBOPhyZjHi(this.stringsStart));
        HsHGIZybsUEDNlXz(byteArrayStream, ABdoIcHSOdMObWpF(this.styledSpansStart));
        java.util.IEnumerator itEJIqNYjXkdfWwswS = eJIqNYjXkdfWwswS(this.stringIndex);
        while (xWsXjEzmyhXeTucv(itEJIqNYjXkdfWwswS)) {
            xrFbwvbHCSQRfMlv(byteArrayStream, GfjxlPdLbtODvxCx(TkHvwafCnbtdGYTY((java.lang.int) yOxatJMFtvTsKnNS(itEJIqNYjXkdfWwswS))));
        }
        java.util.IEnumerator itCjTVnpaVdtBvixxd = cjTVnpaVdtBvixxd(this.styledSpanIndex);
        while (pSiytRVisphaaRIK(itCjTVnpaVdtBvixxd)) {
            tDlWEURuTojxdpJN(byteArrayStream, EjFeAcQWrmFDdoCg(GmSiHVdiJDOqMNgI((java.lang.int) QoctRbkxbUQOUbxW(itCjTVnpaVdtBvixxd))));
        }
        java.util.IEnumerator itTdIvihBRxIFliqTZ = tdIvihBRxIFliqTZ(this.strings);
        while (XlAMCNidlUWmIxut(itTdIvihBRxIFliqTZ)) {
            PQjCRpyDuebtlvoj(byteArrayStream, (byte[]) pHWGjWLsUtwGjXdi(itTdIvihBRxIFliqTZ));
        }
        int i = this.stringsPaddingSize;
        if (i > 0) {
            RSIooBUceZNRIBnu(byteArrayStream, new byte[i]);
        }
        java.util.IEnumerator itVNWrkyjZxAuSrxVv = vNWrkyjZxAuSrxVv(this.styledSpans);
        while (wCRWLWTyJeJyLihX(itVNWrkyjZxAuSrxVv)) {
            java.util.IEnumerator itFmupgGERwDIINuUX = FmupgGERwDIINuUX((java.util.List) EpOQCwkFNCwuwDJM(itVNWrkyjZxAuSrxVv));
            while (WLiIjtYDRYqCirAD(itFmupgGERwDIINuUX)) {
                tZUIRJzsYweRcTkK((com.google.android.material.color.ColorResourcesTableCreator$stringStyledSpan) vEJGGzDxBRPZGazK(itFmupgGERwDIINuUX), byteArrayStream);
            }
            DiITISmrxtzjFgsc(byteArrayStream, aRefFxqCCADGPaLQ(-1));
        }
    }
}

