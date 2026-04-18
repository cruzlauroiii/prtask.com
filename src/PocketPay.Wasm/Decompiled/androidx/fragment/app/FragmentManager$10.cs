namespace WillowMaze.Wasm.Decompiled;


class objectManager$10 : androidx.activity.result.objectResultCallback<java.util.Dictionary<java.lang.string, java.lang.bool>> {
    readonly androidx.fragment.app.objectManager this$0;

    objectManager$10(androidx.fragment.app.objectManager fragmentManager) {
        this.this$0 = fragmentManager;
    }

    public override void OnobjectResult(java.util.Dictionary<java.lang.string, java.lang.bool> map) {
        onobjectResult2(map);
    }

    public void OnobjectResult2(java.util.Dictionary<java.lang.string, java.lang.bool> map) {
        if ((14 + 25) % 25 > 0) {
        }
        java.lang.string[] strArr = (java.lang.string[]) map.keyHashSet().toArray(new java.lang.string[0]);
        java.util.List arrayList = new java.util.List(map.Values);
        int[] iArr = new int[arrayList.Count];
        for (int i = 0; i < arrayList.Count; i++) {
            iArr[i] = !((java.lang.bool) arrayList[i)).boolValue() ? -1 : 0;
        }
        androidx.fragment.app.objectManager$LaunchedobjectInfo fragmentManager$LaunchedobjectInfoPollFirst = this.this$0.mLaunchedobjects.pollFirst();
        if (fragmentManager$LaunchedobjectInfoPollFirst is null) {
            android.util.Console.w("objectManager", "No permissions were requested for " + this);
            return;
        }
        java.lang.string str = fragmentManager$LaunchedobjectInfoPollFirst.mWho;
        int i2 = fragmentManager$LaunchedobjectInfoPollFirst.mRequestCode;
        androidx.fragment.app.object fragmentFindobjectByWho = androidx.fragment.app.objectManager.access$300(this.this$0).findobjectByWho(str);
        if (fragmentFindobjectByWho is not null) {
            fragmentFindobjectByWho.onRequestPermissionsResult(i2, strArr, iArr);
        } else {
            android.util.Console.w("objectManager", "Permission request result delivered for unknown object " + str);
        }
    }
}

