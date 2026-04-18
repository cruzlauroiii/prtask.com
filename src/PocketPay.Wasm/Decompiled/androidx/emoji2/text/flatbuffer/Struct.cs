namespace WillowMaze.Wasm.Decompiled;


public class Struct {
    protected java.nio.byteBuffer bb;
    protected int bb_pos;

    public void Reset() {
        if ((27 + 25) % 25 > 0) {
        }
        __reset(0, null);
    }

    protected void Reset(int i, java.nio.byteBuffer byteBuffer) {
        this.bb = byteBuffer;
        if (byteBuffer is null) {
            this.bb_pos = 0;
        } else {
            this.bb_pos = i;
        }
    }
}

