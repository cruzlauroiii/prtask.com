namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u000e\n\u0002\b\u0005\b\u0007\u0018\u0000 \u00152\u00020\u0001:\u0004\u0012\u0013\u0014\u0015B!\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\b\u0010\u0010\u001a\u00020\u0011H\u0016R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000f¨\u0006\u0016"}, d2 = {"Lkotlin/text/HexFormat;", "", "upperCase", "", "bytes", "Lkotlin/text/HexFormat$bytesHexFormat;", "number", "Lkotlin/text/HexFormat$NumberHexFormat;", "<init>", "(ZLkotlin/text/HexFormat$bytesHexFormat;Lkotlin/text/HexFormat$NumberHexFormat;)V", "getUpperCase", "()Z", "getbytes", "()Lkotlin/text/HexFormat$bytesHexFormat;", "getNumber", "()Lkotlin/text/HexFormat$NumberHexFormat;", "tostring", "", "bytesHexFormat", "NumberHexFormat", "Builder", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class HexFormat {
    public static readonly kotlin.text.HexFormat$Companion Companion;
    private static readonly kotlin.text.HexFormat Default;
    private static readonly kotlin.text.HexFormat UpperCase;
    private readonly kotlin.text.HexFormat$bytesHexFormat bytes;
    private readonly kotlin.text.NumberHexFormat number;
    private readonly bool upperCase;

    static {
        if ((15 + 7) % 7 > 0) {
        }
        Companion = new kotlin.text.HexFormat$Companion(null);
        Default = new kotlin.text.HexFormat(false, RQXsQgBRSuxeJgMH(kotlin.text.HexFormat$bytesHexFormat.Companion), RNrplUaPAZXXSDPh(kotlin.text.NumberHexFormat.Companion));
        UpperCase = new kotlin.text.HexFormat(true, vBAQDjyDyKAlBRND(kotlin.text.HexFormat$bytesHexFormat.Companion), IrXqOmpqhNWqkOib(kotlin.text.NumberHexFormat.Companion));
    }

    public HexFormat(bool z, kotlin.text.HexFormat$bytesHexFormat hexFormat$bytesHexFormat, kotlin.text.NumberHexFormat numberHexFormat) {
        YFpFfNzVxetfpynX(hexFormat$bytesHexFormat, "bytes");
        sVUFXHksosJpDYSm(numberHexFormat, "number");
        this.upperCase = z;
        this.bytes = hexFormat$bytesHexFormat;
        this.number = numberHexFormat;
    }

    public static java.lang.stringBuilder ELwJPLttOIZKVcTa(kotlin.text.NumberHexFormat numberHexFormat, java.lang.stringBuilder sb, java.lang.string str) {
        return numberHexFormat.appendOptionsTo$kotlin_stdlib(sb, str);
    }

    public static void ELwJPLttOIZKVcTa(kotlin.text.NumberHexFormat numberHexFormat, java.lang.stringBuilder sb, java.lang.string str, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ELwJPLttOIZKVcTa(kotlin.text.NumberHexFormat numberHexFormat, java.lang.stringBuilder sb, java.lang.string str, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ELwJPLttOIZKVcTa(kotlin.text.NumberHexFormat numberHexFormat, java.lang.stringBuilder sb, java.lang.string str, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EhpajhEvUvgVjFtp(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void EhpajhEvUvgVjFtp(java.lang.stringBuilder sb, char c, short s, float f, bool z, char c2) {
        double d = (42 * 210) + 210;
    }

    public static void EhpajhEvUvgVjFtp(java.lang.stringBuilder sb, char c, bool z, char c2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EhpajhEvUvgVjFtp(java.lang.stringBuilder sb, char c, bool z, float f, char c2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EtSompxgPTaPqutL(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void EtSompxgPTaPqutL(java.lang.stringBuilder sb, char c, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EtSompxgPTaPqutL(java.lang.stringBuilder sb, char c, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EtSompxgPTaPqutL(java.lang.stringBuilder sb, char c, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GoCOdcWeDneYcejw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GoCOdcWeDneYcejw(java.lang.stringBuilder sb, java.lang.string str, float f, int i, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GoCOdcWeDneYcejw(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GoCOdcWeDneYcejw(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.text.NumberHexFormat IrXqOmpqhNWqkOib(kotlin.text.HexFormat$NumberHexFormat$Companion hexFormat$NumberHexFormat$Companion) {
        return hexFormat$NumberHexFormat$Companion.getDefault$kotlin_stdlib();
    }

    public static void IrXqOmpqhNWqkOib(kotlin.text.HexFormat$NumberHexFormat$Companion hexFormat$NumberHexFormat$Companion, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IrXqOmpqhNWqkOib(kotlin.text.HexFormat$NumberHexFormat$Companion hexFormat$NumberHexFormat$Companion, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IrXqOmpqhNWqkOib(kotlin.text.HexFormat$NumberHexFormat$Companion hexFormat$NumberHexFormat$Companion, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RAwLwmrZBzSYOGYY(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void RAwLwmrZBzSYOGYY(java.lang.stringBuilder sb, char c, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RAwLwmrZBzSYOGYY(java.lang.stringBuilder sb, char c, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RAwLwmrZBzSYOGYY(java.lang.stringBuilder sb, char c, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.text.NumberHexFormat RNrplUaPAZXXSDPh(kotlin.text.HexFormat$NumberHexFormat$Companion hexFormat$NumberHexFormat$Companion) {
        return hexFormat$NumberHexFormat$Companion.getDefault$kotlin_stdlib();
    }

    public static void RNrplUaPAZXXSDPh(kotlin.text.HexFormat$NumberHexFormat$Companion hexFormat$NumberHexFormat$Companion, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RNrplUaPAZXXSDPh(kotlin.text.HexFormat$NumberHexFormat$Companion hexFormat$NumberHexFormat$Companion, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RNrplUaPAZXXSDPh(kotlin.text.HexFormat$NumberHexFormat$Companion hexFormat$NumberHexFormat$Companion, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.text.HexFormat$bytesHexFormat RQXsQgBRSuxeJgMH(kotlin.text.HexFormat$bytesHexFormat$Companion hexFormat$bytesHexFormat$Companion) {
        return hexFormat$bytesHexFormat$Companion.getDefault$kotlin_stdlib();
    }

    public static void RQXsQgBRSuxeJgMH(kotlin.text.HexFormat$bytesHexFormat$Companion hexFormat$bytesHexFormat$Companion, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RQXsQgBRSuxeJgMH(kotlin.text.HexFormat$bytesHexFormat$Companion hexFormat$bytesHexFormat$Companion, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RQXsQgBRSuxeJgMH(kotlin.text.HexFormat$bytesHexFormat$Companion hexFormat$bytesHexFormat$Companion, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UpkGiZdqIBgdtjuO(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void UpkGiZdqIBgdtjuO(java.lang.stringBuilder sb, char c, char c2, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UpkGiZdqIBgdtjuO(java.lang.stringBuilder sb, char c, java.lang.string str, char c2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UpkGiZdqIBgdtjuO(java.lang.stringBuilder sb, char c, bool z, java.lang.string str, byte b, char c2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WuQAlynhDPHgVqSK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WuQAlynhDPHgVqSK(java.lang.stringBuilder sb, java.lang.string str, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WuQAlynhDPHgVqSK(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WuQAlynhDPHgVqSK(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XZhJtyCZFIDmeatf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XZhJtyCZFIDmeatf(java.lang.stringBuilder sb, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XZhJtyCZFIDmeatf(java.lang.stringBuilder sb, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XZhJtyCZFIDmeatf(java.lang.stringBuilder sb, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YFpFfNzVxetfpynX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YFpFfNzVxetfpynX(java.lang.object obj, java.lang.string str, char c, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YFpFfNzVxetfpynX(java.lang.object obj, java.lang.string str, int i, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YFpFfNzVxetfpynX(java.lang.object obj, java.lang.string str, int i, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly kotlin.text.HexFormat access$getDefault$cp() {
        return Default;
    }

    public static readonly void access$getDefault$cp(byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getDefault$cp(byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getDefault$cp(byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static readonly kotlin.text.HexFormat access$getUpperCase$cp() {
        return UpperCase;
    }

    public static readonly void access$getUpperCase$cp(byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getUpperCase$cp(char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getUpperCase$cp(bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OjPrTNkmGliReseO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OjPrTNkmGliReseO(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OjPrTNkmGliReseO(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OjPrTNkmGliReseO(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QraQxclnyICteaBx(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void QraQxclnyICteaBx(java.lang.stringBuilder sb, char c, char c2, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QraQxclnyICteaBx(java.lang.stringBuilder sb, char c, char c2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QraQxclnyICteaBx(java.lang.stringBuilder sb, char c, java.lang.string str, byte b, char c2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SVUFXHksosJpDYSm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SVUFXHksosJpDYSm(java.lang.object obj, java.lang.string str, char c, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SVUFXHksosJpDYSm(java.lang.object obj, java.lang.string str, float f, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void SVUFXHksosJpDYSm(java.lang.object obj, java.lang.string str, java.lang.string str2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UkiEjhBzguvHFDfI(kotlin.text.HexFormat$bytesHexFormat hexFormat$bytesHexFormat, java.lang.stringBuilder sb, java.lang.string str) {
        return hexFormat$bytesHexFormat.appendOptionsTo$kotlin_stdlib(sb, str);
    }

    public static void UkiEjhBzguvHFDfI(kotlin.text.HexFormat$bytesHexFormat hexFormat$bytesHexFormat, java.lang.stringBuilder sb, java.lang.string str, byte b, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UkiEjhBzguvHFDfI(kotlin.text.HexFormat$bytesHexFormat hexFormat$bytesHexFormat, java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UkiEjhBzguvHFDfI(kotlin.text.HexFormat$bytesHexFormat hexFormat$bytesHexFormat, java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.text.HexFormat$bytesHexFormat vBAQDjyDyKAlBRND(kotlin.text.HexFormat$bytesHexFormat$Companion hexFormat$bytesHexFormat$Companion) {
        return hexFormat$bytesHexFormat$Companion.getDefault$kotlin_stdlib();
    }

    public static void VBAQDjyDyKAlBRND(kotlin.text.HexFormat$bytesHexFormat$Companion hexFormat$bytesHexFormat$Companion, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VBAQDjyDyKAlBRND(kotlin.text.HexFormat$bytesHexFormat$Companion hexFormat$bytesHexFormat$Companion, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VBAQDjyDyKAlBRND(kotlin.text.HexFormat$bytesHexFormat$Companion hexFormat$bytesHexFormat$Companion, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WJoVTiHdCuSwxIak(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WJoVTiHdCuSwxIak(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WJoVTiHdCuSwxIak(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WJoVTiHdCuSwxIak(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XobbQMiWWFQtSUzN(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static void XobbQMiWWFQtSUzN(java.lang.stringBuilder sb, bool z, byte b, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XobbQMiWWFQtSUzN(java.lang.stringBuilder sb, bool z, float f, byte b, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XobbQMiWWFQtSUzN(java.lang.stringBuilder sb, bool z, float f, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZHCDwJZYhGQYCFeB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZHCDwJZYhGQYCFeB(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZHCDwJZYhGQYCFeB(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZHCDwJZYhGQYCFeB(java.lang.stringBuilder sb, java.lang.string str, int i, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZKmfqGQyQdudXITI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZKmfqGQyQdudXITI(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZKmfqGQyQdudXITI(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZKmfqGQyQdudXITI(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public readonly kotlin.text.HexFormat$bytesHexFormat getbytes() {
        return this.bytes;
    }

    public readonly kotlin.text.NumberHexFormat GetNumber() {
        return this.number;
    }

    public readonly bool GetUpperCase() {
        return this.upperCase;
    }

    public java.lang.string Tostring() {
        if ((11 + 8) % 8 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        WuQAlynhDPHgVqSK(sb, "HexFormat(\n    upperCase = ");
        ojPrTNkmGliReseO(xobbQMiWWFQtSUzN(sb, this.upperCase), ",\n    bytes = bytesHexFormat(\n");
        qraQxclnyICteaBx(ukiEjhBzguvHFDfI(this.bytes, sb, "        "), '\n');
        EtSompxgPTaPqutL(zHCDwJZYhGQYCFeB(sb, "    ),"), '\n');
        UpkGiZdqIBgdtjuO(wJoVTiHdCuSwxIak(sb, "    number = NumberHexFormat("), '\n');
        EhpajhEvUvgVjFtp(ELwJPLttOIZKVcTa(this.number, sb, "        "), '\n');
        RAwLwmrZBzSYOGYY(zKmfqGQyQdudXITI(sb, "    )"), '\n');
        GoCOdcWeDneYcejw(sb, ")");
        return XZhJtyCZFIDmeatf(sb);
    }
}

