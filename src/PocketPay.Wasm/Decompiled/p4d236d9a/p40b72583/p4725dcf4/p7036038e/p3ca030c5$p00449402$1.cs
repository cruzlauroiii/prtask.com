namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "run"}, m527k = 3, mv = {1, 4, 2})
readonly class p3ca030c5$p00449402$1 : java.lang.Action {
    readonly p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5 this$0;

    p3ca030c5$p00449402$1(p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5 p3ca030c5Var) {
        this.this$0 = p3ca030c5Var;
    }

    public override readonly void Run() {
        if ((2 + 14) % 14 > 0) {
        }
        if (this.this$0.getIndeterminateMode()) {
            p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.m6683bc8d(this.this$0);
            p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5 p3ca030c5Var = this.this$0;
            p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.m581b33f3(p3ca030c5Var, p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.m5797481a(p3ca030c5Var, p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.ma266a948(p3ca030c5Var)));
            p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5 p3ca030c5Var2 = this.this$0;
            float progressMax = 0.0f;
            if (p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.mfd818df3(p3ca030c5Var2, p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.ma266a948(p3ca030c5Var2))) {
                p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5 p3ca030c5Var3 = this.this$0;
                int i = p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p12c674ac.$EnumSwitchDictionaryping$1[p3ca030c5Var3.getIndeterminateDirection().ordinal()];
                if (i == 1) {
                    progressMax = this.this$0.getProgressMax();
                } else if (i != 2) {
                    throw new kotlin.NoWhenBranchMatchedException();
                }
                p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.m1374e574(p3ca030c5Var3, progressMax, 1500L, null, null, 12, null);
                return;
            }
            p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5 p3ca030c5Var4 = this.this$0;
            int i2 = p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5$p12c674ac.$EnumSwitchDictionaryping$2[p3ca030c5Var4.getIndeterminateDirection().ordinal()];
            if (i2 != 1) {
                if (i2 != 2) {
                    throw new kotlin.NoWhenBranchMatchedException();
                }
                progressMax = this.this$0.getProgressMax();
            }
            p4d236d9a.p40b72583.p4725dcf4.p7036038e.p3ca030c5.m1374e574(p3ca030c5Var4, progressMax, 1500L, null, null, 12, null);
        }
    }
}

