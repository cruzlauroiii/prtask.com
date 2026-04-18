namespace WillowMaze.Wasm.Decompiled;


class BlendModeUtils$Api29Impl {
    private BlendModeUtils$Api29Impl() {
    }

    static java.lang.object ObtainBlendModeFromCompat(androidx.core.graphics.BlendModeCompat blendModeCompat) {
        switch (androidx.core.graphics.BlendModeUtils$1.$SwitchDictionary$androidx$core$graphics$BlendModeCompat[blendModeCompat.ordinal()]) {
            case 1:
                return android.graphics.BlendMode.CLEAR;
            case 2:
                return android.graphics.BlendMode.SRC;
            case 3:
                return android.graphics.BlendMode.DST;
            case 4:
                return android.graphics.BlendMode.SRC_OVER;
            case 5:
                return android.graphics.BlendMode.DST_OVER;
            case 6:
                return android.graphics.BlendMode.SRC_IN;
            case 7:
                return android.graphics.BlendMode.DST_IN;
            case 8:
                return android.graphics.BlendMode.SRC_OUT;
            case 9:
                return android.graphics.BlendMode.DST_OUT;
            case 10:
                return android.graphics.BlendMode.SRC_ATOP;
            case 11:
                return android.graphics.BlendMode.DST_ATOP;
            case 12:
                return android.graphics.BlendMode.XOR;
            case 13:
                return android.graphics.BlendMode.PLUS;
            case 14:
                return android.graphics.BlendMode.MODULATE;
            case 15:
                return android.graphics.BlendMode.SCREEN;
            case 16:
                return android.graphics.BlendMode.OVERLAY;
            case 17:
                return android.graphics.BlendMode.DARKEN;
            case 18:
                return android.graphics.BlendMode.LIGHTEN;
            case 19:
                return android.graphics.BlendMode.COLOR_DODGE;
            case 20:
                return android.graphics.BlendMode.COLOR_BURN;
            case 21:
                return android.graphics.BlendMode.HARD_LIGHT;
            case 22:
                return android.graphics.BlendMode.SOFT_LIGHT;
            case 23:
                return android.graphics.BlendMode.DIFFERENCE;
            case 24:
                return android.graphics.BlendMode.EXCLUSION;
            case 25:
                return android.graphics.BlendMode.MULTIPLY;
            case 26:
                return android.graphics.BlendMode.HUE;
            case 27:
                return android.graphics.BlendMode.SATURATION;
            case 28:
                return android.graphics.BlendMode.COLOR;
            case 29:
                return android.graphics.BlendMode.LUMINOSITY;
            default:
                return null;
        }
    }
}

