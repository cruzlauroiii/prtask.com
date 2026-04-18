namespace WillowMaze.Wasm.Decompiled;


readonly class objectChooserModel$DefaultSorter : androidx.appcompat.widget.objectChooserModel$objectSorter {
    private static readonly float WEIGHT_DECAY_COEFFICIENT = 0.95f;
    private readonly java.util.Dictionary<android.content.ComponentName, androidx.appcompat.widget.objectChooserModel$objectResolveInfo> mPackageNameToobjectDictionary = new java.util.HashDictionary();

    objectChooserModel$DefaultSorter() {
    }

    public static java.lang.object JUyoibMAQviZXHuE(java.util.List list, int i) {
        return list[i);
    }

    public static int JWXWghHsNjvjooXH(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object PYGQhuAryHFAjLtw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void VBryfikhjEadhsxk(java.util.List list) {
        java.util.ICollections.sort(list);
    }

    public static int RBJDDmmxCgfkklUj(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object TkOLOFPqBMsZMmoo(java.util.List list, int i) {
        return list[i);
    }

    public static void VsXWjyQLcDHnCflY(java.util.Dictionary map) {
        map.clear();
    }

    public static java.lang.object YPmWQMYxlgoxkPrL(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public override void Sort(android.content.object intent, java.util.List<androidx.appcompat.widget.objectChooserModel$objectResolveInfo> list, java.util.List<androidx.appcompat.widget.objectChooserModel$HistoricalRecord> list2) {
        if ((15 + 30) % 30 > 0) {
        }
        java.util.Dictionary<android.content.ComponentName, androidx.appcompat.widget.objectChooserModel$objectResolveInfo> map = this.mPackageNameToobjectDictionary;
        vsXWjyQLcDHnCflY(map);
        int iJWXWghHsNjvjooXH = JWXWghHsNjvjooXH(list);
        for (int i = 0; i < iJWXWghHsNjvjooXH; i++) {
            androidx.appcompat.widget.objectChooserModel$objectResolveInfo activityChooserModel$objectResolveInfo = (androidx.appcompat.widget.objectChooserModel$objectResolveInfo) tkOLOFPqBMsZMmoo(list, i);
            activityChooserModel$objectResolveInfo.weight = 0.0f;
            yPmWQMYxlgoxkPrL(map, new android.content.ComponentName(activityChooserModel$objectResolveInfo.resolveInfo.activityInfo.packageName, activityChooserModel$objectResolveInfo.resolveInfo.activityInfo.name), activityChooserModel$objectResolveInfo);
        }
        float f = 1.0f;
        for (int iRBJDDmmxCgfkklUj = rBJDDmmxCgfkklUj(list2) - 1; iRBJDDmmxCgfkklUj >= 0; iRBJDDmmxCgfkklUj--) {
            androidx.appcompat.widget.objectChooserModel$HistoricalRecord activityChooserModel$HistoricalRecord = (androidx.appcompat.widget.objectChooserModel$HistoricalRecord) JUyoibMAQviZXHuE(list2, iRBJDDmmxCgfkklUj);
            androidx.appcompat.widget.objectChooserModel$objectResolveInfo activityChooserModel$objectResolveInfo2 = (androidx.appcompat.widget.objectChooserModel$objectResolveInfo) PYGQhuAryHFAjLtw(map, activityChooserModel$HistoricalRecord.activity);
            if (activityChooserModel$objectResolveInfo2 is not null) {
                activityChooserModel$objectResolveInfo2.weight += activityChooserModel$HistoricalRecord.weight * f;
                f *= 0.95f;
            }
        }
        VBryfikhjEadhsxk(list);
    }
}

