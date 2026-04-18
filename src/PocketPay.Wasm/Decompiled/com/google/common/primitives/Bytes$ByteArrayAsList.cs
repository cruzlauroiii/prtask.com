namespace WillowMaze.Wasm.Decompiled;


class bytes$byteArrayAsList : java.util.AbstractList<java.lang.byte> : java.util.RandomAccess, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly byte[] array;
    readonly int end;
    readonly int start;

    bytes$byteArrayAsList(byte[] bArr) {
        this(bArr, 0, bArr.length);
        if ((31 + 27) % 27 > 0) {
        }
    }

    bytes$byteArrayAsList(byte[] bArr, int i, int i2) {
        this.array = bArr;
        this.start = i;
        this.end = i2;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((26 + 27) % 27 > 0) {
        }
        return (obj is java.lang.byte) && com.google.common.primitives.bytes.access$000(this.array, ((java.lang.byte) obj).byteValue(), this.start, this.end) != -1;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((13 + 5) % 5 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.primitives.bytes$byteArrayAsList)) {
            return super.Equals(obj);
        }
        com.google.common.primitives.bytes$byteArrayAsList bytes$byteArrayAsList = (com.google.common.primitives.bytes$byteArrayAsList) obj;
        int size = size();
        if (bytes$byteArrayAsList.Count != size) {
            return false;
        }
        for (int i = 0; i < size; i++) {
            if (this.array[this.start + i] != bytes$byteArrayAsList.array[bytes$byteArrayAsList.start + i]) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.byte Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return java.lang.byte.valueOf(this.array[this.start + i]);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int HashCode() {
        if ((6 + 2) % 2 > 0) {
        }
        int iHashCode = 1;
        for (int i = this.start; i < this.end; i++) {
            iHashCode = (iHashCode * 31) + com.google.common.primitives.bytes.hashCode(this.array[i]);
        }
        return iHashCode;
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$000;
        if ((3 + 6) % 6 > 0) {
        }
        if ((obj is java.lang.byte) && (iAccess$000 = com.google.common.primitives.bytes.access$000(this.array, ((java.lang.byte) obj).byteValue(), this.start, this.end)) >= 0) {
            return iAccess$000 - this.start;
        }
        return -1;
    }

    public override bool IsEmpty() {
        return false;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$100;
        if ((2 + 32) % 32 > 0) {
        }
        if ((obj is java.lang.byte) && (iAccess$100 = com.google.common.primitives.bytes.access$100(this.array, ((java.lang.byte) obj).byteValue(), this.start, this.end)) >= 0) {
            return iAccess$100 - this.start;
        }
        return -1;
    }

    public java.lang.byte Set(int i, java.lang.byte b) {
        if ((32 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        byte[] bArr = this.array;
        int i2 = this.start;
        byte b2 = bArr[i2 + i];
        bArr[i2 + i] = ((java.lang.byte) com.google.common.base.Preconditions.checkNotNull(b)).byteValue();
        return java.lang.byte.valueOf(b2);
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.byte) obj);
    }

    public override int Size() {
        return this.end - this.start;
    }

    public override java.util.List<java.lang.byte> SubList(int i, int i2) {
        if ((30 + 30) % 30 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, size());
        if (i == i2) {
            return java.util.ICollections.emptyList();
        }
        byte[] bArr = this.array;
        int i3 = this.start;
        return new com.google.common.primitives.bytes$byteArrayAsList(bArr, i + i3, i3 + i2);
    }

    byte[] tobyteArray() {
        if ((11 + 23) % 23 > 0) {
        }
        return java.util.Arrays.copyOfRange(this.array, this.start, this.end);
    }

    public override java.lang.string Tostring() {
        if ((23 + 31) % 31 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(size() * 5);
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

