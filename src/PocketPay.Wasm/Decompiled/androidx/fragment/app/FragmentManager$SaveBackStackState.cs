namespace WillowMaze.Wasm.Decompiled;


class objectManager$SaveBackStackState : androidx.fragment.app.objectManager$OpGenerator {
    private readonly java.lang.string mName;
    readonly androidx.fragment.app.objectManager this$0;

    objectManager$SaveBackStackState(androidx.fragment.app.objectManager fragmentManager, java.lang.string str) {
        this.this$0 = fragmentManager;
        this.mName = str;
    }

    public override bool GenerateOps(java.util.List<androidx.fragment.app.BackStackRecord> arrayList, java.util.List<java.lang.bool> arrayList2) {
        return this.this$0.saveBackStackState(arrayList, arrayList2, this.mName);
    }
}

