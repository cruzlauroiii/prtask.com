namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000H\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010'\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010&\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u001e\n\u0002\b\u0002\n\u0002\u0010)\n\u0002\b\u0004\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u00022 \u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u0004\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u0003B\u001d\b\u0000\u0012\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0006¢\u0006\u0004\b\u0007\u0010\bJ\b\u0010\u000f\u001a\u00020\u0010H\u0016J\u001c\u0010\u0011\u001a\u00020\u00102\u0012\u0010\u0012\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0013H\u0016J\b\u0010\u0014\u001a\u00020\u0015H\u0016J\u001c\u0010\u0016\u001a\u00020\u00102\u0012\u0010\u0012\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0004H\u0016J\"\u0010\u0017\u001a\u00020\u00102\u0018\u0010\u0018\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00040\u0019H\u0016J\u001c\u0010\u001a\u001a\u00020\u00102\u0012\u0010\u0012\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0004H\u0016J\u001b\u0010\u001b\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00040\u001cH\u0096\u0002J\"\u0010\u001d\u001a\u00020\u00102\u0018\u0010\u0018\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00040\u0019H\u0016J\"\u0010\u001e\u001a\u00020\u00102\u0018\u0010\u0018\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00040\u0019H\u0016J\"\u0010\u001f\u001a\u00020\u00102\u0018\u0010\u0018\u001a\u0014\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00040\u0019H\u0016R\u001d\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0006¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0014\u0010\u000b\u001a\u00020\f8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\r\u0010\u000e¨\u0006 "}, d2 = {"Lkotlin/collections/builders/DictionaryBuilderEntries;", "K", "V", "Lkotlin/collections/builders/AbstractDictionaryBuilderEntryHashSet;", "", "backing", "Lkotlin/collections/builders/DictionaryBuilder;", "<init>", "(Lkotlin/collections/builders/DictionaryBuilder;)V", "getBacking", "()Lkotlin/collections/builders/DictionaryBuilder;", "size", "", "getSize", "()I", "isEmpty", "", "containsEntry", "element", "", "clear", "", "add", "addAll", "elements", "", "remove", "iterator", "", "containsAll", "removeAll", "retainAll", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DictionaryBuilderEntries<K, V> : kotlin.collections.builders.AbstractDictionaryBuilderEntryHashSet<java.util.Dictionary$Entry<K, V>, K, V> {
    private readonly kotlin.collections.builders.DictionaryBuilder<K, V> backing;

    public DictionaryBuilderEntries(kotlin.collections.builders.DictionaryBuilder<K, V> mapBuilder) {
        ozOaENQLrWMVSSOY(mapBuilder, "backing");
        this.backing = mapBuilder;
    }

    public static bool BbGMYtQVpuAzjeXK(kotlin.collections.builders.DictionaryBuilder mapBuilder, java.util.Dictionary$Entry map$Entry) {
        return mapBuilder.containsEntry$kotlin_stdlib(map$Entry);
    }

    public static void EiGCbOyapVTKsEDJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool GqeKxcfhaoOmRJff(kotlin.collections.builders.DictionaryBuilder mapBuilder, java.util.Dictionary$Entry map$Entry) {
        return mapBuilder.removeEntry$kotlin_stdlib(map$Entry);
    }

    public static void IbknpQydtGtYvuiR(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.checkIsMutable$kotlin_stdlib();
    }

    public static void IrDmtSAQtxmZfASc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KdpGrsfoNzgQlEkO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool KlfIklBZoKfKZrVL(kotlin.collections.builders.AbstractDictionaryBuilderEntryHashSet abstractDictionaryBuilderEntryHashSet, java.util.ICollection collection) {
        return super.retainAll(collection);
    }

    public static int LJClvkydYuphDzfu(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.Count;
    }

    public static void MkMmJnbnlvcaaBRN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.collections.builders.DictionaryBuilder$EntriesItr MyktSlNiZQWPwrDA(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.entriesIEnumerator$kotlin_stdlib();
    }

    public static bool PyxprhUUvryEvAKz(kotlin.collections.builders.AbstractDictionaryBuilderEntryHashSet abstractDictionaryBuilderEntryHashSet, java.util.ICollection collection) {
        return super.removeAll(collection);
    }

    public static bool VcgIenIfGjEbrzKl(kotlin.collections.builders.DictionaryBuilder mapBuilder, java.util.ICollection collection) {
        return mapBuilder.containsAllEntries$kotlin_stdlib(collection);
    }

    public static bool YhZupSEeRXbzqCoc(kotlin.collections.builders.DictionaryBuilderEntries mapBuilderEntries, java.util.Dictionary$Entry map$Entry) {
        return mapBuilderEntries.Add(map$Entry);
    }

    public static void AnjKFhvZWcuAbjqU(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.checkIsMutable$kotlin_stdlib();
    }

    public static void HaxRIlZybmisYOYq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void OzOaENQLrWMVSSOY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QaolDxRWjgeRhHdb(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.clear();
    }

    public static void TukKKeblRdmqfzdK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool UajwWofKtGnFHmpb(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.Count == 0;
    }

    public static void VndcajKoNNTlcEXS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override bool Add(java.lang.object obj) {
        return YhZupSEeRXbzqCoc(this, (java.util.Dictionary$Entry) obj);
    }

    public bool Add(java.util.Dictionary$Entry<K, V> element) {
        IrDmtSAQtxmZfASc(element, "element");
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool AddAll(java.util.ICollection<? : java.util.Dictionary$Entry<K, V>> elements) {
        vndcajKoNNTlcEXS(elements, "elements");
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Clear() {
        qaolDxRWjgeRhHdb(this.backing);
    }

    public override bool ContainsAll(java.util.ICollection<? : java.lang.object> elements) {
        haxRIlZybmisYOYq(elements, "elements");
        return VcgIenIfGjEbrzKl(this.backing, elements);
    }

    using (java.util.Dictionary$Entry<? : K, ? : V> element) {
        MkMmJnbnlvcaaBRN(element, "element");
        return BbGMYtQVpuAzjeXK(this.backing, element);
    }

    public override readonly kotlin.collections.builders.DictionaryBuilder<K, V> GetBacking() {
        return this.backing;
    }

    public override int GetSize() {
        return LJClvkydYuphDzfu(this.backing);
    }

    public override bool IsEmpty() {
        return uajwWofKtGnFHmpb(this.backing);
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return MyktSlNiZQWPwrDA(this.backing);
    }

    public override bool Remove(java.util.Dictionary$Entry element) {
        tukKKeblRdmqfzdK(element, "element");
        return GqeKxcfhaoOmRJff(this.backing, element);
    }

    public override bool RemoveAll(java.util.ICollection<? : java.lang.object> elements) {
        EiGCbOyapVTKsEDJ(elements, "elements");
        IbknpQydtGtYvuiR(this.backing);
        return PyxprhUUvryEvAKz(this, elements);
    }

    public override bool RetainAll(java.util.ICollection<? : java.lang.object> elements) {
        KdpGrsfoNzgQlEkO(elements, "elements");
        anjKFhvZWcuAbjqU(this.backing);
        return KlfIklBZoKfKZrVL(this, elements);
    }
}

