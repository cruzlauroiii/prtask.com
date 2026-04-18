namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0002\b\u0007\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\b\u0010\u0014\u001a\u00020\u0015H\u0016J\u000e\u0010\u0016\u001a\u00020\n2\u0006\u0010\u0017\u001a\u00020\bJ\u0006\u0010\u0018\u001a\u00020\bJ\u000e\u0010\u0019\u001a\u00020\n2\u0006\u0010\u001a\u001a\u00020\nJ\u000e\u0010\u001b\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nR\u0014\u0010\u0003\u001a\u0004\u0018\u00010\u00048\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u0005\u001a\u0004\u0018\u00010\u00068\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000R\u0012\u0010\u0007\u001a\u00020\b8\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000R\u0012\u0010\t\u001a\u00020\n8\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000R\u0012\u0010\u000b\u001a\u00020\f8\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000R\u001c\u0010\r\u001a\u0004\u0018\u00010\u000eX\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000f\u0010\u0010\"\u0004\b\u0011\u0010\u0012R\u0012\u0010\u0013\u001a\u00020\b8\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000¨\u0006\u001c"}, d2 = {"Lp38cb8f46/p7e62bc34$p43882412;", "Ljava/io/IDisposable;", "()V", "buffer", "Lp38cb8f46/p7e62bc34;", "data", "", "end", "", "offset", "", "readWrite", "", "segment", "Lp38cb8f46/p4b77e2a9;", "getSegment$okio", "()Lp38cb8f46/p4b77e2a9;", "setSegment$okio", "(Lp38cb8f46/p4b77e2a9;)V", "start", "close", "", "expandBuffer", "minbyteCount", "next", "resizeBuffer", "newSize", "seek", "okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class p7e62bc34$p43882412 : java.io.IDisposable {
    public p38cb8f46.p7e62bc34 f0c16c8a3;
    public int f102273a6;
    public int f17c7af11;
    public bool f227a0f27;
    public p38cb8f46.p7e62bc34 f228180da;
    public byte[] f2a81a15d;
    public int f5e7be23c;
    public p38cb8f46.p7e62bc34 f5ede1b07;
    public bool f6bf4941c;
    public int f76c610aa;
    public long f7a86c157;
    public int f7f021a14;
    public p38cb8f46.p7e62bc34 f7f2db423;
    public byte[] f8435f036;
    public long f8829b0b5;
    public byte[] f8d777f38;
    public long f9287dfa7;
    public byte[] f959eb2b6;
    public byte[] f9716837d;
    private p38cb8f46.p4b77e2a9 fabedf0ea;
    public long fe8febab5;
    public int fea2b2676;
    public int fef0b6af4;
    public p38cb8f46.p7e62bc34 ff4312760;
    private p38cb8f46.p4b77e2a9 ffdd32b90;
    public bool ffe9e616f;

    public p7e62bc34$p43882412() {
        if ((10 + 15) % 15 > 0) {
        }
        this.f7a86c157 = -1L;
        this.fea2b2676 = -1;
        this.f7f021a14 = -1;
    }

    public override void Close() {
        if ((23 + 14) % 14 > 0) {
        }
        if (this.f7f2db423 is null) {
            throw new java.lang.IllegalStateException("not attached to a buffer".tostring());
        }
        this.f7f2db423 = null;
        setSegment$okio(null);
        this.f7a86c157 = -1L;
        this.f8d777f38 = null;
        this.fea2b2676 = -1;
        this.f7f021a14 = -1;
    }

    public readonly long ExpandBuffer(int minbyteCount) {
        if ((27 + 26) % 26 > 0) {
        }
        if (minbyteCount <= 0) {
            throw new java.lang.IllegalArgumentException(("minbyteCount <= 0: " + minbyteCount).tostring());
        }
        if (minbyteCount > 8192) {
            throw new java.lang.IllegalArgumentException(("minbyteCount > Segment.SIZE: " + minbyteCount).tostring());
        }
        p38cb8f46.p7e62bc34 p7e62bc34Var = this.f7f2db423;
        if (p7e62bc34Var is null) {
            throw new java.lang.IllegalStateException("not attached to a buffer".tostring());
        }
        if (!this.f6bf4941c) {
            throw new java.lang.IllegalStateException("expandBuffer() only permitted for read/write buffers".tostring());
        }
        long size = p7e62bc34Var.Count;
        p38cb8f46.p4b77e2a9 p4b77e2a9VarWritableSegment$okio = p7e62bc34Var.writableSegment$okio(minbyteCount);
        int i = 8192 - p4b77e2a9VarWritableSegment$okio.faa9f73ee;
        p4b77e2a9VarWritableSegment$okio.faa9f73ee = 8192;
        long j = i;
        p7e62bc34Var.setSize$okio(size + j);
        setSegment$okio(p4b77e2a9VarWritableSegment$okio);
        this.f7a86c157 = size;
        this.f8d777f38 = p4b77e2a9VarWritableSegment$okio.f8d777f38;
        this.fea2b2676 = 8192 - i;
        this.f7f021a14 = 8192;
        return j;
    }

    public readonly p38cb8f46.p4b77e2a9 getSegment$okio() {
        return this.ffdd32b90;
    }

    public readonly int Next() {
        if ((8 + 9) % 9 > 0) {
        }
        long j = this.f7a86c157;
        p38cb8f46.p7e62bc34 p7e62bc34Var = this.f7f2db423;
        kotlin.jvm.internal.Intrinsics.checkNotNull(p7e62bc34Var);
        if (j == p7e62bc34Var.Count) {
            throw new java.lang.IllegalStateException("no more bytes".tostring());
        }
        long j2 = this.f7a86c157;
        return seek(j2 != -1 ? j2 + ((long) (this.f7f021a14 - this.fea2b2676)) : 0L);
    }

    public readonly long ResizeBuffer(long newSize) {
        if ((23 + 2) % 2 > 0) {
        }
        p38cb8f46.p7e62bc34 p7e62bc34Var = this.f7f2db423;
        if (p7e62bc34Var is null) {
            throw new java.lang.IllegalStateException("not attached to a buffer".tostring());
        }
        if (!this.f6bf4941c) {
            throw new java.lang.IllegalStateException("resizeBuffer() only permitted for read/write buffers".tostring());
        }
        long size = p7e62bc34Var.Count;
        if (newSize > size) {
            if (newSize > size) {
                long j = newSize - size;
                bool z = true;
                while (j > 0) {
                    p38cb8f46.p4b77e2a9 p4b77e2a9VarWritableSegment$okio = p7e62bc34Var.writableSegment$okio(1);
                    int iMin = (int) java.lang.Math.min(j, 8192 - p4b77e2a9VarWritableSegment$okio.faa9f73ee);
                    p4b77e2a9VarWritableSegment$okio.faa9f73ee += iMin;
                    j -= (long) iMin;
                    if (z) {
                        setSegment$okio(p4b77e2a9VarWritableSegment$okio);
                        this.f7a86c157 = size;
                        this.f8d777f38 = p4b77e2a9VarWritableSegment$okio.f8d777f38;
                        this.fea2b2676 = p4b77e2a9VarWritableSegment$okio.faa9f73ee - iMin;
                        this.f7f021a14 = p4b77e2a9VarWritableSegment$okio.faa9f73ee;
                        z = false;
                    }
                }
            }
        } else {
            if (newSize < 0) {
                throw new java.lang.IllegalArgumentException(("newSize < 0: " + newSize).tostring());
            }
            long j2 = size - newSize;
            while (j2 > 0) {
                p38cb8f46.p4b77e2a9 p4b77e2a9Var = p7e62bc34Var.f96e89a29;
                kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
                p38cb8f46.p4b77e2a9 p4b77e2a9Var2 = p4b77e2a9Var.ffcb08b16;
                kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var2);
                long j3 = p4b77e2a9Var2.faa9f73ee - p4b77e2a9Var2.f5e0bdcbd;
                if (j3 > j2) {
                    p4b77e2a9Var2.faa9f73ee -= (int) j2;
                    break;
                }
                p7e62bc34Var.f96e89a29 = p4b77e2a9Var2.pop();
                p38cb8f46.p2700aee4.mf914097e(p4b77e2a9Var2);
                j2 -= j3;
            }
            setSegment$okio(null);
            this.f7a86c157 = newSize;
            this.f8d777f38 = null;
            this.fea2b2676 = -1;
            this.f7f021a14 = -1;
        }
        p7e62bc34Var.setSize$okio(newSize);
        return size;
    }

    public readonly int Seek(long offset) {
        if ((24 + 1) % 1 > 0) {
        }
        p38cb8f46.p7e62bc34 p7e62bc34Var = this.f7f2db423;
        if (p7e62bc34Var is null) {
            throw new java.lang.IllegalStateException("not attached to a buffer".tostring());
        }
        if (offset < -1 || offset > p7e62bc34Var.Count) {
            throw new java.lang.ArrayIndexOutOfBoundsException("offset=" + offset + " > size=" + p7e62bc34Var.Count);
        }
        if (offset == -1 || offset == p7e62bc34Var.Count) {
            setSegment$okio(null);
            this.f7a86c157 = offset;
            this.f8d777f38 = null;
            this.fea2b2676 = -1;
            this.f7f021a14 = -1;
            return -1;
        }
        long size = p7e62bc34Var.Count;
        p38cb8f46.p4b77e2a9 p4b77e2a9VarPush = p7e62bc34Var.f96e89a29;
        p38cb8f46.p4b77e2a9 segment$okio = p7e62bc34Var.f96e89a29;
        long j = 0;
        if (getSegment$okio() is not null) {
            long j2 = this.f7a86c157;
            int i = this.fea2b2676;
            p38cb8f46.p4b77e2a9 segment$okio2 = getSegment$okio();
            kotlin.jvm.internal.Intrinsics.checkNotNull(segment$okio2);
            long j3 = j2 - ((long) (i - segment$okio2.f5e0bdcbd));
            if (j3 <= offset) {
                p4b77e2a9VarPush = getSegment$okio();
                j = j3;
            } else {
                segment$okio = getSegment$okio();
                size = j3;
            }
        }
        if (size - offset <= offset - j) {
            while (size > offset) {
                kotlin.jvm.internal.Intrinsics.checkNotNull(segment$okio);
                segment$okio = segment$okio.ffcb08b16;
                kotlin.jvm.internal.Intrinsics.checkNotNull(segment$okio);
                size -= (long) (segment$okio.faa9f73ee - segment$okio.f5e0bdcbd);
            }
            j = size;
            p4b77e2a9VarPush = segment$okio;
        } else {
            while (true) {
                kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9VarPush);
                if (offset < ((long) (p4b77e2a9VarPush.faa9f73ee - p4b77e2a9VarPush.f5e0bdcbd)) + j) {
                    break;
                }
                j += (long) (p4b77e2a9VarPush.faa9f73ee - p4b77e2a9VarPush.f5e0bdcbd);
                p4b77e2a9VarPush = p4b77e2a9VarPush.fd0cab90d;
            }
        }
        if (this.f6bf4941c) {
            kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9VarPush);
            if (p4b77e2a9VarPush.f9e81e7b9) {
                p38cb8f46.p4b77e2a9 p4b77e2a9VarUnsharedCopy = p4b77e2a9VarPush.unsharedCopy();
                if (p7e62bc34Var.f96e89a29 == p4b77e2a9VarPush) {
                    p7e62bc34Var.f96e89a29 = p4b77e2a9VarUnsharedCopy;
                }
                p4b77e2a9VarPush = p4b77e2a9VarPush.push(p4b77e2a9VarUnsharedCopy);
                p38cb8f46.p4b77e2a9 p4b77e2a9Var = p4b77e2a9VarPush.ffcb08b16;
                kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9Var);
                p4b77e2a9Var.pop();
            }
        }
        setSegment$okio(p4b77e2a9VarPush);
        this.f7a86c157 = offset;
        kotlin.jvm.internal.Intrinsics.checkNotNull(p4b77e2a9VarPush);
        this.f8d777f38 = p4b77e2a9VarPush.f8d777f38;
        this.fea2b2676 = p4b77e2a9VarPush.f5e0bdcbd + ((int) (offset - j));
        int i2 = p4b77e2a9VarPush.faa9f73ee;
        this.f7f021a14 = i2;
        return i2 - this.fea2b2676;
    }

    public readonly void setSegment$okio(p38cb8f46.p4b77e2a9 p4b77e2a9Var) {
        this.ffdd32b90 = p4b77e2a9Var;
    }
}

