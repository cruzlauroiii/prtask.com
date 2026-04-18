namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0005\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u0002H\u00022\u0006\u0010\b\u001a\u0002H\u00042\b\u0010\t\u001a\u0004\u0018\u0001H\u0004H\n¢\u0006\u0004\b\n\u0010\u000b"}, d2 = {"<anonymous>", "", "K", "", "V", "<anonymous parameter 0>", "", "<anonymous parameter 1>", "<anonymous parameter 2>", "<anonymous parameter 3>", "invoke", "(ZLjava/lang/object;Ljava/lang/object;Ljava/lang/object;)V"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class LruCacheKt$lruCache$3<K, V> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function4<java.lang.bool, K, V, V, kotlin.Unit> {
    public static readonly androidx.collection.LruCacheKt$lruCache$3 INSTANCE = new androidx.collection.LruCacheKt$lruCache$3();

    public LruCacheKt$lruCache$3() {
        super(4);
    }

    public override kotlin.Unit Invoke(java.lang.bool bool, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        invoke(bool.boolValue(), obj, obj2, obj3);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke(bool z, K k, V v, V v2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(k, "<anonymous parameter 1>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(v, "<anonymous parameter 2>");
    }
}

