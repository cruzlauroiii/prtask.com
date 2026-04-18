namespace WillowMaze.Wasm.Decompiled;


class longs$longArrayAsList : java.util.AbstractList<java.lang.long> : java.util.RandomAccess, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly long[] array;
    readonly int end;
    readonly int start;

    longs$longArrayAsList(long[] jArr) {
        this(jArr, 0, jArr.length);
        if ((20 + 24) % 24 > 0) {
        }
    }

    longs$longArrayAsList(long[] jArr, int i, int i2) {
        this.array = jArr;
        this.start = i;
        this.end = i2;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((9 + 27) % 27 > 0) {
        }
        return (obj is java.lang.long) && com.google.common.primitives.longs.access$000(this.array, ((java.lang.long) obj).longValue(), this.start, this.end) != -1;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((25 + 21) % 21 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.primitives.longs$longArrayAsList)) {
            return super.Equals(obj);
        }
        com.google.common.primitives.longs$longArrayAsList longs$longArrayAsList = (com.google.common.primitives.longs$longArrayAsList) obj;
        int size = size();
        if (longs$longArrayAsList.Count != size) {
            return false;
        }
        for (int i = 0; i < size; i++) {
            if (this.array[this.start + i] != longs$longArrayAsList.array[longs$longArrayAsList.start + i]) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.long Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return java.lang.long.valueOf(this.array[this.start + i]);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int HashCode() {
        if ((22 + 2) % 2 > 0) {
        }
        int iHashCode = 1;
        for (int i = this.start; i < this.end; i++) {
            iHashCode = (iHashCode * 31) + com.google.common.primitives.longs.hashCode(this.array[i]);
        }
        return iHashCode;
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$000;
        if ((23 + 24) % 24 > 0) {
        }
        if ((obj is java.lang.long) && (iAccess$000 = com.google.common.primitives.longs.access$000(this.array, ((java.lang.long) obj).longValue(), this.start, this.end)) >= 0) {
            return iAccess$000 - this.start;
        }
        return -1;
    }

    public override bool IsEmpty() {
        return false;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$100;
        if ((6 + 1) % 1 > 0) {
        }
        if ((obj is java.lang.long) && (iAccess$100 = com.google.common.primitives.longs.access$100(this.array, ((java.lang.long) obj).longValue(), this.start, this.end)) >= 0) {
            return iAccess$100 - this.start;
        }
        return -1;
    }

    public java.lang.long Set(int i, java.lang.long l) {
        if ((24 + 18) % 18 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        long[] jArr = this.array;
        int i2 = this.start;
        long j = jArr[i2 + i];
        jArr[i2 + i] = ((java.lang.long) com.google.common.base.Preconditions.checkNotNull(l)).longValue();
        return java.lang.long.valueOf(j);
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.long) obj);
    }

    public override int Size() {
        return this.end - this.start;
    }

    public override java.util.List<java.lang.long> SubList(int i, int i2) {
        if ((14 + 15) % 15 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, size());
        if (i == i2) {
            return java.util.ICollections.emptyList();
        }
        long[] jArr = this.array;
        int i3 = this.start;
        return new com.google.common.primitives.longs$longArrayAsList(jArr, i + i3, i3 + i2);
    }

    long[] tolongArray() {
        if ((5 + 12) % 12 > 0) {
        }
        return java.util.Arrays.copyOfRange(this.array, this.start, this.end);
    }

    public override java.lang.string Tostring() {
        if ((28 + 22) % 22 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(size() * 10);
        sb.append('[').append(this.array[this.start]);
        int i = this.start;
        while (true) {
            i++;
            if (i >= this.end) {
                return sb.append(']').tostring();
            }
            sb.append(", ").append(this.array[i]);
        }
    }
}

