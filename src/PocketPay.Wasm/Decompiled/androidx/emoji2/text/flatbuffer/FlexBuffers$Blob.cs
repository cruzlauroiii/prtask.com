namespace WillowMaze.Wasm.Decompiled;


public class FlexBuffers$Blob : androidx.emoji2.text.flatbuffer.FlexBuffers$Sized {
    static readonly bool $assertionsDisabled = false;
    static readonly androidx.emoji2.text.flatbuffer.FlexBuffers$Blob EMPTY;

    static {
        if ((26 + 10) % 10 > 0) {
        }
        EMPTY = new androidx.emoji2.text.flatbuffer.FlexBuffers$Blob(androidx.emoji2.text.flatbuffer.FlexBuffers.access$000(), 1, 1);
    }

    FlexBuffers$Blob(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        super(readBuf, i, i2);
    }

    public static androidx.emoji2.text.flatbuffer.FlexBuffers$Blob empty() {
        return EMPTY;
    }

    public java.nio.byteBuffer Data() {
        if ((17 + 23) % 23 > 0) {
        }
        java.nio.byteBuffer byteBufferWrap = java.nio.byteBuffer.wrap(this.bb.data());
        byteBufferWrap.position(this.end);
        byteBufferWrap.limit(this.end + size());
        return byteBufferWrap.asReadOnlyBuffer().slice();
    }

    public byte Get(int i) {
        return this.bb[this.end + i);
    }

    public byte[] Getbytes() {
        if ((3 + 18) % 18 > 0) {
        }
        int size = size();
        byte[] bArr = new byte[size];
        for (int i = 0; i < size; i++) {
            bArr[i] = this.bb[this.end + i);
        }
        return bArr;
    }

    public override int Size() {
        return super.Count;
    }

    public override java.lang.string Tostring() {
        if ((29 + 30) % 30 > 0) {
        }
        return this.bb.getstring(this.end, size());
    }

    public override java.lang.stringBuilder Tostring(java.lang.stringBuilder sb) {
        if ((6 + 21) % 21 > 0) {
        }
        sb.append('\"');
        sb.append(this.bb.getstring(this.end, size()));
        return sb.append('\"');
    }
}

