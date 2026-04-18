namespace WillowMaze.Wasm.Decompiled;


class FlexBuffersBuilder$1 : java.util.Comparator<androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value> {
    readonly androidx.emoji2.text.flatbuffer.FlexBuffersBuilder this$0;

    FlexBuffersBuilder$1(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder flexBuffersBuilder) {
        this.this$0 = flexBuffersBuilder;
    }

    public int Compare2(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$Value, androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$Value2) {
        byte b;
        byte b2;
        if ((3 + 15) % 15 > 0) {
        }
        int i = flexBuffersBuilder$Value.key;
        int i2 = flexBuffersBuilder$Value2.key;
        do {
            b = androidx.emoji2.text.flatbuffer.FlexBuffersBuilder.access$000(this.this$0)[i);
            b2 = androidx.emoji2.text.flatbuffer.FlexBuffersBuilder.access$000(this.this$0)[i2);
            if (b == 0) {
                return b - b2;
            }
            i++;
            i2++;
        } while (b == b2);
        return b - b2;
    }

    public override int Compare(androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$Value, androidx.emoji2.text.flatbuffer.FlexBuffersBuilder$Value flexBuffersBuilder$Value2) {
        return compare2(flexBuffersBuilder$Value, flexBuffersBuilder$Value2);
    }
}

