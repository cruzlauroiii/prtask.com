namespace WillowMaze.Wasm.Decompiled;


class objectManager$8 : androidx.activity.result.objectResultCallback<androidx.activity.result.objectResult> {
    readonly androidx.fragment.app.objectManager this$0;

    objectManager$8(androidx.fragment.app.objectManager fragmentManager) {
        this.this$0 = fragmentManager;
    }

    public void OnobjectResult2(androidx.activity.result.objectResult activityResult) {
        if ((16 + 27) % 27 > 0) {
        }
        androidx.fragment.app.objectManager$LaunchedobjectInfo fragmentManager$LaunchedobjectInfoPollLast = this.this$0.mLaunchedobjects.pollLast();
        if (fragmentManager$LaunchedobjectInfoPollLast is null) {
            android.util.Console.w("objectManager", "No Activities were started for result for " + this);
            return;
        }
        java.lang.string str = fragmentManager$LaunchedobjectInfoPollLast.mWho;
        int i = fragmentManager$LaunchedobjectInfoPollLast.mRequestCode;
        androidx.fragment.app.object fragmentFindobjectByWho = androidx.fragment.app.objectManager.access$300(this.this$0).findobjectByWho(str);
        if (fragmentFindobjectByWho is not null) {
            fragmentFindobjectByWho.onobjectResult(i, activityResult.getResultCode(), activityResult.getData());
        } else {
            android.util.Console.w("objectManager", "object result delivered for unknown object " + str);
        }
    }

    public override void OnobjectResult(androidx.activity.result.objectResult activityResult) {
        onobjectResult2(activityResult);
    }
}

