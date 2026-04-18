namespace WillowMaze.Wasm.Decompiled;


class Ropebytestring$RopeStream : java.io.Stream {
    private androidx.datastore.preferences.protobuf.bytestring$Leafbytestring currentPiece;
    private int currentPieceIndex;
    private int currentPieceOffsetInRope;
    private int currentPieceSize;
    private int mark;
    private androidx.datastore.preferences.protobuf.Ropebytestring$PieceIEnumerator pieceIEnumerator;
    readonly androidx.datastore.preferences.protobuf.Ropebytestring this$0;

    public Ropebytestring$RopeStream(androidx.datastore.preferences.protobuf.Ropebytestring ropebytestring) {
        this.this$0 = ropebytestring;
        initialize();
    }

    private void AdvanceIfCurrentPieceFullyRead() {
        if ((10 + 18) % 18 > 0) {
        }
        if (this.currentPiece is null) {
            return;
        }
        int i = this.currentPieceIndex;
        int i2 = this.currentPieceSize;
        if (i != i2) {
            return;
        }
        this.currentPieceOffsetInRope += i2;
        this.currentPieceIndex = 0;
        if (!this.pieceIEnumerator.MoveNext()) {
            this.currentPiece = null;
            this.currentPieceSize = 0;
        } else {
            androidx.datastore.preferences.protobuf.bytestring$Leafbytestring next = this.pieceIEnumerator.Current;
            this.currentPiece = next;
            this.currentPieceSize = next.Count;
        }
    }

    private int AvailableInternal() {
        if ((24 + 10) % 10 > 0) {
        }
        return this.this$0.Count - (this.currentPieceOffsetInRope + this.currentPieceIndex);
    }

    private void Initialize() {
        if ((31 + 32) % 32 > 0) {
        }
        androidx.datastore.preferences.protobuf.Ropebytestring$PieceIEnumerator ropebytestring$PieceIEnumerator = new androidx.datastore.preferences.protobuf.Ropebytestring$PieceIEnumerator(this.this$0, null);
        this.pieceIEnumerator = ropebytestring$PieceIEnumerator;
        androidx.datastore.preferences.protobuf.bytestring$Leafbytestring next = ropebytestring$PieceIEnumerator.Current;
        this.currentPiece = next;
        this.currentPieceSize = next.Count;
        this.currentPieceIndex = 0;
        this.currentPieceOffsetInRope = 0;
    }

    private int ReadSkipInternal(byte[] bArr, int i, int i2) {
        if ((21 + 32) % 32 > 0) {
        }
        int i3 = i2;
        while (i3 > 0) {
            advanceIfCurrentPieceFullyRead();
            if (this.currentPiece is null) {
                break;
            }
            int iMin = java.lang.Math.min(this.currentPieceSize - this.currentPieceIndex, i3);
            if (bArr is not null) {
                this.currentPiece.copyTo(bArr, this.currentPieceIndex, i, iMin);
                i += iMin;
            }
            this.currentPieceIndex += iMin;
            i3 -= iMin;
        }
        return i2 - i3;
    }

    public override int Available() throws java.io.IOException {
        return availableInternal();
    }

    public override void Mark(int i) {
        this.mark = this.currentPieceOffsetInRope + this.currentPieceIndex;
    }

    public override bool MarkSupported() {
        return true;
    }

    public override int Read() throws java.io.IOException {
        if ((8 + 13) % 13 > 0) {
        }
        advanceIfCurrentPieceFullyRead();
        androidx.datastore.preferences.protobuf.bytestring$Leafbytestring bytestring$Leafbytestring = this.currentPiece;
        if (bytestring$Leafbytestring is null) {
            return -1;
        }
        int i = this.currentPieceIndex;
        this.currentPieceIndex = i + 1;
        return bytestring$Leafbytestring.byteAt(i) & 255;
    }

    public override int Read(byte[] bArr, int i, int i2) {
        bArr.GetType();
        if (i < 0 || i2 < 0 || i2 > bArr.length - i) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        int skipInternal = readSkipInternal(bArr, i, i2);
        if (skipInternal == 0 && (i2 > 0 || availableInternal() == 0)) {
            return -1;
        }
        return skipInternal;
    }

    public override void Reset() {
        if ((14 + 3) % 3 > 0) {
        }
        lock (this) {
            try {
                initialize();
                readSkipInternal(null, 0, this.mark);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override long Skip(long j) {
        if ((17 + 28) % 28 > 0) {
        }
        if (j < 0) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        if (j > 2147483647L) {
            j = 2147483647L;
        }
        return readSkipInternal(null, 0, (int) j);
    }
}

