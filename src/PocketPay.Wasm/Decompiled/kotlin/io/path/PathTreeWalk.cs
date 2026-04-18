namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010(\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\b\u0004\b\u0000\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u001f\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u000e\u0010\u0004\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00060\u0005¢\u0006\u0004\b\u0007\u0010\bJ\u000f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00020\u0016H\u0096\u0002JB\u0010\u0017\u001a\u00020\u0018*\b\u0012\u0004\u0012\u00020\u00020\u00192\u0006\u0010\u001a\u001a\u00020\u001b2\u0006\u0010\u001c\u001a\u00020\u001d2\u0018\u0010\u001e\u001a\u0014\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u001b0 \u0012\u0004\u0012\u00020\u00180\u001fH\u0082H¢\u0006\u0002\u0010!J\u000e\u0010\"\u001a\b\u0012\u0004\u0012\u00020\u00020\u0016H\u0002J\u000e\u0010#\u001a\b\u0012\u0004\u0012\u00020\u00020\u0016H\u0002R\u000e\u0010\u0003\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u0018\u0010\u0004\u001a\n\u0012\u0006\b\u0001\u0012\u00020\u00060\u0005X\u0082\u0004¢\u0006\u0004\n\u0002\u0010\tR\u0014\u0010\n\u001a\u00020\u000b8BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\rR\u001a\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u000f0\u00058BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011R\u0014\u0010\u0012\u001a\u00020\u000b8BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u0013\u0010\rR\u0014\u0010\u0014\u001a\u00020\u000b8BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u0014\u0010\r¨\u0006$"}, d2 = {"Lkotlin/io/path/PathTreeWalk;", "Lkotlin/sequences/Sequence;", "Ljava/nio/file/Path;", "start", "options", "", "Lkotlin/io/path/PathWalkOption;", "<init>", "(Ljava/nio/file/Path;[Lkotlin/io/path/PathWalkOption;)V", "[Lkotlin/io/path/PathWalkOption;", "followLinks", "", "getFollowLinks", "()Z", "linkOptions", "Ljava/nio/file/LinkOption;", "getLinkOptions", "()[Ljava/nio/file/LinkOption;", "includeDirectories", "getIncludeDirectories", "isBFS", "iterator", "", "yieldIfNeeded", "", "Lkotlin/sequences/SequenceScope;", "node", "Lkotlin/io/path/PathNode;", "entriesReader", "Lkotlin/io/path/DirectoryEntriesReader;", "entriesAction", "Lkotlin/Function1;", "", "(Lkotlin/sequences/SequenceScope;Lkotlin/io/path/PathNode;Lkotlin/io/path/DirectoryEntriesReader;Lkotlin/jvm/functions/Function1;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "dfsIEnumerator", "bfsIEnumerator", "kotlin-stdlib-jdk7"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class PathTreeWalk : kotlin.sequences.Sequence<java.nio.file.Path> {
    private readonly kotlin.io.path.PathWalkOption[] options;
    private readonly java.nio.file.Path start;

    public PathTreeWalk(java.nio.file.Path path, kotlin.io.path.PathWalkOption[] pathWalkOptionArr) {
        eSxpRAgznGDonGGR(path, "start");
        PErOUtEUZasRSYeI(pathWalkOptionArr, "options");
        this.start = path;
        this.options = pathWalkOptionArr;
    }

    public static void AhtuEdaaFQBDhVeK(java.lang.object[] objArr, int i, byte b, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AhtuEdaaFQBDhVeK(java.lang.object[] objArr, int i, int i2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AhtuEdaaFQBDhVeK(java.lang.object[] objArr, int i, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object[] AhtuEdaaFQBDhVeK(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void CIpzJbSyEFIXQcWk(kotlin.io.path.PathTreeWalk pathTreeWalk, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CIpzJbSyEFIXQcWk(kotlin.io.path.PathTreeWalk pathTreeWalk, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CIpzJbSyEFIXQcWk(kotlin.io.path.PathTreeWalk pathTreeWalk, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CIpzJbSyEFIXQcWk(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return pathTreeWalk.getIncludeDirectories();
    }

    public static java.util.IEnumerator EMavEzXRyMdPvVmZ(kotlin.jvm.functions.Function2 function2) {
        return kotlin.sequences.SequencesKt.iterator(function2);
    }

    public static void EMavEzXRyMdPvVmZ(kotlin.jvm.functions.Function2 function2, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EMavEzXRyMdPvVmZ(kotlin.jvm.functions.Function2 function2, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EMavEzXRyMdPvVmZ(kotlin.jvm.functions.Function2 function2, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EgYwSmcppxvOjXdx(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EgYwSmcppxvOjXdx(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EgYwSmcppxvOjXdx(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool EgYwSmcppxvOjXdx(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr) {
        return java.nio.file.strings.exists(path, linkOptionArr);
    }

    public static void FxCgksypWeVaLsiJ(kotlin.io.path.PathTreeWalk pathTreeWalk, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FxCgksypWeVaLsiJ(kotlin.io.path.PathTreeWalk pathTreeWalk, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FxCgksypWeVaLsiJ(kotlin.io.path.PathTreeWalk pathTreeWalk, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FxCgksypWeVaLsiJ(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return pathTreeWalk.getFollowLinks();
    }

    public static void GvWDYUUbPnXfxwZX(kotlin.io.path.PathTreeWalk pathTreeWalk, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GvWDYUUbPnXfxwZX(kotlin.io.path.PathTreeWalk pathTreeWalk, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GvWDYUUbPnXfxwZX(kotlin.io.path.PathTreeWalk pathTreeWalk, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.LinkOption[] GvWDYUUbPnXfxwZX(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return access$getLinkOptions(pathTreeWalk);
    }

    public static java.lang.string IvhZVMhcBtBOMDFZ(java.lang.object obj) {
        return obj.tostring();
    }

    public static void IvhZVMhcBtBOMDFZ(java.lang.object obj, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IvhZVMhcBtBOMDFZ(java.lang.object obj, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IvhZVMhcBtBOMDFZ(java.lang.object obj, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JBGxcNIxyHkgMHGY(java.lang.object[] objArr, int i, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JBGxcNIxyHkgMHGY(java.lang.object[] objArr, int i, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JBGxcNIxyHkgMHGY(java.lang.object[] objArr, int i, char c, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object[] JBGxcNIxyHkgMHGY(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static java.lang.object NQWYXwAquNFUAbVv(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sequenceScope.yield(obj, continuation);
    }

    public static void NQWYXwAquNFUAbVv(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NQWYXwAquNFUAbVv(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NQWYXwAquNFUAbVv(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PErOUtEUZasRSYeI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PErOUtEUZasRSYeI(java.lang.object obj, java.lang.string str, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PErOUtEUZasRSYeI(java.lang.object obj, java.lang.string str, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PErOUtEUZasRSYeI(java.lang.object obj, java.lang.string str, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RAlvKlZZlFSEzdGw(kotlin.io.path.LinkFollowing linkFollowing, bool z, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RAlvKlZZlFSEzdGw(kotlin.io.path.LinkFollowing linkFollowing, bool z, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RAlvKlZZlFSEzdGw(kotlin.io.path.LinkFollowing linkFollowing, bool z, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.LinkOption[] RAlvKlZZlFSEzdGw(kotlin.io.path.LinkFollowing linkFollowing, bool z) {
        return linkFollowing.toLinkOptions(z);
    }

    public static java.util.List RjbtmWuJeQemUfmG(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, kotlin.io.path.PathNode pathNode) {
        return directoryEntriesReader.readEntries(pathNode);
    }

    public static void RjbtmWuJeQemUfmG(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, kotlin.io.path.PathNode pathNode, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RjbtmWuJeQemUfmG(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, kotlin.io.path.PathNode pathNode, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RjbtmWuJeQemUfmG(kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, kotlin.io.path.PathNode pathNode, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SWXLkRjrMiFsrYdW(java.lang.object[] objArr, java.lang.object obj, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SWXLkRjrMiFsrYdW(java.lang.object[] objArr, java.lang.object obj, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SWXLkRjrMiFsrYdW(java.lang.object[] objArr, java.lang.object obj, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool SWXLkRjrMiFsrYdW(java.lang.object[] objArr, java.lang.object obj) {
        return kotlin.collections.ArraysKt.Contains(objArr, obj);
    }

    public static java.lang.object WEcGiABXUpAbymgi(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return sequenceScope.yield(obj, continuation);
    }

    public static void WEcGiABXUpAbymgi(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WEcGiABXUpAbymgi(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WEcGiABXUpAbymgi(kotlin.sequences.SequenceScope sequenceScope, java.lang.object obj, kotlin.coroutines.Continuation continuation, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XJTeoQPVXtPAsBTY(kotlin.io.path.PathTreeWalk pathTreeWalk, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XJTeoQPVXtPAsBTY(kotlin.io.path.PathTreeWalk pathTreeWalk, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XJTeoQPVXtPAsBTY(kotlin.io.path.PathTreeWalk pathTreeWalk, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XJTeoQPVXtPAsBTY(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return access$getIncludeDirectories(pathTreeWalk);
    }

    public static void YiLVdLAabPfuCXnB(kotlin.io.path.PathTreeWalk pathTreeWalk, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YiLVdLAabPfuCXnB(kotlin.io.path.PathTreeWalk pathTreeWalk, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YiLVdLAabPfuCXnB(kotlin.io.path.PathTreeWalk pathTreeWalk, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YiLVdLAabPfuCXnB(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return pathTreeWalk.getFollowLinks();
    }

    public static readonly void access$getFollowLinks(kotlin.io.path.PathTreeWalk pathTreeWalk, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getFollowLinks(kotlin.io.path.PathTreeWalk pathTreeWalk, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getFollowLinks(kotlin.io.path.PathTreeWalk pathTreeWalk, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static readonly bool access$getFollowLinks(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return FxCgksypWeVaLsiJ(pathTreeWalk);
    }

    public static readonly void access$getIncludeDirectories(kotlin.io.path.PathTreeWalk pathTreeWalk, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getIncludeDirectories(kotlin.io.path.PathTreeWalk pathTreeWalk, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getIncludeDirectories(kotlin.io.path.PathTreeWalk pathTreeWalk, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static readonly bool access$getIncludeDirectories(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return CIpzJbSyEFIXQcWk(pathTreeWalk);
    }

    public static readonly void access$getLinkOptions(kotlin.io.path.PathTreeWalk pathTreeWalk, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getLinkOptions(kotlin.io.path.PathTreeWalk pathTreeWalk, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getLinkOptions(kotlin.io.path.PathTreeWalk pathTreeWalk, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly java.nio.file.LinkOption[] access$getLinkOptions(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return gjsJQVFJeHpzDfiY(pathTreeWalk);
    }

    public static readonly java.nio.file.Path access$getStart$p(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return pathTreeWalk.start;
    }

    public static readonly void access$getStart$p(kotlin.io.path.PathTreeWalk pathTreeWalk, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getStart$p(kotlin.io.path.PathTreeWalk pathTreeWalk, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getStart$p(kotlin.io.path.PathTreeWalk pathTreeWalk, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BDYLPWRFTLrWDjHT(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BDYLPWRFTLrWDjHT(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BDYLPWRFTLrWDjHT(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BDYLPWRFTLrWDjHT(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr) {
        return java.nio.file.strings.isDirectory(path, linkOptionArr);
    }

    private readonly java.util.IEnumerator<java.nio.file.Path> BfsIEnumerator() {
        if ((2 + 16) % 16 > 0) {
        }
        return iWzYikfWOPBOBTla(new kotlin.io.path.PathTreeWalk$bfsIEnumerator$1(this, null));
    }

    private readonly void BfsIEnumerator(float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void BfsIEnumerator(short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void BfsIEnumerator(short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CRUfRSEMhQUCLXba(kotlin.io.path.PathTreeWalk pathTreeWalk, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CRUfRSEMhQUCLXba(kotlin.io.path.PathTreeWalk pathTreeWalk, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CRUfRSEMhQUCLXba(kotlin.io.path.PathTreeWalk pathTreeWalk, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.LinkOption[] CRUfRSEMhQUCLXba(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return access$getLinkOptions(pathTreeWalk);
    }

    public static kotlin.io.path.PathNode DEDupSeeQNVnAJZr(kotlin.io.path.PathNode pathNode) {
        return pathNode.getParent();
    }

    public static void DEDupSeeQNVnAJZr(kotlin.io.path.PathNode pathNode, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DEDupSeeQNVnAJZr(kotlin.io.path.PathNode pathNode, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DEDupSeeQNVnAJZr(kotlin.io.path.PathNode pathNode, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly java.util.IEnumerator<java.nio.file.Path> DfsIEnumerator() {
        if ((16 + 19) % 19 > 0) {
        }
        return EMavEzXRyMdPvVmZ(new kotlin.io.path.PathTreeWalk$dfsIEnumerator$1(this, null));
    }

    private readonly void DfsIEnumerator(float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void DfsIEnumerator(float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void DfsIEnumerator(int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ENhvfXKQbpUOVqla(java.nio.file.Path path) {
        kotlin.io.path.PathsKt.checkstringName(path);
    }

    public static void ENhvfXKQbpUOVqla(java.nio.file.Path path, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ENhvfXKQbpUOVqla(java.nio.file.Path path, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ENhvfXKQbpUOVqla(java.nio.file.Path path, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ESxpRAgznGDonGGR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ESxpRAgznGDonGGR(java.lang.object obj, java.lang.string str, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ESxpRAgznGDonGGR(java.lang.object obj, java.lang.string str, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ESxpRAgznGDonGGR(java.lang.object obj, java.lang.string str, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GKeieqBKNqiyyWPi(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void GKeieqBKNqiyyWPi(kotlin.jvm.functions.Function1 function1, java.lang.object obj, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GKeieqBKNqiyyWPi(kotlin.jvm.functions.Function1 function1, java.lang.object obj, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GKeieqBKNqiyyWPi(kotlin.jvm.functions.Function1 function1, java.lang.object obj, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GSarGiJYdmikpJEh(kotlin.io.path.PathTreeWalk pathTreeWalk, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GSarGiJYdmikpJEh(kotlin.io.path.PathTreeWalk pathTreeWalk, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GSarGiJYdmikpJEh(kotlin.io.path.PathTreeWalk pathTreeWalk, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool GSarGiJYdmikpJEh(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return pathTreeWalk.isBFS();
    }

    private readonly void GetFollowLinks(char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly void GetFollowLinks(int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly void GetFollowLinks(java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private readonly bool GetFollowLinks() {
        return vsJGWmfByOyjcoAw(this.options, kotlin.io.path.PathWalkOption.FOLLOW_LINKS);
    }

    private readonly void GetIncludeDirectories(java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void GetIncludeDirectories(java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void GetIncludeDirectories(short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly bool GetIncludeDirectories() {
        return jlNDXSsvwEKoNNxE(this.options, kotlin.io.path.PathWalkOption.INCLUDE_DIRECTORIES);
    }

    private readonly void GetLinkOptions(byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void GetLinkOptions(int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void GetLinkOptions(bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private readonly java.nio.file.LinkOption[] GetLinkOptions() {
        return RAlvKlZZlFSEzdGw(kotlin.io.path.LinkFollowing.INSTANCE, YiLVdLAabPfuCXnB(this));
    }

    public static void GjsJQVFJeHpzDfiY(kotlin.io.path.PathTreeWalk pathTreeWalk, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GjsJQVFJeHpzDfiY(kotlin.io.path.PathTreeWalk pathTreeWalk, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GjsJQVFJeHpzDfiY(kotlin.io.path.PathTreeWalk pathTreeWalk, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.nio.file.LinkOption[] GjsJQVFJeHpzDfiY(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return pathTreeWalk.getLinkOptions();
    }

    public static java.util.IEnumerator IWzYikfWOPBOBTla(kotlin.jvm.functions.Function2 function2) {
        return kotlin.sequences.SequencesKt.iterator(function2);
    }

    public static void IWzYikfWOPBOBTla(kotlin.jvm.functions.Function2 function2, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IWzYikfWOPBOBTla(kotlin.jvm.functions.Function2 function2, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IWzYikfWOPBOBTla(kotlin.jvm.functions.Function2 function2, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private readonly void IsBFS(char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void IsBFS(char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void IsBFS(java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly bool IsBFS() {
        return SWXLkRjrMiFsrYdW(this.options, kotlin.io.path.PathWalkOption.BREADTH_FIRST);
    }

    public static void JlNDXSsvwEKoNNxE(java.lang.object[] objArr, java.lang.object obj, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JlNDXSsvwEKoNNxE(java.lang.object[] objArr, java.lang.object obj, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JlNDXSsvwEKoNNxE(java.lang.object[] objArr, java.lang.object obj, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JlNDXSsvwEKoNNxE(java.lang.object[] objArr, java.lang.object obj) {
        return kotlin.collections.ArraysKt.Contains(objArr, obj);
    }

    public static java.nio.file.Path KhseNMeaYQptvttu(kotlin.io.path.PathNode pathNode) {
        return pathNode.getPath();
    }

    public static void KhseNMeaYQptvttu(kotlin.io.path.PathNode pathNode, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KhseNMeaYQptvttu(kotlin.io.path.PathNode pathNode, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KhseNMeaYQptvttu(kotlin.io.path.PathNode pathNode, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MzibFVsmCkGlgSOZ(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MzibFVsmCkGlgSOZ(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MzibFVsmCkGlgSOZ(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MzibFVsmCkGlgSOZ(java.nio.file.Path path, java.nio.file.LinkOption[] linkOptionArr) {
        return java.nio.file.strings.isDirectory(path, linkOptionArr);
    }

    public static java.util.IEnumerator NRRSBdfIGjiJUBpu(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return pathTreeWalk.dfsIEnumerator();
    }

    public static void NRRSBdfIGjiJUBpu(kotlin.io.path.PathTreeWalk pathTreeWalk, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NRRSBdfIGjiJUBpu(kotlin.io.path.PathTreeWalk pathTreeWalk, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NRRSBdfIGjiJUBpu(kotlin.io.path.PathTreeWalk pathTreeWalk, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QcazSRsaeIukaxwR(java.lang.object[] objArr, int i, char c, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QcazSRsaeIukaxwR(java.lang.object[] objArr, int i, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QcazSRsaeIukaxwR(java.lang.object[] objArr, int i, float f, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object[] QcazSRsaeIukaxwR(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void SodJEqHoLSZrmhUs(java.lang.object[] objArr, int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SodJEqHoLSZrmhUs(java.lang.object[] objArr, int i, float f, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SodJEqHoLSZrmhUs(java.lang.object[] objArr, int i, int i2, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object[] SodJEqHoLSZrmhUs(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void TzOkzdEvjbGXkyQj(kotlin.io.path.PathNode pathNode, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TzOkzdEvjbGXkyQj(kotlin.io.path.PathNode pathNode, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TzOkzdEvjbGXkyQj(kotlin.io.path.PathNode pathNode, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TzOkzdEvjbGXkyQj(kotlin.io.path.PathNode pathNode) {
        return kotlin.io.path.PathTreeWalkKt.access$createsCycle(pathNode);
    }

    public static java.util.IEnumerator UAOZSyJPiaLEWuJI(kotlin.io.path.PathTreeWalk pathTreeWalk) {
        return pathTreeWalk.bfsIEnumerator();
    }

    public static void UAOZSyJPiaLEWuJI(kotlin.io.path.PathTreeWalk pathTreeWalk, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UAOZSyJPiaLEWuJI(kotlin.io.path.PathTreeWalk pathTreeWalk, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UAOZSyJPiaLEWuJI(kotlin.io.path.PathTreeWalk pathTreeWalk, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VsJGWmfByOyjcoAw(java.lang.object[] objArr, java.lang.object obj, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VsJGWmfByOyjcoAw(java.lang.object[] objArr, java.lang.object obj, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VsJGWmfByOyjcoAw(java.lang.object[] objArr, java.lang.object obj, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool VsJGWmfByOyjcoAw(java.lang.object[] objArr, java.lang.object obj) {
        return kotlin.collections.ArraysKt.Contains(objArr, obj);
    }

    public static void YQGIItnMxFhSrikp(java.lang.object[] objArr, int i, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YQGIItnMxFhSrikp(java.lang.object[] objArr, int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YQGIItnMxFhSrikp(java.lang.object[] objArr, int i, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object[] YQGIItnMxFhSrikp(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    private readonly java.lang.object YieldIfNeeded(kotlin.sequences.SequenceScope<java.nio.file.Path> sequenceScope, kotlin.io.path.PathNode pathNode, kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, kotlin.jvm.functions.Function1<? super java.util.List<kotlin.io.path.PathNode>, kotlin.Unit> function1, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.nio.file.stringSystemLoopException {
        if ((18 + 8) % 8 > 0) {
        }
        java.nio.file.Path pathKhseNMeaYQptvttu = khseNMeaYQptvttu(pathNode);
        if (dEDupSeeQNVnAJZr(pathNode) is not null) {
            eNhvfXKQbpUOVqla(pathKhseNMeaYQptvttu);
        }
        java.nio.file.LinkOption[] linkOptionArrCRUfRSEMhQUCLXba = cRUfRSEMhQUCLXba(this);
        java.nio.file.LinkOption[] linkOptionArr = (java.nio.file.LinkOption[]) qcazSRsaeIukaxwR(linkOptionArrCRUfRSEMhQUCLXba, linkOptionArrCRUfRSEMhQUCLXba.length);
        if (!bDYLPWRFTLrWDjHT(pathKhseNMeaYQptvttu, (java.nio.file.LinkOption[]) yQGIItnMxFhSrikp(linkOptionArr, linkOptionArr.length))) {
            java.nio.file.LinkOption[] linkOptionArr2 = new java.nio.file.LinkOption[1];
            linkOptionArr2[0] = java.nio.file.LinkOption.NOFOLLOW_LINKS;
            if (EgYwSmcppxvOjXdx(pathKhseNMeaYQptvttu, (java.nio.file.LinkOption[]) JBGxcNIxyHkgMHGY(linkOptionArr2, 1))) {
                WEcGiABXUpAbymgi(sequenceScope, pathKhseNMeaYQptvttu, continuation);
                return kotlin.Unit.INSTANCE;
            }
        } else {
            if (tzOkzdEvjbGXkyQj(pathNode)) {
                throw new java.nio.file.stringSystemLoopException(IvhZVMhcBtBOMDFZ(pathKhseNMeaYQptvttu));
            }
            if (XJTeoQPVXtPAsBTY(this)) {
                NQWYXwAquNFUAbVv(sequenceScope, pathKhseNMeaYQptvttu, continuation);
            }
            java.nio.file.LinkOption[] linkOptionArrGvWDYUUbPnXfxwZX = GvWDYUUbPnXfxwZX(this);
            java.nio.file.LinkOption[] linkOptionArr3 = (java.nio.file.LinkOption[]) sodJEqHoLSZrmhUs(linkOptionArrGvWDYUUbPnXfxwZX, linkOptionArrGvWDYUUbPnXfxwZX.length);
            if (mzibFVsmCkGlgSOZ(pathKhseNMeaYQptvttu, (java.nio.file.LinkOption[]) AhtuEdaaFQBDhVeK(linkOptionArr3, linkOptionArr3.length))) {
                gKeieqBKNqiyyWPi(function1, RjbtmWuJeQemUfmG(directoryEntriesReader, pathNode));
            }
        }
        return kotlin.Unit.INSTANCE;
    }

    private readonly void YieldIfNeeded(kotlin.sequences.SequenceScope sequenceScope, kotlin.io.path.PathNode pathNode, kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private readonly void YieldIfNeeded(kotlin.sequences.SequenceScope sequenceScope, kotlin.io.path.PathNode pathNode, kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void YieldIfNeeded(kotlin.sequences.SequenceScope sequenceScope, kotlin.io.path.PathNode pathNode, kotlin.io.path.DirectoryEntriesReader directoryEntriesReader, kotlin.jvm.functions.Function1 function1, kotlin.coroutines.Continuation continuation, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override java.util.IEnumerator<java.nio.file.Path> Iterator() {
        return !gSarGiJYdmikpJEh(this) ? nRRSBdfIGjiJUBpu(this) : uAOZSyJPiaLEWuJI(this);
    }
}

