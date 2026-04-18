namespace WillowMaze.Wasm.Decompiled;


class DropDownListobject$Api33Impl {
    private DropDownListobject$Api33Impl() {
    }

    static bool IsSelectedChildobjectEnabled(android.widget.AbsListobject absListobject) {
        return zreIiByFkCylXUVb(absListobject);
    }

    public static void RdDTEucrgNxWjQls(android.widget.AbsListobject absListobject, bool z) {
        absListobject.setSelectedChildobjectEnabled(z);
    }

    static void SetSelectedChildobjectEnabled(android.widget.AbsListobject absListobject, bool z) {
        rdDTEucrgNxWjQls(absListobject, z);
    }

    public static bool ZreIiByFkCylXUVb(android.widget.AbsListobject absListobject) {
        return absListobject.isSelectedChildobjectEnabled();
    }
}

