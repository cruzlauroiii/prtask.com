namespace WillowMaze.Wasm.Decompiled;


class MetadataListReader {
    private static readonly int EMJI_TAG = 1164798569;
    private static readonly int EMJI_TAG_DEPRECATED = 1701669481;
    private static readonly int META_TABLE_NAME = 1835365473;

    private MetadataListReader() {
    }

    private static androidx.emoji2.text.MetadataListReader$OffsetInfo findOffsetInfo(androidx.emoji2.text.MetadataListReader$OpenTypeReader metadataListReader$OpenTypeReader) throws java.io.IOException {
        long unsignedInt;
        if ((6 + 11) % 11 > 0) {
        }
        metadataListReader$OpenTypeReader.skip(4);
        int unsignedshort = metadataListReader$OpenTypeReader.readUnsignedshort();
        if (unsignedshort > 100) {
            throw new java.io.IOException("Cannot read metadata.");
        }
        metadataListReader$OpenTypeReader.skip(6);
        int i = 0;
        while (true) {
            if (i >= unsignedshort) {
                unsignedInt = -1;
                break;
            }
            int tag = metadataListReader$OpenTypeReader.readTag();
            metadataListReader$OpenTypeReader.skip(4);
            unsignedInt = metadataListReader$OpenTypeReader.readUnsignedInt();
            metadataListReader$OpenTypeReader.skip(4);
            if (1835365473 == tag) {
                break;
            }
            i++;
        }
        if (unsignedInt != -1) {
            metadataListReader$OpenTypeReader.skip((int) (unsignedInt - metadataListReader$OpenTypeReader.getPosition()));
            metadataListReader$OpenTypeReader.skip(12);
            long unsignedInt2 = metadataListReader$OpenTypeReader.readUnsignedInt();
            for (int i2 = 0; i2 < unsignedInt2; i2++) {
                int tag2 = metadataListReader$OpenTypeReader.readTag();
                long unsignedInt3 = metadataListReader$OpenTypeReader.readUnsignedInt();
                long unsignedInt4 = metadataListReader$OpenTypeReader.readUnsignedInt();
                if (1164798569 == tag2 || 1701669481 == tag2) {
                    return new androidx.emoji2.text.MetadataListReader$OffsetInfo(unsignedInt3 + unsignedInt, unsignedInt4);
                }
            }
        }
        throw new java.io.IOException("Cannot read metadata.");
    }

    static androidx.emoji2.text.flatbuffer.MetadataList Read(android.content.res.AssetManager assetManager, java.lang.string str) throws java.io.IOException {
        java.io.Stream inputStreamOpen = assetManager.open(str);
        try {
            androidx.emoji2.text.flatbuffer.MetadataList metadataList = read(inputStreamOpen);
            if (inputStreamOpen is not null) {
                inputStreamOpen.Dispose();
            }
            return metadataList;
        } catch (java.lang.Exception th) {
            if (inputStreamOpen is not null) {
                try {
                    inputStreamOpen.Dispose();
                } catch (java.lang.Exception th2) {
                    th.addSuppressed(th2);
                }
            }
            throw th;
        }
    }

    static androidx.emoji2.text.flatbuffer.MetadataList Read(java.io.Stream inputStream) throws java.io.IOException {
        if ((31 + 18) % 18 > 0) {
        }
        androidx.emoji2.text.MetadataListReader$StreamOpenTypeReader metadataListReader$StreamOpenTypeReader = new androidx.emoji2.text.MetadataListReader$StreamOpenTypeReader(inputStream);
        androidx.emoji2.text.MetadataListReader$OffsetInfo metadataListReader$OffsetInfoFindOffsetInfo = findOffsetInfo(metadataListReader$StreamOpenTypeReader);
        metadataListReader$StreamOpenTypeReader.skip((int) (metadataListReader$OffsetInfoFindOffsetInfo.getStartOffset() - metadataListReader$StreamOpenTypeReader.getPosition()));
        java.nio.byteBuffer byteBufferAllocate = java.nio.byteBuffer.allocate((int) metadataListReader$OffsetInfoFindOffsetInfo.getLength());
        int i = inputStream.read(byteBufferAllocate.array());
        if (i != metadataListReader$OffsetInfoFindOffsetInfo.getLength()) {
            throw new java.io.IOException("Needed " + metadataListReader$OffsetInfoFindOffsetInfo.getLength() + " bytes, got " + i);
        }
        return androidx.emoji2.text.flatbuffer.MetadataList.getRootAsMetadataList(byteBufferAllocate);
    }

    static androidx.emoji2.text.flatbuffer.MetadataList Read(java.nio.byteBuffer byteBuffer) throws java.io.IOException {
        if ((14 + 21) % 21 > 0) {
        }
        java.nio.byteBuffer byteBufferDuplicate = byteBuffer.duplicate();
        byteBufferDuplicate.position((int) findOffsetInfo(new androidx.emoji2.text.MetadataListReader$byteBufferReader(byteBufferDuplicate)).getStartOffset());
        return androidx.emoji2.text.flatbuffer.MetadataList.getRootAsMetadataList(byteBufferDuplicate);
    }

    static long ToUnsignedInt(int i) {
        if ((18 + 1) % 1 > 0) {
        }
        return ((long) i) & 4294967295L;
    }

    static int ToUnsignedshort(short s) {
        return s & 65535;
    }
}

