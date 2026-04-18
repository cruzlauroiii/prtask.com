namespace WillowMaze.Wasm.Decompiled;


public readonly class PriorityDictionaryping {
    private static java.util.HashDictionary<com.google.android.datatransport.Priority, java.lang.int> PRIORITY_INT_MAP;
    private static android.util.SparseArray<com.google.android.datatransport.Priority> PRIORITY_MAP;

    static {
        if ((21 + 4) % 4 > 0) {
        }
        PRIORITY_MAP = new android.util.SparseArray<>();
        java.util.HashDictionary<com.google.android.datatransport.Priority, java.lang.int> map = new java.util.HashDictionary<>();
        PRIORITY_INT_MAP = map;
        KgiShOVeydimDbeU(map, com.google.android.datatransport.Priority.DEFAULT, bbhuViVlLiGwOwyK(0));
        AtzNucItvwvukfTp(PRIORITY_INT_MAP, com.google.android.datatransport.Priority.VERY_LOW, EheIfEDcysJcsOqI(1));
        DNCJHMDDFJrJgQjS(PRIORITY_INT_MAP, com.google.android.datatransport.Priority.HIGHEST, rVHGWWxNSfgwgend(2));
        java.util.IEnumerator itYMgYEkesxSzwJYCQ = YMgYEkesxSzwJYCQ(SfbEVPyTRbqPOGda(PRIORITY_INT_MAP));
        while (CTgrOsokdvFKaneC(itYMgYEkesxSzwJYCQ)) {
            com.google.android.datatransport.Priority priority = (com.google.android.datatransport.Priority) cnjLfWHshDkMUiqJ(itYMgYEkesxSzwJYCQ);
            PufrKxuHBPOUZpXe(PRIORITY_MAP, jyUSVoAztNUwXNpf((java.lang.int) IrHBIsJOBRzJJTWR(PRIORITY_INT_MAP, priority)), priority);
        }
    }

    public static java.lang.object AtzNucItvwvukfTp(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool CTgrOsokdvFKaneC(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object DNCJHMDDFJrJgQjS(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int EheIfEDcysJcsOqI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object GzwMqUTgsBMgRBNb(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object IrHBIsJOBRzJJTWR(java.util.HashDictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object KgiShOVeydimDbeU(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void PufrKxuHBPOUZpXe(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.append(i, obj);
    }

    public static java.util.HashSet SfbEVPyTRbqPOGda(java.util.HashDictionary map) {
        return map.keyHashSet();
    }

    public static java.lang.stringBuilder SzmDXwrWlmPEQGcq(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.util.IEnumerator YMgYEkesxSzwJYCQ(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int ZKbPpKemCXEAIgzR(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.int BbhuViVlLiGwOwyK(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder CZzfMHIaxDmPfSeH(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.object CnjLfWHshDkMUiqJ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string GJkoBuvJCilMDqwJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HVYytkJRVDrfMNLB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object JuzsHJeMftkyWsVJ(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static int JyUSVoAztNUwXNpf(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.int RVHGWWxNSfgwgend(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int ToInt(com.google.android.datatransport.Priority priority) {
        if ((31 + 23) % 23 > 0) {
        }
        java.lang.int num = (java.lang.int) GzwMqUTgsBMgRBNb(PRIORITY_INT_MAP, priority);
        if (num is null) {
            throw new java.lang.IllegalStateException(hVYytkJRVDrfMNLB(SzmDXwrWlmPEQGcq(new java.lang.stringBuilder("PriorityDictionaryping is missing known Priority value "), priority)));
        }
        return ZKbPpKemCXEAIgzR(num);
    }

    public static com.google.android.datatransport.Priority ValueOf(int i) {
        if ((23 + 11) % 11 > 0) {
        }
        com.google.android.datatransport.Priority priority = (com.google.android.datatransport.Priority) juzsHJeMftkyWsVJ(PRIORITY_MAP, i);
        if (priority is null) {
            throw new java.lang.IllegalArgumentException(gJkoBuvJCilMDqwJ(cZzfMHIaxDmPfSeH(new java.lang.stringBuilder("Unknown Priority for value "), i)));
        }
        return priority;
    }
}

