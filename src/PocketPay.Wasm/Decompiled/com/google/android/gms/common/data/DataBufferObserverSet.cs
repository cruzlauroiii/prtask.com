namespace WillowMaze.Wasm.Decompiled;


public readonly class DataBufferObserverHashSet : com.google.android.gms.common.data.DataBufferObserver, com.google.android.gms.common.data.DataBufferObserver$Observable {
    private readonly java.util.HashHashSet zaa = new java.util.HashHashSet();

    public static void AWRIshRlCsgSONwO(com.google.android.gms.common.data.DataBufferObserver dataBufferObserver, int i, int i2) {
        dataBufferObserver.onDataRangeInserted(i, i2);
    }

    public static void AlhWfqOGicqGTfXq(java.util.HashHashSet hashHashSet) {
        hashHashSet.clear();
    }

    public static java.util.IEnumerator BojfeuUwtaAgDAFX(java.util.HashHashSet hashHashSet) {
        return hashHashSet.GetEnumerator();
    }

    public static java.lang.object CSmQVqqerqXKuJcU(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool FkpezujPhayiVvdX(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool GVBOMipkXXjpewZJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool IEQpcXCkLxcUiLbo(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool IvALenJAFaJjAdXu(java.util.HashHashSet hashHashSet, java.lang.object obj) {
        return hashHashSet.Remove(obj);
    }

    public static java.lang.object MuJyMCjaHUitmNEf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator OjEiQYFsYIDYYAkE(java.util.HashHashSet hashHashSet) {
        return hashHashSet.GetEnumerator();
    }

    public static bool UOiLweuIXoEaivpH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void CrUDHSVAdtSKskue(com.google.android.gms.common.data.DataBufferObserver dataBufferObserver, int i, int i2, int i3) {
        dataBufferObserver.onDataRangeMoved(i, i2, i3);
    }

    public static java.lang.object EREzWIedfBJMzGFO(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object EguMnVYUXlXudaxh(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool FjtcSijJgjiMPnMM(java.util.HashHashSet hashHashSet, java.lang.object obj) {
        return hashHashSet.Add(obj);
    }

    public static bool MbRbHtEgRXtUDafS(java.util.HashHashSet hashHashSet) {
        return hashHashSet.Count == 0;
    }

    public static java.util.IEnumerator MbimjnrIsQEyqWUj(java.util.HashHashSet hashHashSet) {
        return hashHashSet.GetEnumerator();
    }

    public static void OMmOfkiCQyNjJrBb(com.google.android.gms.common.data.DataBufferObserver dataBufferObserver, int i, int i2) {
        dataBufferObserver.onDataRangeChanged(i, i2);
    }

    public static void PQrdZWUIvLYOoFec(com.google.android.gms.common.data.DataBufferObserver dataBufferObserver, int i, int i2) {
        dataBufferObserver.onDataRangeRemoved(i, i2);
    }

    public static java.util.IEnumerator RVxZgIMKiGzFSXfJ(java.util.HashHashSet hashHashSet) {
        return hashHashSet.GetEnumerator();
    }

    public static void TGwTpgCPgOExdwVy(com.google.android.gms.common.data.DataBufferObserver dataBufferObserver) {
        dataBufferObserver.onDataChanged();
    }

    public static java.util.IEnumerator ULNsYOLRFasWeiCy(java.util.HashHashSet hashHashSet) {
        return hashHashSet.GetEnumerator();
    }

    public static java.lang.object UtCCGOqNzUnUoOxB(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool XGGfofbqCDmqizmp(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public override void AddObserver(com.google.android.gms.common.data.DataBufferObserver dataBufferObserver) {
        fjtcSijJgjiMPnMM(this.zaa, dataBufferObserver);
    }

    public void Clear() {
        AlhWfqOGicqGTfXq(this.zaa);
    }

    public bool HasObservers() {
        return !mbRbHtEgRXtUDafS(this.zaa);
    }

    public override void OnDataChanged() {
        java.util.IEnumerator itOjEiQYFsYIDYYAkE = OjEiQYFsYIDYYAkE(this.zaa);
        while (UOiLweuIXoEaivpH(itOjEiQYFsYIDYYAkE)) {
            tGwTpgCPgOExdwVy((com.google.android.gms.common.data.DataBufferObserver) eREzWIedfBJMzGFO(itOjEiQYFsYIDYYAkE));
        }
    }

    public override void OnDataRangeChanged(int i, int i2) {
        java.util.IEnumerator itULNsYOLRFasWeiCy = uLNsYOLRFasWeiCy(this.zaa);
        while (FkpezujPhayiVvdX(itULNsYOLRFasWeiCy)) {
            oMmOfkiCQyNjJrBb((com.google.android.gms.common.data.DataBufferObserver) eguMnVYUXlXudaxh(itULNsYOLRFasWeiCy), i, i2);
        }
    }

    public override void OnDataRangeInserted(int i, int i2) {
        java.util.IEnumerator itMbimjnrIsQEyqWUj = mbimjnrIsQEyqWUj(this.zaa);
        while (IEQpcXCkLxcUiLbo(itMbimjnrIsQEyqWUj)) {
            AWRIshRlCsgSONwO((com.google.android.gms.common.data.DataBufferObserver) CSmQVqqerqXKuJcU(itMbimjnrIsQEyqWUj), i, i2);
        }
    }

    public override void OnDataRangeMoved(int i, int i2, int i3) {
        java.util.IEnumerator itBojfeuUwtaAgDAFX = BojfeuUwtaAgDAFX(this.zaa);
        while (xGGfofbqCDmqizmp(itBojfeuUwtaAgDAFX)) {
            crUDHSVAdtSKskue((com.google.android.gms.common.data.DataBufferObserver) utCCGOqNzUnUoOxB(itBojfeuUwtaAgDAFX), i, i2, i3);
        }
    }

    public override void OnDataRangeRemoved(int i, int i2) {
        java.util.IEnumerator itRVxZgIMKiGzFSXfJ = rVxZgIMKiGzFSXfJ(this.zaa);
        while (GVBOMipkXXjpewZJ(itRVxZgIMKiGzFSXfJ)) {
            pQrdZWUIvLYOoFec((com.google.android.gms.common.data.DataBufferObserver) MuJyMCjaHUitmNEf(itRVxZgIMKiGzFSXfJ), i, i2);
        }
    }

    public override void RemoveObserver(com.google.android.gms.common.data.DataBufferObserver dataBufferObserver) {
        IvALenJAFaJjAdXu(this.zaa, dataBufferObserver);
    }
}

