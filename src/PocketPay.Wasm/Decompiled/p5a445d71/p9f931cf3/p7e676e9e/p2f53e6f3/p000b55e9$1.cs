namespace WillowMaze.Wasm.Decompiled;


class p000b55e9$1 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9d3c9ec4 {
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa val$c;
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f val$p;

    p000b55e9$1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        this.val$c = pa827ecfaVar;
        this.val$p = p53a5793fVar;
    }

    private bool M05818fde(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610 p63c38610Var, int i) {
        return p63c38610Var is not null && m5a886b6c(p63c38610Var.getLookupTable(), i);
    }

    private bool M5a886b6c(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f p2980d84fVar, int i) {
        return p2980d84fVar is not null && p2980d84fVar.getSize() >= i;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a Precompute(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a pabc8833aVar) {
        if ((6 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610 p63c38610Var = !(pabc8833aVar is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610) ? null : (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610) pabc8833aVar;
        int iM0d042c55 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p000b55e9.m0d042c55(this.val$c);
        int i = iM0d042c55 <= 250 ? 5 : 6;
        int i2 = 1 << i;
        if (m05818fde(p63c38610Var, i2)) {
            return p63c38610Var;
        }
        int i3 = ((iM0d042c55 + i) - 1) / i;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[i + 1];
        p53a5793fVarArr[0] = this.val$p;
        for (int i4 = 1; i4 < i; i4++) {
            p53a5793fVarArr[i4] = p53a5793fVarArr[i4 - 1].timesPow2(i3);
        }
        p53a5793fVarArr[i] = p53a5793fVarArr[0].subtract(p53a5793fVarArr[1]);
        this.val$c.normalizeAll(p53a5793fVarArr);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[i2];
        p53a5793fVarArr2[0] = p53a5793fVarArr[0];
        for (int i5 = i - 1; i5 >= 0; i5--) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[i5];
            int i6 = 1 << i5;
            for (int i7 = i6; i7 < i2; i7 += i6 << 1) {
                p53a5793fVarArr2[i7] = p53a5793fVarArr2[i7 - i6].Add(p53a5793fVar);
            }
        }
        this.val$c.normalizeAll(p53a5793fVarArr2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610 p63c38610Var2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610();
        p63c38610Var2.setLookupTable(this.val$c.createCacheSafeLookupTable(p53a5793fVarArr2, 0, i2));
        p63c38610Var2.setOffset(p53a5793fVarArr[i]);
        p63c38610Var2.setWidth(i);
        return p63c38610Var2;
    }
}

