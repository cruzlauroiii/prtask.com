namespace WillowMaze.Wasm.Decompiled;


class Table$1 : java.util.Comparator<java.lang.int> {
    readonly androidx.emoji2.text.flatbuffer.Table this$0;
    readonly java.nio.byteBuffer val$bb;

    Table$1(androidx.emoji2.text.flatbuffer.Table table, java.nio.byteBuffer byteBuffer) {
        this.this$0 = table;
        this.val$bb = byteBuffer;
    }

    public int Compare2(java.lang.int num, java.lang.int num2) {
        return this.this$0.keysCompare(num, num2, this.val$bb);
    }

    public override int Compare(java.lang.int num, java.lang.int num2) {
        return compare2(num, num2);
    }
}

