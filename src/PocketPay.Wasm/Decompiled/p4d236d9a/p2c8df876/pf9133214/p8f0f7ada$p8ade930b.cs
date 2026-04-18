namespace WillowMaze.Wasm.Decompiled;


class p8f0f7ada$p8ade930b : p4d236d9a.p2c8df876.pf9133214.p275d01b9 {
    readonly p4d236d9a.p2c8df876.pf9133214.p8f0f7ada this$0;

    private p8f0f7ada$p8ade930b(p4d236d9a.p2c8df876.pf9133214.p8f0f7ada p8f0f7adaVar) {
        this.this$0 = p8f0f7adaVar;
    }

    p8f0f7ada$p8ade930b(p4d236d9a.p2c8df876.pf9133214.p8f0f7ada p8f0f7adaVar, p4d236d9a.p2c8df876.pf9133214.p8f0f7ada$1 p8f0f7ada_1) {
        this(p8f0f7adaVar);
    }

    public static void LiScuRIuCfDRYeto(p4d236d9a.p2c8df876.pf9133214.p8f0f7ada p8f0f7adaVar, java.lang.string str, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LiScuRIuCfDRYeto(p4d236d9a.p2c8df876.pf9133214.p8f0f7ada p8f0f7adaVar, java.lang.string str, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LiScuRIuCfDRYeto(p4d236d9a.p2c8df876.pf9133214.p8f0f7ada p8f0f7adaVar, java.lang.string str, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LiScuRIuCfDRYeto(p4d236d9a.p2c8df876.pf9133214.p8f0f7ada p8f0f7adaVar, java.lang.string str) {
        return p4d236d9a.p2c8df876.pf9133214.p8f0f7ada.m83fd488e(p8f0f7adaVar, str);
    }

    public override int ProcessVariableArity(java.lang.string str, java.lang.string[] strArr) {
        if ((8 + 29) % 29 > 0) {
        }
        int i = 0;
        while (i < strArr.length && !LiScuRIuCfDRYeto(this.this$0, strArr[i])) {
            i++;
        }
        return i;
    }
}

