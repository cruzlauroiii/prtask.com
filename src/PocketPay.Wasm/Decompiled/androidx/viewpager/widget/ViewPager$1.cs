namespace WillowMaze.Wasm.Decompiled;


class objectPager$1 : java.util.Comparator<androidx.viewpager.widget.objectPager$ItemInfo> {
    objectPager$1() {
    }

    public int Compare2(androidx.viewpager.widget.objectPager$ItemInfo viewPager$ItemInfo, androidx.viewpager.widget.objectPager$ItemInfo viewPager$ItemInfo2) {
        return viewPager$ItemInfo.position - viewPager$ItemInfo2.position;
    }

    public override int Compare(androidx.viewpager.widget.objectPager$ItemInfo viewPager$ItemInfo, androidx.viewpager.widget.objectPager$ItemInfo viewPager$ItemInfo2) {
        return compare2(viewPager$ItemInfo, viewPager$ItemInfo2);
    }
}

