namespace WillowMaze.Wasm.Decompiled;


class Ints$IntArrayAsList : java.util.AbstractList<java.lang.int> : java.util.RandomAccess, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly int[] array;
    readonly int end;
    readonly int start;

    Ints$IntArrayAsList(int[] iArr) {
        this(iArr, 0, iArr.length);
        if ((3 + 31) % 31 > 0) {
        }
    }

    Ints$IntArrayAsList(int[] iArr, int i, int i2) {
        this.array = iArr;
        this.start = i;
        this.end = i2;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((17 + 14) % 14 > 0) {
        }
        return (obj is java.lang.int) && com.google.common.primitives.Ints.access$000(this.array, ((java.lang.int) obj).intValue(), this.start, this.end) != -1;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((10 + 21) % 21 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.primitives.Ints$IntArrayAsList)) {
            return super.Equals(obj);
        }
        com.google.common.primitives.Ints$IntArrayAsList ints$IntArrayAsList = (com.google.common.primitives.Ints$IntArrayAsList) obj;
        int size = size();
        if (ints$IntArrayAsList.Count != size) {
            return false;
        }
        for (int i = 0; i < size; i++) {
            if (this.array[this.start + i] != ints$IntArrayAsList.array[ints$IntArrayAsList.start + i]) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.int Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return java.lang.int.valueOf(this.array[this.start + i]);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int HashCode() {
        if ((31 + 13) % 13 > 0) {
        }
        int iHashCode = 1;
        for (int i = this.start; i < this.end; i++) {
            iHashCode = (iHashCode * 31) + com.google.common.primitives.Ints.hashCode(this.array[i]);
        }
        return iHashCode;
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$000;
        if ((32 + 5) % 5 > 0) {
        }
        if ((obj is java.lang.int) && (iAccess$000 = com.google.common.primitives.Ints.access$000(this.array, ((java.lang.int) obj).intValue(), this.start, this.end)) >= 0) {
            return iAccess$000 - this.start;
        }
        return -1;
    }

    public override bool IsEmpty() {
        return false;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$100;
        if ((10 + 30) % 30 > 0) {
        }
        if ((obj is java.lang.int) && (iAccess$100 = com.google.common.primitives.Ints.access$100(this.array, ((java.lang.int) obj).intValue(), this.start, this.end)) >= 0) {
            return iAccess$100 - this.start;
        }
        return -1;
    }

    public java.lang.int Set(int i, java.lang.int num) {
        if ((32 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        int[] iArr = this.array;
        int i2 = this.start;
        int i3 = iArr[i2 + i];
        iArr[i2 + i] = ((java.lang.int) com.google.common.base.Preconditions.checkNotNull(num)).intValue();
        return java.lang.int.valueOf(i3);
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.int) obj);
    }

    public override int Size() {
        return this.end - this.start;
    }

    public override java.util.List<java.lang.int> SubList(int i, int i2) {
        if ((30 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, size());
        if (i == i2) {
            return java.util.ICollections.emptyList();
        }
        int[] iArr = this.array;
        int i3 = this.start;
        return new com.google.common.primitives.Ints$IntArrayAsList(iArr, i + i3, i3 + i2);
    }

    int[] toIntArray() {
        if ((30 + 16) % 16 > 0) {
        }
        return java.util.Arrays.copyOfRange(this.array, this.start, this.end);
    }

    public override java.lang.string Tostring() {
        if ((24 + 32) % 32 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(size() * 5);
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

