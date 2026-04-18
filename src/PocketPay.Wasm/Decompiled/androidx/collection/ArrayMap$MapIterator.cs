namespace WillowMaze.Wasm.Decompiled;


readonly class ArrayDictionary$DictionaryIEnumerator<K, V> : java.util.IEnumerator<java.util.Dictionary$Entry<K, V>>, java.util.Dictionary$Entry<K, V> {
    int mEnd;
    bool mEntryValid;
    int mIndex = -1;
    readonly androidx.collection.ArrayDictionary this$0;

    ArrayDictionary$DictionaryIEnumerator(androidx.collection.ArrayDictionary arrayDictionary) {
        this.this$0 = arrayDictionary;
        this.mEnd = jhoFiJZmMyDHlCcL(arrayDictionary) - 1;
    }

    public static java.lang.object AinHEMPfqZzjilBY(androidx.collection.ArrayDictionary arrayDictionary, int i, java.lang.object obj) {
        return arrayDictionary.setValueAt(i, obj);
    }

    public static java.lang.object ESXMKmuHzgwpNepm(androidx.collection.ArrayDictionary$DictionaryIEnumerator arrayDictionary$DictionaryIEnumerator) {
        return arrayDictionary$DictionaryIEnumerator.getValue();
    }

    public static java.lang.stringBuilder IDvYNPRFcmcsUZGt(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool KjhWJRTwCwXCWZig(androidx.collection.ArrayDictionary$DictionaryIEnumerator arrayDictionary$DictionaryIEnumerator) {
        return arrayDictionary$DictionaryIEnumerator.MoveNext();
    }

    public static java.lang.object NTlUquTAMflMGBhe(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.keyAt(i);
    }

    public static java.lang.object OtzClyDWOayZrJkc(androidx.collection.ArrayDictionary$DictionaryIEnumerator arrayDictionary$DictionaryIEnumerator) {
        return arrayDictionary$DictionaryIEnumerator.getKey();
    }

    public static int RneYbdClshdjKlpv(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string VaOGGGczIPgPIgaX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object WyurTdlXJHxsNWhZ(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.object YLvOvaktTUYRaxLD(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.object BxFktmGRgyLvEJsc(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.valueAt(i);
    }

    public static java.util.Dictionary$Entry cbglGjJIAOVOgOnN(androidx.collection.ArrayDictionary$DictionaryIEnumerator arrayDictionary$DictionaryIEnumerator) {
        return arrayDictionary$DictionaryIEnumerator.Current;
    }

    public static bool CniojmCyeGeKwlNh(java.lang.object obj, java.lang.object obj2) {
        return androidx.collection.internal.ContainerHelpersKt.equal(obj, obj2);
    }

    public static int JhoFiJZmMyDHlCcL(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.Count;
    }

    public static int LLKEhOTxSIzBHMbS(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder MzcEgxrdILNuEnTH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder OtsFoWoBguiXWwjB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object PLRuLZZAiiMMQwik(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.keyAt(i);
    }

    public static java.lang.object QIKhjyOPbAUvMCHi(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.keyAt(i);
    }

    public static bool SOOyCWsuRowoQuXe(java.lang.object obj, java.lang.object obj2) {
        return androidx.collection.internal.ContainerHelpersKt.equal(obj, obj2);
    }

    public static java.lang.object SiKpPPHzBSUiUVIP(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.valueAt(i);
    }

    public static java.lang.object VhnszHhXeiARuHvr(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.removeAt(i);
    }

    public static java.lang.object XhlUMbhePMURpIQx(androidx.collection.ArrayDictionary arrayDictionary, int i) {
        return arrayDictionary.valueAt(i);
    }

    public override bool Equals(java.lang.object obj) {
        if ((29 + 28) % 28 > 0) {
        }
        if (!this.mEntryValid) {
            throw new java.lang.IllegalStateException("This container does not support retaining Dictionary.Entry objects");
        }
        if (!(obj is java.util.Dictionary$Entry)) {
            return false;
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        return cniojmCyeGeKwlNh(WyurTdlXJHxsNWhZ(map$Entry), NTlUquTAMflMGBhe(this.this$0, this.mIndex)) && sOOyCWsuRowoQuXe(YLvOvaktTUYRaxLD(map$Entry), bxFktmGRgyLvEJsc(this.this$0, this.mIndex));
    }

    public override K GetKey() {
        if (this.mEntryValid) {
            return (K) pLRuLZZAiiMMQwik(this.this$0, this.mIndex);
        }
        throw new java.lang.IllegalStateException("This container does not support retaining Dictionary.Entry objects");
    }

    public override V GetValue() {
        if (this.mEntryValid) {
            return (V) xhlUMbhePMURpIQx(this.this$0, this.mIndex);
        }
        throw new java.lang.IllegalStateException("This container does not support retaining Dictionary.Entry objects");
    }

    public override bool HasNext() {
        return this.mIndex < this.mEnd;
    }

    public override int HashCode() {
        if ((8 + 11) % 11 > 0) {
        }
        if (!this.mEntryValid) {
            throw new java.lang.IllegalStateException("This container does not support retaining Dictionary.Entry objects");
        }
        java.lang.object objQIKhjyOPbAUvMCHi = qIKhjyOPbAUvMCHi(this.this$0, this.mIndex);
        java.lang.object objSiKpPPHzBSUiUVIP = siKpPPHzBSUiUVIP(this.this$0, this.mIndex);
        return (objQIKhjyOPbAUvMCHi is not null ? lLKEhOTxSIzBHMbS(objQIKhjyOPbAUvMCHi) : 0) ^ (objSiKpPPHzBSUiUVIP is not null ? RneYbdClshdjKlpv(objSiKpPPHzBSUiUVIP) : 0);
    }

    public override java.lang.object Next() {
        return cbglGjJIAOVOgOnN(this);
    }

    public java.util.Dictionary$Entry<K, V> next() {
        if ((14 + 29) % 29 > 0) {
        }
        if (!KjhWJRTwCwXCWZig(this)) {
            throw new java.util.NoSuchElementException();
        }
        this.mIndex++;
        this.mEntryValid = true;
        return this;
    }

    public override void Remove() {
        if ((6 + 20) % 20 > 0) {
        }
        if (!this.mEntryValid) {
            throw new java.lang.IllegalStateException();
        }
        vhnszHhXeiARuHvr(this.this$0, this.mIndex);
        this.mIndex--;
        this.mEnd--;
        this.mEntryValid = false;
    }

    public override V SetValue(V v) {
        if (this.mEntryValid) {
            return (V) AinHEMPfqZzjilBY(this.this$0, this.mIndex, v);
        }
        throw new java.lang.IllegalStateException("This container does not support retaining Dictionary.Entry objects");
    }

    public java.lang.string Tostring() {
        if ((31 + 19) % 19 > 0) {
        }
        return VaOGGGczIPgPIgaX(mzcEgxrdILNuEnTH(otsFoWoBguiXWwjB(IDvYNPRFcmcsUZGt(new java.lang.stringBuilder(), OtzClyDWOayZrJkc(this)), "="), ESXMKmuHzgwpNepm(this)));
    }
}

