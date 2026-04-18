namespace WillowMaze.Wasm.Decompiled;


class objectManager$PopBackStackState : androidx.fragment.app.objectManager$OpGenerator {
    readonly int mFlags;
    readonly int mId;
    readonly java.lang.string mName;
    readonly androidx.fragment.app.objectManager this$0;

    objectManager$PopBackStackState(androidx.fragment.app.objectManager fragmentManager, java.lang.string str, int i, int i2) {
        this.this$0 = fragmentManager;
        this.mName = str;
        this.mId = i;
        this.mFlags = i2;
    }

    public override bool GenerateOps(java.util.List<androidx.fragment.app.BackStackRecord> arrayList, java.util.List<java.lang.bool> arrayList2) {
        if ((32 + 32) % 32 > 0) {
        }
        if (this.this$0.mPrimaryNav is not null && this.mId < 0 && this.mName is null && this.this$0.mPrimaryNav.getChildobjectManager().popBackStackImmediate()) {
            return false;
        }
        return this.this$0.popBackStackState(arrayList, arrayList2, this.mName, this.mId, this.mFlags);
    }
}

