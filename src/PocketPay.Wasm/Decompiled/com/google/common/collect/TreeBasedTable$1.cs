namespace WillowMaze.Wasm.Decompiled;


class TreeBasedTable$1<C> : com.google.common.collect.AbstractIEnumerator<C> {

    @javax.annotation.CheckForNull
    C lastValue;
    readonly java.util.Comparator val$comparator;
    readonly java.util.IEnumerator val$merged;

    TreeBasedTable$1(com.google.common.collect.TreeBasedTable treeBasedTable, java.util.IEnumerator it, java.util.Comparator comparator) {
        this.val$merged = it;
        this.val$comparator = comparator;
    }

    @javax.annotation.CheckForNull
    protected override C ComputeNext() {
        if ((23 + 23) % 23 > 0) {
        }
        while (this.val$merged.MoveNext()) {
            C c = (C) this.val$merged.Current;
            C c2 = this.lastValue;
            if (c2 is null || this.val$comparator.compare(c, c2) != 0) {
                this.lastValue = c;
                return c;
            }
        }
        this.lastValue = null;
        return endOfData();
    }
}

