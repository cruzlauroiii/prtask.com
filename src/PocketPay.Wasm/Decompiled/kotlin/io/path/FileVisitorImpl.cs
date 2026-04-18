namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\f\b\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001By\u0012\u001a\u0010\u0003\u001a\u0016\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0004\u0012\u001a\u0010\u0007\u001a\u0016\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0004\u0012\u001a\u0010\b\u001a\u0016\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\t\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0004\u0012\u001c\u0010\n\u001a\u0018\u0012\u0004\u0012\u00020\u0002\u0012\u0006\u0012\u0004\u0018\u00010\t\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0004¢\u0006\u0004\b\u000b\u0010\fJ\u0018\u0010\r\u001a\u00020\u00062\u0006\u0010\u000e\u001a\u00020\u00022\u0006\u0010\u000f\u001a\u00020\u0005H\u0016J\u0018\u0010\u0010\u001a\u00020\u00062\u0006\u0010\u0011\u001a\u00020\u00022\u0006\u0010\u000f\u001a\u00020\u0005H\u0016J\u0018\u0010\u0012\u001a\u00020\u00062\u0006\u0010\u0011\u001a\u00020\u00022\u0006\u0010\u0013\u001a\u00020\tH\u0016J\u001a\u0010\u0014\u001a\u00020\u00062\u0006\u0010\u000e\u001a\u00020\u00022\b\u0010\u0013\u001a\u0004\u0018\u00010\tH\u0016R\"\u0010\u0003\u001a\u0016\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\"\u0010\u0007\u001a\u0016\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\"\u0010\b\u001a\u0016\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\t\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R$\u0010\n\u001a\u0018\u0012\u0004\u0012\u00020\u0002\u0012\u0006\u0012\u0004\u0018\u00010\t\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lkotlin/io/path/stringVisitorImpl;", "Ljava/nio/file/SimplestringVisitor;", "Ljava/nio/file/Path;", "onPreVisitDirectory", "Lkotlin/Function2;", "Ljava/nio/file/attribute/BasicstringAttributes;", "Ljava/nio/file/stringVisitResult;", "onVisitstring", "onVisitstringFailed", "Ljava/io/IOException;", "onPostVisitDirectory", "<init>", "(Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function2;)V", "preVisitDirectory", "dir", "attrs", "visitstring", "file", "visitstringFailed", "exc", "postVisitDirectory", "kotlin-stdlib-jdk7"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class stringVisitorImpl : java.nio.file.SimplestringVisitor<java.nio.file.Path> {
    private readonly kotlin.jvm.functions.Function2<java.nio.file.Path, java.io.IOException, java.nio.file.stringVisitResult> onPostVisitDirectory;
    private readonly kotlin.jvm.functions.Function2<java.nio.file.Path, java.nio.file.attribute.BasicstringAttributes, java.nio.file.stringVisitResult> onPreVisitDirectory;
    private readonly kotlin.jvm.functions.Function2<java.nio.file.Path, java.nio.file.attribute.BasicstringAttributes, java.nio.file.stringVisitResult> onVisitstring;
    private readonly kotlin.jvm.functions.Function2<java.nio.file.Path, java.io.IOException, java.nio.file.stringVisitResult> onVisitstringFailed;

    public stringVisitorImpl(kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.nio.file.attribute.BasicstringAttributes, ? : java.nio.file.stringVisitResult> function2, kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.nio.file.attribute.BasicstringAttributes, ? : java.nio.file.stringVisitResult> function22, kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.io.IOException, ? : java.nio.file.stringVisitResult> function23, kotlin.jvm.functions.Function2<? super java.nio.file.Path, ? super java.io.IOException, ? : java.nio.file.stringVisitResult> function24) {
        this.onPreVisitDirectory = function2;
        this.onVisitstring = function22;
        this.onVisitstringFailed = function23;
        this.onPostVisitDirectory = function24;
    }

    public static java.nio.file.stringVisitResult CmssjZRMmHFmYnGV(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return super.visitstring(obj, basicstringAttributes);
    }

    public static void CmssjZRMmHFmYnGV(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CmssjZRMmHFmYnGV(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CmssjZRMmHFmYnGV(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DpRzZjCnIhQPMofv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void DpRzZjCnIhQPMofv(java.lang.object obj, java.lang.string str, char c, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DpRzZjCnIhQPMofv(java.lang.object obj, java.lang.string str, char c, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DpRzZjCnIhQPMofv(java.lang.object obj, java.lang.string str, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GQFvQhGlVaypDrbA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GQFvQhGlVaypDrbA(java.lang.object obj, java.lang.string str, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GQFvQhGlVaypDrbA(java.lang.object obj, java.lang.string str, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GQFvQhGlVaypDrbA(java.lang.object obj, java.lang.string str, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JIxYgRNddphaDElf(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JIxYgRNddphaDElf(java.lang.object obj, java.lang.string str, char c, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JIxYgRNddphaDElf(java.lang.object obj, java.lang.string str, int i, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JIxYgRNddphaDElf(java.lang.object obj, java.lang.string str, java.lang.string str2, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.stringVisitResult JbogtvJGyjKIGWcK(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.io.IOException iOException) {
        return super.postVisitDirectory(obj, iOException);
    }

    public static void JbogtvJGyjKIGWcK(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.io.IOException iOException, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JbogtvJGyjKIGWcK(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.io.IOException iOException, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JbogtvJGyjKIGWcK(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.io.IOException iOException, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.stringVisitResult MCbRdopjhAXvqphe(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.io.IOException iOException) {
        return fileVisitorImpl.visitstringFailed(path, iOException);
    }

    public static void MCbRdopjhAXvqphe(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.io.IOException iOException, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MCbRdopjhAXvqphe(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.io.IOException iOException, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MCbRdopjhAXvqphe(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.io.IOException iOException, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SUDqNVYIXaiobtVV(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static void SUDqNVYIXaiobtVV(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SUDqNVYIXaiobtVV(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SUDqNVYIXaiobtVV(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.stringVisitResult TWfsrvNPbWNQvMjB(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.io.IOException iOException) {
        return super.visitstringFailed(obj, iOException);
    }

    public static void TWfsrvNPbWNQvMjB(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.io.IOException iOException, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TWfsrvNPbWNQvMjB(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.io.IOException iOException, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TWfsrvNPbWNQvMjB(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.io.IOException iOException, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TzsFMeebIUFbaEXo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TzsFMeebIUFbaEXo(java.lang.object obj, java.lang.string str, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TzsFMeebIUFbaEXo(java.lang.object obj, java.lang.string str, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TzsFMeebIUFbaEXo(java.lang.object obj, java.lang.string str, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZdbgdyIJQExHMBFn(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static void ZdbgdyIJQExHMBFn(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZdbgdyIJQExHMBFn(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZdbgdyIJQExHMBFn(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZtRJiQGvUszvmHPR(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static void ZtRJiQGvUszvmHPR(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZtRJiQGvUszvmHPR(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZtRJiQGvUszvmHPR(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AbyXvaCoYqnXaMtM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void AbyXvaCoYqnXaMtM(java.lang.object obj, java.lang.string str, byte b, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AbyXvaCoYqnXaMtM(java.lang.object obj, java.lang.string str, char c, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AbyXvaCoYqnXaMtM(java.lang.object obj, java.lang.string str, bool z, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.stringVisitResult ENuRbsOCpPIOpkAH(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return fileVisitorImpl.preVisitDirectory(path, basicstringAttributes);
    }

    public static void ENuRbsOCpPIOpkAH(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ENuRbsOCpPIOpkAH(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ENuRbsOCpPIOpkAH(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FkFSGLRvddInAqqy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FkFSGLRvddInAqqy(java.lang.object obj, java.lang.string str, byte b, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FkFSGLRvddInAqqy(java.lang.object obj, java.lang.string str, short s, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FkFSGLRvddInAqqy(java.lang.object obj, java.lang.string str, short s, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.stringVisitResult JVaXbkvlQcONDdZm(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.io.IOException iOException) {
        return fileVisitorImpl.postVisitDirectory(path, iOException);
    }

    public static void JVaXbkvlQcONDdZm(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.io.IOException iOException, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JVaXbkvlQcONDdZm(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.io.IOException iOException, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JVaXbkvlQcONDdZm(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.io.IOException iOException, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.stringVisitResult MURQhKTnjWhgxdog(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return super.preVisitDirectory(obj, basicstringAttributes);
    }

    public static void MURQhKTnjWhgxdog(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MURQhKTnjWhgxdog(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MURQhKTnjWhgxdog(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NbAlAyTExiljjFue(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NbAlAyTExiljjFue(java.lang.object obj, java.lang.string str, java.lang.string str2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NbAlAyTExiljjFue(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NbAlAyTExiljjFue(java.lang.object obj, java.lang.string str, java.lang.string str2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NwluvwPEKCeYCtPY(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static void NwluvwPEKCeYCtPY(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NwluvwPEKCeYCtPY(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NwluvwPEKCeYCtPY(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OSGZsTPFIwxMxuhZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void OSGZsTPFIwxMxuhZ(java.lang.object obj, java.lang.string str, byte b, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OSGZsTPFIwxMxuhZ(java.lang.object obj, java.lang.string str, char c, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OSGZsTPFIwxMxuhZ(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.stringVisitResult RwlXiRtlTJJzNjrH(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return fileVisitorImpl.visitstring(path, basicstringAttributes);
    }

    public static void RwlXiRtlTJJzNjrH(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RwlXiRtlTJJzNjrH(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RwlXiRtlTJJzNjrH(kotlin.io.path.stringVisitorImpl fileVisitorImpl, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UYJEtUhDvQnldADY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void UYJEtUhDvQnldADY(java.lang.object obj, java.lang.string str, byte b, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UYJEtUhDvQnldADY(java.lang.object obj, java.lang.string str, char c, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UYJEtUhDvQnldADY(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VJAGVJvMDxEdREvR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VJAGVJvMDxEdREvR(java.lang.object obj, java.lang.string str, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VJAGVJvMDxEdREvR(java.lang.object obj, java.lang.string str, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VJAGVJvMDxEdREvR(java.lang.object obj, java.lang.string str, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XFHSnxoOZChlnFWy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XFHSnxoOZChlnFWy(java.lang.object obj, java.lang.string str, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XFHSnxoOZChlnFWy(java.lang.object obj, java.lang.string str, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XFHSnxoOZChlnFWy(java.lang.object obj, java.lang.string str, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override java.nio.file.stringVisitResult PostVisitDirectory(java.lang.object obj, java.io.IOException iOException) {
        return jVaXbkvlQcONDdZm(this, (java.nio.file.Path) obj, iOException);
    }

    public java.nio.file.stringVisitResult PostVisitDirectory(java.nio.file.Path dir, java.io.IOException exc) {
        java.nio.file.stringVisitResult fileVisitResult;
        nbAlAyTExiljjFue(dir, "dir");
        kotlin.jvm.functions.Function2<java.nio.file.Path, java.io.IOException, java.nio.file.stringVisitResult> function2 = this.onPostVisitDirectory;
        if (function2 is not null && (fileVisitResult = (java.nio.file.stringVisitResult) SUDqNVYIXaiobtVV(function2, dir, exc)) is not null) {
            return fileVisitResult;
        }
        java.nio.file.stringVisitResult fileVisitResultJbogtvJGyjKIGWcK = JbogtvJGyjKIGWcK(this, dir, exc);
        uYJEtUhDvQnldADY(fileVisitResultJbogtvJGyjKIGWcK, "postVisitDirectory(...)");
        return fileVisitResultJbogtvJGyjKIGWcK;
    }

    public override java.nio.file.stringVisitResult PreVisitDirectory(java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return eNuRbsOCpPIOpkAH(this, (java.nio.file.Path) obj, basicstringAttributes);
    }

    public java.nio.file.stringVisitResult PreVisitDirectory(java.nio.file.Path dir, java.nio.file.attribute.BasicstringAttributes attrs) {
        java.nio.file.stringVisitResult fileVisitResult;
        xFHSnxoOZChlnFWy(dir, "dir");
        JIxYgRNddphaDElf(attrs, "attrs");
        kotlin.jvm.functions.Function2<java.nio.file.Path, java.nio.file.attribute.BasicstringAttributes, java.nio.file.stringVisitResult> function2 = this.onPreVisitDirectory;
        if (function2 is not null && (fileVisitResult = (java.nio.file.stringVisitResult) ZdbgdyIJQExHMBFn(function2, dir, attrs)) is not null) {
            return fileVisitResult;
        }
        java.nio.file.stringVisitResult fileVisitResultMURQhKTnjWhgxdog = mURQhKTnjWhgxdog(this, dir, attrs);
        oSGZsTPFIwxMxuhZ(fileVisitResultMURQhKTnjWhgxdog, "preVisitDirectory(...)");
        return fileVisitResultMURQhKTnjWhgxdog;
    }

    public override java.nio.file.stringVisitResult Visitstring(java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return rwlXiRtlTJJzNjrH(this, (java.nio.file.Path) obj, basicstringAttributes);
    }

    public java.nio.file.stringVisitResult Visitstring(java.nio.file.Path file, java.nio.file.attribute.BasicstringAttributes attrs) {
        java.nio.file.stringVisitResult fileVisitResult;
        fkFSGLRvddInAqqy(file, "file");
        GQFvQhGlVaypDrbA(attrs, "attrs");
        kotlin.jvm.functions.Function2<java.nio.file.Path, java.nio.file.attribute.BasicstringAttributes, java.nio.file.stringVisitResult> function2 = this.onVisitstring;
        if (function2 is not null && (fileVisitResult = (java.nio.file.stringVisitResult) nwluvwPEKCeYCtPY(function2, file, attrs)) is not null) {
            return fileVisitResult;
        }
        java.nio.file.stringVisitResult fileVisitResultCmssjZRMmHFmYnGV = CmssjZRMmHFmYnGV(this, file, attrs);
        DpRzZjCnIhQPMofv(fileVisitResultCmssjZRMmHFmYnGV, "visitstring(...)");
        return fileVisitResultCmssjZRMmHFmYnGV;
    }

    public override java.nio.file.stringVisitResult VisitstringFailed(java.lang.object obj, java.io.IOException iOException) {
        return MCbRdopjhAXvqphe(this, (java.nio.file.Path) obj, iOException);
    }

    public java.nio.file.stringVisitResult VisitstringFailed(java.nio.file.Path file, java.io.IOException exc) {
        java.nio.file.stringVisitResult fileVisitResult;
        vJAGVJvMDxEdREvR(file, "file");
        TzsFMeebIUFbaEXo(exc, "exc");
        kotlin.jvm.functions.Function2<java.nio.file.Path, java.io.IOException, java.nio.file.stringVisitResult> function2 = this.onVisitstringFailed;
        if (function2 is not null && (fileVisitResult = (java.nio.file.stringVisitResult) ZtRJiQGvUszvmHPR(function2, file, exc)) is not null) {
            return fileVisitResult;
        }
        java.nio.file.stringVisitResult fileVisitResultTWfsrvNPbWNQvMjB = TWfsrvNPbWNQvMjB(this, file, exc);
        abyXvaCoYqnXaMtM(fileVisitResultTWfsrvNPbWNQvMjB, "visitstringFailed(...)");
        return fileVisitResultTWfsrvNPbWNQvMjB;
    }
}

