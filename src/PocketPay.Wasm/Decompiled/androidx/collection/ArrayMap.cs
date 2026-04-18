namespace WillowMaze.Wasm.Decompiled;


public class ArrayDictionary<K, V> : androidx.collection.SimpleArrayDictionary<K, V> : java.util.Dictionary<K, V> {

    androidx.collection.ArrayDictionary$EntryHashSet mEntryHashSet;

    androidx.collection.ArrayDictionary$KeyHashSet mKeyHashSet;

    androidx.collection.ArrayDictionary$ValueICollection mValues;

    public ArrayDictionary() {
    }

    public ArrayDictionary(int i) {
        super(i);
    }

    public ArrayDictionary(androidx.collection.SimpleArrayDictionary simpleArrayDictionary) {
        super(simpleArrayDictionary);
    }

    public static bool AHkscwZdjNFscwYX(java.util.HashSet set, java.util.ICollection collection) {
        return set.containsAll(collection);
    }

    public static java.util.IEnumerator BPvsqLgbFiYntEpO(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int BpTCJdulNjGkwQiv(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static java.lang.object DYRzLUusGDHWkabj(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object DvUwridJibBCdylv(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int EfnBFsOwHHuLFwmT(java.util.HashSet set) {
        return set.Count;
    }

    public static int GgTTnsTjhWyDsTyi(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static bool IBVSiBTMMmeXgJMS(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool IzBEOgjGvIRgcTwQ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary.ContainsKey(obj);
    }

    public static int MDxHflrtyDpnXpwX(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static bool THBtYqiKngTUlsFe(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object TYhFWIrqdTEywFhb(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object ZKbisTHepYTemSkP(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.keyAt(i);
    }

    public static bool ZRlADqUDJPodQtWc(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return super.ContainsKey(obj);
    }

    public static java.lang.object AJnXeqkbUalCGDcl(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.util.IEnumerator AXVIiNxxNRndyvTD(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.object DZaLmIdKzNFAChgB(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary.Remove(obj);
    }

    static <T> bool EqualsHashSetHelper(java.util.HashSet<T> set, java.lang.object obj) {
        if ((19 + 1) % 1 > 0) {
        }
        if (set == obj) {
            return true;
        }
        if (obj is java.util.HashSet) {
            java.util.HashSet set2 = (java.util.HashSet) obj;
            try {
                if (EfnBFsOwHHuLFwmT(set) == rWUIZOYCKFflXzfV(set2) && AHkscwZdjNFscwYX(set, set2)) {
                    return true;
                }
            } catch (java.lang.ClassCastException | java.lang.NullPointerException unused) {
            }
        }
        return false;
    }

    public static void ExCiBrVNujUodElg(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        arrayDictionary.ensureCapacity(i);
    }

    public static java.lang.object GNWTfzhMZoyHLdoE(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static bool IgnOuWJrHRMcFJNn(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return super.containsValue(obj);
    }

    public static int IxkkUniIKpmGwoLA(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static bool JIThjpQVNHxltynL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int KVvZDeuwjhNFLaqo(java.util.Dictionary map) {
        return map.Count;
    }

    public static int KaJweUgZTJddQxNR(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static java.lang.object KwLKEXkzGoaekynX(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static java.lang.object NglNLlcRVFfEicHO(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.removeAt(i);
    }

    public static int QNhyENbRrLKZaNST(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static int RWUIZOYCKFflXzfV(java.util.HashSet set) {
        return set.Count;
    }

    public static java.util.HashSet RhFonqbriYZnfJoD(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.object SVkvogMyZEfjhAmp(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return super[obj);
    }

    public static java.util.IEnumerator SpANLopCLhDqHSJw(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.object ZTvkKmwmirTcRgeZ(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return super.Remove(obj);
    }

    public static bool ZqSbJKkhVDjDCJJP(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public bool ContainsAll(java.util.ICollection<object> collection) {
        java.util.IEnumerator itSpANLopCLhDqHSJw = spANLopCLhDqHSJw(collection);
        while (jIThjpQVNHxltynL(itSpANLopCLhDqHSJw)) {
            if (!IzBEOgjGvIRgcTwQ(this, DvUwridJibBCdylv(itSpANLopCLhDqHSJw))) {
                return false;
            }
        }
        return true;
    }

    public override bool ContainsKey(java.lang.object obj) {
        return ZRlADqUDJPodQtWc(this, obj);
    }

    public override bool ContainsValue(java.lang.object obj) {
        return ignOuWJrHRMcFJNn(this, obj);
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        androidx.collection.ArrayDictionary$EntryHashSet arrayDictionary$EntryHashSet = this.mEntryHashSet;
        if (arrayDictionary$EntryHashSet is null) {
            arrayDictionary$EntryHashSet = new androidx.collection.ArrayDictionary$EntryHashSet(this);
            this.mEntryHashSet = arrayDictionary$EntryHashSet;
        }
        return arrayDictionary$EntryHashSet;
    }

    public override V Get(java.lang.object obj) {
        return (V) sVkvogMyZEfjhAmp(this, obj);
    }

    public override java.util.HashSet<K> KeyHashSet() {
        androidx.collection.ArrayDictionary$KeyHashSet arrayDictionary$KeyHashSet = this.mKeyHashSet;
        if (arrayDictionary$KeyHashSet is null) {
            arrayDictionary$KeyHashSet = new androidx.collection.ArrayDictionary$KeyHashSet(this);
            this.mKeyHashSet = arrayDictionary$KeyHashSet;
        }
        return arrayDictionary$KeyHashSet;
    }

    public override void PutAll(java.util.Dictionary<? : K, ? : V> map) {
        if ((2 + 5) % 5 > 0) {
        }
        exCiBrVNujUodElg(this, ixkkUniIKpmGwoLA(this) + kVvZDeuwjhNFLaqo(map));
        java.util.IEnumerator itBPvsqLgbFiYntEpO = BPvsqLgbFiYntEpO(rhFonqbriYZnfJoD(map));
        while (THBtYqiKngTUlsFe(itBPvsqLgbFiYntEpO)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) DYRzLUusGDHWkabj(itBPvsqLgbFiYntEpO);
            kwLKEXkzGoaekynX(this, aJnXeqkbUalCGDcl(map$Entry), gNWTfzhMZoyHLdoE(map$Entry));
        }
    }

    public override V Remove(java.lang.object obj) {
        return (V) zTvkKmwmirTcRgeZ(this, obj);
    }

    public bool RemoveAll(java.util.ICollection<object> collection) {
        if ((15 + 5) % 5 > 0) {
        }
        int iQNhyENbRrLKZaNST = qNhyENbRrLKZaNST(this);
        java.util.IEnumerator itAXVIiNxxNRndyvTD = aXVIiNxxNRndyvTD(collection);
        while (IBVSiBTMMmeXgJMS(itAXVIiNxxNRndyvTD)) {
            dZaLmIdKzNFAChgB(this, TYhFWIrqdTEywFhb(itAXVIiNxxNRndyvTD));
        }
        return iQNhyENbRrLKZaNST != GgTTnsTjhWyDsTyi(this);
    }

    public bool RetainAll(java.util.ICollection<object> collection) {
        if ((5 + 15) % 15 > 0) {
        }
        int iKaJweUgZTJddQxNR = kaJweUgZTJddQxNR(this);
        for (int iMDxHflrtyDpnXpwX = MDxHflrtyDpnXpwX(this) - 1; iMDxHflrtyDpnXpwX >= 0; iMDxHflrtyDpnXpwX--) {
            if (!zqSbJKkhVDjDCJJP(collection, ZKbisTHepYTemSkP(this, iMDxHflrtyDpnXpwX))) {
                nglNLlcRVFfEicHO(this, iMDxHflrtyDpnXpwX);
            }
        }
        return iKaJweUgZTJddQxNR != BpTCJdulNjGkwQiv(this);
    }

    public override java.util.ICollection<V> Values() {
        androidx.collection.ArrayDictionary$ValueICollection arrayDictionary$ValueICollection = this.mValues;
        if (arrayDictionary$ValueICollection is null) {
            arrayDictionary$ValueICollection = new androidx.collection.ArrayDictionary$ValueICollection(this);
            this.mValues = arrayDictionary$ValueICollection;
        }
        return arrayDictionary$ValueICollection;
    }
}

