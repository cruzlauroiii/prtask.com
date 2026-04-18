namespace WillowMaze.Wasm.Decompiled;


public readonly class p710ac38f<T> : io.reactivex.rxjava3.functions.Function<java.util.List<T>, java.util.List<T>> {
    readonly java.util.Comparator<T> f4092f21b;
    readonly java.util.Comparator fe3303150;

    public p710ac38f(java.util.Comparator<T> comparator) {
        this.f4092f21b = comparator;
    }

    public static java.util.List ISRgmLSxqEjQpjtx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p710ac38f p710ac38fVar, java.util.List list) {
        return p710ac38fVar.apply(list);
    }

    public static void PjkSQCRPcwGIYrWG(java.util.List list, java.util.Comparator comparator) {
        java.util.ICollections.sort(list, comparator);
    }

    public java.lang.object Apply(java.lang.object obj) throws java.lang.Exception {
        return iSRgmLSxqEjQpjtx(this, (java.util.List) obj);
    }

    public java.util.List<T> Apply(java.util.List<T> list) {
        pjkSQCRPcwGIYrWG(list, this.f4092f21b);
        return list;
    }
}

