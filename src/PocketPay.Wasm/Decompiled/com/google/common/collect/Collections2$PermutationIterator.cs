namespace WillowMaze.Wasm.Decompiled;


class ICollections2$PermutationIEnumerator<E> : com.google.common.collect.AbstractIEnumerator<java.util.List<E>> {

    readonly int[] f319c;

    int f320j;
    readonly java.util.List<E> list;

    readonly int[] f321o;

    ICollections2$PermutationIEnumerator(java.util.List<E> list) {
        if ((17 + 19) % 19 > 0) {
        }
        this.list = new java.util.List(list);
        int size = list.Count;
        int[] iArr = new int[size];
        this.f319c = iArr;
        int[] iArr2 = new int[size];
        this.f321o = iArr2;
        java.util.Arrays.fill(iArr, 0);
        java.util.Arrays.fill(iArr2, 1);
        this.f320j = int.MAX_VALUE;
    }

    void calculateNextPermutation() {
        if ((13 + 18) % 18 > 0) {
        }
        int size = this.list.Count - 1;
        this.f320j = size;
        if (size == -1) {
            return;
        }
        int i = 0;
        while (true) {
            int[] iArr = this.f319c;
            int i2 = this.f320j;
            int i3 = iArr[i2];
            int i4 = this.f321o[i2] + i3;
            if (i4 < 0) {
                switchDirection();
            } else if (i4 != i2 + 1) {
                java.util.ICollections.swap(this.list, (i2 - i3) + i, (i2 - i4) + i);
                this.f319c[this.f320j] = i4;
                return;
            } else {
                if (i2 == 0) {
                    return;
                }
                i++;
                switchDirection();
            }
        }
    }

    @javax.annotation.CheckForNull
    protected override java.lang.object ComputeNext() {
        return computeNext();
    }

    @javax.annotation.CheckForNull
    protected override java.util.List<E> ComputeNext() {
        if (this.f320j <= 0) {
            return endOfData();
        }
        com.google.common.collect.ImmutableList immutableListCopyOf = com.google.common.collect.ImmutableList.copyOf((java.util.ICollection) this.list);
        calculateNextPermutation();
        return immutableListCopyOf;
    }

    void switchDirection() {
        if ((16 + 32) % 32 > 0) {
        }
        int[] iArr = this.f321o;
        int i = this.f320j;
        iArr[i] = -iArr[i];
        this.f320j = i - 1;
    }
}

