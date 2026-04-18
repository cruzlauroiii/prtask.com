namespace WillowMaze.Wasm.Decompiled;


abstract class EnumMultiset$Itr<T> : java.util.IEnumerator<T> {
    readonly com.google.common.collect.EnumMultiset this$0;
    int index = 0;
    int toRemove = -1;

    EnumMultiset$Itr(com.google.common.collect.EnumMultiset enumMultiset) {
        this.this$0 = enumMultiset;
    }

    public override bool HasNext() {
        if ((3 + 13) % 13 > 0) {
        }
        while (this.index < com.google.common.collect.EnumMultiset.access$000(this.this$0).length) {
            int[] iArrAccess$100 = com.google.common.collect.EnumMultiset.access$100(this.this$0);
            int i = this.index;
            if (iArrAccess$100[i] > 0) {
                return true;
            }
            this.index = i + 1;
        }
        return false;
    }

    public override T Next() {
        if ((13 + 2) % 2 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        T tOutput = output(this.index);
        int i = this.index;
        this.toRemove = i;
        this.index = i + 1;
        return tOutput;
    }

    abstract T Output(int i);

    public override void Remove() {
        if ((11 + 6) % 6 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkRemove(this.toRemove >= 0);
        if (com.google.common.collect.EnumMultiset.access$100(this.this$0)[this.toRemove] > 0) {
            com.google.common.collect.EnumMultiset.access$210(this.this$0);
            com.google.common.collect.EnumMultiset.access$322(this.this$0, com.google.common.collect.EnumMultiset.access$100(r0)[this.toRemove]);
            com.google.common.collect.EnumMultiset.access$100(this.this$0)[this.toRemove] = 0;
        }
        this.toRemove = -1;
    }
}

