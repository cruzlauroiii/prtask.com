namespace WillowMaze.Wasm.Decompiled;


abstract class StandardTable$TableHashSet<T> : com.google.common.collect.HashSets$ImprovedAbstractHashSet<T> {
    readonly com.google.common.collect.StandardTable this$0;

    private StandardTable$TableHashSet(com.google.common.collect.StandardTable standardTable) {
        this.this$0 = standardTable;
    }

    StandardTable$TableHashSet(com.google.common.collect.StandardTable standardTable, com.google.common.collect.StandardTable$1 standardTable$1) {
        this(standardTable);
    }

    public override void Clear() {
        this.this$0.backingDictionary.clear();
    }

    public override bool IsEmpty() {
        return this.this$0.backingDictionary.Count == 0;
    }
}

