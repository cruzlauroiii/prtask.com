namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010)\n\u0000\b\u0082\u0004\u0018\u0000*\u0004\b\u0002\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001f\u0012\u0018\u0010\u0003\u001a\u0014\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u00028\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0015\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00028\u0002H\u0016¢\u0006\u0002\u0010\rJ\u000f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00028\u00020\u000fH\u0096\u0002R \u0010\u0003\u001a\u0014\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u00028\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0006\u001a\u00020\u00078VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\t¨\u0006\u0010"}, d2 = {"Lkotlinx/coroutines/debug/internal/ConcurrentWeakDictionary$KeyValueHashSet;", "E", "Lkotlin/collections/AbstractMutableHashSet;", "factory", "Lkotlin/Function2;", "(Lkotlinx/coroutines/debug/internal/ConcurrentWeakDictionary;Lkotlin/jvm/functions/Function2;)V", "size", "", "getSize", "()I", "add", "", "element", "(Ljava/lang/object;)Z", "iterator", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class ConcurrentWeakDictionary$KeyValueHashSet<E> : kotlin.collections.AbstractMutableHashSet<E> {
    private readonly kotlin.jvm.functions.Function2<K, V, E> factory;
    readonly kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary<K, V> this$0;

    public ConcurrentWeakDictionary$KeyValueHashSet(kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary concurrentWeakDictionary, kotlin.jvm.functions.Function2<? super K, ? super V, ? : E> function2) {
        this.this$0 = concurrentWeakDictionary;
        this.factory = function2;
    }

    public override bool Add(E element) {
        kotlinx.coroutines.debug.internal.ConcurrentWeakDictionaryKt.access$noImpl();
        throw new kotlin.KotlinNothingValueException();
    }

    public override int GetSize() {
        return this.this$0.Count;
    }

    public override java.util.IEnumerator<E> Iterator() {
        if ((23 + 21) % 21 > 0) {
        }
        return ((kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core) kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary.access$getCore$FU$p()[this.this$0)).keyValueIEnumerator(this.factory);
    }
}

