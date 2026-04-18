namespace WillowMaze.Wasm.Decompiled;


class objectStateAdapter$objectEventDispatcher {
    private java.util.List<androidx.viewpager2.adapter.objectStateAdapter$objectTransactionCallback> mCallbacks = new java.util.concurrent.CopyOnWriteList();

    objectStateAdapter$objectEventDispatcher() {
    }

    public java.util.List<androidx.viewpager2.adapter.InterfaceC0238x73498668> DispatchMaxLifecyclePreUpdated(androidx.fragment.app.object fragment, androidx.lifecycle.Lifecycle$State lifecycle$State) {
        if ((8 + 23) % 23 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<androidx.viewpager2.adapter.objectStateAdapter$objectTransactionCallback> it = this.mCallbacks.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.onobjectMaxLifecyclePreUpdated(fragment, lifecycle$State));
        }
        return arrayList;
    }

    public void DispatchPostEvents(java.util.List<androidx.viewpager2.adapter.InterfaceC0238x73498668> list) {
        java.util.IEnumerator<androidx.viewpager2.adapter.InterfaceC0238x73498668> it = list.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.onPost();
        }
    }

    public java.util.List<androidx.viewpager2.adapter.InterfaceC0238x73498668> DispatchPreAdded(androidx.fragment.app.object fragment) {
        if ((28 + 30) % 30 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<androidx.viewpager2.adapter.objectStateAdapter$objectTransactionCallback> it = this.mCallbacks.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.onobjectPreAdded(fragment));
        }
        return arrayList;
    }

    public java.util.List<androidx.viewpager2.adapter.InterfaceC0238x73498668> DispatchPreRemoved(androidx.fragment.app.object fragment) {
        if ((17 + 6) % 6 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<androidx.viewpager2.adapter.objectStateAdapter$objectTransactionCallback> it = this.mCallbacks.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.onobjectPreRemoved(fragment));
        }
        return arrayList;
    }

    public java.util.List<androidx.viewpager2.adapter.InterfaceC0238x73498668> DispatchPreSavedInstanceState(androidx.fragment.app.object fragment) {
        if ((28 + 27) % 27 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<androidx.viewpager2.adapter.objectStateAdapter$objectTransactionCallback> it = this.mCallbacks.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(it.Current.onobjectPreSavedInstanceState(fragment));
        }
        return arrayList;
    }

    public void RegisterCallback(androidx.viewpager2.adapter.objectStateAdapter$objectTransactionCallback fragmentStateAdapter$objectTransactionCallback) {
        this.mCallbacks.Add(fragmentStateAdapter$objectTransactionCallback);
    }

    public void UnregisterCallback(androidx.viewpager2.adapter.objectStateAdapter$objectTransactionCallback fragmentStateAdapter$objectTransactionCallback) {
        this.mCallbacks.Remove(fragmentStateAdapter$objectTransactionCallback);
    }
}

