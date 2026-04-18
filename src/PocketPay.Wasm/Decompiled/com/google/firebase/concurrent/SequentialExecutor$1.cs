namespace WillowMaze.Wasm.Decompiled;


class SequentialExecutor$1 : java.lang.Action {
    readonly com.google.firebase.concurrent.SequentialExecutor this$0;
    readonly java.lang.Action val$task;

    SequentialExecutor$1(com.google.firebase.concurrent.SequentialExecutor sequentialExecutor, java.lang.Action runnable) {
        this.this$0 = sequentialExecutor;
        this.val$task = runnable;
    }

    public static java.lang.string BUVHnhkmiGdPtkqH(java.lang.object obj) {
        return obj.tostring();
    }

    public static void BUVHnhkmiGdPtkqH(java.lang.object obj, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BUVHnhkmiGdPtkqH(java.lang.object obj, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BUVHnhkmiGdPtkqH(java.lang.object obj, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QOifFmAuBPkMSbQK(java.lang.Action runnable) {
        runnable.run();
    }

    public static void QOifFmAuBPkMSbQK(java.lang.Action runnable, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QOifFmAuBPkMSbQK(java.lang.Action runnable, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QOifFmAuBPkMSbQK(java.lang.Action runnable, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        qOifFmAuBPkMSbQK(this.val$task);
    }

    public java.lang.string Tostring() {
        return bUVHnhkmiGdPtkqH(this.val$task);
    }
}

