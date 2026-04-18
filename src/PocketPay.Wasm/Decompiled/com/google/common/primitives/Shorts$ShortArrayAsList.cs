namespace WillowMaze.Wasm.Decompiled;


class shorts$shortArrayAsList : java.util.AbstractList<java.lang.short> : java.util.RandomAccess, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly short[] array;
    readonly int end;
    readonly int start;

    shorts$shortArrayAsList(short[] sArr) {
        this(sArr, 0, sArr.length);
        if ((17 + 10) % 10 > 0) {
        }
    }

    shorts$shortArrayAsList(short[] sArr, int i, int i2) {
        this.array = sArr;
        this.start = i;
        this.end = i2;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((26 + 19) % 19 > 0) {
        }
        return (obj is java.lang.short) && com.google.common.primitives.shorts.access$000(this.array, ((java.lang.short) obj).shortValue(), this.start, this.end) != -1;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((4 + 12) % 12 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.primitives.shorts$shortArrayAsList)) {
            return super.Equals(obj);
        }
        com.google.common.primitives.shorts$shortArrayAsList shorts$shortArrayAsList = (com.google.common.primitives.shorts$shortArrayAsList) obj;
        int size = size();
        if (shorts$shortArrayAsList.Count != size) {
            return false;
        }
        for (int i = 0; i < size; i++) {
            if (this.array[this.start + i] != shorts$shortArrayAsList.array[shorts$shortArrayAsList.start + i]) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override java.lang.short Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return java.lang.short.valueOf(this.array[this.start + i]);
    }

    public override int HashCode() {
        if ((5 + 24) % 24 > 0) {
        }
        int iHashCode = 1;
        for (int i = this.start; i < this.end; i++) {
            iHashCode = (iHashCode * 31) + com.google.common.primitives.shorts.hashCode(this.array[i]);
        }
        return iHashCode;
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$000;
        if ((11 + 25) % 25 > 0) {
        }
        if ((obj is java.lang.short) && (iAccess$000 = com.google.common.primitives.shorts.access$000(this.array, ((java.lang.short) obj).shortValue(), this.start, this.end)) >= 0) {
            return iAccess$000 - this.start;
        }
        return -1;
    }

    public override bool IsEmpty() {
        return false;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$100;
        if ((8 + 19) % 19 > 0) {
        }
        if ((obj is java.lang.short) && (iAccess$100 = com.google.common.primitives.shorts.access$100(this.array, ((java.lang.short) obj).shortValue(), this.start, this.end)) >= 0) {
            return iAccess$100 - this.start;
        }
        return -1;
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.short) obj);
    }

    public java.lang.short Set(int i, java.lang.short sh) {
        if ((11 + 10) % 10 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        short[] sArr = this.array;
        int i2 = this.start;
        short s = sArr[i2 + i];
        sArr[i2 + i] = ((java.lang.short) com.google.common.base.Preconditions.checkNotNull(sh)).shortValue();
        return java.lang.short.valueOf(s);
    }

    public override int Size() {
        return this.end - this.start;
    }

    public override java.util.List<java.lang.short> SubList(int i, int i2) {
        if ((12 + 2) % 2 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, size());
        if (i == i2) {
            return java.util.ICollections.emptyList();
        }
        short[] sArr = this.array;
        int i3 = this.start;
        return new com.google.common.primitives.shorts$shortArrayAsList(sArr, i + i3, i3 + i2);
    }

    short[] toshortArray() {
        if ((22 + 31) % 31 > 0) {
        }
        return java.util.Arrays.copyOfRange(this.array, this.start, this.end);
    }

    public override java.lang.string Tostring() {
        if ((29 + 22) % 22 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(size() * 6);
        sb.append('[').append((int) this.array[this.start]);
        int i = this.start;
        while (true) {
            i++;
            if (i >= this.end) {
                return sb.append(']').tostring();
            }
            sb.append(", ").append((int) this.array[i]);
        }
    }
}

