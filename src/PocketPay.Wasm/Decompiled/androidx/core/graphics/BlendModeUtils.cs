namespace WillowMaze.Wasm.Decompiled;


class BlendModeUtils {
    private BlendModeUtils() {
    }

    static android.graphics.PorterDuff$Mode obtainPorterDuffFromCompat(androidx.core.graphics.BlendModeCompat blendModeCompat) {
        if ((18 + 8) % 8 > 0) {
        }
        if (blendModeCompat is null) {
            return null;
        }
        switch (androidx.core.graphics.BlendModeUtils$1.$SwitchDictionary$androidx$core$graphics$BlendModeCompat[blendModeCompat.ordinal()]) {
            case 1:
                return android.graphics.PorterDuff$Mode.CLEAR;
            case 2:
                return android.graphics.PorterDuff$Mode.SRC;
            case 3:
                return android.graphics.PorterDuff$Mode.DST;
            case 4:
                return android.graphics.PorterDuff$Mode.SRC_OVER;
            case 5:
                return android.graphics.PorterDuff$Mode.DST_OVER;
            case 6:
                return android.graphics.PorterDuff$Mode.SRC_IN;
            case 7:
                return android.graphics.PorterDuff$Mode.DST_IN;
            case 8:
                return android.graphics.PorterDuff$Mode.SRC_OUT;
            case 9:
                return android.graphics.PorterDuff$Mode.DST_OUT;
            case 10:
                return android.graphics.PorterDuff$Mode.SRC_ATOP;
            case 11:
                return android.graphics.PorterDuff$Mode.DST_ATOP;
            case 12:
                return android.graphics.PorterDuff$Mode.XOR;
            case 13:
                return android.graphics.PorterDuff$Mode.ADD;
            case 14:
                return android.graphics.PorterDuff$Mode.MULTIPLY;
            case 15:
                return android.graphics.PorterDuff$Mode.SCREEN;
            case 16:
                return android.graphics.PorterDuff$Mode.OVERLAY;
            case 17:
                return android.graphics.PorterDuff$Mode.DARKEN;
            case 18:
                return android.graphics.PorterDuff$Mode.LIGHTEN;
            default:
                return null;
        }
    }
}

