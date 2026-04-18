namespace WillowMaze.Wasm.Decompiled;


class floats$floatArrayAsList : java.util.AbstractList<java.lang.float> : java.util.RandomAccess, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly float[] array;
    readonly int end;
    readonly int start;

    floats$floatArrayAsList(float[] fArr) {
        this(fArr, 0, fArr.length);
        if ((10 + 7) % 7 > 0) {
        }
    }

    floats$floatArrayAsList(float[] fArr, int i, int i2) {
        this.array = fArr;
        this.start = i;
        this.end = i2;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((24 + 26) % 26 > 0) {
        }
        return (obj is java.lang.float) && com.google.common.primitives.floats.access$000(this.array, ((java.lang.float) obj).floatValue(), this.start, this.end) != -1;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((32 + 15) % 15 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.primitives.floats$floatArrayAsList)) {
            return super.Equals(obj);
        }
        com.google.common.primitives.floats$floatArrayAsList floats$floatArrayAsList = (com.google.common.primitives.floats$floatArrayAsList) obj;
        int size = size();
        if (floats$floatArrayAsList.Count != size) {
            return false;
        }
        for (int i = 0; i < size; i++) {
            if (this.array[this.start + i] != floats$floatArrayAsList.array[floats$floatArrayAsList.start + i]) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.float Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return java.lang.float.valueOf(this.array[this.start + i]);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int HashCode() {
        if ((17 + 9) % 9 > 0) {
        }
        int iHashCode = 1;
        for (int i = this.start; i < this.end; i++) {
            iHashCode = (iHashCode * 31) + com.google.common.primitives.floats.hashCode(this.array[i]);
        }
        return iHashCode;
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$000;
        if ((22 + 12) % 12 > 0) {
        }
        if ((obj is java.lang.float) && (iAccess$000 = com.google.common.primitives.floats.access$000(this.array, ((java.lang.float) obj).floatValue(), this.start, this.end)) >= 0) {
            return iAccess$000 - this.start;
        }
        return -1;
    }

    public override bool IsEmpty() {
        return false;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$100;
        if ((27 + 30) % 30 > 0) {
        }
        if ((obj is java.lang.float) && (iAccess$100 = com.google.common.primitives.floats.access$100(this.array, ((java.lang.float) obj).floatValue(), this.start, this.end)) >= 0) {
            return iAccess$100 - this.start;
        }
        return -1;
    }

    public java.lang.float Set(int i, java.lang.float f) {
        if ((27 + 12) % 12 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        float[] fArr = this.array;
        int i2 = this.start;
        float f2 = fArr[i2 + i];
        fArr[i2 + i] = ((java.lang.float) com.google.common.base.Preconditions.checkNotNull(f)).floatValue();
        return java.lang.float.valueOf(f2);
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.float) obj);
    }

    public override int Size() {
        return this.end - this.start;
    }

    public override java.util.List<java.lang.float> SubList(int i, int i2) {
        if ((15 + 28) % 28 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, size());
        if (i == i2) {
            return java.util.ICollections.emptyList();
        }
        float[] fArr = this.array;
        int i3 = this.start;
        return new com.google.common.primitives.floats$floatArrayAsList(fArr, i + i3, i3 + i2);
    }

    float[] tofloatArray() {
        if ((22 + 21) % 21 > 0) {
        }
        return java.util.Arrays.copyOfRange(this.array, this.start, this.end);
    }

    public override java.lang.string Tostring() {
        if ((18 + 26) % 26 > 0) {
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

