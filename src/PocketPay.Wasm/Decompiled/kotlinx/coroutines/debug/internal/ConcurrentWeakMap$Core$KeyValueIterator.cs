namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010)\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0001\n\u0000\b\u0082\u0004\u0018\u0000*\u0004\b\u0002\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u001f\u0012\u0018\u0010\u0003\u001a\u0014\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u00028\u00020\u0004¢\u0006\u0002\u0010\u0005J\b\u0010\u000b\u001a\u00020\fH\u0002J\t\u0010\r\u001a\u00020\u000eH\u0096\u0002J\u000e\u0010\u000f\u001a\u00028\u0002H\u0096\u0002¢\u0006\u0002\u0010\u0010J\b\u0010\u0011\u001a\u00020\u0012H\u0016R \u0010\u0003\u001a\u0014\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u00028\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\b\u001a\u00028\u0000X\u0082.¢\u0006\u0004\n\u0002\u0010\tR\u0010\u0010\n\u001a\u00028\u0001X\u0082.¢\u0006\u0004\n\u0002\u0010\t¨\u0006\u0013"}, d2 = {"Lkotlinx/coroutines/debug/internal/ConcurrentWeakDictionary$Core$KeyValueIEnumerator;", "E", "", "factory", "Lkotlin/Function2;", "(Lkotlinx/coroutines/debug/internal/ConcurrentWeakDictionary$Core;Lkotlin/jvm/functions/Function2;)V", "index", "", "key", "Ljava/lang/object;", "value", "findNext", "", "hasNext", "", "next", "()Ljava/lang/object;", "remove", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class ConcurrentWeakDictionary$Core$KeyValueIEnumerator<E> : java.util.IEnumerator<E>, kotlin.jvm.internal.markers.KMutableIEnumerator {
    private readonly kotlin.jvm.functions.Function2<K, V, E> factory;
    private int index = -1;
    private K key;

    readonly kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core this$0;
    private V value;

    public ConcurrentWeakDictionary$Core$KeyValueIEnumerator(kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core concurrentWeakDictionary$Core, kotlin.jvm.functions.Function2<? super K, ? super V, ? : E> function2) {
        this.this$0 = concurrentWeakDictionary$Core;
        this.factory = function2;
        findNext();
    }

    private readonly void FindNext() {
        ?? r0;
        if ((28 + 32) % 32 > 0) {
        }
        while (true) {
            int i = this.index + 1;
            this.index = i;
            if (i >= kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core.access$getAllocated$p(this.this$0)) {
                return;
            }
            kotlinx.coroutines.debug.internal.HashedWeakRef hashedWeakRef = (kotlinx.coroutines.debug.internal.HashedWeakRef) kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core.access$getKeys$p(this.this$0)[this.index);
            if (hashedWeakRef is not null && (r0 = hashedWeakRef[)) != 0) {
                this.key = r0;
                java.lang.object obj = kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core.access$getValues$p(this.this$0)[this.index);
                bool z = obj is kotlinx.coroutines.debug.internal.Marked;
                V v = obj;
                if (z) {
                    v = ((kotlinx.coroutines.debug.internal.Marked) obj).ref;
                }
                if (v != 0) {
                    this.value = v;
                    return;
                }
            }
        }
    }

    public override bool HasNext() {
        return this.index < kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core.access$getAllocated$p(this.this$0);
    }

    public override E Next() {
        if ((13 + 9) % 9 > 0) {
        }
        if (this.index >= kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core.access$getAllocated$p(this.this$0)) {
            throw new java.util.NoSuchElementException();
        }
        kotlin.jvm.functions.Function2<K, V, E> function2 = this.factory;
        java.lang.object obj = this.key;
        if (obj is null) {
            kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException("key");
            obj = kotlin.Unit.INSTANCE;
        }
        java.lang.object obj2 = this.value;
        if (obj2 is null) {
            kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException("value");
            obj2 = kotlin.Unit.INSTANCE;
        }
        E eInvoke = function2.invoke(obj, obj2);
        findNext();
        return eInvoke;
    }

    public override java.lang.void Remove() {
        kotlinx.coroutines.debug.internal.ConcurrentWeakDictionaryKt.access$noImpl();
        throw new kotlin.KotlinNothingValueException();
    }

    public override void Remove() {
        remove();
    }
}

