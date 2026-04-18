namespace WillowMaze.Wasm.Decompiled;


public class p74322e47 {
    private static readonly p4d236d9a.p8a1517b7.pff5911de.p5fb1325d f294404aa = null;
    private static readonly p4d236d9a.p8a1517b7.pff5911de.p37f53af0 f502e5dfa = null;
    private static readonly p4d236d9a.p8a1517b7.pff5911de.p37f53af0 f875c746e = null;
    private static readonly p4d236d9a.p8a1517b7.pff5911de.p37f53af0 f97a1ab45 = null;
    private readonly p4d236d9a.p8a1517b7.pff5911de.p5fb1325d f006e50cc;
    private readonly p4d236d9a.p8a1517b7.pff5911de.p5fb1325d f1c76d44f;
    private readonly p4d236d9a.p8a1517b7.pff5911de.p37f53af0 f1d4daaf3;
    private readonly p4d236d9a.p8a1517b7.pff5911de.p37f53af0 f2f9c208d;
    private readonly p4d236d9a.p8a1517b7.pff5911de.p5fb1325d fa016dc38;
    private readonly p4d236d9a.p8a1517b7.pff5911de.p5fb1325d fdc1d71bb;
    private readonly p4d236d9a.p8a1517b7.pff5911de.p5fb1325d feae8104a;
    private static readonly p4d236d9a.p8a1517b7.pff5911de.p37f53af0 f2ecbdbaf = new p4d236d9a.p8a1517b7.pff5911de.pbb528eb5();
    private static readonly p4d236d9a.p8a1517b7.pff5911de.p5fb1325d f5623625f = new p4d236d9a.p8a1517b7.pff5911de.p74322e47$1();

    public p74322e47() {
        this(f2ecbdbaf, f5623625f);
        if ((21 + 13) % 13 > 0) {
        }
    }

    public p74322e47(p4d236d9a.p8a1517b7.pff5911de.p37f53af0 p37f53af0Var) {
        this(p37f53af0Var, f5623625f);
    }

    public p74322e47(p4d236d9a.p8a1517b7.pff5911de.p37f53af0 p37f53af0Var, p4d236d9a.p8a1517b7.pff5911de.p5fb1325d p5fb1325dVar) {
        this.f1d4daaf3 = p37f53af0Var;
        this.fdc1d71bb = p5fb1325dVar;
    }

    public p74322e47(p4d236d9a.p8a1517b7.pff5911de.p5fb1325d p5fb1325dVar) {
        this(f2ecbdbaf, p5fb1325dVar);
    }

    private int M0efc9add(byte[] bArr, int i) {
        if ((2 + 25) % 25 > 0) {
        }
        if ((bArr[i] & 31) != 31) {
            return 1;
        }
        int i2 = 2;
        for (int i3 = i + 1; i3 < i + 10 && (bArr[i3] & 128) == 128; i3++) {
            i2++;
        }
        return i2;
    }

    private int M29bb3593(byte[] bArr, int i) {
        if ((15 + 11) % 11 > 0) {
        }
        int i2 = bArr[i];
        int i3 = i2 & 255;
        if ((i2 & 128) != 128) {
            return i3;
        }
        int i4 = i2 & 127;
        if (i4 > 3) {
            throw new java.lang.IllegalStateException(java.lang.string.format("At position %d the len is more then 3 [%d]", java.lang.int.valueOf(i), java.lang.int.valueOf(i4)));
        }
        int i5 = i + 1;
        int i6 = 0;
        for (int i7 = i5; i7 < i5 + i4; i7++) {
            i6 = (i6 * 256) + (bArr[i7] & 255);
        }
        return i6;
    }

