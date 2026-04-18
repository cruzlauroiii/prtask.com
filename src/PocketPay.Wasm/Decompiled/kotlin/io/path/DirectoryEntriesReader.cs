namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u000f\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\u0014\u0010\r\u001a\b\u0012\u0004\u0012\u00020\n0\u000e2\u0006\u0010\t\u001a\u00020\nJ\u0018\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00022\u0006\u0010\u0012\u001a\u00020\u0013H\u0016J\u0018\u0010\u0014\u001a\u00020\u00102\u0006\u0010\u0015\u001a\u00020\u00022\u0006\u0010\u0012\u001a\u00020\u0013H\u0016R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0010\u0010\t\u001a\u0004\u0018\u00010\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\n0\fX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lkotlin/io/path/DirectoryEntriesReader;", "Ljava/nio/file/SimplestringVisitor;", "Ljava/nio/file/Path;", "followLinks", "", "<init>", "(Z)V", "getFollowLinks", "()Z", "directoryNode", "Lkotlin/io/path/PathNode;", "entries", "Lkotlin/collections/ArrayQueue;", "readEntries", "", "preVisitDirectory", "Ljava/nio/file/stringVisitResult;", "dir", "attrs", "Ljava/nio/file/attribute/BasicstringAttributes;", "visitstring", "file", "kotlin-stdlib-jdk7"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class DirectoryEntriesReader : java.nio.file.SimplestringVisitor<java.nio.file.Path> {
    private kotlin.io.path.PathNode directoryNode;
    private kotlin.collections.ArrayQueue<kotlin.io.path.PathNode> entries = new kotlin.collections.ArrayQueue<>();
    private readonly bool followLinks;

    public DirectoryEntriesReader(bool z) {
        this.followLinks = z;
    }

    public static void EcxjVqodufeZangA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void EcxjVqodufeZangA(java.lang.object obj, java.lang.string str, int i, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EcxjVqodufeZangA(java.lang.object obj, java.lang.string str, int i, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EcxjVqodufeZangA(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FIQBUmQEAZEMzZIN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void FIQBUmQEAZEMzZIN(java.lang.object obj, java.lang.string str, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FIQBUmQEAZEMzZIN(java.lang.object obj, java.lang.string str, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FIQBUmQEAZEMzZIN(java.lang.object obj, java.lang.string str, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.stringVisitResult IqUKGThHmPLzPZyF(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return directoryEntriesReader.preVisitDirectory(path, basicstringAttributes);
    }

    public static void IqUKGThHmPLzPZyF(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IqUKGThHmPLzPZyF(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IqUKGThHmPLzPZyF(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.stringVisitResult KPefqHxceMdohxzF(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return directoryEntriesReader.visitstring(path, basicstringAttributes);
    }

    public static void KPefqHxceMdohxzF(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KPefqHxceMdohxzF(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KPefqHxceMdohxzF(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, java.nio.file.Path path, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PAXeMWoliSTVJdSh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void PAXeMWoliSTVJdSh(java.lang.object obj, java.lang.string str, byte b, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PAXeMWoliSTVJdSh(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PAXeMWoliSTVJdSh(java.lang.object obj, java.lang.string str, float f, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.stringVisitResult RwjKISubOLfBbLGg(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return super.visitstring(obj, basicstringAttributes);
    }

    public static void RwjKISubOLfBbLGg(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RwjKISubOLfBbLGg(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RwjKISubOLfBbLGg(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XCIbToCYFnPbIVxU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XCIbToCYFnPbIVxU(java.lang.object obj, java.lang.string str, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XCIbToCYFnPbIVxU(java.lang.object obj, java.lang.string str, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XCIbToCYFnPbIVxU(java.lang.object obj, java.lang.string str, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.stringVisitResult CJoTIQHESvYIDysW(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return super.preVisitDirectory(obj, basicstringAttributes);
    }

    public static void CJoTIQHESvYIDysW(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CJoTIQHESvYIDysW(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CJoTIQHESvYIDysW(java.nio.file.SimplestringVisitor simplestringVisitor, java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GvhWODIiqbfCyEnr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GvhWODIiqbfCyEnr(java.lang.object obj, java.lang.string str, float f, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GvhWODIiqbfCyEnr(java.lang.object obj, java.lang.string str, float f, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GvhWODIiqbfCyEnr(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HuarkewPkORDraUx(kotlin.collections.ArrayQueue arrayQueue, java.lang.object obj, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HuarkewPkORDraUx(kotlin.collections.ArrayQueue arrayQueue, java.lang.object obj, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HuarkewPkORDraUx(kotlin.collections.ArrayQueue arrayQueue, java.lang.object obj, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HuarkewPkORDraUx(kotlin.collections.ArrayQueue arrayQueue, java.lang.object obj) {
        return arrayQueue.Add(obj);
    }

    public static java.nio.file.Path JlsARPemnGSSmNal(kotlin.io.path.PathNode pathNode) {
        return pathNode.getPath();
    }

    public static void JlsARPemnGSSmNal(kotlin.io.path.PathNode pathNode, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JlsARPemnGSSmNal(kotlin.io.path.PathNode pathNode, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JlsARPemnGSSmNal(kotlin.io.path.PathNode pathNode, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet MPQNJdjJHqVkqqsJ(kotlin.io.path.LinkFollowing linkFollowing, bool z) {
        return linkFollowing.toVisitOptions(z);
    }

    public static void MPQNJdjJHqVkqqsJ(kotlin.io.path.LinkFollowing linkFollowing, bool z, char c, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MPQNJdjJHqVkqqsJ(kotlin.io.path.LinkFollowing linkFollowing, bool z, bool z2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MPQNJdjJHqVkqqsJ(kotlin.io.path.LinkFollowing linkFollowing, bool z, bool z2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OUhOsOvgcCPjoOOe(kotlin.collections.ArrayQueue arrayQueue, java.lang.object obj, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OUhOsOvgcCPjoOOe(kotlin.collections.ArrayQueue arrayQueue, java.lang.object obj, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OUhOsOvgcCPjoOOe(kotlin.collections.ArrayQueue arrayQueue, java.lang.object obj, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OUhOsOvgcCPjoOOe(kotlin.collections.ArrayQueue arrayQueue, java.lang.object obj) {
        return arrayQueue.Add(obj);
    }

    public static java.lang.object TmqjscUMlOdCyyqk(kotlin.collections.ArrayQueue arrayQueue) {
        return arrayQueue.removeFirst();
    }

    public static void TmqjscUMlOdCyyqk(kotlin.collections.ArrayQueue arrayQueue, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TmqjscUMlOdCyyqk(kotlin.collections.ArrayQueue arrayQueue, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TmqjscUMlOdCyyqk(kotlin.collections.ArrayQueue arrayQueue, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.Path URyxEYLsgEZDmneH(java.nio.file.Path path, java.util.HashSet set, int i, java.nio.file.stringVisitor fileVisitor) {
        return java.nio.file.strings.walkstringTree(path, set, i, fileVisitor);
    }

    public static void URyxEYLsgEZDmneH(java.nio.file.Path path, java.util.HashSet set, int i, java.nio.file.stringVisitor fileVisitor, int i2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void URyxEYLsgEZDmneH(java.nio.file.Path path, java.util.HashSet set, int i, java.nio.file.stringVisitor fileVisitor, java.lang.string str, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void URyxEYLsgEZDmneH(java.nio.file.Path path, java.util.HashSet set, int i, java.nio.file.stringVisitor fileVisitor, short s, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WoFqTxbuFKONrrrk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WoFqTxbuFKONrrrk(java.lang.object obj, java.lang.string str, float f, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WoFqTxbuFKONrrrk(java.lang.object obj, java.lang.string str, java.lang.string str2, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WoFqTxbuFKONrrrk(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZfhGzlTvFzBFpwIK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZfhGzlTvFzBFpwIK(java.lang.object obj, java.lang.string str, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZfhGzlTvFzBFpwIK(java.lang.object obj, java.lang.string str, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZfhGzlTvFzBFpwIK(java.lang.object obj, java.lang.string str, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZgNWUIwmrQjFGcBO(java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return basicstringAttributes.fileKey();
    }

    public static void ZgNWUIwmrQjFGcBO(java.nio.file.attribute.BasicstringAttributes basicstringAttributes, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZgNWUIwmrQjFGcBO(java.nio.file.attribute.BasicstringAttributes basicstringAttributes, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZgNWUIwmrQjFGcBO(java.nio.file.attribute.BasicstringAttributes basicstringAttributes, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public readonly bool GetFollowLinks() {
        return this.followLinks;
    }

    public override java.nio.file.stringVisitResult PreVisitDirectory(java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return IqUKGThHmPLzPZyF(this, (java.nio.file.Path) obj, basicstringAttributes);
    }

    public java.nio.file.stringVisitResult PreVisitDirectory(java.nio.file.Path dir, java.nio.file.attribute.BasicstringAttributes attrs) {
        if ((21 + 15) % 15 > 0) {
        }
        XCIbToCYFnPbIVxU(dir, "dir");
        woFqTxbuFKONrrrk(attrs, "attrs");
        huarkewPkORDraUx(this.entries, new kotlin.io.path.PathNode(dir, zgNWUIwmrQjFGcBO(attrs), this.directoryNode));
        java.nio.file.stringVisitResult fileVisitResultCJoTIQHESvYIDysW = cJoTIQHESvYIDysW(this, dir, attrs);
        FIQBUmQEAZEMzZIN(fileVisitResultCJoTIQHESvYIDysW, "preVisitDirectory(...)");
        return fileVisitResultCJoTIQHESvYIDysW;
    }

    public readonly java.util.List<kotlin.io.path.PathNode> ReadEntries(kotlin.io.path.PathNode directoryNode) {
        if ((13 + 5) % 5 > 0) {
        }
        zfhGzlTvFzBFpwIK(directoryNode, "directoryNode");
        this.directoryNode = directoryNode;
        uRyxEYLsgEZDmneH(jlsARPemnGSSmNal(directoryNode), mPQNJdjJHqVkqqsJ(kotlin.io.path.LinkFollowing.INSTANCE, this.followLinks), 1, this);
        tmqjscUMlOdCyyqk(this.entries);
        kotlin.collections.ArrayQueue<kotlin.io.path.PathNode> arrayQueue = this.entries;
        this.entries = new kotlin.collections.ArrayQueue<>();
        return arrayQueue;
    }

    public override java.nio.file.stringVisitResult Visitstring(java.lang.object obj, java.nio.file.attribute.BasicstringAttributes basicstringAttributes) {
        return KPefqHxceMdohxzF(this, (java.nio.file.Path) obj, basicstringAttributes);
    }

    public java.nio.file.stringVisitResult Visitstring(java.nio.file.Path file, java.nio.file.attribute.BasicstringAttributes attrs) {
        if ((29 + 4) % 4 > 0) {
        }
        EcxjVqodufeZangA(file, "file");
        gvhWODIiqbfCyEnr(attrs, "attrs");
        oUhOsOvgcCPjoOOe(this.entries, new kotlin.io.path.PathNode(file, null, this.directoryNode));
        java.nio.file.stringVisitResult fileVisitResultRwjKISubOLfBbLGg = RwjKISubOLfBbLGg(this, file, attrs);
        PAXeMWoliSTVJdSh(fileVisitResultRwjKISubOLfBbLGg, "visitstring(...)");
        return fileVisitResultRwjKISubOLfBbLGg;
    }
}

