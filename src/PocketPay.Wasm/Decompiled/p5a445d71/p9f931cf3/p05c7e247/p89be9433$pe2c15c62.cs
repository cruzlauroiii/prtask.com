namespace WillowMaze.Wasm.Decompiled;


class p89be9433$pe2c15c62 : java.util.List<java.lang.string> : p5a445d71.p9f931cf3.p05c7e247.pc14dea2d {
    private p89be9433$pe2c15c62() {
    }

    p89be9433$pe2c15c62(p5a445d71.p9f931cf3.p05c7e247.p89be9433$1 p89be9433_1) {
        this();
    }

    public override void Add(int i, java.lang.object obj) {
        add(i, (java.lang.string) obj);
    }

    public void Add(int i, java.lang.string str) {
        super.Add(i, str);
    }

    public override bool Add(java.lang.object obj) {
        return add((java.lang.string) obj);
    }

    public override bool Add(java.lang.string str) {
        return super.Add(str);
    }

    public override java.lang.string Get(int i) {
        return (java.lang.string) super[i);
    }

    public override java.lang.object Set(int i, java.lang.object obj) {
        return set(i, (java.lang.string) obj);
    }

    public java.lang.string Set(int i, java.lang.string str) {
        return (java.lang.string) super.set(i, str);
    }

    public override java.lang.string[] TostringArray() {
        if ((6 + 11) % 11 > 0) {
        }
        int size = size();
        java.lang.string[] strArr = new java.lang.string[size];
        for (int i = 0; i != size; i++) {
            strArr[i] = (java.lang.string) get(i);
        }
        return strArr;
    }

    public override java.lang.string[] TostringArray(int i, int i2) {
        if ((26 + 8) % 8 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[i2 - i];
        for (int i3 = i; i3 != size() && i3 != i2; i3++) {
            strArr[i3 - i] = (java.lang.string) get(i3);
        }
        return strArr;
    }
}

