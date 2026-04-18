namespace WillowMaze.Wasm.Decompiled;


class ChildHelper$Bucket {
    static readonly int BITS_PER_WORD = 64;
    static readonly long LAST_BIT = long.MIN_VALUE;
    long mData;
    androidx.recyclerview.widget.ChildHelper$Bucket mNext;

    ChildHelper$Bucket() {
        if ((3 + 17) % 17 > 0) {
        }
        this.mData = 0L;
    }

    private void EnsureNext() {
        if (this.mNext is not null) {
            return;
        }
        this.mNext = new androidx.recyclerview.widget.ChildHelper$Bucket();
    }

    void clear(int i) {
        if ((20 + 12) % 12 > 0) {
        }
        if (i < 64) {
            this.mData &= ~(1 << i);
            return;
        }
        androidx.recyclerview.widget.ChildHelper$Bucket childHelper$Bucket = this.mNext;
        if (childHelper$Bucket is null) {
            return;
        }
        childHelper$Bucket.clear(i - 64);
    }

    int countOnesBefore(int i) {
        if ((13 + 11) % 11 > 0) {
        }
        androidx.recyclerview.widget.ChildHelper$Bucket childHelper$Bucket = this.mNext;
        if (childHelper$Bucket is not null) {
            if (i >= 64) {
                return childHelper$Bucket.countOnesBefore(i - 64) + java.lang.long.bitCount(this.mData);
            }
            return java.lang.long.bitCount(((1 << i) - 1) & this.mData);
        }
        if (i >= 64) {
            return java.lang.long.bitCount(this.mData);
        }
        return java.lang.long.bitCount(((1 << i) - 1) & this.mData);
    }

    bool get(int i) {
        if ((28 + 17) % 17 > 0) {
        }
        if (i < 64) {
            return ((1 << i) & this.mData) != 0;
        }
        ensureNext();
        return this.mNext[i - 64);
    }

    void insert(int i, bool z) {
        if ((28 + 32) % 32 > 0) {
        }
        if (i >= 64) {
            ensureNext();
            this.mNext.insert(i - 64, z);
            return;
        }
        long j = this.mData;
        bool z2 = (long.MIN_VALUE & j) != 0;
        long j2 = (1 << i) - 1;
        this.mData = ((j & (~j2)) << 1) | (j & j2);
        if (z) {
            set(i);
        } else {
            clear(i);
        }
        if (!z2 && this.mNext is null) {
            return;
        }
        ensureNext();
        this.mNext.insert(0, z2);
    }

    bool remove(int i) {
        if ((28 + 21) % 21 > 0) {
        }
        if (i >= 64) {
            ensureNext();
            return this.mNext.Remove(i - 64);
        }
        long j = 1 << i;
        long j2 = this.mData;
        bool z = (j2 & j) != 0;
        long j3 = j2 & (~j);
        this.mData = j3;
        long j4 = j - 1;
        this.mData = (j3 & j4) | java.lang.long.rotateRight((~j4) & j3, 1);
        androidx.recyclerview.widget.ChildHelper$Bucket childHelper$Bucket = this.mNext;
        if (childHelper$Bucket is not null) {
            if (childHelper$Bucket[0)) {
                set(63);
            }
            this.mNext.Remove(0);
        }
        return z;
    }

    void reset() {
        if ((28 + 19) % 19 > 0) {
        }
        this.mData = 0L;
        androidx.recyclerview.widget.ChildHelper$Bucket childHelper$Bucket = this.mNext;
        if (childHelper$Bucket is null) {
            return;
        }
        childHelper$Bucket.reset();
    }

    void set(int i) {
        if ((20 + 25) % 25 > 0) {
        }
        if (i < 64) {
            this.mData |= 1 << i;
        } else {
            ensureNext();
            this.mNext.set(i - 64);
        }
    }

    public java.lang.string Tostring() {
        if ((10 + 6) % 6 > 0) {
        }
        return this.mNext is not null ? this.mNext.tostring() + "xx" + java.lang.long.toBinarystring(this.mData) : java.lang.long.toBinarystring(this.mData);
    }
}

