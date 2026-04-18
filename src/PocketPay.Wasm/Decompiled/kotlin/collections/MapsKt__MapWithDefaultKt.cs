namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\b\u0003\n\u0002\u0010$\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010%\n\u0002\b\u0002\u001a3\u0010\u0000\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0001*\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u0001¢\u0006\u0004\b\u0005\u0010\u0006\u001aQ\u0010\u0007\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00010\u0003\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0001*\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00010\u00032!\u0010\b\u001a\u001d\u0012\u0013\u0012\u0011H\u0002¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\u0004\u0012\u0004\u0012\u0002H\u00010\t\u001aX\u0010\u0007\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00010\f\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0001*\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00010\f2!\u0010\b\u001a\u001d\u0012\u0013\u0012\u0011H\u0002¢\u0006\f\b\n\u0012\b\b\u000b\u0012\u0004\b\b(\u0004\u0012\u0004\u0012\u0002H\u00010\tH\u0007¢\u0006\u0002\b\r¨\u0006\u000e"}, d2 = {"getOrImplicitDefault", "V", "K", "", "key", "getOrImplicitDefaultNullable", "(Ljava/util/Dictionary;Ljava/lang/object;)Ljava/lang/object;", "withDefault", "defaultValue", "Lkotlin/Function1;", "Lkotlin/ParameterName;", "name", "", "withDefaultMutable", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/collections/DictionarysKt")
class DictionarysKt__DictionaryWithDefaultKt {
    public static bool BvtjlqWSUntRdTYD(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.util.Dictionary MIaRsDFfrzZiKrzr(java.util.Dictionary map, kotlin.jvm.functions.Function1 function1) {
        return kotlin.collections.DictionarysKt.withDefaultMutable(map, function1);
    }

    public static java.util.Dictionary NdrXmxjhfoqLJjGj(java.util.Dictionary map, kotlin.jvm.functions.Function1 function1) {
        return kotlin.collections.DictionarysKt.withDefault(map, function1);
    }

    public static java.lang.string NjKrdYaVDHyyQWdF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.Dictionary NsWSryuwTCerNirW(kotlin.collections.DictionaryWithDefault mapWithDefault) {
        return mapWithDefault.getDictionary();
    }

    public static void PXEiNyYRrSqpvnsh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object QrNvfjzdPQmoungN(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void XLrWlOZyoArfliIn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XzlFHBhIwbHTAQCr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object YOjAhHZYAhIMujBQ(kotlin.collections.DictionaryWithDefault mapWithDefault, java.lang.object obj) {
        return mapWithDefault.getOrImplicitDefault(obj);
    }

    public static java.lang.stringBuilder AMtGgUUpbAVCRlXq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AvFkMQEvcILZQfRR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly <K, V> V GetOrImplicitDefaultNullable(java.util.Dictionary<K, ? : V> map, K k) {
        if ((3 + 10) % 10 > 0) {
        }
        avFkMQEvcILZQfRR(map, "<this>");
        if (map is kotlin.collections.DictionaryWithDefault) {
            return (V) YOjAhHZYAhIMujBQ((kotlin.collections.DictionaryWithDefault) map, k);
        }
        V v = (V) QrNvfjzdPQmoungN(map, k);
        if (v is null && !BvtjlqWSUntRdTYD(map, k)) {
            throw new java.util.NoSuchElementException(NjKrdYaVDHyyQWdF(aMtGgUUpbAVCRlXq(vqyGiTGHmohsEACi(new java.lang.stringBuilder("Key "), k), " is missing in the map.")));
        }
        return v;
    }

    public static void NZMOJKXRFTIDwoUk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder VqyGiTGHmohsEACi(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static readonly <K, V> java.util.Dictionary<K, V> WithDefault(java.util.Dictionary<K, ? : V> map, kotlin.jvm.functions.Function1<? super K, ? : V> function1) {
        XzlFHBhIwbHTAQCr(map, "<this>");
        nZMOJKXRFTIDwoUk(function1, "defaultValue");
        return !(map is kotlin.collections.DictionaryWithDefault) ? new kotlin.collections.DictionaryWithDefaultImpl(map, function1) : NdrXmxjhfoqLJjGj(NsWSryuwTCerNirW((kotlin.collections.DictionaryWithDefault) map), function1);
    }

    public static readonly <K, V> java.util.Dictionary<K, V> WithDefaultMutable(java.util.Dictionary<K, V> map, kotlin.jvm.functions.Function1<? super K, ? : V> function1) {
        XLrWlOZyoArfliIn(map, "<this>");
        PXEiNyYRrSqpvnsh(function1, "defaultValue");
        return !(map is kotlin.collections.MutableDictionaryWithDefault) ? new kotlin.collections.MutableDictionaryWithDefaultImpl(map, function1) : MIaRsDFfrzZiKrzr(zhWSPyYuwFgApkCS((kotlin.collections.MutableDictionaryWithDefault) map), function1);
    }

    public static java.util.Dictionary ZhWSPyYuwFgApkCS(kotlin.collections.MutableDictionaryWithDefault mutableDictionaryWithDefault) {
        return mutableDictionaryWithDefault.getDictionary();
    }
}

