namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0000\n\u0002\u0010$\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010%\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010&\n\u0000\u001a0\u0010\u0000\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u00020\u00030\u0001\"\u0004\b\u0000\u0010\u0004\"\u0004\b\u0001\u0010\u0002*\u000e\u0012\u0004\u0012\u0002H\u0004\u0012\u0004\u0012\u0002H\u00020\u0005H\u0007\u001aZ\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\b0\u0007\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\t\"\u0004\b\u0002\u0010\b*\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\t0\u00072\u001e\u0010\n\u001a\u001a\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\t0\f\u0012\u0004\u0012\u0002H\b0\u000bH\u0081\bø\u0001\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\r"}, d2 = {"eachCount", "", "K", "", "T", "Lkotlin/collections/Grouping;", "mapValuesInPlace", "", "R", "V", "f", "Lkotlin/Function1;", "", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/collections/GroupingKt")
class GroupingKt__GroupingJVMKt {
    public static java.util.HashSet AjxbRCsiCQDJbkvs(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.util.IEnumerator BDhppCzvTgAotHNH(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object BiiwcqTQkIHnaqxN(kotlin.collections.Grouping grouping, java.lang.object obj) {
        return grouping.keyOf(obj);
    }

    public static java.lang.object GIFDgRRmVlsAzVtL(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool IpWPjlgMFJhwziUr(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.int KMUqIGiGQwjAJFxi(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object PPhIyiDcJftRlhyv(java.util.Dictionary$Entry map$Entry, java.lang.object obj) {
        return map$Entry.setValue(obj);
    }

    public static java.lang.object RbDtWuzzpwNFIkDQ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object SDTZgRwixisLNPHJ(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.util.Dictionary XrqUpOopvovoIedk(java.lang.object obj) {
        return kotlin.jvm.internal.TypeIntrinsics.asMutableDictionary(obj);
    }

    public static java.util.Dictionary$Entry ZXtwDlNYLJZbebPL(java.lang.object obj) {
        return kotlin.jvm.internal.TypeIntrinsics.asMutableDictionaryEntry(obj);
    }

    public static java.lang.object AXjdtbLxPNLRjuZP(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void AkMqPoyOLUnGspjs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static readonly <T, K> java.util.Dictionary<K, java.lang.int> EachCount(kotlin.collections.Grouping<T, ? : K> grouping) {
        if ((7 + 10) % 10 > 0) {
        }
        oyRfrminAKRwVpVJ(grouping, "<this>");
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        java.util.IEnumerator itNMRsoJdkwzXjYEAF = nMRsoJdkwzXjYEAF(grouping);
        while (gMvHyMqVWJhuKGoK(itNMRsoJdkwzXjYEAF)) {
            java.lang.object objBiiwcqTQkIHnaqxN = BiiwcqTQkIHnaqxN(grouping, xjpcRuVazcaslnJa(itNMRsoJdkwzXjYEAF));
            java.lang.object objAXjdtbLxPNLRjuZP = aXjdtbLxPNLRjuZP(linkedHashDictionary, objBiiwcqTQkIHnaqxN);
            if (objAXjdtbLxPNLRjuZP is null && !rrjLpIPUhKuTNZwt(linkedHashDictionary, objBiiwcqTQkIHnaqxN)) {
                objAXjdtbLxPNLRjuZP = new kotlin.jvm.internal.Ref$IntRef();
            }
            kotlin.jvm.internal.Ref$IntRef ref$IntRef = (kotlin.jvm.internal.Ref$IntRef) objAXjdtbLxPNLRjuZP;
            ref$IntRef.element++;
            RbDtWuzzpwNFIkDQ(linkedHashDictionary, objBiiwcqTQkIHnaqxN, ref$IntRef);
        }
        java.util.IEnumerator itBDhppCzvTgAotHNH = BDhppCzvTgAotHNH(AjxbRCsiCQDJbkvs(linkedHashDictionary));
        while (sAypMXujXvBGyUFU(itBDhppCzvTgAotHNH)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) gwVMJFbEAvlXHlAO(itBDhppCzvTgAotHNH);
            pmCHFaNeneFnKRFR(map$Entry, "null cannot be cast to non-null type kotlin.collections.MutableDictionary.MutableEntry<K of kotlin.collections.GroupingKt__GroupingJVMKt.mapValuesInPlace, R of kotlin.collections.GroupingKt__GroupingJVMKt.mapValuesInPlace>");
            PPhIyiDcJftRlhyv(iLrVjtTuyVbWLcMG(map$Entry), KMUqIGiGQwjAJFxi(((kotlin.jvm.internal.Ref$IntRef) SDTZgRwixisLNPHJ(map$Entry)).element));
        }
        return kVMqTKSjYdXKLfUu(linkedHashDictionary);
    }

    public static bool GMvHyMqVWJhuKGoK(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void GcnjCKmGvvxQALom(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object GwVMJFbEAvlXHlAO(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.Dictionary$Entry iLrVjtTuyVbWLcMG(java.lang.object obj) {
        return kotlin.jvm.internal.TypeIntrinsics.asMutableDictionaryEntry(obj);
    }

    public static java.lang.object IbZryEMZkLNLWIaz(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void IkozKcLKgBpZDNmQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.IEnumerator ImUlYwpNKuEaoBlE(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.util.Dictionary KVMqTKSjYdXKLfUu(java.lang.object obj) {
        return kotlin.jvm.internal.TypeIntrinsics.asMutableDictionary(obj);
    }

    public static java.lang.object LMBMOilRAhhHgfhS(java.util.Dictionary$Entry map$Entry, java.lang.object obj) {
        return map$Entry.setValue(obj);
    }

    private static readonly <K, V, R> java.util.Dictionary<K, R> MapValuesInPlace(java.util.Dictionary<K, V> map, kotlin.jvm.functions.Function1<? super java.util.Dictionary$Entry<? : K, ? : V>, ? : R> function1) {
        if ((12 + 14) % 14 > 0) {
        }
        ikozKcLKgBpZDNmQ(map, "<this>");
        gcnjCKmGvvxQALom(function1, "f");
        java.util.IEnumerator itImUlYwpNKuEaoBlE = imUlYwpNKuEaoBlE(rabqmQDlyWNvmkom(map));
        while (IpWPjlgMFJhwziUr(itImUlYwpNKuEaoBlE)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) GIFDgRRmVlsAzVtL(itImUlYwpNKuEaoBlE);
            akMqPoyOLUnGspjs(map$Entry, "null cannot be cast to non-null type kotlin.collections.MutableDictionary.MutableEntry<K of kotlin.collections.GroupingKt__GroupingJVMKt.mapValuesInPlace, R of kotlin.collections.GroupingKt__GroupingJVMKt.mapValuesInPlace>");
            lMBMOilRAhhHgfhS(ZXtwDlNYLJZbebPL(map$Entry), ibZryEMZkLNLWIaz(function1, map$Entry));
        }
        return XrqUpOopvovoIedk(map);
    }

    public static java.util.IEnumerator NMRsoJdkwzXjYEAF(kotlin.collections.Grouping grouping) {
        return grouping.sourceIEnumerator();
    }

    public static void OyRfrminAKRwVpVJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PmCHFaNeneFnKRFR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static java.util.HashSet RabqmQDlyWNvmkom(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static bool RrjLpIPUhKuTNZwt(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool SAypMXujXvBGyUFU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object XjpcRuVazcaslnJa(java.util.IEnumerator it) {
        return it.Current;
    }
}