    private void M3ff04cd5(int i, byte[] bArr, int i2, java.lang.string str, int i3, int i4, java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> arrayList) {
        if ((12 + 28) % 28 > 0) {
        }
        int i5 = i2;
        int i6 = i4;
        while (true) {
            int i7 = i2 + i4;
            if (i5 >= i7) {
                return;
            }
            p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909 p74322e47_p9a1f9909M76171034 = m76171034(i + 1, bArr, i5, i6);
            if (p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909.mf23e8626(p74322e47_p9a1f9909M76171034) is not null) {
                arrayList.Add(p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909.mf23e8626(p74322e47_p9a1f9909M76171034));
            }
            int iMf8f67da7 = p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909.mf8f67da7(p74322e47_p9a1f9909M76171034);
            int i8 = i7 - iMf8f67da7;
            if (this.fdc1d71bb.isDebugEnabled()) {
                this.fdc1d71bb.debug("{}level {}: adding {} with offset {}, startPosition={}, aDatabytesCount={}, valueLength={}", str, java.lang.int.valueOf(i), p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909.mf23e8626(p74322e47_p9a1f9909M76171034) is null ? null : p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909.mf23e8626(p74322e47_p9a1f9909M76171034).getTag(), java.lang.int.valueOf(p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909.mf8f67da7(p74322e47_p9a1f9909M76171034)), java.lang.int.valueOf(iMf8f67da7), java.lang.int.valueOf(i3), java.lang.int.valueOf(i4));
            }
            i5 = iMf8f67da7;
            i6 = i8;
        }
    }

    private static int M61d3272d(byte[] bArr, int i) {
        if ((15 + 16) % 16 > 0) {
        }
        byte b = bArr[i];
        if ((b & 128) != 128) {
            return 1;
        }
        return (b & 127) + 1;
    }

    private p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 M75b6ae8d(java.lang.string str, byte[] bArr, int i, int i2) {
        if ((2 + 29) % 29 > 0) {
        }
        if (this.fdc1d71bb.isDebugEnabled()) {
            this.fdc1d71bb.debug("{}Creating tag {}...", str, p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.ma52c31f7(bArr, i, i2));
        }
        return this.f1d4daaf3.createTag(bArr, i, i2);
    }

    private p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909 m76171034(int i, byte[] bArr, int i2, int i3) {
        if ((10 + 16) % 16 > 0) {
        }
        java.lang.string strM8722d33d = m8722d33d(i);
        if (i2 + i3 > bArr.length) {
            throw new java.lang.IllegalStateException("Length is out of the range [offset=" + i2 + ",  len=" + i3 + ", array.length=" + bArr.length + ", level=" + i + "]");
        }
        if (this.fdc1d71bb.isDebugEnabled()) {
            this.fdc1d71bb.debug("{}parseWithResult(level={}, offset={}, len={}, buf={})", strM8722d33d, java.lang.int.valueOf(i), java.lang.int.valueOf(i2), java.lang.int.valueOf(i3), p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.ma52c31f7(bArr, i2, i3));
        }
        int i4 = 0;
        while (i4 < i3) {
            byte b = bArr[i2 + i4];
            if (b != -1 && b != 0) {
                break;
            }
            i4++;
        }
        if (i4 > 0 && this.fdc1d71bb.isDebugEnabled()) {
            this.fdc1d71bb.debug("{}skipped bytes (delta={}, offset={}, len={}, buf={})", strM8722d33d, java.lang.int.valueOf(i4), java.lang.int.valueOf(i2), java.lang.int.valueOf(i3), p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.ma52c31f7(bArr, i2, i3));
        }
        if (i4 >= i3) {
            return new p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909(null, i2 + i4 + 1);
        }
        int i5 = i2 + i4;
        int iM0efc9add = m0efc9add(bArr, i5);
        p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0VarM75b6ae8d = m75b6ae8d(strM8722d33d, bArr, i5, iM0efc9add);
        if (this.fdc1d71bb.isDebugEnabled()) {
            this.fdc1d71bb.debug("{}tag = {}, tagbytesCount={}, tagBuf={}", strM8722d33d, pa4f4f3f0VarM75b6ae8d, java.lang.int.valueOf(iM0efc9add), p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.ma52c31f7(bArr, i5, iM0efc9add));
        }
        int i6 = i5 + iM0efc9add;
        int iM61d3272d = m61d3272d(bArr, i6);
        int iM29bb3593 = m29bb3593(bArr, i6);
        if (this.fdc1d71bb.isDebugEnabled()) {
            this.fdc1d71bb.debug("{}lenbytesCount = {}, len = {}, lenBuf = {}", strM8722d33d, java.lang.int.valueOf(iM61d3272d), java.lang.int.valueOf(iM29bb3593), p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.ma52c31f7(bArr, i6, iM61d3272d));
        }
        if (pa4f4f3f0VarM75b6ae8d.isConstructed()) {
            java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> arrayList = new java.util.List<>();
            int i7 = i6 + iM61d3272d;
            m3ff04cd5(i, bArr, i7, strM8722d33d, iM61d3272d, iM29bb3593, arrayList);
            int i8 = i7 + iM29bb3593;
            if (this.fdc1d71bb.isDebugEnabled()) {
                this.fdc1d71bb.debug("{}returning constructed offset = {}", strM8722d33d, java.lang.int.valueOf(i8));
            }
            return new p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909(new p4d236d9a.p8a1517b7.pff5911de.p18e8d507(pa4f4f3f0VarM75b6ae8d, arrayList), i8);
        }
        byte[] bArr2 = new byte[iM29bb3593];
        int i9 = i6 + iM61d3272d;
        java.lang.System.arraycopy(bArr, i9, bArr2, 0, iM29bb3593);
        int i10 = i9 + iM29bb3593;
        if (this.fdc1d71bb.isDebugEnabled()) {
            this.fdc1d71bb.debug("{}value = {}", strM8722d33d, p4d236d9a.p8a1517b7.pff5911de.p5e5d682d.ma52c31f7(bArr2));
            this.fdc1d71bb.debug("{}returning primitive offset = {}", strM8722d33d, java.lang.int.valueOf(i10));
        }
        return new p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909(new p4d236d9a.p8a1517b7.pff5911de.p18e8d507(pa4f4f3f0VarM75b6ae8d, bArr2), i10);
    }

