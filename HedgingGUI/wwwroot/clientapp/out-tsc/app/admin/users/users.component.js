var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component } from '@angular/core';
import { AdminService } from 'ClientApp/core/services/api.client.generated';
var usersComponent = /** @class */ (function () {
    /** users ctor */
    function usersComponent(service) {
        var _this = this;
        service.get().subscribe(function (result) {
            _this.vm = result;
        }, function (error) { return console.error(error); });
    }
    usersComponent = __decorate([
        Component({
            selector: 'users',
            templateUrl: './users.component.html',
            styleUrls: ['./users.component.css']
        })
        /** users component*/
        ,
        __metadata("design:paramtypes", [AdminService])
    ], usersComponent);
    return usersComponent;
}());
export { usersComponent };
//# sourceMappingURL=users.component.js.map