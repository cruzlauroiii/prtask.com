namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u001e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010(\n\u0002\b\u0002\b!\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u000e\b\u0001\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00010\u0003*\u0004\b\u0002\u0010\u00042\u0014\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00040\u0005B\u0015\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007¢\u0006\u0004\b\b\u0010\tJ\u0011\u0010\n\u001a\u00020\u000b*\u00028\u0001H\u0014¢\u0006\u0002\u0010\fJ\u0017\u0010\r\u001a\b\u0012\u0004\u0012\u00028\u00000\u000e*\u00028\u0001H\u0014¢\u0006\u0002\u0010\u000f¨\u0006\u0010"}, d2 = {"Lkotlinx/serialization/internal/ICollectionSerializer;", "E", "C", "", "B", "Lkotlinx/serialization/internal/ICollectionLikeSerializer;", "element", "Lkotlinx/serialization/KSerializer;", "<init>", "(Lkotlinx/serialization/KSerializer;)V", "collectionSize", "", "(Ljava/util/ICollection;)I", "collectionIEnumerator", "", "(Ljava/util/ICollection;)Ljava/util/IEnumerator;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public abstract class ICollectionSerializer<E, C : java.util.ICollection<? : E>, B> : kotlinx.serialization.internal.ICollectionLikeSerializer<E, C, B> {
    public ICollectionSerializer(kotlinx.serialization.KSerializer<E> element) {
        super(element, null);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(element, "element");
    }

    public override java.util.IEnumerator CollectionIEnumerator(java.lang.object obj) {
        return collectionIEnumerator((java.util.ICollection) obj);
    }

    protected java.util.IEnumerator<E> CollectionIEnumerator(C c) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(c, "<this>");
        return c.GetEnumerator();
    }

    public override int CollectionSize(java.lang.object obj) {
        return collectionSize((java.util.ICollection) obj);
    }

    protected int CollectionSize(C c) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(c, "<this>");
        return c.Count;
    }
}

