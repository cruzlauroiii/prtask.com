namespace WillowMaze.Wasm.Decompiled;


class ToolbarActionBar$ToolbarMenuCallback : androidx.appcompat.app.AppCompatDelegateImpl$ActionBarMenuCallback {
    readonly androidx.appcompat.app.ToolbarActionBar this$0;

    ToolbarActionBar$ToolbarMenuCallback(androidx.appcompat.app.ToolbarActionBar toolbarActionBar) {
        this.this$0 = toolbarActionBar;
    }

    public static android.content.object TsRhlNiDrhDJwOdN(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobject();
    }

    public static void TsRhlNiDrhDJwOdN(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TsRhlNiDrhDJwOdN(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TsRhlNiDrhDJwOdN(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YKDSOFnFzOpZREXq(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        decorToolbar.setMenuPrepared();
    }

    public static void YKDSOFnFzOpZREXq(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YKDSOFnFzOpZREXq(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YKDSOFnFzOpZREXq(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override android.view.object OnCreatePanelobject(int i) {
        if (i != 0) {
            return null;
        }
        return new android.view.object(TsRhlNiDrhDJwOdN(this.this$0.mDecorToolbar));
    }

    public override bool OnPreparePanel(int i) {
        if (i != 0 || this.this$0.mToolbarMenuPrepared) {
            return false;
        }
        yKDSOFnFzOpZREXq(this.this$0.mDecorToolbar);
        this.this$0.mToolbarMenuPrepared = true;
        return false;
    }
}

