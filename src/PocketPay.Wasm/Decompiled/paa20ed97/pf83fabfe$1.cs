namespace WillowMaze.Wasm.Decompiled;


class pf83fabfe$1 : p7ddcfee1.p406c70d6 {
    readonly paa20ed97.pf83fabfe this$0;
    readonly paa20ed97.p406c70d6 val$callback;

    pf83fabfe$1(paa20ed97.pf83fabfe pf83fabfeVar, paa20ed97.p406c70d6 p406c70d6Var) {
        this.this$0 = pf83fabfeVar;
        this.val$callback = p406c70d6Var;
    }

    private void CallFailure(java.lang.Exception th) {
        try {
            this.val$callback.onFailure(this.this$0, th);
        } catch (java.lang.Exception th2) {
            paa20ed97.pa470a233.throwIfFatal(th2);
            th2.printStackTrace();
        }
    }

    public override void OnFailure(p7ddcfee1.pc3755e61 pc3755e61Var, java.io.IOException iOException) {
        callFailure(iOException);
    }

    public override void OnResponse(p7ddcfee1.pc3755e61 pc3755e61Var, p7ddcfee1.pd64ed3e9 pd64ed3e9Var) {
        try {
            try {
                this.val$callback.onResponse(this.this$0, this.this$0.parseResponse(pd64ed3e9Var));
            } catch (java.lang.Exception th) {
                paa20ed97.pa470a233.throwIfFatal(th);
                th.printStackTrace();
            }
        } catch (java.lang.Exception th2) {
            paa20ed97.pa470a233.throwIfFatal(th2);
            callFailure(th2);
        }
    }
}

