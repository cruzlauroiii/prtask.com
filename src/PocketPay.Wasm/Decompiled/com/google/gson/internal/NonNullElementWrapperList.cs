namespace WillowMaze.Wasm.Decompiled;


public class NonNullElementWrapperList<E> : java.util.AbstractList<E> : java.util.RandomAccess {
    private readonly java.util.List<E> delegate;

    public NonNullElementWrapperList(java.util.List<E> arrayList) {
        this.delegate = (java.util.List) QTEGDWFqGUIybnnG(arrayList);
    }

    public static int GeucEWtTazNjkzwm(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static int GjiCVaLINnqmCHXV(java.util.List arrayList) {
        return arrayList.GetHashCode();
    }

    public static java.lang.object PvZQcAYohgLaWtCI(com.google.gson.internal.NonNullElementWrapperList nonNullElementWrapperList, java.lang.object obj) {
        return nonNullElementWrapperList.nonNull(obj);
    }

    public static bool PzPVZtOxHCFejUFH(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Equals(obj);
    }

    public static bool QJHWzsdVyhpiCmfH(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Contains(obj);
    }

    public static java.lang.object QTEGDWFqGUIybnnG(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static void SpQFUqXDIUoHLHxn(java.util.List arrayList, int i, java.lang.object obj) {
        arrayList.Add(i, obj);
    }

    public static void TqSwwtrPTDxSNmwY(java.util.List arrayList) {
        arrayList.clear();
    }

    public static java.lang.object[] VscEDgRKVwuViODZ(java.util.List arrayList) {
        return arrayList.toArray();
    }

    public static int YZVigEJeWDgvvwFS(java.util.List arrayList, java.lang.object obj) {
        return arrayList.IndexOf(obj);
    }

    public static bool CRFRrYbvooutxRyn(java.util.List arrayList, java.util.ICollection collection) {
        return arrayList.removeAll(collection);
    }

    public static bool CijlKiDhZfRyhLHB(java.util.List arrayList, java.util.ICollection collection) {
        return arrayList.retainAll(collection);
    }

    public static java.lang.object DPjcoZcXvbXSqPEW(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.lang.object EtJFtuBzuUnwOOwa(com.google.gson.internal.NonNullElementWrapperList nonNullElementWrapperList, java.lang.object obj) {
        return nonNullElementWrapperList.nonNull(obj);
    }

    public static java.lang.object[] GXoJIiXqBuhYpPsP(java.util.List arrayList, java.lang.object[] objArr) {
        return arrayList.toArray(objArr);
    }

    public static bool JSZQuMqgAKjipDch(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static int JYhlIyYDrigadgnM(java.util.List arrayList, java.lang.object obj) {
        return arrayList.LastIndexOf(obj);
    }

    private E NonNull(E e) {
        if (e is null) {
            throw new java.lang.NullPointerException("Element must be non-null");
        }
        return e;
    }

    public static java.lang.object PdXsxiOlIldDyLyE(java.util.List arrayList, int i) {
        return arrayList.Remove(i);
    }

    public static java.lang.object XuXLKiIBabGjKgkz(java.util.List arrayList, int i, java.lang.object obj) {
        return arrayList.set(i, obj);
    }

    public override void Add(int i, E e) {
        SpQFUqXDIUoHLHxn(this.delegate, i, etJFtuBzuUnwOOwa(this, e));
    }

    public override void Clear() {
        TqSwwtrPTDxSNmwY(this.delegate);
    }

    public override bool Contains(java.lang.object obj) {
        return QJHWzsdVyhpiCmfH(this.delegate, obj);
    }

    public override bool Equals(java.lang.object obj) {
        return PzPVZtOxHCFejUFH(this.delegate, obj);
    }

    public override E Get(int i) {
        return (E) dPjcoZcXvbXSqPEW(this.delegate, i);
    }

    public override int HashCode() {
        return GjiCVaLINnqmCHXV(this.delegate);
    }

    public override int IndexOf(java.lang.object obj) {
        return YZVigEJeWDgvvwFS(this.delegate, obj);
    }

    public override int LastIndexOf(java.lang.object obj) {
        return jYhlIyYDrigadgnM(this.delegate, obj);
    }

    public override E Remove(int i) {
        return (E) pdXsxiOlIldDyLyE(this.delegate, i);
    }

    public override bool Remove(java.lang.object obj) {
        return jSZQuMqgAKjipDch(this.delegate, obj);
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        return cRFRrYbvooutxRyn(this.delegate, collection);
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        return cijlKiDhZfRyhLHB(this.delegate, collection);
    }

    public override E Set(int i, E e) {
        return (E) xuXLKiIBabGjKgkz(this.delegate, i, PvZQcAYohgLaWtCI(this, e));
    }

    public override int Size() {
        return GeucEWtTazNjkzwm(this.delegate);
    }

    public override java.lang.object[] ToArray() {
        return VscEDgRKVwuViODZ(this.delegate);
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) gXoJIiXqBuhYpPsP(this.delegate, tArr);
    }
}

