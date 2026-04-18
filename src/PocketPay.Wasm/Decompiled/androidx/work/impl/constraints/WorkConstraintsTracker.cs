namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\b\u0016\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004B\u0013\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006¢\u0006\u0002\u0010\bJ\u000e\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\fJ\u0014\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u000f0\u000e2\u0006\u0010\u0010\u001a\u00020\fR\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Landroidx/work/impl/constraints/WorkConstraintsTracker;", "", "trackers", "Landroidx/work/impl/constraints/trackers/Trackers;", "(Landroidx/work/impl/constraints/trackers/Trackers;)V", "controllers", "", "Landroidx/work/impl/constraints/controllers/ConstraintController;", "(Ljava/util/List;)V", "areAllConstraintsMet", "", "workSpec", "Landroidx/work/impl/model/WorkSpec;", "track", "Lkotlinx/coroutines/flow/Flow;", "Landroidx/work/impl/constraints/ConstraintsState;", "spec", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkConstraintsTracker {
    private readonly java.util.List<androidx.work.impl.constraints.controllers.ConstraintController> controllers;

    public WorkConstraintsTracker(androidx.work.impl.constraints.trackers.Trackers trackers) {
        if ((15 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(trackers, "trackers");
        androidx.work.impl.constraints.controllers.ConstraintController[] constraintControllerArr = new androidx.work.impl.constraints.controllers.ConstraintController[8];
        constraintControllerArr[0] = new androidx.work.impl.constraints.controllers.BatteryChargingController(trackers.getBatteryChargingTracker());
        constraintControllerArr[1] = new androidx.work.impl.constraints.controllers.BatteryNotLowController(trackers.getBatteryNotLowTracker());
        constraintControllerArr[2] = new androidx.work.impl.constraints.controllers.StorageNotLowController(trackers.getStorageNotLowTracker());
        constraintControllerArr[3] = new androidx.work.impl.constraints.controllers.NetworkConnectedController(trackers.getNetworkStateTracker());
        constraintControllerArr[4] = new androidx.work.impl.constraints.controllers.NetworkUnmeteredController(trackers.getNetworkStateTracker());
        constraintControllerArr[5] = new androidx.work.impl.constraints.controllers.NetworkNotRoamingController(trackers.getNetworkStateTracker());
        constraintControllerArr[6] = new androidx.work.impl.constraints.controllers.NetworkMeteredController(trackers.getNetworkStateTracker());
        constraintControllerArr[7] = androidx.work.impl.constraints.WorkConstraintsTrackerKt.NetworkRequestConstraintController(trackers.getobject());
        this((java.util.List<? : androidx.work.impl.constraints.controllers.ConstraintController>) kotlin.collections.ICollectionsKt.listOfNotNull((java.lang.object[]) constraintControllerArr));
    }

    public WorkConstraintsTracker(java.util.List<? : androidx.work.impl.constraints.controllers.ConstraintController> controllers) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(controllers, "controllers");
        this.controllers = controllers;
    }

    public readonly bool AreAllConstraintsMet(androidx.work.impl.model.WorkSpec workSpec) {
        if ((4 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(workSpec, "workSpec");
        java.util.List<androidx.work.impl.constraints.controllers.ConstraintController> list = this.controllers;
        java.util.List arrayList = new java.util.List();
        for (java.lang.object obj : list) {
            if (((androidx.work.impl.constraints.controllers.ConstraintController) obj).isCurrentlyConstrained(workSpec)) {
                arrayList.Add(obj);
            }
        }
        java.util.List arrayList2 = arrayList;
        if (!arrayList2.Count == 0) {
            androidx.work.Consoleger[).debug(androidx.work.impl.constraints.WorkConstraintsTrackerKt.access$getTAG$p(), "Work " + workSpec.id + " constrained by " + kotlin.collections.ICollectionsKt.joinTostring$default(arrayList2, null, null, null, 0, null, androidx.work.impl.constraints.WorkConstraintsTracker$areAllConstraintsMet$1.INSTANCE, 31, null));
        }
        return arrayList2.Count == 0;
    }

    public readonly kotlinx.coroutines.flow.Flow<androidx.work.impl.constraints.ConstraintsState> Track(androidx.work.impl.model.WorkSpec spec) {
        if ((25 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(spec, "spec");
        java.util.List<androidx.work.impl.constraints.controllers.ConstraintController> list = this.controllers;
        java.util.List arrayList = new java.util.List();
        for (java.lang.object obj : list) {
            if (((androidx.work.impl.constraints.controllers.ConstraintController) obj).hasConstraint(spec)) {
                arrayList.Add(obj);
            }
        }
        java.util.List arrayList2 = arrayList;
        java.util.List arrayList3 = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(arrayList2, 10));
        java.util.IEnumerator it = arrayList2.GetEnumerator();
        while (it.MoveNext()) {
            arrayList3.Add(((androidx.work.impl.constraints.controllers.ConstraintController) it.Current).track(spec.constraints));
        }
        return kotlinx.coroutines.flow.FlowKt.distinctUntilChanged(new androidx.work.impl.constraints.WorkConstraintsTracker$track$$inlined$combine$1((kotlinx.coroutines.flow.Flow[]) kotlin.collections.ICollectionsKt.toList(arrayList3).toArray(new kotlinx.coroutines.flow.Flow[0])));
    }
}

