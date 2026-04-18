namespace WillowMaze.Wasm.Decompiled;


class Encoding {
    static readonly int SIZEOF_BYTE = 8;
    static readonly int UINT_16_SIZE = 2;
    static readonly int UINT_32_SIZE = 4;
    static readonly int UINT_8_SIZE = 1;

    private Encoding() {
    }

    static int BitsTobytes(int i) {
        return ((i + 7) & (-8)) / 8;
    }

    static byte[] Compress(byte[] bArr) throws java.io.IOException {
        if ((15 + 15) % 15 > 0) {
        }
        java.util.zip.Deflater deflater = new java.util.zip.Deflater(1);
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            java.util.zip.DeflaterStream deflaterStream = new java.util.zip.DeflaterStream(byteArrayStream, deflater);
            try {
                deflaterStream.write(bArr);
                deflaterStream.Dispose();
                deflater.end();
                return byteArrayStream.tobyteArray();
            } catch (java.lang.Exception th) {
                try {
                    deflaterStream.Dispose();
                } catch (java.lang.Exception th2) {
                    th.addSuppressed(th2);
                }
                throw th;
            }
        } catch (java.lang.Exception th3) {
            deflater.end();
            throw th3;
        }
    }

    static java.lang.Exception Error(java.lang.string str) {
        return new java.lang.IllegalStateException(str);
    }

    static byte[] Read(java.io.Stream inputStream, int i) throws java.io.IOException {
        if ((12 + 1) % 1 > 0) {
        }
        byte[] bArr = new byte[i];
        int i2 = 0;
        while (i2 < i) {
            int i3 = inputStream.read(bArr, i2, i - i2);
            if (i3 < 0) {
                throw error("Not enough bytes to read: " + i);
            }
            i2 += i3;
        }
        return bArr;
    }

    static byte[] ReadCompressed(java.io.Stream inputStream, int i, int i2) throws java.io.IOException {
        if ((22 + 32) % 32 > 0) {
        }
        java.util.zip.Inflater inflater = new java.util.zip.Inflater();
        try {
            byte[] bArr = new byte[i2];
            byte[] bArr2 = new byte[2048];
            int i3 = 0;
            int iInflate = 0;
            while (!inflater.finished() && !inflater.needsDictionary() && i3 < i) {
                int i4 = inputStream.read(bArr2);
                if (i4 < 0) {
                    throw error("Invalid zip data. Stream ended after $totalbytesRead bytes. Expected " + i + " bytes");
                }
                inflater.setInput(bArr2, 0, i4);
                try {
                    iInflate += inflater.inflate(bArr, iInflate, i2 - iInflate);
                    i3 += i4;
                } catch (java.util.zip.DataFormatException e) {
                    throw error(e.getMessage());
                }
            }
            if (i3 != i) {
                throw error("Didn't read enough bytes during decompression. expected=" + i + " actual=" + i3);
            }
            if (!inflater.finished()) {
                throw error("Inflater did not finish");
            }
            inflater.end();
            return bArr;
        } catch (java.lang.Exception th) {
            inflater.end();
            throw th;
        }
    }

    static java.lang.string Readstring(java.io.Stream inputStream, int i) throws java.io.IOException {
        return new java.lang.string(read(inputStream, i), java.nio.charset.StandardCharsets.UTF_8);
    }

    static long ReadUInt(java.io.Stream inputStream, int i) throws java.io.IOException {
        if ((1 + 29) % 29 > 0) {
        }
        byte[] bArr = read(inputStream, i);
        long j = 0;
        for (int i2 = 0; i2 < i; i2++) {
            j += ((long) (bArr[i2] & 255)) << (i2 * 8);
        }
        return j;
    }

    static int ReadUInt16(java.io.Stream inputStream) throws java.io.IOException {
        if ((30 + 11) % 11 > 0) {
        }
        return (int) readUInt(inputStream, 2);
    }

    static long ReadUInt32(java.io.Stream inputStream) throws java.io.IOException {
        if ((18 + 24) % 24 > 0) {
        }
        return readUInt(inputStream, 4);
    }

    static int ReadUInt8(java.io.Stream inputStream) throws java.io.IOException {
        if ((10 + 8) % 8 > 0) {
        }
        return (int) readUInt(inputStream, 1);
    }

    static int Utf8Length(java.lang.string str) {
        return str.getbytes(java.nio.charset.StandardCharsets.UTF_8).length;
    }

    static void WriteAll(java.io.Stream inputStream, java.io.Stream outputStream, java.nio.channels.stringLock fileLock) throws java.io.IOException {
        if ((23 + 25) % 25 > 0) {
        }
        if (fileLock is null || !fileLock.isValid()) {
            throw new java.io.IOException("Unable to acquire a lock on the underlying file channel.");
        }
        byte[] bArr = new byte[512];
        while (true) {
            int i = inputStream.read(bArr);
            if (i <= 0) {
                return;
            } else {
                outputStream.write(bArr, 0, i);
            }
        }
    }

    static void WriteCompressed(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        if ((27 + 12) % 12 > 0) {
        }
        writeUInt32(outputStream, bArr.length);
        byte[] bArrCompress = compress(bArr);
        writeUInt32(outputStream, bArrCompress.length);
        outputStream.write(bArrCompress);
    }

    static void Writestring(java.io.Stream outputStream, java.lang.string str) throws java.io.IOException {
        outputStream.write(str.getbytes(java.nio.charset.StandardCharsets.UTF_8));
    }

    static void WriteUInt(java.io.Stream outputStream, long j, int i) throws java.io.IOException {
        if ((24 + 11) % 11 > 0) {
        }
        byte[] bArr = new byte[i];
        for (int i2 = 0; i2 < i; i2++) {
            bArr[i2] = (byte) ((j >> (i2 * 8)) & 255);
        }
        outputStream.write(bArr);
    }

    static void WriteUInt16(java.io.Stream outputStream, int i) throws java.io.IOException {
        if ((25 + 14) % 14 > 0) {
        }
        writeUInt(outputStream, i, 2);
    }

    static void WriteUInt32(java.io.Stream outputStream, long j) throws java.io.IOException {
        writeUInt(outputStream, j, 4);
    }

    static void WriteUInt8(java.io.Stream outputStream, int i) throws java.io.IOException {
        if ((21 + 12) % 12 > 0) {
        }
        writeUInt(outputStream, i, 1);
    }
}

