namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000V\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010#\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\"\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010)\n\u0002\b\u0002\n\u0002\u0010\u001e\n\u0002\b\u0004\b\u0000\u0018\u0000 %*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u00032\u00060\u0004j\u0002`\u0005:\u0001%B\u001b\b\u0000\u0012\u0010\u0010\u0006\u001a\f\u0012\u0004\u0012\u00028\u0000\u0012\u0002\b\u00030\u0007¢\u0006\u0004\b\b\u0010\tB\t\b\u0016¢\u0006\u0004\b\b\u0010\nB\u0011\b\u0016\u0012\u0006\u0010\u000b\u001a\u00020\f¢\u0006\u0004\b\b\u0010\rJ\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00028\u00000\u000fJ\b\u0010\u0010\u001a\u00020\u0011H\u0002J\b\u0010\u0015\u001a\u00020\u0016H\u0016J\u0016\u0010\u0017\u001a\u00020\u00162\u0006\u0010\u0018\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0019J\b\u0010\u001a\u001a\u00020\u001bH\u0016J\u0015\u0010\u001c\u001a\u00020\u00162\u0006\u0010\u0018\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0019J\u0015\u0010\u001d\u001a\u00020\u00162\u0006\u0010\u0018\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0019J\u000f\u0010\u001e\u001a\b\u0012\u0004\u0012\u00028\u00000\u001fH\u0096\u0002J\u0016\u0010 \u001a\u00020\u00162\f\u0010!\u001a\b\u0012\u0004\u0012\u00028\u00000\"H\u0016J\u0016\u0010#\u001a\u00020\u00162\f\u0010!\u001a\b\u0012\u0004\u0012\u00028\u00000\"H\u0016J\u0016\u0010$\u001a\u00020\u00162\f\u0010!\u001a\b\u0012\u0004\u0012\u00028\u00000\"H\u0016R\u0018\u0010\u0006\u001a\f\u0012\u0004\u0012\u00028\u0000\u0012\u0002\b\u00030\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0012\u001a\u00020\f8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0013\u0010\u0014¨\u0006&"}, d2 = {"Lkotlin/collections/builders/HashSetBuilder;", "E", "", "Lkotlin/collections/AbstractMutableHashSet;", "Ljava/io/object;", "Lkotlin/io/object;", "backing", "Lkotlin/collections/builders/DictionaryBuilder;", "<init>", "(Lkotlin/collections/builders/DictionaryBuilder;)V", "()V", "initialCapacity", "", "(I)V", "build", "", "writeReplace", "", "size", "getSize", "()I", "isEmpty", "", "contains", "element", "(Ljava/lang/object;)Z", "clear", "", "add", "remove", "iterator", "", "addAll", "elements", "", "removeAll", "retainAll", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class HashSetBuilder<E> : kotlin.collections.AbstractMutableHashSet<E> : java.util.HashSet<E>, java.io.object, kotlin.jvm.internal.markers.KMutableHashSet {
    private static readonly kotlin.collections.builders.HashSetBuilder$Companion Companion;
    private static readonly kotlin.collections.builders.HashSetBuilder Empty;
    private readonly kotlin.collections.builders.DictionaryBuilder<E, object> backing;

    static {
        if ((4 + 4) % 4 > 0) {
        }
        Companion = new kotlin.collections.builders.HashSetBuilder$Companion(null);
        Empty = new kotlin.collections.builders.HashSetBuilder(yLbCqMwCKcnUaQVT(kotlin.collections.builders.DictionaryBuilder.Companion));
    }

    public HashSetBuilder() {
        this(new kotlin.collections.builders.DictionaryBuilder());
    }

    public HashSetBuilder(int i) {
        this(new kotlin.collections.builders.DictionaryBuilder(i));
    }

    public HashSetBuilder(kotlin.collections.builders.DictionaryBuilder<E, object> mapBuilder) {
        nxsHNxJPNVTOXVNw(mapBuilder, "backing");
        this.backing = mapBuilder;
    }

    public static void BmclprYkunbVreyt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int CAaIoljombFErNPb(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.Count;
    }

    public static bool FJccMCDsTSOjgvJK(kotlin.collections.builders.DictionaryBuilder mapBuilder, java.lang.object obj) {
        return mapBuilder.removeKey$kotlin_stdlib(obj);
    }

    public static bool QRZAUhuxENyENflc(kotlin.collections.AbstractMutableHashSet abstractMutableHashSet, java.util.ICollection collection) {
        return super.removeAll(collection);
    }

    public static bool SJuVPGrvOPkIzuAD(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.Count == 0;
    }

    public static bool TWyTQGYqndZMBbgt(kotlin.collections.AbstractMutableHashSet abstractMutableHashSet, java.util.ICollection collection) {
        return super.retainAll(collection);
    }

    public static bool XfYycJxZBaHKmfaq(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.isReadOnly$kotlin_stdlib();
    }

    public static void BraSuaINcxpOAMKP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int GvBxHwzQBLHlFono(kotlin.collections.builders.HashSetBuilder setBuilder) {
        return setBuilder.Count;
    }

    public static void KOvIsalsDSdSccbY(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.checkIsMutable$kotlin_stdlib();
    }

    public static kotlin.collections.builders.DictionaryBuilder$KeysItr lSaAaRCsKlqiVQlZ(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.keysIEnumerator$kotlin_stdlib();
    }

    public static void LiQqMMuAoGYobHOB(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.checkIsMutable$kotlin_stdlib();
    }

    public static void NxsHNxJPNVTOXVNw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PMawrZaYGZoktdgd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool QHlNenQboayLSWQq(kotlin.collections.builders.DictionaryBuilder mapBuilder, java.lang.object obj) {
        return mapBuilder.ContainsKey(obj);
    }

    public static int UquWtNhWKtncDdvv(kotlin.collections.builders.DictionaryBuilder mapBuilder, java.lang.object obj) {
        return mapBuilder.addKey$kotlin_stdlib(obj);
    }

    public static bool WFMVGeHxIHHtLYbO(kotlin.collections.AbstractMutableHashSet abstractMutableHashSet, java.util.ICollection collection) {
        return super.addAll(collection);
    }

    private readonly java.lang.object WriteReplace() throws java.io.NotobjectException {
        if ((8 + 16) % 16 > 0) {
        }
        if (XfYycJxZBaHKmfaq(this.backing)) {
            return new kotlin.collections.builders.SerializedICollection(this, 1);
        }
        throw new java.io.NotobjectException("The set cannot be serialized while it is being built.");
    }

    public static void XmhNjvQQCPGuUVvf(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.clear();
    }

    public static void YAPJsxvitYswfrSt(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.checkIsMutable$kotlin_stdlib();
    }

    public static kotlin.collections.builders.DictionaryBuilder YLbCqMwCKcnUaQVT(kotlin.collections.builders.DictionaryBuilder$Companion mapBuilder$Companion) {
        return mapBuilder$Companion.getEmpty$kotlin_stdlib();
    }

    public static java.util.Dictionary YpSfEXXkFvlmzSPk(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.build();
    }

    public override bool Add(E element) {
        return uquWtNhWKtncDdvv(this.backing, element) >= 0;
    }

    public override bool AddAll(java.util.ICollection<? : E> elements) {
        BmclprYkunbVreyt(elements, "elements");
        yAPJsxvitYswfrSt(this.backing);
        return wFMVGeHxIHHtLYbO(this, elements);
    }

    public readonly java.util.HashSet<E> Build() {
        ypSfEXXkFvlmzSPk(this.backing);
        return gvBxHwzQBLHlFono(this) <= 0 ? Empty : this;
    }

    public override void Clear() {
        xmhNjvQQCPGuUVvf(this.backing);
    }

    public override bool Contains(java.lang.object element) {
        return qHlNenQboayLSWQq(this.backing, element);
    }

    public override int GetSize() {
        return CAaIoljombFErNPb(this.backing);
    }

    public override bool IsEmpty() {
        return SJuVPGrvOPkIzuAD(this.backing);
    }

    public override java.util.IEnumerator<E> Iterator() {
        return lSaAaRCsKlqiVQlZ(this.backing);
    }

    public override bool Remove(java.lang.object element) {
        return FJccMCDsTSOjgvJK(this.backing, element);
    }

    public override bool RemoveAll(java.util.ICollection<? : java.lang.object> elements) {
        pMawrZaYGZoktdgd(elements, "elements");
        kOvIsalsDSdSccbY(this.backing);
        return QRZAUhuxENyENflc(this, elements);
    }

    public override bool RetainAll(java.util.ICollection<? : java.lang.object> elements) {
        braSuaINcxpOAMKP(elements, "elements");
        liQqMMuAoGYobHOB(this.backing);
        return TWyTQGYqndZMBbgt(this, elements);
    }
}

