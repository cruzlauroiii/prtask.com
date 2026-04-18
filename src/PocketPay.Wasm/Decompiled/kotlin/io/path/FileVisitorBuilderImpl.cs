namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\u0010\u000e\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J@\u0010\u0004\u001a\u00020\u000f26\u0010\u0010\u001a2\u0012\u0013\u0012\u00110\u0006¢\u0006\f\b\u0011\u0012\b\b\u0012\u0012\u0004\b\b(\u0013\u0012\u0013\u0012\u00110\u0007¢\u0006\f\b\u0011\u0012\b\b\u0012\u0012\u0004\b\b(\u0014\u0012\u0004\u0012\u00020\b0\u0005H\u0016J@\u0010\t\u001a\u00020\u000f26\u0010\u0010\u001a2\u0012\u0013\u0012\u00110\u0006¢\u0006\f\b\u0011\u0012\b\b\u0012\u0012\u0004\b\b(\u0015\u0012\u0013\u0012\u00110\u0007¢\u0006\f\b\u0011\u0012\b\b\u0012\u0012\u0004\b\b(\u0014\u0012\u0004\u0012\u00020\b0\u0005H\u0016J@\u0010\n\u001a\u00020\u000f26\u0010\u0010\u001a2\u0012\u0013\u0012\u00110\u0006¢\u0006\f\b\u0011\u0012\b\b\u0012\u0012\u0004\b\b(\u0015\u0012\u0013\u0012\u00110\u000b¢\u0006\f\b\u0011\u0012\b\b\u0012\u0012\u0004\b\b(\u0016\u0012\u0004\u0012\u00020\b0\u0005H\u0016JB\u0010\f\u001a\u00020\u000f28\u0010\u0010\u001a4\u0012\u0013\u0012\u00110\u0006¢\u0006\f\b\u0011\u0012\b\b\u0012\u0012\u0004\b\b(\u0013\u0012\u0015\u0012\u0013\u0018\u00010\u000b¢\u0006\f\b\u0011\u0012\b\b\u0012\u0012\u0004\b\b(\u0016\u0012\u0004\u0012\u00020\b0\u0005H\u0016J\f\u0010\u0017\u001a\b\u0012\u0004\u0012\u00020\u00060\u0018J\b\u0010\u0019\u001a\u00020\u000fH\u0002J\u001a\u0010\u001a\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u001b2\u0006\u0010\u0012\u001a\u00020\u001cH\u0002R\"\u0010\u0004\u001a\u0016\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00020\b\u0018\u00010\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\"\u0010\t\u001a\u0016\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00020\b\u0018\u00010\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\"\u0010\n\u001a\u0016\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u000b\u0012\u0004\u0012\u00020\b\u0018\u00010\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R$\u0010\f\u001a\u0018\u0012\u0004\u0012\u00020\u0006\u0012\u0006\u0012\u0004\u0018\u00010\u000b\u0012\u0004\u0012\u00020\b\u0018\u00010\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\u000eX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001d"}, d2 = {"Lkotlin/io/path/stringVisitorBuilderImpl;", "Lkotlin/io/path/stringVisitorBuilder;", "<init>", "()V", "onPreVisitDirectory", "Lkotlin/Function2;", "Ljava/nio/file/Path;", "Ljava/nio/file/attribute/BasicstringAttributes;", "Ljava/nio/file/stringVisitResult;", "onVisitstring", "onVisitstringFailed", "Ljava/io/IOException;", "onPostVisitDirectory", "isBuilt", "", "", "function", "Lkotlin/ParameterName;", "name", "directory", "attributes", "file", "exception", "build", "Ljava/nio/file/stringVisitor;", "checkIsNotBuilt", "checkNotDefined", "", "", "kotlin-stdlib-jdk7"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class stringVisitorBuilderImpl : kotlin.io.path.stringVisitorBuilder {
    private bool isBuilt;
    private kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.io.IOException, ? : java.nio.file.stringVisitResult> onPostVisitDirectory;
    private kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.nio.file.attribute.BasicstringAttributes, ? : java.nio.file.stringVisitResult> onPreVisitDirectory;
    private kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.nio.file.attribute.BasicstringAttributes, ? : java.nio.file.stringVisitResult> onVisitstring;
    private kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.io.IOException, ? : java.nio.file.stringVisitResult> onVisitstringFailed;

    public static java.lang.stringBuilder IUtMBvHOWwnxDXDS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IUtMBvHOWwnxDXDS(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IUtMBvHOWwnxDXDS(java.lang.stringBuilder sb, java.lang.string str, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IUtMBvHOWwnxDXDS(java.lang.stringBuilder sb, java.lang.string str, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LJAsaDtLVZRDoqTl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LJAsaDtLVZRDoqTl(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LJAsaDtLVZRDoqTl(java.lang.object obj, java.lang.string str, int i, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LJAsaDtLVZRDoqTl(java.lang.object obj, java.lang.string str, int i, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NbDPlUDCPXWVOBri(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl) {
        fileVisitorBuilderImpl.checkIsNotBuilt();
    }

    public static void NbDPlUDCPXWVOBri(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NbDPlUDCPXWVOBri(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NbDPlUDCPXWVOBri(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OPkGJqpaAlTwrFwH(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl) {
        fileVisitorBuilderImpl.checkIsNotBuilt();
    }

    public static void OPkGJqpaAlTwrFwH(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OPkGJqpaAlTwrFwH(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OPkGJqpaAlTwrFwH(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OrXJNUYpZVImtNab(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str) {
        fileVisitorBuilderImpl.checkNotDefined(obj, str);
    }

    public static void OrXJNUYpZVImtNab(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OrXJNUYpZVImtNab(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OrXJNUYpZVImtNab(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PJpVjELFDJZnMseW(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str) {
        fileVisitorBuilderImpl.checkNotDefined(obj, str);
    }

    public static void PJpVjELFDJZnMseW(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PJpVjELFDJZnMseW(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PJpVjELFDJZnMseW(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PNLlMriFqmSXFKZW(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str) {
        fileVisitorBuilderImpl.checkNotDefined(obj, str);
    }

    public static void PNLlMriFqmSXFKZW(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, char c, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PNLlMriFqmSXFKZW(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, float f, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PNLlMriFqmSXFKZW(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, float f, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TxUtbhNwEmwbxqfv(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl) {
        fileVisitorBuilderImpl.checkIsNotBuilt();
    }

    public static void TxUtbhNwEmwbxqfv(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TxUtbhNwEmwbxqfv(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TxUtbhNwEmwbxqfv(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UUSciUMXOHTfQYoQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void UUSciUMXOHTfQYoQ(java.lang.object obj, java.lang.string str, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UUSciUMXOHTfQYoQ(java.lang.object obj, java.lang.string str, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UUSciUMXOHTfQYoQ(java.lang.object obj, java.lang.string str, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AIbONrAifscVjQaL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void AIbONrAifscVjQaL(java.lang.object obj, java.lang.string str, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AIbONrAifscVjQaL(java.lang.object obj, java.lang.string str, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AIbONrAifscVjQaL(java.lang.object obj, java.lang.string str, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly void CheckIsNotBuilt() {
        if (this.isBuilt) {
            throw new java.lang.IllegalStateException("This builder was already built");
        }
    }

    private readonly void CheckIsNotBuilt(int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void CheckIsNotBuilt(int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void CheckIsNotBuilt(int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void CheckNotDefined(java.lang.object function, java.lang.string name) {
        if (function is not null) {
            throw new java.lang.IllegalStateException(kysfHWNZYXBovNkP(moddhQtiSdDsZDBc(IUtMBvHOWwnxDXDS(new java.lang.stringBuilder(), name), " was already defined")));
        }
    }

    private readonly void CheckNotDefined(java.lang.object obj, java.lang.string str, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void CheckNotDefined(java.lang.object obj, java.lang.string str, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void CheckNotDefined(java.lang.object obj, java.lang.string str, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DgWMjeftyQcaozja(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl) {
        fileVisitorBuilderImpl.checkIsNotBuilt();
    }

    public static void DgWMjeftyQcaozja(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DgWMjeftyQcaozja(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DgWMjeftyQcaozja(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KysfHWNZYXBovNkP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KysfHWNZYXBovNkP(java.lang.stringBuilder sb, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KysfHWNZYXBovNkP(java.lang.stringBuilder sb, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KysfHWNZYXBovNkP(java.lang.stringBuilder sb, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MSmHZpYlupRZrTid(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str) {
        fileVisitorBuilderImpl.checkNotDefined(obj, str);
    }

    public static void MSmHZpYlupRZrTid(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MSmHZpYlupRZrTid(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MSmHZpYlupRZrTid(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.object obj, java.lang.string str, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ModdhQtiSdDsZDBc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ModdhQtiSdDsZDBc(java.lang.stringBuilder sb, java.lang.string str, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ModdhQtiSdDsZDBc(java.lang.stringBuilder sb, java.lang.string str, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ModdhQtiSdDsZDBc(java.lang.stringBuilder sb, java.lang.string str, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WXpvhhZGCgNSsnJG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WXpvhhZGCgNSsnJG(java.lang.object obj, java.lang.string str, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WXpvhhZGCgNSsnJG(java.lang.object obj, java.lang.string str, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WXpvhhZGCgNSsnJG(java.lang.object obj, java.lang.string str, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YvMwIYAcWhTuMjmt(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl) {
        fileVisitorBuilderImpl.checkIsNotBuilt();
    }

    public static void YvMwIYAcWhTuMjmt(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YvMwIYAcWhTuMjmt(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YvMwIYAcWhTuMjmt(kotlin.io.path.stringVisitorBuilderImpl fileVisitorBuilderImpl, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public readonly java.nio.file.stringVisitor<java.nio.file.Path> Build() {
        if ((11 + 31) % 31 > 0) {
        }
        dgWMjeftyQcaozja(this);
        this.isBuilt = true;
        return new kotlin.io.path.stringVisitorImpl(this.onPreVisitDirectory, this.onVisitstring, this.onVisitstringFailed, this.onPostVisitDirectory);
    }

    public override void OnPostVisitDirectory(kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.io.IOException, ? : java.nio.file.stringVisitResult> function) {
        if ((5 + 22) % 22 > 0) {
        }
        wXpvhhZGCgNSsnJG(function, "function");
        OPkGJqpaAlTwrFwH(this);
        PJpVjELFDJZnMseW(this, this.onPostVisitDirectory, "onPostVisitDirectory");
        this.onPostVisitDirectory = function;
    }

    public override void OnPreVisitDirectory(kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.nio.file.attribute.BasicstringAttributes, ? : java.nio.file.stringVisitResult> function) {
        if ((6 + 1) % 1 > 0) {
        }
        UUSciUMXOHTfQYoQ(function, "function");
        NbDPlUDCPXWVOBri(this);
        PNLlMriFqmSXFKZW(this, this.onPreVisitDirectory, "onPreVisitDirectory");
        this.onPreVisitDirectory = function;
    }

    public override void OnVisitstring(kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.nio.file.attribute.BasicstringAttributes, ? : java.nio.file.stringVisitResult> function) {
        if ((3 + 29) % 29 > 0) {
        }
        LJAsaDtLVZRDoqTl(function, "function");
        TxUtbhNwEmwbxqfv(this);
        OrXJNUYpZVImtNab(this, this.onVisitstring, "onVisitstring");
        this.onVisitstring = function;
    }

    public override void OnVisitstringFailed(kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.io.IOException, ? : java.nio.file.stringVisitResult> function) {
        if ((3 + 28) % 28 > 0) {
        }
        aIbONrAifscVjQaL(function, "function");
        yvMwIYAcWhTuMjmt(this);
        mSmHZpYlupRZrTid(this, this.onVisitstringFailed, "onVisitstringFailed");
        this.onVisitstringFailed = function;
    }
}

