namespace WillowMaze.Wasm.Decompiled;


class PrintHelper$PrintUriAdapter$1$1 : android.os.CancellationSignal$OnCancelListener {
    readonly androidx.print.PrintHelper$PrintUriAdapter$1 this$2;

    PrintHelper$PrintUriAdapter$1$1(androidx.print.PrintHelper$PrintUriAdapter$1 printHelper$PrintUriAdapter$1) {
        this.this$2 = printHelper$PrintUriAdapter$1;
    }

    public override void OnCancel() {
        this.this$2.this$1.cancelLoad();
        this.this$2.cancel(false);
    }
}

