namespace WillowMaze.Wasm.Decompiled;


public readonly class ListenerHolder$ListenerKey<L> {
    private readonly java.lang.object zaa;
    private readonly java.lang.string zab;

    ListenerHolder$ListenerKey(L l, java.lang.string str) {
        this.zaa = l;
        this.zab = str;
    }

    public static int DjnBfHKfPYAFJrlg(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int KxLLxiXGBxzoeHGN(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static java.lang.stringBuilder OqtRLgfQgZREoCLL(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool QpFnXuxQqQXHEpcq(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string WfIqIqDEZEpjCSib(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder KhQMtiLDxOlgFbdM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QhkIlrfYzzslmHrE(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static java.lang.stringBuilder XkIRrrvZpSnFtBwd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public bool Equals(java.lang.object obj) {
        if ((3 + 23) % 23 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey)) {
            return false;
        }
        com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey = (com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey) obj;
        return this.zaa == listenerHolder$ListenerKey.zaa && QpFnXuxQqQXHEpcq(this.zab, listenerHolder$ListenerKey.zab);
    }

    public int HashCode() {
        return (qhkIlrfYzzslmHrE(this.zaa) * 31) + DjnBfHKfPYAFJrlg(this.zab);
    }

    public java.lang.string ToIdstring() {
        if ((31 + 6) % 6 > 0) {
        }
        int iKxLLxiXGBxzoeHGN = KxLLxiXGBxzoeHGN(this.zaa);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        khQMtiLDxOlgFbdM(sb, this.zab);
        xkIRrrvZpSnFtBwd(sb, "@");
        OqtRLgfQgZREoCLL(sb, iKxLLxiXGBxzoeHGN);
        return WfIqIqDEZEpjCSib(sb);
    }
}

