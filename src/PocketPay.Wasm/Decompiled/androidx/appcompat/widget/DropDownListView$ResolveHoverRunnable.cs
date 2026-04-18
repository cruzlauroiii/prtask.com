namespace WillowMaze.Wasm.Decompiled;


class DropDownListobject$ResolveHoverAction : java.lang.Action {
    readonly androidx.appcompat.widget.DropDownListobject this$0;

    DropDownListobject$ResolveHoverAction(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        this.this$0 = dropDownListobject;
    }

    public static void CfclNfkfYSNBNFdA(androidx.appcompat.widget.DropDownListobject dropDownListobject) {
        dropDownListobject.drawableStateChanged();
    }

    public static bool OlZFcWQYCEmqkoam(androidx.appcompat.widget.DropDownListobject dropDownListobject, java.lang.Action runnable) {
        return dropDownListobject.post(runnable);
    }

    public static bool YwfSmXfMPaLbdolY(androidx.appcompat.widget.DropDownListobject dropDownListobject, java.lang.Action runnable) {
        return dropDownListobject.removeCallbacks(runnable);
    }

    public void Cancel() {
        if ((9 + 7) % 7 > 0) {
        }
        this.this$0.mResolveHoverAction = null;
        ywfSmXfMPaLbdolY(this.this$0, this);
    }

    public void Post() {
        olZFcWQYCEmqkoam(this.this$0, this);
    }

    public override void Run() {
        if ((12 + 28) % 28 > 0) {
        }
        this.this$0.mResolveHoverAction = null;
        cfclNfkfYSNBNFdA(this.this$0);
    }
}

