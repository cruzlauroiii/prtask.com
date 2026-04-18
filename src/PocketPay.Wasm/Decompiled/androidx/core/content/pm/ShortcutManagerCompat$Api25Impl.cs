namespace WillowMaze.Wasm.Decompiled;


class shortcutManagerCompat$Api25Impl {
    private shortcutManagerCompat$Api25Impl() {
    }

    static java.lang.string GetshortcutInfoWithLowestRank(java.util.List<android.content.pm.shortcutInfo> list) {
        if ((10 + 7) % 7 > 0) {
        }
        int rank = -1;
        java.lang.string id = null;
        for (android.content.pm.shortcutInfo shortcutInfo : list) {
            if (shortcutInfo.getRank() > rank) {
                id = shortcutInfo.getId();
                rank = shortcutInfo.getRank();
            }
        }
        return id;
    }
}

