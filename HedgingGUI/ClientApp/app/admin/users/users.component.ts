import { Component, OnInit, ViewChild } from '@angular/core';
import { UserListViewModel, UserDto } from 'ClientApp/core/services/api.client.generated';
import { AdminService } from 'ClientApp/core/services/api.client.generated';
import { MatSort, MatTableDataSource } from '@angular/material';

@Component({
    selector: 'users',
    templateUrl: './users.component.html',
    styleUrls: ['./users.component.css']
})
/** users component*/
export class UsersComponent  implements OnInit {

    viewModel: UserListViewModel;
    users: MatTableDataSource<UserDto>;

    displayedColumns: string[] = ['firstName', 'lastName', 'team', 'actions'];

    @ViewChild(MatSort) sort: MatSort;

    /** users ctor */
    constructor(private service: AdminService) {}

    ngOnInit(): void {
        this.service.get().subscribe(result => {
            this.viewModel = result;
            this.users = new MatTableDataSource(result.users);
            this.users.sort = this.sort;
        }, error => console.error(error));
       
    }

    applyFilter(filterValue: string) {
        this.users.filter = filterValue.trim().toLowerCase();
    }
}