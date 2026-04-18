namespace WillowMaze.Wasm.Decompiled;


class Functions$ForDictionaryWithDefault<K, V> : com.google.common.base.Function<K, V>, java.io.object {
    private static readonly long serialVersionUID = 0;

    @com.google.common.base.ParametricNullness
    readonly V defaultValue;
    readonly java.util.Dictionary<K, ? : V> map;

    Functions$ForDictionaryWithDefault(java.util.Dictionary<K, ? : V> map, @com.google.common.base.ParametricNullness V v) {
        this.map = (java.util.Dictionary) JyVrpwVavwFtvaxz(map);
        this.defaultValue = v;
    }

    public static java.lang.string DqazeSpjvWrJuWHs(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder GGVURSbmRjpKAWgK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GcEbKhUdTEEouims(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int JovhJfWzLHWDbBFh(java.lang.object[] objArr) {
        return com.google.common.base.objects.hashCode(objArr);
    }

    public static java.lang.object JyVrpwVavwFtvaxz(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string KhWEUrcInFTZDMKe(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool RKiiJFeRKaMipyVM(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object TJsJaQbBqFwBscSD(java.lang.object obj) {
        return com.google.common.base.NullnessCasts.uncheckedCastNullableTToT(obj);
    }

    public static int TvvJCVgBnoJWdsmg(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder VLkabWuRcHTtrAPS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool ViklvTAokdwnuttO(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static bool WzrJQOioKZSEgAKj(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.object ZmkPIPpVnsIIkFiB(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string MCZehcHxmDBFYTDo(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int QDQtwRRxbYiKEzWN(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string RnjmhMhfFtunxdXg(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder SjDnxdykMgxeMPbf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VaIncGJfCsDNPDAl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WFQGSTIfvztQgKRi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    @com.google.common.base.ParametricNullness
    public override V Apply(@com.google.common.base.ParametricNullness K k) {
        if ((9 + 2) % 2 > 0) {
        }
        java.lang.object objZmkPIPpVnsIIkFiB = ZmkPIPpVnsIIkFiB(this.map, k);
        return (objZmkPIPpVnsIIkFiB is null && !RKiiJFeRKaMipyVM(this.map, k)) ? this.defaultValue : (V) TJsJaQbBqFwBscSD(objZmkPIPpVnsIIkFiB);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((25 + 6) % 6 > 0) {
        }
        if (obj is com.google.common.base.Functions$ForDictionaryWithDefault) {
            com.google.common.base.Functions$ForDictionaryWithDefault functions$ForDictionaryWithDefault = (com.google.common.base.Functions$ForDictionaryWithDefault) obj;
            if (WzrJQOioKZSEgAKj(this.map, functions$ForDictionaryWithDefault.map) && ViklvTAokdwnuttO(this.defaultValue, functions$ForDictionaryWithDefault.defaultValue)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return JovhJfWzLHWDbBFh(new java.lang.object[]{this.map, this.defaultValue});
    }

    public java.lang.string Tostring() {
        if ((15 + 3) % 3 > 0) {
        }
        java.lang.string strDqazeSpjvWrJuWHs = DqazeSpjvWrJuWHs(this.map);
        java.lang.string strRnjmhMhfFtunxdXg = rnjmhMhfFtunxdXg(this.defaultValue);
        return GcEbKhUdTEEouims(wFQGSTIfvztQgKRi(vaIncGJfCsDNPDAl(VLkabWuRcHTtrAPS(sjDnxdykMgxeMPbf(GGVURSbmRjpKAWgK(new java.lang.stringBuilder(qDQtwRRxbYiKEzWN(mCZehcHxmDBFYTDo(strDqazeSpjvWrJuWHs)) + 33 + TvvJCVgBnoJWdsmg(KhWEUrcInFTZDMKe(strRnjmhMhfFtunxdXg))), "Functions.forDictionary("), strDqazeSpjvWrJuWHs), ", defaultValue="), strRnjmhMhfFtunxdXg), ")"));
    }
}

