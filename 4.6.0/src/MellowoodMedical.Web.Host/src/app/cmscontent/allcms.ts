import { Component, Injector } from '@angular/core';
import { CMSServiceProxy, CMScontentDto, ListResultDtoOfCMScontentDto } from '../../shared/service-proxies/service-proxies';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { PagedListingComponentBase, PagedRequestDto } from "shared/paged-listing-component-base";
import { Router } from '@angular/router';

@Component({
    template: './allcms.component.html',
    animations: [appModuleAnimation()]
})
export class AllCmsComponent extends PagedListingComponentBase<CMScontentDto>{

    cmses: CMScontentDto[] = [];

    constructor(
        injector: Injector,
        private _router: Router,
        private _cmsService: CMSServiceProxy
    ) {
        super(injector);
    }

    protected list(request: PagedRequestDto, pageNumber: number, finishedCallback: Function): void {
        this.loadEvent();
        finishedCallback();
    }
    protected delete(entity: CMScontentDto): void {
        throw new Error("Method not implemented.");
    }

    loadEvent() {
        this._cmsService.getAll()
            .subscribe((result: ListResultDtoOfCMScontentDto) => {
                this.cmses = result.items;
            });
    }

    backToCmsPage() {
        this._router.navigate(['/app/cmscontent']);
    };

}