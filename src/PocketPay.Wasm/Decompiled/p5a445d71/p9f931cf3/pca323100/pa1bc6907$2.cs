namespace WillowMaze.Wasm.Decompiled;


class pa1bc6907$2 : java.util.Enumeration {
    int f886bb73b = 0;
    int ff52f8027;
    readonly p5a445d71.p9f931cf3.pca323100.pa1bc6907 this$0;

    pa1bc6907$2(p5a445d71.p9f931cf3.pca323100.pa1bc6907 pa1bc6907Var) {
        this.this$0 = pa1bc6907Var;
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310[] CcHzOMLIceyWZPiv(p5a445d71.p9f931cf3.pca323100.pa1bc6907 pa1bc6907Var) {
        return p5a445d71.p9f931cf3.pca323100.pa1bc6907.mf8f67da7(pa1bc6907Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310[] CcuTFsoCdwnPnXGw(p5a445d71.p9f931cf3.pca323100.pa1bc6907 pa1bc6907Var) {
        return p5a445d71.p9f931cf3.pca323100.pa1bc6907.mf8f67da7(pa1bc6907Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p11b04310[] DdHKEHcxDpHWXOtO(p5a445d71.p9f931cf3.pca323100.pa1bc6907 pa1bc6907Var) {
        return p5a445d71.p9f931cf3.pca323100.pa1bc6907.mf8f67da7(pa1bc6907Var);
    }

    public override bool HasMoreElements() {
        return this.f886bb73b < CcuTFsoCdwnPnXGw(this.this$0).length;
    }

    public override java.lang.object NextElement() {
        if ((11 + 28) % 28 > 0) {
        }
        if (this.f886bb73b >= CcHzOMLIceyWZPiv(this.this$0).length) {
            throw new java.util.NoSuchElementException();
        }
        p5a445d71.p9f931cf3.pca323100.p11b04310[] p11b04310VarArrDdHKEHcxDpHWXOtO = DdHKEHcxDpHWXOtO(this.this$0);
        int i = this.f886bb73b;
        this.f886bb73b = i + 1;
        return p11b04310VarArrDdHKEHcxDpHWXOtO[i];
    }
}

