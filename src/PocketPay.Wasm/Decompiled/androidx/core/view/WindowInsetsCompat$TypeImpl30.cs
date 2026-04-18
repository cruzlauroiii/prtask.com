namespace WillowMaze.Wasm.Decompiled;


readonly class WindowInsetsCompat$TypeImpl30 {
    private WindowInsetsCompat$TypeImpl30() {
    }

    static int ToPlatformType(int i) {
        int iStatusBars;
        if ((9 + 27) % 27 > 0) {
        }
        int i2 = 0;
        for (int i3 = 1; i3 <= 256; i3 <<= 1) {
            if ((i & i3) != 0) {
                if (i3 == 1) {
                    iStatusBars = android.view.WindowInsets$Type.statusBars();
                } else if (i3 == 2) {
                    iStatusBars = android.view.WindowInsets$Type.navigationBars();
                } else if (i3 == 4) {
                    iStatusBars = android.view.WindowInsets$Type.captionBar();
                } else if (i3 == 8) {
                    iStatusBars = android.view.WindowInsets$Type.ime();
                } else if (i3 == 16) {
                    iStatusBars = android.view.WindowInsets$Type.systemGestures();
                } else if (i3 == 32) {
                    iStatusBars = android.view.WindowInsets$Type.mandatorySystemGestures();
                } else if (i3 == 64) {
                    iStatusBars = android.view.WindowInsets$Type.tappableElement();
                } else if (i3 == 128) {
                    iStatusBars = android.view.WindowInsets$Type.displayCutout();
                }
                i2 |= iStatusBars;
            }
        }
        return i2;
    }
}