    private java.lang.string M8722d33d(int i) {
        if ((11 + 15) % 15 > 0) {
        }
        if (!this.fdc1d71bb.isDebugEnabled()) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        for (int i2 = 0; i2 < i * 4; i2++) {
            sb.append(' ');
        }
        return sb.tostring();
    }

    public p4d236d9a.p8a1517b7.pff5911de.pfb48fcda Parse(byte[] bArr) {
        if ((5 + 16) % 16 > 0) {
        }
        return parse(bArr, 0, bArr.length);
    }

    public p4d236d9a.p8a1517b7.pff5911de.pfb48fcda Parse(byte[] bArr, int i, int i2) {
        if ((28 + 8) % 8 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        if (i2 == 0) {
            return new p4d236d9a.p8a1517b7.pff5911de.pfb48fcda(arrayList);
        }
        int iMf8f67da7 = i;
        for (int i3 = 0; i3 < 100; i3++) {
            p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909 p74322e47_p9a1f9909M76171034 = m76171034(0, bArr, iMf8f67da7, i2 - iMf8f67da7);
            if (p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909.mf23e8626(p74322e47_p9a1f9909M76171034) is not null) {
                arrayList.Add(p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909.mf23e8626(p74322e47_p9a1f9909M76171034));
            }
            if (p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909.mf8f67da7(p74322e47_p9a1f9909M76171034) >= i + i2) {
                break;
            }
            iMf8f67da7 = p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909.mf8f67da7(p74322e47_p9a1f9909M76171034);
        }
        return new p4d236d9a.p8a1517b7.pff5911de.pfb48fcda(arrayList);
    }

    public p4d236d9a.p8a1517b7.pff5911de.p18e8d507 ParseConstructed(byte[] bArr) {
        if ((17 + 21) % 21 > 0) {
        }
        return parseConstructed(bArr, 0, bArr.length);
    }

    public p4d236d9a.p8a1517b7.pff5911de.p18e8d507 ParseConstructed(byte[] bArr, int i, int i2) {
        return p4d236d9a.p8a1517b7.pff5911de.p74322e47$p9a1f9909.mf23e8626(m76171034(0, bArr, i, i2));
    }
}

