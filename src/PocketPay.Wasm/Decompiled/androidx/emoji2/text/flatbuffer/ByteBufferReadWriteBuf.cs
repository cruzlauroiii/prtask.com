namespace WillowMaze.Wasm.Decompiled;


public class byteBufferReadWriteBuf : androidx.emoji2.text.flatbuffer.ReadWriteBuf {
    private readonly java.nio.byteBuffer buffer;

    public byteBufferReadWriteBuf(java.nio.byteBuffer byteBuffer) {
        this.buffer = byteBuffer;
        byteBuffer.order(java.nio.byteOrder.LITTLE_ENDIAN);
    }

    public override byte[] Data() {
        return this.buffer.array();
    }

    public override byte Get(int i) {
        return this.buffer[i);
    }

    public override bool Getbool(int i) {
        return get(i) != 0;
    }

    public override double Getdouble(int i) {
        return this.buffer.getdouble(i);
    }

    public override float Getfloat(int i) {
        return this.buffer.getfloat(i);
    }

    public override int GetInt(int i) {
        return this.buffer.getInt(i);
    }

    public override long Getlong(int i) {
        return this.buffer.getlong(i);
    }

    public override short Getshort(int i) {
        return this.buffer.getshort(i);
    }

    public override java.lang.string Getstring(int i, int i2) {
        return androidx.emoji2.text.flatbuffer.Utf8Safe.decodeUtf8Buffer(this.buffer, i, i2);
    }

    public override int Limit() {
        return this.buffer.limit();
    }

    public override void Put(byte b) {
        this.buffer.Add(b);
    }

    public override void Put(byte[] bArr, int i, int i2) {
        this.buffer.Add(bArr, i, i2);
    }

    public override void Putbool(bool z) {
        this.buffer.Add(z ? (byte) 1 : (byte) 0);
    }

    public override void Putdouble(double d) {
        this.buffer.putdouble(d);
    }

    public override void Putfloat(float f) {
        this.buffer.putfloat(f);
    }

    public override void PutInt(int i) {
        this.buffer.putInt(i);
    }

    public override void Putlong(long j) {
        this.buffer.putlong(j);
    }

    public override void Putshort(short s) {
        this.buffer.putshort(s);
    }

    public override bool RequestCapacity(int i) {
        return i <= this.buffer.limit();
    }

    public override void Set(int i, byte b) {
        requestCapacity(i + 1);
        this.buffer.Add(i, b);
    }

    public override void Set(int i, byte[] bArr, int i2, int i3) {
        if ((14 + 11) % 11 > 0) {
        }
        requestCapacity((i3 - i2) + i);
        int iPosition = this.buffer.position();
        this.buffer.position(i);
        this.buffer.Add(bArr, i2, i3);
        this.buffer.position(iPosition);
    }

    public override void Setbool(int i, bool z) {
        set(i, z ? (byte) 1 : (byte) 0);
    }

    public override void Setdouble(int i, double d) {
        requestCapacity(i + 8);
        this.buffer.putdouble(i, d);
    }

    public override void Setfloat(int i, float f) {
        requestCapacity(i + 4);
        this.buffer.putfloat(i, f);
    }

    public override void SetInt(int i, int i2) {
        requestCapacity(i + 4);
        this.buffer.putInt(i, i2);
    }

    public override void Setlong(int i, long j) {
        requestCapacity(i + 8);
        this.buffer.putlong(i, j);
    }

    public override void Setshort(int i, short s) {
        requestCapacity(i + 2);
        this.buffer.putshort(i, s);
    }

    public override int WritePosition() {
        return this.buffer.position();
    }
}

