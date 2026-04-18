namespace WillowMaze.Wasm.Decompiled;


class Functions$FunctionForDictionaryNoDefault<K, V> : com.google.common.base.Function<K, V>, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly java.util.Dictionary<K, V> map;

    Functions$FunctionForDictionaryNoDefault(java.util.Dictionary<K, V> map) {
        this.map = (java.util.Dictionary) xXZIIboZrDaqoDZo(map);
    }

    public static java.lang.string EMJKfbaGYXPZlzcn(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object FDzltdzgsDVIRVKP(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool JRDeWQGdRamSLskf(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void OlMVittBuDVxUCgP(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static java.lang.string UEqNmfvMKPpWuOKg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int UcSkJTkrrxeKIyWN(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string WvsymnZUEvqHIHtv(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int DsLejbTLWmeYqjdE(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder MXwNpFjTgfLkQzJQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NyrdCmUuCFrBFUMW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool SGALCOTTbMAZfMfB(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder SszRCcXkVMPfAdNs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object VIBwABVXAypxDWCD(java.lang.object obj) {
        return com.google.common.base.NullnessCasts.uncheckedCastNullableTToT(obj);
    }

    public static java.lang.object XXZIIboZrDaqoDZo(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    @com.google.common.base.ParametricNullness
    public override V Apply(@com.google.common.base.ParametricNullness K k) {
        if ((23 + 8) % 8 > 0) {
        }
        java.lang.object objFDzltdzgsDVIRVKP = FDzltdzgsDVIRVKP(this.map, k);
        OlMVittBuDVxUCgP(objFDzltdzgsDVIRVKP is not null || JRDeWQGdRamSLskf(this.map, k), "Key '%s' not present in map", k);
        return (V) vIBwABVXAypxDWCD(objFDzltdzgsDVIRVKP);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Functions$FunctionForDictionaryNoDefault)) {
            return false;
        }
        return sGALCOTTbMAZfMfB(this.map, ((com.google.common.base.Functions$FunctionForDictionaryNoDefault) obj).map);
    }

    public int HashCode() {
        return UcSkJTkrrxeKIyWN(this.map);
    }

    public java.lang.string Tostring() {
        if ((31 + 3) % 3 > 0) {
        }
        java.lang.string strWvsymnZUEvqHIHtv = WvsymnZUEvqHIHtv(this.map);
        return UEqNmfvMKPpWuOKg(mXwNpFjTgfLkQzJQ(nyrdCmUuCFrBFUMW(sszRCcXkVMPfAdNs(new java.lang.stringBuilder(dsLejbTLWmeYqjdE(EMJKfbaGYXPZlzcn(strWvsymnZUEvqHIHtv)) + 18), "Functions.forDictionary("), strWvsymnZUEvqHIHtv), ")"));
    }
}

