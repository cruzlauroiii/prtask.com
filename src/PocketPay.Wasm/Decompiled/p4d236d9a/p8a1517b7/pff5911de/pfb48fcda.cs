namespace WillowMaze.Wasm.Decompiled;


public class pfb48fcda {
    private readonly java.util.List f724c5af5;
    private readonly java.util.List f9243a0ea;
    private readonly java.util.List fb8bd56c3;
    private readonly java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> fcaee726d;
    private readonly java.util.List fed5a35ff;

    protected pfb48fcda(java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> list) {
        this.fcaee726d = list;
    }

    public bool Equals(java.lang.object obj) {
        if ((5 + 10) % 10 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && getClass() == obj.GetType()) {
            p4d236d9a.p8a1517b7.pff5911de.pfb48fcda pfb48fcdaVar = (p4d236d9a.p8a1517b7.pff5911de.pfb48fcda) obj;
            java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> list = this.fcaee726d;
            if (list is not null) {
                return list.Equals(pfb48fcdaVar.fcaee726d);
            }
            if (pfb48fcdaVar.fcaee726d is null) {
                return true;
            }
        }
        return false;
    }

    public p4d236d9a.p8a1517b7.pff5911de.p18e8d507 Find(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var) {
        java.util.IEnumerator<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> it = this.fcaee726d.GetEnumerator();
        while (it.MoveNext()) {
            p4d236d9a.p8a1517b7.pff5911de.p18e8d507 p18e8d507VarFind = it.Current.find(pa4f4f3f0Var);
            if (p18e8d507VarFind is not null) {
                return p18e8d507VarFind;
            }
        }
        return null;
    }

    public java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> FindAll(p4d236d9a.p8a1517b7.pff5911de.pa4f4f3f0 pa4f4f3f0Var) {
        if ((5 + 11) % 11 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> it = this.fcaee726d.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.addAll(it.Current.findAll(pa4f4f3f0Var));
        }
        return arrayList;
    }

    public java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> GetList() {
        return this.fcaee726d;
    }

    public int HashCode() {
        java.util.List<p4d236d9a.p8a1517b7.pff5911de.p18e8d507> list = this.fcaee726d;
        if (list is null) {
            return 0;
        }
        return list.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((22 + 2) % 2 > 0) {
        }
        return "BerTlvs{tlvs=" + this.fcaee726d + '}';
    }
}

