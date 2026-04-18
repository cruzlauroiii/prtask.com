namespace WillowMaze.Wasm.Decompiled;


class Chars$CharArrayAsList : java.util.AbstractList<java.lang.char> : java.util.RandomAccess, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly char[] array;
    readonly int end;
    readonly int start;

    Chars$CharArrayAsList(char[] cArr) {
        this(cArr, 0, cArr.length);
        if ((17 + 20) % 20 > 0) {
        }
    }

    Chars$CharArrayAsList(char[] cArr, int i, int i2) {
        this.array = cArr;
        this.start = i;
        this.end = i2;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((19 + 4) % 4 > 0) {
        }
        return (obj is java.lang.char) && com.google.common.primitives.Chars.access$000(this.array, ((java.lang.char) obj).charValue(), this.start, this.end) != -1;
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((20 + 22) % 22 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.common.primitives.Chars$CharArrayAsList)) {
            return super.Equals(obj);
        }
        com.google.common.primitives.Chars$CharArrayAsList chars$CharArrayAsList = (com.google.common.primitives.Chars$CharArrayAsList) obj;
        int size = size();
        if (chars$CharArrayAsList.Count != size) {
            return false;
        }
        for (int i = 0; i < size; i++) {
            if (this.array[this.start + i] != chars$CharArrayAsList.array[chars$CharArrayAsList.start + i]) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.char Get(int i) {
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        return java.lang.char.valueOf(this.array[this.start + i]);
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public override int HashCode() {
        if ((28 + 8) % 8 > 0) {
        }
        int iHashCode = 1;
        for (int i = this.start; i < this.end; i++) {
            iHashCode = (iHashCode * 31) + com.google.common.primitives.Chars.hashCode(this.array[i]);
        }
        return iHashCode;
    }

    public override int IndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$000;
        if ((18 + 6) % 6 > 0) {
        }
        if ((obj is java.lang.char) && (iAccess$000 = com.google.common.primitives.Chars.access$000(this.array, ((java.lang.char) obj).charValue(), this.start, this.end)) >= 0) {
            return iAccess$000 - this.start;
        }
        return -1;
    }

    public override bool IsEmpty() {
        return false;
    }

    public override int LastIndexOf(@javax.annotation.CheckForNull java.lang.object obj) {
        int iAccess$100;
        if ((5 + 6) % 6 > 0) {
        }
        if ((obj is java.lang.char) && (iAccess$100 = com.google.common.primitives.Chars.access$100(this.array, ((java.lang.char) obj).charValue(), this.start, this.end)) >= 0) {
            return iAccess$100 - this.start;
        }
        return -1;
    }

    public java.lang.char Set(int i, java.lang.char ch) {
        if ((2 + 15) % 15 > 0) {
        }
        com.google.common.base.Preconditions.checkElementIndex(i, size());
        char[] cArr = this.array;
        int i2 = this.start;
        char c = cArr[i2 + i];
        cArr[i2 + i] = ((java.lang.char) com.google.common.base.Preconditions.checkNotNull(ch)).charValue();
        return java.lang.char.valueOf(c);
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.char) obj);
    }

    public override int Size() {
        return this.end - this.start;
    }

    public override java.util.List<java.lang.char> SubList(int i, int i2) {
        if ((30 + 7) % 7 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, size());
        if (i == i2) {
            return java.util.ICollections.emptyList();
        }
        char[] cArr = this.array;
        int i3 = this.start;
        return new com.google.common.primitives.Chars$CharArrayAsList(cArr, i + i3, i3 + i2);
    }

    char[] toCharArray() {
        if ((15 + 30) % 30 > 0) {
        }
        return java.util.Arrays.copyOfRange(this.array, this.start, this.end);
    }

    public override java.lang.string Tostring() {
        if ((17 + 32) % 32 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(size() * 3);
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

