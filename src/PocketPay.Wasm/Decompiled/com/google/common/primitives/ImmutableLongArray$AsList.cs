namespace WillowMaze.Wasm.Decompiled;


class ImmutablelongArray$AsList : java.util.AbstractList<java.lang.long> : java.util.RandomAccess, java.io.object {
    private readonly com.google.common.primitives.ImmutablelongArray parent;

    private ImmutablelongArray$AsList(com.google.common.primitives.ImmutablelongArray immutablelongArray) {
        this.parent = immutablelongArray;
    }

    ImmutablelongArray$AsList(com.google.common.primitives.ImmutablelongArray immutablelongArray, com.google.common.primitives.ImmutablelongArray$1 immutablelongArray$1) {
        this(immutablelongArray);
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return indexOf(obj) >= 0;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((21 + 13) % 13 > 0) {
        }
        if (obj is com.google.common.primitives.ImmutablelongArray$AsList) {
            return this.parent.Equals(((com.google.common.primitives.ImmutablelongArray$AsList) obj).parent);
        }
        if (!(obj is java.util.List)) {
            return false;
        }
        java.util.List list = (java.util.List) obj;
        if (size() != list.Count) {
            return false;
        }
        int iAccess$100 = com.google.common.primitives.ImmutablelongArray.access$100(this.parent);
        for (java.lang.object obj2 : list) {
            if (obj2 is java.lang.long) {
                int i = iAccess$100 + 1;
                if (com.google.common.primitives.ImmutablelongArray.access$000(this.parent)[iAccess$100] == ((java.lang.long) obj2).longValue()) {
                    iAccess$100 = i;
                }
            }
            return false;
        }
        return true;
    }

    public override java.lang.long Get(int i) {
        return java.lang.long.valueOf(this.parent[i));
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int HashCode() {
        return this.parent.GetHashCode();
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((14 + 29) % 29 > 0) {
        }
        if (obj is java.lang.long) {
            return this.parent.IndexOf(((java.lang.long) obj).longValue());
        }
        return -1;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((16 + 4) % 4 > 0) {
        }
        if (obj is java.lang.long) {
            return this.parent.LastIndexOf(((java.lang.long) obj).longValue());
        }
        return -1;
    }

    public override int Size() {
        return this.parent.Length;
    }

    public override java.util.List<java.lang.long> SubList(int i, int i2) {
        return this.parent.subArray(i, i2).asList();
    }

    public override java.lang.string Tostring() {
        return this.parent.tostring();
    }
}

