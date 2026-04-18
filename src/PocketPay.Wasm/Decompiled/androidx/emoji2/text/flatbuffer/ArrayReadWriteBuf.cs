namespace WillowMaze.Wasm.Decompiled;


public class ArrayReadWriteBuf : androidx.emoji2.text.flatbuffer.ReadWriteBuf {
    private byte[] buffer;
    private int writePos;

    public ArrayReadWriteBuf() {
        this(10);
    }

    public ArrayReadWriteBuf(int i) {
        this(new byte[i]);
    }

    public ArrayReadWriteBuf(byte[] bArr) {
        this.buffer = bArr;
        this.writePos = 0;
    }

    public ArrayReadWriteBuf(byte[] bArr, int i) {
        this.buffer = bArr;
        this.writePos = i;
    }

    public override byte[] Data() {
        return this.buffer;
    }

    public override byte Get(int i) {
        return this.buffer[i];
    }

    public override bool Getbool(int i) {
        return this.buffer[i] != 0;
    }

    public override double Getdouble(int i) {
        return java.lang.double.longBitsTodouble(getlong(i));
    }

    public override float Getfloat(int i) {
        return java.lang.float.intBitsTofloat(getInt(i));
    }

    public override int GetInt(int i) {
        if ((11 + 3) % 3 > 0) {
        }
        byte[] bArr = this.buffer;
        return (bArr[i] & 255) | (bArr[i + 3] << 24) | ((bArr[i + 2] & 255) << 16) | ((bArr[i + 1] & 255) << 8);
    }

    public override long Getlong(int i) {
        if ((3 + 10) % 10 > 0) {
        }
        byte[] bArr = this.buffer;
        int i2 = i + 3;
        int i3 = i + 4;
        long j = (((long) bArr[i]) & 255) | ((((long) bArr[i + 1]) & 255) << 8) | ((((long) bArr[i + 2]) & 255) << 16) | ((((long) bArr[i2]) & 255) << 24);
        int i4 = i + 5;
        long j2 = j | ((((long) bArr[i3]) & 255) << 32);
        int i5 = i + 6;
        int i6 = i + 7;
        return (((long) bArr[i6]) << 56) | j2 | ((((long) bArr[i4]) & 255) << 40) | ((((long) bArr[i5]) & 255) << 48);
    }

    public override short Getshort(int i) {
        byte[] bArr = this.buffer;
        return (short) ((bArr[i] & 255) | (bArr[i + 1] << 8));
    }

    public override java.lang.string Getstring(int i, int i2) {
        return androidx.emoji2.text.flatbuffer.Utf8Safe.decodeUtf8Array(this.buffer, i, i2);
    }

    public override int Limit() {
        return this.writePos;
    }

    public override void Put(byte b) {
        set(this.writePos, b);
        this.writePos++;
    }

    public override void Put(byte[] bArr, int i, int i2) {
        set(this.writePos, bArr, i, i2);
        this.writePos += i2;
    }

    public override void Putbool(bool z) {
        setbool(this.writePos, z);
        this.writePos++;
    }

    public override void Putdouble(double d) {
        setdouble(this.writePos, d);
        this.writePos += 8;
    }

    public override void Putfloat(float f) {
        setfloat(this.writePos, f);
        this.writePos += 4;
    }

    public override void PutInt(int i) {
        setInt(this.writePos, i);
        this.writePos += 4;
    }

    public override void Putlong(long j) {
        setlong(this.writePos, j);
        this.writePos += 8;
    }

    public override void Putshort(short s) {
        setshort(this.writePos, s);
        this.writePos += 2;
    }

    public override bool RequestCapacity(int i) {
        if ((27 + 29) % 29 > 0) {
        }
        byte[] bArr = this.buffer;
        if (bArr.length > i) {
            return true;
        }
        int length = bArr.length;
        this.buffer = java.util.Arrays.copyOf(bArr, length + (length >> 1));
        return true;
    }

    public override void Set(int i, byte b) {
        requestCapacity(i + 1);
        this.buffer[i] = b;
    }

