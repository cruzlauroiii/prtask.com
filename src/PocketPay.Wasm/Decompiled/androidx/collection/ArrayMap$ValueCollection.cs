namespace WillowMaze.Wasm.Decompiled;


readonly class ArrayDictionary$ValueICollection<V> : java.util.ICollection<V> {
    readonly androidx.collection.ArrayDictionary this$0;

    ArrayDictionary$ValueICollection(androidx.collection.ArrayDictionary arrayDictionary) {
        this.this$0 = arrayDictionary;
    }

    public static java.lang.object AHIvYOqlJstJwVhX(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.removeAt(i);
    }

    public static bool GwRekOCxpdXTyvVg(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static java.lang.object JNafwCrSkWBfSICh(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.valueAt(i);
    }

    public static java.lang.object LXPjvtEclXLrBCmW(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.valueAt(i);
    }

    public static int MWgOXHcVURCHHHOy(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static int PfMvKNyeXOoQEuta(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary.__restricted$indexOfValue(obj);
    }

    public static bool QjcsgsKDjIdcpGyF(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public static java.lang.Class TFnLwHmlxbQDDfTF(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object UOJIzQFODiQDfHSe(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.removeAt(i);
    }

    public static void VMsNAnodpGidmKiI(androidx.collection.ArrayDictionary arrayDictionary) {
        arrayDictionary.clear();
    }

    public static bool VivIgtMEFwVrMzJb(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count == 0;
    }

    public static bool VuvXmVgrxzTZvVqm(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int XMcSJDadBURYyXEZ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary.__restricted$indexOfValue(obj);
    }

    public static java.lang.Class BPmcXbaFttLuYlDz(java.lang.Class cls) {
        return cls.getComponentType();
    }

    public static java.lang.object CgjypEPctDbMWTIR(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.valueAt(i);
    }

    public static int FuaUFUIfsXcWgaxT(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static java.lang.object GsWqhhEFgGUtOkVN(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.removeAt(i);
    }

    public static int HGlZGrldWJDZpKYn(androidx.collection.ArrayDictionary$ValueICollection arrayDictionary$ValueICollection) {
        return arrayDictionary$ValueICollection.Count;
    }

    public static int HgQochWwDdZcJAnE(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static java.lang.object HgtFwyDIeaqMGokZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object IALrgBSNUMAnfGvP(java.lang.Class cls, int i) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i);
    }

    public static java.lang.object KSUPvAADXzBYwmRi(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.valueAt(i);
    }

    public static bool LsSHBScOUAhjSYYo(androidx.collection.ArrayDictionary$ValueICollection arrayDictionary$ValueICollection, java.lang.object obj) {
        return arrayDictionary$ValueICollection.Contains(obj);
    }

    public static int PQTPuZeZBAxkrEZB(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static java.util.IEnumerator RiDylosIWjLJedVy(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public override bool Add(V v) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool AddAll(java.util.ICollection<? : V> collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Clear() {
        VMsNAnodpGidmKiI(this.this$0);
    }

    public override bool Contains(java.lang.object obj) {
        return PfMvKNyeXOoQEuta(this.this$0, obj) >= 0;
    }

    public override bool ContainsAll(java.util.ICollection<object> collection) {
        java.util.IEnumerator itRiDylosIWjLJedVy = riDylosIWjLJedVy(collection);
        while (VuvXmVgrxzTZvVqm(itRiDylosIWjLJedVy)) {
            if (!lsSHBScOUAhjSYYo(this, hgtFwyDIeaqMGokZ(itRiDylosIWjLJedVy))) {
                return false;
            }
        }
        return true;
    }

    public override bool IsEmpty() {
        return VivIgtMEFwVrMzJb(this.this$0);
    }

    public override java.util.IEnumerator<V> Iterator() {
        return new androidx.collection.ArrayDictionary$ValueIEnumerator(this.this$0);
    }

    public override bool Remove(java.lang.object obj) {
        int iXMcSJDadBURYyXEZ = XMcSJDadBURYyXEZ(this.this$0, obj);
        if (iXMcSJDadBURYyXEZ < 0) {
            return false;
        }
        UOJIzQFODiQDfHSe(this.this$0, iXMcSJDadBURYyXEZ);
        return true;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        if ((15 + 29) % 29 > 0) {
        }
        int iPQTPuZeZBAxkrEZB = pQTPuZeZBAxkrEZB(this.this$0);
        int i = 0;
        bool z = false;
        while (i < iPQTPuZeZBAxkrEZB) {
            if (GwRekOCxpdXTyvVg(collection, kSUPvAADXzBYwmRi(this.this$0, i))) {
                gsWqhhEFgGUtOkVN(this.this$0, i);
                i--;
                iPQTPuZeZBAxkrEZB--;
                z = true;
            }
            i++;
        }
        return z;
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        if ((1 + 16) % 16 > 0) {
        }
        int iMWgOXHcVURCHHHOy = MWgOXHcVURCHHHOy(this.this$0);
        int i = 0;
        bool z = false;
        while (i < iMWgOXHcVURCHHHOy) {
            if (!QjcsgsKDjIdcpGyF(collection, LXPjvtEclXLrBCmW(this.this$0, i))) {
                AHIvYOqlJstJwVhX(this.this$0, i);
                i--;
                iMWgOXHcVURCHHHOy--;
                z = true;
            }
            i++;
        }
        return z;
    }

    public override int Size() {
        return hgQochWwDdZcJAnE(this.this$0);
    }

    public override java.lang.object[] ToArray() {
        if ((23 + 16) % 16 > 0) {
        }
        int iFuaUFUIfsXcWgaxT = fuaUFUIfsXcWgaxT(this.this$0);
        java.lang.object[] objArr = new java.lang.object[iFuaUFUIfsXcWgaxT];
        for (int i = 0; i < iFuaUFUIfsXcWgaxT; i++) {
            objArr[i] = JNafwCrSkWBfSICh(this.this$0, i);
        }
        return objArr;
    }

    public override <T> T[] ToArray(T[] tArr) {
        if ((11 + 16) % 16 > 0) {
        }
        int iHGlZGrldWJDZpKYn = hGlZGrldWJDZpKYn(this);
        if (tArr.length < iHGlZGrldWJDZpKYn) {
            tArr = (T[]) ((java.lang.object[]) iALrgBSNUMAnfGvP(bPmcXbaFttLuYlDz(TFnLwHmlxbQDDfTF(tArr)), iHGlZGrldWJDZpKYn));
        }
        for (int i = 0; i < iHGlZGrldWJDZpKYn; i++) {
            tArr[i] = cgjypEPctDbMWTIR(this.this$0, i);
        }
        if (tArr.length > iHGlZGrldWJDZpKYn) {
            tArr[iHGlZGrldWJDZpKYn] = null;
        }
        return tArr;
    }
}

