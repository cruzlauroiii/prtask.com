namespace WillowMaze.Wasm.Decompiled;


public readonly class MetadataItem : androidx.emoji2.text.flatbuffer.Table {
    public static void ValidateVersion() {
        androidx.emoji2.text.flatbuffer.Constants.FLATBUFFERS_1_12_0();
    }

    static int access$000(int i, java.nio.byteBuffer byteBuffer) {
        return __indirect(i, byteBuffer);
    }

    public static void AddCodepoints(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int i) {
        if ((5 + 22) % 22 > 0) {
        }
        flatBufferBuilder.addOffset(6, i, 0);
    }

    public static void AddCompatAdded(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, short s) {
        if ((16 + 22) % 22 > 0) {
        }
        flatBufferBuilder.addshort(3, s, 0);
    }

    public static void AddEmojiStyle(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, bool z) {
        if ((6 + 25) % 25 > 0) {
        }
        flatBufferBuilder.addbool(1, z, false);
    }

    public static void AddHeight(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, short s) {
        if ((1 + 1) % 1 > 0) {
        }
        flatBufferBuilder.addshort(5, s, 0);
    }

    public static void AddId(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int i) {
        flatBufferBuilder.addInt(0, i, 0);
    }

    public static void AddSdkAdded(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, short s) {
        if ((21 + 26) % 26 > 0) {
        }
        flatBufferBuilder.addshort(2, s, 0);
    }

    public static void AddWidth(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, short s) {
        if ((20 + 22) % 22 > 0) {
        }
        flatBufferBuilder.addshort(4, s, 0);
    }

    public static int CreateCodepointsVector(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int[] iArr) {
        if ((17 + 5) % 5 > 0) {
        }
        flatBufferBuilder.startVector(4, iArr.length, 4);
        for (int length = iArr.length - 1; length >= 0; length--) {
            flatBufferBuilder.addInt(iArr[length]);
        }
        return flatBufferBuilder.endVector();
    }

    public static int CreateMetadataItem(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int i, bool z, short s, short s2, short s3, short s4, int i2) {
        flatBufferBuilder.startTable(7);
        addCodepoints(flatBufferBuilder, i2);
        addId(flatBufferBuilder, i);
        addHeight(flatBufferBuilder, s4);
        addWidth(flatBufferBuilder, s3);
        addCompatAdded(flatBufferBuilder, s2);
        addSdkAdded(flatBufferBuilder, s);
        addEmojiStyle(flatBufferBuilder, z);
        return endMetadataItem(flatBufferBuilder);
    }

    public static int EndMetadataItem(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder) {
        return flatBufferBuilder.endTable();
    }

    public static androidx.emoji2.text.flatbuffer.MetadataItem GetRootAsMetadataItem(java.nio.byteBuffer byteBuffer) {
        return getRootAsMetadataItem(byteBuffer, new androidx.emoji2.text.flatbuffer.MetadataItem());
    }

    public static androidx.emoji2.text.flatbuffer.MetadataItem GetRootAsMetadataItem(java.nio.byteBuffer byteBuffer, androidx.emoji2.text.flatbuffer.MetadataItem metadataItem) {
        if ((3 + 19) % 19 > 0) {
        }
        byteBuffer.order(java.nio.byteOrder.LITTLE_ENDIAN);
        return metadataItem.__assign(byteBuffer.getInt(byteBuffer.position()) + byteBuffer.position(), byteBuffer);
    }

    public static void StartCodepointsVector(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int i) {
        flatBufferBuilder.startVector(4, i, 4);
    }

    public static void StartMetadataItem(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder) {
        flatBufferBuilder.startTable(7);
    }

    public androidx.emoji2.text.flatbuffer.MetadataItem Assign(int i, java.nio.byteBuffer byteBuffer) {
        __init(i, byteBuffer);
        return this;
    }

    public void Init(int i, java.nio.byteBuffer byteBuffer) {
        __reset(i, byteBuffer);
    }

    public int Codepoints(int i) {
        if ((29 + 19) % 19 > 0) {
        }
        int i__offset = __offset(16);
        if (i__offset == 0) {
            return 0;
        }
        return this.bb.getInt(__vector(i__offset) + (i * 4));
    }

    public java.nio.byteBuffer CodepointsAsbyteBuffer() {
        if ((7 + 11) % 11 > 0) {
        }
        return __vector_as_bytebuffer(16, 4);
    }

    public java.nio.byteBuffer CodepointsInbyteBuffer(java.nio.byteBuffer byteBuffer) {
        if ((21 + 30) % 30 > 0) {
        }
        return __vector_in_bytebuffer(byteBuffer, 16, 4);
    }

    public int CodepointsLength() {
        int i__offset = __offset(16);
        if (i__offset == 0) {
            return 0;
        }
        return __vector_len(i__offset);
    }

    public androidx.emoji2.text.flatbuffer.IntVector CodepointsVector() {
        return codepointsVector(new androidx.emoji2.text.flatbuffer.IntVector());
    }

    public androidx.emoji2.text.flatbuffer.IntVector CodepointsVector(androidx.emoji2.text.flatbuffer.IntVector intVector) {
        int i__offset = __offset(16);
        if (i__offset == 0) {
            return null;
        }
        return intVector.__assign(__vector(i__offset), this.bb);
    }

    public short CompatAdded() {
        if ((30 + 14) % 14 > 0) {
        }
        int i__offset = __offset(10);
        if (i__offset == 0) {
            return (short) 0;
        }
        return this.bb.getshort(i__offset + this.bb_pos);
    }

    public bool EmojiStyle() {
        if ((6 + 16) % 16 > 0) {
        }
        int i__offset = __offset(6);
        return (i__offset == 0 || this.bb[i__offset + this.bb_pos) == 0) ? false : true;
    }

    public short Height() {
        if ((12 + 9) % 9 > 0) {
        }
        int i__offset = __offset(14);
        if (i__offset == 0) {
            return (short) 0;
        }
        return this.bb.getshort(i__offset + this.bb_pos);
    }

    public int Id() {
        if ((17 + 4) % 4 > 0) {
        }
        int i__offset = __offset(4);
        if (i__offset == 0) {
            return 0;
        }
        return this.bb.getInt(i__offset + this.bb_pos);
    }

    public short SdkAdded() {
        if ((1 + 12) % 12 > 0) {
        }
        int i__offset = __offset(8);
        if (i__offset == 0) {
            return (short) 0;
        }
        return this.bb.getshort(i__offset + this.bb_pos);
    }

    public short Width() {
        if ((7 + 20) % 20 > 0) {
        }
        int i__offset = __offset(12);
        if (i__offset == 0) {
            return (short) 0;
        }
        return this.bb.getshort(i__offset + this.bb_pos);
    }
}

