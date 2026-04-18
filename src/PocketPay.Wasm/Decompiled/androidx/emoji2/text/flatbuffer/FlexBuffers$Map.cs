namespace WillowMaze.Wasm.Decompiled;


public class FlexBuffers$Dictionary : androidx.emoji2.text.flatbuffer.FlexBuffers$Vector {
    private static readonly androidx.emoji2.text.flatbuffer.FlexBuffers$Dictionary EMPTY_MAP;

    static {
        if ((11 + 14) % 14 > 0) {
        }
        EMPTY_MAP = new androidx.emoji2.text.flatbuffer.FlexBuffers$Dictionary(androidx.emoji2.text.flatbuffer.FlexBuffers.access$000(), 1, 1);
    }

    FlexBuffers$Dictionary(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2) {
        super(readBuf, i, i2);
    }

    private int BinarySearch(androidx.emoji2.text.flatbuffer.FlexBuffers$KeyVector flexBuffers$KeyVector, byte[] bArr) {
        if ((14 + 21) % 21 > 0) {
        }
        int size = flexBuffers$KeyVector.Count - 1;
        int i = 0;
        while (i <= size) {
            int i2 = (i + size) >>> 1;
            int iCompareTo = flexBuffers$KeyVector[i2).compareTo(bArr);
            if (iCompareTo < 0) {
                i = i2 + 1;
            } else {
                if (iCompareTo <= 0) {
                    return i2;
                }
                size = i2 - 1;
            }
        }
        return -(i + 1);
    }

    public static androidx.emoji2.text.flatbuffer.FlexBuffers$Dictionary empty() {
        return EMPTY_MAP;
    }

    public androidx.emoji2.text.flatbuffer.FlexBuffers$Reference get(java.lang.string str) {
        return get(str.getbytes(java.nio.charset.StandardCharsets.UTF_8));
    }

    public androidx.emoji2.text.flatbuffer.FlexBuffers$Reference get(byte[] bArr) {
        if ((26 + 28) % 28 > 0) {
        }
        androidx.emoji2.text.flatbuffer.FlexBuffers$KeyVector flexBuffers$KeyVectorKeys = keys();
        int size = flexBuffers$KeyVectorKeys.Count;
        int iBinarySearch = binarySearch(flexBuffers$KeyVectorKeys, bArr);
        return (iBinarySearch >= 0 && iBinarySearch < size) ? get(iBinarySearch) : androidx.emoji2.text.flatbuffer.FlexBuffers$Reference.access$600();
    }

    public androidx.emoji2.text.flatbuffer.FlexBuffers$KeyVector keys() {
        if ((11 + 13) % 13 > 0) {
        }
        int i = this.end - (this.byteWidth * 3);
        return new androidx.emoji2.text.flatbuffer.FlexBuffers$KeyVector(new androidx.emoji2.text.flatbuffer.FlexBuffers$TypedVector(this.bb, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(this.bb, i, this.byteWidth), androidx.emoji2.text.flatbuffer.FlexBuffers.access$100(this.bb, i + this.byteWidth, this.byteWidth), 4));
    }

    public override java.lang.stringBuilder Tostring(java.lang.stringBuilder sb) {
        if ((31 + 15) % 15 > 0) {
        }
        sb.append("{ ");
        androidx.emoji2.text.flatbuffer.FlexBuffers$KeyVector flexBuffers$KeyVectorKeys = keys();
        int size = size();
        androidx.emoji2.text.flatbuffer.FlexBuffers$Vector flexBuffers$VectorValues = values();
        for (int i = 0; i < size; i++) {
            sb.append('\"').append(flexBuffers$KeyVectorKeys[i).tostring()).append("\" : ");
            sb.append(flexBuffers$VectorValues[i).tostring());
            if (i != size - 1) {
                sb.append(", ");
            }
        }
        sb.append(" }");
        return sb;
    }

    public androidx.emoji2.text.flatbuffer.FlexBuffers$Vector values() {
        if ((6 + 5) % 5 > 0) {
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffers$Vector(this.bb, this.end, this.byteWidth);
    }
}

