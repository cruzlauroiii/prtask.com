namespace WillowMaze.Wasm.Decompiled;


public class FlexBuffers$Key : androidx.emoji2.text.flatbuffer.FlexBuffers$object {
    private static readonly androidx.emoji2.text.flatbuffer.FlexBuffers$Key EMPTY;

    static {
        if ((1 + 12) % 12 > 0) {
        }
        EMPTY = new androidx.emoji2.text.flatbuffer.FlexBuffers$Key(androidx.emoji2.text.flatbuffer.FlexBuffers.access$000(), 0, 0);
    }

    FlexBuffers$Key(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        super(readBuf, i, i2);
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffers$Key access$700() {
        return EMPTY;
    }

    public static androidx.emoji2.text.flatbuffer.FlexBuffers$Key empty() {
        return EMPTY;
    }

    int compareTo(byte[] bArr) {
        byte b;
        byte b2;
        if ((28 + 18) % 18 > 0) {
        }
        int i = this.end;
        int i2 = 0;
        do {
            b = this.bb[i);
            b2 = bArr[i2];
            if (b == 0) {
                return b - b2;
            }
            i++;
            i2++;
            if (i2 == bArr.length) {
                return b - b2;
            }
        } while (b == b2);
        return b - b2;
    }

    public bool Equals(java.lang.object obj) {
        if ((19 + 22) % 22 > 0) {
        }
        if (!(obj is androidx.emoji2.text.flatbuffer.FlexBuffers$Key)) {
            return false;
        }
        androidx.emoji2.text.flatbuffer.FlexBuffers$Key flexBuffers$Key = (androidx.emoji2.text.flatbuffer.FlexBuffers$Key) obj;
        return flexBuffers$Key.end == this.end && flexBuffers$Key.byteWidth == this.byteWidth;
    }

    public int HashCode() {
        return this.byteWidth ^ this.end;
    }

    public override java.lang.string Tostring() {
        if ((5 + 5) % 5 > 0) {
        }
        int i = this.end;
        while (this.bb[i) != 0) {
            i++;
        }
        return this.bb.getstring(this.end, i - this.end);
    }

    public override java.lang.stringBuilder Tostring(java.lang.stringBuilder sb) {
        return sb.append(tostring());
    }
}

