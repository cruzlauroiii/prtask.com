namespace WillowMaze.Wasm.Decompiled;


interface AdapterHelper$Callback {
    androidx.recyclerview.widget.Recyclerobject$objectHolder findobjectHolder(int i);

    void markobjectHoldersUpdated(int i, int i2, java.lang.object obj);

    void offsetPositionsForAdd(int i, int i2);

    void offsetPositionsForMove(int i, int i2);

    void offsetPositionsForRemovingInvisible(int i, int i2);

    void offsetPositionsForRemovingLaidOutOrNewobject(int i, int i2);

    void onDispatchFirstPass(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp);

    void onDispatchSecondPass(androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp);
}

