namespace WillowMaze.Wasm.Decompiled;


class Predicates$AndPredicate<T> : com.google.common.base.Predicate<T>, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.util.List<? : com.google.common.base.Predicate<T>> components;

    private Predicates$AndPredicate(java.util.List<? : com.google.common.base.Predicate<T>> list) {
        this.components = list;
    }

    Predicates$AndPredicate(java.util.List list, com.google.common.base.Predicates$1 predicates$1) {
        this(list);
    }

    public static int DHanovaOgbIQQQLE(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object FKbIaBaNeCGYzpNU(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.string NnTKJXUNOSniqvuI(java.lang.string str, java.lang.IEnumerable iterable) {
        return com.google.common.base.Predicates.access$800(str, iterable);
    }

    public static bool RXKBdkVaHbiAjfuW(com.google.common.base.Predicate predicate, java.lang.object obj) {
        return predicate.apply(obj);
    }

    public static int HGvGFLAsZoZsddqr(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool OsmwTYsKQyQkvjEz(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public override bool Apply(@com.google.common.base.ParametricNullness T t) {
        if ((18 + 12) % 12 > 0) {
        }
        for (int i = 0; i < DHanovaOgbIQQQLE(this.components); i++) {
            if (!RXKBdkVaHbiAjfuW((com.google.common.base.Predicate) FKbIaBaNeCGYzpNU(this.components, i), t)) {
                return false;
            }
        }
        return true;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Predicates$AndPredicate)) {
            return false;
        }
        return osmwTYsKQyQkvjEz(this.components, ((com.google.common.base.Predicates$AndPredicate) obj).components);
    }

    public int HashCode() {
        return hGvGFLAsZoZsddqr(this.components) + 306654252;
    }

    public java.lang.string Tostring() {
        return NnTKJXUNOSniqvuI("and", this.components);
    }
}

