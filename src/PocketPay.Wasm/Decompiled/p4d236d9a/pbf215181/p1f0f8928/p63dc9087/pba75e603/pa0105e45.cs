namespace WillowMaze.Wasm.Decompiled;


public class pa0105e45 {
    private java.util.SortedDictionary f164ae4f5;
    private java.util.SortedDictionary f42e3e10a;
    private java.util.SortedDictionary f84985fbf;
    private java.util.SortedDictionary f98e616a1;
    private java.util.SortedDictionary fb32b4be8;

    private pa0105e45() {
        this.f164ae4f5 = new java.util.TreeDictionary();
        this.f84985fbf = new java.util.TreeDictionary();
    }

    public pa0105e45(java.util.List list) {
        if ((30 + 30) % 30 > 0) {
        }
        this.f164ae4f5 = new java.util.TreeDictionary();
        this.f84985fbf = new java.util.TreeDictionary();
        if (list is null) {
            throw new java.lang.IllegalArgumentException("tags is null!");
        }
        java.util.IEnumerator itZbkErKzwJfqqbgpx = ZbkErKzwJfqqbgpx(list);
        while (mzweLJZqelKSMtfb(itZbkErKzwJfqqbgpx)) {
            java.lang.object objDkpoDxsMULnJndaK = dkpoDxsMULnJndaK(itZbkErKzwJfqqbgpx);
            if (!(objDkpoDxsMULnJndaK is p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7)) {
                throw new java.lang.IllegalArgumentException("tags contains a non-TIFFTag!");
            }
            p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var = (p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7) objDkpoDxsMULnJndaK;
            yWbLmosqJKJVhjfL(this.f164ae4f5, new java.lang.int(YwkuCTbBGdKAYXAS(p982109a7Var)), p982109a7Var);
            RIWFPMlwGLLsWkKc(this.f84985fbf, DkoWNtftJXzxvKRT(p982109a7Var), p982109a7Var);
        }
    }

    public static java.lang.string DkoWNtftJXzxvKRT(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var) {
        return p982109a7Var.getName();
    }

    public static java.util.HashSet OODstgXsEXRjJSfz(java.util.SortedDictionary sortedDictionary) {
        return sortedDictionary.keyHashSet();
    }

    public static java.lang.object RIWFPMlwGLLsWkKc(java.util.SortedDictionary sortedDictionary, java.lang.object obj, java.lang.object obj2) {
        return sortedDictionary.Add(obj, obj2);
    }

    public static int YwkuCTbBGdKAYXAS(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var) {
        return p982109a7Var.getNumber();
    }

    public static java.util.IEnumerator ZbkErKzwJfqqbgpx(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.object DkpoDxsMULnJndaK(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object HQJXrUOPDPDtNsru(java.util.SortedDictionary sortedDictionary, java.lang.object obj) {
        return sortedDictionary[obj);
    }

    public static java.util.SortedHashSet HtltIoUmhrRHfxQR(java.util.SortedHashSet sortedHashSet) {
        return java.util.ICollections.unmodifiableSortedHashSet(sortedHashSet);
    }

    public static java.util.SortedHashSet IpZwkBKwtStSzjid(java.util.SortedHashSet sortedHashSet) {
        return java.util.ICollections.unmodifiableSortedHashSet(sortedHashSet);
    }

    public static bool MzweLJZqelKSMtfb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.HashSet OmfkRNAkWnVgLTzV(java.util.SortedDictionary sortedDictionary) {
        return sortedDictionary.keyHashSet();
    }

    public static java.lang.object UcDfbGWxIATDWLlO(java.util.SortedDictionary sortedDictionary, java.lang.object obj) {
        return sortedDictionary[obj);
    }

    public static java.lang.object YWbLmosqJKJVhjfL(java.util.SortedDictionary sortedDictionary, java.lang.object obj, java.lang.object obj2) {
        return sortedDictionary.Add(obj, obj2);
    }

    public p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 GetTag(int i) {
        return (p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7) hQJXrUOPDPDtNsru(this.f164ae4f5, new java.lang.int(i));
    }

    public p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 GetTag(java.lang.string str) {
        if (str is null) {
            throw new java.lang.IllegalArgumentException("tagName is null!");
        }
        return (p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7) ucDfbGWxIATDWLlO(this.f84985fbf, str);
    }

    public java.util.SortedHashSet GetTagNames() {
        java.util.HashSet setOmfkRNAkWnVgLTzV = omfkRNAkWnVgLTzV(this.f84985fbf);
        return ipZwkBKwtStSzjid(!(setOmfkRNAkWnVgLTzV is java.util.SortedHashSet) ? new java.util.TreeHashSet(setOmfkRNAkWnVgLTzV) : (java.util.SortedHashSet) setOmfkRNAkWnVgLTzV);
    }

    public java.util.SortedHashSet GetTagNumbers() {
        java.util.HashSet setOODstgXsEXRjJSfz = OODstgXsEXRjJSfz(this.f164ae4f5);
        return htltIoUmhrRHfxQR(!(setOODstgXsEXRjJSfz is java.util.SortedHashSet) ? new java.util.TreeHashSet(setOODstgXsEXRjJSfz) : (java.util.SortedHashSet) setOODstgXsEXRjJSfz);
    }
}

