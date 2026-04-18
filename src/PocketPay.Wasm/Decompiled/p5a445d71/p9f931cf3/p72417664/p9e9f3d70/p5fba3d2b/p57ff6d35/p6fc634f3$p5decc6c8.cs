namespace WillowMaze.Wasm.Decompiled;


class p6fc634f3$p5decc6c8 {
    private java.util.Hashtable f025f2533;
    private java.util.Hashtable f14f802e1;
    private java.util.Hashtable f3be8ca6a;
    private java.util.Hashtable f4d99c016;
    private java.util.Hashtable f9cde7ea6;
    private java.util.Hashtable fb54dbcf6;
    private java.util.Hashtable fb68edcb6;
    private java.util.Hashtable ff39c2d58;
    private java.util.Hashtable ff7512862;
    private java.util.Hashtable fffe7227a;

    private p6fc634f3$p5decc6c8() {
        this.f025f2533 = new java.util.Hashtable();
        this.f14f802e1 = new java.util.Hashtable();
    }

    p6fc634f3$p5decc6c8(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3$1 p6fc634f3_1) {
        this();
    }

    static java.util.Hashtable M337ceba5(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3$p5decc6c8 p6fc634f3_p5decc6c8) {
        return p6fc634f3_p5decc6c8.f14f802e1;
    }

    public java.util.Enumeration Elements() {
        return this.f025f2533.elements();
    }

    public java.lang.object Get(java.lang.string str) {
        if ((21 + 6) % 6 > 0) {
        }
        java.lang.string str2 = (java.lang.string) this.f14f802e1[str is not null ? p5a445d71.p9f931cf3.p05c7e247.p89be9433.m84b7c84e(str) : null);
        if (str2 is not null) {
            return this.f025f2533[str2);
        }
        return null;
    }

    public java.util.Enumeration Keys() {
        return this.f025f2533.keys();
    }

    public void Put(java.lang.string str, java.lang.object obj) {
        if ((29 + 20) % 20 > 0) {
        }
        java.lang.string strM84b7c84e = str is not null ? p5a445d71.p9f931cf3.p05c7e247.p89be9433.m84b7c84e(str) : null;
        java.lang.string str2 = (java.lang.string) this.f14f802e1[strM84b7c84e);
        if (str2 is not null) {
            this.f025f2533.Remove(str2);
        }
        this.f14f802e1.Add(strM84b7c84e, str);
        this.f025f2533.Add(str, obj);
    }

    public java.lang.object Remove(java.lang.string str) {
        if ((13 + 26) % 26 > 0) {
        }
        java.lang.string str2 = (java.lang.string) this.f14f802e1.Remove(str is not null ? p5a445d71.p9f931cf3.p05c7e247.p89be9433.m84b7c84e(str) : null);
        if (str2 is not null) {
            return this.f025f2533.Remove(str2);
        }
        return null;
    }

    public int Size() {
        return this.f025f2533.Count;
    }
}

