"use strict";

window.PrTask = {
    copyToClipboard(text) {
        return navigator.clipboard.writeText(text);
    },
    scrollToTop() {
        window.scrollTo({ top: 0, behavior: "smooth" });
    },
    getTimezoneOffset() {
        return new Date().getTimezoneOffset();
    }
};
