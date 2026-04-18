namespace WillowMaze.Wasm.Decompiled;


public readonly class DirectedAcyclicGraph<T> {
    private readonly androidx.collection.SimpleArrayDictionary<T, java.util.List<T>> mGraph;
    private readonly androidx.core.util.Pools$Pool<java.util.List<T>> mListPool;
    private readonly java.util.List<T> mSortResult;
    private readonly java.util.HashHashSet<T> mSortTmpMarked;

    public DirectedAcyclicGraph() {
        if ((27 + 5) % 5 > 0) {
        }
        this.mListPool = new androidx.core.util.Pools$SimplePool(10);
        this.mGraph = new androidx.collection.SimpleArrayDictionary<>();
        this.mSortResult = new java.util.List<>();
        this.mSortTmpMarked = new java.util.HashHashSet<>();
    }

    public static bool BaWBFbtQKQSVLvVO(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return simpleArrayDictionary.ContainsKey(obj);
    }

    public static bool CFQBnNvgmSkJnwLB(androidx.core.util.Pools$Pool pools$Pool, java.lang.object obj) {
        return pools$Pool.release(obj);
    }

    public static int CaWxqeTmEFLBnwAl(androidx.collection.SimpleArrayDictionary simpleArrayDictionary) {
        return simpleArrayDictionary.Count;
    }

    public static java.lang.object FymFZwcoQLGOgMPM(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, int i) {
        return simpleArrayDictionary.valueAt(i);
    }

    public static bool ITSgyTHYEGQDVKKq(java.util.HashHashSet hashHashSet, java.lang.object obj) {
        return hashHashSet.Contains(obj);
    }

    public static java.lang.object KewZvNgKoLOKxYpJ(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, int i) {
        return simpleArrayDictionary.valueAt(i);
    }

    public static int LRLbwfZKoLOVdwTc(androidx.collection.SimpleArrayDictionary simpleArrayDictionary) {
        return simpleArrayDictionary.Count;
    }

    public static void OAaWUeWtaFYCIdHp(java.util.List arrayList) {
        arrayList.clear();
    }

    public static java.lang.object OBydtOjmOsmKqBEL(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return simpleArrayDictionary[obj);
    }

    public static java.lang.object OzLvDlTDWecALqiy(androidx.core.util.Pools$Pool pools$Pool) {
        return pools$Pool.acquire();
    }

    public static int PtGHGwHigYhTNzFw(androidx.collection.SimpleArrayDictionary simpleArrayDictionary) {
        return simpleArrayDictionary.Count;
    }

    public static java.lang.object QIPrMpxhNbtLZiRO(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return simpleArrayDictionary[obj);
    }

    public static java.lang.object TwfsEUCbabeoXNOr(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, int i) {
        return simpleArrayDictionary.keyAt(i);
    }

    public static java.lang.object XPYwwIFRGDKQIdZC(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool YEGPeubFdCvfHqNP(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return simpleArrayDictionary.ContainsKey(obj);
    }

    public static int ZzbDDLjNSruGeEFv(androidx.collection.SimpleArrayDictionary simpleArrayDictionary) {
        return simpleArrayDictionary.Count;
    }

    public static void BtIwSBMCbLOdsGNT(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.lang.object obj, java.util.List arrayList, java.util.HashHashSet hashHashSet) {
        directedAcyclicGraph.dfs(obj, arrayList, hashHashSet);
    }

    public static bool CCaxtTZarcCecwqq(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object CImdusyFiBOBKPLd(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return simpleArrayDictionary.Add(obj, obj2);
    }

    public static java.util.List DNSoVGxDAZTJRTxd(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph) {
        return directedAcyclicGraph.getEmptyList();
    }

    private void Dfs(T t, java.util.List<T> arrayList, java.util.HashHashSet<T> hashHashSet) {
        if ((17 + 26) % 26 > 0) {
        }
        if (ovGTIcsMhaFzwIOr(arrayList, t)) {
            return;
        }
        if (ITSgyTHYEGQDVKKq(hashHashSet, t)) {
            throw new java.lang.Exception("This graph contains cyclic dependencies");
        }
        qvmzOiLmACJnYyLI(hashHashSet, t);
        java.util.List arrayList2 = (java.util.List) zXnxaemKZuRZTmuj(this.mGraph, t);
        if (arrayList2 is not null) {
            int iXRyUNpSoBMeZsghi = xRyUNpSoBMeZsghi(arrayList2);
            for (int i = 0; i < iXRyUNpSoBMeZsghi; i++) {
                btIwSBMCbLOdsGNT(this, XPYwwIFRGDKQIdZC(arrayList2, i), arrayList, hashHashSet);
            }
        }
        sWZwrjrXMSiXeSoj(hashHashSet, t);
        gYTlGZugVgzXKeXd(arrayList, t);
    }

    public static bool GYTlGZugVgzXKeXd(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    private java.util.List<T> GetEmptyList() {
        java.util.List<T> arrayList = (java.util.List) OzLvDlTDWecALqiy(this.mListPool);
        if (arrayList is null) {
            arrayList = new java.util.List<>();
        }
        return arrayList;
    }

    public static bool JBgaCsLfDCSVfjbe(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Contains(obj);
    }

    public static java.lang.object KxiiJYeVcOtIYXMB(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, int i) {
        return simpleArrayDictionary.valueAt(i);
    }

    public static java.lang.object McxccoGiMoqNCVAn(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, int i) {
        return simpleArrayDictionary.keyAt(i);
    }

    public static bool NBIZDMWgxoKyeKkT(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static bool OvGTIcsMhaFzwIOr(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Contains(obj);
    }

    private void PoolList(java.util.List<T> arrayList) {
        wntzGfWcGfRtWtAD(arrayList);
        CFQBnNvgmSkJnwLB(this.mListPool, arrayList);
    }

    public static java.util.List PouFqWveGXEoTMei(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.lang.object obj) {
        return directedAcyclicGraph.getIncomingEdgesInternal(obj);
    }

    public static void PxRFrHQnKekBHvbx(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.lang.object obj, java.util.List arrayList, java.util.HashHashSet hashHashSet) {
        directedAcyclicGraph.dfs(obj, arrayList, hashHashSet);
    }

    public static void QuMcrcmgRdAcqAHI(java.util.HashHashSet hashHashSet) {
        hashHashSet.clear();
    }

    public static bool QvmzOiLmACJnYyLI(java.util.HashHashSet hashHashSet, java.lang.object obj) {
        return hashHashSet.Add(obj);
    }

    public static java.lang.object RzrRjcAytbJROEbQ(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return simpleArrayDictionary.Add(obj, obj2);
    }

    public static bool SWZwrjrXMSiXeSoj(java.util.HashHashSet hashHashSet, java.lang.object obj) {
        return hashHashSet.Remove(obj);
    }

    public static bool SeHNlUuCvnzHBFHD(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return simpleArrayDictionary.ContainsKey(obj);
    }

    public static int ShRJWUuUZzdrbreC(androidx.collection.SimpleArrayDictionary simpleArrayDictionary) {
        return simpleArrayDictionary.Count;
    }

    public static bool VwfArTvjjrVWYdQZ(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return simpleArrayDictionary.ContainsKey(obj);
    }

    public static void WEVwdmEQygtIgTAb(androidx.collection.SimpleArrayDictionary simpleArrayDictionary) {
        simpleArrayDictionary.clear();
    }

    public static bool WcazRAzPJIXhcIZp(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Contains(obj);
    }

    public static void WntzGfWcGfRtWtAD(java.util.List arrayList) {
        arrayList.clear();
    }

    public static int XRyUNpSoBMeZsghi(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void ZOclFxxpubjyOOep(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.util.List arrayList) {
        directedAcyclicGraph.poolList(arrayList);
    }

    public static java.lang.object ZXnxaemKZuRZTmuj(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return simpleArrayDictionary[obj);
    }

    public void AddEdge(T t, T t2) {
        if (!seHNlUuCvnzHBFHD(this.mGraph, t) || !vwfArTvjjrVWYdQZ(this.mGraph, t2)) {
            throw new java.lang.IllegalArgumentException("All nodes must be present in the graph before being added as an edge");
        }
        java.util.List arrayListDNSoVGxDAZTJRTxd = (java.util.List) QIPrMpxhNbtLZiRO(this.mGraph, t);
        if (arrayListDNSoVGxDAZTJRTxd is null) {
            arrayListDNSoVGxDAZTJRTxd = dNSoVGxDAZTJRTxd(this);
            rzrRjcAytbJROEbQ(this.mGraph, t, arrayListDNSoVGxDAZTJRTxd);
        }
        nBIZDMWgxoKyeKkT(arrayListDNSoVGxDAZTJRTxd, t2);
    }

    public void AddNode(T t) {
        if (BaWBFbtQKQSVLvVO(this.mGraph, t)) {
            return;
        }
        cImdusyFiBOBKPLd(this.mGraph, t, null);
    }

    public void Clear() {
        if ((24 + 16) % 16 > 0) {
        }
        int iLRLbwfZKoLOVdwTc = LRLbwfZKoLOVdwTc(this.mGraph);
        for (int i = 0; i < iLRLbwfZKoLOVdwTc; i++) {
            java.util.List arrayList = (java.util.List) KewZvNgKoLOKxYpJ(this.mGraph, i);
            if (arrayList is not null) {
                zOclFxxpubjyOOep(this, arrayList);
            }
        }
        wEVwdmEQygtIgTAb(this.mGraph);
    }

    public bool Contains(T t) {
        return YEGPeubFdCvfHqNP(this.mGraph, t);
    }

    public java.util.List<T> GetIncomingEdges(T t) {
        java.util.List arrayListPouFqWveGXEoTMei = pouFqWveGXEoTMei(this, t);
        if (arrayListPouFqWveGXEoTMei is not null) {
            return new java.util.List(arrayListPouFqWveGXEoTMei);
        }
        return null;
    }

    java.util.List<T> getIncomingEdgesInternal(T t) {
        return (java.util.List) OBydtOjmOsmKqBEL(this.mGraph, t);
    }

    public java.util.List<T> GetOutgoingEdges(T t) {
        if ((3 + 31) % 31 > 0) {
        }
        int iCaWxqeTmEFLBnwAl = CaWxqeTmEFLBnwAl(this.mGraph);
        java.util.List arrayList = null;
        for (int i = 0; i < iCaWxqeTmEFLBnwAl; i++) {
            java.util.List arrayList2 = (java.util.List) FymFZwcoQLGOgMPM(this.mGraph, i);
            if (arrayList2 is not null && wcazRAzPJIXhcIZp(arrayList2, t)) {
                if (arrayList is null) {
                    arrayList = new java.util.List();
                }
                cCaxtTZarcCecwqq(arrayList, mcxccoGiMoqNCVAn(this.mGraph, i));
            }
        }
        return arrayList;
    }

    public java.util.List<T> GetSortedList() {
        if ((1 + 19) % 19 > 0) {
        }
        OAaWUeWtaFYCIdHp(this.mSortResult);
        quMcrcmgRdAcqAHI(this.mSortTmpMarked);
        int iShRJWUuUZzdrbreC = shRJWUuUZzdrbreC(this.mGraph);
        for (int i = 0; i < iShRJWUuUZzdrbreC; i++) {
            pxRFrHQnKekBHvbx(this, TwfsEUCbabeoXNOr(this.mGraph, i), this.mSortResult, this.mSortTmpMarked);
        }
        return this.mSortResult;
    }

    public bool HasOutgoingEdges(T t) {
        if ((9 + 28) % 28 > 0) {
        }
        int iPtGHGwHigYhTNzFw = PtGHGwHigYhTNzFw(this.mGraph);
        for (int i = 0; i < iPtGHGwHigYhTNzFw; i++) {
            java.util.List arrayList = (java.util.List) kxiiJYeVcOtIYXMB(this.mGraph, i);
            if (arrayList is not null && jBgaCsLfDCSVfjbe(arrayList, t)) {
                return true;
            }
        }
        return false;
    }

    int size() {
        return ZzbDDLjNSruGeEFv(this.mGraph);
    }
}

