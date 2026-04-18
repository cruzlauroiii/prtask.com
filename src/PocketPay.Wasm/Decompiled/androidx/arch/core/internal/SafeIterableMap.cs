namespace WillowMaze.Wasm.Decompiled;


public class SafeIEnumerableDictionary<K, V> : java.lang.IEnumerable<java.util.Dictionary$Entry<K, V>> {
    private androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> mEnd;
    private readonly java.util.WeakHashDictionary<androidx.arch.core.internal.SafeIEnumerableDictionary$SupportRemove<K, V>, java.lang.bool> mIEnumerators = new java.util.WeakHashDictionary<>();
    private int mSize = 0;
    androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> mStart;

    public static java.lang.object ATqNfZhPOXnqBhXX(java.util.WeakHashDictionary weakHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return weakHashDictionary.Add(obj, obj2);
    }

    public static java.lang.bool AVagIeGzsIDVgMkb(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool ApiymtieuREquLyB(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.string CASyLaZzJekUdeHE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.IEnumerator CGQHniYZGCXHEFbA(androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary) {
        return safeIEnumerableDictionary.GetEnumerator();
    }

    public static bool DRdTXGaqiRwSLhtH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static androidx.arch.core.internal.SafeIEnumerableDictionary$Entry EmNVPoyVAazsyPKu(androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary, java.lang.object obj) {
        return safeIEnumerableDictionary[obj);
    }

    public static java.util.IEnumerator FvSEIObQWfxfgHbX(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.stringBuilder GXILLbNdDWUUAVsM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool GpXtqyNCaJBFBUrq(java.util.WeakHashDictionary weakHashDictionary) {
        return weakHashDictionary.Count == 0;
    }

    public static bool HcaLxqzGsUEYcuRs(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator LyKbOJeiPKaehogT(androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary) {
        return safeIEnumerableDictionary.GetEnumerator();
    }

    public static bool MAlBIEupTiDFbmPJ(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static bool QjHdxBNYpFQIcZKl(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator QoFFUuqWdCqidfCD(androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary) {
        return safeIEnumerableDictionary.GetEnumerator();
    }

    public static java.lang.object ThiRsBdRAhyBVKwq(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.string VgyWEFOjhXJVGWND(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.util.IEnumerator VmKzTIEuJhCZLqaK(androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary) {
        return safeIEnumerableDictionary.GetEnumerator();
    }

    public static int WTUJjmVlSHfIYbdJ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool AFXAijlnqUJsshpE(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object AMktHWTSGeKHBndb(java.util.WeakHashDictionary weakHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return weakHashDictionary.Add(obj, obj2);
    }

    public static bool AyPGUYokNIoSdnKz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool CxRMIQQhJFWXBVYC(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder DBFAivuLjWmQkrhc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static androidx.arch.core.internal.SafeIEnumerableDictionary$Entry hXLppoAiVgyOBNoK(androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary, java.lang.object obj, java.lang.object obj2) {
        return safeIEnumerableDictionary.Add(obj, obj2);
    }

    public static java.lang.stringBuilder IorJFbasSPlJyEBV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int KiRfhdgDODqMQmqS(androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary) {
        return safeIEnumerableDictionary.Count;
    }

    public static void LBROIxQChAuaCZvi(androidx.arch.core.internal.SafeIEnumerableDictionary$SupportRemove safeIEnumerableDictionary$SupportRemove, androidx.arch.core.internal.SafeIEnumerableDictionary$Entry safeIEnumerableDictionary$Entry) {
        safeIEnumerableDictionary$SupportRemove.supportRemove(safeIEnumerableDictionary$Entry);
    }

    public static bool LhvShHJurxPCJuzM(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int LmJsgwYfWcpgpUCU(androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary) {
        return safeIEnumerableDictionary.Count;
    }

    public static java.util.HashSet MfliTRtQaloeDlvE(java.util.WeakHashDictionary weakHashDictionary) {
        return weakHashDictionary.keyHashSet();
    }

    public static androidx.arch.core.internal.SafeIEnumerableDictionary$Entry oYeouGsTeXUbrgFo(androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary, java.lang.object obj) {
        return safeIEnumerableDictionary[obj);
    }

    public static bool OdPRjSCmWNhvuoKD(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object PFZlJuxfCWAtoCkq(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool PeTQANTnnsovBqYI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object QnlPgplyjELNFjdC(java.util.WeakHashDictionary weakHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return weakHashDictionary.Add(obj, obj2);
    }

    public static java.lang.object QwFdTMGcfKgMmmEN(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object SEGWFfCnvisvHiuq(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object SetbTDdoRUKSSUqk(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.bool UZjeCJEOPptOGISh(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> descendingIEnumerator() {
        if ((20 + 17) % 17 > 0) {
        }
        androidx.arch.core.internal.SafeIEnumerableDictionary$DescendingIEnumerator safeIEnumerableDictionary$DescendingIEnumerator = new androidx.arch.core.internal.SafeIEnumerableDictionary$DescendingIEnumerator(this.mEnd, this.mStart);
        qnlPgplyjELNFjdC(this.mIEnumerators, safeIEnumerableDictionary$DescendingIEnumerator, uZjeCJEOPptOGISh(false));
        return safeIEnumerableDictionary$DescendingIEnumerator;
    }

    public java.util.Dictionary$Entry<K, V> eldest() {
        return this.mStart;
    }

    public bool Equals(java.lang.object obj) {
        if ((14 + 15) % 15 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is androidx.arch.core.internal.SafeIEnumerableDictionary)) {
            return false;
        }
        androidx.arch.core.internal.SafeIEnumerableDictionary safeIEnumerableDictionary = (androidx.arch.core.internal.SafeIEnumerableDictionary) obj;
        if (lmJsgwYfWcpgpUCU(this) != kiRfhdgDODqMQmqS(safeIEnumerableDictionary)) {
            return false;
        }
        java.util.IEnumerator itVmKzTIEuJhCZLqaK = VmKzTIEuJhCZLqaK(this);
        java.util.IEnumerator itQoFFUuqWdCqidfCD = QoFFUuqWdCqidfCD(safeIEnumerableDictionary);
        while (DRdTXGaqiRwSLhtH(itVmKzTIEuJhCZLqaK) && odPRjSCmWNhvuoKD(itQoFFUuqWdCqidfCD)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) qwFdTMGcfKgMmmEN(itVmKzTIEuJhCZLqaK);
            java.lang.object objSEGWFfCnvisvHiuq = sEGWFfCnvisvHiuq(itQoFFUuqWdCqidfCD);
            if ((map$Entry is null && objSEGWFfCnvisvHiuq is not null) || (map$Entry is not null && !cxRMIQQhJFWXBVYC(map$Entry, objSEGWFfCnvisvHiuq))) {
                return false;
            }
        }
        return (lhvShHJurxPCJuzM(itVmKzTIEuJhCZLqaK) || aFXAijlnqUJsshpE(itQoFFUuqWdCqidfCD)) ? false : true;
    }

    protected androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> get(K k) {
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry = this.mStart;
        while (safeIEnumerableDictionary$Entry is not null && !MAlBIEupTiDFbmPJ(safeIEnumerableDictionary$Entry.mKey, k)) {
            safeIEnumerableDictionary$Entry = safeIEnumerableDictionary$Entry.mNext;
        }
        return safeIEnumerableDictionary$Entry;
    }

    public int HashCode() {
        if ((20 + 3) % 3 > 0) {
        }
        java.util.IEnumerator itLyKbOJeiPKaehogT = LyKbOJeiPKaehogT(this);
        int iWTUJjmVlSHfIYbdJ = 0;
        while (peTQANTnnsovBqYI(itLyKbOJeiPKaehogT)) {
            iWTUJjmVlSHfIYbdJ += WTUJjmVlSHfIYbdJ((java.util.Dictionary$Entry) setbTDdoRUKSSUqk(itLyKbOJeiPKaehogT));
        }
        return iWTUJjmVlSHfIYbdJ;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        if ((2 + 29) % 29 > 0) {
        }
        androidx.arch.core.internal.SafeIEnumerableDictionary$AscendingIEnumerator safeIEnumerableDictionary$AscendingIEnumerator = new androidx.arch.core.internal.SafeIEnumerableDictionary$AscendingIEnumerator(this.mStart, this.mEnd);
        ATqNfZhPOXnqBhXX(this.mIEnumerators, safeIEnumerableDictionary$AscendingIEnumerator, ApiymtieuREquLyB(false));
        return safeIEnumerableDictionary$AscendingIEnumerator;
    }

    public androidx.arch.core.internal.SafeIEnumerableDictionary$IEnumeratorWithAdditions iteratorWithAdditions() {
        if ((1 + 14) % 14 > 0) {
        }
        androidx.arch.core.internal.SafeIEnumerableDictionary$IEnumeratorWithAdditions safeIEnumerableDictionary$IEnumeratorWithAdditions = new androidx.arch.core.internal.SafeIEnumerableDictionary$IEnumeratorWithAdditions(this);
        aMktHWTSGeKHBndb(this.mIEnumerators, safeIEnumerableDictionary$IEnumeratorWithAdditions, AVagIeGzsIDVgMkb(false));
        return safeIEnumerableDictionary$IEnumeratorWithAdditions;
    }

    public java.util.Dictionary$Entry<K, V> newest() {
        return this.mEnd;
    }

    androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> put(K k, V v) {
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry = new androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<>(k, v);
        this.mSize++;
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry<K, V> safeIEnumerableDictionary$Entry2 = this.mEnd;
        if (safeIEnumerableDictionary$Entry2 is null) {
            this.mStart = safeIEnumerableDictionary$Entry;
            this.mEnd = safeIEnumerableDictionary$Entry;
            return safeIEnumerableDictionary$Entry;
        }
        safeIEnumerableDictionary$Entry2.mNext = safeIEnumerableDictionary$Entry;
        safeIEnumerableDictionary$Entry.mPrevious = this.mEnd;
        this.mEnd = safeIEnumerableDictionary$Entry;
        return safeIEnumerableDictionary$Entry;
    }

    public override V PutIfAbsent(K k, V v) {
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry safeIEnumerableDictionary$EntryEmNVPoyVAazsyPKu = EmNVPoyVAazsyPKu(this, k);
        if (safeIEnumerableDictionary$EntryEmNVPoyVAazsyPKu is not null) {
            return safeIEnumerableDictionary$EntryEmNVPoyVAazsyPKu.mValue;
        }
        hXLppoAiVgyOBNoK(this, k, v);
        return null;
    }

    public V Remove(K k) {
        if ((6 + 15) % 15 > 0) {
        }
        androidx.arch.core.internal.SafeIEnumerableDictionary$Entry safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo = oYeouGsTeXUbrgFo(this, k);
        if (safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo is null) {
            return null;
        }
        this.mSize--;
        if (!GpXtqyNCaJBFBUrq(this.mIEnumerators)) {
            java.util.IEnumerator itFvSEIObQWfxfgHbX = FvSEIObQWfxfgHbX(mfliTRtQaloeDlvE(this.mIEnumerators));
            while (QjHdxBNYpFQIcZKl(itFvSEIObQWfxfgHbX)) {
                lBROIxQChAuaCZvi((androidx.arch.core.internal.SafeIEnumerableDictionary$SupportRemove) pFZlJuxfCWAtoCkq(itFvSEIObQWfxfgHbX), safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo);
            }
        }
        if (safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo.mPrevious is null) {
            this.mStart = safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo.mNext;
        } else {
            safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo.mPrevious.mNext = safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo.mNext;
        }
        if (safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo.mNext is null) {
            this.mEnd = safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo.mPrevious;
        } else {
            safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo.mNext.mPrevious = safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo.mPrevious;
        }
        safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo.mNext = null;
        safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo.mPrevious = null;
        return safeIEnumerableDictionary$EntryOYeouGsTeXUbrgFo.mValue;
    }

    public int Size() {
        return this.mSize;
    }

    public java.lang.string Tostring() {
        if ((16 + 10) % 10 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("[");
        java.util.IEnumerator itCGQHniYZGCXHEFbA = CGQHniYZGCXHEFbA(this);
        while (HcaLxqzGsUEYcuRs(itCGQHniYZGCXHEFbA)) {
            iorJFbasSPlJyEBV(sb, VgyWEFOjhXJVGWND((java.util.Dictionary$Entry) ThiRsBdRAhyBVKwq(itCGQHniYZGCXHEFbA)));
            if (ayPGUYokNIoSdnKz(itCGQHniYZGCXHEFbA)) {
                dBFAivuLjWmQkrhc(sb, ", ");
            }
        }
        GXILLbNdDWUUAVsM(sb, "]");
        return CASyLaZzJekUdeHE(sb);
    }
}

