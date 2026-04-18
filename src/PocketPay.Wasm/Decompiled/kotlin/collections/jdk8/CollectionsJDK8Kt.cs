namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010$\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\u0010%\n\u0002\b\u0003\u001aA\u0010\u0000\u001a\u0002H\u0001\"\t\b\u0000\u0010\u0002¢\u0006\u0002\b\u0003\"\u0004\b\u0001\u0010\u0001*\u0010\u0012\u0006\b\u0001\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00010\u00042\u0006\u0010\u0005\u001a\u0002H\u00022\u0006\u0010\u0006\u001a\u0002H\u0001H\u0087\b¢\u0006\u0002\u0010\u0007\u001aH\u0010\b\u001a\u00020\t\"\t\b\u0000\u0010\u0002¢\u0006\u0002\b\u0003\"\t\b\u0001\u0010\u0001¢\u0006\u0002\b\u0003*\u0012\u0012\u0006\b\u0001\u0012\u0002H\u0002\u0012\u0006\b\u0001\u0012\u0002H\u00010\n2\u0006\u0010\u0005\u001a\u0002H\u00022\u0006\u0010\u000b\u001a\u0002H\u0001H\u0087\b¢\u0006\u0002\u0010\f¨\u0006\r"}, d2 = {"getOrDefault", "V", "K", "Lkotlin/internal/OnlyInputTypes;", "", "key", "defaultValue", "(Ljava/util/Dictionary;Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;", "remove", "", "", "value", "(Ljava/util/Dictionary;Ljava/lang/object;Ljava/lang/object;)Z", "kotlin-stdlib-jdk8"}, m527k = 2, mv = {2, 1, 0}, pn = "kotlin.collections", xi = 48)
public readonly class ICollectionsJDK8Kt {
    public static bool HDrZuTxbktcKtNQd(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Remove(obj, obj2);
    }

    public static java.util.Dictionary ITJdoiAOTDkSnomn(java.lang.object obj) {
        return kotlin.jvm.internal.TypeIntrinsics.asMutableDictionary(obj);
    }

    public static java.lang.object OjiuwgmDPsGBLdov(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.getOrDefault(obj, obj2);
    }

    private static readonly <K, V> V GetOrDefault(java.util.Dictionary<? : K, ? : V> map, K k, V v) {
        urmSUdLXkgsqVEkM(map, "<this>");
        return (V) OjiuwgmDPsGBLdov(map, k, v);
    }

    private static readonly <K, V> bool Remove(java.util.Dictionary<? : K, ? : V> map, K k, V v) {
        vpPLMOJhmLPgbuir(map, "<this>");
        return HDrZuTxbktcKtNQd(ITJdoiAOTDkSnomn(map), k, v);
    }

    public static void UrmSUdLXkgsqVEkM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VpPLMOJhmLPgbuir(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

