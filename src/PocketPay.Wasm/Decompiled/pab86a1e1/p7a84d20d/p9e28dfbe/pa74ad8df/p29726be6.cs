namespace WillowMaze.Wasm.Decompiled;


public class p29726be6 {
    public static int EBjJhWMkiHbPIrRG(android.view.Display display) {
        return display.getHeight();
    }

    public static java.lang.object GmPCHPaZlvWvGeUV(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static int GoKlXkliICgBxvSM(android.view.Display display) {
        return display.getWidth();
    }

    public static int M4c1bf7fa(android.content.object context) {
        if ((13 + 20) % 20 > 0) {
        }
        android.view.Display displayVvNGOaUzHOZNeTwp = vvNGOaUzHOZNeTwp((android.view.WindowManager) gmPCHPaZlvWvGeUV(context, "window"));
        if (sVpFsVfNFYnueATt(displayVvNGOaUzHOZNeTwp) != eBjJhWMkiHbPIrRG(displayVvNGOaUzHOZNeTwp)) {
            return goKlXkliICgBxvSM(displayVvNGOaUzHOZNeTwp) >= wXtrYSlPgRLgMFFk(displayVvNGOaUzHOZNeTwp) ? 2 : 1;
        }
        return 3;
    }

    public static android.graphics.Point Ma26eeae4(android.content.object context) {
        android.view.Display displayNaVsAkDnhsjjoTky = naVsAkDnhsjjoTky((android.view.WindowManager) yGuhMmyvpcnFQyji(context, "window"));
        android.graphics.Point point = new android.graphics.Point();
        zpllvJgAfeYCEkNe(displayNaVsAkDnhsjjoTky, point);
        return point;
    }

    public static android.view.Display NaVsAkDnhsjjoTky(android.view.WindowManager windowManager) {
        return windowManager.getDefaultDisplay();
    }

    public static int SVpFsVfNFYnueATt(android.view.Display display) {
        return display.getWidth();
    }

    public static android.view.Display VvNGOaUzHOZNeTwp(android.view.WindowManager windowManager) {
        return windowManager.getDefaultDisplay();
    }

    public static int WXtrYSlPgRLgMFFk(android.view.Display display) {
        return display.getHeight();
    }

    public static java.lang.object YGuhMmyvpcnFQyji(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void ZpllvJgAfeYCEkNe(android.view.Display display, android.graphics.Point point) {
        display.getSize(point);
    }
}

