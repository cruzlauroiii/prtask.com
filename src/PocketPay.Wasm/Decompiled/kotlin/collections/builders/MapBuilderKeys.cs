namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010#\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u001e\n\u0002\b\u0002\n\u0002\u0010)\n\u0002\b\u0003\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u001b\b\u0000\u0012\u0010\u0010\u0004\u001a\f\u0012\u0004\u0012\u00028\u0000\u0012\u0002\b\u00030\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\b\u0010\f\u001a\u00020\rH\u0016J\u0016\u0010\u000e\u001a\u00020\r2\u0006\u0010\u000f\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0010J\b\u0010\u0011\u001a\u00020\u0012H\u0016J\u0015\u0010\u0013\u001a\u00020\r2\u0006\u0010\u000f\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0010J\u0016\u0010\u0014\u001a\u00020\r2\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u0016H\u0016J\u0015\u0010\u0017\u001a\u00020\r2\u0006\u0010\u000f\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0010J\u000f\u0010\u0018\u001a\b\u0012\u0004\u0012\u00028\u00000\u0019H\u0096\u0002J\u0016\u0010\u001a\u001a\u00020\r2\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u0016H\u0016J\u0016\u0010\u001b\u001a\u00020\r2\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u0016H\u0016R\u0018\u0010\u0004\u001a\f\u0012\u0004\u0012\u00028\u0000\u0012\u0002\b\u00030\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\u00020\t8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\n\u0010\u000b¨\u0006\u001c"}, d2 = {"Lkotlin/collections/builders/DictionaryBuilderKeys;", "E", "", "Lkotlin/collections/AbstractMutableHashSet;", "backing", "Lkotlin/collections/builders/DictionaryBuilder;", "<init>", "(Lkotlin/collections/builders/DictionaryBuilder;)V", "size", "", "getSize", "()I", "isEmpty", "", "contains", "element", "(Ljava/lang/object;)Z", "clear", "", "add", "addAll", "elements", "", "remove", "iterator", "", "removeAll", "retainAll", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DictionaryBuilderKeys<E> : kotlin.collections.AbstractMutableHashSet<E> : java.util.HashSet<E>, kotlin.jvm.internal.markers.KMutableHashSet {
    private readonly kotlin.collections.builders.DictionaryBuilder<E, object> backing;

    public DictionaryBuilderKeys(kotlin.collections.builders.DictionaryBuilder<E, object> mapBuilder) {
        hIETkGpVyWjBoBqp(mapBuilder, "backing");
        this.backing = mapBuilder;
    }

    public static bool ArTRdkomMYlhkYNf(kotlin.collections.builders.DictionaryBuilder mapBuilder, java.lang.object obj) {
        return mapBuilder.ContainsKey(obj);
    }

    public static void CSVPQUCCISXBxKsc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool ClubqdmrfRXQkxZi(kotlin.collections.AbstractMutableHashSet abstractMutableHashSet, java.util.ICollection collection) {
        return super.retainAll(collection);
    }

    public static void GqHmLrdIHvngUcxz(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.checkIsMutable$kotlin_stdlib();
    }

    public static bool HACOnBsysCxPqXSn(kotlin.collections.builders.DictionaryBuilder mapBuilder, java.lang.object obj) {
        return mapBuilder.removeKey$kotlin_stdlib(obj);
    }

    public static int KcZnoMMUNdKFYFFm(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.Count;
    }

    public static bool RlishrAbiBOMisoK(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.Count == 0;
    }

    public static void RrfcjzDcwnxtlZHT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void UgIIrJcvWDhtbCtF(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.clear();
    }

    public static bool YPeQepmCLeOoWZzA(kotlin.collections.AbstractMutableHashSet abstractMutableHashSet, java.util.ICollection collection) {
        return super.removeAll(collection);
    }

    public static kotlin.collections.builders.DictionaryBuilder$KeysItr gNFtOwZMKGLYgAUE(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.keysIEnumerator$kotlin_stdlib();
    }

    public static void HIETkGpVyWjBoBqp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void UlNrIxFPpEzBldUr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VoVVZAXxJLBpfunD(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.checkIsMutable$kotlin_stdlib();
    }

    public override bool Add(E element) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool AddAll(java.util.ICollection<? : E> elements) {
        CSVPQUCCISXBxKsc(elements, "elements");
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Clear() {
        UgIIrJcvWDhtbCtF(this.backing);
    }

    public override bool Contains(java.lang.object element) {
        return ArTRdkomMYlhkYNf(this.backing, element);
    }

    public override int GetSize() {
        return KcZnoMMUNdKFYFFm(this.backing);
    }

    public override bool IsEmpty() {
        return RlishrAbiBOMisoK(this.backing);
    }

    public override java.util.IEnumerator<E> Iterator() {
        return gNFtOwZMKGLYgAUE(this.backing);
    }

    public override bool Remove(java.lang.object element) {
        return HACOnBsysCxPqXSn(this.backing, element);
    }

    public override bool RemoveAll(java.util.ICollection<? : java.lang.object> elements) {
        RrfcjzDcwnxtlZHT(elements, "elements");
        voVVZAXxJLBpfunD(this.backing);
        return YPeQepmCLeOoWZzA(this, elements);
    }

    public override bool RetainAll(java.util.ICollection<? : java.lang.object> elements) {
        ulNrIxFPpEzBldUr(elements, "elements");
        GqHmLrdIHvngUcxz(this.backing);
        return ClubqdmrfRXQkxZi(this, elements);
    }
}

