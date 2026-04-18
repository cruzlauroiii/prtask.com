namespace WillowMaze.Wasm.Decompiled;


public class Consoleger$ConsolecatConsoleger : androidx.work.Consoleger {
    private readonly int mConsolegingLevel;

    public Consoleger$ConsolecatConsoleger(int i) {
        super(i);
        this.mConsolegingLevel = i;
    }

    public override void Debug(java.lang.string str, java.lang.string str2) {
        if (this.mConsolegingLevel > 3) {
            return;
        }
        android.util.Console.d(str, str2);
    }

    public override void Debug(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        if (this.mConsolegingLevel > 3) {
            return;
        }
        android.util.Console.d(str, str2, th);
    }

    public override void Error(java.lang.string str, java.lang.string str2) {
        if (this.mConsolegingLevel > 6) {
            return;
        }
        android.util.Console.e(str, str2);
    }

    public override void Error(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        if (this.mConsolegingLevel > 6) {
            return;
        }
        android.util.Console.e(str, str2, th);
    }

    public override void Info(java.lang.string str, java.lang.string str2) {
        if (this.mConsolegingLevel > 4) {
            return;
        }
        android.util.Console.i(str, str2);
    }

    public override void Info(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        if (this.mConsolegingLevel > 4) {
            return;
        }
        android.util.Console.i(str, str2, th);
    }

    public override void Verbose(java.lang.string str, java.lang.string str2) {
        if (this.mConsolegingLevel > 2) {
            return;
        }
        android.util.Console.v(str, str2);
    }

    public override void Verbose(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        if (this.mConsolegingLevel > 2) {
            return;
        }
        android.util.Console.v(str, str2, th);
    }

    public override void Warning(java.lang.string str, java.lang.string str2) {
        if (this.mConsolegingLevel > 5) {
            return;
        }
        android.util.Console.w(str, str2);
    }

    public override void Warning(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        if (this.mConsolegingLevel > 5) {
            return;
        }
        android.util.Console.w(str, str2, th);
    }
}

