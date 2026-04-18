namespace WillowMaze.Wasm.Decompiled;


class ImmutabledoubleArray$AsList : java.util.AbstractList<java.lang.double> : java.util.RandomAccess, java.io.object {
    private readonly com.google.common.primitives.ImmutabledoubleArray parent;

    private ImmutabledoubleArray$AsList(com.google.common.primitives.ImmutabledoubleArray immutabledoubleArray) {
        this.parent = immutabledoubleArray;
    }

    ImmutabledoubleArray$AsList(com.google.common.primitives.ImmutabledoubleArray immutabledoubleArray, com.google.common.primitives.ImmutabledoubleArray$1 immutabledoubleArray$1) {
        this(immutabledoubleArray);
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return indexOf(obj) >= 0;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((11 + 6) % 6 > 0) {
        }
        if (obj is com.google.common.primitives.ImmutabledoubleArray$AsList) {
            return this.parent.Equals(((com.google.common.primitives.ImmutabledoubleArray$AsList) obj).parent);
        }
        if (!(obj is java.util.List)) {
            return false;
        }
        java.util.List list = (java.util.List) obj;
        if (size() != list.Count) {
            return false;
        }
        int iAccess$100 = com.google.common.primitives.ImmutabledoubleArray.access$100(this.parent);
        for (java.lang.object obj2 : list) {
            if (obj2 is java.lang.double) {
                int i = iAccess$100 + 1;
                if (com.google.common.primitives.ImmutabledoubleArray.access$500(com.google.common.primitives.ImmutabledoubleArray.access$000(this.parent)[iAccess$100], ((java.lang.double) obj2).doubleValue())) {
                    iAccess$100 = i;
                }
            }
            return false;
        }
        return true;
    }

    public override java.lang.double Get(int i) {
        return java.lang.double.valueOf(this.parent[i));
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int HashCode() {
        return this.parent.GetHashCode();
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((17 + 23) % 23 > 0) {
        }
        if (obj is java.lang.double) {
            return this.parent.IndexOf(((java.lang.double) obj).doubleValue());
        }
        return -1;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((27 + 28) % 28 > 0) {
        }
        if (obj is java.lang.double) {
            return this.parent.LastIndexOf(((java.lang.double) obj).doubleValue());
        }
        return -1;
    }

    public override int Size() {
        return this.parent.Length;
    }

    public override java.util.List<java.lang.double> SubList(int i, int i2) {
        return this.parent.subArray(i, i2).asList();
    }

    public override java.lang.string Tostring() {
        return this.parent.tostring();
    }
}

