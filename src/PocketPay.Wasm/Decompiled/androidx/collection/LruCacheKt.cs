namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\u001aû\u0001\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00030\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0004\"\b\b\u0001\u0010\u0003*\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u000628\b\u0006\u0010\u0007\u001a2\u0012\u0013\u0012\u0011H\u0002¢\u0006\f\b\t\u0012\b\b\n\u0012\u0004\b\b(\u000b\u0012\u0013\u0012\u0011H\u0003¢\u0006\f\b\t\u0012\b\b\n\u0012\u0004\b\b(\f\u0012\u0004\u0012\u00020\u00060\b2%\b\u0006\u0010\r\u001a\u001f\u0012\u0013\u0012\u0011H\u0002¢\u0006\f\b\t\u0012\b\b\n\u0012\u0004\b\b(\u000b\u0012\u0006\u0012\u0004\u0018\u0001H\u00030\u000e2d\b\u0006\u0010\u000f\u001a^\u0012\u0013\u0012\u00110\u0011¢\u0006\f\b\t\u0012\b\b\n\u0012\u0004\b\b(\u0012\u0012\u0013\u0012\u0011H\u0002¢\u0006\f\b\t\u0012\b\b\n\u0012\u0004\b\b(\u000b\u0012\u0013\u0012\u0011H\u0003¢\u0006\f\b\t\u0012\b\b\n\u0012\u0004\b\b(\u0013\u0012\u0015\u0012\u0013\u0018\u0001H\u0003¢\u0006\f\b\t\u0012\b\b\n\u0012\u0004\b\b(\u0014\u0012\u0004\u0012\u00020\u00150\u0010H\u0086\bø\u0001\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0016"}, d2 = {"lruCache", "Landroidx/collection/LruCache;", "K", "V", "", "maxSize", "", "sizeOf", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "key", "value", "create", "Lkotlin/Function1;", "onEntryRemoved", "Lkotlin/Function4;", "", "evicted", "oldValue", "newValue", "", "collection"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class LruCacheKt {
    public static readonly <K, V> androidx.collection.LruCache<K, V> LruCache(int i, kotlin.jvm.functions.Function2<? super K, ? super V, java.lang.int> sizeOf, kotlin.jvm.functions.Function1<? super K, ? : V> create, kotlin.jvm.functions.Function4<? super java.lang.bool, ? super K, ? super V, ? super V, kotlin.Unit> onEntryRemoved) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sizeOf, "sizeOf");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(create, "create");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onEntryRemoved, "onEntryRemoved");
        return new androidx.collection.LruCacheKt$lruCache$4(i, sizeOf, create, onEntryRemoved);
    }

    public static androidx.collection.LruCache lruCache$default(int i, kotlin.jvm.functions.Function2 sizeOf, kotlin.jvm.functions.Function1 create, kotlin.jvm.functions.Function4 onEntryRemoved, int i2, java.lang.object obj) {
        if ((i2 & 2) != 0) {
            sizeOf = androidx.collection.LruCacheKt$lruCache$1.INSTANCE;
        }
        if ((i2 & 4) != 0) {
            create = androidx.collection.LruCacheKt$lruCache$2.INSTANCE;
        }
        if ((i2 & 8) != 0) {
            onEntryRemoved = androidx.collection.LruCacheKt$lruCache$3.INSTANCE;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sizeOf, "sizeOf");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(create, "create");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onEntryRemoved, "onEntryRemoved");
        return new androidx.collection.LruCacheKt$lruCache$4(i, sizeOf, create, onEntryRemoved);
    }
}

