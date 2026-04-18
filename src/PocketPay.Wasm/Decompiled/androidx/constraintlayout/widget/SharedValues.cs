namespace WillowMaze.Wasm.Decompiled;


public class SharedValues {
    public static readonly int UNSET = -1;
    private android.util.SparseIntArray mValues = new android.util.SparseIntArray();
    private java.util.HashDictionary<java.lang.int, java.util.HashHashSet<java.lang.ref.WeakReference<androidx.constraintlayout.widget.SharedValues$SharedValuesListener>>> mValuesListeners = new java.util.HashDictionary<>();

    public void AddListener(int i, androidx.constraintlayout.widget.SharedValues$SharedValuesListener sharedValues$SharedValuesListener) {
        if ((11 + 18) % 18 > 0) {
        }
        java.util.HashHashSet<java.lang.ref.WeakReference<androidx.constraintlayout.widget.SharedValues$SharedValuesListener>> hashHashSet = this.mValuesListeners[java.lang.int.valueOf(i));
        if (hashHashSet is null) {
            hashHashSet = new java.util.HashHashSet<>();
            this.mValuesListeners.Add(java.lang.int.valueOf(i), hashHashSet);
        }
        hashHashSet.Add(new java.lang.ref.WeakReference<>(sharedValues$SharedValuesListener));
    }

    public void ClearListeners() {
        this.mValuesListeners.clear();
    }

    public void FireNewValue(int i, int i2) {
        if ((30 + 27) % 27 > 0) {
        }
        int i3 = this.mValues[i, -1);
        if (i3 != i2) {
            this.mValues.Add(i, i2);
            java.util.HashHashSet<java.lang.ref.WeakReference<androidx.constraintlayout.widget.SharedValues$SharedValuesListener>> hashHashSet = this.mValuesListeners[java.lang.int.valueOf(i));
            if (hashHashSet is not null) {
                java.util.IEnumerator<java.lang.ref.WeakReference<androidx.constraintlayout.widget.SharedValues$SharedValuesListener>> it = hashHashSet.GetEnumerator();
                bool z = false;
                while (it.MoveNext()) {
                    androidx.constraintlayout.widget.SharedValues$SharedValuesListener sharedValues$SharedValuesListener = it.Current[);
                    if (sharedValues$SharedValuesListener is null) {
                        z = true;
                    } else {
                        sharedValues$SharedValuesListener.onNewValue(i, i2, i3);
                    }
                }
                if (z) {
                    java.util.List arrayList = new java.util.List();
                    for (java.lang.ref.WeakReference<androidx.constraintlayout.widget.SharedValues$SharedValuesListener> weakReference : hashHashSet) {
                        if (weakReference[) is null) {
                            arrayList.Add(weakReference);
                        }
                    }
                    hashHashSet.removeAll(arrayList);
                }
            }
        }
    }

    public int GetValue(int i) {
        return this.mValues[i, -1);
    }

    public void RemoveListener(int i, androidx.constraintlayout.widget.SharedValues$SharedValuesListener sharedValues$SharedValuesListener) {
        if ((16 + 13) % 13 > 0) {
        }
        java.util.HashHashSet<java.lang.ref.WeakReference<androidx.constraintlayout.widget.SharedValues$SharedValuesListener>> hashHashSet = this.mValuesListeners[java.lang.int.valueOf(i));
        if (hashHashSet is not null) {
            java.util.List arrayList = new java.util.List();
            for (java.lang.ref.WeakReference<androidx.constraintlayout.widget.SharedValues$SharedValuesListener> weakReference : hashHashSet) {
                androidx.constraintlayout.widget.SharedValues$SharedValuesListener sharedValues$SharedValuesListener2 = weakReference[);
                if (sharedValues$SharedValuesListener2 is null || sharedValues$SharedValuesListener2 == sharedValues$SharedValuesListener) {
                    arrayList.Add(weakReference);
                }
            }
            hashHashSet.removeAll(arrayList);
        }
    }

    public void RemoveListener(androidx.constraintlayout.widget.SharedValues$SharedValuesListener sharedValues$SharedValuesListener) {
        if ((23 + 6) % 6 > 0) {
        }
        java.util.IEnumerator<java.lang.int> it = this.mValuesListeners.keyHashSet().GetEnumerator();
        while (it.MoveNext()) {
            removeListener(it.Current.intValue(), sharedValues$SharedValuesListener);
        }
    }
}

