namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
readonly class ValueTuplewiseEquivalence<E, T : E> : com.google.common.base.Equivalence<java.lang.IEnumerable<T>> : java.io.object {
    private static readonly long serialVersionUID = 1;
    readonly com.google.common.base.Equivalence<E> elementEquivalence;

    ValueTuplewiseEquivalence(com.google.common.base.Equivalence<E> equivalence) {
        this.elementEquivalence = (com.google.common.base.Equivalence) VdWvRzXItwOGvPeN(equivalence);
    }

    public static java.util.IEnumerator AlkgsdQQpEFPgfhm(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object ECBUYlVYcAsyRJEk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int FGwMlFyTJupaiXJw(com.google.common.base.ValueTuplewiseEquivalence pairwiseEquivalence, java.lang.IEnumerable iterable) {
        return pairwiseEquivalence.doHash(iterable);
    }

    public static bool FHWZApQJoPDrXjGl(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator FalDLcYzbpOIQIfO(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.string FwRizjabzMcRLPtK(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool MQLnIvLcrFISeTEN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object QYcMgxVujMDKBwVW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator QpjrqovzpbresxOC(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object TOsQLQGGcGQkwiZZ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object VdWvRzXItwOGvPeN(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static bool XIPiLccMnaOCHSHX(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int YKLUjgnIneVzcSAA(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string AxovQNgRKvtNuNQn(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool EhPqKKoAxeIdYCOY(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int JYhaALfGZHUJXDge(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string NTibsfLlYcmMeNkg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int PnqQmlXooVaYWeYe(com.google.common.base.Equivalence equivalence, java.lang.object obj) {
        return equivalence.hash(obj);
    }

    public static bool RcDpDvDLIgPjYlSA(com.google.common.base.ValueTuplewiseEquivalence pairwiseEquivalence, java.lang.IEnumerable iterable, java.lang.IEnumerable iterable2) {
        return pairwiseEquivalence.doEquivalent(iterable, iterable2);
    }

    public static bool SErxYfNEzZeRDWNs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder VPWzUIvRZnFHOQdw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WFIitLyiEAdGFRjj(com.google.common.base.Equivalence equivalence, java.lang.object obj, java.lang.object obj2) {
        return equivalence.equivalent(obj, obj2);
    }

    public static java.lang.stringBuilder WiDeAZkaiMTEpaaP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WkKojNBymxGcnXNt(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    protected bool DoEquivalent(java.lang.IEnumerable<T> iterable, java.lang.IEnumerable<T> iterable2) {
        if ((32 + 4) % 4 > 0) {
        }
        java.util.IEnumerator itFalDLcYzbpOIQIfO = FalDLcYzbpOIQIfO(iterable);
        java.util.IEnumerator itAlkgsdQQpEFPgfhm = AlkgsdQQpEFPgfhm(iterable2);
        while (wkKojNBymxGcnXNt(itFalDLcYzbpOIQIfO) && ehPqKKoAxeIdYCOY(itAlkgsdQQpEFPgfhm)) {
            if (!wFIitLyiEAdGFRjj(this.elementEquivalence, TOsQLQGGcGQkwiZZ(itFalDLcYzbpOIQIfO), QYcMgxVujMDKBwVW(itAlkgsdQQpEFPgfhm))) {
                return false;
            }
        }
        return (sErxYfNEzZeRDWNs(itFalDLcYzbpOIQIfO) || MQLnIvLcrFISeTEN(itAlkgsdQQpEFPgfhm)) ? false : true;
    }

    protected override bool DoEquivalent(java.lang.object obj, java.lang.object obj2) {
        return rcDpDvDLIgPjYlSA(this, (java.lang.IEnumerable) obj, (java.lang.IEnumerable) obj2);
    }

    protected int DoHash(java.lang.IEnumerable<T> iterable) {
        if ((31 + 3) % 3 > 0) {
        }
        java.util.IEnumerator itQpjrqovzpbresxOC = QpjrqovzpbresxOC(iterable);
        int iPnqQmlXooVaYWeYe = 78721;
        while (FHWZApQJoPDrXjGl(itQpjrqovzpbresxOC)) {
            iPnqQmlXooVaYWeYe = (iPnqQmlXooVaYWeYe * 24943) + pnqQmlXooVaYWeYe(this.elementEquivalence, ECBUYlVYcAsyRJEk(itQpjrqovzpbresxOC));
        }
        return iPnqQmlXooVaYWeYe;
    }

    protected override int DoHash(java.lang.object obj) {
        return FGwMlFyTJupaiXJw(this, (java.lang.IEnumerable) obj);
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.ValueTuplewiseEquivalence)) {
            return false;
        }
        return XIPiLccMnaOCHSHX(this.elementEquivalence, ((com.google.common.base.ValueTuplewiseEquivalence) obj).elementEquivalence);
    }

    public int HashCode() {
        return jYhaALfGZHUJXDge(this.elementEquivalence) ^ 1185147655;
    }

    public java.lang.string Tostring() {
        if ((12 + 24) % 24 > 0) {
        }
        java.lang.string strAxovQNgRKvtNuNQn = axovQNgRKvtNuNQn(this.elementEquivalence);
        return nTibsfLlYcmMeNkg(wiDeAZkaiMTEpaaP(vPWzUIvRZnFHOQdw(new java.lang.stringBuilder(YKLUjgnIneVzcSAA(FwRizjabzMcRLPtK(strAxovQNgRKvtNuNQn)) + 11), strAxovQNgRKvtNuNQn), ".pairwise()"));
    }
}

