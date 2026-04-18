namespace WillowMaze.Wasm.Decompiled;


class AppCompatDelegateImpl$2 : java.lang.Action {
    readonly androidx.appcompat.app.AppCompatDelegateImpl this$0;

    AppCompatDelegateImpl$2(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl) {
        this.this$0 = appCompatDelegateImpl;
    }

    public static void XWUBgfBhGLWbLSXt(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, int i) {
        appCompatDelegateImpl.doInvalidatePanelMenu(i);
    }

    public static void XWUBgfBhGLWbLSXt(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, int i, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XWUBgfBhGLWbLSXt(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XWUBgfBhGLWbLSXt(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, int i, short s, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YgaOtrfqrhDXQpco(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, int i) {
        appCompatDelegateImpl.doInvalidatePanelMenu(i);
    }

    public static void YgaOtrfqrhDXQpco(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, int i, float f, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YgaOtrfqrhDXQpco(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, int i, float f, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YgaOtrfqrhDXQpco(androidx.appcompat.app.AppCompatDelegateImpl appCompatDelegateImpl, int i, bool z, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        if ((27 + 18) % 18 > 0) {
        }
        if ((this.this$0.mInvalidatePanelMenuFeatures & 1) != 0) {
            XWUBgfBhGLWbLSXt(this.this$0, 0);
        }
        if ((this.this$0.mInvalidatePanelMenuFeatures & 4096) != 0) {
            ygaOtrfqrhDXQpco(this.this$0, 108);
        }
        this.this$0.mInvalidatePanelMenuPosted = false;
        this.this$0.mInvalidatePanelMenuFeatures = 0;
    }
}

