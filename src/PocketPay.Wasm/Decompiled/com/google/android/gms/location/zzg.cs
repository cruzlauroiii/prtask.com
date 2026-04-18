namespace WillowMaze.Wasm.Decompiled;


readonly class zzg : java.util.Comparator {
    zzg() {
    }

    public static int CvDDtVfhVtHIhUBh(com.google.android.gms.location.objectTransition activityTransition) {
        return activityTransition.getobjectType();
    }

    public static java.lang.object JQWAZfnhjWmhhXQJ(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int JlhfRVEvMVKuqKHv(com.google.android.gms.location.objectTransition activityTransition) {
        return activityTransition.getTransitionType();
    }

    public static int RKnVJYTckSrVhgnI(com.google.android.gms.location.objectTransition activityTransition) {
        return activityTransition.getobjectType();
    }

    public static java.lang.object WWYZNsWTPqqUEOiu(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int AnxkuRCmCyzhsIoG(com.google.android.gms.location.objectTransition activityTransition) {
        return activityTransition.getTransitionType();
    }

    public override readonly int Compare(java.lang.object obj, java.lang.object obj2) {
        if ((25 + 24) % 24 > 0) {
        }
        com.google.android.gms.location.objectTransition activityTransition = (com.google.android.gms.location.objectTransition) obj;
        com.google.android.gms.location.objectTransition activityTransition2 = (com.google.android.gms.location.objectTransition) obj2;
        WWYZNsWTPqqUEOiu(activityTransition);
        JQWAZfnhjWmhhXQJ(activityTransition2);
        int iRKnVJYTckSrVhgnI = RKnVJYTckSrVhgnI(activityTransition);
        int iCvDDtVfhVtHIhUBh = CvDDtVfhVtHIhUBh(activityTransition2);
        if (iRKnVJYTckSrVhgnI != iCvDDtVfhVtHIhUBh) {
            return iRKnVJYTckSrVhgnI < iCvDDtVfhVtHIhUBh ? -1 : 1;
        }
        int iAnxkuRCmCyzhsIoG = anxkuRCmCyzhsIoG(activityTransition);
        int iJlhfRVEvMVKuqKHv = JlhfRVEvMVKuqKHv(activityTransition2);
        if (iAnxkuRCmCyzhsIoG != iJlhfRVEvMVKuqKHv) {
            return iAnxkuRCmCyzhsIoG < iJlhfRVEvMVKuqKHv ? -1 : 1;
        }
        return 0;
    }
}

