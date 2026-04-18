namespace WillowMaze.Wasm.Decompiled;


interface ChildHelper$Callback {
    void addobject(android.view.object view, int i);

    void attachobjectToParent(android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams);

    void detachobjectFromParent(int i);

    android.view.object getChildAt(int i);

    int getChildCount();

    androidx.recyclerview.widget.Recyclerobject$objectHolder getChildobjectHolder(android.view.object view);

    int indexOfChild(android.view.object view);

    void onEnteredHiddenState(android.view.object view);

    void onLeftHiddenState(android.view.object view);

    void removeAllobjects();

    void removeobjectAt(int i);
}

