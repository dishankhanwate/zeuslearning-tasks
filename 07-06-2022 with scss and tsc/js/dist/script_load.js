"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
const body = document.querySelector("body");
const data_retrieving_script = () => {
    const data_retrieving_script = document.createElement("script");
    data_retrieving_script.src = "../js/dist/data_retrieving.js";
    data_retrieving_script.async = false;
    body.appendChild(data_retrieving_script);
};
const announcement_data = () => {
    const announcement_data = document.createElement("script");
    announcement_data.src = "../js/dist/data_retrieving_announcements.js";
    announcement_data.async = false;
    body.appendChild(announcement_data);
};
const alert_data = () => {
    const alert_data = document.createElement("script");
    alert_data.src = "../js/dist/data_retrieving_alerts.js";
    alert_data.async = false;
    body.appendChild(alert_data);
};
const script = () => {
    const script = document.createElement("script");
    script.src = "../js/dist/script.js";
    script.async = false;
    body.appendChild(script);
};
function asyncLlambda() {
    return __awaiter(this, void 0, void 0, function* () {
        const abc = yield data_retrieving_script();
        console.log(abc);
        yield announcement_data();
        script();
    });
}
;
asyncLlambda();
