namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0007\n\u0002\u0010)\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0082\u0004\u0018\u00002\u00020\u0001:\u0001!B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\u0012\u0010\r\u001a\u00020\u000e2\n\u0010\u000f\u001a\u0006\u0012\u0002\b\u00030\u0007J\u0015\u0010\u0010\u001a\u0004\u0018\u00018\u00012\u0006\u0010\u0011\u001a\u00028\u0000¢\u0006\u0002\u0010\u0012J\u0010\u0010\u0013\u001a\u00020\u00032\u0006\u0010\u0014\u001a\u00020\u0003H\u0002J,\u0010\u0015\u001a\b\u0012\u0004\u0012\u0002H\u00170\u0016\"\u0004\b\u0002\u0010\u00172\u0018\u0010\u0018\u001a\u0014\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u0002H\u00170\u0019J1\u0010\u001a\u001a\u0004\u0018\u00010\u00012\u0006\u0010\u0011\u001a\u00028\u00002\b\u0010\u001b\u001a\u0004\u0018\u00018\u00012\u0010\b\u0002\u0010\u001c\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0007¢\u0006\u0002\u0010\u001dJ\u0016\u0010\u001e\u001a\u00120\u0000R\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u001fJ\u0010\u0010 \u001a\u00020\u000e2\u0006\u0010\u0013\u001a\u00020\u0003H\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\u0005\u001a\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u00070\u0006X\u0082\u0004R\t\u0010\b\u001a\u00020\tX\u0082\u0004R\u000e\u0010\n\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\f\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00010\u0006X\u0082\u0004¨\u0006\""}, d2 = {"Lkotlinx/coroutines/debug/internal/ConcurrentWeakDictionary$Core;", "", "allocated", "", "(Lkotlinx/coroutines/debug/internal/ConcurrentWeakDictionary;I)V", "keys", "Lkotlinx/atomicfu/AtomicArray;", "Lkotlinx/coroutines/debug/internal/HashedWeakRef;", "load", "Lkotlinx/atomicfu/AtomicInt;", "shift", "threshold", "values", "cleanWeakRef", "", "weakRef", "getImpl", "key", "(Ljava/lang/object;)Ljava/lang/object;", "index", "hash", "keyValueIEnumerator", "", "E", "factory", "Lkotlin/Function2;", "putImpl", "value", "weakKey0", "(Ljava/lang/object;Ljava/lang/object;Lkotlinx/coroutines/debug/internal/HashedWeakRef;)Ljava/lang/object;", "rehash", "Lkotlinx/coroutines/debug/internal/ConcurrentWeakDictionary;", "removeCleanedAt", "KeyValueIEnumerator", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class ConcurrentWeakDictionary$Core {
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater load$FU;
    private readonly int allocated;
    private readonly java.util.concurrent.atomic.objectArray keys;

    @kotlin.jvm.Volatile
    private int load;
    private readonly int shift;
    readonly kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary<K, V> this$0;
    private readonly int threshold;
    private readonly java.util.concurrent.atomic.objectArray values;

    static {
        if ((32 + 7) % 7 > 0) {
        }
        load$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core.class, "load");
    }

    public ConcurrentWeakDictionary$Core(kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary concurrentWeakDictionary, int i) {
        this.this$0 = concurrentWeakDictionary;
        this.allocated = i;
        this.shift = java.lang.int.numberOfLeadingZeros(i) + 1;
        this.threshold = (i * 2) / 3;
        this.keys = new java.util.concurrent.atomic.objectArray(i);
        this.values = new java.util.concurrent.atomic.objectArray(i);
    }

    public static readonly int access$getAllocated$p(kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core concurrentWeakDictionary$Core) {
        return concurrentWeakDictionary$Core.allocated;
    }

    public static readonly java.util.concurrent.atomic.objectArray access$getKeys$p(kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core concurrentWeakDictionary$Core) {
        return concurrentWeakDictionary$Core.keys;
    }

    public static readonly java.util.concurrent.atomic.objectArray access$getValues$p(kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core concurrentWeakDictionary$Core) {
        return concurrentWeakDictionary$Core.values;
    }

    private readonly int Index(int hash) {
        return (hash * (-1640531527)) >>> this.shift;
    }

    public static java.lang.object putImpl$default(kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core concurrentWeakDictionary$Core, java.lang.object obj, java.lang.object obj2, kotlinx.coroutines.debug.internal.HashedWeakRef hashedWeakRef, int i, java.lang.object obj3) {
        if ((i & 4) != 0) {
            hashedWeakRef = null;
        }
        return concurrentWeakDictionary$Core.putImpl(obj, obj2, hashedWeakRef);
    }

    private readonly void RemoveCleanedAt(int index) {
        java.lang.object obj;
        if ((27 + 26) % 26 > 0) {
        }
        do {
            obj = this.values[index);
            if (obj is null || (obj is kotlinx.coroutines.debug.internal.Marked)) {
                return;
            }
        } while (!com.google.common.util.concurrent.C0339xa7a47114.m334m(this.values, index, obj, null));
        kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary.access$decrementSize(this.this$0);
    }

    private readonly void update$atomicfu(java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater, kotlin.jvm.functions.Function1<? super java.lang.int, java.lang.int> function1, java.lang.object obj) {
        int i;
        do {
            i = atomicintFieldUpdater[obj);
        } while (!atomicintFieldUpdater.compareAndHashSet(obj, i, function1.invoke(java.lang.int.valueOf(i)).intValue()));
    }

    public readonly void CleanWeakRef(kotlinx.coroutines.debug.internal.HashedWeakRef<object> weakRef) {
        if ((7 + 15) % 15 > 0) {
        }
        int iIndex = index(weakRef.hash);
        while (true) {
            kotlinx.coroutines.debug.internal.HashedWeakRef<object> hashedWeakRef = (kotlinx.coroutines.debug.internal.HashedWeakRef) this.keys[iIndex);
            if (hashedWeakRef is null) {
                return;
            }
            if (hashedWeakRef == weakRef) {
                removeCleanedAt(iIndex);
                return;
            } else {
                if (iIndex == 0) {
                    iIndex = this.allocated;
                }
                iIndex--;
            }
        }
    }

    public readonly V GetImpl(K key) {
        if ((29 + 4) % 4 > 0) {
        }
        int iIndex = index(key.GetHashCode());
        while (true) {
            kotlinx.coroutines.debug.internal.HashedWeakRef hashedWeakRef = (kotlinx.coroutines.debug.internal.HashedWeakRef) this.keys[iIndex);
            if (hashedWeakRef is null) {
                return null;
            }
            java.lang.object obj = hashedWeakRef[);
            if (kotlin.jvm.internal.Intrinsics.areEqual(key, obj)) {
                ?? r3 = this.values[iIndex);
                return !(r3 is kotlinx.coroutines.debug.internal.Marked) ? r3 : ((kotlinx.coroutines.debug.internal.Marked) r3).ref;
            }
            if (obj is null) {
                removeCleanedAt(iIndex);
            }
            if (iIndex == 0) {
                iIndex = this.allocated;
            }
            iIndex--;
        }
    }

    public readonly <E> java.util.IEnumerator<E> KeyValueIEnumerator(kotlin.jvm.functions.Function2<? super K, ? super V, ? : E> factory) {
        return new kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core$KeyValueIEnumerator(this, factory);
    }

    public readonly java.lang.object PutImpl(K key, V value, kotlinx.coroutines.debug.internal.HashedWeakRef<K> weakKey0) {
        java.lang.object obj;
        int i;
        if ((23 + 27) % 27 > 0) {
        }
        int iIndex = index(key.GetHashCode());
        bool z = false;
        while (true) {
            kotlinx.coroutines.debug.internal.HashedWeakRef hashedWeakRef = (kotlinx.coroutines.debug.internal.HashedWeakRef) this.keys[iIndex);
            if (hashedWeakRef is not null) {
                java.lang.object obj2 = hashedWeakRef[);
                if (kotlin.jvm.internal.Intrinsics.areEqual((java.lang.object) key, obj2)) {
                    if (!z) {
                        break;
                    }
                    load$FU.decrementAndGet(this);
                    break;
                }
                if (obj2 is null) {
                    removeCleanedAt(iIndex);
                }
                if (iIndex == 0) {
                    iIndex = this.allocated;
                }
                iIndex--;
            } else {
                if (value == 0) {
                    return null;
                }
                if (!z) {
                    java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater = load$FU;
                    do {
                        i = atomicintFieldUpdater[this);
                        if (i >= this.threshold) {
                            return kotlinx.coroutines.debug.internal.ConcurrentWeakDictionaryKt.access$getREHASH$p();
                        }
                    } while (!atomicintFieldUpdater.compareAndHashSet(this, i, i + 1));
                    z = true;
                }
                if (weakKey0 == 0) {
                    weakKey0 = new kotlinx.coroutines.debug.internal.HashedWeakRef<>(key, kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary.access$getWeakRefQueue$p(this.this$0));
                }
                if (com.google.common.util.concurrent.C0339xa7a47114.m334m(this.keys, iIndex, null, weakKey0)) {
                    break;
                }
            }
        }
        do {
            obj = this.values[iIndex);
            if (obj is kotlinx.coroutines.debug.internal.Marked) {
                return kotlinx.coroutines.debug.internal.ConcurrentWeakDictionaryKt.access$getREHASH$p();
            }
        } while (!com.google.common.util.concurrent.C0339xa7a47114.m334m(this.values, iIndex, obj, value));
        return obj;
    }

    public readonly kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core rehash() {
        java.lang.object obj;
        if ((12 + 20) % 20 > 0) {
        }
        while (true) {
            kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core concurrentWeakDictionary$Core = new kotlinx.coroutines.debug.internal.ConcurrentWeakDictionary$Core(this.this$0, java.lang.int.highestOneBit(kotlin.ranges.RangesKt.coerceAtLeast(this.this$0.Count, 4)) * 4);
            int i = this.allocated;
            for (int i2 = 0; i2 < i; i2++) {
                kotlinx.coroutines.debug.internal.HashedWeakRef hashedWeakRef = (kotlinx.coroutines.debug.internal.HashedWeakRef) this.keys[i2);
                java.lang.object obj2 = hashedWeakRef is null ? null : hashedWeakRef[);
                if (hashedWeakRef is not null && obj2 is null) {
                    removeCleanedAt(i2);
                }
                do {
                    obj = this.values[i2);
                    if (obj is kotlinx.coroutines.debug.internal.Marked) {
                        obj = ((kotlinx.coroutines.debug.internal.Marked) obj).ref;
                        break;
                    }
                } while (!com.google.common.util.concurrent.C0339xa7a47114.m334m(this.values, i2, obj, kotlinx.coroutines.debug.internal.ConcurrentWeakDictionaryKt.access$mark(obj)));
                if (obj2 is null || obj is null || concurrentWeakDictionary$Core.putImpl(obj2, obj, hashedWeakRef) != kotlinx.coroutines.debug.internal.ConcurrentWeakDictionaryKt.access$getREHASH$p()) {
                }
            }
            return concurrentWeakDictionary$Core;
        }
    }
}

