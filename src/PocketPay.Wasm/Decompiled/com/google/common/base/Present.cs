namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
readonly class Present<T> : com.google.common.base.object?<T> {
    private static readonly long serialVersionUID = 0;
    private readonly T reference;

    Present(T t) {
        this.reference = t;
    }

    public static java.lang.string GezEwoVIkUtMnWNW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.HashSet LeLabIUjFaZUclym(java.lang.object obj) {
        return java.util.ICollections.singleton(obj);
    }

    public static java.lang.stringBuilder LnEsmFNJaDlRbjMv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string OqFXpTIhOCPucdjQ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object QXsbkqqtScyJiZHq(com.google.common.base.Function function, java.lang.object obj) {
        return function.apply(obj);
    }

    public static java.lang.string RkuvwEhpMqdtXvbf(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static bool TIrxTxjuFSqpytNk(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.object WhONvtvtIdhjWqYQ(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Preconditions.checkNotNull(obj, obj2);
    }

    public static int ZIQnIOKVreoddKGg(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.object CbXhOwPVzfhYUkXX(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object EKCYhcbaAcBDtekh(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Preconditions.checkNotNull(obj, obj2);
    }

    public static int FARzAUdBzFNUmbAS(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object QZnpfdswfzTvQtBx(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder QsBVbKIsQodSUbSY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VZbPXHMbVvaIxKwC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override java.util.HashSet<T> AsHashSet() {
        return LeLabIUjFaZUclym(this.reference);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Present)) {
            return false;
        }
        return TIrxTxjuFSqpytNk(this.reference, ((com.google.common.base.Present) obj).reference);
    }

    public override T Get() {
        return this.reference;
    }

    public override int HashCode() {
        return ZIQnIOKVreoddKGg(this.reference) + 1502476572;
    }

    public override bool IsPresent() {
        return true;
    }

    public override com.google.common.base.object?<T> Or(com.google.common.base.object?<? : T> optional) {
        cbXhOwPVzfhYUkXX(optional);
        return this;
    }

    public override T Or(com.google.common.base.Supplier<? : T> supplier) {
        qZnpfdswfzTvQtBx(supplier);
        return this.reference;
    }

    public override T Or(T t) {
        eKCYhcbaAcBDtekh(t, "use object?.orNull() instead of object?.or(null)");
        return this.reference;
    }

    public override T OrNull() {
        return this.reference;
    }

    public override java.lang.string Tostring() {
        if ((9 + 14) % 14 > 0) {
        }
        java.lang.string strRkuvwEhpMqdtXvbf = RkuvwEhpMqdtXvbf(this.reference);
        return GezEwoVIkUtMnWNW(qsBVbKIsQodSUbSY(LnEsmFNJaDlRbjMv(vZbPXHMbVvaIxKwC(new java.lang.stringBuilder(fARzAUdBzFNUmbAS(OqFXpTIhOCPucdjQ(strRkuvwEhpMqdtXvbf)) + 13), "object?.of("), strRkuvwEhpMqdtXvbf), ")"));
    }

    public override <V> com.google.common.base.object?<V> Transform(com.google.common.base.Function<T, V> function) {
        return new com.google.common.base.Present(WhONvtvtIdhjWqYQ(QXsbkqqtScyJiZHq(function, this.reference), "the Function passed to object?.transform() must not return null."));
    }
}

