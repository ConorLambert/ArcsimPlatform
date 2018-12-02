import { Component } from '@angular/core';
import { UserListViewModel } from 'ClientApp/core/services/api.client.generated';
import { AdminService } from 'ClientApp/core/services/api.client.generated';

@Component({
    selector: 'admin',
    templateUrl: './admin.component.html',
    styleUrls: ['./admin.component.css']
})
/** admin component*/
export class AdminComponent {
    vm: UserListViewModel;

    /** admin ctor */
    constructor(service: AdminService) {
        service.get().subscribe(result => {
            this.vm = result;
        }, error => console.error(error));
    }
}