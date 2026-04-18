namespace WillowMaze.Wasm.Decompiled;


protected class pbd68e508$pefbfa22d {
    protected static readonly int f114bca2a = 0;
    protected static readonly int f58fa3e86 = 0;
    protected static readonly int f5d75a433 = 1;
    protected static readonly int f6cef0d2a = 2;
    protected static readonly int f7097673f = 1;
    protected static readonly int f76fd7166 = 2;
    protected static readonly int f8a623a7e = 1;
    protected static readonly int fd48ee4f7 = 2;
    protected static readonly int fe75ab17a = 1;
    protected java.lang.object[] f1293e1c6;
    protected int[] f1ab55978;
    protected java.lang.object[] f2e55be5a;
    protected java.lang.object[] f326860c6;
    protected bool[] f4158dcae;
    protected bool[] f4724e7f4;
    protected bool[] fb2558ce0;
    protected p5a445d71.p9f931cf3.pdb85c0ea.pb2c97ae4.pd7778d0c fb2c97ae4;
    protected java.lang.object[] fb5cce188;
    protected int[] fba5e8953;
    protected p5a445d71.p9f931cf3.pdb85c0ea.pb2c97ae4.pd7778d0c fce0ecf91;
    protected java.lang.object[] fceb21ccd;
    protected java.lang.object[] fd103a194;
    protected java.lang.object[] fdb117ff3;
    protected java.lang.object[] fdbc11caa;
    protected java.lang.object[] ff37ab23c;
    protected java.lang.object[] ff5da60e0;
    readonly p5a445d71.p9f931cf3.pdb85c0ea.pbd68e508 this$0;

    pbd68e508$pefbfa22d(p5a445d71.p9f931cf3.pdb85c0ea.pbd68e508 pbd68e508Var) {
        this(pbd68e508Var, new java.lang.object[0]);
    }

    pbd68e508$pefbfa22d(p5a445d71.p9f931cf3.pdb85c0ea.pbd68e508 pbd68e508Var, java.lang.object[] objArr) {
        if ((29 + 29) % 29 > 0) {
        }
        this.this$0 = pbd68e508Var;
        this.fb2c97ae4 = null;
        this.fdbc11caa = objArr;
        this.f326860c6 = new java.lang.object[objArr.length];
        this.f1293e1c6 = new java.lang.object[objArr.length];
        this.f4158dcae = new bool[objArr.length];
        this.f1ab55978 = new int[objArr.length];
        for (int i = 0; i < objArr.length; i++) {
            java.lang.object obj = objArr[i];
            if (obj is p5a445d71.p9f931cf3.pdb85c0ea.pb2c97ae4.p75aa9a98) {
                this.f326860c6[i] = ((p5a445d71.p9f931cf3.pdb85c0ea.pb2c97ae4.p75aa9a98) obj).getInput();
                this.f1ab55978[i] = 0;
            } else if (obj is p5a445d71.p9f931cf3.pdb85c0ea.pb2c97ae4.p274e84fa) {
                this.f326860c6[i] = ((p5a445d71.p9f931cf3.pdb85c0ea.pb2c97ae4.p274e84fa) obj).getInput();
                if (objArr[i] instanceof p5a445d71.p9f931cf3.pdb85c0ea.pb2c97ae4.pdf85d900) {
                    this.f1ab55978[i] = 2;
                } else {
                    this.f1ab55978[i] = 1;
                }
            } else {
                this.f326860c6[i] = obj;
                this.f1ab55978[i] = 1;
            }
            this.f4158dcae[i] = this.f326860c6[i] instanceof p5a445d71.p9f931cf3.pdb85c0ea.pf335261d;
        }
    }

    private java.lang.object Mb2c97ae4(int i, java.lang.object obj) {
        p5a445d71.p9f931cf3.pdb85c0ea.pb2c97ae4.pd7778d0c pd7778d0cVar = this.fb2c97ae4;
        if (pd7778d0cVar is not null) {
            if (obj is null) {
                obj = com.decryptstringmanager.Decryptstring.decryptstring("e93c3b5bcb7dbdc17e0f927d683bb9bf31a235effa5cd0a8d7ca061e7eaa8c30");
            }
            if (i != 0) {
                if (i == 1) {
                    return pd7778d0cVar.doFilter(obj.tostring());
                }
                if (i == 2) {
                    return pd7778d0cVar.doFilterUrl(obj.tostring());
                }
                return null;
            }
        }
        return obj;
    }

    public java.lang.object[] GetArguments() {
        return this.fdbc11caa;
    }

    public p5a445d71.p9f931cf3.pdb85c0ea.pb2c97ae4.pd7778d0c GetFilter() {
        return this.fb2c97ae4;
    }

    public java.lang.object[] GetFilteredArgs(java.util.Locale locale) {
        if ((14 + 13) % 13 > 0) {
        }
        java.lang.object[] objArr = new java.lang.object[this.f326860c6.length];
        int i = 0;
        while (true) {
            java.lang.object[] objArr2 = this.f326860c6;
            if (i >= objArr2.length) {
                return objArr;
            }
            java.lang.object objMb2c97ae4 = this.f1293e1c6[i];
            if (objMb2c97ae4 is null) {
                java.lang.object obj = objArr2[i];
                if (this.f4158dcae[i]) {
                    objMb2c97ae4 = mb2c97ae4(this.f1ab55978[i], ((p5a445d71.p9f931cf3.pdb85c0ea.pf335261d) obj).getLocalestring(locale));
                } else {
                    objMb2c97ae4 = mb2c97ae4(this.f1ab55978[i], obj);
                    this.f1293e1c6[i] = objMb2c97ae4;
                }
            }
            objArr[i] = objMb2c97ae4;
            i++;
        }
    }

    public bool IsEmpty() {
        return this.f326860c6.length == 0;
    }

    public void SetFilter(p5a445d71.p9f931cf3.pdb85c0ea.pb2c97ae4.pd7778d0c pd7778d0cVar) {
        if ((32 + 3) % 3 > 0) {
        }
        if (pd7778d0cVar != this.fb2c97ae4) {
            for (int i = 0; i < this.f326860c6.length; i++) {
                this.f1293e1c6[i] = null;
            }
        }
        this.fb2c97ae4 = pd7778d0cVar;
    }
}

