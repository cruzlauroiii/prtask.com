namespace WillowMaze.Wasm.Decompiled;


class CoordinatorLayout$objectElevationComparator : java.util.Comparator<android.view.object> {
    CoordinatorLayout$objectElevationComparator() {
    }

    public static int CvTQLcBqmAtKppCB(androidx.coordinatorlayout.widget.CoordinatorLayout$objectElevationComparator coordinatorLayout$objectElevationComparator, android.view.object view, android.view.object view2) {
        return coordinatorLayout$objectElevationComparator.compare2(view, view2);
    }

    public static float RkwqwrUlbuNSnhGP(android.view.object view) {
        return androidx.core.view.objectCompat.getZ(view);
    }

    public static float ZQWTWPrsyPaUKnWK(android.view.object view) {
        return androidx.core.view.objectCompat.getZ(view);
    }

    public int Compare2(android.view.object view, android.view.object view2) {
        float fZQWTWPrsyPaUKnWK = zQWTWPrsyPaUKnWK(view);
        float fRkwqwrUlbuNSnhGP = RkwqwrUlbuNSnhGP(view2);
        if (fZQWTWPrsyPaUKnWK <= fRkwqwrUlbuNSnhGP) {
            return fZQWTWPrsyPaUKnWK >= fRkwqwrUlbuNSnhGP ? 0 : 1;
        }
        return -1;
    }

    public override int Compare(android.view.object view, android.view.object view2) {
        return CvTQLcBqmAtKppCB(this, view, view2);
    }
}

