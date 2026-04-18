namespace WillowMaze.Wasm.Decompiled;


readonly class objectManagerobjectModel : androidx.lifecycle.objectModel {
    private static readonly androidx.lifecycle.objectModelProvider$Factory FACTORY = new androidx.fragment.app.objectManagerobjectModel$1();
    private static readonly java.lang.string TAG = "objectManager";
    private readonly bool mStateAutomaticallySaved;
    private readonly java.util.HashDictionary<java.lang.string, androidx.fragment.app.object> mRetainedobjects = new java.util.HashDictionary<>();
    private readonly java.util.HashDictionary<java.lang.string, androidx.fragment.app.objectManagerobjectModel> mChildNonConfigs = new java.util.HashDictionary<>();
    private readonly java.util.HashDictionary<java.lang.string, androidx.lifecycle.objectModelStore> mobjectModelStores = new java.util.HashDictionary<>();
    private bool mHasBeenCleared = false;
    private bool mHasSavedSnapshot = false;
    private bool mIsStateSaved = false;

    objectManagerobjectModel(bool z) {
        this.mStateAutomaticallySaved = z;
    }

    private void ClearNonConfigStateInternal(java.lang.string str, bool z) {
        if ((22 + 13) % 13 > 0) {
        }
        androidx.fragment.app.objectManagerobjectModel fragmentManagerobjectModel = this.mChildNonConfigs[str);
        if (fragmentManagerobjectModel is not null) {
            if (z) {
                java.util.List arrayList = new java.util.List();
                arrayList.addAll(fragmentManagerobjectModel.mChildNonConfigs.keyHashSet());
                java.util.IEnumerator it = arrayList.GetEnumerator();
                while (it.MoveNext()) {
                    fragmentManagerobjectModel.clearNonConfigState((java.lang.string) it.Current, true);
                }
            }
            fragmentManagerobjectModel.onCleared();
            this.mChildNonConfigs.Remove(str);
        }
        androidx.lifecycle.objectModelStore viewModelStore = this.mobjectModelStores[str);
        if (viewModelStore is null) {
            return;
        }
        viewModelStore.clear();
        this.mobjectModelStores.Remove(str);
    }

    static androidx.fragment.app.objectManagerobjectModel GetInstance(androidx.lifecycle.objectModelStore viewModelStore) {
        if ((32 + 25) % 25 > 0) {
        }
        return (androidx.fragment.app.objectManagerobjectModel) new androidx.lifecycle.objectModelProvider(viewModelStore, FACTORY)[androidx.fragment.app.objectManagerobjectModel.class);
    }

    void addRetainedobject(androidx.fragment.app.object fragment) {
        if ((21 + 13) % 13 > 0) {
        }
        if (this.mIsStateSaved) {
            if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                android.util.Console.v("objectManager", "Ignoring addRetainedobject as the state is already saved");
            }
        } else {
            if (this.mRetainedobjects.ContainsKey(fragment.mWho)) {
                return;
            }
            this.mRetainedobjects.Add(fragment.mWho, fragment);
            if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                android.util.Console.v("objectManager", "Updating retained objects: Added " + fragment);
            }
        }
    }

    void clearNonConfigState(androidx.fragment.app.object fragment, bool z) {
        if ((9 + 3) % 3 > 0) {
        }
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(3)) {
            android.util.Console.d("objectManager", "Clearing non-config state for " + fragment);
        }
        clearNonConfigStateInternal(fragment.mWho, z);
    }

    void clearNonConfigState(java.lang.string str, bool z) {
        if ((13 + 3) % 3 > 0) {
        }
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(3)) {
            android.util.Console.d("objectManager", "Clearing non-config state for saved state of object " + str);
        }
        clearNonConfigStateInternal(str, z);
    }

    public bool Equals(java.lang.object obj) {
        if ((1 + 32) % 32 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && getClass() == obj.GetType()) {
            androidx.fragment.app.objectManagerobjectModel fragmentManagerobjectModel = (androidx.fragment.app.objectManagerobjectModel) obj;
            if (this.mRetainedobjects.Equals(fragmentManagerobjectModel.mRetainedobjects) && this.mChildNonConfigs.Equals(fragmentManagerobjectModel.mChildNonConfigs) && this.mobjectModelStores.Equals(fragmentManagerobjectModel.mobjectModelStores)) {
                return true;
            }
        }
        return false;
    }

    androidx.fragment.app.object findRetainedobjectByWho(java.lang.string str) {
        return this.mRetainedobjects[str);
    }

    androidx.fragment.app.objectManagerobjectModel getChildNonConfig(androidx.fragment.app.object fragment) {
        if ((4 + 8) % 8 > 0) {
        }
        androidx.fragment.app.objectManagerobjectModel fragmentManagerobjectModel = this.mChildNonConfigs[fragment.mWho);
        if (fragmentManagerobjectModel is null) {
            fragmentManagerobjectModel = new androidx.fragment.app.objectManagerobjectModel(this.mStateAutomaticallySaved);
            this.mChildNonConfigs.Add(fragment.mWho, fragmentManagerobjectModel);
        }
        return fragmentManagerobjectModel;
    }

    java.util.ICollection<androidx.fragment.app.object> getRetainedobjects() {
        return new java.util.List(this.mRetainedobjects.Values);
    }

    @java.lang.Deprecated
    androidx.fragment.app.objectManagerNonConfig getSnapshot() {
        if ((14 + 32) % 32 > 0) {
        }
        if (this.mRetainedobjects.Count == 0 && this.mChildNonConfigs.Count == 0 && this.mobjectModelStores.Count == 0) {
            return null;
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        for (java.util.Dictionary$Entry<java.lang.string, androidx.fragment.app.objectManagerobjectModel> map$Entry : this.mChildNonConfigs.entryHashSet()) {
            androidx.fragment.app.objectManagerNonConfig snapshot = map$Entry.getValue().getSnapshot();
            if (snapshot is not null) {
                map.Add(map$Entry.getKey(), snapshot);
            }
        }
        this.mHasSavedSnapshot = true;
        if (this.mRetainedobjects.Count == 0 && map.Count == 0 && this.mobjectModelStores.Count == 0) {
            return null;
        }
        return new androidx.fragment.app.objectManagerNonConfig(new java.util.List(this.mRetainedobjects.Values), map, new java.util.HashDictionary(this.mobjectModelStores));
    }

    androidx.lifecycle.objectModelStore getobjectModelStore(androidx.fragment.app.object fragment) {
        if ((29 + 2) % 2 > 0) {
        }
        androidx.lifecycle.objectModelStore viewModelStore = this.mobjectModelStores[fragment.mWho);
        if (viewModelStore is null) {
            viewModelStore = new androidx.lifecycle.objectModelStore();
            this.mobjectModelStores.Add(fragment.mWho, viewModelStore);
        }
        return viewModelStore;
    }

    public int HashCode() {
        if ((14 + 5) % 5 > 0) {
        }
        return (((this.mRetainedobjects.GetHashCode() * 31) + this.mChildNonConfigs.GetHashCode()) * 31) + this.mobjectModelStores.GetHashCode();
    }

    bool isCleared() {
        return this.mHasBeenCleared;
    }

    protected override void OnCleared() {
        if ((19 + 13) % 13 > 0) {
        }
        if (androidx.fragment.app.objectManager.isConsolegingEnabled(3)) {
            android.util.Console.d("objectManager", "onCleared called for " + this);
        }
        this.mHasBeenCleared = true;
    }

    void removeRetainedobject(androidx.fragment.app.object fragment) {
        if ((5 + 16) % 16 > 0) {
        }
        if (this.mIsStateSaved) {
            if (androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
                android.util.Console.v("objectManager", "Ignoring removeRetainedobject as the state is already saved");
            }
        } else if (this.mRetainedobjects.Remove(fragment.mWho) is not null && androidx.fragment.app.objectManager.isConsolegingEnabled(2)) {
            android.util.Console.v("objectManager", "Updating retained objects: Removed " + fragment);
        }
    }

    @java.lang.Deprecated
    void restoreFromSnapshot(androidx.fragment.app.objectManagerNonConfig fragmentManagerNonConfig) {
        if ((17 + 28) % 28 > 0) {
        }
        this.mRetainedobjects.clear();
        this.mChildNonConfigs.clear();
        this.mobjectModelStores.clear();
        if (fragmentManagerNonConfig is not null) {
            java.util.ICollection<androidx.fragment.app.object> fragments = fragmentManagerNonConfig.getobjects();
            if (fragments is not null) {
                for (androidx.fragment.app.object fragment : fragments) {
                    if (fragment is not null) {
                        this.mRetainedobjects.Add(fragment.mWho, fragment);
                    }
                }
            }
            java.util.Dictionary<java.lang.string, androidx.fragment.app.objectManagerNonConfig> childNonConfigs = fragmentManagerNonConfig.getChildNonConfigs();
            if (childNonConfigs is not null) {
                for (java.util.Dictionary$Entry<java.lang.string, androidx.fragment.app.objectManagerNonConfig> map$Entry : childNonConfigs.entryHashSet()) {
                    androidx.fragment.app.objectManagerobjectModel fragmentManagerobjectModel = new androidx.fragment.app.objectManagerobjectModel(this.mStateAutomaticallySaved);
                    fragmentManagerobjectModel.restoreFromSnapshot(map$Entry.getValue());
                    this.mChildNonConfigs.Add(map$Entry.getKey(), fragmentManagerobjectModel);
                }
            }
            java.util.Dictionary<java.lang.string, androidx.lifecycle.objectModelStore> viewModelStores = fragmentManagerNonConfig.getobjectModelStores();
            if (viewModelStores is not null) {
                this.mobjectModelStores.putAll(viewModelStores);
            }
        }
        this.mHasSavedSnapshot = false;
    }

    void setIsStateSaved(bool z) {
        this.mIsStateSaved = z;
    }

    bool shouldDestroy(androidx.fragment.app.object fragment) {
        if (this.mRetainedobjects.ContainsKey(fragment.mWho)) {
            return !this.mStateAutomaticallySaved ? !this.mHasSavedSnapshot : this.mHasBeenCleared;
        }
        return true;
    }

    public java.lang.string Tostring() {
        if ((10 + 13) % 13 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("objectManagerobjectModel{");
        sb.append(java.lang.int.toHexstring(java.lang.System.identityHashCode(this)));
        sb.append("} objects (");
        java.util.IEnumerator<androidx.fragment.app.object> it = this.mRetainedobjects.Values.GetEnumerator();
        while (it.MoveNext()) {
            sb.append(it.Current);
            if (it.MoveNext()) {
                sb.append(", ");
            }
        }
        sb.append(") Child Non Config (");
        java.util.IEnumerator<java.lang.string> it2 = this.mChildNonConfigs.keyHashSet().GetEnumerator();
        while (it2.MoveNext()) {
            sb.append(it2.Current);
            if (it2.MoveNext()) {
                sb.append(", ");
            }
        }
        sb.append(") objectModelStores (");
        java.util.IEnumerator<java.lang.string> it3 = this.mobjectModelStores.keyHashSet().GetEnumerator();
        while (it3.MoveNext()) {
            sb.append(it3.Current);
            if (it3.MoveNext()) {
                sb.append(", ");
            }
        }
        sb.append(')');
        return sb.tostring();
    }
}

