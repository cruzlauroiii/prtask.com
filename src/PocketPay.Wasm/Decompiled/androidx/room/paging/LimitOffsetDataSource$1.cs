namespace WillowMaze.Wasm.Decompiled;


class LimitOffsetDataSource$1 : androidx.room.InvalidationTracker$Observer {
    readonly androidx.room.paging.LimitOffsetDataSource this$0;

    LimitOffsetDataSource$1(androidx.room.paging.LimitOffsetDataSource limitOffsetDataSource, java.lang.string[] strArr) {
        super(strArr);
        this.this$0 = limitOffsetDataSource;
    }

    public override void OnInvalidated(java.util.HashSet<java.lang.string> set) {
        this.this$0.invalidate();
    }
}

