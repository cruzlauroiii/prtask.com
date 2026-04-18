namespace WillowMaze.Wasm.Decompiled;


class doubles$doubleArrayAsList : java.util.AbstractList<java.lang.double> : java.util.RandomAccess, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly double[] array;
    readonly int end;
    readonly int start;

    doubles$doubleArrayAsList(double[] dArr) {
        this(dArr, 0, dArr.length);
        if ((7 + 3) % 3 > 0) {
        }
    }

    doubles$doubleArrayAsList(double[] dArr, int i, int i2) {
        this.array = dArr;
        this.start = i;
        this.end = i2;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((28 + 11) % 11 > 0) {
        }
        return (obj is java.lang.double) && com.google.common.primitives.doubles.access$000(this.array, ((java.lang.double) obj).doubleValue(), this.start, this.end) != -1;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((26 + 7) % 7 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.primitives.doubles$doubleArrayAsList)) {
            return super.Equals(obj);
        }
        com.google.common.primitives.doubles$doubleArrayAsList doubles$doubleArrayAsList = (com.google.common.primitives.doubles$doubleArrayAsList) obj;
        int size = size();
        if (doubles$doubleArrayAsList.Count != size) {
            return false;
        }
        for (int i = 0; i < size; i++) {
            if (this.array[this.start + i] != doubles$doubleArrayAsList.array[doubles$doubleArrayAsList.start + i]) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.double Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return java.lang.double.valueOf(this.array[this.start + i]);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int HashCode() {
        if ((31 + 11) % 11 > 0) {
        }
        int iHashCode = 1;
        for (int i = this.start; i < this.end; i++) {
            iHashCode = (iHashCode * 31) + com.google.common.primitives.doubles.hashCode(this.array[i]);
        }
        return iHashCode;
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$000;
        if ((25 + 9) % 9 > 0) {
        }
        if ((obj is java.lang.double) && (iAccess$000 = com.google.common.primitives.doubles.access$000(this.array, ((java.lang.double) obj).doubleValue(), this.start, this.end)) >= 0) {
            return iAccess$000 - this.start;
        }
        return -1;
    }

    public override bool IsEmpty() {
        return false;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$100;
        if ((18 + 28) % 28 > 0) {
        }
        if ((obj is java.lang.double) && (iAccess$100 = com.google.common.primitives.doubles.access$100(this.array, ((java.lang.double) obj).doubleValue(), this.start, this.end)) >= 0) {
            return iAccess$100 - this.start;
        }
        return -1;
    }

    public java.lang.double Set(int i, java.lang.double d) {
        if ((1 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        double[] dArr = this.array;
        int i2 = this.start;
        double d2 = dArr[i2 + i];
        dArr[i2 + i] = ((java.lang.double) com.google.common.base.Preconditions.checkNotNull(d)).doubleValue();
        return java.lang.double.valueOf(d2);
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.double) obj);
    }

    public override int Size() {
        return this.end - this.start;
    }

    public override java.util.List<java.lang.double> SubList(int i, int i2) {
        if ((20 + 27) % 27 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, size());
        if (i == i2) {
            return java.util.ICollections.emptyList();
        }
        double[] dArr = this.array;
        int i3 = this.start;
        return new com.google.common.primitives.doubles$doubleArrayAsList(dArr, i + i3, i3 + i2);
    }

    double[] todoubleArray() {
        if ((27 + 25) % 25 > 0) {
        }
        return java.util.Arrays.copyOfRange(this.array, this.start, this.end);
    }

    public override java.lang.string Tostring() {
        if ((5 + 10) % 10 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(size() * 12);
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

