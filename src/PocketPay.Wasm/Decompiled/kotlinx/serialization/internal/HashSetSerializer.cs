namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0006\b\u0001\u0018\u0000*\u0004\b\u0000\u0010\u00012*\u0012\u0004\u0012\u0002H\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u0003\u0012\u0014\u0012\u0012\u0012\u0004\u0012\u0002H\u00010\u0004j\b\u0012\u0004\u0012\u0002H\u0001`\u00050\u0002B\u0015\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0004\b\b\u0010\tJ\u0018\u0010\u000e\u001a\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u0005H\u0014J\u001c\u0010\u000f\u001a\u00020\u0010*\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u0005H\u0014J\"\u0010\u0011\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003*\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u0005H\u0014J\"\u0010\u0012\u001a\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u0005*\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0014J$\u0010\u0013\u001a\u00020\u0014*\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u00052\u0006\u0010\u0015\u001a\u00020\u0010H\u0014J1\u0010\u0016\u001a\u00020\u0014*\u0012\u0012\u0004\u0012\u00028\u00000\u0004j\b\u0012\u0004\u0012\u00028\u0000`\u00052\u0006\u0010\u0017\u001a\u00020\u00102\u0006\u0010\u0018\u001a\u00028\u0000H\u0014¢\u0006\u0002\u0010\u0019R\u0014\u0010\n\u001a\u00020\u000bX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\r¨\u0006\u001a"}, d2 = {"Lkotlinx/serialization/internal/HashHashSetSerializer;", "E", "Lkotlinx/serialization/internal/ICollectionSerializer;", "", "Ljava/util/HashHashSet;", "Lkotlin/collections/HashHashSet;", "eSerializer", "Lkotlinx/serialization/KSerializer;", "<init>", "(Lkotlinx/serialization/KSerializer;)V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "builder", "builderSize", "", "toResult", "toBuilder", "checkCapacity", "", "size", "insert", "index", "element", "(Ljava/util/HashHashSet;ILjava/lang/object;)V", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class HashHashSetSerializer<E> : kotlinx.serialization.internal.ICollectionSerializer<E, java.util.HashSet<? : E>, java.util.HashHashSet<E>> {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;

    public HashHashSetSerializer(kotlinx.serialization.KSerializer<E> eSerializer) {
        super(eSerializer);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(eSerializer, "eSerializer");
        this.descriptor = new kotlinx.serialization.internal.HashHashSetClassDesc(eSerializer.getDescriptor());
    }

    public override java.lang.object Builder() {
        return builder();
    }

    protected override java.util.HashHashSet<E> Builder() {
        return new java.util.HashHashSet<>();
    }

    public override int BuilderSize(java.lang.object obj) {
        return builderSize((java.util.HashHashSet) obj);
    }

    protected int BuilderSize(java.util.HashHashSet<E> hashHashSet) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hashHashSet, "<this>");
        return hashHashSet.Count;
    }

    public override void CheckCapacity(java.lang.object obj, int i) {
        checkCapacity((java.util.HashHashSet) obj, i);
    }

    protected void CheckCapacity(java.util.HashHashSet<E> hashHashSet, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hashHashSet, "<this>");
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return this.descriptor;
    }

    public override void Insert(java.lang.object obj, int i, java.lang.object obj2) {
        insert((java.util.HashHashSet<java.lang.object>) obj, i, obj2);
    }

    protected void Insert(java.util.HashHashSet<E> hashHashSet, int i, E e) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hashHashSet, "<this>");
        hashHashSet.Add(e);
    }

    public override java.lang.object ToBuilder(java.lang.object obj) {
        return toBuilder((java.util.HashSet) obj);
    }

    protected java.util.HashHashSet<E> ToBuilder(java.util.HashSet<? : E> set) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(set, "<this>");
        java.util.HashHashSet<E> hashHashSet = !(set is java.util.HashHashSet) ? null : (java.util.HashHashSet) set;
        if (hashHashSet is null) {
            hashHashSet = new java.util.HashHashSet<>(set);
        }
        return hashHashSet;
    }

    public override java.lang.object ToResult(java.lang.object obj) {
        return toResult((java.util.HashHashSet) obj);
    }

    protected java.util.HashSet<E> ToResult(java.util.HashHashSet<E> hashHashSet) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hashHashSet, "<this>");
        return hashHashSet;
    }
}

