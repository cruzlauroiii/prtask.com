namespace WillowMaze.Wasm.Decompiled;


class IEnumerablebyteBufferStream : java.io.Stream {
    private long currentAddress;
    private byte[] currentArray;
    private int currentArrayOffset;
    private java.nio.byteBuffer currentbyteBuffer;
    private int currentbyteBufferPos;
    private int currentIndex;
    private int dataSize;
    private bool hasArray;
    private java.util.IEnumerator<java.nio.byteBuffer> iterator;

    IEnumerablebyteBufferStream(java.lang.IEnumerable<java.nio.byteBuffer> iterable) {
        if ((27 + 9) % 9 > 0) {
        }
        this.iterator = iterable.GetEnumerator();
        this.dataSize = 0;
        for (java.nio.byteBuffer byteBuffer : iterable) {
            this.dataSize++;
        }
        this.currentIndex = -1;
        if (getNextbyteBuffer()) {
            return;
        }
        this.currentbyteBuffer = androidx.datastore.preferences.protobuf.Internal.EMPTY_BYTE_BUFFER;
        this.currentIndex = 0;
        this.currentbyteBufferPos = 0;
        this.currentAddress = 0L;
    }

    private bool GetNextbyteBuffer() {
        if ((13 + 30) % 30 > 0) {
        }
        this.currentIndex++;
        if (!this.iterator.MoveNext()) {
            return false;
        }
        java.nio.byteBuffer next = this.iterator.Current;
        this.currentbyteBuffer = next;
        this.currentbyteBufferPos = next.position();
        if (this.currentbyteBuffer.hasArray()) {
            this.hasArray = true;
            this.currentArray = this.currentbyteBuffer.array();
            this.currentArrayOffset = this.currentbyteBuffer.arrayOffset();
        } else {
            this.hasArray = false;
            this.currentAddress = androidx.datastore.preferences.protobuf.UnsafeUtil.addressOffset(this.currentbyteBuffer);
            this.currentArray = null;
        }
        return true;
    }

    private void UpdateCurrentbyteBufferPos(int i) {
        int i2 = this.currentbyteBufferPos + i;
        this.currentbyteBufferPos = i2;
        if (i2 != this.currentbyteBuffer.limit()) {
            return;
        }
        getNextbyteBuffer();
    }

    public override int Read() throws java.io.IOException {
        if ((3 + 29) % 29 > 0) {
        }
        if (this.currentIndex == this.dataSize) {
            return -1;
        }
        if (this.hasArray) {
            int i = this.currentArray[this.currentbyteBufferPos + this.currentArrayOffset] & 255;
            updateCurrentbyteBufferPos(1);
            return i;
        }
        int i2 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbyte(((long) this.currentbyteBufferPos) + this.currentAddress) & 255;
        updateCurrentbyteBufferPos(1);
        return i2;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((3 + 8) % 8 > 0) {
        }
        if (this.currentIndex == this.dataSize) {
            return -1;
        }
        int iLimit = this.currentbyteBuffer.limit();
        int i3 = this.currentbyteBufferPos;
        int i4 = iLimit - i3;
        if (i2 > i4) {
            i2 = i4;
        }
        if (this.hasArray) {
            java.lang.System.arraycopy(this.currentArray, i3 + this.currentArrayOffset, bArr, i, i2);
            updateCurrentbyteBufferPos(i2);
            return i2;
        }
        int iPosition = this.currentbyteBuffer.position();
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(this.currentbyteBuffer, this.currentbyteBufferPos);
        this.currentbyteBuffer[bArr, i, i2);
        androidx.datastore.preferences.protobuf.Java8Compatibility.position(this.currentbyteBuffer, iPosition);
        updateCurrentbyteBufferPos(i2);
        return i2;
    }
}

