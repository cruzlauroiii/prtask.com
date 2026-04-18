namespace WillowMaze.Wasm.Decompiled;


readonly class ArrayDictionary$KeyHashSet<K> : java.util.HashSet<K> {
    readonly androidx.collection.ArrayDictionary this$0;

    ArrayDictionary$KeyHashSet(androidx.collection.ArrayDictionary arrayDictionary) {
        this.this$0 = arrayDictionary;
    }

    public static java.lang.Class CWOwDsfGjLsRKKST(java.lang.Class cls) {
        return cls.getComponentType();
    }

    public static int XvZDiCdaubsrdtIU(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int YuwQCQikaHGAOyji(androidx.collection.ArrayDictionary$KeyHashSet arrayDictionary$KeyHashSet) {
        return arrayDictionary$KeyHashSet.Count;
    }

    public static bool YwYgIxuLGOqCemyk(androidx.collection.ArrayDictionary arrayDictionary, java.util.ICollection collection) {
        return arrayDictionary.removeAll(collection);
    }

    public static java.lang.Class ZpjlRFzpzLAPGtzK(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.object ZptQkLRxVLSiDwZi(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.keyAt(i);
    }

    public static int EhukqjPOKeuSSyxE(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static int FkroLvwiDJovROCo(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary.indexOfKey(obj);
    }

    public static bool GoviFnWVhTRoEHNu(androidx.collection.ArrayDictionary arrayDictionary, java.util.ICollection collection) {
        return arrayDictionary.containsAll(collection);
    }

    public static void OwfQLQUjzIekQEsw(androidx.collection.ArrayDictionary arrayDictionary) {
        arrayDictionary.clear();
    }

    public static int PYHaogFlZbbIDKKl(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static bool PqQIsCxAejHxCOuI(androidx.collection.ArrayDictionary arrayDictionary, java.util.ICollection collection) {
        return arrayDictionary.retainAll(collection);
    }

    public static java.lang.object QzjNwNKGMFpUHSdC(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.removeAt(i);
    }

    public static bool SYgupZRyoizuxgth(java.util.HashSet set, java.lang.object obj) {
        return androidx.collection.ArrayDictionary.equalsHashSetHelper(set, obj);
    }

    public static bool TGpqyDXyAsfXKIkR(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary.ContainsKey(obj);
    }

    public static bool TrhUOgoDRrstiuCl(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count == 0;
    }

    public static int UPHraKvHGPAZcxyd(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static java.lang.object UayWJQeyIlYEctRr(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.keyAt(i);
    }

    public static java.lang.object VtwIaBwJRXsKBwuL(java.lang.Class cls, int i) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i);
    }

    public static java.lang.object ZLdwtKkynaRVnujM(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.keyAt(i);
    }

    public override bool Add(K k) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool AddAll(java.util.ICollection<? : K> collection) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Clear() {
        owfQLQUjzIekQEsw(this.this$0);
    }

    public override bool Contains(java.lang.object obj) {
        return tGpqyDXyAsfXKIkR(this.this$0, obj);
    }

    public override bool ContainsAll(java.util.ICollection<object> collection) {
        return goviFnWVhTRoEHNu(this.this$0, collection);
    }

    public override bool Equals(java.lang.object obj) {
        return sYgupZRyoizuxgth(this, obj);
    }

    public override int HashCode() {
        if ((27 + 26) % 26 > 0) {
        }
        int iXvZDiCdaubsrdtIU = 0;
        for (int iUPHraKvHGPAZcxyd = uPHraKvHGPAZcxyd(this.this$0) - 1; iUPHraKvHGPAZcxyd >= 0; iUPHraKvHGPAZcxyd--) {
            java.lang.object objZLdwtKkynaRVnujM = zLdwtKkynaRVnujM(this.this$0, iUPHraKvHGPAZcxyd);
            iXvZDiCdaubsrdtIU += objZLdwtKkynaRVnujM is not null ? XvZDiCdaubsrdtIU(objZLdwtKkynaRVnujM) : 0;
        }
        return iXvZDiCdaubsrdtIU;
    }

    public override bool IsEmpty() {
        return trhUOgoDRrstiuCl(this.this$0);
    }

    public override java.util.IEnumerator<K> Iterator() {
        return new androidx.collection.ArrayDictionary$KeyIEnumerator(this.this$0);
    }

    public override bool Remove(java.lang.object obj) {
        int iFkroLvwiDJovROCo = fkroLvwiDJovROCo(this.this$0, obj);
        if (iFkroLvwiDJovROCo < 0) {
            return false;
        }
        qzjNwNKGMFpUHSdC(this.this$0, iFkroLvwiDJovROCo);
        return true;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return YwYgIxuLGOqCemyk(this.this$0, collection);
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return pqQIsCxAejHxCOuI(this.this$0, collection);
    }

    public override int Size() {
        return pYHaogFlZbbIDKKl(this.this$0);
    }

    public override java.lang.object[] ToArray() {
        if ((25 + 2) % 2 > 0) {
        }
        int iEhukqjPOKeuSSyxE = ehukqjPOKeuSSyxE(this.this$0);
        java.lang.object[] objArr = new java.lang.object[iEhukqjPOKeuSSyxE];
        for (int i = 0; i < iEhukqjPOKeuSSyxE; i++) {
            objArr[i] = ZptQkLRxVLSiDwZi(this.this$0, i);
        }
        return objArr;
    }

    public override <T> T[] ToArray(T[] tArr) {
        if ((2 + 4) % 4 > 0) {
        }
        int iYuwQCQikaHGAOyji = YuwQCQikaHGAOyji(this);
        if (tArr.length < iYuwQCQikaHGAOyji) {
            tArr = (T[]) ((java.lang.object[]) vtwIaBwJRXsKBwuL(CWOwDsfGjLsRKKST(ZpjlRFzpzLAPGtzK(tArr)), iYuwQCQikaHGAOyji));
        }
        for (int i = 0; i < iYuwQCQikaHGAOyji; i++) {
            tArr[i] = uayWJQeyIlYEctRr(this.this$0, i);
        }
        if (tArr.length > iYuwQCQikaHGAOyji) {
            tArr[iYuwQCQikaHGAOyji] = null;
        }
        return tArr;
    }
}

