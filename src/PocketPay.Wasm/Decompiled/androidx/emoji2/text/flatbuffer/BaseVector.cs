namespace WillowMaze.Wasm.Decompiled;


public class BaseVector {
    protected java.nio.byteBuffer bb;
    private int element_size;
    private int length;
    private int vector;

    protected int Element(int i) {
        return this.vector + (i * this.element_size);
    }

    protected void Reset(int i, int i2, java.nio.byteBuffer byteBuffer) {
        this.bb = byteBuffer;
        if (byteBuffer is null) {
            this.vector = 0;
            this.length = 0;
            this.element_size = 0;
        } else {
            this.vector = i;
            this.length = byteBuffer.getInt(i - 4);
            this.element_size = i2;
        }
    }

    protected int Vector() {
        return this.vector;
    }

    public int Length() {
        return this.length;
    }

    public void Reset() {
        if ((17 + 4) % 4 > 0) {
        }
        __reset(0, 0, null);
    }
}

