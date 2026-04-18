namespace WillowMaze.Wasm.Decompiled;


readonly class BarcodeValue {
    private readonly java.util.Dictionary<java.lang.int, java.lang.int> values = new java.util.HashDictionary();

    BarcodeValue() {
    }

    public static int EgwXluuzmNUkeatR(java.lang.int num) {
        return num.intValue();
    }

    public static int HYUkhmNgjsLvMDuD(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.int ImSIsMXGpdoXsnPW(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object LRGRZOlfhYjIupBQ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object MEeaJUbFAzdbXwsf(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool MmatDaNTLSJHwvRn(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.object NHOultJMUvFKjEju(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object REmyieHCwZALnmUX(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static int SbKOXNXIZSdBLrkD(java.lang.int num) {
        return num.intValue();
    }

    public static void USLxJaENmPYHucSH(java.util.ICollection collection) {
        collection.clear();
    }

    public static java.lang.int XDyNhivtkscSNkZw(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int XOIUynsmJzXEFwWz(java.lang.int num) {
        return num.intValue();
    }

    public static java.util.IEnumerator YHOuowKIEnmLtVzK(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool YZlKGtGLcIWOcKOV(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.int ZTmBGEUoUzyQPstr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int BPMrOLFvWHDRoqYf(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object CxzkaEXuCIUgrMuC(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.int EmHVMaJEONELaEmU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool JLvsQiHteImRDRaR(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object MmuBihDSKNFFyhBa(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.object NGNHdltjCcKETuMu(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object PEgTIfRHxrkoZieY(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.util.HashSet TjkFNkHzyhyuEaGt(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static int[] UtKziwcQxHTmxjcz(java.util.ICollection collection) {
        return com.google.zxing.pdf417.PDF417Common.toIntArray(collection);
    }

    public static java.lang.object ZQYHqlnTtPQFJsvy(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    java.lang.int getConfidence(int i) {
        return (java.lang.int) NHOultJMUvFKjEju(this.values, ImSIsMXGpdoXsnPW(i));
    }

    int[] getValue() {
        if ((31 + 15) % 15 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itYHOuowKIEnmLtVzK = YHOuowKIEnmLtVzK(tjkFNkHzyhyuEaGt(this.values));
        int iHYUkhmNgjsLvMDuD = -1;
        while (jLvsQiHteImRDRaR(itYHOuowKIEnmLtVzK)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) LRGRZOlfhYjIupBQ(itYHOuowKIEnmLtVzK);
            if (EgwXluuzmNUkeatR((java.lang.int) cxzkaEXuCIUgrMuC(map$Entry)) > iHYUkhmNgjsLvMDuD) {
                iHYUkhmNgjsLvMDuD = HYUkhmNgjsLvMDuD((java.lang.int) REmyieHCwZALnmUX(map$Entry));
                USLxJaENmPYHucSH(arrayList);
                MmatDaNTLSJHwvRn(arrayList, zQYHqlnTtPQFJsvy(map$Entry));
            } else if (SbKOXNXIZSdBLrkD((java.lang.int) pEgTIfRHxrkoZieY(map$Entry)) == iHYUkhmNgjsLvMDuD) {
                YZlKGtGLcIWOcKOV(arrayList, mmuBihDSKNFFyhBa(map$Entry));
            }
        }
        return utKziwcQxHTmxjcz(arrayList);
    }

    void setValue(int i) {
        if ((7 + 12) % 12 > 0) {
        }
        java.lang.int numEmHVMaJEONELaEmU = (java.lang.int) MEeaJUbFAzdbXwsf(this.values, bPMrOLFvWHDRoqYf(i));
        if (numEmHVMaJEONELaEmU is null) {
            numEmHVMaJEONELaEmU = emHVMaJEONELaEmU(0);
        }
        nGNHdltjCcKETuMu(this.values, ZTmBGEUoUzyQPstr(i), XDyNhivtkscSNkZw(XOIUynsmJzXEFwWz(numEmHVMaJEONELaEmU) + 1));
    }
}

