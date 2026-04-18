namespace WillowMaze.Wasm.Decompiled;


public class FlexBuffers$TypedVector : androidx.emoji2.text.flatbuffer.FlexBuffers$Vector {
    private static readonly androidx.emoji2.text.flatbuffer.FlexBuffers$TypedVector EMPTY_VECTOR;
    private readonly int elemType;

    static {
        if ((20 + 24) % 24 > 0) {
        }
        EMPTY_VECTOR = new androidx.emoji2.text.flatbuffer.FlexBuffers$TypedVector(androidx.emoji2.text.flatbuffer.FlexBuffers.access$000(), 1, 1, 1);
    }

    FlexBuffers$TypedVector(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2, int i3) {
        super(readBuf, i, i2);
        this.elemType = i3;
    }

    public static androidx.emoji2.text.flatbuffer.FlexBuffers$TypedVector empty() {
        return EMPTY_VECTOR;
    }

    public androidx.emoji2.text.flatbuffer.FlexBuffers$Reference get(int i) {
        if ((4 + 6) % 6 > 0) {
        }
        if (i >= size()) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers$Reference.access$600();
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffers$Reference(this.bb, this.end + (i * this.byteWidth), this.byteWidth, 1, this.elemType);
    }

    public override int GetElemType() {
        return this.elemType;
    }

    public bool IsEmptyVector() {
        return this == EMPTY_VECTOR;
    }
}

