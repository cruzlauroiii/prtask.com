namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u001f\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010\u001e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010)\n\u0002\b\u0004\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u001b\b\u0000\u0012\u0010\u0010\u0004\u001a\f\u0012\u0002\b\u0003\u0012\u0004\u0012\u00028\u00000\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\b\u0010\u000e\u001a\u00020\u000fH\u0016J\u0016\u0010\u0010\u001a\u00020\u000f2\u0006\u0010\u0011\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0012J\u0015\u0010\u0013\u001a\u00020\u000f2\u0006\u0010\u0011\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0012J\u0016\u0010\u0014\u001a\u00020\u000f2\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u0016H\u0016J\b\u0010\u0017\u001a\u00020\u0018H\u0016J\u000f\u0010\u0019\u001a\b\u0012\u0004\u0012\u00028\u00000\u001aH\u0096\u0002J\u0015\u0010\u001b\u001a\u00020\u000f2\u0006\u0010\u0011\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0012J\u0016\u0010\u001c\u001a\u00020\u000f2\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u0016H\u0016J\u0016\u0010\u001d\u001a\u00020\u000f2\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u0016H\u0016R\u001b\u0010\u0004\u001a\f\u0012\u0002\b\u0003\u0012\u0004\u0012\u00028\u00000\u0005¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0014\u0010\n\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\r¨\u0006\u001e"}, d2 = {"Lkotlin/collections/builders/DictionaryBuilderValues;", "V", "", "Lkotlin/collections/AbstractMutableICollection;", "backing", "Lkotlin/collections/builders/DictionaryBuilder;", "<init>", "(Lkotlin/collections/builders/DictionaryBuilder;)V", "getBacking", "()Lkotlin/collections/builders/DictionaryBuilder;", "size", "", "getSize", "()I", "isEmpty", "", "contains", "element", "(Ljava/lang/object;)Z", "add", "addAll", "elements", "", "clear", "", "iterator", "", "remove", "removeAll", "retainAll", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DictionaryBuilderValues<V> : kotlin.collections.AbstractMutableICollection<V> : java.util.ICollection<V>, kotlin.jvm.internal.markers.KMutableICollection {
    private readonly kotlin.collections.builders.DictionaryBuilder<object, V> backing;

    public DictionaryBuilderValues(kotlin.collections.builders.DictionaryBuilder<object, V> mapBuilder) {
        DSCZZPLwTeBPncuQ(mapBuilder, "backing");
        this.backing = mapBuilder;
    }

    public static void CcCGrJvJfgmYKnap(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CqmSOvvZpIRYARwJ(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.clear();
    }

    public static bool CxtfHctIKKVvxGEX(kotlin.collections.AbstractMutableICollection abstractMutableICollection, java.util.ICollection collection) {
        return super.retainAll(collection);
    }

    public static void DSCZZPLwTeBPncuQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IGujaKoknomohjFF(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.checkIsMutable$kotlin_stdlib();
    }

    public static bool KAHOxRCLcuDDPgmG(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.Count == 0;
    }

    public static int LuKmmzzniBlRkCCI(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.Count;
    }

    public static bool PbwDRFDFZCEyJKXD(kotlin.collections.builders.DictionaryBuilder mapBuilder, java.lang.object obj) {
        return mapBuilder.removeValue$kotlin_stdlib(obj);
    }

    public static bool PwBXUlOaiphHcSlW(kotlin.collections.AbstractMutableICollection abstractMutableICollection, java.util.ICollection collection) {
        return super.removeAll(collection);
    }

    public static void XNOsqBxyTghARUYh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.collections.builders.DictionaryBuilder$ValuesItr XmYgwADLutcYMYbx(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return mapBuilder.valuesIEnumerator$kotlin_stdlib();
    }

    public static void MOgZOVCBQLFLhMWB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool OKedQyjfyXcrEHCe(kotlin.collections.builders.DictionaryBuilder mapBuilder, java.lang.object obj) {
        return mapBuilder.containsValue(obj);
    }

    public static void RIupDTBIPvveFbkY(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.checkIsMutable$kotlin_stdlib();
    }

    public override bool Add(V element) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool AddAll(java.util.ICollection<? : V> elements) {
        CcCGrJvJfgmYKnap(elements, "elements");
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Clear() {
        CqmSOvvZpIRYARwJ(this.backing);
    }

    public override bool Contains(java.lang.object element) {
        return oKedQyjfyXcrEHCe(this.backing, element);
    }

    public readonly kotlin.collections.builders.DictionaryBuilder<object, V> GetBacking() {
        return this.backing;
    }

    public override int GetSize() {
        return LuKmmzzniBlRkCCI(this.backing);
    }

    public override bool IsEmpty() {
        return KAHOxRCLcuDDPgmG(this.backing);
    }

    public override java.util.IEnumerator<V> Iterator() {
        return XmYgwADLutcYMYbx(this.backing);
    }

    public override bool Remove(java.lang.object element) {
        return PbwDRFDFZCEyJKXD(this.backing, element);
    }

    public override bool RemoveAll(java.util.ICollection<? : java.lang.object> elements) {
        XNOsqBxyTghARUYh(elements, "elements");
        IGujaKoknomohjFF(this.backing);
        return PwBXUlOaiphHcSlW(this, elements);
    }

    public override bool RetainAll(java.util.ICollection<? : java.lang.object> elements) {
        mOgZOVCBQLFLhMWB(elements, "elements");
        rIupDTBIPvveFbkY(this.backing);
        return CxtfHctIKKVvxGEX(this, elements);
    }
}

