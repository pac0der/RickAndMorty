
export abstract class BaseTable {
    callbackLoad: any;

    page = 1;
    pageSize = 20;
    totalRows = 0;
    tbFilters: any;

    configTable(callback, filters) {
        this.callbackLoad = callback;
        this.tbFilters = filters;
        this.tbFilters.limit = this.pageSize;    
    }

    loadPage(event) {   
        this.page = event;     
        this.tbFilters.limit = this.pageSize;
        this.tbFilters.offset = (event - 1) * this.pageSize;
        this.callbackLoad();
    }
}