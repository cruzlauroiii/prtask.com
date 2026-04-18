// ── PrTask Core — reusable JS functions for Blazor interop ──

(function () {
    var Saved = localStorage.getItem("prtask-theme");
    if (Saved === "light" || Saved === "dark") {
        document.documentElement.setAttribute("data-theme", Saved);
    }
})();

function prtaskToggleTheme() {
    var Current = document.documentElement.getAttribute("data-theme");
    if (!Current) {
        Current = window.matchMedia("(prefers-color-scheme: dark)").matches ? "dark" : "light";
    }
    var Next = Current === "dark" ? "light" : "dark";
    document.documentElement.setAttribute("data-theme", Next);
    localStorage.setItem("prtask-theme", Next);
    return Next;
}

function prtaskGetTheme() {
    var Saved = document.documentElement.getAttribute("data-theme");
    if (Saved) return Saved;
    return window.matchMedia("(prefers-color-scheme: dark)").matches ? "dark" : "light";
}

function prtaskToggleMenu() {
    var Links = document.querySelector(".nav-links");
    if (Links) { Links.classList.toggle("nav-open"); }
}

function prtaskCloseMenu() {
    var Links = document.querySelector(".nav-links");
    if (Links) { Links.classList.remove("nav-open"); }
}

document.addEventListener("click", function (E) {
    var Link = E.target.closest(".nav-links a");
    if (Link) {
        setTimeout(function () {
            var Links = document.querySelector(".nav-links");
            if (Links) { Links.classList.remove("nav-open"); }
        }, 50);
    }
});

function prtaskGetUser() {
    return localStorage.getItem("prtask-user") || "";
}

function prtaskSetUser(Name) {
    if (Name) { localStorage.setItem("prtask-user", Name); }
    else { localStorage.removeItem("prtask-user"); }
}

function prtaskGetUserId() {
    return localStorage.getItem("prtask-userid") || "";
}

function prtaskSetUserId(Id) {
    if (Id) { localStorage.setItem("prtask-userid", Id); }
    else { localStorage.removeItem("prtask-userid"); }
}

function prtaskCheckAuth() {
    var Cached = prtaskGetUser();
    if (Cached) { return Promise.resolve(Cached); }
    return fetch("/Api/Auth/Me", { credentials: "include" }).then(function (R) {
        if (R.ok) {
            return R.json().then(function (U) {
                var Name = U.username || U.Username || "";
                var Id = U.userId || U.UserId || "";
                if (Name) { prtaskSetUser(Name); }
                if (Id) {
                    prtaskSetUserId(Id);
                    return fetch("/Api/Users/" + encodeURIComponent(Id), { credentials: "include" }).then(function (Pr) {
                        if (Pr.ok) { return Pr.json().then(function (Profile) { prtaskSetUserProfile(Profile); return Name; }); }
                        return Name;
                    }).catch(function () { return Name; });
                }
                return Name;
            });
        }
        prtaskSetUser(null);
        prtaskSetUserId(null);
        return "";
    }).catch(function () { return ""; });
}

function prtaskSignOut() {
    return fetch("/Api/Auth/Logout", { method: "POST", credentials: "include" }).then(function () {
        prtaskSetUser(null);
        prtaskSetUserId(null);
        prtaskSetUserProfile(null);
        window.location.href = "/";
    }).catch(function () {
        prtaskSetUser(null);
        prtaskSetUserId(null);
        prtaskSetUserProfile(null);
        window.location.href = "/";
    });
}

function prtaskCheckNavWrap() {
    var Nav = document.querySelector(".nav-menu");
    if (!Nav) return;
    var Links = Nav.querySelector(".nav-links");
    if (!Links) return;
    var Clone = Links.cloneNode(true);
    Clone.style.cssText = "display:flex;flex-direction:row;flex-wrap:nowrap;position:absolute;visibility:hidden;top:-9999px;left:-9999px;width:auto;";
    Clone.classList.remove("nav-open");
    var LegalItems = Clone.querySelectorAll(".nav-legal");
    LegalItems.forEach(function (El) { El.remove(); });
    document.body.appendChild(Clone);
    var Brand = Nav.querySelector(".nav-brand");
    var BrandWidth = Brand ? Brand.offsetWidth + 48 : 0;
    var LinksWidth = Clone.scrollWidth;
    document.body.removeChild(Clone);
    if (LinksWidth + BrandWidth > Nav.clientWidth) {
        Nav.classList.add("nav-collapsed");
    } else {
        Nav.classList.remove("nav-collapsed");
    }
}

function prtaskGetLanguage() {
    return localStorage.getItem("prtask-language") || "en";
}

function prtaskSetLanguage(Lang) {
    if (Lang) { localStorage.setItem("prtask-language", Lang); }
    else { localStorage.removeItem("prtask-language"); }
}

function prtaskGetSessionToken() {
    return localStorage.getItem("prtask-session") || "";
}

function prtaskGetUserProfile() {
    return localStorage.getItem("prtask-profile") || null;
}

function prtaskSetUserProfile(Profile) {
    if (Profile) { localStorage.setItem("prtask-profile", JSON.stringify(Profile)); }
    else { localStorage.removeItem("prtask-profile"); }
}

function prtaskPauseSync() { }
function prtaskResumeSync() { }
function prtaskIsSyncPaused() { return false; }

function prtaskClearCache() {
    if (!("serviceWorker" in navigator)) { window.location.reload(); return; }
    navigator.serviceWorker.getRegistration().then(function (Reg) {
        if (!Reg) { window.location.reload(); return; }
        Reg.update().then(function () {
            if (Reg.waiting) {
                Reg.waiting.postMessage({ type: "SKIP_WAITING" });
            }
            var Refreshing = false;
            navigator.serviceWorker.addEventListener("controllerchange", function () {
                if (Refreshing) return;
                Refreshing = true;
                window.location.reload();
            });
            if (!Reg.waiting) {
                caches.keys().then(function (Names) {
                    return Promise.all(Names.map(function (N) { return caches.delete(N); }));
                }).then(function () {
                    window.location.reload();
                });
            }
        });
    });
}

window.addEventListener("load", prtaskCheckNavWrap);
window.addEventListener("resize", prtaskCheckNavWrap);
