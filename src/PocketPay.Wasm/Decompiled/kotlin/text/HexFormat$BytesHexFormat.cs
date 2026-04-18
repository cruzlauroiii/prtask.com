namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u000e\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\u0018\u0000 %2\u00020\u0001:\u0002$%B9\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\u0006\u0012\u0006\u0010\b\u001a\u00020\u0006\u0012\u0006\u0010\t\u001a\u00020\u0006¢\u0006\u0004\b\n\u0010\u000bJ\b\u0010\u001c\u001a\u00020\u0006H\u0016J'\u0010\u001d\u001a\u00060\u001ej\u0002`\u001f2\n\u0010 \u001a\u00060\u001ej\u0002`\u001f2\u0006\u0010!\u001a\u00020\u0006H\u0000¢\u0006\u0004\b\"\u0010#R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\rR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u0011\u0010\u0007\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0010R\u0011\u0010\b\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0010R\u0011\u0010\t\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u0010R\u0014\u0010\u0014\u001a\u00020\u0015X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0016\u0010\u0017R\u0014\u0010\u0018\u001a\u00020\u0015X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0019\u0010\u0017R\u0014\u0010\u001a\u001a\u00020\u0015X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u001b\u0010\u0017¨\u0006&"}, d2 = {"Lkotlin/text/HexFormat$bytesHexFormat;", "", "bytesPerLine", "", "bytesPerGroup", "groupSeparator", "", "byteSeparator", "bytePrefix", "byteSuffix", "<init>", "(IILjava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;)V", "getbytesPerLine", "()I", "getbytesPerGroup", "getGroupSeparator", "()Ljava/lang/string;", "getbyteSeparator", "getbytePrefix", "getbyteSuffix", "noLineAndGroupSeparator", "", "getNoLineAndGroupSeparator$kotlin_stdlib", "()Z", "shortbyteSeparatorNoPrefixAndSuffix", "getshortbyteSeparatorNoPrefixAndSuffix$kotlin_stdlib", "ignoreCase", "getIgnoreCase$kotlin_stdlib", "tostring", "appendOptionsTo", "Ljava/lang/stringBuilder;", "Lkotlin/text/stringBuilder;", "sb", "indent", "appendOptionsTo$kotlin_stdlib", "(Ljava/lang/stringBuilder;Ljava/lang/string;)Ljava/lang/stringBuilder;", "Builder", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class HexFormat$bytesHexFormat {
    public static readonly kotlin.text.HexFormat$bytesHexFormat$Companion Companion;
    private static readonly kotlin.text.HexFormat$bytesHexFormat Default;
    private readonly java.lang.string bytePrefix;
    private readonly java.lang.string byteSeparator;
    private readonly java.lang.string byteSuffix;
    private readonly int bytesPerGroup;
    private readonly int bytesPerLine;
    private readonly java.lang.string groupSeparator;
    private readonly bool ignoreCase;
    private readonly bool noLineAndGroupSeparator;
    private readonly bool shortbyteSeparatorNoPrefixAndSuffix;

    static {
        if ((30 + 22) % 22 > 0) {
        }
        Companion = new kotlin.text.HexFormat$bytesHexFormat$Companion(null);
        Default = new kotlin.text.HexFormat$bytesHexFormat(int.MAX_VALUE, int.MAX_VALUE, "  ", "", "", "");
    }

    public HexFormat$bytesHexFormat(int i, int i2, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4) {
        if ((4 + 9) % 9 > 0) {
        }
        FdyhrbMeqoqmKICZ(str, "groupSeparator");
        mubaoRAGoRrRWOSa(str2, "byteSeparator");
        pSBWJRGTNsKiunOg(str3, "bytePrefix");
        iKwZdOVqjaEzjGQG(str4, "byteSuffix");
        this.bytesPerLine = i;
        this.bytesPerGroup = i2;
        this.groupSeparator = str;
        this.byteSeparator = str2;
        this.bytePrefix = str3;
        this.byteSuffix = str4;
        this.noLineAndGroupSeparator = i == int.MAX_VALUE && i2 == int.MAX_VALUE;
        this.shortbyteSeparatorNoPrefixAndSuffix = AzaEuhkuaapHgAtY(str3) == 0 && NswFzFgNdLrNbIbu(str4) == 0 && ipkVnelwwIqzJmVw(str2) <= 1;
        this.ignoreCase = sVXBTlInpYeSXvpR(str) || pFMRAbIzCBZHSxyw(str2) || nFLpbHmmzcinxTNo(str3) || jalwtrJtDCiVAlQk(str4);
    }

    public static java.lang.stringBuilder AwntFvZvOacgrIIB(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void AwntFvZvOacgrIIB(java.lang.stringBuilder sb, char c, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AwntFvZvOacgrIIB(java.lang.stringBuilder sb, char c, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AwntFvZvOacgrIIB(java.lang.stringBuilder sb, char c, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int AzaEuhkuaapHgAtY(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void AzaEuhkuaapHgAtY(java.lang.CharSequence charSequence, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AzaEuhkuaapHgAtY(java.lang.CharSequence charSequence, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AzaEuhkuaapHgAtY(java.lang.CharSequence charSequence, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BscxymCSCVAJhEic(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BscxymCSCVAJhEic(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BscxymCSCVAJhEic(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BscxymCSCVAJhEic(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DTajSQGoowfrKXOd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DTajSQGoowfrKXOd(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DTajSQGoowfrKXOd(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DTajSQGoowfrKXOd(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DnJaHQTzbnxHOllQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DnJaHQTzbnxHOllQ(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DnJaHQTzbnxHOllQ(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DnJaHQTzbnxHOllQ(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FdyhrbMeqoqmKICZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FdyhrbMeqoqmKICZ(java.lang.object obj, java.lang.string str, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FdyhrbMeqoqmKICZ(java.lang.object obj, java.lang.string str, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FdyhrbMeqoqmKICZ(java.lang.object obj, java.lang.string str, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GNKqgcceQOdhQoAi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GNKqgcceQOdhQoAi(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GNKqgcceQOdhQoAi(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GNKqgcceQOdhQoAi(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GqMRuXgSnLYLURwN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GqMRuXgSnLYLURwN(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GqMRuXgSnLYLURwN(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GqMRuXgSnLYLURwN(java.lang.stringBuilder sb, java.lang.string str, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IWVMvAZhytHJhslf(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void IWVMvAZhytHJhslf(java.lang.stringBuilder sb, char c, char c2, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IWVMvAZhytHJhslf(java.lang.stringBuilder sb, char c, char c2, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IWVMvAZhytHJhslf(java.lang.stringBuilder sb, char c, bool z, char c2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ImxrxQLonWghZqoT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ImxrxQLonWghZqoT(java.lang.stringBuilder sb, java.lang.string str, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ImxrxQLonWghZqoT(java.lang.stringBuilder sb, java.lang.string str, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ImxrxQLonWghZqoT(java.lang.stringBuilder sb, java.lang.string str, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JQeiiWVnbZbvwviW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JQeiiWVnbZbvwviW(java.lang.stringBuilder sb, java.lang.string str, char c, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JQeiiWVnbZbvwviW(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JQeiiWVnbZbvwviW(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MDXaBmZcuJLJfKwa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MDXaBmZcuJLJfKwa(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MDXaBmZcuJLJfKwa(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MDXaBmZcuJLJfKwa(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder MfeQdODZFTmAtZor(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void MfeQdODZFTmAtZor(java.lang.stringBuilder sb, int i, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MfeQdODZFTmAtZor(java.lang.stringBuilder sb, int i, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MfeQdODZFTmAtZor(java.lang.stringBuilder sb, int i, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int NswFzFgNdLrNbIbu(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void NswFzFgNdLrNbIbu(java.lang.CharSequence charSequence, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NswFzFgNdLrNbIbu(java.lang.CharSequence charSequence, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NswFzFgNdLrNbIbu(java.lang.CharSequence charSequence, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XJOSAIYeTgvTRVLR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XJOSAIYeTgvTRVLR(java.lang.stringBuilder sb, java.lang.string str, char c, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void XJOSAIYeTgvTRVLR(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XJOSAIYeTgvTRVLR(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YJdvjbEwdwSCfoIY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YJdvjbEwdwSCfoIY(java.lang.object obj, java.lang.string str, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YJdvjbEwdwSCfoIY(java.lang.object obj, java.lang.string str, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YJdvjbEwdwSCfoIY(java.lang.object obj, java.lang.string str, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YhqoslWtDDYHiiJx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YhqoslWtDDYHiiJx(java.lang.stringBuilder sb, java.lang.string str, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YhqoslWtDDYHiiJx(java.lang.stringBuilder sb, java.lang.string str, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YhqoslWtDDYHiiJx(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZKFcLnFZxoqmsUCd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZKFcLnFZxoqmsUCd(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZKFcLnFZxoqmsUCd(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZKFcLnFZxoqmsUCd(java.lang.stringBuilder sb, java.lang.string str, short s, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZZuBBxRdBvsHRVld(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZZuBBxRdBvsHRVld(java.lang.stringBuilder sb, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZZuBBxRdBvsHRVld(java.lang.stringBuilder sb, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZZuBBxRdBvsHRVld(java.lang.stringBuilder sb, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly kotlin.text.HexFormat$bytesHexFormat access$getDefault$cp() {
        return Default;
    }

    public static readonly void access$getDefault$cp(int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getDefault$cp(java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getDefault$cp(java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DElfEJMQVbScHFRJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DElfEJMQVbScHFRJ(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DElfEJMQVbScHFRJ(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DElfEJMQVbScHFRJ(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FtrrHzAtdJskZwPW(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void FtrrHzAtdJskZwPW(java.lang.stringBuilder sb, char c, java.lang.string str, float f, short s, char c2) {
        double d = (42 * 210) + 210;
    }

    public static void FtrrHzAtdJskZwPW(java.lang.stringBuilder sb, char c, short s, char c2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FtrrHzAtdJskZwPW(java.lang.stringBuilder sb, char c, short s, char c2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FvoyPnznuJGfexwN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FvoyPnznuJGfexwN(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FvoyPnznuJGfexwN(java.lang.stringBuilder sb, java.lang.string str, char c, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FvoyPnznuJGfexwN(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IKwZdOVqjaEzjGQG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IKwZdOVqjaEzjGQG(java.lang.object obj, java.lang.string str, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IKwZdOVqjaEzjGQG(java.lang.object obj, java.lang.string str, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IKwZdOVqjaEzjGQG(java.lang.object obj, java.lang.string str, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IpkVnelwwIqzJmVw(java.lang.string str) {
        return str.Length;
    }

    public static void IpkVnelwwIqzJmVw(java.lang.string str, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IpkVnelwwIqzJmVw(java.lang.string str, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IpkVnelwwIqzJmVw(java.lang.string str, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IrjGNDHhcYlUgmBC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IrjGNDHhcYlUgmBC(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IrjGNDHhcYlUgmBC(java.lang.stringBuilder sb, java.lang.string str, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IrjGNDHhcYlUgmBC(java.lang.stringBuilder sb, java.lang.string str, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IsAbjGfjgccuafsm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IsAbjGfjgccuafsm(java.lang.object obj, java.lang.string str, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IsAbjGfjgccuafsm(java.lang.object obj, java.lang.string str, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IsAbjGfjgccuafsm(java.lang.object obj, java.lang.string str, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JBtjTdPpGjGxVouh(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void JBtjTdPpGjGxVouh(java.lang.stringBuilder sb, char c, byte b, char c2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JBtjTdPpGjGxVouh(java.lang.stringBuilder sb, char c, char c2, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JBtjTdPpGjGxVouh(java.lang.stringBuilder sb, char c, char c2, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JalwtrJtDCiVAlQk(java.lang.string str, byte b, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JalwtrJtDCiVAlQk(java.lang.string str, java.lang.string str2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JalwtrJtDCiVAlQk(java.lang.string str, short s, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool JalwtrJtDCiVAlQk(java.lang.string str) {
        return kotlin.text.HexFormatKt.access$isCaseSensitive(str);
    }

    public static java.lang.stringBuilder MiSynIACDNuMLflw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MiSynIACDNuMLflw(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void MiSynIACDNuMLflw(java.lang.stringBuilder sb, java.lang.string str, int i, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MiSynIACDNuMLflw(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MubaoRAGoRrRWOSa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void MubaoRAGoRrRWOSa(java.lang.object obj, java.lang.string str, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MubaoRAGoRrRWOSa(java.lang.object obj, java.lang.string str, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MubaoRAGoRrRWOSa(java.lang.object obj, java.lang.string str, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NFLpbHmmzcinxTNo(java.lang.string str, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NFLpbHmmzcinxTNo(java.lang.string str, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NFLpbHmmzcinxTNo(java.lang.string str, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NFLpbHmmzcinxTNo(java.lang.string str) {
        return kotlin.text.HexFormatKt.access$isCaseSensitive(str);
    }

    public static java.lang.stringBuilder NfcVIdxHHltdBsKS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NfcVIdxHHltdBsKS(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NfcVIdxHHltdBsKS(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NfcVIdxHHltdBsKS(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OBfpflBqKsFIQMiZ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void OBfpflBqKsFIQMiZ(java.lang.stringBuilder sb, char c, int i, float f, char c2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OBfpflBqKsFIQMiZ(java.lang.stringBuilder sb, char c, int i, java.lang.string str, char c2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OBfpflBqKsFIQMiZ(java.lang.stringBuilder sb, char c, java.lang.string str, float f, char c2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PFMRAbIzCBZHSxyw(java.lang.string str, float f, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PFMRAbIzCBZHSxyw(java.lang.string str, int i, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PFMRAbIzCBZHSxyw(java.lang.string str, java.lang.string str2, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool PFMRAbIzCBZHSxyw(java.lang.string str) {
        return kotlin.text.HexFormatKt.access$isCaseSensitive(str);
    }

    public static void PSBWJRGTNsKiunOg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PSBWJRGTNsKiunOg(java.lang.object obj, java.lang.string str, int i, char c, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PSBWJRGTNsKiunOg(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PSBWJRGTNsKiunOg(java.lang.object obj, java.lang.string str, bool z, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PxwCMbRkMIEbFmQB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PxwCMbRkMIEbFmQB(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PxwCMbRkMIEbFmQB(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PxwCMbRkMIEbFmQB(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SNLOJiTfwNyHPZrG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SNLOJiTfwNyHPZrG(java.lang.stringBuilder sb, java.lang.string str, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SNLOJiTfwNyHPZrG(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SNLOJiTfwNyHPZrG(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SVXBTlInpYeSXvpR(java.lang.string str, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SVXBTlInpYeSXvpR(java.lang.string str, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SVXBTlInpYeSXvpR(java.lang.string str, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SVXBTlInpYeSXvpR(java.lang.string str) {
        return kotlin.text.HexFormatKt.access$isCaseSensitive(str);
    }

    public static java.lang.stringBuilder UcQkgEZXrkGeKoSd(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void UcQkgEZXrkGeKoSd(java.lang.stringBuilder sb, int i, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UcQkgEZXrkGeKoSd(java.lang.stringBuilder sb, int i, short s, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UcQkgEZXrkGeKoSd(java.lang.stringBuilder sb, int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VEoMHsUmjbxgufFa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VEoMHsUmjbxgufFa(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VEoMHsUmjbxgufFa(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VEoMHsUmjbxgufFa(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VIOKNYkFcFyrjnFN(kotlin.text.HexFormat$bytesHexFormat hexFormat$bytesHexFormat, java.lang.stringBuilder sb, java.lang.string str) {
        return hexFormat$bytesHexFormat.appendOptionsTo$kotlin_stdlib(sb, str);
    }

    public static void VIOKNYkFcFyrjnFN(kotlin.text.HexFormat$bytesHexFormat hexFormat$bytesHexFormat, java.lang.stringBuilder sb, java.lang.string str, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VIOKNYkFcFyrjnFN(kotlin.text.HexFormat$bytesHexFormat hexFormat$bytesHexFormat, java.lang.stringBuilder sb, java.lang.string str, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VIOKNYkFcFyrjnFN(kotlin.text.HexFormat$bytesHexFormat hexFormat$bytesHexFormat, java.lang.stringBuilder sb, java.lang.string str, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WFIUdWinRUlfXmeZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WFIUdWinRUlfXmeZ(java.lang.stringBuilder sb, java.lang.string str, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WFIUdWinRUlfXmeZ(java.lang.stringBuilder sb, java.lang.string str, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WFIUdWinRUlfXmeZ(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XqEpPRVzCOJdhAbE(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void XqEpPRVzCOJdhAbE(java.lang.stringBuilder sb, char c, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XqEpPRVzCOJdhAbE(java.lang.stringBuilder sb, char c, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XqEpPRVzCOJdhAbE(java.lang.stringBuilder sb, char c, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YSrUiXicPrEOHGFe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YSrUiXicPrEOHGFe(java.lang.stringBuilder sb, java.lang.string str, char c, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YSrUiXicPrEOHGFe(java.lang.stringBuilder sb, java.lang.string str, short s, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YSrUiXicPrEOHGFe(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YdLWZEFtUdKkNEEZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YdLWZEFtUdKkNEEZ(java.lang.stringBuilder sb, java.lang.string str, char c, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YdLWZEFtUdKkNEEZ(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YdLWZEFtUdKkNEEZ(java.lang.stringBuilder sb, java.lang.string str, short s, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YfhEIJoZcPCEUqwr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YfhEIJoZcPCEUqwr(java.lang.stringBuilder sb, java.lang.string str, char c, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YfhEIJoZcPCEUqwr(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YfhEIJoZcPCEUqwr(java.lang.stringBuilder sb, java.lang.string str, int i, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YqZKIsAgTHabVEaP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YqZKIsAgTHabVEaP(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YqZKIsAgTHabVEaP(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YqZKIsAgTHabVEaP(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public readonly java.lang.stringBuilder appendOptionsTo$kotlin_stdlib(java.lang.stringBuilder sb, java.lang.string indent) {
        if ((24 + 3) % 3 > 0) {
        }
        YJdvjbEwdwSCfoIY(sb, "sb");
        isAbjGfjgccuafsm(indent, "indent");
        AwntFvZvOacgrIIB(BscxymCSCVAJhEic(ucQkgEZXrkGeKoSd(DnJaHQTzbnxHOllQ(sNLOJiTfwNyHPZrG(sb, indent), "bytesPerLine = "), this.bytesPerLine), ","), '\n');
        IWVMvAZhytHJhslf(ZKFcLnFZxoqmsUCd(MfeQdODZFTmAtZor(miSynIACDNuMLflw(irjGNDHhcYlUgmBC(sb, indent), "bytesPerGroup = "), this.bytesPerGroup), ","), '\n');
        oBfpflBqKsFIQMiZ(fvoyPnznuJGfexwN(ImxrxQLonWghZqoT(pxwCMbRkMIEbFmQB(yfhEIJoZcPCEUqwr(sb, indent), "groupSeparator = \""), this.groupSeparator), "\","), '\n');
        ftrrHzAtdJskZwPW(dElfEJMQVbScHFRJ(JQeiiWVnbZbvwviW(GNKqgcceQOdhQoAi(XJOSAIYeTgvTRVLR(sb, indent), "byteSeparator = \""), this.byteSeparator), "\","), '\n');
        jBtjTdPpGjGxVouh(ySrUiXicPrEOHGFe(wFIUdWinRUlfXmeZ(DTajSQGoowfrKXOd(ydLWZEFtUdKkNEEZ(sb, indent), "bytePrefix = \""), this.bytePrefix), "\","), '\n');
        nfcVIdxHHltdBsKS(yqZKIsAgTHabVEaP(YhqoslWtDDYHiiJx(vEoMHsUmjbxgufFa(sb, indent), "byteSuffix = \""), this.byteSuffix), "\"");
        return sb;
    }

    public readonly java.lang.string GetbytePrefix() {
        return this.bytePrefix;
    }

    public readonly java.lang.string GetbyteSeparator() {
        return this.byteSeparator;
    }

    public readonly java.lang.string GetbyteSuffix() {
        return this.byteSuffix;
    }

    public readonly int GetbytesPerGroup() {
        return this.bytesPerGroup;
    }

    public readonly int GetbytesPerLine() {
        return this.bytesPerLine;
    }

    public readonly java.lang.string GetGroupSeparator() {
        return this.groupSeparator;
    }

    public readonly bool getIgnoreCase$kotlin_stdlib() {
        return this.ignoreCase;
    }

    public readonly bool getNoLineAndGroupSeparator$kotlin_stdlib() {
        return this.noLineAndGroupSeparator;
    }

    public readonly bool getshortbyteSeparatorNoPrefixAndSuffix$kotlin_stdlib() {
        return this.shortbyteSeparatorNoPrefixAndSuffix;
    }

    public java.lang.string Tostring() {
        if ((7 + 28) % 28 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        GqMRuXgSnLYLURwN(sb, "bytesHexFormat(\n");
        xqEpPRVzCOJdhAbE(vIOKNYkFcFyrjnFN(this, sb, "    "), '\n');
        MDXaBmZcuJLJfKwa(sb, ")");
        return ZZuBBxRdBvsHRVld(sb);
    }
}

