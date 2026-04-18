document.addEventListener("visibilitychange", function () {
    if (document.hidden) {
        if (typeof Blazor !== "undefined" && Blazor.pauseCircuit) Blazor.pauseCircuit();
    } else {
        if (typeof Blazor !== "undefined" && Blazor.resumeCircuit) Blazor.resumeCircuit();
    }
});
