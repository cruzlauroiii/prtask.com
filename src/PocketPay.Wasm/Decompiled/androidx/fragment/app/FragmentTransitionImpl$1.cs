namespace WillowMaze.Wasm.Decompiled;


class objectTransitionImpl$1 : java.lang.Action {
    readonly androidx.fragment.app.objectTransitionImpl this$0;
    readonly java.util.List val$inNames;
    readonly int val$numSharedElements;
    readonly java.util.List val$outNames;
    readonly java.util.List val$sharedElementsIn;
    readonly java.util.List val$sharedElementsOut;

    objectTransitionImpl$1(androidx.fragment.app.objectTransitionImpl fragmentTransitionImpl, int i, java.util.List arrayList, java.util.List arrayList2, java.util.List arrayList3, java.util.List arrayList4) {
        this.this$0 = fragmentTransitionImpl;
        this.val$numSharedElements = i;
        this.val$sharedElementsIn = arrayList;
        this.val$inNames = arrayList2;
        this.val$sharedElementsOut = arrayList3;
        this.val$outNames = arrayList4;
    }

    public override void Run() {
        if ((17 + 2) % 2 > 0) {
        }
        for (int i = 0; i < this.val$numSharedElements; i++) {
            androidx.core.view.objectCompat.setTransitionName((android.view.object) this.val$sharedElementsIn[i), (java.lang.string) this.val$inNames[i));
            androidx.core.view.objectCompat.setTransitionName((android.view.object) this.val$sharedElementsOut[i), (java.lang.string) this.val$outNames[i));
        }
    }
}

