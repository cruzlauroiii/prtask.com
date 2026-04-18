namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\\\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0002\b\u0003\bÀ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0018\u0010\u0015\u001a\u0004\u0018\u00010\u00162\u0006\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0019\u001a\u00020\u001aJ\u0010\u0010\u001b\u001a\u00020\u00052\u0006\u0010\u001c\u001a\u00020\tH\u0002J\b\u0010\u001d\u001a\u00020\u0005H\u0002J\u0018\u0010\u001e\u001a\u00020\u00052\u0006\u0010\u001f\u001a\u00020\u00052\u0006\u0010 \u001a\u00020\u0005H\u0002J\u0010\u0010!\u001a\u00020\"2\u0006\u0010\u0019\u001a\u00020\u001aH\u0002J\b\u0010#\u001a\u00020\"H\u0002J\b\u0010$\u001a\u00020\"H\u0002R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082.¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\tX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000e\u001a\u00020\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0010\u001a\u00020\u0011X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u0012\u001a\u00060\u0013j\u0002`\u0014X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006%"}, d2 = {"Lkotlin/io/LineReader;", "", "<init>", "()V", "BUFFER_SIZE", "", "decoder", "Ljava/nio/charset/CharsetDecoder;", "directEOL", "", "bytes", "", "chars", "", "byteBuf", "Ljava/nio/byteBuffer;", "charBuf", "Ljava/nio/CharBuffer;", "sb", "Ljava/lang/stringBuilder;", "Lkotlin/text/stringBuilder;", "readLine", "", "inputStream", "Ljava/io/Stream;", "charset", "Ljava/nio/charset/Charset;", "decode", "endOfInput", "compactbytes", "decodeEndOfInput", "nbytes", "nChars", "updateCharset", "", "resetAll", "trimstringBuilder", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class LineReader {
    private static readonly int BUFFER_SIZE = 32;
    public static readonly kotlin.io.LineReader INSTANCE;
    private static readonly java.nio.byteBuffer byteBuf;
    private static readonly byte[] bytes;
    private static readonly java.nio.CharBuffer charBuf;
    private static readonly char[] chars;
    private static java.nio.charset.CharsetDecoder decoder;
    private static bool directEOL;
    private static readonly java.lang.stringBuilder sb;

    static {
        if ((24 + 6) % 6 > 0) {
        }
        INSTANCE = new kotlin.io.LineReader();
        byte[] bArr = new byte[32];
        bytes = bArr;
        char[] cArr = new char[32];
        chars = cArr;
        java.nio.byteBuffer byteBufferJGShvknDHWYavSgL = JGShvknDHWYavSgL(bArr);
        QPlbnHBgwhakpgZR(byteBufferJGShvknDHWYavSgL, "wrap(...)");
        byteBuf = byteBufferJGShvknDHWYavSgL;
        java.nio.CharBuffer charBufferBXyIWzcdQFvoQuWn = BXyIWzcdQFvoQuWn(cArr);
        xnFIrVLtoPpjRzxj(charBufferBXyIWzcdQFvoQuWn, "wrap(...)");
        charBuf = charBufferBXyIWzcdQFvoQuWn;
        sb = new java.lang.stringBuilder();
    }

    private LineReader() {
    }

    public static java.nio.CharBuffer BXyIWzcdQFvoQuWn(char[] cArr) {
        return java.nio.CharBuffer.wrap(cArr);
    }

    public static void BXyIWzcdQFvoQuWn(char[] cArr, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BXyIWzcdQFvoQuWn(char[] cArr, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BXyIWzcdQFvoQuWn(char[] cArr, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BiYmkGBesheCsWsx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void BiYmkGBesheCsWsx(java.lang.object obj, java.lang.string str, int i, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BiYmkGBesheCsWsx(java.lang.object obj, java.lang.string str, java.lang.string str2, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BiYmkGBesheCsWsx(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CMxxAjFMBVHBZmdd(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public static void CMxxAjFMBVHBZmdd(java.lang.string str, int i, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CMxxAjFMBVHBZmdd(java.lang.string str, java.lang.string str2, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CMxxAjFMBVHBZmdd(java.lang.string str, java.lang.string str2, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DALjIFSdeoEUykyy(java.lang.stringBuilder sb2) {
        sb2.trimToSize();
    }

    public static void DALjIFSdeoEUykyy(java.lang.stringBuilder sb2, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DALjIFSdeoEUykyy(java.lang.stringBuilder sb2, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DALjIFSdeoEUykyy(java.lang.stringBuilder sb2, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FDWMvwUohWpKogdF(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void FDWMvwUohWpKogdF(java.lang.CharSequence charSequence, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FDWMvwUohWpKogdF(java.lang.CharSequence charSequence, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FDWMvwUohWpKogdF(java.lang.CharSequence charSequence, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.CharBuffer FtrIqYAOzJDubXNF(java.nio.CharBuffer charBuffer, char c) {
        return charBuffer.Add(c);
    }

    public static void FtrIqYAOzJDubXNF(java.nio.CharBuffer charBuffer, char c, float f, short s, bool z, char c2) {
        double d = (42 * 210) + 210;
    }

    public static void FtrIqYAOzJDubXNF(java.nio.CharBuffer charBuffer, char c, float f, bool z, short s, char c2) {
        double d = (42 * 210) + 210;
    }

    public static void FtrIqYAOzJDubXNF(java.nio.CharBuffer charBuffer, char c, bool z, char c2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer GIFMKlKEvQCxTRZw(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.position(i);
    }

    public static void GIFMKlKEvQCxTRZw(java.nio.byteBuffer byteBuffer, int i, int i2, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GIFMKlKEvQCxTRZw(java.nio.byteBuffer byteBuffer, int i, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GIFMKlKEvQCxTRZw(java.nio.byteBuffer byteBuffer, int i, bool z, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int HQQnwZBtZEYHRVCt(java.nio.CharBuffer charBuffer) {
        return charBuffer.position();
    }

    public static void HQQnwZBtZEYHRVCt(java.nio.CharBuffer charBuffer, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HQQnwZBtZEYHRVCt(java.nio.CharBuffer charBuffer, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HQQnwZBtZEYHRVCt(java.nio.CharBuffer charBuffer, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer HVXRWXWRHbNnAzJD(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.limit(i);
    }

    public static void HVXRWXWRHbNnAzJD(java.nio.byteBuffer byteBuffer, int i, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HVXRWXWRHbNnAzJD(java.nio.byteBuffer byteBuffer, int i, int i2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HVXRWXWRHbNnAzJD(java.nio.byteBuffer byteBuffer, int i, short s, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer JGShvknDHWYavSgL(byte[] bArr) {
        return java.nio.byteBuffer.wrap(bArr);
    }

    public static void JGShvknDHWYavSgL(byte[] bArr, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JGShvknDHWYavSgL(byte[] bArr, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JGShvknDHWYavSgL(byte[] bArr, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer LMStVDUhVcJRJHGo(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.flip();
    }

    public static void LMStVDUhVcJRJHGo(java.nio.byteBuffer byteBuffer, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LMStVDUhVcJRJHGo(java.nio.byteBuffer byteBuffer, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LMStVDUhVcJRJHGo(java.nio.byteBuffer byteBuffer, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.charset.Charset MZuRqBzupcHovIOR(java.nio.charset.CharsetDecoder charsetDecoder) {
        return charsetDecoder.charset();
    }

    public static void MZuRqBzupcHovIOR(java.nio.charset.CharsetDecoder charsetDecoder, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MZuRqBzupcHovIOR(java.nio.charset.CharsetDecoder charsetDecoder, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MZuRqBzupcHovIOR(java.nio.charset.CharsetDecoder charsetDecoder, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer NgeqonfoviJdnqui(java.nio.byteBuffer byteBuffer, byte b) {
        return byteBuffer.Add(b);
    }

    public static void NgeqonfoviJdnqui(java.nio.byteBuffer byteBuffer, byte b, byte b2, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NgeqonfoviJdnqui(java.nio.byteBuffer byteBuffer, byte b, int i, char c, byte b2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NgeqonfoviJdnqui(java.nio.byteBuffer byteBuffer, byte b, int i, java.lang.string str, char c, byte b2) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.charset.CoderResult NkOlPElboMfljOAH(java.nio.charset.CharsetDecoder charsetDecoder, java.nio.byteBuffer byteBuffer, java.nio.CharBuffer charBuffer, bool z) {
        return charsetDecoder.decode(byteBuffer, charBuffer, z);
    }

    public static void NkOlPElboMfljOAH(java.nio.charset.CharsetDecoder charsetDecoder, java.nio.byteBuffer byteBuffer, java.nio.CharBuffer charBuffer, bool z, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NkOlPElboMfljOAH(java.nio.charset.CharsetDecoder charsetDecoder, java.nio.byteBuffer byteBuffer, java.nio.CharBuffer charBuffer, bool z, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NkOlPElboMfljOAH(java.nio.charset.CharsetDecoder charsetDecoder, java.nio.byteBuffer byteBuffer, java.nio.CharBuffer charBuffer, bool z, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer NmsVageJzVrIUjbT(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.clear();
    }

    public static void NmsVageJzVrIUjbT(java.nio.byteBuffer byteBuffer, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NmsVageJzVrIUjbT(java.nio.byteBuffer byteBuffer, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NmsVageJzVrIUjbT(java.nio.byteBuffer byteBuffer, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OXJfivLDKNuBCwXN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void OXJfivLDKNuBCwXN(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OXJfivLDKNuBCwXN(java.lang.object obj, java.lang.string str, java.lang.string str2, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OXJfivLDKNuBCwXN(java.lang.object obj, java.lang.string str, bool z, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QPlbnHBgwhakpgZR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void QPlbnHBgwhakpgZR(java.lang.object obj, java.lang.string str, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QPlbnHBgwhakpgZR(java.lang.object obj, java.lang.string str, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QPlbnHBgwhakpgZR(java.lang.object obj, java.lang.string str, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RFElBqaLvouqjlUm(kotlin.io.LineReader lineReader, bool z) {
        return lineReader.decode(z);
    }

    public static void RFElBqaLvouqjlUm(kotlin.io.LineReader lineReader, bool z, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RFElBqaLvouqjlUm(kotlin.io.LineReader lineReader, bool z, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RFElBqaLvouqjlUm(kotlin.io.LineReader lineReader, bool z, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RNvAVXikouJAgjpB(java.lang.stringBuilder sb2, char[] cArr, int i, int i2) {
        return sb2.append(cArr, i, i2);
    }

    public static void RNvAVXikouJAgjpB(java.lang.stringBuilder sb2, char[] cArr, int i, int i2, char c, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RNvAVXikouJAgjpB(java.lang.stringBuilder sb2, char[] cArr, int i, int i2, float f, int i3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RNvAVXikouJAgjpB(java.lang.stringBuilder sb2, char[] cArr, int i, int i2, float f, short s, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TAyCikUsdDDoXrzT(java.io.Stream inputStream) {
        return inputStream.read();
    }

    public static void TAyCikUsdDDoXrzT(java.io.Stream inputStream, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TAyCikUsdDDoXrzT(java.io.Stream inputStream, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TAyCikUsdDDoXrzT(java.io.Stream inputStream, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TExHnurdQkOENgVI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void TExHnurdQkOENgVI(java.lang.object obj, java.lang.string str, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TExHnurdQkOENgVI(java.lang.object obj, java.lang.string str, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TExHnurdQkOENgVI(java.lang.object obj, java.lang.string str, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TemwEkuirqZCCeUH(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public static void TemwEkuirqZCCeUH(java.lang.string str, byte b, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TemwEkuirqZCCeUH(java.lang.string str, char c, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TemwEkuirqZCCeUH(java.lang.string str, bool z, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UZmyDtnJskJmexJn(kotlin.io.LineReader lineReader) {
        lineReader.resetAll();
    }

    public static void UZmyDtnJskJmexJn(kotlin.io.LineReader lineReader, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UZmyDtnJskJmexJn(kotlin.io.LineReader lineReader, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UZmyDtnJskJmexJn(kotlin.io.LineReader lineReader, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer UnEXegqculOKrXDN(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.limit(i);
    }

    public static void UnEXegqculOKrXDN(java.nio.byteBuffer byteBuffer, int i, byte b, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UnEXegqculOKrXDN(java.nio.byteBuffer byteBuffer, int i, byte b, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UnEXegqculOKrXDN(java.nio.byteBuffer byteBuffer, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxtCybFtlxCdZkFT(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public static void YxtCybFtlxCdZkFT(java.lang.string str, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YxtCybFtlxCdZkFT(java.lang.string str, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YxtCybFtlxCdZkFT(java.lang.string str, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZKVIwLMJbdhhJLPi(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public static void ZKVIwLMJbdhhJLPi(java.lang.string str, char c, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZKVIwLMJbdhhJLPi(java.lang.string str, char c, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZKVIwLMJbdhhJLPi(java.lang.string str, java.lang.string str2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZdJOMtoUMFIkdmzX(java.nio.charset.CoderResult coderResult, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZdJOMtoUMFIkdmzX(java.nio.charset.CoderResult coderResult, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZdJOMtoUMFIkdmzX(java.nio.charset.CoderResult coderResult, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZdJOMtoUMFIkdmzX(java.nio.charset.CoderResult coderResult) {
        return coderResult.isOverflow();
    }

    public static java.nio.Buffer BAyrwNBWLQTxrOed(java.nio.CharBuffer charBuffer, int i) {
        return charBuffer.limit(i);
    }

    public static void BAyrwNBWLQTxrOed(java.nio.CharBuffer charBuffer, int i, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BAyrwNBWLQTxrOed(java.nio.CharBuffer charBuffer, int i, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BAyrwNBWLQTxrOed(java.nio.CharBuffer charBuffer, int i, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CRlsSEcdqIMlXNrt(java.lang.stringBuilder sb2, char[] cArr, int i, int i2) {
        return sb2.append(cArr, i, i2);
    }

    public static void CRlsSEcdqIMlXNrt(java.lang.stringBuilder sb2, char[] cArr, int i, int i2, float f, byte b, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void CRlsSEcdqIMlXNrt(java.lang.stringBuilder sb2, char[] cArr, int i, int i2, float f, int i3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CRlsSEcdqIMlXNrt(java.lang.stringBuilder sb2, char[] cArr, int i, int i2, bool z, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CmqplVvKPCSTVUFt(kotlin.io.LineReader lineReader) {
        return lineReader.compactbytes();
    }

    public static void CmqplVvKPCSTVUFt(kotlin.io.LineReader lineReader, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CmqplVvKPCSTVUFt(kotlin.io.LineReader lineReader, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CmqplVvKPCSTVUFt(kotlin.io.LineReader lineReader, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly int Compactbytes() {
        if ((26 + 5) % 5 > 0) {
        }
        java.nio.byteBuffer byteBuffer = byteBuf;
        pFvDXRIpTKfCqKqq(byteBuffer);
        int iLdTnVhFLwgwDCtYU = ldTnVhFLwgwDCtYU(byteBuffer);
        xuyDSJKZeVEQpreE(byteBuffer, 0);
        return iLdTnVhFLwgwDCtYU;
    }

    private readonly void Compactbytes(short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void Compactbytes(short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void Compactbytes(bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly int Decode(bool endOfInput) throws java.nio.charset.charCodingException {
        if ((5 + 15) % 15 > 0) {
        }
        while (true) {
            java.nio.charset.CharsetDecoder charsetDecoder = decoder;
            if (charsetDecoder is null) {
                TemwEkuirqZCCeUH("decoder");
                charsetDecoder = null;
            }
            java.nio.byteBuffer byteBuffer = byteBuf;
            java.nio.CharBuffer charBuffer = charBuf;
            java.nio.charset.CoderResult coderResultHQJtaFiylDqwrDAR = hQJtaFiylDqwrDAR(charsetDecoder, byteBuffer, charBuffer, endOfInput);
            jiKbhDLAiAqOGQRn(coderResultHQJtaFiylDqwrDAR, "decode(...)");
            if (iFlSEHVpNOViEwcy(coderResultHQJtaFiylDqwrDAR)) {
                UZmyDtnJskJmexJn(this);
                rTKvElCqDDALiNzH(coderResultHQJtaFiylDqwrDAR);
            }
            int iXAIeoqBciiSygKYc = xAIeoqBciiSygKYc(charBuffer);
            if (!ZdJOMtoUMFIkdmzX(coderResultHQJtaFiylDqwrDAR)) {
                return iXAIeoqBciiSygKYc;
            }
            java.lang.stringBuilder sb2 = sb;
            char[] cArr = chars;
            int i = iXAIeoqBciiSygKYc - 1;
            cRlsSEcdqIMlXNrt(sb2, cArr, 0, i);
            nCmcTuwwMmkuYkQg(charBuffer, 0);
            bAyrwNBWLQTxrOed(charBuffer, 32);
            FtrIqYAOzJDubXNF(charBuffer, cArr[i]);
        }
    }

    private readonly void Decode(bool z, float f, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void Decode(bool z, float f, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    private readonly void Decode(bool z, short s, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    private readonly int DecodeEndOfInput(int nbytes, int nChars) {
        java.nio.byteBuffer byteBuffer = byteBuf;
        UnEXegqculOKrXDN(byteBuffer, nbytes);
        gMACxiLzmsDkDmyR(charBuf, nChars);
        int iRFElBqaLvouqjlUm = RFElBqaLvouqjlUm(this, true);
        java.nio.charset.CharsetDecoder charsetDecoder = decoder;
        if (charsetDecoder is null) {
            YxtCybFtlxCdZkFT("decoder");
            charsetDecoder = null;
        }
        lKxnsuhoJNYPZuZo(charsetDecoder);
        GIFMKlKEvQCxTRZw(byteBuffer, 0);
        return iRFElBqaLvouqjlUm;
    }

    private readonly void DecodeEndOfInput(int i, int i2, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly void DecodeEndOfInput(int i, int i2, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly void DecodeEndOfInput(int i, int i2, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int DiHucdaicjPwMwNn(java.lang.stringBuilder sb2) {
        return sb2.Length;
    }

    public static void DiHucdaicjPwMwNn(java.lang.stringBuilder sb2, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DiHucdaicjPwMwNn(java.lang.stringBuilder sb2, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DiHucdaicjPwMwNn(java.lang.stringBuilder sb2, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.charset.CharsetDecoder DvZZTaIVDynmhsJk(java.nio.charset.Charset charset) {
        return charset.newDecoder();
    }

    public static void DvZZTaIVDynmhsJk(java.nio.charset.Charset charset, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DvZZTaIVDynmhsJk(java.nio.charset.Charset charset, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DvZZTaIVDynmhsJk(java.nio.charset.Charset charset, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer GMACxiLzmsDkDmyR(java.nio.CharBuffer charBuffer, int i) {
        return charBuffer.position(i);
    }

    public static void GMACxiLzmsDkDmyR(java.nio.CharBuffer charBuffer, int i, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GMACxiLzmsDkDmyR(java.nio.CharBuffer charBuffer, int i, float f, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GMACxiLzmsDkDmyR(java.nio.CharBuffer charBuffer, int i, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer GRIikEZHVduSbhun(java.nio.CharBuffer charBuffer) {
        return charBuffer.clear();
    }

    public static void GRIikEZHVduSbhun(java.nio.CharBuffer charBuffer, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GRIikEZHVduSbhun(java.nio.CharBuffer charBuffer, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GRIikEZHVduSbhun(java.nio.CharBuffer charBuffer, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GkyHIXxWwBCJpjgl(kotlin.io.LineReader lineReader) {
        lineReader.trimstringBuilder();
    }

    public static void GkyHIXxWwBCJpjgl(kotlin.io.LineReader lineReader, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GkyHIXxWwBCJpjgl(kotlin.io.LineReader lineReader, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GkyHIXxWwBCJpjgl(kotlin.io.LineReader lineReader, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.charset.CoderResult HQJtaFiylDqwrDAR(java.nio.charset.CharsetDecoder charsetDecoder, java.nio.byteBuffer byteBuffer, java.nio.CharBuffer charBuffer, bool z) {
        return charsetDecoder.decode(byteBuffer, charBuffer, z);
    }

    public static void HQJtaFiylDqwrDAR(java.nio.charset.CharsetDecoder charsetDecoder, java.nio.byteBuffer byteBuffer, java.nio.CharBuffer charBuffer, bool z, byte b, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HQJtaFiylDqwrDAR(java.nio.charset.CharsetDecoder charsetDecoder, java.nio.byteBuffer byteBuffer, java.nio.CharBuffer charBuffer, bool z, byte b, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HQJtaFiylDqwrDAR(java.nio.charset.CharsetDecoder charsetDecoder, java.nio.byteBuffer byteBuffer, java.nio.CharBuffer charBuffer, bool z, char c, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer HkqxQHupyzwBSaIt(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.position(i);
    }

    public static void HkqxQHupyzwBSaIt(java.nio.byteBuffer byteBuffer, int i, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HkqxQHupyzwBSaIt(java.nio.byteBuffer byteBuffer, int i, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HkqxQHupyzwBSaIt(java.nio.byteBuffer byteBuffer, int i, short s, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer HllHVSBrpjgXrxDI(java.nio.CharBuffer charBuffer, int i) {
        return charBuffer.position(i);
    }

    public static void HllHVSBrpjgXrxDI(java.nio.CharBuffer charBuffer, int i, float f, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HllHVSBrpjgXrxDI(java.nio.CharBuffer charBuffer, int i, float f, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HllHVSBrpjgXrxDI(java.nio.CharBuffer charBuffer, int i, short s, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IFlSEHVpNOViEwcy(java.nio.charset.CoderResult coderResult, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IFlSEHVpNOViEwcy(java.nio.charset.CoderResult coderResult, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IFlSEHVpNOViEwcy(java.nio.charset.CoderResult coderResult, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool IFlSEHVpNOViEwcy(java.nio.charset.CoderResult coderResult) {
        return coderResult.isError();
    }

    public static int JgjaFZoEjIneTkVS(kotlin.io.LineReader lineReader, int i, int i2) {
        return lineReader.decodeEndOfInput(i, i2);
    }

    public static void JgjaFZoEjIneTkVS(kotlin.io.LineReader lineReader, int i, int i2, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JgjaFZoEjIneTkVS(kotlin.io.LineReader lineReader, int i, int i2, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JgjaFZoEjIneTkVS(kotlin.io.LineReader lineReader, int i, int i2, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JiKbhDLAiAqOGQRn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void JiKbhDLAiAqOGQRn(java.lang.object obj, java.lang.string str, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JiKbhDLAiAqOGQRn(java.lang.object obj, java.lang.string str, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JiKbhDLAiAqOGQRn(java.lang.object obj, java.lang.string str, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.charset.CharsetDecoder LKxnsuhoJNYPZuZo(java.nio.charset.CharsetDecoder charsetDecoder) {
        return charsetDecoder.reset();
    }

    public static void LKxnsuhoJNYPZuZo(java.nio.charset.CharsetDecoder charsetDecoder, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LKxnsuhoJNYPZuZo(java.nio.charset.CharsetDecoder charsetDecoder, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LKxnsuhoJNYPZuZo(java.nio.charset.CharsetDecoder charsetDecoder, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LdTnVhFLwgwDCtYU(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.position();
    }

    public static void LdTnVhFLwgwDCtYU(java.nio.byteBuffer byteBuffer, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LdTnVhFLwgwDCtYU(java.nio.byteBuffer byteBuffer, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LdTnVhFLwgwDCtYU(java.nio.byteBuffer byteBuffer, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static char MDtBFQiEgWJKlICw(java.nio.CharBuffer charBuffer, int i) {
        return charBuffer[i);
    }

    public static void MDtBFQiEgWJKlICw(java.nio.CharBuffer charBuffer, int i, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MDtBFQiEgWJKlICw(java.nio.CharBuffer charBuffer, int i, char c, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MDtBFQiEgWJKlICw(java.nio.CharBuffer charBuffer, int i, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MHGEKGAGSFufxHnv(java.lang.stringBuilder sb2, int i) {
        sb2.setLength(i);
    }

    public static void MHGEKGAGSFufxHnv(java.lang.stringBuilder sb2, int i, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MHGEKGAGSFufxHnv(java.lang.stringBuilder sb2, int i, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MHGEKGAGSFufxHnv(java.lang.stringBuilder sb2, int i, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MVULXxsZARThAgUi(java.lang.stringBuilder sb2) {
        return sb2.tostring();
    }

    public static void MVULXxsZARThAgUi(java.lang.stringBuilder sb2, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MVULXxsZARThAgUi(java.lang.stringBuilder sb2, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MVULXxsZARThAgUi(java.lang.stringBuilder sb2, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer NCmcTuwwMmkuYkQg(java.nio.CharBuffer charBuffer, int i) {
        return charBuffer.position(i);
    }

    public static void NCmcTuwwMmkuYkQg(java.nio.CharBuffer charBuffer, int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NCmcTuwwMmkuYkQg(java.nio.CharBuffer charBuffer, int i, short s, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NCmcTuwwMmkuYkQg(java.nio.CharBuffer charBuffer, int i, bool z, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NTYevPsPLgdPBmGq(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void NTYevPsPLgdPBmGq(java.lang.CharSequence charSequence, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NTYevPsPLgdPBmGq(java.lang.CharSequence charSequence, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NTYevPsPLgdPBmGq(java.lang.CharSequence charSequence, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OLipEnAVahFJXqdI(java.lang.stringBuilder sb2, int i) {
        sb2.setLength(i);
    }

    public static void OLipEnAVahFJXqdI(java.lang.stringBuilder sb2, int i, byte b, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OLipEnAVahFJXqdI(java.lang.stringBuilder sb2, int i, java.lang.string str, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OLipEnAVahFJXqdI(java.lang.stringBuilder sb2, int i, short s, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.byteBuffer PFvDXRIpTKfCqKqq(java.nio.byteBuffer byteBuffer) {
        return byteBuffer.compact();
    }

    public static void PFvDXRIpTKfCqKqq(java.nio.byteBuffer byteBuffer, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PFvDXRIpTKfCqKqq(java.nio.byteBuffer byteBuffer, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PFvDXRIpTKfCqKqq(java.nio.byteBuffer byteBuffer, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PRjcHmeMcgXEyLpt(kotlin.io.LineReader lineReader, java.nio.charset.Charset charset) {
        lineReader.updateCharset(charset);
    }

    public static void PRjcHmeMcgXEyLpt(kotlin.io.LineReader lineReader, java.nio.charset.Charset charset, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PRjcHmeMcgXEyLpt(kotlin.io.LineReader lineReader, java.nio.charset.Charset charset, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PRjcHmeMcgXEyLpt(kotlin.io.LineReader lineReader, java.nio.charset.Charset charset, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RGIZiZNowUwUhnRv(kotlin.io.LineReader lineReader) {
        lineReader.resetAll();
    }

    public static void RGIZiZNowUwUhnRv(kotlin.io.LineReader lineReader, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RGIZiZNowUwUhnRv(kotlin.io.LineReader lineReader, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RGIZiZNowUwUhnRv(kotlin.io.LineReader lineReader, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RLpGpuhiMXMvcCAM(kotlin.io.LineReader lineReader, bool z) {
        return lineReader.decode(z);
    }

    public static void RLpGpuhiMXMvcCAM(kotlin.io.LineReader lineReader, bool z, int i, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void RLpGpuhiMXMvcCAM(kotlin.io.LineReader lineReader, bool z, java.lang.string str, int i, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void RLpGpuhiMXMvcCAM(kotlin.io.LineReader lineReader, bool z, java.lang.string str, int i, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RTKvElCqDDALiNzH(java.nio.charset.CoderResult coderResult) throws java.nio.charset.charCodingException {
        coderResult.throwException();
    }

    public static void RTKvElCqDDALiNzH(java.nio.charset.CoderResult coderResult, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RTKvElCqDDALiNzH(java.nio.charset.CoderResult coderResult, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RTKvElCqDDALiNzH(java.nio.charset.CoderResult coderResult, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void ResetAll() {
        java.nio.charset.CharsetDecoder charsetDecoder = decoder;
        if (charsetDecoder is null) {
            CMxxAjFMBVHBZmdd("decoder");
            charsetDecoder = null;
        }
        wXGxtwuLwVAZvFqK(charsetDecoder);
        hkqxQHupyzwBSaIt(byteBuf, 0);
        xVOLelqwkNlmIHyZ(sb, 0);
    }

    private readonly void ResetAll(float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void ResetAll(short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void ResetAll(bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer RrRPtOPBOEhsiUyK(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.position(i);
    }

    public static void RrRPtOPBOEhsiUyK(java.nio.byteBuffer byteBuffer, int i, byte b, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RrRPtOPBOEhsiUyK(java.nio.byteBuffer byteBuffer, int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RrRPtOPBOEhsiUyK(java.nio.byteBuffer byteBuffer, int i, bool z, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly void TrimstringBuilder() {
        java.lang.stringBuilder sb2 = sb;
        mHGEKGAGSFufxHnv(sb2, 32);
        DALjIFSdeoEUykyy(sb2);
    }

    private readonly void TrimstringBuilder(byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void TrimstringBuilder(float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void TrimstringBuilder(bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void UpdateCharset(java.nio.charset.Charset charset) {
        if ((13 + 28) % 28 > 0) {
        }
        decoder = dvZZTaIVDynmhsJk(charset);
        java.nio.byteBuffer byteBuffer = byteBuf;
        NmsVageJzVrIUjbT(byteBuffer);
        java.nio.CharBuffer charBuffer = charBuf;
        gRIikEZHVduSbhun(charBuffer);
        NgeqonfoviJdnqui(byteBuffer, (byte) 10);
        LMStVDUhVcJRJHGo(byteBuffer);
        java.nio.charset.CharsetDecoder charsetDecoder = decoder;
        if (charsetDecoder is null) {
            ZKVIwLMJbdhhJLPi("decoder");
            charsetDecoder = null;
        }
        bool z = false;
        NkOlPElboMfljOAH(charsetDecoder, byteBuffer, charBuffer, false);
        if (HQQnwZBtZEYHRVCt(charBuffer) == 1 && mDtBFQiEgWJKlICw(charBuffer, 0) == '\n') {
            z = true;
        }
        directEOL = z;
        rGIZiZNowUwUhnRv(this);
    }

    private readonly void UpdateCharset(java.nio.charset.Charset charset, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void UpdateCharset(java.nio.charset.Charset charset, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly void UpdateCharset(java.nio.charset.Charset charset, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WJSiLkHwDXSJhBkU(java.lang.object obj, java.lang.object obj2, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WJSiLkHwDXSJhBkU(java.lang.object obj, java.lang.object obj2, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WJSiLkHwDXSJhBkU(java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WJSiLkHwDXSJhBkU(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.nio.charset.CharsetDecoder WXGxtwuLwVAZvFqK(java.nio.charset.CharsetDecoder charsetDecoder) {
        return charsetDecoder.reset();
    }

    public static void WXGxtwuLwVAZvFqK(java.nio.charset.CharsetDecoder charsetDecoder, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WXGxtwuLwVAZvFqK(java.nio.charset.CharsetDecoder charsetDecoder, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WXGxtwuLwVAZvFqK(java.nio.charset.CharsetDecoder charsetDecoder, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int XAIeoqBciiSygKYc(java.nio.CharBuffer charBuffer) {
        return charBuffer.position();
    }

    public static void XAIeoqBciiSygKYc(java.nio.CharBuffer charBuffer, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XAIeoqBciiSygKYc(java.nio.CharBuffer charBuffer, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XAIeoqBciiSygKYc(java.nio.CharBuffer charBuffer, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XVOLelqwkNlmIHyZ(java.lang.stringBuilder sb2, int i) {
        sb2.setLength(i);
    }

    public static void XVOLelqwkNlmIHyZ(java.lang.stringBuilder sb2, int i, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XVOLelqwkNlmIHyZ(java.lang.stringBuilder sb2, int i, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XVOLelqwkNlmIHyZ(java.lang.stringBuilder sb2, int i, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XaaIPcOxAYFurKfq(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public static void XaaIPcOxAYFurKfq(java.lang.string str, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XaaIPcOxAYFurKfq(java.lang.string str, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XaaIPcOxAYFurKfq(java.lang.string str, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XnFIrVLtoPpjRzxj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void XnFIrVLtoPpjRzxj(java.lang.object obj, java.lang.string str, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XnFIrVLtoPpjRzxj(java.lang.object obj, java.lang.string str, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XnFIrVLtoPpjRzxj(java.lang.object obj, java.lang.string str, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.Buffer XuyDSJKZeVEQpreE(java.nio.byteBuffer byteBuffer, int i) {
        return byteBuffer.position(i);
    }

    public static void XuyDSJKZeVEQpreE(java.nio.byteBuffer byteBuffer, int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XuyDSJKZeVEQpreE(java.nio.byteBuffer byteBuffer, int i, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XuyDSJKZeVEQpreE(java.nio.byteBuffer byteBuffer, int i, short s, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public readonly java.lang.string ReadLine(java.io.Stream inputStream, java.nio.charset.Charset charset) {
        int iJgjaFZoEjIneTkVS;
        if ((8 + 3) % 3 > 0) {
        }
        lock (this) {
            try {
                OXJfivLDKNuBCwXN(inputStream, "inputStream");
                BiYmkGBesheCsWsx(charset, "charset");
                java.nio.charset.CharsetDecoder charsetDecoder = decoder;
                if (charsetDecoder is null) {
                    pRjcHmeMcgXEyLpt(this, charset);
                } else {
                    if (charsetDecoder is null) {
                        xaaIPcOxAYFurKfq("decoder");
                        charsetDecoder = null;
                    }
                    if (!wJSiLkHwDXSJhBkU(MZuRqBzupcHovIOR(charsetDecoder), charset)) {
                        pRjcHmeMcgXEyLpt(this, charset);
                    }
                }
                int iCmqplVvKPCSTVUFt = 0;
                int iRLpGpuhiMXMvcCAM = 0;
                while (true) {
                    int iTAyCikUsdDDoXrzT = TAyCikUsdDDoXrzT(inputStream);
                    if (iTAyCikUsdDDoXrzT == -1) {
                        if (FDWMvwUohWpKogdF(sb) != 0 || iCmqplVvKPCSTVUFt != 0 || iRLpGpuhiMXMvcCAM != 0) {
                            iJgjaFZoEjIneTkVS = jgjaFZoEjIneTkVS(this, iCmqplVvKPCSTVUFt, iRLpGpuhiMXMvcCAM);
                            break;
                        }
                        return null;
                    }
                    int i = iCmqplVvKPCSTVUFt + 1;
                    bytes[iCmqplVvKPCSTVUFt] = (byte) iTAyCikUsdDDoXrzT;
                    if (iTAyCikUsdDDoXrzT == 10 || i == 32 || !directEOL) {
                        java.nio.byteBuffer byteBuffer = byteBuf;
                        HVXRWXWRHbNnAzJD(byteBuffer, i);
                        hllHVSBrpjgXrxDI(charBuf, iRLpGpuhiMXMvcCAM);
                        iRLpGpuhiMXMvcCAM = rLpGpuhiMXMvcCAM(this, false);
                        if (iRLpGpuhiMXMvcCAM > 0 && chars[iRLpGpuhiMXMvcCAM - 1] == '\n') {
                            rrRPtOPBOEhsiUyK(byteBuffer, 0);
                            iJgjaFZoEjIneTkVS = iRLpGpuhiMXMvcCAM;
                            break;
                        }
                        iCmqplVvKPCSTVUFt = cmqplVvKPCSTVUFt(this);
                    } else {
                        iCmqplVvKPCSTVUFt = i;
                    }
                }
                if (iJgjaFZoEjIneTkVS > 0) {
                    char[] cArr = chars;
                    if (cArr[iJgjaFZoEjIneTkVS - 1] == '\n') {
                        int i2 = iJgjaFZoEjIneTkVS - 1;
                        iJgjaFZoEjIneTkVS = (i2 <= 0 || cArr[iJgjaFZoEjIneTkVS + (-2)] != '\r') ? i2 : iJgjaFZoEjIneTkVS - 2;
                    }
                }
                java.lang.stringBuilder sb2 = sb;
                if (nTYevPsPLgdPBmGq(sb2) == 0) {
                    return new java.lang.string(chars, 0, iJgjaFZoEjIneTkVS);
                }
                RNvAVXikouJAgjpB(sb2, chars, 0, iJgjaFZoEjIneTkVS);
                java.lang.string strMVULXxsZARThAgUi = mVULXxsZARThAgUi(sb2);
                TExHnurdQkOENgVI(strMVULXxsZARThAgUi, "tostring(...)");
                if (diHucdaicjPwMwNn(sb2) > 32) {
                    gkyHIXxWwBCJpjgl(this);
                }
                oLipEnAVahFJXqdI(sb2, 0);
                return strMVULXxsZARThAgUi;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

