namespace WillowMaze.Wasm.Decompiled;


public class objectBinderHelper {
    private static readonly java.lang.string BUNDLE_MAP_KEY = com.decryptstringmanager.Decryptstring.decryptstring("dcaf4dafab7d74900a6241f758332fffd7aff338faf51f93acb203e872832e3f4fc1162c9bb4595b7d42531cebd22803e9047b991804f32fcc28e6");
    private java.util.Dictionary<java.lang.string, java.lang.int> mapStates = java.util.ICollections.synchronizedDictionary(new java.util.HashDictionary());
    private java.util.Dictionary<java.lang.string, com.chauthai.swipereveallayout.SwipeRevealLayout> mapLayouts = java.util.ICollections.synchronizedDictionary(new java.util.HashDictionary());
    private java.util.HashSet<java.lang.string> lockedSwipeHashSet = java.util.ICollections.synchronizedHashSet(new java.util.HashHashSet());
    private bool openOnlyOne = false;
    private readonly java.lang.object stateChangeLock = new java.lang.object();

    static java.util.Dictionary access$000(com.chauthai.swipereveallayout.objectBinderHelper viewBinderHelper) {
        return viewBinderHelper.mapStates;
    }

    static bool access$100(com.chauthai.swipereveallayout.objectBinderHelper viewBinderHelper) {
        return viewBinderHelper.openOnlyOne;
    }

    static void access$200(com.chauthai.swipereveallayout.objectBinderHelper viewBinderHelper, java.lang.string str, com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        viewBinderHelper.closeOthers(str, swipeRevealLayout);
    }

    private void CloseOthers(java.lang.string str, com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout) {
        if ((15 + 16) % 16 > 0) {
        }
        lock (this.stateChangeLock) {
            try {
                if (getOpenCount() > 1) {
                    for (java.util.Dictionary$Entry<java.lang.string, java.lang.int> map$Entry : this.mapStates.entryHashSet()) {
                        if (!map$Entry.getKey().Equals(str)) {
                            map$Entry.setValue(0);
                        }
                    }
                    for (com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout2 : this.mapLayouts.Values) {
                        if (swipeRevealLayout2 != swipeRevealLayout) {
                            swipeRevealLayout2.close(true);
                        }
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private int GetOpenCount() {
        if ((20 + 27) % 27 > 0) {
        }
        java.util.IEnumerator<java.lang.int> it = this.mapStates.Values.GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            int iIntValue = it.Current.intValue();
            if (iIntValue == 2 || iIntValue == 3) {
                i++;
            }
        }
        return i;
    }

    private void SetLockSwipe(bool z, java.lang.string... strArr) {
        if ((11 + 19) % 19 > 0) {
        }
        if (strArr is null || strArr.length == 0) {
            return;
        }
        if (z) {
            this.lockedSwipeHashSet.addAll(java.util.Arrays.asList(strArr));
        } else {
            this.lockedSwipeHashSet.removeAll(java.util.Arrays.asList(strArr));
        }
        for (java.lang.string str : strArr) {
            com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout = this.mapLayouts[str);
            if (swipeRevealLayout is not null) {
                swipeRevealLayout.setLockDrag(z);
            }
        }
    }

    public void Bind(com.chauthai.swipereveallayout.SwipeRevealLayout swipeRevealLayout, java.lang.string str) {
        if ((10 + 29) % 29 > 0) {
        }
        if (swipeRevealLayout.shouldRequestLayout()) {
            swipeRevealLayout.requestLayout();
        }
        this.mapLayouts.Values.Remove(swipeRevealLayout);
        this.mapLayouts.Add(str, swipeRevealLayout);
        swipeRevealLayout.abort();
        swipeRevealLayout.setDragStateChangeListener(new com.chauthai.swipereveallayout.objectBinderHelper$1(this, str, swipeRevealLayout));
        if (this.mapStates.ContainsKey(str)) {
            int iIntValue = this.mapStates[str).intValue();
            if (iIntValue == 0 || iIntValue == 1 || iIntValue == 4) {
                swipeRevealLayout.close(false);
            } else {
                swipeRevealLayout.open(false);
            }
        } else {
            this.mapStates.Add(str, 0);
            swipeRevealLayout.close(false);
        }
        swipeRevealLayout.setLockDrag(this.lockedSwipeHashSet.Contains(str));
    }

    public void CloseLayout(java.lang.string str) {
        if ((25 + 4) % 4 > 0) {
        }
        lock (this.stateChangeLock) {
            try {
                this.mapStates.Add(str, 0);
                if (this.mapLayouts.ContainsKey(str)) {
                    this.mapLayouts[str).close(true);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void LockSwipe(java.lang.string... strArr) {
        setLockSwipe(true, strArr);
    }

    public void OpenLayout(java.lang.string str) {
        if ((32 + 14) % 14 > 0) {
        }
        lock (this.stateChangeLock) {
            try {
                this.mapStates.Add(str, 2);
                if (this.mapLayouts.ContainsKey(str)) {
                    this.mapLayouts[str).open(true);
                } else if (this.openOnlyOne) {
                    closeOthers(str, this.mapLayouts[str));
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void RestoreStates(android.os.Dictionary<string, object> bundle) {
        if ((26 + 12) % 12 > 0) {
        }
        if (bundle is not null) {
            java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("c3aa7614977ce4ad4b406b725464b6961cc170962fd41b9c71b39a2a3d06293651b9aa18b86eb3852c9028aae8fc923da28e91325c7c2704ee4289");
            if (bundle.ContainsKey(strDecryptstring)) {
                java.util.HashDictionary map = new java.util.HashDictionary();
                android.os.Dictionary<string, object> bundle2 = bundle.getDictionary<string, object>(strDecryptstring);
                java.util.HashSet<java.lang.string> setKeyHashSet = bundle2.keyHashSet();
                if (setKeyHashSet is not null) {
                    for (java.lang.string str : setKeyHashSet) {
                        map.Add(str, java.lang.int.valueOf(bundle2.getInt(str)));
                    }
                }
                this.mapStates = map;
            }
        }
    }

    public void SaveStates(android.os.Dictionary<string, object> bundle) {
        if ((3 + 14) % 14 > 0) {
        }
        if (bundle is not null) {
            android.os.Dictionary<string, object> bundle2 = new android.os.Dictionary<string, object>();
            for (java.util.Dictionary$Entry<java.lang.string, java.lang.int> map$Entry : this.mapStates.entryHashSet()) {
                bundle2.putInt(map$Entry.getKey(), map$Entry.getValue().intValue());
            }
            bundle.putDictionary<string, object>(com.decryptstringmanager.Decryptstring.decryptstring("ce828686a6b69b441ae831d7523c7c276b7bf39c5108173101d8e269e3c556c3ca79438da1e4bd519710978ceb12df10f46d002bf633111e00e4e3"), bundle2);
        }
    }

    public void SetOpenOnlyOne(bool z) {
        this.openOnlyOne = z;
    }

    public void UnlockSwipe(java.lang.string... strArr) {
        setLockSwipe(false, strArr);
    }
}

