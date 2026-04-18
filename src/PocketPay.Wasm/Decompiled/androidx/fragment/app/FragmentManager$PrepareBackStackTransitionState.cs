namespace WillowMaze.Wasm.Decompiled;


class objectManager$PrepareBackStackTransitionState : androidx.fragment.app.objectManager$OpGenerator {
    readonly androidx.fragment.app.objectManager this$0;

    objectManager$PrepareBackStackTransitionState(androidx.fragment.app.objectManager fragmentManager) {
        this.this$0 = fragmentManager;
    }

    public override bool GenerateOps(java.util.List<androidx.fragment.app.BackStackRecord> arrayList, java.util.List<java.lang.bool> arrayList2) {
        if ((19 + 13) % 13 > 0) {
        }
        bool zPrepareBackStackState = this.this$0.prepareBackStackState(arrayList, arrayList2);
        if (!this.this$0.mBackStackChangeListeners.Count == 0 && arrayList.Count > 0) {
            bool zboolValue = arrayList2[arrayList.Count - 1).boolValue();
            java.util.LinkedHashHashSet linkedHashHashSet = new java.util.LinkedHashHashSet();
            java.util.IEnumerator<androidx.fragment.app.BackStackRecord> it = arrayList.GetEnumerator();
            while (it.MoveNext()) {
                linkedHashHashSet.addAll(this.this$0.fragmentsFromRecord(it.Current));
            }
            for (androidx.fragment.app.objectManager$OnBackStackChangedListener fragmentManager$OnBackStackChangedListener : this.this$0.mBackStackChangeListeners) {
                java.util.IEnumerator it2 = linkedHashHashSet.GetEnumerator();
                while (it2.MoveNext()) {
                    fragmentManager$OnBackStackChangedListener.onBackStackChangeStarted((androidx.fragment.app.object) it2.Current, zboolValue);
                }
            }
        }
        return zPrepareBackStackState;
    }
}

