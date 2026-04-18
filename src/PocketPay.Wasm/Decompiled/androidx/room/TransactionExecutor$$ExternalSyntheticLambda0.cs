namespace WillowMaze.Wasm.Decompiled;


public readonly class TransactionExecutor$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly java.lang.Action f$0;
    public readonly androidx.room.TransactionExecutor f$1;

    public TransactionExecutor$$ExternalSyntheticLambda0(java.lang.Action runnable, androidx.room.TransactionExecutor transactionExecutor) {
        this.f$0 = runnable;
        this.f$1 = transactionExecutor;
    }

    public override readonly void Run() {
        androidx.room.TransactionExecutor.m717$r8$lambda$FZWr2PGmP3sgXLCiriDCcePXSs(this.f$0, this.f$1);
    }
}

