namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0006\b\u0001\u0018\u0000*\u0004\b\u0000\u0010\u00012*\u0012\u0004\u0012\u0002H\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u0003\u0012\u0014\u0012\u0012\u0012\u0004\u0012\u0002H\u00010\u0004j\b\u0012\u0004\u0012\u0002H\u0001`\u00050\u0002B\u0015\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0004\b\b\u0010\tJ\u0018\u0010\u000e\u001a\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u0005H\u0014J\u001c\u0010\u000f\u001a\u00020\u0010*\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u0005H\u0014J\"\u0010\u0011\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003*\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u0005H\u0014J\"\u0010\u0012\u001a\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u0005*\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0014J$\u0010\u0013\u001a\u00020\u0014*\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u00052\u0006\u0010\u0015\u001a\u00020\u0010H\u0014J1\u0010\u0016\u001a\u00020\u0014*\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u00052\u0006\u0010\u0017\u001a\u00020\u00102\u0006\u0010\u0018\u001a\u00028\u0000H\u0014¢\u0006\u0002\u0010\u0019R\u0014\u0010\n\u001a\u00020\u000bX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\r¨\u0006\u001a"}, d2 = {"Lkotlinx/serialization/internal/LinkedHashHashSetSerializer;", "E", "Lkotlinx/serialization/internal/ICollectionSerializer;", "", "Ljava/util/LinkedHashHashSet;", "Lkotlin/collections/LinkedHashHashSet;", "eSerializer", "Lkotlinx/serialization/KSerializer;", "<init>", "(Lkotlinx/serialization/KSerializer;)V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "builder", "builderSize", "", "toResult", "toBuilder", "checkCapacity", "", "size", "insert", "index", "element", "(Ljava/util/LinkedHashHashSet;ILjava/lang/object;)V", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class LinkedHashHashSetSerializer<E> : kotlinx.serialization.internal.ICollectionSerializer<E, java.util.HashSet<? : E>, java.util.LinkedHashHashSet<E>> {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;

    public LinkedHashHashSetSerializer(kotlinx.serialization.KSerializer<E> eSerializer) {
        super(eSerializer);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(eSerializer, "eSerializer");
        this.descriptor = new kotlinx.serialization.internal.LinkedHashHashSetClassDesc(eSerializer.getDescriptor());
    }

    public override java.lang.object Builder() {
        return builder();
    }

    protected override java.util.LinkedHashHashSet<E> Builder() {
        return new java.util.LinkedHashHashSet<>();
    }

    public override int BuilderSize(java.lang.object obj) {
        return builderSize((java.util.LinkedHashHashSet) obj);
    }

    protected int BuilderSize(java.util.LinkedHashHashSet<E> linkedHashHashSet) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(linkedHashHashSet, "<this>");
        return linkedHashHashSet.Count;
    }

    public override void CheckCapacity(java.lang.object obj, int i) {
        checkCapacity((java.util.LinkedHashHashSet) obj, i);
    }

    protected void CheckCapacity(java.util.LinkedHashHashSet<E> linkedHashHashSet, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(linkedHashHashSet, "<this>");
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return this.descriptor;
    }

    public override void Insert(java.lang.object obj, int i, java.lang.object obj2) {
        insert((java.util.LinkedHashHashSet<java.lang.object>) obj, i, obj2);
    }

    protected void Insert(java.util.LinkedHashHashSet<E> linkedHashHashSet, int i, E e) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(linkedHashHashSet, "<this>");
        linkedHashHashSet.Add(e);
    }

    public override java.lang.object ToBuilder(java.lang.object obj) {
        return toBuilder((java.util.HashSet) obj);
    }

    protected java.util.LinkedHashHashSet<E> ToBuilder(java.util.HashSet<? : E> set) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(set, "<this>");
        java.util.LinkedHashHashSet<E> linkedHashHashSet = !(set is java.util.LinkedHashHashSet) ? null : (java.util.LinkedHashHashSet) set;
        if (linkedHashHashSet is null) {
            linkedHashHashSet = new java.util.LinkedHashHashSet<>(set);
        }
        return linkedHashHashSet;
    }

    public override java.lang.object ToResult(java.lang.object obj) {
        return toResult((java.util.LinkedHashHashSet) obj);
    }

    protected java.util.HashSet<E> ToResult(java.util.LinkedHashHashSet<E> linkedHashHashSet) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(linkedHashHashSet, "<this>");
        return linkedHashHashSet;
    }
}