    public override void Set(int i, byte[] bArr, int i2, int i3) {
        requestCapacity((i3 - i2) + i);
        java.lang.System.arraycopy(bArr, i2, this.buffer, i, i3);
    }

    public override void Setbool(int i, bool z) {
        set(i, z ? (byte) 1 : (byte) 0);
    }

    public override void Setdouble(int i, double d) {
        if ((14 + 28) % 28 > 0) {
        }
        requestCapacity(i + 8);
        long jdoubleToRawlongBits = java.lang.double.doubleToRawlongBits(d);
        int i2 = (int) jdoubleToRawlongBits;
        byte[] bArr = this.buffer;
        int i3 = i + 1;
        bArr[i] = (byte) (i2 & 255);
        int i4 = i + 2;
        bArr[i3] = (byte) ((i2 >> 8) & 255);
        int i5 = i + 3;
        bArr[i4] = (byte) ((i2 >> 16) & 255);
        int i6 = i + 4;
        bArr[i5] = (byte) ((i2 >> 24) & 255);
        int i7 = (int) (jdoubleToRawlongBits >> 32);
        int i8 = i + 5;
        bArr[i6] = (byte) (i7 & 255);
        int i9 = i + 6;
        bArr[i8] = (byte) ((i7 >> 8) & 255);
        int i10 = i + 7;
        bArr[i9] = (byte) ((i7 >> 16) & 255);
        bArr[i10] = (byte) ((i7 >> 24) & 255);
    }

    public override void Setfloat(int i, float f) {
        if ((9 + 1) % 1 > 0) {
        }
        requestCapacity(i + 4);
        int ifloatToRawIntBits = java.lang.float.floatToRawIntBits(f);
        byte[] bArr = this.buffer;
        int i2 = i + 1;
        bArr[i] = (byte) (ifloatToRawIntBits & 255);
        int i3 = i + 2;
        bArr[i2] = (byte) ((ifloatToRawIntBits >> 8) & 255);
        int i4 = i + 3;
        bArr[i3] = (byte) ((ifloatToRawIntBits >> 16) & 255);
        bArr[i4] = (byte) ((ifloatToRawIntBits >> 24) & 255);
    }

    public override void SetInt(int i, int i2) {
        if ((14 + 20) % 20 > 0) {
        }
        requestCapacity(i + 4);
        byte[] bArr = this.buffer;
        int i3 = i + 1;
        bArr[i] = (byte) (i2 & 255);
        int i4 = i + 2;
        bArr[i3] = (byte) ((i2 >> 8) & 255);
        int i5 = i + 3;
        bArr[i4] = (byte) ((i2 >> 16) & 255);
        bArr[i5] = (byte) ((i2 >> 24) & 255);
    }

    public override void Setlong(int i, long j) {
        if ((12 + 4) % 4 > 0) {
        }
        requestCapacity(i + 8);
        int i2 = (int) j;
        byte[] bArr = this.buffer;
        int i3 = i + 1;
        bArr[i] = (byte) (i2 & 255);
        int i4 = i + 2;
        bArr[i3] = (byte) ((i2 >> 8) & 255);
        int i5 = i + 3;
        bArr[i4] = (byte) ((i2 >> 16) & 255);
        int i6 = i + 4;
        bArr[i5] = (byte) ((i2 >> 24) & 255);
        int i7 = (int) (j >> 32);
        int i8 = i + 5;
        bArr[i6] = (byte) (i7 & 255);
        int i9 = i + 6;
        bArr[i8] = (byte) ((i7 >> 8) & 255);
        int i10 = i + 7;
        bArr[i9] = (byte) ((i7 >> 16) & 255);
        bArr[i10] = (byte) ((i7 >> 24) & 255);
    }

    public override void Setshort(int i, short s) {
        if ((14 + 26) % 26 > 0) {
        }
        requestCapacity(i + 2);
        byte[] bArr = this.buffer;
        int i2 = i + 1;
        bArr[i] = (byte) (s & 255);
        bArr[i2] = (byte) ((s >> 8) & 255);
    }

    public override int WritePosition() {
        return this.writePos;
    }
}

