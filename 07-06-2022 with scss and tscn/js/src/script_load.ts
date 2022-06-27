const body= document.querySelector("body") as HTMLBodyElement;


const data_retrieving_script = ()=>{
    const data_retrieving_script = document.createElement("script");
    data_retrieving_script.src = "../js/dist/data_retrieving.js";
    data_retrieving_script.async = false;
    body.appendChild(data_retrieving_script);
    }

const announcement_data = ()=>{
    const announcement_data = document.createElement("script");
    announcement_data.src = "../js/dist/data_retrieving_announcements.js";
    announcement_data.async = false;
    body.appendChild(announcement_data);
    }

const alert_data = ()=>{
    const alert_data = document.createElement("script");
    alert_data.src = "../js/dist/data_retrieving_alerts.js";
    alert_data.async = false;
    body.appendChild(alert_data);
    }

const script = ()=>{
    const script = document.createElement("script");
    script.src = "../js/dist/script.js";
    script.async = false;
    body.appendChild(script);
    }

async function asyncLlambda() {
    const abc =await data_retrieving_script();
    console.log(abc)
    await announcement_data(); 
    // await alert_data(); 
    script();


};

asyncLlambda();


