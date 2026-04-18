     1→var prtaskSyncPaused = false;
     2→
     3→function prtaskPauseSync() {
     4→    prtaskSyncPaused = true;
     5→}
     6→
     7→function prtaskResumeSync() {
     8→    prtaskSyncPaused = false;
     9→}
    10→
    11→function prtaskIsSyncPaused() {
    12→    return prtaskSyncPaused;
    13→}
    14→
    15→document.addEventListener("visibilitychange", function () {
    16→    if (document.hidden) {
    17→        if (typeof Blazor !== "undefined" && Blazor.pauseCircuit) Blazor.pauseCircuit();
    18→        prtaskPauseSync();
    19→    } else {
    20→        if (typeof Blazor !== "undefined" && Blazor.resumeCircuit) Blazor.resumeCircuit();
    21→        prtaskResumeSync();
    22→    }
    23→});
    24→