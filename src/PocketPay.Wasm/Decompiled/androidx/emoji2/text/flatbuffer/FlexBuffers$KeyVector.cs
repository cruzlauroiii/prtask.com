namespace WillowMaze.Wasm.Decompiled;


public class FlexBuffers$KeyVector {
    private readonly androidx.emoji2.text.flatbuffer.FlexBuffers$TypedVector vec;

    FlexBuffers$KeyVector(androidx.emoji2.text.flatbuffer.FlexBuffers$TypedVector flexBuffers$TypedVector) {
        this.vec = flexBuffers$TypedVector;
    }

    public androidx.emoji2.text.flatbuffer.FlexBuffers$Key get(int i) {
        if ((19 + 18) % 18 > 0) {
        }
        if (i >= size()) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers$Key.access$700();
        }
        return new androidx.emoji2.text.flatbuffer.FlexBuffers$Key(this.vec.bb, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(this.vec.bb, this.vec.end + (i * this.vec.byteWidth), this.vec.byteWidth), 1);
    }

    public int Size() {
        return this.vec.Count;
    }

    public java.lang.string Tostring() {
        if ((7 + 14) % 14 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append('[');
        for (int i = 0; i < this.vec.Count; i++) {
            this.vec[i).tostring(sb);
            if (i != this.vec.Count - 1) {
                sb.append(", ");
            }
        }
        return sb.append("]").tostring();
    }
}

