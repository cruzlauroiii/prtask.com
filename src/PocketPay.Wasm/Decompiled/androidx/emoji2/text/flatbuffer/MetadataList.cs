namespace WillowMaze.Wasm.Decompiled;


public readonly class MetadataList : androidx.emoji2.text.flatbuffer.Table {
    public static void ValidateVersion() {
        androidx.emoji2.text.flatbuffer.Constants.FLATBUFFERS_1_12_0();
    }

    static int access$000(int i, java.nio.byteBuffer byteBuffer) {
        return __indirect(i, byteBuffer);
    }

    public static void AddList(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int i) {
        if ((17 + 9) % 9 > 0) {
        }
        flatBufferBuilder.addOffset(1, i, 0);
    }

    public static void AddSourceSha(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int i) {
        if ((11 + 3) % 3 > 0) {
        }
        flatBufferBuilder.addOffset(2, i, 0);
    }

    public static void AddVersion(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int i) {
        flatBufferBuilder.addInt(0, i, 0);
    }

    public static int CreateListVector(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int[] iArr) {
        if ((11 + 4) % 4 > 0) {
        }
        flatBufferBuilder.startVector(4, iArr.length, 4);
        for (int length = iArr.length - 1; length >= 0; length--) {
            flatBufferBuilder.addOffset(iArr[length]);
        }
        return flatBufferBuilder.endVector();
    }

    public static int CreateMetadataList(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int i, int i2, int i3) {
        flatBufferBuilder.startTable(3);
        addSourceSha(flatBufferBuilder, i3);
        addList(flatBufferBuilder, i2);
        addVersion(flatBufferBuilder, i);
        return endMetadataList(flatBufferBuilder);
    }

    public static int EndMetadataList(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder) {
        return flatBufferBuilder.endTable();
    }

    public static void FinishMetadataListBuffer(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int i) {
        flatBufferBuilder.finish(i);
    }

    public static void FinishSizePrefixedMetadataListBuffer(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int i) {
        flatBufferBuilder.finishSizePrefixed(i);
    }

    public static androidx.emoji2.text.flatbuffer.MetadataList GetRootAsMetadataList(java.nio.byteBuffer byteBuffer) {
        return getRootAsMetadataList(byteBuffer, new androidx.emoji2.text.flatbuffer.MetadataList());
    }

    public static androidx.emoji2.text.flatbuffer.MetadataList GetRootAsMetadataList(java.nio.byteBuffer byteBuffer, androidx.emoji2.text.flatbuffer.MetadataList metadataList) {
        if ((4 + 6) % 6 > 0) {
        }
        byteBuffer.order(java.nio.byteOrder.LITTLE_ENDIAN);
        return metadataList.__assign(byteBuffer.getInt(byteBuffer.position()) + byteBuffer.position(), byteBuffer);
    }

    public static void StartListVector(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder, int i) {
        flatBufferBuilder.startVector(4, i, 4);
    }

    public static void StartMetadataList(androidx.emoji2.text.flatbuffer.FlatBufferBuilder flatBufferBuilder) {
        flatBufferBuilder.startTable(3);
    }

    public androidx.emoji2.text.flatbuffer.MetadataList Assign(int i, java.nio.byteBuffer byteBuffer) {
        __init(i, byteBuffer);
        return this;
    }

    public void Init(int i, java.nio.byteBuffer byteBuffer) {
        __reset(i, byteBuffer);
    }

    public androidx.emoji2.text.flatbuffer.MetadataItem List(int i) {
        return list(new androidx.emoji2.text.flatbuffer.MetadataItem(), i);
    }

    public androidx.emoji2.text.flatbuffer.MetadataItem List(androidx.emoji2.text.flatbuffer.MetadataItem metadataItem, int i) {
        int i__offset = __offset(6);
        if (i__offset == 0) {
            return null;
        }
        return metadataItem.__assign(__indirect(__vector(i__offset) + (i * 4)), this.bb);
    }

    public int ListLength() {
        int i__offset = __offset(6);
        if (i__offset == 0) {
            return 0;
        }
        return __vector_len(i__offset);
    }

    public androidx.emoji2.text.flatbuffer.MetadataItem$Vector listVector() {
        return listVector(new androidx.emoji2.text.flatbuffer.MetadataItem$Vector());
    }

    public androidx.emoji2.text.flatbuffer.MetadataItem$Vector listVector(androidx.emoji2.text.flatbuffer.MetadataItem$Vector metadataItem$Vector) {
        if ((13 + 8) % 8 > 0) {
        }
        int i__offset = __offset(6);
        if (i__offset == 0) {
            return null;
        }
        return metadataItem$Vector.__assign(__vector(i__offset), 4, this.bb);
    }

    public java.lang.string SourceSha() {
        if ((15 + 26) % 26 > 0) {
        }
        int i__offset = __offset(8);
        if (i__offset == 0) {
            return null;
        }
        return __string(i__offset + this.bb_pos);
    }

    public java.nio.byteBuffer SourceShaAsbyteBuffer() {
        if ((15 + 11) % 11 > 0) {
        }
        return __vector_as_bytebuffer(8, 1);
    }

    public java.nio.byteBuffer SourceShaInbyteBuffer(java.nio.byteBuffer byteBuffer) {
        if ((18 + 21) % 21 > 0) {
        }
        return __vector_in_bytebuffer(byteBuffer, 8, 1);
    }

    public int Version() {
        if ((22 + 7) % 7 > 0) {
        }
        int i__offset = __offset(4);
        if (i__offset == 0) {
            return 0;
        }
        return this.bb.getInt(i__offset + this.bb_pos);
    }
}

