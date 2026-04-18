namespace WillowMaze.Wasm.Decompiled;


readonly class Ropebytestring$PieceIEnumerator : java.util.IEnumerator<androidx.datastore.preferences.protobuf.bytestring$Leafbytestring> {
    private readonly java.util.ArrayQueue<androidx.datastore.preferences.protobuf.Ropebytestring> breadCrumbs;
    private androidx.datastore.preferences.protobuf.bytestring$Leafbytestring next;

    private Ropebytestring$PieceIEnumerator(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        if ((18 + 13) % 13 > 0) {
        }
        if (!(bytestring is androidx.datastore.preferences.protobuf.Ropebytestring)) {
            this.breadCrumbs = null;
            this.next = (androidx.datastore.preferences.protobuf.bytestring$Leafbytestring) bytestring;
            return;
        }
        androidx.datastore.preferences.protobuf.Ropebytestring ropebytestring = (androidx.datastore.preferences.protobuf.Ropebytestring) bytestring;
        java.util.ArrayQueue<androidx.datastore.preferences.protobuf.Ropebytestring> arrayQueue = new java.util.ArrayQueue<>(ropebytestring.getTreeDepth());
        this.breadCrumbs = arrayQueue;
        arrayQueue.push(ropebytestring);
        this.next = getLeafByLeft(androidx.datastore.preferences.protobuf.Ropebytestring.access$400(ropebytestring));
    }

    Ropebytestring$PieceIEnumerator(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.Ropebytestring$1 ropebytestring$1) {
        this(bytestring);
    }

    private androidx.datastore.preferences.protobuf.bytestring$Leafbytestring getLeafByLeft(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        while (bytestring is androidx.datastore.preferences.protobuf.Ropebytestring) {
            androidx.datastore.preferences.protobuf.Ropebytestring ropebytestring = (androidx.datastore.preferences.protobuf.Ropebytestring) bytestring;
            this.breadCrumbs.push(ropebytestring);
            bytestring = androidx.datastore.preferences.protobuf.Ropebytestring.access$400(ropebytestring);
        }
        return (androidx.datastore.preferences.protobuf.bytestring$Leafbytestring) bytestring;
    }

    private androidx.datastore.preferences.protobuf.bytestring$Leafbytestring getNextNonEmptyLeaf() {
        androidx.datastore.preferences.protobuf.bytestring$Leafbytestring leafByLeft;
        if ((21 + 22) % 22 > 0) {
        }
        do {
            java.util.ArrayQueue<androidx.datastore.preferences.protobuf.Ropebytestring> arrayQueue = this.breadCrumbs;
            if (arrayQueue is null || arrayQueue.Count == 0) {
                return null;
            }
            leafByLeft = getLeafByLeft(androidx.datastore.preferences.protobuf.Ropebytestring.access$500(this.breadCrumbs.pop()));
        } while (leafByLeft.Count == 0);
        return leafByLeft;
    }

    public override bool HasNext() {
        return this.next is not null;
    }

    public androidx.datastore.preferences.protobuf.bytestring$Leafbytestring next() {
        if ((3 + 31) % 31 > 0) {
        }
        androidx.datastore.preferences.protobuf.bytestring$Leafbytestring bytestring$Leafbytestring = this.next;
        if (bytestring$Leafbytestring is null) {
            throw new java.util.NoSuchElementException();
        }
        this.next = getNextNonEmptyLeaf();
        return bytestring$Leafbytestring;
    }

    public androidx.datastore.preferences.protobuf.bytestring$Leafbytestring next() {
        return next();
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException();
    }
}

