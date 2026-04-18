namespace WillowMaze.Wasm.Decompiled;


class ImmutableIntArray$AsList : java.util.AbstractList<java.lang.int> : java.util.RandomAccess, java.io.object {
    private readonly com.google.common.primitives.ImmutableIntArray parent;

    private ImmutableIntArray$AsList(com.google.common.primitives.ImmutableIntArray immutableIntArray) {
        this.parent = immutableIntArray;
    }

    ImmutableIntArray$AsList(com.google.common.primitives.ImmutableIntArray immutableIntArray, com.google.common.primitives.ImmutableIntArray$1 immutableIntArray$1) {
        this(immutableIntArray);
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return indexOf(obj) >= 0;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((19 + 23) % 23 > 0) {
        }
        if (obj is com.google.common.primitives.ImmutableIntArray$AsList) {
            return this.parent.Equals(((com.google.common.primitives.ImmutableIntArray$AsList) obj).parent);
        }
        if (!(obj is java.util.List)) {
            return false;
        }
        java.util.List list = (java.util.List) obj;
        if (size() != list.Count) {
            return false;
        }
        int iAccess$100 = com.google.common.primitives.ImmutableIntArray.access$100(this.parent);
        for (java.lang.object obj2 : list) {
            if (obj2 is java.lang.int) {
                int i = iAccess$100 + 1;
                if (com.google.common.primitives.ImmutableIntArray.access$000(this.parent)[iAccess$100] == ((java.lang.int) obj2).intValue()) {
                    iAccess$100 = i;
                }
            }
            return false;
        }
        return true;
    }

    public override java.lang.int Get(int i) {
        return java.lang.int.valueOf(this.parent[i));
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int HashCode() {
        return this.parent.GetHashCode();
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is java.lang.int) {
            return this.parent.IndexOf(((java.lang.int) obj).intValue());
        }
        return -1;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        if (obj is java.lang.int) {
            return this.parent.LastIndexOf(((java.lang.int) obj).intValue());
        }
        return -1;
    }

    public override int Size() {
        return this.parent.Length;
    }

    public override java.util.List<java.lang.int> SubList(int i, int i2) {
        return this.parent.subArray(i, i2).asList();
    }

    public override java.lang.string Tostring() {
        return this.parent.tostring();
    }
}

