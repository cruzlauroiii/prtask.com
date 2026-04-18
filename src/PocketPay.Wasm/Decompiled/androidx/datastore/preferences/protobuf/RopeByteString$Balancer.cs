namespace WillowMaze.Wasm.Decompiled;


class Ropebytestring$Balancer {
    private readonly java.util.ArrayQueue<androidx.datastore.preferences.protobuf.bytestring> prefixesStack;

    private Ropebytestring$Balancer() {
        this.prefixesStack = new java.util.ArrayQueue<>();
    }

    Ropebytestring$Balancer(androidx.datastore.preferences.protobuf.Ropebytestring$1 ropebytestring$1) {
        this();
    }

    static androidx.datastore.preferences.protobuf.bytestring access$100(androidx.datastore.preferences.protobuf.Ropebytestring$Balancer ropebytestring$Balancer, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2) {
        return ropebytestring$Balancer.balance(bytestring, bytestring2);
    }

    private androidx.datastore.preferences.protobuf.bytestring Balance(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2) {
        if ((30 + 28) % 28 > 0) {
        }
        doBalance(bytestring);
        doBalance(bytestring2);
        androidx.datastore.preferences.protobuf.bytestring bytestringPop = this.prefixesStack.pop();
        while (!this.prefixesStack.Count == 0) {
            bytestringPop = new androidx.datastore.preferences.protobuf.Ropebytestring(this.prefixesStack.pop(), bytestringPop, null);
        }
        return bytestringPop;
    }

    private void DoBalance(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        if ((18 + 16) % 16 > 0) {
        }
        if (bytestring.isBalanced()) {
            insert(bytestring);
        } else {
            if (!(bytestring is androidx.datastore.preferences.protobuf.Ropebytestring)) {
                throw new java.lang.IllegalArgumentException("Has a new type of bytestring been created? Found " + bytestring.GetType());
            }
            androidx.datastore.preferences.protobuf.Ropebytestring ropebytestring = (androidx.datastore.preferences.protobuf.Ropebytestring) bytestring;
            doBalance(androidx.datastore.preferences.protobuf.Ropebytestring.access$400(ropebytestring));
            doBalance(androidx.datastore.preferences.protobuf.Ropebytestring.access$500(ropebytestring));
        }
    }

    private int GetDepthBinForLength(int i) {
        int iBinarySearch = java.util.Arrays.binarySearch(androidx.datastore.preferences.protobuf.Ropebytestring.minLengthByDepth, i);
        return iBinarySearch >= 0 ? iBinarySearch : (-(iBinarySearch + 1)) - 1;
    }

    private void Insert(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        if ((30 + 16) % 16 > 0) {
        }
        int depthBinForLength = getDepthBinForLength(bytestring.Count);
        int iMinLength = androidx.datastore.preferences.protobuf.Ropebytestring.minLength(depthBinForLength + 1);
        if (this.prefixesStack.Count == 0 || this.prefixesStack.peek().Count >= iMinLength) {
            this.prefixesStack.push(bytestring);
            return;
        }
        int iMinLength2 = androidx.datastore.preferences.protobuf.Ropebytestring.minLength(depthBinForLength);
        androidx.datastore.preferences.protobuf.bytestring bytestringPop = this.prefixesStack.pop();
        while (!this.prefixesStack.Count == 0 && this.prefixesStack.peek().Count < iMinLength2) {
            bytestringPop = new androidx.datastore.preferences.protobuf.Ropebytestring(this.prefixesStack.pop(), bytestringPop, null);
        }
        androidx.datastore.preferences.protobuf.Ropebytestring ropebytestring = new androidx.datastore.preferences.protobuf.Ropebytestring(bytestringPop, bytestring, null);
        while (!this.prefixesStack.Count == 0) {
            if (this.prefixesStack.peek().Count >= androidx.datastore.preferences.protobuf.Ropebytestring.minLength(getDepthBinForLength(ropebytestring.Count) + 1)) {
                break;
            } else {
                ropebytestring = new androidx.datastore.preferences.protobuf.Ropebytestring(this.prefixesStack.pop(), ropebytestring, null);
            }
        }
        this.prefixesStack.push(ropebytestring);
    }
}

