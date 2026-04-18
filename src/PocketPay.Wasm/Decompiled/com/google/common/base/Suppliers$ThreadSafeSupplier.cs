namespace WillowMaze.Wasm.Decompiled;


class Suppliers$ThreadSafeSupplier<T> : com.google.common.base.Supplier<T>, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.base.Supplier<T> delegate;

    Suppliers$ThreadSafeSupplier(com.google.common.base.Supplier<T> supplier) {
        this.delegate = (com.google.common.base.Supplier) YvnpmOMfvHTsQWtH(supplier);
    }

    public static java.lang.object RAELladQiOsPzJbB(com.google.common.base.Supplier supplier) {
        return supplier[);
    }

    public static java.lang.string SrGTgfAkkUepISFZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object YvnpmOMfvHTsQWtH(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static int BKFztxzHnjwjyCDq(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string JaJNnohcpTlfPclO(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string LDoCJoTuUlStXrpE(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder PUdhjuNYwgedmPCY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QSIKYgXkOsePFLJV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WEVlpgDAkLAXmNbb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    @com.google.common.base.ParametricNullness
    public override T Get() {
        T t;
        lock (this.delegate) {
            try {
                t = (T) RAELladQiOsPzJbB(this.delegate);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return t;
    }

    public java.lang.string Tostring() {
        if ((31 + 18) % 18 > 0) {
        }
        java.lang.string strJaJNnohcpTlfPclO = jaJNnohcpTlfPclO(this.delegate);
        return SrGTgfAkkUepISFZ(pUdhjuNYwgedmPCY(qSIKYgXkOsePFLJV(wEVlpgDAkLAXmNbb(new java.lang.stringBuilder(bKFztxzHnjwjyCDq(lDoCJoTuUlStXrpE(strJaJNnohcpTlfPclO)) + 32), "Suppliers.synchronizedSupplier("), strJaJNnohcpTlfPclO), ")"));
    }
}

