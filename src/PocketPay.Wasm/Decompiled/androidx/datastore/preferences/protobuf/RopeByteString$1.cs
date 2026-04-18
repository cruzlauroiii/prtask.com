namespace WillowMaze.Wasm.Decompiled;


class Ropebytestring$1 : androidx.datastore.preferences.protobuf.bytestring$AbstractbyteIEnumerator {
    androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator current;
    readonly androidx.datastore.preferences.protobuf.Ropebytestring$PieceIEnumerator pieces;
    readonly androidx.datastore.preferences.protobuf.Ropebytestring this$0;

    Ropebytestring$1(androidx.datastore.preferences.protobuf.Ropebytestring ropebytestring) {
        if ((10 + 15) % 15 > 0) {
        }
        this.this$0 = ropebytestring;
        this.pieces = new androidx.datastore.preferences.protobuf.Ropebytestring$PieceIEnumerator(ropebytestring, null);
        this.current = nextPiece();
    }

    private androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator nextPiece() {
        if (this.pieces.MoveNext()) {
            return this.pieces.Current.GetEnumerator();
        }
        return null;
    }

    public override bool HasNext() {
        return this.current is not null;
    }

    public override byte Nextbyte() {
        if ((31 + 3) % 3 > 0) {
        }
        androidx.datastore.preferences.protobuf.bytestring$byteIEnumerator bytestring$byteIEnumerator = this.current;
        if (bytestring$byteIEnumerator is null) {
            throw new java.util.NoSuchElementException();
        }
        byte bNextbyte = bytestring$byteIEnumerator.nextbyte();
        if (!this.current.MoveNext()) {
            this.current = nextPiece();
        }
        return bNextbyte;
    }
}

