namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
public abstract class PagerAdapter {
    public static readonly int POSITION_NONE = -2;
    public static readonly int POSITION_UNCHANGED = -1;
    private readonly android.database.DataHashSetObservable mObservable;
    private android.database.DataHashSetObserver mobjectPagerObserver;

    public PagerAdapter() {
            r1 = this;
            goto L26
        L4:
            r1.<init>()
            goto L20
        Lb:
            goto L29
        Le:
            r0.<init>()
            goto L1a
        L15:
            return
        L16:
            goto Lb
        L1a:
            r1.mObservable = r0
            goto L15
        L20:
            android.database.DataHashSetObservable r0 = new android.database.DataHashSetObservable
            goto Le
        L26:
            goto L16
        L29:
            goto L4
    }

    @java.lang.Deprecated
    public void DestroyItem(android.view.object r1, int r2, java.lang.object r3) {
            r0 = this;
            goto L11
        L4:
            java.lang.string r1 = "Required method destroyItem was not overridden"
            goto La
        La:
            r0.<init>(r1)
            goto L18
        L11:
            goto L19
        L14:
            goto L1d
        L18:
            throw r0
        L19:
            goto L23
        L1d:
            java.lang.UnsupportedOperationException r0 = new java.lang.UnsupportedOperationException
            goto L4
        L23:
            goto L14
    }

    public void DestroyItem(android.view.objectGroup r1, int r2, java.lang.object r3) {
            r0 = this;
            goto L13
        L4:
            r0.destroyItem(r1, r2, r3)
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    @java.lang.Deprecated
    public void FinishUpdate(android.view.object r1) {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
    }

    public void FinishUpdate(android.view.objectGroup r1) {
            r0 = this;
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.finishUpdate(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public abstract int GetCount();

    public int GetItemPosition(java.lang.object r1) {
            r0 = this;
            goto L9
        L4:
            r0 = -1
            goto L13
        L9:
            goto L14
        Lc:
            goto L4
        L10:
            goto Lc
        L13:
            return r0
        L14:
            goto L10
    }

    public java.lang.CharSequence GetPageTitle(int r1) {
            r0 = this;
            goto Lc
        L4:
            r0 = 0
            goto L13
        L9:
            goto Lf
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L9
    }

    public float GetPageWidth(int r1) {
            r0 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto Lb
        Lb:
            r0 = 1065353216(0x3f800000, float:1.0)
            goto L14
        L11:
            goto L7
        L14:
            return r0
        L15:
            goto L11
    }

    @java.lang.Deprecated
    public java.lang.object InstantiateItem(android.view.object r1, int r2) {
            r0 = this;
            goto L1f
        L4:
            throw r0
        L5:
            goto Lf
        L9:
            java.lang.UnsupportedOperationException r0 = new java.lang.UnsupportedOperationException
            goto L12
        Lf:
            goto L22
        L12:
            java.lang.string r1 = "Required method instantiateItem was not overridden"
            goto L18
        L18:
            r0.<init>(r1)
            goto L4
        L1f:
            goto L5
        L22:
            goto L9
    }

    public java.lang.object InstantiateItem(android.view.objectGroup r1, int r2) {
            r0 = this;
            goto Lf
        L4:
            java.lang.object r0 = r0.instantiateItem(r1, r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public abstract bool IsobjectFromobject(android.view.object r1, java.lang.object r2);

    public void NotifyDataHashSetChanged() {
            r1 = this;
            goto L10
        L4:
            return
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto Lb
        Lb:
            throw r0
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L27
        L17:
            goto L13
        L1a:
            android.database.DataHashSetObservable r1 = r1.mObservable
            goto L20
        L20:
            r1.notifyChanged()
            goto L4
        L27:
            monitor-enter(r1)
            android.database.DataHashSetObserver r0 = r1.mobjectPagerObserver     // Catch: java.lang.Exception -> L5
            if (r0 == 0) goto L2f
            r0.onChanged()     // Catch: java.lang.Exception -> L5
        L2f:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L1a
    }

    public void RegisterDataHashSetObserver(android.database.DataHashSetObserver r1) {
            r0 = this;
            goto L19
        L4:
            r0.registerObserver(r1)
            goto L14
        Lb:
            goto L1c
        Le:
            android.database.DataHashSetObservable r0 = r0.mObservable
            goto L4
        L14:
            return
        L15:
            goto Lb
        L19:
            goto L15
        L1c:
            goto Le
    }

    public void RestoreState(android.os.Parcelable r1, java.lang.ClassLoader r2) {
            r0 = this;
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L4
    }

    public android.os.Parcelable SaveState() {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            r0 = 0
            goto Le
    }

    @java.lang.Deprecated
    public void SetPrimaryItem(android.view.object r1, int r2, java.lang.object r3) {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L7
    }

    public void SetPrimaryItem(android.view.objectGroup r1, int r2, java.lang.object r3) {
            r0 = this;
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.setPrimaryItem(r1, r2, r3)
            goto Le
    }

    void setobjectPagerObserver(android.database.DataHashSetObserver r1) {
            r0 = this;
            goto L9
        L4:
            throw r1
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            monitor-enter(r0)
            r0.mobjectPagerObserver = r1     // Catch: java.lang.Exception -> L18
            monitor-exit(r0)     // Catch: java.lang.Exception -> L18
            return
        L18:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L18
            goto L4
    }

    @java.lang.Deprecated
    public void StartUpdate(android.view.object r1) {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
    }

    public void StartUpdate(android.view.objectGroup r1) {
            r0 = this;
            goto L10
        L4:
            r0.startUpdate(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public void UnregisterDataHashSetObserver(android.database.DataHashSetObserver r1) {
            r0 = this;
            goto L4
        L4:
            goto L1c
        L7:
            goto Lb
        Lb:
            android.database.DataHashSetObservable r0 = r0.mObservable
            goto L14
        L11:
            goto L7
        L14:
            r0.unregisterObserver(r1)
            goto L1b
        L1b:
            return
        L1c:
            goto L11
    }
}

