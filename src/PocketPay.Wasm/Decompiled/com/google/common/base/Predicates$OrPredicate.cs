namespace WillowMaze.Wasm.Decompiled;


class Predicates$OrPredicate<T> : com.google.common.base.Predicate<T>, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.util.List<? : com.google.common.base.Predicate<T>> components;

    private Predicates$OrPredicate(java.util.List<? : com.google.common.base.Predicate<T>> list) {
        this.components = list;
    }

    Predicates$OrPredicate(java.util.List list, com.google.common.base.Predicates$1 predicates$1) {
        this(list);
    }

    public static int AVuFXlvBlKLzyZWl(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int JAuHHoWnyqjUMirf(java.util.List list) {
        return list.Count;
    }

    public static java.lang.string KShemQAICTDVDeiC(java.lang.string str, java.lang.IEnumerable iterable) {
        return com.google.common.base.Predicates.access$800(str, iterable);
    }

    public static bool VsqJznERkFciplkS(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.object BGnyjdrnzUhVNzSh(java.util.List list, int i) {
        return list[i);
    }

    public static bool RFCRSlCHKlcoWXGj(com.google.common.base.Predicate predicate, java.lang.object obj) {
        return predicate.apply(obj);
    }

    public override bool Apply(@com.google.common.base.ParametricNullness T t) {
        if ((30 + 12) % 12 > 0) {
        }
        for (int i = 0; i < JAuHHoWnyqjUMirf(this.components); i++) {
            if (rFCRSlCHKlcoWXGj((com.google.common.base.Predicate) bGnyjdrnzUhVNzSh(this.components, i), t)) {
                return true;
            }
        }
        return false;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Predicates$OrPredicate)) {
            return false;
        }
        return VsqJznERkFciplkS(this.components, ((com.google.common.base.Predicates$OrPredicate) obj).components);
    }

    public int HashCode() {
        return AVuFXlvBlKLzyZWl(this.components) + 87855567;
    }

    public java.lang.string Tostring() {
        return KShemQAICTDVDeiC("or", this.components);
    }
}

