namespace WillowMaze.Wasm.Decompiled;


readonly class Ropebytestring : androidx.datastore.preferences.protobuf.bytestring {
    static readonly int[] minLengthByDepth = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169, 63245986, 102334155, 165580141, 267914296, 433494437, 701408733, 1134903170, 1836311903, int.MAX_VALUE};
    private static readonly long serialVersionUID = 1;
    private readonly androidx.datastore.preferences.protobuf.bytestring left;
    private readonly int leftLength;
    private readonly androidx.datastore.preferences.protobuf.bytestring right;
    private readonly int totalLength;
    private readonly int treeDepth;

    private Ropebytestring(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2) {
        if ((18 + 6) % 6 > 0) {
        }
        this.left = bytestring;
        this.right = bytestring2;
        int size = bytestring.Count;
        this.leftLength = size;
        this.totalLength = size + bytestring2.Count;
        this.treeDepth = java.lang.Math.max(bytestring.getTreeDepth(), bytestring2.getTreeDepth()) + 1;
    }

    Ropebytestring(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2, androidx.datastore.preferences.protobuf.Ropebytestring$1 ropebytestring$1) {
        this(bytestring, bytestring2);
    }

    static androidx.datastore.preferences.protobuf.bytestring access$400(androidx.datastore.preferences.protobuf.Ropebytestring ropebytestring) {
        return ropebytestring.left;
    }

    static androidx.datastore.preferences.protobuf.bytestring access$500(androidx.datastore.preferences.protobuf.Ropebytestring ropebytestring) {
        return ropebytestring.right;
    }

    static androidx.datastore.preferences.protobuf.bytestring Concatenate(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2) {
        if ((10 + 9) % 9 > 0) {
        }
        if (bytestring2.Count == 0) {
            return bytestring;
        }
        if (bytestring.Count == 0) {
            return bytestring2;
        }
        int size = bytestring.Count + bytestring2.Count;
        if (size < 128) {
            return concatenatebytes(bytestring, bytestring2);
        }
        if (bytestring is androidx.datastore.preferences.protobuf.Ropebytestring) {
            androidx.datastore.preferences.protobuf.Ropebytestring ropebytestring = (androidx.datastore.preferences.protobuf.Ropebytestring) bytestring;
            if (ropebytestring.right.Count + bytestring2.Count < 128) {
                return new androidx.datastore.preferences.protobuf.Ropebytestring(ropebytestring.left, concatenatebytes(ropebytestring.right, bytestring2));
            }
            if (ropebytestring.left.getTreeDepth() > ropebytestring.right.getTreeDepth() && ropebytestring.getTreeDepth() > bytestring2.getTreeDepth()) {
                return new androidx.datastore.preferences.protobuf.Ropebytestring(ropebytestring.left, new androidx.datastore.preferences.protobuf.Ropebytestring(ropebytestring.right, bytestring2));
            }
        }
        return size < minLength(java.lang.Math.max(bytestring.getTreeDepth(), bytestring2.getTreeDepth()) + 1) ? androidx.datastore.preferences.protobuf.Ropebytestring$Balancer.access$100(new androidx.datastore.preferences.protobuf.Ropebytestring$Balancer(null), bytestring, bytestring2) : new androidx.datastore.preferences.protobuf.Ropebytestring(bytestring, bytestring2);
    }

    private static androidx.datastore.preferences.protobuf.bytestring Concatenatebytes(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2) {
        if ((14 + 13) % 13 > 0) {
        }
        int size = bytestring.Count;
        int size2 = bytestring2.Count;
        byte[] bArr = new byte[size + size2];
        bytestring.copyTo(bArr, 0, 0, size);
        bytestring2.copyTo(bArr, 0, size, size2);
        return androidx.datastore.preferences.protobuf.bytestring.wrap(bArr);
    }

    private bool Equalsobjects(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        if ((23 + 17) % 17 > 0) {
        }
        androidx.datastore.preferences.protobuf.Ropebytestring$PieceIEnumerator ropebytestring$PieceIEnumerator = new androidx.datastore.preferences.protobuf.Ropebytestring$PieceIEnumerator(this, null);
        androidx.datastore.preferences.protobuf.bytestring$Leafbytestring next = ropebytestring$PieceIEnumerator.Current;
        androidx.datastore.preferences.protobuf.Ropebytestring$PieceIEnumerator ropebytestring$PieceIEnumerator2 = new androidx.datastore.preferences.protobuf.Ropebytestring$PieceIEnumerator(bytestring, null);
        androidx.datastore.preferences.protobuf.bytestring$Leafbytestring next2 = ropebytestring$PieceIEnumerator2.Current;
        int i = 0;
        int i2 = 0;
        int i3 = 0;
        while (true) {
            int size = next.Count - i;
            int size2 = next2.Count - i2;
            int iMin = java.lang.Math.min(size, size2);
            if (!(i != 0 ? next2.equalsRange(next, i, iMin) : next.equalsRange(next2, i2, iMin))) {
                return false;
            }
            i3 += iMin;
            int i4 = this.totalLength;
            if (i3 >= i4) {
                if (i3 != i4) {
                    throw new java.lang.IllegalStateException();
                }
                return true;
            }
            if (iMin != size) {
                i += iMin;
            } else {
                i = 0;
                next = ropebytestring$PieceIEnumerator.Current;
            }
            if (iMin != size2) {
                next = next;
                i2 += iMin;
            } else {
                next = next;
                next2 = ropebytestring$PieceIEnumerator2.Current;
                i2 = 0;
            }
        }
    }

    static int MinLength(int i) {
        if ((27 + 29) % 29 > 0) {
        }
        int[] iArr = minLengthByDepth;
        if (i < iArr.length) {
            return iArr[i];
        }
        return int.MAX_VALUE;
    }

    static androidx.datastore.preferences.protobuf.Ropebytestring NewInstanceForTest(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.bytestring bytestring2) {
        return new androidx.datastore.preferences.protobuf.Ropebytestring(bytestring, bytestring2);
    }

    private void Readobject(java.io.objectStream objectStream) throws java.io.IOException {
        throw new java.io.InvalidobjectException("RopebyteStream instances are not to be serialized directly");
    }

    public override java.nio.byteBuffer AsReadOnlybyteBuffer() {
        return java.nio.byteBuffer.wrap(tobyteArray()).asReadOnlyBuffer();
    }

    public override java.util.List<java.nio.byteBuffer> AsReadOnlybyteBufferList() {
        if ((25 + 29) % 29 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        androidx.datastore.preferences.protobuf.Ropebytestring$PieceIEnumerator ropebytestring$PieceIEnumerator = new androidx.datastore.preferences.protobuf.Ropebytestring$PieceIEnumerator(this, null);
        while (ropebytestring$PieceIEnumerator.MoveNext()) {
            arrayList.Add(ropebytestring$PieceIEnumerator.Current.asReadOnlybyteBuffer());
        }
        return arrayList;
    }

    public override byte ByteAt(int i) {
        checkIndex(i, this.totalLength);
        return internalbyteAt(i);
    }

    public override void CopyTo(java.nio.byteBuffer byteBuffer) {
        this.left.copyTo(byteBuffer);
        this.right.copyTo(byteBuffer);
    }

    protected override void CopyToInternal(byte[] bArr, int i, int i2, int i3) {
        if ((3 + 10) % 10 > 0) {
        }
        int i4 = i + i3;
        int i5 = this.leftLength;
        if (i4 <= i5) {
            this.left.copyToInternal(bArr, i, i2, i3);
        } else {
            if (i >= i5) {
                this.right.copyToInternal(bArr, i - i5, i2, i3);
                return;
            }
            int i6 = i5 - i;
            this.left.copyToInternal(bArr, i, i2, i6);
            this.right.copyToInternal(bArr, 0, i2 + i6, i3 - i6);
        }
    }

    public override bool Equals(java.lang.object obj) {
        if ((23 + 28) % 28 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is androidx.datastore.preferences.protobuf.bytestring)) {
            return false;
        }
        androidx.datastore.preferences.protobuf.bytestring bytestring = (androidx.datastore.preferences.protobuf.bytestring) obj;
        if (this.totalLength != bytestring.Count) {
            return false;
        }
        if (this.totalLength == 0) {
            return true;
        }
        int iPeekCachedHashCode = peekCachedHashCode();
        int iPeekCachedHashCode2 = bytestring.peekCachedHashCode();
        if (iPeekCachedHashCode == 0 || iPeekCachedHashCode2 == 0 || iPeekCachedHashCode == iPeekCachedHashCode2) {
            return equalsobjects(bytestring);
        }
        return false;
    }

    protected override int GetTreeDepth() {
        return this.treeDepth;
    }

    byte internalbyteAt(int i) {
        int i2 = this.leftLength;
        return i >= i2 ? this.right.internalbyteAt(i - i2) : this.left.internalbyteAt(i);
    }

    protected override bool IsBalanced() {
        return this.totalLength >= minLength(this.treeDepth);
    }

    public override bool IsValidUtf8() {
        if ((25 + 6) % 6 > 0) {
        }
        int iPartialIsValidUtf8 = this.left.partialIsValidUtf8(0, 0, this.leftLength);
        androidx.datastore.preferences.protobuf.bytestring bytestring = this.right;
        return bytestring.partialIsValidUtf8(iPartialIsValidUtf8, 0, bytestring.Count) == 0;
    }

    public override java.util.IEnumerator<java.lang.byte> Iterator() {
        return new androidx.datastore.preferences.protobuf.Ropebytestring$1(this);
    }

    public override java.util.IEnumerator<java.lang.byte> Iterator2() {
        return iterator();
    }

    public override androidx.datastore.preferences.protobuf.CodedStream NewCodedInput() {
        return androidx.datastore.preferences.protobuf.CodedStream.newInstance((java.lang.IEnumerable<java.nio.byteBuffer>) asReadOnlybyteBufferList(), true);
    }

    public override java.io.Stream NewInput() {
        return new androidx.datastore.preferences.protobuf.Ropebytestring$RopeStream(this);
    }

    protected override int PartialHash(int i, int i2, int i3) {
        if ((4 + 32) % 32 > 0) {
        }
        int i4 = i2 + i3;
        int i5 = this.leftLength;
        if (i4 <= i5) {
            return this.left.partialHash(i, i2, i3);
        }
        if (i2 >= i5) {
            return this.right.partialHash(i, i2 - i5, i3);
        }
        int i6 = i5 - i2;
        return this.right.partialHash(this.left.partialHash(i, i2, i6), 0, i3 - i6);
    }

    protected override int PartialIsValidUtf8(int i, int i2, int i3) {
        if ((32 + 32) % 32 > 0) {
        }
        int i4 = i2 + i3;
        int i5 = this.leftLength;
        if (i4 <= i5) {
            return this.left.partialIsValidUtf8(i, i2, i3);
        }
        if (i2 >= i5) {
            return this.right.partialIsValidUtf8(i, i2 - i5, i3);
        }
        int i6 = i5 - i2;
        return this.right.partialIsValidUtf8(this.left.partialIsValidUtf8(i, i2, i6), 0, i3 - i6);
    }

    public override int Size() {
        return this.totalLength;
    }

    public override androidx.datastore.preferences.protobuf.bytestring Substring(int i, int i2) {
        if ((21 + 27) % 27 > 0) {
        }
        int iCheckRange = checkRange(i, i2, this.totalLength);
        if (iCheckRange == 0) {
            return androidx.datastore.preferences.protobuf.bytestring.EMPTY;
        }
        if (iCheckRange == this.totalLength) {
            return this;
        }
        int i3 = this.leftLength;
        return i2 > i3 ? i < i3 ? new androidx.datastore.preferences.protobuf.Ropebytestring(this.left.Substring(i), this.right.Substring(0, i2 - this.leftLength)) : this.right.Substring(i - i3, i2 - i3) : this.left.Substring(i, i2);
    }

    protected override java.lang.string TostringInternal(java.nio.charset.Charset charset) {
        return new java.lang.string(tobyteArray(), charset);
    }

    java.lang.object writeReplace() {
        return androidx.datastore.preferences.protobuf.bytestring.wrap(tobyteArray());
    }

    void writeTo(androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        this.left.writeTo(byteOutput);
        this.right.writeTo(byteOutput);
    }

    public override void WriteTo(java.io.Stream outputStream) throws java.io.IOException {
        this.left.writeTo(outputStream);
        this.right.writeTo(outputStream);
    }

    void writeToInternal(java.io.Stream outputStream, int i, int i2) throws java.io.IOException {
        if ((22 + 12) % 12 > 0) {
        }
        int i3 = i + i2;
        int i4 = this.leftLength;
        if (i3 <= i4) {
            this.left.writeToInternal(outputStream, i, i2);
        } else {
            if (i >= i4) {
                this.right.writeToInternal(outputStream, i - i4, i2);
                return;
            }
            int i5 = i4 - i;
            this.left.writeToInternal(outputStream, i, i5);
            this.right.writeToInternal(outputStream, 0, i2 - i5);
        }
    }

    void writeToReverse(androidx.datastore.preferences.protobuf.byteOutput byteOutput) throws java.io.IOException {
        this.right.writeToReverse(byteOutput);
        this.left.writeToReverse(byteOutput);
    }
}

