export class Proxy {
  constructor() {
    this.APIBaseUrl = "https://localhost:5001/api/Data";
    this.url = "";
    this.Ticket = "";
    this.TicketMode = "header";
  }
  api(url) {
    return fetch(url).then((response) => {
      if (!response.ok) {
        throw new Error(response.statusText);
      }
      return response.json();
    });
  }
  apiPost(url, data) {
    return fetch(url, {
      method: "POST",
      mode: "cors",
      cache: "no-cache",
      credentials: "same-origin",
      headers: {
        "Content-Type": "application/json",
        ticket: this.Ticket,
      },
      referrerPolicy: "no-referrer",
      body: JSON.stringify(data),
    }).then((response) => {
      // //console.log(response)
      if (!response.ok) {
        alert(response.statusText);
        throw new Error(response.statusText);
      }
      return response.json();
    });
  }
  apiPostFiles(url, formData) {
    return fetch(url, {
      method: "POST",
      body: formData,
    }).then((response) => {
      if (!response.ok) {
        throw new Error(response.statusText);
        // alert(response.statusText);
      }
      return response.json();
    });
  }

  async Edit_Table(oTable, methodName) {
    // //console.log(oTable);
    this.url =
      this.APIBaseUrl +
      `/${methodName}?Ticket=` +
      (this.TicketMode === "url" ? this.Ticket : "");
    // //console.log(this.url)
    const result = await this.apiPost(this.url, oTable).then(async (resp) => {
      return resp;
    });
    return result;
  }

  async Delete_Table(oParamsDeleteTable, methodName) {
    this.url =
      this.APIBaseUrl +
      `/${methodName}?Ticket=` +
      (this.TicketMode === "url" ? this.Ticket : "");
    const result = await this.apiPost(this.url, oParamsDeleteTable).then(
      async (resp) => {
        return resp;
      }
    );
    return result;
  }
  async Get_Table(oParam, methodName) {
    // //console.log({ oParam, methodName })
    this.url =
      this.APIBaseUrl +
      `/${methodName}?Ticket=` +
      (this.TicketMode === "url" ? this.Ticket : "");
    // //console.log(this.url)
    const result = await this.apiPost(this.url, oParam).then(async (resp) => {
      // //console.log(resp);
      return resp;
    });
    // //console.log(result);
    return result;
  }
}

export class Param { }
