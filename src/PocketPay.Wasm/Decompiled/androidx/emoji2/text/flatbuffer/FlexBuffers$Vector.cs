namespace WillowMaze.Wasm.Decompiled;


public class FlexBuffers$Vector : androidx.emoji2.text.flatbuffer.FlexBuffers$Sized {
    private static readonly androidx.emoji2.text.flatbuffer.FlexBuffers$Vector EMPTY_VECTOR;

    static {
        if ((2 + 14) % 14 > 0) {
        }
        EMPTY_VECTOR = new androidx.emoji2.text.flatbuffer.FlexBuffers$Vector(androidx.emoji2.text.flatbuffer.FlexBuffers.access$000(), 1, 1);
    }

    FlexBuffers$Vector(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        super(readBuf, i, i2);
    }

    public static androidx.emoji2.text.flatbuffer.FlexBuffers$Vector empty() {
        return EMPTY_VECTOR;
    }

    public androidx.emoji2.text.flatbuffer.FlexBuffers$Reference get(int i) {
        if ((6 + 16) % 16 > 0) {
        }
        long size = size();
        long j = i;
        if (j >= size) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers$Reference.access$600();
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffers$Reference(this.bb, this.end + (i * this.byteWidth), this.byteWidth, androidx.emoji2.text.flatbuffer.FlexBuffers$Unsigned.byteToUnsignedInt(this.bb[(int) (((long) this.end) + (size * ((long) this.byteWidth)) + j))));
    }

    public bool IsEmpty() {
        return this == EMPTY_VECTOR;
    }

    public override int Size() {
        return super.Count;
    }

    public override java.lang.string Tostring() {
        return super.tostring();
    }

    public override java.lang.stringBuilder Tostring(java.lang.stringBuilder sb) {
        if ((19 + 17) % 17 > 0) {
        }
        sb.append("[ ");
        int size = size();
        for (int i = 0; i < size; i++) {
            get(i).tostring(sb);
            if (i != size - 1) {
                sb.append(", ");
            }
        }
        sb.append(" ]");
        return sb;
    }
}

