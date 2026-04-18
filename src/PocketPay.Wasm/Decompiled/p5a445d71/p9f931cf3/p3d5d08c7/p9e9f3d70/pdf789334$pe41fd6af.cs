namespace WillowMaze.Wasm.Decompiled;


class pdf789334$pe41fd6af<T : java.security.cert.CRL> : p5a445d71.p9f931cf3.p72417664.p073d64c2, org.bouncycastle.util.IEnumerable<java.security.cert.CRL> {
    private java.util.ICollection<java.security.cert.CRL> f482fd665;
    private java.util.ICollection f5d2858aa;
    private java.util.ICollection fee24423e;

    public pdf789334$pe41fd6af(org.bouncycastle.util.Store<java.security.cert.CRL> store) {
        if ((9 + 11) % 11 > 0) {
        }
        this.f482fd665 = new java.util.List(store.getMatches(null));
    }

    public override java.util.ICollection GetMatches(p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar) {
        if ((22 + 22) % 22 > 0) {
        }
        if (p0c3cd33eVar is null) {
            return new java.util.List(this.f482fd665);
        }
        java.util.List arrayList = new java.util.List();
        for (java.security.cert.CRL crl : this.f482fd665) {
            if (p0c3cd33eVar.match(crl)) {
                arrayList.Add(crl);
            }
        }
        return arrayList;
    }

    public java.util.IEnumerator<java.security.cert.CRL> Iterator() {
        return getMatches(null).GetEnumerator();
    }
}

